using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3.DataSource
{
    public static class EmployeeData
    {
        public static List<IPerson> EmployeeList =
            new List<IPerson>
            {
                new Employee(026) { FirstName = "Thang", LastName = "Dinh The", Age = 25, Company = "FPT software", JobTitle = "Engineer", Income = 15_500_000M},
                new Employee(027) { FirstName = "Tuan", LastName = "Do Quang", Age = 28, Company = "VietDuc Hospital", JobTitle = "Doctor", Income = 26_340_000M },
                new Employee(030) { FirstName = "Dung", LastName = "Tran Thu", Age = 30, Company = "The Sunshine", JobTitle = "Artist", Income = 8_500_000M },
                new Employee(031) { FirstName = "Hai", LastName = "Nguyen Tien", Age = 33, Company = "VetJet Air", JobTitle = "Pilot", Income = 18_490_000M },
                new Employee(032) { FirstName = "Trung", LastName = "Bui Tien", Age = 40, Company = "HaiHoa", JobTitle = "Architect", Income = 22_500_000M }
            };
    }
}
