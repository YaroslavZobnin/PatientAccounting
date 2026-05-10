using PatientAccounting.Services;
using System;
using System.Collections.Generic;
namespace PatientAccounting.UserInterface
{
    public partial class DoctorWindow : UserControl
    {
        private Staff? _staff;
        public DoctorWindow(Staff staff)
        {
            InitializeComponent();
            InitializeFullName();
        }
        private void InitializeFullName() => FullNameLabel.Text = GeneralMethods.GetFullName(_staff);

        //ПРИОРИТЕТ РАБОТЫ СМЕСТИЛСЯ НА ДРУГУЮ РОЛЬ.
    }
}
