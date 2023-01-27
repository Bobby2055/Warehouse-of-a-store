using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp28.Warehouse;

namespace ConsoleApp28
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("Product Name: " + Name);
            Console.WriteLine("Product ID: " + ProductId);
            Console.WriteLine("Product Price: " + Price);
        }
    }
}
