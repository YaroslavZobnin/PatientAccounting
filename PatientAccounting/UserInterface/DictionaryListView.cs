using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using PatientAccounting.Models;
using System.Data;

namespace PatientAccounting.UserInterface
{
    public partial class DictionaryListView : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        public event Action<IWindowClosed>? OnEditRequested;
        private ViewListMode _currentMode;
        public DictionaryListView(ViewListMode mode)
        {
            InitializeComponent();
            _currentMode = mode;
            LoadData();
            GetAddButtonText();
        }
        private void GetAddButtonText()
        {
            if (_currentMode == ViewListMode.Diseases)
                AddButton.Text = "Добавить новую болезнь";
            else if (_currentMode == ViewListMode.Wards)
                AddButton.Text = "Добавить новую палату";
        }
        private void LoadData()
        {
            if (_currentMode == ViewListMode.Diseases)
            {
                DictionaryGrid.DataSource = DataBaseProcessing.GetListByMode(ViewListMode.Diseases);
                HideColumnIfExists("ID");
                HideColumnIfExists("category_id");
            }
            else if (_currentMode == ViewListMode.Wards)
            {
                DictionaryGrid.DataSource = DataBaseProcessing.GetListByMode(ViewListMode.Wards);
                HideColumnIfExists("ID");
                HideColumnIfExists("department_id");
                HideColumnIfExists("type_of_ward_id");
            }
        }
        private void HideColumnIfExists(string columnName)
        {
            if (DictionaryGrid.Columns.Contains(columnName))
            {
                DictionaryGrid.Columns[columnName].Visible = false;
            }
        }
        private void CancelButton_Click(object sender, EventArgs e) => OnClosed?.Invoke();

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (DictionaryGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись!");
                return;
            }

            DataRow currentRow = ((DataRowView)DictionaryGrid.SelectedRows[0].DataBoundItem).Row;
            if (_currentMode == ViewListMode.Diseases)
            {
                int id = Convert.ToInt32(currentRow["ID"]);
                string name = currentRow["Название болезни"].ToString();
                int categoryId = Convert.ToInt32(currentRow["category_id"]);
                object duration = currentRow["Срок лечения (дн.)"];

                var editDisease = new EditDictionaryOfDiseases(id, name, categoryId, duration);
                editDisease.OnDataSaved += LoadData;

                OnEditRequested?.Invoke(editDisease);
            }
            else if (_currentMode == ViewListMode.Wards)
            {
                int id = Convert.ToInt32(currentRow["ID"]);
                int number = Convert.ToInt32(currentRow["№ Палаты"]);
                int typeId = Convert.ToInt32(currentRow["type_of_ward_id"]);
                int deptId = Convert.ToInt32(currentRow["department_id"]);
                int capacity = Convert.ToInt32(currentRow["Вместимость"]);

                var editWard = new EditDictionaryOfWards(id, number, typeId, deptId, capacity);
                editWard.OnDataSaved += LoadData;
                OnEditRequested?.Invoke(editWard);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_currentMode == ViewListMode.Diseases)
            {
                var addDisease = new EditDictionaryOfDiseases();
                addDisease.OnDataSaved += LoadData;
                OnEditRequested?.Invoke(addDisease);
            }
            else if (_currentMode == ViewListMode.Wards)
            {
                var addWard = new EditDictionaryOfWards();
                addWard.OnDataSaved += LoadData;
                OnEditRequested?.Invoke(addWard);
            }
        }
    }
}
