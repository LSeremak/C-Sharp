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


            Diary diary = new Diary();
            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);
            //diary.AddRating(3);


            //float avg = diary.CalculateAverage();
            //float max = diary.MaxRating();
            //float min = diary.MinRating();


            for (; ; )
            {

                Console.WriteLine("Podaj ocenę z zakresu 1 - 10");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);

                

                if (rating == 11)
                {
                    break;
                }

                if (result)
                {
                    if (rating > 0 & rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba, podaj liczbę z zkresu 1 -10");
                    }
                }
            }

            Console.WriteLine("Srednia twoich ocen to :" + diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena to :" + diary.MaxRating());
            Console.WriteLine("Najniższa ocena to : " + diary.MinRating());


            Console.ReadKey();
        }





            //string min = "test";
            //string min2 = "test 2";


            //console.writeline(min);
            //console.writeline(min2);

            //min2 = "test 3";


            //console.writeline(min2);



            //string firstName;  // zmienna przechowyje imie
            //string lastName; // zminenna przechowuje nazwisko
            //string thanks = "Dziekuję!";



            //Console.WriteLine("Hej ty");
            //Console.Write("Wprowadź imię :");
            ///* Console.Write wuswietla wpisany ciag znakow w zminnnej  w jednym wierszu */

            //firstName = Console.ReadLine();

            //Console.Write("Wprowadź nazwisko :");
            //lastName = Console.ReadLine();

            //Console.WriteLine(thanks);



            //Console.WriteLine(
            //    $"Twoje imie i nazwisko to {firstName} {lastName}"
            //    );



            //double liczba1, liczba2, wynik;


            //Console.WriteLine("Podaj pierwszą liczbę:");
            //liczba1 = Double.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj drugą liczbę:");
            //liczba2 = Double.Parse(Console.ReadLine());

            //wynik = liczba1 + liczba2;

            //Console.WriteLine("\a");

            //Console.WriteLine("Wynik:" + wynik);

            //Console.WriteLine(@"Poczatek
            //        /\
            //       /  \
            //      /    \
            //                    Koniec");

            //string lenght = "Ile to jest znaków";

            //Console.WriteLine(lenght);

            //Console.WriteLine(lenght.Length);


            //string text, uppercase;

            //Console.WriteLine("Wprowadź tekst:");
            //text = Console.ReadLine();

            //Console.WriteLine("A teraz zaminimy test na duże litery");

            //uppercase = text.ToUpper();

            //Console.WriteLine(uppercase);


            //string[] languages = { "C#", "COBOL", "Java",
            //        "C++", "Visual Basic", "Pascal",
            //        "Fortran", "Lisp", "J#"};


            //Console.WriteLine(languages[2]);


            //string[] groceryList;
            //System.Console.Write("Ile elementów znajduje się na liście? ");
            //int size = int.Parse(System.Console.ReadLine());
            //groceryList = new string[size];



            //int a = 89;
            //int b = 99;
            //int c = 5;

            //var wynik = a % b % c; // modulo % - reszta z dzielenia

            //Console.WriteLine("Modulo z trzeh zmiennych to: " + wynik);


            //int zmienna = 256 >> 2;

            ////zmienna = 256 >> 2; // przesunięcie bitowe w lewo lub w prawo


            //Console.WriteLine(zmienna);

            //int xxx;
            //Console.WriteLine("Wprowadź liczbę:");
            //xxx = int.Parse(Console.ReadLine());

           

            //if (xxx > 25)
            //{
            //    Console.WriteLine("Za duża liczba");
            //}

            //else if (xxx < 25)
            //{
            //    Console.WriteLine("Za mała liczba");
            //}

            //else
            //{
            //    Console.WriteLine("Brawo!! To ta liczba!!");
            //}



             



            
        
    }

        
}
