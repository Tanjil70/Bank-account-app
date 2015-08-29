using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
   public  class Account
    {
        public string name { get; set; }
        public double blance { get;  private set; }
        public string  account { get;  private set; }
       public double amount { get; set; }

       public Account(string Name, double Amount, string  Account): this(Name,Account)
       {
           amount = Amount;
       }
       public Account(string Name, string  Account): this(Name)
       {
           account = Account;

       }


       public Account(string Name): this()
       {
           name = Name;
       }

       public Account()
       {
           
       }

      
        public string GetWithdraw( double amount)
        {
             blance -= amount;
             return amount + " taka has been Withdrawn.";

        }

    }
}
