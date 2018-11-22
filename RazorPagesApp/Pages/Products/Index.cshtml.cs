using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationContext _context;
        public List<Product> Products { get; set; }

        public IndexModel(ApplicationContext db)
        {
            _context = db;
        }

        public void OnGet()
        {
            Products = _context.Products.AsNoTracking().ToList();
        }
    }
}
