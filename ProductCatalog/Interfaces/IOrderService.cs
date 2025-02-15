using ProductCatalog.Models.Entities;
using ProductCatalog.Models.VM;

namespace ProductCatalog.Interfaces
{
    public interface IOrderService
    {
        Task<List<Product>> Index();
        //Task<List<Order>> Index();
        Task Create(List<int> productIds);
        Task<Order> GetOrder(int id);
        Task<KeyValuePair<OrderViewModel, List<Product>>> UpdateOrder(int orderId);
        Task UpdateOrder(int orderId, OrderViewModel order);
        Task<List<Order>> ViewAllOrders();
        Task Delete(int orderId);
    }
}
