using System;
using System.IO;
using System.IO.IsolatedStorage;


namespace HotelManagment.BusDatService
{
	/// <summary>
	/// Summary description for Global.
	/// </summary>
	public class Global
	{
		private string loggedUser = "";
		private static string defaultHelpFile = "about:blank";
#if DEBUG
		private static string homeFile = @"\..\..\home.htm";
#else
		private static string homeFile = @"\home.htm";
#endif
		public Global()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static void UserData()
		{
			Global global = new Global();
		}

		public string LoggedUser
		{
			get
			{
				return this.loggedUser;
			}
			set
			{
				this.loggedUser = value;
			}
		}

		/// <summary>
		/// Skedari default qe hapet per help-in ku ai nuk eshte i vlefshem
		/// </summary>
		public static string DefaultHelpFile
		{
			get
			{
				return defaultHelpFile;
			}
		}

		/// <summary>
		/// Skedari home per help-in
		/// </summary>
		public static string HomeFile
		{
			get
			{
				return homeFile;
			}
		}

		/// <summary>
		/// Merr te dhenat e skedarit te dhene nga nje isolated storage
		/// </summary>
		/// <param name="fileName">emri i skedarit per te cilin do te merren te dhenat</param>
		/// <returns>te dhenat e skedarit. Nese skedari nuk ekziston, kthen null</returns>
		public static string GetIsolatedStorageContent(string fileName)
		{
			IsolatedStorageFile store = IsolatedStorageFile.GetStore(IsolatedStorageScope.Assembly |
				IsolatedStorageScope.User, null, null);
			string[] fileNames = store.GetFileNames(fileName);
			if (fileNames.Length == 0)
				return null;
			string content = "";
			using(StreamReader reader = new StreamReader(new IsolatedStorageFileStream(
					  fileName, FileMode.Open, store)))
			{
				content = reader.ReadToEnd();
			}
			return content;
		}

		public static void StoreToIsolatedStorage(string fileName, string data)
		{
			IsolatedStorageFile store = IsolatedStorageFile.GetStore(IsolatedStorageScope.Assembly |
				IsolatedStorageScope.User, null, null);
			using (StreamWriter writer = new StreamWriter(new IsolatedStorageFileStream(fileName, 
					   FileMode.OpenOrCreate, store)))
			{
				writer.Write(data);
			}
		}

		public static StreamWriter GetIsolatedStorageStreamWriter(string fileName)
		{
			IsolatedStorageFile isoStore =  IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
			return new StreamWriter(new IsolatedStorageFileStream(fileName, FileMode.Create, isoStore));
		}

	}
}
