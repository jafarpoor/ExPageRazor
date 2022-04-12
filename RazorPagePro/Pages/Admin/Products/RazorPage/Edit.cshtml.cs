using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagePro.Services;

namespace RazorPagePro
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public ProductDto productDtos { get; set; } 
        private readonly IProductService _productService;

        public EditModel(IProductService service)
        {
            _productService = service;
        }
        public IActionResult OnGet(int? id)
        {
            productDtos = _productService.Fint(id.Value);
            if (productDtos == null)
                return NotFound();
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            _productService.Edit(productDtos);
            return RedirectToPage();
        }
    }
}