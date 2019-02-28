using System;
using HotelManagment;
using HotelManagment.BusDatService;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment.BusDatService
{
	/// <summary>
	/// Summary description for Inicializimi.
	/// </summary>
	public class Inicializimi
	{
		
		public int idIdentifikimi;
		public int idCmimi;
		public int idKlienti;
		public int idGrupi;
        public int idRezervimi;
		public Inicializimi()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public int Inicializo()
		{
			
			int p = 0;
		    DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbInicializoIdentifikimi");
			
			DataRow dr = ds.Tables[0].Rows[0];	
			if (dr[0].ToString() != "")
				
			this.idIdentifikimi = Convert.ToInt32(dr[0]);
			ds = db.Read("dbInicializoCmimiDhoma");
		    dr = ds.Tables[0].Rows[0];
			if (dr[0].ToString() != "")
				
			this.idCmimi = Convert.ToInt32(dr[0]);
			ds = db.Read("dbInicializoKlienti");
			 dr = ds.Tables[0].Rows[0];
			if (dr[0].ToString() != "")
				
			this.idKlienti = Convert.ToInt32(dr[0]);
			ds = db.Read("dbInicializoGrupi");
			dr = ds.Tables[0].Rows[0];
			if (dr[0].ToString() != "")
				
			this.idGrupi = Convert.ToInt32(dr[0]);
			ds = db.Read("dbInicializoRezervimi");
			dr = ds.Tables[0].Rows[0];
			if (dr[0].ToString() != "")
			
			this.idRezervimi = Convert.ToInt32(dr[0]);
			return p;

		}
	}
}
