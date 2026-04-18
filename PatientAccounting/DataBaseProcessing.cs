using Npgsql;
using System.Configuration;
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
        public static string? SearchUserInDataBase(string userLogin, string userPassword)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    string sqlQuery = "SELECT ur.role_name " +
                        "FROM Customer c " +
                        "JOIN User_role ur ON c.customer_role_id = ur.role_id " +
                        "WHERE c.customer_login=@login AND c.customer_password=@password";
                    using (var command = new NpgsqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("login", userLogin);
                        command.Parameters.AddWithValue("password", userPassword);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                                return reader.GetString(0);
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль");
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Серьёзная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
        }
    }
}
