using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Bank
{
  

   public  enum CustomType
    {
        individuals=1,
        companies=2
    }
   public  class Bank1
    {
       private string name;
      public string Name { get; set; }
     
             private List<Account> accounts;
             public int Count { get;  private  set; }
            
        public Bank1(string name)
        {
            this.name = name;
            this.accounts = new List<Account>();
        }

        public Account this[int index]
        {
            get
            {
                return this.accounts[index];
            }
        }

        public void AddAccount(Account acc)
        {
            Count++;

            this.accounts.Add(acc);
        }

        public void RemoveAccount(Account acc)
        {
            Count--;
            this.accounts.Remove(acc);
        }
    }
}
