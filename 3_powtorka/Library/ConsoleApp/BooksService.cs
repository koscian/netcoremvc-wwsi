using Persistence;
using System;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class BooksService
    {
        BooksRepository _repository = new();
        public BooksService(BooksRepository booksRepository) { }

        public BooksService() { }

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
            Console.WriteLine("Podaj stan magazynowy książki: ");
            productsAvailable = Convert.ToInt32(Console.ReadLine());

            _repository.Insert(new Book(title, author, publicationYear, isbn, productsAvailable, price));
            Console.WriteLine("Książka została dodana pomyślnie");

        }
        public void RemoveBook() 
        {
            Console.WriteLine("Podaj tytuł książki do usunięcia");
            string title = Console.ReadLine();
            _repository.RemoveByTitle(title);
        }

        public void ListBooks() 
        { 
            Console.WriteLine("Lista książek: ");
            var list = new List<Book>();
            list = _repository.GetAll();
            list.ForEach(Console.WriteLine);
            
        }
        public void ChangeState()
        {
            string title;
            int state;
            Console.WriteLine("Podaj tytuł książki której stan ma się zmienić: ");
            title = Console.ReadLine();
            Console.WriteLine("Podaj ilość na stanie: ");
            state = Convert.ToInt32(Console.ReadLine());
        }
    }
}
