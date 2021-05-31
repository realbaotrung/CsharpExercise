using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3.DataSource
{
    public static class StudenData
    {
        public static List<IPerson> StudentList =
            new List<IPerson>
            {
                new Student(001) { FirstName = "Trung", LastName = "Tran The", Age = 16, School = "Phan Dinh Phung", ClassOfSchool = "10A1" },
                new Student(002) { FirstName = "Ha", LastName = "Do Thu", Age = 17, School = "Phan Dinh Phung", ClassOfSchool = "11A2" },
                new Student(003) { FirstName = "Lam", LastName = "Mai The", Age = 17, School = "Nguyen Trai", ClassOfSchool = "11D1" },
                new Student(004) { FirstName = "Quang", LastName = "Nguyen Van", Age = 18, School = "Nguyen Trai", ClassOfSchool = "12A4" },
                new Student(005) { FirstName = "Khanh", LastName = "Tran Bao", Age = 18, School = "Ha noi Ams", ClassOfSchool = "12A1" }
            };
    }
}
