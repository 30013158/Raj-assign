//Name - Rajveer Kaur
//Task-1: Creating a login system
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
            string result = "";

            do
            {
                Console.Write("Please enter your username: ");
                string userName = Console.ReadLine();
                Console.WriteLine(ValidateUsername(userName));//Calling the ValidateUsername method
                Console.WriteLine();
            } while (result != "Invalid username!");
            do
            { Console.Write("Please enter the password: ");
                string passWord1 = Console.ReadLine();
                Console.Write("Please re-enter your password to confirm: ");
                string passWord2 = Console.ReadLine();

                result = ValidatePassword(passWord1, passWord2);
                Console.WriteLine();

            } while (result != "Password accepted !" || result != " ");//check
            Console.ReadLine();

            

        }
        static string ValidateUsername(string userName)
        {
            string result;
            if (userName.Length == 8)
            { result = "A valid Username"; }
            else
            {  result = "Invalid username!";}
            return result;
        }

        static string ValidatePassword(string passWord1, string passWord2)
        { string result2;
            if (passWord1.Length >= 8)//look at
            {
                if (passWord1 == passWord2)
                { result2 = "Password accepted !"; }
                else
                { result2 = "Error! your passwords don't match"; }
            }
            else
            { result2 = "Oops! Your password must include 8 characters"; }
            return result2;
        }
    }
}
