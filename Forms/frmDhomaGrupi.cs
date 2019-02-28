using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagment.Forms
{
	public class frmDhomaGrupi : System.Windows.Forms.Form
	{
		private VisionInfoSolutionLibrary.Label label1;
		private VisionInfoSolutionLibrary.Button cmdDil;
		private System.ComponentModel.IContainer components = null;
		private VisionInfoSolutionLibrary.DataGrid dataGrid1;
		public string emriDhoma ;

		public frmDhomaGrupi()
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
			this.dataGrid1 = new VisionInfoSolutionLibrary.DataGrid();
			this.label1 = new VisionInfoSolutionLibrary.Label();
			this.cmdDil = new VisionInfoSolutionLibrary.Button(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dataGrid1.CanDelete = true;
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(32, 88);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.RowHeaderWidth = 20;
			this.dataGrid1.Size = new System.Drawing.Size(536, 220);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid1_Navigate);
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(192)));
			this.label1.Location = new System.Drawing.Point(32, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(532, 28);
			this.label1.TabIndex = 2;
			this.label1.Text = "Klientet per dhomen e zgjedhur jane :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmdDil
			// 
			this.cmdDil.BackColor = System.Drawing.Color.Blue;
			this.cmdDil.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdDil.DoValidation = true;
			this.cmdDil.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdDil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdDil.Location = new System.Drawing.Point(232, 348);
			this.cmdDil.Name = "cmdDil";
			this.cmdDil.Size = new System.Drawing.Size(128, 24);
			this.cmdDil.TabIndex = 3;
			this.cmdDil.Text = "Dil";
			this.cmdDil.Click += new System.EventHandler(this.cmdDil_Click);
			// 
			// frmDhomaGrupi
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.ControlBox = false;
			this.Controls.Add(this.cmdDil);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGrid1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmDhomaGrupi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.frmDhomaGrupi_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmDhomaGrupi_Load(object sender, System.EventArgs e)
		{
			System.Data.DataSet ds = null;
			InputController data = new InputController();
			ds = data.KerkesaRead("ShfaqKlientetPerDhomenEgrupit", emriDhoma);
			this.KrijoStilGride(ds);
			

		}

		private void KrijoStilGride(System.Data.DataSet ds)
		{
			dataGrid1.TableStyles.Clear();
			dataGrid1.DataSource = ds.Tables[0];
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.Bisque;
			
			DataGridTextBoxColumn emri = new DataGridTextBoxColumn();
			emri.HeaderText = "Emri";
			emri.MappingName = "EMRI";
			emri.Width = 100;
			emri.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			
			DataGridTextBoxColumn mbiemri = new DataGridTextBoxColumn();
			mbiemri.HeaderText = "Mbiemri";
			mbiemri.MappingName = "Mbiemri";
			mbiemri.Width = 100;
			mbiemri.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;

			DataGridTextBoxColumn dtHyrje = new DataGridTextBoxColumn();
			dtHyrje.HeaderText = "Data e hyrjes";
			dtHyrje.MappingName = "DATA_HYRJE";
			dtHyrje.Width = 148;
			dtHyrje.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			
			DataGridTextBoxColumn dtDalje = new DataGridTextBoxColumn();
			dtDalje.HeaderText = "Data e daljes";
			dtDalje.MappingName = "DATA_DALJE";
			dtDalje.Width = 148;
			dtDalje.TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			
			
			
			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{emri, mbiemri, dtHyrje, dtDalje});
			dataGrid1.TableStyles.Add(style);
			dataGrid1.FlatMode = false;
			dataGrid1.Expand(-1);

		}

		private void cmdDil_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void dataGrid1_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
			
		}
	}
}

