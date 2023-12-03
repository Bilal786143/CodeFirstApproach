using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int EmpId { get; set; }

        
        [ForeignKey("EmpId")]

        public virtual Employee Employees { get; set; }
            


    }
}