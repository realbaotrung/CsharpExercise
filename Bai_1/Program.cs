using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Program
    {
        public static List<Person> Init()
        {
            var people = new List<Person>
            {
                new Person(001) { FirstName = "Trung", LastName = "Nguyen Bao", PersonAge = 29, PersonIncome = 3_500_000M, TaxCoe = 0.05 },
                new Person(002) { FirstName = "Ha", LastName = "Nguyen Thu", PersonAge = 32, PersonIncome = 21_000_000, TaxCoe = 0.2 },
                new Person(003) { FirstName = "Lam", LastName = "Tran Dinh", PersonAge = 36, PersonIncome = 19_000_000, TaxCoe = 0.2 },
                new Person(004) { FirstName = "Quang", LastName = "Nguyen Minh", PersonAge = 25, PersonIncome = 8_350_000, TaxCoe = 0.1 },
                new Person(005) { FirstName = "Khanh", LastName = "Le Bao", PersonAge = 22, PersonIncome = 4_400_000, TaxCoe = 0.05 }
            };
            return people;
        }

    }
}
