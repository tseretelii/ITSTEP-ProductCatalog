using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Interfaces;
using ProductCatalog.Models;
using ProductCatalog.Models.Entities;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService service)
        {
            _productService = service;
        }

        public async Task<IActionResult> Index()
        {
            return View( await _productService.Index() );
        }

        public async Task<IActionResult> Details(int id)
        {
            return View( await _productService.Details(id) );
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            await _productService.Create(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View(await _productService.Edit(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product request, int id)
        {
            await _productService.Edit(request, id);
            return RedirectToAction("Index");
        }
    }
}
