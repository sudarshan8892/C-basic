using System.Transactions;

namespace OOPS.Filed
{
    public partial class Program
    {
        public class  customer
        {
            public int id { get; set; }
            public string  name { get; set; }

            public List<Order> orders = new List<Order>();  
            

          
            public customer( int id)
            {
                this.id = id;
            }
            public customer(int id, string name):this(id)
            {
                this.name = name;
            }

            public void promote()
            {
                orders = new List<Order>();
            }
        }
    }
}
