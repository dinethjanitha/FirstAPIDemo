using FirstAPI.Service;
using FirstAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepo _todoService;
        public TodosController(ITodoRepo repository )
        {
            _todoService = repository;
        }
        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {

            var myTodos = _todoService.AllTodos();

            if (id is null) return Ok(myTodos);

            myTodos = myTodos.Where(t => t.Id == id).ToList();

            return Ok(myTodos);
        }       
    }
}
