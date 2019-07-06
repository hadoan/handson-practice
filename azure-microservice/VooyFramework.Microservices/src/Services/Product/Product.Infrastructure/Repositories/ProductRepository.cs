using Product.Domain.AggregatesModel.ProductAggregate;
using Product.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext context;

        public ProductRepository(ProductContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IUnitOfWork UnitOfWork => context;

        public Domain.AggregatesModel.ProductAggregate.Product Add(Domain.AggregatesModel.ProductAggregate.Product product)
        {
            if (product.IsTransient())
            {
                return context.Products.Add(product).Entity;
            }
            else return product;
        }
    }
}
