namespace Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseAndCourseStatusData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values ('ASP.Net core', 'ASP.NET Core For Beginners','George W', 8)");
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values ('SQL Server', 'SQL For Beginners','Bill C', 9)");
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values ('Python', 'Python Fundamentals','Teddy Rose', 8)");
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values ('Windows 95', 'AutoCad Basics','John D', 10)");

            Sql("Insert into CourseStatus(Status) Values('In Progress')");
            Sql("Insert into CourseStatus(Status) Values('Completed')");
        }
        
        public override void Down()
        {
        }
    }
}
