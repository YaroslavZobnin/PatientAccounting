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
            BackToMenuButton = new Button();
            CancelButton = new Button();
            DeleteUserPanel = new Panel();
            SuspendLayout();
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
            // DeleteUserPanel
            // 
            DeleteUserPanel.Location = new Point(248, 50);
            DeleteUserPanel.Name = "DeleteUserPanel";
            DeleteUserPanel.Size = new Size(558, 207);
            DeleteUserPanel.TabIndex = 27;
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(DeleteUserPanel);
            Controls.Add(BackToMenuButton);
            Controls.Add(CancelButton);
            DoubleBuffered = true;
            Name = "DeleteUser";
            Size = new Size(876, 523);
            ResumeLayout(false);
        }

        #endregion
        private Button BackToMenuButton;
        private Button CancelButton;
        private Panel DeleteUserPanel;
    }
}
