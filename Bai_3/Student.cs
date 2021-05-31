using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    public class Student : IPerson, IEquatable<Student>
    {
        public Student(): this(0)
        {

        }
        public Student(int id)
        {
            Id = id;
            StudentName = new NameBase();
        }

        public string ClassOfSchool { get; set; }
        public string School { get; set; }
        public int Id { get; set; }

        public NameBase StudentName { get; set; }
        public string FirstName { get => StudentName.FirstNameBase; set => StudentName.FirstNameBase = value; }
        public string LastName { get => StudentName.LastNameBase; set => StudentName.LastNameBase = value; }
        public string Name { get => StudentName.FullNameBase; }

        public int Age { get; set; }
        public double TaxCoe { get; set; }
        public decimal? Income { get; set; }

        public string GetInfo() =>
            $"_{Id}_{Name}_{Age}_{School}_{ClassOfSchool}_";

        public decimal? GetTax() => Income * Convert.ToDecimal(TaxCoe);
        public decimal? GetTax(decimal? income, double taxCoe)
        {
            Income = income;
            TaxCoe = taxCoe;
            return Income * Convert.ToDecimal(TaxCoe);
        }

        public override bool Equals(object obj) => Equals(obj as Student);
        public bool Equals(Student other) => other != null && Id == other.Id;
    }
}
