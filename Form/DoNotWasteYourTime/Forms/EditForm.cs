using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DoNotWasteYourTime.Models;

namespace DoNotWasteYourTime.Forms
{
	public partial class EditGroup : KryptonForm
	{
		private readonly IBlockedSiteGroup group;
		private readonly Label nameLabel;
		private readonly Label descriptionLabel;
		private SiteBlockerManager manager;
		public EditGroup(IBlockedSiteGroup group,Label nameLabel,Label descriptionLabel)
		{
			InitializeComponent();
			this.group = group;
			this.nameLabel = nameLabel;
			this.descriptionLabel = descriptionLabel;
			
		}

		private void EditForm_Load(object sender, EventArgs e)
		{
			description_textbox.Text = group.Description;
			group_name_textbox.Text = group.Name;
			
			manager = SiteBlockerManager.GetInstance();
			
			foreach(var site  in group.Sites) 
			{
				sites_listbox.Items.Add(site);
			}
			
		}

		private void save_button_Click(object sender, EventArgs e)
		{
			group.Description = descriptionLabel.Text = description_textbox.Text;
			group.Name = nameLabel.Text = group_name_textbox.Text;
			
			
			manager.SaveChanges();
			this.Close();
		}

		private void add_site_button_Click(object sender, EventArgs e)
		{
			
			var url = add_site_textbox.Text.Trim();
			sites_listbox.Items.Add(url);

			var site = new Site()
			{
				Id = default,
				Url = url
			};
			
			group.Sites.Add(site);			
		}

		private void remove_site_button_Click(object sender, EventArgs e)
		{
			if(sites_listbox.SelectedItem is null)
			{
				return; 
			}

			group.Sites.RemoveAt(sites_listbox.SelectedIndex);

			sites_listbox.Items.Remove(sites_listbox.SelectedItem);
			
		}

		

	}	
}
