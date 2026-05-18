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
            UniversalGrid.Location = new Point(4, 2);
            UniversalGrid.Name = "UniversalGrid";
            UniversalGrid.RowHeadersWidth = 51;
            UniversalGrid.Size = new Size(740, 342);
            UniversalGrid.TabIndex = 0;
            // 
            // SelectButton
            // 
            SelectButton.Anchor = AnchorStyles.Bottom;
            SelectButton.BackColor = Color.Transparent;
            SelectButton.FlatStyle = FlatStyle.Popup;
            SelectButton.Location = new Point(288, 350);
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
            ExitButton.Location = new Point(4, 350);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(174, 30);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Отмена";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // GetPersonFromList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(ExitButton);
            Controls.Add(SelectButton);
            Controls.Add(UniversalGrid);
            DoubleBuffered = true;
            Name = "GetPersonFromList";
            Size = new Size(747, 385);
            ((System.ComponentModel.ISupportInitialize)UniversalGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView UniversalGrid;
        private Button SelectButton;
        private Button ExitButton;
    }
}
