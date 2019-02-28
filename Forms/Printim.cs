using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using VisionInfoSolutionLibrary;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using HotelManagment.Reports;
using System.Drawing.Printing;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace HotelManagment.Forms
{
	/// <summary>
	/// Kjo forme merret me printimin dhe print dhe preview-ne e dokumentave ne CrystalReports
	/// </summary>
	public class Printim : VisionInfoSolutionLibrary.Form
	{
		#region Private Fields

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.PrintDialog printDialog;
		private VisionInfoSolutionLibrary.ToolBarPrint toolBar1;
		private System.ComponentModel.IContainer components;
		#endregion

		#region Constructors & Destructors
		public Printim()
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

		#region Public Methods
		/// <summary>
		/// Ngarkon ne CrystaReportViewer nje raport ne varesi te parametrit raporti
		/// </summary>
		/// <param name="raporti">percakton se cili raport do te ngarkohet</param>
		public void NgarkoRaport(string raporti)
		{
			switch (raporti)
			{
				case "ShfaqDhomaNePerdorim":
					this.crystalReportViewer1.ReportSource = new CrDhomaNePerdorim();
					break;
				case "ShfaqDhomatEPashlyera":
					this.crystalReportViewer1.ReportSource = new CrDhomatEPashlyera();
					break;
				case "ShfaqBilanci":
					this.crystalReportViewer1.ReportSource = new CrBilancSipasDatave();
					break;
				case "ShfaqBilanciPerDatenEdhene":
					CrBilancDitor cr = new CrBilancDitor();
					cr.SetDataSource(Application.StartupPath + "\\ShfaqBilanci.xml");
					this.crystalReportViewer1.ReportSource = cr;
					break;
				case "RezervimeVlefshme":
					this.crystalReportViewer1.ReportSource = new CrRezervimeVlefshme();
					break;
				case "RezervimeVlefshmePerAgjensi":
					this.crystalReportViewer1.ReportSource = new CrRezervimeVlefshmeAgjensi();
					break;
				case "RezervimeVlefshmePerEmerMbiemer":
					this.crystalReportViewer1.ReportSource = new CrRezervimeVlefshmeEmerMbiemer();
					break;
				case "Dhomat":
					this.crystalReportViewer1.ReportSource = new CrDhomat();
					break;
				case "ShfaqBilancMujor":
					CrBilancMujor cr2 = new CrBilancMujor();
					cr2.SetDataSource(Application.StartupPath + "\\BilancMujor.xml");
					this.crystalReportViewer1.ReportSource = new CrBilancMujor();
					break;
				case "ShfaqGrafikMujor":
					this.crystalReportViewer1.ReportSource = new CrGrafikMujor();
					break;
				case "HyrjeNeHotel":
					this.crystalReportViewer1.ReportSource = new CrHyrjeNeHotel();
					break;
				case "HyrjeNeHotelGrup":
					this.crystalReportViewer1.ReportSource = new CrHyrjeNeHotelGrup();
					break;
				case "FatureKlienti":
					this.crystalReportViewer1.ReportSource = new CrDorezoDhomeKlient();
					break;
				case "FatureKlientiAng":
					this.crystalReportViewer1.ReportSource = new CrDorezoDhomeKlientAng();
					break;
				case "FatureKlientiIt":
					this.crystalReportViewer1.ReportSource = new CrDorezoDhomeKlientIt();
					break;
				case "FatureKlientiFr":
					this.crystalReportViewer1.ReportSource = new CrDorezoDhomeKlientFr();
					break;
				case "FatureGrupi":
					this.crystalReportViewer1.ReportSource = new CrDorezoDhomaGrup();
					break;
				case "FatureGrupiAng":
					this.crystalReportViewer1.ReportSource = new CrDorezoDhomaGrupAng();
					break;
				case "FatureGrupiIt":
					this.crystalReportViewer1.ReportSource = new CrDorezoDhomaGrupIt();
					break;
				case "FatureGrupiFr":
					this.crystalReportViewer1.ReportSource = new CrDorezoDhomaGrupFr();
					break;
				case "FatureDhomaGrupi":
					this.crystalReportViewer1.ReportSource = new CrDorezoGrupPjeserisht();
					break;
				case "FatureDhomaGrupiAng":
					this.crystalReportViewer1.ReportSource = new CrDorezoGrupPjeserishtAng();
					break;
				case "FatureDhomaGrupiIt":
					this.crystalReportViewer1.ReportSource = new CrDorezoGrupPjeserishtIt();
					break;
				case "FatureDhomaGrupiFr":
					this.crystalReportViewer1.ReportSource = new CrDorezoGrupPjeserishtFr();
					break;
				case "FatureNjeDhomeGrupi":
					this.crystalReportViewer1.ReportSource = new CrDorezoDhomeGrupi();
					break;
				case "FatureNjeDhomeGrupiAng":
					this.crystalReportViewer1.ReportSource = new CrDorezoDhomeGrupiAng();
					break;
				case "FatureNjeDhomeGrupiIt":
					this.crystalReportViewer1.ReportSource = new CrDorezoDhomeGrupiIt();
					break;
				case "FatureNjeDhomeGrupiFr":
					this.crystalReportViewer1.ReportSource = new CrDorezoDhomeGrupiFr();
					break;
			}
		}

		
		/// <summary>
		/// Ben ngarkimin dhe printimin e raportit pa e hapur raportin ne PrintPreview, nepermjet nje
		/// printDialog.
		/// </summary>
		/// <param name="raporti"></param>
		public void Printo(string raporti)
		{
			PrintDocument printDocument = new PrintDocument();
			string printerName = "";
			short copies = 1;
			printDocument.DocumentName = "Raport";
			printDialog.Document = printDocument;
			if (printDialog.ShowDialog() != DialogResult.OK)
				return;
			printerName = printDialog.PrinterSettings.PrinterName;
			copies = printDialog.PrinterSettings.Copies;
			try
			{
				switch (raporti)
				{
					case "ShfaqDhomatEPashlyera":
						CrDhomatEPashlyera crDhomaPashlyera = new CrDhomatEPashlyera();
						crDhomaPashlyera.PrintOptions.PrinterName = printerName;
						crDhomaPashlyera.PrintToPrinter(copies, true, 0, 0);
						break;
					case "ShfaqBilanci":
						CrBilancSipasDatave crBilancSipasDatave = new CrBilancSipasDatave();
						crBilancSipasDatave.PrintOptions.PrinterName = printerName;
						crBilancSipasDatave.PrintToPrinter(copies, true, 0, 0);
						break;
					case "ShfaqBilanciPerDatenEdhene":
						CrBilancDitor crBilancDitor = new CrBilancDitor();
						crBilancDitor.PrintOptions.PrinterName = printerName;
						crBilancDitor.PrintToPrinter(copies, true, 0, 0);
						break;
					case "RezervimeVlefshme":
						CrRezervimeVlefshme crRezervimeVlefshme = new CrRezervimeVlefshme();
						crRezervimeVlefshme.PrintOptions.PrinterName = printerName;
						crRezervimeVlefshme.PrintToPrinter(copies, true, 0, 0);
						break;
					case "RezervimeVlefshmePerAgjensi":
						CrRezervimeVlefshmeAgjensi crRezervimeVlefshmeAgjensi = new CrRezervimeVlefshmeAgjensi();
						crRezervimeVlefshmeAgjensi.PrintOptions.PrinterName = printerName;
						crRezervimeVlefshmeAgjensi.PrintToPrinter(copies, true, 0, 0);
						break;
					case "RezervimeVlefshmePerEmerMbiemer":
						CrRezervimeVlefshmeEmerMbiemer crRezervimeVlefshmeEmerMbiemer = new CrRezervimeVlefshmeEmerMbiemer();
						crRezervimeVlefshmeEmerMbiemer.PrintOptions.PrinterName = printerName;
						crRezervimeVlefshmeEmerMbiemer.PrintToPrinter(copies, true, 0, 0);
						break;
					case "Dhomat":
						CrDhomat crDhomat = new CrDhomat();
						crDhomat.PrintOptions.PrinterName = printerName;
						crDhomat.PrintToPrinter(copies, true, 0, 0);
						break;
					case "ShfaqBilancMujor":
						CrBilancMujor crBilancMujor = new CrBilancMujor();
						crBilancMujor.PrintOptions.PrinterName = printerName;
						crBilancMujor.PrintToPrinter(copies, true, 0, 0);
						break;
					case "ShfaqGrafikMujor":
						CrGrafikMujor crGrafikMujor = new CrGrafikMujor();
						crGrafikMujor.PrintOptions.PrinterName = printerName;
						crGrafikMujor.PrintToPrinter(copies, true, 0, 0);
						break;
					case "HyrjeNeHotel":
						CrHyrjeNeHotel crHyrjeNeHotel = new CrHyrjeNeHotel();
						crHyrjeNeHotel.PrintOptions.PrinterName = printerName;
						crHyrjeNeHotel.PrintToPrinter(copies, true, 0, 0);
						break;
					case "HyrjeNeHotelGrup":
						CrHyrjeNeHotelGrup crHyrjeNeHotelGrup = new CrHyrjeNeHotelGrup();
						crHyrjeNeHotelGrup.PrintOptions.PrinterName = printerName;
						crHyrjeNeHotelGrup.PrintToPrinter(copies, true, 0, 0);
						break;
					case "FatureKlienti":
						CrDorezoDhomeKlient crDorezoDhomeKlient = new CrDorezoDhomeKlient();
						crDorezoDhomeKlient.PrintOptions.PrinterName = printerName;
						crDorezoDhomeKlient.PrintToPrinter(copies, true, 0, 0);
						break;
					case "FatureKlientiAng":
						CrDorezoDhomeKlientAng crDorezoDhomeKlient1 = new CrDorezoDhomeKlientAng();
						crDorezoDhomeKlient1.PrintOptions.PrinterName = printerName;
						crDorezoDhomeKlient1.PrintToPrinter(copies, true, 0, 0);
						break;
					case "FatureKlientiIt":
						CrDorezoDhomeKlientIt crDorezoDhomeKlient2 = new CrDorezoDhomeKlientIt();
						crDorezoDhomeKlient2.PrintOptions.PrinterName = printerName;
						crDorezoDhomeKlient2.PrintToPrinter(copies, true, 0, 0);
						break;
					case "FatureKlientiFr":
						CrDorezoDhomeKlientFr crDorezoDhomeKlient3 = new CrDorezoDhomeKlientFr();
						crDorezoDhomeKlient3.PrintOptions.PrinterName = printerName;
						crDorezoDhomeKlient3.PrintToPrinter(copies, true, 0, 0);
						break;
					case "FatureGrupi":
						CrDorezoDhomaGrup crDorezoDhomaGrup = new CrDorezoDhomaGrup();
						crDorezoDhomaGrup.PrintOptions.PrinterName = printerName;
						crDorezoDhomaGrup.PrintToPrinter(copies, true, 0, 0);
						break;
					case "FatureGrupiAng":
						CrDorezoDhomaGrupAng crDorezoDhomaGrup1 = new CrDorezoDhomaGrupAng();
						crDorezoDhomaGrup1.PrintOptions.PrinterName = printerName;
						crDorezoDhomaGrup1.PrintToPrinter(copies, true, 0, 0);
						break;
					case "FatureGrupiIt":
						CrDorezoDhomaGrupIt crDorezoDhomaGrup2 = new CrDorezoDhomaGrupIt();
						crDorezoDhomaGrup2.PrintOptions.PrinterName = printerName;
						crDorezoDhomaGrup2.PrintToPrinter(copies, true, 0, 0);
						break;
					case "FatureGrupiFr":
						CrDorezoDhomaGrupFr crDorezoDhomaGrup3 = new CrDorezoDhomaGrupFr();
						crDorezoDhomaGrup3.PrintOptions.PrinterName = printerName;
						crDorezoDhomaGrup3.PrintToPrinter(copies, true, 0, 0);
						break;
					case "CrDorezoGrupPjeserisht":
						CrDorezoGrupPjeserisht crDorezoGrupPjeserisht = new CrDorezoGrupPjeserisht();
						crDorezoGrupPjeserisht.PrintOptions.PrinterName = printerName;
						crDorezoGrupPjeserisht.PrintToPrinter(copies, true, 0, 0);
						break;
				}
			}
			catch
			{
				System.Windows.Forms.MessageBox.Show("Kontrolloni nese printeri qe keni zgjedhur per printim nuk ka probleme",
					"Printimi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Printim));
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.printDialog = new System.Windows.Forms.PrintDialog();
			this.toolBar1 = new VisionInfoSolutionLibrary.ToolBarPrint();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(824, 24);
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.AutoScroll = true;
			this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = null;
			this.crystalReportViewer1.Size = new System.Drawing.Size(824, 512);
			this.crystalReportViewer1.TabIndex = 1;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// toolBar1
			// 
			this.toolBar1.BackColor = System.Drawing.SystemColors.Control;
			this.toolBar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Size = new System.Drawing.Size(824, 28);
			this.toolBar1.TabIndex = 12;
			// 
			// Printim
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(824, 512);
			this.ControlBox = true;
			this.Controls.Add(this.toolBar1);
			this.Controls.Add(this.crystalReportViewer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "Printim";
			this.ShfaqTitull = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Print Preview";
			this.TitullGjeresi = 824;
			this.Load += new System.EventHandler(this.Printim_Load);
			this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.toolBar1, 0);
			this.ResumeLayout(false);

		}
		#endregion

		#region ToolBar Event Handler
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
		#endregion

		private void Printim_Load(object sender, System.EventArgs e)
		{
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
			this.RifreskoRaportin();
		}

		/// <summary>
		/// Kthe ne shqip te gjitha deklarimet qe jane ne anglisht te crystalReportViewer1
		/// </summary>
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
			this.Close();
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

	}
}
