namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;

            do
            {
                Console.Write("Enter a valid password: ");
                password = Console.ReadLine();
            } while (!IsValidPassword(password));

            Console.WriteLine("Valid password entered.");
        }

        static bool IsValidPassword(string password)
        {
            // Check if the password has at least 8 characters
            if (password.Length < 8)
            {
                Console.WriteLine("Password should have a minimum of 8 characters.");
                return false;
            }

            // Check if the password has at least 1 uppercase letter
            if (!password.Any(char.IsUpper))
            {
                Console.WriteLine("Password should have at least 1 uppercase letter.");
                return false;
            }

            // Check if the password has at least 1 numeric digit
            if (!password.Any(char.IsDigit))
            {
                Console.WriteLine("Password should have at least 1 numeric digit.");
                return false;
            }

            // Check if the password has exactly 1 special character
            if (password.Count(char.IsPunctuation) != 1)
            {
                Console.WriteLine("Password should have exactly 1 special character.");
                return false;
            }

            return true;
        }
    }
}