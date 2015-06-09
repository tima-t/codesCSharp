using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Bank
{
  public    class Account
    {
      public string Name { get; set; }
           public CustomType Customer { get; set; }
           public double Balance { get; set; }
           public double InterestRatePerMonth { get; set; }

           public Account(CustomType cs, double balance, double interest,string name)
           {
               this.Customer = cs;
               this.Balance = balance;
               this.InterestRatePerMonth = interest;
               this.Name = name;
           }

           public  void DepositMoney(double amount)
           {
               this.Balance += amount;
               Console.WriteLine("Your deposi after depositing is {0} ", this.Balance);
           }
           public virtual double CalcInterestAmount(int months)
           {
               return -1;
           }
          

    }
}
