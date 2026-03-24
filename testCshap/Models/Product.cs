using System;
using System.Collections.Generic;

namespace testCshap.Models;

public partial class Product
{
    public int FId { get; set; }

    public string? FProduct { get; set; }

    public int FCategoryId { get; set; }

    public string FName { get; set; } = null!;

    public string? FDescription { get; set; }

    public decimal FPrice { get; set; }

    public byte FStatus { get; set; }

    public DateTime? FCreatedAt { get; set; }
}
