using System;
using System.Collections.Generic;

namespace NorthWindWebAPI.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
