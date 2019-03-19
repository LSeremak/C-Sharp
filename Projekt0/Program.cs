using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.WriteLine("Dziś jest:");
            Console.WriteLine(DateTime.Now.DayOfWeek);

            //int first = 20;
            // int second = 30;
            // int third = first + second;
            // Console.WriteLine(third / 2);



            Console.WriteLine("Jak długo dziś spaleś?");

            int hoursOfSleep = int.Parse(Console.ReadLine());

            if (hoursOfSleep > 8)
            {
                Console.WriteLine("Jesteś wyspany");
            }
            else
            {
                Console.WriteLine("Oj niedobrze, powinieneś spać dłużej");
            }




            Console.ReadKey();
        }
    }

        
}
