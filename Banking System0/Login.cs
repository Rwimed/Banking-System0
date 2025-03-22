
using BCrypt.Net;
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
using static System.Windows.Forms.DataFormats;

namespace Banking_System0
{
    public partial class Login : Form
    {
        private UserManager userManager = new UserManager();
        public Login()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string enteredPassword = txtLoginPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(enteredPassword))
            {
                ShowStatus("⚠ Please enter a username and password.", false);
                return;
            }

            if (!userManager.UserExists(username))
            {
                ShowStatus("⚠ User not found. Please create an account.", false);
                return;
            }

            // Retrieve stored hashed password and account number
            (string storedHashedPassword, string accountNumber) = userManager.GetUserCredentials(username);

            if (string.IsNullOrWhiteSpace(storedHashedPassword) || string.IsNullOrWhiteSpace(accountNumber))
            {
                ShowStatus("❌ Error: Account number or password not found.", false);
                return;
            }

            // Verify password using BCrypt
            if (BCrypt.Net.BCrypt.Verify(enteredPassword, storedHashedPassword))
            {
                ShowStatus("✅ Login successful!", true);

                // Open Banking Menu
                BankingMenu bankingMenu = new BankingMenu(username, accountNumber);
                this.Hide();
                bankingMenu.ShowDialog();
                this.Close();
            }
            else
            {
                ShowStatus("❌ Invalid password.", false);
            }


        }

        // Helper Methods
        private void ShowStatus(string message, bool isSuccess)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = isSuccess ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Login form before opening CreateUser
            CreateUser createUserForm = new CreateUser();
            createUserForm.ShowDialog(); // Show CreateUser as a modal window
            this.Close(); // Ensure Login form closes after returning
        }
        private void btnExit_Click(object sender, EventArgs e)
            {
                Application.Exit(); // Fully closes the application
            }
        }
    }

       
    

