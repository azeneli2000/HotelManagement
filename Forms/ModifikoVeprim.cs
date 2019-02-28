using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using VisionInfoSolutionLibrary;

namespace HotelManagment.Forms
{
	public class ModifikoVeprim : VisionInfoSolutionLibrary.Form
	{
		#region privateVariables
		private VisionInfoSolutionLibrary.Button btnKerko;
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.GroupBox gbZgjidh;
		private VisionInfoSolutionLibrary.TextBox txtMbiemri1;
		private VisionInfoSolutionLibrary.TextBox txtEmri1;
		private VisionInfoSolutionLibrary.Label label2;
		private VisionInfoSolutionLibrary.Label lblEmr;
		private VisionInfoSolutionLibrary.Label lblMbarim;
		private VisionInfoSolutionLibrary.Label lblFillim;
		private VisionInfoSolutionLibrary.DateTimePicker dtpDeri;
		private VisionInfoSolutionLibrary.DateTimePicker dtpPrej;
		private VisionInfoSolutionLibrary.GroupBox gbVeprime;
		private VisionInfoSolutionLibrary.Button btnKerko1;
		private VisionInfoSolutionLibrary.TextBox txtEmerGrupi;
		private VisionInfoSolutionLibrary.Label label3;
		private VisionInfoSolutionLibrary.Label label4;
		private VisionInfoSolutionLibrary.TextBox txtAgjensia1;
		private VisionInfoSolutionLibrary.DataGrid grid;
		private VisionInfoSolutionLibrary.RadioButton rbData;
		private VisionInfoSolutionLibrary.RadioButton rbEmri;
		private VisionInfoSolutionLibrary.RadioButton rbGrupi;
		private System.ComponentModel.IContainer components = null;
		private DataSet ds = null;
		private int numer_rreshtash = 0;
		private int idKlienti;
		private int idGrupi;
		private int idIdentifikimi;
		private int idLloji;
		private int idKategoria;
		private DateTime dtFillimi;
		private DateTime dtMbarimi;
		private int idDhoma;
		#endregion

		#region Constructors
		public ModifikoVeprim()
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
			this.gbVeprime = new VisionInfoSolutionLibrary.GroupBox();
			this.grid = new VisionInfoSolutionLibrary.DataGrid();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.btnKerko = new VisionInfoSolutionLibrary.Button(this.components);
			this.gbZgjidh = new VisionInfoSolutionLibrary.GroupBox();
			this.txtAgjensia1 = new VisionInfoSolutionLibrary.TextBox();
			this.label4 = new VisionInfoSolutionLibrary.Label();
			this.label3 = new VisionInfoSolutionLibrary.Label();
			this.txtEmerGrupi = new VisionInfoSolutionLibrary.TextBox();
			this.txtMbiemri1 = new VisionInfoSolutionLibrary.TextBox();
			this.txtEmri1 = new VisionInfoSolutionLibrary.TextBox();
			this.label2 = new VisionInfoSolutionLibrary.Label();
			this.lblEmr = new VisionInfoSolutionLibrary.Label();
			this.lblMbarim = new VisionInfoSolutionLibrary.Label();
			this.lblFillim = new VisionInfoSolutionLibrary.Label();
			this.dtpDeri = new VisionInfoSolutionLibrary.DateTimePicker();
			this.dtpPrej = new VisionInfoSolutionLibrary.DateTimePicker();
			this.rbData = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbEmri = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.rbGrupi = new VisionInfoSolutionLibrary.RadioButton(this.components);
			this.btnKerko1 = new VisionInfoSolutionLibrary.Button(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gbVeprime)).BeginInit();
			this.gbVeprime.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gbZgjidh)).BeginInit();
			this.gbZgjidh.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(1036, 25);
			// 
			// gbVeprime
			// 
			this.gbVeprime.BackColor = System.Drawing.Color.Transparent;
			this.gbVeprime.Controls.Add(this.grid);
			this.gbVeprime.Controls.Add(this.label1);
			this.gbVeprime.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbVeprime.Location = new System.Drawing.Point(24, 176);
			this.gbVeprime.Name = "gbVeprime";
			this.gbVeprime.Size = new System.Drawing.Size(872, 220);
			this.gbVeprime.TabIndex = 1;
			this.gbVeprime.Text = "Veprime";
			this.gbVeprime.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// grid
			// 
			this.grid.AllowSorting = false;
			this.grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.grid.CanDelete = true;
			this.grid.CaptionVisible = false;
			this.grid.DataMember = "";
			this.grid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grid.HideHorizontalScrollBar = false;
			this.grid.HideVerticalScrollBar = false;
			this.grid.Location = new System.Drawing.Point(14, 36);
			this.grid.Name = "grid";
			this.grid.RowHeaderWidth = 20;
			this.grid.Selekto = true;
			this.grid.Size = new System.Drawing.Size(834, 168);
			this.grid.TabIndex = 1;
			this.grid.CurrentCellChanged += new System.EventHandler(this.grid_CurrentCellChanged);
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(17, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Veprimet e kryer ne datat e mesiperme";
			// 
			// btnKerko
			// 
			this.btnKerko.BackColor = System.Drawing.Color.Blue;
			this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko.DoValidation = true;
			this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko.Location = new System.Drawing.Point(368, 84);
			this.btnKerko.Name = "btnKerko";
			this.btnKerko.Size = new System.Drawing.Size(90, 21);
			this.btnKerko.TabIndex = 3;
			this.btnKerko.Text = "Kerko";
			this.btnKerko.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// gbZgjidh
			// 
			this.gbZgjidh.BackColor = System.Drawing.Color.Transparent;
			this.gbZgjidh.Controls.Add(this.txtAgjensia1);
			this.gbZgjidh.Controls.Add(this.label4);
			this.gbZgjidh.Controls.Add(this.label3);
			this.gbZgjidh.Controls.Add(this.txtEmerGrupi);
			this.gbZgjidh.Controls.Add(this.txtMbiemri1);
			this.gbZgjidh.Controls.Add(this.txtEmri1);
			this.gbZgjidh.Controls.Add(this.label2);
			this.gbZgjidh.Controls.Add(this.lblEmr);
			this.gbZgjidh.Controls.Add(this.lblMbarim);
			this.gbZgjidh.Controls.Add(this.lblFillim);
			this.gbZgjidh.Controls.Add(this.dtpDeri);
			this.gbZgjidh.Controls.Add(this.dtpPrej);
			this.gbZgjidh.Controls.Add(this.rbData);
			this.gbZgjidh.Controls.Add(this.rbEmri);
			this.gbZgjidh.Controls.Add(this.rbGrupi);
			this.gbZgjidh.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbZgjidh.Location = new System.Drawing.Point(24, 42);
			this.gbZgjidh.Name = "gbZgjidh";
			this.gbZgjidh.Size = new System.Drawing.Size(488, 134);
			this.gbZgjidh.TabIndex = 12;
			this.gbZgjidh.Text = "Kerko veprim sipas";
			this.gbZgjidh.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
			// 
			// txtAgjensia1
			// 
			this.txtAgjensia1.AutoSize = false;
			this.txtAgjensia1.DefaultErrorMessage = "Ju duhet te jepni grupin dhe agjensine per kerkim!";
			this.txtAgjensia1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtAgjensia1.FixedLength = false;
			this.txtAgjensia1.IsValid = true;
			this.txtAgjensia1.Location = new System.Drawing.Point(288, 104);
			this.txtAgjensia1.Name = "txtAgjensia1";
			this.txtAgjensia1.Required = false;
			this.txtAgjensia1.RequiredControlColor = System.Drawing.Color.White;
			this.txtAgjensia1.Size = new System.Drawing.Size(170, 20);
			this.txtAgjensia1.TabIndex = 14;
			this.txtAgjensia1.Text = "";
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Location = new System.Drawing.Point(288, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Agjensia";
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Location = new System.Drawing.Point(92, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Grupi";
			// 
			// txtEmerGrupi
			// 
			this.txtEmerGrupi.AutoSize = false;
			this.txtEmerGrupi.DefaultErrorMessage = "";
			this.txtEmerGrupi.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmerGrupi.FixedLength = false;
			this.txtEmerGrupi.IsValid = true;
			this.txtEmerGrupi.Location = new System.Drawing.Point(92, 104);
			this.txtEmerGrupi.Name = "txtEmerGrupi";
			this.txtEmerGrupi.Required = false;
			this.txtEmerGrupi.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmerGrupi.Size = new System.Drawing.Size(170, 20);
			this.txtEmerGrupi.TabIndex = 11;
			this.txtEmerGrupi.Text = "";
			// 
			// txtMbiemri1
			// 
			this.txtMbiemri1.AutoSize = false;
			this.txtMbiemri1.DefaultErrorMessage = "";
			this.txtMbiemri1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtMbiemri1.FixedLength = false;
			this.txtMbiemri1.IsValid = true;
			this.txtMbiemri1.Location = new System.Drawing.Point(288, 64);
			this.txtMbiemri1.Name = "txtMbiemri1";
			this.txtMbiemri1.Required = false;
			this.txtMbiemri1.RequiredControlColor = System.Drawing.Color.White;
			this.txtMbiemri1.Size = new System.Drawing.Size(170, 20);
			this.txtMbiemri1.TabIndex = 9;
			this.txtMbiemri1.Text = "";
			// 
			// txtEmri1
			// 
			this.txtEmri1.AutoSize = false;
			this.txtEmri1.DefaultErrorMessage = "";
			this.txtEmri1.DesabledControlColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmri1.FixedLength = false;
			this.txtEmri1.IsValid = true;
			this.txtEmri1.Location = new System.Drawing.Point(92, 64);
			this.txtEmri1.Name = "txtEmri1";
			this.txtEmri1.Required = false;
			this.txtEmri1.RequiredControlColor = System.Drawing.Color.White;
			this.txtEmri1.Size = new System.Drawing.Size(170, 20);
			this.txtEmri1.TabIndex = 8;
			this.txtEmri1.Text = "";
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(288, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Mbiemri";
			// 
			// lblEmr
			// 
			this.lblEmr.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblEmr.Location = new System.Drawing.Point(93, 52);
			this.lblEmr.Name = "lblEmr";
			this.lblEmr.Size = new System.Drawing.Size(60, 16);
			this.lblEmr.TabIndex = 6;
			this.lblEmr.Text = "Emri";
			// 
			// lblMbarim
			// 
			this.lblMbarim.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblMbarim.Location = new System.Drawing.Point(288, 15);
			this.lblMbarim.Name = "lblMbarim";
			this.lblMbarim.Size = new System.Drawing.Size(72, 12);
			this.lblMbarim.TabIndex = 3;
			this.lblMbarim.Text = "Deri ne daten";
			this.lblMbarim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblFillim
			// 
			this.lblFillim.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblFillim.Location = new System.Drawing.Point(92, 14);
			this.lblFillim.Name = "lblFillim";
			this.lblFillim.Size = new System.Drawing.Size(68, 13);
			this.lblFillim.TabIndex = 2;
			this.lblFillim.Text = "Nga data";
			this.lblFillim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpDeri
			// 
			this.dtpDeri.BackColor = System.Drawing.Color.White;
			this.dtpDeri.CustomFormat = "dd.MM.yyyy/ora hh:mm";
			this.dtpDeri.DefaultErrorMessage = "";
			this.dtpDeri.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDeri.IsValid = true;
			this.dtpDeri.Location = new System.Drawing.Point(288, 28);
			this.dtpDeri.Name = "dtpDeri";
			this.dtpDeri.Required = false;
			this.dtpDeri.ShowCheckBox = true;
			this.dtpDeri.ShowUpDown = true;
			this.dtpDeri.Size = new System.Drawing.Size(170, 20);
			this.dtpDeri.TabIndex = 1;
			this.dtpDeri.Value = new System.DateTime(2005, 7, 4, 14, 53, 0, 0);
			// 
			// dtpPrej
			// 
			this.dtpPrej.BackColor = System.Drawing.Color.White;
			this.dtpPrej.CustomFormat = "dd.MM.yyyy/ora hh:mm";
			this.dtpPrej.DefaultErrorMessage = "";
			this.dtpPrej.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPrej.IsValid = true;
			this.dtpPrej.Location = new System.Drawing.Point(92, 28);
			this.dtpPrej.Name = "dtpPrej";
			this.dtpPrej.Required = false;
			this.dtpPrej.ShowCheckBox = true;
			this.dtpPrej.ShowUpDown = true;
			this.dtpPrej.Size = new System.Drawing.Size(170, 20);
			this.dtpPrej.TabIndex = 0;
			this.dtpPrej.Value = new System.DateTime(2005, 7, 4, 14, 53, 0, 0);
			// 
			// rbData
			// 
			this.rbData.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rbData.Location = new System.Drawing.Point(12, 28);
			this.rbData.Name = "rbData";
			this.rbData.Size = new System.Drawing.Size(72, 24);
			this.rbData.TabIndex = 56;
			this.rbData.Text = "Dates";
			// 
			// rbEmri
			// 
			this.rbEmri.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rbEmri.Location = new System.Drawing.Point(12, 60);
			this.rbEmri.Name = "rbEmri";
			this.rbEmri.Size = new System.Drawing.Size(64, 24);
			this.rbEmri.TabIndex = 56;
			this.rbEmri.Text = "Emrit";
			// 
			// rbGrupi
			// 
			this.rbGrupi.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rbGrupi.Location = new System.Drawing.Point(12, 96);
			this.rbGrupi.Name = "rbGrupi";
			this.rbGrupi.Size = new System.Drawing.Size(60, 24);
			this.rbGrupi.TabIndex = 56;
			this.rbGrupi.Text = "Grupit";
			// 
			// btnKerko1
			// 
			this.btnKerko1.BackColor = System.Drawing.Color.Blue;
			this.btnKerko1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKerko1.DoValidation = false;
			this.btnKerko1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnKerko1.Location = new System.Drawing.Point(544, 100);
			this.btnKerko1.Name = "btnKerko1";
			this.btnKerko1.Size = new System.Drawing.Size(90, 21);
			this.btnKerko1.TabIndex = 13;
			this.btnKerko1.Text = "Kerko";
			this.btnKerko1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnKerko1.Click += new System.EventHandler(this.btnKerko1_Click);
			// 
			// ModifikoVeprim
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1036, 720);
			this.Controls.Add(this.btnKerko1);
			this.Controls.Add(this.gbZgjidh);
			this.Controls.Add(this.btnKerko);
			this.Controls.Add(this.gbVeprime);
			this.Name = "ModifikoVeprim";
			this.Text = "Modifiko veprim";
			this.TitullGjeresi = 1036;
			this.Load += new System.EventHandler(this.ModifikoVeprim_Load);
			this.Controls.SetChildIndex(this.gbVeprime, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			this.Controls.SetChildIndex(this.btnKerko, 0);
			this.Controls.SetChildIndex(this.gbZgjidh, 0);
			this.Controls.SetChildIndex(this.btnKerko1, 0);
			((System.ComponentModel.ISupportInitialize)(this.gbVeprime)).EndInit();
			this.gbVeprime.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gbZgjidh)).EndInit();
			this.gbZgjidh.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region ModifikoMethods

		
		private void btnKerko1_Click(object sender, System.EventArgs e)
		{
		
			
			try
			{
				InputController data = new InputController();
			
				if (this.rbData.Checked == true)
				{
					DateTime dateFillimi = Convert.ToDateTime(this.dtpPrej.Value);
					DateTime dateMbarimi = Convert.ToDateTime(this.dtpDeri.Value);
					this.label1.Text = "Veprimet e klienteve ne datat e dhena";
					DataSet ds = data.KerkesaRead("ShfaqVeprimetPerDatat", dateFillimi, dateMbarimi);
					this.grid.DataSource = ds.Tables[0];
					

					//mbush griden per kete rast
				}
				else if (this.rbEmri.Checked == true)
				{
					string emri = this.txtEmri1.Text;
					string mbiemri = this.txtMbiemri1.Text;
					this.label1.Text = "Te dhenat e klienteve me emer mbiemer te dhene";
					DataSet ds = data.KerkesaRead("ShfaqVeprimetPerKlientin", emri, mbiemri);
					this.grid.DataSource = ds.Tables[0];
				
					//mbush griden per kete rast
				}
				else if (this.rbGrupi.Checked == true)
				{
					string grupi = this.txtEmerGrupi.Text;
					string agjensia = this.txtAgjensia1.Text;
					this.label1.Text = "Te dhenat e klienteve per grupin dhe agjensine e dhene";
					DataSet ds = data.KerkesaRead("ShfaqVeprimetPerGrupin", grupi, agjensia);
					this.grid.DataSource = ds.Tables[0];
					
					//mbush griden per kete rast
				}
			}
			catch(Exception ex)
			{
			}
			

		}

		private void ModifikoVeprim_Load(object sender, System.EventArgs e)
		{
			
			InputController data = new InputController();
			try
			{
				ds = data.KerkesaRead("ShfaqKlientHotel");
				numer_rreshtash = ds.Tables[0].Rows.Count;
				this.grid.DataSource = ds.Tables[0];
				this.KrijoStilGride();
				
				this.label1.Text = "Te dhenat e klienteve qe jane ne hotel";
				
			
			}
			catch(Exception ex)
			{
			}

		}

		private void KrijoStilGride()
		{
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			this.grid.ReadOnly = true;

			DataGridTextBoxColumn colEmri = new DataGridTextBoxColumn();
			colEmri.HeaderText = "Emri";
			colEmri.MappingName = "EMRI";
			colEmri.NullText = "-";
			colEmri.Width = 53;

			DataGridTextBoxColumn colMbiemri = new DataGridTextBoxColumn();
			colMbiemri .HeaderText = "Mbiemri";
			colMbiemri .MappingName = "MBIEMRI";
			colMbiemri.NullText = "-";
			colMbiemri .Width = 55;

			DataGridTextBoxColumn colEmerGrupi= new DataGridTextBoxColumn();
			colEmerGrupi.HeaderText = "Emri i Grupit";
			colEmerGrupi.MappingName = "GRUPI";
			colEmerGrupi.NullText = "-";
			colEmerGrupi.Width = 74;

			DataGridTextBoxColumn colAgjensia = new DataGridTextBoxColumn();
			colAgjensia .HeaderText = "Agjensia";
			colAgjensia .MappingName = "AGJENSIA";
			colAgjensia.NullText = "-";
			colAgjensia .Width = 55;
			
			DataGridTextBoxColumn colMjetIdentifikimi = new DataGridTextBoxColumn();
			colMjetIdentifikimi .HeaderText = "Mjet Identifikimi";
			colMjetIdentifikimi .MappingName = "EMER_LLOJI";
			colMjetIdentifikimi.NullText = "-";
			colMjetIdentifikimi .Width = 92;

			DataGridTextBoxColumn colNrIdentifikimi = new DataGridTextBoxColumn();
			colNrIdentifikimi .HeaderText = "Nr Identifikimi";
			colNrIdentifikimi .MappingName = "NR_IDENTIFIKIMI";
			colNrIdentifikimi.NullText = "-";
			colNrIdentifikimi .Width = 85;

			DataGridTextBoxColumn colDatelindja = new DataGridTextBoxColumn();
			colDatelindja .HeaderText = "Datelindja";
			colDatelindja .MappingName = "DATELINDJA_STR";
			colDatelindja.NullText = "-";
			colDatelindja .Width = 77;

			DataGridTextBoxColumn colDatelindja1 = new DataGridTextBoxColumn();
			colDatelindja1 .HeaderText = "Datelindja";
			colDatelindja1 .MappingName = "DATELINDJA";
			colDatelindja1.NullText = "-";
			colDatelindja1 .Width = 0;
			
			DataGridTextBoxColumn colAdresa = new DataGridTextBoxColumn();
			colAdresa .HeaderText = "Adresa";
			colAdresa .MappingName = "ADRESA";
			colAdresa.NullText = "-";
			colAdresa .Width = 45;

			DataGridTextBoxColumn colNrTel = new DataGridTextBoxColumn();
			colNrTel .HeaderText = "Nr Tel";
			colNrTel .MappingName = "TELEFONI";
			colNrTel.NullText = "-";
			colNrTel .Width = 45;

			DataGridTextBoxColumn colTarga = new DataGridTextBoxColumn();
			colTarga .HeaderText = "Targa";
			colTarga .MappingName = "TARGA";
			colTarga.NullText = "-";
			colTarga .Width = 0;

			DataGridTextBoxColumn colEmail = new DataGridTextBoxColumn();
			colEmail .HeaderText = "Email";
			colEmail .MappingName = "EMAIL";
			colEmail.NullText = "-";
			colEmail .Width = 45;

			DataGridTextBoxColumn colDateFillimi = new DataGridTextBoxColumn();
			colDateFillimi.HeaderText = "Date Hyrje";
			colDateFillimi.MappingName = "DATA_HYRJE";
			colDateFillimi.Width = 0;
			colDateFillimi.NullText = "";

			DataGridTextBoxColumn colDateMbarimi = new DataGridTextBoxColumn();
			colDateMbarimi .HeaderText = "Date Dalje";
			colDateMbarimi .MappingName = "DATA_DALJE";
			colDateMbarimi .Width = 0;
			colDateMbarimi .NullText = "";

			DataGridTextBoxColumn colDateFillimi1 = new DataGridTextBoxColumn();
			colDateFillimi1.HeaderText = "Date Hyrje";
			colDateFillimi1.MappingName = "DATA_HYRJE_STR";
			colDateFillimi1.Width = 77;
			colDateFillimi1.NullText = "";

			DataGridTextBoxColumn colDateMbarimi1 = new DataGridTextBoxColumn();
			colDateMbarimi1 .HeaderText = "Date Dalje";
			colDateMbarimi1 .MappingName = "DATA_DALJE_STR";
			colDateMbarimi1 .Width = 77;
			colDateMbarimi1 .NullText = "";

			DataGridTextBoxColumn colKategoria = new DataGridTextBoxColumn();
			colKategoria.HeaderText = "Kategoria";
			colKategoria.MappingName = "KAT_EMRI";
			colKategoria.Width = 0;

			DataGridTextBoxColumn colDhoma = new DataGridTextBoxColumn();
			colDhoma.HeaderText = "Dhoma";
			colDhoma.MappingName = "DHOMA_EMRI";
			colDhoma.Width = 46;

			DataGridTextBoxColumn colKapari = new DataGridTextBoxColumn();
			colKapari.HeaderText = "Kapari";
			colKapari.MappingName = "KAPARI";
			colKapari.Width = 45;

			DataGridTextBoxColumn colCmimi = new DataGridTextBoxColumn();
			colCmimi.HeaderText = "Cmimi";
			colCmimi.MappingName = "CMIMI";
			colCmimi.Width = 0;

			

			DataGridTextBoxColumn colIdIden = new DataGridTextBoxColumn();
			colIdIden.HeaderText = "Id Identifikimi";
			colIdIden.MappingName = "ID_IDENTIFIKIMI";
			colIdIden.Width = 0;

			DataGridTextBoxColumn colIdLloji= new DataGridTextBoxColumn();
			colIdLloji.HeaderText = "Id Lloji";
			colIdLloji.MappingName = "ID_LLOJI";
			colIdLloji.Width = 0;

		
			DataGridTextBoxColumn colIdDhoma = new DataGridTextBoxColumn();
			colIdDhoma.HeaderText = "IdDhoma";
			colIdDhoma.MappingName = "ID_DHOMA";
			colIdDhoma.Width = 0;

			DataGridTextBoxColumn colIdKlienti = new DataGridTextBoxColumn();
			colIdKlienti.HeaderText = "IdKlienti";
			colIdKlienti.MappingName = "ID_KLIENTI";
			colIdKlienti.Width = 0;

			DataGridTextBoxColumn colIdGrupi = new DataGridTextBoxColumn();
			colIdGrupi.HeaderText = "IdGrupi";
			colIdGrupi.MappingName = "ID_GRUPI";
			colIdGrupi.Width = 0;

			DataGridTextBoxColumn colSkonto = new DataGridTextBoxColumn();
			colSkonto.HeaderText = "Skonto";
			colSkonto.MappingName = "SKONTO";
			colSkonto.Width = 45;

			DataGridTextBoxColumn colGjoba = new DataGridTextBoxColumn();
			colGjoba.HeaderText = "Gjoba";
			colGjoba.MappingName = "GJOBA";
			colGjoba.Width = 45;
			colGjoba.NullText = "-";

			DataGridTextBoxColumn colIdKategoria = new DataGridTextBoxColumn();
			colIdKategoria.HeaderText = "IdKategoria";
			colIdKategoria.MappingName = "ID_KATEGORIA";
			colIdKategoria.Width = 0;
			colSkonto.NullText = "-";

			style.GridColumnStyles.AddRange(
				new DataGridColumnStyle[]{colEmri, colMbiemri,colEmerGrupi,
			colAgjensia,colMjetIdentifikimi,colNrIdentifikimi,
			colDatelindja,colDatelindja1,colNrTel,colAdresa,colTarga ,colEmail,
			colDateFillimi, colDateMbarimi ,
			colDateFillimi1, colDateMbarimi1,colKategoria, colDhoma,
			colKapari,colCmimi,colIdIden,colIdLloji,colIdDhoma,colIdKlienti,colIdGrupi,colIdKategoria,colSkonto,colGjoba,});
			grid.TableStyles.Add(style);
			grid.FlatMode = false;
			grid.Expand(-1);

		}

		private void grid_CurrentCellChanged(object sender, System.EventArgs e)
		{
			
			int rowIndex = grid.CurrentRowIndex;
			idIdentifikimi = Convert.ToInt32(grid[rowIndex,20].ToString());
			idLloji = Convert.ToInt32(grid[rowIndex,21]);
			idDhoma = Convert.ToInt32(grid[rowIndex,22].ToString());
			idKlienti = Convert.ToInt32(grid[rowIndex,23].ToString());
			idKategoria = Convert.ToInt32(grid[rowIndex,25].ToString());	
			this.dtFillimi = Convert.ToDateTime(grid[rowIndex,12]);
			this.dtMbarimi = Convert.ToDateTime(grid[rowIndex,13]);
		    
			frmModifikoVeprim1 frm = new frmModifikoVeprim1(idKlienti,this.idKategoria,this.dtFillimi,this.dtMbarimi);
			frm.ShowDialog(this);
			this.RefreshForm();
		}

		private void RefreshForm()
		{		
		
				InputController data = new InputController();
			
				if (this.rbData.Checked == true)
				{
					DateTime dateFillimi = Convert.ToDateTime(this.dtpPrej.Value);
					DateTime dateMbarimi = Convert.ToDateTime(this.dtpDeri.Value);
					this.label1.Text = "Veprimet e klienteve ne datat e dhena";
					DataSet ds = data.KerkesaRead("ShfaqVeprimetPerDatat", dateFillimi, dateMbarimi);
					this.grid.DataSource = ds.Tables[0];
					
					//mbush griden per kete rast
				}
				else if (this.rbEmri.Checked == true)
				{
					string emri = this.txtEmri1.Text;
					string mbiemri = this.txtMbiemri1.Text;
					this.label1.Text = "Veprimet e klienteve me emer mbiemer te dhene";
					DataSet ds = data.KerkesaRead("ShfaqVeprimetPerKlientin", emri, mbiemri);
					this.grid.DataSource = ds.Tables[0];
				
					
					//mbush griden per kete rast
				}
				else if (this.rbGrupi.Checked == true)
				{
					string grupi = this.txtEmerGrupi.Text;
					string agjensia = this.txtAgjensia1.Text;
					this.label1.Text = "Veprimet e klienteve per grupin dhe agjensine e dhene";
					DataSet ds = data.KerkesaRead("ShfaqVeprimetPerGrupin", grupi, agjensia);
					this.grid.DataSource = ds.Tables[0];
					
					//mbush griden per kete rast
					
				}
				else 
				{
					ds = data.KerkesaRead("ShfaqKlientHotel");
					numer_rreshtash = ds.Tables[0].Rows.Count;
					this.grid.DataSource = ds.Tables[0];
					this.label1.Text = "Te dhenat e klienteve qe jane ne hotel";
					

				}

	
		
		}
	
		#endregion
	}
}

