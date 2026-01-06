using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    /// <summary>
    /// The BadCustomer class is doing things it shouldn't. 
    /// The class should do Customer data validations, 
    /// call the Customer data access layer etc.
    /// However, notice the catch block is doing a Logging activity.
    /// This makes the class overloaded with a lot of responsibility.
    /// If tomorrow a new logger (like an event logger) needs to be
    /// added we'd need to edit the Customer class which is a peculiar thing
    /// to have to do. Why should a customer class have to be responsible for
    /// logging anything? Think of a Swiss army knife which includes
    /// all of the possible tools from Bit driver thru Pharmeceutical 
    /// Spatula to Window-breaker. It would be unweildy (to say the least)
    /// and difficult to fix if something goes wrong. The Single Responsibiblity
    /// Principle (SRP) states that a class should have only one responsibility 
    /// (and not multiple). So applying SRP to the class we would move the logging 
    /// activity to another class.
    /// </summary>
    public class A_BadCustomer
    {

        public void AddToMailingList(string MailingListDetails)
        {
            try
            {
                //Code to validate and format mailing list details and add them to database goes here
                throw new Exception(MailingListDetails);
            }
            catch(Exception exn)
            {
                //log error
                System.IO.File.WriteAllText(@"C:\Temp\Error.txt", exn.Message);
            }
        }
    }
}
