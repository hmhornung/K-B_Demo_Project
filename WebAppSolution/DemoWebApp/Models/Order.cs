namespace DemoWebApp.Models
{
    public class Order
    {

        public int Id { get; set; }
        public int ItemNumber { get; set; }
        public int Quantity { get; set; }
        public DateOnly MyProperty { get; set; }
        public Order()
        {
            
        }
    }
}
