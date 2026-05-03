using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientAccounting
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
            AdditionalButtons.Show(new Point(200, 300));
        }

        private void ExitButton_Click(object sender, EventArgs e) => this.Close();

    }
}
