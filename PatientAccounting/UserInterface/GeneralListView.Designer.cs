namespace PatientAccounting.UserInterface
{
    partial class GeneralListView
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
            ChoiceListLabel = new Label();
            ChoiceListPanel = new Panel();
            WardsRadioButton = new RadioButton();
            TreatmentRadioButton = new RadioButton();
            DiseaseRadioButton = new RadioButton();
            PatientListRadioButton = new RadioButton();
            DoctorListRadioButton = new RadioButton();
            StaffRadioButton = new RadioButton();
            OutputListPanel = new Panel();
            DeleteButton = new Button();
            EditButton = new Button();
            OutputInfoDataGridView = new DataGridView();
            ChoiceListPanel.SuspendLayout();
            OutputListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OutputInfoDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ChoiceListLabel
            // 
            ChoiceListLabel.Anchor = AnchorStyles.Top;
            ChoiceListLabel.AutoSize = true;
            ChoiceListLabel.BackColor = Color.Transparent;
            ChoiceListLabel.Location = new Point(420, 0);
            ChoiceListLabel.Name = "ChoiceListLabel";
            ChoiceListLabel.Size = new Size(130, 20);
            ChoiceListLabel.TabIndex = 0;
            ChoiceListLabel.Text = "Выберите список";
            // 
            // ChoiceListPanel
            // 
            ChoiceListPanel.BackColor = Color.Transparent;
            ChoiceListPanel.Controls.Add(WardsRadioButton);
            ChoiceListPanel.Controls.Add(TreatmentRadioButton);
            ChoiceListPanel.Controls.Add(DiseaseRadioButton);
            ChoiceListPanel.Controls.Add(PatientListRadioButton);
            ChoiceListPanel.Controls.Add(ChoiceListLabel);
            ChoiceListPanel.Controls.Add(DoctorListRadioButton);
            ChoiceListPanel.Controls.Add(StaffRadioButton);
            ChoiceListPanel.Location = new Point(3, 3);
            ChoiceListPanel.Name = "ChoiceListPanel";
            ChoiceListPanel.Size = new Size(843, 50);
            ChoiceListPanel.TabIndex = 1;
            // 
            // WardsRadioButton
            // 
            WardsRadioButton.AutoSize = true;
            WardsRadioButton.Enabled = false;
            WardsRadioButton.Location = new Point(683, 23);
            WardsRadioButton.Name = "WardsRadioButton";
            WardsRadioButton.Size = new Size(82, 24);
            WardsRadioButton.TabIndex = 5;
            WardsRadioButton.TabStop = true;
            WardsRadioButton.Text = "Палаты";
            WardsRadioButton.UseVisualStyleBackColor = true;
            WardsRadioButton.Visible = false;
            WardsRadioButton.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // TreatmentRadioButton
            // 
            TreatmentRadioButton.AutoSize = true;
            TreatmentRadioButton.Enabled = false;
            TreatmentRadioButton.Location = new Point(538, 23);
            TreatmentRadioButton.Name = "TreatmentRadioButton";
            TreatmentRadioButton.Size = new Size(90, 24);
            TreatmentRadioButton.TabIndex = 4;
            TreatmentRadioButton.TabStop = true;
            TreatmentRadioButton.Text = "Лечение";
            TreatmentRadioButton.UseVisualStyleBackColor = true;
            TreatmentRadioButton.Visible = false;
            TreatmentRadioButton.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // DiseaseRadioButton
            // 
            DiseaseRadioButton.AutoSize = true;
            DiseaseRadioButton.Enabled = false;
            DiseaseRadioButton.Location = new Point(231, 23);
            DiseaseRadioButton.Name = "DiseaseRadioButton";
            DiseaseRadioButton.Size = new Size(89, 24);
            DiseaseRadioButton.TabIndex = 3;
            DiseaseRadioButton.TabStop = true;
            DiseaseRadioButton.Text = "Болезни";
            DiseaseRadioButton.UseVisualStyleBackColor = true;
            DiseaseRadioButton.Visible = false;
            DiseaseRadioButton.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // PatientListRadioButton
            // 
            PatientListRadioButton.AutoSize = true;
            PatientListRadioButton.BackColor = Color.Transparent;
            PatientListRadioButton.Enabled = false;
            PatientListRadioButton.Location = new Point(431, 23);
            PatientListRadioButton.Name = "PatientListRadioButton";
            PatientListRadioButton.Size = new Size(101, 24);
            PatientListRadioButton.TabIndex = 1;
            PatientListRadioButton.TabStop = true;
            PatientListRadioButton.Text = "Пациенты";
            PatientListRadioButton.UseVisualStyleBackColor = false;
            PatientListRadioButton.Visible = false;
            PatientListRadioButton.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // DoctorListRadioButton
            // 
            DoctorListRadioButton.AutoSize = true;
            DoctorListRadioButton.BackColor = Color.Transparent;
            DoctorListRadioButton.Enabled = false;
            DoctorListRadioButton.Location = new Point(538, 23);
            DoctorListRadioButton.Name = "DoctorListRadioButton";
            DoctorListRadioButton.Size = new Size(139, 24);
            DoctorListRadioButton.TabIndex = 2;
            DoctorListRadioButton.TabStop = true;
            DoctorListRadioButton.Text = "Лечащие врачи";
            DoctorListRadioButton.UseVisualStyleBackColor = false;
            DoctorListRadioButton.Visible = false;
            DoctorListRadioButton.CheckedChanged += RadioButtons_CheckedChanged;
            // 
            // StaffRadioButton
            // 
            StaffRadioButton.AutoSize = true;
            StaffRadioButton.Enabled = false;
            StaffRadioButton.Location = new Point(326, 23);
            StaffRadioButton.Name = "StaffRadioButton";
            StaffRadioButton.Size = new Size(99, 24);
            StaffRadioButton.TabIndex = 6;
            StaffRadioButton.TabStop = true;
            StaffRadioButton.Text = "Персонал";
            StaffRadioButton.UseVisualStyleBackColor = true;
            StaffRadioButton.Visible = false;
            // 
            // OutputListPanel
            // 
            OutputListPanel.BackColor = Color.Transparent;
            OutputListPanel.Controls.Add(DeleteButton);
            OutputListPanel.Controls.Add(EditButton);
            OutputListPanel.Controls.Add(OutputInfoDataGridView);
            OutputListPanel.Location = new Point(4, 56);
            OutputListPanel.Name = "OutputListPanel";
            OutputListPanel.Size = new Size(862, 400);
            OutputListPanel.TabIndex = 2;
            OutputListPanel.Visible = false;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top;
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.Enabled = false;
            DeleteButton.FlatStyle = FlatStyle.Popup;
            DeleteButton.Location = new Point(628, 369);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(136, 28);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Visible = false;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top;
            EditButton.Cursor = Cursors.Hand;
            EditButton.Enabled = false;
            EditButton.FlatStyle = FlatStyle.Popup;
            EditButton.Location = new Point(381, 369);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(136, 28);
            EditButton.TabIndex = 1;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Visible = false;
            // 
            // OutputInfoDataGridView
            // 
            OutputInfoDataGridView.AllowUserToAddRows = false;
            OutputInfoDataGridView.AllowUserToDeleteRows = false;
            OutputInfoDataGridView.Anchor = AnchorStyles.Top;
            OutputInfoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OutputInfoDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            OutputInfoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OutputInfoDataGridView.Location = new Point(3, 3);
            OutputInfoDataGridView.Name = "OutputInfoDataGridView";
            OutputInfoDataGridView.RowHeadersWidth = 51;
            OutputInfoDataGridView.Size = new Size(856, 360);
            OutputInfoDataGridView.TabIndex = 0;
            // 
            // GeneralListView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OutputListPanel);
            Controls.Add(ChoiceListPanel);
            Name = "GeneralListView";
            Size = new Size(869, 458);
            ChoiceListPanel.ResumeLayout(false);
            ChoiceListPanel.PerformLayout();
            OutputListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OutputInfoDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label ChoiceListLabel;
        private Panel ChoiceListPanel;
        private RadioButton DoctorListRadioButton;
        private RadioButton PatientListRadioButton;
        private RadioButton DiseaseRadioButton;
        private RadioButton TreatmentRadioButton;
        private RadioButton WardsRadioButton;
        private Panel OutputListPanel;
        private DataGridView OutputInfoDataGridView;
        private RadioButton StaffRadioButton;
        private Button DeleteButton;
        private Button EditButton;
    }
}
