using System;
using System.Collections.Generic;

namespace EFFromDatabase.Models;

public partial class CustomerOrder
{
    public string CustomerId { get; set; } = null!;

    public string? ContactName { get; set; }

    public string? ContactTitle { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? ShippedDate { get; set; }
}
