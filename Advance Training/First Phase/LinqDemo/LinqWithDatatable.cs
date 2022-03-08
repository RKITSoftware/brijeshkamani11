using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class LinqWithDatatable
    {
        #region Public Fields
        DataTable studentTable;
        DataTable departmentTable;
        #endregion Public Fields

        #region Constructor
        public LinqWithDatatable()
        {
            studentTable = new DataTable("Student");
            studentTable.Clear();
            studentTable.Columns.Add("ID", typeof (Int32));
            studentTable.Columns.Add("Name");
            studentTable.Columns.Add("DepartmentID", typeof(Int32));
            studentTable.Columns.Add("Semester", typeof(Int32));
            studentTable.Columns.Add("MathMarks", typeof(Int32));
            studentTable.Columns.Add("ScienceMarks", typeof(Int32));
            DataRow student = studentTable.NewRow();
            student["ID"] = 1;
            student["Name"] = "Student1";
            student["DepartmentID"] = 1;
            student["Semester"] = 1;
            student["MathMarks"] = 100;
            student["ScienceMarks"] = 100;
            studentTable.Rows.Add(student);
            student = studentTable.NewRow();
            student["ID"] = 2;
            student["Name"] = "Student2";
            student["DepartmentID"] = 2;
            student["Semester"] = 2;
            student["MathMarks"] = 30;
            student["ScienceMarks"] = 35;
            studentTable.Rows.Add(student);

            departmentTable = new DataTable("Department");
            departmentTable.Clear();
            departmentTable.Columns.Add("DepartmentID", typeof(Int32));
            departmentTable.Columns.Add("Name");
            DataRow department = departmentTable.NewRow();
            department["DepartmentID"] = 1;
            department["Name"] = "Department1";
            departmentTable.Rows.Add(department);
            department = departmentTable.NewRow();
            department["DepartmentID"] = 2;
            department["Name"] = "Department2";
            departmentTable.Rows.Add(department);

        }
        #endregion Constructor

        #region Public Methods
        public void purformDemo()
        {
            // performing FirstOrDeualt in DataTable
            Console.WriteLine(studentTable.AsEnumerable().FirstOrDefault(student => student.Field<int>("Semester") > 1).Field<string>("Name"));

            // performing All in DataTable
            Console.WriteLine("Are all Student Semester greater than 1? " + studentTable.AsEnumerable().All(student => student.Field<int>("Semester") > 1));

            // performing Any in DataTable
            Console.WriteLine("Is any Student Semester greater than 1? " + studentTable.AsEnumerable().Any(student => student.Field<int>("Semester") > 1));

            // performing OrderBy in DataTable
            printStudent(studentTable.AsEnumerable().OrderBy(student => student.Field<string>("Name")));
        }
        #endregion

        #region Private Method

        /// <summary>
        /// For Printing Name of List of Student
        /// </summary>
        /// <param name="StudentList"></param>
        private static void printStudent(IEnumerable<DataRow> StudentTable)
        {
            foreach (DataRow studentRow in StudentTable)
            {
                Console.WriteLine("StundetName: " + studentRow.Field<string>("Name"));
            }
        }

        #endregion Private Method
    }
}
