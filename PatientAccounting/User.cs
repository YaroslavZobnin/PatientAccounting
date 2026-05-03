namespace PatientAccounting
{
    public abstract class User
    {
        public int Id { get; init; }
        public string Login { get; set; }
        public string PassportData { get; init; }
        public UserRole Role { get; init; }
    }
}
