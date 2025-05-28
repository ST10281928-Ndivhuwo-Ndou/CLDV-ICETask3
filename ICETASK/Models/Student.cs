using System;
using System.Collections.Generic;

namespace ICETASK.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentNumber { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Programme { get; set; } = null!;
}
