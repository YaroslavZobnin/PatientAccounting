using PatientAccounting.Data;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class PassportSearching : UserControl
    {
        public event Action<DataRow>? OnUserFound;
        public PassportSearching(string? comments)
        {
            InitializeComponent();
            CommentsLabel.Text = comments;
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string passport = PassportDataTextBox.Text.Trim();
            try
            {
                var dataTable = DataBaseProcessing.GetUserByPassport(passport);
                if (dataTable.Rows.Count > 0)
                    OnUserFound?.Invoke(dataTable.Rows[0]);
                else
                    MessageBox.Show("Пользователь с таким паспортом не найден.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при поиске по паспорту: {ex.Message}");
            }
        }
        public void Clear() => PassportDataTextBox.Clear();
    }
}
