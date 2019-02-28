using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagment.BusDatService
{
	/// <summary>
	/// Summary description for PrintData.
	/// </summary>
	public class PrintData
	{
		public PrintData()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public DataSet MbushDataSet(DataSet ds)
		{
			SqlDataAdapter da = new SqlDataAdapter();
			da.Fill(ds);
			return ds;
		}
	}
}
