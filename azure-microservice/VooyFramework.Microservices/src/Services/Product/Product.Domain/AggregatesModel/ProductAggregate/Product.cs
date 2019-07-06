using Product.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace VooyFramework.Microservices.Product.Domain.AggregatesModel.ProductAggregate
{
    public class Product : Entity, IAggregateRoot
    {
        // DDD Patterns comment
        // Using private fields, allowed since EF Core 1.1, is a much better encapsulation
        // aligned with DDD Aggregates and Domain Entities (Instead of properties and property collections)
        private string name;
        private string desc;

        public Product(string name, string desc)
        {
            this.name = name;
            this.desc = desc;
        }
    }
}
