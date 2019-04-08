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

            //string min = "test";
            //string min2 = "test 2";


            //console.writeline(min);
            //console.writeline(min2);

            //min2 = "test 3";


            //console.writeline(min2);



            string firstName;  // zmienna przechowyje imie
            string lastName; // zminenna przechowuje nazwisko
            string thanks = "Dziekuję!";



            Console.WriteLine("Hej ty");
            Console.Write("Wprowadź imię :");
            /* Console.Write wuswietla wpisany ciag znakow w zminnnej  w jednym wierszu */

            firstName = Console.ReadLine();

            Console.Write("Wprowadź nazwisko :");
            lastName = Console.ReadLine();

            Console.WriteLine(thanks);



            Console.WriteLine(
                $"Twoje imie i nazwisko to {firstName} {lastName}"
                );



            double liczba1, liczba2, wynik;
           

            Console.WriteLine("Podaj pierwszą liczbę:");
            liczba1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            liczba2 = Double.Parse(Console.ReadLine());

            wynik = liczba1 + liczba2;

            Console.WriteLine("\a");

            Console.WriteLine("Wynik:" + wynik);

            Console.WriteLine(@"Poczatek
                    /\
                   /  \
                  /    \
Koniec"
);

            string lenght = "Ile to jest znaków";

            Console.WriteLine(lenght);

            Console.WriteLine(lenght.Length);


            string text, uppercase;

            Console.WriteLine("Wprowadź tekst:");
            text = Console.ReadLine();

            Console.WriteLine("A teraz zaminimy test na duże litery");

            uppercase = text.ToUpper();

            Console.WriteLine(uppercase);


           
            

            

            










            Console.ReadKey();
        }
    }

        
}
