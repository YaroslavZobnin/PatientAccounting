namespace PatientAccounting.UserInterface
{
    partial class MedicalHistoryEntryForm
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
            PatientNameLabel = new Label();
            DoctorComboBox = new ComboBox();
            WardComboBox = new ComboBox();
            DateOfReceiptPicker = new DateTimePicker();
            SaveButton = new Button();
            DoctorLabrl = new Label();
            WardLabel = new Label();
            DateOfReceiptLabel = new Label();
            SuspendLayout();
            // 
            // PatientNameLabel
            // 
            PatientNameLabel.Anchor = AnchorStyles.Top;
            PatientNameLabel.BackColor = Color.Transparent;
            PatientNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            PatientNameLabel.Location = new Point(86, 0);
            PatientNameLabel.Name = "PatientNameLabel";
            PatientNameLabel.Size = new Size(572, 25);
            PatientNameLabel.TabIndex = 0;
            PatientNameLabel.Text = "Полное имя";
            PatientNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // DoctorComboBox
            // 
            DoctorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DoctorComboBox.FormattingEnabled = true;
            DoctorComboBox.Location = new Point(3, 72);
            DoctorComboBox.Name = "DoctorComboBox";
            DoctorComboBox.Size = new Size(262, 28);
            DoctorComboBox.TabIndex = 1;
            // 
            // WardComboBox
            // 
            WardComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WardComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WardComboBox.FormattingEnabled = true;
            WardComboBox.Location = new Point(416, 72);
            WardComboBox.Name = "WardComboBox";
            WardComboBox.Size = new Size(298, 28);
            WardComboBox.TabIndex = 2;
            // 
            // DateOfReceiptPicker
            // 
            DateOfReceiptPicker.Anchor = AnchorStyles.None;
            DateOfReceiptPicker.Enabled = false;
            DateOfReceiptPicker.Location = new Point(225, 139);
            DateOfReceiptPicker.Name = "DateOfReceiptPicker";
            DateOfReceiptPicker.Size = new Size(257, 27);
            DateOfReceiptPicker.TabIndex = 3;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom;
            SaveButton.BackColor = Color.Transparent;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Location = new Point(294, 188);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(122, 31);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // DoctorLabrl
            // 
            DoctorLabrl.AutoSize = true;
            DoctorLabrl.BackColor = Color.Transparent;
            DoctorLabrl.Location = new Point(105, 49);
            DoctorLabrl.Name = "DoctorLabrl";
            DoctorLabrl.Size = new Size(43, 20);
            DoctorLabrl.TabIndex = 5;
            DoctorLabrl.Text = "Врач";
            // 
            // WardLabel
            // 
            WardLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WardLabel.AutoSize = true;
            WardLabel.BackColor = Color.Transparent;
            WardLabel.Location = new Point(541, 49);
            WardLabel.Name = "WardLabel";
            WardLabel.Size = new Size(58, 20);
            WardLabel.TabIndex = 6;
            WardLabel.Text = "Палата";
            // 
            // DateOfReceiptLabel
            // 
            DateOfReceiptLabel.Anchor = AnchorStyles.None;
            DateOfReceiptLabel.AutoSize = true;
            DateOfReceiptLabel.BackColor = Color.Transparent;
            DateOfReceiptLabel.Location = new Point(282, 116);
            DateOfReceiptLabel.Name = "DateOfReceiptLabel";
            DateOfReceiptLabel.Size = new Size(134, 20);
            DateOfReceiptLabel.TabIndex = 7;
            DateOfReceiptLabel.Text = "Дата поступления";
            // 
            // MedicalHistoryEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DateOfReceiptLabel);
            Controls.Add(WardLabel);
            Controls.Add(DoctorLabrl);
            Controls.Add(SaveButton);
            Controls.Add(DateOfReceiptPicker);
            Controls.Add(WardComboBox);
            Controls.Add(DoctorComboBox);
            Controls.Add(PatientNameLabel);
            DoubleBuffered = true;
            Name = "MedicalHistoryEntryForm";
            Size = new Size(717, 223);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PatientNameLabel;
        private ComboBox DoctorComboBox;
        private ComboBox WardComboBox;
        private DateTimePicker DateOfReceiptPicker;
        private Button SaveButton;
        private Label DoctorLabrl;
        private Label WardLabel;
        private Label DateOfReceiptLabel;
    }
}
