using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagePro.Model;

namespace RazorPagePro.Pages.Sum
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Number number { get; set; } = new Number();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
             RazorPagePro.Services.Sum sum = new RazorPagePro.Services.Sum();
            number.Result =  sum.Excute(number.Value1, number.Value2);
            return Page();
        }
    }
}
