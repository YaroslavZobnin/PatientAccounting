using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class EditDictionaryOfWards : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        public event Action? OnDataSaved;
        private readonly int _wardId;
        private readonly bool _isEditMode;
        public EditDictionaryOfWards(int wardId, int currentNumber, int currentTypeId, int currentDeptId, int currentCapacity)
        {
            InitializeComponent();
            _wardId = wardId;
            _isEditMode = true;
            LoadComboBoxes();
            WardNumberNumeric.Value = currentNumber;
            CapacityNumeric.Value = currentCapacity;
            DepartmentComboBox.SelectedValue = currentDeptId;
            WardTypeComboBox.SelectedValue = currentTypeId;
        }
        public EditDictionaryOfWards()
        {
            InitializeComponent();
            _isEditMode = false;
            LoadComboBoxes();
            EditDictionaryOfWardsLabel.Text = "Добавление палаты";
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
                if (_isEditMode)
                {
                    int currentPatients = DataBaseProcessing.GetCurrentPatientsCountInWard(_wardId);
                    if (capacity < currentPatients)
                    {
                        MessageBox.Show(
                            $"Невозможно уменьшить вместимость палаты до {capacity} мест!\n" +
                            $"В данный момент в ней уже находится пациент(ов): {currentPatients}.\n\n" +
                            $"Сначала переведите лишних пациентов.",
                            "Превышение лимита палаты", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DataBaseProcessing.UpdateWard(_wardId, number, typeId, deptId, capacity);
                    MessageBox.Show("Данные палаты успешно обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataBaseProcessing.AddWard(number, typeId, deptId, capacity);
                    MessageBox.Show("Новая палата успешно добавлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                OnDataSaved?.Invoke();
                OnClosed?.Invoke();   
            }
            catch (Npgsql.PostgresException ex)
            {
                MessageBox.Show("Палата с таким номером уже существует!", "Ошибка уникальности", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
