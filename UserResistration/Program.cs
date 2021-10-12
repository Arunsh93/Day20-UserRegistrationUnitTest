using System;

namespace UserResistration
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("*****Welcome to User Resistration*****");
            UserResistrationValidation userResistration = new UserResistrationValidation();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            bool Result = userResistration.ValidatePassword(password);
            if (Result == true)
            {
                Console.WriteLine("Valid Password!");
            }
            else
            {
                Console.WriteLine("Invalid Password!");
            }
        }
    }
}
