using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace BankAccountApp
{
    public class BankAccount    
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; } 
        public decimal Balance { get; private set; } //encapsulation, because we want make sure that setter for balance is private,
                                                     //it is usefull for having that in one place in case a need to change
                                                     // the validation for example

        public BankAccount(string owner) {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }

        //here we are doing a validations for deposit and withdraw methods, so we cannot equal the amount to balance directly somewhere in the code
        public string Deposit(decimal amount)
        {
            if (amount <= 0) {
                return "You can't deposit $" + amount;
            }
            if (amount > 2000) {
                return "AML deposit Limit Reached.";
            }
            Balance += amount;
            return "Deposit completed successfully"; 
        }
        public string Withdraw(decimal amount) {
            if (amount <= 0)
            {
                return "You can't withdraw $" + amount;
            }
            if (amount > Balance)   
            {
                return "You don't have enough money.";
            }   
            Balance -= amount;
            return "Withdraw completed successfully";
        }

    }   
}   
        