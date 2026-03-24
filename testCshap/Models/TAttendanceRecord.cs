using System;
using System.Collections.Generic;

namespace testCshap.Models;

public partial class TAttendanceRecord
{
    public int FId { get; set; }

    public int FEmployeeId { get; set; }

    public DateOnly? FWorkDate { get; set; }

    public DateTime FClockInTime { get; set; }

    public DateTime FClockOutTime { get; set; }

    public string? FStatus { get; set; }

    public DateTime? FCreatedAt { get; set; }
}
