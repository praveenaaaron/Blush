using Blush.Controllers.Data;
using Blush.Models;

using Microsoft.AspNetCore.Mvc;

namespace Blush.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
