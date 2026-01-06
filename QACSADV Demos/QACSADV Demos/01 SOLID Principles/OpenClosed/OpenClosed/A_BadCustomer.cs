using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    /// <summary>
    ///The CustType property is used to determine if the Customer is "Gold or "Silver".
    ///The GetDiscount method uses the CustType property to determine what the 
    ///discount for a customer will be.
    ///The problem with the following code is what happens if the business requirement
    ///changes and a new type of customer is introduced: "Bronze".
    ///The simple and most obvious solution would be to extend the "if-else" condition to 
    ///include another "If else". But if further new conditions were required in the
    ///future we would be constantly modifying the code and having to retest all of
    ///the previous functionality to ensure it's not been affected by the modification.
    ///
    /// </summary>
    public class A_BadCustomer
    {
        private CustomerType customerType;

        public CustomerType CustomerType
        {
            get { return customerType; }
            set { customerType = value; }
        }

        public decimal GetDiscountedPrice(decimal TotalSales)
        {
            if (customerType == CustomerType.Gold)
            {
                return TotalSales - 10 * TotalSales / 100;
            }
            else
            {
                return TotalSales - 5 * TotalSales / 100;
            }
        }
    }
}
