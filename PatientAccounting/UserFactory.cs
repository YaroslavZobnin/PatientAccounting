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
                "Медицинский регистратор" => new Staff(reader),
                "Лечащий врач" => new Staff(reader),
                "Главврач" => new Staff(reader),
                "Системный администратор" => new Staff(reader),
                _ => throw new NotSupportedException($"Роль {roleName} отсутствует в данном приложении.")
            };
        }
    }
}
