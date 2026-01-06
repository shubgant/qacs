using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitution
{
    /// <summary>
    /// So LISKOV principle says the parent should easily replace the child object. 
    /// So to implement LISKOV we need to create two interfaces one is for discount 
    /// and other for database.
    /// The “B_Enquiry” class will only implement “IDiscount” as it not interested in 
    /// the “AddSaleToDatabase” method.
    /// </summary>
    public class B_Enquiry : IDiscount
    {
        ILogger logger;

        public B_Enquiry(ILogger logger)
        {
            this.logger = logger;
        }

        decimal IDiscount.GetDiscountedPrice(decimal price)
        {
            //2% discount for enquiries
            return price - (price * 2 / 100);
        }
    }
}
