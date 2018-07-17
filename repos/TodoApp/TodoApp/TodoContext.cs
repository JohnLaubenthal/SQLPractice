using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class TodoContext : DbContext
    {
        public TodoContext() :base()
        {
            //Runs the constructor DbContext
        }
        public DbSet<Todo> Todos { get; set; }
    }
}
