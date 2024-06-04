namespace EmployeeCRUD_EF_cF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelUpdated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Name", c => c.Int(nullable: false));
        }
    }
}
