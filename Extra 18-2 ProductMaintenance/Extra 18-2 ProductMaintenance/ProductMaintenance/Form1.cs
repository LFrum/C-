using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Validate data entered in textboxes
            this.Validate();
            // Binding the data that is edited or added to the database
            this.productsBindingSource.EndEdit();
            // Updating all the data into the database
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);
        }
    }
}
