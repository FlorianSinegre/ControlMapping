namespace TPCodeFirst.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Course : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Credits = c.Int(nullable: false),
                        Departement_DepartementID = c.Int(),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Departements", t => t.Departement_DepartementID)
                .Index(t => t.Departement_DepartementID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PeronID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 50),
                        FirstName = c.Int(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                        EnrollementID = c.DateTime(nullable: false),
                        StudentGrade_EnrollementID = c.Int(),
                    })
                .PrimaryKey(t => t.PeronID)
                .ForeignKey("dbo.StudentGrades", t => t.StudentGrade_EnrollementID)
                .Index(t => t.StudentGrade_EnrollementID);
            
            CreateTable(
                "dbo.StudentGrades",
                c => new
                    {
                        EnrollementID = c.Int(nullable: false, identity: true),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnrollementID);
            
            CreateTable(
                "dbo.Departements",
                c => new
                    {
                        DepartementID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        StartDate = c.DateTime(nullable: false),
                        Budget = c.Single(nullable: false),
                        Credits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DepartementID);
            
            CreateTable(
                "dbo.PersonCourses",
                c => new
                    {
                        Person_PeronID = c.Int(nullable: false),
                        Course_CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Person_PeronID, t.Course_CourseId })
                .ForeignKey("dbo.People", t => t.Person_PeronID, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId, cascadeDelete: true)
                .Index(t => t.Person_PeronID)
                .Index(t => t.Course_CourseId);
            
            CreateTable(
                "dbo.StudentGradeCourses",
                c => new
                    {
                        StudentGrade_EnrollementID = c.Int(nullable: false),
                        Course_CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentGrade_EnrollementID, t.Course_CourseId })
                .ForeignKey("dbo.StudentGrades", t => t.StudentGrade_EnrollementID, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId, cascadeDelete: true)
                .Index(t => t.StudentGrade_EnrollementID)
                .Index(t => t.Course_CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Departement_DepartementID", "dbo.Departements");
            DropForeignKey("dbo.People", "StudentGrade_EnrollementID", "dbo.StudentGrades");
            DropForeignKey("dbo.StudentGradeCourses", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.StudentGradeCourses", "StudentGrade_EnrollementID", "dbo.StudentGrades");
            DropForeignKey("dbo.PersonCourses", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.PersonCourses", "Person_PeronID", "dbo.People");
            DropIndex("dbo.StudentGradeCourses", new[] { "Course_CourseId" });
            DropIndex("dbo.StudentGradeCourses", new[] { "StudentGrade_EnrollementID" });
            DropIndex("dbo.PersonCourses", new[] { "Course_CourseId" });
            DropIndex("dbo.PersonCourses", new[] { "Person_PeronID" });
            DropIndex("dbo.People", new[] { "StudentGrade_EnrollementID" });
            DropIndex("dbo.Courses", new[] { "Departement_DepartementID" });
            DropTable("dbo.StudentGradeCourses");
            DropTable("dbo.PersonCourses");
            DropTable("dbo.Departements");
            DropTable("dbo.StudentGrades");
            DropTable("dbo.People");
            DropTable("dbo.Courses");
        }
    }
}
