using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    /// <summary>
    /// Old customer. Implements IDatabase
    /// </summary>
    public abstract class A_OldCustomer: IDiscount, ISale
    {
        protected ILogger logger;

        public A_OldCustomer(ILogger logger)
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
    }


}
