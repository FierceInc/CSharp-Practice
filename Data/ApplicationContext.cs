using Microsoft.EntityFrameworkCore;
using RazorTodo.Model;

namespace RazorTodo.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }
    }
}
