using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagment.Forms
{
	public class BrowserContainer : VisionInfoSolutionLibrary.Form
	{
		private VisionInfoSolutionLibrary.WebBrowser webBrowser1;
		private System.ComponentModel.IContainer components = null;

		public BrowserContainer()
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
			this.webBrowser1 = new VisionInfoSolutionLibrary.WebBrowser();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(0, 0);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Office2003 = true;
			this.webBrowser1.Size = new System.Drawing.Size(936, 468);
			this.webBrowser1.TabIndex = 1;
			// 
			// BrowserContainer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(936, 468);
			this.Controls.Add(this.webBrowser1);
			this.Name = "BrowserContainer";
			this.Text = "Ndihma";
			this.Load += new System.EventHandler(this.BrowserContainer_Load);
			this.Controls.SetChildIndex(this.webBrowser1, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void BrowserContainer_Load(object sender, System.EventArgs e)
		{
			this.webBrowser1.Navigate(Application.StartupPath + "\\HelpBiblioteka\\" + "Help.chm");
		}
	}
}

