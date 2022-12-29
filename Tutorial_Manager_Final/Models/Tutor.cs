using System;
using System.Collections.Generic;

namespace Tutorial_Manager_Final.Models;

public partial class Tutor
{
    public int TutorId { get; set; }

    public decimal? Salary { get; set; }

    public string? Name { get; set; }

    public byte[]? Cv { get; set; }

    public string? Username { get; set; }

    public bool? Active { get; set; }

    public string? Password { get; set; }

    public int? ProfId { get; set; }

    public int? AddrId { get; set; }

    public virtual Address? Addr { get; set; }

    public virtual ICollection<Complain> Complains { get; } = new List<Complain>();

    public virtual ICollection<Notification> Notifications { get; } = new List<Notification>();

    public virtual ICollection<Offer> Offers { get; } = new List<Offer>();

    public virtual ICollection<Performance> Performances { get; } = new List<Performance>();

    public virtual Profile? Prof { get; set; }

    public virtual ICollection<Rate> Rates { get; } = new List<Rate>();

    public virtual ICollection<Student> Students { get; } = new List<Student>();

    public virtual ICollection<Subject> Subjects { get; } = new List<Subject>();
}
