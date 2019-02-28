using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using VisionInfoSolutionLibrary;

namespace HotelManagment.Forms
{
	public class DhomaPashlyera : VisionInfoSolutionLibrary.Form, IPrintable
	{
		#region Private Fields
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.DataGrid grid;
		private System.Data.DataSet ds;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private System.Data.DataSet ds1;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.Button btnInfo;
		private VisionInfoSolutionLibrary.TabControl tabControl1;
		private VisionInfoSolutionLibrary.TabPageControl tabPage1;
		private VisionInfoSolutionLibrary.TabPageControl tabPage2;
		private VisionInfoSolutionLibrary.GroupBox groupBox3;
		private VisionInfoSolutionLibrary.DataGrid grid1;
		private VisionInfoSolutionLibrary.GroupBox groupBox4;
		private VisionInfoSolutionLibrary.Button btnInfo1;
		private System.Data.DataSet dsGrupi;
		private VisionInfoSolutionLibrary.Button button1;
		private bool readyToPrint = false;
		private bool clicked = false;
		#endregion

		#region Constructors & Destructors
		public DhomaPashlyera()
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
			this.grid = new VisionInfoSolutionLibrary.DataGrid();
			this.ds = new System.Data.DataSet();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.ds1 = new System.Data.DataSet();
			this.btnInfo = new VisionInfoSolutionLibrary.Button(this.components);
			this.tabControl1 = new VisionInfoSolutionLibrary.TabControl();
			this.tabPage1 = new VisionInfoSolutionLibrary.TabPageControl();
			this.tabPage2 = new VisionInfoSolutionLibrary.TabPageControl();
			this.groupBox3 = new VisionInfoSolutionLibrary.GroupBox();
			this.grid1 = new VisionInfoSolutionLibrary.DataGrid();
			this.groupBox4 = new VisionInfoSolutionLibrary.GroupBox();
			this.btnInfo1 = new VisionInfoSolutionLibrary.Button(this.components);
			this.dsGrupi = new System.Data.DataSet();
			this.button1 = new VisionInfoSolutionLibrary.Button(this.components);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsGrupi)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1015, 25);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.grid);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(10, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(564, 468);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.Text = "Dhomat e pashlyera ne hotel";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
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
			this.grid.Location = new System.Drawing.Point(12, 20);
			this.grid.Name = "grid";
			this.grid.RowHeaderWidth = 20;
			this.grid.Selekto = true;
			this.grid.Size = new System.Drawing.Size(540, 436);
			this.grid.TabIndex = 0;
			this.toolTips.SetToolTip(this.grid, "Te dhenat per dhomat e pashlyera ne hotel!");
			this.grid.Click += new System.EventHandler(this.grid_Click);
			this.grid.CurrentCellChanged += new System.EventHandler(this.grid_CurrentCellChanged);
			// 
			// ds
			// 
			this.ds.DataSetName = "NewDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(584, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(236, 141);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.Text = "groupBox2";
			this.groupBox2.Visible = false;
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// ds1
			// 
			this.ds1.DataSetName = "NewDataSet";
			this.ds1.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// btnInfo
			// 
			this.btnInfo.BackColor = System.Drawing.Color.Blue;
			this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInfo.DoValidation = true;
			this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnInfo.Location = new System.Drawing.Point(660, 160);
			this.btnInfo.Name = "btnInfo";
			this.btnInfo.Size = new System.Drawing.Size(90, 21);
			this.btnInfo.TabIndex = 4;
			this.btnInfo.Text = "Info";
			this.btnInfo.Visible = false;
			this.btnInfo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1015, 609);
			this.tabControl1.TabIndex = 5;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.btnInfo);
			this.tabPage1.DefaultErrorMessage = null;
			this.tabPage1.EnableValidation = true;
			this.tabPage1.IsValid = false;
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(1007, 583);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Dhomat";
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Controls.Add(this.btnInfo1);
			this.tabPage2.DefaultErrorMessage = null;
			this.tabPage2.EnableValidation = true;
			this.tabPage2.IsValid = false;
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(1007, 583);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Grupet";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.grid1);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(10, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(564, 468);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.Text = "Grupet e pashlyer ne hotel";
			this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
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
			this.grid1.Location = new System.Drawing.Point(12, 20);
			this.grid1.Name = "grid1";
			this.grid1.RowHeaderWidth = 20;
			this.grid1.Selekto = true;
			this.grid1.Size = new System.Drawing.Size(540, 436);
			this.grid1.TabIndex = 0;
			this.toolTips.SetToolTip(this.grid1, "Te dhenat per dhomat e pashlyera ne hotel!");
			this.grid1.Click += new System.EventHandler(this.grid1_Click);
			this.grid1.CurrentCellChanged += new System.EventHandler(this.grid1_CurrentCellChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(584, 8);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(236, 156);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.Text = "groupBox4";
			this.groupBox4.Visible = false;
			this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// btnInfo1
			// 
			this.btnInfo1.BackColor = System.Drawing.Color.Blue;
			this.btnInfo1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInfo1.DoValidation = true;
			this.btnInfo1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnInfo1.Location = new System.Drawing.Point(656, 176);
			this.btnInfo1.Name = "btnInfo1";
			this.btnInfo1.Size = new System.Drawing.Size(90, 21);
			this.btnInfo1.TabIndex = 7;
			this.btnInfo1.Text = "Info";
			this.btnInfo1.Visible = false;
			this.btnInfo1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnInfo1.Click += new System.EventHandler(this.btnInfo1_Click);
			// 
			// dsGrupi
			// 
			this.dsGrupi.DataSetName = "NewDataSet";
			this.dsGrupi.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.DoValidation = true;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 21);
			this.button1.TabIndex = 0;
			this.button1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// DhomaPashlyera
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(814, 390);
			this.Controls.Add(this.tabControl1);
			this.HelpFile = "DHOMA TE PASHLYERA.htm";
			this.Name = "DhomaPashlyera";
			this.Text = "Dhoma te pashlyera";
			this.TitullGjeresi = 1015;
			this.Load += new System.EventHandler(this.DhomaPashlyera_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.tabControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsGrupi)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void DhomaPashlyera_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				this.clicked = false;
				InputController data = new InputController();
				//pastrim variablash private dhe te tjera
				this.ds.Tables.Clear();
				this.ds1.Tables.Clear();
				this.dsGrupi.Tables.Clear();
				foreach (Control c in this.groupBox2.Controls)
				{
					if (c is VisionInfoSolutionLibrary.DataGrid)
					{
						c.Dispose();
						break;
					}
				}
				foreach (Control c in this.groupBox4.Controls)
				{
					if (c is VisionInfoSolutionLibrary.DataGrid)
					{
						c.Dispose();
						break;
					}
				}
				this.groupBox2.Visible = false;
				this.btnInfo.Visible = false;
				if (this.tabControl1.SelectedIndex == 0)
				{
					//pastrim variablash private dhe te tjera
					ds = data.KerkesaRead("ShfaqDhomatEPashlyera");
					// Hidh ne skedar XML datasetin sepse sherben per mbushjen e raportit
					int numer_rreshtash = ds.Tables[0].Rows.Count;
					if (numer_rreshtash == 0)
					{
						this.ReadyToPrint = false;
						DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dhoma te pashlyera",
							"Ne hotel nuk ka asnje dhome te pashlyer", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						this.grid.TableStyles.Clear();
						grid.DataSource = ds.Tables[0];
						this.KrijoStilGrid();
						this.ReadyToPrint = true;
						DataSet ds1 = data.KerkesaRead("ShfaqDhomatEPashlyeraPrint");
						ds1.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\ShfaqDhomatEPashlyera.xml");
					}
				}
				else
				{
					this.tabControl1_SelectedIndexChanged(sender, e);
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
		private void grid_CurrentCellChanged(object sender, System.EventArgs e)
		{
			try
			{
				int n = ds.Tables[0].Rows.Count;
				if (n == 0)
				{
					this.groupBox2.Visible = false;
					this.btnInfo.Visible = false;
					return;
				}
				this.groupBox2.Visible = true;
				this.btnInfo.Visible = true;
				PastroGr();
				InputController data = new InputController();
				int rowIndex = grid.CurrentRowIndex;
				if (grid[rowIndex, 0].ToString() == "SHUMA")
				{
					this.groupBox2.Visible = false;
					this.btnInfo.Visible = false;
					return;
				}
				string dhoma = grid[rowIndex, 0].ToString();
				this.groupBox2.Text = "Klientet e pashlyer ne dhomen "+ dhoma;
				ds1 = data.KerkesaRead("KlientetEPashlyerPerDhomen", dhoma);
				VisionInfoSolutionLibrary.DataGrid gridKlienti = new VisionInfoSolutionLibrary.DataGrid();
				this.groupBox2.Controls.Add(gridKlienti);
				gridKlienti.Location = new Point(12, 20);
				gridKlienti.BackgroundColor = System.Drawing.Color.WhiteSmoke;
				int nr = ds1.Tables[1].Columns.Count;
				gridKlienti.Width = 209;
				if (nr == 2)
				{
					gridKlienti.Height = 93;
				}
				else
				{
					gridKlienti.Height = 110;
				}
				gridKlienti.DataSource = ds1.Tables[1];
				this.KrijoStilGrid(gridKlienti);
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

		private void grid_Click(object sender, System.EventArgs e)
		{
			try
			{
				int n = ds.Tables[0].Rows.Count;
				if (n == 0)
				{
					this.groupBox2.Visible = false;
					this.btnInfo.Visible = false;
					return;
				}
				int rowIndex = grid.CurrentRowIndex;
				if (grid[rowIndex, 0].ToString() == "SHUMA")
				{
					this.groupBox2.Visible = false;
					this.btnInfo.Visible = false;
					return;
				
				}
				if (rowIndex == 0)
				{
					if (grid[rowIndex, 0].ToString() == "SHUMA")
					{
						this.groupBox2.Visible = false;
						this.btnInfo.Visible = false;
						return;
				
					}
					this.groupBox2.Visible = true;
					this.btnInfo.Visible = true;
					PastroGr();
					InputController data = new InputController();
					rowIndex = grid.CurrentRowIndex;
					string dhoma = grid[rowIndex, 0].ToString();
					this.groupBox2.Text = "Klientet e pashlyer ne dhomen "+ dhoma;
					ds1 = data.KerkesaRead("KlientetEPashlyerPerDhomen", dhoma);
					VisionInfoSolutionLibrary.DataGrid gridKlienti = new VisionInfoSolutionLibrary.DataGrid();
					this.groupBox2.Controls.Add(gridKlienti);
					gridKlienti.Location = new Point(12, 20);
					gridKlienti.BackgroundColor = System.Drawing.Color.WhiteSmoke;
					int nr = ds1.Tables[1].Columns.Count;
					gridKlienti.Width = 209;
					if (nr == 2)
					{
						gridKlienti.Height = 93;
					}
					else
					{
						gridKlienti.Height = 110;
					}
				
					gridKlienti.DataSource = ds1.Tables[1];
					this.KrijoStilGrid(gridKlienti);
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

		private void btnInfo_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				bool ugjet = false;
				foreach(DataRow dr in ds1.Tables[0].Rows)
				{
					if (Convert.ToDateTime(dr[3]) < System.DateTime.Now)
					{
						ugjet = true;
						break;
					}
				}
				if (ugjet == false)
				{
					DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Dhoma te pashlyera",
						"Dhoma nuk ka detyrime te mbartura!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				DataSet info = new DataSet();
				info.Tables.Add();
				info.Tables[0].Columns.Add("DATA_FILLIMI",	typeof(string));
				info.Tables[0].Columns.Add("DATA_MBARIMI",	typeof(string));
				DateTime mindata;
				DateTime maxdata;
				DateTime datahyrje1, datadalje1;
				DataSet ds2 = new DataSet();
				ds2.Tables.Add();

				ds2.Tables[0].Columns.Add("EMRI", typeof(String));
				ds2.Tables[0].Columns.Add("MBIEMRI", typeof(String));
				ds2.Tables[0].Columns.Add("DATA_HYRJE", typeof(DateTime));
				ds2.Tables[0].Columns.Add("DATA_DALJE", typeof(DateTime));
				ds2.Tables[0].Columns.Add("KAPARI", typeof(Int32));
				ds2.AcceptChanges();
				DataRow ds2_row;
				foreach(DataRow dr in ds1.Tables[0].Rows)
				{
					if (Convert.ToDateTime(dr[3]) < System.DateTime.Now)
					{
						ds2_row = ds2.Tables[0].NewRow();
						for (int i = 0; i < 5; i++)
						{
							ds2_row[i] = dr[i];
						}
						ds2.Tables[0].Rows.Add(ds2_row);

					}
				}
				ds2.AcceptChanges();
				DateTime datahyrje = Convert.ToDateTime(ds2.Tables[0].Rows[0][2]);
				DateTime datadalje = Convert.ToDateTime(ds2.Tables[0].Rows[0][3]);
				mindata = Convert.ToDateTime(ds2.Tables[0].Rows[0][2]);
				maxdata = Convert.ToDateTime(ds2.Tables[0].Rows[0][3]);
				int index1 = 0;
				int index2 = 0;
				TimeSpan ts;
				int nr_ditesh;
				int nr = ds2.Tables[0].Rows.Count;
				DataRow r ;
				for(int i = 1; i < nr; i++)
				{
					datahyrje1 = Convert.ToDateTime(ds2.Tables[0].Rows[i][2]);
					datadalje1 = Convert.ToDateTime(ds2.Tables[0].Rows[i][3]);
					r = info.Tables[0].NewRow();
					if ((datahyrje1 < maxdata)&&(i == nr - 1))
					{
						if (datadalje1 > maxdata)
						{
							maxdata = datadalje1;
						}
						ts = maxdata.Subtract(Convert.ToDateTime(ds2.Tables[0].Rows[index1][2]));
						nr_ditesh = Convert.ToInt32(ts.TotalDays);
						r["DATA_FILLIMI"] = Convert.ToDateTime(ds2.Tables[0].Rows[index1][2]);
						r["DATA_MBARIMI"] = maxdata;
						info.Tables[0].Rows.Add(r);
						info.AcceptChanges();
						datahyrje = datahyrje1;
						datadalje = datadalje1;
						maxdata = Convert.ToDateTime(ds2.Tables[0].Rows[i][3]);
						index1 = i;
					}
					else if ((i == nr - 1)&&(datahyrje1 >= maxdata))
					{
						ts = Convert.ToDateTime(ds2.Tables[0].Rows[i - 1][3]).Subtract(Convert.ToDateTime(ds2.Tables[0].Rows[i - 1][2]));
						r["DATA_FILLIMI"] = Convert.ToDateTime(ds2.Tables[0].Rows[i - 1][2]);
						r["DATA_MBARIMI"] = Convert.ToDateTime(ds2.Tables[0].Rows[i - 1][3]);
						info.Tables[0].Rows.Add(r);
						info.AcceptChanges();
					
						ts = datadalje1.Subtract(datahyrje1);
						r = info.Tables[0].NewRow();
						r["DATA_FILLIMI"] = datahyrje1;
						r["DATA_MBARIMI"] = datadalje1;
						info.Tables[0].Rows.Add(r);
						info.AcceptChanges();
						
					}
					else if (i == nr - 1)
					{
						ts = datadalje1.Subtract(datahyrje1);
						r["DATA_FILLIMI"] = datahyrje1;
						r["DATA_MBARIMI"] = datadalje1;
						info.Tables[0].Rows.Add(r);
						info.AcceptChanges();
					}
					else if (datahyrje1 < maxdata)
					{
						index2 = i;
						if (datadalje1 > maxdata)
						{
							maxdata = datadalje1;
						}

						datahyrje = datahyrje1;
						datadalje = datadalje1;
					}
					else
					{
						ts = maxdata.Subtract(Convert.ToDateTime(ds2.Tables[0].Rows[index1][2]));
						r["DATA_FILLIMI"] = Convert.ToDateTime(ds2.Tables[0].Rows[index1][2]);
						r["DATA_MBARIMI"] = maxdata;
						info.Tables[0].Rows.Add(r);
						info.AcceptChanges();
						datahyrje = datahyrje1;
						datadalje = datadalje1;
						maxdata = Convert.ToDateTime(ds2.Tables[0].Rows[i][3]);
						index1 = i;
					}
				}
				if (nr == 1)
				{
					r = info.Tables[0].NewRow();
					datahyrje = Convert.ToDateTime(ds2.Tables[0].Rows[0][2]);
					datadalje = Convert.ToDateTime(ds2.Tables[0].Rows[0][3]);
					ts = datadalje.Subtract(datahyrje);
					r["DATA_FILLIMI"] = datahyrje;
					r["DATA_MBARIMI"] = datadalje;
					info.Tables[0].Rows.Add(r);
					info.AcceptChanges();
				}
				string koment = "Kujdes! Dhoma ka detyrime te mbartura" + System.Environment.NewLine + "per intervalet e datave si me poshte: ";
				int j = 0;
				foreach (DataRow dr in info.Tables[0].Rows)
				{
					j++;
					koment = koment + System.Environment.NewLine + j + "." + this.konverto(Convert.ToDateTime(dr[0]));
					koment = koment + "   " + this.konverto(Convert.ToDateTime(dr[1]));
				}
				koment = koment + System.Environment.NewLine + "Ne rast se doni te shlyeni dhomen kryeni dorezimet perkates!" ;
				koment = koment + System.Environment.NewLine + "Ky veprim duhet te shoqerohet me hedhje fizike ne arke! " ;
				koment = koment + System.Environment.NewLine + "Ne rast te kundert gjendja e arkes do te rezultoje me e madhe se gjendja reale! " ;
				System.Windows.Forms.MessageBox.Show(this, koment, "Informacion per dhomen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				//dataGrid1.DataSource = info.Tables[0];
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

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.AutoScrollPosition = new Point(0, 0);
			try
			{
				this.groupBox4.Controls.Clear();
				this.groupBox4.Visible = false;
				this.btnInfo1.Visible = false;
				if (this.tabControl1.SelectedIndex == 0)
				{
					this.DhomaPashlyera_Load(sender, e);
				}
				else
				{
					InputController data = new InputController();
					this.dsGrupi = data.KerkesaRead("ShfaqDhomatEPashlyeraGrupi");
					if (this.dsGrupi.Tables[0].Rows.Count != 1)
					{
						this.ReadyToPrint = true;
						this.grid1.DataSource = this.dsGrupi.Tables[0];
						this.KrijoStilGrid1();
					}
					else
					{
						this.ReadyToPrint = false;
						this.grid1.DataSource = this.dsGrupi.Tables[0];
						this.KrijoStilGrid1();
					}
				}
				this.clicked = true;
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

		private void grid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			try
			{
				int n = this.dsGrupi.Tables[0].Rows.Count;
				if (n == 0)
				{
					this.groupBox4.Visible = false;
					this.btnInfo1.Visible = false;
					return;
				}
				this.groupBox4.Visible = true;
				this.btnInfo1.Visible = true;
				PastroGr1();
				InputController data = new InputController();
				int rowIndex = grid1.CurrentRowIndex;
				if (grid1[rowIndex, 1].ToString() == "SHUMA")
				{
					this.groupBox4.Visible = false;
					this.btnInfo1.Visible = false;
					return;
				}
				string grupi = grid1[rowIndex, 1].ToString();
				this.groupBox4.Text = "Klientet e pashlyer per grupin "+ grupi;
				int idHyrja = Convert.ToInt32(grid1[rowIndex, 0]);
				DataSet dsHyrja = this.GjejDataSetPerHyrjen(idHyrja);
				VisionInfoSolutionLibrary.DataGrid gridGrupi = new VisionInfoSolutionLibrary.DataGrid();
				this.groupBox4.Controls.Add(gridGrupi);
				gridGrupi.Location = new Point(12, 20);
				gridGrupi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
				int nr = dsHyrja.Tables[0].Columns.Count;
				gridGrupi.Width = 209;
				if (nr == 2)
				{
					gridGrupi.Height = 108;
				}
				else
				{
					gridGrupi.Height = 125;
				}
				gridGrupi.DataSource = dsHyrja.Tables[0];
				this.KrijoStilGrid1(gridGrupi, dsHyrja);
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

		private void grid1_Click(object sender, System.EventArgs e)
		{
			try
			{
				int n = this.dsGrupi.Tables[0].Rows.Count;
				if (n == 0)
				{
					this.groupBox4.Visible = false;
					this.btnInfo1.Visible = false;
					return;
				}
				int rowIndex = grid1.CurrentRowIndex;
				if (grid1[rowIndex, 1].ToString() == "SHUMA")
				{
					this.groupBox4.Visible = false;
					this.btnInfo1.Visible = false;
					return;
				}
				if (rowIndex == 0)
				{
					if (grid1[rowIndex, 1].ToString() == "SHUMA")
					{
						this.groupBox4.Visible = false;
						this.btnInfo1.Visible = false;
						return;
					}
					this.groupBox4.Visible = true;
					this.btnInfo1.Visible = true;
					PastroGr();
					InputController data = new InputController();
					rowIndex = grid1.CurrentRowIndex;
					string grupi = grid1[rowIndex, 1].ToString();
					this.groupBox4.Text = "Klientet e pashlyer per grupin "+ grupi;
					int idHyrja = Convert.ToInt32(grid1[rowIndex, 0]);
					DataSet dsHyrja = this.GjejDataSetPerHyrjen(idHyrja);
					VisionInfoSolutionLibrary.DataGrid gridGrupi = new VisionInfoSolutionLibrary.DataGrid();
					this.groupBox4.Controls.Add(gridGrupi);
					gridGrupi.Location = new Point(12, 20);
					gridGrupi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
					int nr = dsHyrja.Tables[0].Columns.Count;
					gridGrupi.Width = 209;
					if (nr == 2)
					{
						gridGrupi.Height = 108;
					}
					else
					{
						gridGrupi.Height = 125;
					}
				
					gridGrupi.DataSource = dsHyrja.Tables[0];
					this.KrijoStilGrid1(gridGrupi, dsHyrja);
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
		
		#endregion

		#region Private Methods
		private void KrijoStilGrid()
		{
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			this.grid.ReadOnly = true;
			this.grid.TableStyles.Clear();

			DataGridTekstBoxColumn colDhoma = new DataGridTekstBoxColumn();
			colDhoma.HeaderText = "Dhoma";
			colDhoma.MappingName = "DHOMA";
			colDhoma.Width = 80;

			
			DataGridTekstBoxColumn colKapari = new DataGridTekstBoxColumn();
			colKapari.HeaderText = "Kapari";
			colKapari.MappingName = "KAPARI_STR";
			colKapari.Width = 100;
			colKapari.NullText = "";

			DataGridTekstBoxColumn colPagesaTotale = new DataGridTekstBoxColumn();
			colPagesaTotale.HeaderText = "Pagesa";
			colPagesaTotale.MappingName = "PAGESA";
			colPagesaTotale.Width = 95;
			colPagesaTotale.NullText = "";

			DataGridTekstBoxColumn colDiferenca = new DataGridTekstBoxColumn();
			colDiferenca.HeaderText = "Diferenca";
			colDiferenca.MappingName = "DIFERENCA";
			colDiferenca.Width = 110;
			colDiferenca.NullText = "";

			DataGridTekstBoxColumn colKoment = new DataGridTekstBoxColumn();
			colKoment.HeaderText = "Koment";
			colKoment.MappingName = "KOMENT";
			colKoment.Width = 150;
			colKoment.NullText = "";

			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{colDhoma, colKoment, colPagesaTotale,  colKapari,colDiferenca});
			grid.TableStyles.Add(style);
			grid.FlatMode = false;
			grid.Expand(-1);
		}

		private void KrijoStilGrid1()
		{
			this.grid1.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			this.grid1.ReadOnly = true;

			DataGridTekstBoxColumn colIdHyrja = new DataGridTekstBoxColumn();
			colIdHyrja.HeaderText = "Id Hyrja";
			colIdHyrja.MappingName = "ID_HYRJA";
			colIdHyrja.Width = 0;
			
			DataGridTekstBoxColumn colGrupi = new DataGridTekstBoxColumn();
			colGrupi.HeaderText = "Grupi";
			colGrupi.MappingName = "GRUPI";
			colGrupi.Width = 100;
			colGrupi.NullText = "";

			DataGridTekstBoxColumn colAgjensia = new DataGridTekstBoxColumn();
			colAgjensia.HeaderText = "Agjensia";
			colAgjensia.MappingName = "AGJENSIA";
			colAgjensia.Width = 90;
			colAgjensia.NullText = "";

			DataGridTekstBoxColumn colDhoma = new DataGridTekstBoxColumn();
			colDhoma.HeaderText = "Dhomat";
			colDhoma.MappingName = "DHOMA_EMRI";
			colDhoma.Width = 90;
			colDhoma.NullText = "";

			DataGridTekstBoxColumn colPagesa = new DataGridTekstBoxColumn();
			colPagesa.HeaderText = "Pagesa";
			colPagesa.MappingName = "PAGESA";
			colPagesa.Width = 85;
			colPagesa.NullText = "";

			DataGridTekstBoxColumn colKapari = new DataGridTekstBoxColumn();
			colKapari.HeaderText = "Kapari";
			colKapari.MappingName = "KAPARI";
			colKapari.Width = 70;
			colKapari.NullText = "";

			DataGridTekstBoxColumn colDiferenca = new DataGridTekstBoxColumn();
			colDiferenca.HeaderText = "Diferenca";
			colDiferenca.MappingName = "DIFERENCA";
			colDiferenca.Width = 90;
			colDiferenca.NullText = "";

			DataGridTekstBoxColumn colKoment = new DataGridTekstBoxColumn();
			colKoment.HeaderText = "Koment";
			colKoment.MappingName = "KOMENT";
			colKoment.Width = 100;
			colKoment.NullText = "";

			DataGridTekstBoxColumn colMindata = new DataGridTekstBoxColumn();
			colMindata.HeaderText = "Mindata";
			colMindata.MappingName = "MINDATA";
			colMindata.Width = 0;
			colMindata.NullText = "";

			DataGridTekstBoxColumn colMaxdata = new DataGridTekstBoxColumn();
			colMaxdata.HeaderText = "Maxdata";
			colMaxdata.MappingName = "MAXDATA";
			colMaxdata.Width = 0;
			colMaxdata.NullText = "";

			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{colIdHyrja,colGrupi,colAgjensia,colDhoma,
			 colKoment,colPagesa,colKapari,colDiferenca, colMindata, colMaxdata});
			grid1.TableStyles.Add(style);
			grid1.FlatMode = false;
			grid1.Expand(-1);
		}

		private void KrijoStilGrid(VisionInfoSolutionLibrary.DataGrid gridKlienti)
		{
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table2";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			gridKlienti.ReadOnly = true;

			DataGridTextBoxColumn colKriteri = new DataGridTextBoxColumn();
			colKriteri.HeaderText = "";
			colKriteri.MappingName = "KRITERI";
			colKriteri.Width = 75;
			colKriteri.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			colKriteri.NullText = "";
			style.GridColumnStyles.Add(colKriteri);

			int nr = ds1.Tables[1].Columns.Count;
			nr--;
			for (int i = 1; i <=nr; i++)
			{
				string s = "KLIENTI"+ i;
				DataGridTextBoxColumn colKlienti = new DataGridTextBoxColumn();
				colKlienti.HeaderText = "";
				colKlienti.MappingName = s;
				colKlienti.Width = 130;
				colKlienti.NullText = "";
				style.GridColumnStyles.Add(colKlienti);
			}
	   
			gridKlienti.TableStyles.Add(style);
			gridKlienti.FlatMode = false;
			gridKlienti.Expand(-1);
		}

		private void KrijoStilGrid1(VisionInfoSolutionLibrary.DataGrid gridGrupi, DataSet dsHyrja)
		{
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			gridGrupi.ReadOnly = true;

			DataGridTextBoxColumn colKriteri = new DataGridTextBoxColumn();
			colKriteri.HeaderText = "";
			colKriteri.MappingName = "KRITERI";
			colKriteri.Width = 75;
			colKriteri.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			colKriteri.NullText = "";
			style.GridColumnStyles.Add(colKriteri);

			int nr = dsHyrja.Tables[0].Columns.Count;
			nr--;
			for (int i = 1; i <=nr; i++)
			{
				string s = "KLIENTI"+ i;
				DataGridTextBoxColumn colKlienti = new DataGridTextBoxColumn();
				colKlienti.HeaderText = "";
				colKlienti.MappingName = s;
				colKlienti.Width = 130;
				colKlienti.NullText = "";
				style.GridColumnStyles.Add(colKlienti);
			}
	   
			gridGrupi.TableStyles.Add(style);
			gridGrupi.FlatMode = false;
			gridGrupi.Expand(-1);
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

		private void PastroGr()
		{
			groupBox2.Controls.Clear();
		}
		private void PastroGr1()
		{
			groupBox4.Controls.Clear();
		}
		private DataSet GjejDataSetPerHyrjen(int idHyrja)
		{
			DataSet dsHyrja = new DataSet();
			dsHyrja.Tables.Add();
			dsHyrja.Tables[0].Columns.Add("KRITERI", typeof(String));
			DataRow newR = dsHyrja.Tables[0].NewRow();
			newR["KRITERI"] = "Dhoma";
			dsHyrja.Tables[0].Rows.Add(newR);

			newR = dsHyrja.Tables[0].NewRow();
			newR["KRITERI"] = "Emri";
			dsHyrja.Tables[0].Rows.Add(newR);

			newR = dsHyrja.Tables[0].NewRow();
			newR["KRITERI"] = "Mbiemri";
			dsHyrja.Tables[0].Rows.Add(newR);

			newR = dsHyrja.Tables[0].NewRow();
			newR["KRITERI"] = "Data hyrje";
			dsHyrja.Tables[0].Rows.Add(newR);
			
			newR = dsHyrja.Tables[0].NewRow();
			newR["KRITERI"] = "Data dalje";
			dsHyrja.Tables[0].Rows.Add(newR);

			int i = 1;
			foreach(DataRow dr in this.dsGrupi.Tables[1].Rows)
			{
				if (idHyrja == Convert.ToInt32(dr["ID_HYRJA"]))
				{
					string emriKolona = "KLIENTI" + i;
					dsHyrja.Tables[0].Columns.Add(emriKolona, typeof(String));
					dsHyrja.Tables[0].Rows[0][i] = dr["DHOMA_EMRI"].ToString();
					dsHyrja.Tables[0].Rows[1][i] = dr["EMRI"].ToString();
					dsHyrja.Tables[0].Rows[2][i] = dr["MBIEMRI"].ToString();
					dsHyrja.Tables[0].Rows[3][i] = dr["DATA_HYRJE_STR"].ToString();
					dsHyrja.Tables[0].Rows[4][i] = dr["DATA_DALJE_STR"].ToString();
					i++;
				}
			}
			dsHyrja.AcceptChanges();
			return dsHyrja;
		}
		#endregion

		#region IPrintable Members

		public void PrintPreview()
		{
			Printim print = new Printim();
			if (ds != null)
				print.NgarkoRaport("ShfaqDhomatEPashlyera");
			print.ShowDialog();
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
			Printim print = new Printim();
			print.Printo("ShfaqDhomatEPashlyera");
		}

		private void btnInfo1_Click(object sender, System.EventArgs e)
		{
			int index = this.grid1.CurrentRowIndex;
			DateTime dataMin = Convert.ToDateTime(this.grid1[index, 8]);
			DateTime dataMax = Convert.ToDateTime(this.grid1[index, 9]);
			string s = "";
			if (DateTime.Now >= dataMax)
			{
				s = "Per kete hyrje grupi ka detyrime te mbartura ndaj hotelit per datat:";
				s += Environment.NewLine + this.konverto(dataMin) + " dhe " + this.konverto(dataMax);
				s += Environment.NewLine + "Beni dorezimet perkatese!";
				s += Environment.NewLine + "Kujdes! Dorezimet duhet te shoqerohen me hedhje fizike ne arke,";
				s += Environment.NewLine + "perndryshe gjendja ne arke do te rezultoje me e madhe se gjendja reale e saj.";
				System.Windows.Forms.MessageBox.Show(this, s, "Informacion per grupin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				s = "Kjo hyrje nuk perben detyrim te mbartur per grupin ndaj hotelit!";
				System.Windows.Forms.MessageBox.Show(this, s, "Informacion per grupin", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void tabPage1_Click(object sender, System.EventArgs e)
		{
		
		}

		public event VisionInfoSolutionLibrary.ReadyChangedEventHandler ReadyToPrintChanged;
		#endregion	
	}
}


