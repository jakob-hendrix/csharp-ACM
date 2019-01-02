using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public interface ILoggable
    {
        /* No implementation. Just provides a list of members. Only define signatures. Once defined, this can be implemented
         * in any class that wants to take on the loggable role.
         */
        string Log();
    }
}
