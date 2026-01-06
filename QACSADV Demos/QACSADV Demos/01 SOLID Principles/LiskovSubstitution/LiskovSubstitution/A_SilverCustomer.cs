using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitution
{
    public class A_SilverCustomer : A_BadCustomer
    {
        ILogger logger;

        public A_SilverCustomer(ILogger logger)
        {
            this.logger = logger;
        }

        public override decimal GetDiscountedPrice(decimal price)
        {
            return price - (price * 5 / 100);
        }

        public override void AddSaleToDatabase(string product, decimal totalSales)
        {
            try
            {
                // Database code goes here
            }
            catch (Exception exn)
            {
                logger.Handle(exn.Message);
            }
        }
    }
}
