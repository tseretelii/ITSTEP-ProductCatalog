using ProductCatalog.Models.Entities;
using ProductCatalog.Models.VM;

namespace ProductCatalog.Interfaces
{
    public interface IOrderService
    {
        Task<List<Order>> Index();
        Task Create(List<int> productIds);
        Task<Order> GetOrder(int id);
        Task AddItemToOrder(int productId);
        Task UpdateOrder(int orderId, OrderViewModel orderViewModel);
    }
}
