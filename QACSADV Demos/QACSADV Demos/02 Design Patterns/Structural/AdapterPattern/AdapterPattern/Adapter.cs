using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // The 'Adapter' class implements the ITarget interface and wraps an instance of the Adaptee class.
    // This way it translates calls to the ITarget interface into calls to the Adaptee's interface.

    public class Adapter: ITarget
    {
        private Adaptee _adaptee;

        public Adapter(Adaptee adaptee) => _adaptee = adaptee;

        // Possibly doing some other work and then adapting
        // the Adaptee's SpecificRequest to the Target's Request.
        public void Request() => _adaptee.SpecificRequest();

    }
}
