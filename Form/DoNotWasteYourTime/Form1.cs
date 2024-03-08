using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using DoNotWasteYourTime.Helpers;
using ComponentFactory.Krypton.Toolkit;
using DoNotWasteYourTime.CustomTools;
using DoNotWasteYourTime.Models;
using Microsoft.Extensions.Primitives;

namespace DoNotWasteYourTime
{
	public partial class Form1 : KryptonForm
	{
		public static SiteBlockerManager Manager;
		readonly ResourceManager rm = new("DoNotWasteYourTime.Properties.Resources",Assembly.GetExecutingAssembly());
		public Form1()
		{
			InitializeComponent();
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
			string filePath = $"{Application.StartupPath}\\x.json";
			
			string json = LoadConfig(filePath);
			
			Manager = JsonConvert.DeserializeObject<SiteBlockerManager>(json);
			Manager.FilePath = filePath;

			RegisterControls(Manager.BlockedSiteGroups);

		}
		
		private string LoadConfig(string filePath)
		{
			if (!File.Exists(filePath))
			{
				File.Create(filePath);
				return null;
			}
			
			using var streamReader = new StreamReader(filePath);
			var json = streamReader.ReadToEnd();
			
			if (string.IsNullOrEmpty(json)) 
				throw new NullReferenceException("json file does not read");

			return json;
		}

		private void RegisterControls(IList<BlockedSiteGroup> blockedSiteGroups)
		{
			foreach (var group in blockedSiteGroups)
			{
				var panel = CreateGroupPanel(group);
				flowLayoutPanel1.Controls.Add(panel);							
			}
		}
		
		private Panel CreateGroupPanel(BlockedSiteGroup group)
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
				Manager.SaveChanges();
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
					Manager.BlockedSiteGroups.Remove(group);
					flowLayoutPanel1.Controls.Remove(panel);
					Manager.SaveChanges();
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
			var group = new BlockedSiteGroup()
			{
				Name = rm.GetString("new_group"),
				Sites = new List<string>()
			};
			
			var panel = CreateGroupPanel(group);
			
			flowLayoutPanel1.Controls.Add(panel);

			Manager.BlockedSiteGroups.Add(group);
			Manager.SaveChanges();
		}
		
		


	}
}
