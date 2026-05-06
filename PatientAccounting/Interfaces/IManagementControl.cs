namespace PatientAccounting.Interfaces
{
    internal interface IManagementControl
    {
        void Save();
        void Cancel();
        void ExitToMenu();
        bool ValidateData();
        event Action OnClosed;
    }
}
