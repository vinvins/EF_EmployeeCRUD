namespace EmployeeCRUD_EF_cF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedNameDataType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String(maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String());
        }
    }
}
