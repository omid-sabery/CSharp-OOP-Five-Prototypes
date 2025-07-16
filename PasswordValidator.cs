using System.Text.RegularExpressions;

namespace FivePrototypes
{
    // Validates passwords based on custom rules
    internal class PasswordValidator
    {
        // Regex pattern for password validation
        private static string _passwordPattern = @"^(?=.*[a-z])(?=.*[A-SU-Z])(?=.*\d)(?!.*(&|T)).{6,13}$";

        // Returns a message describing password validity or issues
        private string Message(string password)
        {   
            if (IsValidPassword(password))
                return "Your password is a valid.";
            string message = "The password must:\n";
            if (!ContainsDigit(password))
                message += "\tat least contain one digit!\n";
            if (!ContainsLower(password))
                message += "\tat least contain one lowercase letter!\n";
            if (!ContainsUpper(password))
                message += "\tat least contain one uppercase letter!\n";
            if (ContainsT(password))
                message += "\tnot contain the uppercase T!\n";
            if (ContainsAmpersand(password))
                message += "\tnot contain the & symbol!\n";
            if (IsTooShort(password))
                message += "\tbe at least 6 characters long!\n";
            if (IsTooLong(password))
                message += "\tbe at most 13 characters long!\n";
            return message;
        }

        // Helper methods for password checks
        private bool ContainsDigit(string password) => password.Any(char.IsDigit);
        private bool ContainsLower(string password) => password.Any(char.IsLower);
        private bool ContainsUpper(string password) =>
            password.Any(c => char.IsUpper(c) && c != 'T');
        private bool ContainsT(string password) => password.Contains('T');
        private bool ContainsAmpersand(string password) => password.Contains('&');
        private bool IsTooLong(string password) => password.Length > 13;
        private bool IsTooShort(string password) => password.Length < 6;

        // Returns true if password matches all rules
        public static bool IsValidPassword(string password) => Regex.IsMatch(password, _passwordPattern);

        public PasswordValidator() { }

        // Prompts user for a password and validates it interactively
        public void GetPassword()
        {
            Console.WriteLine("Welcome to the Secure Password Validator");
            Console.WriteLine("Follow the rules below:");
            Console.WriteLine("1. Password must be between 6 and 13 characters.");
            Console.WriteLine("2. It must contain at least one lowercase letter.");
            Console.WriteLine("3. It must contain at least one uppercase letter (excluding 'T').");
            Console.WriteLine("4. It must contain at least one number.");
            Console.WriteLine("5. It must NOT contain the uppercase letter 'T' or the '&' symbol.");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter password: ");
                string password = Console.ReadLine() ?? "";

                Console.WriteLine(); // spacing

                Console.WriteLine(Message(password));

                if (IsValidPassword(password))
                {
                    Console.WriteLine("Password accepted!");
                    break;
                }

                Console.WriteLine("Try again.\n");
            }
        }
    }
}


