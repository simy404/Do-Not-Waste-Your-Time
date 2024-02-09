using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;
using System.Configuration;
using CustomControls.RJControls;
using DevExpress.XtraEditors.ColorPick.Picker;

namespace DoNotWasteYourTime
{
	public partial class Form1 : Form
	{
		public static SiteBlockerManager _Manager;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//ui configuration
			app_name.Text = $"DO NOT\nWASTE\nYOUR TİME";

			string FilePath = $"{Application.StartupPath}\\x.json";
			
			if (File.Exists(FilePath))
			{
				using(StreamReader streamReader = new StreamReader(FilePath))
				{
					string json = streamReader.ReadToEnd();

					_Manager = JsonConvert.DeserializeObject<SiteBlockerManager>(json);
					_Manager.filePath = FilePath;

					foreach (var group in _Manager.blockedSiteGroups)
					{
						Panel panel = CreateGroupPanel(group);
						flowLayoutPanel1.Controls.Add(panel);							
					}						
				}		
			}
			else 
			{
				File.Create(FilePath);
			}						
        }
		
		private Panel CreateGroupPanel(BlockedSiteGroup group)
		{
			Panel panel = new Panel();
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Margin = new Padding(5);

			//Get Panel Size
			int panelWidth = panel.Width;
			int panelHeight = panel.Height;

			//Name Label UI configuration
			Label nameLabel = new Label();
			nameLabel.Text = group.Name;
			nameLabel.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
			nameLabel.AutoSize = true;


			//Description Label configuration
			Label descriptionLabel = new Label();
			descriptionLabel.Text = group.Description;
			descriptionLabel.AutoSize = true;
			descriptionLabel.Location = new Point(0, nameLabel.Height + 5);


			//Edit Button configuration
			Button editButton = new RJButton();
			editButton.Text = "Edit";
			editButton.BackColor = Color.FromArgb(69, 69, 69);
			editButton.Click += (x, y) =>
			{
				EditGroup form = new EditGroup(group,nameLabel,descriptionLabel);
				form.StartPosition = FormStartPosition.CenterScreen;
				form.ShowDialog();
			};
			
			int buttonWidth = 100;
			int buttonHeight = 30;
			editButton.Size = new Size(buttonWidth, buttonHeight);

			//Location
			int buttonX = panelWidth - buttonWidth - 90;
			int buttonY = panelHeight - buttonHeight - 10;
			editButton.Location = new Point(buttonX, buttonY);

			//Toggle Configuration
			RJToggleButton toggle = new RJToggleButton();
			toggle.Checked = group.IsActive;
			toggle.OnBackColor = Color.FromArgb(242, 169, 59);
			toggle.Size = new Size(45, 22);
			toggle.Location = new Point(panelWidth - 70, panelHeight - 35);
			toggle.CheckedChanged += (x, y) =>
			{
				group.IsActive = !group.IsActive;
				_Manager.SaveChanges();
			};

			//Delete Button Configuration
			Button deleteButton = new RJButton();
			deleteButton.Text = "Delete";
			deleteButton.BackColor = Color.FromArgb(69, 69, 69);
			deleteButton.Click += (x, y) =>
			{
				_Manager.blockedSiteGroups.Remove(group);
				flowLayoutPanel1.Controls.Remove(panel);
				_Manager.SaveChanges();
			};
			deleteButton.Size = new Size(50, 22);
			deleteButton.Location = new Point(editButton.Location.X+120, editButton.Location.Y-50);

			panel.Controls.Add(nameLabel);
			panel.Controls.Add(descriptionLabel);
			panel.Controls.Add(editButton);
			panel.Controls.Add(toggle);
			panel.Controls.Add(deleteButton);
			
			return panel;

		}

		private void create_group_button_Click(object sender, EventArgs e)
		{
			BlockedSiteGroup group = new BlockedSiteGroup();
			group.Name = "new group";
			List<string> sites = new List<string>();
			group.Sites = sites;

			Panel panel = CreateGroupPanel(group);
			flowLayoutPanel1.Controls.Add(panel);

			_Manager.blockedSiteGroups.Add(group);
			_Manager.SaveChanges();
		}
	}
}
