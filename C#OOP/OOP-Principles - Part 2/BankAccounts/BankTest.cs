using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Bank;

namespace BankAccounts
{
    class BankTest
    {
        static void Main()
        {
            List<Account> accounts = new List<Account>();
            accounts.Add(new LoanAcc(CustomType.individuals, 500, 100, "Gosho"));
            accounts.Add(new LoanAcc(CustomType.companies, 5000, 110, "Gosho1"));
            accounts.Add(new DepositAcc(CustomType.individuals, 700, 100, "Ivanka"));
            
           
            accounts.Add(new DepositAcc(CustomType.companies, 4000, 120, "Ivanka1"));
            accounts.Add(new MortgageAcc(CustomType.individuals, 1000, 100, "Ana"));
            accounts.Add(new MortgageAcc(CustomType.companies, 10000, 200, "Ana1"));
            (accounts[3] as DepositAcc).DrawMoney(400);
            accounts[4].DepositMoney(200);


            Bank1 bank = new Bank1( "Bull Bank");
            foreach (var acc in accounts)
            {
                bank.AddAccount(acc);
            }

            for (int acc = 0; acc < bank.Count; acc++)
            {
                Console.WriteLine((bank[acc].Name+ "  " + bank[acc].GetType() + "  "  +"amount of money "+ bank[acc].Balance + " calc interest for 5 months"+" " +bank[acc].CalcInterestAmount(5)));
            }
               
            
        }
    }
}
