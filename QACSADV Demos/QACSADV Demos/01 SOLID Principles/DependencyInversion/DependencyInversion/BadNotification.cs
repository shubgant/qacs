using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPMessagerExample
{
    public class BadNotification
    {
        //the class has a dependency on the Email class.
        //This violates the Dependency Inversion Principle.
        //When a class has dependency on another class and 
        //knows a lot about the other classes it interacts with it is said to be 
        //tightly coupled. When a class knows explicitly about the design and 
        //implementation of another class, it raises the risk that changes to 
        //one class will break the other.
        //What if we want to send some other types of notifications like SMS or 
        //save information to a database? To do this we'd need to change the behaviour of the 
        //notification class and this would be bad.
        private BadEmail email;

        public BadNotification(string emailAddress , string emailMessage)
        {
            this.email = new BadEmail(emailAddress, emailMessage);
        }

        public void SendNotification()
        {
            email.SendEmail();
        }
    }
}
