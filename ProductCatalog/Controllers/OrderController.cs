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
            return View(await _orderService.Index());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View(await _orderService.Index());
        }

        [HttpPost]
        public async Task<IActionResult> Create(List<int> productIds)
        {
            await _orderService.Create(productIds);
            return RedirectToAction("Index");
        }
    }
}
