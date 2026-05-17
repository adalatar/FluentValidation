using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public IActionResult Get()
        {
            return StatusCode(StatusCodes.Status200OK, "Category Get");
            return Ok("CategoryGet");
        }

    }
    }

