using System;
using System.Collections.Generic;
using System.Linq;
using System;

namespace LiskovSubstitution
{
    public class C_SilverCustomer : C_BestCustomer
    {
        public C_SilverCustomer(ILogger logger) : base(logger)
        {

        }

        public override decimal GetDiscountedPrice(decimal price)
        {
            return price - (price * 5 / 100);
        }

    }
}