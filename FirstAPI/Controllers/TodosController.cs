using FirstAPI.Services.Todos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FirstAPI.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepo _todoService;
        public TodosController(ITodoRepo repository )
        {
            _todoService = repository;
        }
        [HttpGet]
        public IActionResult GetTodos()
        {

            var myTodos = _todoService.AllTodos();
            return Ok(myTodos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodo(int id) { 
            var todo = _todoService.GetTodo(id);
            if (todo == null)
            {
                return NotFound();
            }
            
            return Ok(todo);
        }

    }
}
