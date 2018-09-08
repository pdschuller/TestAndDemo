using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbWebService.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
        // DbSet creates a query to make a list of ToDoItems
        public DbSet<ToDoItem> TodoItems { get; set; }
    }
}
