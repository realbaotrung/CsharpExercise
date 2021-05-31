using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    public static class LoggingInfo
    {
        public static void WriteToConsole(List<IPerson> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}
