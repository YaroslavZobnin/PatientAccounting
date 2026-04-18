namespace PatientAccounting
{
    partial class Authorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AuthorizationLabel = new Label();
            ExitButton = new Button();
            AskLoginLabel = new Label();
            AskPasswordLabel = new Label();
            InputLoginTextBox = new TextBox();
            InputPasswordTextBox = new TextBox();
            OpenedEyePictureBox = new PictureBox();
            ClosedEyePictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)OpenedEyePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClosedEyePictureBox).BeginInit();
            SuspendLayout();
            // 
            // AuthorizationLabel
            // 
            AuthorizationLabel.Anchor = AnchorStyles.Top;
            AuthorizationLabel.AutoSize = true;
            AuthorizationLabel.BackColor = Color.Transparent;
            AuthorizationLabel.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AuthorizationLabel.ForeColor = Color.Brown;
            AuthorizationLabel.Location = new Point(260, 9);
            AuthorizationLabel.Name = "AuthorizationLabel";
            AuthorizationLabel.Size = new Size(203, 49);
            AuthorizationLabel.TabIndex = 0;
            AuthorizationLabel.Text = "Авторизация";
            AuthorizationLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Transparent;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExitButton.Location = new Point(602, 350);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(86, 38);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // AskLoginLabel
            // 
            AskLoginLabel.Anchor = AnchorStyles.Left;
            AskLoginLabel.AutoSize = true;
            AskLoginLabel.BackColor = Color.Transparent;
            AskLoginLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AskLoginLabel.ForeColor = Color.DarkCyan;
            AskLoginLabel.Location = new Point(39, 136);
            AskLoginLabel.Name = "AskLoginLabel";
            AskLoginLabel.Size = new Size(149, 28);
            AskLoginLabel.TabIndex = 2;
            AskLoginLabel.Text = "Введите логин:";
            // 
            // AskPasswordLabel
            // 
            AskPasswordLabel.Anchor = AnchorStyles.Left;
            AskPasswordLabel.AutoSize = true;
            AskPasswordLabel.BackColor = Color.Transparent;
            AskPasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AskPasswordLabel.ForeColor = Color.DarkCyan;
            AskPasswordLabel.Location = new Point(27, 214);
            AskPasswordLabel.Name = "AskPasswordLabel";
            AskPasswordLabel.Size = new Size(161, 28);
            AskPasswordLabel.TabIndex = 3;
            AskPasswordLabel.Text = "Введите пароль:";
            // 
            // InputLoginTextBox
            // 
            InputLoginTextBox.Anchor = AnchorStyles.None;
            InputLoginTextBox.BackColor = SystemColors.HighlightText;
            InputLoginTextBox.BorderStyle = BorderStyle.None;
            InputLoginTextBox.Location = new Point(213, 144);
            InputLoginTextBox.Name = "InputLoginTextBox";
            InputLoginTextBox.PlaceholderText = "Например, Sasha_123";
            InputLoginTextBox.Size = new Size(430, 20);
            InputLoginTextBox.TabIndex = 4;
            // 
            // InputPasswordTextBox
            // 
            InputPasswordTextBox.Anchor = AnchorStyles.None;
            InputPasswordTextBox.BorderStyle = BorderStyle.None;
            InputPasswordTextBox.Location = new Point(213, 221);
            InputPasswordTextBox.Name = "InputPasswordTextBox";
            InputPasswordTextBox.Size = new Size(430, 20);
            InputPasswordTextBox.TabIndex = 5;
            InputPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // OpenedEyePictureBox
            // 
            OpenedEyePictureBox.Anchor = AnchorStyles.Right;
            OpenedEyePictureBox.BackColor = Color.Transparent;
            OpenedEyePictureBox.Cursor = Cursors.Hand;
            OpenedEyePictureBox.Enabled = false;
            OpenedEyePictureBox.Image = Properties.Resources.OpenEyeWithRemovedBg;
            OpenedEyePictureBox.Location = new Point(650, 211);
            OpenedEyePictureBox.Name = "OpenedEyePictureBox";
            OpenedEyePictureBox.Size = new Size(34, 38);
            OpenedEyePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenedEyePictureBox.TabIndex = 6;
            OpenedEyePictureBox.TabStop = false;
            OpenedEyePictureBox.Visible = false;
            OpenedEyePictureBox.Click += SwitchPasswordVisibility;
            // 
            // ClosedEyePictureBox
            // 
            ClosedEyePictureBox.Anchor = AnchorStyles.Right;
            ClosedEyePictureBox.BackColor = Color.Transparent;
            ClosedEyePictureBox.Cursor = Cursors.Hand;
            ClosedEyePictureBox.Image = Properties.Resources.ClosedEyeRemovedBg;
            ClosedEyePictureBox.Location = new Point(650, 211);
            ClosedEyePictureBox.Name = "ClosedEyePictureBox";
            ClosedEyePictureBox.Size = new Size(34, 38);
            ClosedEyePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ClosedEyePictureBox.TabIndex = 7;
            ClosedEyePictureBox.TabStop = false;
            ClosedEyePictureBox.Click += SwitchPasswordVisibility;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Authorization;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 400);
            Controls.Add(OpenedEyePictureBox);
            Controls.Add(InputPasswordTextBox);
            Controls.Add(InputLoginTextBox);
            Controls.Add(AskPasswordLabel);
            Controls.Add(AskLoginLabel);
            Controls.Add(ExitButton);
            Controls.Add(AuthorizationLabel);
            Controls.Add(ClosedEyePictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Authorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authorization";
            ((System.ComponentModel.ISupportInitialize)OpenedEyePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClosedEyePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AuthorizationLabel;
        private Button ExitButton;
        private Label AskLoginLabel;
        private Label AskPasswordLabel;
        private TextBox InputLoginTextBox;
        private TextBox InputPasswordTextBox;
        private PictureBox OpenedEyePictureBox;
        private PictureBox ClosedEyePictureBox;
    }
}
