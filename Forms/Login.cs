using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagment.Forms
{
	/// <summary>
	/// Summary description for Login.
	/// </summary>
	public class Login : VisionInfoSolutionLibrary.Form
	{
		private VisionInfoSolutionLibrary.Button btnOK;
		private VisionInfoSolutionLibrary.Button btnAnullo;
		private VisionInfoSolutionLibrary.Label lblEmri;
		private VisionInfoSolutionLibrary.Label lblFjalekalimi;
		private VisionInfoSolutionLibrary.TextBox txtFjalekalimi;
		private VisionInfoSolutionLibrary.TextBox txtEmri;
		private System.ComponentModel.IContainer components;
		private string perdoruesi = "";
		public static string emer;
		public static string fjalekalim;
		public static int rolID;
		public static int userId;

		public Login()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Login));
			this.btnOK = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnAnullo = new VisionInfoSolutionLibrary.Button(this.components);
			this.lblEmri = new VisionInfoSolutionLibrary.Label();
			this.lblFjalekalimi = new VisionInfoSolutionLibrary.Label();
			this.txtFjalekalimi = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(334, 24);
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.Blue;
			this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOK.DoValidation = true;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.Location = new System.Drawing.Point(40, 120);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(90, 21);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnAnullo
			// 
			this.btnAnullo.BackColor = System.Drawing.Color.Blue;
			this.btnAnullo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAnullo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAnullo.DoValidation = true;
			this.btnAnullo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAnullo.Location = new System.Drawing.Point(200, 120);
			this.btnAnullo.Name = "btnAnullo";
			this.btnAnullo.Size = new System.Drawing.Size(90, 21);
			this.btnAnullo.TabIndex = 1;
			this.btnAnullo.Text = "Anullo";
			this.btnAnullo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
			// 
			// lblEmri
			// 
			this.lblEmri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmri.Location = new System.Drawing.Point(16, 24);
			this.lblEmri.Name = "lblEmri";
			this.lblEmri.Size = new System.Drawing.Size(100, 20);
			this.lblEmri.TabIndex = 2;
			this.lblEmri.Text = "Emri i perdoruesit";
			// 
			// lblFjalekalimi
			// 
			this.lblFjalekalimi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblFjalekalimi.Location = new System.Drawing.Point(16, 56);
			this.lblFjalekalimi.Name = "lblFjalekalimi";
			this.lblFjalekalimi.Size = new System.Drawing.Size(100, 20);
			this.lblFjalekalimi.TabIndex = 3;
			this.lblFjalekalimi.Text = "Fjalekalimi";
			// 
			// txtFjalekalimi
			// 
			this.txtFjalekalimi.AutoSize = false;
			this.txtFjalekalimi.DefaultErrorMessage = "";
			this.txtFjalekalimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtFjalekalimi.FixedLength = false;
			this.txtFjalekalimi.IsValid = true;
			this.txtFjalekalimi.Location = new System.Drawing.Point(128, 56);
			this.txtFjalekalimi.Name = "txtFjalekalimi";
			this.txtFjalekalimi.PasswordChar = '*';
			this.txtFjalekalimi.Required = false;
			this.txtFjalekalimi.RequiredControlColor = System.Drawing.Color.White;
			this.txtFjalekalimi.Size = new System.Drawing.Size(164, 20);
			this.txtFjalekalimi.TabIndex = 4;
			this.txtFjalekalimi.Text = "";
			this.txtFjalekalimi.TextChanged += new System.EventHandler(this.txtFjalekalimi_TextChanged);
			// 
			// txtEmri
			// 
			this.txtEmri.AutoSize = false;
			this.txtEmri.DefaultErrorMessage = "";
			this.txtEmri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri.FixedLength = false;
			this.txtEmri.IsValid = true;
			this.txtEmri.Location = new System.Drawing.Point(128, 24);
			this.txtEmri.Name = "txtEmri";
			this.txtEmri.Required = false;
			this.txtEmri.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri.Size = new System.Drawing.Size(164, 20);
			this.txtEmri.TabIndex = 5;
			this.txtEmri.Text = "";
			this.txtEmri.TextChanged += new System.EventHandler(this.txtEmri_TextChanged);
			// 
			// Login
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = false;
			this.CancelButton = this.btnAnullo;
			this.ClientSize = new System.Drawing.Size(334, 180);
			this.ControlBox = true;
			this.Controls.Add(this.txtEmri);
			this.Controls.Add(this.txtFjalekalimi);
			this.Controls.Add(this.lblFjalekalimi);
			this.Controls.Add(this.lblEmri);
			this.Controls.Add(this.btnAnullo);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Login";
			this.ShfaqTitull = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.TitullGjeresi = 334;
			this.Load += new System.EventHandler(this.Login_Load);
			this.Closed += new System.EventHandler(this.Login_Closed);
			this.Activated += new System.EventHandler(this.Login_Activated);
			this.Controls.SetChildIndex(this.btnOK, 0);
			this.Controls.SetChildIndex(this.btnAnullo, 0);
			this.Controls.SetChildIndex(this.lblEmri, 0);
			this.Controls.SetChildIndex(this.lblFjalekalimi, 0);
			this.Controls.SetChildIndex(this.txtFjalekalimi, 0);
			this.Controls.SetChildIndex(this.txtEmri, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void Login_Load(object sender, System.EventArgs e)
		{
			this.txtEmri.TabIndex = 0;
			this.txtEmri.BackColor = System.Drawing.Color.White;
			this.txtFjalekalimi.TabIndex = 1;
			this.txtFjalekalimi.BackColor = System.Drawing.Color.White;
			this.btnOK.TabIndex = 2;
			this.btnAnullo.TabIndex = 3;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			bool sukses = Login.Logimi(this.txtEmri.Text, this.txtFjalekalimi.Text);
			if (!sukses)
			{
				this.error.SetError(this.btnOK, "Emri i perdoruesit ose fjalekalimi nuk jane te sakte");
				this.txtEmri.Focus();
				return;
			}
			else
			{
				Login.emer = this.txtEmri.Text;
				//this.emer = this.txtEmri.Text;
				Login.fjalekalim = this.txtFjalekalimi.Text;
				this.error.SetError(this.btnOK, "");
			}
			this.Close();
		}

		public static bool Logimi(string emri, string fjalekalimi)
		{
			InputController data = new InputController();
			// Nese nuk ka asnje perdorues atehere hap programin direkt pa kerkuar username
			DataSet ds = data.KerkesaRead("KontrollUserName", emri, fjalekalimi);
			if (ds.Tables[0].Rows.Count != 0)
			{
				Login.rolID = Convert.ToInt32(ds.Tables[0].Rows[0][2]);
				Login.userId = Convert.ToInt32(ds.Tables[0].Rows[0]["USER_ID"]);
				return true;
			}
			else
				return false;
		}

		private void Login_Activated(object sender, System.EventArgs e)
		{
			this.Activate();
		}

		private void btnAnullo_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		public static bool KontrolloPerdoruesit()
		{
			InputController data = new InputController();
			DataSet ds = data.KerkesaRead("ShfaqPerdoruesit");
			if (ds.Tables[0].Rows.Count != 0)
				return true;
			else
				return false;
		}

		public static void ShowForm()
		{
			Login login = new Login();
			login.ShowDialog();
		}

		private void txtEmri_TextChanged(object sender, System.EventArgs e)
		{
			this.error.SetError(this.btnOK, "");
		}

		private void txtFjalekalimi_TextChanged(object sender, System.EventArgs e)
		{
			this.error.SetError(this.btnOK, "");
		}

		private void Login_Closed(object sender, System.EventArgs e)
		{
			//Application.Exit();
		}
		
		#region Public Properties
		
		public string Perdoruesi
		{
			get
			{
				return this.perdoruesi;
			}
		}
		#endregion
	}
}
