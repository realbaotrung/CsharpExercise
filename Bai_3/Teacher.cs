using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    public class Teacher : IPerson, IEquatable<Teacher>
    {
        public Teacher(): this(0)
        {

        }
        public Teacher(int id)
        {
            Id = id;
            TeacherName = new NameBase();
        }

        public string School { get; set; }
        public int Id { get; set; }

        public NameBase TeacherName { get; set; }
        public string FirstName { get => TeacherName.FirstNameBase; set => TeacherName.FirstNameBase = value; }
        public string LastName { get => TeacherName.LastNameBase; set => TeacherName.LastNameBase = value; }
        public string Name { get => TeacherName.FullNameBase; }

        public int Age { get; set; }
        public double TaxCoe { get; set; }
        public decimal? Income { get; set; }
        public string GetInfo() =>
            $"_{Id}_{Name}_{Age}_{School}_{Income:C0}_{GetTax():C0}_";
        public decimal? GetTax() => Income * Convert.ToDecimal(TaxCoe);
        public decimal? GetTax(decimal? income, double taxCoe)
        {
            Income = income;
            TaxCoe = taxCoe;
            return Income * Convert.ToDecimal(TaxCoe);
        }

        public override bool Equals(object obj) => Equals(obj as Teacher);
        public bool Equals(Teacher other) => other != null && Id == other.Id;
    }
}
