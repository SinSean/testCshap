using System;
using System.Collections.Generic;

namespace testCshap.Models;

public partial class TicketCategory
{
    public int FId { get; set; }

    public string? FName { get; set; }

    public string? FDescription { get; set; }

    public DateTime? FCreatedAt { get; set; }
}
