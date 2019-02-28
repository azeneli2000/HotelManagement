using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotelManagment.Forms
{
	/// <summary>
	/// Summary description for NumriSerial.
	/// </summary>
	public class NumriSerial : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.TextBox txtNumerSerial;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public NumriSerial()
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.txtNumerSerial = new VisionInfoSolutionLibrary.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(144, 104);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(364, 52);
			this.label1.TabIndex = 1;
			this.label1.Text = "Dergojeni numrin me poshte dhe emrin e hotelit tuaj ne adresen info@visioninfosol" +
				"ution.com per te bere rregjistrimin e programit ose telefononi ne numrat (+355)6" +
				"92099613 ose ne  (+355)4251972";
			// 
			// txtNumerSerial
			// 
			this.txtNumerSerial.AutoSize = false;
			this.txtNumerSerial.DefaultErrorMessage = "";
			this.txtNumerSerial.DesabledControlColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtNumerSerial.FixedLength = false;
			this.txtNumerSerial.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtNumerSerial.IsValid = true;
			this.txtNumerSerial.Location = new System.Drawing.Point(36, 72);
			this.txtNumerSerial.Name = "txtNumerSerial";
			this.txtNumerSerial.ReadOnly = true;
			this.txtNumerSerial.Required = false;
			this.txtNumerSerial.RequiredControlColor = System.Drawing.Color.White;
			this.txtNumerSerial.Size = new System.Drawing.Size(304, 20);
			this.txtNumerSerial.TabIndex = 2;
			this.txtNumerSerial.Text = "";
			// 
			// NumriSerial
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(426, 138);
			this.Controls.Add(this.txtNumerSerial);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NumriSerial";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NumriSerial";
			this.Load += new System.EventHandler(this.NumriSerial_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void NumriSerial_Load(object sender, System.EventArgs e)
		{
			this.txtNumerSerial.Text = RegistrationClass.GetKey();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
