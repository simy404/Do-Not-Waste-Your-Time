using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DoNotWasteYourTime.Models
{
	public sealed class SiteBlockerManager 
	{
		private static SiteBlockerManager _instance;
		private static readonly object Padlock = new();
		public IList<IBlockedSiteGroup> BlockedSiteGroups { get; set; }
		private readonly string filePath = $"{Application.StartupPath}\\x.json"; 
		private SiteBlockerManager()
		{
			
		}
		
		public static SiteBlockerManager GetInstance()
		{
			lock (Padlock)
			{
				return _instance ??= new SiteBlockerManager();
			}
		}
		
		public void SaveChanges()
		{
			if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
				throw new Exception("File path is not set or File not exist");
			
			string json = JsonConvert.SerializeObject(BlockedSiteGroups, Formatting.Indented, new JsonSerializerSettings()
			{
				TypeNameHandling = TypeNameHandling.Auto
			});
			
			File.WriteAllText(filePath, json);
		}
		
		public string LoadConfig()
		{
			if (!File.Exists(filePath))
			{
				File.Create(filePath);
				return null;
			}
			
			using var streamReader = new StreamReader(filePath);
			var json = streamReader.ReadToEnd();

			return json;
		}

	}
}
