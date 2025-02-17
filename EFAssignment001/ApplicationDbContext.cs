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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.Inst_ID, ci.Course_ID });

            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.Stud_ID, sc.Course_ID });

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.Dep_Id);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Topic)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.Top_ID);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithMany(i => i.ManagedDepartments)
                .HasForeignKey(d => d.Ins_ID);

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.Dept_ID);

            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudCourses)
                .HasForeignKey(sc => sc.Stud_ID);

            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudCourses)
                .HasForeignKey(sc => sc.Course_ID);

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.CourseInstructors)
                .HasForeignKey(ci => ci.Inst_ID);

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.CourseInstructors)
                .HasForeignKey(ci => ci.Course_ID);
        }
    }
}
