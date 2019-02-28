using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using HotelManagment.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment.Forms
{
	public class ModifikoRezervim : VisionInfoSolutionLibrary.Form
	{
		#region privateVariables
		private VisionInfoSolutionLibrary.TabControl tab;
		private VisionInfoSolutionLibrary.Button btnKerko;
		private VisionInfoSolutionLibrary.GroupBox gbDatat1;
		private VisionInfoSolutionLibrary.Button btnKerko1;
		private VisionInfoSolutionLibrary.Button btnModifiko;
		private VisionInfoSolutionLibrary.Button btnElemino;
		private VisionInfoSolutionLibrary.Button btnDil;
		private VisionInfoSolutionLibrary.Button btnModifiko1;
		private VisionInfoSolutionLibrary.Button btnElemino1;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private System.Windows.Forms.ColumnHeader emriDhoma1;
		private System.Windows.Forms.ColumnHeader cmimiDhoma1;
		private System.Windows.Forms.ColumnHeader idDhoma1;
		private VisionInfoSolutionLibrary.Button button1;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.Label label7;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.Label label9;
		private VisionInfoSolutionLibrary.Label label10;
		private VisionInfoSolutionLibrary.Label label11;
		private VisionInfoSolutionLibrary.Label label12;
		private VisionInfoSolutionLibrary.Label label13;
		private VisionInfoSolutionLibrary.Label label14;
		private VisionInfoSolutionLibrary.Label label15;
		private VisionInfoSolutionLibrary.TabPageControl tabIndividuale;
		private VisionInfoSolutionLibrary.TabPageControl tabGrup;
		private VisionInfoSolutionLibrary.Label lblEmr;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.NumericBox numKapari1;
		private VisionInfoSolutionLibrary.GroupBox groupBox3;
		private VisionInfoSolutionLibrary.Label label18;
		private VisionInfoSolutionLibrary.DateTimePicker dtpNga1;
		private VisionInfoSolutionLibrary.Label label17;
		private VisionInfoSolutionLibrary.TextBox txtEmerAgjensia;
		private VisionInfoSolutionLibrary.DataGrid grid1;
		private System.Windows.Forms.DataGridTextBoxColumn colDhoma;
		private VisionInfoSolutionLibrary.DataGrid grid;
		private VisionInfoSolutionLibrary.Button btnShtoDhome;
		private VisionInfoSolutionLibrary.RadioButton rbData;
		private VisionInfoSolutionLibrary.RadioButton rbEmri;
		private VisionInfoSolutionLibrary.RadioButton rbData1;
		private VisionInfoSolutionLibrary.RadioButton rbGrupi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimiKlienti;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimiKlienti;
		private VisionInfoSolutionLibrary.NumericBox numKapariKlienti;
		private VisionInfoSolutionLibrary.TextBox txtMbiemriKlienti;
		private VisionInfoSolutionLibrary.TextBox txtEmriKlienti;
		private VisionInfoSolutionLibrary.TextBox txtGrupi1;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillKlienti;
		private VisionInfoSolutionLibrary.TextBox txtEklienti;
		private VisionInfoSolutionLibrary.TextBox txtMbKlienti;
		private VisionInfoSolutionLibrary.Label label19;
		private VisionInfoSolutionLibrary.DateTimePicker dtpRezervimi;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.Label label21;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimi1;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.Label label4;
		private VisionInfoSolutionLibrary.DateTimePicker dtRezervimi;
		private VisionInfoSolutionLibrary.ListView lvDhomatLira;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private VisionInfoSolutionLibrary.GroupBox groupBox4;
		private VisionInfoSolutionLibrary.GroupBox groupBox5;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategorite;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhoma;
		private VisionInfoSolutionLibrary.RadioButton rbRezervimeSkaduara1;
		private VisionInfoSolutionLibrary.RadioButton rbRezervimeSkaduara2;
		private VisionInfoSolutionLibrary.DoubleCombo cmbGrupi;
		private VisionInfoSolutionLibrary.Label label6;
		private VisionInfoSolutionLibrary.DoubleCombo cmbPagesaKlienti;
		private VisionInfoSolutionLibrary.Label label8;
		private VisionInfoSolutionLibrary.DoubleCombo cmbPagesaGrupi;
		private int idRezervimiGrupi;
		private DataSet ds ;
		private int idRezervimiKlienti;
		private int idDhomaKlienti;
		private System.Data.DataSet ds1;
		private VisionInfoSolutionLibrary.Label label16;
		private VisionInfoSolutionLibrary.NumericBox numCmimi;
		private VisionInfoSolutionLibrary.Label label20;
		private VisionInfoSolutionLibrary.TextBox txtEmail;
		private int idKategoriaGrupi;
		private System.Windows.Forms.ColumnHeader idKategoria1;
		private System.Windows.Forms.ColumnHeader colCmimi;
		private bool zgjedhur = false;
		#endregion

		#region ConstructorsDestructors
		public ModifikoRezervim()
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
			this.tabIndividuale = new VisionInfoSolutionLibrary.TabPageControl();
			this.btnElemino = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifiko = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnKerko1 = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.grid = new VisionInfoSolutionLibrary.DataGrid();
			this.gbDatat1 = new VisionInfoSolutionLibrary.GroupBox();
			this.rbRezervimeSkaduara1 = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbEmri = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbData = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.txtMbKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.txtEklienti = new VisionInfoSolutionLibrary.TextBox();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.lblEmr = new VisionInfoSolutionLibrary.Label();
			this.dtpFillKlienti = new VisionInfoSolutionLibrary.DateTimePicker();
			this.groupBox4 = new VisionInfoSolutionLibrary.GroupBox();
			this.txtEmail = new VisionInfoSolutionLibrary.TextBox();
			this.label20 = new VisionInfoSolutionLibrary.Label();
			this.numCmimi = new VisionInfoSolutionLibrary.NumericBox();
			this.label16 = new VisionInfoSolutionLibrary.Label();
			this.cmbPagesaKlienti = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.cmbDhoma = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbKategorite = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label11 = new VisionInfoSolutionLibrary.Label();
			this.dtpMbarimiKlienti = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpFillimiKlienti = new VisionInfoSolutionLibrary.DateTimePicker();
			this.txtMbiemriKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.label14 = new VisionInfoSolutionLibrary.Label();
			this.label12 = new VisionInfoSolutionLibrary.Label();
			this.txtEmriKlienti = new VisionInfoSolutionLibrary.TextBox();
			this.label15 = new VisionInfoSolutionLibrary.Label();
			this.label9 = new VisionInfoSolutionLibrary.Label();
			this.label10 = new VisionInfoSolutionLibrary.Label();
			this.dtpRezervimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label19 = new VisionInfoSolutionLibrary.Label();
			this.label13 = new VisionInfoSolutionLibrary.Label();
			this.numKapariKlienti = new VisionInfoSolutionLibrary.NumericBox();
			this.tabGrup = new VisionInfoSolutionLibrary.TabPageControl();
			this.groupBox3 = new VisionInfoSolutionLibrary.GroupBox();
			this.rbRezervimeSkaduara2 = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbData1 = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.txtEmerAgjensia = new VisionInfoSolutionLibrary.TextBox();
			this.label17 = new VisionInfoSolutionLibrary.Label();
			this.txtGrupi1 = new VisionInfoSolutionLibrary.TextBox();
			this.label18 = new VisionInfoSolutionLibrary.Label();
			this.dtpNga1 = new VisionInfoSolutionLibrary.DateTimePicker();
			this.rbGrupi = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.btnElemino1 = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifiko1 = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnKerko = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.grid1 = new VisionInfoSolutionLibrary.DataGrid();
			this.groupBox5 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbPagesaGrupi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label8 = new VisionInfoSolutionLibrary.Label();
			this.cmbGrupi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.button1 = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnShtoDhome = new VisionInfoSolutionLibrary.Button(this.components);
			this.dtpMbarimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpFillimi1 = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.lvDhomatLira = new VisionInfoSolutionLibrary.ListView(this.components);
			this.emriDhoma1 = new System.Windows.Forms.ColumnHeader();
			this.cmimiDhoma1 = new System.Windows.Forms.ColumnHeader();
			this.idDhoma1 = new System.Windows.Forms.ColumnHeader();
			this.idKategoria1 = new System.Windows.Forms.ColumnHeader();
			this.colCmimi = new System.Windows.Forms.ColumnHeader();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.numKapari1 = new VisionInfoSolutionLibrary.NumericBox();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.label7 = new VisionInfoSolutionLibrary.Label();
			this.dtRezervimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label21 = new VisionInfoSolutionLibrary.Label();
			this.colDhoma = new System.Windows.Forms.DataGridTextBoxColumn();
			this.ds = new System.Data.DataSet();
			this.btnDil = new VisionInfoSolutionLibrary.Button(this.components);
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.ds1 = new System.Data.DataSet();
			this.tab.SuspendLayout();
			this.tabIndividuale.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gbDatat1)).BeginInit();
			this.gbDatat1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.tabGrup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox5)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1036, 25);
			// 
			// tab
			// 
			this.tab.Controls.Add(this.tabIndividuale);
			this.tab.Controls.Add(this.tabGrup);
			this.tab.Cursor = System.Windows.Forms.Cursors.Default;
			this.tab.ItemSize = new System.Drawing.Size(57, 18);
			this.tab.Location = new System.Drawing.Point(0, 25);
			this.tab.Name = "tab";
			this.tab.Padding = new System.Drawing.Point(0, 0);
			this.tab.SelectedIndex = 0;
			this.tab.Size = new System.Drawing.Size(1011, 609);
			this.tab.TabIndex = 1;
			this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
			// 
			// tabIndividuale
			// 
			this.tabIndividuale.BackColor = System.Drawing.SystemColors.Control;
			this.tabIndividuale.Controls.Add(this.btnElemino);
			this.tabIndividuale.Controls.Add(this.btnModifiko);
			this.tabIndividuale.Controls.Add(this.btnKerko1);
			this.tabIndividuale.Controls.Add(this.groupBox2);
			this.tabIndividuale.Controls.Add(this.gbDatat1);
			this.tabIndividuale.Controls.Add(this.groupBox4);
			this.tabIndividuale.DefaultErrorMessage = null;
			this.tabIndividuale.EnableValidation = true;
			this.tabIndividuale.IsValid = false;
			this.tabIndividuale.Location = new System.Drawing.Point(4, 22);
			this.tabIndividuale.Name = "tabIndividuale";
			this.tabIndividuale.Size = new System.Drawing.Size(1003, 583);
			this.tabIndividuale.TabIndex = 0;
			this.tabIndividuale.Text = "Individuale";
			// 
			// btnElemino
			// 
			this.btnElemino.BackColor = System.Drawing.Color.Blue;
			this.btnElemino.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnElemino.DoValidation = true;
			this.btnElemino.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnElemino.Location = new System.Drawing.Point(740, 468);
			this.btnElemino.Name = "btnElemino";
			this.btnElemino.Size = new System.Drawing.Size(90, 21);
			this.btnElemino.TabIndex = 21;
			this.btnElemino.Text = "Elemino";
			this.toolTips.SetToolTip(this.btnElemino, "Eleminon rezervimin e zgjedhur!");
			this.btnElemino.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnElemino.Click += new System.EventHandler(this.btnElemino_Click);
			// 
			// btnModifiko
			// 
			this.btnModifiko.BackColor = System.Drawing.Color.Blue;
			this.btnModifiko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifiko.DoValidation = true;
			this.btnModifiko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifiko.Location = new System.Drawing.Point(620, 468);
			this.btnModifiko.Name = "btnModifiko";
			this.btnModifiko.Size = new System.Drawing.Size(90, 21);
			this.btnModifiko.TabIndex = 20;
			this.btnModifiko.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifiko, "Modifikon rezervimin e zgjedhur!");
			this.btnModifiko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
			// 
			// btnKerko1
			// 
			this.btnKerko1.BackColor = System.Drawing.Color.Blue;
			this.btnKerko1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko1.DoValidation = false;
			this.btnKerko1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko1.Location = new System.Drawing.Point(468, 60);
			this.btnKerko1.Name = "btnKerko1";
			this.btnKerko1.Size = new System.Drawing.Size(90, 21);
			this.btnKerko1.TabIndex = 7;
			this.btnKerko1.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko1, "Kerkon per rezervimet qe plotesojne kriteret e zgjedhur!");
			this.btnKerko1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko1.Click += new System.EventHandler(this.btnKerko1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.grid);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 124);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(546, 432);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.Text = "Rezervime";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// grid
			// 
			this.grid.AllowSorting = false;
			this.grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.grid.CanDelete = true;
			this.grid.CaptionVisible = false;
			this.grid.DataMember = "";
			this.grid.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.grid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grid.HideHorizontalScrollBar = false;
			this.grid.HideVerticalScrollBar = false;
			this.grid.Location = new System.Drawing.Point(12, 20);
			this.grid.Name = "grid";
			this.grid.RowHeaderWidth = 20;
			this.grid.Selekto = true;
			this.grid.Size = new System.Drawing.Size(510, 400);
			this.grid.TabIndex = 8;
			this.toolTips.SetToolTip(this.grid, "Zgjidhni nje prej rezervimeve per ta modifikuar ose eleminuar!");
			this.grid.CurrentCellChanged += new System.EventHandler(this.grid_CurrentCellChanged);
			// 
			// gbDatat1
			// 
			this.gbDatat1.BackColor = System.Drawing.Color.Transparent;
			this.gbDatat1.Controls.Add(this.rbRezervimeSkaduara1);
			this.gbDatat1.Controls.Add(this.rbEmri);
			this.gbDatat1.Controls.Add(this.rbData);
			this.gbDatat1.Controls.Add(this.txtMbKlienti);
			this.gbDatat1.Controls.Add(this.txtEklienti);
			this.gbDatat1.Controls.Add(this.label1);
			this.gbDatat1.Controls.Add(this.lblEmr);
			this.gbDatat1.Controls.Add(this.dtpFillKlienti);
			this.gbDatat1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbDatat1.Location = new System.Drawing.Point(10, 8);
			this.gbDatat1.Name = "gbDatat1";
			this.gbDatat1.Size = new System.Drawing.Size(446, 112);
			this.gbDatat1.TabIndex = 1;
			this.gbDatat1.Text = "Kerko rezervim sipas";
			this.gbDatat1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// rbRezervimeSkaduara1
			// 
			this.rbRezervimeSkaduara1.Location = new System.Drawing.Point(12, 84);
			this.rbRezervimeSkaduara1.Name = "rbRezervimeSkaduara1";
			this.rbRezervimeSkaduara1.Size = new System.Drawing.Size(140, 24);
			this.rbRezervimeSkaduara1.TabIndex = 6;
			this.rbRezervimeSkaduara1.Text = "Rezervimet jashte afatit";
			// 
			// rbEmri
			// 
			this.rbEmri.Location = new System.Drawing.Point(12, 56);
			this.rbEmri.Name = "rbEmri";
			this.rbEmri.Size = new System.Drawing.Size(72, 20);
			this.rbEmri.TabIndex = 3;
			this.rbEmri.Text = "Emrit";
			// 
			// rbData
			// 
			this.rbData.Location = new System.Drawing.Point(12, 16);
			this.rbData.Name = "rbData";
			this.rbData.Size = new System.Drawing.Size(80, 24);
			this.rbData.TabIndex = 1;
			this.rbData.Text = "Pas dates";
			// 
			// txtMbKlienti
			// 
			this.txtMbKlienti.AutoSize = false;
			this.txtMbKlienti.DefaultErrorMessage = "Ju duhet te jepni emrin dhe mbiemrin para se te kerkoni!";
			this.txtMbKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbKlienti.FixedLength = false;
			this.txtMbKlienti.IsValid = true;
			this.txtMbKlienti.Location = new System.Drawing.Point(268, 56);
			this.txtMbKlienti.Name = "txtMbKlienti";
			this.txtMbKlienti.Required = false;
			this.txtMbKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbKlienti.Size = new System.Drawing.Size(160, 20);
			this.txtMbKlienti.TabIndex = 5;
			this.txtMbKlienti.Text = "";
			// 
			// txtEklienti
			// 
			this.txtEklienti.AutoSize = false;
			this.txtEklienti.DefaultErrorMessage = "";
			this.txtEklienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEklienti.FixedLength = false;
			this.txtEklienti.IsValid = true;
			this.txtEklienti.Location = new System.Drawing.Point(100, 56);
			this.txtEklienti.Name = "txtEklienti";
			this.txtEklienti.Required = false;
			this.txtEklienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtEklienti.Size = new System.Drawing.Size(160, 20);
			this.txtEklienti.TabIndex = 4;
			this.txtEklienti.Text = "";
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(268, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "Mbiemri";
			// 
			// lblEmr
			// 
			this.lblEmr.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmr.Location = new System.Drawing.Point(100, 42);
			this.lblEmr.Name = "lblEmr";
			this.lblEmr.Size = new System.Drawing.Size(44, 12);
			this.lblEmr.TabIndex = 6;
			this.lblEmr.Text = "Emri";
			// 
			// dtpFillKlienti
			// 
			this.dtpFillKlienti.BackColor = System.Drawing.Color.White;
			this.dtpFillKlienti.CustomFormat = "dd.MM.yyyy";
			this.dtpFillKlienti.DefaultErrorMessage = "";
			this.dtpFillKlienti.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillKlienti.IsValid = true;
			this.dtpFillKlienti.Location = new System.Drawing.Point(100, 16);
			this.dtpFillKlienti.Name = "dtpFillKlienti";
			this.dtpFillKlienti.Required = true;
			this.dtpFillKlienti.ShowCheckBox = true;
			this.dtpFillKlienti.ShowUpDown = true;
			this.dtpFillKlienti.Size = new System.Drawing.Size(160, 20);
			this.dtpFillKlienti.TabIndex = 2;
			this.dtpFillKlienti.Value = new System.DateTime(2005, 10, 6, 13, 11, 0, 0);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.txtEmail);
			this.groupBox4.Controls.Add(this.label20);
			this.groupBox4.Controls.Add(this.numCmimi);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.cmbPagesaKlienti);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.cmbDhoma);
			this.groupBox4.Controls.Add(this.cmbKategorite);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.dtpMbarimiKlienti);
			this.groupBox4.Controls.Add(this.dtpFillimiKlienti);
			this.groupBox4.Controls.Add(this.txtMbiemriKlienti);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.txtEmriKlienti);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.dtpRezervimi);
			this.groupBox4.Controls.Add(this.label19);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.numKapariKlienti);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(566, 124);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(308, 336);
			this.groupBox4.TabIndex = 21;
			this.groupBox4.Text = "Modifikimi  i rezervimit";
			this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// txtEmail
			// 
			this.txtEmail.AutoSize = false;
			this.txtEmail.DefaultErrorMessage = "";
			this.txtEmail.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmail.FixedLength = false;
			this.txtEmail.IsValid = true;
			this.txtEmail.Location = new System.Drawing.Point(108, 160);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Required = false;
			this.txtEmail.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmail.Size = new System.Drawing.Size(180, 21);
			this.txtEmail.TabIndex = 14;
			this.txtEmail.Text = "";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(60, 162);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(40, 20);
			this.label20.TabIndex = 24;
			this.label20.Text = "E-mail";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.numCmimi.Location = new System.Drawing.Point(108, 244);
			this.numCmimi.Name = "numCmimi";
			this.numCmimi.OnlyPositive = true;
			this.numCmimi.ReadOnly = true;
			this.numCmimi.Required = true;
			this.numCmimi.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimi.Size = new System.Drawing.Size(180, 21);
			this.numCmimi.TabIndex = 17;
			this.numCmimi.Text = "";
			this.numCmimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(36, 248);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(64, 20);
			this.label16.TabIndex = 22;
			this.label16.Text = "Cmimi";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbPagesaKlienti
			// 
			this.cmbPagesaKlienti.BackColor = System.Drawing.Color.Transparent;
			this.cmbPagesaKlienti.DefaultErrorMessage = "Zgjidhni formen e pageses!";
			this.cmbPagesaKlienti.IsValid = false;
			this.cmbPagesaKlienti.Kolone1Vlere = null;
			this.cmbPagesaKlienti.Kolone2Vlere = null;
			this.cmbPagesaKlienti.Location = new System.Drawing.Point(108, 304);
			this.cmbPagesaKlienti.Name = "cmbPagesaKlienti";
			this.cmbPagesaKlienti.ReadOnly = false;
			this.cmbPagesaKlienti.Required = true;
			this.cmbPagesaKlienti.Size = new System.Drawing.Size(180, 21);
			this.cmbPagesaKlienti.SkipValidation = false;
			this.cmbPagesaKlienti.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(32, 308);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 20);
			this.label6.TabIndex = 21;
			this.label6.Text = "Pagesa ne";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbDhoma
			// 
			this.cmbDhoma.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhoma.DefaultErrorMessage = "Zgjidhni njeren prej dhomave para se te modifikoni!";
			this.cmbDhoma.IsValid = false;
			this.cmbDhoma.Kolone1Vlere = null;
			this.cmbDhoma.Kolone2Vlere = null;
			this.cmbDhoma.Location = new System.Drawing.Point(108, 216);
			this.cmbDhoma.Name = "cmbDhoma";
			this.cmbDhoma.ReadOnly = false;
			this.cmbDhoma.Required = true;
			this.cmbDhoma.Size = new System.Drawing.Size(180, 21);
			this.cmbDhoma.SkipValidation = false;
			this.cmbDhoma.TabIndex = 16;
			this.cmbDhoma.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbDhoma_SelectedIndexChanged_1);
			// 
			// cmbKategorite
			// 
			this.cmbKategorite.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategorite.DefaultErrorMessage = "Zgjidhni nje prej kategorive!";
			this.cmbKategorite.IsValid = false;
			this.cmbKategorite.Kolone1Vlere = null;
			this.cmbKategorite.Kolone2Vlere = null;
			this.cmbKategorite.Location = new System.Drawing.Point(108, 188);
			this.cmbKategorite.Name = "cmbKategorite";
			this.cmbKategorite.ReadOnly = false;
			this.cmbKategorite.Required = true;
			this.cmbKategorite.Size = new System.Drawing.Size(180, 21);
			this.cmbKategorite.SkipValidation = false;
			this.cmbKategorite.TabIndex = 15;
			this.cmbKategorite.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategorite_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label11.Location = new System.Drawing.Point(28, 108);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 20);
			this.label11.TabIndex = 6;
			this.label11.Text = "Date mbarimi";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpMbarimiKlienti
			// 
			this.dtpMbarimiKlienti.BackColor = System.Drawing.Color.White;
			this.dtpMbarimiKlienti.CustomFormat = "dd.MM.yyyy/hh:mm.tt";
			this.dtpMbarimiKlienti.DefaultErrorMessage = "Ju duhet te zgjidhni daten!";
			this.dtpMbarimiKlienti.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimiKlienti.IsValid = true;
			this.dtpMbarimiKlienti.Location = new System.Drawing.Point(108, 104);
			this.dtpMbarimiKlienti.Name = "dtpMbarimiKlienti";
			this.dtpMbarimiKlienti.Required = true;
			this.dtpMbarimiKlienti.ShowCheckBox = true;
			this.dtpMbarimiKlienti.ShowUpDown = true;
			this.dtpMbarimiKlienti.Size = new System.Drawing.Size(180, 20);
			this.dtpMbarimiKlienti.TabIndex = 12;
			this.dtpMbarimiKlienti.Value = new System.DateTime(2005, 10, 6, 13, 11, 0, 0);
			this.dtpMbarimiKlienti.ValueChanged += new System.EventHandler(this.dtpMbarimiKlienti_ValueChanged);
			// 
			// dtpFillimiKlienti
			// 
			this.dtpFillimiKlienti.BackColor = System.Drawing.Color.White;
			this.dtpFillimiKlienti.CustomFormat = "dd.MM.yyyy/hh:mm.tt";
			this.dtpFillimiKlienti.DefaultErrorMessage = "Ju duhet te zgjidhni daten!";
			this.dtpFillimiKlienti.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimiKlienti.IsValid = true;
			this.dtpFillimiKlienti.Location = new System.Drawing.Point(108, 80);
			this.dtpFillimiKlienti.Name = "dtpFillimiKlienti";
			this.dtpFillimiKlienti.Required = true;
			this.dtpFillimiKlienti.ShowCheckBox = true;
			this.dtpFillimiKlienti.ShowUpDown = true;
			this.dtpFillimiKlienti.Size = new System.Drawing.Size(180, 20);
			this.dtpFillimiKlienti.TabIndex = 11;
			this.dtpFillimiKlienti.Value = new System.DateTime(2005, 10, 6, 13, 11, 0, 0);
			this.dtpFillimiKlienti.ValueChanged += new System.EventHandler(this.dtpFillimiKlienti_ValueChanged);
			// 
			// txtMbiemriKlienti
			// 
			this.txtMbiemriKlienti.AutoSize = false;
			this.txtMbiemriKlienti.DefaultErrorMessage = "Ju duhet te jepni mbiemrin e klientit!";
			this.txtMbiemriKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemriKlienti.FixedLength = false;
			this.txtMbiemriKlienti.IsValid = false;
			this.txtMbiemriKlienti.Location = new System.Drawing.Point(108, 52);
			this.txtMbiemriKlienti.Name = "txtMbiemriKlienti";
			this.txtMbiemriKlienti.Required = true;
			this.txtMbiemriKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemriKlienti.Size = new System.Drawing.Size(180, 21);
			this.txtMbiemriKlienti.TabIndex = 10;
			this.txtMbiemriKlienti.Text = "";
			// 
			// label14
			// 
			this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label14.Location = new System.Drawing.Point(56, 52);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(44, 20);
			this.label14.TabIndex = 3;
			this.label14.Text = "Mbiemri";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label12.Location = new System.Drawing.Point(44, 80);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 20);
			this.label12.TabIndex = 5;
			this.label12.Text = "Date fillimi";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmriKlienti
			// 
			this.txtEmriKlienti.AutoSize = false;
			this.txtEmriKlienti.DefaultErrorMessage = "Ju duhet te jepni emrin e klientit!";
			this.txtEmriKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmriKlienti.FixedLength = false;
			this.txtEmriKlienti.IsValid = false;
			this.txtEmriKlienti.Location = new System.Drawing.Point(108, 24);
			this.txtEmriKlienti.Name = "txtEmriKlienti";
			this.txtEmriKlienti.Required = true;
			this.txtEmriKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmriKlienti.Size = new System.Drawing.Size(180, 21);
			this.txtEmriKlienti.TabIndex = 9;
			this.txtEmriKlienti.Text = "";
			// 
			// label15
			// 
			this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label15.Location = new System.Drawing.Point(32, 24);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(68, 20);
			this.label15.TabIndex = 2;
			this.label15.Text = "Emri";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label9.Location = new System.Drawing.Point(44, 216);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 20);
			this.label9.TabIndex = 8;
			this.label9.Text = "Dhoma";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label10.Location = new System.Drawing.Point(40, 192);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 20);
			this.label10.TabIndex = 7;
			this.label10.Text = "Kategoria";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpRezervimi
			// 
			this.dtpRezervimi.BackColor = System.Drawing.Color.White;
			this.dtpRezervimi.CustomFormat = "dd.MM.yyyy";
			this.dtpRezervimi.DefaultErrorMessage = "Ju duhet te zgjidhni daten!";
			this.dtpRezervimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpRezervimi.IsValid = true;
			this.dtpRezervimi.Location = new System.Drawing.Point(108, 132);
			this.dtpRezervimi.Name = "dtpRezervimi";
			this.dtpRezervimi.Required = true;
			this.dtpRezervimi.ShowCheckBox = true;
			this.dtpRezervimi.ShowUpDown = true;
			this.dtpRezervimi.Size = new System.Drawing.Size(180, 20);
			this.dtpRezervimi.TabIndex = 13;
			this.dtpRezervimi.Value = new System.DateTime(2005, 10, 6, 13, 11, 0, 0);
			// 
			// label19
			// 
			this.label19.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label19.Location = new System.Drawing.Point(8, 136);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(92, 20);
			this.label19.TabIndex = 17;
			this.label19.Text = "Data e rezervimit";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label13.Location = new System.Drawing.Point(4, 280);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(96, 20);
			this.label13.TabIndex = 4;
			this.label13.Text = "Kapari i rezervimit";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numKapariKlienti
			// 
			this.numKapariKlienti.AutoSize = false;
			this.numKapariKlienti.DefaultErrorMessage = "Ju duhet te jepni kaparin!";
			this.numKapariKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numKapariKlienti.DigitsAfterDecimalPoint = 0;
			this.numKapariKlienti.FixedLength = false;
			this.numKapariKlienti.IsValid = false;
			this.numKapariKlienti.KeepFocus = false;
			this.numKapariKlienti.Location = new System.Drawing.Point(108, 276);
			this.numKapariKlienti.Name = "numKapariKlienti";
			this.numKapariKlienti.OnlyPositive = true;
			this.numKapariKlienti.Required = true;
			this.numKapariKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.numKapariKlienti.Size = new System.Drawing.Size(180, 21);
			this.numKapariKlienti.TabIndex = 18;
			this.numKapariKlienti.Text = "";
			this.numKapariKlienti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tabGrup
			// 
			this.tabGrup.BackColor = System.Drawing.SystemColors.Control;
			this.tabGrup.Controls.Add(this.groupBox3);
			this.tabGrup.Controls.Add(this.btnElemino1);
			this.tabGrup.Controls.Add(this.btnModifiko1);
			this.tabGrup.Controls.Add(this.btnKerko);
			this.tabGrup.Controls.Add(this.groupBox1);
			this.tabGrup.Controls.Add(this.groupBox5);
			this.tabGrup.DefaultErrorMessage = null;
			this.tabGrup.EnableValidation = true;
			this.tabGrup.IsValid = false;
			this.tabGrup.Location = new System.Drawing.Point(4, 22);
			this.tabGrup.Name = "tabGrup";
			this.tabGrup.Size = new System.Drawing.Size(1003, 583);
			this.tabGrup.TabIndex = 1;
			this.tabGrup.Text = "Ne grup";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.rbRezervimeSkaduara2);
			this.groupBox3.Controls.Add(this.rbData1);
			this.groupBox3.Controls.Add(this.txtEmerAgjensia);
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.txtGrupi1);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.dtpNga1);
			this.groupBox3.Controls.Add(this.rbGrupi);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(10, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(446, 112);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.Text = "Kerko rezervim sipas";
			this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// rbRezervimeSkaduara2
			// 
			this.rbRezervimeSkaduara2.Location = new System.Drawing.Point(12, 84);
			this.rbRezervimeSkaduara2.Name = "rbRezervimeSkaduara2";
			this.rbRezervimeSkaduara2.Size = new System.Drawing.Size(212, 23);
			this.rbRezervimeSkaduara2.TabIndex = 25;
			this.rbRezervimeSkaduara2.Text = "Rezervimet jashte afatit";
			// 
			// rbData1
			// 
			this.rbData1.Location = new System.Drawing.Point(12, 16);
			this.rbData1.Name = "rbData1";
			this.rbData1.Size = new System.Drawing.Size(72, 24);
			this.rbData1.TabIndex = 22;
			this.rbData1.Text = "Pas dates";
			// 
			// txtEmerAgjensia
			// 
			this.txtEmerAgjensia.AutoSize = false;
			this.txtEmerAgjensia.DefaultErrorMessage = "";
			this.txtEmerAgjensia.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmerAgjensia.FixedLength = false;
			this.txtEmerAgjensia.IsValid = true;
			this.txtEmerAgjensia.Location = new System.Drawing.Point(268, 56);
			this.txtEmerAgjensia.Name = "txtEmerAgjensia";
			this.txtEmerAgjensia.Required = false;
			this.txtEmerAgjensia.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmerAgjensia.Size = new System.Drawing.Size(160, 21);
			this.txtEmerAgjensia.TabIndex = 25;
			this.txtEmerAgjensia.Text = "";
			// 
			// label17
			// 
			this.label17.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label17.Location = new System.Drawing.Point(268, 40);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 16);
			this.label17.TabIndex = 9;
			this.label17.Text = "Agjensia";
			// 
			// txtGrupi1
			// 
			this.txtGrupi1.AutoSize = false;
			this.txtGrupi1.DefaultErrorMessage = "";
			this.txtGrupi1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtGrupi1.FixedLength = false;
			this.txtGrupi1.IsValid = true;
			this.txtGrupi1.Location = new System.Drawing.Point(100, 56);
			this.txtGrupi1.Name = "txtGrupi1";
			this.txtGrupi1.Required = false;
			this.txtGrupi1.RequiredControlColor = System.Drawing.Color.White;
			this.txtGrupi1.Size = new System.Drawing.Size(160, 21);
			this.txtGrupi1.TabIndex = 24;
			this.txtGrupi1.Text = "";
			// 
			// label18
			// 
			this.label18.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label18.Location = new System.Drawing.Point(100, 40);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(60, 16);
			this.label18.TabIndex = 6;
			this.label18.Text = "Grupi";
			// 
			// dtpNga1
			// 
			this.dtpNga1.BackColor = System.Drawing.Color.White;
			this.dtpNga1.CustomFormat = "dd.MM.yyyy";
			this.dtpNga1.DefaultErrorMessage = "";
			this.dtpNga1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNga1.IsValid = true;
			this.dtpNga1.Location = new System.Drawing.Point(100, 16);
			this.dtpNga1.Name = "dtpNga1";
			this.dtpNga1.Required = false;
			this.dtpNga1.ShowCheckBox = true;
			this.dtpNga1.ShowUpDown = true;
			this.dtpNga1.Size = new System.Drawing.Size(160, 20);
			this.dtpNga1.TabIndex = 23;
			this.dtpNga1.Value = new System.DateTime(2005, 10, 6, 13, 11, 0, 0);
			// 
			// rbGrupi
			// 
			this.rbGrupi.Location = new System.Drawing.Point(12, 56);
			this.rbGrupi.Name = "rbGrupi";
			this.rbGrupi.Size = new System.Drawing.Size(72, 20);
			this.rbGrupi.TabIndex = 22;
			this.rbGrupi.Text = "Grupit";
			// 
			// btnElemino1
			// 
			this.btnElemino1.BackColor = System.Drawing.Color.Blue;
			this.btnElemino1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnElemino1.DoValidation = true;
			this.btnElemino1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnElemino1.Location = new System.Drawing.Point(800, 476);
			this.btnElemino1.Name = "btnElemino1";
			this.btnElemino1.Size = new System.Drawing.Size(90, 21);
			this.btnElemino1.TabIndex = 38;
			this.btnElemino1.Text = "Elemino";
			this.toolTips.SetToolTip(this.btnElemino1, "Eleminon rezervimin e zgjedhur!");
			this.btnElemino1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnElemino1.Click += new System.EventHandler(this.btnElemino1_Click);
			// 
			// btnModifiko1
			// 
			this.btnModifiko1.BackColor = System.Drawing.Color.Blue;
			this.btnModifiko1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifiko1.DoValidation = true;
			this.btnModifiko1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifiko1.Location = new System.Drawing.Point(652, 476);
			this.btnModifiko1.Name = "btnModifiko1";
			this.btnModifiko1.Size = new System.Drawing.Size(90, 21);
			this.btnModifiko1.TabIndex = 37;
			this.btnModifiko1.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifiko1, "Modifikon rezervimin e zgjedhur!");
			this.btnModifiko1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifiko1.Click += new System.EventHandler(this.btnModifiko1_Click);
			// 
			// btnKerko
			// 
			this.btnKerko.BackColor = System.Drawing.Color.Blue;
			this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko.DoValidation = false;
			this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko.Location = new System.Drawing.Point(468, 60);
			this.btnKerko.Name = "btnKerko";
			this.btnKerko.Size = new System.Drawing.Size(90, 21);
			this.btnKerko.TabIndex = 26;
			this.btnKerko.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko, "Kerkon per rezervimet qe plotesojne kriteret e zgjedhur!");
			this.btnKerko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.grid1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(10, 124);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(546, 432);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.Text = "Rezervime";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// grid1
			// 
			this.grid1.AllowSorting = false;
			this.grid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.grid1.CanDelete = true;
			this.grid1.CaptionVisible = false;
			this.grid1.DataMember = "";
			this.grid1.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grid1.HideHorizontalScrollBar = false;
			this.grid1.HideVerticalScrollBar = false;
			this.grid1.Location = new System.Drawing.Point(12, 20);
			this.grid1.Name = "grid1";
			this.grid1.RowHeaderWidth = 20;
			this.grid1.Selekto = true;
			this.grid1.Size = new System.Drawing.Size(510, 400);
			this.grid1.TabIndex = 27;
			this.toolTips.SetToolTip(this.grid1, "Zgjidhni nje prej rezervimeve per ta modifikuar ose eleminuar!");
			this.grid1.CurrentCellChanged += new System.EventHandler(this.grid1_CurrentCellChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.Transparent;
			this.groupBox5.Controls.Add(this.cmbPagesaGrupi);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Controls.Add(this.cmbGrupi);
			this.groupBox5.Controls.Add(this.button1);
			this.groupBox5.Controls.Add(this.btnShtoDhome);
			this.groupBox5.Controls.Add(this.dtpMbarimi);
			this.groupBox5.Controls.Add(this.dtpFillimi1);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Controls.Add(this.lvDhomatLira);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.label2);
			this.groupBox5.Controls.Add(this.numKapari1);
			this.groupBox5.Controls.Add(this.label3);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.dtRezervimi);
			this.groupBox5.Controls.Add(this.label21);
			this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox5.Location = new System.Drawing.Point(566, 124);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(392, 340);
			this.groupBox5.TabIndex = 50;
			this.groupBox5.Text = "Modifikimi i rezervimit ";
			this.groupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbPagesaGrupi
			// 
			this.cmbPagesaGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cmbPagesaGrupi.DefaultErrorMessage = null;
			this.cmbPagesaGrupi.IsValid = false;
			this.cmbPagesaGrupi.Kolone1Vlere = null;
			this.cmbPagesaGrupi.Kolone2Vlere = null;
			this.cmbPagesaGrupi.Location = new System.Drawing.Point(112, 308);
			this.cmbPagesaGrupi.Name = "cmbPagesaGrupi";
			this.cmbPagesaGrupi.ReadOnly = false;
			this.cmbPagesaGrupi.Required = true;
			this.cmbPagesaGrupi.Size = new System.Drawing.Size(180, 21);
			this.cmbPagesaGrupi.SkipValidation = false;
			this.cmbPagesaGrupi.TabIndex = 36;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(24, 308);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 20);
			this.label8.TabIndex = 51;
			this.label8.Text = "Pagesa ne";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbGrupi
			// 
			this.cmbGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cmbGrupi.DefaultErrorMessage = "Zgjidhni nje prej grupeve!";
			this.cmbGrupi.IsValid = false;
			this.cmbGrupi.Kolone1Vlere = null;
			this.cmbGrupi.Kolone2Vlere = null;
			this.cmbGrupi.Location = new System.Drawing.Point(112, 24);
			this.cmbGrupi.Name = "cmbGrupi";
			this.cmbGrupi.ReadOnly = false;
			this.cmbGrupi.Required = true;
			this.cmbGrupi.Size = new System.Drawing.Size(180, 21);
			this.cmbGrupi.SkipValidation = false;
			this.cmbGrupi.TabIndex = 28;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Blue;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.DoValidation = true;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(304, 196);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 21);
			this.button1.TabIndex = 34;
			this.button1.Text = "Fshi dhome";
			this.toolTips.SetToolTip(this.button1, "Heq dhomen e zgjedhur nga lista\r\n e dhomave te rezervuara nga grupi!");
			this.button1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnShtoDhome
			// 
			this.btnShtoDhome.BackColor = System.Drawing.Color.Blue;
			this.btnShtoDhome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShtoDhome.DoValidation = false;
			this.btnShtoDhome.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShtoDhome.Location = new System.Drawing.Point(304, 168);
			this.btnShtoDhome.Name = "btnShtoDhome";
			this.btnShtoDhome.Size = new System.Drawing.Size(74, 21);
			this.btnShtoDhome.TabIndex = 33;
			this.btnShtoDhome.Text = "Shto dhome";
			this.toolTips.SetToolTip(this.btnShtoDhome, "Per te shtuar nje ose disa dhomave ne listen\r\n e dhomave te rezervuara nga grupi!" +
				"");
			this.btnShtoDhome.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShtoDhome.Click += new System.EventHandler(this.btnShtoDhome_Click);
			// 
			// dtpMbarimi
			// 
			this.dtpMbarimi.BackColor = System.Drawing.Color.White;
			this.dtpMbarimi.CustomFormat = "dd.MM.yyyy/hh:mm.tt";
			this.dtpMbarimi.DefaultErrorMessage = "Ju duhet te zgjidhni daten perpara se te modifikoni rezervimin!";
			this.dtpMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimi.IsValid = true;
			this.dtpMbarimi.Location = new System.Drawing.Point(112, 80);
			this.dtpMbarimi.Name = "dtpMbarimi";
			this.dtpMbarimi.Required = true;
			this.dtpMbarimi.ShowCheckBox = true;
			this.dtpMbarimi.ShowUpDown = true;
			this.dtpMbarimi.Size = new System.Drawing.Size(180, 20);
			this.dtpMbarimi.TabIndex = 30;
			this.dtpMbarimi.Value = new System.DateTime(2005, 10, 6, 13, 11, 0, 0);
			this.dtpMbarimi.ValueChanged += new System.EventHandler(this.dtpMbarimi_ValueChanged);
			// 
			// dtpFillimi1
			// 
			this.dtpFillimi1.BackColor = System.Drawing.Color.White;
			this.dtpFillimi1.CustomFormat = "dd.MM.yyyy/hh:mm.tt";
			this.dtpFillimi1.DefaultErrorMessage = "Ju duhet te zgjidhni daten perpara se te modifikoni rezervimin!";
			this.dtpFillimi1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimi1.IsValid = true;
			this.dtpFillimi1.Location = new System.Drawing.Point(112, 52);
			this.dtpFillimi1.Name = "dtpFillimi1";
			this.dtpFillimi1.Required = true;
			this.dtpFillimi1.ShowCheckBox = true;
			this.dtpFillimi1.ShowUpDown = true;
			this.dtpFillimi1.Size = new System.Drawing.Size(180, 20);
			this.dtpFillimi1.TabIndex = 29;
			this.dtpFillimi1.Value = new System.DateTime(2005, 10, 6, 13, 11, 0, 0);
			this.dtpFillimi1.ValueChanged += new System.EventHandler(this.dtpFillimi1_ValueChanged);
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Location = new System.Drawing.Point(28, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 20);
			this.label4.TabIndex = 22;
			this.label4.Text = "Date fillimi";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lvDhomatLira
			// 
			this.lvDhomatLira.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						   this.emriDhoma1,
																						   this.cmimiDhoma1,
																						   this.idDhoma1,
																						   this.idKategoria1,
																						   this.colCmimi});
			this.lvDhomatLira.DefaultErrorMessage = "Ju duhet te zgjidhni dhomat perpara se te moidifikoni rezervimin!";
			this.lvDhomatLira.FullRowSelect = true;
			this.lvDhomatLira.GridLines = true;
			this.lvDhomatLira.IsValid = true;
			this.lvDhomatLira.Location = new System.Drawing.Point(112, 136);
			this.lvDhomatLira.MultiSelect = false;
			this.lvDhomatLira.Name = "lvDhomatLira";
			this.lvDhomatLira.Size = new System.Drawing.Size(180, 130);
			this.lvDhomatLira.TabIndex = 32;
			// 
			// emriDhoma1
			// 
			this.emriDhoma1.Text = "Kategoria";
			this.emriDhoma1.Width = 100;
			// 
			// cmimiDhoma1
			// 
			this.cmimiDhoma1.Text = "Dhoma";
			this.cmimiDhoma1.Width = 58;
			// 
			// idDhoma1
			// 
			this.idDhoma1.Text = "idDhoma";
			this.idDhoma1.Width = 0;
			// 
			// idKategoria1
			// 
			this.idKategoria1.Width = 0;
			// 
			// colCmimi
			// 
			this.colCmimi.Text = "cmimi";
			this.colCmimi.Width = 0;
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(4, 280);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Kapari i rezervimit";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(32, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 12;
			this.label2.Text = "Dhomat";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numKapari1
			// 
			this.numKapari1.AutoSize = false;
			this.numKapari1.DefaultErrorMessage = "Ju duhet te percaktoni kaparin per rezervim!";
			this.numKapari1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numKapari1.DigitsAfterDecimalPoint = 0;
			this.numKapari1.FixedLength = false;
			this.numKapari1.IsValid = false;
			this.numKapari1.KeepFocus = false;
			this.numKapari1.Location = new System.Drawing.Point(112, 276);
			this.numKapari1.Name = "numKapari1";
			this.numKapari1.OnlyPositive = true;
			this.numKapari1.Required = true;
			this.numKapari1.RequiredControlColor = System.Drawing.Color.White;
			this.numKapari1.Size = new System.Drawing.Size(180, 21);
			this.numKapari1.TabIndex = 35;
			this.numKapari1.Text = "";
			this.numKapari1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(28, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 20);
			this.label3.TabIndex = 23;
			this.label3.Text = "Date mbarimi";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label7.Location = new System.Drawing.Point(20, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 20);
			this.label7.TabIndex = 2;
			this.label7.Text = "Grupi";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtRezervimi
			// 
			this.dtRezervimi.BackColor = System.Drawing.Color.White;
			this.dtRezervimi.CustomFormat = "dd.MM.yyyy";
			this.dtRezervimi.DefaultErrorMessage = "Ju duhet te zgjidhni daten perpara se te modifikoni rezervimin!";
			this.dtRezervimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtRezervimi.IsValid = true;
			this.dtRezervimi.Location = new System.Drawing.Point(112, 108);
			this.dtRezervimi.Name = "dtRezervimi";
			this.dtRezervimi.Required = true;
			this.dtRezervimi.ShowCheckBox = true;
			this.dtRezervimi.ShowUpDown = true;
			this.dtRezervimi.Size = new System.Drawing.Size(180, 20);
			this.dtRezervimi.TabIndex = 31;
			this.dtRezervimi.Value = new System.DateTime(2005, 10, 6, 13, 11, 0, 0);
			// 
			// label21
			// 
			this.label21.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label21.Location = new System.Drawing.Point(8, 108);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(96, 20);
			this.label21.TabIndex = 26;
			this.label21.Text = "Data e rezervimit";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// colDhoma
			// 
			this.colDhoma.Format = "";
			this.colDhoma.FormatInfo = null;
			this.colDhoma.HeaderText = "Dhoma";
			this.colDhoma.MappingName = "";
			this.colDhoma.Width = 75;
			// 
			// ds
			// 
			this.ds.DataSetName = "NewDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// btnDil
			// 
			this.btnDil.BackColor = System.Drawing.Color.Blue;
			this.btnDil.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDil.DoValidation = true;
			this.btnDil.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDil.Location = new System.Drawing.Point(0, 0);
			this.btnDil.Name = "btnDil";
			this.btnDil.Size = new System.Drawing.Size(90, 21);
			this.btnDil.TabIndex = 0;
			this.btnDil.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// ds1
			// 
			this.ds1.DataSetName = "NewDataSet";
			this.ds1.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// ModifikoRezervim
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1036, 656);
			this.Controls.Add(this.tab);
			this.HelpFile = "MODIFIKO REZERVIME.htm";
			this.IsValid = true;
			this.Name = "ModifikoRezervim";
			this.Text = "Modifikim rezervime";
			this.TitullGjeresi = 1036;
			this.Load += new System.EventHandler(this.ModifikoRezervim_Load);
			this.Controls.SetChildIndex(this.tab, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.tab.ResumeLayout(false);
			this.tabIndividuale.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gbDatat1)).EndInit();
			this.gbDatat1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.tabGrup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox5)).EndInit();
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region FormLoad
		private void ModifikoRezervim_Load(object sender, System.EventArgs e)
		{
			try
			{
				//pastrim variablash private
				this.idRezervimiGrupi = 0;
				this.ds.Tables.Clear() ;
				this.ds1.Tables.Clear() ;
				this.idRezervimiKlienti = 0;
				this.idDhomaKlienti = 0;
				this.idKategoriaGrupi = 0;
				this.zgjedhur = false;
				//pastrim variablash private
				DataSet ds1 = null;
				this.dtpFillimi1.Value = DateTime.Now;
				this.dtpFillimiKlienti.Value = DateTime.Now;
				this.dtpFillKlienti.Value = DateTime.Now;
				this.dtpMbarimi.Value = DateTime.Now;
				this.dtpMbarimiKlienti.Value = DateTime.Now;
				this.dtpNga1.Value = DateTime.Now;
				this.dtpRezervimi.Value = DateTime.Now;
				this.dtRezervimi.Value = DateTime.Now;
				InputController data = new InputController();
				// Shohim nese ka rezervime te cilave u ka kaluar afati
				this.MbushPagesat();
				DataSet dsRezervimeAnullo = null;
				dsRezervimeAnullo = data.KerkesaRead("ShfaqRezervimeSkaduara");
				if (dsRezervimeAnullo.Tables[0].Rows.Count > 0)
				{
					grid.DataSource = dsRezervimeAnullo.Tables[0];
					KrijoStilGrid();
					// Vendosim nje mesazh gabimi ne krah te grides per te paralajmeruar perdoruesin
					// per rezervime te skaduara
					error.SetError(grid, "Rezervimeve te shfaqura iu ka kaluar afati i rezervimit." +
						Environment.NewLine + "Ndryshoni kohen e rezervimit ose fshijeni si rezervim");
				}
					// Perndryshe hidh ne gride te gjitha rezervimet
				else
				{
					error.SetError(grid, "");
					ds = data.KerkesaRead("ShfaqRezervimeKlienti");
					if (ds.Tables[0].Rows.Count > 0)
					{
						grid.DataSource = ds.Tables[0];
						KrijoStilGrid();
					}
					else if (this.tab.SelectedIndex == 0)
					{
						this.grid.TableStyles.Clear();
						grid.DataSource = null;
						System.Windows.Forms.MessageBox.Show(this, "Nuk ka asnje rezervim individual aktualisht ne hotel!",  "Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				// Kontrollo nese ka rezervime per grupet te cilave u ka mbaruar afati
				DataSet dsRezervimeAnullo1 =  null;
				dsRezervimeAnullo1 = data.KerkesaRead("ShfaqRezervimeSkaduaraGrupe");
				if (dsRezervimeAnullo1.Tables[0].Rows.Count > 0)
				{
					grid1.DataSource = dsRezervimeAnullo1.Tables[0];
					KrijoStilGrid1();
					// Vendosim nje mesazh gabimi ne krah te grides per te paralajmeruar perdoruesin
					// per rezervime te skaduara
					error.SetError(grid1, "Rezervimeve te shfaqura iu ka kaluar afati i rezervimit." +
						Environment.NewLine + "Ndryshoni kohen e rezervimit ose fshijeni si rezervim");
				}
					// Perndryshe hidh ne gride te gjitha rezervimet
				else
				{
					error.SetError(grid1, "");
					ds1 = data.KerkesaRead("ShfaqRezervimeGrupi");
					if (ds1.Tables[0].Rows.Count > 0)
					{
						grid1.DataSource = ds1.Tables[0];
						KrijoStilGrid1();
					}
					else if (this.tab.SelectedIndex == 1)
					{
						grid1.TableStyles.Clear();
						grid1.DataSource = null;
						System.Windows.Forms.MessageBox.Show(this, "Nuk ka asnje rezervim ne grup aktualisht ne hotel!", "Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				ds = data.KerkesaRead("ShfaqGrupet");
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbGrupi.Kolone1.Items.Add(dr[1]);
					this.cmbGrupi.Kolone2.Items.Add(dr[0]);
					
				}
				ds = data.KerkesaRead("ShfaqKategorite");
				// Percaktojme gjatesine e vektorit qe mbaje vlerat e idKategori-se
				int nrRreshta = ds.Tables[0].Rows.Count;
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbKategorite.Kolone1.Items.Add(dr[1]);
					this.cmbKategorite.Kolone2.Items.Add(dr[0]);
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

		private void tab_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.zgjedhur = false;
				if (this.tab.SelectedIndex == 0)// klienti
				{
					this.Pastro(this.groupBox4);
					this.ModifikoRezervim_Load(sender, e);
				}
				else//grupi
				{
					this.Pastro(this.groupBox5);
					this.lvDhomatLira.Items.Clear();
					this.ModifikoRezervim_Load(sender, e);
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

		#region RezervimKlienti
		private void btnKerko1_Click(object sender, System.EventArgs e)
		{
			try
			{
				DataSet ds = null;
				this.Pastro(groupBox4);
				numKapariKlienti.Text = "";
				cmbDhoma.Kolone1.Items.Clear();
				cmbDhoma.Kolone2.Items.Clear();
				InputController data = new InputController();
				error.SetError(this.grid, "");
				if (rbData.Checked == true)
				{
					DateTime dataFillimi = Convert.ToDateTime(this.dtpFillKlienti.Value);
					groupBox2.Text = "Rezervimet per te cilat data e fillimit eshte pas dates se dhene";
					ds = data.KerkesaRead("ShfaqRezervimetPerKlientPerDatatEdhena", dataFillimi);
				}
				else if (rbEmri.Checked == true)
				{
					string emri = this.txtEklienti.Text;
					string mbiemri = this.txtMbKlienti.Text;
					groupBox2.Text = "Rezervimet individuale per emer, mbiemer te dhene";
					ds = data.KerkesaRead("ShfaqRezervimetPerKlientPerEmerMbiemerTeDhene", emri, mbiemri);	
				}
				else if (rbRezervimeSkaduara1.Checked)
				{
					// Shohim nese ka rezervime te cilave u ka kaluar afati
					ds = data.KerkesaRead("ShfaqRezervimeSkaduara");
					groupBox2.Text = "Rezervimet te cilave u ka kaluar afati i futjes ne hotel";
				}
				else
					return;
				if (ds.Tables[0].Rows.Count > 0)
				{
					grid.DataSource = ds.Tables[0];
					KrijoStilGrid();
					return;
				}
				else
				{
					grid.TableStyles.Clear();
					grid.DataSource = null;
					System.Windows.Forms.MessageBox.Show(this, "Nuk ka asnje rezervim individual qe ploteson kriteret e kerkimit!",
						"Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		
		private void btnElemino_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				int b = 0;
				int k = 0;
				InputController data = new InputController();			
				ds =data.KerkesaRead("ShfaqRezervimeVlefshme");
				bool ugjet = false;
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					if( idRezervimiKlienti == Convert.ToInt32(dr["ID_REZERVIMI"]))
					{
						ugjet = true;
						break;
					}
				}
				DialogResult result;
				if (ugjet)
				{
					result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i rezervimeve",
						"Rezervimi i zgjedhur eshte ende i vlefshem, jeni te sigurte qe doni ta eliminoni?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}
				else
				{
					result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i rezervimeve",
						"Jeni te sigurte qe doni te eliminoni  rezervimin e zgjedhur?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}
				if (result != DialogResult.Yes)
					return;
				DialogResult result1 = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i rezervimeve",
						"Deshironi te eleminoni edhe hedhjen ne arke per rezervimin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result1 == DialogResult.Yes)
					k = 1;
				else 
					k = 0;
				b = data.KerkesaUpdate("FshiRezervim", this.idRezervimiKlienti, k);
				if(b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this,"Rezervimi i zgjedhur u eliminua!", "Modifikimi i rezervimeve",
						 MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.RefreshFormKlienti(sender, e);
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, "Rezervimi i zgjedhur nuk u eliminua! Provoni perseri!", "Modifikimi i rezervimeve",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

		private void btnModifiko_Click(object sender, System.EventArgs e)
		{
			try
			{
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimiKlienti.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimiKlienti.Value);
				DateTime dtRezervimi = Convert.ToDateTime(this.dtpRezervimi.Value);
				int idKategoria = Convert.ToInt32(this.cmbKategorite.Kolone2Vlere);
				if (this.KontrolloDatatPerRezervim(dtFillimi, dtRezervimi) == 1)//data e rezervimit nuk eshte e rregullt
				{
					dtpRezervimi.IsValid = false;
					System.Windows.Forms.MessageBox.Show(this, "Data e rezervimit nuk mund te jete me e madhe se data e fillimit te rezervimit!" + Environment.NewLine + "Ju lutem kryeni modifikimet e nevojshme para se te beni  rezervimin!", "Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				dtpRezervimi.IsValid = true;
				int cmimi = Convert.ToInt32(this.numCmimi.Text);
				int pagesa = this.GjejPagesen(idKategoria, cmimi, dtFillimi, dtMbarimi);
				int kapari = Convert.ToInt32(this.numKapariKlienti.Text);
				if (kapari > pagesa)
				{
					System.Windows.Forms.MessageBox.Show(this, "Kapari nuk mund te jete me i madh se pagesa per dhomen!", "Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				//data eshte kontrolluar me pare
				this.error.SetError(this.dtpFillimiKlienti, "");
				this.cmbDhoma.IsValid = true;
				this.error.SetError(this.cmbDhoma,"");
				this.dtpFillimiKlienti.IsValid = true;
				this.error.SetError(this.dtpFillimiKlienti,"");
				int b = 0;
				string emri = this.txtEmriKlienti.Text;
				string mbiemri = this.txtMbiemriKlienti.Text;
				DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimiKlienti.Value);
				DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimiKlienti.Value);
				int idDhomaERe = Convert.ToInt32(this.cmbDhoma.Kolone2Vlere);
				int idFormaPagesa = Convert.ToInt32(this.cmbPagesaKlienti.Kolone2Vlere);
				string emaili = this.txtEmail.Text;
				InputController data = new InputController();
				if(System.DateTime.Now > Convert.ToDateTime(grid[grid.CurrentRowIndex,8]))
				{
					DialogResult result1 = VisionInfoSolutionLibrary.MessageBox.Show(this,"Modifikimi i rezervimeve",
						"Kujdes, rezervimi nuk eshte i vlefshem. Deshironi te vazhdoni? ", 
						MessageBoxButtons.YesNo
						, MessageBoxIcon.Information);
					if(result1 != DialogResult.Yes)
					{
						this.RefreshFormKlienti(sender, e);
						return;
					}
					else
					{
						b = data.KerkesaUpdate("ModifikoRezerviminPerKlient", emri, mbiemri, kapari, dataFillimi, dataMbarimi,dtRezervimi,
							this.idRezervimiKlienti, idDhomaERe,this.idDhomaKlienti, idFormaPagesa, emaili, this.PerdoruesId);
						if(b == 0)
							this.RefreshFormKlienti(sender, e);
						System.Windows.Forms.MessageBox.Show(this,"Rezervimi i kryer nga klienti u modifikua!",  "Modifikimi i rezervimeve",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i rezervimeve",
						"Jeni te sigurte qe doni te modifikoni  rezervimin e zgjedhur?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result != DialogResult.Yes)
						return;
					b = data.KerkesaUpdate("ModifikoRezerviminPerKlient", emri, mbiemri, kapari, dataFillimi,
						dataMbarimi,dtRezervimi,this.idRezervimiKlienti, idDhomaERe,this.idDhomaKlienti,
						idFormaPagesa, emaili, this.PerdoruesId);
					if(b == 0)
						this.RefreshFormKlienti(sender, e);
					System.Windows.Forms.MessageBox.Show(this, "Rezervimi i kryer nga klienti u modifikua!", "Modifikimi i rezervimeve",
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
		
		private void cmbKategorite_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimiKlienti.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimiKlienti.Value);
				int idKategoria = Convert.ToInt32(this.cmbKategorite.Kolone2Vlere);
				this.cmbDhoma.Kolone1.Items.Clear();
				this.cmbDhoma.Kolone2.Items.Clear();
				this.cmbDhoma.Kolone1.Text = "";
				this.numCmimi.Text = "";
				//kontrollojme datat per rregullsi
				int a  = this.KntData(idKategoria, dtFillimi, dtMbarimi);
				if (a != 0)
				{
					this.error.SetError(dtpFillimiKlienti, "Data e fillimit duhet te jete me e vogel se data e mbarimit!");
					dtpFillimiKlienti.IsValid = false;
					return;
				}
				this.error.SetError(dtpFillimiKlienti, "");
				dtpFillimiKlienti.IsValid = true;
				InputController data = new InputController();
				//mbushim kombon e dhomave, dhoma e shfaqur nga rezervimi duhet te shfaqet
				//artificialisht si e lire ne menyre qe te mund te zgjidhet perseri
				int idRezervimi = Convert.ToInt32(this.grid[this.grid.CurrentRowIndex, 10] );
				DataSet ds = data.KerkesaRead("ShfaqDhomatPlotesishtTeLiraPerDatatPerKategorinePerModifikim", idKategoria, dtFillimi, dtMbarimi, idRezervimi);
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbDhoma.Kolone1.Items.Add(dr[1]);
					this.cmbDhoma.Kolone2.Items.Add(dr[0]);
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
							"Ju lutemi konfiguroni cmimin ose zgjidhni nje kategori tjeter!","Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
						"Ju lutemi zgjidhni nje kategori tjeter!","Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
		}
		
		private void cmbDhoma_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				InputController data = new InputController();
				DataSet ds = new DataSet() ;
				ds.Tables.Add();
				ds.Tables[0].Columns.Add("ID_DHOMA",typeof(int));
				ds.Tables[0].Columns.Add("DHOMA_EMRI",typeof(string));
				ds.AcceptChanges();	
				DataRow r = ds.Tables[0].NewRow();
				r[0]= Convert.ToInt32(this.grid[this.grid.CurrentRowIndex,12]);
				r[1]= this.grid[this.grid.CurrentRowIndex,3].ToString();
				ds.Tables[0].Rows.Add(r);
				ds.AcceptChanges();	
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
		private void grid_CurrentCellChanged(object sender, System.EventArgs e)
		{
			try
			{
				int rowIndex = grid.CurrentRowIndex;
				this.txtEmriKlienti.Text = grid[rowIndex, 0].ToString();
				this.txtMbiemriKlienti.Text = grid[rowIndex, 1].ToString();
				this.numKapariKlienti.Text = grid[rowIndex, 9].ToString();
				this.dtpRezervimi.Value = Convert.ToDateTime(grid[rowIndex, 4]);
				this.dtpFillimiKlienti.Value = Convert.ToDateTime(grid[rowIndex, 7]);
				this.dtpMbarimiKlienti.Value = Convert.ToDateTime(grid[rowIndex, 8]);
				this.txtEmail.Text = Convert.ToString(grid[rowIndex, 13]);
				DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimiKlienti.Value);
				DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimiKlienti.Value);
				if ((this.cmbKategorite.Kolone1.SelectedItem != null)&&(this.cmbKategorite.Kolone1.SelectedItem.ToString()!= grid[rowIndex,2].ToString()))
					this.cmbKategorite.Kolone1.Text = grid[rowIndex,2].ToString();
				else if (this.cmbKategorite.Kolone1.SelectedItem == null)
					this.cmbKategorite.Kolone1.Text = grid[rowIndex,2].ToString();
				else 
				{
					this.cmbKategorite.Kolone1.Text = grid[rowIndex,2].ToString();
					VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e1 = new VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs();
					this.cmbKategorite_SelectedIndexChanged(sender, e1);
				}
				this.cmbDhoma.Kolone1.Text = grid[rowIndex,3].ToString();
				this.cmbDhoma.Kolone1Vlere = grid[rowIndex,3].ToString();
				this.cmbDhoma.Kolone2.Text = grid[rowIndex,12].ToString();
				this.cmbDhoma.Kolone2Vlere = grid[rowIndex,12].ToString();
				InputController data = new InputController();
				int idDhoma = Convert.ToInt32(this.cmbDhoma.Kolone2Vlere);
				ds = data.KerkesaRead("ShfaqCmimPerDhomenDheDatatEdhena", idDhoma, dataFillimi, dataMbarimi);
				this.numCmimi.Text = ds.Tables[0].Rows[0]["CMIMI"].ToString();
				this.idRezervimiKlienti = Convert.ToInt32(grid[rowIndex , 10]);
				DataSet dsFormaPagesa = data.KerkesaRead("ShfaqFormePagesePerRezervim", idRezervimiKlienti);
				if (dsFormaPagesa.Tables[0].Rows.Count != 0)
				{
					int idFormaPagesa = Convert.ToInt32(dsFormaPagesa.Tables[0].Rows[0]["ID_FORMAPAGESA"]);
					string pagesa = dsFormaPagesa.Tables[0].Rows[0]["EMRI"].ToString();
					this.cmbPagesaKlienti.Kolone1.Text = pagesa;
					this.cmbPagesaKlienti.Kolone1Vlere = pagesa;
					this.cmbPagesaKlienti.Kolone2.Text = idFormaPagesa.ToString();
					this.cmbPagesaKlienti.Kolone2Vlere = idFormaPagesa;
				}
				this.idDhomaKlienti = Convert.ToInt32(grid[rowIndex ,12]);
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

		private void cmbDhoma_SelectedIndexChanged_1(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				DataSet ds = null ;
				this.numCmimi.Text = "";
				int idDhoma = Convert.ToInt32(this.cmbDhoma.Kolone2Vlere);
				DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimiKlienti.Value);
				DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimiKlienti.Value);
				DateTime dataRezervimi = Convert.ToDateTime(this.dtpRezervimi.Value);
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqCmimPerDhomenDheDatatEdhena", idDhoma, dataFillimi, dataMbarimi);
				if(ds.Tables[0].Rows.Count == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Per dhomen e zgjedhur nuk eshte konfiguruar cmimi. Ju "
						+ "lutemi konfiguroni me pare cmimin e dhomes.", "Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					DataRow dr =ds.Tables[0].Rows[0];
					this.numCmimi.Text = Convert.ToString(dr[2]);
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
		private void dtpFillimiKlienti_ValueChanged(object sender, System.EventArgs e)
		{
			cmbKategorite.Kolone1.Text = "";
			cmbKategorite.Kolone2.Text = "";
			cmbDhoma.Kolone1.Items.Clear();
			cmbDhoma.Kolone2.Items.Clear();
			cmbDhoma.Kolone1.Text = "";
			cmbDhoma.Kolone2.Text = "";
			numCmimi.Text = "";
		}

		private void dtpMbarimiKlienti_ValueChanged(object sender, System.EventArgs e)
		{
			cmbKategorite.Kolone1.Text = "";
			cmbKategorite.Kolone2.Text = "";
			cmbDhoma.Kolone1.Items.Clear();
			cmbDhoma.Kolone2.Items.Clear();
			cmbDhoma.Kolone1.Text = "";
			cmbDhoma.Kolone2.Text = "";
			numCmimi.Text = "";
		}

		#endregion

		#region RezervimGrupi
		private void btnKerko_Click(object sender, System.EventArgs e)
		{
			try
			{	
				this.zgjedhur = false;
				this.idRezervimiGrupi = 0;
				this.Cursor = Cursors.WaitCursor;
				DataSet ds = null;
				this.Pastro(groupBox5);
				lvDhomatLira.Items.Clear();
				InputController data = new InputController();
				if (this.rbData1.Checked== true)
				{
					DateTime dataFillimi = Convert.ToDateTime(this.dtpNga1.Value);
					ds = data.KerkesaRead("ShfaqRezervimetPerGrupPerDatenEdhene", dataFillimi);
					groupBox1.Text = "Rezervimet per te cilat data e fillimit eshte pas dates se dhene";
				}
				else if (this.rbGrupi.Checked == true)
				{
					string grupi = this.txtGrupi1.Text;
					string agjensia = this.txtEmerAgjensia.Text;
					ds = data.KerkesaRead("ShfaqRezervimetPerGrupAgjensiTeDhene", grupi, agjensia);	
					groupBox1.Text = "Rezervimet e kryera nga grupet me emer, agjensi te dhene";
				}
				else if (this.rbRezervimeSkaduara2.Checked)
				{
					error.SetError(grid1, "");
					ds = data.KerkesaRead("ShfaqRezervimeSkaduaraGrupe");
					groupBox1.Text = "Rezervimet per grupet te cilave iu ka mbaruar afati";
				}
				else
					return;
				if (ds.Tables[0].Rows.Count > 0)
				{
					grid1.DataSource = ds.Tables[0];
					this.KrijoStilGrid1();
				}
				else
				{
					grid1.TableStyles.Clear();
					grid1.DataSource = null;
					System.Windows.Forms.MessageBox.Show(this, "Nuk ka asnje rezervim ne grup qe ploteson kriteret e kerkimit!",
						"Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void btnElemino1_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				this.ReSetTeDhena();
				int b = 0;
				int k = 0;
				InputController data = new InputController();
				ds =data.KerkesaRead("ShfaqRezervimeVlefshmeNeGrup");
				bool ugjet = false;
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					if( idRezervimiGrupi == Convert.ToInt32(dr[7]))
					{
						ugjet = true;
						break;
					}
				}
				DialogResult result;
				if (ugjet)
				{
					result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i rezervimeve",
						"Rezervimi i zgjedhur eshte ende i vlefshem, jeni te sigurte qe doni ta eliminoni?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}
				else
				{
					result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i rezervimeve",
						"Jeni te sigurte qe doni te eliminoni  rezervimin e zgjedhur?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}
				if (result != DialogResult.Yes)
					return;
				DataSet dsHyrje = data.KerkesaRead("ShfaqVeprimetPerRezervim", this.idRezervimiGrupi);
				int index = this.grid1.CurrentRowIndex;
				int kapariRezervimi = Convert.ToInt32(this.grid1[index, 7]);
				int kapariGrupi = 0;
				int pagesa = 0;
				bool kaHyrjePerRezervim = false;
				if (dsHyrje.Tables[0].Rows.Count != 0)//jane kryer futje nga rezervimi, kapari nuk mund te fshihet prej arkes, duhet kontrolluar nqs mbetet i rregullt
				{
					kaHyrjePerRezervim = true;
					DataSet dsPagesa = this.PagesaGrupi(dsHyrje);
					foreach(DataRow dr in dsHyrje.Tables[0].Rows)
					{
						kapariGrupi = Convert.ToInt32(dr["KAPARI"]);
						if (kapariGrupi > 0)
							break;
					}
					foreach(DataRow dr in dsPagesa.Tables[0].Rows)
					{
						int pagesaDhoma = Convert.ToInt32(dr["VLERA"]);
						pagesa += pagesaDhoma;
					}
					if (kapariGrupi > pagesa)
					{
						string s = "Fshirja e rezervimit nuk mund te behet!";
						s += Environment.NewLine + "Ne hotel jane kryer futje nga ky rezervim. Per pasoje";
						s += Environment.NewLine + "kapari i rezervimit i eshte bashkangjitur kaparit te grupit";
						s += Environment.NewLine + "Pas fshirjes se rezervimit kapari rezulton me i madh se pagesa.";
						s += Environment.NewLine + "Per te bere fshirjen e rezervimit me pare duhet te beni";
						s += Environment.NewLine + "modifikimin e kaparit ne vleren e duhur.";
						System.Windows.Forms.MessageBox.Show(this,s, "Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					string s1 = "Ne hotel jane futur kliente me ane te ketij rezervimi.";
					s1 += Environment.NewLine + "Per pasoje kapari i rezervimit i hedhur ne arke nuk do te fshihet!";
					System.Windows.Forms.MessageBox.Show(this,s1, "Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				if (kaHyrjePerRezervim)
					k = 1;
				else
				{
					DialogResult result1 = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i rezervimeve",
						"Deshironi te eleminoni edhe hedhjen ne arke per rezervimin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result1 == DialogResult.Yes)
						k = 1;
					else 
						k = 0;	
				}
				b = data.KerkesaUpdate("FshiRezervim", idRezervimiGrupi, k);
				if(b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Rezervimi i zgjedhur u eleminua!", "Modifikimi i rezervimeve",
						 MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.RefreshFormGrupi(sender,e);
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, "Rezervimi i zgjedhur nuk u eleminua! Provoni perseri!", "Modifikimi i rezervimeve",
						 MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

//		private void btnModifiko1_Click(object sender, System.EventArgs e)
//		{
//			try
//			{
//				DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimi1.Value);
//				DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
//				DateTime dataRezervimi = Convert.ToDateTime(this.dtRezervimi.Value);
//				int idGrupi = Convert.ToInt32(this.cmbGrupi.Kolone2Vlere);
//				//kontrollohen datat per rregullsi
//				int a = this.KntData(idKategoriaGrupi,dataFillimi,dataMbarimi);
//				if(a == 0)
//				{
//					//kontroll tjeter per datat
//					if (this.KontrolloDatatPerRezervim(dataFillimi, dataRezervimi) == 1)
//					{
//						System.Windows.Forms.MessageBox.Show(this, "Data e rezervimit nuk mund te jete me e madhe se data e fillimit te rezervimit!" + Environment.NewLine + "Ju lutem kryeni modifikimet e nevojshme para se te beni  rezervimin!", "Modifikimi i  rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Error);
//						return;
//					}
//					if (this.KontrolloGrupinPerRezervim(idGrupi, dataFillimi, dataMbarimi) == 1)
//						return;
//					int b = 0;
//					this.dtpFillimi1.IsValid = true;
//					this.error.SetError(this.dtpFillimi1,"");
//					int kapari = Convert.ToInt32( this.numKapari1.Text);
//					//duhet bere kontrolli i kaparit
//					int pagesa = this.GjejPagesen(dataFillimi, dataMbarimi);
//					if (kapari > pagesa)
//					{
//						System.Windows.Forms.MessageBox.Show(this, "Kapari i dhene rezulton me i madh se pagesa per dhomat!" + Environment.NewLine 
//							+ "Kryeni modifikimet e nevojshme!", "Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Error);
//						return;
//					}
//					int idFormaPagesa = Convert.ToInt32(this.cmbPagesaGrupi.Kolone2Vlere);
//					InputController data = new InputController();
//					if(System.DateTime.Now > Convert.ToDateTime(grid1[grid1.CurrentRowIndex,5]))
//					{
//						DialogResult result1 = VisionInfoSolutionLibrary.MessageBox.Show(this,"Modifikimi i rezervimeve",
//							"Kujdes, rezervimi nuk eshte i vlefshem. Deshironi te vazhdoni? ", 
//							MessageBoxButtons.YesNo
//							, MessageBoxIcon.Information);
//						if(result1 != DialogResult.Yes)
//						{
//							this.RefreshFormGrupi( sender,  e);
//							return;
//						}
//						else
//						{
//
//							b = data.KerkesaUpdate("ModifikoRezerviminPerGrup",idGrupi, kapari, idRezervimiGrupi,dataFillimi, 
//								dataMbarimi,dataRezervimi, idFormaPagesa);
//							if(b == 0)
//								this.RefreshFormGrupi( sender,  e);
//						}
//				
//					}
//					else
//					{
//						DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i rezervimeve",
//							"Jeni te sigurte qe doni te modifikoni  rezervimin e zgjedhur?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//						if (result != DialogResult.Yes)
//						{
//							this.RefreshFormGrupi( sender,  e);
//							return;
//						}
//						b = data.KerkesaUpdate("ModifikoRezerviminPerGrup",idGrupi, kapari, idRezervimiGrupi,
//							dataFillimi, dataMbarimi,dataRezervimi, idFormaPagesa);
//					}
//					if (b == 0)
//					{
//						this.RefreshFormGrupi( sender,  e);
//						System.Windows.Forms.MessageBox.Show(this,"Rezervimi i kryer nga grupi u modifikua!", "Modifikimi i rezervimeve",
//							MessageBoxButtons.OK, MessageBoxIcon.Information);
//					}
//					else
//					{
//						System.Windows.Forms.MessageBox.Show(this,"Rezervimi i kryer nga grupi nuk u modifikua! Provoni perseri!", "Modifikimi i rezervimeve",
//							MessageBoxButtons.OK, MessageBoxIcon.Information);
//					}
//				}		
//				else
//				{
//					this.dtpFillimi1.IsValid = false;
//					this.error.SetError(this.dtpFillimi1,"Data e fillimit per rezervimin duhet te jete me e vogel se data e mbarimit!");
//				}
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
//			finally
//			{
//				this.Cursor = Cursors.Default;
//			}
//		}
		private void btnModifiko1_Click(object sender, System.EventArgs e)
		{
			try
			{
				int b = this.ModifikoRezervimGrup(0);
				if (b == 0)
				{
					this.RefreshFormGrupi( sender,  e);
					System.Windows.Forms.MessageBox.Show(this,"Rezervimi i kryer nga grupi u modifikua!", "Modifikimi i rezervimeve",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (b == 1)
				{
					System.Windows.Forms.MessageBox.Show(this,"Rezervimi i kryer nga grupi nuk u modifikua! Provoni perseri!", "Modifikimi i rezervimeve",
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
	/// <summary>
	/// ben modifikimin e rezervimit ne grup
	/// </summary>
	/// <param name="x">nqs x = 0 modifikimi behet nga butoni Modifiko nqs x = 1 modifikimi behet nga shtimi i dhomave</param>
	/// <returns></returns>
		private int ModifikoRezervimGrup(int x)
		{
			if (this.idRezervimiGrupi == 0)
				return 2;
			DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimi1.Value);
			DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
			DateTime dataRezervimi = Convert.ToDateTime(this.dtRezervimi.Value);
			int idGrupi = Convert.ToInt32(this.cmbGrupi.Kolone2Vlere);
			//kontrollohen datat per rregullsi
			int a = this.KntData(idKategoriaGrupi,dataFillimi,dataMbarimi);
			if(a == 0)
			{
				//kontroll tjeter per datat
				if (this.KontrolloDatatPerRezervim(dataFillimi, dataRezervimi) == 1)
				{
					System.Windows.Forms.MessageBox.Show(this, "Data e rezervimit nuk mund te jete me e madhe se data e fillimit te rezervimit!" + Environment.NewLine + "Ju lutem kryeni modifikimet e nevojshme para se te beni  rezervimin!", "Modifikimi i  rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return 2;
				}
				if (this.KontrolloGrupinPerRezervim(idGrupi, dataFillimi, dataMbarimi, x) == 1)
					return 2;
				DataSet dsInfo = this.KontrolloDhomatRezervimGrupi();
				if (dsInfo.Tables[0].Rows.Count != 0)
				{
					string str = "Per datat e zgjedhura dhomat me poshte jane te zena:";
					foreach(DataRow dr in dsInfo.Tables[0].Rows)
					{
						str += Environment.NewLine + "--> " + dr["EMRI"].ToString();
					}
					str += Environment.NewLine + "Modifikoni datat ose fshini dhomat e zena!";
					System.Windows.Forms.MessageBox.Show(this, str, "Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return 2;
				}
				InputController data = new InputController();
				int b = 0;
				this.dtpFillimi1.IsValid = true;
				this.error.SetError(this.dtpFillimi1,"");
				int kapariRezervimi = Convert.ToInt32( this.numKapari1.Text);
				int kapariGrupi = 0;
				int idPergjegjes = 0;
				int kaparKlientiNeArke = 0;
				int index = this.grid1.CurrentRowIndex;
				//duhet bere kontrolli i kaparit vetem nqs eshte klikuar butoni Modifiko
				if ( x == 0)
				{
					DataSet dsHyrje = data.KerkesaRead("ShfaqVeprimetPerRezervim", this.idRezervimiGrupi);
					foreach(DataRow dr in dsHyrje.Tables[0].Rows)
					{
						kapariGrupi = Convert.ToInt32(dr["KAPARI"]);
						kaparKlientiNeArke = kapariGrupi - Convert.ToInt32(this.grid1[index, 7]);
						idPergjegjes = Convert.ToInt32(dr["ID_KLIENTI"]);
						if ( kapariGrupi > 0)
							break;
					}
					int pagesa = this.GjejPagesen(dataFillimi, dataMbarimi);
					if (dsHyrje.Tables[0].Rows.Count!= 0)
					{
						kapariGrupi = kaparKlientiNeArke + kapariRezervimi;
						//kjo eshte edhe vlera e re per kaparin e grupit
						if (kapariGrupi > pagesa)
						{
							System.Windows.Forms.MessageBox.Show(this, "Kapari i dhene rezulton me i madh se pagesa per dhomat!" + Environment.NewLine 
								+ "Kryeni modifikimet e nevojshme!", "Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return 2;
						}
					}
					else
					{
						if (kapariRezervimi > pagesa)
						{
							System.Windows.Forms.MessageBox.Show(this, "Kapari i dhene rezulton me i madh se pagesa per dhomat!" + Environment.NewLine 
								+ "Kryeni modifikimet e nevojshme!", "Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return 2;
						}					
					}
				}
				int idFormaPagesa = Convert.ToInt32(this.cmbPagesaGrupi.Kolone2Vlere);
				if(System.DateTime.Now > Convert.ToDateTime(grid1[grid1.CurrentRowIndex,5]))
				{
					DialogResult result1 = VisionInfoSolutionLibrary.MessageBox.Show(this,"Modifikimi i rezervimeve",
						"Kujdes, rezervimi nuk eshte i vlefshem. Deshironi te vazhdoni? ", 
						MessageBoxButtons.YesNo
						, MessageBoxIcon.Information);
					if(result1 != DialogResult.Yes)
					{
						return 2;
					}
					else
					{
						if (x == 0)//modifikimi i datave dhe i atributeve te tjere behet vetem nqs klikoohet butoni Modifiko
						{
							b = data.KerkesaUpdate("ModifikoRezerviminPerGrup",idGrupi, kapariRezervimi, idRezervimiGrupi,dataFillimi, 
								dataMbarimi,dataRezervimi, idFormaPagesa, kapariGrupi, idPergjegjes, this.PerdoruesId);
						}
					}
				}
				else
				{
					DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i rezervimeve",
						"Jeni te sigurte qe doni te modifikoni  rezervimin e zgjedhur?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result != DialogResult.Yes)
					{
						return 2;
					}
					if (x == 0)//modifikimi i datave dhe i atributeve te tjere behet vetem nqs klikoohet butoni Modifiko
					{
						b = data.KerkesaUpdate("ModifikoRezerviminPerGrup",idGrupi, kapariRezervimi, idRezervimiGrupi,
							dataFillimi, dataMbarimi,dataRezervimi, idFormaPagesa, kapariGrupi, idPergjegjes, this.PerdoruesId);
					}
				}
				if (b == 0)
				{
					return 0;
				}
				else
				{
					return 1;
				}
			}	
			else
			{
				this.dtpFillimi1.IsValid = false;
				this.error.SetError(this.dtpFillimi1,"Data e fillimit per rezervimin duhet te jete me e vogel se data e mbarimit!");
				return 1;
			}
		}
		private void grid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.zgjedhur = true;
				int rowIndex = grid1.CurrentRowIndex;
				this.lvDhomatLira.Items.Clear();
				this.cmbGrupi.Kolone1.Text = grid1[rowIndex,0].ToString();
				this.cmbGrupi.Kolone2Vlere = Convert.ToInt32(grid1[rowIndex,9]);
				this.dtRezervimi.Value = Convert.ToDateTime(grid1[rowIndex,6]);
				this.dtpFillimi1.Value = Convert.ToDateTime(grid1[rowIndex,4]);
				this.dtpMbarimi.Value = Convert.ToDateTime(grid1[rowIndex,5]);
				this.numKapari1.Text = grid1[rowIndex , 7].ToString();
				this.idRezervimiGrupi = Convert.ToInt32(grid1[rowIndex, 8]);
				InputController data = new InputController();
				DataSet dsFormaPagesa = data.KerkesaRead("ShfaqFormePagesePerRezervim", this.idRezervimiGrupi);
				if (dsFormaPagesa.Tables[0].Rows.Count != 0)
				{
					int idFormaPagesa = Convert.ToInt32(dsFormaPagesa.Tables[0].Rows[0]["ID_FORMAPAGESA"]);
					string pagesa = dsFormaPagesa.Tables[0].Rows[0]["EMRI"].ToString();
					this.cmbPagesaGrupi.Kolone1.Text = pagesa;
					this.cmbPagesaGrupi.Kolone1Vlere = pagesa;
					this.cmbPagesaGrupi.Kolone2.Text = idFormaPagesa.ToString();
					this.cmbPagesaGrupi.Kolone2Vlere = idFormaPagesa;
				}
				else
				{
					this.cmbPagesaGrupi.Kolone1.Text = "Cash";
					this.cmbPagesaGrupi.Kolone1Vlere = "Cash";
					this.cmbPagesaGrupi.Kolone2.Text = "1";
					this.cmbPagesaGrupi.Kolone2Vlere = 1;
				}
				DataSet ds = null;
				int idGrupi = Convert.ToInt32(this.cmbGrupi.Kolone2Vlere);
				data = new InputController();
				DateTime dtFillimi = Convert.ToDateTime(grid1[rowIndex,4]);
				ds = data.KerkesaRead("ShfaqDhomaPerRezervimGrupiPerdata",this.idRezervimiGrupi, dtFillimi);
				this.idKategoriaGrupi = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
				this.LoadList(ds);
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

		private void btnShtoDhome_Click(object sender, System.EventArgs e)
		{
			try
			{
				int index = this.grid1.CurrentRowIndex;
				this.ReSetTeDhena();
				int x = this.ModifikoRezervimGrup(1);
				if (x != 0)
					return;
				this.Cursor = Cursors.WaitCursor;
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimi1.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
				if (this.KntData1(dtFillimi, dtMbarimi) == 1)
				{
					this.error.SetError(this.dtpFillimi1, "Data e fillimit duhet te jete me e vogel se data e mbarimit!");
					this.dtpFillimi1.IsValid = false;
					return;
				}
				this.error.SetError(this.dtpFillimi1, "");
				this.dtpFillimi1.IsValid = true;
				InputController data = new InputController();    
				Dhoma1 frm = new Dhoma1(dtFillimi,dtMbarimi);
				frm.ShowDialog(this);
				DateTime dt = Convert.ToDateTime(dtpFillimi1.Value);
				//frm.Location = new System.Drawing.Point(350, 300);
				if (!frm.Visible) 
				{
					this.lvDhomatLira.View = View.Details;
					if ((frm.idDhoma == null)||(frm.idDhoma.Length == 0))
						return;
					for (int i = 0; i < frm.idDhoma.Length; i++)
					{
						// Percakto listItems/1kategoria,0 id_dhoma,4dhoma_emri
						ds = data.KerkesaRead("ShfaqTeDhenatPerDhome",frm.idDhoma[i], dt);
						DataRow dr = ds.Tables[0].Rows[0];
						ListViewItem lvi = new ListViewItem(dr[2].ToString());
						lvi.SubItems.Add(dr[1].ToString());
						lvi.SubItems.Add(dr[0].ToString());
						lvi.SubItems.Add(dr["ID_KATEGORIA"].ToString());
						lvi.SubItems.Add(dr["CMIMI"].ToString());
						this.lvDhomatLira.Items.Add(lvi);
					}
					int nr = this.lvDhomatLira.Items.Count;
					if (nr> 7)
					{
						this.lvDhomatLira.Width = 180;
					}
					else
					{
						this.lvDhomatLira.Width = 162;
					}	
				}
				frm.Close();
				int b = data.KerkesaUpdate("KrijoRezervimDhomeGrupi", idRezervimiGrupi,frm.idDhoma);
				if(b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this,"Dhomat e zgjedhura u shtuan!", "Modifikimi i rezervimeve", 
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.RefreshFormGrupi(sender, e);
					this.grid1.CurrentRowIndex = index;
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.ReSetTeDhena();
				if (this.lvDhomatLira.SelectedItems.Count == 0)
					return;
				int nrDhoma = Convert.ToInt32(this.lvDhomatLira.Items.Count);
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimi1.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimi.Value);
				if (this.KntData1(dtFillimi, dtMbarimi) == 1)
				{
					this.error.SetError(this.dtpFillimi1, "Data e fillimit duhet te jete me e vogel se data e mbarimit!");
					this.dtpFillimi1.IsValid = false;
					return;
				}
				this.error.SetError(this.dtpFillimi1, "");
				this.dtpFillimi1.IsValid = true;
				if(nrDhoma == 1)
				{
					System.Windows.Forms.MessageBox.Show(this,"Kujdes, rezervimi i zgjedhur duhet te kete te pakten nje dhome!", "Modifikimi i rezervimeve",
						 MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				else
				{
					int idDhoma = Convert.ToInt32(this.lvDhomatLira.SelectedItems[0].SubItems[2].Text);
					InputController data = new InputController();
					DataSet dsHyrje  = data.KerkesaRead("ShfaqVeprimetPerRezervim", this.idRezervimiGrupi);
					int kapariGrupi = 0;
					foreach(DataRow dr in dsHyrje.Tables[0].Rows)
					{
						kapariGrupi = Convert.ToInt32(dr["KAPARI"]);
						if (kapariGrupi > 0)
							break;
					}
					int kapari = 0;
					if (dsHyrje.Tables[0].Rows.Count > 0)// ka futje nga rezervimi
						kapari = kapariGrupi;
					else
					    kapari = Convert.ToInt32(this.numKapari1.Text);
					int pagesa = this.GjejPagesen(dtFillimi, dtMbarimi, idDhoma);
					if (kapari > pagesa)
					{
						System.Windows.Forms.MessageBox.Show(this, "Modifikimi nuk mund te kryhet!"+ Environment.NewLine + "Pas eleminimit te dhomes nga rezervimi kapari" + Environment.NewLine + "rezulton  me i madh se pagesa e grupit per dhomat.",
							"Modifikimi i rezervimeve", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					int b  = data.KerkesaUpdate("FshiDhomeRezervuarGrupi",this.idRezervimiGrupi,idDhoma);
					if (b == 0)
						System.Windows.Forms.MessageBox.Show(this,"Dhoma e rezervuar nga grupi u eliminua!", "Modifikimi i rezervimeve",
							 MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.RefreshlvDhomatLira();
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
//				if ((grid1.VisibleRowCount != 0)&&(this.zgjedhur == true))
//				{
//					InputController data = new InputController();
//					int rowIndex = this.grid1.CurrentRowIndex;
//					this.idRezervimiGrupi = Convert.ToInt32(grid1[rowIndex, 8]);
//					ds = data.KerkesaRead("ShfaqDhomaPerRezervimGrupi",this.idRezervimiGrupi);
//					this.LoadList(ds);
//				}
			}
			catch(Exception ex)
			{
				return;
			}
		}

		private void dtpMbarimi_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
//				if ((grid1.VisibleRowCount != 0)&&(this.zgjedhur == true))
//				{
//					InputController data = new InputController();
//					int rowIndex = this.grid1.CurrentRowIndex;
//					this.idRezervimiGrupi = Convert.ToInt32(grid1[rowIndex, 8]);
//					ds = data.KerkesaRead("ShfaqDhomaPerRezervimGrupi",this.idRezervimiGrupi);
//					this.LoadList(ds);
//				}
			}
			catch(Exception ex)
			{
				return;
			}
		}
		#endregion

		#region MetodaNdihmese
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
//		private int KntData(int idKategoria,DateTime dtFillimi,DateTime dtMbarimi )
//		{
//			int a = 0;
//			System.TimeSpan nrDite = dtFillimi.Subtract(dtMbarimi);
//			int difDite = Convert.ToInt32(nrDite.Days);
//			int difOre = Convert.ToInt32(nrDite.Hours);
//			if(idKategoria != 31)
//			{
//				if (difDite > 0  || difOre > 0)
//					a = 1;	
//				else
//					a = 0;
//			}
//			else
//			{
//				if (difDite != 0 )
//				{
//					if(difDite > 0)
//						a = 1;
//					else
//						a = 0;
//				}
//				else if(difDite == 0)
//				{
//					if(difOre >= 0)
//						a = 1;
//					else
//						a = 0;
//				}
//				else
//					a = 0;
//			}
//			return a;	
//				
//		}
		private int KntData(int idKategoria,DateTime dtFillimi,DateTime dtMbarimi )
		{
			TimeSpan ts = dtMbarimi.Subtract(dtFillimi);
			if (idKategoria == 31)
			{
				double nrOre = ts.TotalHours;
				if (nrOre >= 1)
					return 0;
				else
					return 1;
			}
			else
			{
				ts = dtMbarimi.Date.Subtract(dtFillimi.Date);
				double nrDite = ts.TotalDays;
				if (nrDite >= 1)
					return 0;
				else
					return 1;
			}	
		}

		private int KntData1(DateTime dtFillimi,DateTime dtMbarimi )
		{
			TimeSpan ts = dtMbarimi.Subtract(dtFillimi);
			double nrOre = ts.TotalHours;
			if (nrOre >= 1)
				return 0;
			else
				return 1;
		}

		private void KrijoStilGrid()
		{
			this.grid.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			this.grid.ReadOnly = true;

			DataGridTextBoxColumn colEmri = new DataGridTextBoxColumn();
			colEmri.HeaderText = "Emri";
			colEmri.MappingName = "EMRI";
			colEmri.Width = 80;

			DataGridTextBoxColumn colMbiemri = new DataGridTextBoxColumn();
			colMbiemri .HeaderText = "Mbiemri";
			colMbiemri .MappingName = "MBIEMRI";
			colMbiemri .Width =80;
			colMbiemri .TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			
				
			DataGridTextBoxColumn colKategoria = new DataGridTextBoxColumn();
			colKategoria .HeaderText = "Kategoria";
			colKategoria .MappingName = "KAT_EMRI";
			colKategoria .Width =0;
			colKategoria .TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			
			DataGridTextBoxColumn colDhoma = new DataGridTextBoxColumn();
			colDhoma .HeaderText = "Dhoma";
			colDhoma .MappingName = "DHOMA_EMRI";
			colDhoma .Width =70;
			colDhoma .TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		
			DataGridTextBoxColumn colDateRezervimi = new DataGridTextBoxColumn();
			colDateRezervimi.HeaderText = "Date Rezervimi";
			colDateRezervimi.MappingName = "DATA_REZERVIMI";
			colDateRezervimi.Width = 0;
			colDateRezervimi.NullText = "";

			DataGridTextBoxColumn colDateFillimi = new DataGridTextBoxColumn();
			colDateFillimi.HeaderText = "Date Fillimi";
			colDateFillimi.MappingName = "DATA_HYRJE_STR";
			colDateFillimi.Width = 150;
			colDateFillimi.NullText = "";

			DataGridTextBoxColumn colDateMbarimi = new DataGridTextBoxColumn();
			colDateMbarimi .HeaderText = "Date Mbarimi";
			colDateMbarimi .MappingName = "DATA_DALJE_STR";
			colDateMbarimi .Width = 150;
			colDateMbarimi .NullText = "";
			
			
			DataGridTextBoxColumn colDateFillimi1 = new DataGridTextBoxColumn();
			colDateFillimi1.HeaderText = "Date Fillimi";
			colDateFillimi1.MappingName = "DATA_FILLIMI";
			colDateFillimi1.Width = 0;
			colDateFillimi1.NullText = "";

			DataGridTextBoxColumn colDateMbarimi1 = new DataGridTextBoxColumn();
			colDateMbarimi1.HeaderText = "Date Mbarimi";
			colDateMbarimi1.MappingName = "DATA_MBARIMI";
			colDateMbarimi1.Width = 0;
			colDateMbarimi1.NullText = "";

			DataGridTextBoxColumn colKapari = new DataGridTextBoxColumn();
			colKapari.HeaderText = "Kapari";
			colKapari.MappingName = "KAPARI";
			colKapari.Width = 50;

			DataGridTextBoxColumn colIdRezervimi= new DataGridTextBoxColumn();
			colIdRezervimi.HeaderText = "IdRezervimi";
			colIdRezervimi.MappingName = "ID_REZERVIMI";
			colIdRezervimi.Width = 0;

			DataGridTextBoxColumn colIdKategoria = new DataGridTextBoxColumn();
			colIdKategoria.HeaderText = "IdKategoria";
			colIdKategoria.MappingName = "ID_KATEGORIA";
			colIdKategoria.Width = 0;

			DataGridTextBoxColumn colIdDhoma = new DataGridTextBoxColumn();
			colIdDhoma.HeaderText = "IdDhoma";
			colIdDhoma.MappingName = "ID_DHOMA";
			colIdDhoma.Width = 0;

			DataGridTextBoxColumn colEmaili = new DataGridTextBoxColumn();
			colEmaili.HeaderText = "Emaili";
			colEmaili.MappingName = "EMAILI";
			colEmaili.Width = 50;
			colEmaili.NullText = "";

			style.GridColumnStyles.AddRange(
				new DataGridColumnStyle[]{colEmri, colMbiemri,colKategoria,colDhoma, 
											 colDateRezervimi,colDateFillimi, colDateMbarimi ,
											 colDateFillimi1, colDateMbarimi1, colKapari, colIdRezervimi,
											 colIdKategoria, colIdDhoma, colEmaili});
			grid.TableStyles.Add(style);
			grid.FlatMode = false;
			grid.Expand(-1);

		}
	
		private void RefreshFormKlienti(object sender, System.EventArgs e)
		{
			DataSet ds = null;
			InputController data = new InputController();
			this.Pastro(this.groupBox4);
			if ((rbData.Checked== true)||(rbEmri.Checked == true)||(this.rbRezervimeSkaduara1.Checked == true))
			{		
				this.btnKerko1_Click(sender, e);
			}
			else
			{
				this.ModifikoRezervim_Load(sender, e);
				numKapariKlienti.Text = "";
				cmbDhoma.Kolone1.Items.Clear();
				cmbDhoma.Kolone2.Items.Clear();
			}
		}

		private void LoadList(DataSet ds)
		{
			this.lvDhomatLira.Items.Clear();
			DataTable dTable = ds.Tables[0];
			this.lvDhomatLira.View = View.Details;
			for (int i = 0; i < dTable.Rows.Count; i++)
			{
				// Percakto listItems/1dhoma_emri,0 id_dhoma,4 cmimi
				DataRow dr = dTable.Rows[i];
				ListViewItem lvi = new ListViewItem(dr[3].ToString());
				lvi.SubItems.Add(dr[2].ToString());
				lvi.SubItems.Add(dr[0].ToString());
				lvi.SubItems.Add(dr["ID_KATEGORIA"].ToString());
				lvi.SubItems.Add(dr["CMIMI"].ToString());
				this.lvDhomatLira.Items.Add(lvi);
			}
			int nr = this.lvDhomatLira.Items.Count;
			if (nr> 7)
			{
				this.lvDhomatLira.Width = 180;
			}
			else
			{
				this.lvDhomatLira.Width = 162;
			}
		}

		private void KrijoStilGrid1()
		{
			this.grid1.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			this.grid1.ReadOnly = true;

			DataGridTextBoxColumn colEmri = new DataGridTextBoxColumn();
			colEmri.HeaderText = "Emri";
			colEmri.MappingName = "EMRI";
			colEmri.Width = 90;

			DataGridTextBoxColumn colAgjensia = new DataGridTextBoxColumn();
			colAgjensia .HeaderText = "Agjensia";
			colAgjensia .MappingName = "AGJENSIA";
			colAgjensia .Width =90;
			colAgjensia .TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
					
			DataGridTextBoxColumn colDateFillimi = new DataGridTextBoxColumn();
			colDateFillimi.HeaderText = "Date Fillimi";
			colDateFillimi.MappingName = "DATA_HYRJE_STR";
			colDateFillimi.Width = 150;
			colDateFillimi.NullText = "";

			DataGridTextBoxColumn colDateMbarimi = new DataGridTextBoxColumn();
			colDateMbarimi .HeaderText = "Date Mbarimi";
			colDateMbarimi .MappingName = "DATA_DALJE_STR";
			colDateMbarimi .Width = 150;
			colDateMbarimi .NullText = "";

			DataGridTextBoxColumn colDateFillimi1 = new DataGridTextBoxColumn();
			colDateFillimi1.HeaderText = "Date Fillimi";
			colDateFillimi1.MappingName = "DATA_FILLIMI";
			colDateFillimi1.Width = 0;
			colDateFillimi1.NullText = "";

			DataGridTextBoxColumn colDateMbarimi1 = new DataGridTextBoxColumn();
			colDateMbarimi1 .HeaderText = "Date Mbarimi";
			colDateMbarimi1 .MappingName = "DATA_MBARIMI";
			colDateMbarimi1 .Width = 0;
			colDateMbarimi1 .NullText = "";

			DataGridTextBoxColumn colDateRezervimi = new DataGridTextBoxColumn();
			colDateRezervimi .HeaderText = "Date Rezervimi";
			colDateRezervimi .MappingName = "DATA_REZERVIMI";
			colDateRezervimi .Width = 0;
			colDateRezervimi .NullText = "";

			DataGridTextBoxColumn colKapari = new DataGridTextBoxColumn();
			colKapari.HeaderText = "Kapari";
			colKapari.MappingName = "KAPARI";
			colKapari.Width = 50;

			DataGridTextBoxColumn colIdRezervimi = new DataGridTextBoxColumn();
			colIdRezervimi.HeaderText = "IdRezervimi";
			colIdRezervimi.MappingName = "ID_REZERVIMI";
			colIdRezervimi.Width = 0;

			DataGridTextBoxColumn colIdGrupi = new DataGridTextBoxColumn();
			colIdGrupi.HeaderText = "IdGrupi";
			colIdGrupi.MappingName = "ID_GRUPI";
			colIdGrupi.Width = 0;

			DataGridTextBoxColumn colDateKapari = new DataGridTextBoxColumn();
			colDateKapari.HeaderText = "";
			colDateKapari.MappingName = "DATA_KAPARI";
			colDateKapari.Width = 0;
			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{ 
			colEmri, colAgjensia,colDateFillimi, colDateMbarimi ,colDateFillimi1,
			colDateMbarimi1 ,colDateRezervimi, colKapari, colIdRezervimi, colIdGrupi,colDateKapari});
			
			grid1.TableStyles.Add(style);
			grid1.FlatMode = false;
			grid1.Expand(-1);
		}

		private void RefreshlvDhomatLira()
		{
			this.lvDhomatLira.Items.Clear();
			DataSet ds = null;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqDhomaPerRezervimGrupi",this.idRezervimiGrupi);
			this.LoadList(ds);
		}

		private void RefreshFormGrupi(object sender, System.EventArgs e)
		{
			DataSet ds = null;
			this.zgjedhur = false;
			InputController data = new InputController();
			this.Pastro(groupBox5);
			this.idRezervimiGrupi = 0;
			if ((this.rbData1.Checked== true)||(this.rbGrupi.Checked == true)||(this.rbRezervimeSkaduara2.Checked == true))
			{
				this.btnKerko_Click(sender, e);
			}
			else
			{
				this.ModifikoRezervim_Load(sender, e);
				this.lvDhomatLira.Items.Clear();
			}		
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

		private int KontrolloDatatPerRezervim(DateTime dtFillimi, DateTime dtRezervimi)
		{
			if (dtRezervimi.Date > dtFillimi.Date)
				return 1;
			else
				return 0;
		}

		/// <summary>
		/// Kontrollohet nqs
		/// 1. per datat e dhena grupi ka ndonje rezervim tjeter
		/// 2. per datat e dhena grupi ka ndonje hyrje tjeter
		/// Nqs ndodh ndonje nga keta raste veprimi eshte i parregullt
		/// </summary>
		/// <param name="idGrupi"></param>
		/// <param name="dtFillimi"></param>
		/// <param name="dtMbarimi"></param>
		/// <returns></returns>
		private int KontrolloGrupinPerRezervim(int idGrupi, DateTime dtFillimi, DateTime dtMbarimi, int x)
		{
			InputController data  = new InputController();
			//Kontroll1
			//kontrollojme nqs ka rezervime per datat e dhena per grupin ne fjale te zgjedhur
			//ne rast se po nuk mund te kryhet nje hyrje per keto data
			DataSet dsRezervime = data.KerkesaRead("RezervimetPerDatatDheGrupin", idGrupi, dtFillimi, dtFillimi, this.idRezervimiGrupi);
			if (dsRezervime.Tables[0].Rows.Count != 0)
			{
				string s = "Grupi ka nje rezervim ne hotel per intervalin e datave";
				foreach(DataRow rz in dsRezervime.Tables[0].Rows)
				{
					s += Environment.NewLine + this.konverto(Convert.ToDateTime(rz["DATA_FILLIMI"])) + " dhe " + this.konverto(Convert.ToDateTime(rz["DATA_MBARIMI"]));
				}
				s += Environment.NewLine + "Nuk mund te beni rezervim ne emer te ketij grupi per datat e  dhena!";
				System.Windows.Forms.MessageBox.Show(this, s, "Modifiko rezervime", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 1;
			}
			//Kontroll 3
			DataSet dsHyrje = data.KerkesaRead("ShfaqVeprimetPerRezervim", this.idRezervimiGrupi);
			if (dsHyrje.Tables[0].Rows.Count != 0)//jane kryer futje nga rezervimi, rezervimi nuk mund te modifikohet me tej
			{
				int index = this.grid1.CurrentRowIndex;
				DateTime dataFillRez = Convert.ToDateTime(this.grid1[index, 4]);
				DateTime dataFundRez = Convert.ToDateTime(this.grid1[index, 5]);
				int idGrupiRi = Convert.ToInt32(this.cmbGrupi.Kolone2Vlere);
				int idGrupiVjeter = Convert.ToInt32(this.grid1[index, 9]);
				if ((dtFillimi != dataFillRez)||(idGrupiRi != idGrupiVjeter))
				{
					string s1 = "Per rezervimin qe po tentohet te modifikohet jane futur kliente.";
					s1 += Environment.NewLine + "Rezervimi nuk mund te modifikohet me tej!";
					foreach(DataRow rh in dsHyrje.Tables["KLIENTI"].Rows)
					{
						s1 += Environment.NewLine + this.konverto(Convert.ToDateTime(rh["MINDATA"])) + " dhe " + this.konverto(Convert.ToDateTime(rh["MAXDATA"]));
					}
					System.Windows.Forms.MessageBox.Show(this, s1, "Modifiko rezervime", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return 1;
				}
			}
			//Kontroll 2
			//kontrollojme nqs ka hyrje per datat e dhena per grupin e zgjedhur qe nuk i perkasin rezervimit te zgjedhur
			dsHyrje = data.KerkesaRead("ShfaqVeprimetPerGrupinPaRezervim", idGrupi,dtFillimi, dtMbarimi, this.idRezervimiGrupi);
			if (dsHyrje.Tables.Count == 2)
			{
				string s1 = "Grupi ka hyrje ne hotel qe nuk i perkasin rezervimit per intervalin e datave";
				foreach(DataRow rh in dsHyrje.Tables["KLIENTI"].Rows)
				{
					s1 += Environment.NewLine + this.konverto(Convert.ToDateTime(rh["MINDATA"])) + " dhe " + this.konverto(Convert.ToDateTime(rh["MAXDATA"]));
				}
				s1 += Environment.NewLine + "Nuk mund te beni rezervim ne emer te ketij grupi per datat e  dhena!";
				System.Windows.Forms.MessageBox.Show(this, s1, "Modifiko rezervime", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 1;
			}
			return 0;
		}
		/// <summary>
		/// gjen pagesen per listen e dhomave te zgjedhura per rezervim
		/// </summary>
		/// <param name="dtFillimi"></param>
		/// <param name="dtMbarimi"></param>
		/// <returns></returns>
		private int GjejPagesen(DateTime dtFillimi, DateTime dtMbarimi)
		{
			int pagesa = 0;
			int nr = this.lvDhomatLira.Items.Count;
			//gjendet pagesa per dhomat e rezervuara
			for(int i = 0;i < nr; i++ )
			{
				ListViewItem lvi = this.lvDhomatLira.Items[i];
				int cmimi = Convert.ToInt32(lvi.SubItems[4].Text);
				int idKategoria = Convert.ToInt32(lvi.SubItems[3].Text);
				pagesa = pagesa + this.GjejPagesen(idKategoria, cmimi, dtFillimi, dtMbarimi);
			}
			InputController data = new InputController();
			DataSet dsHyrje = data.KerkesaRead("ShfaqVeprimetPerRezervim", this.idRezervimiGrupi);
			DataSet dsPagesa = this.PagesaGrupi(dsHyrje);
			foreach(DataRow dr in dsPagesa.Tables[0].Rows)
			{
				int pagesaDhoma = Convert.ToInt32(dr["VLERA"]);
				pagesa += pagesaDhoma;
			}
			return pagesa;
		}
		/// <summary>
		/// gjen pagesen per listen e dhomave te zgjedhura per rezervim
		/// pa perfshire dhomen e zgjedhur per tu eleminuar
		/// </summary>
		/// <param name="dtFillimi"></param>
		/// <param name="dtMbarimi"></param>
		/// <returns></returns>
		private int GjejPagesen(DateTime dtFillimi, DateTime dtMbarimi, int idDhoma)
		{
			int pagesa = 0;
			int nr = this.lvDhomatLira.Items.Count;
			//gjendet pagesa per dhomat e rezervuara
			for(int i = 0;i < nr; i++ )
			{
				ListViewItem lvi = this.lvDhomatLira.Items[i];
				if (Convert.ToInt32(lvi.SubItems[2].Text) != idDhoma)
				{
					int cmimi = Convert.ToInt32(lvi.SubItems[4].Text);
					int idKategoria = Convert.ToInt32(lvi.SubItems[3].Text);
					pagesa = pagesa + this.GjejPagesen(idKategoria, cmimi, dtFillimi, dtMbarimi);
				}
			}
			InputController data = new InputController();
			DataSet dsHyrje = data.KerkesaRead("ShfaqVeprimetPerRezervim", this.idRezervimiGrupi);
			DataSet dsPagesa = this.PagesaGrupi(dsHyrje);
			foreach(DataRow dr in dsPagesa.Tables[0].Rows)
			{
				int pagesaDhoma = Convert.ToInt32(dr["VLERA"]);
				pagesa += pagesaDhoma;
			}
			return pagesa;
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

		private DataSet KontrolloDhomatRezervimGrupi()
		{
			DateTime dtFillimi = Convert.ToDateTime(dtpFillimi1.Value);
			DateTime dtMbarimi = Convert.ToDateTime(dtpMbarimi.Value);
			InputController data = new InputController();
			DataSet ds = data.KerkesaRead("DhomatEZenaPerDatatPaRezervim", this.idRezervimiGrupi, dtFillimi, dtMbarimi);
			DataSet dsInfo = new DataSet();
			dsInfo.Tables.Add();
			dsInfo.Tables[0].Columns.Add("ID_DHOMA", typeof(Int32));
			dsInfo.Tables[0].Columns.Add("EMRI", typeof(Int32));
			int nr = this.lvDhomatLira.Items.Count;
			for(int i = 0;i < nr; i++ )
			{
				ListViewItem lvi = this.lvDhomatLira.Items[i];
				int idDhoma = Convert.ToInt32(lvi.SubItems[2].Text);
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					if (idDhoma == Convert.ToInt32(dr["ID_DHOMA"]))
					{
						DataRow newrow = dsInfo.Tables[0].NewRow();
						newrow["ID_DHOMA"] = idDhoma;
						newrow["EMRI"] = Convert.ToInt32(lvi.SubItems[1].Text);
						dsInfo.Tables[0].Rows.Add(newrow);
						break;
					}
				}
			}
			dsInfo.AcceptChanges();
			return dsInfo;
		}
		private DataSet PagesaGrupi(DataSet ds)
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
						DataSet klienti = data.KerkesaRead("ShfaqTeDhenaKlientiId", Convert.ToInt32(r["ID_KLIENTI"]));
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
		private void ReSetTeDhena()
		{
			InputController data = new InputController();
			int index = this.grid1.CurrentRowIndex;
			if (this.grid1.CurrentRowIndex == -1)
				return;
			this.dtpFillimi1.Value = Convert.ToDateTime(this.grid1[index, 4]);
			this.dtpMbarimi.Value = Convert.ToDateTime(this.grid1[index, 5]);
			dtRezervimi.Value = Convert.ToDateTime(this.grid1[index, 6]);
			numKapari1.Text = this.grid1[index, 7].ToString();
			DataSet dsFormaPagesa = data.KerkesaRead("ShfaqFormePagesePerRezervim", this.idRezervimiGrupi);
			if (dsFormaPagesa.Tables[0].Rows.Count != 0)
			{
				int idFormaPagesa = Convert.ToInt32(dsFormaPagesa.Tables[0].Rows[0]["ID_FORMAPAGESA"]);
				string pagesa = dsFormaPagesa.Tables[0].Rows[0]["EMRI"].ToString();
				this.cmbPagesaGrupi.Kolone1.Text = pagesa;
				this.cmbPagesaGrupi.Kolone1Vlere = pagesa;
				this.cmbPagesaGrupi.Kolone2.Text = idFormaPagesa.ToString();
				this.cmbPagesaGrupi.Kolone2Vlere = idFormaPagesa;
			}
			else
			{
				this.cmbPagesaGrupi.Kolone1.Text = "Cash";
				this.cmbPagesaGrupi.Kolone1Vlere = "Cash";
				this.cmbPagesaGrupi.Kolone2.Text = "1";
				this.cmbPagesaGrupi.Kolone2Vlere = 1;
			}
		}
		#endregion

	}		
}
