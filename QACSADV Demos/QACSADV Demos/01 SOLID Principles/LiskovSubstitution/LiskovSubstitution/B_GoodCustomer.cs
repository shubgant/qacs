using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    /// <summary>
    /// So LISKOV principle says the parent should easily replace the child object. 
    /// So to implement LISKOV we need to create two interfaces one is for discount 
    /// and other for database.
    /// the “B_GoodCustomer” and its children class will implement both “IDiscount” as well as “IDatabase” 
    /// as it also wants to persist the customer to the database.
    /// </summary>
    public abstract class B_GoodCustomer: IDiscount, ISale
    {
        protected FileLogger logger;

        public B_GoodCustomer(FileLogger logger)
        {
            this.logger = logger;
        }
        public abstract decimal GetDiscountedPrice(decimal price);
        public virtual void AddSaleToDatabase(string product, decimal totalSales)
        {
            try
            {
                // Database code goes here
                //Write success message to Log
                logger.Handle($"product {product} sale of {totalSales:C} committed to database");
            }
            catch (Exception exn)
            {
                logger.Handle(exn.Message);
            }
        }
    }

}
