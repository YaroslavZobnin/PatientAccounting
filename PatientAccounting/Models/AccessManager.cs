namespace PatientAccounting.Models
{
    internal static class AccessManager
    {
        public static bool CanView(string role, ViewListMode mode)
        {
            if (role == "Медицинский регистратор")
                return mode == ViewListMode.Patients || mode == ViewListMode.Doctors;
            if (role == "Главврач")
                return true;
            return false;
        }
        public static bool CanEdit(string role, ViewListMode mode)
        {
            if(role == "Медицинский регистратор")
                return mode == ViewListMode.Patients || mode == ViewListMode.Doctors;
            if(role == "Главврач")
                return mode == ViewListMode.Staff || mode == ViewListMode.Diseases;
            return false;
        }
    }
}
