using FirstAPI.Services.Authors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepo _authorService;
        public AuthorsController(IAuthorRepo service)
        {
            _authorService = service;   
        }

        [HttpGet]
        public IActionResult GetAlltodos() { 
            var authors = _authorService.GetAllAuthors();
            return Ok(authors);    
        
        }

        [HttpGet("{id}")]
        public IActionResult Gettodo(int id)
        { 
            var author = _authorService.GetAuthor(id);

            if (author == null) { 
                return NotFound();
            }

            return Ok(author);   
        }
    }
}
