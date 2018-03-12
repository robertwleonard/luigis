using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace luigis.Models
{
    public class EFProductRepository : IProductRepository
    {
        private AppDbContext context;

        public EFProductRepository(AppDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
