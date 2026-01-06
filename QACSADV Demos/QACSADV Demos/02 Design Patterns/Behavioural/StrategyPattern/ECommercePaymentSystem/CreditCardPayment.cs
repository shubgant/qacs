using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercePaymentSystem
{
    // ConcreteStrategy for credit card payments
    public class CreditCardPayment : IPaymentStrategy
    {
        private string _cardNumber;
        private string _cvv;
        private string _expiryDate;

        public CreditCardPayment(string cardNumber, string cvv, string expiryDate)
        {
            _cardNumber = cardNumber;
            _cvv = cvv;
            _expiryDate = expiryDate;
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment for {amount:C}");
            // Implementation for processing credit card payment
        }
    }
}
