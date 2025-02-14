using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment001.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        [Range(22,60)]
        public int Age { get; set; }
        public int Dep_Id { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {FName} {LName}, Age: {Age}, Address: {Address}";
        }
    }
}
