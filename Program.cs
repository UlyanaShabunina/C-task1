using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the column:\t");
            int x = int.Parse(Console.ReadLine());
            int y = x;
            int[,] A = new int[x, y];

            for (int i = 0; i < A.GetLength(0); i++)        
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.WriteLine("Line: " + i + " Column: " + j);
                    A[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Output array:");
            for (int i = 0; i < A.GetLength(0); i++)       
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int minValue = A.Cast<int>().Min();         
            Console.WriteLine("The minimum element in the array: " + minValue);


            int min = int.MaxValue;
            int max = int.MinValue;
            int k = 0;                      
            int I = 0;                      
            for (int i = 0; i < x; i++)
            {
                int sum = 0;
                for (int j = 0; j < y; j++)
                {
                    sum += A[j, i];
                }
                if (sum > max)
                {
                    k = i;
                    max = sum;
                }
                for (int j = 0; j < y; j++)
                {
                    sum += A[i, j];
                }
                if (sum < min)
                {
                    I = i;
                    min = sum;
                }
            }                     
            Console.WriteLine("Column number whith maximum sum: {0}\t", k + 1);
            Console.WriteLine("Maximum sum: {0}\t", max);
            Console.WriteLine();
            Console.WriteLine("Line number whith minimum sum: {0}\t", I + 1);
            Console.WriteLine("Minimum sum: {0}\t", min);
            Console.WriteLine();

            double [] P = new double[A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (minValue != 0)
                {
                    P[i] = A[i, k] - A[I, i];
                    P[i] /= minValue;
                }
                else
                {
                    Console.WriteLine("Division by zero");
                    return;
                }
            }
            
            Console.WriteLine("Array P:");
            for (int i = 0; i < P.GetLength(0); i++)
            {
                Console.Write(P[i] + "\t");

            }
        }                   
    }
}


