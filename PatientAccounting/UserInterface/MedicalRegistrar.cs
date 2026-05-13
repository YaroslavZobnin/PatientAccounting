using PatientAccounting.Interfaces;
using PatientAccounting.Services;
namespace PatientAccounting.UserInterface
{
    public partial class MedicalRegistrar : UserControl, IPresenter
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
            var outputList = new GeneralListView("Медицинский регистратор");
            ShowControl(outputList);
            SetPanelState(ChoiceActionPanel, false);
            SetPanelState(MainPanel, true);
            outputList.OnClosed += Reversion;
        }
        public void ShowControl(UserControl newControl)
        {
            foreach (Control control in MainPanel.Controls)
                control.Dispose();
            MainPanel.Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(newControl);
        }
        public void Reversion()
        {
            MainPanel.Controls.Clear();
            SetPanelState(ChoiceActionPanel, true);
            SetPanelState(MainPanel, false);
        }
        private void WritingToDataBaseButton_Click(object sender, EventArgs e)
        {
            var addNewUser = new AddNewUser("Медицинский регистратор");
            ShowControl(addNewUser);
            SetPanelState(ChoiceActionPanel, false);
            SetPanelState(MainPanel, true);
            addNewUser.OnClosed += Reversion;
        }
        private void PatientExtract_Click(object sender, EventArgs e)
        {
            var patientDischarge = new PatientDischarge();
            ShowControl(patientDischarge);
            SetPanelState(ChoiceActionPanel, false);
            SetPanelState(MainPanel, true);
            patientDischarge.OnClosed += Reversion;
        }
    }
}
