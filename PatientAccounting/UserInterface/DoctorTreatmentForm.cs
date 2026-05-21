using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using PatientAccounting.Models;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class DoctorTreatmentForm : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        private readonly int _medicalHistoryId;
        private bool _isReadOnly;
        public DoctorTreatmentForm(int medicalHistoryId, bool isReadOnly)
        {
            InitializeComponent();
            _medicalHistoryId = medicalHistoryId;
            _isReadOnly = isReadOnly;
            LoadMedicalDirectories();
            LoadCurrentHistoryData();
            if (_isReadOnly)
                ApplyReadOnlyMode();
        }
        private void ApplyReadOnlyMode()
        {
            //// 1. Прячем или отключаем кнопки сохранения/добавления данных
            //SaveButton.Visible = false;
            //AddAppointmentButton.Visible = false;
            //DeleteButton.Visible = false;

            //// 2. Блокируем выпадающие списки и текстовые поля (врач может смотреть, но не менять)
            //DiseaseComboBox.Enabled = false;
            //WardComboBox.Enabled = false;
            //ComplaintsTextBox.ReadOnly = true;

            //// Если назначения выводятся в DataGridView, запрещаем их редактировать
            //AppointmentsGrid.ReadOnly = true;
            //AppointmentsGrid.AllowUserToAddRows = false;
            //AppointmentsGrid.AllowUserToDeleteRows = false;

            //// 3. Кнопки навигации оставляем КОРРЕКТНО работать
            //BackButton.Enabled = true;  // Вернуться назад к списку карт
            //MenuButton.Enabled = true;  // Выйти в главное меню

            SettingReadOnlyModeForComboBox(DiseaseComboBox, true);
            SettingReadOnlyModeForComboBox(TreatmentComboBox, true);
            SettingReadOnlyModeForComboBox(WardsComboBox, true);
        }
        private void SettingReadOnlyModeForComboBox(ComboBox cb, bool readOnly) => cb.Enabled = readOnly;
        private void LoadMedicalDirectories()
        {
            try
            {
                DiseaseComboBox.DisplayMember = "Название болезни";
                DiseaseComboBox.ValueMember = "ID";
                DiseaseComboBox.DataSource = DataBaseProcessing.GetListByMode(ViewListMode.Diseases);
                DiseaseComboBox.SelectedIndex = -1;

                TreatmentComboBox.DisplayMember = "Название препарата";
                TreatmentComboBox.ValueMember = "ID";
                TreatmentComboBox.DataSource = DataBaseProcessing.GetListByMode(ViewListMode.Treatments);
                TreatmentComboBox.SelectedIndex = -1;

                WardsComboBox.MaxDropDownItems = 8;
                WardsComboBox.IntegralHeight = true;
                WardsComboBox.DisplayMember = "№ Палаты";
                WardsComboBox.ValueMember = "ID";
                WardsComboBox.DataSource = DataBaseProcessing.GetListByMode(ViewListMode.Wards);
                WardsComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке медицинских справочников: {ex.Message}",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCurrentHistoryData()
        {
            try
            {
                DataRow? historyRow = DataBaseProcessing.GetMedicalHistoryDetails(_medicalHistoryId);
                if (historyRow != null)
                {
                    DateOnly receiptDate = (DateOnly)historyRow["date_of_receipt"];

                    DateOfReceipt.Value = receiptDate.ToDateTime(TimeOnly.MinValue);
                    if (historyRow["ward_id"] != DBNull.Value)
                        WardsComboBox.SelectedValue = Convert.ToInt32(historyRow["ward_id"]);

                    if (historyRow["disease_id"] != DBNull.Value)
                        DiseaseComboBox.SelectedValue = Convert.ToInt32(historyRow["disease_id"]);

                    if (historyRow["treatment_id"] != DBNull.Value)
                        TreatmentComboBox.SelectedValue = Convert.ToInt32(historyRow["treatment_id"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных регистратора: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (DiseaseComboBox.SelectedIndex == -1 || TreatmentComboBox.SelectedIndex == -1 || WardsComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите и диагноз, и курс лечения для пациента!",
                                "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DiseaseComboBox.SelectedValue == null ||
                TreatmentComboBox.SelectedValue == null ||
                WardsComboBox.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, убедитесь, что выбраны все поля: диагноз, лечение и палата!",
                                "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int diseaseId = Convert.ToInt32(DiseaseComboBox.SelectedValue);
                int treatmentId = Convert.ToInt32(TreatmentComboBox.SelectedValue);
                int wardId = Convert.ToInt32(WardsComboBox.SelectedValue);
                DataBaseProcessing.UpdateMedicalHistory(_medicalHistoryId, diseaseId, treatmentId, wardId);
                MessageBox.Show("Назначения успешно сохранены в историю болезни пациента!",
                                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnClosed?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении назначений в базу данных: {ex.ToString()}",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            OnClosed?.Invoke();
        }
    }
}
