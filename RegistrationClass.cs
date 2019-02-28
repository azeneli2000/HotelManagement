using System;
using System.Xml;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Management;
using HotelManagment.BusDatService;

namespace HotelManagment
{
	/// <summary>
	/// Klase qe mban funksionet e regjistrimit te programit si metoda statike
	/// </summary>
	public sealed class RegistrationClass
	{
		#region Private fields
		private static string path = "\\Software\\VisionInfoSolution\\HotelManagment";
		private static string name = "Key";
		private static byte[] key = Encoding.ASCII.GetBytes("Vetem Zotit i perulem");
		private static string dateInstalledFilePath = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\conn.4343.sys";

		#endregion

		#region Public Methods
		/// <summary>
		/// Kontrollon nese Celesi i Hotel Manager, i ruajtur ne rregjistra eshte i vlefshem per versionin FULL
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static bool CelesVlefshem()
		{
			int roomsCount = DecryptRoomsCountFull();
			string encrypted = EncryptKeyDemo(roomsCount);
			string decrypted = DecryptKeyFull();
			if (decrypted == encrypted)
				return true;
			return false;
		}

		/// <summary>
		/// Lexon numrin serial nga rregjistrat
		/// </summary>
		/// <returns></returns>
		public static string GetKey()
		{
			return GetKeyValue(path, name);
		}


		/// <summary>
		/// Lexon numrin serial nga rregjistrat dhe nga ky numer, ne baze te algoritmit,
		/// nxjerr numrin e dhomave
		/// </summary>
		/// <returns></returns>
		public static int GetRoomsCount()
		{
			try
			{
				string keyValue = GetKeyValue(path, name);
				string[] splitKey = keyValue.Split(new char[] { '-' });
				if (splitKey.Length >= 2)
				{
					int roomNumber = Convert.ToInt32(splitKey.GetValue(splitKey.Length - 1));
					roomNumber = (roomNumber / 3) - 4;
					return roomNumber;
				}
				// Nese versioni nuk eshte demo, atehere do te thote qe eshte full keshtu qe bejme
				// deshifrimin per vleren e gjetur
				return Convert.ToInt32(RegistrationClass.DecryptRoomsCountFull());
			}
			catch
			{
				return 0;
			}
		}


		/// <summary>
		/// Kontrollon nese Hotel Managment eshte i instaluar si version Demo apo jo.
		/// Ky kontroll behet duke u nisura nga vlera qe ndodhet ne rregjister
		/// </summary>
		/// <returns>true nese programi eshte version Demo; perndryshe false</returns>
		public static bool IsDemoVersion()
		{
			try
			{
				int nrDhomash = GetRoomsCount();
				string key1 = GetKey();
				string encrypted = EncryptKeyDemo(nrDhomash);
				if (key1 == encrypted)
					return true;
				return false;
			}
			catch
			{
				return false;
			}
		}


		public static string GetEncryptedKeyFull()
		{
			return EncryptKeyFull();
		}

		/// <summary>
		/// Ben ndryshimin e vleres se ruajtur ne rregjistra duke deshifruar vleren e deritanishme
		/// te ruajtur ne rregjistra. Versioni kthehet ne DEMO nese numri i dhomave eshte me i madh
		/// se sa ai i dhene me perpara, pavaresisht nese ka qene version i plote apo jo
		/// </summary>
		/// <param name="numerFillestarDhomash"></param>
		/// <param name="numerDhomash"></param>
		public static void EditRegistryKey(int numerFillestarDhomash, int numerDhomash)
		{
			string key1 = "";
			string keyValue = GetKeyValue(path, name);
			string[] splitKey = keyValue.Split(new char[] { '-' });
			int roomsCount = (numerDhomash + 4) * 3;
			if (splitKey.Length >= 2)
			{
				splitKey.SetValue(roomsCount.ToString(), splitKey.Length - 1);
				for (int i = 0; i < splitKey.Length - 1; i++)
				{
					key1 += splitKey.GetValue(i).ToString();
				}
				key1 += "-" + splitKey.GetValue(splitKey.Length - 1).ToString();
				key1 = RegistrationClass.EncryptKeyDemo(numerDhomash);
				StoreKeyValue(path, name, key1);
				StoreKeyValue("Vlera2", numerDhomash.ToString().Length.ToString());
			}
			else
			{
				key1 = RegistrationClass.EncryptKeyDemo(numerDhomash);
				StoreKeyValue(path, name, key1);
				StoreKeyValue("Vlera2", numerDhomash.ToString().Length.ToString());
			}
		}


		/// <summary>
		/// Ruan nje vlere per dhomat, per versionin DEMO te programit
		/// </summary>
		/// <param name="numerDhomash"></param>
		public static void StoreKeyToRegistry(int numerDhomash)
		{
			string Key = EncryptKeyDemo(numerDhomash);
			StoreKeyValue(path, name, Key);
			//StoreKeyValue(path, name, "1");
		}

		/// <summary>
		/// Ruan vleren <see cref="celes"/> ne rregjistra
		/// </summary>
		/// <param name="celes"></param>
		public static void StoreKeyToRegistry(string celes)
		{
			StoreKeyValue(path, name, celes);
		}

		public static void StoreKeyToRegistry(string pathName, string valueName)
		{
			StoreKeyValue(pathName, valueName);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key"></param>
		/// <returns></returns>
		public static bool IsDemoVersion(string Key)
		{
			try
			{
				if (Key[0] != '0')
					return false;
			}
			catch
			{
				return true;
			}
			return true;
		}

		#endregion

		#region Private Methods
		/// <summary>
		/// Kap ditet qe kur programi eshte hapur per here te pare
		/// </summary>
		/// <returns></returns>
		private static int NumriDiteveNgaInstalimi()
		{
			string str = System.Environment.MachineName;
			string encFileString = "";
			TimeSpan days = TimeSpan.MaxValue;
			DateTime dateInstalled = DateTime.MinValue;
			StreamReader reader = null;
			try
			{
				if (File.Exists(dateInstalledFilePath))
				{
					FileStream stream = File.Open(dateInstalledFilePath, FileMode.Open);
					reader = new StreamReader(stream);
					encFileString = reader.ReadToEnd();
					dateInstalled = Convert.ToDateTime(encFileString);
					days = DateTime.Now.Subtract(dateInstalled);
				}
			}
			catch
			{
				// Nese dicka nuk eshte ne rregull atehere i japim vleren maksimale
				days = TimeSpan.MaxValue;
			}
			finally
			{
				if (reader != null)
					reader.Close();
			}
			return days.Days;
		}


		/// <summary>
		/// Kap numrin serial te hard diskut te pare qe eshte i instaluar dhe ka numer serial te vlefshem
		/// KUJDES!!! Duhet qe te testohet kur ne kompjutera perdoret Norton Ghost
		/// </summary>
		/// <returns>numrin serial qe kap nga Windowsi</returns>
		private static string GetHardDiskSignature()
		{
			try
			{
				ManagementObjectSearcher query;
				ManagementObjectCollection queryCollection;
				System.Management.ObjectQuery oq;
				ConnectionOptions co = new ConnectionOptions();
				ManagementScope ms = new ManagementScope("\\\\localhost\\root\\cimv2", co);
				oq = new System.Management.ObjectQuery("SELECT * FROM Win32_DiskDrive");
				query = new ManagementObjectSearcher(ms, oq);
				queryCollection = query.Get();
				foreach (ManagementObject mo in queryCollection)
				{
					if (mo["Signature"] != null)
					{
						int length = GetRoomsCount().ToString().Length;
						if (mo["Signature"].ToString().Length > 11 - length)
						{
							string id = mo["Signature"].ToString();
							return id.Substring(id.Length - (11 - length), 11 - length);
						}
						if (length == 1)
							return Convert.ToInt64(mo["Signature"]).ToString("0000000000");
						if (length == 2)
							return Convert.ToInt64(mo["Signature"]).ToString("000000000");
						if (length == 3)
							return Convert.ToInt64(mo["Signature"]).ToString("00000000");
						//return mo["Signature"].ToString();
					}
				}
				return "1";
			}
			catch (Exception ex)
			{
				return "1";
			}
		}


		private static string GetHardDiskSignature(int numerDhomash)
		{
			try
			{
				ManagementObjectSearcher query;
				ManagementObjectCollection queryCollection;
				System.Management.ObjectQuery oq;
				ConnectionOptions co = new ConnectionOptions();
				ManagementScope ms = new ManagementScope("\\\\localhost\\root\\cimv2", co);
				oq = new System.Management.ObjectQuery("SELECT * FROM Win32_DiskDrive");
				query = new ManagementObjectSearcher(ms, oq);
				queryCollection = query.Get();
				foreach (ManagementObject mo in queryCollection)
				{
					if (mo["Signature"] != null)
					{
						int length = numerDhomash.ToString().Length;
						if (mo["Signature"].ToString().Length > 11 - length)
						{
							string id = mo["Signature"].ToString();
							return id.Substring(id.Length - (11 - length), 11 - length);
						}
						if (length == 1)
							return Convert.ToInt64(mo["Signature"]).ToString("0000000000");
						if (length == 2)
							return Convert.ToInt64(mo["Signature"]).ToString("000000000");
						if (length == 3)
							return Convert.ToInt64(mo["Signature"]).ToString("00000000");
						//return mo["Signature"].ToString();
					}
				}
				return "1";
			}
			catch (Exception ex)
			{
				return "1";
			}
		}

		/// <summary>
		/// Merr numrin serial te windows-it qe eshte instaluar ne kete kompjuter dhe nxjerr nga ky numer
		/// 10 shifrat e para pa shenjen '-'. Ne rast te ndonje gabimi kthen "1".
		/// Ky numer nuk eshte unik per cdo kompjuter, te pakten ne rastet kur perdoret Norton Ghost.
		/// </summary>
		/// <returns>10 shifrat e para te numrit serial te Windows-it</returns>
		private static string GetSystemSerial()
		{
			try
			{
				string serial = "0000000001";
				ManagementObjectSearcher query;
				ManagementObjectCollection queryCollection;
				System.Management.ObjectQuery oq;
				ConnectionOptions co = new ConnectionOptions();
				ManagementScope ms = new ManagementScope("\\\\localhost\\root\\cimv2", co);
				oq = new System.Management.ObjectQuery("SELECT * FROM Win32_OperatingSystem");
				query = new ManagementObjectSearcher(ms, oq);
				queryCollection = query.Get();
				foreach (ManagementObject mo in queryCollection)
				{
					if (mo["SerialNumber"] != null)
					{
						serial = mo["SerialNumber"].ToString();
						break;
					}
				}
				char[] str = { };
				if (serial.Replace("-", "").Length > 7)
				{
					serial = serial.Replace("-", "");
					return serial.Substring(serial.Length - 10, 10);
				}
				return serial;
			}
			catch
			{
				return "0000000001";
			}
		}


		/// <summary>
		/// Ne menyre qe nje nga variablat te jete dinamike, sepse ne kete menyre siguria do te
		/// rritej me shume, percaktojme se sa kohe ka qe eshte ngarkuar sistemi
		/// </summary>
		/// <returns>Kohen ne milisekonda gjate se ciles eshte ngarkuar sistemi. 1 nese
		/// ka ndodh ndonje gabim</returns>
		private static int GetSystemLoadedTime()
		{
			try
			{
				// Shohim ne fillim nese koha e hapjes eshte e ruajtur. Nese po, atehere kthe
				// vleren e ruajtjes
				if (Global.GetIsolatedStorageContent("SystemLoadedTime") != null)
				{
					return Convert.ToInt32(Global.GetIsolatedStorageContent("SystemLoadedTime"));
				}
				// Perndryshe gjej kohen dhe ktheje
				string tickString = Environment.TickCount.ToString();
				int tickInt = 1;
				if (tickString.Length >= 4)
				{
					// Ne fillim shohim nese koha qe kur eshte ngarkuar sistemi eshte me e madhe
					// se 10 sekonda. Ne kete rast marrim 4 shifrat e fundit
					tickInt = Convert.ToInt32(tickString.Substring(tickString.Length - 4, 4));
				}
				else
				{
					// Perndryshe marrim te gjitha vlerat, duke i shtuar zero perpara
					tickInt = Convert.ToInt32(tickString);
					tickString = tickInt.ToString("0000");
					Convert.ToInt32(tickString);
				}

				Global.StoreToIsolatedStorage("SystemLoadedTime", tickInt.ToString());
				return tickInt;
			}
			catch (Exception ex)
			{
				return 1;
			}
		}


		/// <summary>
		/// Kap daten kur eshte instaluar sistemi i shfrytezimit ne kete kompjuter
		/// </summary>
		/// <returns></returns>
		private static string GetSystemDateInstalled()
		{
			try
			{
				ManagementObjectSearcher query;
				ManagementObjectCollection queryCollection;
				System.Management.ObjectQuery oq;
				string dateInstalledString = "";
				ConnectionOptions co = new ConnectionOptions();
				ManagementScope ms = new ManagementScope("\\\\localhost\\root\\cimv2", co);
				oq = new System.Management.ObjectQuery("SELECT * FROM Win32_OperatingSystem");
				query = new ManagementObjectSearcher(ms, oq);
				queryCollection = query.Get();
				foreach (ManagementObject mo in queryCollection)
				{
					if (mo["InstallDate"] != null)
					{
						dateInstalledString = mo["InstallDate"].ToString();
					}
				}
				return dateInstalledString;
			}
			catch
			{
				return "";
			}
		}


		/// <summary>
		/// Ben kriptimin e celesit per versionin demo duke u nisur nga numri i dhomave, numri serial
		/// i Windows-it numri identifikues i Hard Diskut dhe koha qe kur sistemi eshte ngarkuar per
		/// here te fundit.
		/// Numri i dhomave mblidhet me 4 dhe i gjithe numri shumezohet me 3;
		/// </summary>
		/// <param name="numerDhomash">numri i dhomave, e cila eshte e vetmja e dhene qe merret
		/// nga perdoruesi</param>
		/// <returns>vleren e kriptuar per celesin qe do te ruhet ne rregjistra</returns>
		private static string EncryptKeyDemo(int numerDhomash)
		{
			string hardDisk = GetHardDiskSignature(numerDhomash);
			int loadedSystemTime = GetSystemLoadedTime();
			string serial = GetSystemSerial();
			int encyptedRoomCount = (numerDhomash + 4) * 3;
			return serial + hardDisk + loadedSystemTime + "-" + encyptedRoomCount.ToString();
		}


		private static string EncryptKeyFull()
		{
			string keyDemo = GetKeyValue(path, name);
			Encoding ascii = Encoding.ASCII;
			string[] split = keyDemo.Split(new char[] { '-' });
			// Nese gjendet me shume se nje vize atehere vlerat e rregjistrave nuk jane ne rregull.
			// Ne kete rast kthe null
			if (split.Length != 2)
				return null;
			// Nese numri i dhomave nuk plotpjesetohet me 3 atehere ai eshte modifikuar jashte programit.
			// Kthe vlere null edhe ne kete rast
			if ((Convert.ToInt32(split[1]) % 3) != 0)
				return null;
			int roomCount = (Convert.ToInt32(split[1]) / 3) - 4;
			// Tani bejme kriptimin e numrit te dhomave
			Byte[] encodedRoomCount = ascii.GetBytes(roomCount.ToString());
			int nr;
			string nrDhomash = "";
			foreach (Byte b in encodedRoomCount)
			{
				nr = Algebra.GetIndex(Convert.ToChar(b));
				// Bejme kete veprim: ((nr + 9) * 8) - 6 ne Z(59)
				nr = Algebra.Substract(Algebra.Multiply(Algebra.Sum(nr, 9, 59), 8, 59), (6), 59);
				nrDhomash += Algebra.GetChar(nr).ToString();
			}

			// Bejme kriptimin e kohes kur eshte ngarkuar sistemi
			string loadedSystemTime = split[0].Substring(split[0].Length - 4, 4);
			Byte[] systemTime = ascii.GetBytes(loadedSystemTime);
			string encodedSystemTime = "";
			foreach (Byte b in systemTime)
			{
				nr = Algebra.GetIndex(Convert.ToChar(b));
				// Bejme kete veprim: ((nr + 15) * 3) - 8
				nr = Algebra.Substract(Algebra.Multiply(Algebra.Sum(nr, 15, 59), 3, 59), 6, 59);
				encodedSystemTime += Algebra.GetChar(nr).ToString();
			}

			// Bejme kriptimin e numrit serial te Windows-it
			string systemSerial = split[0].Substring(0, 10);
			Byte[] encodedSystemSerial = ascii.GetBytes(systemSerial);
			string systemSerialEnc = "";
			foreach (Byte b in encodedSystemSerial)
			{
				nr = Algebra.GetIndex(Convert.ToChar(b));
				// Bejme kete veprim: ((nr - 2) * 10) + 7
				nr = Algebra.Sum(Algebra.Multiply(Algebra.Substract(nr, 2, 59), 10, 59), 7, 59);
				systemSerialEnc += Algebra.GetChar(nr);
			}

			// Bejme kriptimin e ID-se se hardDiskut
			string hardDisk = split[0].Substring(10, split[0].Length - 14);
			Byte[] encodedHardDiskID = ascii.GetBytes(hardDisk);
			string hardDiskIDEnc = "";
			int i = 0;
			foreach (Byte b in encodedHardDiskID)
			{
				nr = Algebra.GetIndex(Convert.ToChar(b));
				// Bejme kete veprim: ((nr + 6) * 7) + ((i * 3) + 3)
				nr = Algebra.Sum(Algebra.Multiply(Algebra.Sum(nr, 6, 59), 7, 59),
					Algebra.Sum(Algebra.Multiply(i, 3, 59), 3, 59), 59);
				hardDiskIDEnc += Algebra.GetChar(nr);
				i++;
			}

			// Ne kete pike vendosim te gjitha vlerat e nxjerra nga kriptimi, bashke
			return systemSerialEnc + hardDiskIDEnc + encodedSystemTime + nrDhomash;
			//			return keyDemo;
		}


		/// <summary>
		/// Ben deshifrimin e numrit serial qe eshte i ruajtur ne rregjistra nga versioni i plote ne
		/// versionin DEMO
		/// </summary>
		/// <returns>numrin serial te deshifruar</returns>
		private static string DecryptKeyFull()
		{
			try
			{
				int length = Convert.ToInt32(GetKeyValue("Vlera2"));
				string keyFull = GetKeyValue(path, name);
				Encoding ascii = Encoding.ASCII;
				int nr;
				// Bejme deshifrimin e numrit te dhomave qe jane ne program
				string nrDhomash = keyFull.Substring(keyFull.Length - length, length);
				string nrDhomashDec = "";
				Byte[] encodedRoomCount = ascii.GetBytes(nrDhomash);
				foreach (Byte b in encodedRoomCount)
				{
					nr = Algebra.GetIndex(Convert.ToChar(b));
					// Bejme kete veprim: ((nr + 6) / 8) - 9
					nr = Algebra.Substract(Algebra.Divide(Algebra.Sum(nr, 6, 59), 8, 59), 9, 59);
					nrDhomashDec += Algebra.GetChar(nr).ToString();
				}

				// Bejme deshifrimin e kohes se ngarkimit te sistemit
				string loadedSystemTime = keyFull.Substring(keyFull.Length - (4 + length), 4);
				string systemTimeDec = "";
				Byte[] systemTime = ascii.GetBytes(loadedSystemTime);
				foreach (Byte b in systemTime)
				{
					nr = Algebra.GetIndex(Convert.ToChar(b));
					// Bejme kete veprim: ((nr + 8) / 3) - 15
					nr = Algebra.Substract(Algebra.Divide(Algebra.Sum(nr, 6, 59), 3, 59), 15, 59);
					systemTimeDec += Algebra.GetChar(nr).ToString();
				}

				// Bejme deshifrimin e numrit serial te sistemit
				string systemSerial = keyFull.Substring(0, 10);
				string systemSerialDec = "";
				Byte[] encodedSystemSerial = ascii.GetBytes(systemSerial);
				foreach (Byte b in encodedSystemSerial)
				{
					nr = Algebra.GetIndex(Convert.ToChar(b));
					// Bejme kete veprim: ((nr - 7) / 10) + 2
					nr = Algebra.Sum(Algebra.Divide(Algebra.Substract(nr, 7, 59), 10, 59), 2, 59);
					systemSerialDec += Algebra.GetChar(nr).ToString();
				}

				// Bejme deshifrimin e numrit serial te hard diskut
				string hardDiskSerial = keyFull.Substring(10, keyFull.Length - (4 + length + 10));
				string hardDiskSerialDec = "";
				Byte[] encodedHDSerial = ascii.GetBytes(hardDiskSerial);
				int i = 0;
				foreach (Byte b in encodedHDSerial)
				{
					nr = Algebra.GetIndex(Convert.ToChar(b));
					// Bejme kete veprim: ((nr - ((i * 3) + 3) / 7) - 6
					nr = Algebra.Substract(Algebra.Divide(Algebra.Substract(nr,
						Algebra.Sum(Algebra.Multiply(i, 3, 59), 3, 59), 59), 7, 59), 6, 59);
					hardDiskSerialDec += Algebra.GetChar(nr).ToString();
					i++;
				}
				int numerDhomash = Convert.ToInt32(nrDhomashDec);
				numerDhomash = (numerDhomash + 4) * 3;
				// Tani bashkojme vlerat e gjetura nga deshifrimet e mesiperme dhe e kthejme kete vlere
				return systemSerialDec + hardDiskSerialDec + systemTimeDec + "-" + numerDhomash.ToString();
			}
			catch (Exception ex)
			{
				return "";
			}
		}

		private static int DecryptRoomsCountFull()
		{
			try
			{
				string lengthString = GetKeyValue("Vlera2");
				string keyFull = GetKeyValue(path, name);
				int length = Convert.ToInt32(lengthString);
				Encoding ascii = Encoding.ASCII;
				int nr;
				// Bejme deshifrimin e numrit te dhomave qe jane ne program
				string nrDhomash = keyFull.Substring(keyFull.Length - length, length);
				string nrDhomashDec = "";
				Byte[] encodedRoomCount = ascii.GetBytes(nrDhomash);
				foreach (Byte b in encodedRoomCount)
				{
					nr = Algebra.GetIndex(Convert.ToChar(b));
					// Bejme kete veprim: ((nr + 6) / 8) - 9
					nr = Algebra.Substract(Algebra.Divide(Algebra.Sum(nr, 6, 59), 8, 59), 9, 59);
					nrDhomashDec += Algebra.GetChar(nr).ToString();
				}
				return Convert.ToInt32(nrDhomashDec);
			}
			catch
			{
				return 0;
			}
		}


		/// <summary>
		/// Merr vleren e regjistrit per path-in dhe emrin e caktuar te rregjistrit
		/// </summary>
		/// <param name="keyPath">Path-i i celesit</param>
		/// <param name="name">Emri i celesit</param>
		/// <returns>Vleren ne pathin e dhene</returns>
		private static string GetKeyValue(string keyPath, string name)
		{
			//			Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.Registry.LocalMachine;
			//			Microsoft.Win32.RegistryKey key = hklm.OpenSubKey(keyPath);
			//			if (key != null)
			//				return key.GetValue(name).ToString();
			//			else
			//				return null;
			Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.Registry.LocalMachine;
			Microsoft.Win32.RegistryKey hkSoftware = hklm.OpenSubKey("Software", true);
			Microsoft.Win32.RegistryKey hkHotel = hkSoftware.OpenSubKey("VisionInfoSolution");
			Microsoft.Win32.RegistryKey key = hkHotel.OpenSubKey("HotelManagment");
			if (key != null)
				return key.GetValue(name).ToString();
			else
				return null;
		}

		private static string GetKeyValue(string name)
		{
			Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.Registry.LocalMachine;
			Microsoft.Win32.RegistryKey hkSoftware = hklm.OpenSubKey("Software", true);
			Microsoft.Win32.RegistryKey hkHotel = hkSoftware.OpenSubKey("VisionInfoSolution");
			Microsoft.Win32.RegistryKey key = hkHotel.OpenSubKey("HotelManagment");
			if (key != null)
				return key.GetValue(name).ToString();
			else
				return null;
		}


		/// <summary>
		/// Ruan vleren e dhene te regjistrit ne path-in dhe emrin e dhene
		/// </summary>
		/// <param name="keyPath">Path-i i celesit</param>
		/// <param name="name">Emri i celesit</param>
		/// <param name="keyValue">Vlera qe do ti jepet celesit</param>
		private static void StoreKeyValue(string keyPath, string name, string keyValue)
		{
			Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.Registry.LocalMachine;
			Microsoft.Win32.RegistryKey hkSoftware = hklm.OpenSubKey("Software", true);
			Microsoft.Win32.RegistryKey hkHotel = hkSoftware.CreateSubKey("VisionInfoSolution");
			Microsoft.Win32.RegistryKey key = hkHotel.CreateSubKey("HotelManagment");
			if (key != null)
				key.SetValue(name, keyValue);
		}

		private static void StoreKeyValue(string name, string keyValue)
		{
			Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.Registry.LocalMachine;
			Microsoft.Win32.RegistryKey hkSoftware = hklm.OpenSubKey("Software", true);
			Microsoft.Win32.RegistryKey hkHotel = hkSoftware.CreateSubKey("VisionInfoSolution");
			Microsoft.Win32.RegistryKey key = hkHotel.CreateSubKey("HotelManagment");
			//			Microsoft.Win32.RegistryKey key = hklm.CreateSubKey(keyPath);
			if (key != null)
				key.SetValue(name, keyValue);
		}
		#endregion
	}


	/// <summary>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
	/// Klase qe ben veprimet matematikore ne nje unaze me 59 elemente.
	/// Kjo klase nuk mund te inheritohet
	/// </summary>
	public sealed class Algebra
	{
		/// <summary>
		/// Mban te gjitha karakteret qe do te perdoren per shifrim
		/// </summary>
		private static char[] elements = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 
											 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 
											 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 
											 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 
											 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 
											 'U', 'V', 'W',};



		/// <summary>
		/// Gjen shumefishin me te vogel te perbashket te numrave <see cref="x"/> dhe <see cref="y"/>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns>shumefishin me te vogel te numrave <see cref="x"/> dhe <see cref="y"/></returns>
		public static long GCD(long x, long y)
		{
			while (y != 0)
			{
				long r = x % y;
				x = y;
				y = r;
			}
			return x;
		}


		/// <summary>
		/// Gjen te anasjelltin e elementit <see cref="x"/> ne fushen me <see cref="y"/> elemente.
		/// <para> Kjo metode bazohet ne algoritmin e Knuth</para>
		/// </summary>
		/// <param name="x">elementi per te cilin duhet te gjendet i anasjellti</param>
		/// <param name="y">elementet e fushes ne te cilin duhet te gjendet i anasjellti</param>
		/// <returns>te anasjelltin e numrit x ne fushen y</returns>
		public static long GCD1(long x, long y)
		{
			if (x == 0)
				return 0;
			if (x == 1)
				return 1;
			if (x == y)
				return x;
			long[] u = { 1, 0, x }, v = { 0, 1, y }, t = new long[3];
			while (v[2] != 0)
			{
				long q = u[2] / v[2];
				for (int i = 0; i < 3; i++)
				{
					t[i] = u[i] - v[i] * q;
					u[i] = v[i];
					v[i] = t[i];
				}
			}
			Int64 nr1 = Convert.ToInt64(u.GetValue(0));
			if (nr1 <= 0)
				nr1 = 59 + nr1;
			return nr1;
		}


		/// <summary>
		/// Kryen shumezimin e dy numrave <see cref="x"/> dhe <see cref="y"/> ne fushen me
		/// <see cref="z"/> elemente
		/// </summary>
		/// <param name="x">numri i pare qe do te shumezohet</param>
		/// <param name="y">numri i dyte qe do te shumezohet</param>
		/// <param name="z">fusha ne te cilen do te kryhet veprimi i shumezimit</param>
		/// <returns>vleren qe merret nga shumezimi i dy numrave ne fushen me <see cref="z"/> elemente</returns>
		public static int Multiply(int x, int y, int z)
		{
			int a = x * y;
			if (a > z - 1)
				a = a % z;
			return a;
		}


		/// <summary>
		/// Kryen mbledhjen e dy numrave <see cref="x"/> dhe <see cref="y"/> ne fushen me
		/// <see cref="z"/> elemente
		/// </summary>
		/// <param name="x">numri i pare qe do te mblidhet</param>
		/// <param name="y">numri i dyte qe do te mblidhet</param>
		/// <param name="z">fusha ne te cilen do te kryhet veprimi i mbledhjes</param>
		/// <returns>vleren qe merret nga mbledhja e dy numrave ne fushen me <see cref="z"/> elemente</returns>
		public static int Sum(int x, int y, int z)
		{
			int a = x + y;
			if (a > z - 1)
				a = a % z;
			return a;
		}


		/// <summary>
		/// Kryen zbritjen e dy numrave <see cref="x"/> dhe <see cref="y"/> ne fushen me
		/// <see cref="z"/> elemente
		/// </summary>
		/// <param name="x">numri nga i cili do te zbritet numri <see cref="y"/></param>
		/// <param name="y">numri i cili do ti zbritet numri <see cref="x"/></param>
		/// <param name="z">fusha ne te cilen do te kryhet veprimi i zbritjes</param>
		/// <returns>vleren qe do te perftohet nga zbritja e dy numrave ne fushen me <see cref="z"/> elemente</returns>
		public static int Substract(int x, int y, int z)
		{
			int a = x - y;
			if (a < 0)
				a = a + z;
			return a;
		}


		/// <summary>
		/// Kryen pjesetimin e numrit <see cref="x"/> me numrin <see cref="y"/> ne fushen me
		/// <see cref="z"/> elemente
		/// </summary>
		/// <param name="x">numri nga i cili do te pjesetohet numri <see cref="y"/></param>
		/// <param name="y">pjesetuesi i numrit <see cref="x"/></param>
		/// <param name="z">fusha ne te cilen do te kryhet veprimi i pjesetimi</param>
		/// <returns>vleren qe merret nga pjesetimi i dy numrave</returns>
		public static int Divide(int x, int y, int z)
		{
			// Ne fillim gjejme te anasjelltin e y ne fushen z
			int b = Convert.ToInt32(Algebra.GCD1(y, z));
			long a = x * b;
			if (a > z)
				a = a % z;
			return Convert.ToInt32(a);
		}


		public static char GetChar(int x)
		{
			if (x < 0)
				return elements[x + 59];
			if (x > 58)
				return elements[x % 59];
			return elements[x];
		}

		/// <summary>
		/// Merr indeksin e shkronjes ch ne korrespondence me vektorin elements
		/// </summary>
		/// <param name="ch">karakteri per te cilin do te gjendet korrespondenca</param>
		/// <returns>indeksin e karakterit <see cref="ch"/></returns>
		public static int GetIndex(char ch)
		{
			for (int i = 0; i < elements.Length; i++)
			{
				if (elements[i] == ch)
					return i;
			}
			return 0;
		}
	}

}
