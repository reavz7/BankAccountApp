using System.ComponentModel;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();

        public Form1()
        {
            InitializeComponent();
            BankAccount bankAccount = new BankAccount("Kamil Stêpieñ");
            BankAccount bankAccount2 = new BankAccount("Adam Mickiewcz");
            BankAccounts.Add(bankAccount);
            BankAccounts.Add(bankAccount2); 
            RefreshGrid();
        }


        private void label1_Click(object sender, EventArgs e)
        {
                
        }
            
        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
            if (OwnerTxt.Text == "" || OwnerTxt.Text == null)
            {
                MessageBox.Show("Nie wprowadzono imienia i nazwiska");
            }
            else { 
            BankAccounts.Add(bankAccount);  
            RefreshGrid();  
            OwnerTxt.Clear();
            }
        }
        private void RefreshGrid() {

            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;

        }
        
    }
}
