namespace PatientAccounting
{
    public partial class GeneralForm : Form
    {
        //private User _user;
        //public GeneralForm(User user)
        //{
        //    InitializeComponent();
        //    _user = user;
        //}
        public GeneralForm()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e) => this.Close();

        private void ExtraMenuButton_Click(object sender, EventArgs e) => OpenAdditionalButtons();
        private void SizeScreenButton_Click(object sender, EventArgs e)
        {
            ChangingWindowState();
            ChangingTheTextOfTheResizingButton();
        }
        private void BackToAuthorizationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var auth = new Authorization();
            if (auth.ShowDialog() == DialogResult.OK)
            {
                var generalForm = new GeneralForm();
                generalForm.Show();
                this.Close();
            }
            else
                this.Close();
        }
        private void OpenAdditionalButtons()
        {
            SwitchAdditionalMode();
            SwitchVisualActivityExtraMenuButton();
            if (ExtraMenuPanel.Visible)
                ExtraMenuPanel.BringToFront();
        }
        private void SwitchAdditionalMode()
        {
            ExtraMenuPanel.Enabled = !ExtraMenuPanel.Enabled;
            ExtraMenuPanel.Visible = !ExtraMenuPanel.Visible;
        }
        private void SwitchVisualActivityExtraMenuButton()
        {
            if (ExtraMenuPanel.Visible)
            {
                ExtraMenuButton.ForeColor = Color.Red;
                ExtraMenuButton.FlatAppearance.BorderColor = Color.Red;
            }
            else
            {
                ExtraMenuButton.ForeColor = SystemColors.ControlText;
                ExtraMenuButton.FlatAppearance.BorderSize = 1;
                ExtraMenuButton.FlatAppearance.BorderColor = Color.Gray;
            }
        }
        private void ChangingTheTextOfTheResizingButton()
        {
            if (WindowState == FormWindowState.Maximized)
                SizeScreenButton.Text = "Уменьшить";
            else
                SizeScreenButton.Text = "На весь экран";
        }
        private void ChangingWindowState()
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }
    }
}
