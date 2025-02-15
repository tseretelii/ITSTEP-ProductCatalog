using Microsoft.AspNetCore.Http.HttpResults;
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
        public async Task<List<Product>> Index()
        {
            var products = await _context.Products.ToListAsync();
            return products;
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

        public async Task<List<Order>> ViewAllOrders()
        {
            var oders = await _context.Orders.Include(x => x.Products).ToListAsync();
            return oders;
        }
        public async Task<KeyValuePair<OrderViewModel, List<Product>>> UpdateOrder(int Id)
        {
            var order = await _context.Orders.Include(x => x.Products).FirstOrDefaultAsync(x => x.Id == Id);

            var products = await _context.Products.ToListAsync();

            if (order == null)
                throw new Exception("Order Not Found!");

            OrderViewModel orderViewModel = new OrderViewModel()
            {
                ProductIds = order.Products.Select(x => x.Id).ToList(),
            };

            return new KeyValuePair<OrderViewModel, List<Product>>(orderViewModel, products);
        }
        public async Task UpdateOrder(int orderId, OrderViewModel request)
        {
            var order = await _context.Orders.Include(x => x.Products).FirstOrDefaultAsync(x => x.Id == orderId);

            var products = new List<Product>();

            products = await _context.Products.Where(x => request.ProductIds.Contains(x.Id)).ToListAsync();

            order.Products = products;

            _context.Orders.Update(order);
            await _context.SaveChangesAsync();

        }

        public async Task Delete(int orderId)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == orderId);

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }
    }
}
