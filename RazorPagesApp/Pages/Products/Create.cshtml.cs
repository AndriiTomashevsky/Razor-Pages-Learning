using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationContext _context;

        [BindProperty]
        public Product Product { get; set; }

        public CreateModel(ApplicationContext db)
        {
            _context = db;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(Product);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}