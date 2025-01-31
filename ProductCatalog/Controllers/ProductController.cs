using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models.Entities;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> ProductList { get; set; } = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name = "IPhone",
                Description = "New Phone",
                Price = 1999m,
                ProductImageURL = "https://www.apple.com/newsroom/images/2024/09/apple-debuts-iphone-16-pro-and-iphone-16-pro-max/article/Apple-iPhone-16-Pro-hero-240909_inline.jpg.large.jpg"
            },
            new Product
            {
                Id = 2,
                Name = "MacBook Pro",
                Description = "High-performance laptop for professionals",
                Price = 2499m,
                ProductImageURL = "https://plus.unsplash.com/premium_photo-1681666713728-9ed75e148617?q=80&w=1470&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
            },
            new Product
            {
                Id = 3,
                Name = "Samsung Galaxy S23 Ultra",
                Description = "Latest flagship smartphone with advanced features",
                Price = 1299m,
                ProductImageURL = "https://images.unsplash.com/photo-1678958274412-563119ec18ab?q=80&w=1335&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
            },
            new Product
            {
                Id = 4,
                Name = "Sony WH-1000XM5",
                Description = "Noise-canceling wireless headphones",
                Price = 349m,
                ProductImageURL = "https://images.unsplash.com/photo-1577174881658-0f30ed549adc?q=80&w=1320&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
            },
            new Product
            {
                Id = 5,
                Name = "Apple Watch Series 9",
                Description = "Smartwatch with health and fitness tracking",
                Price = 399m,
                ProductImageURL = "https://images.unsplash.com/photo-1705307543536-06ebcb39bb0c?q=80&w=1470&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
            }

        };
        public IActionResult Index()
        {
            return View(ProductList);
        }

        public IActionResult Details(int id)
        {
            // var product = ProductList[id];
            var product = ProductList.FirstOrDefault(x => x.Id == id);

            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
