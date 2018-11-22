using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        public IActionResult OnGet()
        {
            string url = Url.Page("About", new { name = "Tom", age = 34 });
            return Redirect(url);
        }
    }
}
