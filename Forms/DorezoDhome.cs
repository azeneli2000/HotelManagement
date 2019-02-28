using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using VisionInfoSolutionLibrary;
using HotelManagment.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;

namespace HotelManagment
{
	/// <summary>
	/// Summary description for DorezoDhome.
	/// </summary>
	public class DorezoDhome1 : VisionInfoSolutionLibrary.Form, IPrintable
	{
		#region Private Fields
		private VisionInfoSolutionLibrary.TabControl tabControl1;
		private VisionInfoSolutionLibrary.TabPageControl tbKlient;
		private VisionInfoSolutionLibrary.TabPageControl tbGrup;
		private VisionInfoSolutionLibrary.GroupBox gbDorezim;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDorezim;
		private VisionInfoSolutionLibrary.Label lblDhoma;
		private VisionInfoSolutionLibrary.Label lblMbiemri;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhomat;
		private VisionInfoSolutionLibrary.Button btnDorezoKlient;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.DoubleCombo cmbGrupet;
		private VisionInfoSolutionLibrary.Label label4;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.TextBox txtAgjensia;
		private VisionInfoSolutionLibrary.Label label6;
		private VisionInfoSolutionLibrary.Label label7;
		private VisionInfoSolutionLibrary.Label label8;
		private VisionInfoSolutionLibrary.NumericBox numSkonto;
		private VisionInfoSolutionLibrary.Label label9;
		private VisionInfoSolutionLibrary.DoubleListBox lbKlientet;
		private VisionInfoSolutionLibrary.Button btnNdihme;
		private VisionInfoSolutionLibrary.DoubleListBox lbKlientetGrupi;
		private VisionInfoSolutionLibrary.DoubleListBox lbKlientetLargim;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimiGrupi;
		private VisionInfoSolutionLibrary.Button btnDorezimKlienti;
		private VisionInfoSolutionLibrary.Button btnKaloDjathtas;
		private VisionInfoSolutionLibrary.Button btnKaloMajtas;
		private VisionInfoSolutionLibrary.Button btnDorezoGrup;
		private System.ComponentModel.IContainer components;
		private VisionInfoSolutionLibrary.NumericBox numGjoba;
		private VisionInfoSolutionLibrary.Label label12;
		private VisionInfoSolutionLibrary.NumericBox numGjobaGrupi;
		private VisionInfoSolutionLibrary.Label label13;
		private VisionInfoSolutionLibrary.NumericBox numSkontoGrupi;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategoriteKlient;
		private VisionInfoSolutionLibrary.Label label14;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.Button btnPagesaDhoma;
		private VisionInfoSolutionLibrary.DataGrid gridPagesa;
		private VisionInfoSolutionLibrary.Button btnShfaqDetyrimeKlientet;
		private VisionInfoSolutionLibrary.GroupBox groupBox3;
		private VisionInfoSolutionLibrary.DataGrid gridDetyrime;
		private VisionInfoSolutionLibrary.Button btnPrinto;
		private VisionInfoSolutionLibrary.GroupBox groupBox4;
		private VisionInfoSolutionLibrary.GroupBox groupBox5;
		private VisionInfoSolutionLibrary.DataGrid gridPagesaGrupi;
		private VisionInfoSolutionLibrary.DataGrid gridDetyrimiGrupi;
		private VisionInfoSolutionLibrary.Button btnLlogaritPagesen;
		private System.Windows.Forms.ToolTip toolTip1;
		private VisionInfoSolutionLibrary.Button btnPrintoGrup;
		private VisionInfoSolutionLibrary.PrintButton pbtnPrint;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.DataGrid dgDhomaPaDorezuara;
		private VisionInfoSolutionLibrary.GroupBox gbDhomaPaDorezuara1;
		private VisionInfoSolutionLibrary.GroupBox gbDhomatPaDorezuara2;
		private VisionInfoSolutionLibrary.DataGrid dgDhomatPaDorezuaraGrup;
		private VisionInfoSolutionLibrary.ComboBox comboBox1;
		private VisionInfoSolutionLibrary.ComboBox comboBox2;
		private VisionInfoSolutionLibrary.ComboBox comboBox7;
		private VisionInfoSolutionLibrary.ComboBox comboBox8;
		private VisionInfoSolutionLibrary.Label label29;
		private VisionInfoSolutionLibrary.DoubleCombo cmbPagesaKlienti;
		private VisionInfoSolutionLibrary.ComboBox comboBox3;
		private VisionInfoSolutionLibrary.ComboBox comboBox4;
		private VisionInfoSolutionLibrary.ComboBox comboBox5;
		private VisionInfoSolutionLibrary.ComboBox comboBox6;
		private VisionInfoSolutionLibrary.ComboBox comboBox9;
		private VisionInfoSolutionLibrary.ComboBox comboBox10;
		private VisionInfoSolutionLibrary.Label label10;
		private VisionInfoSolutionLibrary.DoubleCombo cmbPagesaGrupi;
		private System.Data.DataSet kliente;
		private System.Data.DataSet pagesa;
		private System.Data.DataSet info;
		private System.Data.DataSet pagesa_grupi;
		private System.Data.DataSet kliente_grupi;
		private System.Data.DataSet info_grupi;
		private System.Data.DataSet detyrimeGrupi;
		private int total_dhomat_grupi;
		private int total_dhoma;
		private int total_detyrime_grupi;
		private int total_detyrime;
		private int pergjegjes;
		private int pergjegjes_grupi;
		private int[] id_kliente_grupi;
		private System.Data.DataSet detyrime;
		/// <summary>
		/// Fushe private qe tregon gjuhen ne te cilen do te printohen faturat
		/// </summary>
		private string gjuha = "";
		/// <summary>
		/// Fushe private qe mban vleren per propertine publike ReadyToPrint
		/// </summary>
		private bool readyToPrint = false;

		#endregion
		
		#region Constructors & Destructors
		public DorezoDhome1()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DorezoDhome1));
			this.tabControl1 = new VisionInfoSolutionLibrary.TabControl();
			this.tbKlient = new VisionInfoSolutionLibrary.TabPageControl();
			this.gbDhomaPaDorezuara1 = new VisionInfoSolutionLibrary.GroupBox();
			this.dgDhomaPaDorezuara = new VisionInfoSolutionLibrary.DataGrid();
			this.btnPrinto = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox3 = new VisionInfoSolutionLibrary.GroupBox();
			this.gridDetyrime = new VisionInfoSolutionLibrary.DataGrid();
			this.btnShfaqDetyrimeKlientet = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.gridPagesa = new VisionInfoSolutionLibrary.DataGrid();
			this.btnPagesaDhoma = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnDorezimKlienti = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbDorezim = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbPagesaKlienti = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox1 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox2 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox7 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox8 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.label29 = new VisionInfoSolutionLibrary.Label();
			this.label14 = new VisionInfoSolutionLibrary.Label();
			this.cmbKategoriteKlient = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.label12 = new VisionInfoSolutionLibrary.Label();
			this.numGjoba = new VisionInfoSolutionLibrary.NumericBox();
			this.lbKlientet = new VisionInfoSolutionLibrary.DoubleListBox();
			this.numSkonto = new VisionInfoSolutionLibrary.NumericBox();
			this.label8 = new VisionInfoSolutionLibrary.Label();
			this.cmbDhomat = new VisionInfoSolutionLibrary.DoubleCombo();
			this.dtpDorezim = new VisionInfoSolutionLibrary.DateTimePicker();
			this.lblDhoma = new VisionInfoSolutionLibrary.Label();
			this.lblMbiemri = new VisionInfoSolutionLibrary.Label();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.tbGrup = new VisionInfoSolutionLibrary.TabPageControl();
			this.gbDhomatPaDorezuara2 = new VisionInfoSolutionLibrary.GroupBox();
			this.dgDhomatPaDorezuaraGrup = new VisionInfoSolutionLibrary.DataGrid();
			this.btnPrintoGrup = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox5 = new VisionInfoSolutionLibrary.GroupBox();
			this.gridDetyrimiGrupi = new VisionInfoSolutionLibrary.DataGrid();
			this.groupBox4 = new VisionInfoSolutionLibrary.GroupBox();
			this.gridPagesaGrupi = new VisionInfoSolutionLibrary.DataGrid();
			this.btnLlogaritPagesen = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbPagesaGrupi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox3 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox4 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox5 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox6 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox9 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox10 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.label10 = new VisionInfoSolutionLibrary.Label();
			this.pbtnPrint = new VisionInfoSolutionLibrary.PrintButton(this.components);
			this.lbKlientetLargim = new VisionInfoSolutionLibrary.DoubleListBox();
			this.btnKaloDjathtas = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnKaloMajtas = new VisionInfoSolutionLibrary.Button(this.components);
			this.lbKlientetGrupi = new VisionInfoSolutionLibrary.DoubleListBox();
			this.label7 = new VisionInfoSolutionLibrary.Label();
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.txtAgjensia = new VisionInfoSolutionLibrary.TextBox();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.cmbGrupet = new VisionInfoSolutionLibrary.DoubleCombo();
			this.dtpMbarimiGrupi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.numSkontoGrupi = new VisionInfoSolutionLibrary.NumericBox();
			this.label9 = new VisionInfoSolutionLibrary.Label();
			this.label13 = new VisionInfoSolutionLibrary.Label();
			this.numGjobaGrupi = new VisionInfoSolutionLibrary.NumericBox();
			this.btnDorezoGrup = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnNdihme = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnDorezoKlient = new VisionInfoSolutionLibrary.Button(this.components);
			this.pagesa = new System.Data.DataSet();
			this.kliente = new System.Data.DataSet();
			this.info = new System.Data.DataSet();
			this.pagesa_grupi = new System.Data.DataSet();
			this.kliente_grupi = new System.Data.DataSet();
			this.info_grupi = new System.Data.DataSet();
			this.detyrime = new System.Data.DataSet();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.detyrimeGrupi = new System.Data.DataSet();
			this.tabControl1.SuspendLayout();
			this.tbKlient.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbDhomaPaDorezuara1)).BeginInit();
			this.gbDhomaPaDorezuara1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgDhomaPaDorezuara)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDetyrime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridPagesa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gbDorezim)).BeginInit();
			this.gbDorezim.SuspendLayout();
			this.cmbPagesaKlienti.SuspendLayout();
			this.tbGrup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbDhomatPaDorezuara2)).BeginInit();
			this.gbDhomatPaDorezuara2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgDhomatPaDorezuaraGrup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox5)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDetyrimiGrupi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridPagesaGrupi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.cmbPagesaGrupi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pagesa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kliente)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pagesa_grupi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kliente_grupi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.info_grupi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.detyrime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.detyrimeGrupi)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1010, 25);
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
			this.tabControl1.Size = new System.Drawing.Size(1010, 609);
			this.tabControl1.TabIndex = 7;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tbKlient
			// 
			this.tbKlient.BackColor = System.Drawing.SystemColors.Control;
			this.tbKlient.Controls.Add(this.gbDhomaPaDorezuara1);
			this.tbKlient.Controls.Add(this.btnPrinto);
			this.tbKlient.Controls.Add(this.groupBox3);
			this.tbKlient.Controls.Add(this.btnShfaqDetyrimeKlientet);
			this.tbKlient.Controls.Add(this.groupBox2);
			this.tbKlient.Controls.Add(this.btnDorezimKlienti);
			this.tbKlient.Controls.Add(this.gbDorezim);
			this.tbKlient.DefaultErrorMessage = null;
			this.tbKlient.EnableValidation = true;
			this.tbKlient.IsValid = false;
			this.tbKlient.Location = new System.Drawing.Point(4, 22);
			this.tbKlient.Name = "tbKlient";
			this.tbKlient.Size = new System.Drawing.Size(1002, 583);
			this.tbKlient.TabIndex = 0;
			this.tbKlient.Text = "Klient";
			// 
			// gbDhomaPaDorezuara1
			// 
			this.gbDhomaPaDorezuara1.BackColor = System.Drawing.Color.Transparent;
			this.gbDhomaPaDorezuara1.Controls.Add(this.dgDhomaPaDorezuara);
			this.gbDhomaPaDorezuara1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbDhomaPaDorezuara1.Location = new System.Drawing.Point(680, 8);
			this.gbDhomaPaDorezuara1.Name = "gbDhomaPaDorezuara1";
			this.gbDhomaPaDorezuara1.Size = new System.Drawing.Size(248, 288);
			this.gbDhomaPaDorezuara1.TabIndex = 36;
			this.gbDhomaPaDorezuara1.Text = "Dhomat e padorezuara brenda afatit";
			this.gbDhomaPaDorezuara1.Visible = false;
			this.gbDhomaPaDorezuara1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// dgDhomaPaDorezuara
			// 
			this.dgDhomaPaDorezuara.AllowSorting = false;
			this.dgDhomaPaDorezuara.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgDhomaPaDorezuara.CanDelete = true;
			this.dgDhomaPaDorezuara.CaptionVisible = false;
			this.dgDhomaPaDorezuara.DataMember = "";
			this.dgDhomaPaDorezuara.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.dgDhomaPaDorezuara.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgDhomaPaDorezuara.HideHorizontalScrollBar = false;
			this.dgDhomaPaDorezuara.HideVerticalScrollBar = false;
			this.dgDhomaPaDorezuara.Location = new System.Drawing.Point(12, 20);
			this.dgDhomaPaDorezuara.Name = "dgDhomaPaDorezuara";
			this.dgDhomaPaDorezuara.RowHeaderWidth = 20;
			this.dgDhomaPaDorezuara.Selekto = true;
			this.dgDhomaPaDorezuara.Size = new System.Drawing.Size(224, 256);
			this.dgDhomaPaDorezuara.TabIndex = 35;
			this.toolTips.SetToolTip(this.dgDhomaPaDorezuara, "Shfaq dhomat te cilat nuk jane dorezuar brenda afatit!");
			this.dgDhomaPaDorezuara.CurrentCellChanged += new System.EventHandler(this.dgDhomaPaDorezuara_CurrentCellChanged);
			// 
			// btnPrinto
			// 
			this.btnPrinto.BackColor = System.Drawing.Color.Blue;
			this.btnPrinto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrinto.DoValidation = true;
			this.btnPrinto.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnPrinto.Location = new System.Drawing.Point(524, 552);
			this.btnPrinto.Name = "btnPrinto";
			this.btnPrinto.Size = new System.Drawing.Size(90, 21);
			this.btnPrinto.TabIndex = 11;
			this.btnPrinto.Text = "Printo";
			this.toolTip1.SetToolTip(this.btnPrinto, "Shikoni dhe printoni faturen per dhomen e zgjedhur");
			this.btnPrinto.Visible = false;
			this.btnPrinto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnPrinto.Click += new System.EventHandler(this.btnPrinto_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.gridDetyrime);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(10, 332);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(658, 212);
			this.groupBox3.TabIndex = 33;
			this.groupBox3.Text = "Detyrimet ekstra per klientet";
			this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// gridDetyrime
			// 
			this.gridDetyrime.AllowSorting = false;
			this.gridDetyrime.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.gridDetyrime.CanDelete = true;
			this.gridDetyrime.CaptionVisible = false;
			this.gridDetyrime.DataMember = "";
			this.gridDetyrime.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gridDetyrime.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridDetyrime.HideHorizontalScrollBar = false;
			this.gridDetyrime.HideVerticalScrollBar = false;
			this.gridDetyrime.Location = new System.Drawing.Point(12, 20);
			this.gridDetyrime.Name = "gridDetyrime";
			this.gridDetyrime.RowHeaderWidth = 20;
			this.gridDetyrime.Selekto = true;
			this.gridDetyrime.Size = new System.Drawing.Size(632, 176);
			this.gridDetyrime.TabIndex = 32;
			this.toolTips.SetToolTip(this.gridDetyrime, "Detyrimet ekstra per klientet e dhomes!");
			// 
			// btnShfaqDetyrimeKlientet
			// 
			this.btnShfaqDetyrimeKlientet.BackColor = System.Drawing.Color.Blue;
			this.btnShfaqDetyrimeKlientet.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShfaqDetyrimeKlientet.DoValidation = true;
			this.btnShfaqDetyrimeKlientet.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShfaqDetyrimeKlientet.Location = new System.Drawing.Point(56, 304);
			this.btnShfaqDetyrimeKlientet.Name = "btnShfaqDetyrimeKlientet";
			this.btnShfaqDetyrimeKlientet.Size = new System.Drawing.Size(90, 21);
			this.btnShfaqDetyrimeKlientet.TabIndex = 9;
			this.btnShfaqDetyrimeKlientet.Text = "Shfaq detyrime";
			this.toolTips.SetToolTip(this.btnShfaqDetyrimeKlientet, "Shfaq detyrimet ekstra vetem per klientet e zgjedhur!");
			this.btnShfaqDetyrimeKlientet.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShfaqDetyrimeKlientet.Click += new System.EventHandler(this.btnShfaqDetyrimeKlientet_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.gridPagesa);
			this.groupBox2.Controls.Add(this.btnPagesaDhoma);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(376, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(292, 288);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.Text = "Pagesa per dhomen";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// gridPagesa
			// 
			this.gridPagesa.AllowSorting = false;
			this.gridPagesa.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.gridPagesa.CanDelete = true;
			this.gridPagesa.CaptionVisible = false;
			this.gridPagesa.DataMember = "";
			this.gridPagesa.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gridPagesa.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridPagesa.HideHorizontalScrollBar = false;
			this.gridPagesa.HideVerticalScrollBar = false;
			this.gridPagesa.Location = new System.Drawing.Point(12, 20);
			this.gridPagesa.Name = "gridPagesa";
			this.gridPagesa.RowHeaderWidth = 20;
			this.gridPagesa.Selekto = true;
			this.gridPagesa.Size = new System.Drawing.Size(265, 210);
			this.gridPagesa.TabIndex = 0;
			this.toolTips.SetToolTip(this.gridPagesa, "Paraqet te dhena te detajuara per peridhen e perdorimit te dhomes\r\ndhe per pagese" +
				"n qe duhet te kryhet!");
			// 
			// btnPagesaDhoma
			// 
			this.btnPagesaDhoma.BackColor = System.Drawing.Color.Blue;
			this.btnPagesaDhoma.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPagesaDhoma.DoValidation = true;
			this.btnPagesaDhoma.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnPagesaDhoma.Location = new System.Drawing.Point(100, 244);
			this.btnPagesaDhoma.Name = "btnPagesaDhoma";
			this.btnPagesaDhoma.Size = new System.Drawing.Size(96, 21);
			this.btnPagesaDhoma.TabIndex = 8;
			this.btnPagesaDhoma.Text = "Llogarit pagesen";
			this.toolTips.SetToolTip(this.btnPagesaDhoma, "Llogarit pagesen per dhomen gjate intervalit te qendrimit ne hotel!");
			this.btnPagesaDhoma.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnPagesaDhoma.Click += new System.EventHandler(this.btnPagesaDhoma_Click);
			// 
			// btnDorezimKlienti
			// 
			this.btnDorezimKlienti.BackColor = System.Drawing.SystemColors.Control;
			this.btnDorezimKlienti.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDorezimKlienti.DoValidation = true;
			this.btnDorezimKlienti.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDorezimKlienti.Location = new System.Drawing.Point(56, 552);
			this.btnDorezimKlienti.Name = "btnDorezimKlienti";
			this.btnDorezimKlienti.Size = new System.Drawing.Size(90, 21);
			this.btnDorezimKlienti.TabIndex = 10;
			this.btnDorezimKlienti.Text = "Dorezo";
			this.toolTips.SetToolTip(this.btnDorezimKlienti, "Kryen dorezimin e dhomes dhe hedh ne arke\r\n pagesen e dhomes dhe detyrimet ekstra" +
				" per klientet!");
			this.btnDorezimKlienti.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnDorezimKlienti.Click += new System.EventHandler(this.btnDorezim_Klienti_Click);
			// 
			// gbDorezim
			// 
			this.gbDorezim.BackColor = System.Drawing.Color.Transparent;
			this.gbDorezim.Controls.Add(this.cmbPagesaKlienti);
			this.gbDorezim.Controls.Add(this.label29);
			this.gbDorezim.Controls.Add(this.label14);
			this.gbDorezim.Controls.Add(this.cmbKategoriteKlient);
			this.gbDorezim.Controls.Add(this.label3);
			this.gbDorezim.Controls.Add(this.label12);
			this.gbDorezim.Controls.Add(this.numGjoba);
			this.gbDorezim.Controls.Add(this.lbKlientet);
			this.gbDorezim.Controls.Add(this.numSkonto);
			this.gbDorezim.Controls.Add(this.label8);
			this.gbDorezim.Controls.Add(this.cmbDhomat);
			this.gbDorezim.Controls.Add(this.dtpDorezim);
			this.gbDorezim.Controls.Add(this.lblDhoma);
			this.gbDorezim.Controls.Add(this.lblMbiemri);
			this.gbDorezim.Controls.Add(this.label1);
			this.gbDorezim.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbDorezim.Location = new System.Drawing.Point(10, 8);
			this.gbDorezim.Name = "gbDorezim";
			this.gbDorezim.Size = new System.Drawing.Size(354, 288);
			this.gbDorezim.TabIndex = 8;
			this.gbDorezim.Text = "Te dhenat per klientin";
			this.gbDorezim.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbPagesaKlienti
			// 
			this.cmbPagesaKlienti.BackColor = System.Drawing.Color.Transparent;
			this.cmbPagesaKlienti.Controls.Add(this.comboBox1);
			this.cmbPagesaKlienti.Controls.Add(this.comboBox2);
			this.cmbPagesaKlienti.Controls.Add(this.comboBox7);
			this.cmbPagesaKlienti.Controls.Add(this.comboBox8);
			this.cmbPagesaKlienti.DefaultErrorMessage = null;
			this.cmbPagesaKlienti.IsValid = false;
			this.cmbPagesaKlienti.Kolone1Vlere = null;
			this.cmbPagesaKlienti.Kolone2Vlere = null;
			this.cmbPagesaKlienti.Location = new System.Drawing.Point(160, 256);
			this.cmbPagesaKlienti.Name = "cmbPagesaKlienti";
			this.cmbPagesaKlienti.ReadOnly = true;
			this.cmbPagesaKlienti.Required = true;
			this.cmbPagesaKlienti.Size = new System.Drawing.Size(180, 21);
			this.cmbPagesaKlienti.SkipValidation = false;
			this.cmbPagesaKlienti.TabIndex = 7;
			// 
			// comboBox1
			// 
			this.comboBox1.DefaultErrorMessage = null;
			this.comboBox1.IsValid = false;
			this.comboBox1.Location = new System.Drawing.Point(136, 0);
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
			this.comboBox2.Size = new System.Drawing.Size(180, 21);
			this.comboBox2.TabIndex = 0;
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
			this.label29.Location = new System.Drawing.Point(92, 260);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(60, 20);
			this.label29.TabIndex = 97;
			this.label29.Text = "Pagesa ne";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label14.Location = new System.Drawing.Point(52, 228);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 20);
			this.label14.TabIndex = 31;
			this.label14.Text = "Gjoba";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbKategoriteKlient
			// 
			this.cmbKategoriteKlient.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategoriteKlient.DefaultErrorMessage = "Zgjidhni nje prej kategorive!";
			this.cmbKategoriteKlient.IsValid = false;
			this.cmbKategoriteKlient.Kolone1Vlere = null;
			this.cmbKategoriteKlient.Kolone2Vlere = null;
			this.cmbKategoriteKlient.Location = new System.Drawing.Point(160, 44);
			this.cmbKategoriteKlient.Name = "cmbKategoriteKlient";
			this.cmbKategoriteKlient.ReadOnly = false;
			this.cmbKategoriteKlient.Required = true;
			this.cmbKategoriteKlient.Size = new System.Drawing.Size(180, 21);
			this.cmbKategoriteKlient.SkipValidation = false;
			this.cmbKategoriteKlient.TabIndex = 2;
			this.cmbKategoriteKlient.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategoriteKlient_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(20, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 20);
			this.label3.TabIndex = 28;
			this.label3.Text = "Kategoria";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label12.Location = new System.Drawing.Point(64, 228);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(0, 24);
			this.label12.TabIndex = 25;
			this.label12.Text = "Gjoba";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numGjoba
			// 
			this.numGjoba.AutoSize = false;
			this.numGjoba.DefaultErrorMessage = "Vendosni nje vlere per gjoben!";
			this.numGjoba.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numGjoba.DigitsAfterDecimalPoint = 0;
			this.numGjoba.FixedLength = false;
			this.numGjoba.IsValid = false;
			this.numGjoba.KeepFocus = false;
			this.numGjoba.Location = new System.Drawing.Point(160, 228);
			this.numGjoba.Name = "numGjoba";
			this.numGjoba.OnlyPositive = true;
			this.numGjoba.Required = true;
			this.numGjoba.RequiredControlColor = System.Drawing.Color.White;
			this.numGjoba.Size = new System.Drawing.Size(180, 21);
			this.numGjoba.TabIndex = 6;
			this.numGjoba.Text = "";
			this.numGjoba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTips.SetToolTip(this.numGjoba, "Vendosni 0 ne rast se nuk doni te aplikoni gjobe!");
			this.numGjoba.Leave += new System.EventHandler(this.numGjoba_Leave);
			// 
			// lbKlientet
			// 
			this.lbKlientet.BackColor = System.Drawing.Color.Transparent;
			this.lbKlientet.DefaultErrorMessage = "Dhoma qe keni zgjedhur nuk ka asnje klient!";
			this.lbKlientet.IsValid = true;
			this.lbKlientet.Kolone1Vlere = "";
			this.lbKlientet.Kolone2Vlere = "";
			this.lbKlientet.Location = new System.Drawing.Point(160, 108);
			this.lbKlientet.Name = "lbKlientet";
			this.lbKlientet.Required = true;
			this.lbKlientet.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbKlientet.Size = new System.Drawing.Size(180, 88);
			this.lbKlientet.SkipValidation = false;
			this.lbKlientet.TabIndex = 4;
			// 
			// numSkonto
			// 
			this.numSkonto.AutoSize = false;
			this.numSkonto.DefaultErrorMessage = "Vendosni nje vlere per skonton!";
			this.numSkonto.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numSkonto.DigitsAfterDecimalPoint = 0;
			this.numSkonto.FixedLength = false;
			this.numSkonto.IsValid = false;
			this.numSkonto.KeepFocus = false;
			this.numSkonto.Location = new System.Drawing.Point(160, 200);
			this.numSkonto.Name = "numSkonto";
			this.numSkonto.OnlyPositive = true;
			this.numSkonto.Required = true;
			this.numSkonto.RequiredControlColor = System.Drawing.Color.White;
			this.numSkonto.Size = new System.Drawing.Size(180, 21);
			this.numSkonto.TabIndex = 5;
			this.numSkonto.Text = "";
			this.numSkonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTips.SetToolTip(this.numSkonto, "Vendosni 0 ne rast se nuk doni te aplikoni skonto ");
			this.numSkonto.Leave += new System.EventHandler(this.numSkonto_Leave);
			// 
			// label8
			// 
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label8.Location = new System.Drawing.Point(48, 200);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 20);
			this.label8.TabIndex = 21;
			this.label8.Text = "Skonto per dhomen";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbDhomat
			// 
			this.cmbDhomat.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhomat.DefaultErrorMessage = "Zgjidhni nje prej dhomave per dorezim!";
			this.cmbDhomat.IsValid = false;
			this.cmbDhomat.Kolone1Vlere = null;
			this.cmbDhomat.Kolone2Vlere = null;
			this.cmbDhomat.Location = new System.Drawing.Point(160, 76);
			this.cmbDhomat.Name = "cmbDhomat";
			this.cmbDhomat.ReadOnly = false;
			this.cmbDhomat.Required = true;
			this.cmbDhomat.Size = new System.Drawing.Size(180, 21);
			this.cmbDhomat.SkipValidation = false;
			this.cmbDhomat.TabIndex = 3;
			this.cmbDhomat.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbDhomat_SelectedIndexChanged);
			// 
			// dtpDorezim
			// 
			this.dtpDorezim.BackColor = System.Drawing.Color.White;
			this.dtpDorezim.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpDorezim.DefaultErrorMessage = "";
			this.dtpDorezim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDorezim.IsValid = true;
			this.dtpDorezim.Location = new System.Drawing.Point(160, 16);
			this.dtpDorezim.Name = "dtpDorezim";
			this.dtpDorezim.Required = false;
			this.dtpDorezim.ShowUpDown = true;
			this.dtpDorezim.Size = new System.Drawing.Size(180, 20);
			this.dtpDorezim.TabIndex = 1;
			this.dtpDorezim.Value = new System.DateTime(2005, 9, 2, 10, 5, 0, 0);
			this.dtpDorezim.ValueChanged += new System.EventHandler(this.dtpDorezim_ValueChanged);
			// 
			// lblDhoma
			// 
			this.lblDhoma.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblDhoma.Location = new System.Drawing.Point(0, 80);
			this.lblDhoma.Name = "lblDhoma";
			this.lblDhoma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblDhoma.Size = new System.Drawing.Size(152, 20);
			this.lblDhoma.TabIndex = 5;
			this.lblDhoma.Text = "Dhomat e zena per kategorine";
			// 
			// lblMbiemri
			// 
			this.lblMbiemri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblMbiemri.Location = new System.Drawing.Point(40, 108);
			this.lblMbiemri.Name = "lblMbiemri";
			this.lblMbiemri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblMbiemri.Size = new System.Drawing.Size(112, 20);
			this.lblMbiemri.TabIndex = 1;
			this.lblMbiemri.Text = "Klientet ne dhome ";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 20);
			this.label1.TabIndex = 35;
			this.label1.Text = "Data e dorezimit";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbGrup
			// 
			this.tbGrup.BackColor = System.Drawing.SystemColors.Control;
			this.tbGrup.Controls.Add(this.gbDhomatPaDorezuara2);
			this.tbGrup.Controls.Add(this.btnPrintoGrup);
			this.tbGrup.Controls.Add(this.groupBox5);
			this.tbGrup.Controls.Add(this.groupBox4);
			this.tbGrup.Controls.Add(this.groupBox1);
			this.tbGrup.Controls.Add(this.btnDorezoGrup);
			this.tbGrup.DefaultErrorMessage = null;
			this.tbGrup.EnableValidation = true;
			this.tbGrup.IsValid = false;
			this.tbGrup.Location = new System.Drawing.Point(4, 22);
			this.tbGrup.Name = "tbGrup";
			this.tbGrup.Size = new System.Drawing.Size(1002, 583);
			this.tbGrup.TabIndex = 1;
			this.tbGrup.Text = "Grup";
			// 
			// gbDhomatPaDorezuara2
			// 
			this.gbDhomatPaDorezuara2.BackColor = System.Drawing.Color.Transparent;
			this.gbDhomatPaDorezuara2.Controls.Add(this.dgDhomatPaDorezuaraGrup);
			this.gbDhomatPaDorezuara2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbDhomatPaDorezuara2.Location = new System.Drawing.Point(632, 296);
			this.gbDhomatPaDorezuara2.Name = "gbDhomatPaDorezuara2";
			this.gbDhomatPaDorezuara2.Size = new System.Drawing.Size(256, 244);
			this.gbDhomatPaDorezuara2.TabIndex = 44;
			this.gbDhomatPaDorezuara2.Text = "Dhomat e padorezuara brenda afatit";
			this.gbDhomatPaDorezuara2.Visible = false;
			this.gbDhomatPaDorezuara2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// dgDhomatPaDorezuaraGrup
			// 
			this.dgDhomatPaDorezuaraGrup.AllowSorting = false;
			this.dgDhomatPaDorezuaraGrup.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgDhomatPaDorezuaraGrup.CanDelete = true;
			this.dgDhomatPaDorezuaraGrup.CaptionVisible = false;
			this.dgDhomatPaDorezuaraGrup.DataMember = "";
			this.dgDhomatPaDorezuaraGrup.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.dgDhomatPaDorezuaraGrup.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgDhomatPaDorezuaraGrup.HideHorizontalScrollBar = false;
			this.dgDhomatPaDorezuaraGrup.HideVerticalScrollBar = false;
			this.dgDhomatPaDorezuaraGrup.Location = new System.Drawing.Point(12, 20);
			this.dgDhomatPaDorezuaraGrup.Name = "dgDhomatPaDorezuaraGrup";
			this.dgDhomatPaDorezuaraGrup.RowHeaderWidth = 20;
			this.dgDhomatPaDorezuaraGrup.Selekto = true;
			this.dgDhomatPaDorezuaraGrup.Size = new System.Drawing.Size(220, 208);
			this.dgDhomatPaDorezuaraGrup.TabIndex = 35;
			this.toolTips.SetToolTip(this.dgDhomatPaDorezuaraGrup, "Dhomat e padorezuara brenda afatit nga grupet!");
			this.dgDhomatPaDorezuaraGrup.CurrentCellChanged += new System.EventHandler(this.dgDhomatPaDorezuaraGrup_CurrentCellChanged);
			// 
			// btnPrintoGrup
			// 
			this.btnPrintoGrup.BackColor = System.Drawing.Color.Blue;
			this.btnPrintoGrup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrintoGrup.DoValidation = true;
			this.btnPrintoGrup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnPrintoGrup.Location = new System.Drawing.Point(484, 548);
			this.btnPrintoGrup.Name = "btnPrintoGrup";
			this.btnPrintoGrup.Size = new System.Drawing.Size(90, 21);
			this.btnPrintoGrup.TabIndex = 26;
			this.btnPrintoGrup.Text = "Printo";
			this.toolTip1.SetToolTip(this.btnPrintoGrup, "Shikoni dhe printoni faturen per klientin e zgjedhur");
			this.btnPrintoGrup.Visible = false;
			this.btnPrintoGrup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnPrintoGrup.Click += new System.EventHandler(this.btnPrintoGrup_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.Transparent;
			this.groupBox5.Controls.Add(this.gridDetyrimiGrupi);
			this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox5.Location = new System.Drawing.Point(10, 296);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(610, 244);
			this.groupBox5.TabIndex = 42;
			this.groupBox5.Text = "Detyrimet ekstra per dhomat e grupit";
			this.groupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// gridDetyrimiGrupi
			// 
			this.gridDetyrimiGrupi.AllowSorting = false;
			this.gridDetyrimiGrupi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.gridDetyrimiGrupi.CanDelete = true;
			this.gridDetyrimiGrupi.CaptionVisible = false;
			this.gridDetyrimiGrupi.DataMember = "";
			this.gridDetyrimiGrupi.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gridDetyrimiGrupi.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridDetyrimiGrupi.HideHorizontalScrollBar = false;
			this.gridDetyrimiGrupi.HideVerticalScrollBar = false;
			this.gridDetyrimiGrupi.Location = new System.Drawing.Point(12, 20);
			this.gridDetyrimiGrupi.Name = "gridDetyrimiGrupi";
			this.gridDetyrimiGrupi.RowHeaderWidth = 20;
			this.gridDetyrimiGrupi.Selekto = true;
			this.gridDetyrimiGrupi.Size = new System.Drawing.Size(576, 208);
			this.gridDetyrimiGrupi.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.gridPagesaGrupi);
			this.groupBox4.Controls.Add(this.btnLlogaritPagesen);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(632, 8);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(256, 284);
			this.groupBox4.TabIndex = 40;
			this.groupBox4.Text = "Pagesa per dhomat";
			this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// gridPagesaGrupi
			// 
			this.gridPagesaGrupi.AllowSorting = false;
			this.gridPagesaGrupi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.gridPagesaGrupi.CanDelete = true;
			this.gridPagesaGrupi.CaptionVisible = false;
			this.gridPagesaGrupi.DataMember = "";
			this.gridPagesaGrupi.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gridPagesaGrupi.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridPagesaGrupi.HideHorizontalScrollBar = false;
			this.gridPagesaGrupi.HideVerticalScrollBar = false;
			this.gridPagesaGrupi.Location = new System.Drawing.Point(12, 20);
			this.gridPagesaGrupi.Name = "gridPagesaGrupi";
			this.gridPagesaGrupi.ReadOnly = true;
			this.gridPagesaGrupi.RowHeaderWidth = 20;
			this.gridPagesaGrupi.Selekto = true;
			this.gridPagesaGrupi.Size = new System.Drawing.Size(217, 224);
			this.gridPagesaGrupi.TabIndex = 0;
			this.toolTips.SetToolTip(this.gridPagesaGrupi, "Te dhena te detajuara per dhomat qe do te dorezohen\r\n si edhe par pagesen qe duhe" +
				"t te kryhet nga ana e grupit!");
			// 
			// btnLlogaritPagesen
			// 
			this.btnLlogaritPagesen.BackColor = System.Drawing.Color.Blue;
			this.btnLlogaritPagesen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLlogaritPagesen.DoValidation = true;
			this.btnLlogaritPagesen.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnLlogaritPagesen.Location = new System.Drawing.Point(80, 252);
			this.btnLlogaritPagesen.Name = "btnLlogaritPagesen";
			this.btnLlogaritPagesen.Size = new System.Drawing.Size(100, 21);
			this.btnLlogaritPagesen.TabIndex = 24;
			this.btnLlogaritPagesen.Text = "Llogarit pagesen";
			this.toolTips.SetToolTip(this.btnLlogaritPagesen, "Llogarit pagesen per dhomat gjate intervalit te qendrimit ne hotel!");
			this.btnLlogaritPagesen.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnLlogaritPagesen.Click += new System.EventHandler(this.btnLlogaritPagesen_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.cmbPagesaGrupi);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.pbtnPrint);
			this.groupBox1.Controls.Add(this.lbKlientetLargim);
			this.groupBox1.Controls.Add(this.btnKaloDjathtas);
			this.groupBox1.Controls.Add(this.btnKaloMajtas);
			this.groupBox1.Controls.Add(this.lbKlientetGrupi);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtAgjensia);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cmbGrupet);
			this.groupBox1.Controls.Add(this.dtpMbarimiGrupi);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.numSkontoGrupi);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.numGjobaGrupi);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(10, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(612, 284);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.Text = "Zgjidh klientet qe do te largohen";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbPagesaGrupi
			// 
			this.cmbPagesaGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cmbPagesaGrupi.Controls.Add(this.comboBox3);
			this.cmbPagesaGrupi.Controls.Add(this.comboBox4);
			this.cmbPagesaGrupi.Controls.Add(this.comboBox5);
			this.cmbPagesaGrupi.Controls.Add(this.comboBox6);
			this.cmbPagesaGrupi.Controls.Add(this.comboBox9);
			this.cmbPagesaGrupi.Controls.Add(this.comboBox10);
			this.cmbPagesaGrupi.DefaultErrorMessage = null;
			this.cmbPagesaGrupi.IsValid = false;
			this.cmbPagesaGrupi.Kolone1Vlere = null;
			this.cmbPagesaGrupi.Kolone2Vlere = null;
			this.cmbPagesaGrupi.Location = new System.Drawing.Point(108, 252);
			this.cmbPagesaGrupi.Name = "cmbPagesaGrupi";
			this.cmbPagesaGrupi.ReadOnly = false;
			this.cmbPagesaGrupi.Required = true;
			this.cmbPagesaGrupi.Size = new System.Drawing.Size(160, 21);
			this.cmbPagesaGrupi.SkipValidation = false;
			this.cmbPagesaGrupi.TabIndex = 22;
			// 
			// comboBox3
			// 
			this.comboBox3.DefaultErrorMessage = null;
			this.comboBox3.IsValid = false;
			this.comboBox3.Location = new System.Drawing.Point(84, 0);
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
			this.comboBox4.Size = new System.Drawing.Size(184, 21);
			this.comboBox4.TabIndex = 0;
			// 
			// comboBox5
			// 
			this.comboBox5.DefaultErrorMessage = null;
			this.comboBox5.IsValid = false;
			this.comboBox5.Location = new System.Drawing.Point(136, 0);
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
			this.comboBox6.Size = new System.Drawing.Size(180, 21);
			this.comboBox6.TabIndex = 0;
			// 
			// comboBox9
			// 
			this.comboBox9.DefaultErrorMessage = null;
			this.comboBox9.IsValid = false;
			this.comboBox9.Location = new System.Drawing.Point(60, 0);
			this.comboBox9.Name = "comboBox9";
			this.comboBox9.Required = false;
			this.comboBox9.Size = new System.Drawing.Size(16, 21);
			this.comboBox9.TabIndex = 1;
			this.comboBox9.Visible = false;
			// 
			// comboBox10
			// 
			this.comboBox10.DefaultErrorMessage = null;
			this.comboBox10.IsValid = false;
			this.comboBox10.Location = new System.Drawing.Point(0, 0);
			this.comboBox10.Name = "comboBox10";
			this.comboBox10.Required = false;
			this.comboBox10.Size = new System.Drawing.Size(180, 21);
			this.comboBox10.TabIndex = 0;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(40, 256);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 20);
			this.label10.TabIndex = 99;
			this.label10.Text = "Pagesa ne";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pbtnPrint
			// 
			this.pbtnPrint.BackColor = System.Drawing.Color.Blue;
			this.pbtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbtnPrint.DoValidation = true;
			this.pbtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.pbtnPrint.Icon = ((System.Drawing.Icon)(resources.GetObject("pbtnPrint.Icon")));
			this.pbtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("pbtnPrint.Image")));
			this.pbtnPrint.Location = new System.Drawing.Point(492, 196);
			this.pbtnPrint.Name = "pbtnPrint";
			this.pbtnPrint.Size = new System.Drawing.Size(40, 21);
			this.pbtnPrint.TabIndex = 23;
			this.toolTip1.SetToolTip(this.pbtnPrint, "Shikoni dhe printoni faturen per dhomen e zgjedhur!");
			this.pbtnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.pbtnPrint.Click += new System.EventHandler(this.pbtnPrint_Click);
			// 
			// lbKlientetLargim
			// 
			this.lbKlientetLargim.BackColor = System.Drawing.Color.Transparent;
			this.lbKlientetLargim.DefaultErrorMessage = "Ju duhet te zgjidhni te pakten nje prej dhomave  per dorezim!";
			this.lbKlientetLargim.IsValid = false;
			this.lbKlientetLargim.Kolone1Vlere = "";
			this.lbKlientetLargim.Kolone2Vlere = "";
			this.lbKlientetLargim.Location = new System.Drawing.Point(428, 100);
			this.lbKlientetLargim.Name = "lbKlientetLargim";
			this.lbKlientetLargim.Required = true;
			this.lbKlientetLargim.SelectionMode = System.Windows.Forms.SelectionMode.One;
			this.lbKlientetLargim.Size = new System.Drawing.Size(160, 88);
			this.lbKlientetLargim.SkipValidation = false;
			this.lbKlientetLargim.TabIndex = 33;
			// 
			// btnKaloDjathtas
			// 
			this.btnKaloDjathtas.BackColor = System.Drawing.Color.Blue;
			this.btnKaloDjathtas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKaloDjathtas.DoValidation = false;
			this.btnKaloDjathtas.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKaloDjathtas.Location = new System.Drawing.Point(304, 152);
			this.btnKaloDjathtas.Name = "btnKaloDjathtas";
			this.btnKaloDjathtas.Size = new System.Drawing.Size(90, 21);
			this.btnKaloDjathtas.TabIndex = 19;
			this.btnKaloDjathtas.Text = "<< Kalo ";
			this.toolTips.SetToolTip(this.btnKaloDjathtas, "Anullon zgjedhjen e dhomes!");
			this.btnKaloDjathtas.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKaloDjathtas.Click += new System.EventHandler(this.btnKaloDjathtas_Click);
			// 
			// btnKaloMajtas
			// 
			this.btnKaloMajtas.BackColor = System.Drawing.Color.Blue;
			this.btnKaloMajtas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKaloMajtas.DoValidation = false;
			this.btnKaloMajtas.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKaloMajtas.Location = new System.Drawing.Point(304, 124);
			this.btnKaloMajtas.Name = "btnKaloMajtas";
			this.btnKaloMajtas.Size = new System.Drawing.Size(90, 21);
			this.btnKaloMajtas.TabIndex = 18;
			this.btnKaloMajtas.Text = "Kalo >>";
			this.toolTips.SetToolTip(this.btnKaloMajtas, "Zgjedh nje dhome per dorezim!");
			this.btnKaloMajtas.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKaloMajtas.Click += new System.EventHandler(this.btnKaloMajtas_Click);
			// 
			// lbKlientetGrupi
			// 
			this.lbKlientetGrupi.BackColor = System.Drawing.Color.Transparent;
			this.lbKlientetGrupi.DefaultErrorMessage = "Grupi qe keni zgjedhur nuk ka asnje home ne perdorim per daten e zgjedhur!";
			this.lbKlientetGrupi.IsValid = true;
			this.lbKlientetGrupi.Kolone1Vlere = "";
			this.lbKlientetGrupi.Kolone2Vlere = "";
			this.lbKlientetGrupi.Location = new System.Drawing.Point(108, 104);
			this.lbKlientetGrupi.Name = "lbKlientetGrupi";
			this.lbKlientetGrupi.Required = false;
			this.lbKlientetGrupi.SelectionMode = System.Windows.Forms.SelectionMode.One;
			this.lbKlientetGrupi.Size = new System.Drawing.Size(160, 88);
			this.lbKlientetGrupi.SkipValidation = true;
			this.lbKlientetGrupi.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label7.Location = new System.Drawing.Point(272, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(148, 20);
			this.label7.TabIndex = 23;
			this.label7.Text = "Dhomat qe do te dorezohen";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Location = new System.Drawing.Point(0, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 20);
			this.label6.TabIndex = 20;
			this.label6.Text = "Dhomat per grupin";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAgjensia
			// 
			this.txtAgjensia.AutoSize = false;
			this.txtAgjensia.DefaultErrorMessage = "";
			this.txtAgjensia.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAgjensia.FixedLength = false;
			this.txtAgjensia.IsValid = true;
			this.txtAgjensia.Location = new System.Drawing.Point(108, 76);
			this.txtAgjensia.Name = "txtAgjensia";
			this.txtAgjensia.Required = false;
			this.txtAgjensia.RequiredControlColor = System.Drawing.Color.White;
			this.txtAgjensia.Size = new System.Drawing.Size(160, 21);
			this.txtAgjensia.TabIndex = 16;
			this.txtAgjensia.Text = "";
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(52, 76);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 20);
			this.label5.TabIndex = 17;
			this.label5.Text = "Agjensia";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Location = new System.Drawing.Point(56, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 20);
			this.label4.TabIndex = 16;
			this.label4.Text = "Grupi";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbGrupet
			// 
			this.cmbGrupet.BackColor = System.Drawing.Color.Transparent;
			this.cmbGrupet.DefaultErrorMessage = "";
			this.cmbGrupet.IsValid = false;
			this.cmbGrupet.Kolone1Vlere = null;
			this.cmbGrupet.Kolone2Vlere = null;
			this.cmbGrupet.Location = new System.Drawing.Point(108, 48);
			this.cmbGrupet.Name = "cmbGrupet";
			this.cmbGrupet.ReadOnly = false;
			this.cmbGrupet.Required = true;
			this.cmbGrupet.Size = new System.Drawing.Size(160, 21);
			this.cmbGrupet.SkipValidation = false;
			this.cmbGrupet.TabIndex = 15;
			this.cmbGrupet.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbGrupet_SelectedIndexChanged);
			// 
			// dtpMbarimiGrupi
			// 
			this.dtpMbarimiGrupi.BackColor = System.Drawing.Color.White;
			this.dtpMbarimiGrupi.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpMbarimiGrupi.DefaultErrorMessage = "";
			this.dtpMbarimiGrupi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimiGrupi.IsValid = true;
			this.dtpMbarimiGrupi.Location = new System.Drawing.Point(108, 20);
			this.dtpMbarimiGrupi.Name = "dtpMbarimiGrupi";
			this.dtpMbarimiGrupi.Required = false;
			this.dtpMbarimiGrupi.ShowCheckBox = true;
			this.dtpMbarimiGrupi.ShowUpDown = true;
			this.dtpMbarimiGrupi.Size = new System.Drawing.Size(160, 20);
			this.dtpMbarimiGrupi.TabIndex = 14;
			this.dtpMbarimiGrupi.Value = new System.DateTime(2005, 9, 2, 10, 5, 0, 0);
			this.dtpMbarimiGrupi.ValueChanged += new System.EventHandler(this.dtpMbarimiGrupi_ValueChanged);
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(4, 20);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(96, 20);
			this.label2.TabIndex = 13;
			this.label2.Text = "Data e dorezimit";
			// 
			// numSkontoGrupi
			// 
			this.numSkontoGrupi.AutoSize = false;
			this.numSkontoGrupi.DefaultErrorMessage = "Vendosni nje vlere per skonton e grupit!";
			this.numSkontoGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numSkontoGrupi.DigitsAfterDecimalPoint = 0;
			this.numSkontoGrupi.FixedLength = false;
			this.numSkontoGrupi.IsValid = false;
			this.numSkontoGrupi.KeepFocus = false;
			this.numSkontoGrupi.Location = new System.Drawing.Point(108, 196);
			this.numSkontoGrupi.Name = "numSkontoGrupi";
			this.numSkontoGrupi.OnlyPositive = true;
			this.numSkontoGrupi.ReadOnly = true;
			this.numSkontoGrupi.Required = true;
			this.numSkontoGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.numSkontoGrupi.Size = new System.Drawing.Size(160, 21);
			this.numSkontoGrupi.TabIndex = 20;
			this.numSkontoGrupi.Text = "";
			this.numSkontoGrupi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSkontoGrupi.Leave += new System.EventHandler(this.numSkontoGrupi_Leave);
			// 
			// label9
			// 
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label9.Location = new System.Drawing.Point(8, 196);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(92, 20);
			this.label9.TabIndex = 26;
			this.label9.Text = "Skonto per grupin";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label13.Location = new System.Drawing.Point(60, 224);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(40, 20);
			this.label13.TabIndex = 39;
			this.label13.Text = "Gjoba";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numGjobaGrupi
			// 
			this.numGjobaGrupi.AutoSize = false;
			this.numGjobaGrupi.DefaultErrorMessage = "Vendosni nje vlere per gjoben e grupit!";
			this.numGjobaGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numGjobaGrupi.DigitsAfterDecimalPoint = 0;
			this.numGjobaGrupi.FixedLength = false;
			this.numGjobaGrupi.IsValid = false;
			this.numGjobaGrupi.KeepFocus = false;
			this.numGjobaGrupi.Location = new System.Drawing.Point(108, 224);
			this.numGjobaGrupi.Name = "numGjobaGrupi";
			this.numGjobaGrupi.OnlyPositive = true;
			this.numGjobaGrupi.ReadOnly = true;
			this.numGjobaGrupi.Required = true;
			this.numGjobaGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.numGjobaGrupi.Size = new System.Drawing.Size(160, 21);
			this.numGjobaGrupi.TabIndex = 21;
			this.numGjobaGrupi.Text = "";
			this.numGjobaGrupi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numGjobaGrupi.Leave += new System.EventHandler(this.numGjobaGrupi_Leave);
			// 
			// btnDorezoGrup
			// 
			this.btnDorezoGrup.BackColor = System.Drawing.Color.Blue;
			this.btnDorezoGrup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDorezoGrup.DoValidation = true;
			this.btnDorezoGrup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDorezoGrup.Location = new System.Drawing.Point(64, 548);
			this.btnDorezoGrup.Name = "btnDorezoGrup";
			this.btnDorezoGrup.Size = new System.Drawing.Size(90, 21);
			this.btnDorezoGrup.TabIndex = 25;
			this.btnDorezoGrup.Text = "Dorezo";
			this.toolTips.SetToolTip(this.btnDorezoGrup, "Dorezon dhomat e zgjedhura, hedh pagesen per dhomat ne arke\r\n si edhe detyrimet e" +
				"kstra per klientet!");
			this.btnDorezoGrup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnDorezoGrup.Click += new System.EventHandler(this.btnDorezoGrup_Click);
			// 
			// btnNdihme
			// 
			this.btnNdihme.BackColor = System.Drawing.Color.Blue;
			this.btnNdihme.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNdihme.DoValidation = true;
			this.btnNdihme.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnNdihme.Location = new System.Drawing.Point(524, 512);
			this.btnNdihme.Name = "btnNdihme";
			this.btnNdihme.Size = new System.Drawing.Size(90, 21);
			this.btnNdihme.TabIndex = 10;
			this.btnNdihme.Text = "Ndihme";
			this.btnNdihme.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// btnDorezoKlient
			// 
			this.btnDorezoKlient.BackColor = System.Drawing.Color.Blue;
			this.btnDorezoKlient.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDorezoKlient.DoValidation = true;
			this.btnDorezoKlient.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDorezoKlient.Location = new System.Drawing.Point(48, 512);
			this.btnDorezoKlient.Name = "btnDorezoKlient";
			this.btnDorezoKlient.Size = new System.Drawing.Size(90, 21);
			this.btnDorezoKlient.TabIndex = 11;
			this.btnDorezoKlient.Text = "Dorezo";
			this.btnDorezoKlient.Visible = false;
			this.btnDorezoKlient.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// pagesa
			// 
			this.pagesa.DataSetName = "NewDataSet";
			this.pagesa.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// kliente
			// 
			this.kliente.DataSetName = "NewDataSet";
			this.kliente.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// info
			// 
			this.info.DataSetName = "NewDataSet";
			this.info.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// pagesa_grupi
			// 
			this.pagesa_grupi.DataSetName = "NewDataSet";
			this.pagesa_grupi.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// kliente_grupi
			// 
			this.kliente_grupi.DataSetName = "NewDataSet";
			this.kliente_grupi.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// info_grupi
			// 
			this.info_grupi.DataSetName = "NewDataSet";
			this.info_grupi.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// detyrime
			// 
			this.detyrime.DataSetName = "NewDataSet1";
			this.detyrime.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// detyrimeGrupi
			// 
			this.detyrimeGrupi.DataSetName = "NewDataSet";
			this.detyrimeGrupi.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// DorezoDhome1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(968, 461);
			this.Controls.Add(this.tabControl1);
			this.EnableValidation = true;
			this.HelpFile = "DOREZO DHOME.htm";
			this.Name = "DorezoDhome1";
			this.RequiredControlsBackColor = System.Drawing.Color.LemonChiffon;
			this.Text = "Dorezo Dhome";
			this.TitullGjeresi = 1010;
			this.Load += new System.EventHandler(this.DorezoDhome_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.tabControl1, 0);
			this.tabControl1.ResumeLayout(false);
			this.tbKlient.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbDhomaPaDorezuara1)).EndInit();
			this.gbDhomaPaDorezuara1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgDhomaPaDorezuara)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDetyrime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridPagesa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gbDorezim)).EndInit();
			this.gbDorezim.ResumeLayout(false);
			this.cmbPagesaKlienti.ResumeLayout(false);
			this.tbGrup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbDhomatPaDorezuara2)).EndInit();
			this.gbDhomatPaDorezuara2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgDhomatPaDorezuaraGrup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox5)).EndInit();
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDetyrimiGrupi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridPagesaGrupi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.cmbPagesaGrupi.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pagesa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kliente)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pagesa_grupi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kliente_grupi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.info_grupi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.detyrime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.detyrimeGrupi)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		
		#region Private Methods
		private void mbushKategorite()
		{
			this.cmbKategoriteKlient.Kolone1.Items.Clear();
			this.cmbKategoriteKlient.Kolone2.Items.Clear();
			DataSet ds = null ;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqKategorite");
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbKategoriteKlient.Kolone1.Items.Add(dr[1]);
				this.cmbKategoriteKlient.Kolone2.Items.Add(dr[0]);
			}

		}
		private void mbushGrupet()
		{
			DataSet ds = null ;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqGrupet");
			
			this.cmbGrupet.Kolone1.Items.Clear();
			this.cmbGrupet.Kolone2.Items.Clear();
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbGrupet.Kolone1.Items.Add(dr[1]);
				this.cmbGrupet.Kolone2.Items.Add(dr[0]);
			}
			
		}

		private void mbushKlientet(DataSet ds)
		{
			this.lbKlientet.Kolone1.Items.Clear();
			this.lbKlientet.Kolone2.Items.Clear();
			foreach(DataRow dr in ds.Tables[0].Rows)
			{ 
				this.lbKlientet.Kolone1.Items.Add( dr[1]);
				this.lbKlientet.Kolone2.Items.Add(dr[0]);
			}
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

		private DataSet gjejDhomat(DataSet ds)
		{
			this.lbKlientetGrupi.Kolone1.Items.Clear();
			this.lbKlientetGrupi.Kolone2.Items.Clear();
			DataSet ds_dhoma = new DataSet();
			ds_dhoma.Tables.Add();
			ds_dhoma.Tables[0].Columns.Add("ID", typeof(Int32));
			ds_dhoma.Tables[0].Columns.Add("DHOMA", typeof(String));
			ds_dhoma.Tables[0].Columns.Add("DOREZUAR", typeof(String));
			ds_dhoma.AcceptChanges();
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
					new_row["DHOMA"] = Convert.ToString(dr["DHOMA"]);
					if (Convert.ToString(dr["KLIENT_HOTELI"]) == "False")
						new_row["DOREZUAR"] = "True";
					else
						new_row["DOREZUAR"] = "False";
					ds_dhoma.Tables[0].Rows.Add(new_row);
					ds_dhoma.AcceptChanges();
				}
			}
			return ds_dhoma;
		}
									
		private void KrijoStilDetyrime()
		{
			gridDetyrime.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.Bisque;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			gridDetyrime.ReadOnly = true;

			DataGridTextBoxColumn emri = new DataGridTextBoxColumn();
			emri.HeaderText = "Emri";
			emri.MappingName = "EMRI";
			emri.Width = 120;
			emri.NullText = "";

			DataGridTextBoxColumn emerLloji = new DataGridTextBoxColumn();
			emerLloji.HeaderText = "Lloji i detyrimit";
			emerLloji.MappingName = "EMER_LLOJI";
			emerLloji.Width = 156;
			emerLloji.NullText = "";
		
			DataGridTextBoxColumn cmimi = new DataGridTextBoxColumn();
			cmimi.HeaderText = "Cmimi";
			cmimi.MappingName = "CMIMI";
			cmimi.Width = 60;
			cmimi.NullText = "";
	
			DataGridTextBoxColumn sasia = new DataGridTextBoxColumn();
			sasia.HeaderText = "Sasia";
			sasia.MappingName = "SASIA";
			sasia.Width = 40;
			sasia.NullText = "";
			
			DataGridTextBoxColumn colData = new DataGridTextBoxColumn();
			colData.HeaderText = "Data";
			colData.MappingName = "DATA_STR";
			colData.Width = 145;
			colData.NullText = "";

			DataGridTextBoxColumn colDataHyrje = new DataGridTextBoxColumn();
			colDataHyrje.HeaderText = "Date hyrje";
			colDataHyrje.MappingName = "DATA_HYRJE_STR";
			colDataHyrje.Width = 150;
			colDataHyrje.NullText = "";

			DataGridTextBoxColumn colDataDalje = new DataGridTextBoxColumn();
			colDataDalje.HeaderText = "Date dalje";
			colDataDalje.MappingName = "DATA_DALJE_STR";
			colDataDalje.Width = 150;
			colDataDalje.NullText = "";

			DataGridTextBoxColumn vlera = new DataGridTextBoxColumn();
			vlera.HeaderText = "Vlera";
			vlera.MappingName = "VLERA";
			vlera.Width = 70;
			vlera.NullText = "";
			
			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{emri,colDataHyrje, colDataDalje, emerLloji, colData, cmimi, sasia, vlera});
			gridDetyrime.TableStyles.Add(style);
			gridDetyrime.FlatMode = false;
			gridDetyrime.Expand(-1);
		}

		private void KrijoStilGrideGrupiEkstra()
		{
			this.gridDetyrimiGrupi.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.Bisque;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			gridDetyrimiGrupi.ReadOnly = true;
			
			DataGridTextBoxColumn colID = new DataGridTextBoxColumn();
			colID.HeaderText = "Id";
			colID.MappingName = "ID_KLIENTI";
			colID.Width = 0;
			colID.NullText = "";

			DataGridTextBoxColumn colDhoma = new DataGridTextBoxColumn();
			colDhoma.HeaderText = "Dhoma";
			colDhoma.MappingName = "DHOMA_EMRI";
			colDhoma.Width = 80;
			colDhoma.NullText = "";
			
			DataGridTextBoxColumn emri = new DataGridTextBoxColumn();
			emri.HeaderText = "Emri";
			emri.MappingName = "EMRI";
			emri.Width = 120;
			emri.NullText = "";

			DataGridTextBoxColumn emerLloji = new DataGridTextBoxColumn();
			emerLloji.HeaderText = "Lloji i detyrimit";
			emerLloji.MappingName = "EMER_LLOJI";
			emerLloji.Width = 156;
			emerLloji.NullText = "";
		
			DataGridTextBoxColumn cmimi = new DataGridTextBoxColumn();
			cmimi.HeaderText = "Cmimi";
			cmimi.MappingName = "CMIMI";
			cmimi.Width = 60;
			cmimi.NullText = "";
	
			DataGridTextBoxColumn sasia = new DataGridTextBoxColumn();
			sasia.HeaderText = "Sasia";
			sasia.MappingName = "SASIA";
			sasia.Width = 40;
			sasia.NullText = "";
			
			DataGridTextBoxColumn colData = new DataGridTextBoxColumn();
			colData.HeaderText = "Data";
			colData.MappingName = "DATA_STR";
			colData.Width = 145;
			colData.NullText = "";

			DataGridTextBoxColumn colDataHyrje = new DataGridTextBoxColumn();
			colDataHyrje.HeaderText = "Date hyrje";
			colDataHyrje.MappingName = "DATA_HYRJE_STR";
			colDataHyrje.Width = 150;
			colDataHyrje.NullText = "";

			DataGridTextBoxColumn colDataDalje = new DataGridTextBoxColumn();
			colDataDalje.HeaderText = "Date dalje";
			colDataDalje.MappingName = "DATA_DALJE_STR";
			colDataDalje.Width = 150;
			colDataDalje.NullText = "";

			DataGridTextBoxColumn vlera = new DataGridTextBoxColumn();
			vlera.HeaderText = "Vlera";
			vlera.MappingName = "VLERA";
			vlera.Width = 70;
			vlera.NullText = "";

			DataGridTextBoxColumn colIdRezervimi = new DataGridTextBoxColumn();
			colIdRezervimi.HeaderText = "ID Rezervimi";
			colIdRezervimi.MappingName = "ID_REZERVIMI";
			colIdRezervimi.Width = 0;
			colIdRezervimi.NullText = "";
			
			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{colID, colDhoma, emri,colDataHyrje,
			colDataDalje, emerLloji, colData, cmimi, sasia, vlera,colIdRezervimi});
			gridDetyrimiGrupi.TableStyles.Add(style);
			gridDetyrimiGrupi.FlatMode = false;
			gridDetyrimiGrupi.Expand(-1);
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
		private void krijostil_pagesa(VisionInfoSolutionLibrary.DataGrid g)
		{
			g.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.Bisque;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			style.AllowSorting = false;
			g.ReadOnly = true;
			
			DataGridTextBoxColumn colKriteri = new DataGridTextBoxColumn();
			colKriteri.HeaderText = "";
			colKriteri.MappingName = "KRITERI";
			colKriteri.Width = 110;
			colKriteri.HeaderText = "";

			DataGridTextBoxColumn colPershkrimi = new DataGridTextBoxColumn();
			colPershkrimi.MappingName = "PERSHKRIMI";
			colPershkrimi.Width = 150;
			colPershkrimi.HeaderText = "";
			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{colKriteri, colPershkrimi});
			g.TableStyles.Add(style);
			g.FlatMode = false;
			g.Expand(-1);

		}

		private void krijostil_pagesa_grupi()
		{
			this.gridPagesaGrupi.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.Bisque;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			style.AllowSorting = false;
			gridPagesaGrupi.ReadOnly = true;

			DataGridTextBoxColumn colDhoma = new DataGridTextBoxColumn();
			colDhoma.HeaderText = "Dhoma";
			colDhoma.MappingName = "DHOMA";
			colDhoma.Width = 80;

			DataGridTextBoxColumn colVlera = new DataGridTextBoxColumn();
			colVlera.HeaderText = "Detyrimi per dhomen";
			colVlera.MappingName = "VLERA";
			colVlera.Width = 132;
			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{colDhoma, colVlera});

			gridPagesaGrupi.TableStyles.Add(style);
			gridPagesaGrupi.FlatMode = false;
			gridPagesaGrupi.Expand(-1);
		}
		private int pagesa_int_per_dhomen(DataTable dt, int idDhoma)
		{
			DateTime mindata = Convert.ToDateTime(dt.Rows[0][3]);
			DateTime maxdata = Convert.ToDateTime(dt.Rows[0][4]);
			foreach(DataRow dr in dt.Rows)
			{
				if (Convert.ToDateTime(dr[4]) > maxdata)
					maxdata = Convert.ToDateTime(dr[4]);
			}
			TimeSpan ts = maxdata.Subtract(mindata);
			int nr_ditesh = Convert.ToInt32(ts.Days);
			int id_kategoria = Convert.ToInt32(dt.Rows[0][6]);
			double nr_oresh_double,ore;
			if (id_kategoria == 31)
			{
				nr_ditesh = Convert.ToInt32(ts.TotalMinutes);
				nr_oresh_double = nr_ditesh;
				ore = Math.Round(nr_oresh_double/60, 1);
			}
			else
			{	
				ore = nr_ditesh;
			}
			InputController data = new InputController();
			DataSet ds_cmimi = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma , mindata);
			int cmimi = Convert.ToInt32(ds_cmimi.Tables[0].Rows[0][0]);
			int pagesa = Convert.ToInt32(ore * cmimi);
			return pagesa;
		}
		
		/// <summary>
		/// merr si parameter datatable per dhomen dhe kthen vetem pagesen 
		/// qe duhet te behet per dhomen
		/// </summary>
		/// <param name="dt"></param>
		/// <param name="idDhoma"></param>
		/// <returns></returns>
		private DataSet pagesa_dataset_per_dhomen(DataTable dt, int idDhoma)
		{
			DataSet tmp = new DataSet();
			tmp.Tables.Add();
			
			tmp.Tables[0].Columns.Add("DATA_FILLIMI", typeof(String));
			tmp.Tables[0].Columns.Add("DATA_MBARIMI", typeof(String));
			tmp.Tables[0].Columns.Add("INTERVALI", typeof(String));
			tmp.Tables[0].Columns.Add("CMIMI", typeof(Int32));
			tmp.Tables[0].Columns.Add("VLERA", typeof(Int32));
			DataRow r = tmp.Tables[0].NewRow();
			DateTime mindata = Convert.ToDateTime(dt.Rows[0][3]);
			DateTime maxdata = Convert.ToDateTime(dt.Rows[0][4]);
			foreach(DataRow dr in dt.Rows)
			{
				if (Convert.ToDateTime(dr[4]) > maxdata)
					maxdata = Convert.ToDateTime(dr[4]);
			}
			r["DATA_FILLIMI"] = this.konverto(mindata);
			r["DATA_MBARIMI"] = this.konverto(maxdata);
			TimeSpan ts = maxdata.Subtract(mindata);
			int nr_ditesh = Convert.ToInt32(ts.Days);
			int id_kategoria = Convert.ToInt32(dt.Rows[0][6]);
			double nr_oresh_double,ore;
			string dite;
			if (id_kategoria == 31)
			{
				nr_ditesh = Convert.ToInt32(ts.TotalMinutes);
				nr_oresh_double = nr_ditesh;
				ore = Math.Round(nr_oresh_double/60, 1);
				dite = ore + " ore";
			}
			else
			{	
				ore = nr_ditesh;
				dite = ore + " dite";
			}
			r["INTERVALI"] = dite;
			InputController data = new InputController();
			DataSet ds_cmimi = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma , mindata);
			int cmimi = Convert.ToInt32(ds_cmimi.Tables[0].Rows[0][0]);
			r["CMIMI"] = cmimi;
			int pagesa = Convert.ToInt32(ore * cmimi);
			r["VLERA"] = pagesa.ToString();
			tmp.Tables[0].Rows.Add(r);
			tmp.AcceptChanges();
			return tmp;
		}

		/// <summary>
		/// mbush griden e detyrimeve per dhomat e  grupit qe do te dorezohen
		/// </summary>
		private void shfaq_detyrime_grupi()
		{
			this.gridDetyrimiGrupi.DataSource = null;
			this.total_detyrime_grupi = 0;
			DataSet tmp_kliente = new DataSet();
			tmp_kliente.Tables.Add();
			tmp_kliente.Tables[0].Columns.Add("ID_KLIENTI", typeof(Int32));
			tmp_kliente.AcceptChanges();
			DataRow r;
			//hidhen gjithe klientet e vlefshem te grupit ne nje vektor
			for(int i = 0;i < this.lbKlientetLargim.Kolone2.Items.Count; i++)
			{
				int id_dhoma = Convert.ToInt32(this.lbKlientetLargim.Kolone2.Items[i]);
				foreach(DataRow dr in this.kliente_grupi.Tables[0].Rows)
				{
					if ( (Convert.ToInt32(dr["ID_DHOMA"]) == id_dhoma) && (dr["KLIENT_HOTELI"].ToString()== "True"))
					{
						r = tmp_kliente.Tables[0].NewRow();
						r["ID_KLIENTI"] = Convert.ToInt32(dr["ID"]);
						tmp_kliente.Tables[0].Rows.Add(r);
					}									  
				}
			}
			tmp_kliente.AcceptChanges();

			this.id_kliente_grupi = new int[tmp_kliente.Tables[0].Rows.Count];
			int j = 0;
			foreach(DataRow dr in tmp_kliente.Tables[0].Rows)
			{
				this.id_kliente_grupi[j] = Convert.ToInt32(dr["ID_KLIENTI"]);
				j++;
			}
			tmp_kliente.Dispose();
			InputController data = new InputController();
			detyrimeGrupi = data.KerkesaRead("ShfaqDetyrimePerKlientetEkstra", id_kliente_grupi);
			DataRow shuma_row = detyrimeGrupi.Tables[0].NewRow();
			int shuma = 0;
			foreach(DataRow dr in detyrimeGrupi.Tables[0].Rows)
			{
				shuma = shuma + Convert.ToInt32(dr[6]);
			}
			shuma_row["DHOMA_EMRI"] = "SHUMA";
			shuma_row["VLERA"] = shuma;
			this.total_detyrime_grupi = shuma;
			detyrimeGrupi.Tables[0].Rows.Add(shuma_row);
			detyrimeGrupi.AcceptChanges();
			if (detyrimeGrupi.Tables[0].Rows.Count != 1)
			{
				this.gridDetyrimiGrupi.DataSource = detyrimeGrupi.Tables[0];
				this.KrijoStilGrideGrupiEkstra();
			}
			else
			{
				this.gridDetyrimiGrupi.DataSource = null;
			}
		}

		private int refresh_pagesa_grupi(int id_dhoma)
		{
			DateTime date_dorezimi = Convert.ToDateTime(this.dtpMbarimiGrupi.Value);
			int shuma = 0;
			InputController data = new InputController();
			foreach(DataRow dr in pagesa_grupi.Tables[0].Rows)
			{
				if (Convert.ToInt32(dr["ID"]) == id_dhoma)
				{
					if (date_dorezimi < Convert.ToDateTime(dr["MAXDATA"]))
					{
						string s = "Data e mbarimit per dhomen eshte " + this.konverto(Convert.ToDateTime(dr["MAXDATA"])) + ".";
						s += Environment.NewLine  + "Deshironi te kryeni dorezimin e dhomes para afatit te caktuar?";
						DataSet dsKat = data.KerkesaRead("NxirrDhome", id_dhoma);
						int idKategoria = Convert.ToInt32(dsKat.Tables[0].Rows[0]["ID_KATEGORIA"]);
						if (idKategoria == 31)
						{
							DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome", s, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							if (result != DialogResult.Yes)
								return -1;
						}
						else if (date_dorezimi.Date < Convert.ToDateTime(dr["MAXDATA"]).Date)
						{
							DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome", s, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							if (result != DialogResult.Yes)
								return -1;
						}
					}
					else if (date_dorezimi > Convert.ToDateTime(dr["MAXDATA"]))
					{
						DialogResult result = System.Windows.Forms.MessageBox.Show(this, "Data e mbarimit per kete dhome eshte " + this.konverto(Convert.ToDateTime(dr["MAXDATA"])) + Environment.NewLine+ "Ju nuk mund te kryeni dorezimin pas kesaj date." , "Dorezo dhome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return -1;
					}
					dr["DATE_DOREZIMI"] = date_dorezimi;
					int id_kategoria = Convert.ToInt32(data.KerkesaRead("NxirrDhome", id_dhoma).Tables[0].Rows[0]["ID_KATEGORIA"]);
					int nr_ditesh;
					double nr_oresh_double, ore;
					string dite;
					DateTime mindata = Convert.ToDateTime(dr["MINDATA"]);
					TimeSpan ts; 
					if (id_kategoria == 31)
					{
						ts = date_dorezimi.Subtract(mindata);
						nr_ditesh = Convert.ToInt32(ts.TotalMinutes);
						nr_oresh_double = nr_ditesh;
						ore = Math.Round(nr_oresh_double/60, 1);
						dite = ore + " ore";
					}
					else
					{	
						ts = date_dorezimi.Date.Subtract(mindata.Date);
						nr_ditesh = Convert.ToInt32(ts.Days);
						ore = nr_ditesh;
						dite = ore + " dite";
					}
					dr["INTERVALI"] = dite;
					int cmimi = Convert.ToInt32(dr["CMIMI"]);
					int vlera_vjeter = Convert.ToInt32(dr["VLERA"]);
					int vlera_re = Convert.ToInt32(ore * cmimi);
					dr["VLERA"] = vlera_re;
					shuma = Convert.ToInt32(pagesa_grupi.Tables[0].Rows[pagesa_grupi.Tables[0].Rows.Count - 1]["VLERA"]);
					shuma = shuma - vlera_vjeter + vlera_re;
					break;
				}
			}
			pagesa_grupi.Tables[0].Rows[pagesa_grupi.Tables[0].Rows.Count - 1]["VLERA"] = shuma;
			return 0;
		}

		private void unrefresh_pagesa_grupi(int id_dhoma)
		{
			int shuma = 0;
			InputController data = new InputController();
			foreach(DataRow dr in pagesa_grupi.Tables[0].Rows)
			{
				if (Convert.ToInt32(dr["ID"]) == id_dhoma)
				{
					dr["DATE_DOREZIMI"] = Convert.ToDateTime(dr["MAXDATA"]);
					int id_kategoria = Convert.ToInt32(data.KerkesaRead("NxirrDhome", id_dhoma).Tables[0].Rows[0][5]);
					int nr_ditesh;
					double nr_oresh_double, ore;
					string dite;
					DateTime mindata = Convert.ToDateTime(dr["MINDATA"]);
					DateTime maxdata = Convert.ToDateTime(dr["MAXDATA"]);
					TimeSpan ts;
					if (id_kategoria == 31)
					{
						ts = maxdata.Subtract(mindata);
						nr_ditesh = Convert.ToInt32(ts.TotalMinutes);
						nr_oresh_double = nr_ditesh;
						ore = Math.Round(nr_oresh_double/60, 1);
						dite = ore + " ore";
					}
					else
					{	
						ts = maxdata.Date.Subtract(mindata.Date);
						nr_ditesh = Convert.ToInt32(ts.Days);
						ore = nr_ditesh;
						dite = ore + " dite";
					}
					dr["INTERVALI"] = dite;
					int cmimi = Convert.ToInt32(dr["CMIMI"]);
					int vlera_vjeter = Convert.ToInt32(dr["VLERA"]);
					int vlera_re = Convert.ToInt32(ore * cmimi);
					dr["VLERA"] = vlera_re;
					shuma = Convert.ToInt32(pagesa_grupi.Tables[0].Rows[pagesa_grupi.Tables[0].Rows.Count - 1]["VLERA"]);
					shuma = shuma - vlera_vjeter + vlera_re;
					break;
				}
			}
			pagesa_grupi.Tables[0].Rows[pagesa_grupi.Tables[0].Rows.Count - 1]["VLERA"] = shuma;
		}
		private DataSet gjej_klientet_dataset(string str_id, string str_emra, string str_bool)
		{
			DataSet ds = new DataSet();
			ds.Tables.Add();
			ds.Tables[0].Columns.Add("ID", typeof(Int32));
			ds.Tables[0].Columns.Add("KLIENTI", typeof(String));
			ds.Tables[0].Columns.Add("KLIENT_HOTELI", typeof(String));
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

			count = 0;
			l = str_bool.Length;
			string x = "";
			i = 0;
			while (i < l)
			{
				string c = str_bool.Substring(i, 1);
				if (i == l - 1)
				{
					x = x + c;
					ds.Tables[0].Rows[count][2] = x;
					x = "";
					count++;
					i++;
				}
				else
				{
					string next = str_bool.Substring(i, 2);
					if ((next == Environment.NewLine)||( i == l - 1))
					{
						ds.Tables[0].Rows[count][2] = x;
						x = "";
						count++;
						i = i + 2;
					}
					else
					{
						x = x + c;
						i++;
					}
				}
			}
			ds.AcceptChanges();
			DataSet ds1 = new DataSet();
			ds1.Tables.Add();
			ds1.Tables[0].Columns.Add("ID", typeof(Int32));
			ds1.Tables[0].Columns.Add("KLIENTI", typeof(String));
			ds1.Tables[0].Columns.Add("KLIENT_HOTELI", typeof(String));
			ds1.AcceptChanges();
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				if (dr["KLIENT_HOTELI"].ToString() == "True")
				{
					DataRow r = ds1.Tables[0].NewRow();
					r["ID"] = dr["ID"];
					r["KLIENTI"] = dr["KLIENTI"];
					r["KLIENT_HOTELI"] = dr["KLIENT_HOTELI"];
					ds1.Tables[0].Rows.Add(r);
				}
			}
			ds1.AcceptChanges();
			return ds1;
		}

		private DataSet gjej_klientet_dataset(string str_id, string str_emra,string str_id_dhoma, string str_dhoma, string str_bool)
		{
			DataSet ds = new DataSet();
			ds.Tables.Add();
			ds.Tables[0].Columns.Add("ID", typeof(Int32));
			ds.Tables[0].Columns.Add("KLIENTI", typeof(String));
			ds.Tables[0].Columns.Add("ID_DHOMA", typeof(Int32));
			ds.Tables[0].Columns.Add("DHOMA", typeof(String));
			ds.Tables[0].Columns.Add("KLIENT_HOTELI", typeof(String));
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

			count = 0;
			l = str_id_dhoma.Length;
			string id_dhoma = "";
			i = 0;
			while (i < l)
			{
				string c = str_id_dhoma.Substring(i, 1);
				if (i == l - 1)
				{
					id_dhoma = id_dhoma + c;
					ds.Tables[0].Rows[count][2] = id_dhoma;
					id_dhoma = "";
					count++;
					i++;
				}
				else
				{
					string next = str_id_dhoma.Substring(i, 2);
					if ((next == Environment.NewLine)||( i == l - 1))
					{
						ds.Tables[0].Rows[count][2] = id_dhoma;
						id_dhoma = "";
						count++;
						i = i + 2;
					}
					else
					{
						id_dhoma = id_dhoma + c;
						i++;
					}
				}
			}

			count = 0;
			l = str_dhoma.Length;
			string dhoma = "";
			i = 0;
			while (i < l)
			{
				string c = str_dhoma.Substring(i, 1);
				if (i == l - 1)
				{
					dhoma = dhoma + c;
					ds.Tables[0].Rows[count][3] = dhoma;
					dhoma = "";
					count++;
					i++;
				}
				else
				{
					string next = str_dhoma.Substring(i, 2);
					if ((next == Environment.NewLine)||( i == l - 1))
					{
						ds.Tables[0].Rows[count][3] = dhoma;
						dhoma = "";
						count++;
						i = i + 2;
					}
					else
					{
						dhoma = dhoma + c;
						i++;
					}
				}
			}

			count = 0;
			l = str_bool.Length;
			string x = "";
			i = 0;
			while (i < l)
			{
				string c = str_bool.Substring(i, 1);
				if (i == l - 1)
				{
					x = x + c;
					ds.Tables[0].Rows[count][4] = x;
					x = "";
					count++;
					i++;
				}
				else
				{
					string next = str_bool.Substring(i, 2);
					if ((next == Environment.NewLine)||( i == l - 1))
					{
						ds.Tables[0].Rows[count][4] = x;
						x = "";
						count++;
						i = i + 2;
					}
					else
					{
						x = x + c;
						i++;
					}
				}
			}

			ds.AcceptChanges();
			return ds;
		}

		private bool dorezuar_grupi(string str_bool)
		{
			int l = str_bool.Length;
			string x = "";
			int i = 0;
			while (i < l)
			{
				
				string c = str_bool.Substring(i, 1);
				if (i == l - 1)
				{
					x = x + c;
					if (x == "False")
						return true;
					x = "";
					i++;
				}
				else
				{
					string next = str_bool.Substring(i, 2);
					if (next == Environment.NewLine)
					{
						if (x == "False")
							return true;
						x = "";
						i = i + 2;
					}
					else
					{
						x = x + c;
						i++;
					}
				}
			}
			return false;
		}

		/// <summary>
		/// Hedh ne griden dgDhomaPaDorezuara te gjitha dhomat te cilave iu ka mbaruar afati i dorezimit
		/// por nuk jane dorezuar ende
		/// </summary>
		private void KontrolloDhomatDorezim()
		{
			InputController data = new InputController();
			DataSet dsDhomaPDKliente = data.KerkesaRead("KontrolloDhomatPaDorezuaraKliente");
			if (dsDhomaPDKliente.Tables[0].Rows.Count > 0)
			{
				this.gbDhomaPaDorezuara1.Visible = true;
				this.dgDhomaPaDorezuara.DataSource = dsDhomaPDKliente.Tables[0];
				this.KrijoStilGride3();
				if (dsDhomaPDKliente.Tables[0].Rows.Count <= 13)
				{
					dgDhomaPaDorezuara.Width = 224;
					this.gbDhomaPaDorezuara1.Width = 248;
				}
				else
				{
					dgDhomaPaDorezuara.Width = 240;
					this.gbDhomaPaDorezuara1.Width = 264;
				}
			}
			else
			{
				this.dgDhomaPaDorezuara.DataSource = null;
				this.gbDhomaPaDorezuara1.Visible = false;
			}
		}

		/// <summary>
		/// Hedh ne griden dgDhomaPaDorezuaraGrup te gjitha dhomat te cilave iu ka mbaruar afati i dorezimit
		/// por nuk jane dorezuar ende, per klientet e grupeve
		/// </summary>
		private void KontrolloDhomatDorezim2()
		{
			InputController data = new InputController();
			DataSet dsDhomaPDGrup = data.KerkesaRead("KontrolloDhomatPaDorezuaraGrupe");
			if (dsDhomaPDGrup.Tables[0].Rows.Count > 0)
			{
				this.gbDhomatPaDorezuara2.Visible = true;
				this.dgDhomatPaDorezuaraGrup.DataSource = dsDhomaPDGrup.Tables[0];
				this.KrijoStilGride4();
			}
			else
			{
				this.gbDhomatPaDorezuara2.Visible = false;
				this.dgDhomatPaDorezuaraGrup.DataSource = null;
			}
			if (dsDhomaPDGrup.Tables[0].Rows.Count <= 10)
			{
				dgDhomatPaDorezuaraGrup.Width = 220;
				//gbDhomatPaDorezuara2.Width = 244;
			}
			else
			{
				dgDhomatPaDorezuaraGrup.Width = 237;
				//gbDhomatPaDorezuara2.Width = 260;
				//groupBox4.Width = 260;
			}
		}

		/// <summary>
		/// Krijon stilin per griden qe shfaq dhomat per klientet te cilat nuk 
		/// jane dorezuar por afati i dorezimit u ka mbaruar
		/// </summary>
		private void KrijoStilGride3()
		{
			dgDhomaPaDorezuara.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.Bisque;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			dgDhomaPaDorezuara.ReadOnly = true;

			DataGridTextBoxColumn dhoma = new DataGridTextBoxColumn();
			dhoma.HeaderText = "Dhoma";
			dhoma.MappingName = "DHOMA_EMRI";
			dhoma.Width = 86;
			dhoma.NullText = "";
			
			DataGridTextBoxColumn emri = new DataGridTextBoxColumn();
			emri.HeaderText = "Klienti";
			emri.MappingName = "EMRI";
			emri.Width = 134;
			emri.NullText = "";

			DataGridTextBoxColumn idKategoria = new DataGridTextBoxColumn();
			idKategoria.HeaderText = "idKategoria";
			idKategoria.MappingName = "ID_KATEGORIA";
			idKategoria.Width = 0;

			DataGridTextBoxColumn katEmri = new DataGridTextBoxColumn();
			katEmri.HeaderText = "katEmri";
			katEmri.MappingName = "KAT_EMRI";
			katEmri.Width = 0;

			DataGridTextBoxColumn idDhoma = new DataGridTextBoxColumn();
			idDhoma.HeaderText = "idDhoma";
			idDhoma.MappingName = "ID_DHOMA";
			idDhoma.Width = 0;

			DataGridTextBoxColumn dtDorezimi = new DataGridTextBoxColumn();
			dtDorezimi.HeaderText = "dtDorezimi";
			dtDorezimi.MappingName = "DATA_DALJE";
			dtDorezimi.Width = 0;

			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{dhoma, emri, idKategoria, katEmri, 
																		 idDhoma, dtDorezimi});
			dgDhomaPaDorezuara.TableStyles.Add(style);
			dgDhomaPaDorezuara.FlatMode = false;
			dgDhomaPaDorezuara.Expand(-1);
		}

		/// <summary>
		/// Krijon stilin per griden qe shfaq dhomat per grupet te cilat nuk 
		/// jane dorezuar por afati i dorezimit u ka mbaruar
		/// </summary>
		private void KrijoStilGride4()
		{
			this.dgDhomatPaDorezuaraGrup.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.Bisque;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			dgDhomatPaDorezuaraGrup.ReadOnly = true;

			DataGridTextBoxColumn dhoma = new DataGridTextBoxColumn();
			dhoma.HeaderText = "Dhoma";
			dhoma.MappingName = "DHOMA_EMRI";
			dhoma.Width = 80;
			dhoma.NullText = "";
			
			DataGridTextBoxColumn emri = new DataGridTextBoxColumn();
			emri.HeaderText = "Klienti";
			emri.MappingName = "EMRI";
			emri.Width = 136;
			emri.NullText = "";

			DataGridTextBoxColumn grupi = new DataGridTextBoxColumn();
			grupi.HeaderText = "Grupi";
			grupi.MappingName = "GRUPI_EMRI";
			grupi.Width = 0;

			DataGridTextBoxColumn katEmri = new DataGridTextBoxColumn();
			katEmri.HeaderText = "katEmri";
			katEmri.MappingName = "KAT_EMRI";
			katEmri.Width = 0;

			DataGridTextBoxColumn idDhoma = new DataGridTextBoxColumn();
			idDhoma.HeaderText = "idDhoma";
			idDhoma.MappingName = "ID_DHOMA";
			idDhoma.Width = 0;

			DataGridTextBoxColumn idGrupi = new DataGridTextBoxColumn();
			idGrupi.HeaderText = "idGrupi";
			idGrupi.MappingName = "ID_GRUPI";
			idGrupi.Width = 0;

			DataGridTextBoxColumn dtDorezimi = new DataGridTextBoxColumn();
			dtDorezimi.HeaderText = "dtDorezimi";
			dtDorezimi.MappingName = "DATA_DALJE";
			dtDorezimi.Width = 0;

			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{dhoma, emri, grupi, katEmri, 
																		 idDhoma, idGrupi, dtDorezimi});
			dgDhomatPaDorezuaraGrup.TableStyles.Add(style);
			dgDhomatPaDorezuaraGrup.FlatMode = false;
			dgDhomatPaDorezuaraGrup.Expand(-1);
		}

		/// <summary>
		/// Ben formatimin e dataseteve qe sherbejne per printimin e fatures dhe i hedh ne nje dataset te ri me
		/// dy tabela. Kete dataset me pas e ruan ne nje skedar XML.
		/// </summary>
		private void FormatDataSets()
		{
			try
			{
				// Ne fillim te dhenat e hotelit i hedhim ne nje dataset
				DataSet ds = new DataSet();
				string informacionet = Application.StartupPath + "\\Informacione.xml";
				if (File.Exists(informacionet))
					ds.ReadXml(Application.StartupPath + "\\Informacione.xml");
				// Krijojme nje dataset te ri
				DataSet dsFaturaKlienti = new DataSet();
				dsFaturaKlienti.EnforceConstraints = false;
				// Shtojme nje tabele General ne dataset e cila do te mbaje te dhenat e pergjithshme
				// qe ka fatura. Shtojme dhe kolonat per keto te dhena
				dsFaturaKlienti.Tables.Add("General");
				dsFaturaKlienti.Tables["General"].Columns.Add("Hotel", typeof(String));
				dsFaturaKlienti.Tables["General"].Columns.Add("Adrese", typeof(String));
				dsFaturaKlienti.Tables["General"].Columns.Add("Nr.Tel", typeof(String));
				dsFaturaKlienti.Tables["General"].Columns.Add("Website", typeof(String));
				dsFaturaKlienti.Tables["General"].Columns.Add("Email", typeof(String));
				dsFaturaKlienti.Tables["General"].Columns.Add("KodFiskal", typeof(String));
				dsFaturaKlienti.Tables["General"].Columns.Add("Dhoma", typeof(String));
				dsFaturaKlienti.Tables["General"].Columns.Add("DtMarrje", typeof(String));
				dsFaturaKlienti.Tables["General"].Columns.Add("DtDorezim", typeof(String));
				dsFaturaKlienti.Tables["General"].Columns.Add("Interval", typeof(String));
				dsFaturaKlienti.Tables["General"].Columns.Add("Cmim", typeof(Int32));
				dsFaturaKlienti.Tables["General"].Columns.Add("Skonto", typeof(Int32));
				dsFaturaKlienti.Tables["General"].Columns.Add("Gjobe", typeof(Int32));
				dsFaturaKlienti.Tables["General"].Columns.Add("Kapar", typeof(Int32));
				dsFaturaKlienti.Tables["General"].Columns.Add("Total", typeof(Int32));
				dsFaturaKlienti.Tables["General"].Columns.Add("MesazhQendrimi", typeof(String));
				dsFaturaKlienti.Tables["General"].Columns.Add("ShumaTotale", typeof(Int32));

				// Krijojme nje rresht te ri ne tabele dhe e mbushim me te dhenat e duhura
				DataRow drGeneral = dsFaturaKlienti.Tables["General"].NewRow();
				drGeneral[0] = ds.Tables[0].Rows[0][0];
				drGeneral[1] = ds.Tables[0].Rows[0][1];
				drGeneral[2] = ds.Tables[0].Rows[0][2];
				drGeneral[4] = ds.Tables[0].Rows[0][3];
				drGeneral[3] = ds.Tables[0].Rows[0][4];
				drGeneral[5] = ds.Tables[0].Rows[0][5];
				drGeneral["MesazhQendrimi"] = ds.Tables[0].Rows[0][7];
				drGeneral["Dhoma"] = pagesa.Tables[0].Rows[0][1];
				drGeneral["DtMarrje"] = pagesa.Tables[0].Rows[1][1];
				drGeneral["DtDorezim"] = pagesa.Tables[0].Rows[2][1];
				drGeneral["Interval"] = pagesa.Tables[0].Rows[4][1];
				drGeneral["Cmim"] = pagesa.Tables[0].Rows[5][1];
				drGeneral["Skonto"] = pagesa.Tables[0].Rows[8][1];
				drGeneral["Gjobe"] = pagesa.Tables[0].Rows[9][1];
				drGeneral["Kapar"] = pagesa.Tables[0].Rows[7][1];
				drGeneral["Total"] = pagesa.Tables[0].Rows[10][1];
				drGeneral["ShumaTotale"] = Convert.ToInt32(pagesa.Tables[0].Rows[10][1]) + 
					Convert.ToInt32(detyrime.Tables[0].Rows[detyrime.Tables[0].Rows.Count - 1][6]);
				// Hedhim rreshtin ne tabele
				dsFaturaKlienti.Tables["General"].Rows.Add(drGeneral);
				dsFaturaKlienti.AcceptChanges();
				// Shtojme tabelen e re "DetyrimeKliente" qe mban te dhenat per klientet dhe detyrimet e tyre
				DataTable dtDetyrime = new DataTable("DetyrimeKlienti");
				dtDetyrime.Columns.Add("Dhoma", typeof(String));
				dtDetyrime.Columns.Add("Emri1", typeof(String));
				dtDetyrime.Columns.Add("Emri2", typeof(String));
				dtDetyrime.Columns.Add("LlojDetyrimi", typeof(String));
				dtDetyrime.Columns.Add("Sasia", typeof(String));
				dtDetyrime.Columns.Add("Totali", typeof(String));
				dsFaturaKlienti.Tables.Add(dtDetyrime);
				int totali = 0;
				// Ky variabel sherben per te kontrolluar nese rreshti pasardhes i DataRow dr ka te njejtin emer
				// klienti apo jo.
				int i = 1;
				foreach(DataRow dr in detyrime.Tables[0].Rows)
				{
					DataRow drDetyrime = dsFaturaKlienti.Tables["DetyrimeKlienti"].NewRow();
					int count = dsFaturaKlienti.Tables[1].Rows.Count;
					if (count > 0)
					{
						// Nese edhe detyrimi tjeter eshte i te njejtit klient atehere hidh vetem detyrimin
						if (dsFaturaKlienti.Tables[1].Rows[count - 1]["Emri2"].ToString() == dr[0].ToString())
						{
							drDetyrime[0] = drGeneral["Dhoma"];
							drDetyrime[1] = "	" + dr[2];
							drDetyrime[2] = dr[0];
							drDetyrime[3] = "	" + dr[1];
							drDetyrime[4] = dr[6];
							
							totali += Convert.ToInt32(dr[6]);
							// Nese ky eshte rreshti i fundit me kete emer klienti atehere duhet te bejme shumen
							// e detyrimeve dhe ta hedhim ne kolonen perkatese te datasetit
							if (i < detyrime.Tables[0].Rows.Count)
							{
								if (detyrime.Tables[0].Rows[i][0].ToString() != dr[0].ToString())
								{
									drDetyrime[5] = totali;
									totali = 0;
								}
							}
						}
						else
						{
							// Nese jemi ne rreshtin e fundit atehere hidh totalin ne dataset dhe dil
							if (dr[0].ToString() == "SHUMA")
							{
							}
							else
							{
								// Hedhim kete rresht qe do mbaje vetem emrin e klientit
								drDetyrime[0] = drGeneral["Dhoma"];
								drDetyrime[1] = dr[0];
								drDetyrime[2] = dr[0];
								drDetyrime[3] = "";
								drDetyrime[4] = "";
								totali = 0;
								// Nese ky eshte rreshti i fundit me kete emer klienti atehere duhet te bejme shumen
								// e detyrimeve dhe ta hedhim ne kolonen perkatese te datasetit
								if (i < detyrime.Tables[0].Rows.Count)
								{
									if (detyrime.Tables[0].Rows[i][0].ToString() != dr[0].ToString())
									{
										totali += Convert.ToInt32(dr[6]);
										drDetyrime[5] = totali;
										totali = 0;
									}
									else
									{
										dsFaturaKlienti.Tables["DetyrimeKlienti"].Rows.Add(drDetyrime);
										// Hedhim nje rresht te ri qe do te kete llojin e detyrimit dhe pagesat perkatese
										drDetyrime = dsFaturaKlienti.Tables["DetyrimeKlienti"].NewRow();
										drDetyrime[0] = drGeneral["Dhoma"];
										drDetyrime[1] = "	" + dr[2];
										drDetyrime[2] = dr[0];
										drDetyrime[3] = "	" + dr[1];
										drDetyrime[4] = dr[6];
										totali += Convert.ToInt32(dr[6]);
									}
								}
								else
								{
									dsFaturaKlienti.Tables["DetyrimeKlienti"].Rows.Add(drDetyrime);
									// Hedhim nje rresht te ri qe do te kete llojin e detyrimit dhe pagesat perkatese
									drDetyrime = dsFaturaKlienti.Tables["DetyrimeKlienti"].NewRow();
									drDetyrime[0] = drGeneral["Dhoma"];
									drDetyrime[1] = "	" + dr[2];
									drDetyrime[2] = dr[0];
									drDetyrime[3] = "	" + dr[1];
									drDetyrime[4] = dr[6];
									totali += Convert.ToInt32(dr[6]);
								}
							}
						}
					}
					else
					{
						// Hedhim kete rresht qe do mbaje vetem emrin e klientit
						drDetyrime[0] = drGeneral["Dhoma"];
						drDetyrime[1] = dr[0];
						drDetyrime[2] = dr[0];
						drDetyrime[3] = "";
						drDetyrime[4] = "";
						totali = 0;
						// Nese ky eshte rreshti i fundit me kete emer klienti atehere duhet te bejme shumen
						// e detyrimeve dhe ta hedhim ne kolonen perkatese te datasetit
						if (i < detyrime.Tables[0].Rows.Count)
						{
							if (detyrime.Tables[0].Rows[i][0].ToString() != dr[0].ToString())
							{
								totali += Convert.ToInt32(dr[6]);
								drDetyrime[5] = totali;
								totali = 0;
							}
							else
							{
								dsFaturaKlienti.Tables["DetyrimeKlienti"].Rows.Add(drDetyrime);
								// Hedhim nje rresht te ri qe do te kete llojin e detyrimit dhe pagesat perkatese
								drDetyrime = dsFaturaKlienti.Tables["DetyrimeKlienti"].NewRow();
								drDetyrime[0] = drGeneral["Dhoma"];
								drDetyrime[1] = "	" + dr[2];
								drDetyrime[2] = dr[0];
								drDetyrime[3] = "	" + dr[1];
								drDetyrime[4] = dr[6];
								totali += Convert.ToInt32(dr[6]);
							}
						}
						else
						{
							dsFaturaKlienti.Tables["DetyrimeKlienti"].Rows.Add(drDetyrime);
							// Hedhim nje rresht te ri qe do te kete llojin e detyrimit dhe pagesat perkatese
							drDetyrime = dsFaturaKlienti.Tables["DetyrimeKlienti"].NewRow();
							drDetyrime[0] = drGeneral["Dhoma"];
							drDetyrime[1] = "	" + dr[2];
							drDetyrime[2] = dr[0];
							drDetyrime[3] = "	" + dr[1];
							drDetyrime[4] = dr[6];
							totali += Convert.ToInt32(dr[6]);
						}
					}
					dsFaturaKlienti.Tables["DetyrimeKlienti"].Rows.Add(drDetyrime);
					i++;
				}
				DataRelation general2detyrime = new DataRelation("GeneralDetyrime",	
					dsFaturaKlienti.Tables["General"].Columns["Dhoma"], 
					dsFaturaKlienti.Tables["DetyrimeKlienti"].Columns["Dhoma"]);
				dsFaturaKlienti.Relations.Add(general2detyrime);

				dsFaturaKlienti.AcceptChanges();
				dsFaturaKlienti.WriteXml(@"C:\Program Files\VisionInfoSolution\HotelManagment\" + "FatureKlienti.xml", XmlWriteMode.WriteSchema);
				this.PerktheFatura("FatureKlienti.xml", true, "Emri1");
			}
			catch(Exception ex)
			{
				return;
			}
		}
		
		/// <summary>
		/// Ben formatimin e dataseteve qe sherbejne per printimin e fatures per grupet dhe i hedh ne nje
		/// dataset me dy tabela
		/// </summary>
		private void FormatDataSetsGrupi()
		{
			try
			{
				// Ne fillim te dhenat e hotelit i hedhim ne nje dataset
				DataSet ds = new DataSet();
				string informacionet = Application.StartupPath + "\\Informacione.xml";
				if (File.Exists(informacionet))
					ds.ReadXml(Application.StartupPath + "\\Informacione.xml");
				// Krijojme nje dataset te ri
				DataSet dsFaturaGrupi = new DataSet();
				dsFaturaGrupi.EnforceConstraints = false;
				// Shtojme nje tabele General ne dataset e cila do te mbaje te dhenat e pergjithshme
				// qe ka fatura. Shtojme dhe kolonat per keto te dhena
				dsFaturaGrupi.Tables.Add("General");
				dsFaturaGrupi.Tables["General"].Columns.Add("Hotel", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Adrese", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Nr.Tel", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Website", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Email", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("KodFiskal", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("MesazhQendrimi", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Kapar", typeof(Int32));
				dsFaturaGrupi.Tables["General"].Columns.Add("Skonto", typeof(Int32));
				dsFaturaGrupi.Tables["General"].Columns.Add("Gjobe", typeof(Int32));
				dsFaturaGrupi.Tables["General"].Columns.Add("KaparSkontoGjobe", typeof(Int32));
				dsFaturaGrupi.Tables["General"].Columns.Add("TotaliDhomat", typeof(Int32));
				dsFaturaGrupi.Tables["General"].Columns.Add("Grupi", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Agjensia", typeof(String));
				// Krijojme nje rresht te ri ne tabele dhe e mbushim me te dhenat e duhura
				DataRow drGeneral = dsFaturaGrupi.Tables["General"].NewRow();
				drGeneral[0] = ds.Tables[0].Rows[0][0];
				drGeneral[1] = ds.Tables[0].Rows[0][1];
				drGeneral[2] = ds.Tables[0].Rows[0][2];
				drGeneral[4] = ds.Tables[0].Rows[0][3];
				drGeneral[3] = ds.Tables[0].Rows[0][4];
				drGeneral[5] = ds.Tables[0].Rows[0][5];
				drGeneral["MesazhQendrimi"] = ds.Tables[0].Rows[0][7];
				drGeneral["Kapar"] = this.pagesa_grupi.Tables[0].Rows[pagesa_grupi.Tables[0].Rows.Count - 4]["VLERA"];
				drGeneral["Skonto"] = this.pagesa_grupi.Tables[0].Rows[pagesa_grupi.Tables[0].Rows.Count - 3]["VLERA"];
				drGeneral["Gjobe"] = this.pagesa_grupi.Tables[0].Rows[pagesa_grupi.Tables[0].Rows.Count - 2]["VLERA"];
				drGeneral["KaparSkontoGjobe"] =  - Convert.ToInt32(drGeneral["Kapar"]) - Convert.ToInt32(drGeneral["Skonto"]) +
					Convert.ToInt32(drGeneral["Gjobe"]);
				drGeneral["TotaliDhomat"] = Convert.ToInt32(this.pagesa_grupi.Tables[0].Rows[pagesa_grupi.Tables[0].Rows.Count - 1]["VLERA"]);
				drGeneral["Grupi"] = this.cmbGrupet.Kolone1Vlere;
				drGeneral["Agjensia"] = this.txtAgjensia.Text;
				dsFaturaGrupi.Tables["General"].Rows.Add(drGeneral);
				dsFaturaGrupi.AcceptChanges();
				// Krijojme tabelen e re Dhomat qe mban emrin e dhomave me atributet perkatese
				dsFaturaGrupi.Tables.Add("Dhomat");
				dsFaturaGrupi.Tables["Dhomat"].Columns.Add("Grupi", typeof(String));
				dsFaturaGrupi.Tables["Dhomat"].Columns.Add("Emri", typeof(String));
				dsFaturaGrupi.Tables["Dhomat"].Columns.Add("Vlera", typeof(String));
				dsFaturaGrupi.Tables["Dhomat"].Columns.Add("TotaliDhoma", typeof(String));
				dsFaturaGrupi.EnforceConstraints = false;
				string emriDhoma, dateFillimi, dateDorezimi;
				int totaliDetyrime = 0;
				int totaliPergjithshem = 0;
				// Do te hedhim ne tabelen Dhomat, ne nje kolone emrin e dhomes dhe datat e fillimit dhe te 
				// mbarimit ose intervalin ose cmimin dhe ne nje kolone tjeter vlerat per intervalin dhe cmimin.
				// Ne nje kolone tjeter vleren totale per nje dhome
				for (int i = 0; i < pagesa_grupi.Tables[0].Rows.Count - 4; i++)
				{
					DataRow drDhomat = dsFaturaGrupi.Tables["Dhomat"].NewRow();
					drDhomat["Grupi"] = this.cmbGrupet.Kolone1Vlere;
					emriDhoma = this.pagesa_grupi.Tables[0].Rows[i][1].ToString();
					dateFillimi = Convert.ToDateTime(this.pagesa_grupi.Tables[0].Rows[i][3]).ToShortDateString();
					dateDorezimi = Convert.ToDateTime(this.pagesa_grupi.Tables[0].Rows[i][5]).ToShortDateString();
					drDhomat["Emri"] = emriDhoma + "\t\t\t" + dateFillimi + "\t" + dateDorezimi;
					dsFaturaGrupi.Tables["Dhomat"].Rows.Add(drDhomat);
					// Shtojme rreshtin e dyte qe sherben per te mbajtur intervalin dhe vleren per te
					drDhomat = dsFaturaGrupi.Tables["Dhomat"].NewRow();
					drDhomat["Grupi"] = this.cmbGrupet.Kolone1Vlere;
					drDhomat["Emri"] = "	Intervali:";
					drDhomat["Vlera"] = this.pagesa_grupi.Tables[0].Rows[i][6];
					dsFaturaGrupi.Tables["Dhomat"].Rows.Add(drDhomat);
					// Shtojme rreshtin e trete qe do te mbaje cmimin, vleren per te dhe totalin per interval
					// dhe cmim
					drDhomat = dsFaturaGrupi.Tables["Dhomat"].NewRow();
					drDhomat["Grupi"] = this.cmbGrupet.Kolone1Vlere;
					drDhomat["Emri"] = "	Cmimi:";
					drDhomat["Vlera"] = this.pagesa_grupi.Tables[0].Rows[i][7];
					//drDhomat["TotaliDhoma"] = this.pagesa_grupi.Tables[0].Rows[i][8];
					dsFaturaGrupi.Tables["Dhomat"].Rows.Add(drDhomat);
					// Shtojme dhe nje rresht te ri per detyrimet totale te dhomes.
					// Ne kolonen Vlera shtojme totalin e detyrimeve te cilen e gjejme duke filtruar rreshtat
					// e datasetit detyrimeGrupi
					drDhomat = dsFaturaGrupi.Tables["Dhomat"].NewRow();
					drDhomat["Grupi"] = this.cmbGrupet.Kolone1Vlere;
					drDhomat["Emri"] = "	Detyrime te tjera te dhomes:";
					totaliDetyrime = 0;
					foreach (DataRow dr in detyrimeGrupi.Tables[0].Select("DHOMA_EMRI = '" + pagesa_grupi.Tables[0].Rows[i][1] + "'"))
					{
						totaliDetyrime += Convert.ToInt32(dr[6]);
					}
					drDhomat["Vlera"] = totaliDetyrime;
					drDhomat["TotaliDhoma"] = Convert.ToInt32(this.pagesa_grupi.Tables[0].Rows[i][8]) + totaliDetyrime;
					totaliPergjithshem += totaliDetyrime;
					dsFaturaGrupi.Tables["Dhomat"].Rows.Add(drDhomat);
				}
				drGeneral["TotaliDhomat"] = Convert.ToInt32(this.pagesa_grupi.Tables[0].Rows[pagesa_grupi.Tables[0].Rows.Count - 1]["VLERA"])
					+ totaliPergjithshem;
				DataRelation general2dhoma = new DataRelation("GeneralDhoma",	
					dsFaturaGrupi.Tables["General"].Columns["Grupi"], 
					dsFaturaGrupi.Tables["Dhomat"].Columns["Grupi"]);
				dsFaturaGrupi.Relations.Add(general2dhoma);

				dsFaturaGrupi.AcceptChanges();
				dsFaturaGrupi.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\FatureGrupi.xml", XmlWriteMode.WriteSchema);
				this.PerktheFatura("FatureGrupi.xml", false, "");
			}
			catch(Exception ex)
			{
				return;
			}
		}
		
		/// <summary>
		/// Ben formatimin e dataseteve qe sherbejne per printimin e fatures per disa dhoma te grupeve
		/// dhe i hedh ne nje dataset me dy tabela
		/// </summary>
		private void FormatDataSetsDhomaGrupi()
		{
			try
			{
				// Ne fillim te dhenat e hotelit i hedhim ne nje dataset
				DataSet ds = new DataSet();
				string informacionet = Application.StartupPath + "\\Informacione.xml";
				if (File.Exists(informacionet))
					ds.ReadXml(Application.StartupPath + "\\Informacione.xml");
				// Krijojme nje dataset te ri
				DataSet dsFaturaGrupi = new DataSet();
				dsFaturaGrupi.EnforceConstraints = false;
				// Shtojme nje tabele General ne dataset e cila do te mbaje te dhenat e pergjithshme
				// qe ka fatura. Shtojme dhe kolonat per keto te dhena
				dsFaturaGrupi.Tables.Add("General");
				dsFaturaGrupi.Tables["General"].Columns.Add("Hotel", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Adrese", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Nr.Tel", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Website", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Email", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("KodFiskal", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("MesazhQendrimi", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Grupi", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Agjensia", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("TotaliDhomat", typeof(Int32));
				// Krijojme nje rresht te ri ne tabele dhe e mbushim me te dhenat e duhura
				DataRow drGeneral = dsFaturaGrupi.Tables["General"].NewRow();
				drGeneral[0] = ds.Tables[0].Rows[0][0];
				drGeneral[1] = ds.Tables[0].Rows[0][1];
				drGeneral[2] = ds.Tables[0].Rows[0][2];
				drGeneral[4] = ds.Tables[0].Rows[0][3];
				drGeneral[3] = ds.Tables[0].Rows[0][4];
				drGeneral[5] = ds.Tables[0].Rows[0][5];
				drGeneral["MesazhQendrimi"] = ds.Tables[0].Rows[0][7];
				drGeneral["Grupi"] = this.cmbGrupet.Kolone1Vlere;
				drGeneral["Agjensia"] = this.txtAgjensia.Text;
				dsFaturaGrupi.Tables["General"].Rows.Add(drGeneral);
				dsFaturaGrupi.AcceptChanges();
				// Krijojme tabelen e re Dhomat qe mban emrin e dhomave me atributet perkatese
				dsFaturaGrupi.Tables.Add("Dhomat");
				dsFaturaGrupi.Tables["Dhomat"].Columns.Add("Grupi", typeof(String));
				dsFaturaGrupi.Tables["Dhomat"].Columns.Add("Emri", typeof(String));
				dsFaturaGrupi.Tables["Dhomat"].Columns.Add("Vlera", typeof(String));
				dsFaturaGrupi.Tables["Dhomat"].Columns.Add("TotaliDhoma", typeof(String));
				dsFaturaGrupi.EnforceConstraints = false;
				string emriDhoma, dateFillimi, dateDorezimi;
				int totaliDetyrime = 0;
				int totaliPergjithshem = 0;
				// Do te hedhim ne tabelen Dhomat, ne nje kolone emrin e dhomes dhe datat e fillimit dhe te 
				// mbarimit ose intervalin ose cmimin dhe ne nje kolone tjeter vlerat per intervalin dhe cmimin.
				// Ne nje kolone tjeter vleren totale per nje dhome
				for (int i = 0; i < pagesa_grupi.Tables[0].Rows.Count - 4; i++)
				{
					string item = pagesa_grupi.Tables[0].Rows[i][1].ToString();
					if (this.lbKlientetLargim.Kolone1.Items.Contains(item))
					{
						DataRow drDhomat = dsFaturaGrupi.Tables["Dhomat"].NewRow();
						drDhomat["Grupi"] = this.cmbGrupet.Kolone1Vlere;
						emriDhoma = this.pagesa_grupi.Tables[0].Rows[i][1].ToString();
						dateFillimi = Convert.ToDateTime(this.pagesa_grupi.Tables[0].Rows[i][3]).ToShortDateString();
						dateDorezimi = Convert.ToDateTime(this.pagesa_grupi.Tables[0].Rows[i][5]).ToShortDateString();
						drDhomat["Emri"] = emriDhoma + "\t\t\t" + dateFillimi + "\t" + dateDorezimi;
						dsFaturaGrupi.Tables["Dhomat"].Rows.Add(drDhomat);
						// Shtojme rreshtin e dyte qe sherben per te mbajtur intervalin dhe vleren per te
						drDhomat = dsFaturaGrupi.Tables["Dhomat"].NewRow();
						drDhomat["Grupi"] = this.cmbGrupet.Kolone1Vlere;
						drDhomat["Emri"] = "	Intervali:";
						drDhomat["Vlera"] = this.pagesa_grupi.Tables[0].Rows[i][6];
						dsFaturaGrupi.Tables["Dhomat"].Rows.Add(drDhomat);
						// Shtojme rreshtin e trete qe do te mbaje cmimin dhe vleren per te
						drDhomat = dsFaturaGrupi.Tables["Dhomat"].NewRow();
						drDhomat["Grupi"] = this.cmbGrupet.Kolone1Vlere;
						drDhomat["Emri"] = "	Cmimi:";
						drDhomat["Vlera"] = this.pagesa_grupi.Tables[0].Rows[i][7];
						//drDhomat["TotaliDhoma"] = this.pagesa_grupi.Tables[0].Rows[i][8];
						dsFaturaGrupi.Tables["Dhomat"].Rows.Add(drDhomat);
						// Shtojme dhe nje rresht te ri per detyrimet totale te dhomes.
						// Ne kolonen Vlera shtojme totalin e detyrimeve te cilen e gjejme duke filtruar rreshtat
						// e datasetit detyrimeGrupi. Ne kolonen TotaliDhoma shtojme totalin per dhome
						drDhomat = dsFaturaGrupi.Tables["Dhomat"].NewRow();
						drDhomat["Grupi"] = this.cmbGrupet.Kolone1Vlere;
						drDhomat["Emri"] = "	Detyrime te tjera te dhomes:";
						totaliDetyrime = 0;
						foreach (DataRow dr in detyrimeGrupi.Tables[0].Select("DHOMA_EMRI = '" + pagesa_grupi.Tables[0].Rows[i][1] + "'"))
						{
							totaliDetyrime += Convert.ToInt32(dr[6]);
						}
						drDhomat["Vlera"] = totaliDetyrime;
						drDhomat["TotaliDhoma"] = Convert.ToInt32(this.pagesa_grupi.Tables[0].Rows[i][8]) + totaliDetyrime;
						totaliPergjithshem += Convert.ToInt32(this.pagesa_grupi.Tables[0].Rows[i][8]) + totaliDetyrime;
						dsFaturaGrupi.Tables["Dhomat"].Rows.Add(drDhomat);
					}
				}
				drGeneral["TotaliDhomat"] = totaliPergjithshem;
				DataRelation general2dhoma = new DataRelation("GeneralDhoma",	
					dsFaturaGrupi.Tables["General"].Columns["Grupi"], 
					dsFaturaGrupi.Tables["Dhomat"].Columns["Grupi"]);
				dsFaturaGrupi.Relations.Add(general2dhoma);

				dsFaturaGrupi.AcceptChanges();
				dsFaturaGrupi.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\FatureDhomaGrupi.xml", XmlWriteMode.WriteSchema);
				this.PerktheFatura("FatureDhomaGrupi.xml", false, "");
			}
			catch(Exception ex)
			{
				return;
			}
		}

		/// <summary>
		/// Ben formatimin e dataseteve qe sherbejne per printimin e fatures per nje klient te grupit
		/// </summary>
		private void FormatDataSetsDhomeGrup()
		{
			try
			{
				// Ne fillim te dhenat e hotelit i hedhim ne nje dataset
				DataSet ds = new DataSet();
				string informacionet = Application.StartupPath + "\\Informacione.xml";
				if (File.Exists(informacionet))
					ds.ReadXml(Application.StartupPath + "\\Informacione.xml");
				// Krijojme nje dataset te ri
				DataSet dsFaturaGrupi = new DataSet();
				dsFaturaGrupi.EnforceConstraints = false;
				#region Tabela General
				// Shtojme nje tabele General ne dataset e cila do te mbaje te dhenat e pergjithshme
				// qe ka fatura. Shtojme dhe kolonat per keto te dhena
				dsFaturaGrupi.Tables.Add("General");
				dsFaturaGrupi.Tables["General"].Columns.Add("Hotel", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Adrese", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Nr.Tel", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Website", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Email", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("KodFiskal", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("MesazhQendrimi", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Grupi", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Agjensia", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("DhomaEmri", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("DtMarrje", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("DtDorezim", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Interval", typeof(String));
				dsFaturaGrupi.Tables["General"].Columns.Add("Cmimi", typeof(Int32));
				dsFaturaGrupi.Tables["General"].Columns.Add("TotaliDhome", typeof(Int32));
				// Krijojme nje rresht te ri ne tabele dhe e mbushim me te dhenat e duhura
				DataRow drGeneral = dsFaturaGrupi.Tables["General"].NewRow();
				drGeneral[0] = ds.Tables[0].Rows[0][0];
				drGeneral[1] = ds.Tables[0].Rows[0][1];
				drGeneral[2] = ds.Tables[0].Rows[0][2];
				drGeneral[4] = ds.Tables[0].Rows[0][3];
				drGeneral[3] = ds.Tables[0].Rows[0][4];
				drGeneral[5] = ds.Tables[0].Rows[0][5];
				drGeneral["MesazhQendrimi"] = ds.Tables[0].Rows[0][7];
				drGeneral["Grupi"] = this.cmbGrupet.Kolone1Vlere;
				drGeneral["Agjensia"] = this.txtAgjensia.Text;
				foreach(DataRow drDhoma in pagesa_grupi.Tables[0].Select("DHOMA = " + "'" + this.lbKlientetLargim.Kolone1.SelectedItem + "'")) 
				{
					drGeneral["DhomaEmri"] = drDhoma[1];
					drGeneral["DtMarrje"] = Convert.ToDateTime(drDhoma[3]).ToShortDateString();
					drGeneral["DtDorezim"] = Convert.ToDateTime(drDhoma[5]).ToShortDateString();
					drGeneral["Interval"] = drDhoma[6];
					drGeneral["Cmimi"] = Convert.ToInt32(drDhoma[7]);
					drGeneral["TotaliDhome"] = drDhoma[8];
				}
				dsFaturaGrupi.Tables["General"].Rows.Add(drGeneral);
				dsFaturaGrupi.AcceptChanges();
				#endregion
				// Shtojme tabelen e re Detyrime dhe kolonat perkatese
				dsFaturaGrupi.Tables.Add("Detyrime");
				dsFaturaGrupi.Tables["Detyrime"].Columns.Add("Grupi", typeof(String));
				dsFaturaGrupi.Tables["Detyrime"].Columns.Add("ID_KLIENTI", typeof(String));
				dsFaturaGrupi.Tables["Detyrime"].Columns.Add("Emri", typeof(String));
				dsFaturaGrupi.Tables["Detyrime"].Columns.Add("Vlera", typeof(String));
				dsFaturaGrupi.Tables["Detyrime"].Columns.Add("Totali", typeof(Int32));
				// Krijojme nje tabele te re dtDhoma qe do te permbaje te dhenat per dhomen e zgjedhur
				DataTable dtDhoma = new DataTable("Dhomat");
				dtDhoma.Columns.Add("Grupi", typeof(String));
				dtDhoma.Columns.Add("ID_KLIENTI", typeof(String));
				dtDhoma.Columns.Add("Emri", typeof(String));
				dtDhoma.Columns.Add("LlojDetyrimi", typeof(String));
				dtDhoma.Columns.Add("Vlera", typeof(String));
				dtDhoma.Columns.Add("Totali", typeof(String));
				foreach(DataRow dr in detyrimeGrupi.Tables[0].Select("DHOMA_EMRI = " + "'" + 
					this.lbKlientetLargim.Kolone1.SelectedItem + "'", "ID_KLIENTI ASC"))
				{
					DataRow drDhoma = dtDhoma.NewRow();
					drDhoma[0] = this.cmbGrupet.Kolone1Vlere;
					drDhoma[1] = dr[10];
					drDhoma[2] = dr[0];
					drDhoma[3] = dr[2];
					drDhoma[4] = dr[6];
					dtDhoma.Rows.Add(drDhoma);
				}
				foreach(DataRow dr in dtDhoma.Rows)
				{
					DataRow drDetyrime = dsFaturaGrupi.Tables["Detyrime"].NewRow();
					int count = dsFaturaGrupi.Tables["Detyrime"].Rows.Count;
					// Nese ne tabelen Detyrime ka me shume se nje rresht
					if (count > 0)
					{
						// Nese ne tabelen Detyrime gjendet ky idKlienti atehere shto detyrimin dhe vleren per te
						if (dsFaturaGrupi.Tables["Detyrime"].Rows[count - 1][1].ToString() == 
							dr[1].ToString())
						{
							drDetyrime[0] = this.cmbGrupet.Kolone1Vlere;
							drDetyrime[1] = dr[1];
							drDetyrime[2] = "\t" + dr[3];
							drDetyrime[3] = Convert.ToInt32(dr[4]);
						}
							// Perndryshe nese ky ID_KLIENTI nuk gjendet atehere shto nje rresht qe do te mbaje emrin
							// e klientit dhe nje rresht tjeter per detyrimin nese ka detyrim
						else
						{
							drDetyrime[0] = this.cmbGrupet.Kolone1Vlere;
							drDetyrime[1] = dr[1];
							drDetyrime[2] = dr[2];
							drDetyrime[3] = "";
							if (dr[3].ToString() != "" && dr[3] != null)
							{
								dsFaturaGrupi.Tables["Detyrime"].Rows.Add(drDetyrime);
								drDetyrime = dsFaturaGrupi.Tables["Detyrime"].NewRow();
								drDetyrime[0] = this.cmbGrupet.Kolone1Vlere;
								drDetyrime[1] = dr[1];
								drDetyrime[2] = "\t" + dr[3];
								drDetyrime[3] = Convert.ToInt32(dr[4]);
							}
						}
					}
						// Perndryshe, nese eshte rreshti i pare atehere nuk kemi cfare kontrollesh te bejme por 
						// shtojme rreshtin e ri
					else
					{
						drDetyrime[0] = this.cmbGrupet.Kolone1Vlere;
						drDetyrime[1] = dr[1];
						drDetyrime[2] = dr[2];
						if (dr[3].ToString() != "" && dr[3] != null)
						{
							dsFaturaGrupi.Tables["Detyrime"].Rows.Add(drDetyrime);
							drDetyrime = dsFaturaGrupi.Tables["Detyrime"].NewRow();
							drDetyrime[0] = this.cmbGrupet.Kolone1Vlere;
							drDetyrime[1] = dr[1];
							drDetyrime[2] = "\t" + dr[3];
							drDetyrime[3] = Convert.ToInt32(dr[4]);
						}
					}
					dsFaturaGrupi.Tables["Detyrime"].Rows.Add(drDetyrime);
				}
				// Hidh vlerat per totalin e cdo klienti ne dataset
				int totali = 0;
				if (dsFaturaGrupi.Tables["Detyrime"].Rows.Count < 2)
				{
					dsFaturaGrupi.Tables["Detyrime"].Rows[0][4] = 0;
				}
				else
				{
					for (int i = 0; i < dsFaturaGrupi.Tables["Detyrime"].Rows.Count - 1; i++)
					{
						int j = i + 1;
						if (dsFaturaGrupi.Tables["Detyrime"].Rows[i][1].ToString() != 
							dsFaturaGrupi.Tables["Detyrime"].Rows[j][1].ToString())
						{
							if (!Convert.IsDBNull(dsFaturaGrupi.Tables["Detyrime"].Rows[i][3]))
								if (dsFaturaGrupi.Tables["Detyrime"].Rows[i][3].ToString() != "")
									totali += Convert.ToInt32(dsFaturaGrupi.Tables["Detyrime"].Rows[i][3]);
							dsFaturaGrupi.Tables["Detyrime"].Rows[i][4] = totali;
							totali = 0;
						}
						else
						{
							if (!Convert.IsDBNull(dsFaturaGrupi.Tables["Detyrime"].Rows[i][3]))
								if (dsFaturaGrupi.Tables["Detyrime"].Rows[i][3].ToString() != "")
									totali += Convert.ToInt32(dsFaturaGrupi.Tables["Detyrime"].Rows[i][3]);
						}
						if (j == dsFaturaGrupi.Tables["Detyrime"].Rows.Count - 1)
							dsFaturaGrupi.Tables["Detyrime"].Rows[j][4] = totali;				
					}
				}
				dsFaturaGrupi.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\FaturaNjeDhomeGrupi.xml", XmlWriteMode.WriteSchema);
				this.PerktheFatura("FaturaNjeDhomeGrupi.xml", true, "Emri");
			}
			catch(Exception ex)
			{
				return;
			}
		}
		
		/// <summary>
		/// Duke marre parasysh skedarin Xml te Perkthimeve ben ndryshimin e skedareve Xml qe sherbejne per
		/// printimin e faturave. Ndryshohen mesazhi i falenderimit dhe pershkrimi i detyrimeve ne varesi te
		/// gjuhes qe paraqitet ne skedarin Perkthime
		/// </summary>
		/// <param name="path"> Vendi ku ndodhet skedari Xml qe do te ndryshohet</param>
		/// <param name="detyrime">tregon nese skedari ka detyrime apo jo</param>
		/// <param name="kolona">emri i kolones ne te cilen ndodhen skedaret.
		/// 0 nese detyrime eshte false</param>
		private void PerktheFatura(string path, bool detyrime, string kolona)
		{
			try
			{
				DataSet ds = new DataSet();
				DataSet dsPerkthime = new DataSet();
				dsPerkthime.ReadXml(Application.StartupPath + "\\Perkthime.xml");
				ds.ReadXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment\\" + path);
				DataTable dtGeneral = ds.Tables[0];
				DataTable dtDetyrime = ds.Tables[1];
				DataRow drPerkthime = (DataRow)dsPerkthime.Tables[0].Select("ID = 'MesazhQendrimi'").GetValue(0);
				gjuha = dsPerkthime.Tables[1].Rows[0][0].ToString();
				ds.Tables[0].Rows[0]["MesazhQendrimi"] = drPerkthime[dsPerkthime.Tables[1].Rows[0][0].ToString()];
				// Tani bejme zevendesimin e detyrimeve me gjuhen e perzgjedhur.
				// Kjo duhet te ndodhe ne rastin kur parametri detyrime eshte true
				if (detyrime)
				{
					foreach (DataRow dr in dsPerkthime.Tables[0].Rows)
					{
						// Nese gjendet nje detyrim me kete emer atehere hidh analogun e tij ne 
						// gjuhen e zgjedhur
						if (dtDetyrime.Select(kolona + " = '\t" + dr["Shqip"] + "'").Length > 0)
						{
							DataRow dr1 = (DataRow)dtDetyrime.Select(kolona + " = '\t" + dr["Shqip"] + "'").GetValue(0);
							dr1[kolona] = "\t" + dr[gjuha];
						}
					}
				}
				ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\" + path, XmlWriteMode.WriteSchema);
			}
			catch (Exception ex)
			{
				return;
			}
		}

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
		private DataSet gjejDataSetKlientet(string str_id)
		{
			DataSet ds = new DataSet();
			ds.Tables.Add();
			ds.Tables[0].Columns.Add("ID", typeof(Int32));
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
			return ds;
		}

		#endregion

		#region Event Handlers

		private void DorezoDhome_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				// pastrim variablash private
				this.kliente.Tables.Clear();
				this.pagesa.Tables.Clear();
				this.info.Tables.Clear();
				this.pagesa_grupi.Tables.Clear();
				this.kliente_grupi.Tables.Clear();
				this.info_grupi.Tables.Clear();
				this.detyrimeGrupi.Tables.Clear();
				this.total_dhomat_grupi = 0;
				this.total_dhoma = 0;
				this.total_detyrime_grupi = 0;
				this.total_detyrime = 0;
				this.pergjegjes = 0;
				this.pergjegjes_grupi = 0;
				this.id_kliente_grupi = null;
				this.detyrime.Tables.Clear();
				this.gjuha = "";
				this.readyToPrint = false;
				// pastrim variablash private
				this.mbushGrupet();
				this.mbushKategorite();
				this.MbushPagesat();
				this.dtpDorezim.Value = DateTime.Now;
				this.dtpMbarimiGrupi.Value = DateTime.Now;
				KontrolloDhomatDorezim();
				KontrolloDhomatDorezim2();
				System.Windows.Forms.ToolTip tooltip = new ToolTip();
				tooltip.SetToolTip(this.gridDetyrimiGrupi, "Klikoni mbi nje prej klienteve" + System.Environment.NewLine + "nqs doni te shihni apo te printoni vetem detyrimet e tij!");
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
				this.AutoScrollPosition = new Point(0, 0);
				this.Cursor = Cursors.Default;
			}
		}


		/// <summary>
		/// Ne kete event behet pastrimi i tabeve gjate ndryshimit si edhe 
		/// propertie ReadyToPrint behet false mqs eshte pastruar gjithcka
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.ReadyToPrint = false;
				if (tabControl1.SelectedTab == this.tbKlient)//dorezimi i dhomave per kliente
				{
					this.Pastro(this.gbDorezim);
					lbKlientet.Kolone1.Items.Clear();
					lbKlientet.Kolone2.Items.Clear();
					gridPagesa.DataSource = null;
					gridDetyrime.DataSource = null;
					this.toolTips.SetToolTip(this.gridDetyrime, "Detyrimet ekstra per klientet e dhomes!");
				}
				else//dorezimi i dhomave per grup
				{
					this.Pastro(groupBox1);
					this.lbKlientetGrupi.Kolone1.Items.Clear();
					this.lbKlientetGrupi.Kolone2.Items.Clear();
					this.lbKlientetLargim.Kolone1.Items.Clear();
					this.lbKlientetLargim.Kolone2.Items.Clear();
					gridPagesaGrupi.DataSource = null;
					gridDetyrimiGrupi.DataSource = null;
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
				this.AutoScrollPosition = new Point(0, 0);
				this.Cursor = Cursors.Default;
			}
		}

		private void cmbDhomat_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{ 
			this.Cursor = Cursors.WaitCursor;
			try
			{
				this.total_dhoma = 0;
				this.total_detyrime = 0;
				this.gridPagesa.DataSource = null;
				this.gridDetyrime.DataSource = null;
				this.pergjegjes = 0;
				this.lbKlientet.Kolone1.Items.Clear();
				this.lbKlientet.Kolone2.Items.Clear();
				this.cmbPagesaKlienti.Kolone1.Text = "Cash";
				this.cmbPagesaKlienti.Kolone1Vlere = "Cash";
				this.cmbPagesaKlienti.Kolone2.Text = "1";
				this.cmbPagesaKlienti.Kolone2Vlere = "1";
				DataSet ds = null ;
				int id_dhoma = Convert.ToInt32(this.cmbDhomat.Kolone2Vlere.ToString()); // vlera merret nga kombo e dhomave
				DateTime date_dorezimi = Convert.ToDateTime(this.dtpDorezim.Value);
				InputController data = new InputController();
				DataTable dt = data.KerkesaRead("ShfaqVeprimetPerDhomen", id_dhoma, -1).Tables["KLIENTI"];
				kliente = new DataSet();
				kliente.Tables.Add();
				kliente.Tables[0].Columns.Add("ID", typeof(Int32));
				kliente.Tables[0].Columns.Add("KLIENTI", typeof(String));
				kliente.AcceptChanges();
				info = new DataSet();
				info.Tables.Add();
				info.Tables[0].Columns.Add("DATE_FILLIMI", typeof(String));
				info.Tables[0].Columns.Add("DATE_MBARIMI", typeof(String));
				info.AcceptChanges();
				this.numSkonto.Text = "0";
				this.numGjoba.Text = "0";
				int id_kategoria = Convert.ToInt32(this.cmbKategoriteKlient.Kolone2Vlere);
				foreach(DataRow dr in dt.Rows)
				{
					DateTime mindata = Convert.ToDateTime(dr["MINDATA"]);
					DateTime maxdata = Convert.ToDateTime(dr["MAXDATA"]);
					if ((date_dorezimi >= mindata) && (date_dorezimi <= maxdata))
					{
//						if (date_dorezimi < maxdata)
//						{
//							if (id_kategoria == 31)
//							{
//								DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome", "Deshironi te kryeni dorezimin e dhomes para afatit te caktuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//								if (result != DialogResult.Yes)
//									return;
//							}
//							else if (date_dorezimi.Date < maxdata.Date)
//							{
//								DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome", "Deshironi te kryeni dorezimin e dhomes para afatit te caktuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//								if (result != DialogResult.Yes)
//									return;
//							}
//						}
						string str_id = dr["ID_KLIENTI_STR"].ToString();
						string str_emra = dr["EMRI"].ToString();
						string str_bool = dr["KLIENT_HOTELI_STR"].ToString();
						kliente = this.gjej_klientet_dataset(str_id, str_emra, str_bool);
						this.mbushKlientet(kliente);
						int shuma = 0;

						pagesa = new DataSet();
						pagesa.Tables.Add();
						pagesa.Tables[0].Columns.Add("KRITERI", typeof(String));
						pagesa.Tables[0].Columns.Add("PERSHKRIMI", typeof(String));
						pagesa.AcceptChanges();

						DataRow pagesa_row = pagesa.Tables[0].NewRow();
						pagesa_row["KRITERI"] = "Dhoma";
						pagesa_row["PERSHKRIMI"] = this.cmbDhomat.Kolone1Vlere.ToString();
						pagesa.Tables[0].Rows.Add(pagesa_row);

						pagesa_row = pagesa.Tables[0].NewRow();
						pagesa_row["KRITERI"] = "Date fillimi";
						pagesa_row["PERSHKRIMI"] = this.konverto(mindata);
						pagesa.Tables[0].Rows.Add(pagesa_row);

						pagesa_row = pagesa.Tables[0].NewRow();
						pagesa_row["KRITERI"] = "Date mbarimi";
						pagesa_row["PERSHKRIMI"] = this.konverto(maxdata);
						pagesa.Tables[0].Rows.Add(pagesa_row);

						pagesa_row = pagesa.Tables[0].NewRow();
						pagesa_row["KRITERI"] = "Date dorezimi";
						pagesa_row["PERSHKRIMI"] = this.konverto(date_dorezimi);
						pagesa.Tables[0].Rows.Add(pagesa_row);
				
						int nr_ditesh;
						double nr_oresh_double, ore;
						string dite;
						TimeSpan ts = date_dorezimi.Subtract(mindata);
						nr_ditesh = Convert.ToInt32(ts.TotalDays);
						if (id_kategoria == 31)
						{
							nr_ditesh = Convert.ToInt32(ts.TotalMinutes);
							nr_oresh_double = nr_ditesh;
							ore = Math.Round(nr_oresh_double/60, 1);
							dite = ore + " ore";
						}
						else
						{	
							ore = nr_ditesh;
							dite = ore + " dite";
						}

						pagesa_row = pagesa.Tables[0].NewRow();
						pagesa_row["KRITERI"] = "Intervali";
						pagesa_row["PERSHKRIMI"] = dite;
						pagesa.Tables[0].Rows.Add(pagesa_row);

						data = new InputController();
						DataSet ds_cmimi = data.KerkesaRead("CmimiDhomesPerDaten", id_dhoma , mindata);
						int cmimi = Convert.ToInt32(ds_cmimi.Tables[0].Rows[0][0]);
						pagesa_row = pagesa.Tables[0].NewRow();
						pagesa_row["KRITERI"] = "Cmimi";
						pagesa_row["PERSHKRIMI"] = cmimi.ToString();
						pagesa.Tables[0].Rows.Add(pagesa_row);

						pagesa_row = pagesa.Tables[0].NewRow();
						pagesa_row["KRITERI"] = "Vlera";
						pagesa_row["PERSHKRIMI"] = Convert.ToInt32(ore * cmimi).ToString();
						pagesa.Tables[0].Rows.Add(pagesa_row);
						shuma = Convert.ToInt32(ore * cmimi);

						int kapari = Convert.ToInt32(dr["KAPARI"]);
						pagesa_row = pagesa.Tables[0].NewRow();
						pagesa_row["KRITERI"] = "Kapari";
						pagesa_row["PERSHKRIMI"] = kapari;
						pagesa.Tables[0].Rows.Add(pagesa_row);
						shuma = shuma - kapari;

						int skonto = Convert.ToInt32(this.numSkonto.Text);
						pagesa_row = pagesa.Tables[0].NewRow();
						pagesa_row["KRITERI"] = "Skonto";
						pagesa_row["PERSHKRIMI"] = skonto.ToString();
						pagesa.Tables[0].Rows.Add(pagesa_row);
						shuma = shuma - skonto;

						int gjoba = Convert.ToInt32(this.numGjoba.Text);
						pagesa_row = pagesa.Tables[0].NewRow();
						pagesa_row["KRITERI"] = "Gjoba";
						pagesa_row["PERSHKRIMI"] = gjoba.ToString();
						pagesa.Tables[0].Rows.Add(pagesa_row);
						shuma = shuma + gjoba;
						
						pagesa_row = pagesa.Tables[0].NewRow();
						pagesa_row["KRITERI"] = "Pagesa";
						pagesa_row["PERSHKRIMI"] = shuma.ToString();
						pagesa.Tables[0].Rows.Add(pagesa_row);
						this.total_dhoma = shuma;
				
						this.gridPagesa.DataSource = pagesa.Tables[0];
						this.krijostil_pagesa(gridPagesa);
						this.pergjegjes = Convert.ToInt32(dr["PERGJEGJES"]);
						pagesa.AcceptChanges();
						this.ReadyToPrint = true;
					}
					else 
					{
						string str = dr["KLIENT_HOTELI"].ToString();
						if (str.Substring(0, 4) == "True")
						{
							DataRow info_row = info.Tables[0].NewRow();
							info_row["DATE_FILLIMI"] = this.konverto(mindata);
							info_row["DATE_MBARIMI"] = this.konverto(maxdata);
							info.Tables[0].Rows.Add(info_row);
						}
					}
				}
				info.AcceptChanges();
				kliente.AcceptChanges();
				if (kliente.Tables[0].Rows.Count > 0)
				{
					int length = this.lbKlientet.Kolone1.Items.Count;
					int[] id_kliente = new int[length];
					//gjendet detyrimi per dhomen
					for(int k = 0; k < length; k++)
					{
						id_kliente[k] = Convert.ToInt32(this.lbKlientet.Kolone2.Items[k]);
					}
					data = new InputController();
					detyrime = data.KerkesaRead("ShfaqDetyrimePerKlientetEkstra", id_kliente);
					DataRow shuma_row = detyrime.Tables[0].NewRow();
					int shuma = 0;
					foreach(DataRow dr in detyrime.Tables[0].Rows)
					{
						shuma = shuma + Convert.ToInt32(dr[6]);
					}
					shuma_row["EMRI"] = "SHUMA";
					shuma_row["VLERA"] = shuma;
					detyrime.Tables[0].Rows.Add(shuma_row);
					detyrime.AcceptChanges();
					gridDetyrime.DataSource = detyrime.Tables[0];
					this.KrijoStilDetyrime();
					this.toolTips.SetToolTip(this.gridDetyrime, "Detyrimet ekstra per klientet e dhomes!");
				}
				if ((info.Tables[0].Rows.Count > 0) && (kliente.Tables[0].Rows.Count > 0))
				{
					string koment = "Kujdes! Dhoma ka hyrje te pashlyera" + System.Environment.NewLine + " per intervalet e datave si me poshte: ";
					int j = 0;
					foreach (DataRow dr in info.Tables[0].Rows)
					{
						j++;
						koment = koment + System.Environment.NewLine + j + "." + dr[0].ToString();
						koment = koment + "   " + dr[1].ToString();
					}
					koment = koment + System.Environment.NewLine + "Ne rast se doni te shlyeni dhomen kryeni dorezimet perkatese!" ;
					koment = koment + System.Environment.NewLine + "Ky veprim duhet te shoqerohet me hedhje fizike ne arke! " ;
					koment = koment + System.Environment.NewLine + "Ne rast te kundert gjendja e arkes do te rezultoje me e madhe se gjendja reale! " ;
					System.Windows.Forms.MessageBox.Show(this, koment, "Dorezo dhome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					this.ReadyToPrint = true;
					return;
				}
				else if (info.Tables[0].Rows.Count > 0)
				{
					string koment = "Kujdes! Dhoma nuk ka aktualisht kliente por ka hyrje te pashlyera" + System.Environment.NewLine + " per intervalet e datave si me poshte: ";
					int j = 0;
					foreach (DataRow dr in info.Tables[0].Rows)
					{
						j++;
						koment = koment + System.Environment.NewLine + j + "." + dr[0].ToString();
						koment = koment + "   " + dr[1].ToString();
					}
					koment = koment + System.Environment.NewLine + "Ne rast se doni te shlyeni dhomen kryeni dorezimet perkatese!" ;
					koment = koment + System.Environment.NewLine + "Ky veprim duhet te shoqerohet me hedhje fizike ne arke! " ;
					koment = koment + System.Environment.NewLine + "Ne rast te kundert gjendja e arkes do te rezultoje me e madhe se gjendja reale! " ;
					System.Windows.Forms.MessageBox.Show(this, koment, "Dorezo dhome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					this.numSkonto.Text = "";
					this.numGjoba.Text = "";
					this.ReadyToPrint = false;
					return;
				}
				else if (kliente.Tables[0].Rows.Count == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Ne dhome nuk ka asnje klient!", "Dorezo dhome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					this.ReadyToPrint = false;
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

		private void btnDorezim_Klienti_Click(object sender, System.EventArgs e)
		{   
			this.Cursor = Cursors.WaitCursor;
			try
			{
				DialogResult result1 = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome", "Jeni te sigurt qe doni ta dorezoni dhomen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result1 != DialogResult.Yes)
					return;
				if (this.total_dhoma < 0)
				{
					string st = "Kujdes! Dorezimi i dhomes nuk mund te kryhet pasi detyrimi per dhomen rezulton negativ.";
					st += Environment.NewLine + "Per te dorezuar dhomen ju mund te kryeni nje prej veprimeve te meposhtem:";
					st += Environment.NewLine + "1. Te zvogeloni vleren e kaparit te dhene per dhomen.";
					st += Environment.NewLine + "2. Te aplikoni gjobe per dhomen.";
					st += Environment.NewLine + "3. Te ndryshoni daten e dorezimit ne rast se e keni vendosur gabim.";
					st += Environment.NewLine + "4. Te zvogeloni vleren e skontos ne rast se e keni aplikuar!";
					System.Windows.Forms.MessageBox.Show(this, st, "Dorezo dhome", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				int numer_klientesh = this.lbKlientet.Kolone1.Items.Count;
				int id_dhoma = Convert.ToInt32(this.cmbDhomat.Kolone2Vlere.ToString());
				DateTime date_dorezimi = Convert.ToDateTime(this.dtpDorezim.Value);
				int[] id = new int[numer_klientesh];
				for (int i = 0; i < numer_klientesh; i++)
				{
					id[i] = Convert.ToInt32(this.lbKlientet.Kolone2.Items[i].ToString());	
				}
				int sasia_arka = this.total_detyrime + this.total_dhoma;
				int skonto = Convert.ToInt32(this.numSkonto.Text);
				int gjobe = Convert.ToInt32(this.numGjoba.Text);
				InputController data = new InputController();
				FormatDataSets();
				int idFormaPagesa = 1;
				if ((this.total_dhoma > 0)&&(this.cmbPagesaKlienti.Kolone1.SelectedItem == null))
				{
					this.error.SetError(this.cmbPagesaKlienti, "Zgjidhni formen e pageses!");
					return;
				}
				this.error.SetError(this.cmbPagesaKlienti, "");
				if (this.total_dhoma > 0)
					idFormaPagesa = Convert.ToInt32(this.cmbPagesaKlienti.Kolone2Vlere);
				int b = data.KerkesaUpdate("DorezoDhome", skonto, gjobe,
					this.total_dhoma, pergjegjes, id, date_dorezimi, false,idFormaPagesa, this.PerdoruesId );
				if (b == 0)
				{
					this.KontrolloDhomatDorezim();
					DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome",
						"Dorezimi i dhomes u krye! Deshironi te printoni faturen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						this.Print();
					}
					this.gridPagesa.DataSource = null;
					this.gridDetyrime.DataSource = null;
					this.dtpDorezim.Value = DateTime.Now;
					this.numSkonto.Text = "";
					this.numGjoba.Text = "";
					this.cmbKategoriteKlient.Kolone1.Text = "";
					this.cmbDhomat.Kolone1.Items.Clear();
					this.cmbDhomat.Kolone2.Items.Clear();
					this.lbKlientet.Kolone1.Items.Clear();
					this.lbKlientet.Kolone2.Items.Clear();
				}
				else
				{
					DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome",
						"Dhoma nuk u dorezua! Provoni perseri!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

		private void cmbGrupet_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				this.cmbGrupet.Kolone1.Text = "";
				this.cmbGrupet.Kolone2.Text = "";
				this.gridPagesaGrupi.DataSource = null;
				this.gridDetyrimiGrupi.DataSource = null;
				this.txtAgjensia.Text = "";
				this.lbKlientetGrupi.Kolone1.Items.Clear();
				this.lbKlientetGrupi.Kolone2.Items.Clear();
				this.lbKlientetLargim.Kolone1.Items.Clear();
				this.lbKlientetLargim.Kolone2.Items.Clear();
				this.numGjobaGrupi.Text = "";
				this.numGjobaGrupi.ReadOnly = true;
				this.numSkontoGrupi.Text = "";
				this.numSkontoGrupi.ReadOnly = true;
				this.total_dhomat_grupi = 0;
				this.total_detyrime_grupi = 0;
				this.id_kliente_grupi = null;
				this.cmbPagesaGrupi.Kolone1.Text = "Cash";
				this.cmbPagesaGrupi.Kolone1Vlere = "Cash";
				this.cmbPagesaGrupi.Kolone2.Text = "1";
				this.cmbPagesaGrupi.Kolone2Vlere = "1";

				DataSet ds = null ;
				int id_grupi = Convert.ToInt32(this.cmbGrupet.Kolone2Vlere);
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqGrupin", id_grupi);
				DataRow drg = ds.Tables[0].Rows[0];
				this.txtAgjensia.Text = drg[1].ToString();
				DataSet dsGrupi = data.KerkesaRead("ShfaqVeprimetPerGrupin", id_grupi,-1);
				DataTable dt;
				if (dsGrupi.Tables[0].Rows.Count > 0)
					dt = dsGrupi.Tables["KLIENTI"];
				else
					dt = new DataTable();
				this.kliente_grupi = new DataSet();
				kliente_grupi.Tables.Add();
				kliente_grupi.Tables[0].Columns.Add("ID", typeof(Int32));
				kliente_grupi.Tables[0].Columns.Add("KLIENTI", typeof(String));
				kliente_grupi.Tables[0].Columns.Add("ID_DHOMA", typeof(Int32));
				kliente_grupi.Tables[0].Columns.Add("DHOMA", typeof(String));
				kliente_grupi.Tables[0].Columns.Add("KLIENT_HOTELI", typeof(bool));
				kliente_grupi.AcceptChanges();
				DateTime date_dorezimi = Convert.ToDateTime(this.dtpMbarimiGrupi.Value);

				this.info_grupi = new DataSet();
				info_grupi.Tables.Add();
				info_grupi.Tables[0].Columns.Add("DATE_FILLIMI", typeof(String));
				info_grupi.Tables[0].Columns.Add("DATE_MBARIMI", typeof(String));
				info_grupi.AcceptChanges();
				int kapari = 0;
				foreach(DataRow dr in dt.Rows)
				{
					DateTime mindata = Convert.ToDateTime(dr["MINDATA"]);
					DateTime maxdata = Convert.ToDateTime(dr["MAXDATA"]);
					if ((date_dorezimi >= mindata) && (date_dorezimi <= maxdata))
					{
						string str_id = dr["ID_KLIENTI_STR"].ToString();
						string str_emra = dr["EMRI"].ToString();
						string str_id_dhoma = dr["ID_DHOMA_STR"].ToString();
						string str_dhoma = dr["DHOMA_EMRI"].ToString();
						string str_bool = dr["KLIENT_HOTELI_STR"].ToString();
						kapari = Convert.ToInt32(dr["KAPARI"]);
						this.pergjegjes_grupi = Convert.ToInt32(dr["PERGJEGJES"]);
						kliente_grupi = this.gjej_klientet_dataset(str_id, str_emra, str_id_dhoma, str_dhoma, str_bool);
						pagesa_grupi = this.gjejDhomat(kliente_grupi);
					}
					else 
					{
						string str_bool =  dr["KLIENT_HOTELI_STR"].ToString();
						if (this.dorezuar_grupi(str_bool) == false)
						{
							DataRow info_row = info_grupi.Tables[0].NewRow();
							info_row["DATE_FILLIMI"] = this.konverto(mindata);
							info_row["DATE_MBARIMI"] = this.konverto(maxdata);
							info_grupi.Tables[0].Rows.Add(info_row);
						}
					}
				}
				if (kliente_grupi.Tables[0].Rows.Count > 0)
				{
					this.numSkontoGrupi.Text = "0";
					this.numGjobaGrupi.Text = "0";
					foreach(DataRow dr2 in pagesa_grupi.Tables[0].Rows)
					{
						if (Convert.ToString(dr2["DOREZUAR"]) == "False")
						{
							this.lbKlientetGrupi.Kolone1.Items.Add(dr2["DHOMA"]);
							this.lbKlientetGrupi.Kolone2.Items.Add(dr2["ID"]);
						}
					}
					pagesa_grupi.Tables[0].Columns.Add("MINDATA", typeof(DateTime));
					pagesa_grupi.Tables[0].Columns.Add("MAXDATA", typeof(DateTime));
					pagesa_grupi.Tables[0].Columns.Add("DATE_DOREZIMI", typeof(DateTime));
					pagesa_grupi.Tables[0].Columns.Add("INTERVALI", typeof(String));
					pagesa_grupi.Tables[0].Columns.Add("CMIMI", typeof(Int32));
					pagesa_grupi.Tables[0].Columns.Add("VLERA", typeof(Int32));
					pagesa_grupi.AcceptChanges();
					int shuma = 0;
					foreach(DataRow drow in pagesa_grupi.Tables[0].Rows)
					{
						int id_dhoma = Convert.ToInt32(drow["ID"]);
						DateTime mindata = DateTime.Now.AddYears(2000);
						DateTime maxdata = DateTime.Now.AddYears(-2000);
						foreach(DataRow r in this.kliente_grupi.Tables[0].Rows )
						{
							if (Convert.ToInt32(r["ID_DHOMA"]) == id_dhoma)
							{
								data = new InputController();
								DataSet klienti = data.KerkesaRead("ShfaqDataPerKlientin", Convert.ToInt32(r["ID"]));
								DateTime datafillimi = Convert.ToDateTime(klienti.Tables[0].Rows[0][0]);
								DateTime datambarimi = Convert.ToDateTime(klienti.Tables[0].Rows[0][1]);
								if (datafillimi < mindata)
									mindata = datafillimi;
								if (datambarimi > maxdata)
									maxdata = datambarimi;
							}
						}
						drow["MINDATA"] = mindata;
						drow["MAXDATA"] = maxdata;
						drow["DATE_DOREZIMI"] = maxdata;
						int id_kategoria = Convert.ToInt32(data.KerkesaRead("NxirrDhome", id_dhoma).Tables[0].Rows[0][5]);
						int nr_ditesh;
						double nr_oresh_double, ore;
						string dite;
						TimeSpan ts; 
						if (id_kategoria == 31)
						{
							ts = maxdata.Subtract(mindata);
							nr_ditesh = Convert.ToInt32(ts.TotalMinutes);
							nr_oresh_double = nr_ditesh;
							ore = Math.Round(nr_oresh_double/60, 1);
							dite = ore + " ore";
						}
						else
						{	
							ts = maxdata.Date.Subtract(mindata.Date);
							nr_ditesh = Convert.ToInt32(ts.Days);
							ore = nr_ditesh;
							dite = ore + " dite";
						}
						drow["INTERVALI"] = dite;
						data = new InputController();
						DataSet ds_cmimi = data.KerkesaRead("CmimiDhomesPerDaten", id_dhoma , mindata);
						int cmimi = Convert.ToInt32(ds_cmimi.Tables[0].Rows[0][0]);
						drow["CMIMI"] = cmimi.ToString();
						drow["VLERA"] = Convert.ToInt32(ore * cmimi);
						shuma = shuma + Convert.ToInt32(ore * cmimi);
					}
					DataRow kapari_row = pagesa_grupi.Tables[0].NewRow();
					kapari_row["DHOMA"] = "Kapari";
					kapari_row["VLERA"] = kapari.ToString();
					pagesa_grupi.Tables[0].Rows.Add(kapari_row);
					pagesa_grupi.AcceptChanges();
					shuma = shuma - kapari;

					int skonto = Convert.ToInt32(this.numSkontoGrupi.Text);
					DataRow pagesa_row = pagesa_grupi.Tables[0].NewRow();
					pagesa_row["DHOMA"] = "Skonto";
					pagesa_row["VLERA"] = skonto;
					pagesa_grupi.Tables[0].Rows.Add(pagesa_row);
					shuma = shuma - skonto;

					int gjoba = Convert.ToInt32(this.numGjobaGrupi.Text);
					pagesa_row = pagesa_grupi.Tables[0].NewRow();
					pagesa_row["DHOMA"] = "Gjoba";
					pagesa_row["VLERA"] = gjoba;
					pagesa_grupi.Tables[0].Rows.Add(pagesa_row);
					shuma = shuma + gjoba;
					this.total_dhomat_grupi = shuma;

					pagesa_row = pagesa_grupi.Tables[0].NewRow();
					pagesa_row["DHOMA"] = "Pagesa";
					pagesa_row["VLERA"] = shuma;
					pagesa_grupi.Tables[0].Rows.Add(pagesa_row);
					pagesa_grupi.AcceptChanges();
					if (this.lbKlientetGrupi.Kolone1.Items.Count > 0)
					{
						this.gridPagesaGrupi.DataSource = pagesa_grupi.Tables[0];
						this.krijostil_pagesa_grupi();
					}
					if (pagesa_grupi.Tables[0].Rows.Count <= 11)
					{
						gridPagesaGrupi.Width = 217;
						//groupBox4.Width = 244;
					}
					else
					{
						gridPagesaGrupi.Width = 233;
						//groupBox4.Width = 260;
						//gbDhomatPaDorezuara2.Width = 260;
					}
				}
				if ((info_grupi.Tables[0].Rows.Count > 0)&&(lbKlientetGrupi.Kolone1.Items.Count > 0))
				{
					string koment = "Kujdes! Grupi ka hyrje te pashlyera" + System.Environment.NewLine + " per intervalet e datave si me poshte: ";
					int j = 0;
					foreach (DataRow dr1 in info_grupi.Tables[0].Rows)
					{
						j++;
						koment = koment + System.Environment.NewLine + j + "." + dr1[0].ToString();
						koment = koment + "   " + dr1[1].ToString();
					}
					koment = koment + System.Environment.NewLine + "Ne rast se doni te shlyeni dhomat per grupin kryeni dorezimet perkatese!" ;
					koment = koment + System.Environment.NewLine + "Ky veprim duhet te shoqerohet me hedhje fizike ne arke! " ;
					koment = koment + System.Environment.NewLine + "Ne rast te kundert gjendja e arkes do te rezultoje me e madhe se gjendja reale! " ;
					System.Windows.Forms.MessageBox.Show(this, koment, "Dorezo dhome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else if ((info_grupi.Tables[0].Rows.Count > 0)&&(lbKlientetGrupi.Kolone1.Items.Count == 0))
				{
					string koment = "Kujdes! Grupi nuk ka aktualisht kliente por ka hyrje te pashlyera" + System.Environment.NewLine + " per intervalet e datave si me poshte: ";
					int j = 0;
					foreach (DataRow dr3 in info_grupi.Tables[0].Rows)
					{
						j++;
						koment = koment + System.Environment.NewLine + j + "." + dr3[0].ToString();
						koment = koment + "   " + dr3[1].ToString();
					}
					koment = koment + System.Environment.NewLine + "Ne rast se doni te shlyeni dhomen kryeni dorezimet perkatese!" ;
					koment = koment + System.Environment.NewLine + "Ky veprim duhet te shoqerohet me hedhje fizike ne arke! " ;
					koment = koment + System.Environment.NewLine + "Ne rast te kundert gjendja e arkes do te rezultoje me e madhe se gjendja reale! " ;
					System.Windows.Forms.MessageBox.Show(this, koment, "Dorezo dhome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else if (( kliente_grupi.Tables[0].Rows.Count == 0)||(lbKlientetGrupi.Kolone1.Items.Count == 0))
				{
					System.Windows.Forms.MessageBox.Show(this, "Grupi nuk ka asnje klient aktualisht ne hotel!", "Dorezo dhome", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void btnKaloMajtas_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (this.lbKlientetGrupi.Kolone1.Items.Count == 0)
					return;
				if (this.lbKlientetGrupi.Kolone1.SelectedItem == null)
					return;
				int i = this.lbKlientetGrupi.Kolone1.Items.IndexOf(this.lbKlientetGrupi.Kolone1.SelectedItem);
				int id_dhoma = Convert.ToInt32(this.lbKlientetGrupi.Kolone2.Items[i]);
				int a = this.refresh_pagesa_grupi(id_dhoma);
				if (a != -1)
				{
					this.lbKlientetLargim.Kolone1.Items.Add(this.lbKlientetGrupi.Kolone1.Items[i]);
					this.lbKlientetLargim.Kolone2.Items.Add(this.lbKlientetGrupi.Kolone2.Items[i]);
					this.lbKlientetGrupi.Kolone1.Items.Remove(this.lbKlientetGrupi.Kolone1.Items[i]);
					this.lbKlientetGrupi.Kolone2.Items.Remove(this.lbKlientetGrupi.Kolone2.Items[i]);
					this.shfaq_detyrime_grupi();
					if (this.lbKlientetGrupi.Kolone1.Items.Count == 0)
					{
						this.numSkontoGrupi.ReadOnly = false;
						this.numGjobaGrupi.ReadOnly = false;
						//this.cmbPagesaGrupi.Enabled = true;
					}
					else
					{
						this.numSkontoGrupi.ReadOnly = true;
						this.numGjobaGrupi.ReadOnly = true;
						//this.cmbPagesaGrupi.Enabled = false;
					}
					if (this.lbKlientetLargim.Kolone1.Items.Count > 0)
						this.ReadyToPrint = true;
					else
						this.ReadyToPrint = false;
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

		private void btnKaloDjathtas_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (this.lbKlientetLargim.Kolone1.Items.Count == 0)
					return;
				if (this.lbKlientetLargim.Kolone1.SelectedItem == null)
					return;
				int i = this.lbKlientetLargim.Kolone1.Items.IndexOf(this.lbKlientetLargim.Kolone1.SelectedItem);
				int id_dhoma = Convert.ToInt32(this.lbKlientetLargim.Kolone2.Items[i]);
				if (this.lbKlientetGrupi.Kolone1.Items.Count == 0)
				{
					this.numGjobaGrupi.Text = "0";
					this.numSkontoGrupi.Text = "0";
				}
				this.numSkontoGrupi_Leave(sender, e);
				this.numGjobaGrupi_Leave(sender, e);
				this.lbKlientetGrupi.Kolone1.Items.Add(this.lbKlientetLargim.Kolone1.Items[i]);
				this.lbKlientetGrupi.Kolone2.Items.Add(this.lbKlientetLargim.Kolone2.Items[i]);
				this.lbKlientetLargim.Kolone1.Items.Remove(this.lbKlientetLargim.Kolone1.Items[i]);
				this.lbKlientetLargim.Kolone2.Items.Remove(this.lbKlientetLargim.Kolone2.Items[i]);
				this.unrefresh_pagesa_grupi(id_dhoma);
				this.shfaq_detyrime_grupi();
				if (this.lbKlientetGrupi.Kolone1.Items.Count == 0)
				{
					this.numSkontoGrupi.ReadOnly = false;
					this.numGjobaGrupi.ReadOnly = false;
					//this.cmbPagesaKlienti.Enabled = true;
				}
				else
				{
					this.numSkontoGrupi.ReadOnly = true;
					this.numGjobaGrupi.ReadOnly = true;
					//this.cmbPagesaKlienti.Enabled = false;
				}
				// Kontrollojme nese print ne menu duhet te behet enable ose jo
				if (this.lbKlientetLargim.Kolone1.Items.Count > 0)
					this.ReadyToPrint = true;
				else
					this.ReadyToPrint = false;
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

		private void btnDorezoGrup_Click(object sender, System.EventArgs e)
		{  
			this.Cursor = Cursors.WaitCursor;
			try
			{
				InputController data = new InputController();
				//nqs klientet kane hyre me ane te rezervimit dhe gjendja eshte e tille
				//qe grupi ka rezervuar me teper se nje dhome por
				//jo te gjitha jane marre atehere nuk mund te behet dorezimi
				if (this.gridDetyrimiGrupi[0, 10].ToString() != "")//klientet kane ardhur me rezervim
				{
					int idRezervimi = Convert.ToInt32(this.gridDetyrimiGrupi[0, 10].ToString());
					DataSet dsRez = data.KerkesaRead("ShfaqDhomaPerRezervim", idRezervimi);
					if (dsRez.Tables[0].Rows.Count != 0)
					{
						System.Windows.Forms.MessageBox.Show(this, "Hyrja per grupin eshte realizuar me ane te rezervimit!" + Environment.NewLine + "Per datat e hyrjes grupi ka ende dhoma te rezervuara!" 
							+ Environment.NewLine + "Qe te beni dorezimin e dhomave nga grupi duhet" + Environment.NewLine+ "te fusni ne dhome keta rezervime ose t'i fshini.", "Dorezo dhome", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				DialogResult result3 = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome", "Jeni te sigurt qe doni te dorezoni dhomat?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result3 != DialogResult.Yes)
					return;
				if (this.lbKlientetLargim.Kolone1.Items.Count == 0)
				{
					DialogResult result1 = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome",
						"Duhet te zgjidhni te pakten nje prej dhomave per dorezim!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				DateTime date_dorezimi = Convert.ToDateTime(this.dtpMbarimiGrupi.Value);
				DialogResult result;
				int idFormaPagesa = 1;
				if ((this.total_dhomat_grupi > 0)&&(this.cmbPagesaGrupi.Kolone1.SelectedItem == null))
				{
					this.error.SetError(this.cmbPagesaGrupi, "Zgjidhni formen e pageses!");
					return;
				}
				this.error.SetError(this.cmbPagesaGrupi, "");
				if (this.total_dhomat_grupi > 0)
					idFormaPagesa = Convert.ToInt32(this.cmbPagesaGrupi.Kolone2Vlere);
				if (this.lbKlientetGrupi.Kolone1.Items.Count == 0)
				{
					if (this.total_dhomat_grupi < 0)
					{
						string st = "Kujdes! Dorezimi i dhomave nuk mund te kryhet pasi detyrimi per to rezulton negativ.";
						st += Environment.NewLine + "Per te dorezuar dhomat ju mund te kryeni nje prej veprimeve te meposhtem:";
						st += Environment.NewLine + "1. Te zvogeloni vleren e kaparit te dhene per grupin.";
						st += Environment.NewLine + "2. Te aplikoni gjobe per grupin.";
						st += Environment.NewLine + "3. Te ndryshoni daten e dorezimit ne rast se e keni vendosur gabim.";
						st += Environment.NewLine + "4. Te zvogeloni vleren e skontos ne rast se e keni aplikuar!";
						System.Windows.Forms.MessageBox.Show(this, st, "Dorezo dhome", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					int skonto = Convert.ToInt32(this.numSkontoGrupi.Text);
					int gjobe = Convert.ToInt32(this.numGjobaGrupi.Text);
					string ss = "Ky veprim do te kryeje dorezimin e gjithe dhomave" + Environment.NewLine;
					ss +=		"per grupin, si edhe hedhjen ne arke te detyrimeve" + Environment.NewLine;
					ss +=		"per klientet dhe te pageses per dhomat! Deshironi te vazhdoni?";
					result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome",ss, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result != DialogResult.Yes)
						return;
					FormatDataSetsGrupi();

					//pervec dorezimit te dhomes duhen gjetur edhe te gjithe klientet e tjere qe
					//kane qene ne te njejten kohe ne hotel me klientet qe largohen te fundit
					//dhe qe i perkasin te njejtit grup.
					DataSet dsGR = data.KerkesaRead("ShfaqVeprimetPerGrupin",Convert.ToInt32(this.cmbGrupet.Kolone2Vlere), -1, date_dorezimi.AddDays(-30), date_dorezimi.AddDays(30));
					int indexkerkuar = this.KerkoDataSet(dsGR, date_dorezimi, date_dorezimi);
					DataRow drk = dsGR.Tables["KLIENTI"].Rows[indexkerkuar];
					string strId = Convert.ToString(drk["ID_KLIENTI_STR"]);
					DataSet tmp = this.gjejDataSetKlientet(strId);
					int l = tmp.Tables[0].Rows.Count - this.id_kliente_grupi.Length;
					int[] idKlienteDale = new int[tmp.Tables[0].Rows.Count];
					int i = 0;
					foreach(DataRow r in tmp.Tables[0].Rows)
					{
						bool ugjet = false;
						for(int j = 0; j < this.id_kliente_grupi.Length; j++)
						{
							if (this.id_kliente_grupi[j] == Convert.ToInt32(r["ID"]))
							{
								ugjet = true;
								break;
							}
						}
						if (!ugjet)
							idKlienteDale[i] = Convert.ToInt32(r["ID"]);
						i++;
					}
					int b = data.KerkesaUpdate("PaguajDhome",idKlienteDale);
					b += data.KerkesaUpdate("DorezoDhome",  skonto, gjobe, this.total_dhomat_grupi, 
						this.pergjegjes_grupi, this.id_kliente_grupi, date_dorezimi,true, idFormaPagesa, this.PerdoruesId );
					if (b == 0)
					{
						result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome",
							"Dorezimi i dhomave u krye!  Deshironi te printoni faturen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (result == DialogResult.Yes)
						{
							this.Print();
						}
						this.KontrolloDhomatDorezim2();
						this.cmbGrupet.Kolone1.Text = "";
						this.cmbGrupet.Kolone2.Text = "";
						this.gridPagesaGrupi.DataSource = null;
						this.gridDetyrimiGrupi.DataSource = null;
						this.txtAgjensia.Text = "";
						this.lbKlientetGrupi.Kolone1.Items.Clear();
						this.lbKlientetGrupi.Kolone2.Items.Clear();
						this.lbKlientetLargim.Kolone1.Items.Clear();
						this.lbKlientetLargim.Kolone2.Items.Clear();
						this.numGjobaGrupi.Text = "";
						this.numGjobaGrupi.ReadOnly = true;
						this.numSkontoGrupi.Text = "";
						this.numSkontoGrupi.ReadOnly = true;
						this.total_dhomat_grupi = 0;
						this.total_detyrime_grupi = 0;
						this.id_kliente_grupi = null;
					}
					else
					{
						DialogResult result2 = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome",
							"Dhomat nuk u dorezuan! Provoni perseri!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				else
				{
					result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome",
						"Ky veprim do te kryeje dorezimin e dhomave te zgjedhura " + Environment.NewLine + "si edhe hedhjen ne arke te detyrimeve per klientet!" + Environment.NewLine + "Hedhja ne arke e pageses per dhomat do te kryhet vetem" + Environment.NewLine + "pasi grupi te kete dorezuar te gjitha dhomat! Deshironi te vazhdoni?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result != DialogResult.Yes)
						return;

					int b = data.KerkesaUpdate("DorezoDhome",  0, 0, this.total_dhomat_grupi, -1 ,
						id_kliente_grupi, date_dorezimi, true, idFormaPagesa, this.PerdoruesId );
					if (b == 0)
					{
						result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome",
							"Dorezimi i dhomave u krye!  Deshironi te printoni faturen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (result == DialogResult.Yes)
						{
							this.Print();
						}
						this.KontrolloDhomatDorezim2();
						this.cmbGrupet.Kolone1.Text = "";
						this.cmbGrupet.Kolone2.Text = "";
						this.gridPagesaGrupi.DataSource = null;
						this.gridDetyrimiGrupi.DataSource = null;
						this.txtAgjensia.Text = "";
						this.lbKlientetGrupi.Kolone1.Items.Clear();
						this.lbKlientetGrupi.Kolone2.Items.Clear();
						this.lbKlientetLargim.Kolone1.Items.Clear();
						this.lbKlientetLargim.Kolone2.Items.Clear();
						this.numGjobaGrupi.Text = "";
						this.numSkontoGrupi.Text = "";
						this.total_dhomat_grupi = 0;
						this.total_detyrime_grupi = 0;
						this.id_kliente_grupi = null;
					}
					else
					{
						DialogResult result1 = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dorezo dhome",
							"Dhomat nuk u dorezuan! Provoni perseri!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
				return;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void dtpMbarimiGrupi_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.cmbGrupet.Kolone1.Text = "";
				this.cmbGrupet.Kolone2.Text = "";
				this.gridPagesaGrupi.DataSource = null;
				this.gridDetyrimiGrupi.DataSource = null;
				this.txtAgjensia.Text = "";
				this.lbKlientetGrupi.Kolone1.Items.Clear();
				this.lbKlientetGrupi.Kolone2.Items.Clear();
				this.lbKlientetLargim.Kolone1.Items.Clear();
				this.lbKlientetLargim.Kolone2.Items.Clear();
				this.numGjobaGrupi.Text = "";
				this.numGjobaGrupi.ReadOnly = true;
				this.numSkontoGrupi.Text = "";
				this.numSkontoGrupi.ReadOnly = true;
				this.total_dhomat_grupi = 0;
				this.total_detyrime_grupi = 0;
				this.id_kliente_grupi = null;
				this.cmbPagesaGrupi.Kolone1.Text = "Cash";
				this.cmbPagesaGrupi.Kolone1Vlere = "Cash";
				this.cmbPagesaGrupi.Kolone2.Text = "1";
				this.cmbPagesaGrupi.Kolone2Vlere = "1";
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

		private void dtpDorezim_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				cmbKategoriteKlient.Kolone1.Text = "";
				cmbKategoriteKlient.Kolone2.Text = "";
				this.cmbDhomat.Kolone1.Text = "";
				this.cmbDhomat.Kolone2.Text = "";
				this.cmbDhomat.Kolone1.Items.Clear();
				this.cmbDhomat.Kolone2.Items.Clear();
				this.lbKlientet.Kolone1.Items.Clear();
				this.lbKlientet.Kolone2.Items.Clear();
				this.numSkonto.Text = "";
				this.numGjoba.Text = "";
				this.gridPagesa.DataSource = null;
				this.gridDetyrime.DataSource = null;
				this.total_dhoma = 0;
				this.total_detyrime = 0;
				this.pergjegjes = 0;
				this.cmbPagesaKlienti.Kolone1.Text = "Cash";
				this.cmbPagesaKlienti.Kolone1Vlere = "Cash";
				this.cmbPagesaKlienti.Kolone2.Text = "1";
				this.cmbPagesaKlienti.Kolone2Vlere = "1";
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

		private void cmbKategoriteKlient_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				DataSet ds = null;
				DateTime dtKerkimi = Convert.ToDateTime(dtpDorezim.Value);
				int idKategoria = Convert.ToInt32(this.cmbKategoriteKlient.Kolone2Vlere);
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqDhomatEZenaPerKategorine", idKategoria, dtKerkimi );
				if (ds.Tables[0].Rows.Count == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Kategoria e mesiperme" + System.Environment.NewLine + "nuk ka asnje dhome te zene!", "Dorezo dhome", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.cmbDhomat.Kolone1.Items.Clear();
					this.cmbDhomat.Kolone2.Items.Clear();
					this.cmbDhomat.Kolone1.Text = "";
					this.cmbDhomat.Kolone2.Text = "";
					lbKlientet.Kolone1.Items.Clear();
					lbKlientet.Kolone2.Items.Clear();
					numSkonto.Text = "";
					numGjoba.Text = "";
					this.total_dhoma = 0;
					this.total_detyrime = 0;
					this.gridPagesa.DataSource = null;
					this.gridDetyrime.DataSource = null;
					this.pergjegjes = 0;
					this.cmbPagesaKlienti.Kolone1.Text = "Cash";
					this.cmbPagesaKlienti.Kolone1Vlere = "Cash";
					this.cmbPagesaKlienti.Kolone2.Text = "1";
					this.cmbPagesaKlienti.Kolone2Vlere = "1";
					return;
				}
				this.cmbDhomat.Kolone1.Items.Clear();
				this.cmbDhomat.Kolone2.Items.Clear();
				this.cmbDhomat.Kolone1.Text = "";
				this.cmbDhomat.Kolone2.Text = "";
				lbKlientet.Kolone1.Items.Clear();
				lbKlientet.Kolone2.Items.Clear();
				numSkonto.Text = "";
				numGjoba.Text = "";
				this.total_dhoma = 0;
				this.total_detyrime = 0;
				this.gridPagesa.DataSource = null;
				this.gridDetyrime.DataSource = null;
				this.pergjegjes = 0;

				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbDhomat.Kolone1.Items.Add(dr[1]);
					this.cmbDhomat.Kolone2.Items.Add(dr[0]);
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
		private void btnPagesaDhoma_Click(object sender, System.EventArgs e)
		{
			try
			{
				int shuma = Convert.ToInt32(pagesa.Tables[0].Rows[6][1])- Convert.ToInt32(pagesa.Tables[0].Rows[7][1]);
				if (this.numSkonto.Text == "")
					return;
				const string NUMERIC_FORMAT = "^-?[0-9]*(\\,)?[0-9]+$";
//				const string NUMERIC_FORMAT = "[0-9]*(\\.)?[0-9]";
				if (!Regex.IsMatch(this.numSkonto.Text, NUMERIC_FORMAT))
				{
					this.error.SetError(this.numSkonto, "Skontoja duhet te jete vlere numerike!");
					this.numSkonto.IsValid = false;
					return;
				}
				int skonto = Convert.ToInt32(this.numSkonto.Text);
				if (skonto < 0)
				{
					this.error.SetError(this.numSkonto, "Skontoja nuk mund te jete negative!");
					this.numSkonto.IsValid = false;
					return;
				}
				this.error.SetError(this.numSkonto, "");
				this.numSkonto.IsValid = true;
				pagesa.Tables[0].Rows[8][1] = skonto;;
				shuma = shuma - skonto;
				
				if (this.numGjoba.Text == "")
					return;
				if (!Regex.IsMatch(this.numGjoba.Text, NUMERIC_FORMAT))
				{
					this.error.SetError(this.numGjoba, "Gjoba duhet te jete vlere numerike!");
					this.numGjoba.IsValid = false;
					return;
				}
				int gjoba = Convert.ToInt32(this.numGjoba.Text);
				if (gjoba < 0)
				{
					this.error.SetError(this.numGjoba, "Gjoba nuk mund te jete negative!");
					return;
				}
				this.error.SetError(this.numGjoba, "");
				pagesa.Tables[0].Rows[9][1] = gjoba;
				shuma = shuma + gjoba;

				pagesa.Tables[0].Rows[10][1] = shuma;

				this.gridPagesa.DataSource = pagesa.Tables[0];
				this.krijostil_pagesa(this.gridPagesa);
				this.total_dhoma = shuma;
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

		private void btnShfaqDetyrimeKlientet_Click(object sender, System.EventArgs e)
		{
			try
			{
				int numer_klientesh = this.lbKlientet.Kolone1.Items.Count;
				int te_zgjedhur = this.lbKlientet.Kolone1.SelectedItems.Count;
				int length = 0;
				if (te_zgjedhur == 0)
					return;
				if  (te_zgjedhur == numer_klientesh)
				{
					length = numer_klientesh;				
				}
				else
				{
					length = te_zgjedhur;
				}
				int[] id_kliente = new int[length];
				//gjendet detyrimi per dhomen
				for(int k = 0; k < length; k++)
				{
				
					id_kliente[k] = Convert.ToInt32(this.lbKlientet.Kolone2.Items[this.lbKlientet.Kolone1.SelectedIndices[k]]);
				}

				InputController data = new InputController();
				DataSet detyrime1 = data.KerkesaRead("ShfaqDetyrimePerKlientetEkstra", id_kliente);
				DataRow shuma_row = detyrime1.Tables[0].NewRow();
				int shuma = 0;
				foreach(DataRow dr in detyrime1.Tables[0].Rows)
				{
					shuma = shuma + Convert.ToInt32(dr[6]);
				}
				shuma_row["EMRI"] = "SHUMA";
				shuma_row["VLERA"] = shuma;
				detyrime1.Tables[0].Rows.Add(shuma_row);
				detyrime1.AcceptChanges();
				gridDetyrime.DataSource = detyrime1.Tables[0];
				this.KrijoStilDetyrime();
				this.toolTips.SetToolTip(this.gridDetyrime, "Detyrimet ekstra per klientet e zgjedhur!");
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

		private void btnLlogaritPagesen_Click(object sender, System.EventArgs e)
		{
			try
			{
//				const string NUMERIC_FORMAT = "^-?[0-9]*(\\,)?[0-9]+$";
				const string NUMERIC_FORMAT = "[0-9]*(\\.)?[0-9]";
				int shuma = Convert.ToInt32(pagesa_grupi.Tables[0].Rows[pagesa_grupi.Tables[0].Rows.Count - 1]["VLERA"]);
				int skontoVjeter = Convert.ToInt32(pagesa_grupi.Tables[0].Rows[pagesa_grupi.Tables[0].Rows.Count - 3]["VLERA"]);
				int gjobaVjeter = Convert.ToInt32(pagesa_grupi.Tables[0].Rows[pagesa_grupi.Tables[0].Rows.Count - 2]["VLERA"]);
				shuma = shuma + skontoVjeter - gjobaVjeter;
				if (this.numSkontoGrupi.Text == "")
				{
					this.error.SetError(this.numSkontoGrupi, "Vendosni vleren e skontos!");
					this.numSkontoGrupi.IsValid = false;
					return;
				}
				if (!Regex.IsMatch(this.numSkontoGrupi.Text, NUMERIC_FORMAT))
				{
					this.error.SetError(this.numSkontoGrupi, "Skontoja duhet te jete vlere numerike!");
					this.numSkontoGrupi.IsValid = false;
					return;
				}
				int skonto = Convert.ToInt32(this.numSkontoGrupi.Text);
				if (skonto < 0)
				{
					this.error.SetError(this.numSkontoGrupi, "Skontoja nuk mund te jete negative!");
					this.numSkontoGrupi.IsValid = false;
					return;
				}
				if (this.numGjobaGrupi.Text == "")
				{
					this.error.SetError(this.numGjobaGrupi, "Vendosni vleren e gjobes!");
					this.numGjobaGrupi.IsValid = false;
					return;
				}
				if (!Regex.IsMatch(this.numGjobaGrupi.Text, NUMERIC_FORMAT))
				{
					this.error.SetError(this.numGjobaGrupi, "Gjoba duhet te jete vlere numerike!");
					this.numGjobaGrupi.IsValid = false;
					return;
				}
				int gjoba = Convert.ToInt32(this.numGjobaGrupi.Text);
				if (gjoba < 0)
				{
					this.error.SetError(this.numGjobaGrupi, "Gjoba nuk mund te jete negative!");
					this.numGjobaGrupi.IsValid = false;
					return;
				}
				shuma = shuma - skonto + gjoba;
				for(int i = pagesa_grupi.Tables[0].Rows.Count - 1; i >= 0; i-- )
				{
					if (pagesa_grupi.Tables[0].Rows[i]["DHOMA"].ToString() == "Skonto")
					{
						pagesa_grupi.Tables[0].Rows[i]["VLERA"] = skonto;
					}
					else if (pagesa_grupi.Tables[0].Rows[i]["DHOMA"].ToString() == "Gjoba")
					{
						pagesa_grupi.Tables[0].Rows[i]["VLERA"] = gjoba;
					}
					else if (pagesa_grupi.Tables[0].Rows[i]["DHOMA"].ToString() == "Pagesa")
					{
						pagesa_grupi.Tables[0].Rows[i]["VLERA"] = shuma;
					}
					else
						break;
				}
				this.total_dhomat_grupi = shuma;
				pagesa_grupi.AcceptChanges();
				this.gridPagesaGrupi.DataSource = pagesa_grupi.Tables[0];
				this.krijostil_pagesa_grupi();
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
		
		private void dgDhomaPaDorezuara_CurrentCellChanged(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				int rowIndex = dgDhomaPaDorezuara.CurrentRowIndex;
				this.dtpDorezim.Value = dgDhomaPaDorezuara[rowIndex, 5];
				this.cmbKategoriteKlient.Kolone1.SelectedItem = null;
				// Ne fillim shkrepim event-in e ndryshimit te indeksit te cmbKategoriteKlient
				this.cmbKategoriteKlient.Kolone2.SelectedItem = this.dgDhomaPaDorezuara[rowIndex,2];
				this.cmbKategoriteKlient.Kolone1.SelectedItem = this.dgDhomaPaDorezuara[rowIndex, 3];
				// Tani shkrepim event-in e ndryshimit te indeksit te cmbDhoma
				this.cmbDhomat.Kolone2.SelectedItem = this.dgDhomaPaDorezuara[rowIndex, 4];
				this.cmbDhomat.Kolone1.SelectedItem = this.dgDhomaPaDorezuara[rowIndex, 0];
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

		private void dgDhomatPaDorezuaraGrup_CurrentCellChanged(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				int rowIndex = dgDhomatPaDorezuaraGrup.CurrentRowIndex;
				this.dtpMbarimiGrupi.Value = dgDhomatPaDorezuaraGrup[rowIndex, 6];
				this.cmbGrupet.Kolone1.SelectedItem = null;
				// Shkrepim event-in e ndryshimit te indeksit te cmbGrupet
				this.cmbGrupet.Kolone1.Text = this.dgDhomatPaDorezuaraGrup[rowIndex, 2].ToString();
				this.cmbGrupet.Kolone2.SelectedItem = this.dgDhomatPaDorezuaraGrup[rowIndex, 5];
				this.cmbGrupet.Kolone1.SelectedItem = this.dgDhomatPaDorezuaraGrup[rowIndex, 2];
				this.cmbGrupet.Kolone1.Text = this.dgDhomatPaDorezuaraGrup[rowIndex, 2].ToString();
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

		private void numSkonto_Leave(object sender, System.EventArgs e)
		{
			if (this.gridPagesa.DataSource != null)
				this.btnPagesaDhoma_Click(sender, e);
		}

		private void numGjoba_Leave(object sender, System.EventArgs e)
		{
			if (this.gridPagesa.DataSource != null)
				this.btnPagesaDhoma_Click(sender, e);
		}

		private void numSkontoGrupi_Leave(object sender, System.EventArgs e)
		{
			if (gridPagesaGrupi.DataSource != null)
				this.btnLlogaritPagesen_Click(sender, e);
		}
		private void numGjobaGrupi_Leave(object sender, System.EventArgs e)
		{
			if (gridPagesaGrupi.DataSource != null)
				this.btnLlogaritPagesen_Click(sender, e);	
		}
		#endregion

		#region IPrintable Members

		public void PrintPreview()
		{
			Printim print = new Printim();
			if (this.tabControl1.SelectedTab == tbKlient)
			{
				this.FormatDataSets();
				if (gjuha == "Anglisht")
					print.NgarkoRaport("FatureKlientiAng");
				else if (gjuha == "Italisht")
					print.NgarkoRaport("FatureKlientiIt");
				else if (gjuha == "Frengjisht")
					print.NgarkoRaport("FatureKlientiFr");
				else
					print.NgarkoRaport("FatureKlienti");
			}
			else if (this.tabControl1.SelectedTab == tbGrup)
			{
				if (this.lbKlientetGrupi.Kolone1.Items.Count == 0)
				{
					// Nese nuk eshte zgjedhur asnje grup per tu larguar atehere dil
					if (this.lbKlientetLargim.Kolone1.Items.Count == 0)
						return;
					this.FormatDataSetsGrupi();
					if (gjuha == "Anglisht")
						print.NgarkoRaport("FatureGrupiAng");
					else if (gjuha == "Italisht")
						print.NgarkoRaport("FatureGrupiIt");
					else if (gjuha == "Frengjisht")
						print.NgarkoRaport("FatureGrupiFr");
					else
						print.NgarkoRaport("FatureGrupi");
				}
				else
				{
					FormatDataSetsDhomaGrupi();
					if (gjuha == "Anglisht")
						print.NgarkoRaport("FatureDhomaGrupiAng");
					else if (gjuha == "Italisht")
						print.NgarkoRaport("FatureDhomaGrupiIt");
					else if (gjuha == "Frengjisht")
						print.NgarkoRaport("FatureDhomaGrupiFr");
					else
						print.NgarkoRaport("FatureDhomaGrupi");
				}
			}
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
			if (this.tabControl1.SelectedTab == tbKlient)
			{
				if (gjuha == "Anglisht")
					print.Printo("FatureKlientiAng");
				else if (gjuha == "Italisht")
					print.Printo("FatureKlientiIt");
				else if (gjuha == "Frengjisht")
					print.Printo("FatureKlientiFr");
				else
					print.Printo("FatureKlienti");
			}
			else if (this.tabControl1.SelectedTab == tbGrup)
			{
				if (gjuha == "Anglisht")
					print.Printo("FatureGrupiAng");
				else if (gjuha == "Italisht")
					print.Printo("FatureGrupiIt");
				else if (gjuha == "Frengjisht")
					print.Printo("FatureGrupiFr");
				else
					print.Printo("FatureGrupi");
			}
		}

		private void btnPrinto_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				this.FormatDataSets();
				this.PrintPreview();
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

		private void btnPrintoGrup_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if (this.lbKlientetGrupi.Kolone1.Items.Count == 0)
					this.FormatDataSetsGrupi();
				else
					this.FormatDataSetsDhomaGrupi();
				this.PrintPreview();
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

		private void pbtnPrint_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				
				if (this.lbKlientetLargim.Kolone1.SelectedItem != null)
				{
					this.FormatDataSetsDhomeGrup();
					Printim print = new Printim();
					if (gjuha == "Anglisht")
						print.NgarkoRaport("FatureNjeDhomeGrupiAng");
					else if (gjuha == "Italisht")
						print.NgarkoRaport("FatureNjeDhomeGrupiIt");
					else if (gjuha == "Frengjisht")
						print.NgarkoRaport("FatureNjeDhomeGrupiFr");
					else
						print.NgarkoRaport("FatureNjeDhomeGrupi");
					print.ShowDialog();
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

		public event VisionInfoSolutionLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

		#endregion

	}
}
