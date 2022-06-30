using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rumainum_Week3
{
    public partial class frmLunchOrder : Form
    {
        double mainCoursePrice; // price of main course
        double eachAddOnPrice; // price of each add-on
        double totalAddOnsPrice; // total price of add-on(s)
        double subtotalPrice; // subtotal of the order
        double taxPrice; // tax price of the subtotal
        double orderTotalPrice; // total price of the order        

        public frmLunchOrder()
        {
            InitializeComponent();
            // Default radio button on Hamburger
            rdoHamburger.Checked = true;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // Reset totals 
                ClearTotals();

                // Validating entries on which checked button(s) is/are true
                // to be added into the total add-on(s) price
                if (chkLettucePepperoniCroutons.Checked == true)
                {
                    totalAddOnsPrice += eachAddOnPrice;
                }
                if (chkKetchupSausageBaconBits.Checked == true)
                {
                    totalAddOnsPrice += eachAddOnPrice;
                }
                if (chkFrenchFriesOlivesBreadSticks.Checked == true)
                {
                    totalAddOnsPrice += eachAddOnPrice;
                }
                
                // Calculating subtotal Price
                subtotalPrice = mainCoursePrice + totalAddOnsPrice;
                // Calculating tax price
                taxPrice = calculateTaxPrice(subtotalPrice);
                // Calculating total price
                orderTotalPrice = subtotalPrice + taxPrice;

                // Show the anwers into the text boxes
                txtSubtotal.Text = subtotalPrice.ToString("c");
                txtTaxTotal.Text = taxPrice.ToString("c");
                txtOrderTotal.Text = orderTotalPrice.ToString("c");
            }
            // This might happen if main course and/or add-ons set too high
            // and the calculated total(s) over flow
            catch (OverflowException)
            {
                MessageBox.Show("An overflow exception has occurred.", "Entry Error");
            }
            
        }

        // Calculating the tax price
        private double calculateTaxPrice (double subtotalPrice)
        {            
            const double TaxRate = 0.0775;

            return taxPrice = subtotalPrice * TaxRate;            
        }

        // Hamburger radio button changed
        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            // Clear all check marks & totals
            ClearAddOns();
            ClearTotals();

            // Change texts and set main course and add-on prices
            if (rdoHamburger.Checked == true)
            {
                eachAddOnPrice = 0.75;
                mainCoursePrice = 6.95;
                grpAddOn.Text = "Add-on items (" + eachAddOnPrice.ToString("c") + "/each)";
                chkLettucePepperoniCroutons.Text = "Lettuce, tomato, and onions";
                chkKetchupSausageBaconBits.Text = "Ketchup, mustard, and mayo";
                chkFrenchFriesOlivesBreadSticks.Text = "French fries";

           }            
        }

        // Pizza radio button changed
        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            // Clear all check marks & totals
            ClearAddOns();
            ClearTotals();

            // Change texts and set main course and add-on prices
            if (rdoPizza.Checked == true)
            {
                eachAddOnPrice = 0.50;
                mainCoursePrice = 5.95;
                grpAddOn.Text = "Add-on items (" + eachAddOnPrice.ToString("c") + "/each)";
                chkLettucePepperoniCroutons.Text = "Pepperoni";
                chkKetchupSausageBaconBits.Text = "Sausage";
                chkFrenchFriesOlivesBreadSticks.Text = "Olives";

            }
        }

        // Salad radio button changed
        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            // Clear all check marks & totals
            ClearAddOns();
            ClearTotals();

            // Change texts and set main course and add-on prices
            if (rdoSalad.Checked == true)
            {
                eachAddOnPrice = 0.25;
                mainCoursePrice = 4.95;
                grpAddOn.Text = "Add-on items (" + eachAddOnPrice.ToString("c") + "/each)";
                chkLettucePepperoniCroutons.Text = "Croutons";
                chkKetchupSausageBaconBits.Text = "Bacon Bits";
                chkFrenchFriesOlivesBreadSticks.Text = "Bread Sticks";

            }
        }

        // Clear all totals
        private void ClearTotals()
        {
            txtSubtotal.Text = "";
            txtTaxTotal.Text = "";
            txtOrderTotal.Text = "";

            subtotalPrice = 0;
            orderTotalPrice = 0;
            totalAddOnsPrice = 0;
        }

        // Clear all check buttons for the add-ons
        private void ClearAddOns()
        {
            chkLettucePepperoniCroutons.Checked = false;
            chkKetchupSausageBaconBits.Checked = false;
            chkFrenchFriesOlivesBreadSticks.Checked = false;
            totalAddOnsPrice = 0;
        }

        // Clear all totals when any of the check button is changed
        private void chkLettucePepperoniCroutons_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }
        private void chkKetchupSausageBaconBits_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }
        private void chkFrenchFriesOlivesBreadSticks_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }

        // Exit program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
