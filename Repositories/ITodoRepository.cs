using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Entities;

namespace TodoApi.Repositories
{
    public interface ITodoRepository
    {
        Task<IEnumerable<Todo>> GetTodos();

        Todo GetTodo(int id);

        Todo AddTodo(Todo todo);

        int UpdateTodo(Todo todo);

        void DeleteTodo(Todo todo);

    }
}