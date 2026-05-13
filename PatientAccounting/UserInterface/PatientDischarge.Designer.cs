namespace PatientAccounting.UserInterface
{
    partial class PatientDischarge
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
            PatientDischargeLabel = new Label();
            PatientsDataGridView = new DataGridView();
            PatientDischargeButton = new Button();
            ExitToMenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PatientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // PatientDischargeLabel
            // 
            PatientDischargeLabel.Anchor = AnchorStyles.Top;
            PatientDischargeLabel.AutoSize = true;
            PatientDischargeLabel.BackColor = Color.Transparent;
            PatientDischargeLabel.Font = new Font("Sitka Text", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            PatientDischargeLabel.Location = new Point(370, 0);
            PatientDischargeLabel.Name = "PatientDischargeLabel";
            PatientDischargeLabel.Size = new Size(209, 29);
            PatientDischargeLabel.TabIndex = 0;
            PatientDischargeLabel.Text = "Выписка пациентов";
            // 
            // PatientsDataGridView
            // 
            PatientsDataGridView.AllowUserToAddRows = false;
            PatientsDataGridView.AllowUserToDeleteRows = false;
            PatientsDataGridView.Anchor = AnchorStyles.Top;
            PatientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PatientsDataGridView.BackgroundColor = SystemColors.ButtonFace;
            PatientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientsDataGridView.Location = new Point(5, 73);
            PatientsDataGridView.Name = "PatientsDataGridView";
            PatientsDataGridView.RowHeadersWidth = 51;
            PatientsDataGridView.Size = new Size(861, 407);
            PatientsDataGridView.TabIndex = 1;
            // 
            // PatientDischargeButton
            // 
            PatientDischargeButton.BackColor = Color.Transparent;
            PatientDischargeButton.Cursor = Cursors.Hand;
            PatientDischargeButton.FlatStyle = FlatStyle.Popup;
            PatientDischargeButton.Location = new Point(390, 496);
            PatientDischargeButton.Name = "PatientDischargeButton";
            PatientDischargeButton.Size = new Size(161, 36);
            PatientDischargeButton.TabIndex = 2;
            PatientDischargeButton.Text = "Выписать";
            PatientDischargeButton.UseVisualStyleBackColor = false;
            PatientDischargeButton.Click += PatientDischargeButton_Click;
            // 
            // ExitToMenuButton
            // 
            ExitToMenuButton.BackColor = Color.Transparent;
            ExitToMenuButton.Cursor = Cursors.Hand;
            ExitToMenuButton.FlatStyle = FlatStyle.Popup;
            ExitToMenuButton.Location = new Point(5, 498);
            ExitToMenuButton.Name = "ExitToMenuButton";
            ExitToMenuButton.Size = new Size(101, 34);
            ExitToMenuButton.TabIndex = 3;
            ExitToMenuButton.Text = "Назад";
            ExitToMenuButton.UseVisualStyleBackColor = false;
            ExitToMenuButton.Click += ExitToMenuButton_Click;
            // 
            // PatientDischarge
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ExitToMenuButton);
            Controls.Add(PatientDischargeButton);
            Controls.Add(PatientsDataGridView);
            Controls.Add(PatientDischargeLabel);
            Name = "PatientDischarge";
            Size = new Size(869, 546);
            ((System.ComponentModel.ISupportInitialize)PatientsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PatientDischargeLabel;
        private DataGridView PatientsDataGridView;
        private Button PatientDischargeButton;
        private Button ExitToMenuButton;
    }
}
