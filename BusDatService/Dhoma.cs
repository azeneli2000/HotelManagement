using System;
using System.Data.SqlClient;
using System.Data;
using HotelManagment.BusDatService;

namespace HotelManagment.BusDatService
{
	/// <summary>
	/// Eshte pergjegjese per veprimet qe kane te bejne me dhomat.
	/// </summary>
	public class Dhoma
	{
		private string emri = "null";
		private int idKategoria = 0;
		private string gjendja = "null";
		private int numKrevatesh = 0;

		#region contructors
		public Dhoma()
		{
			// 
			// TODO: Add constructor logic here
			//
		}
		public Dhoma (string emri, int kategoria, int numKrevatesh)
		{
			this.emri = emri;
			this.idKategoria = kategoria;
			this.numKrevatesh = numKrevatesh;
         
		}
		
		#endregion constructors
		
		#region private methods
		/// <summary>
		/// Merr si parameter id_dhoma dhe data. Kthen nje vlere bool e cila eshte true 
		/// nqs dhoma eshte rezervuar per daten ose false ne te kundert
		/// </summary>
		/// <param name="id_dhoma"></param>
		/// <param name="data"></param>
		/// <returns> bool </returns>
		
		private bool Rezervuar(int id_dhoma, DateTime data, DataSet ds)
		{
			bool rezervuar = false;
			string str_data_fillimi;
			string str_data_mbarimi;
			DateTime data_fillimi;
			DateTime data_mbarimi;
			int id = 0;
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				data_fillimi = Convert.ToDateTime(dr[1]);
				data_mbarimi = Convert.ToDateTime(dr[2]);
				str_data_fillimi = data_fillimi.ToShortDateString();
				str_data_mbarimi = data_mbarimi.ToShortDateString();
				data_fillimi = Convert.ToDateTime(str_data_fillimi);
				data_mbarimi = Convert.ToDateTime(str_data_mbarimi);
				id = Convert.ToInt32(dr["ID_DHOMA"]);
				if (( data_fillimi <= data )&& (data_mbarimi > data) && (id == id_dhoma))
				{
					rezervuar = true;
					break;
				}										   
			}
			return rezervuar;
		}

		/// <summary>
		/// Merr si parameter id_dhoma dhe data. Kthen nje vlere bool e cila eshte true 
		/// nqs dhoma eshte rezervuar per daten dhe oren ose false ne te kundert
		/// </summary>
		/// <param name="id_dhoma"></param>
		/// <param name="data"></param>
		/// <returns> bool </returns>
		
		private bool RezervuarPerDate_Ore(int id_dhoma, DateTime data, DataSet ds)
		{
			bool rezervuar = false;
			DateTime data_fillimi;
			DateTime data_mbarimi;
			int id = 0;
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				data_fillimi = Convert.ToDateTime(dr[1]);
				data_mbarimi = Convert.ToDateTime(dr[2]);
				id = Convert.ToInt32(dr[6]);
				if (( data_fillimi <= data )&& (data_mbarimi > data) && (id == id_dhoma))
				{
					rezervuar = true;
					break;
				}										   
			}
			return rezervuar;
		}

		/// <summary>
		/// Merr si parameter id_dhoma,data dhe kthen numrin e klienteve qe jane ne dhome per daten
		/// </summary>
		/// <param name="id_dhoma"></param>
		/// <param name="data"></param>
		/// <returns> int </returns>
		private int NumerKlientesh(int id_dhoma, DateTime data, DataSet ds)
		{
			DateTime data_fillimi;
			DateTime data_mbarimi;
			int id = 0;
			int nr = 0;
			bool ugjet = false;
			bool k1;
			bool k2;
			bool k3;
			string str_data_fillimi;
			string str_data_mbarimi;
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				data_fillimi = Convert.ToDateTime(dr[0]);
				data_mbarimi = Convert.ToDateTime(dr[1]);
				id = Convert.ToInt32(dr[2]);
				str_data_fillimi = data_fillimi.ToShortDateString();
				str_data_mbarimi = data_mbarimi.ToShortDateString();
				data_fillimi = Convert.ToDateTime(str_data_fillimi);
				data_mbarimi = Convert.ToDateTime(str_data_mbarimi);
				k1 = ( data_fillimi <= data );
				k2 = (data_mbarimi > data);
				k3 = (id == id_dhoma);
				ugjet = (k1 && k2 && k3);
				if ( ugjet == true)
				{
					nr = nr + 1;
				}										   
			}
			return nr;
		}
        
		/// <summary>
		/// Merr si parameter id_dhoma,data dhe kthen numrin e klienteve qe jane ne dhome per daten dhe oren
		/// </summary>
		/// <param name="id_dhoma"></param>
		/// <param name="data"></param>
		/// <returns> int </returns>
		private int NumerKlienteshPerDate_Ore(int id_dhoma, DateTime data, DataSet ds)
		{
			DateTime data_fillimi;
			DateTime data_mbarimi;
			int id = 0;
			int nr = 0;
			bool ugjet = false;
			bool k1;
			bool k2;
			bool k3;
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				data_fillimi = Convert.ToDateTime(dr[0]);
				data_mbarimi = Convert.ToDateTime(dr[1]);
				id = Convert.ToInt32(dr[2]);
				k1 = ( data_fillimi <= data );
				k2 = (data_mbarimi > data);
				k3 = (id == id_dhoma);
				ugjet = (k1 && k2 && k3);
				if ( ugjet == true)
				{
					nr = nr + 1;
				}										   
			}
			return nr;
		}

		/// <summary>
		/// Merr si parameter id_dhoma,dtKerkimi dhe kthen numrin 
		/// e diteve te gjate te cilave dhoma ka qene e lire
		/// dhe numrin e diteve gjate te cilave dhoma ka qene e zene me ane te nje dataseti
		/// <param name="id_dhoma"></param>
		/// <param name="dtkerkimi"></param>
		/// <returns> DataSet </returns>
		private DataSet NumerDitesh(int id_dhoma, DateTime dtKerkimi, int id_kategoria)
		{
			DbController db = new DbController();
			int viti = dtKerkimi.Year;
			int viti_sot = System.DateTime.Today.Year;
			int numer_total_ditesh;
			DateTime dateFillimi = Convert.ToDateTime(viti + "-" + 1 + "-" + 1);
			DateTime dateMbarimi;
			if (viti == viti_sot)
			{
				dateMbarimi = dtKerkimi;
				TimeSpan ts = dateMbarimi.Date.Subtract(dateFillimi.Date); 
				numer_total_ditesh = Convert.ToInt32(ts.Days);
			}
			else
			{
				dateMbarimi = Convert.ToDateTime(viti + "-" + 12 + "-" + 31);
				if (viti % 4 == 0)
				{
					numer_total_ditesh = 366;
				}
				else
				{
					numer_total_ditesh = 365;
				}
			}
			DateTime dita;
			int dite_zena = 0 ;
			string var = "dbShfaqKlientDhomeData";
			DataSet ds = db.Read(var, id_dhoma);
			DateTime date_hyrje;
			DateTime date_dalje;
			for (int i = 0 ; i < numer_total_ditesh + 1 ; i++)
			{
				dita =  dateFillimi.Date.AddDays(i);
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					date_hyrje = Convert.ToDateTime(dr[0]);
					date_dalje = Convert.ToDateTime(dr[1]);
					bool k1 = (id_kategoria == 31);
					bool k2 = ((date_hyrje.Date <= dita.Date)&& (dita.Date < date_dalje.Date));
					bool k3 = ((date_hyrje.Date <= dita.Date)&& (dita.Date <= date_dalje.Date));
					if (((!k1 )&&(k2))||(k1 && k3))
					{
						dite_zena = dite_zena + 1;
						break;
					}
				}
			}
			int dite_lira = numer_total_ditesh - dite_zena;
			DataSet ds1 = new DataSet();
			ds1.Tables.Add();
			ds1.Tables[0].Columns.Add("DITE_ZENA", typeof(Int32));
			ds1.Tables[0].Columns.Add("DITE_LIRA", typeof(Int32));
			DataRow new_row = ds1.Tables[0].NewRow();
			new_row["DITE_ZENA"] = dite_zena;
			new_row["DITE_LIRA"] = dite_lira;
			ds1.Tables[0].Rows.Add(new_row);
			ds1.AcceptChanges();
			return ds1;

		}
		private string konverto(DateTime data)
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
		
		private string konverto_header(DateTime data)
		{
			string data_str = data.ToString();
			string dita, muaji, viti;
			dita = data_str.Substring(8, 2);
			muaji = data_str.Substring(5, 2);
			viti = data_str.Substring(0, 4);
			data_str = viti + System.Environment.NewLine + dita +  "-" + muaji ;
			return data_str;

		}

		private string gjej_dite(string day)
		{
			string dite = "";
			switch(day)
			{
				case "Monday":
					dite = "Hen";
					break;
				case "Tuesday":
					dite = "Mar";
					break;
				case "Wednesday":
					dite = "Mer";
					break;
				case "Thursday":
					dite = "Enj";
					break;
				case "Friday":
					dite = "Pre";
					break;
				case "Saturday":
					dite = "Sht";
					break;
				case "Sunday":
					dite = "Die";
					break;
				default:
					dite = "";
					break;
			}
			return dite;
		}
		private int GjejPagesen(int idKategoria, int cmimi, DateTime dtFillimi, DateTime dtMbarimi)
		{
			TimeSpan ts;
			int pagesa;
			if (idKategoria == 31)
			{
				ts = dtMbarimi.Subtract(dtFillimi);
				double ore = ts.TotalHours;
				pagesa = Convert.ToInt32(Math.Round(cmimi * ore, 2));
			}
			else
			{
				ts = dtMbarimi.Date.Subtract(dtFillimi.Date);
				int dite = ts.Days;
				pagesa = dite * cmimi;
			}
			return pagesa;
		}
		#endregion private methods

		#region public methods
		/// <summary>
		/// krijon nje dhome ne baze te atributeve te klases.
		/// </summary>
		/// <returns>int</returns>
		public int KrijoDhome(int cift)
		{
			int p = 0;int c = 0;
			string var = "dbKrijoDhome";
			DataSet ds = null;
			DbController db = new DbController();
			ds = this.ShfaqDhoma();
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				if(emri == dr["DHOMA_EMRI"].ToString())
					c = 1;
				
			}
			if (c == 0)
				p = db.Create(var,cift,emri,idKategoria,numKrevatesh);
			else
				p = c;
			return p;
			//nese p = 0 dhoma ushtua me sukses, nese p = 1 ekziston nje dhome me kete emer per kete kategori
		}
        
		/// <summary>
		/// modifikon karakteristikat e nje dhome ne baze te atributeve te klases dhe merr si parameter idDhoma.
		/// </summary>
		/// <param name="idDhoma"></param>
		/// <returns>int</returns>
		public int ModifikoDhome(int idDhoma, int dhomaCift)
		{
			int p = 0;int c = 0;int a = 0;
			DataSet ds = null;
			string var = "dbModifikoDhome";
			DbController db = new DbController();
			ds = this.ShfaqDhomeKategori(idKategoria);
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				if(emri == dr[0].ToString())
				{
					if( idDhoma == Convert.ToInt32(dr[1]))
						a =1;// po modifikohet nje dhome ekzistuese
					else
						a = 2;//emri i dhomes eshte perdorur me pare
				}
				
			}
			if ( a == 2)	
				p = 1;			
			else
				p = db.Update(var,idDhoma,emri,dhomaCift,idKategoria,numKrevatesh);
			return p;
		}
		//		public int ModifikoGjendjeDhome(int idDhoma)
		//		{
		//			int p = 0;
		//			DataSet ds = null;
		//			DataSet ds1 = null;
		//			DbController db = new DbController();
		//			ds1 = this.NxirrDhome(idDhoma);
		//			DataRow dr = ds1.Tables[0].Rows[0];
		//			this.numKrevatesh = Convert.ToInt32(dr[4]);
		//			ds = db.Read("dbGjejNrKlientDhome",idDhoma);
		//			int nrKlientDhome = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
		//			if ( nrKlientDhome == 0)
		//				gjendja = "L";
		//			else if(nrKlientDhome == this.numKrevatesh)
		//				gjendja = "Z";
		//			else if(  nrKlientDhome < this.numKrevatesh)
		//				gjendja = "JZ";
		//			
		//			p = db.Update("dbModifikoGjendjeDhome", this.gjendja, idDhoma);
		//			
		//			return p;
		//		}

			
		public int FshiDhome(int idDhoma)
		{
			#region local variables
			int p = 0;
			int z = 2;// dhoma eshte e zene
			int r =  1;//dhoma eshte e rezervuar
			DataSet ds = null;
			DataSet ds1 = null;
			#endregion local variables
			DbController db = new DbController();
			ds1 = db.Read("dbNxirrDhomeRezervuar",idDhoma);
			bool ugjet = false;
			if (Convert.ToInt32(ds1.Tables[0].Rows.Count) == 0)
			{
				Klienti klient = new Klienti();
				ds =  db.Read("dbShfaqGjitheKlientetNeHotel");
				if(ds.Tables[0].Rows.Count != 0)
				{
					foreach (DataRow dr in ds.Tables[0].Rows)
					{
						if( idDhoma == Convert.ToInt32(dr["ID_DHOMA"]))
						{
							ugjet = true;
							return z;
						}
					}
				}
				else
				{
					//DataSet dsCmime
					string var = "dbFshiDhome";
					p = db.Delete(var,idDhoma);
					return p;
				}
				if (!ugjet)
				{
					string var = "dbFshiDhome";
					p = db.Delete(var,idDhoma);
					return p;
				}
			}
			else
				p = r;
			return p;
		}
		/// <summary>
		/// merr si parameter idDhoma dhe vendos ne atributetet e klases te dhenat e dhomes korrespondente
		/// </summary>
		/// <param name="idDhoma"></param>
		/// <returns>DataSet</returns>
		public DataSet NxirrDhome(int idDhoma)
		{
			string var = "dbShfaqDhome";
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read(var,idDhoma);
			return ds;
		}
		/// <summary>
		/// merr si parameter idDhoma dhe data dhe vendos ne atributetet e klases te dhenat e dhomes korrespondente
		/// </summary>
		/// <param name="idDhoma"></param>
		/// <param name="data"></param>
		/// <returns>DataSet</returns>
		public DataSet NxirrDhomeCmim(int idDhoma, DateTime data)
		{
			string var = "dbShfaqDhome";
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read(var,idDhoma, data);
			return ds;
		}
		/// <summary>
		/// merr si parameter idDhoma dhe data dhe nxjerr te dhenat e dhomes per ate date
		/// </summary>
		/// <param name="idDhoma"></param>
		/// <param name="data"></param>
		/// <returns>DataSet</returns>
		public DataSet NxirrDhome(int idDhoma, DateTime data)
		{
			string var = "dbShfaqDhome";
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read(var,idDhoma);
			int id_kategoria = Convert.ToInt32(ds.Tables[0].Rows[0][5]);
			DataSet ds1 = new DataSet();
			ds1.Tables.Add();
			ds1.Tables[0].Columns.Add("KRITER", typeof(string));
			ds1.Tables[0].Columns.Add("PERSHKRIM", typeof(string));
			DataRow dr = ds1.Tables[0].NewRow();
			dr[0] = "Dhoma";
			dr[1] = Convert.ToString(ds.Tables[0].Rows[0][1]);
			ds1.Tables[0].Rows.Add(dr);
			dr = ds1.Tables[0].NewRow();
			dr[0] = "Kategoria";
			dr[1] = Convert.ToString(ds.Tables[0].Rows[0][2]);
			ds1.Tables[0].Rows.Add(dr);
			dr = ds1.Tables[0].NewRow();
			dr[0] = "Kapaciteti";
			int numer_krevatesh = Convert.ToInt32(ds.Tables[0].Rows[0][3]);
			dr[1] = Convert.ToString(numer_krevatesh);
			ds1.Tables[0].Rows.Add(dr);
			dr = ds1.Tables[0].NewRow();
			dr[0] = "Nr i klienteve";
			var = "dbShfaqGjitheHyrjet";
			DataSet dsHyrje = db.Read(var);
			int numer_klientesh = this.NumerKlienteshPerDate_Ore(idDhoma, data, dsHyrje);
			dr[1] = numer_klientesh.ToString();
			ds1.Tables[0].Rows.Add(dr);
			dr = ds1.Tables[0].NewRow();
			dr[0] = "Gjendja";
			var = "dbShfaqTeGjitheRezervimet";
			DataSet dsRezervime = db.Read(var);
			string gjendja = "";

			if (this.RezervuarPerDate_Ore(idDhoma, data, dsRezervime) == true)
			{
				gjendja = "E rezervuar";
			}
			else if (numer_klientesh == 0)
			{
				gjendja = "E lire";
			}
			else if (numer_klientesh == numer_krevatesh)
			{
				gjendja = "E zene";
			}
			else if (numer_klientesh < numer_krevatesh)
			{
				gjendja = "Pjeserisht e lire";
			}
			dr[1] = gjendja;
			ds1.Tables[0].Rows.Add(dr);

			dr = ds1.Tables[0].NewRow();
			dr[0] = "Numri i diteve te zena";
			int dite_zena = Convert.ToInt32(this.NumerDitesh(idDhoma, data,id_kategoria).Tables[0].Rows[0][0]);
			int dite_lira = Convert.ToInt32(this.NumerDitesh(idDhoma, data,id_kategoria).Tables[0].Rows[0][1]);
			dr[1] = Convert.ToString(dite_zena);
			ds1.Tables[0].Rows.Add(dr);
			dr = ds1.Tables[0].NewRow();
			dr[0] = "Numri i diteve te lira";
			dr[1] = Convert.ToString(dite_lira);
			ds1.Tables[0].Rows.Add(dr);
			ds1.AcceptChanges();
			return ds1;
		}

		/// <summary>
		/// Shfaq emrat e dhomave per ID-ne e kategorise se dhene
		/// </summary>
		/// <param name="idKategoria"></param>
		/// <returns></returns>
		public DataSet ShfaqDhomeKategori(int idKategoria)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqDhomaPerKategorine", idKategoria);
			return ds;
		}

		/// <summary>
		/// Shfaq dhomat e lira per kategori dhe date te dhene
		/// </summary>
		/// <param name="idKategoria"></param>
		/// <param name="dtKerkimi"></param>
		/// <returns></returns>
		public DataSet ShfaqDhomatEZenaPerKategorine(int idKategoria, DateTime dtKerkimi)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("ShfaqDhomatEZenaPerKategorine",  dtKerkimi, idKategoria);
			return ds;
		}

		public DataSet ShfaqDhomaTeLiraKategori(int idKategoria)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqDhomaTeLiraKategori",idKategoria);
			return ds;
		}
		
		public DataSet ShfaqDhoma()
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqDhomat");
			return ds;
		}
		public DataSet ShfaqDhomeData(int idDhoma,DateTime dtFillimi,DateTime dtMbarimi)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqTeDhenaDhomePerDatat",idDhoma,dtFillimi,dtMbarimi);
			return ds;
		}

		public DataSet ShfaqDhomaTeLiraKategoriPerDate(int idKategoria, DateTime dtFillimi, DateTime dtMbarimi)
		{
			DbController db = new DbController();
			DataSet ds;
			DataSet ds1 = new DataSet();
			ds1.Tables.Add();
			ds1.Tables[0].Columns.Add("ID_DHOMA", typeof(Int32));
			ds1.Tables[0].Columns.Add("DHOMA_EMRI", typeof(String));
			ds1.Tables[0].Columns.Add("KAT_EMRI", typeof(String));
			ds1.Tables[0].Columns.Add("NR_KREVATESH", typeof(Int32));
			ds1.Tables[0].Columns.Add("CMIMI", typeof(Int32));
			//			DataSet dsHyrje = db.Read(var);
			if (idKategoria != 31)
			{
				ds = db.Read("ShfaqDhomaTeLiraPerDatePerKategori", idKategoria, dtFillimi, dtMbarimi);
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					//int numer_klientesh = this
					int id = Convert.ToInt32(dr["ID_DHOMA"]);
					DataSet klient = db.Read("dbNumerKlienteshPerDateDhoma",id, dtFillimi, dtMbarimi );
					int numer_klientesh = Convert.ToInt32(klient.Tables[0].Rows[0][0]);
					int numer_krevatesh = Convert.ToInt32(dr[3]);
					if (numer_klientesh < numer_krevatesh)
					{
						DataRow new_row = ds1.Tables[0].NewRow();
						new_row[0] = Convert.ToInt32(dr[0]);
						new_row[1] = dr[1].ToString();
						new_row[2] = dr[2].ToString();
						new_row[3] = Convert.ToInt32(dr[3]);
						new_row[4] = Convert.ToInt32(dr[4]);
						ds1.Tables[0].Rows.Add(new_row);
						ds1.AcceptChanges();
					}
				}
			}
			else
			{
				ds = db.Read("ShfaqDhomaMeOreTeLiraPerData",idKategoria, dtFillimi, dtMbarimi);
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					//int numer_klientesh = this
					int id = Convert.ToInt32(dr["ID_DHOMA"]);
					DataSet klient = db.Read("dbNumerKlienteshPerDateDhoma",id, dtFillimi, dtMbarimi );
					int numer_klientesh = Convert.ToInt32(klient.Tables[0].Rows[0][0]);
					int numer_krevatesh = Convert.ToInt32(dr[3]);
					if (numer_klientesh < numer_krevatesh)
					{
						DataRow new_row = ds1.Tables[0].NewRow();
						new_row[0] = Convert.ToInt32(dr[0]);
						new_row[1] = dr[1].ToString();
						new_row[2] = dr[2].ToString();
						new_row[3] = Convert.ToInt32(dr[3]);
						ds1.Tables[0].Rows.Add(new_row);
						ds1.AcceptChanges();
					}
				}
			}
			return ds1;
		}
		
		public DataSet NumerKlienteshPerDateDhoma(int idDhoma, DateTime dtFillimi, DateTime dtMbarimi, int idKlienti)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbNumerKlienteshPerDateDhoma",idDhoma,dtFillimi,  dtMbarimi, idKlienti);
			return ds;
		}
		
		public DataSet NrKlienteNeDhomePerGrup(int idDhoma, DateTime dtFillimi, DateTime dtMbarimi, int idGrupi)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbNrKlienteNeDhomePerGrup",idDhoma,dtFillimi,  dtMbarimi, idGrupi);
			return ds;
		}
		
		public DataSet NrKlienteNeDhomeNeGrup(int idDhoma, DateTime dtFillimi, DateTime dtMbarimi)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbNrKlienteNeDhomeNeGrup",idDhoma,dtFillimi,  dtMbarimi);
			return ds;
		}
		public DataSet ShfaqDhomaTeLiraKategoriPerDatePerModifikim(int idKategoria, DateTime dtFillimi, DateTime dtMbarimi, int idKlienti)
		{
			DbController db = new DbController();
			DataSet ds;
			DataSet ds1 = new DataSet();
			ds1.Tables.Add();
			ds1.Tables[0].Columns.Add("ID_DHOMA", typeof(Int32));
			ds1.Tables[0].Columns.Add("DHOMA_EMRI", typeof(String));
			ds1.Tables[0].Columns.Add("KAT_EMRI", typeof(String));
			ds1.Tables[0].Columns.Add("NR_KREVATESH", typeof(Int32));
			ds1.Tables[0].Columns.Add("CMIMI", typeof(Int32));
			//			DataSet dsHyrje = db.Read(var);
			if (idKategoria != 31)
			{
				ds = db.Read("ShfaqDhomaTeLiraPerDatePerKategori", idKategoria, dtFillimi, dtMbarimi);
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					//int numer_klientesh = this
					int id = Convert.ToInt32(dr["ID_DHOMA"]);
					DataSet klient = db.Read("dbNumerKlienteshPerDateDhoma",id, dtFillimi, dtMbarimi, idKlienti );
					int numer_klientesh = Convert.ToInt32(klient.Tables[0].Rows[0][0]);
					int numer_krevatesh = Convert.ToInt32(dr[3]);
					if (numer_klientesh < numer_krevatesh)
					{
						DataRow new_row = ds1.Tables[0].NewRow();
						new_row[0] = Convert.ToInt32(dr[0]);
						new_row[1] = dr[1].ToString();
						new_row[2] = dr[2].ToString();
						new_row[3] = Convert.ToInt32(dr[3]);
						new_row[4] = Convert.ToInt32(dr[4]);
						ds1.Tables[0].Rows.Add(new_row);
						ds1.AcceptChanges();
					}
				}
			}
			else
			{
				ds = db.Read("ShfaqDhomaMeOreTeLiraPerData",idKategoria, dtFillimi, dtMbarimi);
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					//int numer_klientesh = this
					int id = Convert.ToInt32(dr["ID_DHOMA"]);
					DataSet klient = db.Read("dbNumerKlienteshPerDateDhoma",id, dtFillimi, dtMbarimi, idKlienti );
					int numer_klientesh = Convert.ToInt32(klient.Tables[0].Rows[0][0]);
					int numer_krevatesh = Convert.ToInt32(dr[3]);
					if (numer_klientesh < numer_krevatesh)
					{
						DataRow new_row = ds1.Tables[0].NewRow();
						new_row[0] = Convert.ToInt32(dr[0]);
						new_row[1] = dr[1].ToString();
						new_row[2] = dr[2].ToString();
						new_row[3] = Convert.ToInt32(dr[3]);
						ds1.Tables[0].Rows.Add(new_row);
						ds1.AcceptChanges();
					}
				}
			}
			return ds1;
		}
		public DataSet ShfaqDhomaPlotesishtTeLiraKategoriPerDatePerModifikim(int idKategoria, DateTime dtFillimi, DateTime dtMbarimi, int idRezervimi)
		{
			DbController db = new DbController();
			DataSet ds;
			ds = db.Read("dbShfaqDhomaPlotesishtTeLiraKategoriPerDatePerModifikim", idKategoria, dtFillimi, dtMbarimi, idRezervimi);
			return ds;
		}

		public DataSet ShfaqDhomaPlotesishtTeLiraKategoriPerDate(int idKategoria, DateTime dtFillimi, DateTime dtMbarimi)
		{
			DbController db = new DbController();
			DataSet ds;
			if (idKategoria != 31)
			{
				ds = db.Read("dbShfaqDhomatPlotesishtTeliraPerKategorinePerDatatEdhena", idKategoria, dtFillimi, dtMbarimi);
			}
			else
			{
				ds = db.Read("dbShfaqDhomaMeOrePlotesishtTeLiraPerData",idKategoria, dtFillimi, dtMbarimi);
			}
			return ds;
		}
		/// <summary>
		/// Merr si parameter daten kthen nje dataset i cili ruan edhe gjendjen e dhomes per daten
		/// </summary>
		/// <param name="data"></param>
		/// <returns> DataSet </returns>
	
		public DataSet ShfaqGjendjeDhomat(DateTime data)
		{
			DataSet ds = null;
			string var = "dbShfaqDhomat";
			DbController db = new DbController();
			ds = db.Read(var);
			ds.Tables[0].Columns.Add("GJENDJA", typeof(String));
			ds.AcceptChanges();
			int id_dhoma = 0;
			int numer_krevatesh = 0;
			int numer_klientesh = 0;
			var = "dbShfaqTeGjitheRezervimet";
			DataSet dsRezervime = db.Read(var);
			var = "dbShfaqGjitheHyrjet";
			DataSet dsHyrje = db.Read(var);
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				id_dhoma = Convert.ToInt32(dr[0]);
				numer_krevatesh = Convert.ToInt32(dr[2]);
				numer_klientesh = this.NumerKlienteshPerDate_Ore(id_dhoma, data, dsHyrje);
				if (this.RezervuarPerDate_Ore(id_dhoma, data, dsRezervime ) == true)
				{
					dr[6] = "R";
				}
				else if (numer_klientesh == 0)
				{
					dr[6] = "L";
				}
				else if (numer_klientesh == numer_krevatesh)
				{
					dr[6] = "Z";
				}
				else if (numer_klientesh < numer_krevatesh)
				{
					dr[6] = "JZ";
				}
			}
			ds.AcceptChanges();
			return ds;
		}
		
		/// <summary>
		///  kthen te gjithe klientet per nje dhome te dhene
		/// </summary>
		/// <param name="idDhoma"></param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqKlientetPerDhomen(int id_dhoma)
		{
			DataSet ds = null;
			string var = "dbShfaqKlientetPerDhomenEdhene";
			DbController db = new DbController();
			ds = db.Read(var, id_dhoma);
			return ds;
		}

		public DataSet ShfaqDhomatEPashlyera()
		{
			DataSet ds = null;
			string var = "dbShfaqDhomaPashlyera";
			DbController db = new DbController(); 
			ds = db.Read(var);
			int numer_krevatesh = 0;
			int cmimi = 0;
			int pagesa_totale = 0;
			int diferenca = 0;
			int shuma = 0;
			int id_kategoria;
			string emri;
			string mbiemri;
			DateTime dataHyrje;
			DateTime dataDalje;
			TimeSpan ts;
			int nr_ditesh = 0;
			ds.Tables[0].Columns.Add("PAGESA_TOTALE", typeof(Int32));
			ds.Tables[0].Columns.Add("DIFERENCA", typeof(Int32));
			ds.Tables[0].Columns.Add("NUMER_DITESH", typeof(string));
			ds.AcceptChanges();
			double ore;
			string dite;
			double cmimi_double;
			double numer_krevatesh_double;
			double pagesa_totale_double;
			double diferenca_double;
			double kapari_double = 0;
			double nr_oresh_double;
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				emri = Convert.ToString(dr[0]);
				mbiemri = Convert.ToString(dr[1]);
				dr[0] = emri + "  " + mbiemri;
				numer_krevatesh = Convert.ToInt32(dr[6]);
				cmimi = Convert.ToInt32(dr[7]);
				dataHyrje = Convert.ToDateTime(dr[2]);
				dataDalje = Convert.ToDateTime(dr[3]);
				cmimi_double = cmimi;
				numer_krevatesh_double = numer_krevatesh;
				kapari_double = Convert.ToInt32(dr["KAPARI"]);
				id_kategoria = Convert.ToInt32(dr[8]);
				if (id_kategoria == 31)
				{
					ts = dataDalje.Subtract(dataHyrje);
					ore = Math.Round(ts.TotalHours , 1);
					dite = ore.ToString() + " ore";	
				}
				else
				{
					ts = dataDalje.Date.Subtract(dataHyrje.Date);
					nr_ditesh = Convert.ToInt32(ts.TotalDays);
					ore = nr_ditesh;
					dite = nr_ditesh + " dite";
				}
				pagesa_totale_double = (cmimi_double/numer_krevatesh_double) * ore;
				diferenca_double = pagesa_totale_double - kapari_double;
				pagesa_totale = Convert.ToInt32(pagesa_totale_double);
				diferenca = Convert.ToInt32(diferenca_double);
				nr_ditesh = Convert.ToInt32(ore);
				dr[9] = pagesa_totale;
				dr[10] = diferenca;
				shuma = shuma + diferenca;
				dr[11] = dite;
			}
			//konvertimi i dates
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				dataHyrje = Convert.ToDateTime(dr[2]);
				dataDalje = Convert.ToDateTime(dr[3]);
				dr[12] = this.konverto(dataHyrje);
				dr[13] = this.konverto(dataDalje);
			}
			DataRow new_row = ds.Tables[0].NewRow();
			new_row["DHOMA_EMRI"] = "SHUMA";
			new_row["DIFERENCA"] = shuma;
			ds.Tables[0].Rows.Add(new_row);
			ds.AcceptChanges();
			ds.AcceptChanges();
			return ds;
		}

		public DataRow PagesaPerDhomen(string dhoma, DataSet ds1)
		{
			DataSet ds_dhoma = new DataSet();
			ds_dhoma.Tables.Add();
			ds_dhoma.Tables[0].Columns.Add("DHOMA",typeof(String));
			ds_dhoma.Tables[0].Columns.Add("PAGESA",typeof(Int32));
			ds_dhoma.Tables[0].Columns.Add("KAPARI",typeof(Int32));
			ds_dhoma.Tables[0].Columns.Add("DIFERENCA",typeof(Int32));
			ds_dhoma.Tables[0].Columns.Add("KOMENT",typeof(String));
			ds_dhoma.Tables[0].Columns.Add("KAPARI_STR",typeof(String));
			DataSet ds = new DataSet();
			ds = ds1.Copy();
			int nr = ds.Tables[0].Rows.Count;
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				if (dr[5].ToString() != dhoma)
				{
					dr.Delete();
					nr--;
				}								   
			}
			ds.AcceptChanges();
			DateTime mindata;
			DateTime maxdata;
			DateTime datahyrje1, datadalje1;
			DateTime datahyrje = Convert.ToDateTime(ds.Tables[0].Rows[0][2]);
			DateTime datadalje = Convert.ToDateTime(ds.Tables[0].Rows[0][3]);
			mindata = Convert.ToDateTime(ds.Tables[0].Rows[0][2]);
			maxdata = Convert.ToDateTime(ds.Tables[0].Rows[0][3]);
			int index1 = 0;
			int index2 = 0;
			int kapari, cmimi;
			string kapariStr, pagesaStr;
//			kapari = Convert.ToInt32(ds.Tables[0].Rows[0][4]);
			kapariStr = "";
			pagesaStr = "";
			kapari = 0;
			int numer_krevatesh = Convert.ToInt32(ds.Tables[0].Rows[0][6]);
			bool b = false;
			int id_kategoria = Convert.ToInt32(ds.Tables[0].Rows[0][8]);
			double nr_oresh_double, ore;
			string dite = "";
			double pagesa = 0;
			TimeSpan ts;
			string koment = "";
			int nr_ditesh;
			for(int i = 1; i < nr; i++)
			{
				datahyrje1 = Convert.ToDateTime(ds.Tables[0].Rows[i][2]);
				datadalje1 = Convert.ToDateTime(ds.Tables[0].Rows[i][3]);
				bool shto = true;
				if ((datahyrje1 < maxdata)&&(i == nr - 1))
				{
					cmimi = Convert.ToInt32(ds.Tables[0].Rows[index1][7]);
					if (datadalje1 > maxdata)
					{
						maxdata = datadalje1;
					}
					if (id_kategoria == 31)
					{
						ts = maxdata.Subtract(Convert.ToDateTime(ds.Tables[0].Rows[index1][2]));
						ore = Math.Round(ts.TotalHours, 1);
						if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[index1][4])) > 0)
						{
							pagesa = pagesa + ore * cmimi;
							dite = ore.ToString() + " ore";	
							kapari += Convert.ToInt32(ds.Tables[0].Rows[index1][4]);
							kapariStr += ds.Tables[0].Rows[index1][4].ToString() + Environment.NewLine;
						}
						else
							shto = false;
					}
					else
					{
						ts = maxdata.Date.Subtract(Convert.ToDateTime(ds.Tables[0].Rows[index1][2]).Date);
						nr_ditesh = Convert.ToInt32(ts.TotalDays);
						ore = nr_ditesh;
						if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[index1][4])) > 0)
						{
							pagesa = pagesa +  ore * cmimi;
							dite = nr_ditesh + " dite";
							kapari += Convert.ToInt32(ds.Tables[0].Rows[index1][4]);
							kapariStr += ds.Tables[0].Rows[index1][4].ToString() + Environment.NewLine;
						}
						else
							shto = false;
					}
					if (shto)
						//koment = koment + cmimi + "x" + dite + "+";
						koment = koment + cmimi + "x" + dite + Environment.NewLine;
					datahyrje = datahyrje1;
					datadalje = datadalje1;
					maxdata = Convert.ToDateTime(ds.Tables[0].Rows[i][3]);
					index1 = i;
				}
				else
									if ((i == nr - 1)&&(datahyrje1 >= maxdata))
				{
					cmimi = Convert.ToInt32(ds.Tables[0].Rows[i-1][7]);
					if (id_kategoria == 31)
					{
						ts = Convert.ToDateTime(ds.Tables[0].Rows[i - 1][3]).Subtract(Convert.ToDateTime(ds.Tables[0].Rows[i - 1][2]));
						ore = Math.Round(ts.TotalHours, 1);
						if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[i - 1][4])) > 0)
						{
							pagesa = pagesa + ore * cmimi;
							dite = ore.ToString() + " ore";	
							kapari += Convert.ToInt32(ds.Tables[0].Rows[i - 1][4]);
							kapariStr += ds.Tables[0].Rows[i - 1][4].ToString() + Environment.NewLine;
						}
						else
							shto = false;
					}
					else
					{
						ts = Convert.ToDateTime(ds.Tables[0].Rows[i - 1][3]).Date.Subtract(Convert.ToDateTime(ds.Tables[0].Rows[i - 1][2]).Date);
						nr_ditesh = Convert.ToInt32(ts.TotalDays);
						ore = nr_ditesh;
						if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[i - 1][4])) > 0)
						{
							pagesa = pagesa +  ore * cmimi;
							dite = nr_ditesh + " dite";
							kapari += Convert.ToInt32(ds.Tables[0].Rows[i - 1][4]);
							kapariStr += ds.Tables[0].Rows[i - 1][4].ToString() + Environment.NewLine;
						}
						else
							shto = false;
					}
					if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[i - 1][4])) > 0)
						//koment = koment + cmimi + "x" + dite + "+";
						koment = koment + cmimi + "x" + dite + Environment.NewLine;
					cmimi = Convert.ToInt32(ds.Tables[0].Rows[i][7]);
					if (id_kategoria == 31)
					{
						ts = datadalje1.Subtract(datahyrje1);
						ore = Math.Round(ts.TotalHours, 1);
						if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[i][4])) > 0)
						{
							pagesa = pagesa + ore * cmimi;
							dite = ore.ToString() + " ore";
							kapari += Convert.ToInt32(ds.Tables[0].Rows[i][4]);
							kapariStr += ds.Tables[0].Rows[i][4].ToString() + Environment.NewLine;
						}
						else
							shto = false;
					}
					else
					{
						ts = datadalje1.Date.Subtract(datahyrje1.Date);
						nr_ditesh = Convert.ToInt32(ts.TotalDays);
						ore = nr_ditesh;
						if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[i][4])) > 0)
						{
							pagesa = pagesa +  ore * cmimi;
							dite = nr_ditesh + " dite";
							kapari += Convert.ToInt32(ds.Tables[0].Rows[i][4]);
							kapariStr += ds.Tables[0].Rows[i][4].ToString() + Environment.NewLine;
						}
						else
							shto = false;
					}
					if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[i][4])) > 0)
						//koment = koment + cmimi + "x" + dite + "+";
						koment = koment + cmimi + "x" + dite + Environment.NewLine;
					else
						shto = false;
				}
				else if (i == nr - 1)
				{
					cmimi = Convert.ToInt32(ds.Tables[0].Rows[i][7]);
					if (id_kategoria == 31)
					{
						ts = datadalje1.Subtract(datahyrje1);
						ore = Math.Round(ts.TotalHours, 1);
						if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[i][4])) > 0)
						{
							pagesa = pagesa + ore * cmimi;
							dite = ore.ToString() + " ore";	
							kapari += Convert.ToInt32(ds.Tables[0].Rows[i][4]);
							kapariStr += ds.Tables[0].Rows[i][4].ToString() + Environment.NewLine;
						}
						else
							shto = false;
					}
					else
					{
						ts = datadalje1.Date.Subtract(datahyrje1.Date);
						nr_ditesh = Convert.ToInt32(ts.TotalDays);
						ore = nr_ditesh;
						if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[i][4])) > 0)
						{
							pagesa = pagesa +  ore * cmimi;
							dite = nr_ditesh + " dite";
							kapari += Convert.ToInt32(ds.Tables[0].Rows[i][4]);
							kapariStr += ds.Tables[0].Rows[i][4].ToString() + Environment.NewLine;
						}
						else
							shto = false;
					}
					if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[i][4])) > 0)
						//koment = koment + cmimi + "x" + dite + "+";
						koment = koment + cmimi + "x" + dite + Environment.NewLine;
				}
				else
					if (datahyrje1 < maxdata)
				{
					index2 = i;
					if (datadalje1 > maxdata)
					{
						maxdata = datadalje1;
					}

					datahyrje = datahyrje1;
					datadalje = datadalje1;
				}
				else
				{
					cmimi = Convert.ToInt32(ds.Tables[0].Rows[index1][7]);
					if (id_kategoria == 31)
					{
						ts = maxdata.Subtract(Convert.ToDateTime(ds.Tables[0].Rows[index1][2]));
						ore = Math.Round(ts.TotalHours, 1);
						if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[index1][4])) > 0)
						{
							pagesa = pagesa + ore * cmimi;
							dite = ore.ToString() + " ore";	
							kapari += Convert.ToInt32(ds.Tables[0].Rows[index1][4]);
							kapariStr += ds.Tables[0].Rows[index1][4].ToString() + Environment.NewLine;
						}
						else
							shto = false;
					}
					else
					{
						ts = maxdata.Date.Subtract(Convert.ToDateTime(ds.Tables[0].Rows[index1][2]).Date);
						nr_ditesh = Convert.ToInt32(ts.TotalDays);
						ore = nr_ditesh;
						if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[index1][4])) > 0)
						{
							pagesa = pagesa +  ore * cmimi;
							dite = nr_ditesh + " dite";
							kapari += Convert.ToInt32(ds.Tables[0].Rows[index1][4]);
							kapariStr += ds.Tables[0].Rows[index1][4].ToString() + Environment.NewLine;
						}
						else
							shto = false;
					}
					if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[index1][4])) > 0)
						//koment = koment  + cmimi + "x" + dite + "+";
						koment = koment + cmimi + "x" + dite + Environment.NewLine;
					datahyrje = datahyrje1;
					datadalje = datadalje1;
					maxdata = Convert.ToDateTime(ds.Tables[0].Rows[i][3]);
					index1 = i;
				}
			}
			if (nr == 1)
			{
				bool shto = true;
				cmimi = Convert.ToInt32(ds.Tables[0].Rows[0][7]);
				datahyrje = Convert.ToDateTime(ds.Tables[0].Rows[0][2]);
				datadalje = Convert.ToDateTime(ds.Tables[0].Rows[0][3]);
				if (id_kategoria == 31)
				{
					ts = datadalje.Subtract(datahyrje);
					ore = Math.Round(ts.TotalHours, 1);
					if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[0][4])) > 0)
					{
						pagesa = pagesa + ore * cmimi;
						dite = ore.ToString() + " ore";
						kapari += Convert.ToInt32(ds.Tables[0].Rows[0][4]);
						kapariStr += ds.Tables[0].Rows[0][4].ToString() + Environment.NewLine;
					}
					else
						shto = false;
				}
				else
				{
					ts = datadalje.Date.Subtract(datahyrje.Date);
					nr_ditesh = Convert.ToInt32(ts.TotalDays);
					ore = nr_ditesh;
					if ((ore * cmimi - Convert.ToInt32(ds.Tables[0].Rows[0][4])) > 0)
					{
						pagesa = pagesa +  ore * cmimi;
						dite = nr_ditesh + " dite";
						kapari += Convert.ToInt32(ds.Tables[0].Rows[0][4]);
						kapariStr += ds.Tables[0].Rows[0][4].ToString() + Environment.NewLine;
					}
					else
						shto = false;
				}
				if (shto)
					koment = cmimi + "x" + dite; 
			}
			else
			{
			}
//			int l = koment.Length;
//			l--;
//			if (koment.Trim() != "")
//			{
//				if (koment.Substring(l, 1) == "+")
//				{
//					koment = koment.Substring(0, l);
//				}
//			}
			DataRow new_row= ds_dhoma.Tables[0].NewRow();
			new_row[0] = dhoma;
			new_row[1] = Convert.ToInt32(pagesa);
			new_row[2] = kapari;
			new_row[3] = Convert.ToInt32(pagesa) - kapari;
			new_row[4] = koment;
			new_row["KAPARI_STR"] = kapariStr;
			return new_row;
		}

		public DataSet DhomaPashlyera()
		{
			DataSet ds = this.ShfaqDhomatEPashlyera();
			string emri_dhoma = "";
			if (ds.Tables[0].Rows.Count > 0)
				emri_dhoma = ds.Tables[0].Rows[0][5].ToString();
			int nr = ds.Tables[0].Rows.Count;
			int i = 0;
			DataSet ds_dhoma = new DataSet();
			ds_dhoma.Tables.Add();
			ds_dhoma.Tables[0].Columns.Add("DHOMA",typeof(String));
			ds_dhoma.Tables[0].Columns.Add("PAGESA",typeof(Int32));
			ds_dhoma.Tables[0].Columns.Add("KAPARI",typeof(Int32));
			ds_dhoma.Tables[0].Columns.Add("DIFERENCA",typeof(Int32));
			ds_dhoma.Tables[0].Columns.Add("KOMENT",typeof(String));
			ds_dhoma.Tables[0].Columns.Add("KAPARI_STR",typeof(String));
			DataRow dhoma_row;
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DataRow new_row = ds_dhoma.Tables[0].NewRow();
				if ((dr[5].ToString() == emri_dhoma) && (i == nr - 1))
				{
					
				}
				else if (dr[5].ToString() == emri_dhoma)
				{
					
				}
				else if ( i == nr - 1)
				{
					dhoma_row = this.PagesaPerDhomen(emri_dhoma, ds);
					for (int j = 0 ; j < 6; j++ )
						new_row[j] = dhoma_row [j];
					ds_dhoma.Tables[0].Rows.Add(new_row);
				}
				else
				{
					dhoma_row = this.PagesaPerDhomen(emri_dhoma, ds);
					for (int j = 0 ; j < 6; j++ )
						new_row[j] = dhoma_row [j];
					ds_dhoma.Tables[0].Rows.Add(new_row);
					emri_dhoma = ds.Tables[0].Rows[i][5].ToString();
				}
				i++;
			}
			ds_dhoma.AcceptChanges();
			foreach(DataRow dr in ds_dhoma.Tables[0].Rows)
			{
				if (Convert.ToInt32(dr["DIFERENCA"]) == 0)
				{
					dr.Delete();
				}
			}
			ds_dhoma.AcceptChanges();
			int shuma = 0;
			foreach(DataRow dr in ds_dhoma.Tables[0].Rows)
			{
				shuma = shuma + Convert.ToInt32(dr["DIFERENCA"]);
			}
			DataRow shuma_row = ds_dhoma.Tables[0].NewRow();
			shuma_row["DHOMA"] = "SHUMA";
			shuma_row["DIFERENCA"] = shuma;
			ds_dhoma.Tables[0].Rows.Add(shuma_row);
			ds_dhoma.AcceptChanges();
			return ds_dhoma;
		}

		public DataSet KlientetEPashlyerPerDhomen(string dhoma)
		{
			DataSet ds = null;
			DbController db = new DbController();
			string var = "dbKlientetEPashlyerPerDhomen";//klientet jane te renditur sipa dates se hyrjes
			ds = db.Read(var, dhoma);
			DateTime dtFillimiPrev = Convert.ToDateTime(ds.Tables[0].Rows[0]["DATA_HYRJE"]);
			DateTime dtMbarimiPrev = Convert.ToDateTime(ds.Tables[0].Rows[0]["DATA_DALJE"]);
//			DateTime dtMin = DateTime.Now.AddYears(50);
			int indexFillim = 0;
			int indexFund = 0;
			DateTime dtMin = dtFillimiPrev;
			DateTime dtMax = dtMbarimiPrev;
			int kapari = 0;
			int cmimi = Convert.ToInt32(ds.Tables[0].Rows[0]["CMIMI"]);
			int k = 0;
			int idKategoria = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_KATEGORIA"]);
			DataSet dsFshi = new DataSet();
			dsFshi.Tables.Add();
			dsFshi.Tables[0].Columns.Add("NR", typeof(Int32));
			DataRow newR;
			dsFshi.AcceptChanges();
			int pagesa = 0;
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dtFillimi = Convert.ToDateTime(dr["DATA_HYRJE"]);
				DateTime dtMbarimi = Convert.ToDateTime(dr["DATA_DALJE"]);
				if (dtFillimi <= dtMbarimiPrev)//vazhdon e njejta hyrje
				{  
					kapari += Convert.ToInt32(dr["KAPARI"]);
					if (dtMbarimi > dtMbarimiPrev)
						dtMax = dtMbarimi;
					else
						dtMax = dtMbarimiPrev;
					dtFillimiPrev = dtFillimi;
					dtMbarimiPrev = dtMbarimi;
					if (k == ds.Tables[0].Rows.Count - 1)//nqs jemi ne fund te ds
					{
						indexFund = k;
						pagesa = this.GjejPagesen(idKategoria, cmimi, dtMin, dtMax);
						if (pagesa == kapari)
						{
							for(int m = indexFillim; m <= indexFund; m++)
							{
								newR = dsFshi.Tables[0].NewRow();
								newR["NR"] = m;
								dsFshi.Tables[0].Rows.Add(newR);
							}
						}
					}
				}
				else//hyrja ka mbaruar;
				{
					indexFund = k - 1;
					pagesa = this.GjejPagesen(idKategoria, cmimi, dtMin, dtMax);
					if (pagesa == kapari)
					{
						for(int m = indexFillim; m <= indexFund; m++)
						{
							newR = dsFshi.Tables[0].NewRow();
							newR["NR"] = m;
							dsFshi.Tables[0].Rows.Add(newR);
						}
					}
					//hyrja vijuese
					indexFillim = k;
					kapari = Convert.ToInt32(dr["KAPARI"]);
					dtFillimiPrev = dtFillimi;
					dtMbarimiPrev = dtMbarimi;
					cmimi = Convert.ToInt32(dr["CMIMI"]);
					dtMin = dtFillimiPrev;
					dtMax = dtMbarimi;
					if (k == ds.Tables[0].Rows.Count - 1)
					{
						indexFund = k;
						pagesa = this.GjejPagesen(idKategoria, cmimi, dtFillimiPrev, dtMbarimiPrev);
						if (pagesa == kapari)
						{
							for(int m = indexFillim; m <= indexFund; m++)
							{
								newR = dsFshi.Tables[0].NewRow();
								newR["NR"] = m;
								dsFshi.Tables[0].Rows.Add(newR);
							}
						}
					}
				}
				k++;
			}
			dsFshi.AcceptChanges();
			int t = 0;
			foreach(DataRow dr in dsFshi.Tables[0].Rows)
			{
				ds.Tables[0].Rows[Convert.ToInt32(dr["NR"]) - t].Delete();
				t++;
			}
			ds.AcceptChanges();
			int nr = ds.Tables[0].Rows.Count;
			ds.Tables.Add();
			ds.Tables[1].Columns.Add("KRITERI", typeof(String));
			for (int i = 1; i <= nr ; i++)
			{
				string s = "KLIENTI" + i;
				ds.Tables[1].Columns.Add(s, typeof(String));
			}
			DataRow new_row;
			for(int i = 0; i < 4; i++)
			{
				new_row = ds.Tables[1].NewRow();
				ds.Tables[1].Rows.Add(new_row);
			}
			ds.AcceptChanges();
			ds.Tables[1].Rows[0][0] = "Emri";
			ds.Tables[1].Rows[1][0] = "Mbiemri";
			ds.Tables[1].Rows[2][0] = "Date Hyrje";
			ds.Tables[1].Rows[3][0] = "Date Dalje";
			int j = 1;
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				ds.Tables[1].Rows[0][j] = dr[0].ToString();
				ds.Tables[1].Rows[1][j] = dr[1].ToString();
				ds.Tables[1].Rows[2][j] = this.konverto(Convert.ToDateTime(dr[2]));
				ds.Tables[1].Rows[3][j] = this.konverto(Convert.ToDateTime(dr[3]));
				j++;
			}
			ds.AcceptChanges();
			return ds;
		}

		public DataSet ShfaqDhomatDitore(int neVazhdim)
		{
			//shtohet datatable[0] me te dhenat fillestare
			string var = "dbShfaqDhomatDitore"; 
			DbController db = new DbController();
			DataSet ds = db.Read(var);
			//shtohet nje datatable[1] per header
			ds.Tables.Add();
			ds.AcceptChanges();
			int id_dhoma = 0;

			//gjendet data e fundit per te cilen ka nje dhome te rezervuar
			var = "dbDataRezervimiFundit";
			DataSet dsRevFundit = db.Read(var);
			//gjendet data e fundit per te cilen parashikohet te kete klient ne hotel(dhome te zene)
			var = "dbDataDaljeFundit";
			DataSet dsDaljeFundit = db.Read(var);
			DateTime data_rev_fundit;
			DateTime data_dal_fundit;
			if (Convert.IsDBNull(dsRevFundit.Tables[0].Rows[0][0]))
			{
				data_rev_fundit = System.DateTime.Today;
			}
			else
			{
				data_rev_fundit = Convert.ToDateTime(dsRevFundit.Tables[0].Rows[0][0]);
			}
			//nqs rezervimi i fundit i vlefshem eshte para sot
			//si date e fundit merret sot
			if (data_rev_fundit.Date < DateTime.Today)
				data_rev_fundit = System.DateTime.Today;
			if (Convert.IsDBNull(dsDaljeFundit.Tables[0].Rows[0][0]))
			{
				data_dal_fundit = System.DateTime.Today;
			}
			else
			{
				data_dal_fundit = Convert.ToDateTime(dsDaljeFundit.Tables[0].Rows[0][0]);
			}
			//nqs hyrja e fundit e vlefshme eshte para sot
			//si date e fundit merret sot
			if (data_dal_fundit.Date < DateTime.Today)
				data_dal_fundit = System.DateTime.Today;
			//gjendet maximumi i dy datave
			DateTime data_fundit;
			if (data_rev_fundit < data_dal_fundit)
			{
				data_fundit = data_dal_fundit;
			}
			else
			{
				data_fundit = data_rev_fundit;
			}
			DateTime data_pare;
			DateTime data_sot = System.DateTime.Today;
			if (neVazhdim == 1)
			{
				//gjejme gjithe rezervimet e vlefshme ne intervalin e te cileve 
				//ben pjese edhe e sotmja mundte jete edhe null
				var = "dbDataMinRezervimetEVlefshmePerSot";
				DataSet dsPareRezervim = db.Read(var);
				DateTime data_rez_pare;
				if (Convert.IsDBNull(dsPareRezervim.Tables[0].Rows[0][0]))
				{
					data_rez_pare = DateTime.Today;
				}
				else
				{
					data_rez_pare = Convert.ToDateTime(dsPareRezervim.Tables[0].Rows[0][0]);
				}
				var = "dbDataMinHyrjetEVlefshmePerSot";
				DataSet dsPareHyrjet = db.Read(var);
				DateTime data_hyrje_pare;
				if (Convert.IsDBNull(dsPareHyrjet.Tables[0].Rows[0][0]))
				{
					data_hyrje_pare = DateTime.Now;
				}
				else
				{
					data_hyrje_pare = Convert.ToDateTime(dsPareHyrjet.Tables[0].Rows[0][0]);
				}
				if (data_rez_pare > data_hyrje_pare)
				{
					data_pare = data_hyrje_pare;
				}
				else
				{
					data_pare = data_rez_pare;
				}
			}
			else
				data_pare = data_sot;
			//			TimeSpan ts = data_fundit.Date.Subtract(data_sot.Date);
			TimeSpan ts = data_fundit.Date.Subtract(data_pare.Date);
			int nr_ditesh = Convert.ToInt32(ts.TotalDays);
			nr_ditesh = nr_ditesh + 1;
			string dita;
			//shtohen kolonat per cdo dite
			string a;
			for(int i = 0; i < nr_ditesh; i++)
			{
				//shtohen kolonat per ditet ne te dy datatable te datasetit
				//				dita = data_sot.AddDays(i).ToShortDateString();
				dita = data_pare.AddDays(i).ToShortDateString();
				ds.Tables[0].Columns.Add(ConvertDate(dita), typeof(string));
				ds.Tables[1].Columns.Add(ConvertDate(dita), typeof(string));
			}
			DataRow header_row = ds.Tables[1].NewRow(); 
			for(int i = 0; i < nr_ditesh; i++)
			{
				//shtohen vlerat e datave ne datatable[1]
				//				DateTime date_tmp = data_sot.AddDays(i);
				DateTime date_tmp = data_pare.AddDays(i);
				dita = date_tmp.ToShortDateString();
				string day = date_tmp.DayOfWeek.ToString();
				//				header_row[i] = konverto_header(data_sot.AddDays(i)) + System.Environment.NewLine + this.gjej_dite(day);
				header_row[i] = konverto_header(data_pare.AddDays(i)) + System.Environment.NewLine + this.gjej_dite(day);
			}
			ds.Tables[1].Rows.Add(header_row);
			ds.AcceptChanges();
			int numer_klientesh = 0;
			int numer_krevatesh = 0;
			DateTime data;
			var = "dbShfaqTeGjitheRezervimet";
			DataSet dsRezervime = db.Read(var);
			var = "dbShfaqHyrjetPasSot";
			DataSet dsHyrje = db.Read(var);
			if (neVazhdim == 1)
			{
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					if (Convert.ToInt32(dr[0]) == 0)
					{
					}
					else
					{
						id_dhoma = Convert.ToInt32(dr[0]);
						numer_krevatesh = Convert.ToInt32(dr[2]);
						for(int i = 0; i < nr_ditesh; i++)
						{
							//data = data_sot.AddDays(i);
							data = data_pare.Date.AddDays(i);
							numer_klientesh = this.NumerKlientesh(id_dhoma, data, dsHyrje);
							if (data.Date > data_sot.Date)
							{
								if (this.Rezervuar(id_dhoma, data, dsRezervime) == true)
								{
									dr[i + 3] = "Rezervuar";
								}
								else if (numer_klientesh == 0)
								{
									dr[i + 3] = "E lire";
								}
								else if (numer_klientesh == numer_krevatesh)
								{
									dr[i + 3] = "E zene";
								}
								else if (numer_klientesh < numer_krevatesh)
								{
									dr[i + 3] = "PJL " + numer_klientesh + "/" + numer_krevatesh;
								}
							}
							else if (data.Date == data_sot.Date)
							{
								if (this.Rezervuar(id_dhoma, data, dsRezervime) == true)
								{
									dr[i + 3] = "SRezervuar";
								}
								else if (numer_klientesh == 0)
								{
									dr[i + 3] = "SE lire";
								}
								else if (numer_klientesh == numer_krevatesh)
								{
									dr[i + 3] = "SE zene";
								}
								else if (numer_klientesh < numer_krevatesh)
								{
									dr[i + 3] = "SPJL " + numer_klientesh + "/" + numer_krevatesh;
								}
							}
							else
							{
								if (this.Rezervuar(id_dhoma, data, dsRezervime) == true)
								{
									dr[i + 3] = "DRezervuar";
								}
								else if (numer_klientesh == 0)
								{
									dr[i + 3] = "DE lire";
								}
								else if (numer_klientesh == numer_krevatesh)
								{
									dr[i + 3] = "DE zene";
								}
								else if (numer_klientesh < numer_krevatesh)
								{
									dr[i + 3] = "DPJL " + numer_klientesh + "/" + numer_krevatesh;
								}
							}
						}
						ds.AcceptChanges();
					}
				}
			}
			else
			{
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					if (Convert.ToInt32(dr[0]) == 0)
					{
					
					}
					else
					{
						id_dhoma = Convert.ToInt32(dr[0]);
						numer_krevatesh = Convert.ToInt32(dr[2]);
						for(int i = 0; i < nr_ditesh; i++)
						{
							//data = data_sot.AddDays(i);
							data = data_pare.Date.AddDays(i);
							numer_klientesh = this.NumerKlientesh(id_dhoma, data, dsHyrje);
							if (this.Rezervuar(id_dhoma, data, dsRezervime) == true)
							{
								dr[i + 3] = "Rezervuar";
							}
							else if (numer_klientesh == 0)
							{
								dr[i + 3] = "E lire";
							}
							else if (numer_klientesh == numer_krevatesh)
							{
								dr[i + 3] = "E zene";
							}
							else if (numer_klientesh < numer_krevatesh)
							{
								dr[i + 3] = "PJL " + numer_klientesh + "/" + numer_krevatesh;
							}
						}
						ds.AcceptChanges();
					}
				}
			}
			return ds;
		}

		public DataSet ShfaqRezDhomaMeOre()
		{
			string var = "dbShfaqRezervimetVlefshmePerDhomatMeOre";
			DbController db = new DbController();
			DataSet ds = db.Read(var);
			ds.Tables[0].Columns.Add("DATA_FILLIMI_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_MBARIMI_STR", typeof(String));
			ds.AcceptChanges();
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				dr[4] = this.konverto(Convert.ToDateTime(dr[2]));
				dr[5] = this.konverto(Convert.ToDateTime(dr[3]));
			}
			ds.AcceptChanges();
			return ds;
		}

		public DataSet ShfaqHyrjetDhomaMeOre()
		{
			string var = "dbShfaqHyrjetPasSotDhomatMeOre";
			DbController db = new DbController();
			DataSet ds = db.Read(var);
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR", typeof(String));
			ds.AcceptChanges();
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				dr[4] = this.konverto(Convert.ToDateTime(dr[2]));
				dr[5] = this.konverto(Convert.ToDateTime(dr[3]));
			}
			ds.AcceptChanges();
			return ds;
		}

		public DataSet ShfaqKlientetPerDhomenPerDatenEdhene(int idDhoma, DateTime dateDorezimi)
		{
			
			string var = "dbShfaqKlientetPerDhomenEdhenePerDatenEdhene";
			DbController db = new DbController();
			DataSet ds = db.Read(var, dateDorezimi, idDhoma );
			return ds;

		}

		public DataSet ShfaqKlientetPerDhomenPerDatenEdhenePerGrup(int idDhoma,int id_grupi, DateTime dateDorezimi)
		{
			
			string var = "dbShfaqKlientetPerDhomenEdhenePerDatenEdhenePerGrup";
			DbController db = new DbController();
			DataSet ds = db.Read(var, dateDorezimi, idDhoma , id_grupi);
			return ds;

		}
		public DataSet ShfaqDhomaPashlyeraGrupi()
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqDhomaPashlyeraGrupi");
			ds = this.OrganizoDataSet(ds);
			DataSet[] vektorDs = this.NxirrPagesaPerSecilenHyrje(ds);
			if (vektorDs[0] == null)
			{
				DataSet dsTmp = new DataSet();
				dsTmp.Tables.Add();
				dsTmp.Tables[0].Columns.Add("ID_HYRJA", typeof(Int32));
				dsTmp.Tables[0].Columns.Add("GRUPI", typeof(String));
				dsTmp.Tables[0].Columns.Add("AGJENSIA", typeof(String));
				dsTmp.Tables[0].Columns.Add("DHOMA_EMRI", typeof(String));
				dsTmp.Tables[0].Columns.Add("PAGESA", typeof(Int32));
				dsTmp.Tables[0].Columns.Add("KAPARI", typeof(Int32));
				dsTmp.Tables[0].Columns.Add("DIFERENCA", typeof(Int32));
				dsTmp.Tables[0].Columns.Add("KOMENT", typeof(String));
				dsTmp.Tables[0].Columns.Add("MINDATA", typeof(DateTime));
				dsTmp.Tables[0].Columns.Add("MAXDATA", typeof(DateTime));
				DataRow endRow = dsTmp.Tables[0].NewRow();
				endRow["GRUPI"] = "SHUMA";
				endRow["DIFERENCA"] = 0;
				dsTmp.Tables[0].Rows.Add(endRow);
				dsTmp.AcceptChanges();
				return dsTmp;
			}
			DataSet dsHyrje = this.NdertoDataSetPagesaPergjithshme(ds, vektorDs);
			return dsHyrje;
		}
		private DataSet[] NxirrPagesaPerSecilenHyrje(DataSet ds)
		{
			int nrKliente = ds.Tables[0].Rows.Count;
			int nrHyrje;
			DataSet[] vektorDs;
			if (nrKliente != 0)
			{
				nrHyrje = Convert.ToInt32(ds.Tables[0].Rows[nrKliente - 1]["ID_HYRJA"]) + 1;
				vektorDs = new DataSet[nrHyrje];
			}
			else
			{
				vektorDs = new DataSet[1];
				return vektorDs;
			}
			for(int i = 0; i < nrHyrje; i++)
			{
				int indexFillim = -1;
				int indexFund = -1;
				int indexLeviz = 0;
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					int idHyrje = Convert.ToInt32(dr["ID_HYRJA"]);
					if (i == idHyrje)
					{
						if (indexFillim == -1)
							indexFillim = indexLeviz;
					}
					else
					{
						if (indexFillim != -1)
						{
							indexFund = indexLeviz - 1;
							break;
						}
					}
					indexLeviz++;
				}
				if (indexFund == -1)
					indexFund = indexLeviz - 1;
				int[] vektorDhomat = new int[indexFund - indexFillim + 1];
				string[] vektorEmrat = new string[indexFund - indexFillim + 1];
				int j = 0;
				for(indexLeviz = indexFillim; indexLeviz <= indexFund; indexLeviz++)
				{
					vektorDhomat[j] = Convert.ToInt32(ds.Tables[0].Rows[indexLeviz]["ID_DHOMA"]);
					vektorEmrat[j] = ds.Tables[0].Rows[indexLeviz]["DHOMA_EMRI"].ToString();
					j++;
				}
				DataSet dsDhomat = new DataSet();
				dsDhomat.Tables.Add();
				dsDhomat.Tables[0].Columns.Add("ID_HYRJA", typeof(Int32));
				dsDhomat.Tables[0].Columns.Add("ID_DHOMA", typeof(Int32));
				dsDhomat.Tables[0].Columns.Add("DHOMA_EMRI", typeof(String));
				dsDhomat.AcceptChanges();
				j = 0;
				for(j = 0; j < vektorDhomat.Length; j++)
				{
					bool ugjet = false;
					foreach(DataRow r in dsDhomat.Tables[0].Rows)
					{
						if (Convert.ToInt32(vektorDhomat[j]) == Convert.ToInt32(r["ID_DHOMA"]))
						{
							ugjet = true;
							break;
						}
					}
					if (!ugjet)
					{
						DataRow newR = dsDhomat.Tables[0].NewRow();
						newR["ID_HYRJA"] = i;
						newR["ID_DHOMA"] = vektorDhomat[j];
						newR["DHOMA_EMRI"] = vektorEmrat[j];
						dsDhomat.Tables[0].Rows.Add(newR);
					}
				}
				dsDhomat.AcceptChanges();
				dsDhomat.Tables[0].Columns.Add("KOMENT", typeof(String));
				dsDhomat.Tables[0].Columns.Add("VLERA",typeof(Double));
				foreach(DataRow r in dsDhomat.Tables[0].Rows)
				{
					DateTime dtMin = DateTime.Now.AddYears(50);
					DateTime dtMax = DateTime.Now.AddYears(-50);
					int idKategoria = 0;
					for(indexLeviz = indexFillim; indexLeviz <= indexFund; indexLeviz++)
					{
						DataRow baseRow = ds.Tables[0].Rows[indexLeviz];
						if (Convert.ToInt32(r["ID_DHOMA"]) == Convert.ToInt32(baseRow["ID_DHOMA"]))
						{
							idKategoria = Convert.ToInt32(baseRow["ID_KATEGORIA"]);
							if (Convert.ToDateTime(baseRow["DATA_HYRJE"]) < dtMin)
								dtMin = Convert.ToDateTime(baseRow["DATA_HYRJE"]);
							if (Convert.ToDateTime(baseRow["DATA_DALJE"]) > dtMax)
								dtMax = Convert.ToDateTime(baseRow["DATA_DALJE"]);
						}
					}
					TimeSpan ts;
					DbController db = new DbController();
					DataSet dsCmimi = db.Read("dbShfaqCmimiDhoma",dtMin, Convert.ToInt32(r["ID_DHOMA"]));
					int cmimi = Convert.ToInt32(dsCmimi.Tables[0].Rows[0]["CMIMI"]);
					double pagesa = 0;
					string koment = "";
					if (idKategoria == 31)
					{
						ts = dtMax.Subtract(dtMin);
						double ore = ts.TotalHours;
						pagesa = Math.Round(Math.Round(ore, 1) * cmimi, 1);
						koment = cmimi + "x" + Convert.ToString(Math.Round(ore, 1)) + " ore";
					}
					else
					{
						ts = dtMax.Date.Subtract(dtMin.Date);
						int dite = Convert.ToInt32(ts.TotalDays);
						pagesa = dite * cmimi;
						koment = cmimi + "x" + dite.ToString() + " dite";
					}
					r["KOMENT"] = koment;
					r["VLERA"] = pagesa;
				}
				vektorDs[i] = dsDhomat;
			}
			return vektorDs;	
		}

		private DataSet NdertoDataSetPagesaPergjithshme(DataSet ds, DataSet[] vektorDs)
		{
			DataSet dsHyrje = new DataSet();
			dsHyrje.Tables.Add();
			dsHyrje.Tables[0].Columns.Add("ID_HYRJA", typeof(Int32));
			dsHyrje.Tables[0].Columns.Add("GRUPI", typeof(String));
			dsHyrje.Tables[0].Columns.Add("AGJENSIA", typeof(String));
			dsHyrje.Tables[0].Columns.Add("KAPARI", typeof(Int32));
			dsHyrje.Tables[0].Columns.Add("MINDATA", typeof(DateTime));
			dsHyrje.Tables[0].Columns.Add("MAXDATA", typeof(DateTime));
			foreach(DataRow dr in ds.Tables["KLIENTI"].Rows)
			{
				DataRow newR = dsHyrje.Tables[0].NewRow();
				newR["GRUPI"] = dr["GRUPI"].ToString();
				newR["AGJENSIA"] = dr["AGJENSIA"].ToString();
				newR["KAPARI"] = Convert.ToInt32(dr["KAPARI"]);
				newR["ID_HYRJA"] = Convert.ToInt32(dr["ID_HYRJA"]);
				newR["MINDATA"] = Convert.ToDateTime(dr["MINDATA"]);
				newR["MAXDATA"] = Convert.ToDateTime(dr["MAXDATA"]);
				dsHyrje.Tables[0].Rows.Add(newR);
			}
			dsHyrje.AcceptChanges();
			int i = 0;
			dsHyrje.Tables[0].Columns.Add("PAGESA", typeof(Double));
			dsHyrje.Tables[0].Columns.Add("DIFERENCA", typeof(Double));
			dsHyrje.Tables[0].Columns.Add("KOMENT", typeof(String));
			dsHyrje.Tables[0].Columns.Add("DHOMA_EMRI", typeof(String));
			foreach(DataRow dr in dsHyrje.Tables[0].Rows)
			{
				double pagesaHyrja = 0;
				double diferenca = 0;
				string koment = "";
				string dhomaEmri = "";
				foreach(DataRow r in vektorDs[i].Tables[0].Rows)
				{
					pagesaHyrja += Convert.ToDouble(r["VLERA"]);
					koment += r["KOMENT"] + Environment.NewLine;
					dhomaEmri += r["DHOMA_EMRI"] + Environment.NewLine;
				}
				int kapari = Convert.ToInt32(dr["KAPARI"]);
				diferenca = Convert.ToDouble(pagesaHyrja - kapari);
				dr["PAGESA"] = Math.Round(pagesaHyrja, 1);
				dr["DIFERENCA"] = Math.Round(diferenca, 1);
				dr["KOMENT"] = koment;
				dr["DHOMA_EMRI"] = dhomaEmri;
				i++;
			}
			dsHyrje.AcceptChanges();
			dsHyrje.Tables.Add();
			dsHyrje.Tables[1].Columns.Add("ID_HYRJA", typeof(Int32));
			dsHyrje.Tables[1].Columns.Add("EMRI", typeof(String));
			dsHyrje.Tables[1].Columns.Add("MBIEMRI", typeof(String));
			dsHyrje.Tables[1].Columns.Add("DATA_HYRJE_STR", typeof(String));
			dsHyrje.Tables[1].Columns.Add("DATA_DALJE_STR", typeof(String));
			dsHyrje.Tables[1].Columns.Add("DHOMA_EMRI", typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DataRow newR = dsHyrje.Tables[1].NewRow();
				newR["ID_HYRJA"] = Convert.ToInt32(dr["ID_HYRJA"]);
				newR["EMRI"] = dr["EMRI"].ToString();
				newR["MBIEMRI"] = dr["MBIEMRI"].ToString();
				newR["DATA_HYRJE_STR"] = dr["DATA_HYRJE_STR"].ToString();
				newR["DATA_DALJE_STR"] = dr["DATA_DALJE_STR"].ToString();
				newR["DHOMA_EMRI"] = dr["DHOMA_EMRI"].ToString();
				dsHyrje.Tables[1].Rows.Add(newR);
			}
			dsHyrje.AcceptChanges();
			double totali = 0;
			bool ugjet = false;
			dsHyrje.AcceptChanges();
			DataSet dsFshi = new DataSet();
			dsFshi.Tables.Add();
			dsFshi.Tables[0].Columns.Add("NR", typeof(Int32));
			foreach(DataRow dr in dsHyrje.Tables[0].Rows)
			{
				if (Convert.ToInt32(dr["DIFERENCA"]) == 0)
				{
					ugjet = true;
					int idHyrja = Convert.ToInt32(dr["ID_HYRJA"]);
					dr.Delete();
					int k = 0;
					foreach(DataRow r in dsHyrje.Tables[1].Rows)
					{
						if (idHyrja == Convert.ToInt32(r["ID_HYRJA"]))
						{
							DataRow rFshi = dsFshi.Tables[0].NewRow();
							rFshi["NR"] = k;
							dsFshi.Tables[0].Rows.Add(rFshi);
						}
						k++;
					}
					dsFshi.AcceptChanges();
				}
				else
					totali += Convert.ToDouble(dr["DIFERENCA"]);
			}
			if (ugjet)
			{
				foreach(DataRow dr in dsFshi.Tables[0].Rows)
				{
					dsHyrje.Tables[1].Rows[Convert.ToInt32(dr["NR"])].Delete();
				}
			}
			dsHyrje.AcceptChanges();
			DataRow newRow = dsHyrje.Tables[0].NewRow();
			newRow["ID_HYRJA"] = -1;
			newRow["GRUPI"] = "SHUMA";
			newRow["DIFERENCA"] = Math.Round(totali, 1);
			dsHyrje.Tables[0].Rows.Add(newRow);
			dsHyrje.AcceptChanges();
			return dsHyrje;
		}
		private DataSet OrganizoDataSet(DataSet ds)
		{
			if (ds.Tables[0].Rows.Count == 0)
			{
				return ds;
			}
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr["DATA_HYRJE"]);
				DateTime dataDalje = Convert.ToDateTime(dr["DATA_DALJE"]);
				dr["DATA_HYRJE_STR"] = this.konverto(dataHyrje);
				dr["DATA_DALJE_STR"] = this.konverto(dataDalje);
			}
			ds.AcceptChanges();
			ds.EnforceConstraints = false;
			DataTable dt1 = ds.Tables[0].Clone();
			dt1.Rows.Clear();
			dt1.TableName = "KLIENTI";
			ds.Tables.Add(dt1);
			ds.Tables["KLIENTI"].Columns.Add("ID_DHOMA_STR", typeof(String));
			ds.Tables["KLIENTI"].Columns.Add("ID_KLIENTI_STR", typeof(String));
			ds.Tables["KLIENTI"].Columns.Add("PERGJEGJES", typeof(Int32));
			ds.Tables["KLIENTI"].Columns.Add("ID_HYRJA", typeof(Int32));
			ds.Tables["KLIENTI"].Columns.Add("MINDATA", typeof(DateTime));
			ds.Tables["KLIENTI"].Columns.Add("MAXDATA", typeof(DateTime));
			ds.Tables["KLIENTI"].Columns.Add("KLIENT_HOTELI_STR", typeof(String));
			ds.Tables[0].Columns.Add("ID_HYRJA", typeof(Int32));
			ds.AcceptChanges();
			DateTime maxDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["DATA_DALJE"]);
			int j = 0;
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				int kapari= 0;
				int pergjegjes = 0;
				DataRow dt1Row = dt1.NewRow();
				DataRow drFirst = ds.Tables[0].Rows[i];
				DataRow drNext = ds.Tables[0].Rows[i];
				if (i < ds.Tables[0].Rows.Count - 1)
				{
					drNext = ds.Tables[0].Rows[i + 1];
				}
				drFirst["ID_HYRJA"] = j;
				// Te dhenat per dhomen
				dt1Row["ID_KLIENTI"] = drFirst["ID_KLIENTI"];
				dt1Row["ID_KLIENTI_STR"]  = drFirst["ID_KLIENTI"].ToString();
				dt1Row["KLIENT_HOTELI"] = drFirst["KLIENT_HOTELI"];
				dt1Row["KLIENT_HOTELI_STR"] = drFirst["KLIENT_HOTELI"].ToString();
				dt1Row["ID_DHOMA"] = drFirst["ID_DHOMA"];
				dt1Row["ID_DHOMA_STR"]  = drFirst["ID_DHOMA"].ToString();
				dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"];
				dt1Row["KAPARI"] = drFirst["KAPARI"];
				kapari = Convert.ToInt32(dt1Row["KAPARI"]);
				bool ugjet = false;
				if (kapari != 0)
					ugjet = true;
				pergjegjes = Convert.ToInt32(dt1Row["ID_KLIENTI"]);
				// Te dhenat per klientet
				dt1Row["EMRI"] = drFirst["EMRI"].ToString() + " " + drFirst["MBIEMRI"];
				dt1Row["MBIEMRI"] = drFirst["MBIEMRI"];
				dt1Row["GRUPI"] = drFirst["GRUPI"];
				dt1Row["ID_GRUPI"] = drFirst["ID_GRUPI"];
				dt1Row["AGJENSIA"] = drFirst["AGJENSIA"];
				dt1Row["DATA_HYRJE_STR"] = drFirst["DATA_HYRJE_STR"];
				dt1Row["DATA_DALJE_STR"] = drFirst["DATA_DALJE_STR"];
				dt1Row["MINDATA"] = drFirst["DATA_HYRJE"];
				dt1Row["MAXDATA"] = drFirst["DATA_DALJE"];
				maxDate = Convert.ToDateTime( drFirst["DATA_DALJE"]);
				DateTime data_max = Convert.ToDateTime( drFirst["DATA_DALJE"]);
				while (maxDate >= Convert.ToDateTime(drNext["DATA_HYRJE"]) && (drFirst["GRUPI"].ToString() == drNext["GRUPI"].ToString()) && (i < ds.Tables[0].Rows.Count - 1))
				{
					drFirst["ID_HYRJA"] = j;
					if (data_max < Convert.ToDateTime(drNext["DATA_DALJE"]))
						data_max = Convert.ToDateTime(drNext["DATA_DALJE"]);
					dt1Row["GRUPI"] = drFirst["GRUPI"].ToString();
					dt1Row["AGJENSIA"] = drFirst["AGJENSIA"].ToString();
					dt1Row["ID_KLIENTI_STR"] += Environment.NewLine + drNext["ID_KLIENTI"].ToString();
					dt1Row["KLIENT_HOTELI"] = drFirst["KLIENT_HOTELI"];
					dt1Row["KLIENT_HOTELI_STR"] += Environment.NewLine + drNext["KLIENT_HOTELI"].ToString();
					dt1Row["ID_DHOMA_STR"] += Environment.NewLine + drNext["ID_DHOMA"].ToString();
					dt1Row["DHOMA_EMRI"] += Environment.NewLine + drNext["DHOMA_EMRI"].ToString();
					dt1Row["EMRI"] += Environment.NewLine + drNext["EMRI"].ToString() + " " + drNext["MBIEMRI"];
					dt1Row["MBIEMRI"] += Environment.NewLine + drNext["MBIEMRI"];
					dt1Row["DATA_HYRJE_STR"] += Environment.NewLine + drNext["DATA_HYRJE_STR"];
					dt1Row["DATA_DALJE_STR"] += Environment.NewLine + drNext["DATA_DALJE_STR"];
					kapari = kapari + Convert.ToInt32(drNext["KAPARI"]);
					if ((!ugjet) && (Convert.ToInt32(drNext["KAPARI"]) != 0))
					{
						pergjegjes = Convert.ToInt32(drNext["ID_KLIENTI"]);
						ugjet = true;
					}
					int max = DateTime.Compare(Convert.ToDateTime(drFirst["DATA_DALJE"]), Convert.ToDateTime(drNext["DATA_DALJE"]));
					if (max > 0)
						maxDate = Convert.ToDateTime(drFirst["DATA_DALJE"]);
					else
						maxDate = Convert.ToDateTime(drNext["DATA_DALJE"]);
					i++;
					if (i < ds.Tables[0].Rows.Count - 1)
					{
						drFirst = ds.Tables[0].Rows[i];
						drFirst["ID_HYRJA"] = j;
						drNext = ds.Tables[0].Rows[i + 1];
					}
					drNext["ID_HYRJA"] = j;
				}
				dt1Row["KAPARI"] = kapari;
				dt1Row["PERGJEGJES"] = pergjegjes;
				dt1Row["MAXDATA"] = data_max;
				dt1.Rows.Add(dt1Row);
				drNext["ID_HYRJA"] = j;
				dt1Row["ID_HYRJA"] = j;	
				j++;
			}
			return ds;
		}

		public int KntGjendjeDhome(int idDhoma)
		{
			#region local variables
			int p = 0;
			DataSet ds = null;
			DataSet ds1 = null;
			#endregion local variables
			DbController db = new DbController();
			ds1 = db.Read("dbNxirrDhomeRezervuar",idDhoma);
			
			if (Convert.ToInt32(ds1.Tables[0].Rows.Count) == 0)
			{
				Klienti klient = new Klienti();
				ds =  klient.ShfaqKlientetNeHotel();
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					if( idDhoma != Convert.ToInt32(dr[18]))
						return p;	
					else
						p = 2;
				}
			}
			else
				p = 1;
			
			return p;
		}
		public DataSet NumerKlienteshPerCdoDate(int idDhoma, int kapaciteti)
		{
			DbController db = new DbController();
			bool ugjet = false;
			DateTime dtMinHyrje, dtMaxHyrje;
			string var = "dbShfaqGjitheHyrjet";
			DataSet dsHyrje = db.Read(var);
			//gjendet data e pare dhe e fundit
			var = "dbDataDaljeFunditAll";
			DataSet dsDaljeFundit = db.Read(var);
			if (Convert.IsDBNull(dsDaljeFundit.Tables[0].Rows[0][0]))
			{
				dtMaxHyrje = System.DateTime.Today;
			}
			else
			{
				dtMaxHyrje = Convert.ToDateTime(dsDaljeFundit.Tables[0].Rows[0][0]);
			}
			var = "dbDataHyrjePare";
			DataSet dsHyrjePare = db.Read(var);
			if (Convert.IsDBNull(dsHyrjePare.Tables[0].Rows[0][0]))
			{
				dtMinHyrje = System.DateTime.Today;
			}
			else
			{
				dtMinHyrje = Convert.ToDateTime(dsHyrjePare.Tables[0].Rows[0][0]);
			}
			TimeSpan ts = dtMaxHyrje.Date.Subtract(dtMinHyrje.Date);
			int nrdite = Convert.ToInt32(ts.TotalDays);
			for (int i = 0; i <= nrdite; i++)
			{
				DateTime d = dtMinHyrje.Date.AddDays(i);
				DataSet dsDhoma = this.NxirrDhome(idDhoma, d);
				int nrKliente = Convert.ToInt32(dsDhoma.Tables[0].Rows[3][1]);
				if (nrKliente > kapaciteti)
				{
					ugjet = true;
					break;
				}
			}
			DataSet ds = new DataSet();
			ds.Tables.Add();
			ds.Tables[0].Columns.Add("UGJET", typeof(Int32));
			DataRow r = ds.Tables[0].NewRow();
			if (ugjet)
				r["UGJET"] = 1;
			else
				r["UGJET"] = 0;
			ds.Tables[0].Rows.Add(r);
			ds.AcceptChanges();
			return ds;
		}
		public DataSet NxirrDhomaPerKategorine(int idKategoria)
		{
			DbController db = new DbController();
			DataSet ds = null;
			ds = db.Read("dbShfaqDhomenPerKategorineEdhene",idKategoria);
			return ds;
		}

		public DataSet ShfaqDhomatPerGrupinEdhene(int idGrupi, DateTime date_dorezimi)
		{
			DbController db = new DbController();
			DataSet ds = null;
			ds = db.Read("dbShfaqDhomatPerGrupinEdhene", date_dorezimi, idGrupi);
			return ds;

		}

		public DataSet ShfaqDetyrimetPerDhomat(int[] idDhomat)
		{   
			DataSet dsDhomat = new DataSet();
			DataTable dtb = new DataTable();
			dtb.Columns.Add(new DataColumn("DHOMA_EMRI", typeof(string)));
			dtb.Columns.Add(new DataColumn("DATA_MARRJE", typeof(string)));
			dtb.Columns.Add(new DataColumn("DATA_DOREZIM", typeof(string)));
			dtb.Columns.Add(new DataColumn("CMIMI", typeof(int)));
			dtb.Columns.Add(new DataColumn("NR_DITESH", typeof(int)));
			dtb.Columns.Add(new DataColumn("VLERA", typeof(int)));
			
			
			dsDhomat.Tables.Add(dtb);
			DbController db = new DbController();
			DataSet ds = null;
            
			int gjatesia = idDhomat.Length;
			int i = 0;
			for(i = 0; i < gjatesia; i++)
			{
				DataRow row = dsDhomat.Tables[0].NewRow();
				

				ds = db.Read("dbShfaqDorezimiDhoma", idDhomat[i]);
				
				row["DATA_MARRJE"] = ds.Tables[0].Rows[0][0];
				row["DATA_DOREZIM"] = ds.Tables[0].Rows[0][1];
				TimeSpan ts;
				int nrDitesh;
				DateTime dtHyrje = Convert.ToDateTime(ds.Tables[0].Rows[0][0]);
				DateTime dtDalje = Convert.ToDateTime(ds.Tables[0].Rows[0][1]);
				ts = dtDalje.Subtract(dtHyrje);
				nrDitesh = ts.Days;
				row["NR_DITESH"] = nrDitesh;
				ds = db.Read("dbShfaqEmriDhoma", idDhomat[i]);
				row["DHOMA_EMRI"] = ds.Tables[0].Rows[0][0];
				ds = db.Read("dbShfaqCmimiDhoma", dtHyrje, idDhomat[i]);
				row["CMIMI"] = ds.Tables[0].Rows[0][0];
				
				row["VLERA"] = Convert.ToInt32(row["CMIMI"]) * nrDitesh;
				

				dsDhomat.Tables[0].Rows.Add(row);
				
			}
			
			return dsDhomat;
		}

		public  int LiroDhomen(int idDhoma)
		{
			int p = 0;
			
			DbController db = new DbController();
			p = db.Update("dbModifikoGjendjeDhome", "L", idDhoma);
			
			return p;
		}

		/// <summary>
		/// Shfaq dhomat e padorezuara per klientet te cileve iu ka mbaruar afati i
		/// qendrimit ne hotel
		/// </summary>
		/// <returns></returns>
		public DataSet ShfaqDhomatEPadorezuara()
		{
			try
			{
				DataSet ds = null;
				string var = "dbShfaqDhomatEPadorezuara";
				DbController db = new DbController(); 
				ds = db.Read(var);
				int numer_krevatesh = 0;
				int cmimi = 0;
				int pagesa_totale = 0;
				int diferenca = 0;
				int shuma = 0;
				int id_kategoria;
				string emri;
				string mbiemri;
				DateTime dataHyrje;
				DateTime dataDalje;
				TimeSpan ts;
				int nr_ditesh = 0;
				ds.Tables[0].Columns.Add("PAGESA_TOTALE", typeof(Int32));
				ds.Tables[0].Columns.Add("DIFERENCA", typeof(Int32));
				ds.Tables[0].Columns.Add("NUMER_DITESH", typeof(string));
				ds.AcceptChanges();
				double ore;
				string dite;
				double cmimi_double;
				double numer_krevatesh_double;
				double pagesa_totale_double;
				double diferenca_double;
				double kapari_double;
				double nr_oresh_double;
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					emri = Convert.ToString(dr[0]);
					mbiemri = Convert.ToString(dr[1]);
					dr[0] = emri + "  " + mbiemri;
					numer_krevatesh = Convert.ToInt32(dr[6]);
					cmimi = Convert.ToInt32(dr[7]);
					dataHyrje = Convert.ToDateTime(dr[2]);
					dataDalje = Convert.ToDateTime(dr[3]);
					ts = dataDalje.Subtract(dataHyrje);
					nr_ditesh = Convert.ToInt32(ts.TotalDays);
					cmimi_double = cmimi;
					numer_krevatesh_double = numer_krevatesh;
					kapari_double = Convert.ToInt32(dr[4]);
					id_kategoria = Convert.ToInt32(dr[8]);
					if (id_kategoria == 31)
					{
						nr_ditesh = Convert.ToInt32(ts.TotalMinutes);
						nr_oresh_double = nr_ditesh;
						ore = Math.Round(nr_oresh_double/60, 1);
						dite = ore.ToString() + " ore";	
					}
					else
					{
					
						ore = nr_ditesh;
						dite = nr_ditesh + " dite";
					}
					pagesa_totale_double = (cmimi_double/numer_krevatesh_double) * ore;
					diferenca_double = pagesa_totale_double - kapari_double;
					pagesa_totale = Convert.ToInt32(pagesa_totale_double);
					diferenca = Convert.ToInt32(diferenca_double);
					nr_ditesh = Convert.ToInt32(ore);
					dr[11] = pagesa_totale;
					dr[12] = diferenca;
					shuma = shuma + diferenca;
					dr[13] = dite;
				}
				//konvertimi i dates
				ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
				ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					dataHyrje = Convert.ToDateTime(dr[2]);
					dataDalje = Convert.ToDateTime(dr[3]);
					dr[14] = this.konverto(dataHyrje);
					dr[15] = this.konverto(dataDalje);
				}
				ds.AcceptChanges();
				return ds;
			}
			catch
			{
				return new DataSet();
			}
		}

		/// <summary>
		/// Shfaq dhomat e padorezuara per klientet e grupeve te cileve u ka mbaruar afati i
		/// qendrimit ne hotel
		/// </summary>
		/// <returns></returns>
		public DataSet ShfaqDhomatEPadorezuara2()
		{
			try
			{
				DataSet ds = null;
				string var = "dbShfaqDhomatEPadorezuaraGrupe";
				DbController db = new DbController(); 
				ds = db.Read(var);
				int numer_krevatesh = 0;
				int cmimi = 0;
				int pagesa_totale = 0;
				int diferenca = 0;
				int shuma = 0;
				int id_kategoria;
				string emri;
				string mbiemri;
				DateTime dataHyrje;
				DateTime dataDalje;
				TimeSpan ts;
				int nr_ditesh = 0;
				ds.Tables[0].Columns.Add("PAGESA_TOTALE", typeof(Int32));
				ds.Tables[0].Columns.Add("DIFERENCA", typeof(Int32));
				ds.Tables[0].Columns.Add("NUMER_DITESH", typeof(string));
				ds.AcceptChanges();
				double ore;
				string dite;
				double cmimi_double;
				double numer_krevatesh_double;
				double pagesa_totale_double;
				double diferenca_double;
				double kapari_double;
				double nr_oresh_double;
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					emri = Convert.ToString(dr[0]);
					mbiemri = Convert.ToString(dr[1]);
					dr[0] = emri + "  " + mbiemri;
					numer_krevatesh = Convert.ToInt32(dr[6]);
					cmimi = Convert.ToInt32(dr[7]);
					dataHyrje = Convert.ToDateTime(dr[2]);
					dataDalje = Convert.ToDateTime(dr[3]);
					ts = dataDalje.Subtract(dataHyrje);
					nr_ditesh = Convert.ToInt32(ts.TotalDays);
					cmimi_double = cmimi;
					numer_krevatesh_double = numer_krevatesh;
					kapari_double = Convert.ToInt32(dr[4]);
					id_kategoria = Convert.ToInt32(dr[8]);
					if (id_kategoria == 31)
					{
						nr_ditesh = Convert.ToInt32(ts.TotalMinutes);
						nr_oresh_double = nr_ditesh;
						ore = Math.Round(nr_oresh_double/60, 1);
						dite = ore.ToString() + " ore";	
					}
					else
					{
					
						ore = nr_ditesh;
						dite = nr_ditesh + " dite";
					}
					pagesa_totale_double = (cmimi_double/numer_krevatesh_double) * ore;
					diferenca_double = pagesa_totale_double - kapari_double;
					pagesa_totale = Convert.ToInt32(pagesa_totale_double);
					diferenca = Convert.ToInt32(diferenca_double);
					nr_ditesh = Convert.ToInt32(ore);
					dr[14] = pagesa_totale;
					dr[15] = diferenca;
					shuma = shuma + diferenca;
					dr[16] = dite;
				}
				//konvertimi i dates
				ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
				ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					dataHyrje = Convert.ToDateTime(dr[2]);
					dataDalje = Convert.ToDateTime(dr[3]);
					dr[17] = this.konverto(dataHyrje);
					dr[18] = this.konverto(dataDalje);
				}
				ds.AcceptChanges();
				return ds;
			}
			catch (Exception ex)
			{
				return new DataSet();
			}
		}

		public DataSet ShfaqDhomatEZena(int idRezervimi, DateTime dtFillimi, DateTime dtMbarimi)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbDhomatEZenaPerDatatPaRezervim",idRezervimi, dtFillimi, dtMbarimi);
			return ds;
		}
		#endregion public methods

		private string ConvertDate(string date)
		{
			return date.Substring(0, 4) +System.Environment.NewLine + date.Substring(5, 5);
		}
	
	}

}