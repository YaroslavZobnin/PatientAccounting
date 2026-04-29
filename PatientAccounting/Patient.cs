using System.Data.Common;
namespace PatientAccounting
{
    internal class Patient:User
    {
        public int PatientId { get; init; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string? Patronymic {  get; set; }
        public DateTime YearOfBirth { get; init; }
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

            this.Id = reader.GetInt32(idIndex);
            this.Login = reader.GetString(loginIndex);
            this.PassportData = reader.GetString(passportIndex);
            this.Role = (UserRole)reader.GetInt32(roleIndex);
            this.PatientId = reader.GetInt32(patientIdIndex);
            this.Surname = reader.GetString(surnameIndex);
            this.Name = reader.GetString(nameIndex);
            this.Patronymic = reader.IsDBNull(patronymicIndex) ? "-" : reader.GetString(patronymicIndex);
            this.YearOfBirth = reader.GetDateTime(birthIndex);
            this.Address = reader.GetString(addressIndex);
        }
    }
}
