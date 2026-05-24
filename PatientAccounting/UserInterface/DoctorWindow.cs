using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using PatientAccounting.Models;
using PatientAccounting.Services;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class DoctorWindow : UserControl, IPresenter
    {
        private Staff _staff;
        private bool _showArchive = false;
        public DoctorWindow(Staff staff)
        {
            InitializeComponent();
            _staff = staff;
            InitializeFullName();
            Reversion();
        }
        private void InitializeFullName() => FullNameLabel.Text = GeneralMethods.GetFullName(_staff);
        private void OpenHistorySelector(int patientId, string patientName)
        {
            var historySelector = new PatientHistorySelector(patientId, patientName, _staff.StaffId, _showArchive);
            historySelector.OnClosed += () => Reversion();
            historySelector.OnHistorySelected += (historyId) => OpenTreatmentForm(historyId, patientId, patientName);
            ShowControl(historySelector);
        }
        private void OpenTreatmentForm(int historyId, int patientId, string patientName)
        {
            var treatmentForm = new DoctorTreatmentForm(historyId, _showArchive);
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
                CurrentPatientsButton.Enabled = false;
                ArchivePatientsButton.Enabled = false;
                uiControl.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(uiControl);
            }
        }
        public void Reversion()
        {
            MainPanel.Controls.Clear();
            SetPanelState(ChoiceSearchParameterPanel, true);
            SetPanelState(MainPanel, false);
            CurrentPatientsButton.Enabled = true;
            ArchivePatientsButton.Enabled = true;
        }
        private void SetPanelState(Panel panel, bool visible)
        {
            panel.Visible = visible;
            panel.Enabled = visible;
        }
        private void OpenPatientSearchByList()
        {
            try
            {
                DataTable patientsData = DataBaseProcessing.GetPatientsByStatus(_showArchive);
                var searchControl = new GetPersonFromList(patientsData, _showArchive);

                searchControl.OnItemSelected += (patientRow) =>
                {
                    int patientId = Convert.ToInt32(patientRow["patient_id"]);
                    string patientName = patientRow["ФИО"].ToString() ?? "Неизвестный пациент";
                    OpenHistorySelector(patientId, patientName);
                };
                searchControl.OnClosed += () => Reversion();
                ShowControl(searchControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при формировании списка: {ex.Message}");
            }
        }
        private void OpenPatientSearchByPassport()
        {
            var passportControl = new PassportSearching("Введите данные пациента");

            passportControl.OnUserFound += (patientRow) =>
            {
                ValidateTakenData.IsNeededRole(patientRow, "Пациент");

                int patientId = Convert.ToInt32(patientRow["patient_id"]);
                string patientName = GeneralMethods.GetPatientFullName(patientRow);
                bool isCorrectStatus = DataBaseProcessing.HasHistoryInStatus(patientId, _showArchive);

                if (isCorrectStatus)
                    OpenHistorySelector(patientId, patientName);
                else
                {
                    string modeName = _showArchive ? "в «Архиве»" : "среди «Текущих пациентов»";
                    MessageBox.Show($"Пациент найден, но у него нет историй болезни {modeName}.",
                                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            passportControl.OnClosed += () => Reversion();
            ShowControl(passportControl);
        }

        private void SearchByListButton_Click(object sender, EventArgs e) => OpenPatientSearchByList();

        private void SearchByPassportButton_Click(object sender, EventArgs e) => OpenPatientSearchByPassport();

        private void CurrentPatientsButton_Click(object sender, EventArgs e)
            => CurrentPatientsActiveButton();
        private void CurrentPatientsActiveButton()
        {
            _showArchive = false;
            CurrentPatientsButton.FlatAppearance.BorderColor = Color.Blue;
            CurrentPatientsButton.FlatAppearance.BorderSize = 2;
            ArchivePatientsButton.FlatAppearance.BorderColor = Color.LightGray;
            ArchivePatientsButton.FlatAppearance.BorderSize = 1;
        }

        private void ArchivePatientsButton_Click(object sender, EventArgs e)
            => ArchivePatientsActiveButton();

        private void ArchivePatientsActiveButton()
        {
            _showArchive = true;
            ArchivePatientsButton.FlatAppearance.BorderColor = Color.Blue;
            ArchivePatientsButton.FlatAppearance.BorderSize = 2;
            CurrentPatientsButton.FlatAppearance.BorderColor = Color.LightGray;
            CurrentPatientsButton.FlatAppearance.BorderSize = 1;
        }
    }
}
