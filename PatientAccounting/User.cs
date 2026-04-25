namespace PatientAccounting
{
    internal abstract class User
    {
        public int Id { get; set; }
        public required string Login { get; set; }
        public required string PassportData { get; set; }
        public UserRole Role { get; set; }
    }
}
