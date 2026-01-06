using SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityUnitTests
{
    class StubLogger : ILogger
    {
        public void Handle(string exceptionMesasage)
        {
            //Code that writes to log would go here;
        }
    }
}
