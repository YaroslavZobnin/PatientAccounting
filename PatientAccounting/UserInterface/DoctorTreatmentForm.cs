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
        private DataTable _treatmentsTable;
        private HashSet<int> _assignedMedicineIds = new HashSet<int>();
        public DoctorTreatmentForm(int medicalHistoryId, bool isReadOnly)
        {
            InitializeComponent();
            _medicalHistoryId = medicalHistoryId;
            _isReadOnly = isReadOnly;
            LoadMedicalDirectories();
            LoadCurrentHistoryData();
            LoadTreatmentsTable();
            if (_isReadOnly)
                ApplyReadOnlyMode();
        }
        private void ApplyReadOnlyMode()
        {
            SettingReadOnlyModeForComboBox(DiseaseComboBox, true);
            SettingReadOnlyModeForComboBox(WardsComboBox, true);
            SetButtonState(SaveButton, false);
            SetPanelState(ChoiceTreatmentPanel, false);
        }
        private void SettingReadOnlyModeForComboBox(ComboBox cb, bool readOnly) => cb.Enabled = !readOnly;
        private void SetButtonState(Button button, bool visible)
        {
            button.Visible = visible;
            button.Enabled = visible;
        }
        private void SetPanelState(Panel panel, bool visible)
        {
            panel.Visible = visible;
            panel.Enabled = visible;
        }
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных регистратора: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTreatmentsTable()
        {
            try
            {
                _treatmentsTable = DataBaseProcessing.GetTreatmentByHistoryId(_medicalHistoryId);
                TreatmentDataGrid.DataSource = _treatmentsTable;
                TreatmentDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (TreatmentDataGrid.Columns.Contains("medicine_id"))
                    TreatmentDataGrid.Columns["medicine_id"].Visible = false;
                _assignedMedicineIds.Clear();
                foreach (DataRow row in _treatmentsTable.Rows)
                {
                    if (row["medicine_id"] != DBNull.Value)
                        _assignedMedicineIds.Add(Convert.ToInt32(row["medicine_id"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить таблицу лечения: {ex.Message}", "Ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (DiseaseComboBox.SelectedIndex == -1 || WardsComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, убедитесь, что выбраны диагноз и палата!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int diseaseId = Convert.ToInt32(DiseaseComboBox.SelectedValue);
                int wardId = Convert.ToInt32(WardsComboBox.SelectedValue);
                List<int> medicineIdsToSave = _assignedMedicineIds.ToList();
                DataBaseProcessing.UpdateMedicalHistory(_medicalHistoryId, diseaseId, medicineIdsToSave, wardId);

                MessageBox.Show("Все изменения и назначения успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnClosed?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CancelButton_Click(object sender, EventArgs e) => OnClosed?.Invoke();
        private void AddTreatmentButton_Click(object sender, EventArgs e)
        {
            if (TreatmentComboBox.SelectedIndex == -1 || TreatmentComboBox.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, выберите препарат из списка!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedMedicineId = Convert.ToInt32(TreatmentComboBox.SelectedValue);
            if (_assignedMedicineIds.Contains(selectedMedicineId))
            {
                MessageBox.Show($"Препарат \"{TreatmentComboBox.Text}\" уже находится в списке назначений этой истории болезни!", 
                                "Повторное назначение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddTreatmentAtTable(selectedMedicineId);
        }
        private void AddTreatmentAtTable(int selectedMedicineId)
        {
            try
            {
                _assignedMedicineIds.Add(selectedMedicineId);
                DataRowView selectedRowView = (DataRowView)TreatmentComboBox.SelectedItem;
                DataRow newRow = _treatmentsTable.NewRow();
                newRow["medicine_id"] = selectedMedicineId;
                newRow["Препарат"] = selectedRowView["Название препарата"];
                newRow["Тип"] = selectedRowView.Row.Table.Columns.Contains("Тип") ? selectedRowView["Тип"] : "";
                newRow["Описание"] = selectedRowView.Row.Table.Columns.Contains("Описание") ? selectedRowView["Описание"] : "";
                _treatmentsTable.Rows.Add(newRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при локальном добавлении препарата: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
