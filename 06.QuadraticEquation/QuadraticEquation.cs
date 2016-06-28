using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutputHomework
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a,b,c digit of quadratic equation:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("First we found discriminant with formula: b^2 - 4*a*c.");

            int D = (b * b) - 4 * a * c;


            Console.WriteLine("D is:" + D);


            double descriminant = Math.Sqrt(D);
            Console.WriteLine("Descriminant is" + descriminant);

            bool isInt = descriminant % 1 == 0;
            Console.WriteLine("isInt:" + isInt);



            if (D > 0)
            {
                Console.WriteLine("The equation have two solutions.");
            }
            else if (D == 0)
            {
                Console.WriteLine("The equation have only one solution.");
            }
            else
            {
                Console.WriteLine("The equation do not have solution.");
            }

            if (D > 0)
            {
                Console.WriteLine("x1=" + ((-b + descriminant) / (2 * a)));
                Console.WriteLine("x2=" + ((-b - descriminant) / (2 * a)));
            }
            else if (D == 0)
            {
                Console.WriteLine("x1=" + (-b / (2 * a)));
            }
            else
            {
                Console.WriteLine("No real roots");
            }
          
        }
    }
}
