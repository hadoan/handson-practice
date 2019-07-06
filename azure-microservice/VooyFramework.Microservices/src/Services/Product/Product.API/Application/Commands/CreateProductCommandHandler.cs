using MediatR;
using Product.Domain.AggregatesModel.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace Product.API.Application.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly IMediator mediator;
        private readonly IProductRepository productRepository;

        public CreateProductCommandHandler(IMediator mediator ,
            IProductRepository productRepository)
        {
            this.mediator = mediator;
            this.productRepository = productRepository;
        }
        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product.Domain.AggregatesModel.ProductAggregate.Product(request.Name, request.Desc);

            productRepository.Add(product);

            return await productRepository.UnitOfWork
              .SaveEntitiesAsync(cancellationToken);
        }
    }

}
