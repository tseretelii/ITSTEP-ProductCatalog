using Microsoft.EntityFrameworkCore;
using ProductCatalog.Interfaces;
using ProductCatalog.Models;
using ProductCatalog.Models.Entities;

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

        public async Task Create(List<Product> products)
        {
            Order order = new Order() { Products = products};

            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public Task<Order> GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> Index()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }
    }
}
