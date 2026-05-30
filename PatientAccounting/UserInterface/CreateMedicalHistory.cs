using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using PatientAccounting.Models;
using PatientAccounting.Services;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class CreateMedicalHistory : UserControl, IPresenter, IWindowClosed
    {
        public event Action? OnClosed;
        public CreateMedicalHistory()
        {
            InitializeComponent();
        }
        private void GetPatientFromPassportRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!GetPatientFromPassportRadioButton.Checked) return;
            var passport = new PassportSearching("Введите пациента", false);
            passport.OnUserFound += OnPatientSelected;
            passport.OnClosed += Reversion;
            SetPanelState(ChoicePanel, false);
            SetPanelState(ContentPanel, true);
            ShowControl(passport);
        }

        private void GetPatientFromListRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!GetPatientFromListRadioButton.Checked) return;
            var patientList = new GetPersonFromList(ViewListMode.Patients);
            patientList.OnItemSelected += OnPatientSelected;
            patientList.OnClosed += Reversion;
            SetPanelState(ChoicePanel, false);
            SetPanelState(ContentPanel, true);
            ShowControl(patientList);
        }
        private void OnPatientSelected(DataRow row)
        {
            try
            {
                ValidateTakenData.IsNeededRole(row, "Пациент");
                int id = Convert.ToInt32(row["patient_id"]);
                if (DataBaseProcessing.HasHistoryInStatus(id, lookInArchive: false))
                {
                    MessageBox.Show("Этот пациент уже находится на лечении! Нельзя создать новую историю болезни, пока текущая не закрыта (пациент не выписан).",
                                    "Пациент уже лечится", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Reversion(); 
                    return;
                }
                string name = GeneralMethods.GetPatientFullName(row);
                SetPanelState(ChoicePanel, false);
                var entryForm = new MedicalHistoryEntryForm(id, name);
                entryForm.OnClosed += () => OnClosed?.Invoke();
                ShowControl(entryForm);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Reversion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reversion();
            }
        }
        public void ShowControl(IWindowClosed newControl)
        {
            foreach (Control control in ContentPanel.Controls)
                control.Dispose();
            if (newControl is UserControl uiControl)
            {
                ContentPanel.Controls.Clear();
                uiControl.Dock = DockStyle.Fill;
                ContentPanel.Controls.Add(uiControl);
            }
        }
        public void Reversion()
        {
            ContentPanel.Controls.Clear();
            SetPanelState(ChoicePanel, true);
            SetPanelState(ContentPanel, false);
        }
        private void SetPanelState(Panel panel, bool visible)
        {
            panel.Visible = visible;
            panel.Enabled = visible;
        }
        private void CancelButton_Click(object sender, EventArgs e) => OnClosed?.Invoke();
    }
}
