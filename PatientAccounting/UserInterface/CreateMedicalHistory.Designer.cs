namespace PatientAccounting.UserInterface
{
    partial class CreateMedicalHistory
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
            CreateMedicalHistoryLabel = new Label();
            ChoicePanel = new Panel();
            GetPatientFromPassportRadioButton = new RadioButton();
            GetPatientFromListRadioButton = new RadioButton();
            SearchPatientLabel = new Label();
            panel1 = new Panel();
            PatientsListDataGridView = new DataGridView();
            ChoicePanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatientsListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CreateMedicalHistoryLabel
            // 
            CreateMedicalHistoryLabel.Anchor = AnchorStyles.Top;
            CreateMedicalHistoryLabel.AutoSize = true;
            CreateMedicalHistoryLabel.BackColor = Color.Transparent;
            CreateMedicalHistoryLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            CreateMedicalHistoryLabel.Location = new Point(298, 0);
            CreateMedicalHistoryLabel.Name = "CreateMedicalHistoryLabel";
            CreateMedicalHistoryLabel.Size = new Size(329, 25);
            CreateMedicalHistoryLabel.TabIndex = 0;
            CreateMedicalHistoryLabel.Text = "Создание истории болезни пациента";
            // 
            // ChoicePanel
            // 
            ChoicePanel.Anchor = AnchorStyles.Top;
            ChoicePanel.BackColor = Color.Transparent;
            ChoicePanel.Controls.Add(GetPatientFromPassportRadioButton);
            ChoicePanel.Controls.Add(GetPatientFromListRadioButton);
            ChoicePanel.Controls.Add(SearchPatientLabel);
            ChoicePanel.Location = new Point(252, 3);
            ChoicePanel.Name = "ChoicePanel";
            ChoicePanel.Size = new Size(303, 75);
            ChoicePanel.TabIndex = 1;
            // 
            // GetPatientFromPassportRadioButton
            // 
            GetPatientFromPassportRadioButton.AutoSize = true;
            GetPatientFromPassportRadioButton.Location = new Point(182, 48);
            GetPatientFromPassportRadioButton.Name = "GetPatientFromPassportRadioButton";
            GetPatientFromPassportRadioButton.Size = new Size(118, 24);
            GetPatientFromPassportRadioButton.TabIndex = 2;
            GetPatientFromPassportRadioButton.TabStop = true;
            GetPatientFromPassportRadioButton.Text = "По паспорту";
            GetPatientFromPassportRadioButton.UseVisualStyleBackColor = true;
            GetPatientFromPassportRadioButton.CheckedChanged += GetPatientFromPassportRadioButton_CheckedChanged;
            // 
            // GetPatientFromListRadioButton
            // 
            GetPatientFromListRadioButton.AutoSize = true;
            GetPatientFromListRadioButton.Location = new Point(37, 48);
            GetPatientFromListRadioButton.Name = "GetPatientFromListRadioButton";
            GetPatientFromListRadioButton.Size = new Size(100, 24);
            GetPatientFromListRadioButton.TabIndex = 1;
            GetPatientFromListRadioButton.TabStop = true;
            GetPatientFromListRadioButton.Text = "По списку";
            GetPatientFromListRadioButton.UseVisualStyleBackColor = true;
            GetPatientFromListRadioButton.CheckedChanged += GetPatientFromListRadioButton_CheckedChanged;
            // 
            // SearchPatientLabel
            // 
            SearchPatientLabel.Anchor = AnchorStyles.Top;
            SearchPatientLabel.AutoSize = true;
            SearchPatientLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchPatientLabel.Location = new Point(53, 1);
            SearchPatientLabel.Name = "SearchPatientLabel";
            SearchPatientLabel.Size = new Size(223, 25);
            SearchPatientLabel.TabIndex = 0;
            SearchPatientLabel.Text = "Как осуществляем поиск?";
            // 
            // panel1
            // 
            panel1.Controls.Add(PatientsListDataGridView);
            panel1.Controls.Add(ChoicePanel);
            panel1.Location = new Point(46, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 476);
            panel1.TabIndex = 2;
            // 
            // PatientsListDataGridView
            // 
            PatientsListDataGridView.AllowUserToAddRows = false;
            PatientsListDataGridView.AllowUserToDeleteRows = false;
            PatientsListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PatientsListDataGridView.BackgroundColor = Color.WhiteSmoke;
            PatientsListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientsListDataGridView.Enabled = false;
            PatientsListDataGridView.Location = new Point(3, 84);
            PatientsListDataGridView.Name = "PatientsListDataGridView";
            PatientsListDataGridView.RowHeadersWidth = 51;
            PatientsListDataGridView.Size = new Size(798, 314);
            PatientsListDataGridView.TabIndex = 2;
            PatientsListDataGridView.Visible = false;
            // 
            // CreateMedicalHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(CreateMedicalHistoryLabel);
            Name = "CreateMedicalHistory";
            Size = new Size(869, 546);
            ChoicePanel.ResumeLayout(false);
            ChoicePanel.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PatientsListDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateMedicalHistoryLabel;
        private Panel ChoicePanel;
        private RadioButton GetPatientFromPassportRadioButton;
        private RadioButton GetPatientFromListRadioButton;
        private Label SearchPatientLabel;
        private Panel panel1;
        private DataGridView PatientsListDataGridView;
    }
}
