using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace HotelManagment
{
	/// <summary>
	/// Summary description for SplashScreen.
	/// </summary>
	public class SplashScreen : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components = null;

		public SplashScreen()
		{
			this.Cursor = Cursors.WaitCursor;
			InitializeComponent();
			// 3 rreshtat ne vazhdim sherbejne per te eliminuar nje bug te Visual Studio-s, qe ka
			// te beje me paraqitjen korrekte te imazhit qe eshte ne forme
			Bitmap b = new Bitmap(this.BackgroundImage);
			b.MakeTransparent(b.GetPixel(1, 1));
			this.BackgroundImage = b;
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

		/// <summary>
		///  Hap formen Splash
		/// </summary>
		public void DoSplash()
		{
			//SplashScreen splash = new SplashScreen();
			this.ShowDialog();
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SplashScreen));
			// 
			// SplashScreen
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(544, 340);
			this.ControlBox = false;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "SplashScreen";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SplashScreen";

		}
		#endregion
	}
}
