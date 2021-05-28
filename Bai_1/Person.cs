using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    public class Person
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

    }
}
