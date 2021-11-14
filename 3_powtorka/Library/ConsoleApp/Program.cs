using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Persistence;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Urok", "Mateusz Mękarski i Kaja Kraska", 2021, "978-83-66747-35-7", 5000, 49.90m);
            BooksRepository repository = new BooksRepository();

            Console.WriteLine("Podaj login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Podaj hasło: ");
            string haslo = Console.ReadLine();

            if (login == "Admin" && haslo == "password")
                Console.WriteLine("Access granted");
            else
                Console.WriteLine("Access denied");

            Console.ReadKey();
            Console.Clear();

            BooksService booksService=new(new BooksRepository());

            string input="";
            while (input!="wyjdz")
            {
                Console.WriteLine("Wprowadź komendę (wpisz 'pomoc' aby zobaczyć listę komend): ");
                input = Console.ReadLine();
                if (input == "pomoc")
                {
                    Console.WriteLine("dodaj, usun, wypisz, zmien, dodaj zamowienie, lista zamowien");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "dodaj")
                {
                    booksService.AddBooks();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "usun")
                {
                    booksService.RemoveBook();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "wypisz")
                {
                    booksService.ListBooks();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "zmien")
                {
                    booksService.ChangeState();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "dodaj zamowienie")
                {
                    Console.WriteLine("proba dodania nowego zamowienia");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "lista zamowien")
                {
                    Console.WriteLine("proba wypisania wszystkich zamowien");
                    Console.ReadKey();
                    Console.Clear();
                }
                

            }
        }
    }
}
