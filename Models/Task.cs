using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EmployeeAdministration.Models
{
    public class Task
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        [JsonIgnore]
        public Employee? Employee { get; set; } = null!;
    
    }
}
