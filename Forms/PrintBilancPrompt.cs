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
	public class PrintBilancPrompt : VisionInfoSolutionLibrary.Form
	{
		#region Private Fields
		private VisionInfoSolutionLibrary.Button btnAnullo;
		private VisionInfoSolutionLibrary.Button btnOK;
		private VisionInfoSolutionLibrary.RadioButton rbDitor;
		private VisionInfoSolutionLibrary.RadioButton rbData;
		private System.ComponentModel.IContainer components;
		#endregion

		#region Public Field
		public int result = 0;
		#endregion

		public PrintBilancPrompt()
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
		/// Konstruktor me 3 parametra qe percakton vetite e radioButtons te formes sic jane
		/// Enabled, Checked dhe Text
		/// </summary>
		/// <param name="dateFillimi"></param>
		/// <param name="dateMbarimi"></param>
		/// <param name="dateDitor"></param>
		public PrintBilancPrompt(string dateFillimi, string dateMbarimi, string dateDitor)
		{
			InitializeComponent();
			// Nese dateDitor eshte string bosh atehere kjo do te thote qe nuk mund te behet printimi
			// i bilancit te nje dite
			if (dateDitor == "")
			{
				this.rbDitor.Checked = false;
				this.rbDitor.Enabled = false;
				this.rbData.Checked = true;
				this.rbData.Text = "Printo Bilancin nga data " + dateFillimi + "deri ne daten " + dateMbarimi;
				this.rbDitor.Text = "Printo Bilancin per daten";
			}
			else
			{
				this.rbData.Text = "Printo Bilancin nga data " + dateFillimi + "deri ne daten " + dateMbarimi;
				this.rbDitor.Text = "Printo Bilancin per daten " + dateMbarimi;
			}
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
			this.rbDitor = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbData = new VisionInfoSolutionLibrary.RadioButton(this.components);
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
			// rbDitor
			// 
			this.rbDitor.BackColor = System.Drawing.Color.Transparent;
			this.rbDitor.Location = new System.Drawing.Point(24, 24);
			this.rbDitor.Name = "rbDitor";
			this.rbDitor.Size = new System.Drawing.Size(192, 24);
			this.rbDitor.TabIndex = 2;
			// 
			// rbData
			// 
			this.rbData.BackColor = System.Drawing.Color.Transparent;
			this.rbData.Checked = true;
			this.rbData.Location = new System.Drawing.Point(24, 56);
			this.rbData.Name = "rbData";
			this.rbData.Size = new System.Drawing.Size(192, 24);
			this.rbData.TabIndex = 3;
			// 
			// PrintBilancPrompt
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = false;
			this.ClientSize = new System.Drawing.Size(386, 104);
			this.ControlBox = true;
			this.Controls.Add(this.rbData);
			this.Controls.Add(this.rbDitor);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnAnullo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PrintBilancPrompt";
			this.ShfaqTitull = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Printimi i Bilancit";
			this.TitullGjeresi = 386;
			this.Controls.SetChildIndex(this.btnAnullo, 0);
			this.Controls.SetChildIndex(this.btnOK, 0);
			this.Controls.SetChildIndex(this.rbDitor, 0);
			this.Controls.SetChildIndex(this.rbData, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if (this.rbData.Checked)
				result = 1;
			else if (this.rbDitor.Checked)
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
