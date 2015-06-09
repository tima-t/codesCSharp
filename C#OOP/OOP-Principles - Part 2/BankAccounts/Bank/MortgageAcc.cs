using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Bank
{
    class MortgageAcc:Account
    {
              public MortgageAcc(CustomType cs, double balance, double interest,string name)
            : base(cs, balance, interest,name)
        {

        }
        public override double CalcInterestAmount(int months)
        {
            if (this.Customer==CustomType.individuals && months<6)
            {
                return 0;

                
            }

            if (this.Customer==CustomType.individuals && months>6)
            {
                return months * this.InterestRatePerMonth; 
            }
            if (this.Customer==CustomType.companies && months<12)
            {
                 return months * this.InterestRatePerMonth/2; 
            }

            if (this.Customer == CustomType.companies && months > 12)
            {
                return months * this.InterestRatePerMonth;
            }

            else
            {
                return 0;
            }

        }
    }
}
