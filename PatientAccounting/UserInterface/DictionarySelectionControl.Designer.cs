namespace PatientAccounting.UserInterface
{
    partial class DictionarySelectionControl
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
            ChoiceEditLabel = new Label();
            DiseaseButton = new Button();
            WardsButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // ChoiceEditLabel
            // 
            ChoiceEditLabel.Anchor = AnchorStyles.Top;
            ChoiceEditLabel.AutoSize = true;
            ChoiceEditLabel.BackColor = Color.Transparent;
            ChoiceEditLabel.Location = new Point(99, 0);
            ChoiceEditLabel.Name = "ChoiceEditLabel";
            ChoiceEditLabel.Size = new Size(374, 20);
            ChoiceEditLabel.TabIndex = 0;
            ChoiceEditLabel.Text = "Выберите над каким справочником будем работать";
            // 
            // DiseaseButton
            // 
            DiseaseButton.Anchor = AnchorStyles.Top;
            DiseaseButton.BackColor = Color.Transparent;
            DiseaseButton.FlatStyle = FlatStyle.Popup;
            DiseaseButton.Location = new Point(111, 47);
            DiseaseButton.Name = "DiseaseButton";
            DiseaseButton.Size = new Size(94, 42);
            DiseaseButton.TabIndex = 1;
            DiseaseButton.Text = "Болезни";
            DiseaseButton.UseVisualStyleBackColor = false;
            DiseaseButton.Click += DiseaseButton_Click;
            // 
            // WardsButton
            // 
            WardsButton.Anchor = AnchorStyles.Top;
            WardsButton.BackColor = Color.Transparent;
            WardsButton.FlatStyle = FlatStyle.Popup;
            WardsButton.Location = new Point(307, 47);
            WardsButton.Name = "WardsButton";
            WardsButton.Size = new Size(94, 42);
            WardsButton.TabIndex = 2;
            WardsButton.Text = "Палаты";
            WardsButton.UseVisualStyleBackColor = false;
            WardsButton.Click += WardsButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.BackColor = Color.Transparent;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Location = new Point(3, 295);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 31);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Назад";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // DictionarySelectionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CancelButton);
            Controls.Add(WardsButton);
            Controls.Add(DiseaseButton);
            Controls.Add(ChoiceEditLabel);
            Name = "DictionarySelectionControl";
            Size = new Size(539, 329);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChoiceEditLabel;
        private Button DiseaseButton;
        private Button WardsButton;
        private Button CancelButton;
    }
}
