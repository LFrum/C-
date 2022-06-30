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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Form activateForm = this.ActiveMdiChild;
            if (activateForm != null)
            {
                ActiveForm.Close();
            }
        }

        private void newCarpetingCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new frmCarpeting();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void newHardwoodCostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new frmHardwood();
            newForm.MdiParent = this;
            newForm.Show();

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mnuNewCarpetingCosts.PerformClick();
        }

        private void btnHardwood_Click(object sender, EventArgs e)
        {
            mnuNewHardwoodCosts.PerformClick();
        }
    }
}
