using System;
using System.Collections.Generic;

namespace EFFromDatabase.Models;

public partial class OrdersForCustomersWhoseNameStartsWithA
{
    public int OrderId { get; set; }

    public DateTime? OrderDate { get; set; }
}
