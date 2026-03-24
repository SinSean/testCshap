using System;
using System.Collections.Generic;

namespace testCshap.Models;

public partial class PaymentLog
{
    public int FId { get; set; }

    public int FPaymentTransactionsId { get; set; }

    public string FActionType { get; set; } = null!;

    public string? FRequestData { get; set; }

    public string? FResponseData { get; set; }

    public DateTime FCreatedAt { get; set; }
}
