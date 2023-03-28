using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.DTO
{
    public class AddTodo
    {
        public string? Task { get; set; }

        public AddTodo(string task)
        {
            Task = task;
        }
    }
}