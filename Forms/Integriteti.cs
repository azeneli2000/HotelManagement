using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Management;
using System.Globalization;

namespace HotelManagment.Forms
{
	public class Integriteti : VisionInfoSolutionLibrary.Form
	{
		#region Private Declarations
		private VisionInfoSolutionLibrary.Label lblDorezoDhome;
		private System.Windows.Forms.LinkLabel lblKlikoDorezoDhome;
		private VisionInfoSolutionLibrary.Label lblRezervoDhome;
		private System.Windows.Forms.LinkLabel lblKlikoRezervo;
		private VisionInfoSolutionLibrary.Button btnOK;
		private VisionInfoSolutionLibrary.TabControl tabControl1;
		private VisionInfoSolutionLibrary.TabPageControl tbProgrami;
		private VisionInfoSolutionLibrary.TabPageControl tbSistemi;
		private VisionInfoSolutionLibrary.Label label1;
		private System.Windows.Forms.Label lblLlojProcesori;
		private VisionInfoSolutionLibrary.Label label3;
		private System.Windows.Forms.Label lblEmriProcesori;
		private VisionInfoSolutionLibrary.Label label5;
		private System.Windows.Forms.Label lblEmriPC;
		private VisionInfoSolutionLibrary.Label label7;
		private System.Windows.Forms.Label lblSistemi;
		private VisionInfoSolutionLibrary.Label label4;
		private VisionInfoSolutionLibrary.Label label6;
		private System.Windows.Forms.Label lblKartaGrafike;
		private VisionInfoSolutionLibrary.Label label9;
		private System.Windows.Forms.Label lblShpejtesiaProcesorit;
		private System.Windows.Forms.Label lblMemoriaKartes;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.Label label8;
		private VisionInfoSolutionLibrary.Label label10;
		private System.ComponentModel.IContainer components = null;
		#endregion

		#region Constructors & Destructors
		public Integriteti()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Integriteti));
			this.lblDorezoDhome = new VisionInfoSolutionLibrary.Label();
			this.lblKlikoDorezoDhome = new System.Windows.Forms.LinkLabel();
			this.lblRezervoDhome = new VisionInfoSolutionLibrary.Label();
			this.lblKlikoRezervo = new System.Windows.Forms.LinkLabel();
			this.btnOK = new VisionInfoSolutionLibrary.Button(this.components);
			this.tabControl1 = new VisionInfoSolutionLibrary.TabControl();
			this.tbProgrami = new VisionInfoSolutionLibrary.TabPageControl();
			this.tbSistemi = new VisionInfoSolutionLibrary.TabPageControl();
			this.label10 = new VisionInfoSolutionLibrary.Label();
			this.label8 = new VisionInfoSolutionLibrary.Label();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.lblMemoriaKartes = new System.Windows.Forms.Label();
			this.label9 = new VisionInfoSolutionLibrary.Label();
			this.lblKartaGrafike = new System.Windows.Forms.Label();
			this.label6 = new VisionInfoSolutionLibrary.Label();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.lblShpejtesiaProcesorit = new System.Windows.Forms.Label();
			this.lblSistemi = new System.Windows.Forms.Label();
			this.label7 = new VisionInfoSolutionLibrary.Label();
			this.lblEmriPC = new System.Windows.Forms.Label();
			this.label5 = new VisionInfoSolutionLibrary.Label();
			this.lblEmriProcesori = new System.Windows.Forms.Label();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.lblLlojProcesori = new System.Windows.Forms.Label();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.tabControl1.SuspendLayout();
			this.tbProgrami.SuspendLayout();
			this.tbSistemi.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(526, 24);
			// 
			// lblDorezoDhome
			// 
			this.lblDorezoDhome.BackColor = System.Drawing.Color.Transparent;
			this.lblDorezoDhome.Location = new System.Drawing.Point(8, 20);
			this.lblDorezoDhome.Name = "lblDorezoDhome";
			this.lblDorezoDhome.Size = new System.Drawing.Size(424, 20);
			this.lblDorezoDhome.TabIndex = 1;
			this.lblDorezoDhome.Text = "Nuk ka asnje dhome qe nuk eshte dorezuar brenda afatit";
			// 
			// lblKlikoDorezoDhome
			// 
			this.lblKlikoDorezoDhome.BackColor = System.Drawing.Color.Transparent;
			this.lblKlikoDorezoDhome.Location = new System.Drawing.Point(8, 40);
			this.lblKlikoDorezoDhome.Name = "lblKlikoDorezoDhome";
			this.lblKlikoDorezoDhome.Size = new System.Drawing.Size(272, 20);
			this.lblKlikoDorezoDhome.TabIndex = 2;
			this.lblKlikoDorezoDhome.TabStop = true;
			this.lblKlikoDorezoDhome.Text = "Kliko ketu per te dorezuar dhomat";
			this.lblKlikoDorezoDhome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// lblRezervoDhome
			// 
			this.lblRezervoDhome.BackColor = System.Drawing.Color.Transparent;
			this.lblRezervoDhome.Location = new System.Drawing.Point(4, 76);
			this.lblRezervoDhome.Name = "lblRezervoDhome";
			this.lblRezervoDhome.Size = new System.Drawing.Size(424, 20);
			this.lblRezervoDhome.TabIndex = 3;
			this.lblRezervoDhome.Text = "Nuk ka asnje dhome qe ti kete skaduar afati i rezervimit";
			// 
			// lblKlikoRezervo
			// 
			this.lblKlikoRezervo.BackColor = System.Drawing.Color.Transparent;
			this.lblKlikoRezervo.Location = new System.Drawing.Point(4, 96);
			this.lblKlikoRezervo.Name = "lblKlikoRezervo";
			this.lblKlikoRezervo.Size = new System.Drawing.Size(276, 23);
			this.lblKlikoRezervo.TabIndex = 4;
			this.lblKlikoRezervo.TabStop = true;
			this.lblKlikoRezervo.Text = "Kliko ketu per te modifikuar ose fshire rezervimet";
			this.lblKlikoRezervo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblKlikoRezervo_LinkClicked);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnOK.DoValidation = true;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.Location = new System.Drawing.Point(204, 304);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(90, 21);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "Dil";
			this.btnOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tbProgrami);
			this.tabControl1.Controls.Add(this.tbSistemi);
			this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(528, 292);
			this.tabControl1.TabIndex = 6;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tbProgrami
			// 
			this.tbProgrami.BackColor = System.Drawing.SystemColors.Control;
			this.tbProgrami.Controls.Add(this.lblDorezoDhome);
			this.tbProgrami.Controls.Add(this.lblKlikoRezervo);
			this.tbProgrami.Controls.Add(this.lblRezervoDhome);
			this.tbProgrami.Controls.Add(this.lblKlikoDorezoDhome);
			this.tbProgrami.DefaultErrorMessage = null;
			this.tbProgrami.DockPadding.Bottom = 100;
			this.tbProgrami.EnableValidation = true;
			this.tbProgrami.IsValid = false;
			this.tbProgrami.Location = new System.Drawing.Point(4, 22);
			this.tbProgrami.Name = "tbProgrami";
			this.tbProgrami.Size = new System.Drawing.Size(520, 266);
			this.tbProgrami.TabIndex = 0;
			this.tbProgrami.Text = "Programi";
			// 
			// tbSistemi
			// 
			this.tbSistemi.BackColor = System.Drawing.SystemColors.Control;
			this.tbSistemi.Controls.Add(this.label10);
			this.tbSistemi.Controls.Add(this.label8);
			this.tbSistemi.Controls.Add(this.label2);
			this.tbSistemi.Controls.Add(this.lblMemoriaKartes);
			this.tbSistemi.Controls.Add(this.label9);
			this.tbSistemi.Controls.Add(this.lblKartaGrafike);
			this.tbSistemi.Controls.Add(this.label6);
			this.tbSistemi.Controls.Add(this.label4);
			this.tbSistemi.Controls.Add(this.lblShpejtesiaProcesorit);
			this.tbSistemi.Controls.Add(this.lblSistemi);
			this.tbSistemi.Controls.Add(this.label7);
			this.tbSistemi.Controls.Add(this.lblEmriPC);
			this.tbSistemi.Controls.Add(this.label5);
			this.tbSistemi.Controls.Add(this.lblEmriProcesori);
			this.tbSistemi.Controls.Add(this.label3);
			this.tbSistemi.Controls.Add(this.lblLlojProcesori);
			this.tbSistemi.Controls.Add(this.label1);
			this.tbSistemi.DefaultErrorMessage = null;
			this.tbSistemi.EnableValidation = true;
			this.tbSistemi.IsValid = false;
			this.tbSistemi.Location = new System.Drawing.Point(4, 22);
			this.tbSistemi.Name = "tbSistemi";
			this.tbSistemi.Size = new System.Drawing.Size(520, 266);
			this.tbSistemi.TabIndex = 1;
			this.tbSistemi.Text = "Sistemi";
			// 
			// label10
			// 
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Location = new System.Drawing.Point(0, 204);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(524, 3);
			this.label10.TabIndex = 16;
			this.label10.Text = "label10";
			this.label10.Visible = false;
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(-4, 148);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(528, 3);
			this.label8.TabIndex = 15;
			this.label8.Text = "label8";
			this.label8.Visible = false;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(-8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(532, 3);
			this.label2.TabIndex = 14;
			this.label2.Text = "label2";
			this.label2.Visible = false;
			// 
			// lblMemoriaKartes
			// 
			this.lblMemoriaKartes.BackColor = System.Drawing.Color.Transparent;
			this.lblMemoriaKartes.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblMemoriaKartes.Location = new System.Drawing.Point(160, 184);
			this.lblMemoriaKartes.Name = "lblMemoriaKartes";
			this.lblMemoriaKartes.Size = new System.Drawing.Size(344, 20);
			this.lblMemoriaKartes.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(16, 184);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(132, 20);
			this.label9.TabIndex = 12;
			this.label9.Text = "Memoria e kartes grafike";
			// 
			// lblKartaGrafike
			// 
			this.lblKartaGrafike.BackColor = System.Drawing.Color.Transparent;
			this.lblKartaGrafike.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblKartaGrafike.Location = new System.Drawing.Point(160, 156);
			this.lblKartaGrafike.Name = "lblKartaGrafike";
			this.lblKartaGrafike.Size = new System.Drawing.Size(348, 20);
			this.lblKartaGrafike.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(16, 156);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(132, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "Karta Grafike";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(16, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "Shpejtesia e procesorit";
			// 
			// lblShpejtesiaProcesorit
			// 
			this.lblShpejtesiaProcesorit.BackColor = System.Drawing.Color.Transparent;
			this.lblShpejtesiaProcesorit.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblShpejtesiaProcesorit.Location = new System.Drawing.Point(160, 128);
			this.lblShpejtesiaProcesorit.Name = "lblShpejtesiaProcesorit";
			this.lblShpejtesiaProcesorit.Size = new System.Drawing.Size(348, 20);
			this.lblShpejtesiaProcesorit.TabIndex = 8;
			// 
			// lblSistemi
			// 
			this.lblSistemi.BackColor = System.Drawing.Color.Transparent;
			this.lblSistemi.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSistemi.Location = new System.Drawing.Point(160, 16);
			this.lblSistemi.Name = "lblSistemi";
			this.lblSistemi.Size = new System.Drawing.Size(352, 20);
			this.lblSistemi.TabIndex = 7;
			this.lblSistemi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(16, 44);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(132, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "Emri i kompjuterit";
			// 
			// lblEmriPC
			// 
			this.lblEmriPC.BackColor = System.Drawing.Color.Transparent;
			this.lblEmriPC.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEmriPC.Location = new System.Drawing.Point(160, 44);
			this.lblEmriPC.Name = "lblEmriPC";
			this.lblEmriPC.Size = new System.Drawing.Size(352, 20);
			this.lblEmriPC.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(16, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(132, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Procesori";
			// 
			// lblEmriProcesori
			// 
			this.lblEmriProcesori.BackColor = System.Drawing.Color.Transparent;
			this.lblEmriProcesori.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEmriProcesori.Location = new System.Drawing.Point(160, 72);
			this.lblEmriProcesori.Name = "lblEmriProcesori";
			this.lblEmriProcesori.Size = new System.Drawing.Size(352, 20);
			this.lblEmriProcesori.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(16, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Lloji i procesorit";
			// 
			// lblLlojProcesori
			// 
			this.lblLlojProcesori.BackColor = System.Drawing.Color.Transparent;
			this.lblLlojProcesori.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLlojProcesori.Location = new System.Drawing.Point(160, 100);
			this.lblLlojProcesori.Name = "lblLlojProcesori";
			this.lblLlojProcesori.Size = new System.Drawing.Size(348, 20);
			this.lblLlojProcesori.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sistemi i shfrytezimit";
			// 
			// Integriteti
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = false;
			this.CancelButton = this.btnOK;
			this.ClientSize = new System.Drawing.Size(526, 352);
			this.ControlBox = true;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpFile = "KONTROLLO SISTEMIN.htm";
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Integriteti";
			this.ShfaqTitull = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TitullGjeresi = 526;
			this.Load += new System.EventHandler(this.Integriteti_Load);
			this.Controls.SetChildIndex(this.btnOK, 0);
			this.Controls.SetChildIndex(this.tabControl1, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.tabControl1.ResumeLayout(false);
			this.tbProgrami.ResumeLayout(false);
			this.tbSistemi.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MainForm frm = this.Main as MainForm;
			if (frm != null)
			{
				frm.AddNewTab(new DorezoDhome1());
				this.Close();
			}
		}

		private void Integriteti_Load(object sender, System.EventArgs e)
		{
			int klient = 0;
			int grup = 0;
			int rezervimKlient = 0;
			int rezervimGrup = 0;
			InputController data = new InputController();
			DataSet ds = data.KerkesaRead("KontrolloDhomatPaDorezuaraKliente");
			klient = ds.Tables[0].Rows.Count;
			// Kontrollo numrin e dhomave te padorezuara per grupet	
			ds.Tables.Clear();
			ds = data.KerkesaRead("KontrolloDhomatPaDorezuaraGrupe");
			grup = ds.Tables[0].Rows.Count;
			// Kontrollo numrin e dhomave qe iu ka skaduar rezervimi per kliente
			ds.Tables.Clear();
			ds = data.KerkesaRead("ShfaqRezervimeSkaduara");
			rezervimKlient = ds.Tables[0].Rows.Count;
			// Kontrollo numrin e dhomave qe iu ka skaduar rezervimi per grupe
			ds.Tables.Clear();
			ds = data.KerkesaRead("ShfaqRezervimeSkaduaraGrupe");
			rezervimGrup = ds.Tables[0].Rows.Count;
			this.ShowLabels(klient, grup, rezervimKlient, rezervimGrup);
		}

		private void lblKlikoRezervo_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MainForm frm = this.Main as MainForm;
			if (frm != null)
			{
				frm.AddNewTab(new ModifikoRezervim());
				this.Close();
			}
		}
		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region Private Methods
		/// <summary>
		/// Ben organizimin e labels qe jane ne forme, ne varesi te numrit te dhomave qe jane te 
		/// padorezuara per kliente dhe grupe dhe numrit te dhomave qe iu ka skaduar afati per
		/// kliente dhe grupe
		/// </summary>
		/// <param name="dKlient">numri i dhomave te padorezuara brenda afatit per kliente</param>
		/// <param name="dGrup">numri i dhomave te padorezuara brenda afatit per grupe</param>
		/// <param name="rKlient">numri i dhomave qe iu ka skaduar afati i rezervimit per kliente</param>
		/// <param name="rGrup">numri i dhomave qe iu ka skaduar afati i rezervimit per grupe</param>
		private void ShowLabels(int dKlient, int dGrup, int rKlient, int rGrup)
		{
			if (dKlient + dGrup > 0)
			{
				if (dKlient > 0 && dGrup > 0)
					this.lblDorezoDhome.Text = "Kujdes! Keni " + dKlient + " dhoma te padorezuara nga kliente" +
						" dhe " + dGrup + " nga grupet";
				else if (dKlient > 0)
					this.lblDorezoDhome.Text = "Kujdes! Keni " + dKlient + " dhoma te padorezuara nga kliente";
				else if (dGrup > 0)
					this.lblDorezoDhome.Text = "Kujdes! Keni " + dGrup + " dhoma te padorezuara nga grupet";
			}
			else
				this.lblKlikoDorezoDhome.Visible = false;
			if (rKlient + rGrup > 0)
			{
				if (rKlient > 0 && rGrup > 0)
				{
					this.lblRezervoDhome.Text = "Kujdes! Keni " + rKlient + " dhoma te rezervuara nga kliente" +
						" te cilave iu ka skaduar afati dhe " + rGrup + " dhoma te rezervuara nga grupe" + 
						" te cilave iu ka skaduar afati";
					this.lblRezervoDhome.Height = 34;
					this.lblKlikoRezervo.Top = 146;
				}			
				else if (rKlient > 0)
					this.lblRezervoDhome.Text = "Kujdes! Keni " + rKlient + " dhoma te rezervuara nga kliente" +
						" te cilave iu ka skaduar afati";
				else if (rGrup > 0)
					this.lblRezervoDhome.Text = "Kujdes! Keni " + rGrup + " dhoma te rezervuara nga grupe"
						+ " te cilave iu ka skaduar afati";
			}
			else
				this.lblKlikoRezervo.Visible = false;
		}


		/// <summary>
		/// Ben formatimin e shpejtesise ne Hz
		/// </summary>
		/// <param name="lSpeed"></param>
		/// <returns>stringSpeed</returns>
		private string formatSpeed(Int64 lSpeed)
		{
			//Formaton numrin ne Hz
			float floatSpeed = 0;
			string stringSpeed = "";
			NumberFormatInfo myNfi = new NumberFormatInfo();

			if (lSpeed < 1000 ) 
			{
				//Nese shpejtesia eshte me pak se 1GHz
				stringSpeed = lSpeed.ToString() + " MHz";
			}
			else 
			{
				//Konverto ne GHz
				floatSpeed = (float) lSpeed / 1000;
				stringSpeed = floatSpeed.ToString() + " GHz";
			}

			return stringSpeed;

		}

	
		/// <summary>
		/// Ben formatimin e numrit ne KB
		/// </summary>
		/// <param name="lSize"></param>
		/// <param name="booleanFormatOnly"></param>
		/// <returns>stringSize + " KB"</returns>
		private string formatSize(Int64 lSize, bool booleanFormatOnly)
		{
			//Formato numrin ne KB
			string stringSize = "";
			NumberFormatInfo myNfi = new NumberFormatInfo();

			Int64 lKBSize = 0;

			if (lSize < 1024 ) 
			{
				if (lSize == 0) 
				{
					stringSize = "0";
				}
				else 
				{
					//Me pak se 1 KB por nuk eshte 0 B
					stringSize = "1";
				}
			}
			else 
			{
				if (booleanFormatOnly == false)
				{
					//convert to KB
					lKBSize = lSize / 1024;
				}
				else 
				{
					lKBSize = lSize;
				}

				//Formato numrin ne formatin Default
				stringSize = lKBSize.ToString("n",myNfi);
				//Hiq presjet dhjetore
				stringSize = stringSize.Replace(".00", "");
			}

			return stringSize + " KB";

		}

		
		/// <summary>
		/// Merr te dhenat e sistemit te shfrytezimit dhe te kompjuterit.
		/// </summary>
		private void SystemInfo()
		{
			try
			{
				ManagementObjectSearcher query;
				ManagementObjectCollection queryCollection;
				System.Management.ObjectQuery oq;
				string stringMachineName = "localhost";
				//Krijon lidhjen me kompjuterin
				ConnectionOptions co = new ConnectionOptions();
				//Shenjon te makina
				System.Management.ManagementScope ms = new System.Management.ManagementScope("\\\\" + stringMachineName + "\\root\\cimv2", co);      
				// Marrim te dhenat nga sistemi i shfrytezimit per llojin e sistemit dhe emrin
				oq = new System.Management.ObjectQuery("SELECT * FROM Win32_OperatingSystem");
				query = new ManagementObjectSearcher(ms,oq);
				queryCollection = query.Get();
				foreach ( ManagementObject mo in queryCollection)
				{
					lblSistemi.Text = mo["Caption"].ToString();
					lblEmriPC.Text = mo["csname"].ToString();
				}

				// Marrim informacionet per procesorin
				oq = new System.Management.ObjectQuery("SELECT * FROM Win32_processor");
				query = new ManagementObjectSearcher(ms,oq);
				queryCollection = query.Get();
				foreach (ManagementObject mo in queryCollection)
				{
					this.lblEmriProcesori.Text = mo["Caption"].ToString();
					this.lblLlojProcesori.Text = mo["Manufacturer"].ToString();
					this.lblShpejtesiaProcesorit.Text = formatSpeed(Int64.Parse(mo["MaxClockSpeed"].ToString()));
				}
			
				//Marrim te dhenat per karten grafike
				oq = new System.Management.ObjectQuery("SELECT * FROM Win32_VideoController");
				query = new ManagementObjectSearcher(ms,oq);
				queryCollection = query.Get();
				foreach(ManagementObject mo in queryCollection)
				{
					this.lblKartaGrafike.Text = mo["Name"].ToString();
					if (mo["AdapterRAM"] == null)
					{
						this.lblMemoriaKartes.Text = mo["AdapterRAM"].ToString();
					}
					else
					{
						this.lblMemoriaKartes.Text = formatSize(Int64.Parse(mo["AdapterRAM"].ToString()), false);
					}
				}
			}
			catch
			{}
			finally
			{
				this.label2.Visible = true;
				this.label8.Visible = true;
				this.label10.Visible = true;
			}
		}

		#endregion

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (tabControl1.SelectedIndex == 1)
			{
				this.Cursor = Cursors.WaitCursor;
				this.SystemInfo();
				this.Cursor = Cursors.Default;
			}
			else
			{
				this.label10.Visible = false;
				this.label2.Visible = false;
				this.label8.Visible = false;
			}
		}

	}
}

