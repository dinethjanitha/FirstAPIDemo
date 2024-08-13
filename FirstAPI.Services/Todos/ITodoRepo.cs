﻿using FirstAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAPI.Services.Todos
{
    public interface ITodoRepo
    {
        public List<Todo> AllTodos();
        public Todo GetTodo(int id);
    }
}

//test