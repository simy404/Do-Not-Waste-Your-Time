using System;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using DoNotWasteYourTime.Forms;
using DoNotWasteYourTime.Helpers;
using DoNotWasteYourTime.Models;

namespace DoNotWasteYourTime.UI;

public class PanelBuilder
{
    private readonly IBlockedSiteGroup group;
    private readonly FlowLayoutPanel flowLayoutPanel;
    public PanelBuilder(IBlockedSiteGroup group, FlowLayoutPanel flowLayoutPanel)
    {
        this.group = group;
        this.flowLayoutPanel = flowLayoutPanel ?? throw new ArgumentNullException(nameof(flowLayoutPanel));
    }
    
    public Panel Build()
    {
        using var uiHelper = new UiHelper();
        SiteBlockerManager manager = SiteBlockerManager.GetInstance();
        ResourceManager rm = new("DoNotWasteYourTime.Properties.Resources",Assembly.GetExecutingAssembly());

        var panel = uiHelper.CreatePanel(flowLayoutPanel.Size.Width - 30, flowLayoutPanel.Size.Height / 2);
			
        var nameLabel = uiHelper.CreateLabel(group.Name,30, 30);
        panel.Controls.Add(nameLabel);
			
        var descriptionLabel = uiHelper.CreateLabel(group.Description,30, 70);
        panel.Controls.Add(descriptionLabel);
			
        var toggle = uiHelper.CreateToggle( panel.Location.X+380, panel.Location.Y+25, group.IsActive, (sender, e) =>
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
            DialogResult result = MessageBox.Show(rm.GetString("do_you_want_to_continue"), rm.GetString("confirm"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result is DialogResult.Yes)
            {
                manager.BlockedSiteGroups.Remove(group);
                flowLayoutPanel.Controls.Remove(panel);
                manager.SaveChanges();
            }

        });
			
        panel.Controls.Add(descriptionLabel);
        panel.Controls.Add(editButton);
        panel.Controls.Add(toggle);
        panel.Controls.Add(deleteButton);

        return panel;
    }
}