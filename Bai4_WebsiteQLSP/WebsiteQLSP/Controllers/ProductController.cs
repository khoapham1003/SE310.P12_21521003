using Microsoft.AspNetCore.Mvc;
using WebsiteQLSP.Models;

namespace WebsiteQLSP.Controllers
{
    public class ProductController : Controller
    {
        private readonly Context _context;

        public ProductController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()    
        {
            var product = _context.Products.ToList();
            return View("Product", product);  
        }
    }
}
