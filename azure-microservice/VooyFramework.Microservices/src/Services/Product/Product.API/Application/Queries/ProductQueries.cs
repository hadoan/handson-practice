using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace VooyFramework.Microservices.Product.API.Application.Queries
{
    public class ProductQueries : IProductQueries
    {
        private string _connectionString = string.Empty;
        public ProductQueries(string constr)
        {
            _connectionString = !string.IsNullOrWhiteSpace(constr) ? constr : throw new ArgumentNullException(nameof(constr));
        }
        public async Task<Product> GetProductAsync(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = await connection.QueryAsync<dynamic>(
                 @"select * from product.Products
                        WHERE p.Id=@id"
                      , new { id }
                  );

                if (result.AsList().Count == 0)
                    throw new KeyNotFoundException();

                return MapOrderItems(result);
            }
        }

        public async Task<IEnumerable<ProductSummary>> GetProductListAsync(string category)
        {
            throw new NotImplementedException();
        }

        private Product MapOrderItems(dynamic result)
        {
            var product = new Product
            {
                //ordernumber = result[0].ordernumber,
                //date = result[0].date,
                //status = result[0].status,
                //description = result[0].description,
                //street = result[0].street,
                //city = result[0].city,
                //zipcode = result[0].zipcode,
                //country = result[0].country,
                //orderitems = new List<Orderitem>(),
                //total = 0
            };



            return product;
        }
    }
}
