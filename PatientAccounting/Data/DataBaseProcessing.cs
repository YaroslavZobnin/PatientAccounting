using Npgsql;
using System.Configuration;
using BCrypt.Net;
using System.Data;
using PatientAccounting.Services;
using System.Security.Cryptography;
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
        public static User? SearchUserInDataBase(string userLogin, string userPassword)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    const string sqlQuery = @"
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
                    using (var command = new NpgsqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("login", userLogin);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPass = reader.GetString(reader.GetOrdinal("customer_password"));
                                if (BCrypt.Net.BCrypt.Verify(userPassword, hashedPass))
                                {
                                    string roleName = reader.GetString(reader.GetOrdinal("role_name"));
                                    return UserFactory.Create(roleName, reader);
                                }
                                else return null;
                            }
                            else return null;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка базы данных: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }           
        }
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
            JOIN Staff_worker mw ON mh.staff_worker_id = sw.staff_worker_id
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
        public static bool RegisterStaff(string login, string password, string passport, int roleId,
            string surname, string name, string patronymic, int? specId, int experience)
        {
            using(var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    const string sqlCustomer = @"INSERT INTO Customer (customer_login, customer_password, customer_passport_data,
                    customer_role_id) VALUES(@login, @pass, @passport, @role)
                    RETURNING customer_id";
                    int newCustomerId;
                    using (var command = new NpgsqlCommand(sqlCustomer, connection))
                    {
                        command.Parameters.AddWithValue("login", login);
                        command.Parameters.AddWithValue("pass", BCrypt.Net.BCrypt.HashPassword(password));
                        command.Parameters.AddWithValue("passport", passport);
                        command.Parameters.AddWithValue("role", roleId);
                        newCustomerId = Convert.ToInt32(command.ExecuteScalar());
                    }
                    const string sqlStaff = @"
                INSERT INTO Staff_worker (staff_worker_surname, staff_worker_name, staff_worker_patronymic, 
                                        specialization_id, staff_worker_work_experience, customer_id) 
                VALUES (@surname, @name, @patronymic, @specId, @exp, @customerId)";
                    using (var cmd = new NpgsqlCommand(sqlStaff, connection))
                    {
                        cmd.Parameters.AddWithValue("surname", surname);
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("patronymic", patronymic);
                        cmd.Parameters.AddWithValue("specId", specId.HasValue ? (object)specId.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("exp", experience);
                        cmd.Parameters.AddWithValue("customerId", newCustomerId);
                        cmd.ExecuteNonQuery();
                    }
                    return true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка базы данных: {ex.Message}");
                    return false;
                }
            }
        }
        public static bool RegisterPatientSimple(string login, string password, string passport,
            string surname, string name, string patronymic, DateTime birthDate, string address)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    const string sqlCustomer = @"
                INSERT INTO Customer (customer_login, customer_password, customer_passport_data, customer_role_id) 
                VALUES (@login, @pass, @passport, 1) 
                RETURNING customer_id";
                    int newCustomerId;
                    using (var cmd = new NpgsqlCommand(sqlCustomer, connection))
                    {
                        cmd.Parameters.AddWithValue("login", login);
                        cmd.Parameters.AddWithValue("pass", BCrypt.Net.BCrypt.HashPassword(password));
                        cmd.Parameters.AddWithValue("passport", passport);
                        newCustomerId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
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
                        cmd.Parameters.AddWithValue("customerId", newCustomerId);

                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при регистрации пациента: {ex.Message}");
                    return false;
                }
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
                    MessageBox.Show($"Ошибка базы данных: {ex.Message}");
                }
            }
            return dataTable;
        }
    }
}
