namespace Banking_System0.CreateUserValidation
{
    public static class ValidationHelper
    {
     
        public static bool IsAlphabetOnly(string input, bool allowSpaces = true)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false; // Null or empty input is invalid
            }

            foreach (char c in input)
            {
                if (allowSpaces && c == ' ')
                {
                    continue; // Skip space if allowed
                }

                if (!char.IsLetter(c)) // Check if the character is a letter (A-Z, a-z)
                {
                    return false; // Invalid character found
                }
            }

            return true; // All characters are valid
        }
    }
}







