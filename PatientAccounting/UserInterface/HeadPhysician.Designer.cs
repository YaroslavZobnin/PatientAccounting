namespace PatientAccounting.UserInterface
{
    partial class HeadPhysician
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
            RoleNameLabel = new Label();
            GetAllListsButton = new Button();
            ChoiceActionPanel = new Panel();
            EditGuideButton = new Button();
            ChoiceLabel = new Label();
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
            PersonalAccountLabel.Location = new Point(365, 0);
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
            FullNameLabel.Location = new Point(105, 28);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(668, 30);
            FullNameLabel.TabIndex = 3;
            FullNameLabel.Text = "ФИО";
            FullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            RoleNameLabel.Size = new Size(128, 27);
            RoleNameLabel.TabIndex = 4;
            RoleNameLabel.Text = "Главный врач";
            // 
            // GetAllListsButton
            // 
            GetAllListsButton.BackColor = Color.Transparent;
            GetAllListsButton.FlatStyle = FlatStyle.Popup;
            GetAllListsButton.Location = new Point(72, 37);
            GetAllListsButton.Name = "GetAllListsButton";
            GetAllListsButton.Size = new Size(156, 53);
            GetAllListsButton.TabIndex = 5;
            GetAllListsButton.Text = "Просмотреть списки людей";
            GetAllListsButton.UseVisualStyleBackColor = false;
            GetAllListsButton.Click += GetAllListsButton_Click;
            // 
            // ChoiceActionPanel
            // 
            ChoiceActionPanel.Anchor = AnchorStyles.Top;
            ChoiceActionPanel.Controls.Add(EditGuideButton);
            ChoiceActionPanel.Controls.Add(ChoiceLabel);
            ChoiceActionPanel.Controls.Add(GetAllListsButton);
            ChoiceActionPanel.Location = new Point(33, 61);
            ChoiceActionPanel.Name = "ChoiceActionPanel";
            ChoiceActionPanel.Size = new Size(826, 99);
            ChoiceActionPanel.TabIndex = 6;
            // 
            // EditGuideButton
            // 
            EditGuideButton.BackColor = Color.Transparent;
            EditGuideButton.FlatStyle = FlatStyle.Popup;
            EditGuideButton.Location = new Point(250, 37);
            EditGuideButton.Name = "EditGuideButton";
            EditGuideButton.Size = new Size(156, 53);
            EditGuideButton.TabIndex = 7;
            EditGuideButton.Text = "Работа со справочниками";
            EditGuideButton.UseVisualStyleBackColor = false;
            EditGuideButton.Click += EditGuideButton_Click;
            // 
            // ChoiceLabel
            // 
            ChoiceLabel.AutoSize = true;
            ChoiceLabel.BackColor = Color.Transparent;
            ChoiceLabel.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChoiceLabel.Location = new Point(290, 0);
            ChoiceLabel.Name = "ChoiceLabel";
            ChoiceLabel.Size = new Size(265, 23);
            ChoiceLabel.TabIndex = 6;
            ChoiceLabel.Text = "Выберите необходимый пункт";
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top;
            MainPanel.Location = new Point(3, 81);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(873, 533);
            MainPanel.TabIndex = 7;
            // 
            // HeadPhysician
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChoiceActionPanel);
            Controls.Add(RoleNameLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(PersonalAccountLabel);
            Controls.Add(MainPanel);
            DoubleBuffered = true;
            Name = "HeadPhysician";
            Size = new Size(879, 649);
            ChoiceActionPanel.ResumeLayout(false);
            ChoiceActionPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PersonalAccountLabel;
        private Label FullNameLabel;
        private Label RoleNameLabel;
        private Button GetAllListsButton;
        private Panel ChoiceActionPanel;
        private Label ChoiceLabel;
        private Panel MainPanel;
        private Button EditGuideButton;
    }
}
