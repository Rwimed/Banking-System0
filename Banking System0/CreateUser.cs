using Banking_System0.UserManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking_System0.CreateUserValidation;

namespace Banking_System0
{
    public partial class CreateUser : Form
    {
        private UserManager userManager = new UserManager();
        public CreateUser()
        {
            InitializeComponent();
            ResetForm();
        }

        private void btnCreateUser_Click_1(object sender, EventArgs e)
        {
            string fullName = RemoveExtraSpaces.CleanText(txtFullName.Text.Trim());
            string userName = RemoveExtraSpaces.CleanText(txtUsername.Text.Trim()); 
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string initialDeposit = RemoveExtraSpaces.CleanText(txtInitialDeposit.Text.Trim());

            // Step 1: Validate required fields
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                lblStatus.Text = "⚠ All fields are required";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return; // Stop further execution
            }

            // Step 2: Validate full name format
            if (!ValidationHelper.IsAlphabetOnly(fullName))
            {
                lblStatus.Text = "⚠ Full name can only contain letters (A-Z, a-z).";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return; // Stop execution if name is invalid
            }

            // Step 3: Check if username already exists
            if (userManager.UserExists(userName))
            {
                lblStatus.Text = "⚠ Username already exists. Please choose a different username.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return; // Stop execution if username is taken
            }

            // Step 4: Validate password complexity
            if (!CreateUserSecurePassword.ValidatePassword(password))
            {
                lblStatus.Text = "⚠ Password must be at least 5 characters long and contain at least 1 special character.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return; // Stop execution if password is weak
            }

            // Step 5: Check if passwords match
            if (password != confirmPassword)
            {
                lblStatus.Text = "⚠ Passwords don't match";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return; // Stop execution if passwords don't match
            }

            // Step 6: Validate initial deposit (if provided)
            if (string.IsNullOrWhiteSpace(initialDeposit))
            {
                initialDeposit = "0.00";
            }
            else if (!decimal.TryParse(initialDeposit, out decimal depositValue) || depositValue < 0)
            {
                // Show error if deposit is not a valid positive number
                lblStatus.Text = "⚠ Invalid deposit amount. Please enter a positive number.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return; // Stop execution if deposit is invalid
            }

            // If all validations pass, proceed with user creation
            string accountNumber = GenerateAccountNumber.GenerateAccount();
            string hashedPassword = CreateUserSecurePassword.HashPassword(password);

            userManager.SaveUserToCsv(fullName, userName, accountNumber, hashedPassword, initialDeposit);
            MessageBox.Show($"✅ User '{userName}' created with {initialDeposit} balance.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form and navigate to BankingMenu
            ResetForm();
            BankingMenu bankingMenu = new BankingMenu(userName, accountNumber);
            this.Hide();
            bankingMenu.ShowDialog();
            this.Close();
        }



        private void ResetForm()
        {
            txtFullName.Text = "";
            txtFullName.Enabled = true;
            txtUsername.Text = "";
            txtUsername.Enabled = true;
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtConfirmPassword.Enabled = true;
            txtInitialDeposit.Text = "";
            txtInitialDeposit.Enabled = true;
            btnCreateUser.Enabled = true;
            lblStatus.Text = "";
        }


        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}

