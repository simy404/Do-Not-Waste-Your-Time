namespace DoNotWasteYourTime.Forms
{
	partial class EditGroup
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGroup));
			this.description_label = new System.Windows.Forms.Label();
			this.group_name_label = new System.Windows.Forms.Label();
			this.sites_label = new System.Windows.Forms.Label();
			this.add_site_label = new System.Windows.Forms.Label();
			this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
			this.save_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.sites_listbox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
			this.description_textbox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.group_name_textbox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.add_site_textbox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.add_site_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.remove_site_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// description_label
			// 
			this.description_label.AutoSize = true;
			this.description_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.description_label.Location = new System.Drawing.Point(44, 98);
			this.description_label.Name = "description_label";
			this.description_label.Size = new System.Drawing.Size(88, 19);
			this.description_label.TabIndex = 1;
			this.description_label.Text = "Description :";
			// 
			// group_name_label
			// 
			this.group_name_label.AutoSize = true;
			this.group_name_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.group_name_label.Location = new System.Drawing.Point(44, 21);
			this.group_name_label.Name = "group_name_label";
			this.group_name_label.Size = new System.Drawing.Size(96, 19);
			this.group_name_label.TabIndex = 3;
			this.group_name_label.Text = "Group Name :";
			// 
			// sites_label
			// 
			this.sites_label.AutoSize = true;
			this.sites_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.sites_label.Location = new System.Drawing.Point(357, 20);
			this.sites_label.Name = "sites_label";
			this.sites_label.Size = new System.Drawing.Size(46, 19);
			this.sites_label.TabIndex = 5;
			this.sites_label.Text = "Sites :";
			// 
			// add_site_label
			// 
			this.add_site_label.AutoSize = true;
			this.add_site_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.add_site_label.ForeColor = System.Drawing.SystemColors.ControlText;
			this.add_site_label.Location = new System.Drawing.Point(44, 243);
			this.add_site_label.Name = "add_site_label";
			this.add_site_label.Size = new System.Drawing.Size(69, 19);
			this.add_site_label.TabIndex = 8;
			this.add_site_label.Text = "Add Site :";
			// 
			// kryptonPalette1
			// 
			this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.Image")));
			this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed")));
			this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
			this.kryptonPalette1.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.Image")));
			this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed")));
			this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking")));
			this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.Image")));
			this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed")));
			this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking")));
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
			this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 12;
			this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
			this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
			this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
			this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
			// 
			// save_button
			// 
			this.save_button.Location = new System.Drawing.Point(477, 334);
			this.save_button.Name = "save_button";
			this.save_button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.save_button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.save_button.OverrideDefault.Back.ColorAngle = 45F;
			this.save_button.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.save_button.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.save_button.OverrideDefault.Border.ColorAngle = 45F;
			this.save_button.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.save_button.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.save_button.OverrideDefault.Border.Rounding = 20;
			this.save_button.OverrideDefault.Border.Width = 1;
			this.save_button.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.save_button.Size = new System.Drawing.Size(155, 43);
			this.save_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.save_button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.save_button.StateCommon.Back.ColorAngle = 45F;
			this.save_button.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.save_button.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(159)))), ((int)(((byte)(49)))));
			this.save_button.StateCommon.Border.ColorAngle = 45F;
			this.save_button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.save_button.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.save_button.StateCommon.Border.Rounding = 20;
			this.save_button.StateCommon.Border.Width = 1;
			this.save_button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.save_button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.save_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.save_button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
			this.save_button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
			this.save_button.StatePressed.Back.ColorAngle = 135F;
			this.save_button.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.save_button.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(159)))), ((int)(((byte)(49)))));
			this.save_button.StatePressed.Border.ColorAngle = 135F;
			this.save_button.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.save_button.StatePressed.Border.Rounding = 20;
			this.save_button.StatePressed.Border.Width = 1;
			this.save_button.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.save_button.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.save_button.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.save_button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.save_button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
			this.save_button.StateTracking.Back.ColorAngle = 45F;
			this.save_button.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.save_button.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.save_button.StateTracking.Border.ColorAngle = 45F;
			this.save_button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.save_button.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.save_button.StateTracking.Border.Rounding = 20;
			this.save_button.StateTracking.Border.Width = 1;
			this.save_button.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.save_button.TabIndex = 11;
			this.save_button.Values.Text = "Save";
			this.save_button.Click += new System.EventHandler(this.save_button_Click);
			// 
			// sites_listbox
			// 
			this.sites_listbox.Location = new System.Drawing.Point(360, 44);
			this.sites_listbox.Name = "sites_listbox";
			this.sites_listbox.OverrideFocus.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.sites_listbox.OverrideFocus.Item.Border.Rounding = 10;
			this.sites_listbox.OverrideFocus.Item.Border.Width = 0;
			this.sites_listbox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.sites_listbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.sites_listbox.Size = new System.Drawing.Size(272, 276);
			this.sites_listbox.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
			this.sites_listbox.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateActive.Back.ColorAngle = 45F;
			this.sites_listbox.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateActive.Border.ColorAngle = 15F;
			this.sites_listbox.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.sites_listbox.StateActive.Border.Rounding = 10;
			this.sites_listbox.StateActive.Border.Width = 1;
			this.sites_listbox.StateCheckedNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.sites_listbox.StateCheckedNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.sites_listbox.StateCheckedNormal.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateCheckedNormal.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateCheckedNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.sites_listbox.StateCheckedNormal.Item.Border.Rounding = 2;
			this.sites_listbox.StateCheckedNormal.Item.Border.Width = 1;
			this.sites_listbox.StateCheckedNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.sites_listbox.StateCheckedPressed.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateCheckedPressed.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateCheckedTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.sites_listbox.StateCheckedTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.sites_listbox.StateCheckedTracking.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateCheckedTracking.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateCheckedTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.sites_listbox.StateCheckedTracking.Item.Border.Rounding = 3;
			this.sites_listbox.StateCheckedTracking.Item.Border.Width = 2;
			this.sites_listbox.StateCheckedTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.sites_listbox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.sites_listbox.StateCommon.Border.Rounding = 10;
			this.sites_listbox.StateCommon.Border.Width = 0;
			this.sites_listbox.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateNormal.Back.ColorAngle = 45F;
			this.sites_listbox.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.sites_listbox.StateNormal.Border.Rounding = 10;
			this.sites_listbox.StateNormal.Border.Width = 0;
			this.sites_listbox.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.sites_listbox.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.sites_listbox.StateNormal.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateNormal.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.sites_listbox.StateNormal.Item.Border.Rounding = 10;
			this.sites_listbox.StateNormal.Item.Border.Width = 1;
			this.sites_listbox.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.sites_listbox.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.sites_listbox.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.sites_listbox.StateTracking.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateTracking.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.sites_listbox.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.sites_listbox.StateTracking.Item.Border.Rounding = 2;
			this.sites_listbox.StateTracking.Item.Border.Width = 1;
			this.sites_listbox.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.sites_listbox.TabIndex = 12;
			// 
			// description_textbox
			// 
			this.description_textbox.Location = new System.Drawing.Point(44, 120);
			this.description_textbox.MaxLength = 200;
			this.description_textbox.Multiline = true;
			this.description_textbox.Name = "description_textbox";
			this.description_textbox.Size = new System.Drawing.Size(204, 100);
			this.description_textbox.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.description_textbox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.description_textbox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.description_textbox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.description_textbox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.description_textbox.StateCommon.Border.Rounding = 10;
			this.description_textbox.StateCommon.Border.Width = 1;
			this.description_textbox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
			this.description_textbox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.description_textbox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.description_textbox.TabIndex = 13;
			// 
			// group_name_textbox
			// 
			this.group_name_textbox.Location = new System.Drawing.Point(44, 44);
			this.group_name_textbox.MaxLength = 50;
			this.group_name_textbox.Name = "group_name_textbox";
			this.group_name_textbox.Size = new System.Drawing.Size(204, 30);
			this.group_name_textbox.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.group_name_textbox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.group_name_textbox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.group_name_textbox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.group_name_textbox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.group_name_textbox.StateCommon.Border.Rounding = 15;
			this.group_name_textbox.StateCommon.Border.Width = 1;
			this.group_name_textbox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
			this.group_name_textbox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.group_name_textbox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.group_name_textbox.TabIndex = 14;
			// 
			// add_site_textbox
			// 
			this.add_site_textbox.Location = new System.Drawing.Point(44, 265);
			this.add_site_textbox.MaxLength = 100;
			this.add_site_textbox.Name = "add_site_textbox";
			this.add_site_textbox.Size = new System.Drawing.Size(204, 30);
			this.add_site_textbox.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.add_site_textbox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.add_site_textbox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.add_site_textbox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.add_site_textbox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.add_site_textbox.StateCommon.Border.Rounding = 15;
			this.add_site_textbox.StateCommon.Border.Width = 1;
			this.add_site_textbox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
			this.add_site_textbox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.add_site_textbox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.add_site_textbox.TabIndex = 15;
			// 
			// add_site_button
			// 
			this.add_site_button.Location = new System.Drawing.Point(259, 265);
			this.add_site_button.Name = "add_site_button";
			this.add_site_button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.add_site_button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.add_site_button.OverrideDefault.Back.ColorAngle = 45F;
			this.add_site_button.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.add_site_button.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.add_site_button.OverrideDefault.Border.ColorAngle = 45F;
			this.add_site_button.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.add_site_button.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.add_site_button.OverrideDefault.Border.Rounding = 20;
			this.add_site_button.OverrideDefault.Border.Width = 1;
			this.add_site_button.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.add_site_button.Size = new System.Drawing.Size(64, 30);
			this.add_site_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.add_site_button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.add_site_button.StateCommon.Back.ColorAngle = 45F;
			this.add_site_button.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.add_site_button.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(159)))), ((int)(((byte)(49)))));
			this.add_site_button.StateCommon.Border.ColorAngle = 45F;
			this.add_site_button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.add_site_button.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.add_site_button.StateCommon.Border.Rounding = 20;
			this.add_site_button.StateCommon.Border.Width = 1;
			this.add_site_button.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
			this.add_site_button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.add_site_button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.add_site_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Black", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.add_site_button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
			this.add_site_button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
			this.add_site_button.StatePressed.Back.ColorAngle = 135F;
			this.add_site_button.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.add_site_button.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(159)))), ((int)(((byte)(49)))));
			this.add_site_button.StatePressed.Border.ColorAngle = 135F;
			this.add_site_button.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.add_site_button.StatePressed.Border.Rounding = 20;
			this.add_site_button.StatePressed.Border.Width = 1;
			this.add_site_button.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.add_site_button.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.add_site_button.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.add_site_button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.add_site_button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
			this.add_site_button.StateTracking.Back.ColorAngle = 45F;
			this.add_site_button.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.add_site_button.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.add_site_button.StateTracking.Border.ColorAngle = 45F;
			this.add_site_button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.add_site_button.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.add_site_button.StateTracking.Border.Rounding = 20;
			this.add_site_button.StateTracking.Border.Width = 1;
			this.add_site_button.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.add_site_button.TabIndex = 17;
			this.add_site_button.Values.Text = "Add";
			this.add_site_button.Click += new System.EventHandler(this.add_site_button_Click);
			// 
			// remove_site_button
			// 
			this.remove_site_button.Location = new System.Drawing.Point(376, 342);
			this.remove_site_button.Name = "remove_site_button";
			this.remove_site_button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.remove_site_button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.remove_site_button.OverrideDefault.Back.ColorAngle = 45F;
			this.remove_site_button.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.remove_site_button.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.remove_site_button.OverrideDefault.Border.ColorAngle = 45F;
			this.remove_site_button.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.remove_site_button.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.remove_site_button.OverrideDefault.Border.Rounding = 20;
			this.remove_site_button.OverrideDefault.Border.Width = 1;
			this.remove_site_button.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.remove_site_button.Size = new System.Drawing.Size(65, 30);
			this.remove_site_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.remove_site_button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.remove_site_button.StateCommon.Back.ColorAngle = 45F;
			this.remove_site_button.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.remove_site_button.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(159)))), ((int)(((byte)(49)))));
			this.remove_site_button.StateCommon.Border.ColorAngle = 45F;
			this.remove_site_button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.remove_site_button.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.remove_site_button.StateCommon.Border.Rounding = 20;
			this.remove_site_button.StateCommon.Border.Width = 1;
			this.remove_site_button.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
			this.remove_site_button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.remove_site_button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.remove_site_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Black", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.remove_site_button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
			this.remove_site_button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
			this.remove_site_button.StatePressed.Back.ColorAngle = 135F;
			this.remove_site_button.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.remove_site_button.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(159)))), ((int)(((byte)(49)))));
			this.remove_site_button.StatePressed.Border.ColorAngle = 135F;
			this.remove_site_button.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.remove_site_button.StatePressed.Border.Rounding = 20;
			this.remove_site_button.StatePressed.Border.Width = 1;
			this.remove_site_button.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.remove_site_button.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.remove_site_button.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.remove_site_button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.remove_site_button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
			this.remove_site_button.StateTracking.Back.ColorAngle = 45F;
			this.remove_site_button.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.remove_site_button.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(94)))));
			this.remove_site_button.StateTracking.Border.ColorAngle = 45F;
			this.remove_site_button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.remove_site_button.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.remove_site_button.StateTracking.Border.Rounding = 20;
			this.remove_site_button.StateTracking.Border.Width = 1;
			this.remove_site_button.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.remove_site_button.TabIndex = 18;
			this.remove_site_button.Values.Text = "Remove";
			this.remove_site_button.Click += new System.EventHandler(this.remove_site_button_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(-163, 226);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(243, 201);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 19;
			this.pictureBox3.TabStop = false;
			// 
			// EditGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(668, 394);
			this.Controls.Add(this.remove_site_button);
			this.Controls.Add(this.add_site_button);
			this.Controls.Add(this.add_site_textbox);
			this.Controls.Add(this.group_name_textbox);
			this.Controls.Add(this.description_textbox);
			this.Controls.Add(this.sites_listbox);
			this.Controls.Add(this.save_button);
			this.Controls.Add(this.add_site_label);
			this.Controls.Add(this.sites_label);
			this.Controls.Add(this.group_name_label);
			this.Controls.Add(this.description_label);
			this.Controls.Add(this.pictureBox3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(684, 433);
			this.Name = "EditGroup";
			this.Palette = this.kryptonPalette1;
			this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
			this.ShowIcon = false;
			this.Text = "EditForm";
			this.Load += new System.EventHandler(this.EditForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.PictureBox pictureBox3;

		private ComponentFactory.Krypton.Toolkit.KryptonTextBox group_name_textbox;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox add_site_textbox;

		private ComponentFactory.Krypton.Toolkit.KryptonTextBox description_textbox;

		private ComponentFactory.Krypton.Toolkit.KryptonListBox sites_listbox;

		private ComponentFactory.Krypton.Toolkit.KryptonButton save_button;

		private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;

		#endregion

		private System.Windows.Forms.Label description_label;
		private System.Windows.Forms.Label group_name_label;
		private System.Windows.Forms.Label sites_label;
		private System.Windows.Forms.Label add_site_label;
		private ComponentFactory.Krypton.Toolkit.KryptonButton add_site_button;
		private ComponentFactory.Krypton.Toolkit.KryptonButton remove_site_button;
	}
}