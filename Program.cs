//Rivka Nadell 6848
//Rina Greenboim 5948
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_01_6848_5948
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            const int SIZE = 20;
            int[] A = new int[SIZE], B = new int[SIZE], C = new int[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                A[i] = r.Next(18, 123);//puts in the numbers
                B[i] = r.Next(18, 123);//puts in the numbers
            }
            for (int i = 0; i < SIZE; i++)
            {
                C[i] = Math.Abs(A[i] - B[i]);
            }
            for (int i = 0; i < SIZE; i++)
            {
                if (A[i] / 10 == 0)
                    Console.Write(" " + A[i] + "  ");
                else
                {
                    if (A[i] / 100 == 0)
                        Console.Write(A[i] + "  ");
                    else
                        Console.Write(A[i] + " ");
                }

            }
            Console.WriteLine();

            for (int i = 0; i < SIZE; i++)
            {
                if (B[i] / 10 == 0)
                    Console.Write(" " + B[i] + "  ");
                else
                {
                    if (B[i] / 100 == 0)
                        Console.Write(B[i] + "  ");
                    else
                        Console.Write(B[i] + " ");
                }

            }
            Console.WriteLine();

            for (int i = 0; i < SIZE; i++)
            {
                if (C[i] / 10 == 0)
                    Console.Write(" " + C[i] + "  ");
                else
                {
                    if (C[i] / 100 == 0)
                        Console.Write(C[i] + "  ");
                    else
                        Console.Write(C[i] + " ");
                }

            }
            Console.WriteLine();

        }
    }
}
