using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercePaymentSystem
{
    // ConcreteStrategy for PayPal payments
    public class PayPalPayment : IPaymentStrategy
    {
        private string _emailAddress;
        private string _password;

        public PayPalPayment(string email, string password)
        {
            _emailAddress = email;
            _password = password;
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment for {amount:C}");
            // Implementation for processing PayPal payment
        }
    }
}
