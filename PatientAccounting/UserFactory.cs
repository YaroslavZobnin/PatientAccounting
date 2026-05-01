using System.Data.Common;
namespace PatientAccounting
{
    internal static class UserFactory
    {
        public static User Create(string roleName, DbDataReader reader)
        {
            return roleName switch
            {
                "Пациент" => new Patient(reader),
                "Медицинский регистратор" => new MedicalWorker(reader),
                "Лечащий врач" => new MedicalWorker(reader),
                "Главврач" => new MedicalWorker(reader),
                "Системный администратор" => new MedicalWorker(reader),
                _ => throw new NotSupportedException($"Роль {roleName} отсутствует в данном приложении.")
            };
        }
    }
}
