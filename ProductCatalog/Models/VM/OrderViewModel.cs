namespace ProductCatalog.Models.VM
{
    public class OrderViewModel
    {
        public List<int>? ProductIds { get; set; }
        public bool IsPaid { get; set; }
    }
}
