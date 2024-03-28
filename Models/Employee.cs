using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace EmployeeAdministration.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }


        // here we will save the projects and the tasks the employee has been assigned too

        public List<Task> Tasks { get; } = new List<Task>();

        
        
    }
}
