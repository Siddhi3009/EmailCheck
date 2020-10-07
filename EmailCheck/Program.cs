using System;

namespace EmailCheck
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to Email Check program");
            EmailVaidation validation = new EmailVaidation();
            Console.WriteLine("Enter you email");
            string email = Console.ReadLine();
            bool valid = validation.validateEmail(email);
            Console.WriteLine(valid);
        }
    }
}
