using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }
        public string Data { get; set; }

        public void OnGet(string name, int age)
        {
            Message = "Your application description page.";

            Data = $"User {name}, Age {age}";
        }

        public void OnGetOtherHandler(string name, int age)
        {
            Message = "Your application description page.";

            Data = $"User {name}, Age {age} from other handler";
        }
    }
}
