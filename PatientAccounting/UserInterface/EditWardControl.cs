using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class EditWardControl : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        public event Action? OnDataSaved;
        private readonly int _wardId;
        public EditWardControl(int wardId, int currentNumber, int currentTypeId, int currentDeptId, int currentCapacity)
        {
            InitializeComponent();
            _wardId = wardId;
            LoadComboBoxes();
            WardNumberNumeric.Value = currentNumber;
            CapacityNumeric.Value = currentCapacity;
            DepartmentComboBox.SelectedValue = currentDeptId;
            WardTypeComboBox.SelectedValue = currentTypeId;
        }
        private void LoadComboBoxes()
        {
            try
            {
                DataTable departments = DataBaseProcessing.GetDepartments();
                DepartmentComboBox.DataSource = departments;
                DepartmentComboBox.DisplayMember = "name_department";
                DepartmentComboBox.ValueMember = "department_id";

                DataTable wardTypes = DataBaseProcessing.GetWardTypes();
                WardTypeComboBox.DataSource = wardTypes;
                WardTypeComboBox.DisplayMember = "name_type_of_ward";
                WardTypeComboBox.ValueMember = "type_of_ward_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке справочников для палат: {ex.Message}",
                                "Ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e) => OnClosed?.Invoke();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(WardNumberNumeric.Value);
                int capacity = Convert.ToInt32(CapacityNumeric.Value);
                int deptId = Convert.ToInt32(DepartmentComboBox.SelectedValue);
                int typeId = Convert.ToInt32(WardTypeComboBox.SelectedValue);
                DataBaseProcessing.UpdateWard(_wardId, number, typeId, deptId, capacity);
                MessageBox.Show("Данные палаты успешно обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnDataSaved?.Invoke();
                OnClosed?.Invoke();
            }
            catch (Npgsql.PostgresException ex)
            {
                MessageBox.Show("Палата с таким номером уже существует в больнице!", "Ошибка уникальности", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения палаты: {ex.Message}", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
