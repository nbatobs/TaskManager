using API_project.Model.DTO;
using Microsoft.EntityFrameworkCore;

namespace API_project.Data;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
    {
        
    }
    public DbSet<DatabaseDTO> Tasks { get; set; }
}