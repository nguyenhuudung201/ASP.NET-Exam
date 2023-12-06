using ASP.NET_Exam.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_Exam.Entities
{
    [Table("Departments")]
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Location { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
