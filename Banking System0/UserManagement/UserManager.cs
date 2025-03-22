using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System0.UserManagement
{
    public class UserManager
    {
        private string filePath = "accounts.csv";

        public void SaveUserToCsv(string fullName, string userName, string accountNumber, string hashedPassword, string initialDeposit)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    File.WriteAllText(filePath, "Full Name,Username,Account Number,Password,Balance\n");
                }

                string balance = string.IsNullOrWhiteSpace(initialDeposit) ? "0.00" : initialDeposit;
                string newUser = $"{fullName},{userName},{accountNumber},{hashedPassword},{initialDeposit}\n";
                File.AppendAllText(filePath, newUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public bool UserExists(string userName)
        {
            if (!File.Exists(filePath))
            {
                return false; // File doesn't exist, so username cannot exist
            }

            // Read all lines from the CSV file
            var lines = File.ReadAllLines(filePath);

            // Skip the header line (first line) and check each line
            foreach (var line in lines.Skip(1))
            {
                var data = line.Split(',');

                // Ensure the line has at least 2 columns (Full Name and Username)
                if (data.Length > 1 && data[1].Trim().Equals(userName, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // Username exists
                }
            }

            return false; // Username does not exist
        }

        public (string hashedPassword, string accountNumber) GetUserCredentials(string userName)
        {
            try
            {
                if (!File.Exists(filePath))
                    return ("", "");

                foreach (string line in File.ReadAllLines(filePath))
                {
                    string[] data = line.Split(',');

                    if (data.Length >= 5 && data[1].Trim() == userName) // Username at Index 1
                    {
                        string hashedPassword = data[3].Trim(); // Password at Index 3
                        string accountNumber = data[2].Trim(); // Account Number at Index 2
                        return (hashedPassword, accountNumber);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving credentials: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ("", "");
        }
    }
}
