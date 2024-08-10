using FirstAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAPI.Services
{
    public interface ITodoRepo
    {
        public List<Todo> AllTodos();  
    }
}

//test