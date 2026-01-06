using System;
using System.Collections.Generic;

namespace EFFromDatabase.Models;

public partial class People
{
    public int Id { get; set; }

    public string Surname { get; set; } = null!;

    public string? Forename { get; set; }

    public int? Age { get; set; }
}
