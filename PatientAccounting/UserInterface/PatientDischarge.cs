using PatientAccounting.Data;
using PatientAccounting.Interfaces;
namespace PatientAccounting.UserInterface
{
    public partial class PatientDischarge : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        public PatientDischarge()
        {
            InitializeComponent();
            InitializeDataGrid();
        }
        private void InitializeDataGrid()
        {
            PatientsDataGridView.DataSource = DataBaseProcessing.GetPatientsWithoutDischarge();
            if (PatientsDataGridView.Columns.Contains("ID"))
                PatientsDataGridView.Columns["ID"].Visible = false;
        }
        private void PatientDischargeButton_Click(object sender, EventArgs e)
        {
            if (PatientsDataGridView.CurrentRow == null) return;
            int historyId = Convert.ToInt32(PatientsDataGridView.CurrentRow.Cells["ID"].Value);
            string patientName = PatientsDataGridView.CurrentRow.Cells["ФИО Пациента"].Value.ToString();
            var result = MessageBox.Show($"Выписать пациента {patientName}?", "Выписка",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (DataBaseProcessing.DischargePatient(historyId))
                {
                    MessageBox.Show("Пациент успешно выписан.");
                    InitializeDataGrid();
                }
            }
        }
        private void ExitToMenuButton_Click(object sender, EventArgs e) => OnClosed?.Invoke();
    }
}
