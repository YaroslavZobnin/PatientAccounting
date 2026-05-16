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
            CreateMedicalHistory = new Button();
            PatientExtract = new Button();
            WritingToDataBaseButton = new Button();
            ViewingDoctorsOrPatientsButton = new Button();
            ChoiceActionLabel = new Label();
            MainPanel = new Panel();
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
            ChoiceActionPanel.Controls.Add(CreateMedicalHistory);
            ChoiceActionPanel.Controls.Add(PatientExtract);
            ChoiceActionPanel.Controls.Add(WritingToDataBaseButton);
            ChoiceActionPanel.Controls.Add(ViewingDoctorsOrPatientsButton);
            ChoiceActionPanel.Controls.Add(ChoiceActionLabel);
            ChoiceActionPanel.Location = new Point(135, 66);
            ChoiceActionPanel.Name = "ChoiceActionPanel";
            ChoiceActionPanel.Size = new Size(685, 78);
            ChoiceActionPanel.TabIndex = 5;
            // 
            // CreateMedicalHistory
            // 
            CreateMedicalHistory.Cursor = Cursors.Hand;
            CreateMedicalHistory.FlatStyle = FlatStyle.Popup;
            CreateMedicalHistory.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CreateMedicalHistory.Location = new Point(480, 36);
            CreateMedicalHistory.Name = "CreateMedicalHistory";
            CreateMedicalHistory.Size = new Size(136, 35);
            CreateMedicalHistory.TabIndex = 4;
            CreateMedicalHistory.Text = "Создание карточки";
            CreateMedicalHistory.UseVisualStyleBackColor = true;
            CreateMedicalHistory.Click += CreateMedicalHistory_Click;
            // 
            // PatientExtract
            // 
            PatientExtract.Cursor = Cursors.Hand;
            PatientExtract.FlatStyle = FlatStyle.Popup;
            PatientExtract.Location = new Point(329, 36);
            PatientExtract.Name = "PatientExtract";
            PatientExtract.Size = new Size(100, 35);
            PatientExtract.TabIndex = 3;
            PatientExtract.Text = "Выписка";
            PatientExtract.UseVisualStyleBackColor = true;
            PatientExtract.Click += PatientExtract_Click;
            // 
            // WritingToDataBaseButton
            // 
            WritingToDataBaseButton.Cursor = Cursors.Hand;
            WritingToDataBaseButton.FlatStyle = FlatStyle.Popup;
            WritingToDataBaseButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WritingToDataBaseButton.Location = new Point(170, 36);
            WritingToDataBaseButton.Name = "WritingToDataBaseButton";
            WritingToDataBaseButton.Size = new Size(100, 35);
            WritingToDataBaseButton.TabIndex = 2;
            WritingToDataBaseButton.Text = "Запись в базу";
            WritingToDataBaseButton.UseVisualStyleBackColor = true;
            WritingToDataBaseButton.Click += WritingToDataBaseButton_Click;
            // 
            // ViewingDoctorsOrPatientsButton
            // 
            ViewingDoctorsOrPatientsButton.Cursor = Cursors.Hand;
            ViewingDoctorsOrPatientsButton.FlatStyle = FlatStyle.Popup;
            ViewingDoctorsOrPatientsButton.Location = new Point(12, 36);
            ViewingDoctorsOrPatientsButton.Name = "ViewingDoctorsOrPatientsButton";
            ViewingDoctorsOrPatientsButton.Size = new Size(100, 35);
            ViewingDoctorsOrPatientsButton.TabIndex = 1;
            ViewingDoctorsOrPatientsButton.Text = "Просмотр";
            ViewingDoctorsOrPatientsButton.UseVisualStyleBackColor = true;
            ViewingDoctorsOrPatientsButton.Click += ViewingDoctorsOrPatientsButton_Click;
            // 
            // ChoiceActionLabel
            // 
            ChoiceActionLabel.AutoSize = true;
            ChoiceActionLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            ChoiceActionLabel.Location = new Point(268, 2);
            ChoiceActionLabel.Name = "ChoiceActionLabel";
            ChoiceActionLabel.Size = new Size(169, 23);
            ChoiceActionLabel.TabIndex = 0;
            ChoiceActionLabel.Text = "Выберите действие";
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top;
            MainPanel.BackColor = Color.Transparent;
            MainPanel.Location = new Point(7, 68);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(869, 546);
            MainPanel.TabIndex = 6;
            // 
            // MedicalRegistrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MedicalRegistrarLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(PersonalAccountLabel);
            Controls.Add(ChoiceActionPanel);
            Controls.Add(MainPanel);
            DoubleBuffered = true;
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
        private Button PatientExtract;
        private Button WritingToDataBaseButton;
        private Panel MainPanel;
        private Button CreateMedicalHistory;
    }
}
