using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using ThinkDeeper

namespace ThinkDeeper.InventoryService
{
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        public InventoryController() { }

        // GET api/inventory
        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Gets()
        {
            return new string[] { "value1", "value2" };
        }

        
    
    }
}