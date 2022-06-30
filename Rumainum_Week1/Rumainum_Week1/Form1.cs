using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rumainum_Week1
{
    public partial class frmDailyWorkDrivingCost : Form
    {
        public frmDailyWorkDrivingCost()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // The total miles driven per day
            decimal totalMiles = Convert.ToDecimal(txtTotalMiles.Text);

            // The cost per gallon of gasoline (in cents)
            decimal costPerGallon = Convert.ToDecimal(txtCostPerGallon.Text);

            // The average miles per gallon
            decimal averageMilesPerGallon = Convert.ToDecimal(txtAverageMPG.Text);

            // The parking fess per day (in cents)
            decimal parkingFeesPerDay = Convert.ToDecimal(txtParkingFees.Text);

            // The tolls per day (in cents)
            decimal tollsPerDay = Convert.ToDecimal(txtTolls.Text);

            // Calculating how much the gasoline cost per day
            decimal gasolineCostPerDay = (totalMiles / averageMilesPerGallon) * costPerGallon;
            // Calculating the total cost in regular USD
            decimal totalWorkDailyCost = (gasolineCostPerDay + parkingFeesPerDay + tollsPerDay) / 100;

            // Show the total that was calculated in txtTotalWorkDailyCost textbox with a currency format
            txtTotalWorkDailyCost.Text = totalWorkDailyCost.ToString("c");
        }
    }
}
