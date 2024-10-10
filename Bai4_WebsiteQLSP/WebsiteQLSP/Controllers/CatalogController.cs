using Microsoft.AspNetCore.Mvc;
using WebsiteQLSP.Models;

namespace WebsiteQLSP.Controllers
{
    public class CatalogController : Controller
    {
        private readonly Context _context;

        public CatalogController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var catalogs = _context.Catalogs.ToList();
            return View("Danh mục sản phẩm", catalogs);
        }

    }
}
