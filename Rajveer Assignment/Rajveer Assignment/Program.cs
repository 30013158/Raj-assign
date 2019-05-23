using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajveer_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************Welcome to our new Login system**************");
            Console.Write("Please enter your username: ");
            string userName = Console.ReadLine();
            Console.WriteLine(ValidateUsername(userName));
            Console.WriteLine();
            
            Console.Write("Please enter the password: ");
            string passWord1 = Console.ReadLine();
            Console.Write("Please re-enter your password to confirm: ");
            string passWord2 = Console.ReadLine();
            Console.WriteLine(ValidatePassword(passWord1, passWord2));
            Console.ReadLine();

        }
        static string ValidateUsername(string userName)
        {
            string result;
            if (userName.Length == 8)
            { result = "A valid Username"; }
            else
            { result = "Username is not valid. It must include 8 characters"; }
            return result;
        }

        static string ValidatePassword(string passWord1, string passWord2)
        { string result2;
            if (passWord1.Length == 8)
            {
                if (passWord1 == passWord2)
                { result2 = "Password accepted !"; }
                else
                { result2 = "Error! your passwords don't match"; }
            }
            else
            { result2 = "Aww ! Your password must include 8 characters"; }
            return result2;
        }
    }
}
