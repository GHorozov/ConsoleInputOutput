using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutputHomework
{
    class FibonacciNumber
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
            //(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i < n +n/2; i++)
            {
                Console.Write(i + ", ");
            }        
        }
    }
}
