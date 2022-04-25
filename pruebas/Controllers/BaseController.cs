using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace pruebas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public IConfiguration Configuration;
        public BaseController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}
