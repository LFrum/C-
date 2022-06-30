using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumainum_Week4
{
    class SavingsAccount : Account
    {
        // Interest rate in percentage
        private decimal interestRate;

        public SavingsAccount()
        {
        }

        public SavingsAccount(decimal balance, decimal interestRate):
            base(balance)
        {
            this.InterestRate = interestRate;
        }

        public decimal InterestRate
        {
            get
            {                
                if (interestRate >= 0.0m)
                {
                    return interestRate;
                }
                else
                {
                    // Balance is below 0.0
                    throw new ArgumentOutOfRangeException(interestRate.ToString(),
                        "Interest rate value is below zero.");
                }

            }
            set
            {
                interestRate = value;
            }
        }

        // Calculating the amount of interest earned by an account
        public decimal CalculateInterest(decimal balance, decimal interestRate)
        {
            return (balance * interestRate);
        }       

    }
}