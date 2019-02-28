using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using VisionInfoSolutionLibrary;
using HotelManagment.Forms;
using ZedGraph;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagment.Forms
{
	public class BilancMujor : VisionInfoSolutionLibrary.Form, IPrintable
	{
		#region Private Fields
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.Label label1;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.GroupBox groupBox3;
		private VisionInfoSolutionLibrary.RadioButton rbGrafik;
		private VisionInfoSolutionLibrary.RadioButton rbTabele;
		private ZedGraph.ZedGraphControl ZedBilanci;
		private VisionInfoSolutionLibrary.DateTimePicker dateTimePicker1;
		private VisionInfoSolutionLibrary.Button btnKerko;
		private VisionInfoSolutionLibrary.DataGrid grid;
		private System.Windows.Forms.LinkLabel linkShpenzime;
		private System.Windows.Forms.LinkLabel linkBilanci;
		private System.Windows.Forms.LinkLabel linkTeArdhura;
		private System.Windows.Forms.LinkLabel linkTeGjitha;
		private VisionInfoSolutionLibrary.Label lblKolonat;
		private VisionInfoSolutionLibrary.GroupBox gbKolonat;
		private System.Windows.Forms.LinkLabel linkKesh;
		/// <summary>
		/// variabel i cili mban vleren per propertine ReadyToPrint
		/// </summary>
		private bool readyToPrint = true;
		private System.Data.DataSet ds;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.CheckBox cbBarRes;
		private VisionInfoSolutionLibrary.CheckBox cbHoteli;
		private VisionInfoSolutionLibrary.CheckBox checkBox1;
		private System.Data.DataSet dsPagesa;

		#endregion

		#region Constructors & Destructors
		public BilancMujor()
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
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.lblKolonat = new VisionInfoSolutionLibrary.Label();
			this.linkBilanci = new System.Windows.Forms.LinkLabel();
			this.linkTeArdhura = new System.Windows.Forms.LinkLabel();
			this.linkShpenzime = new System.Windows.Forms.LinkLabel();
			this.linkTeGjitha = new System.Windows.Forms.LinkLabel();
			this.ZedBilanci = new ZedGraph.ZedGraphControl();
			this.dateTimePicker1 = new VisionInfoSolutionLibrary.DateTimePicker();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.grid = new VisionInfoSolutionLibrary.DataGrid();
			this.gbKolonat = new VisionInfoSolutionLibrary.GroupBox();
			this.linkKesh = new System.Windows.Forms.LinkLabel();
			this.btnKerko = new VisionInfoSolutionLibrary.Button(this.components);
			this.ds = new System.Data.DataSet();
			this.groupBox3 = new VisionInfoSolutionLibrary.GroupBox();
			this.rbGrafik = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbTabele = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.dsPagesa = new System.Data.DataSet();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.cbBarRes = new VisionInfoSolutionLibrary.CheckBox();
			this.cbHoteli = new VisionInfoSolutionLibrary.CheckBox();
			this.checkBox1 = new VisionInfoSolutionLibrary.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gbKolonat)).BeginInit();
			this.gbKolonat.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsPagesa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1036, 24);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.lblKolonat);
			this.groupBox1.Controls.Add(this.linkBilanci);
			this.groupBox1.Controls.Add(this.linkTeArdhura);
			this.groupBox1.Controls.Add(this.linkShpenzime);
			this.groupBox1.Controls.Add(this.linkTeGjitha);
			this.groupBox1.Controls.Add(this.ZedBilanci);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.grid);
			this.groupBox1.Controls.Add(this.gbKolonat);
			this.groupBox1.Controls.Add(this.btnKerko);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(10, 124);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(946, 312);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.Text = "Bilanci per vitin korrent";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// lblKolonat
			// 
			this.lblKolonat.Location = new System.Drawing.Point(12, 60);
			this.lblKolonat.Name = "lblKolonat";
			this.lblKolonat.Size = new System.Drawing.Size(44, 16);
			this.lblKolonat.TabIndex = 13;
			this.lblKolonat.Text = "Kolonat";
			this.lblKolonat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblKolonat.Visible = false;
			// 
			// linkBilanci
			// 
			this.linkBilanci.ActiveLinkColor = System.Drawing.Color.DarkRed;
			this.linkBilanci.DisabledLinkColor = System.Drawing.Color.Chocolate;
			this.linkBilanci.ForeColor = System.Drawing.SystemColors.Desktop;
			this.linkBilanci.LinkColor = System.Drawing.Color.Chocolate;
			this.linkBilanci.Location = new System.Drawing.Point(60, 132);
			this.linkBilanci.Name = "linkBilanci";
			this.linkBilanci.Size = new System.Drawing.Size(68, 20);
			this.linkBilanci.TabIndex = 8;
			this.linkBilanci.TabStop = true;
			this.linkBilanci.Text = "Bilanci";
			this.toolTips.SetToolTip(this.linkBilanci, "Shfaq grafikun per bilancin.");
			this.linkBilanci.Visible = false;
			this.linkBilanci.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBilanci_LinkClicked);
			// 
			// linkTeArdhura
			// 
			this.linkTeArdhura.ActiveLinkColor = System.Drawing.Color.DarkRed;
			this.linkTeArdhura.DisabledLinkColor = System.Drawing.Color.Chocolate;
			this.linkTeArdhura.ForeColor = System.Drawing.Color.Chocolate;
			this.linkTeArdhura.LinkColor = System.Drawing.Color.Chocolate;
			this.linkTeArdhura.Location = new System.Drawing.Point(60, 60);
			this.linkTeArdhura.Name = "linkTeArdhura";
			this.linkTeArdhura.Size = new System.Drawing.Size(68, 23);
			this.linkTeArdhura.TabIndex = 9;
			this.linkTeArdhura.TabStop = true;
			this.linkTeArdhura.Text = "Te ardhurat";
			this.toolTips.SetToolTip(this.linkTeArdhura, "Shfaq grafikun per te ardhurat e pergjithshme.");
			this.linkTeArdhura.Visible = false;
			this.linkTeArdhura.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTeArdhura_LinkClicked);
			// 
			// linkShpenzime
			// 
			this.linkShpenzime.ActiveLinkColor = System.Drawing.Color.DarkRed;
			this.linkShpenzime.DisabledLinkColor = System.Drawing.Color.Chocolate;
			this.linkShpenzime.ForeColor = System.Drawing.SystemColors.Desktop;
			this.linkShpenzime.LinkColor = System.Drawing.Color.Chocolate;
			this.linkShpenzime.Location = new System.Drawing.Point(60, 108);
			this.linkShpenzime.Name = "linkShpenzime";
			this.linkShpenzime.Size = new System.Drawing.Size(68, 20);
			this.linkShpenzime.TabIndex = 7;
			this.linkShpenzime.TabStop = true;
			this.linkShpenzime.Text = "Shpenzimet";
			this.toolTips.SetToolTip(this.linkShpenzime, "Shfaq grafikun per te shpenzimet.");
			this.linkShpenzime.Visible = false;
			this.linkShpenzime.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShpenzime_LinkClicked);
			// 
			// linkTeGjitha
			// 
			this.linkTeGjitha.ActiveLinkColor = System.Drawing.Color.DarkRed;
			this.linkTeGjitha.DisabledLinkColor = System.Drawing.Color.Chocolate;
			this.linkTeGjitha.ForeColor = System.Drawing.SystemColors.Desktop;
			this.linkTeGjitha.LinkColor = System.Drawing.Color.Chocolate;
			this.linkTeGjitha.Location = new System.Drawing.Point(60, 156);
			this.linkTeGjitha.Name = "linkTeGjitha";
			this.linkTeGjitha.Size = new System.Drawing.Size(68, 23);
			this.linkTeGjitha.TabIndex = 6;
			this.linkTeGjitha.TabStop = true;
			this.linkTeGjitha.Text = "Te tre";
			this.toolTips.SetToolTip(this.linkTeGjitha, "Shfaq ne te njejtin grafik te ardhurat e pergjithshme, shpenzimet dhe bilancin.");
			this.linkTeGjitha.Visible = false;
			this.linkTeGjitha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTeGjitha_LinkClicked);
			// 
			// ZedBilanci
			// 
			this.ZedBilanci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.ZedBilanci.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.ZedBilanci.ForeColor = System.Drawing.Color.SaddleBrown;
			this.ZedBilanci.IsEnableHPan = false;
			this.ZedBilanci.IsEnableVPan = false;
			this.ZedBilanci.IsEnableZoom = false;
			this.ZedBilanci.IsScrollY2 = false;
			this.ZedBilanci.IsShowContextMenu = true;
			this.ZedBilanci.IsShowHScrollBar = false;
			this.ZedBilanci.IsShowPointValues = false;
			this.ZedBilanci.IsShowVScrollBar = false;
			this.ZedBilanci.IsZoomOnMouseCenter = false;
			this.ZedBilanci.Location = new System.Drawing.Point(156, 48);
			this.ZedBilanci.Name = "ZedBilanci";
			this.ZedBilanci.PanButtons = System.Windows.Forms.MouseButtons.Left;
			this.ZedBilanci.PanButtons2 = System.Windows.Forms.MouseButtons.Middle;
			this.ZedBilanci.PanModifierKeys2 = System.Windows.Forms.Keys.None;
			this.ZedBilanci.PointDateFormat = "g";
			this.ZedBilanci.PointValueFormat = "G";
			this.ZedBilanci.ScrollMaxX = 0;
			this.ZedBilanci.ScrollMaxY = 0;
			this.ZedBilanci.ScrollMaxY2 = 0;
			this.ZedBilanci.ScrollMinX = 0;
			this.ZedBilanci.ScrollMinY = 0;
			this.ZedBilanci.ScrollMinY2 = 0;
			this.ZedBilanci.Size = new System.Drawing.Size(340, 232);
			this.ZedBilanci.TabIndex = 5;
			this.ZedBilanci.Visible = false;
			this.ZedBilanci.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
			this.ZedBilanci.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
			this.ZedBilanci.ZoomModifierKeys = System.Windows.Forms.Keys.None;
			this.ZedBilanci.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
			this.ZedBilanci.ZoomStepFraction = 0.1;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy";
			this.dateTimePicker1.DefaultErrorMessage = "";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.IsValid = true;
			this.dateTimePicker1.Location = new System.Drawing.Point(60, 20);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Required = false;
			this.dateTimePicker1.ShowUpDown = true;
			this.dateTimePicker1.Size = new System.Drawing.Size(72, 20);
			this.dateTimePicker1.TabIndex = 4;
			this.dateTimePicker1.Value = new System.DateTime(2005, 11, 7, 17, 10, 0, 0);
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(16, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Viti";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grid
			// 
			this.grid.AllowSorting = false;
			this.grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.grid.CanDelete = true;
			this.grid.CaptionVisible = false;
			this.grid.DataMember = "";
			this.grid.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.grid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grid.HideHorizontalScrollBar = false;
			this.grid.HideVerticalScrollBar = false;
			this.grid.Location = new System.Drawing.Point(160, 48);
			this.grid.Name = "grid";
			this.grid.RowHeaderWidth = 20;
			this.grid.Selekto = true;
			this.grid.Size = new System.Drawing.Size(464, 244);
			this.grid.TabIndex = 6;
			this.grid.Visible = false;
			// 
			// gbKolonat
			// 
			this.gbKolonat.BackColor = System.Drawing.Color.Transparent;
			this.gbKolonat.Controls.Add(this.linkKesh);
			this.gbKolonat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbKolonat.Location = new System.Drawing.Point(8, 44);
			this.gbKolonat.Name = "gbKolonat";
			this.gbKolonat.Size = new System.Drawing.Size(136, 144);
			this.gbKolonat.TabIndex = 5;
			this.gbKolonat.Visible = false;
			this.gbKolonat.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// linkKesh
			// 
			this.linkKesh.ActiveLinkColor = System.Drawing.Color.DarkRed;
			this.linkKesh.ForeColor = System.Drawing.SystemColors.Desktop;
			this.linkKesh.LinkColor = System.Drawing.Color.Chocolate;
			this.linkKesh.Location = new System.Drawing.Point(64, 40);
			this.linkKesh.Name = "linkKesh";
			this.linkKesh.Size = new System.Drawing.Size(40, 23);
			this.linkKesh.TabIndex = 5;
			this.linkKesh.TabStop = true;
			this.linkKesh.Text = "Cash";
			this.toolTips.SetToolTip(this.linkKesh, "Shfaq grafikun per te ardhurat cash.");
			this.linkKesh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKesh_LinkClicked);
			// 
			// btnKerko
			// 
			this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko.DoValidation = true;
			this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKerko.Location = new System.Drawing.Point(156, 20);
			this.btnKerko.Name = "btnKerko";
			this.btnKerko.Size = new System.Drawing.Size(90, 21);
			this.btnKerko.TabIndex = 5;
			this.btnKerko.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko, "Shfaq bilancin sipas muajve per vitin e zgjedhur.");
			this.btnKerko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
			// 
			// ds
			// 
			this.ds.DataSetName = "NewDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.rbGrafik);
			this.groupBox3.Controls.Add(this.rbTabele);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox3.Location = new System.Drawing.Point(276, 40);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(194, 76);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.Text = "Zgjidhni formen e paraqitjes";
			this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// rbGrafik
			// 
			this.rbGrafik.Location = new System.Drawing.Point(12, 44);
			this.rbGrafik.Name = "rbGrafik";
			this.rbGrafik.Size = new System.Drawing.Size(164, 24);
			this.rbGrafik.TabIndex = 3;
			this.rbGrafik.Text = "Paraqitje grafike";
			this.toolTips.SetToolTip(this.rbGrafik, "Paraqet bilancin sipas muajve ne forme grafike.");
			// 
			// rbTabele
			// 
			this.rbTabele.Checked = true;
			this.rbTabele.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbTabele.Location = new System.Drawing.Point(12, 16);
			this.rbTabele.Name = "rbTabele";
			this.rbTabele.Size = new System.Drawing.Size(164, 20);
			this.rbTabele.TabIndex = 2;
			this.rbTabele.TabStop = true;
			this.rbTabele.Text = "Paraqitje tabelare";
			this.toolTips.SetToolTip(this.rbTabele, "Paraqet bilancin ne forme tabelare.");
			this.rbTabele.CheckedChanged += new System.EventHandler(this.rbTabele_CheckedChanged);
			// 
			// dsPagesa
			// 
			this.dsPagesa.DataSetName = "NewDataSet";
			this.dsPagesa.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.checkBox1);
			this.groupBox2.Controls.Add(this.cbBarRes);
			this.groupBox2.Controls.Add(this.cbHoteli);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Location = new System.Drawing.Point(10, 40);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(254, 76);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.Text = "Modulet";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cbBarRes
			// 
			this.cbBarRes.BackColor = System.Drawing.Color.Transparent;
			this.cbBarRes.DefaultErrorMessage = "";
			this.cbBarRes.IsValid = true;
			this.cbBarRes.Location = new System.Drawing.Point(12, 36);
			this.cbBarRes.Name = "cbBarRes";
			this.cbBarRes.Size = new System.Drawing.Size(192, 16);
			this.cbBarRes.TabIndex = 1;
			this.cbBarRes.Text = "Bar Manager";
			// 
			// cbHoteli
			// 
			this.cbHoteli.BackColor = System.Drawing.Color.Transparent;
			this.cbHoteli.Checked = true;
			this.cbHoteli.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbHoteli.DefaultErrorMessage = "";
			this.cbHoteli.IsValid = true;
			this.cbHoteli.Location = new System.Drawing.Point(12, 16);
			this.cbHoteli.Name = "cbHoteli";
			this.cbHoteli.Size = new System.Drawing.Size(136, 16);
			this.cbHoteli.TabIndex = 0;
			this.cbHoteli.Text = "Hotel Manager";
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.DefaultErrorMessage = "";
			this.checkBox1.IsValid = true;
			this.checkBox1.Location = new System.Drawing.Point(12, 56);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(192, 16);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Restorant Manager";
			// 
			// BilancMujor
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1036, 780);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.HelpFile = "BILANC MUJOR.htm";
			this.Name = "BilancMujor";
			this.Text = "Bilanc mujor";
			this.TitullGjeresi = 1036;
			this.Load += new System.EventHandler(this.BilancMujor_Load);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.groupBox3, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gbKolonat)).EndInit();
			this.gbKolonat.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsPagesa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		#region EventHandlers
		private void BilancMujor_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				//pastrim variablash private
				this.dsPagesa.Tables.Clear();
				this.ds.Tables.Clear();
				this.readyToPrint = false;
				this.grid.TableStyles.Clear();
				//pastrim variablash private
				this.dateTimePicker1.Value = System.DateTime.Today;
				InputController data = new InputController();
				DateTime viti_korrent = Convert.ToDateTime(this.dateTimePicker1.Value);
				ds = data.KerkesaRead("BilancMujorPerVitinKorrent", viti_korrent);
				this.readyToPrint = true;
				grid.DataSource = ds.Tables[0];
				grid.Visible = true;
				this.groupBox1.Size = new Size(494, 308);
				this.grid.Location = new Point(12, 48);
				this.dsPagesa = data.KerkesaRead("ShfaqTeGjithaFormatEPageses");
				this.rbGrafik.Checked = false;
				this.rbTabele.Checked = true;
				this.RemoveLinks();//per te mos i shtuar linket disa here
				this.AddLinks();
				this.KrijoStilGrid();
				// Hidh ne Xml datasetin i cili do te duhet per printim
				ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\BilancMujor.xml");
				this.NdertoZedGrafik();
			}
			catch (SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch (Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return ;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
		
		private void rbTabele_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				if (this.rbTabele.Checked == true)
				{
					this.grid.Visible = true;
					this.ZedBilanci.Visible = false;
					this.groupBox1.Height = 308;//494, 308
					if (this.dsPagesa.Tables[0].Rows.Count <=5)
					{
						grid.Width =464 + 80* this.dsPagesa.Tables[0].Rows.Count;
						this.groupBox1.Width = 494 + 80* this.dsPagesa.Tables[0].Rows.Count;
					}
					else
					{
						grid.Width = 464 + 80* 5;
						this.groupBox1.Width = 494 +  80* 5;
					}
					this.grid.Location = new Point(12, 48);
					this.lblKolonat.Visible = false;
					this.linkBilanci.Visible = false;
					this.linkShpenzime.Visible = false;
					this.linkTeArdhura.Visible = false;
					this.linkTeGjitha.Visible = false;
					this.gbKolonat.Visible = false;
					this.readyToPrint = true;
				}
				else
				{
					this.grid.Visible = false;
					this.ZedBilanci.Visible = true;
					this.groupBox1.Height = 465;//
					this.groupBox1.Width = 970;
					this.ZedBilanci.Height = 400;
					this.ZedBilanci.Width = 800;
					this.ZedBilanci.Location = new Point(156, 48);
					this.gbKolonat.Visible = true;
					this.lblKolonat.Visible = true;
					this.linkBilanci.Visible = true;
					this.linkShpenzime.Visible = true;
					this.linkTeArdhura.Visible = true;
					this.linkTeGjitha.Visible = true;
					this.gbKolonat.Visible = true;
					this.readyToPrint = false;
				}
			}
			catch (SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch (Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return ;
			}
		}
		private void btnKerko_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				if (Convert.ToDateTime(this.dateTimePicker1.Value) > DateTime.Now)
					this.ReadyToPrint = false;
				else
					this.ReadyToPrint = true;
				InputController data = new InputController();
				DateTime date_kerkimi = Convert.ToDateTime(this.dateTimePicker1.Value);
				this.groupBox1.Text = "Bilanci per vitin " + date_kerkimi.Year;
				ds = data.KerkesaRead("BilancMujorPerVitinKorrent", date_kerkimi);
				grid.DataSource = ds.Tables[0];
				if (this.rbTabele.Checked == false)
					grid.Visible = false;
				this.NdertoZedGrafik();
				this.ZedBilanci.Refresh();
				ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\BilancMujor.xml");
			}
			catch (SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch (Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return ;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void linkBilanci_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				//this.ZedBilanci.MasterPane.PaneList.Clear();
				this.ZedBilanci.Refresh();
				GraphPane BilancPane = new GraphPane();
				BilancPane.Title = "Bilanci per vitin e zgjedhur";
				BilancPane.XAxis.Title = "Muajt";
				BilancPane.XAxis.TitleFontSpec.FontColor = Color.Chocolate;
				BilancPane.XAxis.TitleFontSpec.Family = "Microsoft Sans Serif";
				BilancPane.XAxis.TitleFontSpec.Size = 12;
				BilancPane.YAxis.Title = "Vlera";
				BilancPane.YAxis.TitleFontSpec.FontColor = Color.Chocolate;
				BilancPane.YAxis.TitleFontSpec.Family = "Microsoft Sans Serif";
				BilancPane.YAxis.TitleFontSpec.Size = 12;
				double[] bilanci = new double[12];
				for(int i = 0; i < 12; i++)
				{					
					bilanci[i] = Convert.ToDouble(ds.Tables[0].Rows[i]["BILANCI"]);
				}
				string[] str = { "Janar", "Shkurt", "Mars", "Prill", "Maj", "Qershor", "Korrik", "Gusht", 
								   "Shtator", "Tetor", "Nentor", "Dhjetor"};
				BarItem BilanciVije = BilancPane.AddBar( "Bilanci", null, bilanci, Color.AliceBlue );
				BilanciVije.Bar.Fill =  new Fill( Color.White,Color.DarkSeaGreen,45.0f );
				BilanciVije.Bar.Border.IsVisible = true;

				// Draw the X tics between the labels instead of at the labels
				BilancPane.XAxis.IsTicsBetweenLabels = false;

				// Set the XAxis labels
				BilancPane.XAxis.TextLabels = str;
				BilancPane.XAxis.StepAuto = false;
			
				// Set the XAxis to Text type
				BilancPane.XAxis.Type = AxisType.Text;

				// Fill the axis background with a color gradient
				BilancPane.AxisFill = new Fill( Color.White, Color.LightSteelBlue, 45.0f );
				BilancPane.PaneFill = new Fill(Color.White, Color.Bisque, 45.0f);
				// enable the legend
				BilancPane.Legend.IsVisible = true;
				BilancPane.PaneRect = new RectangleF(0, 0, 800, 400);
				// percakohet fonti i titullit
				BilancPane.FontSpec = new FontSpec("Microsoft Sans Serif", 12, Color.Chocolate, true, false, false);
				const float shift = 5;
				for ( int i=0; i<bilanci.Length; i++ )
				{
					// format the label string to have 0 decimal place
					string lab = bilanci[i].ToString();
					// create the text item (assumes the x axis is ordinal or text)
					// for negative bars, the label appears just above the zero value
					TextItem text = new TextItem( lab, (float) (i+1), (float) (bilanci[i] < 0 ? 0.0 : bilanci[i]) + shift );
					// tell Zedgraph to use user scale units for locating the TextItem
					text.Location.CoordinateFrame = CoordType.AxisXYScale;
					// AlignH the left-center of the text to the specified point
					text.Location.AlignH = AlignH.Left;
					text.Location.AlignV = AlignV.Center;
					text.FontSpec.Border.IsVisible = false;
					text.FontSpec.Fill.IsVisible = false;
					// rotate the text 90 degrees
					text.FontSpec.Angle = 90;
					// add the TextItem to the list
					BilancPane.GraphItemList.Add( text );
				}

				ZedBilanci.MasterPane.PaneList.Clear();
				ZedBilanci.GraphPane = BilancPane;
				ZedBilanci.GraphPane.MarginAll = 10;
				ZedBilanci.Anchor	= AnchorStyles.Left | AnchorStyles.Top  
					| AnchorStyles.Right | AnchorStyles.Bottom;
				ZedBilanci.Width = 800;
				ZedBilanci.Height = 400;
				ZedBilanci.Parent = this.groupBox1;
				ZedBilanci.Location = new Point(156, 48);
				this.ZedBilanci.AxisChange();
				this.ZedBilanci.Refresh();

				
			}
			catch (SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch (Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return ;
			}
		}

		private void linkShpenzime_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				this.ZedBilanci.Refresh();
				GraphPane BilancPane = new GraphPane();
				BilancPane.Title = "Shpenzimet per vitin e zgjedhur";
				BilancPane.XAxis.Title = "Muajt";
				BilancPane.XAxis.TitleFontSpec.FontColor = Color.Chocolate;
				BilancPane.XAxis.TitleFontSpec.Family = "Microsoft Sans Serif";
				BilancPane.XAxis.TitleFontSpec.Size = 12;
				BilancPane.YAxis.Title = "Vlera";
				BilancPane.YAxis.TitleFontSpec.FontColor = Color.Chocolate;
				BilancPane.YAxis.TitleFontSpec.Family = "Microsoft Sans Serif";
				BilancPane.YAxis.TitleFontSpec.Size = 12;
				double[] shpenzime = new double[12];
				for(int i = 0; i < 12; i++)
				{					
					shpenzime[i] = Convert.ToDouble(ds.Tables[0].Rows[i]["SHPENZIME"]);
				}
				string[] str = { "Janar", "Shkurt", "Mars", "Prill", "Maj", "Qershor", "Korrik", "Gusht", 
								   "Shtator", "Tetor", "Nentor", "Dhjetor"};
				BarItem ShpenzimeVije = BilancPane.AddBar( "Shpenzimet", null, shpenzime, Color.AliceBlue );
				ShpenzimeVije.Bar.Fill =  new Fill(Color.White, Color.Salmon,45.0f );
				ShpenzimeVije.Bar.Border.IsVisible = true;

				// Draw the X tics between the labels instead of at the labels
				BilancPane.XAxis.IsTicsBetweenLabels = false;

				// Set the XAxis labels
				BilancPane.XAxis.TextLabels = str;
				BilancPane.XAxis.StepAuto = false;
			
				// Set the XAxis to Text type
				BilancPane.XAxis.Type = AxisType.Text;

				// Fill the axis background with a color gradient
				BilancPane.AxisFill = new Fill( Color.White, Color.LightSteelBlue, 45.0f );
				BilancPane.PaneFill = new Fill(Color.White, Color.Bisque, 45.0f);
				// enable the legend
				BilancPane.Legend.IsVisible = true;
				BilancPane.PaneRect = new RectangleF(0, 0, 800, 400);
				// percakohet fonti i titullit
				BilancPane.FontSpec = new FontSpec("Microsoft Sans Serif", 12, Color.Chocolate, true, false, false);
				const float shift = 5;
				for ( int i=0; i<shpenzime.Length; i++ )
				{
					// format the label string to have 0 decimal place
					string lab = shpenzime[i].ToString();
					// create the text item (assumes the x axis is ordinal or text)
					// for negative bars, the label appears just above the zero value
					TextItem text = new TextItem( lab, (float) (i+1), (float) (shpenzime[i] < 0 ? 0.0 : shpenzime[i]) + shift );
					// tell Zedgraph to use user scale units for locating the TextItem
					text.Location.CoordinateFrame = CoordType.AxisXYScale;
					// AlignH the left-center of the text to the specified point
					text.Location.AlignH = AlignH.Left;
					text.Location.AlignV = AlignV.Center;
					text.FontSpec.Border.IsVisible = false;
					text.FontSpec.Fill.IsVisible = false;
					text.FontSpec.FontColor = Color.MidnightBlue;
					// rotate the text 90 degrees
					text.FontSpec.Angle = 90;
					// add the TextItem to the list
					BilancPane.GraphItemList.Add( text );
				}

				ZedBilanci.MasterPane.PaneList.Clear();
				ZedBilanci.GraphPane = BilancPane;
				ZedBilanci.GraphPane.MarginAll = 10;
				ZedBilanci.Anchor	= AnchorStyles.Left | AnchorStyles.Top  
					| AnchorStyles.Right | AnchorStyles.Bottom;
				ZedBilanci.Width = 800;
				ZedBilanci.Height = 400;
				ZedBilanci.Parent = this.groupBox1;
				ZedBilanci.Location = new Point(156, 48);
				this.ZedBilanci.AxisChange();
				this.ZedBilanci.Refresh();				
			}
			catch (SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch (Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return ;
			}	
		}

		private void linkTeGjitha_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				this.NdertoZedGrafik();
			}
			catch (SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch (Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return ;
			}
		}
		private void linkKesh_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				this.ZedBilanci.Refresh();
				GraphPane BilancPane = new GraphPane();
				BilancPane.Title = "Te ardhurat cash per vitin e zgjedhur";
				BilancPane.XAxis.Title = "Muajt";
				BilancPane.XAxis.TitleFontSpec.FontColor = Color.Chocolate;
				BilancPane.XAxis.TitleFontSpec.Family = "Microsoft Sans Serif";
				BilancPane.XAxis.TitleFontSpec.Size = 12;
				BilancPane.YAxis.Title = "Vlera";
				BilancPane.YAxis.TitleFontSpec.FontColor = Color.Chocolate;
				BilancPane.YAxis.TitleFontSpec.Family = "Microsoft Sans Serif";
				BilancPane.YAxis.TitleFontSpec.Size = 12;
				double[] kesh = new double[12];
				for(int i = 0; i < 12; i++)
				{					
					kesh[i] = Convert.ToDouble(ds.Tables[0].Rows[i]["CASH"]);
				}
				string[] str = { "Janar", "Shkurt", "Mars", "Prill", "Maj", "Qershor", "Korrik", "Gusht", 
								   "Shtator", "Tetor", "Nentor", "Dhjetor"};
				BarItem KeshVije = BilancPane.AddBar( "Cash", null, kesh, Color.AliceBlue );
				KeshVije.Bar.Fill =  new Fill(Color.White, Color.SteelBlue,45.0f );
				KeshVije.Bar.Border.IsVisible = true;

				// Draw the X tics between the labels instead of at the labels
				BilancPane.XAxis.IsTicsBetweenLabels = false;

				// Set the XAxis labels
				BilancPane.XAxis.TextLabels = str;
				BilancPane.XAxis.StepAuto = false;
			
				// Set the XAxis to Text type
				BilancPane.XAxis.Type = AxisType.Text;

				// Fill the axis background with a color gradient
				BilancPane.AxisFill = new Fill( Color.White, Color.LightSteelBlue, 45.0f );
				BilancPane.PaneFill = new Fill(Color.White, Color.Bisque, 45.0f);
				// enable the legend
				BilancPane.Legend.IsVisible = true;
				BilancPane.PaneRect = new RectangleF(0, 0, 800, 400);
				// percakohet fonti i titullit
				BilancPane.FontSpec = new FontSpec("Microsoft Sans Serif", 12, Color.Chocolate, true, false, false);
				const float shift = 5;
				for ( int i=0; i<kesh.Length; i++ )
				{
					// format the label string to have 0 decimal place
					string lab = kesh[i].ToString();
					// create the text item (assumes the x axis is ordinal or text)
					// for negative bars, the label appears just above the zero value
					TextItem text = new TextItem( lab, (float) (i+1), (float) (kesh[i] < 0 ? 0.0 : kesh[i]) + shift );
					// tell Zedgraph to use user scale units for locating the TextItem
					text.Location.CoordinateFrame = CoordType.AxisXYScale;
					// AlignH the left-center of the text to the specified point
					text.Location.AlignH = AlignH.Left;
					text.Location.AlignV = AlignV.Center;
					text.FontSpec.Border.IsVisible = false;
					text.FontSpec.Fill.IsVisible = false;
					text.FontSpec.FontColor = Color.MidnightBlue;
					// rotate the text 90 degrees
					text.FontSpec.Angle = 90;
					// add the TextItem to the list
					BilancPane.GraphItemList.Add( text );
				}

				ZedBilanci.MasterPane.PaneList.Clear();
				ZedBilanci.GraphPane = BilancPane;
				ZedBilanci.GraphPane.MarginAll = 10;
				ZedBilanci.Anchor	= AnchorStyles.Left | AnchorStyles.Top  
					| AnchorStyles.Right | AnchorStyles.Bottom;
				ZedBilanci.Width = 800;
				ZedBilanci.Height = 400;
				ZedBilanci.Parent = this.groupBox1;
				ZedBilanci.Location = new Point(156, 48);
				this.ZedBilanci.AxisChange();
				this.ZedBilanci.Refresh();				
			}
			catch (SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch (Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return ;
			}	
		}
		private void link_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				System.Windows.Forms.LinkLabel l = (System.Windows.Forms.LinkLabel) sender;
				string emriLink = l.Name;
				this.ZedBilanci.Refresh();
				GraphPane BilancPane = new GraphPane();
				BilancPane.Title = "Te ardhurat ne " + emriLink + " per vitin e zgjedhur";
				BilancPane.XAxis.Title = "Muajt";
				BilancPane.XAxis.TitleFontSpec.FontColor = Color.Chocolate;
				BilancPane.XAxis.TitleFontSpec.Family = "Microsoft Sans Serif";
				BilancPane.XAxis.TitleFontSpec.Size = 12;
				BilancPane.YAxis.Title = "Vlera";
				BilancPane.YAxis.TitleFontSpec.FontColor = Color.Chocolate;
				BilancPane.YAxis.TitleFontSpec.Family = "Microsoft Sans Serif";
				BilancPane.YAxis.TitleFontSpec.Size = 12;
				double[] v = new double[12];
				for(int i = 0; i < 12; i++)
				{					
					v[i] = Convert.ToDouble(ds.Tables[0].Rows[i][emriLink]);
				}
				string[] str = { "Janar", "Shkurt", "Mars", "Prill", "Maj", "Qershor", "Korrik", "Gusht", 
								   "Shtator", "Tetor", "Nentor", "Dhjetor"};
				BarItem Vije = BilancPane.AddBar( emriLink, null, v, Color.AliceBlue );
				Vije.Bar.Fill =  new Fill(Color.White, Color.SteelBlue ,45.0f );
				Vije.Bar.Border.IsVisible = true;

				// Draw the X tics between the labels instead of at the labels
				BilancPane.XAxis.IsTicsBetweenLabels = false;

				// Set the XAxis labels
				BilancPane.XAxis.TextLabels = str;
				BilancPane.XAxis.StepAuto = false;
			
				// Set the XAxis to Text type
				BilancPane.XAxis.Type = AxisType.Text;

				// Fill the axis background with a color gradient
				BilancPane.AxisFill = new Fill( Color.White, Color.LightSteelBlue, 45.0f );
				BilancPane.PaneFill = new Fill(Color.White, Color.Bisque, 45.0f);
				// enable the legend
				BilancPane.Legend.IsVisible = true;
				BilancPane.PaneRect = new RectangleF(0, 0, 800, 400);
				// percakohet fonti i titullit
				BilancPane.FontSpec = new FontSpec("Microsoft Sans Serif", 12, Color.Chocolate, true, false, false);
				const float shift = 5;
				for ( int i=0; i<v.Length; i++ )
				{
					// format the label string to have 0 decimal place
					string lab = v[i].ToString();
					// create the text item (assumes the x axis is ordinal or text)
					// for negative bars, the label appears just above the zero value
					TextItem text = new TextItem( lab, (float) (i+1), (float) (v[i] < 0 ? 0.0 : v[i]) + shift );
					// tell Zedgraph to use user scale units for locating the TextItem
					text.Location.CoordinateFrame = CoordType.AxisXYScale;
					// AlignH the left-center of the text to the specified point
					text.Location.AlignH = AlignH.Left;
					text.Location.AlignV = AlignV.Center;
					text.FontSpec.Border.IsVisible = false;
					text.FontSpec.Fill.IsVisible = false;
					text.FontSpec.FontColor = Color.MidnightBlue;
					// rotate the text 90 degrees
					text.FontSpec.Angle = 90;
					// add the TextItem to the list
					BilancPane.GraphItemList.Add( text );
				}

				ZedBilanci.MasterPane.PaneList.Clear();
				ZedBilanci.GraphPane = BilancPane;
				ZedBilanci.GraphPane.MarginAll = 10;
				ZedBilanci.Anchor	= AnchorStyles.Left | AnchorStyles.Top  
					| AnchorStyles.Right | AnchorStyles.Bottom;
				ZedBilanci.Width = 800;
				ZedBilanci.Height = 400;
				ZedBilanci.Parent = this.groupBox1;
				ZedBilanci.Location = new Point(156, 48);
				this.ZedBilanci.AxisChange();
				this.ZedBilanci.Refresh();				
			}
			catch (SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch (Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return ;
			}		
		}
		private void linkTeArdhura_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				//this.ZedBilanci.MasterPane.PaneList.Clear();
				this.ZedBilanci.Refresh();

				GraphPane BilancPane = new GraphPane();
				BilancPane.Title = "Te ardhurat per vitin e zgjedhur";
				BilancPane.XAxis.Title = "Muajt";
				BilancPane.XAxis.TitleFontSpec.FontColor = Color.Chocolate;
				BilancPane.XAxis.TitleFontSpec.Family = "Microsoft Sans Serif";
				BilancPane.XAxis.TitleFontSpec.Size = 12;
				BilancPane.YAxis.Title = "Vlera";
				BilancPane.YAxis.TitleFontSpec.FontColor = Color.Chocolate;
				BilancPane.YAxis.TitleFontSpec.Family = "Microsoft Sans Serif";
				BilancPane.YAxis.TitleFontSpec.Size = 12;
				double[] teArdhura = new double[12];
				for(int i = 0; i < 12; i++)
				{					
					teArdhura[i] = Convert.ToDouble(ds.Tables[0].Rows[i]["TE_ARDHURA"]);
				}
				string[] str = { "Janar", "Shkurt", "Mars", "Prill", "Maj", "Qershor", "Korrik", "Gusht", 
								   "Shtator", "Tetor", "Nentor", "Dhjetor"};
				BarItem TeArdhuraVije = BilancPane.AddBar( "Te ardhurat", null, teArdhura, Color.AliceBlue );		
				TeArdhuraVije.Bar.Fill =  new Fill( Color.White, System.Drawing.SystemColors.Desktop,45.0f);
				TeArdhuraVije.Bar.Border.IsVisible = true;

				// Draw the X tics between the labels instead of at the labels
				BilancPane.XAxis.IsTicsBetweenLabels = false;

				// Set the XAxis labels
				BilancPane.XAxis.TextLabels = str;
				BilancPane.XAxis.StepAuto = false;
			
				// Set the XAxis to Text type
				BilancPane.XAxis.Type = AxisType.Text;

				// Fill the axis background with a color gradient
				BilancPane.AxisFill = new Fill( Color.White, Color.LightSteelBlue, 45.0f );
				BilancPane.PaneFill = new Fill(Color.White, Color.Bisque, 45.0f);
				// enable the legend
				BilancPane.Legend.IsVisible = true;
				BilancPane.PaneRect = new RectangleF(0, 0, 800, 400);
				// percakohet fonti i titullit
				BilancPane.FontSpec = new FontSpec("Microsoft Sans Serif", 12, Color.Chocolate, true, false, false);
				const float shift = 5;
				for ( int i=0; i<teArdhura.Length; i++ )
				{
					// format the label string to have 0 decimal place
					string lab = teArdhura[i].ToString();
					// create the text item (assumes the x axis is ordinal or text)
					// for negative bars, the label appears just above the zero value
					TextItem text = new TextItem( lab, (float) (i+1), (float) (teArdhura[i] < 0 ? 0.0 : teArdhura[i]) + shift );
					// tell Zedgraph to use user scale units for locating the TextItem
					text.Location.CoordinateFrame = CoordType.AxisXYScale;
					// AlignH the left-center of the text to the specified point
					text.Location.AlignH = AlignH.Left;
					text.Location.AlignV = AlignV.Center;
					text.FontSpec.Border.IsVisible = false;
					text.FontSpec.Fill.IsVisible = false;
					text.FontSpec.FontColor = Color.MidnightBlue;
					// rotate the text 90 degrees
					text.FontSpec.Angle = 90;
					// add the TextItem to the list
					BilancPane.GraphItemList.Add( text );
				}

				ZedBilanci.MasterPane.PaneList.Clear();
				ZedBilanci.GraphPane = BilancPane;
				ZedBilanci.GraphPane.MarginAll = 10;
				ZedBilanci.Anchor	= AnchorStyles.Left | AnchorStyles.Top  
					| AnchorStyles.Right | AnchorStyles.Bottom;
				ZedBilanci.Width = 800;
				ZedBilanci.Height = 400;
				ZedBilanci.Parent = this.groupBox1;
				ZedBilanci.Location = new Point(156, 48);
				this.ZedBilanci.AxisChange();
				this.ZedBilanci.Refresh();
			}
			catch (SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch (Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return ;
			}
		}

		#endregion

		#region Private Methods
		/// <summary>
		/// Nderton grafikun qe eshte ne forme duke bere dhe formatimin e tij
		/// </summary>
		
		private void NdertoZedGrafik()
		{
			try
			{
				this.ZedBilanci.Refresh();
				GraphPane BilancPane = new GraphPane();
				BilancPane.Title = "Bilanci, te ardhurat dhe shpenzimet per vitin e zgjedhur";
				BilancPane.XAxis.Title = "Muajt";
				BilancPane.XAxis.TitleFontSpec.FontColor = Color.Chocolate;
				BilancPane.XAxis.TitleFontSpec.Family = "Microsoft Sans Serif";
				BilancPane.XAxis.TitleFontSpec.Size = 12;
				BilancPane.YAxis.Title = "Vlera";
				BilancPane.YAxis.TitleFontSpec.FontColor = Color.Chocolate;
				BilancPane.YAxis.TitleFontSpec.Family = "Microsoft Sans Serif";
				BilancPane.YAxis.TitleFontSpec.Size = 12;
				double[] bilanci = new double[12];
				double[] teArdhura = new double[12];
				double[] shpenzime = new double[12];
				double[] maximum = new double[12];
				double[] minimum = new double[12];
				for(int i = 0; i < 12; i++)
				{
					bilanci[i] = Convert.ToDouble(ds.Tables[0].Rows[i]["BILANCI"]);
					maximum[i] = bilanci[i];
					minimum[i] = bilanci[i];
					
					teArdhura[i] = Convert.ToDouble(ds.Tables[0].Rows[i]["TE_ARDHURA"]);
					if (maximum[i] < teArdhura[i])
						maximum[i] = teArdhura[i];
					if (minimum[i] > teArdhura[i])
						minimum[i] = teArdhura[i];

					shpenzime[i] = Convert.ToDouble(ds.Tables[0].Rows[i]["SHPENZIME"]);
					if (maximum[i] < shpenzime[i])
						maximum[i] = shpenzime[i];
					if (minimum[i] > shpenzime[i])
						minimum[i] = shpenzime[i]; 
				}
				string[] str = { "Janar", "Shkurt", "Mars", "Prill", "Maj", "Qershor", "Korrik", "Gusht", 
								   "Shtator", "Tetor", "Nentor", "Dhjetor"};
				BarItem TeArdhuraVije = BilancPane.AddBar( "Te ardhurat", null, teArdhura, Color.AliceBlue );		
				TeArdhuraVije.Bar.Fill =  new Fill( Color.White, System.Drawing.SystemColors.Desktop ,45.0f);
				TeArdhuraVije.Bar.Border.IsVisible = true;

				BarItem ShpenzimeVije = BilancPane.AddBar( "Shpenzimet", null, shpenzime, Color.AliceBlue );
				ShpenzimeVije.Bar.Fill =  new Fill(Color.White, Color.Salmon,45.0f );
				ShpenzimeVije.Bar.Border.IsVisible = true;

				BarItem BilanciVije = BilancPane.AddBar( "Bilanci", null, bilanci, Color.AliceBlue );
				BilanciVije.Bar.Fill =  new Fill( Color.White,Color.DarkSeaGreen,45.0f );
				BilanciVije.Bar.Border.IsVisible = true;

				// Draw the X tics between the labels instead of at the labels
				BilancPane.XAxis.IsTicsBetweenLabels = false;

				// Set the XAxis labels
				BilancPane.XAxis.TextLabels = str;
				BilancPane.XAxis.StepAuto = false;
			
				// Set the XAxis to Text type
				BilancPane.XAxis.Type = AxisType.Text;

				// Fill the axis background with a color gradient
				BilancPane.AxisFill = new Fill( Color.White, Color.LightSteelBlue, 45.0f );
				BilancPane.PaneFill = new Fill(Color.White, Color.Bisque, 45.0f);
				// enable the legend
				BilancPane.Legend.IsVisible = true;
				BilancPane.PaneRect = new RectangleF(0, 0, 800, 400);
				// percakohet fonti i titullit
				BilancPane.FontSpec = new FontSpec("Microsoft Sans Serif", 12, Color.Chocolate, true, false, false);
				for(int i = 0; i < 12; i++)
				{
					//Convert.ToInt32(maximum[i]+ 10)
					BoxItem box = new BoxItem(new RectangleF(0.5f + i, Convert.ToInt32(maximum[i]),1,Convert.ToInt32(maximum[i])), Color.MidnightBlue, Color.White, Color.Empty);
					box.Location.CoordinateFrame = CoordType.AxisXYScale;
					box.Location.AlignH = AlignH.Left;
					box.Location.AlignV = AlignV.Top;
					box.ZOrder = ZOrder.E_BehindAxis;
					BilancPane.GraphItemList.Add( box );
					if (minimum[i] < 0)
					{
						BoxItem box2 = new BoxItem(new RectangleF(0.5f + i, 0,1,Convert.ToInt32(minimum[i])), Color.MidnightBlue, Color.White, Color.Empty);
						box2.Location.CoordinateFrame = CoordType.AxisXYScale;
						box2.Location.AlignH = AlignH.Left;
						box2.Location.AlignV = AlignV.Top;
						box2.ZOrder = ZOrder.E_BehindAxis;
						BilancPane.GraphItemList.Add( box2 );
					}

				}

				ZedBilanci.MasterPane.PaneList.Clear();
				ZedBilanci.GraphPane = BilancPane;
				ZedBilanci.GraphPane.MarginAll = 10;
				ZedBilanci.Anchor	= AnchorStyles.Left | AnchorStyles.Top  
					| AnchorStyles.Right | AnchorStyles.Bottom;
				ZedBilanci.Width = 800;
				ZedBilanci.Height = 400;
				ZedBilanci.Parent = this.groupBox1;
				ZedBilanci.Location = new Point(156, 48);
				this.ZedBilanci.AxisChange();
				this.ZedBilanci.Refresh();
				
			}
			catch(Exception ex)
			{
				return;
			}

		}

		/// <summary>
		/// Krijon stilin e grides grid, i cili eshte stili qe do te perdoret
		/// </summary>
		private void KrijoStilGrid()
		{
			this.grid.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.Bisque;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			this.grid.ReadOnly = true;
			style.AllowSorting = false;

			DataGridTextBoxColumn colNr = new DataGridTextBoxColumn();
			colNr.HeaderText = "Nr.";
			colNr.MappingName = "NR";
			colNr.Width = 30;
			colNr.NullText = "";
			style.GridColumnStyles.Add(colNr);

			DataGridTextBoxColumn colMuaji = new DataGridTextBoxColumn();
			colMuaji.HeaderText = "Muaji";
			colMuaji.MappingName = "MUAJI";
			colMuaji.Width = 100;
			style.GridColumnStyles.Add(colMuaji);

			foreach(DataRow dr in this.dsPagesa.Tables[0].Rows)
			{
				string emriKolona = dr["EMRI"].ToString();
				DataGridTextBoxColumn col = new DataGridTextBoxColumn();
				string perqindja = "(" + dr["PERQINDJA"].ToString() + "%)";
				col.HeaderText = emriKolona + perqindja;
				col.MappingName = emriKolona;
				col.Width = 80;
				col.NullText = "";
				style.GridColumnStyles.Add(col);
			}

			DataGridTextBoxColumn colTeArdhura = new DataGridTextBoxColumn();
			colTeArdhura.HeaderText = "Te ardhurat";
			colTeArdhura.MappingName = "TE_ARDHURA";
			colTeArdhura.Width = 110;
			style.GridColumnStyles.Add(colTeArdhura);
	
			DataGridTextBoxColumn colShpenzime = new DataGridTextBoxColumn();
			colShpenzime.HeaderText = "Shpenzimet";
			colShpenzime.MappingName = "SHPENZIME";
			colShpenzime.Width = 110;
			style.GridColumnStyles.Add(colShpenzime);

			DataGridTextBoxColumn colBilanci = new DataGridTextBoxColumn();
			colBilanci.HeaderText = "Bilanci mujor";
			colBilanci.MappingName = "BILANCI";
			colBilanci.Width = 110;
			style.GridColumnStyles.Add(colBilanci);

			//style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{colNr, colMuaji, colTeArdhura, colShpenzime, colBilanci});
			grid.TableStyles.Add(style);
			grid.FlatMode = false;
			grid.Expand(-1);
			if (this.dsPagesa.Tables[0].Rows.Count <=5)
			{
				grid.Width = 464 + 80* this.dsPagesa.Tables[0].Rows.Count;
				this.groupBox1.Width = 494 + 80* this.dsPagesa.Tables[0].Rows.Count;
			}
			else
			{
				grid.Width = 464 + 80* 5;
				this.groupBox1.Width = 494 + 80* 5;
			}

		}

		
		/// <summary>
		/// ben konvertimin e muajve ne string
		/// <param name="i"></param>
		/// </summary>
		/// <returns>string</returns>
		private string Muaji(int i)
		{
			string s;
			switch(i)
			{
				case 1:
					s = "Janar";
					break;
				case 2:
					s = "Shkurt";
					break;
				case 3:
					s = "Mars";
					break;
				case 4:
					s = "Prill";
					break;
				case 5:
					s = "Maj";
					break;
				case 6:
					s = "Qershor";
					break;
				case 7:
					s = "Korrik";
					break;
				case 8:
					s = "Gusht";
					break;
				case 9:
					s = "Shtator";
					break;
				case 10:
					s = "Tetor";
					break;
				case 11:
					s = "Nentor";
					break;
				case 12:
					s = "Dhjetor";
					break;
				default:
					s = "";
					break;
			}
			return s;
		}
		private void RemoveLinks()
		{
			foreach(Control c in this.gbKolonat.Controls)
			{
				foreach(DataRow dr in this.dsPagesa.Tables[0].Rows)
				{
					if (c is LinkLabel)
					{
						if (c.Name == dr["EMRI"].ToString())
						{
							c.Dispose();
							break;
						}
					}
				}
			}
		}
		private void AddLinks()
		{
			int last = 40;
			int nr = this.dsPagesa.Tables[0].Rows.Count;
			this.gbKolonat.Height = 144 + (nr - 1) * 23;
			int pos = this.gbKolonat.Top;
			this.linkShpenzime.Location = new Point(60,(nr ) * 24 + last + pos);
			this.linkBilanci.Location = new Point(60,(nr ) * 24 + last + 24 + pos);
			this.linkTeGjitha.Location = new Point(60,(nr ) * 24 + last + 48 + pos);
			for(int i = 1; i < nr; i++)
			{
				DataRow dr = dsPagesa.Tables[0].Rows[i];
				string emriLink = dr["Emri"].ToString();
				System.Windows.Forms.LinkLabel link = new LinkLabel();
				link.Name = emriLink;
				link.Text = emriLink;
				link.LinkColor = System.Drawing.Color.Chocolate;
				link.ActiveLinkColor = Color.DarkRed;
				this.gbKolonat.Controls.Add(link);
				link.Size = new Size(72, 23);
				link.Location = new Point(64, last + 24);
				last += 24;
				link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
			}
		}
		#endregion

		#region IPrintable Members

		public void PrintPreview()
		{
			int result = 0;
			PrintBilancMujorPrompt printPrompt = new PrintBilancMujorPrompt(this.dateTimePicker1.Text);
			printPrompt.ShowDialog();
			if (printPrompt == null)
				return;
			result = printPrompt.result;
			// Hiq formen qe i kerkon perdoruesit te beje zgjedhje, nga memorja
			printPrompt.Dispose();
			// Nese perdoruesi shtyp butonin Anullo ose mbyll formen atehere dil pa bere asgje
			if (result == 0)
			{
				return;
			}
			// Perndryshe hap ne Print Preview zgjedhjen e perdoruesit
			Printim printim = new Printim();
			if (result == 1)
				printim.NgarkoRaport("ShfaqBilancMujor");
			else
				printim.NgarkoRaport("ShfaqGrafikMujor");
			printim.ShowDialog();
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
			int result = 0;
			PrintBilancMujorPrompt printPrompt = new PrintBilancMujorPrompt(this.dateTimePicker1.Text);
			printPrompt.ShowDialog();
			if (printPrompt == null)
				return;
			result = printPrompt.result;
			// Hiq formen qe i kerkon perdoruesit te beje zgjedhje, nga memorja
			printPrompt.Dispose();
			// Nese perdoruesi shtyp butonin Anullo ose mbyll formen atehere dil pa bere asgje
			if (result == 0)
			{
				return;
			}
			// Perndryshe hap ne Print Preview zgjedhjen e perdoruesit
			Printim printim = new Printim();
			if (result == 1)
				printim.Printo("ShfaqBilancMujor");
			else
				printim.Printo("ShfaqGrafikMujor");
		}

		
	
		public event VisionInfoSolutionLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

		#endregion
	}
}

