using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregation
{




    /// <summary>
    /// So LISKOV principle says the parent should easily replace the child object. 
    /// So to implement LISKOV we need to create two interfaces one is for discount 
    /// and other for database.
    /// The “B_Enquiry” class will only implement “IDiscount” as it not interested in 
    /// the “Add” method.
    /// </summary>
    public class A_Enquiry : IDiscount
    {
        ILogger logger;

        public A_Enquiry(ILogger logger)
        {
            this.logger = logger;
        }

        decimal IDiscount.GetDiscount(decimal TotalSales)
        {
            //2% discount for enquiries
            return TotalSales - (TotalSales * 2/100);
        }
    }
}
