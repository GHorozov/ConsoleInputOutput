using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutputHomework
{
    class SunOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} from {1} numbers = ", i + 1, n);
                double newNumber = double.Parse(Console.ReadLine());
                sum += newNumber;
            }
            Console.WriteLine("The sum is " + sum);
        }
    }
}
