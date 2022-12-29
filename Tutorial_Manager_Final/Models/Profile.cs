using System;
using System.Collections.Generic;

namespace Tutorial_Manager_Final.Models;

public partial class Profile
{
    public int ProfileId { get; set; }

    public string ProfileName { get; set; } = null!;

    public string? Bio { get; set; }

    public byte[]? ProfilePicture { get; set; }

    public virtual ICollection<Parent> Parents { get; } = new List<Parent>();

    public virtual ICollection<Student> Students { get; } = new List<Student>();

    public virtual ICollection<Tutor> Tutors { get; } = new List<Tutor>();
}
