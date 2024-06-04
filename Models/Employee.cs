using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeCRUD_EF_cF.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}