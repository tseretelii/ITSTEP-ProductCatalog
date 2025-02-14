using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Interfaces;
using ProductCatalog.Models;
using ProductCatalog.Models.Entities;

namespace ProductCatalog.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Product product)
        {
            await _context.Products.AddAsync(product);

            await _context.SaveChangesAsync();
        }

        public async Task<Product> Details(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (product == null)
                throw new Exception();

            return product;
        }

        public async Task<Product> Edit(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (product == null)
                throw new Exception();

            return product;
        }

        public async Task Edit(Product request, int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (product == null)
                throw new Exception();


            product.Name = request.Name;
            product.Description = request.Description;
            product.Price = request.Price;
            product.ProductImageURL = request.ProductImageURL;

            _context.Products.Update(product);

            await _context.SaveChangesAsync();
        }

        public async Task<List<Product>> Index()
        {
            return await _context.Products.OrderByDescending(x => x.Id).ToListAsync();
        }
    }
}
