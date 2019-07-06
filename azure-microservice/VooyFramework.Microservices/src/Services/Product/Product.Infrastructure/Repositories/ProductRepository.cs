using Product.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Text;
using VooyFramework.Microservices.Product.Domain.AggregatesModel.ProductAggregate;

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

        public VooyFramework.Microservices.Product.Domain.AggregatesModel.ProductAggregate.Product Add(VooyFramework.Microservices.Product.Domain.AggregatesModel.ProductAggregate.Product product)
        {
            if (product.IsTransient())
            {
                return context.Products.Add(product).Entity;
            }
            else return product;
        }
    }
}
