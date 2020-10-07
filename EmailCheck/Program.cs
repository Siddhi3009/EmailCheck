using System;

namespace EmailCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Email Check program");
            EmailVaidation validation = new EmailVaidation();
            int loop = 1;
            while (loop == 1)
            {
                Console.WriteLine("Enter you email");
                string email = Console.ReadLine();
                bool valid = validation.validateEmail(email);
                Console.WriteLine(valid);
                Console.WriteLine("1. More\n2. End");
                loop = int.Parse(Console.ReadLine());
            }
        }
    }
}
