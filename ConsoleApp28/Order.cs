using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp28.Warehouse;

namespace ConsoleApp28
{
    public class Order : IOrder
    {
        public int OrderId { get; set; }
        public ICustomer Customer { get; set; }
        public List<IProduct> Products { get; set; }
        public double TotalPrice { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("Order ID: " + OrderId);
            Customer.PrintInfo();
            Console.WriteLine("Order Products:");
            foreach (IProduct product in Products)
            {
                product.PrintInfo();
            }
            Console.WriteLine("Order Total Price: " + TotalPrice);
        }
    }
}
