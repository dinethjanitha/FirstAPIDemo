using FirstAPI.Models;
using FirstAPI.Service;
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
        private TodoService _todoService;
        public TodosController()
        {
            _todoService = new TodoService();
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
