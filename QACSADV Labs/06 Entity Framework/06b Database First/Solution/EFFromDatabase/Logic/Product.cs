//using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFFromDatabase.Models
{
    public partial class Product
    {
        public decimal? OfferPrice =>
          (UnitsInStock < 5 && Discontinued) ? UnitPrice /= 2 : UnitPrice;
    }

    public class Product_Buddy
    {
        [MaxLength(50)]
        public string ProductName { get; set; }
    }
}

