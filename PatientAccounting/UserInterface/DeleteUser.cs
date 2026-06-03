using PatientAccounting.Data;
using PatientAccounting.Interfaces;
using System.Data;
namespace PatientAccounting.UserInterface
{
    public partial class DeleteUser : UserControl, IManagementControl, IWindowClosed
    {
        public event Action? OnClosed;
        private PassportSearching? _passportSearching;
        private DataRow? _foundUserRow;
        private string _adminPassport;
        public DeleteUser(string adminPassportData)
        {
            InitializeComponent();
            _adminPassport = adminPassportData;
            InitPassportSearch();
        }
        private void InitPassportSearch()
        {
            _passportSearching = new PassportSearching("Введите паспортные данные для УДАЛЕНИЯ пользователя", false);
            _passportSearching.Dock = DockStyle.Fill;
            DeleteUserPanel.Controls.Clear();
            DeleteUserPanel.Controls.Add(_passportSearching);
            _passportSearching.OnUserFound += (DataRow foundRow) =>
            {
                _foundUserRow = foundRow;
                SaveProcess();
            };
        }
        public void SaveProcess()
        {
            if (_foundUserRow == null) return;
            string? passport = _foundUserRow["customer_passport_data"].ToString();
            if (passport == _adminPassport)
            {
                MessageBox.Show(
                    "Вы не можете удалить собственный аккаунт из системы!",
                    "Защита от удаления",
                    MessageBoxButtons.OK,MessageBoxIcon.Stop
                );
                _foundUserRow = null;
                Cancel();
                return;
            }
            string fullName = GetUserFullName(_foundUserRow);
            if (ConfirmDelete(fullName, passport) != DialogResult.Yes)
            {
                _foundUserRow = null;
                return;
            }
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
        private string GetUserFullName(DataRow row)
        {
            if (row["role_name"].ToString() == "Пациент")
            {
                return $"{row["patient_surname"]} {row["patient_name"]} {row["patient_patronymic"]}";
            }
            else
            {
                return $"{row["staff_worker_surname"]} {row["staff_worker_name"]} {row["staff_worker_patronymic"]}";
            }
        }
        public void Cancel()
        {
            _foundUserRow = null;
            _passportSearching?.Clear();
        }
        public void ExitToMenu()
        {
            Cancel();
            OnClosed?.Invoke();
        }
        public bool ValidateData() => _foundUserRow != null;
        private DialogResult ConfirmDelete(string name, string passport)
            => MessageBox.Show($"Вы уверены, что хотите БЕЗВОЗВРАТНО удалить пользователя?\n\nФИО: {name}\nПаспорт: {passport}",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        private void BackToMenuButton_Click(object sender, EventArgs e) => ExitToMenu();
    }
}
