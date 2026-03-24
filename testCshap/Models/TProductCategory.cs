using System;
using System.Collections.Generic;

namespace testCshap.Models;

public partial class TProductCategory
{
    public int FId { get; set; }

    public string FName { get; set; } = null!;

    public string? FParentId { get; set; }

    public DateTime? FCreatedAt { get; set; }
}
