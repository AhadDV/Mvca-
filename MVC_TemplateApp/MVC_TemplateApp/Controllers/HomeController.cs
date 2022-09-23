using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_TemplateApp.Models;
using System.Diagnostics;

namespace MVC_TemplateApp.Controllers
{
    public class HomeController : Controller
    {
       private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.Include(x => x.ProductPhotos);
             
            return View(products);
        }
    }
}