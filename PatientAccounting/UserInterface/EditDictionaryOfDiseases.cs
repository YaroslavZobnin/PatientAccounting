using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class EditDictionaryOfDiseases : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        public event Action? OnDataSaved;
        private readonly int _diseaseId;
        private readonly bool _isEditMode;
        public EditDictionaryOfDiseases(int diseaseId, string currentName, int categoryId, object currentDuration)
        {
            InitializeComponent();
            _diseaseId = diseaseId;
            _isEditMode = true;
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
        public EditDictionaryOfDiseases()
        {
            InitializeComponent();
            _isEditMode = false;
            LoadCategoryComboBox();
            IsIncurableCheckBox.Checked = true;
            EditDictionaryOfDiseasesLabel.Text = "Добавление болезни";
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
            if(DurationNumeric.Value < 0)
            {
                MessageBox.Show("Лечение не может быть отрицательным");
                return;
            }
            try
            {
                int newCategoryId = Convert.ToInt32(CategoryComboBox.SelectedValue);
                int? newDuration = IsIncurableCheckBox.Checked ? (int?)null : Convert.ToInt32(DurationNumeric.Value);
                if (_isEditMode)
                {
                    DataBaseProcessing.UpdateDisease(_diseaseId, newName, newCategoryId, newDuration);
                    MessageBox.Show("Болезнь успешно обновлена!");
                }
                else
                {
                    DataBaseProcessing.AddDisease(newName, newCategoryId, newDuration);
                    MessageBox.Show("Новая болезнь успешно добавлена!");
                }
                OnDataSaved?.Invoke();
                OnClosed?.Invoke();
            }
            catch (Npgsql.PostgresException ex)
            {
                MessageBox.Show(
                    $"Болезнь с названием «{newName}» уже существует в справочнике!\n" +
                    "Пожалуйста, проверьте список или укажите другое название.",
                    "Дублирование данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
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
