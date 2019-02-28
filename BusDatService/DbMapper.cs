using System;

namespace HotelManagment.BusDatService
{
	/// <summary>
	/// Klasa qe krijon query-t per ekzekutimin ne databaze
	/// </summary>
	public class DbMapper
	{
		#region Constructor
		public DbMapper()
		{
			// 
			// TODO: Add constructor logic here
			//
		}
		#endregion

		#region GetQuery
		/// <summary>
		/// Merr kerkesa_query , dhe lloji_query dhe paramatra variante opsionale  dhe kthen nje 
		/// String qe permban query-in e kerkuar.
		/// </summary>
		/// <param name="kerkesaQuery"></param>
		/// <param name="llojiQuery"></param>
		/// <returns></returns>
		public string GetQuery(string kerkesaQuery, string varstring1, string varstring2)
		{
			string strSql = "";
			varstring1 = varstring1.Replace("'", "''");
			varstring2 = varstring2.Replace("'", "''");
			switch( kerkesaQuery)
			{
				case "dbKrijoIdentifikimi" :
					strSql = "INSERT INTO KLIENTI_IDENTIFIKIMI(ID_IDENTIFIKIMI, LLOJI_ID) VALUES('" + varstring1 + "', '" + varstring2 + "')";
					break;
				case "ShfaqRezervimetPerKlientPerEmerMbiemerTeDhene":
					strSql = "SELECT R.ID_REZERVIMI, R.EMRI, R.MBIEMRI,R.DATA_REZERVIMI, R.DATA_FILLIMI,R.DATA_MBARIMI, R.KAPARI,R.DATA_KAPARI, DK.ID_DHOMA, DK.DHOMA_EMRI, DK.KAT_EMRI,DK.ID_KATEGORIA,R.EMAILI " +
						"FROM REZERVIM AS R INNER JOIN DHOMA_REZERVIMI AS DR ON R.ID_REZERVIMI = DR.ID_REZERVIMI INNER JOIN DHOMA_KATEGORIA AS DK ON DR.ID_DHOMA = DK.ID_DHOMA " +
						"WHERE (R.ID_GRUPI IS NULL) AND (R.EMRI LIKE '" + varstring1 + "%' AND R.MBIEMRI LIKE '" + varstring2 + "%') ORDER BY R.EMRI, R.MBIEMRI";
					break;

				case "ShfaqRezervimetPerGrupAgjensiTeDhene":
					strSql = "SELECT DISTINCT R.ID_REZERVIMI, R.DATA_REZERVIMI, R.DATA_FILLIMI,R.DATA_MBARIMI,G.EMRI,G.AGJENSIA, R.KAPARI,R.DATA_KAPARI,R.ID_GRUPI " +
						"FROM DHOMAT_REZERVIMET AS R  INNER JOIN GRUPI AS G ON R.ID_GRUPI=G.ID_GRUPI " +
						"WHERE (G.EMRI LIKE '" + varstring1 + "%' AND G.AGJENSIA LIKE '" + varstring2 + "%')";
					break;
				case "ShfaqRezervimetDhomePerGrupAgjensiTeDhene":
					strSql = "SELECT R.ID_REZERVIMI, R.DATA_REZERVIMI, R.DATA_FILLIMI,R.DATA_MBARIMI,G.EMRI,G.AGJENSIA, R.KAPARI,R.ID_GRUPI, DK.ID_DHOMA, DK.DHOMA_EMRI, DK.KAT_EMRI,DK.ID_KATEGORIA " +
						"FROM REZERVIM AS R INNER JOIN DHOMA_REZERVIMI AS DR ON R.ID_REZERVIMI = DR.ID_REZERVIMI INNER JOIN DHOMA_KATEGORIA AS DK ON DR.ID_DHOMA = DK.ID_DHOMA INNER JOIN GRUPI AS G ON R.ID_GRUPI=G.ID_GRUPI " +
						"WHERE (G.EMRI LIKE '" + varstring1 + "%' AND G.AGJENSIA LIKE '" + varstring2 + "%') ORDER BY G.EMRI,DATA_FILLIMI ";
					break;
				case "ShfaqKlientetSipasGrupit" :
					strSql =  "SELECT * " +
						"FROM KLIENTI_GRUPI " + 
						"WHERE ( GRUPI LIKE '" + varstring1 + "%' AND AGJENSIA LIKE '" + varstring2 + "%') AND GRUPI != 'NULL' ORDER BY DATA_HYRJE ";
					break;
					
				case "ShfaqRezervimeVlefshmePerEmerMbiemer":
					strSql = "SELECT EMRI, MBIEMRI , DATA_FILLIMI, DATA_MBARIMI,DATA_REZERVIMI,DHOMA_EMRI,KAPARI FROM REZERVIME_VLEFSHME " + 
						"WHERE EMRI LIKE '" + varstring1 + "%' AND MBIEMRI LIKE '" + varstring2 + "%' AND ID_GRUPI IS NULL";
					break;
				case "ShfaqRezervimeVlefshmePerEmerAgjensi":
					strSql = "SELECT GRUPI, AGJENSIA , DATA_FILLIMI, DATA_MBARIMI,DATA_REZERVIMI,DHOMA_EMRI,KAPARI FROM REZERVIME_VLEFSHME " + 
						"WHERE GRUPI LIKE '" + varstring1 + "%' AND AGJENSIA LIKE '" + varstring2 + "%'";
					break;
				case "KontrollUserNamePassword":
					strSql = "SELECT USER_NAME, PASSWORD, ROL_ID, USER_ID FROM USERS WHERE USER_NAME = '" + varstring1 +
						"' AND PASSWORD = '" + varstring2 + "'";
					break;
				case "KontrolloEmraPerdoruesish":
					strSql = "SELECT [USER_NAME] FROM USERS WHERE [USER_NAME] <> '" + varstring1 + 
						"' AND USER_NAME = '" + varstring2 + "'";
					break;
				case "ShfaqDetyrimKlientiPerEmerMbiemer":
					strSql = " SELECT KD.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE,EMER_LLOJI,DATA,SASIA,CMIMI,DHOMA_EMRI,KAT_EMRI,KD.ID_DETYRIMI "+
						" FROM "+
						" (SELECT K.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE ,DATA,SASIA,ID_LLOJDETYRIMI,ID_DHOMA,ID_DETYRIMI "+
						" FROM KLIENTI AS K"+
						" LEFT JOIN DETYRIMET AS D "+
						" ON K.ID_KLIENTI=D.ID_KLIENTI"+
						" WHERE KLIENT_HOTELI =1)AS KD "+
						" LEFT JOIN LLOJET_DETYRIMI AS LD "+
						" ON LD.ID_LLOJDETYRIMI=KD.ID_LLOJDETYRIMI"+
						" LEFT JOIN DHOMA_KATEGORIA AS DK ON"+
						" DK.ID_DHOMA=KD.ID_DHOMA"+
						" WHERE EMRI LIKE '" + varstring1 + "%' AND  MBIEMRI LIKE '" + varstring2 + "%' ORDER BY EMRI";
					//					strSql = "SELECT ID_DETYRIMI, D.ID_KLIENTI,EMRI, MBIEMRI, D.ID_LLOJDETYRIMI,D.DATA, EMER_LLOJI,CMIMI,SASIA,KAT_EMRI,DHOMA_EMRI " + 
					//						"FROM DETYRIMET AS D INNER JOIN LLOJET_DETYRIMI AS LD ON D.ID_LLOJDETYRIMI = LD.ID_LLOJDETYRIMI " +
					//						"INNER JOIN (SELECT ID_KLIENTI, EMRI, MBIEMRI,DHOMA_EMRI,KAT_EMRI FROM KLIENTI_GRUPI WHERE (EMRI LIKE '" + varstring1 + "%' AND  MBIEMRI LIKE '" + varstring2 + "%') AND " +
					//						"KLIENT_HOTELI =1) AS K " +
					//						"ON D.ID_KLIENTI = K.ID_KLIENTI ORDER BY EMRI";
					break;
				case "ShfaqVetemDetyrimKlientiPerEmerMbiemer":
					strSql = " SELECT KD.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE,EMER_LLOJI,DATA,SASIA,CMIMI,DHOMA_EMRI,KAT_EMRI,KD.ID_DETYRIMI "+
						" FROM "+
						" (SELECT K.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE ,DATA,SASIA,ID_LLOJDETYRIMI,ID_DHOMA,ID_DETYRIMI "+
						" FROM KLIENTI AS K"+
						" INNER JOIN DETYRIMET AS D "+
						" ON K.ID_KLIENTI=D.ID_KLIENTI"+
						" )AS KD "+
						" INNER JOIN LLOJET_DETYRIMI AS LD "+
						" ON LD.ID_LLOJDETYRIMI=KD.ID_LLOJDETYRIMI"+
						" INNER JOIN DHOMA_KATEGORIA AS DK ON"+
						" DK.ID_DHOMA=KD.ID_DHOMA"+
						" WHERE EMRI LIKE '" + varstring1 + "%' AND  MBIEMRI LIKE '" + varstring2 + "%' ORDER BY EMRI";
					break;
				case "ShtoFormePagese" :
					strSql = "INSERT INTO FORMA_PAGESA(EMRI, PERQINDJA) VALUES ('" + varstring1 + "', " + varstring2 + ")";
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}
		public string GetQuery(string kerkesaQuery, string varstring1, string varstring2, string varString3)
		{
			string strSql = "";
			varstring1 = varstring1.Replace("'", "''");
			varstring2 = varstring2.Replace("'", "''");
			varString3 = varString3.Replace("'", "''");
			switch( kerkesaQuery)
			{
				case "KrijoGrupi" :
					strSql = "INSERT INTO GRUPI(EMRI, AGJENSIA, EMAILI) VALUES('" + varstring1 + "', '" + varstring2 + "', '" + varString3+ "')";
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}
		
		public string GetQuery(string kerkesaQuery, string varString1, int varInt1, string varString2, int varInt2)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");
			switch (kerkesaQuery)
			{
				case "KrijoDhome":
					strSql = "INSERT INTO DHOMA (DHOMA_EMRI, ID_KATEGORIA, DHOMA_GJENDJA, NR_KREVATESH) VALUES ('" +
						varString1 + "', " + varInt1 + ", '" + varString2 + "', " + varInt2 + ")";
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}

		public string GetQuery(string kerkesaQuery, DateTime varDate1, DateTime varDate2)
		{
			string strSql;
			switch (kerkesaQuery)
			{
				case "ShfaqBilanci":
					strSql = "SELECT ARKA_DATA, ARKA_SASIA FROM ARKA WHERE DATA BETWEEN '" + varDate1.ToShortDateString() + "' AND '" + varDate2.ToShortDateString() + "'";
					break;
				case "ShfaqArkenPerDatat" :
					varDate2 = varDate2.Date.AddDays(1);
					strSql = "SELECT A.ARKA_DATA, A.ARKA_SASIA,FP.EMRI, FP.PERQINDJA  FROM ARKA AS A" +
						" INNER JOIN FORMA_PAGESA AS FP ON A.ID_FORMAPAGESA = FP.ID_FORMAPAGESA" +
						" WHERE A.ARKA_DATA BETWEEN '" + varDate1.ToShortDateString() + "' AND '" + varDate2.ToShortDateString() +
						" '  AND NOT (A.ARKA_DATA = '" + varDate2.ToShortDateString() + "' ) ORDER BY A.ARKA_DATA";
					break;
				case "ShfaqShpenzimetMidisDatave" :
					strSql = "SELECT S.ID_SHPENZIMI,S.ID_LLOJSHPENZIMI, LS.EMRI, S.DATA, S.SASIA, S.KOMENT " +
						" FROM SHPENZIMI AS S INNER JOIN LLOJE_SHPENZIMI AS LS ON S.ID_LLOJSHPENZIMI = LS.ID_LLOJSHPENZIMI" + 
						" WHERE S.DATA BETWEEN '" + varDate1.ToShortDateString() + "' AND '" + varDate2.ToShortDateString() + "' ORDER BY S.DATA, LS.EMRI";
					break;
				case "dbShfaqShpenzimetPerDatat" :
					strSql = "SELECT  DATA, SASIA, KOMENT FROM SHPENZIMI WHERE DATA BETWEEN '" + varDate1.ToShortDateString() + "' AND '" + varDate2.ToShortDateString() + "' ORDER BY DATA";
					break;
				case "ShumaShpenzimeMidisDatave" :
					strSql = " SELECT SUM(SASIA) FROM SHPENZIMI WHERE " +
						" DATA >= '" + varDate1.ToShortDateString() + "' AND DATA < '" + varDate2.ToShortDateString() + "'";
					break;
				case "ShumaArkaMidisDatave" :
					
					strSql = " SELECT SUM(ARKA_SASIA) FROM ARKA WHERE " +
						" ARKA_DATA >= '" + varDate1.ToShortDateString() + "' AND ARKA_DATA < '" + varDate2.ToShortDateString() + "'";
					break;
				case "ShfaqDetyrimetPerDatat":
					strSql = " SELECT KD.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE,EMER_LLOJI,DATA,SASIA,CMIMI,DHOMA_EMRI,KAT_EMRI,KD.ID_DETYRIMI "+
						" FROM "+
						" (SELECT K.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE ,DATA,SASIA,ID_LLOJDETYRIMI,ID_DHOMA,ID_DETYRIMI "+
						" FROM KLIENTI AS K"+
						" LEFT JOIN DETYRIMET AS D "+
						" ON K.ID_KLIENTI=D.ID_KLIENTI" +
						" WHERE KLIENT_HOTELI =0)AS KD "+
						" LEFT JOIN LLOJET_DETYRIMI AS LD "+
						" ON LD.ID_LLOJDETYRIMI=KD.ID_LLOJDETYRIMI"+
						" LEFT JOIN DHOMA_KATEGORIA AS DK ON"+
						" DK.ID_DHOMA=KD.ID_DHOMA"+
						" WHERE (DATA BETWEEN '" + varDate1.ToShortDateString() + "' AND '" + varDate2.ToShortDateString() + "') ORDER BY EMRI, MBIEMRI, ID_KLIENTI";
 
					break;
				case "ShumaArkaMidisDataveSipasFormesSePageses":
					strSql = "SELECT SUM(A.ARKA_SASIA) AS SHUMA, A.ID_FORMAPAGESA, FP.EMRI, FP.PERQINDJA" + 
						" FROM ARKA AS A LEFT JOIN FORMA_PAGESA AS FP ON A.ID_FORMAPAGESA = FP.ID_FORMAPAGESA " + 
						" WHERE ARKA_DATA BETWEEN '" + varDate1.ToShortDateString() + " ' AND '" + varDate2.ToShortDateString() + "' " + 
						" AND NOT ARKA_DATA = '" + varDate2.ToShortDateString() + "' " +
						" GROUP BY A.ID_FORMAPAGESA, FP.EMRI,FP.PERQINDJA " +
						" ORDER BY A.ID_FORMAPAGESA";	
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}

		public string GetQuery(string kerkesaQuery, string varString1)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			switch (kerkesaQuery)
			{
				case "KontrolloEmerGrupi" :
					strSql = "SELECT COUNT(ID_GRUPI)AS NUMRI FROM GRUPI WHERE EMRI = '" + varString1 + "'";
					break;
				case "GjejIdDetyrimi" :
					strSql =  "SELECT * FROM DETYRIMET WHERE (ID_DETYRIMI = '" + varString1 + "')";
					break;
				case "KrijoKategori":
					strSql =  "INSERT INTO KATEGORIA (KAT_EMRI) VALUES ('" + varString1 + "')";
					break;
				case "KrijoLlojIdentifikimi" :
					strSql = "INSERT INTO LLOJI_IDENTIFIKIMI(EMER_LLOJI) VALUES ('" + varString1 + "')";
					break;
				case "KontrolloEmerKategori" :
					strSql = "SELECT COUNT(ID_KATEGORIA) AS NUMRI  FROM KATEGORIA WHERE KAT_EMRI = '" + varString1 + "'";
					break;
				case "KontrolloLlojIdentifikimi" :
					strSql = "SELECT COUNT(ID_LLOJI)AS NUMRI   FROM LLOJI_IDENTIFIKIMI WHERE EMER_LLOJI = '" + varString1 + "'";
					break;
				case "KontrolloLlojDetyrimi" :
					strSql = "SELECT COUNT(ID_LLOJDETYRIMI) AS NUMRI ,EMER_LLOJI FROM LLOJET_DETYRIMI WHERE EMER_LLOJI = '" + varString1 + "' GROUP BY EMER_LLOJI ";
					break;
				
				case "KontrolloPerdorues":
					strSql = "SELECT USER_NAME FROM USERS WHERE USER_NAME = '" + varString1 + "'";
					break;
					//				case "KlientetEPashlyerPerDhomen" :
					//					strSql = "SELECT  KLIENTI.EMRI, KLIENTI.MBIEMRI, KLIENTI.DATA_HYRJE, KLIENTI.DATA_DALJE," + 
					//						"  KLIENTI.KAPARI " + 
					//						" FROM (KLIENTI INNER JOIN  DHOMAT_CMIMET  ON KLIENTI.ID_DHOMA = DHOMAT_CMIMET.ID_DHOMA)" +
					//						" WHERE (KLIENTI.DATA_HYRJE >= DHOMAT_CMIMET.DATA_FILLIMI) AND (KLIENTI.DATA_HYRJE <= DHOMAT_CMIMET.DATA_MBARIMI)" +
					//						" AND (KLIENTI.KLIENT_HOTELI = 1) " + 
					//						" AND (DHOMAT_CMIMET.DHOMA_EMRI = '" + varString1 + "' )  " + 
					//						"   ORDER BY DHOMAT_CMIMET.DHOMA_EMRI, KLIENTI.DATA_HYRJE";
					//					break;
				case "KlientetEPashlyerPerDhomen" :
					strSql = "SELECT  K.EMRI, K.MBIEMRI, K.DATA_HYRJE, K.DATA_DALJE," + 
						"  K.KAPARI, K.GRUPI, K.AGJENSIA , DHOMAT_CMIMET.CMIMI, DHOMAT_CMIMET.ID_KATEGORIA" + 
						" FROM (KLIENTI_GRUPI AS K INNER JOIN  DHOMAT_CMIMET  ON K.ID_DHOMA = DHOMAT_CMIMET.ID_DHOMA)" +
						" WHERE (K.DATA_HYRJE >= DHOMAT_CMIMET.DATA_FILLIMI) AND (K.DATA_HYRJE <= DHOMAT_CMIMET.DATA_MBARIMI)" +
						" AND (K.KLIENT_HOTELI = 1) AND (K.ID_GRUPI IS NULL)" + 
						" AND (DHOMAT_CMIMET.DHOMA_EMRI = '" + varString1 + "' )  AND (K.ID_GRUPI IS NULL)    " + 
						"   ORDER BY DHOMAT_CMIMET.DHOMA_EMRI, K.DATA_HYRJE";
					break;
				case "ShfaqKlientetPerDhomenEgrupit" :
					strSql = "SELECT EMRI, MBIEMRI , DATA_HYRJE, DATA_DALJE FROM KLIENTI WHERE KLIENT_HOTELI = 1 AND ID_DHOMA = (SELECT ID_DHOMA FROM DHOMA WHERE DHOMA_EMRI = '" + varString1 + "')";
					break;
				case "ShtoLlojShpenzimi" :
					strSql = "INSERT INTO LLOJE_SHPENZIMI(EMRI) VALUES ('" + varString1 + "')";
					break;
				case "NrLloji" :
					strSql = "SELECT COUNT(ID_LLOJSHPENZIMI) AS NR FROM LLOJE_SHPENZIMI WHERE EMRI = '" + varString1 + "'";
					break;
				case "NrPagesashPerEmer" :
					strSql = "SELECT COUNT(ID_FORMAPAGESA) AS NR FROM FORMA_PAGESA WHERE EMRI = '" + varString1 + "'";
					break;
				case "KontrollPerdorues":
					strSql = "SELECT ROL_ID FROM USERS WHERE [USER_NAME] = '" + varString1 + "'";
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}

		public string GetQuery(string kerkesaQuery,  int varInt, string varString)
		{
			string strSql = "";
			varString = varString.Replace("'", "''");
			switch( kerkesaQuery)
			{
				case "ModifikoIdentifikimi" :
					strSql = "UPDATE IDENTIFIKIMI SET NR_IDENTIFIKIMI = '" + varString + "' WHERE ID_IDENTIFIKIMI = " + varInt ;
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}
	
		public string GetQuery(string kerkesaQuery, string varString1, int varInt1)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			switch (kerkesaQuery)
			{
				case "KontrolloEmerGrupi" :
					strSql = "SELECT COUNT(ID_GRUPI)AS NUMRI FROM GRUPI WHERE EMRI = '" + varString1 + "' AND NOT (ID_GRUPI = " + varInt1 + ")";
					break;
				case "KrijoLlojDetyrimi" :
					strSql = "INSERT INTO LLOJET_DETYRIMI (EMER_LLOJI, CMIMI) VALUES ('" + varString1 + "', " + varInt1 + ")";
					break;
				case "ModifikoKategori" :
					strSql = "UPDATE KATEGORIA SET KAT_EMRI = '" + varString1 + "' WHERE ID_KATEGORIA = " + varInt1 ;
					break;
				case "ModifikoLlojIdentifikimi":
					strSql = "UPDATE LLOJI_IDENTIFIKIMI SET EMER_LLOJI = '" + varString1 + "' WHERE ID_LLOJI = " + varInt1;
					break;
				case "KrijoIdentifikim":
					strSql = "INSERT INTO IDENTIFIKIMI (ID_LLOJI, NR_IDENTIFIKIMI) VALUES (" + varInt1 + ", '" + varString1 + "')";
					break;
				case "ModifikoGjendjeDhome" :
					strSql = "UPDATE DHOMA SET DHOMA_GJENDJA = '" + varString1 + "' WHERE ID_DHOMA = " + varInt1 ;
					break;
				case "ModifikoLlojShpenzimi" :
					strSql = "UPDATE LLOJE_SHPENZIMI SET EMRI = '" + varString1 + "' WHERE ID_LLOJSHPENZIMI = " + varInt1 ;
					break;
				case "NrLloji" :
					strSql = "SELECT COUNT(ID_LLOJSHPENZIMI) FROM LLOJE_SHPENZIMI WHERE EMRI = '" + varString1 + "' AND NOT ID_LLOJSHPENZIMI = " + varInt1  ;
					break;
				case "NrPagesashPerEmerPerModifikim" :
					strSql = "SELECT COUNT(ID_FORMAPAGESA) FROM FORMA_PAGESA WHERE EMRI = '" + varString1 + "' AND NOT ID_FORMAPAGESA = " + varInt1  ;
					break;
				case "ZevendesoIdMeUserNameArkaShpenzime" :
					strSql = "UPDATE SHPENZIMI SET EMER_PERDORUES = '" + varString1 + "' WHERE USER_ID = " + varInt1;
					strSql += Environment.NewLine + "UPDATE SHPENZIMI SET USER_ID = NULL WHERE USER_ID = " + varInt1;
					strSql += Environment.NewLine + "UPDATE ARKA SET EMER_PERDORUES = '" + varString1 + "' WHERE USER_ID = " + varInt1;
					strSql += Environment.NewLine + "UPDATE ARKA SET USER_ID = NULL WHERE USER_ID = " + varInt1;
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}
	    
		public string GetQuery(string kerkesaQuery, string varString1,float varFloat)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			switch (kerkesaQuery)
			{
				
				default:
					strSql = "";
					break;
			}
			return strSql;
		}
		public string GetQuery(string kerkesaQuery, int varInt1, int varInt2)
		{   
			string strSql = "";
			switch(kerkesaQuery)
			{
				
				case "ModifikoKaparKlientiFutRezervim" :
					//varInt1 sherben si idKlienti
					//varint2 sherben si kapari
					strSql = "UPDATE KLIENTI SET KAPARI = " + varInt2 + " WHERE ID_KLIENTI = " + varInt1;
					break;
				case "FshiPergjegjes" :
					strSql = "DELETE FROM ARKA WHERE ID_KLIENTI = " + varInt1 + " AND KOMENT = 'Pagese detyrimesh'";
					strSql += Environment.NewLine +  "DELETE FROM DETYRIMET WHERE ID_KLIENTI = " + varInt1 ;
					strSql += Environment.NewLine + " DELETE FROM KLIENTI WHERE ID_KLIENTI = " + varInt1;
					strSql += Environment.NewLine + " DELETE FROM IDENTIFIKIMI WHERE ID_IDENTIFIKIMI = " + varInt2;
					break;
				case "FshiKlient" :
					strSql =  " DELETE FROM ARKA WHERE ID_KLIENTI = " + varInt1;
					strSql += Environment.NewLine + "DELETE FROM DETYRIMET WHERE ID_KLIENTI = " + varInt1 ;
					strSql += Environment.NewLine + " DELETE FROM KLIENTI WHERE ID_KLIENTI = " + varInt1;
					strSql += Environment.NewLine + " DELETE FROM IDENTIFIKIMI WHERE ID_IDENTIFIKIMI = " + varInt2;
					break;
				case "ModifikoKaparKlienti" :
					strSql =  "UPDATE KLIENTI SET KAPARI = 0, SKONTO = 0 , GJOBA = 0  WHERE ID_KLIENTI = " + varInt1;
					strSql += Environment.NewLine + "DELETE ARKA WHERE ID_KLIENTI = " + varInt1 + " AND ((KOMENT = 'Kapar dhome') OR (KOMENT = 'Kapar grupi'))";
					break;
				case "ModifikoPagesaKlientiArka" :
					//varInt1 pagesa
					//varInt2 idKlienti
					strSql =  "UPDATE ARKA SET ARKA_SASIA = " + varInt1 + "  WHERE ID_KLIENTI = " + varInt2 + " AND ((KOMENT = 'Pagese dhome') OR (KOMENT = 'Pagese grupi'))";
					break;
				case "KrijoRezervimDhoma" :
					strSql =  "INSERT INTO DHOMA_REZERVIMI(ID_REZERVIMI, ID_DHOMA) VALUES(" + varInt1 + ", " + varInt2 + ")";
					break;
				case "KrijoCmimiDhoma" :
					strSql = "INSERT INTO DHOMA_CMIMI(ID_DHOMA, ID_CMIMI) VALUES(" + varInt1 + ", " + varInt2 + ")";
					break;
				case "FshiCmimiDhoma" :
					strSql = "DELETE FROM DHOMA_CMIMI WHERE ID_DHOMA = " + varInt1 + " AND ID_CMIMI = " + varInt2;
					strSql += Environment.NewLine + "DELETE FROM CMIMI WHERE ID_CMIMI = " + varInt2;
					break;
				
				case "ModifikoKlientGrup" :
					strSql = "UPDATE GRUP_KLIENTI SET ID_GRUPI = " + varInt2 + " WHERE ID_KLIENTI = " + varInt1 ;
					break;
				case "KrijoKlientNeGrup" :
					strSql = "INSERT INTO GRUP_KLIENTI(ID_GRUPI, ID_KLIENTI) VALUES( " + varInt1 + ", " + varInt2 + ")";
					break;
				case "FshiRezervimDhome":
					strSql = " DELETE FROM DHOMA_REZERVIMI WHERE ID_REZERVIMI = " + varInt1 + " AND ID_DHOMA = " + varInt2 ;
					strSql += Environment.NewLine + " DELETE FROM REZERVIM WHERE ID_REZERVIMI = " + varInt1 ;  
					break;
				case "FshiDhomeRezervuarGrupi":
					strSql = " DELETE FROM DHOMA_REZERVIMI WHERE ID_REZERVIMI = " + varInt1 + " AND ID_DHOMA = " + varInt2 ;
					break;
				case "ShfaqVeprimetPerDhomen" :
					if (varInt2 >= 0)
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							" WHERE  (ID_DHOMA = " + varInt1 + ") " +
							" AND ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) AND (KLIENT_HOTELI = " + varInt2 + ") ORDER BY DHOMA_EMRI, DATA_HYRJE";
					}
					else
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							" WHERE  (ID_DHOMA = " + varInt1 + ") " +
							" AND ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI )ORDER BY DHOMA_EMRI, DATA_HYRJE";
					}
					break;
				case "ShfaqVeprimetPerGrupin" :
					if (varInt2 >= 0)
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE ID_GRUPI = " + varInt1 + " " +
							" AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) AND (KLIENT_HOTELI = " + varInt2 + ") ORDER BY GRUPI, DATA_HYRJE";
					}
					else
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE ID_GRUPI = " + varInt1 + " " +
							" AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI )ORDER BY GRUPI, DATA_HYRJE";
					}
					break;
				case "ShfaqVeprimetNeGrupPerDhomen" :
					if (varInt2 >= 0)
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE ID_DHOMA = " + varInt1 + " " +
							" AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) AND (KLIENT_HOTELI = " + varInt2 + ") ORDER BY GRUPI, DATA_HYRJE";
					}
					else
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE ID_DHOMA = " + varInt1 + " " +
							" AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI )ORDER BY GRUPI, DATA_HYRJE";
					}
					break;	
				default :
					strSql = "";
					break;
			} 
			return strSql;
		}

		public string GetQuery(string kerkesaQuery, string varString1, string varString2, string varString3,
			string varString4, int varInt1, int varInt2)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");
			varString3 = varString3.Replace("'", "''");
			varString4 = varString4.Replace("'", "''");
			switch (kerkesaQuery)
			{
				case "ModifikoPerdorues":
					strSql = "UPDATE USERS SET [USER_NAME] = '" + varString3 + "', PASSWORD = '" + varString4 +
						"', EMRI = '" + varString1 + "', MBIEMRI = '" + varString2 + "', ROL_ID = " + varInt2 +
						" WHERE [USER_ID] = " + varInt1;
					break;
			}
			return strSql;
		}

		public string GetQuery(string kerkesaQuery, string varString1, string varString2, DateTime varDate1,
			string varString3, string varString4, string varString5, string varString6, DateTime varDate2, 
			DateTime varDate3, int varInt1, int varInt2, int varInt3,DateTime varDate4, string varString7, 
			string varString8 )
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");
			varString3 = varString3.Replace("'", "''");
			varString4 = varString4.Replace("'", "''");
			varString5 = varString5.Replace("'", "''");
			varString6 = varString6.Replace("'", "''");
			varString7 = varString7.Replace("'", "''");
			varString8 = varString8.Replace("'", "''");

			switch (kerkesaQuery)
			{
				case "KrijoKlienti":
					strSql = "INSERT INTO KLIENTI(EMRI, MBIEMRI, DATELINDJA, ADRESA, TELEFONI, EMAIL, TARGA, " +
						" DATA_HYRJE , DATA_DALJE, KAPARI, ID_IDENTIFIKIMI, ID_DHOMA,DATA_KAPARI, VENDLINDJA, SHTETESIA, PAGUAR_DHOMA)" +
						" VALUES('" + varString1 + "', '" + varString2 + "', '" + varDate1.ToShortDateString() + "', '" + varString3 + "'" + 
						" , '" + varString4 + "', '" + varString5 + "', '" + varString6 + "', '" + this.formatoDatenGjate(varDate2) + "'," + 
						" '" + this.formatoDatenGjate(varDate3) + "', " + varInt1 + ", " + varInt2 + ", " + varInt3 + "," +
						"'"+this.formatoDatenShumeGjate(varDate4)+"','" + varString7 + "','" + varString8+ "', 0 )" ;
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}

		public string GetQuery(string kerkesaQuery, string varString1, string varString2, DateTime varDate1, 
			string varString3, string varString4, string varString5, string varString6, DateTime varDate2,
			DateTime varDate3, int varInt1, int varInt2, int varInt3,DateTime varDate4, string varString7,
			string varString8, int varInt4 )
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");
			varString3 = varString3.Replace("'", "''");
			varString4 = varString4.Replace("'", "''");
			varString5 = varString5.Replace("'", "''");
			varString6 = varString6.Replace("'", "''");
			varString7 = varString7.Replace("'", "''");
			varString8 = varString8.Replace("'", "''");
			switch (kerkesaQuery)
			{
				case "KrijoKlienti":
					strSql = "INSERT INTO KLIENTI(EMRI, MBIEMRI, DATELINDJA, ADRESA, TELEFONI, EMAIL, TARGA, DATA_HYRJE , DATA_DALJE, KAPARI, ID_IDENTIFIKIMI, ID_DHOMA,DATA_KAPARI, VENDLINDJA, SHTETESIA, ID_REZERVIMI, PAGUAR_DHOMA) VALUES('" + varString1 + "', '" + varString2 + "', '" + varDate1.ToShortDateString() + "', '" + varString3 + "', '" + varString4 + "', '" + varString5 + "', '" + varString6 + "', '" + this.formatoDatenGjate(varDate2) + "', '" + this.formatoDatenGjate(varDate3) + "', " + varInt1 + ", " + varInt2 + ", " + varInt3 + ",'"+this.formatoDatenShumeGjate(varDate4)+"','" + varString7 + "','" + varString8+ "', " + varInt4 + ", 0 )" ;
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}
		public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, int varInt3, DateTime varDate1, 
			DateTime varDate2, DateTime varDate3)
		{   
			string strSql = "";
			switch(kerkesaQuery)
			{
				case "ModifikoRezervimGrupi" :
					strSql = "UPDATE REZERVIM SET ID_GRUPI = " + varInt2 + ", KAPARI = " + varInt3 + ", DATA_FILLIMI = '" + this.formatoDatenGjate(varDate1) + "', DATA_MBARIMI = '" + this.formatoDatenGjate(varDate2) + "', DATA_REZERVIMI = '" + this.formatoDatenGjate(varDate3) + "'  WHERE ID_REZERVIMI = " + varInt1 ;
					break;
				default :
					strSql = "";
					break;
			} 
			return strSql;
		}

		
		public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, int varInt3)
		{
			string strSql = "";
			switch(kerkesaQuery)
			{
				case "ModifikoPagesaKlientiArka" :
					//varInt1 pagesa
					//varInt2 idKlienti
					strSql =  "UPDATE ARKA SET ARKA_SASIA = " + varInt1 + ", USER_ID = " + varInt3 + "  WHERE ID_KLIENTI = " + varInt2 + " AND ((KOMENT = 'Pagese dhome') OR (KOMENT = 'Pagese grupi'))";
					break;
				case "ModifikoKaparKlientiArka" :
					//varInt1 kapari
					//varInt2 idKlienti
					//varInt3 idFormaPagesa
					strSql =  "UPDATE ARKA SET ARKA_SASIA = " + varInt1 + ", ID_FORMAPAGESA = " + varInt3 + "  WHERE (ID_KLIENTI = " + varInt2 + ") AND ((KOMENT = 'Kapar dhome') OR (KOMENT = 'Kapar grupi'))";
					break;
				case "ModifikoRezervimDhome" :
					strSql = "UPDATE  DHOMA_REZERVIMI SET ID_REZERVIMI = " + varInt1 + ", ID_DHOMA = " + varInt2 + "  WHERE ID_REZERVIMI = " + varInt1 + " AND ID_DHOMA = " + varInt3 ;
					break;
				case "NxirrKlientiNgaDhoma" :
					strSql = "UPDATE KLIENTI SET KLIENT_HOTELI = 0 , SKONTO = " + varInt2 + ", GJOBA = " + varInt3 + " WHERE ID_KLIENTI = " + varInt1 ;
					break;
				case "FshiKlienti" :
					strSql = "DELETE FROM DETYRIMET WHERE ID_KLIENTI = " + varInt1 ;
					strSql += Environment.NewLine + " DELETE FROM GRUP_KLIENTI WHERE ID_KLIENTI = " + varInt1+" AND ID_KLIENTI = "+varInt2 ;
					strSql += Environment.NewLine + " DELETE FROM KLIENTI WHERE ID_KLIENTI = " + varInt1;
					strSql += Environment.NewLine + " DELETE FROM IDENTIFIKIMI WHERE ID_IDENTIFIKIMI = " + varInt3;
					break;
				case "AplikoSkontoGjobe" :
					// varInt1 sherben si skonto
					// varInt2 sherben si gjobe
					// varInt3 sherben si id_klienti
					strSql = "UPDATE KLIENTI SET SKONTO = " + varInt1 + ", GJOBA = " + varInt2 + 
						" WHERE ID_KLIENTI = " + varInt3;
					break;
				case "FshiKlientGrupi" :
					//varInt1 sherben si idKlienti
					//varInt2 sherben si idIdentifikimi
					//varInt3 sherben si idGrupi
					strSql =  " DELETE FROM ARKA WHERE ID_KLIENTI = " + varInt1;
					strSql += Environment.NewLine + "DELETE FROM DETYRIMET WHERE ID_KLIENTI = " + varInt1 ;
					strSql += Environment.NewLine + " DELETE FROM GRUP_KLIENTI WHERE ID_KLIENTI = " + varInt1+" AND ID_GRUPI = " +varInt3 ;
					strSql += Environment.NewLine + " DELETE FROM KLIENTI WHERE ID_KLIENTI = " + varInt1;
					strSql += Environment.NewLine + " DELETE FROM IDENTIFIKIMI WHERE ID_IDENTIFIKIMI = " + varInt2;
					break;
				case "FshiPergjegjesGrupi" :
					strSql = " DELETE FROM ARKA WHERE (ID_KLIENTI = " + varInt1 + " ) AND (KOMENT = 'Pagese detyrimesh' )" ;
					strSql += Environment.NewLine + "DELETE FROM DETYRIMET WHERE ID_KLIENTI = " + varInt1 ;
					strSql += Environment.NewLine + " DELETE FROM GRUP_KLIENTI WHERE ID_KLIENTI = " + varInt1+" AND ID_GRUPI = " +varInt3 ;
					strSql += Environment.NewLine + " DELETE FROM KLIENTI WHERE ID_KLIENTI = " + varInt1;
					strSql += Environment.NewLine + " DELETE FROM IDENTIFIKIMI WHERE ID_IDENTIFIKIMI = " + varInt2;
					break;
				default:
					strSql = "";
					break;
			} 
			return strSql;
		}

		public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, int varInt3 , int varInt4)
		{
			string strSql = "";
			switch(kerkesaQuery)
			{
				case "ModifikoKaparKlientiArka" :
					//varInt1 kapari
					//varInt2 idKlienti
					//varInt3 idFormaPagesa
					//varInt4 idPerdoruesi
					strSql =  "UPDATE ARKA SET ARKA_SASIA = " + varInt1 + ", ID_FORMAPAGESA = " + varInt3 + ",USER_ID = " + varInt4+ "  WHERE (ID_KLIENTI = " + varInt2 + ") AND ((KOMENT = 'Kapar dhome') OR (KOMENT = 'Kapar grupi'))";
					break;
				case "HidhKaparPergjegjesIri" :
					strSql = "UPDATE KLIENTI SET KAPARI = " + varInt1 + ", SKONTO = " + varInt2 + ", GJOBA = " + varInt3 + " WHERE (ID_KLIENTI = " + varInt4 + ") ";
					break;
				default:
					strSql = "";
					break;
			} 
			return strSql;
		}
		public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, int varInt3,DateTime varDate)
		{
			string strSql = "";
			switch(kerkesaQuery)
			{
				
				case "KrijoDetyriminPerKlient" :
					strSql = "INSERT INTO DETYRIMET(ID_LLOJDETYRIMI, SASIA, ID_KLIENTI,DATA) VALUES(" + varInt1 + ", " + varInt2 + ", " + varInt3 + ",'" +this.formatoDatenGjate( varDate) + "' )";
					break;
				case "ModifikoDetyrimKlienti" :
					strSql = "UPDATE DETYRIMET SET ID_LLOJDETYRIMI = " + varInt2 + " , SASIA = " + varInt3 + ", DATA = '" + this.formatoDatenGjate(varDate) + "' WHERE ID_DETYRIMI = " + varInt1  ;
					break;
				default :
					strSql = "";
					break;
			} 
			return strSql;
		}
	
		public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, DateTime varDate1)
		{
			string strSql = "";
			switch(kerkesaQuery)
			{
				case "HidhKaparPergjegjesIriNeArke" :
					strSql =  "UPDATE ARKA SET ID_KLIENTI = " + varInt2  + ", ARKA_DATA = '" + varDate1.ToShortDateString()+ "' WHERE ID_KLIENTI = " + varInt1 + " AND ((KOMENT = 'Kapar dhome') OR (KOMENT = 'Kapar grupi'))";
					break;
				case "HidhPagesePergjegjesIriNeArke" :
					strSql =  "UPDATE ARKA SET ID_KLIENTI = " + varInt2  + ", ARKA_DATA = '" + varDate1.ToShortDateString() + "' WHERE ID_KLIENTI = " + varInt1 + " AND ((KOMENT = 'Pagese dhome') OR (KOMENT = 'Pagese grupi'))";
					break;
				case "ModifikoArke" :
					//varInt1 sherben si pagesa
					//varInt2 sherben si idKlienti
					//varDate1 sherben si dtMbarimi
					strSql = "UPDATE ARKA SET ARKA_SASIA = " + varInt1 + ", ARKA_DATA = '" + varDate1.ToShortDateString() +
						"' WHERE ID_KLIENTI = " + varInt2 + " AND ((KOMENT = 'Pagese dhome') OR (KOMENT = 'Pagese grupi')) " ;
					break;
				case "ShfaqKlienteteDhomesPerGrupin" :
					//varInt1 sherben si id_grupi
					//varInt2 id_dhoma
					//varDate si date kerkimi
					strSql = "SELECT K.ID_KLIENTI, K.DHOMA_EMRI, K.DATA_HYRJE, K.DATA_DALJE FROM KLIENTI_GRUPI AS K " +
						" WHERE K.ID_DHOMA = " + varInt2 + " AND K.ID_GRUPI = " + varInt1 + 
						" AND ('" +	this.formatoDatenGjate(varDate1) + "' BETWEEN K.DATA_HYRJE AND K.DATA_DALJE OR K.DATA_DALJE < '" + this.formatoDatenGjate(varDate1) + " ')" +  
						" AND K.KLIENT_HOTELI = 1 ORDER BY K.DHOMA_EMRI, K.DATA_HYRJE " ;
					break;
				default :
					strSql = "";
					break;
			} 
			return strSql;
		}

		public string GetQuery(string kerkesaQuery, DateTime varDate1, int varInt1 )
		{
			string strSql = "";
			string dataGjate = "";
			switch(kerkesaQuery)
			{
				case "ModifikoArke" :
					strSql = "  UPDATE ARKA SET ARKA_DATA = '" + varDate1.ToShortDateString() + "' WHERE ID_KLIENTI = " + varInt1 + " AND ((KOMENT = 'Kapar dhome') OR (KOMENT = 'Kapar grupi'))" ;
					break;
				case "HidhNeArke" :
					strSql = "INSERT INTO ARKA(ARKA_DATA, ARKA_SASIA) VALUES('" + varDate1.ToShortDateString() + "', " + varInt1 + ")" ;
					break;
				case "NxirrArka" :
					varInt1 = -varInt1;
					strSql = "INSERT INTO ARKA(ARKA_DATA, ARKA_SASIA) VALUES('" + varDate1.ToShortDateString() + "', " + varInt1 + ")" ;
					break;
				case "KontrollAplikuarDtFillimiCmimi" :
					strSql = "SELECT ID_DHOMA,DATA_FILLIMI,DATA_MBARIMI FROM CMIMI AS C INNER JOIN DHOMA_CMIMI AS D ON C.ID_CMIMI = D.ID_CMIMI " +
						"WHERE ID_DHOMA = " + varInt1 + " AND ( '" + varDate1.ToShortDateString() + "'BETWEEN DATA_FILLIMI AND DATA_MBARIMI)"; 
					break;
				case "KontrollAplikuarDtMbarimiCmimi" :
					strSql = "SELECT ID_DHOMA,DATA_MBARIMI FROM CMIMI AS C INNER JOIN DHOMA_CMIMI AS D ON C.ID_CMIMI = D.ID_CMIMI " +
						"WHERE ID_DHOMA = " + varInt1 + " AND ( '" + varDate1.ToShortDateString() + "'BETWEEN  DATA_FILLIMI AND DATA_MBARIMI) "; 
					break;
				case "DhomatRezervuarPerDaten" :
					strSql = "SELECT COUNT(DHOMA_REZERVIMI.ID_DHOMA) FROM DHOMA_REZERVIMI INNER JOIN REZERVIM " + 
						"ON DHOMA_REZERVIMI.ID_REZERVIMI = REZERVIM.ID_REZERVIMI WHERE " +
						"DHOMA_REZERVIMI.ID_DHOMA = " + varInt1 + " AND REZERVIM.DATA_FILLIMI<= '" + this.formatoDatenGjate(varDate1) 
						+ "' AND REZERVIM.DATA_MBARIMI>  '" + this.formatoDatenGjate(varDate1) + "'";
					break;
				case "NumriKlientevePerDaten" :
					strSql = "SELECT COUNT(ID_KLIENTI) FROM KLIENTI WHERE " +
						"DATA_HYRJE <= '" + this.formatoDatenGjate(varDate1) + "' AND " +
						" DATA_DALJE > '" + this.formatoDatenGjate(varDate1) + "' AND ID_DHOMA = '" + varInt1 + "'";
					break;
				case "ModifikoDatenEdaljes" :
					strSql = "UPDATE KLIENTI SET DATA_DALJE = '" + varDate1.ToShortDateString() + "' WHERE ID_KLIENTI = " + varInt1 ;
					break;
				case "ShfaqKlientetPerDhomenEdhenePerDatenEdhene" :
					strSql = "SELECT K.ID_KLIENTI, K.EMRI, K.MBIEMRI, K.DATA_HYRJE, K.DATA_DALJE, K.KAPARI, DK.ID_KATEGORIA FROM KLIENTI AS K " +
						" INNER JOIN DHOMA_KATEGORIA AS DK ON DK.ID_DHOMA = K.ID_DHOMA WHERE (K.ID_DHOMA = " + varInt1 + 
						") AND ('" +	this.formatoDatenGjate(varDate1) + "' BETWEEN K.DATA_HYRJE AND K.DATA_DALJE OR K.DATA_DALJE < '" + this.formatoDatenGjate(varDate1) + " ')" +  
						" AND (K.KLIENT_HOTELI = 1) AND K.ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI) ORDER BY K.DATA_HYRJE " ;
					break;
				case "ShfaqCmimiDhoma" :
					strSql = "SELECT CMIMI FROM CMIMI AS C INNER JOIN DHOMA_CMIMI AS D ON C.ID_CMIMI = D.ID_CMIMI " + 
						"WHERE D.ID_DHOMA = " + varInt1 + " AND (DATA_FILLIMI <= '" + varDate1.ToShortDateString() + "' AND DATA_MBARIMI >= '" + varDate1.ToShortDateString() + "')" ;
					break;
				case "ShfaqDhomatEZenaPerKategorine" :
					strSql = "SELECT ID_DHOMA, DHOMA_EMRI FROM DHOMA_KATEGORIA" +
						" WHERE ID_KATEGORIA = " + varInt1 + " AND ID_DHOMA IN" + 
						" (SELECT ID_DHOMA FROM KLIENTI WHERE " +  
						"(' " + this.formatoDatenGjate(varDate1) + "' BETWEEN KLIENTI.DATA_HYRJE AND KLIENTI.DATA_DALJE  OR DATA_DALJE < '" + this.formatoDatenGjate(varDate1)+ "') AND KLIENT_HOTELI = 1 " +
						" AND ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI))";
					break;
				case "CmimiDhomesPerDaten" :
					strSql = "SELECT CMIMI FROM DHOMAT_CMIMET WHERE ID_DHOMA = " + varInt1 + 
						" AND '" + varDate1.ToShortDateString() + "' BETWEEN DATA_FILLIMI AND DATA_MBARIMI";
					break;
				case "ModifikoDateDalje" :
					strSql = "UPDATE KLIENTI SET DATA_DALJE = '" + this.formatoDatenGjate(varDate1) + "' " +
						" WHERE ID_KLIENTI = " + varInt1  + " AND DATA_DALJE > ' " + this.formatoDatenGjate(varDate1)+ "' ";
					break;
				case "ShfaqDhomatPerGrupinEdhene" :
					strSql = "SELECT ID_DHOMA, DHOMA_EMRI FROM DHOMA WHERE ID_DHOMA IN"+
						" (SELECT DISTINCT ID_DHOMA FROM KLIENTI WHERE (ID_KLIENTI IN " +
						" (SELECT ID_KLIENTI FROM GRUP_KLIENTI WHERE ID_GRUPI = " + varInt1 + ")) AND KLIENT_HOTELI = 1" +
						" AND ('" + this.formatoDatenGjate(varDate1) + "' BETWEEN DATA_HYRJE AND DATA_DALJE OR DATA_DALJE < '" + this.formatoDatenGjate(varDate1)+ "' )) ORDER BY ID_DHOMA";
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}
		
		public string GetQuery(string kerkesaQuery, DateTime varDate1, int varInt1, string varString,
			int varInt2  )
		{
			string strSql = "";
			varString = varString.Replace("'", "''");
			switch(kerkesaQuery)
			{				
				

				default :
					strSql = "";
					break;
			}
			return strSql;
		}


		public string GetQuery(string kerkesaQuery, DateTime varDate1, int varInt1, 
			string varString1, int varInt2, int varInt3, string varString2, int varInt4 )
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");

			switch(kerkesaQuery)
			{
				case "ModifikoArke":
					//rasti i modifikimit te kaparit te rezervimit ne arke
					strSql = "UPDATE ARKA SET ARKA_DATA ='"+ varDate1.ToShortDateString() + "',ARKA_SASIA = "+varInt1+",KOMENT='"+ varString1 +
						"', ID_FORMAPAGESA = " + varInt2 + ", EMER_REZ = '" + varString2 + "', USER_ID = " + varInt4 + " WHERE ID_REZERVIMI="+ varInt3;
					break;
				case "HidhKaparRezervimiKlientiNeArke" :
					strSql = "INSERT INTO ARKA(arka_data, arka_sasia, koment, id_klienti, id_rezervimi, id_formapagesa, emer_rez, user_id)  VALUES('" + varDate1.ToShortDateString() + "', " + varInt1 + ", '" + varString1+ "', " + -1 + ", "   + varInt2 +  ", " + varInt3 + ", '" +  varString2 + "'," + varInt4 + ")" ;
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}
//		public string GetQuery(string kerkesaQuery, DateTime varDate1, int varInt1, 
//			string varString1, int varInt2, int varInt3, string varString2, int varInt4 )
//		{
//			string strSql = "";
//			varString1 = varString1.Replace("'", "''");
//			varString2 = varString2.Replace("'", "''");
//
//			switch(kerkesaQuery)
//			{
//				case "HidhKaparRezervimiKlientiNeArke" :
//					strSql = "INSERT INTO ARKA(arka_data, arka_sasia, koment, id_klienti, id_rezervimi, id_formapagesa, emer_rez, user_id)  VALUES('" + varDate1.ToShortDateString() + "', " + varInt1 + ", '" + varString1+ "', " + -1 + ", "   + varInt2 +  ", " + varInt3 + ", '" +  varString2 + "'," + varInt4 + ")" ;
//					break;
//				default :
//					strSql = "";
//					break;
//			}
//			return strSql;
//		}
		public string GetQuery(string kerkesaQuery, DateTime varDate1, int varInt1,
			string varString, int varInt2, int varInt3, int varInt4, int varInt5 )
		{
			string strSql = "";
			varString = varString.Replace("'", "''");
			switch(kerkesaQuery)
			{
				case "HidhDetyrimNeArke" :
					//varInt5 sherben si idFormaPagesa
					strSql = "INSERT INTO ARKA(arka_data, arka_sasia, koment, id_klienti, id_detyrimi,"+
					" id_formapagesa, user_id)  VALUES('" + varDate1.ToShortDateString() + "', " + varInt1 + ", '"
						+ varString+ "', " + varInt2 + ", "   + varInt3 +  ", " + varInt4 + ", " + varInt5 + ")" ;
					break;
				case "HidhNeArke" :
					strSql = "INSERT INTO ARKA(arka_data, arka_sasia, koment, id_klienti, id_formapagesa, user_id)"+
						"  VALUES('" + varDate1.ToShortDateString() + "', " + varInt1 + ", '" + varString+ "', "+
						varInt2 +  ", " + varInt3 + ", " + varInt4 + ")" ;
					break;
				case "HidhKaparRezervimiGrupiNeArke" :
					strSql = "INSERT INTO ARKA(arka_data, arka_sasia, koment, id_klienti, id_rezervimi, id_formapagesa, id_grupi, user_id)" +
						"  VALUES('" + varDate1.ToShortDateString() + "', " + varInt1 + ", '" + varString+ "', " + -1 + ", "   + varInt2 +  ", " + varInt3 + "," + varInt4+ ","  + varInt5 + " )" ;
					break;
				case "ModifikoArke":
					strSql = "UPDATE ARKA SET ARKA_DATA ='"+varDate1.ToShortDateString()+"',ARKA_SASIA = "+varInt1+",KOMENT='"+varString+
						"', ID_FORMAPAGESA = " + varInt2 + ", ID_GRUPI = " + varInt4 + ", USER_ID = " + varInt5 + " WHERE ID_REZERVIMI="+ varInt3;
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}

		public string GetQuery(string kerkesaQuery, DateTime varDate1, int varInt1,
			string varString, int varInt2, int varInt3, int varInt4)
		{
			string strSql = "";
			varString = varString.Replace("'", "''");
			switch(kerkesaQuery)
			{

				
				//HidhNeArke
				case "HidhNeArke" :
					strSql = "INSERT INTO ARKA(arka_data, arka_sasia, koment, id_klienti, id_formapagesa, user_id)"+
						"  VALUES('" + varDate1.ToShortDateString() + "', " + varInt1 + ", '" + varString+ "', "+
						varInt2 +  ", " + varInt3 + ", " + varInt4 + ")" ;
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}


		public string GetQuery(string kerkesaQuery, DateTime varDate1, int varInt1, int varInt2 )
		{
			string strSql = "";
			string dataGjate = "";
			switch(kerkesaQuery)
			{
				case "ShfaqKlientetPerDhomenEdhenePerDatenEdhenePerGrup" :
					strSql = "SELECT K.ID_KLIENTI, K.EMRI, K.MBIEMRI, K.DATA_HYRJE, K.DATA_DALJE, K.KAPARI, DK.ID_KATEGORIA FROM KLIENTI_GRUPI AS K " +
						" INNER JOIN DHOMA_KATEGORIA AS DK ON DK.ID_DHOMA = K.ID_DHOMA WHERE (K.ID_DHOMA = " + varInt2 + 
						") AND ('" +	this.formatoDatenGjate(varDate1) + "' BETWEEN K.DATA_HYRJE AND K.DATA_DALJE OR K.DATA_DALJE < '" + this.formatoDatenGjate(varDate1) + " ')" +  
						" AND (K.KLIENT_HOTELI = 1) AND K.ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI) AND (K.ID_GRUPI = " + varInt1 + ") ORDER BY K.DATA_HYRJE " ;
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}


		public string GetQuery(string kerkesaQuery, DateTime data, int sasia, string emri )
		{
			string strSql = "";
			emri = emri.Replace("'", "''");
			switch(kerkesaQuery)
			{
				
				case "HidhNeArke" :
					strSql = "INSERT INTO ARKA(ARKA_DATA, ARKA_SASIA,KOMENT) VALUES('" +data.ToShortDateString() + "', " + sasia + ", '" + emri + "')";
					break;
				case "ModifikoArke":
					strSql = "UPDATE ARKA SET ARKA_DATA ='"+data.ToShortDateString()+"',ARKA_SASIA = "+sasia+",KOMENT='"+emri+"'WHERE ARKA_DATA='"+this.formatoDatenShumeGjate(data)+"' ";
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}


		public string GetQuery(string kerkesaQuery, DateTime varDate1, int varInt1, string varString,
			int varInt2, int varInt3)
		{
			string strSql = "";
			varString = varString.Replace("'", "''");
			switch(kerkesaQuery)
			{
				
				case "ModifikoArke":
					strSql = "UPDATE ARKA SET ARKA_DATA ='"+varDate1.ToShortDateString()+"',ARKA_SASIA = "+varInt1+",KOMENT='"+varString+
						"', ID_FORMAPAGESA = " + varInt2 + " WHERE ID_REZERVIMI="+ varInt3;
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}


		public string GetQuery(string kerkesaQuery, DateTime varDate1, DateTime varDate2, int varInt1 )
		{
			string strSql = "";
			switch(kerkesaQuery)
			{
				case "DhomatEZenaPerDatatPaRezervim":
					strSql = "SELECT ID_DHOMA " +  
						" FROM DHOMA_KATEGORIA AS DK" +
						" WHERE (DK.ID_DHOMA  IN" + 
						" (SELECT DR.ID_DHOMA FROM DHOMAT_REZERVIMET AS DR " +  
						" WHERE ( NOT ID_REZERVIMI = " + varInt1 + ") AND ((DR.DATA_FILLIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT DR.DATA_FILLIMI = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (DR.DATA_MBARIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DR.DATA_MBARIMI = '" + formatoDatenGjate(varDate1) + "' )" +
						" OR (DR.DATA_FILLIMI < '" + formatoDatenGjate(varDate1) + "' AND DR.DATA_MBARIMI > '" + formatoDatenGjate(varDate2)+"'))) " +
						" OR DK.ID_DHOMA  IN" +
						"( SELECT K.ID_DHOMA FROM  KLIENTI AS K " +
						" WHERE (K.DATA_HYRJE BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT K.DATA_HYRJE = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (K.DATA_DALJE BETWEEN '" + formatoDatenGjate(varDate1)+ "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT K.DATA_DALJE = '" + formatoDatenGjate(varDate1)+ "')" +
						" OR (K.DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND K.DATA_DALJE > '" + formatoDatenGjate(varDate2)+ "') ))"; 
					break;
				case "RezervimetPerDatatDheGrupin" :
					strSql = "SELECT DATA_FILLIMI, DATA_MBARIMI,ID_REZERVIMI  FROM REZERVIM WHERE ID_GRUPI = " + varInt1 + " AND " +
						" ((DATA_FILLIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DATA_FILLIMI = '" + formatoDatenGjate(varDate2) + "' ) OR " +
						" (DATA_MBARIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DATA_MBARIMI = '" + formatoDatenGjate(varDate1) + "' ) OR " +
						" ( DATA_FILLIMI < '" + formatoDatenGjate(varDate1) + "' AND DATA_MBARIMI > '" + formatoDatenGjate(varDate2) + "' ))";
					break;
				case "NrDetyrimeshPerKlientJashteDatave" :
					strSql = "SELECT COUNT(ID_DETYRIMI) AS NR FROM DETYRIMET WHERE ID_KLIENTI = " + varInt1 + " AND "+
						" ((DATA <'" + this.formatoDatenGjate(varDate1) + "') OR (DATA >'" + this.formatoDatenGjate(varDate2) + "'))";
					break;
				case "KrijoCmimPerDhome" :
					strSql = "INSERT INTO CMIMI(DATA_FILLIMI, DATA_MBARIMI, CMIMI) VALUES('" + varDate1.ToShortDateString() + "', '" + varDate2.ToShortDateString() + "'," + varInt1 + ")" ;
					break;
				case "ShfaqDhomatEliraPerKategorinePerDatatEdhena" :
					strSql = "SELECT DK.ID_DHOMA, DK.DHOMA_EMRI, DK.KAT_EMRI,DK.NR_KREVATESH, DC.CMIMI" +  
						" FROM DHOMA_KATEGORIA AS DK" +
						" INNER JOIN DHOMAT_CMIMET AS DC" + 
						" ON DK.ID_DHOMA = DC.ID_DHOMA" + 
						" WHERE (DC.DATA_FILLIMI <= '" + varDate1.ToShortDateString() + "'  AND DC.DATA_MBARIMI >= '" + varDate1.ToShortDateString() + "')" + 
						" AND DK.ID_KATEGORIA = " + varInt1 + " " +
						" AND (DK.ID_DHOMA NOT IN" + 
						" (SELECT DR.ID_DHOMA FROM DHOMAT_REZERVIMET AS DR " +  
						" WHERE (DR.DATA_FILLIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT DR.DATA_FILLIMI = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (DR.DATA_MBARIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DR.DATA_MBARIMI = '" + formatoDatenGjate(varDate1) + "' )" +
						" OR (DR.DATA_FILLIMI < '" + formatoDatenGjate(varDate1) + "' AND DR.DATA_MBARIMI > '" + formatoDatenGjate(varDate2)+"'))) order by dk.dhoma_emri";
					break;

				case "ShfaqDhomatPlotesishtTeLiraPerKategorinePerDatatEdhena" :
					strSql = "SELECT DK.ID_DHOMA, DK.DHOMA_EMRI, DK.KAT_EMRI,DK.NR_KREVATESH, DC.CMIMI" +  
						" FROM DHOMA_KATEGORIA AS DK" +
						" INNER JOIN DHOMAT_CMIMET AS DC" +  
						" ON DK.ID_DHOMA = DC.ID_DHOMA" + 
						" WHERE (DC.DATA_FILLIMI <= '" + varDate1.ToShortDateString() + "'  AND DC.DATA_MBARIMI >= '" + varDate1.ToShortDateString() + "')" + 
						" AND DK.ID_KATEGORIA = " + varInt1 + " " +
						" AND (DK.ID_DHOMA NOT IN" + 
						" (SELECT DR.ID_DHOMA FROM DHOMAT_REZERVIMET AS DR " +  
						" WHERE (DR.DATA_FILLIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT DR.DATA_FILLIMI = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (DR.DATA_MBARIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DR.DATA_MBARIMI = '" + formatoDatenGjate(varDate1) + "' )" +
						" OR (DR.DATA_FILLIMI < '" + formatoDatenGjate(varDate1) + "' AND DR.DATA_MBARIMI > '" + formatoDatenGjate(varDate2)+"'))" +
						" AND DK.ID_DHOMA NOT IN" +
						"( SELECT K.ID_DHOMA FROM  KLIENTI AS K " +
						" WHERE (K.DATA_HYRJE BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT K.DATA_HYRJE = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (K.DATA_DALJE BETWEEN '" + formatoDatenGjate(varDate1)+ "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT K.DATA_DALJE = '" + formatoDatenGjate(varDate1)+ "')" +
						" OR (K.DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND K.DATA_DALJE > '" + formatoDatenGjate(varDate2)+ "') )) order by dk.dhoma_emri"; 
					break;
				case "ShfaqDhomaMeOreTeLiraPerData" :
					strSql = "SELECT DK.ID_DHOMA, DK.DHOMA_EMRI, DK.KAT_EMRI,DK.NR_KREVATESH, DC.CMIMI" +  
						" FROM DHOMA_KATEGORIA AS DK" +
						" INNER JOIN DHOMAT_CMIMET AS DC" + 
						" ON DK.ID_DHOMA = DC.ID_DHOMA" + 
						" WHERE (DC.DATA_FILLIMI <= '" + varDate1.ToShortDateString() + "'  AND DC.DATA_MBARIMI >= '" + varDate1.ToShortDateString() + "')" + 
						" AND DK.ID_KATEGORIA  =  31" +
						" AND (DK.ID_DHOMA NOT IN" + 
						" (SELECT DR.ID_DHOMA FROM DHOMAT_REZERVIMET AS DR " +  
						" WHERE (DR.DATA_FILLIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT DR.DATA_FILLIMI = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (DR.DATA_MBARIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DR.DATA_MBARIMI = '" + formatoDatenGjate(varDate1) + "' )" +
						" OR (DR.DATA_FILLIMI < '" + formatoDatenGjate(varDate1) + "' AND DR.DATA_MBARIMI > '" + formatoDatenGjate(varDate2)+"'))) order by dk.dhoma_emri";
				
					break;
				case "ShfaqDhomaMeOrePlotesishtTeLiraPerData" :
					strSql = "SELECT DK.ID_DHOMA, DK.DHOMA_EMRI, DK.KAT_EMRI,DK.NR_KREVATESH, DC.CMIMI" +  
						" FROM DHOMA_KATEGORIA AS DK" +
						" INNER JOIN DHOMAT_CMIMET AS DC" +  
						" ON DK.ID_DHOMA = DC.ID_DHOMA" + 
						" WHERE (DC.DATA_FILLIMI <= '" + varDate1.ToShortDateString() + "'  AND DC.DATA_MBARIMI >= '" + varDate1.ToShortDateString() + "')" + 
						" AND DK.ID_KATEGORIA = " + varInt1 + " " +
						" AND (DK.ID_DHOMA NOT IN" + 
						" (SELECT DR.ID_DHOMA FROM DHOMAT_REZERVIMET AS DR " +  
						" WHERE (DR.DATA_FILLIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT DR.DATA_FILLIMI = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (DR.DATA_MBARIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DR.DATA_MBARIMI = '" + formatoDatenGjate(varDate1) + "' )" +
						" OR (DR.DATA_FILLIMI < '" + formatoDatenGjate(varDate1) + "' AND DR.DATA_MBARIMI > '" + formatoDatenGjate(varDate2)+"'))" +
						" AND DK.ID_DHOMA NOT IN" +
						"( SELECT K.ID_DHOMA FROM  KLIENTI AS K " +
						" WHERE (K.DATA_HYRJE BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT K.DATA_HYRJE = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (K.DATA_DALJE BETWEEN '" + formatoDatenGjate(varDate1)+ "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT K.DATA_DALJE = '" + formatoDatenGjate(varDate1)+ "')" +
						" OR (K.DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND K.DATA_DALJE > '" + formatoDatenGjate(varDate2)+ "') )) order by dk.dhoma_emri"; 
					break;
				case "ShfaqCmimPerDhomenDheDatatEdhena" :
					strSql = "SELECT DATA_FILLIMI, DATA_MBARIMI , CMIMI FROM DHOMA_CMIMI AS DC INNER JOIN CMIMI AS C " +
						"ON DC.ID_CMIMI = C.ID_CMIMI WHERE ID_DHOMA = " + varInt1 + " AND " +
						"((DATA_FILLIMI <= '" + varDate1.ToShortDateString() + "' AND DATA_MBARIMI >= '" + varDate1.ToShortDateString() + "') OR (DATA_FILLIMI < '" + varDate2.ToShortDateString() + "' AND DATA_MBARIMI > '" + varDate2.ToShortDateString() + "'))";
					break;
				case "ShfaqTeDhenaDhomePerDatat" :
					strSql = "SELECT ID_KLIENTI FROM DHOMA AS D INNER JOIN KLIENTI AS K " +
						"ON D.ID_DHOMA = K.ID_DHOMA WHERE ID_DHOMA = " + varInt1 + " AND " +
						" ID_KLIENTI = 1";
					break;
				case "ShfaqKlientPerDhomeDataTeDhena" :
					strSql = "SELECT EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE, K.DHOMA_EMRI,KAPARI, K.ID_KLIENTI, K.ID_GRUPI,K.ID_REZERVIMI FROM KLIENTI_GRUPI AS K INNER JOIN DHOMA AS D " +
						" ON K.ID_DHOMA = D.ID_DHOMA WHERE D.ID_DHOMA = " + varInt1 + " AND " +
						" ((DATA_HYRJE < '" + this.formatoDatenGjate(varDate2) + "' AND DATA_HYRJE >= '" + this.formatoDatenGjate(varDate1) + "') OR (DATA_DALJE <= '" + this.formatoDatenGjate(varDate2) + "' AND DATA_DALJE >= '" + this.formatoDatenGjate(varDate1) + "') OR (DATA_HYRJE <= '" + this.formatoDatenGjate(varDate1) + "' AND DATA_DALJE >= '" + this.formatoDatenGjate(varDate2)+ "'))" ;
					break;
				case "ShfaqKlientPerDhomeDataTeDhenaKntCmime" :
					//					strSql = "SELECT EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE, K.DHOMA_EMRI,KAPARI, K.ID_KLIENTI, K.ID_GRUPI FROM KLIENTI_GRUPI AS K INNER JOIN DHOMA AS D " +
					//						"ON K.ID_DHOMA = D.ID_DHOMA WHERE D.ID_DHOMA = " + varInt1 + " AND " +
					//						"((DATA_HYRJE <= '" + this.formatoDatenGjate(varDate2) + "' AND DATA_HYRJE >= '" + this.formatoDatenGjate(varDate1) + "') OR (DATA_DALJE <= '" + this.formatoDatenGjate(varDate2) + "' AND DATA_DALJE >= '" + this.formatoDatenGjate(varDate1) + "'))" ;
					strSql = "SELECT EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE, K.DHOMA_EMRI,KAPARI, K.ID_KLIENTI, K.ID_GRUPI FROM KLIENTI_GRUPI AS K INNER JOIN DHOMA AS D " +
						" ON K.ID_DHOMA = D.ID_DHOMA WHERE D.ID_DHOMA = " + varInt1 + " AND " +
						"  (DATA_HYRJE BETWEEN '" +varDate1.ToShortDateString() + "'   AND '"+ varDate2.ToShortDateString() +"' ) ";
					break;
				case "ShfaqTeDhenaGrupiDataTeDhena" :
					strSql = "SELECT EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE,DHOMA_EMRI,KAPARI,ID_KLIENTI FROM KLIENTI_GRUPI " +
						" WHERE ID_GRUPI = " + varInt1 + " AND " +
						"((DATA_HYRJE < '" + this.formatoDatenGjate(varDate2) + "' AND DATA_HYRJE >= '" + this.formatoDatenGjate(varDate1) + "') OR (DATA_DALJE <= '" + this.formatoDatenGjate(varDate2) + "' AND DATA_DALJE >= '" + this.formatoDatenGjate(varDate1) + "') OR (DATA_HYRJE <= '" + this.formatoDatenGjate(varDate1) + "' AND DATA_DALJE >= '" + this.formatoDatenGjate(varDate2)+ "'))" ;
					break;
					
				case "KntRezNdermjetDatave":
					strSql = " SELECT COUNT(R.ID_REZERVIMI)AS NUMRI FROM REZERVIM AS R INNER JOIN DHOMA_REZERVIMI AS D ON R.ID_REZERVIMI = D.ID_REZERVIMI WHERE D.ID_DHOMA = " + varInt1 + " AND (('"+varDate1.ToShortDateString() + "' BETWEEN DATA_FILLIMI AND DATA_MBARIMI ) OR  ('" + varDate2.ToShortDateString() + "' BETWEEN DATA_FILLIMI AND DATA_MBARIMI ))";
					break;
				case "KntRezNdermjetDataveCmime":
					strSql = " SELECT COUNT(R.ID_REZERVIMI)AS NUMRI FROM REZERVIM AS R "+
						" INNER JOIN DHOMA_REZERVIMI AS D ON R.ID_REZERVIMI = D.ID_REZERVIMI " +
						" WHERE D.ID_DHOMA = " + varInt1 + " AND ( DATA_FILLIMI BETWEEN '"+varDate1.ToShortDateString() + "' AND '" + varDate2.ToShortDateString() + "') ";
					break;
				case "ShfaqDetyrimePerKategorineDheDatat":
					strSql = " SELECT KD.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE,EMER_LLOJI,DATA,SASIA,CMIMI,DHOMA_EMRI,KAT_EMRI,KD.ID_DETYRIMI "+
						" FROM "+
						" (SELECT K.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE ,DATA,SASIA,ID_LLOJDETYRIMI,ID_DHOMA,ID_DETYRIMI "+
						" FROM KLIENTI AS K"+
						" INNER JOIN DETYRIMET AS D "+
						" ON K.ID_KLIENTI=D.ID_KLIENTI" +
						" WHERE KLIENT_HOTELI =0)AS KD "+
						" LEFT JOIN LLOJET_DETYRIMI AS LD "+
						" ON LD.ID_LLOJDETYRIMI=KD.ID_LLOJDETYRIMI"+
						" LEFT JOIN DHOMA_KATEGORIA AS DK ON"+
						" DK.ID_DHOMA=KD.ID_DHOMA"+
						" WHERE (DATA BETWEEN '" + varDate1.ToShortDateString() + "' AND '" + varDate2.ToShortDateString() + "') AND " + 
						" LD.ID_LLOJDETYRIMI = " + varInt1 + "ORDER BY EMRI, MBIEMRI, ID_KLIENTI";
					break;
				
				case "NumerKlienteshPerDateDhoma":
					strSql = "SELECT COUNT(ID_KLIENTI) AS NR FROM KLIENTI WHERE ID_DHOMA = " + varInt1 + 
						" AND ((DATA_HYRJE BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT DATA_HYRJE = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (DATA_DALJE BETWEEN '" + formatoDatenGjate(varDate1)+ "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DATA_DALJE = '" + formatoDatenGjate(varDate1)+ "')" +
						" OR (DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + formatoDatenGjate(varDate2)+ "')) "; 
					break;
				case "NrKlienteNeDhomeNeGrup":
					strSql = "SELECT COUNT(ID_KLIENTI) AS NR FROM KLIENTI_GRUPI WHERE ID_DHOMA = " + varInt1 + 
						" AND ((DATA_HYRJE BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT DATA_HYRJE = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (DATA_DALJE BETWEEN '" + formatoDatenGjate(varDate1)+ "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DATA_DALJE = '" + formatoDatenGjate(varDate1)+ "')" +
						" OR (DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + formatoDatenGjate(varDate2)+ "')) AND (ID_GRUPI IS NOT NULL)"; 
					break;
				case "NumerKlienteshPerDateGrup":
					strSql = "SELECT COUNT(ID_KLIENTI) AS NR FROM KLIENTI_GRUPI WHERE ID_GRUPI = " + varInt1 + 
						" AND ((DATA_HYRJE BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT DATA_HYRJE = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (DATA_DALJE BETWEEN '" + formatoDatenGjate(varDate1)+ "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DATA_DALJE = '" + formatoDatenGjate(varDate1)+ "')" +
						" OR (DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + formatoDatenGjate(varDate2)+ "')) "; 
					break;
				case "ShfaqKlientetSipasDatave" :
					if (varInt1 >= 0)
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE (( DATA_HYRJE >= '" + varDate1.ToShortDateString() + "' AND DATA_HYRJE <'" + varDate2.ToShortDateString() + "') OR ( DATA_DALJE > '" + varDate1.ToShortDateString() + "' AND DATA_DALJE <= '" + varDate2.ToShortDateString() + " ') OR (DATA_HYRJE < '" + varDate1.ToShortDateString() + "' AND DATA_DALJE > '" + varDate2.ToShortDateString() + "' ))  "+
							" AND ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) AND (KLIENT_HOTELI = " + varInt1 + ") ORDER BY DHOMA_EMRI, DATA_HYRJE";	
					}
					else
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE (( DATA_HYRJE >= '" + varDate1.ToShortDateString() + "' AND DATA_HYRJE <'" + varDate2.ToShortDateString() + "') OR ( DATA_DALJE > '" + varDate1.ToShortDateString() + "' AND DATA_DALJE <= '" + varDate2.ToShortDateString() + " ') OR (DATA_HYRJE < '" + varDate1.ToShortDateString() + "' AND DATA_DALJE > '" + varDate2.ToShortDateString() + "' ))  "+
							" AND ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI )ORDER BY DHOMA_EMRI, DATA_HYRJE";
					}
					break;
				case "ShfaqVeprimetNeGrupPerDatat" :
					if (varInt1 >= 0)
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE (( DATA_HYRJE >= '" + this.formatoDatenGjate(varDate1) + "' AND DATA_HYRJE <'" + formatoDatenGjate(varDate2) + "') OR ( DATA_DALJE > '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE <= '" + formatoDatenGjate(varDate2) + " ') OR (DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + formatoDatenGjate(varDate2) + "' ))  "+
							" AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) AND (KLIENT_HOTELI = " + varInt1 + ") ORDER BY GRUPI, DATA_HYRJE";
					}
					else
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE (( DATA_HYRJE >= '" + this.formatoDatenGjate(varDate1) + "' AND DATA_HYRJE <'" + formatoDatenGjate(varDate2) + "') OR ( DATA_DALJE > '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE <= '" + formatoDatenGjate(varDate2) + " ') OR (DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + formatoDatenGjate(varDate2) + "' ))  "+
							" AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI )ORDER BY GRUPI, DATA_HYRJE";
					}
					break;
				default :
					strSql = "";
					break;
				
			}
			return strSql;
			
		}

		public string GetQuery(string kerkesaQuery, DateTime varDate1, DateTime varDate2, int varInt1, int varInt2 )
		{
			string strSql = "";
			switch(kerkesaQuery)
			{
				case "ShfaqVeprimetPerGrupPaRezervim" :
					strSql = "SELECT * " +
						"FROM KLIENTI_GRUPI " + 
						" WHERE (( DATA_HYRJE >= '" + this.formatoDatenGjate(varDate1) + "' AND DATA_HYRJE <'" + formatoDatenGjate(varDate2) + "') OR ( DATA_DALJE > '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE <= '" + formatoDatenGjate(varDate2) + " ') OR (DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + formatoDatenGjate(varDate2) + "' ))  "+
						" AND (ID_GRUPI = " + varInt1 + ") AND NOT ID_REZERVIMI = " + varInt2 + " " +
						" AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI )ORDER BY GRUPI, DATA_HYRJE";
					break;
				case "RezervimetPerDatatDheGrupin" :
					strSql = "SELECT DATA_FILLIMI, DATA_MBARIMI  FROM REZERVIM WHERE NOT ID_REZERVIMI = " + varInt2 +  " AND ID_GRUPI = " + varInt1 + " AND " +
						" ((DATA_FILLIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DATA_FILLIMI = '" + formatoDatenGjate(varDate2) + "' ) OR " +
						" (DATA_MBARIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DATA_MBARIMI = '" + formatoDatenGjate(varDate1) + "' ) OR " +
						" ( DATA_FILLIMI < '" + formatoDatenGjate(varDate1) + "' AND DATA_MBARIMI > '" + formatoDatenGjate(varDate2) + "' ))";
					break;
				case "ShfaqDhomatPlotesishtTeLiraPerKategorinePerDatatEdhenaPerModifikim" :
					strSql = "SELECT DK.ID_DHOMA, DK.DHOMA_EMRI, DK.KAT_EMRI,DK.NR_KREVATESH, DC.CMIMI" +  
						" FROM DHOMA_KATEGORIA AS DK" +
						" INNER JOIN DHOMAT_CMIMET AS DC" +  
						" ON DK.ID_DHOMA = DC.ID_DHOMA" + 
						" WHERE (DC.DATA_FILLIMI <= '" + varDate1.ToShortDateString() + "'  AND DC.DATA_MBARIMI >= '" + varDate1.ToShortDateString() + "')" + 
						" AND DK.ID_KATEGORIA = " + varInt1 + " " +
						" AND (DK.ID_DHOMA NOT IN" + 
						" (SELECT DR.ID_DHOMA FROM DHOMAT_REZERVIMET AS DR " +  
						" WHERE ( NOT (ID_REZERVIMI = " + varInt2 + ") AND ((DR.DATA_FILLIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT DR.DATA_FILLIMI = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (DR.DATA_MBARIMI BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DR.DATA_MBARIMI = '" + formatoDatenGjate(varDate1) + "' )" +
						" OR (DR.DATA_FILLIMI < '" + formatoDatenGjate(varDate1) + "' AND DR.DATA_MBARIMI > '" + formatoDatenGjate(varDate2)+"'))))" +
						" AND DK.ID_DHOMA NOT IN" +
						"( SELECT K.ID_DHOMA FROM  KLIENTI AS K " +
						" WHERE (K.DATA_HYRJE BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT K.DATA_HYRJE = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (K.DATA_DALJE BETWEEN '" + formatoDatenGjate(varDate1)+ "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT K.DATA_DALJE = '" + formatoDatenGjate(varDate1)+ "')" +
						" OR (K.DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND K.DATA_DALJE > '" + formatoDatenGjate(varDate2)+ "') ))"; 
					break;
				case "NumerKlienteshPerDateDhoma":
					strSql = "SELECT COUNT(ID_KLIENTI) AS NR FROM KLIENTI WHERE NOT (ID_KLIENTI = " + varInt2 + ") AND (ID_DHOMA = " + varInt1 + 
						") AND ((DATA_HYRJE BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT DATA_HYRJE = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (DATA_DALJE BETWEEN '" + formatoDatenGjate(varDate1)+ "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DATA_DALJE = '" + formatoDatenGjate(varDate1)+ "')" +
						" OR (DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + formatoDatenGjate(varDate2)+ "')) "; 
					break;
				case "NrKlienteNeDhomePerGrup":
					// varInt1 sherben si ID_DHOMA
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt2 sherben si ID_GRUPI
					strSql = "SELECT COUNT(ID_KLIENTI) AS NR FROM KLIENTI_GRUPI WHERE  (ID_GRUPI = " + varInt2 + ") AND (ID_DHOMA = " + varInt1 + 
						") AND ((DATA_HYRJE BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT DATA_HYRJE = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (DATA_DALJE BETWEEN '" + formatoDatenGjate(varDate1)+ "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DATA_DALJE = '" + formatoDatenGjate(varDate1)+ "')" +
						" OR (DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + formatoDatenGjate(varDate2)+ "')) "; 
					break;
				case "NrKlienteNeDhomeJoTeGrupitTeDhene":
					// varInt1 sherben si ID_GRUPI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt2 sherben si ID_DHOMA
					strSql = "SELECT COUNT(ID_KLIENTI) AS NR FROM KLIENTI_GRUPI WHERE NOT ID_GRUPI = " + varInt1 + 
						" AND ID_DHOMA = " + varInt2 + " AND ((DATA_HYRJE BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT DATA_HYRJE = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (DATA_DALJE BETWEEN '" + formatoDatenGjate(varDate1)+ "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DATA_DALJE = '" + formatoDatenGjate(varDate1)+ "')" +
						" OR (DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + formatoDatenGjate(varDate2)+ "')) "; 
					break;				
				case "NumerKlienteshPerDateGrupPerModifikim":
					// varInt1 sherben si ID_GRUPI
					// varDate1 sherben si date fillimi
					// varDate2 sherben si date mbarimi
					// varInt2 sherben si ID_KLIENTI
					strSql = "SELECT COUNT(ID_KLIENTI) AS NR FROM KLIENTI_GRUPI WHERE (ID_GRUPI = " + varInt1 + ") AND NOT (ID_KLIENTI = " + varInt2 + 
						") AND ((DATA_HYRJE BETWEEN '" + formatoDatenGjate(varDate1) + "' AND '" + formatoDatenGjate(varDate2) + "' AND NOT DATA_HYRJE = '" + formatoDatenGjate(varDate2) + "')" +
						" OR (DATA_DALJE BETWEEN '" + formatoDatenGjate(varDate1)+ "' AND '" + formatoDatenGjate(varDate2)+ "' AND NOT DATA_DALJE = '" + formatoDatenGjate(varDate1)+ "')" +
						" OR (DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + formatoDatenGjate(varDate2)+ "')) "; 
					break;
				default :
					strSql = "";
					break;
				
			}
			return strSql;
			
		}

		public string GetQuery(string kerkesaQuery, int varInt1, string varString1, string varString2)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");

			switch( kerkesaQuery)
			{
				case "ShfaqRezervimetPerKlientPerEmerMbiemerTeDhene" :
					strSql = "SELECT * FROM REZERVIM WHERE EMRI = '" + varString1 + "' AND MBIEMRI = '" + varString2 + "'";
					break;
				case "ShfaqRezervimetPerKlientPerGrupAgjensiTeDhene" :
					strSql = "SELECT * FROM REZERVIM WHERE EMRI = '" + varString1 + "' AND AGJENSIA = '" + varString2 + "'";
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}
		public string GetQuery(string kerkesaQuery, int varInt1, string varString1, string varString2,
			string varString3)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");
			varString3 = varString3.Replace("'", "''");

			switch( kerkesaQuery)
			{
				case "ModifikoGrupi" :
					strSql = "UPDATE GRUPI SET EMRI = '" + varString1 + "' , AGJENSIA = '" + varString2 + "', EMAILI = '" + varString3 + "' WHERE ID_GRUPI = " + varInt1 ;
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}
		public string GetQuery( string kerkesaQuery, int varInt1, string varString1, int varInt2, int varInt3)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");

			switch(kerkesaQuery)
			{

				case "KrijoDhome":
					strSql = "INSERT INTO DHOMA (DHOMA_EMRI, ID_KATEGORIA, DHOMA_CIFT, NR_KREVATESH) VALUES ('" +
						varString1 + "', " + varInt2 + ", '" + varInt1 + "', " + varInt3 + ")";
					break;
				default:
					strSql = "" ;
					break;
			}
			return strSql;
		}
	
		public string GetQuery(string kerkesaQuery, int varInt1, string varString1, int varInt2)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");

			switch( kerkesaQuery)
			{
				case "ModifikoIdentifikimPerKlient" :
					strSql = "UPDATE IDENTIFIKIMI SET ID_LLOJI = " + varInt1 + ", NR_IDENTIFIKIMI = '" + varString1 + "' WHERE ID_IDENTIFIKIMI = " + varInt2 ;
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}
	
		public string GetQuery(string kerkesaQuery, string varString1, string varString2, DateTime varDate1, string varString3, string varString4, string varString5, string varString6,
			DateTime varDate2, DateTime varDate3, int varInt1, int varInt2, string varString7, string varString8)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");
			varString3 = varString3.Replace("'", "''");
			varString4 = varString4.Replace("'", "''");
			varString5 = varString5.Replace("'", "''");
			varString6 = varString6.Replace("'", "''");
			varString7 = varString7.Replace("'", "''");
			varString8 = varString8.Replace("'", "''");

			switch( kerkesaQuery)
			{
				case "ModifikoTeDhenaKlienti" :
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
					strSql = "UPDATE KLIENTI SET EMRI = '" + varString1 + "', MBIEMRI = '" + varString2 + "', DATELINDJA = '" + varDate1.ToShortDateString() +
						"', ADRESA = '" + varString3 + "', TELEFONI = '" + varString4 + "', EMAIL = '" + varString5 + "'," + 
						" TARGA = '" + varString6 + "', DATA_HYRJE = '" + this.formatoDatenGjate(varDate2) + "', DATA_DALJE = '" + this.formatoDatenGjate(varDate3) + 
						"', ID_DHOMA = " + varInt1 + ", VENDLINDJA = '" + varString7 + "', SHTETESIA = '" + varString8 + "' WHERE ID_KLIENTI = " + varInt2 ;
					break;
				case "ModifikoTeDhenaPergjegjes" :
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
					//kapari, skonto, gjoba vendoset 0 
					//varString7 sherben si vendlindja
					//varString8 sherben si shtetesia
					strSql = "UPDATE KLIENTI SET EMRI = '" + varString1 + "', MBIEMRI = '" + varString2 + "', DATELINDJA = '" + varDate1.ToShortDateString() +
						"', ADRESA = '" + varString3 + "', TELEFONI = '" + varString4 + "', EMAIL = '" + varString5 + "'," + 
						" TARGA = '" + varString6 + "', DATA_HYRJE = '" + this.formatoDatenGjate(varDate2) + "', DATA_DALJE = '" + this.formatoDatenGjate(varDate3) + 
						"', ID_DHOMA = " + varInt1 + ", KAPARI = 0, SKONTO = 0, GJOBA = 0, VENDLINDJA = '" + varString7 + "', SHTETESIA ='" + varString8 + "' WHERE ID_KLIENTI = " + varInt2 ;
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}

		public string GetQuery(string kerkesaQuery, string varString1, string varString2, 
			DateTime varDate1, string varString3, string varString4, string varString5, 
			string varString6, DateTime varDate2, DateTime varDate3, 
			int varInt1, int varInt2, int varInt3, string varString7, string varString8)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");
			varString3 = varString3.Replace("'", "''");
			varString4 = varString4.Replace("'", "''");
			varString5 = varString5.Replace("'", "''");
			varString6 = varString6.Replace("'", "''");
			varString7 = varString7.Replace("'", "''");
			varString8 = varString8.Replace("'", "''");

			switch( kerkesaQuery)
			{
				case "ModifikoTeDhenaKlientiGrupi" :
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
					strSql = "UPDATE KLIENTI SET EMRI = '" + varString1 + "', MBIEMRI = '" + varString2 + "', DATELINDJA = '" + varDate1.ToShortDateString() +
						"', ADRESA = '" + varString3 + "', TELEFONI = '" + varString4 + "', EMAIL = '" + varString5 + "'," + 
						" TARGA = '" + varString6 + "', DATA_HYRJE = '" + this.formatoDatenGjate(varDate2) + "', DATA_DALJE = '" + this.formatoDatenGjate(varDate3) + 
						"', ID_DHOMA = " + varInt1 + ", VENDLINDJA = '" + varString7 + "',SHTETESIA = '" + varString8 + "' WHERE ID_KLIENTI = " + varInt2 ;
					strSql += Environment.NewLine + "UPDATE GRUP_KLIENTI SET ID_GRUPI = " + varInt3 + " WHERE ID_KLIENTI = " + varInt2;
					break;
				case "ModifikoTeDhenaPergjegjesGrupi" :
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
					//kapari, skonto, gjoba vendoset 0 
					//varInt3 sherben si idGrupi
					//varString7 sherben si vendlindja
					//varString8 sherben si shtetesia
					strSql = "UPDATE KLIENTI SET EMRI = '" + varString1 + "', MBIEMRI = '" + varString2 + "', DATELINDJA = '" + varDate1.ToShortDateString() +
						"', ADRESA = '" + varString3 + "', TELEFONI = '" + varString4 + "', EMAIL = '" + varString5 + "'," + 
						" TARGA = '" + varString6 + "', DATA_HYRJE = '" + this.formatoDatenGjate(varDate2) + "', DATA_DALJE = '" + this.formatoDatenGjate(varDate3) + 
						"', ID_DHOMA = " + varInt1 + ", KAPARI = 0, SKONTO = 0, GJOBA = 0, VENDLINDJA = '" + varString7 + "', SHTETESIA = '" + varString8 + "' WHERE ID_KLIENTI = " + varInt2 ;
					strSql += Environment.NewLine + "UPDATE GRUP_KLIENTI SET ID_GRUPI = " + varInt3 + " WHERE ID_KLIENTI = " + varInt2;
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}
		public string GetQuery(string kerkesaQuery, int varInt1, int varInt2,  DateTime varDate1, DateTime varDate2)
		{
			string strSql = "";
			switch( kerkesaQuery)
			{
				case "ModifikoCmimiPerDhomen" :
					strSql = "UPDATE CMIMI SET DATA_FILLIMI = '" + varDate1.ToShortDateString() + "', DATA_MBARIMI = '" + varDate2.ToShortDateString() + "', CMIMI = " + varInt2 + " WHERE ID_CMIMI = " + varInt1;
					break;
				case "ShfaqVeprimetPerGrupDheDhome":
					strSql = "SELECT * " +
						"FROM KLIENTI_GRUPI " + 
						"WHERE (ID_GRUPI = " + varInt1 + ") AND (ID_DHOMA = " + varInt2 + ") AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) " + 
						" AND (( DATA_HYRJE >= '" + varDate1.ToShortDateString() + "' AND DATA_HYRJE < ='" + varDate2.ToShortDateString() + "') OR ( DATA_DALJE >= '" + varDate1.ToShortDateString() + "' AND DATA_DALJE <= '" + varDate2.ToShortDateString() + " '))" + 
						" ORDER BY GRUPI, DATA_HYRJE";
					break;
				case "ShfaqVeprimetPerDhomen" :
					if (varInt2 >= 0)
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE (( DATA_HYRJE >= '" + this.formatoDatenGjate(varDate1) + "' AND DATA_HYRJE <'" + this.formatoDatenGjate(varDate2) + "') OR ( DATA_DALJE > '" + this.formatoDatenGjate(varDate1) + "' AND DATA_DALJE <= '" + this.formatoDatenGjate(varDate2) + " ') OR (DATA_HYRJE < '" + this.formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + this.formatoDatenGjate(varDate2) + "' ))  "+
							" AND (ID_DHOMA = " + varInt1 + ") " +
							" AND ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) AND (KLIENT_HOTELI = " + varInt2 + ") ORDER BY DHOMA_EMRI, DATA_HYRJE";
					}
					else
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE (( DATA_HYRJE >= '" + this.formatoDatenGjate(varDate1) + "' AND DATA_HYRJE <'" + this.formatoDatenGjate(varDate2) + "') OR ( DATA_DALJE > '" + this.formatoDatenGjate(varDate1) + "' AND DATA_DALJE <= '" + this.formatoDatenGjate(varDate2) + " ') OR (DATA_HYRJE < '" + this.formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + this.formatoDatenGjate(varDate2) + "' ))  "+
							" AND (ID_DHOMA = " + varInt1 + ") " +
							" AND ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI )ORDER BY DHOMA_EMRI, DATA_HYRJE";
					}
					break;
				case "ShfaqVeprimetPerGrupin" :
					if (varInt2 >= 0)
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							" WHERE (( DATA_HYRJE >= '" + this.formatoDatenGjate(varDate1) + "' AND DATA_HYRJE <'" + formatoDatenGjate(varDate2) + "') OR ( DATA_DALJE > '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE <= '" + formatoDatenGjate(varDate2) + " ') OR (DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + formatoDatenGjate(varDate2) + "' ))  "+
							" AND (ID_GRUPI = " + varInt1 + ") " +
							" AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) AND (KLIENT_HOTELI = " + varInt2 + ") ORDER BY GRUPI, DATA_HYRJE";
					}
					else
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							" WHERE (( DATA_HYRJE >= '" + this.formatoDatenGjate(varDate1) + "' AND DATA_HYRJE <'" + formatoDatenGjate(varDate2) + "') OR ( DATA_DALJE > '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE <= '" + formatoDatenGjate(varDate2) + " ') OR (DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + formatoDatenGjate(varDate2) + "' ))  "+
							" AND (ID_GRUPI = " + varInt1 + ") " +
							" AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI )ORDER BY GRUPI, DATA_HYRJE";
					}
					break;
				case "ShfaqVeprimetNeGrupPerDhomen" :
					if (varInt2 >= 0)
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							" WHERE (( DATA_HYRJE >= '" + varDate1.ToShortDateString() + "' AND DATA_HYRJE <'" + varDate2.ToShortDateString() + "') OR ( DATA_DALJE > '" + varDate1.ToShortDateString() + "' AND DATA_DALJE <= '" + varDate2.ToShortDateString() + " ') OR (DATA_HYRJE < '" + varDate1.ToShortDateString() + "' AND DATA_DALJE > '" + varDate2.ToShortDateString() + "' ))  "+
							" AND (ID_DHOMA = " + varInt1 + ") " +
							" AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) AND (KLIENT_HOTELI = " + varInt2 + ") ORDER BY GRUPI, DATA_HYRJE";
					}
					else
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							" WHERE (( DATA_HYRJE >= '" + varDate1.ToShortDateString() + "' AND DATA_HYRJE <'" + varDate2.ToShortDateString() + "') OR ( DATA_DALJE > '" + varDate1.ToShortDateString() + "' AND DATA_DALJE <= '" + varDate2.ToShortDateString() + " ') OR (DATA_HYRJE < '" + varDate1.ToShortDateString() + "' AND DATA_DALJE > '" + varDate2.ToShortDateString() + "' ))  "+
							" AND (ID_DHOMA = " + varInt1 + ") " +
							" AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI )ORDER BY GRUPI, DATA_HYRJE";
					}
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}	

		public string GetQuery(string kerkesaQuery, int varInt1, int varInt2,  
			DateTime varDate1, DateTime varDate2, int varInt3)
		{
			string strSql = "";
			switch( kerkesaQuery)
			{
				case "ShfaqVeprimetPerGrupin" :
					if (varInt2 >= 0)
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							" WHERE (( DATA_HYRJE >= '" + this.formatoDatenGjate(varDate1) + "' AND DATA_HYRJE <'" + formatoDatenGjate(varDate2) + "') OR ( DATA_DALJE > '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE <= '" + formatoDatenGjate(varDate2) + " ') OR (DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + formatoDatenGjate(varDate2) + "' ))  "+
							" AND (ID_GRUPI = " + varInt1 + ") " +
							" AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) AND (KLIENT_HOTELI = " + varInt2 + ") AND ( NOT ID_REZERVIMI = " + varInt3 + ")ORDER BY GRUPI, DATA_HYRJE";
					}
					else
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							" WHERE (( DATA_HYRJE >= '" + this.formatoDatenGjate(varDate1) + "' AND DATA_HYRJE <'" + formatoDatenGjate(varDate2) + "') OR ( DATA_DALJE > '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE <= '" + formatoDatenGjate(varDate2) + " ') OR (DATA_HYRJE < '" + formatoDatenGjate(varDate1) + "' AND DATA_DALJE > '" + formatoDatenGjate(varDate2) + "' ))  "+
							" AND (ID_GRUPI = " + varInt1 + ") " +
							" AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) AND (NOT ID_REZERVIMI = " + varInt3 + ") ORDER BY GRUPI, DATA_HYRJE";
					}
					break;
				case "ShfaqVeprimetPerGrupDheDhome":
					if (varInt3 >= 0)
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							" WHERE (ID_GRUPI = " + varInt1 + ") AND (ID_DHOMA = " + varInt2 + ") AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) " + 
							" AND (( DATA_HYRJE >= '" + varDate1.ToShortDateString() + "' AND DATA_HYRJE <'" + varDate2.ToShortDateString() + "') OR ( DATA_DALJE > '" + varDate1.ToShortDateString() + "' AND DATA_DALJE <= '" + varDate2.ToShortDateString() + " ') OR (DATA_HYRJE < '" + varDate1.ToShortDateString() + "' AND DATA_DALJE > '" + varDate2.ToShortDateString() + "' ))  "+
							" AND (KLIENT_HOTELI = " + varInt3 + " )"+
							" ORDER BY GRUPI, DATA_HYRJE";
					}
					else
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							" WHERE (ID_GRUPI = " + varInt1 + ") AND (ID_DHOMA = " + varInt2 + ") AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) " + 
							" AND (( DATA_HYRJE >= '" + varDate1.ToShortDateString() + "' AND DATA_HYRJE <'" + varDate2.ToShortDateString() + "') OR ( DATA_DALJE > '" + varDate1.ToShortDateString() + "' AND DATA_DALJE <= '" + varDate2.ToShortDateString() + " ') OR (DATA_HYRJE < '" + varDate1.ToShortDateString() + "' AND DATA_DALJE > '" + varDate2.ToShortDateString() + "' ))  "+
							" ORDER BY GRUPI, DATA_HYRJE";
					}
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}	
		
		public string GetQuery(string kerkesaQuery)
		{
			string strSql = "";
			switch( kerkesaQuery)
			{
				case "ShfaqGjitheKlientetNeHotel":
					strSql = "SELECT * FROM KLIENTI";
					break;
				case "ShfaqDhomaPashlyeraGrupi":
					strSql = "SELECT  K.EMRI, K.MBIEMRI, K.DATA_HYRJE, K.DATA_DALJE, K.KAPARI, K.DHOMA_EMRI,K.ID_DHOMA," +
						" K.CMIMI, K.ID_KATEGORIA, K.GRUPI, K.AGJENSIA,K.ID_GRUPI, K.ID_KLIENTI, K.KLIENT_HOTELI FROM KLIENTI_GRUPI AS K"+ 
						" WHERE (K.PAGUAR_DHOMA = 0)   AND (ID_GRUPI IS NOT NULL) ORDER BY K.GRUPI, K.DATA_HYRJE";
					break;
				case "ShfaqIdKlientFundit" :
					strSql = "SELECT MAX(ID_KLIENTI) FROM KLIENTI" ;
					break;
				case "ShfaqIdRezervimFundit" :
					strSql = "SELECT MAX(ID_REZERVIMI) FROM REZERVIM" ;
					break;
				case "FshiArka" :
					strSql = "DELETE ARKA" ;
					break;
				case "ShfaqDhomat":
					strSql = "SELECT ID_DHOMA, DHOMA_EMRI, NR_KREVATESH, DHOMA.ID_KATEGORIA, KAT_EMRI,DHOMA_CIFT  FROM " +
						"(DHOMA INNER JOIN KATEGORIA ON DHOMA.ID_KATEGORIA = KATEGORIA.ID_KATEGORIA  ) ORDER BY DHOMA_EMRI";
					break;
				case "ShfaqDhomatDitore":
					strSql = "SELECT ID_DHOMA, DHOMA_EMRI, NR_KREVATESH  FROM " +
						"(DHOMA INNER JOIN KATEGORIA ON DHOMA.ID_KATEGORIA = KATEGORIA.ID_KATEGORIA  )" +
						"WHERE NOT (DHOMA.ID_KATEGORIA = 31) ORDER BY DHOMA_EMRI";
					break;
				case "ShfaqRezervimetKliente":
					strSql = "SELECT * FROM DHOMAT_REZERVIMET WHERE ID_GRUPI IS NULL ORDER BY DATA_FILLIMI";
					break;
				case "ShfaqRezervimetGrupe":
					strSql = "SELECT DISTINCT DATA_REZERVIMI,DATA_FILLIMI,DATA_MBARIMI,DATA_KAPARI,ID_REZERVIMI,KAPARI,G.EMRI,G.AGJENSIA ,G.ID_GRUPI " +
						"FROM DHOMAT_REZERVIMET AS DR  INNER JOIN GRUPI AS G ON DR.ID_GRUPI = G.ID_GRUPI ";
					break;
				case "ShfaqRezervimetGrupDhome":
					strSql = "SELECT ID_DHOMA,DHOMA_EMRI,KAT_EMRI, DATA_REZERVIMI,DATA_FILLIMI,DATA_MBARIMI,ID_REZERVIMI,KAPARI,G.EMRI,G.AGJENSIA ,G.ID_GRUPI,ID_KATEGORIA " +
						"FROM DHOMAT_REZERVIMET AS DR  INNER JOIN GRUPI AS G ON DR.ID_GRUPI = G.ID_GRUPI ORDER BY DATA_FILLIMI, G.EMRI";
					break;
				case "ShfaqRezervimetVlefshme":
					strSql = "SELECT  DATA_FILLIMI,DATA_MBARIMI,DATA_REZERVIMI,EMRI,MBIEMRI,KAPARI,DHOMA_EMRI, ID_REZERVIMI FROM REZERVIME_VLEFSHME WHERE ID_GRUPI IS NULL ORDER BY DATA_FILLIMI,EMRI";
					break;
				case "ShfaqRezervimetVlefshmeGrupi":
					strSql = "SELECT DATA_FILLIMI,DATA_MBARIMI,DATA_REZERVIMI,KAPARI,GRUPI,AGJENSIA,DHOMA_EMRI,ID_REZERVIMI FROM REZERVIME_VLEFSHME WHERE ID_GRUPI IS NOT NULL ORDER BY DATA_FILLIMI ";
					break;
				case "ShfaqMjeteIdentifikimi":
					strSql = "SELECT * FROM LLOJI_IDENTIFIKIMI";
					break;
				case "ShfaqGjitheShpenzimet" :
					strSql = "SELECT * FROM SHPENZIMI ORDER BY DATA";
					break;
				case "ShfaqDhomaNePerdorim" :
					strSql = "SELECT ID_DHOMA, DHOMA_EMRI, NR_KREVATESH FROM DHOMA INNER JOIN KATEGORIA" + 
						" ON DHOMA.ID_KATEGORIA = KATEGORIA.ID_KATEGORIA" +
						" WHERE NOT DHOMA.ID_KATEGORIA = 1 ";
					break;
				case "ShfaqKategorite" :
					strSql = "SELECT * FROM KATEGORIA";
					break;
				case "ShfaqLlojetDetyrime" :
					strSql = "SELECT * FROM LLOJET_DETYRIMI";
					break;
				case "InicializoIdentifikimi" :
					strSql = "SELECT MAX(ID_IDENTIFIKIMI) AS NR_IDENTIFIKIMI FROM IDENTIFIKIMI";
					break;
				case "InicializoCmimiDhoma" :
					strSql = "SELECT MAX(ID_CMIMI) AS NR_CMIMI FROM CMIMI";
					break;
				case "InicializoKlienti" :
					strSql = "SELECT MAX(ID_KLIENTI) AS NR_KLIENTI FROM KLIENTI";
					break;
				case "InicializoGrupi" :
					strSql = "SELECT MAX(ID_GRUPI) AS NR_GRUPI FROM GRUPI";
					break;
				case "ShumaKapariRezervimi" :
					strSql = "SELECT SUM(KAPARI) FROM REZERVIM";
					break;
				case "ShfaqGrupe":
					strSql = "SELECT ID_GRUPI, EMRI, AGJENSIA FROM GRUPI";
					break;
				case "InicializoRezervimi" :
					strSql = "SELECT MAX(ID_REZERVIMI) FROM REZERVIM ";
					break;
				case "ShfaqKlientetNeHotel" :
					strSql = "SELECT * " +
						"FROM KLIENTI_GRUPI " + 
						"WHERE KLIENT_HOTELI= 1  AND ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) " + 
						"  ORDER BY DHOMA_EMRI, DATA_HYRJE ";
					break;
				case "ShfaqDhomaPashlyera" :
					//					strSql = "SELECT  KLIENTI.EMRI, KLIENTI.MBIEMRI, KLIENTI.DATA_HYRJE, KLIENTI.DATA_DALJE," + 
					//						"  KLIENTI.KAPARI, DHOMAT_CMIMET.DHOMA_EMRI, DHOMAT_CMIMET.NR_KREVATESH," +
					//						" DHOMAT_CMIMET.CMIMI, DHOMAT_CMIMET.ID_KATEGORIA" +
					//						" FROM (KLIENTI INNER JOIN  DHOMAT_CMIMET  ON KLIENTI.ID_DHOMA = DHOMAT_CMIMET.ID_DHOMA)" +
					//						" WHERE (KLIENTI.DATA_HYRJE >= DHOMAT_CMIMET.DATA_FILLIMI) AND (KLIENTI.DATA_HYRJE <= DHOMAT_CMIMET.DATA_MBARIMI)" +
					//						" AND (KLIENTI.KLIENT_HOTELI = 1) " + 
					//						"   ORDER BY DHOMAT_CMIMET.DHOMA_EMRI, KLIENTI.DATA_HYRJE";
					strSql = "SELECT  K.EMRI, K.MBIEMRI, K.DATA_HYRJE, K.DATA_DALJE,  K.KAPARI, DHC.DHOMA_EMRI, " +
						" DHC.NR_KREVATESH, DHC.CMIMI, DHC.ID_KATEGORIA FROM (KLIENTI_GRUPI AS K INNER JOIN  DHOMAT_CMIMET AS DHC" +
						" ON K.ID_DHOMA = DHC.ID_DHOMA)  WHERE (K.DATA_HYRJE >= DHC.DATA_FILLIMI)" + 
						" AND (K.DATA_HYRJE <= DHC.DATA_MBARIMI) AND (K.KLIENT_HOTELI = 1)  "+
						" AND (ID_GRUPI IS NULL) ORDER BY DHC.DHOMA_EMRI, K.DATA_HYRJE";
					break;
				case "DataRezervimiFundit" :
					strSql = "SELECT MAX(DATA_MBARIMI) AS MAX FROM DHOMAT_REZERVIMET WHERE NOT ID_KATEGORIA = 31 ";
					break;
				case "DataDaljeFundit" :
					strSql = "SELECT MAX(KLIENTI.DATA_DALJE) AS MAX FROM KLIENTI INNER JOIN DHOMA_KATEGORIA " +
						" ON DHOMA_KATEGORIA.ID_DHOMA = KLIENTI.ID_DHOMA  AND NOT DHOMA_KATEGORIA.ID_KATEGORIA = 31";
					break;
				case "DataDaljeFunditAll" :
					strSql = "SELECT MAX(KLIENTI.DATA_DALJE) AS MAX FROM KLIENTI";
					break;
				case "DataHyrjePare" :
					strSql = "SELECT MIN(KLIENTI.DATA_HYRJE) AS MIN FROM KLIENTI";
					break;
				case "ShfaqHyrjetPasSot" :
					strSql = "SELECT  DATA_HYRJE, DATA_DALJE, ID_DHOMA FROM KLIENTI WHERE DATA_DALJE> '" + this.formatoDatenGjate(DateTime.Now) + "'";
					break;
				case "ShfaqGjitheHyrjet" :
					strSql = "SELECT  DATA_HYRJE, DATA_DALJE, ID_DHOMA FROM KLIENTI ";
					break;
				case "ShfaqRezervimetVlefshmePerDhomatMeOre" :
					strSql = "SELECT DHOMA_EMRI, KAT_EMRI, DATA_FILLIMI, DATA_MBARIMI FROM DHOMAT_REZERVIMET" +
						" WHERE (ID_KATEGORIA = 31) AND (DATA_MBARIMI >'" + this.formatoDatenGjate(System.DateTime.Today)+ "')";
					break;
				case "ShfaqHyrjetPasSotDhomatMeOre" :
					strSql = "SELECT DHOMA_KATEGORIA.DHOMA_EMRI, DHOMA_KATEGORIA.KAT_EMRI, KLIENTI.DATA_HYRJE, KLIENTI.DATA_DALJE" + 
						" FROM KLIENTI INNER JOIN DHOMA_KATEGORIA ON KLIENTI.ID_DHOMA = DHOMA_KATEGORIA.ID_DHOMA" + 
						"  WHERE ((DHOMA_KATEGORIA.ID_KATEGORIA = 31)  AND (KLIENTI.DATA_DALJE > '" + this.formatoDatenGjate(System.DateTime.Today) + "'))";
					break;
				case "ShfaqRolet":
					strSql = "SELECT ROL_ID, PERSHKRIMI FROM ROLET";
					break;
				case "ShfaqPerdoruesit":
					strSql = "SELECT * FROM USERS";
					break;
				case "KontrolloNumerAdmin":
					strSql = "SELECT COUNT(ROL_ID) FROM USERS WHERE ROL_ID = " + 1;;
					break;
				case "ShfaqCmimetPerDhomat":
					strSql = "SELECT D.ID_DHOMA,D.DHOMA_EMRI,D.ID_KATEGORIA,D.ID_CMIMI,D.CMIMI,D.NR_KREVATESH,D.DATA_FILLIMI,D.DATA_MBARIMI,DK.KAT_EMRI  FROM DHOMAT_CMIMET AS D INNER JOIN DHOMA_KATEGORIA AS DK ON D.ID_DHOMA = DK.ID_DHOMA ";
					break;
				
				case "ShfaqTeGjitheRezervimet":
					strSql = "SELECT * FROM DHOMAT_REZERVIMET ";
					break;
				case "ShfaqKlientetGrupNeHotel":
					strSql = "SELECT * " +
						"FROM KLIENTI_GRUPI " + 
						"WHERE KLIENT_HOTELI= 1  AND ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) " + 
						"  ORDER BY GRUPI, DATA_HYRJE ";
					break;
				case "ShfaqRezervimeSkaduar":
					// Shfaq te gjitha rezervimet te cilave u ka skaduar afati, per kliente
					strSql = "SELECT DISTINCT R.ID_REZERVIMI,R.DATA_REZERVIMI, R.DATA_FILLIMI, R.DATA_MBARIMI,R.DATA_KAPARI, R.KAPARI, R.EMRI, R.MBIEMRI, DK.ID_DHOMA, DK.DHOMA_EMRI, DK.KAT_EMRI ,DK.ID_KATEGORIA, R.EMAILI " + 
						"FROM REZERVIM AS R INNER JOIN DHOMA_REZERVIMI AS DR ON R.ID_REZERVIMI = DR.ID_REZERVIMI " +
						"INNER JOIN DHOMA_KATEGORIA AS DK ON DR.ID_DHOMA = DK.ID_DHOMA " +
						"WHERE (R.ID_GRUPI IS NULL) AND (R.DATA_MBARIMI < GETDATE())";
					break;
				case "ShfaqRezervimeSkaduarGrupe":
					strSql = "SELECT DISTINCT R.ID_REZERVIMI, R.DATA_REZERVIMI, R.DATA_FILLIMI,R.DATA_MBARIMI,G.EMRI,G.AGJENSIA, R.KAPARI,R.DATA_KAPARI,R.ID_GRUPI " + 
						"FROM DHOMAT_REZERVIMET AS R  INNER JOIN GRUPI AS G ON R.ID_GRUPI = G.ID_GRUPI " +
						"WHERE (R.ID_GRUPI IS NOT NULL) AND (R.DATA_MBARIMI < GETDATE())";
					break;
				case "ShfaqDhomatEPadorezuara":
					strSql = "SELECT  K.EMRI, K.MBIEMRI, K.DATA_HYRJE, K.DATA_DALJE," + 
						" K.KAPARI, DHC.DHOMA_EMRI, DHC.NR_KREVATESH, DHC.CMIMI, DHC.ID_KATEGORIA," +
						" DHC.ID_DHOMA, KAT.KAT_EMRI" +
						" FROM (KLIENTI  AS K INNER JOIN  DHOMAT_CMIMET  AS DHC ON K.ID_DHOMA = DHC.ID_DHOMA)" +
						" INNER JOIN KATEGORIA AS KAT ON KAT.ID_KATEGORIA = DHC.ID_KATEGORIA" +
						//" WHERE (K.DATA_HYRJE >= DHC.DATA_FILLIMI) AND (K.DATA_HYRJE <= DHC.DATA_MBARIMI)" +
						" WHERE (K.ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI))" +
						" AND (K.KLIENT_HOTELI = 1) AND (K.DATA_DALJE < GETDATE())" + 
						" AND (DATEDIFF(DAY, K.DATA_HYRJE, DHC.DATA_FILLIMI) <= 0) AND (DATEDIFF(DAY, K.DATA_HYRJE, DHC.DATA_MBARIMI) >= 0)" +
						" ORDER BY DHC.DHOMA_EMRI, K.DATA_HYRJE";
					break;
				case "ShfaqDhomatEPadorezuaraGrupe":
					strSql = "SELECT  K.EMRI, K.MBIEMRI, K.DATA_HYRJE, K.DATA_DALJE," + 
						" K.KAPARI, DHC.DHOMA_EMRI, DHC.NR_KREVATESH, DHC.CMIMI, DHC.ID_KATEGORIA," +
						" DHC.ID_DHOMA, KAT.KAT_EMRI, G.EMRI AS GRUPI_EMRI, G.AGJENSIA, G.ID_GRUPI" +
						" FROM (KLIENTI  AS K INNER JOIN  DHOMAT_CMIMET  AS DHC ON K.ID_DHOMA = DHC.ID_DHOMA" +
						" INNER JOIN GRUP_KLIENTI AS GK ON K.ID_KLIENTI = GK.ID_KLIENTI" +
						" INNER JOIN GRUPI AS G ON G.ID_GRUPI = GK.ID_GRUPI)" + 
						" INNER JOIN KATEGORIA AS KAT ON KAT.ID_KATEGORIA = DHC.ID_KATEGORIA" +
						//" WHERE (K.DATA_HYRJE >= DHC.DATA_FILLIMI) " + // AND (K.DATA_HYRJE <= DHC.DATA_MBARIMI)" +
						" WHERE (K.ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI))" +
						" AND (K.KLIENT_HOTELI = 1) AND (K.DATA_DALJE < GETDATE())" + 
						" AND (DATEDIFF(DAY, K.DATA_HYRJE, DHC.DATA_FILLIMI) <= 0) AND (DATEDIFF(DAY, K.DATA_HYRJE, DHC.DATA_MBARIMI) >= 0)"+
						" ORDER BY DHC.DHOMA_EMRI, K.DATA_HYRJE";
					break;
				case "ShfaqLlojetEShpenzimeve":
					strSql = "SELECT  * FROM LLOJE_SHPENZIMI";
					break;
				case "DataMinRezervimetEVlefshmePerSot":
					strSql = "SELECT MIN(DATA_FILLIMI) AS MIN"+
						" FROM DHOMAT_REZERVIMET WHERE '" + this.formatoDatenGjate(DateTime.Now) + "' BETWEEN  DATA_FILLIMI AND DATA_MBARIMI AND NOT ID_KATEGORIA = 31";
					break;
				case "DataMinHyrjetEVlefshmePerSot":
					strSql = "SELECT MIN(KLIENTI.DATA_HYRJE) AS MIN FROM KLIENTI INNER JOIN DHOMA_KATEGORIA " +
						" ON DHOMA_KATEGORIA.ID_DHOMA = KLIENTI.ID_DHOMA WHERE KLIENTI.KLIENT_HOTELI = 1 AND NOT DHOMA_KATEGORIA.ID_KATEGORIA = 31" +
						" AND '" + this.formatoDatenGjate(DateTime.Now) + "' BETWEEN  DATA_HYRJE AND DATA_DALJE ";
					break;
				case "ShfaqTeGjithaFormatEPageses":
					strSql = "SELECT * FROM FORMA_PAGESA";
					break;
				default :
					strSql = "";
					break;
			}
			return strSql;
		}
	
		public string GetQuery(string kerkesaQuery, int varInt1 )
		{
			string strSql = "" ;
			DateTime dataSot = System.DateTime.Today ;
			switch(kerkesaQuery)
			{
				case "ShfaqPerdoruesPerKlient":
					strSql = "SELECT USER_ID FROM ARKA WHERE ID_KLIENTI = " + varInt1 + " AND (KOMENT = 'Kapar dhome' OR KOMENT = 'Kapar grupi')";
					break;
				case "ShfaqDataPerRezervim":
					strSql = "SELECT DATA_FILLIMI, DATA_MBARIMI FROM REZERVIM WHERE ID_REZERVIMI = " + varInt1;
					break;
				case "PaguajDhome":
					strSql = "UPDATE KLIENTI SET PAGUAR_DHOMA = 1 WHERE ID_KLIENTI = " + varInt1;
					break;
				case "ShfaqRezervimDhomaGrupiPerDaten":
					strSql = "SELECT R.ID_DHOMA,R.ID_KATEGORIA,R.DHOMA_EMRI,R.KAT_EMRI,DHC.CMIMI, R.DATA_FILLIMI, R.DATA_MBARIMI  FROM DHOMAT_REZERVIMET AS R " +
						"INNER JOIN GRUPI AS G ON R.ID_GRUPI=G.ID_GRUPI " +
						" INNER JOIN DHOMAT_CMIMET AS DHC ON DHC.ID_DHOMA = R.ID_DHOMA " +
						"WHERE R.ID_REZERVIMI = " + varInt1 + " AND R.DATA_FILLIMI BETWEEN DHC.DATA_FILLIMI AND DHC.DATA_MBARIMI" ;
					break;
				case "ShfaqKaparRezervimiArkaFormePagese" :
					strSql = "SELECT A.ARKA_SASIA, FP.ID_FORMAPAGESA, FP.EMRI FROM ARKA AS A INNER JOIN  FORMA_PAGESA AS FP ON FP.ID_FORMAPAGESA = A.ID_FORMAPAGESA WHERE ID_REZERVIMI = " + varInt1;
					break;
				case "ShfaqKaparRezervimiArka" :
					strSql = "SELECT * FROM ARKA WHERE ID_REZERVIMI = " + varInt1;
					break;
				case "ShfaqVeprimetPerRezervim" :
					strSql = "SELECT * " +
						"FROM KLIENTI_GRUPI " + 
						" WHERE ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) AND ( ID_REZERVIMI = " + varInt1 + ")ORDER BY GRUPI, DATA_HYRJE";
					break;
				case "KaparRezervimiNeArke" :
					strSql =  "SELECT * FROM ARKA "+
						" WHERE ID_REZERVIMI = " + varInt1 + " AND (KOMENT = 'Kapar rezervimi')";
					break;
				case "ShfaqKlientetGrupNeHotel" :
					if (varInt1 >= 0)
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) AND (KLIENT_HOTELI = " + varInt1 + ") ORDER BY GRUPI, DATA_HYRJE";
					}
					else
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI )ORDER BY GRUPI, DATA_HYRJE";
					}
					break;
				case "KaparKlientiNeArke" :
					strSql =  "SELECT * FROM ARKA "+
						" WHERE ID_KLIENTI = " + varInt1 + " AND ((KOMENT = 'Kapar dhome') OR (KOMENT = 'Kapar grupi'))";
					break;
				case "FshiPagese" :
					strSql =  "DELETE FROM ARKA "+
						" WHERE ID_KLIENTI = " + varInt1 + " AND ((KOMENT = 'Pagese dhome') OR (KOMENT = 'Pagese grupi'))";
					break;
				case "ShfaqFormePagesePerKlient" :
					strSql =  "SELECT A.ID_FORMAPAGESA, FP.EMRI FROM ARKA AS A INNER JOIN FORMA_PAGESA AS FP ON A.ID_FORMAPAGESA = FP.ID_FORMAPAGESA "+
						" WHERE A.ID_KLIENTI = " + varInt1 + " AND ((A.KOMENT = 'Kapar dhome') OR(A.KOMENT = 'Kapar grupi'))";
					break;
				case "PageseKlientiNeArke" :
					strSql =  "SELECT * FROM ARKA "+
						" WHERE ID_KLIENTI = " + varInt1 + " AND ((KOMENT = 'Pagese dhome') OR (KOMENT = 'Pagese grupi'))";
					break;
				case "GjejIdDetyrimiLLoji" :
					strSql =  "SELECT EMER_LLOJI FROM DETYRIMET AS D INNER JOIN LLOJET_DETYRIMI AS LD" + 
						" ON D.ID_LLOJDETYRIMI = LD.ID_LLOJDETYRIMI WHERE ID_DETYRIMI = " + varInt1;
					break;
				case "ShfaqRezervimeVlefshmePerDhomen":
					strSql = "SELECT EMRI, MBIEMRI , DATA_FILLIMI, DATA_MBARIMI,DATA_REZERVIMI,DHOMA_EMRI,KAPARI,ID_DHOMA FROM REZERVIME_VLEFSHME " + 
						"WHERE ID_DHOMA = " + varInt1 +" AND ID_GRUPI IS NULL ORDER BY DATA_FILLIMI ";
					break;
				case "ShfaqRezervimeVlefshmeGrupiPerDhomen":
					strSql = "SELECT GRUPI, AGJENSIA , DATA_FILLIMI, DATA_MBARIMI,DATA_REZERVIMI,DHOMA_EMRI,KAPARI FROM REZERVIME_VLEFSHME " + 
						"WHERE ID_DHOMA = " + varInt1 +" AND ID_GRUPI IS NOT NULL ORDER BY DATA_FILLIMI ";
					break;
				case "ShfaqRezervimeVlefshmePerGrupAgjensi":
					strSql = "SELECT GRUPI, AGJENSIA , DATA_FILLIMI, DATA_MBARIMI,DATA_REZERVIMI,DHOMA_EMRI,KAPARI,ID_REZERVIMI FROM REZERVIME_VLEFSHME " + 
						"WHERE ID_GRUPI = " + varInt1 +" ORDER BY DATA_FILLIMI ";
					break;
				case "FshiKaparKlientiNgaArka":
					strSql = "DELETE FROM ARKA WHERE ID_KLIENTI = " + varInt1 + " AND ((KOMENT = 'Kapar dhome') OR (KOMENT = 'Kapar grupi')) " ;
					break;
				case "ShfaqKlientPerId":
					strSql = "SELECT * FROM KLIENTI_GRUPI WHERE ID_KLIENTI = " + varInt1 ;
					break;
				case "FshiDhome":
					strSql = "DELETE FROM DHOMA_CMIMI WHERE ID_DHOMA = " + varInt1;
					strSql += Environment.NewLine + "DELETE FROM DHOMA WHERE ID_DHOMA = " + varInt1;
					break;
				case "FshiLlojDetyrimi" :
					strSql = "DELETE FROM LLOJET_DETYRIMI WHERE ID_LLOJDETYRIMI = " + varInt1 ;
					break;
				case "FshiDetyrimi" :
					strSql = "DELETE FROM DETYRIMET WHERE ID_DETYRIMI = " + varInt1 ;
					break;
				case "FshiKategori" :
					strSql = "DELETE FROM KATEGORIA WHERE ID_KATEGORIA = " + varInt1 ;
					break;
				case "FshiIdentifikimi" :
					strSql = "DELETE FROM IDENTIFIKIMI WHERE ID_IDENTIFIKIMI = " + varInt1 ;
					break;
				case "FshiMjetIdentifikimi" :
					strSql = "DELETE FROM LLOJI_IDENTIFIKIMI WHERE ID_LLOJI = " + varInt1 ;
					break;
				case "FshiShpenzim" :
					strSql = "DELETE FROM SHPENZIMI WHERE ID_SHPENZIMI = " + varInt1 ;
					break;
				case "FshiGrupi" :
					strSql = "DELETE FROM GRUPI WHERE ID_GRUPI = " + varInt1 ;
					break;
				case "FshiRezervim" :
					strSql = "DELETE FROM DHOMA_REZERVIMI WHERE ID_REZERVIMI = " + varInt1 ;
					strSql += Environment.NewLine + " DELETE FROM REZERVIM WHERE ID_REZERVIMI = " + varInt1;
					break;

				case "NxirrCmimiDhoma" :
					strSql = "SELECT ID_CMIMI, DATA_FILLIMI, DATA_MBARIMI, CMIMI FROM CMIMI WHERE ID_CMIMI IN ( SELECT ID_CMIMI FROM DHOMA_CMIMI WHERE ID_DHOMA = " + varInt1 + ")" ;
					break;
				case "ShfaqDetyrimePerKlientin" :
					strSql = "SELECT ID_DETYRIMI, EMER_LLOJI, CMIMI, SASIA " +
						"FROM DETYRIMET AS D INNER JOIN LLOJET_DETYRIMI AS L ON D.ID_LLOJDETYRIMI = L.ID_LLOJDETYRIMI" +
						" WHERE ID_KLIENTI = " + varInt1 ;
					break;
				case "NxirrDhome" :
					strSql = "SELECT ID_DHOMA ,DHOMA_EMRI, KAT_EMRI, NR_KREVATESH,DHOMA_CIFT, KATEGORIA.ID_KATEGORIA FROM DHOMA INNER JOIN KATEGORIA ON DHOMA.ID_KATEGORIA = KATEGORIA.ID_KATEGORIA WHERE ID_DHOMA = " + varInt1 ;
					break;
				case "ShfaqKlientetPerDhomenEdhene" :
					strSql = "SELECT ID_KLIENTI, EMRI, MBIEMRI, DATA_HYRJE, DATA_DALJE FROM KLIENTI WHERE ID_DHOMA = " + varInt1 + " AND KLIENT_HOTELI = 1" ;
					break;
				case "NxirrDhomeRezervuar" :
					strSql = "SELECT D.ID_DHOMA, D.DHOMA_EMRI, D.KAT_EMRI, D.NR_KREVATESH, R.DATA_FILLIMI, R.DATA_MBARIMI , R.EMRI " +
						"FROM (SELECT ID_DHOMA, DHOMA_EMRI, KAT_EMRI, NR_KREVATESH FROM DHOMA INNER JOIN KATEGORIA ON DHOMA.ID_KATEGORIA = KATEGORIA.ID_KATEGORIA) AS D " +
						"INNER JOIN DHOMA_REZERVIMI AS DR ON D.ID_DHOMA = DR.ID_DHOMA " +
						"INNER JOIN REZERVIM AS R ON DR.ID_REZERVIMI = R.ID_REZERVIMI " +
						"WHERE DR.ID_DHOMA =" + varInt1 ;
					break;
				case "NxirrDhomaZene" :
					strSql = "SELECT DHOMA_EMRI FROM DHOMA WHERE DHOMA_GJENDJA = " + varInt1;
					break;
				case "ShfaqDhomaPerKategorine":
					strSql = "SELECT DHOMA_EMRI, ID_DHOMA FROM DHOMA WHERE ID_KATEGORIA = " + varInt1;
					break;
				case "DorezoDhome" :
					strSql = "UPDATE DHOMA SET DHOMA_GJENDJA WHERE ID_DHOMA = " + varInt1 ;
					break;
				case "ShfaqDataPerKlientin" :
					strSql = "SELECT DATA_HYRJE, DATA_DALJE,KLIENT_HOTELI FROM KLIENTI WHERE ID_KLIENTI = " + varInt1;
					break;
				case "ShfaqDetyrimetPerKlientetEdhomes" :
					strSql = " SELECT KD.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE,EMER_LLOJI,DATA,SASIA,CMIMI,DHOMA_EMRI,KAT_EMRI,KD.ID_DETYRIMI "+
						" FROM "+
						" (SELECT K.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE ,DATA,SASIA,ID_LLOJDETYRIMI,ID_DHOMA,ID_DETYRIMI"+
						" FROM KLIENTI AS K"+
						" LEFT JOIN DETYRIMET AS D "+
						" ON K.ID_KLIENTI=D.ID_KLIENTI"+
						" WHERE KLIENT_HOTELI =1)AS KD "+
						" LEFT JOIN LLOJET_DETYRIMI AS LD "+
						" ON LD.ID_LLOJDETYRIMI=KD.ID_LLOJDETYRIMI"+
						" LEFT JOIN DHOMA_KATEGORIA AS DK ON"+
						" DK.ID_DHOMA=KD.ID_DHOMA"+
						" WHERE DK.ID_DHOMA = "+varInt1+" ORDER BY EMRI";

					//					strSql = "SELECT ID_DETYRIMI,D.ID_KLIENTI, EMRI, MBIEMRI, D.ID_LLOJDETYRIMI,D.DATA, EMER_LLOJI,CMIMI,SASIA,KAT_EMRI,DHOMA_EMRI " + 
					//						"FROM DETYRIMET AS D INNER JOIN LLOJET_DETYRIMI AS LD ON D.ID_LLOJDETYRIMI = LD.ID_LLOJDETYRIMI " +
					//						"INNER JOIN (SELECT ID_KLIENTI, EMRI, MBIEMRI,DHOMA_EMRI,KAT_EMRI FROM KLIENTI_GRUPI WHERE ID_DHOMA = " + varInt1 + " AND " +
					//						"KLIENT_HOTELI =1) AS K " +
					//						"ON D.ID_KLIENTI = K.ID_KLIENTI ORDER BY EMRI";
					break;
				case "ShfaqVetemDetyrimetPerKlientetEdhomes" :
					strSql = " SELECT KD.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE,EMER_LLOJI,DATA,SASIA,CMIMI,DHOMA_EMRI,KAT_EMRI,KD.ID_DETYRIMI "+
						" FROM "+
						" (SELECT K.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE ,DATA,SASIA,ID_LLOJDETYRIMI,ID_DHOMA,ID_DETYRIMI"+
						" FROM KLIENTI AS K"+
						" INNER JOIN DETYRIMET AS D "+
						" ON K.ID_KLIENTI=D.ID_KLIENTI"+
						" )AS KD "+
						" INNER JOIN LLOJET_DETYRIMI AS LD "+
						" ON LD.ID_LLOJDETYRIMI=KD.ID_LLOJDETYRIMI"+
						" INNER JOIN DHOMA_KATEGORIA AS DK ON"+
						" DK.ID_DHOMA=KD.ID_DHOMA"+
						" WHERE DK.ID_DHOMA = "+varInt1+" ORDER BY EMRI";
					break;
				case "ShfaqDetyrimKlientiPerKategorine" :
					
					strSql = " SELECT KD.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE,EMER_LLOJI,DATA,SASIA,CMIMI,DHOMA_EMRI,KAT_EMRI,KD.ID_DETYRIMI "+
						" FROM "+
						" (SELECT K.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE ,DATA,SASIA,ID_LLOJDETYRIMI,ID_DHOMA,ID_DETYRIMI "+
						" FROM KLIENTI AS K"+
						" LEFT JOIN DETYRIMET AS D "+
						" ON K.ID_KLIENTI=D.ID_KLIENTI"+
						" WHERE KLIENT_HOTELI =1)AS KD "+
						" LEFT JOIN LLOJET_DETYRIMI AS LD "+
						" ON LD.ID_LLOJDETYRIMI=KD.ID_LLOJDETYRIMI"+
						" LEFT JOIN DHOMA_KATEGORIA AS DK ON"+
						" DK.ID_DHOMA=KD.ID_DHOMA "+
						" WHERE ID_KATEGORIA = "+ varInt1 +" ORDER BY EMRI";
					
					//					strSql = "SELECT ID_DETYRIMI,D.ID_KLIENTI,EMRI, MBIEMRI, D.ID_LLOJDETYRIMI,D.DATA, EMER_LLOJI,CMIMI, SASIA,KAT_EMRI,DHOMA_EMRI " + 
					//						"FROM DETYRIMET AS D INNER JOIN LLOJET_DETYRIMI AS LD ON D.ID_LLOJDETYRIMI = LD.ID_LLOJDETYRIMI " +
					//						"INNER JOIN (SELECT ID_KLIENTI, EMRI, MBIEMRI,DHOMA_EMRI,KAT_EMRI FROM KLIENTI_GRUPI WHERE ID_KATEGORIA = " + varInt1 + " AND " +
					//						"KLIENT_HOTELI =1 ) AS K " +
					//						"ON D.ID_KLIENTI = K.ID_KLIENTI ORDER BY EMRI";
					break;
				case "ShfaqVetemDetyrimKlientiPerKategorine" :
					
					strSql = " SELECT KD.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE,EMER_LLOJI,DATA,SASIA,CMIMI,DHOMA_EMRI,KAT_EMRI,KD.ID_DETYRIMI "+
						" FROM "+
						" (SELECT K.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE ,DATA,SASIA,ID_LLOJDETYRIMI,ID_DHOMA,ID_DETYRIMI "+
						" FROM KLIENTI AS K"+
						" INNER JOIN DETYRIMET AS D "+
						" ON K.ID_KLIENTI=D.ID_KLIENTI"+
						" )AS KD "+
						" INNER JOIN LLOJET_DETYRIMI AS LD "+
						" ON LD.ID_LLOJDETYRIMI=KD.ID_LLOJDETYRIMI"+
						" INNER JOIN DHOMA_KATEGORIA AS DK ON"+
						" DK.ID_DHOMA=KD.ID_DHOMA "+
						" WHERE ID_KATEGORIA = "+ varInt1 +" ORDER BY EMRI";
					break;
				case "ShfaqCmimetPerDhomenEdhene" :
					strSql = "SELECT C.ID_CMIMI, DATA_FILLIMI, DATA_MBARIMI, CMIMI , ID_DHOMA, DHOMA_EMRI, KAT_EMRI ,NR_KREVATESH ,ID_KATEGORIA " +
						"FROM (SELECT DK.ID_DHOMA,ID_CMIMI, DHOMA_EMRI, KAT_EMRI,NR_KREVATESH,ID_KATEGORIA FROM DHOMA_KATEGORIA AS DK INNER JOIN DHOMA_CMIMI AS DC ON DK.ID_DHOMA = DC.ID_DHOMA WHERE DK.ID_DHOMA = " + varInt1 + ") AS D INNER JOIN CMIMI AS C ON D.ID_CMIMI = C.ID_CMIMI ";
					break;

				case "ShfaqCmimetPerShtreter" :
					strSql = "SELECT * FROM  DHOMA_KATEGORIA WHERE NR_KREVATESH = " + varInt1 ;
					break;
				case "ShfaqCmimetPerKategorineEdhene" :
					strSql = "SELECT  C.ID_CMIMI, DATA_FILLIMI, DATA_MBARIMI, CMIMI , ID_DHOMA, DHOMA_EMRI, KAT_EMRI, NR_KREVATESH ,ID_KATEGORIA " +
						"FROM (SELECT  DK.ID_DHOMA,ID_CMIMI, DHOMA_EMRI, KAT_EMRI,NR_KREVATESH,ID_KATEGORIA FROM DHOMA_KATEGORIA AS DK INNER JOIN DHOMA_CMIMI AS DC ON DK.ID_DHOMA = DC.ID_DHOMA WHERE DK.ID_KATEGORIA = " + varInt1 + ") AS D INNER JOIN CMIMI AS C ON D.ID_CMIMI = C.ID_CMIMI ";
					break;
				case "ShfaqDhomenPerKategorineEdhene" :
					strSql = "SELECT * FROM DHOMA_KATEGORIA WHERE ID_KATEGORIA = " + varInt1 ;
					break;
				case "GjejNrKlientDhome" :
					strSql = "SELECT COUNT(ID_KLIENTI) AS NR_KLIENTESH FROM KLIENTI WHERE ID_DHOMA = " + varInt1 + " AND " +
						"(DATA_HYRJE <= '" + System.DateTime.Today.ToShortDateString() + "' AND DATA_DALJE > '" + System.DateTime.Today.ToShortDateString() + "')";
					break;
				case "ShfaqLlojDetyriminEzgjedhur":
					strSql = "SELECT EMER_LLOJI, CMIMI FROM LLOJET_DETYRIMI WHERE ID_LLOJDETYRIMI = " + varInt1;
					break;
				case "KontrolloLlojDetyrimiKlienti":
					strSql = "SELECT COUNT(ID_DETYRIMI) AS NUMRI FROM DETYRIMET WHERE ID_LLOJDETYRIMI = " + varInt1;
					break;
				case "KontrolloIdLlojiKlienti":
					strSql = "SELECT COUNT(ID_IDENTIFIKIMI) AS NUMRI FROM IDENTIFIKIMI WHERE ID_LLOJI = " + varInt1;
					break;
				case "KontrolloKategoriDhome":
					strSql = "SELECT COUNT(ID_DHOMA) AS NUMRI FROM DHOMA_KATEGORIA WHERE ID_KATEGORIA = " + varInt1;
					break;
				case "NxirCmimetDhoma" :
					strSql = "SELECT DATA_FILLIMI, DATA_MBARIMI, CMIMI FROM CMIMI WHERE ID_CMIMI IN ( SELECT ID_CMIMI FROM DHOMA_CMIMI WHERE ID_DHOMA = " + varInt1 + ")" ;
					break;
				case "KontrolloDhomaRezervuar" :
					strSql = "SELECT ID_DHOMA FROM DHOMA_REZERVIMI WHERE ID_DHOMA = " + varInt1;
					break;
				case "KontrolloKlient" :
					strSql = "SELECT ID_KLIENTI FROM KLIENTI WHERE ID_KLIENTI = " + varInt1 + " AND ( '" + System.DateTime.Today.ToShortDateString() + "' BETWEEN DATA_HYRJE AND DATA_DALJE) ";
					break;
				case "ShfaqRezervimGrupi" :
					strSql = "SELECT ID_REZERVIMI, DATA_FILLIMI, DATA_MBARIMI,DATA_REZERVIMI,DATA_KAPARI, KAPARI, G.EMRI, AGJENSIA " +
						"FROM REZERVIM AS R INNER JOIN GRUPI AS G ON R.ID_GRUPI = G.ID_GRUPI " + 
						"WHERE R.ID_GRUPI = " + varInt1 ;
					break;
				case "KontrolloGrupHotel" :
					strSql = "SELECT K.ID_KLIENTI FROM GRUPI AS G INNER JOIN GRUP_KLIENTI AS GK ON G.ID_GRUPI = GK.ID_KLIENTI " +
						"INNER JOIN KLIENTI AS K ON GK.ID_KLIENTI = K.ID_KLIENTI " +
						"WHERE G.ID_GRUPI = " + varInt1 ;
					break;
				case "ShlyerjeDhomaKlienti" :
					strSql = "SELECT DATA_HYRJE, DATA_DALJE, KAPARI, DHOMA_EMRI, CMIMI " +
						"FROM KLIENTI AS K INNER JOIN DHOMAT_CMIMET AS DC ON K.ID_DHOMA = DC.ID_DHOMA " +
						"WHERE ID_KLIENTI = " + varInt1 + " AND (DATA_HYRJE >= DC.DATA_FILLIMI AND DATA_HYRJE < DC.DATA_MBARIMI)";
					break;
				case "NxirrKategoria" :
					strSql = "SELECT KAT_EMRI FROM KATEGORIA WHERE ID_KATEGORIA = " + varInt1 ;
					break;
				case "ShfaqGrupinPerId":
					strSql = "SELECT EMRI, AGJENSIA, EMAILI FROM GRUPI WHERE ID_GRUPI = " + varInt1;
					break;
				case "NxirrIdentifikimi" :
					strSql = "SELECT ID_LLOJI, NR_IDENTIFIKIMI FROM IDENTIFIKIMI WHERE ID_IDENTIFIKIMI = " + varInt1 ;
					break;
				case "ShfaqDetyrimePerKlientinPerDhomen" :
					strSql = "SELECT EMRI, MBIEMRI, DATA_HYRJE, DATA_DALJE, KAPARI, K.ID_DHOMA, DHOMA_EMRI, CMIMI " +
						"FROM KLIENTI AS K INNER JOIN DHOMAT_CMIMET AS D ON K.ID_DHOMA = D.ID_DHOMA " +
						"WHERE ID_KLIENTI = " + varInt1 + " AND (DATA_HYRJE BETWEEN DATA_FILLIMI AND DATA_MBARIMI)  ";
					break;
				case "ShfaqDetyrimeEkstraPerKlientin" :
					strSql = "SELECT EMRI, MBIEMRI, EMER_LLOJI, CMIMI, SASIA, DATA, DATA_HYRJE, DATA_DALJE, K.ID_KLIENTI, DHOMA_EMRI, ID_REZERVIMI " +
						"FROM KLIENTI AS K inner JOIN DETYRIMET AS D ON K.ID_KLIENTI = D.ID_KLIENTI " +
						" inner JOIN LLOJET_DETYRIMI AS LD ON LD.ID_LLOJDETYRIMI = D.ID_LLOJDETYRIMI " +
						" INNER JOIN DHOMA AS DH ON DH.ID_DHOMA = K.ID_DHOMA"+
						" WHERE K.ID_KLIENTI = " + varInt1  ;
					break;
				
				case "ShfaqKlientPaDetyrime" :
					strSql = "SELECT EMRI, MBIEMRI, DATA_HYRJE, DATA_DALJE, ID_KLIENTI, DHOMA_EMRI, ID_REZERVIMI " +
						" FROM KLIENTI INNER JOIN DHOMA ON DHOMA.ID_DHOMA = KLIENTI.ID_DHOMA"  +
						" WHERE ID_KLIENTI = " + varInt1  ;
					break;
				case "ShfaqKlientetPerGrupin" :
					strSql = "SELECT K.ID_KLIENTI, EMRI, MBIEMRI FROM KLIENTI AS K " +
						"INNER JOIN GRUP_KLIENTI AS GK ON K.ID_KLIENTI = GK.ID_KLIENTI " +
						"WHERE GK.ID_GRUPI = " + varInt1 + " AND KLIENT_HOTELI = 1 " ;
					break;
				case "ShfaqKlientetGrupi" :
					strSql = "SELECT ID_KLIENTI FROM GRUP_KLIENTI WHERE ID_GRUPI = " + varInt1  ;
					break;
				case "ShfaqRezervimDhomaGrupi" :
					strSql = "SELECT R.ID_DHOMA,R.ID_KATEGORIA,R.DHOMA_EMRI,R.KAT_EMRI,DHC.CMIMI FROM DHOMAT_REZERVIMET AS R " +
						"INNER JOIN GRUPI AS G ON R.ID_GRUPI=G.ID_GRUPI " +
						" INNER JOIN DHOMAT_CMIMET AS DHC ON DHC.ID_DHOMA = R.ID_DHOMA WHERE (DATEDIFF(DAY, R.DATA_FILLIMI, DHC.DATA_FILLIMI) <= 0) AND (DATEDIFF(DAY, R.DATA_MBARIMI, DHC.DATA_MBARIMI) >= 0) " +
						" AND R.ID_REZERVIMI = " + varInt1 ;
					break;
				case "ShfaqTeDhenatPerPerdorues":
					strSql = "SELECT U.*, R.PERSHKRIMI FROM USERS AS U INNER JOIN ROLET AS R ON U.ROL_ID " +
						" = R.ROL_ID WHERE U.USER_ID = " + varInt1;
					break;
				case "FshiPerdorues":
					strSql = "DELETE FROM USERS WHERE USER_ID = " + varInt1;
					break;
				case "ShfaqKlientDhomeData" :
					strSql = "SELECT DATA_HYRJE,DATA_DALJE FROM KLIENTI  WHERE ID_DHOMA = " + varInt1 + "  ORDER BY DATA_HYRJE"; 
					break;
				case "ShfaqDhomaTeRezervuara":
					strSql = "SELECT COUNT(ID_DHOMA) FROM DHOMA_REZERVIMI WHERE ID_REZERVIMI = " + varInt1 ;
					break;
				case "ShfaqDorezimiDhoma" :
					strSql = "SELECT MIN(DATA_HYRJE) AS DATA_MARRJE , MAX(DATA_DALJE) AS DATA_DOREZIM FROM KLIENTI WHERE ID_DHOMA = " + varInt1 + " AND KLIENT_HOTELI = 1 ";
					break;
				case "ShfaqEmriDhoma" :
					strSql = "SELECT DHOMA_EMRI FROM DHOMA WHERE ID_DHOMA = " + varInt1 ;
					break;
				case "NxirrNgaDhoma" :
					strSql = "UPDATE KLIENTI SET KLIENT_HOTELI = 0 WHERE ID_KLIENTI = " + varInt1 ;
					break;	
				case "NrShpenzimeshTeLojit" :
					strSql = "SELECT COUNT(ID_SHPENZIMI) FROM SHPENZIMI AS S INNER JOIN LLOJE_SHPENZIMI AS LS"+
						" ON S.ID_LLOJSHPENZIMI = LS.ID_LLOJSHPENZIMI WHERE S.ID_LLOJSHPENZIMI = " + varInt1;
					break;
				case "FshiLlojShpenzimi" :
					strSql = "DELETE FROM LLOJE_SHPENZIMI WHERE ID_LLOJSHPENZIMI = " + varInt1 ;
					break;
				case "ShfaqShpenzimetPerLlojinEdhene" :
					strSql = "SELECT S.ID_SHPENZIMI,S.ID_LLOJSHPENZIMI, LS.EMRI, S.DATA, S.SASIA, S.KOMENT " +
						" FROM SHPENZIMI AS S INNER JOIN LLOJE_SHPENZIMI AS LS ON S.ID_LLOJSHPENZIMI = LS.ID_LLOJSHPENZIMI" + 
						" WHERE S.ID_LLOJSHPENZIMI = " + varInt1 + " ORDER BY S.DATA";
					break;
				case "ShfaqTeDhenaFormaPagesa" :
					strSql = "SELECT * FROM FORMA_PAGESA WHERE ID_FORMAPAGESA = " + varInt1;
					break;
				case "NrVeprimeshNeArkePerFormePagese" :
					strSql = "SELECT COUNT(ID_ARKA) FROM ARKA WHERE ID_FORMAPAGESA = " + varInt1;
					break;
				case "FshiFormePagese" :
					strSql = "DELETE FROM FORMA_PAGESA WHERE ID_FORMAPAGESA = " + varInt1;
					break;
				case "ShfaqFormePageseKaparDhome" :
					strSql = "SELECT A.ID_FORMAPAGESA, FP.EMRI FROM " +
						" ARKA AS A INNER JOIN FORMA_PAGESA AS FP ON A.ID_FORMAPAGESA = FP.ID_FORMAPAGESA " +
						" WHERE (ID_KLIENTI = " + varInt1 + ") AND ((A.KOMENT = 'Kapar dhome') OR (A.KOMENT = 'Kapar grupi')) ";
					break;
				case "ShfaqFormePagesePerRezervim" :
					strSql = "SELECT A.ID_FORMAPAGESA, FP.EMRI FROM " +
						" ARKA AS A INNER JOIN FORMA_PAGESA AS FP ON A.ID_FORMAPAGESA = FP.ID_FORMAPAGESA " +
						" WHERE (ID_REZERVIMI = " + varInt1 + ") AND (A.KOMENT = 'Kapar rezervimi') ";
					break;
				case "FshiKaparRezervimiNgaArka" :
					strSql = "DELETE FROM ARKA WHERE ID_REZERVIMI = " + varInt1 + " AND KOMENT = 'Kapar rezervimi'";
					break;
				default :
					strSql = "";
					break;
			}  
			return strSql;
			
		}

		public string GetQuery(string kerkesaQuery, string varString1, int varInt1, int varInt2)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			switch (kerkesaQuery)
			{
				case "KrijoDetyrimi":
					strSql = "INSERT INTO DETYRIMI(LLOJI_DETYRIMI, CMIMI, SASIA) VALUES (" + varString1 + ", " + varInt1 + ", " + varInt2 + ")";
					break;
				case "KrijoDhome":
					strSql = "INSERT INTO DHOMA(DHOMA_EMRI, ID_KATEGORIA, DHOMA_GJENDJA, NR_KREVATESH) VALUES (" + varString1 + ", " + varInt1 + ", 0, " + varInt2 + ")";
					break;
				case "ModifikoLlojDetyrimi":
					strSql = "UPDATE LLOJET_DETYRIMI SET EMER_LLOJI = '" + varString1 + "', CMIMI = " + varInt1 + " WHERE ID_LLOJDETYRIMI = " + varInt2 ;
					break;
				case "ModifikoIdentifikimi" :
					strSql = "UPDATE IDENTIFIKIMI SET ID_LLOJI = " + varInt2 + ", NR_IDENTIFIKIMI = '" + varString1 + "' WHERE ID_IDENTIFIKIMI = " + varInt1 ;
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}

		public string GetQuery (string kerkesaQuery, DateTime data)
		{
			string strSql = "";
			switch (kerkesaQuery)
			{
				case "GjendjaDitoreDuhur":
					strSql = "SELECT ARKA_DATA, ARKA_SASIA FROM ARKA WHERE (ARKA_DATA = " + data + ")";
					break;
				case "NxirrShpenzim":
					strSql = "SELECT DATA, SASIA FROM SHPENZIMI WHERE (DATA = " + data + ")";
					break;
				case "ShfaqRezervimetPerKlientPerDatenEdhene":
					strSql = "SELECT R.ID_REZERVIMI,R.DATA_REZERVIMI, R.DATA_FILLIMI, R.DATA_MBARIMI,R.DATA_KAPARI, R.KAPARI, R.EMRI, R.MBIEMRI, DK.ID_DHOMA, DK.DHOMA_EMRI, DK.KAT_EMRI ,DK.ID_KATEGORIA, R.EMAILI " + 
						"FROM REZERVIM AS R INNER JOIN DHOMA_REZERVIMI AS DR ON R.ID_REZERVIMI = DR.ID_REZERVIMI " +
						"INNER JOIN DHOMA_KATEGORIA AS DK ON DR.ID_DHOMA = DK.ID_DHOMA " +
						"WHERE (R.ID_GRUPI IS NULL) AND (R.DATA_FILLIMI >= '" + data.ToShortDateString() + "') ORDER BY R.DATA_FILLIMI";
					break;
				case "ShfaqRezervimetVlefshmePerDatenEdhene":
					strSql = "SELECT * FROM REZERVIME_VLEFSHME WHERE '" + data.ToShortDateString() + "' BETWEEN DATA_FILLIMI AND DATA_MBARIMI  ";
					break;
				case "ShfaqRezervimetPerGrupPerDatenEdhene":
					strSql = "SELECT DISTINCT R.ID_REZERVIMI, R.DATA_REZERVIMI , R.DATA_FILLIMI, R.DATA_MBARIMI, R.KAPARI,R.DATA_KAPARI,R.ID_GRUPI, G.EMRI, G.AGJENSIA " + 
						"FROM dHOMAT_REZERVIMET  AS R  INNER JOIN GRUPI AS G ON R.ID_GRUPI = G.ID_GRUPI " +
						"WHERE R.DATA_FILLIMI >= '" + data.ToShortDateString() + "' ";
					break;
				case "ShfaqRezervimetPerGrupDhomePerDatenEdhene":
					strSql = "SELECT R.ID_REZERVIMI, R.DATA_REZERVIMI , R.DATA_FILLIMI, R.DATA_MBARIMI, R.KAPARI,R.ID_GRUPI, G.EMRI, G.AGJENSIA,DR.ID_DHOMA, DR.DHOMA_EMRI, DR.KAT_EMRI,DR.ID_KATEGORIA " + 
						"FROM REZERVIM AS R INNER JOIN DHOMAT_REZERVIMET AS DR ON R.ID_REZERVIMI = DR.ID_REZERVIMI " +
						"INNER JOIN GRUPI AS G ON R.ID_GRUPI = G.ID_GRUPI " +
						"WHERE (R.ID_GRUPI IS NOT NULL) AND (R.DATA_FILLIMI >= '" + data.ToShortDateString() + "') ORDER BY R.DATA_FILLIMI";
					break;
				case "ShfaqShpenzimetPerDatenEdhene":
					strSql = "SELECT S.ID_SHPENZIMI,S.ID_LLOJSHPENZIMI, LS.EMRI, S.DATA, S.SASIA, S.KOMENT " +
						" FROM SHPENZIMI AS S INNER JOIN LLOJE_SHPENZIMI AS LS ON S.ID_LLOJSHPENZIMI = LS.ID_LLOJSHPENZIMI" + 
						" WHERE (DATA='" + data.ToShortDateString() + "') ORDER BY LS.EMRI";
					break;
				case "ShfaqBilanciPerDatenEdhene" :
					strSql = "SELECT SUM(SASIA) AS BILANCI FROM ARKA WHERE DATA = '" + data + "'";
					break;
				case "ShfaqCmimetEdhomavePerDatenEdhene" :
					strSql = "SELECT D.ID_KATEGORIA,D.ID_DHOMA, D.DHOMA_EMRI, D.KAT_EMRI , C.DATA_FILLIMI,C.DATA_MBARIMI,C.CMIMI,C.ID_CMIMI FROM DHOMA_KATEGORIA AS D INNER JOIN DHOMA_CMIMI AS DC " +
						"ON D.ID_DHOMA = DC.ID_DHOMA INNER JOIN CMIMI AS C ON DC.ID_CMIMI = C.ID_CMIMI " +
						"WHERE (  '" + data.ToShortDateString() + "'BETWEEN C.DATA_FILLIMI AND C.DATA_MBARIMI) ORDER BY D.DHOMA_EMRI ";
					break;
				case "FshiArka" :
					strSql = "DELETE FROM ARKA WHERE ARKA_DATA <= '" + data.ToShortDateString() +"'";
					break;
				case "ShumaArka" :
					data = data.AddDays(1);
					strSql = "SELECT SUM(ARKA_SASIA) AS SHUMA FROM ARKA WHERE ARKA_DATA < '" + data.ToShortDateString() + "'";
					break;
				case "ShumaArkaData" :
					strSql = "SELECT SUM(ARKA_SASIA) AS SHUMA FROM ARKA WHERE ARKA_DATA LIKE '" + data.ToShortDateString() + "'";
					break;
				case "ShumaShpenzimi" :
					strSql = "SELECT SUM(SASIA) AS SHUMA FROM SHPENZIMI WHERE DATA <= '" + data.ToShortDateString() + "'";
					break;
				case "ShumaShpenzimeData" :
					strSql = "SELECT SUM(SASIA) AS SHUMA FROM SHPENZIMI WHERE DATA LIKE '" + data.ToShortDateString() + "'";
					break;
				case "ShumaKapariKlienti" :
					strSql = "SELECT SUM(SASIA) AS SHUMA FROM KLIENTI WHERE DATA_HYRJE <= '" + data.ToShortDateString() + "' AND DATA_DALJE > '" + data.ToShortDateString() + "'";
					break;
				case "ShfaqArkenPerDaten" :
					//					strSql = "SELECT ARKA_SASIA, KOMENT, A.ID_KLIENTI, A.ID_DETYRIMI, A.ID_REZERVIMI," 
					//						+ " K.EMRI, K.MBIEMRI,R.EMRI AS EMRI_REZERVIMI, R.MBIEMRI AS MBIEMRI_REZERVIMI, R.ID_GRUPI " 
					//						+ " FROM ARKA AS A LEFT JOIN KLIENTI AS K ON (A.ID_KLIENTI = K.ID_KLIENTI)"
					//						+ " LEFT JOIN REZERVIM AS R ON (R.ID_REZERVIMI = A.ID_REZERVIMI) "
					//						+ " WHERE DAY(ARKA_DATA) =  DAY( '" + data.ToShortDateString()+ "')"
					//						+ " AND MONTH(arka_data) = MONTH('" + data.ToShortDateString() + "')"
					//						+ " AND YEAR(arka_data) = YEAR('" + data.ToShortDateString() +"') ORDER BY A.ID_KLIENTI";
					strSql = "SELECT ARKA_SASIA, KOMENT, A.EMER_REZ, A.ID_DETYRIMI, A.ID_REZERVIMI," 
						+ " A.ID_KLIENTI, K.EMRI, K.MBIEMRI, A.ID_GRUPI, G.EMRI AS GRUPI, G.AGJENSIA, FP.EMRI AS PAGESA, FP.PERQINDJA, U.USER_NAME, A.EMER_PERDORUES " 
						+ " FROM ARKA AS A LEFT JOIN KLIENTI AS K ON (A.ID_KLIENTI = K.ID_KLIENTI)"
						+ " LEFT JOIN GRUPI AS G ON (G.ID_GRUPI = A.ID_GRUPI) "
						+ " INNER JOIN FORMA_PAGESA AS FP ON FP.ID_FORMAPAGESA = A.ID_FORMAPAGESA " 
						+ " LEFT JOIN USERS AS U ON U.USER_ID = A.USER_ID "
						+ " WHERE DAY(ARKA_DATA) =  DAY( '" + data.ToShortDateString()+ "')"
						+ " AND MONTH(arka_data) = MONTH('" + data.ToShortDateString() + "')"
						+ " AND YEAR(arka_data) = YEAR('" + data.ToShortDateString() +"') ORDER BY A.ID_KLIENTI";
					break;
				
				case "ShfaqArkaFormaPagesa" :
					strSql = "SELECT SUM(A.ARKA_SASIA) AS SHUMA, A.ID_FORMAPAGESA, FP.EMRI, FP.PERQINDJA" + 
						" FROM ARKA AS A LEFT JOIN FORMA_PAGESA AS FP ON A.ID_FORMAPAGESA = FP.ID_FORMAPAGESA " + 
						" WHERE ARKA_DATA = '" + data.ToShortDateString() + " '" + 
						" GROUP BY A.ID_FORMAPAGESA, FP.EMRI,FP.PERQINDJA " +
						" ORDER BY A.ID_FORMAPAGESA";					
					break;
				case "ShfaqShpenzimetPerDaten" :
					strSql = "SELECT S.SASIA, S.KOMENT,LS.EMRI, U.USER_NAME, S.EMER_PERDORUES  FROM SHPENZIMI" + 
							" AS S INNER JOIN LLOJE_SHPENZIMI AS LS ON S.ID_LLOJSHPENZIMI = LS.ID_LLOJSHPENZIMI " +
							" LEFT JOIN USERS AS U ON U.USER_ID = S.USER_ID "+
							" WHERE DATA = '" + data.ToShortDateString() + "'";
					break;
				case "FshiShpenzimeDeriNeDatenEDhene" :
					strSql = "DELETE FROM SHPENZIMI WHERE DATA <= '" + data.ToShortDateString() + "'";
					break;
				case "ShfaqRezervimetVlefshmeKlientiPerDatenEdhene":
					//strSql = "SELECT DATA_FILLIMI,DATA_MBARIMI,KAPARI,EMRI,MBIEMRI,DATA_REZERVIMI,DHOMA_EMRI FROM REZERVIME_VLEFSHME WHERE '" + data.ToShortDateString() + "' BETWEEN DATA_FILLIMI AND DATA_MBARIMI AND ID_GRUPI IS NULL ";
					strSql = "SELECT DATA_FILLIMI,DATA_MBARIMI,KAPARI,EMRI,MBIEMRI,DATA_REZERVIMI,DHOMA_EMRI " +
						" FROM REZERVIME_VLEFSHME WHERE " +
						" DATA_MBARIMI >  '" + data.ToString("yyyy-MM-dd") + "' " +
						" AND ID_GRUPI IS NULL ";
					break;					
				case "ShfaqRezervimeVlefshmeGrupiPerDatenEdhene":
					//strSql = "SELECT DATA_FILLIMI,DATA_MBARIMI, KAPARI,DATA_REZERVIMI,GRUPI,AGJENSIA,DHOMA_EMRI,ID_REZERVIMI FROM REZERVIME_VLEFSHME WHERE '" + data.ToShortDateString() + "' BETWEEN DATA_FILLIMI AND DATA_MBARIMI AND ID_GRUPI IS NOT NULL ";
					strSql = "SELECT DATA_FILLIMI,DATA_MBARIMI, KAPARI,DATA_REZERVIMI,GRUPI, " +
						" AGJENSIA,DHOMA_EMRI,ID_REZERVIMI FROM REZERVIME_VLEFSHME " +
						" WHERE DATA_MBARIMI > '" + data.ToString("yyyy-MM-dd") + "' " +
						" AND ID_GRUPI IS NOT NULL";
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}
		public string GetQuery (string kerkesaQuery, int varInt1, DateTime varDate1)
		{
			string strSql = "";
			switch (kerkesaQuery)
			{
				case "NxirrDhome" :
					strSql = "SELECT ID_DHOMA ,DHOMA_EMRI, KAT_EMRI, NR_KREVATESH,DHOMA_CIFT, "+
						" ID_KATEGORIA, CMIMI FROM DHOMAT_CMIMET WHERE ID_DHOMA = " + varInt1 + " AND '" + this.formatoDatenGjate(varDate1) + "' BETWEEN DATA_FILLIMI AND DATA_MBARIMI ";
					break;
				case "ShfaqRezervimDhomaGrupiPerDaten":
					strSql = "SELECT R.ID_DHOMA,R.ID_KATEGORIA,R.DHOMA_EMRI,R.KAT_EMRI,DHC.CMIMI  FROM DHOMAT_REZERVIMET AS R " +
						"INNER JOIN GRUPI AS G ON R.ID_GRUPI=G.ID_GRUPI " +
						" INNER JOIN DHOMAT_CMIMET AS DHC ON DHC.ID_DHOMA = R.ID_DHOMA " +
						"WHERE R.ID_REZERVIMI = " + varInt1 + " AND '" + this.formatoDatenGjate(varDate1) + "' BETWEEN DHC.DATA_FILLIMI AND DHC.DATA_MBARIMI" ;
					break;
				case "NumerKlienteshPerDateDhoma":
					strSql = "SELECT COUNT(ID_KLIENTI) AS NR FROM KLIENTI WHERE (ID_DHOMA = " + varInt1 + 
						") AND ('" + this.formatoDatenGjate(varDate1) + "' BETWEEN DATA_HYRJE AND DATA_DALJE) "+
						" AND (NOT DATA_DALJE = '" + this.formatoDatenGjate(varDate1) + "')";
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}
		public string GetQuery (string kerkesaQuery, int varInt1, DateTime data, int varInt2, string varString)
		{
			string strSql = "";
			varString = varString.Replace("'", "''");
			switch (kerkesaQuery)
			{
				case "ModifikoShpenzim" :
					strSql = "UPDATE SHPENZIMI SET DATA = '" + data.ToShortDateString() + "' , SASIA = " + varInt2 + " , KOMENT = '" + varString + "' WHERE ID_SHPENZIMI = " + varInt1 ;
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}
		public string GetQuery (string kerkesaQuery, int varInt1, DateTime data, int varInt2,
			string varString, int varInt3)
		{
			string strSql = "";
			varString = varString.Replace("'", "''");
			switch (kerkesaQuery)
			{
				case "KrijoShpenzim" :
					strSql = "INSERT INTO SHPENZIMI(ID_LLOJSHPENZIMI, DATA, SASIA, KOMENT, USER_ID) VALUES " +
							" (" + varInt1 + ",'" + data.ToShortDateString() + "', " + varInt2 + ", '" + varString + "', " + varInt3 + ")";
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}

		public string GetQuery (string kerkesaQuery, int varInt1,int varInt2,
			DateTime data, int varInt3, string varString, int varInt4)
		{
			string strSql = "";
			varString = varString.Replace("'", "''");
			switch (kerkesaQuery)
			{
				case "ModifikoShpenzim" :
					strSql = "UPDATE SHPENZIMI SET ID_LLOJSHPENZIMI = " + varInt2 + ", DATA = '" +
						data.ToShortDateString() + "' , SASIA = " + varInt3 + " , KOMENT = '" + varString + "', USER_ID = " + varInt4 + 
						" WHERE ID_SHPENZIMI = " + varInt1 ;
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}
		public string GetQuery (string kerkesaQuery, int varInt1, string varString1,
			string varString2, DateTime varDate1, string varString3, string varString4,
			string varString5, string varString6, DateTime varDate2,
			DateTime varDate3, int varInt2, int varInt3, int varInt4,int varInt5,int varInt6,DateTime varDate4)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");
			varString3 = varString3.Replace("'", "''");
			varString4 = varString4.Replace("'", "''");
			varString5 = varString5.Replace("'", "''");
			varString6 = varString6.Replace("'", "''");
			switch (kerkesaQuery)
			{
				case "ModifikoKlienti":
					strSql = "UPDATE KLIENTI SET EMRI = '" + varString1 + "', MBIEMRI = '" + varString2 + "',DATELINDJA = '"
						+ varDate1.ToShortDateString() + "', ADRESA = ' " + varString3 + "', TELEFONI = '" + varString4 + "', EMAIL = '" +
						varString5 + "', TARGA = '" + varString6 + "', DATA_HYRJE = '" + this.formatoDatenGjate(varDate2) + "', DATA_DALJE = '"
						+ this.formatoDatenGjate(varDate3) + "', KAPARI = " + varInt2 + ", ID_IDENTIFIKIMI = " + varInt3 + ", ID_DHOMA = " + varInt4 + " ,SKONTO = " + varInt5 + ",GJOBA = " + varInt6 + ",DATA_KAPARI ='"+this.formatoDatenShumeGjate(varDate4)+"' WHERE ID_KLIENTI = " + varInt1 ;
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}

		public string GetQuery (string kerkesaQuery, int varInt1, string varString1,
			string varString2, DateTime varDate1, string varString3, string varString4,
			string varString5, string varString6, DateTime varDate2,
			DateTime varDate3, int varInt2, int varInt3, int varInt4,DateTime varDate4)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");
			varString3 = varString3.Replace("'", "''");
			varString4 = varString4.Replace("'", "''");
			varString5 = varString5.Replace("'", "''");
			varString6 = varString6.Replace("'", "''");
			switch (kerkesaQuery)
			{
				case "ModifikoKlientiPaPagese":
					strSql = "UPDATE KLIENTI SET EMRI = '" + varString1 + "', MBIEMRI = '" + varString2 + "',DATELINDJA = '"
						+ varDate1.ToShortDateString() + "', ADRESA = ' " + varString3 + "', TELEFONI = '" + varString4 + "', EMAIL = '" +
						varString5 + "', TARGA = '" + varString6 + "', DATA_HYRJE = '" + this.formatoDatenGjate(varDate2) + "', DATA_DALJE = '"
						+ this.formatoDatenGjate(varDate3) + "', KAPARI = " + varInt2 + ", ID_IDENTIFIKIMI = " + varInt3 + ", ID_DHOMA = " + varInt4 + " ,DATA_KAPARI ='"+this.formatoDatenShumeGjate(varDate4)+"' WHERE ID_KLIENTI = " + varInt1 ;
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}
		public string GetQuery (string kerkesaQuery, int varInt1, string varString1,string varString2, 
			DateTime varDate1, DateTime varDate2, int varInt2)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");

			switch (kerkesaQuery)
			{
				case "ShfaqVeprimetPerKlientinDheDhomen":
					if (varInt2 >= 0)
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE (( DATA_HYRJE >= '" + varDate1.ToShortDateString() + "' AND DATA_HYRJE <'" + varDate2.ToShortDateString() + "') OR ( DATA_DALJE > '" + varDate1.ToShortDateString() + "' AND DATA_DALJE <= '" + varDate2.ToShortDateString() + " ') OR (DATA_HYRJE < '" + varDate1.ToShortDateString() + "' AND DATA_DALJE > '" + varDate2.ToShortDateString() + "' ))  "+
							" AND (ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ))" +
							" AND (ID_DHOMA = " + varInt1 + ") " + 
							"  AND ( EMRI LIKE '" + varString1 + "%' AND MBIEMRI LIKE '" + varString2 + "%')  " +
							" AND (KLIENT_HOTELI = " + varInt2 + ") "+
							" ORDER BY DHOMA_EMRI, DATA_HYRJE";		
					}
					else
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE (( DATA_HYRJE >= '" + varDate1.ToShortDateString() + "' AND DATA_HYRJE <'" + varDate2.ToShortDateString() + "') OR ( DATA_DALJE > '" + varDate1.ToShortDateString() + "' AND DATA_DALJE <= '" + varDate2.ToShortDateString() + " ') OR (DATA_HYRJE < '" + varDate1.ToShortDateString() + "' AND DATA_DALJE > '" + varDate2.ToShortDateString() + "' ))  "+
							" AND (ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ))" +
							" AND (ID_DHOMA = " + varInt1 + ") " + 
							"  AND ( EMRI LIKE '" + varString1 + "%' AND MBIEMRI LIKE '" + varString2 + "%')  " +
							" ORDER BY DHOMA_EMRI, DATA_HYRJE";
					}
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}
		public string GetQuery(string kerkesaQuery, string varString1, string varString2, string varString3,
			string varString4, int varInt1)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");
			varString3 = varString3.Replace("'", "''");
			varString4 = varString4.Replace("'", "''");
			switch (kerkesaQuery)
			{
				case "ShtoPerdorues":
					strSql = "INSERT INTO USERS(EMRI, MBIEMRI, USER_NAME, PASSWORD, ROL_ID) VALUES ('" + 
						varString1 + "', '" + varString2 + "', '" + varString3 + "', '" + varString4 + "', " +
						varInt1 + ")";
					break;
			}
			return strSql;
		}
        
		public string GetQuery( string kerkesaQuery,  string varString1 ,string varString2, int varInt1)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");

			switch (kerkesaQuery)
			{
				case "KrijoDetyrimi":
					strSql = "INSERT INTO DETYRIMI(ID_DETYRIMI, LLOJI, SASIA) VALUES ('" + varString1 + "', '" + varString2 + "', " + varInt1 + ")";
					break;
				case "ShfaqVeprimetPerKlientin" :
					if (varInt1 >= 0)
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"  WHERE ( EMRI LIKE '" + varString1 + "%' AND MBIEMRI LIKE '" + varString2 + "%')  " +
							" AND ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) AND (KLIENT_HOTELI = " + varInt1 + ") ORDER BY DHOMA_EMRI, DATA_HYRJE ";					}
					else
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"  WHERE ( EMRI LIKE '" + varString1 + "%' AND MBIEMRI LIKE '" + varString2 + "%')  " +
							" AND ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) ORDER BY DHOMA_EMRI, DATA_HYRJE ";
					}
					break;
				case "ModifikoFormePagese":
					strSql = "UPDATE FORMA_PAGESA SET EMRI = '" + varString1 + "', PERQINDJA = " + varString2 + " WHERE ID_FORMAPAGESA = " + varInt1;
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}

		public string GetQuery( string kerkesaQuery, int varInt1, string varString1, int varInt2, int varInt3,
			int varInt4)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			switch(kerkesaQuery)
			{

				case "ModifikoDhome" :
					strSql = "UPDATE DHOMA SET DHOMA_EMRI = '" + varString1 + "', ID_KATEGORIA = " + varInt3 + ",DHOMA_CIFT = '" + varInt2 + "', NR_KREVATESH = " + varInt4 + " WHERE ID_DHOMA = " + varInt1 ;
					break;
				default:
					strSql = "" ;
					break;
			}
			return strSql;
		}
        
		public string GetQuery( string kerkesaQuery,  string varString1 ,string varString2, int varInt1, 
			DateTime varDate1, DateTime varDate2, DateTime varDate3, string varString3)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");
			varString3 = varString3.Replace("'", "''");

			switch (kerkesaQuery)
			{
				case "KrijoRezervimKlienti" :
					strSql = "INSERT INTO REZERVIM(EMRI, MBIEMRI, KAPARI, DATA_FILLIMI, DATA_MBARIMI, DATA_REZERVIMI, EMAILI) VALUES('" + varString1 + "', '" + varString2 + "', " + varInt1 + ", '" + this.formatoDatenGjate(varDate1) + "', '" + this.formatoDatenGjate(varDate2) + "', '" + this.formatoDatenGjate(varDate3) + "', '" + varString3+ "')";
					strSql += Environment.NewLine + " SELECT MAX(ID_REZERVIMI) FROM REZERVIM";
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}

		public string GetQuery( string kerkesaQuery, int varInt1, string varString1 ,string varString2, int varInt2,
			DateTime varDate1, DateTime varDate2, DateTime varDate3, DateTime varDate4, string varString3)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");
			varString3 = varString3.Replace("'", "''");

			switch (kerkesaQuery)
			{
				case "ModifikoRezervimKlienti" :
					strSql = "UPDATE REZERVIM SET EMRI = '" + varString1 + "', MBIEMRI = '" + varString2 + 
						"', KAPARI = " + varInt2 + ", DATA_FILLIMI = '" + this.formatoDatenGjate(varDate1) +
						"', DATA_MBARIMI = '" + this.formatoDatenGjate(varDate2) + "', DATA_REZERVIMI = '" + 
						this.formatoDatenGjate(varDate3) + "', EMAILI = '" + varString3 + "'" +
						"  WHERE ID_REZERVIMI = " + varInt1 ;
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}

		public string GetQuery( string kerkesaQuery, int varInt1, string varString1 ,string varString2, int varInt2,
			DateTime varDate1, DateTime varDate2, DateTime varDate3, DateTime varDate4)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");

			switch (kerkesaQuery)
			{
				case "ModifikoRezervimKlienti" :
					strSql = "UPDATE REZERVIM SET EMRI = '" + varString1 + "', MBIEMRI = '" + varString2 + "', KAPARI = " + varInt2 + ", DATA_FILLIMI = '" + this.formatoDatenGjate(varDate1) + "', DATA_MBARIMI = '" + this.formatoDatenGjate(varDate2) + "', DATA_REZERVIMI = '" + this.formatoDatenGjate(varDate3) + "',DATA_KAPARI='"+this.formatoDatenShumeGjate(varDate4)+"'  WHERE ID_REZERVIMI = " + varInt1 ;
					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}
		public string GetQuery( string kerkesaQuery, int varInt1, string varString1 ,string varString2, int varInt2, DateTime varDate1, DateTime varDate2, DateTime varDate3)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");

			switch (kerkesaQuery)
			{
				case "KrijoRezervimGrupi" :
					// varInt1 sherben si ID_GRUPI
					// varString1 sherben si emri i grupit
					// varString2 sherben si agjensia e grupit
					// varInt2 si kapari
					// varDate1 sherben si date fillimi
					// varDate2 si date mbarimi
					// varDate3 si data e rezervimit
					strSql = "INSERT INTO REZERVIM(ID_GRUPI,EMRI, MBIEMRI, KAPARI, DATA_FILLIMI, DATA_MBARIMI, DATA_REZERVIMI)" +
						" VALUES( " + varInt1 + ", '" + varString1 + "', '" + varString2 + "', "  + varInt2 + ", '" + this.formatoDatenGjate(varDate1) + "', '" + this.formatoDatenGjate(varDate2) + "', '" + this.formatoDatenGjate(varDate3) + "')";
					strSql += Environment.NewLine + "SELECT MAX(ID_REZERVIMI) FROM REZERVIM";

					break;
				default:
					strSql = "";
					break;
			}
			return strSql;
		}
		public string GetQuery(string kerkesaQuery, string varString1, string varString2, DateTime varDate1, DateTime varDate2)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");

			switch(kerkesaQuery)
			{
				case "ShfaqDetyrimKlientiPerEmerDheData":
					strSql = " SELECT KD.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE,EMER_LLOJI,DATA,SASIA,CMIMI,DHOMA_EMRI,KAT_EMRI,KD.ID_DETYRIMI "+
						" FROM "+
						" (SELECT K.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE ,DATA,SASIA,ID_LLOJDETYRIMI,ID_DHOMA,ID_DETYRIMI "+
						" FROM KLIENTI AS K"+
						" LEFT JOIN DETYRIMET AS D "+
						" ON K.ID_KLIENTI=D.ID_KLIENTI" +
						" WHERE KLIENT_HOTELI =0)AS KD "+
						" INNER JOIN LLOJET_DETYRIMI AS LD "+
						" ON LD.ID_LLOJDETYRIMI=KD.ID_LLOJDETYRIMI"+
						" LEFT JOIN DHOMA_KATEGORIA AS DK ON"+
						" DK.ID_DHOMA=KD.ID_DHOMA"+
						" WHERE (EMRI LIKE '" + varString1 + "%' AND  MBIEMRI LIKE '" + varString2 + "%') AND " + 
						" (DATA BETWEEN '" + varDate1.ToShortDateString() + "' AND '" + varDate2.ToShortDateString() + "') ORDER BY EMRI, MBIEMRI, ID_KLIENTI";
					break;
				case "ShfaqKlientetEDale":
					strSql = "SELECT * " +
						"FROM KLIENTI_GRUPI" + 
						" WHERE ( EMRI LIKE '" + varString1 + "%' AND MBIEMRI LIKE '" + varString2 + "%')" +
						" AND ((DATA_HYRJE > '" + varDate1.ToShortDateString() + "' AND DATA_HYRJE < '" + varDate2.ToShortDateString() +
						"') OR (DATA_DALJE > '" + varDate1.ToShortDateString() + "' AND DATA_DALJE < '" + varDate2.ToShortDateString() + 
						"')) AND (ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI))" + 
						" AND (KLIENT_HOTELI = 0)" +
						" ORDER BY DHOMA_EMRI, DATA_HYRJE, DATA_DALJE";
					break;
				case "ShfaqGrupetEDale":
					strSql = "SELECT * " +
						"FROM KLIENTI_GRUPI" + 
						" WHERE ( GRUPI LIKE '" + varString1 + "%' AND AGJENSIA LIKE '" + varString2 + "%')" +
						" AND ((DATA_HYRJE > '" + varDate1.ToShortDateString() + "' AND DATA_HYRJE < '" + varDate2.ToShortDateString() +
						"') OR (DATA_DALJE > '" + varDate1.ToShortDateString() + "' AND DATA_DALJE < '" + varDate2.ToShortDateString() + 
						"')) AND (ID_KLIENTI IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI))" + 
						" AND (KLIENT_HOTELI = 0)" +
						" ORDER BY GRUPI, DHOMA_EMRI, DATA_HYRJE, DATA_DALJE ";
					break;
				case "ShfaqKlientetSipasEmrit" :
					strSql = "SELECT * " +
						"FROM KLIENTI_GRUPI " + 
						"WHERE (( DATA_HYRJE >= '" + varDate1.ToShortDateString() + "' AND DATA_HYRJE < ='" + varDate2.ToShortDateString() + "') OR ( DATA_DALJE >= '" + varDate1.ToShortDateString() + "' AND DATA_DALJE <= '" + varDate2.ToShortDateString() + " '))"+
						"  AND ( EMRI LIKE '" + varString1 + "%' AND MBIEMRI LIKE '" + varString2 + "%')  " +
						" AND ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) ORDER BY DHOMA_EMRI, DATA_HYRJE ";
					break;
			}
			return strSql;
		}
		
		public string GetQuery(string kerkesaQuery, string varString1, string varString2, DateTime varDate1, DateTime varDate2, int varInt1)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");

			switch(kerkesaQuery)
			{
				case "ShfaqKlientetSipasEmrit" :
					if (varInt1 >= 0)
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE (( DATA_HYRJE >= '" + varDate1.ToShortDateString() + "' AND DATA_HYRJE <'" + varDate2.ToShortDateString() + "') OR ( DATA_DALJE > '" + varDate1.ToShortDateString() + "' AND DATA_DALJE <= '" + varDate2.ToShortDateString() + " ') OR (DATA_HYRJE < '" + varDate1.ToShortDateString() + "' AND DATA_DALJE > '" + varDate2.ToShortDateString() + "' ))  "+
							"  AND ( EMRI LIKE '" + varString1 + "%' AND MBIEMRI LIKE '" + varString2 + "%')  " +
							" AND ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) AND (KLIENT_HOTELI = " + varInt1 + ") ORDER BY DHOMA_EMRI, DATA_HYRJE ";
					}
					else
					{
						strSql = "SELECT * " +
							"FROM KLIENTI_GRUPI " + 
							"WHERE (( DATA_HYRJE >= '" + varDate1.ToShortDateString() + "' AND DATA_HYRJE <'" + varDate2.ToShortDateString() + "') OR ( DATA_DALJE > '" + varDate1.ToShortDateString() + "' AND DATA_DALJE <= '" + varDate2.ToShortDateString() + " ') OR (DATA_HYRJE < '" + varDate1.ToShortDateString() + "' AND DATA_DALJE > '" + varDate2.ToShortDateString() + "' ))  "+
							"  AND ( EMRI LIKE '" + varString1 + "%' AND MBIEMRI LIKE '" + varString2 + "%')  " +
							" AND ID_KLIENTI NOT IN (SELECT ID_KLIENTI FROM GRUP_KLIENTI ) ORDER BY DHOMA_EMRI, DATA_HYRJE ";
					}
					break;
			}
			return strSql;
		}
		public string GetQuery(string kerkesaQuery, DateTime varDate1, DateTime varDate2, int varInt1, string varString1, string varString2)
		{
			string strSql = "";
			varString1 = varString1.Replace("'", "''");
			varString2 = varString2.Replace("'", "''");

			switch(kerkesaQuery)
			{
				case "ShfaqDetyrimeKlientePerDataEmerKategori":
					strSql = " SELECT KD.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE,EMER_LLOJI,DATA,SASIA,CMIMI,DHOMA_EMRI,KAT_EMRI,KD.ID_DETYRIMI "+
						" FROM "+
						" (SELECT K.ID_KLIENTI,EMRI,MBIEMRI,DATA_HYRJE,DATA_DALJE ,DATA,SASIA,ID_LLOJDETYRIMI,ID_DHOMA,ID_DETYRIMI "+
						" FROM KLIENTI AS K"+
						" LEFT JOIN DETYRIMET AS D "+
						" ON K.ID_KLIENTI=D.ID_KLIENTI" +
						" WHERE KLIENT_HOTELI =0)AS KD "+
						" INNER JOIN LLOJET_DETYRIMI AS LD "+
						" ON LD.ID_LLOJDETYRIMI=KD.ID_LLOJDETYRIMI"+
						" LEFT JOIN DHOMA_KATEGORIA AS DK ON"+
						" DK.ID_DHOMA=KD.ID_DHOMA"+
						" WHERE (EMRI LIKE '" + varString1 + "%' AND  MBIEMRI LIKE '" + varString2 + "%') AND " + 
						" (DATA BETWEEN '" + varDate1.ToShortDateString() + "' AND '" + varDate2.ToShortDateString() + "') AND" +
						" (LD.ID_LLOJDETYRIMI = " + varInt1 + ")ORDER BY EMRI, MBIEMRI, ID_KLIENTI";
					break;
			}
			return strSql;
		}
		#endregion        

		#region Private Methods
		private string formatoDatenShumeGjate(DateTime data)
		{ 
			string strData = "";
			string dita = "";
			string muaji = "";
			string viti = "";
			string ora = "";
			string minutat = "";
			string sekondat = "";
			string milisekondat = "";

			dita = data.Day.ToString();
			if (dita.Length == 1)
				dita = "0" + dita;
            
			muaji = data.Month.ToString();
			if (muaji.Length == 1)
				muaji = "0" + muaji;

			viti = data.Year.ToString();

			ora = data.Hour.ToString();
			if (ora.Length == 1)
				ora = "0" + ora;
		    
			minutat = data.Minute.ToString();
			if (minutat.Length == 1)
				minutat = "0" + minutat;

			sekondat = data.Second.ToString();
			if (sekondat.Length == 1)
				sekondat = "0" + sekondat;

			milisekondat = data.Millisecond.ToString();
			if (milisekondat.Length == 1)
				milisekondat = "00" + milisekondat;
			else if(milisekondat.Length == 2)
				milisekondat = "0" + milisekondat;

			strData = viti + "-" + muaji + "-" + dita + " " + ora + ":" + minutat+":"+sekondat+":"+milisekondat;

			return strData;
    
		}
	
		private string formatoDatenGjate(DateTime data)
		{ 
			string strData = "";
			string dita = "";
			string muaji = "";
			string viti = "";
			string ora = "";
			string minutat = "";

			dita = data.Day.ToString();
			if (dita.Length == 1)
				dita = "0" + dita;
            
			muaji = data.Month.ToString();
			if (muaji.Length == 1)
				muaji = "0" + muaji;

			viti = data.Year.ToString();

			ora = data.Hour.ToString();
			if (ora.Length == 1)
				ora = "0" + ora;
		    
			minutat = data.Minute.ToString();
			if (minutat.Length == 1)
				minutat = "0" + minutat;

			strData = viti + "-" + muaji + "-" + dita + " " + ora + ":" + minutat;

			return strData;
    
		}

		private string formatoDatenShkurt(DateTime data)
		{ 
			string strData = "";
			string dita = "";
			string muaji = "";
			string viti = "";

			dita = data.Day.ToString();
			if (dita.Length == 1)
				dita = "0" + dita;
            
			muaji = data.Month.ToString();
			if (muaji.Length == 1)
				muaji = "0" + muaji;

			viti = data.Year.ToString();
			strData = viti + "-" + muaji + "-" + dita ;
			return strData;
		}

		#endregion
	}
}
