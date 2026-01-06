using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    /// <summary>
    /// The Customer class
    /// Let’s say our system wants to calculate discounts for Enquiries. Now, Enquiries are not 
    /// actual customer’s they are just leads. Because they are just leads we do not want to 
    /// save them to the database for now. So we create a new class called Enquiry which 
    /// inherits from the "(Bad)Customer" class. We provide some discounts to the enquiry so 
    /// that they can be converted to actual customers and we override the "Add" method 
    /// with an exception so that no one can add an Enquiry to the database.
    /// </summary>
    public abstract class A_BadCustomer
    {
        public abstract decimal GetDiscountedPrice(decimal price);
        public abstract void AddSaleToDatabase(string product, decimal totalSales);

    }

}
