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
            BackToMenuButton.Location = new Point(0, 476);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(110, 32);
            BackToMenuButton.TabIndex = 24;
            BackToMenuButton.Text = "Меню";
            BackToMenuButton.UseVisualStyleBackColor = false;
            BackToMenuButton.Click += BackToMenuButton_Click;
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
            DoubleBuffered = true;
            Name = "DeleteUser";
            Size = new Size(876, 523);
            ResumeLayout(false);
        }

        #endregion
        private Button BackToMenuButton;
        private Panel DeleteUserPanel;
    }
}
