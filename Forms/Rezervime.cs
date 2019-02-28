using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using VisionInfoSolutionLibrary;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment.Forms
{
	/// <summary>
	/// Summary description for Rezervime.
	/// </summary>
	public class Rezervime : VisionInfoSolutionLibrary.Form
	{
		#region Private Variables
		private VisionInfoSolutionLibrary.TabPageControl tabGrup;
		private VisionInfoSolutionLibrary.Button btnRezervo;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.Label label6;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Label label9;
		private VisionInfoSolutionLibrary.Label label10;
		private VisionInfoSolutionLibrary.Label label11;
		private VisionInfoSolutionLibrary.Label label12;
		private VisionInfoSolutionLibrary.Label label13;
		private VisionInfoSolutionLibrary.Label label14;
		private VisionInfoSolutionLibrary.TabPageControl tabGr;
		private VisionInfoSolutionLibrary.Label lblCmimi;
		private VisionInfoSolutionLibrary.Button button4;
		private VisionInfoSolutionLibrary.GroupBox gbCaktim;
		private VisionInfoSolutionLibrary.Button btnDjathtas;
		private VisionInfoSolutionLibrary.Button btnMajas;
		private VisionInfoSolutionLibrary.Label label16;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimiK;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimiK;
		private VisionInfoSolutionLibrary.TextBox txtMbiemri;
		private VisionInfoSolutionLibrary.TextBox txtEmri;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategoria;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDhomat;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategorite;
		private VisionInfoSolutionLibrary.Button btnPagesaKlienti;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.DateTimePicker dtpRezervimiKlienti;
		private VisionInfoSolutionLibrary.DateTimePicker dtpRezervimiGrupi;
		private VisionInfoSolutionLibrary.Label label17;
		private VisionInfoSolutionLibrary.NumericBox numCmimi;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.ListView lvDhomatLira;
		private VisionInfoSolutionLibrary.ListView lvDhomatPerRezervim;
		private System.Windows.Forms.ColumnHeader emriDhoma2;
		private System.Windows.Forms.ColumnHeader cmimiDhoma2;
		private System.Windows.Forms.ColumnHeader idDhoma2;
		private System.Windows.Forms.ColumnHeader emriDhoma1;
		private System.Windows.Forms.ColumnHeader cmimiDhoma1;
		private System.Windows.Forms.ColumnHeader idDhoma1;
		private VisionInfoSolutionLibrary.GroupBox groupBox3;
		private VisionInfoSolutionLibrary.Label label20;
		private VisionInfoSolutionLibrary.TextBox txtGrupi;
		private VisionInfoSolutionLibrary.Label label18;
		private VisionInfoSolutionLibrary.Label lblAgjensia;
		private VisionInfoSolutionLibrary.Button btnElemino;
		private VisionInfoSolutionLibrary.Button btnModifiko;
		private VisionInfoSolutionLibrary.Button btnShto;
		private VisionInfoSolutionLibrary.Label label21;
		private VisionInfoSolutionLibrary.Label label7;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimiG;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimiG;
		private VisionInfoSolutionLibrary.Label label8;
		private VisionInfoSolutionLibrary.DoubleCombo cmbGrupet;
		private VisionInfoSolutionLibrary.DoubleCombo cmbGrupi;
		private VisionInfoSolutionLibrary.TextBox txtAgjensia;
		private VisionInfoSolutionLibrary.NumericBox numKapariKlienti;
		private VisionInfoSolutionLibrary.Button btnPagesaGrupi;
		private VisionInfoSolutionLibrary.Button btnPastro;
		private VisionInfoSolutionLibrary.NumericBox numKapariGrupi;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.DoubleCombo cmbPagesaKlienti;
		private VisionInfoSolutionLibrary.ComboBox comboBox1;
		private VisionInfoSolutionLibrary.ComboBox comboBox2;
		private VisionInfoSolutionLibrary.ComboBox comboBox3;
		private VisionInfoSolutionLibrary.ComboBox comboBox4;
		private VisionInfoSolutionLibrary.ComboBox comboBox7;
		private VisionInfoSolutionLibrary.ComboBox comboBox8;
		private VisionInfoSolutionLibrary.Label label29;
		private VisionInfoSolutionLibrary.ComboBox comboBox5;
		private VisionInfoSolutionLibrary.ComboBox comboBox6;
		private VisionInfoSolutionLibrary.ComboBox comboBox9;
		private VisionInfoSolutionLibrary.ComboBox comboBox10;
		private VisionInfoSolutionLibrary.ComboBox comboBox11;
		private VisionInfoSolutionLibrary.ComboBox comboBox12;
		private VisionInfoSolutionLibrary.ComboBox comboBox13;
		private VisionInfoSolutionLibrary.ComboBox comboBox14;
		private VisionInfoSolutionLibrary.Label label4;
		private VisionInfoSolutionLibrary.DoubleCombo cmbPagesaGrupi;
		private VisionInfoSolutionLibrary.TabControl tab;
		private int nrCmimi= 0;
		private string[] vekKategori;
		private System.Data.DataSet dsDhomaCmime;
		private VisionInfoSolutionLibrary.TextBox txtEmail;
		private VisionInfoSolutionLibrary.Label label15;
		private VisionInfoSolutionLibrary.TextBox txtEmailGrupi;
		private VisionInfoSolutionLibrary.Label label19;
		private int nrDhoma = 0;
		#endregion

		#region Constructors Destructors
		public Rezervime()
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
			this.tab = new VisionInfoSolutionLibrary.TabControl();
			this.tabGrup = new VisionInfoSolutionLibrary.TabPageControl();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.txtEmail = new VisionInfoSolutionLibrary.TextBox();
			this.label15 = new VisionInfoSolutionLibrary.Label();
			this.cmbPagesaKlienti = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox1 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox2 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox3 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox4 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox7 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox8 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.label29 = new VisionInfoSolutionLibrary.Label();
			this.numKapariKlienti = new VisionInfoSolutionLibrary.NumericBox();
			this.numCmimi = new VisionInfoSolutionLibrary.NumericBox();
			this.cmbDhomat = new VisionInfoSolutionLibrary.DoubleCombo();
			this.cmbKategoria = new VisionInfoSolutionLibrary.DoubleCombo();
			this.lblCmimi = new VisionInfoSolutionLibrary.Label();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.label9 = new VisionInfoSolutionLibrary.Label();
			this.label12 = new VisionInfoSolutionLibrary.Label();
			this.dtpRezervimiKlienti = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label10 = new VisionInfoSolutionLibrary.Label();
			this.dtpMbarimiK = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpFillimiK = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label11 = new VisionInfoSolutionLibrary.Label();
			this.txtMbiemri = new VisionInfoSolutionLibrary.TextBox();
			this.label13 = new VisionInfoSolutionLibrary.Label();
			this.label14 = new VisionInfoSolutionLibrary.Label();
			this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.btnRezervo = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnPagesaKlienti = new VisionInfoSolutionLibrary.Button(this.components);
			this.tabGr = new VisionInfoSolutionLibrary.TabPageControl();
			this.btnPagesaGrupi = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnElemino = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifiko = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnShto = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox3 = new VisionInfoSolutionLibrary.GroupBox();
			this.txtEmailGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.label19 = new VisionInfoSolutionLibrary.Label();
			this.cmbGrupet = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label20 = new VisionInfoSolutionLibrary.Label();
			this.txtGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.label18 = new VisionInfoSolutionLibrary.Label();
			this.txtAgjensia = new VisionInfoSolutionLibrary.TextBox();
			this.lblAgjensia = new VisionInfoSolutionLibrary.Label();
			this.gbCaktim = new VisionInfoSolutionLibrary.GroupBox();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.btnPastro = new VisionInfoSolutionLibrary.Button(this.components);
			this.lvDhomatLira = new VisionInfoSolutionLibrary.ListView(this.components);
			this.emriDhoma1 = new System.Windows.Forms.ColumnHeader();
			this.cmimiDhoma1 = new System.Windows.Forms.ColumnHeader();
			this.idDhoma1 = new System.Windows.Forms.ColumnHeader();
			this.cmbKategorite = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label16 = new VisionInfoSolutionLibrary.Label();
			this.btnMajas = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnDjathtas = new VisionInfoSolutionLibrary.Button(this.components);
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.lvDhomatPerRezervim = new VisionInfoSolutionLibrary.ListView(this.components);
			this.emriDhoma2 = new System.Windows.Forms.ColumnHeader();
			this.cmimiDhoma2 = new System.Windows.Forms.ColumnHeader();
			this.idDhoma2 = new System.Windows.Forms.ColumnHeader();
			this.button4 = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbPagesaGrupi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox5 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox6 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox9 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox10 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox11 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox12 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox13 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox14 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.numKapariGrupi = new VisionInfoSolutionLibrary.NumericBox();
			this.cmbGrupi = new VisionInfoSolutionLibrary.DoubleCombo();
			this.label7 = new VisionInfoSolutionLibrary.Label();
			this.dtpMbarimiG = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpFillimiG = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label8 = new VisionInfoSolutionLibrary.Label();
			this.label21 = new VisionInfoSolutionLibrary.Label();
			this.dtpRezervimiGrupi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label17 = new VisionInfoSolutionLibrary.Label();
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.dsDhomaCmime = new System.Data.DataSet();
			this.tab.SuspendLayout();
			this.tabGrup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.cmbPagesaKlienti.SuspendLayout();
			this.tabGr.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbCaktim)).BeginInit();
			this.gbCaktim.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.cmbPagesaGrupi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsDhomaCmime)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1024, 25);
			// 
			// tab
			// 
			this.tab.Controls.Add(this.tabGrup);
			this.tab.Controls.Add(this.tabGr);
			this.tab.Cursor = System.Windows.Forms.Cursors.Default;
			this.tab.Location = new System.Drawing.Point(0, 25);
			this.tab.Name = "tab";
			this.tab.Padding = new System.Drawing.Point(0, 0);
			this.tab.SelectedIndex = 0;
			this.tab.Size = new System.Drawing.Size(1011, 609);
			this.tab.TabIndex = 1;
			this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
			// 
			// tabGrup
			// 
			this.tabGrup.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tabGrup.Controls.Add(this.groupBox2);
			this.tabGrup.Controls.Add(this.btnRezervo);
			this.tabGrup.Controls.Add(this.btnPagesaKlienti);
			this.tabGrup.DefaultErrorMessage = null;
			this.tabGrup.EnableValidation = true;
			this.tabGrup.IsValid = false;
			this.tabGrup.Location = new System.Drawing.Point(4, 22);
			this.tabGrup.Name = "tabGrup";
			this.tabGrup.Size = new System.Drawing.Size(1003, 583);
			this.tabGrup.TabIndex = 0;
			this.tabGrup.Text = "Individuale";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.txtEmail);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.cmbPagesaKlienti);
			this.groupBox2.Controls.Add(this.label29);
			this.groupBox2.Controls.Add(this.numKapariKlienti);
			this.groupBox2.Controls.Add(this.numCmimi);
			this.groupBox2.Controls.Add(this.cmbDhomat);
			this.groupBox2.Controls.Add(this.cmbKategoria);
			this.groupBox2.Controls.Add(this.lblCmimi);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.dtpRezervimiKlienti);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.dtpMbarimiK);
			this.groupBox2.Controls.Add(this.dtpFillimiK);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.txtMbiemri);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.txtEmri);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(566, 216);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.Text = "Te dhenat per rezervimet individuale";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// txtEmail
			// 
			this.txtEmail.AutoSize = false;
			this.txtEmail.DefaultErrorMessage = "";
			this.txtEmail.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmail.FixedLength = false;
			this.txtEmail.IsValid = true;
			this.txtEmail.Location = new System.Drawing.Point(100, 176);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Required = false;
			this.txtEmail.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmail.Size = new System.Drawing.Size(180, 21);
			this.txtEmail.TabIndex = 6;
			this.txtEmail.Text = "";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(52, 176);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(40, 20);
			this.label15.TabIndex = 100;
			this.label15.Text = "E-mail";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbPagesaKlienti
			// 
			this.cmbPagesaKlienti.BackColor = System.Drawing.Color.Transparent;
			this.cmbPagesaKlienti.Controls.Add(this.comboBox1);
			this.cmbPagesaKlienti.Controls.Add(this.comboBox2);
			this.cmbPagesaKlienti.Controls.Add(this.comboBox3);
			this.cmbPagesaKlienti.Controls.Add(this.comboBox4);
			this.cmbPagesaKlienti.Controls.Add(this.comboBox7);
			this.cmbPagesaKlienti.Controls.Add(this.comboBox8);
			this.cmbPagesaKlienti.DefaultErrorMessage = "Zgjidhni nje prej formave te pagesave!";
			this.cmbPagesaKlienti.IsValid = false;
			this.cmbPagesaKlienti.Kolone1Vlere = null;
			this.cmbPagesaKlienti.Kolone2Vlere = null;
			this.cmbPagesaKlienti.Location = new System.Drawing.Point(368, 144);
			this.cmbPagesaKlienti.Name = "cmbPagesaKlienti";
			this.cmbPagesaKlienti.ReadOnly = false;
			this.cmbPagesaKlienti.Required = true;
			this.cmbPagesaKlienti.Size = new System.Drawing.Size(180, 21);
			this.cmbPagesaKlienti.SkipValidation = false;
			this.cmbPagesaKlienti.TabIndex = 11;
			// 
			// comboBox1
			// 
			this.comboBox1.DefaultErrorMessage = null;
			this.comboBox1.IsValid = false;
			this.comboBox1.Location = new System.Drawing.Point(344, 0);
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
			this.comboBox2.Size = new System.Drawing.Size(184, 21);
			this.comboBox2.TabIndex = 0;
			// 
			// comboBox3
			// 
			this.comboBox3.DefaultErrorMessage = null;
			this.comboBox3.IsValid = false;
			this.comboBox3.Location = new System.Drawing.Point(136, 0);
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
			this.comboBox4.Size = new System.Drawing.Size(180, 21);
			this.comboBox4.TabIndex = 0;
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
			this.label29.Location = new System.Drawing.Point(300, 148);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(60, 20);
			this.label29.TabIndex = 99;
			this.label29.Text = "Pagesa ne";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numKapariKlienti
			// 
			this.numKapariKlienti.AutoSize = false;
			this.numKapariKlienti.DefaultErrorMessage = "Jepni nje vlere per kaparin!";
			this.numKapariKlienti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numKapariKlienti.DigitsAfterDecimalPoint = 0;
			this.numKapariKlienti.FixedLength = false;
			this.numKapariKlienti.IsValid = false;
			this.numKapariKlienti.KeepFocus = false;
			this.numKapariKlienti.Location = new System.Drawing.Point(368, 116);
			this.numKapariKlienti.Name = "numKapariKlienti";
			this.numKapariKlienti.OnlyPositive = true;
			this.numKapariKlienti.Required = true;
			this.numKapariKlienti.RequiredControlColor = System.Drawing.Color.White;
			this.numKapariKlienti.Size = new System.Drawing.Size(180, 21);
			this.numKapariKlienti.TabIndex = 10;
			this.numKapariKlienti.Text = "";
			this.numKapariKlienti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// numCmimi
			// 
			this.numCmimi.AutoSize = false;
			this.numCmimi.DefaultErrorMessage = "Per dhomen e dhene nuk eshte konfiguruar cmimi!";
			this.numCmimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numCmimi.DigitsAfterDecimalPoint = 0;
			this.numCmimi.FixedLength = false;
			this.numCmimi.IsValid = false;
			this.numCmimi.KeepFocus = false;
			this.numCmimi.Location = new System.Drawing.Point(368, 84);
			this.numCmimi.Name = "numCmimi";
			this.numCmimi.OnlyPositive = true;
			this.numCmimi.ReadOnly = true;
			this.numCmimi.Required = true;
			this.numCmimi.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimi.Size = new System.Drawing.Size(180, 21);
			this.numCmimi.TabIndex = 9;
			this.numCmimi.Text = "";
			this.numCmimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// cmbDhomat
			// 
			this.cmbDhomat.BackColor = System.Drawing.Color.Transparent;
			this.cmbDhomat.DefaultErrorMessage = "Duhet te zgjidhni dhomen qe do te rezervoni!";
			this.cmbDhomat.IsValid = false;
			this.cmbDhomat.Kolone1Vlere = null;
			this.cmbDhomat.Kolone2Vlere = null;
			this.cmbDhomat.Location = new System.Drawing.Point(368, 52);
			this.cmbDhomat.Name = "cmbDhomat";
			this.cmbDhomat.ReadOnly = false;
			this.cmbDhomat.Required = true;
			this.cmbDhomat.Size = new System.Drawing.Size(180, 21);
			this.cmbDhomat.SkipValidation = false;
			this.cmbDhomat.TabIndex = 8;
			this.cmbDhomat.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbDhomat_SelectedIndexChanged);
			// 
			// cmbKategoria
			// 
			this.cmbKategoria.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategoria.DefaultErrorMessage = "Zgjidhni nje prej kategorive!";
			this.cmbKategoria.IsValid = false;
			this.cmbKategoria.Kolone1Vlere = null;
			this.cmbKategoria.Kolone2Vlere = null;
			this.cmbKategoria.Location = new System.Drawing.Point(368, 20);
			this.cmbKategoria.Name = "cmbKategoria";
			this.cmbKategoria.ReadOnly = false;
			this.cmbKategoria.Required = true;
			this.cmbKategoria.Size = new System.Drawing.Size(180, 21);
			this.cmbKategoria.SkipValidation = false;
			this.cmbKategoria.TabIndex = 7;
			this.cmbKategoria.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategoria_SelectedIndexChanged);
			// 
			// lblCmimi
			// 
			this.lblCmimi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblCmimi.Location = new System.Drawing.Point(308, 84);
			this.lblCmimi.Name = "lblCmimi";
			this.lblCmimi.Size = new System.Drawing.Size(52, 20);
			this.lblCmimi.TabIndex = 47;
			this.lblCmimi.Text = "Cmimi";
			this.lblCmimi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(308, 56);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(52, 20);
			this.label1.TabIndex = 45;
			this.label1.Text = "Dhoma";
			// 
			// label9
			// 
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label9.Location = new System.Drawing.Point(296, 24);
			this.label9.Name = "label9";
			this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label9.Size = new System.Drawing.Size(64, 20);
			this.label9.TabIndex = 43;
			this.label9.Text = "Kategorite";
			// 
			// label12
			// 
			this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label12.Location = new System.Drawing.Point(304, 116);
			this.label12.Name = "label12";
			this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label12.Size = new System.Drawing.Size(56, 20);
			this.label12.TabIndex = 5;
			this.label12.Text = "Kapari";
			// 
			// dtpRezervimiKlienti
			// 
			this.dtpRezervimiKlienti.BackColor = System.Drawing.Color.White;
			this.dtpRezervimiKlienti.CustomFormat = "dd.MM.yyyy";
			this.dtpRezervimiKlienti.DefaultErrorMessage = "";
			this.dtpRezervimiKlienti.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpRezervimiKlienti.IsValid = true;
			this.dtpRezervimiKlienti.Location = new System.Drawing.Point(100, 84);
			this.dtpRezervimiKlienti.Name = "dtpRezervimiKlienti";
			this.dtpRezervimiKlienti.Required = true;
			this.dtpRezervimiKlienti.ShowCheckBox = true;
			this.dtpRezervimiKlienti.ShowUpDown = true;
			this.dtpRezervimiKlienti.Size = new System.Drawing.Size(180, 20);
			this.dtpRezervimiKlienti.TabIndex = 3;
			this.dtpRezervimiKlienti.Value = new System.DateTime(2005, 7, 22, 10, 14, 0, 0);
			// 
			// label10
			// 
			this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label10.Location = new System.Drawing.Point(12, 148);
			this.label10.Name = "label10";
			this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label10.Size = new System.Drawing.Size(80, 20);
			this.label10.TabIndex = 42;
			this.label10.Text = "Date mbarimi";
			// 
			// dtpMbarimiK
			// 
			this.dtpMbarimiK.BackColor = System.Drawing.Color.White;
			this.dtpMbarimiK.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpMbarimiK.DefaultErrorMessage = "Ju duhet te zgjidhni nje vlere";
			this.dtpMbarimiK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimiK.IsValid = true;
			this.dtpMbarimiK.Location = new System.Drawing.Point(100, 148);
			this.dtpMbarimiK.Name = "dtpMbarimiK";
			this.dtpMbarimiK.Required = true;
			this.dtpMbarimiK.ShowCheckBox = true;
			this.dtpMbarimiK.ShowUpDown = true;
			this.dtpMbarimiK.Size = new System.Drawing.Size(180, 20);
			this.dtpMbarimiK.TabIndex = 5;
			this.dtpMbarimiK.Value = new System.DateTime(2005, 5, 30, 16, 30, 0, 0);
			this.dtpMbarimiK.ValueChanged += new System.EventHandler(this.dtpMbarimiK_ValueChanged);
			// 
			// dtpFillimiK
			// 
			this.dtpFillimiK.BackColor = System.Drawing.Color.White;
			this.dtpFillimiK.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpFillimiK.DefaultErrorMessage = "Ju duhet te zgjidhni nje date per fillimin e rezervimit";
			this.dtpFillimiK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimiK.IsValid = true;
			this.dtpFillimiK.Location = new System.Drawing.Point(100, 116);
			this.dtpFillimiK.Name = "dtpFillimiK";
			this.dtpFillimiK.Required = true;
			this.dtpFillimiK.ShowCheckBox = true;
			this.dtpFillimiK.ShowUpDown = true;
			this.dtpFillimiK.Size = new System.Drawing.Size(180, 20);
			this.dtpFillimiK.TabIndex = 4;
			this.dtpFillimiK.Value = new System.DateTime(2005, 5, 30, 16, 30, 0, 0);
			this.dtpFillimiK.ValueChanged += new System.EventHandler(this.dtpFillimiK_ValueChanged);
			// 
			// label11
			// 
			this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label11.Location = new System.Drawing.Point(16, 116);
			this.label11.Name = "label11";
			this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label11.Size = new System.Drawing.Size(76, 20);
			this.label11.TabIndex = 39;
			this.label11.Text = "Date fillimi";
			// 
			// txtMbiemri
			// 
			this.txtMbiemri.AutoSize = false;
			this.txtMbiemri.DefaultErrorMessage = "Ju duhet te jepni mbiemrin e klientit!";
			this.txtMbiemri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemri.FixedLength = false;
			this.txtMbiemri.IsValid = false;
			this.txtMbiemri.Location = new System.Drawing.Point(100, 52);
			this.txtMbiemri.Name = "txtMbiemri";
			this.txtMbiemri.Required = true;
			this.txtMbiemri.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemri.Size = new System.Drawing.Size(180, 21);
			this.txtMbiemri.TabIndex = 2;
			this.txtMbiemri.Text = "";
			// 
			// label13
			// 
			this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label13.Location = new System.Drawing.Point(28, 52);
			this.label13.Name = "label13";
			this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label13.Size = new System.Drawing.Size(64, 20);
			this.label13.TabIndex = 3;
			this.label13.Text = "Mbiemri";
			// 
			// label14
			// 
			this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label14.Location = new System.Drawing.Point(24, 24);
			this.label14.Name = "label14";
			this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label14.Size = new System.Drawing.Size(68, 20);
			this.label14.TabIndex = 0;
			this.label14.Text = "Emri";
			// 
			// txtEmri
			// 
			this.txtEmri.AutoSize = false;
			this.txtEmri.DefaultErrorMessage = "Ju duhet te jepni emrin e klientit!";
			this.txtEmri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri.FixedLength = false;
			this.txtEmri.IsValid = false;
			this.txtEmri.Location = new System.Drawing.Point(100, 20);
			this.txtEmri.Name = "txtEmri";
			this.txtEmri.Required = true;
			this.txtEmri.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri.Size = new System.Drawing.Size(180, 21);
			this.txtEmri.TabIndex = 1;
			this.txtEmri.Text = "";
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(0, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 20);
			this.label3.TabIndex = 53;
			this.label3.Text = "Data e rezervimit";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnRezervo
			// 
			this.btnRezervo.BackColor = System.Drawing.Color.Blue;
			this.btnRezervo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRezervo.DoValidation = true;
			this.btnRezervo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnRezervo.Location = new System.Drawing.Point(52, 236);
			this.btnRezervo.Name = "btnRezervo";
			this.btnRezervo.Size = new System.Drawing.Size(90, 21);
			this.btnRezervo.TabIndex = 13;
			this.btnRezervo.Text = "Rezervo";
			this.toolTips.SetToolTip(this.btnRezervo, "Shton nje rezervim me te dhenat e caktuara!");
			this.btnRezervo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnRezervo.Click += new System.EventHandler(this.btnRezervo_Click);
			// 
			// btnPagesaKlienti
			// 
			this.btnPagesaKlienti.BackColor = System.Drawing.Color.Blue;
			this.btnPagesaKlienti.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPagesaKlienti.DoValidation = true;
			this.btnPagesaKlienti.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnPagesaKlienti.Location = new System.Drawing.Point(412, 236);
			this.btnPagesaKlienti.Name = "btnPagesaKlienti";
			this.btnPagesaKlienti.Size = new System.Drawing.Size(104, 21);
			this.btnPagesaKlienti.TabIndex = 12;
			this.btnPagesaKlienti.Text = "Llogarit pagesen";
			this.toolTips.SetToolTip(this.btnPagesaKlienti, "Llogarit paraprakisht pagesen qe duhet te kryhet per dhomen!");
			this.btnPagesaKlienti.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnPagesaKlienti.Click += new System.EventHandler(this.btnPagesaKlienti_Click);
			// 
			// tabGr
			// 
			this.tabGr.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tabGr.Controls.Add(this.btnPagesaGrupi);
			this.tabGr.Controls.Add(this.btnElemino);
			this.tabGr.Controls.Add(this.btnModifiko);
			this.tabGr.Controls.Add(this.btnShto);
			this.tabGr.Controls.Add(this.groupBox3);
			this.tabGr.Controls.Add(this.gbCaktim);
			this.tabGr.Controls.Add(this.button4);
			this.tabGr.Controls.Add(this.groupBox1);
			this.tabGr.DefaultErrorMessage = null;
			this.tabGr.EnableValidation = true;
			this.tabGr.IsValid = false;
			this.tabGr.Location = new System.Drawing.Point(4, 22);
			this.tabGr.Name = "tabGr";
			this.tabGr.Size = new System.Drawing.Size(1003, 583);
			this.tabGr.TabIndex = 1;
			this.tabGr.Text = "Ne Grup";
			// 
			// btnPagesaGrupi
			// 
			this.btnPagesaGrupi.BackColor = System.Drawing.Color.Blue;
			this.btnPagesaGrupi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPagesaGrupi.DoValidation = true;
			this.btnPagesaGrupi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnPagesaGrupi.Location = new System.Drawing.Point(468, 496);
			this.btnPagesaGrupi.Name = "btnPagesaGrupi";
			this.btnPagesaGrupi.Size = new System.Drawing.Size(100, 21);
			this.btnPagesaGrupi.TabIndex = 32;
			this.btnPagesaGrupi.Text = "Llogarit pagesen";
			this.toolTips.SetToolTip(this.btnPagesaGrupi, "Llogarit paraprakisht pagesen qe duhet\r\n te kryeje grupi per dhomat e zgjedhura!");
			this.btnPagesaGrupi.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnPagesaGrupi.Click += new System.EventHandler(this.btnPagesaGrupi_Click_1);
			// 
			// btnElemino
			// 
			this.btnElemino.BackColor = System.Drawing.Color.Blue;
			this.btnElemino.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnElemino.DoValidation = false;
			this.btnElemino.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnElemino.Location = new System.Drawing.Point(316, 88);
			this.btnElemino.Name = "btnElemino";
			this.btnElemino.Size = new System.Drawing.Size(90, 21);
			this.btnElemino.TabIndex = 20;
			this.btnElemino.Text = "Elemino";
			this.toolTips.SetToolTip(this.btnElemino, "Eleminon grupin e zgjedhur!");
			this.btnElemino.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnElemino.Click += new System.EventHandler(this.btnElemino_Click);
			// 
			// btnModifiko
			// 
			this.btnModifiko.BackColor = System.Drawing.Color.Blue;
			this.btnModifiko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifiko.DoValidation = false;
			this.btnModifiko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifiko.Location = new System.Drawing.Point(316, 56);
			this.btnModifiko.Name = "btnModifiko";
			this.btnModifiko.Size = new System.Drawing.Size(90, 21);
			this.btnModifiko.TabIndex = 19;
			this.btnModifiko.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifiko, "Modifikon grupin e zgjedhur!");
			this.btnModifiko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
			// 
			// btnShto
			// 
			this.btnShto.BackColor = System.Drawing.Color.Blue;
			this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShto.DoValidation = false;
			this.btnShto.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShto.Location = new System.Drawing.Point(316, 24);
			this.btnShto.Name = "btnShto";
			this.btnShto.Size = new System.Drawing.Size(90, 21);
			this.btnShto.TabIndex = 18;
			this.btnShto.Text = "Shto";
			this.toolTips.SetToolTip(this.btnShto, "Shton nje grup te ri!");
			this.btnShto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.CausesValidation = false;
			this.groupBox3.Controls.Add(this.txtEmailGrupi);
			this.groupBox3.Controls.Add(this.label19);
			this.groupBox3.Controls.Add(this.cmbGrupet);
			this.groupBox3.Controls.Add(this.label20);
			this.groupBox3.Controls.Add(this.txtGrupi);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.txtAgjensia);
			this.groupBox3.Controls.Add(this.lblAgjensia);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(10, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(294, 136);
			this.groupBox3.TabIndex = 41;
			this.groupBox3.Text = "Konfigurimi i grupeve";
			this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// txtEmailGrupi
			// 
			this.txtEmailGrupi.AutoSize = false;
			this.txtEmailGrupi.DefaultErrorMessage = "";
			this.txtEmailGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmailGrupi.FixedLength = false;
			this.txtEmailGrupi.IsValid = true;
			this.txtEmailGrupi.Location = new System.Drawing.Point(92, 104);
			this.txtEmailGrupi.Name = "txtEmailGrupi";
			this.txtEmailGrupi.Required = false;
			this.txtEmailGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmailGrupi.Size = new System.Drawing.Size(180, 21);
			this.txtEmailGrupi.TabIndex = 17;
			this.txtEmailGrupi.Text = "";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(44, 104);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(40, 20);
			this.label19.TabIndex = 104;
			this.label19.Text = "E-mail";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbGrupet
			// 
			this.cmbGrupet.BackColor = System.Drawing.Color.Transparent;
			this.cmbGrupet.DefaultErrorMessage = null;
			this.cmbGrupet.IsValid = true;
			this.cmbGrupet.Kolone1Vlere = null;
			this.cmbGrupet.Kolone2Vlere = null;
			this.cmbGrupet.Location = new System.Drawing.Point(92, 16);
			this.cmbGrupet.Name = "cmbGrupet";
			this.cmbGrupet.ReadOnly = false;
			this.cmbGrupet.Required = false;
			this.cmbGrupet.Size = new System.Drawing.Size(180, 21);
			this.cmbGrupet.SkipValidation = false;
			this.cmbGrupet.TabIndex = 14;
			this.cmbGrupet.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbGrupet_SelectedIndexChanged);
			// 
			// label20
			// 
			this.label20.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label20.Location = new System.Drawing.Point(12, 48);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(72, 20);
			this.label20.TabIndex = 58;
			this.label20.Text = "Emri i grupit";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtGrupi
			// 
			this.txtGrupi.AutoSize = false;
			this.txtGrupi.DefaultErrorMessage = "Ju duhet te jepni emrin e grupit!";
			this.txtGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtGrupi.FixedLength = false;
			this.txtGrupi.IsValid = true;
			this.txtGrupi.Location = new System.Drawing.Point(92, 48);
			this.txtGrupi.Name = "txtGrupi";
			this.txtGrupi.Required = false;
			this.txtGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtGrupi.Size = new System.Drawing.Size(180, 21);
			this.txtGrupi.TabIndex = 15;
			this.txtGrupi.Text = "";
			// 
			// label18
			// 
			this.label18.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label18.Location = new System.Drawing.Point(40, 20);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(44, 20);
			this.label18.TabIndex = 54;
			this.label18.Text = "Grupi";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAgjensia
			// 
			this.txtAgjensia.AutoSize = false;
			this.txtAgjensia.DefaultErrorMessage = "Ju duhet te percaktoni emrin e agjensise!";
			this.txtAgjensia.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAgjensia.FixedLength = false;
			this.txtAgjensia.IsValid = true;
			this.txtAgjensia.Location = new System.Drawing.Point(92, 76);
			this.txtAgjensia.Name = "txtAgjensia";
			this.txtAgjensia.Required = false;
			this.txtAgjensia.RequiredControlColor = System.Drawing.Color.White;
			this.txtAgjensia.Size = new System.Drawing.Size(180, 21);
			this.txtAgjensia.TabIndex = 16;
			this.txtAgjensia.Text = "";
			// 
			// lblAgjensia
			// 
			this.lblAgjensia.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblAgjensia.Location = new System.Drawing.Point(28, 76);
			this.lblAgjensia.Name = "lblAgjensia";
			this.lblAgjensia.Size = new System.Drawing.Size(56, 20);
			this.lblAgjensia.TabIndex = 56;
			this.lblAgjensia.Text = "Agjensia";
			this.lblAgjensia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbCaktim
			// 
			this.gbCaktim.BackColor = System.Drawing.Color.Transparent;
			this.gbCaktim.Controls.Add(this.label2);
			this.gbCaktim.Controls.Add(this.btnPastro);
			this.gbCaktim.Controls.Add(this.lvDhomatLira);
			this.gbCaktim.Controls.Add(this.cmbKategorite);
			this.gbCaktim.Controls.Add(this.label16);
			this.gbCaktim.Controls.Add(this.btnMajas);
			this.gbCaktim.Controls.Add(this.btnDjathtas);
			this.gbCaktim.Controls.Add(this.label5);
			this.gbCaktim.Controls.Add(this.lvDhomatPerRezervim);
			this.gbCaktim.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbCaktim.Location = new System.Drawing.Point(10, 268);
			this.gbCaktim.Name = "gbCaktim";
			this.gbCaktim.Size = new System.Drawing.Size(582, 216);
			this.gbCaktim.TabIndex = 14;
			this.gbCaktim.Text = "Caktimi i dhomave";
			this.gbCaktim.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(92, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 16);
			this.label2.TabIndex = 53;
			this.label2.Text = "Dhomat e lira per rezervim";
			// 
			// btnPastro
			// 
			this.btnPastro.BackColor = System.Drawing.Color.Blue;
			this.btnPastro.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPastro.DoValidation = false;
			this.btnPastro.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnPastro.Location = new System.Drawing.Point(492, 16);
			this.btnPastro.Name = "btnPastro";
			this.btnPastro.Size = new System.Drawing.Size(68, 21);
			this.btnPastro.TabIndex = 34;
			this.btnPastro.Text = "Pastro";
			this.btnPastro.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnPastro.Click += new System.EventHandler(this.btnPastro_Click);
			// 
			// lvDhomatLira
			// 
			this.lvDhomatLira.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						   this.emriDhoma1,
																						   this.cmimiDhoma1,
																						   this.idDhoma1});
			this.lvDhomatLira.DefaultErrorMessage = "";
			this.lvDhomatLira.FullRowSelect = true;
			this.lvDhomatLira.GridLines = true;
			this.lvDhomatLira.IsValid = true;
			this.lvDhomatLira.Location = new System.Drawing.Point(92, 68);
			this.lvDhomatLira.Name = "lvDhomatLira";
			this.lvDhomatLira.Size = new System.Drawing.Size(180, 130);
			this.lvDhomatLira.TabIndex = 28;
			// 
			// emriDhoma1
			// 
			this.emriDhoma1.Text = "Emri i dhomes";
			this.emriDhoma1.Width = 100;
			// 
			// cmimiDhoma1
			// 
			this.cmimiDhoma1.Text = "Cmimi";
			this.cmimiDhoma1.Width = 58;
			// 
			// idDhoma1
			// 
			this.idDhoma1.Text = "idDhoma";
			this.idDhoma1.Width = 0;
			// 
			// cmbKategorite
			// 
			this.cmbKategorite.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategorite.DefaultErrorMessage = "Ju duhet te zgjidhni kategorine e dhomave per rezervim!";
			this.cmbKategorite.IsValid = false;
			this.cmbKategorite.Kolone1Vlere = null;
			this.cmbKategorite.Kolone2Vlere = null;
			this.cmbKategorite.Location = new System.Drawing.Point(92, 20);
			this.cmbKategorite.Name = "cmbKategorite";
			this.cmbKategorite.ReadOnly = false;
			this.cmbKategorite.Required = true;
			this.cmbKategorite.Size = new System.Drawing.Size(180, 22);
			this.cmbKategorite.SkipValidation = false;
			this.cmbKategorite.TabIndex = 27;
			this.cmbKategorite.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategorite_SelectedIndexChanged);
			// 
			// label16
			// 
			this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label16.Location = new System.Drawing.Point(384, 52);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(160, 16);
			this.label16.TabIndex = 44;
			this.label16.Text = "Dhomat qe do te rezervohen";
			// 
			// btnMajas
			// 
			this.btnMajas.BackColor = System.Drawing.Color.Blue;
			this.btnMajas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMajas.DoValidation = false;
			this.btnMajas.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnMajas.Location = new System.Drawing.Point(280, 128);
			this.btnMajas.Name = "btnMajas";
			this.btnMajas.Size = new System.Drawing.Size(90, 21);
			this.btnMajas.TabIndex = 31;
			this.btnMajas.Text = "<<<Kalo";
			this.toolTips.SetToolTip(this.btnMajas, "Heq dhomat e zgjedhura nga lista e dhomave\r\nqe pritet te rezervohen nga grupi!");
			this.btnMajas.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnMajas.Click += new System.EventHandler(this.btnMajas_Click);
			// 
			// btnDjathtas
			// 
			this.btnDjathtas.BackColor = System.Drawing.Color.Blue;
			this.btnDjathtas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDjathtas.DoValidation = false;
			this.btnDjathtas.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDjathtas.Location = new System.Drawing.Point(280, 96);
			this.btnDjathtas.Name = "btnDjathtas";
			this.btnDjathtas.Size = new System.Drawing.Size(90, 21);
			this.btnDjathtas.TabIndex = 29;
			this.btnDjathtas.Text = "Kalo>>>";
			this.toolTips.SetToolTip(this.btnDjathtas, "Shton dhomat e zgjedhura ne listen e dhomave\r\nqe priten te rezervohen nga grupi!");
			this.btnDjathtas.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnDjathtas.Click += new System.EventHandler(this.btnDjathtas_Click);
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(28, 24);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label5.Size = new System.Drawing.Size(56, 20);
			this.label5.TabIndex = 37;
			this.label5.Text = "Kategorite";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lvDhomatPerRezervim
			// 
			this.lvDhomatPerRezervim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																								  this.emriDhoma2,
																								  this.cmimiDhoma2,
																								  this.idDhoma2});
			this.lvDhomatPerRezervim.DefaultErrorMessage = "Ju duhet te zgjidhni dhomat perpara se te kryeni rezervimin!";
			this.lvDhomatPerRezervim.FullRowSelect = true;
			this.lvDhomatPerRezervim.GridLines = true;
			this.lvDhomatPerRezervim.IsValid = true;
			this.lvDhomatPerRezervim.Location = new System.Drawing.Point(380, 68);
			this.lvDhomatPerRezervim.Name = "lvDhomatPerRezervim";
			this.lvDhomatPerRezervim.Size = new System.Drawing.Size(180, 130);
			this.lvDhomatPerRezervim.TabIndex = 30;
			// 
			// emriDhoma2
			// 
			this.emriDhoma2.Text = "Emri i dhomes";
			this.emriDhoma2.Width = 100;
			// 
			// cmimiDhoma2
			// 
			this.cmimiDhoma2.Text = "Cmimi";
			this.cmimiDhoma2.Width = 58;
			// 
			// idDhoma2
			// 
			this.idDhoma2.Width = 0;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Blue;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.DoValidation = true;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Location = new System.Drawing.Point(36, 492);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(88, 21);
			this.button4.TabIndex = 33;
			this.button4.Text = "Rezervo";
			this.toolTips.SetToolTip(this.button4, "Shton rezervimin e grupit per dhomat e zgjedhura!");
			this.button4.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.cmbPagesaGrupi);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.numKapariGrupi);
			this.groupBox1.Controls.Add(this.cmbGrupi);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.dtpMbarimiG);
			this.groupBox1.Controls.Add(this.dtpFillimiG);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.dtpRezervimiGrupi);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(10, 152);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(582, 112);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.Text = "Te dhenat per rezervimet ne grup";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbPagesaGrupi
			// 
			this.cmbPagesaGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cmbPagesaGrupi.Controls.Add(this.comboBox5);
			this.cmbPagesaGrupi.Controls.Add(this.comboBox6);
			this.cmbPagesaGrupi.Controls.Add(this.comboBox9);
			this.cmbPagesaGrupi.Controls.Add(this.comboBox10);
			this.cmbPagesaGrupi.Controls.Add(this.comboBox11);
			this.cmbPagesaGrupi.Controls.Add(this.comboBox12);
			this.cmbPagesaGrupi.Controls.Add(this.comboBox13);
			this.cmbPagesaGrupi.Controls.Add(this.comboBox14);
			this.cmbPagesaGrupi.DefaultErrorMessage = "Vendosni formen e pageses!";
			this.cmbPagesaGrupi.IsValid = false;
			this.cmbPagesaGrupi.Kolone1Vlere = null;
			this.cmbPagesaGrupi.Kolone2Vlere = null;
			this.cmbPagesaGrupi.Location = new System.Drawing.Point(380, 76);
			this.cmbPagesaGrupi.Name = "cmbPagesaGrupi";
			this.cmbPagesaGrupi.ReadOnly = false;
			this.cmbPagesaGrupi.Required = true;
			this.cmbPagesaGrupi.Size = new System.Drawing.Size(180, 21);
			this.cmbPagesaGrupi.SkipValidation = false;
			this.cmbPagesaGrupi.TabIndex = 26;
			// 
			// comboBox5
			// 
			this.comboBox5.DefaultErrorMessage = null;
			this.comboBox5.IsValid = false;
			this.comboBox5.Location = new System.Drawing.Point(356, 0);
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
			this.comboBox6.Size = new System.Drawing.Size(184, 21);
			this.comboBox6.TabIndex = 0;
			// 
			// comboBox9
			// 
			this.comboBox9.DefaultErrorMessage = null;
			this.comboBox9.IsValid = false;
			this.comboBox9.Location = new System.Drawing.Point(344, 0);
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
			this.comboBox10.Size = new System.Drawing.Size(184, 21);
			this.comboBox10.TabIndex = 0;
			// 
			// comboBox11
			// 
			this.comboBox11.DefaultErrorMessage = null;
			this.comboBox11.IsValid = false;
			this.comboBox11.Location = new System.Drawing.Point(136, 0);
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
			this.comboBox12.Size = new System.Drawing.Size(180, 21);
			this.comboBox12.TabIndex = 0;
			// 
			// comboBox13
			// 
			this.comboBox13.DefaultErrorMessage = null;
			this.comboBox13.IsValid = false;
			this.comboBox13.Location = new System.Drawing.Point(60, 0);
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
			this.comboBox14.Size = new System.Drawing.Size(180, 21);
			this.comboBox14.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(312, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 20);
			this.label4.TabIndex = 101;
			this.label4.Text = "Pagesa ne";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numKapariGrupi
			// 
			this.numKapariGrupi.AutoSize = false;
			this.numKapariGrupi.DefaultErrorMessage = "Jepni nje vlere per kaparin!";
			this.numKapariGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numKapariGrupi.DigitsAfterDecimalPoint = 0;
			this.numKapariGrupi.FixedLength = false;
			this.numKapariGrupi.IsValid = false;
			this.numKapariGrupi.KeepFocus = false;
			this.numKapariGrupi.Location = new System.Drawing.Point(380, 48);
			this.numKapariGrupi.Name = "numKapariGrupi";
			this.numKapariGrupi.OnlyPositive = true;
			this.numKapariGrupi.Required = true;
			this.numKapariGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.numKapariGrupi.Size = new System.Drawing.Size(180, 20);
			this.numKapariGrupi.TabIndex = 25;
			this.numKapariGrupi.Text = "";
			this.numKapariGrupi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// cmbGrupi
			// 
			this.cmbGrupi.BackColor = System.Drawing.Color.Transparent;
			this.cmbGrupi.DefaultErrorMessage = "Ju duhet te zgjidhni grupin perpara se te kryeni nje rezervim!";
			this.cmbGrupi.IsValid = false;
			this.cmbGrupi.Kolone1Vlere = null;
			this.cmbGrupi.Kolone2Vlere = null;
			this.cmbGrupi.Location = new System.Drawing.Point(92, 20);
			this.cmbGrupi.Name = "cmbGrupi";
			this.cmbGrupi.ReadOnly = false;
			this.cmbGrupi.Required = true;
			this.cmbGrupi.Size = new System.Drawing.Size(180, 21);
			this.cmbGrupi.SkipValidation = false;
			this.cmbGrupi.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label7.Location = new System.Drawing.Point(4, 80);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label7.Size = new System.Drawing.Size(80, 20);
			this.label7.TabIndex = 75;
			this.label7.Text = "Date mbarimi";
			// 
			// dtpMbarimiG
			// 
			this.dtpMbarimiG.BackColor = System.Drawing.Color.White;
			this.dtpMbarimiG.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpMbarimiG.DefaultErrorMessage = "Duhet te zgjidhni nje vlere";
			this.dtpMbarimiG.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimiG.IsValid = true;
			this.dtpMbarimiG.Location = new System.Drawing.Point(92, 80);
			this.dtpMbarimiG.Name = "dtpMbarimiG";
			this.dtpMbarimiG.Required = true;
			this.dtpMbarimiG.ShowCheckBox = true;
			this.dtpMbarimiG.ShowUpDown = true;
			this.dtpMbarimiG.Size = new System.Drawing.Size(180, 20);
			this.dtpMbarimiG.TabIndex = 23;
			this.dtpMbarimiG.Value = new System.DateTime(2005, 5, 30, 16, 30, 0, 0);
			this.dtpMbarimiG.ValueChanged += new System.EventHandler(this.dtpMbarimiG_ValueChanged);
			// 
			// dtpFillimiG
			// 
			this.dtpFillimiG.BackColor = System.Drawing.Color.White;
			this.dtpFillimiG.CustomFormat = "dd.MM.yyyy/HH:mm";
			this.dtpFillimiG.DefaultErrorMessage = "Ju duhet te zgjidhni nje date per fillimin e rezervimit";
			this.dtpFillimiG.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimiG.IsValid = false;
			this.dtpFillimiG.Location = new System.Drawing.Point(92, 52);
			this.dtpFillimiG.Name = "dtpFillimiG";
			this.dtpFillimiG.Required = true;
			this.dtpFillimiG.ShowCheckBox = true;
			this.dtpFillimiG.ShowUpDown = true;
			this.dtpFillimiG.Size = new System.Drawing.Size(180, 20);
			this.dtpFillimiG.TabIndex = 22;
			this.dtpFillimiG.Value = new System.DateTime(2005, 5, 30, 16, 30, 0, 0);
			this.dtpFillimiG.ValueChanged += new System.EventHandler(this.dtpFillimiG_ValueChanged);
			// 
			// label8
			// 
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label8.Location = new System.Drawing.Point(20, 52);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label8.Size = new System.Drawing.Size(64, 20);
			this.label8.TabIndex = 72;
			this.label8.Text = "Date fillimi";
			// 
			// label21
			// 
			this.label21.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label21.Location = new System.Drawing.Point(40, 24);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(44, 20);
			this.label21.TabIndex = 70;
			this.label21.Text = "Grupi";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpRezervimiGrupi
			// 
			this.dtpRezervimiGrupi.BackColor = System.Drawing.Color.White;
			this.dtpRezervimiGrupi.CustomFormat = "dd.MM.yyyy";
			this.dtpRezervimiGrupi.DefaultErrorMessage = "";
			this.dtpRezervimiGrupi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpRezervimiGrupi.IsValid = true;
			this.dtpRezervimiGrupi.Location = new System.Drawing.Point(380, 20);
			this.dtpRezervimiGrupi.Name = "dtpRezervimiGrupi";
			this.dtpRezervimiGrupi.Required = false;
			this.dtpRezervimiGrupi.ShowCheckBox = true;
			this.dtpRezervimiGrupi.ShowUpDown = true;
			this.dtpRezervimiGrupi.Size = new System.Drawing.Size(180, 20);
			this.dtpRezervimiGrupi.TabIndex = 24;
			this.dtpRezervimiGrupi.Value = new System.DateTime(2005, 7, 22, 10, 11, 0, 0);
			// 
			// label17
			// 
			this.label17.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label17.Location = new System.Drawing.Point(284, 20);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(88, 20);
			this.label17.TabIndex = 55;
			this.label17.Text = "Data e rezervimit";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Location = new System.Drawing.Point(312, 48);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label6.Size = new System.Drawing.Size(60, 20);
			this.label6.TabIndex = 36;
			this.label6.Text = "Kapari";
			// 
			// dsDhomaCmime
			// 
			this.dsDhomaCmime.DataSetName = "NewDataSet";
			this.dsDhomaCmime.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// Rezervime
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CheckRequiredFields = true;
			this.ClientSize = new System.Drawing.Size(1024, 652);
			this.Controls.Add(this.tab);
			this.ControlsBackColor = System.Drawing.Color.White;
			this.DefaultErrorMessage = "Gabim i panjohur!";
			this.HelpFile = "SHTO REZERVIM.html";
			this.IsValid = true;
			this.Name = "Rezervime";
			this.RequiredControlsBackColor = System.Drawing.Color.LemonChiffon;
			this.Text = "Rezervime";
			this.TitullGjeresi = 1024;
			this.Load += new System.EventHandler(this.Rezervime_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.tab, 0);
			this.tab.ResumeLayout(false);
			this.tabGrup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.cmbPagesaKlienti.ResumeLayout(false);
			this.tabGr.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbCaktim)).EndInit();
			this.gbCaktim.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.cmbPagesaGrupi.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsDhomaCmime)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region FormLoad
		private void Rezervime_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				//pastrim variablash private
				this.nrCmimi= 0;
				this.vekKategori = null;
				this.nrDhoma = 0;
				this.dsDhomaCmime = new DataSet();
				this.dsDhomaCmime.Tables.Add();
				this.dsDhomaCmime.Tables[0].Columns.Add("ID_KATEGORIA", typeof(Int32));
				this.dsDhomaCmime.Tables[0].Columns.Add("CMIMI", typeof(Int32));
				this.dsDhomaCmime.Tables[0].Columns.Add("DHOMA_EMRI", typeof(String));
				this.dsDhomaCmime.AcceptChanges();
				//pastrim variablash private
				DataSet ds = null;
				this.dtpRezervimiKlienti.Text = System.DateTime.Now.ToString();
				this.dtpRezervimiGrupi.Text = System.DateTime.Now.ToString();
				this.dtpFillimiK.Text  = System.DateTime.Now.ToString();
				this.dtpMbarimiK.Text  = System.DateTime.Now.ToString();
				this.dtpFillimiG.Text  = System.DateTime.Now.ToString();
				this.dtpMbarimiG.Text  = System.DateTime.Now.ToString();
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqKategorite");
				// Percaktojme gjatesine e vektorit qe mbaje vlerat e idKategori-se
				int nrRreshta = ds.Tables[0].Rows.Count;
				vekKategori = new string[nrRreshta];
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					this.cmbKategoria.Kolone1.Items.Add(dr[1]);
					this.cmbKategoria.Kolone2.Items.Add(dr[0]);
					this.cmbKategorite.Kolone1.Items.Add(dr[1]);
					this.cmbKategorite.Kolone2.Items.Add(dr[0]);
				}
				this.MbushGrupet();
				this.MbushPagesat();
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
				if (this.tab.SelectedIndex == 0)//klienti
				{
					this.Pastro(this.groupBox2);
					this.cmbPagesaKlienti.Kolone1.Text = "Cash";
					this.cmbPagesaKlienti.Kolone1Vlere = "Cash";
					this.cmbPagesaKlienti.Kolone2.Text = "1";
					this.cmbPagesaKlienti.Kolone2Vlere = "1";
				}
				else// grupi
				{
					this.Pastro(this.groupBox3);
					this.Pastro(this.groupBox1);
					this.Pastro(this.gbCaktim);
					this.lvDhomatLira.Items.Clear();
					this.lvDhomatPerRezervim.Items.Clear();
					this.dsDhomaCmime.Tables[0].Rows.Clear();
					this.cmbPagesaGrupi.Kolone1.Text = "Cash";
					this.cmbPagesaGrupi.Kolone1Vlere = "Cash";
					this.cmbPagesaGrupi.Kolone2.Text = "1";
					this.cmbPagesaGrupi.Kolone2Vlere = "1";
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

		#region ShtoRezervimKlienti

		private void btnRezervo_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimiK.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimiK.Value);
				DateTime dtRezervimi =Convert.ToDateTime(this.dtpRezervimiKlienti.Value);
				//kontrolli per datat eshte bere nje here kur eshte zgjedhur kategoria
				if (this.KontrolloDatatPerRezervim(dtFillimi, dtRezervimi) == 1)//data e rezervimit nuk eshte e rregullt
				{
					dtpRezervimiKlienti.IsValid = false;
					System.Windows.Forms.MessageBox.Show(this, "Data e rezervimit nuk mund te jete me e madhe se data e fillimit te rezervimit!" + Environment.NewLine + "Ju lutem kryeni modifikimet e nevojshme para se te beni  rezervimin!", "Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				dtpRezervimiKlienti.IsValid = true;
				//mbetet te behet kontrolli per kaparin
				int idKategoria = Convert.ToInt32(this.cmbKategoria.Kolone2Vlere);
				string emri= this.txtEmri.Text;
				string mbiemri = this.txtMbiemri.Text;
				int idDhoma = Convert.ToInt32(this.cmbDhomat.Kolone2Vlere);
				int kapari = Convert.ToInt32(this.numKapariKlienti.Text);
				if (kapari < 0)
				{
					this.error.SetError(this.numKapariKlienti, "Kapari nuk mund te jete negativ!");
					return;
				}
				this.error.SetError(this.numKapariKlienti, "");
				InputController data = new InputController();
				DataSet dsCmimi = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma , dtFillimi);
				int cmimi = Convert.ToInt32(dsCmimi.Tables[0].Rows[0][0]);
				int pagesa = this.GjejPagesen(idKategoria, cmimi, dtFillimi, dtMbarimi);
				if (kapari > pagesa)
				{
					System.Windows.Forms.MessageBox.Show(this, "Kapari nuk mund te jete me i madh se pagesa per dhomen!", "Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				int idFormaPagesa = Convert.ToInt32(this.cmbPagesaKlienti.Kolone2Vlere);
				string emaili = this.txtEmail.Text;
				int b = data.KerkesaUpdate("KrijoRezervimKlienti", emri, mbiemri, kapari, idDhoma, dtFillimi, 
					dtMbarimi ,dtRezervimi,idFormaPagesa, emaili, this.PerdoruesId);
				if (b == 0)
				{
					this.Pastro(this.tabGrup);
					System.Windows.Forms.MessageBox.Show(this, "Rezervimi per klientin u shtua!", "Rezervime", 
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, "Rezervimi per klientin nuk u shtua! Provoni perseri!", "Rezervime", 
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
		private void cmbDhomat_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				DataSet ds = null ;
				this.numCmimi.Text = "";
				int idDhoma = Convert.ToInt32(this.cmbDhomat.Kolone2Vlere);
				DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimiK.Value);
				DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimiK.Value);
				DateTime dataRezervimi = Convert.ToDateTime(this.dtpRezervimiKlienti.Value);
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqCmimPerDhomenDheDatatEdhena", idDhoma, dataFillimi, dataMbarimi);
				if(ds.Tables[0].Rows.Count == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Per dhomen e zgjedhur nuk eshte konfiguruar cmimi. Ju "
						+ "lutemi konfiguroni me pare cmimin e dhomes.", "Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
 	
		private void cmbKategoria_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				DataSet ds = null;
				this.cmbDhomat.Kolone1.Items.Clear();
				this.cmbDhomat.Kolone2.Items.Clear();
				this.cmbDhomat.Kolone1.Text = "";
				this.cmbDhomat.Kolone2.Text = "";
				this.numCmimi.Text = "";
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimiK.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimiK.Value);
				int idKategoria = Convert.ToInt32(this.cmbKategoria.Kolone2Vlere);
				int a = this.KntData(idKategoria,dtFillimi,dtMbarimi);
				if(a == 0)
				{
					InputController data = new InputController();
					this.dtpFillimiK.IsValid = true;
					this.error.SetError(this.dtpFillimiK,"");
					ds = data.KerkesaRead("ShfaqDhomatPlotesishtTeLiraPerDatatPerKategorine", idKategoria, dtFillimi, dtMbarimi);
					foreach(DataRow dr in ds.Tables[0].Rows)
					{
						this.cmbDhomat.Kolone1.Items.Add(dr[1]);
						this.cmbDhomat.Kolone2.Items.Add(dr[0]);
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
								"Ju lutemi konfiguroni cmimin ose zgjidhni nje kategori tjeter!","Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							this.cmbKategoria.Kolone1.Text = "";
							this.mbushKategorite();
							return;
						}
						else
							b = 3;
					}
				
					if(b == 3)
					{
						System.Windows.Forms.MessageBox.Show(this,"Per kategorine e zgjedhur,nuk ka dhoma"+Environment.NewLine+
							"te lira."+Environment.NewLine+
							Environment.NewLine+
							"Ju lutemi zgjidhni nje kategori tjeter!","Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.cmbKategoria.Kolone1.Text = "";
						this.mbushKategorite();
						return;
					}
				}
				else
				{
					this.dtpFillimiK.IsValid = false;
					this.error.SetError(this.dtpFillimiK, "Data e hyrjes se klientit duhet te jete me e vogel se data e daljes!");
					this.cmbKategoria.Kolone1.Text = "";
					this.mbushKategorite();
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

		private void btnPagesaKlienti_Click(object sender, System.EventArgs e)
		{
			try
			{
				InputController data = new InputController();
				int idKategoria = Convert.ToInt32(this.cmbKategoria.Kolone2Vlere);
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimiK.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimiK.Value);
				int kapari = Convert.ToInt32(this.numKapariKlienti.Text);
				if (kapari < 0)
				{
					this.error.SetError(this.numKapariKlienti, "Kapari nuk mund te jete negativ!");
					return;
				}
				this.error.SetError(this.numKapariKlienti, "");
				int idDhoma = Convert.ToInt32(this.cmbDhomat.Kolone2Vlere);
				DataSet dsCmimi = data.KerkesaRead("CmimiDhomesPerDaten", idDhoma , dtFillimi);
				int cmimi = Convert.ToInt32(dsCmimi.Tables[0].Rows[0][0]);
				DataSet dsPagesa = this.GjejPagesenDs(idKategoria, cmimi, dtFillimi, dtMbarimi);
				int pagesa = Convert.ToInt32(dsPagesa.Tables[0].Rows[0]["PAGESA"]);
				if (kapari > pagesa)
				{
					System.Windows.Forms.MessageBox.Show(this, "Kapari nuk mund te jete me i madh se pagesa per dhomen!", "Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				else
				{
					int pagesaMeKapar = pagesa - kapari;
					string dite = dsPagesa.Tables[0].Rows[0]["DITE"].ToString() + dsPagesa.Tables[0].Rows[0]["LLOJI"].ToString();
					string koment = "Pagesa per dhomen per " + dite + " eshte " +  pagesaMeKapar;
					koment += Environment.NewLine + dite + " x " + cmimi + " - " + kapari + " = " + pagesaMeKapar;
					System.Windows.Forms.MessageBox.Show(this, koment, "Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		
		private void dtpFillimiK_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				cmbKategoria.Kolone1.Text = "";
				cmbKategoria.Kolone2.Text = "";
				cmbDhomat.Kolone1.Text = "";
				cmbDhomat.Kolone2.Text = "";
				cmbDhomat.Kolone1.Items.Clear();
				cmbDhomat.Kolone2.Items.Clear();
				numCmimi.Text = "";
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

		private void dtpMbarimiK_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				cmbKategoria.Kolone1.Text = "";
				cmbKategoria.Kolone2.Text = "";
				cmbDhomat.Kolone1.Text = "";
				cmbDhomat.Kolone2.Text = "";
				cmbDhomat.Kolone1.Items.Clear();
				cmbDhomat.Kolone2.Items.Clear();
				numCmimi.Text = "";
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

		#region ShtoRezervimGrupi
		
		private void cmbKategorite_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				DataSet ds = null;
				this.lvDhomatLira.Items.Clear();
				this.lvDhomatLira.Width = 162;
				DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimiG.Value);
				DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimiG.Value);
				int idKategoriaG = Convert.ToInt32(this.cmbKategorite.Kolone2Vlere);
				int a = this.KntData(idKategoriaG,dtFillimi,dtMbarimi);
				if(a == 0)
				{
					this.dtpFillimiG.IsValid = true;
					this.error.SetError(this.dtpFillimiG,"");
					InputController data = new InputController();
					ds = data.KerkesaRead("ShfaqDhomatPlotesishtTeLiraPerDatatPerKategorine", idKategoriaG,dtFillimi,dtMbarimi);
					int b = 0;
					if(ds.Tables[0].Rows.Count == 0)
					{
						b = this.KntKonfCmimDhome(idKategoriaG,dtFillimi);
						if(b == 0)
						{
							System.Windows.Forms.MessageBox.Show(this,"Ne daten e hyrjes se klientit, per dhomat e kategorise se zgjedhur"+Environment.NewLine+
								"ju nuk keni konfiguruar cmimet."+Environment.NewLine+
								Environment.NewLine+
								"Ju lutemi konfiguroni cmimin ose zgjidhni nje kategori tjeter!","Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
						else
							b = 3;
					}
					if(b == 3)
					{
						System.Windows.Forms.MessageBox.Show(this,"Per kategorine e zgjedhur,nuk ka dhoma"+Environment.NewLine+
							"te lira."+Environment.NewLine+
							Environment.NewLine+
							"Ju lutemi zgjidhni nje kategori tjeter!","Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.cmbKategorite.Kolone1.Text = "";
						this.mbushKategoriteG();
						return;
					}
					this.LoadList(ds);
				
				}
				else
				{
					this.dtpFillimiG.IsValid = false;
					this.error.SetError(this.dtpFillimiG, "Data e hyrjes se klientit duhet te jete me e vogel se data e daljes!");
					this.cmbKategorite.Kolone1.Text = "";
					this.mbushKategoriteG();
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
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
	
//		private void button4_Click(object sender, System.EventArgs e)
//		{ 
//			this.Cursor = Cursors.WaitCursor;
//			try
//			{
//				DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimiG.Value);
//				DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimiG.Value);
//				DateTime dataRezervimi = Convert.ToDateTime(this.dtpRezervimiGrupi.Value);
//				int idGrupi = Convert.ToInt32(this.cmbGrupi.Kolone2Vlere);
//				if (this.KontrolloDatatPerRezervim(dataFillimi, dataRezervimi) == 1)
//				{
//					System.Windows.Forms.MessageBox.Show(this, "Data e rezervimit nuk mund te jete me e madhe se data e fillimit te rezervimit!" + Environment.NewLine + "Ju lutem kryeni modifikimet e nevojshme para se te beni  rezervimin!", "Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Error);
//					return;
//				}
//				if (this.KontrolloGrupinPerRezervim(idGrupi, dataFillimi, dataMbarimi) == 1)
//					return;
//				int idKategoriaG = Convert.ToInt32(this.cmbKategorite.Kolone2Vlere);
//				int a = this.KntData(idKategoriaG,dataFillimi,dataMbarimi);
//				if(a == 0)
//				{
//					int kapariGrupi = Convert.ToInt32(this.numKapariGrupi.Text);
//					if (kapariGrupi < 0)
//					{
//						this.error.SetError(this.numKapariGrupi, "Kapari nuk mund te jete negativ!");
//						return;
//					}
//					this.error.SetError(this.numKapariGrupi, "");
//					if ((kapariGrupi > 0)&&(this.cmbPagesaGrupi.Kolone1.SelectedItem == null))
//					{
//						this.error.SetError(this.cmbPagesaGrupi, "Zgjidhni formen e pageses!");
//						return;
//					}
//					this.error.SetError(this.cmbPagesaGrupi, "");
//					int idFormaPagesa = 0;
//					if (kapariGrupi > 0)
//						idFormaPagesa = Convert.ToInt32(this.cmbPagesaGrupi.Kolone2Vlere);
//					int c = this.KontrolloDhomeCmimGrupi();
//					if (c == 0)
//					{
//					
//						int[] dhoma = new int[this.lvDhomatPerRezervim.Items.Count];
//						for (int i = 0; i < dhoma.Length; i++)
//							dhoma.SetValue(Convert.ToInt32(lvDhomatPerRezervim.Items[i].SubItems[2].Text), i);
//						InputController data = new InputController();
//						DateTime dataKapari = dataRezervimi.AddMilliseconds(DateTime.Now.Millisecond);
//					
//						int b = data.KerkesaUpdate("KrijoRezervimGrupi", idGrupi, kapariGrupi, dhoma, 
//							dataFillimi, dataMbarimi ,dataRezervimi,dataKapari, idFormaPagesa);
//						if( b == 0)
//							System.Windows.Forms.MessageBox.Show(this, "Rezervimi per  grupin u shtua!", "Rezervime",
//								MessageBoxButtons.OK, MessageBoxIcon.Information);
//						this.RefreshShtoRezervimGrupi();
//					}
//					else if(c == 1||c == 2)
//					{
//						string strDhoma;
//						if(nrDhoma == 1)
//							strDhoma = " nuk eshte e lire.";
//						else
//							strDhoma = " nuk jane te lira";
//						System.Windows.Forms.MessageBox.Show(this, "Kujdes, ndryshimi i datave pasi eshte zgjedhur dhoma"+
//							Environment.NewLine+"duhet shoqeruar me nje rizgjedhje te saj per datat e reja."
//							+Environment.NewLine+"nje ose me shume nga dhomat e zgjedhura, nuk eshte e lire."
//							, "Rezervime",
//							MessageBoxButtons.OK, MessageBoxIcon.Information);
//					
//						this.lvDhomatPerRezervim.Items.Clear();
//				
//						this.lvDhomatLira.Items.Clear();
//						this.cmbKategorite.Kolone1.Text = "";
//						this.mbushKategoriteG();
//					
//						return;
//
//					}
//					else if(c == 3)
//					{
//						string strCmimi= "";
//						if(nrCmimi == 1)
//							strCmimi =" nga cmimet e dhomave eshte i ndryshem.";
//						else
//							strCmimi =" nga cmimet e dhomave jane te ndryshem.";
//						System.Windows.Forms.MessageBox.Show(this, "Kujdes, ndryshimi i datave pasi eshte zgjedhur dhoma"+
//							Environment.NewLine+"duhet shoqeruar me nje rizgjedhje te saj per datat e reja."+
//							Environment.NewLine+"Per datat e dhena, nje ose me shume prej dhomave kane cmim te ndryshem." , "Rezervime",
//							MessageBoxButtons.OK, MessageBoxIcon.Information);
//					
//						this.lvDhomatPerRezervim.Items.Clear();
//						this.lvDhomatLira.Items.Clear();
//						this.cmbKategorite.Kolone1.Text = "";
//						this.mbushKategoriteG();
//						return;
//					}
//					
//				}
//				else
//				{
//					this.dtpFillimiG.IsValid = false;
//					this.error.SetError(this.dtpFillimiG, "Data e hyrjes se klientit duhet te jete me e vogel se data e daljes!");
//					this.cmbKategorite.Kolone1.Text = "";
//					this.mbushKategoriteG();
//					return;
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
		private void button4_Click(object sender, System.EventArgs e)
		{ 
			this.Cursor = Cursors.WaitCursor;
			try
			{
				DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimiG.Value);
				DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimiG.Value);
				DateTime dataRezervimi = Convert.ToDateTime(this.dtpRezervimiGrupi.Value);
				int idGrupi = Convert.ToInt32(this.cmbGrupi.Kolone2Vlere);
				if (this.KontrolloDatatPerRezervim(dataFillimi, dataRezervimi) == 1)
				{
					System.Windows.Forms.MessageBox.Show(this, "Data e rezervimit nuk mund te jete me e madhe se data e fillimit te rezervimit!" + Environment.NewLine + "Ju lutem kryeni modifikimet e nevojshme para se te beni  rezervimin!", "Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (this.KontrolloGrupinPerRezervim(idGrupi, dataFillimi, dataMbarimi) == 1)
					return;
				int idKategoriaG = Convert.ToInt32(this.cmbKategorite.Kolone2Vlere);
				int kapariGrupi = Convert.ToInt32(this.numKapariGrupi.Text);
				if (kapariGrupi < 0)
				{
					this.error.SetError(this.numKapariGrupi, "Kapari nuk mund te jete negativ!");
					return;
				}
				this.error.SetError(this.numKapariGrupi, "");
				//duhet bere kontrolli i kaparit
				int pagesa = this.GjejPagesen(dataFillimi, dataMbarimi);
				if (kapariGrupi > pagesa)
				{
					System.Windows.Forms.MessageBox.Show(this, "Kapari i dhene rezulton me i madh se pagesa per dhomat!" + Environment.NewLine 
						+ "Kryeni modifikimet e nevojshme!", "Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				int idFormaPagesa = Convert.ToInt32(this.cmbPagesaGrupi.Kolone2Vlere);
				int[] dhoma = new int[this.lvDhomatPerRezervim.Items.Count];
				for (int i = 0; i < dhoma.Length; i++)
					dhoma.SetValue(Convert.ToInt32(lvDhomatPerRezervim.Items[i].SubItems[2].Text), i);
				InputController data = new InputController();
				DateTime dataKapari = dataRezervimi.AddMilliseconds(DateTime.Now.Millisecond); 
				int b = data.KerkesaUpdate("KrijoRezervimGrupi", idGrupi, kapariGrupi, dhoma, 
					dataFillimi, dataMbarimi ,dataRezervimi, idFormaPagesa, this.PerdoruesId);
				if( b == 0)
					System.Windows.Forms.MessageBox.Show(this, "Rezervimi per  grupin u shtua!", "Rezervime",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.RefreshShtoRezervimGrupi();
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
		private void btnDjathtas_Click(object sender, System.EventArgs e)
		{
			try
			{
				int selectedCount = this.lvDhomatLira.SelectedIndices.Count;
				int i = 0;
				this.lvDhomatPerRezervim.View = View.Details;
				for (i = 0; i < selectedCount; i++)
				{
					// Percakto listItems
					ListViewItem lvi = new ListViewItem(this.lvDhomatLira.SelectedItems[i].Text);
					lvi.SubItems.Add(this.lvDhomatLira.SelectedItems[i].SubItems[1].Text);
					lvi.SubItems.Add(this.lvDhomatLira.SelectedItems[i].SubItems[2].Text);
					this.lvDhomatPerRezervim.Items.Add(lvi);
					//PER TE MBUSHUR DATASETIN ME CMIME
					DataRow newrow = this.dsDhomaCmime.Tables[0].NewRow();
					newrow["ID_KATEGORIA"] = Convert.ToInt32(this.cmbKategorite.Kolone2Vlere);
					newrow["CMIMI"] = Convert.ToInt32(this.lvDhomatLira.SelectedItems[i].SubItems[1].Text);
					newrow["DHOMA_EMRI"] = this.lvDhomatLira.SelectedItems[i].Text;
					this.dsDhomaCmime.Tables[0].Rows.Add(newrow);
				}
				this.dsDhomaCmime.AcceptChanges();
				i = 0;
				while (this.lvDhomatLira.SelectedItems.Count > 0)
				{
					ListViewItem lvi = new ListViewItem(this.lvDhomatLira.SelectedItems[i].Text);
					this.lvDhomatLira.Items.RemoveAt(this.lvDhomatLira.SelectedIndices[i]);
				}
				this.lvDhomatLira.Refresh();
				this.lvDhomatPerRezervim.Refresh();
				int nr = this.lvDhomatLira.Items.Count;
				if (nr> 7)
				{
					this.lvDhomatLira.Width = 180;
				}
				else
				{
					this.lvDhomatLira.Width = 162;
				}
				nr = this.lvDhomatPerRezervim.Items.Count;
				if (nr> 7)
				{
					this.lvDhomatPerRezervim.Width = 180;
				}
				else
				{
					this.lvDhomatPerRezervim.Width = 162;
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

		private void btnMajas_Click(object sender, System.EventArgs e)
		{
			try
			{
				int selectedCount = this.lvDhomatPerRezervim.SelectedIndices.Count;
				int i = 0;
				this.lvDhomatPerRezervim.View = View.Details;
				for (i = 0; i < selectedCount; i++)
				{
					// Percakto listItems
					ListViewItem lvi = new ListViewItem(this.lvDhomatPerRezervim.SelectedItems[i].Text);
					lvi.SubItems.Add(this.lvDhomatPerRezervim.SelectedItems[i].SubItems[1].Text);
					lvi.SubItems.Add(this.lvDhomatPerRezervim.SelectedItems[i].SubItems[2].Text);
					string DhomaEmri = Convert.ToString(this.lvDhomatPerRezervim.SelectedItems[i].Text);
					int idKategoria = 0;
					foreach(DataRow drow in this.dsDhomaCmime.Tables[0].Rows)
					{
						if (Convert.ToString(drow["DHOMA_EMRI"]) == DhomaEmri)
						{
							idKategoria = Convert.ToInt32(drow["ID_KATEGORIA"]);
							drow.Delete();
							break;
						}
					}
					this.dsDhomaCmime.AcceptChanges();
					if (idKategoria == Convert.ToInt32(cmbKategorite.Kolone2Vlere))
						this.lvDhomatLira.Items.Add(lvi);
				}
				i = 0;
				while (this.lvDhomatPerRezervim.SelectedItems.Count > 0)
				{
					ListViewItem lvi = new ListViewItem(this.lvDhomatPerRezervim.SelectedItems[i].Text);
					this.lvDhomatPerRezervim.Items.RemoveAt(this.lvDhomatPerRezervim.SelectedIndices[i]);
				}
				this.lvDhomatLira.Refresh();
				this.lvDhomatPerRezervim.Refresh();
				int nr = this.lvDhomatLira.Items.Count;
				if (nr> 7)
				{
					this.lvDhomatLira.Width = 180;
				}
				else
				{
					this.lvDhomatLira.Width = 162;
				}
				nr = this.lvDhomatPerRezervim.Items.Count;
				if (nr > 7)
				{
					this.lvDhomatPerRezervim.Width = 180;
				}
				else
				{
					this.lvDhomatPerRezervim.Width = 162;
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

		private void btnPastro_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.dsDhomaCmime.Tables[0].Rows.Clear();
				this.lvDhomatLira.Items.Clear();
				this.lvDhomatPerRezervim.Items.Clear();
				this.lvDhomatLira.Width = 162;
				this.lvDhomatPerRezervim.Width = 162;
				this.cmbKategorite.Kolone1.Text = "";
				for(int i = 0; i < this.vekKategori.Length; i++)
				{
					this.vekKategori.SetValue(null, i);
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
		
		private void btnPagesaGrupi_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				if (lvDhomatPerRezervim.Items.Count != 0)
				{
					DateTime dataFillimi = Convert.ToDateTime(this.dtpFillimiG.Value);
					DateTime dataMbarimi = Convert.ToDateTime(this.dtpMbarimiG.Value);
					int kapariGrupi = Convert.ToInt32(this.numKapariGrupi.Text);
					if (kapariGrupi < 0)
					{
						this.error.SetError(this.numKapariGrupi, "Kapari nuk mund te jete negativ!");
						return;
					}
					this.error.SetError(this.numKapariGrupi, "");
					DataSet dsPagesa  = this.GjejPagesenDs(dataFillimi, dataMbarimi);
					int nr = dsPagesa.Tables[0].Rows.Count;
					int pagesa = Convert.ToInt32(dsPagesa.Tables[0].Rows[nr - 1]["PAGESA"]);
					int pagesaMeKapar = pagesa - kapariGrupi;
					if (kapariGrupi > pagesa)
					{
						System.Windows.Forms.MessageBox.Show(this, "Kapari i dhene rezulton me i madh se pagesa per dhomat!" + Environment.NewLine 
							+ "Kryeni modifikimet e nevojshme!", "Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					else
					{
						string s = "Pagesa per grupin eshte " + pagesaMeKapar + "!";
						for(int i = 0; i < dsPagesa.Tables[0].Rows.Count - 1; i++)
						{
							DataRow dr = dsPagesa.Tables[0].Rows[i];
							s += Environment.NewLine + (i + 1) + ".  " + dr["DHOMA_EMRI"].ToString() + "   " + dr["INTERVALI"].ToString() + " x " + dr["CMIMI"].ToString() + " = " + dr["PAGESA"].ToString();
						}
						s += Environment.NewLine + "Totali: " + pagesa + " - " + kapariGrupi + " = " + pagesaMeKapar;
						System.Windows.Forms.MessageBox.Show(this, s, "Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
	
		private void cmbGrupet_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				int idGrupi = Convert.ToInt32(this.cmbGrupet.Kolone2Vlere);
				InputController data = new InputController();
				DataSet ds = data.KerkesaRead("ShfaqGrupin", idGrupi);
				DataRow dr = ds.Tables[0].Rows[0];
				this.txtAgjensia.Text = dr[1].ToString();
				this.txtGrupi.Text =  dr[0].ToString();
				this.txtEmailGrupi.Text = dr["EMAILI"].ToString();
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

		private void btnShto_Click(object sender, System.EventArgs e)
		{
			try
			{
				InputController data = new InputController();
				int a = this.ValidateGrupiShto();
				if(a == 0)
				{
					string emerGrupi = this.txtGrupi.Text;
					string emerAgjensia = this.txtAgjensia.Text;
					string emaili = this.txtEmailGrupi.Text;
					int b = data.KerkesaUpdate("KrijoGrup", emerGrupi, emerAgjensia, emaili);
					if (b == 0)
						VisionInfoSolutionLibrary.MessageBox.Show(this, "Rezervime",
							"Grupi u shtua!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					else if(b == 1)
						System.Windows.Forms.MessageBox.Show(this, 
							"Emri i zgjedhur per grupin eshte perdorur me pare."
							+Environment.NewLine+"Ju lutemi zgjidhni nje emer te ri!","Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.txtGrupi.Clear();
					this.txtAgjensia.Clear();
					this.txtEmailGrupi.Text = "";
					this.cmbGrupet.Kolone1.Text = "";
					this.cmbGrupet.Kolone1.Items.Clear();
					this.cmbGrupet.Kolone2.Items.Clear();
					this.cmbGrupi.Kolone1.Items.Clear();
					this.cmbGrupi.Kolone2.Items.Clear();
					this.MbushGrupet();
				}
				else
					return;
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

		private void btnModifiko_Click(object sender, System.EventArgs e)
		{
			try
			{
				int a = this.ValidateGrupiModifiko();
				if (a == 0)
				{
					int c = this.ValidateGrupiShto();
					if(c == 0)
					{
						InputController data = new InputController();
						int idGrupi = Convert.ToInt32(this.cmbGrupet.Kolone2Vlere);
						string grupi = this.txtGrupi.Text;
						string agjensia = this.txtAgjensia.Text;
						string emaili = this.txtEmailGrupi.Text;
						int b  = data.KerkesaUpdate("ModifikoGrup",idGrupi,grupi,agjensia, emaili);
						if(b == 0)
							System.Windows.Forms.MessageBox.Show(this, "Grupi i zgjdhur u modifikua!", "Rezervime",
								MessageBoxButtons.OK, MessageBoxIcon.Information);
						else if(b == 1)
							System.Windows.Forms.MessageBox.Show(this, 
								"Emri i zgjedhur per grupin eshte perdorur me pare."
								+Environment.NewLine+"Ju lutemi zgjidhni nje emer te ri!","Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.txtGrupi.Clear();
						this.txtAgjensia.Clear();
						this.txtEmailGrupi.Text = "";
						this.cmbGrupet.Kolone1.Text = "";
						this.cmbGrupet.Kolone1.Items.Clear();
						this.cmbGrupet.Kolone2.Items.Clear();
						this.cmbGrupi.Kolone1.Items.Clear();
						this.cmbGrupi.Kolone2.Items.Clear();
						this.MbushGrupet();
					}
					else
						return;
				}
				else
					return ;
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
		private void btnElemino_Click(object sender, System.EventArgs e)
		{
			try
			{
				int a = this.ValidateGrupiModifiko();
				if (a == 0)
				{
				
					InputController data = new InputController();
					int idGrupi = Convert.ToInt32(this.cmbGrupet.Kolone2Vlere);
					int b  = data.KerkesaUpdate("FshiGrup",idGrupi);
					if(b == 0)
						System.Windows.Forms.MessageBox.Show(this, "Grupi i zgjedhur u eleminua!", "Rezervime",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
					if( b == 2)
						System.Windows.Forms.MessageBox.Show(this,"Grupi i zgjedhur nuk mund te eleminohet,"
							+Environment.NewLine+"kliente te grupit jane ende ne hotel!","Rezervime",MessageBoxButtons.OK,MessageBoxIcon.Information);
					if(b == 1)
						System.Windows.Forms.MessageBox.Show(this,"Grupi i zgjedhur nuk mund te eleminohet,"
							+Environment.NewLine+"me pare duhet te eliminohen rezervimet e ketij grupi!","Rezervime",MessageBoxButtons.OK,MessageBoxIcon.Information);
					if(b == 3)
						System.Windows.Forms.MessageBox.Show(this,"Grupi i zgjedhur nuk mund te eleminohet,"
							+Environment.NewLine+"me pare duhet te eleminohen klientet e ketij grupi!","Rezervime",MessageBoxButtons.OK,MessageBoxIcon.Information);

					this.txtGrupi.Clear();
					this.txtAgjensia.Clear();
					this.txtEmailGrupi.Text = "";
					this.cmbGrupet.Kolone1.Text = "";
					this.cmbGrupet.Kolone1.Items.Clear();
					this.cmbGrupet.Kolone2.Items.Clear();
					this.cmbGrupi.Kolone1.Items.Clear();
					this.cmbGrupi.Kolone2.Items.Clear();
					this.MbushGrupet();
				}
				else
					return;
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

		private void dtpFillimiG_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				dtpRezervimiGrupi.Value = DateTime.Now;
				lvDhomatLira.Items.Clear();
				lvDhomatPerRezervim.Items.Clear();
				this.dsDhomaCmime.Tables[0].Rows.Clear();
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

		private void dtpMbarimiG_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				dtpRezervimiGrupi.Value = DateTime.Now;
				lvDhomatLira.Items.Clear();
				lvDhomatPerRezervim.Items.Clear();
				this.dsDhomaCmime.Tables[0].Rows.Clear();
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

		#region MetodaNdihmese
		/// <summary>
		/// Gjen pagesen qe duhet te kryhet per dhomen me kategorine e dhene, cmimin dhe intervalin e datave
		/// </summary>
		/// <param name="idKategoria"></param>
		/// <param name="cmimi"></param>
		/// <param name="dtFillimi"></param>
		/// <param name="dtMbarimi"></param>
		/// <returns></returns>
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
		/// <summary>
		/// Gjen pagesen qe duhet te kryhet per dhomen me kategorine e dhene, cmimin dhe intervalin e datave
		/// </summary>
		/// <param name="idKategoria"></param>
		/// <param name="cmimi"></param>
		/// <param name="dtFillimi"></param>
		/// <param name="dtMbarimi"></param>
		/// <returns></returns>
		private DataSet GjejPagesenDs(int idKategoria, int cmimi, DateTime dtFillimi, DateTime dtMbarimi)
		{
			DataSet dsPag = new DataSet();
			dsPag.Tables.Add();
			dsPag.Tables[0].Columns.Add("DITE", typeof(double));
			dsPag.Tables[0].Columns.Add("PAGESA", typeof(Int32));
			dsPag.Tables[0].Columns.Add("LLOJI", typeof(String));
			dsPag.AcceptChanges();
			DataRow r = dsPag.Tables[0].NewRow();
			TimeSpan ts;
			int pagesa;
			if (idKategoria == 31)
			{
				ts = dtMbarimi.Subtract(dtFillimi);
				double ore = ts.TotalHours;
				pagesa = Convert.ToInt32(Math.Round(cmimi * ore, 2));
				r["DITE"] = Math.Round(ore, 2);
				r["PAGESA"] = pagesa;
				r["LLOJI"] = " ore";
			}
			else
			{
				ts = dtMbarimi.Date.Subtract(dtFillimi.Date);
				int dite = ts.Days;
				pagesa = dite * cmimi;
				r["DITE"] = Math.Round(Convert.ToDouble(dite), 0);
				r["PAGESA"] = pagesa;
				r["LLOJI"] = " dite";
			}
			dsPag.Tables[0].Rows.Add(r);
			dsPag.AcceptChanges();
			return dsPag;
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
			foreach(DataRow dr in this.dsDhomaCmime.Tables[0].Rows)
			{
				int cmimi = Convert.ToInt32(dr["CMIMI"]);
				int idKategoria = Convert.ToInt32(dr["ID_KATEGORIA"]);
				pagesa = pagesa + this.GjejPagesen(idKategoria, cmimi, dtFillimi, dtMbarimi);
			}
			return pagesa;
		}

		private DataSet GjejPagesenDs(DateTime dtFillimi, DateTime dtMbarimi)
		{
			DataSet dsPagesa = new DataSet();
			dsPagesa.Tables.Add();
			dsPagesa.Tables[0].Columns.Add("DHOMA_EMRI", typeof(String));
			dsPagesa.Tables[0].Columns.Add("CMIMI", typeof(Int32));
			dsPagesa.Tables[0].Columns.Add("INTERVALI", typeof(String));
			dsPagesa.Tables[0].Columns.Add("PAGESA", typeof(Int32));
			int pagesaTotal  = 0;
			foreach(DataRow dr in this.dsDhomaCmime.Tables[0].Rows)
			{
				DataRow newrow = dsPagesa.Tables[0].NewRow();
				newrow["CMIMI"] = Convert.ToInt32(dr["CMIMI"]);
				newrow["DHOMA_EMRI"] = dr["DHOMA_EMRI"].ToString();
				int cmimi = Convert.ToInt32(dr["CMIMI"]);
				int idKategoria = Convert.ToInt32(dr["ID_KATEGORIA"]);
				TimeSpan ts;
				int pagesa;
				if (idKategoria == 31)
				{
					ts = dtMbarimi.Subtract(dtFillimi);
					double ore = ts.TotalHours;
					pagesa = Convert.ToInt32(Math.Round(cmimi * ore, 2));
					newrow["INTERVALI"] = Math.Round(ore, 2) + " ore";
					newrow["PAGESA"] = pagesa;
				}
				else
				{
					ts = dtMbarimi.Date.Subtract(dtFillimi.Date);
					int dite = ts.Days;
					pagesa = dite * cmimi;
					newrow["INTERVALI"] = dite + " dite";
					newrow["PAGESA"] = pagesa;
				}
				dsPagesa.Tables[0].Rows.Add(newrow);
				pagesaTotal += pagesa;
			}
			DataRow newr = dsPagesa.Tables[0].NewRow();
			newr["PAGESA"] = pagesaTotal;
			dsPagesa.Tables[0].Rows.Add(newr);
			dsPagesa.AcceptChanges();
			return dsPagesa;
		}
		
		private int ValidateGrupiShto()
		{
			int a = 0;
			if(this.txtGrupi.Text == "" )
			{
				this.txtGrupi.IsValid = false;
				this.error.SetError(this.txtGrupi,"Ju duhet te jepni nje emer per grupin e ri, perpara se ta shtoni ate!");
				a = 1;
			}
			else if(this.txtAgjensia.Text == "")
			{
				this.txtAgjensia.IsValid = false;
				this.error.SetError(this.txtAgjensia,"Ju duhet te jepni nje emer per agjensine, perpara se ta shtoni grupin!");
				a = 1;
			}
			else
				return a;
			return a;
		}
				
		private int ValidateGrupiModifiko()
		{
			int a = 0;
			if(this.cmbGrupet.Kolone1.Text == "")
			{
				this.cmbGrupet.IsValid = false;
				this.error.SetError(this.cmbGrupet,"Juduhet te zgjidhni nje prej grupeve ekzistuese!");
				a = 1;
			}
			else
				return a ;
			return a;
		}
		
		private void RefreshShtoRezervimGrupi()
		{
			this.cmbGrupi.Kolone1.Text = "";
			this.numKapariGrupi.Text = "";
			this.dtpRezervimiGrupi.Value = System.DateTime.Now;
			this.dtpFillimiG.Value = System.DateTime.Now;
			this.dtpMbarimiG.Value = System.DateTime.Now;
			this.cmbKategoria.Kolone1.Text = "";
			this.lvDhomatLira.Items.Clear();
			this.lvDhomatPerRezervim.Items.Clear();
			this.lvDhomatLira.Width = 162;
			this.lvDhomatPerRezervim.Width = 162;
			this.cmbPagesaGrupi.Kolone1.Text = "";
			this.cmbPagesaGrupi.Kolone2.Text = "";
			this.cmbKategorite.Kolone1.Text = "";
			this.cmbKategorite.Kolone2.Text = "";
			this.dsDhomaCmime.Tables[0].Rows.Clear();
		}
		private void mbushKategoriteG()
		{
			DataSet ds = null ;
			this.cmbKategorite.Kolone1.Items.Clear();
			this.cmbKategorite.Kolone2.Items.Clear();
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqKategorite");
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbKategorite.Kolone1.Items.Add(dr[1]);
				this.cmbKategorite.Kolone2.Items.Add(dr[0]);
			}
		}
		private void RefreshShtoRezervim()
		{
			this.txtEmri.Text = "";
			this.txtMbiemri.Text = "";
			this.numKapariKlienti.Text = "";
			this.dtpRezervimiKlienti.Value = System.DateTime.Now;
			this.dtpFillimiK.Value = System.DateTime.Now;
			this.dtpMbarimiK.Value = System.DateTime.Now;
			this.cmbKategoria.Kolone1.Text = "";
			this.cmbDhomat.Kolone1.Text= "";
			this.numCmimi.Text = "";
		}
		private void MbushGrupet()
		{
			InputController data = new InputController();
			DataSet ds = null;
			ds = data.KerkesaRead("ShfaqGrupet");
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbGrupet.Kolone1.Items.Add(dr[1]);
				this.cmbGrupet.Kolone2.Items.Add(dr[0]);
				this.cmbGrupi.Kolone1.Items.Add(dr[1]);
				this.cmbGrupi.Kolone2.Items.Add(dr[0]);
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
//		private int KntData(int idKategoria,DateTime dtFillimi,DateTime dtMbarimi )
//		{
//			int a = 0;
//			System.TimeSpan nrDite = dtFillimi.Subtract(dtMbarimi);
//			int difDite = Convert.ToInt32(nrDite.Days);
//			int difOre = Convert.ToInt32(nrDite.Hours);
//			if(idKategoria != 31)
//			{
//				if (difDite >= 0)
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

		private void mbushKategorite()
		{
			DataSet ds = null ;
			this.cmbKategoria.Kolone1.Items.Clear();
			this.cmbKategoria.Kolone2.Items.Clear();
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqKategorite");
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbKategoria.Kolone1.Items.Add(dr[1]);
				this.cmbKategoria.Kolone2.Items.Add(dr[0]);
			}
		}
		private void LoadList(DataSet ds)
		{
			DataTable dTable = ds.Tables[0];
			this.lvDhomatLira.View = View.Details;
			for (int i = 0; i < dTable.Rows.Count; i++)
			{
				// Percakto listItems
				DataRow dr = dTable.Rows[i];
				string dhoma = dr["DHOMA_EMRI"].ToString();
				bool ugjet = false;
				foreach(DataRow r in this.dsDhomaCmime.Tables[0].Rows)
				{
					if (dhoma == r["DHOMA_EMRI"].ToString())
					{
						ugjet = true;
						break;
					}
				}
				if (!ugjet)
				{
					ListViewItem lvi = new ListViewItem(dr[1].ToString());
					lvi.SubItems.Add(dr[4].ToString());
					lvi.SubItems.Add(dr[0].ToString());
					this.lvDhomatLira.Items.Add(lvi);
				}
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
		private double Sum(double []a)
		{
			
			double result = 0;
			int i=0;
			while(i < a.Length)
			{
				result += a[i];
				i++;
			}
			return result;
		}

		private int KontrolloDhomeCmimKlienti()
		{
			DataSet ds = null;
			int a = 3;
			int b = 0;
			DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimiK.Value);
			DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimiK.Value);
			int idKategoria = Convert.ToInt32(this.cmbKategoria.Kolone2Vlere);
			InputController data = new InputController();
			string dhoma = this.cmbDhomat.Kolone1.Text.ToString();
			ds = data.KerkesaRead("ShfaqDhomatPlotesishtTeLiraPerDatatPerKategorine", idKategoria, dtFillimi, dtMbarimi);
			if(ds.Tables[0].Rows.Count == 0)
				a = 1;
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				if(dhoma == dr[1].ToString())
				{
					a = 0 ;
					break;
				}
				else
					a = 2;
			}
			if(a == 0 )
			{
				int	idDhoma = Convert.ToInt32(this.cmbDhomat.Kolone2Vlere);
				int cmimi =Convert.ToInt32(this.numCmimi.Text);
				ds = data.KerkesaRead("ShfaqCmimPerDhomenDheDatatEdhena", idDhoma, dtFillimi, dtMbarimi);
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					if(cmimi == Convert.ToInt32(dr[2]))
					{
						a = 0 ;
						break;
					}
					else
						a = 3;
				}
			}
			return a;
		}
		
		private int KontrolloDhomeCmimGrupi()
		{
			DataSet ds = null;
			
			int a = 3;
			DateTime dtFillimi = Convert.ToDateTime(this.dtpFillimiG.Value);
			DateTime dtMbarimi = Convert.ToDateTime(this.dtpMbarimiG.Value);
			int idKategoria = Convert.ToInt32(this.cmbKategorite.Kolone2Vlere);
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqDhomatPlotesishtTeLiraPerDatatPerKategorine", idKategoria, dtFillimi, dtMbarimi);
			if(ds.Tables[0].Rows.Count == 0)
				a = 1;
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				for(int i = 0;i<this.lvDhomatPerRezervim.Items.Count;i++)
				{
					if(this.lvDhomatPerRezervim.Items[i].SubItems[0].Text == dr[1].ToString())
					{
						a = 0 ;
						goto A;
					}
				
					else
						a = 2;
				}
			}
			
			A:if(a == 0 )
			  {
				  int	[] idDhoma= new int[this.lvDhomatPerRezervim.Items.Count]; 
				  for(int i =0;i<this.lvDhomatPerRezervim.Items.Count;i++ )
				  {
					  idDhoma[i]= Convert.ToInt32(this.lvDhomatPerRezervim.Items[i].SubItems[2].Text);
					  ds = data.KerkesaRead("ShfaqCmimPerDhomenDheDatatEdhena", idDhoma[i], dtFillimi, dtMbarimi);
					  if(this.lvDhomatPerRezervim.Items[i].SubItems[1].Text == ds.Tables[0].Rows[0][2].ToString())
					  {
						  a = 0 ;
						  goto B;
					  }
					  else
						  a = 3;
				
				  }
				
			  }
			B:return a;
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
		private int KontrolloGrupinPerRezervim(int idGrupi, DateTime dtFillimi, DateTime dtMbarimi)
		{
			InputController data  = new InputController();
			//Kontroll1
			//kontrollojme nqs ka rezervime per datat e dhena per grupin ne fjale te zgjedhur
			//ne rast se po nuk mund te kryhet nje hyrje per keto data
			DataSet dsRezervime = data.KerkesaRead("RezervimetPerDatatDheGrupin", idGrupi, dtFillimi, dtFillimi);
			if (dsRezervime.Tables[0].Rows.Count != 0)
			{
				string s = "Grupi ka nje rezervim ne hotel per intervalin e datave";
				foreach(DataRow rz in dsRezervime.Tables[0].Rows)
				{
					s += Environment.NewLine + this.konverto(Convert.ToDateTime(rz["DATA_FILLIMI"])) + " dhe " + this.konverto(Convert.ToDateTime(rz["DATA_MBARIMI"]));
				}
				s += Environment.NewLine + "Nuk mund te beni rezervim ne emer te ketij grupi per datat e  dhena!";
				System.Windows.Forms.MessageBox.Show(this, s, "Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 1;
			}
			//Kontroll 2
			//kontrollojme nqs ka hyrje per datat e dhena per grupin e zgjedhur
			DataSet dsHyrje = data.KerkesaRead("ShfaqVeprimetPerGrupin", idGrupi,-1, dtFillimi, dtMbarimi);
			if (dsHyrje.Tables.Count == 2)
			{
				string s1 = "Grupi ka nje hyrje ne hotel per intervalin e datave";
				foreach(DataRow rh in dsHyrje.Tables["KLIENTI"].Rows)
				{
					s1 += Environment.NewLine + this.konverto(Convert.ToDateTime(rh["MINDATA"])) + " dhe " + this.konverto(Convert.ToDateTime(rh["MAXDATA"]));
				}
				s1 += Environment.NewLine + "Nuk mund te beni rezervim ne emer te ketij grupi per datat e  dhena!";
				System.Windows.Forms.MessageBox.Show(this, s1, "Rezervime", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 1;
			}
			return 0;
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
		#endregion

	}
}
