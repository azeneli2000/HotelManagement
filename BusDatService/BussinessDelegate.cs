using System;
using HotelManagment.BusDatService;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagment.BusDatService
{
	/// <summary>
	/// Summary description for BussinessDelegate.
	/// </summary>
	public class BussinessDelegate
	{
		
		public BussinessDelegate()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		
		
		#region public methods
		
		#region VeprimeUpdate

		public int VeprimeUpdate (string idVeprime,DateTime varDate,int varInt)
		{
			int b = 0;
			Arka arkaObject = new Arka();
			switch (idVeprime)
			{	
				case "NxirrArke":
					b = arkaObject.Nxirr(varDate, varInt);
					break;
				case "ModifikoDatenEdaljes" :
					Klienti klientObject = new Klienti();
					b = klientObject.ModifikoDatenEdaljes(varInt, varDate);
					break;
				default:
					b = 0;
					break;
			}
			return b;
		}
		public int VeprimeUpdate (string idVeprime,DateTime varDate,int varInt1, int varInt2)
		{
			int b = 0;
			Arka arkaObject = new Arka();
			switch (idVeprime)
			{
				case "HidhNeArke":
					//varInt2 sherben si id e perdoruesit qe ka bere transaksionin
					b = arkaObject.Hidh(varDate, varInt1,"Hedhje manuale",0,1, varInt2);
					break;			
				default:
					b = 0;
					break;
			}
			return b;
		}
		public int VeprimeUpdate (string idVeprime , int varInt, string varString,int varInt1,int varInt2,int varInt3)
		{
			int b = 0;
			switch (idVeprime)
			{
			
			
				case "ModifikoDhome":
		
					Dhoma dhomaObject1 = new Dhoma(varString, varInt2, varInt3);
					b = dhomaObject1.ModifikoDhome(varInt,varInt1);
					break;
					//varint idDhoma
					//varInt1 dhomaCift
				default:
					b = 0;
					break;					
			}
			return b;
		}


		public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, DateTime varDate1, DateTime varDate2)
		{
			int b = 1;
			switch (idVeprime)
			{
				case "KrijoCmimPerDhome":
					CmimiDhoma cmimiDhoma = new CmimiDhoma(varDate1, varDate2, varInt2);
					b = cmimiDhoma.KrijoCmimiDhoma(varInt1);
					break;
			}
			return b;
		}

		public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, int varInt3, string varString1, 
			string varString2, string varString3, string varString4, string varString5)
		{
			int b = 0;
			switch(idVeprime)
			{
				case "ModifikoPerdorues":
					Perdorues perdorues = new Perdorues();
					b = perdorues.ModifikoPerdorues(varInt1, varInt2, varInt3, varString1, varString2, varString3, varString4, varString5);
					break;
			}
			return b;
		}

		public int VeprimeUpdate(string idVeprime, int varInt2, int varInt3,
			int varInt4,int varInt5, int[] vektor, DateTime varDate, bool varBool, int varInt6, int varInt7)
		{
			int b = 0;
			switch (idVeprime)
			{
				case "DorezoDhome" :
					// varInt2 sherben si skonto
					// varInt3 sherben si gjobe
					// varInt4 sherben si sasia qe do hidhet ne arke per dhomen
					// varInt5 sherben si id per klientin te cilit do i aplikohet kapari
					// vektor sherben per id e klienteve qe do te largohen
					// varDate sherben si date dalje/dorezimi
					// varInt6 sherben i idFormaPagesa
					// varInt7 sherben si id e perdoruesit qe ka bere transaksionin
					Klienti klientiObject = new Klienti();

					b = b + klientiObject.Dorezo( varInt2, varInt3, varInt5, vektor, varDate);
					if (varBool == false)//kur klientet kane ardhur pa grup paguar_dhome behet gjithmone 1
						b = b + klientiObject.PaguajDhome(vektor);
					Detyrime detyrimeObject = new Detyrime();
					//duhet shtuar edhe idPerdoruesi
					b = b + detyrimeObject.HidhDetyrimeNeArke(vektor, varDate,varInt6, varInt7);
					Arka arkaObject = new Arka();
					if ((varInt4 > 0)&&(varInt5 > 0)) 
					{
						string s = "";
						if (varBool == false)
							s = "Pagese dhome";
						else
						{
							s = "Pagese grupi";
							//ne rastin e grupit paguar_dhome behet 1 vetem kur grupi kryen
							//pagesen per te gjitha dhomat
							b = b + klientiObject.PaguajDhome(vektor);
						}
						//Perfshihet ne arke edhe id e Perdoruesit i cili ka bere transaksionin
						b = b +  arkaObject.Hidh(varDate , varInt4, s, varInt5, varInt6, varInt7);
					}
					if ((varInt5 >0)&&(varInt4 == 0)&&(varBool == true))
					{
						b = b + klientiObject.PaguajDhome(vektor);
					}
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		
		public int VeprimeUpdate(string idVeprime, int[] varInt1, int varInt2, DateTime varDate1)
		{
			int b = 1;
			switch (idVeprime)
			{
				case "DorezoDhomePerGrup" :
					// varInt1 sherben si idDhoma
					// varInt2 sherben si pagesa
					// varDate1 sherben si date dalje
					Arka arkaObject = new Arka();
					b = 0;//arkaObject.Hidh(varDate1, varInt2,"Pagese klienti");
					if (b != 0)
					{
						break;
					}

					Dhoma dhomaObject = new Dhoma();
					for (int i = 0; i < varInt1.Length; i++)
					{
						b = dhomaObject.LiroDhomen(varInt1[i]);
					}
					break;
			}
			return b;
		}

		public int VeprimeUpdate(string idVeprime, DateTime varDate1)
		{
			int b = 1;
			switch (idVeprime)
			{
				case "FshiArka":
					Arka arka = new Arka(varDate1);
					b = arka.Fshi();
					break;
			}
			return b;
		}

		

		public int VeprimeUpdate(string idVeprime, string varString1, string varString2, string varString3,
			string varString4, int varInt1)
		{
			int b = 0;
			switch (idVeprime)
			{
				case "ShtoPerdorues":
					Perdorues perdorues = new Perdorues();
					b = perdorues.KrijoPerdorues(varString1, varString2, varString3, varString4, varInt1);
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, int varInt3)
		{
			int b = 0;
			switch (idVeprime)
			{
					//
				case "FshiKlientNgaRezervimi" :
					Klienti klientiObject2 = new Klienti();
					klientiObject2.FshiKlient(varInt1, varInt2, varInt3);
					// varInt1 sherben SI ID_KLIENTI
					// varInt2 sherben si idIdentifikimi
					// varInt3 sherben si idRezervimi
					break;
				case "NxirrKlientiNgaDhoma" :
					Klienti klientiObject = new Klienti();
					klientiObject.NxirrKlientinNgaDhoma(varInt1, varInt2, varInt3);
					// varInt1 sherben SI ID_KLIENTI
					// varInt2 sherben si skonto
					// varInt3 sherben si gjoba
					break;
				case "FshiKlientGrupi":
					//varInt1 sherben si idKlienti
					//varInt2 sherben si idIdentifikimi
					//varInt3 sherben si idGrupi
					Klienti klientiObject1 = new Klienti();
					b = klientiObject1.FshiKlientGrupi(varInt1,varInt2, varInt3);
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, int varInt3, int varInt4)
		{
			int b = 0;
			switch (idVeprime)
			{
				case "FshiKlientGrupiNgaRezervimi" :
					Klienti klientiObject2 = new Klienti();
					klientiObject2.FshiKlientGrupi(varInt1, varInt2, varInt3, varInt4);
					// varInt1 sherben SI ID_KLIENTI
					// varInt2 sherben si idIdentifikimi
					// varInt3 sherben si idGrupi
					// varInt4 sherben si idRezervimi
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2,
			int varInt3, int varInt4, int varInt5,int varInt6, DateTime varDate1, DateTime varDate2 )
		{
			int b = 0;
			switch (idVeprime)
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
					Klienti klienti1 = new Klienti();
					b = klienti1.FshiPergjegjes(varInt1,varInt2,varInt3,
						varInt4, varInt5, varInt6, varDate1, varDate2);		
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2,
			int varInt3, int varInt4, int varInt5,int varInt6, DateTime varDate1, bool dorezuar, int varInt7 )
		{
			int b = 0;
			switch (idVeprime)
			{
				case "ModifikoSkontoKaparGjobe":
					//varInt1 kapari
					//varInt2 skonto
					//varInt3 gjoba
					//varInt4 pergjegjes
					//varInt5 pagesa
					//varInt6 idFormaPagesa
					//varDate1 sherben si data e dorezimit te dhomes kur behet edhe hedhja e pageses ne arke
					//varInt7 sherben si id e perdoruesit i cili eshte loguar ne sistem
					Klienti klienti2 = new Klienti();
					b = klienti2.ModifikoSkontoKaparGjobe(varInt1,varInt2,varInt3, 
						varInt4, varInt5, varInt6, varDate1, dorezuar, varInt7);		
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2,
			int varInt3, int varInt4, int varInt5,int varInt6, DateTime varDate1, 
			bool dorezuar, int varInt7, int varInt8 )
		{
			int b = 0;
			switch (idVeprime)
			{
				case "ModifikoSkontoKaparGjobePerHyrjetMeRezervim":
					//varInt1 kapari
					//varInt2 skonto
					//varInt3 gjoba
					//varInt4 pergjegjes
					//varInt5 pagesa
					//varInt6 idFormaPagesa
					//varDate1 sherben si data e dorezimit te dhomes kur behet edhe hedhja e pageses ne arke
					// dorezuar tregon nqs dhoma eshte dorezuar ose jo
					//varInt7 shernben si kapari Fiktiv qe i vendoset klientit
					//varInt8 sherben si id e perdoruesit qe eshte loguar ne sistem.
					Klienti klienti2 = new Klienti();
					b = klienti2.ModifikoSkontoKaparGjobe(varInt1,varInt2,varInt3, 
						varInt4, varInt5, varInt6, varDate1, dorezuar, varInt7, varInt8);		
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, 
			int varInt3, int varInt4, int varInt5,int varInt6, int varInt7, 
			DateTime varDate1, DateTime varDate2 )
		{
			int b = 0;
			switch (idVeprime)
			{
				case "FshiPergjegjesGrupi":
					//varInt1 idKlienti
					//varInt2 idIdentifikimi
					//varInt3 pergjegjes_ri
					//varInt4 kapar
					//varInt5 skonto
					//varInt6 gjobe
					//varInt7 idGrupi
					Klienti klienti1 = new Klienti();
					b = klienti1.FshiPergjegjesGrupi(varInt1,varInt2,varInt3, varInt4, 
						varInt5, varInt6, varInt7, varDate1, varDate2);		
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, int varInt3,DateTime varDate)
		{
			int b = 0;
			switch (idVeprime)
			{
				case "KrijoDetyrimPerKlient":
					Detyrime detyrime = new Detyrime(varInt1, varInt2, varInt3,varDate);
					b = detyrime.KrijoDetyrimKlienti();
					break;
		
				case "ModifikoDetyriminPerKlient":
					Detyrime detyrime1 = new Detyrime();
					b = detyrime1.ModifikoDetyrimKlienti(varInt1,varInt2,varInt3,varDate);
					break;
			}
			return b;
		}
		public int VeprimeUpdate(string idVeprime, int varInt, int varInt1, int[] vekInt, 
			DateTime varDate1, DateTime varDate2,DateTime varDate3, int varInt2, int varInt3)
		{
			int b = 0;
			switch (idVeprime)
			{
				case "KrijoRezervimGrupi":
					//varInt sherben si idGrupi
					// varInt1 sherben si kapari
					// varVektoriInt1 sherben si ID_DHOMAT  e rezervuara
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varDate3 sherben si data e rezervimit
					// varInt2 sherben si idFormaPagesa
					// varInt3 sherben si id e perdoruesit qe eshte loguar
					Rezervimi rezervObject = new Rezervimi(varDate1,varDate2,varDate3,varInt1,varInt,vekInt);
					b = rezervObject.KrijoRezervimGrupi();
					if ((b == 0)&&(varInt1 > 0))//hedhja ne arke do te behet vetem nqs kapari eshte > 0
					{
						Arka arkaObject = new Arka();
						int id_rez = Convert.ToInt32(rezervObject.id_rez_fundit().Tables[0].Rows[0][0]);
						b = b + arkaObject.HidhKaparRezervimi(varDate1, varInt1, "Kapar rezervimi", id_rez, varInt2, varInt, varInt3);
					}					
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int VeprimeUpdate(string idVeprime, int varInt1, string varString1, int varInt2)
		{
			int b = 0;
			switch (idVeprime)
			{
				case "ModifikoLlojDetyrimi":
					Detyrime detyrime = new Detyrime(varString1, varInt2);
					b = detyrime.ModifikoLlojDetyrimi(varInt1);
					return b;
				default:
					return 1;
			}
		}

		public int VeprimeUpdate(string idVeprime,  int varInt1,int varInt2, string varString1, 
			DateTime varDate1, int varInt3, int varInt4)
		{
			int b = 0;
			switch (idVeprime)
			{
				case ("ModifikoShpenzim"):
					Shpenzime shpenzime = new Shpenzime(varInt2, varDate1, varInt3, varString1, varInt4);
					b = shpenzime.ModifikoShpenzim(varInt1);
					// varInt1 sherben si ID_SHPENZIMI
					// varString1 sherben si koment per shpenzimin
					// varDate1 sherben si data e shpenzimit
					// varInt3 sherben si sasia e shpenzimit
					// varInt4 sherben si id e perdoruesit qe eshte loguar dhe ben modifikimin e shpenzimit
					break;
				
			}
			return b;
		}

		public int VeprimeUpdate(string idVeprime, DateTime varDate1, string varString1, int varInt)
		{
			//TODO: Add method logic here
			int b = 0;
			return b;
		}

		public int VeprimeUpdate(string idVeprime, DateTime varDate1, string varString1, int varInt1, DateTime varDate2, string varString2, int varInt2)
		{
			//TODO: Add method logic here
			int b = 0;
			return b;
		}

		public int VeprimeUpdate(string idVeprime, string varString1, string varString2, string varString3, DateTime varDate1, DateTime varDate2, string varString4, int varInt1)
		{
			//TODO: Add method logic here
			int b = 0;
			return b;
		}

		public int VeprimeUpdate(string idVeprime, string varString1, DateTime varDate1, int varInt1)
		{
			//TODO: Add method logic here
			int b = 0;
			return b;
		}

		public int VeprimeUpdate(string idVeprime,int varInt1, DateTime varDate,
			int varInt2,string varString, int varInt3)
		{
			int b = 0;
			int a = 0;
			switch (idVeprime)
			{
				case "KrijoShpenzim":
					//varInt3 sherben si id e perdoruesit qe eshte loguar ne momentin e rejistrimit te shpenzimit
					Shpenzime shpenzObject = new Shpenzime(varInt1, varDate, varInt2, varString, varInt3);
					b = shpenzObject.KrijoShpenzim();
					break;
				default:
					b = 0;
					break;

			}
			return b;
		}

		public int VeprimeUpdate(string idVeprime, string varString1, string varString2)
		{
			int b = 0;
			switch(idVeprime)
			{
				case "ShtoFormePagese":
					Arka arkaObject = new Arka();
					b = arkaObject.KrijoFormePagese(varString1,varString2);
					break;
				default:
					b = 1;
					break;
			}
			
			return b;
		}
		public int VeprimeUpdate(string idVeprime, string varString1, string varString2, string varString3)
		{
			int b = 0;
			switch(idVeprime)
			{
				case "KrijoGrup":
					Klienti klientObject = new Klienti( varString1,varString2, varString3);
					b = klientObject.KrijoGrup();
					break;
				default:
					b = 1;
					break;
			}
			
			return b;
		}
		public int VeprimeUpdate (string idVeprime,int varInt1,int varInt2, DateTime dtFillimi,DateTime dtMbarimi,int varInt3)
		{
			int b = 0;
			switch (idVeprime)
			{
				case "FshiCmimiPerDhomen":
					CmimiDhoma cmdhomaObject = new CmimiDhoma(dtFillimi,dtMbarimi,varInt3);
					b = cmdhomaObject.FshiCmimiDhoma(varInt1,varInt2);
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int VeprimeUpdate (string idVeprime,int varInt1,int varInt2, DateTime dtFillimi,
			DateTime dtMbarimi,int varInt3, DateTime dtFillimiVjeter, DateTime dtMbarimiVjeter)
		{
			int b = 0;
			switch (idVeprime)
			{
				case "ModifikoCmimiPerDhomen":	
					CmimiDhoma cmDhomaObject = new CmimiDhoma(dtFillimi,dtMbarimi,varInt3);
					b = cmDhomaObject.ModifikoCmimiDhoma(varInt1,varInt2, dtFillimiVjeter, dtMbarimiVjeter);
					//varInt1 idDhoma
					//varInt2 idCmimi
					//varInt3 cmimiDhoma
					// varDate3 sherben si data e fillimit te vjeter per cmimin
					// varDate4 sherben si data e mbarimit te vjeter per cmimin
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int VeprimeUpdate(string idVeprime)
		{
			int b = 0;
			switch(idVeprime)
			{
				case "FshiArke":
					Arka arkaObject = new Arka();
					b = arkaObject.Fshi();
					break;
			}
			return b ;
		}

		/// <summary>
		/// Krijon Detyrimin per klientin ose krijon nje Dhome ne varesi te idVeprime
		/// </summary>
		/// <param name="idVeprime">percakton se cili veprim do kryhet</param>
		/// <param name="varString"></param>
		/// <param name="varInt1"></param>
		/// <param name="varInt2"></param>
		/// <returns></returns>
		public int VeprimeUpdate (string idVeprime,string varString,int varInt1,int varInt2)
		{
			int b = 0;
			
			switch(idVeprime)
			{
				case "KrijoDetyrimKlienti":
					Detyrime detyrObject = new Detyrime(varString, varInt1, varInt2);
					b = detyrObject.KrijoDetyrimKlienti();
					break;
				
					
			}
			return b;
		}
		public int VeprimeUpdate (string idVeprime , int varInt, string varString,int varInt1,int varInt2)
		{
			int b = 0;
			switch (idVeprime)
			{
			
			
				case "KrijoDhome":
					Dhoma dhomaObject = new Dhoma(varString, varInt1, varInt2);
					b = dhomaObject.KrijoDhome(varInt);
					break;
				default:
					b = 0;
					break;					
			}
			return b;
		}
		


		public int VeprimeUpdate (string idVeprime,string varString1,string varString2,int varInt)
		{
			int b = 0;
			
			switch(idVeprime)
			{
				case "ModifikoFormePagese":
					Arka arkaObject = new Arka();
					b = arkaObject.ModifikoFormePagese(varString1, varString2, varInt);
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int VeprimeUpdate (string idVeprime, int varInt ,string varString1,string varString2, string varString3)
		{
			int b = 0;
			switch(idVeprime)
			{
				case "ModifikoGrup":
					Klienti klienti = new Klienti(varString1,varString2, varString3);
					b = klienti.ModifikoGrup(varInt);
					break;
				case "ModifikoFormePagese":
					Arka arkaObject = new Arka();
					b = arkaObject.ModifikoFormePagese(varString1, varString2, varInt);
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		public int VeprimeUpdate (string idVeprime,string varString1,int varInt1)
		{
			int b = 0;
			switch(idVeprime)
			{
				case "KrijoLlojDetyrimi":
					Detyrime detyrObject = new Detyrime(varString1, varInt1);
					b = detyrObject.KrijoLlojDetyrimi();
					break;
				case "ModifikoKategori":
					Kategorite kategorite = new Kategorite(varString1);
					b = kategorite.ModifikoKategori(varInt1);
					break;
				case "ModifikoLlojIdentifikimi":
					Identifikimi identifikimi = new Identifikimi(varString1);
					b = identifikimi.ModifikoLlojIdentifikimi(varInt1);
					break;
				case "ModifikoLlojShpenzimi":
					Shpenzime shpenzimeObject = new Shpenzime();
					b = shpenzimeObject.ModifikoLlojShpenzimi(varString1, varInt1);
					break;
			}
			return b;
		}

		public int VeprimeUpdate (string idVeprime,string varString1,float varFloat)
		{
			int b = 0;
			switch(idVeprime)
			{
				
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int VeprimeUpdate (string idVeprime,string varString)
		{
			int b = 0;
			switch (idVeprime)
			{
				case "KrijoLlojIdentifikimi":
					Identifikimi identObject = new Identifikimi(varString);
					b = identObject.KrijoLlojIdentifikimi();
					break;
				case "KrijoKategori":
					Kategorite kategorite = new Kategorite(varString);
					b = kategorite.KrijoKategori();
					break;
				case "ShtoLlojShpenzimi":
					Shpenzime shpenzimeObject = new Shpenzime();
					b = shpenzimeObject.ShtoLlojShpenzimi(varString);
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}
		       
		public int VeprimeUpdate(string idVeprime , int varInt)
		{
			int b = 0;
			
			switch(idVeprime)
			{
				case "FshiKaparKlientiNgaArka":
					Arka d = new  Arka();
					b = d.FshiKaparKlientiNgaArka(varInt);
					break;
				case "FshiDetyriminPerKlient":
					Detyrime detyrObject = new Detyrime();
					b = detyrObject.FshiDetyrimKlienti(varInt);
					break;
				case "FshiDhome":
					Dhoma dhomaObject = new Dhoma();
					b = dhomaObject.FshiDhome(varInt);
					break;
				case "FshiShpenzim":
					Shpenzime shpenzObject = new Shpenzime();
					b = shpenzObject.FshiShpenzim(varInt);
					break;
				case "FshiLlojDetyrimi":				
					Detyrime detyrObject1 = new Detyrime();
					b = detyrObject1.FshiLlojDetyrimi(varInt);
					break;
				case "FshiMjetIdentifikimi":
					Identifikimi identObject = new Identifikimi();
					b = identObject.FshiLlojIdentifikimi(varInt);
					break;
				case "FshiKategori":
					Kategorite katObject = new Kategorite();
					b = katObject.FshiKategori(varInt);
					break;
				case "FshiGrup":
					Klienti klienti = new Klienti();
					b = klienti.FshiGrup(varInt);
					break;
				case "EleminoPerdorues":
					Perdorues perdorues = new Perdorues();
					b = perdorues.FshiPerdorues(varInt);
					break;
				case "KntGjendjeDhome":
					Dhoma dhomaObject1 = new Dhoma();
					b = dhomaObject1.KntGjendjeDhome(varInt);
					break;
				case "FshiLlojShpenzimi":
					Shpenzime shpenzimeObject = new Shpenzime();
					b = shpenzimeObject.FshiLlojShpenzimi(varInt);
					break;
				case "FshiFormePagese":
					Arka arkaObject = new Arka();
					b = arkaObject.FshiFormePagese(varInt);
					break;
				default:
					b = 1;
					break;
			}
			return b ;
		}
		public int VeprimeUpdate(string idVeprime , int[] varInt)
		{
			int b = 0;
			
			switch(idVeprime)
			{
				case "PaguajDhome":
					Klienti klientiObject = new Klienti();
					b = klientiObject.PaguajDhome(varInt);
					break;
				default:
					b = 1;
					break;
			}
			return b ;
		}
		public int VeprimeUpdate(string idVeprime,int varInt1,int varInt2)
		{
			int b = 0;
			switch(idVeprime)
			{
				case "FshiDhomeRezervuarGrupi":
					Rezervimi rezervim = new Rezervimi();
					b = rezervim.FshiDhomeRezervuarGrupi(varInt1,varInt2);
					break;
				case "FshiKlient":
					Klienti klientiObject = new Klienti();
					b = klientiObject.FshiKlient(varInt1,varInt2);
					break;	
				case "FshiRezervim":
					Rezervimi rezervim1 = new Rezervimi();
					b = rezervim1.FshiRezervim(varInt1,varInt2);
					break;
			}
			return b;
		}
		public int VeprimeUpdate(string idKerkesa,int varInt1,int [] varInt2)
		{
			int b = 0;
			
			switch(idKerkesa)
			{
				case "KrijoRezervimDhomeGrupi":
					Rezervimi rezervim = new Rezervimi();
					b = rezervim.KrijoRezervimDhomeGrupi(varInt1,varInt2);
					break;
				default:
					b = 1;
					break;
			}
			return b;

		}

		//		public int VeprimeUpdate (string idVeprime , int varInt, string varString,int varInt1,int varInt2)
		//		{
		//			int b = 0;
		//			switch (idVeprime)
		//			{
		//			
		//				case "ModifikoDhome":
		//				{
		//					Dhoma dhomaObject = new Dhoma(varString, varInt1, varInt2);
		//					b = dhomaObject.ModifikoDhome(varInt);
		//					break;
		//				}
		//				default:
		//					b = 0;
		//					break;					
		//			}
		//			return b;
		//		}
		public int VeprimeUpdate (string idVeprime,string varString1 ,string varString2,
			int varInt,int varInt1,DateTime varDate1,DateTime varDate2,
			DateTime varDate3, int varInt4, string varString3, int varInt5 )
		{
			int b = 0;
			switch(idVeprime)
			{
				case "KrijoRezervimKlienti":
					// varString1 sherben si emer klienti
					// varString2 sherben si mbiemer klienti
					// varInt sherben si kapari
					// varInt1 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate 2 sherben si date mbarimi
					// varDate3 sherben si date rezervimi
					// varInt3 sherben si idFormaPagesa
					// varString3 sherben si adresa e emailit
					// varInt5 sherben si ide perdoruesit qe eshte loguar
				{
					Rezervimi rezervObject = new Rezervimi(varDate1,varDate2,varDate3,varInt,varString1,varString2,varInt1, varString3);
					b = rezervObject.KrijoRezervimKlienti();
					int id_rez = Convert.ToInt32(rezervObject.id_rez_fundit().Tables[0].Rows[0][0]);
					if (( b == 0)&&(varInt > 0))//hedhja ne arke behet vetem nqs kapari eshte > 0
					{
						Arka arkaObject = new Arka();
						b = b + arkaObject.HidhKaparRezervimi(varDate3,varInt, "Kapar rezervimi", id_rez, varInt4, varString1 + " " + varString2, varInt5);;
					}
					break;
				}
				default :
					b = 1;
					break;
			}
			return b;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="idVeprime"></param>
		/// <param name="varInt1">idKlienti</param>
		/// <param name="varString1">emer</param>
		/// <param name="varString2">mbiemer</param>
		/// <param name="varInt2">kapari</param>
		///  <param name="varInt3">idDhoma</param>
		///  <param name="varInt4">idRezervimi</param>
		/// <param name="varDate1">dtFillimi</param>
		/// <param name="varDate2">dtMbarimi</param>
           
		/// <returns></returns>
		public int VeprimeUpdate (string idVeprime,string varString1 ,string varString2,
			int varInt1,DateTime varDate1,DateTime varDate2,DateTime varDate3,
			int varInt2,int varInt3,int varInt4, int varInt5, string varString3, int varInt6)
		{
			int b = 1;
			switch(idVeprime)
			{
				case "ModifikoRezervimKlienti":
					//varint2 idRezervimi
					//varInt6 idPerdoruesi
					b = 0;
					Rezervimi rezervObject = new Rezervimi(varDate1,varDate2,varDate3,varInt1,
						varString1,varString2,varInt3, varString3);
					b = b + rezervObject.ModifikoRezervimKlienti(varInt2,varInt4,varDate3);
					Arka arkaObject = new Arka();
					if (varInt1 == 0)
					{
						//fshihet hedhja ne arke nqs kapari eshte 0
						b = b + arkaObject.FshiKaparRezervimiNgaArka( varInt2);
					}
					else
					{
						DataSet dsArkaRezervim = arkaObject.KaparRezervimiNeArke(varInt2);
						if (dsArkaRezervim.Tables[0].Rows.Count == 0)//me pare nuk ka patur hedhje ne arke
						{
							b = b + arkaObject.HidhKaparRezervimi(varDate3, varInt1,"Kapar rezervimi", 
								varInt2, varInt5, varString1 + " " + varString2, varInt6);
						}
						else//me pare ka patur hedhje ne arke mjafton te modifikohet ekzistuesja
						{
							b = b + arkaObject.ModifikoArka(varDate3,varInt1, "Kapar rezervimi", varInt5, varInt2, varString1 + " " + varString2, varInt6 );	
						}
					}
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		public int VeprimeUpdate (string idVeprime,int varInt1,int varInt2,
			int varInt3,DateTime varDate1,DateTime varDate2,DateTime varDate3,
			int varInt4, int varInt5, int varInt6, int varInt7 )
		{
			int b = 0;
			switch(idVeprime)
			{
				case "ModifikoRezervimGrupi":
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
					Klienti klientiObject = new Klienti();
					DataSet dsGrupi = klientiObject.ShfaqGrupinPerId(varInt1);
					string emri = Convert.ToString(dsGrupi.Tables[0].Rows[0]["EMRI"]);
					string agjensia = Convert.ToString(dsGrupi.Tables[0].Rows[0]["AGJENSIA"]);
					Rezervimi rezervObject = new Rezervimi(varDate1,varDate2,varDate3,varInt2,varInt1);
					b = rezervObject.ModifikoRezervimGrupi(varInt3,varDate1);
					Arka arkaObject = new Arka();
					if (varInt2 == 0)
					{
						//fshihet hedhja ne arke nqs kapari eshte 0
						b = b + arkaObject.FshiKaparRezervimiNgaArka( varInt3);
					}
					else
					{
						DataSet dsArkaRezervim = arkaObject.KaparRezervimiNeArke(varInt3);
						if (dsArkaRezervim.Tables[0].Rows.Count == 0)//me pare nuk ka patur hedhje ne arke
						{
							//							b = b + arkaObject.HidhKaparRezervimi(varDate3, varInt2,"Kapar rezervimi", varInt3, varInt4, "");
							b = b + arkaObject.HidhKaparRezervimi(varDate3, varInt2, "Kapar rezervimi", varInt3, varInt4, varInt1, varInt7);
						}
						else//me pare ka patur hedhje ne arke mjafton te modifikohet ekzistuesja
						{
							b = b + arkaObject.ModifikoArka(varDate3,varInt2, "Kapar rezervimi", varInt4, varInt3,varInt1, varInt7);	
						}
					}
					//nqs per rezervimin ka tashme hyrje ne hotel behet modifikimi i vleres
					//se kaparit per pergjegjesin e grupit
					if ((b == 0)&&(varInt6 > 0))
					{
						b += klientiObject.ModifikoKaparKlienti(varInt6, varInt5);
					}
					break;
				default:
					b = 1;
					break;
				
			}
			return b;
		}
		public int VeprimeUpdate(string idVeprime,string varString1,string varString2,DateTime varDate1,int varInt1,
			string varString3,string varString4,string varString5,string varString6,string varString7,int varInt2,
			int varInt3,DateTime varDate2,DateTime varDate3, int varInt4,DateTime varDate4,
			string varString8, string varString9, int varInt5, int varInt6, int varInt7, int varInt8)
		{
			int b = 0;
			switch(idVeprime)
			{
				case "FutRezervimKlientiNeDhome":
				{
					//Shtohet identifikimi i ri ne database
					// varInt3 kapari per dhomen
					// varInt5 kapari i rezervimit
					// varInt5 i per pergjegjesin e dhomes
					//varInt8 sherben si id e perdoruesit qe ka bere transaksionin ne arke
					Inicializimi iniObject = new Inicializimi();
					Identifikimi identObject  = new Identifikimi(varInt1,varString3);
					int i  = identObject.KrijoIdentifikimi();
					if (i == 0)
					{
						iniObject.Inicializo();
						int idIdentifikimi = iniObject.idIdentifikimi ;
						Klienti klientObject  = new Klienti(varString1,varString2,varDate1,varString4,varString5,
							varString7,varString6,varDate2,varDate3,varInt3,idIdentifikimi,varInt2, varString8, varString9);
						//krijohet klienti ne saje te rezervimit 
						b = b + klientObject.KrijoKlient(varDate4, varInt4);
						if ((b == 0)&&(varInt7 == 0))
						{
							//Fshihet rezervimi i dhomes pasi kjo dhome nuk do jete me e rezervuar
							Rezervimi rezervObject = new Rezervimi();
							b = b + rezervObject.FshiRezervim(varInt4, 0);
							int id_klienti = Convert.ToInt32(klientObject.gjej_id_klienti_fundit().Tables[0].Rows[0][0]);
							if ((b == 0)&&(varInt3 > 0))//nqs kapari per dhomen eshte > 0
							{
								Arka arkaObject = new Arka();
								//hidhet kapari i dhene nga klienti per dhomen ne arke nqs eshte me i madh se 0
								b = b + arkaObject.Hidh(varDate4,varInt3, "Kapar dhome", id_klienti, varInt6, varInt8);
							}
							// kaparit te klientit i shtohet kapari i rezervimit nqs ky eshte me i madh se 0 dhe nqs eshte pergjegjes.
							if ((b == 0)&&(varInt5 > 0) &&(varInt7 == 0))
							{
								int kapariRi = varInt3 + varInt5;
								b = b + klientObject.ModifikoKaparKlienti(id_klienti, kapariRi);
							}
						}
					}
					break;
				}
					
			}
			return b;
		}
		
		public int VeprimeUpdate(string idVeprime,string varString1,string varString2,DateTime varDate1,
			int varInt1,string varString3,string varString4,string varString5,string varString6,string varString7,
			int varInt2,int varInt3,DateTime varDate2,DateTime varDate3,int varInt4,int varInt5,DateTime varDate4,
			string varString8, string varString9, int varInt6, int varInt7, int varInt8, bool varBool, int varInt9)
		{
			int b = 0;
			switch (idVeprime)
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
					// varInt3 sherben si kapari per grupin
					// varDate2 sherben si dtFillimi
					// varDate3 sherben si dtMbarimi
					// varInt4 sherben si idGrupi
					// varInt5 sherben si idRezervimi
					// varDate4 sherben si datakapari
					// varString8 sherben si vendlindja
					// varString9 sherben si shtetesia
					// varInt6 sherben si kapari i rezervimit
					// varInt7 sherben si idFormaPagesa
					// varInt8 sherben si i
					// varBool sherben per te treguar nqs i eshte hedhur ose jo kapari grupit
					// nqs varBool = false atehere kapari i klientit bashkohet me kaparin e rezervimit
					// perndryshe kapari i klientit mbetet 0
					// varInt9 sherben si id e perdoruesit qe ka bere rezervimin ne arke
					Inicializimi iniObject = new Inicializimi();
					Identifikimi identObject  = new Identifikimi(varInt1,varString3);
					b  = identObject.KrijoIdentifikimi();
					if (b == 0)
					{
						iniObject.Inicializo();
						int idIdentifikimi = iniObject.idIdentifikimi;
						Klienti klientObject  = new Klienti(varString1,varString2,varDate1,varString4,
							varString5,	varString6,varString7,varDate2,varDate3,varInt3,idIdentifikimi,varInt2, varString8, varString9);
						b = b + klientObject.KrijoKlient(varDate4, varInt5);
						if ( b == 0)
						{
							// Fshihet rezervimi i dhomes pasi kjo dhome nuk do jete me e rezervuar
							Rezervimi rezervObject = new Rezervimi();
							iniObject.Inicializo();
							int idKlienti = iniObject.idKlienti;
							b = b + klientObject.KrijoKlientGrup(varInt4,idKlienti);
							if (varInt8 == 0)
								b = b + rezervObject.FshiDhomeRezervuarGrupi(varInt5,varInt2);
							//							int id_klienti = Convert.ToInt32(klientObject.gjej_id_klienti_fundit().Tables[0].Rows[0][0]);
							if ((b == 0)&&(varInt3 > 0))
							{
								Arka arkaObject = new Arka();
								// hidhet kapari i grupit ne arke ne emer te perdoruesit qe eshte loguar
								if(varInt3 > 0)
								{
									b = b + arkaObject.Hidh(varDate4,varInt3, "Kapar grupi", idKlienti, varInt7, varInt9);	
								}
							}
							//nqs kapari i rezervimit eshte me i madhe se 0 ath
							//ky kapar i shtohet kaparit te grupit
							if ((b == 0)&&(varInt6 > 0)&&(varInt8 == 0)&&(varBool == false))
							{
								int kapariRi = varInt3 + varInt6;
								b = b + klientObject.ModifikoKaparKlienti(idKlienti, kapariRi);
							}
						}
					}
					break;
				default:
					b = 1;
					break;
			}
			return b;
		}

		
		
	
		public int VeprimeUpdate(string idVeprime,string varString1,string varString2,DateTime varDate1, 
			int varInt1,string varString3, string varString4, string varString5, string varString6,
			string varString7, int varInt2, DateTime varDate2, DateTime varDate3,
			int varInt3,DateTime varDate4, string varString8, string varString9, int varInt4, int varInt5)
		{
			int b = 0 ;
			switch(idVeprime)
			{
				case"FutKlientiNeDhome":
				{
					Inicializimi iniObject = new Inicializimi();
					Identifikimi identObject  = new Identifikimi(varInt1,varString3);
					int i  = identObject.KrijoIdentifikimi();
					if (i == 0)
					{
						iniObject.Inicializo();
						
						int idIdentifikimi = iniObject.idIdentifikimi;
						// varString1 sherben si emer klienti
						// varString2 sherben si mbiemer klienti
						// varDate1 sherben si datelindja e klientit
						// varInt1 sherben si ID_LLOJIDENTIFIKIMI
						// varString3 shereben si numer identifikimi
						// varString4 sherben si adrese
						// varString5 sherben si numer telefoni
						// varString6 sherben si targe makine
						// varString7 sherben si adrese emaili
						// varInt2 sherben si ID_DHOMA
						// varDate2 sherben si date fillimi
						// varDate3 sherben si date mbarimi
						// varInt3 sherben si kapari
						// varDate4 sherben si data_kapari
						// varString8 sherben si vendlindja
						// varString9 sherben si shtetesia
						// varInt4 sherben si id e formes me te cilen do te paguhet
						// varInt5 sherben si username per perdoruesin i cili eshte loguar
						Klienti klientObject  = new Klienti(varString1,varString2,varDate1,varString4,
							varString5,	varString6,varString7,varDate2,varDate3,varInt3,idIdentifikimi,varInt2, varString8, varString9);
						int k = klientObject.KrijoKlient(varDate4);

						if ( k == 0)
						{
							Dhoma dhomaObject = new Dhoma();
							Arka arkaObject = new Arka();
							//i hidhet kapari njerit prej klienteve nese ai eshte pozitiv
							if (varInt3 > 0)
							{
								int id_klienti = Convert.ToInt32(klientObject.gjej_id_klienti_fundit().Tables[0].Rows[0][0]);
								int a = arkaObject.Hidh(varDate4,varInt3, "Kapar dhome", id_klienti, varInt4, varInt5);
								b =  a;
							}
						}
						else
							b = k;
					}
					else
						b = i;
					break;
				}
					
			}
			return b ;
		}
		
		public int VeprimeUpdate(string idVeprime,int varInt,string varString3,string varString4,
			DateTime varDate,int varInt1,string varString5,string varString6,string varString7,
			string varString8,string varString9,int varInt2,DateTime varDate1,DateTime varDate2,int varInt3,DateTime varDate4,
			string varString10,string varString11, int varInt4, int varInt5)
		{
			int b = 0 ;
			switch(idVeprime)
			{
				case"FutKlientGrupiNeDhome":
				{
					//varInt    sherben si idGrupi
					// varString3 sherben si emer klienti
					// varString4 sherben si mbiemer klienti
					// varDate1 sherben si datelindja e klientit
					// varInt1 sherben si ID_LLOJIDENTIFIKIMI
					// varString5 sherben si numer identifikimi
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
					// varint4 sherben si idFormaPagesa
					// varInt5 sherben si id e perdoruesit qe ka bere transaksionin ne arke
					Inicializimi iniObject = new Inicializimi();
					Identifikimi identObject  = new Identifikimi(varInt1,varString5);
					int i  = identObject.KrijoIdentifikimi();
					if (i == 0)
					{
						iniObject.Inicializo();
						int idIdentifikimi = iniObject.idIdentifikimi ;
						Klienti klientObject  = new Klienti(varString3,varString4,varDate1,
							varString6,varString7,varString9,varString8,varDate1,varDate2,varInt3,idIdentifikimi,varInt2, varString10, varString11);
						b = b +  klientObject.KrijoKlient(varDate4);
						if( b == 0 )
						{
							iniObject.Inicializo();
							int idKlienti = iniObject.idKlienti;
							b = b +  klientObject.KrijoKlientGrup(varInt,idKlienti);
							
							Dhoma dhomaObject = new Dhoma();
							if (varInt3 > 0)
							{
								int id_klienti = Convert.ToInt32(klientObject.gjej_id_klienti_fundit().Tables[0].Rows[0][0]);
								Arka arkaObject = new Arka();
								b = b +  arkaObject.Hidh(varDate4 , varInt3, "Kapar grupi", id_klienti, varInt4, varInt5);
							}	
						}		
					}	
					else b = i;
				}
					break;
				default:
					b = 1;
					break;
			}
			return b ;
		}

		public int VeprimeUpdate(string idVeprime,int varInt,string varString3,string varString4,
			DateTime varDate,int varInt1,string varString5,string varString6,string varString7,
			string varString8,string varString9,int varInt2,DateTime varDate1,DateTime varDate2,int varInt3,DateTime varDate4,
			string varString10,string varString11, int varInt4, int varInt5,int varInt6)
		{
			int b = 0 ;
			switch(idVeprime)
			{
				case"FutKlientGrupiNeDhome":
				{
					//varInt sherben si idGrupi
					// varString3 sherben si emer klienti
					// varString4 sherben si mbiemer klienti
					// varDate1 sherben si datelindja e klientit
					// varInt1 sherben si ID_LLOJIDENTIFIKIMI
					// varString5 sherben si numer identifikimi
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
					// varint4 sherben si idFormaPagesa
					// varInt5 sherben si idRezervimi
					// varInt6 sherben si id e perdoruesit qe ka bere transaksionin ne arke
					Inicializimi iniObject = new Inicializimi();
					Identifikimi identObject  = new Identifikimi(varInt1,varString5);
					int i  = identObject.KrijoIdentifikimi();
					if (i == 0)
					{
						iniObject.Inicializo();
						
						int idIdentifikimi = iniObject.idIdentifikimi ;
						Klienti klientObject  = new Klienti(varString3,varString4,varDate1,
							varString6,varString7,varString9,varString8,varDate1,varDate2,varInt3,idIdentifikimi,varInt2, varString10, varString11);
						b = b +  klientObject.KrijoKlient(varDate4, varInt5);
						if( b == 0 )
						{
							iniObject.Inicializo();
							int idKlienti = iniObject.idKlienti;
							b = b +  klientObject.KrijoKlientGrup(varInt,idKlienti);
							
							Dhoma dhomaObject = new Dhoma();
							if (varInt3 > 0)
							{
								//hedhja ne arke behet ne emer te perdoruesit qe eshte loguar
								int id_klienti = Convert.ToInt32(klientObject.gjej_id_klienti_fundit().Tables[0].Rows[0][0]);
								Arka arkaObject = new Arka();
								b = b +  arkaObject.Hidh(varDate4 , varInt3, "Kapar grupi", id_klienti, varInt4, varInt6);
							}	
						}		
					}	
					else b = i;
				}
					break;
				default:
					b = 1;
					break;
			}
			return b ;
		}

		public int VeprimeUpdate(string idVeprime,string varString1,string varString2,DateTime varDate1,
			string varString3,string varString4,string varString5,string varString6,
			DateTime varDate2,DateTime varDate3,int varInt1,string varString7,
			int varInt2,int varInt3, string varString8, string varString9)
		{
			int b = 0 ;
			switch(idVeprime)
			{
				case"ModifikoTeDhenaKlienti":
					Klienti klientiObject = new Klienti();
					b = klientiObject.ModifikoTeDhenaKlienti(varString1,varString2, varDate1, varString3, varString4, varString5,
						varString6, varDate2, varDate3, varInt1,
						varString7, varInt2, varInt3,varString8, varString9);
					break;
				default:
					b = 1;
					break;
					
			}
			return b ;
		}
		public int VeprimeUpdate(string idVeprime,string varString1,string varString2,DateTime varDate1,
			string varString3,string varString4,string varString5,string varString6,
			DateTime varDate2,DateTime varDate3,int varInt1,string varString7,
			int varInt2,int varInt3, string varString8, string varString9, int varInt4)
		{
			int b = 0 ;
			switch(idVeprime)
			{
				case"ModifikoTeDhenaPergjegjes":
					//varInt4 sherben si idPerdoruesi
					Klienti klientiObject1 = new Klienti();
					b = klientiObject1.ModifikoTeDhenaPergjegjes(varString1,varString2, varDate1, varString3,
						varString4, varString5, varString6, varDate2, varDate3, varInt1, 
						varString7, varInt2, varInt3, 0,varString8, varString9, varInt4);
					break;
				default:
					b = 1;
					break;
					
			}
			return b ;
		}
		public int VeprimeUpdate(string idVeprime,string varString1,string varString2,DateTime varDate1,
			string varString3,string varString4,string varString5,string varString6,
			DateTime varDate2,DateTime varDate3,int varInt1,string varString7,
			int varInt2,int varInt3, int varInt4, string varString8, string varString9)
		{
			int b = 0 ;
			switch(idVeprime)
			{
				case"ModifikoTeDhenaKlientiGrupi":
					//varInt4 sherben si idGrupi
					Klienti klientiObject = new Klienti();
					b = klientiObject.ModifikoTeDhenaKlientiGrupi(varString1,varString2, varDate1, varString3,
						varString4, varString5, varString6, varDate2, varDate3, varInt1, varString7,
						varInt2, varInt3, varInt4,varString8, varString9);
					break;
				default:
					b = 1;
					break;
					
			}
			return b ;
		}
		public int VeprimeUpdate(string idVeprime,string varString1,string varString2,DateTime varDate1,
			string varString3,string varString4,string varString5,string varString6,
			DateTime varDate2,DateTime varDate3,int varInt1,string varString7,
			int varInt2,int varInt3, int varInt4, string varString8, string varString9, int varInt5)
		{
			int b = 0 ;
			switch(idVeprime)
			{
				case"ModifikoTeDhenaPergjegjesGrupi":
					//varInt4 sherben si idGrupi
					//varInt5 idPerdoruesi
					Klienti klientiObject1 = new Klienti();
					b = klientiObject1.ModifikoTeDhenaPergjegjesGrupi(varString1,varString2, varDate1, 
						varString3, varString4, varString5, varString6, varDate2, varDate3, varInt1, 
						varString7, varInt2, varInt3, varInt4,varString8, varString9, varInt5);
					break;
				default:
					b = 1;
					break;
					
			}
			return b ;
		}
		public int VeprimeUpdate(string idVeprime,string varString1,string varString2,DateTime varDate1,
			string varString3,string varString4,string varString5,string varString6,
			DateTime varDate2,DateTime varDate3,int varInt1,string varString7,
			int varInt2,int varInt3, int varInt4, int varInt5, int varInt6, int varInt7, DateTime varDate4,
			string varString8, string varString9, int varInt8)
		{
			int b = -1 ;
			switch(idVeprime)
			{
				case"ModifikoTeDhenaPergjegjes":
					Klienti klientiObject = new Klienti();
					//varInt8 idPerdoruesi
					b = klientiObject.ModifikoTeDhenaPergjegjes(varString1,varString2, varDate1,
						varString3, varString4, varString5, varString6, varDate2, varDate3, varInt1,
						varString7, varInt2, varInt3, varInt4, varInt5, varInt6, varInt7, varDate4,
						varString8, varString9, varInt8);
					break;
				default:
					b = -1;
					break;
			}
			return b ;
		}

		public int VeprimeUpdate(string idVeprime,string varString1,string varString2,DateTime varDate1,
			string varString3,string varString4,string varString5,string varString6,
			DateTime varDate2,DateTime varDate3,int varInt1,string varString7,
			int varInt2,int varInt3, int varInt4, int varInt5, int varInt6, int varInt7,
			DateTime varDate4, int varInt8, string varString8, string varString9, int varInt9)
		{
			int b = 1 ;
			switch(idVeprime)
			{
				case"ModifikoTeDhenaPergjegjesGrupi":
					//varInt9 idPerdoruesi
					Klienti klientiObject = new Klienti();
					b = klientiObject.ModifikoTeDhenaPergjegjesGrupi(varString1,varString2,
						varDate1, varString3, varString4, varString5, varString6,
						varDate2, varDate3, varInt1, varString7, varInt2, varInt3, 
						varInt4, varInt5, varInt6, varInt7, varDate4, varInt8, varString8, varString9, varInt9);
					break;
				default:
					b = 1;
					break;
			}
			return b ;
		}
		#endregion VeprimeUpdate

		#region VeprimeRead
		
		public DataSet VeprimeRead(string idVeprime,  DateTime data)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqDhomaCmimiTeDhene":
					CmimiDhoma cmimiDhoma = new CmimiDhoma();
					//ds = cmimiDhoma.NxirrCmimiDhoma(data);
					break;
				case "GjendjaReale":
					Arka arkaObject1 = new Arka();
					ds = arkaObject1.GjendjaReale(data);
					break;
				case "ShfaqRezervim":
					Rezervimi rezervObject = new Rezervimi();
					//dr = rezervObject.ShfaqRezervim(data);
					break;
				case "ShfaqGjendjenEdhomavePerDatenEdhene":
					Dhoma dhomaObject = new Dhoma();
					ds = dhomaObject.ShfaqGjendjeDhomat(data);
					break;
				case "ShfaqRezervimetPerKlientPerDatenEdhene":
					Rezervimi rezervimi = new Rezervimi();
					ds = rezervimi.ShfaqRezervimeKlientPerDaten(data);
					break;
			
				case "ShfaqRezervimetPerGrupPerDatenEdhene":
					Rezervimi rezervimi2 = new Rezervimi();
					ds = rezervimi2.ShfaqRezervimeGrupPerDaten(data);
					break;
				case "ShfaqRezervimetPerGrupDhomePerDatenEdhene":
					Rezervimi rezervimi3 = new Rezervimi();
					ds = rezervimi3.ShfaqRezervimeGrupDhomePerDaten(data);
					break;
				case "GjendjaRealeArke":
					Arka ArkaObject = new Arka(data);
					ds =ArkaObject.GjendjaReale(data);
					break;
				case "ShfaqShpenzimetPerDatenEdhene":
					Shpenzime ShpenzimeObject = new Shpenzime();
					ds = ShpenzimeObject.ShfaqShpenzime(data);
					break;
				case "ShfaqBilanciPerDatenEdhene":
					Arka ArkaObject1 = new Arka(data);
					ds =ArkaObject1.Bilanci();
					break;
				case "ShfaqBilanciPerDatenEdheneDetaje":
					Arka ArkaObject2 = new Arka(data);
					ds =ArkaObject2.BilanciDetaje();
					break;
				case "ShfaqBilanciPerDatenEdheneJanusGrid":
					Arka arka2 = new Arka(data);
					ds = arka2.BilanciJanusGrid();
					break;
				case "ShfaqCmimetEdhomavePerDatenEdhene":
					CmimiDhoma cmdhomaObject = new CmimiDhoma();
					ds = cmdhomaObject.NxirrCmimiDhomaData(data);
					break;
				case "ShfaqKlientetNeHotel":
					Klienti klienti = new Klienti();
					ds = klienti.ShfaqKlientetDhomatNeHotel2();
					break;
				case "BilancMujorPerVitinKorrent":
					Arka arkaObject2 = new Arka();
					ds = arkaObject2.BilanciTjeter(data);
					break;
				case "ShfaqRezervimeVlefshmeKlientiPerDatenEdhene":
					Rezervimi rezervimiObject= new Rezervimi();
					ds = rezervimiObject.ShfaqRezervimeVlefshmeKlientiPerDaten(data);
					break;
					//				case "ShfaqRezervimeVlefshmePerDatenEdhene":
					//					Rezervimi rezervimi1 = new Rezervimi();
					//					ds = rezervimi1.ShfaqRezervimeVlefshmeKlienti();
					//					break;
				case "ShfaqRezervimeVlefshmeGrupiPerDaten":
					Rezervimi rezerv = new Rezervimi();
					ds = rezerv.ShfaqRezervimeVlefshmeGrupiPerDaten(data);
					break;
				default:
					ds = null;
					break;

			}
			return ds;
		}
		
		public DataSet VeprimeRead(string idVeprime,  DataSet vards, DateTime varDate1)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ModifikoDataSet":
					Dhoma dhomaObject = new Dhoma();
					//ds =dhomaObject.ModifikoDataSet(vards, varDate1);
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet VeprimeRead(string idVeprime, int varInt1, DateTime varDate1, DateTime varDate2)
		{
			DataSet ds = null;
			switch (idVeprime)
			{	
				case "DhomatEZenaPerDatatPaRezervim":
					Dhoma dhomaObject = new Dhoma();
					ds = dhomaObject.ShfaqDhomatEZena(varInt1, varDate1,varDate2);
					break;
				case "RezervimetPerDatatDheGrupin":
					Rezervimi rezervimeObject = new Rezervimi();
					ds = rezervimeObject.ShfaqRezervimeGrupi(varInt1,varDate1,varDate2);
					break;				
				case "NrDetyrimeshPerKlientJashteDatave":
					Detyrime detyrimeObject = new Detyrime();
					ds = detyrimeObject.NrDetyrimeshPerKlientJashteDatave(varInt1,varDate1,varDate2);
					break;				
				case "NrKlienteNeDhomeNeGrup":
					Dhoma dh1 = new Dhoma();
					ds = dh1.NrKlienteNeDhomeNeGrup(varInt1,varDate1,varDate2);
					break;
				case "NumerKlienteshPerDateGrup":
					Klienti kl2 = new Klienti();
					ds = kl2.NumerKlienteshPerDateGrup(varInt1,varDate1,varDate2);
					break;
				case "NumerKlienteshPerDateDhoma":
					Klienti kl1 = new Klienti();
					ds = kl1.NumerKlienteshPerDateDhoma(varInt1,varDate1,varDate2);
					break;
				case "ShfaqCmimPerDhomenDheDatatEdhena":
					CmimiDhoma cmimi = new CmimiDhoma(varDate1, varDate2);
					ds = cmimi.NxirrCmimiDhomaData(varInt1);
					break;
				case "ShfaqKlientPerDhomePerDatat":
					Klienti kl = new Klienti();
					ds = kl.ShfaqKlientetPerDhomeDataTeDhena(varInt1,varDate1,varDate2);
					break;
				case "ShfaqTeDhenaGrupiPerDatat":
					Klienti klientiObject = new Klienti();
					ds = klientiObject.ShfaqTeDhenaGrupiDataTeDhena(varInt1,varDate1,varDate2);
					break;
				case "ShfaqDhomatEliraPerDatatPerKategorine":
					Dhoma dhoma = new Dhoma();
					ds = dhoma.ShfaqDhomaTeLiraKategoriPerDate(varInt1, varDate1, varDate2);
					break;		
				case "ShfaqDhomatPlotesishtTeLiraPerDatatPerKategorine":
					Dhoma dhoma1 = new Dhoma();
					ds = dhoma1.ShfaqDhomaPlotesishtTeLiraKategoriPerDate(varInt1, varDate1, varDate2);
					break;	
				case "ShfaqDetyrimeKlientePerKategori":
					// Shfaq detyrimet per klientet qe kane dale nga hoteli
					Detyrime detyrime13 = new Detyrime();
					ds = detyrime13.ShfaqDetyrimeKlienteDalePerKategori(varInt1, varDate1, varDate2);
					break;
				case "ShfaqVeprimetPerDatat":
					//varInt1 = 1 per hyrjet e vlefshme
					//varInt1 = 0 per hyrjet jo te vlefshme
					//varint1 = -1 pa kriter
					// dtFillimi sherben si date e fillimit te kerkimit per veprimet
					// dtMbarimi sherben si date e mbarimit te kerkimit per veprimet
					Klienti klientiObject1 = new Klienti();
					ds = klientiObject1.ShfaqKlientet(varInt1,varDate1, varDate2 );
					break;
				case "ShfaqVeprimetNeGrupPerDatat":
					//varInt1 = 1 per hyrjet e vlefshme
					//varInt1 = 0 per hyrjet jo te vlefshme
					//varint1 = -1 pa kriter
					// dtFillimi sherben si date e fillimit te kerkimit per veprimet
					// dtMbarimi sherben si date e mbarimit te kerkimit per veprimet
					Klienti klientiObject2 = new Klienti();
					ds = klientiObject2.ShfaqKlientetNeGrup(varDate1, varDate2,varInt1);
					break;
			}
			return ds;
		}

		public DataSet VeprimeRead(string idVeprime, int varInt1, DateTime varDate1, DateTime varDate2, int varInt2)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "RezervimetPerDatatDheGrupin":
					Rezervimi rezervimeObject = new Rezervimi();
					ds = rezervimeObject.ShfaqRezervimeGrupi(varInt1,varDate1,varDate2, varInt2);
					break;	
				case "ShfaqDhomatPlotesishtTeLiraPerDatatPerKategorinePerModifikim":
					Dhoma dhomaObject = new Dhoma();
					ds = dhomaObject.ShfaqDhomaPlotesishtTeLiraKategoriPerDatePerModifikim(varInt1, varDate1, varDate2, varInt2);
					break;
				case "ShfaqDhomatEliraPerDateKategoriPerModifikim":
					Dhoma dhoma = new Dhoma();
					ds = dhoma.ShfaqDhomaTeLiraKategoriPerDatePerModifikim(varInt1, varDate1, varDate2, varInt2);
					break;
				case "NumerKlienteshPerDateDhoma":
					Dhoma dhoma1 = new Dhoma();
					ds = dhoma1.NumerKlienteshPerDateDhoma(varInt1, varDate1, varDate2, varInt2);
					break;
				case "nrKlienteNeDhomePerGrup":
					// varInt1 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt2 sherben si ID_GRUPI
					Dhoma dhoma2 = new Dhoma();
					ds = dhoma2.NrKlienteNeDhomePerGrup(varInt1, varDate1, varDate2, varInt2);
					break;
				case "NumerKlienteshPerDateGrupPerModifikim":
					// varInt1 sherben si ID_GRUPI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt2 sherben si ID_KLIENTI
					Klienti klientiObject = new Klienti();
					ds = klientiObject.NumerKlienteshPerDateGrupPerModifikim(varInt1, varDate1, varDate2, varInt2);
					break;
				case "ShfaqVeprimetPerGrupinPaRezervim":
					// varInt1 sherben si ID_GRUPI
					// varInt2 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varint3 sherben si idklienti
					Klienti klient5 = new Klienti();
					ds = klient5.ShfaqKlientetNeGrupPaRezervim(varInt1, varDate1, varDate2, varInt2);
					break;	
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet VeprimeRead(string idVeprime, int[] varInt1)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqDetyrimePerKlientetPerDhomen" :
					Klienti klientiObject = new Klienti();
					ds = klientiObject.ShfaqDetyrimetPerKlientetPerDhomat(varInt1);
					break;
				case "ShfaqDetyrimePerKlientetEkstra" :
					Klienti klientiObjectIri = new Klienti();
					ds = klientiObjectIri.ShfaqDetyrimeEkstraPerKlientet(varInt1);
					break;
				case "ShfaqDetyrimetPerDhomat" :
					Dhoma dhomaObject = new Dhoma();
					ds = dhomaObject.ShfaqDetyrimetPerDhomat(varInt1);
					break;
				case "ShfaqKlientetPerDhomat" :
					Klienti klienti1 = new Klienti();
					ds = klienti1.ShfaqKlientetPerDhomat(varInt1);
					break;

			}
			return ds;
		}
		
		public DataSet VeprimeRead(string idVeprime, int varInt1, int varInt2)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "NumerKlienteshPerCdoDate":
					Dhoma dhomeObj = new Dhoma();
					ds = dhomeObj.NumerKlienteshPerCdoDate(varInt1, varInt2);
					break;
				case "ShfaqVeprimetPerDhomen":
					//varInt1 sherben si idDhoma
					//varInt2 = 1 per hyrjet e vlefshme
					//varInt2 = 0 per hyrjet jo te vlefshme
					//varInt2 = -1 pa kriter
					Klienti klObject= new  Klienti();
					ds = klObject.ShfaqKlientet(varInt1, varInt2);
					break;
				case "ShfaqVeprimetPerGrupin":
					//varInt1 sherben si idGrupi
					//varInt2 = 1 per hyrjet e vlefshme
					//varInt2 = 0 per hyrjet jo te vlefshme
					//varInt2 = -1 pa kriter
					Klienti klient2 = new Klienti();
					ds = klient2.ShfaqKlientetPerGrup(varInt1, varInt2);
					break;
				case "ShfaqVeprimetPerGrupinPerModifikim":
					//varInt1 sherben si idGrupi
					//varInt2 = 1 per hyrjet e vlefshme
					//varInt2 = 0 per hyrjet jo te vlefshme
					//varInt2 = -1 pa kriter
					Klienti klient3 = new Klienti();
					ds = klient3.ShfaqKlientetPerGrupPerModifikim(varInt1, varInt2);
					break;
				case "ShfaqVeprimetNeGrupPerDhomen":
					//varInt1 sherben si idDhoma
					//varInt2 = 1 per hyrjet e vlefshme
					//varInt2 = 0 per hyrjet jo te vlefshme
					//varInt2 = -1 pa kriter
					Klienti klient4 = new Klienti();
					ds = klient4.ShfaqKlientetNeGrup(varInt1, varInt2);
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}

		public DataSet VeprimeRead(string idVeprime, int varInt1, DateTime varDate1)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqTeDhenatPerDhome":
					Dhoma dhoma2 = new Dhoma();
					ds = dhoma2.NxirrDhomeCmim(varInt1, varDate1);
					break;
				case "ShfaqDhomaPerRezervimGrupiPerdata" :
					Rezervimi rezervimiObject = new Rezervimi();
					ds = rezervimiObject.ShfaqDhomaPerRezervim(varInt1, varDate1);
					break;
				case "NxirrDhomePerDaten" :
					Dhoma dhomaObject = new Dhoma();
					ds = dhomaObject.NxirrDhome(varInt1, varDate1);
					break;
				case "ShfaqKlientetPerDhomenEdhenePerDatenEdhene" :
					Dhoma dhoma1 = new Dhoma();
					ds = dhoma1.ShfaqKlientetPerDhomenPerDatenEdhene(varInt1, varDate1);
					// varInt1 sherben si ID_DHOMA
					// varDate1 sherben si date dorezimi
					break;
				case "ShfaqDhomatEZenaPerKategorine" :
					Dhoma dhomaObject1 = new Dhoma();
					ds = dhomaObject1.ShfaqDhomatEZenaPerKategorine(varInt1, varDate1);
					break;
				case "CmimiDhomesPerDaten" :
					CmimiDhoma cd = new CmimiDhoma();
					ds = cd.NxirrCmimiDhomaPerDaten(varDate1, varInt1);
					break;
				case "ShfaqDhomatPerGrupinEdhene" :
					Dhoma dhomaObject3 = new Dhoma();
					ds = dhomaObject3.ShfaqDhomatPerGrupinEdhene(varInt1, varDate1);
					break;
				case "NumerKlienteshPerDateDhoma":
					Klienti kl1 = new Klienti();
					ds = kl1.NumerKlienteshPerDateDhoma(varInt1,varDate1);
					break;
					//NumerKlienteshPerDateGrup
				default:
					ds = null;
					break;
			}
			return ds;
		}

		public DataSet VeprimeRead(string idVeprime, int varInt1, int varInt2, DateTime varDate1)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqKlientetPerDhomenEdhenePerDatenEdhenePerGrup" :
					Dhoma dhoma2 = new Dhoma();
					ds = dhoma2.ShfaqKlientetPerDhomenPerDatenEdhenePerGrup(varInt1, varInt2, varDate1);
					// varInt1 sherben si ID_DHOMA
					// varDate1 sherben si date dorezimi
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet VeprimeRead(string idVeprime, int varInt1, int varInt2, DateTime varDate1, DateTime varDate2)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqVeprimetPerDhomen":
					//varInt1 sherben si idDhoma
					//varDate1 sherben si dateFillimi
					//varDate2 sherben si dateMbarimi
					//varInt2 = 1 per hyrjet e vlefshme
					//varInt2 = 0 per hyrjet jo te vlefshme
					//varInt2 = -1 pa kriter
					Klienti klient1 = new Klienti();
					ds = klient1.ShfaqKlientet(varInt1, varInt2, varDate1, varDate2);
					break;
				case "ShfaqVeprimetPerGrupin":
					//varInt1 sherben si idGrupi
					//varDate1 sherben si dateFillimi
					//varDate2 sherben si dateMbarimi
					//varInt2 = 1 per hyrjet e vlefshme
					//varInt2 = 0 per hyrjet jo te vlefshme
					//varInt2 = -1 pa kriter
					Klienti klient2 = new Klienti();
					ds = klient2.ShfaqKlientetPerGrup(varInt1, varInt2, varDate1, varDate2);
					break;
				case "ShfaqVeprimetNeGrupPerDhomen":
					//varInt1 sherben si idDhoma
					//varDate1 sherben si dateFillimi
					//varDate2 sherben si dateMbarimi
					//varInt2 = 1 per hyrjet e vlefshme
					//varInt2 = 0 per hyrjet jo te vlefshme
					//varInt2 = -1 pa kriter
					Klienti klient3 = new Klienti();
					ds = klient3.ShfaqKlientetNeGrup(varInt1, varInt2, varDate1, varDate2);
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}

		public DataSet VeprimeRead(string idVeprime, int varInt1, int varInt2, 
			DateTime varDate1, DateTime varDate2, int varInt3)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqVeprimetPerGrupDheDhome" :
					// varInt1 sherben si ID_GRUPI
					// varInt2 sherben si ID_DHOMA
					// varInt1 sherben si date fillimi
					// varInt2 sherben si date mbarimi
					// varInt3 = 1 per hyrjet e vlefshme
					// varInt3 = 0 per hyrjet jo te vlefshme
					// varInt3 = -1 pa kriter
					Klienti klientiObject = new Klienti();
					ds = klientiObject.ShfaqKlientetNeGrup(varInt1, varInt2, varDate1, varDate2, varInt3);
					break;
				case "NrKlienteNeDhomeJoTeGrupitTeDhene":
					// varInt1 sherben si ID_GRUPI
					// varInt2 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varint3 sherben si idklienti
					Klienti klient4 = new Klienti();
					ds = klient4.NrKlienteNeDhomeJoTeGrupit(varInt1, varDate1, varDate2, varInt2, varInt3);
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}

		public DataSet VeprimeRead(string idVeprime, int varInt1)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqDataPerRezervim":
					Rezervimi rObj2 = new Rezervimi();
					ds = rObj2.ShfaqDataPerRezervim(varInt1);
					break;
				case "ShfaqDhomaPerRezervim":
					Rezervimi rObj = new Rezervimi();
					ds = rObj.ShfaqDhomaPerRezervim(varInt1);
					break;
				case "ShfaqVeprimetPerRezervim":
					Klienti klObj = new Klienti();
					ds = klObj.ShfaqKlientetPerRezervim(varInt1);
					break;
				case "ShfaqKaparRezervimiArka":
					Arka arkaObj = new Arka();
					ds = arkaObj.ShfaqKaparRezervimiArka(varInt1);
					break;
				case "ShfaqRezervimeVlefshmePerDhomen":
					Rezervimi rezervObject = new  Rezervimi();
					ds = rezervObject.ShfaqRezervimeVlefshmePerDhome(varInt1);
					break;
				case "ShfaqKlientGrupNeHotelPerModifikim":
					Klienti KlObject = new  Klienti();
					ds = KlObject.ShfaqKlientetNeGrup(varInt1);
					break;
				case "ShfaqRezervimeVlefshmeGrupiPerDhomen":
					Rezervimi rezervObject1 = new  Rezervimi();
					ds = rezervObject1.ShfaqRezervimeVlefshmeGrupiPerDhome(varInt1);
					break;
				case "NxirrDhome":
					Dhoma d = new  Dhoma();
					ds = d.NxirrDhome(varInt1);
					break;
				case "ShfaqLlojDetyriminEzgjedhur":
					Detyrime detyrime = new Detyrime();
					ds = detyrime.NxirrDetyrim(varInt1);
					break;
				case "ShfaqDhomatPerKategorine":
					Dhoma dhoma = new Dhoma();
					ds = dhoma.ShfaqDhomeKategori(varInt1);
					break;
				case "ShfaqDhomatEliraPerKategorine":
					Dhoma dhoma1 = new Dhoma();
					ds = dhoma1.ShfaqDhomaTeLiraKategori(varInt1);
					break;
				case "ShfaqKlientetPerDhomenEdhene":
					Dhoma dhoma11 = new Dhoma();
					ds = dhoma11.ShfaqKlientetPerDhomen(varInt1);
					break;
				case "ShfaqDetyrimePerKlientin":
					Klienti klienti2 = new Klienti();
					ds = klienti2.ShfaqDetyrimePerKlientinPerDhomen(varInt1);
					break;
				case "ShfaqDetyrimePerKlientinEkstra":
					Klienti klienti3 = new Klienti();
					ds = klienti3.ShfaqDetyrimeEkstraPerKlientin(varInt1);
					break;
				case "ShfaqDataPerKlientin":
					Klienti klienti1 = new Klienti();
					ds = klienti1.ShfaqDataPerKlientin(varInt1);
					break;
				case "ShfaqCmimetPerDhomenEdhene":
					CmimiDhoma cmDhomaObject = new CmimiDhoma();
					ds = cmDhomaObject.NxirrCmimiDhoma(varInt1);
					break;

				case "ShfaqCmimetPerShtreteritEdhene":
					CmimiDhoma cmDhomaObject2 = new CmimiDhoma();
					ds = cmDhomaObject2.NxirrCmimiDhomaPerShtreter(varInt1);
					break;
				case "ShfaqCmimetPerKategorineEdhene":
					CmimiDhoma cmDhomaObject1 = new CmimiDhoma();
					ds = cmDhomaObject1.NxirrCmimiDhomaPerKategorine(varInt1);
					break;
				case "ShfaqDhomatPerKategorineEdhene":
					Dhoma dhomaObject3 = new Dhoma();
					ds = dhomaObject3.NxirrDhomaPerKategorine(varInt1);
					break;
				case "ShfaqGrupin":
					Klienti klienti = new Klienti();
					ds = klienti.ShfaqGrupinPerId(varInt1);
					break;
				case "ShfaqDetyrimetPerKlientetEDhomes" :
					Detyrime detyrime10 = new Detyrime();
					ds = detyrime10.ShfaqDetyrimePerDhomen(varInt1);
					break;
				case "ShfaqVetemDetyrimetPerKlientetEDhomes" :
					Detyrime detyrime12 = new Detyrime();
					ds = detyrime12.ShfaqDetyrimePerDhomen(varInt1);
					break;
				case "ShfaqDetyrimKlientiPerKategorineEdhene" :
					Detyrime detyrime11 = new Detyrime();
					ds = detyrime11.ShfaqDetyrimePerKategorine(varInt1);
					break;
				case "ShfaqVetemDetyrimKlientiPerKategorineEdhene" :
					Detyrime detyrime13 = new Detyrime();
					ds = detyrime13.ShfaqDetyrimePerKategorine(varInt1);
					break;
				case "ShfaqKlientetPerGrupinEdhene" :
					Klienti klientiObject = new Klienti();
					ds = klientiObject.ShfaqKlientetPerGrupin(varInt1);
					break;
				case "ShfaqTeDhenatPerPerdoruesin":
					Perdorues perdorues = new Perdorues();
					ds = perdorues.ShfaqTeDhenaPerdorues(varInt1);
					break;
				case "ShfaqDhomaPerRezervimGrupi":
					Rezervimi rezervim = new Rezervimi();
					ds = rezervim.ShfaqRezervimDhomaGrupi(varInt1);
					break;
				case "ShfaqTeDhenatPerDhome":
					Dhoma dhoma2 = new Dhoma();
					ds = dhoma2.NxirrDhome(varInt1);
					break;
				case "ShfaqTeDhenaKlientiId":
					Klienti klient = new Klienti();
					ds = klient.ShfaqKlientPerId(varInt1);
					break;
				case "ShfaqRezervimeVlefshmePerGrupAgjensi":
					Rezervimi rezervObject2= new  Rezervimi();
					ds = rezervObject2.ShfaqRezervimeVlefshmePerGrupAgjensi(varInt1);
					break;
				case "ShfaqShpenzimetPerLlojinEdhene":
					Shpenzime shpObject= new Shpenzime();
					ds = shpObject.ShfaqShpenzime(varInt1);
					break;
				case "ShfaqDhomaNePerdorim":
					Dhoma dhomax= new Dhoma();
					ds = dhomax.ShfaqDhomatDitore(varInt1);
					break;
				case "ShfaqTeDhenaFormaPagesa":
					Arka arkaObject= new Arka();
					ds = arkaObject.ShfaqFormaPagese(varInt1);
					break;
				case "ShfaqFormePageseKaparDhome":
					Arka arkaObject1= new Arka();
					ds = arkaObject1.ShfaqFormePageseKaparDhome(varInt1);
					break;
				case "ShfaqFormePagesePerRezervim":
					Arka arkaObject2= new Arka();
					ds = arkaObject2.ShfaqFormePagesePerRezervim(varInt1);
					break;
				default:
					ds = null;
					break;
			}
			return ds;

		}
		public DataSet VeprimeRead(string idVeprime, string varString1, string varString2, string varString3)
		{
			//TODO: Add method logic here
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqDetyriminEzgjedhur":
					Detyrime detyrime = new Detyrime();
					ds = detyrime.ShfaqDetyrime();
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}

		public DataSet VeprimeRead(string idVeprime)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqDhomatEPashlyeraGrupi":
					Dhoma dhomaObj = new Dhoma();
					ds = dhomaObj.ShfaqDhomaPashlyeraGrupi();
					break;
				case "ShfaqDhomatPerDorezim":
					Dhoma dhoma = new Dhoma();
					ds = dhoma.ShfaqDhoma();
					break;
				case "ShfaqLlojetDetyrime":
					Detyrime detyrime = new Detyrime();
					ds = detyrime.ShfaqDetyrime();
					break;
				case "ShfaqKategorite":
					Kategorite kategorite = new Kategorite();
					ds = kategorite.ShfaqKategori();
					break;
				case "ShfaqDhomat":
					Dhoma dhome = new Dhoma();
					ds = dhome.ShfaqDhoma();
					break;
				case "ShfaqRezervimeVlefshmeKlienti":
					Rezervimi rezervimi2 = new Rezervimi();
					ds = rezervimi2.ShfaqRezervimeVlefshmeKlienti();
					break;
				case "ShfaqRezervimeVlefshmeGrupi":
					Rezervimi rezervimi3 = new Rezervimi();
					ds = rezervimi3.ShfaqRezervimeVlefshmeGrupi();
					break;
				case "ShfaqMjeteIdentifikimi":
					Identifikimi identifikimi = new Identifikimi();
					ds = identifikimi.ShfaqIdentifikim();
					break;
				case "ShfaqGjitheShpenzimet":
					Shpenzime ShpenzimeObject = new Shpenzime();
					ds = ShpenzimeObject.ShfaqShpenzime();
					break;
				case "ShfaqGrupet":
					Klienti klienti = new Klienti();
					ds = klienti.ShfaqGrupe();
					break;
				case "ShfaqKlientetNeHotel":
					Klienti klienti1= new Klienti();
					ds = klienti1.ShfaqKlientetDhomatNeHotel2();
					break;
				case "ShfaqDhomatEPashlyera":
					Dhoma dhomaObject = new Dhoma();
					ds = dhomaObject.DhomaPashlyera();
					break;
				case "ShfaqRezervimeKlienti":
					Rezervimi rezervime = new Rezervimi();
					ds = rezervime.ShfaqRezervimeKlienti();
					break;
				case "ShfaqRezervimeGrupi":
					Rezervimi rezervime1 = new Rezervimi();
					ds = rezervime1.ShfaqRezervimeGrupi();
					break;
				case "ShfaqRezervimeGrupiDhome":
					Rezervimi rezervime2 = new Rezervimi();
					ds = rezervime2.ShfaqRezervimeGrupiDhome();
					break;
				case "ShfaqRezervimetVlefshmePerDhomatMeOre":
					Dhoma dhomaObject1 = new Dhoma();
					ds  = dhomaObject1.ShfaqRezDhomaMeOre();
					break;
				case "ShfaqHyrjetPasSotDhomatMeOre":
					Dhoma dhomaObject2 = new Dhoma();
					ds  = dhomaObject2.ShfaqHyrjetDhomaMeOre();
					break;
				case "ShfaqRolet":
					Perdorues perdorues1 = new Perdorues();
					ds = perdorues1.ShfaqRolet();
					break;
				case "ShfaqPerdoruesit":
					Perdorues perdorues2 = new Perdorues();
					ds = perdorues2.ShfaqPerdoruesit();
					break;
				case "ShfaqCmimetPerDhomat":
					CmimiDhoma cmimi = new CmimiDhoma();
					ds = cmimi.ShfaqCmimet();
					break;
				case "ShfaqDhomatEPashlyeraPrint":
					Dhoma dhoma2 = new Dhoma();
					ds = dhoma2.ShfaqDhomatEPashlyera();
					break;
				case "ShfaqKlientGrupNeHotel":
					Klienti klienti2 = new Klienti();
					ds = klienti2.ShfaqKlientetNeGrup();
					break;
				case "ShfaqRezervimeSkaduara":
					Rezervimi rezervimSkaduar = new Rezervimi();
					ds = rezervimSkaduar.ShfaqRezervimeSkaduar();
					break;
				case "ShfaqRezervimeSkaduaraGrupe":
					Rezervimi rezervimSkaduar1 = new Rezervimi();
					ds = rezervimSkaduar1.ShfaqRezervimeSkaduarGrupe();
					break;
				case "KontrolloDhomatPaDorezuaraKliente":
					Dhoma dhomaPaDorezuar1 = new Dhoma();
					ds = dhomaPaDorezuar1.ShfaqDhomatEPadorezuara();
					break;
				case "KontrolloDhomatPaDorezuaraGrupe":
					Dhoma dhomaPaDorezuar2 = new Dhoma();
					ds = dhomaPaDorezuar2.ShfaqDhomatEPadorezuara2();
					break;
				case "ShfaqRezervimeVlefshme":
					Rezervimi rezervimiObject = new Rezervimi();
					ds = rezervimiObject.ShfaqRezervimeVlefshme();
					break;
				case "ShfaqRezervimeVlefshmeNeGrup":
					Rezervimi rezervimiObject1 = new Rezervimi();
					ds = rezervimiObject1.ShfaqRezervimeVlefshmeNeGrup();
					break;
				case "ShfaqLlojetEShpenzimeve":
					Shpenzime shpenzimiObject1 = new Shpenzime();
					ds = shpenzimiObject1.ShfaqLlojetEShpenzimeve();
					break;
				case "ShfaqPerkthime":
					PerkthimeClass perkthime = new PerkthimeClass();
					ds = perkthime.ShfaqPerkthimet();
					break;
				case "ShfaqTeGjithaFormatEPageses":
					Arka arka = new Arka();
					ds = arka.ShfaqFormaPagese();
					break;
				default:
					break;
			}
			return ds;
		}

		public DataSet VeprimeRead(string idVeprime, string varString1)
		{
			DataSet ds = null;
			switch(idVeprime)
			{
				case "KlientetEPashlyerPerDhomen":
					Dhoma dhomaObject = new Dhoma();
					ds = dhomaObject.KlientetEPashlyerPerDhomen(varString1);
					break;
				case "ShfaqKlientetPerDhomenEgrupit":
					Klienti klienti = new Klienti();
					ds = klienti.ShfaqKlientetPerDhomenEgrupit(varString1);
					break;
				case "KontrollRolPerdoruesi":
					Perdorues perdorues = new Perdorues();
					ds = perdorues.KontrollPerdorues(varString1);
					break;
				default:
					ds = null;
					break;
			}
			return ds;
			
		}

		public DataSet VeprimeRead(string idVeprime, string varString1, string varString2)
		{
			//TODO: Add method logic here
			DataSet ds = null;
			Klienti klientiObject = null;
			switch(idVeprime)
			{
				case"ShfaqDetyrimKlientiPerEmerMbiemer":
					Detyrime detObject = new Detyrime();
					ds = detObject.ShfaqDetyrimePerEmerMbiemer(varString1,varString2);
					break;
				case"ShfaqVetemDetyrimKlientiPerEmerMbiemer":
					Detyrime detObject1 = new Detyrime();
					ds = detObject1.ShfaqDetyrimePerEmerMbiemer(varString1,varString2);
					break;
				case "ShfaqRezervim":
					Rezervimi rezervObject = new Rezervimi();
					//dr = rezervObject.ShfaqRezervim(varString1,varString2);
					break;
				case "ShfaqRezervimetPerKlientPerEmerMbiemerTeDhene":
					Rezervimi rezervim = new Rezervimi();
					ds = rezervim.ShfaqRezervimePerEmerMbiemer(varString1, varString2);
					break;
				case "ShfaqRezervimetPerGrupAgjensiTeDhene":
					Rezervimi rezervim1 = new Rezervimi();
					ds = rezervim1.ShfaqRezervimePerGrupAgjensi(varString1, varString2);
					break;
				case "ShfaqRezervimetDhomePerGrupAgjensiTeDhene":
					Rezervimi rezervim2 = new Rezervimi();
					ds = rezervim2.ShfaqRezervimeDhomePerGrupAgjensi(varString1, varString2);
					break;
				case "ShfaqVeprimetPerGrupin" :
					klientiObject = new Klienti();
					ds = klientiObject.ShfaqKlientetPerGrupinEdhene(varString1, varString2);
					// varString1 sherben si grupi
					// varString2 sherben si agjensia
					break;
				case "ShfaqRezervimVlefshemPerEmerMbiemer":
					Rezervimi rezervimi = new Rezervimi();
					ds = rezervimi.ShfaqRezervimeVlefshmePerEmerMbiemer(varString1, varString2);
					break;
				case "ShfaqRezervimVlefshemPerEmerAgjensi":
					Rezervimi rezervimi1 = new Rezervimi();
					//ds = rezervimi1.ShfaqRezervimeVlefshmePerEmerAgjensi(varString1, varString2);
					break;
				case "KontrollUserName":
					Perdorues perdorues = new Perdorues();
					ds = perdorues.KontrollUserNamePassword(varString1, varString2);
					break;
				default :
					ds = null;
					break;
			}
			return ds;
		}

		public DataSet VeprimeRead(string idVeprime, DateTime dtFillimi, DateTime dtMbarimi)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqBilanci":
					Arka arkaObject = new Arka();
					ds = arkaObject.Bilanci(dtFillimi,dtMbarimi);
					break;
				case "ShfaqShpenzimetMidisDatave":
					// dtFillimi sherben si date e fillimit te kerkimit per shpenzimet
					// dtMbarimi sherben si date e mbarimit te kerkimit per shpenzimet
					Shpenzime shpenzimeObject = new Shpenzime();
					ds = shpenzimeObject.ShfaqShpenzime(dtFillimi, dtMbarimi);
					break;
				case "ShfaqDetyrimeKlientePerData":
					Detyrime detyrime = new Detyrime();
					ds = detyrime.ShfaqDetyrimePerDatat(dtFillimi, dtMbarimi);
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}
		public DataSet VeprimeRead(string idVeprime, string varString1,string varString2, int varInt1)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqVeprimetPerKlientin":
					//varString1 dhe varString2 sherbejne si emri i klientit
					//varInt1 = 1 per hyrjet e vlefshme
					//varInt1 = 0 per hyrjet jo te vlefshme
					//varInt1 = -1
					Klienti klObject = new Klienti();
					ds = klObject.ShfaqKlientet(varString1, varString2, varInt1);
					break;
				default:
					ds = null;
					break;
			}
			return ds;
		}

		public DataSet VeprimeRead (string idVeprime, string varString1, string varString2, DateTime varDate1, DateTime varDate2)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqDetyrimKlientiPerEmerDheData":
					Detyrime detyrime = new Detyrime();
					ds = detyrime.ShfaqDetyrimKlientiPerEmerDheData(varString1, varString2, varDate1, varDate2);
					break;
				case "HyrjeNeHotelKlienteDale":
					Klienti klient1 = new Klienti();
					ds = klient1.ShfaqKlienteDale(varString1, varString2, varDate1, varDate2);
					break;
				case "HyrjeNeHotelGrupeDale":
					Klienti klient2 = new Klienti();
					ds = klient2.ShfaqGrupeDale(varString1, varString2, varDate1, varDate2);
					break; 
				case "ShfaqVeprimetPerKlientin" :
					// varString1 sherben si emer klienti
					// varString2 sherben si mbiemer klienti
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					Klienti klientiObject = new Klienti();
					ds = klientiObject.ShfaqKlientet(varString1, varString2, varDate1, varDate2, -1);
					break;
			}
			return ds;
		}
		public DataSet VeprimeRead (string idVeprime, string varString1, string varString2, DateTime varDate1, DateTime varDate2,int varInt1)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqVeprimetPerKlientin" :
					// varString1 sherben si emer klienti
					// varString2 sherben si mbiemer klienti
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt1 = 1 per hyrjet e vlefshme
					// varInt1 = 0 per hyrjet jo te vlefshme
					// varInt1 = -1 pa kriter
					Klienti klientiObject = new Klienti();
					ds = klientiObject.ShfaqKlientet(varString1, varString2, varDate1, varDate2, varInt1);
					break;
			}
			return ds;
		}
		public DataSet VeprimeRead (string idVeprime, int varInt1, string varString1, string varString2, DateTime varDate1, DateTime varDate2, int varInt2)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqVeprimetPerKlientinDheDhomen":
					Klienti klientiObject = new Klienti();
					ds = klientiObject.ShfaqKlientet(varInt1, varString1, varString2, varDate1, varDate2, varInt2);
					break;
			}
			return ds;
		}

		public DataSet VeprimeRead(string idVeprime, DateTime varDate1, DateTime varDate2, int varInt1, string varString1, string varString2)
		{
			DataSet ds = null;
			switch (idVeprime)
			{
				case "ShfaqDetyrimeKlientePerDataEmerKategori":
					Detyrime detyrime = new Detyrime();
					ds = detyrime.ShfaqDetyrimeKlientePerDataEmerKategori(varDate1, varDate2, varInt1, varString1, varString2);
					break;
			}
			return ds;
		}
		#endregion VeprimeRead
		#endregion public methods

	}
}
