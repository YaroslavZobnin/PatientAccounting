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
            try
            {
                MedicalHistoryDataGrid.DataSource = DataBaseProcessing.GetMedicalHistory(patient.PatientId);
                HideColumnIfExists(MedicalHistoryDataGrid,"medical_history_id");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить историю болезни: {ex.Message}",
                        "Ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HideColumnIfExists(DataGridView dgv, string columnName)
        {
            if (dgv.Columns.Contains(columnName))
            {
                dgv.Columns[columnName].Visible = false;
            }
        }
        private void MedicalHistoryDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if(MedicalHistoryDataGrid.SelectedRows.Count > 0)
            {
                int historyId = Convert.ToInt32(MedicalHistoryDataGrid.SelectedRows[0].Cells["medical_history_id"].Value);
                UpdateTreatmentTable(historyId);
                HideColumnIfExists(TreatmentDataGrid, "medicine_id");
            }
        }
        private void UpdateTreatmentTable(int historyId)
        {
            try
            {
                TreatmentDataGrid.DataSource = DataBaseProcessing.GetTreatmentByHistoryId(historyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить таблицу лечения: {ex.Message}",
                        "Ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
