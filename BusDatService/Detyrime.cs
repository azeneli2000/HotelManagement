using System;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment.BusDatService
{	/// <summary>
	/// 
	/// </summary>
	public class Detyrime
	{
		#region Private Variables
		private string llojiDetyrimi = null;
		private int cmimiDetyrimi = 0;
		private int sasiaDetyrimi = 0;
		private int idKlienti = 0;
		private int idLlojDetyrimi = 0;
		private DateTime dtDetyrimi ;
		#endregion

		#region Constructors
		public Detyrime()
		{
			
		}
        
		public Detyrime (string llojiDetyrimi,int cmimiDetyrimi, int sasiaDetyrimi)
		{
			this.llojiDetyrimi = llojiDetyrimi;
			this.cmimiDetyrimi = cmimiDetyrimi;
			this.sasiaDetyrimi = sasiaDetyrimi;
			
		}
		
		/// <summary>
		/// krijon nje detyrim te ri ne baze te atributeve te klases
		/// </summary>
		/// <returns>int</returns>
		public Detyrime (string llojiDetyrimi,int cmimiDetyrimi)
		{
			this.llojiDetyrimi = llojiDetyrimi;
			this.cmimiDetyrimi = cmimiDetyrimi;
		}

		public Detyrime (int idLlojDetyrim,  int sasia,int idKlient,DateTime dtDetyrimi)
		{
			this.idLlojDetyrimi = idLlojDetyrim;
			this.idKlienti = idKlient;
			this.sasiaDetyrimi = sasia;
			this.dtDetyrimi = dtDetyrimi;

		}

		#endregion constructors

		#region Public Methods
		
		public int KrijoDetyrimKlienti()
		{
			int p = 0;
	
			DbController db = new DbController();
			p = db.Create("dbKrijoDetyrimPerKlient",this.idLlojDetyrimi,sasiaDetyrimi, idKlienti,this.dtDetyrimi);
			return p;
		}
		/// <summary>
		/// krijon llojet e detyrimeve ne baze te atributeve te klases
		/// </summary>
		/// <returns>int</returns>
		public int KrijoLlojDetyrimi()
		{
			int p = 0;
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbKontrolloLlojDetyrimi",this.llojiDetyrimi);
			if (ds.Tables[0].Rows.Count == 0)
				p = db.Create("dbKrijoLlojDetyrimi",llojiDetyrimi,cmimiDetyrimi);
			else 
				p = 1;//ka lloj detyrimi te tille
			return p;
		}

		/// <summary>
		/// sipas parametrave ben modifikimin e detyrimit
		/// </summary>
		/// <param name="idDetyrimi">int</param>
		/// <param name="idLlojDetyrimi">int</param>
		/// <param name="sasia">int</param>
		/// <returns>int</returns>
		public int ModifikoDetyrimKlienti(int idDetyrimi,int idLlojDetyrimi,int sasia,DateTime dtDetyrimi)
		{
			int p = 0;
			DbController db = new DbController();
			p = db.Update("dbModifikoDetyrimKlienti", idDetyrimi,idLlojDetyrimi,sasia,dtDetyrimi);
			return p;
		}

		
		public int ModifikoLlojDetyrimi(int idLlojDetyrimi)
		{
			int p = 0;
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbKontrolloLlojDetyrimiKlienti",idLlojDetyrimi);
			DataRow dr = ds.Tables[0].Rows[0];
			int nrKlient = Convert.ToInt32(dr[0]);
			if (nrKlient == 0)
			{
				ds = db.Read("dbKontrolloLlojDetyrimi",this.llojiDetyrimi);
				if(ds.Tables[0].Rows.Count != 0 )
				{
//					DataRow dr1 = ds.Tables[0].Rows[0];
//					if(this.llojiDetyrimi == dr1[1].ToString())//ka nje lloj detyrimi te tille dhe e krahasojme me detyrimin tone
//						p = db.Update("dbModifikoLlojDetyrimi",idLlojDetyrimi,this.llojiDetyrimi,this.cmimiDetyrimi);
//					else
						p = -1; //ka lloj detyrimi te tille
				
				}
				else
					p = db.Update("dbModifikoLlojDetyrimi",idLlojDetyrimi,this.llojiDetyrimi,this.cmimiDetyrimi);
			}
			else
				p = nrKlient;
			return p;
		}
		/// <summary>
		/// merr si parameter nje detyrim dhe e fshin ate nqs nuk i eshte aplikuar ndonje dhome te zene
		/// </summary>
		/// <param name="id_detyrimi"></param>
		/// <returns>int</returns>
		public int FshiDetyrimKlienti(int idDetyrimi)
		{
			int p = 0;
			string var = "dbFshiDetyrimKlienti";
			DbController db = new DbController();
			p = db.Delete(var,idDetyrimi);
			return p;
		}


		/// <summary>
		/// merr si parameter nje detyrim dhe e fshin ate nqs nuk i eshte aplikuar ndonje dhome te zene
		/// </summary>
		/// <param name="id_detyrimi"></param>
		/// <returns>int</returns>
		public int HidhDetyrimeNeArke(int[] id_kliente, DateTime date_dorezimi,int idFormaPagesa, int idPerdoruesi)
		{
			int p = 0;
			for(int i = 0; i < id_kliente.Length; i++)
			{
				int id = id_kliente[i];
				DbController db = new DbController();
				DataSet detyrime_ds = db.Read("dbShfaqDetyrimePerKlientin", id);
				foreach(DataRow dr in detyrime_ds.Tables[0].Rows)
				{
					int sasia_detyrimi = Convert.ToInt32(dr["CMIMI"])* Convert.ToInt32(dr["SASIA"]);
					int id_detyrimi = Convert.ToInt32(dr["ID_DETYRIMI"]);
					DbController db1 = new DbController();
					p = p + db1.Create("dbHidhDetyrimNeArke", date_dorezimi ,sasia_detyrimi, 
					"Pagese detyrimesh", id, id_detyrimi, idFormaPagesa, idPerdoruesi);
				}
			}
			return p;
		}
		/// <summary>
		/// merr si parameter  llojiDetyrimi dhe e fshin ate nqs nuk i eshte aplikuar ndonje Klienti 
		/// </summary>
		/// <param name="id_detyrimi"></param>
		/// <returns>int</returns>
		public int FshiLlojDetyrimi(int idLlojDetyrimi)
		{
			int p = 0;
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbKontrolloLlojDetyrimiKlienti",idLlojDetyrimi);
			DataRow dr = ds.Tables[0].Rows[0];
			int nrKlient = Convert.ToInt32(dr[0]);
			if (nrKlient == 0)
				p = db.Delete("dbFshiLlojDetyrimi",idLlojDetyrimi);
			else
				p = nrKlient;
			return p;


		}
		/// <summary>
		/// merr si parameter nje idDetyrimi dhe vendos ne atributet e klases karakteristikat e ketij detyrimi.
		/// </summary>
		/// <param name="id_detyrimi"></param>
		/// <returns>int []</returns>
		public DataSet  NxirrDetyrimKlienti(int idDetyrimi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqDetyrimKlienti",idDetyrimi);			
			return ds;
		}


		public DataSet NxirrDetyrim(int idDetyrim)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqLlojDetyriminEzgjedhur", idDetyrim);
			return ds;
		}


		public DataSet ShfaqDetyrime()
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqLlojetDetyrime");
			return ds;
		}
        
		/// <summary>
		/// kthen detyrimet per klientet e nje dhome te dhene
		/// </summary>
		/// <param name="idDhoma">int</param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqDetyrimePerDhomen(int idDhoma)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqDetyrimetPerKlienteteDhomes", idDhoma);
			ds.Tables[0].Columns.Add("DATA_STR", typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				if(dr[6].ToString() != "")
				{
					DateTime data = Convert.ToDateTime(dr[6]);
					dr[12] = this.konverto(data);
				}
			}
			ds.AcceptChanges();
			ds.EnforceConstraints = false;
			DataTable dt1 = ds.Tables[0].Clone();
			dt1.Rows.Clear();
			dt1.TableName = "DETYRIMI";
			ds.Tables.Add(dt1);
			ds.Tables["DETYRIMI"].Columns.Add("CMIMI_STR", typeof(String));
			ds.Tables["DETYRIMI"].Columns.Add("SASIA_STR", typeof(String));
			ds.AcceptChanges();
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				
				DataRow dt1Row = dt1.NewRow();
				DataRow drFirst = ds.Tables[0].Rows[i];
				DataRow drNext = ds.Tables[0].Rows[i];
				if (i < ds.Tables[0].Rows.Count - 1)
				{
					drNext = ds.Tables[0].Rows[i + 1];
				}
				// Te dhenat per KLIENTIN
				dt1Row["EMRI"] = drFirst["EMRI"].ToString() + " " + drFirst["MBIEMRI"];
				// Te dhenat per REZERVIMIN
				dt1Row["DATA_STR"] = drFirst["DATA_STR"];
				dt1Row["DATA_HYRJE"] = drFirst["DATA_HYRJE"];
				dt1Row["DATA_DALJE"] = drFirst["DATA_DALJE"];

				dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"];
				dt1Row["CMIMI_STR"] = drFirst["CMIMI"];
				dt1Row["SASIA_STR"] = drFirst["SASIA"];
				dt1Row["EMER_LLOJI"] = drFirst["EMER_LLOJI"];
				dt1Row["ID_DETYRIMI"] = drFirst["ID_DETYRIMI"];
				dt1Row["ID_KLIENTI"] = drFirst["ID_KLIENTI"];
				while (drFirst["EMRI"].ToString() == Convert.ToString(drNext["EMRI"]) && (drFirst["MBIEMRI"].ToString() == Convert.ToString(drNext["MBIEMRI"])) && (i < ds.Tables[0].Rows.Count - 1))
				{
					dt1Row["DATA_STR"] += Environment.NewLine + drNext["DATA_STR"];
					dt1Row["CMIMI_STR"] += Environment.NewLine + drNext["CMIMI"].ToString();
					dt1Row["SASIA_STR"] += Environment.NewLine + drNext["SASIA"].ToString();
					dt1Row["EMER_LLOJI"] += Environment.NewLine + drNext["EMER_LLOJI"];
													
					i++;
					if (i < ds.Tables[0].Rows.Count - 1)
					{
						drFirst = ds.Tables[0].Rows[i];
						drNext = ds.Tables[0].Rows[i + 1];
					}
				}
				dt1.Rows.Add(dt1Row);
			}

			ds.AcceptChanges();
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				dr["EMRI"] = dr["EMRI"].ToString() + " " + dr["MBIEMRI"].ToString();
			}
			return ds;
		}
		public DataSet ShfaqVetemDetyrimePerDhomen(int idDhoma)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqVetemDetyrimetPerKlienteteDhomes", idDhoma);
			ds.Tables[0].Columns.Add("DATA_STR", typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
					DateTime data = Convert.ToDateTime(dr[6]);
					dr[12] = this.konverto(data);
				
			}
			ds.AcceptChanges();

			return ds;
		}
		public DataSet ShfaqDetyrimePerKategorine(int idKategoria)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqDetyrimKlientiPerKategorine", idKategoria);
			ds.Tables[0].Columns.Add("DATA_STR", typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				if(dr[6].ToString() != "")
				{
					DateTime data = Convert.ToDateTime(dr[6]);
					dr[12] = this.konverto(data);
				}
			}
			ds.AcceptChanges();
			DataTable dt1 = ds.Tables[0].Clone();
			dt1.Rows.Clear();
			dt1.TableName = "DETYRIMI";
			ds.Tables.Add(dt1);
			ds.Tables["DETYRIMI"].Columns.Add("CMIMI_STR", typeof(String));
			ds.Tables["DETYRIMI"].Columns.Add("SASIA_STR", typeof(String));
			ds.AcceptChanges();
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				
				DataRow dt1Row = dt1.NewRow();
				DataRow drFirst = ds.Tables[0].Rows[i];
				DataRow drNext = ds.Tables[0].Rows[i];
				if (i < ds.Tables[0].Rows.Count - 1)
				{
					drNext = ds.Tables[0].Rows[i + 1];
				}
				// Te dhenat per KLIENTIN
				dt1Row["EMRI"] = drFirst["EMRI"].ToString() + " " + drFirst["MBIEMRI"];
				// Te dhenat per DETYRIMIN
				dt1Row["DATA_STR"] = drFirst["DATA_STR"];
				dt1Row["DATA_HYRJE"] = drFirst["DATA_HYRJE"];
				dt1Row["DATA_DALJE"] = drFirst["DATA_DALJE"];

				dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"];
				dt1Row["CMIMI_STR"] = drFirst["CMIMI"];
				dt1Row["SASIA_STR"] = drFirst["SASIA"];
				dt1Row["EMER_LLOJI"] = drFirst["EMER_LLOJI"];
				dt1Row["ID_DETYRIMI"] = drFirst["ID_DETYRIMI"];
				dt1Row["ID_KLIENTI"] = drFirst["ID_KLIENTI"];
				while (drFirst["EMRI"].ToString() == Convert.ToString(drNext["EMRI"]) && (drFirst["MBIEMRI"].ToString() == Convert.ToString(drNext["MBIEMRI"])) && (i < ds.Tables[0].Rows.Count - 1))
				{
					dt1Row["DATA_STR"] += Environment.NewLine + drNext["DATA_STR"];
					dt1Row["CMIMI_STR"] += Environment.NewLine + drNext["CMIMI"].ToString();
					dt1Row["SASIA_STR"] += Environment.NewLine + drNext["SASIA"].ToString();
					dt1Row["EMER_LLOJI"] += Environment.NewLine + drNext["EMER_LLOJI"];
													
					i++;
					if (i < ds.Tables[0].Rows.Count - 1)
					{
						drFirst = ds.Tables[0].Rows[i];
						drNext = ds.Tables[0].Rows[i + 1];
					}
				}
				dt1.Rows.Add(dt1Row);
			}
			ds.AcceptChanges();
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				dr["EMRI"] = dr["EMRI"].ToString() + " " + dr["MBIEMRI"].ToString();
			}
			return ds;
		}
		
		/// <summary>
		/// Kthen nje dataset qe mban te gjitha detyrimet per nje detyrim te dhene ne datat e dhena
		/// </summary>
		/// <param name="idKategoria">Id e detyrimit </param>
		/// <param name="dtFillimi">data me e vogel per te cilen do te zgjidhet kategoria</param>
		/// <param name="dtMbarimi">data me e madhe per te cilen do te zgjidhet kategoria</param>
		/// <returns>DataSet qe mban detyrimet</returns>
		public DataSet ShfaqDetyrimeKlienteDalePerKategori(int idKategoria, DateTime dtFillimi, DateTime dtMbarimi)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqDetyrimePerKategorineDheDatat", idKategoria, dtFillimi, dtMbarimi);
			return ds;
		}

		public DataSet ShfaqVetemDetyrimePerKategorine(int idKategoria)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqVetemDetyrimKlientiPerKategorine", idKategoria);
			ds.Tables[0].Columns.Add("DATA_STR", typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				
					DateTime data = Convert.ToDateTime(dr[6]);
					dr[12] = this.konverto(data);
				
			}
			ds.AcceptChanges();
			return ds;
		}
		public DataSet ShfaqDetyrimePerEmerMbiemer(string emer,string mbiemer)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqDetyrimKlientiPerEmerMbiemer", emer,mbiemer);
			ds.Tables[0].Columns.Add("DATA_STR", typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				
				if(dr[6].ToString() != "")
				{
					DateTime data = Convert.ToDateTime(dr[6]);
					dr[12] = this.konverto(data);
				}
			}
			ds.AcceptChanges();
			ds.EnforceConstraints = false;
			DataTable dt1 = ds.Tables[0].Clone();
			dt1.Rows.Clear();
			dt1.TableName = "DETYRIMI";
			ds.Tables.Add(dt1);
			ds.Tables["DETYRIMI"].Columns.Add("CMIMI_STR", typeof(String));
			ds.Tables["DETYRIMI"].Columns.Add("SASIA_STR", typeof(String));
			ds.AcceptChanges();
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				
				DataRow dt1Row = dt1.NewRow();
				DataRow drFirst = ds.Tables[0].Rows[i];
				DataRow drNext = ds.Tables[0].Rows[i];
				if (i < ds.Tables[0].Rows.Count - 1)
				{
					drNext = ds.Tables[0].Rows[i + 1];
				}
				// Te dhenat per KLIENTIN
				dt1Row["EMRI"] = drFirst["EMRI"].ToString() + " " + drFirst["MBIEMRI"];
				// Te dhenat per REZERVIMIN
				dt1Row["DATA_STR"] = drFirst["DATA_STR"];
				dt1Row["DATA_HYRJE"] = drFirst["DATA_HYRJE"];
				dt1Row["DATA_DALJE"] = drFirst["DATA_DALJE"];

				dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"];
				dt1Row["CMIMI_STR"] = drFirst["CMIMI"];
				dt1Row["SASIA_STR"] = drFirst["SASIA"];
				dt1Row["EMER_LLOJI"] = drFirst["EMER_LLOJI"];
				dt1Row["ID_DETYRIMI"] = drFirst["ID_DETYRIMI"];
				dt1Row["ID_KLIENTI"] = drFirst["ID_KLIENTI"];
				while (drFirst["EMRI"].ToString() == Convert.ToString(drNext["EMRI"]) && (drFirst["MBIEMRI"].ToString() == Convert.ToString(drNext["MBIEMRI"])) && (i < ds.Tables[0].Rows.Count - 1))
				{
					dt1Row["DATA_STR"] += Environment.NewLine + drNext["DATA_STR"];
					dt1Row["CMIMI_STR"] += Environment.NewLine + drNext["CMIMI"].ToString();
					dt1Row["SASIA_STR"] += Environment.NewLine + drNext["SASIA"].ToString();
					dt1Row["EMER_LLOJI"] += Environment.NewLine + drNext["EMER_LLOJI"];
													
					i++;
					if (i < ds.Tables[0].Rows.Count - 1)
					{
						drFirst = ds.Tables[0].Rows[i];
						drNext = ds.Tables[0].Rows[i + 1];
					}
				}
				dt1.Rows.Add(dt1Row);
			}
			ds.AcceptChanges();
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				dr["EMRI"] = dr["EMRI"].ToString() + " " + dr["MBIEMRI"].ToString();
			}
			

			return ds;
		}
		public DataSet ShfaqVetemDetyrimePerEmerMbiemer(string emer,string mbiemer)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqVetemDetyrimKlientiPerEmerMbiemer", emer,mbiemer);
			ds.Tables[0].Columns.Add("DATA_STR", typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				
					DateTime data = Convert.ToDateTime(dr[6]);
					dr[12] = this.konverto(data);
				
			}
			ds.AcceptChanges();
			return ds;
		}


		public DataSet ShfaqDetyrimePerDatat(DateTime dtFillimi, DateTime dtMbarimi)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqDetyrimetPerDatat", dtFillimi, dtMbarimi);
			return ds;
		}

		/// <summary>
		/// Hedh te gjitha detyrimet bashke me te dhenat e tjera te nevojshme per emer, mbiemer, dhe per
		/// intervalin e datave dtFillimi dhe dtMbarimi
		/// </summary>
		/// <param name="emer"></param>
		/// <param name="mbiemer"></param>
		/// <param name="dtFillimi"></param>
		/// <param name="dtMbarimi"></param>
		/// <returns></returns>
		public DataSet ShfaqDetyrimKlientiPerEmerDheData(string emer, string mbiemer, DateTime dtFillimi, DateTime dtMbarimi)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqDetyrimKlientiPerEmerDheData", emer,mbiemer, dtFillimi, dtMbarimi);
			ds.Tables[0].Columns.Add("DATA_STR", typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				if(dr[6].ToString() != "")
				{
					DateTime data = Convert.ToDateTime(dr[6]);
					dr[12] = this.konverto(data);
				}
			}
			ds.AcceptChanges();
			return ds;
		}
		
		public DataSet ShfaqDetyrimeKlientePerDataEmerKategori(DateTime dtFillimi, DateTime dtMbarimi, int idDetyrimi, string emer, string mbiemer)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("ShfaqDetyrimeKlientePerDataEmerKategori", dtFillimi, dtMbarimi, idDetyrimi, emer, mbiemer);
			return ds;
		}

		public DataSet NrDetyrimeshPerKlientJashteDatave(int idKlienti, DateTime dtHyrje, DateTime dtDalje)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbNrDetyrimeshPerKlientJashteDatave", idKlienti, dtHyrje, dtDalje);
			return ds;
		}

		#endregion public methods
		
		#region Private Methods
		private string konverto(DateTime data)
		{
			string data_str = data.ToString();
			string dita, muaji, viti, ora;
			dita = data_str.Substring(8, 2);
			muaji = data_str.Substring(5, 2);
			viti = data_str.Substring(0, 4);
			ora =data_str.Substring(11);
			data_str = dita + "-" + muaji + "-" + viti + " " + ora ;
			return data_str;
		}
		#endregion
		
	}
}