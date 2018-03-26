using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace luigis.Models
{
    public class FakeProductRepository // : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
            new Product { Name = "Chicken Fettucini Alfredo", Price = 13 },
            new Product { Name = "Chicken Parmasean", Price = 14 },
            new Product { Name = "Five-Cheese Pesto Tortellini", Price = 11 }
        }.AsQueryable<Product>();
    }
}
