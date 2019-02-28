using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagment.BusDatService
{
	/// <summary>
	/// Summary description for Rezervimi.
	/// </summary>
	public class Rezervimi
	{
		#region privateVariables 
		private DateTime dtFillimi;
		private DateTime dtMbarimi;
		private int kapari;
		private int idDhomaKlienti;
		private int[] idDhomatGrupi;
		public int idRezervimi;
		public int idGrupi;
		private string emri;// emer klienti ose emer grupi
		private string mbiemri;
		private string emaili;
		private DateTime dtRezervimi;
		#endregion
	
		#region Constructor
		
		
		public Rezervimi(DateTime dtFillimi,DateTime dtMbarimi,DateTime dtRezervimi ,int kapari,
			string emri,string mbiemri,int idDhomaKlienti, string email)
		{
			this.dtFillimi = dtFillimi;
			this.dtMbarimi = dtMbarimi;
			this.dtRezervimi = dtRezervimi;
			this.kapari = kapari;
			this.emri = emri;
			this.mbiemri = mbiemri;
			this.idDhomaKlienti = idDhomaKlienti;
			this.emaili = email;			
		}
		
		public Rezervimi(DateTime dtFillimi,DateTime dtMbarimi,DateTime dtRezervimi,int kapari,
			int idGrupi,int [] idDhomatGrupi)
		{
			this.dtFillimi = dtFillimi;
			this.dtMbarimi = dtMbarimi;
			this.dtRezervimi = dtRezervimi;
			this.kapari  = kapari;
			this.emri = emri;
			this.idGrupi = idGrupi;
			this.idDhomatGrupi = idDhomatGrupi;
			
		}

		public Rezervimi(DateTime dtFillimi,DateTime dtMbarimi,DateTime dtRezervimi,int kapari,
			int idGrupi)
		{
			this.dtFillimi = dtFillimi;
			this.dtMbarimi = dtMbarimi;
			this.dtRezervimi = dtRezervimi;
			this.kapari  = kapari;
		
			this.idGrupi = idGrupi;
		
			
		}
	


		public Rezervimi()
		{
			
		}
		
		#endregion

		#region UpdateMethods

		public int KrijoRezervimKlienti()
		{
			int b = 0;
			DbController db = new DbController();
			Inicializimi iniObject = new Inicializimi();
			DataSet ds = db.Read("dbKrijoRezervimKlienti",this.emri, this.mbiemri, this.kapari, 
				this.dtFillimi, this.dtMbarimi, this.dtRezervimi, this.emaili);
			if (b == 0)
			{
				//int i = iniObject.Inicializo();
				//idRezervimi = iniObject.idRezervimi ;
				idRezervimi = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
				b = b + db.Create("dbKrijoRezervimDhoma",idRezervimi,this.idDhomaKlienti);
			}
			return b;
		}

		public int KrijoRezervimGrupi()
		{
			int b = 0;
			int r = 0;
			int rGrupi = 0;
			int n = 0;
			DbController db = new DbController();
			n = this.idDhomatGrupi.Length;
			DataSet dsGrupi = db.Read("dbShfaqGrupinPerId", this.idGrupi);
			string grupi = dsGrupi.Tables[0].Rows[0][0].ToString();
			string agjensia = dsGrupi.Tables[0].Rows[0][1].ToString();
			DataSet dsR = db.Read("dbKrijoRezervimGrupi",this.idGrupi,grupi, agjensia, this.kapari,
				this.dtFillimi, this.dtMbarimi, this.dtRezervimi);
			if ( b == 0)
			{
//				Inicializimi iniObject = new Inicializimi();
//				int i = iniObject.Inicializo();
//				idRezervimi = iniObject.idRezervimi ;
				idRezervimi = Convert.ToInt32(dsR.Tables[0].Rows[0][0]);
				n = idDhomatGrupi.Length;
				for(int i = 0;i<n;i++)
				{
					b = b + db.Create("dbKrijoRezervimDhoma",idRezervimi,idDhomatGrupi[i]);
				}
			}
			return b;
		}

		public int ModifikoRezervimKlienti(int idRezervimi,int idDhomaEVjeter,DateTime dataKapari)
		{
			int p = 0;
			DbController db = new DbController();
			p = db.Update("dbModifikoRezervimKlienti",idRezervimi,this.emri, this.mbiemri, this.kapari, this.dtFillimi, 
				this.dtMbarimi, this.dtRezervimi, dataKapari, this.emaili);
			if (p == 0)
				p = db.Update("dbModifikoRezervimDhome",idRezervimi,this.idDhomaKlienti,idDhomaEVjeter);
			else
				return p ;
				
			return p;
		}
		
		
		public int ModifikoRezervimGrupi(int idRezervimi,DateTime dataKapari)
		{
			int p = 0;
			DbController db = new DbController();
			p = db.Update("dbModifikoRezervimGrupi", idRezervimi, this.idGrupi, this.kapari, this.dtFillimi, this.dtMbarimi, this.dtRezervimi );
			return p ;
		}
         
		/// <summary>
		/// Fshin nje rezervim te percaktuar me idRezervimi per nje dhome te percaktuar me idDhoma
		/// </summary>
		/// <param name="idRezervimi"> Rezervimi qe do te fshihet</param>
		/// <param name="idDhoma">Dhoma qe eshte e rezervuar</param>
		/// <returns></returns>
		public int FshiRezervim(int idRezervimi,int fshiArke)
		{
			int p = 0;
			DbController db = new DbController();
			p = db.Delete("dbFshiRezervim",idRezervimi);
			if (fshiArke == 1)
				p = p + db.Delete("dbFshiKaparRezervimiNgaArka", idRezervimi);
			return p;
		}
		public int FshiDhomeRezervuarGrupi(int idRezervimi,int idDhoma)
		{
			int p = 0;
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqDhomaTeRezervuara",idRezervimi);
			DataRow dr = ds.Tables[0].Rows[0];
			if(Convert.ToInt32(dr[0]) == 1)
				p = db.Delete("dbFshiRezervim",idRezervimi);
			if(p ==0)
				p = db.Delete("dbFshiDhomeRezervuarGrupi",idRezervimi,idDhoma);

			return p ;
		}
		public int KrijoRezervimDhomeGrupi(int idRezervimi,int [] idDhomatGrupi)
		{
			int p = 0;
			int n = idDhomatGrupi.Length;
			DbController db = new DbController();
			for(int i = 0;i < n;i++)
				p = db.Create("dbKrijoRezervimDhomeGrupi",idRezervimi,idDhomatGrupi[i]);
			return p;
		}
		#endregion

		#region rezervime te vlefshme

		public DataSet ShfaqRezervimeVlefshmeKlienti()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqTeGjithaRezervimetVlefshme");
			if (ds.Tables[0].Rows.Count == 0)
			{
				return ds;
			}
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_REZERVIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[0]);
				DateTime dataDalje = Convert.ToDateTime(dr[1]);
				DateTime dateRezervimi = Convert.ToDateTime(dr[2]);
				dr["DATA_HYRJE_STR"] = this.konvertoGjate(dataHyrje);
				dr["DATA_DALJE_STR"] = this.konvertoGjate(dataDalje);
				dr["DATA_REZERVIMI_STR"] = this.konverto(dateRezervimi);
			}
			ds.AcceptChanges();
			ds.EnforceConstraints = false;
			DataTable dt1 = ds.Tables[0].Clone();
			dt1.Rows.Clear();
			dt1.TableName = "KLIENTI";
			ds.Tables.Add(dt1);
			ds.Tables["KLIENTI"].Columns.Add("KAPARI_STR", typeof(String));
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
			
				dt1Row["DATA_HYRJE_STR"] = drFirst["DATA_HYRJE_STR"];
				dt1Row["DATA_DALJE_STR"] = drFirst["DATA_DALJE_STR"];
				dt1Row["KAPARI_STR"] = drFirst["KAPARI"].ToString();
				dt1Row["DATA_REZERVIMI_STR"] = drFirst["DATA_REZERVIMI_STR"];
				dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"];
			
		
				while (drFirst["EMRI"].ToString() == Convert.ToString(drNext["EMRI"]) && (drFirst["MBIEMRI"].ToString() == Convert.ToString(drNext["MBIEMRI"]))&&((drFirst["DATA_HYRJE_STR"].ToString() == Convert.ToString(drNext["DATA_HYRJE_STR"]))) && drFirst["DATA_DALJE_STR"].ToString() == Convert.ToString(drNext["DATA_DALJE_STR"]) && (i < ds.Tables[0].Rows.Count - 1))
				{
					
					dt1Row["DHOMA_EMRI"] += Environment.NewLine + drNext["DHOMA_EMRI"];
					i++;
					if (i < ds.Tables[0].Rows.Count - 1)
					{
						drFirst = ds.Tables[0].Rows[i];
						drNext = ds.Tables[0].Rows[i + 1];
					}
				}
				dt1.Rows.Add(dt1Row);
			}
			return ds;
		}
		
		
		public DataSet ShfaqRezervimeVlefshmeKlientiPerDaten(DateTime dtFillimi)
		{
			DataSet ds  = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimeVlefshmeKlientiPerDatenEdhene",dtFillimi);
			if (ds.Tables[0].Rows.Count == 0)
			{
				return ds;
			}
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_REZERVIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[0]);
				DateTime dataDalje = Convert.ToDateTime(dr[1]);
				DateTime dateRezervimi = Convert.ToDateTime(dr[5]);
				dr[7] = this.konvertoGjate(dataHyrje);
				dr[8] = this.konvertoGjate(dataDalje);
				dr[9] = this.konverto(dateRezervimi);
			}
			ds.AcceptChanges();
			ds.EnforceConstraints = false;
			DataTable dt1 = ds.Tables[0].Clone();
			dt1.Rows.Clear();
			dt1.TableName = "KLIENTI";
			ds.Tables.Add(dt1);
			ds.Tables["KLIENTI"].Columns.Add("KAPARI_STR", typeof(String));
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
				dt1Row["DATA_HYRJE_STR"] = drFirst["DATA_HYRJE_STR"];
				dt1Row["DATA_DALJE_STR"] = drFirst["DATA_DALJE_STR"];
				dt1Row["KAPARI_STR"] = drFirst["KAPARI"].ToString();
				dt1Row["DATA_REZERVIMI_STR"] = drFirst["DATA_REZERVIMI_STR"];
				dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"];
				while (drFirst["EMRI"].ToString() == Convert.ToString(drNext["EMRI"]) && (drFirst["MBIEMRI"].ToString() == Convert.ToString(drNext["MBIEMRI"])) && (i < ds.Tables[0].Rows.Count - 1))
				{
					if (drFirst["DATA_HYRJE_STR"].ToString() == Convert.ToString(drNext["DATA_HYRJE_STR"]) && drFirst["DATA_DALJE_STR"].ToString() == Convert.ToString(drNext["data_dalje_str"]))
						dt1Row["DHOMA_EMRI"] += Environment.NewLine + drNext["DHOMA_EMRI"];
					else
					{
						dt1Row["DATA_HYRJE_STR"] += Environment.NewLine + drNext["DATA_HYRJE_STR"];
						dt1Row["DATA_DALJE_STR"] += Environment.NewLine + drNext["DATA_DALJE_STR"];
						dt1Row["DATA_REZERVIMI_STR"] += Environment.NewLine + drNext["DATA_REZERVIMI_STR"];
						dt1Row["DHOMA_EMRI"] += Environment.NewLine + drNext["DHOMA_EMRI"];
						dt1Row["KAPARI_STR"] += Environment.NewLine + drNext["KAPARI"].ToString();
					}					
					i++;
					if (i < ds.Tables[0].Rows.Count - 1)
					{
						drFirst = ds.Tables[0].Rows[i];
						drNext = ds.Tables[0].Rows[i + 1];
					}
				}
				dt1.Rows.Add(dt1Row);
			}
			return ds;
		}
		
		public DataSet ShfaqRezervimeVlefshmePerEmerMbiemer(string emer,string mbiemer)
		{
			DataSet ds  = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimeVlefshmePerEmerMbiemer",emer,mbiemer);
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_REZERVIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[2]);
				DateTime dataDalje = Convert.ToDateTime(dr[3]);
				DateTime dateRezervimi = Convert.ToDateTime(dr[4]);
				dr[7] = this.konvertoGjate(dataHyrje);
				dr[8] = this.konvertoGjate(dataDalje);
				dr[9] = this.konverto(dateRezervimi);
			}
			ds.AcceptChanges();
			ds.EnforceConstraints = false;
			DataTable dt1 = ds.Tables[0].Clone();
			dt1.Rows.Clear();
			dt1.TableName = "KLIENTI";
			ds.Tables.Add(dt1);
			ds.Tables["KLIENTI"].Columns.Add("KAPARI_STR", typeof(String));
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
			
				
				dt1Row["DATA_HYRJE_STR"] = drFirst["DATA_HYRJE_STR"];
				dt1Row["DATA_DALJE_STR"] = drFirst["DATA_DALJE_STR"];
				dt1Row["KAPARI_STR"] = drFirst["KAPARI"].ToString();
				dt1Row["DATA_REZERVIMI_STR"] = drFirst["DATA_REZERVIMI_STR"];
				dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"];
				
		
				while (drFirst["EMRI"].ToString() == Convert.ToString(drNext["EMRI"]) && (drFirst["MBIEMRI"].ToString() == Convert.ToString(drNext["MBIEMRI"])) && (i < ds.Tables[0].Rows.Count - 1))
				{
					if (drFirst["DATA_HYRJE_STR"].ToString() == Convert.ToString(drNext["DATA_HYRJE_STR"]) && drFirst["DATA_DALJE_STR"].ToString() == Convert.ToString(drNext["data_dalje_str"]))
						dt1Row["DHOMA_EMRI"] += Environment.NewLine + drNext["DHOMA_EMRI"];
					else
					{
						dt1Row["DATA_HYRJE_STR"] += Environment.NewLine + drNext["DATA_HYRJE_STR"];
						dt1Row["DATA_DALJE_STR"] += Environment.NewLine + drNext["DATA_DALJE_STR"];
						dt1Row["DATA_REZERVIMI_STR"] += Environment.NewLine + drNext["DATA_REZERVIMI_STR"];
						dt1Row["DHOMA_EMRI"] += Environment.NewLine + drNext["DHOMA_EMRI"];
						dt1Row["KAPARI_STR"] += Environment.NewLine + drNext["KAPARI"].ToString();
					}
					i++;
					if (i < ds.Tables[0].Rows.Count - 1)
					{
						drFirst = ds.Tables[0].Rows[i];
						drNext = ds.Tables[0].Rows[i + 1];
					}
				}
				dt1.Rows.Add(dt1Row);
			}
			return ds;
		}
		public DataSet ShfaqRezervimeVlefshmePerDhome(int idDhoma)
		{
			DataSet ds  = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimeVlefshmePerDhomen",idDhoma);
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_REZERVIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[2]);
				DateTime dataDalje = Convert.ToDateTime(dr[3]);
				DateTime dateRezervimi = Convert.ToDateTime(dr[4]);
				dr[8] = this.konvertoGjate(dataHyrje);
				dr[9] = this.konvertoGjate(dataDalje);
				dr[10] = this.konverto(dateRezervimi);
			}
			ds.AcceptChanges();
			ds.EnforceConstraints = false;
			DataTable dt1 = ds.Tables[0].Clone();
			dt1.Rows.Clear();
			dt1.TableName = "KLIENTI";
			ds.Tables.Add(dt1);
			ds.Tables["KLIENTI"].Columns.Add("KAPARI_STR", typeof(String));
			ds.Tables["KLIENTI"].Columns.Add("EMRI_STR", typeof(String));
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
				dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"].ToString();
				// Te dhenat per REZERVIMIN
			
				
				dt1Row["DATA_HYRJE_STR"] = drFirst["DATA_HYRJE_STR"];
				dt1Row["DATA_DALJE_STR"] = drFirst["DATA_DALJE_STR"];
				dt1Row["KAPARI_STR"] = drFirst["KAPARI"].ToString();
				dt1Row["DATA_REZERVIMI_STR"] = drFirst["DATA_REZERVIMI_STR"];
				dt1Row["EMRI_STR"] = drFirst["EMRI"].ToString() + drFirst["MBIEMRI"].ToString();
				dt1.Rows.Add(dt1Row);
			}
			return ds;
		}
		
		
		public DataSet ShfaqRezervimeVlefshmeGrupi()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqTeGjithaRezervimetVlefshmeGrupi");
			if (ds.Tables[0].Rows.Count == 0)
			{
				return ds;
			}
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_REZERVIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[0]);
				DateTime dataDalje = Convert.ToDateTime(dr[1]);
				DateTime dateRezervimi = Convert.ToDateTime(dr[2]);
				dr[8] = this.konvertoGjate(dataHyrje);
				dr[9] = this.konvertoGjate(dataDalje);
				dr[10] = this.konverto(dateRezervimi);
			}
			ds.AcceptChanges();
			ds.EnforceConstraints = false;
			DataTable dt1 = ds.Tables[0].Clone();
			dt1.Rows.Clear();
			dt1.TableName = "KLIENTI";
			ds.Tables.Add(dt1);
			ds.Tables["KLIENTI"].Columns.Add("KAPARI_STR", typeof(String));
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
		
			
				dt1Row["DATA_HYRJE_STR"] = drFirst["DATA_HYRJE_STR"];
				dt1Row["DATA_DALJE_STR"] = drFirst["DATA_DALJE_STR"];
				dt1Row["KAPARI_STR"] = drFirst["KAPARI"].ToString();
				dt1Row["DATA_REZERVIMI_STR"] = drFirst["DATA_REZERVIMI_STR"];
				dt1Row["GRUPI"] = drFirst["GRUPI"];
				dt1Row["AGJENSIA"] = drFirst["AGJENSIA"];
				dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"];
				while (drFirst["ID_REZERVIMI"].ToString() == Convert.ToString(drNext["ID_REZERVIMI"] )&& (i < ds.Tables[0].Rows.Count - 1))
				{
					dt1Row["DHOMA_EMRI"] += Environment.NewLine + drNext["DHOMA_EMRI"];
				
					i++;
					if (i < ds.Tables[0].Rows.Count - 1)
					{
						drFirst = ds.Tables[0].Rows[i];
						drNext = ds.Tables[0].Rows[i + 1];
					}
				}
				dt1.Rows.Add(dt1Row);
			}
			return ds;
		}

		public DataSet ShfaqRezervimeVlefshmeGrupiPerDaten(DateTime dtFillimi)
		{
			DataSet ds  = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimeVlefshmeGrupiPerDatenEdhene",dtFillimi);
			if (ds.Tables[0].Rows.Count == 0)
			{
				return ds;
			}
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_REZERVIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[0]);
				DateTime dataDalje = Convert.ToDateTime(dr[1]);
				DateTime dateRezervimi = Convert.ToDateTime(dr[3]);
				dr[8] = this.konvertoGjate(dataHyrje);
				dr[9] = this.konvertoGjate(dataDalje);
				dr[10] = this.konverto(dateRezervimi);
			}
			ds.AcceptChanges();
			ds.EnforceConstraints = false;
			DataTable dt1 = ds.Tables[0].Clone();
			dt1.Rows.Clear();
			dt1.TableName = "KLIENTI";
			ds.Tables.Add(dt1);
			ds.Tables["KLIENTI"].Columns.Add("KAPARI_STR", typeof(String));
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
		
			
				dt1Row["DATA_HYRJE_STR"] = drFirst["DATA_HYRJE_STR"];
				dt1Row["DATA_DALJE_STR"] = drFirst["DATA_DALJE_STR"];
				dt1Row["KAPARI_STR"] = drFirst["KAPARI"].ToString();
				dt1Row["DATA_REZERVIMI_STR"] = drFirst["DATA_REZERVIMI_STR"];
				dt1Row["GRUPI"] = drFirst["GRUPI"];
				dt1Row["AGJENSIA"] = drFirst["AGJENSIA"];
				dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"];
				while (drFirst["ID_REZERVIMI"].ToString() == Convert.ToString(drNext["ID_REZERVIMI"] )&& (i < ds.Tables[0].Rows.Count - 1))
				{
					dt1Row["DHOMA_EMRI"] += Environment.NewLine + drNext["DHOMA_EMRI"];
				
					i++;
					if (i < ds.Tables[0].Rows.Count - 1)
					{
						drFirst = ds.Tables[0].Rows[i];
						drNext = ds.Tables[0].Rows[i + 1];
					}
				}
				dt1.Rows.Add(dt1Row);
			}
			return ds;
		}

		public DataSet ShfaqRezervimeVlefshmePerGrupAgjensi(int idGrupi)
		{
			DataSet ds  = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimeVlefshmePerGrupAgjensi",idGrupi);
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_REZERVIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[2]);
				DateTime dataDalje = Convert.ToDateTime(dr[3]);
				DateTime dateRezervimi = Convert.ToDateTime(dr[4]);
				dr[8] = this.konvertoGjate(dataHyrje);
				dr[9] = this.konvertoGjate(dataDalje);
				dr[10] = this.konverto(dateRezervimi);
			}
			ds.AcceptChanges();
			ds.EnforceConstraints = false;
			DataTable dt1 = ds.Tables[0].Clone();
			dt1.Rows.Clear();
			dt1.TableName = "KLIENTI";
			ds.Tables.Add(dt1);
			ds.Tables["KLIENTI"].Columns.Add("KAPARI_STR", typeof(String));
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
				dt1Row["GRUPI"] = drFirst["GRUPI"];
				dt1Row["AGJENSIA"] = drFirst["AGJENSIA"];
				// Te dhenat per REZERVIMIN
				dt1Row["DATA_HYRJE_STR"] = drFirst["DATA_HYRJE_STR"];
				dt1Row["DATA_DALJE_STR"] = drFirst["DATA_DALJE_STR"];
				dt1Row["KAPARI_STR"] = drFirst["KAPARI"].ToString();
				dt1Row["DATA_REZERVIMI_STR"] = drFirst["DATA_REZERVIMI_STR"];
				dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"];
				dt1Row["ID_REZERVIMI"] = drFirst["ID_REZERVIMI"];		
				while (drFirst["ID_REZERVIMI"].ToString() == Convert.ToString(drNext["ID_REZERVIMI"]) && (i < ds.Tables[0].Rows.Count - 1))
				{
					
					dt1Row["DHOMA_EMRI"] += Environment.NewLine + drNext["DHOMA_EMRI"];
					
					i++;
					if (i < ds.Tables[0].Rows.Count - 1)
					{
						drFirst = ds.Tables[0].Rows[i];
						drNext = ds.Tables[0].Rows[i + 1];
					}
				}
				dt1.Rows.Add(dt1Row);
			}
			return ds;
		}
		public DataSet ShfaqRezervimeVlefshmeGrupiPerDhome(int idDhoma)
		{
			DataSet ds  = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimeVlefshmeGrupiPerDhomen",idDhoma);
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_REZERVIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[2]);
				DateTime dataDalje = Convert.ToDateTime(dr[3]);
				DateTime dateRezervimi = Convert.ToDateTime(dr[4]);
				dr[7] = this.konvertoGjate(dataHyrje);
				dr[8] = this.konvertoGjate(dataDalje);
				dr[9] = this.konverto(dateRezervimi);
			}
			ds.AcceptChanges();
			ds.EnforceConstraints = false;
			DataTable dt1 = ds.Tables[0].Clone();
			dt1.Rows.Clear();
			dt1.TableName = "KLIENTI";
			ds.Tables.Add(dt1);
			ds.Tables["KLIENTI"].Columns.Add("KAPARI_STR", typeof(String));
			ds.Tables["KLIENTI"].Columns.Add("EMRI_STR", typeof(String));
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
				dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"].ToString();
				// Te dhenat per REZERVIMIN
			
				dt1Row["GRUPI"] = drFirst["GRUPI"];
				dt1Row["AGJENSIA"] = drFirst["AGJENSIA"];
				dt1Row["DATA_HYRJE_STR"] = drFirst["DATA_HYRJE_STR"];
				dt1Row["DATA_DALJE_STR"] = drFirst["DATA_DALJE_STR"];
				dt1Row["KAPARI_STR"] = drFirst["KAPARI"].ToString();
				dt1Row["DATA_REZERVIMI_STR"] = drFirst["DATA_REZERVIMI_STR"];
				dt1.Rows.Add(dt1Row);
			}
			return ds;
		}
		public DataSet ShfaqRezervimeVlefshme()
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqTeGjithaRezervimetVlefshme");
			return ds;
		}
		public DataSet ShfaqRezervimeVlefshmeNeGrup()
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqTeGjithaRezervimetVlefshmeGrupi");
			return ds;
		}
		#endregion

		#region ReadMethods
		public DataSet ShfaqRezervim(DateTime dtFillimi)
		{
			DataSet ds  = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervim",dtFillimi);
			return ds;
		}
		
		public DataSet ShfaqRezervimeKlienti()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqTeGjithaRezervimetKlienti");
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[1]);
				DateTime dataDalje = Convert.ToDateTime(dr[2]);
				dr["DATA_HYRJE_STR"] = this.konvertoGjate(dataHyrje);
				dr["DATA_DALJE_STR"] = this.konvertoGjate(dataDalje);
			}
			ds.AcceptChanges();
			return ds;
		}

		public DataSet ShfaqRezervimeGrupi()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqTeGjithaRezervimetGrupi");
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[1]);
				DateTime dataDalje = Convert.ToDateTime(dr[2]);
				dr[9] = this.konvertoGjate(dataHyrje);
				dr[10] = this.konvertoGjate(dataDalje);
			}
			ds.AcceptChanges();
			return ds;
		}

		public DataSet ShfaqRezervimeGrupi(int idGrupi, DateTime dtFillimi, DateTime dtMbarimi, int idRezervimi)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbRezervimetPerDatatDheGrupin",idGrupi, dtFillimi, dtMbarimi, idRezervimi);
			return ds;
		}
		public DataSet ShfaqRezervimeGrupi(int idGrupi, DateTime dtFillimi, DateTime dtMbarimi)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbRezervimetPerDatatDheGrupin",idGrupi, dtFillimi, dtMbarimi);
			return ds;
		}
		public DataSet ShfaqRezervimeGrupiDhome()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqTeGjithaRezervimetGrupiDhome");
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_REZERVIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[4]);
				DateTime dataDalje = Convert.ToDateTime(dr[5]);
				DateTime dataRezervimi = Convert.ToDateTime(dr[3]);
				dr[12] = this.konvertoGjate(dataHyrje);
				dr[13] = this.konvertoGjate(dataDalje);
				dr[14] = this.konvertoGjate(dataRezervimi);
			}
			ds.AcceptChanges();
			return ds;
		}
		
		public DataSet ShfaqRezervimePerEmerMbiemer(string emer, string mbiemer)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimetPerKlientPerEmerMbiemerTeDhene", emer, mbiemer);
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[4]);
				DateTime dataDalje = Convert.ToDateTime(dr[5]);
				dr["DATA_HYRJE_STR"] = this.konvertoGjate(dataHyrje);
				dr["DATA_DALJE_STR"] = this.konvertoGjate(dataDalje);
			}
			ds.AcceptChanges();
			return ds;
		}
		public DataSet ShfaqRezervimePerGrupAgjensi(string emer, string mbiemer)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimetPerGrupAgjensiTeDhene", emer, mbiemer);
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[2]);
				DateTime dataDalje = Convert.ToDateTime(dr[3]);
				dr[9] = this.konvertoGjate(dataHyrje);
				dr[10] = this.konvertoGjate(dataDalje);
			}
			ds.AcceptChanges();
			return ds;
		}
		public DataSet ShfaqRezervimeDhomePerGrupAgjensi(string emer, string mbiemer)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimetDhomePerGrupAgjensiTeDhene", emer, mbiemer);
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_REZERVIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[2]);
				DateTime dataDalje = Convert.ToDateTime(dr[3]);
				DateTime dataRezervimi = Convert.ToDateTime(dr[1]);
				dr[12] = this.konvertoGjate(dataHyrje);
				dr[13] = this.konvertoGjate(dataDalje);
				dr[14] = this.konverto(dataRezervimi);
			}
			ds.AcceptChanges();
			return ds;
		}
		
		public DataSet ShfaqRezervimeKlientPerDaten(DateTime varDate1)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimetPerKlientPerDatenEdhene", varDate1);
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_REZERVIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[2]);
				DateTime dataDalje = Convert.ToDateTime(dr[3]);
				DateTime dataRezervimi = Convert.ToDateTime(dr["DATA_REZERVIMI"]);
				dr["DATA_HYRJE_STR"] = this.konvertoGjate(dataHyrje);
				dr["DATA_DALJE_STR"] = this.konvertoGjate(dataDalje);
				dr["DATA_REZERVIMI_STR"] = this.konvertoGjate(dataRezervimi);
			}
			ds.AcceptChanges();
			return ds;
		}

		public DataSet ShfaqRezervimeGrupPerDaten(DateTime varDate1)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimetPerGrupPerDatenEdhene", varDate1);
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[2]);
				DateTime dataDalje = Convert.ToDateTime(dr[3]);
				dr[9] = this.konvertoGjate(dataHyrje);
				dr[10] = this.konvertoGjate(dataDalje);
			}
			ds.AcceptChanges();
			return ds;
		}
		public DataSet ShfaqRezervimeGrupDhomePerDaten(DateTime varDate1)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimetPerGrupDhomePerDatenEdhene", varDate1);
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_REZERVIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[2]);
				DateTime dataDalje = Convert.ToDateTime(dr[3]);
				DateTime dataRezervimi = Convert.ToDateTime(dr[1]);
				dr[12] = this.konvertoGjate(dataHyrje);
				dr[13] = this.konvertoGjate(dataDalje);
				dr[14] = this.konverto(dataRezervimi);
			}
			ds.AcceptChanges();
			return ds;
		}
	
		public DataSet ShfaqRezervimDhomaGrupi(int idRezervimi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimDhomaGrupi", idRezervimi);
			return ds;
		}
		public DataSet ShfaqDataPerRezervim(int idRezervimi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqDataPerRezervim", idRezervimi);
			return ds;
		}
		
		public DataSet ShfaqDhomaPerRezervim(int idRezervimi, DateTime data)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimDhomaGrupiPerDaten", idRezervimi, data);
			return ds;
		}
		public DataSet ShfaqDhomaPerRezervim(int idRezervimi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimDhomaGrupiPerDaten", idRezervimi);
			return ds;
		}
		public DataSet id_rez_fundit()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqIdRezervimFundit");
			return ds;
		}

		public DataSet ShfaqRezervimeSkaduar()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimeSkaduar");
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_REZERVIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[2]);
				DateTime dataDalje = Convert.ToDateTime(dr[3]);
				DateTime dataRezervimi = Convert.ToDateTime(dr[1]);
				dr["DATA_HYRJE_STR"] = this.konvertoGjate(dataHyrje);
				dr["DATA_DALJE_STR"] = this.konvertoGjate(dataDalje);
				dr["DATA_REZERVIMI_STR"] = this.konverto(dataRezervimi);
			}
			ds.AcceptChanges();
			return ds;
		}

		public DataSet ShfaqRezervimeSkaduarGrupe()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqRezervimeSkaduarGrupe");
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[2]);
				DateTime dataDalje = Convert.ToDateTime(dr[3]);
				dr[9] = this.konvertoGjate(dataHyrje);
				dr[10] = this.konvertoGjate(dataDalje);
			}
			ds.AcceptChanges();
			return ds;
		}
	
		#endregion

		private string konverto(DateTime data)
		{
			string data_str = data.ToString();
			string dita, muaji, viti, ora;
			dita = data_str.Substring(8, 2);
			muaji = data_str.Substring(5, 2);
			viti = data_str.Substring(0, 4);
			ora =data_str.Substring(11);
			data_str = dita + "-" + muaji + "-" + viti ;
			return data_str;
		}

		private string konvertoGjate(DateTime data)
		{
			string data_str = data.ToString();
			string dita, muaji, viti, ora;
			dita = data_str.Substring(8, 2);
			muaji = data_str.Substring(5, 2);
			viti = data_str.Substring(0, 4);
			ora =data_str.Substring(11);
			data_str = dita + "-" + muaji + "-" + viti + " " + ora;
			return data_str;
		}

	}
}
