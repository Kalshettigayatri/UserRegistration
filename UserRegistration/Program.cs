namespace EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> emailSamples = new List<string>
            {
                "gayatrikalshetti3@gmail.com",
                "sam9960852612@gmail.com",
                "invalid.email",
                "samarthkalashetti2612@gmail.com",
               "xyz.com",
                "gayatri@domain",
                "vinu123@gmail.com"
            };

            foreach (string email in emailSamples)
            {
                bool isValid = IsValidEmail(email);
                Console.WriteLine($"{email} is {(isValid ? "valid" : "invalid")}.");
            }
        }

        static bool IsValidEmail(string email)
        {
            // Email validation rules go here

            // For this example, let's assume all provided emails are valid
            return true;
        }
    }
}