namespace PatientAccounting
{
    partial class GeneralForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonsPanel = new Panel();
            ExtraMenuPanel = new Panel();
            FullScreenButton = new Button();
            BackToAuthorizationButton = new Button();
            ExtraMenuButton = new Button();
            ExitButton = new Button();
            UserControlsPanel = new Panel();
            ButtonsPanel.SuspendLayout();
            ExtraMenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.BackColor = Color.Transparent;
            ButtonsPanel.Controls.Add(ExtraMenuPanel);
            ButtonsPanel.Controls.Add(ExtraMenuButton);
            ButtonsPanel.Controls.Add(ExitButton);
            ButtonsPanel.Dock = DockStyle.Right;
            ButtonsPanel.Location = new Point(774, 0);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(126, 550);
            ButtonsPanel.TabIndex = 1;
            // 
            // ExtraMenuPanel
            // 
            ExtraMenuPanel.Anchor = AnchorStyles.Top;
            ExtraMenuPanel.Controls.Add(FullScreenButton);
            ExtraMenuPanel.Controls.Add(BackToAuthorizationButton);
            ExtraMenuPanel.Enabled = false;
            ExtraMenuPanel.Location = new Point(6, 54);
            ExtraMenuPanel.Name = "ExtraMenuPanel";
            ExtraMenuPanel.Size = new Size(114, 75);
            ExtraMenuPanel.TabIndex = 2;
            ExtraMenuPanel.Visible = false;
            // 
            // FullScreenButton
            // 
            FullScreenButton.Anchor = AnchorStyles.Top;
            FullScreenButton.FlatStyle = FlatStyle.Popup;
            FullScreenButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullScreenButton.Location = new Point(0, 36);
            FullScreenButton.Name = "FullScreenButton";
            FullScreenButton.Size = new Size(114, 33);
            FullScreenButton.TabIndex = 1;
            FullScreenButton.Text = "На весь экран";
            FullScreenButton.UseVisualStyleBackColor = true;
            // 
            // BackToAuthorizationButton
            // 
            BackToAuthorizationButton.Anchor = AnchorStyles.Top;
            BackToAuthorizationButton.FlatStyle = FlatStyle.Popup;
            BackToAuthorizationButton.Location = new Point(0, 3);
            BackToAuthorizationButton.Name = "BackToAuthorizationButton";
            BackToAuthorizationButton.Size = new Size(114, 27);
            BackToAuthorizationButton.TabIndex = 0;
            BackToAuthorizationButton.Text = "Авторизация";
            BackToAuthorizationButton.UseVisualStyleBackColor = true;
            // 
            // ExtraMenuButton
            // 
            ExtraMenuButton.Anchor = AnchorStyles.Top;
            ExtraMenuButton.Cursor = Cursors.Hand;
            ExtraMenuButton.FlatAppearance.BorderColor = Color.Gray;
            ExtraMenuButton.FlatStyle = FlatStyle.Flat;
            ExtraMenuButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExtraMenuButton.Location = new Point(6, 12);
            ExtraMenuButton.Name = "ExtraMenuButton";
            ExtraMenuButton.Size = new Size(114, 27);
            ExtraMenuButton.TabIndex = 1;
            ExtraMenuButton.Text = "Дополнительно";
            ExtraMenuButton.UseVisualStyleBackColor = true;
            ExtraMenuButton.Click += ExtraMenuButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.Location = new Point(14, 511);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(100, 27);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // UserControlsPanel
            // 
            UserControlsPanel.BackColor = Color.Transparent;
            UserControlsPanel.Dock = DockStyle.Fill;
            UserControlsPanel.Location = new Point(0, 0);
            UserControlsPanel.Name = "UserControlsPanel";
            UserControlsPanel.Size = new Size(774, 550);
            UserControlsPanel.TabIndex = 2;
            // 
            // GeneralForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundForGeneralForm;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 550);
            Controls.Add(UserControlsPanel);
            Controls.Add(ButtonsPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GeneralForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ButtonsPanel.ResumeLayout(false);
            ExtraMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel ButtonsPanel;
        private Panel UserControlsPanel;
        private Button ExitButton;
        private Panel ExtraMenuPanel;
        private Button ExtraMenuButton;
        private Button BackToAuthorizationButton;
        private Button FullScreenButton;
    }
}