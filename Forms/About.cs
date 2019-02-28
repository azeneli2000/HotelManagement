using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagment.Forms
{
	public class About : VisionInfoSolutionLibrary.Form
	{
		private VisionInfoSolutionLibrary.Label lblAdresa;
		private VisionInfoSolutionLibrary.Label lblAdresaTxt;
		private VisionInfoSolutionLibrary.Label lblTelTxt;
		private VisionInfoSolutionLibrary.Label lblEmailTxt;
		private VisionInfoSolutionLibrary.Label lblTel;
		private VisionInfoSolutionLibrary.Label lblEmail;
		private VisionInfoSolutionLibrary.Label lblWebSite;
		private System.Windows.Forms.LinkLabel lblWebSiteTxt;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.Button btnOK;
		private System.Windows.Forms.PictureBox pbIcon;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.ComponentModel.IContainer components = null;

		public About()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(About));
			this.lblAdresa = new VisionInfoSolutionLibrary.Label();
			this.lblAdresaTxt = new VisionInfoSolutionLibrary.Label();
			this.lblTelTxt = new VisionInfoSolutionLibrary.Label();
			this.lblEmailTxt = new VisionInfoSolutionLibrary.Label();
			this.lblTel = new VisionInfoSolutionLibrary.Label();
			this.lblEmail = new VisionInfoSolutionLibrary.Label();
			this.lblWebSite = new VisionInfoSolutionLibrary.Label();
			this.lblWebSiteTxt = new System.Windows.Forms.LinkLabel();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.pbIcon = new System.Windows.Forms.PictureBox();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.btnOK = new VisionInfoSolutionLibrary.Button(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(390, 24);
			// 
			// lblAdresa
			// 
			this.lblAdresa.BackColor = System.Drawing.Color.Transparent;
			this.lblAdresa.Location = new System.Drawing.Point(16, 160);
			this.lblAdresa.Name = "lblAdresa";
			this.lblAdresa.Size = new System.Drawing.Size(72, 20);
			this.lblAdresa.TabIndex = 1;
			this.lblAdresa.Text = "Adresa";
			// 
			// lblAdresaTxt
			// 
			this.lblAdresaTxt.BackColor = System.Drawing.Color.Transparent;
			this.lblAdresaTxt.Location = new System.Drawing.Point(100, 160);
			this.lblAdresaTxt.Name = "lblAdresaTxt";
			this.lblAdresaTxt.Size = new System.Drawing.Size(144, 20);
			this.lblAdresaTxt.TabIndex = 2;
			this.lblAdresaTxt.Text = "Rruga Muhamet Gjollesha";
			// 
			// lblTelTxt
			// 
			this.lblTelTxt.BackColor = System.Drawing.Color.Transparent;
			this.lblTelTxt.Location = new System.Drawing.Point(100, 188);
			this.lblTelTxt.Name = "lblTelTxt";
			this.lblTelTxt.Size = new System.Drawing.Size(144, 20);
			this.lblTelTxt.TabIndex = 3;
			this.lblTelTxt.Text = "(+355) 69 20 99 613";
			// 
			// lblEmailTxt
			// 
			this.lblEmailTxt.BackColor = System.Drawing.Color.Transparent;
			this.lblEmailTxt.Location = new System.Drawing.Point(100, 216);
			this.lblEmailTxt.Name = "lblEmailTxt";
			this.lblEmailTxt.Size = new System.Drawing.Size(148, 20);
			this.lblEmailTxt.TabIndex = 4;
			this.lblEmailTxt.Text = "info@visioninfosolution.com";
			// 
			// lblTel
			// 
			this.lblTel.BackColor = System.Drawing.Color.Transparent;
			this.lblTel.Location = new System.Drawing.Point(16, 188);
			this.lblTel.Name = "lblTel";
			this.lblTel.Size = new System.Drawing.Size(72, 20);
			this.lblTel.TabIndex = 5;
			this.lblTel.Text = "Tel";
			// 
			// lblEmail
			// 
			this.lblEmail.BackColor = System.Drawing.Color.Transparent;
			this.lblEmail.Location = new System.Drawing.Point(16, 216);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(64, 20);
			this.lblEmail.TabIndex = 6;
			this.lblEmail.Text = "E-Mail";
			// 
			// lblWebSite
			// 
			this.lblWebSite.BackColor = System.Drawing.Color.Transparent;
			this.lblWebSite.Location = new System.Drawing.Point(16, 244);
			this.lblWebSite.Name = "lblWebSite";
			this.lblWebSite.Size = new System.Drawing.Size(76, 20);
			this.lblWebSite.TabIndex = 7;
			this.lblWebSite.Text = "Web Site";
			// 
			// lblWebSiteTxt
			// 
			this.lblWebSiteTxt.BackColor = System.Drawing.Color.Transparent;
			this.lblWebSiteTxt.Location = new System.Drawing.Point(100, 244);
			this.lblWebSiteTxt.Name = "lblWebSiteTxt";
			this.lblWebSiteTxt.Size = new System.Drawing.Size(152, 20);
			this.lblWebSiteTxt.TabIndex = 9;
			this.lblWebSiteTxt.TabStop = true;
			this.lblWebSiteTxt.Text = "www.visioninfosolution.com";
			this.toolTips.SetToolTip(this.lblWebSiteTxt, "Kliko ketu per te shkuar ne faqen e internetit te programit");
			this.lblWebSiteTxt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblWebSiteTxt_LinkClicked);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(12, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(412, 24);
			this.label1.TabIndex = 10;
			this.label1.Text = "Copyright© 2006 VisionInfoSolutionLibrary. Te gjitha te drejtat e rezervuara";
			// 
			// pbIcon
			// 
			this.pbIcon.BackColor = System.Drawing.Color.Transparent;
			this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
			this.pbIcon.Location = new System.Drawing.Point(256, 24);
			this.pbIcon.Name = "pbIcon";
			this.pbIcon.Size = new System.Drawing.Size(56, 56);
			this.pbIcon.TabIndex = 11;
			this.pbIcon.TabStop = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 20);
			this.label2.TabIndex = 12;
			this.label2.Text = "Hotel Manager        Version 1.0";
			// 
			// btnOK
			// 
			this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOK.DoValidation = true;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.Location = new System.Drawing.Point(156, 316);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(90, 21);
			this.btnOK.TabIndex = 13;
			this.btnOK.Text = "OK";
			this.btnOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(260, 140);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(244, 156);
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// About
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = false;
			this.ClientSize = new System.Drawing.Size(522, 356);
			this.ControlBox = true;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pbIcon);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblWebSiteTxt);
			this.Controls.Add(this.lblWebSite);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblTel);
			this.Controls.Add(this.lblEmailTxt);
			this.Controls.Add(this.lblTelTxt);
			this.Controls.Add(this.lblAdresaTxt);
			this.Controls.Add(this.lblAdresa);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.ShfaqTitull = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rreth Hotel Manager";
			this.TitullGjeresi = 390;
			this.Load += new System.EventHandler(this.About_Load);
			this.Controls.SetChildIndex(this.lblAdresa, 0);
			this.Controls.SetChildIndex(this.lblAdresaTxt, 0);
			this.Controls.SetChildIndex(this.lblTelTxt, 0);
			this.Controls.SetChildIndex(this.lblEmailTxt, 0);
			this.Controls.SetChildIndex(this.lblTel, 0);
			this.Controls.SetChildIndex(this.lblEmail, 0);
			this.Controls.SetChildIndex(this.lblWebSite, 0);
			this.Controls.SetChildIndex(this.lblWebSiteTxt, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.pbIcon, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.btnOK, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void lblWebSiteTxt_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.visioninfosolution.com");
		}

		private void About_Load(object sender, System.EventArgs e)
		{
			// 6 rreshtat ne vazhdim sherbejne per te eliminuar nje bug te Visual Studio-s, qe ka
			// te beje me paraqitjen korrekte te imazhit qe eshte ne forme
//			Bitmap b = new Bitmap(this.pbIcon.Image);
//			b.MakeTransparent(Color.White);
//			this.pbIcon.Image = b;
//			Bitmap b1 = new Bitmap(this.pictureBox1.Image);
//			b1.MakeTransparent(Color.White);
//			this.pictureBox1.Image = b1;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
		}
	}
}

