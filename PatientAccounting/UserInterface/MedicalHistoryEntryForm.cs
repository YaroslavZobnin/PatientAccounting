using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using PatientAccounting.Models;
namespace PatientAccounting.UserInterface
{
    public partial class MedicalHistoryEntryForm : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        private int _patientId;
        public MedicalHistoryEntryForm(int patientId, string patientFullName)
        {
            InitializeComponent();
            _patientId = patientId;
            PatientNameLabel.Text = $"Пациент: {patientFullName}";
            LoadComboBoxes();
            DateOfReceiptPicker.Value = DateTime.Now;
        }
        private void LoadComboBoxes()
        {
            DoctorComboBox.DataSource = DataBaseProcessing.GetListByMode(ViewListMode.Doctors);
            DoctorComboBox.DisplayMember = "Врач";
            DoctorComboBox.ValueMember = "ID";
            WardComboBox.DataSource = DataBaseProcessing.GetListByMode(ViewListMode.Wards);
            WardComboBox.DisplayMember = "№ Палаты";
            WardComboBox.ValueMember = "ID";
        }
        public bool ValidateData()
        {
            if (DoctorComboBox.SelectedValue == null || !int.TryParse(DoctorComboBox.SelectedValue.ToString(), out _))
            {
                MessageBox.Show("Пожалуйста, выберите лечащего врача из списка.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (WardComboBox.SelectedValue == null || !int.TryParse(WardComboBox.SelectedValue.ToString(), out _))
            {
                MessageBox.Show("Пожалуйста, выберите доступную палату.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void SaveProcess()
        {
            if (!ValidateData()) return;
            try
            {
                int doctorId = Convert.ToInt32(DoctorComboBox.SelectedValue);
                int wardId = Convert.ToInt32(WardComboBox.SelectedValue);
                DateTime dateReceipt = DateOfReceiptPicker.Value;
                if (DataBaseProcessing.InsertMedicalHistory(_patientId, doctorId, wardId, dateReceipt))
                {
                    MessageBox.Show("История болезни успешно создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ExitToMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ExitToMenu() => OnClosed?.Invoke();
        private void SaveButton_Click(object sender, EventArgs e) => SaveProcess();

    }
}
