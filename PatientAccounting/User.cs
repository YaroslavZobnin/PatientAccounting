namespace PatientAccounting
{
    internal abstract class User
    {
        public required int Id { get; init; }
        public required string Login { get; set; }
        public required string PassportData { get; init; }
        public required UserRole Role { get; init; }
    }
}
