using System;
using System.Collections.Generic;

namespace Tutorial_Manager_Final.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public int? Grade { get; set; }

    public string? Name { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public bool? Active { get; set; }

    public int? ParId { get; set; }

    public int? TutId { get; set; }

    public int? ProfId { get; set; }

    public int? AddrId { get; set; }

    public virtual Address? Addr { get; set; }

    public virtual ICollection<Complain> Complains { get; } = new List<Complain>();

    public virtual ICollection<Notification> Notifications { get; } = new List<Notification>();

    public virtual Parent? Par { get; set; }

    public virtual ICollection<Performance> Performances { get; } = new List<Performance>();

    public virtual Profile? Prof { get; set; }

    public virtual ICollection<Rate> Rates { get; } = new List<Rate>();

    public virtual Tutor? Tut { get; set; }
}
