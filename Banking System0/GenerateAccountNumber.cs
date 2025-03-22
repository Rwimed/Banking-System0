using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System0
{
   
        public static class GenerateAccountNumber
        {
            // Generate a random account number
            public static string GenerateAccount()
            {
                Random random = new Random();
                return "SB" + random.Next(100000, 999999).ToString();
            }
        }
    }

