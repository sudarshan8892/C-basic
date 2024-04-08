namespace Interfaces
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculater;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculater = shippingCalculator;
        }
        public  Shipment  Processer( Order  order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException(" this order is already shipped ");
            }

            order.shipment = new Shipment
            {
                cost = _shippingCalculater.CalculateShipping(order),
                ShippingDate= DateTime.Now.AddDays(1)
                
            
            };

            return order.shipment;
        }
    }
}
