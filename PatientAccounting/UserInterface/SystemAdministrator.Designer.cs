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
            FullNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameLabel.Location = new Point(151, 35);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(668, 30);
            FullNameLabel.TabIndex = 2;
            FullNameLabel.Text = "ФИО";
            FullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SystemAdministrator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FullNameLabel);
            Controls.Add(PersonalAccountLabel);
            Controls.Add(SystemAdminLabel);
            Name = "SystemAdministrator";
            Size = new Size(879, 649);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SystemAdminLabel;
        private Label PersonalAccountLabel;
        private Label FullNameLabel;
    }
}
