using PatientAccounting.Data;
using PatientAccounting.Models;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class GeneralListView : UserControl
    {
        private ViewListMode _currentMode;
        private string _userRole;
        public GeneralListView(string userRole)
        {
            InitializeComponent();
            _userRole = userRole;
            ConfigureInterface();
            ConfigureButtons();
        }
        private void ConfigureButtons()
        {
            if (!AccessManager.CanView(_userRole, _currentMode))
            {
                this.Controls.Clear();
                this.Controls.Add(new Label { Text = "Доступ запрещен", Dock = DockStyle.Fill });
                return;
            }
            bool editable = AccessManager.CanEdit(_userRole, _currentMode);
            SetButtonState(EditButton, editable);
            SetButtonState(DeleteButton, editable);
        }
        private void ConfigureInterface()
        {
            SetRadioButtonState(PatientListRadioButton, true);
            if(_userRole == "Главврач")
            {
                SetRadioButtonState(DiseaseRadioButton, true);
                SetRadioButtonState(WardsRadioButton, true);
                SetRadioButtonState(TreatmentRadioButton, true);
                SetRadioButtonState(StaffRadioButton, true);
            }
            else
                SetRadioButtonState(DoctorListRadioButton, true);
        }
        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton == null || !radioButton.Checked) return;
            DefinitionMode(radioButton.Text);
            DisplayData(DataBaseProcessing.GetListByMode(_currentMode));
            SetPanelState(OutputListPanel, true);
        }
        private void DisplayData(DataTable dataTable)
        {
            OutputInfoDataGridView.DataSource = dataTable;
            if (OutputInfoDataGridView.Columns.Contains("ID"))
                OutputInfoDataGridView.Columns["ID"].Visible = false;
        }
        private void DefinitionMode(string currentRadioButton)
        {
            switch (currentRadioButton)
            {
                case "Пациенты":
                    _currentMode = ViewListMode.Patients;
                    break;
                case "Лечащие врачи":
                    _currentMode = ViewListMode.Doctors;
                    break;
                case "Болезни":
                    _currentMode = ViewListMode.Diseases;
                    break;
                case "Палаты":
                    _currentMode = ViewListMode.Wards;
                    break;
                case "Лечение":
                    _currentMode = ViewListMode.Treatments;
                    break;
                case "Персонал":
                    _currentMode = ViewListMode.Staff;
                    break;
                default:
                    MessageBox.Show("Ошибка!\nВыбранной роли не существует.");
                    break;
            }
        }
        private void SetRadioButtonState(RadioButton radioButton, bool visible)
        {
            radioButton.Visible = visible;
            radioButton.Enabled = visible;
        }
        private void SetPanelState(Panel panel, bool visible)
        {
            panel.Visible = visible;
            panel.Enabled = visible;
        }
        private void SetButtonState(Button button, bool visible)
        {
            button.Visible = visible;
            button.Enabled = visible;
        }
    }
}
