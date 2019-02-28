using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace HotelManagment.Forms
{
	public class frmTeDhenaHoteli : VisionInfoSolutionLibrary.Form
	{
		private VisionInfoSolutionLibrary.GroupBox groupBox1;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.Label label5;
		private VisionInfoSolutionLibrary.Label label6;
		private VisionInfoSolutionLibrary.TextBox txtEmri;
		private VisionInfoSolutionLibrary.TextBox txtAdresa;
		private VisionInfoSolutionLibrary.TextBox txtTelefoni;
		private VisionInfoSolutionLibrary.TextBox txtEmail;
		private VisionInfoSolutionLibrary.TextBox txtWebSite;
		private VisionInfoSolutionLibrary.Button btnRuaj;
		private VisionInfoSolutionLibrary.Label label7;
		private VisionInfoSolutionLibrary.Label label8;
		private VisionInfoSolutionLibrary.GroupBox groupBox2;
		private VisionInfoSolutionLibrary.TextBox txtFRezervimi;
		private VisionInfoSolutionLibrary.Button button1;
		private VisionInfoSolutionLibrary.PictureBox pictureBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.Button btnFshi;
		private VisionInfoSolutionLibrary.Label lblKodFiskal;
		private VisionInfoSolutionLibrary.TextBox txtKodFiskal;
		private VisionInfoSolutionLibrary.TextBox txtFQendrimi;
		private string PicturePath = "";
		private string emer, adrese, telefon, email, website, kodFiskal, smsRezervim, smsQendrim;

		public frmTeDhenaHoteli()
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

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new VisionInfoSolutionLibrary.GroupBox();
			this.txtKodFiskal = new VisionInfoSolutionLibrary.TextBox();
			this.lblKodFiskal = new VisionInfoSolutionLibrary.Label();
			this.btnFshi = new VisionInfoSolutionLibrary.Button(this.components);
			this.pictureBox1 = new VisionInfoSolutionLibrary.PictureBox();
			this.button1 = new VisionInfoSolutionLibrary.Button(this.components);
			this.txtWebSite = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmail = new VisionInfoSolutionLibrary.TextBox();
			this.txtTelefoni = new VisionInfoSolutionLibrary.TextBox();
			this.txtAdresa = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.btnRuaj = new VisionInfoSolutionLibrary.Button(this.components);
			this.label7 = new VisionInfoSolutionLibrary.Label();
			this.label8 = new VisionInfoSolutionLibrary.Label();
			this.groupBox2 = new VisionInfoSolutionLibrary.GroupBox();
			this.txtFQendrimi = new VisionInfoSolutionLibrary.TextBox();
			this.txtFRezervimi = new VisionInfoSolutionLibrary.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(896, 25);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.txtKodFiskal);
			this.groupBox1.Controls.Add(this.lblKodFiskal);
			this.groupBox1.Controls.Add(this.btnFshi);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.txtWebSite);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtTelefoni);
			this.groupBox1.Controls.Add(this.txtAdresa);
			this.groupBox1.Controls.Add(this.txtEmri);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(10, 42);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(520, 222);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.Text = "Konfigurimi i te dhenave per hotelin";
			this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// txtKodFiskal
			// 
			this.txtKodFiskal.AutoSize = false;
			this.txtKodFiskal.DefaultErrorMessage = "";
			this.txtKodFiskal.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtKodFiskal.FixedLength = false;
			this.txtKodFiskal.IsValid = true;
			this.txtKodFiskal.Location = new System.Drawing.Point(96, 184);
			this.txtKodFiskal.Name = "txtKodFiskal";
			this.txtKodFiskal.Required = false;
			this.txtKodFiskal.RequiredControlColor = System.Drawing.Color.White;
			this.txtKodFiskal.Size = new System.Drawing.Size(200, 21);
			this.txtKodFiskal.TabIndex = 16;
			this.txtKodFiskal.Text = "";
			// 
			// lblKodFiskal
			// 
			this.lblKodFiskal.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblKodFiskal.Location = new System.Drawing.Point(20, 188);
			this.lblKodFiskal.Name = "lblKodFiskal";
			this.lblKodFiskal.Size = new System.Drawing.Size(68, 20);
			this.lblKodFiskal.TabIndex = 15;
			this.lblKodFiskal.Text = "Kodi fiskal";
			this.lblKodFiskal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnFshi
			// 
			this.btnFshi.BackColor = System.Drawing.Color.Blue;
			this.btnFshi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFshi.DoValidation = true;
			this.btnFshi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnFshi.Location = new System.Drawing.Point(416, 152);
			this.btnFshi.Name = "btnFshi";
			this.btnFshi.Size = new System.Drawing.Size(90, 21);
			this.btnFshi.TabIndex = 14;
			this.btnFshi.Text = "Fshi logo";
			this.btnFshi.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(344, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 96);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Blue;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.DoValidation = true;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(316, 152);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 21);
			this.button1.TabIndex = 12;
			this.button1.Text = "Zgjidh logo";
			this.button1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtWebSite
			// 
			this.txtWebSite.AutoSize = false;
			this.txtWebSite.DefaultErrorMessage = "";
			this.txtWebSite.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtWebSite.FixedLength = false;
			this.txtWebSite.IsValid = true;
			this.txtWebSite.Location = new System.Drawing.Point(96, 152);
			this.txtWebSite.Name = "txtWebSite";
			this.txtWebSite.Required = false;
			this.txtWebSite.RequiredControlColor = System.Drawing.Color.White;
			this.txtWebSite.Size = new System.Drawing.Size(200, 21);
			this.txtWebSite.TabIndex = 11;
			this.txtWebSite.Text = "";
			// 
			// txtEmail
			// 
			this.txtEmail.AutoSize = false;
			this.txtEmail.DefaultErrorMessage = "";
			this.txtEmail.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmail.FixedLength = false;
			this.txtEmail.IsValid = true;
			this.txtEmail.Location = new System.Drawing.Point(96, 120);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Required = false;
			this.txtEmail.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmail.Size = new System.Drawing.Size(200, 21);
			this.txtEmail.TabIndex = 10;
			this.txtEmail.Text = "";
			// 
			// txtTelefoni
			// 
			this.txtTelefoni.AutoSize = false;
			this.txtTelefoni.DefaultErrorMessage = "";
			this.txtTelefoni.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtTelefoni.FixedLength = false;
			this.txtTelefoni.IsValid = true;
			this.txtTelefoni.Location = new System.Drawing.Point(96, 88);
			this.txtTelefoni.Name = "txtTelefoni";
			this.txtTelefoni.Required = false;
			this.txtTelefoni.RequiredControlColor = System.Drawing.Color.White;
			this.txtTelefoni.Size = new System.Drawing.Size(200, 21);
			this.txtTelefoni.TabIndex = 9;
			this.txtTelefoni.Text = "";
			// 
			// txtAdresa
			// 
			this.txtAdresa.AutoSize = false;
			this.txtAdresa.DefaultErrorMessage = "";
			this.txtAdresa.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAdresa.FixedLength = false;
			this.txtAdresa.IsValid = true;
			this.txtAdresa.Location = new System.Drawing.Point(96, 56);
			this.txtAdresa.Name = "txtAdresa";
			this.txtAdresa.Required = false;
			this.txtAdresa.RequiredControlColor = System.Drawing.Color.White;
			this.txtAdresa.Size = new System.Drawing.Size(200, 21);
			this.txtAdresa.TabIndex = 7;
			this.txtAdresa.Text = "";
			// 
			// txtEmri
			// 
			this.txtEmri.AutoSize = false;
			this.txtEmri.DefaultErrorMessage = "";
			this.txtEmri.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri.FixedLength = false;
			this.txtEmri.IsValid = true;
			this.txtEmri.Location = new System.Drawing.Point(96, 24);
			this.txtEmri.Name = "txtEmri";
			this.txtEmri.Required = false;
			this.txtEmri.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri.Size = new System.Drawing.Size(200, 21);
			this.txtEmri.TabIndex = 6;
			this.txtEmri.Text = "";
			this.txtEmri.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label6
			// 
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Location = new System.Drawing.Point(24, 156);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Website";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(32, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "E-mail";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(4, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Numer telefoni";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(28, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Adresa";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(40, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Emri";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnRuaj
			// 
			this.btnRuaj.BackColor = System.Drawing.Color.Blue;
			this.btnRuaj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRuaj.DoValidation = true;
			this.btnRuaj.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnRuaj.Location = new System.Drawing.Point(44, 456);
			this.btnRuaj.Name = "btnRuaj";
			this.btnRuaj.Size = new System.Drawing.Size(90, 21);
			this.btnRuaj.TabIndex = 3;
			this.btnRuaj.Text = "Ruaj";
			this.toolTips.SetToolTip(this.btnRuaj, "Ruan ndryshimet e bera ne informacionet per hotelin!");
			this.btnRuaj.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
			// 
			// label7
			// 
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label7.Location = new System.Drawing.Point(8, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(212, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "Mesazh falenderimi per rezervim ne hotel";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label8.Location = new System.Drawing.Point(8, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(212, 20);
			this.label8.TabIndex = 13;
			this.label8.Text = "Mesazh falenderimi per qendrim ne hotel";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.txtFQendrimi);
			this.groupBox2.Controls.Add(this.txtFRezervimi);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(10, 268);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(520, 180);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.Text = "Konfigurimi i mesazheve te falenderimit";
			this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// txtFQendrimi
			// 
			this.txtFQendrimi.AutoSize = false;
			this.txtFQendrimi.DefaultErrorMessage = "";
			this.txtFQendrimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtFQendrimi.FixedLength = false;
			this.txtFQendrimi.IsValid = true;
			this.txtFQendrimi.Location = new System.Drawing.Point(228, 100);
			this.txtFQendrimi.Multiline = true;
			this.txtFQendrimi.Name = "txtFQendrimi";
			this.txtFQendrimi.Required = false;
			this.txtFQendrimi.RequiredControlColor = System.Drawing.Color.White;
			this.txtFQendrimi.Size = new System.Drawing.Size(276, 64);
			this.txtFQendrimi.TabIndex = 15;
			this.txtFQendrimi.Text = "";
			this.toolTips.SetToolTip(this.txtFQendrimi, "Ky mesazh do te sherbeje si mesazh falenderimi ne fature! ");
			// 
			// txtFRezervimi
			// 
			this.txtFRezervimi.AutoSize = false;
			this.txtFRezervimi.DefaultErrorMessage = "";
			this.txtFRezervimi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtFRezervimi.FixedLength = false;
			this.txtFRezervimi.IsValid = true;
			this.txtFRezervimi.Location = new System.Drawing.Point(228, 28);
			this.txtFRezervimi.Multiline = true;
			this.txtFRezervimi.Name = "txtFRezervimi";
			this.txtFRezervimi.Required = false;
			this.txtFRezervimi.RequiredControlColor = System.Drawing.Color.White;
			this.txtFRezervimi.Size = new System.Drawing.Size(276, 64);
			this.txtFRezervimi.TabIndex = 14;
			this.txtFRezervimi.Text = "";
			// 
			// frmTeDhenaHoteli
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(896, 528);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnRuaj);
			this.Controls.Add(this.groupBox1);
			this.HelpFile = "INFORMACIONE.htm";
			this.Name = "frmTeDhenaHoteli";
			this.Text = "Informacione";
			this.TitullGjeresi = 896;
			this.Load += new System.EventHandler(this.frmTeDhenaHoteli_Load);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.btnRuaj, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			string s = "";
			s = this.ZgjidhLogo(this.openFileDialog1, "Figura|*.bmp;*.ico;*.cur;*.jpg;*.gif");
			if (s == "") 
			{
				return;
			}
			else
			{
				this.pictureBox1.Image = Image.FromFile(s);
				this.PicturePath = s;
			}

		}



		#region Private Methods
		private string ZgjidhLogo(System.Windows.Forms.OpenFileDialog c, string s)
		{
			c.FileName = "";
			string result = "";
			c.CheckFileExists = true;
			try
			{
				c.Filter = s;
				c.ShowDialog();
				result = c.FileName;
				return result;
			}
			catch
			{
				return "";
			}
		}

		private void btnRuaj_Click(object sender, System.EventArgs e)
		{
			try
			{
				emer = this.txtEmri.Text;
				adrese = this.txtAdresa.Text;
				telefon = this.txtTelefoni.Text;
				email = this.txtEmail.Text;
				website = this.txtWebSite.Text;
				smsRezervim = this.txtFRezervimi.Text;
				smsQendrim = this.txtFQendrimi.Text;
				kodFiskal = this.txtKodFiskal.Text;
				this.HidhXml();
				VisionInfoSolutionLibrary.MessageBox.Show(this, "Informacione per hotelin", "Informacionet per hotelin u ruajten", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(Exception ex)
			{
				return;
			}

		}
		/// <summary>
		/// Hedh te dhenat ne skedarin Xml
		/// </summary>
		private void HidhXml()
		{
			string fileName = Application.StartupPath + "\\Informacione.xml";
			XmlTextWriter tw = new XmlTextWriter(fileName, null);
			tw.Formatting = Formatting.Indented;
			tw.WriteStartDocument();
			
			tw.WriteStartElement("Informacione");
			tw.WriteElementString("Emri", this.emer);
			tw.WriteElementString("Adresa", this.adrese);
			tw.WriteElementString("Telefoni", this.telefon);
			tw.WriteElementString("E-maili", this.email);
			tw.WriteElementString("Website-i", this.website);
			tw.WriteElementString("KodiFiskal", this.kodFiskal);
			tw.WriteElementString("MesazhRezervimi", this.smsRezervim);
			tw.WriteElementString("MesazhQendrimi", this.smsQendrim);
			tw.WriteElementString("LogoPath", this.PicturePath);
		
			tw.WriteEndElement();
			tw.WriteEndDocument();
			tw.Flush();
			tw.Close();
		}

		//lexon te dhenat nga skedari Xml
		private void LexoXml()
		{
			//bool vlera = false;
			string str = "";
			string fileName = Application.StartupPath + "\\Informacione.xml";
			XmlTextReader tr = new XmlTextReader(fileName);
			try
			{
				while(tr.Read())
				{	
					if (tr.NodeType == XmlNodeType.Element)
					{
						str = tr.LocalName.ToString();
						switch (str)
						{
							case "Emri":
								this.txtEmri.Text = tr.ReadElementString(str).ToString();
								break;
							case "Adresa":
								this.txtAdresa.Text = tr.ReadElementString(str).ToString();
								break;
							case "Telefoni":
								this.txtTelefoni.Text = tr.ReadElementString(str).ToString();
								break;
							case "E-maili":
								this.txtEmail.Text = tr.ReadElementString(str).ToString();
								break;
							case "Website-i":
								this.txtWebSite.Text = tr.ReadElementString(str).ToString();
								break;
							case "KodiFiskal":
								this.txtKodFiskal.Text = tr.ReadElementString(str).ToString();
								break;
							case "LogoPath":
								string x = tr.ReadElementString(str).ToString(); 
								if (x!= "")
									this.pictureBox1.Image = Image.FromFile(x);
								this.PicturePath = x;
								break;
							case "MesazhRezervimi":
								this.txtFRezervimi.Text = tr.ReadElementString(str).ToString();
								break;
							case "MesazhQendrimi":
								this.txtFQendrimi.Text = tr.ReadElementString(str).ToString();
								break;
							default:
								
								break;
						}	  
					}
				}
			}
			catch
			{
				System.Windows.Forms.MessageBox.Show(this, "Skedari ku ju keni ruajtur logon e hotelit " + System.Environment.NewLine + "eshte fshire ose nuk gjendet!", "Informacione per hotelin", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
				return;
			}
			finally
			{
				tr.Close();
			}
		}


		/// <summary>
		/// Merr si parameter nje string dhe nga i cili te gjitha hapesirat i zevendeson me karakterin '_'
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		private string FormatString(string str)
		{
			string vlera = "";
			string[] str1 = str.Split(' ');
			for (int i = 0; i < str1.Length; i++)
			{
				vlera += str1.GetValue(i);
				if (i < str1.Length - 1)
					vlera += "_";
			}
			return vlera;
		}


		/// <summary>
		/// Merr si parameter nje string dhe te gjitha karakteret '_' i zevendeson me hapesire
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		private string FormatStringAna(string str)
		{
			string vlera = "";
			string[] str1 = str.Split('_');
			for (int i = 0; i < str1.Length; i++)
			{
				vlera += str1.GetValue(i);
				if (i < str1.Length - 1)
					vlera += " ";
			}
			return vlera;
		}

		#endregion

		private void frmTeDhenaHoteli_Load(object sender, System.EventArgs e)
		{
			//pastrim variablash private
			this.PicturePath = "";
			this.emer = "";
			this.adrese = "";
			this.telefon = "";
			this.email = "";
			this.website = "";
			this.kodFiskal = "";
			this.smsRezervim = "";
			this.smsQendrim = "" ;
			//pastrim variablash private
			this.LexoXml();
		}

		private void btnFshi_Click(object sender, System.EventArgs e)
		{
			this.pictureBox1.Image = null  ;
			this.PicturePath = "";
		}

	}
}

