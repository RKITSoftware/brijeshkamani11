using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing Lists or Operations
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<Student> studentList = new List<Student>
            {
                new Student { ID = 1, DepartmentID = 1,  MathMarks = 100, Name = "Student1", ScienceMarks = 100, Semester = 2 },
                new Student { ID = 2, DepartmentID = 2, MathMarks = 35, Name = "Student2", ScienceMarks = 30, Semester = 2 }
            };
            List<Department> departmentList = new List<Department>
            {
                new Department{ DepartmentID = 1, Name= "Department1"},
                new Department{ DepartmentID = 2, Name= "Department2"}
            };

            // finding Greater than five from List Using Query Syntax
            printInt(from x in list where x > 5 select x); // 6, 7, 8, 9, 10

            // Using Method
            printInt(list.FindAll(x => x > 5)); // 6, 7, 8, 9, 10

            // Find First or Default
            Console.WriteLine(list.FirstOrDefault(x => x > 5)); // 6

            // Checking Is All Elements are grater-than 5?
            Console.WriteLine("Are all GraterThan 5? " + list.All(x => x > 5)); // False

            // Checking Is any Elements is grater-than 5?
            Console.WriteLine("Is any element GraterThan 5? " + list.Any(x => x > 5)); // True

            // Count All Greater than 5 values using Query
            Console.WriteLine((from x in list where x > 5 select x).Count()); // 5

            // Count All Greater than 5 values using Method
            Console.WriteLine(list.Count(x => x > 5)); // 5

            // Find Max from Greater than 5 values using Query
            Console.WriteLine((from x in list where x > 5 select x).Max()); // 10

            // Find Max from Greater than 5 values using Method
            Console.WriteLine(list.FindAll(x => x > 5).Max()); // 10

            // Orderby Using Query
            printStudent(from student in studentList
                         orderby student.Name
                         select student);
            // Output:
            // StundetName: Student1
            // StundetName: Student2

            // Orderby Using Method
            printStudent(studentList.OrderBy(student => student.Name));
            // Output:
            // StundetName: Student1
            // StundetName: Student2

            // Groupby using Query
            foreach (var NameGroup in from s in studentList
                                     group s by s.Name)
            {
                Console.WriteLine(NameGroup.Key+": " + NameGroup.Count());
            }
            // Output:
            // Student1: 1
            // Student2: 1

            // Groupby using Method
            foreach (var NameGroup in studentList.GroupBy(student => student.Name))
            {
                Console.WriteLine(NameGroup.Key + ": " + NameGroup.Count());
            }
            // Output:
            // Student1: 1
            // Student2: 1

            // innerjoin using Query
            var innerJoin = from student in studentList
            join department in departmentList
            on student.DepartmentID equals department.DepartmentID
            select new
            {
                StudentID = student.ID,
                StudentName = student.Name,
                DepartmentID = student.DepartmentID,
                DepartmentName = department.Name
            };
            foreach (var row in innerJoin)
            {
                Console.WriteLine(row.StudentName + ": " + row.DepartmentName);
            }
            // Output: 
            // Student1: Department1
            // Student2: Department2

            // innerjoin using Method
            innerJoin = studentList.Join(
                      departmentList,   
                      student => student.ID,
                      department => department.DepartmentID,
                      (student, department) => new
                      {
                          StudentID = student.ID,
                          StudentName = student.Name,
                          DepartmentID = student.DepartmentID,
                          DepartmentName = department.Name
                      });
            foreach(var row in innerJoin)
            {
                Console.WriteLine(row.StudentName + ": " + row.DepartmentName);
            }
            // Output: 
            // Student1: Department1
            // Student2: Department2

            // Purfroming Linq with Datatable

            LinqWithDatatable objLinqWithDatatable = new LinqWithDatatable();
            objLinqWithDatatable.purformDemo();

        }

        #region Private Methods

        /// <summary>
        /// For Printing List of int Values
        /// </summary>
        /// <param name="list"> Contains values of int </param>
        private static void printInt(IEnumerable<Int32> list)
        {
            Console.WriteLine(string.Join(", ", list));
        }

        /// <summary>
        /// For Printing Name of List of Student
        /// </summary>
        /// <param name="StudentList"></param>
        private static void printStudent(IEnumerable<Student> StudentList)
        {
            foreach (Student student in StudentList)
            {
                Console.WriteLine("StundetName: " + student.Name);
            }
        }

        #endregion
    }
}
