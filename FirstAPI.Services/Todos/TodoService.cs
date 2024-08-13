using FirstAPI.Models;

namespace FirstAPI.Services.Todos
{
    public class TodoService : ITodoRepo
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 0,
                Title = "Test 1",
                Description = "Test Description 1",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.New
            };

            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 1,
                Title = "Test 2",
                Description = "Test Description 2",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Inprogress
            };

            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 2,
                Title = "Test 3",
                Description = "Test Description 3",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = TodoStatus.New
            };

            todos.Add(todo3);

            return todos;
        }

        public Todo GetTodo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
