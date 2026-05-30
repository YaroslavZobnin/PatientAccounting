namespace PatientAccounting.UserInterface
{
    partial class ReportsSelectionControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            WorkWithInformationLabel = new Label();
            CancelButton = new Button();
            FromDatePicker = new DateTimePicker();
            ToDatePicker = new DateTimePicker();
            FromDatePickerLabel = new Label();
            ToDatePickerLabel = new Label();
            WorkloadButton = new Button();
            PopularDiseasesButton = new Button();
            PatientMovementButton = new Button();
            ChoiceReportsLabel = new Label();
            ReportGrid = new DataGridView();
            InformationAboutReportLabel = new Label();
            ViewToggleCheckBox = new CheckBox();
            ChartPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)ReportGrid).BeginInit();
            SuspendLayout();
            // 
            // WorkWithInformationLabel
            // 
            WorkWithInformationLabel.Anchor = AnchorStyles.Top;
            WorkWithInformationLabel.AutoSize = true;
            WorkWithInformationLabel.BackColor = Color.Transparent;
            WorkWithInformationLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            WorkWithInformationLabel.Location = new Point(301, 0);
            WorkWithInformationLabel.Name = "WorkWithInformationLabel";
            WorkWithInformationLabel.Size = new Size(288, 25);
            WorkWithInformationLabel.TabIndex = 0;
            WorkWithInformationLabel.Text = "Работа с информацией (отчёты)";
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.BackColor = Color.Transparent;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Location = new Point(3, 380);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Назад";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // FromDatePicker
            // 
            FromDatePicker.Anchor = AnchorStyles.Top;
            FromDatePicker.Location = new Point(317, 37);
            FromDatePicker.Name = "FromDatePicker";
            FromDatePicker.Size = new Size(184, 27);
            FromDatePicker.TabIndex = 2;
            FromDatePicker.ValueChanged += DatePicker_ValueChanged;
            // 
            // ToDatePicker
            // 
            ToDatePicker.Anchor = AnchorStyles.Top;
            ToDatePicker.Location = new Point(641, 37);
            ToDatePicker.Name = "ToDatePicker";
            ToDatePicker.Size = new Size(184, 27);
            ToDatePicker.TabIndex = 3;
            ToDatePicker.ValueChanged += DatePicker_ValueChanged;
            // 
            // FromDatePickerLabel
            // 
            FromDatePickerLabel.Anchor = AnchorStyles.Top;
            FromDatePickerLabel.AutoSize = true;
            FromDatePickerLabel.BackColor = Color.Transparent;
            FromDatePickerLabel.Location = new Point(192, 40);
            FromDatePickerLabel.Name = "FromDatePickerLabel";
            FromDatePickerLabel.Size = new Size(119, 20);
            FromDatePickerLabel.TabIndex = 4;
            FromDatePickerLabel.Text = "Начальная дата";
            // 
            // ToDatePickerLabel
            // 
            ToDatePickerLabel.Anchor = AnchorStyles.Top;
            ToDatePickerLabel.AutoSize = true;
            ToDatePickerLabel.BackColor = Color.Transparent;
            ToDatePickerLabel.Location = new Point(524, 42);
            ToDatePickerLabel.Name = "ToDatePickerLabel";
            ToDatePickerLabel.Size = new Size(111, 20);
            ToDatePickerLabel.TabIndex = 5;
            ToDatePickerLabel.Text = "Конечная дата";
            // 
            // WorkloadButton
            // 
            WorkloadButton.Anchor = AnchorStyles.Left;
            WorkloadButton.BackColor = Color.Transparent;
            WorkloadButton.FlatStyle = FlatStyle.Popup;
            WorkloadButton.Location = new Point(12, 83);
            WorkloadButton.Name = "WorkloadButton";
            WorkloadButton.Size = new Size(128, 44);
            WorkloadButton.TabIndex = 6;
            WorkloadButton.Text = "Загруженность";
            WorkloadButton.UseVisualStyleBackColor = false;
            WorkloadButton.Click += WorkloadButton_Click;
            // 
            // PopularDiseasesButton
            // 
            PopularDiseasesButton.Anchor = AnchorStyles.Left;
            PopularDiseasesButton.BackColor = Color.Transparent;
            PopularDiseasesButton.FlatStyle = FlatStyle.Popup;
            PopularDiseasesButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PopularDiseasesButton.Location = new Point(12, 133);
            PopularDiseasesButton.Name = "PopularDiseasesButton";
            PopularDiseasesButton.Size = new Size(128, 44);
            PopularDiseasesButton.TabIndex = 7;
            PopularDiseasesButton.Text = "Популярные болезни";
            PopularDiseasesButton.UseVisualStyleBackColor = false;
            PopularDiseasesButton.Click += PopularDiseasesButton_Click;
            // 
            // PatientMovementButton
            // 
            PatientMovementButton.Anchor = AnchorStyles.Left;
            PatientMovementButton.BackColor = Color.Transparent;
            PatientMovementButton.FlatStyle = FlatStyle.Popup;
            PatientMovementButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PatientMovementButton.Location = new Point(12, 183);
            PatientMovementButton.Name = "PatientMovementButton";
            PatientMovementButton.Size = new Size(128, 44);
            PatientMovementButton.TabIndex = 8;
            PatientMovementButton.Text = "Движение пациентов";
            PatientMovementButton.UseVisualStyleBackColor = false;
            PatientMovementButton.Click += PatientMovementButton_Click;
            // 
            // ChoiceReportsLabel
            // 
            ChoiceReportsLabel.Anchor = AnchorStyles.Left;
            ChoiceReportsLabel.AutoSize = true;
            ChoiceReportsLabel.BackColor = Color.Transparent;
            ChoiceReportsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChoiceReportsLabel.Location = new Point(3, 60);
            ChoiceReportsLabel.Name = "ChoiceReportsLabel";
            ChoiceReportsLabel.Size = new Size(147, 20);
            ChoiceReportsLabel.TabIndex = 9;
            ChoiceReportsLabel.Text = "Возможные отчёты";
            // 
            // ReportGrid
            // 
            ReportGrid.AllowUserToAddRows = false;
            ReportGrid.AllowUserToDeleteRows = false;
            ReportGrid.Anchor = AnchorStyles.Top;
            ReportGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReportGrid.BackgroundColor = SystemColors.ButtonHighlight;
            ReportGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportGrid.Location = new Point(182, 83);
            ReportGrid.Name = "ReportGrid";
            ReportGrid.ReadOnly = true;
            ReportGrid.RowHeadersWidth = 51;
            ReportGrid.Size = new Size(643, 278);
            ReportGrid.TabIndex = 10;
            // 
            // InformationAboutReportLabel
            // 
            InformationAboutReportLabel.Anchor = AnchorStyles.Bottom;
            InformationAboutReportLabel.BackColor = Color.Transparent;
            InformationAboutReportLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            InformationAboutReportLabel.Location = new Point(182, 364);
            InformationAboutReportLabel.Name = "InformationAboutReportLabel";
            InformationAboutReportLabel.Size = new Size(643, 43);
            InformationAboutReportLabel.TabIndex = 11;
            InformationAboutReportLabel.Text = "текст об отчёте";
            InformationAboutReportLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ViewToggleCheckBox
            // 
            ViewToggleCheckBox.Anchor = AnchorStyles.Left;
            ViewToggleCheckBox.AutoSize = true;
            ViewToggleCheckBox.BackColor = Color.Transparent;
            ViewToggleCheckBox.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ViewToggleCheckBox.Location = new Point(12, 275);
            ViewToggleCheckBox.Name = "ViewToggleCheckBox";
            ViewToggleCheckBox.Size = new Size(154, 21);
            ViewToggleCheckBox.TabIndex = 12;
            ViewToggleCheckBox.Text = "Показать диаграмму";
            ViewToggleCheckBox.UseVisualStyleBackColor = false;
            ViewToggleCheckBox.CheckedChanged += ViewToggleCheckBox_CheckedChanged;
            // 
            // ChartPanel
            // 
            ChartPanel.Anchor = AnchorStyles.Top;
            ChartPanel.BackColor = Color.Transparent;
            ChartPanel.Enabled = false;
            ChartPanel.Location = new Point(178, 83);
            ChartPanel.Name = "ChartPanel";
            ChartPanel.Size = new Size(665, 278);
            ChartPanel.TabIndex = 13;
            ChartPanel.Visible = false;
            // 
            // ReportsSelectionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ViewToggleCheckBox);
            Controls.Add(InformationAboutReportLabel);
            Controls.Add(ChoiceReportsLabel);
            Controls.Add(PatientMovementButton);
            Controls.Add(PopularDiseasesButton);
            Controls.Add(WorkloadButton);
            Controls.Add(ToDatePickerLabel);
            Controls.Add(FromDatePickerLabel);
            Controls.Add(ToDatePicker);
            Controls.Add(FromDatePicker);
            Controls.Add(CancelButton);
            Controls.Add(WorkWithInformationLabel);
            Controls.Add(ChartPanel);
            Controls.Add(ReportGrid);
            Name = "ReportsSelectionControl";
            Size = new Size(860, 412);
            ((System.ComponentModel.ISupportInitialize)ReportGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WorkWithInformationLabel;
        private Button CancelButton;
        private DateTimePicker FromDatePicker;
        private DateTimePicker ToDatePicker;
        private Label FromDatePickerLabel;
        private Label ToDatePickerLabel;
        private Button WorkloadButton;
        private Button PopularDiseasesButton;
        private Button PatientMovementButton;
        private Label ChoiceReportsLabel;
        private DataGridView ReportGrid;
        private Label InformationAboutReportLabel;
        private CheckBox ViewToggleCheckBox;
        private Panel ChartPanel;
    }
}
