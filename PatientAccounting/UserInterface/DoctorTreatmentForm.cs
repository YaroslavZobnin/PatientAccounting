using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using PatientAccounting.Models;
using System;
using System.Data;
using System.Windows.Forms;
namespace PatientAccounting.UserInterface
{
    public partial class DoctorTreatmentForm : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        private readonly int _medicalHistoryId;
        public DoctorTreatmentForm(int medicalHistoryId)
        {
            InitializeComponent();
            _medicalHistoryId = medicalHistoryId;
            LoadMedicalDirectories();
            LoadCurrentHistoryData();
        }
        private void LoadMedicalDirectories()
        {
            try
            {
                DiseaseComboBox.DataSource = DataBaseProcessing.GetListByMode(ViewListMode.Diseases);
                DiseaseComboBox.DisplayMember = "Название болезни";
                DiseaseComboBox.ValueMember = "ID";
                DiseaseComboBox.SelectedIndex = -1;

                TreatmentComboBox.DataSource = DataBaseProcessing.GetListByMode(ViewListMode.Treatments);
                TreatmentComboBox.DisplayMember = "Наименование";
                TreatmentComboBox.ValueMember = "ID";
                TreatmentComboBox.SelectedIndex = -1;

                WardsComboBox.DataSource = DataBaseProcessing.GetListByMode(ViewListMode.Wards);
                WardsComboBox.DisplayMember = "Номер палаты";
                WardsComboBox.ValueMember = "ID";
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
                    DateOfReceipt.Value = (DateTime)historyRow["date_of_receipt"];
                    if (historyRow["ward_id"] != DBNull.Value)
                    {
                        int currentWardId = Convert.ToInt32(historyRow["ward_id"]);
                        WardsComboBox.SelectedValue = currentWardId;
                    }
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
                MessageBox.Show($"Ошибка при сохранении назначений в базу данных: {ex.Message}",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            OnClosed?.Invoke();
        }
    }
}
