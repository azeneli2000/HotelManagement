using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;

namespace HotelManagment
{
	/// <summary>
	/// Kjo klase krijon nje timer
	/// </summary>
	public class APITimer
	{
		#region Private Fields
		private int ID_CB_Timer;
		private int Cnt_CB_Timer;
		private int ID_WN_Timer;
		private int Cnt_WN_Timer;
		private TimerProc Cb = null;
		#endregion

		#region Public Fields
		DataSet dsMesazhe = new DataSet();
		#endregion

		#region Constructors
		public APITimer()
		{
			Cb = new TimerProc(OnTickTimer);
		}
		#endregion

		private delegate void TimerProc(IntPtr hWnd, uint nMsg, int nIDEvent, int dwTime);

		public void OnTickTimer(IntPtr hWnd, uint nMsg, int nIDEvent, int dwTime)
		{
			this.Cnt_CB_Timer += 1;
		}

		
		#region Common API Calls
		// Consts used
		public const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x100;
		public const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x2000;
		public const int FORMAT_MESSAGE_FROM_HMODULE = 0x800;
		public const int FORMAT_MESSAGE_FROM_STRING = 0x400;
		public const int FORMAT_MESSAGE_FROM_SYSTEM = 0x1000;
		public const int FORMAT_MESSAGE_IGNORE_INSERTS = 0x200;
		public const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 0xFF;

		public const int WM_TIMER = 0x113;

		[DllImport("user32")]
		private static extern int SetTimer(IntPtr hwnd, int nIDEvent, int uElapse, TimerProc CB);
		[DllImport("user32")]
		private static extern int KillTimer(IntPtr hwnd, int nIDEvent);
		[DllImport("kernel32")]
		private static extern void SetLastError(int dwErrCode);
		[DllImport("kernel32")]
		private static extern int GetLastError();
		[DllImport("kernel32")]
		private static extern int FormatMessage(int dwFlags, IntPtr lpSource, int dwMessageId, int dwLanguageId, System.Text.StringBuilder lpBuffer, int nSize, int Arguments);
		
		private static string GetAPIErrorMessageDescription(int ApiErrNumber ) 
		{
			System.Text.StringBuilder sError = new System.Text.StringBuilder(512); 
			int lErrorMessageLength; 
			lErrorMessageLength = FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM,(IntPtr)0, ApiErrNumber, 0, sError, sError.Capacity, 0) ;
			
			if(lErrorMessageLength > 0)
			{ 
				string strgError = sError.ToString();
				strgError=strgError.Substring(0,strgError.Length-2);
				return strgError+" ("+ApiErrNumber.ToString()+")";
			}
			return "none";

		}
		#endregion
		
		public void StartTimer(int time)
		{
			this.ID_CB_Timer = SetTimer(IntPtr.Zero, 0, time, Cb);
		}
	}
}
