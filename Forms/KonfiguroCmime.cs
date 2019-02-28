using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment.Forms
{
	public class KonfiguroCmime : VisionInfoSolutionLibrary.Form
	{
		#region Private Variables
		private VisionInfoSolutionLibrary.TabControl tab;
		private VisionInfoSolutionLibrary.TabPageControl tbShto;
		private VisionInfoSolutionLibrary.TabPageControl tbModifiko;
		private VisionInfoSolutionLibrary.Button btnElemino;
		private VisionInfoSolutionLibrary.Button btnModifiko;
		private VisionInfoSolutionLibrary.Button btnKerko;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.RadioButton rbDhoma;
		private VisionInfoSolutionLibrary.RadioButton rbData;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.NumericBox numCmimi;
		private VisionInfoSolutionLibrary.Label label4;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimi;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimi;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.TextBox txtEmerDhoma;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Button btnShto;
		private VisionInfoSolutionLibrary.GroupBox groupBox3;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.Label label8;
		private VisionInfoSolutionLibrary.Label label9;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategorite;
		private System.Windows.Forms.DataGridTableStyle MyStyle;
		private System.Windows.Forms.DataGridTextBoxColumn colDhoma;
		private System.Windows.Forms.DataGridTextBoxColumn colCmimi;
		private System.Windows.Forms.DataGridTextBoxColumn colFillimi;
		private System.Windows.Forms.DataGridTextBoxColumn colMbarimi;
		private System.Windows.Forms.DataGridTextBoxColumn colIdCmimi;
		private VisionInfoSolutionLibrary.NumericBox numCmimiShto;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDate;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.DoubleListBox lbDhomatKategori;
		private VisionInfoSolutionLibrary.DoubleListBox lbDhomat;
		private VisionInfoSolutionLibrary.Label label10;
		private VisionInfoSolutionLibrary.Button btnDjathtas;
		private VisionInfoSolutionLibrary.Button btnMajtas;
		private VisionInfoSolutionLibrary.DataGrid grid1;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategoriteModifikime;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhomatModifikime;
		private VisionInfoSolutionLibrary.Button btnPastro;
		private VisionInfoSolutionLibrary.Label label12;
		private VisionInfoSolutionLibrary.Label label13;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimiShto;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimiShto;
		private VisionInfoSolutionLibrary.GroupBox groupBox4;
		private int idKategoria;
		private System.Data.DataSet ds;
		private string[] vekKategori;
		private VisionInfoSolutionLibrary.Label label6;
		private int numer_rreshtash;

		#endregion

		#region Constructors & Deconstructors
		public KonfiguroCmime()
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
			this.tbShto = new VisionInfoSolutionLibrary.TabPageControl();
			this.groupBox3 = new VisionInfoSolutionLibrary.GroupBox();
			this.dtpMbarimiShto = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label12 = new VisionInfoSolutionLibrary.Label();
			this.dtpFillimiShto = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label13 = new VisionInfoSolutionLibrary.Label();
			this.btnPastro = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnMajtas = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnDjathtas = new VisionInfoSolutionLibrary.Button(this.components);
			this.label10 = new VisionInfoSolutionLibrary.Label();
			this.lbDhomat = new VisionInfoSolutionLibrary.DoubleListBox();
			this.lbDhomatKategori = new VisionInfoSolutionLibrary.DoubleListBox();
			this.cmbKategorite = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label9 = new VisionInfoSolutionLibrary.Label();
			this.label8 = new VisionInfoSolutionLibrary.Label();
			this.numCmimiShto = new VisionInfoSolutionLibrary.NumericBox();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.btnShto = new VisionInfoSolutionLibrary.Button(this.components);
			this.tbModifiko = new VisionInfoSolutionLibrary.TabPageControl();
			this.groupBox4 = new VisionInfoSolutionLibrary.GroupBox();
			this.dtpFillimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.numCmimi = new VisionInfoSolutionLibrary.NumericBox();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.dtpMbarimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.txtEmerDhoma = new VisionInfoSolutionLibrary.TextBox();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.btnElemino = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifiko = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnKerko = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.grid1 = new VisionInfoSolutionLibrary.DataGrid();
			this.MyStyle = new System.Windows.Forms.DataGridTableStyle();
			this.colDhoma = new System.Windows.Forms.DataGridTextBoxColumn();
			this.colCmimi = new System.Windows.Forms.DataGridTextBoxColumn();
			this.colFillimi = new System.Windows.Forms.DataGridTextBoxColumn();
			this.colMbarimi = new System.Windows.Forms.DataGridTextBoxColumn();
			this.colIdCmimi = new System.Windows.Forms.DataGridTextBoxColumn();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbDhomatModifikime = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbKategoriteModifikime = new VisionInfoSolutionLibrary.DoubleCombo();
			this.dtpDate = new VisionInfoSolutionLibrary.DateTimePicker();
			this.rbDhoma = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbData = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.ds = new System.Data.DataSet();
			this.tab.SuspendLayout();
			this.tbShto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.tbModifiko.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1011, 25);
			// 
			// tab
			// 
			this.tab.Controls.Add(this.tbShto);
			this.tab.Controls.Add(this.tbModifiko);
			this.tab.Cursor = System.Windows.Forms.Cursors.Default;
			this.tab.Location = new System.Drawing.Point(0, 25);
			this.tab.Name = "tab";
			this.tab.Padding = new System.Drawing.Point(0, 0);
			this.tab.SelectedIndex = 0;
			this.tab.Size = new System.Drawing.Size(1011, 609);
			this.tab.TabIndex = 17;
			this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
			// 
			// tbShto
			// 
			this.tbShto.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbShto.Controls.Add(this.groupBox3);
			this.tbShto.Controls.Add(this.btnShto);
			this.tbShto.DefaultErrorMessage = null;
			this.tbShto.EnableValidation = true;
			this.tbShto.IsValid = false;
			this.tbShto.Location = new System.Drawing.Point(4, 22);
			this.tbShto.Name = "tbShto";
			this.tbShto.Size = new System.Drawing.Size(1003, 583);
			this.tbShto.TabIndex = 0;
			this.tbShto.Text = "Shto      ";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.dtpMbarimiShto);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.dtpFillimiShto);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.btnPastro);
			this.groupBox3.Controls.Add(this.btnMajtas);
			this.groupBox3.Controls.Add(this.btnDjathtas);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.lbDhomat);
			this.groupBox3.Controls.Add(this.lbDhomatKategori);
			this.groupBox3.Controls.Add(this.cmbKategorite);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.numCmimiShto);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(10, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(554, 344);
			this.groupBox3.TabIndex = 24;
			this.groupBox3.Text = "Caktimi i cmimeve per dhomat sipas datave";
			this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// dtpMbarimiShto
			// 
			this.dtpMbarimiShto.BackColor = System.Drawing.Color.White;
			this.dtpMbarimiShto.CustomFormat = "dd.MM.yyyy";
			this.dtpMbarimiShto.DefaultErrorMessage = "Ju duhet te jepni daten e mbarimit per cmimin!";
			this.dtpMbarimiShto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimiShto.IsValid = true;
			this.dtpMbarimiShto.Location = new System.Drawing.Point(96, 284);
			this.dtpMbarimiShto.Name = "dtpMbarimiShto";
			this.dtpMbarimiShto.Required = true;
			this.dtpMbarimiShto.ShowCheckBox = true;
			this.dtpMbarimiShto.ShowUpDown = true;
			this.dtpMbarimiShto.Size = new System.Drawing.Size(160, 20);
			this.dtpMbarimiShto.TabIndex = 65;
			this.dtpMbarimiShto.Value = new System.DateTime(2005, 9, 2, 11, 56, 0, 0);
			// 
			// label12
			// 
			this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label12.Location = new System.Drawing.Point(8, 284);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(76, 20);
			this.label12.TabIndex = 64;
			this.label12.Text = "Date mbarimi";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpFillimiShto
			// 
			this.dtpFillimiShto.BackColor = System.Drawing.Color.White;
			this.dtpFillimiShto.CustomFormat = "dd.MM.yyyy";
			this.dtpFillimiShto.DefaultErrorMessage = "Ju duhet te jepni daten e fillimit  per cmimin!";
			this.dtpFillimiShto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimiShto.IsValid = true;
			this.dtpFillimiShto.Location = new System.Drawing.Point(96, 256);
			this.dtpFillimiShto.Name = "dtpFillimiShto";
			this.dtpFillimiShto.Required = true;
			this.dtpFillimiShto.ShowCheckBox = true;
			this.dtpFillimiShto.ShowUpDown = true;
			this.dtpFillimiShto.Size = new System.Drawing.Size(160, 20);
			this.dtpFillimiShto.TabIndex = 63;
			this.dtpFillimiShto.Value = new System.DateTime(2005, 9, 2, 11, 56, 0, 0);
			// 
			// label13
			// 
			this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label13.Location = new System.Drawing.Point(24, 256);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(60, 20);
			this.label13.TabIndex = 62;
			this.label13.Text = "Date fillimi";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnPastro
			// 
			this.btnPastro.BackColor = System.Drawing.Color.Blue;
			this.btnPastro.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPastro.DoValidation = false;
			this.btnPastro.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnPastro.Location = new System.Drawing.Point(456, 20);
			this.btnPastro.Name = "btnPastro";
			this.btnPastro.Size = new System.Drawing.Size(70, 22);
			this.btnPastro.TabIndex = 53;
			this.btnPastro.Text = "Pastro";
			this.btnPastro.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnPastro.Click += new System.EventHandler(this.btnPastro_Click);
			// 
			// btnMajtas
			// 
			this.btnMajtas.BackColor = System.Drawing.Color.Blue;
			this.btnMajtas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMajtas.DoValidation = false;
			this.btnMajtas.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnMajtas.Location = new System.Drawing.Point(268, 156);
			this.btnMajtas.Name = "btnMajtas";
			this.btnMajtas.Size = new System.Drawing.Size(90, 21);
			this.btnMajtas.TabIndex = 25;
			this.btnMajtas.Text = "<<<Kalo";
			this.toolTips.SetToolTip(this.btnMajtas, "Heq dhomat  e zgjedhura nga lista e dhomave qe do t\'i atribohet cmimi!");
			this.btnMajtas.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnMajtas.Click += new System.EventHandler(this.btnMajtas_Click);
			// 
			// btnDjathtas
			// 
			this.btnDjathtas.BackColor = System.Drawing.Color.Blue;
			this.btnDjathtas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDjathtas.DoValidation = false;
			this.btnDjathtas.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDjathtas.Location = new System.Drawing.Point(268, 124);
			this.btnDjathtas.Name = "btnDjathtas";
			this.btnDjathtas.Size = new System.Drawing.Size(90, 21);
			this.btnDjathtas.TabIndex = 24;
			this.btnDjathtas.Text = "Kalo>>>";
			this.toolTips.SetToolTip(this.btnDjathtas, "Shton dhomat e zgjedhura ne listen e dhomave qe do t\'i atribohet cmimi!");
			this.btnDjathtas.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnDjathtas.Click += new System.EventHandler(this.btnDjathtas_Click);
			// 
			// label10
			// 
			this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label10.Location = new System.Drawing.Point(368, 48);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(108, 20);
			this.label10.TabIndex = 23;
			this.label10.Text = "Dhomat e zgjedhura";
			// 
			// lbDhomat
			// 
			this.lbDhomat.BackColor = System.Drawing.Color.Transparent;
			this.lbDhomat.DefaultErrorMessage = "Ju duhet te zgjidhni dhomat per rezervim!";
			this.lbDhomat.IsValid = false;
			this.lbDhomat.Kolone1Vlere = "";
			this.lbDhomat.Kolone2Vlere = "";
			this.lbDhomat.Location = new System.Drawing.Point(368, 72);
			this.lbDhomat.Name = "lbDhomat";
			this.lbDhomat.Required = true;
			this.lbDhomat.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbDhomat.Size = new System.Drawing.Size(160, 180);
			this.lbDhomat.SkipValidation = false;
			this.lbDhomat.TabIndex = 22;
			// 
			// lbDhomatKategori
			// 
			this.lbDhomatKategori.BackColor = System.Drawing.Color.Transparent;
			this.lbDhomatKategori.DefaultErrorMessage = "Kategoria qe keni zgjedhur nuk ka asnje dhome!";
			this.lbDhomatKategori.IsValid = true;
			this.lbDhomatKategori.Kolone1Vlere = "";
			this.lbDhomatKategori.Kolone2Vlere = "";
			this.lbDhomatKategori.Location = new System.Drawing.Point(96, 72);
			this.lbDhomatKategori.Name = "lbDhomatKategori";
			this.lbDhomatKategori.Required = false;
			this.lbDhomatKategori.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbDhomatKategori.Size = new System.Drawing.Size(160, 180);
			this.lbDhomatKategori.SkipValidation = true;
			this.lbDhomatKategori.TabIndex = 21;
			// 
			// cmbKategorite
			// 
			this.cmbKategorite.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategorite.DefaultErrorMessage = "Zgjidhni nje prej kategorive!";
			this.cmbKategorite.IsValid = false;
			this.cmbKategorite.Kolone1Vlere = null;
			this.cmbKategorite.Kolone2Vlere = null;
			this.cmbKategorite.Location = new System.Drawing.Point(96, 20);
			this.cmbKategorite.Name = "cmbKategorite";
			this.cmbKategorite.ReadOnly = false;
			this.cmbKategorite.Required = true;
			this.cmbKategorite.Size = new System.Drawing.Size(160, 21);
			this.cmbKategorite.SkipValidation = false;
			this.cmbKategorite.TabIndex = 20;
			this.cmbKategorite.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategorite_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label9.Location = new System.Drawing.Point(12, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 20);
			this.label9.TabIndex = 19;
			this.label9.Text = "Kategoria";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label8.Location = new System.Drawing.Point(96, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(132, 20);
			this.label8.TabIndex = 10;
			this.label8.Text = "Dhomat per kategori";
			// 
			// numCmimiShto
			// 
			this.numCmimiShto.AutoSize = false;
			this.numCmimiShto.DefaultErrorMessage = "Ju duhet te caktoni nje vlere per cmimin!";
			this.numCmimiShto.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numCmimiShto.DigitsAfterDecimalPoint = 0;
			this.numCmimiShto.FixedLength = false;
			this.numCmimiShto.IsValid = false;
			this.numCmimiShto.KeepFocus = false;
			this.numCmimiShto.Location = new System.Drawing.Point(96, 312);
			this.numCmimiShto.Name = "numCmimiShto";
			this.numCmimiShto.OnlyPositive = true;
			this.numCmimiShto.Required = true;
			this.numCmimiShto.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimiShto.Size = new System.Drawing.Size(160, 21);
			this.numCmimiShto.TabIndex = 17;
			this.numCmimiShto.Text = "";
			this.numCmimiShto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(20, 312);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 20);
			this.label5.TabIndex = 16;
			this.label5.Text = "Cmimi";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnShto
			// 
			this.btnShto.BackColor = System.Drawing.Color.Blue;
			this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShto.DoValidation = true;
			this.btnShto.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShto.Location = new System.Drawing.Point(108, 360);
			this.btnShto.Name = "btnShto";
			this.btnShto.Size = new System.Drawing.Size(90, 21);
			this.btnShto.TabIndex = 23;
			this.btnShto.Text = "Shto";
			this.toolTips.SetToolTip(this.btnShto, "Shton cmimin per dhomat e zgjedhura!");
			this.btnShto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShto.Click += new System.EventHandler(this.btnShto_Click_1);
			// 
			// tbModifiko
			// 
			this.tbModifiko.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbModifiko.Controls.Add(this.groupBox4);
			this.tbModifiko.Controls.Add(this.btnElemino);
			this.tbModifiko.Controls.Add(this.btnModifiko);
			this.tbModifiko.Controls.Add(this.btnKerko);
			this.tbModifiko.Controls.Add(this.groupBox1);
			this.tbModifiko.Controls.Add(this.groupBox2);
			this.tbModifiko.DefaultErrorMessage = null;
			this.tbModifiko.EnableValidation = true;
			this.tbModifiko.IsValid = false;
			this.tbModifiko.Location = new System.Drawing.Point(4, 22);
			this.tbModifiko.Name = "tbModifiko";
			this.tbModifiko.Size = new System.Drawing.Size(1003, 583);
			this.tbModifiko.TabIndex = 1;
			this.tbModifiko.Text = "Modifiko/Fshi";
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.dtpFillimi);
			this.groupBox4.Controls.Add(this.numCmimi);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.dtpMbarimi);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.txtEmerDhoma);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(488, 124);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(268, 136);
			this.groupBox4.TabIndex = 25;
			this.groupBox4.Text = "Modifikimi i cmimeve per dhomat";
			this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// dtpFillimi
			// 
			this.dtpFillimi.BackColor = System.Drawing.Color.White;
			this.dtpFillimi.CustomFormat = "dd.MM.yyyy";
			this.dtpFillimi.DefaultErrorMessage = "";
			this.dtpFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimi.IsValid = true;
			this.dtpFillimi.Location = new System.Drawing.Point(84, 48);
			this.dtpFillimi.Name = "dtpFillimi";
			this.dtpFillimi.Required = true;
			this.dtpFillimi.ShowCheckBox = true;
			this.dtpFillimi.ShowUpDown = true;
			this.dtpFillimi.Size = new System.Drawing.Size(160, 20);
			this.dtpFillimi.TabIndex = 5;
			this.dtpFillimi.Value = new System.DateTime(2005, 9, 2, 11, 56, 0, 0);
			// 
			// numCmimi
			// 
			this.numCmimi.AutoSize = false;
			this.numCmimi.DefaultErrorMessage = "Ju duhet te caktoni nje cmim per dhomen!";
			this.numCmimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numCmimi.DigitsAfterDecimalPoint = 0;
			this.numCmimi.FixedLength = false;
			this.numCmimi.IsValid = false;
			this.numCmimi.KeepFocus = false;
			this.numCmimi.Location = new System.Drawing.Point(84, 104);
			this.numCmimi.Name = "numCmimi";
			this.numCmimi.OnlyPositive = true;
			this.numCmimi.Required = true;
			this.numCmimi.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimi.Size = new System.Drawing.Size(160, 21);
			this.numCmimi.TabIndex = 9;
			this.numCmimi.Text = "";
			this.numCmimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Location = new System.Drawing.Point(12, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Cmimi";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpMbarimi
			// 
			this.dtpMbarimi.BackColor = System.Drawing.Color.White;
			this.dtpMbarimi.CustomFormat = "dd.MM.yyyy";
			this.dtpMbarimi.DefaultErrorMessage = "";
			this.dtpMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimi.IsValid = true;
			this.dtpMbarimi.Location = new System.Drawing.Point(84, 76);
			this.dtpMbarimi.Name = "dtpMbarimi";
			this.dtpMbarimi.Required = true;
			this.dtpMbarimi.ShowCheckBox = true;
			this.dtpMbarimi.ShowUpDown = true;
			this.dtpMbarimi.Size = new System.Drawing.Size(160, 20);
			this.dtpMbarimi.TabIndex = 7;
			this.dtpMbarimi.Value = new System.DateTime(2005, 9, 2, 11, 56, 0, 0);
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(4, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Date mbarimi";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Date fillimi";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmerDhoma
			// 
			this.txtEmerDhoma.AutoSize = false;
			this.txtEmerDhoma.DefaultErrorMessage = "Zgjidhni nje prej cmimeve!";
			this.txtEmerDhoma.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmerDhoma.FixedLength = false;
			this.txtEmerDhoma.IsValid = false;
			this.txtEmerDhoma.Location = new System.Drawing.Point(84, 20);
			this.txtEmerDhoma.Name = "txtEmerDhoma";
			this.txtEmerDhoma.ReadOnly = true;
			this.txtEmerDhoma.Required = true;
			this.txtEmerDhoma.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmerDhoma.Size = new System.Drawing.Size(160, 21);
			this.txtEmerDhoma.TabIndex = 3;
			this.txtEmerDhoma.Text = "";
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(24, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Dhoma";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnElemino
			// 
			this.btnElemino.BackColor = System.Drawing.Color.Blue;
			this.btnElemino.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnElemino.DoValidation = true;
			this.btnElemino.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnElemino.Location = new System.Drawing.Point(636, 272);
			this.btnElemino.Name = "btnElemino";
			this.btnElemino.Size = new System.Drawing.Size(90, 21);
			this.btnElemino.TabIndex = 24;
			this.btnElemino.Text = "Elemino";
			this.toolTips.SetToolTip(this.btnElemino, "Eleminon cmimin e zgjedhur!");
			this.btnElemino.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnElemino.Click += new System.EventHandler(this.btnElemino_Click_1);
			// 
			// btnModifiko
			// 
			this.btnModifiko.BackColor = System.Drawing.Color.Blue;
			this.btnModifiko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifiko.DoValidation = true;
			this.btnModifiko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifiko.Location = new System.Drawing.Point(516, 272);
			this.btnModifiko.Name = "btnModifiko";
			this.btnModifiko.Size = new System.Drawing.Size(90, 21);
			this.btnModifiko.TabIndex = 23;
			this.btnModifiko.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifiko, "Modifikon cmimin e zgjedhur!");
			this.btnModifiko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click_1);
			// 
			// btnKerko
			// 
			this.btnKerko.BackColor = System.Drawing.Color.Blue;
			this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko.DoValidation = false;
			this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko.Location = new System.Drawing.Point(292, 52);
			this.btnKerko.Name = "btnKerko";
			this.btnKerko.Size = new System.Drawing.Size(90, 21);
			this.btnKerko.TabIndex = 19;
			this.btnKerko.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko, "Kerkon per cmimet qe plotesojne kriteret e zgjedhura!");
			this.btnKerko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click_1);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.grid1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(10, 124);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(466, 292);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.Text = "Cmimet per dhomat";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// grid1
			// 
			this.grid1.AllowSorting = false;
			this.grid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.grid1.CanDelete = true;
			this.grid1.CaptionVisible = false;
			this.grid1.DataMember = "";
			this.grid1.GridLineColor = System.Drawing.SystemColors.ControlText;
			this.grid1.HeaderBackColor = System.Drawing.SystemColors.InactiveCaption;
			this.grid1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grid1.HideHorizontalScrollBar = false;
			this.grid1.HideVerticalScrollBar = false;
			this.grid1.Location = new System.Drawing.Point(12, 20);
			this.grid1.Name = "grid1";
			this.grid1.RowHeaderWidth = 36;
			this.grid1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
			this.grid1.Selekto = true;
			this.grid1.Size = new System.Drawing.Size(440, 260);
			this.grid1.TabIndex = 6;
			this.grid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																							  this.MyStyle});
			this.toolTips.SetToolTip(this.grid1, "Zgjidhni nje prej cmimeve per ta modifikuar ose eleminuar!");
			this.grid1.CurrentCellChanged += new System.EventHandler(this.grid1_CurrentCellChanged_1);
			// 
			// MyStyle
			// 
			this.MyStyle.DataGrid = this.grid1;
			this.MyStyle.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																									  this.colDhoma,
																									  this.colCmimi,
																									  this.colFillimi,
																									  this.colMbarimi,
																									  this.colIdCmimi});
			this.MyStyle.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.MyStyle.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.MyStyle.MappingName = "";
			this.MyStyle.RowHeadersVisible = false;
			this.MyStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
			// 
			// colDhoma
			// 
			this.colDhoma.Format = "";
			this.colDhoma.FormatInfo = null;
			this.colDhoma.HeaderText = "Dhoma";
			this.colDhoma.MappingName = "";
			this.colDhoma.Width = 75;
			// 
			// colCmimi
			// 
			this.colCmimi.Format = "";
			this.colCmimi.FormatInfo = null;
			this.colCmimi.HeaderText = "Cmimi";
			this.colCmimi.MappingName = "";
			this.colCmimi.Width = 75;
			// 
			// colFillimi
			// 
			this.colFillimi.Format = "";
			this.colFillimi.FormatInfo = null;
			this.colFillimi.HeaderText = "Date fillimi";
			this.colFillimi.MappingName = "";
			this.colFillimi.Width = 75;
			// 
			// colMbarimi
			// 
			this.colMbarimi.Format = "";
			this.colMbarimi.FormatInfo = null;
			this.colMbarimi.HeaderText = "Mbarimi";
			this.colMbarimi.MappingName = "";
			this.colMbarimi.Width = 75;
			// 
			// colIdCmimi
			// 
			this.colIdCmimi.Format = "";
			this.colIdCmimi.FormatInfo = null;
			this.colIdCmimi.HeaderText = "IdCmimi";
			this.colIdCmimi.MappingName = "";
			this.colIdCmimi.Width = 75;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.cmbDhomatModifikime);
			this.groupBox2.Controls.Add(this.cmbKategoriteModifikime);
			this.groupBox2.Controls.Add(this.dtpDate);
			this.groupBox2.Controls.Add(this.rbDhoma);
			this.groupBox2.Controls.Add(this.rbData);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(270, 112);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.Text = "Kerkim sipas";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbDhomatModifikime
			// 
			this.cmbDhomatModifikime.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhomatModifikime.DefaultErrorMessage = "Ju duhet te jepni emrin e dhomes!";
			this.cmbDhomatModifikime.IsValid = true;
			this.cmbDhomatModifikime.Kolone1Vlere = null;
			this.cmbDhomatModifikime.Kolone2Vlere = null;
			this.cmbDhomatModifikime.Location = new System.Drawing.Point(92, 72);
			this.cmbDhomatModifikime.Name = "cmbDhomatModifikime";
			this.cmbDhomatModifikime.ReadOnly = false;
			this.cmbDhomatModifikime.Required = false;
			this.cmbDhomatModifikime.Size = new System.Drawing.Size(160, 21);
			this.cmbDhomatModifikime.SkipValidation = false;
			this.cmbDhomatModifikime.TabIndex = 6;
			// 
			// cmbKategoriteModifikime
			// 
			this.cmbKategoriteModifikime.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategoriteModifikime.DefaultErrorMessage = null;
			this.cmbKategoriteModifikime.IsValid = true;
			this.cmbKategoriteModifikime.Kolone1Vlere = null;
			this.cmbKategoriteModifikime.Kolone2Vlere = null;
			this.cmbKategoriteModifikime.Location = new System.Drawing.Point(92, 44);
			this.cmbKategoriteModifikime.Name = "cmbKategoriteModifikime";
			this.cmbKategoriteModifikime.ReadOnly = false;
			this.cmbKategoriteModifikime.Required = false;
			this.cmbKategoriteModifikime.Size = new System.Drawing.Size(160, 21);
			this.cmbKategoriteModifikime.SkipValidation = false;
			this.cmbKategoriteModifikime.TabIndex = 5;
			this.cmbKategoriteModifikime.Load += new System.EventHandler(this.cmbKategoriteModifikime_Load);
			this.cmbKategoriteModifikime.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategoriteModifikime_SelectedIndexChanged);
			// 
			// dtpDate
			// 
			this.dtpDate.BackColor = System.Drawing.Color.White;
			this.dtpDate.CustomFormat = "dd.MM.yyyy";
			this.dtpDate.DefaultErrorMessage = "";
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.IsValid = true;
			this.dtpDate.Location = new System.Drawing.Point(92, 16);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Required = false;
			this.dtpDate.ShowCheckBox = true;
			this.dtpDate.ShowUpDown = true;
			this.dtpDate.Size = new System.Drawing.Size(160, 20);
			this.dtpDate.TabIndex = 4;
			this.dtpDate.Value = new System.DateTime(2005, 9, 2, 11, 56, 0, 0);
			// 
			// rbDhoma
			// 
			this.rbDhoma.Location = new System.Drawing.Point(8, 48);
			this.rbDhoma.Name = "rbDhoma";
			this.rbDhoma.Size = new System.Drawing.Size(76, 24);
			this.rbDhoma.TabIndex = 3;
			this.rbDhoma.Text = "Kategorise";
			// 
			// rbData
			// 
			this.rbData.Location = new System.Drawing.Point(8, 16);
			this.rbData.Name = "rbData";
			this.rbData.Size = new System.Drawing.Size(76, 24);
			this.rbData.TabIndex = 3;
			this.rbData.Text = "Dates";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(20, 76);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 20);
			this.label6.TabIndex = 26;
			this.label6.Text = "Dhoma";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ds
			// 
			this.ds.DataSetName = "NewDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// KonfiguroCmime
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(866, 482);
			this.Controls.Add(this.tab);
			this.HelpFile = "CMIME.htm";
			this.IsValid = true;
			this.Name = "KonfiguroCmime";
			this.Text = "Cmimet";
			this.TitullGjeresi = 1011;
			this.Load += new System.EventHandler(this.KonfiguroCmime_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.tab, 0);
			this.tab.ResumeLayout(false);
			this.tbShto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.tbModifiko.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		
		#region LoadForm
		private void KonfiguroCmime_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				//pastrim variablash private
				this.idKategoria = 0;
				this.ds.Tables.Clear();
				this.vekKategori = null;
				this.numer_rreshtash = 0;
				dtpDate.Value = DateTime.Now;
				label6.ForeColor = System.Drawing.Color.Black;
				//pastrim variablash private
				DataSet ds1 = null;
				InputController data = new InputController();
				ds1 = data.KerkesaRead("ShfaqKategorite");
				// Percaktojme gjatesine e vektorit qe mbaje vlerat e idKategori-se
				int nrRreshta = ds1.Tables[0].Rows.Count;
				vekKategori = new string[nrRreshta];
				foreach(DataRow dr in ds1.Tables[0].Rows)
				{
					this.cmbKategorite.Kolone1.Items.Add(dr[1]);
					this.cmbKategorite.Kolone2.Items.Add(dr[0]);
				}
				DateTime dataKerkimi = System.DateTime.Now;
				ds = data.KerkesaRead("ShfaqCmimetEdhomavePerDatenEdhene", dataKerkimi);
				numer_rreshtash = ds.Tables[0].Rows.Count;
				grid1.DataSource = ds.Tables[0];
				if (numer_rreshtash <= 14)
					this.grid1.Width = 424;
				else
					this.grid1.Width = 440;
				KrijoStilGrid();
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
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void cmbKategoriteModifikime_Load(object sender, System.EventArgs e)
		{
			try
			{
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqKategorite");
				// Percaktojme gjatesine e vektorit qe mbaje vlerat e idKategori-se
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbKategoriteModifikime.Kolone1.Items.Add(dr[1]);
					this.cmbKategoriteModifikime.Kolone2.Items.Add(dr[0]);
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

		private void tab_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				if (this.tab.SelectedIndex == 0)//shtimi i cmimeve
				{
					this.Pastro(this.groupBox3);
					this.lbDhomatKategori.Kolone1.Text = "";
					this.lbDhomatKategori.Kolone2.Text = "";
					this.lbDhomat.Kolone1.Items.Clear();
					this.lbDhomat.Kolone2.Items.Clear();
					lbDhomatKategori.Kolone1.Items.Clear();
					lbDhomatKategori.Kolone2.Items.Clear();
				}
				else//modifikimi i cmimeve
				{
					InputController data = new InputController();
					this.Pastro(this.groupBox4);
					DateTime dataKerkimi = System.DateTime.Now;
					ds = data.KerkesaRead("ShfaqCmimetEdhomavePerDatenEdhene", dataKerkimi);
					numer_rreshtash = ds.Tables[0].Rows.Count;
					grid1.DataSource = ds.Tables[0];
					if (numer_rreshtash <= 14)
						this.grid1.Width = 424;
					else
						this.grid1.Width = 440;
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

		#region ShtoCmimMethods
		private void btnShto_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimiShto.Value);
				DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimiShto.Value);
				int a = this.KntData(dataFillimi,dataMbarimi);
				if(a == 0)
				{
					int b = 0;
					int cmimi = Convert.ToInt32(this.numCmimiShto.Text);
					int nrDhoma = this.lbDhomat.Kolone1.Items.Count;
					for(int i = 0;i < nrDhoma; i++)
					{
						int idDhoma = Convert.ToInt32(this.lbDhomat.Kolone2.Items[i]);
						InputController data = new InputController();
						b = data.KerkesaUpdate("KrijoCmimPerDhome", idDhoma, cmimi, dataFillimi, dataMbarimi);
				
					}
			
					if (b == 0)
						System.Windows.Forms.MessageBox.Show(this,
							"Cmimet e dhomave u shtuan!",  "Konfigurimi i cmimeve",MessageBoxButtons.OK, MessageBoxIcon.Information);
					else if (b != 0 )
					{
						System.Windows.Forms.MessageBox.Show(this,
							"Per  nje ose me shume nga dhomat e dhena,"+
							Environment.NewLine+"cmimi nuk mund te shtohet pasi eshte konfiguruar me pare!"+
							Environment.NewLine+"Cmimet e konfiguruar per dhomat mund t'i shihni dhe modifikoni ne pjesen Modifiko/Fshi!", "Konfigurimi i cmimeve",MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					this.RefreshShtoCmim();
				}
				else if (a == 1)
				{
					this.dtpFillimiShto.IsValid = false;
					this.error.SetError(this.dtpFillimiShto, "Data e fillimit te nje cmimi duhet te jete me e vogel se data e mbarimit!");
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
				return;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void cmbKategorite_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{	
			try
			{
				this.lbDhomat.Kolone1.Items.Clear();
				this.lbDhomat.Kolone2.Items.Clear();
				this.lbDhomatKategori.Kolone1.Items.Clear();
				this.lbDhomatKategori.Kolone2.Items.Clear();
				this.dtpFillimiShto.Value = System.DateTime.Now;
				this.dtpMbarimiShto.Value = System.DateTime.Now;
			
				DataSet ds = null;
				idKategoria = Convert.ToInt32(this.cmbKategorite.Kolone2Vlere);
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqDhomatPerKategorine", idKategoria);
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					this.lbDhomatKategori.Kolone1.Items.Add(dr[0]);
					this.lbDhomatKategori.Kolone2.Items.Add(dr[1]);
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
	
		private void mbushKategorite()
		{
			DataSet ds = null ;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqKategorite");
		}

		private void btnPastro_Click(object sender, System.EventArgs e)
		{
			this.cmbKategorite.Kolone1.Text = "";
			this.lbDhomatKategori.Kolone1.Items.Clear();
			this.lbDhomatKategori.Kolone2.Items.Clear();
			this.lbDhomat.Kolone1.Items.Clear();
			this.lbDhomat.Kolone2.Items.Clear();
			this.numCmimiShto.Text = "";
			this.dtpFillimiShto.Value = System.DateTime.Now;
			this.dtpMbarimiShto.Value = System.DateTime.Now;
		}

		private void RefreshShtoCmim()
		{
			this.dtpFillimiShto.Value = System.DateTime.Now;
			this.dtpMbarimiShto.Value = System.DateTime.Now;
			this.numCmimiShto.Text = "";
			this.lbDhomat.Kolone1.Items.Clear();
			this.lbDhomat.Kolone2.Items.Clear();
		}
		
		#endregion

		#region ModifikoCmimMethods
		private void btnKerko_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				DataSet ds = null;
				int numer_rreshtash = 0;
				this.Pastro(this.groupBox4);
				if (rbData.Checked == true)
				{
					DateTime dataKerkimi = Convert.ToDateTime(this.dtpDate.Value);
					InputController data = new InputController();
					ds = data.KerkesaRead("ShfaqCmimetEdhomavePerDatenEdhene", dataKerkimi);
					numer_rreshtash = Convert.ToInt32(ds.Tables[0].Rows.Count);
					if(numer_rreshtash == 0)
					{
						this.grid1.DataSource = null;
						System.Windows.Forms.MessageBox.Show(this, "Per daten e kerkuar cmimet e dhomave nuk jane konfiguruar!", "Konfigurimi i cmimeve", 
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					else
						grid1.DataSource = ds.Tables[0];
				}
				else if (rbDhoma.Checked == true)
				{
					int idDhoma = Convert.ToInt32(this.cmbDhomatModifikime.Kolone2Vlere);
					int idKategoria = Convert.ToInt32(this.cmbKategoriteModifikime.Kolone2Vlere);
					if(idKategoria == 0)
					{
						this.cmbKategoriteModifikime.IsValid = false;
						this.error.SetError(this.cmbKategoriteModifikime , "Ju duhet te zgjidhni kategorine e dhomave per kerkim!");
					}
					else
					{
						InputController data = new InputController();
						if(this.cmbDhomatModifikime.Kolone1.Text == "")
						{
							ds = data.KerkesaRead("ShfaqCmimetPerKategorineEdhene", idKategoria);
							numer_rreshtash = Convert.ToInt32(ds.Tables[0].Rows.Count);
							if(numer_rreshtash == 0)
							{
								this.grid1.DataSource = null;
								System.Windows.Forms.MessageBox.Show(this, "Per kategorine e dhene cmimet e dhomave nuk jane konfiguruar!", "Konfigurimi i cmimeve",
									MessageBoxButtons.OK, MessageBoxIcon.Information);
							
							}
							else
								grid1.DataSource = ds.Tables[0];
						}
						else
						{
							ds = data.KerkesaRead("ShfaqCmimetPerDhomenEdhene", idDhoma);
							numer_rreshtash = Convert.ToInt32(ds.Tables[0].Rows.Count);
							if(numer_rreshtash == 0)
							{
								this.grid1.DataSource = null;
								System.Windows.Forms.MessageBox.Show(this, "Per dhomen e dhene cmimet nuk jane konfiguruar!", "Konfigurimi i çmimeve",
									MessageBoxButtons.OK, MessageBoxIcon.Information);
							
							}
							else
								grid1.DataSource = ds.Tables[0];
						}
					}
				}
				if (numer_rreshtash <= 14)
					this.grid1.Width = 424;
				else
					this.grid1.Width = 440;
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

		private void btnModifiko_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				DateTime dateFillimi = Convert.ToDateTime(this.dtpFillimi.Value);
				DateTime dateMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
				int index = this.grid1.CurrentRowIndex;
				DateTime dateFillimiVjeter = Convert.ToDateTime(grid1[index, 7].ToString());
				DateTime dateMbarimiVjeter = Convert.ToDateTime(grid1[index, 8].ToString());
				int a = this.KntData(dateFillimi,dateMbarimi);
				if(a == 0)
				{
					DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Konfigurimi i cmimeve",
						"Jeni te sigurte qe doni te modifikoni cmimin e dhomes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result != DialogResult.Yes)
						return;
			
					int b = 0; 
			
					int i = this.grid1.CurrentRowIndex;
					string emerDhoma = this.txtEmerDhoma.Text;
					int idDhoma = Convert.ToInt32(this.grid1[i, 5]); // vlera merret nga grida
					int idCmimi = Convert.ToInt32(this.grid1[i, 6]); // vlera merret nga grida
					DateTime dateRezervimi = Convert.ToDateTime(this.dtpDate.Value);
					int cmimiDhoma = Convert.ToInt32(this.numCmimi.Text);
					InputController data = new InputController();
					b = data.KerkesaUpdate("ModifikoCmimiPerDhomen",idDhoma,idCmimi, dateFillimi, dateMbarimi, cmimiDhoma, dateFillimiVjeter, dateMbarimiVjeter );
					if (b == 0)
					{
						this.RefreshControls();
						this.RefreshCmbDhomat();				
						System.Windows.Forms.MessageBox.Show(this,  "Cmimi i dhomes u modifikua!", "Konfigurimi i cmimeve",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (b == 4)
						System.Windows.Forms.MessageBox.Show(this, "Cmimi i dhomes nuk mund te modifikohet!" +Environment.NewLine + "Per datat korrente te cmimit te dhomes ne hotel ka rezervime!", "Konfigurimi i cmimeve", 
							MessageBoxButtons.OK, MessageBoxIcon.Error);
				
					else if (b == 5)
						System.Windows.Forms.MessageBox.Show(this,  "Cmimi i dhomes nuk mund te modifikohet!" + Environment.NewLine + "Per datat korrente cmimit te dhomes ne hotel ka kliente te regjistuar!", "Konfigurimi i cmimeve",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					else if( b == 1)
						System.Windows.Forms.MessageBox.Show(this, "Cmimi i dhomes nuk mund te modifikohet!"+
							Environment.NewLine+"Per daten e fillimit te dhene cmimi i dhomes eshte konfiguruar me pare!", 
							"Konfigurimi i cmimeve",MessageBoxButtons.OK, MessageBoxIcon.Error);
					else if(b == 2)
						System.Windows.Forms.MessageBox.Show(this, "Cmimi i dhomes nuk mund te modifikohet!"+
							Environment.NewLine+"Per daten e mbarimit te dhene cmimi i dhomes eshte konfiguruar me pare!", 
							"Konfigurimi i cmimeve",MessageBoxButtons.OK, MessageBoxIcon.Error);
					else if(b == 3)
						System.Windows.Forms.MessageBox.Show(this, "Cmimi i dhomes nuk mund te modifikohet!"+
							Environment.NewLine+"Per datat e dhena cmimi i dhomes eshte konfiguruar me pare!", 
							"Konfigurimi i cmimeve",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					this.dtpFillimi.IsValid = false;
					this.error.SetError(this.dtpFillimi, "Data e fillimit per cmimin duhet te jete me e vogel se data e mbarimit!");
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
				return;
			}
		}

		private void btnElemino_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Konfigurimi i cmimeve",
					"Jeni të sigurtë që doni të fshini cmimin e dhomës?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result != DialogResult.Yes)
					return;
			
				int b = 0;
				int i = this.grid1.CurrentRowIndex;
				int idDhoma = Convert.ToInt32(this.grid1[i, 5]); // vlera merret nga grida
				int idCmimi = Convert.ToInt32(this.grid1[i, 6]); // vlera merret nga grida
				DateTime dateFillimi = Convert.ToDateTime(this.dtpFillimi.Value);
				DateTime dateMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
				int cmimiDhoma = Convert.ToInt32(this.numCmimi.Text);
				InputController data = new InputController();
				b = data.KerkesaUpdate("FshiCmimiPerDhomen", idDhoma, idCmimi,dateFillimi, dateMbarimi, cmimiDhoma );
				if (b == 0)
				{
					this.RefreshControls();
					this.RefreshCmbDhomat();
					//msgbox CmimiDhoma i zgjedhur u modifikua		
					System.Windows.Forms.MessageBox.Show(this,  "Cmimi i dhomes u eleminua", "Konfigurimi i cmimeve",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (b == 1)
				{
					this.RefreshControls();
					this.RefreshCmbDhomat();
					System.Windows.Forms.MessageBox.Show(this,  "Cmimi i dhomes nuk mund te eleminohet,"+ Environment.NewLine +"pasi per datat e cmimit per dhomen ka rezervime ne hotel!", "Konfigurimi i cmimeve",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else	if (b == 2)
				{
					this.RefreshControls();
					this.RefreshCmbDhomat();
				
					System.Windows.Forms.MessageBox.Show(this, "Cmimi i dhomes nuk mund te eleminohet,"+ Environment.NewLine +"pasi per datat e cmimit per dhomen ka hyrje ne hotel!", "Konfigurimi i cmimeve", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void KrijoStilGrid()
		{
			grid1.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			this.grid1.ReadOnly = true;

			DataGridTextBoxColumn colKategoria = new DataGridTextBoxColumn();
			colKategoria.HeaderText = "Kategoria";
			colKategoria.MappingName = "KAT_EMRI";
			colKategoria.Width = 90;

			DataGridTextBoxColumn colDhoma = new DataGridTextBoxColumn();
			colDhoma .HeaderText = "Dhoma";
			colDhoma .MappingName = "DHOMA_EMRI";
			colDhoma .Width = 95;
			colDhoma .TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));

			DataGridTextBoxColumn colDateFillimi1 = new DataGridTextBoxColumn();
			colDateFillimi1.HeaderText = "Date Fillimi";
			colDateFillimi1.MappingName = "DATA_FILLIMI_STR";
			colDateFillimi1.Width = 90;
			colDateFillimi1.NullText = "";

			DataGridTextBoxColumn colDateMbarimi1 = new DataGridTextBoxColumn();
			colDateMbarimi1 .HeaderText = "Date Mbarimi";
			colDateMbarimi1 .MappingName = "DATA_MBARIMI_STR";
			colDateMbarimi1 .Width = 90;
			colDateMbarimi1 .NullText = "";

			DataGridTextBoxColumn colDateFillimi = new DataGridTextBoxColumn();
			colDateFillimi.HeaderText = "Date Fillimi";
			colDateFillimi.MappingName = "DATA_FILLIMI";
			colDateFillimi.Width = 0;
			colDateFillimi.NullText = "";

			DataGridTextBoxColumn colDateMbarimi = new DataGridTextBoxColumn();
			colDateMbarimi .HeaderText = "Date Mbarimi";
			colDateMbarimi .MappingName = "DATA_MBARIMI";
			colDateMbarimi .Width = 0;
			colDateMbarimi .NullText = "";

			DataGridTextBoxColumn colCmimi = new DataGridTextBoxColumn();
			colCmimi.HeaderText = "Cmimi";
			colCmimi.MappingName = "CMIMI";
			colCmimi.Width = 54;

			DataGridTextBoxColumn colIdDhoma = new DataGridTextBoxColumn();
			colIdDhoma.HeaderText = "IdDhoma";
			colIdDhoma.MappingName = "ID_DHOMA";
			colIdDhoma.Width = 0;

			DataGridTextBoxColumn colIdCmimi = new DataGridTextBoxColumn();
			colIdCmimi.HeaderText = "IdCmimi";
			colIdCmimi.MappingName = "ID_CMIMI";
			colIdCmimi.Width = 0;

			style.GridColumnStyles.AddRange(
				new DataGridColumnStyle[]{ 	 colKategoria, colDhoma, 
				colDateFillimi1, colDateMbarimi1 , colCmimi, colIdDhoma, colIdCmimi, 
					colDateFillimi, colDateMbarimi});
			
			grid1.TableStyles.Add(style);
			if (((DataTable)grid1.DataSource).Rows.Count > 0)
			{
			}
			grid1.FlatMode = false;
			grid1.Expand(-1);

		}

		private void grid1_CurrentCellChanged_1(object sender, System.EventArgs e)
		{
			try
			{
				int rowIndex = grid1.CurrentRowIndex;
				this.txtEmerDhoma.Text = grid1[rowIndex, 1].ToString();
				this.dtpFillimi.Value = Convert.ToDateTime(grid1[rowIndex, 7]);
				this.dtpMbarimi.Value = Convert.ToDateTime(grid1[rowIndex, 8]);
				this.numCmimi.Text = grid1[rowIndex, 4].ToString();
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

		private void btnDjathtas_Click(object sender, System.EventArgs e)
		{
			try
			{
				int i = 0;
				int selected = this.lbDhomatKategori.Kolone1.SelectedItems.Count;
				for (i = 0; i < selected; i++)
				{   
					if (gjendetNeListe(lbDhomat, this.lbDhomatKategori.Kolone1.Items[this.lbDhomatKategori.Kolone1.SelectedIndices[i]].ToString()))
					{
					
					}
					else
					{
						this.lbDhomat.Kolone1.Items.Add(this.lbDhomatKategori.Kolone1.Items[this.lbDhomatKategori.Kolone1.SelectedIndices[i]]);
						this.lbDhomat.Kolone2.Items.Add(this.lbDhomatKategori.Kolone2.Items[this.lbDhomatKategori.Kolone1.SelectedIndices[i]]);
					}
				}
				//	i = 0;
				//	while (this.lbDhomatKategori.Kolone1.SelectedItems.Count > 0)
				//	{
				//		this.lbDhomatKategori.Kolone2.Items.Remove(this.lbDhomatKategori.Kolone2.Items[this.lbDhomatKategori.Kolone1.SelectedIndices[i]]);
				//		this.lbDhomatKategori.Kolone1.Items.Remove(this.lbDhomatKategori.Kolone1.Items[this.lbDhomatKategori.Kolone1.SelectedIndices[i]]);
				//	}
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

		private void btnMajtas_Click(object sender, System.EventArgs e)
		{
			try
			{
				int i = 0;
				System.Windows.Forms.ListBox.SelectedIndexCollection indices = this.lbDhomat.Kolone1.SelectedIndices ;
				int gjatesia = this.lbDhomat.Kolone1.SelectedIndices.Count;
				for (i = gjatesia - 1; i >= 0; i--)
				{
					this.lbDhomat.Kolone1.Items.RemoveAt(i);
					this.lbDhomat.Kolone2.Items.RemoveAt(i);
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
		
		private void cmbKategoriteModifikime_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				this.cmbDhomatModifikime.Kolone1.Text = "";
				this.cmbDhomatModifikime.Kolone1.Items.Clear();
				this.cmbDhomatModifikime.Kolone2.Items.Clear();
			
				int idKategoria = Convert.ToInt32(this.cmbKategoriteModifikime.Kolone2Vlere);
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqDhomatPerKategorine", idKategoria);
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbDhomatModifikime.Kolone1.Items.Add(dr[0]);
					this.cmbDhomatModifikime.Kolone2.Items.Add(dr[1]);
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

		private void RefreshControls()
		{
			try
			{
				DataSet ds = null;
				InputController data = new InputController();
				int idDhoma = Convert.ToInt32(this.cmbDhomatModifikime.Kolone2Vlere);
				int idKategoria = Convert.ToInt32(this.cmbKategoriteModifikime.Kolone2Vlere);
				if (rbData.Checked == true)
				{
					DateTime dataKerkimi = Convert.ToDateTime(this.dtpDate.Value);
			
					// mbushet grida ne saje te datasetit
					ds = data.KerkesaRead("ShfaqCmimetEdhomavePerDatenEdhene", dataKerkimi);
					numer_rreshtash = Convert.ToInt32(ds.Tables[0].Rows.Count);
					grid1.DataSource = ds.Tables[0];
				}
				else if (this.rbDhoma.Checked == true)
				{
				
					if(this.cmbDhomatModifikime.Kolone1.Text == "")
					{
						ds = data.KerkesaRead("ShfaqCmimetPerKategorineEdhene", idKategoria);
						numer_rreshtash = Convert.ToInt32(ds.Tables[0].Rows.Count);
						grid1.DataSource = ds.Tables[0];
					}
					else
					{
						ds = data.KerkesaRead("ShfaqCmimetPerDhomenEdhene", idDhoma);
						numer_rreshtash = Convert.ToInt32(ds.Tables[0].Rows.Count);
						grid1.DataSource = ds.Tables[0];
					}
				}
				else
				{
					ds = data.KerkesaRead("ShfaqCmimetPerDhomat");
					numer_rreshtash = ds.Tables[0].Rows.Count;
					grid1.DataSource = ds.Tables[0];
					
				}
				this.txtEmerDhoma.Text = "";
				this.dtpFillimi.Value = System.DateTime.Today;
				this.dtpMbarimi.Value = System.DateTime.Today;
				this.numCmimi.Text = "";
				this.cmbDhomatModifikime.Kolone1.Items.Clear();
				this.cmbDhomatModifikime.Kolone2.Items.Clear();
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

		private void RefreshCmbDhomat()
		{
			InputController data = new InputController();
			DataSet ds = null;
			ds = data.KerkesaRead("ShfaqDhomat");
			try
			{
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbDhomatModifikime.Kolone1.Items.Add(dr[1]);
					this.cmbDhomatModifikime.Kolone2.Items.Add(dr[0]);
				}
			}
			catch (Exception ex)
			{
			}
		}

		private int KntData(DateTime dtFillimi,DateTime dtMbarimi )
		{
			TimeSpan ts = dtMbarimi.Date.Subtract(dtFillimi.Date);
			if (Convert.ToInt32(ts.TotalDays) <= 0)
				return 1;
			else
				return 0;
				
		}

		private bool gjendetNeListe(VisionInfoSolutionLibrary.DoubleListBox lista , string fjala)
		{
			bool ugjet;
			ugjet = false;
			int i = 0;
			int gjatesia = lista.Kolone1.Items.Count;
			while ( (i < gjatesia) && (ugjet == false))
			{
				if (lista.Kolone1.Items[i].ToString() == fjala)
					ugjet = true;
			
				i = i +1;


			}
			
			return ugjet;


		}
		#endregion
		
	}
}

