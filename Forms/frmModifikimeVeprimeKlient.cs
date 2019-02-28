using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using VisionInfoSolutionLibrary;
using System.Text.RegularExpressions;


namespace HotelManagment.Forms
{
	public class frmModifikimeVeprimeKlient : VisionInfoSolutionLibrary.Form
	{
		#region Private Variables
		private VisionInfoSolutionLibrary.TabControl tabControl1;
		private VisionInfoSolutionLibrary.TabPageControl tbIndivid;
		private VisionInfoSolutionLibrary.TabPageControl tbGrup;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.RadioButton rbKlienti;
		private VisionInfoSolutionLibrary.RadioButton rbDhoma;
		private VisionInfoSolutionLibrary.RadioButton rbDatat;
		private VisionInfoSolutionLibrary.TextBox txtEmri;
		private VisionInfoSolutionLibrary.TextBox txtMbiemri;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhomat;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimi;
		private VisionInfoSolutionLibrary.Button btnKerko;
		private VisionInfoSolutionLibrary.Label lblMbiemri;
		private VisionInfoSolutionLibrary.Label lblEmri;
		private VisionInfoSolutionLibrary.Label lblTarga;
		private VisionInfoSolutionLibrary.Label lblAdresa;
		private VisionInfoSolutionLibrary.Label label7;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.TextBox txtIdNo;
		private VisionInfoSolutionLibrary.Label lblIdNo;
		private VisionInfoSolutionLibrary.Label lblMbarimMarrje;
		private VisionInfoSolutionLibrary.Label lblFillimMarrje;
		private VisionInfoSolutionLibrary.Label lblEmail;
		private VisionInfoSolutionLibrary.Label lblID;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.Label label4;
		private VisionInfoSolutionLibrary.NumericBox numGjoba;
		private VisionInfoSolutionLibrary.NumericBox numSkonto;
		private VisionInfoSolutionLibrary.NumericBox numCmimi;
		private VisionInfoSolutionLibrary.Label lblCmimi;
		private VisionInfoSolutionLibrary.NumericBox numKapari;
		private VisionInfoSolutionLibrary.Label label6;
		private VisionInfoSolutionLibrary.Label lblNrDhoma;
		private VisionInfoSolutionLibrary.GroupBox gbHyrjet;
		private VisionInfoSolutionLibrary.DataGrid gridKlienti;
		private VisionInfoSolutionLibrary.RadioButton rbGrupi;
		private VisionInfoSolutionLibrary.DoubleCombo cmbGrupet;
		private VisionInfoSolutionLibrary.RadioButton rbDataGrupi;
		private VisionInfoSolutionLibrary.TextBox txtAgjensiaKerkim;
		private VisionInfoSolutionLibrary.RadioButton rbDhomaGrupi;
		private VisionInfoSolutionLibrary.Button btnKerkoGrup;
		private VisionInfoSolutionLibrary.Label label8;
		private VisionInfoSolutionLibrary.Label label9;
		private VisionInfoSolutionLibrary.Label label10;
		private VisionInfoSolutionLibrary.Label label11;
		private VisionInfoSolutionLibrary.Label label12;
		private VisionInfoSolutionLibrary.TextBox txtAgjensiaTeDhena;
		private VisionInfoSolutionLibrary.Label label13;
		private VisionInfoSolutionLibrary.Button btnModifikoVeprimKlient;
		private VisionInfoSolutionLibrary.TextBox txtDhoma;
		private VisionInfoSolutionLibrary.Label label14;
		private VisionInfoSolutionLibrary.Label label15;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhomatTeDhena;
		private VisionInfoSolutionLibrary.TextBox txtGrupi;
		private VisionInfoSolutionLibrary.Label label16;
		private VisionInfoSolutionLibrary.Label label17;
		private VisionInfoSolutionLibrary.Label label18;
		private VisionInfoSolutionLibrary.Label label19;
		private VisionInfoSolutionLibrary.Label label20;
		private VisionInfoSolutionLibrary.Label label21;
		private VisionInfoSolutionLibrary.Label label22;
		private VisionInfoSolutionLibrary.Label label23;
		private VisionInfoSolutionLibrary.Label label24;
		private VisionInfoSolutionLibrary.Label label25;
		private VisionInfoSolutionLibrary.Label label26;
		private VisionInfoSolutionLibrary.Label label27;
		private VisionInfoSolutionLibrary.Label label28;
		private VisionInfoSolutionLibrary.Label label29;
		private VisionInfoSolutionLibrary.Label label30;
		private VisionInfoSolutionLibrary.Label label31;
		private VisionInfoSolutionLibrary.Label label32;
		private VisionInfoSolutionLibrary.Label label33;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhomatGrupi;
		private VisionInfoSolutionLibrary.DoubleCombo cmbGrupetTeDhena;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategoria;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategoriaGrup;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimiGrup;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimiGrup;
		private VisionInfoSolutionLibrary.DataGrid gridGrupi;
		private VisionInfoSolutionLibrary.GroupBox gbGrup;
		private VisionInfoSolutionLibrary.Label label34;
		private VisionInfoSolutionLibrary.NumericBox numCmimiKlienti;
		private VisionInfoSolutionLibrary.Label label35;
		private VisionInfoSolutionLibrary.NumericBox numCmimiGrupi;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKlientet;
		private VisionInfoSolutionLibrary.NumericBox numGjobaGrupi;
		private VisionInfoSolutionLibrary.NumericBox numSkontoGrupi;
		private VisionInfoSolutionLibrary.NumericBox numKapariGrupi;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKlientetGrupi;
		private VisionInfoSolutionLibrary.TextBox txtAgjensiaTeDhena1;
		private VisionInfoSolutionLibrary.Button btnEleminoKlient;
		private VisionInfoSolutionLibrary.Button btnModifikoKlient;
		private VisionInfoSolutionLibrary.GroupBox gbKlientet;
		private VisionInfoSolutionLibrary.GroupBox gbDhoma;
		private VisionInfoSolutionLibrary.Button btnEleminoKlientGrup;
		private VisionInfoSolutionLibrary.Button btnModifikoKlientGrup;
		private VisionInfoSolutionLibrary.Button btnModifikoVeprimGrup;
		private VisionInfoSolutionLibrary.GroupBox gbKlientetGrupi;
		private VisionInfoSolutionLibrary.GroupBox gbGrupi;
		private VisionInfoSolutionLibrary.TextBox txtEmriKlienti;
		private VisionInfoSolutionLibrary.DoubleCombo cmbMjeteIdentifikimi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDaljeKlienti;
		private VisionInfoSolutionLibrary.DateTimePicker dtpHyrjeKlienti;
		private VisionInfoSolutionLibrary.TextBox txtMbiemriKlienti;
		private VisionInfoSolutionLibrary.TextBox txtEmailKlienti;
		private VisionInfoSolutionLibrary.TextBox txtTargaKlienti;
		private VisionInfoSolutionLibrary.TextBox txtAdresaKlienti;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDatelindjaKlienti;
		private VisionInfoSolutionLibrary.TextBox txtTelefoniKlienti;
		private VisionInfoSolutionLibrary.TextBox txtEmailGrupi;
		private VisionInfoSolutionLibrary.TextBox txtAdresaGrupi;
		private VisionInfoSolutionLibrary.TextBox txtTelGrupi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDatelindjaGrupi;
		private VisionInfoSolutionLibrary.TextBox txtIdNoGrupi;
		private VisionInfoSolutionLibrary.DoubleCombo cmbMjeteId;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhomatGrup;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDaljeGrupi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpHyrjeGrupi;
		private VisionInfoSolutionLibrary.TextBox txtMbiemriKlientiGrupi;
		private VisionInfoSolutionLibrary.TextBox txtEmriKlientiGrupi;
		private VisionInfoSolutionLibrary.TextBox txtTargaGrupi;
		private VisionInfoSolutionLibrary.Label label36;
		private VisionInfoSolutionLibrary.Label label37;
		private VisionInfoSolutionLibrary.TextBox txtVendlindjaKlienti;
		private VisionInfoSolutionLibrary.TextBox txtShtetesiaKlienti;
		private VisionInfoSolutionLibrary.TextBox txtShtetesiaGrupi;
		private VisionInfoSolutionLibrary.TextBox txtVendlindjaGrupi;
		private VisionInfoSolutionLibrary.Label label38;
		private VisionInfoSolutionLibrary.Label label39;
		private VisionInfoSolutionLibrary.CheckBox cbVlefshmeKlienti;
		private VisionInfoSolutionLibrary.CheckBox cbVlefshmeGrupi;
		private VisionInfoSolutionLibrary.CheckBox cbKlienti;
		private VisionInfoSolutionLibrary.CheckBox cbDhoma;
		private VisionInfoSolutionLibrary.Label lblDataKlienti;
		private VisionInfoSolutionLibrary.CheckBox cbGrupi;
		private VisionInfoSolutionLibrary.CheckBox cbDhomaGrupi;
		private VisionInfoSolutionLibrary.Label lblDataGrupi;
		private VisionInfoSolutionLibrary.Label label40;
		private VisionInfoSolutionLibrary.DoubleCombo cmbPagesaKlienti;
		private VisionInfoSolutionLibrary.Label label41;
		private VisionInfoSolutionLibrary.DoubleCombo cmbPagesaGrupi;
		private bool clicked;
		private System.Data.DataSet ds_klient;
		private System.Data.DataSet ds_grupi;
		private System.Data.DataSet pagesa;
		#endregion

		#region Constructors & Destructors
		public frmModifikimeVeprimeKlient()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

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
			this.tabControl1 = new VisionInfoSolutionLibrary.TabControl();
			this.tbIndivid = new VisionInfoSolutionLibrary.TabPageControl();
			this.lblDataKlienti = new VisionInfoSolutionLibrary.Label();
			this.cbDhoma = new VisionInfoSolutionLibrary.CheckBox();
			this.cbKlienti = new VisionInfoSolutionLibrary.CheckBox();
			this.cbVlefshmeKlienti = new VisionInfoSolutionLibrary.CheckBox();
			this.btnEleminoKlient = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifikoKlient = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifikoVeprimKlient = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbKlientet = new VisionInfoSolutionLibrary.GroupBox();
			this.txtShtetesiaKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.txtVendlindjaKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.label37 = new VisionInfoSolutionLibrary.Label();
			this.label36 = new VisionInfoSolutionLibrary.Label();
			this.lblEmri = new VisionInfoSolutionLibrary.Label();
			this.numCmimiKlienti = new VisionInfoSolutionLibrary.NumericBox();
			this.label34 = new VisionInfoSolutionLibrary.Label();
			this.cmbDhomatTeDhena = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbKategoria = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label15 = new VisionInfoSolutionLibrary.Label();
			this.label14 = new VisionInfoSolutionLibrary.Label();
			this.txtEmriKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.label13 = new VisionInfoSolutionLibrary.Label();
			this.cmbKlientet = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbMjeteIdentifikimi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.lblID = new VisionInfoSolutionLibrary.Label();
			this.lblMbarimMarrje = new VisionInfoSolutionLibrary.Label();
			this.dtpDaljeKlienti = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpHyrjeKlienti = new VisionInfoSolutionLibrary.DateTimePicker();
			this.lblFillimMarrje = new VisionInfoSolutionLibrary.Label();
			this.txtEmailKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.lblEmail = new VisionInfoSolutionLibrary.Label();
			this.txtTargaKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.lblTarga = new VisionInfoSolutionLibrary.Label();
			this.lblAdresa = new VisionInfoSolutionLibrary.Label();
			this.txtAdresaKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.dtpDatelindjaKlienti = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label7 = new VisionInfoSolutionLibrary.Label();
			this.txtTelefoniKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.txtMbiemriKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.lblMbiemri = new VisionInfoSolutionLibrary.Label();
			this.txtIdNo = new VisionInfoSolutionLibrary.TextBox();
			this.lblIdNo = new VisionInfoSolutionLibrary.Label();
			this.gbDhoma = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbPagesaKlienti = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label40 = new VisionInfoSolutionLibrary.Label();
			this.txtDhoma = new VisionInfoSolutionLibrary.TextBox();
			this.lblNrDhoma = new VisionInfoSolutionLibrary.Label();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.numGjoba = new VisionInfoSolutionLibrary.NumericBox();
			this.numSkonto = new VisionInfoSolutionLibrary.NumericBox();
			this.numCmimi = new VisionInfoSolutionLibrary.NumericBox();
			this.lblCmimi = new VisionInfoSolutionLibrary.Label();
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.numKapari = new VisionInfoSolutionLibrary.NumericBox();
			this.gbHyrjet = new VisionInfoSolutionLibrary.GroupBox();
			this.gridKlienti = new VisionInfoSolutionLibrary.DataGrid();
			this.btnKerko = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.cmbDhomat = new VisionInfoSolutionLibrary.DoubleCombo();
			this.txtMbiemri = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
			this.rbDhoma = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbKlienti = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.dtpFillimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.rbDatat = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.dtpMbarimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.tbGrup = new VisionInfoSolutionLibrary.TabPageControl();
			this.lblDataGrupi = new VisionInfoSolutionLibrary.Label();
			this.cbDhomaGrupi = new VisionInfoSolutionLibrary.CheckBox();
			this.cbGrupi = new VisionInfoSolutionLibrary.CheckBox();
			this.cbVlefshmeGrupi = new VisionInfoSolutionLibrary.CheckBox();
			this.btnEleminoKlientGrup = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifikoKlientGrup = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifikoVeprimGrup = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbKlientetGrupi = new VisionInfoSolutionLibrary.GroupBox();
			this.label21 = new VisionInfoSolutionLibrary.Label();
			this.numCmimiGrupi = new VisionInfoSolutionLibrary.NumericBox();
			this.label35 = new VisionInfoSolutionLibrary.Label();
			this.txtEmailGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtTargaGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtAdresaGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtTelGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.dtpDatelindjaGrupi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.txtIdNoGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.cmbMjeteId = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbDhomatGrup = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbKategoriaGrup = new VisionInfoSolutionLibrary.DoubleCombo();
			this.dtpDaljeGrupi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpHyrjeGrupi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.txtMbiemriKlientiGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmriKlientiGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtAgjensiaTeDhena1 = new VisionInfoSolutionLibrary.TextBox();
			this.cmbGrupetTeDhena = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbKlientetGrupi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label31 = new VisionInfoSolutionLibrary.Label();
			this.label30 = new VisionInfoSolutionLibrary.Label();
			this.label29 = new VisionInfoSolutionLibrary.Label();
			this.label28 = new VisionInfoSolutionLibrary.Label();
			this.label27 = new VisionInfoSolutionLibrary.Label();
			this.label26 = new VisionInfoSolutionLibrary.Label();
			this.label25 = new VisionInfoSolutionLibrary.Label();
			this.label24 = new VisionInfoSolutionLibrary.Label();
			this.label23 = new VisionInfoSolutionLibrary.Label();
			this.label22 = new VisionInfoSolutionLibrary.Label();
			this.label20 = new VisionInfoSolutionLibrary.Label();
			this.label19 = new VisionInfoSolutionLibrary.Label();
			this.label18 = new VisionInfoSolutionLibrary.Label();
			this.label17 = new VisionInfoSolutionLibrary.Label();
			this.label16 = new VisionInfoSolutionLibrary.Label();
			this.txtShtetesiaGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtVendlindjaGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.label38 = new VisionInfoSolutionLibrary.Label();
			this.label39 = new VisionInfoSolutionLibrary.Label();
			this.gbGrupi = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbPagesaGrupi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label41 = new VisionInfoSolutionLibrary.Label();
			this.txtGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtAgjensiaTeDhena = new VisionInfoSolutionLibrary.TextBox();
			this.label12 = new VisionInfoSolutionLibrary.Label();
			this.label11 = new VisionInfoSolutionLibrary.Label();
			this.label8 = new VisionInfoSolutionLibrary.Label();
			this.label9 = new VisionInfoSolutionLibrary.Label();
			this.numGjobaGrupi = new VisionInfoSolutionLibrary.NumericBox();
			this.numSkontoGrupi = new VisionInfoSolutionLibrary.NumericBox();
			this.numKapariGrupi = new VisionInfoSolutionLibrary.NumericBox();
			this.label10 = new VisionInfoSolutionLibrary.Label();
			this.btnKerkoGrup = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbGrup = new VisionInfoSolutionLibrary.GroupBox();
			this.gridGrupi = new VisionInfoSolutionLibrary.DataGrid();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.label33 = new VisionInfoSolutionLibrary.Label();
			this.label32 = new VisionInfoSolutionLibrary.Label();
			this.cmbGrupet = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbDhomatGrupi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.txtAgjensiaKerkim = new VisionInfoSolutionLibrary.TextBox();
			this.rbDhomaGrupi = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbGrupi = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.dtpMbarimiGrup = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpFillimiGrup = new VisionInfoSolutionLibrary.DateTimePicker();
			this.rbDataGrupi = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.ds_klient = new System.Data.DataSet();
			this.ds_grupi = new System.Data.DataSet();
			this.pagesa = new System.Data.DataSet();
			this.tabControl1.SuspendLayout();
			this.tbIndivid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbKlientet)).BeginInit();
			this.gbKlientet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbDhoma)).BeginInit();
			this.gbDhoma.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbHyrjet)).BeginInit();
			this.gbHyrjet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridKlienti)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tbGrup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbKlientetGrupi)).BeginInit();
			this.gbKlientetGrupi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbGrupi)).BeginInit();
			this.gbGrupi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbGrup)).BeginInit();
			this.gbGrup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridGrupi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds_klient)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_grupi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pagesa)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1032, 25);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tbIndivid);
			this.tabControl1.Controls.Add(this.tbGrup);
			this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.tabControl1.Location = new System.Drawing.Point(0, 25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1028, 610);
			this.tabControl1.TabIndex = 1;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tbIndivid
			// 
			this.tbIndivid.BackColor = System.Drawing.SystemColors.Control;
			this.tbIndivid.Controls.Add(this.lblDataKlienti);
			this.tbIndivid.Controls.Add(this.cbDhoma);
			this.tbIndivid.Controls.Add(this.cbKlienti);
			this.tbIndivid.Controls.Add(this.cbVlefshmeKlienti);
			this.tbIndivid.Controls.Add(this.btnEleminoKlient);
			this.tbIndivid.Controls.Add(this.btnModifikoKlient);
			this.tbIndivid.Controls.Add(this.btnModifikoVeprimKlient);
			this.tbIndivid.Controls.Add(this.gbKlientet);
			this.tbIndivid.Controls.Add(this.gbDhoma);
			this.tbIndivid.Controls.Add(this.gbHyrjet);
			this.tbIndivid.Controls.Add(this.btnKerko);
			this.tbIndivid.Controls.Add(this.groupBox1);
			this.tbIndivid.DefaultErrorMessage = null;
			this.tbIndivid.EnableValidation = true;
			this.tbIndivid.IsValid = false;
			this.tbIndivid.Location = new System.Drawing.Point(4, 22);
			this.tbIndivid.Name = "tbIndivid";
			this.tbIndivid.Size = new System.Drawing.Size(1020, 584);
			this.tbIndivid.TabIndex = 0;
			this.tbIndivid.Text = "Individuale";
			// 
			// lblDataKlienti
			// 
			this.lblDataKlienti.BackColor = System.Drawing.Color.Transparent;
			this.lblDataKlienti.Location = new System.Drawing.Point(364, 20);
			this.lblDataKlienti.Name = "lblDataKlienti";
			this.lblDataKlienti.Size = new System.Drawing.Size(80, 20);
			this.lblDataKlienti.TabIndex = 9;
			this.lblDataKlienti.Text = "Midis datave";
			this.lblDataKlienti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbDhoma
			// 
			this.cbDhoma.BackColor = System.Drawing.Color.Transparent;
			this.cbDhoma.DefaultErrorMessage = "";
			this.cbDhoma.IsValid = true;
			this.cbDhoma.Location = new System.Drawing.Point(632, 76);
			this.cbDhoma.Name = "cbDhoma";
			this.cbDhoma.Size = new System.Drawing.Size(72, 24);
			this.cbDhoma.TabIndex = 55;
			this.cbDhoma.Text = "Dhomes";
			// 
			// cbKlienti
			// 
			this.cbKlienti.BackColor = System.Drawing.Color.Transparent;
			this.cbKlienti.DefaultErrorMessage = "";
			this.cbKlienti.IsValid = true;
			this.cbKlienti.Location = new System.Drawing.Point(632, 48);
			this.cbKlienti.Name = "cbKlienti";
			this.cbKlienti.Size = new System.Drawing.Size(72, 24);
			this.cbKlienti.TabIndex = 54;
			this.cbKlienti.Text = "Klientit";
			// 
			// cbVlefshmeKlienti
			// 
			this.cbVlefshmeKlienti.BackColor = System.Drawing.Color.Transparent;
			this.cbVlefshmeKlienti.Checked = true;
			this.cbVlefshmeKlienti.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbVlefshmeKlienti.DefaultErrorMessage = "";
			this.cbVlefshmeKlienti.IsValid = true;
			this.cbVlefshmeKlienti.Location = new System.Drawing.Point(18, 24);
			this.cbVlefshmeKlienti.Name = "cbVlefshmeKlienti";
			this.cbVlefshmeKlienti.Size = new System.Drawing.Size(104, 16);
			this.cbVlefshmeKlienti.TabIndex = 50;
			this.cbVlefshmeKlienti.Text = "Hyrje te vlefshme";
			this.cbVlefshmeKlienti.CheckedChanged += new System.EventHandler(this.cbVlefshmeKlienti_CheckedChanged);
			// 
			// btnEleminoKlient
			// 
			this.btnEleminoKlient.BackColor = System.Drawing.Color.Blue;
			this.btnEleminoKlient.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEleminoKlient.DoValidation = true;
			this.btnEleminoKlient.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnEleminoKlient.Location = new System.Drawing.Point(776, 532);
			this.btnEleminoKlient.Name = "btnEleminoKlient";
			this.btnEleminoKlient.Size = new System.Drawing.Size(90, 21);
			this.btnEleminoKlient.TabIndex = 86;
			this.btnEleminoKlient.Text = "Elemino klient";
			this.toolTips.SetToolTip(this.btnEleminoKlient, "Eleminon klientin e zgjedhur dhe veprimet qe ka kryer ne arke!");
			this.btnEleminoKlient.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnEleminoKlient.Click += new System.EventHandler(this.btnEleminoKlient_Click);
			// 
			// btnModifikoKlient
			// 
			this.btnModifikoKlient.BackColor = System.Drawing.Color.Blue;
			this.btnModifikoKlient.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifikoKlient.DoValidation = true;
			this.btnModifikoKlient.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifikoKlient.Location = new System.Drawing.Point(656, 532);
			this.btnModifikoKlient.Name = "btnModifikoKlient";
			this.btnModifikoKlient.Size = new System.Drawing.Size(90, 21);
			this.btnModifikoKlient.TabIndex = 85;
			this.btnModifikoKlient.Text = "Modifiko klient";
			this.toolTips.SetToolTip(this.btnModifikoKlient, "Modifikon te dhenat per klientin e zgjedhur!");
			this.btnModifikoKlient.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifikoKlient.Click += new System.EventHandler(this.btnModifikoKlient_Click);
			// 
			// btnModifikoVeprimKlient
			// 
			this.btnModifikoVeprimKlient.BackColor = System.Drawing.Color.Blue;
			this.btnModifikoVeprimKlient.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifikoVeprimKlient.DoValidation = false;
			this.btnModifikoVeprimKlient.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifikoVeprimKlient.Location = new System.Drawing.Point(698, 252);
			this.btnModifikoVeprimKlient.Name = "btnModifikoVeprimKlient";
			this.btnModifikoVeprimKlient.Size = new System.Drawing.Size(90, 21);
			this.btnModifikoVeprimKlient.TabIndex = 67;
			this.btnModifikoVeprimKlient.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifikoVeprimKlient, "Modifikon te dhenat e kaparit, skontos, gjobes qe mund t\'i jene aplikuar dhomes!");
			this.btnModifikoVeprimKlient.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifikoVeprimKlient.Click += new System.EventHandler(this.btnModifikoVeprimKlient_Click);
			// 
			// gbKlientet
			// 
			this.gbKlientet.BackColor = System.Drawing.Color.Transparent;
			this.gbKlientet.Controls.Add(this.txtShtetesiaKlienti);
			this.gbKlientet.Controls.Add(this.txtVendlindjaKlienti);
			this.gbKlientet.Controls.Add(this.label37);
			this.gbKlientet.Controls.Add(this.label36);
			this.gbKlientet.Controls.Add(this.lblEmri);
			this.gbKlientet.Controls.Add(this.numCmimiKlienti);
			this.gbKlientet.Controls.Add(this.label34);
			this.gbKlientet.Controls.Add(this.cmbDhomatTeDhena);
			this.gbKlientet.Controls.Add(this.cmbKategoria);
			this.gbKlientet.Controls.Add(this.label15);
			this.gbKlientet.Controls.Add(this.label14);
			this.gbKlientet.Controls.Add(this.txtEmriKlienti);
			this.gbKlientet.Controls.Add(this.label13);
			this.gbKlientet.Controls.Add(this.cmbKlientet);
			this.gbKlientet.Controls.Add(this.cmbMjeteIdentifikimi);
			this.gbKlientet.Controls.Add(this.lblID);
			this.gbKlientet.Controls.Add(this.lblMbarimMarrje);
			this.gbKlientet.Controls.Add(this.dtpDaljeKlienti);
			this.gbKlientet.Controls.Add(this.dtpHyrjeKlienti);
			this.gbKlientet.Controls.Add(this.lblFillimMarrje);
			this.gbKlientet.Controls.Add(this.txtEmailKlienti);
			this.gbKlientet.Controls.Add(this.lblEmail);
			this.gbKlientet.Controls.Add(this.txtTargaKlienti);
			this.gbKlientet.Controls.Add(this.lblTarga);
			this.gbKlientet.Controls.Add(this.lblAdresa);
			this.gbKlientet.Controls.Add(this.txtAdresaKlienti);
			this.gbKlientet.Controls.Add(this.dtpDatelindjaKlienti);
			this.gbKlientet.Controls.Add(this.label7);
			this.gbKlientet.Controls.Add(this.txtTelefoniKlienti);
			this.gbKlientet.Controls.Add(this.label5);
			this.gbKlientet.Controls.Add(this.txtMbiemriKlienti);
			this.gbKlientet.Controls.Add(this.lblMbiemri);
			this.gbKlientet.Controls.Add(this.txtIdNo);
			this.gbKlientet.Controls.Add(this.lblIdNo);
			this.gbKlientet.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbKlientet.Location = new System.Drawing.Point(468, 280);
			this.gbKlientet.Name = "gbKlientet";
			this.gbKlientet.Size = new System.Drawing.Size(544, 240);
			this.gbKlientet.TabIndex = 4;
			this.gbKlientet.Text = "Te dhenat per klientet";
			this.gbKlientet.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// txtShtetesiaKlienti
			// 
			this.txtShtetesiaKlienti.AutoSize = false;
			this.txtShtetesiaKlienti.DefaultErrorMessage = "";
			this.txtShtetesiaKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtShtetesiaKlienti.FixedLength = false;
			this.txtShtetesiaKlienti.IsValid = true;
			this.txtShtetesiaKlienti.Location = new System.Drawing.Point(364, 64);
			this.txtShtetesiaKlienti.Name = "txtShtetesiaKlienti";
			this.txtShtetesiaKlienti.Required = false;
			this.txtShtetesiaKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtShtetesiaKlienti.Size = new System.Drawing.Size(160, 21);
			this.txtShtetesiaKlienti.TabIndex = 78;
			this.txtShtetesiaKlienti.Text = "";
			// 
			// txtVendlindjaKlienti
			// 
			this.txtVendlindjaKlienti.AutoSize = false;
			this.txtVendlindjaKlienti.DefaultErrorMessage = "";
			this.txtVendlindjaKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtVendlindjaKlienti.FixedLength = false;
			this.txtVendlindjaKlienti.IsValid = true;
			this.txtVendlindjaKlienti.Location = new System.Drawing.Point(364, 40);
			this.txtVendlindjaKlienti.Name = "txtVendlindjaKlienti";
			this.txtVendlindjaKlienti.Required = false;
			this.txtVendlindjaKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtVendlindjaKlienti.Size = new System.Drawing.Size(160, 21);
			this.txtVendlindjaKlienti.TabIndex = 77;
			this.txtVendlindjaKlienti.Text = "";
			// 
			// label37
			// 
			this.label37.Location = new System.Drawing.Point(284, 64);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(72, 20);
			this.label37.TabIndex = 109;
			this.label37.Text = "Shtetesia";
			this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label36
			// 
			this.label36.Location = new System.Drawing.Point(284, 44);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(72, 16);
			this.label36.TabIndex = 108;
			this.label36.Text = "Vendlindja";
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblEmri
			// 
			this.lblEmri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmri.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblEmri.Location = new System.Drawing.Point(-4, 20);
			this.lblEmri.Name = "lblEmri";
			this.lblEmri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblEmri.Size = new System.Drawing.Size(96, 16);
			this.lblEmri.TabIndex = 35;
			this.lblEmri.Text = "Klientet ne dhome";
			// 
			// numCmimiKlienti
			// 
			this.numCmimiKlienti.AutoSize = false;
			this.numCmimiKlienti.DefaultErrorMessage = "";
			this.numCmimiKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numCmimiKlienti.DigitsAfterDecimalPoint = 0;
			this.numCmimiKlienti.FixedLength = false;
			this.numCmimiKlienti.IsValid = false;
			this.numCmimiKlienti.KeepFocus = false;
			this.numCmimiKlienti.Location = new System.Drawing.Point(100, 184);
			this.numCmimiKlienti.Name = "numCmimiKlienti";
			this.numCmimiKlienti.OnlyPositive = true;
			this.numCmimiKlienti.ReadOnly = true;
			this.numCmimiKlienti.Required = true;
			this.numCmimiKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimiKlienti.Size = new System.Drawing.Size(160, 21);
			this.numCmimiKlienti.TabIndex = 75;
			this.numCmimiKlienti.Text = "";
			this.numCmimiKlienti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label34
			// 
			this.label34.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label34.Location = new System.Drawing.Point(28, 184);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(64, 20);
			this.label34.TabIndex = 106;
			this.label34.Text = "Cmimi";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbDhomatTeDhena
			// 
			this.cmbDhomatTeDhena.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhomatTeDhena.DefaultErrorMessage = "Zgjidhni dhomen qe do t\'i caktohet klientit!";
			this.cmbDhomatTeDhena.IsValid = false;
			this.cmbDhomatTeDhena.Kolone1Vlere = null;
			this.cmbDhomatTeDhena.Kolone2Vlere = null;
			this.cmbDhomatTeDhena.Location = new System.Drawing.Point(100, 160);
			this.cmbDhomatTeDhena.Name = "cmbDhomatTeDhena";
			this.cmbDhomatTeDhena.ReadOnly = false;
			this.cmbDhomatTeDhena.Required = true;
			this.cmbDhomatTeDhena.Size = new System.Drawing.Size(160, 21);
			this.cmbDhomatTeDhena.SkipValidation = false;
			this.cmbDhomatTeDhena.TabIndex = 74;
			this.cmbDhomatTeDhena.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbDhomatTeDhena_SelectedIndexChanged);
			// 
			// cmbKategoria
			// 
			this.cmbKategoria.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategoria.DefaultErrorMessage = "Zgjidhni nje prej kategorive para se te zgjidhni dhomen!";
			this.cmbKategoria.IsValid = false;
			this.cmbKategoria.Kolone1Vlere = null;
			this.cmbKategoria.Kolone2Vlere = null;
			this.cmbKategoria.Location = new System.Drawing.Point(100, 136);
			this.cmbKategoria.Name = "cmbKategoria";
			this.cmbKategoria.ReadOnly = false;
			this.cmbKategoria.Required = true;
			this.cmbKategoria.Size = new System.Drawing.Size(160, 21);
			this.cmbKategoria.SkipValidation = false;
			this.cmbKategoria.TabIndex = 73;
			this.cmbKategoria.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategoria_SelectedIndexChanged);
			// 
			// label15
			// 
			this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label15.Location = new System.Drawing.Point(28, 164);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(64, 16);
			this.label15.TabIndex = 103;
			this.label15.Text = "Dhoma";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label14.Location = new System.Drawing.Point(16, 140);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(76, 16);
			this.label14.TabIndex = 102;
			this.label14.Text = "Kategoria";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmriKlienti
			// 
			this.txtEmriKlienti.AutoSize = false;
			this.txtEmriKlienti.DefaultErrorMessage = "Vendosni emrin e klientit!";
			this.txtEmriKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmriKlienti.FixedLength = false;
			this.txtEmriKlienti.IsValid = false;
			this.txtEmriKlienti.Location = new System.Drawing.Point(100, 40);
			this.txtEmriKlienti.Name = "txtEmriKlienti";
			this.txtEmriKlienti.Required = true;
			this.txtEmriKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmriKlienti.Size = new System.Drawing.Size(160, 21);
			this.txtEmriKlienti.TabIndex = 69;
			this.txtEmriKlienti.Text = "";
			// 
			// label13
			// 
			this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label13.Location = new System.Drawing.Point(24, 44);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(68, 16);
			this.label13.TabIndex = 100;
			this.label13.Text = "Emri";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbKlientet
			// 
			this.cmbKlientet.BackColor = System.Drawing.Color.Transparent;
			this.cmbKlientet.DefaultErrorMessage = "Zgjidhni nje prej veprimeve ne te majte para se te modifikoni apo te eleminoni!";
			this.cmbKlientet.IsValid = false;
			this.cmbKlientet.Kolone1Vlere = null;
			this.cmbKlientet.Kolone2Vlere = null;
			this.cmbKlientet.Location = new System.Drawing.Point(100, 16);
			this.cmbKlientet.Name = "cmbKlientet";
			this.cmbKlientet.ReadOnly = false;
			this.cmbKlientet.Required = true;
			this.cmbKlientet.Size = new System.Drawing.Size(160, 21);
			this.cmbKlientet.SkipValidation = false;
			this.cmbKlientet.TabIndex = 68;
			this.cmbKlientet.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKlientet_SelectedIndexChanged);
			// 
			// cmbMjeteIdentifikimi
			// 
			this.cmbMjeteIdentifikimi.BackColor = System.Drawing.Color.Transparent;
			this.cmbMjeteIdentifikimi.DefaultErrorMessage = "Zgjidhni llojin e mjetit te identifikimit!";
			this.cmbMjeteIdentifikimi.IsValid = false;
			this.cmbMjeteIdentifikimi.Kolone1Vlere = null;
			this.cmbMjeteIdentifikimi.Kolone2Vlere = null;
			this.cmbMjeteIdentifikimi.Location = new System.Drawing.Point(364, 88);
			this.cmbMjeteIdentifikimi.Name = "cmbMjeteIdentifikimi";
			this.cmbMjeteIdentifikimi.ReadOnly = false;
			this.cmbMjeteIdentifikimi.Required = true;
			this.cmbMjeteIdentifikimi.Size = new System.Drawing.Size(160, 21);
			this.cmbMjeteIdentifikimi.SkipValidation = false;
			this.cmbMjeteIdentifikimi.TabIndex = 79;
			// 
			// lblID
			// 
			this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblID.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblID.Location = new System.Drawing.Point(264, 92);
			this.lblID.Name = "lblID";
			this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblID.Size = new System.Drawing.Size(92, 20);
			this.lblID.TabIndex = 97;
			this.lblID.Text = "Mjeti i identifikimit";
			// 
			// lblMbarimMarrje
			// 
			this.lblMbarimMarrje.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblMbarimMarrje.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblMbarimMarrje.Location = new System.Drawing.Point(12, 116);
			this.lblMbarimMarrje.Name = "lblMbarimMarrje";
			this.lblMbarimMarrje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblMbarimMarrje.Size = new System.Drawing.Size(80, 12);
			this.lblMbarimMarrje.TabIndex = 96;
			this.lblMbarimMarrje.Text = "Date mbarimi";
			// 
			// dtpDaljeKlienti
			// 
			this.dtpDaljeKlienti.BackColor = System.Drawing.Color.White;
			this.dtpDaljeKlienti.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpDaljeKlienti.DefaultErrorMessage = "Vendosni daten e daljes!";
			this.dtpDaljeKlienti.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDaljeKlienti.IsValid = true;
			this.dtpDaljeKlienti.Location = new System.Drawing.Point(100, 112);
			this.dtpDaljeKlienti.Name = "dtpDaljeKlienti";
			this.dtpDaljeKlienti.Required = true;
			this.dtpDaljeKlienti.ShowCheckBox = true;
			this.dtpDaljeKlienti.ShowUpDown = true;
			this.dtpDaljeKlienti.Size = new System.Drawing.Size(160, 20);
			this.dtpDaljeKlienti.TabIndex = 72;
			this.dtpDaljeKlienti.Value = new System.DateTime(2005, 10, 6, 15, 14, 0, 0);
			this.dtpDaljeKlienti.ValueChanged += new System.EventHandler(this.dtpDaljeKlienti_ValueChanged);
			// 
			// dtpHyrjeKlienti
			// 
			this.dtpHyrjeKlienti.BackColor = System.Drawing.Color.White;
			this.dtpHyrjeKlienti.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpHyrjeKlienti.DefaultErrorMessage = "Vendosni daten e hyrjes!";
			this.dtpHyrjeKlienti.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHyrjeKlienti.IsValid = true;
			this.dtpHyrjeKlienti.Location = new System.Drawing.Point(100, 88);
			this.dtpHyrjeKlienti.Name = "dtpHyrjeKlienti";
			this.dtpHyrjeKlienti.Required = false;
			this.dtpHyrjeKlienti.ShowCheckBox = true;
			this.dtpHyrjeKlienti.ShowUpDown = true;
			this.dtpHyrjeKlienti.Size = new System.Drawing.Size(160, 20);
			this.dtpHyrjeKlienti.TabIndex = 71;
			this.dtpHyrjeKlienti.Value = new System.DateTime(2005, 10, 6, 15, 14, 0, 0);
			this.dtpHyrjeKlienti.ValueChanged += new System.EventHandler(this.dtpHyrjeKlienti_ValueChanged);
			// 
			// lblFillimMarrje
			// 
			this.lblFillimMarrje.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblFillimMarrje.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblFillimMarrje.Location = new System.Drawing.Point(16, 92);
			this.lblFillimMarrje.Name = "lblFillimMarrje";
			this.lblFillimMarrje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblFillimMarrje.Size = new System.Drawing.Size(76, 12);
			this.lblFillimMarrje.TabIndex = 93;
			this.lblFillimMarrje.Text = "Date fillimi";
			// 
			// txtEmailKlienti
			// 
			this.txtEmailKlienti.AutoSize = false;
			this.txtEmailKlienti.DefaultErrorMessage = "";
			this.txtEmailKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmailKlienti.FixedLength = false;
			this.txtEmailKlienti.IsValid = true;
			this.txtEmailKlienti.Location = new System.Drawing.Point(364, 208);
			this.txtEmailKlienti.Name = "txtEmailKlienti";
			this.txtEmailKlienti.Required = false;
			this.txtEmailKlienti.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.txtEmailKlienti.Size = new System.Drawing.Size(160, 21);
			this.txtEmailKlienti.TabIndex = 84;
			this.txtEmailKlienti.Text = "";
			// 
			// lblEmail
			// 
			this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblEmail.Location = new System.Drawing.Point(308, 212);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblEmail.Size = new System.Drawing.Size(48, 16);
			this.lblEmail.TabIndex = 91;
			this.lblEmail.Text = "E-Mail";
			// 
			// txtTargaKlienti
			// 
			this.txtTargaKlienti.AutoSize = false;
			this.txtTargaKlienti.DefaultErrorMessage = "";
			this.txtTargaKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTargaKlienti.FixedLength = false;
			this.txtTargaKlienti.IsValid = true;
			this.txtTargaKlienti.Location = new System.Drawing.Point(364, 184);
			this.txtTargaKlienti.Name = "txtTargaKlienti";
			this.txtTargaKlienti.Required = false;
			this.txtTargaKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtTargaKlienti.Size = new System.Drawing.Size(160, 21);
			this.txtTargaKlienti.TabIndex = 83;
			this.txtTargaKlienti.Text = "";
			// 
			// lblTarga
			// 
			this.lblTarga.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblTarga.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTarga.Location = new System.Drawing.Point(320, 188);
			this.lblTarga.Name = "lblTarga";
			this.lblTarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblTarga.Size = new System.Drawing.Size(36, 20);
			this.lblTarga.TabIndex = 89;
			this.lblTarga.Text = "Targa";
			// 
			// lblAdresa
			// 
			this.lblAdresa.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblAdresa.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblAdresa.Location = new System.Drawing.Point(312, 160);
			this.lblAdresa.Name = "lblAdresa";
			this.lblAdresa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblAdresa.Size = new System.Drawing.Size(44, 20);
			this.lblAdresa.TabIndex = 88;
			this.lblAdresa.Text = "Adresa";
			// 
			// txtAdresaKlienti
			// 
			this.txtAdresaKlienti.AutoSize = false;
			this.txtAdresaKlienti.DefaultErrorMessage = "";
			this.txtAdresaKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAdresaKlienti.FixedLength = false;
			this.txtAdresaKlienti.IsValid = false;
			this.txtAdresaKlienti.Location = new System.Drawing.Point(364, 160);
			this.txtAdresaKlienti.Name = "txtAdresaKlienti";
			this.txtAdresaKlienti.Required = false;
			this.txtAdresaKlienti.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.txtAdresaKlienti.Size = new System.Drawing.Size(160, 21);
			this.txtAdresaKlienti.TabIndex = 82;
			this.txtAdresaKlienti.Text = "";
			// 
			// dtpDatelindjaKlienti
			// 
			this.dtpDatelindjaKlienti.BackColor = System.Drawing.Color.White;
			this.dtpDatelindjaKlienti.CustomFormat = "dd.MM.yyyy";
			this.dtpDatelindjaKlienti.DefaultErrorMessage = "Vendosni datelindjen per klientin!";
			this.dtpDatelindjaKlienti.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDatelindjaKlienti.IsValid = true;
			this.dtpDatelindjaKlienti.Location = new System.Drawing.Point(364, 16);
			this.dtpDatelindjaKlienti.Name = "dtpDatelindjaKlienti";
			this.dtpDatelindjaKlienti.Required = true;
			this.dtpDatelindjaKlienti.ShowCheckBox = true;
			this.dtpDatelindjaKlienti.ShowUpDown = true;
			this.dtpDatelindjaKlienti.Size = new System.Drawing.Size(160, 20);
			this.dtpDatelindjaKlienti.TabIndex = 76;
			this.dtpDatelindjaKlienti.Value = new System.DateTime(2005, 10, 6, 15, 14, 0, 0);
			// 
			// label7
			// 
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(288, 20);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label7.Size = new System.Drawing.Size(68, 16);
			this.label7.TabIndex = 85;
			this.label7.Text = "Datelindja";
			// 
			// txtTelefoniKlienti
			// 
			this.txtTelefoniKlienti.AutoSize = false;
			this.txtTelefoniKlienti.DefaultErrorMessage = "";
			this.txtTelefoniKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTelefoniKlienti.FixedLength = false;
			this.txtTelefoniKlienti.IsValid = true;
			this.txtTelefoniKlienti.Location = new System.Drawing.Point(364, 136);
			this.txtTelefoniKlienti.Name = "txtTelefoniKlienti";
			this.txtTelefoniKlienti.Required = false;
			this.txtTelefoniKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtTelefoniKlienti.Size = new System.Drawing.Size(160, 21);
			this.txtTelefoniKlienti.TabIndex = 81;
			this.txtTelefoniKlienti.Text = "";
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(300, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 20);
			this.label5.TabIndex = 83;
			this.label5.Text = "Nr telefoni";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMbiemriKlienti
			// 
			this.txtMbiemriKlienti.AutoSize = false;
			this.txtMbiemriKlienti.DefaultErrorMessage = "Vendosni mbiemrin e klientit!";
			this.txtMbiemriKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemriKlienti.FixedLength = false;
			this.txtMbiemriKlienti.IsValid = false;
			this.txtMbiemriKlienti.Location = new System.Drawing.Point(100, 64);
			this.txtMbiemriKlienti.Name = "txtMbiemriKlienti";
			this.txtMbiemriKlienti.Required = true;
			this.txtMbiemriKlienti.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.txtMbiemriKlienti.Size = new System.Drawing.Size(160, 21);
			this.txtMbiemriKlienti.TabIndex = 70;
			this.txtMbiemriKlienti.Text = "";
			// 
			// lblMbiemri
			// 
			this.lblMbiemri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblMbiemri.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblMbiemri.Location = new System.Drawing.Point(24, 68);
			this.lblMbiemri.Name = "lblMbiemri";
			this.lblMbiemri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblMbiemri.Size = new System.Drawing.Size(68, 16);
			this.lblMbiemri.TabIndex = 36;
			this.lblMbiemri.Text = "Mbiemri";
			// 
			// txtIdNo
			// 
			this.txtIdNo.AutoSize = false;
			this.txtIdNo.DefaultErrorMessage = "Vendosni numrin e identifikimit!";
			this.txtIdNo.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtIdNo.FixedLength = false;
			this.txtIdNo.IsValid = false;
			this.txtIdNo.Location = new System.Drawing.Point(364, 112);
			this.txtIdNo.Name = "txtIdNo";
			this.txtIdNo.Required = true;
			this.txtIdNo.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.txtIdNo.Size = new System.Drawing.Size(160, 21);
			this.txtIdNo.TabIndex = 80;
			this.txtIdNo.Text = "";
			// 
			// lblIdNo
			// 
			this.lblIdNo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblIdNo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblIdNo.Location = new System.Drawing.Point(276, 116);
			this.lblIdNo.Name = "lblIdNo";
			this.lblIdNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblIdNo.Size = new System.Drawing.Size(80, 16);
			this.lblIdNo.TabIndex = 81;
			this.lblIdNo.Text = "Nr identifikimi";
			// 
			// gbDhoma
			// 
			this.gbDhoma.BackColor = System.Drawing.Color.Transparent;
			this.gbDhoma.Controls.Add(this.cmbPagesaKlienti);
			this.gbDhoma.Controls.Add(this.label40);
			this.gbDhoma.Controls.Add(this.txtDhoma);
			this.gbDhoma.Controls.Add(this.lblNrDhoma);
			this.gbDhoma.Controls.Add(this.label3);
			this.gbDhoma.Controls.Add(this.label4);
			this.gbDhoma.Controls.Add(this.numGjoba);
			this.gbDhoma.Controls.Add(this.numSkonto);
			this.gbDhoma.Controls.Add(this.numCmimi);
			this.gbDhoma.Controls.Add(this.lblCmimi);
			this.gbDhoma.Controls.Add(this.label6);
			this.gbDhoma.Controls.Add(this.numKapari);
			this.gbDhoma.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbDhoma.Location = new System.Drawing.Point(468, 144);
			this.gbDhoma.Name = "gbDhoma";
			this.gbDhoma.Size = new System.Drawing.Size(544, 96);
			this.gbDhoma.TabIndex = 3;
			this.gbDhoma.Text = "Te dhenat per dhomen";
			this.gbDhoma.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbPagesaKlienti
			// 
			this.cmbPagesaKlienti.BackColor = System.Drawing.Color.Transparent;
			this.cmbPagesaKlienti.DefaultErrorMessage = "Zgjidhni formen e pageses!";
			this.cmbPagesaKlienti.IsValid = false;
			this.cmbPagesaKlienti.Kolone1Vlere = null;
			this.cmbPagesaKlienti.Kolone2Vlere = null;
			this.cmbPagesaKlienti.Location = new System.Drawing.Point(100, 66);
			this.cmbPagesaKlienti.Name = "cmbPagesaKlienti";
			this.cmbPagesaKlienti.ReadOnly = false;
			this.cmbPagesaKlienti.Required = true;
			this.cmbPagesaKlienti.Size = new System.Drawing.Size(160, 21);
			this.cmbPagesaKlienti.SkipValidation = false;
			this.cmbPagesaKlienti.TabIndex = 63;
			// 
			// label40
			// 
			this.label40.Location = new System.Drawing.Point(24, 69);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(68, 20);
			this.label40.TabIndex = 95;
			this.label40.Text = "Pagesa ne";
			this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDhoma
			// 
			this.txtDhoma.AutoSize = false;
			this.txtDhoma.DefaultErrorMessage = "";
			this.txtDhoma.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtDhoma.FixedLength = false;
			this.txtDhoma.IsValid = false;
			this.txtDhoma.Location = new System.Drawing.Point(100, 16);
			this.txtDhoma.Name = "txtDhoma";
			this.txtDhoma.ReadOnly = true;
			this.txtDhoma.Required = true;
			this.txtDhoma.RequiredControlColor = System.Drawing.Color.White;
			this.txtDhoma.Size = new System.Drawing.Size(160, 21);
			this.txtDhoma.TabIndex = 61;
			this.txtDhoma.Text = "";
			// 
			// lblNrDhoma
			// 
			this.lblNrDhoma.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblNrDhoma.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNrDhoma.Location = new System.Drawing.Point(52, 20);
			this.lblNrDhoma.Name = "lblNrDhoma";
			this.lblNrDhoma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblNrDhoma.Size = new System.Drawing.Size(40, 20);
			this.lblNrDhoma.TabIndex = 93;
			this.lblNrDhoma.Text = "Dhoma";
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(320, 68);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label3.Size = new System.Drawing.Size(36, 16);
			this.label3.TabIndex = 92;
			this.label3.Text = "Gjoba";
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(304, 44);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label4.Size = new System.Drawing.Size(52, 16);
			this.label4.TabIndex = 91;
			this.label4.Text = "Skonto";
			// 
			// numGjoba
			// 
			this.numGjoba.AutoSize = false;
			this.numGjoba.DefaultErrorMessage = "Vendosni 0 ose nje vlere per gjoben!";
			this.numGjoba.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numGjoba.DigitsAfterDecimalPoint = 0;
			this.numGjoba.FixedLength = false;
			this.numGjoba.IsValid = false;
			this.numGjoba.KeepFocus = false;
			this.numGjoba.Location = new System.Drawing.Point(364, 66);
			this.numGjoba.Name = "numGjoba";
			this.numGjoba.OnlyPositive = true;
			this.numGjoba.Required = true;
			this.numGjoba.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.numGjoba.Size = new System.Drawing.Size(160, 21);
			this.numGjoba.TabIndex = 66;
			this.numGjoba.Text = "";
			this.numGjoba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// numSkonto
			// 
			this.numSkonto.AutoSize = false;
			this.numSkonto.DefaultErrorMessage = "Vendosni 0 ose nje vlere per skonton!";
			this.numSkonto.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numSkonto.DigitsAfterDecimalPoint = 0;
			this.numSkonto.FixedLength = false;
			this.numSkonto.IsValid = false;
			this.numSkonto.KeepFocus = false;
			this.numSkonto.Location = new System.Drawing.Point(364, 41);
			this.numSkonto.Name = "numSkonto";
			this.numSkonto.OnlyPositive = true;
			this.numSkonto.Required = true;
			this.numSkonto.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.numSkonto.Size = new System.Drawing.Size(160, 21);
			this.numSkonto.TabIndex = 65;
			this.numSkonto.Text = "";
			this.numSkonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
			this.numCmimi.Location = new System.Drawing.Point(100, 41);
			this.numCmimi.Name = "numCmimi";
			this.numCmimi.OnlyPositive = true;
			this.numCmimi.ReadOnly = true;
			this.numCmimi.Required = true;
			this.numCmimi.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimi.Size = new System.Drawing.Size(160, 21);
			this.numCmimi.TabIndex = 62;
			this.numCmimi.Text = "";
			this.numCmimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblCmimi
			// 
			this.lblCmimi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblCmimi.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCmimi.Location = new System.Drawing.Point(56, 45);
			this.lblCmimi.Name = "lblCmimi";
			this.lblCmimi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCmimi.Size = new System.Drawing.Size(36, 16);
			this.lblCmimi.TabIndex = 87;
			this.lblCmimi.Text = "Cmimi";
			// 
			// label6
			// 
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(320, 20);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label6.Size = new System.Drawing.Size(36, 16);
			this.label6.TabIndex = 85;
			this.label6.Text = "Kapari";
			// 
			// numKapari
			// 
			this.numKapari.AutoSize = false;
			this.numKapari.DefaultErrorMessage = "Vendosni 0 ose nje vlere per kaparin!";
			this.numKapari.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numKapari.DigitsAfterDecimalPoint = 0;
			this.numKapari.FixedLength = false;
			this.numKapari.IsValid = false;
			this.numKapari.KeepFocus = false;
			this.numKapari.Location = new System.Drawing.Point(364, 16);
			this.numKapari.Name = "numKapari";
			this.numKapari.OnlyPositive = true;
			this.numKapari.Required = true;
			this.numKapari.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.numKapari.Size = new System.Drawing.Size(160, 21);
			this.numKapari.TabIndex = 64;
			this.numKapari.Text = "";
			this.numKapari.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// gbHyrjet
			// 
			this.gbHyrjet.BackColor = System.Drawing.Color.Transparent;
			this.gbHyrjet.Controls.Add(this.gridKlienti);
			this.gbHyrjet.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbHyrjet.Location = new System.Drawing.Point(10, 144);
			this.gbHyrjet.Name = "gbHyrjet";
			this.gbHyrjet.Size = new System.Drawing.Size(448, 416);
			this.gbHyrjet.TabIndex = 2;
			this.gbHyrjet.Text = "Hyrjet individuale te vlefshme ne hotel";
			this.gbHyrjet.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// gridKlienti
			// 
			this.gridKlienti.AllowSorting = false;
			this.gridKlienti.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.gridKlienti.CanDelete = true;
			this.gridKlienti.CaptionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.gridKlienti.CaptionVisible = false;
			this.gridKlienti.DataMember = "";
			this.gridKlienti.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gridKlienti.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridKlienti.HideHorizontalScrollBar = false;
			this.gridKlienti.HideVerticalScrollBar = false;
			this.gridKlienti.Location = new System.Drawing.Point(12, 20);
			this.gridKlienti.Name = "gridKlienti";
			this.gridKlienti.RowHeaderWidth = 20;
			this.gridKlienti.Selekto = true;
			this.gridKlienti.Size = new System.Drawing.Size(424, 384);
			this.gridKlienti.TabIndex = 0;
			this.toolTips.SetToolTip(this.gridKlienti, "Zgjidhni nje prej hyrjeve per te modifikuar ose eleminuar klientet perberes!");
			this.gridKlienti.CurrentCellChanged += new System.EventHandler(this.gridKlienti_CurrentCellChanged);
			// 
			// btnKerko
			// 
			this.btnKerko.BackColor = System.Drawing.Color.Blue;
			this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko.DoValidation = false;
			this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko.Location = new System.Drawing.Point(476, 68);
			this.btnKerko.Name = "btnKerko";
			this.btnKerko.Size = new System.Drawing.Size(90, 21);
			this.btnKerko.TabIndex = 1;
			this.btnKerko.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko, "Kerkon per hyrjet individuale ne hotel qe plotesojne kriteret e zgjedhur!");
			this.btnKerko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbDhomat);
			this.groupBox1.Controls.Add(this.txtMbiemri);
			this.groupBox1.Controls.Add(this.txtEmri);
			this.groupBox1.Controls.Add(this.rbDhoma);
			this.groupBox1.Controls.Add(this.rbKlienti);
			this.groupBox1.Controls.Add(this.dtpFillimi);
			this.groupBox1.Controls.Add(this.rbDatat);
			this.groupBox1.Controls.Add(this.dtpMbarimi);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(10, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(448, 132);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.Text = "Kerkim sipas";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(272, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "Mbiemri";
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(104, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "Emri";
			// 
			// cmbDhomat
			// 
			this.cmbDhomat.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhomat.DefaultErrorMessage = null;
			this.cmbDhomat.IsValid = false;
			this.cmbDhomat.Kolone1Vlere = null;
			this.cmbDhomat.Kolone2Vlere = null;
			this.cmbDhomat.Location = new System.Drawing.Point(104, 100);
			this.cmbDhomat.Name = "cmbDhomat";
			this.cmbDhomat.ReadOnly = false;
			this.cmbDhomat.Required = false;
			this.cmbDhomat.Size = new System.Drawing.Size(160, 21);
			this.cmbDhomat.SkipValidation = false;
			this.cmbDhomat.TabIndex = 60;
			// 
			// txtMbiemri
			// 
			this.txtMbiemri.AutoSize = false;
			this.txtMbiemri.DefaultErrorMessage = "";
			this.txtMbiemri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemri.FixedLength = false;
			this.txtMbiemri.IsValid = true;
			this.txtMbiemri.Location = new System.Drawing.Point(272, 72);
			this.txtMbiemri.Name = "txtMbiemri";
			this.txtMbiemri.Required = false;
			this.txtMbiemri.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemri.Size = new System.Drawing.Size(160, 21);
			this.txtMbiemri.TabIndex = 59;
			this.txtMbiemri.Text = "";
			// 
			// txtEmri
			// 
			this.txtEmri.AutoSize = false;
			this.txtEmri.DefaultErrorMessage = "";
			this.txtEmri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri.FixedLength = false;
			this.txtEmri.IsValid = true;
			this.txtEmri.Location = new System.Drawing.Point(104, 72);
			this.txtEmri.Name = "txtEmri";
			this.txtEmri.Required = false;
			this.txtEmri.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri.Size = new System.Drawing.Size(160, 21);
			this.txtEmri.TabIndex = 58;
			this.txtEmri.Text = "";
			// 
			// rbDhoma
			// 
			this.rbDhoma.Location = new System.Drawing.Point(8, 102);
			this.rbDhoma.Name = "rbDhoma";
			this.rbDhoma.Size = new System.Drawing.Size(80, 20);
			this.rbDhoma.TabIndex = 53;
			this.rbDhoma.Text = "Dhomes";
			// 
			// rbKlienti
			// 
			this.rbKlienti.Location = new System.Drawing.Point(8, 74);
			this.rbKlienti.Name = "rbKlienti";
			this.rbKlienti.Size = new System.Drawing.Size(72, 20);
			this.rbKlienti.TabIndex = 52;
			this.rbKlienti.Text = "Klientit";
			// 
			// dtpFillimi
			// 
			this.dtpFillimi.CustomFormat = "dd.MM.yyyy";
			this.dtpFillimi.DefaultErrorMessage = "";
			this.dtpFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimi.IsValid = true;
			this.dtpFillimi.Location = new System.Drawing.Point(104, 36);
			this.dtpFillimi.Name = "dtpFillimi";
			this.dtpFillimi.Required = false;
			this.dtpFillimi.ShowCheckBox = true;
			this.dtpFillimi.ShowUpDown = true;
			this.dtpFillimi.Size = new System.Drawing.Size(160, 20);
			this.dtpFillimi.TabIndex = 56;
			this.dtpFillimi.Value = new System.DateTime(2005, 10, 6, 15, 14, 0, 0);
			// 
			// rbDatat
			// 
			this.rbDatat.Location = new System.Drawing.Point(8, 38);
			this.rbDatat.Name = "rbDatat";
			this.rbDatat.Size = new System.Drawing.Size(84, 20);
			this.rbDatat.TabIndex = 51;
			this.rbDatat.Text = "Midis datave";
			// 
			// dtpMbarimi
			// 
			this.dtpMbarimi.CustomFormat = "dd.MM.yyyy";
			this.dtpMbarimi.DefaultErrorMessage = "";
			this.dtpMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimi.IsValid = true;
			this.dtpMbarimi.Location = new System.Drawing.Point(272, 36);
			this.dtpMbarimi.Name = "dtpMbarimi";
			this.dtpMbarimi.Required = false;
			this.dtpMbarimi.ShowCheckBox = true;
			this.dtpMbarimi.ShowUpDown = true;
			this.dtpMbarimi.Size = new System.Drawing.Size(160, 20);
			this.dtpMbarimi.TabIndex = 57;
			this.dtpMbarimi.Value = new System.DateTime(2005, 10, 6, 15, 14, 0, 0);
			// 
			// tbGrup
			// 
			this.tbGrup.BackColor = System.Drawing.SystemColors.Control;
			this.tbGrup.Controls.Add(this.lblDataGrupi);
			this.tbGrup.Controls.Add(this.cbDhomaGrupi);
			this.tbGrup.Controls.Add(this.cbGrupi);
			this.tbGrup.Controls.Add(this.cbVlefshmeGrupi);
			this.tbGrup.Controls.Add(this.btnEleminoKlientGrup);
			this.tbGrup.Controls.Add(this.btnModifikoKlientGrup);
			this.tbGrup.Controls.Add(this.btnModifikoVeprimGrup);
			this.tbGrup.Controls.Add(this.gbKlientetGrupi);
			this.tbGrup.Controls.Add(this.gbGrupi);
			this.tbGrup.Controls.Add(this.btnKerkoGrup);
			this.tbGrup.Controls.Add(this.gbGrup);
			this.tbGrup.Controls.Add(this.groupBox2);
			this.tbGrup.DefaultErrorMessage = null;
			this.tbGrup.EnableValidation = true;
			this.tbGrup.IsValid = false;
			this.tbGrup.Location = new System.Drawing.Point(4, 22);
			this.tbGrup.Name = "tbGrup";
			this.tbGrup.Size = new System.Drawing.Size(1020, 584);
			this.tbGrup.TabIndex = 1;
			this.tbGrup.Text = "Ne grup";
			// 
			// lblDataGrupi
			// 
			this.lblDataGrupi.BackColor = System.Drawing.Color.Transparent;
			this.lblDataGrupi.Location = new System.Drawing.Point(352, 20);
			this.lblDataGrupi.Name = "lblDataGrupi";
			this.lblDataGrupi.Size = new System.Drawing.Size(76, 20);
			this.lblDataGrupi.TabIndex = 13;
			this.lblDataGrupi.Text = "Midis datave";
			// 
			// cbDhomaGrupi
			// 
			this.cbDhomaGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cbDhomaGrupi.DefaultErrorMessage = "";
			this.cbDhomaGrupi.IsValid = true;
			this.cbDhomaGrupi.Location = new System.Drawing.Point(616, 64);
			this.cbDhomaGrupi.Name = "cbDhomaGrupi";
			this.cbDhomaGrupi.Size = new System.Drawing.Size(76, 24);
			this.cbDhomaGrupi.TabIndex = 6;
			this.cbDhomaGrupi.Text = "Dhomes";
			// 
			// cbGrupi
			// 
			this.cbGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cbGrupi.DefaultErrorMessage = "";
			this.cbGrupi.IsValid = true;
			this.cbGrupi.Location = new System.Drawing.Point(616, 40);
			this.cbGrupi.Name = "cbGrupi";
			this.cbGrupi.Size = new System.Drawing.Size(76, 24);
			this.cbGrupi.TabIndex = 5;
			this.cbGrupi.Text = "Grupit";
			// 
			// cbVlefshmeGrupi
			// 
			this.cbVlefshmeGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cbVlefshmeGrupi.Checked = true;
			this.cbVlefshmeGrupi.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbVlefshmeGrupi.DefaultErrorMessage = "";
			this.cbVlefshmeGrupi.IsValid = true;
			this.cbVlefshmeGrupi.Location = new System.Drawing.Point(18, 24);
			this.cbVlefshmeGrupi.Name = "cbVlefshmeGrupi";
			this.cbVlefshmeGrupi.Size = new System.Drawing.Size(104, 16);
			this.cbVlefshmeGrupi.TabIndex = 1;
			this.cbVlefshmeGrupi.Text = "Hyrje te vlefshme";
			this.cbVlefshmeGrupi.CheckedChanged += new System.EventHandler(this.cbVlefshmeGrupi_CheckedChanged);
			// 
			// btnEleminoKlientGrup
			// 
			this.btnEleminoKlientGrup.BackColor = System.Drawing.Color.Blue;
			this.btnEleminoKlientGrup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEleminoKlientGrup.DoValidation = true;
			this.btnEleminoKlientGrup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnEleminoKlientGrup.Location = new System.Drawing.Point(764, 544);
			this.btnEleminoKlientGrup.Name = "btnEleminoKlientGrup";
			this.btnEleminoKlientGrup.Size = new System.Drawing.Size(90, 21);
			this.btnEleminoKlientGrup.TabIndex = 40;
			this.btnEleminoKlientGrup.Text = "Elemino klient";
			this.toolTips.SetToolTip(this.btnEleminoKlientGrup, "Eleminon klientin e zgjedhur!");
			this.btnEleminoKlientGrup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnEleminoKlientGrup.Click += new System.EventHandler(this.btnEleminoKlientGrup_Click);
			// 
			// btnModifikoKlientGrup
			// 
			this.btnModifikoKlientGrup.BackColor = System.Drawing.Color.Blue;
			this.btnModifikoKlientGrup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifikoKlientGrup.DoValidation = true;
			this.btnModifikoKlientGrup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifikoKlientGrup.Location = new System.Drawing.Point(644, 544);
			this.btnModifikoKlientGrup.Name = "btnModifikoKlientGrup";
			this.btnModifikoKlientGrup.Size = new System.Drawing.Size(90, 21);
			this.btnModifikoKlientGrup.TabIndex = 39;
			this.btnModifikoKlientGrup.Text = "Modifiko klient";
			this.toolTips.SetToolTip(this.btnModifikoKlientGrup, "Modifikon klientin e zgjedhur!");
			this.btnModifikoKlientGrup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifikoKlientGrup.Click += new System.EventHandler(this.btnModifikoKlientGrup_Click);
			// 
			// btnModifikoVeprimGrup
			// 
			this.btnModifikoVeprimGrup.BackColor = System.Drawing.Color.Blue;
			this.btnModifikoVeprimGrup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifikoVeprimGrup.DoValidation = false;
			this.btnModifikoVeprimGrup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifikoVeprimGrup.Location = new System.Drawing.Point(696, 248);
			this.btnModifikoVeprimGrup.Name = "btnModifikoVeprimGrup";
			this.btnModifikoVeprimGrup.Size = new System.Drawing.Size(90, 21);
			this.btnModifikoVeprimGrup.TabIndex = 19;
			this.btnModifikoVeprimGrup.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifikoVeprimGrup, "Modifikon kaparin, skonton, gjoben qe i eshte aplikuar grupit!");
			this.btnModifikoVeprimGrup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifikoVeprimGrup.Click += new System.EventHandler(this.btnModifikoVeprimGrup_Click);
			// 
			// gbKlientetGrupi
			// 
			this.gbKlientetGrupi.BackColor = System.Drawing.Color.Transparent;
			this.gbKlientetGrupi.Controls.Add(this.label21);
			this.gbKlientetGrupi.Controls.Add(this.numCmimiGrupi);
			this.gbKlientetGrupi.Controls.Add(this.label35);
			this.gbKlientetGrupi.Controls.Add(this.txtEmailGrupi);
			this.gbKlientetGrupi.Controls.Add(this.txtTargaGrupi);
			this.gbKlientetGrupi.Controls.Add(this.txtAdresaGrupi);
			this.gbKlientetGrupi.Controls.Add(this.txtTelGrupi);
			this.gbKlientetGrupi.Controls.Add(this.dtpDatelindjaGrupi);
			this.gbKlientetGrupi.Controls.Add(this.txtIdNoGrupi);
			this.gbKlientetGrupi.Controls.Add(this.cmbMjeteId);
			this.gbKlientetGrupi.Controls.Add(this.cmbDhomatGrup);
			this.gbKlientetGrupi.Controls.Add(this.cmbKategoriaGrup);
			this.gbKlientetGrupi.Controls.Add(this.dtpDaljeGrupi);
			this.gbKlientetGrupi.Controls.Add(this.dtpHyrjeGrupi);
			this.gbKlientetGrupi.Controls.Add(this.txtMbiemriKlientiGrupi);
			this.gbKlientetGrupi.Controls.Add(this.txtEmriKlientiGrupi);
			this.gbKlientetGrupi.Controls.Add(this.txtAgjensiaTeDhena1);
			this.gbKlientetGrupi.Controls.Add(this.cmbGrupetTeDhena);
			this.gbKlientetGrupi.Controls.Add(this.cmbKlientetGrupi);
			this.gbKlientetGrupi.Controls.Add(this.label31);
			this.gbKlientetGrupi.Controls.Add(this.label30);
			this.gbKlientetGrupi.Controls.Add(this.label29);
			this.gbKlientetGrupi.Controls.Add(this.label28);
			this.gbKlientetGrupi.Controls.Add(this.label27);
			this.gbKlientetGrupi.Controls.Add(this.label26);
			this.gbKlientetGrupi.Controls.Add(this.label25);
			this.gbKlientetGrupi.Controls.Add(this.label24);
			this.gbKlientetGrupi.Controls.Add(this.label23);
			this.gbKlientetGrupi.Controls.Add(this.label22);
			this.gbKlientetGrupi.Controls.Add(this.label20);
			this.gbKlientetGrupi.Controls.Add(this.label19);
			this.gbKlientetGrupi.Controls.Add(this.label18);
			this.gbKlientetGrupi.Controls.Add(this.label17);
			this.gbKlientetGrupi.Controls.Add(this.label16);
			this.gbKlientetGrupi.Controls.Add(this.txtShtetesiaGrupi);
			this.gbKlientetGrupi.Controls.Add(this.txtVendlindjaGrupi);
			this.gbKlientetGrupi.Controls.Add(this.label38);
			this.gbKlientetGrupi.Controls.Add(this.label39);
			this.gbKlientetGrupi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbKlientetGrupi.Location = new System.Drawing.Point(468, 272);
			this.gbKlientetGrupi.Name = "gbKlientetGrupi";
			this.gbKlientetGrupi.Size = new System.Drawing.Size(544, 264);
			this.gbKlientetGrupi.TabIndex = 4;
			this.gbKlientetGrupi.Text = "Te dhenat per klientet";
			this.toolTips.SetToolTip(this.gbKlientetGrupi, "Modifikon te dhenat per klientin e zgjdhur!");
			this.gbKlientetGrupi.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label21
			// 
			this.label21.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label21.Location = new System.Drawing.Point(-4, 20);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(88, 16);
			this.label21.TabIndex = 5;
			this.label21.Text = "Klientet e grupit";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numCmimiGrupi
			// 
			this.numCmimiGrupi.AutoSize = false;
			this.numCmimiGrupi.DefaultErrorMessage = "";
			this.numCmimiGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numCmimiGrupi.DigitsAfterDecimalPoint = 0;
			this.numCmimiGrupi.FixedLength = false;
			this.numCmimiGrupi.IsValid = false;
			this.numCmimiGrupi.KeepFocus = false;
			this.numCmimiGrupi.Location = new System.Drawing.Point(92, 232);
			this.numCmimiGrupi.Name = "numCmimiGrupi";
			this.numCmimiGrupi.OnlyPositive = true;
			this.numCmimiGrupi.ReadOnly = true;
			this.numCmimiGrupi.Required = true;
			this.numCmimiGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimiGrupi.Size = new System.Drawing.Size(160, 21);
			this.numCmimiGrupi.TabIndex = 29;
			this.numCmimiGrupi.Text = "";
			this.numCmimiGrupi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label35
			// 
			this.label35.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label35.Location = new System.Drawing.Point(24, 236);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(60, 16);
			this.label35.TabIndex = 32;
			this.label35.Text = "Cmimi";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmailGrupi
			// 
			this.txtEmailGrupi.AutoSize = false;
			this.txtEmailGrupi.DefaultErrorMessage = "";
			this.txtEmailGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmailGrupi.FixedLength = false;
			this.txtEmailGrupi.IsValid = true;
			this.txtEmailGrupi.Location = new System.Drawing.Point(360, 208);
			this.txtEmailGrupi.Name = "txtEmailGrupi";
			this.txtEmailGrupi.Required = false;
			this.txtEmailGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmailGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtEmailGrupi.TabIndex = 38;
			this.txtEmailGrupi.Text = "";
			// 
			// txtTargaGrupi
			// 
			this.txtTargaGrupi.AutoSize = false;
			this.txtTargaGrupi.DefaultErrorMessage = "";
			this.txtTargaGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTargaGrupi.FixedLength = false;
			this.txtTargaGrupi.IsValid = true;
			this.txtTargaGrupi.Location = new System.Drawing.Point(360, 184);
			this.txtTargaGrupi.Name = "txtTargaGrupi";
			this.txtTargaGrupi.Required = false;
			this.txtTargaGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtTargaGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtTargaGrupi.TabIndex = 37;
			this.txtTargaGrupi.Text = "";
			// 
			// txtAdresaGrupi
			// 
			this.txtAdresaGrupi.AutoSize = false;
			this.txtAdresaGrupi.DefaultErrorMessage = "";
			this.txtAdresaGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAdresaGrupi.FixedLength = false;
			this.txtAdresaGrupi.IsValid = true;
			this.txtAdresaGrupi.Location = new System.Drawing.Point(360, 160);
			this.txtAdresaGrupi.Name = "txtAdresaGrupi";
			this.txtAdresaGrupi.Required = false;
			this.txtAdresaGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtAdresaGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtAdresaGrupi.TabIndex = 36;
			this.txtAdresaGrupi.Text = "";
			// 
			// txtTelGrupi
			// 
			this.txtTelGrupi.AutoSize = false;
			this.txtTelGrupi.DefaultErrorMessage = "";
			this.txtTelGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTelGrupi.FixedLength = false;
			this.txtTelGrupi.IsValid = true;
			this.txtTelGrupi.Location = new System.Drawing.Point(360, 136);
			this.txtTelGrupi.Name = "txtTelGrupi";
			this.txtTelGrupi.Required = false;
			this.txtTelGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtTelGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtTelGrupi.TabIndex = 35;
			this.txtTelGrupi.Text = "";
			// 
			// dtpDatelindjaGrupi
			// 
			this.dtpDatelindjaGrupi.CustomFormat = "dd.MM.yyyy";
			this.dtpDatelindjaGrupi.DefaultErrorMessage = "Vendosni datelindjen!";
			this.dtpDatelindjaGrupi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDatelindjaGrupi.IsValid = true;
			this.dtpDatelindjaGrupi.Location = new System.Drawing.Point(360, 16);
			this.dtpDatelindjaGrupi.Name = "dtpDatelindjaGrupi";
			this.dtpDatelindjaGrupi.Required = true;
			this.dtpDatelindjaGrupi.ShowCheckBox = true;
			this.dtpDatelindjaGrupi.ShowUpDown = true;
			this.dtpDatelindjaGrupi.Size = new System.Drawing.Size(160, 20);
			this.dtpDatelindjaGrupi.TabIndex = 30;
			this.dtpDatelindjaGrupi.Value = new System.DateTime(2005, 10, 6, 15, 14, 0, 0);
			// 
			// txtIdNoGrupi
			// 
			this.txtIdNoGrupi.AutoSize = false;
			this.txtIdNoGrupi.DefaultErrorMessage = "Nendosni numrin e identifikimit per klientin!";
			this.txtIdNoGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtIdNoGrupi.FixedLength = false;
			this.txtIdNoGrupi.IsValid = false;
			this.txtIdNoGrupi.Location = new System.Drawing.Point(360, 112);
			this.txtIdNoGrupi.Name = "txtIdNoGrupi";
			this.txtIdNoGrupi.Required = true;
			this.txtIdNoGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtIdNoGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtIdNoGrupi.TabIndex = 34;
			this.txtIdNoGrupi.Text = "";
			// 
			// cmbMjeteId
			// 
			this.cmbMjeteId.BackColor = System.Drawing.Color.Transparent;
			this.cmbMjeteId.DefaultErrorMessage = "Zgjidhni nje prej mjeteve te identifikimit";
			this.cmbMjeteId.IsValid = false;
			this.cmbMjeteId.Kolone1Vlere = null;
			this.cmbMjeteId.Kolone2Vlere = null;
			this.cmbMjeteId.Location = new System.Drawing.Point(360, 88);
			this.cmbMjeteId.Name = "cmbMjeteId";
			this.cmbMjeteId.ReadOnly = false;
			this.cmbMjeteId.Required = true;
			this.cmbMjeteId.Size = new System.Drawing.Size(160, 21);
			this.cmbMjeteId.SkipValidation = false;
			this.cmbMjeteId.TabIndex = 33;
			// 
			// cmbDhomatGrup
			// 
			this.cmbDhomatGrup.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhomatGrup.DefaultErrorMessage = "Zgjidhni nje prej dhomave!";
			this.cmbDhomatGrup.IsValid = false;
			this.cmbDhomatGrup.Kolone1Vlere = null;
			this.cmbDhomatGrup.Kolone2Vlere = null;
			this.cmbDhomatGrup.Location = new System.Drawing.Point(92, 208);
			this.cmbDhomatGrup.Name = "cmbDhomatGrup";
			this.cmbDhomatGrup.ReadOnly = false;
			this.cmbDhomatGrup.Required = true;
			this.cmbDhomatGrup.Size = new System.Drawing.Size(160, 21);
			this.cmbDhomatGrup.SkipValidation = false;
			this.cmbDhomatGrup.TabIndex = 28;
			this.cmbDhomatGrup.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbDhomatGrup_SelectedIndexChanged);
			// 
			// cmbKategoriaGrup
			// 
			this.cmbKategoriaGrup.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategoriaGrup.DefaultErrorMessage = "Zgjidhni nje prej kategorive!";
			this.cmbKategoriaGrup.IsValid = false;
			this.cmbKategoriaGrup.Kolone1Vlere = null;
			this.cmbKategoriaGrup.Kolone2Vlere = null;
			this.cmbKategoriaGrup.Location = new System.Drawing.Point(92, 184);
			this.cmbKategoriaGrup.Name = "cmbKategoriaGrup";
			this.cmbKategoriaGrup.ReadOnly = false;
			this.cmbKategoriaGrup.Required = true;
			this.cmbKategoriaGrup.Size = new System.Drawing.Size(160, 21);
			this.cmbKategoriaGrup.SkipValidation = false;
			this.cmbKategoriaGrup.TabIndex = 27;
			this.cmbKategoriaGrup.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategoriaGrup_SelectedIndexChanged);
			// 
			// dtpDaljeGrupi
			// 
			this.dtpDaljeGrupi.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpDaljeGrupi.DefaultErrorMessage = "Vendosni daten e daljes per klientin!";
			this.dtpDaljeGrupi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDaljeGrupi.IsValid = true;
			this.dtpDaljeGrupi.Location = new System.Drawing.Point(92, 160);
			this.dtpDaljeGrupi.Name = "dtpDaljeGrupi";
			this.dtpDaljeGrupi.Required = true;
			this.dtpDaljeGrupi.ShowCheckBox = true;
			this.dtpDaljeGrupi.ShowUpDown = true;
			this.dtpDaljeGrupi.Size = new System.Drawing.Size(160, 20);
			this.dtpDaljeGrupi.TabIndex = 26;
			this.dtpDaljeGrupi.Value = new System.DateTime(2005, 10, 6, 15, 14, 0, 0);
			this.dtpDaljeGrupi.ValueChanged += new System.EventHandler(this.dtpDaljeGrupi_ValueChanged);
			// 
			// dtpHyrjeGrupi
			// 
			this.dtpHyrjeGrupi.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpHyrjeGrupi.DefaultErrorMessage = "Vendosni daten e hyrjes per klientin!";
			this.dtpHyrjeGrupi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHyrjeGrupi.IsValid = true;
			this.dtpHyrjeGrupi.Location = new System.Drawing.Point(92, 136);
			this.dtpHyrjeGrupi.Name = "dtpHyrjeGrupi";
			this.dtpHyrjeGrupi.Required = true;
			this.dtpHyrjeGrupi.ShowCheckBox = true;
			this.dtpHyrjeGrupi.ShowUpDown = true;
			this.dtpHyrjeGrupi.Size = new System.Drawing.Size(160, 20);
			this.dtpHyrjeGrupi.TabIndex = 25;
			this.dtpHyrjeGrupi.Value = new System.DateTime(2005, 10, 6, 15, 14, 0, 0);
			this.dtpHyrjeGrupi.ValueChanged += new System.EventHandler(this.dtpHyrjeGrupi_ValueChanged);
			// 
			// txtMbiemriKlientiGrupi
			// 
			this.txtMbiemriKlientiGrupi.AutoSize = false;
			this.txtMbiemriKlientiGrupi.DefaultErrorMessage = "Vendosni mbiemrin per klientin! ";
			this.txtMbiemriKlientiGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemriKlientiGrupi.FixedLength = false;
			this.txtMbiemriKlientiGrupi.IsValid = false;
			this.txtMbiemriKlientiGrupi.Location = new System.Drawing.Point(92, 112);
			this.txtMbiemriKlientiGrupi.Name = "txtMbiemriKlientiGrupi";
			this.txtMbiemriKlientiGrupi.Required = true;
			this.txtMbiemriKlientiGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemriKlientiGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtMbiemriKlientiGrupi.TabIndex = 24;
			this.txtMbiemriKlientiGrupi.Text = "";
			// 
			// txtEmriKlientiGrupi
			// 
			this.txtEmriKlientiGrupi.AutoSize = false;
			this.txtEmriKlientiGrupi.DefaultErrorMessage = "Vendosni emrin e klientit!";
			this.txtEmriKlientiGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmriKlientiGrupi.FixedLength = false;
			this.txtEmriKlientiGrupi.IsValid = false;
			this.txtEmriKlientiGrupi.Location = new System.Drawing.Point(92, 88);
			this.txtEmriKlientiGrupi.Name = "txtEmriKlientiGrupi";
			this.txtEmriKlientiGrupi.Required = true;
			this.txtEmriKlientiGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmriKlientiGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtEmriKlientiGrupi.TabIndex = 23;
			this.txtEmriKlientiGrupi.Text = "";
			// 
			// txtAgjensiaTeDhena1
			// 
			this.txtAgjensiaTeDhena1.AutoSize = false;
			this.txtAgjensiaTeDhena1.DefaultErrorMessage = "";
			this.txtAgjensiaTeDhena1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAgjensiaTeDhena1.FixedLength = false;
			this.txtAgjensiaTeDhena1.IsValid = true;
			this.txtAgjensiaTeDhena1.Location = new System.Drawing.Point(92, 64);
			this.txtAgjensiaTeDhena1.Name = "txtAgjensiaTeDhena1";
			this.txtAgjensiaTeDhena1.ReadOnly = true;
			this.txtAgjensiaTeDhena1.Required = false;
			this.txtAgjensiaTeDhena1.RequiredControlColor = System.Drawing.Color.White;
			this.txtAgjensiaTeDhena1.Size = new System.Drawing.Size(160, 21);
			this.txtAgjensiaTeDhena1.TabIndex = 22;
			this.txtAgjensiaTeDhena1.Text = "";
			// 
			// cmbGrupetTeDhena
			// 
			this.cmbGrupetTeDhena.BackColor = System.Drawing.Color.Transparent;
			this.cmbGrupetTeDhena.DefaultErrorMessage = "Caktojini klientit nje prej grupeve!";
			this.cmbGrupetTeDhena.IsValid = false;
			this.cmbGrupetTeDhena.Kolone1Vlere = null;
			this.cmbGrupetTeDhena.Kolone2Vlere = null;
			this.cmbGrupetTeDhena.Location = new System.Drawing.Point(92, 40);
			this.cmbGrupetTeDhena.Name = "cmbGrupetTeDhena";
			this.cmbGrupetTeDhena.ReadOnly = false;
			this.cmbGrupetTeDhena.Required = true;
			this.cmbGrupetTeDhena.Size = new System.Drawing.Size(160, 21);
			this.cmbGrupetTeDhena.SkipValidation = false;
			this.cmbGrupetTeDhena.TabIndex = 21;
			this.cmbGrupetTeDhena.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbGrupetTeDhena_SelectedIndexChanged);
			// 
			// cmbKlientetGrupi
			// 
			this.cmbKlientetGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cmbKlientetGrupi.DefaultErrorMessage = "Zgjidhni nje prej hyrjeve ne te majte!";
			this.cmbKlientetGrupi.IsValid = false;
			this.cmbKlientetGrupi.Kolone1Vlere = null;
			this.cmbKlientetGrupi.Kolone2Vlere = null;
			this.cmbKlientetGrupi.Location = new System.Drawing.Point(92, 16);
			this.cmbKlientetGrupi.Name = "cmbKlientetGrupi";
			this.cmbKlientetGrupi.ReadOnly = false;
			this.cmbKlientetGrupi.Required = true;
			this.cmbKlientetGrupi.Size = new System.Drawing.Size(160, 21);
			this.cmbKlientetGrupi.SkipValidation = false;
			this.cmbKlientetGrupi.TabIndex = 20;
			this.cmbKlientetGrupi.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKlientetGrupi_SelectedIndexChanged);
			// 
			// label31
			// 
			this.label31.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label31.Location = new System.Drawing.Point(284, 160);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(68, 20);
			this.label31.TabIndex = 15;
			this.label31.Text = "Adresa";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label30
			// 
			this.label30.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label30.Location = new System.Drawing.Point(300, 184);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(52, 20);
			this.label30.TabIndex = 14;
			this.label30.Text = "Targa";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label29
			// 
			this.label29.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label29.Location = new System.Drawing.Point(292, 208);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(60, 20);
			this.label29.TabIndex = 13;
			this.label29.Text = "E-maili";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label28
			// 
			this.label28.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label28.Location = new System.Drawing.Point(288, 136);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(64, 20);
			this.label28.TabIndex = 12;
			this.label28.Text = "Nr telefoni";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label27
			// 
			this.label27.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label27.Location = new System.Drawing.Point(284, 16);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(68, 20);
			this.label27.TabIndex = 11;
			this.label27.Text = "Datelindja";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label26
			// 
			this.label26.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label26.Location = new System.Drawing.Point(268, 116);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(84, 20);
			this.label26.TabIndex = 10;
			this.label26.Text = "Nr identifikimi";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label25
			// 
			this.label25.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label25.Location = new System.Drawing.Point(28, 44);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(56, 20);
			this.label25.TabIndex = 9;
			this.label25.Text = "Grupi";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label24
			// 
			this.label24.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label24.Location = new System.Drawing.Point(24, 68);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(60, 20);
			this.label24.TabIndex = 8;
			this.label24.Text = "Agjensia";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label23
			// 
			this.label23.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label23.Location = new System.Drawing.Point(32, 114);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(52, 20);
			this.label23.TabIndex = 7;
			this.label23.Text = "Mbiemri";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label22
			// 
			this.label22.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label22.Location = new System.Drawing.Point(24, 90);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(60, 20);
			this.label22.TabIndex = 6;
			this.label22.Text = "Emri";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label20
			// 
			this.label20.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label20.Location = new System.Drawing.Point(12, 160);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(72, 20);
			this.label20.TabIndex = 4;
			this.label20.Text = "Date mbarimi";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label19
			// 
			this.label19.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label19.Location = new System.Drawing.Point(256, 92);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(96, 20);
			this.label19.TabIndex = 3;
			this.label19.Text = "Mjeti i identifikimit";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label18
			// 
			this.label18.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label18.Location = new System.Drawing.Point(24, 212);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(60, 16);
			this.label18.TabIndex = 2;
			this.label18.Text = "Dhoma";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label17
			// 
			this.label17.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label17.Location = new System.Drawing.Point(24, 188);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(60, 15);
			this.label17.TabIndex = 1;
			this.label17.Text = "Kategoria";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label16.Location = new System.Drawing.Point(20, 136);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(64, 20);
			this.label16.TabIndex = 0;
			this.label16.Text = "Date fillimi";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtShtetesiaGrupi
			// 
			this.txtShtetesiaGrupi.AutoSize = false;
			this.txtShtetesiaGrupi.DefaultErrorMessage = "";
			this.txtShtetesiaGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtShtetesiaGrupi.FixedLength = false;
			this.txtShtetesiaGrupi.IsValid = true;
			this.txtShtetesiaGrupi.Location = new System.Drawing.Point(360, 64);
			this.txtShtetesiaGrupi.Name = "txtShtetesiaGrupi";
			this.txtShtetesiaGrupi.Required = false;
			this.txtShtetesiaGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtShtetesiaGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtShtetesiaGrupi.TabIndex = 32;
			this.txtShtetesiaGrupi.Text = "";
			// 
			// txtVendlindjaGrupi
			// 
			this.txtVendlindjaGrupi.AutoSize = false;
			this.txtVendlindjaGrupi.DefaultErrorMessage = "";
			this.txtVendlindjaGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtVendlindjaGrupi.FixedLength = false;
			this.txtVendlindjaGrupi.IsValid = true;
			this.txtVendlindjaGrupi.Location = new System.Drawing.Point(360, 40);
			this.txtVendlindjaGrupi.Name = "txtVendlindjaGrupi";
			this.txtVendlindjaGrupi.Required = false;
			this.txtVendlindjaGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtVendlindjaGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtVendlindjaGrupi.TabIndex = 31;
			this.txtVendlindjaGrupi.Text = "";
			// 
			// label38
			// 
			this.label38.Location = new System.Drawing.Point(280, 64);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(72, 20);
			this.label38.TabIndex = 113;
			this.label38.Text = "Shtetesia";
			this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label39
			// 
			this.label39.Location = new System.Drawing.Point(280, 44);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(72, 16);
			this.label39.TabIndex = 112;
			this.label39.Text = "Vendlindja";
			this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbGrupi
			// 
			this.gbGrupi.BackColor = System.Drawing.Color.Transparent;
			this.gbGrupi.Controls.Add(this.cmbPagesaGrupi);
			this.gbGrupi.Controls.Add(this.label41);
			this.gbGrupi.Controls.Add(this.txtGrupi);
			this.gbGrupi.Controls.Add(this.txtAgjensiaTeDhena);
			this.gbGrupi.Controls.Add(this.label12);
			this.gbGrupi.Controls.Add(this.label11);
			this.gbGrupi.Controls.Add(this.label8);
			this.gbGrupi.Controls.Add(this.label9);
			this.gbGrupi.Controls.Add(this.numGjobaGrupi);
			this.gbGrupi.Controls.Add(this.numSkontoGrupi);
			this.gbGrupi.Controls.Add(this.numKapariGrupi);
			this.gbGrupi.Controls.Add(this.label10);
			this.gbGrupi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbGrupi.Location = new System.Drawing.Point(468, 144);
			this.gbGrupi.Name = "gbGrupi";
			this.gbGrupi.Size = new System.Drawing.Size(544, 96);
			this.gbGrupi.TabIndex = 3;
			this.gbGrupi.Text = "Te dhenat per grupin";
			this.gbGrupi.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbPagesaGrupi
			// 
			this.cmbPagesaGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cmbPagesaGrupi.DefaultErrorMessage = "Zgjidhni formen e pageses!";
			this.cmbPagesaGrupi.IsValid = false;
			this.cmbPagesaGrupi.Kolone1Vlere = null;
			this.cmbPagesaGrupi.Kolone2Vlere = null;
			this.cmbPagesaGrupi.Location = new System.Drawing.Point(88, 66);
			this.cmbPagesaGrupi.Name = "cmbPagesaGrupi";
			this.cmbPagesaGrupi.ReadOnly = false;
			this.cmbPagesaGrupi.Required = true;
			this.cmbPagesaGrupi.Size = new System.Drawing.Size(160, 21);
			this.cmbPagesaGrupi.SkipValidation = false;
			this.cmbPagesaGrupi.TabIndex = 15;
			// 
			// label41
			// 
			this.label41.Location = new System.Drawing.Point(12, 69);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(68, 16);
			this.label41.TabIndex = 104;
			this.label41.Text = "Pagesa ne";
			this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtGrupi
			// 
			this.txtGrupi.AutoSize = false;
			this.txtGrupi.DefaultErrorMessage = "";
			this.txtGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtGrupi.FixedLength = false;
			this.txtGrupi.IsValid = true;
			this.txtGrupi.Location = new System.Drawing.Point(88, 16);
			this.txtGrupi.Name = "txtGrupi";
			this.txtGrupi.ReadOnly = true;
			this.txtGrupi.Required = false;
			this.txtGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtGrupi.TabIndex = 13;
			this.txtGrupi.Text = "";
			// 
			// txtAgjensiaTeDhena
			// 
			this.txtAgjensiaTeDhena.AutoSize = false;
			this.txtAgjensiaTeDhena.DefaultErrorMessage = "";
			this.txtAgjensiaTeDhena.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAgjensiaTeDhena.FixedLength = false;
			this.txtAgjensiaTeDhena.IsValid = true;
			this.txtAgjensiaTeDhena.Location = new System.Drawing.Point(88, 41);
			this.txtAgjensiaTeDhena.Name = "txtAgjensiaTeDhena";
			this.txtAgjensiaTeDhena.ReadOnly = true;
			this.txtAgjensiaTeDhena.Required = false;
			this.txtAgjensiaTeDhena.RequiredControlColor = System.Drawing.Color.White;
			this.txtAgjensiaTeDhena.Size = new System.Drawing.Size(160, 21);
			this.txtAgjensiaTeDhena.TabIndex = 14;
			this.txtAgjensiaTeDhena.Text = "";
			// 
			// label12
			// 
			this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label12.Location = new System.Drawing.Point(24, 45);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 16);
			this.label12.TabIndex = 100;
			this.label12.Text = "Agjensia";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label11.Location = new System.Drawing.Point(32, 20);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 16);
			this.label11.TabIndex = 99;
			this.label11.Text = "Grupi";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(292, 64);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label8.Size = new System.Drawing.Size(60, 16);
			this.label8.TabIndex = 98;
			this.label8.Text = "Gjoba";
			// 
			// label9
			// 
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(288, 40);
			this.label9.Name = "label9";
			this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label9.Size = new System.Drawing.Size(64, 16);
			this.label9.TabIndex = 97;
			this.label9.Text = "Skonto";
			// 
			// numGjobaGrupi
			// 
			this.numGjobaGrupi.AutoSize = false;
			this.numGjobaGrupi.DefaultErrorMessage = "Vendosni  0 ose nje vlere per gjoben!";
			this.numGjobaGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numGjobaGrupi.DigitsAfterDecimalPoint = 0;
			this.numGjobaGrupi.FixedLength = false;
			this.numGjobaGrupi.IsValid = false;
			this.numGjobaGrupi.KeepFocus = false;
			this.numGjobaGrupi.Location = new System.Drawing.Point(360, 66);
			this.numGjobaGrupi.Name = "numGjobaGrupi";
			this.numGjobaGrupi.OnlyPositive = true;
			this.numGjobaGrupi.Required = true;
			this.numGjobaGrupi.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.numGjobaGrupi.Size = new System.Drawing.Size(160, 21);
			this.numGjobaGrupi.TabIndex = 18;
			this.numGjobaGrupi.Text = "";
			this.numGjobaGrupi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// numSkontoGrupi
			// 
			this.numSkontoGrupi.AutoSize = false;
			this.numSkontoGrupi.DefaultErrorMessage = "Vendosni 0 ose nje vlere per skonton!";
			this.numSkontoGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numSkontoGrupi.DigitsAfterDecimalPoint = 0;
			this.numSkontoGrupi.FixedLength = false;
			this.numSkontoGrupi.IsValid = false;
			this.numSkontoGrupi.KeepFocus = false;
			this.numSkontoGrupi.Location = new System.Drawing.Point(360, 41);
			this.numSkontoGrupi.Name = "numSkontoGrupi";
			this.numSkontoGrupi.OnlyPositive = true;
			this.numSkontoGrupi.Required = true;
			this.numSkontoGrupi.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.numSkontoGrupi.Size = new System.Drawing.Size(160, 21);
			this.numSkontoGrupi.TabIndex = 17;
			this.numSkontoGrupi.Text = "";
			this.numSkontoGrupi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// numKapariGrupi
			// 
			this.numKapariGrupi.AutoSize = false;
			this.numKapariGrupi.DefaultErrorMessage = "Vendosni 0 ose nje vlere per kaparin!";
			this.numKapariGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numKapariGrupi.DigitsAfterDecimalPoint = 0;
			this.numKapariGrupi.FixedLength = false;
			this.numKapariGrupi.IsValid = false;
			this.numKapariGrupi.KeepFocus = false;
			this.numKapariGrupi.Location = new System.Drawing.Point(360, 16);
			this.numKapariGrupi.Name = "numKapariGrupi";
			this.numKapariGrupi.OnlyPositive = true;
			this.numKapariGrupi.Required = true;
			this.numKapariGrupi.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.numKapariGrupi.Size = new System.Drawing.Size(160, 21);
			this.numKapariGrupi.TabIndex = 16;
			this.numKapariGrupi.Text = "";
			this.numKapariGrupi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label10
			// 
			this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label10.Location = new System.Drawing.Point(296, 20);
			this.label10.Name = "label10";
			this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label10.Size = new System.Drawing.Size(56, 16);
			this.label10.TabIndex = 93;
			this.label10.Text = "Kapari";
			// 
			// btnKerkoGrup
			// 
			this.btnKerkoGrup.BackColor = System.Drawing.Color.Blue;
			this.btnKerkoGrup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerkoGrup.DoValidation = false;
			this.btnKerkoGrup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerkoGrup.Location = new System.Drawing.Point(476, 68);
			this.btnKerkoGrup.Name = "btnKerkoGrup";
			this.btnKerkoGrup.Size = new System.Drawing.Size(90, 21);
			this.btnKerkoGrup.TabIndex = 12;
			this.btnKerkoGrup.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerkoGrup, "Kerkon hyrjet ne grup ne hotel qe plotesojne kriteret e zgjedhur!");
			this.btnKerkoGrup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerkoGrup.Click += new System.EventHandler(this.btnKerkoGrup_Click);
			// 
			// gbGrup
			// 
			this.gbGrup.BackColor = System.Drawing.Color.Transparent;
			this.gbGrup.Controls.Add(this.gridGrupi);
			this.gbGrup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbGrup.Location = new System.Drawing.Point(10, 144);
			this.gbGrup.Name = "gbGrup";
			this.gbGrup.Size = new System.Drawing.Size(448, 416);
			this.gbGrup.TabIndex = 1;
			this.gbGrup.Text = "Hyrjet ne grup te vlefshme ne hotel";
			this.gbGrup.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// gridGrupi
			// 
			this.gridGrupi.AllowSorting = false;
			this.gridGrupi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.gridGrupi.CanDelete = true;
			this.gridGrupi.CaptionVisible = false;
			this.gridGrupi.DataMember = "";
			this.gridGrupi.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gridGrupi.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridGrupi.HideHorizontalScrollBar = false;
			this.gridGrupi.HideVerticalScrollBar = false;
			this.gridGrupi.Location = new System.Drawing.Point(12, 20);
			this.gridGrupi.Name = "gridGrupi";
			this.gridGrupi.RowHeaderWidth = 20;
			this.gridGrupi.Selekto = true;
			this.gridGrupi.Size = new System.Drawing.Size(424, 384);
			this.gridGrupi.TabIndex = 0;
			this.toolTips.SetToolTip(this.gridGrupi, "Zgjidhni nje prej hyrjeve per te modifikuar ose eleminuar klientet perberes!");
			this.gridGrupi.CurrentCellChanged += new System.EventHandler(this.gridGrupi_CurrentCellChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label33);
			this.groupBox2.Controls.Add(this.label32);
			this.groupBox2.Controls.Add(this.cmbGrupet);
			this.groupBox2.Controls.Add(this.cmbDhomatGrupi);
			this.groupBox2.Controls.Add(this.txtAgjensiaKerkim);
			this.groupBox2.Controls.Add(this.rbDhomaGrupi);
			this.groupBox2.Controls.Add(this.rbGrupi);
			this.groupBox2.Controls.Add(this.dtpMbarimiGrup);
			this.groupBox2.Controls.Add(this.dtpFillimiGrup);
			this.groupBox2.Controls.Add(this.rbDataGrupi);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(448, 132);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.Text = "Kerkim sipas ";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label33
			// 
			this.label33.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label33.Location = new System.Drawing.Point(272, 57);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(100, 14);
			this.label33.TabIndex = 9;
			this.label33.Text = "Agjensia";
			// 
			// label32
			// 
			this.label32.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label32.Location = new System.Drawing.Point(104, 57);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(100, 14);
			this.label32.TabIndex = 8;
			this.label32.Text = "Grupi";
			// 
			// cmbGrupet
			// 
			this.cmbGrupet.BackColor = System.Drawing.Color.Transparent;
			this.cmbGrupet.DefaultErrorMessage = null;
			this.cmbGrupet.IsValid = true;
			this.cmbGrupet.Kolone1Vlere = null;
			this.cmbGrupet.Kolone2Vlere = null;
			this.cmbGrupet.Location = new System.Drawing.Point(104, 72);
			this.cmbGrupet.Name = "cmbGrupet";
			this.cmbGrupet.ReadOnly = false;
			this.cmbGrupet.Required = false;
			this.cmbGrupet.Size = new System.Drawing.Size(160, 21);
			this.cmbGrupet.SkipValidation = false;
			this.cmbGrupet.TabIndex = 9;
			this.cmbGrupet.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbGrupet_SelectedIndexChanged);
			// 
			// cmbDhomatGrupi
			// 
			this.cmbDhomatGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhomatGrupi.DefaultErrorMessage = null;
			this.cmbDhomatGrupi.IsValid = true;
			this.cmbDhomatGrupi.Kolone1Vlere = null;
			this.cmbDhomatGrupi.Kolone2Vlere = null;
			this.cmbDhomatGrupi.Location = new System.Drawing.Point(104, 100);
			this.cmbDhomatGrupi.Name = "cmbDhomatGrupi";
			this.cmbDhomatGrupi.ReadOnly = false;
			this.cmbDhomatGrupi.Required = false;
			this.cmbDhomatGrupi.Size = new System.Drawing.Size(160, 21);
			this.cmbDhomatGrupi.SkipValidation = false;
			this.cmbDhomatGrupi.TabIndex = 11;
			// 
			// txtAgjensiaKerkim
			// 
			this.txtAgjensiaKerkim.AutoSize = false;
			this.txtAgjensiaKerkim.DefaultErrorMessage = "";
			this.txtAgjensiaKerkim.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAgjensiaKerkim.FixedLength = false;
			this.txtAgjensiaKerkim.IsValid = true;
			this.txtAgjensiaKerkim.Location = new System.Drawing.Point(272, 72);
			this.txtAgjensiaKerkim.Name = "txtAgjensiaKerkim";
			this.txtAgjensiaKerkim.Required = false;
			this.txtAgjensiaKerkim.RequiredControlColor = System.Drawing.Color.White;
			this.txtAgjensiaKerkim.Size = new System.Drawing.Size(160, 21);
			this.txtAgjensiaKerkim.TabIndex = 10;
			this.txtAgjensiaKerkim.Text = "";
			// 
			// rbDhomaGrupi
			// 
			this.rbDhomaGrupi.Location = new System.Drawing.Point(8, 104);
			this.rbDhomaGrupi.Name = "rbDhomaGrupi";
			this.rbDhomaGrupi.Size = new System.Drawing.Size(88, 16);
			this.rbDhomaGrupi.TabIndex = 4;
			this.rbDhomaGrupi.Text = "Dhomes";
			// 
			// rbGrupi
			// 
			this.rbGrupi.Location = new System.Drawing.Point(8, 76);
			this.rbGrupi.Name = "rbGrupi";
			this.rbGrupi.Size = new System.Drawing.Size(76, 16);
			this.rbGrupi.TabIndex = 3;
			this.rbGrupi.Text = "Grupit";
			// 
			// dtpMbarimiGrup
			// 
			this.dtpMbarimiGrup.CustomFormat = "dd.MM.yyyy";
			this.dtpMbarimiGrup.DefaultErrorMessage = "";
			this.dtpMbarimiGrup.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimiGrup.IsValid = true;
			this.dtpMbarimiGrup.Location = new System.Drawing.Point(272, 36);
			this.dtpMbarimiGrup.Name = "dtpMbarimiGrup";
			this.dtpMbarimiGrup.Required = false;
			this.dtpMbarimiGrup.ShowCheckBox = true;
			this.dtpMbarimiGrup.ShowUpDown = true;
			this.dtpMbarimiGrup.Size = new System.Drawing.Size(160, 20);
			this.dtpMbarimiGrup.TabIndex = 8;
			this.dtpMbarimiGrup.Value = new System.DateTime(2005, 10, 6, 15, 14, 0, 0);
			// 
			// dtpFillimiGrup
			// 
			this.dtpFillimiGrup.CustomFormat = "dd.MM.yyyy";
			this.dtpFillimiGrup.DefaultErrorMessage = "";
			this.dtpFillimiGrup.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimiGrup.IsValid = true;
			this.dtpFillimiGrup.Location = new System.Drawing.Point(104, 36);
			this.dtpFillimiGrup.Name = "dtpFillimiGrup";
			this.dtpFillimiGrup.Required = false;
			this.dtpFillimiGrup.ShowCheckBox = true;
			this.dtpFillimiGrup.ShowUpDown = true;
			this.dtpFillimiGrup.Size = new System.Drawing.Size(160, 20);
			this.dtpFillimiGrup.TabIndex = 7;
			this.dtpFillimiGrup.Value = new System.DateTime(2005, 10, 6, 15, 14, 0, 0);
			// 
			// rbDataGrupi
			// 
			this.rbDataGrupi.Location = new System.Drawing.Point(8, 38);
			this.rbDataGrupi.Name = "rbDataGrupi";
			this.rbDataGrupi.Size = new System.Drawing.Size(92, 16);
			this.rbDataGrupi.TabIndex = 2;
			this.rbDataGrupi.Text = "Midis datave";
			// 
			// ds_klient
			// 
			this.ds_klient.DataSetName = "NewDataSet";
			this.ds_klient.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// ds_grupi
			// 
			this.ds_grupi.DataSetName = "NewDataSet";
			this.ds_grupi.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// pagesa
			// 
			this.pagesa.DataSetName = "NewDataSet";
			this.pagesa.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// frmModifikimeVeprimeKlient
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1032, 636);
			this.Controls.Add(this.tabControl1);
			this.HelpFile = "MODIFIKO VEPRIM.htm";
			this.Name = "frmModifikimeVeprimeKlient";
			this.Text = "Modifiko/Fshi veprim";
			this.TitullGjeresi = 1032;
			this.Load += new System.EventHandler(this.frmModifikimeVeprimeKlient_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.tabControl1, 0);
			this.tabControl1.ResumeLayout(false);
			this.tbIndivid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbKlientet)).EndInit();
			this.gbKlientet.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbDhoma)).EndInit();
			this.gbDhoma.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbHyrjet)).EndInit();
			this.gbHyrjet.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridKlienti)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tbGrup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbKlientetGrupi)).EndInit();
			this.gbKlientetGrupi.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbGrupi)).EndInit();
			this.gbGrupi.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbGrup)).EndInit();
			this.gbGrup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridGrupi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds_klient)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_grupi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pagesa)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		/// <summary>
		/// Shfaq veprimet per klientet ne gride sipas kritereve te zgjedhur
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnKerko_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				DataSet ds = null;
				InputController data = new InputController();
				string koment = "";
				this.Pastro(this.gbDhoma);
				this.Pastro(this.gbKlientet);
				this.cmbKlientet.Kolone1.Items.Clear();
				this.cmbKlientet.Kolone2.Items.Clear();
				if (this.cbVlefshmeKlienti.Checked == true)
				{
					if (this.rbDatat.Checked == true)
					{
						DateTime data_fillimi = Convert.ToDateTime(this.dtpFillimi.Value).Date;
						DateTime data_mbarimi = Convert.ToDateTime(this.dtpMbarimi.Value).Date;
						if (data_fillimi >=  data_mbarimi)
						{
							this.error.SetError(dtpMbarimi,"Data e mbarimit duhet te jete me e madhe se data e fillimit!");
							this.gridKlienti.DataSource = null;
							return;
						}
						this.error.SetError(this.dtpMbarimi, "");
						koment = "Hyrjet individuale ne hotel midis datave " + this.konvertoshkurt(data_fillimi) + " dhe " +  this.konvertoshkurt(data_mbarimi);
						ds = data.KerkesaRead("ShfaqVeprimetPerDatat",1, data_fillimi.Date.AddDays(1), data_mbarimi.Date.AddDays(1));
						this.MoveUp();
					}
					else if (this.rbDhoma.Checked == true)
					{
						if (this.cmbDhomat.Kolone1.Text == "")
						{
							this.gridKlienti.DataSource = null;
							this.error.SetError(cmbDhomat, " Zgjidhni nje prej dhomave para se te kerkoni!");
							return;
						}
						this.error.SetError(this.cmbDhomat, "");
						int id_dhoma = Convert.ToInt32(this.cmbDhomat.Kolone2Vlere);
						koment = "Hyrjet individuale ne hotel per dhomen " + this.cmbDhomat.Kolone1.Text;
						ds = data.KerkesaRead("ShfaqVeprimetPerDhomen", id_dhoma,1);
						this.MoveDown();
					}
					else if (this.rbKlienti.Checked == true)
					{
						string emri = this.txtEmri.Text;
						string mbiemri = this.txtMbiemri.Text;
						koment = "Hyrjet individuale ne hotel per klientet me emer " + emri + " " + mbiemri;
						ds = data.KerkesaRead("ShfaqVeprimetPerKlientin", emri, mbiemri,1);
						this.MoveUp();
					}
					else
						return;
				}
				else
				{
					DateTime data_fillimi = Convert.ToDateTime(this.dtpFillimi.Value).Date;
					DateTime data_mbarimi = Convert.ToDateTime(this.dtpMbarimi.Value).Date;
					if (data_fillimi >=  data_mbarimi)
					{
						this.error.SetError(dtpMbarimi,"Data e mbarimit duhet te jete me e madhe se data e fillimit!");
						this.gridKlienti.DataSource = null;
						return;
					}
					this.error.SetError(this.dtpMbarimi, "");
					if ((this.cbKlienti.Checked == true)&&(this.cbDhoma.Checked == true))
					{
						string emri = this.txtEmri.Text;
						string mbiemri = this.txtMbiemri.Text;
						if (this.cmbDhomat.Kolone1.Text == "")
						{
							this.gridKlienti.DataSource = null;
							this.error.SetError(cmbDhomat, " Zgjidhni nje prej dhomave para se te kerkoni!");
							return;
						}
						this.error.SetError(this.cmbDhomat, "");
						int idDhoma = Convert.ToInt32(this.cmbDhomat.Kolone2Vlere);
						koment = "Hyrjet individuale te klientit ne dhomen " + this.cmbDhomat.Kolone1.Text;
						ds = data.KerkesaRead("ShfaqVeprimetPerKlientinDheDhomen", idDhoma,emri, mbiemri, data_fillimi.Date.AddDays(1), data_mbarimi.Date.AddDays(1),0);
						this.MoveUp();
					}
					else if (this.cbKlienti.Checked == true)
					{
						string emri = this.txtEmri.Text;
						string mbiemri = this.txtMbiemri.Text;
						koment = "Hyrjet individuale te klientit";
						ds = data.KerkesaRead("ShfaqVeprimetPerKlientin", emri, mbiemri, data_fillimi.Date.AddDays(1), data_mbarimi.Date.AddDays(1),0);
						this.MoveUp();
					}
					else if (this.cbDhoma.Checked == true)
					{
						if (this.cmbDhomat.Kolone1.Text == "")
						{
							this.gridKlienti.DataSource = null;
							this.error.SetError(cmbDhomat, " Zgjidhni nje prej dhomave para se te kerkoni!");
							return;
						}
						this.error.SetError(this.cmbDhomat, "");
						int idDhoma = Convert.ToInt32(this.cmbDhomat.Kolone2Vlere);
						koment = "Hyrjet individuale per dhomen " + this.cmbDhomat.Kolone1.Text;
						ds = data.KerkesaRead("ShfaqVeprimetPerDhomen", idDhoma,0, data_fillimi.Date.AddDays(1), data_mbarimi.Date.AddDays(1));
						this.MoveDown();
					}
					else if ((this.cbKlienti.Checked == false)&&(this.cbDhoma.Checked == false))
					{
						koment = "Hyrjet ne hotel midis datave";
						ds = data.KerkesaRead("ShfaqVeprimetPerDatat", 0, data_fillimi.Date.AddDays(1), data_mbarimi.Date.AddDays(1));
						this.MoveUp();
					}
				}
				this.gbHyrjet.Text = koment;
				if (ds.Tables[0].Rows.Count == 0)
				{
					this.gridKlienti.DataSource = null;
					System.Windows.Forms.MessageBox.Show(this, "Nuk ka asnje hyrje individuale ne hotel" + Environment.NewLine + "qe ploteson kriteret e zgjedhura!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				this.gridKlienti.DataSource = ds.Tables["KLIENTI"];
				this.KrijoStilgride();
			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		
		}

		/// <summary>
		/// Shfaq veprimet per grupet ne gride sipas kritereve te zgjedhur
		/// Ne kete rast kur kerkohet ne baze grupi per hyrjet e vlefshme
		/// nxirren edhe ata kliente te grupit qe jane larguar nga hoteli
		/// se bashku me ata qe kane mbetur per te njejten hyrje
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnKerkoGrup_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				DataSet ds = null;
				string koment = "";
				InputController data = new InputController();
				this.Pastro(this.gbGrupi);
				this.Pastro(this.gbKlientetGrupi);
				this.cmbKlientetGrupi.Kolone1.Items.Clear();
				this.cmbKlientetGrupi.Kolone2.Items.Clear();
				if (this.cbVlefshmeGrupi.Checked == true)
				{
					if (this.rbDataGrupi.Checked == true)
					{
						DateTime dateFillimi = Convert.ToDateTime(this.dtpFillimiGrup.Value);
						DateTime dateMbarimi = Convert.ToDateTime(this.dtpMbarimiGrup.Value);
						if (dateFillimi >=  dateMbarimi)
						{
							this.error.SetError(dtpMbarimiGrup, "Data e mbarimit duhet te jete me e madhe se data e fillimit!");
							this.gridGrupi.DataSource = null;
							return;
						}
						this.error.SetError(this.dtpMbarimiGrup, "");
						koment = "Hyrjet ne grup ne hotel midis datave " + this.konvertoshkurt(dateFillimi) + " dhe " + this.konvertoshkurt(dateMbarimi);
						ds = data.KerkesaRead("ShfaqVeprimetNeGrupPerDatat", 1, dateFillimi.Date.AddDays(1), dateMbarimi.Date.AddDays(1));
						this.MoveUp1();
					}
					else if (this.rbGrupi.Checked == true)
					{
						if (this.cmbGrupet.Kolone1.SelectedItem == null)
						{
							this.error.SetError(cmbGrupet, "Zgjidhni nje prej grupeve para se te kerkoni");
							this.gridGrupi.DataSource = null;
							return;
						}
						this.error.SetError(this.cmbGrupet, "");
						int id_grupi = Convert.ToInt32(this.cmbGrupet.Kolone2Vlere.ToString());
						ds = data.KerkesaRead("ShfaqVeprimetPerGrupinPerModifikim", id_grupi, -1);
						koment = "Hyrjet ne grup ne hotel per grupin " + this.cmbGrupet.Kolone1.Text;
						this.MoveDown1();
					}
					else if (this.rbDhomaGrupi.Checked == true)
					{
						if (this.cmbDhomatGrupi.Kolone1.SelectedItem == null)
						{
							this.error.SetError(cmbDhomatGrupi, "Zgjidhni nje prej dhomave para se te kerkoni");
							this.gridGrupi.DataSource = null;
							return;
						}
						this.error.SetError(this.cmbDhomatGrupi,"");
						int id_dhoma  = Convert.ToInt32(this.cmbDhomatGrupi.Kolone2Vlere.ToString());
						ds = data.KerkesaRead("ShfaqVeprimetNeGrupPerDhomen", id_dhoma, 1);
						koment = "Hyrjet ne grup ne hotel per dhomen " + this.cmbDhomatGrupi.Kolone1.Text;
						this.MoveUp1();
					}
					else
						return;
				}
				else
				{
					DateTime dateFillimi = Convert.ToDateTime(this.dtpFillimiGrup.Value);
					DateTime dateMbarimi = Convert.ToDateTime(this.dtpMbarimiGrup.Value);
					if (dateFillimi >=  dateMbarimi)
					{
						this.error.SetError(dtpMbarimiGrup, "Data e mbarimit duhet te jete me e madhe se data e fillimit!");
						this.gridGrupi.DataSource = null;
						return;
					}
					this.error.SetError(this.dtpMbarimiGrup, "");
					if ((this.cbGrupi.Checked == true)&&(this.cbDhomaGrupi.Checked == true))
					{
						if (this.cmbGrupet.Kolone1.SelectedItem == null)
						{
							this.error.SetError(cmbGrupet, "Zgjidhni nje prej grupeve para se te kerkoni");
							this.gridGrupi.DataSource = null;
							return;
						}
						this.error.SetError(this.cmbGrupet, "");
						int idGrupi = Convert.ToInt32(this.cmbGrupet.Kolone2Vlere.ToString());
						if (this.cmbDhomatGrupi.Kolone1.SelectedItem == null)
						{
							this.error.SetError(cmbDhomatGrupi, "Zgjidhni nje prej dhomave para se te kerkoni");
							this.gridGrupi.DataSource = null;
							return;
						}
						this.error.SetError(this.cmbDhomatGrupi,"");
						int idDhoma  = Convert.ToInt32(this.cmbDhomatGrupi.Kolone2Vlere.ToString());
						koment = "Hyrjet e grupit " + this.cmbGrupet.Kolone1.Text + " ne dhomen " +this.cmbDhomatGrupi.Kolone1.Text;
						ds = data.KerkesaRead("ShfaqVeprimetPerGrupDheDhome",idGrupi, idDhoma, dateFillimi.Date.AddDays(1), dateMbarimi.Date.AddDays(1), 0);
						this.MoveUp1();
					}
					else if (this.cbGrupi.Checked == true)
					{
						if (this.cmbGrupet.Kolone1.SelectedItem == null)
						{
							this.error.SetError(cmbGrupet, "Zgjidhni nje prej grupeve para se te kerkoni");
							this.gridGrupi.DataSource = null;
							return;
						}
						this.error.SetError(this.cmbGrupet, "");
						int idGrupi = Convert.ToInt32(this.cmbGrupet.Kolone2Vlere.ToString());
						koment = "Hyrjet e grupit " + this.cmbGrupet.Kolone1.Text;
						ds = data.KerkesaRead("ShfaqVeprimetPerGrupin", idGrupi, 0, dateFillimi.Date.AddDays(1), dateMbarimi.Date.AddDays(1));
						this.MoveDown1();

					}
					else if (this.cbDhomaGrupi.Checked == true)
					{
						if (this.cmbDhomatGrupi.Kolone1.SelectedItem == null)
						{
							this.error.SetError(cmbDhomatGrupi, "Zgjidhni nje prej dhomave para se te kerkoni");
							this.gridGrupi.DataSource = null;
							return;
						}
						this.error.SetError(this.cmbDhomatGrupi,"");
						int idDhoma  = Convert.ToInt32(this.cmbDhomatGrupi.Kolone2Vlere.ToString());
						koment = "Hyrjet ne grup per dhomen " + this.cmbDhomatGrupi.Kolone1.Text;
						ds = data.KerkesaRead("ShfaqVeprimetNeGrupPerDhomen", idDhoma,0, dateFillimi.Date.AddDays(1), dateMbarimi.Date.AddDays(1));
						this.MoveUp1();
					}
					else if ((this.cbGrupi.Checked == false)&&(this.cbDhomaGrupi.Checked == false))
					{
						koment = "Hyrjet ne grup midis datave " + this.konvertoshkurt(dateFillimi) + " dhe " + this.konvertoshkurt(dateMbarimi);
						ds = data.KerkesaRead("ShfaqVeprimetNeGrupPerDatat",0, dateFillimi.Date.AddDays(1), dateMbarimi.Date.AddDays(1));
						this.MoveUp1();
					}
				}
				this.gbGrup.Text = koment;
				if (ds.Tables[0].Rows.Count == 0)
				{
					this.gridGrupi.DataSource = null;
					System.Windows.Forms.MessageBox.Show(this, "Nuk ka asnje hyrje ne grup ne hotel" + Environment.NewLine + "qe ploteson kriteret e zgjedhura!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				this.gridGrupi.DataSource = ds.Tables["KLIENTI"];
				this.KrijoStilgride2();
			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		/// <summary>
		/// Vec te tjerave behet edhe pastrimi i variablave private
		/// dhe lihet forma ne ate tab ku ka qene dikur
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmModifikimeVeprimeKlient_Load(object sender, System.EventArgs e)
		{
			try
			{
				DataSet ds;
				// pastrim variablash private
				clicked = false;
				this.ds_klient.Tables.Clear();
				this.ds_grupi.Tables.Clear();
				this.pagesa.Tables.Clear();
				this.cbVlefshmeKlienti.Checked = true;
				// pastrim variablash private
				this.mbushDhomat();
				this.mbushGrupet();
				this.mbushKategorite();
				this.mbushMjeteIdentifikimi();
				this.MbushPagesat();
				if (this.tabControl1.SelectedIndex == 0)// klienti
				{
					this.cbVlefshmeKlienti.Checked = true;
					this.rbDatat.Checked = false;
					this.rbKlienti.Checked = false;
					this.rbDhoma.Checked = false;
					this.dtpFillimi.Value = DateTime.Now.Date;
					this.dtpMbarimi.Value = DateTime.Now.Date;
					this.dtpFillimiGrup.Value = DateTime.Now.Date;
					this.dtpMbarimiGrup.Value = DateTime.Now.Date;
					this.MoveDown();
					InputController data = new InputController();
					ds = data.KerkesaRead("ShfaqKlientHotel");
					this.lblDataKlienti.Visible = false;
					this.cbDhoma.Visible = false;
					this.cbKlienti.Visible = false;
					if (ds.Tables.Count != 2)
					{
						this.gridKlienti.DataSource = null;
						System.Windows.Forms.MessageBox.Show(this,"Per momentin nuk ka asnje hyrje individuale ne hotel!", "Modifikimi i hyrjeve ne hotel",  MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					else
					{
						this.gridKlienti.DataSource = ds.Tables["KLIENTI"];
						this.gbHyrjet.Text = "Hyrjet individuale te vlefshme ne hotel";
						this.KrijoStilgride();
					}
				}
				else
				{
					this.cbVlefshmeGrupi.Checked = true;
					this.rbDataGrupi.Checked = false;
					this.rbDhomaGrupi.Checked = false;
					this.rbGrupi.Checked = false;
					this.tabControl1_SelectedIndexChanged(sender, e);
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
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.cmbKlientet.Kolone1.Items.Clear();
				this.cmbKlientet.Kolone2.Items.Clear();
				this.cmbKlientetGrupi.Kolone1.Items.Clear();
				this.cmbKlientetGrupi.Kolone2.Items.Clear();
				DataSet ds;
				InputController data = new InputController();
				if (this.clicked == false)
				{
					this.clicked = true;
					this.lblDataGrupi.Visible = false;
					this.cbGrupi.Visible = false;
					this.cbDhomaGrupi.Visible = false;
					if (Convert.ToInt32(this.tabControl1.SelectedIndex) == 1)//grupi
					{
						ds = data.KerkesaRead("ShfaqKlientGrupNeHotelPerModifikim", -1);
						this.MoveDown1();
						if (ds.Tables.Count != 2)
						{
							this.gridGrupi.DataSource = null;
							System.Windows.Forms.MessageBox.Show(this, "Per momentin nuk ka asnje hyrje ne grup ne hotel!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						this.gridGrupi.DataSource = ds.Tables["KLIENTI"];
						KrijoStilgride2();
					}
					else//klienti
					{
						this.frmModifikimeVeprimeKlient_Load(sender, e);
					}
				}
				else
				{
					//ne kete rast nuk kemi te bejme me ndryshim te fokusit te dokumentit
					//por thjesht me ndryshim tabesh 
					if (Convert.ToInt32(this.tabControl1.SelectedIndex) == 1)//tabi i grupit
					{
						ds = data.KerkesaRead("ShfaqKlientGrupNeHotelPerModifikim", -1);
						this.gbGrup.Text = "Hyrjet ne grup te vlefshme ne hotel";
						this.rbDataGrupi.Checked = false;
						this.rbDhomaGrupi.Checked = false;
						this.rbGrupi.Checked = false;
						if (ds.Tables.Count == 2)
						{
							this.gridGrupi.DataSource = ds.Tables["KLIENTI"];
							KrijoStilgride2();
						}
						else
						{
							this.gridGrupi.DataSource = null;
						}
						this.Pastro(this.gbGrupi);
						this.Pastro(this.gbKlientetGrupi);
						this.MoveDown1();
						this.Pastro(this.groupBox2);
					}
					else// tabi i klientit
					{
						this.cbVlefshmeKlienti.Checked = true;
						ds = data.KerkesaRead("ShfaqKlientHotel");
						this.gbHyrjet.Text = "Hyrjet individuale te vlefshme ne hotel";
						this.rbDatat.Checked = false;
						this.rbDhoma.Checked = false;
						this.rbKlienti.Checked = false;
						if (ds.Tables.Count == 2)
						{
							this.gridKlienti.DataSource = ds.Tables["KLIENTI"];
							this.KrijoStilgride();
						}
						else
						{
							this.gridKlienti.DataSource = null;
						}
						this.Pastro(this.gbDhoma);
						this.Pastro(this.gbKlientet);
						this.MoveDown();
						this.Pastro(this.groupBox1);
					}
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
			}
			finally
			{
				this.AutoScrollPosition = new Point(0, 0);
				this.Cursor = Cursors.Default;
			}
		}
		
		/// <summary>
		/// Mbushen te dhenat per grupet
		/// </summary>
		/// <param name="Sender"></param>
		/// <param name="e"></param>
		private void cmbGrupet_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				int idGrupi = Convert.ToInt32(this.cmbGrupet.Kolone2Vlere);
				InputController data = new InputController();
				DataSet ds = data.KerkesaRead("ShfaqGrupin", idGrupi);
				DataRow dr = ds.Tables[0].Rows[0];
				this.txtAgjensiaKerkim.Text = dr[1].ToString();
			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
			}
		}

		/// <summary>
		/// Mbushet komboja e klienteve me te gjithe klientet qe jane ne dhome
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridKlienti_CurrentCellChanged(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				this.Pastro(this.gbDhoma);
				this.Pastro(this.gbKlientet);
				int index = Convert.ToInt32(gridKlienti.CurrentRowIndex);
				int id_dhoma = Convert.ToInt32(gridKlienti[index, 0]);
				string emri_dhoma = gridKlienti[index, 1].ToString();
				this.txtDhoma.Text = emri_dhoma;

				string str = gridKlienti[index, 7].ToString();
				DateTime d1 = this.gjej_daten(str);
				InputController data = new InputController();
				DataSet ds_cmimi = data.KerkesaRead("CmimiDhomesPerDaten", id_dhoma , d1);
				int cmimi = Convert.ToInt32(ds_cmimi.Tables[0].Rows[0][0]);
				numCmimi.Text = cmimi.ToString();
				
				int idPergjegjes = Convert.ToInt32(gridKlienti[index, 9]);
				DataSet dsFormaPagesa = data.KerkesaRead("ShfaqFormePageseKaparDhome", idPergjegjes);
				int idFormaPagesa;
				string emriPagesa ;
				if (dsFormaPagesa.Tables[0].Rows.Count != 0)
				{
					idFormaPagesa = Convert.ToInt32(dsFormaPagesa.Tables[0].Rows[0]["ID_FORMAPAGESA"]);
					emriPagesa = Convert.ToString(dsFormaPagesa.Tables[0].Rows[0]["EMRI"]);
				}
				else
				{
					idFormaPagesa = 1;
					emriPagesa = "Cash";
				}
				this.cmbPagesaKlienti.Kolone1Vlere = emriPagesa;
				this.cmbPagesaKlienti.Kolone1.Text = emriPagesa;
				this.cmbPagesaKlienti.Kolone2Vlere = idFormaPagesa;
				this.cmbPagesaKlienti.Kolone2.Text = idFormaPagesa.ToString();

				numKapari.Text = gridKlienti[index, 2].ToString();
				numSkonto.Text = gridKlienti[index, 3].ToString();
				numGjoba.Text = gridKlienti[index, 4].ToString();
				string str_bool = gridKlienti[index, 12].ToString();
				if (str_bool.Substring(0, 4) == "True")
				{
					this.numSkonto.ReadOnly = true;
					this.numGjoba.ReadOnly = true;
					//this.numKapari.ReadOnly = false;
					//this.cmbPagesaKlienti.Enabled = true;
				}
				else
				{
					this.numSkonto.ReadOnly = false;
					this.numGjoba.ReadOnly = false;
					//this.numKapari.ReadOnly = true;
					//this.cmbPagesaKlienti.Enabled = false;
				}
				string str_id = gridKlienti[index, 5].ToString();
				string str_emra = gridKlienti[index, 6].ToString();
				DataSet kliente = this.gjej_id_emra(str_id, str_emra);
				this.mbush_kombo_kliente(this.cmbKlientet, kliente);
			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		/// <summary>
		/// Mbushet komboja e klienteve me te gjithe klientet qe jane ne grup
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridGrupi_CurrentCellChanged(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				this.Pastro(this.gbGrupi);
				this.Pastro(this.gbKlientetGrupi);
				int index = Convert.ToInt32(gridGrupi.CurrentRowIndex);
				string grupi = gridGrupi[index, 0].ToString();
				string agjensia = gridGrupi[index, 1].ToString();
				this.txtGrupi.Text = grupi;
				this.txtAgjensiaTeDhena.Text = agjensia;
			
				this.numKapariGrupi.Text = gridGrupi[index, 2].ToString();
				this.numSkontoGrupi.Text = gridGrupi[index, 3].ToString();
				this.numGjobaGrupi.Text = gridGrupi[index, 4].ToString();

				string str_id = gridGrupi[index, 6].ToString();
				string str_emra = gridGrupi[index, 7].ToString();
				DataSet kliente = this.gjej_id_emra(str_id, str_emra);
				this.mbush_kombo_kliente(this.cmbKlientetGrupi, kliente);

				InputController data = new InputController();
				int idPergjegjes = Convert.ToInt32(gridGrupi[index, 10]);
				DataSet dsFormaPagesa = data.KerkesaRead("ShfaqFormePageseKaparDhome", idPergjegjes);
				int idFormaPagesa;
				string emriPagesa;
				if (dsFormaPagesa.Tables[0].Rows.Count != 0)
				{
					idFormaPagesa = Convert.ToInt32(dsFormaPagesa.Tables[0].Rows[0]["ID_FORMAPAGESA"]);
					emriPagesa = Convert.ToString(dsFormaPagesa.Tables[0].Rows[0]["EMRI"]);
				}
				else
				{
					idFormaPagesa = 1;
					emriPagesa = "Cash";
				}
				this.cmbPagesaGrupi.Kolone1Vlere = emriPagesa;
				this.cmbPagesaGrupi.Kolone1.Text = emriPagesa;
				this.cmbPagesaGrupi.Kolone2Vlere = idFormaPagesa;
				this.cmbPagesaGrupi.Kolone2.Text = idFormaPagesa.ToString();

				string strBool = gridGrupi[index, 13].ToString();
				if (this.DorezuarGrupi(strBool) == true)
				{
					this.numSkontoGrupi.ReadOnly = false;
					this.numGjobaGrupi.ReadOnly = false;
					//this.numKapariGrupi.ReadOnly = false;
					//this.cmbPagesaGrupi.Enabled = true;
				}
				else
				{
					this.numSkontoGrupi.ReadOnly = true;
					this.numGjobaGrupi.ReadOnly = true;
					//this.numKapariGrupi.ReadOnly = true;
					//this.cmbPagesaGrupi.Enabled = true;
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
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void cmbGrupetTeDhena_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				int idGrupi = Convert.ToInt32(this.cmbGrupetTeDhena.Kolone2Vlere);
				InputController data = new InputController();
				DataSet ds = data.KerkesaRead("ShfaqGrupin", idGrupi);
				DataRow dr = ds.Tables[0].Rows[0];
				this.txtAgjensiaTeDhena1.Text = dr[1].ToString();
				this.cmbKategoriaGrup.Kolone1.Text = "";
				this.cmbKategoriaGrup.Kolone2.Text = "";
				this.cmbDhomatGrup.Kolone1.Text = "";
				this.cmbDhomatGrup.Kolone2.Text = "";
				this.cmbDhomatGrup.Kolone1.Items.Clear();
				this.cmbDhomatGrup.Kolone2.Items.Clear();
			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
			}
		}

		/// <summary>
		/// Per modifikimin e vlerave te kaparit, skontos, gjobes, formes se pageses per dhomen
		/// vlera qe kane te bejne me hyrjen ne pergjithesi dhe jo me klientet
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnModifikoVeprimKlient_Click(object sender, System.EventArgs e)
		{
			try
			{
				//const string NUMERIC_FORMAT = "^-?[0-9]*(\\,)?[0-9]+$";
				const string NUMERIC_FORMAT = "[0-9]*(\\.)?[0-9]";
				if (this.txtDhoma.Text == "")
				{
					this.error.SetError(this.txtDhoma, "Zgjidhni me pare nje prej hyrjeve ne te majte!");
					this.txtDhoma.IsValid = false;
					return;
				}
				if (!Regex.IsMatch(this.numKapari.Text, NUMERIC_FORMAT))
				{
					this.error.SetError(this.numKapari, "Kapari duhet te jete vlere numerike!");
					this.numKapari.IsValid = false;
					return;
				}
				if (Convert.ToInt32(this.numKapari.Text) < 0)
				{
					this.error.SetError(this.numKapari, "Kapari nuk mund te jete negativ!");
					this.numKapari.IsValid = false;
					return;
				}
				if (!Regex.IsMatch(this.numSkonto.Text, NUMERIC_FORMAT))
				{
					this.error.SetError(this.numSkonto, "Skontoja duhet te jete vlere numerike!");
					this.numSkonto.IsValid = false;
					return;
				}
				if (Convert.ToInt32(this.numSkonto.Text) < 0)
				{
					this.error.SetError(this.numSkonto, "Skontoja nuk mund te jete negative!");
					this.numSkonto.IsValid = false;
					return;
				}
				if (!Regex.IsMatch(this.numGjoba.Text, NUMERIC_FORMAT))
				{
					this.error.SetError(this.numGjoba, "Gjoba duhet te jete vlere numerike!");
					this.numGjoba.IsValid = false;
					return;
				}
				if (Convert.ToInt32(this.numGjoba.Text) < 0)
				{
					this.error.SetError(this.numGjoba, "Gjoba nuk mund te jete negative!");
					this.numGjoba.IsValid = false;
					return;
				}
				if ((this.cmbPagesaKlienti.Enabled == true)&&(this.cmbPagesaKlienti.Kolone1.SelectedItem == null))
				{
					this.error.SetError(this.cmbPagesaKlienti, "Zgjidhni formen e pageses!");
					return;
				}
				InputController data = new InputController();
				int index = gridKlienti.CurrentRowIndex;
				int kapari = Convert.ToInt32(this.numKapari.Text);
				int skonto = Convert.ToInt32(this.numSkonto.Text);
				int gjoba = Convert.ToInt32(this.numGjoba.Text);
				int idDhoma = Convert.ToInt32(gridKlienti[index, 0]);
				int idFormaPagesa = Convert.ToInt32(this.cmbPagesaKlienti.Kolone2Vlere);
				DataSet tmp = data.KerkesaRead("ShfaqTeDhenatPerDhome",idDhoma);
				int idKategoria = Convert.ToInt32(tmp.Tables[0].Rows[0]["ID_KATEGORIA"]);
				DateTime dtFillimi = Convert.ToDateTime(this.gridKlienti[index, 10]);
				DateTime dtMbarimi = Convert.ToDateTime(this.gridKlienti[index, 11]);
				tmp = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma , dtFillimi);
				int cmimi = Convert.ToInt32(tmp.Tables[0].Rows[0][0]);
				int pagesa = this.GjejPagesen(idKategoria, cmimi, dtFillimi, dtMbarimi);
				pagesa = pagesa - kapari - skonto + gjoba;
				int pergjegjes = Convert.ToInt32(this.gridKlienti[index, 9]);
				if (pagesa < 0)
				{
					string s = "Modifikimi nuk u krye!";
					s += Environment.NewLine + "Pas modifikimt te vlerave me siper pagesa per dhomen";
					s += Environment.NewLine + "rezulton negative. Beni modifikimet e nevojshme!";
					System.Windows.Forms.MessageBox.Show(this, s, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				int idRezervimi = 0;
				string strIdRez = this.gridKlienti[index, 13].ToString();
				if (!strIdRez.StartsWith("\r\n")&&(strIdRez != ""))//do te thote qe te pakten nje prej klienteve ka ardhur me rezervim
				{
					//idRezervimi = 100;
					int length = strIdRez.Length;
					string id = "";
					for(int i = 0; i < strIdRez.Length; i++)
					{
						string s = strIdRez.Substring(i, 1);
						if (s == "\r")
							break;
						else
							id += s;
					}
					idRezervimi = Convert.ToInt32(id);
				}
				
				string strBool = gridKlienti[index, 12].ToString();
				bool dorezuar = false;
				if (strBool == "False")
					dorezuar = true;
				else if (strBool == "True")
					dorezuar = false;
				int b = 0;
				if (idRezervimi == 0)//klientet nuk kane ardhur me rezervim
				{
					b = data.KerkesaUpdate("ModifikoSkontoKaparGjobe", kapari, skonto,
						gjoba, pergjegjes, pagesa, idFormaPagesa, dtMbarimi, dorezuar, this.PerdoruesId);
				}
				else//klientet kane hyre me ane te rezervimit
				{
					DataSet dsRezArka = data.KerkesaRead("ShfaqKaparRezervimiArka", idRezervimi);
					if (dsRezArka.Tables[0].Rows.Count == 0)
						//kapari i rezervimit ka qene 0 dhe si i tille nuk eshte hedhur ne arke
						//modifikimi duhet te jete njesoj sikur klientet te mos kishin ardhur me rezervim
						b = data.KerkesaUpdate("ModifikoSkontoKaparGjobe", kapari, skonto,
							gjoba, pergjegjes, pagesa, idFormaPagesa, dtMbarimi, dorezuar,this.PerdoruesId);
					else
					{
						int kapariRezervimi = Convert.ToInt32(dsRezArka.Tables[0].Rows[0]["ARKA_SASIA"]);
						int kapariArka = kapari - kapariRezervimi;
						if (kapariArka < 0)
						{
							System.Windows.Forms.MessageBox.Show(this, "Një modifikim i tille i kaparit nuk mund të bëhet!" + Environment.NewLine + "Klientët që i përkasin kësaj hyrje janë futur me anë të rezervimit" +
								Environment.NewLine + "dhe nje pjesë e kaparit të dhomës i përket kaparit të rezervimit." + Environment.NewLine + "Vlera që ju keni dhënë për kaparin është më e vogël se kapari i rezervimit."
								,"Modifikimi i hyrjeve në hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						b = data.KerkesaUpdate("ModifikoSkontoKaparGjobePerHyrjetMeRezervim", kapariArka, skonto,
							gjoba, pergjegjes, pagesa, idFormaPagesa, dtMbarimi, dorezuar, kapari, this.PerdoruesId);
					}					
				}
				if (b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave per hyrjen u krye!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.RefreshKlienti(sender, e);
					this.Pastro(this.gbDhoma);
					this.cmbKlientet.Kolone1.Items.Clear();
					this.cmbKlientet.Kolone2.Items.Clear();
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave per hyrjen nuk u krye!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		/// <summary>
		/// Shfaqen gjithe te dhenat per klientin e grupit te zgjedhur
		/// </summary>
		/// <param name="Sender"></param>
		/// <param name="e"></param>
		private void cmbKlientetGrupi_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				int idKlienti = Convert.ToInt32(this.cmbKlientetGrupi.Kolone2Vlere);
				InputController data = new InputController();
				this.ds_grupi = data.KerkesaRead("ShfaqTeDhenaKlientiId", idKlienti);
				DataRow r = ds_grupi.Tables[0].Rows[0];

				this.cmbGrupetTeDhena.Kolone1.Text = r["GRUPI"].ToString();
				this.cmbDhomatTeDhena.Kolone1Vlere = r["GRUPI"].ToString();
				this.cmbGrupetTeDhena.Kolone2.Text = r["ID_GRUPI"].ToString();
				this.cmbGrupetTeDhena.Kolone2Vlere  = r["ID_GRUPI"].ToString();
				txtAgjensiaTeDhena1.Text = r["AGJENSIA"].ToString();

				this.txtEmriKlientiGrupi.Text = r["EMRI"].ToString();
				this.txtMbiemriKlientiGrupi.Text = r["MBIEMRI"].ToString();
				DateTime dtFillimi = Convert.ToDateTime(r["DATA_HYRJE"]);
				DateTime dtMbarimi = Convert.ToDateTime(r["DATA_DALJE"]);
				this.dtpHyrjeGrupi.Value = dtFillimi;
				this.dtpDaljeGrupi.Value = dtMbarimi;

				int idKategoria = Convert.ToInt32(r["ID_KATEGORIA"]);
				this.cmbKategoriaGrup.Kolone1.Text = r["KAT_EMRI"].ToString();
				this.cmbKategoriaGrup.Kolone1Vlere = r["KAT_EMRI"].ToString();
				this.cmbKategoriaGrup.Kolone2.Text = r["ID_KATEGORIA"].ToString();
				this.cmbKategoriaGrup.Kolone2Vlere = r["ID_KATEGORIA"].ToString();

				this.cmbDhomatGrup.Kolone1.Items.Clear();
				this.cmbDhomatGrup.Kolone2.Items.Clear();
				DataSet ds_dhoma = data.KerkesaRead("ShfaqDhomatEliraPerDateKategoriPerModifikim", idKategoria, dtFillimi, dtMbarimi, idKlienti);
				foreach(DataRow dr in ds_dhoma.Tables[0].Rows)
				{
					cmbDhomatGrup.Kolone1.Items.Add(dr["DHOMA_EMRI"]);
					cmbDhomatGrup.Kolone2.Items.Add(dr["ID_DHOMA"]);
				}
				cmbDhomatGrup.Kolone1.Text = Convert.ToString(r["DHOMA_EMRI"]);
				cmbDhomatGrup.Kolone1Vlere = Convert.ToString(r["DHOMA_EMRI"]);
				cmbDhomatGrup.Kolone2.Text = Convert.ToString(r["ID_DHOMA"]);
				cmbDhomatGrup.Kolone2Vlere = Convert.ToString(r["ID_DHOMA"]);
				this.numCmimiGrupi.Text = r["CMIMI"].ToString();

				this.cmbMjeteId.Kolone1.Text = r["EMER_LLOJI"].ToString();
				this.cmbMjeteId.Kolone1Vlere = r["EMER_LLOJI"].ToString();
				this.cmbMjeteId.Kolone2.Text = r["ID_LLOJI"].ToString();
				this.cmbMjeteId.Kolone2Vlere = r["ID_LLOJI"].ToString();
				this.txtIdNoGrupi.Text = r["NR_IDENTIFIKIMI"].ToString();

				this.dtpDatelindjaGrupi.Value = Convert.ToDateTime(r["DATELINDJA"]);
				this.txtTelGrupi.Text = r["TELEFONI"].ToString();
				this.txtAdresaGrupi.Text = r["ADRESA"].ToString();
				this.txtTargaGrupi.Text = r["TARGA"].ToString();
				this.txtEmailGrupi.Text = r["EMAIL"].ToString();
			
				this.txtVendlindjaGrupi.Text = r["VENDLINDJA"].ToString();
				this.txtShtetesiaGrupi.Text = r["SHTETESIA"].ToString();
			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
			}
		}

		/// <summary>
		/// Shfaqen gjithe te dhenat per klientin e zgjedhur te dhomes 
		/// </summary>
		/// <param name="Sender"></param>
		/// <param name="e"></param>
		private void cmbKlientet_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				int id_klienti = Convert.ToInt32(this.cmbKlientet.Kolone2Vlere);
				InputController data = new InputController();
				this.ds_klient = data.KerkesaRead("ShfaqTeDhenaKlientiId", id_klienti);
				DataRow r = ds_klient.Tables[0].Rows[0];
				this.txtEmriKlienti.Text = r["EMRI"].ToString();
				this.txtMbiemriKlienti.Text = r["MBIEMRI"].ToString();
				this.dtpHyrjeKlienti.Value = Convert.ToDateTime(r["DATA_HYRJE"]);
				this.dtpDaljeKlienti.Value = Convert.ToDateTime(r["DATA_DALJE"]);

				int idKategoria = Convert.ToInt32(r["ID_KATEGORIA"]);
				this.cmbKategoria.Kolone1.Text = r["KAT_EMRI"].ToString();
				this.cmbKategoria.Kolone1Vlere = r["KAT_EMRI"].ToString();
				this.cmbKategoria.Kolone2.Text = r["ID_KATEGORIA"].ToString();
				this.cmbKategoria.Kolone2Vlere = r["ID_KATEGORIA"].ToString();

				int idKlienti = Convert.ToInt32(this.cmbKlientet.Kolone2Vlere);
				DateTime dtFillimi = Convert.ToDateTime(this.dtpHyrjeKlienti.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpDaljeKlienti.Value);
				DataSet ds_dhoma = data.KerkesaRead("ShfaqDhomatEliraPerDateKategoriPerModifikim", idKategoria, dtFillimi, dtMbarimi, idKlienti);
				string dhoma_emri = r["DHOMA_EMRI"].ToString();
				this.cmbDhomatTeDhena.Kolone1.Items.Clear();
				this.cmbDhomatTeDhena.Kolone2.Items.Clear();
				foreach(DataRow dr in ds_dhoma.Tables[0].Rows)
				{
					this.cmbDhomatTeDhena.Kolone1.Items.Add(dr["DHOMA_EMRI"]);
					this.cmbDhomatTeDhena.Kolone2.Items.Add(dr["ID_DHOMA"]);
				}
				this.cmbDhomatTeDhena.Kolone1.Text = r["DHOMA_EMRI"].ToString();
				this.cmbDhomatTeDhena.Kolone1Vlere = r["DHOMA_EMRI"].ToString();
				this.cmbDhomatTeDhena.Kolone2.Text = r["ID_DHOMA"].ToString();
				this.cmbDhomatTeDhena.Kolone2Vlere = r["ID_DHOMA"].ToString();

				this.numCmimiKlienti.Text = r["CMIMI"].ToString();

				this.cmbMjeteIdentifikimi.Kolone1.Text = r["EMER_LLOJI"].ToString();
				this.cmbMjeteIdentifikimi.Kolone1Vlere = r["EMER_LLOJI"].ToString();
				this.cmbMjeteIdentifikimi.Kolone2.Text = r["ID_LLOJI"].ToString();
				this.cmbMjeteIdentifikimi.Kolone2Vlere = r["ID_LLOJI"].ToString();

				this.txtIdNo.Text = r["NR_IDENTIFIKIMI"].ToString();

				this.dtpDatelindjaKlienti.Value = r["DATELINDJA"].ToString();
				this.txtTelefoniKlienti.Text= r["TELEFONI"].ToString();
				this.txtAdresaKlienti.Text = r["ADRESA"].ToString();
				this.txtTargaKlienti.Text = r["TARGA"].ToString();
				this.txtEmailKlienti.Text= r["EMAIL"].ToString();

				this.txtVendlindjaKlienti.Text = r["VENDLINDJA"].ToString();
				this.txtShtetesiaKlienti.Text = r["SHTETESIA"].ToString();

			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		//pastrohen fushat poshte kesaj per te mos mbetur me vone vlera te gabuara
		//kjo behet per te dy DateTimePickers
		private void dtpHyrjeKlienti_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.cmbDhomatTeDhena.Kolone1.Text = "";
				this.cmbDhomatTeDhena.Kolone2.Text = "";
				this.cmbDhomatTeDhena.Kolone1.Items.Clear();
				this.cmbDhomatTeDhena.Kolone2.Items.Clear();
				this.numCmimiKlienti.Text = "";
				this.cmbKategoria.Kolone1.Text = "";
			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
			}
		}

		private void dtpDaljeKlienti_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.cmbDhomatTeDhena.Kolone1.Text = "";
				this.cmbDhomatTeDhena.Kolone2.Text = "";
				this.cmbDhomatTeDhena.Kolone1.Items.Clear();
				this.cmbDhomatTeDhena.Kolone2.Items.Clear();
				this.numCmimiKlienti.Text = "";
				this.cmbKategoria.Kolone1.Text = "";
			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
			}
		}

		//pastrohen fushat poshte kesaj per te mos mbetur me vone vlera te gabuara
		//kjo behet per te dy DateTimePickers
		private void dtpHyrjeGrupi_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.cmbDhomatGrup.Kolone1.Text = "";
				this.cmbDhomatGrup.Kolone2.Text = "";
				this.cmbDhomatGrup.Kolone1.Items.Clear();
				this.cmbDhomatGrup.Kolone2.Items.Clear();
				this.numCmimiGrupi.Text = "";
				this.cmbKategoriaGrup.Kolone1.Text = "";
			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
			}
		}	
		private void dtpDaljeGrupi_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.cmbDhomatGrup.Kolone1.Text = "";
				this.cmbDhomatGrup.Kolone2.Text = "";
				this.cmbDhomatGrup.Kolone1.Items.Clear();
				this.cmbDhomatGrup.Kolone2.Items.Clear();
				this.numCmimiGrupi.Text = "";
				this.cmbKategoriaGrup.Kolone1.Text = "";
			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
			}
		}
		/// <summary>
		/// Shfaqen te gjitha dhomat e lira perfshire edhe dhomen qe ishte zgjedhur pak me pare
		/// nqs behet fjale per te njejtin interval datash
		/// </summary>
		/// <param name="Sender"></param>
		/// <param name="e"></param>
		private void cmbKategoria_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				if (this.gridKlienti.CurrentRowIndex >= 0 )
				{
					int idKategoria = Convert.ToInt32(this.cmbKategoria.Kolone2Vlere);
					DateTime dtHyrje = Convert.ToDateTime(this.dtpHyrjeKlienti.Value);
					DateTime dtDalje = Convert.ToDateTime(this.dtpDaljeKlienti.Value);
					DateTime dtFillimi = Convert.ToDateTime(this.gridKlienti[this.gridKlienti.CurrentRowIndex, 10].ToString());
					DateTime dtMbarimi = Convert.ToDateTime(this.gridKlienti[this.gridKlienti.CurrentRowIndex, 11].ToString());
					InputController data = new InputController();
					int k = this.KontrolloDatat(idKategoria, dtHyrje, dtDalje);
					if (k == -1)
					{
						this.error.SetError(this.dtpDaljeKlienti, "Data e daljes duhet te jete me e madhe data e hyrjes");
						this.dtpHyrjeKlienti.IsValid = false;
						this.dtpDaljeKlienti.IsValid = false;
						return;
					}
					DataSet ds;
					if (this.cmbKlientet.Kolone1.SelectedItem != null)
					{
						if ((dtHyrje >= dtMbarimi)||(dtDalje <= dtFillimi))//jashte intervalit te hyrjes
							ds = data.KerkesaRead("ShfaqDhomatEliraPerDatatPerKategorine", idKategoria, dtHyrje, dtDalje);
						else
						{
							int idKlienti = Convert.ToInt32(this.cmbKlientet.Kolone2Vlere);
							ds = data.KerkesaRead("ShfaqDhomatEliraPerDateKategoriPerModifikim", idKategoria, dtHyrje, dtDalje, idKlienti);
						}
					}
					else
					{
						ds = data.KerkesaRead("ShfaqDhomatEliraPerDatatPerKategorine", idKategoria, dtHyrje, dtDalje);
					}
					if (ds.Tables[0].Rows.Count == 0)
					{
						string koment = "Per datat e zgjedhura kategoria nuk ka asnje dhome te lire" + Environment.NewLine + "ose asnje prej dhomave nuk i eshte konfiguruar cmimi." + Environment.NewLine + "Zgjidhni nje kategori tjeter ose konfiguroni cmimet!";
						System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					this.numCmimiKlienti.Text = "";
					this.cmbDhomatTeDhena.Kolone1.Text = "";
					this.cmbDhomatTeDhena.Kolone1.Items.Clear();
					this.cmbDhomatTeDhena.Kolone2.Items.Clear();
					foreach(DataRow dr in ds.Tables[0].Rows)
					{
						this.cmbDhomatTeDhena.Kolone1.Items.Add(dr["DHOMA_EMRI"]);
						this.cmbDhomatTeDhena.Kolone2.Items.Add(dr["ID_DHOMA"]);
					}
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
			}
		}

		/// <summary>
		/// Shfaqen te gjitha dhomat e lira perfshire edhe dhomen qe ishte zgjedhur pak me pare
		/// nqs behet fjale per te njejtin interval datash
		/// </summary>
		/// <param name="Sender"></param>
		/// <param name="e"></param>
		private void cmbKategoriaGrup_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				if (this.gridGrupi.CurrentRowIndex >= 0)
				{
					int idKategoria = Convert.ToInt32(this.cmbKategoriaGrup.Kolone2Vlere);
					DateTime dtHyrje = Convert.ToDateTime(this.dtpHyrjeGrupi.Value);
					DateTime dtDalje = Convert.ToDateTime(this.dtpDaljeGrupi.Value);
					DateTime dtFillimi = Convert.ToDateTime(this.gridGrupi[this.gridGrupi.CurrentRowIndex, 11].ToString());
					DateTime dtMbarimi = Convert.ToDateTime(this.gridGrupi[this.gridGrupi.CurrentRowIndex, 12].ToString());
					InputController data = new InputController();
					int k = this.KontrolloDatat(idKategoria, dtHyrje, dtDalje);
					if (k == -1)
					{
						this.error.SetError(this.dtpDaljeGrupi, "Data e daljes duhet te jete me e madhe data e hyrjes");
						this.dtpHyrjeGrupi.IsValid = false;
						this.dtpDaljeGrupi.IsValid = false;
						return;
					}
					DataSet ds;
					if (this.cmbKlientetGrupi.Kolone1.SelectedItem != null)
					{
						if ((dtHyrje >= dtMbarimi)||(dtDalje <= dtFillimi))//jashte intervalit te hyrjes
							ds = data.KerkesaRead("ShfaqDhomatEliraPerDatatPerKategorine", idKategoria, dtHyrje, dtDalje);
						else
						{
							int idKlienti = Convert.ToInt32(this.cmbKlientetGrupi.Kolone2Vlere);
							ds = data.KerkesaRead("ShfaqDhomatEliraPerDateKategoriPerModifikim", idKategoria, dtHyrje, dtDalje, idKlienti);
						}
					}
					else
					{
						ds = data.KerkesaRead("ShfaqDhomatEliraPerDatatPerKategorine", idKategoria, dtHyrje, dtDalje);
					}
					if (ds.Tables[0].Rows.Count == 0)
					{
				
						string koment = "Per datat e zgjedhura kategoria nuk ka asnje dhome te lire" + Environment.NewLine + "ose asnje prej dhomave nuk i eshte konfiguruar cmimi." + Environment.NewLine + "Zgjidhni nje kategori tjeter ose konfiguroni cmimet!";
						System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					this.numCmimiGrupi.Text = "";
					this.cmbDhomatGrup.Kolone1.Text = "";
					this.cmbDhomatGrup.Kolone1.Items.Clear();
					this.cmbDhomatGrup.Kolone2.Items.Clear();
					foreach(DataRow dr in ds.Tables[0].Rows)
					{
						this.cmbDhomatGrup.Kolone1.Items.Add(dr["DHOMA_EMRI"]);
						this.cmbDhomatGrup.Kolone2.Items.Add(dr["ID_DHOMA"]);
					}
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
			}
		}

		/// <summary>
		/// Behet modifikimi i te dhenave per klientet
		/// sipas rasteve te ndryshem, paraprakisht kontrollohet edhe rregullsia e kaparit
		/// te hedhur per dhomat
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnModifikoKlient_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				int index = Convert.ToInt32(gridKlienti.CurrentRowIndex);
				int idKlienti = Convert.ToInt32(this.cmbKlientet.Kolone2Vlere);
				int idKategoria = Convert.ToInt32(this.cmbKategoria.Kolone2Vlere);
				string emri = this.txtEmriKlienti.Text;
				string mbiemri = this.txtMbiemriKlienti.Text;
				DateTime datelindja = Convert.ToDateTime(this.dtpDatelindjaKlienti.Value);
				string adresa = this.txtAdresaKlienti.Text;
				string telefoni = this.txtTelefoniKlienti.Text;
				string emaili = this.txtEmailKlienti.Text;
				string targa = this.txtTargaKlienti.Text;
				string vendlindja = this.txtVendlindjaKlienti.Text ;
				string shtetesia = this.txtShtetesiaKlienti.Text;
				DateTime dtFillimi = Convert.ToDateTime(this.dtpHyrjeKlienti.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpDaljeKlienti.Value);
				int idLlojIdentifikimi = Convert.ToInt32(this.cmbMjeteIdentifikimi.Kolone2Vlere);
				string nrIdentifikimi = this.txtIdNo.Text;
				int idDhoma = Convert.ToInt32(this.cmbDhomatTeDhena.Kolone2Vlere);
				//numri i klienteve ne dhome aktualisht
				int nrKliente = this.cmbKlientet.Kolone1.Items.Count;
				DateTime dt = Convert.ToDateTime(this.gridKlienti[index, 10]);
				InputController data = new InputController();
				DateTime d1 = Convert.ToDateTime(ds_klient.Tables[0].Rows[0]["DATA_HYRJE"]); 
				DateTime d2 = Convert.ToDateTime(ds_klient.Tables[0].Rows[0]["DATA_DALJE"]);
				int idDhomaVjeter = Convert.ToInt32(ds_klient.Tables[0].Rows[0]["ID_DHOMA"]);
				int idRezervimi = 0;
				if (! Convert.IsDBNull(ds_klient.Tables[0].Rows[0]["ID_REZERVIMI"]))
					idRezervimi = Convert.ToInt32(ds_klient.Tables[0].Rows[0]["ID_REZERVIMI"]);
				//gjendet kapari, skonto, gjoba, pergjegjes per dhomen e dikurshme
				//keto te dhena nuk merren direkt nga grida sepse
				//mund te ndodhe qe ne varesi te kerkimit ne gride te mos shfaqet pergjegjesi
//				DataSet dsKaparPergjegjes = this.gjejKaparPergjegjes(Convert.ToInt32(gridKlienti[index, 0]), dt);
//				int kapari = Convert.ToInt32(dsKaparPergjegjes.Tables[0].Rows[0][0]);
//				int skonto = Convert.ToInt32(dsKaparPergjegjes.Tables[0].Rows[0][1]);
//				int gjoba = Convert.ToInt32(dsKaparPergjegjes.Tables[0].Rows[0][2]);
//				int pergjegjes = Convert.ToInt32(dsKaparPergjegjes.Tables[0].Rows[0][3]);

				DateTime dtHyrje = Convert.ToDateTime(this.dtpHyrjeKlienti.Value);
				DateTime dtDalje = Convert.ToDateTime(this.dtpDaljeKlienti.Value);
				DataSet dsHyrja = data.KerkesaRead("ShfaqVeprimetPerDhomen", idDhomaVjeter,-1, d1, d2);
				int indexkerkuar = this.KerkoDataSet(dsHyrja, d1, d2);
				//indexkerkuar eshte gjithmone me i madh se 0, eshte te pakten kl qe po eleminohet
				DataRow drk = dsHyrja.Tables["KLIENTI"].Rows[indexkerkuar];
				string strId = drk["ID_KLIENTI_STR"].ToString();
				DataSet tmp = this.gjejDataSetKlientet(strId);
//				DataSet dsData = this.GjejIntervalinPaKlient(tmp, idKlienti);
//				DateTime dataMax;
//				if (dsData.Tables[0].Rows.Count != 0)//normalisht duhet te jete gjithmone != 0 sepse jemi ne rastin kur jane me shume se nje klient ne dhome
//					dataMax = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MAXDATA"]);
//				else
//					dataMax = dtDalje;
				int pergjegjes = Convert.ToInt32(drk["PERGJEGJES"]);
				int kapari = Convert.ToInt32(drk["KAPARI"]);
				int skonto = Convert.ToInt32(drk["SKONTO"]);
				int gjoba = Convert.ToInt32(drk["GJOBA"]);

//				DateTime dataMaxDhoma = Convert.ToDateTime(this.gridKlienti[index, 10].ToString());
//				DateTime dataMinDhoma = Convert.ToDateTime(this.gridKlienti[index, 11].ToString());

				if (ds_klient.Tables[0].Rows[0]["KLIENT_HOTELI"].ToString() == "False")
				{
					if (d1 != dtFillimi)
					{
						this.error.SetError(this.dtpHyrjeKlienti, "Nuk mund te ndryshoni daten e hyrjes" + Environment.NewLine + "per nje klient qe ka dale nga hoteli!");
						this.dtpHyrjeKlienti.IsValid = false;
						return;
					}
					if (d2 != dtMbarimi)
					{
						this.error.SetError(this.dtpDaljeKlienti, "Nuk mund te ndryshoni daten e daljes" + Environment.NewLine + "per nje klient qe ka dale nga hoteli!");
						this.dtpDaljeKlienti.IsValid = false;
						return;
					}
					if ((idDhoma != idDhomaVjeter))
					{
						this.error.SetError(this.cmbDhomatTeDhena, "Nuk mund te ndryshoni dhomen" + Environment.NewLine + "per nje klient qe ka dale nga hoteli!");
						this.cmbDhomatTeDhena.IsValid = false;
						return;
					}
				}
				DataSet dsResult = this.KontrolloKlient();
				int resultError = Convert.ToInt32(dsResult.Tables[0].Rows[0]["A"]);
				int k = Convert.ToInt32(dsResult.Tables[0].Rows[0]["B"]);
				if (this.AfishoGabimKaparKlienti(resultError) != 0)//ka gabim ne kapar
					return;
				if (this.KontrolloPerDetyrime(idKlienti, dtFillimi, dtMbarimi) == 1)
				{
					System.Windows.Forms.MessageBox.Show(this, "Modifikimi nuk mund te kryhet!" + Environment.NewLine + "Klienti ka detyrime te hedhura te cilat pas modifikimit"
						+ Environment.NewLine + "te dateve dalin jashte intervalit te klientit!",
						"Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				int b = -1;
				//do te merret parasysh qe nqs klienti eshte futur ne hotel ne saje te rezervimit atij nuk mund t'i ndryshohen
				//te dhena te rendesishme qe kane te bejne me hyrjen
				switch(k)
				{
					case 1:
						//rasti kur klienti mbetet ne te njejten dhome 
						//klienti mbetet brenda intervalit te datave
						b = data.KerkesaUpdate("ModifikoTeDhenaKlienti", emri, mbiemri, datelindja, adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idLlojIdentifikimi, nrIdentifikimi, idDhoma, idKlienti, vendlindja, shtetesia);
						break;
					case 2:
						//rasti kur klienti mbetet ne te njejten dhome
						//por del jashte intervalit te hyrjes
						//Vetem --> Vetem
						b = data.KerkesaUpdate("ModifikoTeDhenaKlienti", emri, mbiemri, datelindja, adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idLlojIdentifikimi, nrIdentifikimi, idDhoma, idKlienti,vendlindja, shtetesia);				
						break;
					case 3:
						//rasti kur klienti mbetet ne te njejten dhome 
						//klienti nuk eshte vetem ne dhome aktualisht
						//por modifikimi  i datave e nxjerr jashte intervalit te dhomes
						//nderkohe ne dhome per datat e modifikuara nuk ka asnje klient tjeter
						//Shume --> Vetem
						if (idRezervimi != 0)
						{
							string koment = "Modifikimi i datave e vendos klientin ne nje hyrje tjeter ne hotel.";
							koment += Environment.NewLine + "Nje kalim i tille nuk mund te behet";
							koment += Environment.NewLine + "sepse klienti i zgjedhur eshte futur ne hotel me ane te rezervimeve!";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						if (pergjegjes == idKlienti)
						{
							//klienti eshte pergjegjes per dhomen  e vet prandaj kapari  i tij i kalohet klientit tjeter
							//vete klienti kalon me kapar 0 tek dhoma per datat e modifikuara
							int pergjegjes_ri = 0;
							int id_tmp = 0;
							DateTime min = DateTime.Now.AddYears(2000);
							foreach(DataRow r in tmp.Tables[0].Rows)
							{
								id_tmp = Convert.ToInt32(r["ID"]);
								if (id_tmp != idKlienti)
								{
									if (Convert.ToDateTime(r["DATA_HYRJE"]) < min)
									{
										pergjegjes_ri = id_tmp;
										min = Convert.ToDateTime(r["DATA_HYRJE"]);
									}
								}
							}
							b = data.KerkesaUpdate("ModifikoTeDhenaPergjegjes", emri, mbiemri, datelindja,
								adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idLlojIdentifikimi,
								nrIdentifikimi, idDhoma, kapari, skonto, gjoba, idKlienti, pergjegjes_ri,
								min, vendlindja, shtetesia,this.PerdoruesId);
						}
						else
						{
							//klienti nuk eshte pergjegjes per dhomen dhe kalon me kapar 0 tek dhoma per datat e modifikuara
							b = data.KerkesaUpdate("ModifikoTeDhenaKlienti", emri, mbiemri, datelindja, adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idLlojIdentifikimi, nrIdentifikimi, idDhoma, idKlienti, vendlindja, shtetesia);
						}
						if (b == 0)
						{
							string koment = "Pas modifikimit te klientit dhomes nuk i eshte hedhur kapar per datat e modifikuara." + Environment.NewLine + "Ne rast se doni te hidhni kapar vazhdoni me modifikimin e kaparit te dhomes per keto data.";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						break;
					case 4:
						//rasti kur klienti mbetet ne te njejten dhome 
						//klienti eshte i vetmi ne dhome aktualisht
						//por dhoma ka kliente te tjere per datat e modifikuara
						//klienti kalon me kapar 0 ne datat e reja
						//Vetem --> Shume
						if (idRezervimi != 0)
						{
							string koment = "Modifikimi i datave e vendos klientin ne nje hyrje tjeter ne hotel.";
							koment += Environment.NewLine + "Nje kalim i tille nuk mund te behet";
							koment += Environment.NewLine + "sepse klienti i zgjedhur eshte futur ne hotel me ane te rezervimeve!";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						b = data.KerkesaUpdate("ModifikoTeDhenaPergjegjes", emri, mbiemri, datelindja, 
							adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idLlojIdentifikimi,
							nrIdentifikimi, idDhoma, idKlienti,vendlindja, shtetesia,this.PerdoruesId);
						if (b == 0)
						{
							string s = "Ndryshimi i datave per klientin e kalon ate ne nje hyrje te re.";
							s += Environment.NewLine + "Per datat e caktuara dhomes i eshte aplikuar nje here kapar."; 
							s += Environment.NewLine + "Nqs me ardhjen e klientit te ri deshironi te shtoni kaparini";
							s += Environment.NewLine + "kryeni modifikimin e kaparit per keto data!";
							s += Environment.NewLine + "Kapari qe mund te jete hedhur per datat e vjetra nuk eshte me i vlefshem!";
							System.Windows.Forms.MessageBox.Show(this,s , "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);	
						}
						break;
					case 5:
						//rasti kur klienti mbetet ne te njejten dhome 
						//klienti nuk eshte vetem ne dhome aktualisht
						//por modifikimi  i datave e nxjerr jashte intervalit te dhomes
						//nderkohe ne dhome per datat e modifikuara ka  kliente te tjere
						//Shume --> Shume
						if (idRezervimi != 0)
						{
							string koment = "Modifikimi i datave e vendos klientin ne nje hyrje tjeter ne hotel.";
							koment += Environment.NewLine + "Nje kalim i tille nuk mund te behet";
							koment += Environment.NewLine + "sepse klienti i zgjedhur eshte futur ne hotel me ane te rezervimeve!";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						if (pergjegjes == idKlienti)
						{
							int pergjegjes_ri = 0;
							int id_tmp = 0;
							DateTime min = DateTime.Now.AddYears(2000);
							foreach(DataRow r in tmp.Tables[0].Rows)
							{
								id_tmp = Convert.ToInt32(r["ID"]);
								if (id_tmp != idKlienti)
								{
									if (Convert.ToDateTime(r["DATA_HYRJE"]) < min)
									{
										pergjegjes_ri = id_tmp;
										min = Convert.ToDateTime(r["DATA_HYRJE"]);
									}
								}
							}
							b = data.KerkesaUpdate("ModifikoTeDhenaPergjegjes", emri, mbiemri, datelindja, 
								adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idLlojIdentifikimi,
								nrIdentifikimi, idDhoma, kapari, skonto, gjoba, idKlienti, pergjegjes_ri,
								min, vendlindja, shtetesia,this.PerdoruesId);
						}
						else
						{
							//klienti nuk eshte pergjegjes per dhomen dhe kalon me kapar 0 tek dhoma per datat e modifikuara
							b = data.KerkesaUpdate("ModifikoTeDhenaKlienti", emri, mbiemri, datelindja, adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idLlojIdentifikimi, nrIdentifikimi, idDhoma, idKlienti,vendlindja, shtetesia);
						}
						if (b == 0)
							System.Windows.Forms.MessageBox.Show(this, "Per datat e caktuara dhomes i eshte aplikuar nje here kapar." + Environment.NewLine + "Nqs me ardhjen e klientit te ri deshironi te shtoni kaparini" + Environment.NewLine + "kryeni modifikimet e duhura!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);		
						break;
					case 6:
						//rasti kur klientit i ndryshohet dhoma por 
						//dhoma nuk ka asnje klient
						//klienti ishte vetem ne dhomen e dikurshme
						//kapari nuk ndryshon
						//Vetem --> Vetem
						b = data.KerkesaUpdate("ModifikoTeDhenaKlienti", emri, mbiemri, datelindja, adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idLlojIdentifikimi, nrIdentifikimi, idDhoma, idKlienti,vendlindja, shtetesia);
						break;
					case 7:
						//rasti kur klientit i ndryshohet dhoma por 
						//dhoma nuk ka asnje klient
						//ne dhomen e dikurshme edhe kliente te tjere
						//Shume --> Vetem
						if (idRezervimi != 0)
						{
							string koment = "Modifikimi i datave e vendos klientin ne nje hyrje tjeter ne hotel.";
							koment += Environment.NewLine + "Nje kalim i tille nuk mund te behet";
							koment += Environment.NewLine + "sepse klienti i zgjedhur eshte futur ne hotel me ane te rezervimeve!";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						if (pergjegjes == idKlienti)
						{
							//klienti eshte pergjegjes per dhomen  e vet prandaj kapari  i tij i kalohet klientit tjeter
							//vete klienti kalon me kapar 0 tek dhoma per datat e modifikuara
							int pergjegjes_ri = 0;
							int id_tmp = 0;
							DateTime min = DateTime.Now.AddYears(2000);
							foreach(DataRow r in tmp.Tables[0].Rows)
							{
								id_tmp = Convert.ToInt32(r["ID"]);
								if (id_tmp != idKlienti)
								{
									if (Convert.ToDateTime(r["DATA_HYRJE"]) < min)
									{
										pergjegjes_ri = id_tmp;
										min = Convert.ToDateTime(r["DATA_HYRJE"]);
									}
								}
							}
							b = data.KerkesaUpdate("ModifikoTeDhenaPergjegjes", emri, mbiemri, datelindja, 
								adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idLlojIdentifikimi,
								nrIdentifikimi, idDhoma, kapari, skonto, gjoba, idKlienti, pergjegjes_ri, 
								min,vendlindja, shtetesia,this.PerdoruesId);
						}
						else
						{
							//klienti nuk eshte pergjegjes per dhomen dhe kalon me kapar 0 te pandryshuar tek dhoma per datat e modifikuara
							b = data.KerkesaUpdate("ModifikoTeDhenaKlienti", emri, mbiemri, datelindja, adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idLlojIdentifikimi, nrIdentifikimi, idDhoma, idKlienti,vendlindja, shtetesia);
						}
						if (b == 0)
						{
							string koment = "Pas modifikimit te klientit dhomes se caktuar" + Environment.NewLine + "nuk i eshte hedhur kapar per datat." +Environment.NewLine+ "Ne rast se doni te hidhni kapar vazhdoni" + Environment.NewLine +  "me modifikimin e kaparit te dhomes per keto data.";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						break;
					case 8:
						//rasti kur klientit i ndryshohet dhoma
						//nderkohe ne dhome ka kliente te tjere
						//klienti eshte vetem ne dhomen e dikurshme
						//klienti kalon me kapar 0 te dhoma e re
						//Vetem --> Shume
						if (idRezervimi != 0)
						{
							string koment = "Ndryshimi i dhomes e vendos klientin ne nje hyrje tjeter ne hotel.";
							koment += Environment.NewLine + "Nje kalim i tille nuk mund te behet";
							koment += Environment.NewLine + "sepse klienti i zgjedhur eshte futur ne hotel me ane te rezervimeve!";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						b = data.KerkesaUpdate("ModifikoTeDhenaPergjegjes", emri, mbiemri, datelindja,
							adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idLlojIdentifikimi, 
							nrIdentifikimi, idDhoma, idKlienti,vendlindja, shtetesia,this.PerdoruesId);
						if (b == 0)
						{
							string s = "Ndryshimi i dhomes per klientin e kalon ate ne nje hyrje tjeter.";
							s += Environment.NewLine + "Per datat e caktuara dhomes se re i eshte aplikuar nje here kapar."; 
							s += Environment.NewLine + "Nqs me ardhjen e klientit te ri deshironi te shtoni kaparini";
							s += Environment.NewLine + "kryeni modifikimin e kaparit te dhomes per keto data!";
							s += Environment.NewLine + "Kapari qe mund te jete hedhur per dhomen e vjeter nuk eshte me i vlefshem!";
							System.Windows.Forms.MessageBox.Show(this, s, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);	
						}
						break;
					case 9:
						//rasti kur klientit i ndryshohet dhoma
						//nderkohe ne dhome ka kliente te tjere
						//ne dhomen aktuale ka edhe kliente te tjere
						//klienti kalon me kapar 0 te dhoma e re
						//Shume --> Shume
						if (idRezervimi != 0)
						{
							string koment = "Modifikimi i datave e vendos klientin ne nje hyrje tjeter ne hotel.";
							koment += Environment.NewLine + "Nje kalim i tille nuk mund te behet";
							koment += Environment.NewLine + "sepse klienti i zgjedhur eshte futur ne hotel me ane te rezervimeve!";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						if (pergjegjes == idKlienti)
						{
							//klienti eshte pergjegjes per dhomen  e vet prandaj kapari  i tij i kalohet klientit tjeter
							//vete klienti kalon me kapar 0 tek dhoma per datat e modifikuara
							int pergjegjes_ri = 0;
							int id_tmp = 0;
							DateTime min = DateTime.Now.AddYears(2000);
							foreach(DataRow r in tmp.Tables[0].Rows)
							{
								id_tmp = Convert.ToInt32(r["ID"]);
								if (id_tmp != idKlienti)
								{
									if (Convert.ToDateTime(r["DATA_HYRJE"]) < min)
									{
										pergjegjes_ri = id_tmp;
										min = Convert.ToDateTime(r["DATA_HYRJE"]);
									}
								}
							}
							b = data.KerkesaUpdate("ModifikoTeDhenaPergjegjes", emri, mbiemri, datelindja, 
								adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idLlojIdentifikimi,
								nrIdentifikimi, idDhoma, kapari, skonto, gjoba, idKlienti, pergjegjes_ri, 
								min,vendlindja, shtetesia,this.PerdoruesId);
						}
						else
						{
							//klienti nuk eshte pergjegjes per dhomen dhe kalon me kapar 0 te pandryshuar tek dhoma per datat e modifikuara
							b = data.KerkesaUpdate("ModifikoTeDhenaKlienti", emri, mbiemri, datelindja, adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idLlojIdentifikimi, nrIdentifikimi, idDhoma, idKlienti,vendlindja, shtetesia);
						}
						if (b == 0)
							System.Windows.Forms.MessageBox.Show(this, "Modifikimi i datave e vendos klientin ne nje hyrje tjeter ne hotel." + Environment.NewLine +"Per datat e caktuara dhomes i eshte aplikuar nje here kapar." 
							+ Environment.NewLine + "Nqs me ardhjen e klientit te ri deshironi te shtoni kaparini" 
							+ Environment.NewLine + "kryeni modifikimet e duhura!", 
							"Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);	
						break;
					default:
						b = -1;
						break;
				}
				if (b == 0)
				{
					string koment = "Modifikimi i te dhenave per klientin u krye!";
					System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.RefreshKlienti(sender, e);
					this.Pastro(this.gbKlientet);
					this.cmbKlientet.Kolone1.Items.Clear();
					this.cmbKlientet.Kolone2.Items.Clear();
				}
				else
				{
					string koment = "Modifikimi i te dhenave per klientin nuk u krye! Provoni perseri!";
					System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
		
		/// <summary>
		/// Behet modifikimi i te dhenave per klientet
		/// sipas rasteve te ndryshem, paraprakisht kontrollohet edhe rregullsia e kaparit
		/// te hedhur per dhomat
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnModifikoKlientGrup_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				int b = 0;
				int index = this.gridGrupi.CurrentRowIndex;
				DataRow r = this.ds_grupi.Tables[0].Rows[0];
				DateTime d1 = Convert.ToDateTime(r["DATA_HYRJE"]);
				DateTime d2 = Convert.ToDateTime(r["DATA_DALJE"]);
				int idDhomaVjeter = Convert.ToInt32(r["ID_DHOMA"]);
				int idGrupiVjeter = Convert.ToInt32(r["ID_GRUPI"]);

				int idKlienti = Convert.ToInt32(this.cmbKlientetGrupi.Kolone2Vlere);
				int idGrupi = Convert.ToInt32(this.cmbGrupetTeDhena.Kolone2Vlere);
				string emri = this.txtEmriKlientiGrupi.Text;
				string mbiemri = this.txtMbiemriKlientiGrupi.Text;
				DateTime dtHyrje = Convert.ToDateTime(this.dtpHyrjeGrupi.Value);
				DateTime dtDalje = Convert.ToDateTime(this.dtpDaljeGrupi.Value);
				int idDhoma = Convert.ToInt32(this.cmbDhomatGrup.Kolone2Vlere);
				int idLlojIdentifikimi = Convert.ToInt32(cmbMjeteId.Kolone2Vlere);
				string nrIdentifikimi = this.txtIdNoGrupi.Text;
				DateTime datelindja = Convert.ToDateTime(this.dtpDatelindjaGrupi.Value);
				string telefoni = this.txtTelGrupi.Text;
				string adresa = this.txtAdresaGrupi.Text;
				string targa = this.txtTargaGrupi.Text;
				string email = this.txtEmailGrupi.Text;
				string vendlindja = this.txtVendlindjaGrupi.Text ;
				string shtetesia = this.txtShtetesiaGrupi.Text;
				DateTime dt = Convert.ToDateTime(gridGrupi[index, 11]);

				int idRezervimi = 0;
				if (! Convert.IsDBNull(this.ds_grupi.Tables[0].Rows[0]["ID_REZERVIMI"]))
					idRezervimi = Convert.ToInt32(ds_klient.Tables[0].Rows[0]["ID_REZERVIMI"]);
				InputController data = new InputController();
				DateTime dataMinDhoma = Convert.ToDateTime(this.gridGrupi[index, 11]);
				DateTime dataMaxDhoma = Convert.ToDateTime(this.gridGrupi[index, 12]);
				DataSet ds = data.KerkesaRead("ShfaqVeprimetPerGrupin",idGrupiVjeter, -1, dataMinDhoma, dataMaxDhoma);
				int indexkerkuar = this.KerkoDataSet(ds, dataMinDhoma, dataMaxDhoma);
				DataRow drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
				int pergjegjes = Convert.ToInt32(drk["PERGJEGJES"]);
				int kapari = Convert.ToInt32(drk["KAPARI"]);
				int skonto = Convert.ToInt32(drk["SKONTO"]);
				int gjoba = Convert.ToInt32(drk["GJOBA"]);
				string strId = Convert.ToString(drk["ID_KLIENTI_STR"]);
				DataSet tmp = this.gjejDataSetKlientet(strId);
				if (r["KLIENT_HOTELI"].ToString() == "False")
				{
					if (idGrupiVjeter != idGrupi)
					{
						this.error.SetError(this.cmbGrupetTeDhena, "Nuk mund te ndryshoni grupin" + Environment.NewLine + "per nje klient qe ka dale nga hoteli!");
						cmbGrupetTeDhena.IsValid = false;
						return;
					}
					if (d1 != dtHyrje)
					{
						this.error.SetError(this.dtpHyrjeGrupi, "Nuk mund te ndryshoni daten e hyrjes" + Environment.NewLine + "per nje klient qe ka dale nga hoteli!");
						dtpHyrjeGrupi.IsValid = false;
						return;
					}
					if (d2 != dtDalje)
					{
						this.error.SetError(this.dtpDaljeGrupi, "Nuk mund te ndryshoni daten e daljes" + Environment.NewLine + "per nje klient qe ka dale nga hoteli!");
						dtpDaljeGrupi.IsValid = false;
						return;
					}
					if (idDhomaVjeter != idDhoma)
					{
						this.error.SetError(this.cmbDhomatGrup, "Nuk mund te ndryshoni dhomen" + Environment.NewLine +  "per nje klient qe ka dale nga hoteli!");
						cmbDhomatGrup.IsValid = false;
						return;
					}
				}
				DataSet dsResult = this.KontrolloGrup();
				int resultError = Convert.ToInt32(dsResult.Tables[0].Rows[0]["A"]);
				int k = Convert.ToInt32(dsResult.Tables[0].Rows[0]["B"]);
				if (this.AfishoGabimKaparGrupi(resultError) != 0)//ka gabim ne kapar
					return;
				if (this.KontrolloPerDetyrime(idKlienti, dtHyrje, dtDalje) == 1)
				{
					System.Windows.Forms.MessageBox.Show(this, "Modifikimi nuk mund te kryhet!" + Environment.NewLine + "Klienti ka detyrime te hedhura te cilat pas modifikimit"
						+ Environment.NewLine + "te dateve dalin jashte intervalit te klientit!",
						"Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				switch(k)
				{
					case 1:
						//klienti mbetet ne te njejtin grup
						//aktualisht klienti nuk eshte vetem ne grup
						//modifikimi i datave e mban klientin brenda intervalit te grupit
						//behet normalisht modifikimi i klientit
						b = data.KerkesaUpdate("ModifikoTeDhenaKlientiGrupi", emri, mbiemri, datelindja, adresa, telefoni, email, targa, dtHyrje, dtDalje, idLlojIdentifikimi, nrIdentifikimi, idDhoma, idKlienti, idGrupi,vendlindja, shtetesia);
						break;
					case 2:
						//klienti mbetet ne te njejtin grup
						//aktualisht klienti eshte vetem ne grup
						//per datat e modifikuara grupi nuk ka te tjere kliente
						b = data.KerkesaUpdate("ModifikoTeDhenaKlientiGrupi", emri, mbiemri, datelindja, adresa, telefoni, email, targa, dtHyrje, dtDalje, idLlojIdentifikimi, nrIdentifikimi, idDhoma, idKlienti, idGrupi,vendlindja, shtetesia);
						//klienti kalon me gjithe kapar ne datat e reja
						//Vetem -->Vetem
						if (b == 0)
						{
							System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave per klientin u krye!" + Environment.NewLine + "Kapari i hedhur per grupin vazhdon te jete" + Environment.NewLine + " i vlefshem edhe per datat e modifikuara!","Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							this.RefreshGrupi(sender, e);
							this.Pastro(this.gbKlientetGrupi);
							cmbKlientetGrupi.Kolone1.Items.Clear();
							cmbKlientetGrupi.Kolone2.Items.Clear();
							return;
						}
						break;
					case 3:
						//klienti mbetet ne te njejtin grup
						//aktualisht klienti nuk eshte vetem ne grup
						//modifikimi i datave e nxjerr klientin nga intervali i grupit
						//per datat e modifikuara grupi nuk ka te tjere kliente
						//Shume -->Vetem
						if (idRezervimi != 0)
						{
							string koment = "Modifikimi i datave e vendos klientin ne nje hyrje tjeter ne hotel.";
							koment += Environment.NewLine + "Nje kalim i tille nuk mund te behet";
							koment += Environment.NewLine + "sepse klienti i zgjedhur eshte futur ne hotel me ane te rezervimeve!";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						if (pergjegjes == idKlienti)//klienti eshte pergjegjes per grupin ku ndodhet
						{
							DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i hyrjeve ne hotel", "Modifikimi i datave e nxjerr klientin nga kjo hyrje" +Environment.NewLine +  "e grupit " + this.cmbGrupetTeDhena.Kolone1Vlere.ToString() + " dhe krijon nje hyrje te re!" + Environment.NewLine +"Jeni te sigurte qe doni te vazhdoni?" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							if (result != DialogResult.Yes)
							{
								System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave te klientit nuk u krye", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								return;
							}
							int pergjegjes_ri = 0;
							int id_tmp = 0;
							DateTime min = DateTime.Now.AddYears(2000);
							foreach(DataRow ro in tmp.Tables[0].Rows)
							{
								id_tmp = Convert.ToInt32(ro["ID"]);
								if (id_tmp != idKlienti)
								{
									if (Convert.ToDateTime(ro["DATA_HYRJE"]) < min)
									{
										pergjegjes_ri = id_tmp;
										min = Convert.ToDateTime(ro["DATA_HYRJE"]);
									}
								}
							}
							//klienti kalon me kapar 0 ne hyrjen e re
							//kapari i kalon klientit tjeter ne grup
							b = data.KerkesaUpdate("ModifikoTeDhenaPergjegjesGrupi", emri, mbiemri, datelindja, 
								adresa, telefoni, email, targa, dtHyrje, dtDalje, idLlojIdentifikimi, 
								nrIdentifikimi, idDhoma, kapari, skonto, gjoba, idKlienti, pergjegjes_ri, min,
								idGrupi,vendlindja, shtetesia, this.PerdoruesId);
							if (b == 0)
							{
								System.Windows.Forms.MessageBox.Show(this, "Modifikimi i  te dhenave per klientin u krye!" + Environment.NewLine + "Per hyrjen e re qe u krijua nuk eshte hedhur kapar." + Environment.NewLine + "Vazhdoni me modifikimin e kaparit per kete hyrje" +	Environment.NewLine + " ne rast se doni te hidhni kapar!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
								this.RefreshGrupi(sender, e);
								this.Pastro(this.gbKlientetGrupi);
								cmbKlientetGrupi.Kolone1.Items.Clear();
								cmbKlientetGrupi.Kolone2.Items.Clear();
								return;
							}
						}
						else//klienti nuk eshte pergjegjes pergrupin
						{
							DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i hyrjeve ne hotel", "Modifikimi i datave e nxjerr klientin" + Environment.NewLine + " nga kjo hyrje e grupit " + this.cmbGrupetTeDhena.Kolone1Vlere.ToString() + Environment.NewLine + "dhe e kalon ne nje hyrje te re te po ketij grupi!" + Environment.NewLine + " Jeni te sigurte qe doni te vazhdoni?" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							if (result != DialogResult.Yes)
							{
								System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave te klientit nuk u krye", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								return;
							}
							//klienti kalon ashtu si eshte ne hyrjen e re 
							b = data.KerkesaUpdate("ModifikoTeDhenaKlientiGrupi", emri, mbiemri, datelindja, adresa, telefoni, email, targa, dtHyrje, dtDalje, idLlojIdentifikimi, nrIdentifikimi, idDhoma, idKlienti, idGrupi,vendlindja, shtetesia);
							if (b == 0)
							{
								System.Windows.Forms.MessageBox.Show(this, "Modifikimi i  te dhenave per klientin u krye!" + Environment.NewLine + "Per hyrjen e re qe u krijua nuk eshte hedhur kapar." + Environment.NewLine + "Vazhdoni me modifikimin e kaparit per kete hyrje" + Environment.NewLine +  " ne rast se doni te hidhni kapar!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
								this.RefreshGrupi(sender, e);
								this.Pastro(this.gbKlientetGrupi);
								cmbKlientetGrupi.Kolone1.Items.Clear();
								cmbKlientetGrupi.Kolone2.Items.Clear();
								return;
							}
						}
						break;
					case 4:
						//klienti mbetet ne te njejtin grup
						//aktualisht klienti eshte vetem ne grup
						//per datat e modifikuara grupi ka te tjere kliente
						//kapari i dikurshem humbet. Hyrja ndryshon
						//Vetem --> Shume
						if (idRezervimi != 0)
						{
							string koment = "Modifikimi i datave e vendos klientin ne nje hyrje tjeter ne hotel.";
							koment += Environment.NewLine + "Nje kalim i tille nuk mund te behet";
							koment += Environment.NewLine + "sepse klienti i zgjedhur eshte futur ne hotel me ane te rezervimeve!";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						b = data.KerkesaUpdate("ModifikoTeDhenaPergjegjesGrupi", emri, mbiemri, datelindja, adresa, telefoni,
							email, targa, dtHyrje, dtDalje, idLlojIdentifikimi, nrIdentifikimi, 
							idDhoma, idKlienti,idGrupi, vendlindja, shtetesia, this.PerdoruesId);
						if (b == 0)
						{
							System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave per klientin u krye!" + Environment.NewLine + "Per datat e modifikuara grupi ka kliente te tjere ne hotel!" + Environment.NewLine + "Kapari i hedhur per datat e meparshme nuk eshte me i vlefshem!" + Environment.NewLine +  "Ne rast se doni te ndryshoni kaparin vazhdoni me modifikimet e nevojshme!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							this.RefreshGrupi(sender, e);
							this.Pastro(this.gbKlientetGrupi);
							this.cmbKlientetGrupi.Kolone1.Items.Clear();
							this.cmbKlientetGrupi.Kolone2.Items.Clear();
							return;
						}
						break;
					case 5:
						//klienti mbetet ne te njejtin grup
						//aktualisht klienti nuk eshte vetem ne grup
						//modifikimi i datave e nxjerr klientin nga intervali i grupit
						//klienti eshte pergjegjes per grupin ku ndodhet
						//per datat e modifikuara grupi ka te tjere kliente
						//Shume -->Shume
						if (idRezervimi != 0)
						{
							string koment = "Modifikimi i datave e vendos klientin ne nje hyrje tjeter ne hotel.";
							koment += Environment.NewLine + "Nje kalim i tille nuk mund te behet";
							koment += Environment.NewLine + "sepse klienti i zgjedhur eshte futur ne hotel me ane te rezervimeve!";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						if (pergjegjes == idKlienti)
						{
							DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i hyrjeve ne hotel", "Modifikimi i datave e nxjerr klientin nga kjo hyrje e grupit " + this.cmbGrupetTeDhena.Kolone1Vlere.ToString() + Environment.NewLine + "dhe e kalon ne nje hyrje tjeter te po ketij grupi! Jeni te sigurte qe doni te vazhdoni?" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							if (result != DialogResult.Yes)
							{
								System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave te klientit nuk u krye", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								return;
							}
							int pergjegjes_ri = 0;
							int id_tmp = 0;
							DateTime min = DateTime.Now.AddYears(2000);
							foreach(DataRow ro in tmp.Tables[0].Rows)
							{
								id_tmp = Convert.ToInt32(ro["ID"]);
								if (id_tmp != idKlienti)
								{
									if (Convert.ToDateTime(ro["DATA_HYRJE"]) < min)
									{
										pergjegjes_ri = id_tmp;
										min = Convert.ToDateTime(ro["DATA_HYRJE"]);
									}
								}
							}
							//klienti kalon me kapar 0 ne hyrjen e re
							//kapari i kalon klientit tjeter ne grup
							b = data.KerkesaUpdate("ModifikoTeDhenaPergjegjesGrupi", emri, mbiemri, datelindja,
								adresa, telefoni, email, targa, dtHyrje, dtDalje, idLlojIdentifikimi,
								nrIdentifikimi, idDhoma, kapari, skonto, gjoba, idKlienti, pergjegjes_ri,
								min, idGrupi,vendlindja, shtetesia, this.PerdoruesId);
							if (b == 0)
							{
								System.Windows.Forms.MessageBox.Show(this, "Modifikimi i  te dhenave per klientin u krye!" + Environment.NewLine + "Ne rast se doni te ndryshoni kaparin per hyrjet" + Environment.NewLine + "vazhdoni me modifikimin e tij!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
								this.RefreshGrupi(sender, e);
								this.Pastro(this.gbKlientetGrupi);
								cmbKlientetGrupi.Kolone1.Items.Clear();
								cmbKlientetGrupi.Kolone2.Items.Clear();
								return;
							}
						}
						else//klienti nuk eshte pergjegjes per grupin
						{
							DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i hyrjeve ne hotel", "Modifikimi i datave e nxjerr klientin nga kjo hyrje e grupit " + this.cmbGrupetTeDhena.Kolone1Vlere.ToString() + Environment.NewLine + "dhe e kalon ne nje hyrje tjeter te po ketij grupi! Jeni te sigurte qe doni te vazhdoni?" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							if (result != DialogResult.Yes)
							{
								System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave te klientit nuk u krye", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								return;
							}
							//klienti kalon ashtu si eshte ne hyrjen e re 
							b = data.KerkesaUpdate("ModifikoTeDhenaKlientiGrupi", emri, mbiemri, datelindja, adresa, telefoni, email, targa, dtHyrje, dtDalje, idLlojIdentifikimi, nrIdentifikimi, idDhoma, idKlienti, idGrupi,vendlindja, shtetesia);
							if (b == 0)
							{
								System.Windows.Forms.MessageBox.Show(this, "Modifikimi i  te dhenave per klientin u krye!" + Environment.NewLine + "Ne rast se doni te ndryshoni kaparin per hyrjet" + Environment.NewLine + "vazhdoni me modifikimin e kaparit!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
								this.RefreshGrupi(sender, e);
								this.Pastro(this.gbKlientetGrupi);
								cmbKlientetGrupi.Kolone1.Items.Clear();
								cmbKlientetGrupi.Kolone2.Items.Clear();
								return;
							}
						}
						break;
					case 6:
						//grupi ndryshohet
						//aktualisht klienti eshte vetem ne grup
						//per grupin e modifikuar nuk ka kliente te tjere
						//Vetem --> Vetem
						if (idRezervimi != 0)
						{
							string koment = "Modifikimi i grupit e vendos klientin ne nje hyrje tjeter ne hotel.";
							koment += Environment.NewLine + "Nje kalim i tille nuk mund te behet";
							koment += Environment.NewLine + "sepse klienti i zgjedhur eshte futur ne hotel me ane te rezervimeve!";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						b = data.KerkesaUpdate("ModifikoTeDhenaKlientiGrupi", emri, mbiemri, datelindja, adresa, telefoni, email, targa, dtHyrje, dtDalje, idLlojIdentifikimi, nrIdentifikimi, idDhoma, idKlienti, idGrupi,vendlindja, shtetesia);
						if (b == 0)
						{
							System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave te klientit u krye!" + Environment.NewLine + "Kapari i hedhur eshte i vlefshem edhe pas modifikimit te grupit!",
								"Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							this.RefreshGrupi(sender, e);
							this.Pastro(this.gbKlientetGrupi);
							cmbKlientetGrupi.Kolone1.Items.Clear();
							cmbKlientetGrupi.Kolone2.Items.Clear();
							return;
						}
						break;
					case 7:
						//grupi ndryshohet
						//aktualisht klienti nuk eshte vetem ne grup
						//per datat e modifikuara grupi nuk ka te tjere kliente
						//Shume --> Vetem
						if (idRezervimi != 0)
						{
							string koment = "Modifikimi i grupit e vendos klientin ne nje hyrje tjeter ne hotel.";
							koment += Environment.NewLine + "Nje kalim i tille nuk mund te behet";
							koment += Environment.NewLine + "sepse klienti i zgjedhur eshte futur ne hotel me ane te rezervimeve!";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						if (pergjegjes == idKlienti)//klienti eshte pergjegjes per grupin ku ndodhet
						{
							int pergjegjes_ri = 0;
							int id_tmp = 0;
							DateTime min = DateTime.Now.AddYears(2000);
							foreach(DataRow ro in tmp.Tables[0].Rows)
							{
								id_tmp = Convert.ToInt32(ro["ID"]);
								if (id_tmp != idKlienti)
								{
									if (Convert.ToDateTime(ro["DATA_HYRJE"]) < min)
									{
										pergjegjes_ri = id_tmp;
										min = Convert.ToDateTime(ro["DATA_HYRJE"]);
									}
								}
							}
							//klienti kalon me kapar 0 ne hyrjen e re
							//kapari i kalon klientit tjeter ne grup
							b = data.KerkesaUpdate("ModifikoTeDhenaPergjegjesGrupi", emri, mbiemri, datelindja,
								adresa, telefoni, email, targa, dtHyrje, dtDalje, idLlojIdentifikimi, 
								nrIdentifikimi, idDhoma, kapari, skonto, gjoba, idKlienti, pergjegjes_ri, 
								min, idGrupi,vendlindja, shtetesia, this.PerdoruesId);
							if (b == 0)
							{
								System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave per klientin u krye!" + Environment.NewLine + "Me modifikimin e grupit per klientin, u krijua nje hyrje e re" + Environment.NewLine + "per te cilen nuk eshte hedhur kapar. "+ Environment.NewLine + "Vazhdoni me modifikimin e kaparit per kete hyrje nese deshironi.", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
								this.RefreshGrupi(sender, e);
								this.Pastro(this.gbKlientetGrupi);
								cmbKlientetGrupi.Kolone1.Items.Clear();
								cmbKlientetGrupi.Kolone2.Items.Clear();
								return;
							}
						}
						else//klienti nuk eshte pergjegjes per grupin
						{
							//klienti kalon na grupin tjeter pa ndonje modifikim te kaparit
							b = data.KerkesaUpdate("ModifikoTeDhenaKlientiGrupi", emri, mbiemri, datelindja, adresa, telefoni, email, targa, dtHyrje, dtDalje, idLlojIdentifikimi, nrIdentifikimi, idDhoma, idKlienti, idGrupi,vendlindja, shtetesia);
							if (b == 0)
							{
								System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave per klientin u krye!" + Environment.NewLine + "Per datat e klientit grupi nuk ka hedhur kapar!" + Environment.NewLine + "Vazhdoni me modifikimin e kaparit ne rast se deshironi!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
								this.RefreshGrupi(sender, e);
								this.Pastro(this.gbKlientetGrupi);
								cmbKlientetGrupi.Kolone1.Items.Clear();
								cmbKlientetGrupi.Kolone2.Items.Clear();
								return;
							}
						}
						break;
					case 8:
						//grupi ndryshohet
						//aktualisht klienti eshte vetem ne grup
						//per grupin e modifikuar ka edhe kliente te tjere
						//klienti kalon me kapar 0 te grupi tjeter 
						//Vetem-->Shume
						if (idRezervimi != 0)
						{
							string koment = "Modifikimi i grupit e vendos klientin ne nje hyrje tjeter ne hotel.";
							koment += Environment.NewLine + "Nje kalim i tille nuk mund te behet";
							koment += Environment.NewLine + "sepse klienti i zgjedhur eshte futur ne hotel me ane te rezervimeve!";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						b = data.KerkesaUpdate("ModifikoTeDhenaPergjegjesGrupi", emri, mbiemri, datelindja,
							adresa, telefoni, email, targa, dtHyrje, dtDalje, idLlojIdentifikimi, 
							nrIdentifikimi, idDhoma, idKlienti, idGrupi,vendlindja, shtetesia,this.PerdoruesId);
						if (b == 0)
						{
							System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave per klientin u krye!" + Environment.NewLine + "Grupi " + this.cmbGrupetTeDhena.Kolone1Vlere.ToString() + " ka kliente te tjere ne hotel!" + Environment.NewLine + "Kapari i hedhur per grupin e meparshem nuk eshte me i vlefshem!" + Environment.NewLine +  "Ne rast se doni te ndryshoni kaparin vazhdoni me modifikimet e nevojshme!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							this.RefreshGrupi(sender, e);
							this.Pastro(this.gbKlientetGrupi);
							cmbKlientetGrupi.Kolone1.Items.Clear();
							cmbKlientetGrupi.Kolone2.Items.Clear();
							return;
						}
						break;
					case 9:
						//grupi ndryshohet
						//aktualisht klienti nuk eshte vetem ne grup
						//klienti eshte pergjegjes per grupin ku ndodhet
						//per datat e modifikuara grupi ka te tjere kliente
						//Shume -->Shume
						if (idRezervimi != 0)
						{
							string koment = "Modifikimi i grupit e vendos klientin ne nje hyrje tjeter ne hotel.";
							koment += Environment.NewLine + "Nje kalim i tille nuk mund te behet";
							koment += Environment.NewLine + "sepse klienti i zgjedhur eshte futur ne hotel me ane te rezervimeve!";
							System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						if (pergjegjes == idKlienti)
						{
							int pergjegjes_ri = 0;
							int id_tmp = 0;
							DateTime min = DateTime.Now.AddYears(2000);
							foreach(DataRow ro in tmp.Tables[0].Rows)
							{
								id_tmp = Convert.ToInt32(ro["ID"]);
								if (id_tmp != idKlienti)
								{
									if (Convert.ToDateTime(ro["DATA_HYRJE"]) < min)
									{
										pergjegjes_ri = id_tmp;
										min = Convert.ToDateTime(ro["DATA_HYRJE"]);
									}
								}
							}

							//klienti kalon me kapar 0 ne hyrjen e re
							//kapari i kalon klientit tjeter ne grup
							b = data.KerkesaUpdate("ModifikoTeDhenaPergjegjesGrupi", emri, mbiemri, datelindja,
								adresa, telefoni, email, targa, dtHyrje, dtDalje, idLlojIdentifikimi,
								nrIdentifikimi, idDhoma, kapari, skonto, gjoba, idKlienti, pergjegjes_ri,
								min, idGrupi,vendlindja, shtetesia, this.PerdoruesId);
							if (b == 0)
							{
								System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave per klientin u krye!" + Environment.NewLine + "Kujdes!" + Environment.NewLine +  "Kalimi i klientit nga njeri grup ne tjetrin mund te kerkoje modifikimin e kaparit.", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
								this.RefreshGrupi(sender, e);
								this.Pastro(this.gbKlientetGrupi);
								cmbKlientetGrupi.Kolone1.Items.Clear();
								cmbKlientetGrupi.Kolone2.Items.Clear();
								return;
							}
						}
						else//klienti nuk eshte pergjegjes per grupin ku ndodhet
						{
							b = data.KerkesaUpdate("ModifikoTeDhenaKlientiGrupi", emri, mbiemri, datelindja, adresa, telefoni, email, targa, dtHyrje, dtDalje, idLlojIdentifikimi, nrIdentifikimi, idDhoma, idKlienti, idGrupi,vendlindja, shtetesia);
							if (b == 0)
							{
								System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave per klientin u krye!" + Environment.NewLine + "Kujdes!" + Environment.NewLine +  "Kalimi i klientit nga njeri grup ne tjetrin mund te kerkoje modifikimin e kaparit.", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
								this.RefreshGrupi(sender, e);
								this.Pastro(this.gbKlientetGrupi);
								cmbKlientetGrupi.Kolone1.Items.Clear();
								cmbKlientetGrupi.Kolone2.Items.Clear();
								return;
							}
						}
						break;
					default:
						b = 1;
						break;
				}
				if (b == 0)
				{
					string koment = "Modifikimi i te dhenave per klientin u krye!";
					System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.RefreshGrupi(sender, e);
					this.Pastro(this.gbKlientetGrupi);
					cmbKlientetGrupi.Kolone1.Items.Clear();
					cmbKlientetGrupi.Kolone2.Items.Clear();
				}
				else
				{
					string koment = "Modifikimi i te dhenave per klientin nuk u krye!";
					System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		/// <summary>
		/// Behet eleminimi i klienteve pa perkatesi grupi
		/// sipas rasteve te ndryshem qe mund te shfaqen, kontrollohet edhe regullsia e kaparit
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnEleminoKlient_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i hyrjeve ne hotel", "Jeni te sigurt qe doni ta eleminoni klientin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result != DialogResult.Yes)
				{
					return;
				}
				InputController data = new InputController();
				int b = -1;
				int idKlienti = Convert.ToInt32(this.cmbKlientet.Kolone2Vlere);
				int neHotel = Convert.ToInt32(this.ds_klient.Tables[0].Rows[0]["KLIENT_HOTELI"]);
				if (neHotel == 1)
				{
					System.Windows.Forms.MessageBox.Show(this, "Klienti nuk mund te fshihet pasi eshte ende ne hotel!" + Environment.NewLine + "Kryeni me pare dorezimin e dhomes!","Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				int idIdentifikimi = Convert.ToInt32(this.ds_klient.Tables[0].Rows[0]["ID_IDENTIFIKIMI"]);
				int index = this.gridKlienti.CurrentRowIndex;
				DateTime dt = Convert.ToDateTime(gridKlienti[index, 10]);
				int idDhoma = Convert.ToInt32(gridKlienti[index, 0]);
				DateTime dtHyrje = Convert.ToDateTime(this.dtpHyrjeKlienti.Value);
				DateTime dtDalje = Convert.ToDateTime(this.dtpDaljeKlienti.Value);
				DataSet dsHyrja = data.KerkesaRead("ShfaqVeprimetPerDhomen", idDhoma,-1, dtHyrje, dtDalje);
				int indexkerkuar = this.KerkoDataSet(dsHyrja, dtHyrje, dtDalje);
				//indexkerkuar eshte gjithmone me i madh se 0, eshte te pakten kl qe po eleminohet
				DataRow drk = dsHyrja.Tables["KLIENTI"].Rows[indexkerkuar];
				string strId = drk["ID_KLIENTI_STR"].ToString();
				int k = this.KontrolloPerEleminim(idKlienti, strId);
				int idRezervimi = 0;
				if (! Convert.IsDBNull(ds_klient.Tables[0].Rows[0]["ID_REZERVIMI"]))
					idRezervimi = Convert.ToInt32(ds_klient.Tables[0].Rows[0]["ID_REZERVIMI"]);
				switch(k)
				{

					case 0:
						//rasti kur klienti eshte vetem ne dhome
						//fshirja e klientit shoqerohet me fshirjen e gjithe detyrimeve te tij
						//si edhe me hedhjet ne arke
						if (idRezervimi!= 0)//klienti ka ardhur me rezervim
						{
							DialogResult result1 = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i hyrjeve ne hotel", "Klienti qe doni te eleminoni ka ardhur me rezervim." + Environment.NewLine + "Deshironi te fshini edhe kaparin e rezervimit nga arka?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							if (result1 != DialogResult.Yes)
								b = 1;
							else
								b = data.KerkesaUpdate("FshiKlientNgaRezervimi", idKlienti, idIdentifikimi, idRezervimi);
						}
						else
							b = data.KerkesaUpdate("FshiKlient", idKlienti, idIdentifikimi);
						break;
					case 1:
						//rasti kur klienti ka te tjere ne dhome
						//klienti eshte pergjegjes per kete dhome
						//fshirja e tij duhet te shoqerohet me fshirjen e gjithe detyrimeve te tij
						//me fshirjen  e hedhjeve te tij ne arke persa i perket detyrimeve, si edhe
						//me zevendesimin e hedhjeve te pageses dhe te kaparit per tek nje klient tjeter ne dhome
						DataSet tmp = this.gjejDataSetKlientet(strId);
						DataSet dsData = this.GjejIntervalinPaKlient(tmp, idKlienti);
						DateTime dataMax;
						if (dsData.Tables[0].Rows.Count != 0)//normalisht duhet te jete gjithmone != 0 sepse jemi ne rastin kur jane me shume se nje klient ne dhome
							dataMax = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MAXDATA"]);
						else
							dataMax = dtDalje;
						int pergjegjes = Convert.ToInt32(drk["PERGJEGJES"]);
						if (pergjegjes == idKlienti)
						{
							int pergjegjes_ri = 0;
							int id_tmp = 0;
							DateTime min = DateTime.Now.AddYears(2000);
							foreach(DataRow r in tmp.Tables[0].Rows)
							{
								id_tmp = Convert.ToInt32(r["ID"]);
								if (id_tmp != idKlienti)
								{
									if (Convert.ToDateTime(r["DATA_HYRJE"]) < min)
									{
										pergjegjes_ri = id_tmp;
										min = Convert.ToDateTime(r["DATA_HYRJE"]);
									}
								}
							}
							int kapari = Convert.ToInt32(drk["KAPARI"]);
							int skonto = Convert.ToInt32(drk["SKONTO"]);
							int gjoba = Convert.ToInt32(drk["GJOBA"]);
							b = data.KerkesaUpdate("FshiPergjegjes",idKlienti, idIdentifikimi, pergjegjes_ri, kapari, skonto, gjoba,  min, dataMax);
						}
							//klienti nuk eshte pergjegjes per dhomen
							//fshirja e tij duhet te shoqerohet me fshirjen e detyrimeve dhe te hedhjeve ne arke
						else
						{
							b = data.KerkesaUpdate("FshiKlient", idKlienti, idIdentifikimi);
						}
						break;
					default:
						b = -1;
						break;
				}
				if  (b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Eleminimi i klientit u krye!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.RefreshKlienti(sender, e);
					this.Pastro(this.gbKlientet);
					this.cmbKlientet.Kolone1.Items.Clear();
					this.cmbKlientet.Kolone2.Items.Clear();
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, "Eleminimi i klientit nuk u krye!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		/// <summary>
		/// Behet eleminimi i klienteve me perkatesi grupi
		/// sipas rasteve qe mund te shfaqen, kontrollohet edhe rregullsia e kaparit
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnEleminoKlientGrup_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i hyrjeve ne hotel", "Jeni te sigurt qe doni ta eleminoni klientin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result != DialogResult.Yes)
				{
					return;
				}
				InputController data = new InputController();
				int b = -1;
				int idKlienti = Convert.ToInt32(this.cmbKlientetGrupi.Kolone2Vlere);
				int neHotel = Convert.ToInt32(this.ds_grupi.Tables[0].Rows[0]["KLIENT_HOTELI"]);
				if (neHotel == 1)
				{
					System.Windows.Forms.MessageBox.Show(this, "Klienti nuk mund te fshihet pasi eshte ende ne hotel!" + Environment.NewLine + "Kryeni me pare dorezimin e dhomes!","Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				int idIdentifikimi = Convert.ToInt32(this.ds_grupi.Tables[0].Rows[0]["ID_IDENTIFIKIMI"]);
				int index = this.gridGrupi.CurrentRowIndex;
				DateTime dt = Convert.ToDateTime(gridGrupi[index, 11]);
				int idGrupi = Convert.ToInt32(gridGrupi[index, 15]);
				//DataSet dsKaparPergjegjes = this.gjejKaparPergjegjesGrupi(idGrupi, dt);
				DateTime dtHyrje = Convert.ToDateTime(this.gridGrupi[index, 11]);
				DateTime dtDalje = Convert.ToDateTime(this.gridGrupi[index, 12]);
				DataSet dsHyrje = data.KerkesaRead("ShfaqVeprimetPerGrupin",idGrupi,  -1, dtHyrje, dtDalje);
				int indexkerkuar = this.KerkoDataSet(dsHyrje, dtHyrje, dtDalje);
				// indexkerkuar do te jete gjithmone pozitiv sepse ka te pakten nje klient ne kete ds
				// te pakten klienti qe po eleminohet
				DataRow drk = dsHyrje.Tables["KLIENTI"].Rows[indexkerkuar];
				string strId = drk["ID_KLIENTI_STR"].ToString();
				int pergjegjes = Convert.ToInt32(drk["PERGJEGJES"]);
				int k = this.KontrolloPerEleminim(idKlienti, strId);
				int idRezervimi = 0;
				if (! Convert.IsDBNull(this.ds_grupi.Tables[0].Rows[0]["ID_REZERVIMI"]))
					idRezervimi = Convert.ToInt32(ds_grupi.Tables[0].Rows[0]["ID_REZERVIMI"]);
				switch(k)
				{
					case 0:
						//rasti kur klienti eshte vetem ne grup
						//fshirja e klientit shoqerohet me fshirjen e gjithe detyrimeve te tij
						//si edhe me hedhjet ne arke
						if (idRezervimi != 0)
						{
							DialogResult result1 = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i hyrjeve ne hotel", "Klienti qe doni te eleminoni ka ardhur me rezervim." + Environment.NewLine + "Deshironi te fshini edhe kaparin e rezervimit nga arka?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							if (result1 != DialogResult.Yes)
								b = 1;
							else
								b = data.KerkesaUpdate("FshiKlientGrupiNgaRezervimi", idKlienti, idIdentifikimi, idGrupi, idRezervimi);
						}
						else
							b = data.KerkesaUpdate("FshiKlientGrupi", idKlienti, idIdentifikimi, idGrupi);
						break;
					case 1:
						//rasti kur klienti ka te tjere ne grup
						//klienti eshte pergjegjes per kete grup
						//fshirja e tij duhet te shoqerohet me fshirjen e gjithe detyrimeve te tij
						//me fshirjen  e hedhjeve te tij ne arke persa i perket detyrimeve, si edhe
						//me zevendesimin e hedhjeve te pageses dhe te kaparit per tek nje klient tjeter ne grup
						DataSet tmp = this.gjejDataSetKlientet(strId);
						DataSet dsData = this.GjejIntervalinPaKlient(tmp, idKlienti);
						DateTime dataMax;
						if (dsData.Tables[0].Rows.Count != 0)//normalisht duhet te jete gjithmone != 0 sepse jemi ne rastin kur jane me shume se nje klient ne grup
							dataMax = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MAXDATA"]);
						else
							dataMax = dtDalje;
						if (pergjegjes == idKlienti)
						{
							int pergjegjes_ri = 0;
							int id_tmp = 0;
							DateTime min = DateTime.Now.AddYears(2000);
							foreach(DataRow r in tmp.Tables[0].Rows)
							{
								id_tmp = Convert.ToInt32(r["ID"]);
								if (id_tmp != idKlienti)
								{
									if (Convert.ToDateTime(r["DATA_HYRJE"]) < min)
									{
										pergjegjes_ri = id_tmp;
										min = Convert.ToDateTime(r["DATA_HYRJE"]);
									}
								}
							}
							int kapari = Convert.ToInt32(drk["KAPARI"]);
							int skonto = Convert.ToInt32(drk["SKONTO"]);
							int gjoba = Convert.ToInt32(drk["GJOBA"]);
							b = data.KerkesaUpdate("FshiPergjegjesGrupi", idKlienti, idIdentifikimi,
								pergjegjes_ri, kapari, skonto, gjoba, idGrupi, min, dataMax);
							break;
						}
							//klienti nuk eshte pergjegjes per grup
							//fshirja e tij duhet te shoqerohet me fshirjen e detyrimeve dhe te hedhjeve ne arke
						else
						{
							b = data.KerkesaUpdate("FshiKlientGrupi", idKlienti, idIdentifikimi, idGrupi);
						}
						break;
					default:
						b = -1;
						break;
				}
				if  (b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Eleminimi i klientit u krye!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.RefreshGrupi(sender, e);
					this.Pastro(this.gbKlientetGrupi);
					cmbKlientetGrupi.Kolone1.Items.Clear();
					cmbKlientetGrupi.Kolone2.Items.Clear();
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, "Eleminimi i klientit nuk u krye!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		/// <summary>
		/// Nqs modifikohet dhoma behen paraprakisht disa kontrolle 
		/// 1. per te mos dale jashte intervalit te hyrjeve
		/// 2. per te mos futur ne te njejten dhome kliente me dhe pa perkatesi grupi 
		/// </summary>
		/// <param name="Sender"></param>
		/// <param name="e"></param>
		private void cmbDhomatTeDhena_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				this.numCmimiKlienti.Text = "";
				InputController data = new InputController();
				int idDhoma = Convert.ToInt32(this.cmbDhomatTeDhena.Kolone2Vlere);
				int index = this.gridKlienti.CurrentRowIndex;
				DataSet ds;
				DateTime dtHyrje = Convert.ToDateTime(this.dtpHyrjeKlienti.Value);
				DateTime dtDalje = Convert.ToDateTime(this.dtpDaljeKlienti.Value);
				//Kontroll 1
				if (idDhoma != Convert.ToInt32(this.ds_klient.Tables[0].Rows[0]["ID_DHOMA"]))
				{
					int t = this.TestoData(idDhoma);
					if ((t == 1)||(t == 2))
					{
						cmbDhomatTeDhena.Kolone1.SelectedItem = null;
						return;
					}
				}
				else
				{
					//ndodhen ne te njejten dhome
					DateTime dataMin = Convert.ToDateTime(this.gridKlienti[index, 10].ToString());
					DateTime dataMax = Convert.ToDateTime(this.gridKlienti[index, 11].ToString());
					bool k1 = (dtHyrje >= dataMin) && (dtHyrje < dataMax);
					bool k2 = (dtDalje > dataMin) && (dtDalje <= dataMax);
					bool k3 = (dtHyrje < dataMin) && (dtDalje > dataMax);
					if (k1 || k2 || k3)//klienti ndodhet brenda te njejtes hyrje
					{
						if (dtHyrje < dataMin)
						{
							ds = data.KerkesaRead("NumerKlienteshPerDateDhoma", idDhoma, dtHyrje);
							if (Convert.ToInt32(ds.Tables[0].Rows[0]["NR"]) > 0)
							{
								System.Windows.Forms.MessageBox.Show(this, "Data e hyrjes e caktuar " + this.konverto(dtHyrje) + " nuk eshte e rregullt!" + Environment.NewLine + "Dhoma ka nje hyrje tjeter per kete date.", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
								cmbDhomatTeDhena.Kolone1.SelectedItem = null;
								return;
							}
						}
						if (dtDalje > dataMax)
						{
							ds = data.KerkesaRead("NumerKlienteshPerDateDhoma", idDhoma, dtDalje);
							if (Convert.ToInt32(ds.Tables[0].Rows[0]["NR"]) > 0)
							{
								System.Windows.Forms.MessageBox.Show(this, "Data e daljes e caktuar " + this.konverto(dtDalje) + " nuk eshte e rregullt!" + Environment.NewLine + "Dhoma ka nje hyrje tjeter per kete date.", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
								cmbDhomatTeDhena.Kolone1.SelectedItem = null;
								return;
							}
						}
					}
					else//klienti del plotesisht jashte intervalit te hyrjes
					{
						ds = data.KerkesaRead("ShfaqVeprimetPerDhomen", idDhoma,-1, dtHyrje, dtDalje);
						int indexkerkuar = this.KerkoDataSet(ds, dtHyrje, dtDalje);
						if (indexkerkuar >= 0)
						{
							DataRow drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
							DateTime dataMinPerDhomen = Convert.ToDateTime(drk["MINDATA"]);
							DateTime dataMaxPerDhomen = Convert.ToDateTime(drk["MAXDATA"]);
							string koment = "Dhoma ka nje hyrje ne hotel per intervalin e datave:";
							koment += Environment.NewLine + this.konverto(dataMinPerDhomen) + " dhe " + this.konverto(dataMaxPerDhomen);
							koment += Environment.NewLine + "Nqs doni te shtoni nje klient ne kete dhome duhet ta fusni brenda ketij intervali!";
							if ((dtHyrje < dataMinPerDhomen)||(dtDalje> dataMaxPerDhomen))
							{
								System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK,MessageBoxIcon.Error);
								cmbDhomatTeDhena.Kolone1.SelectedItem = null;
								return;
							}
							//mqs klienti ndryshon hyrje duhet kontrolluar nqs hyrja ku po kalon
							//eshte e dorezuar apo jo.Nqs eshte e dorezuar kalimi nuk mund te kryhet
							string strBool = drk["KLIENT_HOTELI_STR"].ToString();
							if (strBool.Substring(0, 5) == "False")//dhoma eshte dorezuar dhe ne te s'mund te futen kliente te tjere
							{
								koment = "Dhoma ka pasur kliente te tjere per datat e caktuara";
								koment += Environment.NewLine + "te cilet kane dale te gjithe nga hoteli!";
								koment += Environment.NewLine + "Nuk mund te shtoni kliente te tjere per kete hyrje!";
								System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK,MessageBoxIcon.Error);
								cmbDhomatTeDhena.Kolone1.SelectedItem = null;
								return;
							}
						}
					}
				}
				//Kontroll 2
				int NrKlienteNeDhomeNeGrup = Convert.ToInt32(data.KerkesaRead("NrKlienteNeDhomeNeGrup",idDhoma,dtHyrje, dtDalje).Tables[0].Rows[0][0]);
				if (NrKlienteNeDhomeNeGrup > 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Kjo dhome nuk mund te zgjidhet,"
						+ Environment.NewLine + "pasi aktualisht ne te ka kliente te ardhur ne grup!",
						"Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cmbDhomatTeDhena.Kolone1.SelectedItem = null;
					return;
				}
				dtHyrje = Convert.ToDateTime(this.dtpHyrjeKlienti.Value);
				ds = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma , dtHyrje);
				this.numCmimiKlienti.Text = ds.Tables[0].Rows[0][0].ToString();
			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
			}
		}

		/// <summary>
		/// Nqs modifikohet grupi behen paraprakisht disa kontrolle 
		/// 1. per te mos kryer hyrje per grupin nqs tashme ka nje rezervim
		/// 1. per te mos dale jashte intervalit te hyrjeve
		/// 2. per te mos futur ne te njejten dhome kliente pa perkatesi grupi ose qe u perkasin grupeve te tjere
		/// </summary>
		/// <param name="Sender"></param>
		/// <param name="e"></param>
		private void cmbDhomatGrup_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				this.numCmimiGrupi.Text = "";
				InputController data = new InputController();
				int idKlienti = Convert.ToInt32(this.cmbKlientetGrupi.Kolone2Vlere);
				int idGrupi = Convert.ToInt32(this.cmbGrupetTeDhena.Kolone2Vlere);
				int index = this.gridGrupi.CurrentRowIndex;
				DataSet ds;
				DateTime dtHyrje = Convert.ToDateTime(this.dtpHyrjeGrupi.Value);
				DateTime dtDalje = Convert.ToDateTime(this.dtpDaljeGrupi.Value);
				//Kontroll 1
				//kontrollojme nqs ka rezervime per datat e dhena per grupin ne fjale te zgjedhur
				//ne rast se po nuk mund te kryhet nje hyrje per keto data
				DataSet dsRezervime = data.KerkesaRead("RezervimetPerDatatDheGrupin", idGrupi, dtHyrje, dtDalje);
				if (dsRezervime.Tables[0].Rows.Count != 0)
				{
					string s = "Grupi ka nje rezervim ne hotel per intervalin e datave";
					foreach(DataRow rz in dsRezervime.Tables[0].Rows)
					{
						s += Environment.NewLine + this.konverto(Convert.ToDateTime(rz["DATA_FILLIMI"])) + " dhe " + this.konverto(Convert.ToDateTime(rz["DATA_MBARIMI"]));
					}
					s += Environment.NewLine + "Nuk mund te fusni kliente ne emer te ketij grupi per datat e  dhena!";
					System.Windows.Forms.MessageBox.Show(this, s, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.cmbDhomatGrup.Kolone1.SelectedItem = null;
					return;
				}
				//Kontroll 2
				if (idGrupi != Convert.ToInt32(this.ds_grupi.Tables[0].Rows[0]["ID_GRUPI"]))
				{
					int t = this.TestoDataGrupi(idGrupi);
					if ((t == 1)||(t == 2))
					{
						this.cmbDhomatGrup.Kolone1.SelectedItem = null;
						return;
					}
				}
				else
				{
					//ndodhen ne te njejten grup
					DateTime dataMin = Convert.ToDateTime(this.gridGrupi[index, 11].ToString());
					DateTime dataMax = Convert.ToDateTime(this.gridGrupi[index, 12].ToString());
					bool k1 = (dtHyrje >= dataMin) && (dtHyrje < dataMax);
					bool k2 = (dtDalje > dataMin) && (dtDalje <= dataMax);
					bool k3 = (dtHyrje < dataMin) && (dtDalje > dataMax);
					if (k1 || k2 || k3)//klienti ndodhet brenda te njejtes hyrje
					{
						if (dtHyrje < dataMin)
						{
							ds = data.KerkesaRead("NumerKlienteshPerDateGrup", idGrupi, dtHyrje);
							if (Convert.ToInt32(ds.Tables[0].Rows[0]["NR"]) > 0)
							{
								System.Windows.Forms.MessageBox.Show(this, "Data e hyrjes e caktuar " + this.konverto(dtHyrje) + " nuk eshte e rregullt!" + Environment.NewLine + "Grupi ka nje hyrje tjeter per kete date.", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
								this.cmbDhomatGrup.Kolone1.SelectedItem = null;
								return;
							}
						}
						if (dtDalje > dataMax)
						{
							ds = data.KerkesaRead("NumerKlienteshPerDateGrup", idGrupi, dtDalje);
							if (Convert.ToInt32(ds.Tables[0].Rows[0]["NR"]) > 0)
							{
								System.Windows.Forms.MessageBox.Show(this, "Data e daljes e caktuar " + this.konverto(dtDalje) + " nuk eshte e rregullt!" + Environment.NewLine + "Grupi ka nje hyrje tjeter per kete date.", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
								this.cmbDhomatGrup.Kolone1.SelectedItem = null;
								return;
							}
						}
					}
					else//klienti del plotesisht jashte intervalit te hyrjes
					{
						ds = data.KerkesaRead("ShfaqVeprimetPerGrupin", idGrupi,-1, dtHyrje, dtDalje);
						int indexkerkuar = this.KerkoDataSet(ds, dtHyrje, dtDalje);
						if (indexkerkuar >= 0)
						{
							DataRow drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
							DateTime dataMinPerGrupin = Convert.ToDateTime(drk["MINDATA"]);
							DateTime dataMaxPerGrupin = Convert.ToDateTime(drk["MAXDATA"]);
							string koment = "Grupi ka nje hyrje ne hotel per intervalin e datave:";
							koment += Environment.NewLine + this.konverto(dataMinPerGrupin) + " dhe " + this.konverto(dataMaxPerGrupin);
							koment += Environment.NewLine + "Nqs doni te shtoni nje klient ne kete grup duhet ta fusni brenda ketij intervali!";
							if ((dtHyrje < dataMinPerGrupin)||(dtDalje> dataMaxPerGrupin))
							{
								System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK,MessageBoxIcon.Error);
								this.cmbDhomatGrup.Kolone1.SelectedItem = null;
								return;
							}
							string strBool = drk["KLIENT_HOTELI_STR"].ToString();
							if ((this.DorezuarGrupi(strBool) == true))
							{
								koment = "Grupi ka pasur kliente te tjere per datat e caktuara";
								koment += Environment.NewLine + "te cilet kane dale te gjithe nga hoteli!";
								koment += Environment.NewLine + "Nuk mund te shtoni kliente te tjere per kete hyrje!";
								System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK,MessageBoxIcon.Error);
								this.cmbDhomatGrup.Kolone1.SelectedItem = null;
								return;		
							}
						}
					}
				}
				//Kontroll 3 duhet qe ne dhome te mos kete kliente nga grupe te ndryshem
				int idDhoma = Convert.ToInt32(cmbDhomatGrup.Kolone2Vlere);
				int NrKlienteNeDhomeJoTeGrupitTeDhene = Convert.ToInt32(data.KerkesaRead("NrKlienteNeDhomeJoTeGrupitTeDhene",idGrupi,idDhoma, dtHyrje, dtDalje, idKlienti).Tables[0].Rows[0][0]);
				if (NrKlienteNeDhomeJoTeGrupitTeDhene > 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Kjo dhome nuk mund te zgjidhet,"
						+ Environment.NewLine + "pasi aktualisht ne te ka kliente qe" + Environment.NewLine + "nuk i perkasin grupit " + this.cmbGrupetTeDhena.Kolone1.Text + "!",
						"Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.cmbDhomatGrup.Kolone1.SelectedItem = null;
					return;
				}
				dtHyrje = Convert.ToDateTime(this.dtpHyrjeGrupi.Value);
				ds = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma , dtHyrje);
				this.numCmimiGrupi.Text = ds.Tables[0].Rows[0][0].ToString();
			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
			}
		}
		/// <summary>
		/// Modifikohen vlera qe kane te bejne me hyrjen ne pergjithesi
		/// si skonto, kapar, gjobe dhe forma e pageses nga ana e grupit
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnModifikoVeprimGrup_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
//				const string NUMERIC_FORMAT = "^-?[0-9]*(\\,)?[0-9]+$";
				const string NUMERIC_FORMAT = "[0-9]*(\\.)?[0-9]";
				if (this.txtGrupi.Text == "")
				{
					this.error.SetError(this.txtGrupi, "Zgjidhni me pare nje prej hyrjeve ne te majte");
					this.txtGrupi.IsValid = false;
					return;
				}
				if (!Regex.IsMatch(this.numKapariGrupi.Text, NUMERIC_FORMAT))
				{
					this.error.SetError(this.numKapariGrupi, "Kapari duhet te jete vlere numerike!");
					this.numKapariGrupi.IsValid = false;
					return;
				}
				if (Convert.ToInt32(this.numKapariGrupi.Text) < 0)
				{
					this.error.SetError(this.numKapariGrupi, "Kapari nuk mund te jete negativ!");
					this.numKapariGrupi.IsValid = false;
					return;
				}

				if (!Regex.IsMatch(this.numSkontoGrupi.Text, NUMERIC_FORMAT))
				{
					this.error.SetError(this.numSkontoGrupi, "Skontoja duhet te jete vlere numerike!");
					this.numSkontoGrupi.IsValid = false;
					return;
				}
				if (Convert.ToInt32(this.numSkontoGrupi.Text) < 0)
				{
					this.error.SetError(this.numSkontoGrupi, "Skontoja nuk mund te jete negative!");
					this.numSkontoGrupi.IsValid = false;
					return;
				}

				if (!Regex.IsMatch(this.numGjobaGrupi.Text, NUMERIC_FORMAT))
				{
					this.error.SetError(this.numGjobaGrupi, "Gjoba duhet te jete vlere numerike!");
					this.numGjobaGrupi.IsValid = false;
					return;
				}
				if (Convert.ToInt32(this.numGjobaGrupi.Text) < 0)
				{
					this.error.SetError(this.numGjobaGrupi, "Gjoba nuk mund te jete negative!");
					this.numGjobaGrupi.IsValid = false;
					return;
				}
				if ((this.cmbPagesaGrupi.Enabled == true)&&(this.cmbPagesaGrupi.Kolone1.SelectedItem == null))
				{
					this.error.SetError(this.cmbPagesaKlienti, "Zgjidhni formen e pageses!");
					return;
				}
				int index = this.gridGrupi.CurrentRowIndex;
				int idRezervimi = 0;
				string strIdRez = this.gridGrupi[index, 16].ToString();
				if (!strIdRez.StartsWith("\r\n")&&(strIdRez != ""))//do te thote qe te pakten nje prej klienteve ka ardhur me rezervim
				{
					//idRezervimi = 100;
					int length = strIdRez.Length;
					string id = "";
					for(int i = 0; i < strIdRez.Length; i++)
					{
						string s = strIdRez.Substring(i, 1);
						if (s == "\r")
							break;
						else
							id += s;
					}
					idRezervimi = Convert.ToInt32(id);
				}
				int idFormaPagesa = Convert.ToInt32(this.cmbPagesaGrupi.Kolone2Vlere);
				string strId = gridGrupi[index, 6].ToString();
				DataSet kliente = this.gjejDataSetKlientet(strId);
				int kapariVjeter = Convert.ToInt32(this.gridGrupi[index, 2]);
				int skontoVjeter = Convert.ToInt32(this.gridGrupi[index, 3]);
				int gjobaVjeter = Convert.ToInt32(this.gridGrupi[index, 4]);
				this.pagesa = this.PagesaGrupi(kliente, kapariVjeter, skontoVjeter, gjobaVjeter);
				int kapari = Convert.ToInt32(this.numKapariGrupi.Text);
				int vleraVjeter = Convert.ToInt32(this.pagesa.Tables[0].Rows[pagesa.Tables[0].Rows.Count - 1][pagesa.Tables[0].Columns.Count - 1]);
				if (idRezervimi!= 0)
					vleraVjeter += this.PagesaRezervimiGrupi(idRezervimi);
				DateTime dtMbarimi = Convert.ToDateTime(this.gridGrupi[index, 12]);
				if (kapari > vleraVjeter + kapariVjeter + skontoVjeter - gjobaVjeter  )
				{
					this.error.SetError(this.numKapariGrupi, "Kapari  nuk mund te jete me i madh" + Environment.NewLine +  "se vlera qe ka grupi per te paguar!");
					this.numKapariGrupi.IsValid = false;
					return;
				}
				int pergjegjes = Convert.ToInt32(this.gridGrupi[index, 10]);
				int skonto = Convert.ToInt32(this.numSkontoGrupi.Text);
				int gjoba = Convert.ToInt32(this.numGjobaGrupi.Text);
				int vlera = vleraVjeter + kapariVjeter + skontoVjeter - gjobaVjeter - kapari - skonto + gjoba;
				
				string strBool = gridGrupi[index, 13].ToString();
				bool dorezuar = false;
				if (this.DorezuarGrupi(strBool) == true)
					dorezuar = true;
				else
					dorezuar = false;
				InputController data = new InputController();
				int b = 0;
				if (idRezervimi == 0)//klientet nuk kane ardhur me rezervim
				{
					b = data.KerkesaUpdate("ModifikoSkontoKaparGjobe", kapari, skonto,
						gjoba, pergjegjes, vlera, idFormaPagesa, dtMbarimi, dorezuar, this.PerdoruesId);
				}
				else//klientet kane ardhur me rezervim
				{
					DataSet dsRezArka = data.KerkesaRead("ShfaqKaparRezervimiArka", idRezervimi);
					if (dsRezArka.Tables[0].Rows.Count == 0)
						//kapari i rezervimit ka qene 0 dhe si i tille nuk eshte hedhur ne arke
						//modifikimi duhet te jete njesoj sikur klientet te mos kishin ardhur me rezervim
						b = data.KerkesaUpdate("ModifikoSkontoKaparGjobe", kapari, skonto,
							gjoba, pergjegjes, vlera, idFormaPagesa, dtMbarimi, dorezuar, this.PerdoruesId);
					else
					{
						int kapariRezervimi = Convert.ToInt32(dsRezArka.Tables[0].Rows[0]["ARKA_SASIA"]);
						int kapariArka = kapari - kapariRezervimi;
						if (kapariArka < 0)
						{
							System.Windows.Forms.MessageBox.Show(this, "Një modifikim i tille i kaparit nuk mund të bëhet!" + Environment.NewLine + "Klientët që i përkasin kësaj hyrje janë futur me anë të rezervimit" +
								Environment.NewLine + "dhe nje pjesë e kaparit të grupit i përket kaparit të rezervimit." + Environment.NewLine + "Vlera që ju keni dhënë për kaparin është më e vogël se kapari i rezervimit."
								,"Modifikimi i hyrjeve në hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						b = data.KerkesaUpdate("ModifikoSkontoKaparGjobePerHyrjetMeRezervim", kapariArka, skonto,
							gjoba, pergjegjes, vlera, idFormaPagesa, dtMbarimi, dorezuar, kapari,this.PerdoruesId);
					}				
				}
				if (b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Modifikimi i te dhenave per hyrjen u krye!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.RefreshGrupi(sender, e);
					this.Pastro(this.gbGrupi);
					this.cmbKlientetGrupi.Kolone1.Items.Clear();
					this.cmbKlientetGrupi.Kolone2.Items.Clear();
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, "Modifikimi nuk u krye!", "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		/// <summary>
		/// Per shfaqjen e kontrolleve te duhur nqs po kerkohet per
		/// hyrje te vlefshme ose jo
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbVlefshmeKlienti_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				cmbKlientet.Kolone1.Items.Clear();
				cmbKlientet.Kolone2.Items.Clear();
				this.Pastro(this.gbDhoma);
				this.Pastro(this.gbKlientet);
				this.Pastro(this.groupBox1);
				if (this.cbVlefshmeKlienti.Checked == true)
				{
					this.lblDataKlienti.Visible = false;
					this.cbDhoma.Visible = false;
					this.cbKlienti.Visible = false;
					this.cbDhoma.Checked = false;
					this.cbKlienti.Checked = false;
					this.rbDatat.Visible = true;
					this.rbKlienti.Visible = true;
					this.rbDhoma.Visible = true;
					InputController data = new InputController();
					DataSet ds = data.KerkesaRead("ShfaqKlientHotel");
					if (ds.Tables.Count == 2)
						this.gridKlienti.DataSource = ds.Tables["KLIENTI"];
					this.KrijoStilgride();
					this.gbHyrjet.Text = "Hyrjet individuale te vlefshme ne hotel";
					this.MoveDown();
				}
				else
				{
					this.lblDataKlienti.Visible = true;
					this.cbDhoma.Visible = true;
					this.cbKlienti.Visible = true;
					this.rbDatat.Checked = false;
					this.rbKlienti.Checked = false;
					this.rbDhoma.Checked = false;
					this.rbDatat.Visible = false;
					this.rbKlienti.Visible = false;
					this.rbDhoma.Visible = false;
					this.lblDataKlienti.Location = new Point(30, 46);
					this.cbKlienti.Location = new Point(18, 74);
					this.cbDhoma.Location = new Point(18, 102);
					this.gridKlienti.DataSource = null;
					this.gbHyrjet.Text = "Hyrjet individuale jo te vlefshme ne hotel";
					this.MoveUp();
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
			}
		}

		/// <summary>
		/// Per shfaqjen e kontrolleve te duhur nqs po kerkohet per
		/// hyrje te vlefshme ose jo
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbVlefshmeGrupi_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				cmbKlientetGrupi.Kolone1.Items.Clear();
				cmbKlientetGrupi.Kolone2.Items.Clear();
				this.Pastro(this.gbGrupi);
				this.Pastro(this.gbKlientetGrupi);
				this.Pastro(this.groupBox2);
				if (this.cbVlefshmeGrupi.Checked == true)
				{

					this.lblDataGrupi.Visible = false;
					this.cbDhomaGrupi.Visible = false;
					this.cbGrupi.Visible = false;
					this.cbDhomaGrupi.Checked = false;
					this.cbGrupi.Checked = false;
					this.rbDataGrupi.Visible = true;
					this.rbGrupi.Visible = true;
					this.rbDhomaGrupi.Visible = true;
					InputController data = new InputController();
					DataSet ds = data.KerkesaRead("ShfaqKlientGrupNeHotelPerModifikim", -1);
					if (ds.Tables.Count == 2)
						this.gridGrupi.DataSource = ds.Tables["KLIENTI"];
					this.gbGrup.Text = "Hyrjet ne grup te vlefshme ne hotel";
					this.KrijoStilgride2();
					this.MoveDown1();
				}
				else
				{
					this.lblDataGrupi.Visible = true;
					this.cbDhomaGrupi.Visible = true;
					this.cbGrupi.Visible = true;
					this.rbDataGrupi.Checked = false;
					this.rbGrupi.Checked = false;
					this.rbDhomaGrupi.Checked = false;
					this.rbDataGrupi.Visible = false;
					this.rbGrupi.Visible = false;
					this.rbDhomaGrupi.Visible = false;
					this.lblDataGrupi.Location = new Point(30, 46);
					this.cbGrupi.Location = new Point(18, 74);
					this.cbDhomaGrupi.Location = new Point(18, 102);
					this.gridGrupi.DataSource = null;
					this.MoveUp1();
					this.gbGrup.Text = "Hyrjet ne grup jo te vlefshme ne hotel";
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
			}
		}	

		#endregion

		#region Private Methods
		/// <summary>
		/// sherben per te kontrolluar nqs gjate modifikimit te datave 
		/// mbetet ndonje detyrim i hedhur jashte datave te modifikuara
		/// </summary>
		/// <param name="idKlienti"></param>
		/// <param name="dtHyrje"></param>
		/// <param name="dtDalje"></param>
		/// <returns></returns>
		private int KontrolloPerDetyrime(int idKlienti, DateTime dtHyrje, DateTime dtDalje)
		{
			InputController data = new InputController();
			DataSet dsDet = data.KerkesaRead("NrDetyrimeshPerKlientJashteDatave", idKlienti, dtHyrje, dtDalje);
			int nr = Convert.ToInt32(dsDet.Tables[0].Rows[0]["NR"]);
			if (nr > 0)
				return 1;
			else
				return 0;
		}
		/// <summary>
		/// Per mbushjen e kombove qe permbajne mjejtet e identifikimt
		/// </summary>
		private void mbushMjeteIdentifikimi()
		{
			this.cmbMjeteId.Kolone1.Text = "";
			this.cmbMjeteIdentifikimi.Kolone1.Text = "";
			this.cmbMjeteId.Kolone1.Items.Clear();
			this.cmbMjeteId.Kolone2.Items.Clear();
			this.cmbMjeteIdentifikimi.Kolone1.Items.Clear();
			this.cmbMjeteIdentifikimi.Kolone2.Items.Clear();
			DataSet ds = null ;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqMjeteIdentifikimi");
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbMjeteId.Kolone1.Items.Add(dr[1]);
				this.cmbMjeteId.Kolone2.Items.Add(dr[0]);
				this.cmbMjeteIdentifikimi.Kolone1.Items.Add(dr[1]);
				this.cmbMjeteIdentifikimi.Kolone2.Items.Add(dr[0]);
			}
		}

		/// <summary>
		/// Per datasetin e dhene kerkon ne tabelen e tij kliente 
		/// ate hyrje qe perfshihet ne datat e dhena dhe kthen
		/// indeksin per kete hyrje
		/// </summary>
		/// <param name="ds"></param>
		/// <param name="dtHyrje"></param>
		/// <param name="dtDalje"></param>
		/// <returns></returns>
		private int KerkoDataSet(DataSet ds, DateTime dtHyrje, DateTime dtDalje)
		{
			bool ugjetKlientPerDhome = false;
			int indexkerkuar = -1;
			int k = 0;
			if (ds.Tables.Count == 2)
			{
				foreach(DataRow drk in ds.Tables["KLIENTI"].Rows)
				{
					if ((dtHyrje >= Convert.ToDateTime(drk["MINDATA"]))&&(dtHyrje < Convert.ToDateTime(drk["MAXDATA"])))
					{
						indexkerkuar = k;
						ugjetKlientPerDhome = true;
						break;
					}
					else if ((dtDalje > Convert.ToDateTime(drk["MINDATA"]))&&(dtDalje <= Convert.ToDateTime(drk["MAXDATA"])))
					{
						indexkerkuar = k;
						ugjetKlientPerDhome = true;
						break;
					}
					else if ((dtHyrje < Convert.ToDateTime(drk["MINDATA"]))&&(dtDalje > Convert.ToDateTime(drk["MAXDATA"])))
					{
						indexkerkuar = k;
						ugjetKlientPerDhome = true;
						break;
					}
					k++;
				}
			}
			return indexkerkuar;				
		}
		/// <summary>
		/// Afishon mesazhin perkates sipas rasteve
		/// te kontrollit nqs ka gabime ne kapar
		/// </summary>
		/// <param name="r"></param>
		/// <returns></returns>
		private int AfishoGabimKaparKlienti(int r)
		{
			string s;
			string emriDhoma = Convert.ToString(this.gridKlienti[this.gridKlienti.CurrentRowIndex, 1]);
			switch(r)
			{
				case 0:
					s = "";
					break;
				case 1:
					//e njejta dhome por zvogelohet intervali 
					//gje qe con ne parregullsi te kaparit
					s = "Modifikimi i te dhenave per klientin nuk u krye!";
					s += Environment.NewLine + "Per datat e caktuara vlera e hedhur e kaparit";
					s += Environment.NewLine + "rezulton me e madhe se pagesa qe duhet te kryehet!";
					break;
				case 2:
					s = "Modifikimi i te dhenave per klientin nuk u krye!";
					s += Environment.NewLine + "Pas largimit te klientit nga dhoma " + emriDhoma;
					s += Environment.NewLine + "Kapari i hedhur per kete dhome rezulton me i madh se pagesa.";
					break;
				case 3:
					s = "Pas kalimit te klientit ne dhomen " + Convert.ToString(this.cmbDhomatTeDhena.Kolone1.Text);
					s += Environment.NewLine + "kapari rezulton me i madh se pagesa qe duhet te kryhet per dhomen.";
					break;
				case 4:
					s = "Modifikimi i te dhenave per klientin nuk u krye!";
					s += Environment.NewLine + "Pas ndryshimit te datave per klientin";
					s += Environment.NewLine + "kapari i hedhur per dhomen " + emriDhoma;
					s += Environment.NewLine + "rezulton me i madh se pagesa qe duhet te kryhet!";
					break;
				case 5:
					s = "Modifikimi i te dhenave per klientin nuk u krye!";
					s += Environment.NewLine + "Pas kalimit te klientit te datat e reja ";
					s += Environment.NewLine + "kapari rezulton me i madh se pagesa per dhomen!";
					break;
				default :
					s = "";
					break;
			}
			if (s != "")
			{
				System.Windows.Forms.MessageBox.Show(this, s, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 1;
			}
			else
				return 0;
		}
		/// <summary>
		/// Afishon mesazhin perkates sipas rasteve
		/// te kontrollit nqs ka gabime ne kapar
		/// </summary>
		/// <param name="r"></param>
		/// <returns></returns>
		private int AfishoGabimKaparGrupi(int r)
		{
			string s;
			string emriGrupi = Convert.ToString(this.gridGrupi[this.gridGrupi.CurrentRowIndex, 0]);
			switch(r)
			{
				case 0:
					s = "";
					break;
				case 1:
					//i njejti grup por zvogelohet intervali 
					//gje qe con ne parregullsi te kaparit
					s = "Modifikimi i te dhenave per klientin nuk u krye!";
					s += Environment.NewLine + "Per datat e caktuara vlera e hedhur e kaparit";
					s += Environment.NewLine + "rezulton me e madhe se pagesa qe duhet te kryhet!";
					break;
				case 2:
					s = "Modifikimi i te dhenave per klientin nuk u krye!";
					s += Environment.NewLine + "Pas largimit te klientit nga grupi " + emriGrupi;
					s += Environment.NewLine + "Kapari i hedhur nga ana e grupi rezulton me i madh";
					s += Environment.NewLine + " se pagesa qe duhet te kryhet per dhomat e marra ne dorezim.";
					break;
				case 3:
					s = "Pas kalimit te klientit ne grupin " + Convert.ToString(this.cmbGrupetTeDhena.Kolone1.Text);
					s += Environment.NewLine + "kapari rezulton me i madh se pagesa qe duhet te kryhet per dhomat.";
					break;
				case 4:
					s = "Modifikimi i te dhenave per klientin nuk u krye!";
					s += Environment.NewLine + "Pas ndryshimit te datave per klientin";
					s += Environment.NewLine + "kapari i hedhur per grupin " + emriGrupi;
					s += Environment.NewLine + "rezulton me i madh se pagesa qe duhet te kryhet!";
					break;
				case 5:
					s = "Modifikimi i te dhenave per klientin nuk u krye!";
					s += Environment.NewLine + "Pas kalimit te klientit te datat e reja ";
					s += Environment.NewLine + "kapari rezulton me i madh se pagesa per dhomat!";
					break;
				default :
					s = "";
					break;
			}
			if (s != "")
			{
				System.Windows.Forms.MessageBox.Show(this, s, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 1;
			}
			else
				return 0;
		}
		/// <summary>
		/// Gjen pagesen qe duhet te kryhet per dhomen me kategorine e dhene, cmimin dhe intervalin e datave
		/// </summary>
		/// <param name="idKategoria"></param>
		/// <param name="cmimi"></param>
		/// <param name="dtFillimi"></param>
		/// <param name="dtMbarimi"></param>
		/// <returns></returns>
		private int GjejPagesen(int idKategoria, int cmimi, DateTime dtFillimi, DateTime dtMbarimi)
		{
			TimeSpan ts;
			int pagesa;
			if (idKategoria == 31)
			{
				ts = dtMbarimi.Subtract(dtFillimi);
				double ore = ts.TotalHours;
				pagesa = Convert.ToInt32(Math.Round(cmimi * ore, 2));
			}
			else
			{
				ts = dtMbarimi.Date.Subtract(dtFillimi.Date);
				int dite = ts.Days;
				pagesa = dite * cmimi;
			}
			return pagesa;
		}


		/// <summary>
		/// Ne rastin e modifikimt te te dhenave per klientet
		/// kontrollon nqs eshte ndryshuar dhoma
		/// Nqs po kontrollon a ka hyrje per datat e caktuar ne kete dhome
		/// Nqs po kontrollohet qe datat qe do t'i caktohen klientit te 
		/// jene brenda ketij intervali
		/// Kthen 1 ne rast gabimi dhe 0 ne te kundert
		/// </summary>
		/// <param name="idDhoma"></param>
		/// <returns>int</returns>
		private int TestoData(int idDhoma)
		{
			InputController data = new InputController();
			DataRow r = this.ds_klient.Tables[0].Rows[0];
			DateTime dtHyrje = Convert.ToDateTime(this.dtpHyrjeKlienti.Value);
			DateTime dtDalje = Convert.ToDateTime(this.dtpDaljeKlienti.Value);
			idDhoma = Convert.ToInt32(this.cmbDhomatTeDhena.Kolone2Vlere);
			DataSet ds = data.KerkesaRead("ShfaqVeprimetPerDhomen", idDhoma,-1, dtHyrje, dtDalje);
			int indexkerkuar = this.KerkoDataSet(ds, dtHyrje, dtDalje);
			if (indexkerkuar == -1)
				return 0;
			else
			{
				DataRow drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
				DateTime dataMinPerDhomen = Convert.ToDateTime(drk["MINDATA"]);
				DateTime dataMaxPerDhomen = Convert.ToDateTime(drk["MAXDATA"]);
				string koment = "Dhoma ka nje hyrje ne hotel per intervalin e datave:";
				koment += Environment.NewLine + this.konverto(dataMinPerDhomen) + " dhe " + this.konverto(dataMaxPerDhomen);
				koment += Environment.NewLine + "Nqs doni te shtoni nje klient ne kete dhome duhet ta fusni brenda ketij intervali!";
				if ((dtHyrje < dataMinPerDhomen)||(dtDalje > dataMaxPerDhomen))
				{
					System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK,MessageBoxIcon.Error);
					return 1;
				}
				else
				{
					string strBool = drk["KLIENT_HOTELI_STR"].ToString();
					if (strBool.Substring(0, 5) == "False")//dhoma eshte dorezuar dhe ne te s'mund te futen kliente te tjere
					{
						koment = "Dhoma ka pasur kliente te tjere per datat e caktuara";
						koment += Environment.NewLine + "te cilet kane dale te gjithe nga hoteli!";
						koment += Environment.NewLine + "Nuk mund te shtoni kliente te tjere per kete hyrje!";
						System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK,MessageBoxIcon.Error);
						return 2;
					}
					else
						return 0;
				}
			}
		}

		/// <summary>
		/// Ne rastin e modifikimt te te dhenave per klientet
		/// kontrollon nqs eshte ndryshuar grupi
		/// Nqs po kontrollon a ka hyrje per datat e caktuar ne kete grup
		/// Nqs po kontrollohet qe datat qe do t'i caktohen klientit te 
		/// jene brenda ketij intervali
		/// Kthen 1 ne rast gabimi dhe 0 ne te kundert
		/// </summary>
		/// <param name="idGrupi"></param>
		/// <returns>int</returns>
		private int TestoDataGrupi(int idGrupi)
		{
			InputController data = new InputController();
			DataRow r = this.ds_grupi.Tables[0].Rows[0];
			DateTime dtHyrje = Convert.ToDateTime(this.dtpHyrjeGrupi.Value);
			DateTime dtDalje = Convert.ToDateTime(this.dtpDaljeGrupi.Value);
			idGrupi = Convert.ToInt32(this.cmbGrupetTeDhena.Kolone2Vlere);
			DataSet ds = data.KerkesaRead("ShfaqVeprimetPerGrupin", idGrupi,-1, dtHyrje, dtDalje);
			int indexkerkuar = this.KerkoDataSet(ds, dtHyrje, dtDalje);
			if (indexkerkuar == -1)
				return 0;
			else
			{
				DataRow drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
				DateTime dataMinPerGrupin = Convert.ToDateTime(drk["MINDATA"]);
				DateTime dataMaxPerGrupin = Convert.ToDateTime(drk["MAXDATA"]);
				string koment = "Grupi ka nje hyrje ne hotel per intervalin e datave:";
				koment += Environment.NewLine + this.konverto(dataMinPerGrupin) + " dhe " + this.konverto(dataMaxPerGrupin);
				koment += Environment.NewLine + "Nqs doni te shtoni nje klient ne kete grup duhet ta fusni brenda ketij intervali!";
				if ((dtHyrje < dataMinPerGrupin)||(dtDalje > dataMaxPerGrupin))
				{
					System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK,MessageBoxIcon.Error);
					return 1;
				}
				else 
				{
					string strBool = drk["KLIENT_HOTELI_STR"].ToString();
					if ((this.DorezuarGrupi(strBool) == true))
					{
						koment = "Grupi ka pasur kliente te tjere per datat e caktuara";
						koment += Environment.NewLine + "te cilet kane dale te gjithe nga hoteli!";
						koment += Environment.NewLine + "Nuk mund te shtoni kliente te tjere per kete hyrje!";
						System.Windows.Forms.MessageBox.Show(this, koment, "Modifikimi i hyrjeve ne hotel", MessageBoxButtons.OK,MessageBoxIcon.Error);
						return 2;		
					}
					else
						return 0;
				}
			}
		}
		/// <summary>
		/// Per stringun i cili perbehet nga bashkimi i 
		/// fushave KLIENT_HOTEL te te gjithe klienteve te grupit percaktohet nqs
		/// grupi eshte dorezuar ose jo
		/// Nqs te pakten nje klient i grupit nuk eshte larguar 
		/// grupi nuk eshte dorezuar
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		private bool DorezuarGrupi(string str)
		{
			bool b = true;
			for (int i = 0; i < str.Length; i++)
			{
				string c = str.Substring(i, 1);
				if (c == "T")
				{
					b = false;
					break;
				}
			}
			return b;
		}
		/// <summary>
		/// per dy data dhe kategorine e dhene parcaktohet 
		/// nqs intervali i dhene eshte i rregullt
		/// per dhomat ditore intervali duhet te ndryshoje me te pakten nje dite
		/// </summary>
		/// <param name="idKategoria"></param>
		/// <param name="dtFillimi"></param>
		/// <param name="dtMbarimi"></param>
		/// <returns></returns>
		private int KontrolloDatat(int idKategoria, DateTime dtFillimi, DateTime dtMbarimi)
		{
			if (dtFillimi.Date > dtMbarimi.Date)
				return -1;
			if ((dtFillimi.Date == dtMbarimi.Date)&&(idKategoria == 31))
			{
				if (dtFillimi.TimeOfDay >= dtMbarimi.TimeOfDay)
					return -1;
				if (dtFillimi.TimeOfDay < dtMbarimi.TimeOfDay)
					return 0;
				else
					return 0;
			}
			else if ((dtFillimi.Date == dtMbarimi.Date)&&(idKategoria != 31))
				return -1;
			else
				return 0;
		}

		/// <summary>
		/// Percakton rastet e mundshme qe mund te shfaqen gjate modifikimit 
		/// te te dhenave per klientet si edhe kontrollon rregullsine e kaparit per keta raste
		/// </summary>
		/// <returns></returns>
		private DataSet KontrolloKlient()
		{
			int a = 0;
			int b = 0;
			InputController data = new InputController();
			DataSet dsCmimi, tmp, dsData, ds;
			int indexkerkuar, pagesa, kapari,cmimi;
			DataRow drk;
			DateTime dataMinPerDhomen,dataMaxPerDhomen;
			int index = this.gridKlienti.CurrentRowIndex;
			int idKlienti = Convert.ToInt32(this.cmbKlientet.Kolone2Vlere);
			DateTime dtHyrje = Convert.ToDateTime(this.dtpHyrjeKlienti.Value);
			DateTime dtDalje = Convert.ToDateTime(this.dtpDaljeKlienti.Value); 
			int idDhoma = Convert.ToInt32(this.cmbDhomatTeDhena.Kolone2Vlere);
			int idKategoria = Convert.ToInt32(cmbKategoria.Kolone2Vlere);
			int idDhomaVjeter = Convert.ToInt32(this.gridKlienti[this.gridKlienti.CurrentRowIndex, 0].ToString());
			bool merrKapar = false;
			if (idDhoma == idDhomaVjeter)
			{
				dataMinPerDhomen = Convert.ToDateTime(gridKlienti[index, 10].ToString());
				dataMaxPerDhomen = Convert.ToDateTime(gridKlienti[index, 11].ToString());
				bool k1 = (dtHyrje >= dataMinPerDhomen) && (dtHyrje < dataMaxPerDhomen);
				bool k2 = (dtDalje > dataMinPerDhomen) && (dtDalje <= dataMaxPerDhomen);
				bool k3 = (dtHyrje < dataMinPerDhomen) && (dtDalje > dataMaxPerDhomen);
				if (k1 || k2 || k3)//klienti ndodhet brenda te njejtes hyrje
				{
					ds = data.KerkesaRead("ShfaqVeprimetPerDhomen", idDhoma,-1, dtHyrje, dtDalje);
					indexkerkuar = this.KerkoDataSet(ds, dtHyrje, dtDalje);
					//indexkerkuar eshte gjithmone >= 0 sepese do te kete te pakten nje klient
					//te pakten klienti qe po modifikohet
					drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
					string strId = drk["ID_KLIENTI_STR"].ToString();
					tmp = this.gjejDataSetKlientet(strId);
					dsData = this.GjejIntervalinPaKlient(tmp, idKlienti);
					if (dsData.Tables[0].Rows.Count != 0)
					{
						dataMinPerDhomen = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MINDATA"]);
						dataMaxPerDhomen = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MAXDATA"]);
					}
					else//dhoma ka pasur vetem nje klient
					{
						dataMinPerDhomen = dtHyrje;
						dataMaxPerDhomen = dtDalje;
					}
					kapari = Convert.ToInt32(drk["KAPARI"]);
					if (dtHyrje < dataMinPerDhomen)
						dataMinPerDhomen = dtHyrje;
					if (dtDalje > dataMaxPerDhomen)
						dataMaxPerDhomen = dtDalje;
					dsCmimi = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma , dataMinPerDhomen);
					cmimi = Convert.ToInt32(dsCmimi.Tables[0].Rows[0][0]);
					pagesa = this.GjejPagesen(idKategoria, cmimi, dataMinPerDhomen, dataMaxPerDhomen);
					if (kapari > pagesa)
					{
						a =  1;
						b = 0;
					}
					else
					{
						a =  0;
						b = 1;
					}
				}
				else//klienti ndryshon hyrje
				{
					//kontrollojme hyrjen e vjeter
					ds = data.KerkesaRead("ShfaqVeprimetPerDhomen", idDhoma,-1, dataMinPerDhomen, dataMaxPerDhomen);
					indexkerkuar = this.KerkoDataSet(ds,dataMinPerDhomen, dataMaxPerDhomen);
					//ky eshte gjithmone jonegativ sepse hyrja ka te pakten nje klient
					//te pakten klienti qe po modifikohet
					drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
					kapari = Convert.ToInt32(drk["KAPARI"]);
					string strId = drk["ID_KLIENTI_STR"].ToString();
					tmp = this.gjejDataSetKlientet(strId);
					dsData = this.GjejIntervalinPaKlient(tmp, idKlienti);
					if (dsData.Tables[0].Rows.Count == 0)//nuk mbetet me asnje klient ne dhome
						merrKapar = true;
					else//mbeten kliente te tjere ne dhome
					{
						dataMinPerDhomen = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MINDATA"]);
						dataMaxPerDhomen = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MAXDATA"]);
						dsCmimi = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma , dataMinPerDhomen);
						cmimi = Convert.ToInt32(dsCmimi.Tables[0].Rows[0][0]);
						pagesa = this.GjejPagesen(idKategoria, cmimi, dataMinPerDhomen, dataMaxPerDhomen);
						if (kapari > pagesa)
						{
							a =  4;
							b = 0;
						}
					}
					//kontrollojme hyrjen e re
					if (a == 0)
					{
						ds = data.KerkesaRead("ShfaqVeprimetPerDhomen", idDhoma,-1, dtHyrje, dtDalje);
						indexkerkuar = this.KerkoDataSet(ds, dtHyrje, dtDalje);
						if (indexkerkuar < 0)//dhoma s'ka kliente per datat e kerkuara
						{
							if (merrKapar)//klienti kalon me gjithe kapar
							{
								dsCmimi = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma , dtHyrje);
								cmimi = Convert.ToInt32(dsCmimi.Tables[0].Rows[0][0]);
								pagesa = this.GjejPagesen(idKategoria, cmimi, dtHyrje, dtDalje);
								if (kapari > pagesa)
								{
									a =  5;
									b = 0;
								}
								else
								{
									a =  0;
									b = 2;
								}
							}
							else
							{
								a =  0;
								b = 3;
							}
						}
						else//dhoma ka kliente per datat e kerkuara
						{
							//kapari eshte dhene nje here per kete hyrje 
							//si edhe jane caktuar datat e intervalit
							//per rrjedhoje kapari mbetet i rregullt
							if (merrKapar)//klienti ka qene vetem
							{
								a =  0;
								b = 4;
							}
							else
							{
								a =  0;
								b = 5;
							}
						}
					}
				}
			}
			else
			{
				merrKapar = false;
				//per te kontrolluar dhomen e vjeter
				int idKategoriaVjeter = Convert.ToInt32(data.KerkesaRead("NxirrDhome", idDhomaVjeter).Tables[0].Rows[0]["ID_KATEGORIA"]);
				dataMinPerDhomen = Convert.ToDateTime(gridKlienti[index, 10].ToString());
				dataMaxPerDhomen = Convert.ToDateTime(gridKlienti[index, 11].ToString());
				ds = data.KerkesaRead("ShfaqVeprimetPerDhomen", idDhomaVjeter,-1, dataMinPerDhomen, dataMaxPerDhomen);
				//ds nuk mund te jete bosh sepse dhoma ka patur per keto data te pakten nje klient
				//qe eshte klienti qe po modifikohet
				indexkerkuar = this.KerkoDataSet(ds,dataMinPerDhomen, dataMaxPerDhomen);
				drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
				kapari = Convert.ToInt32(drk["KAPARI"]);
				string strId = drk["ID_KLIENTI_STR"].ToString();
				tmp = this.gjejDataSetKlientet(strId);
				dsData = this.GjejIntervalinPaKlient(tmp, idKlienti);
				if (dsData.Tables[0].Rows.Count == 0)//nuk mbetet me           klient ne dhome
					merrKapar = true;
				else
				{
					dataMinPerDhomen = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MINDATA"]);
					dataMaxPerDhomen = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MAXDATA"]);
					dsCmimi = data.KerkesaRead("CmimiDhomesPerDaten", idDhomaVjeter , dataMinPerDhomen);
					cmimi = Convert.ToInt32(dsCmimi.Tables[0].Rows[0][0]);
					pagesa = this.GjejPagesen(idKategoriaVjeter, cmimi,dataMinPerDhomen,dataMaxPerDhomen);
					if (kapari > pagesa)
					{
						a =  2;
						b = 0;
					}
				}
				//per te kontrolluar dhomen e re
				if (a == 0)
				{
					ds = data.KerkesaRead("ShfaqVeprimetPerDhomen", idDhoma,-1, dtHyrje, dtDalje);
					indexkerkuar = this.KerkoDataSet(ds, dtHyrje, dtDalje);
					if (indexkerkuar < 0)//dhoma e re nuk ka kliente per keto data
					{
						if (merrKapar)//kalon me gjithe kapar ne dhomen e re
						{
							dsCmimi = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma, dtHyrje);
							cmimi = Convert.ToInt32(dsCmimi.Tables[0].Rows[0][0]);
							pagesa = this.GjejPagesen(idKategoria, cmimi, dtHyrje,dtDalje);
							if (kapari > pagesa)
							{
								a =  3;
								b = 0;
							}
							else
							{
								a =  0;
								b = 6;
							}
						}
						else
						{
							a =  0;
							b = 7;
						}
					}
					else//dhoma  e re ka kliente per keto data
					{
						//kapari eshte dhene nje here per kete hyrje 
						//si edhe jane caktuar datat e intervalit
						//per rrjedhoje kapari mbetet i rregullt
						if (merrKapar)//klienti ishte vetem
						{
							a =  0;
							b = 8;
						}
						else
						{
							a =  0;
							b = 9;
						}
					}
				}
			}
			DataSet dsR = new DataSet();
			dsR.Tables.Add();
			dsR.Tables[0].Columns.Add("A", typeof(Int32));
			dsR.Tables[0].Columns.Add("B", typeof(Int32));
			DataRow r = dsR.Tables[0].NewRow();
			r["A"] = a;
			r["B"] = b;
			dsR.Tables[0].Rows.Add(r);
			dsR.AcceptChanges();
			return dsR;
		}
		private DataSet KontrolloGrup()
		{
			int a = 0;
			int b = 0;
			InputController data = new InputController();
			DataSet dsCmimi, tmp, dsData, ds;
			int indexkerkuar, pagesa, kapari,cmimi, skonto , gjoba;
			DataRow drk;
			DateTime dataMinPerGrupin,dataMaxPerGrupin;
			int index = this.gridGrupi.CurrentRowIndex;
			int idKlienti = Convert.ToInt32(this.cmbKlientetGrupi.Kolone2Vlere);
			DateTime dtHyrje = Convert.ToDateTime(this.dtpHyrjeGrupi.Value);
			DateTime dtDalje = Convert.ToDateTime(this.dtpDaljeGrupi.Value); 
			int idGrupi = Convert.ToInt32(this.cmbGrupetTeDhena.Kolone2Vlere);
			int idKategoria = Convert.ToInt32(cmbKategoriaGrup.Kolone2Vlere);
			int idGrupiVjeter = Convert.ToInt32(this.gridGrupi[this.gridGrupi.CurrentRowIndex, 15].ToString());
			bool merrKapar = false;
			int idDhoma = Convert.ToInt32(cmbDhomatGrup.Kolone2Vlere); 
			if (idGrupi == idGrupiVjeter)
			{
				dataMinPerGrupin = Convert.ToDateTime(gridGrupi[index, 11].ToString());
				dataMaxPerGrupin = Convert.ToDateTime(gridGrupi[index, 12].ToString());
				bool k1 = (dtHyrje >= dataMinPerGrupin) && (dtHyrje < dataMaxPerGrupin);
				bool k2 = (dtDalje > dataMinPerGrupin) && (dtDalje <= dataMaxPerGrupin);
				bool k3 = (dtHyrje < dataMinPerGrupin) && (dtDalje > dataMaxPerGrupin);
				if (k1 || k2 || k3)//klienti ndodhet brenda te njejtes hyrje
				{
					ds = data.KerkesaRead("ShfaqVeprimetPerGrupin", idGrupi,-1, dtHyrje, dtDalje);
					indexkerkuar = this.KerkoDataSet(ds, dtHyrje, dtDalje);
					//indexkerkuar eshte gjithmone >= 0 sepese do te kete te pakten nje klient
					//te pakten klienti qe po modifikohet
					drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
					string strId = drk["ID_KLIENTI_STR"].ToString();
					tmp = this.gjejDataSetKlientet(strId);
					//gjetja e intervalit pa klient behet per arsye se 
					//mund te ndodhe se ndonese klienti mbetet brenda te njejtes hyrje
					//te dale pak me tej dates min ose dates max
					dsData = this.GjejIntervalinPaKlient(tmp, idKlienti);
					if (dsData.Tables[0].Rows.Count != 0)
					{
						dataMinPerGrupin = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MINDATA"]);
						dataMaxPerGrupin = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MAXDATA"]);
					}
					else//grupi ka pasur vetem nje klient
					{
						dataMinPerGrupin = dtHyrje;
						dataMaxPerGrupin = dtDalje;
					}
					kapari = Convert.ToInt32(drk["KAPARI"]);
					skonto = Convert.ToInt32(drk["SKONTO"]);
					gjoba = Convert.ToInt32(drk["GJOBA"]);
					if (dtHyrje < dataMinPerGrupin)
						dataMinPerGrupin = dtHyrje;
					if (dtDalje > dataMaxPerGrupin)
						dataMaxPerGrupin = dtDalje;
					DataSet dsPagesa = this.PagesaGrupi(tmp, kapari, skonto, gjoba);
					pagesa = Convert.ToInt32(dsPagesa.Tables[0].Rows[dsPagesa.Tables[0].Rows.Count - 1]["VLERA"]);
					if (pagesa < 0)
					{
						a =  1;
						b = 0;
					}
					else
					{
						a =  0;
						b = 1;
					}
				}
				else//klienti ndryshon hyrje
				{
					//kontrollojme hyrjen e vjeter
					ds = data.KerkesaRead("ShfaqVeprimetPerGrupin", idGrupi,-1, dataMinPerGrupin, dataMaxPerGrupin);
					indexkerkuar = this.KerkoDataSet(ds,dataMinPerGrupin, dataMaxPerGrupin);
					//ky eshte gjithmone jonegativ sepse hyrja ka te pakten nje klient
					//te pakten klienti qe po modifikohet
					drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
					kapari = Convert.ToInt32(drk["KAPARI"]);
					skonto = Convert.ToInt32(drk["SKONTO"]);
					gjoba = Convert.ToInt32(drk["GJOBA"]);
					string strId = drk["ID_KLIENTI_STR"].ToString();
					tmp = this.gjejDataSetKlientet(strId);
					dsData = this.GjejIntervalinPaKlient(tmp, idKlienti);
					if (dsData.Tables[0].Rows.Count == 0)//nuk mbetet me asnje klient ne grup
						merrKapar = true;
					else//mbeten kliente te tjere ne grup
					{
						dataMinPerGrupin = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MINDATA"]);
						dataMaxPerGrupin = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MAXDATA"]);
						DataSet dsPagesa = this.PagesaGrupi(tmp, kapari, skonto, gjoba);
						pagesa = Convert.ToInt32(dsPagesa.Tables[0].Rows[dsPagesa.Tables[0].Rows.Count - 1]["VLERA"]);
						if (pagesa < 0)
						{
							a =  4;
							b = 0;
						}
					}
					//kontrollojme hyrjen e re
					if (a == 0)
					{
						ds = data.KerkesaRead("ShfaqVeprimetPerGrupin", idGrupi,-1, dtHyrje, dtDalje);
						indexkerkuar = this.KerkoDataSet(ds, dtHyrje, dtDalje);
						if (indexkerkuar < 0)//grupi s'ka kliente per datat e kerkuara
						{
							if (merrKapar)//klienti kalon me gjithe kapar
							{
								dsCmimi = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma , dtHyrje);
								cmimi = Convert.ToInt32(dsCmimi.Tables[0].Rows[0][0]);
								pagesa = this.GjejPagesen(idKategoria, cmimi, dtHyrje, dtDalje);
								if (kapari > pagesa)
								{
									a =  5;
									b = 0;
								}
								else
								{
									a =  0;
									b = 2;
								}
							}
							else
							{
								a =  0;
								b = 3;
							}
						}
						else//grupi ka kliente per datat e kerkuara
						{
							//kapari eshte dhene nje here per kete hyrje 
							//si edhe jane caktuar datat e intervalit
							//per rrjedhoje kapari mbetet i rregullt
							if (merrKapar)//klienti ka qene vetem
							{
								a =  0;
								b = 4;
							}
							else
							{
								a =  0;
								b = 5;
							}
						}
					}
				}
			}
			else
			{
				merrKapar = false;
				//per te kontrolluar grupin e vjeter
				//int idKategoriaVjeter = Convert.ToInt32(data.KerkesaRead("NxirrDhome", idGrupiVjeter).Tables[0].Rows[0]["ID_KATEGORIA"]);
				dataMinPerGrupin = Convert.ToDateTime(gridGrupi[index, 11].ToString());
				dataMaxPerGrupin = Convert.ToDateTime(gridGrupi[index, 12].ToString());
				ds = data.KerkesaRead("ShfaqVeprimetPerGrupin", idGrupiVjeter,-1, dataMinPerGrupin, dataMaxPerGrupin);
				//ds nuk mund te jete bosh sepse grupi ka patur per keto data te pakten nje klient
				//qe eshte klienti qe po modifikohet
				indexkerkuar = this.KerkoDataSet(ds,dataMinPerGrupin, dataMaxPerGrupin);
				drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
				kapari = Convert.ToInt32(drk["KAPARI"]);
				skonto = Convert.ToInt32(drk["SKONTO"]);
				gjoba = Convert.ToInt32(drk["GJOBA"]);
				string strId = drk["ID_KLIENTI_STR"].ToString();
				tmp = this.gjejDataSetKlientet(strId);
				dsData = this.GjejIntervalinPaKlient(tmp, idKlienti);
				if (dsData.Tables[0].Rows.Count == 0)//nuk mbetet me klient ne grup
					merrKapar = true;
				else//mbeten klient ne grup
				{
					dataMinPerGrupin = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MINDATA"]);
					dataMaxPerGrupin = Convert.ToDateTime(dsData.Tables[0].Rows[0]["MAXDATA"]);
					DataSet dsPagesa = this.PagesaGrupi(tmp, kapari, skonto, gjoba);
					pagesa = Convert.ToInt32(dsPagesa.Tables[0].Rows[dsPagesa.Tables[0].Rows.Count - 1]["VLERA"]);
					if (kapari > pagesa)
					{
						a =  2;
						b = 0;
					}
				}
				//per te kontrolluar grupin e ri
				if (a == 0)
				{
					ds = data.KerkesaRead("ShfaqVeprimetPerGrupin", idGrupi,-1, dtHyrje, dtDalje);
					indexkerkuar = this.KerkoDataSet(ds, dtHyrje, dtDalje);
					if (indexkerkuar < 0)//grupi i ri nuk ka kliente per keto data
					{
						if (merrKapar)//kalon me gjithe kapar ne grupin e ri
						{
							dsCmimi = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma, dtHyrje);
							cmimi = Convert.ToInt32(dsCmimi.Tables[0].Rows[0][0]);
							pagesa = this.GjejPagesen(idKategoria, cmimi, dtHyrje,dtDalje);
							if (kapari > pagesa)
							{
								a =  3;
								b = 0;
							}
							else
							{
								a =  0;
								b = 6;
							}
						}
						else
						{
							a =  0;
							b = 7;
						}
					}
					else//grupi i ri ka kliente per keto data
					{
						//kapari eshte dhene nje here per kete hyrje 
						//si edhe jane caktuar datat e intervalit
						//per rrjedhoje kapari mbetet i rregullt
						if (merrKapar)//klienti ishte vetem
						{
							a =  0;
							b = 8;
						}
						else
						{
							a =  0;
							b = 9;
						}
					}
				}
			}
			DataSet dsR = new DataSet();
			dsR.Tables.Add();
			dsR.Tables[0].Columns.Add("A", typeof(Int32));
			dsR.Tables[0].Columns.Add("B", typeof(Int32));
			DataRow r = dsR.Tables[0].NewRow();
			r["A"] = a;
			r["B"] = b;
			dsR.Tables[0].Rows.Add(r);
			dsR.AcceptChanges();
			return dsR;
		}
		private int KontrolloGrupIvjetri()
		{
			int index =  gridGrupi.CurrentRowIndex;
			int idKlienti = Convert.ToInt32(this.cmbKlientetGrupi.Kolone2Vlere);
			int idGrupi = Convert.ToInt32(this.cmbGrupetTeDhena.Kolone2Vlere);
			int idDhoma = Convert.ToInt32(this.cmbDhomatGrupi.Kolone2Vlere);
			DateTime dtHyrje = Convert.ToDateTime(this.dtpHyrjeGrupi.Value);
			DateTime dtDalje = Convert.ToDateTime(this.dtpDaljeGrupi.Value);
			DataRow r = this.ds_grupi.Tables[0].Rows[0];
			InputController data = new InputController();
			//tregon numrin e klienteve qe jane aktualisht ne grup
			int nrKliente = this.cmbKlientetGrupi.Kolone1.Items.Count;
			//tregon numrin e klienteve qe jane ne grupin e modifikuar per datat e modifikuara
			int nrKlienteTjeter = Convert.ToInt32(data.KerkesaRead("NumerKlienteshPerDateGrupPerModifikim", idGrupi, dtHyrje, dtDalje, idKlienti).Tables[0].Rows[0][0]);
			string strId = this.gridGrupi[index, 6].ToString();
			DataSet kliente = this.gjejDataSetKlientet(strId);
			DataSet dsData = this.GjejIntervalinPaKlient(kliente, idKlienti);
			/* per inicializim*/
			DateTime mindata = dtHyrje;
			DateTime maxdata = dtDalje;
			/* per inicializim*/
			if (dsData.Tables[0].Rows.Count != 0)
			{
				mindata = Convert.ToDateTime(dsData.Tables[0].Rows[0][0]);
				maxdata = Convert.ToDateTime(dsData.Tables[0].Rows[0][1]);
			}
			DateTime dt = Convert.ToDateTime(gridGrupi[index, 11]);
			DataSet dsKaparPergjegjes = this.gjejKaparPergjegjesGrupi(idGrupi, dt);
			int pergjegjes = Convert.ToInt32(dsKaparPergjegjes.Tables[0].Rows[0][3]);
			int kapari = Convert.ToInt32(dsKaparPergjegjes.Tables[0].Rows[0][1]);
			//klienti mbetet ne te njejtin grup
			if (idGrupi == Convert.ToInt32(r["ID_GRUPI"]))
			{
				//aktualisht klienti eshte vetem ne grup
				if (nrKliente == 1)
				{
					//per datat e modifikuara grupi nuk ka te tjere kliente
					//prandaj klienti do te kaloje me gjithe kapar ne datat e reja 
					if (nrKlienteTjeter == 0)
						return 1;
						//per datat e modifikuara grupi ka kliente te tjere 
						//prendaj klienti do te kaloje me kapar 0 ne datat e reja
					else
						return 2;						
				}
					//aktualisht klienti nuk eshte vetem ne grup
				else
				{

					//modifikimi i datave e nxjerr klientin nga intervali i grupit
					if ((dtHyrje >= maxdata)||(dtDalje < mindata))
					{
						//klienti eshte pergjegjes per grupin ku ndodhet
						if (pergjegjes == idKlienti)
						{
							//per datat e modifikuara grupi nuk ka te tjere kliente
							//gjithsesi klienti do te kaloje me kapar 0 ne datat e reja
							//kapari i pergjegjesit do t'i kaloje tjetrit ne radhe
							//do te paraqitet nje mesazh i cili i tregon perdoruesit se per datat e caktuara grupit nuk i eshte hedhur kapar
							if (nrKlienteTjeter == 0)
								return 3;
								//per datat e modifikuara grupi ka kliente te tjere 
								//prandaj klienti do te kaloje me kapar 0 ne datat e reja
								//kapari i pergjegjesit do t'i kaloje tjetrit ne radhe
							else
								return 4;
						}
							//klienti nuk eshte pergjegjes per grupin ku ndodhet
						else
						{
							//per datat e modifikuara grupi nuk ka te tjere kliente
							//do te paraqitet nje mesazh i cili i tregon perdoruesit se per datat e caktuara grupit nuk i eshte hedhur kapar
							if (nrKlienteTjeter == 0)
								return 5;
								//per datat e modifikuara grupi ka kliente te tjere
							else
								return 6;
						}
					}
						//modifikimi i datave e mban klientin brenda intervalit te grupit
					else
					{
						return 7;
					}
				}
			}
				//klientit i ndryshohet grupi
			else
			{
				//klienti eshte i vetmi ne grupin aktual
				if (nrKliente == 1)
				{
					//per grupin e modifikuar nuk ka kliente te tjere
					//klienti do te kaloje ne kete grup me gjithe kapar
					if (nrKlienteTjeter == 0)
					{
						return 8;
					}
						//per grupin e modifikuar ka edhe kliente te tjere
						//klienti do te kaloje ne kete grup me kapr 0
					else
					{
						return 9;
					}
				}
					//grupi aktual ka dhe kliente te tjere
					//eshte e qarte qe ketu trajtohet rasti kur klienti eshte vetem ne dhome
					//mqs nuk do te lejohen dy kliente me grupe te ndryshme ne te njejten dhome
				else
				{
					//klienti eshte pergjegjes per grupin ku eshte
					//prandaj kalon me kapar 0 te grupi i ri dhe ia le kaparin klientit tjeter ne radhe
					if (pergjegjes == idKlienti)
					{
						//grupi i ri nuk ka kliente per datat e modifikuara
						//perdoruesit duhet t'i tregohet se kjo perben nje hyrje te re ne grup 
						//dhe per kete hyrje nuk eshte hedhur kapar
						if (nrKlienteTjeter == 0)
						{
							return 10;
						}
							//grupi i ri ka kliente te tjere per datat
							//rrjedhimisht i eshte hedhur nje here kapar
							//perdoruesi duhet te informohet se ka mundesi te ndryshoje kaparin nese deshiron
						else
						{
							return 11;
						}
					}
						//klienti nuk eshte pergjegjes per grupin ku eshte
						//dhe kalon ashtu si eshte per te grupi i ri
					else
					{
						//grupi i ri nuk ka kliente per datat e modifikuara
						//perdoruesit duhet t'i tregohet se kjo perben nje hyrje te re ne grup 
						//dhe per kete hyrje nuk eshte hedhur kapar
						if (nrKlienteTjeter == 0)
						{
							return 12;
						}
							//grupi i ri ka kliente te tjere per datat
							//rrjedhimisht i eshte hedhur nje here kapar
							//perdoruesi duhet te informohet se ka mundesi te ndryshoje kaparin nese deshiron
						else
						{
							return 13;
						}
					}
				}
			}
		}
		private int KontrolloPerEleminim(int idKlienti, VisionInfoSolutionLibrary.DoubleCombo cmb)
		{
			int nrKliente = cmb.Kolone1.Items.Count;
			//rasti kur klienti eshte vetem ne dhome(grup ne rastin e grupit)
			if (nrKliente == 1)
				return 0;
				//rasti kur klienti nuk eshte vetem ne dhome(grup ne rastin e grupit)
			else 
				return 1;
		}
		private int KontrolloPerEleminim(int idKlienti, string strId)
		{
			int nrKliente = 1;
			for(int i = 0; i < strId.Length; i++)
			{
				if (i != strId.Length - 1)
				{
					string ch = strId.Substring(i, 2);
					if (ch == Environment.NewLine)
					{
						nrKliente++;
						break;
					}
				}
			}
			if (nrKliente == 1)
				//rasti kur klienti eshte vetem ne dhome(grup ne rastin e grupit)
				return 0;
			else 
				//rasti kur klienti nuk eshte vetem ne dhome(grup ne rastin e grupit)
				return 1;
		}
		/// <summary>
		/// Per nje dhome dhe date te dhene gjenden te dhenat e hyrjes
		/// si skonto ,kapar, gjobe dhe pergjegjes
		/// </summary>
		/// <param name="idDhoma"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		private DataSet gjejKaparPergjegjes(int idDhoma, DateTime data)
		{
			InputController data1 = new InputController();
			DataTable dt = data1.KerkesaRead("ShfaqVeprimetPerDhomen", idDhoma, -1).Tables["KLIENTI"];
			DataSet dsKaparPergjegjes = new DataSet();
			dsKaparPergjegjes.Tables.Add();
			dsKaparPergjegjes.Tables[0].Columns.Add("KAPARI", typeof(Int32));
			dsKaparPergjegjes.Tables[0].Columns.Add("SKONTO", typeof(Int32));
			dsKaparPergjegjes.Tables[0].Columns.Add("GJOBA", typeof(Int32));
			dsKaparPergjegjes.Tables[0].Columns.Add("PERGJEGJES", typeof(Int32));
			dsKaparPergjegjes.AcceptChanges();
			foreach(DataRow dr in dt.Rows)
			{
				DateTime mindata = Convert.ToDateTime(dr["MINDATA"]);
				DateTime maxdata = Convert.ToDateTime(dr["MAXDATA"]);
				if ((data >= mindata) && (data <= maxdata))
				{
					DataRow r = dsKaparPergjegjes.Tables[0].NewRow();
					r["KAPARI"] = dr["KAPARI"];
					r["SKONTO"] = dr["SKONTO"];
					r["GJOBA"] = dr["GJOBA"];
					r["PERGJEGJES"] = dr["PERGJEGJES"];
					dsKaparPergjegjes.Tables[0].Rows.Add(r);
					break;
				}
			}
			dsKaparPergjegjes.AcceptChanges();
			return dsKaparPergjegjes;
		}

		/// <summary>
		/// Per nje dhome dhe date te dhene gjenden te dhenat e hyrjes
		/// si skonto ,kapar, gjobe dhe pergjegjes
		/// </summary>
		/// <param name="idGrupi"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		private DataSet gjejKaparPergjegjesGrupi(int idGrupi, DateTime data)
		{
			InputController data1 = new InputController();
			DataTable dt = data1.KerkesaRead("ShfaqVeprimetPerGrupin", idGrupi, -1).Tables["KLIENTI"];
			DataSet dsKaparPergjegjes = new DataSet();
			dsKaparPergjegjes.Tables.Add();
			dsKaparPergjegjes.Tables[0].Columns.Add("KAPARI", typeof(Int32));
			dsKaparPergjegjes.Tables[0].Columns.Add("SKONTO", typeof(Int32));
			dsKaparPergjegjes.Tables[0].Columns.Add("GJOBA", typeof(Int32));
			dsKaparPergjegjes.Tables[0].Columns.Add("PERGJEGJES", typeof(Int32));
			dsKaparPergjegjes.AcceptChanges();
			foreach(DataRow dr in dt.Rows)
			{
				DateTime mindata = Convert.ToDateTime(dr["MINDATA"]);
				DateTime maxdata = Convert.ToDateTime(dr["MAXDATA"]);
				if ((data >= mindata) && (data <= maxdata))
				{
					DataRow r = dsKaparPergjegjes.Tables[0].NewRow();
					r["KAPARI"] = dr["KAPARI"];
					r["SKONTO"] = dr["SKONTO"];
					r["GJOBA"] = dr["GJOBA"];
					r["PERGJEGJES"] = dr["PERGJEGJES"];
					dsKaparPergjegjes.Tables[0].Rows.Add(r);
					break;
				}
			}
			dsKaparPergjegjes.AcceptChanges();
			return dsKaparPergjegjes;
		}
		/// <summary>
		/// Per stringun qe mban id e klienteve ne vazhdimesi
		/// gjendet dataseti me datat dhe dhomat
		/// </summary>
		/// <param name="str_id"></param>
		/// <returns></returns>
		private DataSet gjejDataSetKlientet(string str_id)
		{
			DataSet ds = new DataSet();
			ds.Tables.Add();
			ds.Tables[0].Columns.Add("ID", typeof(Int32));
			ds.Tables[0].Columns.Add("DATA_HYRJE", typeof(DateTime));
			ds.Tables[0].Columns.Add("DATA_DALJE", typeof(DateTime));
			ds.Tables[0].Columns.Add("ID_DHOMA", typeof(Int32));
			ds.Tables[0].Columns.Add("DHOMA_EMRI", typeof(String));
			ds.AcceptChanges();
			int l = str_id.Length;
			string id = "";
			int i = 0;
			while (i < l)
			{
				
				string c = str_id.Substring(i, 1);
				if (i == l - 1)
				{
					id = id + c;
					DataRow dr = ds.Tables[0].NewRow();
					dr["ID"] = Convert.ToInt32(id);
					ds.Tables[0].Rows.Add(dr);
					id = "";
					i++;
				}
				else
				{
					string next = str_id.Substring(i, 2);
					if (next == Environment.NewLine)
					{
						DataRow dr = ds.Tables[0].NewRow();
						dr["ID"] = Convert.ToInt32(id);
						ds.Tables[0].Rows.Add(dr);
						id = "";
						i = i + 2;
					}
					else
					{
						id = id + c;
						i++;
					}
				}
			}
			ds.AcceptChanges();
			InputController data = new InputController();
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				int idKlienti = Convert.ToInt32(dr["ID"]);
				DataSet tmp = data.KerkesaRead("ShfaqTeDhenaKlientiId", idKlienti);
				DataRow r = tmp.Tables[0].Rows[0];
				dr["DATA_HYRJE"] = r["DATA_HYRJE"];
				dr["DATA_DALJE"] = r["DATA_DALJE"];
				dr["ID_DHOMA"] = r["ID_DHOMA"];
				dr["DHOMA_EMRI"] = r["DHOMA_EMRI"];

			}
			ds.AcceptChanges();
			return ds;
		}

		private DataSet PagesaGrupi(DataSet ds, int kapari, int skonto,int  gjoba)
		{
			DataSet ds_dhoma = new DataSet();
			ds_dhoma.Tables.Add();
			ds_dhoma.Tables[0].Columns.Add("ID", typeof(Int32));
			ds_dhoma.Tables[0].Columns.Add("DHOMA", typeof(String));
			ds_dhoma.AcceptChanges();
			InputController data = new InputController();
			foreach(DataRow dr in ds.Tables[0].Rows)
			{ 
				bool ugjet = false;
				int id_dhoma = Convert.ToInt32(dr["ID_DHOMA"]);
				foreach(DataRow r in ds_dhoma.Tables[0].Rows)
				{
					if (Convert.ToInt32(r["ID"]) == id_dhoma)
					{
						ugjet = true;
						break;
					}
				}
				if (!ugjet)
				{
					DataRow new_row = ds_dhoma.Tables[0].NewRow();
					new_row["ID"] = id_dhoma;
					ds_dhoma.Tables[0].Rows.Add(new_row);
					ds_dhoma.AcceptChanges();
				}
			}
			ds_dhoma.Tables[0].Columns.Add("MINDATA", typeof(DateTime));
			ds_dhoma.Tables[0].Columns.Add("MAXDATA", typeof(DateTime));
			ds_dhoma.Tables[0].Columns.Add("INTERVALI", typeof(String));
			ds_dhoma.Tables[0].Columns.Add("CMIMI", typeof(Int32));
			ds_dhoma.Tables[0].Columns.Add("VLERA", typeof(Int32));
			int index = gridGrupi.CurrentRowIndex;
			DateTime d1 = Convert.ToDateTime(gridGrupi[index, 11]);
			DateTime d2 = Convert.ToDateTime(gridGrupi[index, 12]);
			int shuma = 0;
			foreach(DataRow drow in ds_dhoma.Tables[0].Rows)
			{
				int id_dhoma = Convert.ToInt32(drow["ID"]);
				DateTime mindata = DateTime.Now.AddYears(2000);
				DateTime maxdata = DateTime.Now.AddYears(-2000);
				string dhoma = "";
				foreach(DataRow r in ds.Tables[0].Rows )
				{
					if (Convert.ToInt32(r["ID_DHOMA"]) == id_dhoma)
					{
						data = new InputController();
						DataSet klienti = data.KerkesaRead("ShfaqTeDhenaKlientiId", Convert.ToInt32(r["ID"]));
						DateTime datafillimi = Convert.ToDateTime(klienti.Tables[0].Rows[0]["DATA_HYRJE"]);
						DateTime datambarimi = Convert.ToDateTime(klienti.Tables[0].Rows[0]["DATA_DALJE"]);
						dhoma = klienti.Tables[0].Rows[0]["DHOMA_EMRI"].ToString();
						if (datafillimi < mindata)
							mindata = datafillimi;
						if (datambarimi > maxdata)
							maxdata = datambarimi;
					}
				}
				drow["MINDATA"] = mindata;
				drow["MAXDATA"] = maxdata;
				drow["DHOMA"] = dhoma;
				int id_kategoria = Convert.ToInt32(data.KerkesaRead("NxirrDhome", id_dhoma).Tables[0].Rows[0]["ID_KATEGORIA"]);
				int nr_ditesh = 0;
				double nr_oresh_double, ore;
				string dite;
				if (id_kategoria == 31)
				{
					TimeSpan ts = maxdata.Subtract(mindata);
					nr_ditesh = Convert.ToInt32(ts.TotalMinutes);
					nr_oresh_double = nr_ditesh;
					ore = Math.Round(nr_oresh_double/60, 1);
					dite = ore + " ore";
				}
				else
				{	
					TimeSpan ts = maxdata.Date.Subtract(mindata.Date);
					nr_ditesh = Convert.ToInt32(ts.Days);
					ore = nr_ditesh;
					dite = ore + " dite";
				}
				drow["INTERVALI"] = dite;
				DataSet ds_cmimi = data.KerkesaRead("CmimiDhomesPerDaten", id_dhoma , mindata);
				int cmimi = Convert.ToInt32(ds_cmimi.Tables[0].Rows[0][0]);
				drow["CMIMI"] = cmimi.ToString();
				drow["VLERA"] = Convert.ToInt32(ore * cmimi);
				shuma = shuma + Convert.ToInt32(ore * cmimi);
			}
			DataRow kapari_row = ds_dhoma.Tables[0].NewRow();
			kapari_row["DHOMA"] = "Kapari";
			kapari_row["VLERA"] = kapari.ToString();
			ds_dhoma.Tables[0].Rows.Add(kapari_row);
			ds_dhoma.AcceptChanges();
			shuma = shuma - kapari;

			DataRow pagesa_row = ds_dhoma.Tables[0].NewRow();
			pagesa_row["DHOMA"] = "Skonto";
			pagesa_row["VLERA"] = skonto;
			ds_dhoma.Tables[0].Rows.Add(pagesa_row);
			shuma = shuma - skonto;

			pagesa_row = ds_dhoma.Tables[0].NewRow();
			pagesa_row["DHOMA"] = "Gjoba";
			pagesa_row["VLERA"] = gjoba;
			ds_dhoma.Tables[0].Rows.Add(pagesa_row);
			shuma = shuma + gjoba;

			pagesa_row = ds_dhoma.Tables[0].NewRow();
			pagesa_row["DHOMA"] = "Pagesa";
			pagesa_row["VLERA"] = shuma;
			ds_dhoma.Tables[0].Rows.Add(pagesa_row);
			ds_dhoma.AcceptChanges();
			return ds_dhoma;
		}
		
		private int PagesaRezervimiGrupi(int idRezervimi)
		{
			InputController data = new InputController();
			DataSet dsRez = data.KerkesaRead("ShfaqDhomaPerRezervim", idRezervimi);
			int pagesaRezervimi = 0;
			DateTime dtFillimi, dtMbarimi;
			if (dsRez.Tables[0].Rows.Count == 0)
				return pagesaRezervimi;
			else	
			{
				dtFillimi = Convert.ToDateTime(dsRez.Tables[0].Rows[0]["DATA_FILLIMI"]);
				dtMbarimi = Convert.ToDateTime(dsRez.Tables[0].Rows[0]["DATA_MBARIMI"]);
			}
			foreach(DataRow dr in dsRez.Tables[0].Rows)
			{
				int idKategoria = Convert.ToInt32(dr["ID_KATEGORIA"]);
				int cmimi = Convert.ToInt32(dr["CMIMI"]);
				int pagesaDhoma = this.GjejPagesen(idKategoria, cmimi, dtFillimi, dtMbarimi);
				pagesaRezervimi += pagesaDhoma;
			}
			return pagesaRezervimi;
		}
		/// <summary>
		/// Per nje dataset qe i perket nje hyrjeje te caktuar
		/// gjenden datat min dhe max te hyrjes pa perfshire klientin
		/// </summary>
		/// <param name="ds"></param>
		/// <param name="idKlienti"></param>
		/// <returns></returns>
		private DataSet GjejIntervalinPaKlient(DataSet ds, int idKlienti)
		{
			DataSet ds_data = new DataSet();
			ds_data.Tables.Add();
			ds_data.Tables[0].Columns.Add("MINDATA", typeof(DateTime));
			ds_data.Tables[0].Columns.Add("MAXDATA", typeof(DateTime));
			ds_data.AcceptChanges();
			DateTime mindata = DateTime.Now.AddYears(2000);
			DateTime maxdata = DateTime.Now.AddYears(-2000);
			bool ugjet = false;
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				if (Convert.ToInt32(dr["ID"]) != idKlienti)
				{
					ugjet =  true;
					DateTime dtHyrje = Convert.ToDateTime(dr["DATA_HYRJE"]);
					DateTime dtDalje = Convert.ToDateTime(dr["DATA_DALJE"]);
					if (mindata > dtHyrje)
						mindata = dtHyrje;
					if (maxdata < dtDalje)
						maxdata = dtDalje;
				}
			}
			if (ugjet == true)
			{
				DataRow r = ds_data.Tables[0].NewRow();
				r["MINDATA"] = mindata;
				r["MAXDATA"] = maxdata;
				ds_data.Tables[0].Rows.Add(r);
				ds_data.AcceptChanges();
			}
			return ds_data;
		}

		
		private DateTime gjej_daten(string str)
		{
			DateTime data;
			string data_str = str;
			data_str = data_str.Substring(6, 4) + "-" + data_str.Substring(3, 2)+ "-" + data_str.Substring(0, 2) + " " + data_str.Substring(11, 8);
			data = Convert.ToDateTime(data_str);
			return data;
		}
		/// <summary>
		/// per stringjet me id e klienteve dhe me emrat
		/// krijohet ds perkates
		/// </summary>
		/// <param name="str_id"></param>
		/// <param name="str_emra"></param>
		/// <returns></returns>
		private DataSet gjej_id_emra(string str_id, string str_emra)
		{
			DataSet ds = new DataSet();
			ds.Tables.Add();
			ds.Tables[0].Columns.Add("ID", typeof(Int32));
			ds.Tables[0].Columns.Add("KLIENTI", typeof(String));
			ds.AcceptChanges();
			int l = str_id.Length;
			string id = "";
			int i = 0;
			while (i < l)
			{
				
				string c = str_id.Substring(i, 1);
				if (i == l - 1)
				{
					id = id + c;
					DataRow dr = ds.Tables[0].NewRow();
					dr["ID"] = Convert.ToInt32(id);
					ds.Tables[0].Rows.Add(dr);
					id = "";
					i++;
				}
				else
				{
					string next = str_id.Substring(i, 2);
					if (next == Environment.NewLine)
					{
						DataRow dr = ds.Tables[0].NewRow();
						dr["ID"] = Convert.ToInt32(id);
						ds.Tables[0].Rows.Add(dr);
						id = "";
						i = i + 2;
					}
					else
					{
						id = id + c;
						i++;
					}
				}
			}
			int count = 0;
			l = str_emra.Length;
			string emer = "";
			i = 0;
			while (i < l)
			{
				string c = str_emra.Substring(i, 1);
				if (i == l - 1)
				{
					emer = emer + c;
					ds.Tables[0].Rows[count][1] = emer;
					emer = "";
					count++;
					i++;
				}
				else
				{
					string next = str_emra.Substring(i, 2);
					if ((next == Environment.NewLine)||( i == l - 1))
					{
						ds.Tables[0].Rows[count][1] = emer;
						emer = "";
						count++;
						i = i + 2;
					}
					else
					{
						emer = emer + c;
						i++;
					}
				}
			}
			ds.AcceptChanges();
			return ds;

		}

		/// <summary>
		/// kryen mbushjen e kombos me nje ds te caktuar
		/// </summary>
		/// <param name="cmb"></param>
		/// <param name="kliente"></param>
		private void mbush_kombo_kliente(VisionInfoSolutionLibrary.DoubleCombo cmb, DataSet kliente)
		{
			cmb.Kolone1.Items.Clear();
			cmb.Kolone2.Items.Clear();
			cmb.Kolone1.Text = "";
			cmb.Kolone2.Text = "";
			foreach(DataRow dr in kliente.Tables[0].Rows)
			{
				cmb.Kolone1.Items.Add(dr[1].ToString());
				cmb.Kolone2.Items.Add(dr[0].ToString());
			}
		}

		private string konverto(DateTime data)
		{
			string data_str = data.ToString();
			string dita, muaji, viti, ora;
			dita = data_str.Substring(8, 2);
			muaji = data_str.Substring(5, 2);
			viti = data_str.Substring(0, 4);
			ora =data_str.Substring(11);
			data_str = dita + "-" + muaji + "-" + viti + " " + ora;
			return data_str;
		}

		private string konvertoshkurt(DateTime data)
		{
			string data_str = data.ToString();
			string dita, muaji, viti, ora;
			dita = data_str.Substring(8, 2);
			muaji = data_str.Substring(5, 2);
			viti = data_str.Substring(0, 4);
			ora =data_str.Substring(11);
			data_str = dita + "-" + muaji + "-" + viti ;
			return data_str;
		}
		
		/// <summary>
		/// per mbushjen e kombove te dhomave
		/// </summary>
		private void mbushDhomat()
		{
			DataSet ds = null ;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqDhomat");
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbDhomat.Kolone1.Items.Add(dr[1]);
				this.cmbDhomat.Kolone2.Items.Add(dr[0]);
				this.cmbDhomatGrupi.Kolone1.Items.Add(dr[1]);
				this.cmbDhomatGrupi.Kolone2.Items.Add(dr[0]);
			}
		}
		
		/// <summary>
		/// per mbushjen e kombove te grupeve
		/// </summary>
		private void mbushGrupet()
		{
			InputController data = new InputController();
			DataSet ds = null;
			ds = data.KerkesaRead("ShfaqGrupet");
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbGrupet.Kolone1.Items.Add(dr[1]);
				this.cmbGrupet.Kolone2.Items.Add(dr[0]);
				this.cmbGrupetTeDhena.Kolone1.Items.Add(dr[1]);
				this.cmbGrupetTeDhena.Kolone2.Items.Add(dr[0]);
			}
		}

		/// <summary>
		/// per mbushjen e kombove te kategorive
		/// </summary>
		private void mbushKategorite()
		{
			DataSet ds = null ;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqKategorite");
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbKategoria.Kolone1.Items.Add(dr[1]);
				this.cmbKategoria.Kolone2.Items.Add(dr[0]);
				this.cmbKategoriaGrup.Kolone1.Items.Add(dr[1]);
				this.cmbKategoriaGrup.Kolone2.Items.Add(dr[0]);
			}
		}

		/// <summary>
		/// per mbushjen e kombove te formave te pagesave
		/// </summary>
		private void MbushPagesat()
		{
			this.cmbPagesaKlienti.Kolone1.Items.Clear();
			this.cmbPagesaKlienti.Kolone2.Items.Clear();
			this.cmbPagesaKlienti.Kolone1.Text = "";
			this.cmbPagesaKlienti.Kolone2.Text = "";
			this.cmbPagesaGrupi.Kolone1.Items.Clear();
			this.cmbPagesaGrupi.Kolone2.Items.Clear();
			this.cmbPagesaGrupi.Kolone1.Text = "";
			this.cmbPagesaGrupi.Kolone2.Text = "";

			InputController data  = new InputController();
			DataSet ds = data.KerkesaRead("ShfaqTeGjithaFormatEPageses");
			string s = "";
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				if (Convert.ToInt32(dr["ID_FORMAPAGESA"]) == 1)
					s = dr["Emri"].ToString();
				this.cmbPagesaKlienti.Kolone1.Items.Add(dr["EMRI"]);
				this.cmbPagesaKlienti.Kolone2.Items.Add(dr["ID_FORMAPAGESA"]);
				this.cmbPagesaGrupi.Kolone1.Items.Add(dr["EMRI"]);
				this.cmbPagesaGrupi.Kolone2.Items.Add(dr["ID_FORMAPAGESA"]);
			}
			this.cmbPagesaKlienti.Kolone1.Text = s;
			this.cmbPagesaKlienti.Kolone1Vlere = s;
			this.cmbPagesaKlienti.Kolone2.Text = "1";
			this.cmbPagesaKlienti.Kolone2Vlere= "1";
			this.cmbPagesaGrupi.Kolone1.Text = s;
			this.cmbPagesaGrupi.Kolone1Vlere = s;
			this.cmbPagesaGrupi.Kolone2.Text = "1";
			this.cmbPagesaGrupi.Kolone2Vlere= "1";
		}
		private void KrijoStilgride()
		{
			try
			{
				this.gridKlienti.TableStyles.Clear();
				DataGridTableStyle style = new DataGridTableStyle();
				style.MappingName = "KLIENTI";
				style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
				style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
				this.gridKlienti.ReadOnly = true;

				DataGridTekstBoxColumn dhomaEmri = new DataGridTekstBoxColumn();
				dhomaEmri.HeaderText = "Dhoma";
				dhomaEmri.MappingName = "DHOMA_EMRI";
				dhomaEmri.Width = 60;

				DataGridTekstBoxColumn kapari = new DataGridTekstBoxColumn();
				kapari.HeaderText = "Kapari";
				kapari.MappingName = "KAPARI";
				kapari.NullText = "0";
				kapari.Width = 0;

				DataGridTekstBoxColumn skonto = new DataGridTekstBoxColumn();
				skonto.HeaderText = "Skonto";
				skonto.MappingName = "SKONTO";
				skonto.NullText = "0";
				skonto.Width = 0;

				DataGridTekstBoxColumn gjoba = new DataGridTekstBoxColumn();
				gjoba.HeaderText = "Gjoba";
				gjoba.MappingName = "GJOBA";
				gjoba.Width = 0;

				DataGridTekstBoxColumn emri = new DataGridTekstBoxColumn();
				emri.HeaderText = "Klienti";
				emri.MappingName = "EMRI";
				emri.Width = 110;

				DataGridTekstBoxColumn colDateFillimi1 = new DataGridTekstBoxColumn();
				colDateFillimi1.HeaderText = "Date Hyrje";
				colDateFillimi1.MappingName = "DATA_HYRJE_STR";
				colDateFillimi1.Width = 150;
				colDateFillimi1.NullText = "";

				DataGridTekstBoxColumn colDateMbarimi1 = new DataGridTekstBoxColumn();
				colDateMbarimi1 .HeaderText = "Date Dalje";
				colDateMbarimi1 .MappingName = "DATA_DALJE_STR";
				colDateMbarimi1 .Width = 150;
				colDateMbarimi1 .NullText = "";

				DataGridTekstBoxColumn colIdDhoma = new DataGridTekstBoxColumn();
				colIdDhoma .HeaderText = "Id dhoma";
				colIdDhoma .MappingName = "ID_DHOMA";
				colIdDhoma .Width = 0;
				colIdDhoma .NullText = "";

				DataGridTekstBoxColumn colIdKlienti = new DataGridTekstBoxColumn();
				colIdKlienti .HeaderText = "Id klienti";
				colIdKlienti .MappingName = "ID_KLIENTI_STR";
				colIdKlienti .Width = 0;
				colIdKlienti .NullText = "";
				
				DataGridTekstBoxColumn colPergjegjes = new DataGridTekstBoxColumn();
				colPergjegjes .HeaderText = "Pergjegjes";
				colPergjegjes .MappingName = "PERGJEGJES";
				colPergjegjes .Width = 0;
				colPergjegjes .NullText = "";

				DataGridTekstBoxColumn colMinData = new DataGridTekstBoxColumn();
				colMinData .HeaderText = "MinData";
				colMinData .MappingName = "MINDATA";
				colMinData .Width = 0;
				colMinData .NullText = "";

				DataGridTekstBoxColumn colMaxData = new DataGridTekstBoxColumn();
				colMaxData .HeaderText = "MaxData";
				colMaxData .MappingName = "MAXDATA";
				colMaxData .Width = 0;
				colMaxData .NullText = "";

				DataGridTekstBoxColumn colKlientHoteli = new DataGridTekstBoxColumn();
				colKlientHoteli .HeaderText = "Klient hoteli";
				colKlientHoteli .MappingName = "KLIENT_HOTELI_STR";
				colKlientHoteli .Width = 0;
				colKlientHoteli .NullText = "";

				DataGridTekstBoxColumn colIdRezervimi= new DataGridTekstBoxColumn();
				colIdRezervimi.HeaderText = "Id Rezervimi";
				colIdRezervimi .MappingName = "ID_REZERVIMI_STR";
				colIdRezervimi .Width = 0;
				colIdRezervimi .NullText = "";
				
				style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{colIdDhoma, dhomaEmri, kapari,
				skonto,gjoba, colIdKlienti, emri, colDateFillimi1, colDateMbarimi1, colPergjegjes,
				colMinData, colMaxData, colKlientHoteli, colIdRezervimi});
				
				this.gridKlienti.TableStyles.Add(style);
				gridKlienti.Expand(-1);

			}
			catch (Exception ex)
			{
				return;
			}

			
		}

		private void KrijoStilgride2()
		{
			try
			{
				this.gridGrupi.TableStyles.Clear();
				DataGridTableStyle style = new DataGridTableStyle();
				style.MappingName = "KLIENTI";
				style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
				style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
				this.gridGrupi.ReadOnly = true;

				DataGridTekstBoxColumn dhomaEmri = new DataGridTekstBoxColumn();
				dhomaEmri.HeaderText = "Dhoma";
				dhomaEmri.MappingName = "DHOMA_EMRI";
				dhomaEmri.Width = 60;

				DataGridTekstBoxColumn kapari = new DataGridTekstBoxColumn();
				kapari.HeaderText = "Kapari";
				kapari.MappingName = "KAPARI";
				kapari.NullText = "0";
				kapari.Width = 0;

				DataGridTekstBoxColumn skonto = new DataGridTekstBoxColumn();
				skonto.HeaderText = "Skonto";
				skonto.MappingName = "SKONTO";
				skonto.NullText = "0";
				skonto.Width = 0;

				DataGridTekstBoxColumn gjoba = new DataGridTekstBoxColumn();
				gjoba.HeaderText = "Gjoba";
				gjoba.MappingName = "GJOBA";
				gjoba.Width = 0;

				DataGridTekstBoxColumn emri = new DataGridTekstBoxColumn();
				emri.HeaderText = "Klienti";
				emri.MappingName = "EMRI";
				emri.Width = 110;

				DataGridTekstBoxColumn colEmerGrupi= new DataGridTekstBoxColumn();
				colEmerGrupi.HeaderText = "Grupi";
				colEmerGrupi.MappingName = "GRUPI";
				colEmerGrupi.NullText = "-";
				colEmerGrupi.Width = 70;

				DataGridTekstBoxColumn colAgjensia = new DataGridTekstBoxColumn();
				colAgjensia .HeaderText = "Agjensia";
				colAgjensia .MappingName = "AGJENSIA";
				colAgjensia.NullText = "-";
				colAgjensia .Width = 70;
			
				DataGridTekstBoxColumn colDateFillimi1 = new DataGridTekstBoxColumn();
				colDateFillimi1.HeaderText = "Date Hyrje";
				colDateFillimi1.MappingName = "DATA_HYRJE_STR";
				colDateFillimi1.Width = 150;
				colDateFillimi1.NullText = "";

				DataGridTekstBoxColumn colDateMbarimi1 = new DataGridTekstBoxColumn();
				colDateMbarimi1 .HeaderText = "Date Dalje";
				colDateMbarimi1 .MappingName = "DATA_DALJE_STR";
				colDateMbarimi1 .Width = 150;
				colDateMbarimi1 .NullText = "";

				DataGridTekstBoxColumn colIdKlienti = new DataGridTekstBoxColumn();
				colIdKlienti .HeaderText = "Id klienti";
				colIdKlienti .MappingName = "ID_KLIENTI_STR";
				colIdKlienti .Width = 0;
				colIdKlienti .NullText = "";
				
				DataGridTekstBoxColumn colPergjegjes = new DataGridTekstBoxColumn();
				colPergjegjes .HeaderText = "Pergjegjes";
				colPergjegjes .MappingName = "PERGJEGJES";
				colPergjegjes .Width = 0;
				colPergjegjes .NullText = "";

				DataGridTekstBoxColumn colMinData = new DataGridTekstBoxColumn();
				colMinData .HeaderText = "MinData";
				colMinData .MappingName = "MINDATA";
				colMinData .Width = 0;
				colMinData .NullText = "";

				DataGridTekstBoxColumn colMaxData = new DataGridTekstBoxColumn();
				colMaxData .HeaderText = "MaxData";
				colMaxData .MappingName = "MAXDATA";
				colMaxData .Width = 0;
				colMaxData .NullText = "";

				DataGridTekstBoxColumn colKlientHoteli = new DataGridTekstBoxColumn();
				colKlientHoteli .HeaderText = "Klient hoteli";
				colKlientHoteli .MappingName = "KLIENT_HOTELI_STR";
				colKlientHoteli .Width = 0;
				colKlientHoteli .NullText = "";

				DataGridTekstBoxColumn colIdDhoma = new DataGridTekstBoxColumn();
				colIdDhoma .HeaderText = "Id Dhoma";
				colIdDhoma .MappingName = "ID_DHOMA_STR";
				colIdDhoma .Width = 0;
				colIdDhoma .NullText = "";
				
				DataGridTekstBoxColumn colIdGrupi = new DataGridTekstBoxColumn();
				colIdGrupi .HeaderText = "Id Grupi";
				colIdGrupi .MappingName = "ID_GRUPI";
				colIdGrupi .Width = 0;
				colIdGrupi .NullText = "";

				DataGridTekstBoxColumn colIdRezervimi= new DataGridTekstBoxColumn();
				colIdRezervimi.HeaderText = "Id Rezervimi";
				colIdRezervimi .MappingName = "ID_REZERVIMI_STR";
				colIdRezervimi .Width = 0;
				colIdRezervimi .NullText = "";

				style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{colEmerGrupi, 
				colAgjensia,  kapari, skonto, gjoba, dhomaEmri, colIdKlienti, emri, colDateFillimi1,
				colDateMbarimi1, colPergjegjes, colMinData, colMaxData, colKlientHoteli, colIdDhoma,
				colIdGrupi, colIdRezervimi});
				
				this.gridGrupi.TableStyles.Add(style);
				gridGrupi.Expand(-1);

			}
			catch (Exception ex)
			{
				return;
			}
		}

		private void MoveUp()
		{
			this.gbKlientet.Location = new Point(468, 144);
			this.btnModifikoVeprimKlient.Visible = false;
			this.btnModifikoKlient.Location = new Point(656, 396);
			this.btnEleminoKlient.Location = new Point(776, 396);
		}

		private void MoveDown()
		{
			this.gbKlientet.Location = new Point(468, 280);
			this.btnModifikoVeprimKlient.Visible = true;
			this.btnModifikoKlient.Location = new Point(656, 532);
			this.btnEleminoKlient.Location = new Point(776, 532);
		}

		private void MoveUp1()
		{
			this.gbKlientetGrupi.Location = new Point(468, 144);
			this.btnModifikoVeprimGrup.Visible = false;
			this.btnModifikoKlientGrup.Location = new Point(656, 416);
			this.btnEleminoKlientGrup.Location = new Point(776, 416);
		}

		private void MoveDown1()
		{
			this.gbKlientetGrupi.Location = new Point(468, 272);
			this.btnModifikoVeprimGrup.Visible = true;
			this.btnModifikoKlientGrup.Location = new Point(644, 544);
			this.btnEleminoKlientGrup.Location = new Point(764, 544);
		}

		/// <summary>
		/// per te shfaqur te dhenat ne griden e klienteve
		/// pasi eshte bere ndonje modifikim apo eleminim
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RefreshKlienti(object sender, System.EventArgs e)
		{
			try
			{
				InputController data = new InputController();
				if ((this.cbVlefshmeKlienti.Checked == true)&&(this.rbDatat.Checked == false) && (this.rbKlienti.Checked == false) && (this.rbDhoma.Checked == false))
				{
					if (data.KerkesaRead("ShfaqKlientHotel").Tables[0].Rows.Count > 0)
					{
						DataSet ds1 = data.KerkesaRead("ShfaqKlientHotel");
						this.gridKlienti.DataSource = ds1.Tables["KLIENTI"];
						this.gridKlienti.DataSource = ds1.Tables["KLIENTI"];
					}
					else
						this.gridKlienti.DataSource = null;
				}
				else
				{
					this.btnKerko_Click(sender, e);
				}
			}
			catch(Exception ex)
			{
				return;
			}
		}
		/// <summary>
		/// per te shfaqur te dhenat ne griden e grupit 
		/// pasi eshte bere ndonje modifikim apo eleminim
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RefreshGrupi(object sender, System.EventArgs e)
		{
			try
			{
				InputController data = new InputController();
				if ((this.cbVlefshmeGrupi.Checked == true)&&(this.rbDataGrupi.Checked == false)&&(this.rbGrupi.Checked == false)&&(this.rbDhomaGrupi.Checked == false))
				{
					if (data.KerkesaRead("ShfaqKlientGrupNeHotel").Tables[0].Rows.Count > 0)
					{
						DataSet ds1 = data.KerkesaRead("ShfaqKlientGrupNeHotel");
						this.gridGrupi.DataSource = ds1.Tables["KLIENTI"];
						this.gridGrupi.DataSource = ds1.Tables["KLIENTI"];
					}
					else
						this.gridGrupi.DataSource = null;
				}
				else
				{
					this.btnKerkoGrup_Click(sender, e);
				}
			}
			catch(Exception ex)
			{
				return;
			}
		}
	
		#endregion	

	}
}

