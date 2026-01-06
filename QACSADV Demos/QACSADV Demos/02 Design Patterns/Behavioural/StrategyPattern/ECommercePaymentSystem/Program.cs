namespace ECommercePaymentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var paymentContext = new PaymentContext();

            // Customer chooses to pay with credit card
            var creditCardPayment = new CreditCardPayment("1234567890123456", "123", "12/25");
            paymentContext.SetPaymentStrategy(creditCardPayment);
            paymentContext.Pay(125.75);

            // Customer switches to PayPal
            var paypalPayment = new PayPalPayment("user@example.com", "password123");
            paymentContext.SetPaymentStrategy(paypalPayment);
            paymentContext.Pay(89.50);
        }
    }
}
