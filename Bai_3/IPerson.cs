using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    public interface IPerson
    {
        int Id { get; set; }

        string Name { get; set; }

        int Age { get; set; }

        decimal? Income { get; set; }

        double TaxCoe { get; set; }

        decimal? GetTax();

        decimal? GetTax(decimal? income, double taxCoe);

        string GetInfo();
    }
}
