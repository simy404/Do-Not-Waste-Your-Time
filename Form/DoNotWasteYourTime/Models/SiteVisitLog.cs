using System;
using System.Collections.Generic;

namespace DoNotWasteYourTime.Models;

public class SiteVisitLog
{
    public int Id { get; set; }
    public IList<DateTime> VisitTime { get; set; }
}