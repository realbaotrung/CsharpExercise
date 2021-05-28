using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    public class Person : IEquatable<Person>
    {
        public Person() { }

        public Person(int personId)
        {
            PersonId = personId;
        }

        public int PersonId { get; private set; }

        public string FirstName { get; set; }
        private string _lastName;

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += " ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public int PersonAge { get; set; }

        public decimal? PersonIncome { get; set; }

        public double TaxCoe { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   PersonId == other.PersonId;
        }

        public decimal? GetTax(decimal? personIncome, double taxCoe)
        {
            PersonIncome = personIncome;
            TaxCoe = taxCoe;

            var personalIncomeTax = PersonIncome * Convert.ToDecimal(TaxCoe);

            return personalIncomeTax;
        }
    }
}
