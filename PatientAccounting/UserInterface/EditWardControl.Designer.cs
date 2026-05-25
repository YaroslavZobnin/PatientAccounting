namespace PatientAccounting.UserInterface
{
    partial class EditWardControl
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
            WardNumberNumeric = new NumericUpDown();
            CapacityNumeric = new NumericUpDown();
            DepartmentComboBox = new ComboBox();
            WardTypeComboBox = new ComboBox();
            CancelButton = new Button();
            SaveButton = new Button();
            EditWardLabel = new Label();
            NumberWardLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)WardNumberNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CapacityNumeric).BeginInit();
            SuspendLayout();
            // 
            // WardNumberNumeric
            // 
            WardNumberNumeric.Anchor = AnchorStyles.Top;
            WardNumberNumeric.BorderStyle = BorderStyle.None;
            WardNumberNumeric.Location = new Point(294, 45);
            WardNumberNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            WardNumberNumeric.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            WardNumberNumeric.Name = "WardNumberNumeric";
            WardNumberNumeric.Size = new Size(242, 23);
            WardNumberNumeric.TabIndex = 0;
            WardNumberNumeric.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // CapacityNumeric
            // 
            CapacityNumeric.Anchor = AnchorStyles.Top;
            CapacityNumeric.BorderStyle = BorderStyle.None;
            CapacityNumeric.Location = new Point(294, 91);
            CapacityNumeric.Name = "CapacityNumeric";
            CapacityNumeric.Size = new Size(242, 23);
            CapacityNumeric.TabIndex = 1;
            CapacityNumeric.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // DepartmentComboBox
            // 
            DepartmentComboBox.Anchor = AnchorStyles.Top;
            DepartmentComboBox.Cursor = Cursors.Hand;
            DepartmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DepartmentComboBox.FormattingEnabled = true;
            DepartmentComboBox.Location = new Point(287, 143);
            DepartmentComboBox.Name = "DepartmentComboBox";
            DepartmentComboBox.Size = new Size(249, 28);
            DepartmentComboBox.TabIndex = 2;
            // 
            // WardTypeComboBox
            // 
            WardTypeComboBox.Anchor = AnchorStyles.Top;
            WardTypeComboBox.Cursor = Cursors.Hand;
            WardTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WardTypeComboBox.FormattingEnabled = true;
            WardTypeComboBox.Location = new Point(287, 192);
            WardTypeComboBox.Name = "WardTypeComboBox";
            WardTypeComboBox.Size = new Size(249, 28);
            WardTypeComboBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.BackColor = Color.Transparent;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Location = new Point(3, 303);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 4;
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
            SaveButton.Location = new Point(294, 303);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // EditWardLabel
            // 
            EditWardLabel.Anchor = AnchorStyles.Top;
            EditWardLabel.AutoSize = true;
            EditWardLabel.BackColor = Color.Transparent;
            EditWardLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EditWardLabel.Location = new Point(275, 0);
            EditWardLabel.Name = "EditWardLabel";
            EditWardLabel.Size = new Size(203, 23);
            EditWardLabel.TabIndex = 6;
            EditWardLabel.Text = "Редактирование палаты";
            // 
            // NumberWardLabel
            // 
            NumberWardLabel.Anchor = AnchorStyles.Top;
            NumberWardLabel.AutoSize = true;
            NumberWardLabel.BackColor = Color.Transparent;
            NumberWardLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            NumberWardLabel.Location = new Point(106, 45);
            NumberWardLabel.Name = "NumberWardLabel";
            NumberWardLabel.Size = new Size(173, 20);
            NumberWardLabel.TabIndex = 7;
            NumberWardLabel.Text = "Введите номер палаты";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(48, 90);
            label1.Name = "label1";
            label1.Size = new Size(231, 20);
            label1.TabIndex = 8;
            label1.Text = "Введите вместимость палаты";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(61, 146);
            label2.Name = "label2";
            label2.Size = new Size(216, 20);
            label2.TabIndex = 9;
            label2.Text = "Выберите отделение палаты";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(106, 195);
            label3.Name = "label3";
            label3.Size = new Size(171, 20);
            label3.TabIndex = 10;
            label3.Text = "Выберите тип палаты";
            // 
            // EditWardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NumberWardLabel);
            Controls.Add(EditWardLabel);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(WardTypeComboBox);
            Controls.Add(DepartmentComboBox);
            Controls.Add(CapacityNumeric);
            Controls.Add(WardNumberNumeric);
            Name = "EditWardControl";
            Size = new Size(726, 335);
            ((System.ComponentModel.ISupportInitialize)WardNumberNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)CapacityNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown WardNumberNumeric;
        private NumericUpDown CapacityNumeric;
        private ComboBox DepartmentComboBox;
        private ComboBox WardTypeComboBox;
        private Button CancelButton;
        private Button SaveButton;
        private Label EditWardLabel;
        private Label NumberWardLabel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
