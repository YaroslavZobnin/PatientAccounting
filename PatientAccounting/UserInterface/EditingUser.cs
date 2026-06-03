using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class EditingUser : UserControl, IManagementControl, IWindowClosed
    {
        public event Action? OnClosed;
        private int _currentUserId;
        private string? _currentRole;
        private DataRow? _originalRow;
        private PassportSearching? _passportSearching;
        public EditingUser()
        {
            InitializeComponent();
            SetPanelState(EditingUserPanel, false);
            SetButtonState(CancelButton, false);
            SetButtonState(SaveEditedUser, false);
            InitPassportSearch();
        }
        private void InitPassportSearch()
        {
            _passportSearching = new PassportSearching("Введите паспортные данные для редактирования", false);
            _passportSearching.Dock = DockStyle.Fill;

            SearchUserByPassportPanel.Controls.Clear();
            SearchUserByPassportPanel.Controls.Add(_passportSearching);

            _passportSearching.OnUserFound += (DataRow foundRow) =>
            {
                _originalRow = foundRow;
                _currentUserId = Convert.ToInt32(_originalRow["customer_id"]);
                _currentRole = _originalRow["role_name"].ToString();

                LoadUserData();
            };
        }

        private void LoadUserData()
        {
            if (_originalRow == null) return;
            SetPanelState(SearchUserByPassportPanel, false);
            SetPanelState(EditingUserPanel, true);
            SetButtonState(CancelButton, true);
            SetButtonState(SaveEditedUser, true);
            MapUserDataToUI(_originalRow);
        }

        private void MapUserDataToUI(DataRow row)
        {
            FillGeneralFields(row);
            SetPanelState(EditingPatientPanel, false);
            SetPanelState(EditingStaffPanel, false);
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
            if (birthDateValue != DBNull.Value)
            {
                if (birthDateValue is DateOnly dateOnly)
                    DateOfBirthDateTimePicker.Value = dateOnly.ToDateTime(TimeOnly.MinValue);
                else if (birthDateValue is DateTime dateTime)
                    DateOfBirthDateTimePicker.Value = dateTime;
            }
            AddressTextBox.Text = row["patient_address"].ToString();
        }
        private void FillStaffFields(DataRow row)
        {
            SurnameTextBox.Text = row["staff_worker_surname"].ToString();
            NameTextBox.Text = row["staff_worker_name"].ToString();
            PatronymicTextBox.Text = row["staff_worker_patronymic"].ToString();
            WorkExperienceNumericUpDown.Value = row["staff_worker_work_experience"] != DBNull.Value
                ? Convert.ToInt32(row["staff_worker_work_experience"]) : 0;
            if (row["specialization_id"] != DBNull.Value)
            {
                SpecializationsComboBox.Enabled = true;
                LoadSpecialization();
            }
            else
                SpecializationsComboBox.Enabled = false;
        }
        private void LoadSpecialization()
        {
            DataTable spec = DataBaseProcessing.GetSpecializations();
            SpecializationsComboBox.DataSource = spec;
            SpecializationsComboBox.DisplayMember = "name_specialization";
            SpecializationsComboBox.ValueMember = "specialization_id";
            if (_originalRow?["specialization_id"] != DBNull.Value)
                SpecializationsComboBox.SelectedValue = _originalRow["specialization_id"];
        }
        private void LoadUserRolesList()
        {
            DataTable role = DataBaseProcessing.GetRole();
            RoleComboBox.DataSource = role;
            RoleComboBox.DisplayMember = "role_name";
            RoleComboBox.ValueMember = "role_id";
            if (_originalRow?["customer_role_id"] != DBNull.Value)
                RoleComboBox.SelectedValue = _originalRow["customer_role_id"];
        }
        public void SaveProcess()
        {
            if (!ValidateData()) return;
            try
            {
                DataBaseProcessing.UpdateCustomerBase(_currentUserId, UserLoginTextBox.Text, UserPassportTextBox.Text);
                if (_currentRole == "Пациент")
                {
                    DataBaseProcessing.UpdatePatientDetails(_currentUserId, SurnameTextBox.Text,
                        NameTextBox.Text, PatronymicTextBox.Text, DateOfBirthDateTimePicker.Value, AddressTextBox.Text);
                }
                else
                {
                    int? specId = (_currentRole == "Медицинский регистратор" || _currentRole == "Системный администратор")
                        ? null : (int?)SpecializationsComboBox.SelectedValue;
                    DataBaseProcessing.UpdateStaffDetails(_currentUserId, SurnameTextBox.Text, NameTextBox.Text,
                        PatronymicTextBox.Text, specId, (int)WorkExperienceNumericUpDown.Value);
                }
                MessageBox.Show("Данные успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnClosed?.Invoke();
            }
            catch (Exception ex)
            {
                string errorText = ex.ToString().ToLower();
                if (errorText.Contains("unique"))
                {
                    if (errorText.Contains("login"))
                    {
                        MessageBox.Show("Этот логин уже занят другим пользователем!\nПожалуйста, придумайте другой.",
                                        "Ошибка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (errorText.Contains("passport"))
                    {
                        MessageBox.Show("Пользователь с такими паспортными данными уже существует в системе!",
                                        "Ошибка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Логин или паспортные данные уже заняты другим пользователем!",
                                        "Ошибка изменения данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

            if (_currentRole == "Пациент")
            {
                if (!PatientCheckData()) return false;
            }
            else
            {
                if (!StaffCheckData()) return false;
            }
            return true;
        }
        private bool GeneralCheckData()
        {
            if (string.IsNullOrWhiteSpace(UserLoginTextBox.Text) || string.IsNullOrWhiteSpace(UserPassportTextBox.Text))
            {
                MessageBox.Show("Логин и паспорт должны быть заполнены!", "Ошибка");
                return false;
            }
            if (string.IsNullOrWhiteSpace(SurnameTextBox.Text) || string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Фамилия и Имя обязательны!", "Ошибка");
                return false;
            }
            return true;
        }
        private bool PatientCheckData()
        {
            if (DateOfBirthDateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Дата рождения не может быть в будущем!", "Ошибка");
                return false;
            }
            if (string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                MessageBox.Show("Адрес пациента обязателен!", "Ошибка");
                return false;
            }
            return true;
        }
        private bool StaffCheckData()
        {
            if (WorkExperienceNumericUpDown.Value < 0 || WorkExperienceNumericUpDown.Value > 80)
            {
                MessageBox.Show("Опыт работы должен быть от 0 до 80!", "Ошибка");
                return false;
            }
            bool needsSpecialization = (_currentRole != "Медицинский регистратор" && _currentRole != "Системный администратор");
            if (needsSpecialization && SpecializationsComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите специализацию!", "Ошибка");
                return false;
            }
            return true;
        }
        private void SetPanelState(Panel panel, bool visible)
        {
            panel.Visible = visible;
            panel.Enabled = visible;
        }
        private void SetButtonState(Button button, bool visible)
        {
            button.Visible = visible;
            button.Enabled = visible;
        }
        private DialogResult ConfirmExit()
           => MessageBox.Show("Вернуться в меню? Несохраненные изменения пропадут.", "Выход", MessageBoxButtons.YesNo);
        private void SaveEditedUser_Click(object sender, EventArgs e) => SaveProcess();
        private void BackToMenuButton_Click(object sender, EventArgs e) => ExitToMenu();
        private void CancelButton_Click(object sender, EventArgs e) => Cancel();

    }
}
