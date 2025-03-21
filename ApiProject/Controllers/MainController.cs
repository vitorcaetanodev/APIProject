using ApiProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    [ApiController]
    [Route(template: "v1")]
    public class MainController : ControllerBase
    {
        [HttpGet]
        [Route(template:"main")]
        public List<Model> Get()
        {
            return new List<Model>();
        }
    }
}
