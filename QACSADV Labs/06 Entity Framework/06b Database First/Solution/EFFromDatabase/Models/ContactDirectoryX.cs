using System;
using System.Collections.Generic;

namespace EFFromDatabase.Models;

public partial class ContactDirectoryX
{
    public string CompanyName { get; set; } = null!;

    public string? ContactName { get; set; }

    public string? Phone { get; set; }
}
