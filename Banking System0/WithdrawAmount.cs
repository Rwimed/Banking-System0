using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking_System0.UserManagement;
using Banking_System0.UserBalance;

namespace Banking_System0
{
    public partial class WithdrawAmount : Form
    {
        private string accountNumber;
        private UserManager userManager = new UserManager();
        private CheckBalance checkBalance = new CheckBalance();
        private UpdateAccountBalance updateAccountBalance = new UpdateAccountBalance();
        public WithdrawAmount(string accountNumber)
        {
            InitializeComponent();
            this.accountNumber = accountNumber;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate withdrawal amount
                if (!decimal.TryParse(txtAmount.Text, out decimal withdrawAmount) || withdrawAmount <= 0)
                {
                    MessageBox.Show("Invalid withdrawal amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check current balance
                CheckBalance checkBalance = new CheckBalance();
                decimal currentBalance = checkBalance.GetBalance(accountNumber);

                if (withdrawAmount > currentBalance)
                {
                    MessageBox.Show("Insufficient funds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update balance by subtracting the withdrawal amount
                UserManager userManager = new UserManager();

                bool success = updateAccountBalance.UpdateBalance(accountNumber, -withdrawAmount); // Pass negative value to subtract


                if (success)
                {
                    MessageBox.Show($"Withdrawal of {withdrawAmount:C} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Clear(); // Clear the input field after a successful withdrawal
                }
                else
                {
                    MessageBox.Show("Error updating balance. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during withdrawal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        
    

