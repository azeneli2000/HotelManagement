using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using VisionInfoSolutionLibrary;
using HotelManagment.BusDatService;
using HotelManagment.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment
{
	/// <summary>
	/// Summary description for Dhome.
	/// </summary>
	public class Dhome : VisionInfoSolutionLibrary.Form, IPrintable
	{
		#region Private Variables

		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private VisionInfoSolutionLibrary.Button btnEleminoDhome;
		private VisionInfoSolutionLibrary.Button btnModifikoDhome;
		private VisionInfoSolutionLibrary.DataGrid grid;
		private VisionInfoSolutionLibrary.TabControl tabControl1;
		private VisionInfoSolutionLibrary.TabPageControl tbShto;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.ListBox lbDhomat;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.TabPageControl tbModifiko;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.NumericBox numShtreter1;
		private VisionInfoSolutionLibrary.Label label6;
		private VisionInfoSolutionLibrary.Button btnNdihme1;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategoria;
		private System.ComponentModel.IContainer components;
		private VisionInfoSolutionLibrary.Button btnKerko;
		private VisionInfoSolutionLibrary.GroupBox groupBox3;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhomatModifikime;
		private VisionInfoSolutionLibrary.ComboBox comboBox1;
		private VisionInfoSolutionLibrary.ComboBox comboBox2;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategoriteModifikime;
		private VisionInfoSolutionLibrary.ComboBox comboBox3;
		private VisionInfoSolutionLibrary.ComboBox comboBox4;
		private VisionInfoSolutionLibrary.RadioButton rbDhoma;
		private VisionInfoSolutionLibrary.RadioButton rbNrShtreter;
		private VisionInfoSolutionLibrary.NumericBox numNrShtreter;
		private VisionInfoSolutionLibrary.TextBox txtDhoma;
		private VisionInfoSolutionLibrary.Label label4;		
		private VisionInfoSolutionLibrary.GroupBox groupBox4;
		private VisionInfoSolutionLibrary.TextBox txtNrDhoma;
		private VisionInfoSolutionLibrary.Label lblNrDhoma;
		private VisionInfoSolutionLibrary.NumericBox numShtreter;
		private VisionInfoSolutionLibrary.Label label2;		
		private VisionInfoSolutionLibrary.Button btnShtoDhome;
		private VisionInfoSolutionLibrary.Label label8;
		private VisionInfoSolutionLibrary.RadioButton rbEshteCift;
		private VisionInfoSolutionLibrary.RadioButton rbNukEshteCift;
		private VisionInfoSolutionLibrary.TextBox txtCift;
		private VisionInfoSolutionLibrary.Label label9;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategorite1;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhomaCift;
		private bool readyToPrint = false;
		private System.Data.DataSet ds;
		private System.Windows.Forms.Label label10;
		private VisionInfoSolutionLibrary.GroupBox groupBox5;
		private int idKategoria;
		#endregion

		#region Constructors & Destructors
		public Dhome()
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
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.grid = new VisionInfoSolutionLibrary.DataGrid();
			this.ds = new System.Data.DataSet();
			this.btnEleminoDhome = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifikoDhome = new VisionInfoSolutionLibrary.Button(this.components);
			this.tabControl1 = new VisionInfoSolutionLibrary.TabControl();
			this.tbShto = new VisionInfoSolutionLibrary.TabPageControl();
			this.btnShtoDhome = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox4 = new VisionInfoSolutionLibrary.GroupBox();
			this.label8 = new VisionInfoSolutionLibrary.Label();
			this.rbNukEshteCift = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbEshteCift = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.txtNrDhoma = new VisionInfoSolutionLibrary.TextBox();
			this.lblNrDhoma = new VisionInfoSolutionLibrary.Label();
			this.numShtreter = new VisionInfoSolutionLibrary.NumericBox();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbKategoria = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.lbDhomat = new VisionInfoSolutionLibrary.ListBox();
			this.txtCift = new VisionInfoSolutionLibrary.TextBox();
			this.tbModifiko = new VisionInfoSolutionLibrary.TabPageControl();
			this.label9 = new VisionInfoSolutionLibrary.Label();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.btnKerko = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox3 = new VisionInfoSolutionLibrary.GroupBox();
			this.numNrShtreter = new VisionInfoSolutionLibrary.NumericBox();
			this.rbNrShtreter = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.cmbDhomatModifikime = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox1 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox2 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.cmbKategoriteModifikime = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox3 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox4 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.rbDhoma = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbKategorite1 = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbDhomaCift = new VisionInfoSolutionLibrary.DoubleCombo();
			this.groupBox5 = new VisionInfoSolutionLibrary.GroupBox();
			this.numShtreter1 = new VisionInfoSolutionLibrary.NumericBox();
			this.txtDhoma = new VisionInfoSolutionLibrary.TextBox();
			this.btnNdihme1 = new VisionInfoSolutionLibrary.Button(this.components);
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tbShto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tbModifiko.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.cmbDhomatModifikime.SuspendLayout();
			this.cmbKategoriteModifikime.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox5)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1011, 25);
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "Nr.";
			this.dataGridTextBoxColumn1.MappingName = "";
			this.dataGridTextBoxColumn1.ReadOnly = true;
			this.dataGridTextBoxColumn1.Width = 15;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "Numri i dhomes";
			this.dataGridTextBoxColumn2.MappingName = "";
			this.dataGridTextBoxColumn2.ReadOnly = true;
			this.dataGridTextBoxColumn2.Width = 50;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "Kategoria";
			this.dataGridTextBoxColumn3.MappingName = "";
			this.dataGridTextBoxColumn3.ReadOnly = true;
			this.dataGridTextBoxColumn3.Width = 75;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.Format = "";
			this.dataGridTextBoxColumn4.FormatInfo = null;
			this.dataGridTextBoxColumn4.HeaderText = "Cmimi";
			this.dataGridTextBoxColumn4.MappingName = "";
			this.dataGridTextBoxColumn4.ReadOnly = true;
			this.dataGridTextBoxColumn4.Width = 75;
			// 
			// grid
			// 
			this.grid.AllowSorting = false;
			this.grid.BackColor = System.Drawing.Color.WhiteSmoke;
			this.grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.grid.CanDelete = true;
			this.grid.CaptionText = "Dhomat";
			this.grid.CaptionVisible = false;
			this.grid.DataMember = "";
			this.grid.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.grid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grid.HideHorizontalScrollBar = false;
			this.grid.HideVerticalScrollBar = false;
			this.grid.Location = new System.Drawing.Point(12, 20);
			this.grid.Name = "grid";
			this.grid.ParentRowsVisible = false;
			this.grid.ReadOnly = true;
			this.grid.RowHeaderWidth = 36;
			this.grid.Selekto = true;
			this.grid.Size = new System.Drawing.Size(346, 312);
			this.grid.TabIndex = 21;
			this.toolTips.SetToolTip(this.grid, "Zgjidhni nje prej dhomave per ta modifikuar ose eleminuar!");
			this.grid.CurrentCellChanged += new System.EventHandler(this.grid_CurrentCellChanged);
			// 
			// ds
			// 
			this.ds.DataSetName = "NewDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// btnEleminoDhome
			// 
			this.btnEleminoDhome.BackColor = System.Drawing.Color.Blue;
			this.btnEleminoDhome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEleminoDhome.DoValidation = true;
			this.btnEleminoDhome.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnEleminoDhome.Location = new System.Drawing.Point(556, 284);
			this.btnEleminoDhome.Name = "btnEleminoDhome";
			this.btnEleminoDhome.Size = new System.Drawing.Size(90, 21);
			this.btnEleminoDhome.TabIndex = 19;
			this.btnEleminoDhome.Text = "Elemino ";
			this.toolTips.SetToolTip(this.btnEleminoDhome, "Eleminon dhomen e zgjedhur!");
			this.btnEleminoDhome.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnEleminoDhome.Click += new System.EventHandler(this.btnEleminoDhome_Click);
			// 
			// btnModifikoDhome
			// 
			this.btnModifikoDhome.BackColor = System.Drawing.Color.Blue;
			this.btnModifikoDhome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifikoDhome.DoValidation = true;
			this.btnModifikoDhome.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifikoDhome.Location = new System.Drawing.Point(432, 284);
			this.btnModifikoDhome.Name = "btnModifikoDhome";
			this.btnModifikoDhome.Size = new System.Drawing.Size(90, 21);
			this.btnModifikoDhome.TabIndex = 18;
			this.btnModifikoDhome.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifikoDhome, "Modifikon dhomen e zgjedhur!");
			this.btnModifikoDhome.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifikoDhome.Click += new System.EventHandler(this.btnModifikoDhome_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tbShto);
			this.tabControl1.Controls.Add(this.tbModifiko);
			this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabControl1.Location = new System.Drawing.Point(0, 25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1011, 609);
			this.tabControl1.TabIndex = 31;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tbShto
			// 
			this.tbShto.BackColor = System.Drawing.SystemColors.Control;
			this.tbShto.Controls.Add(this.btnShtoDhome);
			this.tbShto.Controls.Add(this.groupBox4);
			this.tbShto.Controls.Add(this.groupBox1);
			this.tbShto.Controls.Add(this.txtCift);
			this.tbShto.DefaultErrorMessage = null;
			this.tbShto.EnableValidation = true;
			this.tbShto.IsValid = false;
			this.tbShto.Location = new System.Drawing.Point(4, 22);
			this.tbShto.Name = "tbShto";
			this.tbShto.Size = new System.Drawing.Size(1003, 583);
			this.tbShto.TabIndex = 0;
			this.tbShto.Text = "Shto";
			// 
			// btnShtoDhome
			// 
			this.btnShtoDhome.BackColor = System.Drawing.Color.Blue;
			this.btnShtoDhome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShtoDhome.DoValidation = true;
			this.btnShtoDhome.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShtoDhome.Location = new System.Drawing.Point(412, 128);
			this.btnShtoDhome.Name = "btnShtoDhome";
			this.btnShtoDhome.Size = new System.Drawing.Size(90, 21);
			this.btnShtoDhome.TabIndex = 7;
			this.btnShtoDhome.Text = "Shto";
			this.toolTips.SetToolTip(this.btnShtoDhome, "Shton nje dhome te re me parametrat e caktuar!");
			this.btnShtoDhome.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShtoDhome.Click += new System.EventHandler(this.btnShtoDhome_Click_1);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.rbNukEshteCift);
			this.groupBox4.Controls.Add(this.rbEshteCift);
			this.groupBox4.Controls.Add(this.txtNrDhoma);
			this.groupBox4.Controls.Add(this.lblNrDhoma);
			this.groupBox4.Controls.Add(this.numShtreter);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(304, 8);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(304, 108);
			this.groupBox4.TabIndex = 34;
			this.groupBox4.Text = "Shtimi i nje dhome te re";
			this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label8
			// 
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label8.Location = new System.Drawing.Point(40, 44);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 20);
			this.label8.TabIndex = 25;
			this.label8.Text = "Dhome çift";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// rbNukEshteCift
			// 
			this.rbNukEshteCift.Location = new System.Drawing.Point(208, 44);
			this.rbNukEshteCift.Name = "rbNukEshteCift";
			this.rbNukEshteCift.Size = new System.Drawing.Size(48, 20);
			this.rbNukEshteCift.TabIndex = 5;
			this.rbNukEshteCift.Text = "Jo";
			// 
			// rbEshteCift
			// 
			this.rbEshteCift.Location = new System.Drawing.Point(124, 44);
			this.rbEshteCift.Name = "rbEshteCift";
			this.rbEshteCift.Size = new System.Drawing.Size(52, 20);
			this.rbEshteCift.TabIndex = 4;
			this.rbEshteCift.Text = "Po";
			this.rbEshteCift.CheckedChanged += new System.EventHandler(this.rbEshteCift_CheckedChanged);
			// 
			// txtNrDhoma
			// 
			this.txtNrDhoma.AutoSize = false;
			this.txtNrDhoma.DefaultErrorMessage = "Ju duhet te jepni nje emer per dhomen qe doni te shtoni!";
			this.txtNrDhoma.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtNrDhoma.FixedLength = false;
			this.txtNrDhoma.IsValid = false;
			this.txtNrDhoma.Location = new System.Drawing.Point(120, 16);
			this.txtNrDhoma.Name = "txtNrDhoma";
			this.txtNrDhoma.Required = true;
			this.txtNrDhoma.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.txtNrDhoma.Size = new System.Drawing.Size(160, 21);
			this.txtNrDhoma.TabIndex = 3;
			this.txtNrDhoma.Text = "";
			// 
			// lblNrDhoma
			// 
			this.lblNrDhoma.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblNrDhoma.Location = new System.Drawing.Point(4, 20);
			this.lblNrDhoma.Name = "lblNrDhoma";
			this.lblNrDhoma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblNrDhoma.Size = new System.Drawing.Size(108, 20);
			this.lblNrDhoma.TabIndex = 19;
			this.lblNrDhoma.Text = "Emri i  dhomes se re";
			// 
			// numShtreter
			// 
			this.numShtreter.AutoSize = false;
			this.numShtreter.DefaultErrorMessage = "Ju duhet te caktoni kapacitetin/numrin e shtreterve!";
			this.numShtreter.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numShtreter.DigitsAfterDecimalPoint = 0;
			this.numShtreter.FixedLength = false;
			this.numShtreter.IsValid = false;
			this.numShtreter.KeepFocus = false;
			this.numShtreter.Location = new System.Drawing.Point(120, 72);
			this.numShtreter.Name = "numShtreter";
			this.numShtreter.OnlyPositive = true;
			this.numShtreter.Required = true;
			this.numShtreter.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.numShtreter.Size = new System.Drawing.Size(160, 21);
			this.numShtreter.TabIndex = 6;
			this.numShtreter.Text = "";
			this.numShtreter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(20, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 20);
			this.label2.TabIndex = 21;
			this.label2.Text = "Kapaciteti";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.cmbKategoria);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.lbDhomat);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(10, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(284, 344);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.Text = "Dhomat ekzistuese";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbKategoria
			// 
			this.cmbKategoria.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategoria.DefaultErrorMessage = "Ju duhet te zgjidhni nje kategori per dhomen!";
			this.cmbKategoria.IsValid = false;
			this.cmbKategoria.Kolone1Vlere = null;
			this.cmbKategoria.Kolone2Vlere = null;
			this.cmbKategoria.Location = new System.Drawing.Point(84, 20);
			this.cmbKategoria.Name = "cmbKategoria";
			this.cmbKategoria.ReadOnly = false;
			this.cmbKategoria.Required = true;
			this.cmbKategoria.Size = new System.Drawing.Size(180, 21);
			this.cmbKategoria.SkipValidation = false;
			this.cmbKategoria.TabIndex = 1;
			this.cmbKategoria.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategoria_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(4, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 20);
			this.label1.TabIndex = 29;
			this.label1.Text = "Kategorite";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(16, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 20);
			this.label3.TabIndex = 31;
			this.label3.Text = "Dhomat";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbDhomat
			// 
			this.lbDhomat.DefaultErrorMessage = "";
			this.lbDhomat.IsValid = true;
			this.lbDhomat.Location = new System.Drawing.Point(84, 56);
			this.lbDhomat.Name = "lbDhomat";
			this.lbDhomat.Size = new System.Drawing.Size(180, 264);
			this.lbDhomat.TabIndex = 2;
			// 
			// txtCift
			// 
			this.txtCift.AutoSize = false;
			this.txtCift.DefaultErrorMessage = "";
			this.txtCift.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtCift.FixedLength = false;
			this.txtCift.IsValid = true;
			this.txtCift.Location = new System.Drawing.Point(660, 52);
			this.txtCift.Name = "txtCift";
			this.txtCift.Required = false;
			this.txtCift.RequiredControlColor = System.Drawing.Color.White;
			this.txtCift.Size = new System.Drawing.Size(24, 20);
			this.txtCift.TabIndex = 37;
			this.txtCift.Text = "Jo";
			this.txtCift.Visible = false;
			// 
			// tbModifiko
			// 
			this.tbModifiko.BackColor = System.Drawing.SystemColors.Control;
			this.tbModifiko.Controls.Add(this.label9);
			this.tbModifiko.Controls.Add(this.label4);
			this.tbModifiko.Controls.Add(this.label6);
			this.tbModifiko.Controls.Add(this.label5);
			this.tbModifiko.Controls.Add(this.btnKerko);
			this.tbModifiko.Controls.Add(this.groupBox3);
			this.tbModifiko.Controls.Add(this.groupBox2);
			this.tbModifiko.Controls.Add(this.btnEleminoDhome);
			this.tbModifiko.Controls.Add(this.btnModifikoDhome);
			this.tbModifiko.Controls.Add(this.cmbKategorite1);
			this.tbModifiko.Controls.Add(this.cmbDhomaCift);
			this.tbModifiko.Controls.Add(this.groupBox5);
			this.tbModifiko.DefaultErrorMessage = null;
			this.tbModifiko.EnableValidation = true;
			this.tbModifiko.IsValid = false;
			this.tbModifiko.Location = new System.Drawing.Point(4, 22);
			this.tbModifiko.Name = "tbModifiko";
			this.tbModifiko.Size = new System.Drawing.Size(1003, 583);
			this.tbModifiko.TabIndex = 1;
			this.tbModifiko.Text = "Modifiko/Fshi";
			// 
			// label9
			// 
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label9.Location = new System.Drawing.Point(404, 216);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(68, 16);
			this.label9.TabIndex = 32;
			this.label9.Text = "Dhome çift";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Location = new System.Drawing.Point(428, 184);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label4.Size = new System.Drawing.Size(44, 20);
			this.label4.TabIndex = 29;
			this.label4.Text = "Dhoma";
			// 
			// label6
			// 
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Location = new System.Drawing.Point(412, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 20);
			this.label6.TabIndex = 26;
			this.label6.Text = "Kategoria";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(408, 244);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 20);
			this.label5.TabIndex = 24;
			this.label5.Text = "Kapaciteti";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnKerko
			// 
			this.btnKerko.BackColor = System.Drawing.Color.Blue;
			this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko.DoValidation = false;
			this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko.Location = new System.Drawing.Point(296, 56);
			this.btnKerko.Name = "btnKerko";
			this.btnKerko.Size = new System.Drawing.Size(90, 21);
			this.btnKerko.TabIndex = 13;
			this.btnKerko.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko, "Kerkon per dhomat qe plotesojne kriteret e mesiperm!");
			this.btnKerko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.numNrShtreter);
			this.groupBox3.Controls.Add(this.rbNrShtreter);
			this.groupBox3.Controls.Add(this.cmbDhomatModifikime);
			this.groupBox3.Controls.Add(this.cmbKategoriteModifikime);
			this.groupBox3.Controls.Add(this.rbDhoma);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(10, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(274, 116);
			this.groupBox3.TabIndex = 31;
			this.groupBox3.Text = "Kerkim sipas";
			this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// numNrShtreter
			// 
			this.numNrShtreter.AutoSize = false;
			this.numNrShtreter.DefaultErrorMessage = "";
			this.numNrShtreter.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numNrShtreter.DigitsAfterDecimalPoint = 0;
			this.numNrShtreter.FixedLength = false;
			this.numNrShtreter.IsValid = true;
			this.numNrShtreter.KeepFocus = false;
			this.numNrShtreter.Location = new System.Drawing.Point(92, 78);
			this.numNrShtreter.Name = "numNrShtreter";
			this.numNrShtreter.OnlyPositive = true;
			this.numNrShtreter.Required = false;
			this.numNrShtreter.RequiredControlColor = System.Drawing.Color.White;
			this.numNrShtreter.Size = new System.Drawing.Size(160, 21);
			this.numNrShtreter.TabIndex = 12;
			this.numNrShtreter.Text = "";
			this.numNrShtreter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// rbNrShtreter
			// 
			this.rbNrShtreter.Location = new System.Drawing.Point(8, 84);
			this.rbNrShtreter.Name = "rbNrShtreter";
			this.rbNrShtreter.Size = new System.Drawing.Size(84, 16);
			this.rbNrShtreter.TabIndex = 9;
			this.rbNrShtreter.Text = "Kapaciteti";
			// 
			// cmbDhomatModifikime
			// 
			this.cmbDhomatModifikime.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhomatModifikime.Controls.Add(this.comboBox1);
			this.cmbDhomatModifikime.Controls.Add(this.comboBox2);
			this.cmbDhomatModifikime.DefaultErrorMessage = "";
			this.cmbDhomatModifikime.IsValid = true;
			this.cmbDhomatModifikime.Kolone1Vlere = null;
			this.cmbDhomatModifikime.Kolone2Vlere = null;
			this.cmbDhomatModifikime.Location = new System.Drawing.Point(92, 48);
			this.cmbDhomatModifikime.Name = "cmbDhomatModifikime";
			this.cmbDhomatModifikime.ReadOnly = false;
			this.cmbDhomatModifikime.Required = false;
			this.cmbDhomatModifikime.Size = new System.Drawing.Size(160, 21);
			this.cmbDhomatModifikime.SkipValidation = true;
			this.cmbDhomatModifikime.TabIndex = 11;
			// 
			// comboBox1
			// 
			this.comboBox1.DefaultErrorMessage = null;
			this.comboBox1.IsValid = false;
			this.comboBox1.Location = new System.Drawing.Point(96, 0);
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
			this.comboBox2.Size = new System.Drawing.Size(156, 21);
			this.comboBox2.TabIndex = 0;
			// 
			// cmbKategoriteModifikime
			// 
			this.cmbKategoriteModifikime.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategoriteModifikime.Controls.Add(this.comboBox3);
			this.cmbKategoriteModifikime.Controls.Add(this.comboBox4);
			this.cmbKategoriteModifikime.DefaultErrorMessage = null;
			this.cmbKategoriteModifikime.IsValid = false;
			this.cmbKategoriteModifikime.Kolone1Vlere = null;
			this.cmbKategoriteModifikime.Kolone2Vlere = null;
			this.cmbKategoriteModifikime.Location = new System.Drawing.Point(92, 16);
			this.cmbKategoriteModifikime.Name = "cmbKategoriteModifikime";
			this.cmbKategoriteModifikime.ReadOnly = false;
			this.cmbKategoriteModifikime.Required = false;
			this.cmbKategoriteModifikime.Size = new System.Drawing.Size(160, 21);
			this.cmbKategoriteModifikime.SkipValidation = false;
			this.cmbKategoriteModifikime.TabIndex = 10;
			this.cmbKategoriteModifikime.Load += new System.EventHandler(this.cmbKategoriteModifikime_Load);
			this.cmbKategoriteModifikime.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategoriteModifikime_SelectedIndexChanged_1);
			// 
			// comboBox3
			// 
			this.comboBox3.DefaultErrorMessage = null;
			this.comboBox3.IsValid = false;
			this.comboBox3.Location = new System.Drawing.Point(96, 0);
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
			this.comboBox4.Size = new System.Drawing.Size(156, 21);
			this.comboBox4.TabIndex = 0;
			// 
			// rbDhoma
			// 
			this.rbDhoma.Location = new System.Drawing.Point(8, 20);
			this.rbDhoma.Name = "rbDhoma";
			this.rbDhoma.Size = new System.Drawing.Size(88, 16);
			this.rbDhoma.TabIndex = 8;
			this.rbDhoma.Text = "Kategorise";
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(16, 48);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 20);
			this.label10.TabIndex = 36;
			this.label10.Text = "Dhoma";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.grid);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 128);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(374, 348);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.Text = "Dhomat ne hotel";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbKategorite1
			// 
			this.cmbKategorite1.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategorite1.DefaultErrorMessage = "Zgjidhni nje prej kategorive para se te modifikoni!";
			this.cmbKategorite1.IsValid = false;
			this.cmbKategorite1.Kolone1Vlere = null;
			this.cmbKategorite1.Kolone2Vlere = null;
			this.cmbKategorite1.Location = new System.Drawing.Point(480, 148);
			this.cmbKategorite1.Name = "cmbKategorite1";
			this.cmbKategorite1.ReadOnly = false;
			this.cmbKategorite1.Required = true;
			this.cmbKategorite1.Size = new System.Drawing.Size(160, 21);
			this.cmbKategorite1.SkipValidation = false;
			this.cmbKategorite1.TabIndex = 14;
			// 
			// cmbDhomaCift
			// 
			this.cmbDhomaCift.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhomaCift.DefaultErrorMessage = "Percaktoni nqs dhoma eshte cift apo tek.";
			this.cmbDhomaCift.IsValid = false;
			this.cmbDhomaCift.Kolone1Vlere = null;
			this.cmbDhomaCift.Kolone2Vlere = null;
			this.cmbDhomaCift.Location = new System.Drawing.Point(480, 208);
			this.cmbDhomaCift.Name = "cmbDhomaCift";
			this.cmbDhomaCift.ReadOnly = false;
			this.cmbDhomaCift.Required = true;
			this.cmbDhomaCift.Size = new System.Drawing.Size(160, 21);
			this.cmbDhomaCift.SkipValidation = false;
			this.cmbDhomaCift.TabIndex = 16;
			this.cmbDhomaCift.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbDhomaCift_SelectedIndexChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.Transparent;
			this.groupBox5.Controls.Add(this.numShtreter1);
			this.groupBox5.Controls.Add(this.txtDhoma);
			this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox5.Location = new System.Drawing.Point(396, 128);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(268, 144);
			this.groupBox5.TabIndex = 35;
			this.groupBox5.Text = "Modifikimi i dhomes";
			this.groupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// numShtreter1
			// 
			this.numShtreter1.AutoSize = false;
			this.numShtreter1.DefaultErrorMessage = "Vendosni kapacitetin/numrin e shtreterve per dhomen!";
			this.numShtreter1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numShtreter1.DigitsAfterDecimalPoint = 0;
			this.numShtreter1.FixedLength = false;
			this.numShtreter1.IsValid = false;
			this.numShtreter1.KeepFocus = false;
			this.numShtreter1.Location = new System.Drawing.Point(84, 112);
			this.numShtreter1.Name = "numShtreter1";
			this.numShtreter1.OnlyPositive = true;
			this.numShtreter1.Required = true;
			this.numShtreter1.RequiredControlColor = System.Drawing.Color.LemonChiffon;
			this.numShtreter1.Size = new System.Drawing.Size(160, 21);
			this.numShtreter1.TabIndex = 17;
			this.numShtreter1.Text = "";
			this.numShtreter1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtDhoma
			// 
			this.txtDhoma.AutoSize = false;
			this.txtDhoma.DefaultErrorMessage = "Ju duhet te jepni emrin per  dhomen qe doni te modifikoni";
			this.txtDhoma.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtDhoma.FixedLength = false;
			this.txtDhoma.IsValid = false;
			this.txtDhoma.Location = new System.Drawing.Point(84, 52);
			this.txtDhoma.Name = "txtDhoma";
			this.txtDhoma.Required = true;
			this.txtDhoma.RequiredControlColor = System.Drawing.Color.White;
			this.txtDhoma.Size = new System.Drawing.Size(160, 21);
			this.txtDhoma.TabIndex = 15;
			this.txtDhoma.Text = "";
			// 
			// btnNdihme1
			// 
			this.btnNdihme1.BackColor = System.Drawing.Color.Blue;
			this.btnNdihme1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNdihme1.DoValidation = true;
			this.btnNdihme1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnNdihme1.Location = new System.Drawing.Point(548, 404);
			this.btnNdihme1.Name = "btnNdihme1";
			this.btnNdihme1.Size = new System.Drawing.Size(90, 21);
			this.btnNdihme1.TabIndex = 31;
			this.btnNdihme1.Text = "Ndihme";
			this.btnNdihme1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// Dhome
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CheckRequiredFields = true;
			this.ClientSize = new System.Drawing.Size(883, 483);
			this.Controls.Add(this.tabControl1);
			this.EnableValidation = true;
			this.HelpFile = "DHOME.htm";
			this.Name = "Dhome";
			this.Text = "Dhomat";
			this.TitullGjeresi = 1011;
			this.Load += new System.EventHandler(this.Dhome_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.tabControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tbShto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tbModifiko.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.cmbDhomatModifikime.ResumeLayout(false);
			this.cmbKategoriteModifikime.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox5)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region DhomeLoad
		private void Dhome_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				// pastrim variablash private
				this.readyToPrint = false;
				this.ds.Tables.Clear();
				idKategoria = 0;
				this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
				// pastrim variablash private
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqKategorite");
				cmbKategoriteModifikime.Kolone1.Items.Clear();
				cmbKategoriteModifikime.Kolone2.Items.Clear();
				cmbKategoria.Kolone1.Items.Clear();
				cmbKategoria.Kolone2.Items.Clear();
				cmbKategorite1.Kolone1.Items.Clear();
				cmbKategorite1.Kolone2.Items.Clear();
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbKategoria.Kolone1.Items.Add(dr[1]);
					this.cmbKategoria.Kolone2.Items.Add(dr[0]);
					this.cmbKategorite1.Kolone1.Items.Add(dr[1]);
					this.cmbKategorite1.Kolone2.Items.Add(dr[0]);
					cmbKategoriteModifikime.Kolone1.Items.Add(dr[1]);
					cmbKategoriteModifikime.Kolone2.Items.Add(dr[0]);
				}
				for (int i = 0;i<2;i++)
				{
					string strCift = "null";
					if( i == 0)
						strCift = "Jo";
					else
						strCift = "Po";
					this.cmbDhomaCift.Kolone1.Items.Add(strCift);
					this.cmbDhomaCift.Kolone2.Items.Add(i);
				}
				ds = data.KerkesaRead("ShfaqDhomat");
				grid.DataSource = ds.Tables[0];
				if (ds.Tables[0].Rows.Count <= 17)
					this.grid.Width = 330;
				else
					this.grid.Width = 346;
				this.KrijoStilGride();
				// Hidh ne Xml datasetin, i cili sherben per printimin
				ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\Dhomat.xml");
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

		private void cmbKategoriteModifikime_Load(object sender, System.EventArgs e)
		{
			try
			{
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqKategorite");
				// Percaktojme gjatesine e vektorit qe mbaje vlerat e idKategori-se
				cmbKategoriteModifikime.Kolone1.Items.Clear();
				cmbKategoriteModifikime.Kolone2.Items.Clear();
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
			}			
		}
		#endregion

		#region EventHandlers
		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				if (this.tabControl1.SelectedTab == tbModifiko)
				{
					this.Pastro(this.groupBox5);
					this.Pastro(this.groupBox3);
					this.groupBox2.Text = "Dhomat ne hotel";
					InputController data = new InputController();
					ds = data.KerkesaRead("ShfaqDhomat");
					grid.DataSource = ds.Tables[0];
					if (ds.Tables[0].Rows.Count <= 17)
						this.grid.Width = 330;
					else
						this.grid.Width = 346;
					// Kapim numrin e rreshtave qe ka grida
					int numRows = grid.BindingContext[grid.DataSource,
						grid.DataMember].Count; 
					// Nese ky numer eshte me i madh se 0 atehere print dhe printPreview duhet te behen enabled
					if (numRows >= 1)
					{
						this.ReadyToPrint = true;
					}
						// Perndryshe duhet te behen disable
					else
						this.ReadyToPrint = false;
					this.rbDhoma.Checked = false;
					this.rbNrShtreter.Checked = false;
					cmbDhomatModifikime.Kolone1.Items.Clear();
					cmbDhomatModifikime.Kolone2.Items.Clear();
				}
				else
				{
					this.cmbKategoria.Kolone1.Text = "";
					this.cmbKategoria.Kolone2.Text = "";
					this.lbDhomat.Items.Clear();
					this.Pastro(this.groupBox4);
					this.ReadyToPrint = false;
					this.rbNukEshteCift.Checked = false;
					this.rbEshteCift.Checked = false;
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

		#region ShtoDhomeMethods
		private void btnShtoDhome_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				// Kontrollojme nese aplikacioni eshte version i plote ose jo.
				// Nese eshte version demo kontrollojme nese numri i dhomave deri tani eshte 5.
				// Ne rast te kundert kontrollojme nese dhomat e ruajtura jane sa eshte numri i dhomave qe duhet
				// te futen ne program
				InputController data = new InputController();
				DataSet ds1 = data.KerkesaRead("ShfaqDhomat");
				int roomsCount = ds1.Tables[0].Rows.Count;
				if (RegistrationClass.IsDemoVersion())
				{
					if (roomsCount >= 5)
					{
						System.Windows.Forms.MessageBox.Show("Ju nuk mund te shtoni dhoma te tjera ne program." +
							Environment.NewLine + "Per te vazhduar, ju duhet te regjistroni programin", "Konfigurimi" +
							" i dhomave", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}
				else
				{
					if (roomsCount >= RegistrationClass.GetRoomsCount())
					{
						System.Windows.Forms.MessageBox.Show("Ju nuk mund te shtoni dhoma te tjera ne program." +
							Environment.NewLine + "Nese doni te shtoni dhoma te reja, duhet te regjistroni programin per nje numer me te madh dhomash", "Konfigurimi" +
							" i dhomave", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}
				int b = 0;
				string emerDhoma = this.txtNrDhoma.Text.Trim();
				int idKategoria = Convert.ToInt32(this.cmbKategoria.Kolone2Vlere);
				int numerShtreter = Convert.ToInt32(this.numShtreter.Text) ;
				if(numerShtreter == 0)
				{
					this.numShtreter.IsValid = false;
					this.error.SetError(this.numShtreter,"Ju duhet te jepni nje vlere me te madhe se zero per numrin e shtreterve!");
					return;
				}
			
				int cift = 0;
				if(this.txtCift.Text == "Po")
					cift = 1;
				b = data.KerkesaUpdate("KrijoDhome", cift,emerDhoma, idKategoria, numerShtreter );
				if (b == 0)
					System.Windows.Forms.MessageBox.Show(this,  "Dhoma u shtua!","Konfigurimi i dhomave",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				else if (b == 1)
					System.Windows.Forms.MessageBox.Show(this, "Ekziston nje dhome me kete emer."+Environment.NewLine+"Ju lutemi zgjidhni nje emer te ri.",
						"Konfigurimi i dhomave",MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.rbEshteCift.Checked = false;
				this.rbNukEshteCift.Checked = false;
				this.numShtreter.ReadOnly = false;
				this.RefreshListBox();
				this.RefreshControls();
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
				RefreshListBox();
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

		private void RefreshListBox()
		{
			this.lbDhomat.Items.Clear();
			this.txtNrDhoma.Text = "";
			this.numShtreter.Text = "";
			int idKategoria = Convert.ToInt32(this.cmbKategoria.Kolone2Vlere);
			InputController inpCon = new InputController();
			ds = inpCon.KerkesaRead("ShfaqDhomatPerKategorine", idKategoria);
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.lbDhomat.Items.Add(dr[0]);
			}
		}
	
		#endregion

		#region ModifikoDhomeMethods

		private void cmbKategoriteModifikime_SelectedIndexChanged_1(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				this.cmbDhomatModifikime.Kolone1.Text = "";
				this.cmbDhomatModifikime.Kolone1.Items.Clear();
				this.cmbDhomatModifikime.Kolone2.Items.Clear();
				idKategoria = Convert.ToInt32(this.cmbKategoriteModifikime.Kolone2Vlere);
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
			}
		}
	
		private void btnKerko_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				DataSet ds = null;
				int numer_rreshtash = 0;
				this.txtDhoma.Text = "";
				this.cmbKategorite1.Kolone1.Text = "";
				this.numShtreter1.Text = "";
				this.cmbDhomaCift.Kolone1.Text = "";
				if (this.rbNrShtreter.Checked == true)
				{
					InputController data = new InputController();
			
					if(this.numNrShtreter.Text == "")
					{
						this.numNrShtreter.IsValid = false;
						this.numNrShtreter.Required = true;
						this.error.SetError(this.numNrShtreter , "Ju duhet te jepni numrin e shtreterve ne menyre qe te kerkoni!");
						this.ReadyToPrint = false;
						return;
					}
					else
					{
						int nrShtreter = Convert.ToInt32(this.numNrShtreter.Text);
						ds = data.KerkesaRead("ShfaqCmimetPerShtreteritEdhene", nrShtreter);
						numer_rreshtash = Convert.ToInt32(ds.Tables[0].Rows.Count);
						if(numer_rreshtash == 0)
						{
							this.grid.DataSource = null;
							System.Windows.Forms.MessageBox.Show(this, "Per kapacitetin e kerkuar nuk ka dhoma te konfiguruara!",  "Konfigurimi i dhomave",
								MessageBoxButtons.OK, MessageBoxIcon.Information);
							
						}
						else
							grid.DataSource = ds.Tables[0];
						// Nese ne gride afishohen te dhena atehere print dhe printPreview duhet te jene enabled
						if (ds.Tables[0].Rows.Count > 0)
						{
							ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\Dhomat.xml");
							this.ReadyToPrint = true;
						}
						else
							this.ReadyToPrint = false;
					}
				
				}
				else if (rbDhoma.Checked == true)
				{
					int idDhoma = Convert.ToInt32(this.cmbDhomatModifikime.Kolone2Vlere);
					int idKategoria = Convert.ToInt32(this.cmbKategoriteModifikime.Kolone2Vlere);
					if(idKategoria == 0)
					{
						this.cmbKategoriteModifikime.IsValid = false;
						this.error.SetError(this.cmbKategoriteModifikime , "Ju duhet te zgjidhni kategorine e dhomave per kerkim!");
						this.ReadyToPrint = false;
					}
					else
					{
						InputController data = new InputController();
						if(this.cmbDhomatModifikime.Kolone1.Text  == "")
						{
						
							ds = data.KerkesaRead("ShfaqDhomatPerKategorineEdhene", idKategoria);
							numer_rreshtash = Convert.ToInt32(ds.Tables[0].Rows.Count);
							grid.DataSource = ds.Tables[0];
						}
						else
						{
							ds = data.KerkesaRead("ShfaqTeDhenatPerDhome", idDhoma);
							numer_rreshtash = Convert.ToInt32(ds.Tables[0].Rows.Count);
							grid.DataSource = ds.Tables[0];
						}
						if (ds.Tables[0].Rows.Count > 0)
						{
							ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\Dhomat.xml");
							this.ReadyToPrint = true;
						}
						else
							this.ReadyToPrint = false;
						
					}
				}
				if (ds.Tables[0].Rows.Count <= 17)
					this.grid.Width = 330;
				else
					this.grid.Width = 346;
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

		private void btnModifikoDhome_Click(object sender, System.EventArgs e)
		{
			try
			{
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Konfigurimi i dhomave", 
					"Jeni te sigurte qe doni ta modifikoni dhomen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result != DialogResult.Yes)
					return;
				int b =0;
				int k = 0;
				int idDhoma = Convert.ToInt32(grid[grid.CurrentRowIndex, 3]);
				string emerDhoma = this.txtDhoma.Text.Trim();
				int idKategoria = Convert.ToInt32(this.cmbKategorite1.Kolone2Vlere);
				int numerShtreter = Convert.ToInt32(this.numShtreter1.Text) ;
				InputController data = new InputController();
				DataSet dsKontroll = data.KerkesaRead("NumerKlienteshPerCdoDate", idDhoma, numerShtreter);
				if (numerShtreter < Convert.ToInt32(this.grid[grid.CurrentRowIndex,2]))
				{
					if (Convert.ToInt32(dsKontroll.Tables[0].Rows[0][0]) == 1)
					{
						string s = "Modifikimi nuk mund te kryhet!";
						s += Environment.NewLine + "Per dhomen ka dite qe ka patur me teper se " + numerShtreter + " kliente.";
						System.Windows.Forms.MessageBox.Show(this, s,"Konfigurimi i dhomave", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				k = data.KerkesaUpdate("KntGjendjeDhome",idDhoma);
				if ( k == 0)
				{
					int dhomaCift = Convert.ToInt32(this.cmbDhomaCift.Kolone2Vlere);
					b = data.KerkesaUpdate("ModifikoDhome", idDhoma, emerDhoma,dhomaCift,idKategoria, numerShtreter );
					if (b == 0)
					{
						System.Windows.Forms.MessageBox.Show(this, 
							"Dhoma e zgjedhur u modifikua!","Konfigurimi i dhomave", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.RefreshControls();
					}
					else if(b == 1)
						System.Windows.Forms.MessageBox.Show(this, 
							"Dhoma nuk mund te  modifikohet."+ Environment.NewLine +"Ne hotel ekziston nje dhome me kete emer."+
							Environment.NewLine+"Lutemi zgjidhni nje emer te ri per dhomen!", "Konfigurimi i dhomave",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if ( k == 1)
				{
					DialogResult result1 = VisionInfoSolutionLibrary.MessageBox.Show(this,  
						"Modifikimi i dhomave","Per dhomen ka ende nje rezervim ne hotel."+
						Environment.NewLine+"Jeni te sigurte qe doni ta modifikoni dhomen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result1 != DialogResult.Yes)
						return;
					if(numerShtreter < Convert.ToInt32(this.grid[grid.CurrentRowIndex,2]))
					{
						this.numShtreter1.IsValid = false;
						this.error.SetError(this.numShtreter1 , "Kur gjendja e dhomes eshte e rezervuar, ju nuk mund te zvogeloni numrin e shtreterve");
						return;
					}
					else
					{
						int dhomaCift = Convert.ToInt32(this.cmbDhomaCift.Kolone2Vlere);
						b = data.KerkesaUpdate("ModifikoDhome", idDhoma, emerDhoma,dhomaCift,idKategoria, numerShtreter );
						if (b == 0)
						{
							System.Windows.Forms.MessageBox.Show(this, 
								"Dhoma e zgjedhur u modifikua!", "Konfigurimi i dhomave", MessageBoxButtons.OK, MessageBoxIcon.Information);
							this.RefreshControls();
						}
						else if(b == 1)
							System.Windows.Forms.MessageBox.Show(this, 
								"Dhoma nuk mund te  modifikohet."+ Environment.NewLine +"Per kategorine e zgjedhur ekziston nje dhome me kete emer."+
								Environment.NewLine+"Lutemi zgjidhni nje emer te ri per dhomen, ose ndryshoni kategorine!", "Konfigurimi i dhomave",MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else if (k == 2)
				{
					DialogResult result2 = VisionInfoSolutionLibrary.MessageBox.Show(this,  
						"Konfigurimi i dhomave","Dhoma ka kliente te palarguar. Jeni te sigurte qe doni ta modifikoni dhomen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result2 != DialogResult.Yes)
						return;
					if(numerShtreter < Convert.ToInt32(this.grid[grid.CurrentRowIndex,2]))
					{
						this.numShtreter1.IsValid = false;
						this.error.SetError(this.numShtreter1 , "Kur gjendja e dhomes eshte e zene, ju nuk mund te zvogeloni numrin e shtreterve");
						return;
					}
					else
					{
						int dhomaCift = Convert.ToInt32(this.cmbDhomaCift.Kolone2Vlere);
						b = data.KerkesaUpdate("ModifikoDhome", idDhoma, emerDhoma,dhomaCift,  idKategoria, numerShtreter );
						if (b == 0)
						{
							VisionInfoSolutionLibrary.MessageBox.Show(this, "Konfigurimi i dhomave",
								"Dhoma e zgjedhur u modifikua.", MessageBoxButtons.OK, MessageBoxIcon.Information);
							this.RefreshControls();
						}
						else if(b == 1)
							System.Windows.Forms.MessageBox.Show(this, 
								"Dhoma nuk mund te  modifikohet."+ Environment.NewLine +"Emri i dhene eshte perdorur me pare, ju lutemi zgjidhni nje emer te ri!", "Konfigurimi i dhomave",MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void btnEleminoDhome_Click(object sender, System.EventArgs e)
		{
			try
			{
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Konfigurimi i dhomave",
					"Jeni te sigurte qe doni ta eleminoni dhomen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result != DialogResult.Yes)
					return;
				int b = 0;
				int idDhoma = Convert.ToInt32(grid[grid.CurrentRowIndex, 3]);
				InputController data = new InputController();
				b = data.KerkesaUpdate("FshiDhome", idDhoma);
				if (b == 0)
					System.Windows.Forms.MessageBox.Show(this,  "Dhoma u eleminua se bashku me cmimet perkatese per te!", "Konfigurimi i dhomave",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				if (b == 1)
					System.Windows.Forms.MessageBox.Show(this, "Dhoma nuk mund te eleminohet, ne hotel ka ende nje rezervim per te!", "Konfigurimi i dhomave", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				if (b == 2)
					System.Windows.Forms.MessageBox.Show(this, "Dhoma nuk mund te eleminohet, ne hotel ka kliente" + Environment.NewLine + "te larguar ose jo te vendosur ne kete dhome!" + Environment.NewLine + "Me pare duhet te eleminoni keta kliente nga hoteli!", "Konfigurimi i dhomave", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.RefreshControls();
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

		private void KrijoStilGride()
		{
			grid.DataSource = ds.Tables[0];
			grid.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			style.AlternatingBackColor = System.Drawing.Color.Bisque;
			
			DataGridTextBoxColumn dhoma = new DataGridTextBoxColumn();
			dhoma.HeaderText = "Dhoma";
			dhoma.MappingName = "DHOMA_EMRI";
			dhoma.Width = 70;
			dhoma.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			
			DataGridTextBoxColumn kategoria = new DataGridTextBoxColumn();
			kategoria.HeaderText = "Kategoria";
			kategoria.MappingName = "KAT_EMRI";
			kategoria.Width = 170;
			kategoria.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;

			DataGridTextBoxColumn nrKrevate = new DataGridTextBoxColumn();
			nrKrevate.HeaderText = "Kapaciteti";
			nrKrevate.MappingName = "NR_KREVATESH";
			nrKrevate.Width = 85;
			nrKrevate.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			
			DataGridTextBoxColumn idDhoma = new DataGridTextBoxColumn();
			idDhoma.HeaderText = "";
			idDhoma.MappingName = "ID_DHOMA";
			idDhoma.Width = 0;

			DataGridTextBoxColumn dhomaCift = new DataGridTextBoxColumn();
			dhomaCift.HeaderText = "";
			dhomaCift.MappingName = "DHOMA_CIFT";
			dhomaCift.Width = 0;
			
			DataGridTextBoxColumn idKategoria = new DataGridTextBoxColumn();
			idKategoria.HeaderText = "";
			idKategoria.MappingName = "ID_KATEGORIA";
			idKategoria.Width = 0;
			
			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{ kategoria,dhoma, nrKrevate, idDhoma,idKategoria,dhomaCift});
			grid.TableStyles.Add(style);
			grid.FlatMode = false;
			grid.Expand(-1);
		}

		private void grid_CurrentCellChanged(object sender, System.EventArgs e)
		{
			try
			{
				int rowIndex = grid.CurrentRowIndex;
				this.txtDhoma.Text = grid[rowIndex, 1].ToString();
				this.cmbKategorite1.Kolone1.Text = grid[rowIndex, 0].ToString();
				this.cmbKategorite1.Kolone1Vlere = grid[rowIndex, 0].ToString();
				this.cmbKategorite1.Kolone2Vlere = grid[rowIndex, 4].ToString();
				this.numShtreter1.Text = Convert.ToString(grid[rowIndex, 2]);
				if(Convert.ToInt32(this.grid[rowIndex,5]) == 0)
					this.cmbDhomaCift.Kolone1.Text = "Jo";
				else
					this.cmbDhomaCift.Kolone1.Text = "Po";
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

		private void rbEshteCift_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(this.rbEshteCift.Checked == true)
				{
					this.numShtreter.Text = "2";
					this.txtCift.Text = "Po";
					this.numShtreter.ReadOnly = true;
				}
				else
				{
					this.numShtreter.Text = "";
					this.numShtreter.ReadOnly = false;
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

		private void cmbDhomaCift_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				if(this.cmbDhomaCift.Kolone1.Text == "Po")
				{
					this.numShtreter1.Text = "2";
					this.numShtreter1.ReadOnly = true;
				}
				else
					this.numShtreter1.ReadOnly = false;
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


		private void RefreshControls()
		{
			DataSet ds = null;
			int numer_rreshtash = 0;
			InputController data = new InputController();
			if (this.rbNrShtreter.Checked == true)
			{
				if(this.numNrShtreter.Text == "")
				{
					this.numNrShtreter.IsValid = false;
					this.numNrShtreter.Required = true;
					this.error.SetError(this.numNrShtreter , "Ju duhet te jepni numrin e shtreterve ne menyre qe te kerkoni!");
					return;
				}
				else
				{
					int nrShtreter = Convert.ToInt32(this.numNrShtreter.Text);
					ds = data.KerkesaRead("ShfaqCmimetPerShtreteritEdhene", nrShtreter);
					numer_rreshtash = Convert.ToInt32(ds.Tables[0].Rows.Count);
					grid.DataSource = ds.Tables[0];
				}			
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
					
					if(this.cmbDhomatModifikime.Kolone1.Text  == "")
					{
						ds = data.KerkesaRead("ShfaqDhomatPerKategorineEdhene", idKategoria);
						numer_rreshtash = Convert.ToInt32(ds.Tables[0].Rows.Count);
						grid.DataSource = ds.Tables[0];								
					}
					else
					{
						ds = data.KerkesaRead("ShfaqTeDhenatPerDhome", idDhoma);
						numer_rreshtash = Convert.ToInt32(ds.Tables[0].Rows.Count);
						grid.DataSource = ds.Tables[0];
					}						
				}			
			}
			else
			{
				ds = data.KerkesaRead("ShfaqDhomat");
				grid.DataSource = ds.Tables[0];
			}
			if (ds.Tables[0].Rows.Count <= 17)
				this.grid.Width = 330;
			else
				this.grid.Width = 346;
			this.txtDhoma.Text = "";
			this.cmbKategorite1.Kolone1.Text = "";
			this.numShtreter1.Text = "";
			this.cmbDhomaCift.Kolone1.Text = "";
		}
		
		#endregion	

		#region IPrintable Members
		public void PrintPreview()
		{
			Printim print = new Printim();
			print.NgarkoRaport("Dhomat");
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
			print.Printo("Dhomat");
		}

		public event VisionInfoSolutionLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

		#endregion
	}
}

