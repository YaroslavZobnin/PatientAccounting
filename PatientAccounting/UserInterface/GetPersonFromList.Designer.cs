namespace PatientAccounting.UserInterface
{
    partial class GetPersonFromList
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
            UniversalGrid = new DataGridView();
            SelectButton = new Button();
            ExitButton = new Button();
            ArchiveDatePicker = new DateTimePicker();
            FilterByDateCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)UniversalGrid).BeginInit();
            SuspendLayout();
            // 
            // UniversalGrid
            // 
            UniversalGrid.AllowUserToAddRows = false;
            UniversalGrid.AllowUserToDeleteRows = false;
            UniversalGrid.Anchor = AnchorStyles.Top;
            UniversalGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UniversalGrid.BackgroundColor = SystemColors.ButtonFace;
            UniversalGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UniversalGrid.GridColor = SystemColors.Menu;
            UniversalGrid.Location = new Point(0, 36);
            UniversalGrid.Name = "UniversalGrid";
            UniversalGrid.RowHeadersWidth = 51;
            UniversalGrid.Size = new Size(821, 308);
            UniversalGrid.TabIndex = 0;
            // 
            // SelectButton
            // 
            SelectButton.Anchor = AnchorStyles.Top;
            SelectButton.BackColor = Color.Transparent;
            SelectButton.FlatStyle = FlatStyle.Popup;
            SelectButton.Location = new Point(325, 397);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(174, 30);
            SelectButton.TabIndex = 1;
            SelectButton.Text = "Выбрать";
            SelectButton.UseVisualStyleBackColor = false;
            SelectButton.Click += SelectButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.Location = new Point(4, 397);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(120, 30);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Назад";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ArchiveDatePicker
            // 
            ArchiveDatePicker.Anchor = AnchorStyles.Top;
            ArchiveDatePicker.Location = new Point(325, 3);
            ArchiveDatePicker.Name = "ArchiveDatePicker";
            ArchiveDatePicker.Size = new Size(200, 27);
            ArchiveDatePicker.TabIndex = 3;
            ArchiveDatePicker.ValueChanged += SearchDate_Changed;
            // 
            // FilterByDateCheckBox
            // 
            FilterByDateCheckBox.Anchor = AnchorStyles.Top;
            FilterByDateCheckBox.AutoSize = true;
            FilterByDateCheckBox.Location = new Point(297, 7);
            FilterByDateCheckBox.Name = "FilterByDateCheckBox";
            FilterByDateCheckBox.Size = new Size(18, 17);
            FilterByDateCheckBox.TabIndex = 4;
            FilterByDateCheckBox.UseVisualStyleBackColor = true;
            FilterByDateCheckBox.CheckedChanged += SearchDate_Changed;
            // 
            // GetPersonFromList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(FilterByDateCheckBox);
            Controls.Add(ArchiveDatePicker);
            Controls.Add(ExitButton);
            Controls.Add(SelectButton);
            Controls.Add(UniversalGrid);
            DoubleBuffered = true;
            Name = "GetPersonFromList";
            Size = new Size(821, 432);
            ((System.ComponentModel.ISupportInitialize)UniversalGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UniversalGrid;
        private Button SelectButton;
        private Button ExitButton;
        private DateTimePicker ArchiveDatePicker;
        private CheckBox FilterByDateCheckBox;
    }
}
