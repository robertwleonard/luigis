using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace luigis.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }

        void SaveProuct(Product product);

        Product DeleteProduct(int productId);
    }
}
