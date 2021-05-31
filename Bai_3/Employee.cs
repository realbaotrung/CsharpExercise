using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    public class Employee : IPerson, IEquatable<Employee>
    {
        public Employee(): this(0)
        {

        }
        public Employee(int id)
        {
            Id = id;
            EmployeeName = new NameBase();
        }

        public string Company { get; set; }
        public string JobTitle { get; set; }
        public int Id { get; set; }

        public NameBase EmployeeName { get; set; }
        public string FirstName { get => EmployeeName.FirstNameBase; set => EmployeeName.FirstNameBase = value; }
        public string LastName { get => EmployeeName.LastNameBase; set => EmployeeName.LastNameBase = value; }
        public string Name { get => EmployeeName.FullNameBase; }

        public int Age { get; set; }
        public double TaxCoe { get; set; }
        public decimal? Income { get; set; }
        public string GetInfo() =>
            $"_{Id}_{Name}_{Age}_{Company}_{JobTitle}_{Income:C0}_{GetTax():C0}_";
        public decimal? GetTax() => Income * Convert.ToDecimal(TaxCoe);
        public decimal? GetTax(decimal? income, double taxCoe)
        {
            Income = income;
            TaxCoe = taxCoe;
            return Income * Convert.ToDecimal(TaxCoe);
        }

        public override bool Equals(object obj) => Equals(obj as Employee);
        public bool Equals(Employee other) => other != null && Id == other.Id;
    }
}
