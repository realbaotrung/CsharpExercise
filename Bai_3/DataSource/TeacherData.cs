using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3.DataSource
{
    public static class TeacherData
    {
        public static List<IPerson> TeacherList =
            new List<IPerson>
            {
                new Teacher(013) { FirstName = "Lien", LastName = "Dinh The", Age = 25, School = "Phan Dinh Phung", Income = 5_000_000M},
                new Teacher(014) { FirstName = "Hai", LastName = "Do Quang", Age = 28, School = "Phan Dinh Phung", Income = 16_600_000M },
                new Teacher(015) { FirstName = "Minh", LastName = "Tran Thu", Age = 30, School = "Nguyen Trai", Income = 27_500_000M },
                new Teacher(016) { FirstName = "Tran", LastName = "Nguyen Tien", Age = 33, School = "Nguyen Trai", Income = 8_000_000M },
                new Teacher(017) { FirstName = "Dung", LastName = "Bui Tien", Age = 40, School = "Ha noi Ams", Income = 12_500_000M }
            };
    }
}
