namespace backend
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LinePrice { get { return UnitPrice * Qty; } }
    }
}
