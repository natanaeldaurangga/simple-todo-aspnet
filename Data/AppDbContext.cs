using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Entities;

namespace TodoApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo>? Todos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        // TODO: lanjut untuk bikin crud rest api todo app
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();// untuk memberitahu Npgsql kalo kita menggunakan serial (autoincrment) bawaan dari postgrenya
        }

        internal Task SaveChangesAsync(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}