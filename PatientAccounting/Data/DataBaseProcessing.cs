using Npgsql;
using PatientAccounting.Services;
using System.Configuration;
using System.Data;
using System.Data.Common;
namespace PatientAccounting.Data
{
    internal static class DataBaseProcessing
    {
        private static string? connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString;
        public static NpgsqlConnection GetConnection()
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new Exception("Ошибка подключения базы данных");
            else return new NpgsqlConnection(connectionString);
        }
        private static DbDataReader? GetUserDataReader(string login, NpgsqlConnection connection)
        {
            const string sql = @"
                SELECT c.customer_id, c.customer_login, c.customer_password, c.customer_passport_data, 
                       ur.role_id, ur.role_name,
                       p.patient_id, p.patient_surname, p.patient_name, p.patient_patronymic, p.patient_birth_date, p.patient_address,
                       sw.staff_worker_id, sw.staff_worker_surname, sw.staff_worker_name, sw.staff_worker_patronymic, 
                       sw.specialization_id, sw.staff_worker_work_experience
                FROM Customer c
                JOIN User_role ur ON c.customer_role_id = ur.role_id
                LEFT JOIN Patient p ON c.customer_id = p.customer_id
                LEFT JOIN Staff_worker sw ON c.customer_id = sw.customer_id
                WHERE c.customer_login = @login"; 
            var command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("login", login);
            var reader = command.ExecuteReader();
            return reader.Read() ? reader : null;
        }
        public static User? Authenticate(string login, string password)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var reader = GetUserDataReader(login, conn);
                if (reader == null)
                    return null;
                if (!VerifyPassword(password, reader.GetString(reader.GetOrdinal("customer_password"))))
                    return null;
                return UserFactory.Create(reader.GetString(reader.GetOrdinal("role_name")), reader);
            }
        }
        private static bool VerifyPassword(string raw, string hashed) =>
            BCrypt.Net.BCrypt.Verify(raw, hashed);
        public static DataTable GetMedicalHistory(int patientId)
        {
            string sqlQuery = @"SELECT
                mh.medical_history_id,
                mh.date_of_receipt AS ""Дата поступления"",
                mh.date_of_discharge AS ""Дата выписки"",
                d.disease_name AS ""Диагноз"",
                sw.staff_worker_surname || ' ' || sw.staff_worker_name AS ""Врач"",
                w.number_ward AS ""Палата""
            FROM Medical_history mh
            JOIN Disease d ON mh.disease_id = d.disease_id
            JOIN Staff_worker sw ON mh.staff_worker_id = sw.staff_worker_id
            JOIN Ward w ON mh.ward_id = w.ward_id
            WHERE mh.patient_id=@patientId
            ORDER BY mh.date_of_receipt DESC";
            var arguments = new Dictionary<string, object> { { "@patientId", patientId} };
            return ExecuteQuery(sqlQuery, arguments);
        }
        public static DataTable GetTreatmentByHistoryId(int historyId)
        {
            string sqlQuery = @"SELECT 
                m.name_medicine AS ""Препарат"",
                tm.name_type_of_medicine AS ""Тип"",
                m.medicine_description AS ""Описание""
            FROM Treatment t
            JOIN Medicine m ON t.medicine_id = m.medicine_id
            JOIN Type_of_medicine tm ON m.type_of_medicine_id = tm.type_of_medicine_id
            WHERE t.medical_history_id = @historyId";
            var arguments = new Dictionary<string, object> { { "@historyId", historyId } };
            return ExecuteQuery(sqlQuery, arguments);
        }
        public static DataTable GetSpecializations()
        {
            string sqlQuery = "SELECT specialization_id, name_specialization " +
                "FROM Specialization ORDER BY name_specialization";
            return ExecuteQuery(sqlQuery, null);
        }
        private static int CreateCustomer(NpgsqlConnection connection, string login, string password, string passport, int roleId)
        {
            const string sql = @"
                INSERT INTO Customer (customer_login, customer_password, customer_passport_data, customer_role_id) 
                VALUES (@login, @pass, @passport, @role) 
                RETURNING customer_id";
            using (var cmd = new NpgsqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("login", login);
                cmd.Parameters.AddWithValue("pass", BCrypt.Net.BCrypt.HashPassword(password));
                cmd.Parameters.AddWithValue("passport", passport);
                cmd.Parameters.AddWithValue("role", roleId);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public static bool RegisterStaff(string login, string password, string passport, int roleId,
    string surname, string name, string patronymic, int? specId, int experience)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    int customerId = CreateCustomer(connection, login, password, passport, roleId);
                    const string sqlStaff = @"
                        INSERT INTO Staff_worker (staff_worker_surname, staff_worker_name, staff_worker_patronymic, 
                                                specialization_id, staff_worker_work_experience, customer_id) 
                        VALUES (@surname, @name, @patronymic, @specId, @exp, @customerId)";
                    using (var cmd = new NpgsqlCommand(sqlStaff, connection))
                    {
                        cmd.Parameters.AddWithValue("surname", surname);
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("patronymic", patronymic);
                        cmd.Parameters.AddWithValue("specId", specId.HasValue ? specId.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("exp", experience);
                        cmd.Parameters.AddWithValue("customerId", customerId);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось зарегистрировать сотрудника. Проверьте уникальность логина или паспорта.", ex);
            }
        }
        public static bool RegisterPatient(string login, string password, string passport,
    string surname, string name, string patronymic, DateTime birthDate, string address)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    int customerId = CreateCustomer(connection, login, password, passport, 1);
                    const string sqlPatient = @"
                        INSERT INTO Patient (patient_surname, patient_name, patient_patronymic, 
                                           patient_birth_date, patient_address, customer_id) 
                        VALUES (@surname, @name, @patronymic, @birth, @address, @customerId)";
                    using (var cmd = new NpgsqlCommand(sqlPatient, connection))
                    {
                        cmd.Parameters.AddWithValue("surname", surname);
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("patronymic", patronymic);
                        cmd.Parameters.AddWithValue("birth", birthDate);
                        cmd.Parameters.AddWithValue("address", address);
                        cmd.Parameters.AddWithValue("customerId", customerId);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось зарегистрировать пациента. Перепроверьте все данные", ex);
            }
        }
        public static void DeleteUserByPassport(string passportData)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                int? id = GetCustomerIdByPassport(passportData, connection);
                if (id == null)
                    throw new Exception("Пользователь с таким паспортом не зарегистрирован в системе.");
                DeleteUserDependencies(id.Value, connection);
            }
        }
        private static DataTable ExecuteQuery(string sql, Dictionary<string, object>? parameters)
        {
            var dataTable = new DataTable();
            using(var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using(var command = new NpgsqlCommand(sql, connection))
                    {
                        if(parameters != null)
                        {
                            foreach (var param in parameters)
                                command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                        using (var adapter = new NpgsqlDataAdapter(command))
                            adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка базы данных!", ex);
                }
            }
            return dataTable;
        }
        private static int? GetCustomerIdByPassport(string passport, NpgsqlConnection conn)
        {
            const string sql = "SELECT customer_id FROM Customer WHERE customer_passport_data = @p";
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("p", passport);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : null;
            }
        }
        private static void DeleteUserDependencies(int customerId, NpgsqlConnection conn)
        {
            string[] deleteQueries =
            {
            @"DELETE FROM Treatment WHERE medical_history_id IN (
                SELECT medical_history_id FROM Medical_history 
                WHERE patient_id = (SELECT patient_id FROM Patient WHERE customer_id = @id)
                OR staff_worker_id = (SELECT staff_worker_id FROM Staff_worker WHERE customer_id = @id)
            )",
            @"DELETE FROM Medical_history 
              WHERE patient_id = (SELECT patient_id FROM Patient WHERE customer_id = @id)
              OR staff_worker_id = (SELECT staff_worker_id FROM Staff_worker WHERE customer_id = @id)",
            "DELETE FROM Staff_worker WHERE customer_id = @id",
            "DELETE FROM Patient WHERE customer_id = @id",
            "DELETE FROM Customer WHERE customer_id = @id"
            };
            foreach (var sql in deleteQueries)
            {
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id", customerId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
