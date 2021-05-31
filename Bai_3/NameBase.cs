using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    public class NameBase
    {
        public NameBase()
        {

        }
        public string LastNameBase { get; set; }
        public string FirstNameBase { get; set; }
        public string FullNameBase
        {
            get
            {
                string fullName = LastNameBase;
                if (!string.IsNullOrWhiteSpace(FirstNameBase))
                {
                    if (!string.IsNullOrWhiteSpace(LastNameBase))
                    {
                        fullName += " ";
                    }
                    fullName += FirstNameBase;
                }
                return fullName;
            }
        }

    }
}
