using PatientAccounting.Data;
using System.Data;
using PatientAccounting.Interfaces;
namespace PatientAccounting.UserInterface
{
    public partial class PassportSearching : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        public event Action<DataRow>? OnUserFound;
        public PassportSearching(string? comments, bool showBackButton = true)
        {
            InitializeComponent();
            CommentsLabel.Text = comments;
            SetButtonState(MenuButton, showBackButton);
        }
        public void SetButtonState(Button button, bool visible)
        {
            button.Visible = visible;
            button.Enabled = visible;
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
        public void Cancel() => Clear();
        private void CancelButton_Click(object sender, EventArgs e) => Cancel();

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Cancel();
            OnClosed?.Invoke();
        }
    }
}
