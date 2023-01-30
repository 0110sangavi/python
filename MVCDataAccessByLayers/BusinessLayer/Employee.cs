using System.ComponentModel.DataAnnotations;
namespace BusinessLayer
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string EmployeeGender { get; set; }
        [Required]
        public string EmployeeDesignation { get; set; }
    }
}