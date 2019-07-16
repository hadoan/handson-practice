using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ordersapi.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var o1=new Order{Id="ID1",Amount= 200};
            var o2=new Order{Id="ID2",Amount= 400};
            return Ok(new List<Order>{o1,o2});
        }

       
    }

    public class Order
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        
    }
}
