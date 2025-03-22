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
    public partial class DepositAmount : Form
    {
        private string accountNumber;
        private UserManager userManager = new UserManager();
        private UpdateAccountBalance updateAccountBalance = new UpdateAccountBalance();
        public DepositAmount(string accountNumber)
        {
            InitializeComponent();
            this.accountNumber = accountNumber;
        }


        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate deposit amount
                if (!decimal.TryParse(txtAmount.Text, out decimal depositAmount) || depositAmount <= 0)
                {
                    MessageBox.Show("Invalid deposit amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                bool success = updateAccountBalance.UpdateBalance(accountNumber, depositAmount);


                if (success)
                {
                    MessageBox.Show($"Deposit of {depositAmount:C} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Clear(); // Clear the input field after a successful deposit
                }
                else
                {
                    MessageBox.Show("Error updating balance. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during deposit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        
    

