using PatientAccounting.Data;
using PatientAccounting.Models;
using System.Data;
using PatientAccounting.Interfaces;
namespace PatientAccounting.UserInterface
{
    public partial class GeneralListView : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        private ViewListMode _currentMode;
        private string _userRole;
        public GeneralListView(string userRole)
        {
            InitializeComponent();
            _userRole = userRole;
            ConfigureInterface();
        }
        private void ConfigureInterface()
        {
            SetRadioButtonState(PatientListRadioButton, true);
            if (_userRole == "Главврач")
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
        private void DisplayData(DataTable dataTable)
        {
            OutputInfoDataGridView.DataSource = dataTable;
            HideColumnIfExists("ID");
            HideColumnIfExists("department_id");
            HideColumnIfExists("type_of_ward_id");
            HideColumnIfExists("category_id");
            HideColumnIfExists("role_name");
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
        private void HideColumnIfExists(string columnName)
        {
            if (OutputInfoDataGridView.Columns.Contains(columnName))
            {
                OutputInfoDataGridView.Columns[columnName].Visible = false;
            }
        }
        private void ExitToMenuButton_Click(object sender, EventArgs e) => OnClosed?.Invoke();
    }
}
