
using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace DoNotWasteYourTime
{
	public partial class EditGroup : KryptonForm
	{
		private readonly BlockedSiteGroup group;
		private readonly Label nameLabel;
		private readonly Label descriptionLabel;
		public EditGroup(BlockedSiteGroup group,Label nameLabel,Label descriptionLabel)
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

			foreach(var site  in group.Sites) 
			{
				sites_listbox.Items.Add(site);
			}
			
		}

		private void save_button_Click(object sender, EventArgs e)
		{
			group.Description = descriptionLabel.Text = description_textbox.Text;
			group.Name = nameLabel.Text = group_name_textbox.Text;

			Form1.Manager.SaveChanges();
			this.Close();
		}

		private void add_site_button_Click(object sender, EventArgs e)
		{
			
			if(string.IsNullOrWhiteSpace(add_site_textbox.Text))
			{
				return;
			}
			var site = add_site_textbox.Text.Trim();
			sites_listbox.Items.Add(site);
			group.Sites.Add(site);
			
		}

		private void remove_site_button_Click(object sender, EventArgs e)
		{
			if(sites_listbox.SelectedItem is null)
			{
				return; 
			}

			group.Sites.Remove(sites_listbox.SelectedItem.ToString());

			sites_listbox.Items.Remove(sites_listbox.SelectedItem);
			
		}

		

	}	
}
