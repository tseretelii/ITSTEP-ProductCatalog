using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
