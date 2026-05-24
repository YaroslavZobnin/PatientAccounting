namespace PatientAccounting.UserInterface
{
    partial class DoctorTreatmentForm
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
            DiseaseComboBox = new ComboBox();
            SaveButton = new Button();
            WardsComboBox = new ComboBox();
            CancelButton = new Button();
            DiseaseLabel = new Label();
            TreatmentLabel = new Label();
            WardLabel = new Label();
            DateOfReceipt = new DateTimePicker();
            DateOfReceiptLabel = new Label();
            TreatmentDataGrid = new DataGridView();
            ChoiceTreatmentPanel = new Panel();
            AddTreatmentButton = new Button();
            TreatmenInfoLabel = new Label();
            ChoiceTreatmentLabel = new Label();
            TreatmentComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)TreatmentDataGrid).BeginInit();
            ChoiceTreatmentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DiseaseComboBox
            // 
            DiseaseComboBox.Anchor = AnchorStyles.Top;
            DiseaseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DiseaseComboBox.FormattingEnabled = true;
            DiseaseComboBox.Location = new Point(146, 14);
            DiseaseComboBox.Name = "DiseaseComboBox";
            DiseaseComboBox.Size = new Size(247, 28);
            DiseaseComboBox.TabIndex = 0;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom;
            SaveButton.BackColor = Color.Transparent;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Location = new Point(376, 392);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(118, 33);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // WardsComboBox
            // 
            WardsComboBox.Anchor = AnchorStyles.Top;
            WardsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WardsComboBox.FormattingEnabled = true;
            WardsComboBox.Location = new Point(146, 62);
            WardsComboBox.Name = "WardsComboBox";
            WardsComboBox.Size = new Size(247, 28);
            WardsComboBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.BackColor = Color.Transparent;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Location = new Point(22, 392);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(118, 33);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Назад";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // DiseaseLabel
            // 
            DiseaseLabel.Anchor = AnchorStyles.Top;
            DiseaseLabel.AutoSize = true;
            DiseaseLabel.BackColor = Color.Transparent;
            DiseaseLabel.Location = new Point(72, 17);
            DiseaseLabel.Name = "DiseaseLabel";
            DiseaseLabel.Size = new Size(68, 20);
            DiseaseLabel.TabIndex = 5;
            DiseaseLabel.Text = "Болезни";
            // 
            // TreatmentLabel
            // 
            TreatmentLabel.Anchor = AnchorStyles.Bottom;
            TreatmentLabel.AutoSize = true;
            TreatmentLabel.BackColor = Color.Transparent;
            TreatmentLabel.Location = new Point(71, 243);
            TreatmentLabel.Name = "TreatmentLabel";
            TreatmentLabel.Size = new Size(69, 20);
            TreatmentLabel.TabIndex = 6;
            TreatmentLabel.Text = "Лечение";
            // 
            // WardLabel
            // 
            WardLabel.Anchor = AnchorStyles.Top;
            WardLabel.AutoSize = true;
            WardLabel.BackColor = Color.Transparent;
            WardLabel.Location = new Point(79, 65);
            WardLabel.Name = "WardLabel";
            WardLabel.Size = new Size(61, 20);
            WardLabel.TabIndex = 7;
            WardLabel.Text = "Палаты";
            // 
            // DateOfReceipt
            // 
            DateOfReceipt.Anchor = AnchorStyles.Top;
            DateOfReceipt.Enabled = false;
            DateOfReceipt.Location = new Point(146, 101);
            DateOfReceipt.Name = "DateOfReceipt";
            DateOfReceipt.Size = new Size(247, 27);
            DateOfReceipt.TabIndex = 8;
            // 
            // DateOfReceiptLabel
            // 
            DateOfReceiptLabel.Anchor = AnchorStyles.Top;
            DateOfReceiptLabel.AutoSize = true;
            DateOfReceiptLabel.BackColor = Color.Transparent;
            DateOfReceiptLabel.Location = new Point(6, 103);
            DateOfReceiptLabel.Name = "DateOfReceiptLabel";
            DateOfReceiptLabel.Size = new Size(134, 20);
            DateOfReceiptLabel.TabIndex = 9;
            DateOfReceiptLabel.Text = "Дата поступления";
            // 
            // TreatmentDataGrid
            // 
            TreatmentDataGrid.AllowUserToAddRows = false;
            TreatmentDataGrid.AllowUserToDeleteRows = false;
            TreatmentDataGrid.Anchor = AnchorStyles.Bottom;
            TreatmentDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TreatmentDataGrid.BackgroundColor = SystemColors.ButtonFace;
            TreatmentDataGrid.BorderStyle = BorderStyle.None;
            TreatmentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TreatmentDataGrid.Location = new Point(146, 154);
            TreatmentDataGrid.Name = "TreatmentDataGrid";
            TreatmentDataGrid.ReadOnly = true;
            TreatmentDataGrid.RowHeadersWidth = 51;
            TreatmentDataGrid.Size = new Size(720, 219);
            TreatmentDataGrid.TabIndex = 10;
            // 
            // ChoiceTreatmentPanel
            // 
            ChoiceTreatmentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChoiceTreatmentPanel.BackColor = Color.Transparent;
            ChoiceTreatmentPanel.Controls.Add(AddTreatmentButton);
            ChoiceTreatmentPanel.Controls.Add(TreatmenInfoLabel);
            ChoiceTreatmentPanel.Controls.Add(ChoiceTreatmentLabel);
            ChoiceTreatmentPanel.Controls.Add(TreatmentComboBox);
            ChoiceTreatmentPanel.Location = new Point(424, 10);
            ChoiceTreatmentPanel.Name = "ChoiceTreatmentPanel";
            ChoiceTreatmentPanel.Size = new Size(422, 138);
            ChoiceTreatmentPanel.TabIndex = 11;
            // 
            // AddTreatmentButton
            // 
            AddTreatmentButton.Anchor = AnchorStyles.Bottom;
            AddTreatmentButton.Cursor = Cursors.Hand;
            AddTreatmentButton.FlatStyle = FlatStyle.Popup;
            AddTreatmentButton.Location = new Point(206, 101);
            AddTreatmentButton.Name = "AddTreatmentButton";
            AddTreatmentButton.Size = new Size(163, 37);
            AddTreatmentButton.TabIndex = 14;
            AddTreatmentButton.Text = "Добавить лекарство";
            AddTreatmentButton.UseVisualStyleBackColor = true;
            AddTreatmentButton.Click += AddTreatmentButton_Click;
            // 
            // TreatmenInfoLabel
            // 
            TreatmenInfoLabel.Anchor = AnchorStyles.Top;
            TreatmenInfoLabel.AutoSize = true;
            TreatmenInfoLabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            TreatmenInfoLabel.Location = new Point(127, 78);
            TreatmenInfoLabel.Name = "TreatmenInfoLabel";
            TreatmenInfoLabel.Size = new Size(292, 17);
            TreatmenInfoLabel.TabIndex = 13;
            TreatmenInfoLabel.Text = "Выберите лекарство для внесения его в список";
            // 
            // ChoiceTreatmentLabel
            // 
            ChoiceTreatmentLabel.Anchor = AnchorStyles.Top;
            ChoiceTreatmentLabel.AutoSize = true;
            ChoiceTreatmentLabel.BackColor = Color.Transparent;
            ChoiceTreatmentLabel.Location = new Point(86, 50);
            ChoiceTreatmentLabel.Name = "ChoiceTreatmentLabel";
            ChoiceTreatmentLabel.Size = new Size(80, 20);
            ChoiceTreatmentLabel.TabIndex = 12;
            ChoiceTreatmentLabel.Text = "Лекарства";
            // 
            // TreatmentComboBox
            // 
            TreatmentComboBox.Anchor = AnchorStyles.Top;
            TreatmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TreatmentComboBox.FormattingEnabled = true;
            TreatmentComboBox.Location = new Point(172, 47);
            TreatmentComboBox.Name = "TreatmentComboBox";
            TreatmentComboBox.Size = new Size(247, 28);
            TreatmentComboBox.TabIndex = 4;
            // 
            // DoctorTreatmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChoiceTreatmentPanel);
            Controls.Add(TreatmentDataGrid);
            Controls.Add(DateOfReceiptLabel);
            Controls.Add(DateOfReceipt);
            Controls.Add(WardLabel);
            Controls.Add(TreatmentLabel);
            Controls.Add(DiseaseLabel);
            Controls.Add(CancelButton);
            Controls.Add(WardsComboBox);
            Controls.Add(SaveButton);
            Controls.Add(DiseaseComboBox);
            Name = "DoctorTreatmentForm";
            Size = new Size(869, 437);
            ((System.ComponentModel.ISupportInitialize)TreatmentDataGrid).EndInit();
            ChoiceTreatmentPanel.ResumeLayout(false);
            ChoiceTreatmentPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DiseaseComboBox;
        private Button SaveButton;
        private ComboBox WardsComboBox;
        private Button CancelButton;
        private Label DiseaseLabel;
        private Label TreatmentLabel;
        private Label WardLabel;
        private DateTimePicker DateOfReceipt;
        private Label DateOfReceiptLabel;
        private DataGridView TreatmentDataGrid;
        private Panel ChoiceTreatmentPanel;
        private ComboBox TreatmentComboBox;
        private Label ChoiceTreatmentLabel;
        private Label TreatmenInfoLabel;
        private Button AddTreatmentButton;
    }
}
