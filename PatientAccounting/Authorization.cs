namespace PatientAccounting
{
    public partial class Authorization : Form
    {
        private User _user;
        public Authorization()
        {
            InitializeComponent();
        }
        public User GetUser => _user;
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
            if(string.IsNullOrEmpty(InputLoginTextBox.Text) || string.IsNullOrEmpty(InputPasswordTextBox.Text))
            {
                MessageBox.Show("Не все поля заполнены!", "Обнаружены пустые поля!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            User? user = DataBaseProcessing.SearchUserInDataBase(InputLoginTextBox.Text, InputPasswordTextBox.Text);
            if (user != null)
            {
                _user = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ClearWhiteSpace()
        {
            InputLoginTextBox.Text = InputLoginTextBox.Text.Trim();
            InputPasswordTextBox.Text = InputPasswordTextBox.Text.Trim();
        }
    }
}
