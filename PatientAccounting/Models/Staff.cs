using System.Data.Common;
namespace PatientAccounting.Services
{
    public class Staff:User
    {
        public int StaffId { get; init; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int SpecialtyCode { get; set; }
        public int WorkExperience { get; set; }
        public Staff(DbDataReader reader)
        {
            int idIndex = reader.GetOrdinal("customer_id");
            int loginIndex = reader.GetOrdinal("customer_login");
            int passportIndex = reader.GetOrdinal("customer_passport_data");
            int roleIndex = reader.GetOrdinal("role_id");
            int staffWorkerIdIdIndex = reader.GetOrdinal("medical_worker_id");
            int surnameIndex = reader.GetOrdinal("medical_worker_surname");
            int nameIndex = reader.GetOrdinal("medical_worker_name");
            int patronymicIndex = reader.GetOrdinal("medical_worker_patronymic");
            int specializationIndex = reader.GetOrdinal("specialization_id");
            int workExperienceIndex = reader.GetOrdinal("medical_worker_work_experience");

            Id = reader.GetInt32(idIndex);
            Login = reader.GetString(loginIndex);
            PassportData = reader.GetString(passportIndex);
            Role = (UserRole)reader.GetInt32(roleIndex);
            StaffId = reader.GetInt32(staffWorkerIdIdIndex);
            Surname = reader.GetString(surnameIndex);
            Name = reader.GetString(nameIndex);
            Patronymic = reader.IsDBNull(patronymicIndex) ? "-" : reader.GetString(patronymicIndex);
            SpecialtyCode = reader.GetInt32(specializationIndex);
            WorkExperience = reader.GetInt32(workExperienceIndex);
        }
    }
}
