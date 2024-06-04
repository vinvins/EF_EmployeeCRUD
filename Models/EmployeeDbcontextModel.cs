using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EmployeeCRUD_EF_cF.Models
{
    public class EmployeeDbcontextModel : DbContext
    {
        public DbSet<Employee> employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }

    }
}