using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rumainum_Week5
{
    public partial class frmCloneCustomer : Form
    {
        // Customer object and variables for customer object
        private Customer customer = new Customer();
        private string customerFirstName, customerLastName, customerEMailAddress;

        public frmCloneCustomer()
        {
            InitializeComponent();
        }

        private void frmCloneCustomer_Load(object sender, EventArgs e)
        {
            // initialize values for each variables
            customerFirstName = "John";
            customerLastName = "Mendez";
            customerEMailAddress = "jmendez@msysco.com";

            // Put the information in each variable
            customer.FirstName = customerFirstName;
            customer.LastName = customerLastName;
            customer.EMailAddress = customerEMailAddress;

            // show the customer information into the label lblCustomerList
            lblCustomerList.Text = customer.ToString();
        }

        // Clear the text(s) in the list box every time the txtCopyNum changed
        private void txtCopyNum_TextChanged(object sender, EventArgs e)
        {
            lstCloneCustomers.Items.Clear();
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            // The number of copies to clone
            int cloneNum = Convert.ToInt32(txtCopyNum.Text);
            
            // Creating a customer(s) list
            CustomerList<Customer> customerList = new CustomerList<Customer>();

            // Add the clones into a list
            for (int i = 0; i < cloneNum; ++i) {
                // use the Icloneable interface to clone the existing customer object
                customerList.Add((Customer)customer.Clone());
            }

            // use the IEnumerable<> interface method to write 
            // the object customer into the list box
            foreach (Customer customer in customerList)
            {
                lstCloneCustomers.Items.Add(customer);
            }
            
            /* Write into the listbox for Excercise 15-1
            for (int i = 0; i < cloneNum; ++i) {
                lstCloneCustomers.Items.Add(customerList[i]);
            }*/
        }

        // Close the windows form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
