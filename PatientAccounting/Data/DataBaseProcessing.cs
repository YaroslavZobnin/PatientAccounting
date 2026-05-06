using Npgsql;
using System.Configuration;
using BCrypt.Net;
using System.Data;
using PatientAccounting.Services;
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
