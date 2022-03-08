using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public string Name { get; set; }
    }
}
