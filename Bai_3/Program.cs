using Bai_3.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class Program
    {
        static void Main()
        {
            // Print out the number of students with each student information
            var studentList = StudenData.StudentList.ToList();
            Console.WriteLine($"Number of Students: {studentList.Count}");
            LoggingInfo.WriteToConsole(studentList);

            // Print out the number of teachers with each teacher information
            var teacherList = TeacherData.TeacherList.ToList();
            foreach (var t in teacherList)
            {
                t.TaxCoe = TaxData.GetTaxCoe(t);
            }
            Console.WriteLine($"Number of Teachers: {teacherList.Count}");
            LoggingInfo.WriteToConsole(teacherList);

            // Print out the number of employees with each employee information
            var employeeList = EmployeeData.EmployeeList.ToList();
            foreach (var e in employeeList)
            {
                e.TaxCoe = TaxData.GetTaxCoe(e);
            }
            Console.WriteLine($"Number of Employees: {employeeList.Count}");
            LoggingInfo.WriteToConsole(employeeList);

        }
    }
}
