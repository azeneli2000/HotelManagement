using System;
using System.Data.SqlClient;
using HotelManagment.BusDatService;
using System.Data;
using System.Drawing;
namespace HotelManagment.BusDatService
{
	/// <summary>
	/// 
	/// </summary>
	public class Shpenzime
	{
		public int idLloji = 0;
		public DateTime dateShpenzimi;
		public int      sasiaShpenzimi = 0;
		public string   emriShpenzimi = "null";
		public int idPerdoruesi;
		#region constructors
		public Shpenzime()
		{				// 
			// TODO: Add constructor logic here
			//
		}
		public Shpenzime(int idLloji, DateTime dateShpenzimi , 
			int sasiaShpenzimi, string emriShpenzimi, int idPerdorues)
		{
			this.idLloji = idLloji;
			this.dateShpenzimi = dateShpenzimi;
			this.sasiaShpenzimi = sasiaShpenzimi;
			this.emriShpenzimi = emriShpenzimi;
			this.idPerdoruesi = idPerdorues;
		}
		#endregion constructors
		#region public methods
		/// <summary>
		/// krijon nje lloj te ri shpenzimi
		/// <param name="emri"></param>	
		/// </summary>
		/// <returns>int</returns>
		public int ShtoLlojShpenzimi(string emri)
		{
			int p = 0;
			DbController db = new DbController();
			string var = "dbNrLloji";
			DataSet ds = db.Read(var, emri);
			int nr = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
			if (nr > 0)
				p = 2;
			else
			{
				var = "dbShtoLlojShpenzimi";
				p = db.Create(var, emri );
			}
			return p;
		}	

		/// <summary>
		/// modifikon nje lloj ekzistues  shpenzimi
		/// <param name="emri"></param>	
		/// <param name="idLloji"></param>	
		/// </summary>
		/// <returns>int</returns>
		public int ModifikoLlojShpenzimi(string emri, int idLloji)
		{
			int p = 0;
			DbController db = new DbController();
			string var = "dbNrLloji";
			DataSet ds = db.Read(var, emri,idLloji);
			int nr = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
			if (nr > 0)
				p = 2;
			else
			{
				var = "dbModifikoLlojShpenzimi";
				p = db.Update(var, emri, idLloji );
			}
			return p;
		}	
		/// <summary>
		/// eleminon nje lloj ekzistues  shpenzimi
		/// <param name="idLloji"></param>	
		/// </summary>
		/// <returns>int</returns>
		public int FshiLlojShpenzimi(int idLloji)
		{
			int p = 0;
			DbController db = new DbController();
			string var = "dbNrShpenzimeshTeLojit";
			DataSet ds = db.Read(var, idLloji);
			int nr = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
			if (nr > 0)
				p = 2;
			else
			{
				var = "dbFshiLlojShpenzimi";
				p = db.Delete(var, idLloji );
			}
			return p;
		}	
		/// <summary>
		/// krijo nje shpenzim bazuar ne atributet e klases	
		/// </summary>
		/// <returns>int</returns>
		public int KrijoShpenzim()
		{
			int p = 0;
			string var = "dbKrijoShpenzim";
			DbController db = new DbController();
			p = db.Create(var, this.idLloji, this.dateShpenzimi,this.sasiaShpenzimi,
				this.emriShpenzimi, this.idPerdoruesi );
			return p;
		}	
		/// <summary>
		/// merr si parameter nje idShpenzimi dhe modifikon karakteristikat e shpenzimit perkates ne baze te atribueteve te klases.	
		/// </summary>
		/// <param name="idShpenzimi"></param>	
		/// <returns>int</returns>
		public int  ModifikoShpenzim(int idShpenzimi)
		{
			int p = 0;
			string var = "dbModifikoShpenzim";
			DbController db = new DbController();
			p= db.Update(var, idShpenzimi,this.idLloji, this.emriShpenzimi,
				this.dateShpenzimi, this.sasiaShpenzimi, this.idPerdoruesi);
			return p;
		}
		/// <summary>
		/// nje idShpenzimi dhe fshin shpenzimin korrespondent
		/// </summary>	
		/// <param name="idShpenzimi"></param>
		/// <returns></returns>	
		public int  FshiShpenzim(int idShpenzimi)
		{
			int p = 0;
			string var = "dbFshiShpenzim";
			DbController db = new DbController();
			p = db.Delete(var,idShpenzimi);
			return p;
		}
		/// <summary>
		/// overloaded merr si paramatra nje date kerkimi	
		/// dhe kthen nje dataset qe permban gjithe shpenzimet e kryer per kete date
		/// </summary>	
		/// <param name="dtKerkimi"></param>
		/// <returns>int</returns>
		public DataSet ShfaqShpenzime( DateTime dtKerkimi )
		{
			DataSet ds = null;
			string var = "dbShfaqShpenzimetPerDatenEdhene";
			DbController db = new DbController(); 
			ds = db.Read( var, dtKerkimi );
			int shuma = 0;
			ds.Tables[0].Columns.Add("DATA_STR", typeof(String));
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				shuma = shuma + Convert.ToInt32(dr["SASIA"]);
				dr["DATA_STR"] = this.konverto(Convert.ToDateTime(dr["DATA"]));
			}
			ds.AcceptChanges();
			var = "Shuma";
			DataRow shumarow;
			shumarow = ds.Tables[0].NewRow();
			shumarow["EMRI"] = var;
			shumarow["SASIA"] = shuma;
			ds.Tables[0].Rows.Add(shumarow);
			ds.AcceptChanges();
			return ds;	
		}
		/// <summary>
		/// overloaded merr si paramatra nje idLloji
		/// dhe kthen nje dataset qe permban gjithe shpenzimet e kryer per kete lloj
		/// </summary>	
		/// <param name="dtKerkimi"></param>
		/// <returns>int</returns>
		public DataSet ShfaqShpenzime( int idLloji )
		{
			DataSet ds = null;
			string var = "dbShfaqShpenzimetPerLlojinEdhene";
			DbController db = new DbController(); 
			ds = db.Read( var, idLloji );
			int shuma = 0;
			ds.Tables[0].Columns.Add("DATA_STR", typeof(String));
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				shuma = shuma + Convert.ToInt32(dr["SASIA"]);
				dr["DATA_STR"] = this.konverto(Convert.ToDateTime(dr["DATA"]));
			}
			ds.AcceptChanges();
			var= "Shuma";
			DataRow shumarow;
			shumarow = ds.Tables[0].NewRow();
			shumarow["EMRI"] = var;
			shumarow["SASIA"] = shuma;
			ds.Tables[0].Rows.Add(shumarow);
			ds.AcceptChanges();
			return ds;	
		}

		/// <summary>
		/// overloaded nuk merr parametra	
		/// dhe kthen nje dataset qe permban gjithe shpenzimet e kryer.
		/// </summary>	
		/// <param name="dtKerkimi"></param>
		/// <returns>int</returns>
		public DataSet ShfaqShpenzime()
		{
			DataSet ds = null;
			string var = "dbShfaqGjitheShpenzimet";
			DbController db = new DbController(); 
			ds = db.Read( var) ;
			int shuma = 0;
			ds.Tables[0].Columns.Add("DATA_STR", typeof(String));
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				shuma = shuma + Convert.ToInt32(dr[2]);
				dr[4] = this.konverto(Convert.ToDateTime(dr[1]));
			}
			ds.AcceptChanges();
			var= "Shuma";
			DataRow shumarow;
			shumarow = ds.Tables[0].NewRow();
			shumarow["KOMENT"] = var;
			shumarow["SASIA"] = shuma;
			//ds.Tables[0].Rows.Add(shumarow);
			ds.AcceptChanges();
			return ds;	
		}
		/// <summary>
		/// merr si paramatra nje date fillimi dhe nje date mbarimi 
		/// dhe kthen nje data set qe jane shpenzimet qe jane bere nga data e fillimit ne ate te mbarimit
		/// gjithashtu perfshin edhe shumen e shpenzimeve per keto data
		/// </summary>
		/// <param name="dtFillimi"></param>
		/// <param name="dtMbarimi"></param>	
		/// <returns>int</returns>
		public DataSet  ShfaqShpenzime(DateTime dtFillimi, DateTime  dtMbarimi)
		{
			DataSet ds = null;
			string var = "dbShfaqShpenzimetMidisDatave";
			DbController db = new DbController();
			ds = db.Read(var, dtFillimi, dtMbarimi);
			int shuma = 0;
			ds.Tables[0].Columns.Add("DATA_STR", typeof(String));
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				shuma = shuma + Convert.ToInt32(dr["SASIA"]);
				dr["DATA_STR"] = this.konverto(Convert.ToDateTime(dr["DATA"]));
			}
			ds.AcceptChanges();
			var= "Shuma";
			DataRow shumarow;
			shumarow = ds.Tables[0].NewRow();
			shumarow["EMRI"] = var;
			shumarow["SASIA"] = shuma;
			ds.Tables[0].Rows.Add(shumarow);
			ds.AcceptChanges();
			return ds;	
		}
		/// <summary>
		/// shfaq te gjithe llojet e shpenzimeve ekzistuese
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet ShfaqLlojetEShpenzimeve()
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqLlojetEShpenzimeve");
			return ds;
		}

		#endregion public methods
		#region Private Methods
		private string konverto(DateTime data)
		{
			string data_str = data.ToString();
			string dita, muaji, viti;
			dita = data_str.Substring(8, 2);
			muaji = data_str.Substring(5, 2);
			viti = data_str.Substring(0, 4);
			data_str = dita + "-" + muaji + "-" + viti;
			return data_str;
		}
		#endregion Private Methods
	}
}