using System;
using System.Management;
using System.Runtime.InteropServices;
using GeoBaha.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GeoBaha
{
	[StandardModule]
	internal sealed class Auth
	{
		public static bool AuthKey;

		public static string AuthString;

		private const int READ_CONTROL = 131072;

		private const int KEY_QUERY_VALUE = 1;

		private const int KEY_SET_VALUE = 2;

		private const int KEY_CREATE_SUB_KEY = 4;

		private const int KEY_ENUMERATE_SUB_KEYS = 8;

		private const int KEY_NOTIFY = 16;

		private const int KEY_CREATE_LINK = 32;

		private const int KEY_ALL_ACCESS = 131135;

		private const int HKEY_LOCAL_MACHINE = -2147483646;

		private const int ERROR_SUCCESS = 0;

		private const int REG_SZ = 1;

		private const int REG_DWORD = 4;

		private const string gREGKEYSYSINFOLOC = "System\\CurrentControlSet\\Control\\ComputerName\\ComputerName";

		private const string gREGKEYSYSINFO = "System\\CurrentControlSet\\Control\\ComputerName\\ComputerName";

		private const string gREGVALSYSINFO = "ComputerName";

		private const string RegKey = "Reg";

		public static string Register;

		public static string SysInfoPath;

		public const string EncryptName = "NahdiKholafaiProduct";

		private const string RegPath = "SOFTWARE\\Project";

		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int RegOpenKeyEx(IntPtr hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, int ulOptions, int samDesired, ref int phkResult);

		[DllImport("advapi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern long RegQueryValueEx(long hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, long lpReserved, ref long lpType, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpData, ref long lpcbData);

		[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int RegCloseKey(int hKey);

		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetVolumeInformationA", ExactSpelling = true, SetLastError = true)]
		private static extern long GetVolumeInformation([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, int nVolumeNameSize, long lpVolumeSerialNumber, long lpMaximumComponentLength, long lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, long nFileSystemNameSize);

		public static void StartSysInfo()
		{
			int try0001_dispatch = -1;
			int num2 = default(int);
			int num = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num2 = 2;
						if (GetKeyValue(-2147483646L, "System\\CurrentControlSet\\Control\\ComputerName\\ComputerName", "ComputerName", ref SysInfoPath))
						{
							goto end_IL_0001;
						}
						break;
					case 64:
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto end_IL_0001_2;
						}
						break;
					}
					Interaction.MsgBox("ساعت سيستم شما تغيير کرده است");
					break;
					end_IL_0001_2:;
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError((exception));
					try0001_dispatch = 64;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		public static bool GetKeyValue(long KeyRoot, string KeyName, string SubKeyRef, ref string KeyVal)
		{
			IntPtr hKey = (IntPtr)KeyRoot;
			bool result;
			checked
			{
				long num = default(long);
				int phkResult = (int)num;
				int num2 = RegOpenKeyEx(hKey, ref KeyName, 0, 131135, ref phkResult);
				num = phkResult;
				long num3 = num2;
				if (num3 == 0)
				{
					string lpData = new string('0', 1024);
					long lpcbData = 1024L;
					long lpType = default(long);
					num3 = RegQueryValueEx(num, ref SubKeyRef, 0L, ref lpType, ref lpData, ref lpcbData);
					if (num3 == 0)
					{
						lpData = ((Strings.Asc(Strings.Mid(lpData, (int)lpcbData, 1)) != 0) ? Strings.Left(lpData, (int)lpcbData) : Strings.Left(lpData, (int)(lpcbData - 1)));
						switch (lpType)
						{
						case 1L:
							KeyVal = lpData;
							break;
						case 4L:
						{
							long num4 = Strings.Len(lpData);
							for (long num5 = num4; num5 >= 1; num5 += -1)
							{
								KeyVal += Conversion.Hex(Strings.Asc(Strings.Mid(lpData, (int)num5, 1)));
							}
							KeyVal = Strings.Format("&h" + KeyVal);
							break;
						}
						}
						result = true;
						num3 = RegCloseKey((int)num);
						goto IL_012e;
					}
				}
				KeyVal = "";
				result = false;
				num3 = RegCloseKey((int)num);
				goto IL_012e;
			}
			IL_012e:
			return result;
		}

		public static void InvertIt()
		{
			string text = "";
			int num = Strings.Len(SysInfoPath);
			checked
			{
				for (int i = 1; i <= num; i++)
				{
					int num2 = Strings.Asc(Strings.Mid(SysInfoPath, i, 1));
					int num3 = 0;
					int num4;
					while (true)
					{
						num4 = num2;
						if (num4 > 127)
						{
							num3++;
							num2 -= 128;
							continue;
						}
						if (num4 > 63)
						{
							num3 += 2;
							num2 -= 64;
							continue;
						}
						if (num4 > 31)
						{
							num3 += 4;
							num2 -= 32;
							continue;
						}
						if (num4 > 15)
						{
							num3 += 8;
							num2 -= 16;
							continue;
						}
						if (num4 > 7)
						{
							num3 += 16;
							num2 -= 8;
							continue;
						}
						if (num4 > 3)
						{
							num3 += 32;
							num2 -= 4;
							continue;
						}
						if (num4 <= 1)
						{
							break;
						}
						num3 += 64;
						num2 -= 2;
					}
					if (num4 == 1)
					{
						num3 += 128;
					}
					num2 = 0xFF ^ num3;
					text += Conversions.ToString(Strings.Chr(num2));
				}
				SysInfoPath = text;
			}
		}

		public static void EncryptIt()
		{
			string text = "";
			int num = Strings.Len("NahdiKholafaiProduct");
			checked
			{
				for (int i = 1; i <= num; i++)
				{
					int charCode = 0;
					int num2 = Strings.Asc(Strings.Mid("NahdiKholafaiProduct", i, 1));
					int num3 = Strings.Len(SysInfoPath);
					for (int j = 1; j <= num3; j++)
					{
						int num4 = Strings.Asc(Strings.Mid(SysInfoPath, j, 1));
						charCode = num2 ^ num4;
					}
					text += Conversions.ToString(Strings.Chr(charCode));
				}
				SysInfoPath = text;
			}
		}

		public static void EncipherIt()
		{
			string text = "";
			int num = Strings.Len(SysInfoPath);
			checked
			{
				for (int i = 1; i <= num; i++)
				{
					int number = Strings.Asc(Strings.Mid(SysInfoPath, i, 1));
					string text2 = Conversion.Hex(number);
					if (Strings.Len(text2) == 1)
					{
						text2 = "0" + text2;
					}
					int num2 = 1;
					do
					{
						switch (Strings.Mid(text2, num2, 1))
						{
						case "0":
							text += "7";
							break;
						case "1":
							text += "B";
							break;
						case "2":
							text += "F";
							break;
						case "3":
							text += "D";
							break;
						case "4":
							text += "1";
							break;
						case "5":
							text += "9";
							break;
						case "6":
							text += "3";
							break;
						case "7":
							text += "A";
							break;
						case "8":
							text += "6";
							break;
						case "9":
							text += "5";
							break;
						case "A":
							text += "E";
							break;
						case "B":
							text += "8";
							break;
						case "C":
							text += "0";
							break;
						case "D":
							text += "C";
							break;
						case "E":
							text += "2";
							break;
						case "F":
							text += "4";
							break;
						}
						num2++;
					}
					while (num2 <= 2);
				}
				SysInfoPath = text;
			}
		}

		public static void GetSubKey()
		{
			if (GetKeyValue(-2147483646L, "SOFTWARE\\Project", "Reg", ref Register))
			{
			}
		}

		public static long GetSerialNumber(string strDrive)
		{
			ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + strDrive + ":\"");
			managementObject.Get();
			return Convert.ToInt32(Conversions.ToString(managementObject["VolumeSerialNumber"]), 16);
		}

        public static void AMain()
		{
			long serialNumber = GetSerialNumber("C");
			SysInfoPath = Conversion.Str(serialNumber);
			if (Strings.Len(SysInfoPath) > 20)
			{
				SysInfoPath = Strings.Left(SysInfoPath, 20);
			}
			InvertIt();
			EncryptIt();
			EncipherIt();
			GetSubKey();
			if (Strings.Len(SysInfoPath) > 20)
			{
				SysInfoPath = Strings.Left(SysInfoPath, 20);
			}
			int num = Strings.Len(SysInfoPath);
			for (int i = 1; i <= num; i = checked(i + 1))
			{
				switch (Strings.Mid(SysInfoPath, i, 1))
				{
				case "0":
					AuthString += "G";
					break;
				case "1":
					AuthString += "I";
					break;
				case "2":
					AuthString += "K";
					break;
				case "3":
					AuthString += "M";
					break;
				case "4":
					AuthString += "O";
					break;
				case "5":
					AuthString += "Q";
					break;
				case "6":
					AuthString += "S";
					break;
				case "7":
					AuthString += "U";
					break;
				case "8":
					AuthString += "V";
					break;
				case "9":
					AuthString += "T";
					break;
				case "A":
					AuthString += "R";
					break;
				case "B":
					AuthString += "P";
					break;
				case "C":
					AuthString += "N";
					break;
				case "D":
					AuthString += "L";
					break;
				case "E":
					AuthString += "J";
					break;
				case "F":
					AuthString += "H";
					break;
				}
			}
			Register = Interaction.GetSetting("active", "Options", "lock");
			if ((Strings.Len(Register) == 0) | (Operators.CompareString(Register, AuthString, TextCompare: false) != 0))
			{
				MyProject.Forms.Frm_Main.Pnl_Authen.Visible = true;
				MyProject.Forms.Frm_Main.mnu_Taarif.Visible = false;
				string text = Strings.Left(SysInfoPath, 5);
				MyProject.Forms.Frm_Main.txtAuth1.Text = text;
				text = Strings.Mid(SysInfoPath, 6, 5);
				MyProject.Forms.Frm_Main.txtAuth2.Text = text;
				text = Strings.Mid(SysInfoPath, 11, 5);
				MyProject.Forms.Frm_Main.txtAuth3.Text = text;
				text = Strings.Right(SysInfoPath, 5);
				MyProject.Forms.Frm_Main.txtAuth4.Text = text;
			}
			else
			{
				MyProject.Forms.Frm_Main.Pnl_Authen.Visible = false;
				MyProject.Forms.Frm_Main.mnu_Taarif.Visible = true;
			}
		}
	}
}
