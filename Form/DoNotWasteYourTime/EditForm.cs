using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNotWasteYourTime
{
	public partial class EditGroup : Form
	{
		BlockedSiteGroup _group;
		Label _nameLabel;
		Label _descriptionLabel;
		public EditGroup(BlockedSiteGroup group,Label namelabel,Label descriptionlabel)
		{
			InitializeComponent();
			_group = group;
			_nameLabel = namelabel;
			_descriptionLabel = descriptionlabel;

		}

		private void EditForm_Load(object sender, EventArgs e)
		{
			description_textbox.Texts = _group.Description;
			group_name_textbox.Texts = _group.Name;

			foreach(var site  in _group.Sites) 
			{
				sites_listbox.Items.Add(site);
			}
			
		}

		private void save_button_Click(object sender, EventArgs e)
		{
			_group.Description = _descriptionLabel.Text = description_textbox.Texts;
			_group.Name = _nameLabel.Text = group_name_textbox.Texts;

			Form1._Manager.SaveChanges();
		}

		private void add_site_button_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(add_site_textbox.Texts))
			{
				return;
			}
			string site = add_site_textbox.Texts.Trim();
			sites_listbox.Items.Add(site);
			_group.Sites.Add(site);
		}

		private void remove_site_button_Click(object sender, EventArgs e)
		{
			if(sites_listbox.SelectedItem is null)
			{
				return; 
			}

			_group.Sites.Remove(sites_listbox.SelectedItem.ToString());

			sites_listbox.Items.Remove(sites_listbox.SelectedItem);
			
		}
	}	
}
