using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.API.Application.Queries
{
    public class Product
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public List<ProductCategory> Categories { get; set; }

    }

    public class ProductCategory
    {
        public string Name { get; set; }
    }

    public class ProductSummary
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public List<String> Categories { get; set; }
    }
}
