using System;
using System.Collections.Generic;

namespace Tutorial_Manager_Final.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string? Title { get; set; }

    public int? Grade { get; set; }

    public int? TutId { get; set; }

    public virtual Tutor? Tut { get; set; }
}
