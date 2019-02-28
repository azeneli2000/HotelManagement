using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HotelManagment.Forms
{
	/// <summary>
	/// Summary description for NumriDhomave.
	/// </summary>
	public class NumriDhomave : System.Windows.Forms.Form
	{
		#region Private Variables
		private VisionInfoSolutionLibrary.NumericBox numNrDhomash;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnAnullo;
		private VisionInfoSolutionLibrary.PictureBox pbIcon;
		private System.Drawing.Icon icon;
		private System.Windows.Forms.Label lblKujdes;
		private System.Windows.Forms.Label lblNrDhomash;
		private bool firstTimeOpen = false;
		/// <summary>
		/// Ruan vleren fillestare te numrit te dhomave
		/// </summary>
		private int initialValue;
		private VisionInfoSolutionLibrary.ErrorProvider error1;
		private System.Windows.Forms.MenuItem menuItem4;
		private VisionInfoSolutionLibrary.ContextMenu cmCopyPaste;
		private System.Windows.Forms.MenuItem mKopjo;
		private System.Windows.Forms.MenuItem mPrej;
		private System.Windows.Forms.MenuItem mNgjit;
		private System.Windows.Forms.MenuItem mFshi;
		private System.Windows.Forms.MenuItem mPerzgjidh;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region Constructors & Destructors
		public NumriDhomave()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			icon = SystemIcons.Warning;

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Ky konstruktor duhet te thirret ne momentin kur programi hapet per here te pare.
		/// </summary>
		/// <param name="firstTime"></param>
		public NumriDhomave(bool firstTime)
		{
			if (firstTime)
			{
				InitializeComponentFirstTime();
				this.firstTimeOpen = true;
				icon = SystemIcons.Information;
			}
			else
			{
				InitializeComponent();
				icon = SystemIcons.Warning;
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
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pbIcon = new VisionInfoSolutionLibrary.PictureBox();
			this.lblKujdes = new System.Windows.Forms.Label();
			this.lblNrDhomash = new System.Windows.Forms.Label();
			this.numNrDhomash = new VisionInfoSolutionLibrary.NumericBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnAnullo = new System.Windows.Forms.Button();
			this.error1 = new VisionInfoSolutionLibrary.ErrorProvider();
			this.cmCopyPaste = new VisionInfoSolutionLibrary.ContextMenu();
			this.mKopjo = new System.Windows.Forms.MenuItem();
			this.mPrej = new System.Windows.Forms.MenuItem();
			this.mNgjit = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.mFshi = new System.Windows.Forms.MenuItem();
			this.mPerzgjidh = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// pbIcon
			// 
			this.pbIcon.Location = new System.Drawing.Point(12, 20);
			this.pbIcon.Name = "pbIcon";
			this.pbIcon.Size = new System.Drawing.Size(48, 40);
			this.pbIcon.TabIndex = 0;
			this.pbIcon.TabStop = false;
			this.pbIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.pbIcon_Paint);
			// 
			// lblKujdes
			// 
			this.lblKujdes.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblKujdes.Location = new System.Drawing.Point(64, 12);
			this.lblKujdes.Name = "lblKujdes";
			this.lblKujdes.Size = new System.Drawing.Size(320, 56);
			this.lblKujdes.TabIndex = 1;
			this.lblKujdes.Text = "Kujdes!\r\nJu po ndryshoni numrin e dhomave te hotelit.\r\nNese rrisni numrin e dhoma" +
				"ve atehere duhet te kerkoni nje tjeter numer aktivizimi per programin";
			// 
			// lblNrDhomash
			// 
			this.lblNrDhomash.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblNrDhomash.Location = new System.Drawing.Point(16, 92);
			this.lblNrDhomash.Name = "lblNrDhomash";
			this.lblNrDhomash.Size = new System.Drawing.Size(160, 23);
			this.lblNrDhomash.TabIndex = 2;
			this.lblNrDhomash.Text = "Jepni numrin e ri te dhomave:";
			// 
			// numNrDhomash
			// 
			this.numNrDhomash.AutoSize = false;
			this.numNrDhomash.ContextMenu = this.cmCopyPaste;
			this.numNrDhomash.DefaultErrorMessage = "";
			this.numNrDhomash.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numNrDhomash.DigitsAfterDecimalPoint = 0;
			this.numNrDhomash.FixedLength = false;
			this.numNrDhomash.IsValid = false;
			this.numNrDhomash.KeepFocus = false;
			this.numNrDhomash.Location = new System.Drawing.Point(180, 92);
			this.numNrDhomash.Name = "numNrDhomash";
			this.numNrDhomash.OnlyPositive = true;
			this.numNrDhomash.Required = false;
			this.numNrDhomash.RequiredControlColor = System.Drawing.Color.White;
			this.numNrDhomash.Size = new System.Drawing.Size(92, 20);
			this.numNrDhomash.TabIndex = 3;
			this.numNrDhomash.Text = "";
			this.numNrDhomash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnOK
			// 
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOK.Location = new System.Drawing.Point(60, 140);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnAnullo
			// 
			this.btnAnullo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAnullo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAnullo.Location = new System.Drawing.Point(216, 140);
			this.btnAnullo.Name = "btnAnullo";
			this.btnAnullo.TabIndex = 5;
			this.btnAnullo.Text = "Anullo";
			// 
			// error1
			// 
			this.error1.ContainerControl = this;
			// 
			// cmCopyPaste
			// 
			this.cmCopyPaste.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.mKopjo,
																						this.mPrej,
																						this.mNgjit,
																						this.menuItem4,
																						this.mFshi,
																						this.mPerzgjidh});
			this.cmCopyPaste.Popup += new System.EventHandler(this.contextMenu1_Popup);
			// 
			// mKopjo
			// 
			this.mKopjo.Index = 0;
			this.mKopjo.Text = "Kopjo";
			this.mKopjo.Click += new System.EventHandler(this.mKopjo_Click);
			// 
			// mPrej
			// 
			this.mPrej.Index = 1;
			this.mPrej.Text = "Prej";
			this.mPrej.Click += new System.EventHandler(this.mPrej_Click);
			// 
			// mNgjit
			// 
			this.mNgjit.Index = 2;
			this.mNgjit.Text = "Ngjit";
			this.mNgjit.Click += new System.EventHandler(this.mNgjit_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.Text = "-";
			// 
			// mFshi
			// 
			this.mFshi.Index = 4;
			this.mFshi.Text = "Fshi";
			this.mFshi.Click += new System.EventHandler(this.mFshi_Click);
			// 
			// mPerzgjidh
			// 
			this.mPerzgjidh.Index = 5;
			this.mPerzgjidh.Text = "Perzgjidh te gjithen";
			this.mPerzgjidh.Click += new System.EventHandler(this.mPerzgjidh_Click);
			// 
			// NumriDhomave
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnAnullo;
			this.ClientSize = new System.Drawing.Size(414, 180);
			this.Controls.Add(this.btnAnullo);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.numNrDhomash);
			this.Controls.Add(this.lblNrDhomash);
			this.Controls.Add(this.lblKujdes);
			this.Controls.Add(this.pbIcon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NumriDhomave";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ndryshimi i numrit te dhomave";
			this.Load += new System.EventHandler(this.NumriDhomave_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void InitializeComponentFirstTime()
		{
			this.pbIcon = new VisionInfoSolutionLibrary.PictureBox();
			this.lblKujdes = new System.Windows.Forms.Label();
			this.lblNrDhomash = new System.Windows.Forms.Label();
			this.numNrDhomash = new VisionInfoSolutionLibrary.NumericBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnAnullo = new System.Windows.Forms.Button();
			this.error1 = new VisionInfoSolutionLibrary.ErrorProvider();
			this.SuspendLayout();
			// 
			// pbIcon
			// 
			this.pbIcon.Location = new System.Drawing.Point(12, 16);
			this.pbIcon.Name = "pbIcon";
			this.pbIcon.Size = new System.Drawing.Size(48, 40);
			this.pbIcon.TabIndex = 0;
			this.pbIcon.TabStop = false;
			this.pbIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.pbIcon_Paint);
			// 
			// lblKujdes
			// 
			this.lblKujdes.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblKujdes.Location = new System.Drawing.Point(408, 140);
			this.lblKujdes.Name = "lblKujdes";
			this.lblKujdes.Size = new System.Drawing.Size(320, 56);
			this.lblKujdes.TabIndex = 1;
			this.lblKujdes.Text = "Kujdes!\r\nJu po ndryshoni numrin e dhomave te hotelit.\r\nNese rrisni numrin e dhoma" +
				"ve atehere duhet te kerkoni nje tjeter numer aktivizimi per programin";
			// 
			// lblNrDhomash
			// 
			this.lblNrDhomash.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblNrDhomash.Location = new System.Drawing.Point(88, 16);
			this.lblNrDhomash.Name = "lblNrDhomash";
			this.lblNrDhomash.Size = new System.Drawing.Size(160, 23);
			this.lblNrDhomash.TabIndex = 2;
			this.lblNrDhomash.Text = "Jepni numrin e ri te dhomave:";
			this.lblNrDhomash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numNrDhomash
			// 
			this.numNrDhomash.AutoSize = false;
			this.numNrDhomash.DefaultErrorMessage = "";
			this.numNrDhomash.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numNrDhomash.DigitsAfterDecimalPoint = 0;
			this.numNrDhomash.FixedLength = false;
			this.numNrDhomash.IsValid = true;
			this.numNrDhomash.KeepFocus = false;
			this.numNrDhomash.Location = new System.Drawing.Point(112, 44);
			this.numNrDhomash.Name = "numNrDhomash";
			this.numNrDhomash.Required = false;
			this.numNrDhomash.RequiredControlColor = System.Drawing.Color.White;
			this.numNrDhomash.Size = new System.Drawing.Size(92, 20);
			this.numNrDhomash.TabIndex = 3;
			this.numNrDhomash.Text = "";
			this.numNrDhomash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnOK
			// 
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOK.Location = new System.Drawing.Point(52, 84);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnAnullo
			// 
			this.btnAnullo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAnullo.Enabled = true;
			this.btnAnullo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAnullo.Location = new System.Drawing.Point(184, 84);
			this.btnAnullo.Name = "btnAnullo";
			this.btnAnullo.TabIndex = 5;
			this.btnAnullo.Text = "Anullo";
			// 
			// error1
			// 
			this.error1.ContainerControl = this;
			// 
			// NumriDhomave
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnAnullo;
			this.ClientSize = new System.Drawing.Size(318, 116);
			this.ControlBox = false;
			this.Controls.Add(this.btnAnullo);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.numNrDhomash);
			this.Controls.Add(this.lblNrDhomash);
			this.Controls.Add(this.lblKujdes);
			this.Controls.Add(this.pbIcon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NumriDhomave";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ndryshimi i numrit te dhomave";
			this.Load += new System.EventHandler(this.NumriDhomave_Load);
			this.ResumeLayout(false);

		}

		private void pbIcon_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			e.Graphics.DrawIcon(icon, 0, 0);
		}

		
		private void NumriDhomave_Load(object sender, System.EventArgs e)
		{
			this.initialValue = RegistrationClass.GetRoomsCount();
			this.numNrDhomash.Text = this.initialValue.ToString();
			// TODO: Merr numrin e dhomave nga regjistri dhe hidhe ne numericBox dhe ne initialValue
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if (this.numNrDhomash.Text == "")
			{
				this.error1.SetError(this.numNrDhomash, "Fusha e numrit te dhomave nuk mund te lihet bosh");
				return;
			}
			if(!Regex.IsMatch(this.numNrDhomash.Text, "^-?[0-9]*(\\,)?[0-9]+$"))
			{
				this.error1.SetError(this.numNrDhomash, "Vlera duhet te jete numer");
				return;
			}
			if (Convert.ToInt32(this.numNrDhomash.Text) < 0)
			{
				this.error1.SetError(this.numNrDhomash, "Vlera duhet te jete me e madhe se zero");
				return;
			}
			this.error1.SetError(this.numNrDhomash, "");
			if (!this.firstTimeOpen)
			{
				if (this.numNrDhomash.Text == this.initialValue.ToString())
				{
					// Ne kete rast nuk bejme modifikim sepse numrat jane te njejte
					this.Close();
					return;
				}
				RegistrationClass.EditRegistryKey(this.initialValue, Convert.ToInt32(this.numNrDhomash.Text));
				MessageBox.Show("Numri i dhomave qe mban hoteli u ndryshua." + Environment.NewLine +
					"Per cdo problem kontaktoni me VisionInfoSolution", "Ndryshimi i dhomave",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
				return;
			}
			RegistrationClass.StoreKeyToRegistry(Convert.ToInt32(this.numNrDhomash.Text));
			MessageBox.Show("Numri i dhomave qe mban hoteli u ruajt", "Ndryshimi i dhomave",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}


		#region ContextMenu EventHandlers
		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
			this.mKopjo.Enabled = this.numNrDhomash.CanCopy;
			this.mPrej.Enabled = this.numNrDhomash.CanCut;
			this.mNgjit.Enabled = this.numNrDhomash.CanPaste;
			this.mFshi.Enabled = this.numNrDhomash.CanDelete;
			this.mPerzgjidh.Enabled = this.numNrDhomash.CanSelectAll;
		}

		private void mKopjo_Click(object sender, System.EventArgs e)
		{
			this.numNrDhomash.Copy();
		}

		private void mPrej_Click(object sender, System.EventArgs e)
		{
			this.numNrDhomash.Cut();
		}

		private void mNgjit_Click(object sender, System.EventArgs e)
		{
			this.numNrDhomash.Paste();
		}

		private void mFshi_Click(object sender, System.EventArgs e)
		{
			this.numNrDhomash.Delete();
		}

		private void mPerzgjidh_Click(object sender, System.EventArgs e)
		{
			this.numNrDhomash.SelectAll();
		}
		#endregion

	}
}
