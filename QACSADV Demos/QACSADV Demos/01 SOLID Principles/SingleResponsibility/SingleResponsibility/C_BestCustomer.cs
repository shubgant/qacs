using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class C_BestCustomer
    {
        private ILogger logger;

        //Different kinds of logger (File, Event, Database...) can now be injected 
        public C_BestCustomer(ILogger logger)
        {
            this.logger = logger;
        }

        public virtual void AddToMailingList(string MailingListDetails)
        {
            try
            {
                //this.logger.Handle(new Exception("Something bad happened"));
                //Code to validate and format mailing list 
                //details and add them to database goes here

                //Mimic something bad happening
                throw new Exception(MailingListDetails);
            }
            catch (Exception ex)
            {
                if (this.logger != null)
                    this.logger.Handle(ex.Message);
            }
        }
    }
}
