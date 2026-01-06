using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregation
{
    public interface ISaleV2 : ISale
    {
        //Old classes can continue to implement ISale whilst new classes
        //can implement ISaleV2
        int RetrieveLoyaltyPoints();
    }
}
