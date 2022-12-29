using System;
using System.Collections.Generic;

namespace Tutorial_Manager_Final.Models;

public partial class Parent
{
    public int ParentId { get; set; }

    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public DateTime? DateRegistered { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public bool? Active { get; set; }

    public int? ProfId { get; set; }

    public int? AddrId { get; set; }

    public virtual Address? Addr { get; set; }

    public virtual ICollection<Complain> Complains { get; } = new List<Complain>();

    public virtual ICollection<Notification> Notifications { get; } = new List<Notification>();

    public virtual ICollection<Offer> Offers { get; } = new List<Offer>();

    public virtual ICollection<Payment> Payments { get; } = new List<Payment>();

    public virtual Profile? Prof { get; set; }

    public virtual ICollection<Rate> Rates { get; } = new List<Rate>();

    public virtual ICollection<Student> Students { get; } = new List<Student>();
}
