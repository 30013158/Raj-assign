//Name - Rajveer Kaur
//Task-2 : Creating a payroll system
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************Welcome to Holiday Park's new Payroll system********************");
            Employee E1 = new Employee();//creating an employee object
            Console.Write("Please enter your full name: ");
            E1.Name = Console.ReadLine();
            Console.Write("Please enter your annual gross salary: $");
            E1.Gross = double.Parse(Console.ReadLine());
            Console.Write("Please enter your tax rate: ");
            E1.Tax = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Have a look at your record:");
            Console.WriteLine($"\nName: {E1.Name} \nGross Salary: ${E1.Gross} \nTax rate: {E1.Tax}% \nNet Salary: ${E1.CalcNet()}");
            Console.ReadLine();
        }
    }
    public class Employee
    {
        //instance variables
        private string name;
        private double gross;
        private double tax;

        //getters and setters
        public string Name { get { return name; } set { name = value; } }
        public double Gross { get { return gross; } set { gross = value; } }
        public double Tax { get { return tax; } set { tax = value; } }

        //CalcNet Method
        public double CalcNet()
        { return Gross * (1 - Tax / 100); }
        
        
        //parameterless constructor
        public Employee ()
        { Console.WriteLine("Employee record created"); }
    }
}
