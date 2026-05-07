namespace PatientAccounting.UserInterface
{
    partial class DeleteUser
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
            InputPassportDataLabel = new Label();
            InputPassportDataTextBox = new TextBox();
            FindUserByPassportButton = new Button();
            BackToMenuButton = new Button();
            CancelButton = new Button();
            InfoAboutDeleteLabel = new Label();
            SuspendLayout();
            // 
            // InputPassportDataLabel
            // 
            InputPassportDataLabel.Anchor = AnchorStyles.Top;
            InputPassportDataLabel.AutoSize = true;
            InputPassportDataLabel.BackColor = Color.Transparent;
            InputPassportDataLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InputPassportDataLabel.Location = new Point(226, 95);
            InputPassportDataLabel.Name = "InputPassportDataLabel";
            InputPassportDataLabel.Size = new Size(534, 28);
            InputPassportDataLabel.TabIndex = 0;
            InputPassportDataLabel.Text = "Введите паспортные данные пользователя для удаления\r\n";
            // 
            // InputPassportDataTextBox
            // 
            InputPassportDataTextBox.Anchor = AnchorStyles.Top;
            InputPassportDataTextBox.Cursor = Cursors.IBeam;
            InputPassportDataTextBox.Location = new Point(250, 169);
            InputPassportDataTextBox.Name = "InputPassportDataTextBox";
            InputPassportDataTextBox.Size = new Size(431, 27);
            InputPassportDataTextBox.TabIndex = 1;
            // 
            // FindUserByPassportButton
            // 
            FindUserByPassportButton.Anchor = AnchorStyles.Top;
            FindUserByPassportButton.BackColor = Color.Transparent;
            FindUserByPassportButton.Cursor = Cursors.Hand;
            FindUserByPassportButton.FlatStyle = FlatStyle.Popup;
            FindUserByPassportButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FindUserByPassportButton.ForeColor = Color.Tomato;
            FindUserByPassportButton.Location = new Point(384, 227);
            FindUserByPassportButton.Name = "FindUserByPassportButton";
            FindUserByPassportButton.Size = new Size(153, 62);
            FindUserByPassportButton.TabIndex = 4;
            FindUserByPassportButton.Text = "Поиск";
            FindUserByPassportButton.UseVisualStyleBackColor = false;
            FindUserByPassportButton.Click += FindUserByPassportButton_Click;
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BackToMenuButton.BackColor = Color.Transparent;
            BackToMenuButton.Cursor = Cursors.Hand;
            BackToMenuButton.FlatStyle = FlatStyle.Popup;
            BackToMenuButton.Font = new Font("Sylfaen", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            BackToMenuButton.Location = new Point(124, 478);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(110, 32);
            BackToMenuButton.TabIndex = 24;
            BackToMenuButton.Text = "Меню";
            BackToMenuButton.UseVisualStyleBackColor = false;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.BackColor = Color.Transparent;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Sylfaen", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            CancelButton.Location = new Point(12, 478);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(106, 32);
            CancelButton.TabIndex = 23;
            CancelButton.Text = "Отменить";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // InfoAboutDeleteLabel
            // 
            InfoAboutDeleteLabel.AutoSize = true;
            InfoAboutDeleteLabel.BackColor = Color.Transparent;
            InfoAboutDeleteLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            InfoAboutDeleteLabel.Location = new Point(268, 123);
            InfoAboutDeleteLabel.Name = "InfoAboutDeleteLabel";
            InfoAboutDeleteLabel.Size = new Size(385, 20);
            InfoAboutDeleteLabel.TabIndex = 26;
            InfoAboutDeleteLabel.Text = "(Восстановление данных после удаления невозможно!)";
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InfoAboutDeleteLabel);
            Controls.Add(BackToMenuButton);
            Controls.Add(CancelButton);
            Controls.Add(FindUserByPassportButton);
            Controls.Add(InputPassportDataTextBox);
            Controls.Add(InputPassportDataLabel);
            Name = "DeleteUser";
            Size = new Size(876, 523);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InputPassportDataLabel;
        private TextBox InputPassportDataTextBox;
        private Button FindUserByPassportButton;
        private Button BackToMenuButton;
        private Button CancelButton;
        private Label InfoAboutDeleteLabel;
    }
}
