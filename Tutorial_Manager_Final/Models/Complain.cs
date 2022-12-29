using System;
using System.Collections.Generic;

namespace Tutorial_Manager_Final.Models;

public partial class Complain
{
    public int ComplainId { get; set; }

    public string? ComplainText { get; set; }

    public int? StuId { get; set; }

    public int? ParId { get; set; }

    public int? TutId { get; set; }

    public virtual Parent? Par { get; set; }

    public virtual Student? Stu { get; set; }

    public virtual Tutor? Tut { get; set; }
}
