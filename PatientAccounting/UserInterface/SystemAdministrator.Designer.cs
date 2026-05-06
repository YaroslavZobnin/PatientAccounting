namespace PatientAccounting
{
    partial class SystemAdministrator
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
            components = new System.ComponentModel.Container();
            SystemAdminLabel = new Label();
            PersonalAccountLabel = new Label();
            FullNameLabel = new Label();
            ActionLabel = new Label();
            ChoicePanel = new Panel();
            EditButton = new Button();
            DeleteUserButton = new Button();
            AddUser = new Button();
            ChoiceLabel = new Label();
            ChoiceRolePanel = new Panel();
            SystemAdminRadioButton = new RadioButton();
            MedicalRegistar = new RadioButton();
            HeadDoctorRadioButton = new RadioButton();
            DoctorRadioButton = new RadioButton();
            PacientRadioButton = new RadioButton();
            ChoiceRoleLabel = new Label();
            InputGeneralDataPanel = new Panel();
            InputPatientNameLabel = new Label();
            InputPatientPatronymicTextBox = new TextBox();
            InputPatientNameTextBox = new TextBox();
            InputPatientSurnameTextBox = new TextBox();
            InputPatientPatronymic = new Label();
            InputPatientSurnameLabel = new Label();
            InputUserPassportData = new TextBox();
            InputUserPasswordTextBox = new TextBox();
            InputUserLoginTextBox = new TextBox();
            InputPassportDataLabel = new Label();
            InputUserPasswordLabel = new Label();
            InputUserLoginLabel = new Label();
            InputGeneralData = new Label();
            AddPatientDataPanel = new Panel();
            InputPatientAddressLabel = new Label();
            PatientDateOfBirthDateTimePicker = new DateTimePicker();
            InputPatientAdressTextBox = new TextBox();
            InputPatientDateOfBirthLabel = new Label();
            InputPatientDataLabel = new Label();
            InputStaffPanel = new Panel();
            ChoiceSpecializationTextBox = new TextBox();
            InputWorkExperienceTextBox = new TextBox();
            InputExperienceStaffLabel = new Label();
            SpecialityStaffLabel = new Label();
            InputStaffLabel = new Label();
            ChoiceSpecializationContextMenuStrip = new ContextMenuStrip(components);
            ChoicePanel.SuspendLayout();
            ChoiceRolePanel.SuspendLayout();
            InputGeneralDataPanel.SuspendLayout();
            AddPatientDataPanel.SuspendLayout();
            InputStaffPanel.SuspendLayout();
            SuspendLayout();
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
            SystemAdminLabel.Size = new Size(236, 27);
            SystemAdminLabel.TabIndex = 0;
            SystemAdminLabel.Text = "Системный администратор";
            // 
            // PersonalAccountLabel
            // 
            PersonalAccountLabel.Anchor = AnchorStyles.Top;
            PersonalAccountLabel.AutoSize = true;
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
            FullNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameLabel.Location = new Point(151, 35);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(668, 30);
            FullNameLabel.TabIndex = 2;
            FullNameLabel.Text = "ФИО";
            FullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ActionLabel
            // 
            ActionLabel.Anchor = AnchorStyles.Top;
            ActionLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ActionLabel.Location = new Point(366, 65);
            ActionLabel.Name = "ActionLabel";
            ActionLabel.Size = new Size(245, 23);
            ActionLabel.TabIndex = 8;
            ActionLabel.Text = "Действие";
            ActionLabel.TextAlign = ContentAlignment.MiddleCenter;
            ActionLabel.Visible = false;
            // 
            // ChoicePanel
            // 
            ChoicePanel.Anchor = AnchorStyles.Top;
            ChoicePanel.BackColor = Color.Transparent;
            ChoicePanel.Controls.Add(EditButton);
            ChoicePanel.Controls.Add(DeleteUserButton);
            ChoicePanel.Controls.Add(AddUser);
            ChoicePanel.Controls.Add(ChoiceLabel);
            ChoicePanel.Location = new Point(192, 143);
            ChoicePanel.Name = "ChoicePanel";
            ChoicePanel.Size = new Size(616, 132);
            ChoicePanel.TabIndex = 7;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditButton.Location = new Point(435, 65);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(160, 57);
            EditButton.TabIndex = 6;
            EditButton.Text = "Редактирование";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteUserButton.Location = new Point(217, 65);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(160, 57);
            DeleteUserButton.TabIndex = 5;
            DeleteUserButton.Text = "Удаление";
            DeleteUserButton.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            AddUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddUser.Location = new Point(8, 65);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(160, 57);
            AddUser.TabIndex = 4;
            AddUser.Text = "Добавление";
            AddUser.UseVisualStyleBackColor = true;
            AddUser.Click += AddUser_Click;
            // 
            // ChoiceLabel
            // 
            ChoiceLabel.AutoSize = true;
            ChoiceLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChoiceLabel.Location = new Point(74, 5);
            ChoiceLabel.Name = "ChoiceLabel";
            ChoiceLabel.Size = new Size(490, 25);
            ChoiceLabel.TabIndex = 3;
            ChoiceLabel.Text = "Выберите, какую манипуляцию вы будете проводить\r\n";
            // 
            // ChoiceRolePanel
            // 
            ChoiceRolePanel.Anchor = AnchorStyles.Top;
            ChoiceRolePanel.BackColor = Color.Transparent;
            ChoiceRolePanel.Controls.Add(SystemAdminRadioButton);
            ChoiceRolePanel.Controls.Add(MedicalRegistar);
            ChoiceRolePanel.Controls.Add(HeadDoctorRadioButton);
            ChoiceRolePanel.Controls.Add(DoctorRadioButton);
            ChoiceRolePanel.Controls.Add(PacientRadioButton);
            ChoiceRolePanel.Controls.Add(ChoiceRoleLabel);
            ChoiceRolePanel.Enabled = false;
            ChoiceRolePanel.Location = new Point(38, 92);
            ChoiceRolePanel.Name = "ChoiceRolePanel";
            ChoiceRolePanel.Size = new Size(826, 82);
            ChoiceRolePanel.TabIndex = 9;
            ChoiceRolePanel.Visible = false;
            // 
            // SystemAdminRadioButton
            // 
            SystemAdminRadioButton.AutoSize = true;
            SystemAdminRadioButton.Location = new Point(605, 48);
            SystemAdminRadioButton.Name = "SystemAdminRadioButton";
            SystemAdminRadioButton.Size = new Size(221, 24);
            SystemAdminRadioButton.TabIndex = 5;
            SystemAdminRadioButton.TabStop = true;
            SystemAdminRadioButton.Text = "Системный администратор";
            SystemAdminRadioButton.UseVisualStyleBackColor = true;
            SystemAdminRadioButton.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // MedicalRegistar
            // 
            MedicalRegistar.AutoSize = true;
            MedicalRegistar.Location = new Point(386, 48);
            MedicalRegistar.Name = "MedicalRegistar";
            MedicalRegistar.Size = new Size(217, 24);
            MedicalRegistar.TabIndex = 4;
            MedicalRegistar.TabStop = true;
            MedicalRegistar.Text = "Медицинский регистратор";
            MedicalRegistar.UseVisualStyleBackColor = true;
            MedicalRegistar.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // HeadDoctorRadioButton
            // 
            HeadDoctorRadioButton.AutoSize = true;
            HeadDoctorRadioButton.Location = new Point(286, 48);
            HeadDoctorRadioButton.Name = "HeadDoctorRadioButton";
            HeadDoctorRadioButton.Size = new Size(94, 24);
            HeadDoctorRadioButton.TabIndex = 3;
            HeadDoctorRadioButton.TabStop = true;
            HeadDoctorRadioButton.Text = "Главврач";
            HeadDoctorRadioButton.UseVisualStyleBackColor = true;
            HeadDoctorRadioButton.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // DoctorRadioButton
            // 
            DoctorRadioButton.AutoSize = true;
            DoctorRadioButton.Location = new Point(149, 48);
            DoctorRadioButton.Name = "DoctorRadioButton";
            DoctorRadioButton.Size = new Size(131, 24);
            DoctorRadioButton.TabIndex = 2;
            DoctorRadioButton.TabStop = true;
            DoctorRadioButton.Text = "Лечащий врач";
            DoctorRadioButton.UseVisualStyleBackColor = true;
            DoctorRadioButton.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // PacientRadioButton
            // 
            PacientRadioButton.AutoSize = true;
            PacientRadioButton.Location = new Point(53, 48);
            PacientRadioButton.Name = "PacientRadioButton";
            PacientRadioButton.Size = new Size(90, 24);
            PacientRadioButton.TabIndex = 1;
            PacientRadioButton.TabStop = true;
            PacientRadioButton.Text = "Пациент";
            PacientRadioButton.UseVisualStyleBackColor = true;
            PacientRadioButton.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // ChoiceRoleLabel
            // 
            ChoiceRoleLabel.AutoSize = true;
            ChoiceRoleLabel.BackColor = Color.Transparent;
            ChoiceRoleLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            ChoiceRoleLabel.Location = new Point(312, 5);
            ChoiceRoleLabel.Name = "ChoiceRoleLabel";
            ChoiceRoleLabel.Size = new Size(306, 23);
            ChoiceRoleLabel.TabIndex = 0;
            ChoiceRoleLabel.Text = "Выберите роль нового пользователя";
            // 
            // InputGeneralDataPanel
            // 
            InputGeneralDataPanel.Anchor = AnchorStyles.Top;
            InputGeneralDataPanel.BackColor = Color.Transparent;
            InputGeneralDataPanel.Controls.Add(InputPatientNameLabel);
            InputGeneralDataPanel.Controls.Add(InputPatientPatronymicTextBox);
            InputGeneralDataPanel.Controls.Add(InputPatientNameTextBox);
            InputGeneralDataPanel.Controls.Add(InputPatientSurnameTextBox);
            InputGeneralDataPanel.Controls.Add(InputPatientPatronymic);
            InputGeneralDataPanel.Controls.Add(InputPatientSurnameLabel);
            InputGeneralDataPanel.Controls.Add(InputUserPassportData);
            InputGeneralDataPanel.Controls.Add(InputUserPasswordTextBox);
            InputGeneralDataPanel.Controls.Add(InputUserLoginTextBox);
            InputGeneralDataPanel.Controls.Add(InputPassportDataLabel);
            InputGeneralDataPanel.Controls.Add(InputUserPasswordLabel);
            InputGeneralDataPanel.Controls.Add(InputUserLoginLabel);
            InputGeneralDataPanel.Controls.Add(InputGeneralData);
            InputGeneralDataPanel.Enabled = false;
            InputGeneralDataPanel.Location = new Point(38, 177);
            InputGeneralDataPanel.Name = "InputGeneralDataPanel";
            InputGeneralDataPanel.Size = new Size(826, 243);
            InputGeneralDataPanel.TabIndex = 10;
            InputGeneralDataPanel.Visible = false;
            // 
            // InputPatientNameLabel
            // 
            InputPatientNameLabel.AutoSize = true;
            InputPatientNameLabel.Location = new Point(15, 171);
            InputPatientNameLabel.Name = "InputPatientNameLabel";
            InputPatientNameLabel.Size = new Size(100, 20);
            InputPatientNameLabel.TabIndex = 12;
            InputPatientNameLabel.Text = "Введите имя:";
            // 
            // InputPatientPatronymicTextBox
            // 
            InputPatientPatronymicTextBox.BorderStyle = BorderStyle.None;
            InputPatientPatronymicTextBox.Location = new Point(302, 201);
            InputPatientPatronymicTextBox.Name = "InputPatientPatronymicTextBox";
            InputPatientPatronymicTextBox.Size = new Size(350, 20);
            InputPatientPatronymicTextBox.TabIndex = 11;
            // 
            // InputPatientNameTextBox
            // 
            InputPatientNameTextBox.BorderStyle = BorderStyle.None;
            InputPatientNameTextBox.Location = new Point(302, 171);
            InputPatientNameTextBox.Name = "InputPatientNameTextBox";
            InputPatientNameTextBox.Size = new Size(350, 20);
            InputPatientNameTextBox.TabIndex = 10;
            // 
            // InputPatientSurnameTextBox
            // 
            InputPatientSurnameTextBox.BorderStyle = BorderStyle.None;
            InputPatientSurnameTextBox.Location = new Point(302, 142);
            InputPatientSurnameTextBox.Name = "InputPatientSurnameTextBox";
            InputPatientSurnameTextBox.Size = new Size(350, 20);
            InputPatientSurnameTextBox.TabIndex = 9;
            // 
            // InputPatientPatronymic
            // 
            InputPatientPatronymic.AutoSize = true;
            InputPatientPatronymic.BackColor = Color.Transparent;
            InputPatientPatronymic.Location = new Point(15, 201);
            InputPatientPatronymic.Name = "InputPatientPatronymic";
            InputPatientPatronymic.Size = new Size(133, 40);
            InputPatientPatronymic.TabIndex = 8;
            InputPatientPatronymic.Text = "Введите отчество:\r\n(необязательно)";
            // 
            // InputPatientSurnameLabel
            // 
            InputPatientSurnameLabel.AutoSize = true;
            InputPatientSurnameLabel.BackColor = Color.Transparent;
            InputPatientSurnameLabel.Location = new Point(15, 142);
            InputPatientSurnameLabel.Name = "InputPatientSurnameLabel";
            InputPatientSurnameLabel.Size = new Size(139, 20);
            InputPatientSurnameLabel.TabIndex = 5;
            InputPatientSurnameLabel.Text = "Введите фамилию:";
            // 
            // InputUserPassportData
            // 
            InputUserPassportData.BorderStyle = BorderStyle.None;
            InputUserPassportData.Location = new Point(302, 113);
            InputUserPassportData.Name = "InputUserPassportData";
            InputUserPassportData.Size = new Size(350, 20);
            InputUserPassportData.TabIndex = 6;
            // 
            // InputUserPasswordTextBox
            // 
            InputUserPasswordTextBox.BorderStyle = BorderStyle.None;
            InputUserPasswordTextBox.Location = new Point(302, 72);
            InputUserPasswordTextBox.Name = "InputUserPasswordTextBox";
            InputUserPasswordTextBox.Size = new Size(350, 20);
            InputUserPasswordTextBox.TabIndex = 5;
            // 
            // InputUserLoginTextBox
            // 
            InputUserLoginTextBox.BorderStyle = BorderStyle.None;
            InputUserLoginTextBox.Location = new Point(302, 36);
            InputUserLoginTextBox.Name = "InputUserLoginTextBox";
            InputUserLoginTextBox.Size = new Size(350, 20);
            InputUserLoginTextBox.TabIndex = 4;
            // 
            // InputPassportDataLabel
            // 
            InputPassportDataLabel.AutoSize = true;
            InputPassportDataLabel.Location = new Point(15, 113);
            InputPassportDataLabel.Name = "InputPassportDataLabel";
            InputPassportDataLabel.Size = new Size(218, 20);
            InputPassportDataLabel.TabIndex = 3;
            InputPassportDataLabel.Text = "Введите паспортные данные: ";
            // 
            // InputUserPasswordLabel
            // 
            InputUserPasswordLabel.AutoSize = true;
            InputUserPasswordLabel.Location = new Point(15, 69);
            InputUserPasswordLabel.Name = "InputUserPasswordLabel";
            InputUserPasswordLabel.Size = new Size(158, 40);
            InputUserPasswordLabel.TabIndex = 2;
            InputUserPasswordLabel.Text = "Введите пароль: \r\n(забыть после ввода)";
            // 
            // InputUserLoginLabel
            // 
            InputUserLoginLabel.AutoSize = true;
            InputUserLoginLabel.Location = new Point(15, 36);
            InputUserLoginLabel.Name = "InputUserLoginLabel";
            InputUserLoginLabel.Size = new Size(117, 20);
            InputUserLoginLabel.TabIndex = 1;
            InputUserLoginLabel.Text = "Введите логин: ";
            // 
            // InputGeneralData
            // 
            InputGeneralData.AutoSize = true;
            InputGeneralData.BackColor = Color.Transparent;
            InputGeneralData.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            InputGeneralData.Location = new Point(328, 0);
            InputGeneralData.Name = "InputGeneralData";
            InputGeneralData.Size = new Size(258, 23);
            InputGeneralData.TabIndex = 0;
            InputGeneralData.Text = "Введите данные пользователя";
            // 
            // AddPatientDataPanel
            // 
            AddPatientDataPanel.Anchor = AnchorStyles.Top;
            AddPatientDataPanel.Controls.Add(InputPatientAddressLabel);
            AddPatientDataPanel.Controls.Add(PatientDateOfBirthDateTimePicker);
            AddPatientDataPanel.Controls.Add(InputPatientAdressTextBox);
            AddPatientDataPanel.Controls.Add(InputPatientDateOfBirthLabel);
            AddPatientDataPanel.Controls.Add(InputPatientDataLabel);
            AddPatientDataPanel.Enabled = false;
            AddPatientDataPanel.Location = new Point(38, 426);
            AddPatientDataPanel.Name = "AddPatientDataPanel";
            AddPatientDataPanel.Size = new Size(826, 124);
            AddPatientDataPanel.TabIndex = 11;
            AddPatientDataPanel.Visible = false;
            // 
            // InputPatientAddressLabel
            // 
            InputPatientAddressLabel.AutoSize = true;
            InputPatientAddressLabel.Location = new Point(15, 43);
            InputPatientAddressLabel.Name = "InputPatientAddressLabel";
            InputPatientAddressLabel.Size = new Size(112, 20);
            InputPatientAddressLabel.TabIndex = 9;
            InputPatientAddressLabel.Text = "Введите адрес:";
            // 
            // PatientDateOfBirthDateTimePicker
            // 
            PatientDateOfBirthDateTimePicker.Location = new Point(302, 68);
            PatientDateOfBirthDateTimePicker.Name = "PatientDateOfBirthDateTimePicker";
            PatientDateOfBirthDateTimePicker.Size = new Size(350, 27);
            PatientDateOfBirthDateTimePicker.TabIndex = 8;
            // 
            // InputPatientAdressTextBox
            // 
            InputPatientAdressTextBox.BorderStyle = BorderStyle.None;
            InputPatientAdressTextBox.Location = new Point(302, 43);
            InputPatientAdressTextBox.Name = "InputPatientAdressTextBox";
            InputPatientAdressTextBox.Size = new Size(350, 20);
            InputPatientAdressTextBox.TabIndex = 7;
            // 
            // InputPatientDateOfBirthLabel
            // 
            InputPatientDateOfBirthLabel.AutoSize = true;
            InputPatientDateOfBirthLabel.BackColor = Color.Transparent;
            InputPatientDateOfBirthLabel.Location = new Point(15, 75);
            InputPatientDateOfBirthLabel.Name = "InputPatientDateOfBirthLabel";
            InputPatientDateOfBirthLabel.Size = new Size(176, 20);
            InputPatientDateOfBirthLabel.TabIndex = 5;
            InputPatientDateOfBirthLabel.Text = "Введите дату рождения:";
            // 
            // InputPatientDataLabel
            // 
            InputPatientDataLabel.AutoSize = true;
            InputPatientDataLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            InputPatientDataLabel.Location = new Point(286, 9);
            InputPatientDataLabel.Name = "InputPatientDataLabel";
            InputPatientDataLabel.Size = new Size(380, 23);
            InputPatientDataLabel.TabIndex = 0;
            InputPatientDataLabel.Text = "Введите дополнительные данные о пациенте";
            // 
            // InputStaffPanel
            // 
            InputStaffPanel.Anchor = AnchorStyles.Top;
            InputStaffPanel.BackColor = Color.Transparent;
            InputStaffPanel.Controls.Add(ChoiceSpecializationTextBox);
            InputStaffPanel.Controls.Add(InputWorkExperienceTextBox);
            InputStaffPanel.Controls.Add(InputExperienceStaffLabel);
            InputStaffPanel.Controls.Add(SpecialityStaffLabel);
            InputStaffPanel.Controls.Add(InputStaffLabel);
            InputStaffPanel.Enabled = false;
            InputStaffPanel.Location = new Point(38, 425);
            InputStaffPanel.Name = "InputStaffPanel";
            InputStaffPanel.Size = new Size(826, 136);
            InputStaffPanel.TabIndex = 12;
            InputStaffPanel.Visible = false;
            // 
            // ChoiceSpecializationTextBox
            // 
            ChoiceSpecializationTextBox.BorderStyle = BorderStyle.None;
            ChoiceSpecializationTextBox.Location = new Point(302, 44);
            ChoiceSpecializationTextBox.Name = "ChoiceSpecializationTextBox";
            ChoiceSpecializationTextBox.Size = new Size(350, 20);
            ChoiceSpecializationTextBox.TabIndex = 13;
            ChoiceSpecializationTextBox.Click += ChoiceSpecializationTextBox_Click;
            // 
            // InputWorkExperienceTextBox
            // 
            InputWorkExperienceTextBox.BorderStyle = BorderStyle.None;
            InputWorkExperienceTextBox.Location = new Point(302, 76);
            InputWorkExperienceTextBox.Name = "InputWorkExperienceTextBox";
            InputWorkExperienceTextBox.Size = new Size(350, 20);
            InputWorkExperienceTextBox.TabIndex = 12;
            // 
            // InputExperienceStaffLabel
            // 
            InputExperienceStaffLabel.AutoSize = true;
            InputExperienceStaffLabel.Location = new Point(15, 76);
            InputExperienceStaffLabel.Name = "InputExperienceStaffLabel";
            InputExperienceStaffLabel.Size = new Size(160, 20);
            InputExperienceStaffLabel.TabIndex = 2;
            InputExperienceStaffLabel.Text = "Введите стаж работы:";
            // 
            // SpecialityStaffLabel
            // 
            SpecialityStaffLabel.AutoSize = true;
            SpecialityStaffLabel.Location = new Point(15, 44);
            SpecialityStaffLabel.Name = "SpecialityStaffLabel";
            SpecialityStaffLabel.Size = new Size(197, 20);
            SpecialityStaffLabel.TabIndex = 1;
            SpecialityStaffLabel.Text = "Выберите специализацию:";
            // 
            // InputStaffLabel
            // 
            InputStaffLabel.AutoSize = true;
            InputStaffLabel.BackColor = Color.Transparent;
            InputStaffLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            InputStaffLabel.Location = new Point(285, 1);
            InputStaffLabel.Name = "InputStaffLabel";
            InputStaffLabel.Size = new Size(379, 23);
            InputStaffLabel.TabIndex = 0;
            InputStaffLabel.Text = "Введите дополнительные данные сотруднику";
            // 
            // ChoiceSpecializationContextMenuStrip
            // 
            ChoiceSpecializationContextMenuStrip.ImageScalingSize = new Size(20, 20);
            ChoiceSpecializationContextMenuStrip.Name = "contextMenuStrip1";
            ChoiceSpecializationContextMenuStrip.Size = new Size(61, 4);
            // 
            // SystemAdministrator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InputGeneralDataPanel);
            Controls.Add(ChoiceRolePanel);
            Controls.Add(ActionLabel);
            Controls.Add(ChoicePanel);
            Controls.Add(FullNameLabel);
            Controls.Add(PersonalAccountLabel);
            Controls.Add(SystemAdminLabel);
            Controls.Add(InputStaffPanel);
            Controls.Add(AddPatientDataPanel);
            DoubleBuffered = true;
            Name = "SystemAdministrator";
            Size = new Size(879, 649);
            ChoicePanel.ResumeLayout(false);
            ChoicePanel.PerformLayout();
            ChoiceRolePanel.ResumeLayout(false);
            ChoiceRolePanel.PerformLayout();
            InputGeneralDataPanel.ResumeLayout(false);
            InputGeneralDataPanel.PerformLayout();
            AddPatientDataPanel.ResumeLayout(false);
            AddPatientDataPanel.PerformLayout();
            InputStaffPanel.ResumeLayout(false);
            InputStaffPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SystemAdminLabel;
        private Label PersonalAccountLabel;
        private Label FullNameLabel;
        private Label ActionLabel;
        private Panel ChoicePanel;
        private Panel ChoiceRolePanel;
        private Button EditButton;
        private Button DeleteUserButton;
        private Button AddUser;
        private Label ChoiceLabel;
        private RadioButton SystemAdminRadioButton;
        private RadioButton MedicalRegistar;
        private RadioButton HeadDoctorRadioButton;
        private RadioButton DoctorRadioButton;
        private RadioButton PacientRadioButton;
        private Label ChoiceRoleLabel;
        private Panel InputGeneralDataPanel;
        private Label InputGeneralData;
        private Label InputUserPasswordLabel;
        private Label InputUserLoginLabel;
        private TextBox InputUserPassportData;
        private TextBox InputUserPasswordTextBox;
        private TextBox InputUserLoginTextBox;
        private Label InputPassportDataLabel;
        private Panel AddPatientDataPanel;
        private Label InputPatientDataLabel;
        private Label InputPatientName;
        private Label InputPatientSurname;
        private Label InputPatientAddress;
        private Label label2;
        private Label InputPatientSurnameLabel;
        private Label InputPatientPatronymic;
        private Label InputPatientDateOfBirthLabel;
        private TextBox InputPatientSurnameTextBox;
        private TextBox InputPatientPatronymicTextBox;
        private TextBox InputPatientNameTextBox;
        private DateTimePicker PatientDateOfBirthDateTimePicker;
        private TextBox InputPatientAdressTextBox;
        private Label InputPatientNameLabel;
        private Label InputPatientAddressLabel;
        private Panel InputStaffPanel;
        private Label InputStaffLabel;
        private Label SpecialityStaffLabel;
        private Label InputExperienceStaffLabel;
        private TextBox InputWorkExperienceTextBox;
        private TextBox ChoiceSpecializationTextBox;
        private ContextMenuStrip ChoiceSpecializationContextMenuStrip;
    }
}
