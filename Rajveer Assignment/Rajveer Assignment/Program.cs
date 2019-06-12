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
            Console.WriteLine();
            //initialising result outside of loops
            string result2 = "";
            string result = "";

            do
            {
              Console.Write("Please enter your username (atleast 8 characters): ");
              string userName = Console.ReadLine();
              Console.WriteLine(ValidateUsername(userName));
              result = ValidateUsername(userName);//Calling the ValidateUsername method
              Console.WriteLine();
            } while (result != " A valid Username! ");


            do
            { Console.Write("Please enter the password: ");
                string passWord1 = Console.ReadLine();
                Console.Write("Please re-enter your password to confirm: ");
                string passWord2 = Console.ReadLine();
                Console.WriteLine(ValidatePassword(passWord1, passWord2));
                result2 = ValidatePassword(passWord1, passWord2);//Calling the ValidatePassword method
                Console.WriteLine();
            }  while (result2 != "** Password accepted ! **");


            //Displaying a message for setting username and password
            Console.WriteLine("Congratulations! Your username and password have been accepted and set.");

            Console.ReadLine();
        }
       
        /*Validate usename method checks the length of username and returns a result 
        informing the user whether their username meet the requirements or not.*/
        static string ValidateUsername(string userName)
        {
            string result;
            if (userName.Length >= 8)
            { result = " A valid Username! "; }
            else
            {  result = "Invalid username! ";}
            return result;
        }

       
        /*Validate password method checks the length of password and also checks if both the passwords are
        same and if all the criteria is correct a message is sent of passwords acceptance otherwise an error message.*/
       static string ValidatePassword(string passWord1, string passWord2)
       { string result2;
            if (passWord1.Length >= 8 )
            {
                if (passWord1 == passWord2)
                { result2 = "** Password accepted ! **"; }
                else
                { result2 = "Error! Your passwords don't match"; }
            }
             else
            { result2 = "Oops! Your password must include at least 8 characters"; }
            return result2;
       }
    }
}
