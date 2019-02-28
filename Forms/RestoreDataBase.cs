using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagment.Forms
{
	public class RestoreDataBase : VisionInfoSolutionLibrary.Form
	{
		private VisionInfoSolutionLibrary.DataGrid dataGrid1;
		private VisionInfoSolutionLibrary.Button btnOK;
		private VisionInfoSolutionLibrary.Button btnAnullo;
		private System.ComponentModel.IContainer components = null;
		private string dateString = "";

		public RestoreDataBase()
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
			this.btnOK = new VisionInfoSolutionLibrary.Button(this.components);
			this.btnAnullo = new VisionInfoSolutionLibrary.Button(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(475, 24);
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.CanDelete = true;
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.HideHorizontalScrollBar = false;
			this.dataGrid1.HideVerticalScrollBar = false;
			this.dataGrid1.Location = new System.Drawing.Point(40, 12);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.RowHeaderWidth = 20;
			this.dataGrid1.Selekto = true;
			this.dataGrid1.Size = new System.Drawing.Size(216, 272);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
			// 
			// btnOK
			// 
			this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOK.DoValidation = true;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.Location = new System.Drawing.Point(284, 60);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(90, 21);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.toolTips.SetToolTip(this.btnOK, "Klikoni butonin per te zevendesuar te dhenat e programit");
			this.btnOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnAnullo
			// 
			this.btnAnullo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAnullo.DoValidation = true;
			this.btnAnullo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAnullo.Location = new System.Drawing.Point(284, 96);
			this.btnAnullo.Name = "btnAnullo";
			this.btnAnullo.Size = new System.Drawing.Size(90, 21);
			this.btnAnullo.TabIndex = 3;
			this.btnAnullo.Text = "Anullo";
			this.toolTips.SetToolTip(this.btnAnullo, "Klikoni per te dale");
			this.btnAnullo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
			// 
			// RestoreDataBase
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = false;
			this.ClientSize = new System.Drawing.Size(396, 364);
			this.ControlBox = true;
			this.Controls.Add(this.btnAnullo);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.dataGrid1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RestoreDataBase";
			this.ShfaqTitull = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TitullGjeresi = 475;
			this.Load += new System.EventHandler(this.RestoreDataBase_Load);
			this.Controls.SetChildIndex(this.dataGrid1, 0);
			this.Controls.SetChildIndex(this.btnOK, 0);
			this.Controls.SetChildIndex(this.btnAnullo, 0);
			this.Controls.SetChildIndex(this.lblStatus, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void RestoreDataBase_Load(object sender, System.EventArgs e)
		{
		
		}

		public static void RestoreLoad()
		{
			RestoreDataBase rb = new RestoreDataBase();
			DataSet ds = new DataSet();
			ds.Tables.Add("Table1");
			ds.Tables[0].Columns.Add("DataFormatuar", typeof(String));
			ds.Tables[0].Columns.Add("Data", typeof(String));
			ds.AcceptChanges();
			string[] str = Directory.GetFiles(@"C:\HoteleBackup");
			string data = "";
			for(int i = 0; i < str.Length; i++)
			{
				data =  str.GetValue(i).ToString();
				DataRow dr = ds.Tables[0].NewRow();
				dr["Data"] = str.GetValue(i);
				dr["DataFormatuar"] = str.GetValue(i).ToString().Substring(21) + " Backup " + i;
				ds.Tables[0].Rows.Add(dr);
			}
			ds.AcceptChanges();
			rb.dataGrid1.DataSource = ds.Tables["Table1"];
			rb.dataGrid1.TableStyles.Clear();
			DataGridTableStyle style = new DataGridTableStyle();
			style.MappingName = "Table1";
			style.AlternatingBackColor = System.Drawing.Color.Bisque;
			style.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			style.SelectionBackColor=  System.Drawing.SystemColors.InactiveCaption;
			style.RowHeadersVisible = false;
			rb.dataGrid1.ReadOnly = true;
			
			DataGridTextBoxColumn colEmri = new DataGridTextBoxColumn();
			colEmri.HeaderText = "Koha e backup-it";
			colEmri.MappingName = "DataFormatuar";
			colEmri.Width = 210;
			colEmri.NullText = "";
		
			DataGridTextBoxColumn colData = new DataGridTextBoxColumn();
			colData.HeaderText = "";
			colData.MappingName = "Data";
			colData.Width = 0;
			colData.NullText = "";

			style.GridColumnStyles.AddRange(new DataGridColumnStyle[]{colEmri, colData});
			rb.dataGrid1.TableStyles.Add(style);
			rb.dataGrid1.FlatMode = false;
			rb.dataGrid1.Expand(-1);

			if (ds.Tables[0].Rows.Count > 0)
				rb.dateString = rb.dataGrid1[0, 1].ToString();
			rb.ShowDialog();
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			System.Data.SqlClient.SqlConnection conn = new SqlConnection();
			conn.ConnectionString = "workstation id=(LOCAL);packet size=4096;user id=sa;data source=\"(LOCAL)\\HM\";persist s" +
				"ecurity info=True;initial catalog=Hotele;password=vision";
			conn.ConnectionString = "Server=\"(LOCAL)\";UId=sa;PWD=vision;Connect Timeout=1;Max Pool Size=1;Connection Lifetime=10;";
			System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				conn.Open();
				cmd.CommandText = "ALTER DATABASE Hotele SET SINGLE_USER";
				
				cmd.Connection = conn;
				//cmd.ExecuteNonQuery();
				cmd.CommandText = @"RESTORE DATABASE Hotele FROM DISK = '" + dateString + "'";
				cmd.ExecuteNonQuery();
				conn.Close();
			}
			catch(Exception ex)
			{
				if (conn.State == ConnectionState.Open)
				{
					conn.Close();
					conn.Dispose();
				}
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void btnAnullo_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			int indeks = Convert.ToInt32(this.dataGrid1.CurrentRowIndex);
			this.dateString = this.dataGrid1[indeks, 1].ToString();
		}
	}
}

