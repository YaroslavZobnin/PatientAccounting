namespace PatientAccounting.Interfaces
{
    public interface IWindowClosed
    {
        event Action? OnClosed;
    }
}
