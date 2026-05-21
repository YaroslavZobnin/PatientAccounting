namespace PatientAccounting.UserInterface
{
    partial class DoctorWindow
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
            SystemAdminLabel = new Label();
            ChoiceSearchParameterPanel = new Panel();
            SearchByPassportButton = new Button();
            SearchByListButton = new Button();
            ChoiceParameterLabel = new Label();
            MainPanel = new Panel();
            panel1 = new Panel();
            ArchivePatientsButton = new Button();
            CurrentPatientsButton = new Button();
            ChoiceSearchParameterPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PersonalAccountLabel
            // 
            PersonalAccountLabel.Anchor = AnchorStyles.Top;
            PersonalAccountLabel.AutoSize = true;
            PersonalAccountLabel.BackColor = Color.Transparent;
            PersonalAccountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PersonalAccountLabel.Location = new Point(402, 8);
            PersonalAccountLabel.Name = "PersonalAccountLabel";
            PersonalAccountLabel.Size = new Size(165, 28);
            PersonalAccountLabel.TabIndex = 2;
            PersonalAccountLabel.Text = "Личный кабинет";
            // 
            // FullNameLabel
            // 
            FullNameLabel.Anchor = AnchorStyles.Top;
            FullNameLabel.BackColor = Color.Transparent;
            FullNameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameLabel.Location = new Point(152, 36);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(644, 22);
            FullNameLabel.TabIndex = 3;
            FullNameLabel.Text = "ФИО";
            FullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SystemAdminLabel
            // 
            SystemAdminLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SystemAdminLabel.AutoSize = true;
            SystemAdminLabel.BackColor = Color.Transparent;
            SystemAdminLabel.BorderStyle = BorderStyle.Fixed3D;
            SystemAdminLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SystemAdminLabel.Location = new Point(3, 617);
            SystemAdminLabel.Name = "SystemAdminLabel";
            SystemAdminLabel.Size = new Size(134, 27);
            SystemAdminLabel.TabIndex = 4;
            SystemAdminLabel.Text = "Лечащий врач";
            // 
            // ChoiceSearchParameterPanel
            // 
            ChoiceSearchParameterPanel.Anchor = AnchorStyles.Top;
            ChoiceSearchParameterPanel.BackColor = Color.Transparent;
            ChoiceSearchParameterPanel.Controls.Add(SearchByPassportButton);
            ChoiceSearchParameterPanel.Controls.Add(SearchByListButton);
            ChoiceSearchParameterPanel.Controls.Add(ChoiceParameterLabel);
            ChoiceSearchParameterPanel.Location = new Point(276, 61);
            ChoiceSearchParameterPanel.Name = "ChoiceSearchParameterPanel";
            ChoiceSearchParameterPanel.Size = new Size(413, 69);
            ChoiceSearchParameterPanel.TabIndex = 5;
            // 
            // SearchByPassportButton
            // 
            SearchByPassportButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchByPassportButton.Cursor = Cursors.Hand;
            SearchByPassportButton.FlatStyle = FlatStyle.Popup;
            SearchByPassportButton.Location = new Point(266, 38);
            SearchByPassportButton.Name = "SearchByPassportButton";
            SearchByPassportButton.Size = new Size(106, 28);
            SearchByPassportButton.TabIndex = 2;
            SearchByPassportButton.Text = "По паспорту";
            SearchByPassportButton.UseVisualStyleBackColor = true;
            SearchByPassportButton.Click += SearchByPassportButton_Click;
            // 
            // SearchByListButton
            // 
            SearchByListButton.Cursor = Cursors.Hand;
            SearchByListButton.FlatStyle = FlatStyle.Popup;
            SearchByListButton.Location = new Point(8, 38);
            SearchByListButton.Name = "SearchByListButton";
            SearchByListButton.Size = new Size(106, 28);
            SearchByListButton.TabIndex = 1;
            SearchByListButton.Text = "По списку";
            SearchByListButton.UseVisualStyleBackColor = true;
            SearchByListButton.Click += SearchByListButton_Click;
            // 
            // ChoiceParameterLabel
            // 
            ChoiceParameterLabel.AutoSize = true;
            ChoiceParameterLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChoiceParameterLabel.Location = new Point(109, 9);
            ChoiceParameterLabel.Name = "ChoiceParameterLabel";
            ChoiceParameterLabel.Size = new Size(219, 23);
            ChoiceParameterLabel.TabIndex = 0;
            ChoiceParameterLabel.Text = "Как осуществляем поиск?";
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top;
            MainPanel.BackColor = Color.Transparent;
            MainPanel.Location = new Point(8, 61);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(869, 548);
            MainPanel.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(ArchivePatientsButton);
            panel1.Controls.Add(CurrentPatientsButton);
            panel1.Location = new Point(8, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 57);
            panel1.TabIndex = 7;
            // 
            // ArchivePatientsButton
            // 
            ArchivePatientsButton.Anchor = AnchorStyles.Top;
            ArchivePatientsButton.BackColor = Color.Transparent;
            ArchivePatientsButton.Cursor = Cursors.Hand;
            ArchivePatientsButton.FlatStyle = FlatStyle.Flat;
            ArchivePatientsButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ArchivePatientsButton.Location = new Point(132, 1);
            ArchivePatientsButton.Name = "ArchivePatientsButton";
            ArchivePatientsButton.Size = new Size(92, 53);
            ArchivePatientsButton.TabIndex = 1;
            ArchivePatientsButton.Text = "Архив";
            ArchivePatientsButton.UseVisualStyleBackColor = false;
            ArchivePatientsButton.Click += ArchivePatientsButton_Click;
            // 
            // CurrentPatientsButton
            // 
            CurrentPatientsButton.Anchor = AnchorStyles.Top;
            CurrentPatientsButton.BackColor = Color.Transparent;
            CurrentPatientsButton.Cursor = Cursors.Hand;
            CurrentPatientsButton.FlatStyle = FlatStyle.Flat;
            CurrentPatientsButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CurrentPatientsButton.Location = new Point(7, 1);
            CurrentPatientsButton.Name = "CurrentPatientsButton";
            CurrentPatientsButton.Size = new Size(92, 53);
            CurrentPatientsButton.TabIndex = 0;
            CurrentPatientsButton.Text = "Текущие пациенты";
            CurrentPatientsButton.UseVisualStyleBackColor = false;
            CurrentPatientsButton.Click += CurrentPatientsButton_Click;
            // 
            // DoctorWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(ChoiceSearchParameterPanel);
            Controls.Add(SystemAdminLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(PersonalAccountLabel);
            Controls.Add(MainPanel);
            DoubleBuffered = true;
            Name = "DoctorWindow";
            Size = new Size(879, 649);
            ChoiceSearchParameterPanel.ResumeLayout(false);
            ChoiceSearchParameterPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PersonalAccountLabel;
        private Label FullNameLabel;
        private Label SystemAdminLabel;
        private Panel ChoiceSearchParameterPanel;
        private Label ChoiceParameterLabel;
        private Panel MainPanel;
        private Button SearchByPassportButton;
        private Button SearchByListButton;
        private Panel panel1;
        private Button ArchivePatientsButton;
        private Button CurrentPatientsButton;
    }
}
