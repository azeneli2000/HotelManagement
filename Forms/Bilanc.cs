using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using VisionInfoSolutionLibrary;
using HotelManagment.Forms;
using Janus.Windows.GridEX;

namespace HotelManagment.Forms
{
	public class Bilanc : VisionInfoSolutionLibrary.Form, IPrintable
	{
		#region Private Fields
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.Label lblNga;
		private VisionInfoSolutionLibrary.Label lblDeri;
		private VisionInfoSolutionLibrary.DataGrid grid1;
		private VisionInfoSolutionLibrary.Label lblgrid1;
		private VisionInfoSolutionLibrary.Label lblgrid2;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.Button btnKerko;
		private VisionInfoSolutionLibrary.DateTimePicker dtpFillimi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpMbarimi;
		private Janus.Windows.GridEX.GridEX gridEX2;

		/// <summary>
		/// variabel privat boolean qe percakton nese printimi eshte i mundur per bilancin ditor
		/// </summary>	
		private bool printBilancDitor = false;
		/// <summary>
		/// variabel privat boolean qe percakton nese printimi eshte i mundur per bilancin sipas datave
		/// </summary>
		private bool printBilancData = false;
		private bool readyToPrint = true;
		private int numer_rreshtash;
		private string dateDitor = "";
		private System.Data.DataSet ds1;
		private System.Data.DataSet dsDetyrime;
		private System.Data.DataSet ds;
		private System.Data.DataSet dsBilanciDitor;

		#endregion

		#region Constructors & Destructors
		public Bilanc()
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
			this.dtpMbarimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpFillimi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.lblDeri = new VisionInfoSolutionLibrary.Label();
			this.lblNga = new VisionInfoSolutionLibrary.Label();
			this.btnKerko = new VisionInfoSolutionLibrary.Button(this.components);
			this.grid1 = new VisionInfoSolutionLibrary.DataGrid();
			this.ds = new System.Data.DataSet();
			this.ds1 = new System.Data.DataSet();
			this.lblgrid1 = new VisionInfoSolutionLibrary.Label();
			this.lblgrid2 = new VisionInfoSolutionLibrary.Label();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.dsDetyrime = new System.Data.DataSet();
			this.dsBilanciDitor = new System.Data.DataSet();
			this.gridEX2 = new Janus.Windows.GridEX.GridEX();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsDetyrime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsBilanciDitor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEX2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1016, 24);
			this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dtpMbarimi);
			this.groupBox1.Controls.Add(this.dtpFillimi);
			this.groupBox1.Controls.Add(this.lblDeri);
			this.groupBox1.Controls.Add(this.lblNga);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(10, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 76);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.Text = "Kerko bilanc per datat";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// dtpMbarimi
			// 
			this.dtpMbarimi.CustomFormat = "dd.MM.yyyy";
			this.dtpMbarimi.DefaultErrorMessage = "";
			this.dtpMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMbarimi.IsValid = true;
			this.dtpMbarimi.Location = new System.Drawing.Point(92, 44);
			this.dtpMbarimi.Name = "dtpMbarimi";
			this.dtpMbarimi.Required = false;
			this.dtpMbarimi.ShowCheckBox = true;
			this.dtpMbarimi.ShowUpDown = true;
			this.dtpMbarimi.Size = new System.Drawing.Size(148, 20);
			this.dtpMbarimi.TabIndex = 4;
			this.dtpMbarimi.Value = new System.DateTime(2005, 10, 25, 16, 9, 0, 0);
			// 
			// dtpFillimi
			// 
			this.dtpFillimi.CustomFormat = "dd.MM.yyyy";
			this.dtpFillimi.DefaultErrorMessage = "";
			this.dtpFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFillimi.IsValid = true;
			this.dtpFillimi.Location = new System.Drawing.Point(92, 16);
			this.dtpFillimi.Name = "dtpFillimi";
			this.dtpFillimi.Required = false;
			this.dtpFillimi.ShowCheckBox = true;
			this.dtpFillimi.ShowUpDown = true;
			this.dtpFillimi.Size = new System.Drawing.Size(148, 20);
			this.dtpFillimi.TabIndex = 3;
			this.dtpFillimi.Value = new System.DateTime(2005, 10, 25, 16, 7, 0, 0);
			// 
			// lblDeri
			// 
			this.lblDeri.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lblDeri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblDeri.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.lblDeri.Location = new System.Drawing.Point(12, 44);
			this.lblDeri.Name = "lblDeri";
			this.lblDeri.Size = new System.Drawing.Size(72, 20);
			this.lblDeri.TabIndex = 2;
			this.lblDeri.Text = "Date mbarimi";
			this.lblDeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblNga
			// 
			this.lblNga.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lblNga.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblNga.Location = new System.Drawing.Point(28, 16);
			this.lblNga.Name = "lblNga";
			this.lblNga.Size = new System.Drawing.Size(56, 20);
			this.lblNga.TabIndex = 1;
			this.lblNga.Text = "Date fillimi";
			this.lblNga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnKerko
			// 
			this.btnKerko.BackColor = System.Drawing.Color.Blue;
			this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko.DoValidation = true;
			this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko.Location = new System.Drawing.Point(284, 68);
			this.btnKerko.Name = "btnKerko";
			this.btnKerko.Size = new System.Drawing.Size(90, 21);
			this.btnKerko.TabIndex = 5;
			this.btnKerko.Text = "Kerko";
			this.toolTips.SetToolTip(this.btnKerko, "Shfaq bilancin midis dy datave te zgjedhura.");
			this.btnKerko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
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
			this.grid1.Location = new System.Drawing.Point(12, 40);
			this.grid1.Name = "grid1";
			this.grid1.ParentRowsBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.grid1.RowHeadersVisible = false;
			this.grid1.RowHeaderWidth = 36;
			this.grid1.Selekto = true;
			this.grid1.Size = new System.Drawing.Size(228, 260);
			this.grid1.TabIndex = 6;
			this.toolTips.SetToolTip(this.grid1, "Bilanci per intervalin midis dy datave.");
			this.grid1.CurrentCellChanged += new System.EventHandler(this.grid1_CurrentCellChanged);
			// 
			// ds
			// 
			this.ds.DataSetName = "NewDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// ds1
			// 
			this.ds1.DataSetName = "NewDataSet";
			this.ds1.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// lblgrid1
			// 
			this.lblgrid1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lblgrid1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblgrid1.Location = new System.Drawing.Point(12, 12);
			this.lblgrid1.Name = "lblgrid1";
			this.lblgrid1.Size = new System.Drawing.Size(232, 28);
			this.lblgrid1.TabIndex = 4;
			this.lblgrid1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lblgrid2
			// 
			this.lblgrid2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lblgrid2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblgrid2.Location = new System.Drawing.Point(280, 12);
			this.lblgrid2.Name = "lblgrid2";
			this.lblgrid2.Size = new System.Drawing.Size(292, 28);
			this.lblgrid2.TabIndex = 11;
			this.lblgrid2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.lblgrid2);
			this.groupBox2.Controls.Add(this.grid1);
			this.groupBox2.Controls.Add(this.lblgrid1);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 124);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(986, 316);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// dsDetyrime
			// 
			this.dsDetyrime.DataSetName = "NewDataSet";
			this.dsDetyrime.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// dsBilanciDitor
			// 
			this.dsBilanciDitor.DataSetName = "NewDataSet";
			this.dsBilanciDitor.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// gridEX2
			// 
			this.gridEX2.AlternatingColors = true;
			this.gridEX2.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.Bisque;
			this.gridEX2.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX2.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridEX2.GroupByBoxVisible = false;
			this.gridEX2.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
			this.gridEX2.GroupRowFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.RaisedLight;
			this.gridEX2.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
			this.gridEX2.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gridEX2.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.InactiveCaptionText;
			this.gridEX2.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEX2.LayoutData = "<GridEXLayoutData><RootTable><AllowEdit>False</AllowEdit><Columns Collection=\"tru" +
				"e\"><Column0 ID=\"Emri\"><Caption>Emri</Caption><DataMember>Emri</DataMember><Key>E" +
				"mri</Key><Position>0</Position><Width>130</Width><HeaderStyle><BackColor>Inactiv" +
				"eCaptionText</BackColor><BackColorAlphaMode>UseAlpha</BackColorAlphaMode><BlendG" +
				"radient>0</BlendGradient><BackColorGradient>InactiveCaptionText</BackColorGradie" +
				"nt><BackgroundGradientMode>Diagonal</BackgroundGradientMode></HeaderStyle></Colu" +
				"mn0><Column1 ID=\"Koment\"><Caption>Koment</Caption><DataMember>Koment</DataMember" +
				"><Key>Koment</Key><Position>1</Position><Width>189</Width><HeaderStyle><BackColo" +
				"r>InactiveCaptionText</BackColor><BackColorGradient>InactiveCaptionText</BackCol" +
				"orGradient></HeaderStyle></Column1><Column2 ID=\"Vlera\"><Caption>Vlera e hedhur</" +
				"Caption><DataMember>Vlera</DataMember><Key>Vlera</Key><Position>2</Position><Wid" +
				"th>82</Width></Column2><Column3 ID=\"Komisioni\"><Caption>Komisioni</Caption><Data" +
				"Member>Komisioni</DataMember><Key>Komisioni</Key><Position>3</Position><Width>57" +
				"</Width></Column3><Column4 ID=\"Totali\"><AggregateFunction>Sum</AggregateFunction" +
				"><Caption>Totali</Caption><DataMember>Totali</DataMember><DefaultGroupFormatStri" +
				"ng /><Key>Totali</Key><Position>4</Position><Width>119</Width><TotalFormatString" +
				">SHUMA = {0.00}</TotalFormatString><HeaderStyle><BackColor>InactiveCaptionText</" +
				"BackColor><BackColorGradient>InactiveCaptionText</BackColorGradient></HeaderStyl" +
				"e></Column4><Column5 ID=\"Perdoruesi\"><Caption>Perdoruesi</Caption><DataMember>Pe" +
				"rdoruesi</DataMember><Key>Perdoruesi</Key><Position>5</Position></Column5><Colum" +
				"n6 ID=\"Larguar\"><Caption>Larguar</Caption><DataMember>LARGUAR</DataMember><Key>L" +
				"arguar</Key><Position>6</Position><Visible>False</Visible><Width>8</Width></Colu" +
				"mn6></Columns><GroupCondition ID=\"\" /><Key>Bilanci ditor</Key><SortKeys Collecti" +
				"on=\"true\"><SortKey0 ID=\"SortKey0\"><ColIndex>4</ColIndex></SortKey0></SortKeys><H" +
				"eaderFormatStyle><Appearance>Flat</Appearance><BackColor>InactiveCaptionText</Ba" +
				"ckColor></HeaderFormatStyle><GroupRowFormatStyle><BackColor>White</BackColor><Ba" +
				"ckColorGradient>White</BackColorGradient></GroupRowFormatStyle><TotalRowFormatSt" +
				"yle><BackColor>InactiveCaptionText</BackColor><BackColorGradient>InactiveCaption" +
				"Text</BackColorGradient></TotalRowFormatStyle></RootTable></GridEXLayoutData>";
			this.gridEX2.Location = new System.Drawing.Point(288, 164);
			this.gridEX2.Name = "gridEX2";
			this.gridEX2.Size = new System.Drawing.Size(696, 260);
			this.gridEX2.TabIndex = 7;
			this.gridEX2.TableHeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.RaisedLight;
			this.gridEX2.TableHeaderFormatStyle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gridEX2.ThemedAreas = Janus.Windows.GridEX.ThemedArea.ScrollBars;
			this.toolTips.SetToolTip(this.gridEX2, "Bilanci i detajuar per diten e zgjedhur.");
			this.gridEX2.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridEX2.TreeLineColor = System.Drawing.SystemColors.Desktop;
			// 
			// Bilanc
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1016, 704);
			this.Controls.Add(this.gridEX2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnKerko);
			this.HelpFile = "BILANC DITOR.htm";
			this.Name = "Bilanc";
			this.Text = "Bilanc";
			this.TitullGjeresi = 1016;
			this.Load += new System.EventHandler(this.Bilanc_Load);
			this.Controls.SetChildIndex(this.btnKerko, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.gridEX2, 0);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsDetyrime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsBilanciDitor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEX2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void grid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				dsDetyrime  = new DataSet();
				InputController data = new InputController();
				DateTime dataKerkimi;
				int rowIndex = grid1.CurrentRowIndex;
				if (grid1[ rowIndex, 0].ToString() != "Bilanci")
				{
					dataKerkimi = Convert.ToDateTime(grid1[ rowIndex, 3]);
					this.dsBilanciDitor = data.KerkesaRead("ShfaqBilanciPerDatenEdheneDetaje", dataKerkimi.Date);
					this.gridEX2.DataSource = this.dsBilanciDitor.Tables[0];
					this.lblgrid2.Text = "Veprimet e kryer ne daten " + konverto(dataKerkimi.Date);
					ds1 = data.KerkesaRead("ShfaqBilanciPerDatenEdhene", dataKerkimi);
					//dsDetyrime = data.KerkesaRead("ShfaqBilanciPerDatenEdheneJanusGrid", dataKerkimi);
					ds1.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\ShfaqBilanciPerDatenEdhene.xml", XmlWriteMode.WriteSchema);
					this.printBilancDitor = true;
					if (ds1.Tables[0].Rows.Count < 1)
					{
						this.dateDitor = "";
					}
					else if (ds1.Tables[0].Rows.Count < 2 && (ds1.Tables[0].Rows[0][1].ToString() == "" && Convert.ToInt32(ds1.Tables[0].Rows[0][0]) == 0))
						this.dateDitor = "";
					else
						this.dateDitor = dataKerkimi.ToShortDateString();
					//kryhet mbushja e grides2 e cila paraqet veprimet qe jane kryer
					//ne daten e klikuar
					int nr2 = ds1.Tables[0].Rows.Count;
				}
			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch (Exception ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Bilanc_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				//pastrim variablash private
				this.ds.Tables.Clear();
				this.ds1.Tables.Clear();
				this.dsBilanciDitor.Tables.Clear();
				this.dsDetyrime.Tables.Clear();
				printBilancData = false;
				readyToPrint = true;
				numer_rreshtash = 0;
				dateDitor = "";
				this.grid1.TableStyles.Clear();
				this.gridEX2.DataSource = null;
				this.gridEX2.RootTable.Groups.Clear();
				//pastrim variablash private			
				this.dtpFillimi.Value = System.DateTime.Now;
				this.dtpMbarimi.Value = System.DateTime.Today;
				this.lblgrid1.Text = "Bilanci per daten " + konverto(System.DateTime.Today.Date);
				this.lblgrid2.Text = "Veprimet e kryer ne daten " + konverto(System.DateTime.Today.Date);
				DateTime dataFillimi = Convert.ToDateTime(dtpFillimi.Value);
				DateTime dataMbarimi = Convert.ToDateTime(dtpMbarimi.Value);
				InputController data = new InputController();
				this.AddConditionalFormatting();
				this.gridEX2.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridEX2.RootTable.Columns["Emri"]));
				this.gridEX2.RootTable.Groups[0].Expand();

				ds = data.KerkesaRead("ShfaqBilanci", dataFillimi, dataMbarimi);
				ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\ShfaqBilanci.xml", XmlWriteMode.WriteSchema);
				//ds1 = data.KerkesaRead("ShfaqBilanciPerDatenEdhene", dataFillimi);
				numer_rreshtash = ds.Tables[0].Rows.Count;
				grid1.DataSource = ds.Tables[0];
				KrijoStilGrid1();
				if (ds.Tables[0].Rows.Count < 1)
				{
					this.dateDitor = "";
				}
				else if (ds.Tables[0].Rows.Count < 2 && (ds.Tables[0].Rows[0][1].ToString() == "" && Convert.ToInt32(ds.Tables[0].Rows[0][0]) == 0))
					this.dateDitor = "";
				else
					this.dateDitor = dataFillimi.ToShortDateString();
				grid1.Height = 262;
				numer_rreshtash = ds.Tables[0].Rows.Count;
				if (numer_rreshtash > 14)
				{
					grid1.Width = 252;						
				}
				else
				{
					grid1.Width = 238;
				}
				int nr2 = ds.Tables[0].Rows.Count;

			}
			catch(SqlException ex)
			{
				VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
				return;
			}
			catch (Exception ex)
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
			this.Cursor = Cursors.WaitCursor;
			try
			{
				InputController data = new InputController();
				DateTime dataFillimi = Convert.ToDateTime( this.dtpFillimi.Value);
				DateTime dataMbarimi = Convert.ToDateTime( this.dtpMbarimi.Value);
				int a = this.KntData(dataFillimi, dataMbarimi);
				if (a != 0)
				{
					error.SetError(this.dtpFillimi, "Data e fillimit nuk mund te jete me e madhe se data e mbarimit");
					this.dtpFillimi.IsValid = false;
					return;
				}
				else
				{
					error.SetError(this.dtpFillimi, "");
					this.dtpFillimi.IsValid = true;
					this.printBilancData = true;
					this.lblgrid1.Text = "Bilanci nga data " + konverto(dataFillimi.Date) + Environment.NewLine  + "deri ne daten " + konverto(dataMbarimi.Date);
					ds = data.KerkesaRead("ShfaqBilanci", dataFillimi, dataMbarimi);
					ds.WriteXml("C:\\Program Files\\VisionInfoSolution\\HotelManagment" + "\\ShfaqBilanci.xml", XmlWriteMode.WriteSchema);
					grid1.DataSource = ds.Tables[0];
					numer_rreshtash = ds.Tables[0].Rows.Count;
					grid1.Height = 262;
					if (numer_rreshtash > 14)
					{
						grid1.Width = 254;
						
					}
					else
					{
						grid1.Width = 238;
					}
					this.gridEX2.DataSource = null;
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
			finally
			{
				this.Cursor = Cursors.Default;
			}
		
		}

		private void dtpFillimi_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		#endregion

		#region Private Methods

		private void KrijoStilGrid1()
		{
			this.grid1.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.Bisque;
			style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			style.RowHeadersVisible = false;
			this.grid1.ReadOnly = true;

			DataGridTextBoxColumn colNr = new DataGridTextBoxColumn();
			colNr.HeaderText = "Nr.";
			colNr.MappingName = "NR";
			colNr.Width = 50;

			DataGridTextBoxColumn colData = new DataGridTextBoxColumn();
			colData.HeaderText = "Data";
			colData.MappingName = "DATA_STR";
			colData.Width = 90;
			colData.NullText = "";

			DataGridTextBoxColumn colBilanci = new DataGridTextBoxColumn();
			colBilanci.HeaderText = "Bilanci ditor";
			colBilanci.MappingName = "SASIA";
			colBilanci.Width = 93;

			DataGridTextBoxColumn colD = new DataGridTextBoxColumn();
			colD.HeaderText = "Data";
			colD.MappingName = "DATA";
			colD.Width = 0;
			colD.NullText = "";

			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{colNr, colData, colBilanci, colD});
			grid1.TableStyles.Add(style);
			grid1.FlatMode = false;
			grid1.Expand(-1);
		}

		/// <summary>
		/// Ben kontroll te nje date fillimi dhe nje mbarimi.
		/// </summary>
		/// <param name="dtFillimi">data e fillimit qe do te kontrollohet me ate te mbarimit</param>
		/// <param name="dtMbarimi">data e mbarimit qe do te kontrollohet me ate te fillimit</param>
		/// <returns>1 nese data e fillimi eshte me e madhe; perndryshe 0</returns>
		private int KntData(DateTime dtFillimi,DateTime dtMbarimi )
		{
			int a = 0;
			System.TimeSpan nrDite = dtFillimi.Date.Subtract(dtMbarimi.Date);
			int difDite = Convert.ToInt32(nrDite.Days);
			int difOre = Convert.ToInt32(nrDite.Hours);
			if (difDite > 0)
				a = 1;	
			else
				a = 0;
			return a;	
				
		}

		private string konverto(DateTime data)
		{
			string data_str = data.ToString();
			string dita, muaji, viti;
			dita = data_str.Substring(8, 2);
			muaji = data_str.Substring(5, 2);
			viti = data_str.Substring(0, 4);
			data_str = dita + "-" + muaji + "-" + viti;
			return data_str;
		}


		private void FormatGrid()
		{
			//			try
			//			{
			//				this.dgBilanc2.Tables.Clear();
			//				this.dgBilanc2.DataSource = this.dsDetyrime;
			//				this.dgBilanc2.SetDataBinding(this.dsDetyrime, "Table1");
			//				this.dgBilanc2.RootTable.DataMember = "Table1";
			//
			//				Janus.Windows.GridEX.GridEXColumn colBilanci = new Janus.Windows.GridEX.GridEXColumn();
			//				colBilanci.DataMember = "RELATION";
			//				colBilanci.Caption = "Bilanci";
			//				colBilanci.Width = 200;
			//				this.dgBilanc2.RootTable.Columns.Add(colBilanci);
			//
			//				Janus.Windows.GridEX.GridEXColumn colDhoma = new Janus.Windows.GridEX.GridEXColumn();
			//				colDhoma.DataMember = "DHOMA_EMRI";
			//				colDhoma.Caption = "Lloji i detyrimit";
			//				colDhoma.Width = 100;
			//				this.dgBilanc2.RootTable.Columns.Add(colDhoma);
			//				this.dgBilanc2.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.dgBilanc2.RootTable.Columns[0]));
			//
			////				Janus.Windows.GridEX.GridEXTable detaje = new Janus.Windows.GridEX.GridEXTable();
			////				
			////				detaje.DataMember = "Table1";
			////				
			////				this.dgBilanc2.RootTable.ChildTables.Add(detaje);
			////				Janus.Windows.GridEX.GridEXColumn colNr = new Janus.Windows.GridEX.GridEXColumn();
			////				this.dgBilanc2.Tables[1].DataMember = "Table1";
			////				colNr.DataMember = "NR";
			////				colNr.Caption = "Nr";
			////				colNr.Width = 50;
			////				detaje.Columns.Add(colNr);
			//			}
			//			catch(Exception ex)
			//			{
			//				return;
			//			}
		}

		private void AddConditionalFormatting()
		{
			//using Janus.Windows.GridEX is set

			//Adding a condition using Discontinued field
			GridEXFormatCondition fc = new GridEXFormatCondition(
				this.gridEX2.RootTable.Columns["Larguar"],
				ConditionOperator.Equal,true);

//			//setting Format style properties to be applied to all the rows
//			//that met this condition
//			fc.FormatStyle.FontStrikeout=TriState.True;
//			fc.FormatStyle.ForeColor=SystemColors.GrayText;
//			this.gridEX1.RootTable.FormatConditions.Add(fc);
//
//
//			//adding a format condition to use font bold when OnSale field is true
//			fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridEX1.RootTable.Columns["OnSale"],
//				ConditionOperator.Equal,true);
			fc.FormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			fc.FormatStyle.ForeColor = Color.Chocolate;
			this.gridEX2.RootTable.FormatConditions.Add(fc);

		}
		#endregion

		#region IPrintable Members

		public void PrintPreview()
		{
			
			int result = 0;
			PrintBilancPrompt printPrompt = new PrintBilancPrompt(this.dtpFillimi.Text, this.dtpMbarimi.Text, dateDitor);
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
				printim.NgarkoRaport("ShfaqBilanci");
			else
				printim.NgarkoRaport("ShfaqBilanciPerDatenEdhene");
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
			PrintBilancPrompt printPrompt = new PrintBilancPrompt(this.dtpFillimi.Text, this.dtpMbarimi.Text, dateDitor);
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
				printim.Printo("ShfaqBilanci");
			else
				printim.Printo("ShfaqBilanciPerDatenEdhene");
		}

		private void dgBilanc2_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
		{
		
		}

		private void gridEX1_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
		{
		
		}

		private void uiButton1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void lblStatus_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			int index = this.gridEX2.Row;
			//string s = Convert.ToString(this.gridEX2.RootTable.Columns[0]);
		}

		public event VisionInfoSolutionLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

		#endregion
	}
}

