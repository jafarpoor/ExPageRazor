using Microsoft.EntityFrameworkCore;
using RazorPagePro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagePro.Data
{
    public class DataBaseContext :DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

      public DbSet<Product> Products { get; set; }
    }
}
