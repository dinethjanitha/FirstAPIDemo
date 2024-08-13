using FirstAPI.DataAccess;
using FirstAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAPI.Services.Todos
{

    public class TodoSqlServerService : ITodoRepo
    {
        public readonly TodoDbContex _context = new TodoDbContex();
        public List<Todo> AllTodos()
        {
            return _context.Todos.ToList();
        }

        public Todo GetTodo(int id)
        {
            return _context.Todos.Find(id);
        }
    }
}
