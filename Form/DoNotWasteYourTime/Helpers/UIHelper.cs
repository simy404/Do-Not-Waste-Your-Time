using System;
using System.Drawing;
using System.Windows.Forms;
using DoNotWasteYourTime.CustomTools;

namespace DoNotWasteYourTime.Helpers
{
    public class UiHelper : IDisposable
    {
		public Label CreateLabel(string name)
		{
			return new Label
			{
				Text = name,
				Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold),
				AutoSize = true,
				Location = new Point(30,30)
			};
		}
		
		public Button CreateButton(string name, int locationX, int locationY, EventHandler eventHandler = null )
		{
			Button deleteButton = new RJButton()
			{
				Text = name,
				BackColor = Color.FromArgb(255, 114, 94),
				Size = new Size(62, 30),
				Location = new Point(locationX, locationY-10),
				BorderRadius = 15,
				Font= new Font("Segoe UI", 9, FontStyle.Bold),
				TabStop = false
			};
			
			if (eventHandler is not null)
				deleteButton.Click += eventHandler;
			
			return deleteButton;
		}

		public RJToggleButton CreateToggle( int with, int height,bool isActive= false, EventHandler eventHandler = null)
		{
			RJToggleButton toggle = new RJToggleButton()
			{
				Size = new Size(20, 10),
				Location = new Point(with , height),
				Checked = isActive,
				OnBackColor = Color.FromArgb(255, 114, 94),
				TabStop = false
			};
			
			if(eventHandler is not null)
				toggle.CheckedChanged += eventHandler;
			
			return toggle;
		}

		public Label CreateDescriptionLabel(string description, int height)
		{
			return new Label
			{
				Text = description,
				AutoSize = true,
				Location = new Point(0, height + 5)
			};
		}
		
		public void Dispose()
		{
			// TODO release managed resources here
		}
    }
}