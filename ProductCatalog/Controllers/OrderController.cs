using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Interfaces;
using ProductCatalog.Models.Entities;
using ProductCatalog.Models.VM;

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
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> ViewAllOrders()
        {
            return View(await _orderService.ViewAllOrders());
        }

        [HttpGet]
        public async Task<IActionResult> UpdateOrder(int Id)
        {
            var dict = await _orderService.UpdateOrder(Id);

            ViewBag.Products = dict.Value;
            return View(dict.Key);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateOrder(int Id, OrderViewModel model)
        {
            await _orderService.UpdateOrder(Id, model);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _orderService.Delete(id);

            return RedirectToAction("ViewAllOrders");
        }
    }
}
