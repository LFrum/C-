using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rumainum_Week2
{
    public partial class Form1 : Form
    {
        // global variables
        const int SeatAvailable = 10;
        // number of first class seats available
        int maxNumberOfFirstClassSeat = 5;
        // Seats status
        bool isFirstClassFull, isEconomyClassFull;
        // prevent the availability to reset when button gets re-clicked
        // seatAvailability for 10 seats for the airline
        bool[] seatAvailability = new bool[SeatAvailable];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert the user input into an integer
                int userInput = Convert.ToInt32(txtUserInput.Text);

                // if user choose 1 - first class ticket
                if (userInput == 1)
                {
                    checkingFirstClass(seatAvailability);
                }
                // if user choose 2 - economy class ticket
                else if (userInput == 2)
                {
                    checkingEconomyClass(seatAvailability);
                }
                else
                {
                    MessageBox.Show("Invalid Input! Please nter 1 or 2 only.");
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input! Please enter 1 or 2.");
            }

        }

        private void checkingFirstClass(bool[] isSeatAvailable)
        {
            for (int i = 0; i < maxNumberOfFirstClassSeat; ++i)
            {
                if (seatAvailability[i] != true)
                {
                    seatAvailability[i] = true;
                    MessageBox.Show("Your first class ticket reservation is successful.");
                    break;
                }

                // The first class is full
                if (seatAvailability[maxNumberOfFirstClassSeat - 1] == true && isEconomyClassFull == false)
                {
                    isFirstClassFull = true;
                    DialogResult altenativeOption = MessageBox.Show("First class seats are full. " +
                        "Would you like to be placed in the economy class?", "Alternative Option",
                        MessageBoxButtons.YesNo);
                    if (altenativeOption == DialogResult.Yes)
                    {
                        //check the economy class seats
                        checkingEconomyClass(isSeatAvailable);
                        break;
                    }
                    else if (altenativeOption == DialogResult.No)
                    {
                        MessageBox.Show("Next flight leaves in 3 hours!");
                        break;
                    }
                }
                else if (seatAvailability[maxNumberOfFirstClassSeat - 1] == true && isEconomyClassFull == true)
                {
                    MessageBox.Show("Flight is full. Next flight leaves in 3 hours!");
                    break;
                }
            }
        }

        private void checkingEconomyClass(bool[] isSeatAvailable)
        {

            for (int i = maxNumberOfFirstClassSeat; i < SeatAvailable; ++i)
            {
                if (seatAvailability[i] != true)
                {
                    seatAvailability[i] = true;
                    MessageBox.Show("Your economy class ticket reservation is successful.");
                    break;
                }

                // The economy class full
                if (seatAvailability[SeatAvailable - 1] == true && isFirstClassFull == false)
                {
                    isEconomyClassFull = true;
                    DialogResult altenativeOption = MessageBox.Show("Economy class seats are full. " +
                       "Would you like to be placed in the first class?", "Alternative Option",
                       MessageBoxButtons.YesNo);
                    if (altenativeOption == DialogResult.Yes)
                    {
                        //check the first class seats
                        checkingFirstClass(isSeatAvailable);
                        break;
                    }
                    else if (altenativeOption == DialogResult.No)
                    {
                        MessageBox.Show("Next flight leaves in 3 hours!");
                        break;
                    }
                }
                else if (seatAvailability[SeatAvailable - 1] == true && isFirstClassFull == true)
                {
                    MessageBox.Show("Flight is full. Next flight leaves in 3 hours!");
                    break;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the form
            this.Close();
        }
    }
}
