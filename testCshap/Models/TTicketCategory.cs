using System;
using System.Collections.Generic;

namespace testCshap.Models;

public partial class TTicketCategory
{
    public int FId { get; set; }

    public string? FName { get; set; }

    public string? FDescription { get; set; }

    public DateTime? FCreatedAt { get; set; }
}
