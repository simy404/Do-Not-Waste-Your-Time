using System;
using System.Drawing;
using System.Windows.Forms;
using DoNotWasteYourTime.CustomTools;

namespace DoNotWasteYourTime.Helpers
{
    public class UiHelper : IDisposable
    {
	    public Panel CreatePanel(int width, int height)
	    {
		    return new RJPanel()
		    {
			    BorderStyle = BorderStyle.None,
			    Width = width,
			    Height = height,
			    BackColor = Color.FromArgb(240, 240, 240),
			    Margin =  new Padding(0,0,0,5)
		    };
	    }
		public Label CreateLabel(string name, int locationX, int locationY )
		{
			return new Label
			{
				Text = name,
				Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold),
				AutoSize = true,
				Location = new Point(locationX, locationY)
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

		
		
		public void Dispose()
		{
			// TODO release managed resources here
		}
    }
}