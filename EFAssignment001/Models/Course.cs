﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment001.Models
{
    public class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }
        public Topic Topic { get; set; }

        public ICollection<Stud_Course> StudCourses { get; set; } = new HashSet<Stud_Course>();
        public ICollection<Course_Inst> CourseInstructors { get; set; } = new HashSet<Course_Inst>();

    }
}
