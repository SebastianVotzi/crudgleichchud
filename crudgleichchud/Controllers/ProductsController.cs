using crudgleichchud.Data;
using crudgleichchud.Models;
using Microsoft.AspNetCore.Mvc;

namespace crudgleichchud.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;
        public ProductsController(AppDbContext context)
        {
            _context = context;
            _context.Products.Add(new Product() { Name = "Teuflo", Price=10});
            _context.Products.Add(new Product() { Name = "Spendelgoon", Price =5});
            _context.Products.Add(new Product() { Name = "Johannson", Price = 1000000 });
            _context.Products.Add(new Product() { Name = "Grottenulm ullibulli", Price = 0 });
            _context.SaveChanges();
        }

        public IActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            return View(products);
        }
    }
}
