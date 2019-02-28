using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace HotelManagment.Forms
{
	public class Reminder : VisionInfoSolutionLibrary.Form
	{
		#region Private Fields

		private VisionInfoSolutionLibrary.Button btnModifiko;
		private VisionInfoSolutionLibrary.GroupBox gbShto;
		private VisionInfoSolutionLibrary.DateTimePicker dtpShtoMesazh;
		private VisionInfoSolutionLibrary.Label lblDataShto;
		private VisionInfoSolutionLibrary.TextBox txtShtoMesazh;
		private VisionInfoSolutionLibrary.Label lblTekstMesazh;
		private VisionInfoSolutionLibrary.Button btnShto;
		private VisionInfoSolutionLibrary.GroupBox gbMesazhet;
		private VisionInfoSolutionLibrary.Label lblTekstModifikoFshi;
		private VisionInfoSolutionLibrary.TextBox txtModifikoFshi;
		private VisionInfoSolutionLibrary.Label lblDataModifikoFshi;
		private VisionInfoSolutionLibrary.DateTimePicker dtpModifikoFshi;
		private VisionInfoSolutionLibrary.Button btnFshi;
		private System.ComponentModel.IContainer components = null;
		private System.Data.DataSet dsMesazhe = new System.Data.DataSet();
		private string dataVjeter = "";
		private DateTime dataVjeterDate;
		private Janus.Windows.GridEX.GridEX dgMesazhe;
		private string tekstiVjeter = "";
		#endregion

		#region Constructors & Destructors
		public Reminder()
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
			this.dgMesazhe = new Janus.Windows.GridEX.GridEX();
			this.btnModifiko = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbShto = new VisionInfoSolutionLibrary.GroupBox();
			this.lblTekstMesazh = new VisionInfoSolutionLibrary.Label();
			this.txtShtoMesazh = new VisionInfoSolutionLibrary.TextBox();
			this.lblDataShto = new VisionInfoSolutionLibrary.Label();
			this.dtpShtoMesazh = new VisionInfoSolutionLibrary.DateTimePicker();
			this.btnShto = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbMesazhet = new VisionInfoSolutionLibrary.GroupBox();
			this.lblTekstModifikoFshi = new VisionInfoSolutionLibrary.Label();
			this.txtModifikoFshi = new VisionInfoSolutionLibrary.TextBox();
			this.lblDataModifikoFshi = new VisionInfoSolutionLibrary.Label();
			this.dtpModifikoFshi = new VisionInfoSolutionLibrary.DateTimePicker();
			this.btnFshi = new VisionInfoSolutionLibrary.Button(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgMesazhe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gbShto)).BeginInit();
			this.gbShto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbMesazhet)).BeginInit();
			this.gbMesazhet.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(888, 24);
			// 
			// dgMesazhe
			// 
			this.dgMesazhe.AllowColumnDrag = false;
			this.dgMesazhe.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.dgMesazhe.AlternatingColors = true;
			this.dgMesazhe.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.Bisque;
			this.dgMesazhe.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgMesazhe.Cursor = System.Windows.Forms.Cursors.Default;
			this.dgMesazhe.GroupByBoxVisible = false;
			this.dgMesazhe.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.dgMesazhe.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.InactiveCaptionText;
			this.dgMesazhe.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.dgMesazhe.LayoutData = @"<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""colData""><Caption>Data</Caption><CellToolTipText>Klikoni mbi mesazhin te cilin doni ta modifikoni ose fshini</CellToolTipText><DataMember>Data</DataMember><HeaderAlignment>Center</HeaderAlignment><Key>colData</Key><Position>0</Position><Width>139</Width></Column0><Column1 ID=""colTeksti""><Caption>Teksti</Caption><CellToolTipText>Klikoni mbi mesazhin te cilin doni ta modifikoni </CellToolTipText><DataMember>Mesazhi</DataMember><HeaderAlignment>Center</HeaderAlignment><Key>colTeksti</Key><Position>1</Position><Width>555</Width></Column1></Columns><DataMember>dsMesazhe</DataMember><GroupCondition ID="""" /><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>1</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>";
			this.dgMesazhe.Location = new System.Drawing.Point(8, 20);
			this.dgMesazhe.Name = "dgMesazhe";
			this.dgMesazhe.SelectedFormatStyle.BackColorGradient = System.Drawing.SystemColors.Highlight;
			this.dgMesazhe.Size = new System.Drawing.Size(696, 288);
			this.dgMesazhe.TabIndex = 1;
			this.dgMesazhe.ThemedAreas = Janus.Windows.GridEX.ThemedArea.ScrollBars;
			this.dgMesazhe.TreeLineColor = System.Drawing.SystemColors.Desktop;
			this.dgMesazhe.UpdateOnLeave = false;
			this.dgMesazhe.CurrentCellChanged += new System.EventHandler(this.dgMesazhe_CurrentCellChanged);
			// 
			// btnModifiko
			// 
			this.btnModifiko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifiko.DoValidation = true;
			this.btnModifiko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModifiko.Location = new System.Drawing.Point(192, 532);
			this.btnModifiko.Name = "btnModifiko";
			this.btnModifiko.Size = new System.Drawing.Size(90, 21);
			this.btnModifiko.TabIndex = 2;
			this.btnModifiko.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifiko, "Modifiko mesazhin e zgjedhur");
			this.btnModifiko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
			// 
			// gbShto
			// 
			this.gbShto.BackColor = System.Drawing.Color.Transparent;
			this.gbShto.Controls.Add(this.lblTekstMesazh);
			this.gbShto.Controls.Add(this.txtShtoMesazh);
			this.gbShto.Controls.Add(this.lblDataShto);
			this.gbShto.Controls.Add(this.dtpShtoMesazh);
			this.gbShto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbShto.Location = new System.Drawing.Point(10, 42);
			this.gbShto.Name = "gbShto";
			this.gbShto.Size = new System.Drawing.Size(536, 84);
			this.gbShto.TabIndex = 3;
			this.gbShto.Text = "Shto mesazh te ri";
			this.gbShto.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// lblTekstMesazh
			// 
			this.lblTekstMesazh.Location = new System.Drawing.Point(8, 48);
			this.lblTekstMesazh.Name = "lblTekstMesazh";
			this.lblTekstMesazh.Size = new System.Drawing.Size(100, 20);
			this.lblTekstMesazh.TabIndex = 3;
			this.lblTekstMesazh.Text = "Teksti i mesazhit";
			this.lblTekstMesazh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtShtoMesazh
			// 
			this.txtShtoMesazh.AutoSize = false;
			this.txtShtoMesazh.DefaultErrorMessage = "";
			this.txtShtoMesazh.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtShtoMesazh.FixedLength = false;
			this.txtShtoMesazh.IsValid = true;
			this.txtShtoMesazh.Location = new System.Drawing.Point(112, 48);
			this.txtShtoMesazh.Name = "txtShtoMesazh";
			this.txtShtoMesazh.Required = false;
			this.txtShtoMesazh.RequiredControlColor = System.Drawing.Color.White;
			this.txtShtoMesazh.Size = new System.Drawing.Size(336, 20);
			this.txtShtoMesazh.TabIndex = 2;
			this.txtShtoMesazh.Text = "";
			this.toolTips.SetToolTip(this.txtShtoMesazh, "Teksti i mesazhit te ri qe do te shtoni");
			// 
			// lblDataShto
			// 
			this.lblDataShto.Location = new System.Drawing.Point(8, 20);
			this.lblDataShto.Name = "lblDataShto";
			this.lblDataShto.Size = new System.Drawing.Size(100, 20);
			this.lblDataShto.TabIndex = 1;
			this.lblDataShto.Text = "Data e mesazhit";
			this.lblDataShto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpShtoMesazh
			// 
			this.dtpShtoMesazh.CustomFormat = "dd/MM/yyyy HH:mm";
			this.dtpShtoMesazh.DefaultErrorMessage = "";
			this.dtpShtoMesazh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpShtoMesazh.IsValid = true;
			this.dtpShtoMesazh.Location = new System.Drawing.Point(112, 20);
			this.dtpShtoMesazh.Name = "dtpShtoMesazh";
			this.dtpShtoMesazh.Required = false;
			this.dtpShtoMesazh.ShowUpDown = true;
			this.dtpShtoMesazh.TabIndex = 0;
			this.toolTips.SetToolTip(this.dtpShtoMesazh, "Koha ne te cilin do te paraqitet mesazhi i ri");
			this.dtpShtoMesazh.Value = new System.DateTime(2006, 1, 12, 11, 50, 0, 0);
			// 
			// btnShto
			// 
			this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShto.DoValidation = true;
			this.btnShto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShto.Location = new System.Drawing.Point(564, 72);
			this.btnShto.Name = "btnShto";
			this.btnShto.Size = new System.Drawing.Size(90, 21);
			this.btnShto.TabIndex = 4;
			this.btnShto.Text = "Shto";
			this.toolTips.SetToolTip(this.btnShto, "Shto mesazhin e ri");
			this.btnShto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
			// 
			// gbMesazhet
			// 
			this.gbMesazhet.BackColor = System.Drawing.Color.Transparent;
			this.gbMesazhet.Controls.Add(this.dgMesazhe);
			this.gbMesazhet.Controls.Add(this.lblTekstModifikoFshi);
			this.gbMesazhet.Controls.Add(this.txtModifikoFshi);
			this.gbMesazhet.Controls.Add(this.lblDataModifikoFshi);
			this.gbMesazhet.Controls.Add(this.dtpModifikoFshi);
			this.gbMesazhet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbMesazhet.Location = new System.Drawing.Point(10, 128);
			this.gbMesazhet.Name = "gbMesazhet";
			this.gbMesazhet.Size = new System.Drawing.Size(716, 388);
			this.gbMesazhet.TabIndex = 5;
			this.gbMesazhet.Text = "Mesazhet e deritanishme";
			this.gbMesazhet.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// lblTekstModifikoFshi
			// 
			this.lblTekstModifikoFshi.Location = new System.Drawing.Point(8, 352);
			this.lblTekstModifikoFshi.Name = "lblTekstModifikoFshi";
			this.lblTekstModifikoFshi.Size = new System.Drawing.Size(100, 20);
			this.lblTekstModifikoFshi.TabIndex = 9;
			this.lblTekstModifikoFshi.Text = "Teksti i mesazhit";
			this.lblTekstModifikoFshi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtModifikoFshi
			// 
			this.txtModifikoFshi.AutoSize = false;
			this.txtModifikoFshi.DefaultErrorMessage = "";
			this.txtModifikoFshi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtModifikoFshi.FixedLength = false;
			this.txtModifikoFshi.IsValid = true;
			this.txtModifikoFshi.Location = new System.Drawing.Point(112, 352);
			this.txtModifikoFshi.Name = "txtModifikoFshi";
			this.txtModifikoFshi.Required = false;
			this.txtModifikoFshi.RequiredControlColor = System.Drawing.Color.White;
			this.txtModifikoFshi.Size = new System.Drawing.Size(336, 20);
			this.txtModifikoFshi.TabIndex = 8;
			this.txtModifikoFshi.Text = "";
			this.toolTips.SetToolTip(this.txtModifikoFshi, "Teksti i mesazhit");
			// 
			// lblDataModifikoFshi
			// 
			this.lblDataModifikoFshi.Location = new System.Drawing.Point(8, 324);
			this.lblDataModifikoFshi.Name = "lblDataModifikoFshi";
			this.lblDataModifikoFshi.Size = new System.Drawing.Size(100, 20);
			this.lblDataModifikoFshi.TabIndex = 7;
			this.lblDataModifikoFshi.Text = "Data e mesazhit";
			this.lblDataModifikoFshi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpModifikoFshi
			// 
			this.dtpModifikoFshi.CustomFormat = "dd/MM/yyyy HH:mm";
			this.dtpModifikoFshi.DefaultErrorMessage = "";
			this.dtpModifikoFshi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpModifikoFshi.IsValid = true;
			this.dtpModifikoFshi.Location = new System.Drawing.Point(112, 324);
			this.dtpModifikoFshi.Name = "dtpModifikoFshi";
			this.dtpModifikoFshi.Required = false;
			this.dtpModifikoFshi.ShowUpDown = true;
			this.dtpModifikoFshi.TabIndex = 6;
			this.toolTips.SetToolTip(this.dtpModifikoFshi, "Koha ne te cilin do te paraqitet mesazhi");
			this.dtpModifikoFshi.Value = new System.DateTime(2006, 1, 12, 11, 50, 0, 0);
			// 
			// btnFshi
			// 
			this.btnFshi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFshi.DoValidation = true;
			this.btnFshi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFshi.Location = new System.Drawing.Point(340, 532);
			this.btnFshi.Name = "btnFshi";
			this.btnFshi.Size = new System.Drawing.Size(90, 21);
			this.btnFshi.TabIndex = 6;
			this.btnFshi.Text = "Fshi";
			this.toolTips.SetToolTip(this.btnFshi, "Fshi mesazhin e zgjedhur");
			this.btnFshi.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
			// 
			// Reminder
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(888, 604);
			this.Controls.Add(this.btnFshi);
			this.Controls.Add(this.gbMesazhet);
			this.Controls.Add(this.btnShto);
			this.Controls.Add(this.gbShto);
			this.Controls.Add(this.btnModifiko);
			this.HelpFile = "ALARM.htm";
			this.Name = "Reminder";
			this.Text = "Mesazhe alarmi";
			this.TitullGjeresi = 888;
			this.Load += new System.EventHandler(this.Reminder_Load);
			this.Controls.SetChildIndex(this.btnModifiko, 0);
			this.Controls.SetChildIndex(this.gbShto, 0);
			this.Controls.SetChildIndex(this.btnShto, 0);
			this.Controls.SetChildIndex(this.gbMesazhet, 0);
			this.Controls.SetChildIndex(this.btnFshi, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			((System.ComponentModel.ISupportInitialize)(this.dgMesazhe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gbShto)).EndInit();
			this.gbShto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbMesazhet)).EndInit();
			this.gbMesazhet.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void Reminder_Load(object sender, System.EventArgs e)
		{
			try
			{
				this.dtpShtoMesazh.Value = DateTime.Now;
				this.dtpModifikoFshi.Value = DateTime.Now;
				if (File.Exists(Application.StartupPath + "\\MesazheAlarmi.xml"))
				{
					dsMesazhe.Tables.Clear();
					dsMesazhe.ReadXml(Application.StartupPath + "\\MesazheAlarmi.xml", XmlReadMode.ReadSchema);
					this.dgMesazhe.DataSource = dsMesazhe.Tables[0];
					this.dgMesazhe.RootTable.DataMember = this.dsMesazhe.Tables[0].TableName;
				}
			}
			catch
			{
				// Empty catch
			}
		}

		private void btnShto_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Nese data qe eshte e futur eshte me e vogel ose e barabarte me daten e tanishme te
				// sistemi atehere jep mesazh qe te nderroje daten dhe dil
				if (Convert.ToDateTime(this.dtpShtoMesazh.Value) <= DateTime.Now)
				{
					MessageBox.Show("Koha e mesazhit te alarmit duhet te jete me e madhe se koha qe ka sistemi juaj",
						"Perkujtese", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				// Nese nuk eshte konfiguruar akoma dataseti dsMesazhe atehere duhet krijuar struktura per te.
				// Ky dataset do te kete 2 kolona: njera do te jete data dhe ora e alarmit dhe tjetra do
				// mbaje mesazhin e alarmit
				if (dsMesazhe.Tables.Count == 0)
				{
					DataTable dtMesazhet = new DataTable("Mesazhet");
					dtMesazhet.Columns.Add("Data", typeof(String));
					dtMesazhet.Columns.Add("Mesazhi", typeof(String));
					dsMesazhe.Tables.Add(dtMesazhet);
					dsMesazhe.AcceptChanges();
				}
				// Hedhim nje rresht te ri ne dsMesazhe
				DataRow dr = dsMesazhe.Tables[0].NewRow();
				dr["Data"] = Convert.ToDateTime(this.dtpShtoMesazh.Value).ToString("dd/MM/yyyy HH:mm");
				dr["Mesazhi"] = this.txtShtoMesazh.Text;
				dsMesazhe.Tables[0].Rows.Add(dr);
				dsMesazhe.AcceptChanges();
				// Bejme renditjen e rreshtave te datasetit sipas kohes se mesazhit
				DataTable dt1 = dsMesazhe.Tables[0].Copy();
				dt1.Rows.Clear();
				DataRow[] drMesazhe = dsMesazhe.Tables[0].Select("", "Data");
				for (int i = 0; i < drMesazhe.Length; i++)
				{
					DataRow dr1 = dt1.NewRow();
					dr1["Data"] = drMesazhe[i]["Data"];
					dr1["Mesazhi"] = drMesazhe[i]["Mesazhi"];
					dt1.Rows.Add(dr1);
				}
				dsMesazhe.Tables.Clear();
				dsMesazhe.Tables.Add(dt1);
				// Hedhim datasetin ne Xml
				dsMesazhe.WriteXml(Application.StartupPath + "\\MesazheAlarmi.xml", XmlWriteMode.WriteSchema);
				MainForm main = this.Main as MainForm;
				main.StartTimer1();
				this.dgMesazhe.DataSource = dsMesazhe.Tables[0];
				this.dgMesazhe.RootTable.DataMember = this.dsMesazhe.Tables[0].TableName;
			}
			catch(Exception ex)
			{
				return;
			}
		}

		private void btnModifiko_Click(object sender, System.EventArgs e)
		{
			if (this.dgMesazhe.Row < 0)
				return;
			DataRow[] dr = dsMesazhe.Tables[0].Select("Mesazhi = '" + this.tekstiVjeter + "' AND Data = '" +
				this.dataVjeter + "'");
			if (dr.Length > 0)
			{
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Mesazhe Alarmi", 
					"Jeni te sigurte qe doni te ndryshoni te dhenat per mesazhin?",MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);
				if (result != DialogResult.Yes)
					return;
				dr[0]["Mesazhi"] = this.txtModifikoFshi.Text;
				dr[0]["Data"] = Convert.ToDateTime(this.dtpModifikoFshi.Value).ToString("dd/MM/yyyy HH:mm");
				dsMesazhe.AcceptChanges();
				// Ne kete pike bejme renditjen e rreshtave sipas dates se mesazhit
				DataTable dt1 = dsMesazhe.Tables[0].Copy();
				dt1.Rows.Clear();
				DataRow[] drMesazhe = dsMesazhe.Tables[0].Select("", "Data");
				for (int i = 0; i < drMesazhe.Length; i++)
				{
					DataRow dr1 = dt1.NewRow();
					dr1["Data"] = drMesazhe[i]["Data"];
					dr1["Mesazhi"] = drMesazhe[i]["Mesazhi"];
					dt1.Rows.Add(dr1);
				}
				dsMesazhe.Tables.Clear();
				dsMesazhe.Tables.Add(dt1);
				// Hedhim datasetin ne Xml
				dsMesazhe.WriteXml(Application.StartupPath + "\\MesazheAlarmi.xml", XmlWriteMode.WriteSchema);
				MessageBox.Show("Modifikimi u krye me sukses", "Mesazhe Alarmi", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
		}

		private void btnFshi_Click(object sender, System.EventArgs e)
		{
			if (this.dgMesazhe.Row < 0)
				return;
			DataRow[] dr = dsMesazhe.Tables[0].Select("Mesazhi = '" + this.tekstiVjeter + "' AND Data = '" +
				this.dataVjeter + "'");
			if (dr.Length > 0)
			{
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Mesazhe Alarmi", 
					"Jeni te sigurte qe doni te ndryshoni te dhenat per mesazhin?",MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);
				if (result != DialogResult.Yes)
					return;
				dsMesazhe.Tables[0].Rows.Remove(dr[0]);
				dsMesazhe.AcceptChanges();
				// Ne kete pike bejme renditjen e rreshtave sipas dates se mesazhit
				DataTable dt1 = dsMesazhe.Tables[0].Copy();
				dt1.Rows.Clear();
				DataRow[] drMesazhe = dsMesazhe.Tables[0].Select("", "Data");
				for (int i = 0; i < drMesazhe.Length; i++)
				{
					DataRow dr1 = dt1.NewRow();
					dr1["Data"] = drMesazhe[i]["Data"];
					dr1["Mesazhi"] = drMesazhe[i]["Mesazhi"];
					dt1.Rows.Add(dr1);
				}
				dsMesazhe.Tables.Clear();
				dsMesazhe.Tables.Add(dt1);
				//this.dsMesazhe.Tables[0].Clear();
				//this.dsMesazhe.Tables.Remove("Mesazhet");
				//this.dsMesazhe.Clear();
				this.dsMesazhe.WriteXml(Application.StartupPath + "\\MesazheAlarmi.xml", XmlWriteMode.WriteSchema);
			}
		}


		private void dgMesazhe_CurrentCellChanged(object sender, System.EventArgs e)
		{
			int j = this.dgMesazhe.Row;
			Janus.Windows.GridEX.GridEXRow row = this.dgMesazhe.GetRow(j);
			this.txtModifikoFshi.Text= row.Cells[1].Value.ToString();
			this.dtpModifikoFshi.Value = this.ConvertToDateTime(row.Cells[0].Value.ToString());
			this.dataVjeter = Convert.ToDateTime(this.dtpModifikoFshi.Value).ToString("dd/MM/yyyy HH:mm");
			this.dataVjeterDate = Convert.ToDateTime(this.dtpModifikoFshi.Value);
			this.tekstiVjeter = this.txtModifikoFshi.Text;
			this.dtpModifikoFshi.Value = this.dataVjeterDate;
		}

		#endregion

		#region Private Methods
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


		private DataTable SortTable(DataTable table)
		{ 
			DataTable t = null; 
			t = table.Copy(); 
			t.DefaultView.Sort=t.Columns[0].ColumnName+" asc"; 
			//output to console for debugging 
//			for (int i=0; i<t.Rows.Count; i++)
//			{ 
//				Console.WriteLine(); 
//				for (int j=0; j<table.Columns.Count; j++) 
//					Console.Write(table.Rows[i].ItemArray[j].ToString()+"\t"); 
//			} 
			return t; 
		}
		#endregion
	}
}

