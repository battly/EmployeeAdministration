using Microsoft.EntityFrameworkCore;

namespace EmployeeAdministration.Models
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
            : base(options)
        {

        }

        public EmployeeDBContext() : base() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { FirstName = "Lindi", LastName = "Harizaj" },
                new Employee { FirstName = "Almi", LastName = "Harizaj" },
                new Employee { FirstName = "Alesio", LastName = "Kucana"}
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}