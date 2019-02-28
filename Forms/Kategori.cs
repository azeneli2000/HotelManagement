using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using VisionInfoSolutionLibrary;
//using Cells = SourceGrid2.Cells.Real;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment
{
	/// <summary>
	/// Summary description for Kategori.
	/// </summary>
	public class Kategori : VisionInfoSolutionLibrary.Form
	{
		#region Private Variables
		private VisionInfoSolutionLibrary.ListBox lbDhomat1;
		private VisionInfoSolutionLibrary.ListBox lbDhomat2;
		private VisionInfoSolutionLibrary.NumericBox numCmimi;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.ListBox lbKategorite;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.Label lblEmri;
		private VisionInfoSolutionLibrary.TextBox txtEmri;
		private VisionInfoSolutionLibrary.Button btnShto;
		private VisionInfoSolutionLibrary.GroupBox gbKategorite;
		private VisionInfoSolutionLibrary.Button btnModifiko;
		private VisionInfoSolutionLibrary.Button btnElemino;
		private VisionInfoSolutionLibrary.DoubleCombo cmbKategorite;
		private VisionInfoSolutionLibrary.ComboBox comboBox1;
		private VisionInfoSolutionLibrary.ComboBox comboBox2;
		private VisionInfoSolutionLibrary.ComboBox comboBox3;
		private VisionInfoSolutionLibrary.ComboBox comboBox4;
		private VisionInfoSolutionLibrary.TextBox txtEmriKategoria;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.Label lblKategorite;
		private System.ComponentModel.IContainer components;
		#endregion

		#region Constructors & Destructors
		public Kategori()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.numCmimi = new VisionInfoSolutionLibrary.NumericBox();
			this.lbDhomat2 = new VisionInfoSolutionLibrary.ListBox();
			this.lbDhomat1 = new VisionInfoSolutionLibrary.ListBox();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.lbKategorite = new VisionInfoSolutionLibrary.ListBox();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.lblEmri = new VisionInfoSolutionLibrary.Label();
			this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
			this.btnShto = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbKategorite = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbKategorite = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox1 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox2 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox3 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox4 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.txtEmriKategoria = new VisionInfoSolutionLibrary.TextBox();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.lblKategorite = new VisionInfoSolutionLibrary.Label();
			this.btnModifiko = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnElemino = new VisionInfoSolutionLibrary.Button(this.components);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbKategorite)).BeginInit();
			this.gbKategorite.SuspendLayout();
			this.cmbKategorite.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(860, 24);
			// 
			// numCmimi
			// 
			this.numCmimi.AutoSize = false;
			this.numCmimi.DefaultErrorMessage = "";
			this.numCmimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numCmimi.DigitsAfterDecimalPoint = 0;
			this.numCmimi.FixedLength = false;
			this.numCmimi.IsValid = true;
			this.numCmimi.KeepFocus = false;
			this.numCmimi.Location = new System.Drawing.Point(100, 68);
			this.numCmimi.Name = "numCmimi";
			this.numCmimi.OnlyPositive = true;
			this.numCmimi.Required = false;
			this.numCmimi.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimi.Size = new System.Drawing.Size(120, 20);
			this.numCmimi.TabIndex = 12;
			this.numCmimi.Text = "";
			this.numCmimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbDhomat2
			// 
			this.lbDhomat2.DefaultErrorMessage = "";
			this.lbDhomat2.IsValid = true;
			this.lbDhomat2.Location = new System.Drawing.Point(384, 140);
			this.lbDhomat2.Name = "lbDhomat2";
			this.lbDhomat2.Size = new System.Drawing.Size(180, 199);
			this.lbDhomat2.TabIndex = 9;
			// 
			// lbDhomat1
			// 
			this.lbDhomat1.DefaultErrorMessage = "";
			this.lbDhomat1.IsValid = true;
			this.lbDhomat1.Location = new System.Drawing.Point(40, 136);
			this.lbDhomat1.Name = "lbDhomat1";
			this.lbDhomat1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbDhomat1.Size = new System.Drawing.Size(180, 199);
			this.lbDhomat1.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.lbKategorite);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.lblEmri);
			this.groupBox2.Controls.Add(this.txtEmri);
			this.groupBox2.Controls.Add(this.btnShto);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 40);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(438, 228);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.Text = "Shtimi i nje kategorie te re";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// lbKategorite
			// 
			this.lbKategorite.DefaultErrorMessage = "";
			this.lbKategorite.IsValid = true;
			this.lbKategorite.Location = new System.Drawing.Point(12, 36);
			this.lbKategorite.Name = "lbKategorite";
			this.lbKategorite.Size = new System.Drawing.Size(204, 173);
			this.lbKategorite.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(12, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Kategorite ekzistuese";
			// 
			// lblEmri
			// 
			this.lblEmri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblEmri.Location = new System.Drawing.Point(240, 24);
			this.lblEmri.Name = "lblEmri";
			this.lblEmri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblEmri.Size = new System.Drawing.Size(120, 16);
			this.lblEmri.TabIndex = 1;
			this.lblEmri.Text = "Emri i kategorise se re";
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
			this.btnShto.Location = new System.Drawing.Point(292, 76);
			this.btnShto.Name = "btnShto";
			this.btnShto.Size = new System.Drawing.Size(90, 21);
			this.btnShto.TabIndex = 3;
			this.btnShto.Text = "Shto";
			this.toolTips.SetToolTip(this.btnShto, "Shton nje kategori te re dhomash!");
			this.btnShto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShto.Click += new System.EventHandler(this.btnRuaj_Click);
			// 
			// gbKategorite
			// 
			this.gbKategorite.BackColor = System.Drawing.Color.Transparent;
			this.gbKategorite.Controls.Add(this.cmbKategorite);
			this.gbKategorite.Controls.Add(this.txtEmriKategoria);
			this.gbKategorite.Controls.Add(this.label5);
			this.gbKategorite.Controls.Add(this.lblKategorite);
			this.gbKategorite.Controls.Add(this.btnModifiko);
			this.gbKategorite.Controls.Add(this.btnElemino);
			this.gbKategorite.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbKategorite.Location = new System.Drawing.Point(10, 272);
			this.gbKategorite.Name = "gbKategorite";
			this.gbKategorite.Size = new System.Drawing.Size(438, 92);
			this.gbKategorite.TabIndex = 17;
			this.gbKategorite.Text = "Modifikimi i kategorive";
			this.gbKategorite.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbKategorite
			// 
			this.cmbKategorite.BackColor = System.Drawing.Color.LemonChiffon;
			this.cmbKategorite.Controls.Add(this.comboBox1);
			this.cmbKategorite.Controls.Add(this.comboBox2);
			this.cmbKategorite.Controls.Add(this.comboBox3);
			this.cmbKategorite.Controls.Add(this.comboBox4);
			this.cmbKategorite.DefaultErrorMessage = "Zghidhni nje prej kategorive para se te modifikoni!";
			this.cmbKategorite.IsValid = false;
			this.cmbKategorite.Kolone1Vlere = null;
			this.cmbKategorite.Kolone2Vlere = null;
			this.cmbKategorite.Location = new System.Drawing.Point(132, 20);
			this.cmbKategorite.Name = "cmbKategorite";
			this.cmbKategorite.ReadOnly = false;
			this.cmbKategorite.Required = true;
			this.cmbKategorite.Size = new System.Drawing.Size(180, 21);
			this.cmbKategorite.SkipValidation = true;
			this.cmbKategorite.TabIndex = 4;
			this.cmbKategorite.TabStop = false;
			this.cmbKategorite.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbKategorite_SelectedIndexChanged_1);
			// 
			// comboBox1
			// 
			this.comboBox1.DefaultErrorMessage = null;
			this.comboBox1.IsValid = false;
			this.comboBox1.Location = new System.Drawing.Point(136, 0);
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
			this.comboBox2.Size = new System.Drawing.Size(200, 21);
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
			this.comboBox4.Size = new System.Drawing.Size(152, 21);
			this.comboBox4.TabIndex = 0;
			// 
			// txtEmriKategoria
			// 
			this.txtEmriKategoria.AutoSize = false;
			this.txtEmriKategoria.BackColor = System.Drawing.Color.LemonChiffon;
			this.txtEmriKategoria.DefaultErrorMessage = "Ju duhet te caktoni nje emer per kategorine para se te modifikoni!";
			this.txtEmriKategoria.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmriKategoria.FixedLength = false;
			this.txtEmriKategoria.IsValid = false;
			this.txtEmriKategoria.Location = new System.Drawing.Point(132, 52);
			this.txtEmriKategoria.Name = "txtEmriKategoria";
			this.txtEmriKategoria.Required = true;
			this.txtEmriKategoria.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmriKategoria.Size = new System.Drawing.Size(180, 21);
			this.txtEmriKategoria.TabIndex = 5;
			this.txtEmriKategoria.Text = "";
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
			this.lblKategorite.Text = "Kategorite ekzistuese";
			// 
			// btnModifiko
			// 
			this.btnModifiko.BackColor = System.Drawing.Color.Blue;
			this.btnModifiko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifiko.DoValidation = false;
			this.btnModifiko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifiko.Location = new System.Drawing.Point(328, 20);
			this.btnModifiko.Name = "btnModifiko";
			this.btnModifiko.Size = new System.Drawing.Size(88, 21);
			this.btnModifiko.TabIndex = 6;
			this.btnModifiko.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifiko, "Modifikon nje kategori ekzistuese!");
			this.btnModifiko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click_1);
			// 
			// btnElemino
			// 
			this.btnElemino.BackColor = System.Drawing.Color.Blue;
			this.btnElemino.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnElemino.DoValidation = false;
			this.btnElemino.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnElemino.Location = new System.Drawing.Point(328, 52);
			this.btnElemino.Name = "btnElemino";
			this.btnElemino.Size = new System.Drawing.Size(88, 21);
			this.btnElemino.TabIndex = 7;
			this.btnElemino.Text = "Elemino";
			this.toolTips.SetToolTip(this.btnElemino, "Eleminon nje kategori ekzistuese!");
			this.btnElemino.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnElemino.Click += new System.EventHandler(this.btnElemino_Click);
			// 
			// Kategori
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(860, 544);
			this.Controls.Add(this.gbKategorite);
			this.Controls.Add(this.groupBox2);
			this.HelpFile = "KATEGORI.htm";
			this.Name = "Kategori";
			this.Text = "Kategori";
			this.TitullGjeresi = 860;
			this.Load += new System.EventHandler(this.Kategori_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			this.Controls.SetChildIndex(this.gbKategorite, 0);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbKategorite)).EndInit();
			this.gbKategorite.ResumeLayout(false);
			this.cmbKategorite.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region LoadForm
		private void Kategori_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				this.mbushKategorite();
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
		
		#endregion

		#region EventHandlers
		private void btnRuaj_Click(object sender, System.EventArgs e)
		{   
			this.Cursor = Cursors.WaitCursor;
			try
			{
				int b = 0 ;
				string kategori = this.txtEmri.Text;
				if(kategori == "")
				{
					this.txtEmri.IsValid = false;
					this.txtEmri.Required = true;
					this.error.SetError(this.txtEmri,"Ju duhet te jepni nje emer per kategorine perpara se ta shtoni!!");
				}
				else
				{
					InputController data = new InputController();
					b = data.KerkesaUpdate("KrijoKategori",kategori);
					if(b == 0)
					{
						System.Windows.Forms.MessageBox.Show(this, "Emri i kategorise se re u shtua me sukses",  "Konfigurimi i kategorive",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.txtEmri.Text = "";
						this.txtEmri.IsValid = true;
						this.error.SetError(txtEmri, "");
						this.mbushKategorite();
					}
					else if (b == 1)
						System.Windows.Forms.MessageBox.Show(this, "Emri i kategorise se re eshte perdorur me pare."+Environment.NewLine+"Ju lutemi jepni nje emer te ri!", "Konfigurimi i kategorive",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
			
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

		private void btnModifiko_Click_1(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				int b = 0 ;
				string emriKategoria = this.txtEmriKategoria.Text;
				if ((this.cmbKategorite.Kolone1.Text == "")||(this.cmbKategorite.Kolone1.SelectedItem == null))
				{
					this.cmbKategorite.IsValid = false;
					this.error.SetError(this.cmbKategorite,"Ju duhet te zgjidhni kategorine perpara se te modifikoni!");
					return;
				}
				else
				{
					this.error.SetError(this.cmbKategorite,"");
					int idKategoria = Convert.ToInt32(this.cmbKategorite.Kolone2Vlere);
					if(emriKategoria == "")
					{
						this.txtEmriKategoria.IsValid = false;
						this.txtEmriKategoria.Required = true;
						this.error.SetError(this.txtEmriKategoria,"Ju duhet te jepni emrin e kategorise se re!");
						return;
					}
					else
					{
						if (idKategoria == 31)
						{
							System.Windows.Forms.MessageBox.Show(this, "Kategoria e dhomave me ore nuk mund te modifikohet!", "Konfigurimi i kategorive",MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
						this.error.SetError(this.txtEmriKategoria,"");
						DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Konfigurimi i kategorive",
							"Jeni te sigurte qe doni te modifikoni emrin e kategorise?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (result != DialogResult.Yes)
							return;
						string kategoriaEre = this.txtEmriKategoria.Text;
						InputController data = new InputController();
						b = data.KerkesaUpdate("ModifikoKategori",kategoriaEre, idKategoria );
						if(b == 0)
						{
							System.Windows.Forms.MessageBox.Show(this,  "Emri per kategorine e dhene u modifikua!", "Konfigurimi i kategorive",
								MessageBoxButtons.OK, MessageBoxIcon.Information);
							this.mbushKategorite();
						}
						else if (b == 1)
							System.Windows.Forms.MessageBox.Show(this, "Emri i kategorise se re eshte perdorur me pare."+Environment.NewLine+"Ju lutemi jepni nje emer te ri!",  "Konfigurimi i kategorive",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
			
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
				this.Cursor = Cursors.Default;
			}
		}

		private void btnElemino_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				int b = 0 ;
				if (this.cmbKategorite.Kolone1.SelectedItem == null)
				{
					this.error.SetError(this.cmbKategorite,"Ju duhet te zgjidhni kategorine perpara se te modifikoni!");
					this.cmbKategorite.IsValid = false;
					return;
				}
				this.error.SetError(this.cmbKategorite,"");
				int idKategoria = Convert.ToInt32(this.cmbKategorite.Kolone2Vlere);  // vlera merret nga kombo e kategorive
				if(idKategoria == 0 )
				{
					this.cmbKategorite.IsValid = false;
					this.cmbKategorite.Required = true;
					this.error.SetError(this.cmbKategorite,"Ju duhet te zgjidhni kategorine perpara se te modifikoni!");
					return;
				}
				else
				{
					if (idKategoria == 31)
					{
						System.Windows.Forms.MessageBox.Show(this, "Kategoria e dhomave me ore nuk mund te eleminohet!", "Konfigurimi i kategorive", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Konfigurimi i kategorive",
						"Jeni te sigurte qe doni te eleminoni kategorine e zgjedhur?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result != DialogResult.Yes)
						return;
					this.error.SetError(this.cmbKategorite,"");
					InputController data = new InputController();
					b = data.KerkesaUpdate("FshiKategori", idKategoria );
					if(b == 0)
					{
					
						System.Windows.Forms.MessageBox.Show(this, "Kategoria e zgjedhur u eleminua!",  "Konfigurimi i kategorive",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.RefreshKategorite();
					}
					else if (b == 1)
					{
						System.Windows.Forms.MessageBox.Show(this, "Kategoria e zgjedhur nuk mund te eleminohet. " + Environment.NewLine + "Per kete kategori ekzistojne dhoma te konfiguruara!", 
							"Konfigurimi i kategorive", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				this.Cursor = Cursors.Default;
			}
		}

		private void cmbKategorite_SelectedIndexChanged_1(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				this.txtEmriKategoria.Text = this.cmbKategorite.Kolone1.Text;
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
		private void RefreshKategorite()
		{
			this.lbKategorite.Items.Clear();
			this.cmbKategorite.Kolone1.Text = "";
			this.txtEmriKategoria.Text = "";
			this.cmbKategorite.Kolone1.Items.Clear();
			this.cmbKategorite.Kolone2.Items.Clear();
			DataSet ds = null ;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqKategorite");
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				this.lbKategorite.Items.Add(dr[1]);
				this.cmbKategorite.Kolone1.Items.Add(dr[1]);
				this.cmbKategorite.Kolone2.Items.Add(dr[0]);
			}
		}
		
		private void mbushKategorite()
		{
			this.lbKategorite.Items.Clear();
			this.cmbKategorite.Kolone1.Text = this.txtEmriKategoria.Text;
			this.cmbKategorite.Kolone1.Items.Clear();
			this.cmbKategorite.Kolone2.Items.Clear();
			DataSet ds = null ;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqKategorite");
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				this.lbKategorite.Items.Add(dr[1]);
				this.cmbKategorite.Kolone1.Items.Add(dr[1]);
				this.cmbKategorite.Kolone2.Items.Add(dr[0]);
			}
		}

		#endregion 
	}
}
