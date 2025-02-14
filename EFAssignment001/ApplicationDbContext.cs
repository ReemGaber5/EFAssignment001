using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using EFAssignment001.Models;
using Microsoft.EntityFrameworkCore;


namespace EFAssignment001
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITI;User Id=sa;password=0100;Integrated Security=false;");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> StudCourses { get; set; }
        public DbSet<Course_Inst> CourseInstructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Course_Inst>().HasKey(ci => new { ci.Inst_ID, ci.Course_ID });
            builder.Entity<Stud_Course>().HasKey(sc => new { sc.Stud_ID, sc.Course_ID });


        }
    }
}
