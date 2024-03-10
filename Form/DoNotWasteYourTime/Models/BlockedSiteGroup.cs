using System.Collections.Generic;
using Newtonsoft.Json;

namespace DoNotWasteYourTime.Models
{
	public class BlockedSiteGroup : IBlockedSiteGroup
	{
		[JsonConstructor]
		public BlockedSiteGroup(int id, string name, string description, bool isActive, IList<Site> sites)
		{
			Id = id;
			Name = name;
			Description = description;
			IsActive = isActive;
			Sites = sites;
		}
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsActive { get; set; }
		public IList<Site> Sites { get; set; }
	}
}
	