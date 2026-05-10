using PatientAccounting.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientAccounting.UserInterface
{
    public partial class MedicalRegistrar : UserControl
    {
        private Staff staff;
        public MedicalRegistrar(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            InitializeFullName();
        }
        private void InitializeFullName() => FullNameLabel.Text = GeneralMethods.GetFullName(staff);
        private void SetPanelState(Panel panel, bool visibility)
        {
            panel.Visible = visibility;
            panel.Enabled = visibility;
        }
    }
}
