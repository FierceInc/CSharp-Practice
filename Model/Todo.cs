using System.ComponentModel.DataAnnotations;

namespace RazorTodo.Model
{
    public class Todo
    {   [Key]
        public int Id { get; set; }
        [Required]
        public string Day { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool IsCompleted{ get; set; }
    }
}
