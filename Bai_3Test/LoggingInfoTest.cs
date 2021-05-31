using Bai_3;
using Bai_3.DataSource;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Bai_3Test
{
    [TestClass]
    public class LoggingInfoTest
    {
        [TestMethod]
        public void WriteToConsoleWithInitialData()
        {
            //-- Arrange
            var changedItems = new List<IPerson>();

            var student = new Student(001)
            {
                FirstName = "Nguyen Bao",
                LastName = "Trung",
                Age = 17,
                School = "Phan Dinh Phung",
                ClassOfSchool = "11B1"
            };
            changedItems.Add(student);

            var teacher = new Teacher(013)
            {
                FirstName = "Lien",
                LastName = "Dinh The",
                Age = 25,
                School = "Phan Dinh Phung",
                Income = 5_000_000M,
            };
            teacher.TaxCoe = TaxData.GetTaxCoe(teacher);
            changedItems.Add(teacher);

            var employee = new Employee(027)
            {
                FirstName = "Tuan",
                LastName = "Do Quang",
                Age = 28,
                Company = "VietDuc Hospital",
                JobTitle = "Doctor",
                Income = 26_340_000M
            };
            employee.TaxCoe = TaxData.GetTaxCoe(employee);
            changedItems.Add(employee);

            //-- Act
            LoggingInfo.WriteToConsole(changedItems);

            //-- Assert
            // Nothing to assert
        }

        [TestMethod]
        public void WriteToConsoleWithDataFromSource()
        {
            //-- Arrange

            var studentList = StudenData.StudentList;

            var teacherList = TeacherData.TeacherList;
            foreach (var t in teacherList)
            {
                t.TaxCoe = TaxData.GetTaxCoe(t);
            }

            var employeeList = EmployeeData.EmployeeList;
            foreach (var e in employeeList)
            {
                e.TaxCoe = TaxData.GetTaxCoe(e);
            }

            //-- Act
            Console.WriteLine($"Number of Students: {studentList.Count}");
            LoggingInfo.WriteToConsole(studentList);

            Console.WriteLine($"Number of Teachers: {teacherList.Count}");
            LoggingInfo.WriteToConsole(teacherList);

            Console.WriteLine($"Number of Employees: {employeeList.Count}");
            LoggingInfo.WriteToConsole(employeeList);

            //-- Assert
            // Nothing to assert
        }
    }
}
