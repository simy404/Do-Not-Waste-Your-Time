using DoNotWasteYourTime.CustomTools;

namespace DoNotWasteYourTime
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGroup));
			this.description_label = new System.Windows.Forms.Label();
			this.group_name_label = new System.Windows.Forms.Label();
			this.sites_listbox = new System.Windows.Forms.ListBox();
			this.sites_label = new System.Windows.Forms.Label();
			this.add_site_label = new System.Windows.Forms.Label();
			this.add_site_button = new System.Windows.Forms.PictureBox();
			this.add_site_textbox = new RJTextBox();
			this.save_button = new RJButton();
			this.group_name_textbox = new RJTextBox();
			this.description_textbox = new RJTextBox();
			this.remove_site_button = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.add_site_button)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.remove_site_button)).BeginInit();
			this.SuspendLayout();
			// 
			// description_label
			// 
			this.description_label.AutoSize = true;
			this.description_label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.description_label.Location = new System.Drawing.Point(6, 65);
			this.description_label.Name = "description_label";
			this.description_label.Size = new System.Drawing.Size(92, 18);
			this.description_label.TabIndex = 1;
			this.description_label.Text = "Description :";
			// 
			// group_name_label
			// 
			this.group_name_label.AutoSize = true;
			this.group_name_label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.group_name_label.Location = new System.Drawing.Point(0, 26);
			this.group_name_label.Name = "group_name_label";
			this.group_name_label.Size = new System.Drawing.Size(98, 18);
			this.group_name_label.TabIndex = 3;
			this.group_name_label.Text = "Group Name :";
			// 
			// sites_listbox
			// 
			this.sites_listbox.FormattingEnabled = true;
			this.sites_listbox.Location = new System.Drawing.Point(105, 167);
			this.sites_listbox.Name = "sites_listbox";
			this.sites_listbox.Size = new System.Drawing.Size(183, 160);
			this.sites_listbox.TabIndex = 4;
			// 
			// sites_label
			// 
			this.sites_label.AutoSize = true;
			this.sites_label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sites_label.Location = new System.Drawing.Point(51, 167);
			this.sites_label.Name = "sites_label";
			this.sites_label.Size = new System.Drawing.Size(47, 18);
			this.sites_label.TabIndex = 5;
			this.sites_label.Text = "Sites :";
			// 
			// add_site_label
			// 
			this.add_site_label.AutoSize = true;
			this.add_site_label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add_site_label.Location = new System.Drawing.Point(25, 128);
			this.add_site_label.Name = "add_site_label";
			this.add_site_label.Size = new System.Drawing.Size(73, 18);
			this.add_site_label.TabIndex = 8;
			this.add_site_label.Text = "Add Site :";
			// 
			// add_site_button
			// 
			this.add_site_button.Image = ((System.Drawing.Image)(resources.GetObject("add_site_button.Image")));
			this.add_site_button.Location = new System.Drawing.Point(295, 128);
			this.add_site_button.Name = "add_site_button";
			this.add_site_button.Size = new System.Drawing.Size(41, 31);
			this.add_site_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.add_site_button.TabIndex = 9;
			this.add_site_button.TabStop = false;
			this.add_site_button.Click += new System.EventHandler(this.add_site_button_Click);
			// 
			// add_site_textbox
			// 
			this.add_site_textbox.BackColor = System.Drawing.SystemColors.Window;
			this.add_site_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
			this.add_site_textbox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.add_site_textbox.BorderSize = 2;
			this.add_site_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add_site_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
			this.add_site_textbox.Location = new System.Drawing.Point(105, 128);
			this.add_site_textbox.Margin = new System.Windows.Forms.Padding(4);
			this.add_site_textbox.Multiline = false;
			this.add_site_textbox.Name = "add_site_textbox";
			this.add_site_textbox.Padding = new System.Windows.Forms.Padding(7);
			this.add_site_textbox.PasswordChar = false;
			this.add_site_textbox.Size = new System.Drawing.Size(183, 31);
			this.add_site_textbox.TabIndex = 7;
			this.add_site_textbox.Texts = "";
			this.add_site_textbox.UnderlinedStyle = false;
			// 
			// save_button
			// 
			this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.save_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.save_button.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.save_button.BorderRadius = 0;
			this.save_button.BorderSize = 0;
			this.save_button.FlatAppearance.BorderSize = 0;
			this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.save_button.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.save_button.ForeColor = System.Drawing.Color.White;
			this.save_button.Location = new System.Drawing.Point(138, 342);
			this.save_button.Name = "save_button";
			this.save_button.Size = new System.Drawing.Size(150, 40);
			this.save_button.TabIndex = 6;
			this.save_button.Text = "Save";
			this.save_button.TextColor = System.Drawing.Color.White;
			this.save_button.UseVisualStyleBackColor = false;
			this.save_button.Click += new System.EventHandler(this.save_button_Click);
			// 
			// group_name_textbox
			// 
			this.group_name_textbox.BackColor = System.Drawing.SystemColors.Window;
			this.group_name_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
			this.group_name_textbox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.group_name_textbox.BorderSize = 2;
			this.group_name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.group_name_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
			this.group_name_textbox.Location = new System.Drawing.Point(105, 26);
			this.group_name_textbox.Margin = new System.Windows.Forms.Padding(4);
			this.group_name_textbox.Multiline = false;
			this.group_name_textbox.Name = "group_name_textbox";
			this.group_name_textbox.Padding = new System.Windows.Forms.Padding(7);
			this.group_name_textbox.PasswordChar = false;
			this.group_name_textbox.Size = new System.Drawing.Size(183, 31);
			this.group_name_textbox.TabIndex = 2;
			this.group_name_textbox.Texts = "";
			this.group_name_textbox.UnderlinedStyle = false;
			// 
			// description_textbox
			// 
			this.description_textbox.BackColor = System.Drawing.SystemColors.Window;
			this.description_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
			this.description_textbox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.description_textbox.BorderSize = 2;
			this.description_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.description_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
			this.description_textbox.Location = new System.Drawing.Point(105, 65);
			this.description_textbox.Margin = new System.Windows.Forms.Padding(4);
			this.description_textbox.Multiline = true;
			this.description_textbox.Name = "description_textbox";
			this.description_textbox.Padding = new System.Windows.Forms.Padding(7);
			this.description_textbox.PasswordChar = false;
			this.description_textbox.Size = new System.Drawing.Size(183, 50);
			this.description_textbox.TabIndex = 0;
			this.description_textbox.Texts = "";
			this.description_textbox.UnderlinedStyle = false;
			// 
			// remove_site_button
			// 
			this.remove_site_button.Image = ((System.Drawing.Image)(resources.GetObject("remove_site_button.Image")));
			this.remove_site_button.Location = new System.Drawing.Point(295, 167);
			this.remove_site_button.Name = "remove_site_button";
			this.remove_site_button.Size = new System.Drawing.Size(41, 31);
			this.remove_site_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.remove_site_button.TabIndex = 10;
			this.remove_site_button.TabStop = false;
			this.remove_site_button.Click += new System.EventHandler(this.remove_site_button_Click);
			// 
			// EditGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 426);
			this.Controls.Add(this.remove_site_button);
			this.Controls.Add(this.add_site_button);
			this.Controls.Add(this.add_site_label);
			this.Controls.Add(this.add_site_textbox);
			this.Controls.Add(this.save_button);
			this.Controls.Add(this.sites_label);
			this.Controls.Add(this.sites_listbox);
			this.Controls.Add(this.group_name_label);
			this.Controls.Add(this.group_name_textbox);
			this.Controls.Add(this.description_label);
			this.Controls.Add(this.description_textbox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(1000, 1000);
			this.Name = "EditGroup";
			this.Text = "EditForm";
			this.Load += new System.EventHandler(this.EditForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.add_site_button)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.remove_site_button)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RJTextBox description_textbox;
		private System.Windows.Forms.Label description_label;
		private RJTextBox group_name_textbox;
		private System.Windows.Forms.Label group_name_label;
		private System.Windows.Forms.ListBox sites_listbox;
		private System.Windows.Forms.Label sites_label;
		private RJButton save_button;
		private System.Windows.Forms.Label add_site_label;
		private RJTextBox add_site_textbox;
		private System.Windows.Forms.PictureBox add_site_button;
		private System.Windows.Forms.PictureBox remove_site_button;
	}
}