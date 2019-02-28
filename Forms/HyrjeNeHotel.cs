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
	public class HyrjeNeHotel : VisionInfoSolutionLibrary.Form, IPrintable
	{
		#region Private Variables
		private VisionInfoSolutionLibrary.GroupBox gbZgjidh;
		private VisionInfoSolutionLibrary.TextBox txtMbiemri1;
		private VisionInfoSolutionLibrary.TextBox txtEmri1;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.Label lblEmr;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDeri;
		private VisionInfoSolutionLibrary.DateTimePicker dtpPrej;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.Button btnKerko;
		private VisionInfoSolutionLibrary.DataGrid dg1;
		private VisionInfoSolutionLibrary.TabControl tabControl1;
		private VisionInfoSolutionLibrary.TabPageControl tbKlient;
		private VisionInfoSolutionLibrary.TabPageControl tbGrup;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhoma;
		private VisionInfoSolutionLibrary.Button btnKerkoGrup;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhomaGrup;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDeriGrupi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpPrejGrupi;
		private VisionInfoSolutionLibrary.DoubleCombo cmbGrupetKerkim;
		private VisionInfoSolutionLibrary.TextBox txtAgjensiaKerkim;
		private VisionInfoSolutionLibrary.GroupBox gbKlient;
		private VisionInfoSolutionLibrary.GroupBox gbGrup;
		private VisionInfoSolutionLibrary.DataGrid dg2;
		private System.Windows.Forms.Label label3;
		private VisionInfoSolutionLibrary.CheckBox cbKlienti;
		private VisionInfoSolutionLibrary.CheckBox cbDhoma;
		private System.Windows.Forms.Label label4;
		private VisionInfoSolutionLibrary.CheckBox cbGrupi;
		private VisionInfoSolutionLibrary.CheckBox cbDhomaGrupi;
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
		public HyrjeNeHotel()
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
			this.dtpDeri = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpPrej = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.cbDhoma = new VisionInfoSolutionLibrary.CheckBox();
			this.cbKlienti = new VisionInfoSolutionLibrary.CheckBox();
			this.btnKerko = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbKlient = new VisionInfoSolutionLibrary.GroupBox();
			this.dg1 = new VisionInfoSolutionLibrary.DataGrid();
			this.ds = new System.Data.DataSet();
			this.tabControl1 = new VisionInfoSolutionLibrary.TabControl();
			this.tbKlient = new VisionInfoSolutionLibrary.TabPageControl();
			this.tbGrup = new VisionInfoSolutionLibrary.TabPageControl();
			this.cbGrupi = new VisionInfoSolutionLibrary.CheckBox();
			this.cbDhomaGrupi = new VisionInfoSolutionLibrary.CheckBox();
			this.gbGrup = new VisionInfoSolutionLibrary.GroupBox();
			this.dg2 = new VisionInfoSolutionLibrary.DataGrid();
			this.btnKerkoGrup = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbGrupetKerkim = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbDhomaGrup = new VisionInfoSolutionLibrary.DoubleCombo();
			this.txtAgjensiaKerkim = new VisionInfoSolutionLibrary.TextBox();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.dtpDeriGrupi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpPrejGrupi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
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
			this.lblStatus.Size = new System.Drawing.Size(1003, 25);
			// 
			// gbZgjidh
			// 
			this.gbZgjidh.BackColor = System.Drawing.Color.Transparent;
			this.gbZgjidh.Controls.Add(this.cbDhoma);
			this.gbZgjidh.Controls.Add(this.cbKlienti);
			this.gbZgjidh.Controls.Add(this.cmbDhoma);
			this.gbZgjidh.Controls.Add(this.txtMbiemri1);
			this.gbZgjidh.Controls.Add(this.txtEmri1);
			this.gbZgjidh.Controls.Add(this.label2);
			this.gbZgjidh.Controls.Add(this.lblEmr);
			this.gbZgjidh.Controls.Add(this.dtpDeri);
			this.gbZgjidh.Controls.Add(this.dtpPrej);
			this.gbZgjidh.Controls.Add(this.label3);
			this.gbZgjidh.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbZgjidh.Location = new System.Drawing.Point(10, 8);
			this.gbZgjidh.Name = "gbZgjidh";
			this.gbZgjidh.Size = new System.Drawing.Size(450, 112);
			this.gbZgjidh.TabIndex = 13;
			this.gbZgjidh.Text = "Kerkim sipas";
			this.gbZgjidh.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbDhoma
			// 
			this.cmbDhoma.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhoma.DefaultErrorMessage = null;
			this.cmbDhoma.IsValid = false;
			this.cmbDhoma.Kolone1Vlere = null;
			this.cmbDhoma.Kolone2Vlere = null;
			this.cmbDhoma.Location = new System.Drawing.Point(104, 80);
			this.cmbDhoma.Name = "cmbDhoma";
			this.cmbDhoma.ReadOnly = false;
			this.cmbDhoma.Required = false;
			this.cmbDhoma.Size = new System.Drawing.Size(160, 21);
			this.cmbDhoma.SkipValidation = false;
			this.cmbDhoma.TabIndex = 7;
			// 
			// txtMbiemri1
			// 
			this.txtMbiemri1.AutoSize = false;
			this.txtMbiemri1.DefaultErrorMessage = "Ju duhet te jepni emrin dhe mbiemrin per kerkim!";
			this.txtMbiemri1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemri1.FixedLength = false;
			this.txtMbiemri1.IsValid = false;
			this.txtMbiemri1.Location = new System.Drawing.Point(272, 52);
			this.txtMbiemri1.Name = "txtMbiemri1";
			this.txtMbiemri1.Required = false;
			this.txtMbiemri1.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemri1.Size = new System.Drawing.Size(160, 21);
			this.txtMbiemri1.TabIndex = 6;
			this.txtMbiemri1.Text = "";
			// 
			// txtEmri1
			// 
			this.txtEmri1.AutoSize = false;
			this.txtEmri1.DefaultErrorMessage = "";
			this.txtEmri1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri1.FixedLength = false;
			this.txtEmri1.IsValid = false;
			this.txtEmri1.Location = new System.Drawing.Point(104, 52);
			this.txtEmri1.Name = "txtEmri1";
			this.txtEmri1.Required = false;
			this.txtEmri1.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri1.Size = new System.Drawing.Size(160, 21);
			this.txtEmri1.TabIndex = 5;
			this.txtEmri1.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(272, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Mbiemri";
			// 
			// lblEmr
			// 
			this.lblEmr.BackColor = System.Drawing.Color.Transparent;
			this.lblEmr.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmr.Location = new System.Drawing.Point(104, 40);
			this.lblEmr.Name = "lblEmr";
			this.lblEmr.Size = new System.Drawing.Size(60, 16);
			this.lblEmr.TabIndex = 6;
			this.lblEmr.Text = "Emri";
			// 
			// dtpDeri
			// 
			this.dtpDeri.BackColor = System.Drawing.Color.White;
			this.dtpDeri.CustomFormat = "dd.MM.yyyy";
			this.dtpDeri.DefaultErrorMessage = "";
			this.dtpDeri.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDeri.IsValid = true;
			this.dtpDeri.Location = new System.Drawing.Point(272, 16);
			this.dtpDeri.Name = "dtpDeri";
			this.dtpDeri.Required = true;
			this.dtpDeri.ShowCheckBox = true;
			this.dtpDeri.ShowUpDown = true;
			this.dtpDeri.Size = new System.Drawing.Size(160, 20);
			this.dtpDeri.TabIndex = 4;
			this.dtpDeri.Value = new System.DateTime(2005, 8, 30, 18, 35, 0, 0);
			// 
			// dtpPrej
			// 
			this.dtpPrej.BackColor = System.Drawing.Color.White;
			this.dtpPrej.CustomFormat = "dd.MM.yyyy";
			this.dtpPrej.DefaultErrorMessage = "";
			this.dtpPrej.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPrej.IsValid = true;
			this.dtpPrej.Location = new System.Drawing.Point(104, 16);
			this.dtpPrej.Name = "dtpPrej";
			this.dtpPrej.Required = true;
			this.dtpPrej.ShowCheckBox = true;
			this.dtpPrej.ShowUpDown = true;
			this.dtpPrej.Size = new System.Drawing.Size(160, 20);
			this.dtpPrej.TabIndex = 3;
			this.dtpPrej.Value = new System.DateTime(2005, 8, 30, 18, 35, 0, 0);
			this.dtpPrej.ValueChanged += new System.EventHandler(this.dtpPrej_ValueChanged);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(28, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 58;
			this.label3.Text = "Midis datave";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbDhoma
			// 
			this.cbDhoma.BackColor = System.Drawing.Color.Transparent;
			this.cbDhoma.DefaultErrorMessage = "";
			this.cbDhoma.IsValid = true;
			this.cbDhoma.Location = new System.Drawing.Point(8, 80);
			this.cbDhoma.Name = "cbDhoma";
			this.cbDhoma.Size = new System.Drawing.Size(92, 24);
			this.cbDhoma.TabIndex = 2;
			this.cbDhoma.Text = "Dhomes";
			this.cbDhoma.CheckedChanged += new System.EventHandler(this.cbDhoma_CheckedChanged);
			// 
			// cbKlienti
			// 
			this.cbKlienti.BackColor = System.Drawing.Color.Transparent;
			this.cbKlienti.DefaultErrorMessage = "";
			this.cbKlienti.IsValid = true;
			this.cbKlienti.Location = new System.Drawing.Point(8, 52);
			this.cbKlienti.Name = "cbKlienti";
			this.cbKlienti.Size = new System.Drawing.Size(92, 24);
			this.cbKlienti.TabIndex = 1;
			this.cbKlienti.Text = "Klientit";
			this.cbKlienti.CheckedChanged += new System.EventHandler(this.cbKlienti_CheckedChanged);
			// 
			// btnKerko
			// 
			this.btnKerko.BackColor = System.Drawing.Color.Blue;
			this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko.DoValidation = false;
			this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko.Location = new System.Drawing.Point(468, 52);
			this.btnKerko.Name = "btnKerko";
			this.btnKerko.Size = new System.Drawing.Size(90, 21);
			this.btnKerko.TabIndex = 8;
			this.btnKerko.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko, "Kerkon per hyrjet individuale ne hotel qe plotesojne kriteret e zgjedhur!");
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
			this.gbKlient.Size = new System.Drawing.Size(892, 416);
			this.gbKlient.TabIndex = 14;
			this.gbKlient.Text = "Hyrjet individuale te vlefshme ne hotel";
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
			this.dg1.Size = new System.Drawing.Size(866, 385);
			this.dg1.TabIndex = 9;
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
			this.tabControl1.Location = new System.Drawing.Point(-8, 25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1011, 609);
			this.tabControl1.TabIndex = 15;
			this.toolTips.SetToolTip(this.tabControl1, "Kerkon per hyrjet ne grup ne hotel qe plotesojne kriteret e zgjedhur!");
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tbKlient
			// 
			this.tbKlient.BackColor = System.Drawing.SystemColors.Control;
			this.tbKlient.Controls.Add(this.gbKlient);
			this.tbKlient.Controls.Add(this.btnKerko);
			this.tbKlient.Controls.Add(this.gbZgjidh);
			this.tbKlient.DefaultErrorMessage = null;
			this.tbKlient.EnableValidation = true;
			this.tbKlient.IsValid = false;
			this.tbKlient.Location = new System.Drawing.Point(4, 22);
			this.tbKlient.Name = "tbKlient";
			this.tbKlient.Size = new System.Drawing.Size(1003, 583);
			this.tbKlient.TabIndex = 0;
			this.tbKlient.Text = "Individuale";
			// 
			// tbGrup
			// 
			this.tbGrup.BackColor = System.Drawing.SystemColors.Control;
			this.tbGrup.Controls.Add(this.cbGrupi);
			this.tbGrup.Controls.Add(this.cbDhomaGrupi);
			this.tbGrup.Controls.Add(this.gbGrup);
			this.tbGrup.Controls.Add(this.btnKerkoGrup);
			this.tbGrup.Controls.Add(this.groupBox1);
			this.tbGrup.DefaultErrorMessage = null;
			this.tbGrup.EnableValidation = true;
			this.tbGrup.IsValid = false;
			this.tbGrup.Location = new System.Drawing.Point(4, 22);
			this.tbGrup.Name = "tbGrup";
			this.tbGrup.Size = new System.Drawing.Size(1003, 583);
			this.tbGrup.TabIndex = 1;
			this.tbGrup.Text = "Ne grup";
			// 
			// cbGrupi
			// 
			this.cbGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cbGrupi.DefaultErrorMessage = "";
			this.cbGrupi.IsValid = true;
			this.cbGrupi.Location = new System.Drawing.Point(20, 64);
			this.cbGrupi.Name = "cbGrupi";
			this.cbGrupi.Size = new System.Drawing.Size(76, 20);
			this.cbGrupi.TabIndex = 10;
			this.cbGrupi.Text = "Grupit";
			// 
			// cbDhomaGrupi
			// 
			this.cbDhomaGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cbDhomaGrupi.DefaultErrorMessage = "";
			this.cbDhomaGrupi.IsValid = true;
			this.cbDhomaGrupi.Location = new System.Drawing.Point(20, 92);
			this.cbDhomaGrupi.Name = "cbDhomaGrupi";
			this.cbDhomaGrupi.Size = new System.Drawing.Size(72, 20);
			this.cbDhomaGrupi.TabIndex = 11;
			this.cbDhomaGrupi.Text = "Dhomes";
			// 
			// gbGrup
			// 
			this.gbGrup.BackColor = System.Drawing.Color.Transparent;
			this.gbGrup.Controls.Add(this.dg2);
			this.gbGrup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbGrup.Location = new System.Drawing.Point(10, 124);
			this.gbGrup.Name = "gbGrup";
			this.gbGrup.Size = new System.Drawing.Size(892, 416);
			this.gbGrup.TabIndex = 2;
			this.gbGrup.Text = "Hyrjet ne grup te vlefshme ne hotel";
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
			this.dg2.Size = new System.Drawing.Size(868, 384);
			this.dg2.TabIndex = 0;
			// 
			// btnKerkoGrup
			// 
			this.btnKerkoGrup.BackColor = System.Drawing.Color.Blue;
			this.btnKerkoGrup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerkoGrup.DoValidation = true;
			this.btnKerkoGrup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerkoGrup.Location = new System.Drawing.Point(476, 52);
			this.btnKerkoGrup.Name = "btnKerkoGrup";
			this.btnKerkoGrup.Size = new System.Drawing.Size(90, 21);
			this.btnKerkoGrup.TabIndex = 17;
			this.btnKerkoGrup.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerkoGrup, "Kerkon per hyrjet ne grup ne hotel qe plotesojne kriteret e zgjedhur!");
			this.btnKerkoGrup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerkoGrup.Click += new System.EventHandler(this.btnKerkoGrup_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.cmbGrupetKerkim);
			this.groupBox1.Controls.Add(this.cmbDhomaGrup);
			this.groupBox1.Controls.Add(this.txtAgjensiaKerkim);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dtpDeriGrupi);
			this.groupBox1.Controls.Add(this.dtpPrejGrupi);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(10, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(450, 112);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.Text = "Kerkim sipas";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbGrupetKerkim
			// 
			this.cmbGrupetKerkim.BackColor = System.Drawing.Color.Transparent;
			this.cmbGrupetKerkim.DefaultErrorMessage = null;
			this.cmbGrupetKerkim.IsValid = true;
			this.cmbGrupetKerkim.Kolone1Vlere = null;
			this.cmbGrupetKerkim.Kolone2Vlere = null;
			this.cmbGrupetKerkim.Location = new System.Drawing.Point(104, 52);
			this.cmbGrupetKerkim.Name = "cmbGrupetKerkim";
			this.cmbGrupetKerkim.ReadOnly = false;
			this.cmbGrupetKerkim.Required = false;
			this.cmbGrupetKerkim.Size = new System.Drawing.Size(160, 21);
			this.cmbGrupetKerkim.SkipValidation = false;
			this.cmbGrupetKerkim.TabIndex = 14;
			this.cmbGrupetKerkim.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbGrupetKerkim_SelectedIndexChanged);
			// 
			// cmbDhomaGrup
			// 
			this.cmbDhomaGrup.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhomaGrup.DefaultErrorMessage = null;
			this.cmbDhomaGrup.IsValid = true;
			this.cmbDhomaGrup.Kolone1Vlere = null;
			this.cmbDhomaGrup.Kolone2Vlere = null;
			this.cmbDhomaGrup.Location = new System.Drawing.Point(104, 80);
			this.cmbDhomaGrup.Name = "cmbDhomaGrup";
			this.cmbDhomaGrup.ReadOnly = false;
			this.cmbDhomaGrup.Required = false;
			this.cmbDhomaGrup.Size = new System.Drawing.Size(160, 21);
			this.cmbDhomaGrup.SkipValidation = false;
			this.cmbDhomaGrup.TabIndex = 16;
			// 
			// txtAgjensiaKerkim
			// 
			this.txtAgjensiaKerkim.AutoSize = false;
			this.txtAgjensiaKerkim.DefaultErrorMessage = "Ju duhet te jepni grupin dhe agjensine per kerkim!";
			this.txtAgjensiaKerkim.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAgjensiaKerkim.FixedLength = false;
			this.txtAgjensiaKerkim.IsValid = false;
			this.txtAgjensiaKerkim.Location = new System.Drawing.Point(272, 52);
			this.txtAgjensiaKerkim.Name = "txtAgjensiaKerkim";
			this.txtAgjensiaKerkim.Required = false;
			this.txtAgjensiaKerkim.RequiredControlColor = System.Drawing.Color.White;
			this.txtAgjensiaKerkim.Size = new System.Drawing.Size(160, 21);
			this.txtAgjensiaKerkim.TabIndex = 15;
			this.txtAgjensiaKerkim.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(276, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 17;
			this.label1.Text = "Agjensia";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(104, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 16;
			this.label5.Text = "Grupi";
			// 
			// dtpDeriGrupi
			// 
			this.dtpDeriGrupi.CustomFormat = "dd.MM.yyyy";
			this.dtpDeriGrupi.DefaultErrorMessage = "";
			this.dtpDeriGrupi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDeriGrupi.IsValid = true;
			this.dtpDeriGrupi.Location = new System.Drawing.Point(272, 14);
			this.dtpDeriGrupi.Name = "dtpDeriGrupi";
			this.dtpDeriGrupi.Required = false;
			this.dtpDeriGrupi.ShowCheckBox = true;
			this.dtpDeriGrupi.ShowUpDown = true;
			this.dtpDeriGrupi.Size = new System.Drawing.Size(160, 20);
			this.dtpDeriGrupi.TabIndex = 13;
			this.dtpDeriGrupi.Value = new System.DateTime(2005, 9, 26, 13, 41, 0, 0);
			// 
			// dtpPrejGrupi
			// 
			this.dtpPrejGrupi.CustomFormat = "dd.MM.yyyy";
			this.dtpPrejGrupi.DefaultErrorMessage = "";
			this.dtpPrejGrupi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPrejGrupi.IsValid = true;
			this.dtpPrejGrupi.Location = new System.Drawing.Point(104, 14);
			this.dtpPrejGrupi.Name = "dtpPrejGrupi";
			this.dtpPrejGrupi.Required = false;
			this.dtpPrejGrupi.ShowCheckBox = true;
			this.dtpPrejGrupi.ShowUpDown = true;
			this.dtpPrejGrupi.Size = new System.Drawing.Size(160, 20);
			this.dtpPrejGrupi.TabIndex = 12;
			this.dtpPrejGrupi.Value = new System.DateTime(2005, 9, 26, 13, 41, 0, 0);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Midis datave";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// HyrjeNeHotel
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(880, 452);
			this.Controls.Add(this.tabControl1);
			this.HelpFile = "HYRJET NE HOTEL.htm";
			this.Name = "HyrjeNeHotel";
			this.Text = "Hyrjet ne hotel";
			this.TitullGjeresi = 1003;
			this.Load += new System.EventHandler(this.HyrjeNeHotel_Load);
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
		private void HyrjeNeHotel_Load(object sender, System.EventArgs e)
		{
			//inicializim var private
			this.clicked = false;
			this.ds.Tables.Clear();
			readyToPrint = true;
			this.Cursor = Cursors.WaitCursor;
			//inicializim var private
			try
			{
				this.mbushDhomat();
				this.mbushGrupet();
				this.dtpDeri.Value = DateTime.Now.Date;
				this.dtpPrej.Value = DateTime.Now.Date;
				this.dtpPrejGrupi.Value = DateTime.Now.Date;
				this.dtpDeriGrupi.Value = DateTime.Now.Date;
				if (this.tabControl1.SelectedIndex == 0)
				{
					InputController data = new InputController();
					ds = data.KerkesaRead("ShfaqKlientHotel");
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.ReadyToPrint = false;
						this.dg1.DataSource = null;
						System.Windows.Forms.MessageBox.Show(this,  "Per momentin nuk ka asnje hyrje individuale ne hotel!", "Hyrjet ne hotel",MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					this.dg1.DataSource = ds.Tables["KLIENTI"];
					KrijoStilgride1();
					this.ReadyToPrint = true;
					// Hidh datasetin ne XML
					this.WriteToXml(this.ds, false);
				}
				else
				{
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
				if (this.clicked == false)
				{
					this.clicked = true;
					if (Convert.ToInt32(this.tabControl1.SelectedIndex) == 1)
					{
					
						InputController data = new InputController();
						ds = data.KerkesaRead("ShfaqKlientGrupNeHotel");
						if (ds.Tables[0].Rows.Count == 0)
						{
							this.ReadyToPrint = false;
							this.dg2.DataSource = null;
							System.Windows.Forms.MessageBox.Show(this, "Per momentin nuk ka asnje hyrje ne grup ne hotel!", "Hyrjet ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
							this.WriteToXml(this.ds, true);
						}
					}
					else
					{
						this.HyrjeNeHotel_Load(sender, e);
					}
				}
				else
				{
					if (this.tabControl1.SelectedIndex == 0)
					{
						this.HyrjeNeHotel_Load(sender, e);
					}
					else
					{

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
				this.AutoScrollPosition = new Point(0, 0);
			}
		}

		private void btnKerko_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				InputController data = new InputController();
				string koment;
				DateTime dtFillimi = Convert.ToDateTime(this.dtpPrej.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpDeri.Value);
				if (dtFillimi.Date >= dtMbarimi.Date)
				{
					this.error.SetError(dtpDeri, "Data e mbarimit duhet te jete me e madhe se data e fillimit!");
					dtpDeri.IsValid = false;
					return;
				}
				this.error.SetError(dtpDeri, "");
				dtpDeri.IsValid = true;
				if ((this.cbKlienti.Checked == true)&&(this.cbDhoma.Checked == true))
				{
					string emri = this.txtEmri1.Text;
					string mbiemri = this.txtMbiemri1.Text;
					if (this.cmbDhoma.Kolone1.SelectedItem == null)
					{
						this.error.SetError(cmbDhoma, "Zgjidhni nje prej dhomave para se te kerkoni!");
						this.dg1.DataSource = null;
						return;
					}
					int id_dhoma  = Convert.ToInt32(this.cmbDhoma.Kolone2Vlere);
					koment = "Hyrjet individuale ne hotel per klientin me emer " + emri + " " + mbiemri + " ne dhomen " + this.cmbDhoma.Kolone1Vlere + " midis datave te zgjedhura!";
					this.gbKlient.Text = koment;
					DataSet ds = data.KerkesaRead("ShfaqVeprimetPerKlientinDheDhomen", id_dhoma,emri, mbiemri, dtFillimi.Date.AddDays(1), dtMbarimi.Date.AddDays(1),-1);
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.dg1.DataSource = null;
						System.Windows.Forms.MessageBox.Show(this,  "Per dhomen e zgjedhur nuk ka asnje hyrje individuale ne hotel!", "Hyrjet ne hotel",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					this.dg1.DataSource = ds.Tables["KLIENTI"];
					// Bej ndryshimet perkatese te propertise ReadyToPrint
					if (ds.Tables[0].Rows.Count < 1)
					{
						this.ReadyToPrint = false;
					}
					else
					{
						this.ReadyToPrint = true;
						this.WriteToXml(ds, false);
						this.KrijoStilgride1();
					}
				}
				else if (this.cbKlienti.Checked == true)
				{
					string emri = this.txtEmri1.Text;
					string mbiemri = this.txtMbiemri1.Text;
					DataSet ds = data.KerkesaRead("ShfaqVeprimetPerKlientin", emri, mbiemri, dtFillimi.Date.AddDays(1), dtMbarimi.Date.AddDays(1),-1);
					koment = "Hyrjet individuale ne hotel per klientet me emer " + emri + " " + mbiemri + " midis datave te zgjedhura";
					this.gbKlient.Text = koment;
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.dg1.DataSource = null;
						System.Windows.Forms.MessageBox.Show(this,  "Per kete emer nuk ka asnje hyrje individuale ne hotel!","Hyrjet ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
						this.WriteToXml(ds, false);
					}
					this.KrijoStilgride1();
				}
				else if (this.cbDhoma.Checked == true)
				{
					if (this.cmbDhoma.Kolone1.SelectedItem == null)
					{
						this.error.SetError(cmbDhoma, "Zgjidhni nje prej dhomave para se te kerkoni!");
						this.dg1.DataSource = null;
						return;
					}
					int id_dhoma  = Convert.ToInt32(this.cmbDhoma.Kolone2Vlere);
					koment = "Hyrjet individuale ne hotel per dhomen " + this.cmbDhoma.Kolone1Vlere + " midis datave te zgjedhura";
					this.gbKlient.Text = koment;
					DataSet ds = data.KerkesaRead("ShfaqVeprimetPerDhomen", id_dhoma,-1, dtFillimi.Date.AddDays(1), dtMbarimi.Date.AddDays(1));
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.dg1.DataSource = null;
						System.Windows.Forms.MessageBox.Show(this,  "Per dhomen e zgjedhur nuk ka asnje hyrje individuale ne hotel!", "Hyrjet ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
						this.WriteToXml(ds, false);
						this.KrijoStilgride1();
					}
				}
				else if ((this.cbKlienti.Checked == false)&&(this.cbDhoma.Checked == false))
				{
					//nqs asnje prej opsioneve nuk zgjidhet atehere kerko sipas datave
					koment = "Hyrjet individuale ne hotel midis datave " + this.konvertoshkurt(dtFillimi) + " dhe " + this.konvertoshkurt(dtMbarimi);
					this.gbKlient.Text = koment;
					DataSet ds = data.KerkesaRead("ShfaqVeprimetPerDatat",-1, dtFillimi, dtMbarimi);
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.dg1.DataSource = null;
						System.Windows.Forms.MessageBox.Show(this,  "Midis datave te zgjedhura nuk ka asnje hyrje individuale ne hotel!", "Hyrjet ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
						this.WriteToXml(ds, false);
						this.KrijoStilgride1();
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
				DateTime dtFillimi = Convert.ToDateTime(this.dtpPrejGrupi.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpDeriGrupi.Value);
				if (dtFillimi.Date >=  dtMbarimi)
				{
					this.error.SetError(dtpDeriGrupi, "Data e mbarimit duhet te jete me e madhe se data e fillimit!");
					this.dtpPrejGrupi.IsValid = false;
					this.dtpDeriGrupi.IsValid = false;
					this.dg2.DataSource = null;
					return;
				}
				this.error.SetError(this.dtpDeriGrupi, "");
				if ((this.cbGrupi.Checked == true)&&(this.cbDhomaGrupi.Checked == true))
				{				
					if (this.cmbGrupetKerkim.Kolone1.SelectedItem == null)
					{
						this.error.SetError(cmbGrupetKerkim, "Zgjidhni nje prej grupeve para se te kerkoni");
						this.dg2.DataSource = null;
						return;
					}
					this.error.SetError(cmbGrupetKerkim, "");
					if (this.cmbDhomaGrup.Kolone1.SelectedItem == null)
					{
						this.error.SetError(cmbDhomaGrup, "Zgjidhni nje prej dhomave para se te kerkoni");
						this.dg2.DataSource = null;
						return;
					}
					this.error.SetError(cmbDhomaGrup, "");
					int idGrupi = Convert.ToInt32(this.cmbGrupetKerkim.Kolone2Vlere);
					int idDhoma = Convert.ToInt32(this.cmbDhomaGrup.Kolone2Vlere);
					koment = "Hyrjet ne hotel per grupin " + cmbGrupetKerkim.Kolone1.Text + " ne dhomen " + cmbDhomaGrup.Kolone1.Text + " per datat e zgjedhura";
					this.gbGrup.Text = koment;
					DataSet ds = data.KerkesaRead("ShfaqVeprimetPerGrupDheDhome",idGrupi, idDhoma, dtFillimi.Date.AddDays(1), dtMbarimi.Date.AddDays(1), -1);
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.dg2.DataSource = null;
						System.Windows.Forms.MessageBox.Show(this, "Per datat e zgjedhura nuk ka asnje hyrje ne grup ne hotel!", "Hyrjet ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					this.dg2.DataSource = ds.Tables["KLIENTI"];
					//mbush griden per kete rast
					// Bej ndryshimet perkatese te propertise ReadyToPrint
					if (ds.Tables[1].Rows.Count < 1)
						this.ReadyToPrint = false;
					else
						this.ReadyToPrint = true;
					this.KrijoStilgride2();
					this.WriteToXml(ds, true);
				}
				else if (this.cbGrupi.Checked == true)
				{
					if (this.cmbGrupetKerkim.Kolone1.SelectedItem == null)
					{
						this.error.SetError(cmbGrupetKerkim, "Zgjidhni nje prej grupeve para se te kerkoni");
						this.dg2.DataSource = null;
						return;
					}
					this.error.SetError(cmbGrupetKerkim, "");
					int id_grupi = Convert.ToInt32(this.cmbGrupetKerkim.Kolone2Vlere.ToString());
					DataSet ds = data.KerkesaRead("ShfaqVeprimetPerGrupin", id_grupi,-1, dtFillimi.Date.AddDays(1), dtMbarimi.Date.AddDays(1));
					koment = "Hyrjet ne grup ne hotel per grupin " + this.cmbGrupetKerkim.Kolone1.Text;
					this.gbGrup.Text = koment;
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.ReadyToPrint = false;
						this.dg2.DataSource = null;
						System.Windows.Forms.MessageBox.Show(this, "Per kete grup nuk ka asnje hyrje ne hotel!","Hyrjet ne hotel",  MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					this.dg2.DataSource = ds.Tables["KLIENTI"];
					// Bej ndryshimet perkatese te propertise ReadyToPrint
					this.ReadyToPrint = true;
					this.WriteToXml(ds, true);
					this.KrijoStilgride2();
				}
				else if (this.cbDhomaGrupi.Checked == true)
				{
					if (this.cmbDhomaGrup.Kolone1.SelectedItem == null)
					{
						this.error.SetError(cmbDhomaGrup, "Zgjidhni nje prej dhomave para se te kerkoni");
						this.dg2.DataSource = null;
						return;
					}
					this.error.SetError(cmbDhomaGrup, "");
					int id_dhoma  = Convert.ToInt32(this.cmbDhomaGrup.Kolone2Vlere.ToString());
					DataSet ds = data.KerkesaRead("ShfaqVeprimetNeGrupPerDhomen", id_dhoma,-1, dtFillimi.Date.AddDays(1), dtMbarimi.Date.AddDays(1));
					koment = "Hyrjet ne grup ne hotel per dhomen " + this.cmbDhomaGrup.Kolone1.Text;
					this.gbGrup.Text = koment;
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.ReadyToPrint = false;
						this.dg2.DataSource = null;
						System.Windows.Forms.MessageBox.Show(this,  "Per dhomen e zgjedhur nuk ka asnje hyrje ne grup ne hotel!","Hyrjet ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					this.dg2.DataSource = ds.Tables["KLIENTI"];
					// Bej ndryshimet perkatese te propertise ReadyToPrint
					this.ReadyToPrint = true;
					this.WriteToXml(ds, true);
					this.KrijoStilgride2();
				}
				else if ((this.cbGrupi.Checked == false)&&(this.cbDhomaGrupi.Checked == false))
				{
					koment = "Hyrjet ne grup ne hotel midis datave " + this.konvertoshkurt(dtFillimi) + " dhe " + this.konvertoshkurt(dtMbarimi);
					this.gbGrup.Text = koment;
					DataSet ds = data.KerkesaRead("ShfaqVeprimetNeGrupPerDatat",-1, dtFillimi.Date.AddDays(1), dtMbarimi.Date.AddDays(1));
					if (ds.Tables[0].Rows.Count == 0)
					{
						this.dg2.DataSource = null;
						System.Windows.Forms.MessageBox.Show(this,  "Per datat e zgjedhura nuk ka asnje hyrje ne grup ne hotel!","Hyrjet ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					this.dg2.DataSource = ds.Tables["KLIENTI"];
					// mbush griden per kete rast
					// Bej ndryshimet perkatese te propertise ReadyToPrint
					if (ds.Tables[1].Rows.Count < 1)
					{
						this.ReadyToPrint = false;
					}
					else
					{
						this.ReadyToPrint = true;
					}
					this.KrijoStilgride2();
					this.WriteToXml(ds, true);
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

		private void dtpPrej_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				DateTime dt = Convert.ToDateTime(this.dtpPrej.Value);
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
				kapari.MappingName = "KAPARI";
				kapari.NullText = "0";
				kapari.Width = 50;

				DataGridTekstBoxColumn skonto = new DataGridTekstBoxColumn();
				skonto.HeaderText = "Skonto";
				skonto.MappingName = "SKONTO";
				skonto.NullText = "0";
				skonto.Width = 50;

				DataGridTekstBoxColumn gjoba = new DataGridTekstBoxColumn();
				gjoba.HeaderText = "Gjoba";
				gjoba.MappingName = "GJOBA";
				gjoba.Width = 50;

				DataGridTekstBoxColumn emri = new DataGridTekstBoxColumn();
				emri.HeaderText = "Klienti";
				emri.MappingName = "EMRI";
				emri.Width = 110;
			
				DataGridTekstBoxColumn colMjetIdentifikimi = new DataGridTekstBoxColumn();
				colMjetIdentifikimi .HeaderText = "Mjet Identifikimi";
				colMjetIdentifikimi .MappingName = "EMER_LLOJI";
				colMjetIdentifikimi.NullText = "-";
				colMjetIdentifikimi .Width = 92;

				DataGridTekstBoxColumn colNrIdentifikimi = new DataGridTekstBoxColumn();
				colNrIdentifikimi .HeaderText = "Nr Identifikimi";
				colNrIdentifikimi .MappingName = "NR_IDENTIFIKIMI";
				colNrIdentifikimi.NullText = "-";
				colNrIdentifikimi .Width = 85;

				DataGridTekstBoxColumn colNrTel = new DataGridTekstBoxColumn();
				colNrTel .HeaderText = "Nr Tel";
				colNrTel .MappingName = "TELEFONI";
				colNrTel.NullText = "-";
				colNrTel .Width = 80;

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

				DataGridTekstBoxColumn colPergjegjes = new DataGridTekstBoxColumn();
				colPergjegjes .HeaderText = "Date Dalje";
				colPergjegjes .MappingName = "PERGJEGJES";
				colPergjegjes .Width = 0;
				colPergjegjes .NullText = "";
			
				DataGridTekstBoxColumn colVendlindja = new DataGridTekstBoxColumn();
				colVendlindja .HeaderText = "Vendlindja";
				colVendlindja .MappingName = "VENDLINDJA";
				colVendlindja .Width = 80;
				colVendlindja .NullText = "";

				DataGridTekstBoxColumn colShtetesia = new DataGridTekstBoxColumn();
				colShtetesia .HeaderText = "Shtetesia";
				colShtetesia .MappingName = "SHTETESIA";
				colShtetesia .Width = 80;
				colShtetesia .NullText = "";

				style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{ colPergjegjes, dhomaEmri, kapari, skonto, gjoba, emri, colMjetIdentifikimi, colNrIdentifikimi, 
																			 colNrTel, colDateFillimi1,
																			 colDateMbarimi1,colVendlindja,colShtetesia});
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

			DataGridTekstBoxColumn colGrupi = new DataGridTekstBoxColumn();
			colGrupi.HeaderText = "Grupi";
			colGrupi.MappingName = "GRUPI";
			colGrupi.Width = 60;

			DataGridTekstBoxColumn colAgjensia = new DataGridTekstBoxColumn();
			colAgjensia.HeaderText = "Agjensia";
			colAgjensia.MappingName = "AGJENSIA";
			colAgjensia.Width = 60;

			DataGridTekstBoxColumn dhomaEmri = new DataGridTekstBoxColumn();
			dhomaEmri.HeaderText = "Dhoma";
			dhomaEmri.MappingName = "DHOMA_EMRI";
			dhomaEmri.Width = 60;

			DataGridTekstBoxColumn kapari = new DataGridTekstBoxColumn();
			kapari.HeaderText = "Kapari";
			kapari.MappingName = "KAPARI";
			kapari.NullText = "0";
			kapari.Width = 50;

			DataGridTekstBoxColumn skonto = new DataGridTekstBoxColumn();
			skonto.HeaderText = "Skonto";
			skonto.MappingName = "SKONTO";
			skonto.NullText = "0";
			skonto.Width = 50;

			DataGridTekstBoxColumn gjoba = new DataGridTekstBoxColumn();
			gjoba.HeaderText = "Gjoba";
			gjoba.MappingName = "GJOBA";
			gjoba.Width = 50;

			DataGridTekstBoxColumn emri = new DataGridTekstBoxColumn();
			emri.HeaderText = "Klienti";
			emri.MappingName = "EMRI";
			emri.Width = 110;
			
			DataGridTekstBoxColumn colMjetIdentifikimi = new DataGridTekstBoxColumn();
			colMjetIdentifikimi .HeaderText = "Mjet Identifikimi";
			colMjetIdentifikimi .MappingName = "EMER_LLOJI";
			colMjetIdentifikimi.NullText = "-";
			colMjetIdentifikimi .Width = 92;

			DataGridTekstBoxColumn colNrIdentifikimi = new DataGridTekstBoxColumn();
			colNrIdentifikimi .HeaderText = "Nr Identifikimi";
			colNrIdentifikimi .MappingName = "NR_IDENTIFIKIMI";
			colNrIdentifikimi.NullText = "-";
			colNrIdentifikimi .Width = 85;

			DataGridTekstBoxColumn colNrTel = new DataGridTekstBoxColumn();
			colNrTel .HeaderText = "Nr Tel";
			colNrTel .MappingName = "TELEFONI";
			colNrTel.NullText = "-";
			colNrTel .Width = 80;

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


			DataGridTekstBoxColumn colIdDhoma = new DataGridTekstBoxColumn();
			colIdDhoma .HeaderText = "Id dhoma";
			colIdDhoma .MappingName = "ID_DHOMA_STR";
			colIdDhoma .Width = 0;
			colIdDhoma .NullText = "";

			DataGridTekstBoxColumn colVendlindja = new DataGridTekstBoxColumn();
			colVendlindja .HeaderText = "Vendlindja";
			colVendlindja .MappingName = "VENDLINDJA";
			colVendlindja .Width = 80;
			colVendlindja .NullText = "";

			DataGridTekstBoxColumn colShtetesia = new DataGridTekstBoxColumn();
			colShtetesia .HeaderText = "Shtetesia";
			colShtetesia .MappingName = "SHTETESIA";
			colShtetesia .Width = 80;
			colShtetesia .NullText = "";

			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{colIdKlienti,colGrupi, 
			colAgjensia,  kapari, skonto,  emri, colIdDhoma, dhomaEmri, colMjetIdentifikimi, colNrIdentifikimi, 
			 colNrTel, colDateFillimi1,
			colDateMbarimi1,colVendlindja,colShtetesia});
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
			string dita, muaji, viti;
			dita = data_str.Substring(8, 2);
			muaji = data_str.Substring(5, 2);
			viti = data_str.Substring(0, 4);
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
			string dtHyrjeStr;
			string dtDaljeStr = "";
			foreach (DataRow dr in ds1.Tables[1].Rows)
			{
				// Bejme formatimin e dates se hyrjes per paraqitjet ne raport
				string[] dtHyrje = dr["DATA_HYRJE_STRORE"].ToString().Replace("\r\n", "&").Split('&');
				dtHyrjeStr = "";
				for (int i = 0; i < dtHyrje.Length; i++)
				{
					if (i == dtHyrje.Length - 1)
					{
						dtHyrjeStr +=  dtHyrje.GetValue(i).ToString().Substring(0, 10);
					}
					else
						dtHyrjeStr +=  dtHyrje.GetValue(i).ToString().Substring(0, 10) + Environment.NewLine;
				}
				dr["DATA_HYRJE_STR"] = dtHyrjeStr;
				// Bejme formatimin e dates se daljes per paraqitjet ne raport
				string[] dtDalje = dr["DATA_DALJE_STRORE"].ToString().Replace("\r\n", "&").Split('&');
				dtDaljeStr = "";
				for (int i = 0; i < dtHyrje.Length; i++)
				{
					if (i == dtHyrje.Length - 1)
					{
						dtDaljeStr +=  dtDalje.GetValue(i).ToString().Substring(0, 10);
					}
					else
						dtDaljeStr +=  dtDalje.GetValue(i).ToString().Substring(0, 10) + Environment.NewLine;
				}
				dr["DATA_DALJE_STR"] = dtDaljeStr;
			}
			//Hidh datasetin ne Xml
			if (grup)
				ds1.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\HyrjeNeHotelGrup.xml", XmlWriteMode.WriteSchema);
			else
				ds1.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\HyrjeNeHotel.xml", XmlWriteMode.WriteSchema);
		}

		#endregion

		#region IPrintable Members

		public void PrintPreview()
		{
			Printim print = new Printim();
			if (tabControl1.SelectedTab == tbKlient)
				print.NgarkoRaport("HyrjeNeHotel");
			else if (tabControl1.SelectedTab == tbGrup)
				print.NgarkoRaport("HyrjeNeHotelGrup");
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
				print.Printo("HyrjeNeHotel");
			else if (tabControl1.SelectedTab == tbGrup)
				print.Printo("HyrjeNeHotelGrup");
			
		}

		private void cbDhoma_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void cbKlienti_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		public event VisionInfoSolutionLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

		#endregion

	}
}

