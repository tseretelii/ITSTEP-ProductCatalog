using Microsoft.EntityFrameworkCore;
using ProductCatalog.Interfaces;
using ProductCatalog.Models;
using ProductCatalog.Models.Entities;
using ProductCatalog.Models.VM;

namespace ProductCatalog.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;
        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task AddItemToOrder(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task Create(List<int> productIds)
        {
            Order order = new Order() { Products = new List<Product>()};

            var products = await _context.Products.Where(x => productIds.Contains(x.Id)).ToListAsync();

            order.Products = products;

            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public Task<Order> GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Order>> Index()
        {
            var orders = await _context.Orders.Include(x => x.Products).ToListAsync();
            return orders;
        }

        public async Task UpdateOrder(int orderId, OrderViewModel orderViewModel)
        {
            //var order = await _context.Orders.Include(x => x.Products).FirstOrDefaultAsync(x => x.Id == orderId);

            //var products = await _context.Products.Where(x => orderViewModel.ProductIds.Contains(x.Id)).ToListAsync();

            //order.Products = products;
            //order.IsPaid = orderViewModel.IsPaid;

            //await _context.Orders.ExecuteUpdateAsync(order);

        }
    }
}
