using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    /* Interface-based polymorphism
    */
    public class LoggingService
    {
        /* Able to access items through the interface. We don't need to know how the Log() is implemented,
         * but the interface promises that the Log() would return a string that can be written
         */
        public static void WriteToFile(List<ILoggable> changedItems)
        {
            foreach (var item in changedItems)
            {
                // TODO
                Console.WriteLine(item.Log());
            }
        }
    }
}
