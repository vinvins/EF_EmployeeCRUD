namespace EmployeeCRUD_EF_cF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UseSP : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.Employee_Insert",
                p => new
                    {
                        Name = p.String(maxLength: 10, unicode: false),
                        Age = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Employees]([Name], [Age])
                      VALUES (@Name, @Age)
                      
                      DECLARE @ID int
                      SELECT @ID = [ID]
                      FROM [dbo].[Employees]
                      WHERE @@ROWCOUNT > 0 AND [ID] = scope_identity()
                      
                      SELECT t0.[ID]
                      FROM [dbo].[Employees] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[ID] = @ID"
            );
            
            CreateStoredProcedure(
                "dbo.Employee_Update",
                p => new
                    {
                        ID = p.Int(),
                        Name = p.String(maxLength: 10, unicode: false),
                        Age = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Employees]
                      SET [Name] = @Name, [Age] = @Age
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "dbo.Employee_Delete",
                p => new
                    {
                        ID = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Employees]
                      WHERE ([ID] = @ID)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Employee_Delete");
            DropStoredProcedure("dbo.Employee_Update");
            DropStoredProcedure("dbo.Employee_Insert");
        }
    }
}
