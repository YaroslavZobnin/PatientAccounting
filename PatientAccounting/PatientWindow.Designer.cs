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
            ((System.ComponentModel.ISupportInitialize)MedicalHistoryDataGrid).BeginInit();
            SuspendLayout();
            // 
            // RoleNameLabel
            // 
            RoleNameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RoleNameLabel.AutoSize = true;
            RoleNameLabel.BackColor = Color.Transparent;
            RoleNameLabel.BorderStyle = BorderStyle.Fixed3D;
            RoleNameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RoleNameLabel.Location = new Point(3, 518);
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
            PersonalAccountLabel.Location = new Point(309, 10);
            PersonalAccountLabel.Name = "PersonalAccountLabel";
            PersonalAccountLabel.Size = new Size(165, 28);
            PersonalAccountLabel.TabIndex = 1;
            PersonalAccountLabel.Text = "Личный кабинет";
            // 
            // FullNameLabel
            // 
            FullNameLabel.BackColor = Color.Transparent;
            FullNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameLabel.Location = new Point(54, 38);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(668, 30);
            FullNameLabel.TabIndex = 2;
            FullNameLabel.Text = "ФИО";
            FullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordDataLabel
            // 
            PasswordDataLabel.AutoSize = true;
            PasswordDataLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordDataLabel.Location = new Point(54, 79);
            PasswordDataLabel.Name = "PasswordDataLabel";
            PasswordDataLabel.Size = new Size(90, 25);
            PasswordDataLabel.TabIndex = 3;
            PasswordDataLabel.Text = "Паспорт: ";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DateOfBirthLabel.Location = new Point(54, 115);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(146, 25);
            DateOfBirthLabel.TabIndex = 4;
            DateOfBirthLabel.Text = "Дата рождения: ";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddressLabel.Location = new Point(54, 155);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(180, 25);
            AddressLabel.TabIndex = 5;
            AddressLabel.Text = "Место проживания: ";
            // 
            // MedicalHistoryDataGrid
            // 
            MedicalHistoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MedicalHistoryDataGrid.Location = new Point(201, 196);
            MedicalHistoryDataGrid.Name = "MedicalHistoryDataGrid";
            MedicalHistoryDataGrid.RowHeadersWidth = 51;
            MedicalHistoryDataGrid.Size = new Size(417, 281);
            MedicalHistoryDataGrid.TabIndex = 6;
            // 
            // PatientWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(MedicalHistoryDataGrid);
            Controls.Add(AddressLabel);
            Controls.Add(DateOfBirthLabel);
            Controls.Add(PasswordDataLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(PersonalAccountLabel);
            Controls.Add(RoleNameLabel);
            DoubleBuffered = true;
            Name = "PatientWindow";
            Size = new Size(774, 550);
            ((System.ComponentModel.ISupportInitialize)MedicalHistoryDataGrid).EndInit();
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
    }
}
