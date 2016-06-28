using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutputHomework
{
    class CirclePerimeterArea
    {
        static void Main(string[] args)
        {
            Console.Write("r=");
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14;
            
            double circleArea = pi * Math.Pow(r, 2);
            double circlePerimeter = 2 * pi * r;
             
            Console.WriteLine("{0:F2}", circlePerimeter);
            Console.WriteLine("{0:F2}", circleArea);

        }
    }
}
