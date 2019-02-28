using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace HotelManagment.BusDatService
{
	/// <summary>
	/// Summary description for Perkthime.
	/// </summary>
	public class PerkthimeClass
	{
		public PerkthimeClass()
		{
			//
			// Ne konstruktor nuk bejme asnje inicializim
			//
		}

		/// <summary>
		/// 1) Merr detyrimet qe jane ne DataBase, shoqeron per detyrimet e marra perkthimet.
		/// 2) Merr shenimet e dhena nga skedari Informacione ne Xml dhe i hedh ne dataset
		/// </summary>
		/// <returns>DataSetin e plote me te gjitha perkthimet e dhena deri tani</returns>
		public DataSet ShfaqPerkthimet()
		{
			DbController db = new DbController();
			// Ne fillim marrim te gjitha llojet e detyrimeve qe jane ne DataBase
			DataSet dsDetyrime = db.Read("dbShfaqLlojetDetyrime");
			DataSet dsPerkthime = new DataSet();
			if (!File.Exists(Application.StartupPath + "\\Perkthime.xml"))
			{
				// Nese skedari xml Perkthime nuk ekziston atehere krijoje dhe shto edhe fushat e duhura
				dsPerkthime.Tables.Add("Perkthime");
				dsPerkthime.Tables[0].Columns.Add("ID", typeof(String));
				dsPerkthime.Tables[0].Columns.Add("Shqip", typeof(String));
				dsPerkthime.Tables[0].Columns.Add("Anglisht", typeof(String));
				dsPerkthime.Tables[0].Columns.Add("Italisht", typeof(String));
				dsPerkthime.Tables[0].Columns.Add("Frengjisht", typeof(String));
				dsPerkthime.Tables[0].Columns.Add("Lloji", typeof(String));
				dsPerkthime.Tables.Add("Gjuha");
				dsPerkthime.Tables[1].Columns.Add("Gjuhe", typeof(String));
				DataRow drGjuha = dsPerkthime.Tables[1].NewRow();
				drGjuha[0] = "Shqip";
				dsPerkthime.Tables[1].Rows.Add(drGjuha);
				dsPerkthime.AcceptChanges();
				dsPerkthime.WriteXml(Application.StartupPath + "\\Perkthime.xml", XmlWriteMode.WriteSchema);
			}
			else
			{
				// Perndryshe, nese ekziston lexo kete skedar dhe hidhe ne dsPerkthime
				dsPerkthime.ReadXml(Application.StartupPath + "\\Perkthime.xml");
			}
			DataSet ds = dsPerkthime.Copy();
			ds.Tables[0].Rows.Clear();
			// Shtojme nje kolone te re Lloji e cila sherben per grupimin e fushave ne griden e
			// perkthimeve. Do te kete tre vlera, Detyrime, Shpenzime dhe Mesazhe
			//ds.Tables[0].Columns.Add("Lloji", typeof(String));
			foreach (DataRow drDetyrime in dsDetyrime.Tables[0].Rows)
			{
				DataRow dr = ds.Tables[0].NewRow();
				if (dsPerkthime.Tables[0].Select("ID = '" + Convert.ToString(drDetyrime[0]) + "'").Length == 0)
				{
					// Nese lloj_detyrimi nuk gjendet ne skedarin xml, atehere hidhe kete detyrim
					// duke vendosur vetem tekstin shqip dhe id-ne e tij
					dr[0] = drDetyrime[0].ToString();
					dr[1] = drDetyrime[1].ToString();
				}
				else
				{
					// Perndryshe nese detyrimi gjendet ne skedar xml, atehere hidh edhe perkthimet
					DataRow drPerkthime = (DataRow)dsPerkthime.Tables[0].Select("ID = '" 
						+ drDetyrime[0].ToString() + "'").GetValue(0);
					dr[0] = drDetyrime[0].ToString();
					dr[1] = drDetyrime[1].ToString();
					dr[2] = drPerkthime[2].ToString();
					dr[3] = drPerkthime[3].ToString();
					dr[4] = drPerkthime[4].ToString();
				}
				dr[5] = "Detyrime";
				ds.Tables[0].Rows.Add(dr);
			}
			// Heqim dsDetyrime nga memorja
			dsDetyrime.Dispose();
			// Lexojme nga skedari Xml Informacione edhe mesazhet e falenderimit dhe te qendrimit ne hotel
			// dhe bashke me to edhe perkthimet
			DataSet dsInformacione = new DataSet();
			dsInformacione.ReadXml(Application.StartupPath + "\\Informacione.xml");
			DataRow dr1 = ds.Tables[0].NewRow();
			if (dsPerkthime.Tables[0].Select("ID = 'MesazhQendrimi'").Length == 0)
			{
				dr1[0] = "MesazhQendrimi";
				dr1[1] = dsInformacione.Tables[0].Rows[0][6];
				dr1[2] = "";
				dr1[3] = "";
				dr1[4] = "";
			}
			else
			{
				DataRow drMesazh = (DataRow)dsPerkthime.Tables[0].Select("ID = 'MesazhQendrimi'").GetValue(0);
				dr1[0] = "MesazhQendrimi";
				dr1[1] = dsInformacione.Tables[0].Rows[0][6];
				dr1[2] = drMesazh[2];
				dr1[3] = drMesazh[3];
				dr1[4] = drMesazh[4];
			}
			dr1[5] = "Mesazhe";
			ds.Tables[0].Rows.Add(dr1);
			DataRow dr2 = ds.Tables[0].NewRow();
			if (dsPerkthime.Tables[0].Select("ID = 'MesazhRezervimi'").Length == 0)
			{
				dr2[0] = "MesazhRezervimi";
				dr2[1] = dsInformacione.Tables[0].Rows[0][7];
				dr2[2] = "";
				dr2[3] = "";
				dr2[4] = "";
			}
			else
			{
				DataRow drMesazh = (DataRow)dsPerkthime.Tables[0].Select("ID = 'MesazhRezervimi'").GetValue(0);
				dr2[0] = "MesazhRezervimi";
				dr2[1] = dsInformacione.Tables[0].Rows[0][7];
				dr2[2] = drMesazh[2];
				dr2[3] = drMesazh[3];
				dr2[4] = drMesazh[4];
			}
			dr2[5] = "Mesazhe";
			ds.Tables[0].Rows.Add(dr2);
			return ds;
		}
	}
}
