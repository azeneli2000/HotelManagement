using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using HotelManagment.BusDatService;

namespace HotelManagment.Forms
{
	public class FutRezervimNeDhome : VisionInfoSolutionLibrary.Form
	{
		#region Private Variables
		private VisionInfoSolutionLibrary.TabControl tab;
		private VisionInfoSolutionLibrary.TabPageControl tbIndivid;
		private VisionInfoSolutionLibrary.TabPageControl tbGrup;
		private VisionInfoSolutionLibrary.Button btnFutKlient;
		private VisionInfoSolutionLibrary.GroupBox groupBox3;
		private VisionInfoSolutionLibrary.Label label4;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.RadioButton rbData1;
		private VisionInfoSolutionLibrary.Button btnKerko1;
		private VisionInfoSolutionLibrary.TextBox txtAgjensiaGrupi;
		private VisionInfoSolutionLibrary.TextBox txtEmerGrupi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDataGrupi;
		private VisionInfoSolutionLibrary.RadioButton rbGrupi;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.GroupBox groupBox5;
		private VisionInfoSolutionLibrary.Label lblAdresa;
		private VisionInfoSolutionLibrary.Label label16;
		private VisionInfoSolutionLibrary.Label lblIdNo;
		private VisionInfoSolutionLibrary.Label lblID;
		private VisionInfoSolutionLibrary.Label lblMbiemri;
		private VisionInfoSolutionLibrary.Label lblEmri;
		private VisionInfoSolutionLibrary.TextBox txtIdRezervimi;
		private VisionInfoSolutionLibrary.TextBox txtEmail;
		private VisionInfoSolutionLibrary.TextBox txtTarga;
		private VisionInfoSolutionLibrary.TextBox txtTelefoni;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.Label lblTarga;
		private VisionInfoSolutionLibrary.Label lblEmail;
		private VisionInfoSolutionLibrary.TextBox txtMbiemri;
		private VisionInfoSolutionLibrary.TextBox txtEmri;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimi;
		private VisionInfoSolutionLibrary.Label lblMbarimMarrje;
		private VisionInfoSolutionLibrary.Label lblFillimMarrje;
		private VisionInfoSolutionLibrary.Label lblNrDhoma;
		private VisionInfoSolutionLibrary.NumericBox numCmimiKlienti;
		private VisionInfoSolutionLibrary.Label label7;
		private VisionInfoSolutionLibrary.NumericBox numKapariKlientiRez;
		private VisionInfoSolutionLibrary.Label lblCmimi;
		private VisionInfoSolutionLibrary.Label lblKapari;
		private VisionInfoSolutionLibrary.Button btnPagesaKlienti;
		private VisionInfoSolutionLibrary.Label label26;
		private VisionInfoSolutionLibrary.Label label27;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.Button btnKerko;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.TextBox txtMbiemriKlienti;
		private VisionInfoSolutionLibrary.TextBox txtEmerKlienti;
		private VisionInfoSolutionLibrary.DateTimePicker dtpData;
		private VisionInfoSolutionLibrary.DataGrid gridKlienti;
		private VisionInfoSolutionLibrary.Label label30;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDatelindja;
		private VisionInfoSolutionLibrary.Label label28;
		private VisionInfoSolutionLibrary.TextBox txtIdDhoma;
		private VisionInfoSolutionLibrary.TextBox txtNrIdentifikimi;
		private VisionInfoSolutionLibrary.TextBox txtAdresa;
		private VisionInfoSolutionLibrary.Label label31;
		private VisionInfoSolutionLibrary.Label label23;
		private VisionInfoSolutionLibrary.RadioButton rbData;
		private VisionInfoSolutionLibrary.RadioButton rbEmri;
		private VisionInfoSolutionLibrary.Label label24;
		private System.Windows.Forms.Panel panelDhomat;
		private System.Windows.Forms.ToolTip toolTip2;
		private VisionInfoSolutionLibrary.NumericBox numKapariKlienti;
		private VisionInfoSolutionLibrary.DataGrid gridGrupi;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.Label label6;
		private VisionInfoSolutionLibrary.Label label8;
		private VisionInfoSolutionLibrary.Label label9;
		private VisionInfoSolutionLibrary.TextBox txtDhoma1;
		private VisionInfoSolutionLibrary.Label label10;
		private VisionInfoSolutionLibrary.NumericBox numCmimiGrupi;
		private VisionInfoSolutionLibrary.Label label20;
		private VisionInfoSolutionLibrary.Label label22;
		private VisionInfoSolutionLibrary.Label label12;
		private VisionInfoSolutionLibrary.Label label18;
		private VisionInfoSolutionLibrary.Label label19;
		private VisionInfoSolutionLibrary.TextBox txtGrupi;
		private VisionInfoSolutionLibrary.TextBox txtEmriKlienti;
		private VisionInfoSolutionLibrary.TextBox txtMbiemriKlienti1;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDatelindja1;
		private VisionInfoSolutionLibrary.TextBox txtTelefoni1;
		private VisionInfoSolutionLibrary.TextBox txtAdresa1;
		private VisionInfoSolutionLibrary.Label label17;
		private VisionInfoSolutionLibrary.TextBox txtEmail1;
		private VisionInfoSolutionLibrary.TextBox txtNrIdentGrupi;
		private VisionInfoSolutionLibrary.TextBox txtTarga1;
		private VisionInfoSolutionLibrary.Label label13;
		private VisionInfoSolutionLibrary.Label label15;
		private VisionInfoSolutionLibrary.Label label14;
		private VisionInfoSolutionLibrary.Label label11;
		private VisionInfoSolutionLibrary.Button btnFutKlientGrup;
		private VisionInfoSolutionLibrary.Label label21;
		private VisionInfoSolutionLibrary.Label label25;
		private VisionInfoSolutionLibrary.Button button3;
		private VisionInfoSolutionLibrary.NumericBox numKapariGrupi;
		private VisionInfoSolutionLibrary.NumericBox numKapariRGrupi;
		private VisionInfoSolutionLibrary.Label label33;
		private System.Windows.Forms.Panel panelDhomatGrupi;
		private VisionInfoSolutionLibrary.Button MerrDhomeGrupi;
		private VisionInfoSolutionLibrary.Button btnShtoKlient;
		private VisionInfoSolutionLibrary.Label label29;
		private VisionInfoSolutionLibrary.Label label34;
		private VisionInfoSolutionLibrary.Label label35;
		private VisionInfoSolutionLibrary.TextBox txtVendlindjaKlienti;
		private VisionInfoSolutionLibrary.TextBox txtShtetesiaKlienti;
		private VisionInfoSolutionLibrary.Label label36;
		private VisionInfoSolutionLibrary.Label label37;
		private VisionInfoSolutionLibrary.TextBox txtVendlindjaGrupi;
		private VisionInfoSolutionLibrary.TextBox txtShtetesiaGrupi;
		private VisionInfoSolutionLibrary.Label label38;
		private VisionInfoSolutionLibrary.Label label39;
		private bool hedhurKaparGrupi;
		private System.Data.DataSet ds;
		private int idGrupi;
		private DataSet dsKlienti;
		private int nrKrevat;
		private int nrKrevatZene = 0;
		private int i = 0;
		private int nrKlientShtese = 0;
		private int idDhoma;
		private int idRezervimiGrupi;
		private int idRezervimi;
		private DataSet dsKlientiGrupi;
		private int nrKrevatGrupi;
		private int nrKrevatZeneGrupi = 0;
		private int iG = 0;
		private int nrKlientShteseGrupi = 0;
		private int idDhomaGrupi;
		private int j = 0;
		private int dhomaKlientiCift;
		private int dhomaGrupiCift;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimi1;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimi1;
		private VisionInfoSolutionLibrary.GroupBox groupBox4;
		private VisionInfoSolutionLibrary.DoubleCombo cmbPagesaKlienti;
		private VisionInfoSolutionLibrary.DoubleCombo cmbMjetId;
		private VisionInfoSolutionLibrary.GroupBox groupBox6;
		private VisionInfoSolutionLibrary.DoubleCombo cmbPagesaGrupi;
		private VisionInfoSolutionLibrary.DoubleCombo cmbMjetId1;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimi;
		private VisionInfoSolutionLibrary.Label label32;
		private VisionInfoSolutionLibrary.Button btnSkano;
		private VisionInfoSolutionLibrary.Button btnSkanoGrup;
		private int rowIndex = 0;

		#endregion

		#region Constructors & Destructors
		public FutRezervimNeDhome()
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
			this.btnFutKlient = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox4 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbPagesaKlienti = new VisionInfoSolutionLibrary.DoubleCombo();
			this.lblKapari = new VisionInfoSolutionLibrary.Label();
			this.label38 = new VisionInfoSolutionLibrary.Label();
			this.numKapariKlienti = new VisionInfoSolutionLibrary.NumericBox();
			this.label24 = new VisionInfoSolutionLibrary.Label();
			this.panelDhomat = new System.Windows.Forms.Panel();
			this.dtpMbarimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpFillimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.txtIdDhoma = new VisionInfoSolutionLibrary.TextBox();
			this.lblMbarimMarrje = new VisionInfoSolutionLibrary.Label();
			this.lblFillimMarrje = new VisionInfoSolutionLibrary.Label();
			this.lblNrDhoma = new VisionInfoSolutionLibrary.Label();
			this.numCmimiKlienti = new VisionInfoSolutionLibrary.NumericBox();
			this.label7 = new VisionInfoSolutionLibrary.Label();
			this.numKapariKlientiRez = new VisionInfoSolutionLibrary.NumericBox();
			this.lblCmimi = new VisionInfoSolutionLibrary.Label();
			this.btnPagesaKlienti = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox5 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbMjetId = new VisionInfoSolutionLibrary.DoubleCombo();
			this.lblAdresa = new VisionInfoSolutionLibrary.Label();
			this.label16 = new VisionInfoSolutionLibrary.Label();
			this.lblIdNo = new VisionInfoSolutionLibrary.Label();
			this.lblID = new VisionInfoSolutionLibrary.Label();
			this.lblMbiemri = new VisionInfoSolutionLibrary.Label();
			this.lblEmri = new VisionInfoSolutionLibrary.Label();
			this.txtIdRezervimi = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmail = new VisionInfoSolutionLibrary.TextBox();
			this.txtTarga = new VisionInfoSolutionLibrary.TextBox();
			this.txtTelefoni = new VisionInfoSolutionLibrary.TextBox();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.lblTarga = new VisionInfoSolutionLibrary.Label();
			this.lblEmail = new VisionInfoSolutionLibrary.Label();
			this.txtMbiemri = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
			this.txtShtetesiaKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.txtVendlindjaKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.label35 = new VisionInfoSolutionLibrary.Label();
			this.label34 = new VisionInfoSolutionLibrary.Label();
			this.txtAdresa = new VisionInfoSolutionLibrary.TextBox();
			this.label31 = new VisionInfoSolutionLibrary.Label();
			this.dtpDatelindja = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label28 = new VisionInfoSolutionLibrary.Label();
			this.txtNrIdentifikimi = new VisionInfoSolutionLibrary.TextBox();
			this.label29 = new VisionInfoSolutionLibrary.Label();
			this.label30 = new VisionInfoSolutionLibrary.Label();
			this.label27 = new VisionInfoSolutionLibrary.Label();
			this.label26 = new VisionInfoSolutionLibrary.Label();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.label23 = new VisionInfoSolutionLibrary.Label();
			this.rbEmri = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbData = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.btnKerko = new VisionInfoSolutionLibrary.Button(this.components);
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.txtMbiemriKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmerKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.dtpData = new VisionInfoSolutionLibrary.DateTimePicker();
			this.gridKlienti = new VisionInfoSolutionLibrary.DataGrid();
			this.btnShtoKlient = new VisionInfoSolutionLibrary.Button(this.components);
			this.tbGrup = new VisionInfoSolutionLibrary.TabPageControl();
			this.groupBox6 = new VisionInfoSolutionLibrary.GroupBox();
			this.label32 = new VisionInfoSolutionLibrary.Label();
			this.cmbPagesaGrupi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label10 = new VisionInfoSolutionLibrary.Label();
			this.numCmimiGrupi = new VisionInfoSolutionLibrary.NumericBox();
			this.dtpMbarimi1 = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpFillimi1 = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label39 = new VisionInfoSolutionLibrary.Label();
			this.label33 = new VisionInfoSolutionLibrary.Label();
			this.panelDhomatGrupi = new System.Windows.Forms.Panel();
			this.button3 = new VisionInfoSolutionLibrary.Button(this.components);
			this.numKapariGrupi = new VisionInfoSolutionLibrary.NumericBox();
			this.label25 = new VisionInfoSolutionLibrary.Label();
			this.numKapariRGrupi = new VisionInfoSolutionLibrary.NumericBox();
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.label8 = new VisionInfoSolutionLibrary.Label();
			this.label9 = new VisionInfoSolutionLibrary.Label();
			this.txtDhoma1 = new VisionInfoSolutionLibrary.TextBox();
			this.MerrDhomeGrupi = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbMjetId1 = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label22 = new VisionInfoSolutionLibrary.Label();
			this.label18 = new VisionInfoSolutionLibrary.Label();
			this.label19 = new VisionInfoSolutionLibrary.Label();
			this.txtGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmriKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.txtMbiemriKlienti1 = new VisionInfoSolutionLibrary.TextBox();
			this.dtpDatelindja1 = new VisionInfoSolutionLibrary.DateTimePicker();
			this.txtTelefoni1 = new VisionInfoSolutionLibrary.TextBox();
			this.txtAdresa1 = new VisionInfoSolutionLibrary.TextBox();
			this.label17 = new VisionInfoSolutionLibrary.Label();
			this.txtEmail1 = new VisionInfoSolutionLibrary.TextBox();
			this.txtNrIdentGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtTarga1 = new VisionInfoSolutionLibrary.TextBox();
			this.label13 = new VisionInfoSolutionLibrary.Label();
			this.label15 = new VisionInfoSolutionLibrary.Label();
			this.label14 = new VisionInfoSolutionLibrary.Label();
			this.label11 = new VisionInfoSolutionLibrary.Label();
			this.txtShtetesiaGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtVendlindjaGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.label37 = new VisionInfoSolutionLibrary.Label();
			this.label36 = new VisionInfoSolutionLibrary.Label();
			this.label20 = new VisionInfoSolutionLibrary.Label();
			this.label12 = new VisionInfoSolutionLibrary.Label();
			this.groupBox3 = new VisionInfoSolutionLibrary.GroupBox();
			this.gridGrupi = new VisionInfoSolutionLibrary.DataGrid();
			this.txtAgjensiaGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.txtEmerGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.dtpDataGrupi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.rbGrupi = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbData1 = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.btnKerko1 = new VisionInfoSolutionLibrary.Button(this.components);
			this.label21 = new VisionInfoSolutionLibrary.Label();
			this.btnFutKlientGrup = new VisionInfoSolutionLibrary.Button(this.components);
			this.ds = new System.Data.DataSet();
			this.dsKlienti = new System.Data.DataSet();
			this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
			this.dsKlientiGrupi = new System.Data.DataSet();
			this.btnSkano = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnSkanoGrup = new VisionInfoSolutionLibrary.Button(this.components);
			this.tab.SuspendLayout();
			this.tbIndivid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox5)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridKlienti)).BeginInit();
			this.tbGrup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox6)).BeginInit();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridGrupi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsKlienti)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsKlientiGrupi)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1036, 25);
			// 
			// tab
			// 
			this.tab.Controls.Add(this.tbIndivid);
			this.tab.Controls.Add(this.tbGrup);
			this.tab.Cursor = System.Windows.Forms.Cursors.Default;
			this.tab.Location = new System.Drawing.Point(0, 25);
			this.tab.Name = "tab";
			this.tab.Padding = new System.Drawing.Point(0, 0);
			this.tab.SelectedIndex = 0;
			this.tab.Size = new System.Drawing.Size(1024, 607);
			this.tab.TabIndex = 1;
			this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
			// 
			// tbIndivid
			// 
			this.tbIndivid.BackColor = System.Drawing.SystemColors.Control;
			this.tbIndivid.Controls.Add(this.btnSkano);
			this.tbIndivid.Controls.Add(this.btnFutKlient);
			this.tbIndivid.Controls.Add(this.groupBox4);
			this.tbIndivid.Controls.Add(this.groupBox5);
			this.tbIndivid.Controls.Add(this.groupBox2);
			this.tbIndivid.Controls.Add(this.btnShtoKlient);
			this.tbIndivid.DefaultErrorMessage = null;
			this.tbIndivid.EnableValidation = true;
			this.tbIndivid.IsValid = false;
			this.tbIndivid.Location = new System.Drawing.Point(4, 22);
			this.tbIndivid.Name = "tbIndivid";
			this.tbIndivid.Size = new System.Drawing.Size(1016, 581);
			this.tbIndivid.TabIndex = 0;
			this.tbIndivid.Text = "Individuale";
			// 
			// btnFutKlient
			// 
			this.btnFutKlient.BackColor = System.Drawing.Color.Blue;
			this.btnFutKlient.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFutKlient.DoValidation = false;
			this.btnFutKlient.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnFutKlient.Location = new System.Drawing.Point(596, 424);
			this.btnFutKlient.Name = "btnFutKlient";
			this.btnFutKlient.Size = new System.Drawing.Size(90, 21);
			this.btnFutKlient.TabIndex = 27;
			this.btnFutKlient.Text = "Merr Dhome";
			this.toolTips.SetToolTip(this.btnFutKlient, "Kryen futjen ne dhome te klienteve te shtuar me pare!");
			this.btnFutKlient.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnFutKlient.Click += new System.EventHandler(this.btnFutKlient_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.cmbPagesaKlienti);
			this.groupBox4.Controls.Add(this.lblKapari);
			this.groupBox4.Controls.Add(this.label38);
			this.groupBox4.Controls.Add(this.numKapariKlienti);
			this.groupBox4.Controls.Add(this.label24);
			this.groupBox4.Controls.Add(this.panelDhomat);
			this.groupBox4.Controls.Add(this.dtpMbarimi);
			this.groupBox4.Controls.Add(this.dtpFillimi);
			this.groupBox4.Controls.Add(this.txtIdDhoma);
			this.groupBox4.Controls.Add(this.lblMbarimMarrje);
			this.groupBox4.Controls.Add(this.lblFillimMarrje);
			this.groupBox4.Controls.Add(this.lblNrDhoma);
			this.groupBox4.Controls.Add(this.numCmimiKlienti);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.numKapariKlientiRez);
			this.groupBox4.Controls.Add(this.lblCmimi);
			this.groupBox4.Controls.Add(this.btnPagesaKlienti);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox4.Location = new System.Drawing.Point(476, 240);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(532, 172);
			this.groupBox4.TabIndex = 78;
			this.groupBox4.Text = "Merr dhome";
			this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbPagesaKlienti
			// 
			this.cmbPagesaKlienti.BackColor = System.Drawing.Color.Transparent;
			this.cmbPagesaKlienti.DefaultErrorMessage = "Zgjidhni nje prej formave te pagesave!";
			this.cmbPagesaKlienti.IsValid = false;
			this.cmbPagesaKlienti.Kolone1Vlere = null;
			this.cmbPagesaKlienti.Kolone2Vlere = null;
			this.cmbPagesaKlienti.Location = new System.Drawing.Point(352, 104);
			this.cmbPagesaKlienti.Name = "cmbPagesaKlienti";
			this.cmbPagesaKlienti.ReadOnly = false;
			this.cmbPagesaKlienti.Required = true;
			this.cmbPagesaKlienti.Size = new System.Drawing.Size(160, 21);
			this.cmbPagesaKlienti.SkipValidation = false;
			this.cmbPagesaKlienti.TabIndex = 25;
			// 
			// lblKapari
			// 
			this.lblKapari.BackColor = System.Drawing.SystemColors.Control;
			this.lblKapari.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblKapari.Location = new System.Drawing.Point(252, 52);
			this.lblKapari.Name = "lblKapari";
			this.lblKapari.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblKapari.Size = new System.Drawing.Size(92, 20);
			this.lblKapari.TabIndex = 146;
			this.lblKapari.Text = "Kapar rezervimi";
			// 
			// label38
			// 
			this.label38.Location = new System.Drawing.Point(284, 108);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(60, 20);
			this.label38.TabIndex = 162;
			this.label38.Text = "Pagesa ne ";
			this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numKapariKlienti
			// 
			this.numKapariKlienti.AutoSize = false;
			this.numKapariKlienti.DefaultErrorMessage = "Vendosni 0 ose kaparin per dhomen! ";
			this.numKapariKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numKapariKlienti.DigitsAfterDecimalPoint = 0;
			this.numKapariKlienti.FixedLength = false;
			this.numKapariKlienti.IsValid = false;
			this.numKapariKlienti.KeepFocus = false;
			this.numKapariKlienti.Location = new System.Drawing.Point(352, 76);
			this.numKapariKlienti.Name = "numKapariKlienti";
			this.numKapariKlienti.OnlyPositive = true;
			this.numKapariKlienti.Required = true;
			this.numKapariKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.numKapariKlienti.Size = new System.Drawing.Size(160, 21);
			this.numKapariKlienti.TabIndex = 24;
			this.numKapariKlienti.Text = "";
			this.numKapariKlienti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.SystemColors.Control;
			this.label24.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label24.Location = new System.Drawing.Point(24, 104);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(52, 16);
			this.label24.TabIndex = 160;
			this.label24.Text = "Kapaciteti";
			this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.label24.Visible = false;
			// 
			// panelDhomat
			// 
			this.panelDhomat.BackColor = System.Drawing.Color.Transparent;
			this.panelDhomat.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panelDhomat.Location = new System.Drawing.Point(80, 100);
			this.panelDhomat.Name = "panelDhomat";
			this.panelDhomat.Size = new System.Drawing.Size(196, 52);
			this.panelDhomat.TabIndex = 159;
			// 
			// dtpMbarimi
			// 
			this.dtpMbarimi.BackColor = System.Drawing.Color.White;
			this.dtpMbarimi.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpMbarimi.DefaultErrorMessage = "";
			this.dtpMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimi.IsValid = true;
			this.dtpMbarimi.Location = new System.Drawing.Point(84, 48);
			this.dtpMbarimi.Name = "dtpMbarimi";
			this.dtpMbarimi.Required = false;
			this.dtpMbarimi.ShowCheckBox = true;
			this.dtpMbarimi.ShowUpDown = true;
			this.dtpMbarimi.Size = new System.Drawing.Size(160, 20);
			this.dtpMbarimi.TabIndex = 20;
			this.dtpMbarimi.Value = new System.DateTime(2005, 7, 12, 18, 36, 0, 0);
			this.dtpMbarimi.ValueChanged += new System.EventHandler(this.dtpMbarimi_ValueChanged);
			// 
			// dtpFillimi
			// 
			this.dtpFillimi.BackColor = System.Drawing.Color.White;
			this.dtpFillimi.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpFillimi.DefaultErrorMessage = "";
			this.dtpFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimi.IsValid = true;
			this.dtpFillimi.Location = new System.Drawing.Point(84, 20);
			this.dtpFillimi.Name = "dtpFillimi";
			this.dtpFillimi.Required = false;
			this.dtpFillimi.ShowCheckBox = true;
			this.dtpFillimi.ShowUpDown = true;
			this.dtpFillimi.Size = new System.Drawing.Size(160, 20);
			this.dtpFillimi.TabIndex = 19;
			this.dtpFillimi.Value = new System.DateTime(2005, 7, 12, 18, 36, 0, 0);
			this.dtpFillimi.ValueChanged += new System.EventHandler(this.dtpFillimi_ValueChanged);
			// 
			// txtIdDhoma
			// 
			this.txtIdDhoma.AutoSize = false;
			this.txtIdDhoma.DefaultErrorMessage = "Zgjidhni nje prej rezervmeve!";
			this.txtIdDhoma.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtIdDhoma.FixedLength = false;
			this.txtIdDhoma.IsValid = false;
			this.txtIdDhoma.Location = new System.Drawing.Point(84, 76);
			this.txtIdDhoma.Name = "txtIdDhoma";
			this.txtIdDhoma.ReadOnly = true;
			this.txtIdDhoma.Required = true;
			this.txtIdDhoma.RequiredControlColor = System.Drawing.Color.White;
			this.txtIdDhoma.Size = new System.Drawing.Size(160, 20);
			this.txtIdDhoma.TabIndex = 21;
			this.txtIdDhoma.Text = "";
			// 
			// lblMbarimMarrje
			// 
			this.lblMbarimMarrje.BackColor = System.Drawing.SystemColors.Control;
			this.lblMbarimMarrje.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblMbarimMarrje.Location = new System.Drawing.Point(4, 52);
			this.lblMbarimMarrje.Name = "lblMbarimMarrje";
			this.lblMbarimMarrje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblMbarimMarrje.Size = new System.Drawing.Size(72, 16);
			this.lblMbarimMarrje.TabIndex = 155;
			this.lblMbarimMarrje.Text = "Date mbarimi";
			// 
			// lblFillimMarrje
			// 
			this.lblFillimMarrje.BackColor = System.Drawing.SystemColors.Control;
			this.lblFillimMarrje.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblFillimMarrje.Location = new System.Drawing.Point(12, 24);
			this.lblFillimMarrje.Name = "lblFillimMarrje";
			this.lblFillimMarrje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblFillimMarrje.Size = new System.Drawing.Size(64, 16);
			this.lblFillimMarrje.TabIndex = 154;
			this.lblFillimMarrje.Text = "Date fillimi";
			// 
			// lblNrDhoma
			// 
			this.lblNrDhoma.BackColor = System.Drawing.SystemColors.Control;
			this.lblNrDhoma.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblNrDhoma.Location = new System.Drawing.Point(24, 80);
			this.lblNrDhoma.Name = "lblNrDhoma";
			this.lblNrDhoma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblNrDhoma.Size = new System.Drawing.Size(52, 20);
			this.lblNrDhoma.TabIndex = 153;
			this.lblNrDhoma.Text = "Dhoma";
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
			this.numCmimiKlienti.Location = new System.Drawing.Point(352, 20);
			this.numCmimiKlienti.Name = "numCmimiKlienti";
			this.numCmimiKlienti.OnlyPositive = true;
			this.numCmimiKlienti.ReadOnly = true;
			this.numCmimiKlienti.Required = true;
			this.numCmimiKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimiKlienti.Size = new System.Drawing.Size(160, 21);
			this.numCmimiKlienti.TabIndex = 22;
			this.numCmimiKlienti.Text = "";
			this.numCmimiKlienti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.Control;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label7.Location = new System.Drawing.Point(308, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 20);
			this.label7.TabIndex = 149;
			this.label7.Text = "Kapari";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numKapariKlientiRez
			// 
			this.numKapariKlientiRez.AutoSize = false;
			this.numKapariKlientiRez.DefaultErrorMessage = "Zgjidhni nje prej rezervimeve!";
			this.numKapariKlientiRez.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numKapariKlientiRez.DigitsAfterDecimalPoint = 0;
			this.numKapariKlientiRez.FixedLength = false;
			this.numKapariKlientiRez.IsValid = false;
			this.numKapariKlientiRez.KeepFocus = false;
			this.numKapariKlientiRez.Location = new System.Drawing.Point(352, 48);
			this.numKapariKlientiRez.Name = "numKapariKlientiRez";
			this.numKapariKlientiRez.OnlyPositive = true;
			this.numKapariKlientiRez.ReadOnly = true;
			this.numKapariKlientiRez.Required = true;
			this.numKapariKlientiRez.RequiredControlColor = System.Drawing.Color.White;
			this.numKapariKlientiRez.Size = new System.Drawing.Size(160, 21);
			this.numKapariKlientiRez.TabIndex = 23;
			this.numKapariKlientiRez.Text = "";
			this.numKapariKlientiRez.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblCmimi
			// 
			this.lblCmimi.BackColor = System.Drawing.SystemColors.Control;
			this.lblCmimi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblCmimi.Location = new System.Drawing.Point(284, 24);
			this.lblCmimi.Name = "lblCmimi";
			this.lblCmimi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCmimi.Size = new System.Drawing.Size(60, 20);
			this.lblCmimi.TabIndex = 147;
			this.lblCmimi.Text = "Cmimi";
			// 
			// btnPagesaKlienti
			// 
			this.btnPagesaKlienti.BackColor = System.Drawing.Color.Blue;
			this.btnPagesaKlienti.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPagesaKlienti.DoValidation = false;
			this.btnPagesaKlienti.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnPagesaKlienti.Location = new System.Drawing.Point(384, 136);
			this.btnPagesaKlienti.Name = "btnPagesaKlienti";
			this.btnPagesaKlienti.Size = new System.Drawing.Size(96, 21);
			this.btnPagesaKlienti.TabIndex = 26;
			this.btnPagesaKlienti.Text = "Llogarit pagesen";
			this.toolTips.SetToolTip(this.btnPagesaKlienti, "Llogarit paraprakisht pagesen per dhomen!");
			this.btnPagesaKlienti.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnPagesaKlienti.Click += new System.EventHandler(this.btnPagesaKlienti_Click_1);
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.Transparent;
			this.groupBox5.Controls.Add(this.cmbMjetId);
			this.groupBox5.Controls.Add(this.lblAdresa);
			this.groupBox5.Controls.Add(this.label16);
			this.groupBox5.Controls.Add(this.lblIdNo);
			this.groupBox5.Controls.Add(this.lblID);
			this.groupBox5.Controls.Add(this.lblMbiemri);
			this.groupBox5.Controls.Add(this.lblEmri);
			this.groupBox5.Controls.Add(this.txtIdRezervimi);
			this.groupBox5.Controls.Add(this.txtEmail);
			this.groupBox5.Controls.Add(this.txtTarga);
			this.groupBox5.Controls.Add(this.txtTelefoni);
			this.groupBox5.Controls.Add(this.label3);
			this.groupBox5.Controls.Add(this.lblTarga);
			this.groupBox5.Controls.Add(this.lblEmail);
			this.groupBox5.Controls.Add(this.txtMbiemri);
			this.groupBox5.Controls.Add(this.txtEmri);
			this.groupBox5.Controls.Add(this.txtShtetesiaKlienti);
			this.groupBox5.Controls.Add(this.txtVendlindjaKlienti);
			this.groupBox5.Controls.Add(this.label35);
			this.groupBox5.Controls.Add(this.label34);
			this.groupBox5.Controls.Add(this.txtAdresa);
			this.groupBox5.Controls.Add(this.label31);
			this.groupBox5.Controls.Add(this.dtpDatelindja);
			this.groupBox5.Controls.Add(this.label28);
			this.groupBox5.Controls.Add(this.txtNrIdentifikimi);
			this.groupBox5.Controls.Add(this.label29);
			this.groupBox5.Controls.Add(this.label30);
			this.groupBox5.Controls.Add(this.label27);
			this.groupBox5.Controls.Add(this.label26);
			this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox5.Location = new System.Drawing.Point(476, 8);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(532, 192);
			this.groupBox5.TabIndex = 77;
			this.groupBox5.Text = "Shtimi i klienteve";
			this.groupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbMjetId
			// 
			this.cmbMjetId.BackColor = System.Drawing.Color.Transparent;
			this.cmbMjetId.DefaultErrorMessage = "Zgjidhni nje prej mjeteve te identifikimit!";
			this.cmbMjetId.IsValid = false;
			this.cmbMjetId.Kolone1Vlere = null;
			this.cmbMjetId.Kolone2Vlere = null;
			this.cmbMjetId.Location = new System.Drawing.Point(352, 20);
			this.cmbMjetId.Name = "cmbMjetId";
			this.cmbMjetId.ReadOnly = false;
			this.cmbMjetId.Required = true;
			this.cmbMjetId.Size = new System.Drawing.Size(160, 21);
			this.cmbMjetId.SkipValidation = false;
			this.cmbMjetId.TabIndex = 12;
			// 
			// lblAdresa
			// 
			this.lblAdresa.BackColor = System.Drawing.SystemColors.Control;
			this.lblAdresa.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblAdresa.Location = new System.Drawing.Point(-123, 260);
			this.lblAdresa.Name = "lblAdresa";
			this.lblAdresa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblAdresa.Size = new System.Drawing.Size(89, 20);
			this.lblAdresa.TabIndex = 132;
			this.lblAdresa.Text = "Adresa";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.SystemColors.Control;
			this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label16.Location = new System.Drawing.Point(-135, 176);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(101, 20);
			this.label16.TabIndex = 107;
			this.label16.Text = "Datelindja";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblIdNo
			// 
			this.lblIdNo.BackColor = System.Drawing.SystemColors.Control;
			this.lblIdNo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblIdNo.Location = new System.Drawing.Point(-171, 232);
			this.lblIdNo.Name = "lblIdNo";
			this.lblIdNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblIdNo.Size = new System.Drawing.Size(137, 20);
			this.lblIdNo.TabIndex = 104;
			this.lblIdNo.Text = "Numri i identifikimit";
			// 
			// lblID
			// 
			this.lblID.BackColor = System.Drawing.SystemColors.Control;
			this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblID.Location = new System.Drawing.Point(-167, 204);
			this.lblID.Name = "lblID";
			this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblID.Size = new System.Drawing.Size(133, 20);
			this.lblID.TabIndex = 103;
			this.lblID.Text = "Mjeti i identifikimit";
			// 
			// lblMbiemri
			// 
			this.lblMbiemri.BackColor = System.Drawing.SystemColors.Control;
			this.lblMbiemri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblMbiemri.Location = new System.Drawing.Point(-131, 148);
			this.lblMbiemri.Name = "lblMbiemri";
			this.lblMbiemri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblMbiemri.Size = new System.Drawing.Size(97, 20);
			this.lblMbiemri.TabIndex = 102;
			this.lblMbiemri.Text = "Mbiemri";
			// 
			// lblEmri
			// 
			this.lblEmri.BackColor = System.Drawing.SystemColors.Control;
			this.lblEmri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmri.Location = new System.Drawing.Point(-135, 120);
			this.lblEmri.Name = "lblEmri";
			this.lblEmri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblEmri.Size = new System.Drawing.Size(101, 20);
			this.lblEmri.TabIndex = 101;
			this.lblEmri.Text = "Emri";
			// 
			// txtIdRezervimi
			// 
			this.txtIdRezervimi.AutoSize = false;
			this.txtIdRezervimi.DefaultErrorMessage = "";
			this.txtIdRezervimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtIdRezervimi.FixedLength = false;
			this.txtIdRezervimi.IsValid = true;
			this.txtIdRezervimi.Location = new System.Drawing.Point(-175, 280);
			this.txtIdRezervimi.Name = "txtIdRezervimi";
			this.txtIdRezervimi.Required = false;
			this.txtIdRezervimi.RequiredControlColor = System.Drawing.Color.White;
			this.txtIdRezervimi.Size = new System.Drawing.Size(73, 20);
			this.txtIdRezervimi.TabIndex = 123;
			this.txtIdRezervimi.Text = "0";
			this.txtIdRezervimi.Visible = false;
			// 
			// txtEmail
			// 
			this.txtEmail.AutoSize = false;
			this.txtEmail.DefaultErrorMessage = "";
			this.txtEmail.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmail.FixedLength = false;
			this.txtEmail.IsValid = true;
			this.txtEmail.Location = new System.Drawing.Point(352, 160);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Required = false;
			this.txtEmail.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmail.Size = new System.Drawing.Size(160, 21);
			this.txtEmail.TabIndex = 17;
			this.txtEmail.Text = "";
			// 
			// txtTarga
			// 
			this.txtTarga.AutoSize = false;
			this.txtTarga.DefaultErrorMessage = "";
			this.txtTarga.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTarga.FixedLength = false;
			this.txtTarga.IsValid = true;
			this.txtTarga.Location = new System.Drawing.Point(352, 132);
			this.txtTarga.Name = "txtTarga";
			this.txtTarga.Required = false;
			this.txtTarga.RequiredControlColor = System.Drawing.Color.White;
			this.txtTarga.Size = new System.Drawing.Size(160, 21);
			this.txtTarga.TabIndex = 16;
			this.txtTarga.Text = "";
			// 
			// txtTelefoni
			// 
			this.txtTelefoni.AutoSize = false;
			this.txtTelefoni.DefaultErrorMessage = "";
			this.txtTelefoni.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTelefoni.FixedLength = false;
			this.txtTelefoni.IsValid = true;
			this.txtTelefoni.Location = new System.Drawing.Point(352, 104);
			this.txtTelefoni.Name = "txtTelefoni";
			this.txtTelefoni.Required = false;
			this.txtTelefoni.RequiredControlColor = System.Drawing.Color.White;
			this.txtTelefoni.Size = new System.Drawing.Size(160, 21);
			this.txtTelefoni.TabIndex = 15;
			this.txtTelefoni.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(284, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 20);
			this.label3.TabIndex = 156;
			this.label3.Text = "Nr telefoni";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTarga
			// 
			this.lblTarga.BackColor = System.Drawing.SystemColors.Control;
			this.lblTarga.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblTarga.Location = new System.Drawing.Point(308, 136);
			this.lblTarga.Name = "lblTarga";
			this.lblTarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblTarga.Size = new System.Drawing.Size(36, 20);
			this.lblTarga.TabIndex = 155;
			this.lblTarga.Text = "Targa";
			// 
			// lblEmail
			// 
			this.lblEmail.BackColor = System.Drawing.SystemColors.Control;
			this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmail.Location = new System.Drawing.Point(308, 164);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblEmail.Size = new System.Drawing.Size(36, 16);
			this.lblEmail.TabIndex = 154;
			this.lblEmail.Text = "E-Mail";
			// 
			// txtMbiemri
			// 
			this.txtMbiemri.AutoSize = false;
			this.txtMbiemri.DefaultErrorMessage = "Zgjidhni nje prej rezervimeve!";
			this.txtMbiemri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemri.FixedLength = false;
			this.txtMbiemri.IsValid = false;
			this.txtMbiemri.Location = new System.Drawing.Point(84, 48);
			this.txtMbiemri.Name = "txtMbiemri";
			this.txtMbiemri.ReadOnly = true;
			this.txtMbiemri.Required = true;
			this.txtMbiemri.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemri.Size = new System.Drawing.Size(160, 21);
			this.txtMbiemri.TabIndex = 8;
			this.txtMbiemri.Text = "";
			// 
			// txtEmri
			// 
			this.txtEmri.AutoSize = false;
			this.txtEmri.DefaultErrorMessage = "Zgjidhni nje prej rezervimeve!";
			this.txtEmri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri.FixedLength = false;
			this.txtEmri.IsValid = false;
			this.txtEmri.Location = new System.Drawing.Point(84, 20);
			this.txtEmri.Name = "txtEmri";
			this.txtEmri.ReadOnly = true;
			this.txtEmri.Required = true;
			this.txtEmri.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri.Size = new System.Drawing.Size(160, 21);
			this.txtEmri.TabIndex = 7;
			this.txtEmri.Text = "";
			// 
			// txtShtetesiaKlienti
			// 
			this.txtShtetesiaKlienti.AutoSize = false;
			this.txtShtetesiaKlienti.DefaultErrorMessage = "";
			this.txtShtetesiaKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtShtetesiaKlienti.FixedLength = false;
			this.txtShtetesiaKlienti.IsValid = true;
			this.txtShtetesiaKlienti.Location = new System.Drawing.Point(84, 132);
			this.txtShtetesiaKlienti.Name = "txtShtetesiaKlienti";
			this.txtShtetesiaKlienti.Required = false;
			this.txtShtetesiaKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtShtetesiaKlienti.Size = new System.Drawing.Size(160, 21);
			this.txtShtetesiaKlienti.TabIndex = 11;
			this.txtShtetesiaKlienti.Text = "";
			// 
			// txtVendlindjaKlienti
			// 
			this.txtVendlindjaKlienti.AutoSize = false;
			this.txtVendlindjaKlienti.DefaultErrorMessage = "";
			this.txtVendlindjaKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtVendlindjaKlienti.FixedLength = false;
			this.txtVendlindjaKlienti.IsValid = true;
			this.txtVendlindjaKlienti.Location = new System.Drawing.Point(84, 104);
			this.txtVendlindjaKlienti.Name = "txtVendlindjaKlienti";
			this.txtVendlindjaKlienti.Required = false;
			this.txtVendlindjaKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtVendlindjaKlienti.Size = new System.Drawing.Size(160, 21);
			this.txtVendlindjaKlienti.TabIndex = 10;
			this.txtVendlindjaKlienti.Text = "";
			// 
			// label35
			// 
			this.label35.Location = new System.Drawing.Point(12, 136);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(64, 20);
			this.label35.TabIndex = 174;
			this.label35.Text = "Shtetesia";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(8, 112);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(68, 16);
			this.label34.TabIndex = 173;
			this.label34.Text = "Vendlindja";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAdresa
			// 
			this.txtAdresa.AutoSize = false;
			this.txtAdresa.DefaultErrorMessage = "";
			this.txtAdresa.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAdresa.FixedLength = false;
			this.txtAdresa.IsValid = true;
			this.txtAdresa.Location = new System.Drawing.Point(352, 76);
			this.txtAdresa.Name = "txtAdresa";
			this.txtAdresa.Required = false;
			this.txtAdresa.RequiredControlColor = System.Drawing.Color.White;
			this.txtAdresa.Size = new System.Drawing.Size(160, 21);
			this.txtAdresa.TabIndex = 14;
			this.txtAdresa.Text = "";
			// 
			// label31
			// 
			this.label31.BackColor = System.Drawing.SystemColors.Control;
			this.label31.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label31.Location = new System.Drawing.Point(288, 80);
			this.label31.Name = "label31";
			this.label31.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label31.Size = new System.Drawing.Size(56, 20);
			this.label31.TabIndex = 171;
			this.label31.Text = "Adresa";
			// 
			// dtpDatelindja
			// 
			this.dtpDatelindja.BackColor = System.Drawing.Color.White;
			this.dtpDatelindja.CustomFormat = "dd.MM.yyyy";
			this.dtpDatelindja.DefaultErrorMessage = "";
			this.dtpDatelindja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDatelindja.IsValid = true;
			this.dtpDatelindja.Location = new System.Drawing.Point(84, 76);
			this.dtpDatelindja.Name = "dtpDatelindja";
			this.dtpDatelindja.Required = false;
			this.dtpDatelindja.ShowCheckBox = true;
			this.dtpDatelindja.ShowUpDown = true;
			this.dtpDatelindja.Size = new System.Drawing.Size(160, 20);
			this.dtpDatelindja.TabIndex = 9;
			this.dtpDatelindja.Value = new System.DateTime(2005, 8, 31, 11, 42, 0, 0);
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.SystemColors.Control;
			this.label28.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label28.Location = new System.Drawing.Point(20, 80);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(56, 20);
			this.label28.TabIndex = 169;
			this.label28.Text = "Datelindja";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNrIdentifikimi
			// 
			this.txtNrIdentifikimi.AutoSize = false;
			this.txtNrIdentifikimi.DefaultErrorMessage = "Ju duhet te jepni nr.e identifikimit!";
			this.txtNrIdentifikimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtNrIdentifikimi.FixedLength = false;
			this.txtNrIdentifikimi.IsValid = false;
			this.txtNrIdentifikimi.Location = new System.Drawing.Point(352, 48);
			this.txtNrIdentifikimi.Name = "txtNrIdentifikimi";
			this.txtNrIdentifikimi.Required = true;
			this.txtNrIdentifikimi.RequiredControlColor = System.Drawing.Color.White;
			this.txtNrIdentifikimi.Size = new System.Drawing.Size(160, 21);
			this.txtNrIdentifikimi.TabIndex = 13;
			this.txtNrIdentifikimi.Text = "";
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.SystemColors.Control;
			this.label29.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label29.Location = new System.Drawing.Point(248, 52);
			this.label29.Name = "label29";
			this.label29.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label29.Size = new System.Drawing.Size(96, 20);
			this.label29.TabIndex = 164;
			this.label29.Text = "Numri i identifikimit";
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.SystemColors.Control;
			this.label30.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label30.Location = new System.Drawing.Point(244, 24);
			this.label30.Name = "label30";
			this.label30.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label30.Size = new System.Drawing.Size(100, 20);
			this.label30.TabIndex = 163;
			this.label30.Text = "Mjeti i identifikimit";
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.SystemColors.Control;
			this.label27.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label27.Location = new System.Drawing.Point(24, 52);
			this.label27.Name = "label27";
			this.label27.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label27.Size = new System.Drawing.Size(52, 20);
			this.label27.TabIndex = 162;
			this.label27.Text = "Mbiemri";
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.SystemColors.Control;
			this.label26.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label26.Location = new System.Drawing.Point(24, 24);
			this.label26.Name = "label26";
			this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label26.Size = new System.Drawing.Size(52, 20);
			this.label26.TabIndex = 161;
			this.label26.Text = "Emri";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label23);
			this.groupBox2.Controls.Add(this.rbEmri);
			this.groupBox2.Controls.Add(this.rbData);
			this.groupBox2.Controls.Add(this.btnKerko);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtMbiemriKlienti);
			this.groupBox2.Controls.Add(this.txtEmerKlienti);
			this.groupBox2.Controls.Add(this.dtpData);
			this.groupBox2.Controls.Add(this.gridKlienti);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(458, 460);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.Text = "Rezervimet e kryera nga klientet";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.SystemColors.Control;
			this.label23.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label23.Location = new System.Drawing.Point(8, 104);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(236, 16);
			this.label23.TabIndex = 120;
			this.label23.Text = "Te dhenat  e rezervimeve te kryer nga klientet";
			// 
			// rbEmri
			// 
			this.rbEmri.Location = new System.Drawing.Point(16, 56);
			this.rbEmri.Name = "rbEmri";
			this.rbEmri.Size = new System.Drawing.Size(80, 24);
			this.rbEmri.TabIndex = 119;
			this.rbEmri.Text = "Klienti";
			// 
			// rbData
			// 
			this.rbData.Location = new System.Drawing.Point(16, 20);
			this.rbData.Name = "rbData";
			this.rbData.Size = new System.Drawing.Size(84, 24);
			this.rbData.TabIndex = 118;
			this.rbData.Text = "Pas dates";
			// 
			// btnKerko
			// 
			this.btnKerko.BackColor = System.Drawing.Color.Blue;
			this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko.DoValidation = false;
			this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko.Location = new System.Drawing.Point(376, 92);
			this.btnKerko.Name = "btnKerko";
			this.btnKerko.Size = new System.Drawing.Size(68, 21);
			this.btnKerko.TabIndex = 5;
			this.btnKerko.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko, "Kerkon per rezervimet individuale qe plotesojne kriteret e caktuar!");
			this.btnKerko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(284, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 114;
			this.label2.Text = "Mbiemri";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(104, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 12);
			this.label1.TabIndex = 113;
			this.label1.Text = "Emri";
			// 
			// txtMbiemriKlienti
			// 
			this.txtMbiemriKlienti.AutoSize = false;
			this.txtMbiemriKlienti.DefaultErrorMessage = "";
			this.txtMbiemriKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemriKlienti.FixedLength = false;
			this.txtMbiemriKlienti.IsValid = true;
			this.txtMbiemriKlienti.Location = new System.Drawing.Point(282, 60);
			this.txtMbiemriKlienti.Name = "txtMbiemriKlienti";
			this.txtMbiemriKlienti.Required = false;
			this.txtMbiemriKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemriKlienti.Size = new System.Drawing.Size(160, 21);
			this.txtMbiemriKlienti.TabIndex = 4;
			this.txtMbiemriKlienti.Text = "";
			// 
			// txtEmerKlienti
			// 
			this.txtEmerKlienti.AutoSize = false;
			this.txtEmerKlienti.DefaultErrorMessage = "";
			this.txtEmerKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmerKlienti.FixedLength = false;
			this.txtEmerKlienti.IsValid = true;
			this.txtEmerKlienti.Location = new System.Drawing.Point(104, 60);
			this.txtEmerKlienti.Name = "txtEmerKlienti";
			this.txtEmerKlienti.Required = false;
			this.txtEmerKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmerKlienti.Size = new System.Drawing.Size(160, 21);
			this.txtEmerKlienti.TabIndex = 3;
			this.txtEmerKlienti.Text = "";
			// 
			// dtpData
			// 
			this.dtpData.BackColor = System.Drawing.Color.White;
			this.dtpData.CustomFormat = "dd.MM.yyyy";
			this.dtpData.DefaultErrorMessage = "";
			this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpData.IsValid = true;
			this.dtpData.Location = new System.Drawing.Point(104, 20);
			this.dtpData.Name = "dtpData";
			this.dtpData.Required = false;
			this.dtpData.ShowCheckBox = true;
			this.dtpData.ShowUpDown = true;
			this.dtpData.Size = new System.Drawing.Size(160, 20);
			this.dtpData.TabIndex = 2;
			this.dtpData.Value = new System.DateTime(2005, 7, 12, 17, 49, 0, 0);
			// 
			// gridKlienti
			// 
			this.gridKlienti.AllowSorting = false;
			this.gridKlienti.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.gridKlienti.CanDelete = true;
			this.gridKlienti.CaptionVisible = false;
			this.gridKlienti.DataMember = "";
			this.gridKlienti.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gridKlienti.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridKlienti.HideHorizontalScrollBar = false;
			this.gridKlienti.HideVerticalScrollBar = false;
			this.gridKlienti.Location = new System.Drawing.Point(8, 120);
			this.gridKlienti.Name = "gridKlienti";
			this.gridKlienti.ReadOnly = true;
			this.gridKlienti.RowHeaderWidth = 36;
			this.gridKlienti.Selekto = true;
			this.gridKlienti.Size = new System.Drawing.Size(436, 328);
			this.gridKlienti.TabIndex = 6;
			this.toolTips.SetToolTip(this.gridKlienti, "Zgjidhni nje prej rezervimeve per ta futur ne hotel!");
			this.gridKlienti.CurrentCellChanged += new System.EventHandler(this.gridKlienti_CurrentCellChanged);
			// 
			// btnShtoKlient
			// 
			this.btnShtoKlient.BackColor = System.Drawing.Color.Blue;
			this.btnShtoKlient.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShtoKlient.DoValidation = true;
			this.btnShtoKlient.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShtoKlient.Location = new System.Drawing.Point(596, 212);
			this.btnShtoKlient.Name = "btnShtoKlient";
			this.btnShtoKlient.Size = new System.Drawing.Size(90, 21);
			this.btnShtoKlient.TabIndex = 18;
			this.btnShtoKlient.Text = "Shto klient";
			this.toolTips.SetToolTip(this.btnShtoKlient, "Shton nje klient ne dhomen perkatese te rezervimit te zgjedhur!");
			this.btnShtoKlient.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShtoKlient.Click += new System.EventHandler(this.btnShtoKlient_Click);
			// 
			// tbGrup
			// 
			this.tbGrup.BackColor = System.Drawing.SystemColors.Control;
			this.tbGrup.Controls.Add(this.btnSkanoGrup);
			this.tbGrup.Controls.Add(this.groupBox6);
			this.tbGrup.Controls.Add(this.MerrDhomeGrupi);
			this.tbGrup.Controls.Add(this.groupBox1);
			this.tbGrup.Controls.Add(this.groupBox3);
			this.tbGrup.Controls.Add(this.btnFutKlientGrup);
			this.tbGrup.DefaultErrorMessage = null;
			this.tbGrup.EnableValidation = true;
			this.tbGrup.IsValid = false;
			this.tbGrup.Location = new System.Drawing.Point(4, 22);
			this.tbGrup.Name = "tbGrup";
			this.tbGrup.Size = new System.Drawing.Size(1016, 581);
			this.tbGrup.TabIndex = 1;
			this.tbGrup.Text = "Ne grup";
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.Color.Transparent;
			this.groupBox6.Controls.Add(this.label32);
			this.groupBox6.Controls.Add(this.cmbPagesaGrupi);
			this.groupBox6.Controls.Add(this.label10);
			this.groupBox6.Controls.Add(this.numCmimiGrupi);
			this.groupBox6.Controls.Add(this.dtpMbarimi1);
			this.groupBox6.Controls.Add(this.dtpFillimi1);
			this.groupBox6.Controls.Add(this.label39);
			this.groupBox6.Controls.Add(this.label33);
			this.groupBox6.Controls.Add(this.panelDhomatGrupi);
			this.groupBox6.Controls.Add(this.button3);
			this.groupBox6.Controls.Add(this.numKapariGrupi);
			this.groupBox6.Controls.Add(this.label25);
			this.groupBox6.Controls.Add(this.numKapariRGrupi);
			this.groupBox6.Controls.Add(this.label6);
			this.groupBox6.Controls.Add(this.label8);
			this.groupBox6.Controls.Add(this.label9);
			this.groupBox6.Controls.Add(this.txtDhoma1);
			this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox6.Location = new System.Drawing.Point(476, 236);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(532, 172);
			this.groupBox6.TabIndex = 108;
			this.groupBox6.Text = "Merr dhome";
			this.groupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(252, 48);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(92, 20);
			this.label32.TabIndex = 174;
			this.label32.Text = "Kapar rezervimi";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbPagesaGrupi
			// 
			this.cmbPagesaGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cmbPagesaGrupi.DefaultErrorMessage = "Zgjidhni nje prej formave te pagesave!";
			this.cmbPagesaGrupi.IsValid = false;
			this.cmbPagesaGrupi.Kolone1Vlere = null;
			this.cmbPagesaGrupi.Kolone2Vlere = null;
			this.cmbPagesaGrupi.Location = new System.Drawing.Point(352, 104);
			this.cmbPagesaGrupi.Name = "cmbPagesaGrupi";
			this.cmbPagesaGrupi.ReadOnly = false;
			this.cmbPagesaGrupi.Required = true;
			this.cmbPagesaGrupi.Size = new System.Drawing.Size(160, 21);
			this.cmbPagesaGrupi.SkipValidation = false;
			this.cmbPagesaGrupi.TabIndex = 52;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.SystemColors.Control;
			this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label10.Location = new System.Drawing.Point(24, 80);
			this.label10.Name = "label10";
			this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label10.Size = new System.Drawing.Size(52, 16);
			this.label10.TabIndex = 98;
			this.label10.Text = "Dhoma";
			// 
			// numCmimiGrupi
			// 
			this.numCmimiGrupi.AutoSize = false;
			this.numCmimiGrupi.DefaultErrorMessage = "Zgjidhni nje prej rezervimeve!";
			this.numCmimiGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numCmimiGrupi.DigitsAfterDecimalPoint = 0;
			this.numCmimiGrupi.FixedLength = false;
			this.numCmimiGrupi.IsValid = false;
			this.numCmimiGrupi.KeepFocus = false;
			this.numCmimiGrupi.Location = new System.Drawing.Point(352, 20);
			this.numCmimiGrupi.Name = "numCmimiGrupi";
			this.numCmimiGrupi.OnlyPositive = true;
			this.numCmimiGrupi.ReadOnly = true;
			this.numCmimiGrupi.Required = false;
			this.numCmimiGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimiGrupi.Size = new System.Drawing.Size(160, 21);
			this.numCmimiGrupi.TabIndex = 49;
			this.numCmimiGrupi.Text = "";
			this.numCmimiGrupi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// dtpMbarimi1
			// 
			this.dtpMbarimi1.CustomFormat = "dd.MM.yyyy/HH.mm";
			this.dtpMbarimi1.DefaultErrorMessage = "";
			this.dtpMbarimi1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimi1.IsValid = true;
			this.dtpMbarimi1.Location = new System.Drawing.Point(84, 48);
			this.dtpMbarimi1.Name = "dtpMbarimi1";
			this.dtpMbarimi1.Required = false;
			this.dtpMbarimi1.ShowCheckBox = true;
			this.dtpMbarimi1.ShowUpDown = true;
			this.dtpMbarimi1.Size = new System.Drawing.Size(160, 20);
			this.dtpMbarimi1.TabIndex = 47;
			this.dtpMbarimi1.Value = new System.DateTime(2006, 1, 6, 13, 40, 0, 0);
			this.dtpMbarimi1.ValueChanged += new System.EventHandler(this.dtpMbarimi1_ValueChanged);
			// 
			// dtpFillimi1
			// 
			this.dtpFillimi1.CustomFormat = "dd.MM.yyyy/HH.mm";
			this.dtpFillimi1.DefaultErrorMessage = "";
			this.dtpFillimi1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimi1.IsValid = true;
			this.dtpFillimi1.Location = new System.Drawing.Point(84, 20);
			this.dtpFillimi1.Name = "dtpFillimi1";
			this.dtpFillimi1.Required = false;
			this.dtpFillimi1.ShowCheckBox = true;
			this.dtpFillimi1.ShowUpDown = true;
			this.dtpFillimi1.Size = new System.Drawing.Size(160, 20);
			this.dtpFillimi1.TabIndex = 46;
			this.dtpFillimi1.Value = new System.DateTime(2006, 1, 6, 13, 38, 0, 0);
			this.dtpFillimi1.ValueChanged += new System.EventHandler(this.dtpFillimi1_ValueChanged);
			// 
			// label39
			// 
			this.label39.Location = new System.Drawing.Point(280, 104);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(64, 20);
			this.label39.TabIndex = 169;
			this.label39.Text = "Pagesa ne ";
			this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label33
			// 
			this.label33.BackColor = System.Drawing.SystemColors.Control;
			this.label33.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label33.Location = new System.Drawing.Point(20, 108);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(56, 16);
			this.label33.TabIndex = 168;
			this.label33.Text = "Kapaciteti";
			this.label33.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.label33.Visible = false;
			// 
			// panelDhomatGrupi
			// 
			this.panelDhomatGrupi.BackColor = System.Drawing.Color.Transparent;
			this.panelDhomatGrupi.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panelDhomatGrupi.Location = new System.Drawing.Point(80, 104);
			this.panelDhomatGrupi.Name = "panelDhomatGrupi";
			this.panelDhomatGrupi.Size = new System.Drawing.Size(192, 40);
			this.panelDhomatGrupi.TabIndex = 167;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Blue;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.DoValidation = false;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(380, 136);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(96, 21);
			this.button3.TabIndex = 53;
			this.button3.Text = "Llogarit pagesen";
			this.toolTips.SetToolTip(this.button3, "Llogarit paraprakisht pagesen per dhomen!");
			this.button3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// numKapariGrupi
			// 
			this.numKapariGrupi.AutoSize = false;
			this.numKapariGrupi.DefaultErrorMessage = "Ju duhet te jepni nje vlere per kaparin!";
			this.numKapariGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numKapariGrupi.DigitsAfterDecimalPoint = 0;
			this.numKapariGrupi.FixedLength = false;
			this.numKapariGrupi.IsValid = false;
			this.numKapariGrupi.KeepFocus = false;
			this.numKapariGrupi.Location = new System.Drawing.Point(352, 76);
			this.numKapariGrupi.Name = "numKapariGrupi";
			this.numKapariGrupi.OnlyPositive = true;
			this.numKapariGrupi.Required = true;
			this.numKapariGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.numKapariGrupi.Size = new System.Drawing.Size(160, 21);
			this.numKapariGrupi.TabIndex = 51;
			this.numKapariGrupi.Text = "";
			this.numKapariGrupi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label25
			// 
			this.label25.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label25.Location = new System.Drawing.Point(256, 76);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(88, 20);
			this.label25.TabIndex = 164;
			this.label25.Text = "Kapari per grupin";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numKapariRGrupi
			// 
			this.numKapariRGrupi.AutoSize = false;
			this.numKapariRGrupi.DefaultErrorMessage = "Zgjidhni nje prej rezervimeve!";
			this.numKapariRGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numKapariRGrupi.DigitsAfterDecimalPoint = 0;
			this.numKapariRGrupi.FixedLength = false;
			this.numKapariRGrupi.IsValid = false;
			this.numKapariRGrupi.KeepFocus = false;
			this.numKapariRGrupi.Location = new System.Drawing.Point(352, 48);
			this.numKapariRGrupi.Name = "numKapariRGrupi";
			this.numKapariRGrupi.OnlyPositive = true;
			this.numKapariRGrupi.ReadOnly = true;
			this.numKapariRGrupi.Required = true;
			this.numKapariRGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.numKapariRGrupi.Size = new System.Drawing.Size(160, 21);
			this.numKapariRGrupi.TabIndex = 50;
			this.numKapariRGrupi.Text = "";
			this.numKapariRGrupi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.Control;
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Location = new System.Drawing.Point(300, 24);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label6.Size = new System.Drawing.Size(44, 16);
			this.label6.TabIndex = 101;
			this.label6.Text = "Cmimi";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.Control;
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label8.Location = new System.Drawing.Point(4, 52);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label8.Size = new System.Drawing.Size(72, 20);
			this.label8.TabIndex = 100;
			this.label8.Text = "Date mbarimi";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.SystemColors.Control;
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label9.Location = new System.Drawing.Point(16, 24);
			this.label9.Name = "label9";
			this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label9.Size = new System.Drawing.Size(60, 20);
			this.label9.TabIndex = 99;
			this.label9.Text = "Date fillimi";
			// 
			// txtDhoma1
			// 
			this.txtDhoma1.AutoSize = false;
			this.txtDhoma1.DefaultErrorMessage = "Zgjidhni nje prej rezervmeve!";
			this.txtDhoma1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtDhoma1.FixedLength = false;
			this.txtDhoma1.IsValid = false;
			this.txtDhoma1.Location = new System.Drawing.Point(84, 76);
			this.txtDhoma1.Name = "txtDhoma1";
			this.txtDhoma1.ReadOnly = true;
			this.txtDhoma1.Required = true;
			this.txtDhoma1.RequiredControlColor = System.Drawing.Color.White;
			this.txtDhoma1.Size = new System.Drawing.Size(160, 20);
			this.txtDhoma1.TabIndex = 48;
			this.txtDhoma1.Text = "";
			// 
			// MerrDhomeGrupi
			// 
			this.MerrDhomeGrupi.BackColor = System.Drawing.Color.Blue;
			this.MerrDhomeGrupi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MerrDhomeGrupi.DoValidation = false;
			this.MerrDhomeGrupi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.MerrDhomeGrupi.Location = new System.Drawing.Point(592, 420);
			this.MerrDhomeGrupi.Name = "MerrDhomeGrupi";
			this.MerrDhomeGrupi.Size = new System.Drawing.Size(90, 21);
			this.MerrDhomeGrupi.TabIndex = 54;
			this.MerrDhomeGrupi.Text = "Merr dhome";
			this.toolTips.SetToolTip(this.MerrDhomeGrupi, "Kryen futjen ne dhome te klienteve te shtuar me pare!");
			this.MerrDhomeGrupi.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.MerrDhomeGrupi.Click += new System.EventHandler(this.MerrDhomeGrupi_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.cmbMjetId1);
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.txtGrupi);
			this.groupBox1.Controls.Add(this.txtEmriKlienti);
			this.groupBox1.Controls.Add(this.txtMbiemriKlienti1);
			this.groupBox1.Controls.Add(this.dtpDatelindja1);
			this.groupBox1.Controls.Add(this.txtTelefoni1);
			this.groupBox1.Controls.Add(this.txtAdresa1);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.txtEmail1);
			this.groupBox1.Controls.Add(this.txtNrIdentGrupi);
			this.groupBox1.Controls.Add(this.txtTarga1);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txtShtetesiaGrupi);
			this.groupBox1.Controls.Add(this.txtVendlindjaGrupi);
			this.groupBox1.Controls.Add(this.label37);
			this.groupBox1.Controls.Add(this.label36);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(476, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(532, 196);
			this.groupBox1.TabIndex = 99;
			this.groupBox1.Text = "Shtimi i klienteve";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbMjetId1
			// 
			this.cmbMjetId1.BackColor = System.Drawing.Color.Transparent;
			this.cmbMjetId1.DefaultErrorMessage = "Zgjidhni nje prej mjeteve te identifikimit!";
			this.cmbMjetId1.IsValid = false;
			this.cmbMjetId1.Kolone1Vlere = null;
			this.cmbMjetId1.Kolone2Vlere = null;
			this.cmbMjetId1.Location = new System.Drawing.Point(352, 20);
			this.cmbMjetId1.Name = "cmbMjetId1";
			this.cmbMjetId1.ReadOnly = false;
			this.cmbMjetId1.Required = true;
			this.cmbMjetId1.Size = new System.Drawing.Size(160, 21);
			this.cmbMjetId1.SkipValidation = false;
			this.cmbMjetId1.TabIndex = 39;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.SystemColors.Control;
			this.label22.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label22.Location = new System.Drawing.Point(36, 24);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(40, 20);
			this.label22.TabIndex = 115;
			this.label22.Text = "Grupi";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.SystemColors.Control;
			this.label18.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label18.Location = new System.Drawing.Point(252, 24);
			this.label18.Name = "label18";
			this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label18.Size = new System.Drawing.Size(92, 20);
			this.label18.TabIndex = 101;
			this.label18.Text = "Mjeti i identifikimit";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.SystemColors.Control;
			this.label19.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label19.Location = new System.Drawing.Point(28, 80);
			this.label19.Name = "label19";
			this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label19.Size = new System.Drawing.Size(48, 20);
			this.label19.TabIndex = 100;
			this.label19.Text = "Mbiemri";
			// 
			// txtGrupi
			// 
			this.txtGrupi.AutoSize = false;
			this.txtGrupi.DefaultErrorMessage = "Zgjidhni nje prej rezervimeve!";
			this.txtGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtGrupi.FixedLength = false;
			this.txtGrupi.IsValid = false;
			this.txtGrupi.Location = new System.Drawing.Point(84, 24);
			this.txtGrupi.Name = "txtGrupi";
			this.txtGrupi.ReadOnly = true;
			this.txtGrupi.Required = true;
			this.txtGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtGrupi.TabIndex = 33;
			this.txtGrupi.Text = "";
			// 
			// txtEmriKlienti
			// 
			this.txtEmriKlienti.AutoSize = false;
			this.txtEmriKlienti.DefaultErrorMessage = "Ju duhet te jepni emrin per klientin!";
			this.txtEmriKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmriKlienti.FixedLength = false;
			this.txtEmriKlienti.IsValid = false;
			this.txtEmriKlienti.Location = new System.Drawing.Point(84, 52);
			this.txtEmriKlienti.Name = "txtEmriKlienti";
			this.txtEmriKlienti.Required = true;
			this.txtEmriKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmriKlienti.Size = new System.Drawing.Size(160, 21);
			this.txtEmriKlienti.TabIndex = 34;
			this.txtEmriKlienti.Text = "";
			// 
			// txtMbiemriKlienti1
			// 
			this.txtMbiemriKlienti1.AutoSize = false;
			this.txtMbiemriKlienti1.DefaultErrorMessage = "Ju duhet te jepni mbiemrin per klientin!";
			this.txtMbiemriKlienti1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemriKlienti1.FixedLength = false;
			this.txtMbiemriKlienti1.IsValid = false;
			this.txtMbiemriKlienti1.Location = new System.Drawing.Point(84, 80);
			this.txtMbiemriKlienti1.Name = "txtMbiemriKlienti1";
			this.txtMbiemriKlienti1.Required = true;
			this.txtMbiemriKlienti1.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemriKlienti1.Size = new System.Drawing.Size(160, 21);
			this.txtMbiemriKlienti1.TabIndex = 35;
			this.txtMbiemriKlienti1.Text = "";
			// 
			// dtpDatelindja1
			// 
			this.dtpDatelindja1.BackColor = System.Drawing.Color.White;
			this.dtpDatelindja1.CustomFormat = "dd.MM.yyyy";
			this.dtpDatelindja1.DefaultErrorMessage = "";
			this.dtpDatelindja1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDatelindja1.IsValid = true;
			this.dtpDatelindja1.Location = new System.Drawing.Point(84, 108);
			this.dtpDatelindja1.Name = "dtpDatelindja1";
			this.dtpDatelindja1.Required = false;
			this.dtpDatelindja1.ShowCheckBox = true;
			this.dtpDatelindja1.ShowUpDown = true;
			this.dtpDatelindja1.Size = new System.Drawing.Size(160, 20);
			this.dtpDatelindja1.TabIndex = 36;
			this.dtpDatelindja1.Value = new System.DateTime(2005, 7, 12, 18, 36, 0, 0);
			// 
			// txtTelefoni1
			// 
			this.txtTelefoni1.AutoSize = false;
			this.txtTelefoni1.DefaultErrorMessage = "";
			this.txtTelefoni1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTelefoni1.FixedLength = false;
			this.txtTelefoni1.IsValid = true;
			this.txtTelefoni1.Location = new System.Drawing.Point(352, 104);
			this.txtTelefoni1.Name = "txtTelefoni1";
			this.txtTelefoni1.Required = false;
			this.txtTelefoni1.RequiredControlColor = System.Drawing.Color.White;
			this.txtTelefoni1.Size = new System.Drawing.Size(160, 21);
			this.txtTelefoni1.TabIndex = 42;
			this.txtTelefoni1.Text = "";
			// 
			// txtAdresa1
			// 
			this.txtAdresa1.AutoSize = false;
			this.txtAdresa1.DefaultErrorMessage = "";
			this.txtAdresa1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAdresa1.FixedLength = false;
			this.txtAdresa1.IsValid = true;
			this.txtAdresa1.Location = new System.Drawing.Point(352, 76);
			this.txtAdresa1.Name = "txtAdresa1";
			this.txtAdresa1.Required = false;
			this.txtAdresa1.RequiredControlColor = System.Drawing.Color.White;
			this.txtAdresa1.Size = new System.Drawing.Size(160, 21);
			this.txtAdresa1.TabIndex = 41;
			this.txtAdresa1.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.SystemColors.Control;
			this.label17.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label17.Location = new System.Drawing.Point(248, 52);
			this.label17.Name = "label17";
			this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label17.Size = new System.Drawing.Size(96, 20);
			this.label17.TabIndex = 102;
			this.label17.Text = "Numri i identifikimit";
			// 
			// txtEmail1
			// 
			this.txtEmail1.AutoSize = false;
			this.txtEmail1.DefaultErrorMessage = "";
			this.txtEmail1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmail1.FixedLength = false;
			this.txtEmail1.IsValid = true;
			this.txtEmail1.Location = new System.Drawing.Point(352, 160);
			this.txtEmail1.Name = "txtEmail1";
			this.txtEmail1.Required = false;
			this.txtEmail1.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmail1.Size = new System.Drawing.Size(160, 21);
			this.txtEmail1.TabIndex = 44;
			this.txtEmail1.Text = "";
			// 
			// txtNrIdentGrupi
			// 
			this.txtNrIdentGrupi.AutoSize = false;
			this.txtNrIdentGrupi.DefaultErrorMessage = "Ju duhet te jepni nje numer identifikimi per klientin, ne varesi te llojit te mje" +
				"tit te identifikimit!";
			this.txtNrIdentGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtNrIdentGrupi.FixedLength = false;
			this.txtNrIdentGrupi.IsValid = false;
			this.txtNrIdentGrupi.Location = new System.Drawing.Point(352, 48);
			this.txtNrIdentGrupi.Name = "txtNrIdentGrupi";
			this.txtNrIdentGrupi.Required = true;
			this.txtNrIdentGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtNrIdentGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtNrIdentGrupi.TabIndex = 40;
			this.txtNrIdentGrupi.Text = "";
			// 
			// txtTarga1
			// 
			this.txtTarga1.AutoSize = false;
			this.txtTarga1.DefaultErrorMessage = "";
			this.txtTarga1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTarga1.FixedLength = false;
			this.txtTarga1.IsValid = true;
			this.txtTarga1.Location = new System.Drawing.Point(352, 132);
			this.txtTarga1.Name = "txtTarga1";
			this.txtTarga1.Required = false;
			this.txtTarga1.RequiredControlColor = System.Drawing.Color.White;
			this.txtTarga1.Size = new System.Drawing.Size(160, 21);
			this.txtTarga1.TabIndex = 43;
			this.txtTarga1.Text = "";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.SystemColors.Control;
			this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label13.Location = new System.Drawing.Point(308, 136);
			this.label13.Name = "label13";
			this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label13.Size = new System.Drawing.Size(36, 20);
			this.label13.TabIndex = 105;
			this.label13.Text = "Targa";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.SystemColors.Control;
			this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label15.Location = new System.Drawing.Point(304, 80);
			this.label15.Name = "label15";
			this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label15.Size = new System.Drawing.Size(40, 16);
			this.label15.TabIndex = 103;
			this.label15.Text = "Adresa";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.SystemColors.Control;
			this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label14.Location = new System.Drawing.Point(308, 164);
			this.label14.Name = "label14";
			this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label14.Size = new System.Drawing.Size(36, 20);
			this.label14.TabIndex = 104;
			this.label14.Text = "E-Mail";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.Control;
			this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label11.Location = new System.Drawing.Point(280, 104);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(64, 20);
			this.label11.TabIndex = 107;
			this.label11.Text = "Nr telefoni";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtShtetesiaGrupi
			// 
			this.txtShtetesiaGrupi.AutoSize = false;
			this.txtShtetesiaGrupi.DefaultErrorMessage = "";
			this.txtShtetesiaGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtShtetesiaGrupi.FixedLength = false;
			this.txtShtetesiaGrupi.IsValid = true;
			this.txtShtetesiaGrupi.Location = new System.Drawing.Point(84, 164);
			this.txtShtetesiaGrupi.Name = "txtShtetesiaGrupi";
			this.txtShtetesiaGrupi.Required = false;
			this.txtShtetesiaGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtShtetesiaGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtShtetesiaGrupi.TabIndex = 38;
			this.txtShtetesiaGrupi.Text = "";
			// 
			// txtVendlindjaGrupi
			// 
			this.txtVendlindjaGrupi.AutoSize = false;
			this.txtVendlindjaGrupi.DefaultErrorMessage = "";
			this.txtVendlindjaGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtVendlindjaGrupi.FixedLength = false;
			this.txtVendlindjaGrupi.IsValid = true;
			this.txtVendlindjaGrupi.Location = new System.Drawing.Point(84, 136);
			this.txtVendlindjaGrupi.Name = "txtVendlindjaGrupi";
			this.txtVendlindjaGrupi.Required = false;
			this.txtVendlindjaGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtVendlindjaGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtVendlindjaGrupi.TabIndex = 37;
			this.txtVendlindjaGrupi.Text = "";
			// 
			// label37
			// 
			this.label37.Location = new System.Drawing.Point(12, 168);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(64, 16);
			this.label37.TabIndex = 122;
			this.label37.Text = "Shtetesia";
			this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label36
			// 
			this.label36.Location = new System.Drawing.Point(12, 140);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(64, 20);
			this.label36.TabIndex = 121;
			this.label36.Text = "Vendlindja";
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.SystemColors.Control;
			this.label20.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label20.Location = new System.Drawing.Point(40, 52);
			this.label20.Name = "label20";
			this.label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label20.Size = new System.Drawing.Size(36, 20);
			this.label20.TabIndex = 99;
			this.label20.Text = "Emri";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.Control;
			this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label12.Location = new System.Drawing.Point(16, 108);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 20);
			this.label12.TabIndex = 106;
			this.label12.Text = "Datelindja";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.gridGrupi);
			this.groupBox3.Controls.Add(this.txtAgjensiaGrupi);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.txtEmerGrupi);
			this.groupBox3.Controls.Add(this.dtpDataGrupi);
			this.groupBox3.Controls.Add(this.rbGrupi);
			this.groupBox3.Controls.Add(this.rbData1);
			this.groupBox3.Controls.Add(this.btnKerko1);
			this.groupBox3.Controls.Add(this.label21);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(10, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(458, 460);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.Text = "Rezervimet e kryer nga grupet";
			this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
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
			this.gridGrupi.Location = new System.Drawing.Point(8, 120);
			this.gridGrupi.Name = "gridGrupi";
			this.gridGrupi.ReadOnly = true;
			this.gridGrupi.RowHeaderWidth = 20;
			this.gridGrupi.Selekto = true;
			this.gridGrupi.Size = new System.Drawing.Size(436, 328);
			this.gridGrupi.TabIndex = 32;
			this.toolTips.SetToolTip(this.gridGrupi, "Zgjidhni nje prej rezervimeve per ta futur ne hotel!");
			this.gridGrupi.CurrentCellChanged += new System.EventHandler(this.gridGrupi_CurrentCellChanged_1);
			// 
			// txtAgjensiaGrupi
			// 
			this.txtAgjensiaGrupi.AutoSize = false;
			this.txtAgjensiaGrupi.DefaultErrorMessage = "";
			this.txtAgjensiaGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAgjensiaGrupi.FixedLength = false;
			this.txtAgjensiaGrupi.IsValid = true;
			this.txtAgjensiaGrupi.Location = new System.Drawing.Point(282, 60);
			this.txtAgjensiaGrupi.Name = "txtAgjensiaGrupi";
			this.txtAgjensiaGrupi.Required = false;
			this.txtAgjensiaGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtAgjensiaGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtAgjensiaGrupi.TabIndex = 30;
			this.txtAgjensiaGrupi.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Location = new System.Drawing.Point(284, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Agjensia";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(104, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Grupi";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// txtEmerGrupi
			// 
			this.txtEmerGrupi.AutoSize = false;
			this.txtEmerGrupi.DefaultErrorMessage = "";
			this.txtEmerGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmerGrupi.FixedLength = false;
			this.txtEmerGrupi.IsValid = true;
			this.txtEmerGrupi.Location = new System.Drawing.Point(104, 60);
			this.txtEmerGrupi.Name = "txtEmerGrupi";
			this.txtEmerGrupi.Required = false;
			this.txtEmerGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmerGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtEmerGrupi.TabIndex = 29;
			this.txtEmerGrupi.Text = "";
			// 
			// dtpDataGrupi
			// 
			this.dtpDataGrupi.BackColor = System.Drawing.Color.White;
			this.dtpDataGrupi.CustomFormat = "dd.MM.yyyy";
			this.dtpDataGrupi.DefaultErrorMessage = "";
			this.dtpDataGrupi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDataGrupi.IsValid = true;
			this.dtpDataGrupi.Location = new System.Drawing.Point(104, 20);
			this.dtpDataGrupi.Name = "dtpDataGrupi";
			this.dtpDataGrupi.Required = false;
			this.dtpDataGrupi.ShowCheckBox = true;
			this.dtpDataGrupi.ShowUpDown = true;
			this.dtpDataGrupi.Size = new System.Drawing.Size(160, 20);
			this.dtpDataGrupi.TabIndex = 28;
			this.dtpDataGrupi.Value = new System.DateTime(2005, 7, 12, 17, 49, 0, 0);
			// 
			// rbGrupi
			// 
			this.rbGrupi.Location = new System.Drawing.Point(16, 56);
			this.rbGrupi.Name = "rbGrupi";
			this.rbGrupi.Size = new System.Drawing.Size(80, 24);
			this.rbGrupi.TabIndex = 1;
			this.rbGrupi.Text = "Grupit";
			// 
			// rbData1
			// 
			this.rbData1.Location = new System.Drawing.Point(16, 20);
			this.rbData1.Name = "rbData1";
			this.rbData1.Size = new System.Drawing.Size(84, 24);
			this.rbData1.TabIndex = 0;
			this.rbData1.Text = "Pas dates";
			// 
			// btnKerko1
			// 
			this.btnKerko1.BackColor = System.Drawing.Color.Blue;
			this.btnKerko1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko1.DoValidation = false;
			this.btnKerko1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko1.Location = new System.Drawing.Point(376, 92);
			this.btnKerko1.Name = "btnKerko1";
			this.btnKerko1.Size = new System.Drawing.Size(68, 21);
			this.btnKerko1.TabIndex = 31;
			this.btnKerko1.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko1, "Kerkon per rezervimet ne grup qe plotesojne kriteret e caktuar!");
			this.btnKerko1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko1.Click += new System.EventHandler(this.btnKerko1_Click);
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(8, 104);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(236, 16);
			this.label21.TabIndex = 108;
			this.label21.Text = "Te dhenat e rezervimeve te kryer nga grupet";
			// 
			// btnFutKlientGrup
			// 
			this.btnFutKlientGrup.BackColor = System.Drawing.Color.Blue;
			this.btnFutKlientGrup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFutKlientGrup.DoValidation = true;
			this.btnFutKlientGrup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnFutKlientGrup.Location = new System.Drawing.Point(596, 212);
			this.btnFutKlientGrup.Name = "btnFutKlientGrup";
			this.btnFutKlientGrup.Size = new System.Drawing.Size(90, 21);
			this.btnFutKlientGrup.TabIndex = 45;
			this.btnFutKlientGrup.Text = "Shto klient";
			this.toolTips.SetToolTip(this.btnFutKlientGrup, "Shton nje klient ne dhomen perkatese te rezervimit te zgjedhur!");
			this.btnFutKlientGrup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnFutKlientGrup.Click += new System.EventHandler(this.btnFutKlientGrup_Click_1);
			// 
			// ds
			// 
			this.ds.DataSetName = "NewDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-GB");
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
			// btnSkano
			// 
			this.btnSkano.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSkano.DoValidation = true;
			this.btnSkano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSkano.Location = new System.Drawing.Point(812, 212);
			this.btnSkano.Name = "btnSkano";
			this.btnSkano.Size = new System.Drawing.Size(90, 21);
			this.btnSkano.TabIndex = 79;
			this.btnSkano.Text = "Skano";
			this.btnSkano.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnSkano.Click += new System.EventHandler(this.btnSkano_Click);
			// 
			// btnSkanoGrup
			// 
			this.btnSkanoGrup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSkanoGrup.DoValidation = true;
			this.btnSkanoGrup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSkanoGrup.Location = new System.Drawing.Point(804, 212);
			this.btnSkanoGrup.Name = "btnSkanoGrup";
			this.btnSkanoGrup.Size = new System.Drawing.Size(90, 21);
			this.btnSkanoGrup.TabIndex = 109;
			this.btnSkanoGrup.Text = "Skano";
			this.btnSkanoGrup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnSkanoGrup.Click += new System.EventHandler(this.btnSkanoGrup_Click);
			// 
			// FutRezervimNeDhome
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1036, 720);
			this.Controls.Add(this.tab);
			this.HelpFile = "FUT REZERVIM NE DHOME.htm";
			this.IsValid = true;
			this.Name = "FutRezervimNeDhome";
			this.Text = "Fut rezervim ne dhome";
			this.TitullGjeresi = 1036;
			this.Load += new System.EventHandler(this.FutRezervimNeDhome_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.tab, 0);
			this.tab.ResumeLayout(false);
			this.tbIndivid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox5)).EndInit();
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridKlienti)).EndInit();
			this.tbGrup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox6)).EndInit();
			this.groupBox6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridGrupi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsKlienti)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsKlientiGrupi)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region FormLoad
		private void FutRezervimNeDhome_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				//pastrim var private
				this.hedhurKaparGrupi = false;
				this.ds.Tables.Clear();
				this.dsKlienti.Tables.Clear();
				this.idGrupi = 0;
				this.nrKrevat = 0;
				this.nrKrevatZene = 0;
				this.i = 0;
				this.nrKlientShtese = 0;
				this.idDhoma = 0;
				this.idRezervimiGrupi  = 0;
				this.idRezervimi = 0;
				this.dsKlientiGrupi.Tables.Clear();
				this.nrKrevatGrupi = 0;
				this.nrKrevatZeneGrupi = 0;
				this.iG = 0;
				this.nrKlientShteseGrupi = 0;
				this.idDhomaGrupi = 0;
				this.j = 0;
				this.dhomaKlientiCift = 0;
				this.dhomaGrupiCift = 0;
				this.rowIndex = 0;
				this.PastroPanel();
				this.PastroPanelGrupi();
				this.cmbPagesaKlienti.Enabled = true;
				this.cmbPagesaGrupi.Enabled = true;
				//pastrim var private 
				this.hedhurKaparGrupi = false;
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqRezervimeKlienti");
				this.gridKlienti.DataSource = ds.Tables[0];
				this.KrijoStilGrideKlienti();
				ds = data.KerkesaRead("ShfaqRezervimeGrupiDhome");
				this.gridGrupi.DataSource = ds.Tables[0];
				this.KrijoStilGrideGrupi();
				ds = data.KerkesaRead("ShfaqMjeteIdentifikimi");		
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbMjetId.Kolone1.Items.Add(dr[1]);
					this.cmbMjetId.Kolone2.Items.Add(dr[0]);
					this.cmbMjetId1.Kolone1.Items.Add(dr[1]);
					this.cmbMjetId1.Kolone2.Items.Add(dr[0]);
				}
				ds.Clear();
				this.BuildDs();
				this.BuildDsGrupi();
				this.MbushPagesat();
				dtpDataGrupi.Value = DateTime.Now;
				dtpDatelindja1.Value = DateTime.Now;
				dtpFillimi1.Value = DateTime.Now;
				dtpMbarimi1.Value = DateTime.Now;
				dtpData.Value = DateTime.Now;
				dtpDatelindja.Value = DateTime.Now;
				dtpFillimi.Value = DateTime.Now;
				dtpMbarimi.Value = DateTime.Now;
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
			try
			{
				InputController data = new InputController();
				if (this.tab.SelectedIndex == 0)//klienti
				{
					this.Pastro(this.groupBox2);
					this.Pastro(this.groupBox5);
					this.Pastro(this.groupBox4);
					this.PastroPanel();
					ds = data.KerkesaRead("ShfaqRezervimeKlienti");
					this.gridKlienti.DataSource = ds.Tables[0];
					this.rbData.Checked = false;
					this.rbEmri.Checked = false;
				}
				else//grupi
				{
					this.Pastro(this.groupBox3);
					this.Pastro(this.groupBox1);
					this.Pastro(groupBox6);
					this.PastroPanelGrupi();
					ds = data.KerkesaRead("ShfaqRezervimeGrupiDhome");
					this.gridGrupi.DataSource = ds.Tables[0];
					this.rbData1.Checked = false;
					this.rbGrupi.Checked = false;
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
			}
		}
		#endregion

		#region FutRezervimKlienti
		/// <summary>
		/// Ben futjen e nje klienti ne dhome. Ne kete rast kryhen disa veprime. Fshihet rezervimi, shtohet klienti
		/// dhe gjendja e dhomes kalon nga e lire ose jo e zene ne te zene ose jo te zene.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnFutKlient_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				int [] b = null;
				int shuma = 0;
				int nrKlient = Convert.ToInt32(this.dsKlienti.Tables[0].Rows.Count);
				if(nrKlient == 0)
				{
					System.Windows.Forms.MessageBox.Show(this,  "Kujdes, perpara se te merrni nje dhome,"+
						Environment.NewLine+"ju duhet te shtoni te dhenat e nje klienti",
						"Fut rezervim ne dhome",	MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				int kapariRezervimi = Convert.ToInt32(numKapariKlientiRez.Text);
				int idFormaPagesa = 0;
				int kapari = Convert.ToInt32(this.numKapariKlienti.Text);
				if (kapari > 0)
					idFormaPagesa = Convert.ToInt32(this.cmbPagesaKlienti.Kolone2Vlere);
				if(System.DateTime.Now > Convert.ToDateTime(this.gridKlienti[gridKlienti.CurrentRowIndex,6]))
				{
					System.Windows.Forms.MessageBox.Show(this,
						"Ky rezervim nuk mund te futet ne dhome!"+
						Environment.NewLine+ "Data e mbarimit per rezervimin ka skaduar.", "Fut rezervim ne dhome ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.RefreshControlsKlienti(sender, e);
					return;
				}
				InputController data = new InputController();
				b = new int[nrKlient];
				int i = 0;
				foreach(DataRow dr in this.dsKlienti.Tables[0].Rows)
				{
					b[i] = data.KerkesaUpdate("FutRezervimKlientiNeDhome", dr[0].ToString(), dr[1].ToString(),
						Convert.ToDateTime(dr[2]), Convert.ToInt32(dr[3]), dr[4].ToString(),
						dr[5].ToString(), dr[6].ToString(), dr[7].ToString(),dr[8].ToString(),  
						Convert.ToInt32(dr[9]), Convert.ToInt32(dr[10]),  Convert.ToDateTime(dr[11]), Convert.ToDateTime(dr[12]),
						Convert.ToInt32(dr[13]),Convert.ToDateTime(dr[14]), dr[15].ToString(), dr[16].ToString(), 
						kapariRezervimi, idFormaPagesa, i, this.PerdoruesId);
					shuma = shuma + b[i];
					i = i+1;
				}
				if(shuma == 0)
				{
					System.Windows.Forms.MessageBox.Show(this,  "Futja e klientëve ne dhomë, u krye me sukses!","Fut rezervim në dhomë",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.RefreshControlsKlienti(sender, e);
					this.Refresh_ShtoKlient();
					this.PastroPanel();
				}
				else if (shuma != 0)
					System.Windows.Forms.MessageBox.Show(this,  "Futja e klienteve ne dhomë,nuk u krye me sukses! Provoni përsëri!","Fut rezervim në dhomë",
						MessageBoxButtons.OK, MessageBoxIcon.Error);	
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

		private void btnKerko_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				this.Pastro(this.groupBox4);
				this.Pastro(this.groupBox5);
				this.PastroPanel();
				this.cmbPagesaKlienti.Enabled = true;
				this.dsKlienti.Clear();
				DataSet ds = null;
				if (this.rbData.Checked)
				{
					DateTime dataKerkimi = Convert.ToDateTime(this.dtpData.Value);
					InputController data = new InputController();
					ds = data.KerkesaRead("ShfaqRezervimetPerKlientPerDatenEdhene", dataKerkimi);
					this.gridKlienti.DataSource = ds.Tables[0];
				}
				else if (this.rbEmri.Checked)
				{
					string emri = this.txtEmerKlienti.Text;
					string mbiemri = this.txtMbiemriKlienti.Text;
					InputController data = new InputController();
					ds = data.KerkesaRead("ShfaqRezervimetPerKlientPerEmerMbiemerTeDhene", emri, mbiemri);
					this.gridKlienti.DataSource = ds.Tables[0];
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

		private void gridKlienti_CurrentCellChanged(object sender, System.EventArgs e)
		{
			try
			{
				int kapari = 0;
				this.Pastro(this.groupBox4);
				this.Pastro(this.groupBox5);
				int rowIndex1 = this.gridKlienti.CurrentRowIndex;
				this.dsKlienti.Clear();
				this.nrKlientShtese = 0;
				cmbPagesaKlienti.Enabled = true;
				rowIndex = this.gridKlienti.CurrentRowIndex;
				this.PastroPanel();	
				this.txtEmri.Text = this.gridKlienti[rowIndex, 0].ToString();
				this.txtMbiemri.Text = this.gridKlienti[rowIndex, 1].ToString();
				DateTime dtFillim = Convert.ToDateTime(this.gridKlienti[rowIndex, 5]);
				DateTime dtMbarim = Convert.ToDateTime(this.gridKlienti[rowIndex, 6]);
				this.numKapariKlientiRez.Text = this.gridKlienti[rowIndex, 7].ToString();
				this.txtIdDhoma.Text = this.gridKlienti[rowIndex,2].ToString();
				InputController data = new InputController();
				this.idDhoma = Convert.ToInt32(this.gridKlienti[rowIndex, 8]);
				this.idRezervimi = Convert.ToInt32(this.gridKlienti[rowIndex, 10]);
				this.dtpFillimi.Value = dtFillim;
				this.dtpMbarimi.Value = dtMbarim;
				DataSet ds = data.KerkesaRead("ShfaqCmimPerDhomenDheDatatEdhena", idDhoma, dtFillim, dtMbarim);
				this.numCmimiKlienti.Text = ds.Tables[0].Rows[0][2].ToString();	
				ds = data.KerkesaRead("ShfaqTeDhenatPerDhome",idDhoma);
				nrKrevat = Convert.ToInt32(ds.Tables[0].Rows[0][3]);
				this.dhomaKlientiCift = Convert.ToInt32(ds.Tables[0].Rows[0][4]);
				this.numKapariKlienti.ReadOnly = false;
				ds = data.KerkesaRead("ShfaqKlientPerDhomePerDatat",idDhoma,dtFillim,dtMbarim);
				this.nrKrevatZene = ds.Tables[0].Rows.Count;
				if(nrKrevatZene != 0)
				{
					for(int i = 0; i < ds.Tables[0].Rows.Count;i++)
					{
						if(Convert.ToInt32(ds.Tables[0].Rows[0][5]) != 0 )
							kapari = Convert.ToInt32(ds.Tables[0].Rows[0][5]);
						else
							kapari = 0;
					}
					this.numKapariKlienti.Text = kapari.ToString();	
					this.numKapariKlienti.ReadOnly = true;
				}
			
				this.label24.Visible = true;
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
	
		private void KrijoStilGrideKlienti()
		{
			this.gridKlienti.TableStyles.Clear();
			this.gridKlienti.DataSource = ds.Tables[0];
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.Bisque;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;

			DataGridTextBoxColumn emri = new DataGridTextBoxColumn();
			emri.HeaderText = "Emri";
			emri.MappingName = "EMRI";
			emri.Width = 60;
			emri.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			
			DataGridTextBoxColumn mbiemri = new DataGridTextBoxColumn();
			mbiemri.HeaderText = "Mbiemri";
			mbiemri.MappingName = "MBIEMRI";
			mbiemri.Width = 60;
			mbiemri.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			
			DataGridTextBoxColumn dhoma = new DataGridTextBoxColumn();
			dhoma.HeaderText = "Dhoma";
			dhoma.MappingName = "DHOMA_EMRI";
			dhoma.Width = 60;
			dhoma.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			
			DataGridTextBoxColumn dtFillim = new DataGridTextBoxColumn();
			dtFillim.HeaderText = "Date Fillimi";
			dtFillim.MappingName = "DATA_HYRJE_STR";
			dtFillim.Width = 150;
			dtFillim.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			
			DataGridTextBoxColumn dtMbarim = new DataGridTextBoxColumn();
			dtMbarim.HeaderText = "Date Mbarimi";
			dtMbarim.MappingName = "DATA_DALJE_STR";
			dtMbarim.Width = 150;
			dtMbarim.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;

			DataGridTextBoxColumn dtFillim1 = new DataGridTextBoxColumn();
			dtFillim1.HeaderText = "Date Fillimi";
			dtFillim1.MappingName = "DATA_FILLIMI";
			dtFillim1.Width = 0;
			dtFillim1.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			
			DataGridTextBoxColumn dtMbarim1 = new DataGridTextBoxColumn();
			dtMbarim1.HeaderText = "Date Mbarimi";
			dtMbarim1.MappingName = "DATA_MBARIMI";
			dtMbarim1.Width = 0;
			dtMbarim1.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			
			DataGridTextBoxColumn kapari = new DataGridTextBoxColumn();
			kapari.HeaderText = "Kapari";
			kapari.MappingName = "KAPARI";
			kapari.Width = 50;
			kapari.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			
			DataGridTextBoxColumn idDhoma = new DataGridTextBoxColumn();
			idDhoma.HeaderText = "";
			idDhoma.MappingName = "ID_DHOMA";
			idDhoma.Width = 0;
			
			DataGridTextBoxColumn idKategoria = new DataGridTextBoxColumn();
			idKategoria.HeaderText = "";
			idKategoria.MappingName = "ID_KATEGORIA";
			idKategoria.Width = 0;
			
			DataGridTextBoxColumn idRezervimi = new DataGridTextBoxColumn();
			idRezervimi.HeaderText = "";
			idRezervimi.MappingName = "ID_REZERVIMI";
			idRezervimi.Width = 0;

			
			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{emri, mbiemri, dhoma, dtFillim, 
				dtMbarim,dtFillim1, dtMbarim1, kapari, idDhoma, idKategoria, idRezervimi});
			this.gridKlienti.TableStyles.Add(style);
			this.gridKlienti.FlatMode = false;
			this.gridKlienti.Expand(-1);
		}

		private void btnPagesaKlienti_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				if (numKapariKlientiRez.Text == "")
				{
					this.error.SetError(numKapariKlientiRez, "Zgjidhni nje prej rezervimeve!");
					numKapariKlientiRez.IsValid = false;
					return;
				}
				this.error.SetError(numKapariKlientiRez, "");
				numKapariKlientiRez.IsValid = true;
				if (numKapariKlienti.Text == "")
				{
					this.error.SetError(numKapariKlienti, "Jepni kaparin per dhomen!");
					numKapariKlienti.IsValid = false;
					return;
				}
				this.error.SetError(numKapariKlienti, "");
				numKapariKlienti.IsValid = true;

				int nrNjesi = 0;
				string stringNjesi = "";
				double nrNjesiOre = 0;
				double nrNjesiOre1 = 0;
				double nrNjesiMin = 0;
				int nrNjesiOre2 = 0;
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimi.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);	
				System.TimeSpan difDite = dtMbarimi.Subtract(dtFillimi);
				if(Convert.ToInt32(this.gridKlienti[this.gridKlienti.CurrentRowIndex,9]) == 31)
				{
					nrNjesi = Convert.ToInt32(difDite.Days);
					nrNjesiOre = Convert.ToDouble(difDite.Hours);
					nrNjesiOre2 = Convert.ToInt32(nrNjesiOre);
					nrNjesiMin = Convert.ToDouble(difDite.Minutes);
					nrNjesiOre1 = nrNjesiMin/60;
					nrNjesiOre = ((nrNjesi*12)+nrNjesiOre)-nrNjesiOre1;	
					nrNjesi = Convert.ToInt32(nrNjesiOre);
					stringNjesi = "ore";
				}
				else
				{
					difDite = dtMbarimi.Date.Subtract(dtFillimi.Date);
					nrNjesi = Convert.ToInt32(difDite.Days);
					stringNjesi = "dite";
				}
				int cmimi = Convert.ToInt32(this.numCmimiKlienti.Text);
				int kapari = Convert.ToInt32(this.numKapariKlientiRez.Text)+Convert.ToInt32(this.numKapariKlienti.Text);
				double shuma = nrNjesi * cmimi; 
				double shuma1 = shuma - kapari;
				int shuma2 = Convert.ToInt32(shuma1);
				System.Windows.Forms.MessageBox.Show(this, 
					"Pagesa per dhomen e zgjedhur per "+nrNjesi+" "+ stringNjesi+" eshte  "+shuma2+""
					+Environment.NewLine
					+Environment.NewLine+nrNjesi+" x "+cmimi+" - "+kapari+" = "+shuma2+"", 
				       
					"Llogaritja paraprake e pagesës", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void btnShtoKlient_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				int kapari = 0;
				int b = 0;
				int shuma = 0;
				DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimi.Value);
				DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
				this.dtpFillimi.IsValid = true;
				this.error.SetError(this.dtpFillimi,"");
				this.dtpMbarimi.IsValid = true;
				int idFormaPagesa = 0;
				//kontrolloset nese kapaciteti i dhomes eshte plotesuar
				if(this.nrKlientShtese == this.nrKrevat)
				{
					System.Windows.Forms.MessageBox.Show(this, 	"Kujdes kapaciteti i dhomes eshte plotesuar,"+
						Environment.NewLine+"ne kete dhome nuk mund te futen kliente te tjere!","Fut rezervim ne dhome ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.txtNrIdentifikimi.Text = "";
					this.txtAdresa.Text = "";
					this.txtTelefoni.Text = "";
					this.txtEmail.Text = "";
					this.txtTarga.Text = "";
					this.txtEmri.Text = "";
					this.txtMbiemri.Text = "";
					this.cmbMjetId.Kolone1.Text = "";
					this.txtVendlindjaKlienti.Text = "";
					this.txtShtetesiaKlienti.Text = "";
					return;
				}
				//kontrollohet nese po shtohet klienti qe ka bere rezervimin apo jo
				if(nrKlientShtese == 0 )
				{
					//llogarisim shumen qe duhet paguar
					if(Convert.ToInt32(this.gridKlienti[this.gridKlienti.CurrentRowIndex,9]) == 31)
					{
						System.TimeSpan difDite = dataMbarimi.Subtract(dataFillimi);
						int nrNjesi = Convert.ToInt32(difDite.Days);
						double nrNjesiOre = Convert.ToDouble(difDite.Hours);
						int nrNjesiOre2 = Convert.ToInt32(nrNjesiOre);
						double nrNjesiMin = Convert.ToDouble(difDite.Minutes);
						double nrNjesiOre1 = nrNjesiMin/60;
						nrNjesiOre = ((nrNjesi*12)+nrNjesiOre)-nrNjesiOre1;	
						nrNjesi = Convert.ToInt32(nrNjesiOre);
						shuma = nrNjesi * Convert.ToInt32(this.numCmimiKlienti.Text);
					}
					else
					{
						System.TimeSpan difDite = dataMbarimi.Date.Subtract(dataFillimi.Date);
						shuma = Convert.ToInt32(difDite.Days) * Convert.ToInt32(this.numCmimiKlienti.Text);
					}
					//knt kapari s'eshte dhene
					if  (this.numKapariKlienti.Text == "")
					{
						this.numKapariKlienti.IsValid = false;
						this.error.SetError(this.numKapariKlienti,"Ju duhet te jepni nje vlere per kaparin!");
						return;
					}
						//knt kapari < 0
					else if(Convert.ToInt32(this.numKapariKlienti.Text) < 0 )
					{
						this.numKapariKlienti.IsValid = false;
						this.error.SetError(this.numKapariKlienti,"Kapari nuk mund te jete negativ!");
						return;
					}
						//knt kapari kalon shumen 
					else if((Convert.ToInt32(this.numKapariKlienti.Text) + Convert.ToInt32(numKapariKlientiRez.Text)) > shuma)
					{
						this.numKapariKlienti.IsValid = false;
						this.error.SetError(this.numKapariKlienti,"Kapari nuk mund te kete vlere me te madhe se pagesa e dhomes" + Environment.NewLine + "jepni nje vlere te njejte ose me te vogel se pagesa!");
						return;
					}
					else if ((Convert.ToInt32(this.numKapariKlienti.Text) > 0 )&&(this.cmbPagesaKlienti.Kolone1.SelectedItem == null))
					{
						this.error.SetError(this.cmbPagesaKlienti, "Zgjidhni formen e pageses!");
						return;
					}
						//kapari eshte ok
					else
					{
						if(nrKlientShtese == 0 && this.numKapariKlienti.ReadOnly == false)
						{
							kapari = Convert.ToInt32(this.numKapariKlienti.Text);
							idFormaPagesa = Convert.ToInt32(this.cmbPagesaKlienti.Kolone2Vlere);
						}
						else
							kapari = 0;
						this.numKapariKlienti.ReadOnly = true;
						this.cmbPagesaKlienti.Enabled = false;
						this.numKapariKlienti.IsValid = true;
						this.error.SetError(this.numKapariKlienti,"");
						this.error.SetError(this.cmbPagesaKlienti, "");
			
					}
				}
				else
					kapari = 0;	
				//nese vlera e dhene per kaparin eshte e rregullt, e bejme ate 'valid'
				this.numKapariKlienti.IsValid = true;
				this.error.SetError(this.numKapariKlienti,"");
				this.error.SetError(this.numKapariKlienti,"");
				//behet shtimi i te dhenave te klientit ne dataset
				string emri = this.txtEmri.Text;
				string mbiemri = this.txtMbiemri.Text;
				DateTime datelindja = Convert.ToDateTime(this.dtpDatelindja.Value);
				int idMjetIdentifikimi = Convert.ToInt32(this.cmbMjetId.Kolone2Vlere);
				string nrIdentifikimi = this.txtNrIdentifikimi.Text;
				string adresa = this.txtAdresa.Text;
				string telefoni = this.txtTelefoni.Text;
				string targa = this.txtTarga.Text;
				string email = this.txtEmail.Text;
				string vendlindja = this.txtVendlindjaKlienti.Text;
				string shtetesia = this.txtShtetesiaKlienti.Text;
				DateTime dataKapari = dataFillimi.AddMilliseconds(DateTime.Now.Millisecond);
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
				r[13]= idRezervimi;
				r[14] = dataKapari;
				r[15] = vendlindja;
				r[16] = shtetesia;
				this.dsKlienti.Tables["KLIENTI"].Rows.Add(r);
				this.dsKlienti.AcceptChanges();
				nrKlientShtese = nrKlientShtese +1;
				//pasrohen nga paneli te  dhenat e klientit te porsa shtuar
				this.txtNrIdentifikimi.Text = "";
				this.txtAdresa.Text = "";
				this.txtTelefoni.Text = "";
				this.txtEmail.Text = "";
				this.txtTarga.Text = "";
				this.txtEmri.Text = "";
				this.txtMbiemri.Text = "";
				this.cmbMjetId.Kolone1.Text = "";
				this.txtVendlindjaKlienti.Text = "";
				this.txtShtetesiaKlienti.Text = "";
				this.txtEmri.ReadOnly = false;
				this.txtMbiemri.ReadOnly = false;
				this.PastroPanel();
				this.nrKrevatZene = this.nrKrevatZene +1;
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

		private void dtpFillimi_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if ((this.tab.SelectedIndex == 0)&&(this.gridKlienti.CurrentRowIndex >= 0))
				{
					string s = this.gridKlienti[this.gridKlienti.CurrentRowIndex,5].ToString();
//					if (Convert.ToBoolean(System.DateTime.Parse(s)))
//					{
//						this.dtpFillimi.Value = Convert.ToDateTime(this.gridKlienti[this.gridKlienti.CurrentRowIndex,5].ToString());
//					}
////					if (s.EndsWith("D"))
					this.dtpFillimi.Value = Convert.ToDateTime(this.gridKlienti[this.gridKlienti.CurrentRowIndex,5].ToString());
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

		private void dtpMbarimi_ValueChanged(object sender, System.EventArgs e)
		{            
			try
			{
				if ((this.tab.SelectedIndex == 0)&&(this.gridKlienti.CurrentRowIndex >= 0))
					this.dtpMbarimi.Value = Convert.ToDateTime(this.gridKlienti[this.gridKlienti.CurrentRowIndex,6].ToString());
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

		private void pic_Click(object sender, System.EventArgs e)
		{
			try
			{
				DataSet ds = null;
				string mesazhi = "";
			
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
		}

		#endregion

		#region MetodaNdihmese KLienti
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
				lartesi = 31;
				gjeresi = 33;
				hapsire = 5;
				h_nr = 5;
				//				this.panelCmimi.Visible = true;
				//				this.panelCmimi.Location = new System.Drawing.Point(28,180);
				if(this.dhomaKlientiCift == 1)
				{
					if(this.nrKrevatZene == 0)
					{
						emri = "0";
						System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
						pic.Name = emri;
				
						
						pic.Size = new System.Drawing.Size(37,36);
						pic.Location = new System.Drawing.Point(8, 8);
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
						pic.Location = new System.Drawing.Point(8,8);
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
						pic.Location = new System.Drawing.Point(8, 8);
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
				//				this.panelCmimi.Visible = true;
				this.panelDhomat.Size = new System.Drawing.Size(213,87);
				//				this.panelCmimi.Location = new System.Drawing.Point(28,220);
				
				
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
				//				this.panelCmimi.Visible = true;
				this.panelDhomat.Size = new System.Drawing.Size(220,40);
				//				this.panelCmimi.Location = new System.Drawing.Point(28,180);
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
		public void Pastro()
		{
			foreach(Control c in this.panelDhomat.Controls)
			{
				try
				{
					if(nrKrevat <=5)
					{

						System.Windows.Forms.PictureBox p = (System.Windows.Forms.PictureBox) c;
						p.Dispose();
					}
					else if(nrKrevat >5 && nrKrevat <=30)
					{
						System.Windows.Forms.Button b = (System.Windows.Forms.Button) c;
						b.Dispose();
					}
					else
					{
						System.Windows.Forms.Label l = (System.Windows.Forms.Label) c;
						l.Dispose();
					}
				}
				catch(Exception ex)
				{
					return;
				}
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
			data_str = dita + "-" + muaji + "-" + viti;
			return data_str;
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
			dsKlienti.Tables["KLIENTI"].Columns.Add("ID_REZERVIMI",typeof(int));
			dsKlienti.Tables["KLIENTI"].Columns.Add("DATA_KAPARI",typeof(DateTime));
			dsKlienti.Tables["KLIENTI"].Columns.Add("VENDLINDJA",typeof(String));
			dsKlienti.Tables["KLIENTI"].Columns.Add("SHTETESIA",typeof(String));
			dsKlienti.AcceptChanges();
		}

		private void Refresh_ShtoKlient()
		{
			this.txtNrIdentifikimi.Text = "";
			this.txtAdresa.Text = "";
			this.txtTelefoni.Text = "";
			this.txtEmail.Text = "";
			this.txtTarga.Text = "";
			this.numKapariKlienti.Clear();
			this.cmbPagesaKlienti.Enabled = true;
			this.cmbPagesaKlienti.Kolone1.Text = "";
			this.cmbPagesaKlienti.Kolone2.Text = "";
			this.dtpFillimi.Value = DateTime.Now;
			this.dtpMbarimi.Value = DateTime.Now;
			this.txtIdDhoma.Text = "";
			this.numCmimiKlienti.Text = "";
			this.dsKlienti.Clear();
			this.nrKlientShtese = 0;
		}
		private void RefreshControlsKlienti(object sender, System.EventArgs e)
		{
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqRezervimeKlienti");
			this.gridKlienti.DataSource = ds.Tables[0];
			if ((this.rbData.Checked == true)||(this.rbGrupi.Checked == true))
				this.btnKerko_Click(sender, e);
		}
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
		#endregion

		#region FutRezervimGrupi

		private void btnKerko1_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				ds.Clear();
				this.Pastro(this.groupBox1);
				this.Pastro(this.groupBox6);
				this.PastroPanelGrupi();
				this.cmbPagesaGrupi.Enabled = true;
				this.dsKlientiGrupi.Clear();
				if (this.rbData1.Checked)
				{
					DateTime dataKerkimi = Convert.ToDateTime(this.dtpDataGrupi.Value);
					InputController data = new InputController();
					ds = data.KerkesaRead("ShfaqRezervimetPerGrupDhomePerDatenEdhene", dataKerkimi);
					this.gridGrupi.DataSource = ds.Tables[0];
				}
				else if (this.rbGrupi.Checked)
				{
					string grupi = this.txtEmerGrupi.Text;
					string agjensia = this.txtAgjensiaGrupi.Text;
					InputController data = new InputController();
					ds = data.KerkesaRead("ShfaqRezervimetDhomePerGrupAgjensiTeDhene", grupi, agjensia);
					this.gridGrupi.DataSource = ds.Tables[0];
				}
				this.RefreshControlsGrupi();
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

		private void btnFutKlientGrup_Click_1(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				int kapari = 0;
				int shuma1 = 0;
				DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimi1.Value);
				DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimi1.Value);
				InputController data = new InputController();
				if(dataMbarimi.CompareTo(System.DateTime.Now) < 0 )
				{
					System.Windows.Forms.MessageBox.Show(this,
						"Ky rezervim nuk mund te futet ne dhome!"+
						Environment.NewLine+ "Data e mbarimit per rezervimin ka skaduar.", "Fut rezervim ne dhome ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.RefreshControlsKlienti(sender, e);
					return;
				}
				//kontrollohet nese kapaciteti i dhomes eshte plotesuar
				if(this.nrKlientShteseGrupi == this.nrKrevatGrupi)
				{
					System.Windows.Forms.MessageBox.Show(this, 	"Kujdes kapaciteti i dhomës është plotësuar,"+
						Environment.NewLine+"në këtë dhomë nuk mund të futen klientë të tjerë!","Fut rezervim në dhomë ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.txtNrIdentifikimi.Text = "";
					this.txtAdresa.Text = "";
					this.txtTelefoni.Text = "";
					this.txtEmail.Text = "";
					this.txtTarga.Text = "";
					this.txtEmri.Text = "";
					this.txtMbiemri.Text = "";
					this.cmbMjetId.Kolone1.Text = "";
					return;
				}
				//kontrollohet rregullsia e kaparit
//				if ((this.nrKlientShteseGrupi == 0)&& (numKapariGrupi.ReadOnly == true))
				if (this.nrKlientShteseGrupi == 0)
				{
					//llogarisim shumen qe duhet paguar
					DataSet dsPagesa = data.KerkesaRead("ShfaqDhomaPerRezervimGrupiPerdata",this.idRezervimiGrupi, dataFillimi);
					foreach(DataRow dr in dsPagesa.Tables[0].Rows)
					{
						int cmim = Convert.ToInt32(dr["CMIMI"]);
						int idKategoria = Convert.ToInt32(dr["ID_KATEGORIA"]);
						shuma1 = shuma1 + this.GjejPagesen(idKategoria, cmim, dataFillimi, dataMbarimi);
					}
					ds = data.KerkesaRead("ShfaqVeprimetPerGrupin", idGrupi,-1, dataFillimi.AddDays(-15), dataMbarimi.AddDays(15));
					int indexkerkuar = this.KerkoDataSet(ds, dataFillimi, dataMbarimi);
					if (indexkerkuar >= 0)
					{
						DataRow drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
						string strId = drk["ID_KLIENTI_STR"].ToString();
						DataSet tmp = this.gjejDataSetKlientet(strId);
						dsPagesa = this.PagesaGrupi(tmp, kapari, 0, 0);
						foreach(DataRow dr in dsPagesa.Tables[0].Rows)
						{
							int pagesaDhoma = Convert.ToInt32(dr["VLERA"]);
							shuma1 += pagesaDhoma;
						}
					}
					//knt kapari s'eshte dhene
					if  (this.numKapariGrupi.Text == "")
					{
						this.numKapariGrupi.IsValid = false;
						this.error.SetError(this.numKapariGrupi,"Ju duhet te jepni nje vlere per kaparin!");
						return;
					}
					//knt kapari < 0
					else if(Convert.ToInt32(this.numKapariGrupi.Text) < 0)
					{
						this.numKapariGrupi.IsValid = false;
						this.error.SetError(this.numKapariGrupi,"Kapari nuk mund te kete vlere me te vogel se zero!");
						return;
					}
					//knt kapari kalon shumen 
					else if((Convert.ToInt32(this.numKapariGrupi.Text) + Convert.ToInt32(this.numKapariRGrupi.Text)) > shuma1)
					{
						this.numKapariGrupi.IsValid = false;
						this.error.SetError(this.numKapariGrupi,"Kapari nuk mund te kete vlere me te madhe se pagesa e grupit" + Environment.NewLine + "jepni nje vlere te njejte ose me te vogel se pagesa!");
						return;
					}
					else if ((kapari > 0)&&(this.cmbPagesaGrupi.Kolone1.SelectedItem == null))
					{
						this.error.SetError(this.cmbPagesaGrupi, "Zgjidhni formen e pageses!");
						return;
					}
					//kapari eshte ok
					else
					{
						if ((this.nrKlientShteseGrupi == 0) && (this.numKapariGrupi.ReadOnly == false))
							kapari = Convert.ToInt32(this.numKapariGrupi.Text);
						else
							kapari = 0;
						this.numKapariGrupi.ReadOnly = true;
						this.cmbPagesaGrupi.Enabled = false;
						this.numKapariGrupi.IsValid = true;
						this.error.SetError(this.numKapariGrupi,"");
						this.error.SetError(this.cmbPagesaGrupi, "");
					}
				}
				else
					kapari = 0;	
				//nese vlera e dhene per kaparin eshte e regullt, e bejme ate 'valid'
				this.numKapariGrupi.IsValid = true;
				this.error.SetError(this.numKapariGrupi,"");
				this.error.SetError(this.cmbPagesaGrupi, "");
				//behet shtimi i te dhenave te klientit ne dataset
				string emri = this.txtEmriKlienti.Text;
				string mbiemri = this.txtMbiemriKlienti1.Text;
				DateTime datelindja = Convert.ToDateTime(this.dtpDatelindja1.Value);
				string adresa = this.txtAdresa1.Text;
				string telefoni = this.txtTelefoni1.Text;
				string targa = this.txtTarga1.Text;
				string email = this.txtEmail1.Text;
				string nrIdentifikimi = this.txtNrIdentGrupi.Text;
				int idMjetIdentifikimi = Convert.ToInt32(this.cmbMjetId1.Kolone2Vlere);
				DateTime dataKapari = dataFillimi.AddMilliseconds(DateTime.Now.Millisecond);
				string vendlindja = this.txtVendlindjaGrupi.Text;
				string shtetesia = this.txtShtetesiaGrupi.Text;
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
				r[10] = idDhomaGrupi;
				r[11] = kapari;
				r[12] = dataFillimi;
				r[13] = dataMbarimi;
				r[14] = this.idRezervimiGrupi;
				r[15] = dataKapari;
				r[16] = vendlindja;
				r[17] = shtetesia;
				this.dsKlientiGrupi.Tables["KLIENTI"].Rows.Add(r);
				this.dsKlientiGrupi.AcceptChanges();
				nrKlientShteseGrupi = nrKlientShteseGrupi +1;
				if(this.nrKlientShteseGrupi > this.nrKrevatGrupi)
				{
					System.Windows.Forms.MessageBox.Show(this, 	"Kujdes kapaciteti i dhomes eshte plotesuar,"+
						Environment.NewLine+"ne kete dhome nuk mund te futen kliente te tjere!","Fut rezervim ne dhome ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				this.PastroPanelGrupi();
				this.nrKrevatZeneGrupi = this.nrKrevatZeneGrupi +1;
				this.MbushPanelGrupi();
				this.txtEmriKlienti.Text = "";
				this.txtMbiemriKlienti1.Text = "";
				this.txtNrIdentGrupi.Text = "";
				this.txtAdresa1.Text = "";
				this.txtTelefoni1.Text = "";
				this.txtEmail1.Text = "";
				this.txtTarga1.Text = "";
				this.cmbMjetId1.Kolone1.Text = "";
				this.txtVendlindjaGrupi.Text = "";
				this.txtShtetesiaGrupi.Text = "";
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
	
		private void MerrDhomeGrupi_Click(object sender, System.EventArgs e)
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
						"Fut rezervim ne dhome",	MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				int kapariRezervimi = 0;
				if (this.hedhurKaparGrupi == true)
					kapariRezervimi = 0;
				else
					kapariRezervimi = Convert.ToInt32(numKapariRGrupi.Text);			
				InputController data = new InputController();
				int idFormaPagesa = 0;
				if (Convert.ToInt32(this.numKapariGrupi.Text) > 0)
				{
					idFormaPagesa = Convert.ToInt32(this.cmbPagesaGrupi.Kolone2Vlere); 
				}
				b = new int[nrKlient];
				int i = 0;
				foreach(DataRow dr in this.dsKlientiGrupi.Tables[0].Rows)
				{
					b[i] = data.KerkesaUpdate("FutRezervimGrupiNeDhome",dr[1].ToString(), dr[2].ToString(),
						Convert.ToDateTime(dr[3]), Convert.ToInt32(dr[4]), dr[5].ToString(),
						dr[6].ToString(), dr[7].ToString(), dr[8].ToString(),dr[9].ToString(),  
						Convert.ToInt32(dr[10]),Convert.ToInt32(dr[11]), Convert.ToDateTime(dr[12]), Convert.ToDateTime(dr[13]),Convert.ToInt32(dr[0]),Convert.ToInt32(dr[14]),
						Convert.ToDateTime(dr[15]), dr[16].ToString(), dr[17].ToString(),
						kapariRezervimi, idFormaPagesa, i, this.hedhurKaparGrupi, this.PerdoruesId);
					shuma = shuma + b[i];
					i = i+1;
				}
				if(shuma == 0)
				{
					System.Windows.Forms.MessageBox.Show(this,  "Futja e klientëve të grupit në dhomën e rezervuar, u krye me sukses!","Fut rezervim në dhomë",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.dsKlientiGrupi.Clear();
					this.numKapariRGrupi.Text = "";
					this.RefreshGrupi( sender,  e);
					this.label33.Visible = false;
					this.PastroPanelGrupi();
				}
				else if (shuma != 0)
					System.Windows.Forms.MessageBox.Show(this,  "Futja e klientëve të grupit në dhomën e rezervuar, nuk u krye me sukses! Provoni përseri!" ,"Fut rezervim ne dhome",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
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
		
		private void gridGrupi_CurrentCellChanged_1(object sender, System.EventArgs e)
		{
			try
			{
				DataSet ds = null;
				int kapari = 0;
				this.Pastro(this.groupBox1);
				this.Pastro(this.groupBox6);
				this.PastroPanelGrupi();
				this.cmbPagesaGrupi.Enabled = true;
				this.numKapariGrupi.ReadOnly = false;
				this.dsKlientiGrupi.Clear();
				this.nrKlientShteseGrupi = 0;
				numKapariGrupi.Text = "";
				InputController data = new InputController();
				int rowIndex = this.gridGrupi.CurrentRowIndex;
				this.txtGrupi.Text = this.gridGrupi[rowIndex,0].ToString();
				this.txtDhoma1.Text = this.gridGrupi[rowIndex,2].ToString();
				this.dtpFillimi1.Text = this.gridGrupi[rowIndex,5].ToString();
				this.dtpMbarimi1.Text = this.gridGrupi[rowIndex,6].ToString();
				this.idDhomaGrupi = Convert.ToInt32(this.gridGrupi[rowIndex,9]);
				this.PastroPanelGrupi();
				this.idGrupi = Convert.ToInt32(this.gridGrupi[rowIndex,11]);
				ds = data.KerkesaRead("ShfaqTeDhenaGrupiPerDatat", idGrupi, Convert.ToDateTime(this.gridGrupi[rowIndex,5]),Convert.ToDateTime(this.gridGrupi[rowIndex,6]));
				if(ds.Tables[0].Rows.Count != 0 )
				{
					this.numKapariGrupi.Text = Convert.ToString(Convert.ToInt32(ds.Tables[1].Rows[0]["KAPARI"]) - Convert.ToInt32(this.gridGrupi[rowIndex,8]));
					this.hedhurKaparGrupi = true;
					this.numKapariGrupi.ReadOnly = true;
					this.cmbPagesaGrupi.Kolone1Vlere = Convert.ToString(ds.Tables[1].Rows[0]["EMRI"]);
					this.cmbPagesaGrupi.Kolone1.Text = Convert.ToString(ds.Tables[1].Rows[0]["EMRI"]);
					this.cmbPagesaGrupi.Kolone2Vlere = Convert.ToInt32(ds.Tables[1].Rows[0]["ID_FORMAPAGESA"]);
					this.cmbPagesaGrupi.Kolone2.Text = Convert.ToString(ds.Tables[1].Rows[0]["ID_FORMAPAGESA"]);
					this.cmbPagesaGrupi.Enabled = false;
				}
				else
					this.hedhurKaparGrupi = false;
				ds = data.KerkesaRead("ShfaqTeDhenatPerDhome",this.idDhomaGrupi);
				nrKrevatGrupi = Convert.ToInt32(ds.Tables[0].Rows[0][3]);
				this.dhomaGrupiCift = Convert.ToInt32(ds.Tables[0].Rows[0][4]);

				this.idRezervimiGrupi = Convert.ToInt32(this.gridGrupi[rowIndex,10]);
		  	
				this.numKapariRGrupi.Text = this.gridGrupi[rowIndex,8].ToString();
				ds = data.KerkesaRead("ShfaqCmimPerDhomenDheDatatEdhena", this.idDhomaGrupi, Convert.ToDateTime(this.dtpFillimi1.Value), Convert.ToDateTime(this.dtpMbarimi1.Value ));
				this.numCmimiGrupi.Text = ds.Tables[0].Rows[0][2].ToString();			
				ds = data.KerkesaRead("ShfaqKlientPerDhomePerDatat",idDhomaGrupi,Convert.ToDateTime(this.gridGrupi[rowIndex,5]),Convert.ToDateTime(this.gridGrupi[rowIndex,5]));
				this.nrKrevatZeneGrupi = ds.Tables[0].Rows.Count;
				if(nrKrevatZeneGrupi != 0)
				{
					for(int i = 0; i < ds.Tables[0].Rows.Count;i++)
					{
						if(Convert.ToInt32(ds.Tables[0].Rows[0][5]) != 0 )
							kapari = Convert.ToInt32(ds.Tables[0].Rows[0][5]);
						else
							kapari = 0;
					}
					this.numKapariGrupi.Text = kapari.ToString();	
					this.numKapariGrupi.ReadOnly = true;
				}
				this.label33.Visible = true;
				this.MbushPanelGrupi();
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

		private void picG_Click(object sender, System.EventArgs e)
		{
			try
			{
				DataSet ds = null;
				string mesazhi = "";
				DateTime dtFillimiGrupi = Convert.ToDateTime(this.dtpFillimi1.Value);
				DateTime dtMbarimiGrupi = Convert.ToDateTime(this.dtpMbarimi1.Value);
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
							r[0]=this.dsKlientiGrupi.Tables["KLIENTI"].Rows[l][1];
							r[1]=this.dsKlientiGrupi.Tables["KLIENTI"].Rows[l][2];
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
								string emriKl = ds.Tables[0].Rows[0][1] + "     " + r2[1].ToString() ;
								string mbiemriKl = ds.Tables[0].Rows[0][2] + "     " + r2[2].ToString();
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
				DateTime dtFillimiGrupi = Convert.ToDateTime(this.dtpFillimi1.Value);
				DateTime dtMbarimiGrupi = Convert.ToDateTime(this.dtpMbarimi1.Value);
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
		private void dtpFillimi1_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				 if ((this.tab.SelectedIndex == 1)&&(this.gridGrupi.CurrentRowIndex >= 0))
					this.dtpFillimi1.Value = Convert.ToDateTime(this.gridGrupi[this.gridGrupi.CurrentRowIndex,5].ToString());
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

		private void dtpMbarimi1_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if ((this.tab.SelectedIndex == 1)&&(this.gridGrupi.CurrentRowIndex >= 0))
					this.dtpMbarimi1.Value = Convert.ToDateTime(this.gridGrupi[this.gridGrupi.CurrentRowIndex,6].ToString());
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

		private void button3_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (this.numKapariRGrupi.Text == "")
				{
					this.error.SetError(this.numKapariRGrupi, "Zgjidhni nje prej rezervimeve!");
					this.numKapariRGrupi.IsValid = false;
					return;
				}
				this.error.SetError(this.numKapariRGrupi, "");
				this.numKapariRGrupi.IsValid = true;
				if (this.numKapariGrupi.Text == "")
				{
					this.error.SetError(this.numKapariGrupi, "Jepni kaparin per grupin");
					this.numKapariGrupi.IsValid = false;
					return;
				}
				this.error.SetError(this.numKapariGrupi, "");
				this.numKapariGrupi.IsValid = true;
				DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimi1.Value);
				DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimi1.Value);
				InputController data = new InputController();
				//fillimisht vendosim pagesen qe duhet te beje grupi per dhomat e rezervuara
				DataSet dsPagesa = data.KerkesaRead("ShfaqDhomaPerRezervimGrupiPerdata",this.idRezervimiGrupi, dataFillimi);
				string s = "Pagesa që duhet të bëjë grupi është:";
				s += Environment.NewLine + "Dhomat e rezervuara:";
				int shuma1 = 0;
				int i = 0;
				foreach(DataRow dr in dsPagesa.Tables[0].Rows)
				{
					int cmim = Convert.ToInt32(dr["CMIMI"]);
					int idKategoria = Convert.ToInt32(dr["ID_KATEGORIA"]);
					string njesi = "";
					if (idKategoria == 31)
					{
						TimeSpan ts = dataMbarimi.Subtract(dataFillimi);
						double ore = Math.Round(ts.TotalHours, 1);
						njesi = ore + " ore";
					}
					else
					{
						TimeSpan ts = dataMbarimi.Date.Subtract(dataFillimi.Date);
						int dite = Convert.ToInt32(ts.TotalDays);
						njesi = dite + " dite";
					}
					int pagesaDhoma = this.GjejPagesen(idKategoria, cmim, dataFillimi, dataMbarimi);
					shuma1 = shuma1 + pagesaDhoma;
					s += Environment.NewLine + (i + 1) + ". " + dr["DHOMA_EMRI"].ToString() + "    " + njesi + " x " + cmim + " = " + pagesaDhoma;
					i++;
				}
				//me pas llogarisim pagesen qe duhet te beje grupi per dhomat tashme te zena prej tij
				ds = data.KerkesaRead("ShfaqVeprimetPerGrupin", idGrupi,-1, dataFillimi.AddDays(-30), dataMbarimi.AddDays(30));
				int indexkerkuar = this.KerkoDataSet(ds, dataFillimi, dataMbarimi);
				int kapari = Convert.ToInt32(this.numKapariGrupi.Text) + Convert.ToInt32(this.numKapariRGrupi.Text);
				if (indexkerkuar >= 0)
				{
					s += Environment.NewLine + "Dhomat e zëna:";
					DataRow drk = ds.Tables["KLIENTI"].Rows[indexkerkuar];
					string strId = drk["ID_KLIENTI_STR"].ToString();
					DataSet tmp = this.gjejDataSetKlientet(strId);
					dsPagesa = this.PagesaGrupi(tmp, kapari, 0, 0);
					foreach(DataRow dr in dsPagesa.Tables[0].Rows)
					{
						string njesi = dr["INTERVALI"].ToString();
						int cmim = Convert.ToInt32(dr["CMIMI"]);
						int pagesaDhoma = Convert.ToInt32(dr["VLERA"]);
						shuma1 += pagesaDhoma;
						s += Environment.NewLine + (i + 1) + ". " + dr["DHOMA"].ToString() + "    " + njesi + " x " + cmim + " = " + pagesaDhoma;
						i++;
					}
				}
				int shumaMekapar = shuma1 - kapari;
				s += Environment.NewLine + "Totali:   " + shuma1 + " - " + kapari + " = " +shumaMekapar;
				System.Windows.Forms.MessageBox.Show(this, s, "Llogaritja paraprake e pagesës", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		#region Metoda Ndihmese grupi
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
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("ID_REZERVIMI",typeof(int));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("DATA_KAPARI",typeof(DateTime));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("VENDLINDJA",typeof(String));
			dsKlientiGrupi.Tables["KLIENTI"].Columns.Add("SHTETESIA",typeof(String));
			dsKlientiGrupi.AcceptChanges();
		}
		private void KrijoStilGrideGrupi()
		{
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.Bisque;
			this.gridGrupi.TableStyles.Clear();
			this.gridGrupi.ReadOnly = true;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;

			DataGridTextBoxColumn grupi = new DataGridTextBoxColumn();
			grupi.HeaderText = "Grupi";
			grupi.MappingName = "EMRI";
			grupi.Width = 120;
			grupi.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;

			DataGridTextBoxColumn agjensia = new DataGridTextBoxColumn();
			agjensia.HeaderText = "Agjensia";
			agjensia.MappingName = "AGJENSIA";
			agjensia.Width = 80;
			agjensia.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			
			DataGridTextBoxColumn dhoma = new DataGridTextBoxColumn();
			dhoma.HeaderText = "Dhoma";
			dhoma.MappingName = "DHOMA_EMRI";
			dhoma.Width = 60;
			dhoma.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;

			DataGridTextBoxColumn dtFillim = new DataGridTextBoxColumn();
			dtFillim.HeaderText = "Date Fillimi";
			dtFillim.MappingName = "DATA_HYRJE_STR";
			dtFillim.Width = 150;
			dtFillim.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;

			DataGridTextBoxColumn dtMbarim = new DataGridTextBoxColumn();
			dtMbarim.HeaderText = "Date Mbarimi";
			dtMbarim.MappingName = "DATA_DALJE_STR";
			dtMbarim.Width = 150;
			dtMbarim.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			
			DataGridTextBoxColumn dtFillim1 = new DataGridTextBoxColumn();
			dtFillim1.HeaderText = "Date Mbarimi";
			dtFillim1.MappingName = "DATA_FILLIMI";
			dtFillim1.Width = 0;
			dtFillim1.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;

			DataGridTextBoxColumn dtMbarim1 = new DataGridTextBoxColumn();
			dtMbarim1.HeaderText = "Data e mbarimit";
			dtMbarim1.MappingName = "DATA_MBARIMI";
			dtMbarim1.Width = 0;
			dtMbarim1.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;

			DataGridTextBoxColumn dtRezervim = new DataGridTextBoxColumn();
			dtRezervim.HeaderText = "Data e rezervimit";
			dtRezervim.MappingName = "DATA_REZERVIMI_STR";
			dtRezervim.Width = 0;
			dtRezervim.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;

			DataGridTextBoxColumn kapari = new DataGridTextBoxColumn();
			kapari.HeaderText = "Kapari";
			kapari.MappingName = "KAPARI";
			kapari.Width = 50;

			
			DataGridTextBoxColumn idDhoma = new DataGridTextBoxColumn();
			idDhoma.HeaderText = "";
			idDhoma.MappingName = "ID_DHOMA";
			idDhoma.Width = 0;
			
			DataGridTextBoxColumn idRezervimi = new DataGridTextBoxColumn();
			idRezervimi.HeaderText = "";
			idRezervimi.MappingName = "ID_REZERVIMI";
			idRezervimi.Width = 0;

			DataGridTextBoxColumn idGrupi = new DataGridTextBoxColumn();
			idGrupi.HeaderText = "";
			idGrupi.MappingName = "ID_GRUPI";
			idGrupi.Width = 0;

			DataGridTextBoxColumn idKategoria = new DataGridTextBoxColumn();
			idKategoria.HeaderText = "";
			idKategoria.MappingName = "ID_KATEGORIA";
			idKategoria.Width = 0;
			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{grupi, agjensia,dhoma,dtFillim, dtMbarim, 
																		 dtFillim1, dtMbarim1, dtRezervim,kapari, idDhoma, idRezervimi,idGrupi,
																		 idKategoria});
			this.gridGrupi.TableStyles.Add(style);
			this.gridGrupi.FlatMode = false;
		}
		private void RefreshGrupi(object sender, System.EventArgs e)
		{
			this.txtGrupi.Text = "";
			this.txtEmriKlienti.Text = "";
			this.txtMbiemriKlienti1.Text = "";
			this.cmbMjetId1.Kolone1.Text = "";
			this.txtNrIdentGrupi.Text = "";
			this.txtAgjensiaGrupi.Text = "";
			this.txtTelefoni1.Text = "";
			this.txtTarga1.Text = "";
			this.txtAdresa1.Text = "";
			this.txtEmail1.Text = "";
			this.dtpFillimi1.Value = DateTime.Now;
			this.dtpMbarimi1.Value = DateTime.Now;
			this.dtpFillimi1.Value = DateTime.Now;
			this.dtpMbarimi1.Value = DateTime.Now;
			this.txtDhoma1.Text = "";
			this.numCmimiGrupi.Text = "";
			this.numKapariGrupi.Text = "";
			this.cmbPagesaGrupi.Enabled = true;
			this.cmbPagesaGrupi.Kolone1.Text = "";
			this.cmbPagesaGrupi.Kolone2.Text = "";
			this.cmbPagesaGrupi.Enabled = true;
			this.nrKlientShteseGrupi = 0;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqRezervimeGrupiDhome");
			this.gridGrupi.DataSource = ds.Tables[0];
			if ((this.rbData1.Checked == true)||(this.rbGrupi.Checked == true))
				this.btnKerko1_Click(sender, e);
		}
		
		private void RefreshControlsGrupi()
		{
			this.txtGrupi.Text = "";
			this.txtEmriKlienti.Text = "";
			this.txtMbiemriKlienti1.Text = "";
			this.cmbMjetId1.Kolone1.Text = "";
			this.txtNrIdentGrupi.Text = "";
			this.txtAgjensiaGrupi.Text = "";
			this.txtTelefoni1.Text = "";
			this.txtTarga1.Text = "";
			this.txtAdresa1.Text = "";
			this.txtEmail1.Text = "";
			this.dtpFillimi1.Text = "";
			this.dtpMbarimi1.Text = "";
			this.txtDhoma1.Text = "";
			this.numCmimiGrupi.Text = "";
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
				
				this.panelDhomatGrupi.Size = new System.Drawing.Size(213,87);
				
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
				
				this.panelDhomatGrupi.Size = new System.Drawing.Size(220,40);
				
				System.Windows.Forms.Label lb = new System.Windows.Forms.Label();
				lb.Size = new System.Drawing.Size(185, 28);
				lb.Visible = true;
				lb.Location = new System.Drawing.Point (4,4);
				lb.ForeColor = System.Drawing.Color.Navy;
				int nrKrevatLireG = nrKrevatGrupi - this.nrKrevatZeneGrupi;
				lb.Text = "Kapaciteti i dhomes eshte "+nrKrevatLireG+" shtreter te lire dhe "+ nrKrevatZene+" shtreter te zene.";
				this.panelDhomatGrupi.Controls.Add(lb);
				i = i + 1;
			}
			
		}

		private void PastroPanelGrupi()
		{
			try
			{
				panelDhomatGrupi.Controls.Clear();
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
		#endregion

		private void btnSkano_Click(object sender, System.EventArgs e)
		{
			string[] str = Skanim.Skanim.GetValueFromScan();
			this.txtEmri.Text = str.GetValue(0).ToString();
			this.txtMbiemri.Text = str.GetValue(1).ToString();
			this.txtNrIdentifikimi.Text = str.GetValue(2).ToString();
		}

		private void btnSkanoGrup_Click(object sender, System.EventArgs e)
		{
			string[] str = Skanim.Skanim.GetValueFromScan();
			this.txtEmriKlienti.Text = str.GetValue(0).ToString();
			this.txtMbiemriKlienti.Text = str.GetValue(1).ToString();
			this.txtNrIdentGrupi.Text = str.GetValue(2).ToString();
		}
		
	}   
}

