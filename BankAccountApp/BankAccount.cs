﻿using System;
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
        public double Balance { get; set; }

        public BankAccount(string owner) {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }
    }   
}
        