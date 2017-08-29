namespace CodeToDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddURL1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Departments", name: "Name", newName: "DeptName");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Departments", name: "DeptName", newName: "Name");
        }
    }
}
