namespace PatientAccounting.UserInterface
{
    partial class AddNewUser
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
            BackToMenuButton = new Button();
            CancelButton = new Button();
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
            ChoiceRolePanel = new Panel();
            SystemAdminRadioButton = new RadioButton();
            MedicalRegistar = new RadioButton();
            HeadDoctorRadioButton = new RadioButton();
            DoctorRadioButton = new RadioButton();
            PacientRadioButton = new RadioButton();
            ChoiceRoleLabel = new Label();
            InputStaffPanel = new Panel();
            ChoiceSpecializationTextBox = new TextBox();
            InputWorkExperienceTextBox = new TextBox();
            InputExperienceStaffLabel = new Label();
            SpecialityStaffLabel = new Label();
            InputStaffLabel = new Label();
            AddPatientDataPanel = new Panel();
            InputPatientAddressLabel = new Label();
            PatientDateOfBirthDateTimePicker = new DateTimePicker();
            InputPatientAdressTextBox = new TextBox();
            InputPatientDateOfBirthLabel = new Label();
            InputPatientDataLabel = new Label();
            ChoiceSpecializationContextMenuStrip = new ContextMenuStrip(components);
            InputGeneralDataPanel.SuspendLayout();
            ChoiceRolePanel.SuspendLayout();
            InputStaffPanel.SuspendLayout();
            AddPatientDataPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BackToMenuButton.BackColor = Color.Transparent;
            BackToMenuButton.Cursor = Cursors.Hand;
            BackToMenuButton.FlatStyle = FlatStyle.Popup;
            BackToMenuButton.Font = new Font("Sylfaen", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            BackToMenuButton.Location = new Point(126, 485);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(110, 32);
            BackToMenuButton.TabIndex = 21;
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
            CancelButton.Location = new Point(14, 485);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(106, 32);
            CancelButton.TabIndex = 20;
            CancelButton.Text = "Отменить";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Visible = false;
            CancelButton.Click += CancelButton_Click;
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
            InputGeneralDataPanel.Location = new Point(19, 92);
            InputGeneralDataPanel.Name = "InputGeneralDataPanel";
            InputGeneralDataPanel.Size = new Size(826, 243);
            InputGeneralDataPanel.TabIndex = 17;
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
            ChoiceRolePanel.Location = new Point(19, 6);
            ChoiceRolePanel.Name = "ChoiceRolePanel";
            ChoiceRolePanel.Size = new Size(826, 82);
            ChoiceRolePanel.TabIndex = 16;
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
            InputStaffPanel.Location = new Point(19, 337);
            InputStaffPanel.Name = "InputStaffPanel";
            InputStaffPanel.Size = new Size(826, 136);
            InputStaffPanel.TabIndex = 19;
            InputStaffPanel.Visible = false;
            // 
            // ChoiceSpecializationTextBox
            // 
            ChoiceSpecializationTextBox.BorderStyle = BorderStyle.None;
            ChoiceSpecializationTextBox.Location = new Point(302, 44);
            ChoiceSpecializationTextBox.Name = "ChoiceSpecializationTextBox";
            ChoiceSpecializationTextBox.ReadOnly = true;
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
            // AddPatientDataPanel
            // 
            AddPatientDataPanel.Anchor = AnchorStyles.Top;
            AddPatientDataPanel.Controls.Add(InputPatientAddressLabel);
            AddPatientDataPanel.Controls.Add(PatientDateOfBirthDateTimePicker);
            AddPatientDataPanel.Controls.Add(InputPatientAdressTextBox);
            AddPatientDataPanel.Controls.Add(InputPatientDateOfBirthLabel);
            AddPatientDataPanel.Controls.Add(InputPatientDataLabel);
            AddPatientDataPanel.Enabled = false;
            AddPatientDataPanel.Location = new Point(19, 340);
            AddPatientDataPanel.Name = "AddPatientDataPanel";
            AddPatientDataPanel.Size = new Size(826, 124);
            AddPatientDataPanel.TabIndex = 18;
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
            // ChoiceSpecializationContextMenuStrip
            // 
            ChoiceSpecializationContextMenuStrip.BackColor = Color.Transparent;
            ChoiceSpecializationContextMenuStrip.ImageScalingSize = new Size(20, 20);
            ChoiceSpecializationContextMenuStrip.Name = "ChoiceSpecializationContextMenuStrip";
            ChoiceSpecializationContextMenuStrip.Size = new Size(61, 4);
            // 
            // AddNewUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BackToMenuButton);
            Controls.Add(CancelButton);
            Controls.Add(InputGeneralDataPanel);
            Controls.Add(ChoiceRolePanel);
            Controls.Add(InputStaffPanel);
            Controls.Add(AddPatientDataPanel);
            Name = "AddNewUser";
            Size = new Size(876, 523);
            InputGeneralDataPanel.ResumeLayout(false);
            InputGeneralDataPanel.PerformLayout();
            ChoiceRolePanel.ResumeLayout(false);
            ChoiceRolePanel.PerformLayout();
            InputStaffPanel.ResumeLayout(false);
            InputStaffPanel.PerformLayout();
            AddPatientDataPanel.ResumeLayout(false);
            AddPatientDataPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BackToMenuButton;
        private Button CancelButton;
        private Panel InputGeneralDataPanel;
        private Label InputPatientNameLabel;
        private TextBox InputPatientPatronymicTextBox;
        private TextBox InputPatientNameTextBox;
        private TextBox InputPatientSurnameTextBox;
        private Label InputPatientPatronymic;
        private Label InputPatientSurnameLabel;
        private TextBox InputUserPassportData;
        private TextBox InputUserPasswordTextBox;
        private TextBox InputUserLoginTextBox;
        private Label InputPassportDataLabel;
        private Label InputUserPasswordLabel;
        private Label InputUserLoginLabel;
        private Label InputGeneralData;
        private Panel ChoiceRolePanel;
        private RadioButton SystemAdminRadioButton;
        private RadioButton MedicalRegistar;
        private RadioButton HeadDoctorRadioButton;
        private RadioButton DoctorRadioButton;
        private RadioButton PacientRadioButton;
        private Label ChoiceRoleLabel;
        private Panel InputStaffPanel;
        private TextBox ChoiceSpecializationTextBox;
        private TextBox InputWorkExperienceTextBox;
        private Label InputExperienceStaffLabel;
        private Label SpecialityStaffLabel;
        private Label InputStaffLabel;
        private Panel AddPatientDataPanel;
        private Label InputPatientAddressLabel;
        private DateTimePicker PatientDateOfBirthDateTimePicker;
        private TextBox InputPatientAdressTextBox;
        private Label InputPatientDateOfBirthLabel;
        private Label InputPatientDataLabel;
        private ContextMenuStrip ChoiceSpecializationContextMenuStrip;
    }
}
