using System.Collections.Generic;

namespace DoNotWasteYourTime.Models;

public class Site
{
    public int Id { get; set; }
    public string Url { get; set; }
    public IList<SiteVisitLog> VisitLogs { get; set; }
}