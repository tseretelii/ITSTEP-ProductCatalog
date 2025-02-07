using ProductCatalog.Models.Entities;

namespace ProductCatalog.Interfaces
{
    public interface IOrderService
    {
        Task<List<Product>> Index();
        Task Create(List<Product> products);
        Task<Order> GetOrder(int id);
        Task AddItemToOrder(int productId);
    }
}
