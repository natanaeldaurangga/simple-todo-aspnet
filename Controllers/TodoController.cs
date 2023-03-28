using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.DTO;
using TodoApi.Entities;

namespace TodoApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly AppDbContext? _context;

        public TodoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context!.Todos!.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddTodo dto)
        {
            Todo todo = new Todo();
            todo.Task = dto.Task;

            _context?.Todos?.Add(todo);
            await _context!.SaveChangesAsync();
            return Ok(await _context!.Todos!.ToListAsync());
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete([FromQuery(Name = "id")] int id)
        {   // TODO: lanjut untuk update data, sama find
            Todo todo = await _context.Todos.FindAsync(id);

            if (todo == null) return BadRequest();

            _context.Todos.Remove(todo);
            await _context.SaveChangesAsync();
            return Ok(todo);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromQuery(Name = "id")] int id, [FromBody] AddTodo dto)
        {
            Todo todo = await _context.Todos.FindAsync(id);

            if (todo == null) return BadRequest();

            todo.Task = dto.Task;
            await _context.SaveChangesAsync();
            return Ok(todo);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Show([FromRoute] int id = 1)
        {
            Todo todo = await _context.Todos.FindAsync(id);
            if (todo == null) return BadRequest();
            return Ok(todo);
        }

    }
}