using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagment.BusDatService
{
	/// <summary>
	/// Summary description for Identifikimi.
	/// </summary>
	public class Identifikimi
	{
		private int idLloji;
		private string nrIdentifikimi, emerLloji;
		public int idIdentifikimi;

		public Identifikimi()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public Identifikimi(string emerLloji)
		{
			this.emerLloji = emerLloji;
		}
		public Identifikimi(int idLloji,string nrIdentifikimi)
		{
			this.idLloji = idLloji;
			this.nrIdentifikimi = nrIdentifikimi;
		}


		public int KrijoLlojIdentifikimi()
		{
			int p = 0;
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbKontrolloLlojIdentifikimi",this.emerLloji);  //krijuar ose jo
			DataRow dr = ds.Tables[0].Rows[0];
			if (Convert.ToInt32(dr[0]) == 0)
			p = db.Create("dbKrijoLlojIdentifikimi",this.emerLloji);
			else
				p = 1;//lloji i identifikimit eshte konfiguruar me pare
			return p;
		}
		public int KrijoIdentifikimi()
		{
			int p = 0; int c = 0;
			DbController db = new DbController();
			c = db.Create("dbKrijoIdentifikim",this.nrIdentifikimi, this.idLloji);
			return p = c;

		}
		public int ModifikoLlojIdentifikimi(int idLloji)
		{
			int p = 0;int u = 0;
			DbController db = new DbController();
			u = db.Update("dbModifikoLlojIdentifikimi", this.emerLloji, idLloji);
			return p = u;
		}
		public int ModifikoIdentifikimi(int idIdentifikimi)
		{
			int p = 0; int u = 0;
			DbController db = new DbController();
			u = db.Update("dbModifikoIdentifikimi", this.idLloji, this.nrIdentifikimi, idIdentifikimi);
			return p = u;

		}

		public DataSet ShfaqIdentifikim()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqMjeteIdentifikimi");
			return ds;
		}

		public int FshiLlojIdentifikimi(int idLloji)
		{
			#region local variables
			int p = 0;
			int d = 0;
			int i = 1;//ka klient me kete lloj identifkimi
			#endregion
			DataSet ds = null;
			DbController db = new DbController();
		    ds = db.Read("dbKontrolloIdLlojiKlienti",idLloji);
			DataRow dr = ds.Tables[0].Rows[0];
			if ( Convert.ToInt32(dr[0]) == 0)
			{
				d = db.Delete("dbFshiMjetIdentifikimi",idLloji);
				p = d;
			}
			else p =i;
			return p;
		}

		public int FshiIdentifikimi(int idIdentifikimi)
		{
			int p = 0 ;
			DbController db = new DbController();
			int d = db.Delete("dbFshiIdentifikimi",idIdentifikimi);
			p = d;
			return p ;

		}
		public int NxirrIdentifkim(int idIdentifikimi)
		{
			int p = 0;
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbNxirrIdentifikimi",idIdentifikimi);
			DataRow dr = ds.Tables[0].Rows[0];
			this.idLloji = Convert.ToInt32(dr[1]);
			this.nrIdentifikimi = Convert.ToString(dr[2]);

			return p ;
			
		}

	}
}
