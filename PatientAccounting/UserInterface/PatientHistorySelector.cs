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
        private string _patientName;
        private DataTable _activeHistories;
        private bool _isShowingArchive = false;
        public PatientHistorySelector(int patientId, string patientName)
        {
            InitializeComponent();
            _patientId = patientId;
            _patientName = patientName;
            PatientLabel.Text = $"Мед. карты пациента: {patientName}";
            LoadActiveHistories();
        }
        private void LoadActiveHistories()
        {
            try
            {
                _activeHistories = DataBaseProcessing.GetActiveHistoriesByPatient(_patientId);
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
        private void HistoryDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (_activeHistories == null) return;
            string selectedDate = SearchByDate.Value.ToString("yyyy-MM-dd");
            DataView dv = _activeHistories.DefaultView;
            dv.RowFilter = $"[Дата поступления] <= #{selectedDate}# AND ([Дата выписки] >= #{selectedDate}# OR [Дата выписки] IS NULL)";
            HistoriesGrid.DataSource = dv;
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
