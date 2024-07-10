using Domain.Entities;
using Domain.Interfaces.Application;
using Infrastructure.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : BaseController
    {
        private readonly ICategoriesApplication _application;

        public CategoriesController(ICategoriesApplication application)
        {
            _application = application;
        }

        [HttpGet("GetRecords")]
        public async Task<ActionResult> GetRecords() 
        {
            var result = await _application.GetRecords();
            return Ok(result);
        }
        [HttpPost("Insert")]
        public async Task<ActionResult> Insert(Categories entity)
        {
            var result = await _application.Insert(entity);
            return Ok(result);
        }
    }
}
