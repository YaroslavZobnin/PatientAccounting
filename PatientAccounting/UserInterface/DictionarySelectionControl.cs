using PatientAccounting.Interfaces;
using PatientAccounting.Models;
namespace PatientAccounting.UserInterface
{
    public partial class DictionarySelectionControl : UserControl, IWindowClosed
    {
        public event Action? OnClosed;
        public event Action<ViewListMode>? OnModeSelected;
        public DictionarySelectionControl()
        {
            InitializeComponent();
        }
        private void DiseaseButton_Click(object sender, EventArgs e)
            => OnModeSelected?.Invoke(ViewListMode.Diseases);
        private void WardsButton_Click(object sender, EventArgs e)
            => OnModeSelected?.Invoke(ViewListMode.Wards);
        private void CancelButton_Click(object sender, EventArgs e)
            => OnClosed?.Invoke();
    }
}
