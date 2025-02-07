using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Interfaces;
using ProductCatalog.Models.Entities;

namespace ProductCatalog.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public async Task<IActionResult> Index()
        {
            return View( await _orderService.Index());
        }

        [HttpPost]
        public async Task<IActionResult> Create(List<Product> products)
        {
            await _orderService.Create(products);
            return RedirectToAction("Index");
        }
    }
}
