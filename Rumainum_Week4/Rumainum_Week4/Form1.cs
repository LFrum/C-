using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rumainum_Week4
{
    public partial class frmBankAccount : Form
    {
        private decimal currentBalance;
        private decimal initialBalance;
        private decimal interestRate;
        private decimal transactionFee;
        private decimal credit;
        private decimal debit;
        private SavingsAccount savings = new SavingsAccount();
        private CheckingAccount checking = new CheckingAccount();

        public frmBankAccount()
        {
            InitializeComponent();
        }        

        private void frmBankAccount_Load(object sender, EventArgs e)
        {
            // Default set for Savings account
            rdoSavingsAccount.Checked = true;

            // Clear all inputs
            ClearAllInputs();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // reset debit & credit
                ClearTotals();

                // Clear results
                ClearResultsTexts();

                credit = Convert.ToDecimal(txtCredit.Text);
                debit = Convert.ToDecimal(txtDebit.Text);
                initialBalance = Convert.ToDecimal(txtInitialBalance.Text);

                if (rdoSavingsAccount.Checked == true)
                {                    
                    interestRate = Convert.ToDecimal(txtInterestRateOrFee.Text);
                    interestRate /= 100;
                    savings = new SavingsAccount(initialBalance, interestRate);

                    // Add credit to balance
                    currentBalance = savings.Credit(credit);
                    // update balance in the class
                    savings.Balance = currentBalance;
                    // Subtract debit from balance
                    currentBalance = savings.Debit(debit);
                    // Calculate interest rate                                        
                    interestRate = savings.CalculateInterest(currentBalance, interestRate);
                    txtTotalInterestOrFee.Text = interestRate.ToString("c");
                    currentBalance += interestRate;
                }

                else if (rdoCheckingAccount.Checked == true)
                {
                    // if Checking account radio button is true
                    transactionFee = Convert.ToDecimal(txtInterestRateOrFee.Text);
                    checking = new CheckingAccount(initialBalance, transactionFee);
                    currentBalance = checking.Credit(credit);
                    // update balance in the class
                    checking.Balance = currentBalance;

                    if (checking.Debit(debit) >= 0)
                    {
                        // Subtract debit & transaction fee from balance 
                        currentBalance = checking.Debit(debit);
                        // Show transaction fee                        
                        txtTotalInterestOrFee.Text = transactionFee.ToString("c");
                    }
                    else
                    {
                        checking.Debit(debit);
                        ClearResultsTexts();
                        return;
                    }
                }
                // Show current balance
                txtCurrentBalance.Text = currentBalance.ToString("c");
            }
            catch (FormatException)
            {
                MessageBox.Show( "A format exception has occurred. Please check all entries.", "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show("An overflow exception has occurred. Please enter smaller values.", "Entry Error");
            }
            // all other exceptions 
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void rdoSavingsAccount_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearResultsTexts();
            ClearAllInputs();

            if (rdoSavingsAccount.Checked == true)
            {
                lblInterestRateOrFee.Text = "Interest Rate (%) :";
                lblTotalInterestOrFee.Text = "Total Interest : ";
            }
        }

        private void rdoCheckingAccount_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearResultsTexts();
            ClearAllInputs();

            if (rdoCheckingAccount.Checked == true)
            {
                lblInterestRateOrFee.Text = "Transaction Fee :";
                lblTotalInterestOrFee.Text = "Total Fee(s) : ";
            }
        }
        
        private void ClearAllInputs()
        {
            // Clear all input texts
            txtInitialBalance.Text = "";
            txtInterestRateOrFee.Text = "";
            txtCredit.Text = "";
            txtDebit.Text = "";
        }

        private void ClearResultsTexts()
        {
            // Clear all textboxes and results
            txtTotalInterestOrFee.Text = "";
            txtCurrentBalance.Text = "";
        }

        private void ClearTotals()
        {
            // Clear all totals
            initialBalance = 0;
            currentBalance = 0;
            interestRate = 0;
            transactionFee = 0;
            credit = 0;
            debit = 0;
        }

        // Reset all account
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAllInputs();
            ClearResultsTexts();
        }

        // End Application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtInitialBalance_TextChanged(object sender, EventArgs e)
        {
            ClearResultsTexts();
        }

        private void txtInterestRateOrFee_TextChanged(object sender, EventArgs e)
        {
            ClearResultsTexts();
        }

        private void txtCredit_TextChanged(object sender, EventArgs e)
        {
            ClearResultsTexts();
        }

        private void txtDebit_TextChanged(object sender, EventArgs e)
        {
            ClearResultsTexts();
        }
    }
}