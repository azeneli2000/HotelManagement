using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using VisionInfoSolutionLibrary;
using Cells = SourceGrid2.Cells.Real;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace HotelManagment.Forms
{
	public class Detyrimet : VisionInfoSolutionLibrary.Form
	{
		#region Private Variables
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Label lblEmri;
		private VisionInfoSolutionLibrary.TextBox txtDetyrimi;
		private VisionInfoSolutionLibrary.NumericBox numCmimi;
		private VisionInfoSolutionLibrary.Button btnElemino;
		private VisionInfoSolutionLibrary.Button btnModifiko;
		private VisionInfoSolutionLibrary.Button btnShto;
		private VisionInfoSolutionLibrary.GroupBox groupBox3;
		private VisionInfoSolutionLibrary.ListBox lbDetyrimet;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.DoubleCombo cmbDetyrime;
		private VisionInfoSolutionLibrary.ComboBox comboBox1;
		private VisionInfoSolutionLibrary.ComboBox comboBox2;
		private VisionInfoSolutionLibrary.Label label4;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.TextBox txtEmriModifiko;
		private VisionInfoSolutionLibrary.NumericBox numCmimiModifiko;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.Label label5;
		private System.ComponentModel.IContainer components = null;
		#endregion

		#region Constructors and Destructors
		public Detyrimet()
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
			this.numCmimi = new VisionInfoSolutionLibrary.NumericBox();
			this.txtDetyrimi = new VisionInfoSolutionLibrary.TextBox();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.lblEmri = new VisionInfoSolutionLibrary.Label();
			this.btnShto = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnModifiko = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnElemino = new VisionInfoSolutionLibrary.Button(this.components);
			this.groupBox3 = new VisionInfoSolutionLibrary.GroupBox();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.lbDetyrimet = new VisionInfoSolutionLibrary.ListBox();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.cmbDetyrime = new VisionInfoSolutionLibrary.DoubleCombo();
			this.comboBox1 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.comboBox2 = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.txtEmriModifiko = new VisionInfoSolutionLibrary.TextBox();
			this.numCmimiModifiko = new VisionInfoSolutionLibrary.NumericBox();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.cmbDetyrime.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(936, 25);
			// 
			// numCmimi
			// 
			this.numCmimi.AutoSize = false;
			this.numCmimi.BackColor = System.Drawing.Color.LemonChiffon;
			this.numCmimi.DefaultErrorMessage = "Ju duhet te caktoni nje cmim per detyrimin!";
			this.numCmimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numCmimi.DigitsAfterDecimalPoint = 0;
			this.numCmimi.FixedLength = false;
			this.numCmimi.IsValid = false;
			this.numCmimi.KeepFocus = false;
			this.numCmimi.Location = new System.Drawing.Point(248, 84);
			this.numCmimi.Name = "numCmimi";
			this.numCmimi.OnlyPositive = true;
			this.numCmimi.Required = false;
			this.numCmimi.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimi.Size = new System.Drawing.Size(200, 21);
			this.numCmimi.TabIndex = 3;
			this.numCmimi.Text = "";
			this.numCmimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtDetyrimi
			// 
			this.txtDetyrimi.AutoSize = false;
			this.txtDetyrimi.BackColor = System.Drawing.Color.LemonChiffon;
			this.txtDetyrimi.DefaultErrorMessage = "Ju duhet t\'i caktoni nje emer detyrimit!";
			this.txtDetyrimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtDetyrimi.FixedLength = false;
			this.txtDetyrimi.IsValid = false;
			this.txtDetyrimi.Location = new System.Drawing.Point(248, 36);
			this.txtDetyrimi.Name = "txtDetyrimi";
			this.txtDetyrimi.Required = false;
			this.txtDetyrimi.RequiredControlColor = System.Drawing.Color.White;
			this.txtDetyrimi.Size = new System.Drawing.Size(200, 21);
			this.txtDetyrimi.TabIndex = 2;
			this.txtDetyrimi.Text = "";
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(248, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Cmimi per njesi";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lblEmri
			// 
			this.lblEmri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmri.Location = new System.Drawing.Point(248, 20);
			this.lblEmri.Name = "lblEmri";
			this.lblEmri.Size = new System.Drawing.Size(72, 16);
			this.lblEmri.TabIndex = 7;
			this.lblEmri.Text = "Emri";
			this.lblEmri.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// btnShto
			// 
			this.btnShto.BackColor = System.Drawing.Color.Blue;
			this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnShto.DoValidation = false;
			this.btnShto.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnShto.Location = new System.Drawing.Point(304, 124);
			this.btnShto.Name = "btnShto";
			this.btnShto.Size = new System.Drawing.Size(90, 21);
			this.btnShto.TabIndex = 4;
			this.btnShto.Text = "Shto";
			this.toolTips.SetToolTip(this.btnShto, "Shton nje lloj te ri detyrimi!");
			this.btnShto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
			// 
			// btnModifiko
			// 
			this.btnModifiko.BackColor = System.Drawing.Color.Blue;
			this.btnModifiko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifiko.DoValidation = false;
			this.btnModifiko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnModifiko.Location = new System.Drawing.Point(312, 32);
			this.btnModifiko.Name = "btnModifiko";
			this.btnModifiko.Size = new System.Drawing.Size(90, 21);
			this.btnModifiko.TabIndex = 8;
			this.btnModifiko.Text = "Modifiko";
			this.toolTips.SetToolTip(this.btnModifiko, "Modifikon llojet ekzistuese te detyrimeve!");
			this.btnModifiko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click_1);
			// 
			// btnElemino
			// 
			this.btnElemino.BackColor = System.Drawing.Color.Blue;
			this.btnElemino.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnElemino.DoValidation = false;
			this.btnElemino.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnElemino.Location = new System.Drawing.Point(312, 64);
			this.btnElemino.Name = "btnElemino";
			this.btnElemino.Size = new System.Drawing.Size(90, 21);
			this.btnElemino.TabIndex = 9;
			this.btnElemino.Text = "Elemino";
			this.toolTips.SetToolTip(this.btnElemino, "Eleminon llojet ekzistuese te detyrimeve!");
			this.btnElemino.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnElemino.Click += new System.EventHandler(this.btnElemino_Click_1);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.lbDetyrimet);
			this.groupBox3.Controls.Add(this.numCmimi);
			this.groupBox3.Controls.Add(this.txtDetyrimi);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.lblEmri);
			this.groupBox3.Controls.Add(this.btnShto);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(10, 40);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(466, 224);
			this.groupBox3.TabIndex = 21;
			this.groupBox3.Text = "Shtimi i nje detyrimi te ri";
			this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(184, 20);
			this.label5.TabIndex = 22;
			this.label5.Text = "Detyrimet ekzistuese";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lbDetyrimet
			// 
			this.lbDetyrimet.DefaultErrorMessage = "";
			this.lbDetyrimet.IsValid = true;
			this.lbDetyrimet.Location = new System.Drawing.Point(12, 36);
			this.lbDetyrimet.Name = "lbDetyrimet";
			this.lbDetyrimet.Size = new System.Drawing.Size(204, 173);
			this.lbDetyrimet.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.cmbDetyrime);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtEmriModifiko);
			this.groupBox2.Controls.Add(this.numCmimiModifiko);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.btnModifiko);
			this.groupBox2.Controls.Add(this.btnElemino);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 268);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(466, 116);
			this.groupBox2.TabIndex = 28;
			this.groupBox2.Text = "Modifikimi i detyrimeve ekzistuese";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// cmbDetyrime
			// 
			this.cmbDetyrime.BackColor = System.Drawing.Color.LemonChiffon;
			this.cmbDetyrime.Controls.Add(this.comboBox1);
			this.cmbDetyrime.Controls.Add(this.comboBox2);
			this.cmbDetyrime.DefaultErrorMessage = "Ju duhet te zgjidhni nje lloj detyrimi perpara se te modifikoni!";
			this.cmbDetyrime.IsValid = false;
			this.cmbDetyrime.Kolone1Vlere = null;
			this.cmbDetyrime.Kolone2Vlere = null;
			this.cmbDetyrime.Location = new System.Drawing.Point(92, 16);
			this.cmbDetyrime.Name = "cmbDetyrime";
			this.cmbDetyrime.ReadOnly = false;
			this.cmbDetyrime.Required = true;
			this.cmbDetyrime.Size = new System.Drawing.Size(200, 21);
			this.cmbDetyrime.SkipValidation = false;
			this.cmbDetyrime.TabIndex = 5;
			this.cmbDetyrime.SelectedIndexChanged += new VisionInfoSolutionLibrary.SelectedIndexChangedEventHandler(this.cmbDetyrime_SelectedIndexChanged_2);
			// 
			// comboBox1
			// 
			this.comboBox1.DefaultErrorMessage = null;
			this.comboBox1.IsValid = false;
			this.comboBox1.Location = new System.Drawing.Point(68, 0);
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
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Location = new System.Drawing.Point(28, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 20);
			this.label4.TabIndex = 17;
			this.label4.Text = "Emri";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(16, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 20);
			this.label2.TabIndex = 21;
			this.label2.Text = "Detyrimet";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmriModifiko
			// 
			this.txtEmriModifiko.AutoSize = false;
			this.txtEmriModifiko.BackColor = System.Drawing.Color.LemonChiffon;
			this.txtEmriModifiko.DefaultErrorMessage = "Ju duhet t\'i caktoni nje emer detyrimit perpara se ta modifikoni!";
			this.txtEmriModifiko.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmriModifiko.FixedLength = false;
			this.txtEmriModifiko.IsValid = false;
			this.txtEmriModifiko.Location = new System.Drawing.Point(92, 44);
			this.txtEmriModifiko.Name = "txtEmriModifiko";
			this.txtEmriModifiko.Required = false;
			this.txtEmriModifiko.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmriModifiko.Size = new System.Drawing.Size(200, 21);
			this.txtEmriModifiko.TabIndex = 6;
			this.txtEmriModifiko.Text = "";
			// 
			// numCmimiModifiko
			// 
			this.numCmimiModifiko.AutoSize = false;
			this.numCmimiModifiko.BackColor = System.Drawing.Color.LemonChiffon;
			this.numCmimiModifiko.DefaultErrorMessage = "Ju duhet t\'i caktoni nje cmim detyrimit perpara se ta modifikoni!";
			this.numCmimiModifiko.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.numCmimiModifiko.DigitsAfterDecimalPoint = 0;
			this.numCmimiModifiko.FixedLength = false;
			this.numCmimiModifiko.IsValid = false;
			this.numCmimiModifiko.KeepFocus = false;
			this.numCmimiModifiko.Location = new System.Drawing.Point(92, 76);
			this.numCmimiModifiko.Name = "numCmimiModifiko";
			this.numCmimiModifiko.OnlyPositive = true;
			this.numCmimiModifiko.Required = false;
			this.numCmimiModifiko.RequiredControlColor = System.Drawing.Color.White;
			this.numCmimiModifiko.Size = new System.Drawing.Size(200, 21);
			this.numCmimiModifiko.TabIndex = 7;
			this.numCmimiModifiko.Text = "";
			this.numCmimiModifiko.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(4, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 18;
			this.label3.Text = "Cmimi per njesi";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Detyrimet
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(936, 628);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.EnableValidation = true;
			this.HelpFile = "DETYRIME.htm";
			this.Name = "Detyrimet";
			this.Text = "Detyrimet";
			this.Load += new System.EventHandler(this.Detyrimet_Load);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.groupBox3, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.cmbDetyrime.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region EventHandlers
		private void btnShto_Click(object sender, System.EventArgs e)
		{
			try
			{
				int b = 0;
				const string NUMERIC_FORMAT = "^-?[0-9]*(\\,)?[0-9]+$";
				if (this.txtDetyrimi.Text.Trim() == "")
				{
					this.error.SetError(this.txtDetyrimi, "Jepni emrin e llojit te detyrimit!");
					return;
				}
				this.error.SetError(this.txtDetyrimi, "");
				if (this.numCmimi.Text.Trim() == "")
				{
					this.error.SetError(this.numCmimi, "Jepni cmimin e llojit te detyrimit!");
					return;
				}
				this.error.SetError(this.numCmimi, "");
				if (!Regex.IsMatch(this.numCmimi.Text, NUMERIC_FORMAT))
				{
					this.error.SetError(this.numCmimi, "Cmimi duhet te jete vlere numerike!");
					return;
				}
				this.error.SetError(this.numCmimi, "");
				if (Convert.ToInt32(this.numCmimi.Text) < 0)
				{
					this.error.SetError(this.numCmimi, "Cmimi nuk mund te jete negativ!");
					return;
				}
				this.error.SetError(this.numCmimi, "");
				string detyrimi =  this.txtDetyrimi.Text.Trim();
				int cmimi = Convert.ToInt32(this.numCmimi.Text); 
				InputController data = new InputController();
				b = data.KerkesaUpdate("KrijoLlojDetyrim", detyrimi, cmimi);
				if(b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this,  "Lloji i ri i detyrimit i ri u shtua!","Konfigurimi i llojeve te detyrimeve",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.txtDetyrimi.Text = " ";
					this.numCmimi.Text = " ";
					this.mbushDetyrimet();
				}
				else if (b == 1)
					System.Windows.Forms.MessageBox.Show(this, "Ekziston nje detyrim me kete emer."+Environment.NewLine+"Ju lutemi zgjidhni nje emer te ri.",
						"Konfigurimi i llojeve te detyrimeve",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        
		private void Detyrimet_Load(object sender, System.EventArgs e)
		{
			try
			{
				this.mbushDetyrimet() ;
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
        
		private void btnModifiko_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				//kontroll
				const string NUMERIC_FORMAT = "^-?[0-9]*(\\,)?[0-9]+$";
				if (this.cmbDetyrime.Kolone1.SelectedItem == null)
				{
					this.error.SetError(this.cmbDetyrime, "Zgjidhni me pare nje prej llojeve te detyrimeve!");
					return;
				}
				this.error.SetError(this.cmbDetyrime, "");
				if (this.txtEmriModifiko.Text.Trim() == "")
				{
					this.error.SetError(this.txtEmriModifiko, "Jepni emrin per llojin e detyrimit!");
					return;
				}
				this.error.SetError(this.txtEmriModifiko, "");
				if (this.numCmimiModifiko.Text.Trim() == "")
				{
					this.error.SetError(this.numCmimiModifiko, "Jepni cmimin per llojin e detyrimit!");
					return;
				}
				this.error.SetError(this.numCmimiModifiko, "");
				if (!Regex.IsMatch(this.numCmimiModifiko.Text, NUMERIC_FORMAT))
				{
					this.error.SetError(this.numCmimiModifiko, "Cmimi duhet te jete vlere numerike!");
					return;
				}
				this.error.SetError(this.numCmimiModifiko, "");
				if (Convert.ToInt32(this.numCmimiModifiko.Text)< 0)
				{
					this.error.SetError(this.numCmimiModifiko, "Cmimi nuk mund te jete negativ");
					return;
				}
				this.error.SetError(this.numCmimiModifiko, "");
				//kontroll
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Konfigurimi i llojeve te detyrimeve", 
					"Jeni te sigurte qe doni ta modifikoni detyrimin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result != DialogResult.Yes)
					return;
				int b = 0 ;
				int idDetyrimi = Convert.ToInt32(this.cmbDetyrime.Kolone2Vlere);// do merret nga kombo e detyrimeve
				string detyrimi = this.txtEmriModifiko.Text.Trim(); 
				int cmimi = Convert.ToInt32(this.numCmimiModifiko.Text); 
				InputController data = new InputController();
				b = data.KerkesaUpdate("ModifikoLlojDetyrimi", idDetyrimi, detyrimi,cmimi);
				if(b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this,  "Lloji i zgjedhur i detyrimit u modifikua.","Konfigurimi i llojeve te detyrimeve",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.mbushDetyrimet();
					this.cmbDetyrime.Kolone1.Text = "";
					this.numCmimiModifiko.Text = "";
					this.txtEmriModifiko.Text = "";
				}
				else if (b == -1)
					System.Windows.Forms.MessageBox.Show(this, "Ekziston nje lloj detyrimi me kete emer."+Environment.NewLine+"Ju lutemi zgjidhni nje emer te ri.",
						"Konfigurimi i llojeve te detyrimeve",MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
				{
					string varKlienti = "";	
					if(b == 1)
						varKlienti = "klienti ";
					else
						varKlienti = "klienteve";
					System.Windows.Forms.MessageBox.Show(this, "Lloji i zgjedhur i detyrimit nuk mund te modifikohet."+Environment.NewLine+"Ky detyrim i  eshte hedhur "+ b +" "+ varKlienti +".",
						"Modifikimi i detyrimeve",MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.cmbDetyrime.Kolone1.Text = "";
					this.numCmimiModifiko.Text = "";
					this.txtEmriModifiko.Text = "";
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

		private void btnElemino_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				if (this.cmbDetyrime.Kolone1.SelectedItem == null)
				{
					this.error.SetError(this.cmbDetyrime, "Zgjidhni me pare nje prej llojeve te detyrimeve!");
					return;
				}
				this.error.SetError(this.cmbDetyrime, "");
				DialogResult result = VisionInfoSolutionLibrary.MessageBox.Show(this, "Konfigurimi i llojeve te detyrimeve", 
					"Jeni te sigurte qe doni ta modifikoni detyrimin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result != DialogResult.Yes)
					return;
				int b = 0 ;
				int idDetyrimi = Convert.ToInt32(this.cmbDetyrime.Kolone2Vlere); // idDetyrimi merr vlere nga kombo
				InputController data = new InputController();
				b = data.KerkesaUpdate("FshiLlojDetyrimi", idDetyrimi);
				if(b == 0)
				{
					System.Windows.Forms.MessageBox.Show(this,  "Detyrimi i zgjedhur u eleminua.","Konfigurimi i llojeve te detyrimeve",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.mbushDetyrimet();
					this.cmbDetyrime.Kolone1.Text = "";
					this.numCmimiModifiko.Text = "";
					this.txtEmriModifiko.Text = "";
				}
				else
				{
					string varKlienti = "";	
					if(b == 1)
						varKlienti = "klienti ";
					else
						varKlienti = "klienteve";
					System.Windows.Forms.MessageBox.Show(this, "Lloji i zgjedhur i detyrimit nuk mund te fshihet."+Environment.NewLine+"Ky detyrim i  eshte hedhur "+ b +" "+ varKlienti +".",
						"Konfigurimi i llojeve te detyrimeve",MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.cmbDetyrime.Kolone1.Text = "";
					this.numCmimiModifiko.Text = "";
					this.txtEmriModifiko.Text = "";
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

		private void cmbDetyrime_SelectedIndexChanged_2(object Sender, VisionInfoSolutionLibrary.SelectedIndexChangedEventArgs e)
		{
			try
			{
				DataSet ds = null;
				int idLlojDetyrimi = Convert.ToInt32(this.cmbDetyrime.Kolone2Vlere); // vlera merret nga kombo e detyrimeve
				InputController data = new InputController();
				ds = data.KerkesaRead("ShfaqLlojDetyriminEzgjedhur", idLlojDetyrimi);
				//mbushja e kontrolleve me vlerat e duhura
				this.txtEmriModifiko.Text = Convert.ToString(ds.Tables[0].Rows[0][0]);
				this.numCmimiModifiko.Text = Convert.ToString(ds.Tables[0].Rows[0][1]);
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
		private void mbushDetyrimet()
		{
			DataSet ds = null ;
			this.cmbDetyrime.Kolone1.Items.Clear();
			this.cmbDetyrime.Kolone2.Items.Clear();
			this.lbDetyrimet.Items.Clear();
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqLlojetDetyrime");
			//mbushja e kombos
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbDetyrime.Kolone1.Items.Add(dr[1]);
				this.cmbDetyrime.Kolone2.Items.Add(dr[0]);

				this.lbDetyrimet.Items.Add(dr[1]);

			}
		}

		private void RefreshDetyrimet()
		{
			DataSet ds = null;
			this.cmbDetyrime.Kolone1.Text = "";
			this.txtEmriModifiko.Text = "";
			this.numCmimiModifiko.Text = "";
			this.cmbDetyrime.Kolone1.Items.Clear();
			this.cmbDetyrime.Kolone2.Items.Clear();
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqLlojetDetyrime");
			//mbushja e kombos
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				this.cmbDetyrime.Kolone1.Items.Add(dr[1]);
				this.cmbDetyrime.Kolone2.Items.Add(dr[0]);
			}
           
		}

		#endregion
	}
}

