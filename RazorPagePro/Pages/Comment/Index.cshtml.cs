using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagePro.Model;

namespace RazorPagePro.Pages.Comment
{
    [PageFilter]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        //Handler
        public void OnPostAdd(int id)
        {

        }

        public void OnPostAddComment(int id)
        {

        }
    }
}
