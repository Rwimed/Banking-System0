using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Banking_System0.UserManagement;
using Banking_System0.UserBalance;

namespace Banking_System0
{
    public partial class BankingMenu : Form

    {
        private string accountNumber;
        public BankingMenu(string userName, string accountNumber)
        {
            InitializeComponent();
            this.accountNumber = accountNumber;
            lblUser.Text = "Welcome, " + userName;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

            try
            {
                DepositAmount depositForm = new DepositAmount(accountNumber);
                depositForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during deposit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                WithdrawAmount withdrawForm = new WithdrawAmount(accountNumber);
                withdrawForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during withdrawal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            try
            {
                CheckBalance checkBalance = new CheckBalance();
                decimal balance = checkBalance.GetBalance(accountNumber);

                MessageBox.Show($"Current Balance: {balance:C}", "Balance Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving balance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide(); // Hide BankingMenu before opening CreateUser
                CreateUser createUserForm = new CreateUser();
                createUserForm.ShowDialog(); // Show CreateUser as a modal window
                this.Close(); // Ensure BankingMenu closes after returning
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating back: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit(); // Fully closes the application
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exiting application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

