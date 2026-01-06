using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregation
{
    public class B_PlatinumCustomer : B_NewerCustomer
    { 

        public B_PlatinumCustomer(ILogger logger)
            : base(logger)
        {

        }

        public override decimal GetDiscount(decimal TotalSales)
        {
            return TotalSales - (TotalSales * 15/100);
        }

        public override int RetrieveLoyaltyPoints()
        {
            return (int)(base.RetrieveLoyaltyPoints() * 1.15m);
        }

    }
}
