using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using HotelManagment.BusDatService;


namespace HotelManagment.Forms
{
	public class MerrDhome : VisionInfoSolutionLibrary.Form
	{
		#region Private Variables
		private VisionInfoSolutionLibrary.TabControl tab;
		private VisionInfoSolutionLibrary.TabPageControl tbIndivid;
		private VisionInfoSolutionLibrary.TabPageControl tbGrup;
		private VisionInfoSolutionLibrary.Label lblKategoria;
		private VisionInfoSolutionLibrary.Label lblTarga;
		private VisionInfoSolutionLibrary.Label lblEmail;
		private VisionInfoSolutionLibrary.Label lblAdresa;
		private VisionInfoSolutionLibrary.Label lblIdNo;
		private VisionInfoSolutionLibrary.Label lblID;
		private VisionInfoSolutionLibrary.Label lblMbiemri;
		private VisionInfoSolutionLibrary.Label lblNrDhoma;
		private VisionInfoSolutionLibrary.Button btnMerr;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.Label label7;
		private VisionInfoSolutionLibrary.Label label8;
		private VisionInfoSolutionLibrary.Label label10;
		private VisionInfoSolutionLibrary.Label label11;
		private VisionInfoSolutionLibrary.Label label13;
		private VisionInfoSolutionLibrary.TextBox txtEmri;
		private VisionInfoSolutionLibrary.TextBox txtMbiemri;
		private VisionInfoSolutionLibrary.TextBox txtIdNo;
		private VisionInfoSolutionLibrary.TextBox txtAdresa;
		private VisionInfoSolutionLibrary.TextBox txtTarga;
		private VisionInfoSolutionLibrary.TextBox txtEmail;
		private VisionInfoSolutionLibrary.Label label14;
		private VisionInfoSolutionLibrary.TextBox txtGrupi;
		private VisionInfoSolutionLibrary.Label lblAgjensia;
		private VisionInfoSolutionLibrary.TextBox txtAgjensia;
		private VisionInfoSolutionLibrary.Label label15;
		private VisionInfoSolutionLibrary.Label label16;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDatelindja;
		private VisionInfoSolutionLibrary.Label label17;
		private VisionInfoSolutionLibrary.Label label6;
		private VisionInfoSolutionLibrary.TextBox txtTelefoni;
		private VisionInfoSolutionLibrary.Label label18;
		private VisionInfoSolutionLibrary.DoubleCombo cmbMjetId;
		private VisionInfoSolutionLibrary.DoubleCombo cmbMjetIdGrupi;
		private VisionInfoSolutionLibrary.TextBox txtTelefoniGrupi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDatelindjaGrupi;
		private VisionInfoSolutionLibrary.TextBox txtEmailGrupi;
		private VisionInfoSolutionLibrary.TextBox txtTargaGrupi;
		private VisionInfoSolutionLibrary.TextBox txtAdresaGrupi;
		private VisionInfoSolutionLibrary.TextBox txtIdNoGrupi;
		private VisionInfoSolutionLibrary.TextBox txtMbiemriGrupi;
		private VisionInfoSolutionLibrary.TextBox txtEmriGrupi;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.Label label20;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.GroupBox groupBox3;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategoria;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhoma;
		private VisionInfoSolutionLibrary.Label lblFillimMarrje;
		private VisionInfoSolutionLibrary.Label lblMbarimMarrje;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimi;
		private System.Windows.Forms.Panel panelDhomat;
		private VisionInfoSolutionLibrary.Label label22;
		private System.Windows.Forms.Panel panelCmimi;
		private VisionInfoSolutionLibrary.Label lblCmimi;
		private VisionInfoSolutionLibrary.Label label19;
		private VisionInfoSolutionLibrary.NumericBox numKapariKlienti;
		private VisionInfoSolutionLibrary.NumericBox numCmimi;
		private VisionInfoSolutionLibrary.Button btnPagesaKlienti;
		private System.Windows.Forms.ToolTip toolTip2;
		private System.Windows.Forms.PictureBox pic;
		private VisionInfoSolutionLibrary.Button btnShtoKlient;
		private VisionInfoSolutionLibrary.GroupBox groupBox4;
		private VisionInfoSolutionLibrary.DoubleCombo cmbGrupet1;
		private VisionInfoSolutionLibrary.ComboBox comboBox1;
		private VisionInfoSolutionLibrary.ComboBox comboBox2;
		private VisionInfoSolutionLibrary.Label label21;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategoriaGrupi;
		private VisionInfoSolutionLibrary.ComboBox comboBox3;
		private VisionInfoSolutionLibrary.ComboBox comboBox4;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.Label label12;
		private VisionInfoSolutionLibrary.Label label4;
		private VisionInfoSolutionLibrary.Label label9;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimiGrupi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimiGrupi;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhomaGrupi;
		private VisionInfoSolutionLibrary.ComboBox comboBox5;
		private VisionInfoSolutionLibrary.ComboBox comboBox6;
		private VisionInfoSolutionLibrary.Button btnElemino;
		private VisionInfoSolutionLibrary.Button btnModifiko;
		private VisionInfoSolutionLibrary.Button btnShto;
		private VisionInfoSolutionLibrary.Label label23;
		private VisionInfoSolutionLibrary.Label label1;
		private System.Windows.Forms.Panel panelDhomatGrupi;
		private VisionInfoSolutionLibrary.NumericBox numCmimiGrup;
		private VisionInfoSolutionLibrary.Button btnPagesaGrupi;
		private VisionInfoSolutionLibrary.NumericBox numKapariGrupi;
		private System.Windows.Forms.Panel panelCmimiGrupi;
		private VisionInfoSolutionLibrary.Button btnShtoKlGrupi;
		private VisionInfoSolutionLibrary.Button btnMerrDhomeGrupi;
		private VisionInfoSolutionLibrary.DoubleCombo cmbGrupet;
		private VisionInfoSolutionLibrary.Label lblCmimiGrupi;
		private VisionInfoSolutionLibrary.Label lblKapariGrupi;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.Label label24;
		private VisionInfoSolutionLibrary.TextBox txtVendlindjaKlienti;
		private VisionInfoSolutionLibrary.TextBox txtShtetesiaKlienti;
		private VisionInfoSolutionLibrary.Label label25;
		private VisionInfoSolutionLibrary.Label label26;
		private VisionInfoSolutionLibrary.TextBox txtVendlindjaGrupi;
		private VisionInfoSolutionLibrary.TextBox txtShtetesiaGrupi;
		private VisionInfoSolutionLibrary.Label label27;
		private VisionInfoSolutionLibrary.Label label28;
		private VisionInfoSolutionLibrary.DoubleCombo cmbPagesaKlienti;
		private VisionInfoSolutionLibrary.ComboBox comboBox7;
		private VisionInfoSolutionLibrary.ComboBox comboBox8;
		private VisionInfoSolutionLibrary.Label label29;
		private VisionInfoSolutionLibrary.DoubleCombo cmbPagesaGrupi;
		private VisionInfoSolutionLibrary.GroupBox gbKlientet;
		private int dhomaGrupiCift;
		private DataSet dsKlienti;
		private int nrKrevat;
		private int nrKrevatZene = 0;
		private int i = 0;
		private int nrKlientShtese = 0;
		private DataSet dsKlientiGrupi;
		private int nrKrevatGrupi;
		private int nrKrevatZeneGrupi = 0;
		private int iG = 0;
		private int nrKlientShteseGrupi = 0;
		private int idKategoria;
		private VisionInfoSolutionLibrary.Label label30;
		private VisionInfoSolutionLibrary.TextBox txtEmailGr;
		private int dhomaKlientiCift;
		private VisionInfoSolutionLibrary.Button btnSkano;
		private VisionInfoSolutionLibrary.Button btnSkanoGrup;
		private int idRezervimi;
		#endregion

		#region Constructors and Destructors
		public MerrDhome()
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
			this.tab = new VisionInfoSolutionLibrary.TabControl();
			this.tbIndivid = new VisionInfoSolutionLibrary.TabPageControl();
			this.btnSkano = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox3 = new VisionInfoSolutionLibrary.GroupBox();
			this.panelCmimi = new System.Windows.Forms.Panel();
			this.cmbPagesaKlienti = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label28 = new VisionInfoSolutionLibrary.Label();
			this.lblCmimi = new VisionInfoSolutionLibrary.Label();
			this.label19 = new VisionInfoSolutionLibrary.Label();
			this.numKapariKlienti = new VisionInfoSolutionLibrary.NumericBox();
			this.numCmimi = new VisionInfoSolutionLibrary.NumericBox();
			this.btnPagesaKlienti = new VisionInfoSolutionLibrary.Button(this.components);
			this.label22 = new VisionInfoSolutionLibrary.Label();
			this.panelDhomat = new System.Windows.Forms.Panel();
			this.lblFillimMarrje = new VisionInfoSolutionLibrary.Label();
			this.lblMbarimMarrje = new VisionInfoSolutionLibrary.Label();
			this.dtpFillimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpMbarimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.cmbDhoma = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbKategoria = new VisionInfoSolutionLibrary.DoubleCombo();
			this.lblKategoria = new VisionInfoSolutionLibrary.Label();
			this.lblNrDhoma = new VisionInfoSolutionLibrary.Label();
			this.btnMerr = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbKlientet = new VisionInfoSolutionLibrary.GroupBox();
			this.label27 = new VisionInfoSolutionLibrary.Label();
			this.txtVendlindjaKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.label24 = new VisionInfoSolutionLibrary.Label();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.btnShtoKlient = new VisionInfoSolutionLibrary.Button(this.components);
			this.cmbMjetId = new VisionInfoSolutionLibrary.DoubleCombo();
			this.txtTelefoni = new VisionInfoSolutionLibrary.TextBox();
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.dtpDatelindja = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label16 = new VisionInfoSolutionLibrary.Label();
			this.txtEmail = new VisionInfoSolutionLibrary.TextBox();
			this.txtTarga = new VisionInfoSolutionLibrary.TextBox();
			this.txtAdresa = new VisionInfoSolutionLibrary.TextBox();
			this.txtIdNo = new VisionInfoSolutionLibrary.TextBox();
			this.txtMbiemri = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
			this.lblTarga = new VisionInfoSolutionLibrary.Label();
			this.lblEmail = new VisionInfoSolutionLibrary.Label();
			this.lblAdresa = new VisionInfoSolutionLibrary.Label();
			this.lblIdNo = new VisionInfoSolutionLibrary.Label();
			this.lblID = new VisionInfoSolutionLibrary.Label();
			this.lblMbiemri = new VisionInfoSolutionLibrary.Label();
			this.txtShtetesiaKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.tbGrup = new VisionInfoSolutionLibrary.TabPageControl();
			this.btnSkanoGrup = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnMerrDhomeGrupi = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox4 = new VisionInfoSolutionLibrary.GroupBox();
			this.panelDhomatGrupi = new System.Windows.Forms.Panel();
			this.panelCmimiGrupi = new System.Windows.Forms.Panel();
			this.cmbPagesaGrupi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox7 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox8 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.label29 = new VisionInfoSolutionLibrary.Label();
			this.lblCmimiGrupi = new VisionInfoSolutionLibrary.Label();
			this.numCmimiGrup = new VisionInfoSolutionLibrary.NumericBox();
			this.numKapariGrupi = new VisionInfoSolutionLibrary.NumericBox();
			this.lblKapariGrupi = new VisionInfoSolutionLibrary.Label();
			this.btnPagesaGrupi = new VisionInfoSolutionLibrary.Button(this.components);
			this.label23 = new VisionInfoSolutionLibrary.Label();
			this.cmbDhomaGrupi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox5 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox6 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.cmbKategoriaGrupi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox3 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox4 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.label12 = new VisionInfoSolutionLibrary.Label();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.label9 = new VisionInfoSolutionLibrary.Label();
			this.dtpMbarimiGrupi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpFillimiGrupi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.cmbGrupet1 = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox1 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox2 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.label21 = new VisionInfoSolutionLibrary.Label();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.txtEmailGr = new VisionInfoSolutionLibrary.TextBox();
			this.label30 = new VisionInfoSolutionLibrary.Label();
			this.cmbGrupet = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label20 = new VisionInfoSolutionLibrary.Label();
			this.txtGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.label14 = new VisionInfoSolutionLibrary.Label();
			this.txtAgjensia = new VisionInfoSolutionLibrary.TextBox();
			this.lblAgjensia = new VisionInfoSolutionLibrary.Label();
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.txtVendlindjaGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.label26 = new VisionInfoSolutionLibrary.Label();
			this.label25 = new VisionInfoSolutionLibrary.Label();
			this.cmbMjetIdGrupi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.txtTelefoniGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.label18 = new VisionInfoSolutionLibrary.Label();
			this.dtpDatelindjaGrupi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label17 = new VisionInfoSolutionLibrary.Label();
			this.label15 = new VisionInfoSolutionLibrary.Label();
			this.txtEmailGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtTargaGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtAdresaGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtIdNoGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtMbiemriGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmriGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.label7 = new VisionInfoSolutionLibrary.Label();
			this.label8 = new VisionInfoSolutionLibrary.Label();
			this.label10 = new VisionInfoSolutionLibrary.Label();
			this.label11 = new VisionInfoSolutionLibrary.Label();
			this.label13 = new VisionInfoSolutionLibrary.Label();
			this.btnShtoKlGrupi = new VisionInfoSolutionLibrary.Button(this.components);
			this.txtShtetesiaGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.btnElemino = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifiko = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnShto = new VisionInfoSolutionLibrary.Button(this.components);
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
			this.pic = new System.Windows.Forms.PictureBox();
			this.dsKlienti = new System.Data.DataSet();
			this.dsKlientiGrupi = new System.Data.DataSet();
			this.tab.SuspendLayout();
			this.tbIndivid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.panelCmimi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbKlientet)).BeginInit();
			this.gbKlientet.SuspendLayout();
			this.tbGrup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.panelCmimiGrupi.SuspendLayout();
			this.cmbPagesaGrupi.SuspendLayout();
			this.cmbDhomaGrupi.SuspendLayout();
			this.cmbKategoriaGrupi.SuspendLayout();
			this.cmbGrupet1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsKlienti)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsKlientiGrupi)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1011, 24);
			// 
			// tab
			// 
			this.tab.Controls.Add(this.tbIndivid);
			this.tab.Controls.Add(this.tbGrup);
			this.tab.Cursor = System.Windows.Forms.Cursors.Default;
			this.tab.Location = new System.Drawing.Point(0, 24);
			this.tab.Name = "tab";
			this.tab.Padding = new System.Drawing.Point(0, 0);
			this.tab.SelectedIndex = 0;
			this.tab.Size = new System.Drawing.Size(1011, 609);
			this.tab.TabIndex = 1;
			this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
			// 
			// tbIndivid
			// 
			this.tbIndivid.BackColor = System.Drawing.SystemColors.Control;
			this.tbIndivid.Controls.Add(this.btnSkano);
			this.tbIndivid.Controls.Add(this.groupBox3);
			this.tbIndivid.Controls.Add(this.btnMerr);
			this.tbIndivid.Controls.Add(this.gbKlientet);
			this.tbIndivid.DefaultErrorMessage = null;
			this.tbIndivid.EnableValidation = true;
			this.tbIndivid.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tbIndivid.IsValid = false;
			this.tbIndivid.Location = new System.Drawing.Point(4, 22);
			this.tbIndivid.Name = "tbIndivid";
			this.tbIndivid.Size = new System.Drawing.Size(1003, 583);
			this.tbIndivid.TabIndex = 0;
			this.tbIndivid.Text = "Fut klient ne dhome";
			// 
			// btnSkano
			// 
			this.btnSkano.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSkano.DoValidation = true;
			this.btnSkano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSkano.Location = new System.Drawing.Point(668, 120);
			this.btnSkano.Name = "btnSkano";
			this.btnSkano.Size = new System.Drawing.Size(90, 21);
			this.btnSkano.TabIndex = 91;
			this.btnSkano.Text = "Skano";
			this.toolTip2.SetToolTip(this.btnSkano, "Skano pasaporten dhe merr te dhenat per klientin");
			this.btnSkano.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnSkano.Click += new System.EventHandler(this.btnSkano_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.panelCmimi);
			this.groupBox3.Controls.Add(this.label22);
			this.groupBox3.Controls.Add(this.panelDhomat);
			this.groupBox3.Controls.Add(this.lblFillimMarrje);
			this.groupBox3.Controls.Add(this.lblMbarimMarrje);
			this.groupBox3.Controls.Add(this.dtpFillimi);
			this.groupBox3.Controls.Add(this.dtpMbarimi);
			this.groupBox3.Controls.Add(this.cmbDhoma);
			this.groupBox3.Controls.Add(this.cmbKategoria);
			this.groupBox3.Controls.Add(this.lblKategoria);
			this.groupBox3.Controls.Add(this.lblNrDhoma);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(10, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(298, 380);
			this.groupBox3.TabIndex = 36;
			this.groupBox3.Text = "Caktimi i dhomes";
			this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// panelCmimi
			// 
			this.panelCmimi.Controls.Add(this.cmbPagesaKlienti);
			this.panelCmimi.Controls.Add(this.label28);
			this.panelCmimi.Controls.Add(this.lblCmimi);
			this.panelCmimi.Controls.Add(this.label19);
			this.panelCmimi.Controls.Add(this.numKapariKlienti);
			this.panelCmimi.Controls.Add(this.numCmimi);
			this.panelCmimi.Controls.Add(this.btnPagesaKlienti);
			this.panelCmimi.Location = new System.Drawing.Point(4, 168);
			this.panelCmimi.Name = "panelCmimi";
			this.panelCmimi.Size = new System.Drawing.Size(288, 128);
			this.panelCmimi.TabIndex = 83;
			this.panelCmimi.Visible = false;
			// 
			// cmbPagesaKlienti
			// 
			this.cmbPagesaKlienti.BackColor = System.Drawing.Color.Transparent;
			this.cmbPagesaKlienti.DefaultErrorMessage = null;
			this.cmbPagesaKlienti.IsValid = false;
			this.cmbPagesaKlienti.Kolone1Vlere = null;
			this.cmbPagesaKlienti.Kolone2Vlere = null;
			this.cmbPagesaKlienti.Location = new System.Drawing.Point(88, 60);
			this.cmbPagesaKlienti.Name = "cmbPagesaKlienti";
			this.cmbPagesaKlienti.ReadOnly = false;
			this.cmbPagesaKlienti.Required = true;
			this.cmbPagesaKlienti.Size = new System.Drawing.Size(180, 21);
			this.cmbPagesaKlienti.SkipValidation = false;
			this.cmbPagesaKlienti.TabIndex = 77;
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(12, 64);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(68, 20);
			this.label28.TabIndex = 78;
			this.label28.Text = "Pagesa ne";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCmimi
			// 
			this.lblCmimi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblCmimi.Location = new System.Drawing.Point(28, 4);
			this.lblCmimi.Name = "lblCmimi";
			this.lblCmimi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCmimi.Size = new System.Drawing.Size(52, 20);
			this.lblCmimi.TabIndex = 73;
			this.lblCmimi.Text = "Cmimi";
			// 
			// label19
			// 
			this.label19.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label19.Location = new System.Drawing.Point(36, 36);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(44, 20);
			this.label19.TabIndex = 74;
			this.label19.Text = "Kapari";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numKapariKlienti
			// 
			this.numKapariKlienti.AutoSize = false;
			this.numKapariKlienti.DefaultErrorMessage = "Caktoni nje vlere ose 0 per kaparin!";
			this.numKapariKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numKapariKlienti.DigitsAfterDecimalPoint = 0;
			this.numKapariKlienti.FixedLength = false;
			this.numKapariKlienti.IsValid = false;
			this.numKapariKlienti.KeepFocus = false;
			this.numKapariKlienti.Location = new System.Drawing.Point(88, 32);
			this.numKapariKlienti.Name = "numKapariKlienti";
			this.numKapariKlienti.OnlyPositive = true;
			this.numKapariKlienti.Required = true;
			this.numKapariKlienti.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.numKapariKlienti.Size = new System.Drawing.Size(180, 21);
			this.numKapariKlienti.TabIndex = 76;
			this.numKapariKlienti.Text = "";
			this.numKapariKlienti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// numCmimi
			// 
			this.numCmimi.AutoSize = false;
			this.numCmimi.DefaultErrorMessage = "";
			this.numCmimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numCmimi.DigitsAfterDecimalPoint = 0;
			this.numCmimi.FixedLength = false;
			this.numCmimi.IsValid = false;
			this.numCmimi.KeepFocus = false;
			this.numCmimi.Location = new System.Drawing.Point(88, 4);
			this.numCmimi.Name = "numCmimi";
			this.numCmimi.OnlyPositive = true;
			this.numCmimi.ReadOnly = true;
			this.numCmimi.Required = false;
			this.numCmimi.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimi.Size = new System.Drawing.Size(180, 21);
			this.numCmimi.TabIndex = 75;
			this.numCmimi.Text = "";
			this.numCmimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnPagesaKlienti
			// 
			this.btnPagesaKlienti.BackColor = System.Drawing.Color.Blue;
			this.btnPagesaKlienti.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPagesaKlienti.DoValidation = true;
			this.btnPagesaKlienti.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnPagesaKlienti.Location = new System.Drawing.Point(116, 92);
			this.btnPagesaKlienti.Name = "btnPagesaKlienti";
			this.btnPagesaKlienti.Size = new System.Drawing.Size(101, 21);
			this.btnPagesaKlienti.TabIndex = 77;
			this.btnPagesaKlienti.Text = "Llogarit pagesen";
			this.toolTips.SetToolTip(this.btnPagesaKlienti, "Llogarit paraprakisht pagesen per dhomen!");
			this.btnPagesaKlienti.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnPagesaKlienti.Click += new System.EventHandler(this.btnPagesaKlienti_Click_1);
			// 
			// label22
			// 
			this.label22.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label22.Location = new System.Drawing.Point(28, 144);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(56, 16);
			this.label22.TabIndex = 82;
			this.label22.Text = "Kapaciteti";
			this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.label22.Visible = false;
			// 
			// panelDhomat
			// 
			this.panelDhomat.BackColor = System.Drawing.Color.Transparent;
			this.panelDhomat.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panelDhomat.Location = new System.Drawing.Point(88, 132);
			this.panelDhomat.Name = "panelDhomat";
			this.panelDhomat.Size = new System.Drawing.Size(196, 36);
			this.panelDhomat.TabIndex = 81;
			// 
			// lblFillimMarrje
			// 
			this.lblFillimMarrje.BackColor = System.Drawing.SystemColors.Control;
			this.lblFillimMarrje.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblFillimMarrje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblFillimMarrje.Location = new System.Drawing.Point(8, 24);
			this.lblFillimMarrje.Name = "lblFillimMarrje";
			this.lblFillimMarrje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblFillimMarrje.Size = new System.Drawing.Size(76, 20);
			this.lblFillimMarrje.TabIndex = 77;
			this.lblFillimMarrje.Text = "Date fillimi";
			// 
			// lblMbarimMarrje
			// 
			this.lblMbarimMarrje.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblMbarimMarrje.Location = new System.Drawing.Point(8, 52);
			this.lblMbarimMarrje.Name = "lblMbarimMarrje";
			this.lblMbarimMarrje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblMbarimMarrje.Size = new System.Drawing.Size(76, 20);
			this.lblMbarimMarrje.TabIndex = 78;
			this.lblMbarimMarrje.Text = "Date mbarimi";
			// 
			// dtpFillimi
			// 
			this.dtpFillimi.BackColor = System.Drawing.Color.White;
			this.dtpFillimi.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpFillimi.DefaultErrorMessage = "Duhet te zgjidhni nje vlere per marrjen e dhomes!";
			this.dtpFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimi.IsValid = true;
			this.dtpFillimi.Location = new System.Drawing.Point(92, 20);
			this.dtpFillimi.Name = "dtpFillimi";
			this.dtpFillimi.Required = true;
			this.dtpFillimi.ShowCheckBox = true;
			this.dtpFillimi.ShowUpDown = true;
			this.dtpFillimi.Size = new System.Drawing.Size(180, 20);
			this.dtpFillimi.TabIndex = 31;
			this.dtpFillimi.Value = new System.DateTime(2005, 8, 31, 11, 42, 0, 0);
			this.dtpFillimi.ValueChanged += new System.EventHandler(this.dtpFillimi_ValueChanged);
			// 
			// dtpMbarimi
			// 
			this.dtpMbarimi.BackColor = System.Drawing.Color.White;
			this.dtpMbarimi.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpMbarimi.DefaultErrorMessage = "Duhet te zgjidhni nje vlere per dorezimin e dhomes!";
			this.dtpMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimi.IsValid = true;
			this.dtpMbarimi.Location = new System.Drawing.Point(92, 48);
			this.dtpMbarimi.Name = "dtpMbarimi";
			this.dtpMbarimi.Required = true;
			this.dtpMbarimi.ShowCheckBox = true;
			this.dtpMbarimi.ShowUpDown = true;
			this.dtpMbarimi.Size = new System.Drawing.Size(180, 20);
			this.dtpMbarimi.TabIndex = 31;
			this.dtpMbarimi.Value = new System.DateTime(2005, 8, 31, 11, 42, 0, 0);
			this.dtpMbarimi.ValueChanged += new System.EventHandler(this.dtpMbarimi_ValueChanged);
			// 
			// cmbDhoma
			// 
			this.cmbDhoma.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhoma.DefaultErrorMessage = "Zgjidhni me pare dhomen qe do t\'i caktoni klinteve!";
			this.cmbDhoma.IsValid = false;
			this.cmbDhoma.Kolone1Vlere = null;
			this.cmbDhoma.Kolone2Vlere = null;
			this.cmbDhoma.Location = new System.Drawing.Point(92, 108);
			this.cmbDhoma.Name = "cmbDhoma";
			this.cmbDhoma.ReadOnly = false;
			this.cmbDhoma.Required = true;
			this.cmbDhoma.Size = new System.Drawing.Size(180, 21);
			this.cmbDhoma.SkipValidation = false;
			this.cmbDhoma.TabIndex = 74;
			this.cmbDhoma.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbDhoma_SelectedIndexChanged);
			// 
			// cmbKategoria
			// 
			this.cmbKategoria.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategoria.DefaultErrorMessage = "Zgjidhni me pare nje prej kategorive!";
			this.cmbKategoria.IsValid = false;
			this.cmbKategoria.Kolone1Vlere = null;
			this.cmbKategoria.Kolone2Vlere = null;
			this.cmbKategoria.Location = new System.Drawing.Point(92, 76);
			this.cmbKategoria.Name = "cmbKategoria";
			this.cmbKategoria.ReadOnly = false;
			this.cmbKategoria.Required = true;
			this.cmbKategoria.Size = new System.Drawing.Size(180, 21);
			this.cmbKategoria.SkipValidation = false;
			this.cmbKategoria.TabIndex = 73;
			this.cmbKategoria.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategoria_SelectedIndexChanged);
			// 
			// lblKategoria
			// 
			this.lblKategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblKategoria.Location = new System.Drawing.Point(12, 84);
			this.lblKategoria.Name = "lblKategoria";
			this.lblKategoria.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblKategoria.Size = new System.Drawing.Size(72, 20);
			this.lblKategoria.TabIndex = 31;
			this.lblKategoria.Text = "Kategoria";
			// 
			// lblNrDhoma
			// 
			this.lblNrDhoma.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblNrDhoma.Location = new System.Drawing.Point(32, 112);
			this.lblNrDhoma.Name = "lblNrDhoma";
			this.lblNrDhoma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblNrDhoma.Size = new System.Drawing.Size(52, 20);
			this.lblNrDhoma.TabIndex = 4;
			this.lblNrDhoma.Text = "Dhoma";
			// 
			// btnMerr
			// 
			this.btnMerr.BackColor = System.Drawing.Color.Blue;
			this.btnMerr.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMerr.DoValidation = false;
			this.btnMerr.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnMerr.Location = new System.Drawing.Point(120, 396);
			this.btnMerr.Name = "btnMerr";
			this.btnMerr.Size = new System.Drawing.Size(90, 21);
			this.btnMerr.TabIndex = 90;
			this.btnMerr.Text = "Merr dhome";
			this.toolTips.SetToolTip(this.btnMerr, "Fut ne dhome klientet e caktuar me siper!");
			this.btnMerr.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnMerr.Click += new System.EventHandler(this.btnMerr_Click);
			// 
			// gbKlientet
			// 
			this.gbKlientet.BackColor = System.Drawing.Color.Transparent;
			this.gbKlientet.Controls.Add(this.label27);
			this.gbKlientet.Controls.Add(this.txtVendlindjaKlienti);
			this.gbKlientet.Controls.Add(this.label24);
			this.gbKlientet.Controls.Add(this.label3);
			this.gbKlientet.Controls.Add(this.btnShtoKlient);
			this.gbKlientet.Controls.Add(this.cmbMjetId);
			this.gbKlientet.Controls.Add(this.txtTelefoni);
			this.gbKlientet.Controls.Add(this.label6);
			this.gbKlientet.Controls.Add(this.dtpDatelindja);
			this.gbKlientet.Controls.Add(this.label16);
			this.gbKlientet.Controls.Add(this.txtEmail);
			this.gbKlientet.Controls.Add(this.txtTarga);
			this.gbKlientet.Controls.Add(this.txtAdresa);
			this.gbKlientet.Controls.Add(this.txtIdNo);
			this.gbKlientet.Controls.Add(this.txtMbiemri);
			this.gbKlientet.Controls.Add(this.txtEmri);
			this.gbKlientet.Controls.Add(this.lblTarga);
			this.gbKlientet.Controls.Add(this.lblEmail);
			this.gbKlientet.Controls.Add(this.lblAdresa);
			this.gbKlientet.Controls.Add(this.lblIdNo);
			this.gbKlientet.Controls.Add(this.lblID);
			this.gbKlientet.Controls.Add(this.lblMbiemri);
			this.gbKlientet.Controls.Add(this.txtShtetesiaKlienti);
			this.gbKlientet.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbKlientet.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gbKlientet.Location = new System.Drawing.Point(320, 8);
			this.gbKlientet.Name = "gbKlientet";
			this.gbKlientet.Size = new System.Drawing.Size(308, 380);
			this.gbKlientet.TabIndex = 8;
			this.gbKlientet.Text = "Te dhenat per futjen e klientit ne dhome";
			this.gbKlientet.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(28, 24);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(76, 20);
			this.label27.TabIndex = 76;
			this.label27.Text = "Emri";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtVendlindjaKlienti
			// 
			this.txtVendlindjaKlienti.AutoSize = false;
			this.txtVendlindjaKlienti.DefaultErrorMessage = "";
			this.txtVendlindjaKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtVendlindjaKlienti.FixedLength = false;
			this.txtVendlindjaKlienti.IsValid = true;
			this.txtVendlindjaKlienti.Location = new System.Drawing.Point(112, 100);
			this.txtVendlindjaKlienti.Name = "txtVendlindjaKlienti";
			this.txtVendlindjaKlienti.Required = false;
			this.txtVendlindjaKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtVendlindjaKlienti.Size = new System.Drawing.Size(180, 21);
			this.txtVendlindjaKlienti.TabIndex = 81;
			this.txtVendlindjaKlienti.Text = "";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(4, 128);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(100, 20);
			this.label24.TabIndex = 74;
			this.label24.Text = "Shtetesia";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(4, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 73;
			this.label3.Text = "Vendlindja";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnShtoKlient
			// 
			this.btnShtoKlient.BackColor = System.Drawing.Color.Blue;
			this.btnShtoKlient.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShtoKlient.DoValidation = true;
			this.btnShtoKlient.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShtoKlient.Location = new System.Drawing.Point(148, 336);
			this.btnShtoKlient.Name = "btnShtoKlient";
			this.btnShtoKlient.Size = new System.Drawing.Size(90, 21);
			this.btnShtoKlient.TabIndex = 89;
			this.btnShtoKlient.Text = "Shto Klient";
			this.toolTips.SetToolTip(this.btnShtoKlient, "Shton klientin me te dhenat e mesiperme ne listen\r\n e klienteve qe do te futen ne" +
				" dhomen e zgjedhur!");
			this.btnShtoKlient.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShtoKlient.Click += new System.EventHandler(this.btnShtoKlient_Click);
			// 
			// cmbMjetId
			// 
			this.cmbMjetId.BackColor = System.Drawing.Color.Transparent;
			this.cmbMjetId.DefaultErrorMessage = "Zgjidhni nje menyre identifikimi!";
			this.cmbMjetId.IsValid = false;
			this.cmbMjetId.Kolone1Vlere = null;
			this.cmbMjetId.Kolone2Vlere = null;
			this.cmbMjetId.Location = new System.Drawing.Point(112, 156);
			this.cmbMjetId.Name = "cmbMjetId";
			this.cmbMjetId.ReadOnly = false;
			this.cmbMjetId.Required = true;
			this.cmbMjetId.Size = new System.Drawing.Size(180, 21);
			this.cmbMjetId.SkipValidation = false;
			this.cmbMjetId.TabIndex = 83;
			// 
			// txtTelefoni
			// 
			this.txtTelefoni.AutoSize = false;
			this.txtTelefoni.DefaultErrorMessage = "";
			this.txtTelefoni.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTelefoni.FixedLength = false;
			this.txtTelefoni.IsValid = true;
			this.txtTelefoni.Location = new System.Drawing.Point(112, 216);
			this.txtTelefoni.Name = "txtTelefoni";
			this.txtTelefoni.Required = false;
			this.txtTelefoni.RequiredControlColor = System.Drawing.Color.White;
			this.txtTelefoni.Size = new System.Drawing.Size(180, 21);
			this.txtTelefoni.TabIndex = 85;
			this.txtTelefoni.Text = "";
			// 
			// label6
			// 
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Location = new System.Drawing.Point(28, 220);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 20);
			this.label6.TabIndex = 49;
			this.label6.Text = "Numer telefoni";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDatelindja
			// 
			this.dtpDatelindja.BackColor = System.Drawing.Color.White;
			this.dtpDatelindja.CustomFormat = "dd.MM.yyyy";
			this.dtpDatelindja.DefaultErrorMessage = "";
			this.dtpDatelindja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDatelindja.IsValid = true;
			this.dtpDatelindja.Location = new System.Drawing.Point(112, 76);
			this.dtpDatelindja.Name = "dtpDatelindja";
			this.dtpDatelindja.Required = false;
			this.dtpDatelindja.ShowCheckBox = true;
			this.dtpDatelindja.ShowUpDown = true;
			this.dtpDatelindja.Size = new System.Drawing.Size(180, 20);
			this.dtpDatelindja.TabIndex = 80;
			this.dtpDatelindja.Value = new System.DateTime(2005, 8, 31, 11, 42, 0, 0);
			// 
			// label16
			// 
			this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label16.Location = new System.Drawing.Point(28, 78);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(76, 20);
			this.label16.TabIndex = 47;
			this.label16.Text = "Datelindja";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmail
			// 
			this.txtEmail.AutoSize = false;
			this.txtEmail.DefaultErrorMessage = "";
			this.txtEmail.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmail.FixedLength = false;
			this.txtEmail.IsValid = true;
			this.txtEmail.Location = new System.Drawing.Point(112, 300);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Required = false;
			this.txtEmail.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmail.Size = new System.Drawing.Size(180, 21);
			this.txtEmail.TabIndex = 88;
			this.txtEmail.Text = "";
			// 
			// txtTarga
			// 
			this.txtTarga.AutoSize = false;
			this.txtTarga.DefaultErrorMessage = "";
			this.txtTarga.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTarga.FixedLength = false;
			this.txtTarga.IsValid = true;
			this.txtTarga.Location = new System.Drawing.Point(112, 272);
			this.txtTarga.Name = "txtTarga";
			this.txtTarga.Required = false;
			this.txtTarga.RequiredControlColor = System.Drawing.Color.White;
			this.txtTarga.Size = new System.Drawing.Size(180, 21);
			this.txtTarga.TabIndex = 87;
			this.txtTarga.Text = "";
			// 
			// txtAdresa
			// 
			this.txtAdresa.AutoSize = false;
			this.txtAdresa.DefaultErrorMessage = "";
			this.txtAdresa.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAdresa.FixedLength = false;
			this.txtAdresa.IsValid = true;
			this.txtAdresa.Location = new System.Drawing.Point(112, 244);
			this.txtAdresa.Name = "txtAdresa";
			this.txtAdresa.Required = false;
			this.txtAdresa.RequiredControlColor = System.Drawing.Color.White;
			this.txtAdresa.Size = new System.Drawing.Size(180, 21);
			this.txtAdresa.TabIndex = 86;
			this.txtAdresa.Text = "";
			// 
			// txtIdNo
			// 
			this.txtIdNo.AutoSize = false;
			this.txtIdNo.DefaultErrorMessage = "Ju duhet te jepni numrin e identifikimit!";
			this.txtIdNo.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtIdNo.FixedLength = false;
			this.txtIdNo.IsValid = false;
			this.txtIdNo.Location = new System.Drawing.Point(112, 188);
			this.txtIdNo.Name = "txtIdNo";
			this.txtIdNo.Required = true;
			this.txtIdNo.RequiredControlColor = System.Drawing.Color.White;
			this.txtIdNo.Size = new System.Drawing.Size(180, 21);
			this.txtIdNo.TabIndex = 84;
			this.txtIdNo.Text = "";
			// 
			// txtMbiemri
			// 
			this.txtMbiemri.AutoSize = false;
			this.txtMbiemri.DefaultErrorMessage = "Jepni mbiemrin e klientit!";
			this.txtMbiemri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemri.FixedLength = false;
			this.txtMbiemri.IsValid = false;
			this.txtMbiemri.Location = new System.Drawing.Point(112, 48);
			this.txtMbiemri.Name = "txtMbiemri";
			this.txtMbiemri.Required = true;
			this.txtMbiemri.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemri.Size = new System.Drawing.Size(180, 21);
			this.txtMbiemri.TabIndex = 79;
			this.txtMbiemri.Text = "";
			// 
			// txtEmri
			// 
			this.txtEmri.AutoSize = false;
			this.txtEmri.DefaultErrorMessage = "Jepni emrin e klientit!";
			this.txtEmri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri.FixedLength = false;
			this.txtEmri.IsValid = false;
			this.txtEmri.Location = new System.Drawing.Point(112, 20);
			this.txtEmri.Name = "txtEmri";
			this.txtEmri.Required = true;
			this.txtEmri.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.txtEmri.Size = new System.Drawing.Size(180, 21);
			this.txtEmri.TabIndex = 78;
			this.txtEmri.Text = "";
			// 
			// lblTarga
			// 
			this.lblTarga.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblTarga.Location = new System.Drawing.Point(4, 276);
			this.lblTarga.Name = "lblTarga";
			this.lblTarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblTarga.Size = new System.Drawing.Size(100, 20);
			this.lblTarga.TabIndex = 27;
			this.lblTarga.Text = "Targa e automjetit";
			// 
			// lblEmail
			// 
			this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmail.Location = new System.Drawing.Point(48, 304);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblEmail.Size = new System.Drawing.Size(56, 20);
			this.lblEmail.TabIndex = 25;
			this.lblEmail.Text = "E-Mail";
			// 
			// lblAdresa
			// 
			this.lblAdresa.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblAdresa.Location = new System.Drawing.Point(48, 248);
			this.lblAdresa.Name = "lblAdresa";
			this.lblAdresa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblAdresa.Size = new System.Drawing.Size(56, 20);
			this.lblAdresa.TabIndex = 24;
			this.lblAdresa.Text = "Adresa";
			// 
			// lblIdNo
			// 
			this.lblIdNo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblIdNo.Location = new System.Drawing.Point(8, 192);
			this.lblIdNo.Name = "lblIdNo";
			this.lblIdNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblIdNo.Size = new System.Drawing.Size(96, 20);
			this.lblIdNo.TabIndex = 199;
			this.lblIdNo.Text = "Numri i identifikimit";
			// 
			// lblID
			// 
			this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblID.Location = new System.Drawing.Point(8, 160);
			this.lblID.Name = "lblID";
			this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblID.Size = new System.Drawing.Size(96, 20);
			this.lblID.TabIndex = 7;
			this.lblID.Text = "Mjeti i identifikimit";
			// 
			// lblMbiemri
			// 
			this.lblMbiemri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblMbiemri.Location = new System.Drawing.Point(32, 52);
			this.lblMbiemri.Name = "lblMbiemri";
			this.lblMbiemri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblMbiemri.Size = new System.Drawing.Size(72, 20);
			this.lblMbiemri.TabIndex = 6;
			this.lblMbiemri.Text = "Mbiemri";
			// 
			// txtShtetesiaKlienti
			// 
			this.txtShtetesiaKlienti.AutoSize = false;
			this.txtShtetesiaKlienti.DefaultErrorMessage = "";
			this.txtShtetesiaKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtShtetesiaKlienti.FixedLength = false;
			this.txtShtetesiaKlienti.IsValid = true;
			this.txtShtetesiaKlienti.Location = new System.Drawing.Point(112, 128);
			this.txtShtetesiaKlienti.Name = "txtShtetesiaKlienti";
			this.txtShtetesiaKlienti.Required = false;
			this.txtShtetesiaKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtShtetesiaKlienti.Size = new System.Drawing.Size(180, 21);
			this.txtShtetesiaKlienti.TabIndex = 82;
			this.txtShtetesiaKlienti.Text = "";
			// 
			// tbGrup
			// 
			this.tbGrup.BackColor = System.Drawing.SystemColors.Control;
			this.tbGrup.Controls.Add(this.btnSkanoGrup);
			this.tbGrup.Controls.Add(this.btnMerrDhomeGrupi);
			this.tbGrup.Controls.Add(this.groupBox4);
			this.tbGrup.Controls.Add(this.groupBox2);
			this.tbGrup.Controls.Add(this.groupBox1);
			this.tbGrup.Controls.Add(this.btnElemino);
			this.tbGrup.Controls.Add(this.btnModifiko);
			this.tbGrup.Controls.Add(this.btnShto);
			this.tbGrup.DefaultErrorMessage = null;
			this.tbGrup.EnableValidation = true;
			this.tbGrup.IsValid = false;
			this.tbGrup.Location = new System.Drawing.Point(4, 22);
			this.tbGrup.Name = "tbGrup";
			this.tbGrup.Size = new System.Drawing.Size(1003, 583);
			this.tbGrup.TabIndex = 1;
			this.tbGrup.Text = "Fut grup ne dhome";
			// 
			// btnSkanoGrup
			// 
			this.btnSkanoGrup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSkanoGrup.DoValidation = true;
			this.btnSkanoGrup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSkanoGrup.Location = new System.Drawing.Point(684, 268);
			this.btnSkanoGrup.Name = "btnSkanoGrup";
			this.btnSkanoGrup.Size = new System.Drawing.Size(90, 21);
			this.btnSkanoGrup.TabIndex = 45;
			this.btnSkanoGrup.Text = "Skano";
			this.toolTip2.SetToolTip(this.btnSkanoGrup, "Skano pasaporten dhe merr te dhenat per klientin");
			this.btnSkanoGrup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnSkanoGrup.Click += new System.EventHandler(this.btnSkanoGrup_Click);
			// 
			// btnMerrDhomeGrupi
			// 
			this.btnMerrDhomeGrupi.BackColor = System.Drawing.Color.Blue;
			this.btnMerrDhomeGrupi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMerrDhomeGrupi.DoValidation = false;
			this.btnMerrDhomeGrupi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnMerrDhomeGrupi.Location = new System.Drawing.Point(112, 540);
			this.btnMerrDhomeGrupi.Name = "btnMerrDhomeGrupi";
			this.btnMerrDhomeGrupi.Size = new System.Drawing.Size(90, 21);
			this.btnMerrDhomeGrupi.TabIndex = 27;
			this.btnMerrDhomeGrupi.Text = "Merr Dhome";
			this.toolTips.SetToolTip(this.btnMerrDhomeGrupi, "Fut klientet e caktuar ne dhomen e zgjedhur!");
			this.btnMerrDhomeGrupi.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnMerrDhomeGrupi.Click += new System.EventHandler(this.btnMerrDhomeGrupi_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.panelDhomatGrupi);
			this.groupBox4.Controls.Add(this.panelCmimiGrupi);
			this.groupBox4.Controls.Add(this.label23);
			this.groupBox4.Controls.Add(this.cmbDhomaGrupi);
			this.groupBox4.Controls.Add(this.cmbKategoriaGrupi);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.dtpMbarimiGrupi);
			this.groupBox4.Controls.Add(this.dtpFillimiGrupi);
			this.groupBox4.Controls.Add(this.cmbGrupet1);
			this.groupBox4.Controls.Add(this.label21);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(10, 148);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(290, 384);
			this.groupBox4.TabIndex = 44;
			this.groupBox4.Text = "Caktimi i dhomes";
			this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// panelDhomatGrupi
			// 
			this.panelDhomatGrupi.BackColor = System.Drawing.Color.Transparent;
			this.panelDhomatGrupi.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panelDhomatGrupi.Location = new System.Drawing.Point(84, 156);
			this.panelDhomatGrupi.Name = "panelDhomatGrupi";
			this.panelDhomatGrupi.Size = new System.Drawing.Size(196, 36);
			this.panelDhomatGrupi.TabIndex = 86;
			// 
			// panelCmimiGrupi
			// 
			this.panelCmimiGrupi.BackColor = System.Drawing.Color.Transparent;
			this.panelCmimiGrupi.Controls.Add(this.cmbPagesaGrupi);
			this.panelCmimiGrupi.Controls.Add(this.label29);
			this.panelCmimiGrupi.Controls.Add(this.lblCmimiGrupi);
			this.panelCmimiGrupi.Controls.Add(this.numCmimiGrup);
			this.panelCmimiGrupi.Controls.Add(this.numKapariGrupi);
			this.panelCmimiGrupi.Controls.Add(this.lblKapariGrupi);
			this.panelCmimiGrupi.Controls.Add(this.btnPagesaGrupi);
			this.panelCmimiGrupi.Location = new System.Drawing.Point(8, 208);
			this.panelCmimiGrupi.Name = "panelCmimiGrupi";
			this.panelCmimiGrupi.Size = new System.Drawing.Size(280, 128);
			this.panelCmimiGrupi.TabIndex = 88;
			this.panelCmimiGrupi.Visible = false;
			// 
			// cmbPagesaGrupi
			// 
			this.cmbPagesaGrupi.BackColor = System.Drawing.Color.LemonChiffon;
			this.cmbPagesaGrupi.Controls.Add(this.comboBox7);
			this.cmbPagesaGrupi.Controls.Add(this.comboBox8);
			this.cmbPagesaGrupi.DefaultErrorMessage = "Zgjidhni formen e pageses!";
			this.cmbPagesaGrupi.IsValid = false;
			this.cmbPagesaGrupi.Kolone1Vlere = null;
			this.cmbPagesaGrupi.Kolone2Vlere = null;
			this.cmbPagesaGrupi.Location = new System.Drawing.Point(80, 64);
			this.cmbPagesaGrupi.Name = "cmbPagesaGrupi";
			this.cmbPagesaGrupi.ReadOnly = false;
			this.cmbPagesaGrupi.Required = true;
			this.cmbPagesaGrupi.Size = new System.Drawing.Size(180, 21);
			this.cmbPagesaGrupi.SkipValidation = false;
			this.cmbPagesaGrupi.TabIndex = 14;
			// 
			// comboBox7
			// 
			this.comboBox7.DefaultErrorMessage = null;
			this.comboBox7.IsValid = false;
			this.comboBox7.Location = new System.Drawing.Point(60, 0);
			this.comboBox7.Name = "comboBox7";
			this.comboBox7.Required = false;
			this.comboBox7.Size = new System.Drawing.Size(16, 21);
			this.comboBox7.TabIndex = 1;
			this.comboBox7.Visible = false;
			// 
			// comboBox8
			// 
			this.comboBox8.DefaultErrorMessage = null;
			this.comboBox8.IsValid = false;
			this.comboBox8.Location = new System.Drawing.Point(0, 0);
			this.comboBox8.Name = "comboBox8";
			this.comboBox8.Required = false;
			this.comboBox8.Size = new System.Drawing.Size(180, 21);
			this.comboBox8.TabIndex = 0;
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(12, 64);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(60, 20);
			this.label29.TabIndex = 95;
			this.label29.Text = "Pagesa ne";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCmimiGrupi
			// 
			this.lblCmimiGrupi.BackColor = System.Drawing.Color.Transparent;
			this.lblCmimiGrupi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCmimiGrupi.Location = new System.Drawing.Point(24, 8);
			this.lblCmimiGrupi.Name = "lblCmimiGrupi";
			this.lblCmimiGrupi.Size = new System.Drawing.Size(48, 20);
			this.lblCmimiGrupi.TabIndex = 94;
			this.lblCmimiGrupi.Text = "Cmimi";
			this.lblCmimiGrupi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblCmimiGrupi.Visible = false;
			// 
			// numCmimiGrup
			// 
			this.numCmimiGrup.AutoSize = false;
			this.numCmimiGrup.DefaultErrorMessage = "Ju duhet te percaktoni nje vlere per cmimin e dhomes!";
			this.numCmimiGrup.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numCmimiGrup.DigitsAfterDecimalPoint = 0;
			this.numCmimiGrup.FixedLength = false;
			this.numCmimiGrup.IsValid = false;
			this.numCmimiGrup.KeepFocus = false;
			this.numCmimiGrup.Location = new System.Drawing.Point(80, 8);
			this.numCmimiGrup.Name = "numCmimiGrup";
			this.numCmimiGrup.OnlyPositive = true;
			this.numCmimiGrup.ReadOnly = true;
			this.numCmimiGrup.Required = true;
			this.numCmimiGrup.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimiGrup.Size = new System.Drawing.Size(180, 21);
			this.numCmimiGrup.TabIndex = 12;
			this.numCmimiGrup.Text = "";
			this.numCmimiGrup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numCmimiGrup.Visible = false;
			// 
			// numKapariGrupi
			// 
			this.numKapariGrupi.AutoSize = false;
			this.numKapariGrupi.DefaultErrorMessage = "Ju duhet te percaktoni nje vlere per kaparin e dhomes!";
			this.numKapariGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numKapariGrupi.DigitsAfterDecimalPoint = 0;
			this.numKapariGrupi.FixedLength = false;
			this.numKapariGrupi.IsValid = false;
			this.numKapariGrupi.KeepFocus = false;
			this.numKapariGrupi.Location = new System.Drawing.Point(80, 36);
			this.numKapariGrupi.Name = "numKapariGrupi";
			this.numKapariGrupi.OnlyPositive = true;
			this.numKapariGrupi.Required = true;
			this.numKapariGrupi.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.numKapariGrupi.Size = new System.Drawing.Size(180, 21);
			this.numKapariGrupi.TabIndex = 13;
			this.numKapariGrupi.Text = "";
			this.numKapariGrupi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numKapariGrupi.Visible = false;
			// 
			// lblKapariGrupi
			// 
			this.lblKapariGrupi.BackColor = System.Drawing.Color.Transparent;
			this.lblKapariGrupi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblKapariGrupi.Location = new System.Drawing.Point(24, 36);
			this.lblKapariGrupi.Name = "lblKapariGrupi";
			this.lblKapariGrupi.Size = new System.Drawing.Size(48, 20);
			this.lblKapariGrupi.TabIndex = 90;
			this.lblKapariGrupi.Text = "Kapari";
			this.lblKapariGrupi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblKapariGrupi.Visible = false;
			// 
			// btnPagesaGrupi
			// 
			this.btnPagesaGrupi.BackColor = System.Drawing.Color.Blue;
			this.btnPagesaGrupi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPagesaGrupi.DoValidation = true;
			this.btnPagesaGrupi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnPagesaGrupi.Location = new System.Drawing.Point(104, 96);
			this.btnPagesaGrupi.Name = "btnPagesaGrupi";
			this.btnPagesaGrupi.Size = new System.Drawing.Size(96, 21);
			this.btnPagesaGrupi.TabIndex = 92;
			this.btnPagesaGrupi.Text = "Llogarit pagesen";
			this.toolTips.SetToolTip(this.btnPagesaGrupi, "Llogarit paraprakisht pagesen per dhomen!");
			this.btnPagesaGrupi.Visible = false;
			this.btnPagesaGrupi.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnPagesaGrupi.Click += new System.EventHandler(this.btnPagesaGrupi_Click_1);
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label23.Location = new System.Drawing.Point(16, 164);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(64, 16);
			this.label23.TabIndex = 87;
			this.label23.Text = "Kapaciteti";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label23.Visible = false;
			// 
			// cmbDhomaGrupi
			// 
			this.cmbDhomaGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhomaGrupi.Controls.Add(this.comboBox5);
			this.cmbDhomaGrupi.Controls.Add(this.comboBox6);
			this.cmbDhomaGrupi.DefaultErrorMessage = "Zgjidhni nje prej dhomave!";
			this.cmbDhomaGrupi.IsValid = false;
			this.cmbDhomaGrupi.Kolone1Vlere = null;
			this.cmbDhomaGrupi.Kolone2Vlere = null;
			this.cmbDhomaGrupi.Location = new System.Drawing.Point(88, 132);
			this.cmbDhomaGrupi.Name = "cmbDhomaGrupi";
			this.cmbDhomaGrupi.ReadOnly = false;
			this.cmbDhomaGrupi.Required = true;
			this.cmbDhomaGrupi.Size = new System.Drawing.Size(180, 21);
			this.cmbDhomaGrupi.SkipValidation = false;
			this.cmbDhomaGrupi.TabIndex = 11;
			this.cmbDhomaGrupi.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbDhomaGrupi_SelectedIndexChanged_1);
			// 
			// comboBox5
			// 
			this.comboBox5.DefaultErrorMessage = null;
			this.comboBox5.IsValid = false;
			this.comboBox5.Location = new System.Drawing.Point(100, 0);
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
			this.comboBox6.Size = new System.Drawing.Size(196, 21);
			this.comboBox6.TabIndex = 0;
			// 
			// cmbKategoriaGrupi
			// 
			this.cmbKategoriaGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategoriaGrupi.Controls.Add(this.comboBox3);
			this.cmbKategoriaGrupi.Controls.Add(this.comboBox4);
			this.cmbKategoriaGrupi.DefaultErrorMessage = "Zgjidhni nje prej kategorive!";
			this.cmbKategoriaGrupi.IsValid = false;
			this.cmbKategoriaGrupi.Kolone1Vlere = null;
			this.cmbKategoriaGrupi.Kolone2Vlere = null;
			this.cmbKategoriaGrupi.Location = new System.Drawing.Point(88, 104);
			this.cmbKategoriaGrupi.Name = "cmbKategoriaGrupi";
			this.cmbKategoriaGrupi.ReadOnly = false;
			this.cmbKategoriaGrupi.Required = true;
			this.cmbKategoriaGrupi.Size = new System.Drawing.Size(180, 21);
			this.cmbKategoriaGrupi.SkipValidation = false;
			this.cmbKategoriaGrupi.TabIndex = 10;
			this.cmbKategoriaGrupi.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategoriaGrupi_SelectedIndexChanged_1);
			// 
			// comboBox3
			// 
			this.comboBox3.DefaultErrorMessage = null;
			this.comboBox3.IsValid = false;
			this.comboBox3.Location = new System.Drawing.Point(100, 0);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Required = false;
			this.comboBox3.Size = new System.Drawing.Size(16, 21);
			this.comboBox3.TabIndex = 1;
			this.comboBox3.Visible = false;
			// 
			// comboBox4
			// 
			this.comboBox4.DefaultErrorMessage = null;
			this.comboBox4.IsValid = false;
			this.comboBox4.Location = new System.Drawing.Point(0, 0);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Required = false;
			this.comboBox4.Size = new System.Drawing.Size(196, 21);
			this.comboBox4.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Location = new System.Drawing.Point(16, 108);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(64, 20);
			this.label2.TabIndex = 76;
			this.label2.Text = "Kategoria";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label12.Location = new System.Drawing.Point(8, 132);
			this.label12.Name = "label12";
			this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label12.Size = new System.Drawing.Size(72, 20);
			this.label12.TabIndex = 73;
			this.label12.Text = "Dhoma";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Location = new System.Drawing.Point(-4, 80);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label4.Size = new System.Drawing.Size(84, 20);
			this.label4.TabIndex = 75;
			this.label4.Text = "Date mbarimi";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label9.Location = new System.Drawing.Point(0, 52);
			this.label9.Name = "label9";
			this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label9.Size = new System.Drawing.Size(80, 16);
			this.label9.TabIndex = 74;
			this.label9.Text = "Date fillimi";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpMbarimiGrupi
			// 
			this.dtpMbarimiGrupi.BackColor = System.Drawing.Color.White;
			this.dtpMbarimiGrupi.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpMbarimiGrupi.DefaultErrorMessage = "";
			this.dtpMbarimiGrupi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimiGrupi.IsValid = true;
			this.dtpMbarimiGrupi.Location = new System.Drawing.Point(88, 76);
			this.dtpMbarimiGrupi.Name = "dtpMbarimiGrupi";
			this.dtpMbarimiGrupi.Required = true;
			this.dtpMbarimiGrupi.ShowCheckBox = true;
			this.dtpMbarimiGrupi.ShowUpDown = true;
			this.dtpMbarimiGrupi.Size = new System.Drawing.Size(180, 20);
			this.dtpMbarimiGrupi.TabIndex = 9;
			this.dtpMbarimiGrupi.Value = new System.DateTime(2005, 8, 31, 11, 42, 0, 0);
			this.dtpMbarimiGrupi.ValueChanged += new System.EventHandler(this.dtpMbarimiGrupi_ValueChanged);
			// 
			// dtpFillimiGrupi
			// 
			this.dtpFillimiGrupi.BackColor = System.Drawing.Color.White;
			this.dtpFillimiGrupi.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpFillimiGrupi.DefaultErrorMessage = "";
			this.dtpFillimiGrupi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimiGrupi.IsValid = true;
			this.dtpFillimiGrupi.Location = new System.Drawing.Point(88, 48);
			this.dtpFillimiGrupi.Name = "dtpFillimiGrupi";
			this.dtpFillimiGrupi.Required = true;
			this.dtpFillimiGrupi.ShowCheckBox = true;
			this.dtpFillimiGrupi.ShowUpDown = true;
			this.dtpFillimiGrupi.Size = new System.Drawing.Size(180, 20);
			this.dtpFillimiGrupi.TabIndex = 8;
			this.dtpFillimiGrupi.Value = new System.DateTime(2005, 8, 31, 11, 42, 0, 0);
			this.dtpFillimiGrupi.ValueChanged += new System.EventHandler(this.dtpFillimiGrupi_ValueChanged);
			// 
			// cmbGrupet1
			// 
			this.cmbGrupet1.BackColor = System.Drawing.Color.Transparent;
			this.cmbGrupet1.Controls.Add(this.comboBox1);
			this.cmbGrupet1.Controls.Add(this.comboBox2);
			this.cmbGrupet1.DefaultErrorMessage = "Zgjidhni nje prej grupeve!";
			this.cmbGrupet1.IsValid = false;
			this.cmbGrupet1.Kolone1Vlere = null;
			this.cmbGrupet1.Kolone2Vlere = null;
			this.cmbGrupet1.Location = new System.Drawing.Point(88, 20);
			this.cmbGrupet1.Name = "cmbGrupet1";
			this.cmbGrupet1.ReadOnly = false;
			this.cmbGrupet1.Required = true;
			this.cmbGrupet1.Size = new System.Drawing.Size(180, 21);
			this.cmbGrupet1.SkipValidation = false;
			this.cmbGrupet1.TabIndex = 7;
			this.cmbGrupet1.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbGrupet1_SelectedIndexChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.DefaultErrorMessage = null;
			this.comboBox1.IsValid = false;
			this.comboBox1.Location = new System.Drawing.Point(100, 0);
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
			this.comboBox2.Size = new System.Drawing.Size(196, 21);
			this.comboBox2.TabIndex = 0;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label21.Location = new System.Drawing.Point(36, 24);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(44, 16);
			this.label21.TabIndex = 70;
			this.label21.Text = "Grupi";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.txtEmailGr);
			this.groupBox2.Controls.Add(this.label30);
			this.groupBox2.Controls.Add(this.cmbGrupet);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.txtGrupi);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.txtAgjensia);
			this.groupBox2.Controls.Add(this.lblAgjensia);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(290, 136);
			this.groupBox2.TabIndex = 40;
			this.groupBox2.Text = "Konfigurimi i grupeve";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// txtEmailGr
			// 
			this.txtEmailGr.AutoSize = false;
			this.txtEmailGr.DefaultErrorMessage = "";
			this.txtEmailGr.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmailGr.FixedLength = false;
			this.txtEmailGr.IsValid = true;
			this.txtEmailGr.Location = new System.Drawing.Point(88, 104);
			this.txtEmailGr.Name = "txtEmailGr";
			this.txtEmailGr.Required = false;
			this.txtEmailGr.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmailGr.Size = new System.Drawing.Size(180, 21);
			this.txtEmailGr.TabIndex = 105;
			this.txtEmailGr.Text = "";
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(40, 104);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(40, 20);
			this.label30.TabIndex = 104;
			this.label30.Text = "E-mail";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbGrupet
			// 
			this.cmbGrupet.BackColor = System.Drawing.Color.Transparent;
			this.cmbGrupet.DefaultErrorMessage = null;
			this.cmbGrupet.IsValid = true;
			this.cmbGrupet.Kolone1Vlere = null;
			this.cmbGrupet.Kolone2Vlere = null;
			this.cmbGrupet.Location = new System.Drawing.Point(88, 16);
			this.cmbGrupet.Name = "cmbGrupet";
			this.cmbGrupet.ReadOnly = false;
			this.cmbGrupet.Required = false;
			this.cmbGrupet.Size = new System.Drawing.Size(180, 21);
			this.cmbGrupet.SkipValidation = true;
			this.cmbGrupet.TabIndex = 1;
			this.cmbGrupet.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbGrupet_SelectedIndexChanged);
			// 
			// label20
			// 
			this.label20.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label20.Location = new System.Drawing.Point(36, 52);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(44, 20);
			this.label20.TabIndex = 58;
			this.label20.Text = "Emri ";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtGrupi
			// 
			this.txtGrupi.AutoSize = false;
			this.txtGrupi.DefaultErrorMessage = "";
			this.txtGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtGrupi.FixedLength = false;
			this.txtGrupi.IsValid = true;
			this.txtGrupi.Location = new System.Drawing.Point(88, 48);
			this.txtGrupi.Name = "txtGrupi";
			this.txtGrupi.Required = false;
			this.txtGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtGrupi.Size = new System.Drawing.Size(180, 21);
			this.txtGrupi.TabIndex = 2;
			this.txtGrupi.Text = "";
			// 
			// label14
			// 
			this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label14.Location = new System.Drawing.Point(36, 20);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(44, 20);
			this.label14.TabIndex = 54;
			this.label14.Text = "Grupi";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAgjensia
			// 
			this.txtAgjensia.AutoSize = false;
			this.txtAgjensia.DefaultErrorMessage = "";
			this.txtAgjensia.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAgjensia.FixedLength = false;
			this.txtAgjensia.IsValid = true;
			this.txtAgjensia.Location = new System.Drawing.Point(88, 76);
			this.txtAgjensia.Name = "txtAgjensia";
			this.txtAgjensia.Required = false;
			this.txtAgjensia.RequiredControlColor = System.Drawing.Color.White;
			this.txtAgjensia.Size = new System.Drawing.Size(180, 21);
			this.txtAgjensia.TabIndex = 3;
			this.txtAgjensia.Text = "";
			// 
			// lblAgjensia
			// 
			this.lblAgjensia.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblAgjensia.Location = new System.Drawing.Point(24, 76);
			this.lblAgjensia.Name = "lblAgjensia";
			this.lblAgjensia.Size = new System.Drawing.Size(56, 20);
			this.lblAgjensia.TabIndex = 56;
			this.lblAgjensia.Text = "Agjensia";
			this.lblAgjensia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.txtVendlindjaGrupi);
			this.groupBox1.Controls.Add(this.label26);
			this.groupBox1.Controls.Add(this.label25);
			this.groupBox1.Controls.Add(this.cmbMjetIdGrupi);
			this.groupBox1.Controls.Add(this.txtTelefoniGrupi);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.dtpDatelindjaGrupi);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.txtEmailGrupi);
			this.groupBox1.Controls.Add(this.txtTargaGrupi);
			this.groupBox1.Controls.Add(this.txtAdresaGrupi);
			this.groupBox1.Controls.Add(this.txtIdNoGrupi);
			this.groupBox1.Controls.Add(this.txtMbiemriGrupi);
			this.groupBox1.Controls.Add(this.txtEmriGrupi);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.btnShtoKlGrupi);
			this.groupBox1.Controls.Add(this.txtShtetesiaGrupi);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(312, 148);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(324, 384);
			this.groupBox1.TabIndex = 39;
			this.groupBox1.Text = "Te dhenat per futjen e klienteve ne grup";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// txtVendlindjaGrupi
			// 
			this.txtVendlindjaGrupi.AutoSize = false;
			this.txtVendlindjaGrupi.DefaultErrorMessage = "";
			this.txtVendlindjaGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtVendlindjaGrupi.FixedLength = false;
			this.txtVendlindjaGrupi.IsValid = true;
			this.txtVendlindjaGrupi.Location = new System.Drawing.Point(120, 108);
			this.txtVendlindjaGrupi.Name = "txtVendlindjaGrupi";
			this.txtVendlindjaGrupi.Required = false;
			this.txtVendlindjaGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtVendlindjaGrupi.Size = new System.Drawing.Size(180, 21);
			this.txtVendlindjaGrupi.TabIndex = 18;
			this.txtVendlindjaGrupi.Text = "";
			// 
			// label26
			// 
			this.label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label26.Location = new System.Drawing.Point(40, 136);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(72, 20);
			this.label26.TabIndex = 65;
			this.label26.Text = "Shtetesia";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label25
			// 
			this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label25.Location = new System.Drawing.Point(40, 112);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(72, 20);
			this.label25.TabIndex = 64;
			this.label25.Text = "Vendlindja";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbMjetIdGrupi
			// 
			this.cmbMjetIdGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cmbMjetIdGrupi.DefaultErrorMessage = "Zgjidhni nje prej menyrave te identifikimit!";
			this.cmbMjetIdGrupi.IsValid = false;
			this.cmbMjetIdGrupi.Kolone1Vlere = null;
			this.cmbMjetIdGrupi.Kolone2Vlere = null;
			this.cmbMjetIdGrupi.Location = new System.Drawing.Point(120, 164);
			this.cmbMjetIdGrupi.Name = "cmbMjetIdGrupi";
			this.cmbMjetIdGrupi.ReadOnly = false;
			this.cmbMjetIdGrupi.Required = true;
			this.cmbMjetIdGrupi.Size = new System.Drawing.Size(180, 21);
			this.cmbMjetIdGrupi.SkipValidation = false;
			this.cmbMjetIdGrupi.TabIndex = 20;
			// 
			// txtTelefoniGrupi
			// 
			this.txtTelefoniGrupi.AutoSize = false;
			this.txtTelefoniGrupi.DefaultErrorMessage = "";
			this.txtTelefoniGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTelefoniGrupi.FixedLength = false;
			this.txtTelefoniGrupi.IsValid = true;
			this.txtTelefoniGrupi.Location = new System.Drawing.Point(120, 224);
			this.txtTelefoniGrupi.Name = "txtTelefoniGrupi";
			this.txtTelefoniGrupi.Required = false;
			this.txtTelefoniGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtTelefoniGrupi.Size = new System.Drawing.Size(180, 21);
			this.txtTelefoniGrupi.TabIndex = 22;
			this.txtTelefoniGrupi.Text = "";
			// 
			// label18
			// 
			this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label18.Location = new System.Drawing.Point(24, 228);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(88, 20);
			this.label18.TabIndex = 61;
			this.label18.Text = "Numer telefoni";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDatelindjaGrupi
			// 
			this.dtpDatelindjaGrupi.BackColor = System.Drawing.Color.White;
			this.dtpDatelindjaGrupi.CustomFormat = "dd.MM.yyyy";
			this.dtpDatelindjaGrupi.DefaultErrorMessage = "";
			this.dtpDatelindjaGrupi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDatelindjaGrupi.IsValid = true;
			this.dtpDatelindjaGrupi.Location = new System.Drawing.Point(120, 80);
			this.dtpDatelindjaGrupi.Name = "dtpDatelindjaGrupi";
			this.dtpDatelindjaGrupi.Required = true;
			this.dtpDatelindjaGrupi.ShowCheckBox = true;
			this.dtpDatelindjaGrupi.ShowUpDown = true;
			this.dtpDatelindjaGrupi.Size = new System.Drawing.Size(180, 20);
			this.dtpDatelindjaGrupi.TabIndex = 17;
			this.dtpDatelindjaGrupi.Value = new System.DateTime(2005, 8, 31, 11, 42, 0, 0);
			// 
			// label17
			// 
			this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label17.Location = new System.Drawing.Point(40, 84);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(72, 20);
			this.label17.TabIndex = 59;
			this.label17.Text = "Datelindja";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label15.Location = new System.Drawing.Point(52, 316);
			this.label15.Name = "label15";
			this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label15.Size = new System.Drawing.Size(60, 20);
			this.label15.TabIndex = 58;
			this.label15.Text = "E-Mail";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEmailGrupi
			// 
			this.txtEmailGrupi.AutoSize = false;
			this.txtEmailGrupi.DefaultErrorMessage = "";
			this.txtEmailGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmailGrupi.FixedLength = false;
			this.txtEmailGrupi.IsValid = true;
			this.txtEmailGrupi.Location = new System.Drawing.Point(120, 312);
			this.txtEmailGrupi.Name = "txtEmailGrupi";
			this.txtEmailGrupi.Required = false;
			this.txtEmailGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmailGrupi.Size = new System.Drawing.Size(180, 21);
			this.txtEmailGrupi.TabIndex = 25;
			this.txtEmailGrupi.Text = "";
			// 
			// txtTargaGrupi
			// 
			this.txtTargaGrupi.AutoSize = false;
			this.txtTargaGrupi.DefaultErrorMessage = "";
			this.txtTargaGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTargaGrupi.FixedLength = false;
			this.txtTargaGrupi.IsValid = true;
			this.txtTargaGrupi.Location = new System.Drawing.Point(120, 284);
			this.txtTargaGrupi.Name = "txtTargaGrupi";
			this.txtTargaGrupi.Required = false;
			this.txtTargaGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtTargaGrupi.Size = new System.Drawing.Size(180, 21);
			this.txtTargaGrupi.TabIndex = 24;
			this.txtTargaGrupi.Text = "";
			// 
			// txtAdresaGrupi
			// 
			this.txtAdresaGrupi.AutoSize = false;
			this.txtAdresaGrupi.DefaultErrorMessage = "";
			this.txtAdresaGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAdresaGrupi.FixedLength = false;
			this.txtAdresaGrupi.IsValid = true;
			this.txtAdresaGrupi.Location = new System.Drawing.Point(120, 252);
			this.txtAdresaGrupi.Name = "txtAdresaGrupi";
			this.txtAdresaGrupi.Required = false;
			this.txtAdresaGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtAdresaGrupi.Size = new System.Drawing.Size(180, 21);
			this.txtAdresaGrupi.TabIndex = 23;
			this.txtAdresaGrupi.Text = "";
			// 
			// txtIdNoGrupi
			// 
			this.txtIdNoGrupi.AutoSize = false;
			this.txtIdNoGrupi.DefaultErrorMessage = "Ju duhet te jepni numrin e identifikimit!";
			this.txtIdNoGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtIdNoGrupi.FixedLength = false;
			this.txtIdNoGrupi.IsValid = false;
			this.txtIdNoGrupi.Location = new System.Drawing.Point(120, 196);
			this.txtIdNoGrupi.Name = "txtIdNoGrupi";
			this.txtIdNoGrupi.Required = true;
			this.txtIdNoGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtIdNoGrupi.Size = new System.Drawing.Size(180, 21);
			this.txtIdNoGrupi.TabIndex = 21;
			this.txtIdNoGrupi.Text = "";
			// 
			// txtMbiemriGrupi
			// 
			this.txtMbiemriGrupi.AutoSize = false;
			this.txtMbiemriGrupi.DefaultErrorMessage = "Ju duhet te jepni mbiemrin e klientit!";
			this.txtMbiemriGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemriGrupi.FixedLength = false;
			this.txtMbiemriGrupi.IsValid = false;
			this.txtMbiemriGrupi.Location = new System.Drawing.Point(120, 52);
			this.txtMbiemriGrupi.Name = "txtMbiemriGrupi";
			this.txtMbiemriGrupi.Required = true;
			this.txtMbiemriGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemriGrupi.Size = new System.Drawing.Size(180, 21);
			this.txtMbiemriGrupi.TabIndex = 16;
			this.txtMbiemriGrupi.Text = "";
			// 
			// txtEmriGrupi
			// 
			this.txtEmriGrupi.AutoSize = false;
			this.txtEmriGrupi.DefaultErrorMessage = "Ju duhet te jepni emrin e klientit!";
			this.txtEmriGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmriGrupi.FixedLength = false;
			this.txtEmriGrupi.IsValid = false;
			this.txtEmriGrupi.Location = new System.Drawing.Point(120, 24);
			this.txtEmriGrupi.Name = "txtEmriGrupi";
			this.txtEmriGrupi.Required = true;
			this.txtEmriGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmriGrupi.Size = new System.Drawing.Size(180, 21);
			this.txtEmriGrupi.TabIndex = 15;
			this.txtEmriGrupi.Text = "";
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Location = new System.Drawing.Point(12, 284);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label5.Size = new System.Drawing.Size(100, 24);
			this.label5.TabIndex = 27;
			this.label5.Text = "Targa e automjetit";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label7.Location = new System.Drawing.Point(36, 256);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label7.Size = new System.Drawing.Size(76, 20);
			this.label7.TabIndex = 24;
			this.label7.Text = "Adresa";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label8.Location = new System.Drawing.Point(0, 200);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label8.Size = new System.Drawing.Size(112, 20);
			this.label8.TabIndex = 19;
			this.label8.Text = "Numri i identifikimit";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label10.Location = new System.Drawing.Point(4, 168);
			this.label10.Name = "label10";
			this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label10.Size = new System.Drawing.Size(108, 20);
			this.label10.TabIndex = 7;
			this.label10.Text = "Mjeti i identifikimit";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label11.Location = new System.Drawing.Point(44, 56);
			this.label11.Name = "label11";
			this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label11.Size = new System.Drawing.Size(68, 20);
			this.label11.TabIndex = 6;
			this.label11.Text = "Mbiemri";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label13.Location = new System.Drawing.Point(56, 28);
			this.label13.Name = "label13";
			this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label13.Size = new System.Drawing.Size(56, 20);
			this.label13.TabIndex = 5;
			this.label13.Text = "Emri";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnShtoKlGrupi
			// 
			this.btnShtoKlGrupi.BackColor = System.Drawing.Color.Blue;
			this.btnShtoKlGrupi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShtoKlGrupi.DoValidation = true;
			this.btnShtoKlGrupi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShtoKlGrupi.Location = new System.Drawing.Point(156, 348);
			this.btnShtoKlGrupi.Name = "btnShtoKlGrupi";
			this.btnShtoKlGrupi.Size = new System.Drawing.Size(90, 21);
			this.btnShtoKlGrupi.TabIndex = 26;
			this.btnShtoKlGrupi.Text = "Shto klient";
			this.toolTips.SetToolTip(this.btnShtoKlGrupi, "Shton klientin me te dhenat e mesiperme ne listen\r\n e klienteve qe do te futen ne" +
				" dhomen e zgjedhur!");
			this.btnShtoKlGrupi.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShtoKlGrupi.Click += new System.EventHandler(this.btnShtoKlGrupi_Click);
			// 
			// txtShtetesiaGrupi
			// 
			this.txtShtetesiaGrupi.AutoSize = false;
			this.txtShtetesiaGrupi.DefaultErrorMessage = "";
			this.txtShtetesiaGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtShtetesiaGrupi.FixedLength = false;
			this.txtShtetesiaGrupi.IsValid = true;
			this.txtShtetesiaGrupi.Location = new System.Drawing.Point(120, 136);
			this.txtShtetesiaGrupi.Name = "txtShtetesiaGrupi";
			this.txtShtetesiaGrupi.Required = false;
			this.txtShtetesiaGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtShtetesiaGrupi.Size = new System.Drawing.Size(180, 20);
			this.txtShtetesiaGrupi.TabIndex = 19;
			this.txtShtetesiaGrupi.Text = "";
			// 
			// btnElemino
			// 
			this.btnElemino.BackColor = System.Drawing.Color.Blue;
			this.btnElemino.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnElemino.DoValidation = false;
			this.btnElemino.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnElemino.Location = new System.Drawing.Point(312, 88);
			this.btnElemino.Name = "btnElemino";
			this.btnElemino.Size = new System.Drawing.Size(90, 21);
			this.btnElemino.TabIndex = 6;
			this.btnElemino.Text = "Elemino";
			this.toolTips.SetToolTip(this.btnElemino, "Eleminon grupin e zgjedhur!");
			this.btnElemino.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnElemino.Click += new System.EventHandler(this.btnElemino_Click);
			// 
			// btnModifiko
			// 
			this.btnModifiko.BackColor = System.Drawing.Color.Blue;
			this.btnModifiko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifiko.DoValidation = false;
			this.btnModifiko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifiko.Location = new System.Drawing.Point(312, 56);
			this.btnModifiko.Name = "btnModifiko";
			this.btnModifiko.Size = new System.Drawing.Size(90, 21);
			this.btnModifiko.TabIndex = 5;
			this.btnModifiko.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifiko, "Modifikon grupin e zgjedhur!");
			this.btnModifiko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
			// 
			// btnShto
			// 
			this.btnShto.BackColor = System.Drawing.Color.Blue;
			this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShto.DoValidation = false;
			this.btnShto.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShto.Location = new System.Drawing.Point(312, 24);
			this.btnShto.Name = "btnShto";
			this.btnShto.Size = new System.Drawing.Size(90, 21);
			this.btnShto.TabIndex = 4;
			this.btnShto.Text = "Shto";
			this.toolTips.SetToolTip(this.btnShto, "Shton nje grup te ri!");
			this.btnShto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 0;
			// 
			// pic
			// 
			this.pic.Location = new System.Drawing.Point(0, 0);
			this.pic.Name = "pic";
			this.pic.TabIndex = 0;
			this.pic.TabStop = false;
			// 
			// dsKlienti
			// 
			this.dsKlienti.DataSetName = "NewDataSet";
			this.dsKlienti.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// dsKlientiGrupi
			// 
			this.dsKlientiGrupi.DataSetName = "NewDataSet";
			this.dsKlientiGrupi.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// MerrDhome
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(815, 466);
			this.Controls.Add(this.tab);
			this.HelpFile = "MERR DHOME.htm";
			this.Name = "MerrDhome";
			this.Text = "Merr dhome";
			this.TitullGjeresi = 1011;
			this.Load += new System.EventHandler(this.MerrDhome_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.tab, 0);
			this.tab.ResumeLayout(false);
			this.tbIndivid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.panelCmimi.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbKlientet)).EndInit();
			this.gbKlientet.ResumeLayout(false);
			this.tbGrup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.panelCmimiGrupi.ResumeLayout(false);
			this.cmbPagesaGrupi.ResumeLayout(false);
			this.cmbDhomaGrupi.ResumeLayout(false);
			this.cmbKategoriaGrupi.ResumeLayout(false);
			this.cmbGrupet1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsKlienti)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsKlientiGrupi)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region FormLoad
	
		private void MerrDhome_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				// pastrim variablash private
				this.dhomaGrupiCift = 0;
				string emr = this.Perdorues.ToString();
				this.nrKrevat = 0;
				this.nrKrevatZene = 0;
				this.i = 0;
				this.nrKlientShtese = 0;
				this.nrKrevatGrupi = 0;
				this.nrKrevatZeneGrupi = 0;
				this.iG = 0;
				this.nrKlientShteseGrupi = 0;
				this.idKategoria = 0;
				this.dhomaKlientiCift = 0;
				this.dsKlienti.Tables.Clear();
				this.dsKlientiGrupi.Tables.Clear();
				this.idRezervimi = 0;
				//pastrim variablash private
				InputController data = new InputController();
				DataSet ds = null;
				this.dtpFillimi.Text = System.DateTime.Now.ToString();
				this.dtpMbarimi.Text = System.DateTime.Now.ToString();
				this.dtpFillimiGrupi.Text = System.DateTime.Now.ToString();
				this.dtpMbarimiGrupi.Text = System.DateTime.Now.ToString();
				this.dtpDatelindja.Value = DateTime.Now;
				this.dtpDatelindjaGrupi.Value = DateTime.Now;
				ds = data.KerkesaRead("ShfaqMjeteIdentifikimi");
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbMjetId.Kolone1.Items.Add(dr[1]);
					this.cmbMjetId.Kolone2.Items.Add(dr[0]);
					this.cmbMjetIdGrupi.Kolone1.Items.Add(dr[1]);
					this.cmbMjetIdGrupi.Kolone2.Items.Add(dr[0]);
				}
				ds = data.KerkesaRead("ShfaqKategorite");
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbKategoria.Kolone1.Items.Add(dr[1]);
					this.cmbKategoria.Kolone2.Items.Add(dr[0]);
					this.cmbKategoriaGrupi.Kolone1.Items.Add(dr[1]);
					this.cmbKategoriaGrupi.Kolone2.Items.Add(dr[0]);
				}
				this.MbushGrupet();
				this.MbushPagesat();
				this.BuildDs();
				this.BuildDsGrupi();
				// Kontrollo nese ekziston vlera publike per skanimin e pashaportes
				string skanim = Global.GetIsolatedStorageContent("Skanim");
				if (skanim != "true")
				{
					this.btnSkano.Visible = false;
					this.btnSkanoGrup.Visible = false;
				}
				else
				{
					this.btnSkano.Visible = true;
					this.btnSkanoGrup.Visible = false;
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

		private void tab_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				this.idRezervimi = 0;
				if (dsKlienti.Tables.Count != 0)
					this.dsKlienti.Tables["KLIENTI"].Rows.Clear();
				if (dsKlientiGrupi.Tables.Count != 0)
					this.dsKlientiGrupi.Tables["KLIENTI"].Rows.Clear();
				if (this.tab.SelectedIndex == 0)//klienti
				{
					this.Pastro(this.groupBox3);
					this.Pastro(this.gbKlientet);
					this.Pastro(this.panelCmimi);
					this.PastroPanel();
				}
				else
				{
					this.Pastro(this.groupBox2);
					this.Pastro(this.groupBox4);
					this.Pastro(this.groupBox1);
					this.Pastro(this.panelCmimiGrupi);
					this.PastroPanelGrupi();
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
				this.AutoScrollPosition = new Point(0, 0);
			}
		}
	
		#endregion
		
		#region MerrDhomeKlient
		private void mbushKategorite()
		{
			DataSet ds = null ;
			this.cmbKategoria.Kolone1.Items.Clear();
			this.cmbKategoria.Kolone2.Items.Clear();
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqKategorite");
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbKategoria.Kolone1.Items.Add(dr[1]);
				this.cmbKategoria.Kolone2.Items.Add(dr[0]);
			}
		}
		
		private void mbushMjeteIdentifikimi()
		{	
			DataSet ds = null ;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqMjeteIdentifikimi");

		}
		private void dtpFillimi_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.cmbKategoria.Kolone1.Text = "";
				this.cmbKategoria.Kolone2.Text = "";

				this.cmbDhoma.Kolone1.Items.Clear();
				this.cmbDhoma.Kolone2.Items.Clear();
				this.cmbDhoma.Kolone1.Text = "";
				this.cmbDhoma.Kolone2.Text = "";

				this.PastroPanel();
				this.numCmimi.Text = "";
				this.numKapariKlienti.Text = "";

				this.cmbPagesaKlienti.Kolone1.Text = "Cash";
				this.cmbPagesaKlienti.Kolone1Vlere = "Cash";
				this.cmbPagesaKlienti.Kolone2.Text = "1";
				this.cmbPagesaKlienti.Kolone2Vlere = "1";
				this.cmbPagesaKlienti.Enabled = true;
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

		private void dtpMbarimi_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.cmbKategoria.Kolone1.Text = "";
				this.cmbKategoria.Kolone2.Text = "";

				this.cmbDhoma.Kolone1.Items.Clear();
				this.cmbDhoma.Kolone2.Items.Clear();
				this.cmbDhoma.Kolone1.Text = "";
				this.cmbDhoma.Kolone2.Text = "";

				this.PastroPanel();
				this.numCmimi.Text = "";
				this.numKapariKlienti.Text = "";

				this.cmbPagesaKlienti.Kolone1.Text = "Cash";
				this.cmbPagesaKlienti.Kolone1Vlere = "Cash";
				this.cmbPagesaKlienti.Kolone2.Text = "1";
				this.cmbPagesaKlienti.Kolone2Vlere = "1";
				this.cmbPagesaKlienti.Enabled = true;
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

		private void cmbDhoma_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				this.cmbPagesaKlienti.Enabled = true;
				DataSet ds = null;
				int kapari = 0;
				InputController data = new InputController();
				int idDhoma = Convert.ToInt32(cmbDhoma.Kolone2Vlere);
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimi.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
				ds = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma , dtFillimi);
				this.numCmimi.Text = "";
				//Nese dhomes i eshte caktuar cmimi atehere paraqit cmimin e pare per kete interval datash
				if (ds.Tables[0].Rows.Count > 0)
					numCmimi.Text = ds.Tables[0].Rows[0][0].ToString();
				else if (ds.Tables[0].Rows.Count == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Per datat e mesiperme dhomes se zgjedhur nuk i eshte konfiguruar cmimi" + Environment.NewLine + "Konfiguroni cmimet ose zgjidhni nje dhome tjeter!", "Merr dhome", MessageBoxButtons.OK, MessageBoxIcon.Information);
					cmbDhoma.Kolone1.Text = "";
					this.numKapariKlienti.Text = "";
					this.numCmimi.Text = "";
					this.cmbPagesaKlienti.Kolone1.Text = "Cash";
					this.cmbPagesaKlienti.Kolone1Vlere = "Cash";
					this.cmbPagesaKlienti.Kolone2.Text = "1";
					this.cmbPagesaKlienti.Kolone2Vlere = "1";
					this.cmbPagesaKlienti.Enabled = true;
					this.PastroPanel();	
					return;
				}
				this.numKapariKlienti.Clear();
				this.PastroPanel();	
				this.dsKlienti.Clear();
				this.nrKlientShtese = 0;
				ds = data.KerkesaRead("ShfaqTeDhenatPerDhome",idDhoma);
				nrKrevat = Convert.ToInt32(ds.Tables[0].Rows[0][3]);
				this.dhomaKlientiCift = Convert.ToInt32(ds.Tables[0].Rows[0][4]);
				this.numKapariKlienti.ReadOnly = false;
				ds = data.KerkesaRead("ShfaqVeprimetPerDhomen", idDhoma,-1, dtFillimi.AddMonths(-3), dtMbarimi.AddMonths(3));
				bool ugjetKlientPerDhome = false;
				int indexkerkuar = 0;
				int k = 0;
				if (ds.Tables.Count == 2)
				{
					foreach(DataRow drk in ds.Tables["KLIENTI"].Rows)
					{
						if ((dtFillimi >= Convert.ToDateTime(drk["MINDATA"]))&&(dtFillimi < Convert.ToDateTime(drk["MAXDATA"])))
						{
							indexkerkuar = k;
							ugjetKlientPerDhome = true;
							break;
						}
						else if ((dtMbarimi > Convert.ToDateTime(drk["MINDATA"]))&&(dtMbarimi <= Convert.ToDateTime(drk["MAXDATA"])))
						{
							indexkerkuar = k;
							ugjetKlientPerDhome = true;
							break;
						}
						else if ((dtFillimi < Convert.ToDateTime(drk["MINDATA"]))&&(dtMbarimi > Convert.ToDateTime(drk["MAXDATA"])))
						{
							indexkerkuar = k;
							ugjetKlientPerDhome = true;
							break;
						}
						k++;
					}
				}
				int idFormaPagesa = 0;
				string emriPagesa = "";
				int pergjegjes = 0;
				if (ugjetKlientPerDhome)
				{
					DataRow drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
					DateTime dataMinPerDhomen = Convert.ToDateTime(drk["MINDATA"]);
					DateTime dataMaxPerDhomen = Convert.ToDateTime(drk["MAXDATA"]);
					string koment = "Dhoma ka nje hyrje ne hotel per intervalin e datave:";
					koment += Environment.NewLine + this.konverto(dataMinPerDhomen) + " dhe " + this.konverto(dataMaxPerDhomen);
					koment += Environment.NewLine + "Nqs doni te shtoni nje klient ne kete dhome duhet ta fusni brenda ketij intervali!";
					if ((dtFillimi < dataMinPerDhomen)||(dtMbarimi> dataMaxPerDhomen))
					{
						System.Windows.Forms.MessageBox.Show(this, koment, "Merr dhome", MessageBoxButtons.OK,MessageBoxIcon.Error);
						this.numCmimi.Text = "";
						this.numKapariKlienti.Text = "";
						this.cmbPagesaKlienti.Kolone1.Text = "";
						return;
					}
					string strBool = drk["KLIENT_HOTELI_STR"].ToString();
					if (strBool.Substring(0, 4) == "Fals")//dhoma eshte dorezuar dhe ne te s'mund te futen kliente te tjere
					{
						koment = "Dhoma ka pasur kliente te tjere per datat e caktuara";
						koment += Environment.NewLine + "te cilet kane dale te gjithe nga hoteli!";
						koment += Environment.NewLine + "Nuk mund te shtoni kliente te tjere per kete hyrje!";
						System.Windows.Forms.MessageBox.Show(this, koment, "Merr dhome", MessageBoxButtons.OK,MessageBoxIcon.Error);
						this.numCmimi.Text = "";
						this.numKapariKlienti.Text = "";
						this.cmbPagesaKlienti.Kolone1.Text = "";
						return;
					}
					kapari = Convert.ToInt32(drk["KAPARI"]);
					pergjegjes = Convert.ToInt32(drk["PERGJEGJES"]);
					DataSet dsFormaPagesa = data.KerkesaRead("ShfaqFormePageseKaparDhome", pergjegjes);
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
					this.cmbPagesaKlienti.Kolone1.Text = emriPagesa;
					this.cmbPagesaKlienti.Kolone1Vlere = emriPagesa;
                    this.cmbPagesaKlienti.Kolone2.Text = idFormaPagesa.ToString();
					this.cmbPagesaKlienti.Kolone2Vlere = idFormaPagesa;
					this.numKapariKlienti.Text = kapari.ToString();
					this.numKapariKlienti.ReadOnly = true;
					this.cmbPagesaKlienti.Enabled = false;
				}
				else
				{
					kapari = 0;
					this.numKapariKlienti.Text = "0";
					this.numKapariKlienti.ReadOnly = false;
					this.cmbPagesaKlienti.Kolone1.Text = "Cash";
					this.cmbPagesaKlienti.Kolone1Vlere = "Cash";
					this.cmbPagesaKlienti.Kolone2.Text = "1";
					this.cmbPagesaKlienti.Kolone2Vlere = "1";
					this.cmbPagesaKlienti.Enabled = true;
				}
				ds.Tables.Clear();
				ds = data.KerkesaRead("ShfaqKlientPerDhomePerDatat",idDhoma,dtFillimi,dtMbarimi);
				this.nrKrevatZene = ds.Tables[0].Rows.Count;
				this.label22.Visible = true;
				this.MbushPanel();
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
		private void cmbKategoria_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimi.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
				idKategoria = Convert.ToInt32(this.cmbKategoria.Kolone2Vlere);
				int a = this.KntData(dtFillimi,dtMbarimi);
				if(a == 0)
				{
					this.dtpFillimi.IsValid = true;
					this.error.SetError(this.dtpFillimi,"");
					this.dtpMbarimi.IsValid = true;
					this.cmbDhoma.Kolone1.Items.Clear();
					this.cmbDhoma.Kolone2.Items.Clear();
					this.cmbDhoma.Kolone1.Text = "";
					this.numKapariKlienti.Text = "";
					this.cmbPagesaKlienti.Kolone1.Text = "Cash";
					this.cmbPagesaKlienti.Kolone1Vlere = "Cash";
					this.cmbPagesaKlienti.Kolone2.Text = "1";
					this.cmbPagesaKlienti.Kolone2Vlere = "1";
					this.cmbPagesaKlienti.Enabled = true;

					this.numCmimi.Text = "";
					this.PastroPanel();				
					InputController data = new InputController();
					DataSet ds = data.KerkesaRead("ShfaqDhomatEliraPerDatatPerKategorine", idKategoria, dtFillimi, dtMbarimi);
					if(ds.Tables[0].Rows.Count == 0)
					{
						System.Windows.Forms.MessageBox.Show(this,"Per daten e hyrjes se klientit, kategoria e zgjedhur"+Environment.NewLine+
							"nuk ka asnje dhome te lire ose dhomave te saj nuk i jane konfiguruar cmimet."+Environment.NewLine+
							"Ju lutemi zgjidhni nje kategori tjeter ose konfiguroni cmimet!","Merr Dhome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.cmbKategoria.Kolone1.Text = "";
						return;
					}
					else
					{
						foreach (DataRow dr in ds.Tables[0].Rows)
						{
							this.cmbDhoma.Kolone1.Items.Add(dr[1]);
							this.cmbDhoma.Kolone2.Items.Add(dr[0]);
						}
					}
				}
				else if(a == 1)
				{
				
					this.dtpFillimi.IsValid = false;
					this.error.SetError(this.dtpFillimi, "Data e hyrjes se klientit duhet te jete me e vogel se data e daljes!");
					this.mbushKategorite();
					return;
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
		
		private void btnPagesaKlienti_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				if(this.numKapariKlienti.Text == "")
				{
					this.error.SetError(this.numKapariKlienti,"Ju duhet te  jepni nje vlere per kaparin");
					return;
				}
				this.error.SetError(this.numKapariKlienti, "");

				InputController data = new InputController();
				int idDhoma = Convert.ToInt32(cmbDhoma.Kolone2Vlere);
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimi.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
				DataSet ds = data.KerkesaRead("ShfaqKlientPerDhomePerDatat",idDhoma,dtFillimi,dtMbarimi);
				if (ds.Tables[0].Rows.Count > 0)
				{
					DateTime dMin = DateTime.Now.AddYears(100);
					DateTime dMax = DateTime.Now.AddYears(-100);
					foreach(DataRow dr in ds.Tables[0].Rows)
					{
						if (dMin > Convert.ToDateTime(dr["DATA_HYRJE"]))
						{
							dMin = Convert.ToDateTime(dr["DATA_HYRJE"]);
						}
						if (dMax < Convert.ToDateTime(dr["DATA_DALJE"]))
						{
							dMax = Convert.ToDateTime(dr["DATA_DALJE"]);
						}
					}
					dtFillimi = dMin;
					dtMbarimi = dMax;
				}

				int idKategoria = Convert.ToInt32(this.cmbKategoria.Kolone2Vlere);
				int cmimi = Convert.ToInt32(this.numCmimi.Text);
				int kapari = Convert.ToInt32(this.numKapariKlienti.Text);
				string njesi = "";
				string str = "";
				string strPagesa = "";
				string strDite = "";
				if (idKategoria == 31)
				{
					System.TimeSpan difDite1 = dtMbarimi.Subtract(dtFillimi);
					double ore = Math.Round(difDite1.TotalHours, 1);
					double pagesa = ore * cmimi - Convert.ToDouble(kapari);
					str = ore + " x " + cmimi + " - " + kapari + " = " + pagesa;	
					strPagesa = pagesa.ToString();
					strDite = ore.ToString();
					njesi = "ore";
				}
				else
				{
					System.TimeSpan difDite1 = dtMbarimi.Date.Subtract(dtFillimi.Date);
					int dite = difDite1.Days;
					int pagesa = dite * cmimi - kapari;
					str = dite + " x " + cmimi + " - " + kapari + " = " + pagesa;
					strDite = dite.ToString();
					strPagesa = pagesa.ToString();
					njesi = "dite";
				}
				string koment = "Pagesa per dhomen e zgjedhur per " + strDite + " " + njesi + " eshte " + strPagesa;
				koment += Environment.NewLine + str;
				System.Windows.Forms.MessageBox.Show(this, koment, "Llogaritja paraprake e pagesës", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		private void RefreshKlienti()
		{
			this.txtEmri.Clear();
			this.txtMbiemri.Clear();
			this.txtEmail.Clear();
			this.txtAdresa.Clear();
			this.txtIdNo.Clear();
			this.txtTelefoni.Clear();
			this.txtTarga.Clear();
			this.cmbMjetId.Kolone1.Text = "";
			this.dtpDatelindja.Text = System.DateTime.Now.ToString();
			this.txtVendlindjaKlienti.Text = "";
			this.txtShtetesiaKlienti.Text = "";
		}
		
		private void BuildDs()
		{
			
			dsKlienti.Tables.Add("KLIENTI");
			dsKlienti.Tables["KLIENTI"].Columns.Add("EMRI",typeof(string));
			dsKlienti.Tables["KLIENTI"].Columns.Add("MBIEMRI",typeof(string));
			dsKlienti.Tables["KLIENTI"].Columns.Add("DATELINDJA",typeof(DateTime));
			dsKlienti.Tables["KLIENTI"].Columns.Add("ID_MJETIDENTIFIKIMI",typeof(int));
			dsKlienti.Tables["KLIENTI"].Columns.Add("NR_IDENTIFIKIMI",typeof(string));
			dsKlienti.Tables["KLIENTI"].Columns.Add("ADRESA",typeof(string));
			dsKlienti.Tables["KLIENTI"].Columns.Add("TELEFONI",typeof(string));
			dsKlienti.Tables["KLIENTI"].Columns.Add("TARGA",typeof(string));
			dsKlienti.Tables["KLIENTI"].Columns.Add("EMAIL",typeof(string));
			dsKlienti.Tables["KLIENTI"].Columns.Add("ID_DHOMA",typeof(int));
			dsKlienti.Tables["KLIENTI"].Columns.Add("KAPARI",typeof(int));
			dsKlienti.Tables["KLIENTI"].Columns.Add("DATA_HYRJE",typeof(DateTime));
			dsKlienti.Tables["KLIENTI"].Columns.Add("DATA_DALJE",typeof(DateTime));
			dsKlienti.Tables["KLIENTI"].Columns.Add("DATA_KAPARI",typeof(DateTime));
			dsKlienti.Tables["KLIENTI"].Columns.Add("VENDLINDJA",typeof(String));
			dsKlienti.Tables["KLIENTI"].Columns.Add("SHTETESIA",typeof(String));
			dsKlienti.AcceptChanges();
		}
		private void btnShtoKlient_Click(object sender, System.EventArgs e)
		{
			try
			{
				int kapari = 0;
				DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimi.Value);
				DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
				idKategoria = Convert.ToInt32(this.cmbKategoria.Kolone2Vlere);
				int a = this.KntData(dataFillimi,dataMbarimi);
				InputController data = new InputController();
				if(a == 0)
				{

					this.dtpFillimi.IsValid = true;
					this.error.SetError(this.dtpFillimi,"");
					this.dtpMbarimi.IsValid = true;
					int b = 0;
					string emri = this.txtEmri.Text;
					string mbiemri = this.txtMbiemri.Text;
					DateTime datelindja = Convert.ToDateTime(this.dtpDatelindja.Value);
					int idMjetIdentifikimi = Convert.ToInt32(this.cmbMjetId.Kolone2Vlere);
					string nrIdentifikimi = this.txtIdNo.Text;
					string adresa = this.txtAdresa.Text;
					string telefoni = this.txtTelefoni.Text;
					string targa = this.txtTarga.Text;
					string email = this.txtEmail.Text;
					int idDhoma = Convert.ToInt32(this.cmbDhoma.Kolone2Vlere);
					string vendlindja = this.txtVendlindjaKlienti.Text;
					string shtetesia = this.txtShtetesiaKlienti.Text;
					//				int tmpKapari = Convert.ToInt32(numKapariKlienti.Text);
					//				if (nrKlientShtese > 0)
					//					this.dsKlienti.Tables[0].Rows[0]["KAPARI"] = tmpKapari;
					int nrKlienteNeDhomeNeGrup = Convert.ToInt32(data.KerkesaRead("NrKlienteNeDhomeNeGrup",idDhoma,dataFillimi, dataMbarimi).Tables[0].Rows[0][0]);
					if (nrKlienteNeDhomeNeGrup != 0)
					{
						System.Windows.Forms.MessageBox.Show(this, "Ne dhomen e zgjedhur ka kliente te ardhur ne grup." + Environment.NewLine + "Ju nuk mund te shtoni nje klient qe nuk i perket ketij grupi!", "Merr dhome", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					kapari = Convert.ToInt32(this.numKapariKlienti.Text);
					if ((kapari > 0)&& (this.cmbPagesaKlienti.Kolone1.SelectedItem == null))
					{
						this.cmbPagesaKlienti.IsValid = false;
						this.error.SetError(this.cmbPagesaKlienti, "Zgjidhni formen e pageses!");
						return;
					}
					this.cmbPagesaKlienti.IsValid = true;
					this.error.SetError(this.cmbPagesaKlienti, "");
					if(nrKlientShtese == 0 && this.numKapariKlienti.ReadOnly == false)
					{
						this.numKapariKlienti.ReadOnly = true;
						this.cmbPagesaKlienti.Enabled = false;
					}
					else
						kapari = 0;
					int idkategoria = Convert.ToInt32(this.cmbKategoria.Kolone2Vlere);
					int cmimi = Convert.ToInt32(this.numCmimi.Text);
					int shuma1 = this.GjejPagesen(idKategoria, cmimi, dataFillimi, dataMbarimi);
					if(kapari > shuma1)
					{
						this.numKapariKlienti.IsValid = false;
						this.error.SetError(this.numKapariKlienti,"Kapari nuk mund te kete vlere me te madhe se pagesa e dhomes." + Environment.NewLine + "Caktoni nje vlere te njejte ose me te vogel se pagesa!");
						this.numKapariKlienti.ReadOnly = false;
						this.cmbPagesaKlienti.Enabled = true;
						return;
					}
					DateTime dataKapari = dataFillimi.AddMilliseconds(DateTime.Now.Millisecond);
					nrKlientShtese = nrKlientShtese +1;
					if(this.nrKlientShtese > this.nrKrevat)
					{
						System.Windows.Forms.MessageBox.Show(this, 	"Kujdes kapaciteti i dhomes eshte plotesuar,"+
							Environment.NewLine+"ne kete dhome nuk mund te futen kliente te tjere!","Merr dhome ", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.RefreshKlienti();
						return;
					}
					DataRow r = this.dsKlienti.Tables["KLIENTI"].NewRow();
					r[0] = emri;
					r[1] = mbiemri;
					r[2] = datelindja;
					r[3] = idMjetIdentifikimi;
					r[4] = nrIdentifikimi;
					r[5] = adresa;
					r[6] = telefoni;
					r[7] = targa;
					r[8] = email;
					r[9] = idDhoma;
					r[10] = kapari;
					r[11] = dataFillimi;
					r[12] = dataMbarimi;
					r[13] = dataKapari;
					r[14] = vendlindja;
					r[15] = shtetesia;
					this.dsKlienti.Tables["KLIENTI"].Rows.Add(r);
					this.dsKlienti.AcceptChanges();
					
					this.PastroPanel();
					this.nrKrevatZene = this.nrKrevatZene +1;
					this.MbushPanel();
					this.RefreshKlienti();
				}
		
				else if(a == 1)
				{
				
					this.dtpFillimi.IsValid = false;
					this.error.SetError(this.dtpFillimi, "Data e hyrjes se klientit duhet te jete me e vogel se data e daljes!");
					this.cmbKategoria.Kolone1.Text = "";
					this.mbushKategorite();
					return;
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

		private void btnMerr_Click(object sender, System.EventArgs e)
		{
			try
			{
				int [] b = null;
				int shuma = 0;
				int nrKlient = Convert.ToInt32(this.dsKlienti.Tables[0].Rows.Count);
				if(nrKlient == 0)
				{
					System.Windows.Forms.MessageBox.Show(this,  "Kujdes, perpara se te merrni nje dhome,"+
						Environment.NewLine+"ju duhet te shtoni te dhenat e nje klienti",
						"Fut klient ne dhome",	MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				InputController data = new InputController();
				int idFormaPagesa = 0;
				if (this.cmbPagesaKlienti.Kolone1.SelectedItem != null)
					idFormaPagesa = Convert.ToInt32(this.cmbPagesaKlienti.Kolone2Vlere);
				b = new int[nrKlient];
				int i = 0;
				foreach(DataRow dr in this.dsKlienti.Tables[0].Rows)
				{
					b[i] = data.KerkesaUpdate("FutKlientNeDhome", dr[0].ToString(), dr[1].ToString(),
						Convert.ToDateTime(dr[2]), Convert.ToInt32(dr[3]), dr[4].ToString(),
						dr[5].ToString(), dr[6].ToString(), dr[7].ToString(),dr[8].ToString(),  
						Convert.ToInt32(dr[9]),  Convert.ToDateTime(dr[11]), Convert.ToDateTime(dr[12]), Convert.ToInt32(dr[10]),
						Convert.ToDateTime(dr[13]), dr[14].ToString(), dr[15].ToString(), idFormaPagesa, this.PerdoruesId);
					shuma = shuma + b[i];
					i = i+1;
				}
				if(shuma == 0)
				{
					VisionInfoSolutionLibrary.MessageBox.Show(this, "Fut klient ne dhome", "Futja e klienteve ne dhome, u krye me sukses!",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.dtpFillimi.Text = DateTime.Now.ToString();
					this.dtpMbarimi.Text = DateTime.Now.ToString();
					this.mbushKategorite();
					this.cmbKategoria.Kolone1.Text = "";
					this.cmbDhoma.Kolone1.Text = "";
					this.cmbDhoma.Kolone1.Items.Clear();
					this.cmbDhoma.Kolone2.Items.Clear();
					this.txtVendlindjaKlienti.Text = "";
					this.txtShtetesiaKlienti.Text = "";
					this.dsKlienti.Clear();
					this.PastroPanel();
					this.panelCmimi.Visible = false;
					this.label22.Visible = false;
					this.cmbPagesaKlienti.Kolone1.Text = "Cash";
					this.cmbPagesaKlienti.Kolone1Vlere = "Cash";
					this.cmbPagesaKlienti.Kolone2.Text = "1";
					this.cmbPagesaKlienti.Kolone2Vlere = "1";
				}
			
				else if (shuma != 0)
				
					VisionInfoSolutionLibrary.MessageBox.Show(this, "Fut klient ne dhome", "Futja e klienteve ne dhome,nuk u krye me sukses!",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private int KntData(DateTime dtFillimi,DateTime dtMbarimi )
		{
			int a = 0;
			System.TimeSpan nrDite = dtFillimi.Subtract(dtMbarimi);
			int difDite = Convert.ToInt32(nrDite.Days);
			int difOre = Convert.ToInt32(nrDite.Hours);
			if(idKategoria != 31)
			{
				nrDite = dtFillimi.Date.Subtract(dtMbarimi.Date);
				difDite = Convert.ToInt32(nrDite.Days);
				if (difDite >= 0 )
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
			return a;	
		}
		
		
		#endregion

		#region MerrDhomeGrup

		private void cmbKategoriaGrupi_SelectedIndexChanged_1(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				this.idRezervimi = 0;
				if (this.cmbGrupet1.Kolone1.SelectedItem == null)
				{
					this.error.SetError(this.cmbGrupet1, "Zgjidhni me pare grupin!");
					return;
				}
				this.error.SetError(this.cmbGrupet1, "");
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimiGrupi.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimiGrupi.Value);
				idKategoria = Convert.ToInt32(this.cmbKategoriaGrupi.Kolone2Vlere);
				this.cmbPagesaGrupi.Kolone1.Text = "Cash";
				this.cmbPagesaGrupi.Kolone2.Text = "1";
				this.cmbPagesaGrupi.Kolone1Vlere = "Cash";
				this.cmbPagesaGrupi.Kolone2Vlere = "1";
				this.cmbPagesaGrupi.Enabled = true;
				int a = this.KntData(dtFillimi,dtMbarimi);
				if(a == 0)
				{
					this.dtpFillimiGrupi.IsValid = true;
					this.error.SetError(this.dtpFillimiGrupi,"");
					this.cmbDhomaGrupi.Kolone1.Items.Clear();
					this.cmbDhomaGrupi.Kolone2.Items.Clear();
					this.cmbDhomaGrupi.Kolone1.Text = "";
					this.numKapariGrupi.Clear();
					this.numCmimiGrup.Text = "";
					this.PastroPanelGrupi();	
					InputController data = new InputController();
					DataSet ds = data.KerkesaRead("ShfaqDhomatEliraPerDatatPerKategorine", idKategoria, dtFillimi, dtMbarimi);
					if (ds.Tables[0].Rows.Count == 0)
					{
						System.Windows.Forms.MessageBox.Show(this,"Per daten e hyrjes se klientit, kategoria e zgjedhur"+Environment.NewLine+
							"nuk ka asnje dhome te lire ose dhomave te saj nuk i jane konfiguruar cmimet."+Environment.NewLine+
							"Ju lutemi zgjidhni nje kategori tjeter ose konfiguroni cmimet!","Merr Dhome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.cmbKategoriaGrupi.Kolone1.Text = "";
						return;
					}
					else
					{
						foreach(DataRow dr in ds.Tables[0].Rows)
						{
							this.cmbDhomaGrupi.Kolone1.Items.Add(dr[1]);
							this.cmbDhomaGrupi.Kolone2.Items.Add(dr[0]);
						}
					}
				}
				else if(a == 1)
				{
					this.dtpFillimiGrupi.IsValid = false;
					this.error.SetError(this.dtpFillimiGrupi, "Data e hyrjes se klientit duhet te jete me e vogel se data e daljes!");
					this.MbushKategoriteGrupi();
					return;
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

		private void cmbDhomaGrupi_SelectedIndexChanged_1(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				DataSet ds = null;
				int kapari = 0;
				int idFormaPagesa = 0;
				string emriPagesa = "";
				this.cmbPagesaGrupi.Kolone1.Text = "Cash";
				this.cmbPagesaGrupi.Kolone2.Text = "1";
				this.cmbPagesaGrupi.Kolone1Vlere = "Cash";
				this.cmbPagesaGrupi.Kolone2Vlere = "1";
				this.cmbPagesaGrupi.Enabled = true;
				InputController data = new InputController();
				int idDhoma = Convert.ToInt32(this.cmbDhomaGrupi.Kolone2Vlere);
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimiGrupi.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimiGrupi.Value);
				ds = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma , dtFillimi);
				this.numCmimiGrup.Text = "";
				if (ds.Tables[0].Rows.Count == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Per datat e mesiperme dhomes se zgjedhur nuk i eshte konfiguruar cmimi" + Environment.NewLine + "Konfiguroni cmimet ose zgjidhni nje dhome tjeter!", "Merr dhome", MessageBoxButtons.OK, MessageBoxIcon.Information);
					cmbDhoma.Kolone1.Text = "";
					this.numKapariGrupi.Clear();
					this.numCmimiGrup.Text = "";
					this.PastroPanelGrupi();	
					return;
				}
				DataRow dr =ds.Tables[0].Rows[0];
				this.numCmimiGrup.Text = Convert.ToString(dr[0]);
				this.numKapariGrupi.Clear();
				this.PastroPanelGrupi();
				this.dsKlientiGrupi.Clear();
				this.nrKlientShteseGrupi = 0;
				ds = data.KerkesaRead("ShfaqTeDhenatPerDhome",idDhoma);
				nrKrevatGrupi = Convert.ToInt32(ds.Tables[0].Rows[0][3]);
				this.dhomaGrupiCift = Convert.ToInt32(ds.Tables[0].Rows[0][4]);
				this.numKapariGrupi.ReadOnly = false;
				int idGrupi = Convert.ToInt32(this.cmbGrupet1.Kolone2Vlere);
				ds = data.KerkesaRead("ShfaqVeprimetPerGrupin",idGrupi, -1, dtFillimi.AddDays(-30), dtMbarimi.AddDays(30));
				int indexkerkuar = 0;
				int k = 0;
				bool ugjetVeprimPerGrup = false;
				if (ds.Tables.Count == 2)
				{
					foreach(DataRow drg in ds.Tables["KLIENTI"].Rows)
					{
						if ((dtFillimi >= Convert.ToDateTime(drg["MINDATA"]))&&(dtFillimi < Convert.ToDateTime(drg["MAXDATA"])))
						{
							indexkerkuar = k;
							ugjetVeprimPerGrup = true;
							break;
						}
						else if ((dtMbarimi > Convert.ToDateTime(drg["MINDATA"]))&&(dtMbarimi <= Convert.ToDateTime(drg["MAXDATA"])))
						{
							indexkerkuar = k;
							ugjetVeprimPerGrup = true;
							break;
						}
						else if ((dtFillimi < Convert.ToDateTime(drg["MINDATA"]))&&(dtMbarimi > Convert.ToDateTime(drg["MAXDATA"])))
						{
							indexkerkuar = k;
							ugjetVeprimPerGrup = true;
							break;
						}
						k++;
					}
				}
				//kontrollojme nqs ka rezervime per datat e dhena per grupin ne fjale te zgjedhur
				//ne rast se po nuk mund te kryhet nje hyrje per keto data
				DataSet dsRezervime = data.KerkesaRead("RezervimetPerDatatDheGrupin", idGrupi, dtFillimi, dtMbarimi);
				this.idRezervimi = 0;
				if (dsRezervime.Tables[0].Rows.Count != 0)
				{
					if (!ugjetVeprimPerGrup)//nqs nga rezervimi nuk eshte bere asnje futje ne dhome ath nuk lejohet te behen futje prej kesaj forme
					{
						string s = "Grupi ka nje rezervim ne hotel per intervalin e datave";
						foreach(DataRow rz in dsRezervime.Tables[0].Rows)
						{
							s += Environment.NewLine + this.konverto(Convert.ToDateTime(rz["DATA_FILLIMI"])) + " dhe " + this.konverto(Convert.ToDateTime(rz["DATA_MBARIMI"]));
						}
						s += Environment.NewLine + "Nuk mund te fusni kliente ne emer te ketij grupi per datat e  dhena!";
						System.Windows.Forms.MessageBox.Show(this, s, "Merr dhome", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.numCmimiGrup.Text = "";
						this.numKapariGrupi.Text = "";
						this.cmbPagesaGrupi.Kolone1.Text = "";
						return;
					}
					else//nqs eshte bere ndonje futje ne dhome nga rezervimi ath mund te shtohen kliente te rinj vetem ne dhomat qe nuk jane te rezervuara 
					{
						DataRow drg = ds.Tables["KLIENTI"].Rows[indexkerkuar];
						this.idRezervimi = Convert.ToInt32(dsRezervime.Tables[0].Rows[0]["ID_REZERVIMI"]);
//						string strId = drg["ID_KLIENTI_STR"].ToString();
//						DataSet tmp = this.gjejDataSetKlientet(strId);
//						bool zgjedhurDhomePL = false;
//						foreach(DataRow r in tmp.Tables[0].Rows)
//						{
//							if (idDhoma == Convert.ToInt32(r["ID_DHOMA"]))
//							{
//								zgjedhurDhomePL = true;
//								break;
//							}
//						}
//						if (!zgjedhurDhomePL)
//						{
//							string s = "Grupi ka nje rezervim ne hotel per intervalin e datave";
//							foreach(DataRow rz in dsRezervime.Tables[0].Rows)
//							{
//								s += Environment.NewLine + this.konverto(Convert.ToDateTime(rz["DATA_FILLIMI"])) + " dhe " + this.konverto(Convert.ToDateTime(rz["DATA_MBARIMI"]));
//							}
//							s += Environment.NewLine + "Kliente te tjere mund te shtohen vetem ne dhomat ku tashme jane futur disa kliente nga rezervimi!";
//							System.Windows.Forms.MessageBox.Show(this, s, "Merr dhome", MessageBoxButtons.OK, MessageBoxIcon.Error);
//							return;
//						}
					}
				}
				//jane gjetur kliente te grupit per keto data prandaj
				//1. kontrollohet intervali i datave per klientin qe do te futet nqs eshte i rregullt;
				//2. gjendet kapari dhe forma e pageses nga grupi
				if (ugjetVeprimPerGrup)
				{
					DataRow drg = ds.Tables["KLIENTI"].Rows[indexkerkuar];
					DateTime dataMinPerGrupin = Convert.ToDateTime(drg["MINDATA"]);
					DateTime dataMaxPerGrupin = Convert.ToDateTime(drg["MAXDATA"]);
					string koment = "Grupi ka nje hyrje ne hotel per intervalin e datave:";
					koment += Environment.NewLine + this.konverto(dataMinPerGrupin) + " dhe " + this.konverto(dataMaxPerGrupin);
					koment += Environment.NewLine + "Nqs doni te shtoni nje klient me kete grup duhet ta fusni brenda ketij intervali!";
					if ((dtFillimi < dataMinPerGrupin)||(dtMbarimi> dataMaxPerGrupin))
					{
						System.Windows.Forms.MessageBox.Show(this, koment, "Merr dhome", MessageBoxButtons.OK,MessageBoxIcon.Error);
						this.numCmimiGrup.Text = "";
						this.numKapariGrupi.Text = "";
						this.cmbPagesaGrupi.Kolone1.Text = "";
						return;
					}
					string strBool = drg["KLIENT_HOTELI_STR"].ToString();
					if ((this.DorezuarGrupi(strBool) == true))
					{
						koment = "Grupi ka pasur kliente te tjere per datat e caktuara";
						koment += Environment.NewLine + "te cilet kane dale te gjithe nga hoteli!";
						koment += Environment.NewLine + "Nuk mund te shtoni kliente te tjere per kete hyrje!";
						System.Windows.Forms.MessageBox.Show(this, koment, "Merr dhome", MessageBoxButtons.OK,MessageBoxIcon.Error);
						this.numCmimiGrup.Text = "";
						this.numKapariGrupi.Text = "";
						this.cmbPagesaGrupi.Kolone1.Text = "";
						return;		
					}
					int idPergjegjes = Convert.ToInt32(drg["PERGJEGJES"]);
					if ((this.idRezervimi != 0)&&(!Convert.IsDBNull(drg["ID_REZERVIMI_STR"])))//nuk eshte gjetur rezervim
					{
						//shohim nqs hyrjet qe po behen i perkasin ndonje rezervimi
						this.idRezervimi = Convert.ToInt32(data.KerkesaRead("ShfaqTeDhenaKlientiId", idPergjegjes).Tables[0].Rows[0]["ID_REZERVIMI"]);
					}
					DataSet dsFormaPagesa = data.KerkesaRead("ShfaqFormePageseKaparDhome", idPergjegjes);
					kapari = Convert.ToInt32(drg["KAPARI"]);
					if (dsFormaPagesa.Tables[0].Rows.Count != 0)
					{
						idFormaPagesa = Convert.ToInt32(dsFormaPagesa.Tables[0].Rows[0]["ID_FORMAPAGESA"]);
						emriPagesa = Convert.ToString(dsFormaPagesa.Tables[0].Rows[0]["EMRI"]);
					}
					else
					{
						idFormaPagesa = 1;
						emriPagesa = "Cash";
						kapari = 0;
					}
					this.numKapariGrupi.Text = kapari.ToString();
					this.cmbPagesaGrupi.Kolone1.Text = emriPagesa;
					this.cmbPagesaGrupi.Kolone1Vlere = emriPagesa;
					this.cmbPagesaGrupi.Kolone2.Text = idFormaPagesa.ToString();
					this.cmbPagesaGrupi.Kolone2Vlere = idFormaPagesa.ToString();
					this.numKapariGrupi.ReadOnly = true;
					this.cmbPagesaGrupi.Enabled = false;
				}
				else
				{
					idFormaPagesa = 1;
					emriPagesa = "Cash";
					kapari = 0;
					this.numKapariGrupi.Text = kapari.ToString();
					this.cmbPagesaGrupi.Kolone1.Text = emriPagesa;
					this.cmbPagesaGrupi.Kolone1Vlere = emriPagesa;
					this.cmbPagesaGrupi.Kolone2.Text = idFormaPagesa.ToString();
					this.cmbPagesaGrupi.Kolone2Vlere = idFormaPagesa.ToString();
				}
				ds.Tables.Clear();
				ds = data.KerkesaRead("ShfaqKlientPerDhomePerDatat",idDhoma,dtFillimi,dtMbarimi);
				this.nrKrevatZeneGrupi = ds.Tables[0].Rows.Count;
				bool ugjet = false;
				idFormaPagesa = 1;
				emriPagesa = "Cash";
				kapari = 0;
				bool klientetjotegrupit = false;
				foreach(DataRow dr1 in ds.Tables[0].Rows)
				{
					if ( Convert.IsDBNull(dr1["ID_GRUPI"]))
					{
						klientetjotegrupit = true;
						break;
					}
					if (Convert.ToInt32(dr1["ID_GRUPI"]) != idGrupi)
					{
						klientetjotegrupit = true;
						break;
					}
				}
				if ((nrKrevatZeneGrupi != 0)&&(klientetjotegrupit))
				{
					for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
					{
						if(Convert.ToInt32(ds.Tables[0].Rows[i][5]) != 0 )
						{
							ugjet = true;
							kapari = Convert.ToInt32(ds.Tables[0].Rows[i][5]);
							idFormaPagesa = Convert.ToInt32(ds.Tables[1].Rows[0]["ID_FORMAPAGESA"]);
							emriPagesa = Convert.ToString(ds.Tables[1].Rows[0]["EMRI"]);
							break;
						}
						else
							kapari = 0;
					}
					if (ugjet)
					{
						this.cmbPagesaGrupi.Kolone1.Text = emriPagesa;
						this.cmbPagesaGrupi.Kolone1Vlere = emriPagesa;
						this.cmbPagesaGrupi.Kolone2.Text = idFormaPagesa.ToString();
						this.cmbPagesaGrupi.Kolone2Vlere = idFormaPagesa.ToString();
					}
					else
					{
						this.cmbPagesaGrupi.Kolone1.Text = "Cash";
						this.cmbPagesaGrupi.Kolone1Vlere = "Cash";
						this.cmbPagesaGrupi.Kolone2.Text = "1";
						this.cmbPagesaGrupi.Kolone2Vlere = "1";
					}
					this.numKapariGrupi.Text = kapari.ToString();	
					this.numKapariGrupi.ReadOnly = true;
					this.cmbPagesaGrupi.Enabled = false;
				}
				this.label23.Visible = true;
				this.MbushPanelGrupi();
				this.panelCmimiGrupi.Visible = true;
				this.numCmimiGrup.Visible = true;
				this.numKapariGrupi.Visible = true;
				this.lblCmimiGrupi.Visible = true;
				this.lblKapariGrupi.Visible = true;
				this.btnPagesaGrupi.Visible = true;		
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
		private void cmbGrupet_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				int idGrupi = Convert.ToInt32(this.cmbGrupet.Kolone2Vlere);
				InputController data = new InputController();
				DataSet ds = data.KerkesaRead("ShfaqGrupin", idGrupi);
				DataRow dr = ds.Tables[0].Rows[0];
				this.txtAgjensia.Text = dr[1].ToString();
				this.txtGrupi.Text =  dr[0].ToString();
				this.txtEmailGr.Text = dr["EMAILI"].ToString();
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

		private void RefreshGrupi()
		{
			this.txtEmriGrupi.Clear();
			this.txtMbiemriGrupi.Clear();
			this.txtEmailGrupi.Clear();
			this.txtAdresaGrupi.Clear();
			this.txtIdNoGrupi.Clear();
			this.txtTargaGrupi.Clear();
			//this.numCmimiGrup.Clear();
			this.txtTelefoniGrupi.Clear();
			//this.numKapariGrupi.Clear();
			//this.cmbGrupet1.Kolone1.Text = "";
			//this.cmbKategoriaGrupi.Kolone1.Text = "";
			this.cmbMjetIdGrupi.Kolone1.Text = "";
			//this.cmbDhomaGrupi.Kolone1.Text = "";
			this.dtpDatelindjaGrupi.Text = System.DateTime.Now.ToString();
			//this.dtpFillimiGrupi.Text = System.DateTime.Now.ToString();
			//this.dtpMbarimiGrupi.Text = System.DateTime.Now.ToString();
			this.txtVendlindjaGrupi.Text = "";
			this.txtShtetesiaGrupi.Text = "";
		}
		
		private void BuildDsGrupi()
		{
			
			dsKlientiGrupi.Tables.Add("KLIENTI");
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("ID_GRUPI",typeof(int));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("EMRI",typeof(string));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("MBIEMRI",typeof(string));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("DATELINDJA",typeof(DateTime));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("ID_MJETIDENTIFIKIMI",typeof(int));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("NR_IDENTIFIKIMI",typeof(string));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("ADRESA",typeof(string));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("TELEFONI",typeof(string));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("TARGA",typeof(string));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("EMAIL",typeof(string));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("ID_DHOMA",typeof(int));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("KAPARI",typeof(int));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("DATA_HYRJE",typeof(DateTime));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("DATA_DALJE",typeof(DateTime));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("DATA_KAPARI",typeof(DateTime));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("VENDLINDJA",typeof(String));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("SHTETESIA",typeof(String));
			dsKlientiGrupi.AcceptChanges();
		}
		private void MbushKategoriteGrupi()
		{
			DataSet ds = null;
			InputController data = new InputController();
			this.cmbKategoriaGrupi.Kolone1.Items.Clear();
			this.cmbKategoriaGrupi.Kolone2.Items.Clear();
			ds = data.KerkesaRead("ShfaqKategorite");
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbKategoriaGrupi.Kolone1.Items.Add(dr[1]);
				this.cmbKategoriaGrupi.Kolone2.Items.Add(dr[0]);
			}
		}
		private void btnShtoKlGrupi_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				int b = 0;
				int kapari = 0;
				InputController data = new InputController();
				DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimiGrupi.Value);
				DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimiGrupi.Value);
				idKategoria = Convert.ToInt32(this.cmbKategoriaGrupi.Kolone2Vlere);
				int a = this.KntData(dataFillimi,dataMbarimi);
				if(a == 0)
				{
					this.dtpFillimiGrupi.IsValid = true;
					this.error.SetError(this.dtpFillimiGrupi,"");
				
					int idGrupi = Convert.ToInt32(this.cmbGrupet1.Kolone2Vlere);
					string emri = this.txtEmriGrupi.Text;
					string mbiemri = this.txtMbiemriGrupi.Text;
					DateTime datelindja = Convert.ToDateTime(this.dtpDatelindjaGrupi.Value);
					int idMjetIdentifikimi = Convert.ToInt32(this.cmbMjetIdGrupi.Kolone2Vlere); // vlera merret nga kombo e mjeteve te identifikimit;
					string nrIdentifikimi = this.txtIdNoGrupi.Text;
					string adresa = this.txtAdresaGrupi.Text;
					string telefoni = this.txtTelefoniGrupi.Text;
					string targa = this.txtTargaGrupi.Text;
					string email = this.txtEmailGrupi.Text;
					int idDhoma = Convert.ToInt32(this.cmbDhomaGrupi.Kolone2Vlere); // vlera merret nga kombo e dhomave
					string vendlindja = this.txtVendlindjaGrupi.Text;
					string shtetesia = this.txtShtetesiaGrupi.Text;
					int nrKlienteNeDhomePerGrup = Convert.ToInt32(data.KerkesaRead("nrKlienteNeDhomePerGrup",idDhoma,dataFillimi, dataMbarimi, idGrupi).Tables[0].Rows[0][0]);
					int nrKlienteshNeDhome = Convert.ToInt32(data.KerkesaRead("NumerKlienteshPerDateDhoma",idDhoma,dataFillimi, dataMbarimi).Tables[0].Rows[0][0]);
					int nrKlienteJoTeGrupit = nrKlienteshNeDhome - nrKlienteNeDhomePerGrup;
					if (nrKlienteJoTeGrupit > 0)
					{
						System.Windows.Forms.MessageBox.Show(this, "Ky klient nuk mund te shtohet!" + Environment.NewLine + "Ne dhome ka kliente qe nuk i perkasin grupit " + this.cmbGrupet1.Kolone1Vlere.ToString() + "!" , "Merr dhome", MessageBoxButtons.OK , MessageBoxIcon.Error);
						return;
					}
					kapari = Convert.ToInt32(this.numKapariGrupi.Text);
					if ((kapari > 0)&&(this.cmbPagesaGrupi.Kolone1.SelectedItem == null))
					{
						this.error.SetError(this.cmbPagesaGrupi, "Zgjidhni formen e pageses!");
						return;
					}
					this.error.SetError(this.cmbPagesaGrupi, "");
					if(this.nrKlientShteseGrupi == 0 && this.numKapariGrupi.ReadOnly == false)
					{
						kapari = Convert.ToInt32(this.numKapariGrupi.Text);
						this.numKapariGrupi.ReadOnly = true;
						this.cmbPagesaGrupi.Enabled = false;
					}
					else
						kapari = 0;
					if(Convert.ToInt32(this.cmbKategoriaGrupi.Kolone2Vlere) == 31)
					{
						System.TimeSpan difDite = dataMbarimi.Subtract(dataFillimi);
						int nrNjesi = Convert.ToInt32(difDite.Days);
						double nrNjesiOre = Convert.ToDouble(difDite.Hours);
						int nrNjesiOre2 = Convert.ToInt32(nrNjesiOre);
						double nrNjesiMin = Convert.ToDouble(difDite.Minutes);
						double nrNjesiOre1 = nrNjesiMin/60;
						nrNjesiOre = ((nrNjesi*12)+nrNjesiOre)-nrNjesiOre1;	
						nrNjesi = Convert.ToInt32(nrNjesiOre);
						int shuma1 = nrNjesi * Convert.ToInt32(this.numCmimiGrup.Text);
						if(kapari > shuma1)
						{
							this.numKapariGrupi.IsValid = false;
							this.error.SetError(this.numKapariGrupi,"Kapari nuk mund te kete vlere me te madhe se pagesa e dhomes" + Environment.NewLine + "Jepni nje vlere te njejte ose me te vogel se pagesa!");
							this.numKapariGrupi.ReadOnly = false;
							this.cmbPagesaGrupi.Enabled = true;
							return;
						}
					}
					else
					{
						System.TimeSpan difDite = dataMbarimi.Date.Subtract(dataFillimi.Date);
						int shuma = Convert.ToInt32(difDite.Days) * Convert.ToInt32(this.numCmimiGrup.Text);
						if (kapari > shuma)
						{
							this.numKapariGrupi.IsValid = false;
							this.error.SetError(this.numKapariGrupi,"Kapari nuk mund te kete vlere me te madhe se pagesa e dhomes" + Environment.NewLine + "Jepni nje vlere te njejte ose me te vogel se pagesa!");
							this.numKapariGrupi.ReadOnly = false;
							this.cmbPagesaGrupi.Enabled = true;
							return;
						}
					}
					DateTime dataKapari = dataFillimi.AddMilliseconds(DateTime.Now.Millisecond);
					nrKlientShteseGrupi = nrKlientShteseGrupi +1;
					if(this.nrKlientShteseGrupi > this.nrKrevatGrupi)
					{
						System.Windows.Forms.MessageBox.Show(this, 	"Kujdes kapaciteti i dhomes eshte plotesuar,"+
							Environment.NewLine+"ne kete dhome nuk mund te futen kliente te tjere!","Merr dhome ", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.RefreshGrupi();
						return;
					}
					DataRow r = this.dsKlientiGrupi.Tables["KLIENTI"].NewRow();
					r[0] = idGrupi;
					r[1] = emri;
					r[2] = mbiemri;
					r[3] = datelindja;
					r[4] = idMjetIdentifikimi;
					r[5] = nrIdentifikimi;
					r[6] = adresa;
					r[7] = telefoni;
					r[8] = targa;
					r[9] = email;
					r[10] = idDhoma;
					r[11] = kapari;
					r[12] = dataFillimi;
					r[13] = dataMbarimi;
					r[14] = dataKapari;
					r[15] = vendlindja;
					r[16] = shtetesia;
					this.dsKlientiGrupi.Tables["KLIENTI"].Rows.Add(r);
					this.dsKlientiGrupi.AcceptChanges();
					
				
					this.PastroPanelGrupi();
					this.nrKrevatZeneGrupi = this.nrKrevatZeneGrupi +1;
					this.MbushPanelGrupi();
					this.RefreshGrupi();
				}
				else if(a == 1)
				{
					this.dtpFillimiGrupi.IsValid = false;
					this.error.SetError(this.dtpFillimiGrupi, "Data e hyrjes se klientit duhet te jete me e vogel se data e daljes!");
					this.cmbKategoriaGrupi.Kolone1.Text = "";
					this.MbushKategoriteGrupi();
					return;
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
		
		private void MbushGrupet()
		{
			this.cmbGrupet.Kolone1.Items.Clear();
			this.cmbGrupet.Kolone2.Items.Clear();
			this.cmbGrupet1.Kolone1.Items.Clear();
			this.cmbGrupet1.Kolone2.Items.Clear();
			InputController data = new InputController();
			DataSet ds = null;
			ds = data.KerkesaRead("ShfaqGrupet");
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbGrupet.Kolone1.Items.Add(dr[1]);
				this.cmbGrupet.Kolone2.Items.Add(dr[0]);
				this.cmbGrupet1.Kolone1.Items.Add(dr[1]);
				this.cmbGrupet1.Kolone2.Items.Add(dr[0]);
			}

		}
		private void btnShto_Click(object sender, System.EventArgs e)
		{
			try
			{
				InputController data = new InputController();
				int a = this.ValidateGrupiShto();
				if(a == 0)
				{
					string emerGrupi = this.txtGrupi.Text;
					string emerAgjensia = this.txtAgjensia.Text;
					string email = this.txtEmailGr.Text;
					int b = data.KerkesaUpdate("KrijoGrup", emerGrupi, emerAgjensia, email);
					if (b == 0)
						VisionInfoSolutionLibrary.MessageBox.Show(this, "Shtimi i grupeve",
							"Grupi u shtua!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					else if(b == 1)
						System.Windows.Forms.MessageBox.Show(this, 
							"Emri i zgjedhur per grupin eshte perdorur me pare."
							+Environment.NewLine+"Ju lutemi zgjidhni nje emer te ri!","Shtimi i grupeve", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.txtGrupi.Clear();
					this.txtAgjensia.Clear();
					this.txtEmailGr.Text = "";
					this.cmbGrupet.Kolone1.Text = "";
					this.cmbGrupet.Kolone1.Items.Clear();
					this.cmbGrupet.Kolone2.Items.Clear();
					this.cmbGrupet1.Kolone1.Items.Clear();
					this.cmbGrupet1.Kolone2.Items.Clear();
					this.MbushGrupet();
				}
				else
					return;
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
		private int  ValidateGrupiShto()
		{
			int a = 0;
			if(this.txtGrupi.Text == "" )
			{
				this.txtGrupi.IsValid = false;
				this.error.SetError(this.txtGrupi,"Ju duhet te jepni nje emer per grupin e ri, perpara se ta shtoni ate!");
				a = 1;
			}
			else if(this.txtAgjensia.Text == "")
			{
				this.txtAgjensia.IsValid = false;
				this.error.SetError(this.txtAgjensia,"Ju duhet te jepni nje emer per agjensine, perpara se ta shtoni grupin!");
				a = 1;
			}
			else
				return a;
			return a;
		}
				
		private int  ValidateGrupiModifiko()
		{
			int a = 0;
			if(this.cmbGrupet.Kolone1.Text == "")
			{
				this.cmbGrupet.IsValid = false;
				this.error.SetError(this.cmbGrupet,"Juduhet te zgjidhni nje prej grupeve ekzistuese!");
				a = 1;
			}
			else
				return a ;
			return a;
		}
		private void btnModifiko_Click(object sender, System.EventArgs e)
		{
			try
			{
				int a = this.ValidateGrupiModifiko();
				if (a == 0)
				{
					int c = this.ValidateGrupiShto();
					if(c == 0)
					{
						InputController data = new InputController();
						int idGrupi = Convert.ToInt32(this.cmbGrupet.Kolone2Vlere);
						string grupi = this.txtGrupi.Text;
						string agjensia = this.txtAgjensia.Text;
						string emaili = this.txtEmailGr.Text;
						int b  = data.KerkesaUpdate("ModifikoGrup",idGrupi,grupi,agjensia, emaili);
						if(b == 0)
							VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i grupeve", "Grupi i zgjedhur u modifikua.",
								MessageBoxButtons.OK, MessageBoxIcon.Information);
						else if(b == 1)
							System.Windows.Forms.MessageBox.Show(this, 
								"Emri i zgjedhur per grupin eshte perdorur me pare."
								+Environment.NewLine+"Ju lutemi zgjidhni nje emer te ri!","Shtimi i grupeve", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.txtGrupi.Clear();
						this.txtAgjensia.Clear();
						this.txtEmailGr.Clear();
						this.cmbGrupet.Kolone1.Text = "";
					
						this.MbushGrupet();
					}
					else
						return;
				}
				else
					return ;
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

		private void btnElemino_Click(object sender, System.EventArgs e)
		{
			try
			{
				int a = this.ValidateGrupiModifiko();
				if (a == 0)
				{
					InputController data = new InputController();
					int idGrupi = Convert.ToInt32(this.cmbGrupet.Kolone2Vlere);
					int b  = data.KerkesaUpdate("FshiGrup",idGrupi);
					if(b == 0)
						VisionInfoSolutionLibrary.MessageBox.Show(this, "Elimini i grupeve",
							"Grupi i zgjedhur u eliminua.", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if( b == 2)
						System.Windows.Forms.MessageBox.Show(this,"Grupi i zgjedhur nuk mund te eliminohet,"
							+Environment.NewLine+"kliente te grupit jane ende ne hotel!","Eliminimi i grupeve",MessageBoxButtons.OK,MessageBoxIcon.Information);
					if(b == 1)
						System.Windows.Forms.MessageBox.Show(this,"Grupi i zgjedhur nuk mund te eliminohet,"
							+Environment.NewLine+"me pare duhet te eliminohen rezervimet e ketij grupi!","Eliminimi i grupeve",MessageBoxButtons.OK,MessageBoxIcon.Information);
					if(b == 3)
						System.Windows.Forms.MessageBox.Show(this,"Grupi i zgjedhur nuk mund te eliminohet,"
							+Environment.NewLine+"me pare duhet te eliminohen klientet e ketij grupi!","Eliminimi i grupeve",MessageBoxButtons.OK,MessageBoxIcon.Information);
					this.txtGrupi.Clear();
					this.txtAgjensia.Clear();
					this.txtEmailGr.Text = "";
					this.cmbGrupet.Kolone1.Text = "";
					this.cmbGrupet.Kolone1.Items.Clear();
					this.cmbGrupet.Kolone2.Items.Clear();
					this.cmbGrupet1.Kolone1.Items.Clear();
					this.cmbGrupet1.Kolone2.Items.Clear();
					this.MbushGrupet();
				
				}
				else
					return ;
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

//		private void btnPagesaGrupi_Click_1(object sender, System.EventArgs e)
//		{
//			try
//			{
//				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimiGrupi.Value);
//				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimiGrupi.Value);
//				int idKategoria = Convert.ToInt32(this.cmbKategoriaGrupi.Kolone2Vlere);
//				int cmimi = Convert.ToInt32(this.numCmimiGrup.Text);
//				int kapari = Convert.ToInt32(this.numKapariGrupi.Text);
//				string njesi = "";
//				string str = "";
//				string strPagesa = "";
//				string strDite = "";
//				if (idKategoria == 31)
//				{
//					System.TimeSpan difDite1 = dtMbarimi.Subtract(dtFillimi);
//					double ore = Math.Round(difDite1.TotalHours, 1);
////					double pagesa = ore * cmimi - Convert.ToDouble(kapari);
//					double pagesa = ore * cmimi;
////					str = ore + " x " + cmimi + " - " + kapari + " = " + pagesa;	
//					str = ore + " x " + cmimi + " = " + pagesa;	
//					strPagesa = pagesa.ToString();
//					strDite = ore.ToString();
//					njesi = "ore";
//				}
//				else
//				{
//					System.TimeSpan difDite1 = dtMbarimi.Date.Subtract(dtFillimi.Date);
//					int dite = difDite1.Days;
////					int pagesa = dite * cmimi - kapari;
//					int pagesa = dite * cmimi;
////					str = dite + " x " + cmimi + " - " + kapari + " = " + pagesa;
//					str = dite + " x " + cmimi  + " = " + pagesa;
//					strDite = dite.ToString();
//					strPagesa = pagesa.ToString();
//					njesi = "dite";
//				}
//				string koment = "Pagesa per dhomen e zgjedhur per " + strDite + " " + njesi + " eshte " + strPagesa;
//				koment += Environment.NewLine + str;
//				System.Windows.Forms.MessageBox.Show(this, koment, "Merr dhome", MessageBoxButtons.OK, MessageBoxIcon.Information);
//			}
//			catch(SqlException ex)
//			{
//				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
//				return;
//			}
//			catch(Exception ex)
//			{
//				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
//			}
//		}
		private void btnPagesaGrupi_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				if (this.cmbGrupet1.Kolone1.SelectedItem == null)
					return;
				int idGrupi = Convert.ToInt32(this.cmbGrupet1.Kolone2Vlere);
				if (cmbKategoriaGrupi.Kolone1.SelectedItem == null)
					return;
				if (cmbKategoriaGrupi.Kolone1.SelectedItem == null)
					return;
				if (numKapariGrupi.Text == "")
					return;
				int kapariGrupi = Convert.ToInt32(this.numKapariGrupi.Text);
				DateTime dataFillimi = Convert.ToDateTime(dtpFillimiGrupi.Value);
				DateTime dataMbarimi = Convert.ToDateTime(dtpMbarimiGrupi.Value);
				InputController data = new InputController();
				DataSet ds = data.KerkesaRead("ShfaqVeprimetPerGrupin", idGrupi,-1, dataFillimi.AddDays(-30), dataMbarimi.AddDays(30));
				int indexkerkuar = this.KerkoDataSet(ds, dataFillimi, dataMbarimi);
				int shuma1 = 0;
				int kapari = Convert.ToInt32(numKapariGrupi.Text);
				string s = "";
				int idDhomaZgjedhur = Convert.ToInt32(cmbDhomaGrupi.Kolone2Vlere);
				bool dhomePL = false;
				if (indexkerkuar >= 0)//grupi ka tashme nje hyrje ne hotel per keto data
				{
					s = "Pagesa që duhet të bëjë grupi është:";
					s += Environment.NewLine + "Dhomat e zëna:";
					DataRow drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
					string strId = drk["ID_KLIENTI_STR"].ToString();
					DataSet tmp = this.gjejDataSetKlientet(strId);
					DataSet dsPagesa = this.PagesaGrupi(tmp, kapari, 0, 0);
					int i = 0;
					foreach(DataRow dr in dsPagesa.Tables[0].Rows)
					{
						string njesi = "";
						int cmim = 0;
						int pagesaDhoma = 0;
						if (Convert.ToInt32(dr["ID"]) != idDhomaZgjedhur)
						{
							njesi = dr["INTERVALI"].ToString();
							cmim = Convert.ToInt32(dr["CMIMI"]);
							pagesaDhoma = Convert.ToInt32(dr["VLERA"]);
						}
						else//dhoma e zgjedhur ben pjese ne listen e dhomave PL
						{
							dhomePL = true;
							njesi = dr["INTERVALI"].ToString();
							cmim = Convert.ToInt32(numCmimiGrup.Text);
							if ((dataFillimi >= Convert.ToDateTime(dr["MINDATA"]))&&(dataMbarimi <= Convert.ToDateTime(dr["MAXDATA"])))
							{
								//klienti tjeter po futet brenda intervalt te datave te dhomes
								njesi = dr["INTERVALI"].ToString();
								cmim = Convert.ToInt32(dr["CMIMI"]);
								pagesaDhoma = Convert.ToInt32(dr["VLERA"]);
							}
							else
							{
								//intervali i futjes se klientit ndryshon nga ai i dhomes
								DateTime minData = DateTime.Now;
								DateTime maxData = DateTime.Now;
								if (dataFillimi <= Convert.ToDateTime(dr["MINDATA"]))
									minData = dataFillimi;
								else
									minData = Convert.ToDateTime(dr["MINDATA"]);
								if (dataMbarimi <= Convert.ToDateTime(dr["MAXDATA"]))
									maxData = Convert.ToDateTime(dr["MAXDATA"]);
								else
									maxData = dataMbarimi;
								if (njesi.EndsWith("te"))
								{
									TimeSpan ts = maxData.Date.Subtract(minData.Date);
									njesi = Convert.ToInt32(ts.TotalDays) + " dite";
									pagesaDhoma = Convert.ToInt32(cmim * Convert.ToInt32(ts.TotalDays));
								}
								else
								{
									TimeSpan ts = maxData.Subtract(minData);
									njesi = Convert.ToInt32(ts.TotalHours) + " ore";
									pagesaDhoma = Convert.ToInt32(cmim * Convert.ToInt32(ts.TotalHours));
								}
							}
						}
						shuma1 += pagesaDhoma;
						s += Environment.NewLine + (i + 1) + ". " + dr["DHOMA"].ToString() + "    " + njesi + " x " + cmim + " = " + pagesaDhoma;
						i++;
					}
					if (! Convert.IsDBNull(drk["ID_REZERVIMI_STR"])&&(!drk["ID_REZERVIMI_STR"].ToString().StartsWith(Environment.NewLine)))//te pakten nje prej klienteve ka ardhur me rezervim
					{
						if (drk["ID_REZERVIMI_STR"].ToString() != Environment.NewLine)
						{
							int idPergjegjes = Convert.ToInt32(drk["PERGJEGJES"]);
							int idRezervimi = Convert.ToInt32(data.KerkesaRead("ShfaqTeDhenaKlientiId", idPergjegjes).Tables[0].Rows[0]["ID_REZERVIMI"]);
							DataSet dsRezervimi = data.KerkesaRead("ShfaqDataPerRezervim", idRezervimi);
							dsPagesa = data.KerkesaRead("ShfaqDhomaPerRezervimGrupi",idRezervimi);
							if (dsPagesa.Tables[0].Rows.Count != 0)
							{
								s += Environment.NewLine + "Dhomat e rezervuara:";
								DateTime dataFillimiRez = Convert.ToDateTime(dsRezervimi.Tables[0].Rows[0]["DATA_FILLIMI"]);
								DateTime dataMbarimiRez = Convert.ToDateTime(dsRezervimi.Tables[0].Rows[0]["DATA_MBARIMI"]);
								foreach(DataRow dr in dsPagesa.Tables[0].Rows)
								{
									int cmim = Convert.ToInt32(dr["CMIMI"]);
									int idKategoria = Convert.ToInt32(dr["ID_KATEGORIA"]);
									string njesi = "";
									if (idKategoria == 31)
									{
										TimeSpan ts = dataMbarimiRez.Subtract(dataFillimiRez);
										double ore = Math.Round(ts.TotalHours, 1);
										njesi = ore + " ore";
									}
									else
									{
										TimeSpan ts = dataMbarimiRez.Date.Subtract(dataFillimiRez.Date);
										int dite = Convert.ToInt32(ts.TotalDays);
										njesi = dite + " dite";
									}
									int pagesaDhoma = this.GjejPagesen(idKategoria, cmim, dataFillimiRez, dataMbarimiRez);
									shuma1 = shuma1 + pagesaDhoma;
									s += Environment.NewLine + (i + 1) + ". " + dr["DHOMA_EMRI"].ToString() + "    " + njesi + " x " + cmim + " = " + pagesaDhoma;
									i++;
								}
							}
						}
					}
					if (!dhomePL)//nqs dhoma nuk eshte PL shtohet ne llogaritjen e pageses si rresht me vete
					{
						s += Environment.NewLine + "Dhoma e zgjedhur:";
						int idKategoria = Convert.ToInt32(cmbKategoriaGrupi.Kolone2Vlere);
						string njesi = "";
						if (idKategoria == 31)
						{
							TimeSpan ts = dataMbarimi.Subtract(dataFillimi);
							int ore = Convert.ToInt32(ts.TotalHours);
							njesi = ore + " ore";
						}
						else
						{
							TimeSpan ts = dataMbarimi.Date.Subtract(dataFillimi.Date);
							int dite = Convert.ToInt32(ts.TotalDays);
							njesi = dite + " dite";
						}
						int cmimi = Convert.ToInt32(numCmimiGrup.Text);
						int pagesa = this.GjejPagesen(idKategoria, cmimi, dataFillimi, dataMbarimi);
						shuma1 = shuma1 + pagesa;
						s += Environment.NewLine + (i + 1) + ". " + cmbDhomaGrupi.Kolone1.Text + "    " + njesi + " x " + cmimi + " = " + pagesa;
					}	
				
					int shumaMekapar = shuma1 - kapari;
					s += Environment.NewLine + "Totali:   " + shuma1 + " - " + kapari + " = " +shumaMekapar; 
					System.Windows.Forms.MessageBox.Show(this, s, "Llogaritja paraprake e pagesës", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else//grupi nuk ka asnje hyrje ne hotel
				{
					int idKategoria = Convert.ToInt32(cmbKategoriaGrupi.Kolone2Vlere);
					string njesi = "";
					if (idKategoria == 31)
					{
						TimeSpan ts = dataMbarimi.Subtract(dataFillimi);
						int ore = Convert.ToInt32(ts.TotalHours);
						njesi = ore + " ore";
					}
					else
					{
						TimeSpan ts = dataMbarimi.Date.Subtract(dataFillimi.Date);
						int dite = Convert.ToInt32(ts.TotalDays);
						njesi = dite + " dite";
					}
					int cmimi = Convert.ToInt32(numCmimiGrup.Text);
					int pagesa = this.GjejPagesen(idKategoria, cmimi, dataFillimi, dataMbarimi);
					int pagesaMeKapar = pagesa - kapari;
					s = "Pagesa qe duhet te beje grupi per dhomen per " + njesi + " eshte " + pagesaMeKapar;
					s += Environment.NewLine + njesi + " x " + cmimi + " - " + kapari + " = " + pagesaMeKapar;
					System.Windows.Forms.MessageBox.Show(this, s, "Llogaritja paraprake e pagesës", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		private void btnMerrDhomeGrupi_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				int [] b = null;
				int shuma = 0;
				int nrKlient = Convert.ToInt32(this.dsKlientiGrupi.Tables[0].Rows.Count);
				if(nrKlient == 0)
				{
					System.Windows.Forms.MessageBox.Show(this,  "Kujdes, perpara se te merrni nje dhome,"+
						Environment.NewLine+"ju duhet te shtoni te dhenat e nje klienti",
						"Fut klient ne dhome",	MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				InputController data = new InputController();
				b = new int[nrKlient];
				int idFormaPagesa = 0;
				if (this.cmbPagesaGrupi.Kolone1.SelectedItem != null)
					idFormaPagesa = Convert.ToInt32(this.cmbPagesaGrupi.Kolone2Vlere);
				int i = 0;
				foreach(DataRow dr in this.dsKlientiGrupi.Tables[0].Rows)
				{
					if (this.idRezervimi == 0)
					{
						b[i] = data.KerkesaUpdate("FutKlientGrupiNeDhome", Convert.ToInt32(dr[0]),dr[1].ToString(), dr[2].ToString(),
							Convert.ToDateTime(dr[3]), Convert.ToInt32(dr[4]), dr[5].ToString(),
							dr[6].ToString(), dr[7].ToString(), dr[8].ToString(),dr[9].ToString(),  
							Convert.ToInt32(dr[10]),  Convert.ToDateTime(dr[12]), Convert.ToDateTime(dr[13]), Convert.ToInt32(dr[11]),
							Convert.ToDateTime(dr[14]), dr[15].ToString(), dr[16].ToString(), idFormaPagesa, this.PerdoruesId);
					}
					else
					{
						b[i] = data.KerkesaUpdate("FutKlientGrupiNeDhome", Convert.ToInt32(dr[0]),dr[1].ToString(), dr[2].ToString(),
							Convert.ToDateTime(dr[3]), Convert.ToInt32(dr[4]), dr[5].ToString(),
							dr[6].ToString(), dr[7].ToString(), dr[8].ToString(),dr[9].ToString(),  
							Convert.ToInt32(dr[10]),  Convert.ToDateTime(dr[12]), Convert.ToDateTime(dr[13]), Convert.ToInt32(dr[11]),
							Convert.ToDateTime(dr[14]), dr[15].ToString(), dr[16].ToString(), idFormaPagesa, idRezervimi, this.PerdoruesId);
					}
					shuma = shuma + b[i];
					i = i+1;
				}
				if(shuma == 0)
				{
					this.idRezervimi = 0;
					VisionInfoSolutionLibrary.MessageBox.Show(this, "Fut klient ne dhome", "Futja e klienteve te grupit ne dhome, u krye me sukses!",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Fut klient ne dhome", "Deshironi te vazhdoni me kete grup?",
						MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if(result == DialogResult.No)
					{
						this.cmbGrupet1.Kolone1.Text = "";
						this.dtpFillimiGrupi.Text = DateTime.Now.ToString();
						this.dtpMbarimiGrupi.Text = DateTime.Now.ToString();
					}
					this.MbushKategoriteGrupi();
					this.cmbKategoriaGrupi.Kolone1.Text = "";
					this.cmbDhomaGrupi.Kolone1.Text = "";
					this.PastroPanelGrupi();
					this.cmbDhomaGrupi.Kolone1.Items.Clear();
					this.cmbDhomaGrupi.Kolone2.Items.Clear();
					this.panelCmimiGrupi.Visible = false;
					this.label23.Visible = false;
					this.dsKlientiGrupi.Tables[0].Rows.Clear();
					this.txtVendlindjaGrupi.Text = "";
					this.txtShtetesiaGrupi.Text = "";
				}
				else if (shuma != 0)
				{
					VisionInfoSolutionLibrary.MessageBox.Show(this, "Fut klient ne dhome", "Futja e klienteve ne dhome,nuk u krye me sukses!",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		private void cmbGrupet1_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				this.idRezervimi = 0;
				this.dtpFillimiGrupi.Value = DateTime.Now;
				this.dtpMbarimiGrupi.Value = DateTime.Now;
				this.cmbKategoria.Kolone1.Text = "";
				this.cmbKategoria.Kolone2.Text = "";
				this.cmbDhomaGrupi.Kolone1.Text = "";
				this.cmbDhomaGrupi.Kolone2.Text = "";
				this.cmbDhomaGrupi.Kolone1.Items.Clear();
				this.cmbDhomaGrupi.Kolone2.Items.Clear();
				this.PastroPanelGrupi();
				this.numKapariGrupi.Text = "";
				this.numKapariGrupi.ReadOnly = false;
				this.numCmimiGrup.Text = "";
				this.btnPagesaGrupi.Visible = false;
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

		#region MetodaNdihmese
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
		private void dtpFillimiGrupi_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.idRezervimi = 0;
				cmbKategoriaGrupi.Kolone1.Text = "";
				cmbKategoriaGrupi.Kolone2.Text = "";

				cmbDhomaGrupi.Kolone1.Items.Clear();
				cmbDhomaGrupi.Kolone2.Items.Clear();
				cmbDhomaGrupi.Kolone1.Text = "";
				cmbDhomaGrupi.Kolone2.Text = "";

				this.PastroPanelGrupi();
				numCmimiGrup.Text = "";
				numKapariGrupi.Text = "";

				this.cmbPagesaGrupi.Kolone1.Text = "Cash";
				this.cmbPagesaGrupi.Kolone2.Text = "1";
				this.cmbPagesaGrupi.Kolone1Vlere = "Cash";
				this.cmbPagesaGrupi.Kolone2Vlere = "1";
				this.cmbPagesaGrupi.Enabled = true;
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

		private void dtpMbarimiGrupi_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.idRezervimi = 0;
				cmbKategoriaGrupi.Kolone1.Text = "";
				cmbKategoriaGrupi.Kolone2.Text = "";

				cmbDhomaGrupi.Kolone1.Items.Clear();
				cmbDhomaGrupi.Kolone2.Items.Clear();
				cmbDhomaGrupi.Kolone1.Text = "";
				cmbDhomaGrupi.Kolone2.Text = "";

				this.PastroPanelGrupi();
				numCmimiGrup.Text = "";
				numKapariGrupi.Text = "";

				this.cmbPagesaGrupi.Kolone1.Text = "Cash";
				this.cmbPagesaGrupi.Kolone2.Text = "1";
				this.cmbPagesaGrupi.Kolone1Vlere = "Cash";
				this.cmbPagesaGrupi.Kolone2Vlere = "1";
				this.cmbPagesaGrupi.Enabled = true;
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
		private int  KntKonfCmimDhome(DateTime dtFillimi)
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
		private void MbushPanel()
		{
			
			
			int i = 0;
			int lartesi = 0;
			int gjeresi = 0;
			int hapsire = 0;
			int p1 = 0;
			int p2 = 0;
			int h_nr = 0;
//			int v_nr = 0;
			string emri = "";
			if (nrKrevat <= 5)
			{
				lartesi = 30;
				gjeresi = 32;
				hapsire = 5;
				h_nr = 5;
				this.panelCmimi.Visible = true;
				this.panelCmimi.Location = new System.Drawing.Point(4, 168);
				if(this.dhomaKlientiCift == 1)
				{
					if(this.nrKrevatZene == 0)
					{
						emri = "0";
						System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
						pic.Name = emri;
				
						
						pic.Size = new System.Drawing.Size(37,36);
						pic.Location = new System.Drawing.Point(1, 1);
						pic.BorderStyle = System.Windows.Forms.BorderStyle.None;
					
						pic.BackgroundImage = System.Drawing.Image.FromFile (Application.StartupPath + "/Images/krevati-cift-lire.gif");
						pic.Click += new System.EventHandler(this.pic_Click);
						this.panelDhomat.Controls.Add(pic);
						return;
						
					}
					else if(this.nrKrevatZene == 1)
					{
						emri = "0";
						System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
						pic.Name = emri;
				
						
						pic.Size = new System.Drawing.Size(37,36);
						pic.Location = new System.Drawing.Point(1, 1);
						pic.BorderStyle = System.Windows.Forms.BorderStyle.None;
					
						pic.BackgroundImage = System.Drawing.Image.FromFile (Application.StartupPath + "/Images/krevati-cift-pl.gif");
						pic.Click += new System.EventHandler(this.pic_Click);
						this.panelDhomat.Controls.Add(pic);
						return;
						
					}
					else if(this.nrKrevatZene == 2)
					{
						emri = "1";
						System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
						pic.Name = emri;
				
						
						pic.Size = new System.Drawing.Size(37,36);
						pic.Location = new System.Drawing.Point(1, 1);
						pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
					
						pic.BackgroundImage = System.Drawing.Image.FromFile (Application.StartupPath + "/Images/krevati-cift-zene.gif");
						pic.Click += new System.EventHandler(this.pic_Click);
						this.panelDhomat.Controls.Add(pic);
						return;
						
					}
				
				}
				for(int j =0; j<nrKrevatZene;j ++)
				{
							
					emri = ""+j;
					System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
					pic.Name = emri;
				
					pic.Width = gjeresi;
					pic.Height = lartesi;
					p1 = (i % h_nr + 1) * hapsire + (i % h_nr) * gjeresi;
					p2 = (i / h_nr + 1) * hapsire + (i / h_nr) * lartesi;
					pic.Location = new System.Drawing.Point(p1, p2);
					pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
					
					pic.BackgroundImage = System.Drawing.Image.FromFile (Application.StartupPath + "/Images/krevati-zene.gif");
					pic.Click += new System.EventHandler(this.pic_Click);
					this.panelDhomat.Controls.Add(pic);
					i = i + 1;
				}
				for(int j =nrKrevatZene; j<nrKrevat;j ++)
				{
					emri = ""+j;
					System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
					pic.Name = emri;
				
					pic.Width = gjeresi;
					pic.Height = lartesi;
					p1 = (i % h_nr + 1) * hapsire + (i % h_nr) * gjeresi;
					p2 = (i / h_nr + 1) * hapsire + (i / h_nr) * lartesi;
					pic.Location = new System.Drawing.Point(p1, p2);
					pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
					pic.BackgroundImage = System.Drawing.Image.FromFile (Application.StartupPath + "/Images/krevati-lire.gif");
					pic.Click += new System.EventHandler(this.pic_Click);
					this.panelDhomat.Controls.Add(pic);
					i = i + 1;
				}
			}
			else if (nrKrevat>5 && nrKrevat<= 30)
			{
				
				lartesi = 15;
				gjeresi = 15;
				hapsire = 5;
				h_nr = 10;
				int t = 0;
				this.panelCmimi.Visible = true;
				this.panelDhomat.Size = new System.Drawing.Size(213,87);
				this.panelCmimi.Location = new System.Drawing.Point(4, 200);
				
				
				for(int j =0; j<nrKrevatZene;j ++)
				{
					t = j+1;
					emri = ""+j;
					System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
					btn.Name = emri;
					btn.FlatStyle =  System.Windows.Forms.FlatStyle.Flat;
					btn.Width = gjeresi;
					btn.Height = lartesi;
					p1 = (i % h_nr + 1) * hapsire + (i % h_nr) * gjeresi;
					p2 = (i / h_nr + 1) * hapsire + (i / h_nr) * lartesi;
					btn.Location = new System.Drawing.Point(p1, p2);
					btn.BackColor = System.Drawing.Color.SandyBrown;
					btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
					btn.ForeColor = System.Drawing.Color.Navy;
					btn.Click += new System.EventHandler(this.btn_Click);
					this.panelDhomat.Controls.Add(btn);
					i = i + 1;
				}
				for(int j = nrKrevatZene; j<nrKrevat;j ++)
				{
					t = j+1;
					emri = ""+j;
					System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
					btn.Name = emri;
					btn.FlatStyle =  System.Windows.Forms.FlatStyle.Flat;
					btn.Width = gjeresi;
					btn.Height = lartesi;
					p1 = (i % h_nr + 1) * hapsire + (i % h_nr) * gjeresi;
					p2 = (i / h_nr + 1) * hapsire + (i / h_nr) * lartesi;
					btn.Location = new System.Drawing.Point(p1, p2);
					btn.BackColor = System.Drawing.Color.Snow;
					btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
					btn.ForeColor = System.Drawing.Color.Navy;
					btn.Click += new System.EventHandler(this.btn_Click);
					
					this.panelDhomat.Controls.Add(btn);
					i = i + 1;
				}
			}
			else
			{
				this.panelCmimi.Visible = true;
				this.panelDhomat.Size = new System.Drawing.Size(220,40);
				this.panelCmimi.Location = new System.Drawing.Point(4, 168);
				System.Windows.Forms.Label lb = new System.Windows.Forms.Label();
				lb.Size = new System.Drawing.Size(185, 28);
				lb.Visible = true;
				lb.Location = new System.Drawing.Point (4,4);
				lb.ForeColor = System.Drawing.Color.Navy;
				int nrKrevatLire = nrKrevat - this.nrKrevatZene;
				lb.Text = "Kapaciteti i dhomes eshte "+nrKrevatLire+" shtreter te lire dhe "+ nrKrevatZene+" shtreter te zene.";
				this.panelDhomat.Controls.Add(lb);
				i = i + 1;
			}
			
		}

		private void PastroPanel()
		{
			try
			{
				panelDhomat.Controls.Clear();
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

		private void pic_Click(object sender, System.EventArgs e)
		{
			try
			{
				DataSet ds = null;
				string mesazhi = "";
				int idDhoma = Convert.ToInt32(this.cmbDhoma.Kolone2Vlere);
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimi.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqKlientPerDhomePerDatat",idDhoma,dtFillimi,dtMbarimi);
				int nrRreshta = ds.Tables[0].Rows.Count;
				if(nrRreshta == 0)
				{
					//ne dhome nuk ka klient te dhenat qe do shfaqen jane vetem te klinteve te rinj	
				
					
					System.Windows.Forms.PictureBox p = (System.Windows.Forms.PictureBox) sender;
					string emri = p.Name;
					int n = Convert.ToInt32(emri);
					if(n >=nrKlientShtese)
						return;
					else
					{
						if(this.nrKrevatZene  == 2 && this.dhomaKlientiCift  == 1)
						{
							DataRow r2 = dsKlienti.Tables[0].Rows[n];
							string emriKl = dsKlienti.Tables[0].Rows[0][0] + "     " + r2[0].ToString() ;
							string mbiemriKl = dsKlienti.Tables[0].Rows[0][1] + "     " + r2[1].ToString();
							string data_hyrjeK = this.konverto(Convert.ToDateTime(dsKlienti.Tables[0].Rows[0][11])) + "     " + this.konverto(Convert.ToDateTime(r2[11]));
							string data_daljeK = this.konverto(Convert.ToDateTime(dsKlienti.Tables[0].Rows[0][12])) + "     " + this.konverto(Convert.ToDateTime(r2[12]));
							mesazhi = " Klientet e caktuar ne dhome: "+
								Environment.NewLine+
								Environment.NewLine+"  Emri               "+emriKl+
								Environment.NewLine+"  Mbiemri          "+mbiemriKl+
								Environment.NewLine+
								Environment.NewLine+"  Data Hyrje     "+data_hyrjeK+
								Environment.NewLine+"  Data Dalje      "+data_daljeK;
							this.toolTip2.SetToolTip(p , mesazhi);
							return;

						}
						DataRow r = this.dsKlienti.Tables[0].Rows[n];
						string emriK = r[0].ToString();
						string mbiemriK = r[1].ToString();
						string data_hyrje = this.konverto(Convert.ToDateTime(r[11]));
						string data_dalje = this.konverto(Convert.ToDateTime(r[12]));
						mesazhi = " Klienti i caktuar ne dhome: "+
							Environment.NewLine+
							Environment.NewLine+"  Emri               "+emriK+
							Environment.NewLine+"  Mbiemri          "+mbiemriK+
							Environment.NewLine+
							Environment.NewLine+"  Data Hyrje     "+data_hyrje+
							Environment.NewLine+"  Data Dalje      "+data_dalje;
				
						this.toolTip2.SetToolTip(p , mesazhi);
					}
				
				}
				else 
				{	
				
					if(nrKlientShtese != 0)	
					{
						for(int l = 0; l<nrKlientShtese;l++)
						{
							DataRow r = ds.Tables[0].NewRow();
							r[0]=this.dsKlienti.Tables["KLIENTI"].Rows[l][0];
							r[1]=this.dsKlienti.Tables["KLIENTI"].Rows[l][1];
							r[2]=this.dsKlienti.Tables["KLIENTI"].Rows[l][11];
							r[3]=this.dsKlienti.Tables["KLIENTI"].Rows[l][12];
							ds.Tables[0].Rows.Add(r);
							ds.AcceptChanges();
						}
				
						System.Windows.Forms.PictureBox p = (System.Windows.Forms.PictureBox ) sender;
						string emri = p.Name;
						int n = Convert.ToInt32(emri);
						if(n >= nrKrevatZene)
							return;
						else
						{
							if(this.nrKrevatZene  == 2 && this.dhomaKlientiCift  == 1)
							{
								DataRow r2 = ds.Tables[0].Rows[n];
								string emriKl = ds.Tables[0].Rows[0][0] + "     " + r2[0].ToString() ;
								string mbiemriKl = ds.Tables[0].Rows[0][1] + "     " + r2[1].ToString();
								string data_hyrjeK = this.konverto(Convert.ToDateTime(ds.Tables[0].Rows[0][2])) + "     " + this.konverto(Convert.ToDateTime(r2[2]));
								string data_daljeK = this.konverto(Convert.ToDateTime(ds.Tables[0].Rows[0][3])) + "     " + this.konverto(Convert.ToDateTime(r2[3]));
								mesazhi = " Klientet e caktuar ne dhome: "+
									Environment.NewLine+
									Environment.NewLine+"  Emri               "+emriKl+
									Environment.NewLine+"  Mbiemri          "+mbiemriKl+
									Environment.NewLine+
									Environment.NewLine+"  Data Hyrje     "+data_hyrjeK+
									Environment.NewLine+"  Data Dalje      "+data_daljeK;
								this.toolTip2.SetToolTip(p , mesazhi);
								return;

							}
							DataRow r1 = ds.Tables[0].Rows[n];
							string emriK = r1[0].ToString() ;
							string mbiemriK = r1[1].ToString();
							string data_hyrje = this.konverto(Convert.ToDateTime(r1[2]));
							string data_dalje = this.konverto(Convert.ToDateTime(r1[3]));
							mesazhi = " Klienti i caktuar ne dhome: "+
								Environment.NewLine+
								Environment.NewLine+"  Emri               "+emriK+
								Environment.NewLine+"  Mbiemri          "+mbiemriK+
								Environment.NewLine+
								Environment.NewLine+"  Data Hyrje     "+data_hyrje+
								Environment.NewLine+"  Data Dalje      "+data_dalje;
							this.toolTip2.SetToolTip(p , mesazhi);
						}
					}
					else
					{
						System.Windows.Forms.PictureBox p = (System.Windows.Forms.PictureBox) sender;
						string emri = p.Name;
						int n = Convert.ToInt32(emri);
						if(n >= nrKrevatZene)
							return;
						else
						{
							DataRow r1 = ds.Tables[0].Rows[n];
							string emriK = r1[0].ToString();
							string mbiemriK = r1[1].ToString();
							string data_hyrje = this.konverto(Convert.ToDateTime(r1[2]));
							string data_dalje = this.konverto(Convert.ToDateTime(r1[3]));
							mesazhi = " Klienti i caktuar ne dhome: "+
								Environment.NewLine+
								Environment.NewLine+"  Emri               "+emriK+
								Environment.NewLine+"  Mbiemri          "+mbiemriK+
								Environment.NewLine+
								Environment.NewLine+"  Data Hyrje     "+data_hyrje+
								Environment.NewLine+"  Data Dalje      "+data_dalje;
										
							this.toolTip2.SetToolTip(p , mesazhi);
						}
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

		private void btn_Click(object sender, System.EventArgs e)
		{
			try
			{
				DataSet ds = null;
				string mesazhi = "";
				int idDhoma = Convert.ToInt32(this.cmbDhoma.Kolone2Vlere);
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimi.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqKlientPerDhomePerDatat",idDhoma,dtFillimi,dtMbarimi);
				int nrRreshta = ds.Tables[0].Rows.Count;
				if(nrRreshta == 0)
				{
					//ne dhome nuk ka klient te dhenat qe do shfaqen jane vetem te klinteve te rinj	
				
					
					System.Windows.Forms.Button b = (System.Windows.Forms.Button) sender;
					string emri = b.Name;
					int n = Convert.ToInt32(emri);
					if(n >=nrKlientShtese)
						return;
					else
					{
					
						DataRow r = this.dsKlienti.Tables[0].Rows[n];
						string emriK = r[0].ToString();
						string mbiemriK = r[1].ToString();
						string data_hyrje = this.konverto(Convert.ToDateTime(r[11]));
						string data_dalje = this.konverto(Convert.ToDateTime(r[12]));
						mesazhi = " Klienti i caktuar ne dhome: "+
							Environment.NewLine+
							Environment.NewLine+"  Emri               "+emriK+
							Environment.NewLine+"  Mbiemri          "+mbiemriK+
							Environment.NewLine+
							Environment.NewLine+"  Data Hyrje     "+data_hyrje+
							Environment.NewLine+"  Data Dalje      "+data_dalje;
				
						this.toolTip2.SetToolTip(b , mesazhi);
					}
				
				}
				else 
				{	
				
					if(nrKlientShtese != 0)	
					{
						for(int l = 0; l<nrKlientShtese;l++)
						{
							DataRow r = ds.Tables[0].NewRow();
							r[0]=this.dsKlienti.Tables["KLIENTI"].Rows[l][0];
							r[1]=this.dsKlienti.Tables["KLIENTI"].Rows[l][1];
							r[2]=this.dsKlienti.Tables["KLIENTI"].Rows[l][11];
							r[3]=this.dsKlienti.Tables["KLIENTI"].Rows[l][12];
							ds.Tables[0].Rows.Add(r);
							ds.AcceptChanges();
						}
				
						System.Windows.Forms.Button b = (System.Windows.Forms.Button) sender;
						string emri = b.Name;
						int n = Convert.ToInt32(emri);
						if(n >= nrKrevatZene)
							return;
						else
						{
							DataRow r1 = ds.Tables[0].Rows[n];
							string emriK = r1[0].ToString();
							string mbiemriK = r1[1].ToString();
							string data_hyrje = this.konverto(Convert.ToDateTime(r1[2]));
							string data_dalje = this.konverto(Convert.ToDateTime(r1[3]));
							mesazhi = " Klienti i caktuar ne dhome: "+
								Environment.NewLine+
								Environment.NewLine+"  Emri               "+emriK+
								Environment.NewLine+"  Mbiemri          "+mbiemriK+
								Environment.NewLine+
								Environment.NewLine+"  Data Hyrje     "+data_hyrje+
								Environment.NewLine+"  Data Dalje      "+data_dalje;
							this.toolTip2.SetToolTip(b , mesazhi);
						}
					}
					else
					{
						System.Windows.Forms.Button b = (System.Windows.Forms.Button) sender;
						string emri = b.Name;
						int n = Convert.ToInt32(emri);
						if(n >= nrKrevatZene)
							return;
						else
						{
							DataRow r1 = ds.Tables[0].Rows[n];
							string emriK = r1[0].ToString();
							string mbiemriK = r1[1].ToString();
							string data_hyrje = this.konverto(Convert.ToDateTime(r1[2]));
							string data_dalje = this.konverto(Convert.ToDateTime(r1[3]));
							mesazhi = " Klienti i caktuar ne dhome: "+
								Environment.NewLine+
								Environment.NewLine+"  Emri               "+emriK+
								Environment.NewLine+"  Mbiemri          "+mbiemriK+
								Environment.NewLine+
								Environment.NewLine+"  Data Hyrje     "+data_hyrje+
								Environment.NewLine+"  Data Dalje      "+data_dalje;
							this.toolTip2.SetToolTip(b , mesazhi);
						}			
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
				this.Cursor = Cursors.Default;
			}	
		}

		private void MbushPanelGrupi()
		{
			int i = 0;
			int lartesi = 0;
			int gjeresi = 0;
			int hapsire = 0;
			int p1 = 0;
			int p2 = 0;
			int h_nr = 0;
//			int v_nr = 0;
			string emri = "";
			if (nrKrevatGrupi <= 5)
			{
				lartesi = 30;
				gjeresi = 32;
				hapsire = 5;
				h_nr = 5;
				this.panelCmimiGrupi.Visible = true;
				this.panelCmimiGrupi.Location = new System.Drawing.Point(8, 200);
				if(this.dhomaGrupiCift == 1)
				{
					if(this.nrKrevatZeneGrupi == 0)
					{
						emri = "0";
						System.Windows.Forms.PictureBox picG = new System.Windows.Forms.PictureBox();
						picG.Name = emri;
						picG.Size = new System.Drawing.Size(37,36);
						picG.Location = new System.Drawing.Point(1, 1);
						picG.BorderStyle = System.Windows.Forms.BorderStyle.None;
						picG.Image = System.Drawing.Image.FromFile (Application.StartupPath + "/Images/krevati-cift-lire.gif");
						picG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						picG.Click += new System.EventHandler(this.picG_Click);
						this.panelDhomatGrupi.Controls.Add(picG);
						return;
						
					}
					else if(this.nrKrevatZeneGrupi == 1)
					{
						emri = "0";
						System.Windows.Forms.PictureBox picG = new System.Windows.Forms.PictureBox();
						picG.Name = emri;
						picG.Size = new System.Drawing.Size(37,36);
						picG.Location = new System.Drawing.Point(1, 1);
						picG.BorderStyle = System.Windows.Forms.BorderStyle.None;
						picG.Image = System.Drawing.Image.FromFile (Application.StartupPath + "/Images/krevati-cift-pl.gif");
						picG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						picG.Click += new System.EventHandler(this.picG_Click);
						this.panelDhomatGrupi.Controls.Add(picG);
						return;
						
					}
					else if(this.nrKrevatZeneGrupi == 2)
					{
						emri = "1";
						System.Windows.Forms.PictureBox picG = new System.Windows.Forms.PictureBox();
						picG.Name = emri;
						picG.Size = new System.Drawing.Size(37,36);
						picG.Location = new System.Drawing.Point(1, 1);
						picG.BorderStyle = System.Windows.Forms.BorderStyle.None;
						picG.Image = System.Drawing.Image.FromFile (Application.StartupPath + "/Images/krevati-cift-zene.gif");
						picG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						picG.Click += new System.EventHandler(this.picG_Click);
						this.panelDhomatGrupi.Controls.Add(picG);
						return;
						
					}
				}
				for(int j =0; j<nrKrevatZeneGrupi;j ++)
				{
							
					emri = ""+j;
					System.Windows.Forms.PictureBox picG = new System.Windows.Forms.PictureBox();
					picG.Name = emri;
				
					picG.Width = gjeresi;
					picG.Height = lartesi;
					p1 = (i % h_nr + 1) * hapsire + (i % h_nr) * gjeresi;
					p2 = (i / h_nr + 1) * hapsire + (i / h_nr) * lartesi;
					picG.Location = new System.Drawing.Point(p1, p2);
					picG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
					picG.BackgroundImage = System.Drawing.Image.FromFile (Application.StartupPath + "/Images/krevati-zene.gif");
					picG.Click += new System.EventHandler(this.picG_Click);
					this.panelDhomatGrupi.Controls.Add(picG);
					this.panelDhomatGrupi.Size = new Size(196, 36);
					i = i + 1;
				}
				for(int j =nrKrevatZeneGrupi; j<nrKrevatGrupi;j ++)
				{
					emri = ""+j;
					System.Windows.Forms.PictureBox picG = new System.Windows.Forms.PictureBox();
					picG.Name = emri;
				
					picG.Width = gjeresi;
					picG.Height = lartesi;
					p1 = (i % h_nr + 1) * hapsire + (i % h_nr) * gjeresi;
					p2 = (i / h_nr + 1) * hapsire + (i / h_nr) * lartesi;
					picG.Location = new System.Drawing.Point(p1, p2);
					picG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
					picG.BackgroundImage = System.Drawing.Image.FromFile (Application.StartupPath + "/Images/krevati-lire.gif");
					picG.Click += new System.EventHandler(this.picG_Click);
					this.panelDhomatGrupi.Controls.Add(picG);
					i = i + 1;
				}
			}
			else if (nrKrevatGrupi > 5 && nrKrevatGrupi<= 30)
			{
				
				lartesi = 15;
				gjeresi = 15;
				hapsire = 5;
				h_nr = 10;
				int t = 0;
				this.panelCmimiGrupi.Visible = true;
				this.panelDhomatGrupi.Size = new System.Drawing.Size(220,40);
				this.panelCmimiGrupi.Location = new System.Drawing.Point(8,220);
				
				
				for(int j =0; j<nrKrevatZeneGrupi;j ++)
				{
					t = j+1;
					emri = ""+j;
					System.Windows.Forms.Button btnG = new System.Windows.Forms.Button();
					btnG.Name = emri;
					btnG.FlatStyle =  System.Windows.Forms.FlatStyle.Flat;
					btnG.Width = gjeresi;
					btnG.Height = lartesi;
					p1 = (i % h_nr + 1) * hapsire + (i % h_nr) * gjeresi;
					p2 = (i / h_nr + 1) * hapsire + (i / h_nr) * lartesi;
					btnG.Location = new System.Drawing.Point(p1, p2);
					btnG.BackColor = System.Drawing.Color.SandyBrown;
					btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
					btnG.ForeColor = System.Drawing.Color.Navy;
					btnG.Click += new System.EventHandler(this.btnG_Click);
					this.panelDhomatGrupi.Controls.Add(btnG);
					i = i + 1;
				}
				for(int j = nrKrevatZeneGrupi; j<nrKrevatGrupi;j ++)
				{
					t = j+1;
					emri = ""+j;
					System.Windows.Forms.Button btnG = new System.Windows.Forms.Button();
					btnG.Name = emri;
					btnG.FlatStyle =  System.Windows.Forms.FlatStyle.Flat;
					btnG.Width = gjeresi;
					btnG.Height = lartesi;
					p1 = (i % h_nr + 1) * hapsire + (i % h_nr) * gjeresi;
					p2 = (i / h_nr + 1) * hapsire + (i / h_nr) * lartesi;
					btnG.Location = new System.Drawing.Point(p1, p2);
					btnG.BackColor = System.Drawing.Color.Snow;
					btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
					btnG.ForeColor = System.Drawing.Color.Navy;
					btnG.Click += new System.EventHandler(this.btnG_Click);
					
					this.panelDhomatGrupi.Controls.Add(btnG);
					i = i + 1;
				}
			}
			else
			{
				this.panelCmimiGrupi.Visible = true;
				this.panelDhomatGrupi.Size = new System.Drawing.Size(220,40);
				this.panelCmimiGrupi.Location = new System.Drawing.Point(8, 200);
				System.Windows.Forms.Label lb = new System.Windows.Forms.Label();
				lb.Size = new System.Drawing.Size(185, 28);
				lb.Visible = true;
				lb.Location = new System.Drawing.Point (4,4);
				lb.ForeColor = System.Drawing.Color.Navy;
				int nrKrevatLireG = nrKrevatGrupi - this.nrKrevatZeneGrupi;
				nrKrevatZene = this.nrKrevatZeneGrupi;
				lb.Text = "Kapaciteti i dhomes eshte "+nrKrevatLireG+" shtreter te lire dhe "+ nrKrevatZene+" shtreter te zene.";
				this.panelDhomatGrupi.Controls.Add(lb);
				i = i + 1;
			}
			
		}

		private void PastroPanelGrupi()
		{
			try
			{
				this.panelDhomatGrupi.Controls.Clear();
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

		private void picG_Click(object sender, System.EventArgs e)
		{
			try
			{
				DataSet ds = null;
				string mesazhi = "";
				int idDhomaGrupi = Convert.ToInt32(this.cmbDhomaGrupi.Kolone2Vlere);
				DateTime dtFillimiGrupi = Convert.ToDateTime(this.dtpFillimiGrupi.Value);
				DateTime dtMbarimiGrupi = Convert.ToDateTime(this.dtpMbarimiGrupi.Value);
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqKlientPerDhomePerDatat",idDhomaGrupi,dtFillimiGrupi,dtMbarimiGrupi);
				int nrRreshtaG = ds.Tables[0].Rows.Count;
				if(nrRreshtaG == 0)
				{
					//ne dhome nuk ka klient te dhenat qe do shfaqen jane vetem te klinteve te rinj	
				
					
					System.Windows.Forms.PictureBox pg = (System.Windows.Forms.PictureBox) sender;
					string emri = pg.Name;
					int n = Convert.ToInt32(emri);
					if(n >=nrKlientShteseGrupi)
						return;
					else
					{
						if(this.nrKrevatZeneGrupi  == 2 && this.dhomaGrupiCift  == 1)
						{
							DataRow r2 = this.dsKlientiGrupi.Tables[0].Rows[n];
							string emriKl = dsKlientiGrupi.Tables[0].Rows[0][1] + "     " + r2[1].ToString() ;
							string mbiemriKl = dsKlientiGrupi.Tables[0].Rows[0][2] + "     " + r2[2].ToString();
							string data_hyrjeK = this.konverto(Convert.ToDateTime(dsKlientiGrupi.Tables[0].Rows[0][12])) + "     " + this.konverto(Convert.ToDateTime(r2[12]));
							string data_daljeK = this.konverto(Convert.ToDateTime(dsKlientiGrupi.Tables[0].Rows[0][13])) + "     " + this.konverto(Convert.ToDateTime(r2[13]));
							mesazhi = " Klientet e caktuar ne dhome: "+
								Environment.NewLine+
								Environment.NewLine+"  Emri               "+emriKl+
								Environment.NewLine+"  Mbiemri          "+mbiemriKl+
								Environment.NewLine+
								Environment.NewLine+"  Data Hyrje     "+data_hyrjeK+
								Environment.NewLine+"  Data Dalje      "+data_daljeK;
							this.toolTip2.SetToolTip(pg , mesazhi);
							return;

						}
						DataRow r = this.dsKlientiGrupi.Tables[0].Rows[n];
						string emriK = r[1].ToString();
						string mbiemriK = r[2].ToString();
						string data_hyrje = this.konverto(Convert.ToDateTime(r[12]));
						string data_dalje = this.konverto(Convert.ToDateTime(r[13]));
						mesazhi = " Klienti i caktuar ne dhome: "+
							Environment.NewLine+
							Environment.NewLine+"  Emri               "+emriK+
							Environment.NewLine+"  Mbiemri          "+mbiemriK+
							Environment.NewLine+
							Environment.NewLine+"  Data Hyrje     "+data_hyrje+
							Environment.NewLine+"  Data Dalje      "+data_dalje;
				
						this.toolTip2.SetToolTip(pg , mesazhi);
					}
				
				}
				else 
				{	
				
					if(nrKlientShteseGrupi != 0)	
					{
						for(int l = 0; l<nrKlientShteseGrupi;l++)
						{
							DataRow r = ds.Tables[0].NewRow();
//							r[0]=this.dsKlientiGrupi.Tables["KLIENTI"].Rows[l][1];
//							r[1]=this.dsKlientiGrupi.Tables["KLIENTI"].Rows[l][2];
							r[0]=this.dsKlientiGrupi.Tables["KLIENTI"].Rows[l]["EMRI"];
							r[1]=this.dsKlientiGrupi.Tables["KLIENTI"].Rows[l]["MBIEMRI"];
							r[2]=this.dsKlientiGrupi.Tables["KLIENTI"].Rows[l][12];
							r[3]=this.dsKlientiGrupi.Tables["KLIENTI"].Rows[l][13];
							ds.Tables[0].Rows.Add(r);
							ds.AcceptChanges();
						}
				
						System.Windows.Forms.PictureBox pg = (System.Windows.Forms.PictureBox ) sender;
						string emri = pg.Name;
						int n = Convert.ToInt32(emri);
						if(n >= nrKrevatZeneGrupi)
							return;
						else
						{
							if(this.nrKrevatZeneGrupi  == 2 && this.dhomaGrupiCift  == 1)
							{
								DataRow r2 = ds.Tables[0].Rows[n];
								string emriKl = ds.Tables[0].Rows[0]["EMRI"] + "     " + r2[0].ToString() ;
								string mbiemriKl = ds.Tables[0].Rows[0]["MBIEMRI"] + "     " + r2[1].ToString();
								string data_hyrjeK = this.konverto(Convert.ToDateTime(ds.Tables[0].Rows[0][2])) + "     " + this.konverto(Convert.ToDateTime(r2[2]));
								string data_daljeK = this.konverto(Convert.ToDateTime(ds.Tables[0].Rows[0][3])) + "     " + this.konverto(Convert.ToDateTime(r2[3]));
								mesazhi = " Klientet e caktuar ne dhome: "+
									Environment.NewLine+
									Environment.NewLine+"  Emri               "+emriKl+
									Environment.NewLine+"  Mbiemri          "+mbiemriKl+
									Environment.NewLine+
									Environment.NewLine+"  Data Hyrje     "+data_hyrjeK+
									Environment.NewLine+"  Data Dalje      "+data_daljeK;
								this.toolTip2.SetToolTip(pg , mesazhi);
								return;
							}
							DataRow r1 = ds.Tables[0].Rows[n];
							string emriK = r1[0].ToString();
							string mbiemriK = r1[1].ToString();
							string data_hyrje = this.konverto(Convert.ToDateTime(r1[2]));
							string data_dalje = this.konverto(Convert.ToDateTime(r1[3]));
							mesazhi = " Klienti i caktuar ne dhome: "+
								Environment.NewLine+
								Environment.NewLine+"  Emri               "+emriK+
								Environment.NewLine+"  Mbiemri          "+mbiemriK+
								Environment.NewLine+
								Environment.NewLine+"  Data Hyrje     "+data_hyrje+
								Environment.NewLine+"  Data Dalje      "+data_dalje;
							this.toolTip2.SetToolTip(pg , mesazhi);
						}
					}
					else
					{
						System.Windows.Forms.PictureBox pg = (System.Windows.Forms.PictureBox) sender;
						string emri = pg.Name;
						int n = Convert.ToInt32(emri);
						if(n >= nrKrevatZeneGrupi)
							return;
						else
						{
							DataRow r1 = ds.Tables[0].Rows[n];
							string emriK = r1[0].ToString();
							string mbiemriK = r1[1].ToString();
							string data_hyrje = this.konverto(Convert.ToDateTime(r1[2]));
							string data_dalje = this.konverto(Convert.ToDateTime(r1[3]));
							mesazhi = " Klienti i caktuar ne dhome: "+
								Environment.NewLine+
								Environment.NewLine+"  Emri               "+emriK+
								Environment.NewLine+"  Mbiemri          "+mbiemriK+
								Environment.NewLine+
								Environment.NewLine+"  Data Hyrje     "+data_hyrje+
								Environment.NewLine+"  Data Dalje      "+data_dalje;
					
						
							this.toolTip2.SetToolTip(pg , mesazhi);
						}
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

		private void btnG_Click(object sender, System.EventArgs e)
		{
			try
			{
				DataSet ds = null;
				string mesazhi = "";
				int idDhomaGrupi = Convert.ToInt32(this.cmbDhomaGrupi.Kolone2Vlere);
				DateTime dtFillimiGrupi = Convert.ToDateTime(this.dtpFillimiGrupi.Value);
				DateTime dtMbarimiGrupi = Convert.ToDateTime(this.dtpMbarimiGrupi.Value);
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqKlientPerDhomePerDatat",idDhomaGrupi,dtFillimiGrupi,dtMbarimiGrupi);
				int nrRreshtaG = ds.Tables[0].Rows.Count;
				if(nrRreshtaG == 0)
				{
					//ne dhome nuk ka klient te dhenat qe do shfaqen jane vetem te klinteve te rinj	
				
					
					System.Windows.Forms.Button bg = (System.Windows.Forms.Button) sender;
					string emri = bg.Name;
					int n = Convert.ToInt32(emri);
					if(n >=nrKlientShteseGrupi)
						return;
					else
					{
					
						DataRow r = this.dsKlientiGrupi.Tables[0].Rows[n];
						string emriK = r[1].ToString();
						string mbiemri = r[2].ToString();
						string data_hyrje = this.konverto(Convert.ToDateTime(r[12]));
						string data_dalje = this.konverto(Convert.ToDateTime(r[13]));
						mesazhi = " Klienti i caktuar ne dhome: "+
							Environment.NewLine+
							Environment.NewLine+"  Emri               "+emriK+
							Environment.NewLine+"  Mbiemri          "+mbiemri+
							Environment.NewLine+
							Environment.NewLine+"  Data Hyrje     "+data_hyrje+
							Environment.NewLine+"  Data Dalje      "+data_dalje;
					
				
						this.toolTip2.SetToolTip(bg , mesazhi);
					}
				
				}
				else 
				{	
				
					if(nrKlientShteseGrupi != 0)	
					{
						for(int l = 0; l<nrKlientShteseGrupi;l++)
						{
							DataRow r = ds.Tables[0].NewRow();
							r[0]=this.dsKlientiGrupi.Tables["KLIENTI"].Rows[l][1];
							r[1]=this.dsKlientiGrupi.Tables["KLIENTI"].Rows[l][2];
							r[2]=this.dsKlientiGrupi.Tables["KLIENTI"].Rows[l][12];
							r[3]=this.dsKlientiGrupi.Tables["KLIENTI"].Rows[l][13];
							ds.Tables[0].Rows.Add(r);
							ds.AcceptChanges();
						}
				
						System.Windows.Forms.Button bg = (System.Windows.Forms.Button) sender;
						string emri = bg.Name;
						int n = Convert.ToInt32(emri);
						if(n >= nrKrevatZeneGrupi)
							return;
						else
						{
							DataRow r1 = ds.Tables[0].Rows[n];
							string emriK = r1[0].ToString();
							string mbiemri = r1[1].ToString();
							string data_hyrje = this.konverto(Convert.ToDateTime(r1[2]));
							string data_dalje = this.konverto(Convert.ToDateTime(r1[3]));
							mesazhi = " Klienti i caktuar ne dhome: "+
								Environment.NewLine+
								Environment.NewLine+"  Emri               "+emriK+
								Environment.NewLine+"  Mbiemri          "+mbiemri+
								Environment.NewLine+
								Environment.NewLine+"  Data Hyrje     "+data_hyrje+
								Environment.NewLine+"  Data Dalje      "+data_dalje;
					
					
						
							this.toolTip2.SetToolTip(bg , mesazhi);
						}
					}
					else
					{
						System.Windows.Forms.Button bg = (System.Windows.Forms.Button) sender;
						string emri = bg.Name;
						int n = Convert.ToInt32(emri);
						if(n >= nrKrevatZeneGrupi)
							return;
						else
						{
							DataRow r1 = ds.Tables[0].Rows[n];
							string emriK = r1[0].ToString();
							string mbiemriK = r1[1].ToString();
							string data_hyrje = this.konverto(Convert.ToDateTime(r1[2]));
							string data_dalje = this.konverto(Convert.ToDateTime(r1[3]));
							mesazhi = " Klienti i caktuar ne dhome: "+
								Environment.NewLine+
								Environment.NewLine+"  Emri               "+emriK+
								Environment.NewLine+"  Mbiemri          "+mbiemriK+
								Environment.NewLine+
								Environment.NewLine+"  Data Hyrje     "+data_hyrje+
								Environment.NewLine+"  Data Dalje      "+data_dalje;
					
				
							this.toolTip2.SetToolTip(bg , mesazhi);
						}
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

		private string konverto(DateTime data)
		{
			string data_str = data.ToString();
			string dita, muaji, viti, ora;
			dita = data_str.Substring(8, 2);
			muaji = data_str.Substring(5, 2);
			viti = data_str.Substring(0, 4);
			ora =data_str.Substring(11);
			data_str = dita + "-" + muaji + "-" + viti + "/" + ora;
			return data_str;
		}

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
			ds_dhoma.AcceptChanges();
			return ds_dhoma;
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
		#endregion

		private void btnSkano_Click(object sender, System.EventArgs e)
		{
			string[] str = Skanim.Skanim.GetValueFromScan();
			this.txtEmri.Text = str.GetValue(0).ToString();
			this.txtMbiemri.Text = str.GetValue(1).ToString();
			this.txtIdNo.Text = str.GetValue(2).ToString();
		}

		private void btnSkanoGrup_Click(object sender, System.EventArgs e)
		{
			string[] str = Skanim.Skanim.GetValueFromScan();
			this.txtEmriGrupi.Text = str.GetValue(0).ToString();
			this.txtMbiemriGrupi.Text = str.GetValue(1).ToString();
			this.txtIdNoGrupi.Text = str.GetValue(2).ToString();
		}
	}
}

