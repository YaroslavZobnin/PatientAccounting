namespace PatientAccounting.UserInterface
{
    partial class CreateMedicalHistory
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
            CreateMedicalHistoryLabel = new Label();
            ChoicePanel = new Panel();
            GetPatientFromPassportRadioButton = new RadioButton();
            GetPatientFromListRadioButton = new RadioButton();
            SearchPatientLabel = new Label();
            ContentPanel = new Panel();
            CancelButton = new Button();
            ChoicePanel.SuspendLayout();
            SuspendLayout();
            // 
            // CreateMedicalHistoryLabel
            // 
            CreateMedicalHistoryLabel.Anchor = AnchorStyles.Top;
            CreateMedicalHistoryLabel.AutoSize = true;
            CreateMedicalHistoryLabel.BackColor = Color.Transparent;
            CreateMedicalHistoryLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            CreateMedicalHistoryLabel.Location = new Point(298, 0);
            CreateMedicalHistoryLabel.Name = "CreateMedicalHistoryLabel";
            CreateMedicalHistoryLabel.Size = new Size(329, 25);
            CreateMedicalHistoryLabel.TabIndex = 0;
            CreateMedicalHistoryLabel.Text = "Создание истории болезни пациента";
            // 
            // ChoicePanel
            // 
            ChoicePanel.Anchor = AnchorStyles.Top;
            ChoicePanel.BackColor = Color.Transparent;
            ChoicePanel.Controls.Add(GetPatientFromPassportRadioButton);
            ChoicePanel.Controls.Add(GetPatientFromListRadioButton);
            ChoicePanel.Controls.Add(SearchPatientLabel);
            ChoicePanel.Location = new Point(298, 28);
            ChoicePanel.Name = "ChoicePanel";
            ChoicePanel.Size = new Size(303, 75);
            ChoicePanel.TabIndex = 1;
            // 
            // GetPatientFromPassportRadioButton
            // 
            GetPatientFromPassportRadioButton.AutoSize = true;
            GetPatientFromPassportRadioButton.Location = new Point(182, 48);
            GetPatientFromPassportRadioButton.Name = "GetPatientFromPassportRadioButton";
            GetPatientFromPassportRadioButton.Size = new Size(118, 24);
            GetPatientFromPassportRadioButton.TabIndex = 2;
            GetPatientFromPassportRadioButton.Text = "По паспорту";
            GetPatientFromPassportRadioButton.UseVisualStyleBackColor = true;
            GetPatientFromPassportRadioButton.CheckedChanged += GetPatientFromPassportRadioButton_CheckedChanged;
            // 
            // GetPatientFromListRadioButton
            // 
            GetPatientFromListRadioButton.AutoSize = true;
            GetPatientFromListRadioButton.Location = new Point(37, 48);
            GetPatientFromListRadioButton.Name = "GetPatientFromListRadioButton";
            GetPatientFromListRadioButton.Size = new Size(100, 24);
            GetPatientFromListRadioButton.TabIndex = 1;
            GetPatientFromListRadioButton.Text = "По списку";
            GetPatientFromListRadioButton.UseVisualStyleBackColor = true;
            GetPatientFromListRadioButton.CheckedChanged += GetPatientFromListRadioButton_CheckedChanged;
            // 
            // SearchPatientLabel
            // 
            SearchPatientLabel.Anchor = AnchorStyles.Top;
            SearchPatientLabel.AutoSize = true;
            SearchPatientLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchPatientLabel.Location = new Point(53, 1);
            SearchPatientLabel.Name = "SearchPatientLabel";
            SearchPatientLabel.Size = new Size(223, 25);
            SearchPatientLabel.TabIndex = 0;
            SearchPatientLabel.Text = "Как осуществляем поиск?";
            // 
            // ContentPanel
            // 
            ContentPanel.Location = new Point(32, 106);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(816, 395);
            ContentPanel.TabIndex = 3;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Transparent;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Location = new Point(3, 507);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(93, 36);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Выход";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // CreateMedicalHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CancelButton);
            Controls.Add(ContentPanel);
            Controls.Add(ChoicePanel);
            Controls.Add(CreateMedicalHistoryLabel);
            DoubleBuffered = true;
            Name = "CreateMedicalHistory";
            Size = new Size(869, 546);
            ChoicePanel.ResumeLayout(false);
            ChoicePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateMedicalHistoryLabel;
        private Panel ChoicePanel;
        private RadioButton GetPatientFromPassportRadioButton;
        private RadioButton GetPatientFromListRadioButton;
        private Label SearchPatientLabel;
        private Panel ContentPanel;
        private Button CancelButton;
    }
}
