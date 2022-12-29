using System;
using System.Collections.Generic;

namespace Tutorial_Manager_Final.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? KifleKetema { get; set; }

    public string? State { get; set; }

    public virtual ICollection<Parent> Parents { get; } = new List<Parent>();

    public virtual ICollection<Student> Students { get; } = new List<Student>();

    public virtual ICollection<Tutor> Tutors { get; } = new List<Tutor>();
}
