using System;
using System.Collections.Generic;

namespace Tutorial_Manager_Final.Models;

public partial class Schedule
{
    public int ScheduleId { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? Time { get; set; }

    public int? TutId { get; set; }
}
