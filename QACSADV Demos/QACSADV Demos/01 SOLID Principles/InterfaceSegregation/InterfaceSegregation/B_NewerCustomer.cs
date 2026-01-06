using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    // So LISKOV principle says the parent should easily replace the child object. 
    // So to implement LISKOV we need to create two interfaces one is for discount 
    // and other for database.
    // the "B_GoodCustomer" and its children class will implement both "IDiscount" as well as "IDatabase" 
    // as it also wants to persist the customer to the database.
    public abstract class B_NewerCustomer:ISaleV2, IDiscount
    {
        protected ILogger logger;

        //Different kinds of logger (File, Event, Database...) can now be injected 
        public B_NewerCustomer(ILogger logger)
        {
            this.logger = logger;
        }

        public abstract decimal GetDiscount(decimal TotalSales);

        public virtual void AddSaleToDatabase(string product, decimal totalSales)
        {
            try
            {
                // Database code goes here
                logger.Handle($"product: {product} sold for {totalSales:C} and successfully logged to database");
            }
            catch (Exception exn)
            {
                logger.Handle(exn.Message);
            }
        }

        public virtual int RetrieveLoyaltyPoints()
        {
           // code to Read from the database goes here
            return 100;
        }

    }

}
