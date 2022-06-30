using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumainum_Week4
{
    class Account
    {
        private decimal balance;

        public Account()
        {
        }

        public Account (decimal balance)
        {
            this.Balance = balance;
        }

        public decimal Balance
        {
            get
            {
                if ( balance >= 0.0m)
                {
                    return balance;
                }
                else
                {
                    // Balance is below 0.0
                    throw new ArgumentOutOfRangeException(balance.ToString(),
                        "Balance is below zero.");
                }
                
            }
            set
            {
                balance = value;
            }
        }

        public virtual decimal Credit (decimal credit)
        {
            decimal newBalance;
            newBalance = balance + credit;
            return newBalance;
        }

        public virtual decimal Debit (decimal debit)
        {
            decimal newBalance;
            if ((balance - debit) < 0)
            {
                // Balance is below 0.0
                throw new ArgumentOutOfRangeException(balance.ToString(),
                    "Debit amount exceeded the account balance.");
            }
            else
            {
                newBalance = balance - debit;
                return newBalance;
            }
            
        }
    }
}
