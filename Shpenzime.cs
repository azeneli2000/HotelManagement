using System;
using System.Data.SqlClient;
using HotelManagment.BusDatService;
namespace HotelManagment.BusDatService
{
	/// <summary>
	/// 
	/// </summary>
	public class Shpenzime
	{
		
		
			public DateTime dateShpenzimi ;
			public int      sasiaShpenzimi = 0;
			public string   emriShpenzimi = "null";

			#region constructors
			public Shpenzime()
			{
				// 
				// TODO: Add constructor logic here
				//
			}
			public Shpenzime(DateTime dateShpenzimi , int sasiaShpenzimi, string emriShpenzimi)
			{
				this.dateShpenzimi = dateShpenzimi;
				this.sasiaShpenzimi = sasiaShpenzimi;
				this.emriShpenzimi = emriShpenzimi;
			}
			#endregion constructors
	
			#region public methods
			/// <summary>
			/// krijo nje shpenzim bazuar ne atributet e klases
			/// </summary>
			/// <returns>int</returns>
			public int KrijoShpenzim()
			{
				int p = 0;
				string var = "dbKrijoShpenzim";
				DbController db = new DbController();
				p = db.Create(var,dateShpenzimi,sasiaShpenzimi,emriShpenzimi);
				return p;
			}
			/// <summary>
			/// merr si parameter nje idShpenzimi dhe modifikon karakteristikat e shpenzimit perkates ne baze te atribueteve te klases.
			/// </summary>
			/// <param name="idShpenzimi"></param>
			/// <returns>int</returns>
			public int  ModifikoShpenzim(int idShpenzimi)
			{
				int p = 0;
				string var = "dbModifikoShpenzim";
				DbController db = new DbController();
				p= db.Update(var,idShpenzimi,dateShpenzimi,sasiaShpenzimi,emriShpenzimi);
				return p;
			}
			/// <summary>
			/// nje idShpenzimi dhe fshin shpenzimin korrespondent
			/// </summary>
			/// <param name="idShpenzimi"></param>
			/// <returns></returns>
			public int  FshiShpenzim(int idShpenzimi)
			{
				int p = 0;
				string var = "dbFshiShpenzim";
				DbController db = new DbController();
				p = db.Delete(var,idShpenzimi);
				return p;
			}
			/// <summary>
			/// merr si paramatra nje date fillimi dhe nje date mbarimi 
			/// dhe kthen nje numer qe eshte shuma e shpenzimeve qe jane bere nga data e fillimit ne ate te mbarimit
			/// </summary>
			/// <param name="dtFillimi"></param>
			/// <param name="dtMbarimi"></param>
			/// <returns>int</returns>
			public int  NxirrShpenzim(DateTime dtFillimi, DateTime  dtMbarimi)
			{
				int [] sasia = null;
				int i = 0;	
				int k = 1;
				bool j = false;
				int shumaShpenzimi;
				string var = "dbNxirrShpenzim";
				DbController db = new DbController();
				///SqlDataReader dataReader = db.Read(var,dtFillimi);
			///	while (dataReader.Read())
				///{
				///	i++;
				///}
				int n = i;

				sasia = new int [n];
				///sasia [0] = dataReader.GetInt32(0);
				while (j == false)
				{
					System.DateTime current = dtFillimi.AddDays(i);					   
					j = System.DateTime.Equals(dtFillimi,dtMbarimi);
					///SqlDataReader data1Reader = db.Read(var,current);
					///while(data1Reader.Read())
					///{
					///	sasia[i] = dataReader.GetInt32(2);
					///	k++;  
					///}
				}
				
				///SqlDataReader data2Reader = db.Read(var,dtMbarimi);
				
				//sasia[n] = data2Reader.GetInt32(2);
				///llogaritet sasia per cdo date ne intervalin e datave 
				///dhe ne fund bejme shumen e vektorit te sasive
			
				shumaShpenzimi = this.Sum(sasia);
				return shumaShpenzimi;
			
			}
			#endregion public methods
			private int Sum(int []a)
			{
			
				int result = 0;
				int i=0;
				while(i < a.Length)
				{
					result += a[i];
					i++;
				}
				return result;
			}
		}
	}