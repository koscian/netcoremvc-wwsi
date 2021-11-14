using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class OrderService
    {
        private OrdersRepository _orderRepository { get; set; }
        OrderService(OrdersRepository orderRepository) 
        {
            _orderRepository = orderRepository;
        }
        public void PlaceOrder()
        {
            Order order = new Order();
            Console.WriteLine("add - dodaj pozycje do zamowienia \nend - zamknij zamowienie");
            string str=Console.ReadLine();
            int idKsiazki, ilosc;
            while (str == "add")
            {
                Console.WriteLine("Podaj ID książki:");
                idKsiazki = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj ilość:");
                ilosc = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
