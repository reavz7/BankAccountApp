using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    //The savingaccount class is a "child class" and a bankaccount is a "parent class"
    public class SavingsAccount : BankAccount
    {
        //Inheritance here, from now SavingAccount have acces to all BankAccount class, functions and parameters like owner, bankaccount and balance

        //Now here we are adding InterestRate for SavingAccounts in case user will want to have this type of account and no just
        //a regular bankaccount
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner, decimal interestRate) : base(owner + "("+interestRate+"%)") //here we have to interigance the owner name also from bankaccount and just adding interestrate so it can be displayed later in app
        {   
            //We are only specifying interestrate here, because the other parameters are made in BankAccount
            InterestRate = interestRate;
            //From now, the saving accounts can have a: owner, bankaccount, amount and INTERESTRATE
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)    
            {
                return "You can't deposit $" + amount;
            }
            if (amount > 2000)
            {
                return "AML deposit Limit Reached.";
            }
            decimal interestAmount = (InterestRate/100) * amount;
            Balance += amount + interestAmount;
            return "Deposit completed successfully";
        }

    }
}
