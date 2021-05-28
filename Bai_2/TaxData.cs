using Bai_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    public static partial class TaxData
    {
        public static List<Person> PersonList { get; } =
            new List<Person>
            {
                new Person(001) { FirstName = "Trung", LastName = "Nguyen Bao", PersonAge = 16, PersonIncome = 2_600_000M },
                new Person(002) { FirstName = "Ha", LastName = "Nguyen Thu", PersonAge = 22, PersonIncome = 7_600_000M },
                new Person(003) { FirstName = "Lam", LastName = "Tran Dinh", PersonAge = 28, PersonIncome = 12_350_000M },
                new Person(004) { FirstName = "Quang", LastName = "Nguyen Minh", PersonAge = 31, PersonIncome = 17_500_000M },
                new Person(005) { FirstName = "Khanh", LastName = "Le Bao", PersonAge = 27, PersonIncome = 22_760_000M }
            };

    }

    public static partial class TaxData
    {
        public static double GetTaxCoe(Person p)
        {
            double taxCoe = 0;

            if (p.PersonAge > 18)
            {
                if (p.PersonIncome <= 9_000_000M)
                    taxCoe = 0.05;
                if (p.PersonIncome > 9_000_000M && p.PersonIncome <= 15_000_000M)
                    taxCoe = 0.1;
                if (p.PersonIncome > 15_000_000M && p.PersonIncome <= 20_000_000M)
                    taxCoe = 0.15;
                if (p.PersonIncome > 20_000_000M && p.PersonIncome <= 30_000_000M)
                    taxCoe = 0.2;
            }

            return taxCoe;
        }

    }

}
