using System;
using System.Collections.Generic;

namespace testCshap.Models;

public partial class TProductImage
{
    public int FId { get; set; }

    public int FProductId { get; set; }

    public string FImageUrl { get; set; } = null!;

    public int FSortOrder { get; set; }

    public byte FIsMain { get; set; }
}
