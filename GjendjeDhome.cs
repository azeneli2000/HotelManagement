using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using VisionInfoSolutionLibrary;

namespace HotelManagment
{
	/// <summary>
	/// Summary description for GjendjeDhome.
	/// </summary>
	public class GjendjeDhome : VisionInfoSolutionLibrary.Form
	{
		private System.ComponentModel.IContainer components = null;

		public GjendjeDhome()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// GjendjeDhome
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(688, 292);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GjendjeDhome";
			this.Text = "GjendjeDhome";

		}
		#endregion
	}
}
