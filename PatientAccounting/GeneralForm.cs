namespace PatientAccounting
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();

        }

        private void ExitButton_Click(object sender, EventArgs e) => this.Close();

        private void ExtraMenuButton_Click(object sender, EventArgs e) => OpenAdditionalButtons();

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
    }
}
