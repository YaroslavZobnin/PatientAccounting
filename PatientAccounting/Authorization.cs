namespace PatientAccounting
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e) => this.Close();
        private void SwitchPasswordVisibility(object sender, EventArgs e)
        {
            SwitchClosedEyeMode();
            SwitchOpenedEyeMode();
            if (!ClosedEyePictureBox.Enabled)
                InputPasswordTextBox.UseSystemPasswordChar = false;
            else
                InputPasswordTextBox.UseSystemPasswordChar = true;
        }
        private void SwitchOpenedEyeMode()
        {
            OpenedEyePictureBox.Visible = !OpenedEyePictureBox.Visible;
            OpenedEyePictureBox.Enabled = !OpenedEyePictureBox.Enabled;
        }
        private void SwitchClosedEyeMode()
        {
            ClosedEyePictureBox.Visible = !ClosedEyePictureBox.Visible;
            ClosedEyePictureBox.Enabled = !ClosedEyePictureBox.Enabled;
        }

        private void LoginAttempt_Click(object sender, EventArgs e)
        {
            ClearWhiteSpace();
            if (string.IsNullOrEmpty(InputLoginTextBox.Text))
                MessageBox.Show("Логин не введён!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (string.IsNullOrEmpty(InputPasswordTextBox.Text))
                MessageBox.Show("Пароль не введён!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                RoleAllocation();

        }
        private void ClearWhiteSpace()
        {
            InputLoginTextBox.Text = InputLoginTextBox.Text.Trim();
            InputPasswordTextBox.Text = InputPasswordTextBox.Text.Trim();
        }
        private void RoleAllocation(string? role)
        {
            switch(role)
            {
                case "Пациент":
                    MessageBox.Show("Пациент", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Медицинский регистратор":
                    MessageBox.Show("Медицинский регистратор", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Лучащий врач":
                    MessageBox.Show("Лечащий врач", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Главврач":
                    MessageBox.Show("Главврач", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Системный администратор":
                    MessageBox.Show("Системный администратор", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Неизвестно":
                    break;
                default:
                    throw new Exception("Данной роли не сущесвтует");
            }
        }
    }
}
