using PatientAccounting.Interfaces;
using PatientAccounting.Services;
using PatientAccounting.UserInterface;
namespace PatientAccounting
{
    public partial class SystemAdministrator : UserControl, IPresenter
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
            var addUser = new AddNewUser("Системный администратор");
            addUser.OnClosed += ReturnToMainMenu;
            ShowControl(addUser);
            currentActiveControl = addUser;
            SetPanelState(ChoicePanel, false);
            SetPanelState(MainEventPanel, true);
        }
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            ActionLabel.Text = "Удаление пользователя";
            var deleteUser = new DeleteUser();
            deleteUser.OnClosed += ReturnToMainMenu;
            ShowControl(deleteUser);
            currentActiveControl = deleteUser;
            SetPanelState(ChoicePanel, false);
            SetPanelState(MainEventPanel, true);
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            ActionLabel.Text = "Редактирование пользователя";
            var editingUser = new EditingUser();
            editingUser.OnClosed += ReturnToMainMenu;
            ShowControl(editingUser);
            currentActiveControl = editingUser;
            SetPanelState(ChoicePanel, false);
            SetPanelState(MainEventPanel, true);
        }
        public void ReturnToMainMenu()
        {
            MainEventPanel.Controls.Clear();
            currentActiveControl = null;
            SetPanelState(ChoicePanel, true);
            SetPanelState(MainEventPanel, false);
            ActionLabel.Text = "Выберите действие";
        }
        public void ShowControl(UserControl newControl)
        {
            foreach (Control control in MainEventPanel.Controls)
                control.Dispose();
            MainEventPanel.Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            MainEventPanel.Controls.Add(newControl);
        }
        private void SetPanelState(Panel panel, bool visible)
        {
            panel.Visible = visible;
            panel.Enabled = visible;
        }
    }
}
