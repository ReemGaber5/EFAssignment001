using EFAssignment001.Models;

namespace EFAssignment001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext applicationDbContext = new ApplicationDbContext();

            using (var context = new ApplicationDbContext())
            {
                #region Add 

                ////add new student
                //var std = new Student
                //{
                //    FName = "Ahmed",
                //    LName = "Ali",
                //    Address = "Maadi",
                //    Age = 24,
                //    Dep_Id = 1
                //};
                //context.Students.Add(std);
                //context.SaveChanges();


                ////Add new Course 
                //var course = new Course
                //{
                //    Name = ".NET",
                //    Duration = 40,
                //    Description = "EntityFrameWork",
                //    Top_ID = 1
                //};
                //context.Courses.Add(course);
                //context.SaveChanges();

                ////Add New Dept
                //var department = new Department
                //{
                //    Name = "Computer Science",
                //    Ins_ID = 1,
                //    HiringDate = DateTime.Now
                //};
                //context.Departments.Add(department);
                //context.SaveChanges();


                ////Add New Instructor
                //var instructor = new Instructor
                //{
                //    Name = "Alaa",
                //    Salary = 50000,
                //    Address = "Helwan",
                //    HourRate = 25,
                //    Bouns = 1000,
                //    Dept_ID = 1
                //};
                //context.Instructors.Add(instructor);
                //context.SaveChanges();

                #endregion

                #region Retrieve students 
                ////get all students
                //var allstudents = context.Students.ToList();
                //foreach (var student in allstudents)
                //{
                //    Console.WriteLine(student);
                //}

                //get student by id 
                var Student = context.Students.Find(1);
                Console.WriteLine(Student);


                //update student 

                var newStudent = context.Students.Find(1);
                if (newStudent != null)
                {
                    newStudent.FName = "Updated";
                    newStudent.Age = 30;
                    context.SaveChanges();
                }


                #endregion


            }

        }
    }
}
