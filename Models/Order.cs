namespace Refactor.Models
{
    public class Order
    {
        public int Id { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Amount { get; set; }
        public string CustomerId { get; set; }
    }
}
