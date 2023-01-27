using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp28.Warehouse;

namespace ConsoleApp28
{
    public class Customer : ICustomer
    {
        public string Name { get; set; }
        public int CustomerId { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("Customer Name: " + Name);
            Console.WriteLine("Customer ID: " + CustomerId);
        }
    }
}
