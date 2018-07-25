namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        TeacherId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentsCourses",
                c => new
                    {
                        Students_Id = c.Int(nullable: false),
                        Courses_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Students_Id, t.Courses_id })
                .ForeignKey("dbo.Students", t => t.Students_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Courses_id, cascadeDelete: true)
                .Index(t => t.Students_Id)
                .Index(t => t.Courses_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.StudentsCourses", "Courses_id", "dbo.Courses");
            DropForeignKey("dbo.StudentsCourses", "Students_Id", "dbo.Students");
            DropIndex("dbo.StudentsCourses", new[] { "Courses_id" });
            DropIndex("dbo.StudentsCourses", new[] { "Students_Id" });
            DropIndex("dbo.Courses", new[] { "TeacherId" });
            DropTable("dbo.StudentsCourses");
            DropTable("dbo.Teachers");
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
        }
    }
}
