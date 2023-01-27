using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp28.Warehouse;

namespace ConsoleApp28
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee ID: " + EmployeeId);
        }
    }
}
