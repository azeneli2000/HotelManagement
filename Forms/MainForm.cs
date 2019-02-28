using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using HotelManagment.Forms;
using HotelManagment.BusDatService;
using System.Xml;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.VisualStudioAnalyzer.PrimaryEventCollector;

namespace HotelManagment
{
	/// <summary>
	/// Forma kryesore e programit qe ben te gjitha inicializimet e nevojshme
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		#region Private Declarations
		private VisionInfoSolutionLibrary.MainMenu mainMenu1;
		private VisionInfoSolutionLibrary.MenuItem mVeprime;
		private DocumentManager.DocumentManager docManager;
		private VisionInfoSolutionLibrary.MenuItem mTeDhena;
		private VisionInfoSolutionLibrary.MenuItem mPrintPreview;
		private VisionInfoSolutionLibrary.MenuItem mPrint;
		private VisionInfoSolutionLibrary.MenuItem mDil;
		private VisionInfoSolutionLibrary.MenuItem mVizualizim;
		private VisionInfoSolutionLibrary.MenuItem mArka;
		private VisionInfoSolutionLibrary.MenuItem mKonfigurime;
		private VisionInfoSolutionLibrary.MenuItem mInstrumente;
		private VisionInfoSolutionLibrary.MenuItem mKrijoBackup;
		private VisionInfoSolutionLibrary.MenuItem mKarikoBackup;
		private VisionInfoSolutionLibrary.MenuItem mNdihme;
		private VisionInfoSolutionLibrary.MenuItem mRrethProg;
		private VisionInfoSolutionLibrary.MenuItem mPermbajtja;
		private VisionInfoSolutionLibrary.MenuItem mKontakt;
		private VisionInfoSolutionLibrary.MenuItem mRezervime;
		private System.ComponentModel.IContainer components;
		private VisionInfoSolutionLibrary.MenuItem mHyrje;
		private VisionInfoSolutionLibrary.MenuItem menuItem1;
		private VisionInfoSolutionLibrary.MenuItem mBilancDitor;
		private VisionInfoSolutionLibrary.MenuItem mBilancMujor;
		private VisionInfoSolutionLibrary.MenuItem mModifiko_Fshi_Rezervime;
		private VisionInfoSolutionLibrary.MenuItem mFut_Rezervim_ne_dhome;
		private VisionInfoSolutionLibrary.MenuItem mMerr_dhome;
		private VisionInfoSolutionLibrary.MenuItem mDorezo_dhome;
		private VisionInfoSolutionLibrary.MenuItem mModifiko_Fshi_veprim;
		private VisionInfoSolutionLibrary.MenuItem mHidh_detyrime;
		private VisionInfoSolutionLibrary.MenuItem mVizualizimi_i_gjendjes_se_dhomave;
		private VisionInfoSolutionLibrary.MenuItem mVizualizimi_i_dhomave_te_pashlyera;
		private VisionInfoSolutionLibrary.MenuItem mVizualizimi_i_dhomave_ne_perdorim;
		private VisionInfoSolutionLibrary.MenuItem mGjendja_ditore_e_arkes;
		private VisionInfoSolutionLibrary.MenuItem mBilanci;
		private VisionInfoSolutionLibrary.MenuItem mKonfigurimi_i_kategorive;
		private VisionInfoSolutionLibrary.MenuItem mKonfigurimi_i_dhomave;
		private VisionInfoSolutionLibrary.MenuItem mKonfigurimi_i_cmimeve;
		private VisionInfoSolutionLibrary.MenuItem mKonfigurimi_i_detyrimeve;
		private VisionInfoSolutionLibrary.MenuItem mHyrje_ne_Hotel;
		private VisionInfoSolutionLibrary.MenuItem mRezervime_te_vlefshme;
		private VisionInfoSolutionLibrary.MenuItem mShto_Rezervime;
		private VisionInfoSolutionLibrary.MenuItem mShpenzime;
		private VisionInfoSolutionLibrary.MenuItem mInformacione;
		private VisionInfoSolutionLibrary.MenuItem mRaporteDetyrimesh;
		private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
		private Janus.Windows.UI.Dock.UIPanel pnlNdihme;
		private Janus.Windows.UI.Dock.UIPanelInnerContainer pnlNdihmeContainer;
		private VisionInfoSolution.OfficeMenus officeMenus1;
		private VisionInfoSolutionLibrary.ToolBarControl toolBarControl1;
		private VisionInfoSolutionLibrary.MenuItem mIdentifikim;
		private VisionInfoSolutionLibrary.MenuItem mPerkthime;
		private VisionInfoSolutionLibrary.MenuItem mSettings;
		/// <summary>
		/// sherben per propertine Perdoruesi i cili mban perdoruesin e loguar per momentin
		/// </summary>
		private string perdoruesi = "";
		private int perdoruesId;
		private VisionInfoSolutionLibrary.MenuItem mPagesa;
		/// <summary>
		/// Fushe private qe ne varesi te perdoruesit te loguar do te beje ndryshimin
		/// e stilit te paraqitjes se formave, menuve
		/// </summary>
		private bool stilOffice = true;
		private VisionInfoSolutionLibrary.MenuItem mKontrollo_sistemin;
		private VisionInfoSolutionLibrary.WebBrowser dynHelp;
		private VisionInfoSolutionLibrary.MenuItem mNdihma;
		/// <summary>
		/// Variabel boolean qe percakton nese forma qe eshte aktive eshte Faqja Kryesore
		/// </summary>
		private bool faqeKryesore = false;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem mnuRregjistrimi;
		private System.Windows.Forms.MenuItem mnuNrSistemi;
		private System.Windows.Forms.ImageList menuImages;
		private string formaFundit;
		private VisionInfoSolutionLibrary.MenuItem mAlarm;
		private VisionInfoSolutionLibrary.MenuItem mHyrjeDalje;
		private System.Windows.Forms.ImageList imageList1;
		/// <summary>
		/// Sherben per te ruajtur te gjitha mesazhet qe ka ruajtur perdoruesi ne program
		/// </summary>
		private DataSet dsMesazhe = new DataSet();
		private bool exit = false;
		#endregion		

		#region Constructors & Destructors
		/// <summary>
		/// Paraqet Splash Sreen-in dhe inicializon MainFormin
		/// </summary>
		public MainForm()
		{
			SplashScreen1.SetStatus("Duke inicializuar te dhenat e formes kryesore...");
			System.Threading.Thread.Sleep(500);
			InitializeComponent();
			this.SetStyle(ControlStyles.SupportsTransparentBackColor |
				ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
			this.UpdateStyles();
			if (!this.Initialize())
				this.exit = true;
			Application.EnableVisualStyles();
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu1 = new VisionInfoSolutionLibrary.MainMenu();
            this.mTeDhena = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mPrint = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mPrintPreview = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mDil = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mVeprime = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mMerr_dhome = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mDorezo_dhome = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mModifiko_Fshi_veprim = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mHidh_detyrime = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mRezervime = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mShto_Rezervime = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mModifiko_Fshi_Rezervime = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mFut_Rezervim_ne_dhome = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mVizualizim = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mVizualizimi_i_gjendjes_se_dhomave = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mVizualizimi_i_dhomave_te_pashlyera = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mVizualizimi_i_dhomave_ne_perdorim = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mArka = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mGjendja_ditore_e_arkes = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mShpenzime = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mBilanci = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mBilancDitor = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mBilancMujor = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mKonfigurime = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mKonfigurimi_i_kategorive = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mKonfigurimi_i_dhomave = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mKonfigurimi_i_cmimeve = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mIdentifikim = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mKonfigurimi_i_detyrimeve = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mPagesa = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mHyrje_ne_Hotel = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mHyrje = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mRezervime_te_vlefshme = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mRaporteDetyrimesh = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mHyrjeDalje = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mInstrumente = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.menuItem1 = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mInformacione = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mKrijoBackup = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mKarikoBackup = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mPerkthime = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mSettings = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mAlarm = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mKontrollo_sistemin = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mNdihme = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mRrethProg = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mPermbajtja = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mKontakt = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mNdihma = new VisionInfoSolutionLibrary.MenuItem(this.components);
            this.mnuRregjistrimi = new System.Windows.Forms.MenuItem();
            this.mnuNrSistemi = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.docManager = new DocumentManager.DocumentManager();
            this.menuImages = new System.Windows.Forms.ImageList(this.components);
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.pnlNdihme = new Janus.Windows.UI.Dock.UIPanel();
            this.pnlNdihmeContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.dynHelp = new VisionInfoSolutionLibrary.WebBrowser();
            this.officeMenus1 = new VisionInfoSolution.OfficeMenus(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolBarControl1 = new VisionInfoSolutionLibrary.ToolBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNdihme)).BeginInit();
            this.pnlNdihme.SuspendLayout();
            this.pnlNdihmeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.Emri = null;
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mTeDhena,
            this.mVeprime,
            this.mRezervime,
            this.mVizualizim,
            this.mArka,
            this.mKonfigurime,
            this.mHyrje_ne_Hotel,
            this.mInstrumente,
            this.mNdihme});
            // 
            // mTeDhena
            // 
            this.mTeDhena.Emri = "";
            this.mTeDhena.Index = 0;
            this.mTeDhena.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mPrint,
            this.mPrintPreview,
            this.mDil});
            this.mTeDhena.Text = "Te Dhena";
            // 
            // mPrint
            // 
            this.mPrint.Emri = "";
            this.mPrint.Index = 0;
            this.mPrint.Text = "&Printo";
            this.mPrint.Click += new System.EventHandler(this.mPrint_Click);
            // 
            // mPrintPreview
            // 
            this.mPrintPreview.Emri = "";
            this.mPrintPreview.Index = 1;
            this.mPrintPreview.Text = "Print Preview";
            this.mPrintPreview.Click += new System.EventHandler(this.mPrintPreview_Click);
            // 
            // mDil
            // 
            this.mDil.Emri = "";
            this.mDil.Index = 2;
            this.mDil.Text = "Dil";
            this.mDil.Click += new System.EventHandler(this.mDil_Click);
            // 
            // mVeprime
            // 
            this.mVeprime.Emri = "";
            this.mVeprime.Index = 1;
            this.mVeprime.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mMerr_dhome,
            this.mDorezo_dhome,
            this.mModifiko_Fshi_veprim,
            this.mHidh_detyrime});
            this.mVeprime.Text = "Veprime";
            this.mVeprime.Click += new System.EventHandler(this.mVeprime_Click);
            // 
            // mMerr_dhome
            // 
            this.mMerr_dhome.Emri = "mMerr_dhome";
            this.mMerr_dhome.Index = 0;
            this.mMerr_dhome.Text = "Merr dhome";
            this.mMerr_dhome.Click += new System.EventHandler(this.mMerrDhome_Click);
            // 
            // mDorezo_dhome
            // 
            this.mDorezo_dhome.Emri = "mDorezo_dhome";
            this.mDorezo_dhome.Index = 1;
            this.mDorezo_dhome.Text = "Dorezo dhome";
            this.mDorezo_dhome.Click += new System.EventHandler(this.mDorezoDhome_Click);
            // 
            // mModifiko_Fshi_veprim
            // 
            this.mModifiko_Fshi_veprim.Emri = "mModifiko_Fshi_veprim";
            this.mModifiko_Fshi_veprim.Index = 2;
            this.mModifiko_Fshi_veprim.Text = "Modifiko/Fshi veprim";
            this.mModifiko_Fshi_veprim.Click += new System.EventHandler(this.mModifikoVeprim_Click);
            // 
            // mHidh_detyrime
            // 
            this.mHidh_detyrime.Emri = "mHidh_detyrime";
            this.mHidh_detyrime.Index = 3;
            this.mHidh_detyrime.Text = "Hidh detyrime";
            this.mHidh_detyrime.Click += new System.EventHandler(this.mDetyrime_Click);
            // 
            // mRezervime
            // 
            this.mRezervime.Emri = "";
            this.mRezervime.Index = 2;
            this.mRezervime.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mShto_Rezervime,
            this.mModifiko_Fshi_Rezervime,
            this.mFut_Rezervim_ne_dhome});
            this.mRezervime.Text = "Rezervime";
            // 
            // mShto_Rezervime
            // 
            this.mShto_Rezervime.Emri = "mShto_Rezervime";
            this.mShto_Rezervime.Index = 0;
            this.mShto_Rezervime.Text = "Shto &rezervim";
            this.mShto_Rezervime.Click += new System.EventHandler(this.mShtoRezervim_Click);
            // 
            // mModifiko_Fshi_Rezervime
            // 
            this.mModifiko_Fshi_Rezervime.Emri = "mModifiko_Fshi_Rezervime";
            this.mModifiko_Fshi_Rezervime.Index = 1;
            this.mModifiko_Fshi_Rezervime.Text = "Modifiko/Fshi rezervim";
            this.mModifiko_Fshi_Rezervime.Click += new System.EventHandler(this.mModifikoRezervim_Click);
            // 
            // mFut_Rezervim_ne_dhome
            // 
            this.mFut_Rezervim_ne_dhome.Emri = "mFut_Rezervim_ne_dhome";
            this.mFut_Rezervim_ne_dhome.Index = 2;
            this.mFut_Rezervim_ne_dhome.Text = "Fut rezervim ne dhome";
            this.mFut_Rezervim_ne_dhome.Click += new System.EventHandler(this.mPermbledhjeRezervim_Click);
            // 
            // mVizualizim
            // 
            this.mVizualizim.Emri = "";
            this.mVizualizim.Index = 3;
            this.mVizualizim.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mVizualizimi_i_gjendjes_se_dhomave,
            this.mVizualizimi_i_dhomave_te_pashlyera,
            this.mVizualizimi_i_dhomave_ne_perdorim});
            this.mVizualizim.Text = "Vizualizim";
            // 
            // mVizualizimi_i_gjendjes_se_dhomave
            // 
            this.mVizualizimi_i_gjendjes_se_dhomave.Emri = "mVizualizimi_i_gjendjes_se_dhomave";
            this.mVizualizimi_i_gjendjes_se_dhomave.Index = 0;
            this.mVizualizimi_i_gjendjes_se_dhomave.Text = "Gjendja e dhomave";
            this.mVizualizimi_i_gjendjes_se_dhomave.Click += new System.EventHandler(this.mGjendjeDhome_Click);
            // 
            // mVizualizimi_i_dhomave_te_pashlyera
            // 
            this.mVizualizimi_i_dhomave_te_pashlyera.Emri = "mVizualizimi_i_dhomave_te_pashlyera";
            this.mVizualizimi_i_dhomave_te_pashlyera.Index = 1;
            this.mVizualizimi_i_dhomave_te_pashlyera.Text = "Dhoma te pashlyera";
            this.mVizualizimi_i_dhomave_te_pashlyera.Click += new System.EventHandler(this.mPashlyerDhome_Click);
            // 
            // mVizualizimi_i_dhomave_ne_perdorim
            // 
            this.mVizualizimi_i_dhomave_ne_perdorim.Emri = "mVizualizimi_i_dhomave_ne_perdorim";
            this.mVizualizimi_i_dhomave_ne_perdorim.Index = 2;
            this.mVizualizimi_i_dhomave_ne_perdorim.Text = "Dhoma ne perdorim";
            this.mVizualizimi_i_dhomave_ne_perdorim.Click += new System.EventHandler(this.mPerdorimDhome_Click);
            // 
            // mArka
            // 
            this.mArka.Emri = "";
            this.mArka.Index = 4;
            this.mArka.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mGjendja_ditore_e_arkes,
            this.mShpenzime,
            this.mBilanci});
            this.mArka.Text = "Arka";
            // 
            // mGjendja_ditore_e_arkes
            // 
            this.mGjendja_ditore_e_arkes.Emri = "mGjendja_ditore_e_arkes";
            this.mGjendja_ditore_e_arkes.Index = 0;
            this.mGjendja_ditore_e_arkes.Text = "Gjendja ditore";
            this.mGjendja_ditore_e_arkes.Click += new System.EventHandler(this.mGjendjeDitore_Click);
            // 
            // mShpenzime
            // 
            this.mShpenzime.Emri = "mShpenzime";
            this.mShpenzime.Index = 1;
            this.mShpenzime.Text = "Shpenzime";
            this.mShpenzime.Click += new System.EventHandler(this.mShpenzime_Click);
            // 
            // mBilanci
            // 
            this.mBilanci.Emri = "mBilanci";
            this.mBilanci.Index = 2;
            this.mBilanci.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mBilancDitor,
            this.mBilancMujor});
            this.mBilanci.Text = "Bilanc";
            this.mBilanci.Click += new System.EventHandler(this.mBilanc_Click);
            // 
            // mBilancDitor
            // 
            this.mBilancDitor.Emri = "";
            this.mBilancDitor.Index = 0;
            this.mBilancDitor.Text = "&Bilanc ditor";
            this.mBilancDitor.Click += new System.EventHandler(this.mBilancDitor_Click);
            // 
            // mBilancMujor
            // 
            this.mBilancMujor.Emri = "";
            this.mBilancMujor.Index = 1;
            this.mBilancMujor.Text = "Bilanc mujor";
            this.mBilancMujor.Click += new System.EventHandler(this.mBilancMujor_Click);
            // 
            // mKonfigurime
            // 
            this.mKonfigurime.Emri = "";
            this.mKonfigurime.Index = 5;
            this.mKonfigurime.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mKonfigurimi_i_kategorive,
            this.mKonfigurimi_i_dhomave,
            this.mKonfigurimi_i_cmimeve,
            this.mIdentifikim,
            this.mKonfigurimi_i_detyrimeve,
            this.mPagesa});
            this.mKonfigurime.Text = "Konfigurime";
            // 
            // mKonfigurimi_i_kategorive
            // 
            this.mKonfigurimi_i_kategorive.Emri = "mKonfigurimi_i_kategorive";
            this.mKonfigurimi_i_kategorive.Index = 0;
            this.mKonfigurimi_i_kategorive.Text = "Kategori";
            this.mKonfigurimi_i_kategorive.Click += new System.EventHandler(this.mKategori_Click);
            // 
            // mKonfigurimi_i_dhomave
            // 
            this.mKonfigurimi_i_dhomave.Emri = "mKonfigurimi_i_dhomave";
            this.mKonfigurimi_i_dhomave.Index = 1;
            this.mKonfigurimi_i_dhomave.Text = "Dhome";
            this.mKonfigurimi_i_dhomave.Click += new System.EventHandler(this.mDhome_Click);
            // 
            // mKonfigurimi_i_cmimeve
            // 
            this.mKonfigurimi_i_cmimeve.Emri = "mKonfigurimi_i_cmimeve";
            this.mKonfigurimi_i_cmimeve.Index = 2;
            this.mKonfigurimi_i_cmimeve.Text = "&Cmime";
            this.mKonfigurimi_i_cmimeve.Click += new System.EventHandler(this.mCmime_Click);
            // 
            // mIdentifikim
            // 
            this.mIdentifikim.Emri = "mKonfigurimi_i_identifikimeve";
            this.mIdentifikim.Index = 3;
            this.mIdentifikim.Text = "Identifikim";
            this.mIdentifikim.Click += new System.EventHandler(this.mIdentifikim_Click);
            // 
            // mKonfigurimi_i_detyrimeve
            // 
            this.mKonfigurimi_i_detyrimeve.Emri = "mKonfigurimi_i_detyrimeve";
            this.mKonfigurimi_i_detyrimeve.Index = 4;
            this.mKonfigurimi_i_detyrimeve.Text = "Detyrim";
            this.mKonfigurimi_i_detyrimeve.Click += new System.EventHandler(this.mDetyrim_Click);
            // 
            // mPagesa
            // 
            this.mPagesa.Emri = "mKonfigurimi_i_pagesave";
            this.mPagesa.Index = 5;
            this.mPagesa.Text = "Pagesa";
            this.mPagesa.Click += new System.EventHandler(this.mPagesa_Click);
            // 
            // mHyrje_ne_Hotel
            // 
            this.mHyrje_ne_Hotel.Emri = "";
            this.mHyrje_ne_Hotel.Index = 6;
            this.mHyrje_ne_Hotel.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mHyrje,
            this.mRezervime_te_vlefshme,
            this.mRaporteDetyrimesh,
            this.mHyrjeDalje});
            this.mHyrje_ne_Hotel.Text = "Raporte";
            // 
            // mHyrje
            // 
            this.mHyrje.Emri = "mHyrje_ne_Hotel";
            this.mHyrje.Index = 0;
            this.mHyrje.Text = "Hyrjet ne hotel";
            this.mHyrje.Click += new System.EventHandler(this.mHyrje_Click);
            // 
            // mRezervime_te_vlefshme
            // 
            this.mRezervime_te_vlefshme.Emri = "mRezervime_te_vlefshme";
            this.mRezervime_te_vlefshme.Index = 1;
            this.mRezervime_te_vlefshme.Text = "Rezervime te vlefshme";
            this.mRezervime_te_vlefshme.Click += new System.EventHandler(this.mRezervimeVlefsheme_Click);
            // 
            // mRaporteDetyrimesh
            // 
            this.mRaporteDetyrimesh.Emri = "mDetyrime";
            this.mRaporteDetyrimesh.Index = 2;
            this.mRaporteDetyrimesh.Text = "Detyrimet";
            this.mRaporteDetyrimesh.Click += new System.EventHandler(this.mRaporteDetyrimesh_Click);
            // 
            // mHyrjeDalje
            // 
            this.mHyrjeDalje.Emri = "mHyrje_daljet_ne_hotel";
            this.mHyrjeDalje.Index = 3;
            this.mHyrjeDalje.Text = "Hyrje - daljet ne hotel";
            this.mHyrjeDalje.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // mInstrumente
            // 
            this.mInstrumente.Emri = "";
            this.mInstrumente.Index = 7;
            this.mInstrumente.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.mInformacione,
            this.mKrijoBackup,
            this.mKarikoBackup,
            this.mPerkthime,
            this.mSettings,
            this.mAlarm,
            this.mKontrollo_sistemin});
            this.mInstrumente.Text = "Instrumente";
            // 
            // menuItem1
            // 
            this.menuItem1.Emri = "";
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Konfigurimi i perdoruesve";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click_1);
            // 
            // mInformacione
            // 
            this.mInformacione.Emri = "";
            this.mInformacione.Index = 1;
            this.mInformacione.Text = "Informacione";
            this.mInformacione.Click += new System.EventHandler(this.mInformacione_Click);
            // 
            // mKrijoBackup
            // 
            this.mKrijoBackup.Emri = "";
            this.mKrijoBackup.Index = 2;
            this.mKrijoBackup.Text = "Krijo Backup";
            this.mKrijoBackup.Click += new System.EventHandler(this.mKrijoBackup_Click);
            // 
            // mKarikoBackup
            // 
            this.mKarikoBackup.Emri = "";
            this.mKarikoBackup.Index = 3;
            this.mKarikoBackup.Text = "Kariko Backup";
            this.mKarikoBackup.Click += new System.EventHandler(this.mKarikoBackup_Click);
            // 
            // mPerkthime
            // 
            this.mPerkthime.Emri = "mPerkthime";
            this.mPerkthime.Index = 4;
            this.mPerkthime.Text = "Perkthime";
            this.mPerkthime.Click += new System.EventHandler(this.mPerkthime_Click);
            // 
            // mSettings
            // 
            this.mSettings.Emri = "mRregullime";
            this.mSettings.Index = 5;
            this.mSettings.Text = "Rregullime";
            this.mSettings.Click += new System.EventHandler(this.mSettings_Click);
            // 
            // mAlarm
            // 
            this.mAlarm.Emri = "mAlarm";
            this.mAlarm.Index = 6;
            this.mAlarm.Text = "Alarm";
            this.mAlarm.Click += new System.EventHandler(this.mAlarm_Click);
            // 
            // mKontrollo_sistemin
            // 
            this.mKontrollo_sistemin.Emri = "mKontrollo_sistemin";
            this.mKontrollo_sistemin.Index = 7;
            this.mKontrollo_sistemin.Text = "Kontrollo sistemin";
            this.mKontrollo_sistemin.Click += new System.EventHandler(this.mKontrollo_sistemin_Click);
            // 
            // mNdihme
            // 
            this.mNdihme.Emri = "";
            this.mNdihme.Index = 8;
            this.mNdihme.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mRrethProg,
            this.mPermbajtja,
            this.mKontakt,
            this.mNdihma,
            this.mnuRregjistrimi,
            this.mnuNrSistemi,
            this.menuItem5});
            this.mNdihme.Text = "Ndihme";
            this.mNdihme.Click += new System.EventHandler(this.mNdihme_Click);
            // 
            // mRrethProg
            // 
            this.mRrethProg.Emri = "";
            this.mRrethProg.Index = 0;
            this.mRrethProg.Text = "Rreth Programit";
            this.mRrethProg.Click += new System.EventHandler(this.mRrethProg_Click);
            // 
            // mPermbajtja
            // 
            this.mPermbajtja.Emri = "";
            this.mPermbajtja.Index = 1;
            this.mPermbajtja.Text = "Permbajtja";
            this.mPermbajtja.Click += new System.EventHandler(this.mPermbajtja_Click);
            // 
            // mKontakt
            // 
            this.mKontakt.Emri = "";
            this.mKontakt.Index = 2;
            this.mKontakt.Text = "Kontakt";
            this.mKontakt.Click += new System.EventHandler(this.mKontakt_Click);
            // 
            // mNdihma
            // 
            this.mNdihma.Emri = "";
            this.mNdihma.Index = 3;
            this.mNdihma.Text = "Ndihme";
            this.mNdihma.Click += new System.EventHandler(this.mNdihma_Click);
            // 
            // mnuRregjistrimi
            // 
            this.mnuRregjistrimi.Index = 4;
            this.mnuRregjistrimi.Text = "Rregjistro programin";
            this.mnuRregjistrimi.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // mnuNrSistemi
            // 
            this.mnuNrSistemi.Index = 5;
            this.mnuNrSistemi.Text = "Numri i sistemit";
            this.mnuNrSistemi.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 6;
            this.menuItem5.Text = "Ndrysho numrin e dhomave";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // docManager
            // 
            this.docManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docManager.Location = new System.Drawing.Point(3, 29);
            this.docManager.Name = "docManager";
            this.docManager.Size = new System.Drawing.Size(685, 634);
            this.docManager.TabBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.docManager.TabHighlightColor = System.Drawing.SystemColors.Desktop;
            this.docManager.TabIndex = 0;
            this.docManager.TabShadowColor = System.Drawing.SystemColors.HotTrack;
            this.docManager.TabStripBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.docManager.UseCustomTabStripBackColor = true;
            this.docManager.WidgetColor = System.Drawing.SystemColors.Desktop;
            this.docManager.CloseButtonPressed += new DocumentManager.DocumentManager.CloseButtonPressedEventHandler(this.docManager_CloseButtonPressed);
            this.docManager.FocusedDocumentChanged += new System.EventHandler(this.docManager_FocusedDocumentChanged);
            // 
            // menuImages
            // 
            this.menuImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuImages.ImageStream")));
            this.menuImages.TransparentColor = System.Drawing.Color.White;
            this.menuImages.Images.SetKeyName(0, "");
            this.menuImages.Images.SetKeyName(1, "");
            this.menuImages.Images.SetKeyName(2, "");
            this.menuImages.Images.SetKeyName(3, "");
            this.menuImages.Images.SetKeyName(4, "");
            this.menuImages.Images.SetKeyName(5, "");
            this.menuImages.Images.SetKeyName(6, "");
            this.menuImages.Images.SetKeyName(7, "");
            this.menuImages.Images.SetKeyName(8, "");
            this.menuImages.Images.SetKeyName(9, "");
            this.menuImages.Images.SetKeyName(10, "");
            this.menuImages.Images.SetKeyName(11, "");
            this.menuImages.Images.SetKeyName(12, "");
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.pnlNdihme.Id = new System.Guid("49f718f0-259f-4665-8020-c1533f722ac5");
            this.uiPanelManager1.Panels.Add(this.pnlNdihme);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("49f718f0-259f-4665-8020-c1533f722ac5"), Janus.Windows.UI.Dock.PanelDockStyle.Right, new System.Drawing.Size(207, 634), true);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // pnlNdihme
            // 
            this.pnlNdihme.InnerContainer = this.pnlNdihmeContainer;
            this.pnlNdihme.Location = new System.Drawing.Point(688, 29);
            this.pnlNdihme.Name = "pnlNdihme";
            this.pnlNdihme.Size = new System.Drawing.Size(207, 634);
            this.pnlNdihme.TabIndex = 4;
            this.pnlNdihme.Text = "Ndihme";
            this.pnlNdihme.VisibleChanged += new System.EventHandler(this.pnlNdihme_VisibleChanged);
            this.pnlNdihme.SizeChanged += new System.EventHandler(this.pnlNdihme_SizeChanged);
            // 
            // pnlNdihmeContainer
            // 
            this.pnlNdihmeContainer.Controls.Add(this.dynHelp);
            this.pnlNdihmeContainer.Location = new System.Drawing.Point(5, 23);
            this.pnlNdihmeContainer.Name = "pnlNdihmeContainer";
            this.pnlNdihmeContainer.Size = new System.Drawing.Size(201, 610);
            this.pnlNdihmeContainer.TabIndex = 0;
            // 
            // dynHelp
            // 
            this.dynHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dynHelp.Location = new System.Drawing.Point(0, 0);
            this.dynHelp.Name = "dynHelp";
            this.dynHelp.Office2003 = true;
            this.dynHelp.Size = new System.Drawing.Size(201, 610);
            this.dynHelp.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            // 
            // toolBarControl1
            // 
            this.toolBarControl1.BackColor = System.Drawing.SystemColors.Control;
            this.toolBarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarControl1.Location = new System.Drawing.Point(0, 0);
            this.toolBarControl1.Name = "toolBarControl1";
            this.toolBarControl1.Size = new System.Drawing.Size(898, 26);
            this.toolBarControl1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(898, 666);
            this.Controls.Add(this.docManager);
            this.Controls.Add(this.pnlNdihme);
            this.Controls.Add(this.toolBarControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(906, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNdihme)).EndInit();
            this.pnlNdihme.ResumeLayout(false);
            this.pnlNdihmeContainer.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region Main Entry Point for the Application
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			try
			{
				CultureInfo al = new CultureInfo("sq-AL");
				Application.CurrentCulture = al;
				
                //SplashScreen1.ShowSplashScreen();
                //SplashScreen1.SetStatus("Duke ngarkuar formen kryesore...");
                //System.Threading.Thread.Sleep(100);
				// Krijojme instancen e MainForm
				MainForm mainForm = null;
				mainForm = new MainForm();
				if (mainForm.exit)
				{
					Application.Exit();
					return;
				}
                //SplashScreen1.SetStatus("Duke krijuar lidhjen me bazen e te dhenave...");
                //System.Threading.Thread.Sleep(500);
				Application.EnableVisualStyles();
				Application.DoEvents();
                //SplashScreen1.CloseForm();
				Application.Run(mainForm);
			}
			catch(Exception ex)
			{
				//System.Diagnostics.Trace.Write(ex.Message);
				throw new Exception(ex.Message);
				
			}
		}
		#endregion

		#region Private Methods	
		/// <summary>
		/// Shton nje forme te re ne tabin e formave qe hapet ne MainForm ose nese nje forme eshte e hapur
		/// njehere, atehere kalon fokusin ne ate forme
		/// </summary>
		/// <param name="frm">forma e cila do te krijohet ose do te marre fokusin</param>
		public void AddNewTab(VisionInfoSolutionLibrary.Form frm)
		{
			try
			{
				Type tipi = frm.GetType();
				int indeks = this.GetFormIndex(tipi);
				// Mund te kemi vetem nje forme te nje lloji te hapur
				if (indeks != -1)
				{
					// Kemi nje forme te hapur ne MainForm
					this.docManager.FocusedDocument = this.docManager.TabStrips[0].Documents[indeks];
					// Bej update menuve te printimit dhe skedarit te help-it
					this.ToggleMenuItems(frm);
					this.ShowHelp(frm.HelpFile);
					return;
				}
				formaFundit = frm.Name;
				// Beji update help-it
				this.ShowHelp(frm.HelpFile);
				// Percaktojme propertite Perdorues dhe StyleOffice 2003 per formen qe do te hapet
				frm.Perdorues = this.perdoruesi;
				frm.PerdoruesId = this.perdoruesId;
				frm.StyleOffice2003 = this.stilOffice;
				Cursor.Current = Cursors.WaitCursor;
				frm.ValidChanged += new VisionInfoSolutionLibrary.ValidChangeEventHandler(OnValidChanged); 
				DocumentManager.Document doc = new DocumentManager.Document(frm, frm.Text);
				this.ToggleMenuItems(frm);
				frm.MdiParent = this;
				frm.FormBorderStyle = FormBorderStyle.None;
				frm.Main = this;
				frm.ControlBox = false;
				// Vendosim propertine AutoScroll ne true, ne menyre qe programi te punoje me te gjitha
				// rezolucionet, megjithate aplikacioni punon me mire me rezolucionin 1024 x 768 
				if (frm.Name != "FaqeKryesore")
				{
					frm.AutoScroll = true;
					this.pnlNdihme.AutoHideButtonVisible = Janus.Windows.UI.InheritableBoolean.True;
					this.pnlNdihme.AutoHideActive = false;
					this.pnlNdihme.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.True;
					this.faqeKryesore = false;
				}
				else
				{
					frm.AutoScroll = false;
					this.pnlNdihme.Width = 200;
					this.pnlNdihme.AutoHideButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
					this.pnlNdihme.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
					this.faqeKryesore = true;
				}
				this.docManager.AddDocument(doc);
				this.docManager.FocusedDocument = doc;
			}
			catch(Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
		}
		
		
		private bool CloseForm(System.Windows.Forms.Form sysForm, DocumentManager.Document focusedDocument)
		{
			if (sysForm != null)
			{
				sysForm.ActiveControl = null;
				this.docManager.FocusedDocument = focusedDocument;
				sysForm.Close();
				return true;
				
			}
			return false;
		}

		
		/// <summary>
		/// Hiq tabin nga forma kryesore
		/// </summary>
		/// <param name="frm"></param>
		public void RemoveTab(VisionInfoSolutionLibrary.Form frm)
		{
			if(frm is FaqeKryesore)
			{
				// Anjehere nuk duhet te mbyllet faqja kryesore.
				return;
			}
			int index = this.GetFormIndex(frm.GetType());
			if(index != -1 && !frm.FormIsClosing)
			{
				if(frm != null )
				{
					frm.Close();
					frm.Dispose();
				}
				this.docManager.RemoveDocument(this.docManager.TabStrips[0].Documents[index]);
			}
		}


		/// <summary>
		/// Kthen indeksin e formes ne tab, nese kjo forme gjendet; perndryshe kthen -1
		/// </summary>
		/// <param name="formType">Forma</param>
		/// <returns>Indeksin</returns>
		private int GetFormIndex(Type formType)
		{
			if(this.docManager.TabStrips.Count > 0)
			{
				for(int i = 0; i < this.docManager.TabStrips[0].Documents.Count; i++)
				{
					if(this.docManager.TabStrips[0].Documents[i].Control.GetType() == formType)
					{
						return i;
					}
				}
			}
			return -1;
		}
		

		private void SetWidthForDynamicHelp()
		{
			// Do te leme rreth 150px per dritaren e dynamic help
			if(this.ClientSize.Width > 900)
				this.pnlNdihme.Size = new Size(this.ClientSize.Width - 750, this.pnlNdihme.Size.Height);
			else
				this.pnlNdihme.Size = new Size(150, this.pnlNdihme.Size.Height);
		}

		
		/// <summary>
		/// Shfaq skedarin e dhene html ne dritaren e ndihmes dinamike
		/// </summary>
		/// <param name="helpFile">Path-i i skedarit te ndihmes</param>
		private void ShowHelp(string helpFile)
		{
			// Update dritaren e ndihmes dinamike
			string path = Application.StartupPath;
				
			try
			{
				if(helpFile == Global.DefaultHelpFile)
				{
					dynHelp.Navigate(Global.DefaultHelpFile);
					return;
				}
				if(helpFile != "" && helpFile != null)
				{
#if DEBUG
					dynHelp.Navigate(Application.StartupPath + "\\Dyn Help\\" + helpFile);
#else
					dynHelp.Navigate(Application.StartupPath + "\\Dyn Help\\" + helpFile);
#endif
				}
				else
				{
					dynHelp.Navigate(Global.DefaultHelpFile);
				}
				// Nese dokumenti nuk arrin te ngarkohet atehere navigo ne faqen default
				if(dynHelp.Document == null)
				{
					dynHelp.Navigate(Global.DefaultHelpFile);
				}
			}
			catch(Exception ex)
			{
//				Microsoft.ApplicationBlocks.ExceptionManagement.ExceptionManager.Publish(ex);
//				if(this.showDynamicHelpErrorMessage)
//				{
//					MainForm.ShowMessageText("DynamicHelpError",SeverityLevels.Error);
//				}
//				this.showDynamicHelpErrorMessage = false;
			}
		}

		
		/// <summary>
		/// Kontrollon nese aplikacioni eshte i regjistruar apo jo.
		/// Nese nuk eshte i rregjistruar dhe ne databaze ka me shume se 3 dhoma te konfiguruara,
		/// atehere mbylle programin
		/// </summary>
		/// <returns>true nese versioni eshte i rregjistruar ose eshte VLERESUES dhe nuk i eshte
		/// cenuar baza e te dhenave. Perndryshe false</returns>
		private void CheckRegistration()
		{
			if (HotelManagment.RegistrationClass.IsDemoVersion())
			{}
		}
		
		
		/// <summary>
		/// Kontrollon nese programi po hapet per here te pare ne kete kompjuter.
		/// Kontrollin e ben duke u nisur nga IsolatedStorage qe ruhet per kete kompjuter
		/// </summary>
		/// <returns>true, nese programi po hapet per here te pare; false ne rast te kundert</returns>
		private bool CheckFirstTime()
		{
			if (Global.GetIsolatedStorageContent("FirstTime") != "false")
			{
				StreamWriter writer = Global.GetIsolatedStorageStreamWriter("FirstTime");
				writer.Close();
				Global.StoreToIsolatedStorage("FirstTime", "false");
				return true;
			}
			return false;
		}

		
		private string GetKeyValue(string name)
		{
			try
			{
				Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.Registry.LocalMachine;
				Microsoft.Win32.RegistryKey hkSoftware = hklm.OpenSubKey("Software", true);
				Microsoft.Win32.RegistryKey hkHotel = hkSoftware.OpenSubKey("VisionInfoSolution");
				Microsoft.Win32.RegistryKey key = hkHotel.OpenSubKey("HotelManagment");
				string[] vlerat = key.GetSubKeyNames();
				if (key != null)
					return key.GetValue(name).ToString();
				else
					return null;
			}
			catch
			{
				return null;
			}
		}


		#endregion

		#region Event Handlers
		
		private bool Initialize()
		{
			SplashScreen1.SetStatus("Duke bere inicializimet e nevojshme te programit...");
			System.Threading.Thread.Sleep(200);
			this.SetWidthForDynamicHelp();
			//System.Diagnostics.Trace.Listeners.Add(new TextWriterTraceListener("trace.log"));
			//this.Show();
			//StartTimer();
			// Kontrollojme nese programi eshte hapur per here te pare. Ne kete rast paraqesim mesazhin
			// qe i kujton perdoruesit qe eshte version demo dhe i japim edhe numrin serial qe duhet
			// per aktivizimin e programit
			if (this.CheckFirstTime())
			{
				SplashScreen1.HideSplash();
				NumriDhomave nrDhomash = new NumriDhomave(true);
				nrDhomash.ShowDialog();
				NumriSerial nrSerial = new NumriSerial();
				nrSerial.ShowDialog();
			}
			// Kontrollojme nese versioni qe po perdoret eshte DEMO apo i plote.
			// Per kete kontrollojme vleren qe eshte ne rregjistra dhe shohim nese i perket versionit
			// DEMO ose versionit te plote. Nese eshte version DEMO kontrollojme se sa dhoma ka te
			// konfiguruara. Nese ka me shume se 5 dhoma ose numri serial nuk i pergjigjet as versionit te plote
			// dhe as atij DEMO atehere jepi mesazh dhe mbyll programin
			SplashScreen1.SetStatus("Duke kontrolluar numrin e dhomave ne program...");
			System.Threading.Thread.Sleep(300);
			InputController data = new InputController();
			DataSet dsDhomaCount = data.KerkesaRead("ShfaqDhomat");
			int roomsCount = dsDhomaCount.Tables[0].Rows.Count;
			SplashScreen1.SetStatus("Duke kontrolluar versionin e programit...");
			System.Threading.Thread.Sleep(200);
			if (!RegistrationClass.IsDemoVersion())
			{
				if (!RegistrationClass.CelesVlefshem())
				{
					RegistrationClass.StoreKeyToRegistry(5);
				}
				else
				{
					if (roomsCount > RegistrationClass.GetRoomsCount())
					{
						System.Windows.Forms.MessageBox.Show("Ju nuk mund ta hapni programin. Numri i dhomave te ruajtura eshte me i madh se numri i dhomave per te cilin keni instaluar programin",
							"Numri i dhomave", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
					this.mnuNrSistemi.Visible = false;
					this.mnuRregjistrimi.Visible = false;
				}
			}
			else
			{
				if (roomsCount > 5)
				{
					System.Windows.Forms.MessageBox.Show("Ju nuk mund ta hapni programin. Numri i dhomave te ruajtura eshte me i madh se numri i dhomave per te cilin keni instaluar programin",
						"Numri i dhomave", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			// Kontrollo nese ka ndonje vlere ne rregjister qe do shtoje vlerat per skanim
			SplashScreen1.SetStatus("Duke kontrolluar vlerat ne rregjistra");
			System.Threading.Thread.Sleep(500);
			if (this.GetKeyValue("Skanim") == "true")
			{
				StreamWriter writer = Global.GetIsolatedStorageStreamWriter("Skanim");
				writer.Close();
				Global.StoreToIsolatedStorage("Skanim", "true");
			}
			else
			{
				StreamWriter writer = Global.GetIsolatedStorageStreamWriter("Skanim");
				writer.Close();
				Global.StoreToIsolatedStorage("Skanim", "false");
			}
			if (this.Logimi())
				this.AddNewTab(new FaqeKryesore());
			else
				return true;
			SplashScreen1.SetStatus("Duke kontrolluar menyren e paraqitjes se programit...");
			System.Threading.Thread.Sleep(200);
			if (this.stilOffice)
			{
				this.LoadMenuImages();
				officeMenus1.Start(this);
			}
			else
			{
				this.uiPanelManager1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Standard;
				this.docManager.UseCustomTabStripBackColor = false;
				this.docManager.TabBackColor = Color.FromKnownColor(KnownColor.Control);
				this.docManager.WidgetColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
				this.docManager.TabHighlightColor = Color.FromKnownColor(KnownColor.ControlLightLight);
				this.docManager.TabShadowColor = Color.Black;
			}
			this.toolBarControl1.office2003 = this.stilOffice;
			this.dynHelp.Office2003 = this.stilOffice;
			this.InitializeToolBar();
			return true;
		}

		
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			StartTimer();
		}

		private void MainForm_Resize(object sender, System.EventArgs e)
		{
			this.SetWidthForDynamicHelp();
		}
	
		private void docManager_FocusedDocumentChanged(object sender, System.EventArgs e)
		{
			if (this.docManager.FocusedDocument != null)
			{
				VisionInfoSolutionLibrary.Form frm = this.docManager.FocusedDocument.Control as VisionInfoSolutionLibrary.Form;
				if (frm.Name != this.formaFundit)
				{
					frm.PastroForme(frm);
					frm.NgarkoForme();
					this.formaFundit = frm.Name;
					frm.AutoScrollPosition = new Point(0, 0);
				}
				if (frm != null)
				{
					// Beji update help-it dhe menuve te printimit
					this.ShowHelp(frm.HelpFile);
					this.ToggleMenuItems(frm);
					Debug.WriteLine(String.Format("Dokumenti fokus: {0}", this.docManager.FocusedDocument.Text));
				}
				if (frm.Name != "FaqeKryesore")
				{
					this.pnlNdihme.AutoHideButtonVisible = Janus.Windows.UI.InheritableBoolean.True;
					this.pnlNdihme.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.True;
					this.faqeKryesore = false;
					this.pnlNdihme.AutoHide = true;
					frm.AutoScrollPosition = new Point(0, 0);
				}
				else
				{
					this.pnlNdihme.Width = 200;
					this.pnlNdihme.AutoHideButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
					this.pnlNdihme.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
					this.pnlNdihme.AutoHideActive = false;
					if (this.pnlNdihme.Closed)
						this.pnlNdihme.Closed = false;
					if (this.pnlNdihme.AutoHide)
						this.pnlNdihme.AutoHide = false;
					this.faqeKryesore = true;
				}
			}
		}

		private void OnReadyToPrintChanged(object sender, VisionInfoSolutionLibrary.ReadyChangedEventArgs e)
		{
			VisionInfoSolutionLibrary.Form frm = sender as VisionInfoSolutionLibrary.Form;
			if (frm != null)
			{
				VisionInfoSolutionLibrary.IPrintable printable = frm as VisionInfoSolutionLibrary.IPrintable;
				if (printable != null)
				{
					this.TogglePrintMenus(printable);
				}
			}
		}

		private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Hotel Manager", "Jeni të sigurtë që doni të dilni?",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
				e.Cancel = false;
			else
				e.Cancel = true;
		}

		private void docManager_CloseButtonPressed(object sender, DocumentManager.CloseButtonPressedEventArgs e)
		{
			// Faqja kryesore nuk duhet te mbyllet asnjehere
			if (this.docManager.FocusedDocument != null)
			{
				if (this.docManager.FocusedDocument.Control is FaqeKryesore)
					return;
				VisionInfoSolutionLibrary.Form sysForm = this.docManager.FocusedDocument.Control as VisionInfoSolutionLibrary.Form;
				if (this.CloseForm(sysForm, this.docManager.FocusedDocument))
				{
					if (this.docManager.TabStrips.Count > 0 && this.docManager.TabStrips[0].Documents.Contains(this.docManager.FocusedDocument))
					{
						this.docManager.RemoveDocument(this.docManager.FocusedDocument);
					}
				}
			}
		}

		
		private void OnValidChanged(object sender, VisionInfoSolutionLibrary.ValidChangeEventArgs e)
		{
			bool enableSave = false;
			VisionInfoSolutionLibrary.Form frm = sender as VisionInfoSolutionLibrary.Form;
			VisionInfoSolutionLibrary.TabPageControl tab = sender as VisionInfoSolutionLibrary.TabPageControl;
			if (frm != null)
			{
				if (frm.Name == "Rezervime")
				{
					enableSave = true;
				}
			}
			else if (tab != null)
			{
				enableSave = true;
			}
		}

		/// <summary>
		/// Nuk duhet te lejohet ndryshimi i madhesise se pnlNdihme nese jemi ne
		/// Faqen Kryesore
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlNdihme_SizeChanged(object sender, System.EventArgs e)
		{
			if (this.faqeKryesore)
				this.pnlNdihme.Width = 200;
		}

		
		#region Menu Events

		private void mRezervime_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new Rezervime());
		}

		
		private void mPrint_Click(object sender, System.EventArgs e)
		{
			if (this.docManager.FocusedDocument == null)
				return;
			VisionInfoSolutionLibrary.IPrintable frm = this.docManager.FocusedDocument.Control as VisionInfoSolutionLibrary.IPrintable;
			if (frm != null)
			{
				this.Cursor = Cursors.WaitCursor;
				frm.Print();
				this.Cursor = Cursors.Default;
			}
		}

		private void mPrintPreview_Click(object sender, System.EventArgs e)
		{
			if (this.docManager.FocusedDocument == null)
				return;
			VisionInfoSolutionLibrary.IPrintable frm = this.docManager.FocusedDocument.Control as VisionInfoSolutionLibrary.IPrintable;
			if (frm != null)
			{
				this.Cursor = Cursors.WaitCursor;
				frm.PrintPreview();
				this.Cursor = Cursors.Default;
			}
		}
		
		
		private void mDorezoDhome_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new DorezoDhome1());
		}

		
		private void mGjendjeDhome_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new GjendjeDhome());
		}

		private void mIdentifikim_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new frmIdentifikimi());
		}

		private void mPerdorimDhome_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new DhomatNePerdorim());
		}


		private void mPashlyerDhome_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new DhomaPashlyera());
		}

		
		private void mGjendjeDitore_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new GjendjeDitore());
		}

		private void mKategori_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new Kategori());
		}

		private void mDhome_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new Dhome());
		}
		
		private void mRuaj_Click(object sender, System.EventArgs e)
		{
			if (this.docManager.FocusedDocument != null)
			{
				VisionInfoSolutionLibrary.Form frm = this.docManager.FocusedDocument.Control as VisionInfoSolutionLibrary.Form;
				if (frm != null)
					frm.Save();
			}
		}

		private void mNdihme_Click(object sender, System.EventArgs e)
		{
		
		}

		private void mPermbajtja_Click(object sender, System.EventArgs e)
		{
			if (this.pnlNdihme.Closed)
				this.pnlNdihme.Closed = false;
			else if (this.pnlNdihme.AutoHide)
				this.pnlNdihme.AutoHide = false;
		}

		private void mModifikoRezervim_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab( new ModifikoRezervim());
		}

		

		private void mPermbledhjeRezervim_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab( new FutRezervimNeDhome());
		}

		private void mVeprime_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem1_Click_1(object sender, System.EventArgs e)
		{
			this.AddNewTab(new frmPerdorues());	
		}

		private void mModifikoVeprim_Click(object sender, System.EventArgs e)
		{
			//this.AddNewTab( new ModifikoVeprim());
			this.AddNewTab( new frmModifikimeVeprimeKlient());
		}

		private void mDetyrime_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab( new HidhDetyrime());
		}
		
		private void mShtoRezervim_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab( new Rezervime());
		}

		private void mMerrDhome_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab( new MerrDhome());
		}


		private void mBilanc_Click(object sender, System.EventArgs e)
		{
			
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void mKryejShpenzim_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab( new KryejShpenzim());
		}

		private void mInformacione_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab( new frmTeDhenaHoteli());
		}

		private void mDetyrim_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab( new Detyrimet());
		}


		private void mSettings_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new HotelManagment.Forms.Settings());
		}

		private void mCmime_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab( new KonfiguroCmime());
		}

		private void mRezervimeVlefsheme_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab( new RezervimeVlefshme());
		}

		private void mHyrje_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab( new HyrjeNeHotel());
		}

		private void mShpenzime_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab( new KryejShpenzim());
		}

		private void mBilancDitor_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab( new Bilanc());
		}
		private void mBilancMujor_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab( new BilancMujor());
		}
		private void mPerkthime_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new Perkthime());
		}
		private void mRaporteDetyrimesh_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new RaporteDetyrimesh());
		}
	
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new RaporteKlienteDale());
		}

		private void mKontakt_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new Kontakt());
		}
		private void mPagesa_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new Pagesa());
		}

		private void mKontrollo_sistemin_Click(object sender, System.EventArgs e)
		{
			Integriteti integritet = new Integriteti();
			integritet.Main = this;
			integritet.Perdorues = this.perdoruesi;
			integritet.PerdoruesId = this.perdoruesId;
			integritet.StyleOffice2003 = this.stilOffice;
			integritet.ShowDialog(this);
		}

		private void mNdihma_Click(object sender, System.EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				System.Diagnostics.Process.Start(Application.StartupPath + @"\Helpexe\HtmlHelpViewer.exe");
			}
			catch
			{}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
			//this.AddNewTab(new BrowserContainer());
		}

		private void mRrethProg_Click(object sender, System.EventArgs e)
		{
			About about = new About();
			about.StyleOffice2003 = this.stilOffice;
			about.ShowDialog(this);
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			
			Rregjistrimi rregjistrimi = new Rregjistrimi();
			rregjistrimi.ShowDialog();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			NumriSerial nrSerial = new NumriSerial();
			nrSerial.ShowDialog();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			NumriDhomave nrDhomash = new NumriDhomave();
			nrDhomash.ShowDialog();
		}


		private void mAlarm_Click(object sender, System.EventArgs e)
		{
			this.AddNewTab(new Reminder());
		}
		#endregion

		#endregion

		#region Toggle Menus & Buttons

		/// <summary>
		/// Ndrysho gjendjet (enable dhe disable) te butonave print dhe printPreview
		/// </summary>
		/// <param name="frm"></param>
		private void TogglePrintMenus(VisionInfoSolutionLibrary.IPrintable frm)
		{
			if (frm.ReadyToPrint)
			{
				this.mPrint.Enabled = true;
				this.mPrintPreview.Enabled = true;
				this.toolBarControl1.tPrint.Enabled = true;
				this.toolBarControl1.tPrintPreview.Enabled = true;
			}
			else
			{
				this.toolBarControl1.tPrintPreview.Enabled = false;
				this.toolBarControl1.tPrint.Enabled = false;
				this.mPrint.Enabled = false;
				this.mPrintPreview.Enabled = false;
			}
		}

		private void ToggleMenuItems(VisionInfoSolutionLibrary.Form frm)
		{
			VisionInfoSolutionLibrary.IPrintable printable = frm as VisionInfoSolutionLibrary.IPrintable;
			if (printable != null)
			{
				printable.ReadyToPrintChanged += new VisionInfoSolutionLibrary.ReadyChangedEventHandler(OnReadyToPrintChanged);
				this.TogglePrintMenus(printable);
				// Kontrollojme nese ekziston direktoria ku hidhen skedaret XML per printimin
				// e raporteve
				if (!Directory.Exists("C:\\Program Files\\VisionInfoSolution\\HotelManagment\\"))
					Directory.CreateDirectory("C:\\Program Files\\VisionInfoSolution\\HotelManagment\\");
				if (printable.ReadyToPrint)
				{
					this.mPrint.Enabled = true;
					this.mPrintPreview.Enabled = true;
					this.toolBarControl1.tPrint.Enabled = true;
					this.toolBarControl1.tPrintPreview.Enabled = true;
				}
				else
				{
					this.mPrint.Enabled = false;
					this.mPrintPreview.Enabled = false;
					this.toolBarControl1.tPrint.Enabled = false;
					this.toolBarControl1.tPrintPreview.Enabled = false;
				}
			}
			else
			{
				this.mPrint.Enabled = false;
				this.mPrintPreview.Enabled = false;
				this.toolBarControl1.tPrint.Enabled = false;
				this.toolBarControl1.tPrintPreview.Enabled = false;
			}
			
		}

		private void LoadMenuImages()
		{
			try
			{
//				this.officeMenus1.AddPicture(this.mPrint, 3);
//				this.officeMenus1.AddPicture(this.mPrintPreview, 4);
//				this.officeMenus1.AddPicture(this.mMerr_dhome, 5);
//				this.officeMenus1.AddPicture(this.mFut_Rezervim_ne_dhome, 6);
//				this.officeMenus1.AddPicture(this.mDorezo_dhome, 7);
//				this.officeMenus1.AddPicture(this.mShto_Rezervime, 8);
//				this.officeMenus1.AddPicture(this.mArka, 9);
//				this.officeMenus1.AddPicture(this.mHidh_detyrime, 10);
//				this.officeMenus1.AddPicture(this.mHyrjeDalje, 11);
//				this.officeMenus1.AddPicture(this.mVizualizimi_i_gjendjes_se_dhomave, 12);
			}
			catch(Exception ex)
			{
				return;
			}
		}

		/// <summary>
		/// Percakton nese butonat e toolbarit do te jene enabled apo jo, si dhe shton eventet
		/// per keto butona
		/// </summary>
		private void InitializeToolBar()		
		{
			this.toolBarControl1.tDorezo_dhome.Enabled = this.mDorezo_dhome.Enabled;
			this.toolBarControl1.tFut_Rezervim_ne_dhome.Enabled = this.mFut_Rezervim_ne_dhome.Enabled;
			this.toolBarControl1.tGjendja_ditore_e_arkes.Enabled = this.mGjendja_ditore_e_arkes.Enabled;
			this.toolBarControl1.tHidh_detyrime.Enabled = this.mHidh_detyrime.Enabled;
			this.toolBarControl1.tHyrje.Enabled = this.mHyrje.Enabled;
			this.toolBarControl1.tMerr_dhome.Enabled = this.mMerr_dhome.Enabled;
			this.toolBarControl1.tShto_Rezervime.Enabled = this.mShto_Rezervime.Enabled;
			this.toolBarControl1.tVizualizimi_i_gjendjes_se_dhomave.Enabled = this.mVizualizimi_i_gjendjes_se_dhomave.Enabled;

			this.toolBarControl1.tPrint.Click +=new EventHandler(tPrint_Click);
			this.toolBarControl1.tPrintPreview.Click +=new EventHandler(tPrintPreview_Click);
			this.toolBarControl1.tMerr_dhome.Click +=new EventHandler(tMerr_dhome_Click);
			this.toolBarControl1.tShto_Rezervime.Click +=new EventHandler(tShto_Rezervime_Click);
			this.toolBarControl1.tFut_Rezervim_ne_dhome.Click +=new EventHandler(tFut_Rezervim_ne_dhome_Click);
			this.toolBarControl1.tDorezo_dhome.Click +=new EventHandler(tDorezo_dhome_Click);
			this.toolBarControl1.tHidh_detyrime.Click +=new EventHandler(tHidh_detyrime_Click);
			this.toolBarControl1.tVizualizimi_i_gjendjes_se_dhomave.Click +=new EventHandler(tVizualizimi_i_gjendjes_se_dhomave_Click);
			this.toolBarControl1.tHyrje.Click += new EventHandler(tHyrje_Click);
			this.toolBarControl1.tGjendja_ditore_e_arkes.Click +=new EventHandler(tGjendja_ditore_e_arkes_Click);
			this.toolBarControl1.tAbout.Click +=new EventHandler(tAbout_Click);
			this.toolBarControl1.tNdihme.Click += new EventHandler(tNdihme_Click);
		}
		#endregion

		#region Logimi dhe Te Drejtat
		private bool Logimi ()
		{
			bool sukses = false;
			DataSet dsSettings = new DataSet();
			if (File.Exists(Application.StartupPath + "\\Settings.xml"))
				dsSettings.ReadXml(Application.StartupPath + "\\Settings.xml");
			else
			{
				dsSettings.Tables.Add("Settings");
				dsSettings.Tables[0].Columns.Add("Perdorues", typeof(String));
				dsSettings.Tables[0].Columns.Add("Office", typeof(Boolean));
				DataRow dr = dsSettings.Tables[0].NewRow();
				dr[0] = "";
				dr[1] = true;
				this.stilOffice = true;
				dsSettings.Tables[0].Rows.Add(dr);
				dsSettings.AcceptChanges();
				dsSettings.WriteXml(Application.StartupPath + "\\Settings.xml", XmlWriteMode.WriteSchema);
			}
			this.stilOffice = (Boolean)dsSettings.Tables[0].Rows[0][1];
			// Nese nuk ka perdorues atehere hap programin pa i kerkuar perdoruesit password
			if (!Login.KontrolloPerdoruesit())
			{
				// Kontrollo per stilin e perdoruesit qe ka zgjedhur
				DataRow drPerdorues = (DataRow)dsSettings.Tables[0].Select("Perdorues = ''").GetValue(0);
				this.stilOffice = Convert.ToBoolean(drPerdorues[1]);
				return true;
			}
			SplashScreen1.HideSplash();
			Login.ShowForm();
			string username = Login.emer;
			string password = Login.fjalekalim;
			// Nese perdoruesi klikon ne kutine e mbylljes se formes atehere mbyll gjithe aplikacionin
			if (username == "" || password == "" || username == null || password == null)
			{
				Application.Exit();
				return false;
			}
			try
			{
				sukses = Login.Logimi(username, password);
			}	
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				Application.Exit();
				return false;
			}
			if (!sukses)
			{
				this.Logimi();
			}
			// Ne baze te rolit qe ka ky perdorues qe do te logohet bejme ngarkimin e te drejtave
			this.perdoruesi = Login.emer;
			this.perdoruesId = Login.userId;
			// Ngarkojme settings per perdoruesin
			if (dsSettings.Tables[0].Select("Perdorues = '" + this.perdoruesi + "'").Length > 0)
			{
				DataRow drPerdorues = (DataRow)dsSettings.Tables[0].Select("Perdorues = '" + this.perdoruesi + "'").GetValue(0);
				this.stilOffice = Convert.ToBoolean(drPerdorues[1]);
			}
			else
			{
				this.stilOffice = true;
				DataRow dr1 = dsSettings.Tables[0].NewRow();
				dr1[0] = this.perdoruesi;
				dr1[1] = true;
				dsSettings.Tables[0].Rows.Add(dr1);
				dsSettings.WriteXml(Application.StartupPath + "\\Settings.xml", XmlWriteMode.WriteSchema);
			}
			this.NgarkoTeDrejtat(Login.rolID);
			SplashScreen1.ShowSplash();
			return true;
		}

		private void NgarkoTeDrejtat(int rolID)
		{
			// Hap skedarin Xml qe permban settings per perdoruesin
			// Nese perdoruesi eshte administrator atehere ai ka te gjitha te drejtat mbi aplikacionin
			if (rolID == 1)
				return;
			// Perndryshe ngarko te gjitha te dhenat nga skedari XML
			//mInstrumente.Enabled = false;
			this.mKarikoBackup.Enabled = false;
			this.mKrijoBackup.Enabled = false;
			this.menuItem5.Enabled = false;
			if (this.mnuNrSistemi.Visible)
			{
				this.mnuNrSistemi.Enabled = false;
				this.mnuRregjistrimi.Enabled = false;
				this.menuItem5.Enabled = false;
			}
			bool vlera = false;
			string menuName = "";
			bool uGjet = false;
			string fileName = Application.StartupPath + "\\Konfigurime.xml";
			XmlTextReader tr = new XmlTextReader(fileName);
			try
			{
				while (tr.Read())
				{
					if (tr.Value == "0" || tr.Value == "1")
					{
						if (tr.Value == "0")
							vlera = false;
						else
							vlera = true;
						tr.Read();
						menuName = tr.Name;
						foreach(VisionInfoSolutionLibrary.MenuItem menuItem in mainMenu1.MenuItems)
						{
							uGjet = false;
							foreach (VisionInfoSolutionLibrary.MenuItem menuItemCol in menuItem.MenuItems)
							{
								if (menuItemCol.Emri == ("m" + menuName))
								{
									if (vlera == true)
										menuItemCol.Enabled = true;
									else
										menuItemCol.Enabled = false;
									vlera = false;
									uGjet = true;
									break;
								}
							}
							if (uGjet)
								break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				return;
			}
			finally
			{
				tr.Close();
			}
		}

		private void MainForm_Activated(object sender, System.EventArgs e)
		{
			//SplashScreen.CloseSplash();
		}

		private void mDil_Click(object sender, System.EventArgs e)
		{
			DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Hotel Manager", "Jeni te sigurtë që doni të dilni nga programi?",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
				Application.Exit();
		}

		private void pnlNdihme_VisibleChanged(object sender, System.EventArgs e)
		{
			this.pnlNdihme.BringToFront();
		}

		public string Perdoruesi
		{
			get
			{
				return this.perdoruesi;
			}
		}

		public int PerdoruesId
		{
			get
			{
				return this.perdoruesId;
			}
		}
		
		#endregion

		#region ToolBarEventHandlers
		private void tPrint_Click(object sender, EventArgs e)
		{
			if (this.docManager.FocusedDocument == null)
				return;
			VisionInfoSolutionLibrary.IPrintable frm = this.docManager.FocusedDocument.Control as VisionInfoSolutionLibrary.IPrintable;
			if (frm != null)
			{
				this.Cursor = Cursors.WaitCursor;
				frm.Print();
				this.Cursor = Cursors.Default;
			}
		}

		private void tPrintPreview_Click(object sender, EventArgs e)
		{
			if (this.docManager.FocusedDocument == null)
				return;
			VisionInfoSolutionLibrary.IPrintable frm = this.docManager.FocusedDocument.Control as VisionInfoSolutionLibrary.IPrintable;
			if (frm != null)
			{
				this.Cursor = Cursors.WaitCursor;
				frm.PrintPreview();
				this.Cursor = Cursors.Default;
			}
		}

		private void tMerr_dhome_Click(object sender, EventArgs e)
		{
			this.AddNewTab( new MerrDhome());
		}

		private void tShto_Rezervime_Click(object sender, EventArgs e)
		{
			this.AddNewTab( new Rezervime());
		}

		private void tFut_Rezervim_ne_dhome_Click(object sender, EventArgs e)
		{
			this.AddNewTab( new FutRezervimNeDhome());
		}

		private void tDorezo_dhome_Click(object sender, EventArgs e)
		{
			this.AddNewTab(new DorezoDhome1());
		}

		private void tHidh_detyrime_Click(object sender, EventArgs e)
		{
			this.AddNewTab( new HidhDetyrime());
		}

		private void tVizualizimi_i_gjendjes_se_dhomave_Click(object sender, EventArgs e)
		{
			this.AddNewTab(new GjendjeDhome());
		}

		private void tHyrje_Click(object sender, EventArgs e)
		{
			this.AddNewTab( new HyrjeNeHotel());
		}

		private void tGjendja_ditore_e_arkes_Click(object sender, EventArgs e)
		{
			this.AddNewTab(new GjendjeDitore());
		}

		private void tAbout_Click(object sender, EventArgs e)
		{
			About about = new About();
			about.StyleOffice2003 = this.stilOffice;
			about.ShowDialog(this);
		}

		private void tNdihme_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				System.Diagnostics.Process.Start(Application.StartupPath + @"\Helpexe\HtmlHelpViewer.exe");
			}
			catch
			{}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Shfaq file-in specifik ne dritaren e ndihmes dinamike
		/// </summary>
		/// <param name="helpFile"></param>
		public void ShfaqNdihme(string helpFile)
		{
			string path = Application.StartupPath;
		}
		#endregion

		#region Timer Handling
		#region Private Fields
		private int ID_CB_Timer;
		private int Cnt_CB_Timer;
		private int ID_WN_Timer;
		private int Cnt_WN_Timer;
		private TimerProc Cb = null;
		#endregion

		public void StartTimer()
		{
			try
			{
				this.dsMesazhe.Tables.Clear();
				this.dsMesazhe.ReadXml(Application.StartupPath + "\\MesazheAlarmi.xml");
				if (dsMesazhe.Tables[0].Rows.Count > 0)
				{
					DateTime dt = this.ConvertToDateTime(dsMesazhe.Tables[0].Rows[0][0].ToString());
					string mesazh = dsMesazhe.Tables[0].Rows[0][1].ToString();
					TimeSpan dt1 = dt.Subtract(DateTime.Now);
					int dateInt = (Int32)dt1.TotalMilliseconds;
					if (dateInt > 0)
					{
						// Nese nuk ka asnje mesazh te papariqitur atehere vendos timerin per mesazhin e pare
						Cb = new TimerProc(this.OnTickTimer);
						this.ID_CB_Timer = SetTimer(IntPtr.Zero, 0, dateInt, Cb);
					}
					else
					{
						// Perndryshe hiq te gjitha rreshtat me mesazhe qe iu ka kaluar koha, dhe jepi nje
						// mesazh perdoruesit me te gjitha tekstet dhe oret e mesazheve qe iu ka kaluar ora
						this.dsMesazhe.Tables.Clear();
						this.dsMesazhe.ReadXml(Application.StartupPath + "\\MesazheAlarmi.xml");
						string mesazhTotal = "";
						for (int i = 0; i < dsMesazhe.Tables[0].Rows.Count; i++)
						{
							DataRow dr = this.dsMesazhe.Tables[0].Rows[i];
							dt = this.ConvertToDateTime(dr["Data"].ToString());
							dt1 = dt.Subtract(DateTime.Now);
							dateInt = (Int32)dt1.TotalMilliseconds;
							if (dateInt <= 0)
							{
								mesazhTotal += dr["Data"].ToString() + "\t\t" + dr[1].ToString() + Environment.NewLine;
								dsMesazhe.Tables[0].Rows.Remove(dr);
								i--;
							}
							else if (dateInt > 0)
							{
								Cb = new TimerProc(this.OnTickTimer);
								this.ID_CB_Timer = SetTimer(IntPtr.Zero, 0, dateInt, Cb);
								break;
							}
						}
						dsMesazhe.WriteXml(Application.StartupPath + "\\MesazheAlarmi.xml", XmlWriteMode.WriteSchema);
						System.Windows.Forms.MessageBox.Show("Keni mesazhe te cilave iu ka kaluar afati i leximit" +
							Environment.NewLine + mesazhTotal, "Mesazhe alarmi",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch(Exception ex)
			{
				return;
			}
		}

		public void StartTimer1()
		{
			try
			{
				this.dsMesazhe.Tables.Clear();
				this.dsMesazhe.ReadXml(Application.StartupPath + "\\MesazheAlarmi.xml");
				if (dsMesazhe.Tables[0].Rows.Count > 0)
				{
					DateTime dt = this.ConvertToDateTime(dsMesazhe.Tables[0].Rows[0][0].ToString());
					string mesazh = dsMesazhe.Tables[0].Rows[0][1].ToString();
					TimeSpan dt1 = dt.Subtract(DateTime.Now);
					int dateInt = (Int32)dt1.TotalMilliseconds;
					if (dateInt > 0)
					{
						// Nese nuk ka asnje mesazh te paparaqitur atehere vendos timerin per mesazhin e pare
						Cb = new TimerProc(this.OnTickTimer);
						this.ID_CB_Timer = SetTimer(IntPtr.Zero, 0, dateInt, Cb);
					}
					else
					{
						// Perndryshe hiq te gjitha rreshtat me mesazhe qe iu ka kaluar koha, dhe jepi nje
						// mesazh perdoruesit me te gjitha tekstet dhe oret e mesazheve qe iu ka kaluar ora
						string mesazhTotal = "";
						this.dsMesazhe.Tables.Clear();
						this.dsMesazhe.ReadXml(Application.StartupPath + "\\MesazheAlarmi.xml");
						for (int i = 0; i < dsMesazhe.Tables[0].Rows.Count; i++)
						{
							DataRow dr = this.dsMesazhe.Tables[0].Rows[i];
							dt = this.ConvertToDateTime(dr["Data"].ToString());
							dt1 = dt.Subtract(DateTime.Now);
							dateInt = (Int32)dt1.TotalMilliseconds;
							if (dateInt <= 0)
							{
								System.Windows.Forms.MessageBox.Show(this, dr[1].ToString(), "Mesazh Alarmi", MessageBoxButtons.OK,
									MessageBoxIcon.Information);
								dsMesazhe.Tables[0].Rows.Remove(dr);
								dsMesazhe.AcceptChanges();
								i--;
								dsMesazhe.WriteXml(Application.StartupPath + "\\MesazheAlarmi.xml", XmlWriteMode.WriteSchema);
							}
							else if (dateInt > 0)
							{
								Cb = new TimerProc(this.OnTickTimer);
								this.ID_CB_Timer = SetTimer(IntPtr.Zero, 0, dateInt, Cb);
								break;
							}
						}
					}
				}
				else
				{

				}
			}
			catch(Exception ex)
			{
				return;
			}
		}
	


		#region Common API Calls
		// Consts used
		public const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x100;
		public const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x2000;
		public const int FORMAT_MESSAGE_FROM_HMODULE = 0x800;
		public const int FORMAT_MESSAGE_FROM_STRING = 0x400;
		public const int FORMAT_MESSAGE_FROM_SYSTEM = 0x1000;
		public const int FORMAT_MESSAGE_IGNORE_INSERTS = 0x200;
		public const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 0xFF;

		public const int WM_TIMER = 0x113;

		[DllImport("user32")]
		private static extern int SetTimer(IntPtr hwnd, int nIDEvent, int uElapse, TimerProc CB);
		[DllImport("user32")]
		private static extern int KillTimer(IntPtr hwnd, int nIDEvent);
		[DllImport("kernel32")]
		private static extern void SetLastError(int dwErrCode);
		[DllImport("kernel32")]
		private static extern int GetLastError();
		[DllImport("kernel32")]
		private static extern int FormatMessage(int dwFlags, IntPtr lpSource, int dwMessageId, int dwLanguageId, System.Text.StringBuilder lpBuffer, int nSize, int Arguments);
		
		private static string GetAPIErrorMessageDescription(int ApiErrNumber ) 
		{
			System.Text.StringBuilder sError = new System.Text.StringBuilder(512); 
			int lErrorMessageLength;
            lErrorMessageLength = FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM, 
                FORMAT_MESSAGE_FROM_STRING, ApiErrNumber, 0, sError, sError.Capacity, 0);
			
			if(lErrorMessageLength > 0)
			{ 
				string strgError = sError.ToString();
				strgError=strgError.Substring(0,strgError.Length-2);
				return strgError+" ("+ApiErrNumber.ToString()+")";
			}
			return "none";

		}
		#endregion

		#region Callback Timers
		//Callback
		private delegate void TimerProc(IntPtr hWnd, uint nMsg, int nIDEvent, int dwTime);
		

		// Received Ticks by callback
		private void OnTickTimer(IntPtr hWnd, uint nMsg, int nIDEvent, int dwTime)
		{
			try
			{
				int rs = 0;
				dsMesazhe.Tables.Clear();
				this.dsMesazhe.ReadXml(Application.StartupPath + "\\MesazheAlarmi.xml");
				rs = KillTimer(IntPtr.Zero,this.ID_CB_Timer);
				string mesazh = dsMesazhe.Tables[0].Rows[0][1].ToString();
				//Application.EnableVisualStyles();
				System.Windows.Forms.MessageBox.Show(this, mesazh , "Mesazh Alarmi", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				this.dsMesazhe.Tables[0].Rows.Remove(dsMesazhe.Tables[0].Rows[0]);
				this.dsMesazhe.AcceptChanges();
				dsMesazhe.WriteXml(Application.StartupPath + "\\MesazheAlarmi.xml", XmlWriteMode.WriteSchema);
				this.Cnt_CB_Timer+=1;
				this.StartTimer1();
			}
			catch
			{
			}
		}

		#endregion
		
		/// <summary>
		/// Ben konvertimin e nje stringu te formatit 'dd/MM/yyyy HH:mm' ne dateTime.
		/// Nese stringu nuk eshte i sakte atehere kthen vleren diten e sotme
		/// </summary>
		/// <param name="dateString"></param>
		/// <returns></returns>
		private DateTime ConvertToDateTime(string dateString)
		{
			try
			{
				int day = Convert.ToInt32(dateString.Substring(0, 2));
				int month = Convert.ToInt32(dateString.Substring(3, 2));
				int year = Convert.ToInt32(dateString.Substring(6, 4));
				int hour = Convert.ToInt32(dateString.Substring(11, 2));
				int minutes = Convert.ToInt32(dateString.Substring(14, 2));
				DateTime dt = new DateTime(year, month, day, hour, minutes, 0);
				return dt;
			}
			catch
			{
				return DateTime.Now;
			}
		}
		#endregion

		#region Backup and Restore Database Utilities
		private void mKrijoBackup_Click(object sender, System.EventArgs e)
		{
			BackUpDatabase();
		}

		private void BackUpDatabase()
		{
			DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Backup database", "Jeni te sigurte qe doni " +
				"ti beni backup bazes se te dhenave?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result != DialogResult.Yes)
				return;
			try
			{
				if (!Directory.Exists(@"C:\HoteleBackup"))
					Directory.CreateDirectory(@"C:\HoteleBackup");
				DateTime dt = DateTime.Now;
				string name = "Hotel" + dt.ToString("dd-MM-yyyy-HH-mm");
				System.Data.SqlClient.SqlConnection conn = new SqlConnection();
				conn.ConnectionString = "workstation id=(LOCAL);packet size=4096;user id=sa;data source=\"(LOCAL)\\HM\";persist s" +
					"ecurity info=True;initial catalog=Hotele;password=vision";
				System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
				conn.Open();
				cmd.CommandText = @"BACKUP DATABASE Hotele TO DISK = 'C:\HoteleBackup\" + name + "' WITH FORMAT";
				cmd.Connection = conn;
				cmd.ExecuteNonQuery();
				conn.Close();
				System.Windows.Forms.MessageBox.Show("Baza e te dhenave u ruajt me sukses","Ruajtja e bazes",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Ruajtja e bazes", "Baza e te dhenave nuk u ruajt!" + 
					Environment.NewLine + "Nje gabim ndodhi gjate ruajtjes se bazes se te dhenave",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
 
		}

		private void mKarikoBackup_Click(object sender, System.EventArgs e)
		{
			RestoreDataBase();
		}

		private void RestoreDataBase()
		{
			DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Kariko backup", "Kujdes! Ky veprim mund te coje " +
				"ne humbjen e te dhenave.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			if (result != DialogResult.OK)
				return;
			try
			{
				if (!Directory.Exists(@"C:\HoteleBackup"))
				{
					System.Windows.Forms.MessageBox.Show("Baza e te dhenave nuk u karikua!" + 
						Environment.NewLine + "Direktoria HoteleBackup nuk ekziston!", "Karikimi i bazes", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				HotelManagment.Forms.RestoreDataBase.RestoreLoad();
			}
			catch(Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Baza e te dhenave nuk u karikua!" + 
					Environment.NewLine + "Nje gabim ndodhi gjate karikimit se bazes se te dhenave",
					"Karikimi i bazes", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		#endregion


	}
}
