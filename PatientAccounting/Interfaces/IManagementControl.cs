namespace PatientAccounting.Interfaces
{
    public interface IManagementControl : IWindowClosed
    {
        void SaveProcess();
        void Cancel();
        void ExitToMenu();
        bool ValidateData();
    }
}
