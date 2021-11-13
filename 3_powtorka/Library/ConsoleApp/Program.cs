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

        }
    }
}
