using System;
using System.Collections.Generic;

namespace ThemeInt.DataBase;

public partial class JobMaster
{
    public int JobId { get; set; }

    public string? JobTitle { get; set; }

    public string? JobDiscription { get; set; }

    public int JobTypeId { get; set; }

    public virtual JobType JobType { get; set; } = null!;
}
