using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class AddNewUser : UserControl, IManagementControl
    {
        public event Action? OnClosed;
        public AddNewUser()
        {
            InitializeComponent();
        }
        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton == null || !radioButton.Checked) return;
            SwitchConditionRadioButton();
            SwitchVisibilityGeneralPanel();
            SwitchCancelButton();
            if (radioButton.Text == "Пациент")
                SwitchVisibilityPatientDataPanel();
            else
            {
                SwitchVisibilityStaffDataPanel();
                CheckingForDiscChoiceSpec(radioButton);
                FillSpecialtyMenu();
            }
        }
        private void ChoiceSpecializationTextBox_Click(object sender, EventArgs e)
            => ChoiceSpecializationContextMenuStrip.Show(ChoiceSpecializationTextBox, new Point(0, ChoiceSpecializationTextBox.Height));
        private void SwitchVisibilityGeneralPanel()
        {
            InputGeneralDataPanel.Visible = !InputGeneralDataPanel.Visible;
            InputGeneralDataPanel.Enabled = !InputGeneralDataPanel.Enabled;
        }
        private void SwitchVisibilityPatientDataPanel()
        {
            AddPatientDataPanel.Visible = !AddPatientDataPanel.Visible;
            AddPatientDataPanel.Enabled |= InputGeneralDataPanel.Enabled;
        }
        private void SwitchVisibilityStaffDataPanel()
        {
            InputStaffPanel.Visible = !InputStaffPanel.Visible;
            InputStaffPanel.Enabled = !InputStaffPanel.Enabled;
        }
        private void SwitchConditionRadioButton()
        {
            foreach (var c in ChoiceRolePanel.Controls)
                if (c is RadioButton radioButton)
                    radioButton.Enabled = !radioButton.Enabled;
        }
        private void SwitchCancelButton()
        {
            CancelButton.Visible = !CancelButton.Visible;
            CancelButton.Enabled = !CancelButton.Enabled;
        }
        private void ResettingTheSelection()
        {
            foreach (var c in ChoiceRolePanel.Controls)
                if (c is RadioButton radioButton)
                    radioButton.Checked = false;
        }
        private void ResetAdding()
        {
            InputGeneralDataPanel.Visible = false;
            InputGeneralDataPanel.Enabled = false;
            AddPatientDataPanel.Visible = false;
            AddPatientDataPanel.Enabled = false;
            InputStaffPanel.Visible = false;
            InputStaffPanel.Enabled = false;
            ResettingTheSelection();
            ClearInputPanels(this);
        }
        private void FillSpecialtyMenu()
        {
            var dataTable = DataBaseProcessing.GetSpecializations();
            ChoiceSpecializationContextMenuStrip.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                string? name = row["name_specialization"].ToString();
                int id = Convert.ToInt32(row["specialization_id"]);
                var item = new ToolStripMenuItem(name);
                item.Tag = id;
                item.Click += SpecialtyItem_Click;
                ChoiceSpecializationContextMenuStrip.Items.Add(item);
            }
        }
        private void SpecialtyItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            int selectedId = (int)clickedItem.Tag;
            string? selectedName = clickedItem.Text;
            ChoiceSpecializationTextBox.Text = selectedName;
        }
        private void CheckingForDiscChoiceSpec(RadioButton radioButton)
        {
            if (radioButton.Text == "Медицинский регистратор" || radioButton.Text == "Системный администратор")
                ChoiceSpecializationTextBox.Enabled = false;
            else
                ChoiceSpecializationTextBox.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e) => Cancel();

        private void ClearInputPanels(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox) textBox.Clear();
                if (control is DateTimePicker dateTimePicker) dateTimePicker.Value = DateTime.Now;
                if (control.HasChildren) ClearInputPanels(control);
            }
        }
        private void BackToMenuButton_Click(object sender, EventArgs e) => ExitToMenu();
        public void Cancel()
        {
            ResetAdding();
            SwitchConditionRadioButton();
            SwitchCancelButton();
        }
        public void ExitToMenu()
        {
            OnClosed?.Invoke();
            ClearInputPanels(this);
        }
        public void Save()
        {
            MessageBox.Show("QQ");
        }
        public bool ValidateData()
        {
            return true;
        }
    }
}

