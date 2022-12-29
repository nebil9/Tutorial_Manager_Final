using System;
using System.Collections.Generic;

namespace Tutorial_Manager_Final.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public decimal? Anount { get; set; }

    public int? ParId { get; set; }

    public virtual Parent? Par { get; set; }
}
