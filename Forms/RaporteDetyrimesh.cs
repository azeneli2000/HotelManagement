using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using HotelManagment.BusDatService;
using HotelManagment.Reports;
using VisionInfoSolutionLibrary;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Drawing.Printing;

namespace HotelManagment.Forms
{
	public class RaporteDetyrimesh : VisionInfoSolutionLibrary.Form, IPrintable
	{
		#region Private Declarations

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private VisionInfoSolutionLibrary.GroupBox gbDetyrimet;
		private VisionInfoSolutionLibrary.CheckBox chkLlojDetyrimi;
		private VisionInfoSolutionLibrary.CheckBox chkEmerKlienti;
		private VisionInfoSolutionLibrary.TextBox txtEmri;
		private VisionInfoSolutionLibrary.TextBox txtMbiemri;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDetyrime;
		private VisionInfoSolutionLibrary.Button btnParaqit;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDateMbarimi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDateFillimi;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ImageList imageList1;
		private VisionInfoSolutionLibrary.GroupBox gbRaport;
		private System.Windows.Forms.PrintDialog printDialog;
		private VisionInfoSolutionLibrary.Label lblMbiemri;
		private VisionInfoSolutionLibrary.Label lblEmri;
		private System.Windows.Forms.Label label1;
		private bool readyToPrint = false;
		private System.Data.DataSet dsDetyrime;
		private string emer = "";
		private string mbiemer = "";
		private DateTime dtFillimi;
		private DateTime dtMbarimi;
		private VisionInfoSolutionLibrary.ToolBarPrint toolBar1;
		private int idDetyrimi = 0;
		#endregion

		#region Constructors & Destructors
		public RaporteDetyrimesh()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(RaporteDetyrimesh));
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.gbDetyrimet = new VisionInfoSolutionLibrary.GroupBox();
			this.dtpDateMbarimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.cmbDetyrime = new VisionInfoSolutionLibrary.DoubleCombo();
			this.chkLlojDetyrimi = new VisionInfoSolutionLibrary.CheckBox();
			this.dtpDateFillimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.lblMbiemri = new VisionInfoSolutionLibrary.Label();
			this.lblEmri = new VisionInfoSolutionLibrary.Label();
			this.txtMbiemri = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
			this.chkEmerKlienti = new VisionInfoSolutionLibrary.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnParaqit = new VisionInfoSolutionLibrary.Button(this.components);
			this.dsDetyrime = new System.Data.DataSet();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.gbRaport = new VisionInfoSolutionLibrary.GroupBox();
			this.toolBar1 = new VisionInfoSolutionLibrary.ToolBarPrint();
			this.printDialog = new System.Windows.Forms.PrintDialog();
			((System.ComponentModel.ISupportInitialize)(this.gbDetyrimet)).BeginInit();
			this.gbDetyrimet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsDetyrime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gbRaport)).BeginInit();
			this.gbRaport.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.AutoScroll = true;
			this.crystalReportViewer1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.crystalReportViewer1.DisplayGroupTree = false;
			this.crystalReportViewer1.DisplayToolbar = false;
			this.crystalReportViewer1.Location = new System.Drawing.Point(12, 48);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = null;
			this.crystalReportViewer1.Size = new System.Drawing.Size(876, 432);
			this.crystalReportViewer1.TabIndex = 5;
			this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
			// 
			// gbDetyrimet
			// 
			this.gbDetyrimet.BackColor = System.Drawing.Color.Transparent;
			this.gbDetyrimet.Controls.Add(this.dtpDateMbarimi);
			this.gbDetyrimet.Controls.Add(this.cmbDetyrime);
			this.gbDetyrimet.Controls.Add(this.chkLlojDetyrimi);
			this.gbDetyrimet.Controls.Add(this.dtpDateFillimi);
			this.gbDetyrimet.Controls.Add(this.lblMbiemri);
			this.gbDetyrimet.Controls.Add(this.lblEmri);
			this.gbDetyrimet.Controls.Add(this.txtMbiemri);
			this.gbDetyrimet.Controls.Add(this.txtEmri);
			this.gbDetyrimet.Controls.Add(this.chkEmerKlienti);
			this.gbDetyrimet.Controls.Add(this.label1);
			this.gbDetyrimet.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbDetyrimet.Location = new System.Drawing.Point(10, 40);
			this.gbDetyrimet.Name = "gbDetyrimet";
			this.gbDetyrimet.Size = new System.Drawing.Size(474, 112);
			this.gbDetyrimet.TabIndex = 6;
			this.gbDetyrimet.Text = "Kerkoni detyrimet";
			this.gbDetyrimet.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// dtpDateMbarimi
			// 
			this.dtpDateMbarimi.CustomFormat = "dd.MM.yyyy";
			this.dtpDateMbarimi.DefaultErrorMessage = "";
			this.dtpDateMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateMbarimi.IsValid = true;
			this.dtpDateMbarimi.Location = new System.Drawing.Point(300, 16);
			this.dtpDateMbarimi.Name = "dtpDateMbarimi";
			this.dtpDateMbarimi.Required = false;
			this.dtpDateMbarimi.ShowUpDown = true;
			this.dtpDateMbarimi.Size = new System.Drawing.Size(160, 20);
			this.dtpDateMbarimi.TabIndex = 1;
			this.dtpDateMbarimi.Value = new System.DateTime(2005, 10, 13, 14, 1, 0, 0);
			// 
			// cmbDetyrime
			// 
			this.cmbDetyrime.BackColor = System.Drawing.Color.Transparent;
			this.cmbDetyrime.DefaultErrorMessage = "Duhet te zgjidhni nje nga llojet e detyrimeve!";
			this.cmbDetyrime.IsValid = false;
			this.cmbDetyrime.Kolone1Vlere = null;
			this.cmbDetyrime.Kolone2Vlere = null;
			this.cmbDetyrime.Location = new System.Drawing.Point(124, 80);
			this.cmbDetyrime.Name = "cmbDetyrime";
			this.cmbDetyrime.ReadOnly = false;
			this.cmbDetyrime.Required = false;
			this.cmbDetyrime.Size = new System.Drawing.Size(160, 24);
			this.cmbDetyrime.SkipValidation = false;
			this.cmbDetyrime.TabIndex = 3;
			// 
			// chkLlojDetyrimi
			// 
			this.chkLlojDetyrimi.BackColor = System.Drawing.Color.Transparent;
			this.chkLlojDetyrimi.DefaultErrorMessage = "";
			this.chkLlojDetyrimi.ForeColor = System.Drawing.Color.DarkRed;
			this.chkLlojDetyrimi.IsValid = true;
			this.chkLlojDetyrimi.Location = new System.Drawing.Point(12, 80);
			this.chkLlojDetyrimi.Name = "chkLlojDetyrimi";
			this.chkLlojDetyrimi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chkLlojDetyrimi.Size = new System.Drawing.Size(96, 24);
			this.chkLlojDetyrimi.TabIndex = 2;
			this.chkLlojDetyrimi.Text = "Lloji i detyrimit";
			this.chkLlojDetyrimi.CheckedChanged += new System.EventHandler(this.chkLlojDetyrimi_CheckedChanged);
			// 
			// dtpDateFillimi
			// 
			this.dtpDateFillimi.CustomFormat = "dd.MM.yyyy";
			this.dtpDateFillimi.DefaultErrorMessage = "";
			this.dtpDateFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateFillimi.IsValid = true;
			this.dtpDateFillimi.Location = new System.Drawing.Point(124, 16);
			this.dtpDateFillimi.Name = "dtpDateFillimi";
			this.dtpDateFillimi.Required = false;
			this.dtpDateFillimi.ShowUpDown = true;
			this.dtpDateFillimi.Size = new System.Drawing.Size(160, 20);
			this.dtpDateFillimi.TabIndex = 0;
			this.dtpDateFillimi.Value = new System.DateTime(2005, 10, 13, 13, 35, 0, 0);
			// 
			// lblMbiemri
			// 
			this.lblMbiemri.Location = new System.Drawing.Point(300, 40);
			this.lblMbiemri.Name = "lblMbiemri";
			this.lblMbiemri.Size = new System.Drawing.Size(100, 12);
			this.lblMbiemri.TabIndex = 19;
			this.lblMbiemri.Text = "Mbiemri";
			// 
			// lblEmri
			// 
			this.lblEmri.Location = new System.Drawing.Point(124, 40);
			this.lblEmri.Name = "lblEmri";
			this.lblEmri.Size = new System.Drawing.Size(100, 12);
			this.lblEmri.TabIndex = 18;
			this.lblEmri.Text = "Emri";
			// 
			// txtMbiemri
			// 
			this.txtMbiemri.AutoSize = false;
			this.txtMbiemri.DefaultErrorMessage = "";
			this.txtMbiemri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemri.FixedLength = false;
			this.txtMbiemri.IsValid = true;
			this.txtMbiemri.Location = new System.Drawing.Point(300, 52);
			this.txtMbiemri.Name = "txtMbiemri";
			this.txtMbiemri.Required = false;
			this.txtMbiemri.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemri.Size = new System.Drawing.Size(160, 21);
			this.txtMbiemri.TabIndex = 2;
			this.txtMbiemri.Text = "";
			// 
			// txtEmri
			// 
			this.txtEmri.AutoSize = false;
			this.txtEmri.DefaultErrorMessage = "";
			this.txtEmri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri.FixedLength = false;
			this.txtEmri.IsValid = true;
			this.txtEmri.Location = new System.Drawing.Point(124, 52);
			this.txtEmri.Name = "txtEmri";
			this.txtEmri.Required = false;
			this.txtEmri.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri.Size = new System.Drawing.Size(160, 21);
			this.txtEmri.TabIndex = 2;
			this.txtEmri.Text = "";
			// 
			// chkEmerKlienti
			// 
			this.chkEmerKlienti.BackColor = System.Drawing.Color.Transparent;
			this.chkEmerKlienti.DefaultErrorMessage = "";
			this.chkEmerKlienti.IsValid = true;
			this.chkEmerKlienti.Location = new System.Drawing.Point(12, 52);
			this.chkEmerKlienti.Name = "chkEmerKlienti";
			this.chkEmerKlienti.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chkEmerKlienti.Size = new System.Drawing.Size(96, 24);
			this.chkEmerKlienti.TabIndex = 4;
			this.chkEmerKlienti.Text = "Emri i klientit";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(28, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "Midis datave";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnParaqit
			// 
			this.btnParaqit.BackColor = System.Drawing.Color.Blue;
			this.btnParaqit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnParaqit.DoValidation = true;
			this.btnParaqit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnParaqit.Location = new System.Drawing.Point(496, 88);
			this.btnParaqit.Name = "btnParaqit";
			this.btnParaqit.Size = new System.Drawing.Size(90, 21);
			this.btnParaqit.TabIndex = 4;
			this.btnParaqit.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnParaqit, "Kerkon per detyrimet ekstra te paguar qe plotesojne kriteret e zgjedhur!");
			this.btnParaqit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnParaqit.Click += new System.EventHandler(this.btnParaqit_Click);
			// 
			// dsDetyrime
			// 
			this.dsDetyrime.DataSetName = "DsDetyrime";
			this.dsDetyrime.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// gbRaport
			// 
			this.gbRaport.BackColor = System.Drawing.Color.Transparent;
			this.gbRaport.Controls.Add(this.crystalReportViewer1);
			this.gbRaport.Controls.Add(this.toolBar1);
			this.gbRaport.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbRaport.Location = new System.Drawing.Point(10, 160);
			this.gbRaport.Name = "gbRaport";
			this.gbRaport.Size = new System.Drawing.Size(902, 488);
			this.gbRaport.TabIndex = 10;
			this.gbRaport.Text = "Raporti per detyrimet";
			this.gbRaport.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// toolBar1
			// 
			this.toolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.toolBar1.BackColor = System.Drawing.SystemColors.Control;
			this.toolBar1.Location = new System.Drawing.Point(12, 20);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Size = new System.Drawing.Size(876, 28);
			this.toolBar1.TabIndex = 11;
			// 
			// RaporteDetyrimesh
			// 
			this.AcceptButton = this.btnParaqit;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CheckRequiredFields = true;
			this.ClientSize = new System.Drawing.Size(936, 683);
			this.Controls.Add(this.gbRaport);
			this.Controls.Add(this.btnParaqit);
			this.Controls.Add(this.gbDetyrimet);
			this.EnableValidation = true;
			this.HelpFile = "RAPORT DETYRIME.htm";
			this.Name = "RaporteDetyrimesh";
			this.Text = "Raport per detyrimet";
			this.Load += new System.EventHandler(this.RaporteDetyrimesh_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.gbDetyrimet, 0);
			this.Controls.SetChildIndex(this.btnParaqit, 0);
			this.Controls.SetChildIndex(this.gbRaport, 0);
			((System.ComponentModel.ISupportInitialize)(this.gbDetyrimet)).EndInit();
			this.gbDetyrimet.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsDetyrime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gbRaport)).EndInit();
			this.gbRaport.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void RaporteDetyrimesh_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				// pastrim var private
				this.readyToPrint = false;
				this.dsDetyrime.Tables.Clear();
				this.emer = "";
				this.mbiemer = "";
				this.dtFillimi = DateTime.Now;
				this.dtMbarimi = DateTime.Now;
				this.idDetyrimi = 0;
				//pastrim var private
				this.RefreshDetyrime();
				this.RifreskoRaportin();
				// Krijojme eventHandlers per butonat e raporteve
				this.dtpDateFillimi.Value = DateTime.Now;
				this.dtpDateMbarimi.Value = DateTime.Now;
				this.toolBar1.btnPrint.Click += new EventHandler(btnPrint_Click);
				this.toolBar1.btnEksporto.Click += new EventHandler(btnEksporto_Click);
				this.toolBar1.btnFundit.Click += new EventHandler(btnFundit_Click);
				this.toolBar1.btnMbyll.Click += new EventHandler(btnMbyll_Click);
				this.toolBar1.btnPara.Click += new EventHandler(btnPara_Click);
				this.toolBar1.btnPare.Click += new EventHandler(btnPare_Click);
				this.toolBar1.btnPrapa.Click += new EventHandler(btnPrapa_Click);
				this.toolBar1.btnRifresko.Click += new EventHandler(btnRifresko_Click);
				this.toolBar1.cmZoom.MenuItems[0].Click += new EventHandler(RaporteDetyrimeshMenu0_Click);
				this.toolBar1.cmZoom.MenuItems[1].Click += new EventHandler(RaporteDetyrimeshMenu1_Click);
				this.toolBar1.cmZoom.MenuItems[2].Click += new EventHandler(RaporteDetyrimeshMenu2_Click);
				this.toolBar1.cmZoom.MenuItems[3].Click += new EventHandler(RaporteDetyrimeshMenu3_Click);
				this.toolBar1.cmZoom.MenuItems[3].Click += new EventHandler(RaporteDetyrimeshMenu4_Click);
				this.toolBar1.btnMbyll.Visible = false;
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
		
		private void btnParaqit_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				InputController data = new InputController();
				int veprim = this.KontrolloGrupBox();
				if (veprim == 0)
					return;
				emer = this.txtEmri.Text;
				mbiemer = this.txtMbiemri.Text;
				dtFillimi = (DateTime)this.dtpDateFillimi.Value;
				dtMbarimi = (DateTime)this.dtpDateMbarimi.Value;
				idDetyrimi = Convert.ToInt32(this.cmbDetyrime.Kolone2Vlere);
				if (veprim == 1)
					this.dsDetyrime = data.KerkesaRead("ShfaqDetyrimeKlientePerData", dtFillimi, dtMbarimi);
				else if (veprim == 2)
					this.dsDetyrime = data.KerkesaRead("ShfaqDetyrimeKlientePerKategori", idDetyrimi, dtFillimi, dtMbarimi);
				else if (veprim == 3)
					dsDetyrime = data.KerkesaRead("ShfaqDetyrimKlientiPerEmerDheData", emer, mbiemer, dtFillimi, dtMbarimi);
				else if (veprim == 4)
					this.dsDetyrime = data.KerkesaRead("ShfaqDetyrimeKlientePerDataEmerKategori", dtFillimi, dtMbarimi, idDetyrimi, emer, mbiemer);
				if (this.dsDetyrime.Tables[0].Rows.Count > 0)
				{
					FormatdsDetyrime();
					this.crystalReportViewer1.ReportSource = new CrDetyrimeKliente();
					this.ReadyToPrint = true;
				}
				else
				{
					this.ReadyToPrint = false;
					this.crystalReportViewer1.ReportSource = null;
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
				this.RifreskoRaportin();
			}
		}

		private void chkLlojDetyrimi_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				if (this.chkLlojDetyrimi.Checked)
					this.cmbDetyrime.Required = true;
				else
					this.cmbDetyrime.Required = false;
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
		/// <summary>
		/// Mbush cmbDetyrime me te gjitha llojet e detyrimeve dhe ID-te perkatese te tyre nga databaza
		/// </summary>
		private void RefreshDetyrime()
		{
			InputController data = new InputController();
			DataSet ds = data.KerkesaRead("ShfaqLlojetDetyrime");
			this.cmbDetyrime.Kolone1.Items.Clear();
			this.cmbDetyrime.Kolone2.Items.Clear();
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbDetyrime.Kolone1.Items.Add(dr[1]);
				this.cmbDetyrime.Kolone2.Items.Add(dr[0]);
			}
		}

		/// <summary>
		/// Kontrollo vlerat e dtpDateFillimi dhe dtpDateMbarimi qe jane ne gbDetyrime dhe me pas
		/// vlerat e checkBoxeve te formes
		/// </summary>
		/// <returns>0 nese ka gabim</returns>
		private int KontrolloGrupBox()
		{
			if ((DateTime)this.dtpDateMbarimi.Value < (DateTime)this.dtpDateFillimi.Value)
			{
				this.error.SetError(this.dtpDateFillimi, "Data e fillimit te kerkimit nuk mund te jete " + 
					Environment.NewLine + "me e madhe se data e mbarimit te kerkimit");
				return 0;
			}
			this.error.SetError(this.dtpDateFillimi, "");
			if (this.chkLlojDetyrimi.Checked && this.chkEmerKlienti.Checked)
				return 4;
			if (this.chkLlojDetyrimi.Checked)
				return 2;
			if (this.chkEmerKlienti.Checked)
				return 3;
			return 1;
		}

		/// <summary>
		/// Ben formatimin e datasetit dsDetyrime ne menyre te pershtatshme per te bere printimin
		/// dhe kete dataset e hedh ne nje file Xml
		/// </summary>
		private void FormatdsDetyrime()
		{
			try
			{
				DataSet ds = new DataSet();
				string informacionet = Application.StartupPath + "\\Informacione.xml";
				if (File.Exists(informacionet))
					ds.ReadXml(Application.StartupPath + "\\Informacione.xml");
				// Krijojme nje dataset te ri
				DataSet dsPrint = new DataSet();
				dsPrint.EnforceConstraints = false;
				// Shtojme nje tabele General ne dataset e cila do te mbaje te dhenat e pergjithshme
				// qe ka fatura. Shtojme dhe kolonat per keto te dhena
				dsPrint.Tables.Add("General");
				dsPrint.Tables["General"].Columns.Add("Hotel", typeof(String));
				dsPrint.Tables["General"].Columns.Add("Adrese", typeof(String));
				dsPrint.Tables["General"].Columns.Add("Nr.Tel", typeof(String));
				dsPrint.Tables["General"].Columns.Add("Website", typeof(String));
				dsPrint.Tables["General"].Columns.Add("Email", typeof(String));
				dsPrint.Tables["General"].Columns.Add("KodFiskal", typeof(String));
				dsPrint.Tables["General"].Columns.Add("MesazhQendrimi", typeof(String));
				dsPrint.Tables["General"].Columns.Add("Relation", typeof(Int32));

				// Krijojme nje rresht te ri ne tabele dhe e mbushim me te dhenat e duhura
				DataRow drGeneral = dsPrint.Tables["General"].NewRow();
				drGeneral[0] = ds.Tables[0].Rows[0][0];
				drGeneral[1] = ds.Tables[0].Rows[0][1];
				drGeneral[2] = ds.Tables[0].Rows[0][2];
				drGeneral[4] = ds.Tables[0].Rows[0][3];
				drGeneral[3] = ds.Tables[0].Rows[0][4];
				drGeneral[5] = ds.Tables[0].Rows[0][5];
				drGeneral["MesazhQendrimi"] = ds.Tables[0].Rows[0][7];
				drGeneral["Relation"] = 1;
				// Hedhim rreshtin ne tabele
				dsPrint.Tables["General"].Rows.Add(drGeneral);
				dsPrint.AcceptChanges();
				// Krijojme tabelen e re
				int totali = 0;
				DataTable dtPrint = new DataTable();
				dtPrint.TableName = "Detyrime";
				dtPrint.Columns.Add("ID_KLIENTI", typeof(Int32));
				dtPrint.Columns.Add("Emri", typeof(String));
				dtPrint.Columns.Add("Data", typeof(String));
				dtPrint.Columns.Add("Vlera", typeof(Int32));
				dtPrint.Columns.Add("Totali", typeof(Int32));
				dtPrint.Columns.Add("Relation", typeof(Int32));
				dsPrint.Tables.Add(dtPrint);
				foreach(DataRow drDetyrime in dsDetyrime.Tables[0].Rows)
				{
					DataRow drPrint = dsPrint.Tables[1].NewRow();
					int idKlienti = Convert.ToInt32(drDetyrime[0]);
					// Nese ky klient eshte hedhur nje here ne dsPrint atehere nuk do te hedhim emrin e klientit
					// por vetem detyrimet
					if (dsPrint.Tables[1].Select("ID_KLIENTI = " + idKlienti).Length > 0)
					{
						drPrint[0] = drDetyrime[0];
						drPrint[1] = "\t" + drDetyrime[5];
						drPrint[2] = Convert.ToDateTime(drDetyrime[6]).ToShortDateString();
						drPrint[5] = 1;
						// Ndonje hedhje e gabuar ne databaze mund te beje qe te kemi exception, ne rast te tille
						// vleres i hedhim 0
						try
						{
							drPrint[3] = Convert.ToInt32(drDetyrime[7]) * Convert.ToInt32(drDetyrime[8]);
						}
						catch
						{
							drPrint[3] = 0;
						}
						dsPrint.Tables[1].Rows.Add(drPrint);
					}
					// Perndryshe, nese ky klient nuk eshte hedhur asnjehere ne dsPrint, atehere hedhim emrin
					// e klientit ne rreshtin e pare dhe ne rreshtin e dyte hedhim detyrimin per klientin
					else
					{
						//drPrint[0] = drDetyrime[0];
						drPrint[1] = drDetyrime[1] + " " + drDetyrime[2] + "\t\t" + drDetyrime[9] + "\t" + 
							Convert.ToDateTime(drDetyrime[3]).ToShortDateString() + "\t" + Convert.ToDateTime(drDetyrime[4]).ToShortDateString();
						drPrint[5] = 1;
						dsPrint.Tables[1].Rows.Add(drPrint);
						drPrint = dsPrint.Tables[1].NewRow();
						drPrint[0] = drDetyrime[0];
						drPrint[1] = "\t" + drDetyrime[5];
						drPrint[2] = Convert.ToDateTime(drDetyrime[6]).ToShortDateString();
						drPrint[5] = 1;
						// Ndonje hedhje e gabuar ne databaze mund te beje qe te kemi exception, ne rast te tille
						// vleres i hedhim 0
						try
						{
							drPrint[3] = Convert.ToInt32(drDetyrime[7]) * Convert.ToInt32(drDetyrime[8]);
						}
						catch
						{
							drPrint[3] = 0;
						}
						dsPrint.Tables[1].Rows.Add(drPrint);
					}
					// Per te kontrolluar nese ky eshte detyrimi i fundit per kete klient, ne menyre qe te hedhim
					// totalin therrasim metoden Select per dsDetyrimet dhe per dsPrint duke u nisur nga 
					// ID_KLIENTI dhe kontrollojme nese kane te njejtin numer DataRow-sh
					if (dsDetyrime.Tables[0].Select("ID_KLIENTI = " + idKlienti).Length ==
						dsPrint.Tables[1].Select("ID_KLIENTI = " + idKlienti).Length)
					{
						foreach (DataRow dr in dsPrint.Tables[1].Select("ID_KLIENTI = " + idKlienti))
						{
							if (dr[3] != null && dr[3].ToString() != "")
							{
								totali += Convert.ToInt32(dr[3]);
							}
						}
						dsPrint.Tables[1].Rows[dsPrint.Tables[1].Rows.Count - 1][4] = totali;
						totali = 0;
					}
					//dsPrint.Tables[1].Rows.Add(drPrint);
				}
				DataRelation general2detyrime = new DataRelation("GeneralDetyrime",	
					dsPrint.Tables["General"].Columns["Relation"], 
					dsPrint.Tables["Detyrime"].Columns["Relation"]);
				dsPrint.Relations.Add(general2detyrime);
				dsPrint.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\RaportDetyrimesh.xml", XmlWriteMode.WriteSchema);
			}
			catch(Exception ex)
			{
				return;
			}
		}
		#endregion

		#region CrystalReportViewer
		private void RifreskoRaportin()
		{
			foreach (Control child in this.crystalReportViewer1.Controls)
			{
				if (child is CrystalDecisions.Windows.Forms.PageView)
				{
					PageView child1 = child as PageView;
					foreach (Control child2 in child1.Controls)
					{
						if (child2 is System.Windows.Forms.TabControl)
						{
							foreach (Control child3 in child2.Controls)
							{
								DocumentControl child4 = child3 as DocumentControl;
								if (child4 != null)
									child4.Text = "Raporti Kryesor";
							}
						}
					}
				}
				else if (child is System.Windows.Forms.StatusBar)
				{
					StatusBar status = child as StatusBar;
					status.Panels[0].Text = status.Panels[0].Text.Replace("Current Page No:", "Numri i faqes korrente");
					status.Panels[1].Text = status.Panels[1].Text.Replace("Total Page No:", "Numri total i faqeve:");					
					status.Panels[2].Text = status.Panels[2].Text.Replace("Zoom Factor:", "Shkalla e zmadhimit:");					
				}
			}
		}

		private void toolbar1_ButtonClick(object sender, DotNetWidgets.DotNetToolbarItemClickEventArgs e)
		{
			if (e.Button.ToolTipText == "Printo")
			{
				this.crystalReportViewer1.PrintReport();
			}
			else if (e.Button.ToolTipText == "Shko ne faqen tjeter")
				this.crystalReportViewer1.ShowNextPage();
			else if (e.Button.ToolTipText == "Shko ne faqen e pare")
				this.crystalReportViewer1.ShowFirstPage();
			else if (e.Button.ToolTipText == "Shko ne faqen e meparshme")
				this.crystalReportViewer1.ShowPreviousPage();
			else if (e.Button.ToolTipText == "Shko ne faqen e fundit")
				this.crystalReportViewer1.ShowLastPage();
			else if (e.Button.ToolTipText == "Eksporto")
				this.crystalReportViewer1.ExportReport();
			else if (e.Button.ToolTipText == "Rifresko")
				this.crystalReportViewer1.RefreshReport();
			else if (e.Button.ToolTipText == "Mbyll Raportin")
				this.Close();
			this.RifreskoRaportin();

		}

		private void crystalReportViewer1_Load(object sender, System.EventArgs e)
		{
			this.RifreskoRaportin();
		}
		private void btnPrint_Click(object sender, EventArgs e)
		{
			this.crystalReportViewer1.PrintReport();
			this.RifreskoRaportin();
		}

		private void btnEksporto_Click(object sender, EventArgs e)
		{
			this.crystalReportViewer1.ExportReport();
			this.RifreskoRaportin();
		}

		private void btnFundit_Click(object sender, EventArgs e)
		{
			this.crystalReportViewer1.ShowLastPage();
			this.RifreskoRaportin();
		}

		private void btnMbyll_Click(object sender, EventArgs e)
		{
			//this.crystalReportViewer1.CloseView();
		}

		private void btnPara_Click(object sender, EventArgs e)
		{
			this.crystalReportViewer1.ShowNextPage();
			this.RifreskoRaportin();
		}

		private void btnPare_Click(object sender, EventArgs e)
		{
			this.crystalReportViewer1.ShowFirstPage();
			this.RifreskoRaportin();
		}

		private void btnPrapa_Click(object sender, EventArgs e)
		{
			this.crystalReportViewer1.ShowPreviousPage();
			this.RifreskoRaportin();
		}

		private void btnRifresko_Click(object sender, EventArgs e)
		{
			this.crystalReportViewer1.RefreshReport();
			this.RifreskoRaportin();
		}

		private void RaporteDetyrimeshMenu0_Click(object sender, EventArgs e)
		{
			this.crystalReportViewer1.Zoom(50);
			this.RifreskoRaportin();
		}

		private void RaporteDetyrimeshMenu1_Click(object sender, EventArgs e)
		{
			this.crystalReportViewer1.Zoom(100);
			this.RifreskoRaportin();
		}

		private void RaporteDetyrimeshMenu2_Click(object sender, EventArgs e)
		{
			this.crystalReportViewer1.Zoom(150);
			this.RifreskoRaportin();
		}

		private void RaporteDetyrimeshMenu3_Click(object sender, EventArgs e)
		{
			this.crystalReportViewer1.Zoom(200);
			this.RifreskoRaportin();
		}

		private void RaporteDetyrimeshMenu4_Click(object sender, EventArgs e)
		{
			this.crystalReportViewer1.Zoom(400);
			this.RifreskoRaportin();
		}
		#endregion

		#region IPrintable Members

		public void PrintPreview()
		{
			// Ne kete rast nuk behet asgje pasi ne e kemi njehere te hapur raportin
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
			PrintDocument printDocument = new PrintDocument();
			string printerName = "";
			short copies = 1;
			printDocument.DocumentName = "Raport";
			printDialog.Document = printDocument;
			printDialog.ShowDialog();
			printerName = printDialog.PrinterSettings.PrinterName;
			copies = printDialog.PrinterSettings.Copies;
			CrDetyrimeKliente crDetyrimeKliente = new CrDetyrimeKliente();
			crDetyrimeKliente.PrintOptions.PrinterName = printerName;
			crDetyrimeKliente.PrintToPrinter(copies, true, 0, 0);
		}

		public event VisionInfoSolutionLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

		#endregion

	}
}

