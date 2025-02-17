using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFAssignment001.Migrations
{
    public partial class initial02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Students_Dep_Id",
                table: "Students",
                column: "Dep_Id");

            migrationBuilder.CreateIndex(
                name: "IX_StudCourses_Course_ID",
                table: "StudCourses",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors",
                column: "Dept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments",
                column: "Ins_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses",
                column: "Top_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseInstructors_Course_ID",
                table: "CourseInstructors",
                column: "Course_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructors_Courses_Course_ID",
                table: "CourseInstructors",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructors_Instructors_Inst_ID",
                table: "CourseInstructors",
                column: "Inst_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                table: "Courses",
                column: "Top_ID",
                principalTable: "Topics",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors",
                column: "Dept_ID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourses_Courses_Course_ID",
                table: "StudCourses",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourses_Students_Stud_ID",
                table: "StudCourses",
                column: "Stud_ID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dep_Id",
                table: "Students",
                column: "Dep_Id",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructors_Courses_Course_ID",
                table: "CourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructors_Instructors_Inst_ID",
                table: "CourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourses_Courses_Course_ID",
                table: "StudCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourses_Students_Stud_ID",
                table: "StudCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dep_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dep_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_StudCourses_Course_ID",
                table: "StudCourses");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_CourseInstructors_Course_ID",
                table: "CourseInstructors");
        }
    }
}
