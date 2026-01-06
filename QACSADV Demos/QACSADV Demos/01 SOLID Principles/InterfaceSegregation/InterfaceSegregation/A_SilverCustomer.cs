using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregation
{
    public class A_SilverCustomer : A_OldCustomer
    {
        public A_SilverCustomer(ILogger logger) : base(logger)
        {

        }

        public override decimal GetDiscount(decimal TotalSales)
        {
            return TotalSales - (TotalSales * 5/100);
        }
    }
}
