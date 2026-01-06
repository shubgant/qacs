namespace OpenClosedPrinciple
{
    public class GoldCustomer : B_GoodCustomer {
        public override decimal GetDiscountedPrice(decimal TotalSales)
        {
            return TotalSales - 10 * TotalSales / 100;
        }
    }
}