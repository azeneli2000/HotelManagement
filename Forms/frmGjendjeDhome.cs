using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using VisionInfoSolutionLibrary;
using System.Globalization;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using ZedGraph;

namespace HotelManagment.BusDatService
{
	/// <summary>
	/// Summary description for GjendjeDhome.
	/// </summary>
	public class GjendjeDhome : VisionInfoSolutionLibrary.PrintForm
	{
		#region Private Fields
		private VisionInfoSolutionLibrary.GroupBox gbGjendja;
		private VisionInfoSolutionLibrary.Button btnShfaq;
		private VisionInfoSolutionLibrary.Label label4;
		private System.Windows.Forms.Panel panel4;
		private VisionInfoSolutionLibrary.Label label3;
		private System.Windows.Forms.Panel panel3;
		private VisionInfoSolutionLibrary.Label label2;
		private System.Windows.Forms.Panel panel2;
		private VisionInfoSolutionLibrary.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelDhomat;
		private ZedGraph.ZedGraphControl ZedDhomat;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.Label label6;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.RadioButton rbDhomat;
		private VisionInfoSolutionLibrary.RadioButton rbGrafik;
		public DateTime dtKerkimi;
		private System.Data.DataSet ds;
		private VisionInfoSolutionLibrary.MonthCal.MonthCalendar monthCalendarAlb1;
		private VisionInfoSolutionLibrary.DateTimePicker dateTimePicker1;
		private int numer_rreshtash;
		#endregion

		#region Constructors & Destructors
		public GjendjeDhome()
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
			this.gbGjendja = new VisionInfoSolutionLibrary.GroupBox();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelDhomat = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.ZedDhomat = new ZedGraph.ZedGraphControl();
			this.btnShfaq = new VisionInfoSolutionLibrary.Button(this.components);
			this.ds = new System.Data.DataSet();
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.monthCalendarAlb1 = new VisionInfoSolutionLibrary.MonthCal.MonthCalendar();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.rbGrafik = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbDhomat = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.dateTimePicker1 = new VisionInfoSolutionLibrary.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.gbGjendja)).BeginInit();
			this.gbGjendja.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1028, 24);
			// 
			// gbGjendja
			// 
			this.gbGjendja.BackColor = System.Drawing.Color.Transparent;
			this.gbGjendja.Controls.Add(this.label4);
			this.gbGjendja.Controls.Add(this.panel4);
			this.gbGjendja.Controls.Add(this.label3);
			this.gbGjendja.Controls.Add(this.label2);
			this.gbGjendja.Controls.Add(this.panel2);
			this.gbGjendja.Controls.Add(this.label1);
			this.gbGjendja.Controls.Add(this.panel1);
			this.gbGjendja.Controls.Add(this.panelDhomat);
			this.gbGjendja.Controls.Add(this.panel3);
			this.gbGjendja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbGjendja.Location = new System.Drawing.Point(260, 40);
			this.gbGjendja.Name = "gbGjendja";
			this.gbGjendja.Size = new System.Drawing.Size(756, 572);
			this.gbGjendja.TabIndex = 2;
			this.gbGjendja.Text = "Gjendja e dhomave per ne daten e zgjedhur";
			this.gbGjendja.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Location = new System.Drawing.Point(440, 544);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 20);
			this.label4.TabIndex = 28;
			this.label4.Text = "E rezervuar";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.NavajoWhite;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Location = new System.Drawing.Point(392, 544);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(40, 20);
			this.panel4.TabIndex = 27;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(440, 520);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 26;
			this.label3.Text = "E zene";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(284, 544);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 24;
			this.label2.Text = "Pjeserisht e lire";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Location = new System.Drawing.Point(236, 544);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(40, 20);
			this.panel2.TabIndex = 23;
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(284, 520);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 22;
			this.label1.Text = "Plotesisht e lire";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(236, 516);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(40, 20);
			this.panel1.TabIndex = 21;
			// 
			// panelDhomat
			// 
			this.panelDhomat.BackColor = System.Drawing.Color.AliceBlue;
			this.panelDhomat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelDhomat.Location = new System.Drawing.Point(12, 16);
			this.panelDhomat.Name = "panelDhomat";
			this.panelDhomat.Size = new System.Drawing.Size(736, 492);
			this.panelDhomat.TabIndex = 13;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Salmon;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Location = new System.Drawing.Point(392, 516);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(40, 20);
			this.panel3.TabIndex = 25;
			// 
			// ZedDhomat
			// 
			this.ZedDhomat.IsEnableHPan = true;
			this.ZedDhomat.IsEnableVPan = true;
			this.ZedDhomat.IsEnableZoom = true;
			this.ZedDhomat.IsScrollY2 = false;
			this.ZedDhomat.IsShowContextMenu = true;
			this.ZedDhomat.IsShowHScrollBar = false;
			this.ZedDhomat.IsShowPointValues = false;
			this.ZedDhomat.IsShowVScrollBar = false;
			this.ZedDhomat.IsZoomOnMouseCenter = false;
			this.ZedDhomat.Location = new System.Drawing.Point(12, 12);
			this.ZedDhomat.Name = "ZedDhomat";
			this.ZedDhomat.PanButtons = System.Windows.Forms.MouseButtons.Left;
			this.ZedDhomat.PanButtons2 = System.Windows.Forms.MouseButtons.Middle;
			this.ZedDhomat.PanModifierKeys2 = System.Windows.Forms.Keys.None;
			this.ZedDhomat.PointDateFormat = "g";
			this.ZedDhomat.PointValueFormat = "G";
			this.ZedDhomat.ScrollMaxX = 0;
			this.ZedDhomat.ScrollMaxY = 0;
			this.ZedDhomat.ScrollMaxY2 = 0;
			this.ZedDhomat.ScrollMinX = 0;
			this.ZedDhomat.ScrollMinY = 0;
			this.ZedDhomat.ScrollMinY2 = 0;
			this.ZedDhomat.Size = new System.Drawing.Size(236, 212);
			this.ZedDhomat.TabIndex = 33;
			this.ZedDhomat.Visible = false;
			this.ZedDhomat.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
			this.ZedDhomat.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
			this.ZedDhomat.ZoomModifierKeys = System.Windows.Forms.Keys.None;
			this.ZedDhomat.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
			this.ZedDhomat.ZoomStepFraction = 0.1;
			// 
			// btnShfaq
			// 
			this.btnShfaq.BackColor = System.Drawing.Color.Blue;
			this.btnShfaq.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShfaq.DoValidation = true;
			this.btnShfaq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShfaq.Location = new System.Drawing.Point(84, 324);
			this.btnShfaq.Name = "btnShfaq";
			this.btnShfaq.Size = new System.Drawing.Size(90, 21);
			this.btnShfaq.TabIndex = 2;
			this.btnShfaq.Text = "Shfaq";
			this.toolTips.SetToolTip(this.btnShfaq, "Shfaq gjendjen e dhomave per daten dhe oren e zgjedhur!");
			this.btnShfaq.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShfaq.Click += new System.EventHandler(this.btnShfaq_Click);
			// 
			// ds
			// 
			this.ds.DataSetName = "NewDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.monthCalendarAlb1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(10, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(240, 268);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// monthCalendarAlb1
			// 
			this.monthCalendarAlb1.ActiveMonth.Month = 3;
			this.monthCalendarAlb1.ActiveMonth.Year = 2006;
			this.monthCalendarAlb1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.monthCalendarAlb1.Culture = new System.Globalization.CultureInfo("en-US");
			this.monthCalendarAlb1.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.monthCalendarAlb1.Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.monthCalendarAlb1.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.monthCalendarAlb1.Header.TextColor = System.Drawing.Color.White;
			this.monthCalendarAlb1.ImageList = null;
			this.monthCalendarAlb1.Location = new System.Drawing.Point(8, 28);
			this.monthCalendarAlb1.MaxDate = new System.DateTime(3398, 5, 12, 0, 0, 0, 0);
			this.monthCalendarAlb1.MinDate = new System.DateTime(1753, 3, 13, 0, 0, 0, 0);
			this.monthCalendarAlb1.Month.BackgroundImage = null;
			this.monthCalendarAlb1.Month.Colors.FocusBackground = System.Drawing.Color.FromArgb(((System.Byte)(43)), ((System.Byte)(122)), ((System.Byte)(255)));
			this.monthCalendarAlb1.Month.Colors.FocusBorder = System.Drawing.SystemColors.ActiveCaption;
			this.monthCalendarAlb1.Month.Colors.FocusDate = System.Drawing.Color.Black;
			this.monthCalendarAlb1.Month.Colors.FocusText = System.Drawing.Color.Black;
			this.monthCalendarAlb1.Month.Colors.SelectedBackground = System.Drawing.SystemColors.ActiveCaption;
			this.monthCalendarAlb1.Month.Colors.SelectedBorder = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(69)), ((System.Byte)(185)));
			this.monthCalendarAlb1.Month.Colors.SelectedDate = System.Drawing.Color.Black;
			this.monthCalendarAlb1.Month.Colors.SelectedText = System.Drawing.Color.Black;
			this.monthCalendarAlb1.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.monthCalendarAlb1.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.monthCalendarAlb1.Name = "monthCalendarAlb1";
			this.monthCalendarAlb1.SelectionMode = VisionInfoSolutionLibrary.MonthCal.mcSelectionMode.One;
			this.monthCalendarAlb1.Size = new System.Drawing.Size(212, 184);
			this.monthCalendarAlb1.TabIndex = 37;
			this.monthCalendarAlb1.Theme = true;
			this.monthCalendarAlb1.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.monthCalendarAlb1.Weekdays.TextColor = System.Drawing.SystemColors.ActiveCaption;
			this.monthCalendarAlb1.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.monthCalendarAlb1.Weeknumbers.TextColor = System.Drawing.SystemColors.ActiveCaption;
			this.monthCalendarAlb1.DaySelected += new VisionInfoSolutionLibrary.MonthCal.DaySelectedEventHandler(this.monthCalendarAlb1_DaySelected);
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(12, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 16);
			this.label5.TabIndex = 36;
			this.label5.Text = "Data";
			// 
			// label6
			// 
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Location = new System.Drawing.Point(12, 216);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 16);
			this.label6.TabIndex = 33;
			this.label6.Text = "Ora";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.rbGrafik);
			this.groupBox2.Controls.Add(this.rbDhomat);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Location = new System.Drawing.Point(10, 352);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(242, 84);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// rbGrafik
			// 
			this.rbGrafik.Location = new System.Drawing.Point(8, 48);
			this.rbGrafik.Name = "rbGrafik";
			this.rbGrafik.Size = new System.Drawing.Size(232, 24);
			this.rbGrafik.TabIndex = 1;
			this.rbGrafik.Text = "Paraqitja grafike e gjendjes se dhomave";
			// 
			// rbDhomat
			// 
			this.rbDhomat.Checked = true;
			this.rbDhomat.Location = new System.Drawing.Point(8, 16);
			this.rbDhomat.Name = "rbDhomat";
			this.rbDhomat.Size = new System.Drawing.Size(232, 24);
			this.rbDhomat.TabIndex = 0;
			this.rbDhomat.TabStop = true;
			this.rbDhomat.Text = "Paraqitja e detajuar e gjendjes se dhomave";
			this.rbDhomat.CheckedChanged += new System.EventHandler(this.rbDhomat_CheckedChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "HH:mm";
			this.dateTimePicker1.DefaultErrorMessage = "";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.IsValid = true;
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 240);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Required = false;
			this.dateTimePicker1.ShowCheckBox = true;
			this.dateTimePicker1.ShowUpDown = true;
			this.dateTimePicker1.Size = new System.Drawing.Size(116, 20);
			this.dateTimePicker1.TabIndex = 38;
			this.dateTimePicker1.Value = new System.DateTime(2006, 3, 16, 14, 25, 0, 0);
			// 
			// GjendjeDhome
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1028, 780);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbGjendja);
			this.Controls.Add(this.btnShfaq);
			this.HelpFile = "GJENDJA E DHOMAVE.htm";
			this.Name = "GjendjeDhome";
			this.Text = "GjendjeDhome";
			this.TitullGjeresi = 1028;
			this.Load += new System.EventHandler(this.GjendjeDhome_Load);
			this.Controls.SetChildIndex(this.btnShfaq, 0);
			this.Controls.SetChildIndex(this.gbGjendja, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			((System.ComponentModel.ISupportInitialize)(this.gbGjendja)).EndInit();
			this.gbGjendja.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void GjendjeDhome_Load(object sender, System.EventArgs e)
		{
			try
			{
				// pastrim variablash private
				this.dtKerkimi = DateTime.Now;
				this.ds.Tables.Clear();
				numer_rreshtash = 0;
				this.rbGrafik.Checked = false;
				this.rbDhomat.Checked = true;
				// pastrim variablash private
				Application.CurrentCulture = new System.Globalization.CultureInfo("sq-AL", true);
				// Vendosim gjuhen shqipe per kalendarin e formes
				CultureInfo al = new CultureInfo("sq-AL");
				this.monthCalendarAlb1.Culture = al;
				string str1 = Thread.CurrentThread.CurrentCulture.ToString();
				string str = al.Name;
				Thread.CurrentThread.CurrentUICulture.DateTimeFormat.DayNames.SetValue("Hene", 1);

				//this.monthCalendarAlb1.SelectionStart = System.DateTime.Today;
				this.monthCalendarAlb1.ActiveMonth.Month = DateTime.Now.Month;
				this.dateTimePicker1.Value  = System.DateTime.Now;
				//dtKerkimi =  this.monthCalendarAlb1.SelectionStart;
				string strdata = Convert.ToString(dtKerkimi.ToShortDateString());
				string strora = Convert.ToDateTime(this.dateTimePicker1.Value).ToShortTimeString().ToString();
				strdata = strdata + " " + strora;
				dtKerkimi =  Convert.ToDateTime(strdata);
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqGjendjenEdhomavePerDatenEdhene", dtKerkimi);
				int numer_dhomash = ds.Tables[0].Rows.Count;
				this.ZedDhomat.Parent = this.gbGjendja;
				this.ZedDhomat.Location = new Point(12, 16);
				this.ZedDhomat.Size = new Size(736, 492);
				if (numer_dhomash > 0)
				{
					this.PastroPanel();
					int[] v = this.MbushPanel();
					this.NdertoZedGrafik(v);
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, 
						"Ne hotel nuk eshte konfiguruar asnje dhome momentalisht."+  "\r\n" +
						"Ju lutem vazhdoni me konfigurimin e dhomave!","Gjendja e dhomave", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				// Vendos active month per kalendarin
				this.monthCalendarAlb1.ActiveMonth.Month = DateTime.Now.Month;
				this.monthCalendarAlb1.ActiveMonth.Year = DateTime.Now.Year;
				// Zgjidh diten e sotme
				this.monthCalendarAlb1.SelectDate(DateTime.Now);
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

		private int[] MbushPanel()
		{
			int[] v = new int[5];
			//v[0] numri i dhomave
			//v[1] dhomat plotesisht te lira
			//v[2] dhomat e zena
			//v[3] dhomat pjeserisht te lira
			//v[4] dhomat e rezervuara
			numer_rreshtash = ds.Tables[0].Rows.Count;
			v[0] = numer_rreshtash;
			int id_dhoma;
			string emer_dhoma;
			string gjendja;
			int i = 0;
			int lartesi = 0;
			int gjeresi = 0;
			int hapsire = 0;
			int p1 = 0;
			int p2 = 0;
			int h_nr = 0;
			//			int v_nr = 0;
			if (numer_rreshtash <= 100)
			{
				lartesi = 36;
				gjeresi = 60;
				hapsire = 12;
				h_nr = 10;
			}
			else if (numer_rreshtash <= 221)
			{
				lartesi = 20;
				gjeresi = 48;
				hapsire = 8;
				h_nr = 13;
			}
			else
			{
				//msgbox
			}
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				id_dhoma = Convert.ToInt32(dr[0]);
				emer_dhoma = Convert.ToString(dr[1]);
				gjendja = Convert.ToString(dr[6]);
				System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
				btn.Name = id_dhoma.ToString();
				btn.Text = emer_dhoma;
				btn.FlatStyle =  System.Windows.Forms.FlatStyle.Flat;
				btn.Width = gjeresi;
				btn.Height = lartesi;
				p1 = (i % h_nr + 1) * hapsire + (i % h_nr) * gjeresi;
				p2 = (i / h_nr + 1) * hapsire + (i / h_nr) * lartesi;
				btn.Location = new System.Drawing.Point(p1, p2);
				if (gjendja == "R")
				{
					btn.BackColor = System.Drawing.Color.NavajoWhite;
					v[4]++;
				}
				else if (gjendja == "L")
				{
					btn.BackColor = System.Drawing.Color.White;
					v[1]++;
				}
				else if (gjendja == "Z")
				{
					btn.BackColor = System.Drawing.Color.Salmon;
					v[2]++;
				}
				else if (gjendja == "JZ")
				{
					btn.BackColor = System.Drawing.Color.LightSteelBlue;
					v[3]++;
				}
				btn.Click += new System.EventHandler(this.btn_Click);
				this.panelDhomat.Controls.Add(btn);
				i = i + 1;
			}
			return v;
		}

		private void NdertoZedGrafik(int[] v)
		{
			this.ZedDhomat.Refresh();
			GraphPane myPane = new GraphPane();
			// Set the GraphPane title
			myPane.Title = "Paraqitja grafike e gjendjes se dhomave";
			myPane.FontSpec.IsItalic = false;
			myPane.FontSpec.Size = 10f;
			myPane.FontSpec.Family = "Microsoft Sans Serif";
			myPane.FontSpec.FontColor = Color.Chocolate;

			// Fill the pane background with a color gradient
			myPane.PaneFill = new Fill( Color.AliceBlue );
			// No fill for the axis background
			myPane.AxisFill.Type = FillType.None;

			// Set the legend to an arbitrary location
			myPane.Legend.IsVisible = false;
			
			// Add some pie slices
			double[] perqindje = new double[4];
			for (int i = 0; i < 4; i++)
			{
				double frac = Convert.ToDouble(v[i + 1])/Convert.ToDouble(v[0]);
				perqindje[i] = Math.Round((frac*100), 1);
			}
			PieItem segment1 = myPane.AddPieSlice( v[1], Color.White, Color.White, 45f, 0, "Te lira: " + perqindje[0] + "%" );
			if (v[1] == 0)
				segment1.LabelDetail.IsVisible = false;
			PieItem segment2 = myPane.AddPieSlice( v[2], Color.Salmon, Color.White, 70f, 0, "Te zena: " + perqindje[1] + "%");
			segment2.LabelDetail.FontSpec.FontColor = Color.Red;
			if (v[2] == 0)
				segment2.LabelDetail.IsVisible = false;
			PieItem segment3 = myPane.AddPieSlice( v[3], Color.LightSteelBlue, Color.White, 70f, 0.2, "Pjeserisht te zena: " + perqindje[2] + "%");
			segment3.LabelDetail.FontSpec.FontColor = Color.MidnightBlue;
			if (v[3] == 0)
				segment3.LabelDetail.IsVisible = false;
			PieItem segment4 = myPane.AddPieSlice( v[4], Color.NavajoWhite, Color.White, 70f, 0, "Te rezervuara: "+ perqindje[3] + "%" );
			segment4.LabelDetail.FontSpec.FontColor = Color.Chocolate;
			if (v[4] == 0)
				segment4.LabelDetail.IsVisible = false;
												
			// Sum up the pie values																					
			CurveList curves = myPane.CurveList ;

			// Make a text label to highlight the total value
			TextItem text = new TextItem( "Numri total i dhomave: " + v[0].ToString (),
				0.18F, 0.40F, CoordType.PaneFraction );
			text.Location.AlignH = AlignH.Center;
			text.Location.AlignV = AlignV.Bottom;
			text.FontSpec.Border.IsVisible = false ;
			text.FontSpec.Fill = new Fill( Color.White, Color.SandyBrown, 45F );
			text.FontSpec.FontColor = System.Drawing.SystemColors.Desktop;
			text.FontSpec.StringAlignment = StringAlignment.Center ;
			myPane.GraphItemList.Add( text );

			// Create a drop shadow for the total value text item
			TextItem text2 = new TextItem( text );
			text2.FontSpec.Fill = new Fill( Color.Black );
			text2.Location.X += 0.008f;
			text2.Location.Y += 0.01f;
			myPane.GraphItemList.Add( text2 );
			myPane.PaneRect = new RectangleF(0, 0, 736, 492);
			this.ZedDhomat.GraphPane = myPane;
			this.ZedDhomat.AxisChange();
			this.ZedDhomat.Size = new Size(736, 492);
			this.ZedDhomat.Refresh();
		}

		private void btnShfaq_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				DateTime a = dtKerkimi;
				string strdata = Convert.ToString(dtKerkimi.ToShortDateString());
				string strora = Convert.ToDateTime(this.dateTimePicker1.Value).ToShortTimeString().ToString();
				strdata = strdata + " " + strora;
				dtKerkimi =  Convert.ToDateTime(strdata);
				this.PastroPanel();
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqGjendjenEdhomavePerDatenEdhene", dtKerkimi);
				int[] v = this.MbushPanel();
				this.NdertoZedGrafik(v);
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

		private void btn_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Windows.Forms.Button b = (System.Windows.Forms.Button) sender;
				int id_dhoma = Convert.ToInt32(b.Name);
				string emer_dhoma = b.Text;
				HotelManagment.Forms.Dhoma2 frm = new HotelManagment.Forms.Dhoma2();
				frm.Name = Convert.ToString(id_dhoma);
				frm.Text = "Te dhena per dhomen " + emer_dhoma;
				frm.dateTimePicker1.Value = dtKerkimi;
				frm.Location = new System.Drawing.Point(350, 300);
				frm.StyleOffice2003 = this.StyleOffice2003;
				frm.ShowDialog();
				frm.ShowInTaskbar = false;
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
		private void rbDhomat_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				if (this.rbDhomat.Checked == true)
				{
					this.ZedDhomat.Visible = false;
					this.panelDhomat.Visible = true;
				}
				else
				{
					this.ZedDhomat.Visible = true;
					this.panelDhomat.Visible = false;
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

		private void PastroPanel()
		{
			try
			{
				panelDhomat.Controls.Clear();
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

		private void monthCalendarAlb1_DaySelected(object sender, VisionInfoSolutionLibrary.MonthCal.DaySelectedEventArgs e)
		{
			try
			{
				dtKerkimi = Convert.ToDateTime((e.Days).GetValue(0));
				string strdata = Convert.ToString(dtKerkimi.ToShortDateString());
				string strora = Convert.ToDateTime(this.dateTimePicker1.Value).ToShortTimeString().ToString();
				strdata = strdata + " " + strora;
				dtKerkimi =  Convert.ToDateTime(strdata);
				//dtKerkimi = Convert.ToDateTime((e.Days).GetValue(0));

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
	}
}
