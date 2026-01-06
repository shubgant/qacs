using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface ISale
    {
        void AddSaleToDatabase(string product, decimal totalSales);
        //Adding a RetrieveLoyaltyPoints method here as a required extra method would break all of the existing code
        //for the classes that implement this interface.
        //We want to keep all of the old "legacy code working but allow new 
        //classes to implement an interface that has both Add SalesToDatabase and RetrieveLoyaltyPoints methods - see below
        //void RetrieveLoyaltyPoints();
    }


}
