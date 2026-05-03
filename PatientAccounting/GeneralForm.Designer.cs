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
            ExitButton = new Button();
            UserControlsPanel = new Panel();
            ButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.BackColor = Color.Transparent;
            ButtonsPanel.Controls.Add(ExitButton);
            ButtonsPanel.Dock = DockStyle.Right;
            ButtonsPanel.Location = new Point(774, 0);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(126, 550);
            ButtonsPanel.TabIndex = 1;
            // 
            // ExitButton
            // 
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
            ResumeLayout(false);
        }

        #endregion
        private Panel ButtonsPanel;
        private Panel UserControlsPanel;
        private Button ExitButton;
    }
}