using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models.Entities;

namespace ProductCatalog.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> Index();
        Task<Product> Details(int id);
        Task Create(Product product);
        Task<Product> Edit(int id);
        Task Edit(Product request, int id);
    }
}
