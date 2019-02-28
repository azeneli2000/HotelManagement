using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment.Forms
{
	/// <summary>
	/// Summary description for Dhoma1.
	/// </summary>
	public class Dhoma1 : VisionInfoSolutionLibrary.Form
	{
		private System.ComponentModel.IContainer components;
		public string dhoma_zgjedhur;
		private VisionInfoSolutionLibrary.GroupBox gbCaktim;
		private VisionInfoSolutionLibrary.ListView lvDhomatLira;
		private VisionInfoSolutionLibrary.Label label16;
		private VisionInfoSolutionLibrary.Button btnMajas;
		private VisionInfoSolutionLibrary.Button btnDjathtas;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.ListView lvDhomatPerRezervim;
		private System.Windows.Forms.ColumnHeader emriDhoma1;
		private System.Windows.Forms.ColumnHeader cmimiDhoma1;
		private System.Windows.Forms.ColumnHeader idDhoma1;
		private System.Windows.Forms.ColumnHeader emriDhoma2;
		private System.Windows.Forms.ColumnHeader cmimiDhoma2;
		private System.Windows.Forms.ColumnHeader idDhoma2;
		private VisionInfoSolutionLibrary.Button btnShtoDhome;
		public int [] idDhoma;
		private DateTime dtFillimi;
		private DateTime dtMbarimi;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategorite;
		private VisionInfoSolutionLibrary.Button btnPastro;
		private VisionInfoSolutionLibrary.Label label1;
		private System.Data.DataSet dsDhomaTeZgjedhura;
		private string[] vekKategori;
	
		public Dhoma1(DateTime dtFillimi,DateTime dtMbarimi)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.dtFillimi = dtFillimi;
			this.dtMbarimi = dtMbarimi;
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.gbCaktim = new VisionInfoSolutionLibrary.GroupBox();
			this.btnPastro = new VisionInfoSolutionLibrary.Button(this.components);
			this.cmbKategorite = new VisionInfoSolutionLibrary.DoubleCombo();
			this.lvDhomatLira = new VisionInfoSolutionLibrary.ListView(this.components);
			this.emriDhoma1 = new System.Windows.Forms.ColumnHeader();
			this.cmimiDhoma1 = new System.Windows.Forms.ColumnHeader();
			this.idDhoma1 = new System.Windows.Forms.ColumnHeader();
			this.label16 = new VisionInfoSolutionLibrary.Label();
			this.btnMajas = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnDjathtas = new VisionInfoSolutionLibrary.Button(this.components);
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.lvDhomatPerRezervim = new VisionInfoSolutionLibrary.ListView(this.components);
			this.emriDhoma2 = new System.Windows.Forms.ColumnHeader();
			this.cmimiDhoma2 = new System.Windows.Forms.ColumnHeader();
			this.idDhoma2 = new System.Windows.Forms.ColumnHeader();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.btnShtoDhome = new VisionInfoSolutionLibrary.Button(this.components);
			this.dsDhomaTeZgjedhura = new System.Data.DataSet();
			((System.ComponentModel.ISupportInitialize)(this.gbCaktim)).BeginInit();
			this.gbCaktim.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsDhomaTeZgjedhura)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(493, 24);
			// 
			// gbCaktim
			// 
			this.gbCaktim.BackColor = System.Drawing.Color.Transparent;
			this.gbCaktim.Controls.Add(this.btnPastro);
			this.gbCaktim.Controls.Add(this.cmbKategorite);
			this.gbCaktim.Controls.Add(this.lvDhomatLira);
			this.gbCaktim.Controls.Add(this.label16);
			this.gbCaktim.Controls.Add(this.btnMajas);
			this.gbCaktim.Controls.Add(this.btnDjathtas);
			this.gbCaktim.Controls.Add(this.label5);
			this.gbCaktim.Controls.Add(this.lvDhomatPerRezervim);
			this.gbCaktim.Controls.Add(this.label1);
			this.gbCaktim.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbCaktim.ForeColor = System.Drawing.Color.Navy;
			this.gbCaktim.Location = new System.Drawing.Point(10, 8);
			this.gbCaktim.Name = "gbCaktim";
			this.gbCaktim.Size = new System.Drawing.Size(506, 228);
			this.gbCaktim.TabIndex = 15;
			this.gbCaktim.Text = "Caktimi i dhomave";
			this.gbCaktim.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// btnPastro
			// 
			this.btnPastro.BackColor = System.Drawing.Color.Blue;
			this.btnPastro.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPastro.DoValidation = false;
			this.btnPastro.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnPastro.Location = new System.Drawing.Point(392, 16);
			this.btnPastro.Name = "btnPastro";
			this.btnPastro.Size = new System.Drawing.Size(70, 22);
			this.btnPastro.TabIndex = 53;
			this.btnPastro.Text = "Pastro";
			this.btnPastro.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnPastro.Click += new System.EventHandler(this.btnPastro_Click);
			// 
			// cmbKategorite
			// 
			this.cmbKategorite.BackColor = System.Drawing.Color.Transparent;
			this.cmbKategorite.DefaultErrorMessage = "Ju duhet te zgjidhni kategorine!";
			this.cmbKategorite.IsValid = false;
			this.cmbKategorite.Kolone1Vlere = null;
			this.cmbKategorite.Kolone2Vlere = null;
			this.cmbKategorite.Location = new System.Drawing.Point(160, 16);
			this.cmbKategorite.Name = "cmbKategorite";
			this.cmbKategorite.ReadOnly = false;
			this.cmbKategorite.Required = false;
			this.cmbKategorite.Size = new System.Drawing.Size(160, 21);
			this.cmbKategorite.SkipValidation = false;
			this.cmbKategorite.TabIndex = 48;
			this.cmbKategorite.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmKategorite_SelectedIndexChanged);
			// 
			// lvDhomatLira
			// 
			this.lvDhomatLira.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						   this.emriDhoma1,
																						   this.cmimiDhoma1,
																						   this.idDhoma1});
			this.lvDhomatLira.DefaultErrorMessage = "";
			this.lvDhomatLira.FullRowSelect = true;
			this.lvDhomatLira.GridLines = true;
			this.lvDhomatLira.IsValid = true;
			this.lvDhomatLira.Location = new System.Drawing.Point(16, 72);
			this.lvDhomatLira.Name = "lvDhomatLira";
			this.lvDhomatLira.Size = new System.Drawing.Size(180, 130);
			this.lvDhomatLira.TabIndex = 49;
			// 
			// emriDhoma1
			// 
			this.emriDhoma1.Text = "Emri i dhomes";
			this.emriDhoma1.Width = 100;
			// 
			// cmimiDhoma1
			// 
			this.cmimiDhoma1.Text = "Cmimi";
			this.cmimiDhoma1.Width = 58;
			// 
			// idDhoma1
			// 
			this.idDhoma1.Text = "idDhoma";
			this.idDhoma1.Width = 0;
			// 
			// label16
			// 
			this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label16.ForeColor = System.Drawing.Color.DarkRed;
			this.label16.Location = new System.Drawing.Point(296, 56);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(112, 16);
			this.label16.TabIndex = 44;
			this.label16.Text = "Dhomat per rezervim";
			this.label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// btnMajas
			// 
			this.btnMajas.BackColor = System.Drawing.Color.Blue;
			this.btnMajas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMajas.DoValidation = false;
			this.btnMajas.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnMajas.Location = new System.Drawing.Point(208, 136);
			this.btnMajas.Name = "btnMajas";
			this.btnMajas.Size = new System.Drawing.Size(88, 21);
			this.btnMajas.TabIndex = 51;
			this.btnMajas.Text = "<<<Kalo";
			this.btnMajas.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnMajas.Click += new System.EventHandler(this.btnMajas_Click);
			// 
			// btnDjathtas
			// 
			this.btnDjathtas.BackColor = System.Drawing.Color.Blue;
			this.btnDjathtas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDjathtas.DoValidation = false;
			this.btnDjathtas.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDjathtas.Location = new System.Drawing.Point(208, 104);
			this.btnDjathtas.Name = "btnDjathtas";
			this.btnDjathtas.Size = new System.Drawing.Size(88, 21);
			this.btnDjathtas.TabIndex = 50;
			this.btnDjathtas.Text = "Kalo>>>";
			this.btnDjathtas.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnDjathtas.Click += new System.EventHandler(this.btnDjathtas_Click);
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(76, 16);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label5.Size = new System.Drawing.Size(76, 20);
			this.label5.TabIndex = 37;
			this.label5.Text = "Kategorite";
			// 
			// lvDhomatPerRezervim
			// 
			this.lvDhomatPerRezervim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																								  this.emriDhoma2,
																								  this.cmimiDhoma2,
																								  this.idDhoma2});
			this.lvDhomatPerRezervim.DefaultErrorMessage = "Ju duhet te zgjidhni nje prej dhomave !";
			this.lvDhomatPerRezervim.FullRowSelect = true;
			this.lvDhomatPerRezervim.GridLines = true;
			this.lvDhomatPerRezervim.IsValid = true;
			this.lvDhomatPerRezervim.Location = new System.Drawing.Point(312, 72);
			this.lvDhomatPerRezervim.Name = "lvDhomatPerRezervim";
			this.lvDhomatPerRezervim.Size = new System.Drawing.Size(180, 130);
			this.lvDhomatPerRezervim.TabIndex = 52;
			// 
			// emriDhoma2
			// 
			this.emriDhoma2.Text = "Emri i dhomes";
			this.emriDhoma2.Width = 100;
			// 
			// cmimiDhoma2
			// 
			this.cmimiDhoma2.Text = "Cmimi";
			this.cmimiDhoma2.Width = 58;
			// 
			// idDhoma2
			// 
			this.idDhoma2.Width = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 20);
			this.label1.TabIndex = 17;
			this.label1.Text = "Dhomat e lira per kategorine";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// btnShtoDhome
			// 
			this.btnShtoDhome.BackColor = System.Drawing.Color.Blue;
			this.btnShtoDhome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShtoDhome.DoValidation = false;
			this.btnShtoDhome.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShtoDhome.Location = new System.Drawing.Point(216, 248);
			this.btnShtoDhome.Name = "btnShtoDhome";
			this.btnShtoDhome.Size = new System.Drawing.Size(88, 21);
			this.btnShtoDhome.TabIndex = 54;
			this.btnShtoDhome.Text = "Shto";
			this.toolTips.SetToolTip(this.btnShtoDhome, "Shton dhomat e zgjedhura ne listen e dhomave per rezervim!");
			this.btnShtoDhome.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShtoDhome.Click += new System.EventHandler(this.btnShtoDhome_Click);
			// 
			// dsDhomaTeZgjedhura
			// 
			this.dsDhomaTeZgjedhura.DataSetName = "NewDataSet";
			this.dsDhomaTeZgjedhura.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// Dhoma1
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = false;
			this.BackColor = System.Drawing.Color.AntiqueWhite;
			this.ClientSize = new System.Drawing.Size(534, 284);
			this.ControlBox = true;
			this.Controls.Add(this.gbCaktim);
			this.Controls.Add(this.btnShtoDhome);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Dhoma1";
			this.ShfaqTitull = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shto dhome per rezervim";
			this.TitullGjeresi = 493;
			this.Load += new System.EventHandler(this.Dhoma1_Load);
			this.Controls.SetChildIndex(this.btnShtoDhome, 0);
			this.Controls.SetChildIndex(this.gbCaktim, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			((System.ComponentModel.ISupportInitialize)(this.gbCaktim)).EndInit();
			this.gbCaktim.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsDhomaTeZgjedhura)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Dhoma1_Load(object sender, System.EventArgs e)
		{
			this.dsDhomaTeZgjedhura.Tables.Add();
			this.dsDhomaTeZgjedhura.Tables[0].Columns.Add("ID_DHOMA", typeof(Int32));
			this.dsDhomaTeZgjedhura.Tables[0].Columns.Add("ID_KATEGORIA", typeof(Int32));
			this.dsDhomaTeZgjedhura.AcceptChanges();
			this.mbushKategorite();
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(166)), ((System.Byte)(64)), ((System.Byte)(1)));
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(166)), ((System.Byte)(64)), ((System.Byte)(1)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(166)), ((System.Byte)(64)), ((System.Byte)(1)));
			this.gbCaktim.ForeColor = Color.MidnightBlue;
		}

		private void mbushKategorite ()
		{   
			DataSet ds = null;

			
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqKategorite");
			// Percaktojme gjatesine e vektorit qe mbaje vlerat e idKategori-se
			int nrRreshta = ds.Tables[0].Rows.Count;
			vekKategori = new string[nrRreshta];
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				
				this.cmbKategorite.Kolone1.Items.Add(dr[1]);
				this.cmbKategorite.Kolone2.Items.Add(dr[0]);
			}

		}

		private void LoadList(DataSet ds)
		{
			this.lvDhomatLira.Items.Clear();
			DataTable dTable = ds.Tables[0];
			this.lvDhomatLira.View = View.Details;
			for (int i = 0; i < dTable.Rows.Count; i++)
			{
				// Percakto listItems
				DataRow dr = dTable.Rows[i];
				int idDhoma = Convert.ToInt32(dr["ID_DHOMA"]);
				bool ugjet = false;
				foreach (DataRow r in this.dsDhomaTeZgjedhura.Tables[0].Rows)
				{
					if (idDhoma == Convert.ToInt32(r["ID_DHOMA"]))
					{
						ugjet = true;
					}
				}
				if (!ugjet)
				{
					ListViewItem lvi = new ListViewItem(dr["DHOMA_EMRI"].ToString());
					lvi.SubItems.Add(dr["CMIMI"].ToString());
					lvi.SubItems.Add(dr["ID_DHOMA"].ToString());
					this.lvDhomatLira.Items.Add(lvi);
				}
			}
			int nr = this.lvDhomatLira.Items.Count;
			if (nr> 7)
			{
				this.lvDhomatLira.Width = 180;
			}
			else
			{
				this.lvDhomatLira.Width = 162;
			}	
		}

		private void btnDjathtas_Click(object sender, System.EventArgs e)
		{
			int selectedCount = this.lvDhomatLira.SelectedIndices.Count;
			int i = 0;
			this.lvDhomatPerRezervim.View = View.Details;
			for (i = 0; i < selectedCount; i++)
			{
				// Percakto listItems
				ListViewItem lvi = new ListViewItem(this.lvDhomatLira.SelectedItems[i].Text);
				lvi.SubItems.Add(this.lvDhomatLira.SelectedItems[i].SubItems[1].Text);
				lvi.SubItems.Add(this.lvDhomatLira.SelectedItems[i].SubItems[2].Text);
				int idDhomaZgjedhur = Convert.ToInt32(this.lvDhomatLira.SelectedItems[i].SubItems[2].Text);
				DataRow newrow = this.dsDhomaTeZgjedhura.Tables[0].NewRow();
				newrow["ID_DHOMA"] = idDhomaZgjedhur;
				newrow["ID_KATEGORIA"] = Convert.ToInt32(cmbKategorite.Kolone2Vlere);
				this.dsDhomaTeZgjedhura.Tables[0].Rows.Add(newrow);
				this.dsDhomaTeZgjedhura.AcceptChanges();
				this.lvDhomatPerRezervim.Items.Add(lvi);
			}
			i = 0;
			while (this.lvDhomatLira.SelectedItems.Count > 0)
			{
				ListViewItem lvi = new ListViewItem(this.lvDhomatLira.SelectedItems[i].Text);
				this.lvDhomatLira.Items.RemoveAt(this.lvDhomatLira.SelectedIndices[i]);
			}
			this.lvDhomatLira.Refresh();
			this.lvDhomatPerRezervim.Refresh();
			int nr = this.lvDhomatLira.Items.Count;
			if (nr> 7)
			{
				this.lvDhomatLira.Width = 180;
			}
			else
			{
				this.lvDhomatLira.Width = 162;
			}
			nr = this.lvDhomatPerRezervim.Items.Count;
			if (nr> 7)
			{
				this.lvDhomatPerRezervim.Width = 180;
			}
			else
			{
				this.lvDhomatPerRezervim.Width = 162;
			}
		}

		private void btnMajas_Click(object sender, System.EventArgs e)
		{
			int selectedCount = this.lvDhomatPerRezervim.SelectedIndices.Count;
			int i = 0;
			this.lvDhomatPerRezervim.View = View.Details;
			for (i = 0; i < selectedCount; i++)
			{
				// Percakto listItems
				ListViewItem lvi = new ListViewItem(this.lvDhomatPerRezervim.SelectedItems[i].Text);
				lvi.SubItems.Add(this.lvDhomatPerRezervim.SelectedItems[i].SubItems[1].Text);
				lvi.SubItems.Add(this.lvDhomatPerRezervim.SelectedItems[i].SubItems[2].Text);
				int idDhomaZgjedhur = Convert.ToInt32(this.lvDhomatPerRezervim.SelectedItems[i].SubItems[2].Text);
				int idKategoria = 0;
				foreach(DataRow dr in this.dsDhomaTeZgjedhura.Tables[0].Rows)
				{
					if (idDhomaZgjedhur == Convert.ToInt32(dr["ID_DHOMA"]))
					{
						idKategoria = Convert.ToInt32(dr["ID_KATEGORIA"]);
						dr.Delete();
						this.dsDhomaTeZgjedhura.AcceptChanges();
						break;
					}
				}
				if (idKategoria == Convert.ToInt32(this.cmbKategorite.Kolone2Vlere))
					this.lvDhomatLira.Items.Add(lvi);
			}
			i = 0;
			while (this.lvDhomatPerRezervim.SelectedItems.Count > 0)
			{
				ListViewItem lvi = new ListViewItem(this.lvDhomatPerRezervim.SelectedItems[i].Text);
				this.lvDhomatPerRezervim.Items.RemoveAt(this.lvDhomatPerRezervim.SelectedIndices[i]);
			}
			this.lvDhomatLira.Refresh();
			this.lvDhomatPerRezervim.Refresh();
			int nr = this.lvDhomatLira.Items.Count;
			if (nr> 7)
			{
				this.lvDhomatLira.Width = 180;
			}
			else
			{
				this.lvDhomatLira.Width = 162;
			}
			nr = this.lvDhomatPerRezervim.Items.Count;
			if (nr> 7)
			{
				this.lvDhomatPerRezervim.Width = 180;
			}
			else
			{
				this.lvDhomatPerRezervim.Width = 162;
			}
		}

		private void cmKategorite_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			DataSet ds = null;
			try
			{
				int idKategoria = Convert.ToInt32(this.cmbKategorite.Kolone2Vlere);
//				for(int i = 0; i < this.vekKategori.Length; i++)
//				{
//					if (this.vekKategori[i] == idKategoria.ToString())
//						return;
//					if (vekKategori[i] == null)
//					{
//						this.vekKategori.SetValue(idKategoria.ToString(), i);
//						break;
//					}
//				}
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqDhomatPlotesishtTeLiraPerDatatPerKategorine", idKategoria,this.dtFillimi,this.dtMbarimi);
				this.LoadList(ds);
				int b = 0;
				if(ds.Tables[0].Rows.Count == 0)
				{
					b = this.KntKonfCmimDhome(idKategoria,dtFillimi);
					if(b == 0)
					{
						System.Windows.Forms.MessageBox.Show(this,"Ne daten e hyrjes se klientit, per dhomat e kategorise se zgjedhur"+Environment.NewLine+
							"ju nuk keni konfiguruar cmimet."+Environment.NewLine+
							Environment.NewLine+
							"Ju lutemi konfiguroni cmimin ose zgjidhni nje kategori tjeter!","Merr Dhome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
					else
						b = 3;
				}
				
				if(b == 3)
				{
					System.Windows.Forms.MessageBox.Show(this,"Per kategorine e zgjedhur,gjendja e dhomave"+Environment.NewLine+
						"eshte e zene."+Environment.NewLine+
						Environment.NewLine+
						"Ju lutemi zgjidhni nje kategori tjeter!","Merr Dhome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
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

		private void btnPastro_Click(object sender, System.EventArgs e)
		{
			this.lvDhomatLira.Items.Clear();
			this.lvDhomatPerRezervim.Items.Clear();
			this.cmbKategorite.Kolone1.Text = "";
			if (this.dsDhomaTeZgjedhura.Tables[0].Rows.Count != 0)
				this.dsDhomaTeZgjedhura.Tables[0].Rows.Clear();
		}

		private void btnShtoDhome_Click(object sender, System.EventArgs e)
		{
			
			idDhoma = new int[this.lvDhomatPerRezervim.Items.Count];
			for (int i = 0; i < idDhoma.Length; i++)
				idDhoma.SetValue(Convert.ToInt32(lvDhomatPerRezervim.Items[i].SubItems[2].Text), i);
			this.Close();
		}

		#region MetodaNdihmese
		private int KntKonfCmimDhome(int idKategoria,DateTime dtFillimi)
		{
			DataSet ds = null;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqCmimetEdhomavePerDatenEdhene", dtFillimi);
			int a = 0;	
			if(ds.Tables[0].Rows.Count != 0)
			{
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					if(idKategoria  == Convert.ToInt32(dr[0]))
						a = 1;
					
				}
			}
			else
				a = 2;
			return a;
		}
		
		
		#endregion
	}
}
