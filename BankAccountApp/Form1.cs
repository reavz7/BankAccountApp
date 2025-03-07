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
        
            if (OwnerTxt.Text == "" || OwnerTxt.Text == null)
            {
                MessageBox.Show("You have to type owner nickname first.");
                return;
            }
            if (InterestRateNum.Value > 0)
            {
                BankAccounts.Add(new SavingsAccount(OwnerTxt.Text, InterestRateNum.Value));
            }
            else {
                BankAccounts.Add(new BankAccount(OwnerTxt.Text));
            }

                RefreshGrid();
                OwnerTxt.Clear();
                InterestRateNum.Value = 0;
        }
        private void RefreshGrid()
        {

            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;

        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                //Encapsulation in action
                string message = selectedBankAccount.Deposit(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
            else {
                MessageBox.Show("You didn't pick a person");
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = selectedBankAccount.Withdraw(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;    
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("You didn't pick a person");
            }

        }
    }
}
