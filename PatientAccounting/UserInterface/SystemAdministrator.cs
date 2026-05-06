using PatientAccounting.Data;
using PatientAccounting.Services;
using System.Data;
namespace PatientAccounting
{
    public partial class SystemAdministrator : UserControl
    {
        private Staff staff;
        public SystemAdministrator(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            InitializeFullName();
        }
        private void InitializeFullName()
            => FullNameLabel.Text = GeneralMethods.GetFullName(staff);

        private void AddUser_Click(object sender, EventArgs e)
        {
            ActionLabel.Text = "Добавление пользователя";
            SwitchVisibilityChoicePanel();
            SwitchVisibilityChoiceRolePanel();
        }
        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton == null || !radioButton.Checked) return;
            SwitchConditionRadioButton();
            SwitchVisibilityGeneralPanel();
            if (radioButton.Text == "Пациент")
                SwitchVisibilityPatientDataPanel();
            else
            {
                SwitchVisibilityStaffDataPanel();
                FillSpecialtyMenu();
            }
        }
        private void ChoiceSpecializationTextBox_Click(object sender, EventArgs e)
            => ChoiceSpecializationContextMenuStrip.Show(ChoiceSpecializationTextBox, new Point(0, ChoiceSpecializationTextBox.Height));

        private void SwitchVisibilityChoicePanel()
        {
            ChoicePanel.Visible = !ChoicePanel.Visible;
            ChoicePanel.Enabled = !ChoicePanel.Enabled;
        }
        private void SwitchVisibilityChoiceRolePanel()
        {
            ChoiceRolePanel.Visible = !ChoiceRolePanel.Visible;
            ChoiceRolePanel.Enabled = !ChoiceRolePanel.Enabled;
        }
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

    }
}
