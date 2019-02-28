using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;

namespace HotelManagment.Forms
{
	public class frmPerdorues : VisionInfoSolutionLibrary.Form
	{
		#region Private Declarations
		private VisionInfoSolutionLibrary.TabControl tab;
		private VisionInfoSolutionLibrary.TabPageControl tbPerdorues;
		private VisionInfoSolutionLibrary.TabPageControl tbDrejtat;
		private VisionInfoSolutionLibrary.Button btnShto;
		private VisionInfoSolutionLibrary.Label lblEmerPerdoruesi;
		private VisionInfoSolutionLibrary.Label lblMbiemri;
		private VisionInfoSolutionLibrary.Label lblEmri;
		private VisionInfoSolutionLibrary.TextBox txtFjalekalimi2;
		private VisionInfoSolutionLibrary.TextBox txtFjalekalimi1;
		private VisionInfoSolutionLibrary.TextBox txtEmerPerdoruesi;
		private VisionInfoSolutionLibrary.TextBox txtMbiemri;
		private VisionInfoSolutionLibrary.TextBox txtEmri;
		private VisionInfoSolutionLibrary.Label lblFjalekalimi1;
		private VisionInfoSolutionLibrary.Label lblFjalekalimi2;
		private VisionInfoSolutionLibrary.Label lblRoli;
		private VisionInfoSolutionLibrary.GroupBox grbShtoPerdorues;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.TextBox txtEmriMod;
		private VisionInfoSolutionLibrary.TextBox txtMbiemriMod;
		private VisionInfoSolutionLibrary.TextBox txtFjalekalimiMod;
		private VisionInfoSolutionLibrary.Label label4;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.Label lblEmerPerdoruesiMod;
		private VisionInfoSolutionLibrary.DoubleCombo cmbPerdoruesMod;
		private VisionInfoSolutionLibrary.Button btnElemino;
		private VisionInfoSolutionLibrary.Button btnModifiko;
		private VisionInfoSolutionLibrary.DoubleCombo cmbRoli;
		private VisionInfoSolutionLibrary.GroupBox grbModifikoEleminoPerdorues;
		private VisionInfoSolutionLibrary.DoubleCombo cmbRoliMod;
		private VisionInfoSolutionLibrary.Label lblTeDrejtat;
		private VisionInfoSolutionLibrary.Label lblTeDrejtatPergj;
		private VisionInfoSolutionLibrary.Button btnRuaj;
		private VisionInfoSolutionLibrary.GroupBox grbModifikimiDrejtave;
		private VisionInfoSolutionLibrary.TextBox txtEmerPerdoruesMod;
		private VisionInfoSolutionLibrary.Label lblEmerPerdoruesMod;
		private VisionInfoSolutionLibrary.ListBox lbDrejta;
		private VisionInfoSolutionLibrary.ListBox lbDrejtaMundshme;
		private VisionInfoSolutionLibrary.Button btnKaloDjathtas;
		private VisionInfoSolutionLibrary.Button btnKaloMajtas;
		private VisionInfoSolutionLibrary.TextBox txtRolVFalse;
		private System.ComponentModel.IContainer components = null;
		#endregion

		#region Constructors and Destructors
		public frmPerdorues()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
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
			this.tbPerdorues = new VisionInfoSolutionLibrary.TabPageControl();
			this.grbModifikoEleminoPerdorues = new VisionInfoSolutionLibrary.GroupBox();
			this.txtRolVFalse = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmerPerdoruesMod = new VisionInfoSolutionLibrary.TextBox();
			this.lblEmerPerdoruesMod = new VisionInfoSolutionLibrary.Label();
			this.cmbRoliMod = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbPerdoruesMod = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.txtEmriMod = new VisionInfoSolutionLibrary.TextBox();
			this.txtMbiemriMod = new VisionInfoSolutionLibrary.TextBox();
			this.txtFjalekalimiMod = new VisionInfoSolutionLibrary.TextBox();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.lblEmerPerdoruesiMod = new VisionInfoSolutionLibrary.Label();
			this.grbShtoPerdorues = new VisionInfoSolutionLibrary.GroupBox();
			this.lblRoli = new VisionInfoSolutionLibrary.Label();
			this.cmbRoli = new VisionInfoSolutionLibrary.DoubleCombo();
			this.lblFjalekalimi2 = new VisionInfoSolutionLibrary.Label();
			this.lblFjalekalimi1 = new VisionInfoSolutionLibrary.Label();
			this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
			this.txtMbiemri = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmerPerdoruesi = new VisionInfoSolutionLibrary.TextBox();
			this.txtFjalekalimi1 = new VisionInfoSolutionLibrary.TextBox();
			this.txtFjalekalimi2 = new VisionInfoSolutionLibrary.TextBox();
			this.lblEmri = new VisionInfoSolutionLibrary.Label();
			this.lblMbiemri = new VisionInfoSolutionLibrary.Label();
			this.lblEmerPerdoruesi = new VisionInfoSolutionLibrary.Label();
			this.btnShto = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifiko = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnElemino = new VisionInfoSolutionLibrary.Button(this.components);
			this.tbDrejtat = new VisionInfoSolutionLibrary.TabPageControl();
			this.lbDrejta = new VisionInfoSolutionLibrary.ListBox();
			this.grbModifikimiDrejtave = new VisionInfoSolutionLibrary.GroupBox();
			this.btnKaloMajtas = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnKaloDjathtas = new VisionInfoSolutionLibrary.Button(this.components);
			this.lblTeDrejtatPergj = new VisionInfoSolutionLibrary.Label();
			this.lblTeDrejtat = new VisionInfoSolutionLibrary.Label();
			this.lbDrejtaMundshme = new VisionInfoSolutionLibrary.ListBox();
			this.btnRuaj = new VisionInfoSolutionLibrary.Button(this.components);
			this.tab.SuspendLayout();
			this.tbPerdorues.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grbModifikoEleminoPerdorues)).BeginInit();
			this.grbModifikoEleminoPerdorues.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grbShtoPerdorues)).BeginInit();
			this.grbShtoPerdorues.SuspendLayout();
			this.tbDrejtat.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grbModifikimiDrejtave)).BeginInit();
			this.grbModifikimiDrejtave.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1011, 25);
			// 
			// tab
			// 
			this.tab.Controls.Add(this.tbPerdorues);
			this.tab.Controls.Add(this.tbDrejtat);
			this.tab.Cursor = System.Windows.Forms.Cursors.Default;
			this.tab.Location = new System.Drawing.Point(0, 25);
			this.tab.Name = "tab";
			this.tab.Padding = new System.Drawing.Point(0, 0);
			this.tab.SelectedIndex = 0;
			this.tab.Size = new System.Drawing.Size(1011, 609);
			this.tab.TabIndex = 1;
			this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
			// 
			// tbPerdorues
			// 
			this.tbPerdorues.BackColor = System.Drawing.SystemColors.Control;
			this.tbPerdorues.Controls.Add(this.grbModifikoEleminoPerdorues);
			this.tbPerdorues.Controls.Add(this.grbShtoPerdorues);
			this.tbPerdorues.Controls.Add(this.btnShto);
			this.tbPerdorues.Controls.Add(this.btnModifiko);
			this.tbPerdorues.Controls.Add(this.btnElemino);
			this.tbPerdorues.DefaultErrorMessage = null;
			this.tbPerdorues.EnableValidation = true;
			this.tbPerdorues.IsValid = false;
			this.tbPerdorues.Location = new System.Drawing.Point(4, 22);
			this.tbPerdorues.Name = "tbPerdorues";
			this.tbPerdorues.Size = new System.Drawing.Size(1003, 583);
			this.tbPerdorues.TabIndex = 0;
			this.tbPerdorues.Text = "Konfigurime perdoruesish";
			// 
			// grbModifikoEleminoPerdorues
			// 
			this.grbModifikoEleminoPerdorues.BackColor = System.Drawing.Color.Transparent;
			this.grbModifikoEleminoPerdorues.Controls.Add(this.txtRolVFalse);
			this.grbModifikoEleminoPerdorues.Controls.Add(this.txtEmerPerdoruesMod);
			this.grbModifikoEleminoPerdorues.Controls.Add(this.lblEmerPerdoruesMod);
			this.grbModifikoEleminoPerdorues.Controls.Add(this.cmbRoliMod);
			this.grbModifikoEleminoPerdorues.Controls.Add(this.cmbPerdoruesMod);
			this.grbModifikoEleminoPerdorues.Controls.Add(this.label1);
			this.grbModifikoEleminoPerdorues.Controls.Add(this.label3);
			this.grbModifikoEleminoPerdorues.Controls.Add(this.txtEmriMod);
			this.grbModifikoEleminoPerdorues.Controls.Add(this.txtMbiemriMod);
			this.grbModifikoEleminoPerdorues.Controls.Add(this.txtFjalekalimiMod);
			this.grbModifikoEleminoPerdorues.Controls.Add(this.label4);
			this.grbModifikoEleminoPerdorues.Controls.Add(this.label5);
			this.grbModifikoEleminoPerdorues.Controls.Add(this.lblEmerPerdoruesiMod);
			this.grbModifikoEleminoPerdorues.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grbModifikoEleminoPerdorues.Location = new System.Drawing.Point(10, 184);
			this.grbModifikoEleminoPerdorues.Name = "grbModifikoEleminoPerdorues";
			this.grbModifikoEleminoPerdorues.Size = new System.Drawing.Size(588, 160);
			this.grbModifikoEleminoPerdorues.TabIndex = 1;
			this.grbModifikoEleminoPerdorues.Text = "Modifiko/Elemino Perdorues";
			this.grbModifikoEleminoPerdorues.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// txtRolVFalse
			// 
			this.txtRolVFalse.AutoSize = false;
			this.txtRolVFalse.DefaultErrorMessage = "";
			this.txtRolVFalse.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtRolVFalse.FixedLength = false;
			this.txtRolVFalse.IsValid = true;
			this.txtRolVFalse.Location = new System.Drawing.Point(464, 16);
			this.txtRolVFalse.Name = "txtRolVFalse";
			this.txtRolVFalse.Required = false;
			this.txtRolVFalse.RequiredControlColor = System.Drawing.Color.White;
			this.txtRolVFalse.Size = new System.Drawing.Size(68, 20);
			this.txtRolVFalse.TabIndex = 28;
			this.txtRolVFalse.Text = "";
			this.txtRolVFalse.Visible = false;
			// 
			// txtEmerPerdoruesMod
			// 
			this.txtEmerPerdoruesMod.AutoSize = false;
			this.txtEmerPerdoruesMod.DefaultErrorMessage = "";
			this.txtEmerPerdoruesMod.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmerPerdoruesMod.FixedLength = false;
			this.txtEmerPerdoruesMod.IsValid = false;
			this.txtEmerPerdoruesMod.Location = new System.Drawing.Point(412, 68);
			this.txtEmerPerdoruesMod.Name = "txtEmerPerdoruesMod";
			this.txtEmerPerdoruesMod.Required = false;
			this.txtEmerPerdoruesMod.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmerPerdoruesMod.Size = new System.Drawing.Size(160, 21);
			this.txtEmerPerdoruesMod.TabIndex = 11;
			this.txtEmerPerdoruesMod.Text = "";
			this.toolTips.SetToolTip(this.txtEmerPerdoruesMod, "Emri qe do te perdore per tu futur ne program!");
			// 
			// lblEmerPerdoruesMod
			// 
			this.lblEmerPerdoruesMod.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmerPerdoruesMod.Location = new System.Drawing.Point(300, 68);
			this.lblEmerPerdoruesMod.Name = "lblEmerPerdoruesMod";
			this.lblEmerPerdoruesMod.Size = new System.Drawing.Size(104, 20);
			this.lblEmerPerdoruesMod.TabIndex = 25;
			this.lblEmerPerdoruesMod.Text = "Emri i perdoruesit";
			this.lblEmerPerdoruesMod.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cmbRoliMod
			// 
			this.cmbRoliMod.BackColor = System.Drawing.Color.Transparent;
			this.cmbRoliMod.DefaultErrorMessage = null;
			this.cmbRoliMod.IsValid = false;
			this.cmbRoliMod.Kolone1Vlere = null;
			this.cmbRoliMod.Kolone2Vlere = null;
			this.cmbRoliMod.Location = new System.Drawing.Point(412, 124);
			this.cmbRoliMod.Name = "cmbRoliMod";
			this.cmbRoliMod.ReadOnly = false;
			this.cmbRoliMod.Required = false;
			this.cmbRoliMod.Size = new System.Drawing.Size(160, 21);
			this.cmbRoliMod.SkipValidation = false;
			this.cmbRoliMod.TabIndex = 13;
			// 
			// cmbPerdoruesMod
			// 
			this.cmbPerdoruesMod.BackColor = System.Drawing.Color.Transparent;
			this.cmbPerdoruesMod.DefaultErrorMessage = null;
			this.cmbPerdoruesMod.IsValid = false;
			this.cmbPerdoruesMod.Kolone1Vlere = null;
			this.cmbPerdoruesMod.Kolone2Vlere = null;
			this.cmbPerdoruesMod.Location = new System.Drawing.Point(120, 20);
			this.cmbPerdoruesMod.Name = "cmbPerdoruesMod";
			this.cmbPerdoruesMod.ReadOnly = false;
			this.cmbPerdoruesMod.Required = false;
			this.cmbPerdoruesMod.Size = new System.Drawing.Size(160, 21);
			this.cmbPerdoruesMod.SkipValidation = false;
			this.cmbPerdoruesMod.TabIndex = 8;
			this.cmbPerdoruesMod.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbPerdoruesMod_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(304, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 27;
			this.label1.Text = "Roli i perdoruesit";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(304, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 26;
			this.label3.Text = "Fjalekalimi";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtEmriMod
			// 
			this.txtEmriMod.AutoSize = false;
			this.txtEmriMod.DefaultErrorMessage = "";
			this.txtEmriMod.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmriMod.FixedLength = false;
			this.txtEmriMod.IsValid = true;
			this.txtEmriMod.Location = new System.Drawing.Point(120, 68);
			this.txtEmriMod.Name = "txtEmriMod";
			this.txtEmriMod.Required = false;
			this.txtEmriMod.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmriMod.Size = new System.Drawing.Size(160, 21);
			this.txtEmriMod.TabIndex = 9;
			this.txtEmriMod.Text = "";
			// 
			// txtMbiemriMod
			// 
			this.txtMbiemriMod.AutoSize = false;
			this.txtMbiemriMod.DefaultErrorMessage = "";
			this.txtMbiemriMod.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemriMod.FixedLength = false;
			this.txtMbiemriMod.IsValid = true;
			this.txtMbiemriMod.Location = new System.Drawing.Point(120, 96);
			this.txtMbiemriMod.Name = "txtMbiemriMod";
			this.txtMbiemriMod.Required = false;
			this.txtMbiemriMod.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemriMod.Size = new System.Drawing.Size(160, 21);
			this.txtMbiemriMod.TabIndex = 10;
			this.txtMbiemriMod.Text = "";
			// 
			// txtFjalekalimiMod
			// 
			this.txtFjalekalimiMod.AutoSize = false;
			this.txtFjalekalimiMod.DefaultErrorMessage = "";
			this.txtFjalekalimiMod.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtFjalekalimiMod.FixedLength = false;
			this.txtFjalekalimiMod.IsValid = true;
			this.txtFjalekalimiMod.Location = new System.Drawing.Point(412, 96);
			this.txtFjalekalimiMod.Name = "txtFjalekalimiMod";
			this.txtFjalekalimiMod.PasswordChar = '*';
			this.txtFjalekalimiMod.Required = false;
			this.txtFjalekalimiMod.RequiredControlColor = System.Drawing.Color.White;
			this.txtFjalekalimiMod.Size = new System.Drawing.Size(160, 21);
			this.txtFjalekalimiMod.TabIndex = 12;
			this.txtFjalekalimiMod.Text = "";
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Location = new System.Drawing.Point(52, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 20);
			this.label4.TabIndex = 23;
			this.label4.Text = "Emri";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(44, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 20);
			this.label5.TabIndex = 24;
			this.label5.Text = "Mbiemri";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblEmerPerdoruesiMod
			// 
			this.lblEmerPerdoruesiMod.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmerPerdoruesiMod.Location = new System.Drawing.Point(4, 24);
			this.lblEmerPerdoruesiMod.Name = "lblEmerPerdoruesiMod";
			this.lblEmerPerdoruesiMod.Size = new System.Drawing.Size(108, 20);
			this.lblEmerPerdoruesiMod.TabIndex = 22;
			this.lblEmerPerdoruesiMod.Text = "Zgjidhni perdoruesin";
			this.lblEmerPerdoruesiMod.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// grbShtoPerdorues
			// 
			this.grbShtoPerdorues.BackColor = System.Drawing.Color.Transparent;
			this.grbShtoPerdorues.Controls.Add(this.lblRoli);
			this.grbShtoPerdorues.Controls.Add(this.cmbRoli);
			this.grbShtoPerdorues.Controls.Add(this.lblFjalekalimi2);
			this.grbShtoPerdorues.Controls.Add(this.lblFjalekalimi1);
			this.grbShtoPerdorues.Controls.Add(this.txtEmri);
			this.grbShtoPerdorues.Controls.Add(this.txtMbiemri);
			this.grbShtoPerdorues.Controls.Add(this.txtEmerPerdoruesi);
			this.grbShtoPerdorues.Controls.Add(this.txtFjalekalimi1);
			this.grbShtoPerdorues.Controls.Add(this.txtFjalekalimi2);
			this.grbShtoPerdorues.Controls.Add(this.lblEmri);
			this.grbShtoPerdorues.Controls.Add(this.lblMbiemri);
			this.grbShtoPerdorues.Controls.Add(this.lblEmerPerdoruesi);
			this.grbShtoPerdorues.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grbShtoPerdorues.Location = new System.Drawing.Point(10, 8);
			this.grbShtoPerdorues.Name = "grbShtoPerdorues";
			this.grbShtoPerdorues.Size = new System.Drawing.Size(588, 140);
			this.grbShtoPerdorues.TabIndex = 0;
			this.grbShtoPerdorues.Text = "Shto Perdorues";
			this.grbShtoPerdorues.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// lblRoli
			// 
			this.lblRoli.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblRoli.Location = new System.Drawing.Point(304, 104);
			this.lblRoli.Name = "lblRoli";
			this.lblRoli.Size = new System.Drawing.Size(100, 20);
			this.lblRoli.TabIndex = 21;
			this.lblRoli.Text = "Roli i perdoruesit";
			this.lblRoli.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cmbRoli
			// 
			this.cmbRoli.BackColor = System.Drawing.Color.Transparent;
			this.cmbRoli.DefaultErrorMessage = "Ju duhet te zgjidhni nje rol per perdoruesin e ri qe do te shtoni!";
			this.cmbRoli.IsValid = false;
			this.cmbRoli.Kolone1Vlere = null;
			this.cmbRoli.Kolone2Vlere = null;
			this.cmbRoli.Location = new System.Drawing.Point(412, 100);
			this.cmbRoli.Name = "cmbRoli";
			this.cmbRoli.ReadOnly = false;
			this.cmbRoli.Required = true;
			this.cmbRoli.Size = new System.Drawing.Size(160, 21);
			this.cmbRoli.SkipValidation = false;
			this.cmbRoli.TabIndex = 6;
			// 
			// lblFjalekalimi2
			// 
			this.lblFjalekalimi2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblFjalekalimi2.Location = new System.Drawing.Point(280, 72);
			this.lblFjalekalimi2.Name = "lblFjalekalimi2";
			this.lblFjalekalimi2.Size = new System.Drawing.Size(124, 20);
			this.lblFjalekalimi2.TabIndex = 10;
			this.lblFjalekalimi2.Text = "Perserisni fjalekalimin";
			this.lblFjalekalimi2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblFjalekalimi1
			// 
			this.lblFjalekalimi1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblFjalekalimi1.Location = new System.Drawing.Point(304, 44);
			this.lblFjalekalimi1.Name = "lblFjalekalimi1";
			this.lblFjalekalimi1.Size = new System.Drawing.Size(100, 20);
			this.lblFjalekalimi1.TabIndex = 20;
			this.lblFjalekalimi1.Text = "Fjalekalimi";
			this.lblFjalekalimi1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtEmri
			// 
			this.txtEmri.AutoSize = false;
			this.txtEmri.DefaultErrorMessage = "";
			this.txtEmri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri.FixedLength = false;
			this.txtEmri.IsValid = true;
			this.txtEmri.Location = new System.Drawing.Point(120, 16);
			this.txtEmri.Name = "txtEmri";
			this.txtEmri.Required = false;
			this.txtEmri.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri.Size = new System.Drawing.Size(160, 21);
			this.txtEmri.TabIndex = 1;
			this.txtEmri.Text = "";
			// 
			// txtMbiemri
			// 
			this.txtMbiemri.AutoSize = false;
			this.txtMbiemri.DefaultErrorMessage = "";
			this.txtMbiemri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemri.FixedLength = false;
			this.txtMbiemri.IsValid = true;
			this.txtMbiemri.Location = new System.Drawing.Point(120, 48);
			this.txtMbiemri.Name = "txtMbiemri";
			this.txtMbiemri.Required = false;
			this.txtMbiemri.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemri.Size = new System.Drawing.Size(160, 21);
			this.txtMbiemri.TabIndex = 2;
			this.txtMbiemri.Text = "";
			// 
			// txtEmerPerdoruesi
			// 
			this.txtEmerPerdoruesi.AutoSize = false;
			this.txtEmerPerdoruesi.DefaultErrorMessage = "Ju duhet te jepni nje emer perdoruesi per perdoruesin e ri qe do te shtoni!";
			this.txtEmerPerdoruesi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmerPerdoruesi.FixedLength = false;
			this.txtEmerPerdoruesi.IsValid = false;
			this.txtEmerPerdoruesi.Location = new System.Drawing.Point(412, 16);
			this.txtEmerPerdoruesi.Name = "txtEmerPerdoruesi";
			this.txtEmerPerdoruesi.Required = true;
			this.txtEmerPerdoruesi.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmerPerdoruesi.Size = new System.Drawing.Size(160, 21);
			this.txtEmerPerdoruesi.TabIndex = 3;
			this.txtEmerPerdoruesi.Text = "";
			// 
			// txtFjalekalimi1
			// 
			this.txtFjalekalimi1.AutoSize = false;
			this.txtFjalekalimi1.DefaultErrorMessage = "Ju duhet te jepni nje fjalekalim per perdoruesin e ri qe do te shtoni!";
			this.txtFjalekalimi1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtFjalekalimi1.FixedLength = false;
			this.txtFjalekalimi1.IsValid = false;
			this.txtFjalekalimi1.Location = new System.Drawing.Point(412, 44);
			this.txtFjalekalimi1.Name = "txtFjalekalimi1";
			this.txtFjalekalimi1.PasswordChar = '*';
			this.txtFjalekalimi1.Required = true;
			this.txtFjalekalimi1.RequiredControlColor = System.Drawing.Color.White;
			this.txtFjalekalimi1.Size = new System.Drawing.Size(160, 21);
			this.txtFjalekalimi1.TabIndex = 4;
			this.txtFjalekalimi1.Text = "";
			// 
			// txtFjalekalimi2
			// 
			this.txtFjalekalimi2.AutoSize = false;
			this.txtFjalekalimi2.DefaultErrorMessage = "Duhet te shkruani edhe nje here fjalekalimin e ri per perdoruesin!";
			this.txtFjalekalimi2.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtFjalekalimi2.FixedLength = false;
			this.txtFjalekalimi2.IsValid = false;
			this.txtFjalekalimi2.Location = new System.Drawing.Point(412, 72);
			this.txtFjalekalimi2.Name = "txtFjalekalimi2";
			this.txtFjalekalimi2.PasswordChar = '*';
			this.txtFjalekalimi2.Required = true;
			this.txtFjalekalimi2.RequiredControlColor = System.Drawing.Color.White;
			this.txtFjalekalimi2.Size = new System.Drawing.Size(160, 21);
			this.txtFjalekalimi2.TabIndex = 5;
			this.txtFjalekalimi2.Text = "";
			// 
			// lblEmri
			// 
			this.lblEmri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmri.Location = new System.Drawing.Point(60, 20);
			this.lblEmri.Name = "lblEmri";
			this.lblEmri.Size = new System.Drawing.Size(52, 16);
			this.lblEmri.TabIndex = 17;
			this.lblEmri.Text = "Emri";
			this.lblEmri.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblMbiemri
			// 
			this.lblMbiemri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblMbiemri.Location = new System.Drawing.Point(60, 48);
			this.lblMbiemri.Name = "lblMbiemri";
			this.lblMbiemri.Size = new System.Drawing.Size(52, 20);
			this.lblMbiemri.TabIndex = 18;
			this.lblMbiemri.Text = "Mbiemri";
			this.lblMbiemri.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblEmerPerdoruesi
			// 
			this.lblEmerPerdoruesi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmerPerdoruesi.Location = new System.Drawing.Point(296, 16);
			this.lblEmerPerdoruesi.Name = "lblEmerPerdoruesi";
			this.lblEmerPerdoruesi.Size = new System.Drawing.Size(108, 20);
			this.lblEmerPerdoruesi.TabIndex = 19;
			this.lblEmerPerdoruesi.Text = "Emri i perdoruesit";
			this.lblEmerPerdoruesi.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnShto
			// 
			this.btnShto.BackColor = System.Drawing.Color.Blue;
			this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShto.DoValidation = true;
			this.btnShto.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShto.Location = new System.Drawing.Point(52, 156);
			this.btnShto.Name = "btnShto";
			this.btnShto.Size = new System.Drawing.Size(90, 21);
			this.btnShto.TabIndex = 7;
			this.btnShto.Text = "Shto";
			this.toolTips.SetToolTip(this.btnShto, "Shton nje perdorues te ri!");
			this.btnShto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
			// 
			// btnModifiko
			// 
			this.btnModifiko.BackColor = System.Drawing.Color.Blue;
			this.btnModifiko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifiko.DoValidation = false;
			this.btnModifiko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifiko.Location = new System.Drawing.Point(52, 352);
			this.btnModifiko.Name = "btnModifiko";
			this.btnModifiko.Size = new System.Drawing.Size(90, 21);
			this.btnModifiko.TabIndex = 14;
			this.btnModifiko.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifiko, "Modifikon perdoruesin e zgjedhur!");
			this.btnModifiko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
			// 
			// btnElemino
			// 
			this.btnElemino.BackColor = System.Drawing.Color.Blue;
			this.btnElemino.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnElemino.DoValidation = false;
			this.btnElemino.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnElemino.Location = new System.Drawing.Point(476, 356);
			this.btnElemino.Name = "btnElemino";
			this.btnElemino.Size = new System.Drawing.Size(90, 21);
			this.btnElemino.TabIndex = 15;
			this.btnElemino.Text = "Elemino";
			this.toolTips.SetToolTip(this.btnElemino, "Eleminon perdoruesin e zgjedhur!");
			this.btnElemino.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnElemino.Click += new System.EventHandler(this.btnElemino_Click);
			// 
			// tbDrejtat
			// 
			this.tbDrejtat.BackColor = System.Drawing.SystemColors.Control;
			this.tbDrejtat.Controls.Add(this.lbDrejta);
			this.tbDrejtat.Controls.Add(this.grbModifikimiDrejtave);
			this.tbDrejtat.Controls.Add(this.btnRuaj);
			this.tbDrejtat.DefaultErrorMessage = null;
			this.tbDrejtat.EnableValidation = true;
			this.tbDrejtat.IsValid = false;
			this.tbDrejtat.Location = new System.Drawing.Point(4, 22);
			this.tbDrejtat.Name = "tbDrejtat";
			this.tbDrejtat.Size = new System.Drawing.Size(1003, 583);
			this.tbDrejtat.TabIndex = 1;
			this.tbDrejtat.Text = "Konfigurime te drejtash";
			// 
			// lbDrejta
			// 
			this.lbDrejta.DefaultErrorMessage = null;
			this.lbDrejta.IsValid = true;
			this.lbDrejta.Location = new System.Drawing.Point(288, 52);
			this.lbDrejta.Name = "lbDrejta";
			this.lbDrejta.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbDrejta.Size = new System.Drawing.Size(160, 238);
			this.lbDrejta.TabIndex = 1;
			// 
			// grbModifikimiDrejtave
			// 
			this.grbModifikimiDrejtave.BackColor = System.Drawing.Color.Transparent;
			this.grbModifikimiDrejtave.Controls.Add(this.btnKaloMajtas);
			this.grbModifikimiDrejtave.Controls.Add(this.btnKaloDjathtas);
			this.grbModifikimiDrejtave.Controls.Add(this.lblTeDrejtatPergj);
			this.grbModifikimiDrejtave.Controls.Add(this.lblTeDrejtat);
			this.grbModifikimiDrejtave.Controls.Add(this.lbDrejtaMundshme);
			this.grbModifikimiDrejtave.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grbModifikimiDrejtave.Location = new System.Drawing.Point(10, 8);
			this.grbModifikimiDrejtave.Name = "grbModifikimiDrejtave";
			this.grbModifikimiDrejtave.Size = new System.Drawing.Size(454, 296);
			this.grbModifikimiDrejtave.TabIndex = 0;
			this.grbModifikimiDrejtave.Text = "Modifikimi i te drejtave";
			this.grbModifikimiDrejtave.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// btnKaloMajtas
			// 
			this.btnKaloMajtas.BackColor = System.Drawing.Color.Blue;
			this.btnKaloMajtas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKaloMajtas.DoValidation = false;
			this.btnKaloMajtas.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKaloMajtas.Location = new System.Drawing.Point(180, 128);
			this.btnKaloMajtas.Name = "btnKaloMajtas";
			this.btnKaloMajtas.Size = new System.Drawing.Size(90, 21);
			this.btnKaloMajtas.TabIndex = 4;
			this.btnKaloMajtas.Text = "<< Kalo";
			this.toolTips.SetToolTip(this.btnKaloMajtas, "Heq nje te drejte per perdoruein!");
			this.btnKaloMajtas.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKaloMajtas.Click += new System.EventHandler(this.btnKaloMajtas_Click);
			// 
			// btnKaloDjathtas
			// 
			this.btnKaloDjathtas.BackColor = System.Drawing.Color.Blue;
			this.btnKaloDjathtas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKaloDjathtas.DoValidation = false;
			this.btnKaloDjathtas.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKaloDjathtas.Location = new System.Drawing.Point(180, 84);
			this.btnKaloDjathtas.Name = "btnKaloDjathtas";
			this.btnKaloDjathtas.Size = new System.Drawing.Size(90, 21);
			this.btnKaloDjathtas.TabIndex = 3;
			this.btnKaloDjathtas.Text = "Kalo >>";
			this.toolTips.SetToolTip(this.btnKaloDjathtas, "Shton nje te drejte per perdoruesin!");
			this.btnKaloDjathtas.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKaloDjathtas.Click += new System.EventHandler(this.btnKaloDjathtas_Click);
			// 
			// lblTeDrejtatPergj
			// 
			this.lblTeDrejtatPergj.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblTeDrejtatPergj.Location = new System.Drawing.Point(12, 20);
			this.lblTeDrejtatPergj.Name = "lblTeDrejtatPergj";
			this.lblTeDrejtatPergj.Size = new System.Drawing.Size(216, 20);
			this.lblTeDrejtatPergj.TabIndex = 2;
			this.lblTeDrejtatPergj.Text = "Te drejtat e mundshme te perdoruesit";
			this.lblTeDrejtatPergj.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lblTeDrejtat
			// 
			this.lblTeDrejtat.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblTeDrejtat.Location = new System.Drawing.Point(276, 20);
			this.lblTeDrejtat.Name = "lblTeDrejtat";
			this.lblTeDrejtat.Size = new System.Drawing.Size(156, 20);
			this.lblTeDrejtat.TabIndex = 1;
			this.lblTeDrejtat.Text = "Te drejtat e perdoruesit";
			this.lblTeDrejtat.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lbDrejtaMundshme
			// 
			this.lbDrejtaMundshme.DefaultErrorMessage = null;
			this.lbDrejtaMundshme.IsValid = false;
			this.lbDrejtaMundshme.Location = new System.Drawing.Point(12, 44);
			this.lbDrejtaMundshme.Name = "lbDrejtaMundshme";
			this.lbDrejtaMundshme.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbDrejtaMundshme.Size = new System.Drawing.Size(160, 238);
			this.lbDrejtaMundshme.TabIndex = 0;
			// 
			// btnRuaj
			// 
			this.btnRuaj.BackColor = System.Drawing.Color.Blue;
			this.btnRuaj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRuaj.DoValidation = false;
			this.btnRuaj.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnRuaj.Location = new System.Drawing.Point(44, 316);
			this.btnRuaj.Name = "btnRuaj";
			this.btnRuaj.Size = new System.Drawing.Size(90, 21);
			this.btnRuaj.TabIndex = 3;
			this.btnRuaj.Text = "Ruaj";
			this.toolTips.SetToolTip(this.btnRuaj, "Ruan ndryshimet e bera!");
			this.btnRuaj.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
			// 
			// frmPerdorues
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(680, 432);
			this.Controls.Add(this.tab);
			this.HelpFile = "KONFIGURIMI I PERDORUESVE.htm";
			this.Name = "frmPerdorues";
			this.Text = "Konfigurimi i perdoruesve";
			this.TitullGjeresi = 1011;
			this.Load += new System.EventHandler(this.frmPerdorues_Load);
			this.Activated += new System.EventHandler(this.frmPerdorues_Activated);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.tab, 0);
			this.tab.ResumeLayout(false);
			this.tbPerdorues.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grbModifikoEleminoPerdorues)).EndInit();
			this.grbModifikoEleminoPerdorues.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grbShtoPerdorues)).EndInit();
			this.grbShtoPerdorues.ResumeLayout(false);
			this.tbDrejtat.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grbModifikimiDrejtave)).EndInit();
			this.grbModifikimiDrejtave.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void frmPerdorues_Load(object sender, System.EventArgs e)
		{
			InputController data = new InputController();
			DataSet ds = data.KerkesaRead("ShfaqRolet");
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbRoli.Kolone1.Items.Add(dr[1]);
				this.cmbRoli.Kolone2.Items.Add(dr[0]);
				this.cmbRoliMod.Kolone1.Items.Add(dr[1]);
				this.cmbRoliMod.Kolone2.Items.Add(dr[0]);
			}
			string perd = this.Perdorues;
			ds = data.KerkesaRead("KontrollRolPerdoruesi", this.Perdorues);
			if (ds.Tables[0].Rows.Count > 0)
			{
				if (ds.Tables[0].Rows[0][0].ToString() == "2")
				{
					this.btnKaloDjathtas.Enabled = false;
					this.btnKaloMajtas.Enabled = false;
					this.btnRuaj.Enabled = false;
					this.btnShto.Enabled = false;
					this.btnModifiko.Enabled = false;
					this.btnElemino.Enabled = false;
				}
			}
			RefreshPerdoruesit();
			LoadlbDrejtaMundshme();
			this.LexoXml();
		}

		private void btnShto_Click(object sender, System.EventArgs e)
		{
			string emri = this.txtEmri.Text;
			string mbiemri = this.txtMbiemri.Text;
			string fjalekalimi = this.txtFjalekalimi1.Text;
			string emerPerdoruesi = this.txtEmerPerdoruesi.Text;
			int rolID = Convert.ToInt32(this.cmbRoli.Kolone2Vlere); 
			if (fjalekalimi != this.txtFjalekalimi2.Text)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, "Shtimi i perdoruesve", 
					"Fjalekalimi duhet te shkruhet dy here ne menyre te njejte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.txtFjalekalimi2.Focus();
				return;
			}
			InputController data = new InputController();
			int b = data.KerkesaUpdate("ShtoPerdorues", emri, mbiemri, emerPerdoruesi, fjalekalimi, rolID);
			if (b == 0)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, "Shtimi i perdoruesve", "Perdoruesi i ri u shtua me sukses!",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Pastro(this.grbShtoPerdorues);
				this.RefreshPerdoruesit();
			}
			else if (b == 1)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, "Shtimi i perdoruesve",
					"Ky emer perdoruesi ekziston ne bazen e te dhenave!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.txtEmerPerdoruesi.Focus();
			}
			else if (b == 2)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, "Shtimi i perdoruesve",
					"Perdoruesi i pare qe do te rregjistrohet ne program duhet te kete rolin administrator!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.cmbRoli.Focus();
			}
		}

		private void cmbPerdoruesMod_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			int userID = Convert.ToInt32(this.cmbPerdoruesMod.Kolone2Vlere);
			InputController data = new InputController();
			DataSet ds = data.KerkesaRead("ShfaqTeDhenatPerPerdoruesin", userID);
			this.txtEmerPerdoruesMod.Text = ds.Tables[0].Rows[0][1].ToString();
			this.txtEmriMod.Text = ds.Tables[0].Rows[0][3].ToString();
			this.txtMbiemriMod.Text = ds.Tables[0].Rows[0][5].ToString();
			this.txtFjalekalimiMod.Text = ds.Tables[0].Rows[0][2].ToString();
			this.txtRolVFalse.Text = ds.Tables[0].Rows[0][4].ToString();
			this.cmbRoliMod.Kolone1.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0][4]) - 1;
			this.cmbRoliMod.Kolone2.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[0][4]) - 1;
			this.cmbRoliMod.Kolone1.Text = ds.Tables[0].Rows[0][6].ToString();
		}

		
		private void btnModifiko_Click(object sender, System.EventArgs e)
		{
			if (this.cmbPerdoruesMod.Kolone1Vlere == null)
				return;
			Cursor = Cursors.WaitCursor;
			if (this.txtFjalekalimiMod.Text == "" || this.txtEmerPerdoruesMod.Text == "")
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i perdoruesve", 
					"Fjalekalimi dhe emri i perdoruesit nuk mund te jene bosh!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int userID = Convert.ToInt32(this.cmbPerdoruesMod.Kolone2Vlere);
			string emer = this.txtEmriMod.Text;
			string mbiemer = this.txtMbiemriMod.Text;
			string emerPerdorues1 = this.cmbPerdoruesMod.Kolone1Vlere.ToString();
			string emerPerdorues2 = this.txtEmerPerdoruesMod.Text;
			string fjalekalimi = this.txtFjalekalimiMod.Text;
			int rolID2 = Convert.ToInt32(this.cmbRoliMod.Kolone2Vlere);
			int rolID1 = Convert.ToInt32(this.txtRolVFalse.Text);
			InputController data = new InputController();
			int b = data.KerkesaUpdate("ModifikoPerdorues", userID, rolID1, rolID2, emer, mbiemer, emerPerdorues1, emerPerdorues2, fjalekalimi);
			if (b == 0)
			{
				// Bejme edhe modifikimin ne skedarin Xml Settings.xml te emrit te perdoruesit
				DataSet ds = new DataSet();
				ds.ReadXml(Application.StartupPath + "\\Settings.xml");
				if (ds.Tables[0].Select("Perdorues = '" + emerPerdorues1 + "'").Length > 0)
				{
					DataRow dr = (DataRow)ds.Tables[0].Select( "Perdorues = '" + emerPerdorues1 + "'").GetValue(0);
					dr["Perdorues"] = emerPerdorues2;
					ds.AcceptChanges();
					ds.WriteXml(Application.StartupPath + "\\Settings.xml", XmlWriteMode.WriteSchema);
				}
				VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i perdoruesve", 
					"Te dhenat e perdoruesit u modifikuan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Pastro(this.grbModifikoEleminoPerdorues);
				this.RefreshPerdoruesit();
			}
			else if (b == 1)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, "Modifikimi i perdoruesve", 
					"Ky emer perdoruesi ekziston ne bazen e te dhenave", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.txtEmerPerdoruesMod.Focus();
			}
			else if (b == 2)
			{
				System.Windows.Forms.MessageBox.Show(this, "Modifikimi nuk u krye sepse perdoruesi te cilit doni" +
					"ti ndryshoni emrin eshte i vetmi administrator i programit", "Modifikimi i perdoruesve", MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			Cursor = Cursors.Default;
		}

		private void btnElemino_Click(object sender, System.EventArgs e)
		{
			if (this.cmbPerdoruesMod.Kolone1Vlere == null)
				return;
			DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Eleminimi i perdoruesit",
				"Jeni te sigurte qe doni te eleminoni kete perdorues?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result != DialogResult.Yes)
				return;
			InputController data = new InputController();
			int userID = Convert.ToInt32(this.cmbPerdoruesMod.Kolone2Vlere);
			string user = this.cmbPerdoruesMod.Kolone1Vlere.ToString();
			// Nese perdoruesi qe tentohet te fshihet eshte ai qe ka hapur programin atehere
			// nuk duhet te lejohet qe te fshihet
			if (user == this.Perdorues)
			{
				MessageBox.Show("Nuk mund te fshini perdoruesin qe per momentin ka hapur programin", 
					"Eleminimi i perdoruesit",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int b = data.KerkesaUpdate("EleminoPerdorues", userID);
			if (b == 0)
			{
				this.Pastro(this.grbModifikoEleminoPerdorues);
				VisionInfoSolutionLibrary.MessageBox.Show(this, "Eleminimi i perdoruesit", 
					"Perdoruesi u fshi nga baza e te dhenave!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				DataSet ds = new DataSet();
				ds.ReadXml(Application.StartupPath + "\\Settings.xml");
				if (ds.Tables[0].Select("Perdorues = '" + user + "'").Length > 0)
				{
					// Heqim edhe nga skedari Settings rreshtin e ketij perdoruesi ne menyre
					// qe skedari mos te ngarkohet me te dhena qe nuk duhen
					ds.Tables[0].Rows.Remove((DataRow)ds.Tables[0].Select(
						"Perdorues = '" + user + "'").GetValue(0));
					ds.AcceptChanges();
					ds.WriteXml(Application.StartupPath + "\\Settings.xml", XmlWriteMode.WriteSchema);
				}
			this.RefreshPerdoruesit();
			}
			else if (b == 2)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, "Eleminimi i perdoruesit", 
					"Perdoruesi nuk mund te fshihet sepse eshte i vetmi qe ka rolin administrator ne program", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		/// <summary>
		/// Kur klikohet butoni KaloDjathtas atehere te gjithe elementet e selektuar nga lbDrejtaMundshme hidhen
		/// ne lbDrejta dhe me pas hiqet perzgjedhja nga elementet e lbDrejtaMundshme
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnKaloDjathtas_Click(object sender, System.EventArgs e)
		{
			int selectedCount = this.lbDrejtaMundshme.SelectedIndices.Count;
			int i = 0;
			for (i = 0; i < selectedCount; i++)
			{
				bool uGjet = false;
				for (int j = 0; j < this.lbDrejta.Items.Count; j++)
				{
					if (lbDrejta.Items[j].ToString() == lbDrejtaMundshme.SelectedItems[i].ToString())
					{
						uGjet = true;
						break;
					}
				}
				if (!uGjet)
					this.lbDrejta.Items.Add(this.lbDrejtaMundshme.SelectedItems[i]);
			}
			this.lbDrejta.ClearSelected();
			this.lbDrejtaMundshme.ClearSelected();
			this.HidhXml();
			
		}

		/// <summary>
		/// Fshihen te gjithe elementet e selektuar nga lbDrejta
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnKaloMajtas_Click(object sender, System.EventArgs e)
		{
			while (this.lbDrejta.SelectedItems.Count != 0)
			{
				this.lbDrejta.Items.Remove(this.lbDrejta.SelectedItems[0]);
			}
			this.HidhXml();
		}
		
		/// <summary>
		/// Hedh te dhenat nga lbDhoma ne XML
		/// </summary>
		private void HidhXml()
		{
			string fileName = Application.StartupPath + "\\Konfigurime.xml";
			XmlTextWriter tw = new XmlTextWriter(fileName, null);
			tw.Formatting = Formatting.Indented;
			tw.WriteStartDocument();
			int count = this.lbDrejtaMundshme.Items.Count;
			tw.WriteStartElement("Konfigurime");
			string str = "";
			for (int i = 0; i < this.lbDrejtaMundshme.Items.Count; i++)
			{
				str = FormatString(this.lbDrejtaMundshme.Items[i].ToString());
				string uGjet = "0";
				for (int j = 0; j < this.lbDrejta.Items.Count; j++)
				{
					if (this.lbDrejtaMundshme.Items[i].ToString() == this.lbDrejta.Items[j].ToString())
					{
						uGjet = "1";
						break;
					}
				}
				tw.WriteElementString(str, uGjet);
				
			}
			tw.WriteEndElement();
			tw.WriteEndDocument();
			tw.Flush();
			tw.Close();
		}

		private void btnRuaj_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.HidhXml();
			}
			catch (Exception ex)
			{
				return;
			}
			VisionInfoSolutionLibrary.MessageBox.Show(this, "Konfigurimi i te drejtave",
				"Te drejtat per perdoruesit u ruajten", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Merr si parameter nje string dhe nga i cili te gjitha hapesirat i zevendeson me karakterin '_'
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		private string FormatString(string str)
		{
			string vlera = "";
			string[] str1 = str.Split(' ');
			for (int i = 0; i < str1.Length; i++)
			{
				vlera += str1.GetValue(i);
				if (i < str1.Length - 1)
					vlera += "_";
			}
			return vlera;
		}

		/// <summary>
		/// Merr si parameter nje string dhe te gjitha karakteret '_' i zevendeson me hapesire
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		private string FormatStringAna(string str)
		{
			string vlera = "";
			string[] str1 = str.Split('_');
			for (int i = 0; i < str1.Length; i++)
			{
				vlera += str1.GetValue(i);
				if (i < str1.Length - 1)
					vlera += " ";
			}
			return vlera;
		}

		/// <summary>
		/// Lexon skedarin XML dhe me vlerat e gjetura ben mbushjen e lbDrejta
		/// </summary>
		private void LexoXml()
		{
			bool vlera = false;
			string fileName = Application.StartupPath + "\\Konfigurime.xml";
			XmlTextReader tr = new XmlTextReader(fileName);
			try
			{
				while(tr.Read())
				{
					if (tr.NodeType == XmlNodeType.Text)
					{
						if (tr.Value == "1")
						{
							vlera = true;
						}
						else
							vlera = false;
					}
					else if (tr.NodeType == XmlNodeType.EndElement)
					{
						if (vlera == true)
						{
							this.lbDrejta.Items.Add(FormatStringAna(tr.Name));
							vlera = false;
						}
					}
				}
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			finally
			{
				tr.Close();
			}
		}

		/// <summary>
		/// Merr te dhenat nga databaza dhe i hedh ne cmbPerdorues, pasi me pare ben fshirjen e te gjithe
		/// elementeve nga cmbPerdorues
		/// </summary>
		private void RefreshPerdoruesit()
		{
			this.cmbPerdoruesMod.Kolone1.Items.Clear();
			this.cmbPerdoruesMod.Kolone2.Items.Clear();
			InputController data = new InputController();
			DataSet ds = data.KerkesaRead("ShfaqPerdoruesit");
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbPerdoruesMod.Kolone1.Items.Add(dr[1]);
				this.cmbPerdoruesMod.Kolone2.Items.Add(dr[0]);
			}
		}

		/// <summary>
		/// Hedh te gjitha te drejtat e mundshme qe mund te kete nje perdorues, ne listbox
		/// </summary>
		private void LoadlbDrejtaMundshme()
		{
			this.lbDrejtaMundshme.Items.Add("Shto Rezervime");
			this.lbDrejtaMundshme.Items.Add("Modifiko Fshi Rezervime");
			this.lbDrejtaMundshme.Items.Add("Fut Rezervim ne dhome");
			this.lbDrejtaMundshme.Items.Add("Merr dhome");
			this.lbDrejtaMundshme.Items.Add("Dorezo dhome");
			this.lbDrejtaMundshme.Items.Add("Modifiko Fshi veprim");
			this.lbDrejtaMundshme.Items.Add("Hidh detyrime");
			this.lbDrejtaMundshme.Items.Add("Vizualizimi i gjendjes se dhomave");
			this.lbDrejtaMundshme.Items.Add("Vizualizimi i dhomave te pashlyera");
			this.lbDrejtaMundshme.Items.Add("Vizualizimi i dhomave ne perdorim");
			this.lbDrejtaMundshme.Items.Add("Gjendja ditore e arkes");
			this.lbDrejtaMundshme.Items.Add("Shpenzime");
			this.lbDrejtaMundshme.Items.Add("Bilanci");
			this.lbDrejtaMundshme.Items.Add("Konfigurimi i kategorive");
			this.lbDrejtaMundshme.Items.Add("Konfigurimi i dhomave");
			this.lbDrejtaMundshme.Items.Add("Konfigurimi i cmimeve");
			this.lbDrejtaMundshme.Items.Add("Konfigurimi i identifikimeve");
			this.lbDrejtaMundshme.Items.Add("Konfigurimi i detyrimeve");
			this.lbDrejtaMundshme.Items.Add("Konfigurimi i pagesave");
			this.lbDrejtaMundshme.Items.Add("Hyrje ne Hotel");
			this.lbDrejtaMundshme.Items.Add("Rezervime te vlefshme");
			this.lbDrejtaMundshme.Items.Add("Detyrime");
			this.lbDrejtaMundshme.Items.Add("Hyrje daljet ne hotel");
			this.lbDrejtaMundshme.Items.Add("Alarm");
			this.lbDrejtaMundshme.Items.Add("Perkthime");
			this.lbDrejtaMundshme.Items.Add("Kontrollo sistemin");
		}
		#endregion

		private void frmPerdorues_Activated(object sender, System.EventArgs e)
		{
			this.frmPerdorues_Load(sender, e);
		}

		private void tab_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				if (this.tab.SelectedIndex == 0)
				{
					this.Pastro(this.grbShtoPerdorues);
					this.Pastro(this.grbModifikoEleminoPerdorues);
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

	}
}

