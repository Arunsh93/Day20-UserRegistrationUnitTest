using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserResistration
{
    public class UserResistrationValidation
    {
        public static string RegexFirstName = "^[A-Z]{1}[a-zA-Z]{2,}";
        public static string RegexLastName  = "^[a-zA-Z]{1}[a-z]{2,}";
        public static string RegexEmailId   = "^abc.[A-Za-z1-9]*@bl.co.[a-z]*$";
        public static string RegexPhoneNumber = "^[0-9]{2}[ ][0-9]{10}$";
        public static string RegexPassword1 = "^[A-Za-z0-9.@!#$&]{8,}$";
        public static string RegexPassword2 = "^(?=.*[A-Z])[A-Za-z0-9.@!#$&]{8,}$";
        public static string RegexPassword3 = "^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9.@!#$&]{8,}$";
        public static string RegexPassword4 = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@!#$&])[A-Za-z0-9.@!#$&]{8,}$";
        public static string UC9RegexEmailId = "^[A-Za-z0-9]+([-.+][0-9]+)?[0-9]*[@][A-Za-z0-9]+[.][a-zA-Z]{2,}([.][a-z]{2,})?$";

        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, RegexFirstName);
        }

        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, RegexLastName);
        }

        public bool ValidateEmailId(string emailId)
        {
            return Regex.IsMatch(emailId, RegexLastName);
        }

        public bool ValidatePhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, RegexPhoneNumber);
        }

        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, RegexPassword4);
        }

        public bool ValidateSampleEmailIds(string emailId)
        {
            return Regex.IsMatch(emailId, UC9RegexEmailId);
        }
    }
}
