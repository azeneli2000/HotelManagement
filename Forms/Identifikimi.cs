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
	public class frmIdentifikimi : VisionInfoSolutionLibrary.Form
	{
		private VisionInfoSolutionLibrary.GroupBox groupBox3;
		private VisionInfoSolutionLibrary.ListBox lbMjetet;
		private VisionInfoSolutionLibrary.Label label4;
		private VisionInfoSolutionLibrary.TextBox txtEmri1;
		private VisionInfoSolutionLibrary.Button btnShto1;
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.Button btnModifiko1;
		private VisionInfoSolutionLibrary.Button btnElemino1;
		private VisionInfoSolutionLibrary.DoubleCombo cmbMjetId;
		private VisionInfoSolutionLibrary.ComboBox comboBox1;
		private VisionInfoSolutionLibrary.ComboBox comboBox2;
		private VisionInfoSolutionLibrary.Label label6;
		private VisionInfoSolutionLibrary.TextBox txtEmriIdentifikimi;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Label label2;
		private System.ComponentModel.IContainer components = null;
		
		#region Constructors & Destructors
		public frmIdentifikimi()
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
			this.groupBox3 = new VisionInfoSolutionLibrary.GroupBox();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.lbMjetet = new VisionInfoSolutionLibrary.ListBox();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.txtEmri1 = new VisionInfoSolutionLibrary.TextBox();
			this.btnShto1 = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.btnModifiko1 = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnElemino1 = new VisionInfoSolutionLibrary.Button(this.components);
			this.cmbMjetId = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox1 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox2 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.txtEmriIdentifikimi = new VisionInfoSolutionLibrary.TextBox();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.cmbMjetId.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.lbMjetet);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.txtEmri1);
			this.groupBox3.Controls.Add(this.btnShto1);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(10, 40);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(438, 228);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.Text = "Shtimi i nje mjeti te ri identifikimi";
			this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(236, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Emri i llojit te identifikimit";
			// 
			// lbMjetet
			// 
			this.lbMjetet.DefaultErrorMessage = "";
			this.lbMjetet.IsValid = true;
			this.lbMjetet.Location = new System.Drawing.Point(12, 40);
			this.lbMjetet.Name = "lbMjetet";
			this.lbMjetet.Size = new System.Drawing.Size(204, 173);
			this.lbMjetet.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Location = new System.Drawing.Point(12, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Mjetet ekzistuese te identifikimit";
			// 
			// txtEmri1
			// 
			this.txtEmri1.AutoSize = false;
			this.txtEmri1.DefaultErrorMessage = "Ju duhet t\'i caktoni nje emer mjetit  te identifikimit perpara se ta shtoni!";
			this.txtEmri1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri1.FixedLength = false;
			this.txtEmri1.IsValid = false;
			this.txtEmri1.Location = new System.Drawing.Point(236, 52);
			this.txtEmri1.Name = "txtEmri1";
			this.txtEmri1.Required = true;
			this.txtEmri1.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri1.Size = new System.Drawing.Size(180, 21);
			this.txtEmri1.TabIndex = 6;
			this.txtEmri1.Text = "";
			// 
			// btnShto1
			// 
			this.btnShto1.BackColor = System.Drawing.Color.Blue;
			this.btnShto1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShto1.DoValidation = false;
			this.btnShto1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShto1.Location = new System.Drawing.Point(284, 84);
			this.btnShto1.Name = "btnShto1";
			this.btnShto1.Size = new System.Drawing.Size(90, 21);
			this.btnShto1.TabIndex = 7;
			this.btnShto1.Text = "Shto";
			this.toolTips.SetToolTip(this.btnShto1, "Shton nje menyre te re identifikimi!");
			this.btnShto1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShto1.Click += new System.EventHandler(this.btnShto1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.btnModifiko1);
			this.groupBox1.Controls.Add(this.btnElemino1);
			this.groupBox1.Controls.Add(this.cmbMjetId);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtEmriIdentifikimi);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(10, 272);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(438, 92);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.Text = "Modifikimi i mjeteve te identifikimit";
			this.toolTips.SetToolTip(this.groupBox1, "Eleminon nje menyre ekzistuese identifikimi!");
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// btnModifiko1
			// 
			this.btnModifiko1.BackColor = System.Drawing.Color.Blue;
			this.btnModifiko1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifiko1.DoValidation = false;
			this.btnModifiko1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifiko1.Location = new System.Drawing.Point(332, 20);
			this.btnModifiko1.Name = "btnModifiko1";
			this.btnModifiko1.Size = new System.Drawing.Size(90, 21);
			this.btnModifiko1.TabIndex = 10;
			this.btnModifiko1.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifiko1, "Modifikon nje menyre ekzistuese identiikimi!");
			this.btnModifiko1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifiko1.Click += new System.EventHandler(this.btnModifiko1_Click);
			// 
			// btnElemino1
			// 
			this.btnElemino1.BackColor = System.Drawing.Color.Blue;
			this.btnElemino1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnElemino1.DoValidation = false;
			this.btnElemino1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnElemino1.Location = new System.Drawing.Point(332, 56);
			this.btnElemino1.Name = "btnElemino1";
			this.btnElemino1.Size = new System.Drawing.Size(90, 21);
			this.btnElemino1.TabIndex = 11;
			this.btnElemino1.Text = "Elemino";
			this.btnElemino1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnElemino1.Click += new System.EventHandler(this.btnElemino1_Click);
			// 
			// cmbMjetId
			// 
			this.cmbMjetId.BackColor = System.Drawing.Color.Transparent;
			this.cmbMjetId.Controls.Add(this.comboBox1);
			this.cmbMjetId.Controls.Add(this.comboBox2);
			this.cmbMjetId.DefaultErrorMessage = "Zgjidhni nje prej mjeteve te identifikimit perpara se te modifikoni!";
			this.cmbMjetId.IsValid = false;
			this.cmbMjetId.Kolone1Vlere = null;
			this.cmbMjetId.Kolone2Vlere = null;
			this.cmbMjetId.Location = new System.Drawing.Point(132, 22);
			this.cmbMjetId.Name = "cmbMjetId";
			this.cmbMjetId.ReadOnly = false;
			this.cmbMjetId.Required = true;
			this.cmbMjetId.Size = new System.Drawing.Size(180, 21);
			this.cmbMjetId.SkipValidation = false;
			this.cmbMjetId.TabIndex = 8;
			this.cmbMjetId.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbMjetId_SelectedIndexChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.DefaultErrorMessage = null;
			this.comboBox1.IsValid = false;
			this.comboBox1.Location = new System.Drawing.Point(140, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Required = false;
			this.comboBox1.Size = new System.Drawing.Size(16, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Visible = false;
			// 
			// comboBox2
			// 
			this.comboBox2.DefaultErrorMessage = null;
			this.comboBox2.IsValid = false;
			this.comboBox2.Location = new System.Drawing.Point(0, 0);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Required = false;
			this.comboBox2.Size = new System.Drawing.Size(196, 21);
			this.comboBox2.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Location = new System.Drawing.Point(24, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 20);
			this.label6.TabIndex = 6;
			this.label6.Text = "Emri";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmriIdentifikimi
			// 
			this.txtEmriIdentifikimi.AutoSize = false;
			this.txtEmriIdentifikimi.BackColor = System.Drawing.Color.LemonChiffon;
			this.txtEmriIdentifikimi.DefaultErrorMessage = "Ju duhet te jepni  nje emer per mjetin para se te modifikoni!";
			this.txtEmriIdentifikimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmriIdentifikimi.FixedLength = false;
			this.txtEmriIdentifikimi.IsValid = false;
			this.txtEmriIdentifikimi.Location = new System.Drawing.Point(132, 56);
			this.txtEmriIdentifikimi.Name = "txtEmriIdentifikimi";
			this.txtEmriIdentifikimi.Required = true;
			this.txtEmriIdentifikimi.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmriIdentifikimi.Size = new System.Drawing.Size(180, 21);
			this.txtEmriIdentifikimi.TabIndex = 9;
			this.txtEmriIdentifikimi.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 20);
			this.label2.TabIndex = 14;
			this.label2.Text = "Mjetet e identifikimit";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmIdentifikimi
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(936, 520);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.HelpFile = "IDENTIFIKIM.htm";
			this.Name = "frmIdentifikimi";
			this.Text = "Identifikime";
			this.Load += new System.EventHandler(this.frmIdentifikimi_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.groupBox3, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.cmbMjetId.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region EventHandlers
		private void frmIdentifikimi_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				this.mbushMjeteIdentifikimi();
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

		private void btnShto1_Click(object sender, System.EventArgs e)
		{
			try
			{
				int b = 0 ;
				if (this.txtEmri1.Text == "")
				{
					this.error.SetError(txtEmri1, "Zgjidhni me pare nje prej mjeteve te identifikimit!");
					txtEmri1.IsValid = false;
					return;
				}
				txtEmri1.IsValid = true;
				this.error.SetError(txtEmri1, "");
				string identifikimi = this.txtEmri1.Text;
				InputController data = new InputController();
				b = data.KerkesaUpdate("KrijoLlojIdentifikimi",identifikimi);
				if(b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Mjeti i ri i identifikimit u shtua me sukses!", "Konfigurimi i mjeteve te identifikimit", 
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.mbushMjeteIdentifikimi();
					this.txtEmri1.Text = "";
				}
				else if (b == 1)
					System.Windows.Forms.MessageBox.Show(this,  "Emri i dhene eshte perdorur me pare."+Environment.NewLine+"Ju lutemi jepni nje emer te ri!","Konfigurimi i mjeteve te identifikimit", 
						MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void btnModifiko1_Click(object sender, System.EventArgs e)
		{
			try
			{
				int b = 0;
				if ((cmbMjetId.Kolone1.Text == "")||(cmbMjetId.Kolone1.SelectedItem == null))
				{
					this.error.SetError(cmbMjetId, "Zgjidhni me pare nje prej mjeteve te identifikimit!");
					cmbMjetId.IsValid = false;
					return;
				}
				this.error.SetError(cmbMjetId, "");
				cmbMjetId.IsValid = true;
				if (this.txtEmriIdentifikimi.Text == "")
				{
					this.error.SetError(txtEmriIdentifikimi, "Caktoni emrin e mjetit te identifikimit para se ta modifikoni!");
					return;
				}
				this.error.SetError(cmbMjetId, "");
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Konfigurimi i mjeteve te identifikimit",
					"Jeni te sigurte qe doni te modifikoni mjetin e zgjedhur?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result != DialogResult.Yes)
					return;
				int idIdentifikimi = Convert.ToInt32(this.cmbMjetId.Kolone2Vlere); ;
				string identifikimiIri = this.txtEmriIdentifikimi.Text;
				InputController data = new InputController();
				b = data.KerkesaUpdate("ModifikoLlojIdentifikimi", identifikimiIri, idIdentifikimi );
				if(b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Mjeti i identifikimit u modifikua!",  "Konfigurimi i Mjeteve te Identifikimit",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.mbushMjeteIdentifikimi();
				}
				else if (b == 1)
					System.Windows.Forms.MessageBox.Show(this,  "Emri i dhene eshte perdorur me pare."+Environment.NewLine+"Ju lutemi jepni nje emer te ri!","Konfigurimi i mjeteve te identifikimit", 
						MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void btnElemino1_Click(object sender, System.EventArgs e)
		{
			try
			{
				int b = 0 ;
				if ((cmbMjetId.Kolone1.Text == "")||(cmbMjetId.Kolone1.SelectedItem == null))
				{
					this.error.SetError(cmbMjetId, "Zgjidhni me pare nje prej mjeteve te identifikimit!)");
					cmbMjetId.IsValid = false;
					return;
				}
				this.error.SetError(cmbMjetId, "");
				cmbMjetId.IsValid = true;
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Konfigurimi i mjeteve te identifkimit",
					"Jeni të sigurte qe doni te eleminoni emrin e mjetit te identifikimit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result != DialogResult.Yes)
					return;
				int idMjetIdentifikimi = Convert.ToInt32(this.cmbMjetId.Kolone2Vlere);  // vlera merret nga kombo e mjeteve te identifikimit
				InputController data = new InputController();
				b = data.KerkesaUpdate("FshiMjetIdentifikimi", idMjetIdentifikimi );
				if(b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this, "Mjeti i identifikimit i zgjedhur u eleminua.", "Konfigurimi i mjeteve te identifikimit" ,
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.RefreshMjetIdentifikimi();
				}
				else if (b == 1)
					System.Windows.Forms.MessageBox.Show(this,  "Mjeti i identifikimit i dhene nuk mund te eleminohet." + Environment.NewLine + "Ekzistojne kliente te regjistruar me kete mjet identifikimi!","Konfigurimi i Mjeteve te Identifikimit", 
						MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		
		private void cmbMjetId_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				txtEmriIdentifikimi.Text = cmbMjetId.Kolone1.Text;
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

		#region PrivateMethods
		private void mbushMjeteIdentifikimi()
		{
			this.lbMjetet.Items.Clear();
			this.cmbMjetId.Kolone1.Text = this.txtEmriIdentifikimi.Text;
			this.cmbMjetId.Kolone1.Items.Clear();
			this.cmbMjetId.Kolone2.Items.Clear();
			DataSet ds = null ;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqMjeteIdentifikimi");
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.lbMjetet.Items.Add(dr[1]);
				this.cmbMjetId.Kolone1.Items.Add(dr[1]);
				this.cmbMjetId.Kolone2.Items.Add(dr[0]);
			}
		}

		private void RefreshMjetIdentifikimi()
		{
			this.lbMjetet.Items.Clear();
			this.cmbMjetId.Kolone1.Text = "";
			this.txtEmriIdentifikimi.Text = "";
			this.cmbMjetId.Kolone1.Items.Clear();
			this.cmbMjetId.Kolone2.Items.Clear();
			DataSet ds = null ;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqMjeteIdentifikimi");
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.lbMjetet.Items.Add(dr[1]);
				this.cmbMjetId.Kolone1.Items.Add(dr[1]);
				this.cmbMjetId.Kolone2.Items.Add(dr[0]);
			}
		}
		#endregion
	
	}
}

