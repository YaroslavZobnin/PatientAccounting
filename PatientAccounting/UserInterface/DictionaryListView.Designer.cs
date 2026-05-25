namespace PatientAccounting.UserInterface
{
    partial class DictionaryListView
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
            CancelButton = new Button();
            DictionaryGrid = new DataGridView();
            EditButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DictionaryGrid).BeginInit();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.BackColor = Color.Transparent;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Location = new Point(3, 500);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 39);
            CancelButton.TabIndex = 0;
            CancelButton.Text = "Назад";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // DictionaryGrid
            // 
            DictionaryGrid.AllowUserToAddRows = false;
            DictionaryGrid.AllowUserToDeleteRows = false;
            DictionaryGrid.Anchor = AnchorStyles.Top;
            DictionaryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DictionaryGrid.BackgroundColor = SystemColors.Control;
            DictionaryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DictionaryGrid.Location = new Point(112, 46);
            DictionaryGrid.Name = "DictionaryGrid";
            DictionaryGrid.RowHeadersWidth = 51;
            DictionaryGrid.Size = new Size(749, 409);
            DictionaryGrid.TabIndex = 1;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom;
            EditButton.BackColor = Color.Transparent;
            EditButton.FlatStyle = FlatStyle.Popup;
            EditButton.Location = new Point(402, 500);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(136, 39);
            EditButton.TabIndex = 2;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // DictionaryListView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EditButton);
            Controls.Add(DictionaryGrid);
            Controls.Add(CancelButton);
            Name = "DictionaryListView";
            Size = new Size(1007, 542);
            ((System.ComponentModel.ISupportInitialize)DictionaryGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CancelButton;
        private DataGridView DictionaryGrid;
        private Button EditButton;
    }
}
