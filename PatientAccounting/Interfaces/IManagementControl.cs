namespace PatientAccounting.Interfaces
{
    internal interface IManagementControl
    {
        void SaveProcess();
        void Cancel();
        void ExitToMenu();
        bool ValidateData();
        event Action OnClosed;
    }
}
