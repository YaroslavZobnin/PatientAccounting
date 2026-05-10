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
            SearchByListRadioButton = new RadioButton();
            SearchByPassportRadioButton = new RadioButton();
            ChoiceParameterLabel = new Label();
            ChoiceSearchParameterPanel.SuspendLayout();
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
            FullNameLabel.BackColor = Color.Transparent;
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
            ChoiceSearchParameterPanel.BackColor = Color.Transparent;
            ChoiceSearchParameterPanel.Controls.Add(SearchByListRadioButton);
            ChoiceSearchParameterPanel.Controls.Add(SearchByPassportRadioButton);
            ChoiceSearchParameterPanel.Controls.Add(ChoiceParameterLabel);
            ChoiceSearchParameterPanel.Location = new Point(276, 61);
            ChoiceSearchParameterPanel.Name = "ChoiceSearchParameterPanel";
            ChoiceSearchParameterPanel.Size = new Size(463, 69);
            ChoiceSearchParameterPanel.TabIndex = 5;
            // 
            // SearchByListRadioButton
            // 
            SearchByListRadioButton.AutoSize = true;
            SearchByListRadioButton.Location = new Point(248, 34);
            SearchByListRadioButton.Name = "SearchByListRadioButton";
            SearchByListRadioButton.Size = new Size(179, 24);
            SearchByListRadioButton.TabIndex = 2;
            SearchByListRadioButton.TabStop = true;
            SearchByListRadioButton.Text = "По списку пациентов";
            SearchByListRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchByPassportRadioButton
            // 
            SearchByPassportRadioButton.AutoSize = true;
            SearchByPassportRadioButton.Location = new Point(14, 34);
            SearchByPassportRadioButton.Name = "SearchByPassportRadioButton";
            SearchByPassportRadioButton.Size = new Size(118, 24);
            SearchByPassportRadioButton.TabIndex = 1;
            SearchByPassportRadioButton.TabStop = true;
            SearchByPassportRadioButton.Text = "По паспорту";
            SearchByPassportRadioButton.UseVisualStyleBackColor = true;
            // 
            // ChoiceParameterLabel
            // 
            ChoiceParameterLabel.AutoSize = true;
            ChoiceParameterLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChoiceParameterLabel.Location = new Point(102, 9);
            ChoiceParameterLabel.Name = "ChoiceParameterLabel";
            ChoiceParameterLabel.Size = new Size(219, 23);
            ChoiceParameterLabel.TabIndex = 0;
            ChoiceParameterLabel.Text = "Как осуществляем поиск?";
            // 
            // DoctorWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChoiceSearchParameterPanel);
            Controls.Add(SystemAdminLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(PersonalAccountLabel);
            DoubleBuffered = true;
            Name = "DoctorWindow";
            Size = new Size(879, 649);
            ChoiceSearchParameterPanel.ResumeLayout(false);
            ChoiceSearchParameterPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PersonalAccountLabel;
        private Label FullNameLabel;
        private Label SystemAdminLabel;
        private Panel ChoiceSearchParameterPanel;
        private RadioButton SearchByListRadioButton;
        private RadioButton SearchByPassportRadioButton;
        private Label ChoiceParameterLabel;
    }
}
