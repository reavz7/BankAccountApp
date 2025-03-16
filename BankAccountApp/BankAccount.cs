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
        public decimal Balance { get; protected set; } //encapsulation, because we want make sure that setter for balance is private,
                                                     //it is usefull for having that in one place in case a need to change
                                                     // the validation for example
                                                     //But now when Im doing polymorphism we are setting this on protected, it is similiar to private set
                                                     //but from now I can use Balance in child class for example in SavingsAccount

        public BankAccount(string owner) {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }

        //here we are doing a validations for deposit and withdraw methods, so we cannot equal the amount to balance directly somewhere in the code
        public virtual string Deposit(decimal amount)
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
        