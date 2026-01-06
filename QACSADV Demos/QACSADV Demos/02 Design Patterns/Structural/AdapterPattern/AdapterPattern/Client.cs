using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Client
    {
        public void Main()
        {
            // Show how Adaptee's methods can be used via the Target interface.
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            target.Request();
        }
    }
}
