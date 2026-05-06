using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using PatientAccounting.Services;
using PatientAccounting.UserInterface;
namespace PatientAccounting
{
    public partial class SystemAdministrator : UserControl
    {
        private Staff staff;
        private IManagementControl? currentActiveControl;
        public SystemAdministrator(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            InitializeFullName();
        }
        private void InitializeFullName()
            => FullNameLabel.Text = GeneralMethods.GetFullName(staff);

        private void AddUser_Click(object sender, EventArgs e)
        {
            ActionLabel.Text = "Добавление пользователя";
            var addUser = new AddNewUser();
            addUser.OnClosed += ReturnToMainMenu;
            ShowControl(addUser);
            currentActiveControl = addUser;
            SwitchVisibilityChoicePanel();
            SwitchVisibilityMainPanel();
        }
        private void ReturnToMainMenu()
        {
            MainEventPanel.Controls.Clear();
            currentActiveControl = null;
            SwitchVisibilityMainPanel();
            SwitchVisibilityChoicePanel();
            ActionLabel.Text = "Выберите действие";
        }
        private void ShowControl(UserControl newControl)
        {
            foreach (Control control in MainEventPanel.Controls)
                control.Dispose();
            MainEventPanel.Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            MainEventPanel.Controls.Add(newControl);
        }
        private void SwitchVisibilityChoicePanel()
        {
            ChoicePanel.Visible = !ChoicePanel.Visible;
            ChoicePanel.Enabled = !ChoicePanel.Enabled;
        }
        private void SwitchVisibilityMainPanel()
        {
            MainEventPanel.Visible = !MainEventPanel.Visible;
            MainEventPanel.Enabled = !MainEventPanel.Enabled;
        }
    }
}
