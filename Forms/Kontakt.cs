using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Text;
using VisionInfoSolutionLibrary.smtp;
using System.IO;

namespace HotelManagment.Forms
{
	#region StampActions
	public enum StampActions
	{
		EditedBy = 1,
		DateTime = 2,
		Custom = 4
	}
	#endregion

	/// <summary>
	/// RichTextBox qe permban dhe toolbar
	/// </summary>
	public class Kontakt : VisionInfoSolutionLibrary.Form
	{
		#region Private Declarations
		private System.Windows.Forms.ToolBar tb1;
		private System.Windows.Forms.ToolBarButton tbbBold;
		private System.Windows.Forms.ToolBarButton tbbItalic;
		private System.Windows.Forms.ToolBarButton tbbUnderline;
		private System.Windows.Forms.ToolBarButton tbbCenter;
		private System.Windows.Forms.ToolBarButton tbbRight;
		private System.Windows.Forms.ToolBarButton tbbStrikeout;
		private System.Windows.Forms.ToolBarButton tbbColor;
		private System.Windows.Forms.ContextMenu cmColors;
		private System.Windows.Forms.MenuItem miBlack;
		private System.Windows.Forms.MenuItem miBlue;
		private System.Windows.Forms.MenuItem miRed;
		private System.Windows.Forms.MenuItem miGreen;
		private System.Windows.Forms.ToolBarButton tbbStamp;
		private System.Windows.Forms.ToolBarButton tbbOpen;
		private System.Windows.Forms.ToolBarButton tbbUndo;
		private System.Windows.Forms.ToolBarButton tbbRedo;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		private System.Windows.Forms.ToolBarButton tbbSeparator4;
		private System.Windows.Forms.ToolBarButton tbbSeparator1;
		private System.Windows.Forms.ToolBarButton tbbLeft;
		private System.Windows.Forms.OpenFileDialog ofd1;
		private System.Windows.Forms.SaveFileDialog sfd1;
		private System.Windows.Forms.ContextMenu cmFonts;
		private System.Windows.Forms.MenuItem miArial;
		private System.Windows.Forms.MenuItem miGaramond;
		private System.Windows.Forms.MenuItem miTahoma;
		private System.Windows.Forms.MenuItem miTimesNewRoman;
		private System.Windows.Forms.MenuItem miVerdana;
		private System.Windows.Forms.ToolBarButton tbbFont;
		private System.Windows.Forms.ToolBarButton tbbFontSize;
		private System.Windows.Forms.ToolBarButton tbbSeparator5;
		private System.Windows.Forms.MenuItem miCourierNew;
		private System.Windows.Forms.MenuItem miMicrosoftSansSerif;
		private System.Windows.Forms.ContextMenu cmFontSizes;
		private System.Windows.Forms.MenuItem mi8;
		private System.Windows.Forms.MenuItem mi9;
		private System.Windows.Forms.MenuItem mi10;
		private System.Windows.Forms.MenuItem mi11;
		private System.Windows.Forms.MenuItem mi12;
		private System.Windows.Forms.MenuItem mi14;
		private System.Windows.Forms.MenuItem mi16;
		private System.Windows.Forms.MenuItem mi18;
		private System.Windows.Forms.MenuItem mi20;
		private System.Windows.Forms.MenuItem mi22;
		private System.Windows.Forms.MenuItem mi24;
		private System.Windows.Forms.MenuItem mi26;
		private System.Windows.Forms.MenuItem mi28;
		private System.Windows.Forms.MenuItem mi36;
		private System.Windows.Forms.MenuItem mi48;
		private System.Windows.Forms.MenuItem mi72;
		private System.Windows.Forms.ToolBarButton tbbSave;
		private VisionInfoSolution.OfficeMenus officeMenus1;
		public VisionInfoSolutionLibrary.TextBox txtMarresi;
		public VisionInfoSolutionLibrary.TextBox txtDerguesi;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Label lblMarresi;
		public VisionInfoSolutionLibrary.TextBox txtSubjekti;
		private VisionInfoSolutionLibrary.Label lblSubjekti;
		private VisionInfoSolutionLibrary.Label lblAtachment;
		private System.Windows.Forms.ImageList imgList2;
		private System.Windows.Forms.ImageList imgList1;
		private VisionInfoSolutionLibrary.Button btnAtachment;
		private VisionInfoSolutionLibrary.Button btnSend;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.OpenFileDialog ofd2;
		public VisionInfoSolutionLibrary.RichTextBox rtbKontakt;
		private System.ComponentModel.IContainer components;
		private VisionInfoSolutionLibrary.TextBox txtPassword;
		private Janus.Windows.UI.StatusBar.UIStatusBar statusBar;
		private VisionInfoSolutionLibrary.Label lblHost;
		private VisionInfoSolutionLibrary.ListBox lbAttachment;
		private VisionInfoSolutionLibrary.TextBox txtHost;
		private VisionInfoSolutionLibrary.ContextMenu contextMenu2;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem mKopjo2;
		private System.Windows.Forms.MenuItem mPrej2;
		private System.Windows.Forms.MenuItem mNgjit2;
		private System.Windows.Forms.MenuItem mFshi2;
		private System.Windows.Forms.MenuItem mPerzgjidh2;
		private System.Windows.Forms.ImageList imageList2;
		private VisionInfoSolutionLibrary.ToolBarKontakt toolBarKontakt1;
		/// <summary>
		/// Path-i ku ndodhet attachment-i qe zgjedh perdoruesi
		/// </summary>
		private object attachLocation;
		#endregion

		#region Constructors & Destructors
		public Kontakt()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			//Update the graphics on the toolbar
			UpdateToolbar();
			JoinToolBars();
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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Kontakt));
			Janus.Windows.UI.StatusBar.UIStatusBarPanel uiStatusBarPanel1 = new Janus.Windows.UI.StatusBar.UIStatusBarPanel();
			this.tb1 = new System.Windows.Forms.ToolBar();
			this.tbbSave = new System.Windows.Forms.ToolBarButton();
			this.tbbOpen = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
			this.tbbFont = new System.Windows.Forms.ToolBarButton();
			this.cmFonts = new System.Windows.Forms.ContextMenu();
			this.miArial = new System.Windows.Forms.MenuItem();
			this.miCourierNew = new System.Windows.Forms.MenuItem();
			this.miGaramond = new System.Windows.Forms.MenuItem();
			this.miMicrosoftSansSerif = new System.Windows.Forms.MenuItem();
			this.miTahoma = new System.Windows.Forms.MenuItem();
			this.miTimesNewRoman = new System.Windows.Forms.MenuItem();
			this.miVerdana = new System.Windows.Forms.MenuItem();
			this.tbbFontSize = new System.Windows.Forms.ToolBarButton();
			this.cmFontSizes = new System.Windows.Forms.ContextMenu();
			this.mi8 = new System.Windows.Forms.MenuItem();
			this.mi9 = new System.Windows.Forms.MenuItem();
			this.mi10 = new System.Windows.Forms.MenuItem();
			this.mi11 = new System.Windows.Forms.MenuItem();
			this.mi12 = new System.Windows.Forms.MenuItem();
			this.mi14 = new System.Windows.Forms.MenuItem();
			this.mi16 = new System.Windows.Forms.MenuItem();
			this.mi18 = new System.Windows.Forms.MenuItem();
			this.mi20 = new System.Windows.Forms.MenuItem();
			this.mi22 = new System.Windows.Forms.MenuItem();
			this.mi24 = new System.Windows.Forms.MenuItem();
			this.mi26 = new System.Windows.Forms.MenuItem();
			this.mi28 = new System.Windows.Forms.MenuItem();
			this.mi36 = new System.Windows.Forms.MenuItem();
			this.mi48 = new System.Windows.Forms.MenuItem();
			this.mi72 = new System.Windows.Forms.MenuItem();
			this.tbbSeparator5 = new System.Windows.Forms.ToolBarButton();
			this.tbbBold = new System.Windows.Forms.ToolBarButton();
			this.tbbItalic = new System.Windows.Forms.ToolBarButton();
			this.tbbUnderline = new System.Windows.Forms.ToolBarButton();
			this.tbbStrikeout = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator1 = new System.Windows.Forms.ToolBarButton();
			this.tbbLeft = new System.Windows.Forms.ToolBarButton();
			this.tbbCenter = new System.Windows.Forms.ToolBarButton();
			this.tbbRight = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbUndo = new System.Windows.Forms.ToolBarButton();
			this.tbbRedo = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator4 = new System.Windows.Forms.ToolBarButton();
			this.tbbStamp = new System.Windows.Forms.ToolBarButton();
			this.tbbColor = new System.Windows.Forms.ToolBarButton();
			this.cmColors = new System.Windows.Forms.ContextMenu();
			this.miBlack = new System.Windows.Forms.MenuItem();
			this.miBlue = new System.Windows.Forms.MenuItem();
			this.miRed = new System.Windows.Forms.MenuItem();
			this.miGreen = new System.Windows.Forms.MenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.imgList1 = new System.Windows.Forms.ImageList(this.components);
			this.rtbKontakt = new VisionInfoSolutionLibrary.RichTextBox(this.components);
			this.contextMenu2 = new VisionInfoSolutionLibrary.ContextMenu();
			this.mKopjo2 = new System.Windows.Forms.MenuItem();
			this.mPrej2 = new System.Windows.Forms.MenuItem();
			this.mNgjit2 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.mFshi2 = new System.Windows.Forms.MenuItem();
			this.mPerzgjidh2 = new System.Windows.Forms.MenuItem();
			this.ofd1 = new System.Windows.Forms.OpenFileDialog();
			this.sfd1 = new System.Windows.Forms.SaveFileDialog();
			this.officeMenus1 = new VisionInfoSolution.OfficeMenus(this.components);
			this.imgList2 = new System.Windows.Forms.ImageList(this.components);
			this.txtMarresi = new VisionInfoSolutionLibrary.TextBox();
			this.txtDerguesi = new VisionInfoSolutionLibrary.TextBox();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.lblMarresi = new VisionInfoSolutionLibrary.Label();
			this.txtSubjekti = new VisionInfoSolutionLibrary.TextBox();
			this.lblSubjekti = new VisionInfoSolutionLibrary.Label();
			this.lblAtachment = new VisionInfoSolutionLibrary.Label();
			this.btnAtachment = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnSend = new VisionInfoSolutionLibrary.Button(this.components);
			this.ofd2 = new System.Windows.Forms.OpenFileDialog();
			this.txtPassword = new VisionInfoSolutionLibrary.TextBox();
			this.statusBar = new Janus.Windows.UI.StatusBar.UIStatusBar();
			this.lblHost = new VisionInfoSolutionLibrary.Label();
			this.lbAttachment = new VisionInfoSolutionLibrary.ListBox();
			this.txtHost = new VisionInfoSolutionLibrary.TextBox();
			this.toolBarKontakt1 = new VisionInfoSolutionLibrary.ToolBarKontakt();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(788, 24);
			// 
			// tb1
			// 
			this.tb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tb1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.tb1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																				   this.tbbSave,
																				   this.tbbOpen,
																				   this.tbbSeparator3,
																				   this.tbbFont,
																				   this.tbbFontSize,
																				   this.tbbSeparator5,
																				   this.tbbBold,
																				   this.tbbItalic,
																				   this.tbbUnderline,
																				   this.tbbStrikeout,
																				   this.tbbSeparator1,
																				   this.tbbLeft,
																				   this.tbbCenter,
																				   this.tbbRight,
																				   this.tbbSeparator2,
																				   this.tbbUndo,
																				   this.tbbRedo,
																				   this.tbbSeparator4,
																				   this.tbbStamp,
																				   this.tbbColor});
			this.tb1.ButtonSize = new System.Drawing.Size(16, 16);
			this.tb1.Dock = System.Windows.Forms.DockStyle.None;
			this.tb1.DropDownArrows = true;
			this.tb1.ImageList = this.imageList1;
			this.tb1.Location = new System.Drawing.Point(4, 24);
			this.tb1.Name = "tb1";
			this.tb1.ShowToolTips = true;
			this.tb1.Size = new System.Drawing.Size(792, 28);
			this.tb1.TabIndex = 0;
			this.tb1.Wrappable = false;
			this.tb1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tb1_ButtonClick);
			// 
			// tbbSave
			// 
			this.tbbSave.ImageIndex = 11;
			this.tbbSave.ToolTipText = "Ruaj";
			// 
			// tbbOpen
			// 
			this.tbbOpen.ImageIndex = 10;
			this.tbbOpen.ToolTipText = "Hap";
			// 
			// tbbSeparator3
			// 
			this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbFont
			// 
			this.tbbFont.DropDownMenu = this.cmFonts;
			this.tbbFont.ImageIndex = 14;
			this.tbbFont.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.tbbFont.ToolTipText = "Shkrimi";
			// 
			// cmFonts
			// 
			this.cmFonts.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.miArial,
																					this.miCourierNew,
																					this.miGaramond,
																					this.miMicrosoftSansSerif,
																					this.miTahoma,
																					this.miTimesNewRoman,
																					this.miVerdana});
			// 
			// miArial
			// 
			this.miArial.Index = 0;
			this.miArial.Text = "Arial";
			this.miArial.Click += new System.EventHandler(this.Font_Click);
			// 
			// miCourierNew
			// 
			this.miCourierNew.Index = 1;
			this.miCourierNew.Text = "Courier New";
			this.miCourierNew.Click += new System.EventHandler(this.Font_Click);
			// 
			// miGaramond
			// 
			this.miGaramond.Index = 2;
			this.miGaramond.Text = "Garamond";
			this.miGaramond.Click += new System.EventHandler(this.Font_Click);
			// 
			// miMicrosoftSansSerif
			// 
			this.miMicrosoftSansSerif.Index = 3;
			this.miMicrosoftSansSerif.Text = "Microsoft Sans Serif";
			this.miMicrosoftSansSerif.Click += new System.EventHandler(this.Font_Click);
			// 
			// miTahoma
			// 
			this.miTahoma.Index = 4;
			this.miTahoma.Text = "Tahoma";
			this.miTahoma.Click += new System.EventHandler(this.Font_Click);
			// 
			// miTimesNewRoman
			// 
			this.miTimesNewRoman.Index = 5;
			this.miTimesNewRoman.Text = "Times New Roman";
			this.miTimesNewRoman.Click += new System.EventHandler(this.Font_Click);
			// 
			// miVerdana
			// 
			this.miVerdana.Index = 6;
			this.miVerdana.Text = "Verdana";
			this.miVerdana.Click += new System.EventHandler(this.Font_Click);
			// 
			// tbbFontSize
			// 
			this.tbbFontSize.DropDownMenu = this.cmFontSizes;
			this.tbbFontSize.ImageIndex = 15;
			this.tbbFontSize.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.tbbFontSize.ToolTipText = "Madhesia e shkrimit";
			// 
			// cmFontSizes
			// 
			this.cmFontSizes.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.mi8,
																						this.mi9,
																						this.mi10,
																						this.mi11,
																						this.mi12,
																						this.mi14,
																						this.mi16,
																						this.mi18,
																						this.mi20,
																						this.mi22,
																						this.mi24,
																						this.mi26,
																						this.mi28,
																						this.mi36,
																						this.mi48,
																						this.mi72});
			// 
			// mi8
			// 
			this.mi8.Index = 0;
			this.mi8.Text = "8";
			this.mi8.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi9
			// 
			this.mi9.Index = 1;
			this.mi9.Text = "9";
			this.mi9.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi10
			// 
			this.mi10.Index = 2;
			this.mi10.Text = "10";
			this.mi10.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi11
			// 
			this.mi11.Index = 3;
			this.mi11.Text = "11";
			this.mi11.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi12
			// 
			this.mi12.Index = 4;
			this.mi12.Text = "12";
			this.mi12.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi14
			// 
			this.mi14.Index = 5;
			this.mi14.Text = "14";
			this.mi14.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi16
			// 
			this.mi16.Index = 6;
			this.mi16.Text = "16";
			this.mi16.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi18
			// 
			this.mi18.Index = 7;
			this.mi18.Text = "18";
			this.mi18.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi20
			// 
			this.mi20.Index = 8;
			this.mi20.Text = "20";
			this.mi20.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi22
			// 
			this.mi22.Index = 9;
			this.mi22.Text = "22";
			this.mi22.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi24
			// 
			this.mi24.Index = 10;
			this.mi24.Text = "24";
			this.mi24.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi26
			// 
			this.mi26.Index = 11;
			this.mi26.Text = "26";
			this.mi26.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi28
			// 
			this.mi28.Index = 12;
			this.mi28.Text = "28";
			this.mi28.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi36
			// 
			this.mi36.Index = 13;
			this.mi36.Text = "36";
			this.mi36.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi48
			// 
			this.mi48.Index = 14;
			this.mi48.Text = "48";
			this.mi48.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// mi72
			// 
			this.mi72.Index = 15;
			this.mi72.Text = "72";
			this.mi72.Click += new System.EventHandler(this.FontSize_Click);
			// 
			// tbbSeparator5
			// 
			this.tbbSeparator5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbBold
			// 
			this.tbbBold.ImageIndex = 0;
			this.tbbBold.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.tbbBold.ToolTipText = "I theksuar";
			// 
			// tbbItalic
			// 
			this.tbbItalic.ImageIndex = 1;
			this.tbbItalic.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.tbbItalic.ToolTipText = "Korsiv";
			// 
			// tbbUnderline
			// 
			this.tbbUnderline.ImageIndex = 2;
			this.tbbUnderline.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.tbbUnderline.ToolTipText = "I nenvizuar";
			// 
			// tbbStrikeout
			// 
			this.tbbStrikeout.ImageIndex = 3;
			this.tbbStrikeout.ToolTipText = "Me vize ne mes";
			// 
			// tbbSeparator1
			// 
			this.tbbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbLeft
			// 
			this.tbbLeft.ImageIndex = 4;
			this.tbbLeft.ToolTipText = "Majtas";
			// 
			// tbbCenter
			// 
			this.tbbCenter.ImageIndex = 5;
			this.tbbCenter.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.tbbCenter.ToolTipText = "Qender";
			// 
			// tbbRight
			// 
			this.tbbRight.ImageIndex = 6;
			this.tbbRight.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.tbbRight.ToolTipText = "Djathtas";
			// 
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbUndo
			// 
			this.tbbUndo.ImageIndex = 12;
			this.tbbUndo.ToolTipText = "Zhbej";
			// 
			// tbbRedo
			// 
			this.tbbRedo.ImageIndex = 13;
			this.tbbRedo.ToolTipText = "Ribej";
			// 
			// tbbSeparator4
			// 
			this.tbbSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbStamp
			// 
			this.tbbStamp.ImageIndex = 8;
			this.tbbStamp.ToolTipText = "Edit Stamp";
			// 
			// tbbColor
			// 
			this.tbbColor.DropDownMenu = this.cmColors;
			this.tbbColor.ImageIndex = 7;
			this.tbbColor.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.tbbColor.ToolTipText = "Ngjyra";
			// 
			// cmColors
			// 
			this.cmColors.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.miBlack,
																					 this.miBlue,
																					 this.miRed,
																					 this.miGreen});
			// 
			// miBlack
			// 
			this.miBlack.Index = 0;
			this.miBlack.Text = "E zeze";
			this.miBlack.Click += new System.EventHandler(this.Color_Click);
			// 
			// miBlue
			// 
			this.miBlue.Index = 1;
			this.miBlue.Text = "Blu";
			this.miBlue.Click += new System.EventHandler(this.Color_Click);
			// 
			// miRed
			// 
			this.miRed.Index = 2;
			this.miRed.Text = "E kuqe";
			this.miRed.Click += new System.EventHandler(this.Color_Click);
			// 
			// miGreen
			// 
			this.miGreen.Index = 3;
			this.miGreen.Text = "E gjelber";
			this.miGreen.Click += new System.EventHandler(this.Color_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageList2
			// 
			this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imgList1
			// 
			this.imgList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imgList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imgList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList1.ImageStream")));
			this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// rtbKontakt
			// 
			this.rtbKontakt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbKontakt.ContextMenu = this.contextMenu2;
			this.rtbKontakt.Location = new System.Drawing.Point(16, 208);
			this.rtbKontakt.Name = "rtbKontakt";
			this.rtbKontakt.Size = new System.Drawing.Size(772, 247);
			this.rtbKontakt.TabIndex = 7;
			this.rtbKontakt.Text = "";
			this.toolTips.SetToolTip(this.rtbKontakt, "Teksti i email-it");
			// 
			// contextMenu2
			// 
			this.contextMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.mKopjo2,
																						 this.mPrej2,
																						 this.mNgjit2,
																						 this.menuItem4,
																						 this.mFshi2,
																						 this.mPerzgjidh2});
			this.contextMenu2.Popup += new System.EventHandler(this.contextMenu2_Popup);
			// 
			// mKopjo2
			// 
			this.mKopjo2.Index = 0;
			this.mKopjo2.Text = "Kopjo";
			this.mKopjo2.Click += new System.EventHandler(this.mKopjo2_Click);
			// 
			// mPrej2
			// 
			this.mPrej2.Index = 1;
			this.mPrej2.Text = "Prej";
			this.mPrej2.Click += new System.EventHandler(this.mPrej2_Click);
			// 
			// mNgjit2
			// 
			this.mNgjit2.Index = 2;
			this.mNgjit2.Text = "Ngjit";
			this.mNgjit2.Click += new System.EventHandler(this.mNgjit2_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.Text = "-";
			// 
			// mFshi2
			// 
			this.mFshi2.Index = 4;
			this.mFshi2.Text = "Fshi";
			this.mFshi2.Click += new System.EventHandler(this.mFshi2_Click);
			// 
			// mPerzgjidh2
			// 
			this.mPerzgjidh2.Index = 5;
			this.mPerzgjidh2.Text = "Perzgjidh te gjithen";
			this.mPerzgjidh2.Click += new System.EventHandler(this.mPerzgjidh2_Click);
			// 
			// ofd1
			// 
			this.ofd1.DefaultExt = "txt";
			this.ofd1.Filter = "Skedar rich text|*.rtf|Skedar tekst|*.txt|Dokument Word|*.doc";
			this.ofd1.Title = "Open File";
			// 
			// sfd1
			// 
			this.sfd1.DefaultExt = "rtf";
			this.sfd1.Filter = "Skedar rich text|*.rtf|Skedar tekst|*.txt|Dokument Word|*.doc";
			this.sfd1.Title = "Ruaj si ...";
			// 
			// officeMenus1
			// 
			this.officeMenus1.ImageList = null;
			// 
			// imgList2
			// 
			this.imgList2.ImageSize = new System.Drawing.Size(16, 16);
			this.imgList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList2.ImageStream")));
			this.imgList2.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// txtMarresi
			// 
			this.txtMarresi.AutoSize = false;
			this.txtMarresi.DefaultErrorMessage = "";
			this.txtMarresi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMarresi.FixedLength = false;
			this.txtMarresi.IsValid = true;
			this.txtMarresi.Location = new System.Drawing.Point(144, 56);
			this.txtMarresi.Name = "txtMarresi";
			this.txtMarresi.Required = false;
			this.txtMarresi.RequiredControlColor = System.Drawing.Color.White;
			this.txtMarresi.Size = new System.Drawing.Size(276, 20);
			this.txtMarresi.TabIndex = 1;
			this.txtMarresi.Text = "info@infovisionsolution.com";
			this.toolTips.SetToolTip(this.txtMarresi, "Adresa e marresit");
			// 
			// txtDerguesi
			// 
			this.txtDerguesi.AutoSize = false;
			this.txtDerguesi.DefaultErrorMessage = "";
			this.txtDerguesi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtDerguesi.FixedLength = false;
			this.txtDerguesi.IsValid = true;
			this.txtDerguesi.Location = new System.Drawing.Point(144, 80);
			this.txtDerguesi.Name = "txtDerguesi";
			this.txtDerguesi.Required = false;
			this.txtDerguesi.RequiredControlColor = System.Drawing.Color.White;
			this.txtDerguesi.Size = new System.Drawing.Size(136, 20);
			this.txtDerguesi.TabIndex = 2;
			this.txtDerguesi.Text = "";
			this.toolTips.SetToolTip(this.txtDerguesi, "Adresa e derguesit");
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(16, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Adresa e derguesit";
			// 
			// lblMarresi
			// 
			this.lblMarresi.BackColor = System.Drawing.Color.Transparent;
			this.lblMarresi.Location = new System.Drawing.Point(16, 56);
			this.lblMarresi.Name = "lblMarresi";
			this.lblMarresi.Size = new System.Drawing.Size(100, 20);
			this.lblMarresi.TabIndex = 5;
			this.lblMarresi.Text = "Adresa e marresit";
			// 
			// txtSubjekti
			// 
			this.txtSubjekti.AutoSize = false;
			this.txtSubjekti.DefaultErrorMessage = "";
			this.txtSubjekti.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtSubjekti.FixedLength = false;
			this.txtSubjekti.IsValid = true;
			this.txtSubjekti.Location = new System.Drawing.Point(144, 104);
			this.txtSubjekti.Name = "txtSubjekti";
			this.txtSubjekti.Required = false;
			this.txtSubjekti.RequiredControlColor = System.Drawing.Color.White;
			this.txtSubjekti.Size = new System.Drawing.Size(276, 20);
			this.txtSubjekti.TabIndex = 4;
			this.txtSubjekti.Text = "";
			// 
			// lblSubjekti
			// 
			this.lblSubjekti.BackColor = System.Drawing.Color.Transparent;
			this.lblSubjekti.Location = new System.Drawing.Point(16, 104);
			this.lblSubjekti.Name = "lblSubjekti";
			this.lblSubjekti.Size = new System.Drawing.Size(100, 20);
			this.lblSubjekti.TabIndex = 8;
			this.lblSubjekti.Text = "Subjekti";
			// 
			// lblAtachment
			// 
			this.lblAtachment.BackColor = System.Drawing.Color.Transparent;
			this.lblAtachment.Location = new System.Drawing.Point(16, 128);
			this.lblAtachment.Name = "lblAtachment";
			this.lblAtachment.Size = new System.Drawing.Size(100, 20);
			this.lblAtachment.TabIndex = 9;
			this.lblAtachment.Text = "Bashkangjit";
			// 
			// btnAtachment
			// 
			this.btnAtachment.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAtachment.DoValidation = true;
			this.btnAtachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAtachment.Location = new System.Drawing.Point(432, 128);
			this.btnAtachment.Name = "btnAtachment";
			this.btnAtachment.Size = new System.Drawing.Size(24, 21);
			this.btnAtachment.TabIndex = 6;
			this.btnAtachment.Text = "...";
			this.toolTips.SetToolTip(this.btnAtachment, "Bashkangjiti email-it nje skedar");
			this.btnAtachment.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnAtachment.Click += new System.EventHandler(this.btnAtachment_Click);
			// 
			// btnSend
			// 
			this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSend.DoValidation = true;
			this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSend.Location = new System.Drawing.Point(496, 88);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(90, 21);
			this.btnSend.TabIndex = 8;
			this.btnSend.Text = "Dergo";
			this.toolTips.SetToolTip(this.btnSend, "Dergoni emailin");
			this.btnSend.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// ofd2
			// 
			this.ofd2.DefaultExt = "txt";
			this.ofd2.Filter = "Te gjithe llojet e skedareve|*.*";
			this.ofd2.Title = "Open File";
			// 
			// txtPassword
			// 
			this.txtPassword.AutoSize = false;
			this.txtPassword.DefaultErrorMessage = "";
			this.txtPassword.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtPassword.FixedLength = false;
			this.txtPassword.IsValid = true;
			this.txtPassword.Location = new System.Drawing.Point(284, 80);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Required = false;
			this.txtPassword.RequiredControlColor = System.Drawing.Color.White;
			this.txtPassword.Size = new System.Drawing.Size(136, 20);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.Text = "";
			this.toolTips.SetToolTip(this.txtPassword, "Fjalekalimi i adreses se derguesit");
			// 
			// statusBar
			// 
			this.statusBar.Location = new System.Drawing.Point(0, 464);
			this.statusBar.Name = "statusBar";
			uiStatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			uiStatusBarPanel1.DrawBorder = false;
			uiStatusBarPanel1.Key = "";
			uiStatusBarPanel1.ProgressBarValue = 0;
			uiStatusBarPanel1.Width = 782;
			this.statusBar.Panels.AddRange(new Janus.Windows.UI.StatusBar.UIStatusBarPanel[] {
																								 uiStatusBarPanel1});
			this.statusBar.Size = new System.Drawing.Size(788, 23);
			this.statusBar.TabIndex = 11;
			// 
			// lblHost
			// 
			this.lblHost.BackColor = System.Drawing.Color.Transparent;
			this.lblHost.Location = new System.Drawing.Point(16, 176);
			this.lblHost.Name = "lblHost";
			this.lblHost.Size = new System.Drawing.Size(100, 20);
			this.lblHost.TabIndex = 12;
			this.lblHost.Text = "Host";
			this.lblHost.Visible = false;
			// 
			// lbAttachment
			// 
			this.lbAttachment.DefaultErrorMessage = "";
			this.lbAttachment.IsValid = true;
			this.lbAttachment.Location = new System.Drawing.Point(144, 128);
			this.lbAttachment.Name = "lbAttachment";
			this.lbAttachment.Size = new System.Drawing.Size(276, 43);
			this.lbAttachment.TabIndex = 5;
			this.toolTips.SetToolTip(this.lbAttachment, "Shtypni butonin \'Delete\' ne tastiere per te hequr bashkangjitjen e zgjedhur");
			this.lbAttachment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbAttachment_KeyPress);
			this.lbAttachment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbAttachment_KeyUp);
			// 
			// txtHost
			// 
			this.txtHost.AutoSize = false;
			this.txtHost.DefaultErrorMessage = "";
			this.txtHost.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtHost.FixedLength = false;
			this.txtHost.IsValid = true;
			this.txtHost.Location = new System.Drawing.Point(144, 176);
			this.txtHost.Name = "txtHost";
			this.txtHost.Required = false;
			this.txtHost.RequiredControlColor = System.Drawing.Color.White;
			this.txtHost.Size = new System.Drawing.Size(276, 20);
			this.txtHost.TabIndex = 13;
			this.txtHost.Text = "";
			this.txtHost.Visible = false;
			// 
			// toolBarKontakt1
			// 
			this.toolBarKontakt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.toolBarKontakt1.BackColor = System.Drawing.SystemColors.Control;
			this.toolBarKontakt1.Location = new System.Drawing.Point(0, 24);
			this.toolBarKontakt1.Name = "toolBarKontakt1";
			this.toolBarKontakt1.Size = new System.Drawing.Size(788, 28);
			this.toolBarKontakt1.TabIndex = 14;
			// 
			// Kontakt
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(788, 487);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.txtHost);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtSubjekti);
			this.Controls.Add(this.txtDerguesi);
			this.Controls.Add(this.txtMarresi);
			this.Controls.Add(this.lbAttachment);
			this.Controls.Add(this.lblHost);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.btnAtachment);
			this.Controls.Add(this.lblAtachment);
			this.Controls.Add(this.lblSubjekti);
			this.Controls.Add(this.lblMarresi);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rtbKontakt);
			this.Controls.Add(this.toolBarKontakt1);
			this.Controls.Add(this.tb1);
			this.HelpFile = "KONTAKT.htm";
			this.Name = "Kontakt";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kontakt";
			this.TitullGjeresi = 788;
			this.Load += new System.EventHandler(this.RichTextBoxExtended_Load);
			this.Controls.SetChildIndex(this.tb1, 0);
			this.Controls.SetChildIndex(this.toolBarKontakt1, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.rtbKontakt, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.lblMarresi, 0);
			this.Controls.SetChildIndex(this.lblSubjekti, 0);
			this.Controls.SetChildIndex(this.lblAtachment, 0);
			this.Controls.SetChildIndex(this.btnAtachment, 0);
			this.Controls.SetChildIndex(this.btnSend, 0);
			this.Controls.SetChildIndex(this.lblHost, 0);
			this.Controls.SetChildIndex(this.lbAttachment, 0);
			this.Controls.SetChildIndex(this.txtMarresi, 0);
			this.Controls.SetChildIndex(this.txtDerguesi, 0);
			this.Controls.SetChildIndex(this.txtSubjekti, 0);
			this.Controls.SetChildIndex(this.txtPassword, 0);
			this.Controls.SetChildIndex(this.txtHost, 0);
			this.Controls.SetChildIndex(this.statusBar, 0);
			this.ResumeLayout(false);

		}
		#endregion

		#region Stamp Event Stuff
		[Description("Occurs when the stamp button is clicked"), 
		Category("Behavior")]
		public event System.EventHandler Stamp;
        
		/// <summary>
		/// OnStamp event
		/// </summary>
		protected virtual void OnStamp(EventArgs e)
		{
			if(Stamp != null)
				Stamp(this, e);

			switch(StampAction)
			{
				case StampActions.EditedBy:
				{
					StringBuilder stamp = new StringBuilder(""); //holds our stamp text
					if(rtbKontakt.Text.Length > 0) stamp.Append("\r\n\r\n"); //add two lines for space
					stamp.Append("Edited by "); 
					//use the CurrentPrincipal name if one exsist else use windows logon username
					if(Thread.CurrentPrincipal == null || Thread.CurrentPrincipal.Identity == null || Thread.CurrentPrincipal.Identity.Name.Length <= 0)
						stamp.Append(Environment.UserName);
					else
						stamp.Append(Thread.CurrentPrincipal.Identity.Name);
					stamp.Append(" on " + DateTime.Now.ToLongDateString() + "\r\n");
			
					rtbKontakt.SelectionLength = 0; //unselect everything basicly
					rtbKontakt.SelectionStart = rtbKontakt.Text.Length; //start new selection at the end of the text
					rtbKontakt.SelectionColor = this.StampColor; //make the selection blue
					rtbKontakt.SelectionFont = new Font(rtbKontakt.SelectionFont, FontStyle.Bold); //set the selection font and style
					rtbKontakt.AppendText(stamp.ToString()); //add the stamp to the richtextbox
					rtbKontakt.Focus(); //set focus back on the richtextbox
				} break; //end edited by stamp
				case StampActions.DateTime:
				{
					StringBuilder stamp = new StringBuilder(""); //holds our stamp text
					if(rtbKontakt.Text.Length > 0) stamp.Append("\r\n\r\n"); //add two lines for space
					stamp.Append(DateTime.Now.ToLongDateString() + "\r\n");
					rtbKontakt.SelectionLength = 0; //unselect everything basicly
					rtbKontakt.SelectionStart = rtbKontakt.Text.Length; //start new selection at the end of the text
					rtbKontakt.SelectionColor = this.StampColor; //make the selection blue
					rtbKontakt.SelectionFont = new Font(rtbKontakt.SelectionFont, FontStyle.Bold); //set the selection font and style
					rtbKontakt.AppendText(stamp.ToString()); //add the stamp to the richtextbox
					rtbKontakt.Focus(); //set focus back on the richtextbox
				} break;
			} //end select
		}
		#endregion

		#region Toolbar button click
		/// <summary>
		///     Handler for the toolbar button click event
		/// </summary>
		private void tb1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			//Switch based on the tooltip of the button pressed
			//OR: This could be changed to switch on the actual button pressed (e.g. e.Button and the case would be tbbBold)
			switch(e.Button.ToolTipText.ToLower())
			{
				case "i theksuar": 
				{
					if(rtbKontakt.SelectionFont != null) 
					{
						//using bitwise Exclusive OR to flip-flop the value
						rtbKontakt.SelectionFont = new Font(rtbKontakt.SelectionFont, rtbKontakt.SelectionFont.Style ^ FontStyle.Bold);
					}
				} break;
				case "korsiv": 
				{
					if(rtbKontakt.SelectionFont != null) 
					{
						//using bitwise Exclusive OR to flip-flop the value
						rtbKontakt.SelectionFont = new Font(rtbKontakt.SelectionFont, rtbKontakt.SelectionFont.Style ^ FontStyle.Italic);
					}
				} break;
				case "i nenvizuar":
				{
					if(rtbKontakt.SelectionFont != null) 
					{
						//using bitwise Exclusive OR to flip-flop the value
						rtbKontakt.SelectionFont = new Font(rtbKontakt.SelectionFont, rtbKontakt.SelectionFont.Style ^ FontStyle.Underline);
					}
				} break;
				case "me vize ne mes":
				{
					if(rtbKontakt.SelectionFont != null) 
					{
						//using bitwise Exclusive OR to flip-flop the value
						rtbKontakt.SelectionFont = new Font(rtbKontakt.SelectionFont, rtbKontakt.SelectionFont.Style ^ FontStyle.Strikeout);
					}
				} break;
				case "majtas":
				{
					//change horizontal alignment to left
					rtbKontakt.SelectionAlignment = HorizontalAlignment.Left; 
				} break;
				case "qender":
				{
					//change horizontal alignment to center
					rtbKontakt.SelectionAlignment = HorizontalAlignment.Center;
				} break;
				case "djathtas":
				{
					//change horizontal alignment to right
					rtbKontakt.SelectionAlignment = HorizontalAlignment.Right;
				} break;
				case "edit stamp":
				{
					OnStamp(new EventArgs()); //send stamp event
				} break;
				case "ngjyra":
				{
					rtbKontakt.SelectionColor = Color.Black;
				} break;
				case "zhbej":
				{
					rtbKontakt.Undo();
				} break;
				case "ribej":
				{
					rtbKontakt.Redo();
				} break;
				case "hap":
				{
					try
					{
						if (ofd1.ShowDialog() == DialogResult.OK && ofd1.FileName.Length > 0)
							if(System.IO.Path.GetExtension(ofd1.FileName).ToLower().Equals(".rtf")) 
								rtbKontakt.LoadFile(ofd1.FileName, RichTextBoxStreamType.RichText);
							else if (System.IO.Path.GetExtension(ofd1.FileName).ToLower().Equals(".doc"))
								rtbKontakt.LoadFile(ofd1.FileName, RichTextBoxStreamType.RichText);
							else
								rtbKontakt.LoadFile(ofd1.FileName, RichTextBoxStreamType.PlainText);
					}
					catch (ArgumentException ae)
					{
						if(ae.Message == "Invalid file format.")
							MessageBox.Show(this.Parent, "Nje gabim ndodhi gjate ngarkimit te skedarit: " + ofd1.FileName,
							"Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);				
					}
				} break;
				case "ruaj":
				{
					if(sfd1.ShowDialog() == DialogResult.OK && sfd1.FileName.Length > 0)
						if(System.IO.Path.GetExtension(sfd1.FileName).ToLower().Equals(".rtf"))
							rtbKontakt.SaveFile(sfd1.FileName);
						else if (System.IO.Path.GetExtension(sfd1.FileName).ToLower().Equals(".doc"))
							rtbKontakt.SaveFile(sfd1.FileName); 
						else
							rtbKontakt.SaveFile(sfd1.FileName, RichTextBoxStreamType.PlainText);
				}
					break;
			} //end select
			UpdateToolbar(); //Update the toolbar buttons
		}
		#endregion

		#region Update Toolbar
		/// <summary>
		///     Update the toolbar button statuses
		/// </summary>
		public void UpdateToolbar()
		{
			//This is done incase 2 different fonts are selected at the same time
			//If that is the case there is no selection font so I use the default
			//font instead.
			Font fnt;
			if(rtbKontakt.SelectionFont != null)
				fnt = rtbKontakt.SelectionFont;
			else
				fnt = rtbKontakt.Font;

			//Do all the toolbar button checks
			tbbBold.Pushed		= fnt.Bold; //bold button
			tbbItalic.Pushed	= fnt.Italic; //italic button
			tbbUnderline.Pushed	= fnt.Underline; //underline button
			tbbStrikeout.Pushed	= fnt.Strikeout; //strikeout button
			tbbLeft.Pushed		= (rtbKontakt.SelectionAlignment == HorizontalAlignment.Left); //justify left
			tbbCenter.Pushed	= (rtbKontakt.SelectionAlignment == HorizontalAlignment.Center); //justify center
			tbbRight.Pushed		= (rtbKontakt.SelectionAlignment == HorizontalAlignment.Right);//justify right
			
			// Do all the toolbar button checks for the second toolbar
			toolBarKontakt1.tbbBold.Pushed		= fnt.Bold; //bold button
			toolBarKontakt1.tbbItalic.Pushed	= fnt.Italic; //italic button
			toolBarKontakt1.tbbUnderline.Pushed	= fnt.Underline; //underline button
			toolBarKontakt1.tbbStrikeout.Pushed	= fnt.Strikeout; //strikeout button
			toolBarKontakt1.tbbLeft.Pushed		= (rtbKontakt.SelectionAlignment == HorizontalAlignment.Left); //justify left
			toolBarKontakt1.tbbCenter.Pushed	= (rtbKontakt.SelectionAlignment == HorizontalAlignment.Center); //justify center
			toolBarKontakt1.tbbRight.Pushed		= (rtbKontakt.SelectionAlignment == HorizontalAlignment.Right);//justify right

			//Check the correct color
			foreach(MenuItem mi in cmColors.MenuItems)
			{
				mi.Checked = (rtbKontakt.SelectionColor == Color.FromName(mi.Text));
			}

			//Check the correct font
			foreach(MenuItem mi in cmFonts.MenuItems)
			{
				mi.Checked = (fnt.FontFamily.Name == mi.Text);
			}

			//Check the correct font size
			foreach(MenuItem mi in cmFontSizes.MenuItems)
			{
				mi.Checked = ((int)fnt.SizeInPoints == float.Parse(mi.Text));
			}
		}
		#endregion

		#region Update Toolbar Seperators
		private void UpdateToolbarSeperators()
		{
			//Save & Open
			if(!tbbSave.Visible && !tbbOpen.Visible) 
				tbbSeparator3.Visible = false;
			else
				tbbSeparator3.Visible = true;

			//Font & Font Size
			if(!tbbFont.Visible && !tbbFontSize.Visible) 
				tbbSeparator5.Visible = false;
			else
				tbbSeparator5.Visible = true;

			//Bold, Italic, Underline, & Strikeout
			if(!tbbBold.Visible && !tbbItalic.Visible && !tbbUnderline.Visible && !tbbStrikeout.Visible)
				tbbSeparator1.Visible = false;
			else
				tbbSeparator1.Visible = true;

			//Left, Center, & Right
			if(!tbbLeft.Visible && !tbbCenter.Visible && !tbbRight.Visible)
				tbbSeparator2.Visible = false;
			else
				tbbSeparator2.Visible = true;

			//Undo & Redo
			if(!tbbUndo.Visible && !tbbRedo.Visible) 
				tbbSeparator4.Visible = false;
			else
				tbbSeparator4.Visible = true;
		}
		#endregion

		#region RichTextBox Selection Change
		/// <summary>
		///	Ndrysho butonat e toolbarit kur nje tekst i ri zgjidhet
		/// </summary>
		private void rtbKontakt_SelectionChanged(object sender, System.EventArgs e)
		{
			UpdateToolbar(); //Update butonat e toolbar-it
		}
		#endregion

		#region Color Click
		/// <summary>
		/// Ndryshon ngjyren e tekstit te richTextBox
		/// </summary>
		private void Color_Click(object sender, System.EventArgs e)
		{
			if(rtbKontakt.SelectionFont != null) 
			{
				if (((MenuItem)sender).Text == "E zeze")
					rtbKontakt.SelectionColor = Color.Black;
				else if (((MenuItem)sender).Text == "E kuqe")
					rtbKontakt.SelectionColor = Color.Red;
				else if (((MenuItem)sender).Text == "E gjelber")
					rtbKontakt.SelectionColor = Color.Green;
				else if (((MenuItem)sender).Text == "Blu")
					rtbKontakt.SelectionColor = Color.Blue;
			}
		}
		#endregion

		#region Font Click
		/// <summary>
		///     Change the richtextbox font
		/// </summary>
		private void Font_Click(object sender, System.EventArgs e)
		{
			if(rtbKontakt.SelectionFont != null) 
			{
				//set the richtextbox font family based on the name of the menu item
				rtbKontakt.SelectionFont = new Font(((MenuItem)sender).Text, rtbKontakt.SelectionFont.SizeInPoints);
			}
		}
		#endregion

		#region Font Size Click
		/// <summary>
		///     Change the richtextbox font size
		/// </summary>
		private void FontSize_Click(object sender, System.EventArgs e)
		{
			//set the richtextbox font size based on the name of the menu item
			rtbKontakt.SelectionFont = new Font(rtbKontakt.SelectionFont.FontFamily.Name, float.Parse(((MenuItem)sender).Text));
		}
		#endregion

		#region Klikimi i Linkut
		/// <summary>
		/// Starto browser-in default nese klikohet nje link
		/// </summary>
		private void rtbKontakt_LinkClicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}
		#endregion

		#region Public Properties
		/// <summary>
		/// ToolBari-i qe ndodhet brenda richtextBox-it
		/// </summary>
//		[Description("The internal toolbar control"),
//		Category("Internal Controls")]
//		public System.Windows.Forms.ToolBar Toolbar
//		{
//			get { return tb1; }
//		}
//
//		/// <summary>
//		///     The RichTextBox that is contained with-in the RichTextBoxExtened control
//		/// </summary>
//		[Description("The internal richtextbox control"),
//		Category("Internal Controls")]
//		public VisionInfoSolutionLibrary.RichTextBox RichTextBox
//		{
//			get	{ return rtbKontakt; }
//		}
//
//		/// <summary>
//		///     Show the save button or not
//		/// </summary>
//		[Description("Percakton nese do te shfaqet butoni i ruajtjes se tekstit"),
//		Category("Appearance")]
//		public Boolean ShowSave
//		{
//			get { return tbbSave.Visible; }
//			set { tbbSave.Visible = value; UpdateToolbarSeperators(); }
//		}

		/// <summary>
		///    Show the open button or not 
		/// </summary>
		[Description("Percakton nese do te shfaqet butoni i Hapjes se tekstit"),
		Category("Appearance")]
		public Boolean ShowOpen
		{
			get { return tbbOpen.Visible; }
			set	{ tbbOpen.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		/// Show the stamp button or not
		/// </summary>
		[Description("Show the stamp button or not"),
		Category("Appearance")]
		public Boolean ShowStamp
		{
			get { return tbbStamp.Visible; }
			set { tbbStamp.Visible = value; }
		}
		
		/// <summary>
		///     Show the color button or not
		/// </summary>
		[Description("Percakton nese do te shfaqet butoni i ngjyrave te tekstit"),
		Category("Appearance")]
		public Boolean ShowColors
		{
			get { return tbbColor.Visible; }
			set { tbbColor.Visible = value; }
		}

		/// <summary>
		///     Show the undo button or not
		/// </summary>
		[Description("Percakton nese do te shfaqet butoni i zhberjes te tekstit"),
		Category("Appearance")]
		public Boolean ShowUndo
		{
			get { return tbbUndo.Visible; }
			set { tbbUndo.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the redo button or not
		/// </summary>
		[Description("Percakton nese do te shfaqet butoni i riberjes te tekstit"),
		Category("Appearance")]
		public Boolean ShowRedo
		{
			get { return tbbRedo.Visible; }
			set { tbbRedo.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the bold button or not
		/// </summary>
		[Description("Show the bold button or not"),
		Category("Appearance")]
		public Boolean ShowBold
		{
			get { return tbbBold.Visible; }
			set { tbbBold.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Percakton nese do te shfaqet butoni korsiv apo jo
		/// </summary>
		[Description("Show the italic button or not"),
		Category("Appearance")]
		public Boolean ShowItalic
		{
			get { return tbbItalic.Visible; }
			set { tbbItalic.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the underline button or not
		/// </summary>
		[Description("Percakton nese do te shfaqet butoni i nenvizimit te tekstit"),
		Category("Appearance")]
		public Boolean ShowUnderline
		{
			get { return tbbUnderline.Visible; }
			set { tbbUnderline.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the strikeout button or not
		/// </summary>
		[Description("Percakton nese do te shfaqet butoni i StrikeOut"),
		Category("Appearance")]
		public Boolean ShowStrikeout
		{
			get { return tbbStrikeout.Visible; }
			set { tbbStrikeout.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the left justify button or not
		/// </summary>
		[Description("Percakton nese do te shfaqet butoni i Majtezimit te tekstit"),
		Category("Appearance")]
		public Boolean ShowLeftJustify
		{
			get { return tbbLeft.Visible; }
			set { tbbLeft.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the right justify button or not
		/// </summary>
		[Description("Percakton nese do te shfaqet butoni i Djathtezimit te tekstit"),
		Category("Appearance")]
		public Boolean ShowRightJustify
		{
			get { return tbbRight.Visible; }
			set { tbbRight.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the center justify button or not
		/// </summary>
		[Description("Percakton nese do te shfaqet butoni i Qenderzimit te tekstit"),
		Category("Appearance")]
		public Boolean ShowCenterJustify
		{
			get { return tbbCenter.Visible; }
			set { tbbCenter.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Determines how the stamp button will respond
		/// </summary>
		StampActions m_StampAction = StampActions.EditedBy;
		[Description("Determines how the stamp button will respond"),
		Category("Behavior")]
		public StampActions StampAction
		{
			get { return m_StampAction; }
			set { m_StampAction = value; }
		}
		
		/// <summary>
		///     Color of the stamp text
		/// </summary>
		Color m_StampColor = Color.Blue;

		[Description("Color of the stamp text"),
		Category("Appearance")]
		public Color StampColor
		{
			get { return m_StampColor; }
			set { m_StampColor = value; }
		}
			
		/// <summary>
		///     Show the font button or not
		/// </summary>
		[Description("Show the font button or not"),
		Category("Appearance")]
		public Boolean ShowFont
		{
			get { return tbbFont.Visible; }
			set { tbbFont.Visible = value; }
		}

		/// <summary>
		///     Show the font size button or not
		/// </summary>
		[Description("Percakton nese do te shfaqet butoni i madhesise se shkrimit"),
		Category("Appearance")]
		public Boolean ShowFontSize
		{
			get { return tbbFontSize.Visible; }
			set { tbbFontSize.Visible = value; }
		}

		/// <summary>
		/// Gjej URL-te brenda richtextbox-it
		/// </summary>
		[Description("Gjej URL-te brenda richtextbox"),
		Category("Behavior")]
		public Boolean DetectURLs
		{
			get { return rtbKontakt.DetectUrls; }
			set { rtbKontakt.DetectUrls = value; }
		}
		#endregion

		#region Load RichTextBoxExtended
		/// <summary>
		/// Ne kete event inicializohet officeMenu, ne menyre qe te paraqiten menute ne stil office 2003
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RichTextBoxExtended_Load(object sender, System.EventArgs e)
		{
			if (this.btnSend.VisualStyle == Janus.Windows.UI.VisualStyle.Office2003)
			{
				// Kontrollojme nese stili i zgjedhur nga perdoruesi eshte ai i Office2003
				this.officeMenus1.Start(this);
				this.officeMenus1.AddPicture(this.mKopjo2, 0);
				this.officeMenus1.AddPicture(this.mPrej2, 1);
				this.officeMenus1.AddPicture(this.mNgjit2, 2);
				this.toolBarKontakt1.office2003 = true;
				this.toolBarKontakt1.BackColor = Color.FromKnownColor(KnownColor.InactiveCaptionText);
			}
			else
				this.toolBarKontakt1.office2003 = false;
			try
			{
				if (File.Exists(Application.StartupPath + "\\Informacione.xml"))
				{
					DataSet ds = new DataSet();
					ds.ReadXml(Application.StartupPath + "\\Informacione.xml");
					this.txtDerguesi.Text = ds.Tables[0].Rows[0]["SetEmail"].ToString();
					this.txtPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString();
					this.txtHost.Text = ds.Tables[0].Rows[0]["Host"].ToString();
					// Per arsye performance heqim ds-ne nga memoria
					ds.Dispose();
				}
			}
			catch
			{
				// Empty catch
			}
		}
		#endregion

		private void btnAtachment_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (ofd2.ShowDialog() == DialogResult.OK && ofd2.FileName.Length > 0)
				{
					this.attachLocation = ofd2.FileName;
					SmtpAttachment a = new SmtpAttachment();
					a.FileName = ofd2.FileName;
					a.ContentType = "application/octet-stream";
					a.Location = AttachmentLocation.Attachment;
					this.lbAttachment.Items.Add(a);
				}
			}
			catch (ArgumentException ae)
			{
				if(ae.Message == "Format jo i vlefshem i skedarit.")
					MessageBox.Show(this.Parent, "Gabim",
						"Nje gabim ndodhi gjate ngarkimit te skedarit: " + ofd2.FileName,
						MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
		}

		private void btnSend_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				SmtpEmailer emailer = new SmtpEmailer();
				emailer.From = this.txtDerguesi.Text;
				if (emailer.From == "")
					return;
				emailer.Body = this.rtbKontakt.Text;
				emailer.Subject = this.txtSubjekti.Text;
				emailer.To.Add(this.txtMarresi.Text);
				emailer.Port = 25;
				emailer.Host = this.txtHost.Text;
				for (int i = 0; i < this.lbAttachment.Items.Count; ++i)
				{
					emailer.Attachments.Add((SmtpAttachment) lbAttachment.Items[i]);
				}
				emailer.User = this.txtDerguesi.Text;
				emailer.Password = this.txtPassword.Text;
				emailer.AuthenticationMode = AuthenticationType.Base64;
				emailer.OnMailSent +=new VisionInfoSolutionLibrary.smtp.SmtpEmailer.MailSentDelegate(emailer_OnMailSent);
				emailer.SendMessageAsync();
				statusBar.Panels[0].Text = "Duke derguar emailin...";
			}
			catch
			{
				System.Windows.Forms.MessageBox.Show("E-maili nuk arriti te dergohej", "Dergimi i E-mailit",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				statusBar.Panels[0].Text = "";
			}
		}

		private void emailer_OnMailSent()
		{
			MessageBox.Show("E-maili u dergua me sukses", "Kontakt", MessageBoxButtons.OK, MessageBoxIcon.Information);
			statusBar.Panels[0].Text = "";
		}

		private void contextMenu2_Popup(object sender, System.EventArgs e)
		{
			this.mKopjo2.Enabled = this.rtbKontakt.CanCopy;
			this.mPrej2.Enabled = this.rtbKontakt.CanCut;
			this.mNgjit2.Enabled = this.rtbKontakt.CanPaste;
			this.mPerzgjidh2.Enabled = this.rtbKontakt.CanSelect;
			this.mFshi2.Enabled = this.rtbKontakt.CanDelete;
		}

		private void mKopjo2_Click(object sender, System.EventArgs e)
		{
			this.rtbKontakt.Copy();
		}

		private void mPrej2_Click(object sender, System.EventArgs e)
		{
			this.rtbKontakt.Cut();
		}

		private void mNgjit2_Click(object sender, System.EventArgs e)
		{
			this.rtbKontakt.Paste();
		}

		private void mFshi2_Click(object sender, System.EventArgs e)
		{
			this.rtbKontakt.Delete();
		}

		private void mPerzgjidh2_Click(object sender, System.EventArgs e)
		{
			this.rtbKontakt.SelectAll();
		}


		protected override void SetToolTips()
		{
			
			base.SetToolTips ();
		}

		private void lbAttachment_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			return;
		}

		private void lbAttachment_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Delete)
			{
				for (int i = 0; i < this.lbAttachment.SelectedItems.Count; i++)
				{
					this.lbAttachment.Items.Remove(this.lbAttachment.SelectedItems[i]);
				}
			}
		}


		private void JoinToolBars()
		{
			this.toolBarKontakt1.tbbBold.Click += new EventHandler(tbbBold_Click);
			this.toolBarKontakt1.tbbCenter.Click += new EventHandler(tbbCenter_Click);
			this.toolBarKontakt1.tbbColor.Click += new EventHandler(tbbColor_Click);
			this.toolBarKontakt1.tbbFont.Click += new EventHandler(tbbFont_Click);
			this.toolBarKontakt1.tbbFontSize.Click += new EventHandler(tbbFontSize_Click);
			this.toolBarKontakt1.tbbItalic.Click += new EventHandler(tbbItalic_Click);
			this.toolBarKontakt1.tbbLeft.Click += new EventHandler(tbbLeft_Click);
			this.toolBarKontakt1.tbbOpen.Click += new EventHandler(tbbOpen_Click);
			this.toolBarKontakt1.tbbRedo.Click += new EventHandler(tbbRedo_Click);
			this.toolBarKontakt1.tbbRight.Click += new EventHandler(tbbRight_Click);
			this.toolBarKontakt1.tbbSave.Click += new EventHandler(tbbSave_Click);
			this.toolBarKontakt1.tbbStrikeout.Click += new EventHandler(tbbStrikeout_Click);
			this.toolBarKontakt1.tbbUnderline.Click += new EventHandler(tbbUnderline_Click);
			this.toolBarKontakt1.tbbUndo.Click += new EventHandler(tbbUndo_Click);
		}

		private void tbbBold_Click(object sender, EventArgs e)
		{
			ToolBarButtonClickEventArgs e1 = new ToolBarButtonClickEventArgs(this.tbbBold);
			this.tb1_ButtonClick(tb1, e1);
		}

		private void tbbCenter_Click(object sender, EventArgs e)
		{
			ToolBarButtonClickEventArgs e1 = new ToolBarButtonClickEventArgs(this.tbbCenter);
			this.tb1_ButtonClick(tb1, e1);
		}

		private void tbbColor_Click(object sender, EventArgs e)
		{
			this.cmColors.Show(this.toolBarKontakt1.tbbColor, new Point(0, this.toolBarKontakt1.tbbColor.Height));
			ToolBarButtonClickEventArgs e1 = new ToolBarButtonClickEventArgs(this.tbbColor);
			this.tb1_ButtonClick(tb1, e1);
		}

		private void tbbFont_Click(object sender, EventArgs e)
		{
			this.cmFonts.Show(this.toolBarKontakt1.tbbFont, new Point(0, this.toolBarKontakt1.tbbFont.Height));
			ToolBarButtonClickEventArgs e1 = new ToolBarButtonClickEventArgs(this.tbbFont);
			this.tb1_ButtonClick(tb1, e1);
		}

		private void tbbFontSize_Click(object sender, EventArgs e)
		{
			this.cmFontSizes.Show(this.toolBarKontakt1.tbbFontSize, new Point(0, this.toolBarKontakt1.tbbFontSize.Height));
			ToolBarButtonClickEventArgs e1 = new ToolBarButtonClickEventArgs(this.tbbFontSize);
			this.tb1_ButtonClick(tb1, e1);
		}

		private void tbbItalic_Click(object sender, EventArgs e)
		{
			ToolBarButtonClickEventArgs e1 = new ToolBarButtonClickEventArgs(this.tbbItalic);
			this.tb1_ButtonClick(tb1, e1);
		}

		private void tbbLeft_Click(object sender, EventArgs e)
		{
			ToolBarButtonClickEventArgs e1 = new ToolBarButtonClickEventArgs(this.tbbLeft);
			this.tb1_ButtonClick(tb1, e1);
		}

		private void tbbOpen_Click(object sender, EventArgs e)
		{
			ToolBarButtonClickEventArgs e1 = new ToolBarButtonClickEventArgs(this.tbbOpen);
			this.tb1_ButtonClick(tb1, e1);
		}

		private void tbbRedo_Click(object sender, EventArgs e)
		{
			ToolBarButtonClickEventArgs e1 = new ToolBarButtonClickEventArgs(this.tbbRedo);
			this.tb1_ButtonClick(tb1, e1);
		}

		private void tbbRight_Click(object sender, EventArgs e)
		{
			ToolBarButtonClickEventArgs e1 = new ToolBarButtonClickEventArgs(this.tbbRight);
			this.tb1_ButtonClick(tb1, e1);
		}

		private void tbbSave_Click(object sender, EventArgs e)
		{
			ToolBarButtonClickEventArgs e1 = new ToolBarButtonClickEventArgs(this.tbbSave);
			this.tb1_ButtonClick(tb1, e1);
		}

		private void tbbStrikeout_Click(object sender, EventArgs e)
		{
			ToolBarButtonClickEventArgs e1 = new ToolBarButtonClickEventArgs(this.tbbStrikeout);
			this.tb1_ButtonClick(tb1, e1);
		}

		private void tbbUnderline_Click(object sender, EventArgs e)
		{
			ToolBarButtonClickEventArgs e1 = new ToolBarButtonClickEventArgs(this.tbbUnderline);
			this.tb1_ButtonClick(tb1, e1);
		}

		private void tbbUndo_Click(object sender, EventArgs e)
		{
			ToolBarButtonClickEventArgs e1 = new ToolBarButtonClickEventArgs(this.tbbUndo);
			this.tb1_ButtonClick(tb1, e1);
		}
	} //end class
} //end namespace
