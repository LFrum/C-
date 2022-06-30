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

        private void mnuFileCarpetingCosts_Click(object sender, EventArgs e)
        {
            Form newForm = new frmCarpeting();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void mnuFileHardwoodCosts_Click(object sender, EventArgs e)
        {
            Form newForm = new frmHardwood();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            Form activateForm = this.ActiveMdiChild;
            if (activateForm != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascadeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void btnCarpetingCosts_Click(object sender, EventArgs e)
        {
            mnuFileNewHardwoodCosts.PerformClick();
        }

        private void btnHardwoodCosts_Click(object sender, EventArgs e)
        {
            mnuFileNewCarpetingCosts.PerformClick();
        }
    }
}
