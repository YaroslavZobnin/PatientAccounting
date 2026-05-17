using System.Data;
namespace PatientAccounting.Models
{
    internal static class ValidateTakenData
    {
        public static bool IsNeededRole(DataRow row, string neededRole)
        {
            if (row.Table.Columns.Contains("role_name"))
            {
                string? role = row["role_name"].ToString();
                if (role != neededRole)
                    throw new ArgumentException($"Паспортные данные не принадлежат ожидаемой роли.\nОжидалась роль: {neededRole}.");
                else return true;
            }
            else throw new Exception("Передаётся неправильный параметр DataRow.\nПерепроверьте, что вы передаёте правильную строку.");
        }
    }
}
