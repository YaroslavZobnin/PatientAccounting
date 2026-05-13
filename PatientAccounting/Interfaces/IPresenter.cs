namespace PatientAccounting.Interfaces
{
    internal interface IPresenter
    {
        void Reversion();
        void ShowControl(UserControl newControl);
    }
}
