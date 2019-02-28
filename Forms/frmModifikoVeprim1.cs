using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data ;
using System.Data.SqlClient;

namespace HotelManagment.Forms
{
	public class frmModifikoVeprim1 : VisionInfoSolutionLibrary.Form
	{
		#region privateVariables
		private VisionInfoSolutionLibrary.Button button1;
		private VisionInfoSolutionLibrary.Button button2;
		private VisionInfoSolutionLibrary.GroupBox gbVeprime;
		private VisionInfoSolutionLibrary.NumericBox numCmimi;
		private VisionInfoSolutionLibrary.Label lblCmimi;
		private VisionInfoSolutionLibrary.Label lblAdresa;
		private VisionInfoSolutionLibrary.TextBox txtAdresa;
		private VisionInfoSolutionLibrary.Label label8;
		private VisionInfoSolutionLibrary.DateTimePicker dtDatelindja;
		private VisionInfoSolutionLibrary.Label label7;
		private VisionInfoSolutionLibrary.NumericBox numKapari;
		private VisionInfoSolutionLibrary.Label label6;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategorite;
		private VisionInfoSolutionLibrary.ComboBox comboBox5;
		private VisionInfoSolutionLibrary.ComboBox comboBox6;
		private VisionInfoSolutionLibrary.TextBox txtTelefoni;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.Label lblMbarimMarrje;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimi;
		private VisionInfoSolutionLibrary.Label lblFillimMarrje;
		private VisionInfoSolutionLibrary.Label lblKategoria;
		private VisionInfoSolutionLibrary.Label lblNrDhoma;
		private VisionInfoSolutionLibrary.TextBox txtEmail;
		private VisionInfoSolutionLibrary.Label lblEmail;
		private VisionInfoSolutionLibrary.TextBox txtIdNo;
		private VisionInfoSolutionLibrary.Label lblIdNo;
		private VisionInfoSolutionLibrary.TextBox txtMbiemri;
		private VisionInfoSolutionLibrary.TextBox txtEmri;
		private VisionInfoSolutionLibrary.Label lblID;
		private VisionInfoSolutionLibrary.Label lblMbiemri;
		private VisionInfoSolutionLibrary.Label lblEmri;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.ComboBox comboBox1;
		private VisionInfoSolutionLibrary.ComboBox comboBox2;
		private VisionInfoSolutionLibrary.DoubleCombo cmbGrupi;
		private VisionInfoSolutionLibrary.DoubleCombo cmbGrupi1;
		private VisionInfoSolutionLibrary.DoubleCombo cmbMjetId;
		private System.ComponentModel.IContainer components = null;
		
		private VisionInfoSolutionLibrary.ErrorProvider error;
		private VisionInfoSolutionLibrary.Button btnElimino;
		private VisionInfoSolutionLibrary.Button btnModifiko;
		private DataSet ds = null;
		private int idKlienti;
		private int idGrupi;
		private int idIdentifikimi;
		private int idLloji;
		private int idKategoria;
		private DateTime dtFillimi;
		private DateTime dtMbarimi;
		private DateTime dataKapari;
		private VisionInfoSolutionLibrary.DoubleCombo cmbNrDhoma;
		private int idDhoma;
		private VisionInfoSolutionLibrary.TextBox txtTarga;
		private VisionInfoSolutionLibrary.Label lblTarga;
		private VisionInfoSolutionLibrary.NumericBox numSkonto;
		private VisionInfoSolutionLibrary.NumericBox numGjoba;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.Label label3;
		private string klient_hotel;
		private string emriDhoma;
		private int skonto;
		private int gjoba;
		#endregion

		#region Constructors
		public frmModifikoVeprim1(int idKlienti,int idKategoria,DateTime dtFillimi,DateTime dtMbarimi)
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			this.idKlienti = idKlienti;
			this.idKategoria = idKategoria;
			this.dtFillimi = dtFillimi;
			this.dtMbarimi = dtMbarimi;
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
		#endregion

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.gbVeprime = new VisionInfoSolutionLibrary.GroupBox();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.numGjoba = new VisionInfoSolutionLibrary.NumericBox();
			this.numSkonto = new VisionInfoSolutionLibrary.NumericBox();
			this.txtTarga = new VisionInfoSolutionLibrary.TextBox();
			this.lblTarga = new VisionInfoSolutionLibrary.Label();
			this.cmbNrDhoma = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbGrupi1 = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbMjetId = new VisionInfoSolutionLibrary.DoubleCombo();
			this.numCmimi = new VisionInfoSolutionLibrary.NumericBox();
			this.lblCmimi = new VisionInfoSolutionLibrary.Label();
			this.lblAdresa = new VisionInfoSolutionLibrary.Label();
			this.txtAdresa = new VisionInfoSolutionLibrary.TextBox();
			this.label8 = new VisionInfoSolutionLibrary.Label();
			this.dtDatelindja = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label7 = new VisionInfoSolutionLibrary.Label();
			this.numKapari = new VisionInfoSolutionLibrary.NumericBox();
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.cmbKategorite = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox5 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox6 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.txtTelefoni = new VisionInfoSolutionLibrary.TextBox();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.lblMbarimMarrje = new VisionInfoSolutionLibrary.Label();
			this.dtpMbarimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpFillimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.lblFillimMarrje = new VisionInfoSolutionLibrary.Label();
			this.lblKategoria = new VisionInfoSolutionLibrary.Label();
			this.lblNrDhoma = new VisionInfoSolutionLibrary.Label();
			this.txtEmail = new VisionInfoSolutionLibrary.TextBox();
			this.lblEmail = new VisionInfoSolutionLibrary.Label();
			this.txtIdNo = new VisionInfoSolutionLibrary.TextBox();
			this.lblIdNo = new VisionInfoSolutionLibrary.Label();
			this.txtMbiemri = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
			this.lblID = new VisionInfoSolutionLibrary.Label();
			this.lblMbiemri = new VisionInfoSolutionLibrary.Label();
			this.lblEmri = new VisionInfoSolutionLibrary.Label();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.cmbGrupi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox1 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox2 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.ds = new System.Data.DataSet();
			this.error = new VisionInfoSolutionLibrary.ErrorProvider();
			this.btnModifiko = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnElimino = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbVeprime.SuspendLayout();
			this.cmbKategorite.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(656, 25);
			// 
			// gbVeprime
			// 
			this.gbVeprime.BackColor = System.Drawing.SystemColors.Control;
			this.gbVeprime.Controls.Add(this.label3);
			this.gbVeprime.Controls.Add(this.label2);
			this.gbVeprime.Controls.Add(this.numGjoba);
			this.gbVeprime.Controls.Add(this.numSkonto);
			this.gbVeprime.Controls.Add(this.txtTarga);
			this.gbVeprime.Controls.Add(this.lblTarga);
			this.gbVeprime.Controls.Add(this.cmbNrDhoma);
			this.gbVeprime.Controls.Add(this.cmbGrupi1);
			this.gbVeprime.Controls.Add(this.cmbMjetId);
			this.gbVeprime.Controls.Add(this.numCmimi);
			this.gbVeprime.Controls.Add(this.lblCmimi);
			this.gbVeprime.Controls.Add(this.lblAdresa);
			this.gbVeprime.Controls.Add(this.txtAdresa);
			this.gbVeprime.Controls.Add(this.label8);
			this.gbVeprime.Controls.Add(this.dtDatelindja);
			this.gbVeprime.Controls.Add(this.label7);
			this.gbVeprime.Controls.Add(this.numKapari);
			this.gbVeprime.Controls.Add(this.label6);
			this.gbVeprime.Controls.Add(this.cmbKategorite);
			this.gbVeprime.Controls.Add(this.txtTelefoni);
			this.gbVeprime.Controls.Add(this.label5);
			this.gbVeprime.Controls.Add(this.lblMbarimMarrje);
			this.gbVeprime.Controls.Add(this.dtpMbarimi);
			this.gbVeprime.Controls.Add(this.dtpFillimi);
			this.gbVeprime.Controls.Add(this.lblFillimMarrje);
			this.gbVeprime.Controls.Add(this.lblKategoria);
			this.gbVeprime.Controls.Add(this.lblNrDhoma);
			this.gbVeprime.Controls.Add(this.txtEmail);
			this.gbVeprime.Controls.Add(this.lblEmail);
			this.gbVeprime.Controls.Add(this.txtIdNo);
			this.gbVeprime.Controls.Add(this.lblIdNo);
			this.gbVeprime.Controls.Add(this.txtMbiemri);
			this.gbVeprime.Controls.Add(this.txtEmri);
			this.gbVeprime.Controls.Add(this.lblID);
			this.gbVeprime.Controls.Add(this.lblMbiemri);
			this.gbVeprime.Controls.Add(this.lblEmri);
			this.gbVeprime.Controls.Add(this.label1);
			this.gbVeprime.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbVeprime.Location = new System.Drawing.Point(16, 12);
			this.gbVeprime.Name = "gbVeprime";
			this.gbVeprime.Size = new System.Drawing.Size(708, 320);
			this.gbVeprime.TabIndex = 18;
			this.gbVeprime.TabStop = false;
			this.gbVeprime.Text = "Veprime";
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(356, 252);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label3.Size = new System.Drawing.Size(36, 16);
			this.label3.TabIndex = 84;
			this.label3.Text = "Gjoba";
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(356, 224);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(36, 16);
			this.label2.TabIndex = 83;
			this.label2.Text = "Skonto";
			// 
			// numGjoba
			// 
			this.numGjoba.AutoSize = false;
			this.numGjoba.DefaultErrorMessage = "Duhet te jepni nje vlere per kaparin!";
			this.numGjoba.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numGjoba.DigitsAfterDecimalPoint = 0;
			this.numGjoba.FixedLength = false;
			this.numGjoba.IsValid = false;
			this.numGjoba.KeepFocus = false;
			this.numGjoba.Location = new System.Drawing.Point(408, 252);
			this.numGjoba.Name = "numGjoba";
			this.numGjoba.Required = true;
			this.numGjoba.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.numGjoba.Size = new System.Drawing.Size(180, 20);
			this.numGjoba.TabIndex = 82;
			this.numGjoba.Text = "";
			this.numGjoba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// numSkonto
			// 
			this.numSkonto.AutoSize = false;
			this.numSkonto.DefaultErrorMessage = "Duhet te jepni nje vlere per kaparin!";
			this.numSkonto.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numSkonto.DigitsAfterDecimalPoint = 0;
			this.numSkonto.FixedLength = false;
			this.numSkonto.IsValid = false;
			this.numSkonto.KeepFocus = false;
			this.numSkonto.Location = new System.Drawing.Point(408, 224);
			this.numSkonto.Name = "numSkonto";
			this.numSkonto.Required = true;
			this.numSkonto.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.numSkonto.Size = new System.Drawing.Size(180, 20);
			this.numSkonto.TabIndex = 81;
			this.numSkonto.Text = "";
			this.numSkonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTarga
			// 
			this.txtTarga.AutoSize = false;
			this.txtTarga.DefaultErrorMessage = "";
			this.txtTarga.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTarga.FixedLength = false;
			this.txtTarga.IsValid = true;
			this.txtTarga.Location = new System.Drawing.Point(116, 244);
			this.txtTarga.Name = "txtTarga";
			this.txtTarga.Required = false;
			this.txtTarga.RequiredControlColor = System.Drawing.Color.White;
			this.txtTarga.Size = new System.Drawing.Size(171, 20);
			this.txtTarga.TabIndex = 80;
			this.txtTarga.Text = "";
			// 
			// lblTarga
			// 
			this.lblTarga.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblTarga.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTarga.Location = new System.Drawing.Point(8, 244);
			this.lblTarga.Name = "lblTarga";
			this.lblTarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblTarga.Size = new System.Drawing.Size(92, 20);
			this.lblTarga.TabIndex = 79;
			this.lblTarga.Text = "Targa e automjetit";
			// 
			// cmbNrDhoma
			// 
			this.cmbNrDhoma.DefaultErrorMessage = "Zgjidhni nje prej dhomave!";
			this.cmbNrDhoma.IsValid = false;
			this.cmbNrDhoma.Kolone1Vlere = null;
			this.cmbNrDhoma.Kolone2Vlere = null;
			this.cmbNrDhoma.Location = new System.Drawing.Point(408, 148);
			this.cmbNrDhoma.Name = "cmbNrDhoma";
			this.cmbNrDhoma.Required = true;
			this.cmbNrDhoma.Size = new System.Drawing.Size(180, 24);
			this.cmbNrDhoma.SkipValidation = false;
			this.cmbNrDhoma.TabIndex = 78;
			// 
			// cmbGrupi1
			// 
			this.cmbGrupi1.DefaultErrorMessage = null;
			this.cmbGrupi1.IsValid = false;
			this.cmbGrupi1.Kolone1Vlere = null;
			this.cmbGrupi1.Kolone2Vlere = null;
			this.cmbGrupi1.Location = new System.Drawing.Point(116, 48);
			this.cmbGrupi1.Name = "cmbGrupi1";
			this.cmbGrupi1.Required = false;
			this.cmbGrupi1.Size = new System.Drawing.Size(172, 24);
			this.cmbGrupi1.SkipValidation = false;
			this.cmbGrupi1.TabIndex = 77;
			// 
			// cmbMjetId
			// 
			this.cmbMjetId.DefaultErrorMessage = null;
			this.cmbMjetId.IsValid = false;
			this.cmbMjetId.Kolone1Vlere = null;
			this.cmbMjetId.Kolone2Vlere = null;
			this.cmbMjetId.Location = new System.Drawing.Point(116, 124);
			this.cmbMjetId.Name = "cmbMjetId";
			this.cmbMjetId.Required = false;
			this.cmbMjetId.Size = new System.Drawing.Size(172, 24);
			this.cmbMjetId.SkipValidation = false;
			this.cmbMjetId.TabIndex = 76;
			// 
			// numCmimi
			// 
			this.numCmimi.AutoSize = false;
			this.numCmimi.DefaultErrorMessage = "";
			this.numCmimi.DesabledControlColor = System.Drawing.SystemColors.ControlLightLight;
			this.numCmimi.DigitsAfterDecimalPoint = 0;
			this.numCmimi.FixedLength = false;
			this.numCmimi.IsValid = false;
			this.numCmimi.KeepFocus = false;
			this.numCmimi.Location = new System.Drawing.Point(408, 172);
			this.numCmimi.Name = "numCmimi";
			this.numCmimi.ReadOnly = true;
			this.numCmimi.Required = true;
			this.numCmimi.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimi.Size = new System.Drawing.Size(180, 20);
			this.numCmimi.TabIndex = 74;
			this.numCmimi.Text = "";
			this.numCmimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblCmimi
			// 
			this.lblCmimi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblCmimi.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCmimi.Location = new System.Drawing.Point(340, 172);
			this.lblCmimi.Name = "lblCmimi";
			this.lblCmimi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCmimi.Size = new System.Drawing.Size(52, 20);
			this.lblCmimi.TabIndex = 73;
			this.lblCmimi.Text = "Cmimi";
			// 
			// lblAdresa
			// 
			this.lblAdresa.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblAdresa.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblAdresa.Location = new System.Drawing.Point(32, 220);
			this.lblAdresa.Name = "lblAdresa";
			this.lblAdresa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblAdresa.Size = new System.Drawing.Size(68, 20);
			this.lblAdresa.TabIndex = 68;
			this.lblAdresa.Text = "Adresa";
			// 
			// txtAdresa
			// 
			this.txtAdresa.AutoSize = false;
			this.txtAdresa.DefaultErrorMessage = "";
			this.txtAdresa.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAdresa.FixedLength = false;
			this.txtAdresa.IsValid = false;
			this.txtAdresa.Location = new System.Drawing.Point(116, 220);
			this.txtAdresa.Name = "txtAdresa";
			this.txtAdresa.Required = false;
			this.txtAdresa.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.txtAdresa.Size = new System.Drawing.Size(170, 20);
			this.txtAdresa.TabIndex = 67;
			this.txtAdresa.Text = "";
			// 
			// label8
			// 
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(52, 48);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label8.Size = new System.Drawing.Size(52, 20);
			this.label8.TabIndex = 66;
			this.label8.Text = "Grupi";
			// 
			// dtDatelindja
			// 
			this.dtDatelindja.BackColor = System.Drawing.Color.White;
			this.dtDatelindja.CustomFormat = "dd.MM.yyyy";
			this.dtDatelindja.DefaultErrorMessage = "Ju duhet te zgjidhni nje date per fillimin e rezervimit";
			this.dtDatelindja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtDatelindja.IsValid = true;
			this.dtDatelindja.Location = new System.Drawing.Point(116, 172);
			this.dtDatelindja.Name = "dtDatelindja";
			this.dtDatelindja.Required = true;
			this.dtDatelindja.ShowCheckBox = true;
			this.dtDatelindja.ShowUpDown = true;
			this.dtDatelindja.Size = new System.Drawing.Size(172, 20);
			this.dtDatelindja.TabIndex = 64;
			this.dtDatelindja.Value = new System.DateTime(2005, 5, 30, 16, 30, 37, 62);
			// 
			// label7
			// 
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(32, 172);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label7.Size = new System.Drawing.Size(72, 20);
			this.label7.TabIndex = 63;
			this.label7.Text = "Datelindja";
			// 
			// numKapari
			// 
			this.numKapari.AutoSize = false;
			this.numKapari.DefaultErrorMessage = "Duhet te jepni nje vlere per kaparin!";
			this.numKapari.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numKapari.DigitsAfterDecimalPoint = 0;
			this.numKapari.FixedLength = false;
			this.numKapari.IsValid = false;
			this.numKapari.KeepFocus = false;
			this.numKapari.Location = new System.Drawing.Point(408, 196);
			this.numKapari.Name = "numKapari";
			this.numKapari.Required = true;
			this.numKapari.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.numKapari.Size = new System.Drawing.Size(180, 20);
			this.numKapari.TabIndex = 62;
			this.numKapari.Text = "";
			this.numKapari.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label6
			// 
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(356, 196);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label6.Size = new System.Drawing.Size(36, 16);
			this.label6.TabIndex = 61;
			this.label6.Text = "Kapari";
			// 
			// cmbKategorite
			// 
			this.cmbKategorite.Controls.Add(this.comboBox5);
			this.cmbKategorite.Controls.Add(this.comboBox6);
			this.cmbKategorite.DefaultErrorMessage = "Zgjidhni nje prej kategorive!";
			this.cmbKategorite.IsValid = false;
			this.cmbKategorite.Kolone1Vlere = null;
			this.cmbKategorite.Kolone2Vlere = null;
			this.cmbKategorite.Location = new System.Drawing.Point(408, 124);
			this.cmbKategorite.Name = "cmbKategorite";
			this.cmbKategorite.Required = true;
			this.cmbKategorite.Size = new System.Drawing.Size(180, 24);
			this.cmbKategorite.SkipValidation = false;
			this.cmbKategorite.TabIndex = 59;
			this.cmbKategorite.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategorite_SelectedIndexChanged);
			// 
			// comboBox5
			// 
			this.comboBox5.DefaultErrorMessage = null;
			this.comboBox5.IsValid = false;
			this.comboBox5.Location = new System.Drawing.Point(384, 0);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Required = false;
			this.comboBox5.Size = new System.Drawing.Size(16, 21);
			this.comboBox5.TabIndex = 1;
			this.comboBox5.Visible = false;
			// 
			// comboBox6
			// 
			this.comboBox6.DefaultErrorMessage = null;
			this.comboBox6.IsValid = false;
			this.comboBox6.Location = new System.Drawing.Point(0, 0);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Required = false;
			this.comboBox6.Size = new System.Drawing.Size(172, 21);
			this.comboBox6.TabIndex = 0;
			// 
			// txtTelefoni
			// 
			this.txtTelefoni.AutoSize = false;
			this.txtTelefoni.DefaultErrorMessage = "";
			this.txtTelefoni.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTelefoni.FixedLength = false;
			this.txtTelefoni.IsValid = true;
			this.txtTelefoni.Location = new System.Drawing.Point(116, 196);
			this.txtTelefoni.Name = "txtTelefoni";
			this.txtTelefoni.Required = false;
			this.txtTelefoni.RequiredControlColor = System.Drawing.Color.White;
			this.txtTelefoni.Size = new System.Drawing.Size(172, 20);
			this.txtTelefoni.TabIndex = 58;
			this.txtTelefoni.Text = "";
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(8, 196);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 20);
			this.label5.TabIndex = 56;
			this.label5.Text = "Nr telefoni";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblMbarimMarrje
			// 
			this.lblMbarimMarrje.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblMbarimMarrje.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblMbarimMarrje.Location = new System.Drawing.Point(320, 100);
			this.lblMbarimMarrje.Name = "lblMbarimMarrje";
			this.lblMbarimMarrje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblMbarimMarrje.Size = new System.Drawing.Size(72, 20);
			this.lblMbarimMarrje.TabIndex = 51;
			this.lblMbarimMarrje.Text = "Date mbarimi";
			// 
			// dtpMbarimi
			// 
			this.dtpMbarimi.BackColor = System.Drawing.Color.White;
			this.dtpMbarimi.CustomFormat = "dd.MM.yyyy /ora hh:mm.tt";
			this.dtpMbarimi.DefaultErrorMessage = "Duhet te zgjidhni nje vlere";
			this.dtpMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimi.IsValid = true;
			this.dtpMbarimi.Location = new System.Drawing.Point(408, 100);
			this.dtpMbarimi.Name = "dtpMbarimi";
			this.dtpMbarimi.Required = true;
			this.dtpMbarimi.ShowCheckBox = true;
			this.dtpMbarimi.ShowUpDown = true;
			this.dtpMbarimi.Size = new System.Drawing.Size(180, 20);
			this.dtpMbarimi.TabIndex = 50;
			this.dtpMbarimi.Value = new System.DateTime(2005, 5, 30, 16, 30, 37, 46);
			// 
			// dtpFillimi
			// 
			this.dtpFillimi.BackColor = System.Drawing.Color.White;
			this.dtpFillimi.CustomFormat = "dd.MM.yyyy  /ora hh:mm.tt";
			this.dtpFillimi.DefaultErrorMessage = "Ju duhet te zgjidhni nje date per fillimin e rezervimit";
			this.dtpFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimi.IsValid = true;
			this.dtpFillimi.Location = new System.Drawing.Point(408, 76);
			this.dtpFillimi.Name = "dtpFillimi";
			this.dtpFillimi.Required = true;
			this.dtpFillimi.ShowCheckBox = true;
			this.dtpFillimi.ShowUpDown = true;
			this.dtpFillimi.Size = new System.Drawing.Size(180, 20);
			this.dtpFillimi.TabIndex = 49;
			this.dtpFillimi.Value = new System.DateTime(2005, 5, 30, 16, 30, 37, 62);
			// 
			// lblFillimMarrje
			// 
			this.lblFillimMarrje.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblFillimMarrje.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblFillimMarrje.Location = new System.Drawing.Point(324, 76);
			this.lblFillimMarrje.Name = "lblFillimMarrje";
			this.lblFillimMarrje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblFillimMarrje.Size = new System.Drawing.Size(72, 20);
			this.lblFillimMarrje.TabIndex = 48;
			this.lblFillimMarrje.Text = "Date fillimi";
			// 
			// lblKategoria
			// 
			this.lblKategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblKategoria.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblKategoria.Location = new System.Drawing.Point(296, 124);
			this.lblKategoria.Name = "lblKategoria";
			this.lblKategoria.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblKategoria.Size = new System.Drawing.Size(96, 20);
			this.lblKategoria.TabIndex = 46;
			this.lblKategoria.Text = "Kategoria e dhomes";
			// 
			// lblNrDhoma
			// 
			this.lblNrDhoma.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblNrDhoma.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNrDhoma.Location = new System.Drawing.Point(316, 148);
			this.lblNrDhoma.Name = "lblNrDhoma";
			this.lblNrDhoma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblNrDhoma.Size = new System.Drawing.Size(76, 20);
			this.lblNrDhoma.TabIndex = 44;
			this.lblNrDhoma.Text = "Dhoma";
			// 
			// txtEmail
			// 
			this.txtEmail.AutoSize = false;
			this.txtEmail.DefaultErrorMessage = "";
			this.txtEmail.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmail.FixedLength = false;
			this.txtEmail.IsValid = true;
			this.txtEmail.Location = new System.Drawing.Point(408, 52);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Required = false;
			this.txtEmail.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.txtEmail.Size = new System.Drawing.Size(180, 20);
			this.txtEmail.TabIndex = 41;
			this.txtEmail.Text = "";
			// 
			// lblEmail
			// 
			this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblEmail.Location = new System.Drawing.Point(356, 52);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblEmail.Size = new System.Drawing.Size(36, 16);
			this.lblEmail.TabIndex = 40;
			this.lblEmail.Text = "E-Mail";
			// 
			// txtIdNo
			// 
			this.txtIdNo.AutoSize = false;
			this.txtIdNo.DefaultErrorMessage = "Ju duhet te jepni numrin e identiikimit!";
			this.txtIdNo.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtIdNo.FixedLength = false;
			this.txtIdNo.IsValid = false;
			this.txtIdNo.Location = new System.Drawing.Point(116, 148);
			this.txtIdNo.Name = "txtIdNo";
			this.txtIdNo.Required = true;
			this.txtIdNo.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.txtIdNo.Size = new System.Drawing.Size(172, 20);
			this.txtIdNo.TabIndex = 36;
			this.txtIdNo.Text = "";
			// 
			// lblIdNo
			// 
			this.lblIdNo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblIdNo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblIdNo.Location = new System.Drawing.Point(12, 148);
			this.lblIdNo.Name = "lblIdNo";
			this.lblIdNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblIdNo.Size = new System.Drawing.Size(92, 20);
			this.lblIdNo.TabIndex = 35;
			this.lblIdNo.Text = "Numri i identifikimit";
			// 
			// txtMbiemri
			// 
			this.txtMbiemri.AutoSize = false;
			this.txtMbiemri.DefaultErrorMessage = "Ju duhet te jepni mbiemrin e klientit";
			this.txtMbiemri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemri.FixedLength = false;
			this.txtMbiemri.IsValid = false;
			this.txtMbiemri.Location = new System.Drawing.Point(116, 100);
			this.txtMbiemri.Name = "txtMbiemri";
			this.txtMbiemri.Required = true;
			this.txtMbiemri.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.txtMbiemri.Size = new System.Drawing.Size(172, 20);
			this.txtMbiemri.TabIndex = 34;
			this.txtMbiemri.Text = "";
			// 
			// txtEmri
			// 
			this.txtEmri.AutoSize = false;
			this.txtEmri.DefaultErrorMessage = "Ju duhet te jepni emrin e klientit";
			this.txtEmri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri.FixedLength = false;
			this.txtEmri.IsValid = false;
			this.txtEmri.Location = new System.Drawing.Point(116, 76);
			this.txtEmri.Name = "txtEmri";
			this.txtEmri.Required = true;
			this.txtEmri.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.txtEmri.Size = new System.Drawing.Size(172, 20);
			this.txtEmri.TabIndex = 33;
			this.txtEmri.Text = "";
			// 
			// lblID
			// 
			this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblID.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblID.Location = new System.Drawing.Point(12, 124);
			this.lblID.Name = "lblID";
			this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblID.Size = new System.Drawing.Size(92, 20);
			this.lblID.TabIndex = 32;
			this.lblID.Text = "Mjeti i identifikimit";
			// 
			// lblMbiemri
			// 
			this.lblMbiemri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblMbiemri.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblMbiemri.Location = new System.Drawing.Point(44, 100);
			this.lblMbiemri.Name = "lblMbiemri";
			this.lblMbiemri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblMbiemri.Size = new System.Drawing.Size(60, 20);
			this.lblMbiemri.TabIndex = 31;
			this.lblMbiemri.Text = "Mbiemri";
			// 
			// lblEmri
			// 
			this.lblEmri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmri.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblEmri.Location = new System.Drawing.Point(52, 76);
			this.lblEmri.Name = "lblEmri";
			this.lblEmri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblEmri.Size = new System.Drawing.Size(52, 20);
			this.lblEmri.TabIndex = 30;
			this.lblEmri.Text = "Emri";
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(20, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Te dhenat e veprimit te zgjedhur";
			// 
			// cmbGrupi
			// 
			this.cmbGrupi.DefaultErrorMessage = null;
			this.cmbGrupi.IsValid = false;
			this.cmbGrupi.Kolone1Vlere = null;
			this.cmbGrupi.Kolone2Vlere = null;
			this.cmbGrupi.Location = new System.Drawing.Point(0, 0);
			this.cmbGrupi.Name = "cmbGrupi";
			this.cmbGrupi.Required = false;
			this.cmbGrupi.Size = new System.Drawing.Size(136, 24);
			this.cmbGrupi.SkipValidation = false;
			this.cmbGrupi.TabIndex = 0;
			// 
			// comboBox1
			// 
			this.comboBox1.DefaultErrorMessage = null;
			this.comboBox1.IsValid = false;
			this.comboBox1.Location = new System.Drawing.Point(92, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Required = false;
			this.comboBox1.Size = new System.Drawing.Size(16, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Visible = false;
			// 
			// comboBox2
			// 
			this.comboBox2.DefaultErrorMessage = null;
			this.comboBox2.IsValid = false;
			this.comboBox2.Location = new System.Drawing.Point(0, 0);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Required = false;
			this.comboBox2.Size = new System.Drawing.Size(172, 21);
			this.comboBox2.TabIndex = 0;
			// 
			// ds
			// 
			this.ds.DataSetName = "NewDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// btnModifiko
			// 
			this.btnModifiko.BackColor = System.Drawing.Color.Blue;
			this.btnModifiko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifiko.DoValidation = true;
			this.btnModifiko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifiko.Location = new System.Drawing.Point(188, 356);
			this.btnModifiko.Name = "btnModifiko";
			this.btnModifiko.Size = new System.Drawing.Size(90, 21);
			this.btnModifiko.TabIndex = 19;
			this.btnModifiko.Text = "Modifiko";
			this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
			// 
			// btnElimino
			// 
			this.btnElimino.BackColor = System.Drawing.Color.Blue;
			this.btnElimino.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnElimino.DoValidation = true;
			this.btnElimino.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnElimino.Location = new System.Drawing.Point(340, 352);
			this.btnElimino.Name = "btnElimino";
			this.btnElimino.Size = new System.Drawing.Size(90, 21);
			this.btnElimino.TabIndex = 20;
			this.btnElimino.Text = "Elimino";
			this.btnElimino.Click += new System.EventHandler(this.btnElimino_Click);
			// 
			// frmModifikoVeprim1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CheckRequiredFields = true;
			this.ClientSize = new System.Drawing.Size(800, 406);
			this.ControlBox = true;
			this.Controls.Add(this.btnElimino);
			this.Controls.Add(this.btnModifiko);
			this.Controls.Add(this.gbVeprime);
			this.EnableValidation = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmModifikoVeprim1";
			this.ShfaqTitull = false;
			this.ShowInTaskbar = false;
			this.Text = "Modifiko Veprim";
			this.TitullGjeresi = 656;
			this.Load += new System.EventHandler(this.frmModifikoVeprim1_Load);
			this.Controls.SetChildIndex(this.gbVeprime, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.btnModifiko, 0);
			this.Controls.SetChildIndex(this.btnElimino, 0);
			this.gbVeprime.ResumeLayout(false);
			this.cmbKategorite.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

	
		#region FormLoad
		private void frmModifikoVeprim1_Load(object sender, System.EventArgs e)
		{
			InputController data = new InputController();
			try
			{
				ds = data.KerkesaRead("ShfaqMjeteIdentifikimi");
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbMjetId.Kolone1.Items.Add(dr[1]);
					this.cmbMjetId.Kolone2.Items.Add(dr[0]);
				
				}
				ds = data.KerkesaRead("ShfaqGrupet");
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbGrupi1.Kolone1.Items.Add(dr[1]);
					this.cmbGrupi1.Kolone2.Items.Add(dr[0]);
					
				}
				ds = data.KerkesaRead("ShfaqTeDhenaKlientiId",idKlienti);
				this.MbushForm(ds);
				this.klient_hotel = ds.Tables[0].Rows[0][25].ToString(); 
				if(this.klient_hotel == "True")
				{
					this.numSkonto.Visible = false;
					this.numGjoba.Visible = false;
					this.numSkonto.Required = false;
					this.numGjoba.Required = false;
					this.label2.Visible = false;
					this.label3.Visible = false;
				}
				else if(this.klient_hotel == "False" && ds.Tables[0].Rows[0][23].ToString() == "")
				{
					this.numSkonto.Visible = false;
					this.numGjoba.Visible = false;
					this.numSkonto.Required = false;
					this.numGjoba.Required = false;
					this.label2.Visible = false;
					this.label3.Visible = false;
				}
				else
				{
					this.numSkonto.Text = ds.Tables[0].Rows[0][23].ToString();
					this.skonto = Convert.ToInt32(ds.Tables[0].Rows[0][23]);
					this.numGjoba.Text = ds.Tables[0].Rows[0][24].ToString();
					this.gjoba = Convert.ToInt32(ds.Tables[0].Rows[0][24]);
				}
				ds = data.KerkesaRead("ShfaqKategorite");
				// Percaktojme gjatesine e vektorit qe mbaje vlerat e idKategori-se
				int nrRreshta = ds.Tables[0].Rows.Count;
			
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbKategorite.Kolone1.Items.Add(dr[1]);
					this.cmbKategorite.Kolone2.Items.Add(dr[0]);
					
				}
				ds = data.KerkesaRead("ShfaqDhomatEliraPerDatatPerKategorine", idKategoria, dtFillimi, dtMbarimi);
				DataRow r = ds.Tables[0].NewRow();
				r[0]= this.idDhoma;
				r[1]= this.emriDhoma;
				ds.Tables[0].Rows.Add(r);
				ds.AcceptChanges();
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbNrDhoma.Kolone1.Items.Add(dr[1]);
					this.cmbNrDhoma.Kolone2.Items.Add(dr[0]);
				}
			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
		}
		#endregion

	    #region ModifikoVeprim
		private void MbushForm(DataSet ds)
		{
			DataRow dr = ds.Tables[0].Rows[0];
			this.cmbGrupi1.Kolone1.Text = dr[13].ToString();
			this.cmbGrupi1.Kolone2Vlere = dr[15].ToString();
			this.txtEmri.Text = dr[0].ToString();
			this.txtMbiemri.Text = dr[1].ToString();
			this.dtDatelindja.Value = Convert.ToDateTime(dr[2]);
			this.cmbMjetId.Kolone1.Text = Convert.ToString(dr[20]);
			this.cmbMjetId.Kolone2Vlere = dr[11].ToString();
			this.txtIdNo.Text = dr[12].ToString();
			this.txtTelefoni.Text = dr[4].ToString();
			this.txtTarga.Text = dr[6].ToString();
			this.txtAdresa.Text = dr[3].ToString();
			this.txtEmail.Text = dr[5].ToString();
			this.cmbKategorite.Kolone1.Text = dr[19].ToString();
			this.cmbNrDhoma.Kolone1.Text = dr[17].ToString();
			this.idKategoria = Convert.ToInt32(dr[22]);
			this.idIdentifikimi = Convert.ToInt32(dr[10]);
			
			this.emriDhoma = dr[17].ToString();
			this.idDhoma = Convert.ToInt32(dr[16]);
			this.numCmimi.Text = dr[18].ToString();
			this.dtpFillimi.Value = dr[7].ToString();
			this.dtpMbarimi.Value = dr[8].ToString();
			this.numKapari.Text = dr[9].ToString();
			
		
			string a = dr[15].ToString();
			if (a == "")
				idGrupi = 0;
			else
				this.idGrupi = Convert.ToInt32(a);
			
			this.idDhoma = Convert.ToInt32(dr[16]);
			this.dataKapari = Convert.ToDateTime(dr[26]);
		}

		private void btnModifiko_Click(object sender, System.EventArgs e)
		{
			DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimi.Value);
			DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
			int a = this.KntData(this.idKategoria,dataFillimi,dataMbarimi);
			if(a == 0)
			{
				
				this.dtpFillimi.IsValid = true;
				this.error.SetError(this.dtpFillimi,"");
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifiko Veprim Klienti", 
					"Jeni te sigurte qe doni ta modifikoni kete veprim ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.No)
					return;

				int b = 0;
				string emri = this.txtEmri.Text;
				string mbiemri = this.txtMbiemri.Text;
				DateTime datelindja = Convert.ToDateTime(this.dtDatelindja.Value);
				string MjetIdentifikimi = this.cmbMjetId.Kolone1Vlere.ToString();
				string nrIdentifikimi = this.txtIdNo.Text;
				string adresa = this.txtAdresa.Text;
				string telefoni = this.txtTelefoni.Text;
				string targa = this.txtTarga.Text;
				string email = this.txtEmail.Text;
				this.idLloji = Convert.ToInt32(this.cmbMjetId.Kolone2Vlere);
				this.idDhoma = Convert.ToInt32(this.cmbNrDhoma.Kolone2Vlere);
				int kapari = Convert.ToInt32(this.numKapari.Text);
				
				InputController data = new InputController();
				DateTime dataKapariERe = dataFillimi.AddMilliseconds(DateTime.Now.Millisecond);
					

				if(this.klient_hotel == "False")
				{
					DialogResult result1 = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifiko Veprim Klienti",
						"Kujdes klienti nuk eshte ne hotel.Deshironi te vazhdoni?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (result1 == DialogResult.No)
						this.Close();
					if(this.numSkonto.Visible == true)
					{
						int skontoERe = Convert.ToInt32(this.numSkonto.Text);
						int gjobaERe = Convert.ToInt32(this.numGjoba.Text);
						System.TimeSpan dif = dataMbarimi.Subtract(dataFillimi);
						int nrDite = Convert.ToInt32(dif.Days);
						int pagesa = nrDite * Convert.ToInt32(this.numCmimi.Text) - skonto + gjoba;
						int pagesaERe = nrDite * Convert.ToInt32(this.numCmimi.Text) - skontoERe + gjobaERe;
						int diferenca = pagesa - pagesaERe;
						if(diferenca != 0)
							System.Windows.Forms.MessageBox.Show(this,"Modifikimi i skontos ose gjobes shoqerohet"+
								Environment.NewLine+"me ndryshim te pageses se kryer nga klienti"+
								Environment.NewLine+" per dhomen, si rrjedhim ju duhet te kyeni"+
								Environment.NewLine+" hedhje manuale ne arke me vlere: "+diferenca+"$","Modifikim Veprim Klienti", MessageBoxButtons.OK, MessageBoxIcon.Information);

						b = data.KerkesaUpdate("ModifikoVeprimKlient", emri, mbiemri, datelindja, MjetIdentifikimi, nrIdentifikimi,adresa, telefoni,targa, email, 
							dataFillimi, dataMbarimi, kapari,this.idKlienti,this.idGrupi,this.idIdentifikimi,this.idLloji,this.idDhoma,skontoERe,gjobaERe,dataKapariERe,dataKapari);
						if (b == 0)
						{
							this.Pastro(this.gbVeprime);
							result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifiko Veprim Klienti",
								"Veprimi u modifikua  me sukses ", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						this.Close();
					}
					else
					{
						b = data.KerkesaUpdate("ModifikoVeprimKlientPaPagese", emri, mbiemri, datelindja, MjetIdentifikimi, nrIdentifikimi,adresa, telefoni,targa, email, 
							dataFillimi, dataMbarimi, kapari,this.idKlienti,this.idGrupi,this.idIdentifikimi,this.idLloji,this.idDhoma,dataKapariERe,dataKapari);
						if (b == 0)
						{
							this.Pastro(this.gbVeprime);
							result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifiko Veprim Klienti",
								"Veprimi u modifikua  me sukses ", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						this.Close();
					}
				}
				else if(this.klient_hotel == "True" && (DateTime.Now > dtMbarimi))
				{
					DialogResult result1 = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifiko Veprim Klienti",
						"Kujdes klienti nuk e ka dorezuar dhomen, por data e daljes per te ka kaluar.Deshironi te vazhdoni?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (result1 == DialogResult.No)
						this.Close();
					
					b = data.KerkesaUpdate("ModifikoVeprimKlientPaPagese", emri, mbiemri, datelindja, MjetIdentifikimi, nrIdentifikimi,adresa, telefoni,targa, email, 
						dataFillimi, dataMbarimi, kapari,this.idKlienti,this.idGrupi,this.idIdentifikimi,this.idLloji,this.idDhoma,dataKapariERe,dataKapari);
					if (b == 0)
					{
						this.Pastro(this.gbVeprime);
						result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifiko Veprim Klienti",
							"Veprimi u modifikua  me sukses ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					this.Close();
				}
					//n.q.s klienti eshte ne hotel
				else
				{
						
					b = data.KerkesaUpdate("ModifikoVeprimKlientPaPagese", emri, mbiemri, datelindja, MjetIdentifikimi, nrIdentifikimi,adresa, telefoni,targa, email, 
						dataFillimi, dataMbarimi, kapari,this.idKlienti,this.idGrupi,this.idIdentifikimi,this.idLloji,this.idDhoma,dataKapariERe,dataKapari);
					if (b == 0)
					{
						this.Pastro(this.gbVeprime);
						result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifiko Veprim Klienti",
							"Veprimi u modifikua  me sukses ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					this.Close();
				}
				
			}
			
			
			else if(a == 1)
			{
				this.cmbKategorite.Kolone1.Text = "";
				this.dtpFillimi.IsValid = false;
				this.error.SetError(this.dtpFillimi, "Data e hyrjes se klientit duhet te jete me e vogel se data e daljes!");
				return;
			}
			
		
			}

		private void btnElimino_Click(object sender, System.EventArgs e)
		{
			DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Fshi Veprim Klienti", 
				"Jeni te sigurte qe doni ta fshini kete veprim ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No)
				return;
			int b = 0;
			int idGrupi = Convert.ToInt32(this.cmbGrupi.Kolone2Vlere );
			int kapari = 0;
			DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimi.Value);
			DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
			InputController data = new InputController();
			b = data.KerkesaUpdate("FshiVeprimKlient",this.idKlienti,this.idGrupi,this.idIdentifikimi);
			
			if (this.klient_hotel == "False")
			{
				//TODO: Ne varesi te numrit te gabimit do te shfaqen mesazhet perkatese
				if (b == 0)
					result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Fshi Veprim Klienti",
						"Veprimi i zgjedhur u eliminua. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
				result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Fshi Veprim Klienti",
					"Veprimi nuk mund te eliminohet, lutemi provoni perseri! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			}
			else if (this.klient_hotel == "True")
			{
				//TODO: Ne varesi te numrit te gabimit do te shfaqen mesazhet perkatese
				result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Fshi Veprim Klienti",
					"Veprimi nuk mund te eliminohet, klienti eshte ne hotel. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			}
			this.Close();
		
		}

		private void MbushKategorite()
		{
			this.cmbKategorite.Kolone1.Items.Clear();
			this.cmbKategorite.Kolone1.Items.Clear();
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqKategorite");
			// Percaktojme gjatesine e vektorit qe mbaje vlerat e idKategori-se
			int nrRreshta = ds.Tables[0].Rows.Count;
			
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbKategorite.Kolone1.Items.Add(dr[1]);
				this.cmbKategorite.Kolone2.Items.Add(dr[0]);
					
			}
		}
		private void cmbKategorite_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			
			DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimi.Value);
			DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
			this.cmbNrDhoma.Kolone1.Items.Clear();
			this.cmbNrDhoma.Kolone2.Items.Clear();
			this.cmbNrDhoma.Kolone1.Text = "";
			int idKategoria = Convert.ToInt32(this.cmbKategorite.Kolone2Vlere);
			InputController data = new InputController();
			
			ds = data.KerkesaRead("ShfaqDhomatEliraPerDatatPerKategorine", idKategoria, dtFillimi, dtMbarimi);
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbNrDhoma.Kolone1.Items.Add(dr[1]);
				this.cmbNrDhoma.Kolone2.Items.Add(dr[0]);
			}
			int b = 0;
			if(ds.Tables[0].Rows.Count == 0)
			{
				b = this.KntKonfCmimDhome(idKategoria,dtFillimi);
				if(b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this,"Ne daten e hyrjes se klientit, per dhomat e kategorise se zgjedhur"+Environment.NewLine+
						"ju nuk keni konfiguruar cmimet."+Environment.NewLine+
						Environment.NewLine+
						"Ju lutemi konfiguroni cmimin ose zgjidhni nje kategori tjeter!","Merr Dhome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.MbushKategorite();
					this.cmbKategorite.Kolone1.Text = "";
					return;
				}
				else
					b = 3;
			}
				
			if(b == 3)
			{
				System.Windows.Forms.MessageBox.Show(this,"Per kategorine e zgjedhur,gjendja e dhomave"+Environment.NewLine+
					"eshte e zene."+Environment.NewLine+
					Environment.NewLine+
					"Ju lutemi zgjidhni nje kategori tjeter!","Merr Dhome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.MbushKategorite();
				this.cmbKategorite.Kolone1.Text = "";
				return;
			}
				
		}

		private void cmbNrDhoma_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			DataSet ds1 = null;
			DataSet ds = new DataSet() ;
			ds.Tables.Add();
			ds.Tables[0].Columns.Add("ID_DHOMA",typeof(int));
			ds.Tables[0].Columns.Add("DHOMA_EMRI",typeof(string));
			ds.AcceptChanges();	
			DataRow r = ds.Tables[0].NewRow();
			r[0]= this.idDhoma;
			r[1]= this.emriDhoma;
			ds.Tables[0].Rows.Add(r);
			ds.AcceptChanges();	

			InputController data = new InputController();
			int idDhoma = Convert.ToInt32(cmbNrDhoma.Kolone2Vlere);
			DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimi.Value);
			DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
			ds1 = data.KerkesaRead("ShfaqCmimPerDhomenDheDatatEdhena", idDhoma, dtFillimi, dtMbarimi);
			//Nese dhomes i eshte caktuar cmimi atehere paraqit cmimin e pare per kete interval datash
			if (ds1.Tables[0].Rows.Count > 0)
				numCmimi.Text = ds1.Tables[0].Rows[0][2].ToString();
		}

		
		#endregion
	
		#region MetodaNdihmese
	
		private int KntKonfCmimDhome(int idKategoria,DateTime dtFillimi)
		{
			DataSet ds = null;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqCmimetEdhomavePerDatenEdhene", dtFillimi);
			int a = 0;	
			if(ds.Tables[0].Rows.Count != 0)
			{
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					if(idKategoria  == Convert.ToInt32(dr[0]))
						a = 1;
					
				}
			}
			else
				a = 2;
			return a;
		}
		private int KntData(int idKategoria,DateTime dtFillimi,DateTime dtMbarimi )
		{
			int a = 0;
			System.TimeSpan nrDite = dtFillimi.Subtract(dtMbarimi);
			int difDite = Convert.ToInt32(nrDite.Days);
			int difOre = Convert.ToInt32(nrDite.Hours);
			if(dtFillimi > System.DateTime.Now)
				a = 2;
			else
			{
				if(idKategoria != 31)
				{
					if (difDite > 0  || difOre > 0)
						a = 1;	
					else
						a = 0;
				}
				else
				{
					if (difDite != 0 )
					{
						if(difDite > 0)
							a = 1;
						else
							a = 0;
					}
					else if(difDite == 0)
					{
						if(difOre >= 0)
							a = 1;
						else
							a = 0;
					}
					else
						a = 0;
				}
			}
			return a;	
				
		}
		
		#endregion

		



		

	

		
	}
}

