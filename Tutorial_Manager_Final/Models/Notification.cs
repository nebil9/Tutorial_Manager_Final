using System;
using System.Collections.Generic;

namespace Tutorial_Manager_Final.Models;

public partial class Notification
{
    public int NotificationId { get; set; }

    public string? Notification1 { get; set; }

    public DateTime? Date { get; set; }

    public int? ParId { get; set; }

    public int? StuId { get; set; }

    public int? TutId { get; set; }

    public virtual Parent? Par { get; set; }

    public virtual Student? Stu { get; set; }

    public virtual Tutor? Tut { get; set; }
}
