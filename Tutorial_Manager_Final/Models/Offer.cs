using System;
using System.Collections.Generic;

namespace Tutorial_Manager_Final.Models;

public partial class Offer
{
    public int OfferId { get; set; }

    public DateTime? Date { get; set; }

    public bool? Accept { get; set; }

    public int? ParId { get; set; }

    public int? TutId { get; set; }

    public virtual Parent? Par { get; set; }

    public virtual Tutor? Tut { get; set; }
}
