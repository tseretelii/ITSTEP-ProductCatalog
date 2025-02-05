namespace ProductCatalog.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product>? Products { get; set; }
        public bool IsPaid { get; set; } = false;
    }
}
