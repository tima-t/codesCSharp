using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Bank
{
    class DepositAcc:Account
    {
        public DepositAcc(CustomType cs, double balance, double interest,string name)
            : base(cs, balance, interest,name)
        {

        }

        public void DrawMoney(double amount)
        {
            this.Balance -= amount;
            Console.WriteLine("your amount after drawing money is {0}", this.Balance);
        }
      

        public override double CalcInterestAmount(int months)
        {
            if (this.Balance<1000)
            {
                return 0;
            }
            else
            {
             return   months * this.InterestRatePerMonth;
            }
        }
    }
}
