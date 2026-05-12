namespace PatientAccounting.Interfaces
{
    internal interface IWindowClosed
    {
        event Action? OnClosed;
    }
}
