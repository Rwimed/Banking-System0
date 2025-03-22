using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System0.CreateUserValidation
{
    public class RemoveExtraSpaces
    {
        public static string CleanText(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input; // Return the input if it's null or empty
            }

            string result = "";
            bool lastWasSpace = true; // Used to track multiple spaces

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                // Ignore leading and multiple spaces
                if (c == ' ')
                {
                    if (!lastWasSpace) // Add only a single space
                    {
                        result += c;
                    }
                    lastWasSpace = true;
                }
                else
                {
                    result += c; // Append valid character
                    lastWasSpace = false;
                }
            }

            return result;
        }
    }
}

