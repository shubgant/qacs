using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPMessagerExample
{
    public class BetterNotification
    {
        //the class STILL has a dependency on the Email class. Aothough
        //it's now being passed in as a parameter to the Notification
        //class's constructor.
        //This STILL violates the Dependency Inversion Principle.
        //When a class has dependency on another class and 
        //knows a lot about the other classes it interacts with it is said to be 
        //tightly coupled. When a class knows explicitly about the design and 
        //implementation of another class, it raises the risk that changes to 
        //one class will break the other.
        //What if we want to send some other types of notifications like SMS or 
        //save information to a database? To do this we'd need to change the behaviour of the 
        //notification class and this would be bad.
        private BetterEmail email;

        //Email object is passed in to notification object's constructor
        public BetterNotification(BetterEmail email)
        {
            this.email = email;
        }

        public void SendNotification()
        {
            email.SendEmail();
        }
    }
}
