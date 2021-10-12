using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserResistration
{
    public class UserResistrationValidation
    {
        public static string RegexFirstName = "^[A-Z]{1}[a-zA-Z]{2,}";
        public static string RegexLastName =  "^[a-zA-Z]{1}[a-z]{2,}";

        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, RegexFirstName);
        }

        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, RegexLastName);
        }
    }
}
