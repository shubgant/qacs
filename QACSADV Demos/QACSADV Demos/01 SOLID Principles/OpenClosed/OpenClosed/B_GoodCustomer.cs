// The GoodCustomer class. It is now closed for modification but open for
// Extension by allowing for the addition of new specialised Customer classes
namespace OpenClosedPrinciple
{
    //Base or (super) class
    public abstract class B_GoodCustomer {

        public abstract decimal GetDiscountedPrice(decimal TotalSales);

    }
}