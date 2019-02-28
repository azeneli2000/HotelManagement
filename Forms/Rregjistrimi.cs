using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualStudioAnalyzer.PrimaryEventCollector;
using System.Messaging;

namespace HotelManagment.Forms
{
	/// <summary>
	/// Summary description for Rregjistrimi.
	/// </summary>
	public class Rregjistrimi : System.Windows.Forms.Form
	{
		#region Private Declarations
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnAnullo;
		private VisionInfoSolutionLibrary.Label lblMesazh;
		private VisionInfoSolutionLibrary.TextBox txtSerial1;
		private VisionInfoSolutionLibrary.TextBox txtSerial3;
		private VisionInfoSolutionLibrary.TextBox txtSerial4;
		private VisionInfoSolutionLibrary.TextBox txtSerial2;
		private VisionInfoSolutionLibrary.TextBox txtSerial5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region Constructors & Destructors
		public Rregjistrimi()
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

		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnOK = new System.Windows.Forms.Button();
			this.btnAnullo = new System.Windows.Forms.Button();
			this.lblMesazh = new VisionInfoSolutionLibrary.Label();
			this.txtSerial1 = new VisionInfoSolutionLibrary.TextBox();
			this.txtSerial3 = new VisionInfoSolutionLibrary.TextBox();
			this.txtSerial4 = new VisionInfoSolutionLibrary.TextBox();
			this.txtSerial2 = new VisionInfoSolutionLibrary.TextBox();
			this.txtSerial5 = new VisionInfoSolutionLibrary.TextBox();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Enabled = false;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOK.Location = new System.Drawing.Point(96, 100);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(88, 23);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnAnullo
			// 
			this.btnAnullo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAnullo.Location = new System.Drawing.Point(204, 100);
			this.btnAnullo.Name = "btnAnullo";
			this.btnAnullo.Size = new System.Drawing.Size(88, 23);
			this.btnAnullo.TabIndex = 7;
			this.btnAnullo.Text = "Anullo";
			this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
			// 
			// lblMesazh
			// 
			this.lblMesazh.Location = new System.Drawing.Point(24, 16);
			this.lblMesazh.Name = "lblMesazh";
			this.lblMesazh.Size = new System.Drawing.Size(340, 36);
			this.lblMesazh.TabIndex = 2;
			this.lblMesazh.Text = "Ju lutemi jepni numrin serial te cilin e keni marre me ane te telefonit ose inter" +
				"netit";
			// 
			// txtSerial1
			// 
			this.txtSerial1.AutoSize = false;
			this.txtSerial1.DefaultErrorMessage = "";
			this.txtSerial1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtSerial1.FixedLength = false;
			this.txtSerial1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtSerial1.IsValid = true;
			this.txtSerial1.Location = new System.Drawing.Point(24, 64);
			this.txtSerial1.MaxLength = 5;
			this.txtSerial1.Name = "txtSerial1";
			this.txtSerial1.Required = false;
			this.txtSerial1.RequiredControlColor = System.Drawing.Color.White;
			this.txtSerial1.Size = new System.Drawing.Size(60, 20);
			this.txtSerial1.TabIndex = 0;
			this.txtSerial1.Text = "";
			this.txtSerial1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SerialKeyUp);
			this.txtSerial1.TextChanged += new System.EventHandler(this.SerialTextChanged);
			// 
			// txtSerial3
			// 
			this.txtSerial3.AutoSize = false;
			this.txtSerial3.DefaultErrorMessage = "";
			this.txtSerial3.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtSerial3.FixedLength = false;
			this.txtSerial3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtSerial3.IsValid = true;
			this.txtSerial3.Location = new System.Drawing.Point(168, 64);
			this.txtSerial3.MaxLength = 5;
			this.txtSerial3.Name = "txtSerial3";
			this.txtSerial3.Required = false;
			this.txtSerial3.RequiredControlColor = System.Drawing.Color.White;
			this.txtSerial3.Size = new System.Drawing.Size(60, 20);
			this.txtSerial3.TabIndex = 2;
			this.txtSerial3.Text = "";
			this.txtSerial3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SerialKeyUp);
			this.txtSerial3.TextChanged += new System.EventHandler(this.SerialTextChanged);
			// 
			// txtSerial4
			// 
			this.txtSerial4.AutoSize = false;
			this.txtSerial4.DefaultErrorMessage = "";
			this.txtSerial4.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtSerial4.FixedLength = false;
			this.txtSerial4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtSerial4.IsValid = true;
			this.txtSerial4.Location = new System.Drawing.Point(240, 64);
			this.txtSerial4.MaxLength = 5;
			this.txtSerial4.Name = "txtSerial4";
			this.txtSerial4.Required = false;
			this.txtSerial4.RequiredControlColor = System.Drawing.Color.White;
			this.txtSerial4.Size = new System.Drawing.Size(60, 20);
			this.txtSerial4.TabIndex = 3;
			this.txtSerial4.Text = "";
			this.txtSerial4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SerialKeyUp);
			this.txtSerial4.TextChanged += new System.EventHandler(this.SerialTextChanged);
			// 
			// txtSerial2
			// 
			this.txtSerial2.AutoSize = false;
			this.txtSerial2.DefaultErrorMessage = "";
			this.txtSerial2.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtSerial2.FixedLength = false;
			this.txtSerial2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtSerial2.IsValid = true;
			this.txtSerial2.Location = new System.Drawing.Point(96, 64);
			this.txtSerial2.MaxLength = 5;
			this.txtSerial2.Name = "txtSerial2";
			this.txtSerial2.Required = false;
			this.txtSerial2.RequiredControlColor = System.Drawing.Color.White;
			this.txtSerial2.Size = new System.Drawing.Size(60, 20);
			this.txtSerial2.TabIndex = 1;
			this.txtSerial2.Text = "";
			this.txtSerial2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SerialKeyUp);
			this.txtSerial2.TextChanged += new System.EventHandler(this.SerialTextChanged);
			// 
			// txtSerial5
			// 
			this.txtSerial5.AutoSize = false;
			this.txtSerial5.DefaultErrorMessage = "";
			this.txtSerial5.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtSerial5.FixedLength = false;
			this.txtSerial5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtSerial5.IsValid = true;
			this.txtSerial5.Location = new System.Drawing.Point(312, 64);
			this.txtSerial5.MaxLength = 5;
			this.txtSerial5.Name = "txtSerial5";
			this.txtSerial5.Required = false;
			this.txtSerial5.RequiredControlColor = System.Drawing.Color.White;
			this.txtSerial5.Size = new System.Drawing.Size(60, 20);
			this.txtSerial5.TabIndex = 4;
			this.txtSerial5.Text = "";
			this.txtSerial5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SerialKeyUp);
			this.txtSerial5.TextChanged += new System.EventHandler(this.SerialTextChanged);
			// 
			// Rregjistrimi
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(392, 134);
			this.Controls.Add(this.txtSerial5);
			this.Controls.Add(this.txtSerial2);
			this.Controls.Add(this.txtSerial4);
			this.Controls.Add(this.txtSerial3);
			this.Controls.Add(this.txtSerial1);
			this.Controls.Add(this.lblMesazh);
			this.Controls.Add(this.btnAnullo);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Rregjistrimi";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rregjistrimi";
			this.Load += new System.EventHandler(this.Rregjistrimi_Load);
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void Rregjistrimi_Load(object sender, System.EventArgs e)
		{
		
		}

		private void SerialTextChanged(object sender, System.EventArgs e)
		{
			string serial = this.txtSerial1.Text + "-" + this.txtSerial2.Text + "-" +
				this.txtSerial3.Text + "-" + this.txtSerial4.Text + "-" + this.txtSerial5.Text;
		}


		private void SerialKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			VisionInfoSolutionLibrary.TextBox txt = sender as VisionInfoSolutionLibrary.TextBox;
			if (txt.Text.Length >= 5 && Char.IsLetterOrDigit((char)e.KeyValue))
			{
				this.SelectNextControl(txt, true, true, true, true);
			}
			// Nese numri serial i futur eshte me 25 karaktere atehere kontrollojme nese numri eshte
			// ai i duhuri per te bere aktivizimin e programit
			if (this.txtSerial1.TextLength + this.txtSerial2.TextLength + this.txtSerial3.TextLength +
				this.txtSerial4.TextLength + this.txtSerial5.TextLength  == 25)
			{
				this.btnOK.Enabled = true;
				this.AcceptButton = btnOK;
			}
			else
				this.btnOK.Enabled = false;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			try
			{
				string serial = this.txtSerial1.Text + this.txtSerial2.Text + this.txtSerial3.Text +
					this.txtSerial4.Text + this.txtSerial5.Text;
				if (serial == RegistrationClass.GetEncryptedKeyFull())
				{
					int roomsCount = RegistrationClass.GetRoomsCount();
					RegistrationClass.StoreKeyToRegistry(serial);
					RegistrationClass.StoreKeyToRegistry("Vlera2", roomsCount.ToString().Length.ToString());
					MessageBox.Show("Rregjistrimi i programit u krye me sukses per " + roomsCount + " dhoma" +
						Environment.NewLine + "Ju lutemi hapni dhe mbyllni programin perseri qe ndryshimet te "
						+ "te pasqyrohen ne program.", "Rregjistrimi", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
					this.Close();
				}
				else
					MessageBox.Show("Numri serial qe ju futet nuk eshte i sakte. Ju lutemi provoni perseri ose merrni numrin serial nga VisionInfoSolution", "Rregjistrimi", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
			}
			catch(Exception ex)
			{
				return;
			}
		}

		private void btnAnullo_Click(object sender, System.EventArgs e)
		{
			this.Visible = false;
			this.Close();
			// Jep nje mesazh qe versioni i programit eshte trial
			System.Windows.Forms.MessageBox.Show("Ju veme ne dijeni qe programi HotelManager eshte ne versionin vleresues." +
				Environment.NewLine + "Per te pasur versionin e plote duhet te fusni numrin serial!", "Rregjistrimi",
				MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		#endregion
	}
}
