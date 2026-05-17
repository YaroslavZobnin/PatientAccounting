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
            var passport = new PassportSearching("Введите пациента");
            passport.OnUserFound += OnPatientSelected;
            ShowControl(passport);
        }
        private void GetPatientFromListRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var patientList = new GetPersonFromList(ViewListMode.Patients);
            patientList.OnItemSelected += OnPatientSelected;
            ShowControl(patientList);
        }
        private void OnPatientSelected(DataRow row)
        {
            try
            {
                ValidateTakenData.IsNeededRole(row, "Пациент");
                int id = Convert.ToInt32(row["patient_id"]);
                string? name = row["ФИО"].ToString();
                SetPanelState(ChoicePanel, false);
                var entryForm = new MedicalHistoryEntryForm(id, name);
                entryForm.OnClosed += () => OnClosed?.Invoke();
                ShowControl(entryForm);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
