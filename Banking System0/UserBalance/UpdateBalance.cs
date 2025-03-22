using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System0.UserBalance
{
    class UpdateAccountBalance
    {
        public bool UpdateBalance(string accountNumber, decimal amount)
        {
            string filePath = "accounts.csv"; // Update the file path to accounts.csv

            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("User data file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Read all lines from the CSV file
                List<string> lines = File.ReadAllLines(filePath).ToList();
                bool isUpdated = false;

                for (int i = 1; i < lines.Count; i++) // Start from 1 to skip the header
                {
                    string[] data = lines[i].Split(',');

                    // Ensure the line has the correct format (Full Name, Username, Account Number, Password, Balance)
                    if (data.Length >= 5 && data[2].Trim() == accountNumber) // Account Number is at index 2
                    {
                        // Get the current balance
                        if (decimal.TryParse(data[4].Trim(), out decimal currentBalance))
                        {
                            // Update the balance by adding/subtracting the amount
                            decimal newBalance = currentBalance + amount;
                            data[4] = newBalance.ToString("F2"); // Update Balance at index 4
                            lines[i] = string.Join(",", data); // Reconstruct the line
                            isUpdated = true;
                            break; // Stop after finding and updating the correct account
                        }
                        else
                        {
                            MessageBox.Show("Invalid balance format in the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }

                if (isUpdated)
                {
                    // Write the updated lines back to the CSV file
                    File.WriteAllLines(filePath, lines);
                    return true;
                }
                else
                {
                    MessageBox.Show("Account not found. Balance update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating balance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

}

