using System;
using System.Data;
using System.Windows.Forms;
using PatientAccounting.Data;
using PatientAccounting.Interfaces;
namespace PatientAccounting.UserInterface
{
    public partial class PatientHistorySelector : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        public event Action<int>? OnHistorySelected; 
        private int _patientId;
        private int _doctorId;
        private string _patientName;
        private DataTable _activeHistories;
        private bool _isShowingArchive = false;
        public PatientHistorySelector(int patientId, string patientName, int doctorId)
        {
            InitializeComponent();
            _patientId = patientId;
            _doctorId = doctorId;
            _patientName = patientName;
            PatientLabel.Text = $"Мед. карты пациента: {patientName}";
            LoadActiveHistories();
        }
        private void LoadActiveHistories()
        {
            try
            {
                _activeHistories = DataBaseProcessing.GetActiveHistoriesByDoctor(_patientId, _doctorId);
                HistoriesGrid.DataSource = _activeHistories;
                if (HistoriesGrid.Columns.Contains("ID"))
                    HistoriesGrid.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки историй: {ex.Message}");
            }
        }
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
        private void SearchDate_ValueChanged(object sender, EventArgs e)
            => SearchDate();
        private void SearchDate()
        {
            if (_activeHistories == null)
                return;
            if (SearchByDate.Checked)
            {
                DataTable filteredTable = _activeHistories.Clone();
                DateOnly selectedDate = DateOnly.FromDateTime(SearchByDate.Value);
                foreach (DataRow row in _activeHistories.Rows)
                {
                    if (row["Дата поступления"] != DBNull.Value)
                    {
                        DateOnly receiptDate = (DateOnly)row["Дата поступления"];
                        if (receiptDate == selectedDate)
                            filteredTable.ImportRow(row);
                    }
                }
                HistoriesGrid.DataSource = filteredTable;
            }
            else
                HistoriesGrid.DataSource = _activeHistories;
        }
        private void SwapModeButton_Click(object sender, EventArgs e)
        {
            if (!_isShowingArchive)
            {
                DataTable pastHistories = DataBaseProcessing.GetPastHistoriesByPatient(_patientId);
                HistoriesGrid.DataSource = pastHistories;
                SwapModeButton.Text = "Нынешние";
                SetButtonState(TransitionToTreatment, false);
                SetPanelState(SearchByDatePanel, false);
                _isShowingArchive = true;
            }
            else
            {
                LoadActiveHistories();
                SwapModeButton.Text = "Архив";
                SetButtonState(TransitionToTreatment, true);
                SetPanelState(SearchByDatePanel, true);
                _isShowingArchive = false;
            }
        }
        private void TransitionToTreatment_Click(object sender, EventArgs e)
        {
            if (HistoriesGrid.SelectedRows.Count > 0)
            {
                var row = ((DataRowView)HistoriesGrid.SelectedRows[0].DataBoundItem).Row;
                int historyId = Convert.ToInt32(row["ID"]);
                OnHistorySelected?.Invoke(historyId);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите активную госпитализацию из списка.");
            }
        }
        private void BackButton_Click(object sender, EventArgs e) => OnClosed?.Invoke();
    }
}
