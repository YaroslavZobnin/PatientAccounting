using PatientAccounting.Data;
using PatientAccounting.Services;
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
            => FullNameLabel.Text = GeneralMethods.GetFullName(patient);
        private void InitializePassportData()
            => PasswordDataLabel.Text = GeneralMethods.GetAnyInfo("Паспортные данные: ", patient.PassportData);
        private void InitializeDateOfBirth()
            => DateOfBirthLabel.Text = GeneralMethods.GetAnyInfo("Дата рождения: ", patient.DateOfBirth.ToShortDateString());
        private void InitializeAddress()
            => AddressLabel.Text = GeneralMethods.GetAnyInfo("Место проживания: ", patient.Address);
        private void InitializeMedicalHistory()
        {
            MedicalHistoryDataGrid.DataSource = DataBaseProcessing.GetMedicalHistory(patient.PatientId);
            if (MedicalHistoryDataGrid.Columns.Contains("medical_history_id"))
                MedicalHistoryDataGrid.Columns["medical_history_id"].Visible = false;
        }
        private void MedicalHistoryDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if(MedicalHistoryDataGrid.SelectedRows.Count > 0)
            {
                int historyId = Convert.ToInt32(MedicalHistoryDataGrid.SelectedRows[0].Cells["medical_history_id"].Value);
                UpdateTreatmentTable(historyId);
            }
        }
        private void UpdateTreatmentTable(int historyId)
            => TreatmentDataGrid.DataSource = DataBaseProcessing.GetTreatmentByHistoryId(historyId);
    }
}
