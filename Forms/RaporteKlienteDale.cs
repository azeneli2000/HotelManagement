using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Drawing.Printing;
using VisionInfoSolutionLibrary;

namespace HotelManagment.Forms
{
	public class RaporteKlienteDale : VisionInfoSolutionLibrary.Form, IPrintable
	{
		#region Private Declarations
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.PrintDialog printDialog;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private VisionInfoSolutionLibrary.Button btnKerko;
		private System.ComponentModel.IContainer components = null;		
		private VisionInfoSolutionLibrary.GroupBox gbRaportiKliente;
		private VisionInfoSolutionLibrary.Label lblAgjensia;
		private VisionInfoSolutionLibrary.Label lblGrupi;
		private VisionInfoSolutionLibrary.Label lblMbiemri;
		private VisionInfoSolutionLibrary.Label lblEmri;
		private VisionInfoSolutionLibrary.TextBox txtAgjensia;
		private VisionInfoSolutionLibrary.TextBox txtGrupi;
		private VisionInfoSolutionLibrary.RadioButton rbGrupe;
		private VisionInfoSolutionLibrary.RadioButton rbKliente;
		private VisionInfoSolutionLibrary.TextBox txtMbiemri;
		private VisionInfoSolutionLibrary.TextBox txtEmri;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDateFillimi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDateMbarimi;
		private VisionInfoSolutionLibrary.GroupBox gbTeDhenatKlient;
		private System.Windows.Forms.Label label1;
		private bool readyToPrint = true;
		private string emer = "";
		private string mbiemer = "";
		private string grup = "";
		private string agjensi = "";
		private DateTime dtFillimi;
		private DateTime dtMbarimi;
		private VisionInfoSolutionLibrary.ToolBarPrint toolBar1;
		private System.Data.DataSet dsHyrjeNeHotel;
		#endregion

		#region Constructors & Destructors
		public RaporteKlienteDale()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(RaporteKlienteDale));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.printDialog = new System.Windows.Forms.PrintDialog();
			this.dsHyrjeNeHotel = new System.Data.DataSet();
			this.gbRaportiKliente = new VisionInfoSolutionLibrary.GroupBox();
			this.toolBar1 = new VisionInfoSolutionLibrary.ToolBarPrint();
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.btnKerko = new VisionInfoSolutionLibrary.Button(this.components);
			this.lblAgjensia = new VisionInfoSolutionLibrary.Label();
			this.lblGrupi = new VisionInfoSolutionLibrary.Label();
			this.lblMbiemri = new VisionInfoSolutionLibrary.Label();
			this.lblEmri = new VisionInfoSolutionLibrary.Label();
			this.txtAgjensia = new VisionInfoSolutionLibrary.TextBox();
			this.txtGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.rbGrupe = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbKliente = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.txtMbiemri = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
			this.dtpDateFillimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpDateMbarimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.gbTeDhenatKlient = new VisionInfoSolutionLibrary.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dsHyrjeNeHotel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gbRaportiKliente)).BeginInit();
			this.gbRaportiKliente.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbTeDhenatKlient)).BeginInit();
			this.gbTeDhenatKlient.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// dsHyrjeNeHotel
			// 
			this.dsHyrjeNeHotel.DataSetName = "NewDataSet";
			this.dsHyrjeNeHotel.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// gbRaportiKliente
			// 
			this.gbRaportiKliente.BackColor = System.Drawing.Color.Transparent;
			this.gbRaportiKliente.Controls.Add(this.toolBar1);
			this.gbRaportiKliente.Controls.Add(this.crystalReportViewer1);
			this.gbRaportiKliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbRaportiKliente.Location = new System.Drawing.Point(10, 172);
			this.gbRaportiKliente.Name = "gbRaportiKliente";
			this.gbRaportiKliente.Size = new System.Drawing.Size(892, 488);
			this.gbRaportiKliente.TabIndex = 8;
			this.gbRaportiKliente.Text = "Raporti per hyrjet ne hotel";
			this.gbRaportiKliente.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// toolBar1
			// 
			this.toolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.toolBar1.BackColor = System.Drawing.SystemColors.Control;
			this.toolBar1.Location = new System.Drawing.Point(8, 20);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Size = new System.Drawing.Size(876, 28);
			this.toolBar1.TabIndex = 12;
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.AutoScroll = true;
			this.crystalReportViewer1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.crystalReportViewer1.DisplayGroupTree = false;
			this.crystalReportViewer1.DisplayToolbar = false;
			this.crystalReportViewer1.Location = new System.Drawing.Point(8, 48);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = null;
			this.crystalReportViewer1.Size = new System.Drawing.Size(876, 432);
			this.crystalReportViewer1.TabIndex = 6;
			// 
			// btnKerko
			// 
			this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko.DoValidation = true;
			this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKerko.Location = new System.Drawing.Point(484, 92);
			this.btnKerko.Name = "btnKerko";
			this.btnKerko.Size = new System.Drawing.Size(90, 21);
			this.btnKerko.TabIndex = 6;
			this.btnKerko.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko, "Kerkon per hyrjet jo te vlefshme ne hotel\r\n qe plotesojne kriteret e zgjedhur si " +
				"edhe\r\n per pagesat qe jane kryer per to!");
			this.btnKerko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
			// 
			// lblAgjensia
			// 
			this.lblAgjensia.BackColor = System.Drawing.Color.Transparent;
			this.lblAgjensia.Location = new System.Drawing.Point(280, 80);
			this.lblAgjensia.Name = "lblAgjensia";
			this.lblAgjensia.Size = new System.Drawing.Size(100, 16);
			this.lblAgjensia.TabIndex = 19;
			this.lblAgjensia.Text = "Agjensia";
			// 
			// lblGrupi
			// 
			this.lblGrupi.BackColor = System.Drawing.Color.Transparent;
			this.lblGrupi.Location = new System.Drawing.Point(112, 84);
			this.lblGrupi.Name = "lblGrupi";
			this.lblGrupi.Size = new System.Drawing.Size(100, 12);
			this.lblGrupi.TabIndex = 18;
			this.lblGrupi.Text = "Grupi";
			// 
			// lblMbiemri
			// 
			this.lblMbiemri.BackColor = System.Drawing.Color.Transparent;
			this.lblMbiemri.Location = new System.Drawing.Point(280, 40);
			this.lblMbiemri.Name = "lblMbiemri";
			this.lblMbiemri.Size = new System.Drawing.Size(100, 12);
			this.lblMbiemri.TabIndex = 17;
			this.lblMbiemri.Text = "Mbiemri";
			// 
			// lblEmri
			// 
			this.lblEmri.BackColor = System.Drawing.Color.Transparent;
			this.lblEmri.Location = new System.Drawing.Point(112, 40);
			this.lblEmri.Name = "lblEmri";
			this.lblEmri.Size = new System.Drawing.Size(100, 12);
			this.lblEmri.TabIndex = 16;
			this.lblEmri.Text = "Emri";
			// 
			// txtAgjensia
			// 
			this.txtAgjensia.AutoSize = false;
			this.txtAgjensia.DefaultErrorMessage = "";
			this.txtAgjensia.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAgjensia.FixedLength = false;
			this.txtAgjensia.IsValid = true;
			this.txtAgjensia.Location = new System.Drawing.Point(280, 96);
			this.txtAgjensia.Name = "txtAgjensia";
			this.txtAgjensia.Required = false;
			this.txtAgjensia.RequiredControlColor = System.Drawing.Color.White;
			this.txtAgjensia.Size = new System.Drawing.Size(160, 21);
			this.txtAgjensia.TabIndex = 5;
			this.txtAgjensia.Text = "";
			// 
			// txtGrupi
			// 
			this.txtGrupi.AutoSize = false;
			this.txtGrupi.DefaultErrorMessage = "";
			this.txtGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtGrupi.FixedLength = false;
			this.txtGrupi.IsValid = true;
			this.txtGrupi.Location = new System.Drawing.Point(112, 96);
			this.txtGrupi.Name = "txtGrupi";
			this.txtGrupi.Required = false;
			this.txtGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtGrupi.Size = new System.Drawing.Size(160, 21);
			this.txtGrupi.TabIndex = 4;
			this.txtGrupi.Text = "";
			// 
			// rbGrupe
			// 
			this.rbGrupe.BackColor = System.Drawing.Color.Transparent;
			this.rbGrupe.Location = new System.Drawing.Point(16, 132);
			this.rbGrupe.Name = "rbGrupe";
			this.rbGrupe.Size = new System.Drawing.Size(100, 24);
			this.rbGrupe.TabIndex = 13;
			this.rbGrupe.Text = "Sipas grupit";
			// 
			// rbKliente
			// 
			this.rbKliente.BackColor = System.Drawing.Color.Transparent;
			this.rbKliente.Checked = true;
			this.rbKliente.Location = new System.Drawing.Point(16, 92);
			this.rbKliente.Name = "rbKliente";
			this.rbKliente.Size = new System.Drawing.Size(100, 24);
			this.rbKliente.TabIndex = 12;
			this.rbKliente.Text = "Sipas klientit";
			// 
			// txtMbiemri
			// 
			this.txtMbiemri.AutoSize = false;
			this.txtMbiemri.DefaultErrorMessage = "";
			this.txtMbiemri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemri.FixedLength = false;
			this.txtMbiemri.IsValid = true;
			this.txtMbiemri.Location = new System.Drawing.Point(280, 52);
			this.txtMbiemri.Name = "txtMbiemri";
			this.txtMbiemri.Required = false;
			this.txtMbiemri.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemri.Size = new System.Drawing.Size(160, 21);
			this.txtMbiemri.TabIndex = 3;
			this.txtMbiemri.Text = "";
			// 
			// txtEmri
			// 
			this.txtEmri.AutoSize = false;
			this.txtEmri.DefaultErrorMessage = "";
			this.txtEmri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri.FixedLength = false;
			this.txtEmri.IsValid = true;
			this.txtEmri.Location = new System.Drawing.Point(112, 52);
			this.txtEmri.Name = "txtEmri";
			this.txtEmri.Required = false;
			this.txtEmri.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri.Size = new System.Drawing.Size(160, 21);
			this.txtEmri.TabIndex = 2;
			this.txtEmri.Text = "";
			// 
			// dtpDateFillimi
			// 
			this.dtpDateFillimi.CustomFormat = "dd.MM.yyyy";
			this.dtpDateFillimi.DefaultErrorMessage = "";
			this.dtpDateFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateFillimi.IsValid = true;
			this.dtpDateFillimi.Location = new System.Drawing.Point(112, 16);
			this.dtpDateFillimi.Name = "dtpDateFillimi";
			this.dtpDateFillimi.Required = false;
			this.dtpDateFillimi.ShowUpDown = true;
			this.dtpDateFillimi.Size = new System.Drawing.Size(160, 20);
			this.dtpDateFillimi.TabIndex = 0;
			this.dtpDateFillimi.Value = new System.DateTime(2005, 11, 5, 12, 43, 0, 0);
			// 
			// dtpDateMbarimi
			// 
			this.dtpDateMbarimi.CustomFormat = "dd.MM.yyyy";
			this.dtpDateMbarimi.DefaultErrorMessage = "";
			this.dtpDateMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateMbarimi.IsValid = true;
			this.dtpDateMbarimi.Location = new System.Drawing.Point(280, 16);
			this.dtpDateMbarimi.Name = "dtpDateMbarimi";
			this.dtpDateMbarimi.Required = false;
			this.dtpDateMbarimi.ShowUpDown = true;
			this.dtpDateMbarimi.Size = new System.Drawing.Size(160, 20);
			this.dtpDateMbarimi.TabIndex = 1;
			this.dtpDateMbarimi.Value = new System.DateTime(2005, 11, 5, 12, 43, 0, 0);
			// 
			// gbTeDhenatKlient
			// 
			this.gbTeDhenatKlient.BackColor = System.Drawing.Color.Transparent;
			this.gbTeDhenatKlient.Controls.Add(this.lblAgjensia);
			this.gbTeDhenatKlient.Controls.Add(this.lblGrupi);
			this.gbTeDhenatKlient.Controls.Add(this.lblMbiemri);
			this.gbTeDhenatKlient.Controls.Add(this.lblEmri);
			this.gbTeDhenatKlient.Controls.Add(this.txtAgjensia);
			this.gbTeDhenatKlient.Controls.Add(this.txtGrupi);
			this.gbTeDhenatKlient.Controls.Add(this.txtMbiemri);
			this.gbTeDhenatKlient.Controls.Add(this.txtEmri);
			this.gbTeDhenatKlient.Controls.Add(this.dtpDateFillimi);
			this.gbTeDhenatKlient.Controls.Add(this.dtpDateMbarimi);
			this.gbTeDhenatKlient.Controls.Add(this.label1);
			this.gbTeDhenatKlient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbTeDhenatKlient.Location = new System.Drawing.Point(10, 40);
			this.gbTeDhenatKlient.Name = "gbTeDhenatKlient";
			this.gbTeDhenatKlient.Size = new System.Drawing.Size(460, 128);
			this.gbTeDhenatKlient.TabIndex = 7;
			this.gbTeDhenatKlient.Text = "Kerkoni hyrjet ne hotel";
			this.gbTeDhenatKlient.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(24, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 12;
			this.label1.Text = "Midis datave";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RaporteKlienteDale
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(936, 780);
			this.Controls.Add(this.rbKliente);
			this.Controls.Add(this.rbGrupe);
			this.Controls.Add(this.gbRaportiKliente);
			this.Controls.Add(this.gbTeDhenatKlient);
			this.Controls.Add(this.btnKerko);
			this.HelpFile = "RAPORT HYRJE DALJE.htm";
			this.Name = "RaporteKlienteDale";
			this.Text = "Hyrje - daljet ne hotel";
			this.Load += new System.EventHandler(this.RaporteKlienteDale_Load);
			this.Controls.SetChildIndex(this.btnKerko, 0);
			this.Controls.SetChildIndex(this.gbTeDhenatKlient, 0);
			this.Controls.SetChildIndex(this.gbRaportiKliente, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.rbGrupe, 0);
			this.Controls.SetChildIndex(this.rbKliente, 0);
			((System.ComponentModel.ISupportInitialize)(this.dsHyrjeNeHotel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gbRaportiKliente)).EndInit();
			this.gbRaportiKliente.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbTeDhenatKlient)).EndInit();
			this.gbTeDhenatKlient.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Private Methods
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
		#endregion

		#region EventHandlers
		private void crystalReportViewer1_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				this.RifreskoRaportin();
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
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void btnKerko_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				dtFillimi = (DateTime)this.dtpDateFillimi.Value;
				dtMbarimi = (DateTime)this.dtpDateMbarimi.Value;
				emer = this.txtEmri.Text;
				mbiemer = this.txtMbiemri.Text;
				grup = this.txtGrupi.Text;
				agjensi = this.txtAgjensia.Text;
				InputController data = new InputController();
				if (this.rbKliente.Checked)
				{
					dsHyrjeNeHotel = data.KerkesaRead("HyrjeNeHotelKlienteDale", emer, mbiemer, dtFillimi, dtMbarimi);
					dsHyrjeNeHotel.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + @"\HyrjeDaljeKliente.xml", XmlWriteMode.WriteSchema);
					if (dsHyrjeNeHotel.Tables[0].Rows.Count < 1)
					{
						System.Windows.Forms.MessageBox.Show(this, "Per kushtet e zgjedhura nuk ka asnje hyrje-dalje ne hotel",
							"Raporti per Hyrje-Daljet ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.ReadyToPrint = false;
						this.crystalReportViewer1.ReportSource = null;
					}
					else
					{
						this.crystalReportViewer1.ReportSource = new HotelManagment.Reports.CrHyrjeDaljeKliente();
						this.ReadyToPrint = true;
					}
				}
				else if (this.rbGrupe.Checked)
				{
					dsHyrjeNeHotel = data.KerkesaRead("HyrjeNeHotelGrupeDale", grup, agjensi, dtFillimi, dtMbarimi);
					dsHyrjeNeHotel.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + @"\HyrjeDaljeGrupe.xml", XmlWriteMode.WriteSchema);
					if (dsHyrjeNeHotel.Tables[0].Rows.Count < 1)
					{
						System.Windows.Forms.MessageBox.Show(this, "Per kushtet e zgjedhura nuk ka asnje hyrje-dalje ne hotel",
							"Raporti per Hyrje-Daljet ne hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.crystalReportViewer1.ReportSource = null;
						this.ReadyToPrint = false;
					}
					else
					{
						this.crystalReportViewer1.ReportSource = new HotelManagment.Reports.CrHyrjeDaljeGrupe();
						this.ReadyToPrint = true;
					}
				}
				this.RifreskoRaportin();
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
		private void RaporteKlienteDale_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				//pastrim var private
				this.readyToPrint = true;
				this.emer = "";
				this.mbiemer = "";
				this.grup = "";
				this.agjensi = "";
				this.dtFillimi = DateTime.Now;
				this.dtMbarimi = DateTime.Now;
				this.dsHyrjeNeHotel.Tables.Clear();
				this.dtpDateFillimi.Value = DateTime.Now;
				this.dtpDateMbarimi.Value = DateTime.Now;
				// Krijojme eventHandlers per butonat e raporteve
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
		#endregion

		#region IPrintable Members

		public void PrintPreview()
		{
			// Nuk behet asgje. Forma eshte hapur ne print preview
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
			this.crystalReportViewer1.PrintReport();
		}

		private void toolbar1_ButtonClick_1(object sender, DotNetWidgets.DotNetToolbarItemClickEventArgs e)
		{
		
		}


		public event VisionInfoSolutionLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

		#endregion

		#region CrystalReportViewer
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
	}
}

