using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp
{
    public class PersonModel : PageModel
    {
        public string Message { get; set; }

        [BindProperty(Name = "othername", SupportsGet = true)]
        public string Name { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Age { get; set; }

        public void OnGet()
        {
            Message = $"Name: {Name}  Age: {Age}";
        }

        public void OnPost()
        {
            Message = $"Name: {Name}  Age: {Age}";
        }
    }
}