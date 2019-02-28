using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using HotelManagment.BusDatService;
using HotelManagment.Reports;
using VisionInfoSolutionLibrary;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace HotelManagment.Forms
{
	public class Perkthime : VisionInfoSolutionLibrary.Form
	{
		#region Private Declarations

		private VisionInfoSolutionLibrary.GroupBox gbPerkthime;
		private VisionInfoSolutionLibrary.Button btnRuaj;
		private Janus.Windows.GridEX.GridEX dgPerkthime;
		private System.Data.DataSet dsPerkthime;
		private System.ComponentModel.IContainer components = null;
		private string gjuha = "";
		#endregion

		#region Constructors & Destructors
		public Perkthime()
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
			this.dgPerkthime = new Janus.Windows.GridEX.GridEX();
			this.dsPerkthime = new System.Data.DataSet();
			this.gbPerkthime = new VisionInfoSolutionLibrary.GroupBox();
			this.btnRuaj = new VisionInfoSolutionLibrary.Button(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgPerkthime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPerkthime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gbPerkthime)).BeginInit();
			this.gbPerkthime.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			// 
			// dgPerkthime
			// 
			this.dgPerkthime.AllowColumnDrag = false;
			this.dgPerkthime.AllowDrop = true;
			this.dgPerkthime.AlternatingColors = true;
			this.dgPerkthime.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.Bisque;
			this.dgPerkthime.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgPerkthime.Cursor = System.Windows.Forms.Cursors.Default;
			this.dgPerkthime.GroupByBoxVisible = false;
			this.dgPerkthime.GroupRowFormatStyle.BackColor = System.Drawing.Color.Empty;
			this.dgPerkthime.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
			this.dgPerkthime.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.dgPerkthime.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.InactiveCaptionText;
			this.dgPerkthime.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.dgPerkthime.LayoutData = @"<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Shqip""><AllowDrag>False</AllowDrag><AllowRemove>False</AllowRemove><Caption>Shqip</Caption><DataMember>Shqip</DataMember><Key>Shqip</Key><Position>0</Position><Width>214</Width></Column0><Column1 ID=""Anglisht""><AllowDrag>False</AllowDrag><Caption>Anglisht</Caption><DataMember>Anglisht</DataMember><Key>Anglisht</Key><Position>1</Position><Width>214</Width></Column1><Column2 ID=""Italisht""><Caption>Italisht</Caption><DataMember>Italisht</DataMember><Key>Italisht</Key><Position>2</Position><Width>214</Width></Column2><Column3 ID=""Frengjisht""><Caption>Frengjisht</Caption><DataMember>Frengjisht</DataMember><Key>Frengjisht</Key><Position>3</Position><Width>214</Width></Column3><Column4 ID=""Lloji""><DataMember>Lloji</DataMember><DefaultGroupPrefix /><Key>Lloji</Key><Position>4</Position><Visible>False</Visible><Width>8</Width></Column4></Columns><GroupCondition ID="""" /><Key>Perkthime</Key><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>0</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>";
			this.dgPerkthime.Location = new System.Drawing.Point(16, 24);
			this.dgPerkthime.Name = "dgPerkthime";
			this.dgPerkthime.Size = new System.Drawing.Size(856, 432);
			this.dgPerkthime.TabIndex = 1;
			this.dgPerkthime.ThemedAreas = Janus.Windows.GridEX.ThemedArea.ScrollBars;
			this.dgPerkthime.TreeLineColor = System.Drawing.SystemColors.Desktop;
			this.dgPerkthime.EditingCell += new Janus.Windows.GridEX.EditingCellEventHandler(this.dgPerkthime_EditingCell);
			// 
			// dsPerkthime
			// 
			this.dsPerkthime.DataSetName = "NewDataSet";
			this.dsPerkthime.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// gbPerkthime
			// 
			this.gbPerkthime.BackColor = System.Drawing.Color.Transparent;
			this.gbPerkthime.Controls.Add(this.dgPerkthime);
			this.gbPerkthime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbPerkthime.Location = new System.Drawing.Point(10, 42);
			this.gbPerkthime.Name = "gbPerkthime";
			this.gbPerkthime.Size = new System.Drawing.Size(900, 468);
			this.gbPerkthime.TabIndex = 2;
			this.gbPerkthime.Text = "Tabela e perkthimeve";
			this.gbPerkthime.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// btnRuaj
			// 
			this.btnRuaj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRuaj.DoValidation = true;
			this.btnRuaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRuaj.Location = new System.Drawing.Point(420, 520);
			this.btnRuaj.Name = "btnRuaj";
			this.btnRuaj.Size = new System.Drawing.Size(90, 21);
			this.btnRuaj.TabIndex = 2;
			this.btnRuaj.Text = "Ruaj";
			this.toolTips.SetToolTip(this.btnRuaj, "Ruan ndryshimet e bera ne tabelen e perkthimeve!");
			this.btnRuaj.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
			// 
			// Perkthime
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(936, 568);
			this.Controls.Add(this.gbPerkthime);
			this.Controls.Add(this.btnRuaj);
			this.HelpFile = "PERKTHIME.htm";
			this.Name = "Perkthime";
			this.Text = "Perkthime";
			this.Load += new System.EventHandler(this.Perkthime_Load);
			this.Controls.SetChildIndex(this.btnRuaj, 0);
			this.Controls.SetChildIndex(this.gbPerkthime, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			((System.ComponentModel.ISupportInitialize)(this.dgPerkthime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPerkthime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gbPerkthime)).EndInit();
			this.gbPerkthime.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region EventHandlers
		private void Perkthime_Load(object sender, System.EventArgs e)
		{
			gjuha = "";
			InputController data = new InputController();
			this.dsPerkthime = data.KerkesaRead("ShfaqPerkthime");
			this.dgPerkthime.DataSource = dsPerkthime.Tables[0];
			this.dgPerkthime.RootTable.DataMember = this.dsPerkthime.Tables[0].TableName;
			gjuha = this.dsPerkthime.Tables[1].Rows[0][0].ToString();
			switch (gjuha)
			{
				case "Shqip":
					this.gjuha = "Shqip";
					break;
				case "Anglisht":
					this.gjuha = "Anglisht";
					break;
				case "Italisht":
					this.gjuha = "Italisht";
					break;
				case "Frengjisht":
					this.gjuha = "Frengjisht";
					break;
			}
			this.dgPerkthime.RootTable.Groups.Add( new Janus.Windows.GridEX.GridEXGroup(
				this.dgPerkthime.RootTable.Columns["Lloji"]));
		}

		private void btnGjuha_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show(this, "Gjuha per printimin e faturave u ruajt",
				"Perkthime", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnRuaj_Click(object sender, System.EventArgs e)
		{
			this.dsPerkthime.Tables[1].Rows[0][0] = this.gjuha;
			this.dsPerkthime.WriteXml(Application.StartupPath + "\\Perkthime.xml", XmlWriteMode.WriteSchema);
			System.Windows.Forms.MessageBox.Show(this, "Perkthimet u ruajten", "Perkthime", 
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		/// <summary>
		/// Nese perdoruesi tenton te modifikoje kolonen shqip te vlerave atehere dil pa e lejuar
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgPerkthime_EditingCell(object sender, Janus.Windows.GridEX.EditingCellEventArgs e)
		{
			if (e.Column.Key == "Shqip")
				e.Cancel = true;
			return;
		}
		#endregion

	}
}

