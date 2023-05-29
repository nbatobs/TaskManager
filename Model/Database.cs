using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace API_project.Model;

public class Database
{
    [Key]
    public int TaskID { get; set; }
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    [Required]
    public TaskStatus Status { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public enum TaskStatus
    {
        ToDo,
        InProgress,
        Completed
    }
    public Database()
    {
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
    
    public void UpdateTimestamps()
    {
        UpdatedAt = DateTime.Now;
    }
}