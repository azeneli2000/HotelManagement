using System;
using HotelManagment;
using HotelManagment.BusDatService;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment
{
	/// <summary>
	/// Summary description for InputController.
	/// </summary>
	public class InputController
	{
		#region Contructors
		public InputController()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#endregion
		
		#region KerkesaUpdate
		public int KerkesaUpdate(string idKerkesa, int varInt1)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch(idKerkesa)
			{
				
				case "FshiDetyriminPerKlient":
					b = busObject.VeprimeUpdate("FshiDetyriminPerKlient", varInt1);
					break;
				case "FshiDhome":
					b = busObject.VeprimeUpdate("FshiDhome", varInt1);
					break;
				case "FshiKategori":
					b = busObject.VeprimeUpdate("FshiKategori", varInt1);
					break;
				case "FshiShpenzim":
					b = busObject.VeprimeUpdate("FshiShpenzim", varInt1);
					break;
				case "FshiMjetIdentifikimi":
					b = busObject.VeprimeUpdate("FshiMjetIdentifikimi", varInt1);
					break;
				case "FshiLlojDetyrimi":
					b = busObject.VeprimeUpdate("FshiLlojDetyrimi", varInt1);
					break;
				case "FshiVeprim":
					b = busObject.VeprimeUpdate("FshiVeprim", varInt1);
					break;
				case "FshiShpenziminEzgjedhur":
					b = busObject.VeprimeUpdate("FshiShpenziminEzgjedhur", varInt1);
					break;
				case "FshiGrup":
					b = busObject.VeprimeUpdate("FshiGrup", varInt1);
					// varInt1 sherben si ID_grupi
					break;
				
				case "EleminoPerdorues":
					b = busObject.VeprimeUpdate("EleminoPerdorues", varInt1);
					break;
				case "KntGjendjeDhome":
					b = busObject.VeprimeUpdate("KntGjendjeDhome", varInt1);
					break;
				case "FshiLlojShpenzimi" :
					// varInt1 sherben si id i llojit te shpenzimit
					b = busObject.VeprimeUpdate("FshiLlojShpenzimi" , varInt1 );
					break;				
				case "FshiFormePagese" :
					// varInt1 sherben si id i formes se pageses
					b = busObject.VeprimeUpdate("FshiFormePagese" , varInt1 );
					break;
				default:
					b = 1;
					break;
			}
			return b;

		}
		public int KerkesaUpdate(string idKerkesa,int varInt1,int [] varInt2)
		{
			int b = 0;
			BussinessDelegate busObject = new BussinessDelegate();
			switch(idKerkesa)
			{
				case "KrijoRezervimDhomeGrupi":
					b = busObject.VeprimeUpdate("KrijoRezervimDhomeGrupi", varInt1 , varInt2);
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int KerkesaUpdate(string idKerkesa,int [] varInt1)
		{
			int b = 0;
			BussinessDelegate busObject = new BussinessDelegate();
			switch(idKerkesa)
			{
				case "PaguajDhome":
					b = busObject.VeprimeUpdate("PaguajDhome", varInt1);
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}		
		public int KerkesaUpdate(string idKerkesa,int varInt1,int varInt2)
		{
			int b = 0;
			BussinessDelegate busObject = new BussinessDelegate();
			switch(idKerkesa)
			{
				case "FshiDhomeRezervuarGrupi":
					b = busObject.VeprimeUpdate("FshiDhomeRezervuarGrupi", varInt1 , varInt2);
					break;
				case "FshiKlient":
					//varInt1 sherben si idKlienti
					//varInt2 sherben si idIdentifikimi
					b = busObject.VeprimeUpdate("FshiKlient", varInt1, varInt2);
					break;
				case "FshiRezervim":
					b = busObject.VeprimeUpdate("FshiRezervim", varInt1, varInt2);
					break;
				default:
					b = 1;
					break;

			}
			return b;
		}
		public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, int varInt3, string varString1, 
			string varString2, string varString3, string varString4, string varString5)
		{
			int b = 0;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoPerdorues":
					b = busObject.VeprimeUpdate("ModifikoPerdorues", varInt1, varInt2, varInt3, varString1, varString2,
						varString3, varString4, varString5);
					break;
			}
			return b;
		}

		public int KerkesaUpdate(string idKerkesa, int varInt1, string varString1,int varInt2,int varInt3, int varInt4)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoDhome":
					b = busObject.VeprimeUpdate("ModifikoDhome", varInt1, varString1, varInt2, varInt3,varInt4);
					// varInt1 sherben si ID_DHOMA
					// varString1 sherben si emri i dhomes
					//varInt2 sherben si karakteristike e dhomes cift ose jo
					// varInt3 sherben si ID_KATEGORIA
					// varInt4 sherben si numer krevatesh
					break;
				
				default :
					b = 1 ;
					break;
			}
			return b ;
		}
		
		public int KerkesaUpdate(string idKerkesa, int varInt1,int varInt2, string varString1, DateTime varDate,
			int varInt3, int varInt4 )
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				
				case "ModifikoShpenzim":
					b = busObject.VeprimeUpdate("ModifikoShpenzim", varInt1,varInt2, 
						varString1, varDate, varInt3, varInt4);
					// varInt1 sherben si ID_SHPENZIM
					// varInt2 sherben si ID_LLOJSHPENZIM
					// varString1 sherben si komenti i shpenzimit
					// varDate sherben si data e shpenzimit
					// varInt3 sherben si vlera e shpenzimit
					// varInt4 sherben si id e perdoruesit qe eshte i loguar ne momentin qe modifikohet shpenzimi
					// do te ruhet id e perdoruesit qe ka modifikuar shpenzimin per here te fundit
					break;
				
				default :
					b = 1 ;
					break;
			}
			return b;
		}



		public int KerkesaUpdate(string idKerkesa, DateTime varDate1)
		{
			int  b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "FshiArka" :
				{
					b = busObject.VeprimeUpdate("FshiArka", varDate1);
					break ;
				}
				
				default :
					b = 1 ;
					break;

			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa, string varString1 )
		{   
			int  b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "KrijoKategori" :
					b = busObject.VeprimeUpdate("KrijoKategori", varString1);
					break ;
				case "KrijoLlojIdentifikimi" :
					b = busObject.VeprimeUpdate("KrijoLlojIdentifikimi", varString1);
					break ;
				case "ShtoLlojShpenzimi" :
					// varString1 sherben si emri i llojit te shpenzimit
					b = busObject.VeprimeUpdate("ShtoLlojShpenzimi" , varString1 );
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		/// <summary>
		/// Sherben per te krijuar ose modifikuar nje lloj detyrimi, per te modifikuar nje lloj kategorie
		/// </summary>
		/// <param name="idKerkesa">kerkesa ne baze te se ciles do te kryhet nje lloj veprimi</param>
		/// <param name="varString1">emri i llojit te detyrimit qe do te shtohet; emri i ri i kategorise; emri
		///  i ri i llojit te identifikimit</param>
		/// <param name="varInt1">cmimi i llojit te detyrimit; ID_KATEGORIA; ID_LLOJI per identifikimin</param>
		/// <returns></returns>
		public int KerkesaUpdate (string idKerkesa, string varString1, int varInt1)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "KrijoLlojDetyrim":
					b = busObject.VeprimeUpdate("KrijoLlojDetyrimi", varString1, varInt1);
					// varString1 sherben si emri i llojit te detyrimit
					// varInt1 sherben si cmimi i llojit te detyrimit
					break;
				case "ModifikoKategori":
					b = busObject.VeprimeUpdate("ModifikoKategori", varString1, varInt1);
					// varString eshte emri i ri i kategorise
					// varInt eshte ID_KATEGORIA
					break;	
				case "ModifikoLlojIdentifikimi":
					b = busObject.VeprimeUpdate("ModifikoLlojIdentifikimi", varString1, varInt1);
					break;
				case "ModifikoLlojShpenzimi":
					b = busObject.VeprimeUpdate("ModifikoLlojShpenzimi", varString1, varInt1);
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate (string idKerkesa, string varString1, float varFloat)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				
				default :
					b = 1 ;
					break;
			}
			return b ;
		}
		
		public int KerkesaUpdate(string idKerkesa,int varInt,string varString,string varString1)
		{
			int b = 0;
			BussinessDelegate busObject = new BussinessDelegate();
			switch(idKerkesa)
			{
				case "ModifikoFormePagese":
					b = busObject.VeprimeUpdate("ModifikoFormePagese",varString,varString1,varInt);
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int KerkesaUpdate(string idKerkesa,int varInt,string varString1,string varString2, string varString3)
		{
			int b = 0;
			BussinessDelegate busObject = new BussinessDelegate();
			switch(idKerkesa)
			{
				case "ModifikoGrup":
					b = busObject.VeprimeUpdate("ModifikoGrup",varInt, varString1,varString2,varString3);
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int KerkesaUpdate (string idKerkesa, DateTime varDate , int varInt)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "HidhNeArke":
					b = busObject.VeprimeUpdate("HidhNeArke", varDate, varInt);
					break;
				case "NxirrNgaArka":
					b = busObject.VeprimeUpdate("NxirrArke", varDate, varInt);
					break;
				case  "ModifikoDatenEdaljes" :
					b = busObject.VeprimeUpdate("ModifikoDatenEdaljes", varDate, varInt);
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}
		public int KerkesaUpdate (string idKerkesa, DateTime varDate , int varInt1, int varInt2)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "HidhNeArke":
					//varInt2 sherben si id e perdoruesit qe ka kryer transaksionin
					b = busObject.VeprimeUpdate("HidhNeArke", varDate, varInt1, varInt2);
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}
		public int KerkesaUpdate(string idKerkesa, int varInt1, string varString1, int varInt2)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoLlojDetyrimi":
					b = busObject.VeprimeUpdate("ModifikoLlojDetyrimi", varInt1, varString1, varInt2);
					//varInt1 sherben si ID_LLOJDETYRIMI 
					//varString1 sherben si emri i llojit te detyrimit
					// varInt2 sherben si cmimi i llojit te detyrimit
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, int varInt3)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "FshiKlientNgaRezervimi" :
					b = busObject.VeprimeUpdate("FshiKlientNgaRezervimi", varInt1, varInt2, varInt3);
					// varInt1 sherben si idKlienti
					// varInt2 sherben si idIdentifikimi
					// varInt3 sherben si idRezervimi
					break;
				case "NxirrKlientiNgaDhoma" :
					b = busObject.VeprimeUpdate("NxirrKlientiNgaDhoma", varInt1, varInt2, varInt3);
					// varInt1 sherben si idKlienti
					// varInt2 sherben si skonto
					// varInt3 sherben si gjoba
					break;
				case "FshiKlientGrupi":
					//varInt1 sherben si idKlienti
					//varInt2 sherben si idIdentifikimi
					//varInt3 sherben si idGrupi
					b = busObject.VeprimeUpdate("FshiKlientGrupi", varInt1, varInt2, varInt3);
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, int varInt3, int varInt4)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "FshiKlientGrupiNgaRezervimi":
					b = busObject.VeprimeUpdate("FshiKlientGrupiNgaRezervimi", varInt1, varInt2, varInt3, varInt4);
					//varInt1 idKlienti
					//varInt2 idGrupi
					//varInt3 idIdentifikimi
					break;
				case "FshiVeprimKlient":
					b = busObject.VeprimeUpdate("FshiVeprimKlienti", varInt1, varInt2, varInt3);
					//varInt1 idKlienti
					//varInt2 idGrupi
					//varInt3 idIdentifikimi
					break;
				case "NxirrKlientiNgaDhoma" :
					b = busObject.VeprimeUpdate("NxirrKlientiNgaDhoma", varInt1, varInt2, varInt3);
					// varInt1 sherben si idKlienti
					// varInt2 sherben si skonto
					// varInt3 sherben si gjoba
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, 
			int varInt3, int varInt4, int varInt5, int varInt6, DateTime varDate1, DateTime varDate2)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "FshiPergjegjes":
					//varInt1 idKlienti
					//varInt2 idIdentifikimi
					//varInt3 pergjegjes_ri
					//varInt4 kapar
					//varInt5 skonto
					//varInt6 gjobe
					//varDate si date per hedhjen e kaparit ne arke
					//varDate si date per hedhjen e pageses ne arke
					b = busObject.VeprimeUpdate("FshiPergjegjes", varInt1, varInt2, 
						varInt3, varInt4, varInt5, varInt6, varDate1, varDate2);
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, 
			int varInt3, int varInt4, int varInt5, int varInt6, DateTime varDate1, bool dorezuar,int varInt7)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoSkontoKaparGjobe":
					//varInt1 kapari
					//varInt2 skonto
					//varInt3 gjoba
					//varInt4 pergjegjes
					//varInt5 pagesa
					//varInt6 idFormaPagesa
					//varDate1 sherben si data e dorezimit te dhomes kur behet edhe hedhja e pageses ne arke
					//varInt7 sherben si id e Perdoruesit i cili eshte loguar
					b = busObject.VeprimeUpdate("ModifikoSkontoKaparGjobe", varInt1, varInt2, varInt3, 
						varInt4, varInt5, varInt6, varDate1, dorezuar, varInt7);
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, 
			int varInt3, int varInt4, int varInt5, int varInt6, DateTime varDate1,
			bool dorezuar, int varInt7, int varInt8)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoSkontoKaparGjobePerHyrjetMeRezervim":
					//varInt1 kapari i hedhur realisht ne arke
					//varInt2 skonto
					//varInt3 gjoba
					//varInt4 pergjegjes
					//varInt5 pagesa
					//varInt6 idFormaPagesa
					//varDate1 sherben si data e dorezimit te dhomes kur behet edhe hedhja e pageses ne arke
					// dorezuar tregon nqs dhoma eshte dorezuar ose jo
					//varInt7 shernben si kapari Fiktiv qe i vendoset klientit
					//varInt8 sherben si id e perdoruesit i cili eshte loguar.
					b = busObject.VeprimeUpdate("ModifikoSkontoKaparGjobePerHyrjetMeRezervim", varInt1, varInt2, varInt3, 
						varInt4, varInt5, varInt6, varDate1, dorezuar, varInt7, varInt8);
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, int varInt3,
			int varInt4, int varInt5, int varInt6, int varInt7, DateTime varDate1, DateTime varDate2)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				
				
				case "FshiPergjegjesGrupi":
					//varInt1 idKlienti
					//varInt2 idIdentifikimi
					//varInt3 pergjegjes_ri
					//varInt4 kapar
					//varInt5 skonto
					//varInt6 gjobe
					//varInt7 idGrupi
					//varDate1 data  e hedhjes se kaparit per pergjegjesin e ri 
					b = busObject.VeprimeUpdate("FshiPergjegjesGrupi", varInt1, varInt2, 
						varInt3, varInt4, varInt5, varInt6, varInt7, varDate1, varDate2);
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}
		public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, int varInt3,DateTime varDate)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				
				case "KrijoDetyrimPerKlient":
					b = busObject.VeprimeUpdate("KrijoDetyrimPerKlient", varInt1, varInt2, varInt3, varDate);
					break;
		
				case "ModifikoDetyriminPerKlient":
					b = busObject.VeprimeUpdate("ModifikoDetyriminPerKlient", varInt1, varInt2, varInt3,varDate);
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa, int varInt2, int varInt3,int varInt4, 
			int varInt5, int[] vektor, DateTime varDate, bool varBool, int varInt6, int varInt7)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				
				case "DorezoDhome":
					//varInt7 sherben si id e Perdoruesit qe ka bere transaksionin
					b = busObject.VeprimeUpdate("DorezoDhome",  varInt2, varInt3, 
						varInt4, varInt5, vektor,  varDate, varBool, varInt6, varInt7);
					break;
				default:
					b = 1;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa,  int varInt1, DateTime varDate1, 
			int varInt2, string varString1, int varInt3)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "KrijoShpenzim" :
					// varInt1 sherben si id e llojit qe i perket ky shpenzim
					// varString1 sherben si koment per shpenzimin
					// varDate1 sherben si data e shpenzimit
					// varInt2 sherben si sasia e shpenzimit
					// varInt3 sherben si id e perdoruesit qe eshte loguar gjate hedhjes se shpenzimit
					b = busObject.VeprimeUpdate("KrijoShpenzim", varInt1, varDate1, varInt2, varString1, varInt3) ;
					break ;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}


		public int KerkesaUpdate(string idKerkesa, string varString1, string varString2, 
			int varInt1, DateTime varDate1, DateTime varDate2,DateTime varDate3, 
			int varInt2,int varInt3,int varInt4, int varInt5, string varString3, int varInt6)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoRezerviminPerKlient" :
					b = busObject.VeprimeUpdate("ModifikoRezervimKlienti", varString1, varString2, 
						varInt1, varDate1, varDate2,varDate3, varInt2,varInt3,varInt4,varInt5, varString3, varInt6);
					// varString1 sherben si emer klienti
					// varString2 sherben si mbiemer klienti
					// varInt1 sherben si kapari
					// varDate1 sherben si data e fillimit
					// varDate2 sherben si data e mbarimit
					//varInt2 sherben si ID_REZERVIMI
					// varInt3 sherben si ID_DHOMA ere 
					//varInt4 sherben si ID_DHOMA e vjeter
					//varint5 sherben si idFormaPagesa
					//varString3 sherben si adresa e emailit
					//varInt6 sherben si id e perdoruesit qe eshte loguar
					break ;
				
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa,int varInt1,int varInt2,
			int varInt3, DateTime varDate1, DateTime varDate2, DateTime varDate3,
			int varInt4, int varInt5, int varInt6, int varInt7)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoRezerviminPerGrup" :
					b = busObject.VeprimeUpdate("ModifikoRezervimGrupi", varInt1,varInt2,varInt3,
						varDate1, varDate2,varDate3, varInt4, varInt5, varInt6, varInt7);
					// varInt1 sherben si idGrupi
					// varInt2 sherben si kapari
					//varInt3 sherben si idRezervimi
					// varDate1 sherben si data e fillimit
					// varDate2 sherben si data e mbarimit
					//varDate3 sherben si data e rezervimit
					// varInt2 sherben si ID_DHOMA
					// varInt4 sherben si idFormaPagesa
					//varInt5 sherben si kapari per grupin
					//varInt6 sherben si id per pergjegjesin e grupit
					//varInt7 sherben si id perdoruesi
					break ;
				
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, DateTime varDate1, DateTime varDate2)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "KrijoCmimPerDhome" :
					b = busObject.VeprimeUpdate("KrijoCmimPerDhome", varInt1, varInt2, varDate1, varDate2) ;
					break ;
				
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa, int[] varInt1, int varInt2, DateTime varDate1)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "DorezoDhomePerGrup" :
					b = busObject.VeprimeUpdate("DorezoDhomePerGrup", varInt1, varInt2, varDate1);
					// varInt sherben si idDhomat per grupin
					// varInt2 sherben si pagesa
					// varDate1 sherben si date dalje
					break ;
				
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa, int varInt1,int varInt2, DateTime varDate1, DateTime varDate2, int varInt3)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "FshiCmimiPerDhomen":
					
					b = busObject.VeprimeUpdate("FshiCmimiPerDhomen", varInt1, varInt2,varDate1, varDate2, varInt3);
					//varInt1 sherben si ID_DHOMA
					//varInt2 sherben si ID_CMIMI
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}
		public int KerkesaUpdate(string idKerkesa, int varInt1,int varInt2, DateTime varDate1, DateTime varDate2, 
			int varInt3, DateTime varDate3, DateTime varDate4)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoCmimiPerDhomen" :
					b = busObject.VeprimeUpdate("ModifikoCmimiPerDhomen", varInt1,varInt2, varDate1, 
						varDate2, varInt3,varDate3,varDate4);
					
					// varInt2 sherben si ID_CMIMI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt3 sherben si cmimi
					// varDate3 sherben si data e fillimit te vjeter per cmimin
					// varDate4 sherben si data e mbarimit te vjeter per cmimin
					break ;				
				default :
					b = 1 ;
					break;
			}
			return b ;
		}
		public int KerkesaUpdate(string idKerkesa, int varInt1, string varString1,int varInt2, int varInt3 )
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
								
				case "KrijoDhome":
				{
					b = busObject.VeprimeUpdate("KrijoDhome",varInt1, varString1, varInt2, varInt3);
					// varString1 sherben per emrin e dhomes
					// varInt1 sheben per kategorine e dhomes
					// varInt2 sherben per cmimin e dhomes
					break;
				}
				default :
					b = 1 ;
					break;
			}
			return b;
		}
		


		

		public int KerkesaUpdate(string idKerkesa,int varInt, int varInt1,int[] varVektoriInt1, 
			DateTime varDate1, DateTime varDate2,DateTime varDate3, int varInt2, int varInt3)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{	
				case "KrijoRezervimGrupi" :
					//varInt sherben si idGrupi
					// varInt1 sherben si kapari
					// varVektoriInt1 sherben si ID_DHOMAT  e rezervuara
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varDate3 sherben si data e rezervimit
					// varInt2 sherben si idFormaPagesa
					// varInt3 sherben si ide perdoruesit qe eshte loguar
					b = busObject.VeprimeUpdate("KrijoRezervimGrupi", varInt, varInt1, varVektoriInt1, 
						varDate1, varDate2,varDate3,varInt2, varInt3);
					break ;
				
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa, string varString1, string varString2, DateTime varDate1,
			int varInt1, string varString3, string varString4, string varString5, string varString6, string varString7,
			int varInt2, int varInt3, DateTime varDate2, DateTime varDate3)
		{
			//TODO: Add method logic here
			int b = 0;
			return b;
		}

		public int KerkesaUpdate(string idKerkesa,string varString1,string varString2, int varInt1,
			int varInt2, DateTime varDate1, DateTime varDate2,DateTime varDate3, int varInt4, string varString3,
			int varInt5)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{	
				case "KrijoRezervimKlienti" :
					// varString1 sherben si emer klienti
					// varString2 sherben si mbiemer klienti
					// varInt1 sherben si kapari
					// varInt2 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate 2 sherben si date mbarimi
					// varDate3 sherben si date rezervimi
					// varInt3 sherben si idFormaPagesa
					// varString3 sherben si adresa e emailit per individin
					// varInt5 sherben si id e perdoruesit qe eshte loguar
					b = busObject.VeprimeUpdate("KrijoRezervimKlienti", varString1,  varString2, varInt1, 
						varInt2,  varDate1, varDate2,varDate3, varInt4, varString3, varInt5) ;
					break ;
				
				default :
					b = 1 ;
					break;
			}
			return b ;
		}


		public int KerkesaUpdate(string idKerkesa, string varString1, string varString2)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoLlojIdentifikimi" :
					b = busObject.VeprimeUpdate("ModifikoLlojIdentifikimi", varString1, varString2);
					break;
				case "ShtoFormePagese":
					b = busObject.VeprimeUpdate("ShtoFormePagese",  varString1, varString2);
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa, string varString1, string varString2, string varString3)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "KrijoGrup":
					b = busObject.VeprimeUpdate("KrijoGrup",varString1,varString2,varString3);
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}
		public DataSet KerkesaRead (string idKerkesa, DateTime varDate1, DateTime varDate2)
		{
			DataSet ds = null;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqBilanci":
					ds = busObject.VeprimeRead("ShfaqBilanci", varDate1, varDate2);
					break;
				case "ShfaqRezervimetPerKlientPerDatatEdhena":
					ds = busObject.VeprimeRead("ShfaqRezervimetPerKlientPerDatenEdhene", varDate1, varDate2);
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi 
					break;
				case "ShfaqShpenzimetMidisDatave":
					//varDate1 sherben si date e fillimit te kerkimit per shpenzimet
					//varDate2 sherben si date e fundit e kerkimit per shpenzimet
					ds = busObject.VeprimeRead("ShfaqShpenzimetMidisDatave", varDate1, varDate2);
					break;
				case "ShfaqDetyrimeKlientePerData":
					ds = busObject.VeprimeRead("ShfaqDetyrimeKlientePerData", varDate1, varDate2);
					break;
				default :
					ds = null ;
					break;
			}
			return ds ;
		}

		public int KerkesaUpdate (string idKerkesa, string varString1, string varString2, string varString3,
			string varString4, int varInt1)
		{
			int b = 0;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShtoPerdorues":
					// varString1 - emri
					// varString2 - mbiemri
					// varString3 - username
					// varString4 - password
					// varInt1 - RolID
					b = busObject.VeprimeUpdate("ShtoPerdorues", varString1, varString2, varString3, varString4, varInt1);
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int KerkesaUpdate(string idKerkesa,string varString1,string varString2,DateTime varDate1,
			int varInt1,string varString3, string varString4, string varString5, string varString6,
			string varString7, int varInt2,int varInt3, DateTime varDate2, DateTime varDate3, int varInt4,DateTime varDate4,
			string varString8,string varString9,int varInt5, int varInt6, int varInt7, int varInt8 )
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{	
				case "FutRezervimKlientiNeDhome" :
					// varString1 sherben si emer klienti
					// varString2 sherben si mbiemer klienti
					// varDate1 sherben si datelindja e klientit
					// varInt1 sherben si ID_LLOJIDENTIFIKIMI
					// varString3 shereben si numer identifikimi
					// varString4 sherben si adrese
					// varString5 sherben si numer telefoni
					// varString6 sherben si targe makine
					// varString7 sherben si adrese imaili
					// varInt2 sherben si ID_DHOMA
					// varInt3 sherben si kapari per dhomen 
					// varDate2 sherben si date fillimi
					// varDate3 sherben si date mbarimi 
					// varInt4 sherben si idRezervimi per te fshire rezervimin pasi futet klienti
					// varDate4 sherben si data e rezervimit(hidhet kapari ne kete date )
					// varString8 sherben si vendlindja
					// varString9 sherben si shtetesia
					// varInt5 sherben si kapari i rezervimit
					// varInt6 sherben si idFormaPagesa
					// varInt7 sherben si i per te treguar nqs klienti qe po futet eshte pergjegjes 
					// varInt8 sherben si id e Perdoruesit qe ka bere transaksionin
					b = busObject.VeprimeUpdate("FutRezervimKlientiNeDhome", varString1,  varString2, 
						varDate1,  varInt1, varString3, varString4, varString5, varString6, varString7, 
						varInt2, varInt3,  varDate2, varDate3, varInt4,varDate4, varString8, varString9,
						varInt5, varInt6, varInt7, varInt8);
					break ;
				
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		
		public int KerkesaUpdate(string idKerkesa, string varString1,
			string varString2, DateTime varDate1, int varInt1,string varString3, string varString4,
			string varString5, string varString6, string varString7, int varInt2,int varInt3,
			DateTime varDate2, DateTime varDate3,int varInt4,int varInt5,DateTime varDate4,
			string varString8, string varString9, int varInt6, int varInt7, int varInt8, bool varBool, int varInt9)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{	
				case "FutRezervimGrupiNeDhome" :
					// varString1 sherben si emer
					// varString2 sherben si mbiemer
					// varDate1 sherben si datelindja
					// varInt1 sherben si idIdentif
					// varString3 sherben si nrIdentif
					// varString4 sherben si adresa
					// varString5 sherben si tel
					// varString6 sherben si targa
					// varString7 sherben si email
					// varInt2 sherben si idDhoma
					// varInt3 sherben si kapari
					// varDate2 sherben si dtFillimi
					// varDate3 sherben si dtMbarimi
					// varInt4 sherben si idGrupi
					// varInt5 sherben si idRezervimi
					// varDate4 sherben si datakapari
					// varString8 sherben si vendlindja
					// varString9 sherben si shtetesia
					// varInt6 sherben si kapari i rezervimit
					// varInt7 sherben si idFormaPagesa
					// varInt8 sherben si i per te treguar i sati eshte klienti qe po futet me ane te rezervimit
					// varBool sherben per te treguar nqs i eshte hedhur ose jo kapari grupit
					// varInt9 sherben si id e perdoruesit qe ka bere transaksionin ne arke
					b = busObject.VeprimeUpdate("FutRezervimGrupiNeDhome", varString1,  varString2,
						varDate1,  varInt1, varString3, varString4, varString5,
						varString6, varString7,  varInt2, varInt3, 
						varDate2, varDate3,varInt4,varInt5,varDate4, varString8, varString9,
						varInt6, varInt7, varInt8, varBool, varInt9);
					
					break ;
				
				default :
					b = 1 ;
					break;
			}
			return b ;
		}

		public int KerkesaUpdate(string idKerkesa,string varString1,string varString2,DateTime varDate1,
			int varInt1,string varString3, string varString4, string varString5, string varString6,
			string varString7, int varInt2, DateTime varDate2, DateTime varDate3,
			int varInt3,DateTime varDate4, string varString8, string varString9, int varInt4, int varInt5)
		{
			int b = 0 ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{	
				case "FutKlientNeDhome" :
					b = busObject.VeprimeUpdate("FutKlientiNeDhome", varString1,  varString2, varDate1,
						varInt1, varString3, varString4, varString5, varString6, varString7,  varInt2, 
						varDate2, varDate3,varInt3,varDate4, varString8, varString9, varInt4, varInt5);
					// varString1 sherben si emer klienti
					// varString2 sherben si mbiemer klienti
					// varDate1 sherben si datelindja e klientit
					// varInt1 sherben si ID_LLOJIDENTIFIKIMI
					// varString3 shereben si numer identifikimi
					// varString4 sherben si adrese
					// varString5 sherben si numer telefoni
					// varString6 sherben si targe makine
					// varString7 sherben si adrese imaili
					// varInt2 sherben si ID_DHOMA
					// varDate2 sherben si date fillimi
					// varDate3 sherben si date mbarimi
					// varInt3 sherben si kapari
					// varDate4 sherben si data kapari
					// varString8 sherben si vendlindja
					// varString9 sherben si shtetesia
					// varInt4 sherben si forma me te cilen do te paguhet 
					// varInt5 sherben si username i perdoruesit i cili eshte loguar
					break;
				default :
					b = 1 ;
					break;
			}
			return b ;
		}
        

		public int KerkesaUpdate(string idKerkesa,int varInt,string varString3,string varString4,
			DateTime varDate,int varInt1,string varString5,string varString6,string varString7,
			string varString8,string varString9,int varInt2,DateTime varDate1,DateTime varDate2,
			int varInt3,DateTime varDate4, string varString10, string varString11, int varInt4, int varInt5)
		{
			int b = 0;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "FutKlientGrupiNeDhome":
					b = busObject.VeprimeUpdate("FutKlientGrupiNeDhome",varInt,varString3,
						varString4,varDate1,varInt1,varString5,varString6,varString7,varString8,
						varString9,varInt2,varDate1,varDate2,varInt3,varDate4, varString10,
						varString11, varInt4, varInt5);
					
					// varString1 sherben si emer grupi
					// varString2 sherben si agjensia
					// varString3 sherben si emeri
					// varString4 sherben si mbiemri
					// varDate1 sherben si datelindja e klientit
					// varInt1 sherben si ID_LLOJIDENTIFIKIMI
					// varString5 shereben si numer identifikimi
					// varString6 sherben si adrese
					// varString7 sherben si numer telefoni
					// varString8 sherben si targe makine
					// varString9 sherben si adrese imaili
					// varInt2 sherben si ID_DHOMA
					// varDate2 sherben si date fillimi
					// varDate3 sherben si date mbarimi
					// varInt3 sherben si kapari
					// varDate4 sherben si data kapari
					// varString10 sherben si vendlindja
					// varString11 sherben si shtetesia
					// varInt4 sherben si idFormaPagesa 
					// varInt5 sherben si id e perdoruesit qe ka bere transaksionin ne arke
					break;

			}
			return b;
		}
	
		public int KerkesaUpdate(string idKerkesa,int varInt,string varString3,string varString4,
			DateTime varDate,int varInt1,string varString5,string varString6,string varString7,
			string varString8,string varString9,int varInt2,DateTime varDate1,DateTime varDate2,
			int varInt3,DateTime varDate4, string varString10, string varString11, int varInt4,
			int varInt5, int varInt6)
		{
			int b = 0;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "FutKlientGrupiNeDhome":
					b = busObject.VeprimeUpdate("FutKlientGrupiNeDhome",varInt,varString3,
						varString4,varDate1,varInt1,varString5,varString6,varString7,varString8,
						varString9,varInt2,varDate1,varDate2,varInt3,varDate4, varString10,
						varString11, varInt4, varInt5, varInt6);
					
					// varString1 sherben si emer grupi
					// varString2 sherben si agjensia
					// varString3 sherben si emeri
					// varString4 sherben si mbiemri
					// varDate1 sherben si datelindja e klientit
					// varInt1 sherben si ID_LLOJIDENTIFIKIMI
					// varString5 shereben si numer identifikimi
					// varString6 sherben si adrese
					// varString7 sherben si numer telefoni
					// varString8 sherben si targe makine
					// varString9 sherben si adrese imaili
					// varInt2 sherben si ID_DHOMA
					// varDate2 sherben si date fillimi
					// varDate3 sherben si date mbarimi
					// varInt3 sherben si kapari
					// varDate4 sherben si data kapari
					// varString10 sherben si vendlindja
					// varString11 sherben si shtetesia
					// varInt4 sherben si idFormaPagesa 
					// varInt5 sherben si idRezervimi
					// varInt6 sherben si id e perdoruesit qe ka bere transaksionin ne arke
					break;

			}
			return b;
		}
		public int KerkesaUpdate(string idKerkesa,string varString1,string varString2,DateTime varDate1,
			string varString3,string varString4,string varString5,string varString6,
			DateTime varDate2,DateTime varDate3,int varInt1,string varString7,
			int varInt2,int varInt3, string varString8, string varString9)
			
		{
			int b = 0;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoTeDhenaKlienti":
					b = busObject.VeprimeUpdate("ModifikoTeDhenaKlienti",varString1
						,varString2,varDate1,varString3,varString4,varString5,varString6
						,varDate2,varDate3, varInt1, varString7,
						varInt2, varInt3, varString8, varString9);
					break;
				default:
					b = 1;
					break;

			}
			return b;
		}
		public int KerkesaUpdate(string idKerkesa,string varString1,string varString2,DateTime varDate1,
			string varString3,string varString4,string varString5,string varString6,
			DateTime varDate2,DateTime varDate3,int varInt1,string varString7,
			int varInt2,int varInt3, string varString8, string varString9, int varInt4)
			
		{
			int b = 0;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoTeDhenaPergjegjes":
					//varInt4 idPerdoruesi
					b = busObject.VeprimeUpdate("ModifikoTeDhenaPergjegjes",varString1
						,varString2,varDate1,varString3,varString4,varString5,varString6
						,varDate2,varDate3, varInt1, varString7,
						varInt2, varInt3, varString8, varString9, varInt4);
					break;
				default:
					b = 1;
					break;

			}
			return b;
		}
		public int KerkesaUpdate(string idKerkesa,string varString1,string varString2,DateTime varDate1,
			string varString3,string varString4,string varString5,string varString6,
			DateTime varDate2,DateTime varDate3,int varInt1,string varString7,
			int varInt2,int varInt3, int varInt4, string varString8, string varString9)
			
		{
			int b = 0;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoTeDhenaKlientiGrupi":
					//varInt4 sherben si idGrupi
					b = busObject.VeprimeUpdate("ModifikoTeDhenaKlientiGrupi",varString1
						,varString2,varDate1,varString3,varString4,varString5,varString6
						,varDate2,varDate3, varInt1, varString7,
						varInt2, varInt3, varInt4,varString8, varString9);
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int KerkesaUpdate(string idKerkesa,string varString1,string varString2,DateTime varDate1,
			string varString3,string varString4,string varString5,string varString6,
			DateTime varDate2,DateTime varDate3,int varInt1,string varString7,
			int varInt2,int varInt3, int varInt4, string varString8, string varString9, int varInt5)
			
		{
			int b = 0;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoTeDhenaPergjegjesGrupi":
					//varInt4 sherben si idGrupi
					//varInt5 idPerdoruesi
					b = busObject.VeprimeUpdate("ModifikoTeDhenaPergjegjesGrupi",varString1
						,varString2,varDate1,varString3,varString4,varString5,varString6
						,varDate2,varDate3, varInt1, varString7,
						varInt2, varInt3, varInt4, varString8, varString9, varInt5);
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int KerkesaUpdate(string idKerkesa,string varString1,string varString2,DateTime varDate1,
			string varString3,string varString4,string varString5,string varString6,
			DateTime varDate2,DateTime varDate3,int varInt1,string varString7,
			int varInt2,int varInt3, int varInt4, int varInt5, int varInt6, int varInt7, DateTime varDate4,
			string varString8, string varString9, int varInt8)
			
		{
			int b = -1;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoTeDhenaPergjegjes":
					//varInt8 idPerdoruesi
					b = busObject.VeprimeUpdate("ModifikoTeDhenaPergjegjes",varString1
						,varString2,varDate1,varString3,varString4,varString5,varString6
						,varDate2,varDate3, varInt1, varString7,
						varInt2, varInt3, varInt4, varInt5, varInt6, varInt7, varDate4, 
						varString8, varString9, varInt8);
					break;
				default:
					b = -1;
					break;
			}
			return b;
		}
		
		public int KerkesaUpdate(string idKerkesa,string varString1,string varString2,DateTime varDate1,
			string varString3,string varString4,string varString5,string varString6,
			DateTime varDate2,DateTime varDate3,int varInt1,string varString7,
			int varInt2,int varInt3, int varInt4, int varInt5, int varInt6, 
			int varInt7, DateTime varDate4, int varInt8, string varString8, string varString9, int varInt9)
			
		{
			int b = 0;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoTeDhenaPergjegjesGrupi":
					//varInt7 sherben si idGrupi
					//varInt9 idPerdoruesi
					b = busObject.VeprimeUpdate("ModifikoTeDhenaPergjegjesGrupi",varString1
						,varString2,varDate1,varString3,varString4,varString5,varString6
						,varDate2,varDate3, varInt1, varString7,
						varInt2, varInt3, varInt4, varInt5, varInt6, varInt7, varDate4, varInt8,
						varString8, varString9, varInt9);
					break;
				default:
					b = 1;
					break;

			}
			return b;
		}


		#endregion 
		
		#region KerkesaRead
		public DataSet KerkesaRead (string idKerkesa, int varInt1, DateTime varDate1, DateTime varDate2)
		{
			DataSet ds = null;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "DhomatEZenaPerDatatPaRezervim":
					ds = busObject.VeprimeRead("DhomatEZenaPerDatatPaRezervim", varInt1, varDate1, varDate2);
					break;
				case "RezervimetPerDatatDheGrupin":
					// varInt1 sherben si ID_GRUPI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi 
					ds = busObject.VeprimeRead("RezervimetPerDatatDheGrupin", varInt1, varDate1, varDate2);
					break;				
				case "NrDetyrimeshPerKlientJashteDatave":
					// varInt1 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi 
					ds = busObject.VeprimeRead("NrDetyrimeshPerKlientJashteDatave", varInt1, varDate1, varDate2);
					break;
				case "NrKlienteNeDhomeNeGrup":
					// varInt1 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi 
					ds = busObject.VeprimeRead("NrKlienteNeDhomeNeGrup", varInt1, varDate1, varDate2);
					break;
				case "NumerKlienteshPerDateGrup":
					// varInt1 sherben si ID_GRUPI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi 
					ds = busObject.VeprimeRead("NumerKlienteshPerDateGrup", varInt1, varDate1, varDate2);
					break;
				case "NumerKlienteshPerDateDhoma":
					// varInt1 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi 
					ds = busObject.VeprimeRead("NumerKlienteshPerDateDhoma", varInt1, varDate1, varDate2);
					break;
				case "ShfaqCmimPerDhomenDheDatatEdhena":
					// varInt1 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi 
					ds = busObject.VeprimeRead("ShfaqCmimPerDhomenDheDatatEdhena", varInt1, varDate1, varDate2);
					break;
				case "ShfaqKlientPerDhomePerDatat":
					ds = busObject.VeprimeRead("ShfaqKlientPerDhomePerDatat", varInt1, varDate1, varDate2);
					// varInt1 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi 
					break;
				case "ShfaqTeDhenaGrupiPerDatat":
					// varInt1 sherben si ID_grupi
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi 
					ds = busObject.VeprimeRead("ShfaqTeDhenaGrupiPerDatat", varInt1, varDate1, varDate2);
					break;
				case "ShfaqDhomatEliraPerDatatPerKategorine":
					//varInt1 sherben si ID_KATEGORIA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi 
					ds = busObject.VeprimeRead("ShfaqDhomatEliraPerDatatPerKategorine", varInt1, varDate1, varDate2);
					break;
				case "ShfaqDhomatPlotesishtTeLiraPerDatatPerKategorine":
					//varInt1 sherben si ID_KATEGORIA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi 
					ds = busObject.VeprimeRead("ShfaqDhomatPlotesishtTeLiraPerDatatPerKategorine", varInt1, varDate1, varDate2);
					break;
				case "ShfaqDetyrimeKlientePerKategori":
					ds = busObject.VeprimeRead("ShfaqDetyrimeKlientePerKategori", varInt1, varDate1, varDate2);
					break;
				case "ShfaqVeprimetPerDatat":
					//varInt1 = 1 per hyrjet e vlefshme
					//varInt1 = 0 per hyrjet jo te vlefshme
					//varint1 = -1 pa kriter
					//varDate1 sherben si date e fillimit te kerkimit per veprimet
					//varDate2 sherben si date e fundit e kerkimit per veprimet
					ds = busObject.VeprimeRead("ShfaqVeprimetPerDatat", varInt1, varDate1, varDate2);
					break;
				case "ShfaqVeprimetNeGrupPerDatat":
					ds = busObject.VeprimeRead("ShfaqVeprimetNeGrupPerDatat", varInt1, varDate1, varDate2);
					break;
				default :
					ds = null ;
					break;
			}
			return ds ;
		}

		public DataSet KerkesaRead (string idKerkesa, int varInt1, DateTime varDate1, DateTime varDate2, int varInt2)
		{
			DataSet ds = null;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{	
				case "ShfaqVeprimetPerGrupinPaRezervim":
					// varInt1 sherben si ID_GRUPI
					// varInt2 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varint3 sherben si idklienti
					ds = busObject.VeprimeRead("ShfaqVeprimetPerGrupinPaRezervim",  varInt1, varDate1, varDate2, varInt2);
					break;
				case "RezervimetPerDatatDheGrupin":
					// varInt1 sherben si ID_GRUPI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi 
					ds = busObject.VeprimeRead("RezervimetPerDatatDheGrupin", varInt1, varDate1, varDate2, varInt2);
					break;		
				case "ShfaqDhomatPlotesishtTeLiraPerDatatPerKategorinePerModifikim":
					// varInt1 sherben si ID_KATEGORIA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt2 sherben si id e rezervimit qe po modifikohet
					ds = busObject.VeprimeRead("ShfaqDhomatPlotesishtTeLiraPerDatatPerKategorinePerModifikim", varInt1, varDate1, varDate2, varInt2);
					break;
				case "ShfaqDhomatEliraPerDateKategoriPerModifikim":
					// varInt1 sherben si ID_KATEGORIA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt2 sherben si id e klientit qe po modifikohet
					ds = busObject.VeprimeRead("ShfaqDhomatEliraPerDateKategoriPerModifikim", varInt1, varDate1, varDate2, varInt2);
					break;
				case "NumerKlienteshPerDateDhoma":
					// varInt1 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt2 sherben si id e klientit qe po modifikohet
					ds = busObject.VeprimeRead("NumerKlienteshPerDateDhoma", varInt1, varDate1, varDate2, varInt2);
					break;
				case "nrKlienteNeDhomePerGrup":
					// varInt1 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt2 sherben si ID_GRUPI
					ds = busObject.VeprimeRead("nrKlienteNeDhomePerGrup", varInt1, varDate1, varDate2, varInt2);
					break;
				case "NumerKlienteshPerDateGrupPerModifikim":
					// varInt1 sherben si ID_GRUPI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt2 sherben si ID_KLIENTI
					ds = busObject.VeprimeRead("NumerKlienteshPerDateGrupPerModifikim", varInt1, varDate1, varDate2, varInt2);
					break;
				default :
					ds = null ;
					break;
			}
			return ds ;
		}

		public DataSet KerkesaRead (string idKerkesa, int[] varInt1)
		{
			DataSet ds = null;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqDetyrimePerKlientetPerDhomen" :
					ds = busObject.VeprimeRead("ShfaqDetyrimePerKlientetPerDhomen", varInt1);
					// varInt1 ruan id e klienteve
					break;
				case "ShfaqDetyrimePerKlientetEkstra" :
					ds = busObject.VeprimeRead("ShfaqDetyrimePerKlientetEkstra", varInt1);
					// varInt1 ruan id e klienteve
					break;
				case "ShfaqDetyrimetPerDhomat" :
					ds = busObject.VeprimeRead("ShfaqDetyrimetPerDhomat", varInt1);
					// varInt1 ruan id e dhomave
					break;
				case "ShfaqKlientetPerDhomat" :
					ds = busObject.VeprimeRead("ShfaqKlientetPerDhomat", varInt1);
					// varInt1 ruan id e dhomave
					break;
				default :
					ds = null ;
					break;
			}
			return ds ;
		}

		public DataSet KerkesaRead (string idKerkesa, DateTime varDate1 )
		{
			DataSet ds = null ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqRezervimetPerKlientPerDatatEdhena":
					ds = busObject.VeprimeRead("ShfaqRezervimetPerKlientPerDatenEdhene", varDate1);
					// varDate1 sherben si date fillimi
					break;
				
				case "GjendjaDitoreDuhur":
					ds = busObject.VeprimeRead("GjendjaDitoreDuhur", varDate1 );
					break;
				case "ShfaqGjendjenEdhomavePerDatenEdhene":
					ds = busObject.VeprimeRead("ShfaqGjendjenEdhomavePerDatenEdhene", varDate1 );
					break;
				case "ShfaqShpenzimetPerDatenEdhene":
					ds = busObject.VeprimeRead("ShfaqShpenzimetPerDatenEdhene", varDate1 );
					break;
				case "ShfaqBilanciPerDatenEdhene":
					ds = busObject.VeprimeRead("ShfaqBilanciPerDatenEdhene", varDate1 );
					break;
				case "ShfaqBilanciPerDatenEdheneDetaje":
					ds = busObject.VeprimeRead("ShfaqBilanciPerDatenEdheneDetaje", varDate1 );
					break;
				case "ShfaqBilanciPerDatenEdheneJanusGrid":
					ds = busObject.VeprimeRead("ShfaqBilanciPerDatenEdheneJanusGrid", varDate1);
					break;
				case "ShfaqRezervimetPerKlientPerDatenEdhene":
					ds = busObject.VeprimeRead("ShfaqRezervimetPerKlientPerDatenEdhene", varDate1 );
					// varDate1 sherben si data e pare e rezervimit
					break;
				case "ShfaqRezervimeVlefshmeKlientiPerDatenEdhene":
					ds = busObject.VeprimeRead("ShfaqRezervimeVlefshmeKlientiPerDatenEdhene", varDate1 );
					// varDate1 sherben si data e pare e rezervimit
					break;
				case "ShfaqRezervimeVlefshmeGrupiPerDaten":
					ds = busObject.VeprimeRead("ShfaqRezervimeVlefshmeGrupiPerDaten", varDate1);
					// varDate1 sherben si date fillimi
					break;
				case "ShfaqRezervimetPerGrupPerDatenEdhene":
					ds = busObject.VeprimeRead("ShfaqRezervimetPerGrupPerDatenEdhene", varDate1 );
					// varDate1 sherben si data e pare e rezervimit
					break;
				case "ShfaqRezervimetPerGrupDhomePerDatenEdhene":
					ds = busObject.VeprimeRead("ShfaqRezervimetPerGrupDhomePerDatenEdhene", varDate1 );
					// varDate1 sherben si data e pare e rezervimit
					break;
				case "ShfaqCmimetEdhomavePerDatenEdhene" :
					ds = busObject.VeprimeRead("ShfaqCmimetEdhomavePerDatenEdhene" , varDate1 );
					// varDate1 sherben si data e pare e rezervimit
					break;
				case "ShfaqDhomaCmimiTeDhene" :
					ds = busObject.VeprimeRead("ShfaqDhomaCmimiTeDhene", varDate1);
					break;
			
				case "GjendjaRealeArke":
					ds = busObject.VeprimeRead("GjendjaRealeArke", varDate1);
					//varDate1 herben si dateKerkimi
					break;
				case "BilancMujorPerVitinKorrent":
					ds = busObject.VeprimeRead("BilancMujorPerVitinKorrent", varDate1);
					//varDate1 sherben si vitKerkimi
					break;
				default :
					ds = null ;
					break;	
			}
			return ds ;
		}

		public DataSet KerkesaRead (string idKerkesa, DateTime data1, string varString1, int varInt1 )
		{
			DataSet ds = null ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{				
				default :
					ds = null ;
					break;
			}
			return ds ;
		}

		public DataSet KerkesaRead (string idKerkesa,  string varString1)
		{
			DataSet ds = null ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqShpenzimetPerKomentinEdhene":
					ds = busObject.VeprimeRead("ShfaqShpenzimetPerKomentinEdhene", varString1 );
					// varString1 sherben si koment per shpenzimin
					break;
				
				case "KlientetEPashlyerPerDhomen":
					ds = busObject.VeprimeRead("KlientetEPashlyerPerDhomen", varString1 );
					// varString1 sherben si emri i dhomes
					break;
				case "ShfaqKlientetPerDhomenEgrupit" :
					ds = busObject.VeprimeRead("ShfaqKlientetPerDhomenEgrupit" , varString1 );
					// varString1 sherben si emri i dhomes
					break;
				case "KontrollRolPerdoruesi":
					ds = busObject.VeprimeRead("KontrollRolPerdoruesi", varString1);
					break;
				default :
					ds = null ;
					break;
			}
			return ds ;
		}

		public DataSet KerkesaRead (string idKerkesa )
		{
			DataSet ds = null ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqDhomatEPashlyeraGrupi" :
					ds = busObject.VeprimeRead("ShfaqDhomatEPashlyeraGrupi");
					break;
				case "ShfaqDhomat" :
					ds = busObject.VeprimeRead("ShfaqDhomat");
					break;
				case "ShfaqDhomatEPashlyera" :
					ds = busObject.VeprimeRead("ShfaqDhomatEPashlyera");
					break;
				case "ShfaqLlojetDetyrime" :
					ds = busObject.VeprimeRead("ShfaqLlojetDetyrime");
					break;
				case "ShfaqKategorite" :
					ds = busObject.VeprimeRead("ShfaqKategorite");
					break;
				case "ShfaqMjeteIdentifikimi" :
					ds = busObject.VeprimeRead("ShfaqMjeteIdentifikimi");
					break;
				case "ShfaqRezervimeKlienti":
					ds = busObject.VeprimeRead("ShfaqRezervimeKlienti");
					break;
				case "ShfaqRezervimeVlefshmeKlienti":
					ds = busObject.VeprimeRead("ShfaqRezervimeVlefshmeKlienti");
					break;
				case "ShfaqRezervimeGrupi":
					ds = busObject.VeprimeRead("ShfaqRezervimeGrupi");
					break;
				case "ShfaqRezervimeGrupiDhome":
					ds = busObject.VeprimeRead("ShfaqRezervimeGrupiDhome");
					break;
				case "ShfaqGjitheShpenzimet":
					ds = busObject.VeprimeRead("ShfaqGjitheShpenzimet");
					break;
				case "ShfaqGrupet":
					ds = busObject.VeprimeRead("ShfaqGrupet");
					break;
				case "ShfaqKlientHotel":
					ds = busObject.VeprimeRead("ShfaqKlientetNeHotel");
					break;
				case "ShfaqAgjensinePerGrupinEdhene" :
					ds = busObject.VeprimeRead("ShfaqAgjensinePerGrupinEdhene");
					break;
				case "ShfaqRezervimetVlefshmePerDhomatMeOre" :
					ds = busObject.VeprimeRead("ShfaqRezervimetVlefshmePerDhomatMeOre");
					break;
				case "ShfaqHyrjetPasSotDhomatMeOre" :
					ds = busObject.VeprimeRead("ShfaqHyrjetPasSotDhomatMeOre");
					break;
				case "ShfaqRolet":
					ds = busObject.VeprimeRead("ShfaqRolet");
					break;
				case "ShfaqPerdoruesit":
					ds = busObject.VeprimeRead("ShfaqPerdoruesit");
					break;
				case "ShfaqCmimetPerDhomat":
					ds = busObject.VeprimeRead("ShfaqCmimetPerDhomat");
					break;
				case "ShfaqDhomatEPashlyeraPrint":
					ds = busObject.VeprimeRead("ShfaqDhomatEPashlyeraPrint");
					break;
				case "ShfaqKlientGrupNeHotel":
					ds = busObject.VeprimeRead("ShfaqKlientGrupNeHotel");
					break;
				case "ShfaqRezervimeVlefshmeGrupi":
					ds = busObject.VeprimeRead("ShfaqRezervimeVlefshmeGrupi");
					break;
				case "ShfaqRezervimeSkaduara":
					ds = busObject.VeprimeRead("ShfaqRezervimeSkaduara");
					break;
				case "ShfaqRezervimeSkaduaraGrupe":
					ds = busObject.VeprimeRead("ShfaqRezervimeSkaduaraGrupe");
					break;
				case "KontrolloDhomatPaDorezuaraKliente":
					ds = busObject.VeprimeRead("KontrolloDhomatPaDorezuaraKliente");
					break;
				case "KontrolloDhomatPaDorezuaraGrupe":
					ds = busObject.VeprimeRead("KontrolloDhomatPaDorezuaraGrupe");
					break;
				case "ShfaqRezervimeVlefshme":
					ds = busObject.VeprimeRead("ShfaqRezervimeVlefshme");
					break;
				case "ShfaqRezervimeVlefshmeNeGrup":
					ds = busObject.VeprimeRead("ShfaqRezervimeVlefshmeNeGrup");
					break;
				case "ShfaqLlojetEShpenzimeve":
					ds = busObject.VeprimeRead("ShfaqLlojetEShpenzimeve");
					break;
				case "ShfaqPerkthime":
					ds = busObject.VeprimeRead("ShfaqPerkthime");
					break;
				case "ShfaqTeGjithaFormatEPageses":
					ds = busObject.VeprimeRead("ShfaqTeGjithaFormatEPageses");
					break;
				default :
					ds = null ;
					break;
			}
			return ds ;
		}
		
		public DataSet KerkesaRead(string idKerkesa, DataSet vards, DateTime varDate1)
		{
			DataSet ds = null;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ModifikoDataSet":
					ds = busObject.VeprimeRead("ModifikoDataSet", vards, varDate1);
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet KerkesaRead (string idKerkesa, int varInt1 )
		{
			DataSet ds = null ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqDataPerRezervim" :
					ds = busObject.VeprimeRead("ShfaqDataPerRezervim", varInt1);
					break;
				case "ShfaqKaparRezervimiArka" :
					ds = busObject.VeprimeRead("ShfaqKaparRezervimiArka", varInt1);
					break;
				case "ShfaqKlientGrupNeHotelPerModifikim" :
					ds = busObject.VeprimeRead("ShfaqKlientGrupNeHotelPerModifikim", varInt1);
					break;
				case "ShfaqLlojDetyriminEzgjedhur" :
					ds = busObject.VeprimeRead("ShfaqLlojDetyriminEzgjedhur", varInt1);
					break;
				case "ShfaqDhomatPerKategorine" :
					ds = busObject.VeprimeRead("ShfaqDhomatPerKategorine", varInt1 );
					break;
				case "ShfaqDhomatEliraPerKategorine" :
					ds = busObject.VeprimeRead("ShfaqDhomatEliraPerKategorine", varInt1 );
					break;
				case "ShfaqKlientetPerDhomenEdhene" :
					ds = busObject.VeprimeRead("ShfaqKlientetPerDhomenEdhene", varInt1 );
					break;
				case "ShfaqDetyrimePerKlientinPerDhomen" :
					ds = busObject.VeprimeRead("ShfaqDetyrimePerKlientin", varInt1 );
					break;
				case "ShfaqDataPerKlientin" :
					ds = busObject.VeprimeRead("ShfaqDataPerKlientin", varInt1 );
					break;
				case "ShfaqDetyrimetPerKlientetEDhomes" :
					ds = busObject.VeprimeRead("ShfaqDetyrimetPerKlientetEDhomes", varInt1 );
					break;
				case "ShfaqVetemDetyrimetPerKlientetEDhomes" :
					ds = busObject.VeprimeRead("ShfaqVetemDetyrimetPerKlientetEDhomes", varInt1 );
					break;
				case "ShfaqDetyrimKlientiPerKategorineEdhene" :
					ds = busObject.VeprimeRead("ShfaqDetyrimKlientiPerKategorineEdhene", varInt1 );
					break;
				case "ShfaqVetemDetyrimKlientiPerKategorineEdhene" :
					ds = busObject.VeprimeRead("ShfaqVetemDetyrimKlientiPerKategorineEdhene", varInt1 );
					break;
				case "ShfaqTeDhenaKlientiId" :
					ds = busObject.VeprimeRead("ShfaqTeDhenaKlientiId", varInt1 );
					break;
				case "ShfaqTeDhenatPerDhome" :
					ds = busObject.VeprimeRead("ShfaqTeDhenatPerDhome", varInt1 );
					break;
				case "ShfaqTeDhenaPerDetyrim" :
					ds = busObject.VeprimeRead("ShfaqTeDhenaPerDetyrim", varInt1 );
					break;
				case "ShfaqTeDhenaPerRezerviminKlienti" :
					ds = busObject.VeprimeRead("ShfaqTeDhenaPerRezerviminKlienti", varInt1 );
					break;
				case "ShfaqDhomaPerRezervimGrupi" :
					ds = busObject.VeprimeRead("ShfaqDhomaPerRezervimGrupi", varInt1 );
					break;
				case "ShfaqCmimetPerDhomenEdhene" :
					ds = busObject.VeprimeRead("ShfaqCmimetPerDhomenEdhene", varInt1 );
					break;
				case "ShfaqCmimetPerShtreteritEdhene" :
					ds = busObject.VeprimeRead("ShfaqCmimetPerShtreteritEdhene", varInt1 );
					break;
				case "ShfaqCmimetPerKategorineEdhene" :
					ds = busObject.VeprimeRead("ShfaqCmimetPerKategorineEdhene", varInt1 );
					break;
				case "ShfaqDhomatPerKategorineEdhene" :
					ds = busObject.VeprimeRead("ShfaqDhomatPerKategorineEdhene", varInt1 );
					break;
				case "ShfaqGrupin":
					ds = busObject.VeprimeRead("ShfaqGrupin", varInt1);
					break;
				case "NxirrDhome":
					ds = busObject.VeprimeRead("NxirrDhome", varInt1);
					break;
				case "ShfaqDetyrimePerKlientinEkstra" :
					ds = busObject.VeprimeRead("ShfaqDetyrimePerKlientinEkstra", varInt1);
					break;
				case "ShfaqKlientetPerGrupinEdhene" :
					ds = busObject.VeprimeRead("ShfaqKlientetPerGrupinEdhene", varInt1);
					break;
				case "ShfaqTeDhenatPerPerdoruesin":
					ds = busObject.VeprimeRead("ShfaqTeDhenatPerPerdoruesin", varInt1);
					break;
				case "ShfaqRezervimeVlefshmePerDhomen":
					ds = busObject.VeprimeRead("ShfaqRezervimeVlefshmePerDhomen", varInt1 );
					break;
				case "ShfaqRezervimeVlefshmeGrupiPerDhomen":
					ds = busObject.VeprimeRead("ShfaqRezervimeVlefshmeGrupiPerDhomen", varInt1 );
					break;
				case "ShfaqRezervimeVlefshmePerGrupAgjensi":
					ds = busObject.VeprimeRead("ShfaqRezervimeVlefshmePerGrupAgjensi", varInt1 );
					break;				
				case "ShfaqShpenzimetPerLlojinEdhene":
					ds = busObject.VeprimeRead("ShfaqShpenzimetPerLlojinEdhene", varInt1 );
					break;
				case "ShfaqDhomaNePerdorim" :
					ds = busObject.VeprimeRead("ShfaqDhomaNePerdorim", varInt1);
					break;
				case "ShfaqTeDhenaFormaPagesa" :
					ds = busObject.VeprimeRead("ShfaqTeDhenaFormaPagesa", varInt1);
					break;
				case "ShfaqFormePageseKaparDhome" :
					ds = busObject.VeprimeRead("ShfaqFormePageseKaparDhome", varInt1);
					break;
				case "ShfaqFormePagesePerRezervim" :
					ds = busObject.VeprimeRead("ShfaqFormePagesePerRezervim", varInt1);
					break;
				case "ShfaqVeprimetPerRezervim" :
					ds = busObject.VeprimeRead("ShfaqVeprimetPerRezervim", varInt1);
					break;
				case "ShfaqDhomaPerRezervim" :
					ds = busObject.VeprimeRead("ShfaqDhomaPerRezervim", varInt1);
					break;
				default :
					ds = null ;
					break;
			}
			return ds ;
		}

		public DataSet KerkesaRead (string idKerkesa, int varInt1, int varInt2 )
		{
			DataSet ds = null ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "NumerKlienteshPerCdoDate" :
					ds = busObject.VeprimeRead("NumerKlienteshPerCdoDate", varInt1, varInt2);
					break;
				case "ShfaqVeprimetPerDhomen":
					//varInt1 sherben si idDhoma
					//varInt2 = 1 per hyrjet e vlefshme
					//varInt2 = 0 per hyrjet jo te vlefshme
					//varInt2 = -1 pa kriter
					ds = busObject.VeprimeRead("ShfaqVeprimetPerDhomen", varInt1, varInt2 );
					break;
				case "ShfaqVeprimetPerGrupin":
					//varInt1 sherben si idGrupi
					//varInt2 = 1 per hyrjet e vlefshme
					//varInt2 = 0 per hyrjet jo te vlefshme
					//varInt2 = -1 pa kriter
					ds = busObject.VeprimeRead("ShfaqVeprimetPerGrupin",  varInt1, varInt2);
					break;
				case "ShfaqVeprimetPerGrupinPerModifikim":
					//varInt1 sherben si idGrupi
					//varInt2 = 1 per hyrjet e vlefshme
					//varInt2 = 0 per hyrjet jo te vlefshme
					//varInt2 = -1 pa kriter
					ds = busObject.VeprimeRead("ShfaqVeprimetPerGrupinPerModifikim",  varInt1, varInt2);
					break;
				case "ShfaqVeprimetNeGrupPerDhomen":
					//varInt1 sherben si idDhoma
					//varInt2 = 1 per hyrjet e vlefshme
					//varInt2 = 0 per hyrjet jo te vlefshme
					//varInt2 = -1 pa kriter
					ds = busObject.VeprimeRead("ShfaqVeprimetNeGrupPerDhomen", varInt1, varInt2);
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}

		public DataSet KerkesaRead (string idKerkesa, int varInt1, DateTime varDate1 )
		{
			DataSet ds = null ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqTeDhenatPerDhome" :
					ds = busObject.VeprimeRead("ShfaqTeDhenatPerDhome", varInt1, varDate1);
					break;
				case "ShfaqDhomaPerRezervimGrupiPerdata" :
					ds = busObject.VeprimeRead("ShfaqDhomaPerRezervimGrupiPerdata", varInt1, varDate1);
					break;
				case "NxirrDhomePerDaten" :
					ds = busObject.VeprimeRead("NxirrDhomePerDaten", varInt1, varDate1);
					break;
				case "ShfaqKlientetPerDhomenEdhenePerDatenEdhene" :
					ds = busObject.VeprimeRead("ShfaqKlientetPerDhomenEdhenePerDatenEdhene", varInt1, varDate1);
					// varInt1 sherben si ID_DHOMA
					// varInt2 sherben si date dorezimi
					break;
				case "ShfaqDhomatEZenaPerKategorine":
					ds = busObject.VeprimeRead("ShfaqDhomatEZenaPerKategorine", varInt1, varDate1);
					break;
				case "CmimiDhomesPerDaten":
					ds = busObject.VeprimeRead("CmimiDhomesPerDaten", varInt1, varDate1);
					break;
				case "ShfaqDhomatPerGrupinEdhene":
					ds = busObject.VeprimeRead("ShfaqDhomatPerGrupinEdhene", varInt1, varDate1);
					break;
				case "NumerKlienteshPerDateDhoma":
					// varInt1 sherben si ID_DHOMA
					// varDate1 sherben si date
					ds = busObject.VeprimeRead("NumerKlienteshPerDateDhoma", varInt1, varDate1);
					break;
				case "NumerKlienteshPerDateGrup":
					// varInt1 sherben si ID_GRUPI
					// varDate1 sherben si date
					ds = busObject.VeprimeRead("NumerKlienteshPerDateGrup", varInt1, varDate1);
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}

		public DataSet KerkesaRead (string idKerkesa, int varInt1, int varInt2, DateTime varDate1 )
		{
			DataSet ds = null ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqKlientetPerDhomenEdhenePerDatenEdhenePerGrup" :
					ds = busObject.VeprimeRead("ShfaqKlientetPerDhomenEdhenePerDatenEdhenePerGrup", varInt1, varInt2, varDate1);
					// varInt1 sherben si ID_DHOMA
					// varInt2 sherben si date dorezimi
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet KerkesaRead (string idKerkesa, int varInt1, int varInt2, DateTime varDate1, DateTime varDate2 )
		{
			DataSet ds = null ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqVeprimetPerDhomen":
					//varInt1 sherben si idDhoma
					//varDate1 sherben si dateFillimi
					//varDate2 sherben si dateMbarimi
					//varInt2 = 1 per hyrjet e vlefshme
					//varInt2 = 0 per hyrjet jo te vlefshme
					//varInt2 = -1 pa kriter
					ds = busObject.VeprimeRead("ShfaqVeprimetPerDhomen", varInt1,varInt2, varDate1, varDate2);
					break;
				case "ShfaqVeprimetPerGrupin":
					//varInt1 sherben si idGrupi
					//varDate1 sherben si dateFillimi
					//varDate2 sherben si dateMbarimi
					//varInt2 = 1 per hyrjet e vlefshme
					//varInt2 = 0 per hyrjet jo te vlefshme
					//varInt2 = -1 pa kriter
					ds = busObject.VeprimeRead("ShfaqVeprimetPerGrupin", varInt1,varInt2, varDate1, varDate2);
					break;
				case "ShfaqVeprimetNeGrupPerDhomen":
					//varInt1 sherben si idDhoma
					//varDate1 sherben si dateFillimi
					//varDate2 sherben si dateMbarimi
					//varInt2 = 1 per hyrjet e vlefshme
					//varInt2 = 0 per hyrjet jo te vlefshme
					//varInt2 = -1 pa kriter
					ds = busObject.VeprimeRead("ShfaqVeprimetNeGrupPerDhomen", varInt1,varInt2, varDate1, varDate2);
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}

		public DataSet KerkesaRead (string idKerkesa, int varInt1, int varInt2, DateTime varDate1, DateTime varDate2, int varInt3 )
		{
			DataSet ds = null ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqVeprimetPerGrupDheDhome" :
					// varInt1 sherben si ID_GRUPI
					// varInt2 sherben si ID_DHOMA
					// varInt1 sherben si date fillimi
					// varInt2 sherben si date mbarimi
					// varInt3 = 1 per hyrjet e vlefshme
					// varInt3 = 0 per hyrjet jo te vlefshme
					// varInt3 = -1 pa kriter
					ds = busObject.VeprimeRead("ShfaqVeprimetPerGrupDheDhome", varInt1, varInt2, varDate1, varDate2, varInt3);
					break;
				case "NrKlienteNeDhomeJoTeGrupitTeDhene":
					// varInt1 sherben si ID_GRUPI
					// varInt2 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varint3 sherben si idklienti
					ds = busObject.VeprimeRead("NrKlienteNeDhomeJoTeGrupitTeDhene",  varInt1, varInt2, varDate1, varDate2, varInt3);
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}


		public DataSet KerkesaRead (string idKerkesa, string varString1, string varString2 )
		{
			DataSet ds = null ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqTeDhenaPerKlientin" :
					ds = busObject.VeprimeRead("ShfaqTeDhenaPerKlientin", varString1, varString2);
					break;
				case "ShfaqDetyrimePerKlientin" :
					ds = busObject.VeprimeRead("ShfaqDetyrimePerKlientin", varString1, varString2);
					break;
				case "ShfaqRezervimetPerKlientPerEmerMbiemerTeDhene" :
					ds = busObject.VeprimeRead("ShfaqRezervimetPerKlientPerEmerMbiemerTeDhene", varString1, varString2);
					// varString1 sherben si emer klienti
					// varString2 sherben si mbiemer klienti
					break;
				case "ShfaqRezervimetPerGrupAgjensiTeDhene" :
					ds = busObject.VeprimeRead("ShfaqRezervimetPerGrupAgjensiTeDhene", varString1, varString2);
					// varString1 sherben si emer grupi
					// varString2 sherben si emer agjensie
					break;
				case "ShfaqRezervimetDhomePerGrupAgjensiTeDhene" :
					ds = busObject.VeprimeRead("ShfaqRezervimetDhomePerGrupAgjensiTeDhene", varString1, varString2);
					// varString1 sherben si emer grupi
					// varString2 sherben si emer agjensie
					break;
				case "ShfaqVeprimetPerGrupin" :
					ds = busObject.VeprimeRead("ShfaqVeprimetPerGrupin", varString1, varString2);
					// varString1 sherben si emer grupi
					// varString2 sherben si emer agjensie
					break;
				case "ShfaqRezervimeVlefshemPerEmerMbiemer":
					ds =busObject.VeprimeRead("ShfaqRezervimVlefshemPerEmerMbiemer",varString1,varString2);
					break;
				case "ShfaqRezervimeVlefshemPerEmerAgjensi":
					ds =busObject.VeprimeRead("ShfaqRezervimVlefshemPerEmerAgjensi",varString1,varString2);
					break;
				case "KontrollUserName":
					// varString1 sherben si emri i perdoruesit
					// varString2 sherben si fjalekalimi i perdoruesit
					ds = busObject.VeprimeRead("KontrollUserName", varString1, varString2);
					break;
				case "ShfaqDetyrimKlientiPerEmerMbiemer":
					ds = busObject.VeprimeRead("ShfaqDetyrimKlientiPerEmerMbiemer", varString1,varString2 );
					// varString1 sherben si emri i dhomes
					break;
				case "ShfaqVetemDetyrimKlientiPerEmerMbiemer":
					ds = busObject.VeprimeRead("ShfaqVetemDetyrimKlientiPerEmerMbiemer", varString1,varString2 );
					// varString1 sherben si emri i dhomes
					break;
				default :
					ds = null ;
					break;
			}
			return ds ;
		}

		public DataSet KerkesaRead (string idKerkesa, string varString1, string varString2, int varInt1)
		{
			DataSet ds = null ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqVeprimetPerKlientin":
					//varString1 dhe varString2 sherbejne si emri i klientit
					//varInt1 = 1 per hyrjet e vlefshme
					//varInt1 = 0 per hyrjet jo te vlefshme
					//varInt1 = -1
					ds = busObject.VeprimeRead("ShfaqVeprimetPerKlientin", varString1,varString2, varInt1 );
					break;
				default :
					ds = null ;
					break;
			}
			return ds ;
		}
		public DataSet KerkesaRead (string idKerkesa, string varString1, string varString2, string varString3 )
		{
			DataSet ds = null ;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				
				case "ShfaqDetyriminEzgjedhur" :
					ds = busObject.VeprimeRead("ShfaqDetyriminEzgjedhur", varString1, varString2, varString3);
					break;
				default :
					ds = null ;
					break;
			}
			return ds ;
		}

		public DataSet KerkesaRead (string idKerkesa, string varString1, string varString2, DateTime varDate1, DateTime varDate2)
		{
			DataSet ds = null;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqDetyrimKlientiPerEmerDheData":
					ds = busObject.VeprimeRead("ShfaqDetyrimKlientiPerEmerDheData", varString1, varString2, varDate1, varDate2);
					break;
				case "HyrjeNeHotelKlienteDale":
					ds = busObject.VeprimeRead("HyrjeNeHotelKlienteDale", varString1, varString2, varDate1, varDate2);
					break;
				case "HyrjeNeHotelGrupeDale":
					ds = busObject.VeprimeRead("HyrjeNeHotelGrupeDale", varString1, varString2, varDate1, varDate2);
					break;
				
			}
			return ds;
		}
		
		public DataSet KerkesaRead (string idKerkesa, string varString1, string varString2, DateTime varDate1, DateTime varDate2, int varInt1)
		{
			DataSet ds = null;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqVeprimetPerKlientin" :
					// varString1 sherben si emer klienti
					// varString2 sherben si mbiemer klienti
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt1 = 1 per hyrjet e vlefshme
					// varInt1 = 0 per hyrjet jo te vlefshme
					// varInt1 = -1 pa kriter
					ds = busObject.VeprimeRead("ShfaqVeprimetPerKlientin", varString1, varString2, varDate1, varDate2, varInt1);
					break;				
			}
			return ds;
		}
		public DataSet KerkesaRead (string idKerkesa,int varInt1,  string varString1, string varString2, DateTime varDate1, DateTime varDate2, int varInt2)
		{
			DataSet ds = null;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqVeprimetPerKlientinDheDhomen":
					ds = busObject.VeprimeRead("ShfaqVeprimetPerKlientinDheDhomen",varInt1, varString1, varString2, varDate1, varDate2, varInt2);
					break;				
			}
			return ds;
		}
		
		public DataSet KerkesaRead (string idKerkesa, DateTime varDate1, DateTime varDate2, int varInt1, string varString1, string varString2)
		{
			DataSet ds = null;
			BussinessDelegate busObject = new BussinessDelegate();
			switch (idKerkesa)
			{
				case "ShfaqDetyrimeKlientePerDataEmerKategori":
					ds = busObject.VeprimeRead("ShfaqDetyrimeKlientePerDataEmerKategori", varDate1, varDate2, varInt1, varString1, varString2);
					break;
			}
			return ds;
		}
		#endregion 
		
	}

}
