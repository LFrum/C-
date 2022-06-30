using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateFlooringCosts
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCarpetingCosts_Click(object sender, EventArgs e)
        {
            Form frmCarp = new frmCarpeting();
            frmCarp.Show();
        }

        private void btnHardwoodCosts_Click(object sender, EventArgs e)
        {
            Form frmHW= new frmHardwood();
            frmHW.Show();
        }
    }
}
