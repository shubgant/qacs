using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregation
{
    public class A_GoldCustomer : A_OldCustomer
    {
        public A_GoldCustomer(ILogger logger) : base(logger)
        {

        }

        public override decimal GetDiscount(decimal TotalSales)
        {
            return TotalSales - (TotalSales * 10 / 100);
        }
    }
}
