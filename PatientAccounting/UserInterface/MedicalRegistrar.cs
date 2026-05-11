using PatientAccounting.Services;
namespace PatientAccounting.UserInterface
{
    public partial class MedicalRegistrar : UserControl
    {
        private Staff staff;
        public MedicalRegistrar(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            InitializeFullName();
        }
        private void InitializeFullName() => FullNameLabel.Text = GeneralMethods.GetFullName(staff);
        private void SetPanelState(Panel panel, bool visibility)
        {
            panel.Visible = visibility;
            panel.Enabled = visibility;
        }

        private void ViewingDoctorsOrPatientsButton_Click(object sender, EventArgs e)
        {
            var OutputList = new GeneralListView("Медицинский регистратор");
            ShowControl(OutputList);
            SetPanelState(ChoiceActionPanel, false);
            SetPanelState(MainPanel, true);
        }
        private void ShowControl(UserControl newControl)
        {
            foreach (Control control in MainPanel.Controls)
                control.Dispose();
            MainPanel.Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(newControl);
        }
    }
}
