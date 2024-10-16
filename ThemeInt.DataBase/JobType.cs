using System;
using System.Collections.Generic;

namespace ThemeInt.DataBase;

public partial class JobType
{
    public int JobtypeId { get; set; }

    public string? JobTypeName { get; set; }

    public virtual ICollection<JobMaster> JobMasters { get; set; } = new List<JobMaster>();
}
