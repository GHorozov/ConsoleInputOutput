using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutputHomework
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            //Write a program that gets two numbers from the console and prints the greater of them.
            //Try to implement this without if statements.

            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());

            bool greaterAB = a >= b;
            Console.WriteLine(greaterAB? a:b); 
        }
    }
}
