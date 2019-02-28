using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagment.BusDatService
{
	/// <summary>
	/// Klase qe merret me te gjitha veprimet qe kane te bejne me klientet
	/// </summary>
	public class Klienti
	{
		private string emer, mbiemer,agjensia, adrese, telefon, email, targe, vendlindja, shtetesia,emailGrupi;
		private int kapar, idIdentifikim, idDhome,skonto,gjoba;
		private DateTime datelindje, dtHyrje, dtDalje,dataKapari;
		
		#region Constructors
		public Klienti()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		/// <summary>
		/// Merr si parametra te gjitha te dhenat per klientin
		/// </summary>
		/// <param name="emri">emri i klientit</param>
		/// <param name="mbiemri">mbiemri i klientit</param>
		/// <param name="datelindja">datelindja e klientit</param>
		/// <param name="adresa">adresa e klientit</param>
		/// <param name="telefoni">telefoni i klientit</param>
		/// <param name="emaili">emaili i klientit</param>
		/// <param name="targa">targa e makines se klientit</param>
		/// <param name="dtHyrja">data e hyrjes se klientit</param>
		/// <param name="dtDalja">data e daljes se klientit</param>
		/// <param name="kapari">kapari qe paguan klienti</param>
		/// <param name="idIdentifikimi">numri i identifikimit te klientit</param>
		/// <param name="idDhoma">ID e dhomes qe ze klienti</param>
		public Klienti(string emri, string mbiemri, DateTime datelindja, string adresa, string telefoni, string emaili,
			string targa, DateTime dtHyrje, DateTime dtDalje, int kapari, int idIdentifikimi, int idDhoma,int skonto,int gjoba, string vendlindja, string shtetesia)
		{
			this.emer = emri;
			this.mbiemer = mbiemri;
			this.datelindje = datelindja;
			this.adrese = adresa;
			this.telefon = telefoni;
			this.email = emaili;
			this.targe = targa;
			this.dtHyrje = dtHyrje;
			this.dtDalje = dtDalje;
			this.kapar = kapari;
			this.idIdentifikim = idIdentifikimi;
			this.idDhome = idDhoma;
			this.skonto = skonto;
			this.gjoba = gjoba;
			this.vendlindja = vendlindja;
			this.shtetesia = shtetesia;
		}
		public Klienti(string emri, string mbiemri, DateTime datelindja, string adresa, string telefoni, string emaili,
			string targa, DateTime dtHyrje, DateTime dtDalje, int kapari, int idIdentifikimi, int idDhoma, string vendlindja, string shtetesia)
		{
			this.emer = emri;
			this.mbiemer = mbiemri;
			this.datelindje = datelindja;
			this.adrese = adresa;
			this.telefon = telefoni;
			this.email = emaili;
			this.targe = targa;
			this.dtHyrje = dtHyrje;
			this.dtDalje = dtDalje;
			this.kapar = kapari;
			this.idIdentifikim = idIdentifikimi;
			this.idDhome = idDhoma;
			this.vendlindja = vendlindja;
			this.shtetesia = shtetesia;
			
		}
		public Klienti(string emri, string mbiemri,int kapari,int idDhoma)
		{
			this.emer = emri;
			this.mbiemer = mbiemri;
			this.kapar = kapari;
			this.idDhome = idDhoma;
		
		}
		public Klienti(string emri,string agjensia,string emailGr)
		{
			this.emer= emri;
			this.agjensia = agjensia;
			this.emailGrupi = emailGr;
		}
		#endregion

		#region Public Methods
		
		public int KrijoKlient(DateTime dataKapari)
		{
			int c = 0;
			DbController db = new DbController();
			c = db.Create("dbKrijoKlient",this.emer,this.mbiemer,this.datelindje,this.adrese,
				this.telefon,this.email,this.targe,this.dtHyrje,this.dtDalje,this.kapar,
				this.idIdentifikim,this.idDhome,dataKapari, this.vendlindja, this.shtetesia);
			return c;
		}
		/// <summary>
		/// Ben krijimin e klientit kur ai vjen me rezervim
		/// </summary>
		/// <param name="dataKapari"></param>
		/// <param name="idRezervimi"></param>
		/// <returns></returns>
		public int KrijoKlient(DateTime dataKapari, int idRezervimi)
		{
			int c = 0;
			DbController db = new DbController();
			c = db.Create("dbKrijoKlient",this.emer,this.mbiemer,this.datelindje,this.adrese,
				this.telefon,this.email,this.targe,this.dtHyrje,this.dtDalje,this.kapar,
				this.idIdentifikim,this.idDhome,dataKapari, this.vendlindja, this.shtetesia, idRezervimi);
			return c;
		}

		public int KrijoGrup()
		{
			int p = 0;
			DbController db = new DbController();
			DataSet ds = null;
			ds = db.Read("dbKontrolloEmerGrupi",this.emer);
			if (Convert.ToInt32(ds.Tables[0].Rows[0]["NUMRI"]) == 0)
				p = db.Create("dbKrijoGrup",this.emer,this.agjensia, this.emailGrupi);
			else 
				p = 1;//ka klient me kete emer grupi
			return p;
		}

		public int KrijoKlientGrup(int idGrupi,int idKlienti)
		{
			int p = 0;
			DbController db = new DbController();
			p = db.Create("dbKrijoKlientNeGrup", idGrupi, idKlienti);
			return p;
		}

		public int ModifikoKaparKlienti(int idKlienti, int kapari)
		{
			int p = 0;
			DbController db = new DbController();
			p = db.Update("dbModifikoKaparKlientiFutRezervim", idKlienti, kapari);
			return p;
		}

		public int ModifikoGrup(int idGrupi)
		{
			int p = 0;
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbKontrolloEmerGrupi",this.emer, idGrupi);
			int nrGrupe = Convert.ToInt32(ds.Tables[0].Rows[0]["NUMRI"]);
			if (nrGrupe == 0)
			{
				p = db.Update("dbModifikoGrup",idGrupi,this.emer,this.agjensia, this.emailGrupi);
			}
			else
			{
				p = 1;//ekziston nje grup me kete emer
			}
			return p ;
		}
		public int ModifikoKlientGrup(int idKlienti,int idGrupi)
		{
			int p = 0;
			DbController db = new DbController();
			p = db.Update("dbModifikoKlientGrup",idKlienti,idGrupi);
			return p ;
		}
		/// <summary>
		/// Ben modifikimin e vlerave te kaparit, skontos gjobes se aplikuar per nje hyrje
		/// si te tabela Klienti ashtu edhe te Arka vetemnper hyrjet e shpejta
		/// </summary>
		/// <param name="kapari"></param>
		/// <param name="skonto"></param>
		/// <param name="gjoba"></param>
		/// <param name="idKlienti"></param>
		/// <param name="pagesa"></param>
		/// <param name="idFormaPagesa"></param>
		/// <param name="dtDorezimi"></param>
		/// <returns></returns>
		public int ModifikoSkontoKaparGjobe(int kapari,int skonto,
			int gjoba, int idKlienti, int pagesa, int idFormaPagesa, DateTime dtDorezimi, 
			bool dorezuar, int idPerdoruesi)
		{
			int p = 0;
			DbController db = new DbController();
			//modifikohet kapari, skonto, gjoba te klienti
			p = db.Update("dbHidhKaparPergjegjesIri",kapari,skonto, gjoba,idKlienti);
			if (kapari == 0)
			{
				p = p + db.Delete("dbFshiKaparKlientiArka", idKlienti);
			}
			else
			{
				DataSet dsArkaKlient = db.Read("KaparKlientiNeArke", idKlienti);
				if (dsArkaKlient.Tables[0].Rows.Count != 0)//ka nje hedhje te klientit ne arke
					p = p + db.Update("dbModifikoKaparKlientiArka", kapari, idKlienti, idFormaPagesa, idPerdoruesi);
				else//nuk ka nje hedhje te klientit ne arke, duhet te krijojme nje te re
				{
					DataSet dsKlient = db.Read("dbShfaqKlientPerId", idKlienti);
					DateTime data = Convert.ToDateTime(dsKlient.Tables[0].Rows[0]["DATA_HYRJE"]);
					string koment;
					if (Convert.IsDBNull(dsKlient.Tables[0].Rows[0]["ID_GRUPI"]))
						koment = "Kapar dhome";
					else
						koment = "Kapar grupi";
					//merret idPerdoruesi nga forma
					p = p + db.Create("dbHidhNeArke",data,kapari, koment, idKlienti, idFormaPagesa, idPerdoruesi);
				}
			}
			//behet modifikimi i pageses sipas llogaritjeve te meparshme
			DataSet dsPagesaArka = db.Read("dbPageseKlientiNeArke", idKlienti);
			if (dsPagesaArka.Tables[0].Rows.Count != 0)
				//ekziston nje hedhje pagese nga klienti ne arke
				//e cila modifikohet
			{
				if (pagesa > 0)
					p = p + db.Update("dbModifikoPagesaKlientiArka", pagesa, idKlienti, idPerdoruesi);
				else
					//nqs pagesa eshte 0 fshihet nga arka
					p = p + db.Delete("dbFshiPagese", idKlienti);
			}
			else
				//me pare pagesa ka qene 0 dhe si e tille nuk eshte hedhur ne arke
				//me ndryshimin e saj ne nje vlere pozitive nevojitet te krijohet nje hedhje e re ne arke 
				//per daten e dorezimit
			{
				if ((pagesa > 0)&& (dorezuar == true))//modifikimi i pageses behet vetem nqs dhoma apo grupi eshte dorezuar
				{
					DataSet dsKlient = db.Read("dbShfaqKlientPerId", idKlienti);
					string koment;
					if (Convert.IsDBNull(dsKlient.Tables[0].Rows[0]["ID_GRUPI"]))
						koment = "Pagese dhome";
					else
						koment = "Pagese grupi";
					//merret idPerdoruesi nga forma
					p = p + db.Create("dbHidhNeArke",dtDorezimi,pagesa, koment, idKlienti, 1, idPerdoruesi);
				}
			}
			return p ;

		}
		/// <summary>
		/// Ben modifikimin e vlerave te kaparit, skontos gjobes se aplikuar per nje hyrje
		/// si te tabela Klienti ashtu edhe te Arka vetemnper hyrjet me ane te rezervimeve
		/// </summary>
		/// <param name="kapariArka"></param>
		/// <param name="skonto"></param>
		/// <param name="gjoba"></param>
		/// <param name="idKlienti"></param>
		/// <param name="pagesa"></param>
		/// <param name="idFormaPagesa"></param>
		/// <param name="dtDorezimi"></param>
		/// <param name="kapariFiktiv"></param>
		/// <returns></returns>
		public int ModifikoSkontoKaparGjobe(int kapariArka,int skonto,
			int gjoba, int idKlienti, int pagesa, int idFormaPagesa, DateTime dtDorezimi,
			bool dorezuar, int kapariFiktiv, int idPerdoruesi)
		{
			int p = 0;
			DbController db = new DbController();
			//modifikohet kapari, skonto, gjoba te klienti
			p = db.Update("dbHidhKaparPergjegjesIri", kapariFiktiv ,skonto, gjoba,idKlienti);
			if (kapariArka == 0)
			{
				p = p + db.Delete("dbFshiKaparKlientiArka", idKlienti);
			}
			else
			{
				DataSet dsArkaKlient = db.Read("KaparKlientiNeArke", idKlienti);
				if (dsArkaKlient.Tables[0].Rows.Count != 0)//ka nje hedhje te klientit ne arke
					p = p + db.Update("dbModifikoKaparKlientiArka", kapariArka, idKlienti, idFormaPagesa, idPerdoruesi);
				else//nuk ka nje hedhje te klientit ne arke, duhet te krijojme nje te re
				{
					DataSet dsKlient = db.Read("dbShfaqKlientPerId", idKlienti);
					DateTime data = Convert.ToDateTime(dsKlient.Tables[0].Rows[0]["DATA_HYRJE"]);
					string koment;
					if (Convert.IsDBNull(dsKlient.Tables[0].Rows[0]["ID_GRUPI"]))
						koment = "Kapar dhome";
					else
						koment = "Kapar grupi";
					//idPerdoruesi merret nga forma
					p = p + db.Create("dbHidhNeArke",data,kapariArka, koment, idKlienti, idFormaPagesa, idPerdoruesi);
				}
			}
			//behet modifikimi i pageses sipas llogaritjeve te meparshme
			DataSet dsPagesaArka = db.Read("dbPageseKlientiNeArke", idKlienti);
			if (dsPagesaArka.Tables[0].Rows.Count != 0)
				//ekziston nje hedhje pagese nga klienti ne arke
				//e cila modifikohet
			{
				if (pagesa > 0)
					p = p + db.Update("dbModifikoPagesaKlientiArka", pagesa, idKlienti, idPerdoruesi);
				else
					//nqs pagesa eshte 0 fshihet nga arka
					p = p + db.Delete("dbFshiPagese", idKlienti);
			}
			else
				//me pare pagesa ka qene 0 dhe si e tille nuk eshte hedhur ne arke
				//me ndryshimin e saj ne nje vlere pozitive nevojitet te krijohet nje hedhje e re ne arke 
				//per daten e dorezimit
			{
				if ((pagesa > 0)&& (dorezuar == true))//modifikimi i pageses behet vetem nqs dhoma apo grupi eshte dorezuar
				{
					DataSet dsKlient = db.Read("dbShfaqKlientPerId", idKlienti);
					string koment;
					if (Convert.IsDBNull(dsKlient.Tables[0].Rows[0]["ID_GRUPI"]))
						koment = "Pagese dhome";
					else
						koment = "Pagese grupi";
					//idPerdoruesi merret nga forma
					p = p + db.Create("dbHidhNeArke",dtDorezimi,pagesa, koment, idKlienti, 1, idPerdoruesi);
				}
			}
			return p ;

		}
		/// <summary>
		/// Fshin gjithe te dhenat per nje klient perfshire edhe hedhjet ne arke
		/// identifikimin, detyrimet
		/// </summary>
		/// <param name="idKlienti"></param>
		/// <param name="idIdentifikimi"></param>
		/// <returns></returns>
		public int FshiKlient(int idKlienti, int idIdentifikimi)
		{
			int p = 0;
			DbController db = new DbController();
			//fshihet klienti se bashku me detyrimet, identifikimin dhe hedhjet ne arke
			p = db.Update("dbFshiKlient", idKlienti, idIdentifikimi);
			return p;
		}
		/// <summary>
		/// Fshin te dhenat per nje klient duke perfshire edhe fshirjen e kaparit te rezervimit
		/// </summary>
		/// <param name="idKlienti"></param>
		/// <param name="idIdentifikimi"></param>
		/// <param name="idRezervimi"></param>
		/// <returns></returns>
		public int FshiKlient(int idKlienti, int idIdentifikimi, int idRezervimi)
		{
			int p = 0;
			DbController db = new DbController();
			//fshihet klienti se bashku me detyrimet, identifikimin dhe hedhjet ne arke
			p = db.Update("dbFshiKlient", idKlienti, idIdentifikimi);
			if ( p == 0)
				p += db.Delete("dbFshiKaparRezervimiNgaArka", idRezervimi);
			return p;
		}
		/// <summary>
		/// Fshin gjithe te dhenat per nje klient perfshire edhe hedhjet ne arke
		/// identifikimin, detyrimet dhe regjistrimin ne grup
		/// </summary>
		/// <param name="idKlienti"></param>
		/// <param name="idIdentifikimi"></param>
		/// <param name="idGrupi"></param>
		/// <returns></returns>
		public int FshiKlientGrupi(int idKlienti, int idIdentifikimi, int idGrupi)
		{
			int p = 0;
			DbController db = new DbController();
			//fshihet klienti se bashku me detyrimet, identifikimin dhe hedhjet ne arke dhe per grupin
			p = db.Update("dbFshiKlientGrupi", idKlienti, idIdentifikimi, idGrupi);
			return p;
		}
		/// <summary>
		/// Ben fshirjen e te dheanve per klientin duke perfshire edhe
		/// fshirjen e kaparit te rezervimit nga arka
		/// </summary>
		/// <param name="idKlienti"></param>
		/// <param name="idIdentifikimi"></param>
		/// <param name="idGrupi"></param>
		/// <param name="idRezervimi"></param>
		/// <returns></returns>
		public int FshiKlientGrupi(int idKlienti, int idIdentifikimi, int idGrupi, int idRezervimi)
		{
			int p = 0;
			DbController db = new DbController();
			//fshihet klienti se bashku me detyrimet, identifikimin dhe hedhjet ne arke dhe per grupin
			p = db.Update("dbFshiKlientGrupi", idKlienti, idIdentifikimi, idGrupi);
			if ( p == 0)
				p += db.Delete("dbFshiKaparRezervimiNgaArka", idRezervimi);
			return p;
		}
		/// <summary>
		/// Pervec fshirjes se klientit
		/// ben zevendesimin e hedhjeve ne arke te klientit ne emer te pergjegjesit
		/// te ri qe i caktohet dhomes
		/// </summary>
		/// <param name="idKlienti"></param>
		/// <param name="idIdentifikimi"></param>
		/// <param name="pergjegjes_ri"></param>
		/// <param name="kapari"></param>
		/// <param name="skonto"></param>
		/// <param name="gjoba"></param>
		/// <param name="dt"></param>
		/// <param name="dtDalje"></param>
		/// <returns></returns>
		public int FshiPergjegjes(int idKlienti, int idIdentifikimi, int pergjegjes_ri,int kapari, 
			int skonto, int gjoba, DateTime dt, DateTime dtDalje)
		{
			int p = 0;
			DbController db = new DbController();
			//fshihet pergjegjesi se bashku me detyrimet, identifikimin pa hedhjet e tjera ne arke
			//kapari, skontoja dhe gjoba i kalohen pergjegjesit te ri
			p = db.Update("dbFshiPergjegjes", idKlienti, idIdentifikimi);
			//regjistrohet kapari, skonto, gjoba te pergj i ri i dhomes
			p = p + db.Update("dbHidhKaparPergjegjesIri", kapari, skonto, gjoba, pergjegjes_ri);
			//nqs nuk ka pasur me pare kapar edhe pas largimit te pergjegjesit nuk 
			//do te figuroje nje i tille
			p = p + db.Update("dbHidhKaparPergjegjesIriNeArke", idKlienti,dt,  pergjegjes_ri);
			//Modifikohet hedhja e pageses ne arke
			//edhe nqs me pare nuk ka patur hedhje krijohet nje e tille
			p = p + db.Update("dbHidhPagesePergjegjesIriNeArke", idKlienti, dtDalje,  pergjegjes_ri);
			return p;
		}
		/// <summary>
		/// Pervec fshirjes se klientit
		/// ben zevendesimin e hedhjeve ne arke te klientit ne emer te pergjegjesit
		/// te ri qe i caktohet grupit
		/// </summary>
		/// <param name="idKlienti"></param>
		/// <param name="idIdentifikimi"></param>
		/// <param name="pergjegjes_ri"></param>
		/// <param name="kapari"></param>
		/// <param name="skonto"></param>
		/// <param name="gjoba"></param>
		/// <param name="idGrupi"></param>
		/// <param name="dt"></param>
		/// <returns></returns>
		public int FshiPergjegjesGrupi(int idKlienti, int idIdentifikimi, int pergjegjes_ri,
			int kapari, int skonto, int gjoba, int idGrupi, DateTime dt, DateTime dtDalje)
		{
			int p = 0;
			DbController db = new DbController();
			//fshihet pergjegjesi se bashku me detyrimet, identifikimin pa hedhjet e tjera ne arke
			//kapari, skontoja dhe gjoba i kalohen pergjegjesit te ri
			p = db.Update("dbFshiPergjegjesGrupi", idKlienti, idIdentifikimi, idGrupi);
			//regjistrohet kapari, skonto, gjoba te pergj i ri i dhomes
			p = p + db.Update("dbHidhKaparPergjegjesIri", kapari, skonto, gjoba, pergjegjes_ri);
			//nqs nuk ka pasur me pare kapar edhe pas largimit te pergjegjesit nuk 
			//do te figuroje nje i tille
			p = p + db.Update("dbHidhKaparPergjegjesIriNeArke", idKlienti,dt,  pergjegjes_ri);
			//Modifikohet hedhja e pageses ne arke
			//edhe nqs me pare nuk ka patur hedhje krijohet nje e tille
			p = p + db.Update("dbHidhPagesePergjegjesIriNeArke", idKlienti, dtDalje,  pergjegjes_ri);
			return p;
		}
		
		public int FshiGrup(int idGrupi)
		{
			int p = 0;
			DataSet ds = null;
			DataSet dsKlient = null;
			DataSet dsGrup = null;
			DbController db  = new DbController();
			dsGrup = db.Read("dbShfaqKlientetGrupi",idGrupi);
			if(dsGrup.Tables[0].Rows.Count == 0)
			{
				ds = db.Read("dbShfaqRezervimGrupi",idGrupi);
				if (ds.Tables[0].Rows.Count == 0)
				{
					dsKlient = db.Read("dbKontrolloGrupHotel",idGrupi);
					if (dsKlient.Tables[0].Rows.Count == 0)
						p = db.Delete("dbFshiGrup",idGrupi);
					else 
						p = 2;//klient te grupit jane ne hotel
				}
				else 
					p = 1;//per grupin eshte kryer rezervim
			}
			else 
				p = 3;//ka te dhena per klient te ketij grupi
			return p;
		}

		public int ModifikoTeDhenaKlienti(string emri, string mbiemri, DateTime datelindja, string adresa, 
			string telefoni, string emaili, string targa, DateTime dtFillimi, DateTime dtMbarimi,
			int idLlojIdentifikimi, string nrIdentifikimi, int idDhoma, int idKlienti,string vendlindja, string shtetesia)
		{
			int b = 0;
			DbController db = new DbController();
			b = b + db.Update("dbModifikoArke", dtFillimi, idKlienti);
			b = b + db.Update("dbModifikoTeDhenaKlienti",emri, mbiemri, datelindja, adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idDhoma, idKlienti, vendlindja, shtetesia);
			DataSet ds = db.Read("dbShfaqKlientPerId", idKlienti);
			int idIdentifikimi = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_IDENTIFIKIMI"]);
			b = b + db.Update("dbModifikoIdentifikimPerKlient", idLlojIdentifikimi, nrIdentifikimi, idIdentifikimi);
			return b;
		}


		public int ModifikoTeDhenaKlientiGrupi(string emri, string mbiemri, DateTime datelindja, string adresa, 
			string telefoni, string emaili, string targa, DateTime dtFillimi, DateTime dtMbarimi,
			int idLlojIdentifikimi, string nrIdentifikimi, int idDhoma, int idKlienti, int idGrupi,
			string vendlindja, string shtetesia)
		{
			int b = 0;
			DbController db = new DbController();
			b = b + db.Update("dbModifikoArke", dtFillimi, idKlienti);
			b = b + db.Update("dbModifikoTeDhenaKlientiGrupi",emri, mbiemri, datelindja, adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idDhoma, idKlienti, idGrupi, vendlindja, shtetesia);
			DataSet ds = db.Read("dbShfaqKlientPerId", idKlienti);
			int idIdentifikimi = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_IDENTIFIKIMI"]);
			b = b + db.Update("dbModifikoIdentifikimPerKlient", idLlojIdentifikimi, nrIdentifikimi, idIdentifikimi);
			return b;
		}


		public int ModifikoTeDhenaPergjegjes(string emri, string mbiemri, DateTime datelindja, string adresa, 
			string telefoni, string emaili, string targa, DateTime dtFillimi, DateTime dtMbarimi,
			int idLlojIdentifikimi, string nrIdentifikimi, int idDhoma, int idKlienti, int kapari, 
			string vendlindja, string shtetesia, int idPerdoruesi)
		{
			int b = 0;
			DbController db = new DbController();
			//modifikohen te dhenat per pergjegjesin dhe vihen ne 0 vlerat e kaparit dhe s + gj
			b = b + db.Update("dbModifikoTeDhenaPergjegjes",emri, mbiemri, datelindja, adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idDhoma, idKlienti,vendlindja, shtetesia);
			DataSet ds = db.Read("dbShfaqKlientPerId", idKlienti);
			int idIdentifikimi = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_IDENTIFIKIMI"]);
			//modifikohet identifikimi
			b = b + db.Update("dbModifikoIdentifikimPerKlient", idLlojIdentifikimi, nrIdentifikimi, idIdentifikimi);
			//fshihet hedhja e kaparit ne arke
			b = b + db.Update("dbFshiKaparKlientiNgaArka", idKlienti);
			return b;
		}

		public int ModifikoTeDhenaPergjegjesGrupi(string emri, string mbiemri, DateTime datelindja, string adresa, 
			string telefoni, string emaili, string targa, DateTime dtFillimi, DateTime dtMbarimi,
			int idLlojIdentifikimi, string nrIdentifikimi, int idDhoma, int idKlienti, int idGrupi,
			string vendlindja, string shtetesia, int idPerdoruesi)
		{
			int b = 0;
			DbController db = new DbController();
			//modifikohen te dhenat per pergjegjesin e grupit si edhe kapar, skonto, gjobe behen 0
			//behet edhe ndryshimi i grupit
			b = b + db.Update("dbModifikoTeDhenaPergjegjesGrupi",emri, mbiemri, datelindja, adresa,
				telefoni, emaili, targa, dtFillimi, dtMbarimi, idDhoma, idKlienti,idGrupi, vendlindja, shtetesia);
			DataSet ds = db.Read("dbShfaqKlientPerId", idKlienti);
			int idIdentifikimi = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_IDENTIFIKIMI"]);
			//modifikohet identifikimi
			b = b + db.Update("dbModifikoIdentifikimPerKlient", idLlojIdentifikimi, nrIdentifikimi, idIdentifikimi);
			//fshihet hedhja e kaparit ne arke
			b = b + db.Update("dbFshiKaparKlientiNgaArka", idKlienti);
			return b;
		}

		public int ModifikoTeDhenaPergjegjes(string emri, string mbiemri, DateTime datelindja, string adresa, 
			string telefoni, string emaili, string targa, DateTime dtFillimi, DateTime dtMbarimi,
			int idLlojIdentifikimi, string nrIdentifikimi, int idDhoma, 
			int kapari,int skonto, int gjoba, int idKlienti, int pergjegjes_ri, DateTime min, string vendlindja,
			string shtetesia, int idPerdoruesi)
		{
			int b = 0;
			DbController db = new DbController();
			//modifikohen te dhenat per pergjegjesin e dhomes si edhe kapar, skonto, gjobe behen 0
			b = b + db.Update("dbModifikoTeDhenaPergjegjes",emri, mbiemri, datelindja, adresa, telefoni, emaili, targa, dtFillimi, dtMbarimi, idDhoma, idKlienti, vendlindja, shtetesia);
			DataSet ds = db.Read("dbShfaqKlientPerId", idKlienti);
			int idIdentifikimi = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_IDENTIFIKIMI"]);
			//modifikohet identifikimi
			b = b + db.Update("dbModifikoIdentifikimPerKlient", idLlojIdentifikimi, nrIdentifikimi, idIdentifikimi);
			//te pergjegjesi i ri regjistrohet vlera e kaparit, skontos dhe gjobes
			//nuk ka nevoje per idPerdoruesi
			b = b + db.Update("dbHidhKaparPergjegjesIri", kapari, skonto, gjoba, pergjegjes_ri);
			DataSet dsArkaKlient = db.Read("KaparKlientiNeArke",idKlienti);
			if (dsArkaKlient.Tables[0].Rows.Count != 0)
				//do te thote qe pergjegjesi i meparshem ka pasur nje 
				//hedhje ne arke e cila tani mund te modifikohet 
				b = b + db.Update("dbHidhKaparPergjegjesIriNeArke", idKlienti, min, pergjegjes_ri);
			else
				//ne te kundert do te krijohet nje hedhje e re ne arke
				// me forme pagese 1 dhe koment "Kapar dhome"
				//ne kete rast duhet id e Perdoruesit qe ka bere hedhjen e meparshme ne arke
				//dmth te idKlienti
			{
				b = b + db.Create("dbHidhNeArke",min,kapari, "Kapar dhome", pergjegjes_ri, 1, idPerdoruesi);
			}
			//pagesa ne arke nuk modifikohet sepse behet fjale vetem per hyrje te vlefshme
			//klienteve te dale nga hoteli nuk mund tu modifikohen datat dhe as dhoma
			return b;
		}

		public int ModifikoTeDhenaPergjegjesGrupi(string emri, string mbiemri, DateTime datelindja, string adresa, 
			string telefoni, string emaili, string targa, DateTime dtFillimi, DateTime dtMbarimi,
			int idLlojIdentifikimi, string nrIdentifikimi, int idDhoma, 
			int kapari,int skonto, int gjoba, int idKlienti, int pergjegjes_ri, 
			DateTime min, int idGrupi,string vendlindja, string shtetesia, int idPerdoruesi)
		{
			int b = 0;
			DbController db = new DbController();
			//modifikohen te dhenat per pergjegjesin e grupit si edhe kapar, skonto, gjobe behen 0
			//behet edhe ndryshimi i grupit
			b = b + db.Update("dbModifikoTeDhenaPergjegjesGrupi",emri, mbiemri, datelindja, adresa, telefoni, emaili, targa, 
				dtFillimi, dtMbarimi, idDhoma, idKlienti, idGrupi, vendlindja, shtetesia);
			DataSet ds = db.Read("dbShfaqKlientPerId", idKlienti);
			int idIdentifikimi = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_IDENTIFIKIMI"]);
			//modifikohet identifikimi
			b = b + db.Update("dbModifikoIdentifikimPerKlient", idLlojIdentifikimi, nrIdentifikimi, idIdentifikimi);
			//te pergjegjesi i ri regjistrohet vlera e kaparit, skontos dhe gjobes
			b = b + db.Update("dbHidhKaparPergjegjesIri", kapari, skonto, gjoba, pergjegjes_ri);
			DataSet dsArkaKlient = db.Read("KaparKlientiNeArke",idKlienti);
			if (dsArkaKlient.Tables[0].Rows.Count != 0)
				//do te thote qe pergjegjesi i meparshem ka pasur nje 
				//hedhje ne arke e cila tani mund te modifikohet 
				b = b + db.Update("dbHidhKaparPergjegjesIriNeArke", idKlienti, min, pergjegjes_ri);
			else
				//ne te kundert do te krijohet nje hedhje e re ne arke
				// me forme pagese 1 dhe koment "Kapar grupi"
				//ne kete rast duhet id e Perdoruesit qe ka bere hedhjen e meparshme ne arke
				//dmth te idKlienti
			{
				b = b + db.Create("dbHidhNeArke",min,kapari, "Kapar grupi", pergjegjes_ri, 1, idPerdoruesi);
			}
			return b;
		}
		public DataSet ShfaqKlientetPerDhomeDataTeDhena(int idDhoma,DateTime dtFillimi,DateTime dtMbarimi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqKlientPerDhomeDataTeDhena",idDhoma,dtFillimi,dtMbarimi);
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				if (Convert.ToInt32(dr["KAPARI"]) != 0)
				{
					int pergjegjes = Convert.ToInt32(dr["ID_KLIENTI"]);
					DataSet dsPagesa = db.Read("ShfaqFormePagesePerKlient", pergjegjes);
					ds.Tables.Add();
					ds.Tables[1].Columns.Add("ID_FORMAPAGESA", typeof(Int32));
					ds.Tables[1].Columns.Add("EMRI", typeof(String));
					DataRow newrow = ds.Tables[1].NewRow();
					if (dsPagesa.Tables[0].Rows.Count == 0)//do te thote qe ne arke nuk eshte bere tjeter hedhje sepse kapari i gjithi eshte kapar i rezervimit
					{
						int idRezervimi = Convert.ToInt32(dr["ID_REZERVIMI"]);
						dsPagesa = db.Read("dbShfaqKaparRezervimiArkaFormePagese", idRezervimi);
					}
					newrow["ID_FORMAPAGESA"] = dsPagesa.Tables[0].Rows[0]["ID_FORMAPAGESA"].ToString();
					newrow["EMRI"] = dsPagesa.Tables[0].Rows[0]["EMRI"].ToString();
					ds.Tables[1].Rows.Add(newrow);
					ds.AcceptChanges();
					break;
				}
			}
			return ds;
		}
		public DataSet ShfaqTeDhenaGrupiDataTeDhena(int idGrupi,DateTime dtFillimi,DateTime dtMbarimi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqTeDhenaGrupiDataTeDhena",idGrupi,dtFillimi,dtMbarimi);
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				if (Convert.ToInt32(dr["KAPARI"])!= 0)
				{
					int pergjegjes = Convert.ToInt32(dr["ID_KLIENTI"]);
					DataSet dsPagesa = db.Read("ShfaqFormePagesePerKlient", pergjegjes);
					ds.Tables.Add();
					ds.Tables[1].Columns.Add("ID_FORMAPAGESA", typeof(Int32));
					ds.Tables[1].Columns.Add("EMRI", typeof(String));
					ds.Tables[1].Columns.Add("KAPARI", typeof(Int32));
					DataRow newrow = ds.Tables[1].NewRow();
					if (dsPagesa.Tables[0].Rows.Count != 0)
					{
						newrow["ID_FORMAPAGESA"] = dsPagesa.Tables[0].Rows[0]["ID_FORMAPAGESA"].ToString();
						newrow["EMRI"] = dsPagesa.Tables[0].Rows[0]["EMRI"].ToString();
						newrow["KAPARI"] = Convert.ToInt32(dr["KAPARI"]);
					}
					else
					{
						newrow["ID_FORMAPAGESA"] = 1;
						newrow["EMRI"] = "Cash";
						newrow["KAPARI"] = Convert.ToInt32(dr["KAPARI"]);
					}
					ds.Tables[1].Rows.Add(newrow);
					ds.AcceptChanges();
				}
			}
			return ds;

		}
		public DataSet NumerKlienteshPerDateDhoma(int idDhoma,DateTime dtFillimi,DateTime dtMbarimi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbNumerKlienteshPerDateDhoma",idDhoma,dtFillimi,dtMbarimi);
			return ds;
		}
		public DataSet NumerKlienteshPerDateDhoma(int idDhoma,DateTime dt)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbNumerKlienteshPerDateDhoma",idDhoma,dt);
			return ds;
		}
		public DataSet NumerKlienteshPerDateGrup(int idGrupi,DateTime dtFillimi,DateTime dtMbarimi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbNumerKlienteshPerDateGrup",idGrupi,dtFillimi,dtMbarimi);
			return ds;
		}

		public DataSet NrKlienteNeDhomeJoTeGrupit(int idGrupi,DateTime dtFillimi,DateTime dtMbarimi,int idDhoma, int idKlienti)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbNrKlienteNeDhomeJoTeGrupitTeDhene",idGrupi,dtFillimi,dtMbarimi, idDhoma);
			return ds;
		}
		public DataSet NumerKlienteshPerDateGrupPerModifikim(int idDhoma,DateTime dtFillimi,DateTime dtMbarimi, int idKlienti)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbNumerKlienteshPerDateGrupPerModifikim",idDhoma,dtFillimi,dtMbarimi, idKlienti);
			return ds;
		}
		public DataSet gjej_id_klienti_fundit()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqIdKlientFundit");
			return ds;
		}
		public DataSet DetyrimPergjithshemKlienti(int idKlienti)
		{
			
			DataSet ds = null;
			DataSet ds1 = null;
			DataSet detyrimKlienti = new DataSet("DetyrimKlienti");
			DbController db = new DbController();
			ds = db.Read("dbShlyerjeDhomaKlienti",idKlienti);//kapari,cmimidhoma,emerdhoma
			ds1 = db.Read("dbShfaqDetyrimePerKlientin",idKlienti);//llojDetyrimi,sasia,cmimi
			DataRow rreshti;
			rreshti = detyrimKlienti.Tables[0].NewRow();
			rreshti["DHOMA_EMRI"] = Convert.ToString(ds.Tables[0].Rows[2]);
			rreshti["CMIMI_DHOMA"] = Convert.ToInt32(ds.Tables[0].Rows[1]);
			rreshti["KAPARI"] = Convert.ToInt32(ds.Tables[0].Rows[0]);
			foreach( DataRow dr in ds.Tables[0].Rows)
			{
				rreshti = detyrimKlienti.Tables[0].NewRow();			
			}
			return ds;
		}

		public DataSet ShfaqGrupe()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqGrupe");
			return ds;
		}

		public DataSet ShfaqKlientPerId(int idKlienti)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqKlientPerId", idKlienti);
			return ds;
		}
		
		/// <summary>
		/// Kthen emrin e grupit dhe te agjensise per nje idGrupi te dhene
		/// </summary>
		/// <param name="idGrupi">id e Grupit qe po kerkohet</param>
		/// <returns></returns>
		public DataSet ShfaqGrupinPerId(int idGrupi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqGrupinPerId", idGrupi);
			return ds;
		}

		/// <summary>
		/// shfaq hyrjet ne hotel per emer mbiemer te dhene
		/// </summary>
		/// <param name="dataFillimi"></param>
		/// <param name="dataMbarimi"></param>
		/// <returns> DataSet</returns>
	
		public DataSet ShfaqKlientet(string emri, string mbiemri, int vlefshem)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqVeprimetPerKlientin", emri, mbiemri, vlefshem);
			ds = this.OrganizoDataSetPerKliente(ds);
			return ds;
		}

		/// <summary>
		/// shfaq hyrjet ne hotel midis dy datave
		/// </summary>
		/// <param name="emri"></param>
		/// <param name="mbiemri"></param>
		/// <returns> DataSet</returns>
		public DataSet ShfaqKlientet(int vlefshem,DateTime dataFillimi, DateTime dataMbarimi )
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqKlientetSipasDatave", vlefshem, dataFillimi, dataMbarimi);
			ds = this.OrganizoDataSetPerKliente(ds);
			return ds;
		}

		/// <summary>
		/// shfaq hyrjet ne hotel per dhomen me id te dhene
		/// </summary>
		/// <param name="idDhoma"></param>
		/// <returns> DataSet</returns>
		public DataSet ShfaqKlientet(int idDhoma, int vlefshem)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqVeprimetPerDhomen", idDhoma, vlefshem);
			ds = this.OrganizoDataSetPerKliente(ds);
			return ds;
		}

		/// <summary>
		/// shfaq hyrjet per dhomen me id te dhene, midis dy datave
		/// </summary>
		/// <param name="id_dhoma"></param>
		/// <param name="dataFillimi"></param>
		/// <param name="dataMbarimi"></param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqKlientet(int id_dhoma,int vlefshem,  DateTime dtFillimi, DateTime dtMbarimi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqVeprimetPerDhomen",id_dhoma,vlefshem, dtFillimi, dtMbarimi);
			ds = this.OrganizoDataSetPerKliente(ds);
			return ds;
		}

		/// <summary>
		/// shfaq hyrjet per klientin me emer mbiemer te dhene, midis dy datave
		/// </summary>
		/// <param name="emri"></param>
		/// <param name="mbiemri"></param>
		/// <param name="dataFillimi"></param>
		/// <param name="dataMbarimi"></param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqKlientet(string emri, string mbiemri,DateTime dtFillimi, DateTime dtMbarimi, int vlefshem)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqKlientetSipasEmrit", emri , mbiemri, dtFillimi, dtMbarimi, vlefshem);
			ds = this.OrganizoDataSetPerKliente(ds);
			return ds;
		}

		/// <summary>
		/// shfaq hyrjet per klientin me emer mbiemer te dhene ne dhomen me id te dhene, midis dy datave
		/// </summary>
		/// <param name="idDhoma"></param>
		/// <param name="emri"></param>
		/// <param name="mbiemri"></param>
		/// <param name="dataFillimi"></param>
		/// <param name="dataMbarimi"></param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqKlientet(int idDhoma, string emri, string mbiemri,
			DateTime dataFillimi, DateTime dataMbarimi, int vlefshem)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqVeprimetPerKlientinDheDhomen",idDhoma, emri, mbiemri, dataFillimi, dataMbarimi, vlefshem);
			ds = this.OrganizoDataSetPerKliente(ds);
			return ds;
		}

		public DataSet ShfaqKlientetPerGrupinEdhene(string grupi, string agjensia)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqKlientetSipasGrupit", grupi, agjensia);
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATELINDJA_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				
				DateTime dataHyrje = Convert.ToDateTime(dr[7]);
				DateTime dataDalje = Convert.ToDateTime(dr[8]);
				DateTime datelindja = Convert.ToDateTime(dr[2]);
				dr[27] = this.konverto(dataHyrje);
				dr[28] = this.konverto(dataDalje);
				dr[29] = this.konverto(datelindja);
			}
			ds.AcceptChanges();
			return ds;

		}
		/// <returns>emer,mbiemer,grupi,agjensia,mjetIdentifikimi,nrIdentifikimi,datelindja,nrTel,Email,dateHyrje,dateDalje,dhomaEmri,kapari</returns>
		public DataSet ShfaqKlientetNeHotel()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqKlientetNeHotel");
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATELINDJA_STR",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr["DATA_HYRJE"]);
				DateTime dataDalje = Convert.ToDateTime(dr["DATA_DALJE"]);
				DateTime datelindja = Convert.ToDateTime(dr["DATELINDJA"]);
				dr["DATA_HYRJE_STR"] = this.konverto(dataHyrje);
				dr["DATA_DALJE_STR"] = this.konverto(dataDalje);
				dr["DATELINDJA_STR"] = this.konverto(datelindja);
			}
			ds.AcceptChanges();
			return ds;
		}


		/// <summary>
		/// shfaq hyrjet e vlefshme ne hotel, qe kane klienti_hoteli = 1, ose qe nuk u ka kaluar data e daljes
		/// </summary>
		/// <returns>DataSet</returns>       
		public DataSet ShfaqKlientetDhomatNeHotel2()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqKlientetNeHotel");
			ds = this.OrganizoDataSetPerKliente(ds);
			return ds;
		}
        

		/// <summary>
		/// shfaq hyrjet e vlefshme ne grup ne hotel
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet ShfaqKlientetNeGrup()
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqKlientetGrupNeHotel");
			ds = this.OrganizoDataSetPerGrup(ds);
			return ds;
		}

		/// <summary>
		/// shfaq hyrjet ne hotel per grupin ne varesi te 
		/// kerkeses se perdoruesit per hyrje te vlefshme ose jo
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet ShfaqKlientetNeGrup(int klientHoteli)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqKlientetGrupNeHotel", klientHoteli);
			ds = this.OrganizoDataSetPerGrupPerModifikim(ds);
			return ds;
		}

		/// <summary>
		/// shfaq hyrjet per grupin, dhomen e dhene midis dy datave
		/// </summary>
		/// <param name="idGrupi"></param>
		/// <param name="idDhoma"></param>
		/// <param name="dataFillimi"></param>
		/// <param name="dataMbarimi"></param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqKlientetNeGrup(int idGrupi, int idDhoma,
			DateTime dtFillimi, DateTime dtMbarimi, int vlefshem)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqVeprimetPerGrupDheDhome", idGrupi, idDhoma, dtFillimi, dtMbarimi, vlefshem);
			ds = this.OrganizoDataSetPerGrup(ds);
			return ds;
		}
		/// <summary>
		/// shfaq hyrjet per grupin, dhomen e dhene midis dy datave
		/// </summary>
		/// <param name="idGrupi"></param>
		/// <param name="idDhoma"></param>
		/// <param name="dataFillimi"></param>
		/// <param name="dataMbarimi"></param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqKlientetNeGrupPaRezervim(int idGrupi,
			DateTime dtFillimi, DateTime dtMbarimi, int idRezervimi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqVeprimetPerGrupPaRezervim", idGrupi,
				dtFillimi, dtMbarimi, idRezervimi);
			ds = this.OrganizoDataSetPerGrup(ds);
			return ds;
		}		/// <summary>
		/// shfaq hyrjet per grupin e dhene
		/// </summary>
		/// <param name="idGrupi"></param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqKlientetPerGrup(int id_grupi,int vlefshem)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqVeprimetPerGrupin", id_grupi, vlefshem);
			ds = this.OrganizoDataSetPerGrup(ds);
			return ds;
		}

		/// <summary>
		/// shfaq hyrjet per grupin e dhene per modifikim
		/// </summary>
		/// <param name="idGrupi"></param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqKlientetPerGrupPerModifikim(int id_grupi,int vlefshem)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqVeprimetPerGrupin", id_grupi, vlefshem);
			ds = this.OrganizoDataSetPerGrupPerModifikim(ds);
			return ds;
		}
		/// <summary>
		/// shfaq hyrjet per grupin e dhene midis dy datave
		/// </summary>
		/// <param name="idGrupi"></param>
		/// <param name="dataFillimi"></param>
		/// <param name="dataMbarimi"></param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqKlientetPerGrup(int id_grupi,int vlefshem, DateTime dtFillimi, DateTime dtMbarimi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqVeprimetPerGrupin", id_grupi,vlefshem, dtFillimi, dtMbarimi);
			ds = this.OrganizoDataSetPerGrup(ds);
			return ds;
		}
		public DataSet ShfaqKlientetPerGrup(int id_grupi,int vlefshem, 
			DateTime dtFillimi, DateTime dtMbarimi, int idRezervimi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqVeprimetPerGrupinPaRezervim", id_grupi,vlefshem, dtFillimi, dtMbarimi, idRezervimi);
			ds = this.OrganizoDataSetPerGrup(ds);
			return ds;
		}
		/// <summary>
		/// shfaq hyrjet ne grup per dhomen e dhene
		/// </summary>
		/// <param name="id_dhoma"></param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqKlientetNeGrup(int id_dhoma, int vlefshem)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqVeprimetNeGrupPerDhomen", id_dhoma, vlefshem);
			ds = this.OrganizoDataSetPerGrup(ds);
			return ds;
		}

		/// <summary>
		/// shfaq hyrjet ne grup per dhomen e dhene midis dy datave
		/// </summary>
		/// <param name="idDhoma"></param>
		/// <param name="dataFillimi"></param>
		/// <param name="dataMbarimi"></param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqKlientetNeGrup(int id_dhoma,int vlefshem, DateTime dtFillimi, DateTime dtMbarimi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqVeprimetNeGrupPerDhomen", id_dhoma, vlefshem, dtFillimi, dtMbarimi);
			ds = this.OrganizoDataSetPerGrup(ds);
			return ds;
		}

		/// <summary>
		/// shfaq hyrjet ne grup  midis dy datave
		/// </summary>
		/// <param name="dataFillimi"></param>
		/// <param name="dataMbarimi"></param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqKlientetNeGrup( DateTime date_fillimi, DateTime date_mbarimi, int vlefshem)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqVeprimetNeGrupPerDatat",vlefshem, date_fillimi, date_mbarimi);
			ds = this.OrganizoDataSetPerGrup(ds);
			return ds;
		}

		/// <summary>
		/// shfaq datat e hyrjes dhe daljes per klientin e dhene
		/// </summary>
		/// <param name="idKlienti"></param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqDataPerKlientin(int idKlienti)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqDataPerKlientin", idKlienti);
			return ds;
		}
		/// <summary>
		/// shfaq klientet qe i perkasin rezervimit te dhene
		/// </summary>
		/// <param name="idRezervimi"></param>
		/// <returns></returns>
		public DataSet ShfaqKlientetPerRezervim(int idRezervimi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqVeprimetPerRezervim", idRezervimi);
			return ds;
		}

		/// <summary>
		/// shfaq detyrimet per dhomen 
		/// </summary>
		/// <param name="idKlienti">int</param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqDetyrimePerKlientinPerDhomen(int idKlienti)
		{   

			DataSet dsDhoma = new DataSet();
			DataTable dtb = new DataTable();
			dtb.Columns.Add(new DataColumn("EMRI", typeof(string)));
			dtb.Columns.Add(new DataColumn("MBIEMRI", typeof(string)));
			dtb.Columns.Add(new DataColumn("DATA_HYRJE", typeof(DateTime)));
			dtb.Columns.Add(new DataColumn("DATA_DALJE", typeof(DateTime)));
			dtb.Columns.Add(new DataColumn("KAPARI", typeof(int)));
			dtb.Columns.Add(new DataColumn("ID_DHOMA", typeof(int)));
			dtb.Columns.Add(new DataColumn("DHOMA_EMRI", typeof(string)));
			dtb.Columns.Add(new DataColumn("CMIMI", typeof(int)));
			dtb.Columns.Add(new DataColumn("VLERA", typeof(int)));
			dtb.Columns.Add(new DataColumn("DETYRIMI", typeof(int)));
			dsDhoma.Tables.Add(dtb);
			DbController db = new DbController();
			
			
			DataSet ds = null;
			ds = db.Read("dbShfaqDetyrimePerKlientinPerDhomen", idKlienti);
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DataRow row = dsDhoma.Tables[0].NewRow();
				row["EMRI"] = dr["EMRI"];
				row["MBIEMRI"] = dr["MBIEMRI"];
				row["DATA_HYRJE"] = dr["DATA_HYRJE"];
				row["DATA_DALJE"] = dr["DATA_DALJE"];
				row["KAPARI"] = dr["KAPARI"];
				row["ID_DHOMA"] = dr["ID_DHOMA"];
				row["DHOMA_EMRI"] = dr["DHOMA_EMRI"];
				row["CMIMI"] = dr["CMIMI"];

				DateTime dtHyrje;
				DateTime dtDalje;
				dtHyrje = Convert.ToDateTime(dr["DATA_HYRJE"]);
				dtDalje = Convert.ToDateTime(dr["DATA_DALJE"]);
				int nrDitesh ;
				TimeSpan ts;
				ts = dtDalje.Subtract(dtHyrje);
				nrDitesh = ts.Days;
                
				row["VLERA"] = nrDitesh * Convert.ToInt32(dr["CMIMI"]);
				row["DETYRIMI"] = Convert.ToInt32(dr["CMIMI"]) * nrDitesh - Convert.ToInt32(dr["KAPARI"]);

				dsDhoma.Tables[0].Rows.Add(row);
			}
			return dsDhoma;
		}
		/// <summary>
		/// shfaq detyrimet ekstra te klientit
		/// </summary>
		/// <param name="idKlienti">int</param>
		/// <returns>DataSet</returns>
		public DataSet ShfaqDetyrimeEkstraPerKlientin(int idKlienti)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqDetyrimeEkstraPerKlientin", idKlienti);
			return ds;

		}
        
		public DataSet ShfaqKlientetPerGrupin(int idGrupi)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqKlientetPerGrupin", idGrupi);
			return ds;
		}
        
		public DataSet ShfaqDetyrimetPerKlientetPerDhomat(int[] idKlientet)
		{
			DataSet dsKlientet = new DataSet();
			DataTable dtb = new DataTable();
			dtb.Columns.Add(new DataColumn("EMRI", typeof(string)));
			dtb.Columns.Add(new DataColumn("MBIEMRI", typeof(string)));
			dtb.Columns.Add(new DataColumn("DATA_HYRJE", typeof(DateTime)));
			dtb.Columns.Add(new DataColumn("DATA_DALJE", typeof(DateTime)));
			dtb.Columns.Add(new DataColumn("KAPARI", typeof(int)));
			dtb.Columns.Add(new DataColumn("ID_DHOMA", typeof(int)));
			dtb.Columns.Add(new DataColumn("DHOMA_EMRI", typeof(string)));
			dtb.Columns.Add(new DataColumn("CMIMI", typeof(int)));
			dsKlientet.Tables.Add(dtb);
			DbController db = new DbController();
			
			for (int i = 0; i < idKlientet.Length; i++)
			{
				DataSet ds = db.Read("dbShfaqDetyrimePerKlientinPerDhomen", idKlientet[i]);
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					DataRow row = dsKlientet.Tables[0].NewRow();
					row["EMRI"] = dr["EMRI"];
					row["MBIEMRI"] = dr["MBIEMRI"];
					row["DATA_HYRJE"] = dr["DATA_HYRJE"];
					row["DATA_DALJE"] = dr["DATA_DALJE"];
					row["KAPARI"] = dr["KAPARI"];
					row["ID_DHOMA"] = dr["ID_DHOMA"];
					row["DHOMA_EMRI"] = dr["DHOMA_EMRI"];
					row["CMIMI"] = dr["CMIMI"];
					dsKlientet.Tables[0].Rows.Add(row);
				}
			    
						
				
			}
			return dsKlientet;
		}



		public DataSet ShfaqDetyrimeEkstraPerKlientet(int[] idKlientet)
		{
			DataSet dsKlientet = new DataSet();
			DataTable dtb = new DataTable();
			dtb.Columns.Add(new DataColumn("EMRI", typeof(string)));
			dtb.Columns.Add(new DataColumn("MBIEMRI", typeof(string)));
			dtb.Columns.Add(new DataColumn("EMER_LLOJI", typeof(string)));
			dtb.Columns.Add(new DataColumn("CMIMI", typeof(int)));
			dtb.Columns.Add(new DataColumn("SASIA", typeof(int)));
			dtb.Columns.Add(new DataColumn("DATA", typeof(DateTime)));
			dtb.Columns.Add(new DataColumn("VLERA", typeof(int)));
			dtb.Columns.Add(new DataColumn("DATA_STR", typeof(String)));
			dtb.Columns.Add(new DataColumn("DATA_HYRJE_STR", typeof(String)));
			dtb.Columns.Add(new DataColumn("DATA_DALJE_STR", typeof(String)));
			dtb.Columns.Add(new DataColumn("ID_KLIENTI", typeof(Int32)));
			dtb.Columns.Add(new DataColumn("DHOMA_EMRI", typeof(String)));
			dtb.Columns.Add(new DataColumn("ID_REZERVIMI", typeof(Int32)));

			dsKlientet.Tables.Add(dtb);
			DbController db = new DbController();
			int vlera = 0;
			for (int i = 0; i < idKlientet.Length; i++)
			{
				DataSet ds = db.Read("dbShfaqDetyrimeEkstraPerKlientin", idKlientet[i]);
				if (ds.Tables[0].Rows.Count > 0)
				{
					foreach(DataRow dr in ds.Tables[0].Rows)
					{
						DataRow row = dsKlientet.Tables[0].NewRow();
						row["EMRI"] = dr["EMRI"].ToString() + " " + dr["MBIEMRI"].ToString();
						row["MBIEMRI"] = dr["MBIEMRI"];
						row["EMER_LLOJI"] = dr["EMER_LLOJI"];
						row["CMIMI"] = dr["CMIMI"];
						row["SASIA"] = dr["SASIA"];
						row["DATA"] = dr["DATA"];
						row["VLERA"] = Convert.ToInt32(dr["CMIMI"]) * Convert.ToInt32(dr["SASIA"]);
						vlera = vlera + Convert.ToInt32(dr["CMIMI"]) * Convert.ToInt32(dr["SASIA"]);
						row["DATA_STR"] = this.konverto(Convert.ToDateTime(dr["DATA"]));
						row["DATA_HYRJE_STR"] = this.konverto(Convert.ToDateTime(dr["DATA_HYRJE"]));
						row["DATA_DALJE_STR"] = this.konverto(Convert.ToDateTime(dr["DATA_DALJE"]));
						row["ID_KLIENTI"] = Convert.ToInt32(dr["ID_KLIENTI"]);
						row["DHOMA_EMRI"] = dr["DHOMA_EMRI"].ToString();
						if (!Convert.IsDBNull(dr["ID_REZERVIMI"]))
							row["ID_REZERVIMI"] = Convert.ToInt32(dr["ID_REZERVIMI"]);
						dsKlientet.Tables[0].Rows.Add(row);
					}
				}
				else
				{
					ds = db.Read("ShfaqKlientPaDetyrime", idKlientet[i] );
					DataRow r = ds.Tables[0].Rows[0];
					DataRow row = dsKlientet.Tables[0].NewRow();
					row["EMRI"] = r["EMRI"].ToString() + " " + r["MBIEMRI"].ToString() ;
					row["MBIEMRI"] = r["MBIEMRI"];
					row["VLERA"] = 0;
					row["DATA_HYRJE_STR"] = this.konverto(Convert.ToDateTime(r["DATA_HYRJE"]));
					row["DATA_DALJE_STR"] = this.konverto(Convert.ToDateTime(r["DATA_DALJE"]));
					row["ID_KLIENTI"] = Convert.ToInt32(r["ID_KLIENTI"]);
					row["DHOMA_EMRI"] = r["DHOMA_EMRI"].ToString();
					if (!Convert.IsDBNull(r["ID_REZERVIMI"]))
						row["ID_REZERVIMI"] = Convert.ToInt32(r["ID_REZERVIMI"]);
					dsKlientet.Tables[0].Rows.Add(row);
				}
			}
			return dsKlientet;

		}

		public int NxirrKlientinNgaDhoma(int idKlienti, int skonto, int gjoba)
		{
			int p = 0;
			DbController db = new DbController();
			p = db.Update("dbNxirrKlientiNgaDhoma",idKlienti,skonto, gjoba );
			return p ;
		}

		public int ModifikoDatenEdaljes(int idKlienti, DateTime dtDalje)
		{
			int p = 0;
			DbController db = new DbController();
			p = db.Update("dbModifikoDatenEdaljes",dtDalje, idKlienti );
			return p ;
		}
			
		public DataSet ShfaqKlientetPerDhomat(int[] idDhomat)
		{   
			DataSet ds = null;
			DataSet dsKlientet = new DataSet();
			DataTable dtb = new DataTable();
			dtb.Columns.Add(new DataColumn("ID_KLIENTI", typeof(int)));
			dtb.Columns.Add(new DataColumn("DATA_HYRJE", typeof(DateTime)));
			dtb.Columns.Add(new DataColumn("DATA_DALJE", typeof(DateTime)));
			dsKlientet.Tables.Add(dtb);
			DbController db = new DbController();
			int gjatesia = idDhomat.Length;
			int i = 0;
			for(i=0; i < gjatesia; i++)
			{
				ds = db.Read("dbShfaqKlientetPerDhomenEdhene", idDhomat[i]);
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					DataRow row = dsKlientet.Tables[0].NewRow();
					row["ID_KLIENTI"] = dr["ID_KLIENTI"];
					row["DATA_HYRJE"] = dr["DATA_HYRJE"];
					row["DATA_DALJE"] = dr["DATA_DALJE"];
					dsKlientet.Tables[0].Rows.Add(row);
				}
			}
		
			return dsKlientet;
		}
        
		
		/// <summary>
		/// kthen klientet qe ndodhen aktualisht ne dhomen e dhene
		/// </summary>
		/// <param name="emriDhoma"></param>
		/// <returns></returns>
		public DataSet ShfaqKlientetPerDhomenEgrupit(string emriDhoma)
		{
			DataSet ds = null;
			DbController db = new DbController();
			ds = db.Read("dbShfaqKlientetPerDhomenEgrupit", emriDhoma);
			return ds;	
		}


		/// <summary>
		/// Hedh ne nje dataset te gjitha te dhenat rreth klienteve dhe dhomave te cilet kane hyre
		/// dhe kane dale nga dhoma ne nje periudhe kohe te percaktuar nga dtFillimi dhe nga dtMbarimi.
		/// Te dhenat hidhen te grupuara sipas klienteve qe kane qene ne ate dhome ne te njejten
		/// periudhe kohe
		/// </summary>
		/// <param name="emer">Emri i klientit</param>
		/// <param name="mbiemer">Mbiemri i klientit</param>
		/// <param name="dtFillimi">Data e fillimit te kerkimit</param>
		/// <param name="dtMbarimi">Data e mbarimit te kerkimit</param>
		/// <returns>DataSet me te gjitha te dhenat</returns>
		public DataSet ShfaqKlienteDale(string emer, string mbiemer, DateTime dtFillimi, DateTime dtMbarimi)
		{
			DataSet dsKliente = null;
			double difDite = 0;
			double difOre = 0;
			System.TimeSpan diff;
			DbController db = new DbController();
			// Marrim te gjitha te dhenat per klientin dhe per dhomen dhe i hedhim ne dsKliente
			dsKliente = db.Read("ShfaqKlientetEDale", emer, mbiemer, dtFillimi, dtMbarimi);
			dsKliente.Tables[0].Columns.Add("PAGESA", typeof(Double));
			dsKliente.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof (String));
			dsKliente.Tables[0].Columns.Add("DATA_DALJE_STR", typeof(String));
			dsKliente.AcceptChanges();
			//dsKliente
			foreach (DataRow dr in dsKliente.Tables[0].Rows)
			{

				diff = Convert.ToDateTime(dr["DATA_DALJE"]).Subtract(Convert.ToDateTime(dr["DATA_HYRJE"]));
				dr["EMRI"] += " " + dr["MBIEMRI"];
				if ((Int32)dr["ID_KATEGORIA"] != 31)
				{
					difDite = Math.Round(diff.TotalDays);
					dr["PAGESA"] = Convert.ToDouble(difDite * Convert.ToDouble(dr["CMIMI"]));
					dr["DATA_HYRJE_STR"] = Convert.ToDateTime(dr["DATA_HYRJE"]).ToString("dd/MM/yyyy");
					dr["DATA_DALJE_STR"] = Convert.ToDateTime(dr["DATA_DALJE"]).ToString("dd/MM/yyyy");
				}
				else
				{
					difOre = diff.TotalHours;
					dr["PAGESA"] = difOre * Convert.ToDouble(dr["CMIMI"]);
					dr["DATA_HYRJE_STR"] = Convert.ToDateTime(dr["DATA_HYRJE"]).ToString("dd/MM/yyyy HH/mm");
					dr["DATA_DALJE_STR"] = Convert.ToDateTime(dr["DATA_DALJE"]).ToString("dd/MM/yyyy HH/mm");
				}
			}
			if (dsKliente.Tables[0].Rows.Count < 2)
				return dsKliente;
			DataSet dsKliente1 = dsKliente.Clone();
			dsKliente1.Tables[0].ImportRow(dsKliente.Tables[0].Rows[0]);
			for(int i = 0; i < dsKliente.Tables[0].Rows.Count - 1; i++)
			{
				int j = i + 1;
				DataRow dr = dsKliente.Tables[0].Rows[i];
				DataRow dr1 = dsKliente.Tables[0].Rows[j];
				DateTime dtDalje = Convert.ToDateTime(dr["DATA_DALJE"]);
				DateTime dtHyrje1 = Convert.ToDateTime(dr1["DATA_HYRJE"]);
				if (dr["DHOMA_EMRI"].ToString() == dr1["DHOMA_EMRI"].ToString() && dtDalje > dtHyrje1)
				{
					int count = dsKliente1.Tables[0].Rows.Count - 1;
					dsKliente1.Tables[0].Rows[count]["EMRI"] += Environment.NewLine + dr1["EMRI"];
					dsKliente1.Tables[0].Rows[count]["MBIEMRI"] += Environment.NewLine + dr1["MBIEMRI"];
					dsKliente1.Tables[0].Rows[count]["DATA_HYRJE_STR"] += Environment.NewLine + dr1["DATA_HYRJE_STR"];
					dsKliente1.Tables[0].Rows[count]["DATA_DALJE_STR"] += Environment.NewLine + dr1["DATA_DALJE_STR"];
				}
				else
				{
					dsKliente1.Tables[0].ImportRow(dsKliente.Tables[0].Rows[j]);
				}
			}
			return dsKliente1;
		}

		
		/// <summary>
		/// Hedh ne nje dataset te dhenat rreth klienteve te cilet iu perkasin grupeve, dhomave dhe grupeve
		/// perkatese. Hedh te dhenat rreth klienteve te cilet kane hyre dhe kane dale nga dhomat.
		/// Te dhenat grupohen ne varesi te grupeve
		/// </summary>
		/// <param name="grupi">Emri i grupit te cilit i perkasin</param>
		/// <param name="agjensia">Emri i agjensise se grupit</param>
		/// <param name="dtFillimi">Data e fillimit te kerkimit</param>
		/// <param name="dtMbarimi">Data e mbarimit te kerkimit</param>
		/// <returns></returns>
		public DataSet ShfaqGrupeDale(string grupi, string agjensia, DateTime dtFillimi, DateTime dtMbarimi)
		{
			DataSet dsGrupe = null;
			double difDite = 0;
			double difOre = 0;
			System.TimeSpan diff;
			DbController db = new DbController();
			// Marrim te gjitha te dhenat per grupet dhe klientet e tyre si dhe pagesat
			dsGrupe = db.Read("ShfaqGrupetEDale", grupi, agjensia, dtFillimi, dtMbarimi);
			dsGrupe.Tables[0].Columns.Add("PAGESA", typeof(Double));
			dsGrupe.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof (String));
			dsGrupe.Tables[0].Columns.Add("DATA_DALJE_STR", typeof(String));
			dsGrupe.AcceptChanges();
			foreach (DataRow dr in dsGrupe.Tables[0].Rows)
			{
				dr["EMRI"] += " " + dr["MBIEMRI"];
				diff = Convert.ToDateTime(dr["DATA_DALJE"]).Subtract(Convert.ToDateTime(dr["DATA_HYRJE"]));
				if ((Int32)dr["ID_KATEGORIA"] != 31)
				{
					difDite = Math.Round(diff.TotalDays);
					dr["PAGESA"] = difDite * Convert.ToDouble(dr["CMIMI"]);
					dr["DATA_HYRJE_STR"] = Convert.ToDateTime(dr["DATA_HYRJE"]).ToString("dd/MM/yyyy");
					dr["DATA_DALJE_STR"] = Convert.ToDateTime(dr["DATA_DALJE"]).ToString("dd/MM/yyyy");
				}
				else
				{
					difOre = diff.TotalHours;
					dr["PAGESA"] = difOre * Convert.ToDouble(dr["CMIMI"]);
					dr["DATA_HYRJE_STR"] = Convert.ToDateTime(dr["DATA_HYRJE"]).ToString("dd/MM/yyyy HH/mm");
					dr["DATA_DALJE_STR"] = Convert.ToDateTime(dr["DATA_DALJE"]).ToString("dd/MM/yyyy HH/mm");
				}
			}
			// Nese dataseti ka me 1 ose asnje rresht atehere nuk kemi se cfare te formatojme keshtu qe dil
			if (dsGrupe.Tables[0].Rows.Count < 2)
				return dsGrupe;
			DataSet dsGrupe1 = dsGrupe.Clone();
			dsGrupe1.Tables[0].ImportRow(dsGrupe.Tables[0].Rows[0]);
			for(int i = 0; i < dsGrupe.Tables[0].Rows.Count - 1; i++)
			{
				int j = i + 1;
				DataRow dr = dsGrupe.Tables[0].Rows[i];
				DataRow dr1 = dsGrupe.Tables[0].Rows[j];
				DateTime dtDalje = Convert.ToDateTime(dr["DATA_DALJE"]);
				DateTime dtHyrje1 = Convert.ToDateTime(dr1["DATA_HYRJE"]);
				if (dr["GRUPI"].ToString() == dr1["GRUPI"].ToString() && dtDalje > dtHyrje1)
				{
					int count = dsGrupe1.Tables[0].Rows.Count - 1;
					dsGrupe1.Tables[0].Rows[count]["EMRI"] += Environment.NewLine + dr1["EMRI"];
					dsGrupe1.Tables[0].Rows[count]["MBIEMRI"] += Environment.NewLine + dr1["MBIEMRI"];
					dsGrupe1.Tables[0].Rows[count]["DHOMA_EMRI"] +=Environment.NewLine + dr1["DHOMA_EMRI"];
					dsGrupe1.Tables[0].Rows[count]["DATA_HYRJE_STR"] += Environment.NewLine + dr1["DATA_HYRJE_STR"];
					dsGrupe1.Tables[0].Rows[count]["DATA_DALJE_STR"] += Environment.NewLine + dr1["DATA_DALJE_STR"];
				}
				else
				{
					dsGrupe1.Tables[0].ImportRow(dsGrupe.Tables[0].Rows[j]);
				}
			}
			return dsGrupe1;
		}

		/// <summary>
		/// Kthen nje vlere integer pasi kryen nxjerrjen e klienteve nga hoteli si edhe modifikimet e tyre
		/// </summary>
		/// <param name="">id e Grupit qe po kerkohet</param>
		/// <returns></returns>
		public int Dorezo( int skonto, int gjobe, int pergjegjes,int[] id_kliente,DateTime date_dorezimi)
		{
			int l = id_kliente.Length;
			int shuma = 0;
			DbController db;
			//modifikohet id_klienti
			for(int i = 0; i < l; i++)
			{
				db = new DbController();
				shuma = shuma + db.Update("NxirrNgaDhoma", id_kliente[i]);
			}
			for(int i = 0; i < l; i++)
			{
				db = new DbController();
				shuma = shuma + db.Update("ModifikoDateDalje",  date_dorezimi, id_kliente[i]);
			}
			db = new DbController();
			shuma = shuma + db.Update("AplikoSkontoGjobe", skonto, gjobe, pergjegjes);
			return shuma;
		}
		/// <summary>
		/// Per te gjithe klientet e hedhur ne vektor vendoset fusha 
		/// PAGUAR_DHOMA 1
		/// </summary>
		/// <param name="idKliente"></param>
		/// <returns></returns>
		public int PaguajDhome(int[] idKliente)
		{
			DbController db = new DbController();
			int shuma = 0;
			int l = idKliente.Length;
			for(int i = 0; i < l; i++)
			{
				shuma += db.Update("dbPaguajDhome", idKliente[i]);
			}
			return shuma;
		}
		#endregion

		#region Private Methods
		private string konverto(DateTime data)
		{
			string data_str = data.ToString();
			string dita, muaji, viti, ora;
			dita = data_str.Substring(8, 2);
			muaji = data_str.Substring(5, 2);
			viti = data_str.Substring(0, 4);
			ora =data_str.Substring(11);
			data_str = dita + "-" + muaji + "-" + viti + " " + ora;
			return data_str;
		}

		private string konvertoshkurt(DateTime data)
		{
			string data_str = data.ToString();
			string dita, muaji, viti;
			dita = data_str.Substring(8, 2);
			muaji = data_str.Substring(5, 2);
			viti = data_str.Substring(0, 4);
			data_str = dita + "-" + muaji + "-" + viti;
			return data_str;
		}

		private DataSet OrganizoDataSetPerKliente(DataSet ds)
		{
			if (ds.Tables[0].Rows.Count == 0 )
			{
				return ds;
			}
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATELINDJA_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_HYRJE_STRORE", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STRORE",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[7]);
				DateTime dataDalje = Convert.ToDateTime(dr[8]);
				DateTime datelindja = Convert.ToDateTime(dr[2]);
				dr["DATA_HYRJE_STR"] = this.konverto(dataHyrje);
				dr["DATA_DALJE_STR"] = this.konverto(dataDalje);
				dr["DATA_HYRJE_STRORE"] = this.konvertoshkurt(dataHyrje);
				dr["DATA_DALJE_STRORE"] = this.konvertoshkurt(dataDalje);
				dr["DATELINDJA_STR"] = this.konverto(datelindja);
			}
			ds.AcceptChanges();
			ds.EnforceConstraints = false;
			DataTable dt1 = ds.Tables[0].Clone();
			dt1.Rows.Clear();
			dt1.TableName = "KLIENTI";
			ds.Tables.Add(dt1);
			ds.Tables["KLIENTI"].Columns.Add("PERGJEGJES", typeof(Int32));
			ds.Tables["KLIENTI"].Columns.Add("ID_KLIENTI_STR", typeof(String));
			ds.Tables["KLIENTI"].Columns.Add("MINDATA", typeof(DateTime));
			ds.Tables["KLIENTI"].Columns.Add("MAXDATA", typeof(DateTime));
			ds.Tables["KLIENTI"].Columns.Add("KLIENT_HOTELI_STR", typeof(String));
			ds.Tables["KLIENTI"].Columns.Add("ID_REZERVIMI_STR", typeof(String));
			ds.AcceptChanges();
			DateTime maxDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["DATA_DALJE"]);
			for (int i = 0; i < ds.Tables[0].Rows.Count ; i++)
			{
				int kapari= 0;
				int skonto = 0;
				int gjoba = 0;
				int pergjegjes = 0;
				DataRow dt1Row = dt1.NewRow();
				DataRow drFirst = ds.Tables[0].Rows[i];
				DataRow drNext = ds.Tables[0].Rows[i];
				if (i < ds.Tables[0].Rows.Count - 1)
				{
					drNext = ds.Tables[0].Rows[i + 1];
				}
					
				// Te dhenat per dhomen
				dt1Row["ID_DHOMA"] = drFirst["ID_DHOMA"];
				dt1Row["ID_KLIENTI"] = drFirst["ID_KLIENTI"];
				dt1Row["ID_KLIENTI_STR"] = drFirst["ID_KLIENTI"].ToString();
				dt1Row["KLIENT_HOTELI"] = drFirst["KLIENT_HOTELI"];
				dt1Row["KLIENT_HOTELI_STR"] = drFirst["KLIENT_HOTELI"].ToString();
				dt1Row["ID_REZERVIMI"] = drFirst["ID_REZERVIMI"];
				dt1Row["ID_REZERVIMI_STR"] = drFirst["ID_REZERVIMI"].ToString();
				dt1Row["KAPARI"] = drFirst["KAPARI"];
				dt1Row["SKONTO"] = drFirst["SKONTO"];
				dt1Row["GJOBA"] = drFirst["GJOBA"];
				kapari = Convert.ToInt32(dt1Row["KAPARI"]);
				skonto = Convert.ToInt32(dt1Row["SKONTO"]);
				gjoba = Convert.ToInt32(dt1Row["GJOBA"]);
				bool ugjet = false;
				if (kapari != 0)
					ugjet = true;
				pergjegjes = Convert.ToInt32(dt1Row["ID_KLIENTI"]);
				// Te dhenat per klientet
				dt1Row["EMRI"] = drFirst["EMRI"].ToString() + " " + drFirst["MBIEMRI"];
				dt1Row["MBIEMRI"] = drFirst["MBIEMRI"];
				dt1Row["ADRESA"] = drFirst["ADRESA"];
				dt1Row["TELEFONI"] = drFirst["TELEFONI"];
				dt1Row["EMAIL"] = drFirst["EMAIL"];
				dt1Row["TARGA"] = drFirst["TARGA"];
				dt1Row["VENDLINDJA"] = drFirst["VENDLINDJA"];
				dt1Row["SHTETESIA"] = drFirst["SHTETESIA"];
				dt1Row["NR_IDENTIFIKIMI"] = drFirst["NR_IDENTIFIKIMI"];
				dt1Row["GRUPI"] = drFirst["GRUPI"];
				dt1Row["AGJENSIA"] = drFirst["AGJENSIA"];
				dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"];
				dt1Row["KAT_EMRI"] = drFirst["KAT_EMRI"];
				dt1Row["EMER_LLOJI"] = drFirst["EMER_LLOJI"];
				dt1Row["DATA_HYRJE_STR"] = drFirst["DATA_HYRJE_STR"];
				dt1Row["DATA_DALJE_STR"] = drFirst["DATA_DALJE_STR"];
				dt1Row["DATA_HYRJE_STRORE"] = drFirst["DATA_HYRJE_STRORE"];
				dt1Row["DATA_DALJE_STRORE"] = drFirst["DATA_DALJE_STRORE"];
				dt1Row["DATELINDJA_STR"] = drFirst["DATELINDJA_STR"];
				dt1Row["MINDATA"] = drFirst["DATA_HYRJE"];
				dt1Row["MAXDATA"] = drFirst["DATA_DALJE"];
				maxDate = Convert.ToDateTime( drFirst["DATA_DALJE"]);
				DateTime data_max = Convert.ToDateTime( drFirst["DATA_DALJE"]);
				while (maxDate >= Convert.ToDateTime(drNext["DATA_HYRJE"]) && (drFirst["ID_DHOMA"].ToString() == drNext["ID_DHOMA"].ToString()) && (i < ds.Tables[0].Rows.Count - 1))
				{
					if (data_max < Convert.ToDateTime(drNext["DATA_DALJE"]))
						data_max = Convert.ToDateTime(drNext["DATA_DALJE"]);
					dt1Row["ID_DHOMA"] = drFirst["ID_DHOMA"];
					dt1Row["ID_KLIENTI"] = drFirst["ID_KLIENTI"];
					dt1Row["ID_KLIENTI_STR"] += Environment.NewLine + drNext["ID_KLIENTI"].ToString();
					dt1Row["KLIENT_HOTELI"] = drFirst["KLIENT_HOTELI"];
					dt1Row["KLIENT_HOTELI_STR"] += Environment.NewLine + drNext["KLIENT_HOTELI"].ToString();
					dt1Row["ID_REZERVIMI"] = drFirst["ID_REZERVIMI"];
					dt1Row["ID_REZERVIMI_STR"] += Environment.NewLine + drNext["ID_REZERVIMI"].ToString();
					dt1Row["EMRI"] += Environment.NewLine + drNext["EMRI"].ToString() + " " + drNext["MBIEMRI"];
					dt1Row["MBIEMRI"] += Environment.NewLine + drNext["MBIEMRI"];
					dt1Row["ADRESA"] += Environment.NewLine + drNext["ADRESA"];
					dt1Row["TELEFONI"] += Environment.NewLine + drNext["TELEFONI"];
					dt1Row["EMAIL"] += Environment.NewLine + drNext["EMAIL"];
					dt1Row["TARGA"] += Environment.NewLine + drNext["TARGA"];
					dt1Row["VENDLINDJA"] += Environment.NewLine + drNext["VENDLINDJA"];
					dt1Row["SHTETESIA"] += Environment.NewLine + drNext["SHTETESIA"];
					dt1Row["NR_IDENTIFIKIMI"] += Environment.NewLine + drNext["NR_IDENTIFIKIMI"];
					dt1Row["GRUPI"] += Environment.NewLine + drNext["GRUPI"];
					dt1Row["AGJENSIA"] += Environment.NewLine + drNext["AGJENSIA"];
					dt1Row["KAT_EMRI"] += Environment.NewLine + drNext["KAT_EMRI"];
					dt1Row["EMER_LLOJI"] += Environment.NewLine + drNext["EMER_LLOJI"];
					dt1Row["DATA_HYRJE_STR"] += Environment.NewLine + drNext["DATA_HYRJE_STR"];
					dt1Row["DATA_DALJE_STR"] += Environment.NewLine + drNext["DATA_DALJE_STR"];
					dt1Row["DATA_HYRJE_STRORE"] += Environment.NewLine + drNext["DATA_HYRJE_STRORE"];
					dt1Row["DATA_DALJE_STRORE"] += Environment.NewLine + drNext["DATA_DALJE_STRORE"];
					dt1Row["DATELINDJA_STR"] += Environment.NewLine + drNext["DATELINDJA_STR"];
					kapari = kapari + Convert.ToInt32(drNext["KAPARI"]);
					skonto = skonto + Convert.ToInt32(drNext["SKONTO"]);
					gjoba = gjoba + Convert.ToInt32(drNext["GJOBA"]);
					if ((!ugjet) && (Convert.ToInt32(drNext["KAPARI"]) != 0))
					{
						pergjegjes = Convert.ToInt32(drNext["ID_KLIENTI"]);
						ugjet = true;
					}
					int max = DateTime.Compare(Convert.ToDateTime(drFirst["DATA_DALJE"]), Convert.ToDateTime(drNext["DATA_DALJE"]));
					if (max >= 0)
						maxDate = Convert.ToDateTime(drFirst["DATA_DALJE"]);
					else
						maxDate = Convert.ToDateTime(drNext["DATA_DALJE"]);
					i++;
					if (i < ds.Tables[0].Rows.Count - 1)
					{
						drFirst = ds.Tables[0].Rows[i];
						drNext = ds.Tables[0].Rows[i + 1];
					}
				}
				dt1Row["KAPARI"] = kapari;
				dt1Row["GJOBA"] = gjoba;
				dt1Row["SKONTO"] = skonto;
				dt1Row["PERGJEGJES"] = pergjegjes;
				dt1.Rows.Add(dt1Row);
			}
			return ds;
		}

		private DataSet OrganizoDataSetPerGrup(DataSet ds)
		{
			if (ds.Tables[0].Rows.Count == 0)
			{
				return ds;
			}
			ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATELINDJA_STR",typeof(String));
			ds.Tables[0].Columns.Add("DATA_HYRJE_STRORE", typeof(String));
			ds.Tables[0].Columns.Add("DATA_DALJE_STRORE",typeof(String));
			foreach(DataRow dr in ds.Tables[0].Rows)
			{
				DateTime dataHyrje = Convert.ToDateTime(dr[7]);
				DateTime dataDalje = Convert.ToDateTime(dr[8]);
				DateTime datelindja = Convert.ToDateTime(dr[2]);
				dr["DATA_HYRJE_STR"] = this.konverto(dataHyrje);
				dr["DATA_DALJE_STR"] = this.konverto(dataDalje);
				dr["DATA_HYRJE_STRORE"] = this.konvertoshkurt(dataHyrje);
				dr["DATA_DALJE_STRORE"] = this.konvertoshkurt(dataDalje);
				dr["DATELINDJA_STR"] = this.konverto(datelindja);
			}
			ds.AcceptChanges();
			ds.EnforceConstraints = false;
			DataTable dt1 = ds.Tables[0].Clone();
			dt1.Rows.Clear();
			dt1.TableName = "KLIENTI";
			ds.Tables.Add(dt1);
			ds.Tables["KLIENTI"].Columns.Add("ID_DHOMA_STR", typeof(String));
			ds.Tables["KLIENTI"].Columns.Add("ID_KLIENTI_STR", typeof(String));
			ds.Tables["KLIENTI"].Columns.Add("PERGJEGJES", typeof(Int32));
			ds.Tables["KLIENTI"].Columns.Add("MINDATA", typeof(DateTime));
			ds.Tables["KLIENTI"].Columns.Add("MAXDATA", typeof(DateTime));
			ds.Tables["KLIENTI"].Columns.Add("KLIENT_HOTELI_STR", typeof(String));
			ds.Tables["KLIENTI"].Columns.Add("ID_REZERVIMI_STR", typeof(String));
			ds.AcceptChanges();
			DateTime maxDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["DATA_DALJE"]);
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				int kapari= 0;
				int skonto = 0;
				int gjoba = 0;
				int pergjegjes = 0;
				DataRow dt1Row = dt1.NewRow();
				DataRow drFirst = ds.Tables[0].Rows[i];
				DataRow drNext = ds.Tables[0].Rows[i];
				if (i < ds.Tables[0].Rows.Count - 1)
				{
					drNext = ds.Tables[0].Rows[i + 1];
				}
				// Te dhenat per dhomen
				dt1Row["ID_KLIENTI"] = drFirst["ID_KLIENTI"];
				dt1Row["ID_KLIENTI_STR"]  = drFirst["ID_KLIENTI"].ToString();
				dt1Row["KLIENT_HOTELI"] = drFirst["KLIENT_HOTELI"];
				dt1Row["KLIENT_HOTELI_STR"] = drFirst["KLIENT_HOTELI"].ToString();
				dt1Row["ID_REZERVIMI"] = drFirst["ID_REZERVIMI"];
				dt1Row["ID_REZERVIMI_STR"] = drFirst["ID_REZERVIMI"].ToString();
				dt1Row["ID_DHOMA"] = drFirst["ID_DHOMA"];
				dt1Row["ID_DHOMA_STR"]  = drFirst["ID_DHOMA"].ToString();
				dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"];
				dt1Row["KAPARI"] = drFirst["KAPARI"];
				dt1Row["SKONTO"] = drFirst["SKONTO"];
				dt1Row["GJOBA"] = drFirst["GJOBA"];
				kapari = Convert.ToInt32(dt1Row["KAPARI"]);
				skonto = Convert.ToInt32(dt1Row["SKONTO"]);
				gjoba = Convert.ToInt32(dt1Row["GJOBA"]);
				bool ugjet = false;
				if (kapari != 0)
					ugjet = true;
				pergjegjes = Convert.ToInt32(dt1Row["ID_KLIENTI"]);
				// Te dhenat per klientet
				dt1Row["EMRI"] = drFirst["EMRI"].ToString() + " " + drFirst["MBIEMRI"];
				dt1Row["MBIEMRI"] = drFirst["MBIEMRI"];
				dt1Row["ADRESA"] = drFirst["ADRESA"];
				dt1Row["TELEFONI"] = drFirst["TELEFONI"];
				dt1Row["EMAIL"] = drFirst["EMAIL"];
				dt1Row["TARGA"] = drFirst["TARGA"];
				dt1Row["VENDLINDJA"] = drFirst["VENDLINDJA"];
				dt1Row["SHTETESIA"] = drFirst["SHTETESIA"];
				dt1Row["NR_IDENTIFIKIMI"] = drFirst["NR_IDENTIFIKIMI"];
				dt1Row["GRUPI"] = drFirst["GRUPI"];
				dt1Row["ID_GRUPI"] = drFirst["ID_GRUPI"];
				dt1Row["AGJENSIA"] = drFirst["AGJENSIA"];
				dt1Row["KAT_EMRI"] = drFirst["KAT_EMRI"];
				dt1Row["EMER_LLOJI"] = drFirst["EMER_LLOJI"];
				dt1Row["DATA_HYRJE_STR"] = drFirst["DATA_HYRJE_STR"];
				dt1Row["DATA_DALJE_STR"] = drFirst["DATA_DALJE_STR"];
				dt1Row["DATA_HYRJE_STRORE"] = drFirst["DATA_HYRJE_STRORE"];
				dt1Row["DATA_DALJE_STRORE"] = drFirst["DATA_DALJE_STRORE"];
				dt1Row["DATELINDJA_STR"] = drFirst["DATELINDJA_STR"];
				dt1Row["MINDATA"] = drFirst["DATA_HYRJE"];
				dt1Row["MAXDATA"] = drFirst["DATA_DALJE"];
				maxDate = Convert.ToDateTime( drFirst["DATA_DALJE"]);
				DateTime data_max = Convert.ToDateTime( drFirst["DATA_DALJE"]);
				while (maxDate >= Convert.ToDateTime(drNext["DATA_HYRJE"]) && (drFirst["GRUPI"].ToString() == drNext["GRUPI"].ToString()) && (i < ds.Tables[0].Rows.Count - 1))
				{
					if (data_max < Convert.ToDateTime(drNext["DATA_DALJE"]))
						data_max = Convert.ToDateTime(drNext["DATA_DALJE"]);
					dt1Row["GRUPI"] = drFirst["GRUPI"].ToString();
					dt1Row["AGJENSIA"] = drFirst["AGJENSIA"].ToString();
					dt1Row["ID_KLIENTI_STR"] += Environment.NewLine + drNext["ID_KLIENTI"].ToString();
					dt1Row["KLIENT_HOTELI"] = drFirst["KLIENT_HOTELI"];
					dt1Row["KLIENT_HOTELI_STR"] += Environment.NewLine + drNext["KLIENT_HOTELI"].ToString();
					dt1Row["ID_REZERVIMI"] = drFirst["ID_REZERVIMI"];
					dt1Row["ID_REZERVIMI_STR"] += Environment.NewLine + drNext["ID_REZERVIMI"].ToString();
					dt1Row["ID_DHOMA_STR"] += Environment.NewLine + drNext["ID_DHOMA"].ToString();
					dt1Row["DHOMA_EMRI"] += Environment.NewLine + drNext["DHOMA_EMRI"].ToString();
					dt1Row["EMRI"] += Environment.NewLine + drNext["EMRI"].ToString() + " " + drNext["MBIEMRI"];
					dt1Row["MBIEMRI"] += Environment.NewLine + drNext["MBIEMRI"];
					dt1Row["ADRESA"] += Environment.NewLine + drNext["ADRESA"];
					dt1Row["TELEFONI"] += Environment.NewLine + drNext["TELEFONI"];
					dt1Row["EMAIL"] += Environment.NewLine + drNext["EMAIL"];
					dt1Row["TARGA"] += Environment.NewLine + drNext["TARGA"];
					dt1Row["VENDLINDJA"] += Environment.NewLine + drNext["VENDLINDJA"];
					dt1Row["SHTETESIA"] += Environment.NewLine + drNext["SHTETESIA"];
					dt1Row["NR_IDENTIFIKIMI"] += Environment.NewLine + drNext["NR_IDENTIFIKIMI"];
					dt1Row["KAT_EMRI"] += Environment.NewLine + drNext["KAT_EMRI"];
					dt1Row["EMER_LLOJI"] += Environment.NewLine + drNext["EMER_LLOJI"];
					dt1Row["DATA_HYRJE_STR"] += Environment.NewLine + drNext["DATA_HYRJE_STR"];
					dt1Row["DATA_DALJE_STR"] += Environment.NewLine + drNext["DATA_DALJE_STR"];
					dt1Row["DATA_HYRJE_STRORE"] += Environment.NewLine + drNext["DATA_HYRJE_STRORE"];
					dt1Row["DATA_DALJE_STRORE"] += Environment.NewLine + drNext["DATA_DALJE_STRORE"];
					dt1Row["DATELINDJA_STR"] += Environment.NewLine + drNext["DATELINDJA_STR"];
					kapari = kapari + Convert.ToInt32(drNext["KAPARI"]);
					skonto = skonto + Convert.ToInt32(drNext["SKONTO"]);
					gjoba = gjoba + Convert.ToInt32(drNext["GJOBA"]);
					if ((!ugjet) && (Convert.ToInt32(drNext["KAPARI"]) != 0))
					{
						pergjegjes = Convert.ToInt32(drNext["ID_KLIENTI"]);
						ugjet = true;
					}
					int max = DateTime.Compare(Convert.ToDateTime(drFirst["DATA_DALJE"]), Convert.ToDateTime(drNext["DATA_DALJE"]));
					if (max > 0)
						maxDate = Convert.ToDateTime(drFirst["DATA_DALJE"]);
					else
						maxDate = Convert.ToDateTime(drNext["DATA_DALJE"]);
					i++;
					if (i < ds.Tables[0].Rows.Count - 1)
					{
						drFirst = ds.Tables[0].Rows[i];
						drNext = ds.Tables[0].Rows[i + 1];
					}
				}
				dt1Row["KAPARI"] = kapari;
				dt1Row["GJOBA"] = gjoba;
				dt1Row["SKONTO"] = skonto;
				dt1Row["PERGJEGJES"] = pergjegjes;
				dt1Row["MAXDATA"] = data_max;
				dt1.Rows.Add(dt1Row);
			}
			return ds;
		}

		private DataSet OrganizoDataSetPerGrupPerModifikim(DataSet ds)
		{
			try
			{
				if (ds.Tables[0].Rows.Count == 0)
				{
					return ds;
				}
				ds.Tables[0].Columns.Add("DATA_HYRJE_STR", typeof(String));
				ds.Tables[0].Columns.Add("DATA_DALJE_STR",typeof(String));
				ds.Tables[0].Columns.Add("DATELINDJA_STR",typeof(String));
				ds.Tables[0].Columns.Add("DATA_HYRJE_STRORE", typeof(String));
				ds.Tables[0].Columns.Add("DATA_DALJE_STRORE",typeof(String));
				foreach(DataRow dr in ds.Tables[0].Rows)
				{
					DateTime dataHyrje = Convert.ToDateTime(dr[7]);
					DateTime dataDalje = Convert.ToDateTime(dr[8]);
					DateTime datelindja = Convert.ToDateTime(dr[2]);
					dr["DATA_HYRJE_STR"] = this.konverto(dataHyrje);
					dr["DATA_DALJE_STR"] = this.konverto(dataDalje);
					dr["DATA_HYRJE_STRORE"] = this.konvertoshkurt(dataHyrje);
					dr["DATA_DALJE_STRORE"] = this.konvertoshkurt(dataDalje);
					dr["DATELINDJA_STR"] = this.konverto(datelindja);
				}
				ds.AcceptChanges();
				ds.EnforceConstraints = false;
				DataTable dt1 = ds.Tables[0].Clone();
				dt1.Rows.Clear();
				dt1.TableName = "KLIENTI";
				ds.Tables.Add(dt1);
				ds.Tables["KLIENTI"].Columns.Add("ID_DHOMA_STR", typeof(String));
				ds.Tables["KLIENTI"].Columns.Add("ID_KLIENTI_STR", typeof(String));
				ds.Tables["KLIENTI"].Columns.Add("PERGJEGJES", typeof(Int32));
				ds.Tables["KLIENTI"].Columns.Add("MINDATA", typeof(DateTime));
				ds.Tables["KLIENTI"].Columns.Add("MAXDATA", typeof(DateTime));
				ds.Tables["KLIENTI"].Columns.Add("KLIENT_HOTELI_STR", typeof(String));
				ds.Tables["KLIENTI"].Columns.Add("ID_REZERVIMI_STR", typeof(String));
				ds.AcceptChanges();
				DateTime maxDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["DATA_DALJE"]);
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					int kapari= 0;
					int skonto = 0;
					int gjoba = 0;
					int pergjegjes = 0;
					DataRow dt1Row = dt1.NewRow();
					DataRow drFirst = ds.Tables[0].Rows[i];
					DataRow drNext = ds.Tables[0].Rows[i];
					if (i < ds.Tables[0].Rows.Count - 1)
					{
						drNext = ds.Tables[0].Rows[i + 1];
					}
					// Te dhenat per dhomen
					dt1Row["ID_KLIENTI"] = drFirst["ID_KLIENTI"];
					dt1Row["ID_KLIENTI_STR"]  = drFirst["ID_KLIENTI"].ToString();
					dt1Row["KLIENT_HOTELI"] = drFirst["KLIENT_HOTELI"];
					dt1Row["KLIENT_HOTELI_STR"] = drFirst["KLIENT_HOTELI"].ToString();
					dt1Row["ID_REZERVIMI"] = drFirst["ID_REZERVIMI"];
					dt1Row["ID_REZERVIMI_STR"] = drFirst["ID_REZERVIMI"].ToString();
					dt1Row["ID_DHOMA"] = drFirst["ID_DHOMA"];
					dt1Row["ID_DHOMA_STR"]  = drFirst["ID_DHOMA"].ToString();
					dt1Row["DHOMA_EMRI"] = drFirst["DHOMA_EMRI"];
					dt1Row["KAPARI"] = drFirst["KAPARI"];
					dt1Row["SKONTO"] = drFirst["SKONTO"];
					dt1Row["GJOBA"] = drFirst["GJOBA"];
					kapari = Convert.ToInt32(dt1Row["KAPARI"]);
					skonto = Convert.ToInt32(dt1Row["SKONTO"]);
					gjoba = Convert.ToInt32(dt1Row["GJOBA"]);
					bool ugjet = false;
					if (kapari != 0)
						ugjet = true;
					pergjegjes = Convert.ToInt32(dt1Row["ID_KLIENTI"]);
					// Te dhenat per klientet
					dt1Row["EMRI"] = drFirst["EMRI"].ToString() + " " + drFirst["MBIEMRI"];
					dt1Row["MBIEMRI"] = drFirst["MBIEMRI"];
					dt1Row["ADRESA"] = drFirst["ADRESA"];
					dt1Row["TELEFONI"] = drFirst["TELEFONI"];
					dt1Row["EMAIL"] = drFirst["EMAIL"];
					dt1Row["TARGA"] = drFirst["TARGA"];
					dt1Row["VENDLINDJA"] = drFirst["VENDLINDJA"];
					dt1Row["SHTETESIA"] = drFirst["SHTETESIA"];
					dt1Row["NR_IDENTIFIKIMI"] = drFirst["NR_IDENTIFIKIMI"];
					dt1Row["GRUPI"] = drFirst["GRUPI"];
					dt1Row["ID_GRUPI"] = drFirst["ID_GRUPI"];
					dt1Row["AGJENSIA"] = drFirst["AGJENSIA"];
					dt1Row["KAT_EMRI"] = drFirst["KAT_EMRI"];
					dt1Row["EMER_LLOJI"] = drFirst["EMER_LLOJI"];
					dt1Row["DATA_HYRJE_STR"] = drFirst["DATA_HYRJE_STR"];
					dt1Row["DATA_DALJE_STR"] = drFirst["DATA_DALJE_STR"];
					dt1Row["DATA_HYRJE_STRORE"] = drFirst["DATA_HYRJE_STRORE"];
					dt1Row["DATA_DALJE_STRORE"] = drFirst["DATA_DALJE_STRORE"];
					dt1Row["DATELINDJA_STR"] = drFirst["DATELINDJA_STR"];
					dt1Row["MINDATA"] = drFirst["DATA_HYRJE"];
					dt1Row["MAXDATA"] = drFirst["DATA_DALJE"];
					maxDate = Convert.ToDateTime( drFirst["DATA_DALJE"]);
					DateTime data_max = Convert.ToDateTime( drFirst["DATA_DALJE"]);
					bool neHotel = false;
					while (maxDate >= Convert.ToDateTime(drNext["DATA_HYRJE"]) && (drFirst["GRUPI"].ToString() == drNext["GRUPI"].ToString()) && (i < ds.Tables[0].Rows.Count - 1))
					{
						if (data_max < Convert.ToDateTime(drNext["DATA_DALJE"]))
							data_max = Convert.ToDateTime(drNext["DATA_DALJE"]);
						dt1Row["GRUPI"] = drFirst["GRUPI"].ToString();
						dt1Row["AGJENSIA"] = drFirst["AGJENSIA"].ToString();
						dt1Row["ID_KLIENTI_STR"] += Environment.NewLine + drNext["ID_KLIENTI"].ToString();
						dt1Row["KLIENT_HOTELI"] = drFirst["KLIENT_HOTELI"];
						if (!neHotel)
							if (Convert.ToInt32(dt1Row["KLIENT_HOTELI"]) == 1)
								neHotel = true;
						dt1Row["KLIENT_HOTELI_STR"] += Environment.NewLine + drNext["KLIENT_HOTELI"].ToString();
						dt1Row["ID_DHOMA_STR"] += Environment.NewLine + drNext["ID_DHOMA"].ToString();
						dt1Row["ID_REZERVIMI"] = drFirst["ID_REZERVIMI"];
						dt1Row["ID_REZERVIMI_STR"] += Environment.NewLine + drNext["ID_REZERVIMI"].ToString();
						dt1Row["DHOMA_EMRI"] += Environment.NewLine + drNext["DHOMA_EMRI"].ToString();
						dt1Row["EMRI"] += Environment.NewLine + drNext["EMRI"].ToString() + " " + drNext["MBIEMRI"];
						dt1Row["MBIEMRI"] += Environment.NewLine + drNext["MBIEMRI"];
						dt1Row["ADRESA"] += Environment.NewLine + drNext["ADRESA"];
						dt1Row["TELEFONI"] += Environment.NewLine + drNext["TELEFONI"];
						dt1Row["EMAIL"] += Environment.NewLine + drNext["EMAIL"];
						dt1Row["TARGA"] += Environment.NewLine + drNext["TARGA"];
						dt1Row["VENDLINDJA"] += Environment.NewLine + drNext["VENDLINDJA"];
						dt1Row["SHTETESIA"] += Environment.NewLine + drNext["SHTETESIA"];
						dt1Row["NR_IDENTIFIKIMI"] += Environment.NewLine + drNext["NR_IDENTIFIKIMI"];
						dt1Row["KAT_EMRI"] += Environment.NewLine + drNext["KAT_EMRI"];
						dt1Row["EMER_LLOJI"] += Environment.NewLine + drNext["EMER_LLOJI"];
						dt1Row["DATA_HYRJE_STR"] += Environment.NewLine + drNext["DATA_HYRJE_STR"];
						dt1Row["DATA_DALJE_STR"] += Environment.NewLine + drNext["DATA_DALJE_STR"];
						dt1Row["DATA_HYRJE_STRORE"] += Environment.NewLine + drNext["DATA_HYRJE_STRORE"];
						dt1Row["DATA_DALJE_STRORE"] += Environment.NewLine + drNext["DATA_DALJE_STRORE"];
						dt1Row["DATELINDJA_STR"] += Environment.NewLine + drNext["DATELINDJA_STR"];
						kapari = kapari + Convert.ToInt32(drNext["KAPARI"]);
						skonto = skonto + Convert.ToInt32(drNext["SKONTO"]);
						gjoba = gjoba + Convert.ToInt32(drNext["GJOBA"]);
						if ((!ugjet) && (Convert.ToInt32(drNext["KAPARI"]) != 0))
						{
							pergjegjes = Convert.ToInt32(drNext["ID_KLIENTI"]);
							ugjet = true;
						}
						int max = DateTime.Compare(Convert.ToDateTime(drFirst["DATA_DALJE"]), Convert.ToDateTime(drNext["DATA_DALJE"]));
						if (max > 0)
							maxDate = Convert.ToDateTime(drFirst["DATA_DALJE"]);
						else
							maxDate = Convert.ToDateTime(drNext["DATA_DALJE"]);
						i++;
						if (i < ds.Tables[0].Rows.Count - 1)
						{
							drFirst = ds.Tables[0].Rows[i];
							drNext = ds.Tables[0].Rows[i + 1];
						}
					}
					if (!neHotel)
						if (Convert.ToInt32(dt1Row["KLIENT_HOTELI"]) == 1)
							neHotel = true;
					dt1Row["KAPARI"] = kapari;
					dt1Row["GJOBA"] = gjoba;
					dt1Row["SKONTO"] = skonto;
					dt1Row["PERGJEGJES"] = pergjegjes;
					dt1Row["MAXDATA"] = data_max;
					if (neHotel)
						dt1.Rows.Add(dt1Row);
				}
				return ds;
			}
			catch(Exception ex)
			{
				return new DataSet();
			}

		}
		
		#endregion
	}
}
