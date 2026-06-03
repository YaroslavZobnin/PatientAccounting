namespace PatientAccounting.UserInterface
{
    partial class EditingUser
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
            BackToMenuButton = new Button();
            CancelButton = new Button();
            EditingUserPanel = new Panel();
            WarningLabel = new Label();
            RoleComboBox = new ComboBox();
            PatronymicLabel = new Label();
            NameLabel = new Label();
            PatronymicTextBox = new TextBox();
            NameTextBox = new TextBox();
            SurnameLabel = new Label();
            SurnameTextBox = new TextBox();
            UserRoleLabel = new Label();
            UserPassportLabel = new Label();
            UserLoginLabel = new Label();
            UserPassportTextBox = new TextBox();
            UserLoginTextBox = new TextBox();
            AllInfoAboutUser = new Label();
            SearchUserByPassportPanel = new Panel();
            EditingPatientPanel = new Panel();
            DateOfBirthDateTimePicker = new DateTimePicker();
            DateOfBirthLabel = new Label();
            AddressLabel = new Label();
            AddressTextBox = new TextBox();
            EditingStaffPanel = new Panel();
            WorkExperienceNumericUpDown = new NumericUpDown();
            SpecializationsComboBox = new ComboBox();
            SpecializationLabel = new Label();
            WorkExperienceLabel = new Label();
            SaveEditedUser = new Button();
            EditingUserPanel.SuspendLayout();
            EditingPatientPanel.SuspendLayout();
            EditingStaffPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WorkExperienceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BackToMenuButton.BackColor = Color.Transparent;
            BackToMenuButton.Cursor = Cursors.Hand;
            BackToMenuButton.FlatStyle = FlatStyle.Popup;
            BackToMenuButton.Font = new Font("Sylfaen", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            BackToMenuButton.Location = new Point(115, 488);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(110, 32);
            BackToMenuButton.TabIndex = 26;
            BackToMenuButton.Text = "Меню";
            BackToMenuButton.UseVisualStyleBackColor = false;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.BackColor = Color.Transparent;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.Enabled = false;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Sylfaen", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            CancelButton.Location = new Point(3, 488);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(106, 32);
            CancelButton.TabIndex = 25;
            CancelButton.Text = "Отменить";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Visible = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditingUserPanel
            // 
            EditingUserPanel.Anchor = AnchorStyles.Top;
            EditingUserPanel.BackColor = Color.Transparent;
            EditingUserPanel.Controls.Add(WarningLabel);
            EditingUserPanel.Controls.Add(RoleComboBox);
            EditingUserPanel.Controls.Add(PatronymicLabel);
            EditingUserPanel.Controls.Add(NameLabel);
            EditingUserPanel.Controls.Add(PatronymicTextBox);
            EditingUserPanel.Controls.Add(NameTextBox);
            EditingUserPanel.Controls.Add(SurnameLabel);
            EditingUserPanel.Controls.Add(SurnameTextBox);
            EditingUserPanel.Controls.Add(UserRoleLabel);
            EditingUserPanel.Controls.Add(UserPassportLabel);
            EditingUserPanel.Controls.Add(UserLoginLabel);
            EditingUserPanel.Controls.Add(UserPassportTextBox);
            EditingUserPanel.Controls.Add(UserLoginTextBox);
            EditingUserPanel.Controls.Add(AllInfoAboutUser);
            EditingUserPanel.Enabled = false;
            EditingUserPanel.Location = new Point(3, 7);
            EditingUserPanel.Name = "EditingUserPanel";
            EditingUserPanel.Size = new Size(870, 245);
            EditingUserPanel.TabIndex = 28;
            EditingUserPanel.Visible = false;
            // 
            // WarningLabel
            // 
            WarningLabel.AutoSize = true;
            WarningLabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            WarningLabel.Location = new Point(653, 107);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new Size(184, 17);
            WarningLabel.TabIndex = 14;
            WarningLabel.Text = "Изменение роли невозможно!";
            // 
            // RoleComboBox
            // 
            RoleComboBox.Cursor = Cursors.Hand;
            RoleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RoleComboBox.Enabled = false;
            RoleComboBox.FormattingEnabled = true;
            RoleComboBox.Location = new Point(624, 75);
            RoleComboBox.Name = "RoleComboBox";
            RoleComboBox.Size = new Size(243, 28);
            RoleComboBox.TabIndex = 13;
            // 
            // PatronymicLabel
            // 
            PatronymicLabel.AutoSize = true;
            PatronymicLabel.Location = new Point(716, 178);
            PatronymicLabel.Name = "PatronymicLabel";
            PatronymicLabel.Size = new Size(72, 20);
            PatronymicLabel.TabIndex = 12;
            PatronymicLabel.Text = "Отчество";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(441, 178);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 20);
            NameLabel.TabIndex = 11;
            NameLabel.Text = "Имя";
            // 
            // PatronymicTextBox
            // 
            PatronymicTextBox.Cursor = Cursors.IBeam;
            PatronymicTextBox.Location = new Point(633, 201);
            PatronymicTextBox.Name = "PatronymicTextBox";
            PatronymicTextBox.Size = new Size(234, 27);
            PatronymicTextBox.TabIndex = 10;
            // 
            // NameTextBox
            // 
            NameTextBox.Cursor = Cursors.IBeam;
            NameTextBox.Location = new Point(333, 201);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(264, 27);
            NameTextBox.TabIndex = 9;
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(125, 178);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(73, 20);
            SurnameLabel.TabIndex = 8;
            SurnameLabel.Text = "Фамилия";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Cursor = Cursors.IBeam;
            SurnameTextBox.Location = new Point(33, 201);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(250, 27);
            SurnameTextBox.TabIndex = 7;
            // 
            // UserRoleLabel
            // 
            UserRoleLabel.AutoSize = true;
            UserRoleLabel.Location = new Point(716, 52);
            UserRoleLabel.Name = "UserRoleLabel";
            UserRoleLabel.Size = new Size(42, 20);
            UserRoleLabel.TabIndex = 6;
            UserRoleLabel.Text = "Роль";
            // 
            // UserPassportLabel
            // 
            UserPassportLabel.AutoSize = true;
            UserPassportLabel.Location = new Point(424, 55);
            UserPassportLabel.Name = "UserPassportLabel";
            UserPassportLabel.Size = new Size(68, 20);
            UserPassportLabel.TabIndex = 5;
            UserPassportLabel.Text = "Паспорт";
            // 
            // UserLoginLabel
            // 
            UserLoginLabel.AutoSize = true;
            UserLoginLabel.Location = new Point(125, 55);
            UserLoginLabel.Name = "UserLoginLabel";
            UserLoginLabel.Size = new Size(52, 20);
            UserLoginLabel.TabIndex = 4;
            UserLoginLabel.Text = "Логин";
            // 
            // UserPassportTextBox
            // 
            UserPassportTextBox.Cursor = Cursors.IBeam;
            UserPassportTextBox.Location = new Point(333, 76);
            UserPassportTextBox.Name = "UserPassportTextBox";
            UserPassportTextBox.Size = new Size(264, 27);
            UserPassportTextBox.TabIndex = 2;
            // 
            // UserLoginTextBox
            // 
            UserLoginTextBox.Cursor = Cursors.IBeam;
            UserLoginTextBox.Location = new Point(33, 76);
            UserLoginTextBox.Name = "UserLoginTextBox";
            UserLoginTextBox.Size = new Size(250, 27);
            UserLoginTextBox.TabIndex = 1;
            // 
            // AllInfoAboutUser
            // 
            AllInfoAboutUser.AutoSize = true;
            AllInfoAboutUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            AllInfoAboutUser.Location = new Point(311, 4);
            AllInfoAboutUser.Name = "AllInfoAboutUser";
            AllInfoAboutUser.Size = new Size(286, 25);
            AllInfoAboutUser.TabIndex = 0;
            AllInfoAboutUser.Text = "Вся информация о пользователе";
            // 
            // SearchUserByPassportPanel
            // 
            SearchUserByPassportPanel.Anchor = AnchorStyles.Top;
            SearchUserByPassportPanel.BackColor = Color.Transparent;
            SearchUserByPassportPanel.Location = new Point(150, 3);
            SearchUserByPassportPanel.Name = "SearchUserByPassportPanel";
            SearchUserByPassportPanel.Size = new Size(667, 187);
            SearchUserByPassportPanel.TabIndex = 32;
            // 
            // EditingPatientPanel
            // 
            EditingPatientPanel.Anchor = AnchorStyles.Top;
            EditingPatientPanel.Controls.Add(DateOfBirthDateTimePicker);
            EditingPatientPanel.Controls.Add(DateOfBirthLabel);
            EditingPatientPanel.Controls.Add(AddressLabel);
            EditingPatientPanel.Controls.Add(AddressTextBox);
            EditingPatientPanel.Enabled = false;
            EditingPatientPanel.Location = new Point(4, 255);
            EditingPatientPanel.Name = "EditingPatientPanel";
            EditingPatientPanel.Size = new Size(869, 88);
            EditingPatientPanel.TabIndex = 29;
            EditingPatientPanel.Visible = false;
            // 
            // DateOfBirthDateTimePicker
            // 
            DateOfBirthDateTimePicker.Location = new Point(588, 35);
            DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            DateOfBirthDateTimePicker.Size = new Size(235, 27);
            DateOfBirthDateTimePicker.TabIndex = 4;
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Location = new Point(646, 12);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(116, 20);
            DateOfBirthLabel.TabIndex = 3;
            DateOfBirthLabel.Text = "Дата рождения";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(133, 13);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(51, 20);
            AddressLabel.TabIndex = 2;
            AddressLabel.Text = "Адрес";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(20, 35);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(306, 27);
            AddressTextBox.TabIndex = 0;
            // 
            // EditingStaffPanel
            // 
            EditingStaffPanel.Anchor = AnchorStyles.Top;
            EditingStaffPanel.Controls.Add(WorkExperienceNumericUpDown);
            EditingStaffPanel.Controls.Add(SpecializationsComboBox);
            EditingStaffPanel.Controls.Add(SpecializationLabel);
            EditingStaffPanel.Controls.Add(WorkExperienceLabel);
            EditingStaffPanel.Enabled = false;
            EditingStaffPanel.Location = new Point(6, 268);
            EditingStaffPanel.Name = "EditingStaffPanel";
            EditingStaffPanel.Size = new Size(866, 77);
            EditingStaffPanel.TabIndex = 30;
            EditingStaffPanel.Visible = false;
            // 
            // WorkExperienceNumericUpDown
            // 
            WorkExperienceNumericUpDown.Cursor = Cursors.IBeam;
            WorkExperienceNumericUpDown.Location = new Point(57, 35);
            WorkExperienceNumericUpDown.Name = "WorkExperienceNumericUpDown";
            WorkExperienceNumericUpDown.Size = new Size(182, 27);
            WorkExperienceNumericUpDown.TabIndex = 5;
            // 
            // SpecializationsComboBox
            // 
            SpecializationsComboBox.Cursor = Cursors.Hand;
            SpecializationsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SpecializationsComboBox.FormattingEnabled = true;
            SpecializationsComboBox.Location = new Point(586, 35);
            SpecializationsComboBox.Name = "SpecializationsComboBox";
            SpecializationsComboBox.Size = new Size(211, 28);
            SpecializationsComboBox.TabIndex = 4;
            // 
            // SpecializationLabel
            // 
            SpecializationLabel.AutoSize = true;
            SpecializationLabel.Location = new Point(624, 12);
            SpecializationLabel.Name = "SpecializationLabel";
            SpecializationLabel.Size = new Size(119, 20);
            SpecializationLabel.TabIndex = 3;
            SpecializationLabel.Text = "Специализация";
            // 
            // WorkExperienceLabel
            // 
            WorkExperienceLabel.AutoSize = true;
            WorkExperienceLabel.Location = new Point(131, 12);
            WorkExperienceLabel.Name = "WorkExperienceLabel";
            WorkExperienceLabel.Size = new Size(43, 20);
            WorkExperienceLabel.TabIndex = 2;
            WorkExperienceLabel.Text = "Стаж";
            // 
            // SaveEditedUser
            // 
            SaveEditedUser.BackColor = Color.Transparent;
            SaveEditedUser.FlatStyle = FlatStyle.Popup;
            SaveEditedUser.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SaveEditedUser.ForeColor = Color.YellowGreen;
            SaveEditedUser.Location = new Point(349, 486);
            SaveEditedUser.Name = "SaveEditedUser";
            SaveEditedUser.Size = new Size(207, 32);
            SaveEditedUser.TabIndex = 31;
            SaveEditedUser.Text = "Сохранить";
            SaveEditedUser.UseVisualStyleBackColor = false;
            SaveEditedUser.Click += SaveEditedUser_Click;
            // 
            // EditingUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(SearchUserByPassportPanel);
            Controls.Add(SaveEditedUser);
            Controls.Add(BackToMenuButton);
            Controls.Add(CancelButton);
            Controls.Add(EditingStaffPanel);
            Controls.Add(EditingPatientPanel);
            Controls.Add(EditingUserPanel);
            DoubleBuffered = true;
            Name = "EditingUser";
            Size = new Size(876, 523);
            EditingUserPanel.ResumeLayout(false);
            EditingUserPanel.PerformLayout();
            EditingPatientPanel.ResumeLayout(false);
            EditingPatientPanel.PerformLayout();
            EditingStaffPanel.ResumeLayout(false);
            EditingStaffPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WorkExperienceNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button BackToMenuButton;
        private Button CancelButton;
        private Panel EditingUserPanel;
        private TextBox UserLoginTextBox;
        private Label AllInfoAboutUser;
        private TextBox UserPassportTextBox;
        private Label UserRoleLabel;
        private Label UserPassportLabel;
        private Label UserLoginLabel;
        private TextBox NameTextBox;
        private Label SurnameLabel;
        private TextBox SurnameTextBox;
        private Label NameLabel;
        private TextBox PatronymicTextBox;
        private Label PatronymicLabel;
        private Panel EditingPatientPanel;
        private TextBox AddressTextBox;
        private Label DateOfBirthLabel;
        private Label AddressLabel;
        private Panel EditingStaffPanel;
        private Label SpecializationLabel;
        private Label WorkExperienceLabel;
        private DateTimePicker DateOfBirthDateTimePicker;
        private ComboBox SpecializationsComboBox;
        private ComboBox RoleComboBox;
        private NumericUpDown WorkExperienceNumericUpDown;
        private Button SaveEditedUser;
        private Label WarningLabel;
        private Panel SearchUserByPassportPanel;
    }
}
