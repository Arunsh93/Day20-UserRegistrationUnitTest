using System;

namespace UserResistration
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("*****Welcome to User Resistration*****");
            UserResistrationValidation userResistration = new UserResistrationValidation();
            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();
            bool Result = userResistration.ValidateEmailId(phoneNumber);
            if (Result == true)
            {
                Console.WriteLine("Valid Phone Number!");
            }
            else
            {
                Console.WriteLine("Invalid Phone Number!");
            }
        }
    }
}
