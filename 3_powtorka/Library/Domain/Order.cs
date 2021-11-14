using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public class Order
    {
        DateTime Date { get; set; }
        List<BookOrdered> BooksOrderedList { get; set; }

        public Order()
        {
            Date = DateTime.Now;
            BooksOrderedList = new();
        }
        public override string ToString()
        {
            string str = $"Order: {Date} Book: {BookId} Count: {NumerOrdered}";
            return str;
        }
    }
}
