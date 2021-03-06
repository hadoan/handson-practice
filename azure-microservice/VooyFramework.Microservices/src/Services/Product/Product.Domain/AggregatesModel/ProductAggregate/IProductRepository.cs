﻿using Product.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace VooyFramework.Microservices.Product.Domain.AggregatesModel.ProductAggregate
{
    public interface IProductRepository : IRepository<Product>
    {
        Product Add(Product product);
    }
}
