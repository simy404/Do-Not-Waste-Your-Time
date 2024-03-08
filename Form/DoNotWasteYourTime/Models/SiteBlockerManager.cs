using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace DoNotWasteYourTime.Models
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
			if (string.IsNullOrWhiteSpace(FilePath) || !File.Exists(FilePath))
				throw new Exception("File path is not set or File not exist");
			
			string json = JsonConvert.SerializeObject(this,Formatting.Indented);
			File.WriteAllText(FilePath, json);
		}

	}
}
