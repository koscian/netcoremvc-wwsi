using Domain;
using System.Collections.Generic;

namespace Persistence
{
    public class OrdersRepository
    {
        private List<Order> database = new();

        public void Insert(Order order)
        {
            database.Add(order);
        }
        public List<Order> GetAll()
        {
            return database;
        }


    }
}
