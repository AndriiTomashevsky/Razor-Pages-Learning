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

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public int Age { get; set; }

        public void OnGet()
        {
            Message = "Input data";
        }

        public void OnPost()
        {
            Message = $"Name: {Name}  Age: {Age}";
        }
    }
}