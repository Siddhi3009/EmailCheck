using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailCheck
{
    class EmailVaidation
    {
        public static string REGEX_EMAIL = "^[a-zA-Z0-9]+([.+-_@#$][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}$";
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}
