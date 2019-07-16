using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThinkDeeper.CatalogService.DTO;

namespace ThinkDeeper.CatalogService
{
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase
    {
        public CatalogController() { }

       
        [HttpGet("products")]
        public async Task<ProductListResponse> GetProducts(){
            
        }
    }
}