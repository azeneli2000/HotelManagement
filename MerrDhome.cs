using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using VisionInfoSolutionLibrary;

namespace HotelManagment
{
	/// <summary>
	/// Summary description for MerrDhome.
	/// </summary>
	public class MerrDhome : VisionInfoSolutionLibrary.Form
	{
		#region
		private VisionInfoSolutionLibrary.GroupBox gbRezervim;
		private VisionInfoSolutionLibrary.TextBox txtTarga;
		private VisionInfoSolutionLibrary.Label lblTarga;
		private VisionInfoSolutionLibrary.TextBox txtEmail;
		private VisionInfoSolutionLibrary.Label lblEmail;
		private VisionInfoSolutionLibrary.Label lblAdresa;
		private VisionInfoSolutionLibrary.TextBox txtAdresa;
		private VisionInfoSolutionLibrary.ComboBox cmbID;
		private VisionInfoSolutionLibrary.NumericBox numKapari;
		private VisionInfoSolutionLibrary.TextBox txtIdNo;
		private VisionInfoSolutionLibrary.Label lblIdNo;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimi;
		private VisionInfoSolutionLibrary.ComboBox cmbNrDhoma;
		private VisionInfoSolutionLibrary.TextBox txtMbiemri;
		private VisionInfoSolutionLibrary.TextBox txtEmri;
		private VisionInfoSolutionLibrary.Label lblID;
		private VisionInfoSolutionLibrary.Label lblMbiemri;
		private VisionInfoSolutionLibrary.Label lblNrDhoma;
		private VisionInfoSolutionLibrary.Label lblEmri;
		private VisionInfoSolutionLibrary.Label lblFillimMarrje;
		private VisionInfoSolutionLibrary.Label lblMbarimMarrje;
		private VisionInfoSolutionLibrary.Label lblKapari;
		private VisionInfoSolutionLibrary.Button btnMerr;
		private System.ComponentModel.IContainer components;
		#endregion

		#region Constructors and Destructors
		public MerrDhome()
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
			this.components = new System.ComponentModel.Container();
			this.gbRezervim = new VisionInfoSolutionLibrary.GroupBox();
			this.txtTarga = new VisionInfoSolutionLibrary.TextBox();
			this.lblTarga = new VisionInfoSolutionLibrary.Label();
			this.txtEmail = new VisionInfoSolutionLibrary.TextBox();
			this.lblEmail = new VisionInfoSolutionLibrary.Label();
			this.lblAdresa = new VisionInfoSolutionLibrary.Label();
			this.txtAdresa = new VisionInfoSolutionLibrary.TextBox();
			this.cmbID = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.numKapari = new VisionInfoSolutionLibrary.NumericBox();
			this.txtIdNo = new VisionInfoSolutionLibrary.TextBox();
			this.lblIdNo = new VisionInfoSolutionLibrary.Label();
			this.dtpMbarimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpFillimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.cmbNrDhoma = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.lblFillimMarrje = new VisionInfoSolutionLibrary.Label();
			this.txtMbiemri = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
			this.lblID = new VisionInfoSolutionLibrary.Label();
			this.lblMbiemri = new VisionInfoSolutionLibrary.Label();
			this.lblNrDhoma = new VisionInfoSolutionLibrary.Label();
			this.lblEmri = new VisionInfoSolutionLibrary.Label();
			this.lblMbarimMarrje = new VisionInfoSolutionLibrary.Label();
			this.lblKapari = new VisionInfoSolutionLibrary.Label();
			this.btnMerr = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbRezervim.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(832, 25);
			// 
			// gbRezervim
			// 
			this.gbRezervim.Controls.Add(this.lblKapari);
			this.gbRezervim.Controls.Add(this.lblMbarimMarrje);
			this.gbRezervim.Controls.Add(this.txtTarga);
			this.gbRezervim.Controls.Add(this.lblTarga);
			this.gbRezervim.Controls.Add(this.txtEmail);
			this.gbRezervim.Controls.Add(this.lblEmail);
			this.gbRezervim.Controls.Add(this.lblAdresa);
			this.gbRezervim.Controls.Add(this.txtAdresa);
			this.gbRezervim.Controls.Add(this.cmbID);
			this.gbRezervim.Controls.Add(this.numKapari);
			this.gbRezervim.Controls.Add(this.txtIdNo);
			this.gbRezervim.Controls.Add(this.lblIdNo);
			this.gbRezervim.Controls.Add(this.dtpMbarimi);
			this.gbRezervim.Controls.Add(this.dtpFillimi);
			this.gbRezervim.Controls.Add(this.cmbNrDhoma);
			this.gbRezervim.Controls.Add(this.lblFillimMarrje);
			this.gbRezervim.Controls.Add(this.txtMbiemri);
			this.gbRezervim.Controls.Add(this.txtEmri);
			this.gbRezervim.Controls.Add(this.lblID);
			this.gbRezervim.Controls.Add(this.lblMbiemri);
			this.gbRezervim.Controls.Add(this.lblNrDhoma);
			this.gbRezervim.Controls.Add(this.lblEmri);
			this.gbRezervim.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbRezervim.Location = new System.Drawing.Point(16, 48);
			this.gbRezervim.Name = "gbRezervim";
			this.gbRezervim.Size = new System.Drawing.Size(736, 296);
			this.gbRezervim.TabIndex = 5;
			this.gbRezervim.TabStop = false;
			this.gbRezervim.Text = "Te dhenat";
			// 
			// txtTarga
			// 
			this.txtTarga.AutoSize = false;
			this.txtTarga.DefaultErrorMessage = "";
			this.txtTarga.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTarga.FixedLength = false;
			this.txtTarga.IsValid = true;
			this.txtTarga.Location = new System.Drawing.Point(484, 96);
			this.txtTarga.Name = "txtTarga";
			this.txtTarga.Required = false;
			this.txtTarga.RequiredControlColor = System.Drawing.Color.White;
			this.txtTarga.Size = new System.Drawing.Size(152, 20);
			this.txtTarga.TabIndex = 28;
			this.txtTarga.Text = "";
			// 
			// lblTarga
			// 
			this.lblTarga.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblTarga.Location = new System.Drawing.Point(352, 96);
			this.lblTarga.Name = "lblTarga";
			this.lblTarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblTarga.Size = new System.Drawing.Size(124, 20);
			this.lblTarga.TabIndex = 27;
			this.lblTarga.Text = "Targa e automjetit";
			// 
			// txtEmail
			// 
			this.txtEmail.AutoSize = false;
			this.txtEmail.DefaultErrorMessage = "";
			this.txtEmail.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmail.FixedLength = false;
			this.txtEmail.IsValid = true;
			this.txtEmail.Location = new System.Drawing.Point(136, 160);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Required = false;
			this.txtEmail.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmail.Size = new System.Drawing.Size(150, 20);
			this.txtEmail.TabIndex = 26;
			this.txtEmail.Text = "";
			// 
			// lblEmail
			// 
			this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmail.Location = new System.Drawing.Point(20, 160);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblEmail.Size = new System.Drawing.Size(108, 24);
			this.lblEmail.TabIndex = 25;
			this.lblEmail.Text = "E-Mail";
			// 
			// lblAdresa
			// 
			this.lblAdresa.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblAdresa.Location = new System.Drawing.Point(24, 128);
			this.lblAdresa.Name = "lblAdresa";
			this.lblAdresa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblAdresa.Size = new System.Drawing.Size(104, 20);
			this.lblAdresa.TabIndex = 24;
			this.lblAdresa.Text = "Adresa";
			// 
			// txtAdresa
			// 
			this.txtAdresa.AutoSize = false;
			this.txtAdresa.DefaultErrorMessage = "";
			this.txtAdresa.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAdresa.FixedLength = false;
			this.txtAdresa.IsValid = false;
			this.txtAdresa.Location = new System.Drawing.Point(136, 128);
			this.txtAdresa.Name = "txtAdresa";
			this.txtAdresa.Required = false;
			this.txtAdresa.RequiredControlColor = System.Drawing.Color.LightSteelBlue;
			this.txtAdresa.Size = new System.Drawing.Size(150, 20);
			this.txtAdresa.TabIndex = 23;
			this.txtAdresa.Text = "";
			// 
			// cmbID
			// 
			this.cmbID.DefaultErrorMessage = null;
			this.cmbID.IsValid = false;
			this.cmbID.Location = new System.Drawing.Point(484, 32);
			this.cmbID.Name = "cmbID";
			this.cmbID.Required = false;
			this.cmbID.Size = new System.Drawing.Size(152, 21);
			this.cmbID.TabIndex = 22;
			// 
			// numKapari
			// 
			this.numKapari.AutoSize = false;
			this.numKapari.DefaultErrorMessage = "";
			this.numKapari.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numKapari.DigitsAfterDecimalPoint = 0;
			this.numKapari.FixedLength = false;
			this.numKapari.IsValid = false;
			this.numKapari.KeepFocus = false;
			this.numKapari.Location = new System.Drawing.Point(136, 192);
			this.numKapari.Name = "numKapari";
			this.numKapari.Required = false;
			this.numKapari.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.numKapari.Size = new System.Drawing.Size(152, 20);
			this.numKapari.TabIndex = 21;
			this.numKapari.Text = "";
			this.numKapari.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtIdNo
			// 
			this.txtIdNo.AutoSize = false;
			this.txtIdNo.DefaultErrorMessage = "";
			this.txtIdNo.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtIdNo.FixedLength = false;
			this.txtIdNo.IsValid = false;
			this.txtIdNo.Location = new System.Drawing.Point(484, 64);
			this.txtIdNo.Name = "txtIdNo";
			this.txtIdNo.Required = false;
			this.txtIdNo.RequiredControlColor = System.Drawing.Color.White;
			this.txtIdNo.Size = new System.Drawing.Size(152, 20);
			this.txtIdNo.TabIndex = 20;
			this.txtIdNo.Text = "";
			// 
			// lblIdNo
			// 
			this.lblIdNo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblIdNo.Location = new System.Drawing.Point(352, 64);
			this.lblIdNo.Name = "lblIdNo";
			this.lblIdNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblIdNo.Size = new System.Drawing.Size(124, 20);
			this.lblIdNo.TabIndex = 19;
			this.lblIdNo.Text = "Numri i identifikimit";
			// 
			// dtpMbarimi
			// 
			this.dtpMbarimi.BackColor = System.Drawing.Color.White;
			this.dtpMbarimi.CustomFormat = "dd.MM.yyyy";
			this.dtpMbarimi.DefaultErrorMessage = "Duhet te zgjidhni nje vlere";
			this.dtpMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimi.IsValid = true;
			this.dtpMbarimi.Location = new System.Drawing.Point(484, 160);
			this.dtpMbarimi.Name = "dtpMbarimi";
			this.dtpMbarimi.Required = true;
			this.dtpMbarimi.ShowCheckBox = true;
			this.dtpMbarimi.ShowUpDown = true;
			this.dtpMbarimi.Size = new System.Drawing.Size(160, 20);
			this.dtpMbarimi.TabIndex = 18;
			this.dtpMbarimi.Value = new System.DateTime(2005, 5, 30, 16, 30, 37, 46);
			// 
			// dtpFillimi
			// 
			this.dtpFillimi.BackColor = System.Drawing.Color.White;
			this.dtpFillimi.CustomFormat = "dd.MM.yyyy";
			this.dtpFillimi.DefaultErrorMessage = "Ju duhet te zgjidhni nje date per fillimin e rezervimit";
			this.dtpFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimi.IsValid = false;
			this.dtpFillimi.Location = new System.Drawing.Point(484, 128);
			this.dtpFillimi.Name = "dtpFillimi";
			this.dtpFillimi.Required = false;
			this.dtpFillimi.ShowCheckBox = true;
			this.dtpFillimi.ShowUpDown = true;
			this.dtpFillimi.Size = new System.Drawing.Size(160, 20);
			this.dtpFillimi.TabIndex = 17;
			this.dtpFillimi.Value = new System.DateTime(2005, 5, 30, 16, 30, 37, 62);
			// 
			// cmbNrDhoma
			// 
			this.cmbNrDhoma.DefaultErrorMessage = "Ju duhet te zgjidhni nje vlere";
			this.cmbNrDhoma.IsValid = false;
			this.cmbNrDhoma.ItemHeight = 13;
			this.cmbNrDhoma.Location = new System.Drawing.Point(136, 32);
			this.cmbNrDhoma.Name = "cmbNrDhoma";
			this.cmbNrDhoma.Required = false;
			this.cmbNrDhoma.Size = new System.Drawing.Size(152, 21);
			this.cmbNrDhoma.TabIndex = 16;
			// 
			// lblFillimMarrje
			// 
			this.lblFillimMarrje.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblFillimMarrje.Location = new System.Drawing.Point(348, 128);
			this.lblFillimMarrje.Name = "lblFillimMarrje";
			this.lblFillimMarrje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblFillimMarrje.Size = new System.Drawing.Size(128, 20);
			this.lblFillimMarrje.TabIndex = 12;
			this.lblFillimMarrje.Text = "Data e marrjes se dhomes";
			// 
			// txtMbiemri
			// 
			this.txtMbiemri.AutoSize = false;
			this.txtMbiemri.DefaultErrorMessage = "Ju duhet te jepni mbiemrin e klientit";
			this.txtMbiemri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemri.FixedLength = false;
			this.txtMbiemri.IsValid = false;
			this.txtMbiemri.Location = new System.Drawing.Point(136, 96);
			this.txtMbiemri.Name = "txtMbiemri";
			this.txtMbiemri.Required = true;
			this.txtMbiemri.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.txtMbiemri.Size = new System.Drawing.Size(152, 20);
			this.txtMbiemri.TabIndex = 9;
			this.txtMbiemri.Text = "";
			// 
			// txtEmri
			// 
			this.txtEmri.AutoSize = false;
			this.txtEmri.DefaultErrorMessage = "Ju duhet te jepni emrin e klientit";
			this.txtEmri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri.FixedLength = false;
			this.txtEmri.IsValid = false;
			this.txtEmri.Location = new System.Drawing.Point(136, 64);
			this.txtEmri.Name = "txtEmri";
			this.txtEmri.Required = true;
			this.txtEmri.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.txtEmri.Size = new System.Drawing.Size(152, 20);
			this.txtEmri.TabIndex = 8;
			this.txtEmri.Text = "";
			// 
			// lblID
			// 
			this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblID.Location = new System.Drawing.Point(352, 32);
			this.lblID.Name = "lblID";
			this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblID.Size = new System.Drawing.Size(124, 20);
			this.lblID.TabIndex = 7;
			this.lblID.Text = "Mjeti i identifikimit";
			// 
			// lblMbiemri
			// 
			this.lblMbiemri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblMbiemri.Location = new System.Drawing.Point(24, 96);
			this.lblMbiemri.Name = "lblMbiemri";
			this.lblMbiemri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblMbiemri.Size = new System.Drawing.Size(104, 20);
			this.lblMbiemri.TabIndex = 6;
			this.lblMbiemri.Text = "Mbiemri";
			// 
			// lblNrDhoma
			// 
			this.lblNrDhoma.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblNrDhoma.Location = new System.Drawing.Point(24, 32);
			this.lblNrDhoma.Name = "lblNrDhoma";
			this.lblNrDhoma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblNrDhoma.Size = new System.Drawing.Size(104, 20);
			this.lblNrDhoma.TabIndex = 4;
			this.lblNrDhoma.Text = "Numri i dhomes";
			// 
			// lblEmri
			// 
			this.lblEmri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmri.Location = new System.Drawing.Point(24, 64);
			this.lblEmri.Name = "lblEmri";
			this.lblEmri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblEmri.Size = new System.Drawing.Size(104, 20);
			this.lblEmri.TabIndex = 5;
			this.lblEmri.Text = "Emri";
			// 
			// lblMbarimMarrje
			// 
			this.lblMbarimMarrje.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblMbarimMarrje.Location = new System.Drawing.Point(344, 160);
			this.lblMbarimMarrje.Name = "lblMbarimMarrje";
			this.lblMbarimMarrje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblMbarimMarrje.Size = new System.Drawing.Size(132, 20);
			this.lblMbarimMarrje.TabIndex = 29;
			this.lblMbarimMarrje.Text = "Data e leshimit te dhomes";
			// 
			// lblKapari
			// 
			this.lblKapari.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblKapari.Location = new System.Drawing.Point(28, 192);
			this.lblKapari.Name = "lblKapari";
			this.lblKapari.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblKapari.Size = new System.Drawing.Size(100, 20);
			this.lblKapari.TabIndex = 30;
			this.lblKapari.Text = "Kapari";
			// 
			// btnMerr
			// 
			this.btnMerr.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMerr.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnMerr.Location = new System.Drawing.Point(156, 392);
			this.btnMerr.Name = "btnMerr";
			this.btnMerr.Size = new System.Drawing.Size(90, 21);
			this.btnMerr.TabIndex = 31;
			this.btnMerr.Text = "Merr";
			this.btnMerr.Click += new System.EventHandler(this.btnMerr_Click);
			// 
			// MerrDhome
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CheckRequiredFields = true;
			this.ClientSize = new System.Drawing.Size(832, 632);
			this.Controls.Add(this.gbRezervim);
			this.Controls.Add(this.btnMerr);
			this.ControlsBackColor = System.Drawing.Color.White;
			this.EnableValidation = true;
			this.Name = "MerrDhome";
			this.RequiredControlsBackColor = System.Drawing.Color.LightYellow;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Merr Dhome";
			this.TitullGjeresi = 832;
			this.Controls.SetChildIndex(this.btnMerr, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.gbRezervim, 0);
			this.gbRezervim.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnMerr_Click(object sender, System.EventArgs e)
		{
			if (this.IsValid)
			{
				
			}
		}
	}
}
