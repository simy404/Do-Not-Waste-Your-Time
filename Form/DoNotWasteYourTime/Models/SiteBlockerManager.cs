using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace DoNotWasteYourTime
{
	public class SiteBlockerManager
	{
		public SiteBlockerManager(IList<BlockedSiteGroup> blockedSiteGroups,string filePath )
		{
			this.BlockedSiteGroups = blockedSiteGroups;
			Debug.Assert(filePath != null, nameof(filePath) + " != null");
			this.FilePath = filePath;
		}

		public IList<BlockedSiteGroup> BlockedSiteGroups { get; set; }
		public string FilePath { get; set; }
		public void SaveChanges()
		{
			string json = JsonConvert.SerializeObject(this,Formatting.Indented);
			File.WriteAllText(FilePath, json);
		}

	}
}
