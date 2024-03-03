using System.Collections.Generic;

namespace DoNotWasteYourTime
{
	public class BlockedSiteGroup
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsActive { get; set; }
		public IList<string> Sites { get; set; }
	}
}
	