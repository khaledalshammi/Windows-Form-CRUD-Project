namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DeptID = c.Int(nullable: false, identity: true),
                        DeptName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.DeptID);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        BirthDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProfiles", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.UserProfiles", new[] { "DepartmentID" });
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Departments");
        }
    }
}
