using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Models;

namespace RazorPagesApp
{
    public class PersonModel : PageModel
    {
        public string Message { get; set; }

        [BindProperty]
        public Person Person { get; set; }

        public void OnGet()
        {
            Message = "Input data";
        }

        public void OnPost()
        {
            Message = $"Name: {Person.Name}  Age: {Person.Age}";
        }
    }
}