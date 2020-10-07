using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailCheck
{
    class EmailVaidation
    {
        public static string REGEX_EMAIL = "^[a-z0-9A-Z]+[_+-.]?[a-z0-9]{0,}?[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}[.]?[a-z]{2}?$";
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}
