using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    //----------------------------Task 2-------------------------------
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ProdDate { get; set; }
        public DateTime ExpDate { get; set; }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: ${Price}, Production date: {ProdDate:d}, Expiration date: {ExpDate:d}");
        }
        public virtual void ExpirationSearch()
        {
            if (ExpDate >= DateTime.Today)
            {
                Console.WriteLine($"Product: {Name} is fresh");
            }
            else
            {
                Console.WriteLine($"Product: {Name} is expired");
            }
        }
    }
    public class Batch : Product
    {
        public int Amount { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: ${Price}, Amount: {Amount}, Production date: {ProdDate:d}, Expiration date: {ExpDate:d}");
        }
    }
    public class Set : Product
    {
        public Product Prod { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: ${Price}, Set: {Prod.Name}");
        }
    }
}
