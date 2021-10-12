using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserResistration
{
    public class UserResistrationValidation
    {
        public string RegexPattern = "^[A-Z]{1}[a-zA-Z]{2,}";

        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, RegexPattern);
        }
    }
}
