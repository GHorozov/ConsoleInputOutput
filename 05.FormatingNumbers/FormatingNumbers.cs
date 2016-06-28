using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutputHomework
{
    class FormatingNumbers
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 numbers:integer a (0 <= a <= 500); floating-point b; floating-point c
            //The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
            //The number a should be printed in hexadecimal, left aligned
            //Then the number a should be printed in binary form, padded with zeroes
            //The number b should be printed with 2 digits after the decimal point, right aligned
            //The number c should be printed with 3 digits after the decimal point, left aligned.

            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            if (a >= 0 && a <= 500)
            {
                Console.Write("b=");
                float b = float.Parse(Console.ReadLine());
                Console.Write("c=");
                float c = float.Parse(Console.ReadLine());
                string bitA = Convert.ToString(a,2).PadLeft(10,'0');
                Console.WriteLine("|{0,-10:X}|{1}|{2,10:N2}|{3,-10:0.000}|", a, bitA, b, c);

            }
            else
                Console.WriteLine("Incorect value for number a.");
           
        
        
        
        
        
        }
    }
}
