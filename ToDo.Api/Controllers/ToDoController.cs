using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToDo.Api.Controllers
{
    [Route("api/todo")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        public ToDoController()
        {
            
        }

        public async Task<IActionResult> CreateToDoTask([FromQuery] string description)
        {
            var result = 1;
            return Ok(result);
        }
    }
}
