using IDSps1.Data;
using IDSps1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IDSps1.Controllers
{
    public class DonorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DonorController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Charity> objcharity = _db.Charity;
            return View(objcharity);
        }

        public IActionResult Payment()
        {
            return View();
        }
    }
}
