using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }

        public string Class { get; set; }

        public int Age { get; set; }
        public string Address{ get; set; }

        public int? DeptId { get; set; }
        [ForeignKey("DeptId")]
        public virtual Department Departments { get; set; }

    }
}