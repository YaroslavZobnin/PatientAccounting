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
            AddButton = new Button();
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
            DictionaryGrid.Location = new Point(3, 0);
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
            EditButton.Location = new Point(377, 500);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(136, 39);
            EditButton.TabIndex = 2;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Transparent;
            AddButton.FlatStyle = FlatStyle.Popup;
            AddButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(696, 479);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(144, 60);
            AddButton.TabIndex = 3;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // DictionaryListView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddButton);
            Controls.Add(EditButton);
            Controls.Add(DictionaryGrid);
            Controls.Add(CancelButton);
            DoubleBuffered = true;
            Name = "DictionaryListView";
            Size = new Size(843, 542);
            ((System.ComponentModel.ISupportInitialize)DictionaryGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CancelButton;
        private DataGridView DictionaryGrid;
        private Button EditButton;
        private Button AddButton;
    }
}
