using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Entities;
using TodoApi.Data;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        // TODO: lanjut untuk Todo repository sampai crud beres
        private readonly ILogger<TodoRepository> _logger;

        private readonly AppDbContext _context;

        public TodoRepository(ILogger<TodoRepository> logger)
        {
            _logger = logger;
        }

        public Todo AddTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public void DeleteTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public Todo GetTodo(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Todo>> GetTodos()
        {
            return await _context.Todos.ToListAsync();
        }

        public int UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}