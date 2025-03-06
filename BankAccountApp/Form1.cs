using System.ComponentModel;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BankAccount bankAccount = new BankAccount("Kamil Stêpieñ");
            BankAccount bankAccount2 = new BankAccount("Adam Mickiewcz");
            BankAccount bankAccount3 = new BankAccount("Cristiano Ronaldo");

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
