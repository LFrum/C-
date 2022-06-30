using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumainum_Week4
{
    class CheckingAccount : Account
    {
        private decimal transactionFee = 2.00m;

        public CheckingAccount()
        {
        }

        public CheckingAccount(decimal balance, decimal transactionFee) :
            base(balance)
        {
            this.TransactionFee = transactionFee;
        }

        public decimal TransactionFee
        {
            get
            {
                return transactionFee;
            }
            set
            {
                transactionFee = value;
            }
        }

        public override decimal Debit(decimal debit)
        {
            if ((Balance - debit - transactionFee) < 0)
            {
                // Balance is below 0.0
                throw new ArgumentOutOfRangeException(debit.ToString(),
                    "Debit & transactionFee amount exceeded the account balance.");
            }
            else
            {
                decimal newBalance;
                newBalance = Balance - debit - transactionFee;
                return newBalance;
            }

        }
    }
}
