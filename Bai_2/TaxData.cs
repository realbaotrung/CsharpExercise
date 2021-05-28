using Bai_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    public static class TaxData
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
