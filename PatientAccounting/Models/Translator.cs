namespace PatientAccounting.Models
{
    internal static class Translator
    {
        public static string TranslateRole(ViewListMode mode)
        {
            return mode switch
            {
                ViewListMode.Patients => "patient",
                ViewListMode.Doctors => "staff_worker",
                ViewListMode.Staff => "staff_worker",
                ViewListMode.MedicalStaff => "staff_worker",
                _ => throw new ArgumentException("Ошибка перевода роли.")
            };
        }
    }
}
