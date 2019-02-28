using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Drawing2D;
using VisionInfoSolutionLibrary;
using System.Reflection;
using System.Reflection.Emit;


namespace HotelManagment.Forms
{
	public class DhomatNePerdorim : VisionInfoSolutionLibrary.Form
	{
		#region Private Fields

		private System.Data.DataSet ds;
		private VisionInfoSolutionLibrary.DataGrid grid;
		private VisionInfoSolutionLibrary.TabControl tab;
		private VisionInfoSolutionLibrary.TabPageControl tbDite;
		private VisionInfoSolutionLibrary.TabPageControl tbOre;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private System.Data.DataSet ds1;
		private VisionInfoSolutionLibrary.DataGrid grid1;
		private System.Data.DataSet ds2;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.DataGrid grid2;
		private int numer_dhomash;
		private int numer_datash;
		private int nr_rez;
		private int nr_hyrje;
		private Point pointInCell00;
		private VisionInfoSolutionLibrary.DataGrid hGrid;
		private bool clicked;
		private VisionInfoSolutionLibrary.GroupBox gbDhomatNePerdorim;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.RadioButton rbSot;
		private VisionInfoSolutionLibrary.RadioButton rbTjeter;
		private VisionInfoSolutionLibrary.GroupBox groupBox3;
		private VisionInfoSolutionLibrary.Label label4;
		private System.Windows.Forms.Panel panel4;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.Label label5;
		private System.Windows.Forms.Panel panel2;
		private VisionInfoSolutionLibrary.Label label6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		/// <summary>
		/// Variabel privat qe mban vleren per propertine ReadyToPrint
		/// </summary>
		private bool readyToPrint = true;
		#endregion

		#region Constructors & Destructors
		public DhomatNePerdorim()
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
			this.gbDhomatNePerdorim = new VisionInfoSolutionLibrary.GroupBox();
			this.grid = new VisionInfoSolutionLibrary.DataGrid();
			this.hGrid = new VisionInfoSolutionLibrary.DataGrid();
			this.ds = new System.Data.DataSet();
			this.tab = new VisionInfoSolutionLibrary.TabControl();
			this.tbDite = new VisionInfoSolutionLibrary.TabPageControl();
			this.groupBox3 = new VisionInfoSolutionLibrary.GroupBox();
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.rbTjeter = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbSot = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.tbOre = new VisionInfoSolutionLibrary.TabPageControl();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.grid2 = new VisionInfoSolutionLibrary.DataGrid();
			this.grid1 = new VisionInfoSolutionLibrary.DataGrid();
			this.ds2 = new System.Data.DataSet();
			this.ds1 = new System.Data.DataSet();
			((System.ComponentModel.ISupportInitialize)(this.gbDhomatNePerdorim)).BeginInit();
			this.gbDhomatNePerdorim.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.tab.SuspendLayout();
			this.tbDite.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.tbOre.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1011, 24);
			// 
			// gbDhomatNePerdorim
			// 
			this.gbDhomatNePerdorim.BackColor = System.Drawing.Color.Transparent;
			this.gbDhomatNePerdorim.Controls.Add(this.grid);
			this.gbDhomatNePerdorim.Controls.Add(this.hGrid);
			this.gbDhomatNePerdorim.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbDhomatNePerdorim.Location = new System.Drawing.Point(10, 64);
			this.gbDhomatNePerdorim.Name = "gbDhomatNePerdorim";
			this.gbDhomatNePerdorim.Size = new System.Drawing.Size(910, 503);
			this.gbDhomatNePerdorim.TabIndex = 1;
			this.gbDhomatNePerdorim.Text = "Gjendja e dhomave ditore nga sot deri ne rezervimin apo hyrjen e fundit te vlefsh" +
				"me";
			this.gbDhomatNePerdorim.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// grid
			// 
			this.grid.AllowSorting = false;
			this.grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.grid.CanDelete = true;
			this.grid.CaptionBackColor = System.Drawing.SystemColors.ControlLightLight;
			this.grid.CaptionVisible = false;
			this.grid.ColumnHeadersVisible = false;
			this.grid.DataMember = "";
			this.grid.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.grid.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.grid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grid.HideHorizontalScrollBar = false;
			this.grid.HideVerticalScrollBar = false;
			this.grid.Location = new System.Drawing.Point(12, 60);
			this.grid.Name = "grid";
			this.grid.PreferredColumnWidth = 60;
			this.grid.RowHeaderWidth = 15;
			this.grid.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
			this.grid.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
			this.grid.Selekto = false;
			this.grid.Size = new System.Drawing.Size(884, 432);
			this.grid.TabIndex = 0;
			this.grid.Paint += new System.Windows.Forms.PaintEventHandler(this.grid_Paint);
			// 
			// hGrid
			// 
			this.hGrid.AllowSorting = false;
			this.hGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.hGrid.CanDelete = true;
			this.hGrid.CaptionVisible = false;
			this.hGrid.ColumnHeadersVisible = false;
			this.hGrid.DataMember = "";
			this.hGrid.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.hGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.hGrid.HideHorizontalScrollBar = false;
			this.hGrid.HideVerticalScrollBar = false;
			this.hGrid.Location = new System.Drawing.Point(12, 16);
			this.hGrid.Name = "hGrid";
			this.hGrid.ReadOnly = true;
			this.hGrid.RowHeaderWidth = 20;
			this.hGrid.Selekto = false;
			this.hGrid.Size = new System.Drawing.Size(884, 100);
			this.hGrid.TabIndex = 1;
			// 
			// ds
			// 
			this.ds.DataSetName = "NewDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// tab
			// 
			this.tab.Controls.Add(this.tbDite);
			this.tab.Controls.Add(this.tbOre);
			this.tab.Cursor = System.Windows.Forms.Cursors.Default;
			this.tab.ItemSize = new System.Drawing.Size(63, 18);
			this.tab.Location = new System.Drawing.Point(0, 24);
			this.tab.Name = "tab";
			this.tab.Padding = new System.Drawing.Point(0, 0);
			this.tab.SelectedIndex = 0;
			this.tab.Size = new System.Drawing.Size(1011, 609);
			this.tab.TabIndex = 2;
			this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
			// 
			// tbDite
			// 
			this.tbDite.BackColor = System.Drawing.SystemColors.Control;
			this.tbDite.Controls.Add(this.groupBox3);
			this.tbDite.Controls.Add(this.rbTjeter);
			this.tbDite.Controls.Add(this.rbSot);
			this.tbDite.Controls.Add(this.groupBox1);
			this.tbDite.Controls.Add(this.gbDhomatNePerdorim);
			this.tbDite.DefaultErrorMessage = null;
			this.tbDite.EnableValidation = true;
			this.tbDite.IsValid = true;
			this.tbDite.Location = new System.Drawing.Point(4, 22);
			this.tbDite.Name = "tbDite";
			this.tbDite.Size = new System.Drawing.Size(1003, 583);
			this.tbDite.TabIndex = 0;
			this.tbDite.Text = "Dhomat ditore";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.panel1);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.panel2);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.panel3);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.panel4);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox3.Location = new System.Drawing.Point(148, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(532, 52);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.Text = "Legjenda";
			this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label6
			// 
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Location = new System.Drawing.Point(52, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 20);
			this.label6.TabIndex = 30;
			this.label6.Text = "Plotesisht e lire";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(8, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(40, 20);
			this.panel1.TabIndex = 29;
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(192, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 20);
			this.label5.TabIndex = 32;
			this.label5.Text = "Pjeserisht e lire";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Location = new System.Drawing.Point(148, 20);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(40, 20);
			this.panel2.TabIndex = 31;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(336, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 20);
			this.label3.TabIndex = 34;
			this.label3.Text = "E zene";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Salmon;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Location = new System.Drawing.Point(288, 20);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(40, 20);
			this.panel3.TabIndex = 33;
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Location = new System.Drawing.Point(444, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 20);
			this.label4.TabIndex = 36;
			this.label4.Text = "E rezervuar";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.NavajoWhite;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Location = new System.Drawing.Point(396, 20);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(40, 20);
			this.panel4.TabIndex = 35;
			// 
			// rbTjeter
			// 
			this.rbTjeter.BackColor = System.Drawing.Color.Transparent;
			this.rbTjeter.Location = new System.Drawing.Point(20, 40);
			this.rbTjeter.Name = "rbTjeter";
			this.rbTjeter.Size = new System.Drawing.Size(104, 16);
			this.rbTjeter.TabIndex = 4;
			this.rbTjeter.Text = "Ne vazhdim";
			this.toolTips.SetToolTip(this.rbTjeter, "Paraqet dhomat ne perdorim duke perfshire edhe ditet qe kane kaluar per rezervimi" +
				"n apo hyrjen!");
			// 
			// rbSot
			// 
			this.rbSot.BackColor = System.Drawing.Color.Transparent;
			this.rbSot.Checked = true;
			this.rbSot.Location = new System.Drawing.Point(20, 20);
			this.rbSot.Name = "rbSot";
			this.rbSot.Size = new System.Drawing.Size(104, 16);
			this.rbSot.TabIndex = 3;
			this.rbSot.TabStop = true;
			this.rbSot.Text = "Nga sot";
			this.toolTips.SetToolTip(this.rbSot, "Shfaq dhomat ditorene perdorim nga sot e ne vazhdim!");
			this.rbSot.CheckedChanged += new System.EventHandler(this.rbSot_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(10, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(130, 52);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// tbOre
			// 
			this.tbOre.BackColor = System.Drawing.SystemColors.Control;
			this.tbOre.Controls.Add(this.groupBox2);
			this.tbOre.DefaultErrorMessage = null;
			this.tbOre.EnableValidation = true;
			this.tbOre.IsValid = true;
			this.tbOre.Location = new System.Drawing.Point(4, 22);
			this.tbOre.Name = "tbOre";
			this.tbOre.Size = new System.Drawing.Size(1003, 583);
			this.tbOre.TabIndex = 1;
			this.tbOre.Text = "Dhomat me ore";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.grid2);
			this.groupBox2.Controls.Add(this.grid1);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(822, 392);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.Text = "Rezervimet dhe hyrjet per dhomat me ore ";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(416, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Hyrjet e vlefshme";
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(12, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Rezervimet e vlefshme";
			// 
			// grid2
			// 
			this.grid2.AllowSorting = false;
			this.grid2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.grid2.CanDelete = true;
			this.grid2.CaptionVisible = false;
			this.grid2.DataMember = "";
			this.grid2.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.grid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grid2.HideHorizontalScrollBar = false;
			this.grid2.HideVerticalScrollBar = false;
			this.grid2.Location = new System.Drawing.Point(416, 48);
			this.grid2.Name = "grid2";
			this.grid2.RowHeadersVisible = false;
			this.grid2.RowHeaderWidth = 20;
			this.grid2.Selekto = true;
			this.grid2.Size = new System.Drawing.Size(385, 328);
			this.grid2.TabIndex = 1;
			this.toolTips.SetToolTip(this.grid2, "Paraqet hyrjet ende te vlefshme vetem per dhomat me ore!");
			// 
			// grid1
			// 
			this.grid1.AllowSorting = false;
			this.grid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.grid1.CanDelete = true;
			this.grid1.CaptionVisible = false;
			this.grid1.DataMember = "";
			this.grid1.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grid1.HideHorizontalScrollBar = false;
			this.grid1.HideVerticalScrollBar = false;
			this.grid1.Location = new System.Drawing.Point(12, 48);
			this.grid1.Name = "grid1";
			this.grid1.RowHeadersVisible = false;
			this.grid1.RowHeaderWidth = 20;
			this.grid1.Selekto = true;
			this.grid1.Size = new System.Drawing.Size(385, 328);
			this.grid1.TabIndex = 0;
			this.toolTips.SetToolTip(this.grid1, "Paraqet rezervimet ende te vlefshme vetem per dhomat me ore!");
			// 
			// ds2
			// 
			this.ds2.DataSetName = "NewDataSet";
			this.ds2.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// ds1
			// 
			this.ds1.DataSetName = "NewDataSet";
			this.ds1.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// DhomatNePerdorim
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(926, 547);
			this.Controls.Add(this.tab);
			this.HelpFile = "DHOMA NE PERDORIM.htm";
			this.Name = "DhomatNePerdorim";
			this.Text = "Dhomat ne perdorim";
			this.TitullGjeresi = 1011;
			this.Load += new System.EventHandler(this.DhomatNePerdorim_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.tab, 0);
			((System.ComponentModel.ISupportInitialize)(this.gbDhomatNePerdorim)).EndInit();
			this.gbDhomatNePerdorim.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.tab.ResumeLayout(false);
			this.tbDite.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.tbOre.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void DhomatNePerdorim_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				if (this.tab.SelectedIndex == 0)//dhomat ditore
				{
					clicked = false;
					grid.GridHorizontallyScrolled += new VisionInfoSolutionLibrary.DataGrid.GridHScrolledEventHandler(grid_GridHorizontallyScrolled);
					InputController data = new InputController();
					ds = data.KerkesaRead("ShfaqDhomaNePerdorim", 0);
					numer_datash = ds.Tables[0].Columns.Count - 3;
					numer_dhomash = ds.Tables[0].Rows.Count;
					numer_datash--;
					if (numer_dhomash == 0) 
					{
						System.Windows.Forms.MessageBox.Show(this, "Ne hotel nuk eshte konfiguruar asnje dhome momentalisht." + Environment.NewLine + "Vazhdoni me konfigurimin e dhomeve!","Dhomat ditore ne perdorim", MessageBoxButtons.OK, MessageBoxIcon.Information);
						grid.DataSource = null;
						this.hGrid.DataSource = null;
						return;
					}
					else
					{
						if (numer_datash == 0)
						{
							System.Windows.Forms.MessageBox.Show(this,"Nuk ka asnje rezervim apo hyrje te vlefshme" + "\r\n" + "per ditet ne vazhdim!" ,"Dhomat ditore ne perdorim", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}
						grid.DataSource = ds.Tables[0];
						this.hGrid.DataSource = ds.Tables[1];
						// Nese ne gride nuk paraqiten aq data sa per te mbushur gjeresine e grides, atehere
						// ndrysho gjeresine e grides ne proporcion te drejte me numrin e diteve ne gride
						if (ds.Tables[1].Columns.Count < 20)
						{
							int count = ds.Tables[1].Columns.Count - 1;
							this.grid.Width = 884 - (20 - count) * 40;
							this.hGrid.Width = 884 - (20 - count) * 40;
							this.gbDhomatNePerdorim.Width = this.grid.Width + 26;
						}
						// Krijo stilet per gridat
						this.KrijoStilHeader(0);
						this.KrijoStilGrid(0);

					}
					pointInCell00 = new Point(grid.GetCellBounds(0,0).X + 4, grid.GetCellBounds(0,0).Y + 4);
				}
				else
				{
					this.tab_SelectedIndexChanged(sender, e);
				}
			}
			catch (SqlException ex)
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

		private void rbSot_CheckedChanged(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				if (this.rbSot.Checked == true)
				{
					grid.GridHorizontallyScrolled += new VisionInfoSolutionLibrary.DataGrid.GridHScrolledEventHandler(grid_GridHorizontallyScrolled);
					InputController data = new InputController();
					ds = data.KerkesaRead("ShfaqDhomaNePerdorim", 0);
					numer_datash = ds.Tables[0].Columns.Count - 3;
					numer_dhomash = ds.Tables[0].Rows.Count;
					numer_datash--;
					if (numer_dhomash == 0)
					{
						System.Windows.Forms.MessageBox.Show(this, "Ne hotel nuk eshte konfiguruar asnje dhome momentalisht." + Environment.NewLine + "Vazhdoni me konfigurimin e dhomeve!","Dhomat ditore ne perdorim", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					if (numer_datash == 0)
					{
						System.Windows.Forms.MessageBox.Show(this,"Nuk ka asnje rezervim apo hyrje te vlefshme" + "\r\n" + "per ditet ne vazhdim!" ,"Dhomat ditore ne perdorim", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					grid.DataSource = ds.Tables[0];
					this.hGrid.DataSource = ds.Tables[1];
					// Nese ne gride nuk paraqiten aq data sa per te mbushur gjeresine e grides, atehere
					// ndrysho gjeresine e grides ne proporcion te drejte me numrin e diteve ne gride
					//884, 432
					if (ds.Tables[1].Columns.Count <= 20)
					{
						int count = ds.Tables[1].Columns.Count - 1;
						this.grid.Width = 884 - (20 - count) * 40;
						this.hGrid.Width = 884 - (20 - count) * 40;
						this.gbDhomatNePerdorim.Width = this.grid.Width + 26;
					}
					else
					{
						this.grid.Width = 884;
						this.hGrid.Width = 884;
						this.gbDhomatNePerdorim.Width = this.grid.Width + 26;
					}
					// Krijo stilet per gridat
					this.KrijoStilHeader(0);
					this.KrijoStilGrid(0);
					if (numer_dhomash == 0)
						return;
					pointInCell00 = new Point(grid.GetCellBounds(0,0).X + 4, grid.GetCellBounds(0,0).Y + 4);
				}
				else
				{
					grid.GridHorizontallyScrolled += new VisionInfoSolutionLibrary.DataGrid.GridHScrolledEventHandler(grid_GridHorizontallyScrolled);
					InputController data = new InputController();
					ds = data.KerkesaRead("ShfaqDhomaNePerdorim", 1);
					numer_datash = ds.Tables[0].Columns.Count - 3;
					numer_dhomash = ds.Tables[0].Rows.Count;
					numer_datash--;
					if (numer_dhomash == 0)
					{
						System.Windows.Forms.MessageBox.Show(this, "Ne hotel nuk eshte konfiguruar asnje dhome momentalisht." + Environment.NewLine + "Vazhdoni me konfigurimin e dhomeve!","Dhomat ditore ne perdorim", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					if (numer_datash == 0)
					{
						System.Windows.Forms.MessageBox.Show(this,"Nuk ka asnje rezervim apo hyrje te vlefshme" + "\r\n" + "per ditet ne vazhdim!" ,"Dhomat ditore ne perdorim", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					grid.DataSource = ds.Tables[0];
					this.hGrid.DataSource = ds.Tables[1];
					// Nese ne gride nuk paraqiten aq data sa per te mbushur gjeresine e grides, atehere
					// ndrysho gjeresine e grides ne proporcion te drejte me numrin e diteve ne gride
					if (ds.Tables[1].Columns.Count <= 20)
					{
						int count = ds.Tables[1].Columns.Count - 1;
						this.grid.Width = 884 - (20 - count) * 40;
						this.hGrid.Width = 884 - (20 - count) * 40;
						this.gbDhomatNePerdorim.Width = this.grid.Width + 26;
					}
					else
					{
						this.grid.Width = 884;
						this.hGrid.Width = 884;
						this.gbDhomatNePerdorim.Width = this.grid.Width + 26;
					}
					// Krijo stilet per gridat
					this.KrijoStilHeader(1);
					this.KrijoStilGrid(1);
					pointInCell00 = new Point(grid.GetCellBounds(0,0).X + 4, grid.GetCellBounds(0,0).Y + 4);
				}
			}
			catch (SqlException ex)
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
				int i = Convert.ToInt32(tab.SelectedIndex);
				if (i == 0)
				{
					this.DhomatNePerdorim_Load(sender, e);
				}
				else if (i == 1)
				{
					InputController data = new InputController();	
					ds1 = data.KerkesaRead("ShfaqRezervimetVlefshmePerDhomatMeOre");
					nr_rez = ds1.Tables[0].Rows.Count;
					this.KrijoStilGrid1();
					this.KrijoStilGrid2();
					if (nr_rez == 0)
					{
						DialogResult result = System.Windows.Forms.MessageBox.Show(this,"Nuk ka asnje rezervim te vlefshem per dhomat me ore!" , "Rezervimet e vlefshme per dhomat me ore",MessageBoxButtons.OK, MessageBoxIcon.Information);
						grid1.DataSource = null;
					}
					else
					{
						grid1.DataSource = ds1.Tables[0];
						this.KrijoStilGrid1();
					}
					ds2 = data.KerkesaRead("ShfaqHyrjetPasSotDhomatMeOre");
					nr_hyrje = ds2.Tables[0].Rows.Count;
					if (nr_hyrje == 0)
					{
						DialogResult result = System.Windows.Forms.MessageBox.Show(this,"Nuk ka asnje hyrje te vlefshme per dhomat me ore!" , "Hyrjet e vlefshme per dhomat me ore", MessageBoxButtons.OK, MessageBoxIcon.Information);
						grid2.DataSource = null;
					}
					else
					{
						grid2.DataSource = ds2.Tables[0];
						this.KrijoStilGrid2();	
					}
				
					if (clicked == false)
					{
						clicked = true;
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
			finally
			{
				this.AutoScrollPosition = new Point(0, 0);
				this.Cursor = Cursors.Default;
			}
		}	
		#endregion

		#region Private Methods
		private void KrijoStilHeader(int neVazhdim)
		{
			hGrid.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table2";
			style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.hGrid.ReadOnly = true;
			style.PreferredRowHeight = 26;
			style.RowHeadersVisible = true;
			style.HeaderBackColor = SystemColors.InactiveCaptionText;
			DateTime data_sot = System.DateTime.Today;
			DateTime data_pare;
			if (neVazhdim == 1)
				data_pare = Convert.ToDateTime(ds.Tables[0].Columns[3].ColumnName);
			else
				data_pare = data_sot;
			DateTime data;
			string str_data;
			for(int i = 0; i < numer_datash; i++)
			{
				DataGridColoredTextBoxColumn colData = new DataGridColoredTextBoxColumn();
				//data = data_sot.AddDays(i);
				data = data_pare.AddDays(i);
				str_data = data.ToShortDateString();
				colData.MappingName = this.ConvertDate(str_data);
				colData.HeaderText = ConDate(str_data);
				colData.Width = 40;
				colData.NullText = "";
				style.GridColumnStyles.Add(colData);
			}
			
			style.RowHeaderWidth = 80;
			hGrid.TableStyles.Add(style);
			hGrid.FlatMode = false;
			hGrid.Expand(-1);
			
		}
		private void KrijoStilGrid(int neVazhdim)
		{
			grid.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			style.GridLineColor = System.Drawing.Color.SteelBlue;
			this.grid.ReadOnly = true;
			style.PreferredRowHeight = 16;
			style.RowHeadersVisible = true;
			style.HeaderBackColor = SystemColors.InactiveCaptionText;
			DateTime data_sot = System.DateTime.Today;
			DateTime data_pare;
			if (neVazhdim == 1)
				data_pare = Convert.ToDateTime(ds.Tables[0].Columns[3].ColumnName);
			else
				data_pare = data_sot;
			DateTime data;
			string str_data;
			for(int i = -3; i < numer_datash; i++)
			{
				DataGridColoredTextBoxColumn colData = new DataGridColoredTextBoxColumn();
				if (i >= 0)
				{
					
					//data = data_sot.AddDays(i);
					data = data_pare.AddDays(i);
					str_data = data.ToShortDateString();
					colData.MappingName = this.ConvertDate(str_data);
					colData.HeaderText = ConDate(str_data);
					colData.Width = 40;
					colData.NullText = "";
					style.GridColumnStyles.Add(colData);
				}
				else if (i == -3)
				{
					colData.HeaderText = "Id";
					colData.MappingName = "ID_DHOMA";
					colData.Width = 0;
					style.GridColumnStyles.Add(colData);
				}
				else if (i == -2)
				{	
					//					colData.HeaderText = "Dhoma";
					//					colData.MappingName = "DHOMA_EMRI";
					//					colData.Width = 100;
					//					style.GridColumnStyles.Add(colData);
				}
				else if ( i == -1)
				{
					colData.HeaderText = "Numer Krevatesh";
					colData.MappingName = "NR_KREVATESH";
					colData.Width = 0;
					style.GridColumnStyles.Add(colData);
				}
			}
			style.RowHeaderWidth = 80;
			grid.TableStyles.Add(style);
			grid.FlatMode = false;
		}
		
				
		private string ConvertDate(string date)
		{
			return date.Substring(0, 4) +  Environment.NewLine  + date.Substring(5, 5);
		}

		
		private string ConDate(string date)
		{
			return date.Substring(0, 4) + Environment.NewLine + date.Substring(5);
		}

		
		private void KrijoStilGrid1()
		{
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			style.RowHeadersVisible = false;
			style.HeaderBackColor = SystemColors.InactiveCaptionText;
			this.grid1.ReadOnly = true;
			this.grid1.TableStyles.Clear();

			DataGridTextBoxColumn colEmri = new DataGridTextBoxColumn();
			colEmri.HeaderText = "Dhoma";
			colEmri.MappingName = "DHOMA_EMRI";
			colEmri.Width = 80;
			//colVlera.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));

			DataGridTextBoxColumn colDataFillimi = new DataGridTextBoxColumn();
			colDataFillimi.HeaderText = "Date/Ore fillimi";
			colDataFillimi.MappingName = "DATA_FILLIMI_STR";
			colDataFillimi.Width = 150;

			DataGridTextBoxColumn colDataMbarimi = new DataGridTextBoxColumn();
			colDataMbarimi.HeaderText = "Date/Ore mbarimi";
			colDataMbarimi.MappingName = "DATA_MBARIMI_STR";
			colDataMbarimi.Width = 150;

			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{ colEmri, colDataFillimi, colDataMbarimi});
			grid1.TableStyles.Add(style);
			grid1.FlatMode = false;
			grid1.Expand(-1);
		}

		
		private void KrijoStilGrid2()
		{
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			style.RowHeadersVisible = false;
			style.HeaderBackColor = SystemColors.InactiveCaptionText;
			this.grid2.ReadOnly = true;
			this.grid2.TableStyles.Clear();

			DataGridTextBoxColumn colEmri = new DataGridTextBoxColumn();
			colEmri.HeaderText = "Dhoma";
			colEmri.MappingName = "DHOMA_EMRI";
			colEmri.Width = 80;

			//colVlera.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));

			DataGridTextBoxColumn colDataFillimi = new DataGridTextBoxColumn();
			colDataFillimi.HeaderText = "Date/Ore hyrje";
			colDataFillimi.MappingName = "DATA_HYRJE_STR";
			colDataFillimi.Width = 150;

			DataGridTextBoxColumn colDataMbarimi = new DataGridTextBoxColumn();
			colDataMbarimi.HeaderText = "Date/Ore dalje";
			colDataMbarimi.MappingName = "DATA_DALJE_STR";
			colDataMbarimi.Width = 150;

			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{ colEmri, colDataFillimi, colDataMbarimi});
			grid2.TableStyles.Add(style);
			grid2.FlatMode = false;
			grid2.Expand(-1);
		}
		#endregion

		#region Paint
		private void grid_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			try
			{
				int row = TopRow();
				if (row < 0)
					return;
				double yDelta = grid.GetCellBounds(row, 0).Height + 0.8;
				double y = grid.GetCellBounds(row, 0).Top + 6;
				DataTable dt = (DataTable)this.grid.DataSource;
				CurrencyManager cm = (CurrencyManager) this.BindingContext[grid.DataSource, grid.DataMember];

				while(y < grid.Height - yDelta && row < cm.Count)
				{
					//Kap dhe vendos tekstin e headerit
					string text = string.Format(dt.Rows[row][1].ToString());
					e.Graphics.DrawString(text, grid.Font, new SolidBrush(Color.Black), 6, (float)y);
					y += yDelta;
					row++;
				}
			}
			catch(Exception ex)
			{
				return;
			}
		}

		private int TopRow()
		{
			System.Windows.Forms.DataGrid.HitTestInfo hti = grid.HitTest(this.pointInCell00);
			return hti.Row;
		}

		private void grid_GridHorizontallyScrolled(object sender, ScrollEventArgs se)
		{
			hGrid.ScrollGridHorizontal(sender, se);
		}
		public Color MyGetColorRowCol(int row, int col)
		{

			// just conditionally set colors based on row, col values...
			Color c = Color.LightGreen;
			if( col % 2 == 0) 
				c = Color.Goldenrod;

			if( (row + col) % 5 == 0)
				c = Color.Pink;
			else if((row + col) % 3 == 0)
				c = Color.BlueViolet;

			return c;
		}
		#endregion
	}
}

