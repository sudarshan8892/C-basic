using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.costructors
{


    public class Customer
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public List<Order>? order { get; set; }
        public Customer()//parameterless Constrctors
        {
          order= new List<Order>();
        }
       public Customer(string name ):this()
        {
            this.Name = name;
        }
        public Customer(int id, string name):this(name)
        {
             this.id=id; 
        }
        public Customer(int id, string name ,string last) : this(name)
        {
            this.id = id;
        }

        static void Main(string[] rag)
        {
            var c = new Customer(1, "shetty");
            var order = new Order();
            //c.order.Add(order); 
           
          
            Console.WriteLine( c.Name);
            Console.WriteLine( c.id );


        }
    }
}
