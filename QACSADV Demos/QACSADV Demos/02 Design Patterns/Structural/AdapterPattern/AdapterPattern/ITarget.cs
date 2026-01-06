using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // The 'ITarget' interface defines the domain-specific interface used by the Client code.

    public interface ITarget
    {
        void Request();
    }
}
