using PatientAccounting.Interfaces;
using PatientAccounting.Models;
using PatientAccounting.Services;
namespace PatientAccounting.UserInterface
{
    public partial class DoctorWindow : UserControl, IPresenter
    {
        private Staff? _staff;
        public DoctorWindow(Staff staff)
        {
            InitializeComponent();
            _staff = staff;
            InitializeFullName();
            Reversion();
        }
        private void InitializeFullName() => FullNameLabel.Text = GeneralMethods.GetFullName(_staff);
        private void OpenPatientSearch()
        {
            var searchControl = new GetPersonFromList(ViewListMode.Patients);
            searchControl.OnItemSelected += (patientRow) =>
            {
                int patientId = Convert.ToInt32(patientRow["patient_id"]);
                string patientName = patientRow["ФИО"].ToString() ?? "Неизвестный пациент";
                OpenHistorySelector(patientId, patientName);
            };
            ShowControl(searchControl);
        }
        private void OpenHistorySelector(int patientId, string patientName)
        {
            var historySelector = new PatientHistorySelector(patientId, patientName);
            historySelector.OnClosed += () => OpenPatientSearch();
            historySelector.OnHistorySelected += (historyId) =>
            {
                OpenTreatmentForm(historyId, patientId, patientName);
            };

            ShowControl(historySelector);
        }
        private void OpenTreatmentForm(int historyId, int patientId, string patientName)
        {
            var treatmentForm = new DoctorTreatmentForm(historyId);
            treatmentForm.OnClosed += () => OpenHistorySelector(patientId, patientName);
            ShowControl(treatmentForm);
        }
        public void ShowControl(IWindowClosed newControl)
        {
            foreach (Control control in MainPanel.Controls)
                control.Dispose();
            if (newControl is UserControl uiControl)
            {
                MainPanel.Controls.Clear();
                SetPanelState(ChoiceSearchParameterPanel, false);
                SetPanelState(MainPanel, true);
                uiControl.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(uiControl);
            }
        }
        public void Reversion()
        {
            MainPanel.Controls.Clear();
            SetPanelState(ChoiceSearchParameterPanel, true);
            SetPanelState(MainPanel, false);
        }
        private void SetPanelState(Panel panel, bool visible)
        {
            panel.Visible = visible;
            panel.Enabled = visible;
        }

        private void SearchByListRadioButton_CheckedChanged(object sender, EventArgs e)
            => OpenPatientSearchByList();

        private void SearchByPassportRadioButton_CheckedChanged(object sender, EventArgs e)
            => OpenPatientSearchByPassport();
        private void OpenPatientSearchByList()
        {
            var searchControl = new GetPersonFromList(ViewListMode.Patients);

            searchControl.OnItemSelected += (patientRow) => 
            {
                int patientId = Convert.ToInt32(patientRow["patient_id"]);
                string patientName = patientRow["ФИО"].ToString() ?? "Неизвестный пациент";
                OpenHistorySelector(patientId, patientName);
            };
            ShowControl(searchControl);
        }
        private void OpenPatientSearchByPassport()
        {

            var passportControl = new PassportSearching("Введите данные пациента");

            passportControl.OnUserFound += (patientRow) => 
            {
                ValidateTakenData.IsNeededRole(patientRow, "Пациент");
                int patientId = Convert.ToInt32(patientRow["patient_id"]);
                string patientName = GeneralMethods.GetPatientFullName(patientRow);
                OpenHistorySelector(patientId, patientName);
            };
            passportControl.OnClosed += () => Reversion();
            ShowControl(passportControl);
        }
    }
}
