using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class EditDisease : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        public event Action? OnDataSaved;
        private readonly int _diseaseId;
        public EditDisease(int diseaseId, string currentName, int categoryId, object currentDuration)
        {
            InitializeComponent();
            _diseaseId = diseaseId;
            LoadCategoryComboBox();
            NameTextBox.Text = currentName;
            CategoryComboBox.SelectedValue = categoryId;
            if (currentDuration != DBNull.Value && currentDuration != null)
            {
                DurationNumeric.Value = Convert.ToInt32(currentDuration);
                IsIncurableCheckBox.Checked = false;
            }
            else
                IsIncurableCheckBox.Checked = true;

        }
        private void CancelButton_Click(object sender, EventArgs e) => OnClosed?.Invoke();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string newName = NameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Название болезни не может быть пустым!");
                return;
            }
            try
            {
                int newCategoryId = Convert.ToInt32(CategoryComboBox.SelectedValue);
                int? newDuration = IsIncurableCheckBox.Checked
                    ? (int?)null
                    : Convert.ToInt32(DurationNumeric.Value);
                DataBaseProcessing.UpdateDisease(_diseaseId, newName, newCategoryId, newDuration);

                MessageBox.Show("Болезнь обновлена!");
                OnDataSaved?.Invoke();
                OnClosed?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private void LoadCategoryComboBox()
        {
            try
            {
                DataTable categories = DataBaseProcessing.GetDiseaseCategories();

                CategoryComboBox.DataSource = categories;
                CategoryComboBox.DisplayMember = "category_name"; 
                CategoryComboBox.ValueMember = "category_id";  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке категорий болезней: {ex.Message}",
                                "Ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void IsIncurableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DurationNumeric.Enabled = !IsIncurableCheckBox.Checked;
        }
    }
}
