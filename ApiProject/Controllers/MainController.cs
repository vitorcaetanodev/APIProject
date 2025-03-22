using ApiProject.Data;
using ApiProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiProject.Controllers
{
    [ApiController]
    [Route(template: "v1")]
    public class MainController : ControllerBase
    {

        [HttpGet]
        [Route(template: "main")]
        public async Task<IActionResult> GetAsync(
            [FromServices] AppDbContext context)
        {
            var models = await context
                .Models
                .AsNoTracking()
                .ToListAsync();
            return Ok(models);
        }

        [HttpGet]
        [Route(template: "todos/{id}")]
        public async Task<IActionResult> GetByIdAsync(
            [FromServices] AppDbContext context, [FromRoute] int id)
        {
            var models = await context
                .Models
                .AsNoTracking()
                .FirstOrDefaultAsync(x=>x.Id == id);
            return Ok(models);
        }
    }
}
