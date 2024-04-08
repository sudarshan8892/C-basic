namespace Interfaces
{
     public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
    public class ShippingCalculator: IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotelPrice < 30f)
                return order.TotelPrice * 01f;

            return 0;
        }
    }
}
