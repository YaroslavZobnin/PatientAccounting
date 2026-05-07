using PatientAccounting.Data;
using PatientAccounting.Interfaces;
namespace PatientAccounting.UserInterface
{
    public partial class DeleteUser : UserControl, IManagementControl
    {
        public event Action? OnClosed;
        public DeleteUser()
        {
            InitializeComponent();
        }
        private void FindUserByPassportButton_Click(object sender, EventArgs e) => SaveProcess();
        private void CancelButton_Click(object sender, EventArgs e) => Cancel();
        public void Cancel() => InputPassportDataTextBox.Clear();
        public void ExitToMenu()
        {
            InputPassportDataTextBox.Clear();
            OnClosed?.Invoke();
        }
        public void SaveProcess()
        {
            if (!ValidateData()) return;
            string passport = InputPassportDataTextBox.Text.Trim();
            if (ConfirmDeleteWithPassportData(passport) != DialogResult.Yes) return;
            try
            {
                DataBaseProcessing.DeleteUserByPassport(passport);
                MessageBox.Show("Пользователь и все связанные данные успешно удалены.", "Успех");
                ExitToMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(InputPassportDataTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите паспортные данные для поиска.");
                return false;
            }
            return true;
        }
        private DialogResult ConfirmDeleteWithPassportData(string passportData)
            => MessageBox.Show($"Вы уверены, что хотите безвозвратно удалить пользователя (Паспорт: {passportData})?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        private void BackToMenuButton_Click(object sender, EventArgs e) => ExitToMenu();
    }
}
