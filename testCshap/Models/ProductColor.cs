using System;
using System.Collections.Generic;

namespace testCshap.Models;

public partial class ProductColor
{
    public int FId { get; set; }

    public string FName { get; set; } = null!;

    public string? FColorCode { get; set; }
}
