using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks()
        {
            string[] task = new string[] { "Task 1", "Task 2", "Task 3","Task 4" };
            return Ok(task) ;
        }

        [HttpPost]
        public IActionResult NewTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTask()
        {
            return Ok();
        }


        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }
    }
}
