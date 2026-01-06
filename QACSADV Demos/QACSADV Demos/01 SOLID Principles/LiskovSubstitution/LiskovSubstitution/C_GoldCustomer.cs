using System;
using System.Collections.Generic;
using System.Linq;
using System;

namespace LiskovSubstitution
{
    public class C_GoldCustomer : C_BestCustomer
    {
        public C_GoldCustomer(ILogger logger) : base(logger)
        {

        }

        public override decimal GetDiscountedPrice(decimal price)
        {
            return price - (price * 10 / 100);
        }

    }
}

