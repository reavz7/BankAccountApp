using System.ComponentModel;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BankAccount bankAccount = new BankAccount();
            bankAccount.Owner = "Kamil Stêpieñ";
            bankAccount.AccountNumber = Guid.NewGuid();
            bankAccount.Balance = 777.47;   
            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.Owner = "Adam Mickiewicz";
            bankAccount2.AccountNumber = Guid.NewGuid();
            bankAccount2.Balance = 1798;
            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.Owner = "Cristiano Ronaldo"; 
            bankAccount3.AccountNumber = Guid.NewGuid();    
            bankAccount3.Balance = 150521.29;   

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            BankAccountsGrid.DataSource = bankAccounts;
        }
       
            
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
