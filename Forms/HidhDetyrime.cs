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
	public class HidhDetyrime : VisionInfoSolutionLibrary.Form
	{
		#region PrivateVariables

		private VisionInfoSolutionLibrary.Button btnShto;
		private VisionInfoSolutionLibrary.Button btnModifiko;
		private VisionInfoSolutionLibrary.Button btnElemino;
		private VisionInfoSolutionLibrary.TabControl tab;
		private VisionInfoSolutionLibrary.TabPageControl tabShto;
		private VisionInfoSolutionLibrary.TabPageControl tabModifiko;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.GroupBox groupBox3;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.RadioButton rbDhoma;
		private VisionInfoSolutionLibrary.TextBox txtMbiemri1;
		private VisionInfoSolutionLibrary.TextBox txtEmri1;
		private VisionInfoSolutionLibrary.Label label7;
		private VisionInfoSolutionLibrary.Label lblEmr;
		private VisionInfoSolutionLibrary.RadioButton rbEmri;
		private VisionInfoSolutionLibrary.ComboBox comboBox1;
		private VisionInfoSolutionLibrary.ComboBox comboBox2;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private System.Windows.Forms.DataGridTableStyle MyStyle;
		private VisionInfoSolutionLibrary.Button btnKerko;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategorite;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhomat;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.Label label6;
		private VisionInfoSolutionLibrary.Label label11;
		private VisionInfoSolutionLibrary.Label label15;
		private VisionInfoSolutionLibrary.Label label16;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDetyrimi1;
		private VisionInfoSolutionLibrary.TextBox txtEmriModifiko;
		private VisionInfoSolutionLibrary.TextBox txtDhomaModifiko;
		private VisionInfoSolutionLibrary.NumericBox numSasi;
		private VisionInfoSolutionLibrary.DataGrid grid;
		private VisionInfoSolutionLibrary.Button btnKerko1;
		private VisionInfoSolutionLibrary.GroupBox groupBox4;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhomat1;
		private VisionInfoSolutionLibrary.ComboBox comboBox9;
		private VisionInfoSolutionLibrary.ComboBox comboBox10;
		private VisionInfoSolutionLibrary.ComboBox comboBox11;
		private VisionInfoSolutionLibrary.ComboBox comboBox12;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategorite1;
		private VisionInfoSolutionLibrary.ComboBox comboBox13;
		private VisionInfoSolutionLibrary.ComboBox comboBox14;
		private VisionInfoSolutionLibrary.TextBox txtMbiemri;
		private VisionInfoSolutionLibrary.TextBox txtEmri;
		private VisionInfoSolutionLibrary.Label label4;
		private VisionInfoSolutionLibrary.Label label9;
		private VisionInfoSolutionLibrary.RadioButton rbEmri1;
		private VisionInfoSolutionLibrary.Label label17;
		private VisionInfoSolutionLibrary.RadioButton rbDhoma1;
		private VisionInfoSolutionLibrary.GroupBox groupBox5;
		private VisionInfoSolutionLibrary.Label label8;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDetyrimi;
		private VisionInfoSolutionLibrary.NumericBox numSasiDetyrimi;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.Label lblLloji;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDetyrimet;
		private VisionInfoSolutionLibrary.ComboBox comboBox3;
		private VisionInfoSolutionLibrary.ComboBox comboBox4;
		private VisionInfoSolutionLibrary.ComboBox comboBox6;
		private VisionInfoSolutionLibrary.ComboBox comboBox15;
		private VisionInfoSolutionLibrary.GroupBox groupBox6;
		private VisionInfoSolutionLibrary.TextBox txtEmri2;
		private VisionInfoSolutionLibrary.TextBox txtDhoma;
		private VisionInfoSolutionLibrary.Label label14;
		private VisionInfoSolutionLibrary.Label label12;
		private VisionInfoSolutionLibrary.DataGrid dg;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDetyrime1;
		private VisionInfoSolutionLibrary.GroupBox groupBox7;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.Label label13;
		private VisionInfoSolutionLibrary.Label label18;
		private VisionInfoSolutionLibrary.Label label19;
		private int idDetyrimi;
		private int idKlienti;
		private int idKlienti1;

		#endregion

		#region Constructors
		public HidhDetyrime()
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
			this.btnShto = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifiko = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnElemino = new VisionInfoSolutionLibrary.Button(this.components);
			this.tab = new VisionInfoSolutionLibrary.TabControl();
			this.tabShto = new VisionInfoSolutionLibrary.TabPageControl();
			this.groupBox6 = new VisionInfoSolutionLibrary.GroupBox();
			this.txtEmri2 = new VisionInfoSolutionLibrary.TextBox();
			this.txtDhoma = new VisionInfoSolutionLibrary.TextBox();
			this.label14 = new VisionInfoSolutionLibrary.Label();
			this.label12 = new VisionInfoSolutionLibrary.Label();
			this.groupBox5 = new VisionInfoSolutionLibrary.GroupBox();
			this.label8 = new VisionInfoSolutionLibrary.Label();
			this.dtpDetyrimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.numSasiDetyrimi = new VisionInfoSolutionLibrary.NumericBox();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.lblLloji = new VisionInfoSolutionLibrary.Label();
			this.cmbDetyrimet = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox3 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox4 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox6 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox15 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.btnKerko = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox3 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbDhomat = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox1 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox2 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.cmbKategorite = new VisionInfoSolutionLibrary.DoubleCombo();
			this.txtMbiemri1 = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmri1 = new VisionInfoSolutionLibrary.TextBox();
			this.label7 = new VisionInfoSolutionLibrary.Label();
			this.lblEmr = new VisionInfoSolutionLibrary.Label();
			this.rbEmri = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.rbDhoma = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.dg = new VisionInfoSolutionLibrary.DataGrid();
			this.tabModifiko = new VisionInfoSolutionLibrary.TabPageControl();
			this.cmbDetyrime1 = new VisionInfoSolutionLibrary.DoubleCombo();
			this.btnKerko1 = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox4 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbDhomat1 = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox9 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox10 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox11 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox12 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.cmbKategorite1 = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox13 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox14 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.txtMbiemri = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.label9 = new VisionInfoSolutionLibrary.Label();
			this.rbEmri1 = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.label17 = new VisionInfoSolutionLibrary.Label();
			this.rbDhoma1 = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.grid = new VisionInfoSolutionLibrary.DataGrid();
			this.label15 = new VisionInfoSolutionLibrary.Label();
			this.label16 = new VisionInfoSolutionLibrary.Label();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.dtpDetyrimi1 = new VisionInfoSolutionLibrary.DateTimePicker();
			this.txtEmriModifiko = new VisionInfoSolutionLibrary.TextBox();
			this.txtDhomaModifiko = new VisionInfoSolutionLibrary.TextBox();
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.label11 = new VisionInfoSolutionLibrary.Label();
			this.numSasi = new VisionInfoSolutionLibrary.NumericBox();
			this.groupBox7 = new VisionInfoSolutionLibrary.GroupBox();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.label13 = new VisionInfoSolutionLibrary.Label();
			this.label18 = new VisionInfoSolutionLibrary.Label();
			this.label19 = new VisionInfoSolutionLibrary.Label();
			this.MyStyle = new System.Windows.Forms.DataGridTableStyle();
			this.tab.SuspendLayout();
			this.tabShto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox6)).BeginInit();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox5)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.cmbDetyrimet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.cmbDhomat.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.tabModifiko.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.cmbDhomat1.SuspendLayout();
			this.cmbKategorite1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox7)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1036, 25);
			// 
			// btnShto
			// 
			this.btnShto.BackColor = System.Drawing.Color.Blue;
			this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShto.DoValidation = true;
			this.btnShto.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShto.Location = new System.Drawing.Point(708, 344);
			this.btnShto.Name = "btnShto";
			this.btnShto.Size = new System.Drawing.Size(90, 21);
			this.btnShto.TabIndex = 11;
			this.btnShto.Text = "Shto";
			this.toolTips.SetToolTip(this.btnShto, "Hedh nje detyrim te ri ekstra per klientin e zgjedhur!");
			this.btnShto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
			// 
			// btnModifiko
			// 
			this.btnModifiko.BackColor = System.Drawing.Color.Blue;
			this.btnModifiko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifiko.DoValidation = true;
			this.btnModifiko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifiko.Location = new System.Drawing.Point(648, 304);
			this.btnModifiko.Name = "btnModifiko";
			this.btnModifiko.Size = new System.Drawing.Size(90, 21);
			this.btnModifiko.TabIndex = 22;
			this.btnModifiko.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifiko, "Modifikon detyrimin e zgjedhur!");
			this.btnModifiko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
			// 
			// btnElemino
			// 
			this.btnElemino.BackColor = System.Drawing.Color.Blue;
			this.btnElemino.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnElemino.DoValidation = true;
			this.btnElemino.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnElemino.Location = new System.Drawing.Point(764, 304);
			this.btnElemino.Name = "btnElemino";
			this.btnElemino.Size = new System.Drawing.Size(90, 21);
			this.btnElemino.TabIndex = 23;
			this.btnElemino.Text = "Elemino";
			this.toolTips.SetToolTip(this.btnElemino, "Eleminon detyrimin  zgjedhur!");
			this.btnElemino.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnElemino.Click += new System.EventHandler(this.btnElemino_Click);
			// 
			// tab
			// 
			this.tab.Controls.Add(this.tabShto);
			this.tab.Controls.Add(this.tabModifiko);
			this.tab.Cursor = System.Windows.Forms.Cursors.Default;
			this.tab.ItemSize = new System.Drawing.Size(24, 17);
			this.tab.Location = new System.Drawing.Point(0, 25);
			this.tab.Name = "tab";
			this.tab.Padding = new System.Drawing.Point(0, 0);
			this.tab.SelectedIndex = 0;
			this.tab.Size = new System.Drawing.Size(1011, 609);
			this.tab.TabIndex = 7;
			this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
			// 
			// tabShto
			// 
			this.tabShto.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tabShto.Controls.Add(this.groupBox6);
			this.tabShto.Controls.Add(this.groupBox5);
			this.tabShto.Controls.Add(this.btnKerko);
			this.tabShto.Controls.Add(this.groupBox3);
			this.tabShto.Controls.Add(this.groupBox1);
			this.tabShto.Controls.Add(this.btnShto);
			this.tabShto.DefaultErrorMessage = null;
			this.tabShto.EnableValidation = true;
			this.tabShto.IsValid = false;
			this.tabShto.Location = new System.Drawing.Point(4, 21);
			this.tabShto.Name = "tabShto";
			this.tabShto.Size = new System.Drawing.Size(1003, 584);
			this.tabShto.TabIndex = 0;
			this.tabShto.Text = "Hidh";
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.Color.Transparent;
			this.groupBox6.Controls.Add(this.txtEmri2);
			this.groupBox6.Controls.Add(this.txtDhoma);
			this.groupBox6.Controls.Add(this.label14);
			this.groupBox6.Controls.Add(this.label12);
			this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox6.Location = new System.Drawing.Point(584, 128);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(304, 80);
			this.groupBox6.TabIndex = 69;
			this.groupBox6.Text = "Klienti";
			this.groupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// txtEmri2
			// 
			this.txtEmri2.AutoSize = false;
			this.txtEmri2.DefaultErrorMessage = "Zgjidhni nje prej klienteve ne te majte!";
			this.txtEmri2.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri2.FixedLength = false;
			this.txtEmri2.IsValid = false;
			this.txtEmri2.Location = new System.Drawing.Point(104, 16);
			this.txtEmri2.Name = "txtEmri2";
			this.txtEmri2.ReadOnly = true;
			this.txtEmri2.Required = true;
			this.txtEmri2.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri2.Size = new System.Drawing.Size(180, 21);
			this.txtEmri2.TabIndex = 6;
			this.txtEmri2.Text = "";
			// 
			// txtDhoma
			// 
			this.txtDhoma.AutoSize = false;
			this.txtDhoma.DefaultErrorMessage = "";
			this.txtDhoma.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtDhoma.FixedLength = false;
			this.txtDhoma.IsValid = false;
			this.txtDhoma.Location = new System.Drawing.Point(104, 44);
			this.txtDhoma.Name = "txtDhoma";
			this.txtDhoma.ReadOnly = true;
			this.txtDhoma.Required = true;
			this.txtDhoma.RequiredControlColor = System.Drawing.Color.White;
			this.txtDhoma.Size = new System.Drawing.Size(180, 21);
			this.txtDhoma.TabIndex = 7;
			this.txtDhoma.Text = "";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label14.Location = new System.Drawing.Point(52, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(44, 20);
			this.label14.TabIndex = 65;
			this.label14.Text = "Klienti";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label12.Location = new System.Drawing.Point(48, 44);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 20);
			this.label12.TabIndex = 63;
			this.label12.Text = "Dhoma";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.Transparent;
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Controls.Add(this.dtpDetyrimi);
			this.groupBox5.Controls.Add(this.numSasiDetyrimi);
			this.groupBox5.Controls.Add(this.label2);
			this.groupBox5.Controls.Add(this.lblLloji);
			this.groupBox5.Controls.Add(this.cmbDetyrimet);
			this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox5.Location = new System.Drawing.Point(584, 212);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(304, 120);
			this.groupBox5.TabIndex = 68;
			this.groupBox5.Text = "Shto detyrim";
			this.groupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label8.Location = new System.Drawing.Point(8, 28);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 20);
			this.label8.TabIndex = 73;
			this.label8.Text = "Data e detyrimit";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDetyrimi
			// 
			this.dtpDetyrimi.BackColor = System.Drawing.Color.White;
			this.dtpDetyrimi.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpDetyrimi.DefaultErrorMessage = "";
			this.dtpDetyrimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDetyrimi.IsValid = true;
			this.dtpDetyrimi.Location = new System.Drawing.Point(104, 28);
			this.dtpDetyrimi.Name = "dtpDetyrimi";
			this.dtpDetyrimi.Required = true;
			this.dtpDetyrimi.ShowCheckBox = true;
			this.dtpDetyrimi.ShowUpDown = true;
			this.dtpDetyrimi.Size = new System.Drawing.Size(180, 20);
			this.dtpDetyrimi.TabIndex = 8;
			this.dtpDetyrimi.Value = new System.DateTime(2005, 8, 30, 18, 35, 0, 0);
			// 
			// numSasiDetyrimi
			// 
			this.numSasiDetyrimi.AutoSize = false;
			this.numSasiDetyrimi.DefaultErrorMessage = "Ju duhet te caktoni sasine para se te hidhni nje detyrim!";
			this.numSasiDetyrimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numSasiDetyrimi.DigitsAfterDecimalPoint = 0;
			this.numSasiDetyrimi.FixedLength = false;
			this.numSasiDetyrimi.IsValid = false;
			this.numSasiDetyrimi.KeepFocus = false;
			this.numSasiDetyrimi.Location = new System.Drawing.Point(104, 84);
			this.numSasiDetyrimi.Name = "numSasiDetyrimi";
			this.numSasiDetyrimi.OnlyPositive = true;
			this.numSasiDetyrimi.Required = true;
			this.numSasiDetyrimi.RequiredControlColor = System.Drawing.Color.White;
			this.numSasiDetyrimi.Size = new System.Drawing.Size(180, 21);
			this.numSasiDetyrimi.TabIndex = 10;
			this.numSasiDetyrimi.Text = "";
			this.numSasiDetyrimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(40, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 20);
			this.label2.TabIndex = 70;
			this.label2.Text = "Sasia";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblLloji
			// 
			this.lblLloji.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lblLloji.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblLloji.Location = new System.Drawing.Point(8, 56);
			this.lblLloji.Name = "lblLloji";
			this.lblLloji.Size = new System.Drawing.Size(88, 20);
			this.lblLloji.TabIndex = 69;
			this.lblLloji.Text = "Lloji i detyrimit";
			this.lblLloji.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbDetyrimet
			// 
			this.cmbDetyrimet.BackColor = System.Drawing.Color.Transparent;
			this.cmbDetyrimet.Controls.Add(this.comboBox3);
			this.cmbDetyrimet.Controls.Add(this.comboBox4);
			this.cmbDetyrimet.Controls.Add(this.comboBox6);
			this.cmbDetyrimet.Controls.Add(this.comboBox15);
			this.cmbDetyrimet.DefaultErrorMessage = "Zgjidhni nje prej llojeve te detyrimeve!";
			this.cmbDetyrimet.IsValid = false;
			this.cmbDetyrimet.Kolone1Vlere = null;
			this.cmbDetyrimet.Kolone2Vlere = null;
			this.cmbDetyrimet.Location = new System.Drawing.Point(104, 56);
			this.cmbDetyrimet.Name = "cmbDetyrimet";
			this.cmbDetyrimet.ReadOnly = false;
			this.cmbDetyrimet.Required = true;
			this.cmbDetyrimet.Size = new System.Drawing.Size(180, 21);
			this.cmbDetyrimet.SkipValidation = false;
			this.cmbDetyrimet.TabIndex = 9;
			// 
			// comboBox3
			// 
			this.comboBox3.DefaultErrorMessage = null;
			this.comboBox3.IsValid = false;
			this.comboBox3.Location = new System.Drawing.Point(76, 0);
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
			this.comboBox4.Size = new System.Drawing.Size(188, 21);
			this.comboBox4.TabIndex = 0;
			// 
			// comboBox6
			// 
			this.comboBox6.DefaultErrorMessage = null;
			this.comboBox6.IsValid = false;
			this.comboBox6.Location = new System.Drawing.Point(644, 0);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Required = false;
			this.comboBox6.Size = new System.Drawing.Size(16, 21);
			this.comboBox6.TabIndex = 1;
			this.comboBox6.Visible = false;
			// 
			// comboBox15
			// 
			this.comboBox15.DefaultErrorMessage = null;
			this.comboBox15.IsValid = false;
			this.comboBox15.Location = new System.Drawing.Point(0, 0);
			this.comboBox15.Name = "comboBox15";
			this.comboBox15.Required = false;
			this.comboBox15.Size = new System.Drawing.Size(152, 21);
			this.comboBox15.TabIndex = 0;
			// 
			// btnKerko
			// 
			this.btnKerko.BackColor = System.Drawing.Color.Blue;
			this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko.DoValidation = false;
			this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko.Location = new System.Drawing.Point(476, 56);
			this.btnKerko.Name = "btnKerko";
			this.btnKerko.Size = new System.Drawing.Size(90, 21);
			this.btnKerko.TabIndex = 5;
			this.btnKerko.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko, "Kerkon per klientet ne hotel qe plotesojne kriteret\r\n e caktuar dhe detyrimet e t" +
				"yre ekstra!");
			this.btnKerko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.cmbDhomat);
			this.groupBox3.Controls.Add(this.cmbKategorite);
			this.groupBox3.Controls.Add(this.txtMbiemri1);
			this.groupBox3.Controls.Add(this.txtEmri1);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.lblEmr);
			this.groupBox3.Controls.Add(this.rbEmri);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.rbDhoma);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(10, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(454, 112);
			this.groupBox3.TabIndex = 20;
			this.groupBox3.Text = "Kerkoni per klientin qe do t\'i hidhni detyrime ";
			this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbDhomat
			// 
			this.cmbDhomat.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhomat.Controls.Add(this.comboBox1);
			this.cmbDhomat.Controls.Add(this.comboBox2);
			this.cmbDhomat.DefaultErrorMessage = null;
			this.cmbDhomat.IsValid = false;
			this.cmbDhomat.Kolone1Vlere = null;
			this.cmbDhomat.Kolone2Vlere = null;
			this.cmbDhomat.Location = new System.Drawing.Point(104, 44);
			this.cmbDhomat.Name = "cmbDhomat";
			this.cmbDhomat.ReadOnly = false;
			this.cmbDhomat.Required = false;
			this.cmbDhomat.Size = new System.Drawing.Size(160, 22);
			this.cmbDhomat.SkipValidation = false;
			this.cmbDhomat.TabIndex = 2;
			// 
			// comboBox1
			// 
			this.comboBox1.DefaultErrorMessage = null;
			this.comboBox1.IsValid = false;
			this.comboBox1.Location = new System.Drawing.Point(80, 0);
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
			this.comboBox2.Size = new System.Drawing.Size(152, 21);
			this.comboBox2.TabIndex = 0;
			// 
			// cmbKategorite
			// 
			this.cmbKategorite.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategorite.DefaultErrorMessage = null;
			this.cmbKategorite.IsValid = false;
			this.cmbKategorite.Kolone1Vlere = null;
			this.cmbKategorite.Kolone2Vlere = null;
			this.cmbKategorite.Location = new System.Drawing.Point(104, 16);
			this.cmbKategorite.Name = "cmbKategorite";
			this.cmbKategorite.ReadOnly = false;
			this.cmbKategorite.Required = false;
			this.cmbKategorite.Size = new System.Drawing.Size(160, 22);
			this.cmbKategorite.SkipValidation = false;
			this.cmbKategorite.TabIndex = 1;
			this.cmbKategorite.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategorite_SelectedIndexChanged);
			// 
			// txtMbiemri1
			// 
			this.txtMbiemri1.AutoSize = false;
			this.txtMbiemri1.DefaultErrorMessage = "Ju duhet te jepni emrin dhe mbiemrin per kerkim!";
			this.txtMbiemri1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemri1.FixedLength = false;
			this.txtMbiemri1.IsValid = false;
			this.txtMbiemri1.Location = new System.Drawing.Point(280, 80);
			this.txtMbiemri1.Name = "txtMbiemri1";
			this.txtMbiemri1.Required = false;
			this.txtMbiemri1.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemri1.Size = new System.Drawing.Size(152, 20);
			this.txtMbiemri1.TabIndex = 4;
			this.txtMbiemri1.Text = "";
			// 
			// txtEmri1
			// 
			this.txtEmri1.AutoSize = false;
			this.txtEmri1.DefaultErrorMessage = "";
			this.txtEmri1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri1.FixedLength = false;
			this.txtEmri1.IsValid = false;
			this.txtEmri1.Location = new System.Drawing.Point(104, 80);
			this.txtEmri1.Name = "txtEmri1";
			this.txtEmri1.Required = false;
			this.txtEmri1.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri1.Size = new System.Drawing.Size(160, 20);
			this.txtEmri1.TabIndex = 3;
			this.txtEmri1.Text = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label7.Location = new System.Drawing.Point(280, 66);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 15);
			this.label7.TabIndex = 58;
			this.label7.Text = "Mbiemri";
			// 
			// lblEmr
			// 
			this.lblEmr.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lblEmr.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmr.Location = new System.Drawing.Point(104, 66);
			this.lblEmr.Name = "lblEmr";
			this.lblEmr.Size = new System.Drawing.Size(60, 16);
			this.lblEmr.TabIndex = 57;
			this.lblEmr.Text = "Emri";
			// 
			// rbEmri
			// 
			this.rbEmri.Location = new System.Drawing.Point(12, 76);
			this.rbEmri.Name = "rbEmri";
			this.rbEmri.Size = new System.Drawing.Size(64, 24);
			this.rbEmri.TabIndex = 61;
			this.rbEmri.Text = "Emrit";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(16, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "          Dhoma";
			// 
			// rbDhoma
			// 
			this.rbDhoma.Location = new System.Drawing.Point(12, 16);
			this.rbDhoma.Name = "rbDhoma";
			this.rbDhoma.Size = new System.Drawing.Size(76, 24);
			this.rbDhoma.TabIndex = 3;
			this.rbDhoma.Text = "Kategorise";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dg);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(10, 128);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(562, 344);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.Text = "Klietet qe jane ne hotel dhe detyrimet ekzistuese te tyre";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// dg
			// 
			this.dg.AllowSorting = false;
			this.dg.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dg.CanDelete = true;
			this.dg.CaptionVisible = false;
			this.dg.DataMember = "";
			this.dg.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.dg.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg.HideHorizontalScrollBar = false;
			this.dg.HideVerticalScrollBar = false;
			this.dg.Location = new System.Drawing.Point(12, 20);
			this.dg.Name = "dg";
			this.dg.RowHeaderWidth = 20;
			this.dg.Selekto = true;
			this.dg.Size = new System.Drawing.Size(520, 310);
			this.dg.TabIndex = 51;
			this.toolTips.SetToolTip(this.dg, "Zgjidhni nje prej klienteve per t\'i hedhur nje detyrim ekstra!");
			this.dg.CurrentCellChanged += new System.EventHandler(this.dg_CurrentCellChanged);
			// 
			// tabModifiko
			// 
			this.tabModifiko.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tabModifiko.Controls.Add(this.cmbDetyrime1);
			this.tabModifiko.Controls.Add(this.btnKerko1);
			this.tabModifiko.Controls.Add(this.groupBox4);
			this.tabModifiko.Controls.Add(this.groupBox2);
			this.tabModifiko.Controls.Add(this.btnModifiko);
			this.tabModifiko.Controls.Add(this.btnElemino);
			this.tabModifiko.Controls.Add(this.label15);
			this.tabModifiko.Controls.Add(this.label16);
			this.tabModifiko.Controls.Add(this.label5);
			this.tabModifiko.Controls.Add(this.dtpDetyrimi1);
			this.tabModifiko.Controls.Add(this.txtEmriModifiko);
			this.tabModifiko.Controls.Add(this.txtDhomaModifiko);
			this.tabModifiko.Controls.Add(this.label6);
			this.tabModifiko.Controls.Add(this.label11);
			this.tabModifiko.Controls.Add(this.numSasi);
			this.tabModifiko.Controls.Add(this.groupBox7);
			this.tabModifiko.Controls.Add(this.label3);
			this.tabModifiko.Controls.Add(this.label13);
			this.tabModifiko.Controls.Add(this.label18);
			this.tabModifiko.Controls.Add(this.label19);
			this.tabModifiko.DefaultErrorMessage = null;
			this.tabModifiko.EnableValidation = true;
			this.tabModifiko.IsValid = false;
			this.tabModifiko.Location = new System.Drawing.Point(4, 21);
			this.tabModifiko.Name = "tabModifiko";
			this.tabModifiko.Size = new System.Drawing.Size(1003, 584);
			this.tabModifiko.TabIndex = 1;
			this.tabModifiko.Text = "Modifiko/Elemino";
			// 
			// cmbDetyrime1
			// 
			this.cmbDetyrime1.BackColor = System.Drawing.Color.Transparent;
			this.cmbDetyrime1.DefaultErrorMessage = "Zgjidhni nje prej llojeve te detyrimeve!";
			this.cmbDetyrime1.IsValid = false;
			this.cmbDetyrime1.Kolone1Vlere = null;
			this.cmbDetyrime1.Kolone2Vlere = null;
			this.cmbDetyrime1.Location = new System.Drawing.Point(692, 228);
			this.cmbDetyrime1.Name = "cmbDetyrime1";
			this.cmbDetyrime1.ReadOnly = false;
			this.cmbDetyrime1.Required = true;
			this.cmbDetyrime1.Size = new System.Drawing.Size(180, 21);
			this.cmbDetyrime1.SkipValidation = false;
			this.cmbDetyrime1.TabIndex = 20;
			// 
			// btnKerko1
			// 
			this.btnKerko1.BackColor = System.Drawing.Color.Blue;
			this.btnKerko1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko1.DoValidation = false;
			this.btnKerko1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko1.Location = new System.Drawing.Point(476, 56);
			this.btnKerko1.Name = "btnKerko1";
			this.btnKerko1.Size = new System.Drawing.Size(90, 21);
			this.btnKerko1.TabIndex = 16;
			this.btnKerko1.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko1, "Kerkon per klientet ne hotel qe plotesojne kriteret\r\n e caktuar dhe detyrimet e t" +
				"yre ekstra!");
			this.btnKerko1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko1.Click += new System.EventHandler(this.btnKerko1_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.cmbDhomat1);
			this.groupBox4.Controls.Add(this.cmbKategorite1);
			this.groupBox4.Controls.Add(this.txtMbiemri);
			this.groupBox4.Controls.Add(this.txtEmri);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.rbEmri1);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.rbDhoma1);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(10, 8);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(454, 112);
			this.groupBox4.TabIndex = 66;
			this.groupBox4.Text = "Kerkim sipas";
			this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbDhomat1
			// 
			this.cmbDhomat1.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhomat1.Controls.Add(this.comboBox9);
			this.cmbDhomat1.Controls.Add(this.comboBox10);
			this.cmbDhomat1.Controls.Add(this.comboBox11);
			this.cmbDhomat1.Controls.Add(this.comboBox12);
			this.cmbDhomat1.DefaultErrorMessage = null;
			this.cmbDhomat1.IsValid = false;
			this.cmbDhomat1.Kolone1Vlere = null;
			this.cmbDhomat1.Kolone2Vlere = null;
			this.cmbDhomat1.Location = new System.Drawing.Point(104, 44);
			this.cmbDhomat1.Name = "cmbDhomat1";
			this.cmbDhomat1.ReadOnly = false;
			this.cmbDhomat1.Required = false;
			this.cmbDhomat1.Size = new System.Drawing.Size(160, 22);
			this.cmbDhomat1.SkipValidation = false;
			this.cmbDhomat1.TabIndex = 13;
			// 
			// comboBox9
			// 
			this.comboBox9.DefaultErrorMessage = null;
			this.comboBox9.IsValid = false;
			this.comboBox9.Location = new System.Drawing.Point(80, 0);
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
			this.comboBox10.Size = new System.Drawing.Size(152, 21);
			this.comboBox10.TabIndex = 0;
			// 
			// comboBox11
			// 
			this.comboBox11.DefaultErrorMessage = null;
			this.comboBox11.IsValid = false;
			this.comboBox11.Location = new System.Drawing.Point(80, 0);
			this.comboBox11.Name = "comboBox11";
			this.comboBox11.Required = false;
			this.comboBox11.Size = new System.Drawing.Size(16, 21);
			this.comboBox11.TabIndex = 1;
			this.comboBox11.Visible = false;
			// 
			// comboBox12
			// 
			this.comboBox12.DefaultErrorMessage = null;
			this.comboBox12.IsValid = false;
			this.comboBox12.Location = new System.Drawing.Point(0, 0);
			this.comboBox12.Name = "comboBox12";
			this.comboBox12.Required = false;
			this.comboBox12.Size = new System.Drawing.Size(152, 21);
			this.comboBox12.TabIndex = 0;
			// 
			// cmbKategorite1
			// 
			this.cmbKategorite1.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategorite1.Controls.Add(this.comboBox13);
			this.cmbKategorite1.Controls.Add(this.comboBox14);
			this.cmbKategorite1.DefaultErrorMessage = null;
			this.cmbKategorite1.IsValid = false;
			this.cmbKategorite1.Kolone1Vlere = null;
			this.cmbKategorite1.Kolone2Vlere = null;
			this.cmbKategorite1.Location = new System.Drawing.Point(104, 16);
			this.cmbKategorite1.Name = "cmbKategorite1";
			this.cmbKategorite1.ReadOnly = false;
			this.cmbKategorite1.Required = false;
			this.cmbKategorite1.Size = new System.Drawing.Size(160, 22);
			this.cmbKategorite1.SkipValidation = false;
			this.cmbKategorite1.TabIndex = 12;
			this.cmbKategorite1.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategorite1_SelectedIndexChanged);
			// 
			// comboBox13
			// 
			this.comboBox13.DefaultErrorMessage = null;
			this.comboBox13.IsValid = false;
			this.comboBox13.Location = new System.Drawing.Point(80, 0);
			this.comboBox13.Name = "comboBox13";
			this.comboBox13.Required = false;
			this.comboBox13.Size = new System.Drawing.Size(16, 21);
			this.comboBox13.TabIndex = 1;
			this.comboBox13.Visible = false;
			// 
			// comboBox14
			// 
			this.comboBox14.DefaultErrorMessage = null;
			this.comboBox14.IsValid = false;
			this.comboBox14.Location = new System.Drawing.Point(0, 0);
			this.comboBox14.Name = "comboBox14";
			this.comboBox14.Required = false;
			this.comboBox14.Size = new System.Drawing.Size(152, 21);
			this.comboBox14.TabIndex = 0;
			// 
			// txtMbiemri
			// 
			this.txtMbiemri.AutoSize = false;
			this.txtMbiemri.DefaultErrorMessage = "Ju duhet te jepni emrin dhe mbiemrin per kerkim!";
			this.txtMbiemri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemri.FixedLength = false;
			this.txtMbiemri.IsValid = false;
			this.txtMbiemri.Location = new System.Drawing.Point(280, 80);
			this.txtMbiemri.Name = "txtMbiemri";
			this.txtMbiemri.Required = false;
			this.txtMbiemri.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemri.Size = new System.Drawing.Size(152, 20);
			this.txtMbiemri.TabIndex = 15;
			this.txtMbiemri.Text = "";
			// 
			// txtEmri
			// 
			this.txtEmri.AutoSize = false;
			this.txtEmri.DefaultErrorMessage = "";
			this.txtEmri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri.FixedLength = false;
			this.txtEmri.IsValid = false;
			this.txtEmri.Location = new System.Drawing.Point(104, 80);
			this.txtEmri.Name = "txtEmri";
			this.txtEmri.Required = false;
			this.txtEmri.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri.Size = new System.Drawing.Size(160, 20);
			this.txtEmri.TabIndex = 14;
			this.txtEmri.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Location = new System.Drawing.Point(280, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 12);
			this.label4.TabIndex = 58;
			this.label4.Text = "Mbiemri";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label9.Location = new System.Drawing.Point(104, 66);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 12);
			this.label9.TabIndex = 57;
			this.label9.Text = "Emri";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// rbEmri1
			// 
			this.rbEmri1.Location = new System.Drawing.Point(12, 76);
			this.rbEmri1.Name = "rbEmri1";
			this.rbEmri1.Size = new System.Drawing.Size(64, 24);
			this.rbEmri1.TabIndex = 61;
			this.rbEmri1.Text = "Emrit";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label17.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label17.Location = new System.Drawing.Point(16, 48);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(72, 20);
			this.label17.TabIndex = 7;
			this.label17.Text = "          Dhoma";
			// 
			// rbDhoma1
			// 
			this.rbDhoma1.Location = new System.Drawing.Point(12, 16);
			this.rbDhoma1.Name = "rbDhoma1";
			this.rbDhoma1.Size = new System.Drawing.Size(76, 24);
			this.rbDhoma1.TabIndex = 3;
			this.rbDhoma1.Text = "Kategorise";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.grid);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 128);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(562, 344);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.Text = "Detyrimet per klientet qe jane ne hotel";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// grid
			// 
			this.grid.AllowSorting = false;
			this.grid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
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
			this.grid.Size = new System.Drawing.Size(520, 310);
			this.grid.TabIndex = 81;
			this.toolTips.SetToolTip(this.grid, "Zgjidhni nje prej detyrimeve per ta modifikuar ose eleminuar!");
			this.grid.CurrentCellChanged += new System.EventHandler(this.grid_CurrentCellChanged_1);
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label15.Location = new System.Drawing.Point(612, 256);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(72, 20);
			this.label15.TabIndex = 71;
			this.label15.Text = "Sasia";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label16.Location = new System.Drawing.Point(596, 228);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(88, 20);
			this.label16.TabIndex = 70;
			this.label16.Text = "Lloji i detyrimit";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(596, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 20);
			this.label5.TabIndex = 80;
			this.label5.Text = "Data e detyrimit";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDetyrimi1
			// 
			this.dtpDetyrimi1.BackColor = System.Drawing.Color.White;
			this.dtpDetyrimi1.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpDetyrimi1.DefaultErrorMessage = "";
			this.dtpDetyrimi1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDetyrimi1.IsValid = true;
			this.dtpDetyrimi1.Location = new System.Drawing.Point(692, 200);
			this.dtpDetyrimi1.Name = "dtpDetyrimi1";
			this.dtpDetyrimi1.Required = true;
			this.dtpDetyrimi1.ShowCheckBox = true;
			this.dtpDetyrimi1.ShowUpDown = true;
			this.dtpDetyrimi1.Size = new System.Drawing.Size(180, 20);
			this.dtpDetyrimi1.TabIndex = 19;
			this.dtpDetyrimi1.Value = new System.DateTime(2005, 8, 30, 18, 35, 0, 0);
			// 
			// txtEmriModifiko
			// 
			this.txtEmriModifiko.AutoSize = false;
			this.txtEmriModifiko.DefaultErrorMessage = "Zgjidhni me pare nje prej detyrimeve ne te majte!";
			this.txtEmriModifiko.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmriModifiko.FixedLength = false;
			this.txtEmriModifiko.IsValid = false;
			this.txtEmriModifiko.Location = new System.Drawing.Point(692, 144);
			this.txtEmriModifiko.Name = "txtEmriModifiko";
			this.txtEmriModifiko.ReadOnly = true;
			this.txtEmriModifiko.Required = true;
			this.txtEmriModifiko.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmriModifiko.Size = new System.Drawing.Size(180, 21);
			this.txtEmriModifiko.TabIndex = 17;
			this.txtEmriModifiko.Text = "";
			// 
			// txtDhomaModifiko
			// 
			this.txtDhomaModifiko.AutoSize = false;
			this.txtDhomaModifiko.DefaultErrorMessage = "";
			this.txtDhomaModifiko.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtDhomaModifiko.FixedLength = false;
			this.txtDhomaModifiko.IsValid = false;
			this.txtDhomaModifiko.Location = new System.Drawing.Point(692, 172);
			this.txtDhomaModifiko.Name = "txtDhomaModifiko";
			this.txtDhomaModifiko.ReadOnly = true;
			this.txtDhomaModifiko.Required = true;
			this.txtDhomaModifiko.RequiredControlColor = System.Drawing.Color.White;
			this.txtDhomaModifiko.Size = new System.Drawing.Size(180, 21);
			this.txtDhomaModifiko.TabIndex = 18;
			this.txtDhomaModifiko.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Location = new System.Drawing.Point(620, 148);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 20);
			this.label6.TabIndex = 75;
			this.label6.Text = "Klienti";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label11.Location = new System.Drawing.Point(616, 172);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(68, 20);
			this.label11.TabIndex = 73;
			this.label11.Text = "Dhoma";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numSasi
			// 
			this.numSasi.AutoSize = false;
			this.numSasi.DefaultErrorMessage = "Ju duhet te caktoni sasine para se te modifikoni nje detyrim!";
			this.numSasi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numSasi.DigitsAfterDecimalPoint = 0;
			this.numSasi.FixedLength = false;
			this.numSasi.IsValid = false;
			this.numSasi.KeepFocus = false;
			this.numSasi.Location = new System.Drawing.Point(692, 256);
			this.numSasi.Name = "numSasi";
			this.numSasi.OnlyPositive = true;
			this.numSasi.Required = true;
			this.numSasi.RequiredControlColor = System.Drawing.Color.White;
			this.numSasi.Size = new System.Drawing.Size(180, 21);
			this.numSasi.TabIndex = 21;
			this.numSasi.Text = "";
			this.numSasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// groupBox7
			// 
			this.groupBox7.BackColor = System.Drawing.Color.Transparent;
			this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox7.Location = new System.Drawing.Point(584, 128);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(312, 164);
			this.groupBox7.TabIndex = 82;
			this.groupBox7.Text = "Modifikim i detyrimeve";
			this.groupBox7.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(632, 240);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 20);
			this.label3.TabIndex = 80;
			this.label3.Text = "Data e detyrimit";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label13.Location = new System.Drawing.Point(656, 152);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 20);
			this.label13.TabIndex = 75;
			this.label13.Text = "Emer";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label18.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label18.Location = new System.Drawing.Point(644, 184);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(76, 20);
			this.label18.TabIndex = 74;
			this.label18.Text = "Mbiemer";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label19.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label19.Location = new System.Drawing.Point(652, 208);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(68, 20);
			this.label19.TabIndex = 73;
			this.label19.Text = "Dhoma";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MyStyle
			// 
			this.MyStyle.DataGrid = null;
			this.MyStyle.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.MyStyle.MappingName = "";
			this.MyStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
			// 
			// HidhDetyrime
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1036, 636);
			this.Controls.Add(this.tab);
			this.HelpFile = "HIDH DETYRIME.htm";
			this.Name = "HidhDetyrime";
			this.Text = "Hidh detyrime";
			this.TitullGjeresi = 1036;
			this.Load += new System.EventHandler(this.HidhDetyrime_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.tab, 0);
			this.tab.ResumeLayout(false);
			this.tabShto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox6)).EndInit();
			this.groupBox6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox5)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.cmbDetyrimet.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.cmbDhomat.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.tabModifiko.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.cmbDhomat1.ResumeLayout(false);
			this.cmbKategorite1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox7)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region FormLoad
		private void HidhDetyrime_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				//pastrim variablash private
				this.idDetyrimi = 0;
				this.idKlienti = 0;
				this.idKlienti1 = 0;
				//pastrim variablash private
				DataSet ds = null;
				InputController data = new InputController();
				this.dtpDetyrimi.Value = System.DateTime.Now;
				ds = data.KerkesaRead("ShfaqKategorite");
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbKategorite.Kolone1.Items.Add(dr[1]);
					this.cmbKategorite.Kolone2.Items.Add(dr[0]);
					this.cmbKategorite1.Kolone1.Items.Add(dr[1]);
					this.cmbKategorite1.Kolone2.Items.Add(dr[0]);
				}
				this.mbushDetyrimet();
				string emer = "";
				string mbiemer = "";
				ds = data.KerkesaRead("ShfaqDetyrimKlientiPerEmerMbiemer", emer,mbiemer);
				if(ds.Tables["DETYRIMI"].Rows.Count == 0)
				{
					grid.DataSource = null;
					dg.DataSource = null;
					System.Windows.Forms.MessageBox.Show(this, "Ne hotel nuk ka asnje klient!","Hidh detyrime",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					return ;
				}
				if (ds.Tables[0].Rows.Count <= 16)
				{
					dg.Width = 520;
					grid.Width = 520;
				}
				else
				{
					dg.Width = 536;
					grid.Width = 536;
				}
				dg.DataSource = ds.Tables["DETYRIMI"];
				grid.DataSource = ds.Tables[0];
				//grid.DataSource = ds.Tables[0];
				this.KrijoStildg();
				this.KrijoStilGrid();
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
			this.Cursor = Cursors.WaitCursor;
			try
			{
				InputController data = new InputController();
				DataSet ds = data.KerkesaRead("ShfaqDetyrimKlientiPerEmerMbiemer", "","");
				if (this.tab.SelectedIndex == 0)//hedhja
				{
					this.Pastro(this.groupBox3);
					this.Pastro(this.groupBox5);
					this.Pastro(this.groupBox6);
					if (ds.Tables["DETYRIMI"].Rows.Count > 0)
						this.dg.DataSource = ds.Tables["DETYRIMI"];
					else
						this.dg.DataSource = null;
				}
				else//modifikimi
				{
					this.Pastro(this.groupBox4);
					this.Pastro(this.groupBox7);
					if (ds.Tables[0].Rows.Count > 0)
						this.grid.DataSource = ds.Tables[0];
					else
						this.grid.DataSource = null;
				}
				if (ds.Tables.Count != 0)
				{
					if (ds.Tables[0].Rows.Count <= 16)
					{
						dg.Width = 520;
						grid.Width = 520;
					}
					else
					{
						dg.Width = 536;
						grid.Width = 536;
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
				this.AutoScrollPosition = new Point(0, 0);
			}
		}
		#endregion

		#region ShtoDetyrim
		private void btnShto_Click(object sender, System.EventArgs e)
		{   
			try
			{
				int a = 0;
				a = this.KntDate(this.idKlienti, "shto");
				DataSet ds = null;
				if(a == 1)//data e hedhjes nuk ben pjese ne intervalin e klientit
				{
					System.Windows.Forms.MessageBox.Show(this, "Detyrimi per klientin nuk mund te hidhet!" + Environment.NewLine+"Data e hedhjes se detyrimit"+
						" duhet"+ Environment.NewLine +"te jete brenda intervalit te datave per klientin!",
						"Hidh detyrime",MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				else
				{
					int b = 0  ;
					int idLlojDetyrimi = Convert.ToInt32(this.cmbDetyrimet.Kolone2Vlere); // vleren do ta marre nga kombo e detyrimeve
					int sasia = Convert.ToInt32(this.numSasiDetyrimi.Text) ;
					DateTime dtDetyrimi = Convert.ToDateTime(this.dtpDetyrimi.Value);
					InputController data = new InputController();
					b = data.KerkesaUpdate("KrijoDetyrimPerKlient", idLlojDetyrimi,sasia,idKlienti,dtDetyrimi);
					if (b == 0)
					{
						System.Windows.Forms.MessageBox.Show(this, "Detyrimi per klientin e zgjedhur u shtua!", "Hidh detyrime",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						if ((this.rbDhoma.Checked == true)||(this.rbEmri.Checked == true))
							this.btnKerko_Click(sender, e);
						else
						{
							string emer = "";
							string mbiemer = "";
							ds = data.KerkesaRead("ShfaqDetyrimKlientiPerEmerMbiemer", emer,mbiemer);
							if (ds.Tables[0].Rows.Count <= 15)
								dg.Width = 520;
							else
								dg.Width = 536;
							dg.DataSource = ds.Tables["DETYRIMI"];
						}
						this.Pastro(this.groupBox5);
						this.Pastro(this.groupBox6);
					}
					else
					{
						System.Windows.Forms.MessageBox.Show(this, "Detyrimi per klientin nuk u hodh. Provoni perseri!", "Hidh detyrime", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
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
		}

		private void mbushDetyrimet()
		{
			DataSet ds = null ;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqLlojetDetyrime");
			//mbushja e kombos
			this.cmbDetyrime1.Kolone1.Items.Clear();
			this.cmbDetyrime1.Kolone2.Items.Clear();
			this.cmbDetyrimet.Kolone1.Items.Clear();
			this.cmbDetyrimet.Kolone2.Items.Clear();

			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbDetyrimet.Kolone1.Items.Add(dr[1]);
				this.cmbDetyrimet.Kolone2.Items.Add(dr[0]);

				this.cmbDetyrime1.Kolone1.Items.Add(dr[1]);
				this.cmbDetyrime1.Kolone2.Items.Add(dr[0]);
			}
		}

		private void cmbKategorite_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				this.cmbDhomat.Kolone1.Text = "";
				this.cmbDhomat.Kolone1.Items.Clear();
				this.cmbDhomat.Kolone2.Items.Clear();
				DataSet ds = null;
				int idKategoria = Convert.ToInt32(this.cmbKategorite.Kolone2Vlere);
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqDhomatPerKategorine", idKategoria);
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbDhomat.Kolone1.Items.Add(dr[0]);
					this.cmbDhomat.Kolone2.Items.Add(dr[1]);
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

		private void btnKerko_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				DataSet ds = null;
				InputController data = new InputController();
				if (rbDhoma.Checked == true)
				{
					if(this.cmbKategorite.Kolone1.SelectedItem == null)
					{
						this.cmbKategorite.IsValid = false;
						this.error.SetError(this.cmbKategorite , "Ju duhet te zgjidhni kategorine e dhomave per kerkim!");
					}
					else
					{
						int idKategoria = Convert.ToInt32(this.cmbKategorite.Kolone2Vlere);
						if(this.cmbDhomat.Kolone1.Text == "")
						{
							this.cmbKategorite.IsValid = true;
							this.error.SetError(this.cmbKategorite , "");
							ds = data.KerkesaRead("ShfaqDetyrimKlientiPerKategorineEdhene", idKategoria);
							if(ds.Tables["DETYRIMI"].Rows.Count == 0)
							{
								System.Windows.Forms.MessageBox.Show(this, "Dhomat per kategorine e kerkuar nuk kane kliente!","Hidh detyrime",
									MessageBoxButtons.OK, MessageBoxIcon.Information);
								return;
							}
							dg.DataSource = ds.Tables["DETYRIMI"];
							this.KrijoStildg();
						}
						else
						{
							if (this.cmbDhomat.Kolone1.SelectedItem == null)
							{
								this.error.SetError(this.cmbDhomat, "Zgjidhni nje prej dhomave qe gjenden ne liste!");
								return;
							}
							int idDhoma = Convert.ToInt32(this.cmbDhomat.Kolone2Vlere);
							this.error.SetError(this.cmbDhomat, "");
							this.cmbKategorite.IsValid = true;
							this.error.SetError(this.cmbKategorite , "");
							ds = data.KerkesaRead("ShfaqDetyrimetPerKlientetEDhomes", idDhoma);
							if(ds.Tables["DETYRIMI"].Rows.Count == 0)
							{
								System.Windows.Forms.MessageBox.Show(this, "Dhoma e zgjedhur nuk ka kliente!","Hidh detyrime",
									MessageBoxButtons.OK, MessageBoxIcon.Information);
								return;
							}
							dg.DataSource = ds.Tables["DETYRIMI"];
							this.KrijoStildg();
						
						}
					}
				}
				else if(rbEmri.Checked == true)
				{
					string emer = this.txtEmri1.Text.ToString();
					string mbiemer = this.txtMbiemri1.Text.ToString();
					ds = data.KerkesaRead("ShfaqDetyrimKlientiPerEmerMbiemer", emer,mbiemer);
					if(ds.Tables["DETYRIMI"].Rows.Count == 0)
					{
						System.Windows.Forms.MessageBox.Show(this, "Klientet me emer mbiemer te dhene nuk kane detyrime!","Hidh detyrime",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					dg.DataSource = ds.Tables["DETYRIMI"];
					this.KrijoStildg();
				}
				if ((ds != null)&& (ds.Tables.Count != 0))
				{
					if (ds.Tables[0].Rows.Count <= 15)
						dg.Width = 520;
					else
						dg.Width = 536;
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

		private void dg_CurrentCellChanged(object sender, System.EventArgs e)
		{
			try
			{
				int rowIndex = this.dg.CurrentRowIndex;
				this.txtEmri2.Text = this.dg[rowIndex,0].ToString();
				this.txtDhoma.Text = this.dg[rowIndex,2].ToString();
				this.idKlienti = Convert.ToInt32(dg[rowIndex,7]);
				this.cmbDetyrimet.Kolone1.Text = "";
				this.cmbDetyrimet.Kolone2.Text = "";
				this.numSasiDetyrimi.Text = "";
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
		
		#endregion

		#region ModifikoDetyrim
		private void btnKerko1_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				DataSet ds = null;
				InputController data = new InputController();
				if (rbDhoma1.Checked == true)
				{
					if(this.cmbKategorite1.Kolone1.SelectedItem == null)
					{
						this.cmbKategorite1.IsValid = false;
						this.error.SetError(this.cmbKategorite1 , "Ju duhet te zgjidhni kategorine e dhomave per kerkim!");
					}
					else
					{
						int idKategoria = Convert.ToInt32(this.cmbKategorite1.Kolone2Vlere);
						if(this.cmbDhomat1.Kolone1.Text == "")
						{
							this.cmbKategorite1.IsValid = true;
							this.error.SetError(this.cmbKategorite1 , "");
							ds = data.KerkesaRead("ShfaqVetemDetyrimKlientiPerKategorineEdhene", idKategoria);
							if(ds.Tables[0].Rows.Count == 0)
							{
								System.Windows.Forms.MessageBox.Show(this,"Hidh detyrime", "Dhomat per kategorine e kerkuar nuk kane kliente!",
									MessageBoxButtons.OK, MessageBoxIcon.Information);
								return;
							}
							grid.DataSource = ds.Tables[0];
							this.KrijoStilGrid();
					
						}
						else
						{	
							if (this.cmbDhomat1.Kolone1.SelectedItem == null)
							{
								this.error.SetError(this.cmbDhomat1, "Zgjidhni nje prej dhomave qe gjenden ne liste!");
								return;
							}
							this.error.SetError(this.cmbDhomat1, "");
							int idDhoma = Convert.ToInt32(this.cmbDhomat1.Kolone2Vlere);				
							this.cmbKategorite1.IsValid = true;
							this.error.SetError(this.cmbKategorite1 , "");
							ds = data.KerkesaRead("ShfaqVetemDetyrimetPerKlientetEDhomes", idDhoma);
							if(ds.Tables[0].Rows.Count == 0)
							{
								System.Windows.Forms.MessageBox.Show(this,"Hidh detyrime", "Dhoma e zgjedhur nuk ka kliente!",
									MessageBoxButtons.OK, MessageBoxIcon.Information);
								return;
							}
							grid.DataSource = ds.Tables[0];
							this.KrijoStilGrid();
						
						}
					}	
				}
				else if(rbEmri1.Checked == true)
				{
					string emer = this.txtEmri.Text.ToString();
					string mbiemer = this.txtMbiemri.Text.ToString();
					ds = data.KerkesaRead("ShfaqVetemDetyrimKlientiPerEmerMbiemer", emer,mbiemer);
					if(ds.Tables["DETYRIMI"].Rows.Count == 0)
					{
						System.Windows.Forms.MessageBox.Show(this,"Hidh detyrime", "Ne hotel nuk ka kliente me kete emer!",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					grid.DataSource = ds.Tables[0];
					this.KrijoStilGrid();
				}
				if ((ds != null)&&(ds.Tables.Count != 0))
				{
					if (ds.Tables[0].Rows.Count <= 16)
						grid.Width = 520;
					else
						grid.Width = 536;
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

		private void cmbKategorite1_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				this.cmbDhomat1.Kolone1.Text = "";
				this.cmbDhomat1.Kolone1.Items.Clear();
				this.cmbDhomat1.Kolone2.Items.Clear();
				DataSet ds = null;
				int idKategoria = Convert.ToInt32(this.cmbKategorite1.Kolone2Vlere);
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqDhomatPerKategorine", idKategoria);
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbDhomat1.Kolone1.Items.Add(dr[0]);
					this.cmbDhomat1.Kolone2.Items.Add(dr[1]);
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
			try
			{
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i detyrimeve", 
					"Jeni te sigurte qe doni te modifikoni detyrimin e zgjedhur ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result != DialogResult.Yes)
					return;
				int a = 0;
				DataSet ds = null;
				a = this.KntDate(this.idKlienti1, "modifiko");
				if (a == 1)
				{
					System.Windows.Forms.MessageBox.Show(this, "Kujdes detyrimi nuk mund te modifkohet!" + Environment.NewLine + "Data e hedhjes se detyrimit"+
						Environment.NewLine+"nuk ben pjese ne intervalin e datave per klientin!",
						"Modifikimi i detyrimeve",MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				else 
				{
					int b = 0;
					int idLlojDetyrimi = Convert.ToInt32(this.cmbDetyrime1.Kolone2Vlere);
					int sasia = Convert.ToInt32(this.numSasi.Text) ;
					DateTime dtDetyrimi = Convert.ToDateTime(this.dtpDetyrimi1.Value);
					InputController data = new InputController();
					b = data.KerkesaUpdate("ModifikoDetyriminPerKlient", this.idDetyrimi,idLlojDetyrimi,sasia,dtDetyrimi);
					if (b == 0)
					{
						System.Windows.Forms.MessageBox.Show(this, "Modifikimi i detyrimeve", "Detyrimi per klientin e zgjedhur u modifikua!",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						if ((this.rbDhoma1.Checked == true)||(this.rbEmri1.Checked == true))
						{
							this.btnKerko1_Click(sender, e);
						}
						else
						{
							string emer = "";
							string mbiemer = "";
							ds = data.KerkesaRead("ShfaqDetyrimKlientiPerEmerMbiemer", emer,mbiemer);
							if (ds.Tables[0].Rows.Count <= 16)
								grid.Width = 520;
							else
								grid.Width = 536;
							grid.DataSource = ds.Tables[0];
						}
						this.txtEmriModifiko.Text = "";
						this.txtDhomaModifiko.Text = "";
						this.dtpDetyrimi1.Value = DateTime.Now;
						this.cmbDetyrime1.Kolone1.Text = "";
						this.cmbDetyrime1.Kolone2.Text = "";
						this.numSasi.Text = "";
					}
					else
					{
						System.Windows.Forms.MessageBox.Show(this, "Detyrimi per klientin nuk u modifikua! Provoni perseri", "Modifikimi i detyrimeve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
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
		}
			
		private void btnElemino_Click(object sender, System.EventArgs e)
		{
			try
			{
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i detyrimeve", 
					"Jeni te sigurte qe doni te eliminoni detyrimin e zgjedhur ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result != DialogResult.Yes)
					return;	
				DataSet ds = null;
				int b = 0  ;
				InputController data = new InputController();
				b = data.KerkesaUpdate("FshiDetyriminPerKlient", this.idDetyrimi);
				if (b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Modifikimi i detyrimeve", "Detyrimi per klientin e zgjedhur u eleminua!",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					if ((this.rbDhoma1.Checked == true)||(this.rbEmri1.Checked == true))
					{
						this.btnKerko1_Click(sender, e);
					}
					else
					{
						string emer = "";
						string mbiemer = "";
						ds = data.KerkesaRead("ShfaqDetyrimKlientiPerEmerMbiemer", emer,mbiemer);
						if (ds.Tables[0].Rows.Count <= 16)
							grid.Width = 520;
						else
							grid.Width = 536;
						grid.DataSource = ds.Tables[0];
					}
					this.txtEmriModifiko.Text = "";
					this.txtDhomaModifiko.Text = "";
					this.dtpDetyrimi1.Value = DateTime.Now;
					this.cmbDetyrime1.Kolone1.Text = "";
					this.cmbDetyrime1.Kolone2.Text = "";
					this.numSasi.Text = "";
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, "Detyrimi per klientin nuk u eleminua. provoni perseri!", "Modifikimi i detyrimeve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

		private void grid_CurrentCellChanged_1(object sender, System.EventArgs e)
		{
			try
			{
				int rowIndex = this.grid.CurrentRowIndex;
				if (grid[rowIndex,8].ToString() == "")
				{
					this.idDetyrimi = 0;
					this.txtEmriModifiko.Text = "";
					this.txtDhomaModifiko.Text = "";
					this.cmbDetyrime1.Kolone1.Text = "";
					this.numSasi.Text = "";
					this.dtpDetyrimi1.Value = DateTime.Now;
				}
				else
				{
					this.txtEmriModifiko.Text = this.grid[rowIndex,0].ToString();
					this.txtDhomaModifiko.Text = this.grid[rowIndex,2].ToString();
					this.cmbDetyrime1.Kolone1.Text = this.grid[rowIndex,3].ToString();
					this.numSasi.Text = this.grid[rowIndex,5].ToString();
					this.idKlienti1 = Convert.ToInt32(grid[rowIndex,7]);
					this.dtpDetyrimi1.Text = grid[rowIndex,9].ToString();
					this.idDetyrimi = Convert.ToInt32(grid[rowIndex,8]);
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
        
						
		#endregion

		#region PrivateMethods
		private void KrijoStilGrid()
		{
			grid.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			//style.MappingName = "DETYRIMI";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			this.grid.ReadOnly = true;

			DataGridTextBoxColumn colEmri = new DataGridTextBoxColumn();
			colEmri.HeaderText = "Klienti";
			colEmri.MappingName = "EMRI";
			colEmri.Width = 110;
			
			DataGridTextBoxColumn colKategoria = new DataGridTextBoxColumn();
			colKategoria.HeaderText = "Kategoria";
			colKategoria.MappingName = "KAT_EMRI";
			colKategoria.Width = 0;

			DataGridTextBoxColumn colDhoma = new DataGridTextBoxColumn();
			colDhoma .HeaderText = "Dhoma";
			colDhoma .MappingName = "DHOMA_EMRI";
			colDhoma .Width = 55;
			colDhoma .TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));

			DataGridTextBoxColumn colLlojDetyrimi = new DataGridTextBoxColumn();
			colLlojDetyrimi.HeaderText = "Lloj Detyrimi";
			colLlojDetyrimi.MappingName = "EMER_LLOJI";
			colLlojDetyrimi.Width = 135;
			colLlojDetyrimi.NullText = "";

			DataGridTextBoxColumn colCmimi = new DataGridTextBoxColumn();
			colCmimi.HeaderText = "Cmimi";
			colCmimi.MappingName = "CMIMI";
			colCmimi.Width = 40;
			colCmimi.NullText = "";

			DataGridTextBoxColumn colSasia = new DataGridTextBoxColumn();
			colSasia .HeaderText = "Sasia";
			colSasia .MappingName = "SASIA";
			colSasia .Width = 40;
			colSasia .NullText = "";

			DataGridTextBoxColumn colDtDetyrimi1 = new DataGridTextBoxColumn();
			colDtDetyrimi1 .HeaderText = "Dt Detyrimi";
			colDtDetyrimi1 .MappingName = "DATA_STR";
			colDtDetyrimi1 .Width = 135;
			colDtDetyrimi1 .NullText = "";

			DataGridTextBoxColumn colDtDetyrimi = new DataGridTextBoxColumn();
			colDtDetyrimi .HeaderText = "Data e detyrimit";
			colDtDetyrimi .MappingName = "DATA";
			colDtDetyrimi .Width = 0;
			colDtDetyrimi .NullText = "";

			DataGridTextBoxColumn idKlienti = new DataGridTextBoxColumn();
			idKlienti .HeaderText = "";
			idKlienti .MappingName = "ID_KLIENTI";
			idKlienti .Width = 0;
			idKlienti .NullText = "";

			DataGridTextBoxColumn idDetyrimi = new DataGridTextBoxColumn();
			idDetyrimi .HeaderText = "";
			idDetyrimi .MappingName = "ID_DETYRIMI";
			idDetyrimi .Width = 0;
			idDetyrimi .NullText = "";

			style.GridColumnStyles.AddRange(
				new DataGridColumnStyle[]{ colEmri,colKategoria, colDhoma,
											 colLlojDetyrimi,colCmimi ,colSasia,colDtDetyrimi1,idKlienti,
											 idDetyrimi,colDtDetyrimi });
			
			grid.TableStyles.Add(style);
			grid.FlatMode = false;
			grid.Expand(-1);
		}

		private void KrijoStildg()
		{
			this.dg.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "DETYRIMI";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			this.dg.ReadOnly = true;
			
			DataGridTekstBoxColumn colEmri = new DataGridTekstBoxColumn();
			colEmri.HeaderText = "Klienti";
			colEmri.MappingName = "EMRI";
			colEmri.Width = 110;

			DataGridTekstBoxColumn colKategoria = new DataGridTekstBoxColumn();
			colKategoria.HeaderText = "Kategoria";
			colKategoria.MappingName = "KAT_EMRI";
			colKategoria.Width = 0;

			DataGridTekstBoxColumn colDhoma = new DataGridTekstBoxColumn();
			colDhoma .HeaderText = "Dhoma";
			colDhoma .MappingName = "DHOMA_EMRI";
			colDhoma .Width = 55;
			

			DataGridTekstBoxColumn colLlojDetyrimi = new DataGridTekstBoxColumn();
			colLlojDetyrimi.HeaderText = "Lloj Detyrimi";
			colLlojDetyrimi.MappingName = "EMER_LLOJI";
			colLlojDetyrimi.Width = 135;
			colLlojDetyrimi.NullText = "";

			DataGridTekstBoxColumn colCmimi = new DataGridTekstBoxColumn();
			colCmimi.HeaderText = "Cmimi";
			colCmimi.MappingName = "CMIMI_STR";
			colCmimi.Width = 40;
			colCmimi.NullText = "";

			DataGridTekstBoxColumn colSasia = new DataGridTekstBoxColumn();
			colSasia .HeaderText = "Sasia";
			colSasia .MappingName = "SASIA_STR";
			colSasia .Width = 40;
			colSasia .NullText = "";

			DataGridTekstBoxColumn colDtDetyrimi = new DataGridTekstBoxColumn();
			colDtDetyrimi .HeaderText = "Dt Detyrimi";
			colDtDetyrimi .MappingName = "DATA_STR";
			colDtDetyrimi .Width = 135;
			colDtDetyrimi .NullText = "";

			DataGridTekstBoxColumn colDtDetyrimi1 = new DataGridTekstBoxColumn();
			colDtDetyrimi1 .HeaderText = "Dt Detyrimi";
			colDtDetyrimi1 .MappingName = "DATA";
			colDtDetyrimi1 .Width = 0;
			colDtDetyrimi1 .NullText = "";

			DataGridTekstBoxColumn idKlienti = new DataGridTekstBoxColumn();
			idKlienti .HeaderText = "";
			idKlienti .MappingName = "ID_KLIENTI";
			idKlienti .Width = 0;
			idKlienti .NullText = "";

			DataGridTekstBoxColumn idDetyrimi = new DataGridTekstBoxColumn();
			idDetyrimi .HeaderText = "";
			idDetyrimi .MappingName = "ID_DETYRIMI";
			idDetyrimi .Width = 0;
			idDetyrimi .NullText = "";
			style.GridColumnStyles.AddRange(
				new DataGridColumnStyle[]{ 
											 colEmri,colKategoria, colDhoma,
											 colLlojDetyrimi,colCmimi ,colSasia,colDtDetyrimi,idKlienti,idDetyrimi,
											 colDtDetyrimi1 });
			
			dg.TableStyles.Add(style);
			dg.FlatMode = false;
			dg.Expand(-1);

		}
		private int KntDate(int idKlienti, string s)
		{
			DataSet ds = null;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqDataPerKlientin",idKlienti);
			DateTime dtFillimi = Convert.ToDateTime(ds.Tables[0].Rows[0][0]);
			DateTime dtMbarimi = Convert.ToDateTime(ds.Tables[0].Rows[0][1]);
			DateTime dtDetyrimi;
			if (s == "shto")
				dtDetyrimi = Convert.ToDateTime(this.dtpDetyrimi.Value);
			else
				dtDetyrimi = Convert.ToDateTime(this.dtpDetyrimi1.Value);
			if ((dtDetyrimi < dtMbarimi)&&(dtDetyrimi > dtFillimi))
				return 0;
			else
				return 1;
		}

		#endregion
	}
}
