using System.Data;

namespace PatientAccounting.Services
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
            string name = row["patient_surname"].ToString() + ' ' 
                + row["patient_name"].ToString() + ' ' 
                + row["patient_patronymic"].ToString();
            return name.Trim();
        }
    }
}
