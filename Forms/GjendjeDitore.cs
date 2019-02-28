using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using VisionInfoSolutionLibrary;
using System.Globalization;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment.Forms
{
	/// <summary>
	/// Summary description for GjendjeDitore.
	/// </summary>
	public class GjendjeDitore : VisionInfoSolutionLibrary.PrintForm
	{
		#region Private Variables

		private System.ComponentModel.IContainer components;
		private VisionInfoSolutionLibrary.NumericBox numGjendjaReale;
		private VisionInfoSolutionLibrary.NumericBox numVleraHedhje;
		private VisionInfoSolutionLibrary.MonthCal.MonthCalendar  monthCalendarAlb1;
		private VisionInfoSolutionLibrary.Button btnHidh;
		private VisionInfoSolutionLibrary.GroupBox gbGjendja;
		private VisionInfoSolutionLibrary.GroupBox gbVlera;
		private VisionInfoSolutionLibrary.GroupBox gbGjendjaDitore;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.DataGrid dgArka;
		private DateTime dtKerkimi;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.CheckBox cbBarRes;
		private VisionInfoSolutionLibrary.CheckBox cbHoteli;
		private VisionInfoSolutionLibrary.CheckBox checkBox1;
		private System.Data.DataSet ds;
		#endregion

		#region Constructors & Destructors
		public GjendjeDitore()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
			this.numGjendjaReale = new VisionInfoSolutionLibrary.NumericBox();
			this.numVleraHedhje = new VisionInfoSolutionLibrary.NumericBox();
			this.monthCalendarAlb1 = new VisionInfoSolutionLibrary.MonthCal.MonthCalendar();
			this.ds = new System.Data.DataSet();
			this.gbVlera = new VisionInfoSolutionLibrary.GroupBox();
			this.btnHidh = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbGjendjaDitore = new VisionInfoSolutionLibrary.GroupBox();
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.dgArka = new VisionInfoSolutionLibrary.DataGrid();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.checkBox1 = new VisionInfoSolutionLibrary.CheckBox();
			this.cbBarRes = new VisionInfoSolutionLibrary.CheckBox();
			this.cbHoteli = new VisionInfoSolutionLibrary.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.gbGjendja)).BeginInit();
			this.gbGjendja.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gbVlera)).BeginInit();
			this.gbVlera.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbGjendjaDitore)).BeginInit();
			this.gbGjendjaDitore.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgArka)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(924, 25);
			// 
			// gbGjendja
			// 
			this.gbGjendja.BackColor = System.Drawing.Color.Transparent;
			this.gbGjendja.Controls.Add(this.numGjendjaReale);
			this.gbGjendja.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbGjendja.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gbGjendja.Location = new System.Drawing.Point(256, 128);
			this.gbGjendja.Name = "gbGjendja";
			this.gbGjendja.Size = new System.Drawing.Size(196, 58);
			this.gbGjendja.TabIndex = 2;
			this.gbGjendja.Text = "Gjendja fizike ne arke per daten";
			this.gbGjendja.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// numGjendjaReale
			// 
			this.numGjendjaReale.AutoSize = false;
			this.numGjendjaReale.DefaultErrorMessage = "";
			this.numGjendjaReale.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numGjendjaReale.DigitsAfterDecimalPoint = 0;
			this.numGjendjaReale.FixedLength = false;
			this.numGjendjaReale.IsValid = true;
			this.numGjendjaReale.KeepFocus = false;
			this.numGjendjaReale.Location = new System.Drawing.Point(20, 24);
			this.numGjendjaReale.Name = "numGjendjaReale";
			this.numGjendjaReale.OnlyPositive = false;
			this.numGjendjaReale.ReadOnly = true;
			this.numGjendjaReale.Required = false;
			this.numGjendjaReale.RequiredControlColor = System.Drawing.Color.White;
			this.numGjendjaReale.Size = new System.Drawing.Size(152, 20);
			this.numGjendjaReale.TabIndex = 7;
			this.numGjendjaReale.Text = "";
			this.numGjendjaReale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTips.SetToolTip(this.numGjendjaReale, "Shuma e hedhjeve vetem per daten e zgjedhur!");
			// 
			// numVleraHedhje
			// 
			this.numVleraHedhje.AutoSize = false;
			this.numVleraHedhje.DefaultErrorMessage = "Ju duhet te caktoni nje vlere ne rast se do te beni hedhje ne arke!";
			this.numVleraHedhje.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numVleraHedhje.DigitsAfterDecimalPoint = 0;
			this.numVleraHedhje.FixedLength = false;
			this.numVleraHedhje.IsValid = false;
			this.numVleraHedhje.KeepFocus = false;
			this.numVleraHedhje.Location = new System.Drawing.Point(20, 24);
			this.numVleraHedhje.Name = "numVleraHedhje";
			this.numVleraHedhje.OnlyPositive = true;
			this.numVleraHedhje.Required = true;
			this.numVleraHedhje.RequiredControlColor = System.Drawing.Color.White;
			this.numVleraHedhje.Size = new System.Drawing.Size(150, 20);
			this.numVleraHedhje.TabIndex = 8;
			this.numVleraHedhje.Text = "";
			this.numVleraHedhje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
			this.monthCalendarAlb1.Location = new System.Drawing.Point(12, 16);
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
			this.monthCalendarAlb1.TabIndex = 8;
			this.monthCalendarAlb1.Theme = true;
			this.monthCalendarAlb1.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.monthCalendarAlb1.Weekdays.TextColor = System.Drawing.SystemColors.ActiveCaption;
			this.monthCalendarAlb1.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.monthCalendarAlb1.Weeknumbers.TextColor = System.Drawing.SystemColors.ActiveCaption;
			this.monthCalendarAlb1.DaySelected += new VisionInfoSolutionLibrary.MonthCal.DaySelectedEventHandler(this.monthCalendarAlb1_DaySelected);
			// 
			// ds
			// 
			this.ds.DataSetName = "NewDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// gbVlera
			// 
			this.gbVlera.BackColor = System.Drawing.Color.Transparent;
			this.gbVlera.Controls.Add(this.numVleraHedhje);
			this.gbVlera.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbVlera.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gbVlera.Location = new System.Drawing.Point(244, 80);
			this.gbVlera.Name = "gbVlera";
			this.gbVlera.Size = new System.Drawing.Size(196, 60);
			this.gbVlera.TabIndex = 17;
			this.gbVlera.Text = "Vlera e hedhjes ne arke";
			this.gbVlera.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// btnHidh
			// 
			this.btnHidh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHidh.DoValidation = true;
			this.btnHidh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHidh.Location = new System.Drawing.Point(304, 152);
			this.btnHidh.Name = "btnHidh";
			this.btnHidh.Size = new System.Drawing.Size(90, 21);
			this.btnHidh.TabIndex = 9;
			this.btnHidh.Text = "Hidh";
			this.toolTips.SetToolTip(this.btnHidh, "Hedh vleren e caktuar ne arke per daten ne kalendar!");
			this.btnHidh.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnHidh.Click += new System.EventHandler(this.btnHidh_Click);
			// 
			// gbGjendjaDitore
			// 
			this.gbGjendjaDitore.BackColor = System.Drawing.Color.Transparent;
			this.gbGjendjaDitore.Controls.Add(this.monthCalendarAlb1);
			this.gbGjendjaDitore.Controls.Add(this.gbVlera);
			this.gbGjendjaDitore.Controls.Add(this.btnHidh);
			this.gbGjendjaDitore.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbGjendjaDitore.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gbGjendjaDitore.Location = new System.Drawing.Point(10, 108);
			this.gbGjendjaDitore.Name = "gbGjendjaDitore";
			this.gbGjendjaDitore.Size = new System.Drawing.Size(458, 212);
			this.gbGjendjaDitore.TabIndex = 18;
			this.gbGjendjaDitore.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dgArka);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(10, 328);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(458, 212);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.Text = "Arka sipas formes se pagesave";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// dgArka
			// 
			this.dgArka.AllowSorting = false;
			this.dgArka.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgArka.CanDelete = true;
			this.dgArka.CaptionVisible = false;
			this.dgArka.DataMember = "";
			this.dgArka.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.dgArka.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgArka.HideHorizontalScrollBar = false;
			this.dgArka.HideVerticalScrollBar = false;
			this.dgArka.Location = new System.Drawing.Point(12, 20);
			this.dgArka.Name = "dgArka";
			this.dgArka.RowHeadersVisible = false;
			this.dgArka.RowHeaderWidth = 0;
			this.dgArka.Selekto = true;
			this.dgArka.Size = new System.Drawing.Size(432, 180);
			this.dgArka.TabIndex = 10;
			this.toolTips.SetToolTip(this.dgArka, "Hedhjet e kategorizuara sipas formes se pagesave vetem per daten e zgjedhur!");
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
			this.groupBox2.Size = new System.Drawing.Size(458, 64);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.Text = "Modulet";
			this.groupBox2.Visible = false;
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.DefaultErrorMessage = "";
			this.checkBox1.IsValid = true;
			this.checkBox1.Location = new System.Drawing.Point(260, 24);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(172, 24);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Restorant Manager";
			// 
			// cbBarRes
			// 
			this.cbBarRes.BackColor = System.Drawing.Color.Transparent;
			this.cbBarRes.DefaultErrorMessage = "";
			this.cbBarRes.IsValid = true;
			this.cbBarRes.Location = new System.Drawing.Point(140, 24);
			this.cbBarRes.Name = "cbBarRes";
			this.cbBarRes.Size = new System.Drawing.Size(112, 24);
			this.cbBarRes.TabIndex = 1;
			this.cbBarRes.Text = "Bar Manager";
			this.cbBarRes.CheckedChanged += new System.EventHandler(this.cbBarRes_CheckedChanged);
			// 
			// cbHoteli
			// 
			this.cbHoteli.BackColor = System.Drawing.Color.Transparent;
			this.cbHoteli.Checked = true;
			this.cbHoteli.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbHoteli.DefaultErrorMessage = "";
			this.cbHoteli.IsValid = true;
			this.cbHoteli.Location = new System.Drawing.Point(12, 24);
			this.cbHoteli.Name = "cbHoteli";
			this.cbHoteli.Size = new System.Drawing.Size(124, 24);
			this.cbHoteli.TabIndex = 0;
			this.cbHoteli.Text = "Hotel Manager";
			this.cbHoteli.CheckedChanged += new System.EventHandler(this.cbHoteli_CheckedChanged);
			// 
			// GjendjeDitore
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CheckRequiredFields = true;
			this.ClientSize = new System.Drawing.Size(924, 616);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbGjendja);
			this.Controls.Add(this.gbGjendjaDitore);
			this.EnableValidation = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.HelpFile = "GJENDJA DITORE.htm";
			this.Name = "GjendjeDitore";
			this.Text = "Gjendja ditore e arkes";
			this.TitullGjeresi = 924;
			this.Load += new System.EventHandler(this.GjendjeDitore_Load);
			this.Controls.SetChildIndex(this.gbGjendjaDitore, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.gbGjendja, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			((System.ComponentModel.ISupportInitialize)(this.gbGjendja)).EndInit();
			this.gbGjendja.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gbVlera)).EndInit();
			this.gbVlera.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbGjendjaDitore)).EndInit();
			this.gbGjendjaDitore.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgArka)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void GjendjeDitore_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.ds.Tables.Clear();
			dtKerkimi =  System.DateTime.Today;
			InputController data = new InputController();
			try
			{
				// Vendosim gjuhen shqipe per kalendarin e formes
				CultureInfo al = new CultureInfo("sq-AL");
				this.monthCalendarAlb1.Culture = al;
				this.monthCalendarAlb1.ActiveMonth.Month = DateTime.Now.Month;
				// Nxjerrim gjendjen e arkes per diten e sotme dhe bejme edhe inicializimet
				// e tjera te nevojshme
				ds = data.KerkesaRead("GjendjaRealeArke", dtKerkimi );
				DataRow dr = ds.Tables[0].Rows[0];
				int vlera = Convert.ToInt32(ds.Tables[0].Rows[0]["SHUMA"]);
				this.numGjendjaReale.Text = Convert.ToString(vlera);
				this.dgArka.DataSource = ds.Tables[0];
				this.KrijoStilGride();
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
				return;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void btnHidh_Click(object sender, System.EventArgs e)
		{  
			try
			{
				int b = 0 ;
				if (this.numVleraHedhje.Text != "")
				{
					int sasia = Convert.ToInt32(this.numVleraHedhje.Text) ;
					if (sasia < 0)
					{
						this.error.SetError(this.numVleraHedhje, "Nuk mund te hidhni vlera negative ne arke!");
						return;
					}
					this.error.SetError(this.numVleraHedhje, "");
					InputController input = new InputController();
					b = input.KerkesaUpdate("HidhNeArke", dtKerkimi, sasia, this.PerdoruesId );
					if (b == 0)
					{
						RefreshControls();
						System.Windows.Forms.MessageBox.Show(this, 
							"Hedhja u krye me sukses!", "Gjendja ne arke",MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						System.Windows.Forms.MessageBox.Show(this, 
							"Hedhja nuk u krye! Provoni perseri", "Gjendja ne arke",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				return;
			}
		}

		private void monthCalendarAlb1_DaySelected(object sender, VisionInfoSolutionLibrary.MonthCal.DaySelectedEventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			dtKerkimi = Convert.ToDateTime((e.Days).GetValue(0));
			InputController data = new InputController();
			try
			{
				if ((this.cbHoteli.Checked == true)&&(this.cbBarRes.Checked == true))
				{
					this.error.SetError(this.groupBox2, "");
				}
				else if (this.cbBarRes.Checked == true)
				{
					this.error.SetError(this.groupBox2, "");
				}
				else if (this.cbHoteli.Checked == true)
				{
					this.error.SetError(this.groupBox2, "");
					ds = data.KerkesaRead("GjendjaRealeArke", dtKerkimi );
					DataRow dr = ds.Tables[0].Rows[0];
					int vlera = Convert.ToInt32(ds.Tables[0].Rows[0]["SHUMA"]);
					this.numGjendjaReale.Text = Convert.ToString(vlera);
					this.dgArka.DataSource = ds.Tables[0];
					this.KrijoStilGride();
				}
				else
				{
					this.numGjendjaReale.Text = "";
					this.dgArka.DataSource = null;
					this.error.SetError(this.groupBox2, "Zgjidhni nje prej moduleve!");
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
				return;
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void cbBarRes_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void cbHoteli_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}
		#endregion
		#region Private methods
		private void KrijoStilGride()
		{
			this.dgArka.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.Bisque;
			style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			style.RowHeadersVisible = false;
			dgArka.ReadOnly = true;

			DataGridTextBoxColumn colEmri = new DataGridTextBoxColumn();
			colEmri.HeaderText = "Emri";
			colEmri.MappingName = "EMRI";
			colEmri.Width = 128;
			colEmri.NullText = "";

			DataGridTextBoxColumn colShuma = new DataGridTextBoxColumn();
			colShuma.HeaderText = "Vlera e hedhur";
			colShuma.MappingName = "SHUMA";
			colShuma.Width = 110;
			colShuma.NullText = "";
		
			DataGridTextBoxColumn colPerqindja = new DataGridTextBoxColumn();
			colPerqindja.HeaderText = "Perqindja";
			colPerqindja.MappingName = "PERQINDJA";
			colPerqindja.Width = 80;
			colPerqindja.NullText = "";

			DataGridTextBoxColumn colPerfundimtare = new DataGridTextBoxColumn();
			colPerfundimtare.HeaderText = "Vlera me komision";
			colPerfundimtare.MappingName = "MEKOMISION";
			colPerfundimtare.Width = 110;
			colPerfundimtare.NullText = "";
	
			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{colEmri,colShuma,colPerqindja,colPerfundimtare});
			dgArka.TableStyles.Add(style);
			dgArka.FlatMode = false;
			dgArka.Expand(-1);
		}
		private void RefreshControls()
		{
			this.numVleraHedhje.Text = "";
			InputController data = new InputController();
			try
			{
				ds = data.KerkesaRead("GjendjaRealeArke", dtKerkimi );
				DataRow dr = ds.Tables[0].Rows[0];
				if (Convert.IsDBNull(dr[0]))
				{
					this.numGjendjaReale.Text = "0";
				}
				else
				{
					int vlera = Convert.ToInt32(dr[0]);
					this.numGjendjaReale.Text = Convert.ToString(vlera);
				}
				//ds = data.KerkesaRead("GjendjaDitoreDuhur", dtKerkimi);
				//this.numGjendjaDuhur.Text = Convert.ToString(ds.Tables[0].Rows[0]);

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
		#endregion
	}
}
