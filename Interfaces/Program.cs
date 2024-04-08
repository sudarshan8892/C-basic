namespace Interfaces
{
    public class Program
    {
        public static void Main(string [] args)
        {
            var orderProcesser = new OrderProcessor( new ShippingCalculator());
            
            var order= new Order() { OrderPlaced= DateTime.Now,TotelPrice= 20f };
            var result= orderProcesser.Processer(order);
            Console.WriteLine("cost:{0},shipping Date:{1}", result.cost, result.ShippingDate);

        }
    }
}
