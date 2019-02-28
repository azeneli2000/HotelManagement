using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagment.BusDatService
{	/// <summary>
	/// 
	/// </summary>
	public class Arka
	{
	    
		private int sasiaLek = 0;
		private  DateTime data ;
		private string koment;
	
		#region constructors

		public Arka()
		{
			// 
			// TODO: Add constructor logic here
			//
		}
		public Arka(DateTime date, int sasiaLek, string komenti)
		{
			this.sasiaLek = sasiaLek;
			this.data = date;
			this.koment = komenti; 
		}

		public Arka(DateTime date)
		{
			this.data = date;
		}
		#endregion constructors
		
		#region Public Methods
		/// <summary>
		/// merr si paramater nje date dhe mbledh te gjtha hedhjet ne arke per ate date
		/// </summary>
		/// <param name="data"></param>
		/// <returns>int</returns>
		/// <summary>
		private int ShumaArkaData(DateTime data)
		{
			DataSet ds = null;
			string var = "dbShumaArkaData";
			int shumaArka = 0;
			DbController db = new DbController(); 
			ds = db.Read( var, data );
			DataRow dr=ds.Tables[0].Rows[0];
			if (Convert.IsDBNull(dr[0]))
			{
				shumaArka = 0;
			}
			else
			{
				shumaArka = Convert.ToInt32(dr[0]);
			}
			return shumaArka;

		}
		/// <summary>
		/// merr si paramater nje date dhe mbledh te gjtha hedhjet ne arke deri ne ate date
		/// </summary>
		/// <param name="data"></param>
		/// <returns>int</returns>
		/// <summary>
		private int ShumaArka(DateTime data)
		{
			DataSet ds = null;
			string var = "dbShumaArka";
			int shumaArka = 0;
			DbController db = new DbController(); 
			ds = db.Read( var, data );
			DataRow dr=ds.Tables[0].Rows[0];
			if (Convert.IsDBNull(dr[0]))
			{
				shumaArka = 0;
			}
			else
			{
				shumaArka = Convert.ToInt32(dr[0]);
			}
			return shumaArka;

		}
		/// <summary>
		/// merr si paramater nje date dhe mbledh te gjtha hedhjet ne arke midis datave
		/// pa perfshire daten e mbarimit
		/// </summary>
		/// <param name="dataFillimi"></param>
		/// <param name="dataMbarimi"></param>
		/// <returns>int</returns>
		/// <summary>
		private int ShumaArka(DateTime dataFillimi, DateTime dataMbarimi)
		{
			DataSet ds = null;
			string var = "dbShumaArkaMidisDatave";
			int shumaArka = 0;
			DbController db = new DbController(); 
			ds = db.Read( var, dataFillimi, dataMbarimi );
			DataRow dr=ds.Tables[0].Rows[0];
			if (Convert.IsDBNull(dr[0]))
			{
				shumaArka = 0;
			}
			else
			{
				shumaArka = Convert.ToInt32(dr[0]);
			}
			return shumaArka;

		}

		/// <summary>
		/// merr si paramater nje date dhe mbledh te gjtha hedhjet ne arke midis datave
		/// pa perfshire daten e mbarimit
		/// </summary>
		/// <param name="dataFillimi"></param>
		/// <param name="dataMbarimi"></param>
		/// <returns>int</returns>
		/// <summary>
		private DataSet ShumaArka(DateTime dataFillimi, DateTime dataMbarimi, DataSet dsPagesa, DataSet dsTmp)
		{	
			string var = "dbShumaArkaMidisDataveSipasFormesSePageses";
			DbController db = new DbController(); 
			DataSet dsArka = db.Read( var, dataFillimi, dataMbarimi );
			DataRow newrow = dsTmp.Tables[0].NewRow();
			double shuma = 0;
			foreach(DataRow drPagesa in dsPagesa.Tables[0].Rows)
			{
				bool ugjet = false;
				string pagesa = drPagesa["EMRI"].ToString();
				foreach(DataRow dr in dsArka.Tables[0].Rows)
				{
					if (pagesa == dr["EMRI"].ToString())
					{
						ugjet = true;
						double vlera = Convert.ToDouble(dr["SHUMA"]);
						double perqindja = 0.01 * Math.Round(Convert.ToDouble(drPagesa["PERQINDJA"]), 2);
						double komisioni = vlera * perqindja;
						double vleraMeKomision = Math.Round((vlera - komisioni), 2);
						shuma += vleraMeKomision;
						newrow[pagesa] = vleraMeKomision;
						break;
					}
				}
				if (!ugjet)
				{
					newrow[pagesa] = 0;
				}
			}
			newrow["TE_ARDHURA"] = Math.Round(shuma, 2);
			dsTmp.Tables[0].Rows.Add(newrow);
			dsTmp.AcceptChanges();
			return dsTmp;

		}
		/// <summary>
		/// merr si paramater nje date dhe mbledh te gjtha shpenzimet per ate date
		/// </summary>
		/// <param name="data"></param>
		/// <returns>int</returns>
		/// <summary>
		private int ShumaShpenzimeData(DateTime data)
		{
			DataSet ds = null;
			string var = "dbShumaShpenzimeData";
			int shumaShpenzime = 0;
			DbController db = new DbController(); 
			ds = db.Read( var, data );
			DataRow dr=ds.Tables[0].Rows[0];
			if (Convert.IsDBNull(dr[0]))
			{
				shumaShpenzime = 0;
			}
			else
			{
				shumaShpenzime = Convert.ToInt32(dr[0]);
			}
			return shumaShpenzime;
		}
		/// <summary>
		/// merr si paramater nje date dhe mbledh te gjtha shpenzimet deri ne ate date
		/// </summary>
		/// <param name="data"></param>
		/// <returns>int</returns>
		/// <summary>
		private int ShumaShpenzime(DateTime data)
		{
			DataSet ds = null;
			string var = "dbShumaShpenzime";
			int shumaShpenzime = 0;
			DbController db = new DbController(); 
			ds = db.Read( var, data );
			DataRow dr=ds.Tables[0].Rows[0];
			if (Convert.IsDBNull(dr[0]))
			{
				shumaShpenzime = 0;
			}
			else
			{
				shumaShpenzime = Convert.ToInt32(dr[0]);
			}
			return shumaShpenzime;
		}
		/// <summary>
		/// merr si paramater nje dateFillimi dhe nje dateMbarimi  dhe mbledh te gjtha shpenzimet 
		/// midis dy datave pa perfshire daten e mbatrimit
		/// <param name="dataFillimi"></param>
		/// <param name="dataMbarimi"></param>
		/// <returns>int</returns>
		/// <summary>
		private int ShumaShpenzime(DateTime dataFillimi, DateTime dataMbarimi)
		{
			DataSet ds = null;
			string var = "dbShumaShpenzimeMidisDatave";
			int shumaShpenzime = 0;
			DbController db = new DbController(); 
			ds = db.Read( var, dataFillimi, dataMbarimi );
			DataRow dr=ds.Tables[0].Rows[0];
			if (Convert.IsDBNull(dr[0]))
			{
				shumaShpenzime = 0;
			}
			else
			{
				shumaShpenzime = Convert.ToInt32(dr[0]);
			}
			return shumaShpenzime;
		}
		/// merr si paramater nje date dhe mbledh te gjtha hedhjet 
		/// </summary>
		/// <param name="data"></param>
		/// <returns>int</returns>
		public DataSet GjendjaReale(DateTime data)
		{	
			//			int shumaArka = this.ShumaArka(data);
			//			int shumaShpenzime = this.ShumaShpenzime(data);
			DbController db = new DbController();
			DataSet dsArka = db.Read("dbShfaqArkaFormaPagesa", data);
			dsArka.Tables[0].Columns.Add("MEKOMISION", typeof(Double));
			dsArka.AcceptChanges();
			int total = 0;
			double dTotal = 0;
			foreach(DataRow dr in dsArka.Tables[0].Rows)
			{
				if (Convert.ToInt32(dr["ID_FORMAPAGESA"]) == 1)
					//hedhje kesh
				{
					int vleraInt = Convert.ToInt32(dr["SHUMA"]);
					double vleraDouble = Convert.ToDouble(dr["SHUMA"]);
					total += vleraInt;
					dTotal += vleraDouble;
					dr["MEKOMISION"] = vleraDouble;
				}
				else
					//hedhje te tjera
				{
					double perqindja = Convert.ToDouble(dr["PERQINDJA"]);
					double dPerqindja = 0.01 * Math.Round(perqindja , 2);
					double vlera = Convert.ToDouble(dr["SHUMA"]);
					double komisioni = vlera * dPerqindja;
					double vleraMeKomision = Math.Round((vlera - komisioni), 2);
					int vleraInt = Convert.ToInt32(dr["SHUMA"]);
					total += vleraInt;
					dTotal += vleraMeKomision;
					dr["MEKOMISION"] = vleraMeKomision;
				}
			}
			DataSet dsPagesa = db.Read("dbShfaqTeGjithaFormatEPageses");
			DataSet dsMunguar = new DataSet();
			dsMunguar.Tables.Add();
			dsMunguar.Tables[0].Columns.Add("ID_FORMAPAGESA", typeof(Int32));
			dsMunguar.Tables[0].Columns.Add("EMRI", typeof(String));
			dsMunguar.Tables[0].Columns.Add("PERQINDJA", typeof(float));
			foreach(DataRow dr in dsPagesa.Tables[0].Rows)
			{
				int idFormaPagesa = Convert.ToInt32(dr["ID_FORMAPAGESA"]);
				bool ugjet = false;
				foreach(DataRow dr1 in dsArka.Tables[0].Rows)
				{
					if (idFormaPagesa == Convert.ToInt32(dr1["ID_FORMAPAGESA"]))
					{
						ugjet = true;
						break;
					}
				}
				if (!ugjet)
				{
					DataRow newRow = dsMunguar.Tables[0].NewRow();
					newRow["ID_FORMAPAGESA"] = dr["ID_FORMAPAGESA"];
					newRow["EMRI"] = dr["EMRI"];
					newRow["PERQINDJA"] = dr["PERQINDJA"];
					dsMunguar.Tables[0].Rows.Add(newRow);
				}
			}
			dsMunguar.AcceptChanges();
			foreach(DataRow dr in dsMunguar.Tables[0].Rows)
			{
				DataRow newRow = dsArka.Tables[0].NewRow();
				newRow["ID_FORMAPAGESA"] = dr["ID_FORMAPAGESA"];
				newRow["EMRI"] = dr["EMRI"];
				newRow["PERQINDJA"] = Math.Round(Convert.ToDouble(dr["PERQINDJA"]), 2);
				newRow["SHUMA"] = 0;
				newRow["MEKOMISION"] = 0;
				dsArka.Tables[0].Rows.Add(newRow);
			}
			dsPagesa.Dispose();
			dsMunguar.Dispose();
			dsArka.AcceptChanges();
			DataRow r = dsArka.Tables[0].NewRow();
			r["EMRI"] = "Totali";
			//r["SHUMA"] = total;
			r["MEKOMISION"] = Math.Round(dTotal, 2);
			dsArka.Tables[0].Rows.Add(r);
			dsArka.AcceptChanges();
			return dsArka;
		}
		
		
		/// <summary>
		/// merr si parameter nje date dhe kthen te gjithe veprimet qe jane kryer ne kete date
		///	duke paraqitur edhe bilancin ditor
		/// </summary>
		/// <param name="dtFillimi"></param>
		/// <param name="dtMbarimi"></param>
		/// <returns>int</returns>
		public DataSet Bilanci()
		{
			DataSet ds;
			DataSet ds1;
			int shuma = 0;
			//gjendet dataseti per arken
			string var = "dbShfaqArkaData";
			DbController db = new DbController(); 
			ds = db.Read(var, data );
			ds.Tables[0].Columns.Add("SASIA_DOUBLE", typeof(double)); 
			double dShuma = 0;
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				double vlera = Convert.ToDouble(dr["ARKA_SASIA"]);
				double perqindja = Math.Round(Convert.ToDouble(dr["PERQINDJA"]), 2);
				perqindja = 0.01 * perqindja;
				double komisioni = perqindja * vlera;
				double vleraMeKomision = Math.Round((vlera - komisioni), 2);
				dShuma += vleraMeKomision;
				//shuma = shuma + Convert.ToInt32(dr[0]);
			}
			//gjendet dataseti per shpenzimet
			shuma = Convert.ToInt32(dShuma);
			var = "dbShfaqShpenzimiData";
			int sasia;
			string komenti;
			db = new DbController(); 
			ds1 = db.Read(var, data );

			//datasetit te arkes i shtohet dataseti per shpenzimet
			DataRow new_row;
			foreach (DataRow dr in ds1.Tables[0].Rows)
			{
				sasia = Convert.ToInt32(dr[0]);
				komenti = Convert.ToString(dr[1]);
				new_row = ds.Tables[0].NewRow();
				new_row["ARKA_SASIA"] = sasia*(-1);
				new_row["KOMENT"] = komenti;
				ds.Tables[0].Rows.Add(new_row);
				dShuma = dShuma - Convert.ToDouble(dr[0]);
				shuma = shuma - Convert.ToInt32(dr[0]);

			}
			ds.AcceptChanges();
			
			//shtohet nje kolone per numer rendor
			ds.Tables[0].Columns.Add("NR", typeof(string));
			int nr_rreshtash = ds.Tables[0].Rows.Count;
			for(int i = 0; i<nr_rreshtash; i++)
			{
				ds.Tables[0].Rows[i]["NR"] = Convert.ToString(i +1);
			}
			ds.AcceptChanges();
			ds.Tables[0].Columns.Add("DATA_STR", typeof(String));
			//shtohet nje rresht per bilancin ditor
			new_row = ds.Tables[0].NewRow();
			new_row["SASIA_DOUBLE"] = dShuma;
			new_row["ARKA_SASIA"] = shuma;
			new_row["NR"] = "Bilanci";
			ds.Tables[0].Rows.Add(new_row);
			return ds;
		}

		public DataSet BilanciDetaje()
		{
			string var = "dbShfaqArkaData";
			DbController db = new DbController(); 
			//gjendet dataseti per arken
			DataSet dsArka = db.Read(var, this.data );
			//nqs perdoruesi eshte fshire shenojme emrin e tij
			//i cili nuk merret naga tabela e perdoruesve
			//te njejten gje bejme edhe per shpenzimet
			dsArka.Tables[0].Columns.Add("LARGUAR", typeof(bool));
			dsArka.AcceptChanges();
			foreach(DataRow dr in dsArka.Tables[0].Rows)
			{
				if ((Convert.IsDBNull(dr["USER_NAME"]))&& !Convert.IsDBNull(dr["EMER_PERDORUES"]))
				{
					dr["USER_NAME"] = dr["EMER_PERDORUES"].ToString();
					dr["LARGUAR"] = true;
				}
				else
					dr["LARGUAR"] = false;
			}
			//gjendet dataseti per shpenzimet
			var = "dbShfaqShpenzimiData";
			DataSet dsShpenzime = db.Read(var, data );
			dsShpenzime.Tables[0].Columns.Add("LARGUAR", typeof(bool));
			dsShpenzime.AcceptChanges();
			foreach(DataRow dr in dsShpenzime.Tables[0].Rows)
			{
				if ((Convert.IsDBNull(dr["USER_NAME"]))&& !Convert.IsDBNull(dr["EMER_PERDORUES"]))
				{
					dr["USER_NAME"] = dr["EMER_PERDORUES"].ToString();
					dr["LARGUAR"] = true;
				}
				else
					dr["LARGUAR"] = false;
				
			}
			foreach(DataRow dr in dsShpenzime.Tables[0].Rows)
			{
				DataRow arkaRow = dsArka.Tables[0].NewRow();
				arkaRow["ARKA_SASIA"] = Convert.ToInt32(dr["SASIA"])* (-1);
				arkaRow["KOMENT"] = dr["EMRI"] + "/" + dr["KOMENT"];
				arkaRow["ID_KLIENTI"] = -2;
				arkaRow["USER_NAME"] = dr["USER_NAME"].ToString();
				arkaRow["LARGUAR"] = Convert.ToBoolean(dr["LARGUAR"]);
				dsArka.Tables[0].Rows.Add(arkaRow);
			}
			dsArka.AcceptChanges();
			DataSet dsBilanci = new DataSet();
			dsBilanci.Tables.Add();
			dsBilanci.Tables[0].Columns.Add("EMRI", typeof(String));
			dsBilanci.Tables[0].Columns.Add("KOMENT", typeof(String));
			dsBilanci.Tables[0].Columns.Add("VLERA", typeof(Int32));
			dsBilanci.Tables[0].Columns.Add("TOTALI", typeof(double));
			dsBilanci.Tables[0].Columns.Add("KOMISIONI", typeof(String));
			dsBilanci.Tables[0].Columns.Add("PERDORUESI", typeof(String));
			dsBilanci.Tables[0].Columns.Add("LARGUAR", typeof(String));
			dsBilanci.AcceptChanges();
			foreach(DataRow dr in dsArka.Tables[0].Rows)
			{
				DataRow bilancirow = dsBilanci.Tables[0].NewRow();
				bilancirow["VLERA"] = dr["ARKA_SASIA"];
				bilancirow["PERDORUESI"] = dr["USER_NAME"];
				bilancirow["LARGUAR"] = dr["LARGUAR"];
				if ((Convert.IsDBNull(dr["PERQINDJA"]))||(Convert.ToDouble(dr["PERQINDJA"]) == 0))
				{
					bilancirow["TOTALI"] = Convert.ToDouble(dr["ARKA_SASIA"]);
				}
				else
				{
					double vlera = Convert.ToDouble(dr["ARKA_SASIA"]);
					double perqindja = 0.01 * Math.Round(Convert.ToDouble(dr["PERQINDJA"]), 2);
					double komisioni = vlera * perqindja;
					double vleraMeKomision = Math.Round((vlera - komisioni), 2);
					bilancirow["TOTALI"] = vleraMeKomision;
					//					string sqarimKomisioni = Convert.ToString(dr["ARKA_SASIA"]);
					//					sqarimKomisioni += " - " + dr["PERQINDJA"].ToString() + "%";
					//					sqarimKomisioni += " " + Convert.ToString(dr["ARKA_SASIA"]);
					bilancirow["KOMISIONI"] = dr["PERQINDJA"].ToString() + "%";
				}
				int idKlienti = Convert.ToInt32(dr["ID_KLIENTI"]);
				if (idKlienti == -2)
				{
					//shpenzim
					bilancirow["EMRI"] = "Shpenzim";
					bilancirow["KOMENT"] = dr["KOMENT"];
				}
				else if (idKlienti == -1)
				{
					//Kapar rezervimi
					bilancirow["EMRI"] = "Kapar rezervimi";
					if (Convert.IsDBNull(dr["ID_GRUPI"]))
						bilancirow["KOMENT"] = dr["EMER_REZ"].ToString();
					else
						bilancirow["KOMENT"] = "Grupi " + dr["GRUPI"].ToString() + Environment.NewLine + "Agjensia " + dr["AGJENSIA"].ToString();
				}
				else if (idKlienti == 0)
				{
					//hedhje manuale
					bilancirow["EMRI"] = "Hedhje manuale";
					//bilancirow["KOMENT"] = ;
				}
				else
				{
					//klient
					if (dr["KOMENT"].ToString() == "Kapar dhome")
					{
						bilancirow["EMRI"] = "Kapar";
						DataSet tmp = db.Read("dbShfaqKlientPerId", idKlienti);
						string dhoma = Convert.ToString(tmp.Tables[0].Rows[0]["DHOMA_EMRI"]);
						bilancirow["KOMENT"] = "Dhoma " + dhoma;
					}
					else if (dr["KOMENT"].ToString() == "Kapar grupi")
					{
						bilancirow["EMRI"] = "Kapar";
						DataSet tmp = db.Read("dbShfaqKlientPerId", idKlienti);
						string grupi = Convert.ToString(tmp.Tables[0].Rows[0]["GRUPI"]);
						string agjensia = Convert.ToString(tmp.Tables[0].Rows[0]["AGJENSIA"]);
						bilancirow["KOMENT"] = "Grupi " + grupi + Environment.NewLine + "Agjensia " + agjensia;
					}
					else if (dr["KOMENT"].ToString() == "Pagese dhome")
					{
						bilancirow["EMRI"] = "Pagese";
						DataSet tmp = db.Read("dbShfaqKlientPerId", idKlienti);
						string dhoma = Convert.ToString(tmp.Tables[0].Rows[0]["DHOMA_EMRI"]);
						bilancirow["KOMENT"] = "Dhoma " + dhoma;
					}
					else if (dr["KOMENT"].ToString() == "Pagese grupi")
					{
						bilancirow["EMRI"] = "Pagese";
						DataSet tmp = db.Read("dbShfaqKlientPerId", idKlienti);
						string grupi = Convert.ToString(tmp.Tables[0].Rows[0]["GRUPI"]);
						string agjensia = Convert.ToString(tmp.Tables[0].Rows[0]["AGJENSIA"]);
						bilancirow["KOMENT"] = "Grupi " + grupi + Environment.NewLine +  "Agjensia " + agjensia;
					}
					else
					{
						bilancirow["EMRI"] = dr["EMRI"].ToString() + " " + dr["MBIEMRI"].ToString();
						int idDetyrimi = Convert.ToInt32(dr["ID_DETYRIMI"]);
						DataSet ds = db.Read("dbGjejIdDetyrimiLLoji", idDetyrimi);
						string lloji = ds.Tables[0].Rows[0]["EMER_LLOJI"].ToString();
						bilancirow["KOMENT"] = lloji;
					}
				}
				dsBilanci.Tables[0].Rows.Add(bilancirow);
			}
			return dsBilanci;
		}
		public DataSet BilanciJanusGrid()
		{
			DataSet ds;
			DataSet ds1;
			DataTable dtGeneral = new DataTable("General");
			dtGeneral.Columns.Add("RELATION", typeof(Int32));
			dtGeneral.Columns.Add("EMRI", typeof(String));
			dtGeneral.Columns.Add("ID_KLIENTI", typeof(Int32));
			int shuma = 0;
			//gjendet dataseti per arken
			string var = "dbShfaqArkaData";
			DbController db = new DbController(); 
			ds = db.Read(var, data );
			ds.Tables[0].Columns.Add("RELATION", typeof (Int32));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				shuma = shuma + Convert.ToInt32(dr[0]);
			}
			int count = 0;
			// Shtojme ne tabelen General te gjithe rreshtat e tabeles se pare qe nuk kane ID_KLIENTI = NULL
			// ID_KLIENTI = -1 OSE ID_KLIENTI = 0
			foreach(DataRow drDetails in ds.Tables[0].Select("ID_KLIENTI IS NOT NULL AND ID_KLIENTI > 0", "EMRI DESC"))
			{
				bool uGjet = false;
				foreach(DataRow drGeneral in dtGeneral.Rows)
				{
					if (drGeneral["ID_KLIENTI"] == drDetails["ID_KLIENTI"])
					{
						drDetails["RELATION"] = drGeneral["RELATION"];
						uGjet = true;
						break;
					}
				}
				if (!uGjet)
				{
					DataRow drGeneral = dtGeneral.NewRow();
					drDetails["RELATION"] = count;
					drGeneral["RELATION"] = count;
					drGeneral["EMRI"] = drDetails["EMRI"] + " " + drDetails["MBIEMRI"];
					drGeneral["ID_KLIENTI"] = drDetails["ID_KLIENTI"];
					dtGeneral.Rows.Add(drGeneral);
					count++;
				}
			}
			// Shtojme tani vleren per kolonen RELATION ne tabelen e pare te datasetit kur kemi te bejme me
			// hedhje manuale
			foreach (DataRow drDetails in ds.Tables[0].Select("ID_KLIENTI IS NOT NULL AND ID_KLIENTI = 0"))
			{
				drDetails["RELATION"] = count;
			}
			// Nese ka ndonje hedhje manuale per ate date, atehere rrit count me 1 dhe shto rreshtin e ri ne
			// tabelen General
			if (ds.Tables[0].Select("ID_KLIENTI IS NOT NULL AND ID_KLIENTI = 0").Length > 0)
			{
				DataRow drGeneral = dtGeneral.NewRow();
				drGeneral["RELATION"] = count;
				drGeneral["EMRI"] = "Hedhje manuale ne arke";
				dtGeneral.Rows.Add(drGeneral);
				count++;
			}
			// Shtojme tani vleren per kolonen RELATION ne tabelen e pare te datasetit kur kemi te bejme me
			// KAPARIN E REZERVIMIT
			foreach (DataRow drDetails in ds.Tables[0].Select("ID_KLIENTI IS NOT NULL AND ID_KLIENTI = -1"))
			{
				drDetails["RELATION"] = count;
				if (Convert.IsDBNull(drDetails["ID_GRUPI"]))
					drDetails["KOMENT"] = "Klienti " + drDetails["EMRI_REZERVIMI"] + " " + drDetails["MBIEMRI_REZERVIMI"] + "   " + drDetails["KOMENT"];
				else
					drDetails["KOMENT"] = "Grupi " + drDetails["EMRI_REZERVIMI"] + " " + drDetails["MBIEMRI_REZERVIMI"] + "   " + drDetails["KOMENT"];
			}
			if (ds.Tables[0].Select("ID_KLIENTI IS NOT NULL AND ID_KLIENTI = -1").Length > 0)
			{
				DataRow drGeneral = dtGeneral.NewRow();
				drGeneral["RELATION"] = count;
				drGeneral["EMRI"] = "Rezervime dhome";
				dtGeneral.Rows.Add(drGeneral);
				count++;
			}

			//gjendet dataseti per shpenzimet
			var = "dbShfaqShpenzimiData";
			int sasia;
			string komenti;
			db = new DbController(); 
			ds1 = db.Read(var, data );

			//datasetit te arkes i shtohet dataseti per shpenzimet
			DataRow new_row;
			foreach (DataRow dr in ds1.Tables[0].Rows)
			{
				sasia = Convert.ToInt32(dr[0]);
				komenti = Convert.ToString(dr[1]);
				new_row = ds.Tables[0].NewRow();
				new_row["ARKA_SASIA"] = sasia*(-1);
				new_row["KOMENT"] = komenti;
				new_row["RELATION"] = count;
				ds.Tables[0].Rows.Add(new_row);
				shuma = shuma - Convert.ToInt32(dr[0]);
			}
			if (ds1.Tables[0].Rows.Count > 0)
			{
				DataRow drGeneral = dtGeneral.NewRow();
				drGeneral["RELATION"] = count;
				drGeneral["EMRI"] = "Shpenzime";
				dtGeneral.Rows.Add(drGeneral);
			}
			ds.Tables.Add(dtGeneral);
			ds.AcceptChanges();
			// Krijojme nje relation mes dy tabelave dtGeneral dhe Table1 dhe ia shtojme datasetit ds
			DataRelation general2details = new DataRelation("GeneralDetails",
				ds.Tables["General"].Columns["RELATION"], 
				ds.Tables["Table1"].Columns["RELATION"]);
			ds.Relations.Add(general2details);

			//shtohet nje kolone per numer rendor
			ds.Tables[0].Columns.Add("NR", typeof(string));
			int nr_rreshtash = ds.Tables[0].Rows.Count;
			for(int i = 0; i<nr_rreshtash; i++)
			{
				ds.Tables[0].Rows[i][2] = Convert.ToString(i +1);
			}
			ds.AcceptChanges();
			ds.Tables[0].Columns.Add("DATA_STR", typeof(String));
			//shtohet nje rresht per bilancin ditor
			new_row = ds.Tables[0].NewRow();
			new_row["ARKA_SASIA"] = shuma;
			new_row["NR"] = "Bilanci";
			ds.Tables[0].Rows.Add(new_row);
			return ds;
		}

		/// <summary>
		/// overloaded merr si parametra nje date gjen bilancin per secil1n muaj
		/// ne fund kryen shumen e bilanceve per te gjithe muajt edhe sipas formes se pagesave.
		/// </summary>
		/// <param name="data"></param>
		/// <returns>DataSet</returns>
		public DataSet BilanciTjeter(DateTime data)
		{
			DataSet ds = new DataSet();
			DataSet dsTmp = new DataSet();
			ds.Tables.Add();
			dsTmp.Tables.Add();
			ds.Tables[0].Columns.Add("MUAJI", typeof(String));
			ds.Tables[0].Columns.Add("BILANCI", typeof(double));
			ds.Tables[0].Columns.Add("TE_ARDHURA", typeof(double));
			ds.Tables[0].Columns.Add("SHPENZIME", typeof(Int32));
			ds.AcceptChanges();
			dsTmp.Tables[0].Columns.Add("TE_ARDHURA", typeof(double));
			dsTmp.AcceptChanges();
			DbController db = new DbController();
			DataSet dsPagesa = db.Read("dbShfaqTeGjithaFormatEPageses");
			double[] v = new double[dsPagesa.Tables[0].Rows.Count];
			foreach(DataRow dr in dsPagesa.Tables[0].Rows)
			{
				string emerKolone = dr["EMRI"].ToString();
				ds.Tables[0].Columns.Add(emerKolone, typeof(double));
				dsTmp.Tables[0].Columns.Add(emerKolone, typeof(double));
			}
			ds.AcceptChanges();
			int viti = data.Year;
			int viti_sot = System.DateTime.Today.Year;
			int muaji;
			DateTime dtKerkimiFillimi;
			DateTime dtKerkimiMbarimi;
			double shuma_arka = 0;
			int shuma_shpenzime = 0;
			double shuma = 0;
			double shuma1 = 0;
			int shuma2 = 0;
			double bilanci_muaji = 0;
			string str_muaji;
			muaji = 12;
			for (int i = 1; i <= muaji; i++)
			{
				dsTmp.Tables[0].Rows.Clear();
				DataRow new_row = ds.Tables[0].NewRow();
				dtKerkimiFillimi = Convert.ToDateTime(viti + "-" + i + "-" + 1);
				dtKerkimiMbarimi = Convert.ToDateTime((viti + i/12) + "-" + (i%12 + 1) + "-" + 1);
				dsTmp = this.ShumaArka(dtKerkimiFillimi,dtKerkimiMbarimi, dsPagesa, dsTmp );
				shuma_arka = Convert.ToDouble(dsTmp.Tables[0].Rows[0]["TE_ARDHURA"]);
				shuma_shpenzime = this.ShumaShpenzime(dtKerkimiFillimi,dtKerkimiMbarimi );
				bilanci_muaji = shuma_arka - shuma_shpenzime;
				shuma = Math.Round((shuma + bilanci_muaji), 2);
				shuma1 = Math.Round((shuma1 + shuma_arka), 2);
				shuma2 = shuma2 + shuma_shpenzime;
				str_muaji = this.Muaji(i);
				new_row["MUAJI"] = str_muaji;
				new_row["BILANCI"] = bilanci_muaji;
				new_row["TE_ARDHURA"] = shuma_arka;
				new_row["SHPENZIME"] = shuma_shpenzime;
				int j = 0;
				foreach(DataRow drPagesa in dsPagesa.Tables[0].Rows)
				{
					string pagesa = drPagesa["EMRI"].ToString();
					new_row[pagesa] = dsTmp.Tables[0].Rows[0][pagesa];
					v[j] += Convert.ToDouble(dsTmp.Tables[0].Rows[0][pagesa]);
					j++;
				}
				ds.Tables[0].Rows.Add(new_row);
			}
			ds.AcceptChanges();
			//shtohet nje kolone per numer rendor
			ds.Tables[0].Columns.Add("NR", typeof(String));
			int nr_rreshtash = ds.Tables[0].Rows.Count;
			for(int i = 0; i<nr_rreshtash; i++)
			{
				ds.Tables[0].Rows[i]["NR"] = Convert.ToString(i +1);
			}
			ds.AcceptChanges();
			//shtohet nje rresht per shumen vjetore
			DataRow shuma_row = ds.Tables[0].NewRow();
			shuma_row["MUAJI"] = "Bilanci per vitin";
			shuma_row["BILANCI"] = shuma;
			shuma_row["TE_ARDHURA"] = shuma1;
			shuma_row["SHPENZIME"] = shuma2;
			int k = 0;
			foreach(DataRow dr in dsPagesa.Tables[0].Rows)
			{
				string pagesa = dr["EMRI"].ToString();
				shuma_row[pagesa] = v[k];
				k++;
			}
			ds.Tables[0].Rows.Add(shuma_row);
			ds.AcceptChanges();
			return ds;
		}
		/// <summary>
		/// merr si parametra nje date fillimi dhe nje date mbarimi dhe gjen bilancin per secilen dite.
		/// ne fund kryen shumen e bilanceve per te gjitha ditet.
		/// </summary>
		/// <param name="dtFillimi"></param>
		/// <param name="dtMbarimi"></param>
		/// <returns>int</returns>
		public DataSet Bilanci(DateTime dtFillimi, DateTime dtMbarimi)
		{
			///ideja eshte ne intervalin e diteve mes diteve te fillimi dhe mbarimit 
			///llogarit bilancin per secilen dhe bej shumen e te gjithave
			/// n.p.r kalendarit gjej sa dite jane nga fillimi ne mbarim
			DataSet ds;
			//krijohet dataseti per arken
			string var = "dbShfaqArkenPerDatat";
			DbController db = new DbController(); 
			ds = db.Read(var, dtFillimi, dtMbarimi );
			double shuma_pergjithshme_arka = 0;
			double shuma_data = 0;
			int nr_rreshtash;
			DateTime data;
			DataRow shuma_data_row;
			DataRow shuma_pergj_row;
			DataRow dr;
			string str_dtFillimi = dtFillimi.ToShortDateString();
			string str_dtMbarimi = dtMbarimi.ToShortDateString();
			TimeSpan ts = dtMbarimi.Date.Subtract(dtFillimi.Date);
			int nr_ditesh = Convert.ToInt32(ts.Days);
			nr_ditesh = nr_ditesh + 1;
			DateTime dita;
			DataSet tmp= new DataSet();
			tmp.Tables.Add();
			tmp.Tables[0].Columns.Add("ARKA_DATA", typeof(DateTime));
			tmp.Tables[0].Columns.Add("ARKA_SASIA", typeof(double));
			ds.Tables[0].Columns.Add("SASIA_DOUBLE", typeof(double));
			DataRow tmp_row;
			bool ugjet;
			if (ds.Tables[0].Rows.Count != 0)
			{
				
				data = Convert.ToDateTime(ds.Tables[0].Rows[0][0]);
				string s = data.ToString();
				nr_rreshtash = ds.Tables[0].Rows.Count;
				//gjendet bilanci i arkes per cdo dite dhe shtohet si rresht i ri ne fund te datasetit
				for(int i = 0; i<nr_rreshtash; i++)
				{
					dr = ds.Tables[0].Rows[i];
					double vlera = Convert.ToDouble(dr["ARKA_SASIA"]);
					double perqindja = 0.01 * Math.Round(Convert.ToDouble(dr["PERQINDJA"]), 2);
					double komisioni = vlera * perqindja;
					double vleraMeKomision = Math.Round((vlera - komisioni),2);
					shuma_pergjithshme_arka = shuma_pergjithshme_arka + vleraMeKomision;
					DateTime d = Convert.ToDateTime(dr[0]);
					if ((data.Date == Convert.ToDateTime(dr[0]).Date)&& (i == nr_rreshtash-1))
					{
						shuma_data = shuma_data + vleraMeKomision;
						shuma_data_row = ds.Tables[0].NewRow();
						shuma_data_row["ARKA_DATA"] = data;
						shuma_data_row["SASIA_DOUBLE"] = Math.Round(shuma_data, 2);
						ds.Tables[0].Rows.Add(shuma_data_row);
					}
					else if (data.Date == Convert.ToDateTime(dr[0]).Date)
					{
						shuma_data = shuma_data + vleraMeKomision;
					}
					else if ((data != Convert.ToDateTime(dr[0]).Date)&& (i == nr_rreshtash-1))
					{
						shuma_data_row = ds.Tables[0].NewRow();
						shuma_data_row["ARKA_DATA"] = data;
						shuma_data_row["SASIA_DOUBLE"] = Math.Round(shuma_data, 2);
						ds.Tables[0].Rows.Add(shuma_data_row);
						data = Convert.ToDateTime(dr[0]);
						shuma_data = vleraMeKomision;
						shuma_data_row = ds.Tables[0].NewRow();
						shuma_data_row["ARKA_DATA"] = data;
						shuma_data_row["SASIA_DOUBLE"] = Math.Round(shuma_data, 2);
						ds.Tables[0].Rows.Add(shuma_data_row);

					}
					else
					{
						shuma_data_row = ds.Tables[0].NewRow();
						shuma_data_row["ARKA_DATA"] = data;
						shuma_data_row["SASIA_DOUBLE"] = Math.Round(shuma_data, 2);
						ds.Tables[0].Rows.Add(shuma_data_row);
						shuma_data = vleraMeKomision;
						data = Convert.ToDateTime(dr[0]);
					}
				}
				ds.AcceptChanges();
				//fshihen rreshtat e dikurshem te datasetit dhe mbeten bilancet ditore te 
				//shtuar pak me pare
				for(int i = 0; i<nr_rreshtash; i++)
				{
					dr = ds.Tables[0].Rows[i];
					dr.Delete();
				}
				ds.AcceptChanges();
				//krijohet nje dataset i ri tmp i cili permban edhe datat per te 
				//cilat nuk ka veprime ne arke
				nr_rreshtash = ds.Tables[0].Rows.Count;
				for(int i = 0;i<nr_ditesh; i++)
				{
					dita = dtFillimi.Date.AddDays(i);
					ugjet = false;
					for (int j = 0; j<nr_rreshtash; j++)
					{
						dr = ds.Tables[0].Rows[j];
						DateTime d = Convert.ToDateTime(dr[0]);
						if (dita.ToShortDateString() == d.Date.ToShortDateString())
						{
							tmp_row = tmp.Tables[0].NewRow();
							tmp_row["ARKA_DATA"] =dr[0];
							tmp_row["ARKA_SASIA"] = dr["SASIA_DOUBLE"];
							tmp.Tables[0].Rows.Add(tmp_row);
							ugjet = true;
							break;
						}
					}
					if (!ugjet)
					{
						tmp_row = tmp.Tables[0].NewRow();
						tmp_row["ARKA_DATA"] = dita;
						tmp_row["ARKA_SASIA"] = 0;
						tmp.Tables[0].Rows.Add(tmp_row);
					}
				}
				tmp.AcceptChanges();
			}
			else
			{
				//dataseti i marre nga baza ishte bosh prandaj krijohet
				// nje dataset i ri i cili permban te gjitha ditet duke i vendosur bilancin=0
				for (int i = 0; i<nr_ditesh; i++)
				{
					dita = dtFillimi.AddDays(i);
					tmp_row = tmp.Tables[0].NewRow();
					tmp_row["ARKA_DATA"] = dita;
					tmp_row["ARKA_SASIA"] = 0;
					tmp.Tables[0].Rows.Add(tmp_row);
				}
				tmp.AcceptChanges();
			}
			
			//krijohet dataseti per shpenzimin
			DataSet ds1;
			var = "dbShfaqShpenzimetPerDatat";
			db = new DbController(); 
			ds1 = db.Read(var, dtFillimi, dtMbarimi );
			int shuma_pergjithshme_shpenzimi = 0;
			shuma_data = 0;
			DataSet tmp1= new DataSet();
			tmp1.Tables.Add();
			tmp1.Tables[0].Columns.Add("DATA", typeof(DateTime));
			tmp1.Tables[0].Columns.Add("SASIA", typeof(double));
			if (ds1.Tables[0].Rows.Count != 0)
			{
				data = Convert.ToDateTime(ds1.Tables[0].Rows[0][0]);
				nr_rreshtash = ds1.Tables[0].Rows.Count;
				//gjendet bilanci per shpenzimet per cdo dite dhe shtohet si rresht i ri ne fund te datasetit
				for(int i = 0; i<nr_rreshtash; i++)
				{
					dr = ds1.Tables[0].Rows[i];
					shuma_pergjithshme_shpenzimi = shuma_pergjithshme_shpenzimi + Convert.ToInt32(dr[1]);
					if ((data == Convert.ToDateTime(dr[0]))&& (i == nr_rreshtash-1))
					{
						shuma_data = shuma_data + Convert.ToDouble(dr[1]);
						shuma_data_row = ds1.Tables[0].NewRow();
						shuma_data_row["DATA"] = data;
						shuma_data_row["SASIA"] = shuma_data;
						ds1.Tables[0].Rows.Add(shuma_data_row);
					}
					else if (data == Convert.ToDateTime(dr[0]))
					{
						shuma_data = shuma_data + Convert.ToDouble(dr[1]);
					}
					else if ((data != Convert.ToDateTime(dr[0]))&& (i == nr_rreshtash-1))
					{
						shuma_data_row = ds1.Tables[0].NewRow();
						shuma_data_row["DATA"] = data;
						shuma_data_row["SASIA"] = shuma_data;
						ds1.Tables[0].Rows.Add(shuma_data_row);
						data = Convert.ToDateTime(dr[0]);
						shuma_data = Convert.ToDouble(dr[1]);
						shuma_data_row = ds1.Tables[0].NewRow();
						shuma_data_row["DATA"] = data;
						shuma_data_row["SASIA"] = shuma_data;
						ds1.Tables[0].Rows.Add(shuma_data_row);

					}
					else
					{
						shuma_data_row = ds1.Tables[0].NewRow();
						shuma_data_row["DATA"] = data;
						shuma_data_row["SASIA"] = shuma_data;
						ds1.Tables[0].Rows.Add(shuma_data_row);
						shuma_data = Convert.ToDouble(dr[1]);
						data = Convert.ToDateTime(dr[0]);
					}
				}
				ds1.AcceptChanges();
				//fshihen rreshtat e dikurshem te datasetit dhe mbeten bilancet ditore te 
				//shtuar pak me pare
				for(int i = 0; i<nr_rreshtash; i++)
				{
					dr = ds1.Tables[0].Rows[i];
					dr.Delete();
				}
				ds1.AcceptChanges();
			
				//krijohet nje dataset i ri tmp1 i cili permban edhe datat per te 
				//cilat nuk ka veprime per shpenzimet
				nr_rreshtash = ds1.Tables[0].Rows.Count;	
				for(int i = 0;i<nr_ditesh; i++)
				{
					dita = dtFillimi.AddDays(i);
					ugjet = false;
					for (int j = 0; j<nr_rreshtash; j++)
					{
						dr = ds1.Tables[0].Rows[j];
						if (dita.Date == Convert.ToDateTime(dr[0]).Date)
						{
							tmp_row = tmp1.Tables[0].NewRow();
							tmp_row["DATA"] = Convert.ToDateTime(dr[0]).Date;
							tmp_row["SASIA"] = Convert.ToDouble(dr[1]);
							tmp1.Tables[0].Rows.Add(tmp_row);
							ugjet = true;
							break;
						}
					}
					if (!ugjet)
					{
						tmp_row = tmp1.Tables[0].NewRow();
						tmp_row["DATA"] = dita.Date;
						tmp_row["SASIA"] = 0;
						tmp1.Tables[0].Rows.Add(tmp_row);
					}
				}
				tmp1.AcceptChanges();
			}
			else
			{
				//dataseti i marre nga baza ishte bosh prandaj krijohet
				// nje dataset i ri i cili permban te gjitha ditet duke i vendosur bilancin=0
				for (int i = 0; i<nr_ditesh; i++)
				{
					dita = dtFillimi.AddDays(i);
					tmp_row = tmp1.Tables[0].NewRow();
					tmp_row["DATA"] = dita.Date;
					tmp_row["SASIA"] = 0;
					tmp1.Tables[0].Rows.Add(tmp_row);
				}
				tmp1.AcceptChanges();
			}



			//dataseti i pergjithshem
			DataRow dr1;
			for(int i = 0; i<nr_ditesh; i++)
			{
				dr = tmp.Tables[0].Rows[i];
				dr1 = tmp1.Tables[0].Rows[i];
				double x = Convert.ToDouble(dr[1]);
				double y = Convert.ToDouble(dr1[1]); 
				tmp1.Tables[0].Rows[i][1] = x - y ;
			}
			tmp1.AcceptChanges();



			//shtohet nje kolone per numer rendor
			tmp1.Tables[0].Columns.Add("NR", typeof(string));
			nr_rreshtash = tmp1.Tables[0].Rows.Count;
			for(int i = 0; i<nr_rreshtash; i++)
			{
				tmp1.Tables[0].Rows[i][2] = Convert.ToString(i +1);
			}
			tmp1.AcceptChanges();
			//behet konvertimi i dates ne string
			tmp1.Tables[0].Columns.Add("DATA_STR", typeof(String));
			foreach(DataRow r in tmp1.Tables[0].Rows)
			{
				r["DATA_STR"] = this.konverto(Convert.ToDateTime(r[0]));
			}
			tmp1.AcceptChanges();
			//shtohet nje rresht ne fund te datasetit i cili permban shumen e gjithe bilanceve
			//ditore per te gjitha ditet e zgjedhura
			double shuma_pergjithshme = shuma_pergjithshme_arka - Convert.ToDouble(shuma_pergjithshme_shpenzimi);
			shuma_pergj_row = tmp1.Tables[0].NewRow();
			shuma_pergj_row["DATA"] = dtMbarimi;
			shuma_pergj_row["SASIA"] = Math.Round(shuma_pergjithshme, 2);
			shuma_pergj_row["NR"] = "Bilanci";
			tmp1.Tables[0].Rows.Add(shuma_pergj_row);
			tmp1.AcceptChanges();
			return tmp1;
		}

		public DataSet Bilanci1(DateTime dataFillimi, DateTime dataMbarimi)
		{
			DataSet ds = new DataSet();
			ds.Tables.Add();
			ds.Tables[0].Columns.Add("DATA", typeof(DateTime));
			ds.Tables[0].Columns.Add("SASIA", typeof(Int32));
			TimeSpan ts = dataMbarimi.Date.Subtract(dataFillimi);
			int numer_ditesh = Convert.ToInt32(ts.Days);
			numer_ditesh = numer_ditesh + 1;
			DateTime dita;
			int shuma_arka;
			int shuma_shpenzime;
			int shuma_pergj_arka = 0;
			int shuma_pergj_shpenzime = 0;
			//DataSet ds_arka;
			//DbController db = new DbController(); 
			//string var = "dbShfaqArkenPerDatat";
			//ds_arka = db.Read(var, dtFillimi, dtMbarimi );
			for(int i = 0; i<numer_ditesh; i++)
			{
				DataRow new_row = ds.Tables[0].NewRow();
				dita = dataFillimi.Date.AddDays(i);
				new_row["DATA"] = dita;
				shuma_arka = this.ShumaArkaData(dita);
				shuma_shpenzime = this.ShumaShpenzimeData(dita);
				new_row["SASIA"] = shuma_arka - shuma_shpenzime;
				shuma_pergj_arka = shuma_pergj_arka + shuma_arka;
				shuma_pergj_shpenzime = shuma_pergj_shpenzime + shuma_shpenzime;
				ds.Tables[0].Rows.Add(new_row);
			}
			ds.AcceptChanges();
			//shtohet nje kolone per numer rendor
			ds.Tables[0].Columns.Add("NR", typeof(string));
			int nr_rreshtash = ds.Tables[0].Rows.Count;
			for(int i = 0; i< nr_rreshtash; i++)
			{
				ds.Tables[0].Rows[i][2] = Convert.ToString(i +1);
			}
			ds.AcceptChanges();

			//shtohet nje rresht per shumen
			int shuma_pergjithshme = shuma_pergj_arka - shuma_pergj_shpenzime;
			DataRow shuma_pergj_row = ds.Tables[0].NewRow();
			shuma_pergj_row["DATA"] = dataMbarimi;
			shuma_pergj_row["SASIA"] = shuma_pergjithshme;
			shuma_pergj_row["NR"] = "Bilanci";
			ds.Tables[0].Rows.Add(shuma_pergj_row);
			ds.AcceptChanges();
			
			return ds;
		}
		/// <summary>
		/// merr si parametra nje date dhe nje numer (sasia e lekeve) dhe krijon nje hedhje te re manuale ne arke
		/// </summary>
		/// <param name="data"></param>
		/// <param name="sasiaLek"></param>
		/// <returns>int</returns>
		public int  Hidh( DateTime data,int sasiaLek, string komenti, int id_klienti, int idFormaPagesa, int idPerdoruesi)
		{
			int p = 0;
			string var = "dbHidhNeArke";
			DbController db = new DbController();
			p = db.Create(var,data,sasiaLek, komenti, id_klienti, idFormaPagesa, idPerdoruesi);
			return p;
		}

		/// <summary>
		/// merr si parametra nje date dhe nje numer (sasia e lekeve) dhe krijon nje hedhje te re ne arke
		/// qe i perket kaparit te rezervimit per klient
		/// </summary>
		/// <param name="data"></param>
		/// <param name="sasiaLek"></param>
		/// <returns>int</returns>
		public int  HidhKaparRezervimi( DateTime data,int sasiaLek, 
			string komenti, int id_rezervimi, int idFormaPagesa, string emri, int idPerdoruesi)
		{
			int p = 0;
			string var = "dbHidhKaparRezervimiKlientiNeArke";
			DbController db = new DbController();
			p = db.Create(var,data,sasiaLek, komenti, id_rezervimi, idFormaPagesa, emri, idPerdoruesi);
			return p;
		}

		/// <summary>
		/// merr si parametra nje date dhe nje numer (sasia e lekeve) dhe krijon nje hedhje te re ne arke
		/// qe i perket kaparit te rezervimit per grup
		/// </summary>
		/// <param name="data"></param>
		/// <param name="sasiaLek"></param>
		/// <returns>int</returns>
		public int  HidhKaparRezervimi( DateTime data,int sasiaLek, 
			string komenti, int id_rezervimi, int idFormaPagesa, int idGrupi, int idPerdoruesi)
		{
			int p = 0;
			string var = "dbHidhKaparRezervimiGrupiNeArke";
			DbController db = new DbController();
			p = db.Create(var,data,sasiaLek, komenti, id_rezervimi, idFormaPagesa,idGrupi, idPerdoruesi);
			return p;
		}
		
		public int FshiKaparKlientiNgaArka(int idKlienti)
		{
			string var = "dbFshiKaparKlientiNgaArka";
			DbController db = new DbController();
			int  b = db.Update(var, idKlienti);
			return b;

		}

		public int FshiKaparRezervimiNgaArka(int idRezervimi)
		{
			DbController db = new DbController();
			int b = db.Delete("dbFshiKaparRezervimiNgaArka", idRezervimi);
			return b;
		}

		public DataSet KaparRezervimiNeArke(int idRezervimi)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbKaparRezervimiNeArke", idRezervimi);
			return ds;
		}

		public int  ModifikoArka( DateTime data,
			int sasiaLek, string komenti, int idFormaPagesa, int idRezervimi, int idPerdoruesi)
		{
			int p = 0;
			string var = "dbModifikoArke";
			DbController db = new DbController();
			p = db.Update(var,sasiaLek, komenti,data, idFormaPagesa,idRezervimi, idPerdoruesi);
			return p;
		}
		/// <summary>
		/// Metoda vlen vetem per modifikimin e atyre transaksioneve ne arke
		/// qe kane te bejne me kaparin e rezervimit te rezervimeve
		/// ne grup
		/// </summary>
		/// <param name="data"></param>
		/// <param name="sasiaLek"></param>
		/// <param name="komenti"></param>
		/// <param name="idFormaPagesa"></param>
		/// <param name="idRezervimi"></param>
		/// <param name="idGrupi"></param>
		/// <returns></returns>
		public int  ModifikoArka( DateTime data,
			int sasiaLek, string komenti, int idFormaPagesa, int idRezervimi, int idGrupi, int idPerdoruesi)
		{
			int p = 0;
			string var = "dbModifikoArke";
			DbController db = new DbController();
			p = db.Update(var,sasiaLek, komenti,data, idFormaPagesa,idRezervimi, idGrupi, idPerdoruesi);
			return p;
		}

		/// <summary>
		/// Metoda vlen vetem per modifikimin e atyre transaksioneve ne arke qe kane te bejne me 
		/// kaparin e rezervimeve
		/// </summary>
		/// <param name="data"></param>
		/// <param name="sasiaLek"></param>
		/// <param name="komenti"></param>
		/// <param name="idFormaPagesa"></param>
		/// <param name="idRezervimi"></param>
		/// <param name="emerRez"></param>
		/// <param name="idPerdoruesi"></param>
		/// <returns></returns>
		public int  ModifikoArka( DateTime data,
			int sasiaLek, string komenti, int idFormaPagesa, int idRezervimi, string emerRez, int idPerdoruesi)
		{
			int p = 0;
			string var = "dbModifikoArke";
			DbController db = new DbController();
			p = db.Update(var,sasiaLek, komenti,data, idFormaPagesa,idRezervimi, emerRez, idPerdoruesi);
			return p;
		}
		/// <summary>
		/// merr si paramatra nje date dhe nje numer negativ (sasine e lekeve)  dhe krijon nje dalje nga arka.
		/// </summary>
		/// <param name="data"></param>
		/// <param name="sasiaLek"></param>
		/// <returns>int</returns>
		public int Nxirr( DateTime data,int sasiaLek)
		{
			int p=0;
			string var = "dbNxirrNgaArka";
			DbController db = new DbController();
			p = db.Update(var,data, sasiaLek);
			return p;
		}

		//		/// <summary>
		//		/// fshin te gjitha transaksionet e arkes deri ne nje date duke shtuar nje rresht i cili mban 
		//		/// gjendjen reale per arken deri ne ate date.
		//		/// </summary>
		//		/// <returns>int</returns>
		public int Fshi()
		{
			int a = 0;
			int p = 0;
			//			//gjendet shuma per arken deri ne daten e dhene
			//			int shumaArka = this.ShumaArka(this.data);
			//			//fshihen transaksionet ne arke deri ne daten ne fjale
			//			string var = "dbFshiArka";
			//			DbController db = new DbController();
			//			a = db.Delete(var, this.data);
			//			p = p + a;
			//			//hidhet rreshti ne arke me shumen per arken
			//			var = "dbHidhNeArke";
			//			db = new DbController();
			//			a = db.Create(var, this.data, shumaArka, "Fshirje e arkes");
			//			p = p + a;
			//			//gjendet shuma per shpenzimet deri ne daten e dhene
			//			int shumaShpenzime = this.ShumaShpenzime(this.data);
			//			//fshihen transaksionet per shpenzimet deri ne daten ne fjale
			//			var = "dbFshiShpenzimeDeriNeDatenEDhene";
			//			db = new DbController();
			//			a = db.Delete(var, this.data);
			//			p = p + a;
			//			//hidhet rreshti ne arke me shumen per arken
			//			var = "dbKrijoShpenzim";
			//			db = new DbController();
			//			a = db.Create(var, this.data, shumaShpenzime, "Shpenzimet deri me " + this.data.ToShortDateString());
			//			p = p + a;
			return p;
		}
		/// <summary>
		/// shfaq te gjitha format e pagesave ekzistuese
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet ShfaqFormaPagese()
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqTeGjithaFormatEPageses");
			return ds;
		}

		/// <summary>
		/// shfaq te dhenat per nje forme ekzistuese te pagesave 
		/// <param name="idFormaPagesa"></param>
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet ShfaqFormaPagese(int idFormaPagesa)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqTeDhenaFormaPagesa", idFormaPagesa);
			return ds;
		}

		/// <summary>
		/// shfaq formen e pageses me te cilen nje klient
		/// ka paguar kaparin per dhomen
		/// <param name="idKlienti"></param>
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet ShfaqFormePageseKaparDhome(int idKlienti)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqFormePageseKaparDhome", idKlienti);
			return ds;
		}
		/// <summary>
		/// shfaq formen e pageses me te cilen per nje rezervim
		/// eshte paguar kapari per dhomen
		/// <param name="idKlienti"></param>
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet ShfaqFormePagesePerRezervim(int idRezervimi)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqFormePagesePerRezervim", idRezervimi);
			return ds;
		}
		/// <summary>
		/// krijon nje forme te re pagese me parametrat e dhene
		/// <param name="emri"></param>
		/// <param name="perqindja"></param>
		/// </summary>
		/// <returns>int</returns>
		public int KrijoFormePagese(string emri, string perqindja)
		{
			DbController db = new DbController();
			DataSet dsPagesat = db.Read("dbNrPagesashPerEmer", emri);
			int b = 0;
			if (Convert.ToInt32(dsPagesat.Tables[0].Rows[0][0]) > 0)
				//ekziston nje forme e tille pagese me kete emer
				b = 2;
			else
				b = db.Create("dbShtoFormePagese",emri, perqindja);
			return b;
		}

		/// <summary>
		/// modifikon nje forme te dhene pagese
		/// <param name="emri"></param>
		/// <param name="perqindja"></param>
		/// <param name="idFormaPagesa"></param>
		/// </summary>
		/// <returns>int</returns>
		public int ModifikoFormePagese(string emri, string perqindja, int idFormaPagesa)
		{
			DbController db = new DbController();
			DataSet dsPagesat = db.Read("dbNrPagesashPerEmerPerModifikim", emri, idFormaPagesa);
			int b = 0;
			if (Convert.ToInt32(dsPagesat.Tables[0].Rows[0][0]) > 0)
				//ekziston nje forme e tille pagese me kete emer
				b = 2;
			else
			{
				dsPagesat = db.Read("dbNrVeprimeshNeArkePerFormePagese", idFormaPagesa);
				if (Convert.ToInt32(dsPagesat.Tables[0].Rows[0][0]) > 0)
					b = 3;
				else
					b = db.Update("dbModifikoFormePagese",emri, perqindja, idFormaPagesa);
			}
			return b;
		}

		/// <summary>
		/// eleminon nje forme te dhene pagese
		/// <param name="idFormaPagesa"></param>
		/// </summary>
		/// <returns>int</returns>
		public int FshiFormePagese(int idFormaPagesa)
		{
			DbController db = new DbController();
			DataSet dsPagesat = db.Read("dbNrVeprimeshNeArkePerFormePagese", idFormaPagesa);
			int b = 0;
			if (Convert.ToInt32(dsPagesat.Tables[0].Rows[0][0]) > 0)
				//ne arke ekzistojne veprime te kryer me kete forme pagese
				b = 2;
			else
				b = db.Update("dbFshiFormePagese", idFormaPagesa);
			return b;
		}

		public DataSet ShfaqKaparRezervimiArka(int idRezervimi)
		{
			DbController db = new DbController();
			DataSet ds = db.Read("dbShfaqKaparRezervimiArka", idRezervimi);
			return ds;
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// ben konvertimin e muajve ne string
		/// <param name="i"></param>
		/// </summary>
		/// <returns>string</returns>
		private string Muaji(int i)
		{
			string s;
			switch(i)
			{
				case 1:
					s = "Janar";
					break;
				case 2:
					s = "Shkurt";
					break;
				case 3:
					s = "Mars";
					break;
				case 4:
					s = "Prill";
					break;
				case 5:
					s = "Maj";
					break;
				case 6:
					s = "Qershor";
					break;
				case 7:
					s = "Korrik";
					break;
				case 8:
					s = "Gusht";
					break;
				case 9:
					s = "Shtator";
					break;
				case 10:
					s = "Tetor";
					break;
				case 11:
					s = "Nentor";
					break;
				case 12:
					s = "Dhjetor";
					break;
				default:
					s = "";
					break;
			}
			return s;
		}

		/// <summary>
		/// ben konvertimin e dates ne string
		/// <param name="data"></param>
		/// </summary>
		/// <returns>string</returns>

		private string konverto(DateTime data)
		{
			string data_str = data.ToString();
			string dita, muaji, viti;
			dita = data_str.Substring(8, 2);
			muaji = data_str.Substring(5, 2);
			viti = data_str.Substring(0, 4);
			data_str = dita + "-" + muaji + "-" + viti;
			return data_str;
		}

		#endregion	
	}
}
