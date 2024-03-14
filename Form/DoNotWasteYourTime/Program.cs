using System;
using System.Windows.Forms;
using DoNotWasteYourTime.Forms;
using DoNotWasteYourTime.UI.Forms;

namespace DoNotWasteYourTime
{
	internal static class Program
	{
		/// <summary>
		/// Uygulamanın ana girdi noktası.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
