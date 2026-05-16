using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using PatientAccounting.Models;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class GetPersonFromList : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        public event Action<DataRow>? OnItemSelected;
        private ViewListMode _currentMode;
        public GetPersonFromList(ViewListMode mode)
        {
            InitializeComponent();
            _currentMode = mode;
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                DataTable data = DataBaseProcessing.GetListByMode(_currentMode);
                UniversalGrid.DataSource = data;
                if (UniversalGrid.Columns.Contains("ID"))
                    UniversalGrid.Columns["ID"].Visible = false;
                if (UniversalGrid.Columns.Contains("patient_id"))
                    UniversalGrid.Columns["patient_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (UniversalGrid.SelectedRows.Count > 0)
            {
                var row = ((DataRowView)UniversalGrid.SelectedRows[0].DataBoundItem).Row;
                OnItemSelected?.Invoke(row);
            }
            else
                MessageBox.Show("Пожалуйста, выберите строку из таблицы.");
        }
        private void CancelChoice() => OnClosed?.Invoke();
    }
}
