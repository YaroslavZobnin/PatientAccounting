using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using PatientAccounting.Models;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
namespace PatientAccounting.UserInterface
{
    public partial class ReportsSelectionControl : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        private ActiveReport _currentReport = ActiveReport.Occupancy;

        private const string _informationAboutWorkload =
            "Данный отчёт показывает загруженность палат.";
        private const string _informationAboutTopDisease =
            "Данная статистика показывает популярность болезни за выбранный период времени.";
        private const string _informationAboutMovementReport =
            "Данный отчёт показывает, сколько пациентов поступили и сколько выписано в каждом отделении за выбранный период времени.";
        public ReportsSelectionControl()
        {
            InitializeComponent();
            SetDefaultData();
            ShowWorkLoadReport();
            InitializeInformationAboutReport(_informationAboutWorkload);
        }
        private void SetPanelState(Panel panel, bool visible)
        {
            panel.Visible = visible;
            panel.Enabled = visible;
        }
        private void SetCheckBoxState(CheckBox cb, bool visible)
        {
            cb.Visible = visible;
            cb.Enabled = visible;
            if (!visible)
                cb.Checked = false;
        }
        private void InitializeInformationAboutReport(string info)
            => InformationAboutReportLabel.Text = info;
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
            {
                ReportGrid.DataSource = DataBaseProcessing.GetTopDiseasesReport(FromDatePicker.Value, ToDatePicker.Value);
                if (ViewToggleCheckBox.Checked)
                {
                    UpdateChart();
                }
            }
            else if (_currentReport == ActiveReport.Movement)
            {
                ReportGrid.DataSource = DataBaseProcessing.GetPatientMovementReport(FromDatePicker.Value, ToDatePicker.Value);
            }
        }
        private void ShowWorkLoadReport()
        {
            _currentReport = ActiveReport.Occupancy;
            FromDatePicker.Enabled = false;
            ToDatePicker.Enabled = false;
            SetCheckBoxState(ViewToggleCheckBox, false);
            SetPanelState(ChartPanel, false);
            InitializeInformationAboutReport(_informationAboutWorkload);
            ReportGrid.DataSource = DataBaseProcessing.GetHospitalOccupancyReport();
        }
        private void TopDiseasesReport()
        {
            _currentReport = ActiveReport.TopDiseases;
            FromDatePicker.Enabled = true;
            ToDatePicker.Enabled = true;
            SetCheckBoxState(ViewToggleCheckBox, true);
            bool showChart = ViewToggleCheckBox.Checked;
            ReportGrid.Visible = !showChart;
            ChartPanel.Visible = showChart;
            if (showChart)
                ChartPanel.BringToFront();
            else
                ReportGrid.BringToFront();
            InitializeInformationAboutReport(_informationAboutTopDisease);
            RefreshDateReport();
        }
        private void MovementReport()
        {
            _currentReport = ActiveReport.Movement;
            FromDatePicker.Enabled = true;
            ToDatePicker.Enabled = true;
            SetCheckBoxState(ViewToggleCheckBox, false);
            InitializeInformationAboutReport(_informationAboutMovementReport);
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

        private void ViewToggleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool showChart = ViewToggleCheckBox.Checked;

            ReportGrid.Visible = !showChart;
            ChartPanel.Visible = showChart;

            if (showChart)
            {
                ChartPanel.BringToFront(); 
                UpdateChart();
            }
            else
            {
                ReportGrid.BringToFront(); 
            }
        }
        private void UpdateChart()
        {
            ChartPanel.Controls.Clear();
            if (ReportGrid.DataSource == null) return;

            Chart pieChart = new Chart();
            pieChart.Dock = DockStyle.Fill;

            ChartArea area = new ChartArea("PieArea");
            pieChart.ChartAreas.Add(area);

            Series series = new Series("DiseasesSeries");
            series.ChartType = SeriesChartType.Pie;

            DataTable topDiseases = (DataTable)ReportGrid.DataSource;

            foreach (DataRow row in topDiseases.Rows)
            {
                string label = row["Название болезни"].ToString();
                double value = Convert.ToDouble(row["Количество случаев"]);

                int pointIndex = series.Points.AddY(value);
                series.Points[pointIndex].LegendText = label;
                series.Points[pointIndex].Label = "#PERCENT{P0}";
            }

            pieChart.Series.Add(series);

            Legend legend = new Legend("MainLegend");
            pieChart.Legends.Add(legend);

            ChartPanel.Controls.Add(pieChart);
        }
    }
}
