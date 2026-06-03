using System.Data;

namespace PatientAccounting.Models
{
    internal static class GeneralMethods
    {
        public static string GetFullName(User? user)
        {
            if (user is Patient patient)
                return string.Join(" ", patient.Surname, patient.Name, patient.Patronymic).Trim();
            else if (user is Staff staff)
                return string.Join(" ", staff.Surname, staff.Name, staff.Patronymic).Trim();
            else if (user == null)
                return string.Empty;
            else throw new ArgumentException("Выход за предел допустимых ролей");
        }
        public static string GetAnyInfo(string firstComms, string addInfo) => $"{firstComms}{addInfo}";
        public static string GetPatientFullName(DataRow row)
        {
            if (row.Table.Columns.Contains("ФИО"))
                return row["ФИО"].ToString();

            string surname = "";
            if (row.Table.Columns.Contains("Фамилия")) 
                surname = row["Фамилия"].ToString();

            string name = "";
            if (row.Table.Columns.Contains("Имя")) 
                name = row["Имя"].ToString();

            string patronymic = "";
            if (row.Table.Columns.Contains("Отчество")) 
                patronymic = row["Отчество"].ToString();

            string fullName = $"{surname} {name} {patronymic}".Trim();
            if (string.IsNullOrWhiteSpace(fullName))
                return "Неизвестный Пациент (Ошибка колонок БД)";

            return fullName;
        }
    }
}
