using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercePaymentSystem
{
    // The Context class
    public class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy) => 
            _paymentStrategy = paymentStrategy;
        public void Pay(double amount) =>
            _paymentStrategy.ProcessPayment(amount);
    }
}
