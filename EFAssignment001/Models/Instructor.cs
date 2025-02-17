using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment001.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }
        public int Dept_ID { get; set; }
        public Department Department { get; set; }
        public ICollection<Department> ManagedDepartments { get; set; }= new HashSet<Department>();
        public ICollection<Course_Inst> CourseInstructors { get; set; } = new HashSet<Course_Inst>();
    }
}
