using System;
using System.Collections.Generic;

namespace testCshap.Models;

public partial class Department
{
    public int FId { get; set; }

    public string? FDepartmentName { get; set; }

    public int? FManagerId { get; set; }
}
