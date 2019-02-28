using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment.Forms
{
	/// <summary>
	/// Summary description for Dhoma2.
	/// </summary>
	public class Dhoma2 : VisionInfoSolutionLibrary.Form
	{
		private System.ComponentModel.IContainer components;
		private VisionInfoSolutionLibrary.DataGrid grid;
		private System.Data.DataSet ds;
		public VisionInfoSolutionLibrary.DateTimePicker dateTimePicker1;
		private VisionInfoSolutionLibrary.Button btnOK;

		public Dhoma2()
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.grid = new VisionInfoSolutionLibrary.DataGrid();
			this.ds = new System.Data.DataSet();
			this.dateTimePicker1 = new VisionInfoSolutionLibrary.DateTimePicker();
			this.btnOK = new VisionInfoSolutionLibrary.Button(this.components);
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(339, 24);
			// 
			// grid
			// 
			this.grid.AllowSorting = false;
			this.grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.grid.CanDelete = true;
			this.grid.CaptionVisible = false;
			this.grid.DataMember = "";
			this.grid.DataSource = this.ds;
			this.grid.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.grid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grid.HideHorizontalScrollBar = false;
			this.grid.HideVerticalScrollBar = false;
			this.grid.Location = new System.Drawing.Point(20, 8);
			this.grid.Name = "grid";
			this.grid.RowHeaderWidth = 20;
			this.grid.Selekto = true;
			this.grid.Size = new System.Drawing.Size(312, 142);
			this.grid.TabIndex = 0;
			// 
			// ds
			// 
			this.ds.DataSetName = "NewDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("sq-AL");
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.BackColor = System.Drawing.Color.White;
			this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
			this.dateTimePicker1.DefaultErrorMessage = "";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.IsValid = true;
			this.dateTimePicker1.Location = new System.Drawing.Point(24, 156);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Required = false;
			this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
			this.dateTimePicker1.TabIndex = 2;
			this.dateTimePicker1.Value = new System.DateTime(2005, 8, 15, 10, 53, 0, 0);
			this.dateTimePicker1.Visible = false;
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.Blue;
			this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOK.DoValidation = true;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.Location = new System.Drawing.Point(128, 160);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(90, 21);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// Dhoma2
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = false;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(346, 206);
			this.ControlBox = true;
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.grid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Location = new System.Drawing.Point(350, 300);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Dhoma2";
			this.ShfaqTitull = false;
			this.ShowInTaskbar = false;
			this.Text = "Te dhena per dhomen";
			this.TitullGjeresi = 339;
			this.Load += new System.EventHandler(this.Dhoma2_Load);
			this.Controls.SetChildIndex(this.grid, 0);
			this.Controls.SetChildIndex(this.dateTimePicker1, 0);
			this.Controls.SetChildIndex(this.btnOK, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Dhoma2_Load(object sender, System.EventArgs e)
		{

			InputController data = new InputController();
			//TODO: Kujdes vleren e idDhoma
			int id_dhoma = Convert.ToInt32(this.Name);
			this.Location = new System.Drawing.Point(350, 300);
			DateTime date = Convert.ToDateTime(this.dateTimePicker1.Value);
			ds = data.KerkesaRead("NxirrDhomePerDaten", id_dhoma, date);
			grid.DataSource = ds.Tables[0];
			this.KrijoStilGrid();
		}  

		private void KrijoStilGrid()
		{
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.NavajoWhite;
			style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			this.grid.ReadOnly = true;

			DataGridTextBoxColumn colKriteri = new DataGridTextBoxColumn();
			colKriteri.MappingName = "KRITER";
			colKriteri.Width = 140;

			DataGridTextBoxColumn colPershkrim = new DataGridTextBoxColumn();
			colPershkrim.MappingName = "PERSHKRIM";
			colPershkrim.Width = 168;
			colPershkrim.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));

			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{ colKriteri, colPershkrim});
			grid.TableStyles.Add(style);
			grid.FlatMode = false;
			grid.Expand(-1);
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
