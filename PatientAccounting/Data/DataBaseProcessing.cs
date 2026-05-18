using Npgsql;
using PatientAccounting.Models;
using PatientAccounting.Services;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Net;
using System.Windows.Forms;
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
        public static DataTable GetRole()
        {
            string sqlQuery = "SELECT role_id, role_name FROM User_role";
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
        private static void PrepareParameters(NpgsqlCommand command, Dictionary<string, object>? parameters)
        {
            if (parameters == null) return;
            foreach (var param in parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            }
        }
        private static DataTable ExecuteQuery(string sql, Dictionary<string, object>? parameters)
        {
            try
            {
                var dataTable = new DataTable();
                using var connection = GetConnection();
                connection.Open();
                using var command = new NpgsqlCommand(sql, connection);
                PrepareParameters(command, parameters);
                using var adapter = new NpgsqlDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при чтении из БД", ex);
            }
        }
        private static void ExecuteNonQuery(string sql, Dictionary<string, object>? parameters)
        {
            try
            {
                using var connection = GetConnection();
                connection.Open();
                using var command = new NpgsqlCommand(sql, connection);
                PrepareParameters(command, parameters);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при записи в БД", ex);
            }
        }
        private static int? GetCustomerIdByPassport(string passport, NpgsqlConnection connection)
        {
            const string sql = "SELECT customer_id FROM Customer WHERE customer_passport_data = @p";
            using (var cmd = new NpgsqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("p", passport);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : null;
            }
        }
        private static void DeleteUserDependencies(int customerId, NpgsqlConnection connection)
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
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("id", customerId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateCustomerBase(int id, string login, string passport)
        {
            const string sql = "UPDATE Customer SET customer_login = @l, customer_passport_data = @p WHERE customer_id = @id";
            ExecuteNonQuery(sql, new Dictionary<string, object> { { "l", login }, { "p", passport }, { "id", id } });
        }

        public static void UpdatePatientDetails(int id, string s, string n, string? p, DateTime birth, string addr)
        {
            const string sql = "UPDATE Patient SET patient_surname=@s, patient_name=@n, patient_patronymic=@p, patient_birth_date=@b, patient_address=@a WHERE customer_id=@id";
            ExecuteNonQuery(sql, new Dictionary<string, object> { { "s", s }, { "n", n }, { "p", p }, { "b", birth }, { "a", addr }, { "id", id } });
        }

        public static void UpdateStaffDetails(int id, string s, string n, string? p, object? spec, int exp)
        {
            const string sql = "UPDATE Staff_worker SET staff_worker_surname=@s, staff_worker_name=@n, staff_worker_patronymic=@p, specialization_id=@spec, staff_worker_work_experience=@exp WHERE customer_id=@id";
            ExecuteNonQuery(sql, new Dictionary<string, object> { { "s", s }, { "n", n }, { "p", p }, { "spec", spec }, { "exp", exp }, { "id", id } });
        }
        public static DataTable GetUserByPassport(string passport)
        {
            const string sql = @"
            SELECT c.*, ur.role_name,
                   p.patient_id, p.patient_surname, p.patient_name, p.patient_patronymic, p.patient_birth_date, p.patient_address,
                   sw.staff_worker_surname, sw.staff_worker_name, sw.staff_worker_patronymic, 
                   sw.specialization_id, sw.staff_worker_work_experience
            FROM Customer c
            JOIN User_role ur ON c.customer_role_id = ur.role_id
            LEFT JOIN Patient p ON c.customer_id = p.customer_id
            LEFT JOIN Staff_worker sw ON c.customer_id = sw.customer_id
            WHERE c.customer_passport_data = @p";
            var args = new Dictionary<string, object> { { "p", passport } };
            return ExecuteQuery(sql, args);
        }
        public static DataTable GetListByMode(ViewListMode mode)
        {
            return mode switch
            {
                ViewListMode.Patients => GetAllPatients(),
                ViewListMode.Doctors => GetAllDoctors(),
                ViewListMode.Staff => GetAllStaff(),
                ViewListMode.MedicalStaff => GetAllMedicalStaff(),
                ViewListMode.Wards => GetAllWards(),
                ViewListMode.Diseases => GetAllDiseases(),
                ViewListMode.Treatments => GetAllTreatments(),
                _ => throw new ArgumentOutOfRangeException("Данного режима не существует")
            };
        }
        private static DataTable GetAllStaff()
        {
            const string sql = "SELECT " +
                "sw.staff_worker_id AS \"ID\"," +
                "sw.staff_worker_surname AS \"Фамилия\"," +
                "sw.staff_worker_name AS \"Имя\"," +
                "spec.name_specialization AS \"Специализация\"," +
                "ur.role_name AS \"Должность\"," +
                "sw.staff_worker_work_experience AS \"Стаж (лет)\" " +
                "FROM Staff_worker sw " +
                "JOIN Specialization spec ON sw.specialization_id = spec.specialization_id " +
                "JOIN Customer c ON sw.customer_id = c.customer_id " +
                "JOIN User_role ur ON c.customer_role_id = ur.role_id " +
                "ORDER BY ur.role_name, sw.staff_worker_surname";
            return ExecuteQuery(sql, null);
        }
        private static DataTable GetAllDoctors()
        {
            const string sql = "SELECT " +
                "sw.staff_worker_id AS \"ID\"," +
                "sw.staff_worker_surname || ' ' || sw.staff_worker_name || ' ' || sw.staff_worker_patronymic AS \"Врач\"," +
                "spec.name_specialization AS \"Специализация\"," +
                "sw.staff_worker_work_experience AS \"Стаж\" " +
                "FROM Staff_worker sw " +
                "JOIN Specialization spec ON sw.specialization_id = spec.specialization_id " +
                "JOIN Customer c ON sw.customer_id = c.customer_id " +
                "WHERE c.customer_role_id IN (3) " +
                "ORDER BY sw.staff_worker_surname";
            return ExecuteQuery(sql, null);
        }
        private static DataTable GetAllPatients()
        {
            const string sql = @"SELECT 
                  patient_id AS ""ID"",
                  patient_surname || ' ' || patient_name || ' ' || patient_patronymic AS ""ФИО"",
                  patient_birth_date AS ""Дата рождения"",
                  patient_address AS ""Адрес"",
                  CAST('Пациент' AS text) AS ""role_name""
                  FROM Patient
                  ORDER BY patient_surname;";
            return ExecuteQuery(sql, null);
        }
        private static DataTable GetAllMedicalStaff()
        {
            const string sql = "SELECT " +
                "sw.staff_worker_id AS \"ID\"," +
                "sw.staff_worker_surname || ' ' || sw.staff_worker_name || ' ' || sw.staff_worker_patronymic AS \"Врач\"," +
                "spec.name_specialization AS \"Специализация\"," +
                "sw.staff_worker_work_experience AS \"Стаж\" " +
                "FROM Staff_worker sw " +
                "JOIN Specialization spec ON sw.specialization_id = spec.specialization_id " +
                "JOIN Customer c ON sw.customer_id = c.customer_id " +
                "JOIN User_role ur ON c.customer_role_id = ur.role_id " +
                "WHERE c.customer_role_id IN (3, 4) " +
                "ORDER BY sw.staff_worker_surname";
            return ExecuteQuery(sql, null);
        }
        private static DataTable GetAllWards()
        {
            const string sql = "SELECT " +
                "w.ward_id AS \"ID\"," +
                "w.number_ward AS \"№ Палаты\"," +
                "d.name_department AS \"Отделение\"," +
                "tw.name_type_of_ward AS \"Тип палаты\"," +
                "w.capacity AS \"Вместимость\" " +
                "FROM Ward w " +
                "JOIN Department d ON w.department_id = d.department_id " +
                "JOIN Type_of_ward tw ON w.type_of_ward_id = tw.type_of_ward_id " +
                "ORDER BY d.name_department, w.number_ward;";
            return ExecuteQuery(sql, null);
        }
        private static DataTable GetAllDiseases()
        {
            const string sql = "SELECT " +
                "d.disease_id AS \"ID\"," +
                "d.disease_name AS \"Название болезни\"," +
                "c.category_name AS \"Категория\"," +
                "d.treatment_duration AS \"Срок лечения (дн.)\" " +
                "FROM Disease d " +
                "JOIN Category c ON d.category_id = c.category_id " +
                "ORDER BY c.category_name, d.disease_name;";
            return ExecuteQuery(sql, null);
        }
        private static DataTable GetAllTreatments()
        {
            const string sql = "SELECT " +
                "m.medicine_id AS \"ID\"," +
                "m.name_medicine AS \"Название препарата\"," +
                "tm.name_type_of_medicine AS \"Тип\"," +
                "m.medicine_description AS \"Описание\" " +
                "FROM Medicine m " +
                "JOIN Type_of_medicine tm ON m.type_of_medicine_id = tm.type_of_medicine_id " +
                "ORDER BY tm.name_type_of_medicine, m.name_medicine;";
            return ExecuteQuery(sql, null);
        }
        public static DataTable GetPatientsWithoutDischarge()
        {
            const string sql = "SELECT " +
                "mh.medical_history_id AS \"ID\"," +
                "p.patient_surname || ' ' || p.patient_name || ' ' || p.patient_patronymic AS \"ФИО Пациента\"," +
                "d.disease_name AS \"Диагноз\"," +
                "w.number_ward AS \"Палата\"," +
                "mh.date_of_receipt AS \"Дата поступления\" " +
                "FROM Medical_history mh " +
                "JOIN Patient p ON mh.patient_id = p.patient_id " +
                "JOIN Disease d ON mh.disease_id = d.disease_id " +
                "JOIN Ward w ON mh.ward_id = w.ward_id " +
                "WHERE mh.date_of_discharge IS NULL -- Только те, кто еще лечится " +
                "ORDER BY mh.date_of_receipt";
            return ExecuteQuery(sql, null);
        }
        public static bool DischargePatient(int medicalHistoryId)
        {
            const string sql = "UPDATE Medical_history SET date_of_discharge = CURRENT_DATE WHERE medical_history_id = @id";
            var args = new Dictionary<string, object> { { "id", medicalHistoryId } };
            try
            {
                ExecuteNonQuery(sql, args);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выписке: {ex.Message}");
                return false;
            }
        }
        public static bool InsertMedicalHistory(int patientId, int staffWorkerId, int wardId, DateTime dateOfReceipt)
        {
            const string sql = @"
                 INSERT INTO Medical_history (patient_id, staff_worker_id, ward_id, date_of_receipt) 
                 VALUES (@patientId, @staffId, @wardId, @dateReceipt)";
            var args = new Dictionary<string, object>
            {
                    { "patientId", patientId },{ "staffId", staffWorkerId },{ "wardId", wardId },{ "dateReceipt", dateOfReceipt }
            };
            try
            {
                ExecuteNonQuery(sql, args);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось создать запись истории болезни в базе данных.", ex);
            }
        }
        public static DataTable GetAvailableWards()
        {
            const string sql = @"SELECT 
                    w.ward_id AS ""ID"",
                    'Палата №' || w.number_ward || ' (Свободно мест: ' || (w.capacity - COUNT(mh.patient_id)) || ')' AS ""№ Палаты""
                    FROM Ward w
                    LEFT JOIN Medical_history mh ON w.ward_id = mh.ward_id AND mh.date_of_discharge IS NULL
                    GROUP BY w.ward_id, w.number_ward, w.capacity
                    HAVING COUNT(mh.patient_id) < w.capacity
                    ORDER BY w.number_ward;";
            try
            {
                return ExecuteQuery(sql, null);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при получении списка свободных палат", ex);
            }
        }
        public static DataTable GetActiveHistoriesByPatient(int patientId)
        {
            const string sql = @"SELECT 
                        mh.medical_history_id AS ""ID"",
                        mh.date_of_receipt AS ""Дата поступления"",
                        w.number_ward AS ""Палата"",
                        d.staff_worker_surname || ' ' || d.staff_worker_surname || ' ' || d.staff_worker_patronymic AS ""Врач""
                    FROM Medical_history mh
                    JOIN Ward w ON mh.ward_id = w.ward_id
                    JOIN Staff_worker d ON mh.staff_worker_id = d.staff_worker_id
                    WHERE mh.patient_id = @patientId AND mh.date_of_discharge IS NULL
                    ORDER BY mh.date_of_receipt DESC;";
            var args = new Dictionary<string, object> { { "patientId", patientId } };
            return ExecuteQuery(sql, args);
        }
        public static DataTable GetPastHistoriesByPatient(int patientId)
        {
            const string sql = @"SELECT 
                        mh.date_of_receipt AS ""Поступление"",
                        mh.date_of_discharge AS ""Выписка"",
                        dis.disease_name AS ""Диагноз"",
                        m.name_medicine AS ""Лечение""
                    FROM Medical_history mh
                    LEFT JOIN Disease dis ON mh.disease_id = dis.disease_id
                    LEFT JOIN Treatment t ON mh.medical_history_id = t.medical_history_id
                    LEFT JOIN Medicine m ON t.medicine_id = m.medicine_id
                    WHERE mh.patient_id = @patientId AND mh.date_of_discharge IS NOT NULL
                    ORDER BY mh.date_of_discharge DESC";
            var args = new Dictionary<string, object> { { "patientId", patientId } };
            return ExecuteQuery(sql, args);
        }
        public static void UpdateMedicalHistory(int historyId, int diseaseId, int treatmentId, int wardId)
        {
            const string sql = @"UPDATE Medical_history 
                    SET disease_id = @diseaseId, 
                        treatment_id = @treatmentId,
                        ward_id = @wardId
                    WHERE medical_history_id = @historyId;";

            var args = new Dictionary<string, object>
            {
                { "historyId", historyId },
                { "diseaseId", diseaseId },
                { "treatmentId", treatmentId },
                { "wardId", wardId }
            };
            ExecuteNonQuery(sql, args);
        }
        public static DataRow? GetMedicalHistoryDetails(int historyId)
        {
            const string sql = @"SELECT ward_id, date_of_receipt
                    FROM Medical_history 
                    WHERE medical_history_id = @historyId;";
            var args = new Dictionary<string, object> { { "historyId", historyId } };
            DataTable dataTable = ExecuteQuery(sql, args);
            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
        }
    }
}
