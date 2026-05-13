namespace PatientAccounting.Interfaces
{
    public interface IPresenter
    {
        void Reversion();
        void ShowControl(IWindowClosed newControl);
    }
}
