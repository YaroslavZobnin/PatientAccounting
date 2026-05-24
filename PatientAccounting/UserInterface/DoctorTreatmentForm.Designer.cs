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
            TreatmentComboBox = new ComboBox();
            SaveButton = new Button();
            WardsComboBox = new ComboBox();
            CancelButton = new Button();
            DiseaseLabel = new Label();
            TreatmentLabel = new Label();
            WardLabel = new Label();
            DateOfReceipt = new DateTimePicker();
            SuspendLayout();
            // 
            // DiseaseComboBox
            // 
            DiseaseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DiseaseComboBox.FormattingEnabled = true;
            DiseaseComboBox.Location = new Point(52, 88);
            DiseaseComboBox.Name = "DiseaseComboBox";
            DiseaseComboBox.Size = new Size(247, 28);
            DiseaseComboBox.TabIndex = 0;
            // 
            // TreatmentComboBox
            // 
            TreatmentComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TreatmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TreatmentComboBox.FormattingEnabled = true;
            TreatmentComboBox.Location = new Point(557, 88);
            TreatmentComboBox.Name = "TreatmentComboBox";
            TreatmentComboBox.Size = new Size(247, 28);
            TreatmentComboBox.TabIndex = 1;
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
            WardsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WardsComboBox.FormattingEnabled = true;
            WardsComboBox.Location = new Point(52, 159);
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
            DiseaseLabel.AutoSize = true;
            DiseaseLabel.BackColor = Color.Transparent;
            DiseaseLabel.Location = new Point(133, 65);
            DiseaseLabel.Name = "DiseaseLabel";
            DiseaseLabel.Size = new Size(68, 20);
            DiseaseLabel.TabIndex = 5;
            DiseaseLabel.Text = "Болезни";
            // 
            // TreatmentLabel
            // 
            TreatmentLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TreatmentLabel.AutoSize = true;
            TreatmentLabel.BackColor = Color.Transparent;
            TreatmentLabel.Location = new Point(649, 65);
            TreatmentLabel.Name = "TreatmentLabel";
            TreatmentLabel.Size = new Size(69, 20);
            TreatmentLabel.TabIndex = 6;
            TreatmentLabel.Text = "Лечение";
            // 
            // WardLabel
            // 
            WardLabel.AutoSize = true;
            WardLabel.BackColor = Color.Transparent;
            WardLabel.Location = new Point(133, 136);
            WardLabel.Name = "WardLabel";
            WardLabel.Size = new Size(61, 20);
            WardLabel.TabIndex = 7;
            WardLabel.Text = "Палаты";
            // 
            // DateOfReceipt
            // 
            DateOfReceipt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateOfReceipt.Enabled = false;
            DateOfReceipt.Location = new Point(557, 160);
            DateOfReceipt.Name = "DateOfReceipt";
            DateOfReceipt.Size = new Size(247, 27);
            DateOfReceipt.TabIndex = 8;
            // 
            // DoctorTreatmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DateOfReceipt);
            Controls.Add(WardLabel);
            Controls.Add(TreatmentLabel);
            Controls.Add(DiseaseLabel);
            Controls.Add(CancelButton);
            Controls.Add(WardsComboBox);
            Controls.Add(SaveButton);
            Controls.Add(TreatmentComboBox);
            Controls.Add(DiseaseComboBox);
            Name = "DoctorTreatmentForm";
            Size = new Size(869, 437);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DiseaseComboBox;
        private ComboBox TreatmentComboBox;
        private Button SaveButton;
        private ComboBox WardsComboBox;
        private Button CancelButton;
        private Label DiseaseLabel;
        private Label TreatmentLabel;
        private Label WardLabel;
        private DateTimePicker DateOfReceipt;
    }
}
