namespace Refactor.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public bool Approved { get; set; }
        public decimal Amount { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
