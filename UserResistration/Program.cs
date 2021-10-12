using System;

namespace UserResistration
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("*****Welcome to User Resistration*****");
                UserResistrationValidation userResistration = new UserResistrationValidation();
                Console.Write("Enter First Name: ");
                string FirstName = Console.ReadLine();
                bool Result = userResistration.ValidateFirstName(FirstName);

                if (Result == true)
                {
                    Console.WriteLine("Valid Name!");
                }
                else
                {
                    Console.WriteLine("Invalid Name!");
                }
            
        }
    }
}
