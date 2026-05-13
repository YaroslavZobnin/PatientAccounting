namespace PatientAccounting.UserInterface
{
    partial class PassportSearching
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
            SearchByPassportLabel = new Label();
            CommentsLabel = new Label();
            PassportDataTextBox = new TextBox();
            SearchButton = new Button();
            SuspendLayout();
            // 
            // SearchByPassportLabel
            // 
            SearchByPassportLabel.Anchor = AnchorStyles.Top;
            SearchByPassportLabel.AutoSize = true;
            SearchByPassportLabel.BackColor = Color.Transparent;
            SearchByPassportLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchByPassportLabel.Location = new Point(255, 0);
            SearchByPassportLabel.Name = "SearchByPassportLabel";
            SearchByPassportLabel.Size = new Size(169, 25);
            SearchByPassportLabel.TabIndex = 0;
            SearchByPassportLabel.Text = "Поиск по паспорту";
            // 
            // CommentsLabel
            // 
            CommentsLabel.Anchor = AnchorStyles.Top;
            CommentsLabel.BackColor = Color.Transparent;
            CommentsLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CommentsLabel.Location = new Point(93, 34);
            CommentsLabel.Name = "CommentsLabel";
            CommentsLabel.Size = new Size(504, 25);
            CommentsLabel.TabIndex = 1;
            CommentsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // PassportDataTextBox
            // 
            PassportDataTextBox.Anchor = AnchorStyles.Top;
            PassportDataTextBox.Location = new Point(93, 83);
            PassportDataTextBox.Name = "PassportDataTextBox";
            PassportDataTextBox.Size = new Size(492, 27);
            PassportDataTextBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Top;
            SearchButton.BackColor = Color.Transparent;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.Location = new Point(278, 126);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(115, 36);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // PassportSearching
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SearchButton);
            Controls.Add(PassportDataTextBox);
            Controls.Add(CommentsLabel);
            Controls.Add(SearchByPassportLabel);
            Name = "PassportSearching";
            Size = new Size(667, 187);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SearchByPassportLabel;
        private Label CommentsLabel;
        private TextBox PassportDataTextBox;
        private Button SearchButton;
    }
}
