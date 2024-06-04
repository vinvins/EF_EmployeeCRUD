namespace EmployeeCRUD_EF_cF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeCRUD_EF_cF.Models.EmployeeDbcontextModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EmployeeCRUD_EF_cF.Models.EmployeeDbcontextModel";
        }

        protected override void Seed(EmployeeCRUD_EF_cF.Models.EmployeeDbcontextModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
