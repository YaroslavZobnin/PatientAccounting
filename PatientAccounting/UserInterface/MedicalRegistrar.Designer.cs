namespace PatientAccounting.UserInterface
{
    partial class MedicalRegistrar
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
            PersonalAccountLabel = new Label();
            FullNameLabel = new Label();
            MedicalRegistrarLabel = new Label();
            ChoiceActionPanel = new Panel();
            ChoiceActionLabel = new Label();
            ViewingDoctorsOrPatientsButton = new Button();
            WritingToDataBaseButton = new Button();
            PatientRecords = new Button();
            ChoiceActionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PersonalAccountLabel
            // 
            PersonalAccountLabel.Anchor = AnchorStyles.Top;
            PersonalAccountLabel.AutoSize = true;
            PersonalAccountLabel.BackColor = Color.Transparent;
            PersonalAccountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PersonalAccountLabel.Location = new Point(403, 8);
            PersonalAccountLabel.Name = "PersonalAccountLabel";
            PersonalAccountLabel.Size = new Size(165, 28);
            PersonalAccountLabel.TabIndex = 2;
            PersonalAccountLabel.Text = "Личный кабинет";
            // 
            // FullNameLabel
            // 
            FullNameLabel.Anchor = AnchorStyles.Top;
            FullNameLabel.BackColor = Color.Transparent;
            FullNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameLabel.Location = new Point(152, 35);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(668, 30);
            FullNameLabel.TabIndex = 3;
            FullNameLabel.Text = "ФИО";
            FullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MedicalRegistrarLabel
            // 
            MedicalRegistrarLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MedicalRegistrarLabel.AutoSize = true;
            MedicalRegistrarLabel.BackColor = Color.Transparent;
            MedicalRegistrarLabel.BorderStyle = BorderStyle.Fixed3D;
            MedicalRegistrarLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MedicalRegistrarLabel.Location = new Point(3, 617);
            MedicalRegistrarLabel.Name = "MedicalRegistrarLabel";
            MedicalRegistrarLabel.Size = new Size(233, 27);
            MedicalRegistrarLabel.TabIndex = 4;
            MedicalRegistrarLabel.Text = "Медицинский регистратор";
            // 
            // ChoiceActionPanel
            // 
            ChoiceActionPanel.Anchor = AnchorStyles.Top;
            ChoiceActionPanel.BackColor = Color.Transparent;
            ChoiceActionPanel.Controls.Add(PatientRecords);
            ChoiceActionPanel.Controls.Add(WritingToDataBaseButton);
            ChoiceActionPanel.Controls.Add(ViewingDoctorsOrPatientsButton);
            ChoiceActionPanel.Controls.Add(ChoiceActionLabel);
            ChoiceActionPanel.Location = new Point(259, 77);
            ChoiceActionPanel.Name = "ChoiceActionPanel";
            ChoiceActionPanel.Size = new Size(463, 109);
            ChoiceActionPanel.TabIndex = 5;
            // 
            // ChoiceActionLabel
            // 
            ChoiceActionLabel.AutoSize = true;
            ChoiceActionLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            ChoiceActionLabel.Location = new Point(150, 0);
            ChoiceActionLabel.Name = "ChoiceActionLabel";
            ChoiceActionLabel.Size = new Size(169, 23);
            ChoiceActionLabel.TabIndex = 0;
            ChoiceActionLabel.Text = "Выберите действие";
            // 
            // ViewingDoctorsOrPatientsButton
            // 
            ViewingDoctorsOrPatientsButton.FlatStyle = FlatStyle.Popup;
            ViewingDoctorsOrPatientsButton.Location = new Point(15, 64);
            ViewingDoctorsOrPatientsButton.Name = "ViewingDoctorsOrPatientsButton";
            ViewingDoctorsOrPatientsButton.Size = new Size(100, 35);
            ViewingDoctorsOrPatientsButton.TabIndex = 1;
            ViewingDoctorsOrPatientsButton.Text = "Просмотр";
            ViewingDoctorsOrPatientsButton.UseVisualStyleBackColor = true;
            // 
            // WritingToDataBaseButton
            // 
            WritingToDataBaseButton.FlatStyle = FlatStyle.Popup;
            WritingToDataBaseButton.Location = new Point(175, 64);
            WritingToDataBaseButton.Name = "WritingToDataBaseButton";
            WritingToDataBaseButton.Size = new Size(100, 35);
            WritingToDataBaseButton.TabIndex = 2;
            WritingToDataBaseButton.Text = "Запись";
            WritingToDataBaseButton.UseVisualStyleBackColor = true;
            // 
            // PatientRecords
            // 
            PatientRecords.FlatStyle = FlatStyle.Popup;
            PatientRecords.Location = new Point(329, 64);
            PatientRecords.Name = "PatientRecords";
            PatientRecords.Size = new Size(100, 35);
            PatientRecords.TabIndex = 3;
            PatientRecords.Text = "Приём";
            PatientRecords.UseVisualStyleBackColor = true;
            // 
            // MedicalRegistrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChoiceActionPanel);
            Controls.Add(MedicalRegistrarLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(PersonalAccountLabel);
            Name = "MedicalRegistrar";
            Size = new Size(879, 649);
            ChoiceActionPanel.ResumeLayout(false);
            ChoiceActionPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PersonalAccountLabel;
        private Label FullNameLabel;
        private Label MedicalRegistrarLabel;
        private Panel ChoiceActionPanel;
        private Button ViewingDoctorsOrPatientsButton;
        private Label ChoiceActionLabel;
        private Button PatientRecords;
        private Button WritingToDataBaseButton;
    }
}
