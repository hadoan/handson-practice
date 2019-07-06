using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VooyFramework.Microservices.Product.API.Application.Queries;

namespace Product.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IProductQueries productQueries;

        public ProductsController(
            IMediator mediator,
            IProductQueries productQueries
            )
        {
            this.mediator = mediator;
            this.productQueries = productQueries;
        }

        [Route("create")]
        [HttpPost]
        public async Task<ActionResult<bool>> CreateProduct([FromBody] VooyFramework.Microservices.Product.API.Application.Commands.CreateProductCommand createProductCommand)
        {

            return await mediator.Send(createProductCommand);
        }
    }
}
