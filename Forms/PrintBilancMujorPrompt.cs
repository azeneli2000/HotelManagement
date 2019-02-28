using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotelManagment.Forms
{
	/// <summary>
	/// Summary description for PrintBilancPrompt.
	/// </summary>
	public class PrintBilancMujorPrompt : VisionInfoSolutionLibrary.Form
	{
		#region Private Fields
		private VisionInfoSolutionLibrary.Button btnAnullo;
		private VisionInfoSolutionLibrary.Button btnOK;
		private System.ComponentModel.IContainer components;
		#endregion
		private VisionInfoSolutionLibrary.RadioButton rbGrafik;
		private VisionInfoSolutionLibrary.RadioButton rbBilanc;

		#region Public Field
		public int result = 0;
		#endregion

		public PrintBilancMujorPrompt()
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
		/// Konstruktor me 1 parameter qe percakton tekstin e radiobuttons ne varesi te parametrit
		/// </summary>
		/// <param name="viti">viti per te cilin do te printohet bilanci</param>
		public PrintBilancMujorPrompt(string viti)
		{
			InitializeComponent();
			// Nese dateDitor eshte string bosh atehere kjo do te thote qe nuk mund te behet printimi
			// i bilancit te nje dite
			this.rbBilanc.Text = "Printo bilancin per vitin " + viti;
			this.rbGrafik.Text = "Printo grafikun e bilancit per vitin " + viti;
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
			this.components = new System.ComponentModel.Container();
			this.btnAnullo = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnOK = new VisionInfoSolutionLibrary.Button(this.components);
			this.rbGrafik = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbBilanc = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(386, 24);
			// 
			// btnAnullo
			// 
			this.btnAnullo.BackColor = System.Drawing.Color.Blue;
			this.btnAnullo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAnullo.DoValidation = true;
			this.btnAnullo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAnullo.Location = new System.Drawing.Point(256, 56);
			this.btnAnullo.Name = "btnAnullo";
			this.btnAnullo.Size = new System.Drawing.Size(90, 21);
			this.btnAnullo.TabIndex = 0;
			this.btnAnullo.Text = "Anullo";
			this.btnAnullo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.Blue;
			this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOK.DoValidation = true;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.Location = new System.Drawing.Point(256, 24);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(90, 21);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// rbGrafik
			// 
			this.rbGrafik.BackColor = System.Drawing.Color.Transparent;
			this.rbGrafik.Location = new System.Drawing.Point(32, 56);
			this.rbGrafik.Name = "rbGrafik";
			this.rbGrafik.Size = new System.Drawing.Size(192, 24);
			this.rbGrafik.TabIndex = 2;
			// 
			// rbBilanc
			// 
			this.rbBilanc.BackColor = System.Drawing.Color.Transparent;
			this.rbBilanc.Checked = true;
			this.rbBilanc.Location = new System.Drawing.Point(32, 24);
			this.rbBilanc.Name = "rbBilanc";
			this.rbBilanc.Size = new System.Drawing.Size(192, 24);
			this.rbBilanc.TabIndex = 3;
			// 
			// PrintBilancMujorPrompt
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = false;
			this.ClientSize = new System.Drawing.Size(386, 104);
			this.ControlBox = true;
			this.Controls.Add(this.rbBilanc);
			this.Controls.Add(this.rbGrafik);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnAnullo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PrintBilancMujorPrompt";
			this.ShfaqTitull = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Printimi i Bilancit";
			this.TitullGjeresi = 386;
			this.Controls.SetChildIndex(this.btnAnullo, 0);
			this.Controls.SetChildIndex(this.btnOK, 0);
			this.Controls.SetChildIndex(this.rbGrafik, 0);
			this.Controls.SetChildIndex(this.rbBilanc, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if (this.rbBilanc.Checked)
				result = 1;
			else if (this.rbGrafik.Checked)
				result = 2;
			this.Hide();
		}

		private void btnAnullo_Click(object sender, System.EventArgs e)
		{
			this.result = 0;
			this.Hide();
		}
	}
}
