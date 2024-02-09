namespace DoNotWasteYourTime
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.app_name = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.home_page = new CustomControls.RJControls.RJButton();
			this.create_group_button = new CustomControls.RJControls.RJButton();
			this.groups_label = new System.Windows.Forms.Label();
			this.home_page_panel = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.home_page_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.home_page);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 468);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.panel2.Controls.Add(this.app_name);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 68);
			this.panel2.TabIndex = 2;
			// 
			// app_name
			// 
			this.app_name.AutoSize = true;
			this.app_name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.app_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.app_name.Location = new System.Drawing.Point(68, 12);
			this.app_name.Name = "app_name";
			this.app_name.Size = new System.Drawing.Size(240, 18);
			this.app_name.TabIndex = 1;
			this.app_name.Text = "DO NOT WASTE YOUR TİME";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(59, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// home_page
			// 
			this.home_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
			this.home_page.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
			this.home_page.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.home_page.BorderRadius = 0;
			this.home_page.BorderSize = 0;
			this.home_page.FlatAppearance.BorderSize = 0;
			this.home_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.home_page.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.home_page.ForeColor = System.Drawing.Color.White;
			this.home_page.Location = new System.Drawing.Point(0, 80);
			this.home_page.Margin = new System.Windows.Forms.Padding(0);
			this.home_page.Name = "home_page";
			this.home_page.Size = new System.Drawing.Size(200, 52);
			this.home_page.TabIndex = 0;
			this.home_page.Text = "HomePage";
			this.home_page.TextColor = System.Drawing.Color.White;
			this.home_page.UseVisualStyleBackColor = false;
			// 
			// create_group_button
			// 
			this.create_group_button.AutoSize = true;
			this.create_group_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.create_group_button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
			this.create_group_button.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.create_group_button.BorderRadius = 0;
			this.create_group_button.BorderSize = 0;
			this.create_group_button.FlatAppearance.BorderSize = 0;
			this.create_group_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.create_group_button.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
			this.create_group_button.ForeColor = System.Drawing.Color.White;
			this.create_group_button.Location = new System.Drawing.Point(505, 14);
			this.create_group_button.Margin = new System.Windows.Forms.Padding(0);
			this.create_group_button.Name = "create_group_button";
			this.create_group_button.Size = new System.Drawing.Size(125, 43);
			this.create_group_button.TabIndex = 4;
			this.create_group_button.Text = "Create";
			this.create_group_button.TextColor = System.Drawing.Color.White;
			this.create_group_button.UseVisualStyleBackColor = false;
			this.create_group_button.Click += new System.EventHandler(this.create_group_button_Click);
			// 
			// groups_label
			// 
			this.groups_label.AutoSize = true;
			this.groups_label.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groups_label.Location = new System.Drawing.Point(15, 21);
			this.groups_label.Name = "groups_label";
			this.groups_label.Size = new System.Drawing.Size(69, 24);
			this.groups_label.TabIndex = 0;
			this.groups_label.Text = "Groups";
			// 
			// home_page_panel
			// 
			this.home_page_panel.AutoSize = true;
			this.home_page_panel.Controls.Add(this.create_group_button);
			this.home_page_panel.Controls.Add(this.flowLayoutPanel1);
			this.home_page_panel.Controls.Add(this.groups_label);
			this.home_page_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.home_page_panel.Location = new System.Drawing.Point(200, 0);
			this.home_page_panel.Name = "home_page_panel";
			this.home_page_panel.Size = new System.Drawing.Size(649, 468);
			this.home_page_panel.TabIndex = 3;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 75);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(649, 393);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(849, 468);
			this.Controls.Add(this.home_page_panel);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(865, 507);
			this.MinimumSize = new System.Drawing.Size(865, 507);
			this.Name = "Form1";
			this.Text = "DNWYT";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.home_page_panel.ResumeLayout(false);
			this.home_page_panel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CustomControls.RJControls.RJButton home_page;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label app_name;
		private CustomControls.RJControls.RJButton create_group_button;
		private System.Windows.Forms.Label groups_label;
		private System.Windows.Forms.Panel home_page_panel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}

