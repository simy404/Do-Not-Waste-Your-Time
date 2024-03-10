using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DoNotWasteYourTime.CustomTools;
using DoNotWasteYourTime.Helpers;
using DoNotWasteYourTime.Models;
using Newtonsoft.Json;

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
			var config = manager.LoadConfig();
			
			
			if (!string.IsNullOrEmpty(config))
				manager.BlockedSiteGroups = (JsonConvert.DeserializeObject<List<IBlockedSiteGroup>>(config, new JsonSerializerSettings()
				{
					TypeNameHandling = TypeNameHandling.Auto
				}));
			

			if (manager.BlockedSiteGroups is not null)
				RegisterControls(manager.BlockedSiteGroups);
			else
				manager.BlockedSiteGroups = new List<IBlockedSiteGroup>();

		}
		private void RegisterControls(IList<IBlockedSiteGroup> blockedSiteGroups)
		{
			foreach (var blockedSiteGroup in blockedSiteGroups)
			{
				RegisterControl(blockedSiteGroup);
			}
		}

		private void RegisterControl(IBlockedSiteGroup blockedSiteGroup)
		{
			var panel = CreateGroupPanel(blockedSiteGroup);
			flowLayoutPanel1.Controls.Add(panel);
		}
		
		private Panel CreateGroupPanel(IBlockedSiteGroup group)
		{
			var panel = new RJPanel()
			{
				BorderStyle = BorderStyle.None,
				Width = (flowLayoutPanel1.Size.Width-30),
				Height = flowLayoutPanel1.Size.Height/2,
				BackColor = Color.FromArgb(240, 240, 240),
				Margin =  new Padding(0,0,0,5)
			};
			
			using var uiHelper = new UiHelper();
			
			var nameLabel = uiHelper.CreateLabel(group.Name,30, 30);
			var descriptionLabel = uiHelper.CreateLabel(TextHelper.WrapText(group.Description, 15), 30, 70);
			
			var toggle = uiHelper.CreateToggle( panel.Location.X+380, panel.Location.Y+25, group.IsActive, (sender, args) =>
			{
				group.IsActive = !group.IsActive;
				manager.SaveChanges();
			});
			
			var editButton = uiHelper.CreateButton(rm.GetString("edit"), panel.Location.X+440, panel.Location.Y+30,(sender, e) =>
			{
				var form = new EditGroup(group, nameLabel, descriptionLabel);
				form.StartPosition = FormStartPosition.CenterScreen;
				form.ShowDialog();
			});
			
			var deleteButton = uiHelper.CreateButton(rm.GetString("delete"), panel.Location.X+510, panel.Location.Y+30,(sender, args) =>
			{
				DialogResult result = MessageBox.Show("Devam etmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					manager.BlockedSiteGroups.Remove(group);
					flowLayoutPanel1.Controls.Remove(panel);
					manager.SaveChanges();
				}

			});

			panel.Controls.Add(nameLabel);
			panel.Controls.Add(descriptionLabel);
			panel.Controls.Add(editButton);
			panel.Controls.Add(toggle);
			panel.Controls.Add(deleteButton);

			return panel;
		}
		
		private void create_group_button_Click_1(object sender, EventArgs e)
		{
			Site site = new Site()
			{
				Id = 1,
				Url = "",
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
