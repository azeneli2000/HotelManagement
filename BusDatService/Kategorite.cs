using System;
using System.Data.SqlClient;
using HotelManagment.BusDatService;
using System.Data;

namespace HotelManagment
{
	/// <summary>
	/// Summary description for Kategorite.
	/// </summary>
	public class Kategorite
	{   
		private string emerKategoria = "null";
		public int idKategoria;
		public Kategorite()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public Kategorite(string emerKategoria)
		{
			this.emerKategoria = emerKategoria;
			
		}

		public DataSet ShfaqKategori()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqKategorite");
			return ds;
		}

		public int KrijoKategori()
		{
			int p = 0;
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbKontrolloEmerKategori",this.emerKategoria);
			DataRow dr = ds.Tables[0].Rows[0];
			if (Convert.ToInt32(dr[0]) == 0)
				p = db.Create("dbKrijoKategori",this.emerKategoria);
			else 
				p = 1;//kategoria me kete emer eshte konfiguruar me pare
			return p;
		}

		public int ModifikoKategori(int idKategoria)
		{
			int p = 0;
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbKontrolloEmerKategori",this.emerKategoria);
			DataRow dr = ds.Tables[0].Rows[0];
			if (Convert.ToInt32(dr[0]) == 0)
			p = db.Update("dbModifikoKategori",this.emerKategoria, idKategoria);
			else 
				p = 1;//kategoria me kete emer eshte konfiguruar me pare
			return p;
		}

		public int FshiKategori(int idKategoria)
		{
			int p = 0;
			DataSet ds = null;
			DbController db = new DbController();
			Dhoma dhomaObject = new Dhoma();
			ds = db.Read("dbKontrolloKategoriDhome",idKategoria);
			DataRow dr = ds.Tables[0].Rows[0];
			if(Convert.ToInt32(dr[0]) == 0)
				p = db.Delete("dbFshiKategori",idKategoria);
			else
				p = 1; //per kete kategori ka dhoma te konfiguruara	,fshirja lejohet kur nuk ka dhoma				
                return p;

		}

		public int NxirrKategoria(int idKategoria)
		{
			int p = 0;
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbNxirrKategoria",idKategoria);
			DataRow dr = ds.Tables[0].Rows[0];
			this.emerKategoria = Convert.ToString(dr[1]);
			return p;

		}
	}
}
