namespace PatientAccounting.UserInterface
{
    partial class EditDictionaryOfDiseases
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
            EditDictionaryOfDiseasesLabel = new Label();
            NameTextBox = new TextBox();
            NewNameLabel = new Label();
            CancelButton = new Button();
            SaveButton = new Button();
            CategoryComboBox = new ComboBox();
            DurationNumeric = new NumericUpDown();
            IsIncurableCheckBox = new CheckBox();
            ChoiceCategoryLabel = new Label();
            ChoiceDurationLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)DurationNumeric).BeginInit();
            SuspendLayout();
            // 
            // EditDiseaseLabel
            // 
            EditDictionaryOfDiseasesLabel.Anchor = AnchorStyles.Top;
            EditDictionaryOfDiseasesLabel.AutoSize = true;
            EditDictionaryOfDiseasesLabel.BackColor = Color.Transparent;
            EditDictionaryOfDiseasesLabel.Location = new Point(278, 0);
            EditDictionaryOfDiseasesLabel.Name = "EditDiseaseLabel";
            EditDictionaryOfDiseasesLabel.Size = new Size(186, 20);
            EditDictionaryOfDiseasesLabel.TabIndex = 0;
            EditDictionaryOfDiseasesLabel.Text = "Редактирование болезни";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top;
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameTextBox.Location = new Point(313, 60);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(402, 20);
            NameTextBox.TabIndex = 1;
            // 
            // NewNameLabel
            // 
            NewNameLabel.Anchor = AnchorStyles.Top;
            NewNameLabel.AutoSize = true;
            NewNameLabel.BackColor = Color.Transparent;
            NewNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            NewNameLabel.Location = new Point(52, 60);
            NewNameLabel.Name = "NewNameLabel";
            NewNameLabel.Size = new Size(236, 20);
            NewNameLabel.TabIndex = 2;
            NewNameLabel.Text = "Введите новое название болезни";
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.BackColor = Color.Transparent;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Location = new Point(3, 315);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Назад";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom;
            SaveButton.BackColor = Color.Transparent;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Location = new Point(338, 315);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(313, 109);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(402, 28);
            CategoryComboBox.TabIndex = 5;
            // 
            // DurationNumeric
            // 
            DurationNumeric.Anchor = AnchorStyles.Top;
            DurationNumeric.BorderStyle = BorderStyle.None;
            DurationNumeric.Location = new Point(314, 161);
            DurationNumeric.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            DurationNumeric.Name = "DurationNumeric";
            DurationNumeric.Size = new Size(401, 23);
            DurationNumeric.TabIndex = 6;
            // 
            // IsIncurableCheckBox
            // 
            IsIncurableCheckBox.AutoSize = true;
            IsIncurableCheckBox.Location = new Point(410, 190);
            IsIncurableCheckBox.Name = "IsIncurableCheckBox";
            IsIncurableCheckBox.Size = new Size(249, 24);
            IsIncurableCheckBox.TabIndex = 7;
            IsIncurableCheckBox.Text = "Неопределенная длительность";
            IsIncurableCheckBox.UseVisualStyleBackColor = true;
            IsIncurableCheckBox.CheckedChanged += IsIncurableCheckBox_CheckedChanged;
            // 
            // ChoiceCategoryLabel
            // 
            ChoiceCategoryLabel.Anchor = AnchorStyles.Top;
            ChoiceCategoryLabel.AutoSize = true;
            ChoiceCategoryLabel.BackColor = Color.Transparent;
            ChoiceCategoryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            ChoiceCategoryLabel.Location = new Point(81, 112);
            ChoiceCategoryLabel.Name = "ChoiceCategoryLabel";
            ChoiceCategoryLabel.Size = new Size(159, 20);
            ChoiceCategoryLabel.TabIndex = 8;
            ChoiceCategoryLabel.Text = "Выберите категорию";
            // 
            // ChoiceDurationLabel
            // 
            ChoiceDurationLabel.Anchor = AnchorStyles.Top;
            ChoiceDurationLabel.BackColor = Color.Transparent;
            ChoiceDurationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            ChoiceDurationLabel.Location = new Point(52, 160);
            ChoiceDurationLabel.Name = "ChoiceDurationLabel";
            ChoiceDurationLabel.Size = new Size(236, 100);
            ChoiceDurationLabel.TabIndex = 9;
            ChoiceDurationLabel.Text = "Введите длительность лечения (в днях)\r\nЕсли же длительность лечения неизвестна поставьте галочку под вводом длительности";
            ChoiceDurationLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // EditDictionaryOfDiseases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChoiceDurationLabel);
            Controls.Add(ChoiceCategoryLabel);
            Controls.Add(IsIncurableCheckBox);
            Controls.Add(DurationNumeric);
            Controls.Add(CategoryComboBox);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(NewNameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(EditDictionaryOfDiseasesLabel);
            Name = "EditDictionaryOfDiseases";
            Size = new Size(741, 347);
            ((System.ComponentModel.ISupportInitialize)DurationNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EditDictionaryOfDiseasesLabel;
        private TextBox NameTextBox;
        private Label NewNameLabel;
        private Button CancelButton;
        private Button SaveButton;
        private ComboBox CategoryComboBox;
        private NumericUpDown DurationNumeric;
        private CheckBox IsIncurableCheckBox;
        private Label ChoiceCategoryLabel;
        private Label ChoiceDurationLabel;
    }
}
