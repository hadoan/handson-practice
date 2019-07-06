using MediatR;
using Microsoft.AspNetCore.Mvc;
using Product.API.Application.Commands;
using Product.API.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<ActionResult<bool>> CreateProduct([FromBody] CreateProductCommand createProductCommand)
        {

            return await mediator.Send(createProductCommand);
        }
    }
}
