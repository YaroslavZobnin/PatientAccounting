using System.Data.Common;
namespace PatientAccounting
{
    internal class MedicalWorker:User
    {
        public int MedicalWorkerId { get; init; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int SpecialtyCode { get; set; }
        public int WorkExperience { get; set; }
        public MedicalWorker(DbDataReader reader)
        {
            int idIndex = reader.GetOrdinal("customer_id");
            int loginIndex = reader.GetOrdinal("customer_login");
            int passportIndex = reader.GetOrdinal("customer_passport_data");
            int roleIndex = reader.GetOrdinal("role_id");
            int medicalWorkerIdIdIndex = reader.GetOrdinal("medical_worker_id");
            int surnameIndex = reader.GetOrdinal("medical_worker_surname");
            int nameIndex = reader.GetOrdinal("medical_worker_name");
            int patronymicIndex = reader.GetOrdinal("medical_worker_patronymic");
            int specializationIndex = reader.GetOrdinal("specialization_id");
            int workExperienceIndex = reader.GetOrdinal("medical_worker_work_experience");

            this.Id = reader.GetInt32(idIndex);
            this.Login = reader.GetString(loginIndex);
            this.PassportData = reader.GetString(passportIndex);
            this.Role = (UserRole)reader.GetInt32(roleIndex);
            this.MedicalWorkerId = reader.GetInt32(medicalWorkerIdIdIndex);
            this.Surname = reader.GetString(surnameIndex);
            this.Name = reader.GetString(nameIndex);
            this.Patronymic = reader.IsDBNull(patronymicIndex) ? "-" : reader.GetString(patronymicIndex);
            this.SpecialtyCode = reader.GetInt32(specializationIndex);
            this.WorkExperience = reader.GetInt32(workExperienceIndex);
        }
    }
}
