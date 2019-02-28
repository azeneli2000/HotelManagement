using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;

namespace HotelManagment.Forms
{
	public class Settings : VisionInfoSolutionLibrary.Form
	{
		#region Private Fields
		private VisionInfoSolutionLibrary.GroupBox gbStili;
		private VisionInfoSolutionLibrary.GroupBox gbEmail;
		private VisionInfoSolutionLibrary.TextBox txtPassword;
		private VisionInfoSolutionLibrary.TextBox txtEmail;
		private VisionInfoSolutionLibrary.TextBox txtHost;
		private VisionInfoSolutionLibrary.Label lblHost;
		private VisionInfoSolutionLibrary.Label lblPassword;
		private VisionInfoSolutionLibrary.Label lblEmail;
		private VisionInfoSolutionLibrary.Button btnRuaj;
		private VisionInfoSolutionLibrary.GroupBox gbGjuha;
		private VisionInfoSolutionLibrary.RadioButton rbFrengjisht;
		private VisionInfoSolutionLibrary.RadioButton rbItalisht;
		private VisionInfoSolutionLibrary.RadioButton rbAnglisht;
		private VisionInfoSolutionLibrary.RadioButton rbShqip;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.RadioButton rbStilXP;
		private VisionInfoSolutionLibrary.RadioButton rbStilOffice;
		private VisionInfoSolutionLibrary.ErrorProvider warning;
		/// <summary>
		/// Variabel privat qe mban vleren per gjuhen e zgjedhur
		/// per printimin e faturave
		/// </summary>
		private string gjuha = "";
		private VisionInfoSolutionLibrary.ComboBox cmbProgramet;
		private VisionInfoSolutionLibrary.GroupBox gbAssemblies;
		private VisionInfoSolutionLibrary.TextBox txtIpPc;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.Button btnRuajAssembly;
		/// <summary>
		/// Fushe private qe ruan vleren fillestare per stilin e perdorur nga perdoruesi
		/// </summary>
		private bool stil1;
		#endregion

		#region Constructors & Destructors
		public Settings()
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
			this.gbStili = new VisionInfoSolutionLibrary.GroupBox();
			this.rbStilXP = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbStilOffice = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.gbEmail = new VisionInfoSolutionLibrary.GroupBox();
			this.lblEmail = new VisionInfoSolutionLibrary.Label();
			this.lblPassword = new VisionInfoSolutionLibrary.Label();
			this.lblHost = new VisionInfoSolutionLibrary.Label();
			this.txtHost = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmail = new VisionInfoSolutionLibrary.TextBox();
			this.txtPassword = new VisionInfoSolutionLibrary.TextBox();
			this.btnRuaj = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbGjuha = new VisionInfoSolutionLibrary.GroupBox();
			this.rbFrengjisht = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbItalisht = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbAnglisht = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbShqip = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.warning = new VisionInfoSolutionLibrary.ErrorProvider();
			this.cmbProgramet = new VisionInfoSolutionLibrary.ComboBox(this.components);
			this.gbAssemblies = new VisionInfoSolutionLibrary.GroupBox();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.txtIpPc = new VisionInfoSolutionLibrary.TextBox();
			this.btnRuajAssembly = new VisionInfoSolutionLibrary.Button(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gbStili)).BeginInit();
			this.gbStili.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbEmail)).BeginInit();
			this.gbEmail.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbGjuha)).BeginInit();
			this.gbGjuha.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbAssemblies)).BeginInit();
			this.gbAssemblies.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			// 
			// gbStili
			// 
			this.gbStili.BackColor = System.Drawing.Color.Transparent;
			this.gbStili.Controls.Add(this.rbStilXP);
			this.gbStili.Controls.Add(this.rbStilOffice);
			this.gbStili.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbStili.Location = new System.Drawing.Point(10, 42);
			this.gbStili.Name = "gbStili";
			this.gbStili.Size = new System.Drawing.Size(390, 68);
			this.gbStili.TabIndex = 1;
			this.gbStili.Text = "Stili ne te cilin do te paraqitet programi";
			this.gbStili.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// rbStilXP
			// 
			this.rbStilXP.Location = new System.Drawing.Point(20, 24);
			this.rbStilXP.Name = "rbStilXP";
			this.rbStilXP.Size = new System.Drawing.Size(132, 24);
			this.rbStilXP.TabIndex = 1;
			this.rbStilXP.Text = "Ne stilin XP dhe klasik";
			// 
			// rbStilOffice
			// 
			this.rbStilOffice.Location = new System.Drawing.Point(212, 24);
			this.rbStilOffice.Name = "rbStilOffice";
			this.rbStilOffice.Size = new System.Drawing.Size(116, 24);
			this.rbStilOffice.TabIndex = 0;
			this.rbStilOffice.Text = "Ne stilin Office 2003";
			// 
			// gbEmail
			// 
			this.gbEmail.BackColor = System.Drawing.Color.Transparent;
			this.gbEmail.Controls.Add(this.lblEmail);
			this.gbEmail.Controls.Add(this.lblPassword);
			this.gbEmail.Controls.Add(this.lblHost);
			this.gbEmail.Controls.Add(this.txtHost);
			this.gbEmail.Controls.Add(this.txtEmail);
			this.gbEmail.Controls.Add(this.txtPassword);
			this.gbEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbEmail.Location = new System.Drawing.Point(10, 184);
			this.gbEmail.Name = "gbEmail";
			this.gbEmail.Size = new System.Drawing.Size(390, 132);
			this.gbEmail.TabIndex = 2;
			this.gbEmail.Text = "Rregullimi i vlerave te adreses elektronike";
			this.gbEmail.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// lblEmail
			// 
			this.lblEmail.Location = new System.Drawing.Point(24, 28);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(100, 20);
			this.lblEmail.TabIndex = 5;
			this.lblEmail.Text = "Adresa e emailit";
			this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblPassword
			// 
			this.lblPassword.Location = new System.Drawing.Point(24, 56);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(100, 20);
			this.lblPassword.TabIndex = 4;
			this.lblPassword.Text = "Fjalekalimi";
			this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblHost
			// 
			this.lblHost.Location = new System.Drawing.Point(24, 84);
			this.lblHost.Name = "lblHost";
			this.lblHost.Size = new System.Drawing.Size(96, 20);
			this.lblHost.TabIndex = 3;
			this.lblHost.Text = "Host";
			this.lblHost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtHost
			// 
			this.txtHost.AutoSize = false;
			this.txtHost.DefaultErrorMessage = "";
			this.txtHost.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtHost.FixedLength = false;
			this.txtHost.IsValid = true;
			this.txtHost.Location = new System.Drawing.Point(144, 84);
			this.txtHost.Name = "txtHost";
			this.txtHost.Required = false;
			this.txtHost.RequiredControlColor = System.Drawing.Color.White;
			this.txtHost.Size = new System.Drawing.Size(168, 20);
			this.txtHost.TabIndex = 2;
			this.txtHost.Text = "";
			// 
			// txtEmail
			// 
			this.txtEmail.AutoSize = false;
			this.txtEmail.DefaultErrorMessage = "";
			this.txtEmail.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmail.FixedLength = false;
			this.txtEmail.IsValid = true;
			this.txtEmail.Location = new System.Drawing.Point(144, 28);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Required = false;
			this.txtEmail.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmail.Size = new System.Drawing.Size(168, 20);
			this.txtEmail.TabIndex = 1;
			this.txtEmail.Text = "";
			this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
			// 
			// txtPassword
			// 
			this.txtPassword.AutoSize = false;
			this.txtPassword.DefaultErrorMessage = "";
			this.txtPassword.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtPassword.FixedLength = false;
			this.txtPassword.IsValid = true;
			this.txtPassword.Location = new System.Drawing.Point(144, 56);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Required = false;
			this.txtPassword.RequiredControlColor = System.Drawing.Color.White;
			this.txtPassword.Size = new System.Drawing.Size(168, 20);
			this.txtPassword.TabIndex = 0;
			this.txtPassword.Text = "";
			// 
			// btnRuaj
			// 
			this.btnRuaj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRuaj.DoValidation = false;
			this.btnRuaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRuaj.Location = new System.Drawing.Point(272, 332);
			this.btnRuaj.Name = "btnRuaj";
			this.btnRuaj.Size = new System.Drawing.Size(90, 21);
			this.btnRuaj.TabIndex = 3;
			this.btnRuaj.Text = "Ruaj";
			this.toolTips.SetToolTip(this.btnRuaj, "Ruan ndryshimet e bera ne tiparet e programit!");
			this.btnRuaj.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
			// 
			// gbGjuha
			// 
			this.gbGjuha.BackColor = System.Drawing.Color.Transparent;
			this.gbGjuha.Controls.Add(this.rbFrengjisht);
			this.gbGjuha.Controls.Add(this.rbItalisht);
			this.gbGjuha.Controls.Add(this.rbAnglisht);
			this.gbGjuha.Controls.Add(this.rbShqip);
			this.gbGjuha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbGjuha.Location = new System.Drawing.Point(10, 112);
			this.gbGjuha.Name = "gbGjuha";
			this.gbGjuha.Size = new System.Drawing.Size(392, 68);
			this.gbGjuha.TabIndex = 4;
			this.gbGjuha.Text = "Zgjidhni gjuhen e printimit te faturave";
			this.gbGjuha.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// rbFrengjisht
			// 
			this.rbFrengjisht.Location = new System.Drawing.Point(292, 24);
			this.rbFrengjisht.Name = "rbFrengjisht";
			this.rbFrengjisht.Size = new System.Drawing.Size(80, 24);
			this.rbFrengjisht.TabIndex = 3;
			this.rbFrengjisht.Text = "Frengjisht";
			// 
			// rbItalisht
			// 
			this.rbItalisht.Location = new System.Drawing.Point(204, 24);
			this.rbItalisht.Name = "rbItalisht";
			this.rbItalisht.Size = new System.Drawing.Size(80, 24);
			this.rbItalisht.TabIndex = 2;
			this.rbItalisht.Text = "Italisht";
			// 
			// rbAnglisht
			// 
			this.rbAnglisht.Location = new System.Drawing.Point(108, 24);
			this.rbAnglisht.Name = "rbAnglisht";
			this.rbAnglisht.Size = new System.Drawing.Size(80, 24);
			this.rbAnglisht.TabIndex = 1;
			this.rbAnglisht.Text = "Anglisht";
			// 
			// rbShqip
			// 
			this.rbShqip.Location = new System.Drawing.Point(16, 24);
			this.rbShqip.Name = "rbShqip";
			this.rbShqip.Size = new System.Drawing.Size(80, 24);
			this.rbShqip.TabIndex = 0;
			this.rbShqip.Text = "Shqip";
			// 
			// warning
			// 
			this.warning.ContainerControl = this;
			// 
			// cmbProgramet
			// 
			this.cmbProgramet.DefaultErrorMessage = null;
			this.cmbProgramet.IsValid = false;
			this.cmbProgramet.Location = new System.Drawing.Point(172, 36);
			this.cmbProgramet.Name = "cmbProgramet";
			this.cmbProgramet.Required = false;
			this.cmbProgramet.Size = new System.Drawing.Size(148, 21);
			this.cmbProgramet.TabIndex = 5;
			// 
			// gbAssemblies
			// 
			this.gbAssemblies.BackColor = System.Drawing.Color.Transparent;
			this.gbAssemblies.Controls.Add(this.label2);
			this.gbAssemblies.Controls.Add(this.label1);
			this.gbAssemblies.Controls.Add(this.txtIpPc);
			this.gbAssemblies.Controls.Add(this.cmbProgramet);
			this.gbAssemblies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbAssemblies.Location = new System.Drawing.Point(412, 42);
			this.gbAssemblies.Name = "gbAssemblies";
			this.gbAssemblies.Size = new System.Drawing.Size(348, 140);
			this.gbAssemblies.TabIndex = 6;
			this.gbAssemblies.Text = "Konfigurimi i programeve te tjere";
			this.gbAssemblies.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Emri ose IP i kompjuterit";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(28, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Programi ndihmes";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtIpPc
			// 
			this.txtIpPc.AutoSize = false;
			this.txtIpPc.DefaultErrorMessage = "";
			this.txtIpPc.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtIpPc.FixedLength = false;
			this.txtIpPc.IsValid = true;
			this.txtIpPc.Location = new System.Drawing.Point(172, 72);
			this.txtIpPc.Name = "txtIpPc";
			this.txtIpPc.Required = false;
			this.txtIpPc.RequiredControlColor = System.Drawing.Color.White;
			this.txtIpPc.Size = new System.Drawing.Size(144, 20);
			this.txtIpPc.TabIndex = 6;
			this.txtIpPc.Text = "";
			// 
			// btnRuajAssembly
			// 
			this.btnRuajAssembly.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRuajAssembly.DoValidation = true;
			this.btnRuajAssembly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRuajAssembly.Location = new System.Drawing.Point(644, 196);
			this.btnRuajAssembly.Name = "btnRuajAssembly";
			this.btnRuajAssembly.Size = new System.Drawing.Size(90, 21);
			this.btnRuajAssembly.TabIndex = 7;
			this.btnRuajAssembly.Text = "Ruaj";
			this.btnRuajAssembly.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnRuajAssembly.Click += new System.EventHandler(this.btnRuajAssembly_Click);
			// 
			// Settings
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(936, 520);
			this.Controls.Add(this.btnRuajAssembly);
			this.Controls.Add(this.gbAssemblies);
			this.Controls.Add(this.gbGjuha);
			this.Controls.Add(this.btnRuaj);
			this.Controls.Add(this.gbEmail);
			this.Controls.Add(this.gbStili);
			this.HelpFile = "RREGULLIME.htm";
			this.Name = "Settings";
			this.Text = "Rregullime";
			this.Load += new System.EventHandler(this.Settings_Load);
			this.Controls.SetChildIndex(this.gbStili, 0);
			this.Controls.SetChildIndex(this.gbEmail, 0);
			this.Controls.SetChildIndex(this.btnRuaj, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.gbGjuha, 0);
			this.Controls.SetChildIndex(this.gbAssemblies, 0);
			this.Controls.SetChildIndex(this.btnRuajAssembly, 0);
			((System.ComponentModel.ISupportInitialize)(this.gbStili)).EndInit();
			this.gbStili.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbEmail)).EndInit();
			this.gbEmail.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbGjuha)).EndInit();
			this.gbGjuha.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbAssemblies)).EndInit();
			this.gbAssemblies.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void btnRuaj_Click(object sender, System.EventArgs e)
		{
			// Vendosim kursorin ne gjendje pritjeje
			this.Cursor = Cursors.WaitCursor;
			DataSet ds = new DataSet();
			// Ndryshojme emailin, passwordin dhe hostin
			if (this.txtEmail.Text.Split(new char[]{'@'}).Length != 2)
			{
				warning.SetError(txtEmail, "Adresa e e-mailit e dhene nga ju nuk duket e sakte");
			}
			else
			{

			}
			// Ndryshojme stilin e paraqitjes se programit
			try
			{
				if (this.rbStilXP.Checked)
				{
					ds.Tables.Clear();
					ds.ReadXml(Application.StartupPath + "\\Settings.xml");
					if (ds.Tables[0].Select("Perdorues = '" + this.Perdorues + "'").Length == 0)
					{
						DataRow dr = ds.Tables[0].NewRow();
						dr[0] = this.Perdorues;
						dr[1] = false;
					}
					else
					{
						DataRow dr = (DataRow)ds.Tables[0].Select("Perdorues = '" + this.Perdorues + "'").GetValue(0);
						dr[0] = this.Perdorues;
						dr[1] = false;
					}
					ds.WriteXml(Application.StartupPath + "\\Settings.xml", XmlWriteMode.WriteSchema);
				}
				else if (this.rbStilOffice.Checked)
				{
					ds.ReadXml(Application.StartupPath + "\\Settings.xml");
					if (ds.Tables[0].Select("Perdorues = '" + this.Perdorues + "'").Length == 0)
					{
						DataRow dr = ds.Tables[0].NewRow();
						dr[0] = this.Perdorues;
						dr[1] = true;
					}
					else
					{
						DataRow dr = (DataRow)ds.Tables[0].Select("Perdorues = '" + this.Perdorues + "'").GetValue(0);
						dr[0] = this.Perdorues;
						dr[1] = true;
					}
					ds.WriteXml(Application.StartupPath + "\\Settings.xml", XmlWriteMode.WriteSchema);
				}

				// Ne kete pjese behet ruajtja e gjuhes se printimit te faturave
				ds.Tables.Clear();
				ds.ReadXml(Application.StartupPath + "\\Perkthime.xml");
				if (this.rbShqip.Checked)
					ds.Tables[1].Rows[0][0] = "Shqip";
				else if (this.rbAnglisht.Checked)
					ds.Tables[1].Rows[0][0] = "Anglisht";
				else if (this.rbItalisht.Checked)
					ds.Tables[1].Rows[0][0] = "Italisht";
				else if (this.rbFrengjisht.Checked)
					ds.Tables[1].Rows[0][0] = "Frengjisht";
				ds.AcceptChanges();
				this.gjuha = ds.Tables[1].Rows[0][0].ToString();
				ds.WriteXml(Application.StartupPath + "\\Perkthime.xml", XmlWriteMode.WriteSchema);

				// Ruajme edhe emailin, passwordin dhe hostin per programin
				ds.Tables.Clear();
				ds.ReadXml(Application.StartupPath + "\\Informacione.xml");
				ds.Tables[0].Rows[0]["SetEmail"] = this.txtEmail.Text;
				ds.Tables[0].Rows[0]["Password"] = this.txtPassword.Text;
				ds.Tables[0].Rows[0]["Host"] = this.txtHost.Text;
				ds.WriteXml(Application.StartupPath + "\\Informacione.xml", XmlWriteMode.WriteSchema);
				// Kontrollojme nese eshte bere ndonje ndryshim ne stilin e programit
				if (stil1 == this.rbStilOffice.Checked)
					MessageBox.Show("Te dhenat u ruajten me sukses", "Rregullime", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
				else
					MessageBox.Show("Te dhenat e ruajten." + Environment.NewLine + "Qe keto te dhena te kene " +
						"efekt, duhet te rihapni programin", "Rregullime", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
				stil1 = this.rbStilOffice.Checked;
			}
			catch(Exception ex)
			{
				return;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Settings_Load(object sender, System.EventArgs e)
		{
			this.gjuha = "";
			this.stil1 = false;
			InputController data = new InputController();
			DataSet ds = new DataSet();
			// Gjejme se ne cilin stil eshte programi i paraqitur
			// Kete e gjejme thjesht nga stili qe eshte perdorur ne butonin Ruaj
			if (this.btnRuaj.VisualStyle == Janus.Windows.UI.VisualStyle.Office2003)
			{
				this.rbStilOffice.Checked = true;
				this.rbStilXP.Checked = false;
			}
			else
			{
				this.rbStilXP.Checked = true;
				this.rbStilOffice.Checked = false;
			}
			stil1 = this.rbStilOffice.Checked;
			
			// Ne kete pjese behet kontrolli i gjuhes per printimin e faturave
			ds.Tables.Clear();
			if (File.Exists(Application.StartupPath + "\\Perkthime.xml"))
			{
				ds.ReadXml(Application.StartupPath + "\\Perkthime.xml");
				gjuha = ds.Tables[1].Rows[0][0].ToString();
			}
			else
			{
				ds = data.KerkesaRead("ShfaqPerkthime");
				ds.WriteXml(Application.StartupPath + "\\Perkthime.xml", XmlWriteMode.WriteSchema);
				gjuha = "Shqip";
			}
			switch (gjuha)
			{
				case "Shqip":
					this.rbShqip.Checked = true;
					this.gjuha = "Shqip";
					break;
				case "Anglisht":
					this.rbAnglisht.Checked = true;
					this.gjuha = "Anglisht";
					break;
				case "Italisht":
					this.rbItalisht.Checked = true;
					this.gjuha = "Italisht";
					break;
				case "Frengjisht":
					this.rbFrengjisht.Checked = true;
					this.gjuha = "Frengjisht";
					break;
			}

			// Vendosim emailin dhe passwordin e perdoruesit qe ka zgjedhur
			ds.Tables.Clear();
			ds.ReadXml(Application.StartupPath + "\\Informacione.xml");
			if (ds.Tables[0].Columns.Contains("SetEmail"))
			{
				// Shohim nese emaili eshte konfiguruar ndonje here. Nese po vendosim vlerat
				this.txtEmail.Text = ds.Tables[0].Rows[0]["SetEmail"].ToString();
				this.txtPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString();
				this.txtHost.Text = ds.Tables[0].Rows[0]["Host"].ToString();
			}
			else
			{
				// Nese nuk eshte konfiguruar ndonjehere shtojme kolonat dhe vlerat
				ds.Tables[0].Columns.Add("SetEmail",typeof(String));
				ds.Tables[0].Columns.Add("Password", typeof(String));
				ds.Tables[0].Columns.Add("Host", typeof(String));
				ds.Tables[0].Rows[0]["SetEmail"] = this.txtEmail.Text;
				ds.Tables[0].Rows[0]["Password"] = this.txtPassword.Text;
				ds.Tables[0].Rows[0]["Host"] = this.txtHost.Text;
			}
			ds.WriteXml(Application.StartupPath + "\\Informacione.xml");
		}

		private void txtEmail_Leave(object sender, System.EventArgs e)
		{
			if (this.txtEmail.Text.Split(new char[]{'@'}).Length != 2)
			{
				warning.SetError(txtEmail, "Adresa e e-mailit e dhene nga ju nuk duket e sakte");
			}
			else
			{
				string[] str = this.txtEmail.Text.Split(new char[]{'@'},2);
				warning.SetError(this.txtEmail, "");
				this.txtHost.Text = "www." + str.GetValue(1);
				this.txtPassword.Focus();
			}
		}
		#endregion

		private void btnRuajAssembly_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}

