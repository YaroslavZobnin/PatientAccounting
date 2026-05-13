using PatientAccounting.Data;
using PatientAccounting.Models;
namespace PatientAccounting.UserInterface
{
    public partial class CreateMedicalHistory : UserControl
    {
        public CreateMedicalHistory()
        {
            InitializeComponent();

        }
        private void SetPanelState(Panel panel, bool visibility)
        {
            panel.Visible = visibility;
            panel.Enabled = visibility;
        }
        private void SetDataGridView(DataGridView dgv, bool visibility)
        {
            dgv.Visible = visibility;
            dgv.Enabled = visibility;
        }
        private void ResetSearch()
        {
            SetDataGridView(PatientsListDataGridView, false);

        }
        private void InitializeDataGrid()
        {
            PatientsListDataGridView.DataSource = DataBaseProcessing.GetListByMode(ViewListMode.Patients);
            if (PatientsListDataGridView.Columns.Contains("ID"))
                PatientsListDataGridView.Columns["ID"].Visible = false;
        }
        //private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        //{
        //    var radioButton = sender as RadioButton;
        //    if (radioButton == null || !radioButton.Checked) return;
        //    if (radioButton.Text == "По списку")
        //    {
        //        InitializeDataGrid();
        //        SetDataGridView(PatientsListDataGridView, true);
        //    }
        //    else
        //    {

        //    }
        //}
        private void GetPatientFromPassportRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void GetPatientFromListRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            InitializeDataGrid();
            SetDataGridView(PatientsListDataGridView, true);
        }
    }
}
