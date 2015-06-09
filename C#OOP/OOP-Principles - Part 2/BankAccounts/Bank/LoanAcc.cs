using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Bank
{
    class LoanAcc:Account
    {  
        public LoanAcc(CustomType cs, double balance, double interest,string name)
            : base(cs, balance, interest,name)
        {

        }

      

        public override double CalcInterestAmount(int months)
        {
            if ((this.Customer==CustomType.individuals && months<3) || (this.Customer==CustomType.companies && months<2 ))
            {
                return 0;
            }
            else
            {
                return months * this.InterestRatePerMonth;
            }
        }
    }
}
