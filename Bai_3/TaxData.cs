using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    public static class TaxData
    {
        public static double GetTaxCoe(IPerson p)
        {
            double taxCoe = 0;

            if (p.Age > 18)
            {
                if (p.Income <= 9_000_000M)
                    taxCoe = 0.05;
                if (p.Income > 9_000_000M && p.Income <= 15_000_000M)
                    taxCoe = 0.1;
                if (p.Income > 15_000_000M && p.Income <= 20_000_000M)
                    taxCoe = 0.15;
                if (p.Income > 20_000_000M && p.Income <= 30_000_000M)
                    taxCoe = 0.2;
            }

            return taxCoe;
        }
    }
}
