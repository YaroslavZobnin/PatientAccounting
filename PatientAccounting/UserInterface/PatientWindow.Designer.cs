namespace PatientAccounting
{
    partial class PatientWindow
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
            RoleNameLabel = new Label();
            PersonalAccountLabel = new Label();
            FullNameLabel = new Label();
            PasswordDataLabel = new Label();
            DateOfBirthLabel = new Label();
            AddressLabel = new Label();
            MedicalHistoryDataGrid = new DataGridView();
            TreatmentDataGrid = new DataGridView();
            MedicalHistoryLabel = new Label();
            TreatmentLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)MedicalHistoryDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TreatmentDataGrid).BeginInit();
            SuspendLayout();
            // 
            // RoleNameLabel
            // 
            RoleNameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RoleNameLabel.AutoSize = true;
            RoleNameLabel.BackColor = Color.Transparent;
            RoleNameLabel.BorderStyle = BorderStyle.Fixed3D;
            RoleNameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RoleNameLabel.Location = new Point(3, 617);
            RoleNameLabel.Name = "RoleNameLabel";
            RoleNameLabel.Size = new Size(83, 27);
            RoleNameLabel.TabIndex = 0;
            RoleNameLabel.Text = "Пациент";
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
            PersonalAccountLabel.TabIndex = 1;
            PersonalAccountLabel.Text = "Личный кабинет";
            // 
            // FullNameLabel
            // 
            FullNameLabel.Anchor = AnchorStyles.Top;
            FullNameLabel.BackColor = Color.Transparent;
            FullNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameLabel.Location = new Point(151, 35);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(668, 30);
            FullNameLabel.TabIndex = 2;
            FullNameLabel.Text = "ФИО";
            FullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordDataLabel
            // 
            PasswordDataLabel.Anchor = AnchorStyles.Top;
            PasswordDataLabel.AutoSize = true;
            PasswordDataLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordDataLabel.Location = new Point(106, 73);
            PasswordDataLabel.Name = "PasswordDataLabel";
            PasswordDataLabel.Size = new Size(90, 25);
            PasswordDataLabel.TabIndex = 3;
            PasswordDataLabel.Text = "Паспорт: ";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.Anchor = AnchorStyles.Top;
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DateOfBirthLabel.Location = new Point(106, 96);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(146, 25);
            DateOfBirthLabel.TabIndex = 4;
            DateOfBirthLabel.Text = "Дата рождения: ";
            // 
            // AddressLabel
            // 
            AddressLabel.Anchor = AnchorStyles.Top;
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddressLabel.Location = new Point(106, 122);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(180, 25);
            AddressLabel.TabIndex = 5;
            AddressLabel.Text = "Место проживания: ";
            // 
            // MedicalHistoryDataGrid
            // 
            MedicalHistoryDataGrid.AllowUserToAddRows = false;
            MedicalHistoryDataGrid.AllowUserToDeleteRows = false;
            MedicalHistoryDataGrid.Anchor = AnchorStyles.Top;
            MedicalHistoryDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MedicalHistoryDataGrid.BackgroundColor = SystemColors.ControlLight;
            MedicalHistoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MedicalHistoryDataGrid.Location = new Point(55, 176);
            MedicalHistoryDataGrid.Name = "MedicalHistoryDataGrid";
            MedicalHistoryDataGrid.ReadOnly = true;
            MedicalHistoryDataGrid.RowHeadersWidth = 51;
            MedicalHistoryDataGrid.Size = new Size(768, 237);
            MedicalHistoryDataGrid.TabIndex = 6;
            MedicalHistoryDataGrid.SelectionChanged += MedicalHistoryDataGrid_SelectionChanged;
            // 
            // TreatmentDataGrid
            // 
            TreatmentDataGrid.AllowUserToAddRows = false;
            TreatmentDataGrid.AllowUserToDeleteRows = false;
            TreatmentDataGrid.Anchor = AnchorStyles.Top;
            TreatmentDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TreatmentDataGrid.BackgroundColor = SystemColors.ControlLight;
            TreatmentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TreatmentDataGrid.Location = new Point(55, 445);
            TreatmentDataGrid.Name = "TreatmentDataGrid";
            TreatmentDataGrid.ReadOnly = true;
            TreatmentDataGrid.RowHeadersWidth = 51;
            TreatmentDataGrid.Size = new Size(768, 137);
            TreatmentDataGrid.TabIndex = 7;
            // 
            // MedicalHistoryLabel
            // 
            MedicalHistoryLabel.Anchor = AnchorStyles.Top;
            MedicalHistoryLabel.AutoSize = true;
            MedicalHistoryLabel.Location = new Point(392, 153);
            MedicalHistoryLabel.Name = "MedicalHistoryLabel";
            MedicalHistoryLabel.Size = new Size(139, 20);
            MedicalHistoryLabel.TabIndex = 8;
            MedicalHistoryLabel.Text = "История болезней";
            // 
            // TreatmentLabel
            // 
            TreatmentLabel.Anchor = AnchorStyles.Top;
            TreatmentLabel.AutoSize = true;
            TreatmentLabel.Location = new Point(362, 422);
            TreatmentLabel.Name = "TreatmentLabel";
            TreatmentLabel.Size = new Size(217, 20);
            TreatmentLabel.TabIndex = 9;
            TreatmentLabel.Text = "Лечение выбранной болезни";
            // 
            // PatientWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(TreatmentLabel);
            Controls.Add(MedicalHistoryLabel);
            Controls.Add(TreatmentDataGrid);
            Controls.Add(MedicalHistoryDataGrid);
            Controls.Add(AddressLabel);
            Controls.Add(DateOfBirthLabel);
            Controls.Add(PasswordDataLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(PersonalAccountLabel);
            Controls.Add(RoleNameLabel);
            DoubleBuffered = true;
            Name = "PatientWindow";
            Size = new Size(879, 649);
            ((System.ComponentModel.ISupportInitialize)MedicalHistoryDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)TreatmentDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RoleNameLabel;
        private Label PersonalAccountLabel;
        private Label FullNameLabel;
        private Label PasswordDataLabel;
        private Label DateOfBirthLabel;
        private Label AddressLabel;
        private DataGridView MedicalHistoryDataGrid;
        private DataGridView TreatmentDataGrid;
        private Label MedicalHistoryLabel;
        private Label TreatmentLabel;
    }
}
