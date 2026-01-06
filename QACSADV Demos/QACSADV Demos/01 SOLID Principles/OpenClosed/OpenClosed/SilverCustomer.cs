namespace OpenClosedPrinciple
{
    public class SilverCustomer : B_GoodCustomer {
        public override decimal GetDiscountedPrice(decimal TotalSales)
        {
            return TotalSales - 5 * TotalSales / 100;
        }
    }
}