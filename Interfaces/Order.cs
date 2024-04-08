namespace Interfaces
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderPlaced { get; set; }
        public Shipment? shipment { get; set; }

        public float TotelPrice { get; set; }
        public bool IsShipped
        {
            get { return shipment != null; }
        }

    }
}