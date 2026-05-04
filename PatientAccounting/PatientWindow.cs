namespace PatientAccounting
{
    public partial class PatientWindow : UserControl
    {
        private Patient patient;
        public PatientWindow(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            InitializeFullNameLabel();
            InitializePassportData();
            InitializeDateOfBirth();
            InitializeAddress();
            InitializeMedicalHistory();
        }
        private void InitializeFullNameLabel()
            => FullNameLabel.Text = string.Join(" ", patient.Surname, patient.Name, patient.Patronymic).Trim();
        private void InitializePassportData()
            => PasswordDataLabel.Text = $"Паспортные данные: {patient.PassportData}";
        private void InitializeDateOfBirth()
            => DateOfBirthLabel.Text = $"Дата рождения: {patient.DateOfBirth.ToShortDateString()}";
        private void InitializeAddress()
            => AddressLabel.Text = $"Место проживания: {patient.Address}";
        private void InitializeMedicalHistory()
            => MedicalHistoryDataGrid.DataSource = DataBaseProcessing.GetMedicalHistory(patient.PatientId);
    }
}
