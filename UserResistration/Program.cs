using System;

namespace UserResistration
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("*****Welcome to User Resistration*****");
            UserResistrationValidation userResistration = new UserResistrationValidation();
            Console.Write("Enter EmailId: ");
            string Email = Console.ReadLine();
            bool Result = userResistration.ValidateEmailId(Email);
            if (Result == true)
            {
                Console.WriteLine("Valid EmailId!");
            }
            else
            {
                Console.WriteLine("Invalid EmailId!");
            }
        }
    }
}
