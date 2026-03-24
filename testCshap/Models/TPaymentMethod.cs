using System;
using System.Collections.Generic;

namespace testCshap.Models;

public partial class TPaymentMethod
{
    public int FId { get; set; }

    public string? FMethodName { get; set; }

    public string? FProviderCode { get; set; }

    public decimal? FHandlingFee { get; set; }

    public bool FIsActive { get; set; }
}
