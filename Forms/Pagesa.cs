using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using VisionInfoSolutionLibrary;
using System.Text.RegularExpressions;

namespace HotelManagment.Forms
{
	public class Pagesa : VisionInfoSolutionLibrary.Form
	{
		private VisionInfoSolutionLibrary.GroupBox gbKategorite;
		private VisionInfoSolutionLibrary.ComboBox comboBox1;
		private VisionInfoSolutionLibrary.ComboBox comboBox2;
		private VisionInfoSolutionLibrary.ComboBox comboBox3;
		private VisionInfoSolutionLibrary.ComboBox comboBox4;
		private VisionInfoSolutionLibrary.ComboBox comboBox5;
		private VisionInfoSolutionLibrary.ComboBox comboBox6;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.Label lblKategorite;
		private VisionInfoSolutionLibrary.Button btnModifiko;
		private VisionInfoSolutionLibrary.Button btnElemino;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.Label lblEmri;
		private VisionInfoSolutionLibrary.TextBox txtEmri;
		private VisionInfoSolutionLibrary.Button btnShto;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.DoubleCombo cmbPagesa;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.ListView lvPagesa;
		private System.Windows.Forms.ColumnHeader colEmri;
		private System.Windows.Forms.ColumnHeader colPerqindja;
		private VisionInfoSolutionLibrary.TextBox txtEmriMod;
		private VisionInfoSolutionLibrary.TextBox numPerqindja;
		private VisionInfoSolutionLibrary.TextBox numPerqindjaMod;
		private System.ComponentModel.IContainer components = null;
		#region Constructors & Destructors
		public Pagesa()
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
			this.gbKategorite = new VisionInfoSolutionLibrary.GroupBox();
			this.numPerqindjaMod = new VisionInfoSolutionLibrary.TextBox();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.cmbPagesa = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox1 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox2 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox3 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox4 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox5 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox6 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.txtEmriMod = new VisionInfoSolutionLibrary.TextBox();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.lblKategorite = new VisionInfoSolutionLibrary.Label();
			this.btnModifiko = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnElemino = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.numPerqindja = new VisionInfoSolutionLibrary.TextBox();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.lblEmri = new VisionInfoSolutionLibrary.Label();
			this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
			this.btnShto = new VisionInfoSolutionLibrary.Button(this.components);
			this.lvPagesa = new VisionInfoSolutionLibrary.ListView(this.components);
			this.colEmri = new System.Windows.Forms.ColumnHeader();
			this.colPerqindja = new System.Windows.Forms.ColumnHeader();
			((System.ComponentModel.ISupportInitialize)(this.gbKategorite)).BeginInit();
			this.gbKategorite.SuspendLayout();
			this.cmbPagesa.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			// 
			// gbKategorite
			// 
			this.gbKategorite.BackColor = System.Drawing.Color.Transparent;
			this.gbKategorite.Controls.Add(this.numPerqindjaMod);
			this.gbKategorite.Controls.Add(this.label1);
			this.gbKategorite.Controls.Add(this.cmbPagesa);
			this.gbKategorite.Controls.Add(this.txtEmriMod);
			this.gbKategorite.Controls.Add(this.label5);
			this.gbKategorite.Controls.Add(this.lblKategorite);
			this.gbKategorite.Controls.Add(this.btnModifiko);
			this.gbKategorite.Controls.Add(this.btnElemino);
			this.gbKategorite.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbKategorite.Location = new System.Drawing.Point(10, 272);
			this.gbKategorite.Name = "gbKategorite";
			this.gbKategorite.Size = new System.Drawing.Size(438, 128);
			this.gbKategorite.TabIndex = 19;
			this.gbKategorite.Text = "Modifikimi i formes se pagesave";
			this.gbKategorite.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// numPerqindjaMod
			// 
			this.numPerqindjaMod.AutoSize = false;
			this.numPerqindjaMod.BackColor = System.Drawing.Color.LemonChiffon;
			this.numPerqindjaMod.DefaultErrorMessage = "";
			this.numPerqindjaMod.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numPerqindjaMod.FixedLength = false;
			this.numPerqindjaMod.IsValid = true;
			this.numPerqindjaMod.Location = new System.Drawing.Point(132, 84);
			this.numPerqindjaMod.Name = "numPerqindjaMod";
			this.numPerqindjaMod.Required = false;
			this.numPerqindjaMod.RequiredControlColor = System.Drawing.Color.White;
			this.numPerqindjaMod.Size = new System.Drawing.Size(180, 21);
			this.numPerqindjaMod.TabIndex = 7;
			this.numPerqindjaMod.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 16;
			this.label1.Text = "Perqindja";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbPagesa
			// 
			this.cmbPagesa.BackColor = System.Drawing.Color.Transparent;
			this.cmbPagesa.Controls.Add(this.comboBox1);
			this.cmbPagesa.Controls.Add(this.comboBox2);
			this.cmbPagesa.Controls.Add(this.comboBox3);
			this.cmbPagesa.Controls.Add(this.comboBox4);
			this.cmbPagesa.Controls.Add(this.comboBox5);
			this.cmbPagesa.Controls.Add(this.comboBox6);
			this.cmbPagesa.DefaultErrorMessage = "Zghidhni nje prej kategorive para se te modifikoni!";
			this.cmbPagesa.IsValid = false;
			this.cmbPagesa.Kolone1Vlere = null;
			this.cmbPagesa.Kolone2Vlere = null;
			this.cmbPagesa.Location = new System.Drawing.Point(132, 20);
			this.cmbPagesa.Name = "cmbPagesa";
			this.cmbPagesa.ReadOnly = false;
			this.cmbPagesa.Required = true;
			this.cmbPagesa.Size = new System.Drawing.Size(180, 21);
			this.cmbPagesa.SkipValidation = true;
			this.cmbPagesa.TabIndex = 5;
			this.cmbPagesa.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbPagesa_SelectedIndexChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.DefaultErrorMessage = null;
			this.comboBox1.IsValid = false;
			this.comboBox1.Location = new System.Drawing.Point(108, 0);
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
			this.comboBox2.Size = new System.Drawing.Size(180, 21);
			this.comboBox2.TabIndex = 0;
			// 
			// comboBox3
			// 
			this.comboBox3.DefaultErrorMessage = null;
			this.comboBox3.IsValid = false;
			this.comboBox3.Location = new System.Drawing.Point(136, 0);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Required = false;
			this.comboBox3.Size = new System.Drawing.Size(16, 21);
			this.comboBox3.TabIndex = 1;
			this.comboBox3.Visible = false;
			// 
			// comboBox4
			// 
			this.comboBox4.DefaultErrorMessage = null;
			this.comboBox4.IsValid = false;
			this.comboBox4.Location = new System.Drawing.Point(0, 0);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Required = false;
			this.comboBox4.Size = new System.Drawing.Size(200, 21);
			this.comboBox4.TabIndex = 0;
			// 
			// comboBox5
			// 
			this.comboBox5.DefaultErrorMessage = null;
			this.comboBox5.IsValid = false;
			this.comboBox5.Location = new System.Drawing.Point(136, 0);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Required = false;
			this.comboBox5.Size = new System.Drawing.Size(16, 21);
			this.comboBox5.TabIndex = 1;
			this.comboBox5.Visible = false;
			// 
			// comboBox6
			// 
			this.comboBox6.DefaultErrorMessage = null;
			this.comboBox6.IsValid = false;
			this.comboBox6.Location = new System.Drawing.Point(0, 0);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Required = false;
			this.comboBox6.Size = new System.Drawing.Size(152, 21);
			this.comboBox6.TabIndex = 0;
			// 
			// txtEmriMod
			// 
			this.txtEmriMod.AutoSize = false;
			this.txtEmriMod.BackColor = System.Drawing.Color.LemonChiffon;
			this.txtEmriMod.DefaultErrorMessage = "Ju duhet te caktoni nje emer per kategorine para se te modifikoni!";
			this.txtEmriMod.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmriMod.FixedLength = false;
			this.txtEmriMod.IsValid = true;
			this.txtEmriMod.Location = new System.Drawing.Point(132, 52);
			this.txtEmriMod.Name = "txtEmriMod";
			this.txtEmriMod.Required = false;
			this.txtEmriMod.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmriMod.Size = new System.Drawing.Size(180, 21);
			this.txtEmriMod.TabIndex = 6;
			this.txtEmriMod.Text = "";
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(24, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 20);
			this.label5.TabIndex = 3;
			this.label5.Text = "Emri";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblKategorite
			// 
			this.lblKategorite.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblKategorite.Location = new System.Drawing.Point(4, 24);
			this.lblKategorite.Name = "lblKategorite";
			this.lblKategorite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblKategorite.Size = new System.Drawing.Size(120, 20);
			this.lblKategorite.TabIndex = 0;
			this.lblKategorite.Text = "Format ekzistuese";
			// 
			// btnModifiko
			// 
			this.btnModifiko.BackColor = System.Drawing.Color.Blue;
			this.btnModifiko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifiko.DoValidation = false;
			this.btnModifiko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifiko.Location = new System.Drawing.Point(332, 36);
			this.btnModifiko.Name = "btnModifiko";
			this.btnModifiko.Size = new System.Drawing.Size(88, 21);
			this.btnModifiko.TabIndex = 8;
			this.btnModifiko.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifiko, "Modifikon nje forme ekzistuese pagese!");
			this.btnModifiko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
			// 
			// btnElemino
			// 
			this.btnElemino.BackColor = System.Drawing.Color.Blue;
			this.btnElemino.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnElemino.DoValidation = false;
			this.btnElemino.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnElemino.Location = new System.Drawing.Point(332, 68);
			this.btnElemino.Name = "btnElemino";
			this.btnElemino.Size = new System.Drawing.Size(88, 21);
			this.btnElemino.TabIndex = 9;
			this.btnElemino.Text = "Elemino";
			this.toolTips.SetToolTip(this.btnElemino, "Eleminon nje forme ekzistuese pagese!");
			this.btnElemino.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnElemino.Click += new System.EventHandler(this.btnElemino_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.numPerqindja);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.lblEmri);
			this.groupBox2.Controls.Add(this.txtEmri);
			this.groupBox2.Controls.Add(this.btnShto);
			this.groupBox2.Controls.Add(this.lvPagesa);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 40);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(438, 228);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.Text = "Shtimi i nje forme te re pagese";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// numPerqindja
			// 
			this.numPerqindja.AutoSize = false;
			this.numPerqindja.BackColor = System.Drawing.Color.LemonChiffon;
			this.numPerqindja.DefaultErrorMessage = "";
			this.numPerqindja.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numPerqindja.FixedLength = false;
			this.numPerqindja.IsValid = true;
			this.numPerqindja.Location = new System.Drawing.Point(240, 96);
			this.numPerqindja.Name = "numPerqindja";
			this.numPerqindja.Required = false;
			this.numPerqindja.RequiredControlColor = System.Drawing.Color.White;
			this.numPerqindja.Size = new System.Drawing.Size(180, 21);
			this.numPerqindja.TabIndex = 3;
			this.numPerqindja.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(240, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 20);
			this.label2.TabIndex = 17;
			this.label2.Text = "Pagesa ne perqindje";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(12, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(180, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Format ekzistuese te pagesave";
			// 
			// lblEmri
			// 
			this.lblEmri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblEmri.Location = new System.Drawing.Point(240, 28);
			this.lblEmri.Name = "lblEmri";
			this.lblEmri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblEmri.Size = new System.Drawing.Size(180, 16);
			this.lblEmri.TabIndex = 1;
			this.lblEmri.Text = "Emri i formes se re te pageses";
			this.lblEmri.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtEmri
			// 
			this.txtEmri.AutoSize = false;
			this.txtEmri.BackColor = System.Drawing.Color.LemonChiffon;
			this.txtEmri.DefaultErrorMessage = "";
			this.txtEmri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri.FixedLength = false;
			this.txtEmri.IsValid = false;
			this.txtEmri.Location = new System.Drawing.Point(240, 44);
			this.txtEmri.Name = "txtEmri";
			this.txtEmri.Required = false;
			this.txtEmri.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri.Size = new System.Drawing.Size(180, 21);
			this.txtEmri.TabIndex = 2;
			this.txtEmri.Text = "";
			// 
			// btnShto
			// 
			this.btnShto.BackColor = System.Drawing.Color.Blue;
			this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShto.DoValidation = false;
			this.btnShto.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShto.Location = new System.Drawing.Point(288, 124);
			this.btnShto.Name = "btnShto";
			this.btnShto.Size = new System.Drawing.Size(90, 21);
			this.btnShto.TabIndex = 4;
			this.btnShto.Text = "Shto";
			this.toolTips.SetToolTip(this.btnShto, "Shton nje forme te re pagese!");
			this.btnShto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
			// 
			// lvPagesa
			// 
			this.lvPagesa.BackColor = System.Drawing.Color.White;
			this.lvPagesa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.colEmri,
																					   this.colPerqindja});
			this.lvPagesa.DefaultErrorMessage = "";
			this.lvPagesa.IsValid = true;
			this.lvPagesa.Location = new System.Drawing.Point(8, 36);
			this.lvPagesa.Name = "lvPagesa";
			this.lvPagesa.Size = new System.Drawing.Size(212, 180);
			this.lvPagesa.TabIndex = 1;
			this.lvPagesa.View = System.Windows.Forms.View.Details;
			// 
			// colEmri
			// 
			this.colEmri.Text = "Emri";
			this.colEmri.Width = 107;
			// 
			// colPerqindja
			// 
			this.colPerqindja.Text = "Perqindja";
			this.colPerqindja.Width = 100;
			// 
			// Pagesa
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(936, 520);
			this.Controls.Add(this.gbKategorite);
			this.Controls.Add(this.groupBox2);
			this.HelpFile = "PAGESA.htm";
			this.Name = "Pagesa";
			this.Text = "Pagesa";
			this.Load += new System.EventHandler(this.Pagesa_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			this.Controls.SetChildIndex(this.gbKategorite, 0);
			((System.ComponentModel.ISupportInitialize)(this.gbKategorite)).EndInit();
			this.gbKategorite.ResumeLayout(false);
			this.cmbPagesa.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Private Methods
		private void MbushPagesat()
		{
			this.lvPagesa.Items.Clear();
			this.cmbPagesa.Kolone1.Items.Clear();
			this.cmbPagesa.Kolone2.Items.Clear();
			this.cmbPagesa.Kolone1.Text = "";
			this.cmbPagesa.Kolone2.Text = "";
			InputController data  = new InputController();
			DataSet ds = data.KerkesaRead("ShfaqTeGjithaFormatEPageses");
			this.lvPagesa.View = View.Details;
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				string[] s = new string[2];
				ListViewItem item = new ListViewItem(dr["EMRI"].ToString());
				item.SubItems.Add(dr["PERQINDJA"].ToString() + "%");
				this.lvPagesa.Items.Add(item);
				this.cmbPagesa.Kolone1.Items.Add(dr["EMRI"]);
				this.cmbPagesa.Kolone2.Items.Add(dr["ID_FORMAPAGESA"]);
			}
		}
		#endregion

		#region Event Handlers
		private void Pagesa_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				this.MbushPagesat();
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

		private void btnShto_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				string emri = this.txtEmri.Text;
				string perqindja = this.numPerqindja.Text;
				double perqindjaDouble = 0;
				if (emri.Trim() == "")
				{
					this.error.SetError(this.txtEmri, "Jepni emrin e formes se pageses!");
					return;
				}
				this.error.SetError(this.txtEmri, "");
				if (perqindja.Trim() == "")
				{
					this.error.SetError(this.numPerqindja, "Jepni perqindjen e komisionit per formen e pageses!");
					return;
				}
				this.error.SetError(this.numPerqindja, "");
				try
				{
					perqindjaDouble = Convert.ToDouble(perqindja);
					if (perqindjaDouble < 0)
					{
						this.error.SetError(numPerqindja, "Vlera e komisionit duhet te jete vlere pozitive!");
						return;
					}
					this.error.SetError(numPerqindja, "");
				}
				catch(Exception ex)
				{
					this.error.SetError(numPerqindja, "Vlera e komisionit duhet te jete vlere numerike!");
					return;
				}				
				this.error.SetError(this.numPerqindja, "");
				bool ugjet = false;
				for(int i = 0; i< perqindja.Length; i++)
				{
					string ch = perqindja.Substring(i, 1);
					if (ch == ",")
					{
						ugjet = true;
						string tmp = perqindja.Substring(0, i) + "." + perqindja.Substring(i+1);
						perqindja = tmp;
						break;
					}
				}
				InputController data = new InputController();
				int b = data.KerkesaUpdate("ShtoFormePagese", emri, perqindja);
				if (b == 0)
				{
					//shtimi u krye ne rregull
					System.Windows.Forms.MessageBox.Show(this,  "Forma e re e pageses u shtua!", "Konfigurimi i formes se pagesave", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.MbushPagesat();
					this.txtEmri.Text = "";
					this.numPerqindja.Text = "";
					this.Pastro(gbKategorite);
				}
				else if (b == 2)
				{
					System.Windows.Forms.MessageBox.Show(this, "Forma e re e pageses nuk mund te shtohet!" + Environment.NewLine + "Ekziston tashme nje forme pagese me kete emer!" , "Konfigurimi i formes se pagesave", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				else
				{
					VisionInfoSolutionLibrary.MessageBox.Show(this, "Konfigurimi i formes se pagesave", "Forma e re e pageses nuk u shtua! Provoni perseri!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
		private void btnModifiko_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				if ((this.cmbPagesa.Kolone1.SelectedItem == null)||(this.cmbPagesa.Kolone1.Text == ""))
				{
					this.error.SetError(this.cmbPagesa, "Zgjidhni me pare nje prej formave ekzistuese te pagesave!");
					return;
				}
				this.error.SetError(this.cmbPagesa, "");
				int idFormaPagesa = Convert.ToInt32(this.cmbPagesa.Kolone2Vlere);
				string emri = this.txtEmriMod.Text;
				string perqindja = this.numPerqindjaMod.Text;
				if (emri.Trim() == "")
				{
					this.error.SetError(this.txtEmriMod, "Jepni emrin e formes se pageses!");
					return;
				}
				this.error.SetError(this.txtEmriMod, "");
				if (perqindja.Trim() == "")
				{
					this.error.SetError(this.numPerqindjaMod, "Jepni perqindjen e komisionit per formen e pageses!");
					return;
				}
				double perqindjaDouble = 0;
				try
				{
					perqindjaDouble = Convert.ToDouble(perqindja);
					if (perqindjaDouble < 0)
					{
						this.error.SetError(this.numPerqindjaMod, "Komisioni duhet te jete vlere pozitive!");
						return;
					}
					this.error.SetError(this.numPerqindjaMod, "");
				}
				catch(Exception ex)
				{
					this.error.SetError(this.numPerqindjaMod, "Komisioni duhet te jete vlere numerike!");
					return;
				}
				this.error.SetError(this.numPerqindjaMod, "");
				for(int i = 0; i< perqindja.Length; i++)
				{
					string ch = perqindja.Substring(i, 1);
					if (ch == ",")
					{
						string tmp = perqindja.Substring(0, i) + "." + perqindja.Substring(i+1);
						perqindja = tmp;
						break;
					}
				}
				if (idFormaPagesa == 1)
				{
					System.Windows.Forms.MessageBox.Show(this, "Nuk mund te modifikoni formen e pagesave Cash!", "Konfigurimi i formes se pagesave", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				InputController data = new InputController();
				int b = data.KerkesaUpdate("ModifikoFormePagese", idFormaPagesa, emri, perqindja);
				if (b == 0)
				{
					//modifikimi u krye ne rregull
					System.Windows.Forms.MessageBox.Show(this,  "Forma e pageses u modifikua!","Konfigurimi i formes se pagesave", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.MbushPagesat();
					this.txtEmriMod.Text = "";
					this.numPerqindjaMod.Text = "";
				}
				else if (b == 2)
				{
					System.Windows.Forms.MessageBox.Show(this, "Modifikimi i formes se pageses nuk mund te kryhet!" + Environment.NewLine + "Ekziston tashme nje forme pagese me kete emer!" , "Konfigurimi i formes se pagesave", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				else if (b == 3)
				{
					string s = "Modifikimi i formes se pageses nuk mund te kryhet!";
					s += Environment.NewLine + "Ne hotel jane kryer me pare pagesa me kete forme!";
					s += Environment.NewLine + "Per te ndryshuar komisionin krijoni nje forme te re pagese.";
					System.Windows.Forms.MessageBox.Show(this, s, "Konfigurimi i formes se pagesave", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				else
				{
					VisionInfoSolutionLibrary.MessageBox.Show(this, "Konfigurimi i formes se pagesave", "Forma e pageses nuk u modifikua! Provoni perseri!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
		private void btnElemino_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				if ((this.cmbPagesa.Kolone1.SelectedItem == null)||(this.cmbPagesa.Kolone1.Text == ""))
				{
					this.error.SetError(this.cmbPagesa, "Zgjidhni me pare nje prej formave ekzistuese te pagesave!");
					return;
				}
				this.error.SetError(this.cmbPagesa, "");
				int idFormaPagesa = Convert.ToInt32(this.cmbPagesa.Kolone2Vlere);
				string emri = this.cmbPagesa.Kolone1.Text;
				if (idFormaPagesa == 1)
				{
					System.Windows.Forms.MessageBox.Show(this, "Nuk mund te fshini formen e pageses " + emri + "!", "Konfigurimi i formes se pagesave", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				InputController data = new InputController();
				int b = data.KerkesaUpdate("FshiFormePagese", idFormaPagesa);
				if (b == 0)
				{
					//eleminimi u krye ne rregull
					System.Windows.Forms.MessageBox.Show(this,  "Forma e pageses u eleminua!", "Konfigurimi i formes se pagesave", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.MbushPagesat();
					this.txtEmriMod.Text = "";
					this.numPerqindjaMod.Text = "";
					this.cmbPagesa.Kolone1.Text = "";
					this.cmbPagesa.Kolone2.Text = "";
				}
				else if (b == 2)
				{
					System.Windows.Forms.MessageBox.Show(this, "Eleminimi i formes se pageses nuk mund te kryhet!" + Environment.NewLine + "Ne hotel jane kryer pagesa ne kete forme!" , "Konfigurimi i formes se pagesave", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				else
				{
					System.Windows.Forms.MessageBox.Show(this, "Forma e pageses nuk u eleminua! Provoni perseri!",  "Konfigurimi i formes se pagesave",MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

		private void cmbPagesa_SelectedIndexChanged(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				int idFormaPagesa = Convert.ToInt32(this.cmbPagesa.Kolone2Vlere);
				InputController data = new InputController();
				DataSet dsPagesa = data.KerkesaRead("ShfaqTeDhenaFormaPagesa", idFormaPagesa);
				this.txtEmriMod.Text = dsPagesa.Tables[0].Rows[0]["EMRI"].ToString();
				string perqindja = Convert.ToDouble(dsPagesa.Tables[0].Rows[0]["PERQINDJA"]).ToString();
				this.numPerqindjaMod.Text = perqindja;
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
	}
}

