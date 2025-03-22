using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System0.UserBalance
{
    public class CheckBalance
    {
        private string filePath;

        public CheckBalance(string filePath = "accounts.csv")
        {
            this.filePath = filePath;
        }
    
    public decimal GetBalance(string accountNumber)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("User data file not found.");
            }

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] data = line.Split(',');

                // Ensure CSV structure (Full Name, Username, Account Number, Password, Balance)
                if (data.Length >= 5 && data[2].Trim() == accountNumber.Trim()) // Account number is index 2
                {
                    if (decimal.TryParse(data[4].Trim(), out decimal balance)) // Balance is index 4
                    {
                        return balance;
                    }
                    else
                    {
                        throw new FormatException("Invalid balance format in the file.");
                    }
                }
            }

            throw new Exception("Account not found.");
        }
        catch (Exception ex)
        {
            // Log the error or rethrow it for the calling code to handle
            throw new Exception($"Error retrieving balance: {ex.Message}", ex);
        }
    }
    }
}

