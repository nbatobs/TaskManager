using System.ComponentModel.DataAnnotations;

namespace API_project.Model.DTO;

public class DatabaseDTO
{
    [Key]
    public int TaskID { get; set; }
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    [Required]
    public TaskStatusDTO Status { get; set; }
    public DateTime DueDate { get; set; }
    
    public enum TaskStatusDTO
    {
        ToDo,
        InProgress,
        Completed
    }
}