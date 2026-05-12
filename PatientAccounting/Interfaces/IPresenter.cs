namespace PatientAccounting.Interfaces
{
    internal interface IPresenter
    {
        void ReturnToMainMenu();
        void ShowControl(UserControl newControl);
    }
}
