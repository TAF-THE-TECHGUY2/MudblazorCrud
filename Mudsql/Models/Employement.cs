using System.ComponentModel.DataAnnotations;  // Ensure you have this using directive

namespace Mudsql.Models
{
    public class Employment
    {
        [Key] 
        public int EmployeeID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
