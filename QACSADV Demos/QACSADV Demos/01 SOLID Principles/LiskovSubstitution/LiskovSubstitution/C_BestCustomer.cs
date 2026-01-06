using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public abstract class C_BestCustomer: IDiscount, ISale
    {
        private ILogger logger;

        //Different kinds of logger (File, Event, Database...) can now be injected 
        public C_BestCustomer(ILogger logger)
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
                //Mimic something bad happening
                //throw new Exception("A bad thing has happened.");
            }
            catch (Exception ex)
            {
                logger.Handle(ex.Message);
            }
        }

    }
}
