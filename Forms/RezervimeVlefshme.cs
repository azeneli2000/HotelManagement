using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using VisionInfoSolutionLibrary;

namespace HotelManagment.Forms
{
	public class RezervimeVlefshme : VisionInfoSolutionLibrary.Form, IPrintable
	{
		#region Private Variables
		private VisionInfoSolutionLibrary.GroupBox gbZgjidh;
		private VisionInfoSolutionLibrary.TextBox txtMbiemri1;
		private VisionInfoSolutionLibrary.TextBox txtEmri1;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.Label lblEmr;
		private VisionInfoSolutionLibrary.DateTimePicker dtpPrej;
		private VisionInfoSolutionLibrary.RadioButton rbData;
		private VisionInfoSolutionLibrary.RadioButton rbEmri;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.Button btnKerko;
		private VisionInfoSolutionLibrary.DataGrid dg1;
		private VisionInfoSolutionLibrary.TabControl tabControl1;
		private VisionInfoSolutionLibrary.TabPageControl tbKlient;
		private VisionInfoSolutionLibrary.TabPageControl tbGrup;
		private VisionInfoSolutionLibrary.RadioButton rbDhoma;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhoma;
		private VisionInfoSolutionLibrary.RadioButton rbGrupi;
		private VisionInfoSolutionLibrary.RadioButton rbDataGrupi;
		private VisionInfoSolutionLibrary.RadioButton rbDhomaGrupi;
		private VisionInfoSolutionLibrary.Button btnKerkoGrup;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhomaGrup;
		private VisionInfoSolutionLibrary.DateTimePicker dtpPrejGrupi;
		private VisionInfoSolutionLibrary.DoubleCombo cmbGrupetKerkim;
		private VisionInfoSolutionLibrary.TextBox txtAgjensiaKerkim;
		private VisionInfoSolutionLibrary.GroupBox gbKlient;
		private VisionInfoSolutionLibrary.GroupBox gbGrup;
		private VisionInfoSolutionLibrary.DataGrid dg2;
		private System.Windows.Forms.VScrollBar sender1 = new System.Windows.Forms.VScrollBar();
		private System.Data.DataSet ds;
		private bool clicked;
		/// <summary>
		/// Fushe qe mban vleren e propertise ReadyToPrint
		/// </summary>
		private bool readyToPrint = true;
		/// <summary>
		/// Fushe private qe mban numrin e rreshtave qe mban rreshti i pare i dukshem i dgDhoma
		/// </summary>
		#endregion

		#region Constructors & Destructors
		public RezervimeVlefshme()
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
			this.gbZgjidh = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbDhoma = new VisionInfoSolutionLibrary.DoubleCombo();
			this.txtMbiemri1 = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmri1 = new VisionInfoSolutionLibrary.TextBox();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.lblEmr = new VisionInfoSolutionLibrary.Label();
			this.dtpPrej = new VisionInfoSolutionLibrary.DateTimePicker();
			this.rbData = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbEmri = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbDhoma = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.btnKerko = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbKlient = new VisionInfoSolutionLibrary.GroupBox();
			this.dg1 = new VisionInfoSolutionLibrary.DataGrid();
			this.ds = new System.Data.DataSet();
			this.tabControl1 = new VisionInfoSolutionLibrary.TabControl();
			this.tbKlient = new VisionInfoSolutionLibrary.TabPageControl();
			this.tbGrup = new VisionInfoSolutionLibrary.TabPageControl();
			this.gbGrup = new VisionInfoSolutionLibrary.GroupBox();
			this.dg2 = new VisionInfoSolutionLibrary.DataGrid();
			this.btnKerkoGrup = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbGrupetKerkim = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbDhomaGrup = new VisionInfoSolutionLibrary.DoubleCombo();
			this.dtpPrejGrupi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.rbDhomaGrupi = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbDataGrupi = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbGrupi = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.txtAgjensiaKerkim = new VisionInfoSolutionLibrary.TextBox();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			((System.ComponentModel.ISupportInitialize)(this.gbZgjidh)).BeginInit();
			this.gbZgjidh.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbKlient)).BeginInit();
			this.gbKlient.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tbKlient.SuspendLayout();
			this.tbGrup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbGrup)).BeginInit();
			this.gbGrup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1015, 25);
			this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
			// 
			// gbZgjidh
			// 
			this.gbZgjidh.BackColor = System.Drawing.Color.Transparent;
			this.gbZgjidh.Controls.Add(this.cmbDhoma);
			this.gbZgjidh.Controls.Add(this.txtMbiemri1);
			this.gbZgjidh.Controls.Add(this.txtEmri1);
			this.gbZgjidh.Controls.Add(this.label2);
			this.gbZgjidh.Controls.Add(this.lblEmr);
			this.gbZgjidh.Controls.Add(this.dtpPrej);
			this.gbZgjidh.Controls.Add(this.rbData);
			this.gbZgjidh.Controls.Add(this.rbEmri);
			this.gbZgjidh.Controls.Add(this.rbDhoma);
			this.gbZgjidh.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbZgjidh.Location = new System.Drawing.Point(10, 8);
			this.gbZgjidh.Name = "gbZgjidh";
			this.gbZgjidh.Size = new System.Drawing.Size(430, 112);
			this.gbZgjidh.TabIndex = 13;
			this.gbZgjidh.Text = "Kerko rezervimet e vlefshme sipas";
			this.gbZgjidh.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbDhoma
			// 
			this.cmbDhoma.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhoma.DefaultErrorMessage = null;
			this.cmbDhoma.IsValid = false;
			this.cmbDhoma.Kolone1Vlere = null;
			this.cmbDhoma.Kolone2Vlere = null;
			this.cmbDhoma.Location = new System.Drawing.Point(88, 80);
			this.cmbDhoma.Name = "cmbDhoma";
			this.cmbDhoma.ReadOnly = false;
			this.cmbDhoma.Required = false;
			this.cmbDhoma.Size = new System.Drawing.Size(160, 21);
			this.cmbDhoma.SkipValidation = false;
			this.cmbDhoma.TabIndex = 57;
			// 
			// txtMbiemri1
			// 
			this.txtMbiemri1.AutoSize = false;
			this.txtMbiemri1.DefaultErrorMessage = "Ju duhet te jepni emrin dhe mbiemrin per kerkim!";
			this.txtMbiemri1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemri1.FixedLength = false;
			this.txtMbiemri1.IsValid = false;
			this.txtMbiemri1.Location = new System.Drawing.Point(256, 24);
			this.txtMbiemri1.Name = "txtMbiemri1";
			this.txtMbiemri1.Required = false;
			this.txtMbiemri1.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemri1.Size = new System.Drawing.Size(160, 21);
			this.txtMbiemri1.TabIndex = 9;
			this.txtMbiemri1.Text = "";
			// 
			// txtEmri1
			// 
			this.txtEmri1.AutoSize = false;
			this.txtEmri1.DefaultErrorMessage = "";
			this.txtEmri1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri1.FixedLength = false;
			this.txtEmri1.IsValid = false;
			this.txtEmri1.Location = new System.Drawing.Point(88, 24);
			this.txtEmri1.Name = "txtEmri1";
			this.txtEmri1.Required = false;
			this.txtEmri1.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri1.Size = new System.Drawing.Size(160, 21);
			this.txtEmri1.TabIndex = 8;
			this.txtEmri1.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(256, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Mbiemri";
			// 
			// lblEmr
			// 
			this.lblEmr.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lblEmr.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmr.Location = new System.Drawing.Point(88, 12);
			this.lblEmr.Name = "lblEmr";
			this.lblEmr.Size = new System.Drawing.Size(60, 16);
			this.lblEmr.TabIndex = 6;
			this.lblEmr.Text = "Emri";
			// 
			// dtpPrej
			// 
			this.dtpPrej.BackColor = System.Drawing.Color.White;
			this.dtpPrej.CustomFormat = "dd.MM.yyyy";
			this.dtpPrej.DefaultErrorMessage = "";
			this.dtpPrej.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPrej.IsValid = true;
			this.dtpPrej.Location = new System.Drawing.Point(88, 52);
			this.dtpPrej.Name = "dtpPrej";
			this.dtpPrej.Required = true;
			this.dtpPrej.ShowCheckBox = true;
			this.dtpPrej.ShowUpDown = true;
			this.dtpPrej.Size = new System.Drawing.Size(160, 20);
			this.dtpPrej.TabIndex = 0;
			this.dtpPrej.Value = new System.DateTime(2005, 8, 30, 18, 35, 0, 0);
			// 
			// rbData
			// 
			this.rbData.Location = new System.Drawing.Point(12, 52);
			this.rbData.Name = "rbData";
			this.rbData.Size = new System.Drawing.Size(68, 20);
			this.rbData.TabIndex = 56;
			this.rbData.Text = "Dates";
			// 
			// rbEmri
			// 
			this.rbEmri.Location = new System.Drawing.Point(12, 20);
			this.rbEmri.Name = "rbEmri";
			this.rbEmri.Size = new System.Drawing.Size(64, 24);
			this.rbEmri.TabIndex = 56;
			this.rbEmri.Text = "Klientit";
			// 
			// rbDhoma
			// 
			this.rbDhoma.Location = new System.Drawing.Point(12, 84);
			this.rbDhoma.Name = "rbDhoma";
			this.rbDhoma.Size = new System.Drawing.Size(60, 16);
			this.rbDhoma.TabIndex = 56;
			this.rbDhoma.Text = "Dhomes";
			// 
			// btnKerko
			// 
			this.btnKerko.BackColor = System.Drawing.Color.Blue;
			this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko.DoValidation = false;
			this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko.Location = new System.Drawing.Point(452, 56);
			this.btnKerko.Name = "btnKerko";
			this.btnKerko.Size = new System.Drawing.Size(90, 21);
			this.btnKerko.TabIndex = 57;
			this.btnKerko.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko, "Kerkon per rezervimet e vlefshme individuale\r\n qe plotesojne kriteret e caktuar!");
			this.btnKerko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
			// 
			// gbKlient
			// 
			this.gbKlient.BackColor = System.Drawing.Color.Transparent;
			this.gbKlient.Controls.Add(this.dg1);
			this.gbKlient.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbKlient.Location = new System.Drawing.Point(10, 124);
			this.gbKlient.Name = "gbKlient";
			this.gbKlient.Size = new System.Drawing.Size(710, 412);
			this.gbKlient.TabIndex = 14;
			this.gbKlient.Text = "Rezervimet e vlefshme ";
			this.gbKlient.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// dg1
			// 
			this.dg1.AllowSorting = false;
			this.dg1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dg1.CanDelete = true;
			this.dg1.CaptionVisible = false;
			this.dg1.DataMember = "";
			this.dg1.GridLineColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dg1.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.dg1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg1.HideHorizontalScrollBar = false;
			this.dg1.HideVerticalScrollBar = false;
			this.dg1.Location = new System.Drawing.Point(12, 20);
			this.dg1.Name = "dg1";
			this.dg1.RowHeaderWidth = 20;
			this.dg1.Selekto = false;
			this.dg1.Size = new System.Drawing.Size(684, 380);
			this.dg1.TabIndex = 15;
			// 
			// ds
			// 
			this.ds.DataSetName = "NewDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tbKlient);
			this.tabControl1.Controls.Add(this.tbGrup);
			this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabControl1.Location = new System.Drawing.Point(0, 25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1015, 610);
			this.tabControl1.TabIndex = 15;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tbKlient
			// 
			this.tbKlient.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbKlient.Controls.Add(this.gbZgjidh);
			this.tbKlient.Controls.Add(this.gbKlient);
			this.tbKlient.Controls.Add(this.btnKerko);
			this.tbKlient.DefaultErrorMessage = null;
			this.tbKlient.EnableValidation = true;
			this.tbKlient.IsValid = false;
			this.tbKlient.Location = new System.Drawing.Point(4, 22);
			this.tbKlient.Name = "tbKlient";
			this.tbKlient.Size = new System.Drawing.Size(1007, 584);
			this.tbKlient.TabIndex = 0;
			this.tbKlient.Text = "Individuale";
			// 
			// tbGrup
			// 
			this.tbGrup.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbGrup.Controls.Add(this.gbGrup);
			this.tbGrup.Controls.Add(this.btnKerkoGrup);
			this.tbGrup.Controls.Add(this.groupBox1);
			this.tbGrup.DefaultErrorMessage = null;
			this.tbGrup.EnableValidation = true;
			this.tbGrup.IsValid = false;
			this.tbGrup.Location = new System.Drawing.Point(4, 22);
			this.tbGrup.Name = "tbGrup";
			this.tbGrup.Size = new System.Drawing.Size(1007, 584);
			this.tbGrup.TabIndex = 1;
			this.tbGrup.Text = "Ne grup";
			// 
			// gbGrup
			// 
			this.gbGrup.BackColor = System.Drawing.Color.Transparent;
			this.gbGrup.Controls.Add(this.dg2);
			this.gbGrup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbGrup.Location = new System.Drawing.Point(10, 116);
			this.gbGrup.Name = "gbGrup";
			this.gbGrup.Size = new System.Drawing.Size(786, 416);
			this.gbGrup.TabIndex = 2;
			this.gbGrup.Text = "Rezervimet e vlefshme ne grup";
			this.gbGrup.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// dg2
			// 
			this.dg2.AllowSorting = false;
			this.dg2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dg2.CanDelete = true;
			this.dg2.CaptionVisible = false;
			this.dg2.DataMember = "";
			this.dg2.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.dg2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg2.HideHorizontalScrollBar = false;
			this.dg2.HideVerticalScrollBar = false;
			this.dg2.Location = new System.Drawing.Point(12, 20);
			this.dg2.Name = "dg2";
			this.dg2.RowHeaderWidth = 20;
			this.dg2.Selekto = false;
			this.dg2.Size = new System.Drawing.Size(764, 384);
			this.dg2.TabIndex = 0;
			// 
			// btnKerkoGrup
			// 
			this.btnKerkoGrup.BackColor = System.Drawing.Color.Blue;
			this.btnKerkoGrup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerkoGrup.DoValidation = true;
			this.btnKerkoGrup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerkoGrup.Location = new System.Drawing.Point(452, 52);
			this.btnKerkoGrup.Name = "btnKerkoGrup";
			this.btnKerkoGrup.Size = new System.Drawing.Size(90, 21);
			this.btnKerkoGrup.TabIndex = 1;
			this.btnKerkoGrup.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerkoGrup, "Kerkon per rezervimet e vlefshme ne grup\r\n qe plotesojne kriteret e caktuar!");
			this.btnKerkoGrup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerkoGrup.Click += new System.EventHandler(this.btnKerkoGrup_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.cmbGrupetKerkim);
			this.groupBox1.Controls.Add(this.cmbDhomaGrup);
			this.groupBox1.Controls.Add(this.dtpPrejGrupi);
			this.groupBox1.Controls.Add(this.rbDhomaGrupi);
			this.groupBox1.Controls.Add(this.rbDataGrupi);
			this.groupBox1.Controls.Add(this.rbGrupi);
			this.groupBox1.Controls.Add(this.txtAgjensiaKerkim);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(10, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(430, 104);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.Text = "Kerkim sipas";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbGrupetKerkim
			// 
			this.cmbGrupetKerkim.BackColor = System.Drawing.Color.Transparent;
			this.cmbGrupetKerkim.DefaultErrorMessage = null;
			this.cmbGrupetKerkim.IsValid = false;
			this.cmbGrupetKerkim.Kolone1Vlere = null;
			this.cmbGrupetKerkim.Kolone2Vlere = null;
			this.cmbGrupetKerkim.Location = new System.Drawing.Point(88, 24);
			this.cmbGrupetKerkim.Name = "cmbGrupetKerkim";
			this.cmbGrupetKerkim.ReadOnly = false;
			this.cmbGrupetKerkim.Required = false;
			this.cmbGrupetKerkim.Size = new System.Drawing.Size(160, 21);
			this.cmbGrupetKerkim.SkipValidation = false;
			this.cmbGrupetKerkim.TabIndex = 25;
			this.cmbGrupetKerkim.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbGrupetKerkim_SelectedIndexChanged);
			// 
			// cmbDhomaGrup
			// 
			this.cmbDhomaGrup.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhomaGrup.DefaultErrorMessage = null;
			this.cmbDhomaGrup.IsValid = true;
			this.cmbDhomaGrup.Kolone1Vlere = null;
			this.cmbDhomaGrup.Kolone2Vlere = null;
			this.cmbDhomaGrup.Location = new System.Drawing.Point(88, 72);
			this.cmbDhomaGrup.Name = "cmbDhomaGrup";
			this.cmbDhomaGrup.ReadOnly = false;
			this.cmbDhomaGrup.Required = false;
			this.cmbDhomaGrup.Size = new System.Drawing.Size(160, 21);
			this.cmbDhomaGrup.SkipValidation = false;
			this.cmbDhomaGrup.TabIndex = 24;
			// 
			// dtpPrejGrupi
			// 
			this.dtpPrejGrupi.CustomFormat = "dd.MM.yyyy";
			this.dtpPrejGrupi.DefaultErrorMessage = "";
			this.dtpPrejGrupi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPrejGrupi.IsValid = true;
			this.dtpPrejGrupi.Location = new System.Drawing.Point(88, 48);
			this.dtpPrejGrupi.Name = "dtpPrejGrupi";
			this.dtpPrejGrupi.Required = false;
			this.dtpPrejGrupi.ShowCheckBox = true;
			this.dtpPrejGrupi.ShowUpDown = true;
			this.dtpPrejGrupi.Size = new System.Drawing.Size(160, 20);
			this.dtpPrejGrupi.TabIndex = 22;
			this.dtpPrejGrupi.Value = new System.DateTime(2005, 9, 26, 13, 41, 0, 0);
			// 
			// rbDhomaGrupi
			// 
			this.rbDhomaGrupi.Location = new System.Drawing.Point(12, 72);
			this.rbDhomaGrupi.Name = "rbDhomaGrupi";
			this.rbDhomaGrupi.Size = new System.Drawing.Size(68, 24);
			this.rbDhomaGrupi.TabIndex = 21;
			this.rbDhomaGrupi.Text = "Dhomes";
			// 
			// rbDataGrupi
			// 
			this.rbDataGrupi.Location = new System.Drawing.Point(12, 48);
			this.rbDataGrupi.Name = "rbDataGrupi";
			this.rbDataGrupi.Size = new System.Drawing.Size(68, 24);
			this.rbDataGrupi.TabIndex = 20;
			this.rbDataGrupi.Text = "Dates";
			// 
			// rbGrupi
			// 
			this.rbGrupi.Location = new System.Drawing.Point(12, 24);
			this.rbGrupi.Name = "rbGrupi";
			this.rbGrupi.Size = new System.Drawing.Size(68, 24);
			this.rbGrupi.TabIndex = 19;
			this.rbGrupi.Text = "Grupit";
			// 
			// txtAgjensiaKerkim
			// 
			this.txtAgjensiaKerkim.AutoSize = false;
			this.txtAgjensiaKerkim.DefaultErrorMessage = "Ju duhet te jepni grupin dhe agjensine per kerkim!";
			this.txtAgjensiaKerkim.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAgjensiaKerkim.FixedLength = false;
			this.txtAgjensiaKerkim.IsValid = false;
			this.txtAgjensiaKerkim.Location = new System.Drawing.Point(256, 24);
			this.txtAgjensiaKerkim.Name = "txtAgjensiaKerkim";
			this.txtAgjensiaKerkim.Required = false;
			this.txtAgjensiaKerkim.RequiredControlColor = System.Drawing.Color.White;
			this.txtAgjensiaKerkim.Size = new System.Drawing.Size(160, 21);
			this.txtAgjensiaKerkim.TabIndex = 18;
			this.txtAgjensiaKerkim.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(260, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 17;
			this.label1.Text = "Agjensia";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(92, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 16;
			this.label5.Text = "Grupi";
			// 
			// RezervimeVlefshme
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(895, 555);
			this.Controls.Add(this.tabControl1);
			this.HelpFile = "REZERVIME TE VLEFSHME.htm";
			this.Name = "RezervimeVlefshme";
			this.Text = "RezervimeVlefshme";
			this.TitullGjeresi = 1015;
			this.Load += new System.EventHandler(this.RezervimeVlefshme_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.tabControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.gbZgjidh)).EndInit();
			this.gbZgjidh.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbKlient)).EndInit();
			this.gbKlient.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tbKlient.ResumeLayout(false);
			this.tbGrup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbGrup)).EndInit();
			this.gbGrup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void RezervimeVlefshme_Load(object sender, System.EventArgs e)
		{
			this.clicked = false;
			this.ds.Tables.Clear();
			this.readyToPrint = true;
			this.Cursor = Cursors.WaitCursor;
			this.rbData.Checked = false;
			this.rbDhoma.Checked = false;
			this.rbEmri.Checked = false;
			try
			{
				if (this.tabControl1.SelectedIndex == 0)
				{
					this.mbushDhomat();
					this.mbushGrupet();
					this.dtpPrej.Value = DateTime.Now.Date;
					this.dtpPrejGrupi.Value = DateTime.Now.Date;
					InputController data = new InputController();
					ds = data.KerkesaRead("ShfaqRezervimeVlefshmeKlienti");
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.ReadyToPrint = false;
						this.dg1.DataSource = null;
						DialogResult result = System.Windows.Forms.MessageBox.Show("Per momentin nuk ka rezervime te vlefshme!", "Rezervimet e vlefshme", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					this.dg1.DataSource = ds.Tables["KLIENTI"];
					KrijoStilgride1();
					this.ReadyToPrint = true;
					// Ky cikel sherben per te zevendesuar te gjitha fushat null me "-", per hedhjen ne XML
					foreach (DataRow dr in ds.Tables[1].Rows)
					{
						for (int i = 0; i < ds.Tables[1].Columns.Count - 5 ; i ++)
						{
							string dataString1 = "";
							string dataString2 = "";
							if (ds.Tables[1].Columns[i].ColumnName == "DATA_HYRJE_STR" || ds.Tables[1].Columns[i].ColumnName == "DATA_DALJE_STR")
							{
								dataString1 = dr[i].ToString();
								int j = 0;
								while (j <= dataString1.Length - 10)
								{
									dataString2 += dataString1.Substring(j, 10);
									j+= 24;
									if (j < dataString1.Length - 10)
										dataString2 += Environment.NewLine;
								}
								dr[i] = dataString2;
							}
							if (Convert.IsDBNull(dr[i]))
							{
								if (ds.Tables[1].Columns[i].DataType == typeof(String))
								{
									dr[i] = "-";
								}
								else if (ds.Tables[1].Columns[i].DataType == typeof(Int32))
								{
									dr[i] = 0;
								}
							}
						}
					}	
					//Hidh datasetin ne Xml
					ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\RezervimeVlefshme.xml");
				}
				else
				{
					this.mbushGrupet();
					this.mbushDhomat();
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
		
		private void btnKerko_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				InputController data = new InputController();
				string koment;
				if (this.rbData.Checked == true)
				{
					DateTime dateKerkimi = Convert.ToDateTime(this.dtpPrej.Value);
					
					ds = data.KerkesaRead("ShfaqRezervimeVlefshmeKlientiPerDatenEdhene",dateKerkimi);
					koment = "Rezervimet individuale ne hotel pas dates "+this.konvertoshkurt(dateKerkimi);
					this.gbKlient.Text = koment;
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.ReadyToPrint = false;
						this.dg1.DataSource = null;
						DialogResult result = System.Windows.Forms.MessageBox.Show(this,  "Per daten e zgjedhur nuk ka asnje rezervim te vlefshem!", "Rezervimet e vlefshme", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					this.ReadyToPrint = true;
					// Ky cikel sherben per te zevendesuar te gjitha fushat null me "-", per hedhjen ne XML
					foreach (DataRow dr in ds.Tables[1].Rows)
					{
						for (int i = 0; i < ds.Tables[1].Columns.Count - 5; i ++)
						{
							string dataString1 = "";
							string dataString2 = "";
							if (ds.Tables[1].Columns[i].ColumnName == "DATA_HYRJE_STR" || ds.Tables[1].Columns[i].ColumnName == "DATA_DALJE_STR")
							{
								dataString1 = dr[i].ToString();
								int j = 0;
								while (j <= dataString1.Length - 10)
								{
									dataString2 += dataString1.Substring(j, 10);
									j+= 24;
									if (j < dataString1.Length - 10)
										dataString2 += Environment.NewLine;
								}
								dr[i] = dataString2;
							}
							if (Convert.IsDBNull(dr[i]))
							{
								if (ds.Tables[1].Columns[i].DataType == typeof(String))
								{
									dr[i] = "-";
								}
								else if (ds.Tables[1].Columns[i].DataType == typeof(Int32))
								{
									dr[i] = 0;
								}
							}
						}
					}
					this.dg1.DataSource = ds.Tables["KLIENTI"];
					this.KrijoStilgride1();
					//Hidh datasetin ne Xml
					ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\RezervimeVlefshme.xml");
				}
				else if (this.rbEmri.Checked == true)
				{
					string emri = this.txtEmri1.Text;
					string mbiemri = this.txtMbiemri1.Text;
					ds = data.KerkesaRead("ShfaqRezervimeVlefshemPerEmerMbiemer",emri,mbiemri);
					
					koment = "Rezervimet individuale per klientet me emer " + emri + " " + mbiemri;
					this.gbKlient.Text = koment;
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.dg1.DataSource = null;
						DialogResult result = System.Windows.Forms.MessageBox.Show(this,  "Per kete emer nuk ka asnje rezervim te vlefshem!", "Rezervimet e vlefshme",MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					this.dg1.DataSource = ds.Tables["KLIENTI"];
					//mbush griden per kete rast
					//					this.KrijoStilGride();
					// Bej ndryshimet perkatese te propertise ReadyToPrint
					if (ds.Tables[1].Rows.Count < 1)
					{
						this.ReadyToPrint = false;
					}
					else
					{
						this.ReadyToPrint = true;
						// Ky cikel sherben per te zevendesuar te gjitha fushat null me "-", per hedhjen ne XML
						// Gjithashtu edhe per formatimin e datave ne menyre qe te mos paraqitet ora
						foreach (DataRow dr in ds.Tables[1].Rows)
						{
							for (int i = 0; i < ds.Tables[1].Columns.Count - 5; i ++)
							{
								string dataString1 = "";
								string dataString2 = "";
								if (ds.Tables[1].Columns[i].ColumnName == "DATA_HYRJE_STR" || ds.Tables[1].Columns[i].ColumnName == "DATA_DALJE_STR")
								{
									dataString1 = dr[i].ToString();
									int j = 0;
									while (j <= dataString1.Length - 10)
									{
										dataString2 += dataString1.Substring(j, 10);
										j+= 24;
										if (j < dataString1.Length - 10)
											dataString2 += Environment.NewLine;
									}
									dr[i] = dataString2;
								}
								if (Convert.IsDBNull(dr[i]))
								{
									if (ds.Tables[1].Columns[i].DataType == typeof(String))
									{
										dr[i] = "-";
									}
									else if (ds.Tables[1].Columns[i].DataType == typeof(Int32))
									{
										dr[i] = 0;
									}
								}
							}
						}	
						//Hidh datasetin ne Xml
						ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\RezervimeVlefshme.xml");
					}
					this.KrijoStilgride1();
				}
				else if (this.rbDhoma.Checked == true)
				{
					if (this.cmbDhoma.Kolone1.Text.ToString() == "")
					{
						this.error.SetError(cmbDhoma, "Zgjidhni nje prej dhomave para se te kerkoni!");
						this.dg1.DataSource = null;
						return;
					}
					int id_dhoma  = Convert.ToInt32(this.cmbDhoma.Kolone2Vlere);
					koment = "Rezervimet e vlefshme per dhomen " + this.cmbDhoma.Kolone1Vlere;
					this.gbKlient.Text = koment;
					DataSet ds = data.KerkesaRead("ShfaqRezervimeVlefshmePerDhomen", id_dhoma);
					
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.dg1.DataSource = null;
						DialogResult result = System.Windows.Forms.MessageBox.Show(this,  "Per dhomen e zgjedhur nuk ka asnje rezervim te vlefshem!", "Rezervimet e vlefshme",MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					this.dg1.DataSource = ds.Tables["KLIENTI"];
					//mbush griden per kete rast
					//					this.KrijoStilGride();
					// Bej ndryshimet perkatese te propertise ReadyToPrint
					if (ds.Tables[0].Rows.Count < 1)
					{
						this.ReadyToPrint = false;
					}
					else
					{
						this.ReadyToPrint = true;
						// Ky cikel sherben per te zevendesuar te gjitha fushat null me "-", per hedhjen ne XML
						foreach (DataRow dr in ds.Tables[0].Rows)
						{
							for (int i = 0; i < ds.Tables[1].Columns.Count - 5; i ++)
							{
								string dataString1 = "";
								string dataString2 = "";
								if (ds.Tables[1].Columns[i].ColumnName == "DATA_HYRJE_STR" || ds.Tables[1].Columns[i].ColumnName == "DATA_DALJE_STR")
								{
									dataString1 = dr[i].ToString();
									int j = 0;
									while (j <= dataString1.Length - 10)
									{
										dataString2 += dataString1.Substring(j, 10);
										j+= 24;
										if (j < dataString1.Length - 10)
											dataString2 += Environment.NewLine;
									}
									dr[i] = dataString2;
								}
								if (Convert.IsDBNull(dr[i]))
								{
									if (ds.Tables[1].Columns[i].DataType == typeof(String))
									{
										dr[i] = "-";
									}
									else if (ds.Tables[1].Columns[i].DataType == typeof(System.Int32))
									{
										dr[i] = 0;
									}
								}
							}
						}	
						//Hidh datasetin ne Xml
						ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\RezervimeVlefshme.xml");
						this.KrijoStilgride3();
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
		private void btnKerkoGrup_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			string koment;
			try
			{
				InputController data = new InputController();
				if (this.rbDataGrupi.Checked == true)
				{
					DateTime dateFillimi = Convert.ToDateTime(this.dtpPrejGrupi.Value);
					koment = "Rezervimet e vlefshme te kryera nga grupet ne daten " + this.konvertoshkurt(dateFillimi);
					this.gbGrup.Text = koment;
					DataSet ds = data.KerkesaRead("ShfaqRezervimeVlefshmeGrupiPerDaten", dateFillimi);
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.dg2.DataSource = null;
						DialogResult result = System.Windows.Forms.MessageBox.Show(this,  "Per daten e zgjedhur nuk ka rezervim te vlefshem!", "Rezervimet e vlefshme",MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					this.dg2.DataSource = ds.Tables["KLIENTI"];
					//mbush griden per kete rast
					// Bej ndryshimet perkatese te propertise ReadyToPrint
					if (ds.Tables[1].Rows.Count < 1)
					{
						this.ReadyToPrint = false;
					}
					else
					{
						this.ReadyToPrint = true;
						// Ky cikel sherben per te zevendesuar te gjitha fushat null me "-", per hedhjen ne XML
						foreach (DataRow dr in ds.Tables[1].Rows)
						{
							for (int i = 0; i < ds.Tables[1].Columns.Count - 5; i ++)
							{
								string dataString1 = "";
								string dataString2 = "";
								if (ds.Tables[1].Columns[i].ColumnName == "DATA_HYRJE_STR" || ds.Tables[1].Columns[i].ColumnName == "DATA_DALJE_STR")
								{
									dataString1 = dr[i].ToString();
									int j = 0;
									while (j <= dataString1.Length - 10)
									{
										dataString2 += dataString1.Substring(j, 10);
										j+= 24;
										if (j < dataString1.Length - 10)
											dataString2 += Environment.NewLine;
									}
									dr[i] = dataString2;
								}
								if (Convert.IsDBNull(dr[i]))
								{
									if (ds.Tables[1].Columns[i].DataType == typeof(String))
									{
										dr[i] = "-";
									}
									else if (ds.Tables[1].Columns[i].DataType == typeof(Int32))
									{
										dr[i] = 0;
									}
								}
							}			
						}
					}
					this.KrijoStilgride2();
					//Hidh datasetin ne Xml
					ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\HyrjeNeHotelGrup.xml");
				}
				else if (this.rbGrupi.Checked == true)
				{
					if (this.cmbGrupetKerkim.Kolone1.Text == "")
					{
						this.error.SetError(cmbGrupetKerkim, "Zgjidhni nje prej grupeve para se te kerkoni");
						this.dg2.DataSource = null;
						return;
					}
					int id_grupi = Convert.ToInt32(this.cmbGrupetKerkim.Kolone2Vlere.ToString());
					DataSet ds = data.KerkesaRead("ShfaqRezervimeVlefshmePerGrupAgjensi", id_grupi);
					koment = "Rezervimet e vlefshme per grupin " + this.cmbGrupetKerkim.Kolone1.Text;
					this.gbGrup.Text = koment;
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.ReadyToPrint = false;
						this.dg2.DataSource = null;
						DialogResult result = System.Windows.Forms.MessageBox.Show(this,  "Per kete grup nuk ka asnje rezervim te vleshem!", "Rezervimet e vlefshme",MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					this.dg2.DataSource = ds.Tables["KLIENTI"];
					// Bej ndryshimet perkatese te propertise ReadyToPrint
					this.ReadyToPrint = true;
					// Ky cikel sherben per te zevendesuar te gjitha fushat null me "-", per hedhjen ne XML
					foreach (DataRow dr in ds.Tables[1].Rows)
					{
						for (int i = 0; i < ds.Tables[1].Columns.Count - 5; i ++)
						{
							string dataString1 = "";
							string dataString2 = "";
							if (ds.Tables[1].Columns[i].ColumnName == "DATA_HYRJE_STR" || ds.Tables[1].Columns[i].ColumnName == "DATA_DALJE_STR")
							{
								dataString1 = dr[i].ToString();
								int j = 0;
								while (j <= dataString1.Length - 10)
								{
									dataString2 += dataString1.Substring(j, 10);
									j+= 24;
									if (j < dataString1.Length - 10)
										dataString2 += Environment.NewLine;
								}
								dr[i] = dataString2;
							}
							if (Convert.IsDBNull(dr[i]))
							{
								if (ds.Tables[1].Columns[i].DataType == typeof(String))
								{
									dr[i] = "-";
								}
								else if (ds.Tables[1].Columns[i].DataType == typeof(Int32))
								{
									dr[i] = 0;
								}
							}
						}
					}	
					//Hidh datasetin ne Xml
					this.WriteToXml(ds, false);
					//ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\RezervimeVlefshmePerAgjensi.xml");
					this.KrijoStilgride2();
				}
				else if (this.rbDhomaGrupi.Checked == true)
				{
					if (this.cmbDhomaGrup.Kolone1.Text == "")
					{
						this.error.SetError(cmbDhomaGrup, "Zgjidhni nje prej dhomave para se te kerkoni");
						this.dg2.DataSource = null;
						return;
					}
					int id_dhoma  = Convert.ToInt32(this.cmbDhomaGrup.Kolone2Vlere.ToString());
					DataSet ds = data.KerkesaRead("ShfaqRezervimeVlefshmeGrupiPerDhomen", id_dhoma);
					koment = "Rezervimet e vlefshme ne grup per dhomen " + this.cmbDhomaGrup.Kolone1.Text;
					this.gbGrup.Text = koment;
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.ReadyToPrint = false;
						this.dg2.DataSource = null;
						DialogResult result = System.Windows.Forms.MessageBox.Show(this,  "Per dhomen e zgjedhur nuk ka asnje rezervim te vlefshem ne grup!", "Rezervimet e vlefshme",MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					this.dg2.DataSource = ds.Tables["KLIENTI"];
					// Bej ndryshimet perkatese te propertise ReadyToPrint
					this.ReadyToPrint = true;
					// Ky cikel sherben per te zevendesuar te gjitha fushat null me "-", per hedhjen ne XML
					foreach (DataRow dr in ds.Tables[0].Rows)
					{
						for (int i = 0; i < ds.Tables[1].Columns.Count - 5; i ++)
						{
							string dataString1 = "";
							string dataString2 = "";
							if (ds.Tables[1].Columns[i].ColumnName == "DATA_HYRJE_STR" || ds.Tables[1].Columns[i].ColumnName == "DATA_DALJE_STR")
							{
								dataString1 = dr[i].ToString();
								int j = 0;
								while (j <= dataString1.Length - 10)
								{
									dataString2 += dataString1.Substring(j, 10);
									j+= 24;
									if (j < dataString1.Length - 10)
										dataString2 += Environment.NewLine;
								}
								dr[i] = dataString2;
							}
							if (Convert.IsDBNull(dr[i]))
							{
								if (ds.Tables[1].Columns[i].DataType == typeof(String))
								{
									dr[i] = "-";
								}
								else if (ds.Tables[1].Columns[i].DataType == typeof(Int32))
								{
									dr[i] = 0;
								}
							}
						}
					}	
					//Hidh datasetin ne Xml
					this.WriteToXml(ds, false);
					//ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\RezervimeVlefshmePerAgjensi.xml");
					this.KrijoStilgride2();
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

		private void cmbGrupetKerkim_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				int idGrupi = Convert.ToInt32(this.cmbGrupetKerkim.Kolone2Vlere);
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
		
		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			 {
				this.Pastro(this.gbZgjidh);
				this.Pastro(this.groupBox1);
				if (this.clicked == false)
				{
					this.clicked = true;
					if (Convert.ToInt32(this.tabControl1.SelectedIndex) == 1)
					{
						this.rbGrupi.Checked = false;
						this.rbDhomaGrupi.Checked = false;
						this.rbDataGrupi.Checked = false;
						InputController data = new InputController();
						ds = data.KerkesaRead("ShfaqRezervimeVlefshmeGrupi");
						if (ds.Tables[0].Rows.Count == 0)
						{
							this.ReadyToPrint = false;
							this.dg2.DataSource = null;
							DialogResult result = System.Windows.Forms.MessageBox.Show("Per momentin nuk ka asnje rezervim te vlefshem ne grup!", "Rezervimet e vlefshme", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						this.dg2.DataSource = ds.Tables["KLIENTI"];
						KrijoStilgride2();
						if (ds.Tables[0].Rows.Count < 1)
						{
							this.ReadyToPrint = false;
						}
						else
						{
							this.ReadyToPrint = true;
							// Ky cikel sherben per te zevendesuar te gjitha fushat null me "-", per hedhjen ne XML
							foreach (DataRow dr in ds.Tables[1].Rows)
							{
								for (int i = 0; i < ds.Tables[1].Columns.Count - 5 ; i ++)
								{
									string dataString1 = "";
									string dataString2 = "";
									if (ds.Tables[1].Columns[i].ColumnName == "DATA_HYRJE_STR" || ds.Tables[1].Columns[i].ColumnName == "DATA_DALJE_STR")
									{
										dataString1 = dr[i].ToString();
										int j = 0;
										while (j <= dataString1.Length - 10)
										{
											dataString2 += dataString1.Substring(j, 10);
											j+= 24;
											if (j < dataString1.Length - 10)
												dataString2 += Environment.NewLine;
										}
										dr[i] = dataString2;
									}
									if (Convert.IsDBNull(dr[i]))
									{
										if (ds.Tables[1].Columns[i].DataType == typeof(String))
										{
											dr[i] = "-";
										}
										else if (ds.Tables[1].Columns[i].DataType == typeof(Int32))
										{
											dr[i] = 0;
										}
									}
								}
							}	
							//Hidh datasetin ne Xml
							this.WriteToXml(ds, false);
							//ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\RezervimeVlefshmePerAgjensi.xml");
						}
					}
					else
					{
						this.RezervimeVlefshme_Load(sender, e);
					}
				}
				else
				{
					if (this.tabControl1.SelectedIndex == 0)
					{
						this.RezervimeVlefshme_Load(sender, e);
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

		#endregion

		#region Private Methods

		private void KrijoStilgride1()
		{
			try
			{
				this.dg1.TableStyles.Clear();
				DataGridTableStyle style = new DataGridTableStyle();
				style.MappingName = "KLIENTI";
				style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
				style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
				this.dg1.ReadOnly = true;

				DataGridTekstBoxColumn dhomaEmri = new DataGridTekstBoxColumn();
				dhomaEmri.HeaderText = "Dhoma";
				dhomaEmri.MappingName = "DHOMA_EMRI";
				dhomaEmri.Width = 60;

				DataGridTekstBoxColumn kapari = new DataGridTekstBoxColumn();
				kapari.HeaderText = "Kapari";
				kapari.MappingName = "KAPARI_STR";
				kapari.NullText = "0";
				kapari.Width = 50;

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

				DataGridTekstBoxColumn colDateRezervimi = new DataGridTekstBoxColumn();
				colDateRezervimi .HeaderText = "Data kur eshte kryer Rezervimi";
				colDateRezervimi .MappingName = "DATA_REZERVIMI_STR";
				colDateRezervimi .Width = 160;
				colDateRezervimi .NullText = "";
				style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{   emri,  dhomaEmri, kapari,
																			 colDateFillimi1,
																			 colDateMbarimi1,colDateRezervimi});
				this.dg1.TableStyles.Add(style);
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
		private void KrijoStilgride3()
		{
			try
			{
				this.dg1.TableStyles.Clear();
				DataGridTableStyle style = new DataGridTableStyle();
				style.MappingName = "KLIENTI";
				style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
				style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
				this.dg1.ReadOnly = true;

				DataGridTekstBoxColumn dhomaEmri = new DataGridTekstBoxColumn();
				dhomaEmri.HeaderText = "Dhoma";
				dhomaEmri.MappingName = "DHOMA_EMRI";
				dhomaEmri.Width = 60;

				DataGridTekstBoxColumn kapari = new DataGridTekstBoxColumn();
				kapari.HeaderText = "Kapari";
				kapari.MappingName = "KAPARI_STR";
				kapari.NullText = "0";
				kapari.Width = 50;

				DataGridTekstBoxColumn emri = new DataGridTekstBoxColumn();
				emri.HeaderText = "Klienti";
				emri.MappingName = "EMRI_STR";
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

				DataGridTekstBoxColumn colDateRezervimi = new DataGridTekstBoxColumn();
				colDateRezervimi .HeaderText = "Data kur eshte kryer Rezervimi";
				colDateRezervimi .MappingName = "DATA_REZERVIMI_STR";
				colDateRezervimi .Width = 160;
				colDateRezervimi .NullText = "";
				style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{     dhomaEmri, emri,kapari,
																			 colDateFillimi1,
																			 colDateMbarimi1,colDateRezervimi});
				this.dg1.TableStyles.Add(style);
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
		private void KrijoStilgride2()
		{
			this.dg2.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "KLIENTI";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			this.dg2.ReadOnly = true;

			DataGridTekstBoxColumn dhomaEmri = new DataGridTekstBoxColumn();
			dhomaEmri.HeaderText = "Dhoma";
			dhomaEmri.MappingName = "DHOMA_EMRI";
			dhomaEmri.Width = 60;

			DataGridTekstBoxColumn kapari = new DataGridTekstBoxColumn();
			kapari.HeaderText = "Kapari";
			kapari.MappingName = "KAPARI_STR";
			kapari.NullText = "0";
			kapari.Width = 50;

			DataGridTekstBoxColumn grupi = new DataGridTekstBoxColumn();
			grupi.HeaderText = "Grupi";
			grupi.MappingName = "GRUPI";
			grupi.Width = 95;

			DataGridTekstBoxColumn agjensia = new DataGridTekstBoxColumn();
			agjensia.HeaderText = "Agjensia";
			agjensia.MappingName = "AGJENSIA";
			agjensia.Width = 95;

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

			DataGridTekstBoxColumn colDateRezervimi = new DataGridTekstBoxColumn();
			colDateRezervimi .HeaderText = "Data kur eshte kryer Rezervimi";
			colDateRezervimi .MappingName = "DATA_REZERVIMI_STR";
			colDateRezervimi .Width = 160;
			colDateRezervimi .NullText = "";

			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{grupi, agjensia,   dhomaEmri, kapari,colDateFillimi1,
																		 colDateMbarimi1,colDateRezervimi});
			this.dg2.TableStyles.Add(style);
		}

		private void mbushDhomat()
		{
			this.cmbDhoma.Kolone1.Items.Clear();
			this.cmbDhoma.Kolone2.Items.Clear();
			this.cmbDhomaGrup.Kolone1.Items.Clear();
			this.cmbDhomaGrup.Kolone2.Items.Clear();
			DataSet ds = null ;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqDhomat");
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbDhoma.Kolone1.Items.Add(dr[1]);
				this.cmbDhoma.Kolone2.Items.Add(dr[0]);
				this.cmbDhomaGrup.Kolone1.Items.Add(dr[1]);
				this.cmbDhomaGrup.Kolone2.Items.Add(dr[0]);
			}
		}
		
		private void mbushGrupet()
		{
			this.cmbGrupetKerkim.Kolone1.Items.Clear();
			this.cmbGrupetKerkim.Kolone2.Items.Clear();
			InputController data = new InputController();
			DataSet ds = null;
			ds = data.KerkesaRead("ShfaqGrupet");
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbGrupetKerkim.Kolone1.Items.Add(dr[1]);
				this.cmbGrupetKerkim.Kolone2.Items.Add(dr[0]);
			}
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
		/// Hedh ne xml DataSetin duke bere ndryshimet e duhura per datat e hyrjes dhe te daljes,
		/// per paraqitjet ne raportet
		/// </summary>
		/// <param name="dsArg"></param>
		private void WriteToXml(DataSet dsArg, bool grup)
		{
			DataSet ds1 = dsArg.Copy();  
			foreach (DataRow dr in ds1.Tables["KLIENTI"].Rows)
			{
				// Bejme formatimin e dates se hyrjes per paraqitjet ne raport
				dr["DATA_HYRJE_STR"] = dr["DATA_HYRJE_STR"].ToString().Substring(0, 10);
				// Bejme formatimin e dates se daljes per paraqitjet ne raport
				dr["DATA_DALJE_STR"] = dr["DATA_DALJE_STR"].ToString().Substring(0, 10);
				// Bejme formatimin e dates se rezervimit per paraqitjet ne raport
				dr["DATA_REZERVIMI_STR"] = dr["DATA_REZERVIMI_STR"].ToString().Substring(0, 10);
				// Shtojme aq lines te reja ne kolonat e grupit dhe agjensise, sa dhoma ka per cdo rresht
				// te datasetit
				int nrDhomash = dr["DHOMA_EMRI"].ToString().Replace("\r\n", "&").Split('&').Length;
			}
			//Hidh datasetin ne Xml
			if (grup)
				ds1.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\HyrjeNeHotelGrup.xml", XmlWriteMode.WriteSchema);
			else
				ds1.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\RezervimeVlefshmePerAgjensi.xml", XmlWriteMode.WriteSchema);
		}


		#endregion
		
		#region IPrintable Members
		public void PrintPreview()
		{
			Printim print = new Printim();
			if (tabControl1.SelectedTab == tbKlient)
				print.NgarkoRaport("RezervimeVlefshmePerEmerMbiemer");
			else if (tabControl1.SelectedTab == tbGrup)
				print.NgarkoRaport("RezervimeVlefshmePerAgjensi");
			print.ShowDialog();
		}

		public bool ReadyToPrint
		{
			get
			{
				return this.readyToPrint;
			}
			set
			{
				bool oldValue = readyToPrint;
				readyToPrint = value;
				if(ReadyToPrintChanged != null && value != oldValue)
					ReadyToPrintChanged(this, new ReadyChangedEventArgs());
			}
		}

		public void Print()
		{
			Printim print = new Printim();
			if (tabControl1.SelectedTab == tbKlient)
				print.Printo("RezervimeVlefshmePerEmerMbiemer");
			else if (tabControl1.SelectedTab == tbGrup)
				print.Printo("RezervimeVlefshmePerAgjensi");
		}

		private void lblStatus_Click(object sender, System.EventArgs e)
		{
		
		}

		public event VisionInfoSolutionLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

		#endregion

	}
}

