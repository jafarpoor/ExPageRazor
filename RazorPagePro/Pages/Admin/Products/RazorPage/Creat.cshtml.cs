using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagePro.Services;

namespace RazorPagePro.Pages.Admin.Products.RazorPage
{
    public class CreatModel : PageModel
    {
        [BindProperty]
        public ProductDto productDtos { get; set; } = new ProductDto();
        private readonly IProductService _productService;
        public CreatModel(IProductService service)
        {
            _productService = service;
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            _productService.Add(productDtos);
        }
    }
}
