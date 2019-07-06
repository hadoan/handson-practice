using Autofac;
using Product.Infrastructure.Repositories;
using System.Reflection;
using VooyFramework.Microservices.BuildingBlocks.EventBus.Abstractions;
using VooyFramework.Microservices.Product.API.Application.Queries;
using VooyFramework.Microservices.Product.Domain.AggregatesModel.ProductAggregate;

namespace VooyFramework.Microservices.Product.API.Infrastructure.AutofacModules
{
    public class ApplicationModule
        : Autofac.Module
    {

        public string QueriesConnectionString { get; }

        public ApplicationModule(string qconstr)
        {
            QueriesConnectionString = qconstr;

        }

        protected override void Load(ContainerBuilder builder)
        {

            builder.Register(c => new ProductQueries(QueriesConnectionString))
                .As<IProductQueries>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ProductRepository>()
                .As<IProductRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(Application.Commands.CreateProductCommandHandler).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(IIntegrationEventHandler<>));

        }
    }
}
