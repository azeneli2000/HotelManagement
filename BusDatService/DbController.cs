using System;
using HotelManagment;
using HotelManagment.BusDatService;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment.BusDatService
{
	/// <summary>
	/// Krijon dy instanca te DbMapper dhe DbManager dhe pasi merr stringun qe do te perdoret per Query nga
	/// DbMapper, therret metoden GetData te DbManager.
	/// </summary>
	public class DbController
	{
		public DbController()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#region Create
		public int Create(string CRUD,int varInt1,int varInt2,int varInt3,DateTime varDate)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case "dbKrijoDetyrimPerKlient":
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoDetyriminPerKlient",varInt1, varInt2, varInt3,varDate));
					b = dbmanObject.GetData();
					break;
					//varInt1 idllojdetyrimi
					//varInt2 sasia
					//varInt3 idKlienti
					//varDate dataDetyrimi
				default:
					b = 1;
					break;
			}
			return b;
		}	
		public int Create(string CRUD,string varString,int varInt)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b;
			switch(CRUD)
			{
				case "dbKrijoLlojDetyrimi":
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoLlojDetyrimi",varString,varInt));
					b = dbmanObject.GetData();
					break;
				case "dbKrijoIdentifikim":
					// varString eshte numri i identifikimit
					// varInt eshte ID e llojit te identifikimit
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoIdentifikim", varString, varInt));
					b = dbmanObject.GetData();
					break;
				case "dbModifikoGjendjeDhome":
					dbmanObject.strSql = dbmapObject.GetQuery("ModifikoGjendjeDhome", varString, varInt);
					b = dbmanObject.GetData();
					break;

				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Create(string CRUD,string varString,float varFloat)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b;
			switch(CRUD)
			{
				
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Create(string CRUD, string varString1, string varString2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch (CRUD)
			{
				case "dbShtoFormePagese":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShtoFormePagese", varString1, varString2));
					b = dbmanObject.GetData();
					break;
				default :
					b = 1;
					break;
			}
			return b;
		}

		public int Create(string CRUD, string varString1, string varString2, string varString3)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch (CRUD)
			{
				case "dbKrijoGrup" :
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoGrupi",varString1, varString2, varString3));
					b = dbmanObject.GetData();
					// varString1 sherben si emri i grupit
					// varString2 sherben si emri i agjensise
					// varString3 sherben si emaili i grupit
					break;
				default :
					b = 1;
					break;
			}
			return b;
		}
		public int Create(string CRUD,int varInt1, string varString1,int varInt2,int varInt3)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch (CRUD)
			{
				case"dbKrijoDhome":
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoDhome", varInt1, varString1, varInt2, varInt3));
					b = dbmanObject.GetData();
					break;
				default :
					b = 1;
					break;
			}
			return b;
		}
		public int Create(string CRUD, DateTime varDate1, DateTime varDate2, int varInt1)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch (CRUD)
			{
				case "dbKrijoCmimPerDhome":
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoCmimPerDhome",varDate1, varDate2, varInt1));
					b = dbmanObject.GetData();
					break;
				default :
					b = 1;
					break;
			}
			return b;
		}

		public int Create(string CRUD,int varInt1,int varInt2)
		{
			int b;
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			switch(CRUD)
			{
				case "dbKrijoRezervimDhoma" :
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoRezervimDhoma",varInt1,varInt2));
					b = dbmanObject.GetData();
					// varInt1 sherben si ID_REZERVIMI, varInt2 sherben si ID_DHOMA
					break;

				case "dbKrijoCmimiDhoma" :
					dbmanObject.strSql = dbmapObject.GetQuery("KrijoCmimiDhoma",  varInt1, varInt2);
					b = dbmanObject.GetData();
					break;
				case "dbKrijoKlientNeGrup" :
					dbmanObject.strSql = dbmapObject.GetQuery("KrijoKlientNeGrup",  varInt1, varInt2);
					b = dbmanObject.GetData();
					// varInt1 sherben si ID_GRUPI, varInt2 sherben si ID_KLIENTI
					break;
				case "dbKrijoRezervimDhomeGrupi":
					dbmanObject.strSql = dbmapObject.GetQuery("KrijoRezervimDhoma", varInt1, varInt2);
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Create(string CRUD,string varString1, string varString2, int varInt1, 
			DateTime varDate1, DateTime varDate2, DateTime varDate3, string varString3)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case "dbKrijoRezervimKlienti":
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoRezervimKlienti",varString1, varString2,
						varInt1, varDate1, varDate2, varDate3, varString3));
					b = dbmanObject.GetData();
					// varString1 sherben si emri
					//varString2 si mbiemri
					//varInt1 si kapari
					// varDate1 si data fillimi
					//varDate2 si data mbarimi
					//varDate3 si data e rezervimit
					//varString3 sherben si emaili
					break;
				default:
					b = 1;
					break;				
			}
			return b;

		}

		public int Create(string CRUD, int varInt1,string varString1, string varString2, int varInt2, 
			DateTime varDate1, DateTime varDate2, DateTime varDate3)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case "dbKrijoRezervimGrupi":
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoRezervimGrupi",varInt1,varString1, varString2, varInt2, varDate1, varDate2, varDate3));
					b = dbmanObject.GetData();
					// varInt1 sherben si ID_GRUPI
					// varString1 sherben si emri i grupit
					// varString2 sherben si agjensia e grupit
					// varInt2 si kapari
					// varDate1 sherben si date fillimi
					// varDate2 si date mbarimi
					// varDate3 si data e rezervimit
					break;
				default:
					b = 1;
					break;				
			}
			return b;

		}
	
		
		public int Create(string CRUD, int varInt1,  DateTime varData, 
			int varInt2,string varString, int varInt3)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b;
			switch(CRUD)
			{
				case "dbKrijoShpenzim":
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoShpenzim", varInt1, varData,
						varInt2, varString, varInt3));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		

		public int Create(string CRUD,string varString1,int varInt1,string varString2,int varInt2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case"dbKrijoDhome":
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoDhome",  varString1, varInt1, varString2, varInt2));
					b = dbmanObject.GetData();
					break;
			}
			return b;
		}


		public int Create(string CRUD, DateTime varDate , int varInt1, string varString, int varInt2  )
		{
			DbMapper dbmapObject  = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				
				
				
				case "dbHidhPageseKlienti":
					//varDate sherben si date e hedhjes ne arke
					//varInt1 sherben si sasi e hedhjes ne arke
					//varString sherben si koment
					//varInt2 sherben si id_rezervimi
					dbmanObject.strSql = (dbmapObject.GetQuery("HidhPageseKlienti", varDate, varInt1, varString, varInt2));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Create(string CRUD, DateTime varDate , int varInt1, string varString1,
			int varInt2,int  varInt3, string varString2, int varInt4 )
		
		{
			DbMapper dbmapObject  = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case "dbHidhKaparRezervimiKlientiNeArke":
					//varDate sherben si date e hedhjes ne arke
					//varInt1 sherben si sasi e hedhjes ne arke
					//varString sherben si koment
					//varInt2 sherben si id_rezervimi
					// varInt4 sherben si id e perdoruesit qe eshte loguar
					dbmanObject.strSql = (dbmapObject.GetQuery("HidhKaparRezervimiKlientiNeArke", varDate,
						varInt1, varString1, varInt2, varInt3, varString2, varInt4));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int Create(string CRUD, DateTime varDate , int varInt1, string varString1,
			int varInt2,int  varInt3, int varInt4, int varInt5 )
		
		{
			DbMapper dbmapObject  = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case "dbHidhDetyrimNeArke":
					//varDate sherben si date e hedhjes ne arke
					//varInt1 sherben si sasi e hedhjes ne arke
					//varString1 sherben si koment
					//varInt2 sherben si id_klienti
					//varInt3 sherben si id_detyrimi
					//varInt4 sherben si idFormaPagesa
					dbmanObject.strSql = (dbmapObject.GetQuery("HidhDetyrimNeArke", varDate,
						varInt1, varString1, varInt2, varInt3,varInt4, varInt5));
					b = dbmanObject.GetData();
					break;
				case "dbHidhKaparRezervimiGrupiNeArke":
					//varDate sherben si date e hedhjes ne arke
					//varInt1 sherben si sasi e hedhjes ne arke
					//varString sherben si koment
					//varInt2 sherben si id_rezervimi
					//varInt6 sherben si id e perdoruesit qe eshte loguar
					dbmanObject.strSql = (dbmapObject.GetQuery("HidhKaparRezervimiGrupiNeArke", varDate,
						varInt1, varString1, varInt2, varInt3, varInt4, varInt5));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Create(string CRUD, DateTime varDate , int varInt1, string varString1,
			int varInt2,int  varInt3, int varInt4 )
		
		{
			DbMapper dbmapObject  = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				
				case "dbHidhNeArke":
					//varDate sherben si date e hedhjes ne arke
					//varInt1 sherben si sasi e hedhjes ne arke
					//varString sherben si koment
					//varInt2 sherben si id_klienti
					//varInt3 sherben si idFormaPagesa
					//varInt4 sherben si id e Perdoruesit qe ka bere transaksionin ne arke
					dbmanObject.strSql = (dbmapObject.GetQuery("HidhNeArke", varDate, varInt1, 
						varString1, varInt2, varInt3, varInt4));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Create(string CRUD,string varString1,string varString2, string varString3,string varString4,DateTime varDate1, int varInt1, int varInt2,  string varString5, string varString6, int varInt3, DateTime varDate2, DateTime varDate3, int varInt4  )
		{
			DbMapper dbmapObject  = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case "dbFutKlientGrupiNeDhome":
					//dbmanObject.strSql = (dbmapObject.GetQuery("FutKlientGrupiNeDhome", varString1, varString2, varString3, varString4, varDate1, varInt1, varInt2, varString3, varString4, varString5, varString6, varInt3, varDate2, varDate3, varInt4 ));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		
		public int Create(string CRUD,string varString)
		{
			DbMapper dbmapObject  = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case "dbKrijoKategori":
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoKategori",varString));
					b = dbmanObject.GetData();
					break;
				case "dbKrijoLlojIdentifikimi":
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoLlojIdentifikimi",varString));
					b = dbmanObject.GetData();
					break;
				case "dbShtoLlojShpenzimi":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShtoLlojShpenzimi",varString));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Create (string CRUD, string varString1, string varString2, DateTime varDate1, string varString3,
			string varString4, string varString5, string varString6, DateTime varDate2, DateTime varDate3, int varInt1,
			int varInt2, int varInt3,DateTime varDate4, string varString7, string varString8)
		{
			int b = 0;
			DbMapper dbmapObject  = new DbMapper();
			DbManager dbmanObject = new DbManager();
			switch (CRUD)
			{
				case "dbKrijoKlient":
					// varString1 sherben si emer, varString2 sherben si mbiemer
					// varDate1 sherben si datelindje, varString3 sherben si adrese
					// varString4 sherben si telefon, varString5 sherben si email
					// varString6 sherben si targe
					// varDate2 sherben si date hyrje, varDate3 si date dalje
					// varInt1 si kapar, varInt2 si ID_IDENTIFIKIMI, varInt3 si ID_DHOMA
					// varString7 sherben si vendlindja
					// varString8 sherben si shtetesia
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoKlienti",varString1, varString2, varDate1, varString3, varString4, varString5, varString6, varDate2, varDate3, varInt1, varInt2, varInt3,varDate4, varString7, varString8));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Create (string CRUD, string varString1, string varString2, DateTime varDate1, string varString3,
			string varString4, string varString5, string varString6, DateTime varDate2, DateTime varDate3, int varInt1,
			int varInt2, int varInt3,DateTime varDate4, string varString7, string varString8, int varInt4)
		{
			int b = 0;
			DbMapper dbmapObject  = new DbMapper();
			DbManager dbmanObject = new DbManager();
			switch (CRUD)
			{
				case "dbKrijoKlient":
					// varString1 sherben si emer, varString2 sherben si mbiemer
					// varDate1 sherben si datelindje, varString3 sherben si adrese
					// varString4 sherben si telefon, varString5 sherben si email
					// varString6 sherben si targe
					// varDate2 sherben si date hyrje, varDate3 si date dalje
					// varInt1 si kapar, varInt2 si ID_IDENTIFIKIMI, varInt3 si ID_DHOMA, varInt4 si idRezervimi
					// varString7 sherben si vendlindja
					// varString8 sherben si shtetesia
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoKlienti",varString1, varString2, varDate1,
						varString3, varString4, varString5, varString6, varDate2, varDate3, varInt1,
						varInt2, varInt3,varDate4, varString7, varString8, varInt4));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		#endregion Create

		#region Delete
		public int Delete(string CRUD, DateTime varDate1)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b;
			switch(CRUD)
			{
				case "dbFshiArka" :
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiArka", varDate1));
					b = dbmanObject.GetData();
					break;
				case "dbFshiShpenzimeDeriNeDatenEDhene" :
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiShpenzimeDeriNeDatenEDhene", varDate1));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public  int Delete(string CRUD,int varInt)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b;
			switch(CRUD)
			{
				
				case  "dbFshiKaparKlientiArka":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiKaparKlientiNgaArka",varInt));
					b = dbmanObject.GetData();
					break;
				case  "dbFshiPagese":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiPagese",varInt));
					b = dbmanObject.GetData();
					break;
				case  "dbFshiLlojDetyrimi":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiLlojDetyrimi",varInt));
					b = dbmanObject.GetData();
					break;
				case "dbFshiDetyrimKlienti":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiDetyrimi",varInt));
					b = dbmanObject.GetData();
					break;
				case "dbFshiDhome":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiDhome",varInt));
					b = dbmanObject.GetData();
					break;
				case "dbFshiIdentifikimi":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiIdentifikimi",varInt));
					b = dbmanObject.GetData();
					break;
				case "dbFshiShpenzim":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiShpenzim",varInt));
					b = dbmanObject.GetData();
					break;
				case "dbFshiGrup":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiGrupi",varInt));
					b = dbmanObject.GetData();
					break;
				case "dbFshiRezervim":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiRezervim",varInt));
					b = dbmanObject.GetData();
					break;
				case "dbNxirrKlientDhome":
					dbmanObject.strSql = (dbmapObject.GetQuery("NxirrKlientDhome",varInt));
					b = dbmanObject.GetData();
					break;
				case "dbFshiKategori":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiKategori",varInt));
					b = dbmanObject.GetData();
					break;
				case "dbFshiMjetIdentifikimi":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiMjetIdentifikimi",varInt));
					b = dbmanObject.GetData();
					break;
				case "dbFshiLlojShpenzimi":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiLlojShpenzimi",varInt));
					b = dbmanObject.GetData();
					break;
				case "dbFshiKaparRezervimiNgaArka":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiKaparRezervimiNgaArka",varInt));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int Delete(string CRUD,int varInt1,int varInt2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b;
			switch(CRUD)
			{
				case"dbFshiCmimiDhoma":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiCmimiDhoma",varInt1,varInt2));
					// varInt sheben si ID_DHOMA
					// varInt1 sherben si ID_CMIMI
					b = dbmanObject.GetData();
					break;
				case "dbFshiRezervimDhome":
					dbmanObject.strSql = dbmapObject.GetQuery("FshiRezervimDhome", varInt1, varInt2);
					b = dbmanObject.GetData();
					break;
				case "dbFshiDhomeRezervuarGrupi":
					dbmanObject.strSql = dbmapObject.GetQuery("FshiDhomeRezervuarGrupi", varInt1, varInt2);
					b = dbmanObject.GetData();
					break;
				case "dbShfaqVeprimetPerDhomen":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetPerDhomen",varInt1, varInt2));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}


		#endregion Delete

		#region Update
		public int Update(string CRUD, int varInt)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b;
			switch(CRUD)
			{
				case "dbPaguajDhome":
					dbmanObject.strSql = (dbmapObject.GetQuery("PaguajDhome", varInt));
					b = dbmanObject.GetData();
					break;
				case "dbFshiKaparKlientiNgaArka":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiKaparKlientiNgaArka", varInt));
					b = dbmanObject.GetData();
					break;
				case "dbDorezoDhome":
					dbmanObject.strSql = (dbmapObject.GetQuery("DorezoDhome", varInt));
					b = dbmanObject.GetData();
					break;
				case "NxirrNgaDhoma":
					//varInt sherben si id_klienti
					dbmanObject.strSql = (dbmapObject.GetQuery("NxirrNgaDhoma", varInt));
					b = dbmanObject.GetData();
					break;
				case "FshiPerdorues":
					dbmanObject.strSql = dbmapObject.GetQuery("FshiPerdorues", varInt);
					b = dbmanObject.GetData();
					break;
				case "dbFshiFormePagese":
					dbmanObject.strSql = dbmapObject.GetQuery("FshiFormePagese", varInt);
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Update(string CRUD, int varInt1, DateTime varDate1, int varInt2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b;
			switch(CRUD)
			{
				case "dbHidhKaparPergjegjesIriNeArke" :
					dbmanObject.strSql =(dbmapObject.GetQuery("HidhKaparPergjegjesIriNeArke", varInt1, varInt2, varDate1));
					b = dbmanObject.GetData();
					break;
				case "dbModifikoArke":
					//varInt1 sherben si pagesa
					//varInt2 sherben si idKlienti
					//varDate1 sherben si dtMbarimi
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoArke", varInt1, varInt2, varDate1));
					b = dbmanObject.GetData();
					break;
				case "dbHidhPagesePergjegjesIriNeArke" :
					dbmanObject.strSql =(dbmapObject.GetQuery("HidhPagesePergjegjesIriNeArke", varInt1, varInt2, varDate1));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int  Update(string CRUD,DateTime varData,int varInt)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b;
			switch(CRUD)
			{
				
				case "dbModifikoArke":
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoArke",varData,varInt));
					b = dbmanObject.GetData();
					break;
				case "dbNxirrNgaArka":
					dbmanObject.strSql = (dbmapObject.GetQuery("NxirrArka",varData,varInt));
					b = dbmanObject.GetData();
					break;
				case "dbModifikoDatenEdaljes":
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoDatenEdaljes",varData,varInt));
					b = dbmanObject.GetData();
					// varInt sherben si idKlienti
					// varDate sherben si data e daljes
					break;
				case "dbShfaqCmimiDhoma" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqCmimiDhoma",varData,varInt));
					b = dbmanObject.GetData();
					// varInt sherben si idDhoma
					// varDate sherben si data e hyrjes
					break;
				
				case "ModifikoDateDalje" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoDateDalje",varData,varInt));
					b = dbmanObject.GetData();
					// varInt sherben si idKlienti
					// varDate sherben si date dorezimi
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Update(string CRUD,int varInt1,int varInt2, string varString,
			DateTime varData,  int varInt3, int varInt4)
		{
			
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case "dbModifikoShpenzim":
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoShpenzim",varInt1,varInt2,
						varData,varInt3, varString, varInt4));
					b = dbmanObject.GetData();
					break;
			
				default:
					b = 1;
					break;
			}
			return b;		
		}

		public int Update(string CRUD, string varString1, string varString2, string varString3, string varString4,
			int varInt1)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch (CRUD)
			{
				case "ShtoPerdorues":
					// varString1 - emri
					// varString2 - mbiemri
					// varString3 - username
					// varString4 - password
					// varInt1 - rolID
					dbmanObject.strSql = dbmapObject.GetQuery("ShtoPerdorues", varString1, varString2, varString3,
						varString4, varInt1);
					b = dbmanObject.GetData();
					break;
			}
			return b;
		}

		public int Update(string CRUD, string varString1, string varString2, string varString3, string varString4,
			int varInt1, int varInt2)
		{
			int b = 0;
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			switch (CRUD)
			{
				case "ModifikoPerdorues":
					dbmanObject.strSql = dbmapObject.GetQuery("ModifikoPerdorues", varString1, varString2, varString3,
						varString4, varInt1, varInt2);
					b = dbmanObject.GetData();
					break;
			}
			return b;
		}

		public int Update(string CRUD, int varInt1, string varString1, string varString2, DateTime varDate1,
			string varString3, string varString4, string varString5, string varString6, DateTime varDate2, DateTime
			varDate3, int varInt2, int varInt3, int varInt4,int varInt5,int varInt6,DateTime varDate4)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch (CRUD)
			{
				case "dbModifikoKlient":
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoKlienti",varInt1, varString1, varString2,varDate1, varString3, varString4, varString5, varString6, varDate2, varDate3, varInt2, varInt3, varInt4,varInt5,varInt6,varDate4));
					b = dbmanObject.GetData();
					// varInt1 sherben si ID_KLIENTI
					// varString1 sherben si emer klienti, vartring2 si mbiemer
					// varDate1 sherben si datelindja
					// varString3 sherben si adrese, varString4 si telefon, varString5 si email, varString6 si targe
					// varDate2 sherben si date hyrje, varDate3 si date dalje
					// varInt2 shereben si kapar, varInt3 si ID_IDENTIFIKIMI, varInt4 si ID_DHOMA
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Update(string CRUD, string varString1, string varString2, DateTime varDate1, string varString3, string varString4, string varString5, string varString6,
			DateTime varDate2, DateTime varDate3, int varInt1, int varInt2, string varString7, string varString8) 
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch (CRUD)
			{
				case "dbModifikoTeDhenaKlienti":
					//varString1 sherben si emri
					//varString2 sherben si mbiemri
					//varDate1 sherben si datelindja
					//varString3 sherben si adresa
					//varString4 sherben si telefoni
					//varString5 sherben si emaili
					//varString6 sherben si targa
					//varDate2 sherben si date hyrje
					//varDate3 sherben si date dalje
					//varInt1 sherben si id dhoma
					//varInt2 sherben si id klienti
					//varString7 sherben si vendlindja
					//varString8 sherben si shtetesia
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoTeDhenaKlienti",varString1, varString2, varDate1, varString3, varString4, varString5, varString6, varDate2, varDate3, varInt1, varInt2, varString7, varString8));
					b = dbmanObject.GetData();
					break;
				case "dbModifikoTeDhenaPergjegjes":
					//varString1 sherben si emri
					//varString2 sherben si mbiemri
					//varDate1 sherben si datelindja
					//varString3 sherben si adresa
					//varString4 sherben si telefoni
					//varString5 sherben si emaili
					//varString6 sherben si targa
					//varDate2 sherben si date hyrje
					//varDate3 sherben si date dalje
					//varInt1 sherben si id dhoma
					//varInt2 sherben si id klienti
					//kapari vendoset 0
					//varString7 sherben si vendlindja
					//varString8 sherben si shtetesia
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoTeDhenaPergjegjes",varString1, varString2, varDate1, varString3, varString4, varString5, varString6, varDate2, varDate3, varInt1, varInt2, varString7, varString8));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}


		public int Update(string CRUD, string varString1, string varString2, DateTime varDate1, 
			string varString3, string varString4, string varString5, string varString6, 
			DateTime varDate2, DateTime varDate3, int varInt1, int varInt2, int varInt3,
			string varString7, string varString8) 
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch (CRUD)
			{
				case "dbModifikoTeDhenaKlientiGrupi":
					//varString1 sherben si emri
					//varString2 sherben si mbiemri
					//varDate1 sherben si datelindja
					//varString3 sherben si adresa
					//varString4 sherben si telefoni
					//varString5 sherben si emaili
					//varString6 sherben si targa
					//varDate2 sherben si date hyrje
					//varDate3 sherben si date dalje
					//varInt1 sherben si id dhoma
					//varInt2 sherben si id klienti
					//varInt3 sherben si idGrupi
					//varString7 sherben si vendlindja
					//varString8 sherben si shtetesia
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoTeDhenaKlientiGrupi",
						varString1, varString2, varDate1, varString3, varString4, varString5,
						varString6, varDate2, varDate3, varInt1, varInt2, varInt3, varString7, varString8));
					b = dbmanObject.GetData();
					break;
				case "dbModifikoTeDhenaPergjegjesGrupi":
					//varString1 sherben si emri
					//varString2 sherben si mbiemri
					//varDate1 sherben si datelindja
					//varString3 sherben si adresa
					//varString4 sherben si telefoni
					//varString5 sherben si emaili
					//varString6 sherben si targa
					//varDate2 sherben si date hyrje
					//varDate3 sherben si date dalje
					//varInt1 sherben si id dhoma
					//varInt2 sherben si id klienti
					//varInt3 sherben si idGrupi
					//varString7 sherben si vendlindja
					//varString8 sherben si shtetesia
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoTeDhenaPergjegjesGrupi",
						varString1, varString2, varDate1, varString3, varString4, varString5, 
						varString6, varDate2, varDate3, varInt1, varInt2, varInt3, varString7, varString8));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int Update(string CRUD, int varInt1, string varString1, string varString2, DateTime varDate1,
			string varString3, string varString4, string varString5, string varString6, DateTime varDate2, DateTime
			varDate3, int varInt2, int varInt3, int varInt4,DateTime varDate4)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch (CRUD)
			{
				case "dbModifikoKlientPaPagese":
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoKlientiPaPagese",varInt1, varString1, varString2,varDate1, varString3, varString4, varString5, varString6, varDate2, varDate3, varInt2, varInt3, varInt4,varDate4));
					b = dbmanObject.GetData();
					// varInt1 sherben si ID_KLIENTI
					// varString1 sherben si emer klienti, vartring2 si mbiemer
					// varDate1 sherben si datelindja
					// varString3 sherben si adrese, varString4 si telefon, varString5 si email, varString6 si targe
					// varDate2 sherben si date hyrje, varDate3 si date dalje
					// varInt2 shereben si kapar, varInt3 si ID_IDENTIFIKIMI, varInt4 si ID_DHOMA
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int Update(string CRUD, int varInt1, string varString1, string varString2, int varInt2, DateTime varDate1,
			DateTime varDate2, DateTime varDate3, DateTime varDate4,string  varString3)
			
		{
			
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch (CRUD)
			{
				case "dbModifikoRezervimKlienti":
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoRezervimKlienti",varInt1, varString1, varString2,
						varInt2, varDate1, varDate2, varDate3,varDate4, varString3));
					b = dbmanObject.GetData();
					// varInt1 sherben si ID_REZERVIMI
					// varString1 sherben si emeri, varString2 si mbiemri, varInt2 si kapari
					// varDate1 sherben si date fillimi, varDate2 si date mbarimi, varDate3 si data e rezervimit
					//varString3 sherben si emaili
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}


		public int Update(string CRUD, int varInt1, int varInt2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				
				case "dbModifikoKaparKlientiFutRezervim":
					//varInt1 sherben si idKlienti
					//varint2 sherben si kapari
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoKaparKlientiFutRezervim", varInt1, varInt2));
					b = dbmanObject.GetData();
					break;
				case "dbFshiPergjegjes":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiPergjegjes", varInt1, varInt2));
					b = dbmanObject.GetData();
					break;
				case "dbFshiKlient":
					dbmanObject.strSql = (dbmapObject.GetQuery("FshiKlient", varInt1, varInt2));
					b = dbmanObject.GetData();
					break;
				case "dbModifikoCmimiDhoma" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ModifikoCmimiDhoma", varInt1, varInt2));
					b = dbmanObject.GetData();
					break;
				case "dbModifikoKaparKlienti" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ModifikoKaparKlienti", varInt1, varInt2));
					b = dbmanObject.GetData();
					break;
				case "dbModifikoPagesaKlientiArka" :
					//varInt1 pagesa
					//varInt2 idKlienti
					dbmanObject.strSql =(dbmapObject.GetQuery("ModifikoPagesaKlientiArka", varInt1, varInt2));
					b = dbmanObject.GetData();
					break;
				case "dbModifikoKlientGrup" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ModifikoKlientGrup", varInt1, varInt2));
					b = dbmanObject.GetData();
					// varInt1 sherben si ID_KLIENTI
					// varInt2 sherben si ID_GRUPI
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Update(string CRUD, int varInt1, int varInt2, int varInt3)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case "dbModifikoPagesaKlientiArka" :
					//varInt1 pagesa
					//varInt2 idKlienti
					dbmanObject.strSql =(dbmapObject.GetQuery("ModifikoPagesaKlientiArka", varInt1, varInt2, varInt3));
					b = dbmanObject.GetData();
					break;
				case "dbModifikoKaparKlientiArka" :
					//varInt1 kapari
					//varInt2 idKlienti
					dbmanObject.strSql =(dbmapObject.GetQuery("ModifikoKaparKlientiArka", varInt1, varInt2, varInt3));
					b = dbmanObject.GetData();
					break;
				case "dbModifikoRezervimDhome" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ModifikoRezervimDhome", varInt1, varInt2,varInt3));
					b = dbmanObject.GetData();
					// varInt1 sherben si ID_REZERVIMI
					// varInt2 sherben si ID_DHOMA_e re
					//var Int3 sherben si ID_DHOMA e vjeter
					break;
				case "dbNxirrKlientiNgaDhoma" :
					dbmanObject.strSql =(dbmapObject.GetQuery("NxirrKlientiNgaDhoma", varInt1, varInt2, varInt3));
					b = dbmanObject.GetData();
					// varInt1 sherben si ID_KLIENTI
					// varInt2 sherben si SKONTO
					// varInt3 sherben si gjoba
					break;
				case "AplikoSkontoGjobe" :
					// varInt1 sherben si skonto
					// varInt2 sherben si gjobe
					// varInt3 sherben si id_klienti
					dbmanObject.strSql =(dbmapObject.GetQuery("AplikoSkontoGjobe", varInt1, varInt2, varInt3));
					b = dbmanObject.GetData();					
					break;
				
				case "dbFshiPergjegjesGrupi" :
					// varInt1 sherben si idKlienti
					// varInt2 sherben si idIdentifikimi
					// varInt3 sherben si idGrupi
					dbmanObject.strSql =(dbmapObject.GetQuery("FshiPergjegjesGrupi", varInt1, varInt2, varInt3));
					b = dbmanObject.GetData();					
					break;
				case "dbFshiKlientGrupi" :
					// varInt1 sherben si idKlienti
					// varInt2 sherben si idIdentifikimi
					// varInt3 sherben si idGrupi
					dbmanObject.strSql =(dbmapObject.GetQuery("FshiKlientGrupi", varInt1, varInt2, varInt3));
					b = dbmanObject.GetData();					
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int Update(string CRUD, int varInt1, int varInt2, int varInt3, int varInt4)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case "dbModifikoKaparKlientiArka" :
					//varInt1 kapari
					//varInt2 idKlienti
					dbmanObject.strSql =(dbmapObject.GetQuery("ModifikoKaparKlientiArka", varInt1, varInt2, varInt3, varInt4));
					b = dbmanObject.GetData();
					break;
				case "dbHidhKaparPergjegjesIri" :
					dbmanObject.strSql =(dbmapObject.GetQuery("HidhKaparPergjegjesIri", varInt1, varInt2, varInt3, varInt4));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
	
		public int Update(string CRUD,int varInt1,int varInt2,int varInt3,DateTime varDate)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case "dbModifikoDetyrimKlienti":
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoDetyrimKlienti",varInt1, varInt2, varInt3,varDate));
					b = dbmanObject.GetData();
					break;
					//varInt1 idllojdetyrimi
					//varInt2 sasia
					//varInt3 idKlienti
					//varDate dataDetyrimi
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int Update(string CRUD,int varInt1,string varString1,DateTime varDate,
			int varInt2, int varInt3, int varInt4)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case "dbModifikoArke":
					//varInt3 idRezervimi
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoArke",varDate,
						varInt1,varString1, varInt2, varInt3));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Update(string CRUD,int varInt1,string varString1,DateTime varDate,
			int varInt2, int varInt3, int varInt4, int varInt5)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case "dbModifikoArke":
					//varInt3 idRezervimi
					//varInt4 idGrupi
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoArke",varDate,
						varInt1,varString1, varInt2, varInt3, varInt4, varInt5));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}	
		
		public int Update(string CRUD,int varInt1,string varString1,DateTime varDate,
			int varInt2, int varInt3, string varString2, int varInt4)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case "dbModifikoArke":
					//rasti i modifikimit te kaparit te rezervimit ne arke
					//varInt3 idRezervimi
					//varInt4 idPerdoruesi
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoArke",varDate,
						varInt1,varString1, varInt2, varInt3, varString2, varInt4));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int Update(string CRUD, string varString,int varInt)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b = 0;
			switch(CRUD)
			{
				case"dbModifikoKategori":
					dbmanObject.strSql =(dbmapObject.GetQuery("ModifikoKategori", varString, varInt));
					b = dbmanObject.GetData();
					break;
				case"dbModifikoLlojDetyrimi":
					dbmanObject.strSql =(dbmapObject.GetQuery("ModifikoLlojDetyrimi", varString, varInt));
					b = dbmanObject.GetData();
					break;
				case "dbModifikoLlojIdentifikimi":
					dbmanObject.strSql = dbmapObject.GetQuery("ModifikoLlojIdentifikimi", varString, varInt);
					b = dbmanObject.GetData();
					break;
				case "dbModifikoGjendjeDhome":
					dbmanObject.strSql = dbmapObject.GetQuery("ModifikoGjendjeDhome", varString, varInt);
					b = dbmanObject.GetData();
					break;
				case "dbModifikoLlojShpenzimi":
					dbmanObject.strSql = dbmapObject.GetQuery("ModifikoLlojShpenzimi",varString, varInt);
					b = dbmanObject.GetData();
					break;
				case "dbZevendesoIdMeUserNameArkaShpenzime":
					dbmanObject.strSql = dbmapObject.GetQuery("ZevendesoIdMeUserNameArkaShpenzime",varString, varInt);
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		

		public int Update(string CRUD,int varInt1, string varString1, string varString2, string varString3 )
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b;
			switch(CRUD)
			{
				case "dbModifikoGrup":
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoGrupi",varInt1, varString1, varString2, varString3 ));
					b = dbmanObject.GetData();
					// varString1 sherben si emer grupi
					// varString2 sherben si emer agjensie
					// varString3 sherben si email
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Update(string CRUD,int varInt1, int varInt2, DateTime varDate1, DateTime varDate2 )
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b;
			switch(CRUD)
			{
				case "dbModifikoCmimiPerDhomen" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoCmimiPerDhomen" ,varInt1, varInt2, varDate1 , varDate2 ));
					// varInt1 sherben si ID_DHOMA
					// varInt2 sherben si cmimi
					// varDate1 sherben si date fillimi dhe varDate2 si date mbarimi
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int Update(string CRUD,int varInt1,string varString1,int varInt2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b;
			switch(CRUD)
			{
				case "dbModifikoLlojDetyrimi":
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoLlojDetyrimi",varString1, varInt2, varInt1));
					b = dbmanObject.GetData();
					break;
				case "dbModifikoIdentifikimPerKlient" :
					// varInt1 sherben si ID_LLOJIDENTIFIKIMI 
					// varString sherben si nr identifikimi
					// varInt2 sherben si ID_IDENTIFIKIMI
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoIdentifikimPerKlient",varInt1, varString1, varInt2 ));
					b = dbmanObject.GetData();					
					break;				
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int Update(string CRUD,string varString1,string varString2,int varInt1)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b;
			switch(CRUD)
			{
				case "dbModifikoFormePagese":
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoFormePagese",varString1, varString2, varInt1));
					b = dbmanObject.GetData();
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int Update(string CRUD,int varInt1, int varInt2, int varInt3,
			DateTime varDate1, DateTime varDate2, DateTime varDate3)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b =0;
			switch(CRUD)
			{
				case "dbModifikoRezervimGrupi":
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoRezervimGrupi", varInt1, varInt2, varInt3, varDate1, varDate2, varDate3));
					b = dbmanObject.GetData();
					// varInt1 sherben si ID_REZERVIMI, varInt2 si ID_GRUPI, varInt3 si KAPARI
					// varDate1 sherben si date fillimi, varDate2 sherben si date mbarimi, varDate3 si data e rezervimit
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		
		public int Update(string CRUD,int varInt1, string varString1, int varInt2, int varInt3,int varInt4)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			int b;
			switch(CRUD)
			{
				case"dbModifikoDhome":
					dbmanObject.strSql = (dbmapObject.GetQuery("ModifikoDhome", varInt1, varString1, varInt2, varInt3, varInt4));
					b = dbmanObject.GetData();
					break;

				default:
					b = 1;
					break;
			}
			return b;
		}
		#endregion Update

		#region Read

		public DataSet Read(string CRUD)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds = null;
			switch(CRUD)
			{
				case "dbShfaqGjitheKlientetNeHotel":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqGjitheKlientetNeHotel"));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDhomaPashlyeraGrupi":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqDhomaPashlyeraGrupi"));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqIdRezervimFundit":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqIdRezervimFundit"));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqIdKlientFundit":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqIdKlientFundit"));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDhomaPashlyera":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqDhomaPashlyera"));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqGjitheShpenzimet":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqGjitheShpenzimet"));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDhomat":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqDhomat"));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDhomatDitore":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqDhomatDitore"));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqKategorite":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategorite");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqLlojetDetyrime":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqLlojetDetyrime");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqMjeteIdentifikimi":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqMjeteIdentifikimi");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqTeGjitheRezervimet":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTeGjitheRezervimet");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqTeGjithaRezervimetKlienti":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRezervimetKliente");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqTeGjithaRezervimetVlefshme":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRezervimetVlefshme");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqTeGjithaRezervimetVlefshmeGrupi":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRezervimetVlefshmeGrupi");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqTeGjithaRezervimetGrupi":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRezervimetGrupe");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqTeGjithaRezervimetGrupiDhome":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRezervimetGrupDhome");
					ds = dbmanObject.GetData("R");
					break;
				case "dbInicializoIdentifikimi":
					dbmanObject.strSql = dbmapObject.GetQuery("InicializoIdentifikimi");
					ds = dbmanObject.GetData("R");
					break;
				case "dbInicializoCmimiDhoma":
					dbmanObject.strSql = dbmapObject.GetQuery("InicializoCmimiDhoma");
					ds = dbmanObject.GetData("R");
					break;
				case "dbInicializoKlienti":
					dbmanObject.strSql = dbmapObject.GetQuery("InicializoKlienti");
					ds = dbmanObject.GetData("R");
					break;
				case "dbInicializoGrupi":
					dbmanObject.strSql = dbmapObject.GetQuery("InicializoGrupi");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShumaKapariRezervimi" :
					dbmanObject.strSql = dbmapObject.GetQuery("ShumaKapariRezervimi");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqGrupe" :
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqGrupe");
					ds = dbmanObject.GetData("R");
					break;
				case "dbInicializoRezervimi" :
					dbmanObject.strSql = dbmapObject.GetQuery("InicializoRezervimi");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqKlientetNeHotel":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKlientetNeHotel");
					ds = dbmanObject.GetData("R");
					break;
				case "dbDataRezervimiFundit":
					dbmanObject.strSql = dbmapObject.GetQuery("DataRezervimiFundit");
					ds = dbmanObject.GetData("R");
					break;
				case "dbDataDaljeFundit":
					dbmanObject.strSql = dbmapObject.GetQuery("DataDaljeFundit");
					ds = dbmanObject.GetData("R");
					break;
				case "dbDataDaljeFunditAll":
					dbmanObject.strSql = dbmapObject.GetQuery("DataDaljeFunditAll");
					ds = dbmanObject.GetData("R");
					break;
				case "dbDataHyrjePare":
					dbmanObject.strSql = dbmapObject.GetQuery("DataHyrjePare");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqHyrjetPasSot":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqHyrjetPasSot");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqGjitheHyrjet":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqGjitheHyrjet");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimetVlefshmePerDhomatMeOre":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRezervimetVlefshmePerDhomatMeOre");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqHyrjetPasSotDhomatMeOre":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqHyrjetPasSotDhomatMeOre");
					ds = dbmanObject.GetData("R");
					break;
				case "ShfaqRolet":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRolet");
					ds = dbmanObject.GetData("R");
					break;
				case "ShfaqPerdoruesit":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqPerdoruesit");
					ds = dbmanObject.GetData("R");
					break;
				case "KontrolloNumerAdmin":
					dbmanObject.strSql = dbmapObject.GetQuery("KontrolloNumerAdmin");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqCmimetPerDhomat":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqCmimetPerDhomat");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqKlientetGrupNeHotel":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKlientetGrupNeHotel");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimeSkaduar":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRezervimeSkaduar");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimeSkaduarGrupe":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRezervimeSkaduarGrupe");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDhomatEPadorezuara":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqDhomatEPadorezuara"));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDhomatEPadorezuaraGrupe":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDhomatEPadorezuaraGrupe");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqLlojetEShpenzimeve":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqLlojetEShpenzimeve");
					ds = dbmanObject.GetData("R");
					break;
				case "dbDataMinRezervimetEVlefshmePerSot":
					dbmanObject.strSql = dbmapObject.GetQuery("DataMinRezervimetEVlefshmePerSot");
					ds = dbmanObject.GetData("R");
					break;
				case "dbDataMinHyrjetEVlefshmePerSot":
					dbmanObject.strSql = dbmapObject.GetQuery("DataMinHyrjetEVlefshmePerSot");
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqTeGjithaFormatEPageses" :
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTeGjithaFormatEPageses");
					ds = dbmanObject.GetData("R");
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet Read(string CRUD,int varInt1,int varInt2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds = null;
			switch(CRUD)
			{
				case "dbShfaqVeprimetPerDhomen":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetPerDhomen",varInt1, varInt2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqVeprimetPerGrupin" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetPerGrupin", varInt1, varInt2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqVeprimetNeGrupPerDhomen" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetNeGrupPerDhomen", varInt1, varInt2));
					ds = dbmanObject.GetData("R");
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}

		public DataSet Read(string CRUD,string varString)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds = null;
			switch(CRUD)
			{
				
				case "dbGjejIdDetyrimi" :
					dbmanObject.strSql = (dbmapObject.GetQuery("GjejIdDetyrimi",varString));
					ds = dbmanObject.GetData("R");
					break;
				case "dbKontrolloEmerKategori" :
					dbmanObject.strSql = (dbmapObject.GetQuery("KontrolloEmerKategori", varString));
					ds = dbmanObject.GetData("R");
					break;
				case "dbKontrolloLlojIdentifikimi" :
					dbmanObject.strSql = (dbmapObject.GetQuery("KontrolloLlojIdentifikimi", varString));
					ds = dbmanObject.GetData("R");
					break;
				case "dbKontrolloLlojDetyrimi" :
					dbmanObject.strSql = (dbmapObject.GetQuery("KontrolloLlojDetyrimi",varString));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqCmimetEdhomavePerEmrinEdhene":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqCmimetEdhomavePerEmrinEdhene",varString));//varString emri i Dhomes
					ds = dbmanObject.GetData("R");
					break;
				case "KontrolloPerdorues":
					dbmanObject.strSql = dbmapObject.GetQuery("KontrolloPerdorues", varString);
					ds = dbmanObject.GetData("R");
					break;
				case "dbKlientetEPashlyerPerDhomen":
					dbmanObject.strSql = dbmapObject.GetQuery("KlientetEPashlyerPerDhomen", varString);
					ds = dbmanObject.GetData("R");
					// varString emri i dhomes
					break;
				case "dbShfaqKlientetPerDhomenEgrupit":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKlientetPerDhomenEgrupit", varString);
					ds = dbmanObject.GetData("R");
					// varString emri i dhomes
					break;
				case "dbNrLloji":
					// varString emri i llojit te shpenzimit
					dbmanObject.strSql = dbmapObject.GetQuery("NrLloji", varString);
					ds = dbmanObject.GetData("R");
					break;
				case "dbNrPagesashPerEmer":
					// varString emri i formes se pageses
					dbmanObject.strSql = dbmapObject.GetQuery("NrPagesashPerEmer", varString);
					ds = dbmanObject.GetData("R");
					break;
				case "dbKontrolloEmerGrupi":
					// varString emri i formes se pageses
					dbmanObject.strSql = dbmapObject.GetQuery("KontrolloEmerGrupi", varString);
					ds = dbmanObject.GetData("R");
					break;
				case "KontrollPerdorues":
					dbmanObject.strSql = dbmapObject.GetQuery("KontrollPerdorues", varString);
					ds = dbmanObject.GetData("R");
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet Read(string CRUD,string varString1, int varInt1)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds = null;
			switch(CRUD)
			{
					
				case "dbKontrolloEmerGrupi" :
					dbmanObject.strSql = (dbmapObject.GetQuery("KontrolloEmerGrupi",varString1, varInt1));
					ds = dbmanObject.GetData("R");
					// varString emri i grupit
					break;
				case "dbNrLloji":
					// varString emri i llojit te shpenzimit
					// varInt1 si id
					dbmanObject.strSql = dbmapObject.GetQuery("NrLloji", varString1, varInt1);
					ds = dbmanObject.GetData("R");
					break;
				case "dbNrPagesashPerEmerPerModifikim":
					// varString emri i forme se pageses
					// varInt1 si id
					dbmanObject.strSql = dbmapObject.GetQuery("NrPagesashPerEmerPerModifikim", varString1, varInt1);
					ds = dbmanObject.GetData("R");
					break;
				

				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet Read(string CRUD,int varInt)
		{
			DataSet ds;
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			switch(CRUD)
			{
				case "dbShfaqPerdoruesPerKlient":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqPerdoruesPerKlient",varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDataPerRezervim":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqDataPerRezervim",varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimDhomaGrupiPerDaten":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqRezervimDhomaGrupiPerDaten",varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqKaparRezervimiArkaFormePagese":
					//varInt sherben si idRezervimi
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqKaparRezervimiArkaFormePagese",varInt));
					ds = dbmanObject.GetData("R");
					break;	
				case "dbShfaqKaparRezervimiArka":
					//varInt sherben si idKlienti
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqKaparRezervimiArka",varInt));
					ds = dbmanObject.GetData("R");
					break;	
				case "dbShfaqVeprimetPerRezervim":
					//varInt sherben si idKlienti
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetPerRezervim",varInt));
					ds = dbmanObject.GetData("R");
					break;	
				case "dbKaparRezervimiNeArke":
					//varInt sherben si idKlienti
					dbmanObject.strSql = (dbmapObject.GetQuery("KaparRezervimiNeArke",varInt));
					ds = dbmanObject.GetData("R");
					break;	
				case "dbShfaqKlientetGrupNeHotel":
					//varInt sherben si idKlienti
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqKlientetGrupNeHotel",varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "KaparKlientiNeArke":
					//varInt sherben si idKlienti
					dbmanObject.strSql = (dbmapObject.GetQuery("KaparKlientiNeArke",varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "ShfaqFormePagesePerKlient":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqFormePagesePerKlient",varInt));
					ds = dbmanObject.GetData("R");
					//varInt sherben si idKlienti
					break;
				case "dbPageseKlientiNeArke":
					dbmanObject.strSql = (dbmapObject.GetQuery("PageseKlientiNeArke",varInt));
					ds = dbmanObject.GetData("R");
					//varInt sherben si idKlienti
					break;
				case "dbGjejIdDetyrimiLLoji":
					dbmanObject.strSql = (dbmapObject.GetQuery("GjejIdDetyrimiLLoji",varInt));
					ds = dbmanObject.GetData("R");
					//varInt sherben si idDetyrimi
					break;
				case "dbShfaqRezervimeVlefshmePerDhomen":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqRezervimeVlefshmePerDhomen",varInt));
					ds = dbmanObject.GetData("R");
					//varInt sherben si idDhoma
					break;
				case "dbShfaqRezervimeVlefshmeGrupiPerDhomen":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqRezervimeVlefshmeGrupiPerDhomen",varInt));
					ds = dbmanObject.GetData("R");
					//varInt sherben si idDhoma
					break;
				case "dbShfaqKlientPerId":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqKlientPerId",varInt));
					ds = dbmanObject.GetData("R");
					//varInt sherben si idKlienti
					break;
				case "dbNxirrCmimiDhoma":
					dbmanObject.strSql = (dbmapObject.GetQuery("NxirrCmimiDhoma",varInt));
					ds = dbmanObject.GetData("R");
					// varInt sherben si ID_DHOMA
					break;
				case "dbShfaqDhome":
					dbmanObject.strSql = (dbmapObject.GetQuery("NxirrDhome",varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbNxirrDhomeRezervuar":
					dbmanObject.strSql = (dbmapObject.GetQuery("NxirrDhomeRezervuar",varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbNxirrDhomeZene":
					dbmanObject.strSql = (dbmapObject.GetQuery("NxirrDhomeZene",varInt));
					ds = dbmanObject.GetData("R");
					break;
					///gjen idKlienti per idDetyrimi te dhene
				case "dbGjejDetyrimKlienti":
					dbmanObject.strSql = (dbmapObject.GetQuery("GjejIdDetyrimi",varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDhomaPerKategorine":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqDhomaPerKategorine",varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqKlientetPerDhomenEdhene":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKlientetPerDhomenEdhene", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDetyrimePerKlientin":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDetyrimePerKlientin", varInt);
					ds = dbmanObject.GetData("R");
					// varInt sherben si ID_DHOMA
					break;
				case "dbShfaqDataPerKlientin":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDataPerKlientin", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDetyrimetPerKlienteteDhomes":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDetyrimetPerKlientetEdhomes", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqVetemDetyrimetPerKlienteteDhomes":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqVetemDetyrimetPerKlientetEdhomes", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDetyrimKlientiPerKategorine":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDetyrimKlientiPerKategorine", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqVetemDetyrimKlientiPerKategorine":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqVetemDetyrimKlientiPerKategorine", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqCmimetPerDhomenEdhene":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqCmimetPerDhomenEdhene", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqCmimetPerShtreter":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqCmimetPerShtreter", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqCmimetPerKategorineEdhene":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqCmimetPerKategorineEdhene", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDhomenPerKategorineEdhene":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDhomenPerKategorineEdhene", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbGjejNrKlientDhome" :
					dbmanObject.strSql = dbmapObject.GetQuery("GjejNrKlientDhome", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqLlojDetyriminEzgjedhur":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqLlojDetyriminEzgjedhur", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbKontrolloLlojDetyrimiKlienti" :
					dbmanObject.strSql = dbmapObject.GetQuery("KontrolloLlojDetyrimiKlienti", varInt);
					ds = dbmanObject.GetData("R");
					// varInt sherben si ID_LLOJDETYRIMI
					break;
				case "dbKontrolloIdLlojiKlienti" :
					dbmanObject.strSql = dbmapObject.GetQuery("KontrolloIdLlojiKlienti", varInt);
					ds = dbmanObject.GetData("R");
					// varInt sherben si ID_LLOJI
					break;
				case "dbShfaqDhomaTeLiraKategori":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDhomatEliraPerKategorine", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbKontrolloKategoriDhome" :
					dbmanObject.strSql = dbmapObject.GetQuery("KontrolloKategoriDhome", varInt);
					ds = dbmanObject.GetData("R");
					// varInt sherben si ID_LLOJI
					break;
				case "dbNxirCmimetDhoma":
					dbmanObject.strSql = (dbmapObject.GetQuery("NxirCmimetDhoma",varInt));
					ds = dbmanObject.GetData("R");
					// varInt sherben si ID_DHOMA
					break;
				case "dbKontrolloDhomaRezervuar":
					dbmanObject.strSql = (dbmapObject.GetQuery("KontrolloDhomaRezervuar",varInt));
					ds = dbmanObject.GetData("R");
					// varInt sherben si ID_DHOMA
					break;
				case "dbKontrolloKlientHotel" :
					dbmanObject.strSql = (dbmapObject.GetQuery("KontrolloKlient" ,varInt));
					ds = dbmanObject.GetData("R");
					// varInt sherben si ID_KLIENTI
					break;
				case "dbShfaqRezervimGrupi" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqRezervimGrupi" ,varInt));
					ds = dbmanObject.GetData("R");
					// varInt sherben si ID_GRUPI
					break;
				case "dbKontrolloGrupHotel" :
					dbmanObject.strSql = (dbmapObject.GetQuery("KontrolloGrupHotel" ,varInt));
					ds = dbmanObject.GetData("R");
					// varInt sherben si ID_GRUPI
					break;
				case "dbShlyerjeDhomaKlienti" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShlyerjeDhomaKlienti" ,varInt));
					ds = dbmanObject.GetData("R");
					// varInt sherben si ID_KLIENTI
					break;
				case "dbNxirrKategoria" :
					dbmanObject.strSql = (dbmapObject.GetQuery("NxirrKategoria" ,varInt));
					ds = dbmanObject.GetData("R");
					// varInt sherben si ID_KLIENTI
					break;
				case "dbShfaqGrupinPerId" :
					//varInt sherben si idGrupi
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqGrupinPerId", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbNxirrIdentifikimi" :
					//varInt sherben si idIdentifikimi
					dbmanObject.strSql = dbmapObject.GetQuery("NxirrIdentifikimi", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDetyrimePerKlientinPerDhomen" :
					//varInt sherben si idKlienti
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDetyrimePerKlientinPerDhomen", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDetyrimeEkstraPerKlientin" :
					//varInt sherben si idKlienti
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDetyrimeEkstraPerKlientin", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "ShfaqKlientPaDetyrime" :
					//varInt sherben si idKlienti
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKlientPaDetyrime", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqKlientetPerGrupin" :
					//varInt sherben si idKlienti
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKlientetPerGrupin", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqKlientetGrupi" :
					//varInt sherben si idKlienti
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKlientetGrupi", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "ShfaqTeDhenatPerPerdorues":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTeDhenatPerPerdorues", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimDhomaGrupi":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRezervimDhomaGrupi", varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqKlientDhomeData":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqKlientDhomeData", varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDhomaTeRezervuara":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqDhomaTeRezervuara", varInt));
					ds = dbmanObject.GetData("R");
					break;
				
				case "dbShfaqDorezimiDhoma" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqDorezimiDhoma", varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqEmriDhoma" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqEmriDhoma", varInt));
					ds = dbmanObject.GetData("R");
					break;		
				case "dbShfaqRezervimeVlefshmePerGrupAgjensi":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqRezervimeVlefshmePerGrupAgjensi",varInt));
					ds = dbmanObject.GetData("R");
					//varInt sherben si idGRUPI
					break;
				case "dbShfaqVeprimetPerDhomen":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetPerDhomen",varInt));
					ds = dbmanObject.GetData("R");
					//varInt sherben si idGRUPI
					break;
				case "dbNrShpenzimeshTeLojit":
					dbmanObject.strSql = (dbmapObject.GetQuery("NrShpenzimeshTeLojit",varInt));
					ds = dbmanObject.GetData("R");
					//varInt sherben si idLLoji
					break;
				case "dbShfaqShpenzimetPerLlojinEdhene" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqShpenzimetPerLlojinEdhene", varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqTeDhenaFormaPagesa" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqTeDhenaFormaPagesa", varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbNrVeprimeshNeArkePerFormePagese" :
					dbmanObject.strSql = (dbmapObject.GetQuery("NrVeprimeshNeArkePerFormePagese", varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqFormePageseKaparDhome" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqFormePageseKaparDhome", varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqFormePagesePerRezervim" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqFormePagesePerRezervim", varInt));
					ds = dbmanObject.GetData("R");
					break;
				default:
					ds = null;
					break;
			}
			return  ds;
		}
		public DataSet Read(string CRUD, DateTime varData)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds;
			switch(CRUD)
			{
				case "dbGjendjaDitoreDuhur" :
					dbmanObject.strSql = (dbmapObject.GetQuery("dbGjendjaDitoreDuhur",varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbNxirrShpenzim" :
					dbmanObject.strSql = (dbmapObject.GetQuery("NxirrShpenzim",varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqBilanciPerDatenEdhene" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqBilanciPerDatenEdhene", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqGjendjenEdhomavePerDatenEdhene" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqGjendjenEdhomavePerDatenEdhene", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimetPerKlientPerDatenEdhene" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqRezervimetPerKlientPerDatenEdhene", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimeVlefshmePerDatenEdhene" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqRezervimetVlefshmePerDatenEdhene", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimetPerGrupPerDatenEdhene" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqRezervimetPerGrupPerDatenEdhene", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimetPerGrupDhomePerDatenEdhene" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqRezervimetPerGrupDhomePerDatenEdhene", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqCmimetEdhomavePerDatenEdhene" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqCmimetEdhomavePerDatenEdhene", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqShpenzimetPerDatenEdhene" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqShpenzimetPerDatenEdhene", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimetPerKlientPerDatatEdhena" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqRezervimetPerKlientPerDatatEdhena", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimetPerGrupPerDatatEdhena" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqRezervimetPerGrupPerDatatEdhena", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShumaArka" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShumaArka", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShumaShpenzime" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShumaShpenzimi", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShumaKapariKlienti" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShumaKapariKlienti", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqArkaData" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqArkenPerDaten", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqArkaFormaPagesa" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqArkaFormaPagesa", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqShpenzimiData" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqShpenzimetPerDaten", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShumaArkaData" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShumaArkaData", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShumaShpenzimeData" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShumaShpenzimeData", varData));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimeVlefshmeKlientiPerDatenEdhene" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqRezervimetVlefshmeKlientiPerDatenEdhene", varData));
					ds = dbmanObject.GetData("R");
					break;					
				case "dbShfaqRezervimeVlefshmeGrupiPerDatenEdhene" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqRezervimeVlefshmeGrupiPerDatenEdhene", varData));
					ds = dbmanObject.GetData("R");
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet Read(string CRUD, DateTime varDate1, DateTime varDate2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds;
			switch(CRUD)
			{
				case "dbShfaqArkenPerDatat":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqArkenPerDatat", varDate1, varDate2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqShpenzimetPerDatat":
					dbmanObject.strSql = (dbmapObject.GetQuery("dbShfaqShpenzimetPerDatat", varDate1, varDate2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqShpenzimetMidisDatave":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqShpenzimetMidisDatave", varDate1, varDate2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShumaShpenzimeMidisDatave" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShumaShpenzimeMidisDatave", varDate1, varDate2));
					ds = dbmanObject.GetData("R");
					break;	
				case "dbShumaArkaMidisDatave" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShumaArkaMidisDatave", varDate1, varDate2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDetyrimetPerDatat":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDetyrimetPerDatat", varDate1, varDate2);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShumaArkaMidisDataveSipasFormesSePageses":
					dbmanObject.strSql = dbmapObject.GetQuery("ShumaArkaMidisDataveSipasFormesSePageses", varDate1, varDate2);
					ds = dbmanObject.GetData("R");
					break;
				default :
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet Read(string CRUD,int varInt1, string varString1, string varString2,  DateTime varDate1, DateTime varDate2, int varInt2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds;
			switch(CRUD)
			{
				case "dbShfaqVeprimetPerKlientinDheDhomen":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetPerKlientinDheDhomen",varInt1, varString1, varString2,  varDate1, varDate2, varInt2));
					ds = dbmanObject.GetData("R");
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet Read(string CRUD, int varInt1, DateTime varDate1)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds;
			switch(CRUD)
			{
				case "dbShfaqDhome":
					dbmanObject.strSql = (dbmapObject.GetQuery("NxirrDhome",varInt1, varDate1));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimDhomaGrupiPerDaten":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqRezervimDhomaGrupiPerDaten",varInt1, varDate1));
					ds = dbmanObject.GetData("R");
					break;
				case "dbNumerKlienteshPerDateDhoma":
					dbmanObject.strSql = (dbmapObject.GetQuery("NumerKlienteshPerDateDhoma",varInt1, varDate1));
					ds = dbmanObject.GetData("R");
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet Read(string CRUD, DateTime varDate1, int varInt1)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds;
			switch(CRUD)
			{
				case "dbKontrollAplikuarDtFillimiCmimi":
					dbmanObject.strSql = (dbmapObject.GetQuery("KontrollAplikuarDtFillimiCmimi", varDate1, varInt1));
					ds = dbmanObject.GetData("R");
					// varDate1 sherben si date fillimi
					// varInt1 sherben si ID_DHOMA 
					break;
				case "dbKontrollAplikuarDtMbarimiCmimi":
					dbmanObject.strSql = (dbmapObject.GetQuery("KontrollAplikuarDtMbarimiCmimi", varDate1, varInt1));
					ds = dbmanObject.GetData("R");
					// varDate1 sherben si date mbarimi
					// varInt1 sherben si ID_DHOMA 
					break;
				case "dbDhomatRPerDaten" :
					dbmanObject.strSql =(dbmapObject.GetQuery("DhomatRezervuarPerDaten", varDate1, varInt1));
					ds = dbmanObject.GetData("R");
					break;
				case "dbNumriKlientevePerDaten" :
					dbmanObject.strSql =(dbmapObject.GetQuery("NumriKlientevePerDaten", varDate1, varInt1));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqKlientetPerDhomenEdhenePerDatenEdhene" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqKlientetPerDhomenEdhenePerDatenEdhene", varDate1, varInt1));
					ds = dbmanObject.GetData("R");
					// varDate1 sherben si date dorezimi
					// varInt1 sherben si ID_DHOMA
					break;
				case "dbShfaqCmimiDhoma" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqCmimiDhoma", varDate1, varInt1));
					ds = dbmanObject.GetData("R");
					// varDate1 sherben si date hyrje
					// varInt1 sherben si ID_DHOMA
					break;
				case "ShfaqDhomatEZenaPerKategorine" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqDhomatEZenaPerKategorine", varDate1, varInt1));
					ds = dbmanObject.GetData("R");
					// varDate1 sherben si date dorezimi
					// varInt1 sherben si ID_KATEGORIA
					break;
				case "CmimiDhomesPerDaten" :
					dbmanObject.strSql =(dbmapObject.GetQuery("CmimiDhomesPerDaten", varDate1, varInt1));
					ds = dbmanObject.GetData("R");
					// varDate1 sherben si date kerkimi
					// varInt1 sherben si ID_DHOMA
					break;
				case "dbShfaqDhomatPerGrupinEdhene":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqDhomatPerGrupinEdhene", varDate1, varInt1));
					ds = dbmanObject.GetData("R");
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}

		public DataSet Read(string CRUD, DateTime varDate1, int varInt1, int varInt2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds;
			switch(CRUD)
			{
				case "dbShfaqKlientetPerDhomenEdhenePerDatenEdhenePerGrup" :
					dbmanObject.strSql =(dbmapObject.GetQuery("ShfaqKlientetPerDhomenEdhenePerDatenEdhenePerGrup", varDate1, varInt1, varInt2));
					ds = dbmanObject.GetData("R");
					// varDate1 sherben si date dorezimi
					// varInt1 sherben si ID_DHOMA
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet Read(string CRUD, string varString1, string varString2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds;
			switch(CRUD)
			{
				case "dbShfaqDetyrimKlientiPerEmerMbiemer":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqDetyrimKlientiPerEmerMbiemer", varString1, varString2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqVetemDetyrimKlientiPerEmerMbiemer":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVetemDetyrimKlientiPerEmerMbiemer", varString1, varString2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimetPerKlientPerEmerMbiemerTeDhene":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqRezervimetPerKlientPerEmerMbiemerTeDhene", varString1, varString2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimetPerKlientinEdhene" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqRezervimetPerKlientinEdhene", varString1, varString2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimetPerGrupAgjensiTeDhene" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqRezervimetPerGrupAgjensiTeDhene", varString1, varString2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimetDhomePerGrupAgjensiTeDhene" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqRezervimetDhomePerGrupAgjensiTeDhene", varString1, varString2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimetPerGrupinEdhene" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqRezervimetPerGrupinEdhene", varString1, varString2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqVeprimetPerGrupin" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetPerGrupin", varString1, varString2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqKlientetSipasGrupit" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqKlientetSipasGrupit", varString1, varString2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimeVlefshmePerEmerMbiemer":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqRezervimeVlefshmePerEmerMbiemer", varString1, varString2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqRezervimeVlefshmePerEmerAgjensi":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqRezervimeVlefshmePerEmerAgjensi", varString1, varString2));
					ds = dbmanObject.GetData("R");
					break;
				case "KontrollUserNamePassword":
					dbmanObject.strSql = dbmapObject.GetQuery("KontrollUserNamePassword", varString1, varString2);
					ds = dbmanObject.GetData("R");
					break;
				case "KontrolloEmraPerdoruesish":
					dbmanObject.strSql = dbmapObject.GetQuery("KontrolloEmraPerdoruesish", varString1, varString2);
					ds = dbmanObject.GetData("R");
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet Read(string CRUD, string varString1, string varString2, int varInt1)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds;
			switch(CRUD)
			{
				case "dbShfaqVeprimetPerKlientin":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqVeprimetPerKlientin", varString1, varString2, varInt1);
					ds = dbmanObject.GetData("R");
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}

		public DataSet Read(string CRUD, int varInt, DateTime varDate1, DateTime varDate2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds = null;
			switch(CRUD)
			{
				case "dbDhomatEZenaPerDatatPaRezervim":
					dbmanObject.strSql = (dbmapObject.GetQuery("DhomatEZenaPerDatatPaRezervim", varDate1, varDate2, varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbRezervimetPerDatatDheGrupin":
					// varInt1 sherben si ID_GRUPI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					dbmanObject.strSql = (dbmapObject.GetQuery("RezervimetPerDatatDheGrupin",  varDate1, varDate2, varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbNrDetyrimeshPerKlientJashteDatave":
					// varInt1 sherben si ID_KLIENTI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					dbmanObject.strSql = (dbmapObject.GetQuery("NrDetyrimeshPerKlientJashteDatave",  varDate1, varDate2, varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbNrKlienteNeDhomeNeGrup":
					dbmanObject.strSql = (dbmapObject.GetQuery("NrKlienteNeDhomeNeGrup", varDate1, varDate2, varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqCmimPerDhomenDheDatatEdhena":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqCmimPerDhomenDheDatatEdhena", varDate1, varDate2, varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqTeDhenaDhomePerDatat":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqTeDhenaDhomePerDatat", varDate1, varDate2, varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "ShfaqDhomaTeLiraPerDatePerKategori":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDhomatEliraPerKategorinePerDatatEdhena", varDate1, varDate2, varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDhomatPlotesishtTeliraPerKategorinePerDatatEdhena":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDhomatPlotesishtTeLiraPerKategorinePerDatatEdhena", varDate1, varDate2, varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "ShfaqDhomaMeOreTeLiraPerData":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDhomaMeOreTeLiraPerData", varDate1, varDate2, varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDhomaMeOrePlotesishtTeLiraPerData":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDhomaMeOrePlotesishtTeLiraPerData", varDate1, varDate2, varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqKlientPerDhomeDataTeDhena":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKlientPerDhomeDataTeDhena", varDate1, varDate2, varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqKlientPerDhomeDataTeDhenaKntCmime":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKlientPerDhomeDataTeDhenaKntCmime", varDate1, varDate2, varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqTeDhenaGrupiDataTeDhena":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTeDhenaGrupiDataTeDhena", varDate1, varDate2, varInt);
					ds = dbmanObject.GetData("R");
					break;
				case "dbKntRezNdermjetDatave":
					dbmanObject.strSql = (dbmapObject.GetQuery("KntRezNdermjetDatave", varDate1, varDate2,varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbKntRezNdermjetDataveCmime":
					dbmanObject.strSql = (dbmapObject.GetQuery("KntRezNdermjetDataveCmime", varDate1, varDate2,varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbNumerKlienteshPerDateDhoma":
					dbmanObject.strSql = (dbmapObject.GetQuery("NumerKlienteshPerDateDhoma", varDate1, varDate2,varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbNumerKlienteshPerDateGrup":
					dbmanObject.strSql = (dbmapObject.GetQuery("NumerKlienteshPerDateGrup", varDate1, varDate2,varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDetyrimePerKategorineDheDatat":
					dbmanObject.strSql = dbmapObject.GetQuery("ShfaqDetyrimePerKategorineDheDatat", varDate1, varDate2, varInt);
					ds = dbmanObject.GetData("R");
					break;			
				case "dbShfaqKlientetSipasDatave" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqKlientetSipasDatave", varDate1, varDate2, varInt));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqVeprimetNeGrupPerDatat" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetNeGrupPerDatat", varDate1, varDate2, varInt));
					ds = dbmanObject.GetData("R");
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		
		public DataSet Read(string CRUD, int varInt1, DateTime varDate1, DateTime varDate2, int varInt2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds = null;
			switch(CRUD)
			{
				case "dbShfaqVeprimetPerGrupPaRezervim":
					// varInt1 sherben si ID_GRUPI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetPerGrupPaRezervim",  varDate1, varDate2, varInt1, varInt2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbRezervimetPerDatatDheGrupin":
					// varInt1 sherben si ID_GRUPI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					dbmanObject.strSql = (dbmapObject.GetQuery("RezervimetPerDatatDheGrupin",  varDate1, varDate2, varInt1, varInt2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqDhomaPlotesishtTeLiraKategoriPerDatePerModifikim":
					// varInt1 sherben si ID_GRUPI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt2 sherben si ID_DHOMA
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqDhomatPlotesishtTeLiraPerKategorinePerDatatEdhenaPerModifikim",  varDate1, varDate2,varInt1, varInt2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbNrKlienteNeDhomeJoTeGrupitTeDhene":
					// varInt1 sherben si ID_GRUPI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt2 sherben si ID_DHOMA
					dbmanObject.strSql = (dbmapObject.GetQuery("NrKlienteNeDhomeJoTeGrupitTeDhene",  varDate1, varDate2,varInt1, varInt2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbNumerKlienteshPerDateDhoma":
					dbmanObject.strSql = (dbmapObject.GetQuery("NumerKlienteshPerDateDhoma", varDate1, varDate2,varInt1, varInt2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbNrKlienteNeDhomePerGrup":
					// varInt1 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt2 sherben si ID_GRUPI
					dbmanObject.strSql = (dbmapObject.GetQuery("NrKlienteNeDhomePerGrup", varDate1, varDate2,varInt1, varInt2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbNumerKlienteshPerDateGrupPerModifikim":
					// varInt1 sherben si ID_GRUPI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt2 sherben si ID_KLIENTI
					dbmanObject.strSql = (dbmapObject.GetQuery("NumerKlienteshPerDateGrupPerModifikim", varDate1, varDate2,varInt1, varInt2));
					ds = dbmanObject.GetData("R");
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet Read(string CRUD, int varInt1, int varInt2, DateTime varDate1, DateTime varDate2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds = null;
			switch(CRUD)
			{
				case "dbShfaqVeprimetPerDhomen" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetPerDhomen",varInt1, varInt2, varDate1, varDate2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqVeprimetPerGrupin" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetPerGrupin", varInt1, varInt2, varDate1, varDate2));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqVeprimetNeGrupPerDhomen" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetNeGrupPerDhomen", varInt1, varInt2, varDate1, varDate2));
					ds = dbmanObject.GetData("R");
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet Read(string CRUD, int varInt1, int varInt2, DateTime varDate1, DateTime varDate2, 
			int varInt3)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds = null;
			switch(CRUD)
			{
				case "dbShfaqVeprimetPerGrupinPaRezervim" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetPerGrupinPaRezervim", varInt1, 
						varInt2, varDate1, varDate2, varInt3));
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqVeprimetPerGrupDheDhome":
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqVeprimetPerGrupDheDhome",varInt1, varInt2, varDate1, varDate2, varInt3));
					ds = dbmanObject.GetData("R");
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet Read(string CRUD, string varString1, string varString2, DateTime varDate1, DateTime varDate2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds = null;
			string query = "";
			switch(CRUD)
			{
				case "dbShfaqDetyrimKlientiPerEmerDheData":
					query = dbmapObject.GetQuery("ShfaqDetyrimKlientiPerEmerDheData", varString1, varString2, varDate1,
						varDate2);
					dbmanObject.strSql = query;
					ds = dbmanObject.GetData("R");
					break;
				case "ShfaqKlientetEDale":
					query = dbmapObject.GetQuery("ShfaqKlientetEDale", varString1, varString2, varDate1, varDate2);
					dbmanObject.strSql = query;
					ds = dbmanObject.GetData("R");
					break;
				case "ShfaqGrupetEDale":
					query = dbmapObject.GetQuery("ShfaqGrupetEDale", varString1, varString2, varDate1, varDate2);
					dbmanObject.strSql = query;
					ds = dbmanObject.GetData("R");
					break;
				case "dbShfaqKlientetSipasEmrit" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqKlientetSipasEmrit", varString1, varString2, varDate1, varDate2));
					ds = dbmanObject.GetData("R");
					break;
			}
			return ds;
		}

		public DataSet Read(string CRUD, string varString1, string varString2, DateTime varDate1, DateTime varDate2, int varInt1)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds = null;
			switch(CRUD)
			{
				case "dbShfaqKlientetSipasEmrit" :
					dbmanObject.strSql = (dbmapObject.GetQuery("ShfaqKlientetSipasEmrit", varString1, varString2, varDate1, varDate2, varInt1));
					ds = dbmanObject.GetData("R");
					break;
			}
			return ds;
		}

		public DataSet Read(string CRUD, DateTime varDate1, DateTime varDate2, int varInt1, string varString1, string varString2)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds = null;
			switch (CRUD)
			{
				case "ShfaqDetyrimeKlientePerDataEmerKategori":
					string query = dbmapObject.GetQuery("ShfaqDetyrimeKlientePerDataEmerKategori", varDate1, 
						varDate2, varInt1, varString1, varString2);
					dbmanObject.strSql = query;
					ds = dbmanObject.GetData("R");
					break;
			}
			return ds;
		}

		public DataSet Read(string CRUD,string varString1, string varString2, int varInt1, 
			DateTime varDate1, DateTime varDate2, DateTime varDate3, string varString3)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds;
			switch(CRUD)
			{
				case "dbKrijoRezervimKlienti":
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoRezervimKlienti",varString1, varString2,
						varInt1, varDate1, varDate2, varDate3, varString3));
					ds = dbmanObject.GetData("R");
					// varString1 sherben si emri
					//varString2 si mbiemri
					//varInt1 si kapari
					// varDate1 si data fillimi
					//varDate2 si data mbarimi
					//varDate3 si data e rezervimit
					//varString3 sherben si emaili
					break;
				default:
					ds = null;
					break;				
			}
			return ds;

		}
		public DataSet Read(string CRUD, int varInt1,string varString1, string varString2, int varInt2, 
			DateTime varDate1, DateTime varDate2, DateTime varDate3)
		{
			DbMapper dbmapObject = new DbMapper();
			DbManager dbmanObject = new DbManager();
			DataSet ds;
			switch(CRUD)
			{
				case "dbKrijoRezervimGrupi":
					dbmanObject.strSql = (dbmapObject.GetQuery("KrijoRezervimGrupi",varInt1,varString1, varString2, varInt2, varDate1, varDate2, varDate3));
					ds = dbmanObject.GetData("R");
					// varInt1 sherben si ID_GRUPI
					// varString1 sherben si emri i grupit
					// varString2 sherben si agjensia e grupit
					// varInt2 si kapari
					// varDate1 sherben si date fillimi
					// varDate2 si date mbarimi
					// varDate3 si data e rezervimit
					break;
				default:
					ds = null;
					break;				
			}
			return ds;

		}
		#endregion Read
	}
}
