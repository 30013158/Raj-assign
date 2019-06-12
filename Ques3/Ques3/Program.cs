//Name : Rajveer Kaur
//Task3 - Adding 2 matrices together
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
            //Random numbers
            Random rand = new Random();

            //initialising Matrix A's array using random numbers and using nested for loop
            int[,] matrixA = new int[3, 3];
            
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for(int j=0; j < matrixA.GetLength(1); j++)
                { matrixA[i, j] = rand.Next(-10, 10); }
            }
            
            //displaying Matrix A
            Console.WriteLine("Matrix A: ");
            Display(matrixA);

            Console.WriteLine();

            //initialising Matrix A's array using random numbers and using nested for loop
            int[,] matrixB = new int[3, 3];

            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                { matrixB[i, j] = rand.Next(-10, 10); }
            }
            
            //displaying Matrix B
            Console.WriteLine("Matrix B: ");
            Display(matrixB);

            Console.WriteLine();

            //matrix C = matrix A = matrix B

            int[,] matrixC = new int[3, 3];
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                { matrixC[i, j] = matrixA[i, j] + matrixB[i, j];  }
            }
            Console.WriteLine("Matrix C = Matrix A + Matrix B ");
            Display(matrixC);

            Console.ReadLine();
        }
       
        //a method for displaying the arrays
        static void Display(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                Console.Write(arr[i, j] + " ");

                Console.WriteLine();
            }

        }
    }
}
