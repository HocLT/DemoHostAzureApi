
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoHostAzureApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello Guy";
        }

        [HttpPost]
        [Route("{name}")]
        public string Welcome(string name)
        {
            return "Hello " + name;
        }
    }
}
