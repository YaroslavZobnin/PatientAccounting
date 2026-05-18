namespace PatientAccounting.UserInterface
{
    partial class PatientHistorySelector
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
            HistoriesGrid = new DataGridView();
            SwapModeButton = new Button();
            TransitionToTreatment = new Button();
            SearchByDate = new DateTimePicker();
            SearchByDatePanel = new Panel();
            SearchByDateLabel = new Label();
            PatientLabel = new Label();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)HistoriesGrid).BeginInit();
            SearchByDatePanel.SuspendLayout();
            SuspendLayout();
            // 
            // HistoriesGrid
            // 
            HistoriesGrid.AllowUserToAddRows = false;
            HistoriesGrid.AllowUserToDeleteRows = false;
            HistoriesGrid.Anchor = AnchorStyles.Top;
            HistoriesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HistoriesGrid.BackgroundColor = SystemColors.Control;
            HistoriesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoriesGrid.Location = new Point(56, 98);
            HistoriesGrid.Name = "HistoriesGrid";
            HistoriesGrid.RowHeadersWidth = 51;
            HistoriesGrid.Size = new Size(598, 359);
            HistoriesGrid.TabIndex = 0;
            // 
            // SwapModeButton
            // 
            SwapModeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SwapModeButton.BackColor = Color.Transparent;
            SwapModeButton.Cursor = Cursors.Hand;
            SwapModeButton.FlatStyle = FlatStyle.Popup;
            SwapModeButton.Location = new Point(635, 469);
            SwapModeButton.Name = "SwapModeButton";
            SwapModeButton.Size = new Size(98, 27);
            SwapModeButton.TabIndex = 1;
            SwapModeButton.Text = "Архив";
            SwapModeButton.UseVisualStyleBackColor = false;
            SwapModeButton.Click += SwapModeButton_Click;
            // 
            // TransitionToTreatment
            // 
            TransitionToTreatment.Anchor = AnchorStyles.Bottom;
            TransitionToTreatment.BackColor = Color.Transparent;
            TransitionToTreatment.Cursor = Cursors.Hand;
            TransitionToTreatment.FlatStyle = FlatStyle.Popup;
            TransitionToTreatment.Location = new Point(245, 470);
            TransitionToTreatment.Name = "TransitionToTreatment";
            TransitionToTreatment.Size = new Size(178, 26);
            TransitionToTreatment.TabIndex = 2;
            TransitionToTreatment.Text = "К лечению";
            TransitionToTreatment.UseVisualStyleBackColor = false;
            TransitionToTreatment.Click += TransitionToTreatment_Click;
            // 
            // SearchByDate
            // 
            SearchByDate.Anchor = AnchorStyles.Top;
            SearchByDate.Location = new Point(41, 31);
            SearchByDate.Name = "SearchByDate";
            SearchByDate.Size = new Size(188, 27);
            SearchByDate.TabIndex = 3;
            SearchByDate.Value = new DateTime(2026, 5, 18, 16, 54, 24, 0);
            // 
            // SearchByDatePanel
            // 
            SearchByDatePanel.Controls.Add(SearchByDateLabel);
            SearchByDatePanel.Controls.Add(SearchByDate);
            SearchByDatePanel.Location = new Point(245, 30);
            SearchByDatePanel.Name = "SearchByDatePanel";
            SearchByDatePanel.Size = new Size(266, 62);
            SearchByDatePanel.TabIndex = 4;
            // 
            // SearchByDateLabel
            // 
            SearchByDateLabel.Anchor = AnchorStyles.Top;
            SearchByDateLabel.AutoSize = true;
            SearchByDateLabel.BackColor = Color.Transparent;
            SearchByDateLabel.Location = new Point(88, 8);
            SearchByDateLabel.Name = "SearchByDateLabel";
            SearchByDateLabel.Size = new Size(108, 20);
            SearchByDateLabel.TabIndex = 4;
            SearchByDateLabel.Text = "Поиск по дате";
            // 
            // PatientLabel
            // 
            PatientLabel.Anchor = AnchorStyles.Top;
            PatientLabel.BackColor = Color.Transparent;
            PatientLabel.Location = new Point(161, 3);
            PatientLabel.Name = "PatientLabel";
            PatientLabel.Size = new Size(447, 24);
            PatientLabel.TabIndex = 5;
            PatientLabel.Text = "Пациент:";
            PatientLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExitButton.BackColor = Color.Transparent;
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.Location = new Point(11, 469);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(69, 27);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Меню";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += BackButton_Click;
            // 
            // PatientHistorySelector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ExitButton);
            Controls.Add(PatientLabel);
            Controls.Add(SearchByDatePanel);
            Controls.Add(TransitionToTreatment);
            Controls.Add(SwapModeButton);
            Controls.Add(HistoriesGrid);
            Name = "PatientHistorySelector";
            Size = new Size(736, 503);
            ((System.ComponentModel.ISupportInitialize)HistoriesGrid).EndInit();
            SearchByDatePanel.ResumeLayout(false);
            SearchByDatePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView HistoriesGrid;
        private Button SwapModeButton;
        private Button TransitionToTreatment;
        private DateTimePicker SearchByDate;
        private Panel SearchByDatePanel;
        private Label SearchByDateLabel;
        private Label PatientLabel;
        private Button ExitButton;
    }
}
