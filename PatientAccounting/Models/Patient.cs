using System.Data.Common;
namespace PatientAccounting.Services
{
    public class Patient:User
    {
        public int PatientId { get; init; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string? Patronymic {  get; set; }
        public DateTime DateOfBirth { get; init; }
        public string Address { get; set; }
        public Patient(DbDataReader reader) 
        {
            int idIndex = reader.GetOrdinal("customer_id");
            int loginIndex = reader.GetOrdinal("customer_login");
            int passportIndex = reader.GetOrdinal("customer_passport_data");
            int roleIndex = reader.GetOrdinal("role_id");
            int patientIdIndex = reader.GetOrdinal("patient_id");
            int surnameIndex = reader.GetOrdinal("patient_surname");
            int nameIndex = reader.GetOrdinal("patient_name");
            int patronymicIndex = reader.GetOrdinal("patient_patronymic");
            int birthIndex = reader.GetOrdinal("patient_birth_date");
            int addressIndex = reader.GetOrdinal("patient_address");

            Id = reader.GetInt32(idIndex);
            Login = reader.GetString(loginIndex);
            PassportData = reader.GetString(passportIndex);
            Role = (UserRole)reader.GetInt32(roleIndex);
            PatientId = reader.GetInt32(patientIdIndex);
            Surname = reader.GetString(surnameIndex);
            Name = reader.GetString(nameIndex);
            Patronymic = reader.IsDBNull(patronymicIndex) ? null : reader.GetString(patronymicIndex);
            DateOfBirth = reader.GetDateTime(birthIndex);
            Address = reader.GetString(addressIndex);
        }
    }
}
