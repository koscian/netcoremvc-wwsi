using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            
            int result = 5 + 9;
            
            int number = 1;
            float money=3.14f;
            string text = "to jest tekst";
            bool isLogged = false;
            char myChar = 'm';
            decimal price = 120.12m;
            Console.WriteLine(number + ", " + money + ", " + text + ", " + isLogged + ", " + myChar + ", " + price);
            
            string myAge = "Age: ";
            int wifeAge = 18;
            var result = myAge + wifeAge;
            Console.WriteLine(result);
            //wniosek: dodanie zmiennych int i string połączy je w jedną zmienną typu string
            
            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;
            bool and = isTrue & isFalse;
            bool or = isTrue ^ isReallyTrue;
            bool negative = !isFalse;
            Console.WriteLine(and + ", " + or + ", " + negative);

            var a = 5;
            var b = 12;
            var add = a + b;
            var sub = a - b;
            var div = a / b;
            var mul = a * b;
            var mod = a % b;
            Console.WriteLine(add + ", " + sub + ", " + div + ", " + mul + ", " + mod);

            string a="Ala ", b="ma ", c="kota.";
            var result = a + b + c;
            Console.WriteLine(result);
            //dodawanie do siebie wielu zmiennych string łączy je w jedną długą zmienną string.  przy pisaniu słów należy pamiętać o spacjach

            int n1 = 10, n2 = 20;
            if (n1 == n2)
                Console.WriteLine("n1 jest równe n2");
            else if (n1 > n2)
                Console.WriteLine("n1 jest większe niż n2");
            else 
                Console.WriteLine("n2 jest większe niż n1");

            for (int i = 0; i < 10; i++)
                Console.WriteLine("C#");
            int j = 0;
            while (j<10)
            {
                Console.WriteLine("C#");
                j++;
            }

            var n = 10;
            for(int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i + "- Parzysta");
                else
                    Console.WriteLine(i + "- Nieparzysta");
            }

            string[] colors = new string[4] { "niebieski", "czerowny", "zielony", "czarny" };
            Console.WriteLine("Mój pierwszy kolor to " + colors[0]);
            Console.WriteLine("Mój ostatni kolor to " + colors[3]);

            int[] liczby = new int[10];
            for (int i = 0; i < 10; i++)
            {
                liczby[i] = i + 3;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Liczba: " + liczby[i]);
            }
            
            */
            List<string> fruits = new List<string>();
            fruits.Add("pomarańcza");
            fruits.Add("mandarynka");
            fruits.Add("limonka");
            fruits.Add("pomelo");
            Console.WriteLine(fruits[0] + ", " + fruits[1] + ", " + fruits[2] + ", " + fruits[3]);
            fruits.Remove("pomarańcza");
            fruits.RemoveAt(2);
            foreach(string item in fruits)
            {
                Console.WriteLine(item);
            }
        }
    }
}
