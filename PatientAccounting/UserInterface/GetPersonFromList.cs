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
        private DataTable? _unfilteredTable;
        private bool _isArchiveMode;
        public GetPersonFromList(ViewListMode mode)
        {
            InitializeComponent();
            _currentMode = mode;
            _isArchiveMode = false;
            LoadData();
            ConfigureDatePanel();
            ConfigureCheckBox();
        }
        public GetPersonFromList(DataTable customData, bool isArchiveMode = false)
        {
            InitializeComponent();
            _customDataSource = customData;
            _isArchiveMode = isArchiveMode;
            LoadData();
            ConfigureDatePanel();
            ConfigureCheckBox();
        }
        private void ConfigureDatePanel()
        {
            if (ArchiveDatePicker != null)
            {
                ArchiveDatePicker.Visible = _isArchiveMode;
                ArchiveDatePicker.Enabled = _isArchiveMode;
            }
        }
        private void ConfigureCheckBox()
        {
            if(!ArchiveDatePicker.Visible)
            {
                FilterByDateCheckBox.Visible = false;
                FilterByDateCheckBox.Enabled = false;
            }
        }
        private void LoadData()
        {
            try
            {
                DataTable data = _customDataSource ?? DataBaseProcessing.GetListByMode(_currentMode);
                _unfilteredTable = data;
                UniversalGrid.DataSource = data;
                string nameRole = Translator.TranslateRole(_currentMode) + "_id";
                if (UniversalGrid.Columns.Contains("ID"))
                {
                    data.Columns["ID"].ColumnName = nameRole;
                    SetColumnsState(UniversalGrid, nameRole, false);
                    HideColumn(UniversalGrid, nameRole);
                }
                ApplyColumnsVisibility(nameRole);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }
        private void ApplyColumnsVisibility(string nameRole)
        {
            HideColumn(UniversalGrid, nameRole);
            HideColumn(UniversalGrid, "medical_history_id");
            HideColumn(UniversalGrid, "patient_id");
            HideColumn(UniversalGrid, "role_name");
        }
        private void HideColumn(DataGridView dgv, string name)
        {
            if(dgv.Columns.Contains(name))
            {
                SetColumnsState(dgv, name, false);
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
        private void SearchDate_Changed(object sender, EventArgs e)
        {
            if (_unfilteredTable == null) return;
            if (!_unfilteredTable.Columns.Contains("Последнее поступление")) return;
            if (FilterByDateCheckBox.Checked)
            {
                DataTable filteredTable = _unfilteredTable.Clone();
                DateOnly selectedDate = DateOnly.FromDateTime(ArchiveDatePicker.Value);
                foreach (DataRow row in _unfilteredTable.Rows)
                {
                    if (row["Последнее поступление"] != DBNull.Value)
                    {
                        DateOnly receiptDate = row["Последнее поступление"] is DateTime dt
                            ? DateOnly.FromDateTime(dt)
                            : (DateOnly)row["Последнее поступление"];
                        if (receiptDate == selectedDate)
                            filteredTable.ImportRow(row);
                    }
                }
                UniversalGrid.DataSource = filteredTable;
            }
            else
                UniversalGrid.DataSource = _unfilteredTable;
            string nameRole = Translator.TranslateRole(_currentMode) + "_id";
            ApplyColumnsVisibility(nameRole);
        }
        private void SetColumnsState(DataGridView data, string columnName, bool visible)
            => data.Columns[columnName].Visible = visible;
        private void ExitButton_Click(object sender, EventArgs e) => OnClosed?.Invoke();
    }
}
