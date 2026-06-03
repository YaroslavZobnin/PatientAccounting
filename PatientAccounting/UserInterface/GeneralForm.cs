using PatientAccounting.Models;
using PatientAccounting.UserInterface;

namespace PatientAccounting
{
    public partial class GeneralForm : Form
    {
        private User _user;
        public GeneralForm(User user)
        {
            InitializeComponent();
            _user = user;
            WindowDefinition();
        }
        private void WindowDefinition()
        {
            UserControl? targetWindow = _user switch
            {
                Patient patient => new PatientWindow(patient),
                Staff staff when staff.Role == UserRole.SystemRegistrar => new SystemAdministrator(staff),
                Staff staff when staff.Role == UserRole.MedicalRegistrar => new MedicalRegistrar(staff),
                Staff staff when staff.Role == UserRole.AttendingPhysician => new DoctorWindow(staff),
                Staff staff when staff.Role == UserRole.HeadPhysician => new HeadPhysician(staff),
                _ => null 
            };
            if (targetWindow != null)
                ChangeUserInterface(targetWindow);
            else
                MessageBox.Show("Ошибка: Роль пользователя не распознана или доступ запрещен.",
                                "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ChangeUserInterface(UserControl control)
        {
            UserControlsPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            UserControlsPanel.Controls.Add(control);
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
            if(Confirmation() == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Retry;
                this.Close();
            }
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
        private DialogResult Confirmation()
            => MessageBox.Show("Вы уверены, что хотите выйти?\nВсе несохраненные данные пропадут.",
                              "Подтверждение",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    }
}
