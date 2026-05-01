using Npgsql;
using System.Configuration;
using BCrypt.Net;
namespace PatientAccounting
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
                       p.patient_id, p.patient_surname, p.patient_name, p.patient_patronymic, p.patient_birth_date, p.patient_adress,
                       mw.medical_worker_id, mw.medical_worker_surname, mw.medical_worker_name, mw.medical_worker_patronymic, 
                       mw.specialization_id, mw.medical_worker_work_experience
                FROM Customer c
                JOIN User_role ur ON c.customer_role_id = ur.role_id
                LEFT JOIN Patient p ON c.customer_id = p.customer_id
                LEFT JOIN Medical_worker mw ON c.customer_id = mw.customer_id
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
    }
}
