namespace PatientAccounting
{
    internal abstract class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string PassportData { get; set; }
        public UserRole Role { get; set; }
    }
}
