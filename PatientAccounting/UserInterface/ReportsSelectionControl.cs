using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using PatientAccounting.Models;
namespace PatientAccounting.UserInterface
{
    public partial class ReportsSelectionControl : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        private ActiveReport _currentReport = ActiveReport.Occupancy;
        public ReportsSelectionControl()
        {
            InitializeComponent();
            SetDefaultData();
            ShowWorkLoadReport();
        }
        private void SetDefaultData()
        {
            FromDatePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            ToDatePicker.Value = DateTime.Now;
        }
        private void RefreshDateReport()
        {
            if (FromDatePicker.Value > ToDatePicker.Value)
            {
                MessageBox.Show("Дата 'С' не может быть больше даты 'По'!", "Ошибка диапазона", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_currentReport == ActiveReport.TopDiseases)
                ReportGrid.DataSource = DataBaseProcessing.GetTopDiseasesReport(FromDatePicker.Value, ToDatePicker.Value);
            else if (_currentReport == ActiveReport.Movement)
                ReportGrid.DataSource = DataBaseProcessing.GetPatientMovementReport(FromDatePicker.Value, ToDatePicker.Value);
        }
        private void ShowWorkLoadReport()
        {
            _currentReport = ActiveReport.Occupancy;
            FromDatePicker.Enabled = false;
            ToDatePicker.Enabled = false;
            ReportGrid.DataSource = DataBaseProcessing.GetHospitalOccupancyReport();
        }
        private void TopDiseasesReport()
        {
            _currentReport = ActiveReport.TopDiseases;
            FromDatePicker.Enabled = true;
            ToDatePicker.Enabled = true;
            RefreshDateReport();
        }
        private void MovementReport()
        {
            _currentReport = ActiveReport.Movement;
            FromDatePicker.Enabled = true;
            ToDatePicker.Enabled = true;
            RefreshDateReport();
        }
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (_currentReport != ActiveReport.Occupancy)
                RefreshDateReport();
        }
        private void WorkloadButton_Click(object sender, EventArgs e)
            => ShowWorkLoadReport();

        private void CancelButton_Click(object sender, EventArgs e)
            => OnClosed?.Invoke();

        private void PopularDiseasesButton_Click(object sender, EventArgs e)
            => TopDiseasesReport();

        private void PatientMovementButton_Click(object sender, EventArgs e)
            => MovementReport();
    }
}
