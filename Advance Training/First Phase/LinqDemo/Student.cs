using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinqDemo
{
    internal class Student
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public int DepartmentID { get; set; }
        public int Semester { get; set; }

        public double MathMarks { get; set; }
        public double ScienceMarks { get; set; }
    }
}