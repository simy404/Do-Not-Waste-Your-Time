using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DoNotWasteYourTime.Helpers;
using DoNotWasteYourTime.Models;
using DoNotWasteYourTime.UI.Components;

namespace DoNotWasteYourTime.Forms
{
	public partial class MainForm : KryptonForm
	{
		private SiteBlockerManager manager;
		private readonly ResourceManager rm = new("DoNotWasteYourTime.Properties.Resources",Assembly.GetExecutingAssembly());
		public MainForm()
		{
			InitializeComponent();
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
			manager = SiteBlockerManager.GetInstance();
			manager.BlockedSiteGroups = DeserializeConfig<List<IBlockedSiteGroup>>(manager.LoadConfig());
			RegisterControls(manager.BlockedSiteGroups);
            
		}

		private T DeserializeConfig<T>(string config) where T : class, new()
		{
			if (string.IsNullOrEmpty(config))
				return null;
			
			JsonParser jsonParser = new JsonParser();
			
			return jsonParser.JsonToModelResultParse<T>(config) ?? new T();
		}
		
		
		private void RegisterControls(IList<IBlockedSiteGroup> blockedSiteGroups)
		{
			if (!blockedSiteGroups.Any())
				return;
			
			foreach (var blockedSiteGroup in blockedSiteGroups)
			{
				RegisterControl(blockedSiteGroup);
			}
		}

		private void RegisterControl(IBlockedSiteGroup blockedSiteGroup)
		{
			var panel = CreatePanelControl(blockedSiteGroup);
			flowLayoutPanel1.Controls.Add(panel);
		}
		
		private Panel CreatePanelControl(IBlockedSiteGroup group)
		{
			PanelBuilder controlPanelBuilder = new PanelBuilder(group, flowLayoutPanel1);
			return controlPanelBuilder.Build();
		}
		
		private void create_group_button_Click(object sender, EventArgs e)
		{
			Site site = new Site()
			{
				Id = 1,
				Url = "Deneme",
				VisitLogs = new List<SiteVisitLog>
				{
					new SiteVisitLog()
					{
						Id = 1,
						VisitTime = new List<DateTime>()
						{
							DateTime.Now
						}
					}
				}
			};
			
			var group = new BlockedSiteGroup(0, rm.GetString("new_group"), "Description", false, new List<Site>()
			{
				site
			});
			
			RegisterControl(group);
			manager.BlockedSiteGroups.Add(group);
			manager.SaveChanges();
		}
		
	}
}
