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
            SystemAdminLabel = new Label();
            PersonalAccountLabel = new Label();
            FullNameLabel = new Label();
            ActionLabel = new Label();
            ChoicePanel = new Panel();
            EditButton = new Button();
            DeleteUserButton = new Button();
            AddUser = new Button();
            ChoiceLabel = new Label();
            MainEventPanel = new Panel();
            ChoicePanel.SuspendLayout();
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
            // MainEventPanel
            // 
            MainEventPanel.Anchor = AnchorStyles.Top;
            MainEventPanel.BackColor = Color.Transparent;
            MainEventPanel.Enabled = false;
            MainEventPanel.Location = new Point(0, 91);
            MainEventPanel.Name = "MainEventPanel";
            MainEventPanel.Size = new Size(876, 523);
            MainEventPanel.TabIndex = 9;
            MainEventPanel.Visible = false;
            // 
            // SystemAdministrator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainEventPanel);
            Controls.Add(ActionLabel);
            Controls.Add(ChoicePanel);
            Controls.Add(FullNameLabel);
            Controls.Add(PersonalAccountLabel);
            Controls.Add(SystemAdminLabel);
            DoubleBuffered = true;
            Name = "SystemAdministrator";
            Size = new Size(879, 649);
            ChoicePanel.ResumeLayout(false);
            ChoicePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SystemAdminLabel;
        private Label PersonalAccountLabel;
        private Label FullNameLabel;
        private Label ActionLabel;
        private Label InputPatientName;
        private Label InputPatientSurname;
        private Label InputPatientAddress;
        private Label label2;
        private Panel ChoicePanel;
        private Button EditButton;
        private Button DeleteUserButton;
        private Button AddUser;
        private Label ChoiceLabel;
        private Panel MainEventPanel;
    }
}
