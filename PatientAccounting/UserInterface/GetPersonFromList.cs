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
        private DataTable? _customDataSource;
        public GetPersonFromList(ViewListMode mode)
        {
            InitializeComponent();
            _currentMode = mode;
            LoadData();
        }
        public GetPersonFromList(DataTable customData)
        {
            InitializeComponent();
            _customDataSource = customData;
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                DataTable data = _customDataSource ?? DataBaseProcessing.GetListByMode(_currentMode);
                UniversalGrid.DataSource = data;
                string nameRole = Translator.TranslateRole(_currentMode) + "_id";
                if (UniversalGrid.Columns.Contains("ID"))
                {
                    data.Columns["ID"].ColumnName = nameRole;
                    SetColumnsState(UniversalGrid, nameRole, false);
                }
                if (UniversalGrid.Columns.Contains("role_name"))
                    SetColumnsState(UniversalGrid, "role_name", false);
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
        private void SetColumnsState(DataGridView data, string columnName, bool visible)
            => data.Columns[columnName].Visible = visible;
        private void Exit() => OnClosed?.Invoke();
    }
}
