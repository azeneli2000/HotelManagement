using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagment.BusDatService
{
	/// <summary>
	/// Eshte klase pergjegjese per veprimet qe kane te bejne me perdoruesit
	/// </summary>
	public class Perdorues
	{
		public string userName = "";
		
		/// <summary>
		/// Konstruktor pa parametra per krijimin e nje instance te klases Perdorues
		/// </summary>
		public Perdorues()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		/// <summary>
		/// Ben kontrollin e usernamit dhe passwordit ne databaze
		/// </summary>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public DataSet KontrollUserNamePassword(string username, string password)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("KontrollUserNamePassword", username, password);
			if (ds != null)
				userName = username;
			return ds;
		}

		/// <summary>
		/// Shfaq rolet qe jane ne databaze
		/// </summary>
		/// <returns></returns>
		public DataSet ShfaqRolet()
		{
			DbController db = new DbController();
			DataSet ds = db.Read("ShfaqRolet");
			return ds;
		}

		/// <summary>
		/// Kthen nje dataSet qe mban te gjithe perdoruesit qe jane per momentin te ruajtur ne databaze
		/// </summary>
		/// <returns></returns>
		public DataSet ShfaqPerdoruesit()
		{
			DbController db = new DbController();
			DataSet ds = db.Read("ShfaqPerdoruesit");
			return ds;
		}

		/// <summary>
		/// Ben krijimin e nje perdoruesi te ri ne baze te atributeve te dhena
		/// </summary>
		/// <param name="emer"></param>
		/// <param name="mbiemer"></param>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <param name="rolID"></param>
		/// <returns></returns>
		public int KrijoPerdorues(string emer, string mbiemer, string username, string password, int rolID)
		{
			int b = 0;
			DbController db = new DbController();
			// Ne fillim do te kontrollojme nese nje perdorues me kete username ekziston
			DataSet ds = db.Read("KontrolloPerdorues", username);
			// Nese ekziston, dil dhe kthe vleren 1
			if (ds.Tables[0].Rows.Count != 0)
				return 1;
			// Do te kontrollojme nese perdoruesi qe do te shtohet eshte i pari dhe te kontrollohet roli qe i
			// i eshte caktuar. Nese ky rol eshte user atehere dil pa bere shtim dhe kthe vleren 2
			ds = this.ShfaqPerdoruesit();
			if (ds.Tables[0].Rows.Count == 0)
			{
				if (rolID == 2)
					return 2;
			}
			b = db.Update("ShtoPerdorues", emer, mbiemer, username, password, rolID);
			return b;
		}

		/// <summary>
		/// Ben modifikimin e perdoruesit nga baza e te dhenave
		/// </summary>
		/// <param name="userID"></param>
		/// <param name="rolID1">roli qe ka perdoruesi ne fillim</param>
		/// <param name="rolID2">roli i ri qe i jepet perdoruesit</param>
		/// <param name="emer"></param>
		/// <param name="mbiemer"></param>
		/// <param name="emerPerdorues1">emri qe ka perdoruesi ne fillim</param>
		/// <param name="emerPerdorues2">emri i ri qe i jepet perdoruesit</param>
		/// <param name="fjalekalim"></param>
		/// <returns></returns>
		public int ModifikoPerdorues(int userID, int rolID1, int rolID2, string emer, string mbiemer, string emerPerdorues1, 
			string emerPerdorues2, string fjalekalim)
		{
			int b = 0;
			DbController db = new DbController();
			DataSet ds = db.Read("KontrolloEmraPerdoruesish", emerPerdorues1, emerPerdorues2);
			// Nese emri i perdoruesit gjendet ne databaze atehere mos kryej modifikim dhe kthe vleren 1
			if (ds.Tables[0].Rows.Count != 0)
				return 1;
			// Nese roli i meparshem i perdoruesit eshte administrator dhe ky rol tenton te behet perdorues
			// atehere kontrollo nese eshte i vetmi administrator i programit dhe nese po, atehere dil pa bere
			// gje dhe kthe vleren 2
			if ((rolID1 != rolID2) && (rolID1 == 1))
			{
				if (this.NumerAdmin() == 1)
					return 2;
			}
			b = db.Update("ModifikoPerdorues", emer, mbiemer, emerPerdorues2, fjalekalim, userID, rolID2);
			return b;
		}

		/// <summary>
		/// Shfaq te dhenat per perdoruesin qe ka si userID <c>userID</c>
		/// </summary>
		/// <param name="userID"></param>
		/// <returns></returns>
		public DataSet ShfaqTeDhenaPerdorues(int userID)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("ShfaqTeDhenatPerPerdorues", userID);
			return ds;
		}

		/// <summary>
		/// Ben fshirjen e nje perdoruesi ose administratori.
		/// Nese administratori qe tentohet te fshihet, eshte i vetmi administrator, atehere 
		/// kjo gje nuk duhet te lejohet
		/// </summary>
		/// <param name="userID"></param>
		/// <returns>0 nese fshirja kryhet me sukses</returns>
		/// <returns>2 nese perdoruesi eshte administrator dhe eshte i vetmi administrator ne databaze<returns>
		public int FshiPerdorues(int userID)
		{
			int b = 0;
			
			DbController db = new DbController();
			DataSet ds = this.ShfaqTeDhenaPerdorues(userID);
			// Nese perdoruesi eshte administrator atehere kontrollo nese ky eshte i vetmi administrator
			if (Convert.ToInt32(ds.Tables[0].Rows[0][4]) == 1)
			{
				// Nese perdoruesi eshte i vetmi administrator atehere dil pa bere fshirjen dhe kthe vleren 2
				if (this.NumerAdmin() == 1)
					return 2;
			}
			string userName = ds.Tables[0].Rows[0]["USER_NAME"].ToString();
			b = db.Update("dbZevendesoIdMeUserNameArkaShpenzime", userName, userID);
			b += db.Update("FshiPerdorues", userID);
			return b;
		}


		public DataSet KontrollPerdorues(string emerPerdoruesi)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("KontrollPerdorues", emerPerdoruesi);
			return ds;
		}

		/// <summary>
		/// Kontrollon numrin e administratoreve qe jane ne databaze
		/// </summary>
		/// <returns></returns>
		private int NumerAdmin()
		{
			int count = 0;
			DbController db = new DbController();
			DataSet ds = db.Read("KontrolloNumerAdmin");
			count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
			return count;
		}
	}
}
