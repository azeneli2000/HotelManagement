using System;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment.BusDatService
{
	/// <summary>
	/// Summary description for CmimiDhoma.
	/// </summary>
	public class CmimiDhoma
	{
		private DateTime dtFillimi ;
		private DateTime dtMbarimi;
		private int cmimiDhoma;
      
		#region constructors
		public CmimiDhoma()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public CmimiDhoma(DateTime dtFillimi,DateTime dtMbarimi,int cmimiDhoma)
		{
			this.dtFillimi = dtFillimi;
			this.dtMbarimi = dtMbarimi;
			this.cmimiDhoma = cmimiDhoma;
		}

		public CmimiDhoma(DateTime dtFillim, DateTime dtMbarim)
		{
			this.dtFillimi = dtFillim;
			this.dtMbarimi = dtMbarim;
		}
		#endregion

		#region public methods
        public int KrijoCmimiDhoma(int idDhoma)
		{
			int p = 0;int c = 1; int cd = 2;
			DbController db = new DbController();
			p = this.KntAplikuarCmimiDhomaData(idDhoma);
			if( p == 0)
			{
				c = db.Create("dbKrijoCmimPerDhome", dtFillimi,dtMbarimi, cmimiDhoma);
				if ( c == 0)
				{
					Inicializimi iniObject = new Inicializimi();
					int i = iniObject.Inicializo();
					int idCmimi = iniObject.idCmimi;
					cd = db.Create("dbKrijoCmimiDhoma",idDhoma,idCmimi);
					p = cd;
				}
				else
					p = c;
			}
			else
				return p;
			return p;
			
		}
		
		public int ModifikoCmimiDhoma(int idDhoma ,int idCmimi, DateTime dtFillimiVjeter, DateTime dtMbarimiVjeter)
		{
			int p = 0;
			DataSet ds = null;
			DbController db = new DbController();
			ds = this.KontrolloDhomaRezervuarData(idDhoma, dtFillimiVjeter, dtMbarimiVjeter);
			DataRow dr1 = ds.Tables[0].Rows[0];
			if(Convert.ToInt32(dr1[0]) == 0)
			{
				DataSet ds1 = null;
				ds1 = db.Read("dbShfaqKlientPerDhomeDataTeDhenaKntCmime",idDhoma,dtFillimiVjeter,dtMbarimiVjeter);
				if(Convert.ToInt32(ds1.Tables[0].Rows.Count) == 0)
				{  
					p = this.KntAplikuarCmimiDhomaData(idDhoma);
					if( p == 0)
					p = db.Update("dbModifikoCmimiPerDhomen",idCmimi, cmimiDhoma, this.dtFillimi,this.dtMbarimi);
					else
						return p ;//1 konflikt dtfillimi,2 konflikt dtmbarimi
				}
				else 
					p = 5;//dhoma eshte e zene
			}
			else 
				p = 4;//dhoma eshte e rezervuar
			return p;
			
		}
		public int FshiCmimiDhoma(int idDhoma,int idCmimi)
		{
			int p = 0;
			int z= 2;int r = 1;
			DataSet ds = null;
			DataSet ds1 = null;		
			DbController db = new DbController();
			Dhoma dhomaObject = new Dhoma();
			ds = dhomaObject.NxirrDhome(idDhoma);
			DataRow dr = ds.Tables[0].Rows[0];
			string gjendja = Convert.ToString(dr[2]);
			ds1 = this.KontrolloDhomaRezervuarData(idDhoma,this.dtFillimi,this.dtMbarimi);
			DataRow dr1 = ds1.Tables[0].Rows[0];
			if(Convert.ToInt32(dr1[0]) == 0)
			{
				ds = db.Read("dbShfaqKlientPerDhomeDataTeDhenaKntCmime",idDhoma,this.dtFillimi,this.dtMbarimi);
				if(Convert.ToInt32(ds.Tables[0].Rows.Count) == 0)
					p = db.Delete("dbFshiCmimiDhoma",idDhoma,idCmimi);
				else
					return p = z ;
			}
			else			
				p = r;			
			return p;
		}

		public DataSet NxirrCmimiDhomaPerKategorine(int  idKategoria)
		{
			DbController db = new DbController();
			DataSet ds = null;
			ds = db.Read("dbShfaqCmimetPerKategorineEdhene",idKategoria);
			ds.Tables[0].Columns.Add("DATA_FILLIMI_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_MBARIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[1]);
				DateTime dataDalje = Convert.ToDateTime(dr[2]);
				dr[9] = this.konverto(dataHyrje);
				dr[10] = this.konverto(dataDalje);
				
			}
			ds.AcceptChanges();
			return ds;
		}
		public DataSet NxirrCmimiDhoma(int  idDhoma)
		{
			DbController db = new DbController();
			DataSet ds = null;
			ds = db.Read("dbShfaqCmimetPerDhomenEdhene",idDhoma);

			ds.Tables[0].Columns.Add("DATA_FILLIMI_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_MBARIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[1]);
				DateTime dataDalje = Convert.ToDateTime(dr[2]);
				dr[9] = this.konverto(dataHyrje);
				dr[10] = this.konverto(dataDalje);
				
			}
			ds.AcceptChanges();
			return ds;
		}
		public DataSet NxirrCmimiDhomaPerShtreter(int  nrShtreter)
		{
			DbController db = new DbController();
			DataSet ds = null;
			ds = db.Read("dbShfaqCmimetPerShtreter",nrShtreter);

			return ds;
		}

		public DataSet NxirrCmimiDhomaPerDaten(DateTime varDate, int idDhoma)
		{
			DbController db = new DbController();
			DataSet ds = null;
			ds = db.Read("CmimiDhomesPerDaten",varDate, idDhoma);
			return ds;
		}

		public DataSet NxirrCmimiDhomaData(int idDhome)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqCmimPerDhomenDheDatatEdhena", idDhome, this.dtFillimi, this.dtMbarimi);
			return ds;
		}
		public DataSet NxirrCmimiDhomaData(DateTime data)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqCmimetEdhomavePerDatenEdhene", data);
			ds.Tables[0].Columns.Add("DATA_FILLIMI_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_MBARIMI_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[4]);
				DateTime dataDalje = Convert.ToDateTime(dr[5]);
				dr[8] = this.konverto(dataHyrje);
				dr[9] = this.konverto(dataDalje);
				
			}
			ds.AcceptChanges();
			return ds;
		}
		public DataSet NxirrPagesaDhomaData(int idDhoma,int kapari,DateTime dtHyrje,DateTime dtDalje)
		{
			DataSet ds = null;
			int skonto = 0;
			int nrDite = 0;
			int cmimi = 0;
			DbController db = new DbController();
			ds = db.Read("dbNxirCmimetDhoma",idDhoma);//dt_fillimi,dt_mbarimi,cmimi
					
			foreach ( DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dtFillimi = Convert.ToDateTime(dr[0]);
				DateTime dtMbarimi = Convert.ToDateTime(dr[1]);
				cmimi = Convert.ToInt32(dr[2]);
				if( dtHyrje.CompareTo(dtFillimi)>0 && dtHyrje.CompareTo(dtMbarimi)<0)
				{
					System.TimeSpan diff = dtHyrje.Subtract(dtDalje);
					 nrDite = Convert.ToInt32(diff.Days);
				}
				
			}
				int Pagesa = ((nrDite * cmimi)- kapari)* skonto; 
            return ds;
		}
		public DataSet ShfaqCmimet()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqCmimetPerDhomat");
			ds.Tables[0].Columns.Add("DATA_FILLIMI_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_MBARIMI_STR",typeof(String));
			
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[6]);
				DateTime dataDalje = Convert.ToDateTime(dr[7]);
				dr[9] = this.konverto(dataHyrje);
				dr[10] = this.konverto(dataDalje);
				
			}
			ds.AcceptChanges();
			return ds;
		}
		#endregion
            
		private DataSet KontrolloDhomaRezervuarData(int idDhoma ,DateTime dtFillimi,DateTime dtMbarimi)
		{
			DataSet ds = null;
            DbController db = new DbController();
			ds = db.Read("dbKntRezNdermjetDataveCmime",idDhoma,dtFillimi,dtMbarimi);
			return ds;
		}

		private int KntAplikuarCmimiDhomaData(int idDhoma)
		{ 
			int p = 0;
			int a = 0;
			DataSet ds = null;
			DataSet ds1 = null;
			DbController db = new DbController();
			//kontrroll ne database nese dt_fillimi apo dt_mbarimi jane aplikuar ma pare
			ds = db.Read("dbKontrollAplikuarDtFillimiCmimi",this.dtFillimi, idDhoma);
			DataRow dr;
			if (ds.Tables[0].Rows.Count != 0)
			{
				dr = ds.Tables[0].Rows[0];
				if (Convert.ToInt32(ds.Tables[0].Rows.Count) != 0)
				{
					if   (this.dtFillimi == Convert.ToDateTime(dr[1]))
						a = 0;
					else
						a = 1; //konflikt dtFillimi
				}
			}
			else
			{
				a = 0;
			}
			ds1 = db.Read("dbKontrollAplikuarDtMbarimiCmimi",this.dtMbarimi, idDhoma);
			if (ds1.Tables[0].Rows.Count != 0)
			{							  
				dr = ds1.Tables[0].Rows[0];
				if(Convert.ToInt32(ds.Tables[0].Rows.Count) != 0)
				{
					if (this.dtMbarimi == Convert.ToDateTime(dr[1]))
						p = 0;
					else
				
						p = 2; //konflikt dtMbarimi
				}
			}
			else
			{
				p = 0;
			}
			return a + p;
			
		}
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
	}
}
