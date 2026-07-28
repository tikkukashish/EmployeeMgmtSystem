using System.ComponentModel.DataAnnotations;

namespace EmployeeMgmtSystem.Models
{
    public class Employee
    {
        [Key]
        [Required]
        [Display(Name ="Employee ID")]
        public int EmpId { get; set; }
        [Display(Name ="Employee Name")]
        [Required]
        [StringLength(50)]
        public string EmpName { get; set; }
        [Display(Name ="Mobile no.")]
        [Required]
        public long mobile { get; set; }

    }
}
