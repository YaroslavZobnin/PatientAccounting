using System.Data;
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
        private DataTable _histories;
        private bool _isShowingArchive;
        public PatientHistorySelector(int patientId, string patientName, int doctorId, bool isArchiveMode)
        {
            InitializeComponent();
            _patientId = patientId;
            _doctorId = doctorId;
            _patientName = patientName;
            _isShowingArchive = isArchiveMode;
            PatientLabel.Text = $"Мед. карты пациента: {patientName}";
            LoadHistories();
        }
        private void LoadHistories()
        {
            try
            {
                if (!_isShowingArchive)
                {
                    _histories = DataBaseProcessing.GetActiveHistoriesByDoctor(_patientId, _doctorId);
                    TransitionToTreatment.Text = "Перейти к лечению";
                }
                else
                {
                    _histories = DataBaseProcessing.GetPastHistoriesByPatient(_patientId);
                    TransitionToTreatment.Text = "Просмотреть детали";
                }
                SetButtonState(TransitionToTreatment, true);
                SetPanelState(SearchByDatePanel, _isShowingArchive);
                SearchDate();
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
            if (_histories == null) return;
            if (_isShowingArchive && FilterByDateCheckBox.Checked)
            {
                DataTable filteredTable = _histories.Clone();
                DateOnly selectedDate = DateOnly.FromDateTime(SearchByDate.Value);
                foreach (DataRow row in _histories.Rows)
                {
                    if (row["Дата поступления"] != DBNull.Value)
                    {
                        DateOnly receiptDate = row["Дата поступления"] is DateTime dt
                            ? DateOnly.FromDateTime(dt)
                            : (DateOnly)row["Дата поступления"];
                        if (receiptDate == selectedDate)
                            filteredTable.ImportRow(row);
                    }
                }
                HistoriesGrid.DataSource = filteredTable;
            }
            else
                HistoriesGrid.DataSource = _histories;
            if (HistoriesGrid.Columns.Contains("ID"))
                HistoriesGrid.Columns["ID"].Visible = false;
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
