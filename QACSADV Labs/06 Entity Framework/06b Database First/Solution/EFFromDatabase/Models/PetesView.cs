using System;
using System.Collections.Generic;

namespace EFFromDatabase.Models;

public partial class PetesView
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int? TotalSales { get; set; }
}
