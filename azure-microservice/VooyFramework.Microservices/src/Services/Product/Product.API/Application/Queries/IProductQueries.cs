using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VooyFramework.Microservices.Product.API.Application.Queries
{
    public interface IProductQueries
    {
        Task<Product> GetProductAsync(int id);
        Task<IEnumerable<ProductSummary>> GetProductListAsync(string category);
    }
}
