using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double [,] matrixA = new double[3, 3];
            
            for (int i = 0; i <= 3; i++)
            {
                for(int j=0; j <= 3; j++)
                { matrixA[i, j] = rand.Next(-10, 10); }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix A: ");
            Display(matrixA);
            Console.ReadLine();
            
        }
        static void Display(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
