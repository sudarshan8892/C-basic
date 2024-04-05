using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Filed
{
    public partial class Program
    {
        static void Main(string[] args) 
        {
            customer customer = new customer(1);
            customer.orders.Add(new Order());
            customer.orders.Add(new Order());
            Console.WriteLine(  customer.orders.Count());
            customer.promote();

            Console.WriteLine(customer.orders.Count());

        }
    }
}
