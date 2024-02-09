using DevExpress.Utils.Behaviors.Common;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNotWasteYourTime
{
	public class SiteBlockerManager
	{
		public SiteBlockerManager(IList<BlockedSiteGroup> _blockedSiteGroups,string _filePath ) 
		{
			blockedSiteGroups = _blockedSiteGroups;
			filePath = _filePath;
		}

		public IList<BlockedSiteGroup> blockedSiteGroups { get; set; }
		public string filePath { get; set; }
		public void SaveChanges()
		{
			string json = JsonConvert.SerializeObject(this,Formatting.Indented);
			File.WriteAllText(filePath, json);
		}

	}
}
