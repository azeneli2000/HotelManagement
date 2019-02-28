using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment.Forms
{
	public class KryejShpenzim : VisionInfoSolutionLibrary.Form
	{
		#region Private Fields
		private VisionInfoSolutionLibrary.Button btnShto;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.Label label6;
		private VisionInfoSolutionLibrary.Label label7;
		private VisionInfoSolutionLibrary.NumericBox numSasia;
		private VisionInfoSolutionLibrary.TabControl tab;
		private VisionInfoSolutionLibrary.TabPageControl tbShto;
		private VisionInfoSolutionLibrary.TabPageControl tbFshi;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.RadioButton rbData;
		private VisionInfoSolutionLibrary.RadioButton rbEmri;
		private VisionInfoSolutionLibrary.Button button1;
		private VisionInfoSolutionLibrary.NumericBox numVlera;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.DateTimePicker dtpShpenzimi;
		private VisionInfoSolutionLibrary.TextBox txtShpenzimi;
		private VisionInfoSolutionLibrary.Label label4;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDataShpenzimi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDataKerkimi;
		private VisionInfoSolutionLibrary.DataGrid grid1;
		private VisionInfoSolutionLibrary.GroupBox groupBox3;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.RadioButton rbMidisDatave;
		private VisionInfoSolutionLibrary.DateTimePicker dtpNga;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDeri;
		private VisionInfoSolutionLibrary.Button btnKerko;
		private VisionInfoSolutionLibrary.Button btnModifiko;
		private VisionInfoSolutionLibrary.Button btnElemino;
		private VisionInfoSolutionLibrary.GroupBox groupBox4;
		private VisionInfoSolutionLibrary.GroupBox groupBox5;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.TextBox txtEmerShpenzimi;
		private VisionInfoSolutionLibrary.Button btnShtoLloj;
		private VisionInfoSolutionLibrary.Button btnModifikoLloj;
		private VisionInfoSolutionLibrary.TextBox txtKoment;
		private VisionInfoSolutionLibrary.Label label8;
		private VisionInfoSolutionLibrary.DoubleCombo cmbLlojet;
		private VisionInfoSolutionLibrary.Label lblEmri;
		private VisionInfoSolutionLibrary.Button btnEleminoLloj;
		private VisionInfoSolutionLibrary.DoubleListBox lbLlojet;
		private VisionInfoSolutionLibrary.Label lbl;
		private VisionInfoSolutionLibrary.DoubleCombo cmbLlojetMod;
		private VisionInfoSolutionLibrary.DoubleCombo cmbLlojetKerkim;
		private int numer_rreshtash;
		private System.Data.DataSet ds;

		#endregion

		public KryejShpenzim()
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

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnShto = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbLlojet = new VisionInfoSolutionLibrary.DoubleCombo();
			this.numSasia = new VisionInfoSolutionLibrary.NumericBox();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.dtpDataShpenzimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.txtKoment = new VisionInfoSolutionLibrary.TextBox();
			this.label7 = new VisionInfoSolutionLibrary.Label();
			this.label8 = new VisionInfoSolutionLibrary.Label();
			this.tab = new VisionInfoSolutionLibrary.TabControl();
			this.tbShto = new VisionInfoSolutionLibrary.TabPageControl();
			this.groupBox5 = new VisionInfoSolutionLibrary.GroupBox();
			this.btnEleminoLloj = new VisionInfoSolutionLibrary.Button(this.components);
			this.lblEmri = new VisionInfoSolutionLibrary.Label();
			this.lbLlojet = new VisionInfoSolutionLibrary.DoubleListBox();
			this.txtEmerShpenzimi = new VisionInfoSolutionLibrary.TextBox();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.btnShtoLloj = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifikoLloj = new VisionInfoSolutionLibrary.Button(this.components);
			this.tbFshi = new VisionInfoSolutionLibrary.TabPageControl();
			this.groupBox4 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbLlojetMod = new VisionInfoSolutionLibrary.DoubleCombo();
			this.lbl = new VisionInfoSolutionLibrary.Label();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.dtpShpenzimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.numVlera = new VisionInfoSolutionLibrary.NumericBox();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.txtShpenzimi = new VisionInfoSolutionLibrary.TextBox();
			this.btnElemino = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifiko = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnKerko = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox3 = new VisionInfoSolutionLibrary.GroupBox();
			this.grid1 = new VisionInfoSolutionLibrary.DataGrid();
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbLlojetKerkim = new VisionInfoSolutionLibrary.DoubleCombo();
			this.dtpDataKerkimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.rbData = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbEmri = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbMidisDatave = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.dtpDeri = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpNga = new VisionInfoSolutionLibrary.DateTimePicker();
			this.ds = new System.Data.DataSet();
			this.button1 = new VisionInfoSolutionLibrary.Button(this.components);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.tab.SuspendLayout();
			this.tbShto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox5)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.tbFshi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1015, 24);
			// 
			// btnShto
			// 
			this.btnShto.BackColor = System.Drawing.Color.Blue;
			this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShto.DoValidation = true;
			this.btnShto.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShto.Location = new System.Drawing.Point(296, 300);
			this.btnShto.Name = "btnShto";
			this.btnShto.Size = new System.Drawing.Size(90, 21);
			this.btnShto.TabIndex = 14;
			this.btnShto.Text = "Hidh";
			this.toolTips.SetToolTip(this.btnShto, "Hedh nje shpenzim te ri me te dhenat e percaktuara!");
			this.btnShto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.cmbLlojet);
			this.groupBox2.Controls.Add(this.numSasia);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.dtpDataShpenzimi);
			this.groupBox2.Controls.Add(this.txtKoment);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 236);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(270, 144);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.Text = "Hidh shpenzime";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbLlojet
			// 
			this.cmbLlojet.BackColor = System.Drawing.Color.Transparent;
			this.cmbLlojet.DefaultErrorMessage = "Zgjidhni nje prej llojeve per shpenzimin!";
			this.cmbLlojet.IsValid = false;
			this.cmbLlojet.Kolone1Vlere = null;
			this.cmbLlojet.Kolone2Vlere = null;
			this.cmbLlojet.Location = new System.Drawing.Point(64, 20);
			this.cmbLlojet.Name = "cmbLlojet";
			this.cmbLlojet.ReadOnly = false;
			this.cmbLlojet.Required = true;
			this.cmbLlojet.Size = new System.Drawing.Size(180, 21);
			this.cmbLlojet.SkipValidation = false;
			this.cmbLlojet.TabIndex = 10;
			// 
			// numSasia
			// 
			this.numSasia.AutoSize = false;
			this.numSasia.DefaultErrorMessage = "Ju duhet te caktoni vleren e shpenzuar!";
			this.numSasia.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numSasia.DigitsAfterDecimalPoint = 0;
			this.numSasia.FixedLength = false;
			this.numSasia.IsValid = false;
			this.numSasia.KeepFocus = false;
			this.numSasia.Location = new System.Drawing.Point(64, 80);
			this.numSasia.Name = "numSasia";
			this.numSasia.OnlyPositive = true;
			this.numSasia.Required = true;
			this.numSasia.RequiredControlColor = System.Drawing.Color.White;
			this.numSasia.Size = new System.Drawing.Size(180, 21);
			this.numSasia.TabIndex = 12;
			this.numSasia.Text = "";
			this.numSasia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(20, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Vlera";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Location = new System.Drawing.Point(20, 52);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 20);
			this.label6.TabIndex = 9;
			this.label6.Text = "Data";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDataShpenzimi
			// 
			this.dtpDataShpenzimi.BackColor = System.Drawing.Color.White;
			this.dtpDataShpenzimi.CustomFormat = "dd.MM.yyyy";
			this.dtpDataShpenzimi.DefaultErrorMessage = "";
			this.dtpDataShpenzimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDataShpenzimi.IsValid = true;
			this.dtpDataShpenzimi.Location = new System.Drawing.Point(64, 52);
			this.dtpDataShpenzimi.Name = "dtpDataShpenzimi";
			this.dtpDataShpenzimi.Required = true;
			this.dtpDataShpenzimi.ShowCheckBox = true;
			this.dtpDataShpenzimi.ShowUpDown = true;
			this.dtpDataShpenzimi.Size = new System.Drawing.Size(180, 20);
			this.dtpDataShpenzimi.TabIndex = 11;
			this.dtpDataShpenzimi.Value = new System.DateTime(2005, 7, 6, 16, 56, 0, 0);
			// 
			// txtKoment
			// 
			this.txtKoment.AutoSize = false;
			this.txtKoment.DefaultErrorMessage = "Ju duhet te hidhni nje emer per shpenzimin ose nje koment te mundshem!";
			this.txtKoment.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtKoment.FixedLength = false;
			this.txtKoment.IsValid = false;
			this.txtKoment.Location = new System.Drawing.Point(64, 112);
			this.txtKoment.Name = "txtKoment";
			this.txtKoment.Required = true;
			this.txtKoment.RequiredControlColor = System.Drawing.Color.White;
			this.txtKoment.Size = new System.Drawing.Size(180, 21);
			this.txtKoment.TabIndex = 13;
			this.txtKoment.Text = "";
			// 
			// label7
			// 
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label7.Location = new System.Drawing.Point(8, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "Lloji";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 112);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 20);
			this.label8.TabIndex = 5;
			this.label8.Text = "Koment";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tab
			// 
			this.tab.Controls.Add(this.tbShto);
			this.tab.Controls.Add(this.tbFshi);
			this.tab.Cursor = System.Windows.Forms.Cursors.Default;
			this.tab.Location = new System.Drawing.Point(0, 25);
			this.tab.Name = "tab";
			this.tab.Padding = new System.Drawing.Point(0, 0);
			this.tab.SelectedIndex = 0;
			this.tab.Size = new System.Drawing.Size(1015, 610);
			this.tab.TabIndex = 43;
			this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
			// 
			// tbShto
			// 
			this.tbShto.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbShto.Controls.Add(this.groupBox5);
			this.tbShto.Controls.Add(this.groupBox2);
			this.tbShto.Controls.Add(this.btnShto);
			this.tbShto.DefaultErrorMessage = null;
			this.tbShto.EnableValidation = true;
			this.tbShto.IsValid = false;
			this.tbShto.Location = new System.Drawing.Point(4, 22);
			this.tbShto.Name = "tbShto";
			this.tbShto.Size = new System.Drawing.Size(1007, 584);
			this.tbShto.TabIndex = 0;
			this.tbShto.Text = "Shto        ";
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.Transparent;
			this.groupBox5.Controls.Add(this.btnEleminoLloj);
			this.groupBox5.Controls.Add(this.lblEmri);
			this.groupBox5.Controls.Add(this.lbLlojet);
			this.groupBox5.Controls.Add(this.txtEmerShpenzimi);
			this.groupBox5.Controls.Add(this.label1);
			this.groupBox5.Controls.Add(this.btnShtoLloj);
			this.groupBox5.Controls.Add(this.btnModifikoLloj);
			this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox5.Location = new System.Drawing.Point(10, 8);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(438, 224);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.Text = "Konfigurimi i llojeve te shpenzimeve";
			this.groupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// btnEleminoLloj
			// 
			this.btnEleminoLloj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEleminoLloj.DoValidation = false;
			this.btnEleminoLloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEleminoLloj.Location = new System.Drawing.Point(284, 132);
			this.btnEleminoLloj.Name = "btnEleminoLloj";
			this.btnEleminoLloj.Size = new System.Drawing.Size(90, 21);
			this.btnEleminoLloj.TabIndex = 9;
			this.btnEleminoLloj.Text = "Elemino";
			this.toolTips.SetToolTip(this.btnEleminoLloj, "Eleminon llojin e shpenzimit te zgjedhur!");
			this.btnEleminoLloj.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnEleminoLloj.Click += new System.EventHandler(this.btnEleminoLloj_Click);
			// 
			// lblEmri
			// 
			this.lblEmri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblEmri.Location = new System.Drawing.Point(232, 16);
			this.lblEmri.Name = "lblEmri";
			this.lblEmri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblEmri.Size = new System.Drawing.Size(120, 16);
			this.lblEmri.TabIndex = 6;
			this.lblEmri.Text = "Emri i llojit te ri";
			this.lblEmri.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lbLlojet
			// 
			this.lbLlojet.BackColor = System.Drawing.Color.Transparent;
			this.lbLlojet.DefaultErrorMessage = null;
			this.lbLlojet.IsValid = false;
			this.lbLlojet.Kolone1Vlere = "";
			this.lbLlojet.Kolone2Vlere = "";
			this.lbLlojet.Location = new System.Drawing.Point(12, 36);
			this.lbLlojet.Name = "lbLlojet";
			this.lbLlojet.Required = false;
			this.lbLlojet.SelectionMode = System.Windows.Forms.SelectionMode.One;
			this.lbLlojet.Size = new System.Drawing.Size(204, 178);
			this.lbLlojet.SkipValidation = false;
			this.lbLlojet.TabIndex = 5;
			this.toolTips.SetToolTip(this.lbLlojet, "Zgjidhni nje prej llojeve te shpenzimit perta modifikuar!");
			this.lbLlojet.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.lbLlojet_SelectedIndexChanged);
			// 
			// txtEmerShpenzimi
			// 
			this.txtEmerShpenzimi.AutoSize = false;
			this.txtEmerShpenzimi.BackColor = System.Drawing.Color.LemonChiffon;
			this.txtEmerShpenzimi.DefaultErrorMessage = "";
			this.txtEmerShpenzimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmerShpenzimi.FixedLength = false;
			this.txtEmerShpenzimi.IsValid = true;
			this.txtEmerShpenzimi.Location = new System.Drawing.Point(232, 36);
			this.txtEmerShpenzimi.Name = "txtEmerShpenzimi";
			this.txtEmerShpenzimi.Required = false;
			this.txtEmerShpenzimi.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmerShpenzimi.Size = new System.Drawing.Size(180, 21);
			this.txtEmerShpenzimi.TabIndex = 6;
			this.txtEmerShpenzimi.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Llojet ekzistuese te shpenzimeve";
			// 
			// btnShtoLloj
			// 
			this.btnShtoLloj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShtoLloj.DoValidation = false;
			this.btnShtoLloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShtoLloj.Location = new System.Drawing.Point(284, 68);
			this.btnShtoLloj.Name = "btnShtoLloj";
			this.btnShtoLloj.Size = new System.Drawing.Size(90, 21);
			this.btnShtoLloj.TabIndex = 7;
			this.btnShtoLloj.Text = "Shto";
			this.toolTips.SetToolTip(this.btnShtoLloj, "Shton nje llojte ri shpenzimi!");
			this.btnShtoLloj.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShtoLloj.Click += new System.EventHandler(this.btnShtoLloj_Click);
			// 
			// btnModifikoLloj
			// 
			this.btnModifikoLloj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifikoLloj.DoValidation = false;
			this.btnModifikoLloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModifikoLloj.Location = new System.Drawing.Point(284, 100);
			this.btnModifikoLloj.Name = "btnModifikoLloj";
			this.btnModifikoLloj.Size = new System.Drawing.Size(90, 21);
			this.btnModifikoLloj.TabIndex = 8;
			this.btnModifikoLloj.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifikoLloj, "Modifikon llojin e shpenzimit te zgjedhur!");
			this.btnModifikoLloj.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifikoLloj.Click += new System.EventHandler(this.btnModifikoLloj_Click);
			// 
			// tbFshi
			// 
			this.tbFshi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbFshi.Controls.Add(this.groupBox4);
			this.tbFshi.Controls.Add(this.btnElemino);
			this.tbFshi.Controls.Add(this.btnModifiko);
			this.tbFshi.Controls.Add(this.btnKerko);
			this.tbFshi.Controls.Add(this.groupBox3);
			this.tbFshi.Controls.Add(this.groupBox1);
			this.tbFshi.DefaultErrorMessage = null;
			this.tbFshi.EnableValidation = true;
			this.tbFshi.IsValid = false;
			this.tbFshi.Location = new System.Drawing.Point(4, 22);
			this.tbFshi.Name = "tbFshi";
			this.tbFshi.Size = new System.Drawing.Size(1007, 584);
			this.tbFshi.TabIndex = 1;
			this.tbFshi.Text = "Modifiko/Fshi";
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.cmbLlojetMod);
			this.groupBox4.Controls.Add(this.lbl);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.dtpShpenzimi);
			this.groupBox4.Controls.Add(this.numVlera);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.txtShpenzimi);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(480, 124);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(296, 136);
			this.groupBox4.TabIndex = 55;
			this.groupBox4.Text = "Modifikimi i shpenzimit";
			this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbLlojetMod
			// 
			this.cmbLlojetMod.BackColor = System.Drawing.Color.Transparent;
			this.cmbLlojetMod.DefaultErrorMessage = "Zgjidhni nje prej llojeve te shpenzimeve!";
			this.cmbLlojetMod.IsValid = false;
			this.cmbLlojetMod.Kolone1Vlere = null;
			this.cmbLlojetMod.Kolone2Vlere = null;
			this.cmbLlojetMod.Location = new System.Drawing.Point(96, 16);
			this.cmbLlojetMod.Name = "cmbLlojetMod";
			this.cmbLlojetMod.ReadOnly = false;
			this.cmbLlojetMod.Required = true;
			this.cmbLlojetMod.Size = new System.Drawing.Size(180, 21);
			this.cmbLlojetMod.SkipValidation = false;
			this.cmbLlojetMod.TabIndex = 58;
			// 
			// lbl
			// 
			this.lbl.Location = new System.Drawing.Point(0, 16);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(88, 20);
			this.lbl.TabIndex = 6;
			this.lbl.Text = "Lloji i shpenzimit";
			this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(52, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Vlera";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpShpenzimi
			// 
			this.dtpShpenzimi.BackColor = System.Drawing.Color.White;
			this.dtpShpenzimi.CustomFormat = "dd.MM.yyyy";
			this.dtpShpenzimi.DefaultErrorMessage = "";
			this.dtpShpenzimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpShpenzimi.IsValid = false;
			this.dtpShpenzimi.Location = new System.Drawing.Point(96, 72);
			this.dtpShpenzimi.Name = "dtpShpenzimi";
			this.dtpShpenzimi.Required = true;
			this.dtpShpenzimi.ShowCheckBox = true;
			this.dtpShpenzimi.ShowUpDown = true;
			this.dtpShpenzimi.Size = new System.Drawing.Size(180, 20);
			this.dtpShpenzimi.TabIndex = 60;
			this.dtpShpenzimi.Value = new System.DateTime(2005, 7, 6, 17, 0, 0, 0);
			// 
			// numVlera
			// 
			this.numVlera.AutoSize = false;
			this.numVlera.DefaultErrorMessage = "Ju duhet te jepni nje vlere per shpenzimin e kryer!";
			this.numVlera.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numVlera.DigitsAfterDecimalPoint = 0;
			this.numVlera.FixedLength = false;
			this.numVlera.IsValid = false;
			this.numVlera.KeepFocus = false;
			this.numVlera.Location = new System.Drawing.Point(96, 100);
			this.numVlera.Name = "numVlera";
			this.numVlera.OnlyPositive = true;
			this.numVlera.Required = true;
			this.numVlera.RequiredControlColor = System.Drawing.Color.White;
			this.numVlera.Size = new System.Drawing.Size(180, 21);
			this.numVlera.TabIndex = 61;
			this.numVlera.Text = "";
			this.numVlera.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(52, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Data";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Location = new System.Drawing.Point(44, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Koment";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtShpenzimi
			// 
			this.txtShpenzimi.AutoSize = false;
			this.txtShpenzimi.BackColor = System.Drawing.SystemColors.Window;
			this.txtShpenzimi.DefaultErrorMessage = "Ju duhet te jepni nje koment ose emer per shpenzimin e kryer!";
			this.txtShpenzimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtShpenzimi.FixedLength = false;
			this.txtShpenzimi.IsValid = false;
			this.txtShpenzimi.Location = new System.Drawing.Point(96, 44);
			this.txtShpenzimi.Name = "txtShpenzimi";
			this.txtShpenzimi.Required = true;
			this.txtShpenzimi.RequiredControlColor = System.Drawing.Color.White;
			this.txtShpenzimi.Size = new System.Drawing.Size(180, 21);
			this.txtShpenzimi.TabIndex = 59;
			this.txtShpenzimi.Text = "";
			// 
			// btnElemino
			// 
			this.btnElemino.BackColor = System.Drawing.Color.Blue;
			this.btnElemino.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnElemino.DoValidation = true;
			this.btnElemino.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnElemino.Location = new System.Drawing.Point(648, 272);
			this.btnElemino.Name = "btnElemino";
			this.btnElemino.Size = new System.Drawing.Size(90, 21);
			this.btnElemino.TabIndex = 63;
			this.btnElemino.Text = "Elemino";
			this.toolTips.SetToolTip(this.btnElemino, "Eleminon shpenzimin e zgjedhur!");
			this.btnElemino.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnElemino.Click += new System.EventHandler(this.btnElemino_Click);
			// 
			// btnModifiko
			// 
			this.btnModifiko.BackColor = System.Drawing.Color.Blue;
			this.btnModifiko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifiko.DoValidation = true;
			this.btnModifiko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifiko.Location = new System.Drawing.Point(532, 272);
			this.btnModifiko.Name = "btnModifiko";
			this.btnModifiko.Size = new System.Drawing.Size(90, 21);
			this.btnModifiko.TabIndex = 62;
			this.btnModifiko.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifiko, "Modifikon shpenzimin e zgjedhur!");
			this.btnModifiko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
			// 
			// btnKerko
			// 
			this.btnKerko.BackColor = System.Drawing.Color.Blue;
			this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko.DoValidation = false;
			this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko.Location = new System.Drawing.Point(488, 52);
			this.btnKerko.Name = "btnKerko";
			this.btnKerko.Size = new System.Drawing.Size(90, 21);
			this.btnKerko.TabIndex = 57;
			this.btnKerko.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko, "Kerkon per shpenzimet qe plotesojne kriteret e caktuar!");
			this.btnKerko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.grid1);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(10, 124);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(462, 280);
			this.groupBox3.TabIndex = 51;
			this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// grid1
			// 
			this.grid1.AllowSorting = false;
			this.grid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.grid1.CanDelete = true;
			this.grid1.CaptionVisible = false;
			this.grid1.DataMember = "";
			this.grid1.GridLineColor = System.Drawing.SystemColors.ControlText;
			this.grid1.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.grid1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grid1.HideHorizontalScrollBar = false;
			this.grid1.HideVerticalScrollBar = false;
			this.grid1.Location = new System.Drawing.Point(12, 20);
			this.grid1.Name = "grid1";
			this.grid1.RowHeaderWidth = 36;
			this.grid1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
			this.grid1.Selekto = true;
			this.grid1.Size = new System.Drawing.Size(440, 244);
			this.grid1.TabIndex = 6;
			this.toolTips.SetToolTip(this.grid1, "Zgjidhni nje prej shpenzimeve per ta modifikuar!");
			this.grid1.CurrentCellChanged += new System.EventHandler(this.grid1_CurrentCellChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.cmbLlojetKerkim);
			this.groupBox1.Controls.Add(this.dtpDataKerkimi);
			this.groupBox1.Controls.Add(this.rbData);
			this.groupBox1.Controls.Add(this.rbEmri);
			this.groupBox1.Controls.Add(this.rbMidisDatave);
			this.groupBox1.Controls.Add(this.dtpDeri);
			this.groupBox1.Controls.Add(this.dtpNga);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(10, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(462, 112);
			this.groupBox1.TabIndex = 48;
			this.groupBox1.Text = "Kerko shpenzim";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbLlojetKerkim
			// 
			this.cmbLlojetKerkim.BackColor = System.Drawing.Color.Transparent;
			this.cmbLlojetKerkim.DefaultErrorMessage = null;
			this.cmbLlojetKerkim.IsValid = false;
			this.cmbLlojetKerkim.Kolone1Vlere = null;
			this.cmbLlojetKerkim.Kolone2Vlere = null;
			this.cmbLlojetKerkim.Location = new System.Drawing.Point(112, 76);
			this.cmbLlojetKerkim.Name = "cmbLlojetKerkim";
			this.cmbLlojetKerkim.ReadOnly = false;
			this.cmbLlojetKerkim.Required = false;
			this.cmbLlojetKerkim.Size = new System.Drawing.Size(160, 21);
			this.cmbLlojetKerkim.SkipValidation = false;
			this.cmbLlojetKerkim.TabIndex = 56;
			// 
			// dtpDataKerkimi
			// 
			this.dtpDataKerkimi.BackColor = System.Drawing.Color.White;
			this.dtpDataKerkimi.CustomFormat = "dd.MM.yyyy";
			this.dtpDataKerkimi.DefaultErrorMessage = "";
			this.dtpDataKerkimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDataKerkimi.IsValid = true;
			this.dtpDataKerkimi.Location = new System.Drawing.Point(112, 48);
			this.dtpDataKerkimi.Name = "dtpDataKerkimi";
			this.dtpDataKerkimi.Required = false;
			this.dtpDataKerkimi.ShowCheckBox = true;
			this.dtpDataKerkimi.ShowUpDown = true;
			this.dtpDataKerkimi.Size = new System.Drawing.Size(160, 20);
			this.dtpDataKerkimi.TabIndex = 55;
			this.dtpDataKerkimi.Value = new System.DateTime(2005, 8, 24, 17, 18, 0, 0);
			// 
			// rbData
			// 
			this.rbData.Location = new System.Drawing.Point(12, 48);
			this.rbData.Name = "rbData";
			this.rbData.Size = new System.Drawing.Size(88, 24);
			this.rbData.TabIndex = 11;
			this.rbData.Text = "Per daten";
			// 
			// rbEmri
			// 
			this.rbEmri.Location = new System.Drawing.Point(12, 76);
			this.rbEmri.Name = "rbEmri";
			this.rbEmri.Size = new System.Drawing.Size(84, 20);
			this.rbEmri.TabIndex = 11;
			this.rbEmri.Text = "Llojit";
			// 
			// rbMidisDatave
			// 
			this.rbMidisDatave.Location = new System.Drawing.Point(12, 20);
			this.rbMidisDatave.Name = "rbMidisDatave";
			this.rbMidisDatave.Size = new System.Drawing.Size(92, 24);
			this.rbMidisDatave.TabIndex = 52;
			this.rbMidisDatave.Text = "Midis datave";
			// 
			// dtpDeri
			// 
			this.dtpDeri.BackColor = System.Drawing.Color.White;
			this.dtpDeri.CustomFormat = "dd.MM.yyyy";
			this.dtpDeri.DefaultErrorMessage = "";
			this.dtpDeri.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDeri.IsValid = true;
			this.dtpDeri.Location = new System.Drawing.Point(284, 20);
			this.dtpDeri.Name = "dtpDeri";
			this.dtpDeri.Required = false;
			this.dtpDeri.ShowCheckBox = true;
			this.dtpDeri.ShowUpDown = true;
			this.dtpDeri.Size = new System.Drawing.Size(160, 20);
			this.dtpDeri.TabIndex = 54;
			this.dtpDeri.Value = new System.DateTime(2005, 8, 24, 17, 18, 0, 0);
			// 
			// dtpNga
			// 
			this.dtpNga.BackColor = System.Drawing.Color.White;
			this.dtpNga.CustomFormat = "dd.MM.yyyy";
			this.dtpNga.DefaultErrorMessage = "";
			this.dtpNga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNga.IsValid = true;
			this.dtpNga.Location = new System.Drawing.Point(112, 20);
			this.dtpNga.Name = "dtpNga";
			this.dtpNga.Required = false;
			this.dtpNga.ShowCheckBox = true;
			this.dtpNga.ShowUpDown = true;
			this.dtpNga.Size = new System.Drawing.Size(160, 20);
			this.dtpNga.TabIndex = 53;
			this.dtpNga.Value = new System.DateTime(2005, 8, 24, 17, 18, 0, 0);
			// 
			// ds
			// 
			this.ds.DataSetName = "NewDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Blue;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.DoValidation = true;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(584, 460);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 20);
			this.button1.TabIndex = 47;
			this.button1.Text = "Ndihme";
			this.button1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// KryejShpenzim
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(928, 516);
			this.Controls.Add(this.tab);
			this.HelpFile = "SHPENZIME.htm";
			this.Name = "KryejShpenzim";
			this.Text = "Kryej shpenzime";
			this.TitullGjeresi = 1015;
			this.Load += new System.EventHandler(this.KryejShpenzim_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.tab, 0);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.tab.ResumeLayout(false);
			this.tbShto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox5)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.tbFshi.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void KryejShpenzim_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{		
				//pastrim variablash private
				this.numer_rreshtash = 0;
				this.ds.Tables.Clear();
				//pastrim variablash private
				this.dtpDataShpenzimi.Value = System.DateTime.Today;
				this.dtpDataKerkimi.Value = System.DateTime.Today;
				this.dtpShpenzimi.Value =  System.DateTime.Today;
				this.dtpDeri.Value = System.DateTime.Today;
				this.dtpNga.Value = System.DateTime.Today;
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqShpenzimetPerDatenEdhene", DateTime.Now.Date);
				this.groupBox3.Text = "Shpenzimet e kryer sot";
				numer_rreshtash = ds.Tables[0].Rows.Count;
				grid1.DataSource = ds.Tables[0];
				KrijoStilGrid();
				this.MbushLlojet();
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

		private void tab_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				if (this.tab.SelectedIndex == 1)
				{
					this.Pastro(this.groupBox1);
					this.Pastro(this.groupBox4);
					InputController data = new InputController();
					ds = data.KerkesaRead("ShfaqShpenzimetPerDatenEdhene", DateTime.Now.Date);
					this.groupBox3.Text = "Shpenzimet e kryer sot";
					grid1.DataSource = ds.Tables[0];
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
			}
		}

		private void btnShto_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				int b = 0 ;
				int idLloji = Convert.ToInt32(this.cmbLlojet.Kolone2Vlere);
				DateTime dataHedhje = Convert.ToDateTime(this.dtpDataShpenzimi.Value);
				int sasia = Convert.ToInt32(this.numSasia.Text) ;
				string koment = this.txtKoment.Text;
				InputController data = new InputController();
				b = data.KerkesaUpdate("KrijoShpenzim", idLloji, dataHedhje, sasia, koment, this.PerdoruesId);
				if (b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, 
						"Hedhja e shpenzimit u krye me sukses!","Hedhje shpenzimesh", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if ((this.rbData.Checked == true )||(this.rbEmri.Checked == true)||(this.rbMidisDatave.Checked == true))
						this.btnKerko_Click(sender, e);
					else
					{
						ds = data.KerkesaRead("ShfaqShpenzimetPerDatenEdhene", DateTime.Now.Date);
						this.groupBox3.Text = "Shpenzimet e kryer sot";
						this.grid1.DataSource = ds.Tables[0];
					}

					this.txtKoment.Text = "";
					this.dtpDataShpenzimi.Value = System.DateTime.Today;
					this.numSasia.Text = "";
					this.cmbLlojet.Kolone1.Text = "";
					this.cmbLlojet.Kolone2.Text = "";
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, "Shpenzimi nuk u hodh! Provoni perseri", "Hedhja e shpenzimeve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
				DataSet ds = null;
				string koment = "";
				InputController data = new InputController();
				if (rbData.Checked == true)
				{
					DateTime dataKerkimi = Convert.ToDateTime(this.dtpDataKerkimi.Value);
					koment = "Shpenzimet ne daten " + this.konvertoshkurt(dataKerkimi);
					ds = data.KerkesaRead("ShfaqShpenzimetPerDatenEdhene", dataKerkimi);
				}
				else if (rbEmri.Checked == true)
				{
					if (this.cmbLlojetKerkim.Kolone2Vlere == null)	
					{
						this.error.SetError(this.cmbLlojetKerkim, "Zgjidhni nje prej llojeve para se te kerkoni!");
						this.cmbLlojetKerkim.IsValid = false;
						return;
					}
					this.error.SetError(this.cmbLlojetKerkim, "");
					this.cmbLlojetKerkim.IsValid = true;

					koment = "Shpenzimet e llojit " + this.cmbLlojetKerkim.Kolone1.Text ;
					int idLloji = Convert.ToInt32(this.cmbLlojetKerkim.Kolone2Vlere);
					ds = data.KerkesaRead("ShfaqShpenzimetPerLlojinEdhene", idLloji);
				}
				else if (rbMidisDatave.Checked == true)
				{
					DateTime dataNga = Convert.ToDateTime(this.dtpNga.Value);
					DateTime dataDeri = Convert.ToDateTime(this.dtpDeri.Value);
					int a = this.KntData(dataNga, dataDeri);
					if (a != 0)
					{
						error.SetError(this.dtpNga, "Data e fillimit nuk mund te jete me e madhe se data e mbarimit");
						this.dtpNga.IsValid = false;
						return;
					}
					error.SetError(this.dtpNga, "");
					koment = "Shpenzimet nga  " + dataNga.ToShortDateString() + " deri " + dataDeri.ToShortDateString()+ ".";
					ds = data.KerkesaRead("ShfaqShpenzimetMidisDatave", dataNga, dataDeri);
				}
				else
				{
					ds = data.KerkesaRead("ShfaqShpenzimetPerDatenEdhene", DateTime.Now.Date);
					koment = "Shpenzimet e kryer sot";
				}
				this.groupBox3.Text = koment;
				if (ds.Tables[0].Rows.Count == 0)
				{
					grid1.DataSource = null;
					System.Windows.Forms.MessageBox.Show(this, "Nuk eshte kryer asnje shpenzim per kriterin e zgjedhur!", "Modifikimi i shpenzimeve", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
					grid1.DataSource = ds.Tables[0];
				numer_rreshtash = ds.Tables[0].Rows.Count;
				
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
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Fshirja e shpenzimeve",
					" Jeni te sigurt qe doni eleminoni shpenzimin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result != DialogResult.Yes)
					return;
				int b = 0 ;
				int i = this.grid1.CurrentRowIndex;
				int idShpenzimi = Convert.ToInt32(this.grid1[i, 5]);
				InputController data = new InputController();
				b = data.KerkesaUpdate("FshiShpenzim",idShpenzimi);
				if (b == 0)
				{
					this.btnKerko_Click(sender, e);
					this.txtShpenzimi.Text = "";
					this.dtpShpenzimi.Value = System.DateTime.Today;
					this.numVlera.Text = "";
					this.cmbLlojetMod.Kolone1.Text = "";
					this.cmbLlojetMod.Kolone1Vlere = "";
					this.cmbLlojetMod.Kolone2.Text = "";
					this.cmbLlojetMod.Kolone2Vlere = "";
					System.Windows.Forms.MessageBox.Show(this, 
						"Shpenzimi u eleminua!", "Modifikimi i shpenzimeve",MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, 
						"Shpenzimi nuk u eleminua!", "Modifikimi i shpenzimeve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

		private void btnModifiko_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				int b = 0 ;
				int i = this.grid1.CurrentRowIndex;
				int idShpenzimi = Convert.ToInt32(this.grid1[i, 5]);
				int idLlojShpenzimi = Convert.ToInt32(grid1[i, 6]);
				string komenti = this.txtShpenzimi.Text;
				DateTime dataShpenzimi = Convert.ToDateTime(this.dtpShpenzimi.Value);
				int vlera = Convert.ToInt32(this.numVlera.Text);
				InputController data = new InputController();
				b = data.KerkesaUpdate("ModifikoShpenzim",idShpenzimi, idLlojShpenzimi, 
					komenti, dataShpenzimi, vlera, this.PerdoruesId);
				if (b == 0)
				{
					this.btnKerko_Click(sender, e);
					this.txtShpenzimi.Text = "";
					this.dtpShpenzimi.Value = System.DateTime.Today;
					this.numVlera.Text = "";
					this.cmbLlojetMod.Kolone1.Text = "";
					this.cmbLlojetMod.Kolone1Vlere = "";
					this.cmbLlojetMod.Kolone2.Text = "";
					this.cmbLlojetMod.Kolone2Vlere = "";
					System.Windows.Forms.MessageBox.Show(this, 
						"Shpenzimi u modifikua!", "Modifikimi i shpenzimeve",MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, "Shpenzimi nuk u modifikua! Provoni perseri!",
						"Modifikimi i shpenzimeve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

		private void grid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			try
			{
				int rowIndex = grid1.CurrentRowIndex;
				if (grid1[rowIndex, 0].ToString() != "Shuma")
				{
					this.cmbLlojetMod.Kolone1.Text = grid1[rowIndex, 0].ToString();
					this.cmbLlojetMod.Kolone1Vlere = grid1[rowIndex, 0].ToString();
					this.cmbLlojetMod.Kolone2.Text = grid1[rowIndex, 6].ToString();
					this.cmbLlojetMod.Kolone2Vlere = grid1[rowIndex, 6].ToString();
					this.txtShpenzimi.Text = grid1[rowIndex, 1].ToString();
					this.dtpShpenzimi.Value = Convert.ToDateTime(grid1[rowIndex, 4].ToString());
					this.numVlera.Text = grid1[rowIndex, 3].ToString();
				}
				else
				{
					this.cmbLlojetMod.Kolone1.Text = "";
					this.cmbLlojetMod.Kolone1Vlere = "";
					this.cmbLlojetMod.Kolone2.Text = "";
					this.cmbLlojetMod.Kolone2Vlere = "";
					this.txtShpenzimi.Text = "";
					this.dtpShpenzimi.Value = System.DateTime.Today;
					this.numVlera.Text = "";
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

		private void btnShtoLloj_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				string emri =  this.txtEmerShpenzimi.Text;
				if (emri.Trim() == "")
				{
					this.error.SetError(this.txtEmerShpenzimi, "Emri i llojit te shpenzimit nuk mund te jete bosh!");
					this.txtEmerShpenzimi.IsValid = false;
					return;
				}
				this.error.SetError(this.txtEmerShpenzimi, "");
				InputController data = new InputController();
				int b = data.KerkesaUpdate("ShtoLlojShpenzimi", emri);
				if (b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Lloji i ri i shpenzimit u shtua!", "Konfigurimi i shpenzimeve", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.MbushLlojet();
					this.txtEmerShpenzimi.Text = "";
				}
				else if (b == 2)
				{
					this.error.SetError(this.txtEmerShpenzimi, "Ekziston nje lloj shpenzimi me kete emer!" + Environment.NewLine + "Caktoni nje emer tjeter!");
					this.txtEmerShpenzimi.IsValid = false;
					return;
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, "Lloji i ri i shpenzimit nuk u shtua!" + Environment.NewLine + "Provoni perseri", "Konfigurimi i shpenzimeve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

		private void btnModifikoLloj_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				string emri =  this.txtEmerShpenzimi.Text;

				if (this.lbLlojet.Kolone1.SelectedItem == null)
				{
					this.error.SetError(this.txtEmerShpenzimi, "Zgjidhni me pare nje prej llojeve te shpenzimeve" + Environment.NewLine + "ne te majte para se te modifikoni!");
					this.txtEmerShpenzimi.IsValid = false;
					return;
				}
				this.error.SetError(this.txtEmerShpenzimi, "");
				int i = this.lbLlojet.Kolone1.Items.IndexOf(this.lbLlojet.Kolone1.SelectedItem);

				if (emri.Trim() == "")
				{
					this.error.SetError(this.txtEmerShpenzimi, "Emri i llojit te shpenzimit nuk mund te jete bosh");
					this.txtEmerShpenzimi.IsValid = false;
					return;
				}
				this.error.SetError(this.txtEmerShpenzimi, "");

				InputController data = new InputController();
				string emriLloji = Convert.ToString(this.lbLlojet.Kolone1.Items[i]);
				int idLloji = Convert.ToInt32(this.lbLlojet.Kolone2.Items[i]);
				int b = data.KerkesaUpdate("ModifikoLlojShpenzimi", emri, idLloji);
				if (b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Lloji i shpenzimit u modifikua!", "Konfigurimi i shpenzimeve", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.MbushLlojet();
					this.txtEmerShpenzimi.Text = "";
				}
				else if (b == 2)
				{
					this.error.SetError(this.txtEmerShpenzimi, "Ekziston nje lloj shpenzimi me kete emer!" + Environment.NewLine + "Caktoni nje emer tjeter!");
					this.txtEmerShpenzimi.IsValid = false;
					return;
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, "Lloji i shpenzimit nuk u modifikua!" + Environment.NewLine + "Provoni perseri", "Konfigurimi i shpenzimeve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
		private void btnEleminoLloj_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				string emri =  this.txtEmerShpenzimi.Text;

				if (this.lbLlojet.Kolone1.SelectedItem == null)
				{
					this.error.SetError(this.txtEmerShpenzimi, "Zgjidhni me pare nje prej llojeve te shpenzimeve" + Environment.NewLine + "ne te majte para se te eleminoni!");
					this.txtEmerShpenzimi.IsValid = false;
					return;
				}
				this.error.SetError(this.txtEmerShpenzimi, "");
				int i = this.lbLlojet.Kolone1.Items.IndexOf(this.lbLlojet.Kolone1.SelectedItem);

				if (emri == "")
				{
					this.error.SetError(this.txtEmerShpenzimi, "Zgjidhni me pare nje prej llojeve te shpenzimeve" + Environment.NewLine + "ne te majte para se te eleminoni!");
					return;
				}
				this.error.SetError(this.txtEmerShpenzimi, "");

				InputController data = new InputController();
				int idLloji = Convert.ToInt32(this.lbLlojet.Kolone2.Items[i]);
				int b = data.KerkesaUpdate("FshiLlojShpenzimi",idLloji);
				if (b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Lloji i shpenzimit u eleminua!", "Konfigurimi i shpenzimeve", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.MbushLlojet();
					this.txtEmerShpenzimi.Text = "";
				}
				else if (b == 2)
				{
					this.error.SetError(this.txtEmerShpenzimi, "Ky lloj shpenzimi nuk mund te eleminohet" + Environment.NewLine + "pasi eshte kryer tashme nje shpenzim i ketij lloji!");
					this.txtEmerShpenzimi.IsValid = false;
					return;
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, "Lloji i shpenzimit nuk u eleminua!" + Environment.NewLine + "Provoni perseri", "Konfigurimi i shpenzimeve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
		private void lbLlojet_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				int i = this.lbLlojet.Kolone1.Items.IndexOf(this.lbLlojet.Kolone1.SelectedItem);
				this.txtEmerShpenzimi.Text = this.lbLlojet.Kolone1.Items[i].ToString();
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
		private void cbBarRes_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void cbHoteli_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		
		#endregion

		#region Private Methods
		private void KrijoStilGrid()
		{
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			this.grid1.ReadOnly = true;
			this.grid1.TableStyles.Clear();

			DataGridTextBoxColumn colEmri = new DataGridTextBoxColumn();
			colEmri.HeaderText = "Lloji";
			colEmri.MappingName = "EMRI";
			colEmri.Width = 130;
			colEmri.NullText = "";

			DataGridTextBoxColumn colKoment = new DataGridTextBoxColumn();
			colKoment.HeaderText = "Koment";
			colKoment.MappingName = "KOMENT";
			colKoment.Width = 150;
			colKoment.NullText = "";

			DataGridTextBoxColumn colDataStr = new DataGridTextBoxColumn();
			colDataStr.HeaderText = "Data";
			colDataStr.MappingName = "DATA_STR";
			colDataStr.Width = 80;
			colDataStr.NullText = "";

			DataGridTextBoxColumn colVlera = new DataGridTextBoxColumn();
			colVlera.HeaderText = "Vlera";
			colVlera.MappingName = "SASIA";
			colVlera.Width = 75;

			DataGridTextBoxColumn colData = new DataGridTextBoxColumn();
			colData.HeaderText = "Data";
			colData.MappingName = "DATA";
			colData.Width = 0;
			colData.NullText = "";

			DataGridTextBoxColumn colIdShpenzimi = new DataGridTextBoxColumn();
			colIdShpenzimi.HeaderText = "IdShpenzimi";
			colIdShpenzimi.MappingName = "ID_SHPENZIMI";
			colIdShpenzimi.Width = 0;

			DataGridTextBoxColumn colIdLlojShpenzimi = new DataGridTextBoxColumn();
			colIdLlojShpenzimi.HeaderText = "IdLlojShpenzimi";
			colIdLlojShpenzimi.MappingName = "ID_LLOJSHPENZIMI";
			colIdLlojShpenzimi.Width = 0;

			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{ colEmri,colKoment, colDataStr, colVlera, colData,colIdShpenzimi,colIdLlojShpenzimi});
			grid1.TableStyles.Add(style);
			grid1.FlatMode = false;
			grid1.Expand(-1);

		}
		
		private DateTime dekonverto(string d_str)
		{
			DateTime data;
			string dita, muaji, viti;
			dita = d_str.Substring(0, 2);
			muaji = d_str.Substring(3, 2);
			viti = d_str.Substring(6);
			d_str = viti + "-" + muaji + "-" + dita;
			data = Convert.ToDateTime(d_str);
			return data;
		}

		private int KntData(DateTime dtFillimi,DateTime dtMbarimi )
		{
			int a = 0;
			if (dtFillimi.Date >= dtMbarimi.Date)
				a = 1;	
			else
				a = 0;
			return a;	
				
		}

		private void MbushLlojet()
		{
			InputController data = new InputController(); 
			DataSet dsLloje = data.KerkesaRead("ShfaqLlojetEShpenzimeve");
			this.lbLlojet.Kolone1.Items.Clear();
			this.lbLlojet.Kolone2.Items.Clear();
			this.cmbLlojet.Kolone1.Items.Clear();
			this.cmbLlojet.Kolone2.Items.Clear();
			this.cmbLlojetKerkim.Kolone1.Items.Clear();
			this.cmbLlojetKerkim.Kolone2.Items.Clear();
			this.cmbLlojetMod.Kolone1.Items.Clear();
			this.cmbLlojetMod.Kolone2.Items.Clear();
			foreach(DataRow dr in dsLloje.Tables[0].Rows)
			{
				this.lbLlojet.Kolone1.Items.Add(dr["EMRI"]);
				this.lbLlojet.Kolone2.Items.Add(dr["ID_LLOJSHPENZIMI"]);

				this.cmbLlojet.Kolone1.Items.Add(dr["EMRI"]);
				this.cmbLlojet.Kolone2.Items.Add(dr["ID_LLOJSHPENZIMI"]);

				this.cmbLlojetKerkim.Kolone1.Items.Add(dr["EMRI"]);
				this.cmbLlojetKerkim.Kolone2.Items.Add(dr["ID_LLOJSHPENZIMI"]);

				this.cmbLlojetMod.Kolone1.Items.Add(dr["EMRI"]);
				this.cmbLlojetMod.Kolone2.Items.Add(dr["ID_LLOJSHPENZIMI"]);
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

		#endregion		

	}
}

