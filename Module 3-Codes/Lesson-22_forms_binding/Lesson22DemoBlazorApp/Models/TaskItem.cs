using System.ComponentModel.DataAnnotations;

namespace Lesson22DemoBlazorApp.Models
{
    public class TaskItem
    {
        [Required]
        public string Title { get; set; } = "";

        [Required]
        public DateTime? DueDate { get; set; }

        public bool IsComplete { get; set; }
    }
}
