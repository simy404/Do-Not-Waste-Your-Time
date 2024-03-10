using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DoNotWasteYourTime.Models;

[JsonPolymorphic] // T sınıfının Derived classı T türünde serialize edilirse Derived classın kendi prop/fieldlarının kaybolmasını önler.
[JsonDerivedType(typeof(BlockedSiteGroup), typeDiscriminator: "BlockedSiteGroup")] // "$type": "DoNotWasteYourTime.Models.BlockedSiteGroup, DoNotWasteYourTime" serialize işleminde bu şekilde kaydeder ve deserialize olurken classı tanımasını sağlar.
public interface IBlockedSiteGroup
{
     int Id { get; set; }
     string Name { get; set; }
     string Description { get; set; }   
     bool IsActive { get; set; }
     IList<Site> Sites { get; set; }
}