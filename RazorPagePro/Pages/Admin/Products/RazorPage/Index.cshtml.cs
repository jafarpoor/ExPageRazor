using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagePro.Services;

namespace RazorPagePro.Pages.Admin.Products.RazorPage
{
    public class IndexModel : PageModel
    {
        public List<ProductDto> productDtos { get; set; } = new List<ProductDto>();
        private readonly IProductService _productService;
        public IndexModel(IProductService service)
        {
            _productService = service;
        }
        public void OnGet()
        {
            productDtos = _productService.List();
        }
    }
}
