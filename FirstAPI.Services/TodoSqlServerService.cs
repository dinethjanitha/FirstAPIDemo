using FirstAPI.DataAccess;
using FirstAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAPI.Services
{

    public class TodoSqlServerService : ITodoRepo
    {
        public readonly TodoDbContex _context = new TodoDbContex();
        public List<Todo> AllTodos()
        {
           return _context.Todos.ToList();
        }
    }
}
