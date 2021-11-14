using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class BooksService
    {
        public void AddBooks() 
        {
            string title, author, isbn;  
            decimal price;
            int publicationYear, productsAvailable;
            Console.WriteLine("Podaj tytuł: ");
            title = Console.ReadLine();
            Console.WriteLine("Podaj autora: ");
            author = Console.ReadLine();
            Console.WriteLine("Podaj kod ISBN: ");
            isbn = Console.ReadLine();
            Console.WriteLine("Podaj cenę: ");
            price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Podaj rok publikacji: ");
            publicationYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj dostępność książki: ");
            productsAvailable = Convert.ToInt32(Console.ReadLine());

        }
        public void RemoveBook() 
        {
            Console.WriteLine("Podaj tytuł książki do usunięcia");
        }

        public void ListBooks() 
        { 
            Console.WriteLine("Tu pojawi się lista książek"); 
        }
        public void ChangeState()
        {
            string title;
            int state;
            Console.WriteLine("Podaj tytuł książki której stan ma się zmienić: ");
            title = Console.ReadLine();
            Console.WriteLine("Podaj stan: ");
            state = Convert.ToInt32(Console.ReadLine());
        }
    }
}
