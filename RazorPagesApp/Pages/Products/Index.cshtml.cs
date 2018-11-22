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

        public async Task OnGetAsync()
        {
            Products = await _context.Products.AsNoTracking().ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
