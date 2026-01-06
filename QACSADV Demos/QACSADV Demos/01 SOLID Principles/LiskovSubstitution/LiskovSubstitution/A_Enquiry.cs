using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitution
{
    public class A_Enquiry : A_BadCustomer
    {
        ILogger logger;

        public A_Enquiry(ILogger logger)
        {
            this.logger = logger;
        }

        public override decimal GetDiscountedPrice(decimal price)
        {
            //2% discount for enquiries
            return price - (price * 2/100);
        }

        public override void AddSaleToDatabase(string product, decimal totalSales)
        {
            throw new Exception("Not Allowed!");
        }
    }
}
