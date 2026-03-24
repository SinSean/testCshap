using System;
using System.Collections.Generic;

namespace testCshap.Models;

public partial class ProductVariant
{
    public int FId { get; set; }

    public int FProductId { get; set; }

    public int FColorId { get; set; }

    public int FSizeId { get; set; }

    public string FSkuCode { get; set; } = null!;

    public int FStock { get; set; }

    public decimal? FPrice { get; set; }
}
