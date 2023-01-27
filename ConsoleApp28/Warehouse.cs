using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    public class Warehouse
    {
        public interface IEmployee
        {
            string Name { get; set; }
            int EmployeeId { get; set; }
            void PrintInfo();
        }
        public interface ICustomer
        {
            string Name { get; set; }
            int CustomerId { get; set; }
            void PrintInfo();
        }
        public interface IProduct
        {
            string Name { get; set; }
            int ProductId { get; set; }
            double Price { get; set; }
            void PrintInfo();
        }
        public interface IOrder
        {
            int OrderId { get; set; }
            ICustomer Customer { get; set; }
            List<IProduct> Products { get; set; }
            double TotalPrice { get; set; }
            void PrintInfo();
        }
    }
}
