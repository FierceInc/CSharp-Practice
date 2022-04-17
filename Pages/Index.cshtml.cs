using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorTodo.Data;
using RazorTodo.Model;

namespace RazorTodo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationContext _context;
        public IEnumerable<Todo> Todos;
        public IndexModel(ApplicationContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
            Todos = _context.Todos;
        }
    }
}