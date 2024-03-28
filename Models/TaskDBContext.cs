using Microsoft.EntityFrameworkCore;

namespace EmployeeAdministration.Models
{
    public class TaskDBContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public TaskDBContext() : base()  { }

        public TaskDBContext(DbContextOptions<TaskDBContext> options) : base(options) { }
    }
}
