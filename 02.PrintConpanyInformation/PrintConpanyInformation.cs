using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutputHomework
{
    class PrintConpanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Company name:");
            string cName = (string)Console.ReadLine();
           
            Console.Write("Company address:");
            string cAddress = (string)Console.ReadLine();
            
            Console.Write("Tel:(+)");
            long cPhone = long.Parse(Console.ReadLine());
            
            Console.Write("Fax:");
            string fax = (string)(Console.ReadLine());
            
            Console.Write("Web site:");
            string webSite = (string)Console.ReadLine();
            
            Console.Write("Manager first name:");
            string firstName = (string)Console.ReadLine();
           
            Console.Write("Manager last name:");
            string lastName = (string)Console.ReadLine();
           
            Console.Write("Manager age:");
            byte mAge = byte.Parse(Console.ReadLine());
           
            Console.Write("Manager phone:");
            long mPhone = long.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(cName);
            Console.WriteLine(cAddress);
            Console.WriteLine(cPhone);
            Console.WriteLine(fax);
            Console.WriteLine(webSite);
            Console.WriteLine("Manager:{0} {1} (age:{2}, tel.(+){3})", firstName, lastName, mAge, mPhone);

        }
    }
}
