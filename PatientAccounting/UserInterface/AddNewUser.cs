using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class AddNewUser : UserControl, IManagementControl
    {
        public event Action? OnClosed;
        public AddNewUser()
        {
            InitializeComponent();
        }
        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton == null || !radioButton.Checked) return;
            SwitchConditionRadioButton();
            SwitchVisibilityGeneralPanel();
            SwitchCancelButton();
            if (radioButton.Text == "Пациент")
                SwitchVisibilityPatientDataPanel();
            else
            {
                SwitchVisibilityStaffDataPanel();
                CheckingForDiscChoiceSpec(radioButton);
                FillSpecialtyMenu();
            }
        }
        private void ChoiceSpecializationTextBox_Click(object sender, EventArgs e)
            => ChoiceSpecializationContextMenuStrip.Show(ChoiceSpecializationTextBox, new Point(0, ChoiceSpecializationTextBox.Height));
        private void SwitchVisibilityGeneralPanel()
        {
            InputGeneralDataPanel.Visible = !InputGeneralDataPanel.Visible;
            InputGeneralDataPanel.Enabled = !InputGeneralDataPanel.Enabled;
        }
        private void SwitchVisibilityPatientDataPanel()
        {
            AddPatientDataPanel.Visible = !AddPatientDataPanel.Visible;
            AddPatientDataPanel.Enabled |= InputGeneralDataPanel.Enabled;
        }
        private void SwitchVisibilityStaffDataPanel()
        {
            InputStaffPanel.Visible = !InputStaffPanel.Visible;
            InputStaffPanel.Enabled = !InputStaffPanel.Enabled;
        }
        private void SwitchConditionRadioButton()
        {
            foreach (var c in ChoiceRolePanel.Controls)
                if (c is RadioButton radioButton)
                    radioButton.Enabled = !radioButton.Enabled;
        }
        private void SwitchCancelButton()
        {
            CancelButton.Visible = !CancelButton.Visible;
            CancelButton.Enabled = !CancelButton.Enabled;
        }
        private void ResettingTheSelection()
        {
            foreach (var c in ChoiceRolePanel.Controls)
                if (c is RadioButton radioButton)
                    radioButton.Checked = false;
        }
        private void ResetAdding()
        {
            InputGeneralDataPanel.Visible = false;
            InputGeneralDataPanel.Enabled = false;
            AddPatientDataPanel.Visible = false;
            AddPatientDataPanel.Enabled = false;
            InputStaffPanel.Visible = false;
            InputStaffPanel.Enabled = false;
            ResettingTheSelection();
            ClearInputPanels(this);
        }
        private void FillSpecialtyMenu()
        {
            var dataTable = DataBaseProcessing.GetSpecializations();
            ChoiceSpecializationContextMenuStrip.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                string? name = row["name_specialization"].ToString();
                int id = Convert.ToInt32(row["specialization_id"]);
                var item = new ToolStripMenuItem(name);
                item.Tag = id;
                item.Click += SpecialtyItem_Click;
                ChoiceSpecializationContextMenuStrip.Items.Add(item);
            }
        }
        private void SpecialtyItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            ChoiceSpecializationTextBox.Text = item.Text;
            ChoiceSpecializationTextBox.Tag = item.Tag;
        }
        private void CheckingForDiscChoiceSpec(RadioButton radioButton)
        {
            if (radioButton.Text == "Медицинский регистратор" || radioButton.Text == "Системный администратор")
                ChoiceSpecializationTextBox.Enabled = false;
            else
                ChoiceSpecializationTextBox.Enabled = true;
        }
        private void CancelButton_Click(object sender, EventArgs e) => Cancel();

        private void ClearInputPanels(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox) textBox.Clear();
                if (control is DateTimePicker dateTimePicker) dateTimePicker.Value = DateTime.Now;
                if (control.HasChildren) ClearInputPanels(control);
            }
        }
        private void BackToMenuButton_Click(object sender, EventArgs e) => ExitToMenu();
        public void Cancel()
        {
            ResetAdding();
            SwitchConditionRadioButton();
            SwitchCancelButton();
        }
        public void ExitToMenu()
        {
            OnClosed?.Invoke();
            ClearInputPanels(this);
        }
        public void SaveProcess()
        {
            if (!ValidateData()) return;
            string login = InputUserLoginTextBox.Text;
            string password = InputUserPasswordTextBox.Text;
            string passport = InputUserPassportData.Text;
            string surname = InputUserSurnameTextBox.Text;
            string name = InputUserNameTextBox.Text;
            string patronymic = InputUserPatronymicTextBox.Text;
            bool isSuccess = false;
            if (PatientRadioButton.Checked)
            {
                DateTime birth = PatientDateOfBirthDateTimePicker.Value;
                string address = InputPatientAddressTextBox.Text;

                isSuccess = DataBaseProcessing.RegisterPatientSimple(login, password, passport,
                                                                    surname, name, patronymic,
                                                                    birth, address);
            }
            else
            {
                int.TryParse(InputWorkExperienceTextBox.Text, out int exp);
                int? specId = ChoiceSpecializationTextBox.Tag as int?;
                int roleId = GetSelectedRoleId();
                isSuccess = DataBaseProcessing.RegisterStaff(login, password, passport, roleId,
                                                                  surname, name, patronymic,
                                                                  specId, exp);
            }
            if (isSuccess)
            {
                MessageBox.Show("Данные успешно сохранены!");
                ExitToMenu();
            }
        }
        public bool ValidateData()
        {
            var commonFields = new Dictionary<string, string>
            {
                { "Логин", InputUserLoginTextBox.Text },
                { "Пароль", InputUserPasswordTextBox.Text },
                { "Паспортные данные", InputUserPassportData.Text },
                { "Фамилия", InputUserSurnameTextBox.Text },
                { "Имя", InputUserNameTextBox.Text }
            };
            foreach (var field in commonFields)
            {
                if (string.IsNullOrWhiteSpace(field.Value))
                {
                    MessageBox.Show($"Поле '{field.Key}' обязательно для заполнения!");
                    return false;
                }
            }
            if (PatientRadioButton.Checked)
            {
                if (PatientDateOfBirthDateTimePicker.Value >= DateTime.Now.Date)
                {
                    MessageBox.Show("Введите корректную дату рождения!");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(InputPatientAddressTextBox.Text))
                {
                    MessageBox.Show("Поле 'Адрес' обязательно для пациента!");
                    return false;
                }
            }
            else
            {
                int roleId = GetSelectedRoleId();
                if (roleId == 3 || roleId == 4)
                {
                    if (string.IsNullOrEmpty(ChoiceSpecializationTextBox.Text) || ChoiceSpecializationTextBox.Tag == null)
                    {
                        MessageBox.Show("Для врачей обязательно указание специализации!");
                        return false;
                    }
                }
            }
            return true;
        }
        private int GetSelectedRoleId()
        {
            if (MedicalRegistar.Checked) return 2;
            if (DoctorRadioButton.Checked) return 3;
            if (HeadDoctorRadioButton.Checked) return 4;
            if (SystemAdminRadioButton.Checked) return 5;
            return 1;
        }
        private void SaveAddUser_Click(object sender, EventArgs e) => SaveProcess();

    }
}

