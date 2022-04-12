using RazorPagePro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagePro.Services
{
   public interface IProductService
    {
        int Add(ProductDto productDto);
        int Delet(int Id);
        ProductDto Edit(ProductDto productDto);
        List<ProductDto> List();
        ProductDto Fint(int id);
        List<ProductDto> Search(string Name);

    }

    public class ProductService : IProductService
    {
        private readonly DataBaseContext _dataBaseContext;
        public ProductService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public int Add(ProductDto productDto)
        {
            _dataBaseContext.Products.Add(new Model.Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                Desciription = productDto.Desciription
            });

            return _dataBaseContext.SaveChanges();
        }

        public int Delet(int Id)
        {
            var Result = _dataBaseContext.Products.Find(Id);
            _dataBaseContext.Remove(Result);

            return _dataBaseContext.SaveChanges();
        }

        public ProductDto Edit(ProductDto productDto)
        {
            var Result = _dataBaseContext.Products.Find(productDto.Id);
            Result.Name = productDto.Name;
            Result.Price = productDto.Price;
            Result.Desciription = productDto.Desciription;
            _dataBaseContext.SaveChanges();

            return new ProductDto
            {
                Name = Result.Name,
                Desciription = Result.Desciription,
                Price = Result.Price
            };
        }

        public ProductDto Fint(int id)
        {
            var Result = _dataBaseContext.Products.Find(id);

            return new ProductDto
            {
                Name = Result.Name,
                Desciription = Result.Desciription,
                Price = Result.Price
            };
        }

        public List<ProductDto> List()
        {
            var Result = _dataBaseContext.Products.OrderByDescending(p => p.Id)
                .Select(p => new ProductDto
             {
                Id =p.Id,
                Desciription = p.Desciription,
                Name = p.Name,
                Price = p.Price
            }).ToList();

            return Result;
        }

        public List<ProductDto> Search(string Name)
        {
            var Result = _dataBaseContext.Products.OrderByDescending(p => p.Id)
               .Select(p => new ProductDto
               {
                   Id = p.Id,
                   Desciription = p.Desciription,
                   Name = p.Name,
                   Price = p.Price
               }).Where(p=>p.Name.Contains(Name)).ToList();

            return Result;
        }
    }
}
