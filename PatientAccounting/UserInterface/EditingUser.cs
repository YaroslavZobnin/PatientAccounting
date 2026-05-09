using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class EditingUser : UserControl, IManagementControl
    {
        public event Action? OnClosed;
        private int _currentUserId;
        private string? _currentRole;
        private DataRow? _originalRow;
        public EditingUser()
        {
            InitializeComponent();
        }

        private void AcceptedInputPassportDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dataTable = DataBaseProcessing.GetUserByPassport(InputPassportDataTextBox.Text.Trim());
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Пользователь не найден.");
                    return;
                }
                SetPanelState(InputPassportData, false);
                _originalRow = dataTable.Rows[0];
                _currentUserId = Convert.ToInt32(_originalRow["customer_id"]);
                _currentRole = _originalRow["role_name"].ToString();
                SetPanelState(EditingUserPanel, true);
                MapUserDataToUI(_originalRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetPanelState(Panel panel, bool visible)
        {
            panel.Visible = visible;
            panel.Enabled = visible;
        }

        private void MapUserDataToUI(DataRow row)
        {
            FillGeneralFields(row);
            if (_currentRole == "Пациент")
            {
                SetPanelState(EditingPatientPanel, true);
                FillPatientFields(row);
            }
            else
            {
                SetPanelState(EditingStaffPanel, true);
                FillStaffFields(row);
            }
        }
        private void FillGeneralFields(DataRow row)
        {
            UserLoginTextBox.Text = row["customer_login"].ToString();
            UserPassportTextBox.Text = row["customer_passport_data"].ToString();
            LoadUserRolesList();
        }
        private void FillPatientFields(DataRow row)
        {
            SurnameTextBox.Text = row["patient_surname"].ToString();
            NameTextBox.Text = row["patient_name"].ToString();
            PatronymicTextBox.Text = row["patient_patronymic"].ToString();
            var birthDateValue = row["patient_birth_date"];
            if (birthDateValue is DateOnly dateOnly)
            {
                DateOfBirthDateTimePicker.Value = dateOnly.ToDateTime(TimeOnly.MinValue);
            }
            else if (birthDateValue is DateTime date)
            {
                DateOfBirthDateTimePicker.Value = date;
            }
            AddressTextBox.Text = row["patient_address"].ToString();
        }
        private void FillStaffFields(DataRow row)
        {
            SurnameTextBox.Text = row["staff_worker_surname"].ToString();
            NameTextBox.Text = row["staff_worker_name"].ToString();
            PatronymicTextBox.Text = row["staff_worker_patronymic"].ToString();
            WorkExperienceNumericUpDown.Value = (int)row["staff_worker_work_experience"];
            if (row["specialization_id"] != DBNull.Value)
                LoadSpecialization();
            else
                SpecializationsComboBox.Enabled = false;
        }
        private void LoadSpecialization()
        {
            DataTable spec = DataBaseProcessing.GetSpecializations();
            SpecializationsComboBox.DataSource = spec;
            SpecializationsComboBox.DisplayMember = "name_specialization";
            SpecializationsComboBox.ValueMember = "specialization_id";
            SpecializationsComboBox.SelectedValue = _originalRow["specialization_id"];
        }
        private void LoadUserRolesList()
        {
            DataTable role = DataBaseProcessing.GetRole();
            RoleComboBox.DataSource = role;
            RoleComboBox.DisplayMember = "role_name";
            RoleComboBox.ValueMember = "role_id";
            if (_originalRow["customer_role_id"] != DBNull.Value)
                RoleComboBox.SelectedValue = _originalRow["customer_role_id"];
        }
        public void SaveProcess()
        {
            if (!ValidateData()) return;
            try
            {
                DataBaseProcessing.UpdateCustomerBase(_currentUserId, UserLoginTextBox.Text, UserPassportTextBox.Text);
                if (_currentRole == "Пациент")
                    DataBaseProcessing.UpdatePatientDetails(_currentUserId, SurnameTextBox.Text,
                        NameTextBox.Text, PatronymicTextBox.Text, DateOfBirthDateTimePicker.Value, AddressTextBox.Text);
                else
                {
                    object? specId = (_currentRole == "Медицинский регистратор" || _currentRole == "Системный администратор")
                        ? null : SpecializationsComboBox.SelectedValue;
                    DataBaseProcessing.UpdateStaffDetails(_currentUserId, SurnameTextBox.Text, NameTextBox.Text,
                        PatronymicTextBox.Text, (int?)SpecializationsComboBox.SelectedValue, (int)WorkExperienceNumericUpDown.Value);
                }
                MessageBox.Show("Данные сохранены.");
                OnClosed?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        public void Cancel()
        {
            if (_originalRow != null)
                MapUserDataToUI(_originalRow);
        }
        public void ExitToMenu()
        {
            if (ConfirmExit() == DialogResult.Yes)
                OnClosed?.Invoke();
        }
        public bool ValidateData()
        {
            if (!GeneralCheckData()) return false;
            if (_currentRole == "Patient")
                if (!PatientCheckData()) return false;
                else if (_currentRole == "Staff_worker")
                    if (!StaffCheckData()) return false;
            return true;
        }
        private bool GeneralCheckData()
        {
            if (string.IsNullOrWhiteSpace(UserLoginTextBox.Text) || string.IsNullOrWhiteSpace(UserLoginTextBox.Text))
            {
                MessageBox.Show("Логин и паспорт должны быть заполнены!", "Ошибка валидации");
                return false;
            }
            if (string.IsNullOrWhiteSpace(SurnameTextBox.Text) || string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Фамилия и Имя обязательны для заполнения!", "Ошибка валидации");
                return false;
            }
            return true;
        }
        private bool PatientCheckData()
        {
            if (DateOfBirthDateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Дата рождения не может быть в будущем!", "Ошибка валидации");
                return false;
            }
            if (string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                MessageBox.Show("Адрес пациента не может быть пустым!", "Ошибка валидации");
                return false;
            }
            return true;
        }
        private bool StaffCheckData()
        {
            if (WorkExperienceNumericUpDown.Value < 0 || WorkExperienceNumericUpDown.Value > 80)
            {
                MessageBox.Show("Опыт работы должен быть числом от 0 до 80!", "Ошибка валидации");
                return false;
            }
            bool needsSpecialization = (_currentRole != "Медицинский регистратор" && _currentRole != "Системный администратор");
            if (needsSpecialization && SpecializationsComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите специализацию сотрудника!", "Ошибка валидации");
                return false;
            }
            return true;
        }
        private DialogResult ConfirmExit()
           => MessageBox.Show("Вернуться в меню? Все несохраненные изменения будут потеряны.", "Выход", MessageBoxButtons.YesNo);

        private void SaveEditedUser_Click(object sender, EventArgs e) => SaveProcess();

        private void BackToMenuButton_Click(object sender, EventArgs e) => ExitToMenu();

        private void CancelButton_Click(object sender, EventArgs e) => Cancel();

    }
}
