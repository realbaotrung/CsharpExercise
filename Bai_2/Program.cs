using Bai_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Program
    {
        public static List<Person> GetPersonList() => TaxData.PersonList;

        static void Main()
        {
            List<Person> people = GetPersonList();

            foreach (var person in people)
            {
                person.TaxCoe = TaxData.GetTaxCoe(person);
            }

            foreach (var person in people)
            {
                Console.WriteLine($"The Id: {person.PersonId} \t|\t Full Name: {person.FullName} \t|\t TaxCoe: {person.TaxCoe} \t|\t Tax: {person.GetTax():C0}");
            }
        }
    }
}
