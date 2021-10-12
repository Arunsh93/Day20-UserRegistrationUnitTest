using System;

namespace UserResistration
{
    class Program
    {
        static void Main(string[] args)
        { 
                Console.WriteLine("*****Welcome to User Resistration*****");
                UserResistrationValidation userResistration = new UserResistrationValidation();
                Console.Write("Enter Last Name: ");
                string LastName = Console.ReadLine();
                bool Result = userResistration.ValidateLastName(LastName);
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
