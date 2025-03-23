using System.ComponentModel.DataAnnotations;

namespace Curdoperationwithangular.Models
{
    public class Employee
    {
        [Key]
        public int Empid {  get; set; }
        public string? Empname {  get; set; }
        public decimal Empsalary { get;set; }
        public string? Empemail { get; set; }
        public string? Empmobile {  get; set; }
    }
}
