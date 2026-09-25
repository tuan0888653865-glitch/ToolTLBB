using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;
using SmartBot;

namespace ns0
{
	// Token: 0x02000074 RID: 116
	internal sealed class Class83
	{
		// Token: 0x0600039E RID: 926 RVA: 0x0006CD7C File Offset: 0x0006AF7C
		// Note: this type is marked as 'beforefieldinit'.
		static Class83()
		{
			FontStyle[] array = new FontStyle[3];
			array[0] = FontStyle.Bold;
			array[1] = FontStyle.Italic;
			Class83.fontStyle_0 = array;
			Class83.hatchStyle_0 = new HatchStyle[]
			{
				HatchStyle.BackwardDiagonal,
				HatchStyle.Cross,
				HatchStyle.DashedDownwardDiagonal,
				HatchStyle.DashedHorizontal,
				HatchStyle.DashedUpwardDiagonal,
				HatchStyle.DashedVertical,
				HatchStyle.DiagonalBrick,
				HatchStyle.DiagonalCross,
				HatchStyle.Divot,
				HatchStyle.DottedDiamond,
				HatchStyle.DottedGrid,
				HatchStyle.ForwardDiagonal,
				HatchStyle.Horizontal,
				HatchStyle.HorizontalBrick,
				HatchStyle.LargeCheckerBoard,
				HatchStyle.LargeConfetti,
				HatchStyle.Cross,
				HatchStyle.LightDownwardDiagonal,
				HatchStyle.LightHorizontal,
				HatchStyle.LightUpwardDiagonal,
				HatchStyle.LightVertical,
				HatchStyle.Cross,
				HatchStyle.Horizontal,
				HatchStyle.NarrowHorizontal,
				HatchStyle.NarrowVertical,
				HatchStyle.OutlinedDiamond,
				HatchStyle.Plaid,
				HatchStyle.Shingle,
				HatchStyle.SmallCheckerBoard,
				HatchStyle.SmallConfetti,
				HatchStyle.SmallGrid,
				HatchStyle.SolidDiamond,
				HatchStyle.Sphere,
				HatchStyle.Trellis,
				HatchStyle.Vertical,
				HatchStyle.Wave,
				HatchStyle.Weave,
				HatchStyle.WideDownwardDiagonal,
				HatchStyle.WideUpwardDiagonal,
				HatchStyle.ZigZag
			};
			Class83.dictionary_1 = new Dictionary<int, char>();
			Class83.random_0 = new Random();
			Class83.object_1 = new object();
			Class83.byte_0 = new byte[4];
			Class83.byte_1 = new byte[4];
			Class83.byte_2 = new byte[2];
			Class83.byte_3 = new byte[8];
			Class83.string_1 = "&\"]+c%5jiq";
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0006D594 File Offset: 0x0006B794
		internal static int smethod_0(string string_2)
		{
			if (string_2 == frmMain.String_172)
			{
				return 0;
			}
			if (Class83.dictionary_0.Count == 0)
			{
				Class83.smethod_3();
			}
			string_2 = string_2.ToUpper();
			if (Class83.dictionary_0.Count > 0)
			{
				using (Dictionary<int, string>.Enumerator enumerator = Class83.dictionary_0.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<int, string> keyValuePair = enumerator.Current;
						if (keyValuePair.Value == string_2)
						{
							return keyValuePair.Key;
						}
					}
					return 0;
				}
				int result;
				return result;
			}
			return 0;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0006D634 File Offset: 0x0006B834
		internal static string smethod_1(int int_0)
		{
			if (int_0 == 0)
			{
				return frmMain.String_172;
			}
			if (Class83.dictionary_0.Count == 0)
			{
				Class83.smethod_3();
			}
			if (Class83.dictionary_0.Count > 0 && Class83.list_0.Count > 0)
			{
				for (int i = Class83.list_0.Count - 1; i >= 0; i--)
				{
					if (Class83.list_0[i].int_0 == int_0)
					{
						foreach (KeyValuePair<int, string> keyValuePair in Class83.dictionary_0)
						{
							if (keyValuePair.Key == Class83.list_0[i].int_1)
							{
								return keyValuePair.Value;
							}
						}
						return frmMain.String_172;
					}
				}
			}
			return frmMain.String_172;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0006D71C File Offset: 0x0006B91C
		internal static string smethod_2(int int_0)
		{
			if (int_0 == 0)
			{
				return frmMain.String_172;
			}
			if (Class83.dictionary_0.Count == 0)
			{
				Class83.smethod_3();
			}
			if (Class83.dictionary_0.Count > 0 && Class83.list_1.Count > 0)
			{
				for (int i = Class83.list_1.Count - 1; i >= 0; i--)
				{
					if (Class83.list_1[i].int_0 == int_0)
					{
						foreach (KeyValuePair<int, string> keyValuePair in Class83.dictionary_0)
						{
							if (keyValuePair.Key == Class83.list_1[i].int_1)
							{
								return keyValuePair.Value;
							}
						}
						return frmMain.String_172;
					}
				}
			}
			return frmMain.String_172;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0006D804 File Offset: 0x0006BA04
		internal static void smethod_3()
		{
			Class83.dictionary_0.Add(33, "PAGEUP");
			Class83.dictionary_0.Add(34, "PAGEDOWN");
			Class83.dictionary_0.Add(35, "END");
			Class83.dictionary_0.Add(36, "HOME");
			Class83.dictionary_0.Add(37, "LEFT");
			Class83.dictionary_0.Add(38, "UP");
			Class83.dictionary_0.Add(39, "RIGHT");
			Class83.dictionary_0.Add(40, "DOWN");
			Class83.dictionary_0.Add(45, "INSERT");
			Class83.dictionary_0.Add(46, "DELETE");
			Class83.dictionary_0.Add(48, "0");
			Class83.dictionary_0.Add(49, "1");
			Class83.dictionary_0.Add(50, "2");
			Class83.dictionary_0.Add(51, "3");
			Class83.dictionary_0.Add(52, "4");
			Class83.dictionary_0.Add(53, "5");
			Class83.dictionary_0.Add(54, "6");
			Class83.dictionary_0.Add(55, "7");
			Class83.dictionary_0.Add(56, "8");
			Class83.dictionary_0.Add(57, "9");
			Class83.dictionary_0.Add(65, "A");
			Class83.dictionary_0.Add(66, "B");
			Class83.dictionary_0.Add(67, "C");
			Class83.dictionary_0.Add(68, "D");
			Class83.dictionary_0.Add(69, "E");
			Class83.dictionary_0.Add(70, "F");
			Class83.dictionary_0.Add(71, "G");
			Class83.dictionary_0.Add(72, "H");
			Class83.dictionary_0.Add(73, "I");
			Class83.dictionary_0.Add(74, "J");
			Class83.dictionary_0.Add(75, "K");
			Class83.dictionary_0.Add(76, "L");
			Class83.dictionary_0.Add(77, "M");
			Class83.dictionary_0.Add(78, "N");
			Class83.dictionary_0.Add(79, "O");
			Class83.dictionary_0.Add(80, "P");
			Class83.dictionary_0.Add(81, "Q");
			Class83.dictionary_0.Add(82, "R");
			Class83.dictionary_0.Add(83, "S");
			Class83.dictionary_0.Add(84, "T");
			Class83.dictionary_0.Add(85, "U");
			Class83.dictionary_0.Add(86, "V");
			Class83.dictionary_0.Add(87, "W");
			Class83.dictionary_0.Add(88, "X");
			Class83.dictionary_0.Add(89, "Y");
			Class83.dictionary_0.Add(90, "Z");
			Class83.dictionary_0.Add(112, "F1");
			Class83.dictionary_0.Add(113, "F2");
			Class83.dictionary_0.Add(114, "F3");
			Class83.dictionary_0.Add(115, "F4");
			Class83.dictionary_0.Add(116, "F5");
			Class83.dictionary_0.Add(117, "F6");
			Class83.dictionary_0.Add(118, "F7");
			Class83.dictionary_0.Add(119, "F8");
			Class83.dictionary_0.Add(120, "F9");
			Class83.dictionary_0.Add(121, "F10");
			Class83.dictionary_0.Add(122, "F11");
			Class83.dictionary_0.Add(123, "F12");
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0006DBEC File Offset: 0x0006BDEC
		internal static void smethod_4()
		{
			string text = "";
			bool flag = false;
			for (int i = 0; i < Class83.list_1.Count; i++)
			{
				if (Class83.list_1[i].int_0 == Class83.list_0[i].int_0)
				{
					if (Class83.list_1[i].int_1 != Class83.list_0[i].int_1)
					{
						Class83.list_1[i].bool_0 = true;
						text += string.Format("{0},{1}|", Class83.list_1[i].int_0.ToString(), Class83.list_1[i].int_1.ToString());
						flag = true;
					}
					if (Class83.list_1[i].bool_1)
					{
						try
						{
							if (frmLogin.class101_0.class210_0.Count > 0)
							{
								for (int j = frmLogin.class101_0.class210_0.Count - 1; j >= 0; j--)
								{
									frmLogin.class101_0.class210_0[j].method_62(i, Class83.list_1[i].int_1);
								}
								Class83.list_1[i].bool_1 = false;
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
			if (flag && text != null)
			{
				Class161.smethod_4("gauto", "hotkey", text, frmMain.String_470, null);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000024E9 File Offset: 0x000006E9
		internal static void smethod_5()
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0006DD5C File Offset: 0x0006BF5C
		internal static void smethod_6(IntPtr intptr_0, Point point_0)
		{
			Point position = Cursor.Position;
			Class159.ClientToScreen(intptr_0, ref point_0);
			Cursor.Position = new Point(point_0.X, point_0.Y);
			Struct6 @struct = default(Struct6);
			@struct.uint_0 = 0U;
			@struct.struct7_0.struct8_0.uint_1 = 2U;
			Struct6 struct2 = default(Struct6);
			struct2.uint_0 = 0U;
			struct2.struct7_0.struct8_0.uint_1 = 4U;
			Struct6[] array = new Struct6[]
			{
				@struct,
				struct2
			};
			Class159.SendInput((uint)array.Length, array, Marshal.SizeOf(typeof(Struct6)));
			Cursor.Position = position;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0006DE0C File Offset: 0x0006C00C
		internal static void smethod_7(IntPtr intptr_0, string string_2)
		{
			if (!string.IsNullOrEmpty(string_2) && intptr_0 != (IntPtr)0 && string_2.Length > 0)
			{
				foreach (char value in string_2)
				{
					Class159.PostMessage(intptr_0, Class159.uint_2, (IntPtr)((int)value), (IntPtr)0);
				}
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0006DE6C File Offset: 0x0006C06C
		internal static void smethod_8(IntPtr intptr_0, int int_0)
		{
			if (int_0 != 0 && intptr_0 != (IntPtr)0)
			{
				Class159.PostMessage(intptr_0, Class159.uint_0, (IntPtr)int_0, (IntPtr)0);
				Class159.PostMessage(intptr_0, Class159.uint_1, (IntPtr)0, (IntPtr)0);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0006DEBC File Offset: 0x0006C0BC
		internal static int smethod_9(string string_2)
		{
			if (string_2.ToLower().Contains("cyber auto"))
			{
				return 1;
			}
			if (frmLogin.list_15.Count > 0)
			{
				try
				{
					foreach (string text in frmLogin.list_15)
					{
						if (string_2.ToLower().Contains(text.ToLower()))
						{
							return 1;
						}
					}
				}
				catch (Exception)
				{
				}
			}
			if (string_2.Contains("bossgame.net"))
			{
				return 2;
			}
			if (frmLogin.list_16.Count > 0)
			{
				try
				{
					foreach (string text2 in frmLogin.list_16)
					{
						if (string_2.ToLower().Contains(text2.ToLower()))
						{
							return 2;
						}
					}
					return 0;
				}
				catch (Exception)
				{
					return 0;
				}
				int result;
				return result;
			}
			return 0;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0006DFD4 File Offset: 0x0006C1D4
		internal static void smethod_10(string string_2, string string_3, List<string> list_2, bool bool_1 = false)
		{
			string text = Class83.smethod_81(string_2, string_3, false);
			list_2.Clear();
			if (bool_1)
			{
				text = HttpUtility.UrlDecode(text);
				try
				{
					byte[] bytes = Convert.FromBase64String(text);
					text = Encoding.UTF8.GetString(bytes);
				}
				catch (Exception)
				{
					frmLogin.Boolean_0 = true;
				}
			}
			if (text.Contains("|"))
			{
				string[] array = text.Split(new char[]
				{
					'|'
				});
				if (array.Length != 0)
				{
					foreach (string item in array)
					{
						list_2.Add(item);
					}
					return;
				}
			}
			else if (text != "")
			{
				list_2.Add(text);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0006E084 File Offset: 0x0006C284
		internal static bool smethod_11()
		{
			return frmLogin.list_3.Count > 0 && frmLogin.dateTime_0 != DateTime.MinValue && frmLogin.list_3.Contains(Convert.ToInt32(frmLogin.dateTime_0.DayOfWeek) + 1);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0006E0D4 File Offset: 0x0006C2D4
		internal static void smethod_12(string string_2, List<string> list_2)
		{
			list_2.Clear();
			if (string_2.Contains("|"))
			{
				string[] array = string_2.Split(new char[]
				{
					'|'
				});
				if (array.Length != 0)
				{
					foreach (string item in array)
					{
						list_2.Add(item);
					}
					return;
				}
			}
			else if (string_2 != "")
			{
				list_2.Add(string_2);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0006E13C File Offset: 0x0006C33C
		internal static bool smethod_13(string string_2)
		{
			foreach (char c in string_2)
			{
				if (c < '0' || c > '9')
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000042EA File Offset: 0x000024EA
		internal static bool smethod_14()
		{
			return frmLogin.string_17 == frmLogin.string_8 && frmLogin.string_0 == "CN";
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00004311 File Offset: 0x00002511
		internal static bool smethod_15(Class58 class58_0)
		{
			return class58_0 != null && class58_0.class59_0.string_0 == string.Empty;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00004332 File Offset: 0x00002532
		internal static void smethod_16()
		{
			Process.Start(frmLogin.class101_0.globalSettings_0.ZingMeURL);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0006E174 File Offset: 0x0006C374
		internal static string smethod_17(string string_2)
		{
			string str = frmLogin.class101_0.globalSettings_0.GameID + "_ver.log";
			bool flag = false;
			string text = "";
			if (File.Exists(GlobalSettings.string_0))
			{
				try
				{
					text = File.ReadAllText(GlobalSettings.string_0);
				}
				catch (Exception)
				{
				}
				if (!text.Contains("version " + string_2) && !text.Contains("Version " + string_2))
				{
					flag = true;
				}
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				try
				{
					text = Class83.smethod_125(frmLogin.class101_0.globalSettings_0.VersionsURL + str, "", "GET", null, true).Replace("\n", "").Trim();
					if (text != "" && !text.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage))
					{
						File.WriteAllText(GlobalSettings.string_0, text);
					}
				}
				catch (Exception)
				{
					text = "Có lỗi khi download thông tin phiên bản mới.\nVui lòng báo admin.";
				}
			}
			return text;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00003C2E File Offset: 0x00001E2E
		internal static long Int64_0
		{
			get
			{
				return frmLogin.stopwatch_0.ElapsedMilliseconds;
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00004349 File Offset: 0x00002549
		internal static string smethod_18(string string_2)
		{
			return (string_2 + Class83.Class85.smethod_0(string_2 + frmLogin.string_2).ToLower()).Substring(0, 8 + frmLogin.random_0.Next(0, 5));
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0006E280 File Offset: 0x0006C480
		internal static void smethod_19(string string_2)
		{
			using (FileStream fileStream = new FileStream(string_2, FileMode.Append, FileAccess.Write))
			{
				using (StreamWriter streamWriter = new StreamWriter(fileStream))
				{
					streamWriter.WriteLine(Class83.smethod_98(frmLogin.random_0.Next(1, 30)));
				}
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0006E2E8 File Offset: 0x0006C4E8
		internal static void smethod_20(string string_2)
		{
			string str = Class83.Class85.smethod_0("7f8a" + frmLogin.string_2).ToLower().Substring(0, 8) + ".exe";
			string text = Path.GetTempPath() + str;
			if (!File.Exists(text))
			{
				byte[] vp = Class212.vp;
				File.WriteAllBytes(text, vp);
			}
			if (File.Exists(text))
			{
				string text2 = string.Format("{0}.{1}.{2}.{3}", new object[]
				{
					frmLogin.random_0.Next(1, 10),
					frmLogin.random_0.Next(1, 10),
					frmLogin.random_0.Next(1, 10),
					frmLogin.random_0.Next(1, 10)
				});
				string arguments = string.Format("{0} /va {1} /s desc \"{2}\" /s company \"{3}\" /s comment \"{4}\" /s title \"{5}\" /s ProductName \"{6}\" /pv {7} /s private \"{8}\" /s OriginalFilename \"{9}\" /s LegalCopyright \"\"", new object[]
				{
					string_2,
					text2,
					Class83.smethod_21(frmLogin.random_0.Next(2, 6)),
					Class83.smethod_21(frmLogin.random_0.Next(2, 6)),
					Class83.smethod_21(frmLogin.random_0.Next(2, 6)),
					Class83.smethod_21(frmLogin.random_0.Next(2, 6)),
					Class83.smethod_21(frmLogin.random_0.Next(2, 4)),
					text2,
					Class83.smethod_21(frmLogin.random_0.Next(2, 6)),
					Class83.smethod_21(frmLogin.random_0.Next(2, 6))
				});
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

		// Token: 0x060003B5 RID: 949 RVA: 0x0006E494 File Offset: 0x0006C694
		internal static string smethod_21(int int_0 = 4)
		{
			string text = "";
			for (int i = 0; i < int_0; i++)
			{
				text = text + " " + Class83.smethod_98(frmLogin.random_0.Next(3, 8));
			}
			return text.Trim();
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000437A File Offset: 0x0000257A
		internal static string smethod_22()
		{
			if (!frmLogin.bool_33)
			{
				return Application.ProductVersion;
			}
			return frmLogin.string_12;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0006E4D8 File Offset: 0x0006C6D8
		internal static bool smethod_23()
		{
			string[] array = frmLogin.class101_0.globalSettings_0.MainURL2.Split(new char[]
			{
				'|'
			});
			for (;;)
			{
				int num = 0;
				string text = "";
				for (;;)
				{
					string text2 = Class83.smethod_98(5);
					if (!frmLogin.bool_29)
					{
						string str = frmLogin.random_0.Next().ToString("0");
						string text3 = HttpUtility.UrlEncode(Class83.smethod_39(Class83.smethod_71(frmLogin.class101_0.globalSettings_0.AESKeysets[1].secureString_2) + str, 1));
						string text4 = HttpUtility.UrlEncode(Class83.smethod_39(text2 + "," + frmLogin.class101_0.globalSettings_0.GameID, 1));
						text = Class83.smethod_124(array[num] + frmLogin.class101_0.globalSettings_0.ServerListURL, string.Concat(new string[]
						{
							"chicka=",
							frmLogin.string_11,
							"&f541=",
							text3,
							"&k53=",
							text4
						}), "POST", null, true);
					}
					if ((!(text != "") || text.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage) || !text.StartsWith("data=")) && !frmLogin.bool_29)
					{
						goto IL_366;
					}
					try
					{
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						if (!frmLogin.bool_29)
						{
							text = HttpUtility.UrlDecode(text.Replace("data=", ""));
							text = Class83.smethod_41(text, 1);
							dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(text);
						}
						if (frmLogin.bool_29 || (!frmLogin.bool_29 && dictionary.ContainsKey("dsign")))
						{
							string b = "";
							string text5 = "";
							string a = "123456";
							if (!frmLogin.bool_29)
							{
								b = dictionary["dsign"].ToString();
								string str2 = dictionary["salt"].ToString();
								text5 = "";
								if (dictionary.ContainsKey("msg"))
								{
									text5 = dictionary["msg"].ToString();
								}
								a = Class83.smethod_121(frmLogin.class101_0.globalSettings_0.GameID, str2 + text2);
							}
							if (frmLogin.bool_29)
							{
								text5 = Class83.class81_0.string_1;
							}
							if (a == b || frmLogin.bool_29)
							{
								string[] array2 = text5.Split(new char[]
								{
									'|'
								});
								if (array2.Length != 0)
								{
									foreach (string text6 in array2)
									{
										Class132 @class = new Class132();
										if (!text6.StartsWith("http://"))
										{
											if (!text6.EndsWith("/"))
											{
												@class.string_0 = "http://" + text6 + "/";
											}
											else
											{
												@class.string_0 = "http://" + text6;
											}
										}
										else if (!text6.EndsWith("/"))
										{
											@class.string_0 = text6 + "/";
										}
										else
										{
											@class.string_0 = text6;
										}
										frmLogin.list_5.Add(@class);
									}
								}
								frmLogin.bool_21 = true;
								return true;
							}
						}
						goto IL_366;
					}
					catch (Exception)
					{
						goto IL_366;
					}
					IL_262:
					if (string.IsNullOrEmpty(array[num]))
					{
						break;
					}
					continue;
					IL_366:
					num++;
					if (num < array.Length)
					{
						goto IL_262;
					}
					break;
				}
				IL_346:
				if (!frmLogin.bool_21 && !frmLogin.bool_29 && frmLogin.bool_28)
				{
					frmLogin.bool_29 = true;
					continue;
				}
				return true;
				goto IL_346;
			}
			bool result;
			return result;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0006E87C File Offset: 0x0006CA7C
		internal static Class132 smethod_24()
		{
			Class132 @class = null;
			if (frmLogin.list_5.Count > 0)
			{
				long elapsedMilliseconds = frmLogin.stopwatch_0.ElapsedMilliseconds;
				int num;
				do
				{
					num = frmLogin.random_0.Next(0, 100) % frmLogin.list_5.Count;
					if (num < frmLogin.list_5.Count && !frmLogin.list_5[num].bool_0)
					{
						goto Block_3;
					}
				}
				while (frmLogin.stopwatch_0.ElapsedMilliseconds - elapsedMilliseconds < 100L);
				goto IL_7E;
				Block_3:
				@class = frmLogin.list_5[num];
				@class.bool_0 = true;
			}
			IL_7E:
			if (@class == null)
			{
				if (frmLogin.list_5.Count > 0)
				{
					@class = frmLogin.list_5[0];
				}
				else
				{
					@class = new Class132();
					@class.string_0 = "http://server1.gameauto.net/";
					@class.int_0 = 100;
					@class.bool_0 = true;
				}
				@class.bool_1 = true;
			}
			return @class;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0006E950 File Offset: 0x0006CB50
		internal static void smethod_25()
		{
			long elapsedMilliseconds = frmLogin.stopwatch_0.ElapsedMilliseconds;
			bool flag = false;
			string string_ = "";
			frmLogin.dateTime_0 = Class83.smethod_44();
			flag = false;
			Class132 @class = null;
			if (!frmLogin.bool_29)
			{
				if (frmLogin.string_0 == "VN")
				{
					if (frmLogin.class132_0 == null)
					{
						@class = Class83.smethod_24();
					}
					else
					{
						@class = frmLogin.class132_0;
					}
				}
			}
			else
			{
				@class = new Class132();
				@class.bool_1 = true;
				@class.int_0 = 100;
				@class.bool_0 = true;
				@class.string_0 = "http://server1.gameauto.net/";
			}
			string text = Class83.smethod_98(5);
			string text2 = "";
			if (!frmLogin.bool_29)
			{
				string str = frmLogin.random_0.Next().ToString("0");
				string text3 = HttpUtility.UrlEncode(Class83.smethod_39(Class83.smethod_71(frmLogin.class101_0.globalSettings_0.AESKeysets[1].secureString_2) + str, 1));
				string text4 = HttpUtility.UrlEncode(Class83.smethod_39(text + "," + frmLogin.class101_0.globalSettings_0.GameID, 1));
				text2 = Class83.smethod_125(@class.string_0 + frmLogin.class101_0.globalSettings_0.GetDataURL, string.Concat(new string[]
				{
					"chicka=",
					frmLogin.string_11,
					"&f541=",
					text3,
					"&k54=",
					text4
				}), "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
			}
			if ((text2 != "" && !text2.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage) && text2.StartsWith("data=")) || frmLogin.bool_29)
			{
				try
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					if (!frmLogin.bool_29)
					{
						text2 = HttpUtility.UrlDecode(text2.Replace("data=", ""));
						text2 = Class83.smethod_41(text2, 1);
						dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(text2);
					}
					if (frmLogin.bool_29 || (!frmLogin.bool_29 && dictionary.ContainsKey("dsign")))
					{
						string b = "";
						string value = "";
						string a = "123456";
						if (!frmLogin.bool_29)
						{
							b = dictionary["dsign"].ToString();
							string str2 = dictionary["salt"].ToString();
							value = "";
							if (dictionary.ContainsKey("data"))
							{
								value = dictionary["data"].ToString();
							}
							a = Class83.smethod_121(frmLogin.class101_0.globalSettings_0.GameID, str2 + text);
						}
						if (frmLogin.bool_29)
						{
							value = Class83.class81_0.string_3;
						}
						if (a == b || frmLogin.bool_29)
						{
							Dictionary<string, object>[] array = JsonConvert.DeserializeObject<Dictionary<string, object>[]>(value);
							if (array.Length != 0 && frmLogin.list_25.Count == 0)
							{
								foreach (Dictionary<string, object> dictionary2 in array)
								{
									Class144 class2 = new Class144();
									class2.string_0 = dictionary2["hash"].ToString();
									class2.string_1 = dictionary2["version"].ToString();
									class2.string_2 = dictionary2["provider"].ToString();
									class2.string_3 = Class83.smethod_73(dictionary2["addr"].ToString(), "TDTthangancap");
									frmLogin.list_25.Add(class2);
								}
							}
							string text5 = Class83.smethod_81(string_, "ctvid", false);
							frmLogin.list_14.Clear();
							if (dictionary.ContainsKey("ctvid"))
							{
								text5 = dictionary["ctvid"].ToString();
							}
							if (text5.Contains("|"))
							{
								string[] array3 = text5.Split(new char[]
								{
									'|'
								});
								if (array3.Length != 0)
								{
									foreach (string item in array3)
									{
										frmLogin.list_14.Add(item);
									}
								}
							}
							if (dictionary.ContainsKey("cbauto"))
							{
								Class83.smethod_12(dictionary["cbauto"].ToString(), frmLogin.list_15);
							}
							if (dictionary.ContainsKey("bgauto"))
							{
								Class83.smethod_12(dictionary["bgauto"].ToString(), frmLogin.list_16);
							}
							if (dictionary.ContainsKey("blckchat"))
							{
								frmLogin.class101_0.globalSettings_0.BlockChat = bool.Parse(dictionary["blckchat"].ToString());
							}
							if (dictionary.ContainsKey("q12_1h"))
							{
								int.TryParse(dictionary["q12_1h"].ToString(), out frmLogin.class101_0.globalSettings_0.Q12_1hPrice);
							}
							if (dictionary.ContainsKey("q12_3h"))
							{
								int.TryParse(dictionary["q12_3h"].ToString(), out frmLogin.class101_0.globalSettings_0.Q12_3hPrice);
							}
							if (dictionary.ContainsKey("enddate"))
							{
								string text6 = dictionary["enddate"].ToString();
								if (text6 != "")
								{
									DateTime minValue = DateTime.MinValue;
									DateTime.TryParse(text6, out minValue);
									if (minValue != DateTime.MinValue && minValue < frmLogin.dateTime_0)
									{
										Class83.smethod_46("Auto gặp lỗi trong quá trình khởi tạo.\nVui lòng liên hệ GAuto để được hỗ trợ.", "Load auto", 30000, new object[0]);
										frmLogin.long_39 = frmLogin.stopwatch_0.ElapsedMilliseconds + 30000L;
									}
								}
							}
							if (dictionary.ContainsKey("batkm"))
							{
								frmLogin.string_9 = dictionary["batkm"].ToString();
							}
							if (dictionary.ContainsKey("tnfreeacc"))
							{
								string text6 = dictionary["tnfreeacc"].ToString();
								int.TryParse(text6, out frmLogin.class101_0.globalSettings_0.TNFreeAcc);
							}
							if (dictionary.ContainsKey("blockfrom"))
							{
								int.TryParse(dictionary["blockfrom"].ToString(), out frmLogin.int_2);
							}
							if (dictionary.ContainsKey("blockthese"))
							{
								Class83.smethod_12(dictionary["blockthese"].ToString(), frmLogin.list_32);
							}
							if (frmLogin.string_9 == "1" && dictionary.ContainsKey("kmmsg"))
							{
								frmLogin.string_10 = dictionary["kmmsg"].ToString();
								if (!frmLogin.bool_19)
								{
									frmLogin.bool_19 = true;
									MessageBox.Show(frmLogin.string_10, "Thông báo!");
								}
							}
							if (dictionary.ContainsKey("blckmsg"))
							{
								frmLogin.string_1 = dictionary["blckmsg"].ToString();
								if (!frmLogin.string_1.EndsWith("|"))
								{
									frmLogin.string_1 += "|";
								}
							}
							string text7 = Class83.smethod_81(text2, "freeday", false);
							if (text7 != "")
							{
								string[] array5 = text7.Trim().Split(new char[]
								{
									'|'
								});
								int num = -1;
								if (array5.Length != 0 && text7 != "")
								{
									foreach (string text8 in array5)
									{
										num = -1;
										int.TryParse(text8, out num);
										if (num > 0)
										{
											frmLogin.list_3.Add(num);
										}
										else if (num == 0 && text8 == "0")
										{
											frmLogin.list_3.Add(num);
										}
									}
								}
							}
							if (dictionary.ContainsKey("thongbao"))
							{
								Class83.smethod_12(dictionary["thongbao"].ToString(), frmLogin.list_26);
							}
							if (dictionary.ContainsKey("gtips"))
							{
								List<string> list = new List<string>();
								Class83.smethod_12(dictionary["gtips"].ToString(), list);
								if (list.Count > 1)
								{
									long num2 = 0L;
									long.TryParse(list[0], out num2);
									if (num2 <= 30000L && num2 != 0L)
									{
										frmLogin.long_27 = 1800000L;
									}
									else
									{
										frmLogin.long_27 = num2;
									}
									try
									{
										for (int j = 1; j < list.Count; j++)
										{
											string text9 = list[j];
											if (text9.Contains(";"))
											{
												string[] array6 = text9.Split(new char[]
												{
													';'
												});
												if (array6.Length != 0)
												{
													if (string.Compare(array6[0], "vng", true) == 0)
													{
														frmLogin.list_27.Add(array6[1]);
													}
													else if (string.Compare(array6[0], "tk", true) == 0)
													{
														frmLogin.list_28.Add(array6[1]);
													}
													else if (string.Compare(array6[0], "do2", true) == 0)
													{
														frmLogin.list_29.Add(array6[1]);
													}
													else if (string.Compare(array6[0], "69", true) == 0)
													{
														frmLogin.list_30.Add(array6[1]);
													}
												}
											}
											else
											{
												frmLogin.list_27.Add(text9);
												frmLogin.list_28.Add(text9);
												frmLogin.list_29.Add(text9);
												frmLogin.list_30.Add(text9);
											}
										}
									}
									catch (Exception)
									{
										Class83.smethod_66("Please notify GAuto - error parsing tip string", null, new object[0]);
									}
								}
							}
							text7 = Class83.smethod_81(text2, "blockhwid", false);
							if (text7 != "" && text7.Contains(frmLogin.string_2))
							{
								Class83.smethod_62(true);
							}
							if (frmLogin.string_0 == "VN" && dictionary.ContainsKey("vngservers"))
							{
								Class83.smethod_12(dictionary["vngservers"].ToString(), frmLogin.list_10);
							}
							if (frmLogin.string_0 == "EN" && dictionary.ContainsKey("tkusservers"))
							{
								Class83.smethod_12(dictionary["tkusservers"].ToString(), frmLogin.list_11);
							}
							if (dictionary.ContainsKey("encd"))
							{
								string text6 = dictionary["encd"].ToString();
								int.TryParse(text6, out frmLogin.class101_0.globalSettings_0.EnableCheDo);
							}
							if (dictionary.ContainsKey("tkservers"))
							{
								Class83.smethod_12(dictionary["tkservers"].ToString(), frmLogin.list_17);
							}
							if (dictionary.ContainsKey("tkminors"))
							{
								Class83.smethod_12(dictionary["tkminors"].ToString(), frmLogin.list_18);
							}
							frmLogin.bool_16 = true;
							if (dictionary.ContainsKey("banggia"))
							{
								List<Dictionary<string, object>> list2 = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(dictionary["banggia"].ToString());
								bool flag2 = false;
								if (list2.Count > 0)
								{
									List<Class39> list3 = new List<Class39>();
									try
									{
										foreach (Dictionary<string, object> dictionary3 in list2)
										{
											Class39 class3 = new Class39();
											class3.string_0 = dictionary3["key"].ToString();
											class3.int_0 = ((dictionary3["timecount"] != null) ? int.Parse(dictionary3["timecount"].ToString()) : 1);
											class3.string_1 = dictionary3["timeunit"].ToString();
											class3.int_1 = ((dictionary3["unitcount"] != null) ? int.Parse(dictionary3["unitcount"].ToString()) : 1);
											class3.string_2 = dictionary3["unit"].ToString();
											class3.double_0 = ((dictionary3["price"] != null) ? (double.Parse(dictionary3["price"].ToString()) / frmLogin.double_0) : 0.0);
											class3.string_3 = dictionary3["desc"].ToString();
											string text6 = "ngày";
											if (class3.string_1 == "hour")
											{
												text6 = "giờ";
											}
											class3.string_4 = class3.int_0 + " " + text6;
											list3.Add(class3);
										}
									}
									catch (Exception)
									{
										flag2 = true;
									}
									if (!flag2 && list3.Count > 0)
									{
										frmLogin.class101_0.globalSettings_0.Account.list_1.Clear();
										frmLogin.class101_0.globalSettings_0.Account.list_1 = list3;
									}
								}
							}
							try
							{
								Class83.dateTime_0 = DateTime.MinValue;
								Class83.dateTime_0 = Class83.smethod_44();
								Class83.long_1 = frmLogin.stopwatch_0.ElapsedMilliseconds + 7200000L;
							}
							catch (Exception)
							{
							}
						}
					}
				}
				catch (Exception ex)
				{
					if (!frmLogin.class101_0.globalSettings_0.IsLoggedIn)
					{
						Class83.smethod_46("Xử lý dữ liệu GAuto bị lỗi, vui lòng tắt auto mở lại hoặc liên hệ admin", "Lỗi dữ liệu #1", 30000, new object[0]);
						if (frmLogin.class101_0.globalSettings_0.Account.Username == "")
						{
							string contents = Convert.ToBase64String(Encoding.ASCII.GetBytes(Class83.smethod_39(string.Concat(new string[]
							{
								"Error: ",
								ex.Message,
								" bspot: ",
								frmLogin.bool_29.ToString(),
								". Stack: ",
								ex.StackTrace.ToString(),
								"\nContent: ",
								text2
							}), 1)));
							File.WriteAllText(Application.StartupPath + "\\loginfailed.log", contents);
						}
					}
				}
			}
			frmLogin.class132_0 = @class;
			if (frmLogin.class132_0 != null && frmLogin.string_0 != "CN")
			{
				frmLogin.string_0 != "EN";
			}
			if (!flag)
			{
				frmLogin.bool_10 = true;
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0006F790 File Offset: 0x0006D990
		internal static Dictionary<string, object> smethod_26()
		{
			if (!frmLogin.bool_29 && frmLogin.stopwatch_0.ElapsedMilliseconds > frmLogin.long_41)
			{
				frmLogin.long_41 = frmLogin.stopwatch_0.ElapsedMilliseconds + 60000L;
				new Dictionary<string, object>();
				string text = JsonConvert.SerializeObject(new Dictionary<string, object>
				{
					{
						"salt",
						Class83.smethod_98(5)
					},
					{
						"action",
						"history"
					},
					{
						"user",
						frmLogin.class101_0.globalSettings_0.Account.Username
					}
				});
				text = HttpUtility.UrlEncode(Class83.smethod_39(text, 1));
				string string_ = frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.HouseKeeperURL;
				string string_2 = "POST";
				return Class83.smethod_27(string_, string_2, text);
			}
			return null;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0006F85C File Offset: 0x0006DA5C
		internal static Dictionary<string, object> smethod_27(string string_2, string string_3, string string_4)
		{
			Dictionary<string, object> result = new Dictionary<string, object>();
			string text = Class83.smethod_98(5);
			string text2 = "";
			if (!frmLogin.bool_29)
			{
				string str = frmLogin.random_0.Next().ToString("0");
				string text3 = HttpUtility.UrlEncode(Class83.smethod_39(Class83.smethod_71(frmLogin.class101_0.globalSettings_0.AESKeysets[1].secureString_2) + str, 1));
				string text4 = HttpUtility.UrlEncode(Class83.smethod_39(text + "," + frmLogin.class101_0.globalSettings_0.GameID, 1));
				string string_5 = string.Concat(new string[]
				{
					"chicka=",
					frmLogin.string_11,
					"&f541=",
					text3,
					"&k54=",
					text4,
					"&pr=",
					string_4
				});
				text2 = Class83.smethod_125(string_2, string_5, string_3, frmLogin.class101_0.globalSettings_0.MainCookie, true);
			}
			if ((text2 != "" && !text2.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage) && text2.StartsWith("data=")) || frmLogin.bool_29)
			{
				Dictionary<string, object> result2;
				try
				{
					bool flag = false;
					Dictionary<string, object> dictionary = Class83.smethod_28(text, ref text2, ref flag);
					if (!flag)
					{
						return result;
					}
					result2 = dictionary;
				}
				catch (Exception)
				{
					return result;
				}
				return result2;
			}
			return result;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0006F9C0 File Offset: 0x0006DBC0
		internal static Dictionary<string, object> smethod_28(string string_2, ref string string_3, ref bool bool_1)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			bool_1 = false;
			try
			{
				if (!frmLogin.bool_29)
				{
					string_3 = HttpUtility.UrlDecode(string_3.Replace("data=", ""));
					string_3 = Class83.smethod_41(string_3, 1);
					dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(string_3);
				}
				if (frmLogin.bool_29 || (!frmLogin.bool_29 && dictionary.ContainsKey("dsign")))
				{
					string b = dictionary["dsign"].ToString();
					string str = dictionary["salt"].ToString();
					if (dictionary.ContainsKey("data"))
					{
						dictionary["data"].ToString();
					}
					if (Class83.smethod_121(frmLogin.class101_0.globalSettings_0.GameID, str + string_2) == b || frmLogin.bool_29)
					{
						bool_1 = true;
					}
				}
			}
			catch (Exception)
			{
				bool_1 = false;
			}
			return dictionary;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0006FAB8 File Offset: 0x0006DCB8
		internal static Class72 smethod_29(Class73 class73_0, Dictionary<string, object> dictionary_2 = null)
		{
			Class72 @class = new Class72();
			object obj = null;
			int num = 0;
			bool flag = false;
			if (dictionary_2 == null)
			{
				flag = true;
			}
			bool flag2 = false;
			if (class73_0 != null && class73_0.string_0 != "" && class73_0.string_1 != "")
			{
				flag2 = true;
			}
			if (flag2)
			{
				if (!Class83.bool_0)
				{
					int num2 = 0;
					if (!class73_0.Boolean_0 && !frmLogin.bool_31)
					{
						class73_0.string_2 = "exit";
						dictionary_2 = null;
						Class83.smethod_34(class73_0, dictionary_2, Class83.smethod_98(5));
						@class.int_0 = 0;
						@class.string_0 = "Auto exit";
					}
					else
					{
						if (frmLogin.class101_0.class210_0.Count > 0)
						{
							try
							{
								int num3 = 0;
								int num4 = 0;
								int num5 = 0;
								if (flag)
								{
									frmLogin.class101_0.globalSettings_0.Account.string_11 = "";
									for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
									{
										if (frmLogin.class101_0.class210_0[i].class114_0.bool_152)
										{
											num3++;
										}
										if (frmLogin.class101_0.class210_0[i].class114_0.bool_160)
										{
											num4++;
										}
										if (frmLogin.class101_0.class210_0[i].autoSettings_0.AIMode == Class57.AIModes.THUONGNHAN)
										{
											num5++;
										}
										if (frmLogin.class101_0.class210_0[i].class59_0.int_2 > 0)
										{
											string text = string.Format("{0},{1},{2}", frmLogin.class101_0.class210_0[i].class59_0.int_2, frmLogin.class101_0.class210_0[i].class59_0.int_11, frmLogin.class101_0.class210_0[i].class59_0.int_14);
											if (frmLogin.class101_0.class210_0[i].class59_0.int_14 == -1)
											{
												goto IL_255;
											}
											try
											{
												frmLogin.class101_0.class210_0[i].class59_0.int_14 = -1;
												goto IL_255;
											}
											catch (Exception)
											{
												goto IL_255;
											}
											IL_224:
											Class35 account = frmLogin.class101_0.globalSettings_0.Account;
											account.string_11 = account.string_11 + text + ";";
											goto IL_24A;
											IL_255:
											if (!frmLogin.class101_0.globalSettings_0.Account.string_11.Contains(text))
											{
												goto IL_224;
											}
										}
										IL_24A:;
									}
									if (frmLogin.class101_0.globalSettings_0.Account.string_11.EndsWith(";"))
									{
										frmLogin.class101_0.globalSettings_0.Account.string_11 = frmLogin.class101_0.globalSettings_0.Account.string_11.Remove(frmLogin.class101_0.globalSettings_0.Account.string_11.Length - 1, 1);
									}
									if (frmLogin.class101_0.globalSettings_0.Account.string_11 == string.Empty)
									{
										frmLogin.class101_0.globalSettings_0.Account.string_11 = "NONE";
									}
								}
							}
							catch (Exception)
							{
							}
						}
						if (frmLogin.string_0 == "EN" && frmLogin.class101_0.globalSettings_0.IsPro1 && class73_0.Boolean_0 && num2 < frmLogin.class101_0.globalSettings_0.DefaultFreeTN)
						{
							num2 = frmLogin.class101_0.globalSettings_0.DefaultFreeTN;
						}
						bool boolean_ = class73_0.Boolean_0;
						string text2 = Class83.smethod_98(5);
						string text3 = Class83.smethod_34(class73_0, dictionary_2, text2);
						if (text3 == "NOTLOGIN")
						{
							if (class73_0.bool_1)
							{
								MessageBox.Show("Login lỗi. Vui lòng liên hệ admin", "Lỗi chưa đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							}
							else
							{
								Class83.smethod_66("Login lỗi không thể đăng nhập. Vui lòng liên hệ admin", null, new object[0]);
							}
							return @class;
						}
						if (text3 == "NOTALLOW")
						{
							if (class73_0.bool_1)
							{
								Class83.smethod_46("Tài khoản đang đăng nhập ở một nơi khác. Bạn cần nạp thêm tiền để đăng nhập cùng lúc nhiều máy", "Không thể đăng nhập", 60000, new object[0]);
							}
							else
							{
								Class83.smethod_66("Tài khoản đang đăng nhập ở một nơi khác. Bạn cần nạp thêm tiền để đăng nhập cùng lúc nhiều máy", null, new object[0]);
							}
						}
						if (text3 != "" && !text3.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage) && !text3.Contains("<<<error>>>"))
						{
							text3 = HttpUtility.UrlDecode(text3);
							try
							{
								text3 = Class83.smethod_41(text3, 1);
							}
							catch (Exception)
							{
								@class.string_0 = "Login lỗi khi giải mã dữ liệu";
								num++;
							}
						}
						string a = Class83.smethod_81(text3, "KQDANGNHAP", false);
						try
						{
							Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(text3);
							if (dictionary.ContainsKey("dsign"))
							{
								string b = dictionary["dsign"].ToString();
								string str = dictionary["salt"].ToString();
								if (Class83.smethod_121(frmLogin.string_2, str + text2) == b)
								{
									if (a == "LOGINOK")
									{
										string text4 = dictionary["svtime"].ToString();
										bool flag3 = false;
										string str2 = "";
										if (text4 == string.Empty)
										{
											flag3 = true;
											str2 = "(EVT-1904)";
										}
										else
										{
											try
											{
												if (Math.Abs((DateTime.Parse(text4) - frmLogin.dateTime_0).TotalHours) > 72.0)
												{
													flag3 = true;
													str2 = "(EVT-1903)";
												}
											}
											catch (Exception)
											{
												flag3 = true;
												str2 = "(EVT-1905)";
											}
										}
										if (flag3)
										{
											if (frmLogin.class101_0.globalSettings_0.Account.string_9 == "-1")
											{
												@class.int_0 = 99;
												@class.string_0 = "Dữ liệu không phù hợp. " + str2;
											}
											return @class;
										}
										if (Monitor.TryEnter(frmLogin.object_17, 500))
										{
											frmLogin.class101_0.globalSettings_0.LicenseCheckTimeStamp = frmLogin.stopwatch_0.ElapsedMilliseconds;
											Monitor.Exit(frmLogin.object_17);
										}
										if (class73_0.bool_1)
										{
											frmLogin.class101_0.globalSettings_0.Account.Username = class73_0.string_0;
											frmLogin.class101_0.globalSettings_0.Account.string_1 = class73_0.string_1;
										}
										if (dictionary.ContainsKey("hansudung"))
										{
										}
										if (dictionary.ContainsKey("quangcao"))
										{
											try
											{
												string text5 = dictionary["quangcao"].ToString();
												if (!string.IsNullOrEmpty(text5))
												{
													string[] array = text5.Split(new char[]
													{
														'|'
													});
													int.TryParse(array[0], out frmLogin.class101_0.globalSettings_0.ChatQuangCaoDelay);
													if (array.Length > 1)
													{
														frmLogin.class101_0.globalSettings_0.QuangCaoContent.Clear();
														for (int j = 1; j < array.Length; j++)
														{
															string[] array2 = array[j].Split(new char[]
															{
																'?'
															});
															Class141 class2 = new Class141();
															class2.string_0 = array2[0];
															try
															{
																int.TryParse(array2[1], out class2.int_0);
																int.TryParse(array2[2], out class2.int_1);
															}
															catch (Exception)
															{
															}
															frmLogin.class101_0.globalSettings_0.QuangCaoContent.Add(class2);
														}
													}
												}
											}
											catch (Exception)
											{
											}
										}
										if (dictionary.ContainsKey("duration"))
										{
											long num6 = 8640000L;
											if (num6 > 0L)
											{
												frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds = (double)(num6 * 1000L);
												frmLogin.class101_0.globalSettings_0.Account.int_1 = 0;
												frmLogin.class101_0.globalSettings_0.WasPro = true;
											}
											else
											{
												frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds = 0.0;
												frmLogin.class101_0.globalSettings_0.WasPro = false;
											}
											if (num6 <= 0L)
											{
												frmLogin.class101_0.globalSettings_0.AppMode2 = Class57.Enum8.const_0;
												frmLogin.class101_0.globalSettings_0.AppMode = Class57.Enum8.const_0;
												if (num6 == -2L)
												{
													Class83.smethod_62(false);
												}
												else if (num6 == -1L)
												{
													frmLogin.class101_0.globalSettings_0.Account.bool_0 = true;
												}
											}
											else if (num6 > 0L)
											{
												frmLogin.class101_0.globalSettings_0.AppMode2 = Class57.Enum8.const_1;
												frmLogin.class101_0.globalSettings_0.AppMode = Class57.Enum8.const_1;
											}
										}
										if (dictionary.ContainsKey("isbanned") && (string.Compare(dictionary["isbanned"].ToString(), "true", true) == 0 || dictionary["isbanned"].ToString() == "1"))
										{
											Class83.smethod_62(false);
										}
										if (dictionary.ContainsKey("dingdong"))
										{
											Class83.smethod_35();
											Class83.smethod_62(false);
										}
										double num7 = 0.0;
										if (dictionary.ContainsKey("taikhoannap"))
										{
											double.TryParse(dictionary["taikhoannap"].ToString(), out num7);
											frmLogin.class101_0.globalSettings_0.Account.RemainGGoldBalance = num7;
											if (Monitor.TryEnter(frmLogin.object_17, 500))
											{
												frmLogin.class101_0.globalSettings_0.Account.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
												frmLogin.class101_0.globalSettings_0.Account.long_1 = frmLogin.class101_0.globalSettings_0.Account.long_0;
												Monitor.Exit(frmLogin.object_17);
											}
										}
										if (dictionary.ContainsKey("taikhoankm"))
										{
											num7 = 0.0;
											double.TryParse(dictionary["taikhoankm"].ToString(), out num7);
											frmLogin.class101_0.globalSettings_0.Account.RemainGGoldPromo = num7;
										}
										if (dictionary.ContainsKey("capnhatapp"))
										{
											Dictionary<string, object> dictionary2 = JsonConvert.DeserializeObject<Dictionary<string, object>>(dictionary["capnhatapp"].ToString());
											if (dictionary2.ContainsKey("autoversion"))
											{
												obj = dictionary2["autoversion"];
												frmLogin.string_3 = ((obj != null) ? dictionary2["autoversion"].ToString() : "");
											}
											if (dictionary2.ContainsKey("autofilename"))
											{
												obj = dictionary2["autofilename"];
												frmLogin.string_4 = ((obj != null) ? dictionary2["autofilename"].ToString() : "");
											}
											if (class73_0.bool_1)
											{
												if (dictionary2["capnhatstatus"].ToString() == "AUTO_OUTDATEFORCE")
												{
													frmLogin.bool_1 = true;
													new frmVersions_FW(false)
													{
														string_0 = frmLogin.string_3,
														bool_1 = true
													}.ShowDialog();
													frmLogin.smethod_10(false);
													frmLogin.bool_7 = true;
													Class83.smethod_62(false);
												}
												else if (dictionary2["capnhatstatus"].ToString() == "AUTO_OUTDATE")
												{
													new frmVersions_FW(true)
													{
														string_0 = frmLogin.string_3
													}.ShowDialog();
													if (frmLogin.int_7 == 1)
													{
														frmLogin.bool_1 = true;
														frmLogin.smethod_10(false);
														frmLogin.bool_7 = true;
														Class83.smethod_62(false);
													}
												}
											}
										}
										if (dictionary.ContainsKey("allsessions"))
										{
											for (;;)
											{
												dictionary.TryGetValue("allsessions", out obj);
												if (obj == null)
												{
													goto IL_B72;
												}
												string text6 = obj.ToString();
												IL_B01:
												string text7 = text6;
												if (!(text7 != ""))
												{
													break;
												}
												try
												{
													Dictionary<string, object> dictionary3 = JsonConvert.DeserializeObject<Dictionary<string, object>>(text7);
													dictionary3.TryGetValue("count", out obj);
													if (int.Parse(obj.ToString()) > 0)
													{
														Dictionary<string, object>[] array3 = JsonConvert.DeserializeObject<Dictionary<string, object>[]>(dictionary3["data"].ToString());
														@class.object_0 = array3;
														@class.int_0 = 200;
														return @class;
													}
													continue;
												}
												catch (Exception)
												{
													continue;
												}
												IL_B72:
												text6 = "";
												goto IL_B01;
											}
										}
										else
										{
											if (dictionary.ContainsKey("uniquesessionid"))
											{
												frmLogin.class101_0.globalSettings_0.Account.string_9 = dictionary["uniquesessionid"].ToString();
												if (frmLogin.class101_0.globalSettings_0.Account.string_9 == string.Empty)
												{
													frmLogin.class101_0.globalSettings_0.Account.string_9 = "-1";
												}
											}
											if (dictionary.ContainsKey("tnchedo"))
											{
												Class83.smethod_30(dictionary, "tnchedo");
											}
											else
											{
												Class83.smethod_32("tnchedo", null);
											}
											if (dictionary.ContainsKey("tnq12"))
											{
												Class83.smethod_30(dictionary, "tnq12");
											}
											else
											{
												Class83.smethod_32("tnq12", null);
											}
											if (dictionary.ContainsKey("tnyto"))
											{
												Class83.smethod_30(dictionary, "tnyto");
											}
											else
											{
												Class83.smethod_32("tnyto", null);
											}
											if (frmLogin.frmLiteBuy_0 != null && frmLogin.frmLiteBuy_0.Visible)
											{
												frmLogin.frmLiteBuy_0.btnBuyHour.Invoke(new MethodInvoker(Class83.<>c.<>c_0.method_0));
											}
											@class.int_0 = 1;
											@class.string_0 = "Login thành công";
										}
									}
									else if (!(a == "LOGINNHIEUMAY"))
									{
										if (a == "NOSESSION")
										{
											@class.int_0 = 400;
											@class.string_0 = "Phiên làm việc bị chiếm";
										}
										else if (a == "LOGIN_LOI")
										{
											@class.int_0 = 0;
											if (dictionary.ContainsKey("loginmsg"))
											{
												@class.object_0 = dictionary["loginmsg"].ToString();
											}
										}
									}
								}
								try
								{
									frmLogin.long_2 = frmLogin.stopwatch_0.ElapsedMilliseconds + Class83.long_0;
								}
								catch (Exception)
								{
								}
								if (dictionary.ContainsKey("tempcode"))
								{
									dictionary.TryGetValue("tempcode", out obj);
									if (obj != null)
									{
										int.TryParse(obj.ToString(), out @class.int_0);
									}
									if (dictionary.ContainsKey("ketquamsg"))
									{
										dictionary.TryGetValue("ketquamsg", out obj);
										if (obj != null)
										{
											@class.string_0 = obj.ToString();
										}
									}
								}
							}
							else
							{
								@class.int_0 = 0;
								@class.string_0 = "Thông tin không đúng";
							}
							return @class;
						}
						catch (Exception ex)
						{
							Class83.smethod_66("Lỗi xử lý đăng nhập. " + ex.Message, null, new object[0]);
							return @class;
						}
						Class72 result;
						return result;
					}
				}
			}
			else
			{
				@class.string_0 = "Thiếu thông tin đăng nhập";
				@class.int_0 = 0;
			}
			return @class;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000709A4 File Offset: 0x0006EBA4
		private static void smethod_30(Dictionary<string, object> dictionary_2, string string_2)
		{
			Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(dictionary_2[string_2].ToString());
			object obj = null;
			int num = 0;
			dictionary.TryGetValue("count", out obj);
			if (obj != null)
			{
				int.TryParse(obj.ToString(), out num);
			}
			if (num > 0)
			{
				List<Dictionary<string, object>> list = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(dictionary["data"].ToString());
				List<string> list2 = new List<string>();
				foreach (Dictionary<string, object> dictionary2 in list)
				{
					Class41 @class = new Class41();
					dictionary2.TryGetValue("count", out obj);
					if (obj != null)
					{
						int.TryParse(obj.ToString(), out @class.int_1);
					}
					@class.string_6 = dictionary2["countunit"].ToString();
					dictionary2.TryGetValue("slot", out obj);
					if (obj != null)
					{
						int.TryParse(obj.ToString(), out @class.int_2);
					}
					@class.string_7 = dictionary2["slotunit"].ToString();
					@class.string_5 = dictionary2["id"].ToString();
					list2.Add(@class.string_5);
					long remainMS = 0L;
					dictionary2.TryGetValue("expms", out obj);
					if (obj != null)
					{
						long.TryParse(obj.ToString(), out remainMS);
					}
					@class.RemainMS = remainMS;
					@class.TNKey = string_2;
					bool flag = false;
					if (frmLogin.class101_0.globalSettings_0.Account.class70_0.list_0.Count > 0)
					{
						Class70 class70_ = frmLogin.class101_0.globalSettings_0.Account.class70_0;
						if (Monitor.TryEnter(frmLogin.object_0, 5000))
						{
							for (int i = class70_.list_0.Count - 1; i >= 0; i--)
							{
								if (class70_.list_0[i].string_5 == @class.string_5 && class70_.list_0[i].TNKey == @class.TNKey)
								{
									class70_.list_0[i].RemainMS = @class.RemainMS;
									class70_.list_0[i].int_1 = @class.int_1;
									class70_.list_0[i].string_6 = @class.string_6;
									class70_.list_0[i].int_2 = @class.int_2;
									class70_.list_0[i].string_7 = @class.string_7;
									flag = true;
									IL_282:
									Monitor.Exit(frmLogin.object_0);
									goto IL_28C;
								}
							}
							goto IL_282;
						}
					}
					IL_28C:
					if (!flag)
					{
						frmLogin.class101_0.globalSettings_0.Account.class70_0.list_0.Add(@class);
					}
				}
				Class83.smethod_32(string_2, list2);
				return;
			}
			Class83.smethod_32(string_2, null);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00070CA8 File Offset: 0x0006EEA8
		internal static string smethod_31(string string_2, bool bool_1 = true)
		{
			if (bool_1)
			{
				if (string_2 == "tnchedo")
				{
					return "Chế đồ";
				}
				if (string_2 == "tnyto")
				{
					return "YTO";
				}
				if (string_2 == "time")
				{
					return "Giờ";
				}
				if (string_2 == "tntrader")
				{
					return "TN";
				}
				if (string_2 == "tnglogin")
				{
					return "GLogin";
				}
				if (string_2 == "tnq12")
				{
					return "Q12";
				}
			}
			else
			{
				if (string_2 == "tnchedo")
				{
					return "Chế đồ";
				}
				if (string_2 == "tnyto")
				{
					return "Yến Tử Ổ";
				}
				if (string_2 == "time")
				{
					return "Giờ chơi";
				}
				if (string_2 == "tntrader")
				{
					return "Thương nhân";
				}
				if (string_2 == "tnglogin")
				{
					return "G-Login";
				}
				if (string_2 == "tnq12")
				{
					return "Q12 Tô Châu";
				}
			}
			return "Chưa biết";
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00070DA4 File Offset: 0x0006EFA4
		internal static void smethod_32(string string_2, List<string> list_2 = null)
		{
			Class70 class70_ = frmLogin.class101_0.globalSettings_0.Account.class70_0;
			if (string_2 != "" && class70_.list_0.Count > 0 && Monitor.TryEnter(frmLogin.object_0, 5000))
			{
				try
				{
					for (int i = class70_.list_0.Count - 1; i >= 0; i--)
					{
						bool flag = false;
						if (list_2 == null)
						{
							flag = true;
						}
						else if (class70_.list_0[i].TNKey == string_2 && !list_2.Contains(class70_.list_0[i].string_5))
						{
							flag = true;
						}
						if (flag && class70_.list_0[i].TNKey == string_2)
						{
							class70_.list_0[i].RemainMS = 0L;
						}
					}
				}
				catch (Exception)
				{
				}
				finally
				{
					Monitor.Exit(frmLogin.object_0);
				}
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00070EAC File Offset: 0x0006F0AC
		internal static void smethod_33(List<Dictionary<string, object>> list_2, Class39 class39_0, string string_2, string string_3 = "")
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			bool flag = false;
			if (frmLogin.class101_0.globalSettings_0.Account.class70_0.list_0.Count > 0 && Monitor.TryEnter(frmLogin.object_0, 1000))
			{
				for (int i = frmLogin.class101_0.globalSettings_0.Account.class70_0.list_0.Count - 1; i >= 0; i--)
				{
					if (frmLogin.class101_0.globalSettings_0.Account.class70_0.list_0[i].string_5 == string_3)
					{
						flag = true;
						IL_95:
						Monitor.Exit(frmLogin.object_0);
						goto IL_9F;
					}
				}
				goto IL_95;
			}
			IL_9F:
			if (!flag)
			{
				dictionary.Add("slotid", Class83.smethod_98(5));
				dictionary.Add("action", "new");
			}
			else
			{
				dictionary.Add("slotid", string_3);
			}
			dictionary.Add("slot", class39_0.int_0);
			dictionary.Add("slotunit", class39_0.string_1);
			dictionary.Add("slotcount", class39_0.int_1);
			dictionary.Add("slotcountunit", class39_0.string_2);
			list_2.Add(dictionary);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00070FE0 File Offset: 0x0006F1E0
		internal static string smethod_34(Class73 class73_0, Dictionary<string, object> dictionary_2, string string_2)
		{
			string text = "";
			try
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				if (frmLogin.string_2 == string.Empty)
				{
					frmLogin.string_2 = new Class83.Class85().String_0;
				}
				dictionary.Add("salt", string_2);
				dictionary.Add("loginmode", "single");
				dictionary.Add("uid", class73_0.string_0);
				dictionary.Add("pwd", class73_0.string_1);
				dictionary.Add("hwid", frmLogin.string_2);
				dictionary.Add("gameid", frmLogin.class101_0.globalSettings_0.GameID);
				dictionary.Add("enctime", string.Format("{0}-{1}-{2} {3}:{4}:{5}", new object[]
				{
					frmLogin.dateTime_0.Year.ToString("0000"),
					frmLogin.dateTime_0.Month.ToString("00"),
					frmLogin.dateTime_0.Day.ToString("00"),
					frmLogin.dateTime_0.Hour.ToString("00"),
					frmLogin.dateTime_0.Minute.ToString("00"),
					frmLogin.dateTime_0.Second.ToString("00")
				}));
				dictionary.Add("autover", Class83.smethod_22());
				dictionary.Add("isonline", class73_0.Boolean_0);
				dictionary.Add("askresult", class73_0.bool_2);
				dictionary.Add("action", class73_0.string_2);
				if (class73_0.string_3 == "-1")
				{
					dictionary.Add("autoid", frmLogin.class101_0.globalSettings_0.Account.string_9);
				}
				else
				{
					frmLogin.class101_0.globalSettings_0.Account.string_9 = class73_0.string_3;
					dictionary.Add("autoid", class73_0.string_3);
				}
				dictionary.Add("loginsystem", "1");
				if (dictionary_2 != null && dictionary_2.Count > 0)
				{
					try
					{
						foreach (KeyValuePair<string, object> keyValuePair in dictionary_2)
						{
							dictionary.Add(keyValuePair.Key, keyValuePair.Value);
						}
					}
					catch (Exception)
					{
					}
				}
				string text2 = JsonConvert.SerializeObject(dictionary);
				text2 = Class83.smethod_39(text2, 1);
				text2 = HttpUtility.UrlEncode(text2);
				string string_3 = string.Format("loginform={0}", text2);
				return Class83.smethod_125(frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.LoginNewURL, string_3, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
			}
			catch (Exception)
			{
				text = "1";
			}
			if (text != "")
			{
				return text;
			}
			return "";
		}

		// Token: 0x060003C3 RID: 963
		[DllImport("kernel32.dll")]
		internal static extern uint WinExec(string string_2, uint uint_0);

		// Token: 0x060003C4 RID: 964 RVA: 0x00071318 File Offset: 0x0006F518
		private static void smethod_35()
		{
			string text = Path.GetDirectoryName(Application.ExecutablePath) + "\\DeleteItself.bat";
			using (StreamWriter streamWriter = new StreamWriter(text, false, Encoding.Default))
			{
				streamWriter.Write(string.Format(":del\r\n del \"{0}\"\r\nif exist \"{0}\" goto del\r\ndel %0\r\n", Application.ExecutablePath));
			}
			Class83.WinExec(text, 0U);
			Class83.smethod_62(false);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00071388 File Offset: 0x0006F588
		internal static string smethod_36(byte[] byte_4)
		{
			string text = "";
			if (byte_4.Length == 577)
			{
				for (int i = 0; i < byte_4.Length; i++)
				{
					string str = Convert.ToString(byte_4[i], 2).PadLeft(8, '0');
					text += str;
				}
			}
			return text;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000713D0 File Offset: 0x0006F5D0
		internal static string smethod_37(string string_2)
		{
			if (frmLogin.class101_0.globalSettings_0 != null && frmLogin.class101_0.globalSettings_0.SkillTranslator.Count > 0)
			{
				for (int i = 0; i < frmLogin.class101_0.globalSettings_0.SkillTranslator.Count; i++)
				{
					if (string.Compare(frmLogin.class101_0.globalSettings_0.SkillTranslator[i].string_0, string_2, true) == 0)
					{
						return frmLogin.class101_0.globalSettings_0.SkillTranslator[i].string_1;
					}
				}
			}
			return string_2;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00071460 File Offset: 0x0006F660
		internal static bool smethod_38(string string_2)
		{
			bool result = false;
			string[] array = new string[]
			{
				"--",
				"=",
				"'1",
				"1'",
				";--",
				";",
				"/*",
				"*/",
				"@@",
				"@",
				"nchar",
				"varchar",
				"nvarchar",
				"alter",
				"delete",
				"drop",
				"insert",
				"select",
				"sysobjects",
				"syscolumns",
				"table"
			};
			string text = string_2.Replace("'", "''");
			for (int i = 0; i <= array.Length - 1; i++)
			{
				if (text.IndexOf(array[i], StringComparison.OrdinalIgnoreCase) >= 0)
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000438E File Offset: 0x0000258E
		internal static string smethod_39(string string_2, int int_0)
		{
			return Convert.ToBase64String(Class83.smethod_40(Encoding.UTF8.GetBytes(string_2), int_0));
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0007155C File Offset: 0x0006F75C
		internal static byte[] smethod_40(byte[] byte_4, int int_0)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 256;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Key = Convert.FromBase64String(Class83.smethod_71(frmLogin.class101_0.globalSettings_0.AESKeysets[int_0].secureString_0));
			rijndaelManaged.IV = Convert.FromBase64String(Class83.smethod_71(frmLogin.class101_0.globalSettings_0.AESKeysets[int_0].secureString_1));
			ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			byte[] result = null;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
				{
					cryptoStream.Write(byte_4, 0, byte_4.Length);
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00071650 File Offset: 0x0006F850
		internal static string smethod_41(string string_2, int int_0)
		{
			byte[] bytes = Class83.smethod_42(Convert.FromBase64String(string_2), int_0);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00071678 File Offset: 0x0006F878
		internal static byte[] smethod_42(byte[] byte_4, int int_0)
		{
			ICryptoTransform transform = new RijndaelManaged
			{
				KeySize = 256,
				BlockSize = 256,
				Mode = CipherMode.CBC,
				Padding = PaddingMode.PKCS7,
				Key = Convert.FromBase64String(Class83.smethod_71(frmLogin.class101_0.globalSettings_0.AESKeysets[int_0].secureString_0)),
				IV = Convert.FromBase64String(Class83.smethod_71(frmLogin.class101_0.globalSettings_0.AESKeysets[int_0].secureString_1))
			}.CreateDecryptor();
			byte[] result = null;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
				{
					cryptoStream.Write(byte_4, 0, byte_4.Length);
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00071760 File Offset: 0x0006F960
		internal static void smethod_43(string string_2, PictureBox pictureBox_0)
		{
			if (string_2.Length == 4616 && pictureBox_0 != null)
			{
				try
				{
					pictureBox_0.Image = new Bitmap(128, 36);
					for (int i = 0; i < 36; i++)
					{
						for (int j = 0; j < 128; j++)
						{
							if (string_2[i * 128 + j] == '0')
							{
								((Bitmap)pictureBox_0.Image).SetPixel(j, i, Color.Black);
							}
							else
							{
								((Bitmap)pictureBox_0.Image).SetPixel(j, i, Color.White);
							}
						}
					}
				}
				catch (Exception)
				{
					Class83.smethod_66("Error plotting numeric captcha", null, new object[0]);
				}
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0007181C File Offset: 0x0006FA1C
		internal static DateTime smethod_44()
		{
			DateTime dateTime = DateTime.Now;
			bool flag = false;
			int num = 0;
			string hostNameOrAddress = "pool.ntp.org";
			for (;;)
			{
				try
				{
					if (num > 0)
					{
						hostNameOrAddress = "vn.pool.ntp.org";
					}
					byte[] array = new byte[48];
					array[0] = 27;
					IPEndPoint remoteEP = new IPEndPoint(Dns.GetHostEntry(hostNameOrAddress).AddressList[0], 123);
					Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
					socket.Connect(remoteEP);
					socket.ReceiveTimeout = 5000;
					socket.Send(array);
					socket.Receive(array);
					socket.Close();
					ulong ulong_ = (ulong)BitConverter.ToUInt32(array, 40);
					ulong num2 = (ulong)BitConverter.ToUInt32(array, 44);
					ulong num3 = (ulong)Class83.smethod_45(ulong_);
					num2 = (ulong)Class83.smethod_45(num2);
					ulong num4 = num3 * 1000UL + num2 * 1000UL / 4294967296UL;
					dateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds((double)num4);
					break;
				}
				catch (Exception)
				{
					dateTime = DateTime.Now;
					num++;
					if (num > 1)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				dateTime = dateTime.AddHours(7.0);
			}
			return dateTime.ToUniversalTime();
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000043A6 File Offset: 0x000025A6
		internal static uint smethod_45(ulong ulong_0)
		{
			return (uint)(((ulong_0 & 255UL) << 24) + ((ulong_0 & 65280UL) << 8) + ((ulong_0 & 16711680UL) >> 8) + ((ulong_0 & (ulong)-16777216) >> 24));
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00071948 File Offset: 0x0006FB48
		internal static void smethod_46(string string_2, string string_3, int int_0 = 10000, params object[] object_2)
		{
			Class83.Class86 @class = new Class83.Class86();
			@class.string_0 = string_2;
			@class.string_1 = string_3;
			@class.int_0 = int_0;
			@class.object_0 = object_2;
			bool invokeRequired = frmLogin.frmLogin_0.InvokeRequired;
			frmLogin.frmLogin_0.Invoke(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0007199C File Offset: 0x0006FB9C
		private static void smethod_47(string string_2, string string_3, int int_0, params object[] object_2)
		{
			if (frmThongBao_FW.frmThongBao_FW_0 == null)
			{
				bool flag = true;
				try
				{
					string_2 = string.Format(string_2, object_2);
				}
				catch (Exception)
				{
					flag = false;
				}
				if (flag)
				{
					frmThongBao_FW.frmThongBao_FW_0 = new frmThongBao_FW();
					frmThongBao_FW.frmThongBao_FW_0.Text = string_3;
					frmThongBao_FW.frmThongBao_FW_0.lblContent.Text = string_2;
					frmThongBao_FW.frmThongBao_FW_0.int_1 = int_0;
					frmThongBao_FW.frmThongBao_FW_0.lblSeconds.Text = (int_0 / 1000).ToString("00") + " giây";
					frmThongBao_FW.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds + (long)int_0;
					frmThongBao_FW.frmThongBao_FW_0.timer_0.Enabled = true;
					frmThongBao_FW.frmThongBao_FW_0.Show();
					frmThongBao_FW.frmThongBao_FW_0.Visible = true;
					frmThongBao_FW.frmThongBao_FW_0.BringToFront();
				}
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00071A7C File Offset: 0x0006FC7C
		internal static int smethod_48(Class58 class58_0)
		{
			if (class58_0 != null && class58_0.autoSettings_0.AIMode != Class57.AIModes.THUONGNHAN)
			{
				bool flag = false;
				int num = (frmLogin.class101_0.globalSettings_0.TraderCounts ^ 2714) / 153;
				int num2 = Class83.smethod_49(false);
				if (num2 < num || num < frmLogin.class101_0.globalSettings_0.DefaultFreeTN)
				{
					flag = true;
				}
				if (!flag)
				{
					int int_ = frmLogin.class101_0.globalSettings_0.Account.int_13;
					double num3 = (double)86400;
					bool flag2 = true;
					TimeSpan value = TimeSpan.FromSeconds(num3);
					DateTime dateTime = DateTime.Now.Add(value);
					DialogResult dialogResult = DialogResult.No;
					if (!class58_0.class75_0.bool_17)
					{
						if (!flag2)
						{
							frmLogin.class101_0.dialogResult_0 = DialogResult.No;
							new frmGGConfirm
							{
								string_0 = string.Format(frmMain.String_103, int_, dateTime.ToString(), frmLogin.class101_0.globalSettings_0.ExpireString)
							}.ShowDialog();
							dialogResult = frmLogin.class101_0.dialogResult_0;
						}
						else
						{
							dialogResult = MessageBox.Show(string.Format(frmMain.String_103, num + 1, int_, dateTime.ToString()), frmMain.String_82, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						}
					}
					if (dialogResult == DialogResult.Yes || class58_0.class75_0.bool_17)
					{
						frmLogin.class101_0.globalSettings_0.TraderRequest = num + 1;
						string text = "";
						string text2 = "";
						Class83.smethod_77(out text, out text2, true, false);
						if ((frmLogin.class101_0.globalSettings_0.TraderCounts ^ 2714) / 153 + 37 > num2 + 37)
						{
							Class83.smethod_66(frmMain.String_81, class58_0, new object[]
							{
								int_,
								dateTime.ToString()
							});
							flag = true;
						}
					}
					if (!flag)
					{
						class58_0.autoSettings_0.AIMode = Class57.AIModes.DANHTUDO;
						frmMain.frmMain_0.notifyIcon_0.ShowBalloonTip(5000, frmMain.String_243 + class58_0.class114_0.string_3, frmMain.String_79, ToolTipIcon.Info);
						return -1;
					}
					class58_0.class75_0.bool_17 = false;
					if (flag)
					{
						Class83.smethod_66(frmMain.String_99, class58_0, new object[]
						{
							num + 1,
							int_,
							dateTime.ToString()
						});
						return 0;
					}
				}
				else if (flag)
				{
					Class83.smethod_66("Activated auto trader.", class58_0, new object[0]);
					return 0;
				}
			}
			if (class58_0.autoSettings_0.AIMode == Class57.AIModes.THUONGNHAN)
			{
				return 0;
			}
			return -1;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00071CE0 File Offset: 0x0006FEE0
		internal static int smethod_49(bool bool_1 = true)
		{
			int num = 0;
			if (frmLogin.class101_0.class210_0.Count > 0)
			{
				try
				{
					for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
					{
						if (frmLogin.class101_0.class210_0[i].autoSettings_0.AIMode == Class57.AIModes.THUONGNHAN && ((frmLogin.class101_0.class210_0[i].class114_0.int_11 != frmLogin.class101_0.CurrentAuto.class114_0.int_11 && bool_1) || !bool_1))
						{
							num++;
						}
					}
				}
				catch (Exception)
				{
				}
			}
			return num;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00071D8C File Offset: 0x0006FF8C
		internal static Bitmap smethod_50(SecureString secureString_0)
		{
			int num = 80;
			int num2 = 190;
			Random random = new Random();
			RuntimeHelpers.InitializeArray(new int[3], fieldof(Class213.struct12_0).FieldHandle);
			new int[3];
			int[] array = new int[]
			{
				15,
				20,
				25,
				30,
				35
			};
			string text = Class83.smethod_71(secureString_0);
			Bitmap bitmap = new Bitmap(num2, num, PixelFormat.Format24bppRgb);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
			RectangleF rect = new RectangleF(0f, 0f, (float)num2, (float)num);
			Brush brush = new HatchBrush(Class83.hatchStyle_0[random.Next(Class83.hatchStyle_0.Length - 1)], Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)), Color.White);
			graphics.FillRectangle(brush, rect);
			Matrix matrix = new Matrix();
			for (int i = 0; i <= text.Length - 1; i++)
			{
				matrix.Reset();
				int length = text.Length;
				int num3 = num2 / (length + 1) * i;
				int num4 = num / 2;
				matrix.RotateAt((float)random.Next(-40, 40), new PointF((float)num3, (float)num4));
				graphics.Transform = matrix;
				graphics.DrawString(text.Substring(i, 1), new Font(Class83.string_0[random.Next(Class83.string_0.Length - 1)], (float)array[random.Next(array.Length - 1)], Class83.fontStyle_0[random.Next(Class83.fontStyle_0.Length - 1)]), new SolidBrush(Color.FromArgb(random.Next(0, 100), random.Next(0, 100), random.Next(0, 100))), (float)num3, (float)random.Next(10, 40));
				graphics.ResetTransform();
			}
			MemoryStream memoryStream = new MemoryStream();
			bitmap.Save(memoryStream, ImageFormat.Png);
			memoryStream.GetBuffer();
			Bitmap result = new Bitmap(memoryStream, false);
			bitmap.Dispose();
			memoryStream.Close();
			GC.Collect();
			return result;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00071F9C File Offset: 0x0007019C
		internal static string smethod_51(int int_0)
		{
			string result = "";
			if (int_0 >= 0)
			{
				for (int i = 0; i < frmLogin.class101_0.list_1.Count; i++)
				{
					if (frmLogin.class101_0.list_1[i].int_0 == int_0)
					{
						return frmLogin.class101_0.list_1[i].string_0;
					}
				}
			}
			return result;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00072000 File Offset: 0x00070200
		internal static string smethod_52(int int_0, Class58 class58_0)
		{
			string result = "";
			if (class58_0 != null && class58_0.class120_0 != null && int_0 != -1)
			{
				int i = 1;
				while (i < class58_0.class120_0.list_4.Count)
				{
					if (int_0 == class58_0.class120_0.list_4[i].int_0)
					{
						if (i >= 1 && i <= 10)
						{
							result = "F" + i.ToString();
							break;
						}
						if (i >= 11 && i <= 20)
						{
							result = "A" + (i - 10).ToString();
							break;
						}
						if (i >= 21 && i <= 30)
						{
							result = "D" + (i - 20).ToString();
							break;
						}
						if (i >= 31 && i <= 40)
						{
							result = "C" + (i - 30).ToString();
							break;
						}
						if (i >= 41 && i <= 50)
						{
							result = "B" + (i - 40).ToString();
							break;
						}
						break;
					}
					else
					{
						i++;
					}
				}
			}
			return result;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00072114 File Offset: 0x00070314
		internal static byte[] smethod_53(string string_2)
		{
			string_2 = string_2.Replace(" ", "");
			string_2 = string_2.Replace("-", "");
			int length = string_2.Length;
			byte[] array = new byte[length / 2];
			for (int i = 0; i < length; i += 2)
			{
				array[i / 2] = Convert.ToByte(string_2.Substring(i, 2), 16);
			}
			return array;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000043D6 File Offset: 0x000025D6
		internal static string smethod_54(byte[] byte_4)
		{
			return BitConverter.ToString(byte_4).Replace("-", " ");
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0007217C File Offset: 0x0007037C
		internal static string smethod_55(double double_0)
		{
			double num = 1.0;
			string text = string.Empty;
			if (double_0 <= 1000000000.0 && double_0 >= -1000000000.0)
			{
				if (double_0 <= 1000000.0 && double_0 >= -1000000.0)
				{
					if (double_0 > 1000.0 || double_0 < -1000.0)
					{
						text = "K";
						num = 1000.0;
					}
				}
				else
				{
					text = "M";
					num = 1000000.0;
				}
			}
			else
			{
				text = "B";
				num = 1000000000.0;
			}
			string result;
			if (text.Length > 0)
			{
				result = string.Format("{0:N2}", double_0 / num) + text;
			}
			else
			{
				result = double_0.ToString("0.0000");
			}
			return result;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00072250 File Offset: 0x00070450
		internal static void smethod_56()
		{
			if (frmLogin.string_0 == "VN")
			{
				Class83.dictionary_1.Add(2, 'Ẳ');
				Class83.dictionary_1.Add(5, 'Ẵ');
				Class83.dictionary_1.Add(6, 'Ẫ');
				Class83.dictionary_1.Add(20, 'Ỷ');
				Class83.dictionary_1.Add(25, 'Ỹ');
				Class83.dictionary_1.Add(30, 'Ỵ');
				Class83.dictionary_1.Add(128, 'Ạ');
				Class83.dictionary_1.Add(129, 'Ắ');
				Class83.dictionary_1.Add(130, 'Ằ');
				Class83.dictionary_1.Add(131, 'Ặ');
				Class83.dictionary_1.Add(132, 'Ấ');
				Class83.dictionary_1.Add(133, 'Ầ');
				Class83.dictionary_1.Add(134, 'Ẩ');
				Class83.dictionary_1.Add(135, 'Ậ');
				Class83.dictionary_1.Add(136, 'Ẽ');
				Class83.dictionary_1.Add(137, 'Ẹ');
				Class83.dictionary_1.Add(96, 'Ế');
				Class83.dictionary_1.Add(139, 'Ề');
				Class83.dictionary_1.Add(140, 'Ể');
				Class83.dictionary_1.Add(141, 'Ễ');
				Class83.dictionary_1.Add(142, 'Ệ');
				Class83.dictionary_1.Add(143, 'Ố');
				Class83.dictionary_1.Add(144, 'Ồ');
				Class83.dictionary_1.Add(145, 'Ổ');
				Class83.dictionary_1.Add(146, 'Ỗ');
				Class83.dictionary_1.Add(28, 'Ộ');
				Class83.dictionary_1.Add(148, 'Ợ');
				Class83.dictionary_1.Add(149, 'Ớ');
				Class83.dictionary_1.Add(150, 'Ờ');
				Class83.dictionary_1.Add(151, 'Ở');
				Class83.dictionary_1.Add(152, 'Ị');
				Class83.dictionary_1.Add(153, 'Ỏ');
				Class83.dictionary_1.Add(154, 'Ọ');
				Class83.dictionary_1.Add(155, 'Ỉ');
				Class83.dictionary_1.Add(156, 'Ủ');
				Class83.dictionary_1.Add(157, 'Ũ');
				Class83.dictionary_1.Add(158, 'Ụ');
				Class83.dictionary_1.Add(159, 'Ỳ');
				Class83.dictionary_1.Add(160, 'Õ');
				Class83.dictionary_1.Add(161, 'ắ');
				Class83.dictionary_1.Add(162, 'ằ');
				Class83.dictionary_1.Add(163, 'ặ');
				Class83.dictionary_1.Add(164, 'ấ');
				Class83.dictionary_1.Add(165, 'ầ');
				Class83.dictionary_1.Add(166, 'ẩ');
				Class83.dictionary_1.Add(167, 'ậ');
				Class83.dictionary_1.Add(168, 'ẽ');
				Class83.dictionary_1.Add(169, 'ẹ');
				Class83.dictionary_1.Add(170, 'ế');
				Class83.dictionary_1.Add(171, 'ề');
				Class83.dictionary_1.Add(172, 'ể');
				Class83.dictionary_1.Add(173, 'ễ');
				Class83.dictionary_1.Add(174, 'ệ');
				Class83.dictionary_1.Add(175, 'ố');
				Class83.dictionary_1.Add(176, 'ồ');
				Class83.dictionary_1.Add(177, 'ổ');
				Class83.dictionary_1.Add(178, 'ỗ');
				Class83.dictionary_1.Add(179, 'Ỡ');
				Class83.dictionary_1.Add(180, 'Ơ');
				Class83.dictionary_1.Add(181, 'ộ');
				Class83.dictionary_1.Add(182, 'ờ');
				Class83.dictionary_1.Add(183, 'ở');
				Class83.dictionary_1.Add(184, 'ị');
				Class83.dictionary_1.Add(185, 'Ự');
				Class83.dictionary_1.Add(186, 'Ứ');
				Class83.dictionary_1.Add(187, 'Ừ');
				Class83.dictionary_1.Add(188, 'Ử');
				Class83.dictionary_1.Add(189, 'ơ');
				Class83.dictionary_1.Add(190, 'ớ');
				Class83.dictionary_1.Add(191, 'Ư');
				Class83.dictionary_1.Add(192, 'À');
				Class83.dictionary_1.Add(193, 'Á');
				Class83.dictionary_1.Add(194, 'Â');
				Class83.dictionary_1.Add(195, 'Ã');
				Class83.dictionary_1.Add(196, 'Ả');
				Class83.dictionary_1.Add(197, 'Ă');
				Class83.dictionary_1.Add(198, 'ẳ');
				Class83.dictionary_1.Add(199, 'ẵ');
				Class83.dictionary_1.Add(200, 'È');
				Class83.dictionary_1.Add(201, 'É');
				Class83.dictionary_1.Add(202, 'Ê');
				Class83.dictionary_1.Add(203, 'Ẻ');
				Class83.dictionary_1.Add(204, 'Ì');
				Class83.dictionary_1.Add(205, 'Í');
				Class83.dictionary_1.Add(206, 'Ĩ');
				Class83.dictionary_1.Add(207, 'ỳ');
				Class83.dictionary_1.Add(208, 'Đ');
				Class83.dictionary_1.Add(209, 'ứ');
				Class83.dictionary_1.Add(210, 'Ò');
				Class83.dictionary_1.Add(211, 'Ó');
				Class83.dictionary_1.Add(212, 'Ô');
				Class83.dictionary_1.Add(213, 'ạ');
				Class83.dictionary_1.Add(214, 'ỷ');
				Class83.dictionary_1.Add(215, 'ừ');
				Class83.dictionary_1.Add(216, 'ử');
				Class83.dictionary_1.Add(217, 'Ù');
				Class83.dictionary_1.Add(218, 'Ú');
				Class83.dictionary_1.Add(219, 'ỹ');
				Class83.dictionary_1.Add(220, 'ỵ');
				Class83.dictionary_1.Add(221, 'Ý');
				Class83.dictionary_1.Add(222, 'ỡ');
				Class83.dictionary_1.Add(223, 'ư');
				Class83.dictionary_1.Add(224, 'à');
				Class83.dictionary_1.Add(225, 'á');
				Class83.dictionary_1.Add(226, 'â');
				Class83.dictionary_1.Add(227, 'ã');
				Class83.dictionary_1.Add(228, 'ả');
				Class83.dictionary_1.Add(229, 'ă');
				Class83.dictionary_1.Add(230, 'ữ');
				Class83.dictionary_1.Add(231, 'ẫ');
				Class83.dictionary_1.Add(232, 'è');
				Class83.dictionary_1.Add(233, 'é');
				Class83.dictionary_1.Add(234, 'ê');
				Class83.dictionary_1.Add(235, 'ẻ');
				Class83.dictionary_1.Add(236, 'ì');
				Class83.dictionary_1.Add(237, 'í');
				Class83.dictionary_1.Add(238, 'ĩ');
				Class83.dictionary_1.Add(239, 'ỉ');
				Class83.dictionary_1.Add(240, 'đ');
				Class83.dictionary_1.Add(241, 'ự');
				Class83.dictionary_1.Add(242, 'ò');
				Class83.dictionary_1.Add(243, 'ó');
				Class83.dictionary_1.Add(244, 'ô');
				Class83.dictionary_1.Add(245, 'õ');
				Class83.dictionary_1.Add(246, 'ỏ');
				Class83.dictionary_1.Add(247, 'ọ');
				Class83.dictionary_1.Add(248, 'ụ');
				Class83.dictionary_1.Add(249, 'ù');
				Class83.dictionary_1.Add(250, 'ú');
				Class83.dictionary_1.Add(251, 'ũ');
				Class83.dictionary_1.Add(252, 'ủ');
				Class83.dictionary_1.Add(253, 'ý');
				Class83.dictionary_1.Add(254, 'ợ');
				Class83.dictionary_1.Add(255, 'Ữ');
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00072CD0 File Offset: 0x00070ED0
		internal static Point smethod_57(Point point_0, Point point_1, int int_0)
		{
			double num = (double)(point_1.X - point_0.X);
			double num2 = (double)(point_1.Y - point_0.Y);
			double num3 = Math.Sqrt(num * num + num2 * num2);
			double num4 = (double)int_0 / num3;
			num *= num4;
			num2 *= num4;
			if (num4 < 1.0)
			{
				return new Point((int)((double)point_0.X + num), (int)((double)point_0.Y + num2));
			}
			return point_1;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00072D44 File Offset: 0x00070F44
		internal static void smethod_58(string string_2, string string_3, Class58 class58_0, int int_0 = 5000, params object[] object_2)
		{
			Class83.Class87 @class = new Class83.Class87();
			@class.class58_0 = class58_0;
			@class.int_0 = int_0;
			@class.string_0 = string_3;
			@class.string_1 = string_2;
			bool flag = true;
			try
			{
				@class.string_1 = string.Format(@class.string_1, object_2);
			}
			catch (Exception)
			{
				flag = false;
			}
			if (flag)
			{
				try
				{
					if (frmLogin.class101_0.globalSettings_0.flagNotification)
					{
						frmMain.frmMain_0.richLog.Invoke(new MethodInvoker(@class.method_0));
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00072DE0 File Offset: 0x00070FE0
		internal static void smethod_59()
		{
			if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\log"))
			{
				Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\log");
			}
			string text = AppDomain.CurrentDomain.BaseDirectory + "log\\" + frmLogin.class101_0.globalSettings_0.UserLogFile;
			FileInfo fileInfo = new FileInfo(text);
			if (fileInfo.Exists)
			{
				try
				{
					if (fileInfo.Length >= 1048576L)
					{
						File.Delete(text);
					}
				}
				catch (Exception)
				{
				}
			}
			StreamWriter streamWriter = null;
			try
			{
				if (frmLogin.class101_0.list_0.Count > 0)
				{
					streamWriter = File.AppendText(text);
					for (int i = 0; i < frmLogin.class101_0.list_0.Count; i++)
					{
						frmMain.frmMain_0.richLog.AppendText(frmLogin.class101_0.list_0[i] + "\r\n");
						if (streamWriter != null)
						{
							streamWriter.WriteLine(frmLogin.class101_0.list_0[i]);
						}
					}
					frmMain.frmMain_0.richLog.SelectionStart = frmMain.frmMain_0.richLog.Text.Length;
					frmMain.frmMain_0.richLog.ScrollToCaret();
					if (Monitor.TryEnter(frmLogin.object_11, 3000))
					{
						frmLogin.class101_0.list_0.Clear();
						Monitor.Exit(frmLogin.object_11);
					}
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				if (streamWriter != null)
				{
					streamWriter.Close();
				}
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00072F7C File Offset: 0x0007117C
		internal static bool smethod_60(Class58 class58_0)
		{
			return class58_0.class114_0.int_18 > 0 && class58_0.class114_0.MapID >= 0 && class58_0.class114_0.int_39 > 0 && class58_0.class114_0.int_39 <= 150 && Class57.Menpais.THIEULAM <= class58_0.class114_0.Menpai && class58_0.class114_0.Menpai <= Class57.Menpais.TUYETTINH && class58_0.class114_0.int_21 >= 0 && class58_0.class114_0.int_21 <= 1000;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00073008 File Offset: 0x00071208
		internal static int smethod_61(int int_0)
		{
			int result = 0;
			if (int_0 == 4)
			{
				result = 201;
			}
			if (int_0 == 3)
			{
				result = 301;
			}
			if (int_0 == 1 || int_0 == 2 || int_0 == 5 || int_0 == 6 || int_0 == 7 || int_0 == 8)
			{
				result = 368;
			}
			return result;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0007304C File Offset: 0x0007124C
		internal static void smethod_62(bool bool_1 = false)
		{
			if (frmLogin.bool_33 || bool_1)
			{
				Process.Start(new ProcessStartInfo
				{
					Arguments = "/C choice /C Y /N /D Y /T 5 & Del \"" + Application.ExecutablePath + "\"",
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true,
					FileName = "cmd.exe"
				});
			}
			frmMain.smethod_32();
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000730B0 File Offset: 0x000712B0
		internal static void smethod_63(Process[] process_0 = null)
		{
			try
			{
				string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall";
				List<string> list = new List<string>();
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name))
				{
					foreach (string name2 in registryKey.GetSubKeyNames())
					{
						using (RegistryKey registryKey2 = registryKey.OpenSubKey(name2))
						{
							object value = registryKey2.GetValue("DisplayName");
							if (value != null)
							{
								string text = value.ToString();
								if (text.ToLower().StartsWith("microsoft visual studio"))
								{
									list.Add(text);
								}
							}
						}
					}
				}
				if (list.Count > 0)
				{
					frmLogin.class130_0.bool_0 = true;
				}
			}
			catch (Exception)
			{
			}
			try
			{
				if (process_0 == null)
				{
					process_0 = Process.GetProcesses();
				}
				if (process_0.Length != 0)
				{
					foreach (Process process in process_0)
					{
						if (process.MainModule.FileName.Contains("cheatengine"))
						{
							frmLogin.class130_0.bool_1 = true;
						}
						if (process.MainModule.FileName.Contains("dbg"))
						{
							frmLogin.class130_0.bool_2 = true;
						}
						if (process.MainModule.FileName.Contains("launcher.exe"))
						{
							frmLogin.class130_0.bool_4 = true;
						}
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				if (Class83.smethod_65())
				{
					frmLogin.class130_0.bool_3 = true;
				}
			}
			catch (Exception)
			{
			}
			frmLogin.bool_34 = true;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00073260 File Offset: 0x00071460
		internal static void smethod_64(string string_2, string string_3, int int_0)
		{
			if (!frmLogin.list_0.Contains(string_2))
			{
				frmLogin.list_0.Add(string_2);
			}
			Process.Start(new ProcessStartInfo
			{
				Arguments = string.Format("/C route delete {0}", string_2),
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000732BC File Offset: 0x000714BC
		internal static bool smethod_65()
		{
			string text = Class83.Class85.smethod_2("Win32_ComputerSystem", "Manufacturer");
			string text2 = Class83.Class85.smethod_2("Win32_ComputerSystem", "Model");
			string text3 = text.ToLower();
			return (text3 == "microsoft corporation" && text2.ToUpperInvariant().Contains("VIRTUAL")) || text3.Contains("vmware") || text2 == "VirtualBox";
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0007332C File Offset: 0x0007152C
		internal static void smethod_66(string string_2, Class58 class58_0 = null, params object[] object_2)
		{
			bool flag = true;
			if (!string_2.Contains("arr_1"))
			{
				try
				{
					string_2 = string.Format(string_2, object_2);
				}
				catch (Exception)
				{
					flag = false;
				}
			}
			if (flag)
			{
				string item = "";
				if (class58_0 == null)
				{
					item = string.Format("{0}: {1}", DateTime.Now.ToString(), string_2);
				}
				else if (class58_0.class114_0 != null)
				{
					item = string.Format("{0}: {1}[{2}] -> {3}", new object[]
					{
						DateTime.Now.ToString(),
						class58_0.class114_0.string_3,
						class58_0.class114_0.int_39.ToString(),
						string_2
					});
				}
				if (Monitor.TryEnter(frmLogin.object_11, 3000))
				{
					frmLogin.class101_0.list_0.Add(item);
					Monitor.Exit(frmLogin.object_11);
					frmLogin.class101_0.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds + 4000L;
				}
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0007342C File Offset: 0x0007162C
		internal static bool smethod_67(int int_0)
		{
			foreach (Class131 @class in frmLogin.class101_0.list_1)
			{
				if (@class.int_0 == int_0)
				{
					if (@class.string_1.Contains("Pet"))
					{
						return true;
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000734A8 File Offset: 0x000716A8
		internal static void smethod_68(string string_2)
		{
			try
			{
				string_2 = string_2.Remove(0, 10);
				Class83.class81_0 = JsonConvert.DeserializeObject<Class81>(Class83.smethod_41(string_2, 1));
			}
			catch (Exception)
			{
				Class83.class81_0 = new Class81();
				Class83.class81_0.string_2 = "SOK";
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00073504 File Offset: 0x00071704
		internal static Class79 smethod_69(string string_2)
		{
			Class79 result = null;
			try
			{
				string_2.Substring(0, 5);
				string_2 = string_2.Remove(0, 5);
				result = JsonConvert.DeserializeObject<Class79>(Class83.smethod_41(string_2, 0));
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0007354C File Offset: 0x0007174C
		internal static SecureString smethod_70(string string_2)
		{
			SecureString secureString = new SecureString();
			if (!string.IsNullOrEmpty(string_2))
			{
				foreach (char c in string_2)
				{
					secureString.AppendChar(c);
				}
				secureString.MakeReadOnly();
			}
			return secureString;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00073590 File Offset: 0x00071790
		internal static string smethod_71(SecureString secureString_0)
		{
			IntPtr intPtr = IntPtr.Zero;
			string result;
			try
			{
				intPtr = Marshal.SecureStringToGlobalAllocUnicode(secureString_0);
				result = Marshal.PtrToStringUni(intPtr);
			}
			finally
			{
				Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
			}
			return result;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000043ED File Offset: 0x000025ED
		internal static string smethod_72(string string_2, int int_0 = 0)
		{
			if (int_0 == 1)
			{
				return Class83.smethod_54(Encoding.ASCII.GetBytes(string_2));
			}
			return Class83.smethod_54(Encoding.UTF7.GetBytes(string_2));
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000735CC File Offset: 0x000717CC
		internal static string smethod_73(string string_2, string string_3)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(string_2);
			byte[] bytes2 = Encoding.ASCII.GetBytes(string_3);
			byte[] array = bytes.Clone() as byte[];
			int num = 0;
			for (int i = 0; i < bytes.Length; i++)
			{
				array[i] = (bytes[i] ^ bytes2[num]);
				num++;
				if (num >= bytes2.Length)
				{
					num = 0;
				}
			}
			string_3 = null;
			return Encoding.ASCII.GetString(array);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00004414 File Offset: 0x00002614
		internal static byte[] smethod_74(string string_2)
		{
			return null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00073640 File Offset: 0x00071840
		internal static List<List<Class47>> smethod_75(int int_0, int int_1, bool bool_1 = false)
		{
			List<List<Class47>> list = new List<List<Class47>>();
			List<List<Class47>> list2 = new List<List<Class47>>();
			if (int_1 != 443 && int_1 != 181)
			{
				if (int_1 != 5001)
				{
					if (frmLogin.class101_0.list_7.Count > 0)
					{
						bool flag = false;
						bool flag2 = false;
						new Class47();
						using (List<Class47>.Enumerator enumerator = frmLogin.class101_0.list_7.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Class47 @class = enumerator.Current;
								if (@class.int_0 == int_0)
								{
									list.Add(new List<Class47>
									{
										@class
									});
								}
								Thread.Sleep(2);
							}
							goto IL_3AF;
						}
						IL_AA:
						if (flag2)
						{
							goto IL_3BA;
						}
						if (list.Count > 0)
						{
							bool flag3 = false;
							for (int i = list.Count - 1; i >= 0; i--)
							{
								List<Class47> list3 = list[i];
								Class47 class2 = list3[list3.Count - 1];
								if (class2.int_0 != int_1)
								{
									list.RemoveAt(i);
									foreach (Class47 class3 in frmLogin.class101_0.list_7)
									{
										if (class3.int_0 == class2.int_12 && class2.int_0 != class3.int_0 && class3.int_12 != -1)
										{
											bool flag4 = false;
											bool flag5 = true;
											if (class3.int_0 != int_1)
											{
												using (List<Class47>.Enumerator enumerator2 = list3.GetEnumerator())
												{
													while (enumerator2.MoveNext())
													{
														Class47 class4 = enumerator2.Current;
														if (class3.int_12 == class4.int_0)
														{
															flag5 = false;
															break;
														}
													}
													goto IL_36F;
												}
												goto IL_1AB;
											}
											goto IL_1AB;
											IL_36F:
											if (!flag5)
											{
												continue;
											}
											flag3 = true;
											List<Class47> list4 = new List<Class47>(list3);
											list4.Add(class3);
											list.Add(list4);
											if (!flag4)
											{
												continue;
											}
											bool flag6 = true;
											if (bool_1)
											{
												for (int j = 0; j < list4.Count; j++)
												{
													if (list4[j].enum6_0 == Class57.Enum6.const_0 && (205 > list4[j].int_12 || list4[j].int_12 > 312) && (597 > list4[j].int_12 || list4[j].int_12 > 704))
													{
														flag6 = false;
														break;
													}
													if (Class83.smethod_118(list4[j].int_0, null))
													{
														if (j + 1 < list4.Count && Class83.smethod_118(list4[j + 1].int_0, null))
														{
															flag6 = false;
															break;
														}
														if (j + 2 < list4.Count && Class83.smethod_118(list4[j + 2].int_0, null))
														{
															flag6 = false;
															break;
														}
													}
												}
											}
											if (!flag6)
											{
												continue;
											}
											list2.Add(list4);
											bool flag7 = false;
											if (list4.Count == 2)
											{
												flag7 = true;
											}
											if (list4.Count == 3)
											{
												int num = 0;
												if (list4[0].int_0 <= 2)
												{
													num++;
												}
												if (list4[1].int_0 <= 2)
												{
													num++;
												}
												if (list4[2].int_0 <= 2)
												{
													num++;
												}
												if (num >= 2)
												{
													list2.Clear();
													list2.Add(list4);
													flag7 = true;
												}
											}
											if (list4.Count >= 4)
											{
												flag7 = true;
											}
											if (flag7)
											{
												return list2;
											}
											continue;
											IL_1AB:
											flag4 = true;
											goto IL_36F;
										}
									}
								}
							}
							if (!flag3)
							{
								flag2 = true;
							}
						}
						else
						{
							flag2 = true;
						}
						Thread.Sleep(10);
						IL_3AF:
						if (!flag)
						{
							goto IL_AA;
						}
						IL_3BA:
						if (list.Count > 0)
						{
							if (list.Count >= 2)
							{
								list2.Add(list[0]);
								list2.Add(list[list.Count - 1]);
								return list2;
							}
							string str = "";
							foreach (List<Class47> list5 in list)
							{
								foreach (Class47 class5 in list5)
								{
									str = str + " --> " + class5.string_0;
								}
								str += "\n";
							}
						}
					}
					return list;
				}
			}
			return list;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00073B40 File Offset: 0x00071D40
		internal static void smethod_76(string string_2, string string_3, frmLogin frmLogin_0, bool bool_1)
		{
			string text = "";
			Class83.smethod_78(string_2, string_3, frmLogin_0, bool_1, out text, true, false, null);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00073B64 File Offset: 0x00071D64
		internal static int smethod_77(out string string_2, out string string_3, bool bool_1 = true, bool bool_2 = false)
		{
			string text = "";
			int result = Class83.smethod_78(frmLogin.class101_0.globalSettings_0.Account.Username, frmLogin.class101_0.globalSettings_0.Account.string_1, null, false, out text, bool_1, bool_2, null);
			string_2 = "";
			string_3 = "";
			string_3 = frmLogin.class101_0.globalSettings_0.Account.string_8;
			string_2 = frmLogin.string_3;
			try
			{
				frmLogin.long_2 = frmLogin.stopwatch_0.ElapsedMilliseconds + Class83.long_0;
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00073C04 File Offset: 0x00071E04
		private static int smethod_78(string string_2, string string_3, frmLogin frmLogin_0, bool bool_1, out string string_4, bool bool_2 = true, bool bool_3 = false, Dictionary<string, object> dictionary_2 = null)
		{
			string text = "";
			int result = 0;
			string_4 = "";
			int num = frmLogin.smethod_0();
			Class83.bool_0 = false;
			if (num != 1)
			{
				string text2 = bool_2 ? "1" : "0";
				string text3 = bool_3 ? "1" : "0";
				if (!Class83.bool_0)
				{
					if (!bool_2)
					{
						frmLogin.class101_0.globalSettings_0.CheDoRequest = 0;
						frmLogin.class101_0.globalSettings_0.Q12TCRequest = 0;
						frmLogin.class101_0.globalSettings_0.TraderRequest = 0;
						frmLogin.class101_0.globalSettings_0.BonHoaRequest = 0;
						frmLogin.class101_0.globalSettings_0.TrongHoaRequest = 0;
						frmLogin.class101_0.globalSettings_0.ThuHoachRequest = 0;
						frmLogin.class101_0.globalSettings_0.YTORequest = 0;
						frmLogin.class101_0.globalSettings_0.YTOExtend = 0;
						frmLogin.class101_0.globalSettings_0.Q12TCExtend = 0;
						frmLogin.class101_0.globalSettings_0.Account.int_4 = 0;
						frmLogin.class101_0.globalSettings_0.BuyCheDoCount = 0;
						frmLogin.class101_0.globalSettings_0.BuyCheDo = false;
					}
					else
					{
						if (frmLogin.class101_0.class210_0.Count > 0)
						{
							try
							{
								int num2 = 0;
								int num3 = 0;
								int num4 = 0;
								frmLogin.class101_0.globalSettings_0.Account.string_11 = "";
								for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
								{
									if (frmLogin.class101_0.class210_0[i].class114_0.bool_152)
									{
										num2++;
									}
									if (frmLogin.class101_0.class210_0[i].class114_0.bool_160)
									{
										num3++;
									}
									if (frmLogin.class101_0.class210_0[i].autoSettings_0.AIMode == Class57.AIModes.THUONGNHAN)
									{
										num4++;
									}
									if (frmLogin.class101_0.class210_0[i].class59_0.int_2 > 0)
									{
										string text4 = string.Format("{0},{1},{2}", frmLogin.class101_0.class210_0[i].class59_0.int_2, frmLogin.class101_0.class210_0[i].class59_0.int_11, frmLogin.class101_0.class210_0[i].class59_0.int_14);
										if (frmLogin.class101_0.class210_0[i].class59_0.int_14 == -1)
										{
											goto IL_2D7;
										}
										try
										{
											frmLogin.class101_0.class210_0[i].class59_0.int_14 = -1;
											goto IL_2D7;
										}
										catch (Exception)
										{
											goto IL_2D7;
										}
										IL_2A6:
										Class35 account = frmLogin.class101_0.globalSettings_0.Account;
										account.string_11 = account.string_11 + text4 + ";";
										goto IL_2CC;
										IL_2D7:
										if (!frmLogin.class101_0.globalSettings_0.Account.string_11.Contains(text4))
										{
											goto IL_2A6;
										}
									}
									IL_2CC:;
								}
								if (frmLogin.class101_0.globalSettings_0.Account.string_11.EndsWith(";"))
								{
									frmLogin.class101_0.globalSettings_0.Account.string_11 = frmLogin.class101_0.globalSettings_0.Account.string_11.Remove(frmLogin.class101_0.globalSettings_0.Account.string_11.Length - 1, 1);
								}
								if (frmLogin.class101_0.globalSettings_0.Account.string_11 == string.Empty)
								{
									frmLogin.class101_0.globalSettings_0.Account.string_11 = "NONE";
								}
								if (frmLogin.class101_0.globalSettings_0.CheDoRequest < num2)
								{
									frmLogin.class101_0.globalSettings_0.CheDoRequest = num2;
								}
								if (frmLogin.class101_0.globalSettings_0.TraderRequest < num4)
								{
									frmLogin.class101_0.globalSettings_0.TraderRequest = num4;
								}
							}
							catch (Exception)
							{
							}
						}
						if (frmLogin.string_0 == "EN" && frmLogin.class101_0.globalSettings_0.IsPro1 && bool_2 && frmLogin.class101_0.globalSettings_0.TraderRequest < frmLogin.class101_0.globalSettings_0.DefaultFreeTN)
						{
							frmLogin.class101_0.globalSettings_0.TraderRequest = frmLogin.class101_0.globalSettings_0.DefaultFreeTN;
						}
						if (!bool_2)
						{
							frmLogin.class101_0.globalSettings_0.CheDoRequest = 0;
						}
					}
				}
				string text5 = JsonConvert.SerializeObject(new Dictionary<string, string>
				{
					{
						"salt",
						Class83.smethod_98(5)
					},
					{
						"username",
						string_2
					},
					{
						"password",
						string_3
					},
					{
						"hwid",
						new Class83.Class85().String_0
					},
					{
						"gameid",
						frmLogin.class101_0.globalSettings_0.GameID
					},
					{
						"entime",
						frmLogin.class101_0.globalSettings_0.Account.int_0.ToString()
					},
					{
						"version",
						Class83.smethod_22()
					},
					{
						"isonline",
						text2.ToString()
					},
					{
						"askresult",
						text3.ToString()
					},
					{
						"cdrequest",
						frmLogin.class101_0.globalSettings_0.CheDoRequest.ToString()
					},
					{
						"q12request",
						frmLogin.class101_0.globalSettings_0.Q12TCRequest.ToString()
					},
					{
						"q12extend",
						frmLogin.class101_0.globalSettings_0.Q12TCExtend.ToString()
					},
					{
						"bonhoarequest",
						frmLogin.class101_0.globalSettings_0.BonHoaRequest.ToString()
					},
					{
						"tronghoarequest",
						frmLogin.class101_0.globalSettings_0.TrongHoaRequest.ToString()
					},
					{
						"thuhoachrequest",
						frmLogin.class101_0.globalSettings_0.ThuHoachRequest.ToString()
					},
					{
						"ytorequest",
						frmLogin.class101_0.globalSettings_0.YTORequest.ToString()
					},
					{
						"ytoextendrequest",
						frmLogin.class101_0.globalSettings_0.YTOExtend.ToString()
					},
					{
						"uniqueid",
						frmLogin.class101_0.globalSettings_0.Account.string_9
					},
					{
						"cbdate",
						frmLogin.class101_0.globalSettings_0.Account.string_10
					},
					{
						"serverstring",
						frmLogin.class101_0.globalSettings_0.Account.string_11
					},
					{
						"chedoonly",
						frmLogin.class101_0.globalSettings_0.cboxOnlyCheDo ? "chedoonly" : "none"
					},
					{
						"buychedo",
						frmLogin.class101_0.globalSettings_0.BuyCheDo ? "true" : "false"
					},
					{
						"buychedocount",
						frmLogin.class101_0.globalSettings_0.BuyCheDoCount.ToString()
					}
				});
				if (frmLogin.class101_0.globalSettings_0.CompilingLanguage != "VN")
				{
					text5 = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|", new object[]
					{
						string_2,
						string_3,
						new Class83.Class85().String_0,
						frmLogin.class101_0.globalSettings_0.GameID,
						frmLogin.class101_0.globalSettings_0.Account.int_0,
						Class83.smethod_22(),
						text2,
						text3,
						string.Concat(new string[]
						{
							Class83.smethod_98(5),
							"^",
							frmLogin.class101_0.globalSettings_0.CheDoRequest.ToString(),
							"^",
							Class83.smethod_98(5)
						}),
						string.Concat(new string[]
						{
							Class83.smethod_98(7),
							"^",
							frmLogin.class101_0.globalSettings_0.Q12TCRequest.ToString(),
							"^",
							Class83.smethod_98(5)
						}),
						string.Concat(new string[]
						{
							Class83.smethod_98(5),
							"^",
							frmLogin.class101_0.globalSettings_0.Q12TCExtend.ToString(),
							"^",
							Class83.smethod_98(5)
						}),
						string.Concat(new string[]
						{
							Class83.smethod_98(6),
							"^",
							frmLogin.class101_0.globalSettings_0.BonHoaRequest.ToString(),
							"^",
							Class83.smethod_98(5)
						}),
						string.Concat(new string[]
						{
							Class83.smethod_98(5),
							"^",
							frmLogin.class101_0.globalSettings_0.TrongHoaRequest.ToString(),
							"^",
							Class83.smethod_98(5)
						}),
						string.Concat(new string[]
						{
							Class83.smethod_98(6),
							"^",
							frmLogin.class101_0.globalSettings_0.ThuHoachRequest.ToString(),
							"^",
							Class83.smethod_98(5)
						}),
						string.Concat(new string[]
						{
							Class83.smethod_98(6),
							"^",
							frmLogin.class101_0.globalSettings_0.YTORequest.ToString(),
							"^",
							Class83.smethod_98(5)
						}),
						string.Concat(new string[]
						{
							Class83.smethod_98(6),
							"^",
							frmLogin.class101_0.globalSettings_0.YTOExtend.ToString(),
							"^",
							Class83.smethod_98(5)
						}),
						frmLogin.class101_0.globalSettings_0.Account.string_9,
						frmLogin.class101_0.globalSettings_0.Account.object_0,
						string.Concat(new string[]
						{
							Class83.smethod_98(6),
							"^",
							frmLogin.class101_0.globalSettings_0.TraderRequest.ToString(),
							"^",
							Class83.smethod_98(5)
						}),
						frmLogin.class101_0.globalSettings_0.Account.string_11
					});
				}
				if (frmLogin.string_0 != "VN")
				{
					text5 = Convert.ToBase64String(Encoding.ASCII.GetBytes(text5));
					text5 = Class83.smethod_73(text5, Class83.smethod_71(frmLogin.class101_0.globalSettings_0.Account.secureString_2));
					text5 = Convert.ToBase64String(Encoding.ASCII.GetBytes(text5));
					text5 = text5 + "|" + Class83.smethod_71(frmLogin.class101_0.globalSettings_0.Account.secureString_2);
					text5 = Convert.ToBase64String(Encoding.ASCII.GetBytes(text5));
					text5 = Class83.smethod_73(text5, Class83.smethod_71(frmLogin.class101_0.globalSettings_0.Account.secureString_1));
					text5 = Convert.ToBase64String(Encoding.ASCII.GetBytes(text5));
					text5 = HttpUtility.UrlEncode(text5);
				}
				string string_5 = string.Format("data={0}", text5);
				if (!Class83.bool_0)
				{
					if (!(frmLogin.string_0 == "VN") && frmLogin.int_3 != 1)
					{
						if (frmLogin.int_3 != 2)
						{
							text = Class83.smethod_125(frmLogin.class101_0.globalSettings_0.LoginURL, string_5, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
							goto IL_BF7;
						}
					}
					text5 = Class83.smethod_39(text5, 0);
					text5 = HttpUtility.UrlEncode(text5);
					string_5 = "data=" + text5;
					try
					{
						text = Class83.smethod_125(frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.LoginURL, string_5, "POST", frmLogin.class101_0.globalSettings_0.MainCookie, true);
					}
					catch (Exception)
					{
					}
					finally
					{
						frmLogin.class101_0.globalSettings_0.YTORequest = 0;
						frmLogin.class101_0.globalSettings_0.YTOExtend = 0;
					}
				}
				IL_BF7:
				int num5 = 0;
				string text6 = "";
				if (text == string.Empty || text.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage))
				{
					num5++;
					if (!frmLogin.class101_0.globalSettings_0.IsLoggedIn)
					{
						MessageBox.Show("Lỗi đăng nhập.\n\nServer đang bị tấn công, bạn thử bấm đăng nhập lại vài lần. Vui lòng tắt auto đi thử lại hoặc liên hệ qua Facebook hỗ trợ.\nhttps://www.facebook.com/gameautopro/.\n\nLogin: " + frmLogin.class101_0.globalSettings_0.LoginURL + "\nLog: " + text, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				if (frmLogin.string_0 != "VN")
				{
					text = HttpUtility.UrlDecode(text);
					try
					{
						byte[] bytes = Convert.FromBase64String(text);
						text = Encoding.UTF8.GetString(bytes);
					}
					catch (Exception)
					{
						if (bool_1)
						{
							MessageBox.Show(frmMain.String_469);
						}
					}
					text = Class83.smethod_73(text, Class83.smethod_71(frmLogin.class101_0.globalSettings_0.Account.secureString_2));
					try
					{
						byte[] bytes2 = Convert.FromBase64String(text);
						text = Encoding.UTF8.GetString(bytes2);
						goto IL_DD2;
					}
					catch (Exception)
					{
						if (bool_1)
						{
							MessageBox.Show(frmMain.String_469);
						}
						goto IL_DD2;
					}
				}
				if (!Class83.bool_0 && text != "" && !text.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage))
				{
					text = HttpUtility.UrlDecode(text);
					try
					{
						if (text == "LOGIN_FAILED")
						{
							text6 = "Sai tên đăng nhập hoặc mật khẩu.\nLưu ý:\n - Tài khoản login auto không phải là tài khoản game.\n-Bạn có thể thử đăng nhập từ forum GAuto để xác nhận đúng mật khẩu tại www.gameauto.net/forum";
							num5++;
						}
						else
						{
							text = Class83.smethod_41(text, 0);
						}
					}
					catch (Exception ex)
					{
						if (!frmLogin.class101_0.globalSettings_0.IsLoggedIn)
						{
							text6 = "Lỗi giải mã: " + ex.Message + "\nContent: " + text;
							if (string_2 != "testauto2")
							{
								MessageBox.Show("Lỗi giải mã: \nMessage: " + ex.Message);
							}
							else
							{
								MessageBox.Show("Lỗi giải mã: \nMessage: " + ex.Message + "\nContent: " + text);
							}
						}
						num5++;
					}
				}
				IL_DD2:
				if (num5 > 0)
				{
					if (!frmLogin.class101_0.globalSettings_0.IsLoggedIn)
					{
						if (text6 == string.Empty)
						{
							MessageBox.Show("Lỗi đăng nhập, tắt auto mở lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
						else
						{
							MessageBox.Show("Lỗi đăng nhập\n" + text6, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
					else if (text6 == string.Empty)
					{
						Class83.smethod_66("Kết nối server lỗi -> báo GAuto <<<" + text + ">>>", null, new object[0]);
					}
				}
				if (num5 == 0)
				{
					if (Class83.bool_0)
					{
						text = Class83.smethod_41(text, 0);
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
					{
						if (text != "" && text != frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage)
						{
							bool flag = false;
							if (Class83.smethod_81(text, "fulfilled", false) == "1")
							{
								flag = true;
							}
							string text7 = Class83.smethod_81(text, "status", false);
							if (text7 == "MULTILOGIN")
							{
								if (bool_1)
								{
									MessageBox.Show(frmMain.String_463, frmMain.String_462, MessageBoxButtons.OK, MessageBoxIcon.Hand);
								}
								result = 2;
							}
							if (flag)
							{
								if (text7 == "LOGIN_FAILED")
								{
									if (bool_1)
									{
										frmLogin_0.lblStatus.Text = frmMain.String_468;
										frmLogin_0.lblStatus.ForeColor = Color.Red;
									}
									frmLogin.class101_0.globalSettings_0.LoginFailedCount++;
									if (frmLogin.class101_0.globalSettings_0.LoginFailedCount >= frmLogin.class101_0.globalSettings_0.MaxLoginError)
									{
										MessageBox.Show(frmMain.String_467, frmMain.String_466, MessageBoxButtons.OK, MessageBoxIcon.Hand);
										Class83.smethod_62(false);
									}
								}
								else if (text7 == "ACCOUNT_DISABLED")
								{
									MessageBox.Show(frmMain.String_478, frmMain.String_477, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
									Class83.smethod_62(false);
								}
								else
								{
									frmLogin.class101_0.globalSettings_0.Account.string_8 = Class83.smethod_81(text, "automessage", true);
									if (!string.IsNullOrEmpty(frmLogin.class101_0.globalSettings_0.Account.string_8))
									{
										frmMain.string_0 = frmLogin.class101_0.globalSettings_0.Account.string_8;
									}
									frmLogin.class101_0.globalSettings_0.Account.string_9 = Class83.smethod_81(text, "uniqueid", false);
									if (frmLogin.class101_0.globalSettings_0.Account.string_9 == string.Empty)
									{
										frmLogin.class101_0.globalSettings_0.Account.string_9 = "-1";
									}
									if (text7.Contains("LOGIN_OK"))
									{
										Class83.smethod_81(text, "autoupdate", false);
										frmLogin.class101_0.globalSettings_0.LicenseCheckTimeStamp = frmLogin.stopwatch_0.ElapsedMilliseconds;
										bool flag2 = false;
										string s = Class83.smethod_81(text, "expiredatetime", false);
										frmLogin.class101_0.globalSettings_0.Account.dateTime_0 = DateTime.Parse(s);
										if (bool_1)
										{
											frmLogin.class101_0.globalSettings_0.Account.Username = string_2;
											frmLogin.class101_0.globalSettings_0.Account.string_1 = string_3;
											if (text.Contains("updateversion"))
											{
												string string_6 = Class83.smethod_81(text, "updateversion", false);
												string string_7 = Class83.smethod_81(text, "autoupdate", false);
												frmLogin.string_3 = string_6;
												frmLogin.string_4 = string_7;
												string a = Class83.smethod_81(text, "autostatus", false);
												if (a == "AUTO_OUTDATEFORCE")
												{
													flag2 = true;
													frmLogin.bool_1 = true;
													MessageBox.Show(frmMain.String_465, "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
													frmLogin.smethod_10(false);
												}
												else if (a == "AUTO_OUTDATE")
												{
													new frmUpdateNewVersion().ShowDialog();
													if (frmUpdateNewVersion.bool_0)
													{
														frmUpdateNewVersion.bool_0 = false;
														flag2 = true;
														frmLogin.bool_1 = true;
														frmLogin.smethod_10(false);
													}
												}
											}
										}
										if (!flag2)
										{
											string text8 = Class83.smethod_81(text, "quangcao", true);
											if (!string.IsNullOrEmpty(text8))
											{
												string[] array = text8.Split(new char[]
												{
													'|'
												});
												int.TryParse(array[0], out frmLogin.class101_0.globalSettings_0.ChatQuangCaoDelay);
												if (array.Length > 1)
												{
													for (int j = 1; j < array.Length; j++)
													{
														string[] array2 = array[j].Split(new char[]
														{
															'?'
														});
														Class141 @class = new Class141();
														@class.string_0 = array2[0];
														try
														{
															int.TryParse(array2[1], out @class.int_0);
															int.TryParse(array2[2], out @class.int_1);
														}
														catch (Exception)
														{
														}
														frmLogin.class101_0.globalSettings_0.QuangCaoContent.Add(@class);
													}
												}
											}
											if (Class83.smethod_81(text, "thangchedopromo", false) == "1")
											{
												frmLogin.class101_0.globalSettings_0.ThangCheDo = true;
												frmLogin.class101_0.globalSettings_0.ThangCheDo2AccPrice = 0;
												int.TryParse(Class83.smethod_81(text, "cd2accprice", false), out frmLogin.class101_0.globalSettings_0.ThangCheDo2AccPrice);
												if (frmLogin.class101_0.globalSettings_0.ThangCheDo2AccPrice == 0)
												{
													frmLogin.class101_0.globalSettings_0.ThangCheDo2AccPrice = 5;
												}
												frmLogin.class101_0.globalSettings_0.ThangCheDo5AccPrice = 0;
												int.TryParse(Class83.smethod_81(text, "cd5accprice", false), out frmLogin.class101_0.globalSettings_0.ThangCheDo5AccPrice);
												if (frmLogin.class101_0.globalSettings_0.ThangCheDo5AccPrice == 0)
												{
													frmLogin.class101_0.globalSettings_0.ThangCheDo5AccPrice = 10;
												}
												frmLogin.class101_0.globalSettings_0.ThangCheDo50AccPrice = 0;
												int.TryParse(Class83.smethod_81(text, "cd50accprice", false), out frmLogin.class101_0.globalSettings_0.ThangCheDo50AccPrice);
												if (frmLogin.class101_0.globalSettings_0.ThangCheDo50AccPrice == 0)
												{
													frmLogin.class101_0.globalSettings_0.ThangCheDo50AccPrice = 20;
												}
											}
											if (text.Contains("tnchedoallow"))
											{
												int num6 = 0;
												int.TryParse(Class83.smethod_81(text, "tnchedoallow", false), out num6);
												frmLogin.class101_0.globalSettings_0.CheDoCounts = (num6 * 152 ^ 2013);
												if (Class83.smethod_81(text, "tnchedostatus", false) == "TNOK")
												{
													frmLogin.class101_0.globalSettings_0.CheDoStatus = 1;
												}
												else
												{
													frmLogin.class101_0.globalSettings_0.CheDoStatus = 0;
												}
												num6 = 0;
												int.TryParse(Class83.smethod_81(text, "tnchedoremain", false), out num6);
												frmLogin.class101_0.globalSettings_0.CheDoDuration = (num6 * 152 ^ 2013);
												if (num6 > 0)
												{
													frmLogin.class101_0.globalSettings_0.Account.int_14 = 0;
													frmLogin.class101_0.globalSettings_0.HadCDPro = true;
												}
												else
												{
													frmLogin.class101_0.globalSettings_0.HadCDPro = false;
												}
												int.TryParse(Class83.smethod_81(text, "tnq1tcallow", false), out num6);
												int num7 = num6;
												frmLogin.class101_0.globalSettings_0.Q12TCCounts = (num6 * 849 ^ 1786);
												if (Class83.smethod_81(text, "tnq1tcstatus", false) == "TNOK")
												{
													frmLogin.class101_0.globalSettings_0.Q12TCStatus = 1;
												}
												else
												{
													frmLogin.class101_0.globalSettings_0.Q12TCStatus = 0;
												}
												num6 = 0;
												int.TryParse(Class83.smethod_81(text, "tnq1tcremain", false), out num6);
												if (num6 > 0 && num7 <= 0)
												{
													frmLogin.class101_0.globalSettings_0.Q12TCCounts = 88;
												}
												if (num6 > 0)
												{
													frmLogin.class101_0.globalSettings_0.Account.int_2 = 0;
													frmLogin.class101_0.globalSettings_0.HadQ123Pro = true;
												}
												else
												{
													frmLogin.class101_0.globalSettings_0.HadQ123Pro = false;
												}
												try
												{
													frmLogin.class101_0.globalSettings_0.Q12TCDuration = (num6 * 849 ^ 1786);
												}
												catch (Exception)
												{
												}
												int.TryParse(Class83.smethod_81(text, "tnytoallow", false), out num6);
												int num8 = num6;
												frmLogin.class101_0.globalSettings_0.YTOCounts = (num6 * 147 ^ 2716);
												if (Class83.smethod_81(text, "tnytostatus", false) == "TNOK")
												{
													frmLogin.class101_0.globalSettings_0.YTOStatus = 1;
												}
												else
												{
													frmLogin.class101_0.globalSettings_0.YTOStatus = 0;
												}
												num6 = 0;
												int.TryParse(Class83.smethod_81(text, "tnytoremain", false), out num6);
												if (num6 > 0 && num8 <= 0)
												{
													frmLogin.class101_0.globalSettings_0.YTOCounts = 3002;
												}
												if (num6 > 0)
												{
													frmLogin.class101_0.globalSettings_0.Account.int_3 = 0;
													frmLogin.class101_0.globalSettings_0.HadYTOPro = true;
												}
												else
												{
													frmLogin.class101_0.globalSettings_0.HadYTOPro = false;
												}
												try
												{
													frmLogin.class101_0.globalSettings_0.YTODuration = (num6 * 147 ^ 2716);
												}
												catch (Exception)
												{
												}
											}
										}
										if (Class83.smethod_81(text, "gameid", false) == frmLogin.class101_0.globalSettings_0.GameID)
										{
											double num9 = 0.0;
											double.TryParse(Class83.smethod_81(text, "duration", false), out num9);
											if (num9 == -1.0)
											{
												result = -1;
											}
											else if (num9 == -2.0)
											{
												result = 2;
											}
											try
											{
												if (num9 > 0.0)
												{
													frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds = (double)((long)(num9 * 1000.0));
													frmLogin.class101_0.globalSettings_0.Account.int_1 = 0;
													frmLogin.class101_0.globalSettings_0.WasPro = true;
												}
												else
												{
													frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds = 0.0;
													frmLogin.class101_0.globalSettings_0.WasPro = false;
												}
											}
											catch (Exception)
											{
											}
											if (num9 <= 0.0)
											{
												frmLogin.class101_0.globalSettings_0.AppMode2 = Class57.Enum8.const_0;
												frmLogin.class101_0.globalSettings_0.AppMode = Class57.Enum8.const_0;
												if (num9 == -2.0)
												{
													Class83.smethod_62(false);
												}
												else if (num9 == -1.0)
												{
													frmLogin.class101_0.globalSettings_0.Account.bool_0 = true;
												}
											}
											else if (num9 > 0.0)
											{
												frmLogin.class101_0.globalSettings_0.AppMode2 = Class57.Enum8.const_1;
												frmLogin.class101_0.globalSettings_0.AppMode = Class57.Enum8.const_1;
											}
											double.TryParse(Class83.smethod_81(text, "balance", false), out frmLogin.class101_0.globalSettings_0.Account.double_0);
											string s2 = Class83.smethod_81(text, "dailybalance", false);
											double remainGGoldBalance = 0.0;
											double.TryParse(s2, out remainGGoldBalance);
											frmLogin.class101_0.globalSettings_0.Account.RemainGGoldBalance = remainGGoldBalance;
											if (Class83.smethod_81(text, "isgoldlogin", false) == "1")
											{
												frmLogin.class101_0.globalSettings_0.Account.bool_1 = true;
											}
											else
											{
												frmLogin.class101_0.globalSettings_0.Account.bool_1 = false;
											}
											frmLogin.class101_0.globalSettings_0.Account.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
											frmLogin.class101_0.globalSettings_0.Account.long_1 = frmLogin.class101_0.globalSettings_0.Account.long_0;
											try
											{
												frmLogin.long_2 = frmLogin.stopwatch_0.ElapsedMilliseconds + Class83.long_0;
											}
											catch (Exception)
											{
											}
											frmLogin.class101_0.globalSettings_0.Account.string_7 = frmMain.String_464;
											if (bool_1)
											{
												if (frmLogin.class101_0.globalSettings_0.AppMode == Class57.Enum8.const_0)
												{
													new frmLiteVersion().ShowDialog();
												}
												if (!frmLiteVersion.bool_0)
												{
													frmLogin.class101_0.globalSettings_0.IsLoggedIn = true;
													Class83.smethod_82();
												}
												else
												{
													Class83.smethod_62(false);
												}
											}
											result = 1;
										}
									}
									else if (text7 == "MULTILOGIN")
									{
										if (bool_1)
										{
											MessageBox.Show(frmMain.String_463, frmMain.String_462, MessageBoxButtons.OK, MessageBoxIcon.Hand);
										}
										result = 2;
									}
									else if (text7 == "ASK_USER" && !bool_3)
									{
										if (bool_1)
										{
											frmLogin.class101_0.dialogResult_0 = DialogResult.No;
											new frmGGConfirm
											{
												string_0 = frmMain.String_461
											}.ShowDialog();
											if (frmLogin.class101_0.dialogResult_0 == DialogResult.Yes)
											{
												frmLogin.class101_0.globalSettings_0.Account.Username = string_2;
												frmLogin.class101_0.globalSettings_0.Account.string_1 = string_3;
												string text9 = "";
												string text10 = "";
												Class83.smethod_77(out text9, out text10, true, true);
												Class83.smethod_82();
											}
											else
											{
												Class83.smethod_62(false);
											}
										}
										else
										{
											result = 1;
											string text11 = "";
											string text12 = "";
											Class83.smethod_77(out text11, out text12, true, true);
										}
									}
								}
							}
							else
							{
								try
								{
									frmLogin.long_2 = frmLogin.stopwatch_0.ElapsedMilliseconds + Class83.long_0;
								}
								catch (Exception)
								{
								}
							}
						}
						frmLogin.class101_0.globalSettings_0.CheDoRequest = 0;
						frmLogin.class101_0.globalSettings_0.Q12TCRequest = 0;
						frmLogin.class101_0.globalSettings_0.BonHoaRequest = 0;
						frmLogin.class101_0.globalSettings_0.TrongHoaRequest = 0;
						frmLogin.class101_0.globalSettings_0.ThuHoachRequest = 0;
						frmLogin.class101_0.globalSettings_0.Q12TCExtend = 0;
						frmLogin.class101_0.globalSettings_0.YTOExtend = 0;
						frmLogin.class101_0.globalSettings_0.YTORequest = 0;
						frmLogin.class101_0.globalSettings_0.Account.int_4 = 0;
						frmLogin.class101_0.globalSettings_0.Account.object_0 = 0;
						if (frmLogin.class101_0.globalSettings_0.BuyCheDo && frmLogin.class101_0.globalSettings_0.BuyCheDoCount > 0)
						{
							Class83.smethod_66("Kết thúc việc mua slot chế đồ thêm, vui lòng kiểm tra thông tin tài khoản", null, new object[0]);
						}
						frmLogin.class101_0.globalSettings_0.BuyCheDo = false;
						frmLogin.class101_0.globalSettings_0.BuyCheDoCount = 0;
						try
						{
							frmLogin.class101_0.bool_1 = true;
							return result;
						}
						catch (Exception)
						{
							return result;
						}
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage != "VN" && text != frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage)
					{
						if (text.Contains("LOGIN_FAILED"))
						{
							if (bool_1)
							{
								frmLogin_0.lblStatus.Text = frmMain.String_468;
								frmLogin_0.lblStatus.ForeColor = Color.Red;
							}
							frmLogin.class101_0.globalSettings_0.LoginFailedCount++;
							if (frmLogin.class101_0.globalSettings_0.LoginFailedCount >= frmLogin.class101_0.globalSettings_0.MaxLoginError)
							{
								MessageBox.Show(frmMain.String_467, frmMain.String_466, MessageBoxButtons.OK, MessageBoxIcon.Hand);
								Class83.smethod_62(false);
							}
						}
						else if (text.Contains("ACCOUNT_DISABLED;"))
						{
							MessageBox.Show(frmMain.String_478, frmMain.String_477, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							Class83.smethod_62(false);
						}
						else if (text.Contains("MULTILOGIN"))
						{
							if (bool_1)
							{
								MessageBox.Show(frmMain.String_463, frmMain.String_462, MessageBoxButtons.OK, MessageBoxIcon.Hand);
							}
							result = 2;
						}
						else if (text.Contains("\"LoginResult\":\"LOGIN_OK\""))
						{
							string s3 = Class83.smethod_81(text, "duration", false);
							string s4 = Class83.smethod_81(text, "ggoldbalance", false);
							string s5 = Class83.smethod_81(text, "ggoldpromo", false);
							string string_8 = Class83.smethod_81(text, "uniquesessionid", false);
							string s6 = Class83.smethod_81(text, "tnq1tc", false);
							string s7 = Class83.smethod_81(text, "tnq1tcrem", false);
							string s8 = Class83.smethod_81(text, "tnyto", false);
							string s9 = Class83.smethod_81(text, "tnytorem", false);
							string string_9 = Class83.smethod_81(text, "muablock", false);
							string s10 = Class83.smethod_81(text, "mychedocount", false);
							string s11 = Class83.smethod_81(text, "mytradercount", false);
							string s12 = Class83.smethod_81(text, "blockedversion", false);
							string s13 = Class83.smethod_81(text, "expdatetime", false);
							string s14 = Class83.smethod_81(text, "traderprice", false);
							string s15 = Class83.smethod_81(text, "traderfree", false);
							frmLogin.class101_0.globalSettings_0.Account.string_8 = string_9;
							string a2 = Class83.smethod_81(text, "autoupdate", false);
							string string_10 = Class83.smethod_81(text, "autofilename", false);
							string string_11 = Class83.smethod_81(text, "autoversion", false);
							string s16 = Class83.smethod_81(text, "1hquestprice", false);
							string s17 = Class83.smethod_81(text, "3hquestprice", false);
							string s18 = Class83.smethod_81(text, "craftingprice", false);
							int int_ = 0;
							int.TryParse(s12, out int_);
							frmLogin.int_2 = int_;
							int num10 = 0;
							int.TryParse(s16, out num10);
							frmLogin.class101_0.globalSettings_0.Account.Price1HQuest = num10;
							int.TryParse(s17, out num10);
							frmLogin.class101_0.globalSettings_0.Account.Price3HQuest = num10;
							int.TryParse(s18, out num10);
							frmLogin.class101_0.globalSettings_0.Account.CraftingPrice = num10;
							int.TryParse(s14, out num10);
							frmLogin.class101_0.globalSettings_0.Account.int_13 = num10;
							int.TryParse(s15, out num10);
							frmLogin.class101_0.globalSettings_0.DefaultFreeTN = num10;
							try
							{
								frmLogin.class101_0.globalSettings_0.BangGia.Clear();
								string text13 = Class83.smethod_81(text, "price_1", false);
								string text14 = Class83.smethod_81(text, "price_6", false);
								string text15 = Class83.smethod_81(text, "price_30", false);
								string text16 = Class83.smethod_81(text, "price_90", false);
								string text17 = Class83.smethod_81(text, "price_180", false);
								string text18 = Class83.smethod_81(text, "price_360", false);
								string text19 = Class83.smethod_81(text, "price_9999", false);
								if (!string.IsNullOrEmpty(text13))
								{
									frmLogin.class101_0.globalSettings_0.BangGia.Add("price_1", int.Parse(text13));
								}
								if (!string.IsNullOrEmpty(text14))
								{
									frmLogin.class101_0.globalSettings_0.BangGia.Add("price_6", int.Parse(text14));
								}
								if (!string.IsNullOrEmpty(text15))
								{
									frmLogin.class101_0.globalSettings_0.BangGia.Add("price_30", int.Parse(text15));
								}
								if (!string.IsNullOrEmpty(text16))
								{
									frmLogin.class101_0.globalSettings_0.BangGia.Add("price_90", int.Parse(text16));
								}
								if (!string.IsNullOrEmpty(text17))
								{
									frmLogin.class101_0.globalSettings_0.BangGia.Add("price_180", int.Parse(text17));
								}
								if (!string.IsNullOrEmpty(text18))
								{
									frmLogin.class101_0.globalSettings_0.BangGia.Add("price_360", int.Parse(text18));
								}
								if (!string.IsNullOrEmpty(text19))
								{
									frmLogin.class101_0.globalSettings_0.BangGia.Add("price_9999", int.Parse(text19));
								}
							}
							catch (Exception)
							{
							}
							frmLogin.class101_0.globalSettings_0.Account.string_9 = string_8;
							if (frmLogin.class101_0.globalSettings_0.Account.string_9 == string.Empty)
							{
								frmLogin.class101_0.globalSettings_0.Account.string_9 = "-1";
							}
							frmLogin.class101_0.globalSettings_0.LicenseCheckTimeStamp = frmLogin.stopwatch_0.ElapsedMilliseconds;
							bool flag3 = false;
							frmLogin.class101_0.globalSettings_0.Account.dateTime_0 = DateTime.Parse(s13);
							if (bool_1)
							{
								frmLogin.class101_0.globalSettings_0.Account.Username = string_2;
								frmLogin.class101_0.globalSettings_0.Account.string_1 = string_3;
								frmLogin.string_3 = string_11;
								frmLogin.string_4 = string_10;
								if (a2 == "AUTO_OUTDATEFORCE")
								{
									flag3 = true;
									frmLogin.bool_1 = true;
									MessageBox.Show(frmMain.String_465, "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
									frmLogin.smethod_10(false);
								}
								else if (a2 == "AUTO_OUTDATE")
								{
									new frmUpdateNewVersion().ShowDialog();
									if (frmUpdateNewVersion.bool_0)
									{
										frmUpdateNewVersion.bool_0 = false;
										flag3 = true;
										frmLogin.bool_1 = true;
										frmLogin.smethod_10(false);
									}
								}
							}
							if (!flag3)
							{
								int num11 = 0;
								int.TryParse(s10, out num11);
								frmLogin.class101_0.globalSettings_0.CheDoCounts = (num11 * 152 ^ 2013);
								if (num11 > 0)
								{
									for (int k = 0; k < num11; k++)
									{
										string string_12 = "chedoentry-" + k.ToString();
										string string_13 = Class83.smethod_81(text, string_12, false);
										string s19 = Class83.smethod_81(string_13, "chedorem", false);
										Class139 class2 = new Class139();
										int.TryParse(s19, out class2.int_0);
										class2.string_0 = "Chế đồ";
										int.TryParse(Class83.smethod_81(string_13, "chedopri", false), out class2.int_1);
										if (class2.int_0 < frmLogin.class101_0.globalSettings_0.Account.int_9 || frmLogin.class101_0.globalSettings_0.Account.int_9 == 0)
										{
											frmLogin.class101_0.globalSettings_0.Account.int_9 = class2.int_0;
										}
										if (class2.int_0 > frmLogin.class101_0.globalSettings_0.Account.int_11)
										{
											frmLogin.class101_0.globalSettings_0.Account.int_11 = class2.int_0;
										}
										try
										{
											if (k >= frmLogin.class101_0.globalSettings_0.Account.class210_0.Count)
											{
												class2.int_0 = (class2.int_0 * 152 ^ 2013);
												frmLogin.class101_0.globalSettings_0.Account.class210_0.method_1(class2);
											}
											else
											{
												frmLogin.class101_0.globalSettings_0.Account.class210_0[k].int_0 = (class2.int_0 * 152 ^ 2013);
												frmLogin.class101_0.globalSettings_0.Account.class210_0[k].int_1 = class2.int_1;
											}
										}
										catch (Exception)
										{
										}
									}
								}
								num11 = 0;
								int.TryParse(s11, out num11);
								double num12 = 0.0;
								double.TryParse(s3, out num12);
								if (num12 <= 0.0)
								{
									num11 = 0;
								}
								frmLogin.class101_0.globalSettings_0.TraderCounts = (num11 * 153 ^ 2714);
								if (num11 > 0)
								{
									for (int l = 0; l < num11; l++)
									{
										string string_14 = "traderentry-" + l.ToString();
										string string_15 = Class83.smethod_81(text, string_14, false);
										string s20 = Class83.smethod_81(string_15, "traderrem", false);
										Class139 class3 = new Class139();
										int.TryParse(s20, out class3.int_0);
										class3.string_0 = "Thương nhân";
										int.TryParse(Class83.smethod_81(string_15, "traderpri", false), out class3.int_1);
										if (class3.int_0 < frmLogin.class101_0.globalSettings_0.Account.int_10 || frmLogin.class101_0.globalSettings_0.Account.int_10 == 0)
										{
											frmLogin.class101_0.globalSettings_0.Account.int_10 = class3.int_0;
										}
										if (class3.int_0 > frmLogin.class101_0.globalSettings_0.Account.int_12)
										{
											frmLogin.class101_0.globalSettings_0.Account.int_12 = class3.int_0;
										}
										try
										{
											if (l >= frmLogin.class101_0.globalSettings_0.Account.class210_1.Count)
											{
												class3.int_0 = (class3.int_0 * 153 ^ 2714);
												frmLogin.class101_0.globalSettings_0.Account.class210_1.method_1(class3);
											}
											else
											{
												frmLogin.class101_0.globalSettings_0.Account.class210_1[l].int_0 = (class3.int_0 * 153 ^ 2714);
												frmLogin.class101_0.globalSettings_0.Account.class210_1[l].int_1 = class3.int_1;
											}
										}
										catch (Exception)
										{
										}
									}
								}
								int.TryParse(s6, out num11);
								if (num11 > 0)
								{
									num11 = 3;
								}
								frmLogin.class101_0.globalSettings_0.Q12TCCounts = (num11 * 849 ^ 1786);
								int num13 = 0;
								int.TryParse(s7, out num13);
								if (num13 > 0)
								{
									frmLogin.class101_0.globalSettings_0.Q12TCStatus = 1;
								}
								else
								{
									frmLogin.class101_0.globalSettings_0.Q12TCStatus = 0;
								}
								num11 = num13;
								if (num11 > 0)
								{
									frmLogin.class101_0.globalSettings_0.Account.int_2 = 0;
									frmLogin.class101_0.globalSettings_0.HadQ123Pro = true;
								}
								else
								{
									frmLogin.class101_0.globalSettings_0.HadQ123Pro = false;
								}
								try
								{
									frmLogin.class101_0.globalSettings_0.Q12TCDuration = (num11 * 849 ^ 1786);
								}
								catch (Exception)
								{
								}
								int.TryParse(s8, out num11);
								if (num11 > 0)
								{
									num11 = 3;
								}
								frmLogin.class101_0.globalSettings_0.YTOCounts = (num11 * 147 ^ 2716);
								num13 = 0;
								int.TryParse(s9, out num13);
								if (num13 > 0)
								{
									frmLogin.class101_0.globalSettings_0.YTOStatus = 1;
								}
								else
								{
									frmLogin.class101_0.globalSettings_0.YTOStatus = 0;
								}
								num11 = num13;
								if (num11 > 0)
								{
									frmLogin.class101_0.globalSettings_0.Account.int_3 = 0;
									frmLogin.class101_0.globalSettings_0.HadYTOPro = true;
								}
								else
								{
									frmLogin.class101_0.globalSettings_0.HadYTOPro = false;
								}
								try
								{
									frmLogin.class101_0.globalSettings_0.YTODuration = (num11 * 147 ^ 2716);
								}
								catch (Exception)
								{
								}
							}
							double num14 = 0.0;
							double.TryParse(s3, out num14);
							if (num14 == -1.0)
							{
								result = -1;
							}
							else if (num14 == -2.0)
							{
								result = 2;
							}
							try
							{
								if (num14 > 0.0)
								{
									frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds = (double)((long)(num14 * 1000.0));
									frmLogin.class101_0.globalSettings_0.Account.int_1 = 0;
									frmLogin.class101_0.globalSettings_0.WasPro = true;
								}
								else
								{
									frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds = 0.0;
									frmLogin.class101_0.globalSettings_0.WasPro = false;
								}
							}
							catch (Exception)
							{
							}
							if (num14 <= 0.0)
							{
								frmLogin.class101_0.globalSettings_0.AppMode2 = Class57.Enum8.const_0;
								frmLogin.class101_0.globalSettings_0.AppMode = Class57.Enum8.const_0;
								if (num14 == -2.0)
								{
									Class83.smethod_62(false);
								}
								else if (num14 == -1.0)
								{
									frmLogin.class101_0.globalSettings_0.Account.bool_0 = true;
								}
							}
							else if (num14 > 0.0)
							{
								frmLogin.class101_0.globalSettings_0.AppMode2 = Class57.Enum8.const_1;
								frmLogin.class101_0.globalSettings_0.AppMode = Class57.Enum8.const_1;
							}
							double num15 = 0.0;
							double.TryParse(s5, out num15);
							frmLogin.class101_0.globalSettings_0.Account.RemainGGoldPromo = num15;
							double.TryParse(s4, out num15);
							frmLogin.class101_0.globalSettings_0.Account.RemainGGoldBalance = num15;
							if (frmLogin.class101_0.globalSettings_0.Account.RemainGGoldPromo == 0.0 && frmLogin.class101_0.globalSettings_0.Account.RemainGGoldBalance == 0.0)
							{
								frmLogin.bool_14 = true;
							}
							else
							{
								frmLogin.bool_14 = false;
							}
							frmLogin.class101_0.globalSettings_0.Account.long_0 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							frmLogin.class101_0.globalSettings_0.Account.long_1 = frmLogin.class101_0.globalSettings_0.Account.long_0;
							try
							{
								frmLogin.long_2 = frmLogin.stopwatch_0.ElapsedMilliseconds + Class83.long_0;
							}
							catch (Exception)
							{
							}
							frmLogin.class101_0.globalSettings_0.Account.string_7 = frmMain.String_464;
							if (bool_1)
							{
								if (frmLogin.class101_0.globalSettings_0.AppMode == Class57.Enum8.const_0)
								{
									frmLiteVersion frmLiteVersion = new frmLiteVersion();
									if (frmLogin.string_0 != "VN")
									{
										if (frmLogin.class101_0.globalSettings_0.Account.RemainGGoldBalance <= 0.0 && frmLogin.class101_0.globalSettings_0.Account.RemainGGoldPromo <= 0.0)
										{
											frmLiteVersion.Height = 283;
										}
										else
										{
											frmLiteVersion.Height = 609;
											frmLiteVersion.method_0();
										}
									}
									frmLiteVersion.ShowDialog();
								}
								if (!frmLiteVersion.bool_0)
								{
									Class83.smethod_82();
								}
								else
								{
									Class83.smethod_62(false);
								}
							}
							result = 1;
							frmLogin.class101_0.globalSettings_0.CheDoRequest = 0;
							if (frmLogin.string_0 == "EN" && frmLogin.class101_0.globalSettings_0.IsPro1)
							{
								if (frmLogin.class101_0.globalSettings_0.TraderRequest < frmLogin.class101_0.globalSettings_0.DefaultFreeTN)
								{
									frmLogin.class101_0.globalSettings_0.TraderRequest = frmLogin.class101_0.globalSettings_0.DefaultFreeTN;
								}
								else
								{
									frmLogin.class101_0.globalSettings_0.TraderRequest = 0;
								}
							}
							else
							{
								frmLogin.class101_0.globalSettings_0.TraderRequest = 0;
							}
							frmLogin.class101_0.globalSettings_0.Q12TCRequest = 0;
							frmLogin.class101_0.globalSettings_0.BonHoaRequest = 0;
							frmLogin.class101_0.globalSettings_0.TrongHoaRequest = 0;
							frmLogin.class101_0.globalSettings_0.ThuHoachRequest = 0;
							frmLogin.class101_0.globalSettings_0.Q12TCExtend = 0;
							frmLogin.class101_0.globalSettings_0.YTOExtend = 0;
							frmLogin.class101_0.globalSettings_0.YTORequest = 0;
							frmLogin.class101_0.globalSettings_0.Account.int_4 = 0;
							frmLogin.class101_0.globalSettings_0.Account.object_0 = 0;
							try
							{
								frmLogin.class101_0.bool_1 = true;
							}
							catch (Exception)
							{
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00076968 File Offset: 0x00074B68
		internal static string smethod_79(string string_2)
		{
			try
			{
				byte[] bytes = Convert.FromBase64String(string_2);
				string_2 = Encoding.UTF8.GetString(bytes);
			}
			catch (Exception)
			{
				string_2 = "";
			}
			return string_2;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000769AC File Offset: 0x00074BAC
		internal static Dictionary<string, string> smethod_80(string string_2)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if (string_2.Contains("\":"))
			{
				StringBuilder stringBuilder = new StringBuilder(string_2);
				int num = 0;
				for (int i = 0; i < stringBuilder.Length; i++)
				{
					if (stringBuilder[i] == ':' && stringBuilder[i - 1] == '"')
					{
						int num2 = i - 1;
						do
						{
							num2--;
							char c = stringBuilder[4];
						}
						while (stringBuilder[num2] != '"' && num2 != 0 && num2 > num);
						string text = string_2.Substring(num2 + 1, i - num2 - 2);
						if (text != "")
						{
							try
							{
								string value = Class83.smethod_81(string_2, text, false);
								dictionary.Add(text, value);
							}
							catch (Exception)
							{
								break;
							}
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00076A88 File Offset: 0x00074C88
		internal static string smethod_81(string string_2, string string_3, bool bool_1 = false)
		{
			int num = string_2.IndexOf(string_3);
			int length = string_2.Length;
			if (num != -1 && num < length)
			{
				string text = "\"" + string_3 + "\":";
				string text2 = "";
				bool flag = false;
				if (num + string_3.Length + 2 < length && string_2[num + string_3.Length + 2] == '{')
				{
					flag = true;
				}
				int i = num + 1;
				while (i < length)
				{
					if (string_2[i] != ',' || flag)
					{
						if (string_2[i] != '}')
						{
							if (i == string_2.Length - 1)
							{
								int num2 = string_2.LastIndexOf(text);
								if (num2 > 0 && num2 < string_2.Length)
								{
									text2 = string_2.Substring(num2 + text.Length, string_2.Length - num2 - text.Length);
								}
							}
							i++;
							continue;
						}
						text2 = Class83.smethod_83(string_2, text, "}", 1, 1);
					}
					else
					{
						text2 = Class83.smethod_83(string_2, text, ",", 1, 1);
					}
					IL_F1:
					text2 = text2.Trim(new char[]
					{
						'"'
					});
					text2 = text2.Trim();
					string text3 = text2;
					if (bool_1)
					{
						try
						{
							text2 = HttpUtility.UrlDecode(text2);
							byte[] bytes = Convert.FromBase64String(text2);
							text2 = Encoding.UTF8.GetString(bytes);
						}
						catch (Exception)
						{
							if (!frmLogin.class101_0.globalSettings_0.IsLoggedIn)
							{
								MessageBox.Show("Lỗi giải mã dữ liệu #3. Tắt auto thử lại. Value: " + text3);
							}
							else
							{
								Class83.smethod_66("Lỗi giải mã dữ liệu #3, tắt auto thử lại. Value: " + text3, null, new object[0]);
							}
							text2 = text3;
						}
					}
					return text2;
				}
				goto IL_F1;
			}
			return "";
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00076C20 File Offset: 0x00074E20
		internal static void smethod_82()
		{
			long num = frmLogin.stopwatch_0.ElapsedMilliseconds + 30000L;
			while (!frmLogin.bool_10)
			{
				Thread.Sleep(200);
				if (frmLogin.stopwatch_0.ElapsedMilliseconds >= num)
				{
					MessageBox.Show(frmMain.String_460);
					Class83.smethod_62(false);
					return;
				}
			}
			new frmMain().Show();
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00076C7C File Offset: 0x00074E7C
		internal static string smethod_83(string string_2, string string_3, string string_4, int int_0 = 1, int int_1 = 1)
		{
			if (!string.IsNullOrEmpty(string_2))
			{
				int length = string_2.Length;
				int num = -1;
				int num2 = -1;
				for (int i = 1; i <= int_0; i++)
				{
					num = string_2.IndexOf(string_3);
					if (num != -1)
					{
						num += string_3.Length;
						string_2 = string_2.Substring(num, string_2.Length - num);
					}
				}
				if (num != -1 && num < length)
				{
					for (int j = 1; j <= int_1; j++)
					{
						num2 = string_2.IndexOf(string_4);
					}
					if (num2 != -1 && num2 < string_2.Length)
					{
						string_2 = string_2.Substring(0, num2);
						return string_2;
					}
				}
			}
			return "";
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00004417 File Offset: 0x00002617
		internal static void smethod_84()
		{
			Process.Start(frmLogin.class101_0.globalSettings_0.UserGuideURL);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000442E File Offset: 0x0000262E
		internal static void smethod_85()
		{
			Process.Start(frmLogin.class101_0.globalSettings_0.WhatsNewURL);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00004445 File Offset: 0x00002645
		internal static void smethod_86()
		{
			Process.Start(frmLogin.class101_0.globalSettings_0.RegisterAccountURL);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000445C File Offset: 0x0000265C
		internal static void smethod_87()
		{
			Process.Start(frmLogin.class101_0.globalSettings_0.ForumURL);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00004473 File Offset: 0x00002673
		internal static void smethod_88()
		{
			Process.Start(frmLogin.class101_0.globalSettings_0.TermsURL);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000448A File Offset: 0x0000268A
		internal static void smethod_89()
		{
			Process.Start(frmLogin.class101_0.globalSettings_0.RegistrationGuideURL);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000044A1 File Offset: 0x000026A1
		internal static void smethod_90()
		{
			Process.Start(frmLogin.class101_0.globalSettings_0.PayPalURL);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000044B8 File Offset: 0x000026B8
		internal static void smethod_91()
		{
			Process.Start(frmLogin.class101_0.globalSettings_0.FacebookURL);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000044CF File Offset: 0x000026CF
		internal static void smethod_92()
		{
			Process.Start(frmLogin.class132_0.string_0 + frmLogin.class101_0.globalSettings_0.ForgotPassURL);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000044F5 File Offset: 0x000026F5
		internal static void smethod_93()
		{
			Process.Start(frmLogin.class101_0.globalSettings_0.MainURL);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000450C File Offset: 0x0000270C
		internal static void smethod_94(string string_2, Exception exception_0)
		{
			MessageBox.Show(string.Concat(new string[]
			{
				string_2,
				"\n",
				exception_0.Message,
				"\n",
				exception_0.StackTrace
			}));
			Class83.smethod_62(false);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000454B File Offset: 0x0000274B
		internal static void smethod_95()
		{
			new frmAbout().Show();
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00004557 File Offset: 0x00002757
		internal byte[] method_0(Class157 class157_0)
		{
			return new byte[1026];
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00076D14 File Offset: 0x00074F14
		internal static void smethod_96(string string_2, params object[] object_2)
		{
			StreamWriter streamWriter = null;
			if (File.Exists(frmLogin.class101_0.globalSettings_0.LogFilePath))
			{
				FileInfo fileInfo = new FileInfo(frmLogin.class101_0.globalSettings_0.LogFilePath);
				if (fileInfo != null && fileInfo.Length >= (long)(frmLogin.class101_0.globalSettings_0.LogFileMaxSize * 1000000))
				{
					string destFileName = AppDomain.CurrentDomain.BaseDirectory + string.Format("log\\{0:D2}{1:D2}{2:D2}_{3:D2}{4:D2}{5:D4}.log", new object[]
					{
						DateTime.Now.Hour,
						DateTime.Now.Minute,
						DateTime.Now.Second,
						DateTime.Now.Month,
						DateTime.Now.Day,
						DateTime.Now.Year
					});
					try
					{
						File.Move(frmLogin.class101_0.globalSettings_0.LogFilePath, destFileName);
					}
					finally
					{
					}
				}
			}
			try
			{
				string_2 = string.Format(string_2, object_2);
				string value = string.Format("{0}: {1}", DateTime.Now.ToString(), string_2);
				object obj = frmMain.frmMain_0.object_0;
				lock (obj)
				{
					streamWriter = new StreamWriter(frmLogin.class101_0.globalSettings_0.LogFilePath, true);
					if (streamWriter != null)
					{
						streamWriter.WriteLine(value);
					}
				}
			}
			catch (Exception)
			{
				Class83.smethod_100(frmMain.String_458, new object[0]);
			}
			finally
			{
				if (streamWriter != null)
				{
					streamWriter.Close();
				}
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00076EE8 File Offset: 0x000750E8
		internal static Class39 smethod_97(Class41 class41_0)
		{
			if (frmLogin.class101_0.globalSettings_0.Account.list_1.Count > 0)
			{
				for (int i = frmLogin.class101_0.globalSettings_0.Account.list_1.Count - 1; i >= 0; i--)
				{
					bool flag = false;
					if ((class41_0.GiaHanTime == "" || class41_0.GiaHanTime == frmMain.String_782) && frmLogin.class101_0.globalSettings_0.Account.list_1[i].int_0 == class41_0.int_1 && frmLogin.class101_0.globalSettings_0.Account.list_1[i].string_1 == class41_0.string_6)
					{
						flag = true;
					}
					if (!flag && class41_0.GiaHanTime != "" && class41_0.GiaHanTime != frmMain.String_782 && class41_0.GiaHanTime == frmLogin.class101_0.globalSettings_0.Account.list_1[i].string_4)
					{
						flag = true;
					}
					if (frmLogin.class101_0.globalSettings_0.Account.list_1[i].string_0 == class41_0.TNKey && flag && frmLogin.class101_0.globalSettings_0.Account.list_1[i].int_1 == class41_0.int_2 && frmLogin.class101_0.globalSettings_0.Account.list_1[i].string_2 == class41_0.string_7)
					{
						return frmLogin.class101_0.globalSettings_0.Account.list_1[i];
					}
				}
			}
			return null;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000770B0 File Offset: 0x000752B0
		internal static string smethod_98(int int_0 = 24)
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			char[] array = new char[int_0];
			object obj = Class83.object_1;
			lock (obj)
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = text[Class83.random_0.Next(text.Length)];
				}
			}
			return new string(array);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0007711C File Offset: 0x0007531C
		internal static string smethod_99(int int_0, bool bool_1 = false)
		{
			string text = int_0.ToString("X4");
			if (!bool_1)
			{
				return text;
			}
			char[] array = text.ToCharArray();
			text = string.Empty;
			for (int i = array.Length - 1; i >= 0; i -= 2)
			{
				if (array.Length > 1 && array.Length % 2 == 0 && i != 0)
				{
					text += array[i - 1].ToString();
				}
				text += array[i].ToString();
			}
			return text;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00004563 File Offset: 0x00002763
		internal static void smethod_100(string string_2, params object[] object_2)
		{
			string_2 = string.Format(string_2, object_2);
			MessageBox.Show(string_2, frmMain.String_457, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00077194 File Offset: 0x00075394
		internal static void smethod_101(ref IntPtr intptr_0, ref IntPtr intptr_1, string string_2, UIntPtr uintptr_0)
		{
			intptr_0 = Class159.CreateFileMapping((IntPtr)(-1), (IntPtr)0, Class159.Enum19.flag_4, 0U, (uint)uintptr_0, string_2);
			if (intptr_0 == IntPtr.Zero)
			{
				MessageBox.Show("Cannot create new pipe");
			}
			intptr_1 = Class159.MapViewOfFile(intptr_0, 983071U, 0U, 0U, uintptr_0);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000771E8 File Offset: 0x000753E8
		internal static DateTime smethod_102(long long_2)
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0);
			return dateTime.Add(new TimeSpan(0, 0, (int)long_2));
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00077218 File Offset: 0x00075418
		internal static void smethod_103(Class58 class58_0, bool bool_1 = true, bool bool_2 = true)
		{
			try
			{
				for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
				{
					Class58 @class = frmLogin.class101_0.class210_0[i];
					if (@class != null && @class.class114_0.int_11 != class58_0.class114_0.int_11 && @class.autoSettings_0.numGroupID == class58_0.autoSettings_0.numGroupID)
					{
						@class.IsAIEnabled = true;
						if (@class.autoSettings_0.AIMode != Class57.AIModes.DANHTUDO)
						{
							@class.autoSettings_0.AIMode = Class57.AIModes.DANHTUDO;
						}
						if (bool_2)
						{
							@class.autoSettings_0.cboxTheoSau = true;
						}
						else
						{
							@class.autoSettings_0.cboxTheoSau = false;
						}
						if (@class.class114_0.MapID != class58_0.class114_0.MapID)
						{
							@class.method_219();
							if (@class.class59_0.int_2 == 3)
							{
								goto IL_242;
							}
							if (@class.class59_0.int_2 == 4)
							{
								goto IL_242;
							}
							@class.class114_0.int_33 = class58_0.class114_0.MapID;
							@class.class114_0.int_34 = (int)class58_0.class114_0.float_0;
							@class.class114_0.int_35 = (int)class58_0.class114_0.float_5;
							@class.class114_0.bool_12 = true;
							@class.class114_0.Status = Class57.Enum13.const_8;
							IL_292:
							@class.class114_0.enum13_3 = Class57.Enum13.const_19;
							goto IL_2A2;
							IL_242:
							@class.class114_0.int_34 = (int)class58_0.class114_0.float_0;
							@class.class114_0.int_35 = (int)class58_0.class114_0.float_5;
							@class.class114_0.int_33 = class58_0.class114_0.MapID;
							@class.class114_0.bool_154 = true;
							goto IL_292;
						}
						double num = Class83.smethod_116((double)@class.class114_0.float_0, (double)@class.class114_0.float_5, (double)class58_0.class114_0.float_0, (double)class58_0.class114_0.float_5);
						if (num > 6.0)
						{
							@class.method_219();
							if (num > 35.0)
							{
								@class.method_369();
							}
							@class.class114_0.Status = Class57.Enum13.const_8;
							@class.class114_0.float_11 = class58_0.class114_0.float_0;
							@class.class114_0.float_14 = class58_0.class114_0.float_5;
							@class.class114_0.int_29 = class58_0.class114_0.MapID;
							@class.class114_0.bool_12 = false;
							@class.class114_0.enum13_3 = Class57.Enum13.const_19;
						}
						else
						{
							if (@class.class114_0.Status != Class57.Enum13.const_9)
							{
								@class.class114_0.Status = Class57.Enum13.const_0;
							}
							@class.class114_0.enum13_3 = Class57.Enum13.const_0;
						}
					}
					IL_2A2:;
				}
			}
			catch (Exception)
			{
				Class83.smethod_66(frmMain.String_456, null, new object[0]);
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00077504 File Offset: 0x00075704
		internal static void smethod_104(Class58 class58_0, bool bool_1 = false, bool bool_2 = true)
		{
			if (class58_0.class126_0.int_1 > 0 && class58_0.class126_0.list_0[0].int_0 == class58_0.class114_0.int_11)
			{
				try
				{
					int num = 0;
					for (int i = 1; i <= class58_0.class126_0.int_1; i++)
					{
						Class127 @class = class58_0.class126_0.list_0[i];
						if (@class.int_0 != class58_0.class114_0.int_11)
						{
							Class58 class2 = null;
							bool flag = false;
							int j = frmLogin.class101_0.class210_0.Count - 1;
							while (j >= 0)
							{
								Class58 class3 = frmLogin.class101_0.class210_0[j];
								if (class3.class114_0.int_11 == @class.int_0)
								{
									class2 = class3;
									flag = true;
									IL_C2:
									if (!flag)
									{
										num++;
									}
									if (class2 == null)
									{
										goto IL_2E4;
									}
									class2.IsAIEnabled = true;
									if (class2.autoSettings_0.AIMode != Class57.AIModes.DANHTUDO)
									{
										class2.autoSettings_0.AIMode = Class57.AIModes.DANHTUDO;
									}
									if (bool_2)
									{
										class2.autoSettings_0.cboxTheoSau = true;
										class2.autoSettings_0.PTTheoSauMode = 0;
									}
									else
									{
										class2.autoSettings_0.cboxTheoSau = false;
									}
									if (class2.class114_0.MapID == class58_0.class114_0.MapID)
									{
										double num2 = Class83.smethod_116((double)class2.class114_0.float_0, (double)class2.class114_0.float_5, (double)class58_0.class114_0.float_0, (double)class58_0.class114_0.float_5);
										if (num2 <= 6.0)
										{
											if (class2.class114_0.Status != Class57.Enum13.const_9)
											{
												class2.class114_0.Status = Class57.Enum13.const_0;
											}
											class2.class114_0.enum13_3 = Class57.Enum13.const_0;
											goto IL_2E4;
										}
										if (num2 > 35.0)
										{
											class2.method_369();
										}
										class2.class114_0.Status = Class57.Enum13.const_8;
										class2.class114_0.float_11 = class58_0.class114_0.float_0;
										class2.class114_0.float_14 = class58_0.class114_0.float_5;
										class2.class114_0.int_29 = class58_0.class114_0.MapID;
										class2.class114_0.bool_12 = false;
										class2.class114_0.enum13_3 = Class57.Enum13.const_19;
										if (bool_1)
										{
											class2.class114_0.enum13_3 = Class57.Enum13.const_20;
											goto IL_2E4;
										}
										goto IL_2E4;
									}
									else
									{
										class2.class114_0.int_33 = class58_0.class114_0.MapID;
										class2.class114_0.int_34 = (int)class58_0.class114_0.float_0;
										class2.class114_0.int_35 = (int)class58_0.class114_0.float_5;
										class2.class114_0.bool_12 = true;
										class2.class114_0.Status = Class57.Enum13.const_8;
										class2.class114_0.enum13_3 = Class57.Enum13.const_19;
										if (bool_1)
										{
											class2.class114_0.enum13_3 = Class57.Enum13.const_20;
										}
										if (class2.class59_0.int_2 == 3)
										{
											class2.class114_0.bool_154 = true;
											goto IL_2E4;
										}
										goto IL_2E4;
									}
								}
								else
								{
									j--;
								}
							}
							goto IL_C2;
						}
						IL_2E4:;
					}
					if (class58_0.class126_0 != null)
					{
						class58_0.class126_0.int_15 = num;
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00077840 File Offset: 0x00075A40
		internal static void smethod_105(Class58 class58_0, int int_0, int int_1, int int_2, bool bool_1 = true)
		{
			int num = int_0;
			int num2 = int_1;
			if (class58_0.class126_0.int_1 > 0 && class58_0.class126_0.list_0[0].int_0 == class58_0.class114_0.int_11)
			{
				try
				{
					int num3 = 0;
					int num4 = 0;
					int num5 = 0;
					for (int i = 1; i <= class58_0.class126_0.int_1; i++)
					{
						Class127 @class = class58_0.class126_0.list_0[i];
						if (@class.int_0 != class58_0.class114_0.int_11)
						{
							Class58 class2 = null;
							bool flag = false;
							int j = frmLogin.class101_0.class210_0.Count - 1;
							while (j >= 0)
							{
								Class58 class3 = frmLogin.class101_0.class210_0[j];
								if (class3.class114_0.int_11 == @class.int_0)
								{
									class2 = class3;
									IL_CB:
									if (!flag)
									{
										num3++;
									}
									if (class2 == null)
									{
										goto IL_3BE;
									}
									class2.IsAIEnabled = true;
									if (class2.autoSettings_0.AIMode != Class57.AIModes.DANHTUDO)
									{
										class2.autoSettings_0.AIMode = Class57.AIModes.DANHTUDO;
									}
									if (class2.class114_0.MapID == int_2)
									{
										if (num == 43 && num2 == 91)
										{
											if (class2.autoSettings_0.cboQ1Cau.Contains("ầu phả") || class2.autoSettings_0.cboQ1Cau.Contains("ght bri") || class2.autoSettings_0.cboQ1Cau.Contains("右桥"))
											{
												if (num5 <= 2)
												{
													int_0 = 80;
													int_1 = 88;
												}
												else
												{
													int_0 = num;
													int_1 = num2;
												}
												num5++;
											}
											if (class2.autoSettings_0.cboQ1Cau.Contains(frmMain.String_694))
											{
												int num6 = 3;
												if (class58_0.class126_0.int_1 == 3)
												{
													num6 = 2;
												}
												if (num4 >= num6)
												{
													int_0 = 80;
													int_1 = 88;
												}
												else
												{
													if (class2.autoSettings_0.cboxDanhTheoKey)
													{
														class2.autoSettings_0.cboxDanhTheoKey = false;
													}
													int_0 = num;
													int_1 = num2;
												}
												num4++;
											}
										}
										double num7 = Class83.smethod_116((double)class2.class114_0.float_0, (double)class2.class114_0.float_5, (double)int_0, (double)int_1);
										if (num7 > 3.0)
										{
											if (num == 43 && num2 == 91 && class2.class114_0.ActionStatus == 7)
											{
												class2.method_194(-1, 34, 0, 0, false, false);
												int int_3 = class2.method_209();
												class2.method_194(-1, int_3, 0, 0, false, false);
												Thread.Sleep(100);
												class2.method_104(-1);
											}
											if (!bool_1)
											{
												class2.autoSettings_0.cboxTheoSau = false;
											}
											else
											{
												class2.autoSettings_0.cboxTheoSau = true;
											}
											if (num7 > 40.0)
											{
												class2.method_369();
											}
											class2.method_162((float)int_0, (float)int_1);
											class2.class114_0.Status = Class57.Enum13.const_8;
											class2.class114_0.float_11 = (float)int_0;
											class2.class114_0.float_14 = (float)int_1;
											class2.class114_0.int_29 = int_2;
											class2.class114_0.bool_12 = false;
											class2.class114_0.enum13_3 = Class57.Enum13.const_0;
											goto IL_3BE;
										}
										if (class2.class114_0.MapID == 1)
										{
											class2.method_162((float)int_0, (float)int_1);
										}
										if (class58_0.class114_0.bool_160)
										{
											class2.method_162((float)int_0, (float)int_1);
										}
										class2.class114_0.Status = Class57.Enum13.const_0;
										goto IL_3BE;
									}
									else
									{
										class2.class114_0.int_33 = int_2;
										class2.class114_0.int_34 = int_0;
										class2.class114_0.int_35 = int_1;
										class2.class114_0.bool_12 = true;
										class2.class114_0.Status = Class57.Enum13.const_8;
										if (class2.class59_0.int_2 == 3 || class2.class59_0.int_2 == 4)
										{
											class2.class114_0.bool_154 = true;
											goto IL_3BE;
										}
										goto IL_3BE;
									}
								}
								else
								{
									j--;
								}
							}
							goto IL_CB;
						}
						IL_3BE:;
					}
					if (class58_0.class126_0 != null)
					{
						class58_0.class126_0.int_15 = num3;
					}
				}
				catch (Exception)
				{
					Class83.smethod_66(frmMain.String_455, null, new object[0]);
				}
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00077C6C File Offset: 0x00075E6C
		internal static void smethod_106(Class58 class58_0, bool bool_1 = false, int int_0 = 0, int int_1 = -1, int int_2 = -1, int int_3 = 0)
		{
			if (class58_0.class126_0.int_1 >= 0)
			{
				class58_0.class75_0.long_3 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				int num = 0;
				List<int> list = new List<int>();
				List<int> list2 = new List<int>();
				List<int> list3 = new List<int>();
				if (class58_0.class126_0.list_0[0].int_0 == class58_0.class114_0.int_11 || (class58_0.class126_0.int_1 == 0 && bool_1))
				{
					if (bool_1)
					{
						if (int_0 == 1)
						{
							class58_0.class75_0.long_5 = frmLogin.stopwatch_0.ElapsedMilliseconds;
						}
						else if (int_0 == 2 && class58_0.class59_0.int_2 == 3)
						{
							if (class58_0.class59_0.int_11 == 10 || class58_0.class59_0.int_11 == 0)
							{
								return;
							}
							if (frmLogin.stopwatch_0.ElapsedMilliseconds - class58_0.class75_0.long_6 > (long)int_3)
							{
								class58_0.class75_0.long_6 = 0L;
							}
							if (class58_0.class75_0.long_6 == 0L)
							{
								int num2 = 0;
								for (;;)
								{
									bool flag = false;
									for (int i = 0; i < 30; i++)
									{
										Class113 @class = class58_0.class112_0.list_1[i];
										if (@class.int_0 == 30008009 || @class.int_0 == 30505217)
										{
											if (class58_0.autoSettings_0.cboxDanhQuai)
											{
												class58_0.method_370();
											}
											class58_0.method_189(i, class58_0.class114_0.int_9, 0, 0, 0, 0);
											class58_0.class75_0.long_6 = frmLogin.stopwatch_0.ElapsedMilliseconds;
											flag = true;
										}
									}
									if (!frmLogin.class101_0.globalSettings_0.TuMuaCKH)
									{
										flag = true;
									}
									num2++;
									if (class58_0.class59_0.int_11 == 1 || class58_0.class59_0.int_11 == 2 || class58_0.class59_0.int_11 == 8 || class58_0.class59_0.int_11 == 9 || class58_0.class59_0.int_11 == 10)
									{
										goto IL_90F;
									}
									if (flag || num2 > 1)
									{
										break;
									}
									class58_0.method_110(4, 2);
									Thread.Sleep(200);
									class58_0.method_111(37, -1);
									Thread.Sleep(500);
								}
								class58_0.method_210();
							}
						}
						else if (int_0 == 3)
						{
							class58_0.method_207();
						}
						else if (int_0 == 5)
						{
							class58_0.method_370();
							class58_0.class75_0.long_8 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							class58_0.class75_0.long_10 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							if (class58_0.class120_0.int_8 == 0)
							{
								class58_0.method_167(int_1, int_2, 34);
								Thread.Sleep(1000);
							}
							else
							{
								class58_0.method_167(int_1, int_2, class58_0.class120_0.int_8);
							}
							if (class58_0.class114_0.string_8 == "KNVH")
							{
								int num3 = class58_0.method_209();
								class58_0.method_167(int_1, int_2, num3);
								class58_0.class120_0.int_8 = num3;
							}
							if (class58_0.class114_0.ActionStatus == 3)
							{
								if (class58_0.class120_0.int_8 == 0)
								{
									class58_0.class120_0.int_8 = 34;
								}
								class58_0.method_21();
							}
						}
						else if (int_0 == 7)
						{
							if (int_1 == 1)
							{
								class58_0.class75_0.long_13 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							}
							for (int j = 0; j < 30; j++)
							{
								if (class58_0.class112_0.list_1[j].int_0 == 30103042)
								{
									class58_0.method_189(j, class58_0.class114_0.int_9, 0, 0, 0, 0);
									break;
								}
							}
						}
						else if (int_0 == 8)
						{
							if (int_1 == -1)
							{
								if (Class83.smethod_117(class58_0.class114_0.MapID, null))
								{
									int num4 = class58_0.method_208(4);
									if (num4 >= 0)
									{
										class58_0.method_370();
										class58_0.method_189(num4, class58_0.class114_0.int_9, 0, 0, 0, 0);
										class58_0.class114_0.long_100 = frmLogin.stopwatch_0.ElapsedMilliseconds + 10000L;
									}
									else if (int_2 == -1)
									{
										class58_0.method_370();
										class58_0.method_194(0, 22, 0, 0, false, false);
										class58_0.class114_0.long_100 = frmLogin.stopwatch_0.ElapsedMilliseconds + 20000L;
									}
								}
							}
							else if (int_1 >= 0 && !Class83.smethod_118(class58_0.class114_0.MapID, null))
							{
								int num5;
								if (int_1 == 99)
								{
									num5 = class58_0.method_28(-1);
								}
								else
								{
									num5 = class58_0.method_28(int_1);
								}
								if (num5 >= 0)
								{
									class58_0.method_370();
									Thread.Sleep(500);
									class58_0.method_189(num5, class58_0.class114_0.int_9, 0, 0, 0, 0);
									class58_0.class114_0.long_100 = frmLogin.stopwatch_0.ElapsedMilliseconds + 10000L;
								}
								else
								{
									class58_0.method_370();
									Thread.Sleep(500);
									class58_0.method_194(0, 22, 0, 0, false, false);
									class58_0.class114_0.long_100 = frmLogin.stopwatch_0.ElapsedMilliseconds + 20000L;
								}
							}
						}
						else if (int_0 == 9)
						{
							class58_0.method_148();
						}
						else if (int_0 == 11)
						{
							class58_0.class75_0.long_10 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							if (int_1 == 1 && class58_0.class114_0.ActionStatus == 7)
							{
								if (class58_0.class120_0.int_8 > 0)
								{
									class58_0.method_194(-1, class58_0.class120_0.int_8, 0, 0, false, false);
								}
								else
								{
									class58_0.method_194(-1, 34, 0, 0, false, false);
									int int_4 = class58_0.method_209();
									class58_0.method_194(-1, int_4, 0, 0, false, false);
								}
							}
						}
						else if (int_0 == 12)
						{
							int num6 = 0;
							for (int k = 0; k < 30; k++)
							{
								if (class58_0.class112_0.list_1[k].int_0 == 30103042)
								{
									num6++;
									if (num6 >= int_1)
									{
										class58_0.method_139(k);
									}
								}
							}
						}
						else if (int_0 == 13)
						{
							if (int_1 == 1)
							{
								class58_0.autoSettings_0.cboxTuNhatVatPham = true;
							}
							else
							{
								class58_0.autoSettings_0.cboxTuNhatVatPham = false;
							}
						}
						else if (int_0 == 14)
						{
							class58_0.class75_0.long_7 = frmLogin.stopwatch_0.ElapsedMilliseconds;
						}
						else if (int_0 == 16)
						{
							if (class58_0.class116_0.Int32_1 != 0)
							{
								bool flag2 = true;
								if (class58_0.class114_0.Menpai == Class57.Menpais.NGAMI && !class58_0.autoSettings_0.cboxDanhQuai)
								{
									flag2 = false;
								}
								if (flag2)
								{
									class58_0.class116_0.bool_3 = false;
									class58_0.method_169(class58_0.class116_0.int_1, class58_0.class116_0.int_2);
								}
							}
						}
						else if (int_0 == 17)
						{
							class58_0.class116_0.bool_3 = true;
						}
						else if (int_0 == 18)
						{
							class58_0.class75_0.long_11 = frmLogin.stopwatch_0.ElapsedMilliseconds;
							if (int_1 == 1)
							{
								class58_0.class75_0.long_11 = frmLogin.stopwatch_0.ElapsedMilliseconds - 8000L;
							}
						}
						else if (int_0 == 20)
						{
							if (class58_0.class75_0.fightingModes_0 == Class57.FightingModes.DANHPETONLY)
							{
								class58_0.class75_0.fightingModes_0 = class58_0.autoSettings_0.FightMode;
								class58_0.autoSettings_0.FightMode = Class57.FightingModes.DANHGOMQUAI;
								class58_0.class75_0.bool_9 = class58_0.autoSettings_0.cboxDanhTheoKey;
								class58_0.autoSettings_0.cboxDanhTheoKey = false;
								class58_0.autoSettings_0.cboxDanhTheoAi = false;
							}
							if (int_1 > 0)
							{
								class58_0.class75_0.int_14 = (int)class58_0.autoSettings_0.Diameter4;
								if (class58_0.class114_0.CharType == Class57.Enum11.const_0)
								{
									class58_0.autoSettings_0.Diameter4 = 5.0;
								}
								else
								{
									class58_0.autoSettings_0.Diameter4 = (double)int_1;
								}
							}
						}
						else if (int_0 == 21)
						{
							if (class58_0.class75_0.fightingModes_0 != Class57.FightingModes.DANHPETONLY)
							{
								class58_0.autoSettings_0.FightMode = class58_0.class75_0.fightingModes_0;
								class58_0.class75_0.fightingModes_0 = Class57.FightingModes.DANHPETONLY;
								class58_0.autoSettings_0.cboxDanhTheoKey = class58_0.class75_0.bool_9;
							}
							if (int_1 > 0)
							{
								class58_0.autoSettings_0.Diameter4 = 30.0;
							}
						}
						else if (int_0 == 22)
						{
							if (class58_0.class114_0.Menpai == Class57.Menpais.NGAMI)
							{
								list.Add(class58_0.class114_0.int_11);
							}
							if (class58_0.class114_0.int_17 <= 0)
							{
								list2.Add(class58_0.class114_0.int_9);
							}
						}
						else if (int_0 == 23)
						{
							class58_0.autoSettings_0.AIMode = Class57.AIModes.DANHTUDO;
							frmMain.smethod_26(class58_0);
						}
						else if (int_0 == 24)
						{
							class58_0.method_44();
						}
						else if (int_0 == 26)
						{
							class58_0.method_148();
						}
						else if (int_0 == 27)
						{
							class58_0.method_348(true);
						}
						else if (int_0 == 29)
						{
							class58_0.autoSettings_0.cboxChoHoiSinh = false;
						}
						else if (int_0 == 31)
						{
							class58_0.method_109(int_1);
						}
						else if (int_0 == 32)
						{
							class58_0.class114_0.bool_74 = true;
							if (class58_0.autoSettings_0.cboxTheoSau)
							{
								class58_0.class114_0.int_93 = 1;
								class58_0.autoSettings_0.cboxTheoSau = false;
							}
						}
					}
					IL_90F:
					try
					{
						for (int l = 1; l <= class58_0.class126_0.int_1; l++)
						{
							Class127 class2 = class58_0.class126_0.list_0[l];
							if (class2.int_0 != class58_0.class114_0.int_11)
							{
								Class83.Class88 class3 = new Class83.Class88();
								class3.class58_0 = null;
								int m = frmLogin.class101_0.class210_0.Count - 1;
								while (m >= 0)
								{
									Class58 class4 = frmLogin.class101_0.class210_0[m];
									if (class4.class114_0.int_11 == class2.int_0)
									{
										class3.class58_0 = class4;
										IL_9A7:
										if (class3.class58_0 == null)
										{
											goto IL_1896;
										}
										if (int_0 == 1)
										{
											class3.class58_0.class75_0.long_5 = frmLogin.stopwatch_0.ElapsedMilliseconds;
											goto IL_1896;
										}
										if (int_0 == 2 && class58_0.class59_0.int_2 == 3)
										{
											if (frmLogin.stopwatch_0.ElapsedMilliseconds - class3.class58_0.class75_0.long_6 > (long)int_3)
											{
												class3.class58_0.class75_0.long_6 = 0L;
											}
											if (class3.class58_0.class75_0.long_6 == 0L)
											{
												int num7 = 0;
												for (;;)
												{
													bool flag3 = false;
													for (int n = 0; n < 30; n++)
													{
														Class113 class5 = class3.class58_0.class112_0.list_1[n];
														if (class5.int_0 == 30008009 || class5.int_0 == 30505217)
														{
															class3.class58_0.method_370();
															class3.class58_0.method_189(n, class3.class58_0.class114_0.int_9, 0, 0, 0, 0);
															class3.class58_0.class75_0.long_6 = frmLogin.stopwatch_0.ElapsedMilliseconds;
															flag3 = true;
														}
													}
													num7++;
													if (class3.class58_0.class59_0.int_11 == 1 || class3.class58_0.class59_0.int_11 == 2 || class3.class58_0.class59_0.int_11 == 8)
													{
														goto IL_1896;
													}
													if (!frmLogin.class101_0.globalSettings_0.TuMuaCKH)
													{
														flag3 = true;
													}
													if (flag3 || num7 > 1)
													{
														break;
													}
													class3.class58_0.method_110(4, 2);
													Thread.Sleep(200);
													class3.class58_0.method_111(37, -1);
													Thread.Sleep(300);
												}
												class3.class58_0.method_210();
												goto IL_1896;
											}
											goto IL_1896;
										}
										else if (int_0 == 3)
										{
											class3.class58_0.method_207();
											if (l > class58_0.class75_0.int_9)
											{
												return;
											}
											goto IL_1896;
										}
										else if (int_0 == 4)
										{
											if (Class83.smethod_117(class3.class58_0.class114_0.MapID, class3.class58_0))
											{
												class3.class58_0.method_162(30f, 12f);
												goto IL_1896;
											}
											goto IL_1896;
										}
										else if (int_0 == 5)
										{
											class3.class58_0.method_370();
											class3.class58_0.class75_0.long_8 = frmLogin.stopwatch_0.ElapsedMilliseconds;
											class3.class58_0.class75_0.long_10 = frmLogin.stopwatch_0.ElapsedMilliseconds;
											if (class3.class58_0.class120_0.int_8 == 0)
											{
												class3.class58_0.method_167(int_1, int_2, 34);
												Thread.Sleep(1000);
											}
											else
											{
												class3.class58_0.method_167(int_1, int_2, class3.class58_0.class120_0.int_8);
											}
											if (class3.class58_0.class114_0.string_8 == "KNVH")
											{
												int num8 = class3.class58_0.method_209();
												class3.class58_0.method_167(int_1, int_2, num8);
												class3.class58_0.class120_0.int_8 = num8;
											}
											if (class3.class58_0.class114_0.ActionStatus == 3)
											{
												if (class3.class58_0.class120_0.int_8 == 0)
												{
													class3.class58_0.class120_0.int_8 = 34;
												}
												class3.class58_0.method_21();
												goto IL_1896;
											}
											goto IL_1896;
										}
										else
										{
											if (int_0 == 6)
											{
												class3.class58_0.autoSettings_0.cboxDanhTheoKey = true;
												goto IL_1896;
											}
											if (int_0 == 7)
											{
												if (int_1 == 1)
												{
													class3.class58_0.class75_0.long_13 = frmLogin.stopwatch_0.ElapsedMilliseconds;
												}
												for (int num9 = 0; num9 < 30; num9++)
												{
													if (class3.class58_0.class112_0.list_1[num9].int_0 == 30103042)
													{
														class3.class58_0.method_189(num9, class3.class58_0.class114_0.int_9, 0, 0, 0, 0);
														break;
													}
												}
												goto IL_1896;
											}
											if (int_0 == 8)
											{
												if (class3.class58_0.class114_0.byte_1 != 0)
												{
													goto IL_1896;
												}
												if (int_1 == -1)
												{
													if (!Class83.smethod_117(class3.class58_0.class114_0.MapID, null) && int_2 <= 0)
													{
														goto IL_1896;
													}
													num++;
													int num10 = class3.class58_0.method_208(4);
													if (num10 >= 0)
													{
														class3.class58_0.method_370();
														class3.class58_0.method_189(num10, class3.class58_0.class114_0.int_9, 0, 0, 0, 0);
														class3.class58_0.class114_0.long_100 = frmLogin.stopwatch_0.ElapsedMilliseconds + 10000L;
														goto IL_1896;
													}
													if (int_2 == -1)
													{
														class3.class58_0.method_370();
														class3.class58_0.method_194(0, 22, 0, 0, false, false);
														class3.class58_0.class114_0.long_100 = frmLogin.stopwatch_0.ElapsedMilliseconds + 20000L;
														goto IL_1896;
													}
													goto IL_1896;
												}
												else
												{
													if (int_1 < 0 || Class83.smethod_118(class3.class58_0.class114_0.MapID, null))
													{
														goto IL_1896;
													}
													int num11;
													if (int_1 == 99)
													{
														num11 = class3.class58_0.method_28(-1);
													}
													else
													{
														num11 = class3.class58_0.method_28(int_1);
													}
													if (num11 >= 0)
													{
														class3.class58_0.method_370();
														Thread.Sleep(500);
														class3.class58_0.method_189(num11, class58_0.class114_0.int_9, 0, 0, 0, 0);
														class3.class58_0.class114_0.long_100 = frmLogin.stopwatch_0.ElapsedMilliseconds + 10000L;
														goto IL_1896;
													}
													class3.class58_0.method_370();
													Thread.Sleep(500);
													class3.class58_0.method_194(0, 22, 0, 0, false, false);
													class3.class58_0.class114_0.long_100 = frmLogin.stopwatch_0.ElapsedMilliseconds + 20000L;
													goto IL_1896;
												}
											}
											else
											{
												if (int_0 == 9)
												{
													class3.class58_0.method_148();
													goto IL_1896;
												}
												if (int_0 == 10)
												{
													class3.class58_0.method_196(class3.class58_0.class114_0.int_9, 21, 0, 0, 0, false);
													goto IL_1896;
												}
												if (int_0 == 11)
												{
													class3.class58_0.class75_0.long_10 = frmLogin.stopwatch_0.ElapsedMilliseconds;
													if (int_1 != 1 || class3.class58_0.class114_0.ActionStatus != 7)
													{
														goto IL_1896;
													}
													if (class3.class58_0.class120_0.int_8 > 0)
													{
														class3.class58_0.method_194(-1, class3.class58_0.class120_0.int_8, 0, 0, false, false);
														goto IL_1896;
													}
													class3.class58_0.method_194(-1, 34, 0, 0, false, false);
													int int_5 = class3.class58_0.method_209();
													class3.class58_0.method_194(-1, int_5, 0, 0, false, false);
													goto IL_1896;
												}
												else
												{
													if (int_0 == 12)
													{
														int num12 = 0;
														for (int num13 = 0; num13 < 30; num13++)
														{
															if (class3.class58_0.class112_0.list_1[num13].int_0 == 30103042)
															{
																num12++;
																if (num12 >= int_1)
																{
																	class3.class58_0.method_139(num13);
																}
															}
														}
														goto IL_1896;
													}
													if (int_0 == 13)
													{
														if (int_1 == 1)
														{
															class3.class58_0.autoSettings_0.cboxTuNhatVatPham = true;
															goto IL_1896;
														}
														class3.class58_0.autoSettings_0.cboxTuNhatVatPham = false;
														goto IL_1896;
													}
													else
													{
														if (int_0 == 14)
														{
															class3.class58_0.class75_0.long_7 = frmLogin.stopwatch_0.ElapsedMilliseconds;
															goto IL_1896;
														}
														if (int_0 == 15)
														{
															class3.class58_0.autoSettings_0.cboxTheoSau = false;
															goto IL_1896;
														}
														if (int_0 == 16)
														{
															if (class3.class58_0.class116_0.Int32_1 == 0)
															{
																goto IL_1896;
															}
															bool flag4 = true;
															if (class3.class58_0.class114_0.Menpai == Class57.Menpais.NGAMI && !class3.class58_0.autoSettings_0.cboxDanhQuai)
															{
																flag4 = false;
															}
															if (flag4)
															{
																class3.class58_0.class116_0.bool_3 = false;
																class3.class58_0.method_169(class3.class58_0.class116_0.int_1, class3.class58_0.class116_0.int_2);
																goto IL_1896;
															}
															goto IL_1896;
														}
														else
														{
															if (int_0 == 17)
															{
																class3.class58_0.class116_0.bool_3 = true;
																goto IL_1896;
															}
															if (int_0 == 18)
															{
																class3.class58_0.class75_0.long_11 = frmLogin.stopwatch_0.ElapsedMilliseconds;
																if (int_1 == 1)
																{
																	class3.class58_0.class75_0.long_11 = frmLogin.stopwatch_0.ElapsedMilliseconds - 8000L;
																	goto IL_1896;
																}
																goto IL_1896;
															}
															else
															{
																if (int_0 == 19)
																{
																	class3.class58_0.class75_0.long_14 = frmLogin.stopwatch_0.ElapsedMilliseconds;
																	goto IL_1896;
																}
																if (int_0 == 20)
																{
																	if (class3.class58_0.class75_0.fightingModes_0 == Class57.FightingModes.DANHPETONLY)
																	{
																		class3.class58_0.class75_0.fightingModes_0 = class3.class58_0.autoSettings_0.FightMode;
																		class3.class58_0.autoSettings_0.FightMode = Class57.FightingModes.DANHGOMQUAI;
																		class3.class58_0.class75_0.bool_9 = class3.class58_0.autoSettings_0.cboxDanhTheoKey;
																		class3.class58_0.autoSettings_0.cboxDanhTheoKey = false;
																		class3.class58_0.autoSettings_0.cboxDanhTheoAi = false;
																	}
																	if (int_1 <= 0)
																	{
																		goto IL_1896;
																	}
																	class3.class58_0.class75_0.int_14 = (int)class3.class58_0.autoSettings_0.Diameter4;
																	if (class3.class58_0.class114_0.CharType == Class57.Enum11.const_0)
																	{
																		class3.class58_0.autoSettings_0.Diameter4 = 5.0;
																		goto IL_1896;
																	}
																	class3.class58_0.autoSettings_0.Diameter4 = (double)int_1;
																	goto IL_1896;
																}
																else if (int_0 == 21)
																{
																	if (class3.class58_0.class75_0.fightingModes_0 != Class57.FightingModes.DANHPETONLY)
																	{
																		class3.class58_0.autoSettings_0.FightMode = class3.class58_0.class75_0.fightingModes_0;
																		class3.class58_0.class75_0.fightingModes_0 = Class57.FightingModes.DANHPETONLY;
																		class3.class58_0.autoSettings_0.cboxDanhTheoKey = class3.class58_0.class75_0.bool_9;
																	}
																	if (int_1 > 0)
																	{
																		class3.class58_0.autoSettings_0.Diameter4 = 30.0;
																		goto IL_1896;
																	}
																	goto IL_1896;
																}
																else if (int_0 == 22)
																{
																	if (class3.class58_0.class114_0.Menpai == Class57.Menpais.NGAMI)
																	{
																		list.Add(class3.class58_0.class114_0.int_11);
																	}
																	if (class3.class58_0.class114_0.int_17 <= 0)
																	{
																		list2.Add(class3.class58_0.class114_0.int_9);
																		goto IL_1896;
																	}
																	goto IL_1896;
																}
																else if (int_0 == 23)
																{
																	bool flag5 = false;
																	if (int_1 == 0)
																	{
																		if (class3.class58_0.class114_0.Menpai == Class57.Menpais.THIEULAM)
																		{
																			flag5 = true;
																		}
																	}
																	else if (int_1 == 1)
																	{
																		if (class3.class58_0.class114_0.Menpai == Class57.Menpais.MINHGIAO)
																		{
																			flag5 = true;
																		}
																	}
																	else if (int_1 == 2)
																	{
																		if (class3.class58_0.class114_0.Menpai == Class57.Menpais.CAIBANG)
																		{
																			flag5 = true;
																		}
																	}
																	else if (int_1 == 3)
																	{
																		if (class3.class58_0.class114_0.Menpai == Class57.Menpais.VODANG)
																		{
																			flag5 = true;
																		}
																	}
																	else if (int_1 == 4)
																	{
																		if (class3.class58_0.class114_0.Menpai == Class57.Menpais.NGAMI)
																		{
																			flag5 = true;
																		}
																	}
																	else if (int_1 == 5)
																	{
																		if (class3.class58_0.class114_0.Menpai == Class57.Menpais.TINHTUC)
																		{
																			flag5 = true;
																		}
																	}
																	else if (int_1 == 6)
																	{
																		if (class3.class58_0.class114_0.Menpai == Class57.Menpais.THIENLONG)
																		{
																			flag5 = true;
																		}
																	}
																	else if (int_1 == 7)
																	{
																		if (class3.class58_0.class114_0.Menpai == Class57.Menpais.THIENSON)
																		{
																			flag5 = true;
																		}
																	}
																	else if (int_1 == 8)
																	{
																		if (class3.class58_0.class114_0.Menpai == Class57.Menpais.TIEUDAO)
																		{
																			flag5 = true;
																		}
																	}
																	else if (int_1 == 10)
																	{
																		if (class3.class58_0.class114_0.Menpai == Class57.Menpais.MODUNG)
																		{
																			flag5 = true;
																		}
																	}
																	else if (int_1 == 11)
																	{
																		if (class3.class58_0.class114_0.Menpai == Class57.Menpais.DUONGMON)
																		{
																			flag5 = true;
																		}
																	}
																	else if (int_1 == 12)
																	{
																		if (class3.class58_0.class114_0.Menpai == Class57.Menpais.QUYCOC)
																		{
																			flag5 = true;
																		}
																	}
																	else if (int_1 == 13)
																	{
																		if (class3.class58_0.class114_0.Menpai == Class57.Menpais.DAOHOA)
																		{
																			flag5 = true;
																		}
																	}
																	else if (int_1 == 14 && class3.class58_0.class114_0.Menpai == Class57.Menpais.TUYETTINH)
																	{
																		flag5 = true;
																	}
																	if (flag5)
																	{
																		class58_0.method_113(class3.class58_0.class114_0.int_11, class3.class58_0.class114_0.int_12);
																		Thread.Sleep(2000);
																		if (!class3.class58_0.class114_0.bool_41)
																		{
																			class3.class58_0.class75_0.bool_17 = true;
																			frmMain.frmMain_0.cboxIsAcBa.Invoke(new MethodInvoker(class3.method_0));
																		}
																		return;
																	}
																	goto IL_1896;
																}
																else
																{
																	if (int_0 == 24)
																	{
																		class3.class58_0.autoSettings_0.MapID = class58_0.autoSettings_0.MapID;
																		class3.class58_0.autoSettings_0.CenterX = class58_0.autoSettings_0.CenterX;
																		class3.class58_0.autoSettings_0.CenterY = class58_0.autoSettings_0.CenterY;
																		class3.class58_0.method_44();
																		goto IL_1896;
																	}
																	if (int_0 == 25)
																	{
																		if (!class3.class58_0.IsAIEnabled)
																		{
																			class3.class58_0.IsAIEnabled = true;
																		}
																		if (class3.class58_0.autoSettings_0.AIMode == Class57.AIModes.NHIEMVU || class3.class58_0.autoSettings_0.AIMode == Class57.AIModes.KHAIKHOANG_HAIDUOC || class3.class58_0.autoSettings_0.AIMode == Class57.AIModes.TRONGTROT)
																		{
																			class3.class58_0.autoSettings_0.AIMode = Class57.AIModes.DANHTUDO;
																			frmMain.smethod_26(class3.class58_0);
																			goto IL_1896;
																		}
																		goto IL_1896;
																	}
																	else
																	{
																		if (int_0 == 26)
																		{
																			class3.class58_0.method_148();
																			goto IL_1896;
																		}
																		if (int_0 == 27)
																		{
																			class3.class58_0.method_348(true);
																			goto IL_1896;
																		}
																		if (int_0 == 28)
																		{
																			class3.class58_0.method_104(int_1);
																			class3.class58_0.method_359(int_1);
																			class3.class58_0.method_251(int_1);
																			goto IL_1896;
																		}
																		if (int_0 == 29)
																		{
																			class3.class58_0.autoSettings_0.cboxChoHoiSinh = false;
																			goto IL_1896;
																		}
																		if (int_0 == 30)
																		{
																			if (class3.class58_0.class114_0.byte_1 == 1)
																			{
																				class3.class58_0.method_360();
																				goto IL_1896;
																			}
																			goto IL_1896;
																		}
																		else
																		{
																			if (int_0 == 31)
																			{
																				class3.class58_0.method_109(int_1);
																				goto IL_1896;
																			}
																			if (int_0 != 32)
																			{
																				goto IL_1896;
																			}
																			class3.class58_0.class114_0.bool_74 = true;
																			if (class3.class58_0.autoSettings_0.cboxTheoSau)
																			{
																				class3.class58_0.class114_0.int_93 = 1;
																				class3.class58_0.autoSettings_0.cboxTheoSau = false;
																				goto IL_1896;
																			}
																			goto IL_1896;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
									else
									{
										m--;
									}
								}
								goto IL_9A7;
							}
							IL_1896:;
						}
					}
					catch (Exception)
					{
						Class83.smethod_66(frmMain.String_454, class58_0, new object[0]);
					}
				}
				if (int_0 == 22)
				{
					if (list2.Count > 0)
					{
						try
						{
							int num14 = 0;
							Class58 class6 = null;
							Class58 class7 = null;
							Class58 class8 = null;
							bool flag6 = false;
							for (int num15 = 0; num15 < list2.Count; num15++)
							{
								int num16 = list2[num15];
								if (list.Count >= num14 + 1)
								{
									int num17 = list[num14];
									for (int num18 = frmLogin.class101_0.class210_0.Count - 1; num18 >= 0; num18--)
									{
										Class58 class9 = frmLogin.class101_0.class210_0[num18];
										if (class9.class114_0.int_11 == num17)
										{
											class6 = class9;
											IL_19DB:
											if (class6 != null)
											{
												class6.method_194(num16, 408, 0, 0, false, false);
												list3.Add(num16);
												flag6 = true;
											}
											num14++;
											goto IL_1A5E;
										}
									}
									goto IL_19DB;
								}
								if (int_1 == 2)
								{
									int num19 = frmLogin.class101_0.class210_0.Count - 1;
									while (num19 >= 0)
									{
										Class58 class10 = frmLogin.class101_0.class210_0[num19];
										if (class10.class114_0.int_9 == num16)
										{
											class7 = class10;
											IL_1A53:
											if (class7 != null)
											{
												class7.method_154();
												goto IL_1A5E;
											}
											goto IL_1A5E;
										}
										else
										{
											num19--;
										}
									}
									goto IL_1A53;
								}
								IL_1A5E:;
							}
							if (flag6)
							{
								if (int_1 != 0)
								{
									if (int_1 != 2)
									{
										Thread.Sleep(3000);
										goto IL_1B14;
									}
								}
								Thread.Sleep(15000);
								if (list3.Count > 0)
								{
									int num20 = 0;
									IL_1B0A:
									while (num20 < list3.Count)
									{
										for (int num21 = frmLogin.class101_0.class210_0.Count - 1; num21 >= 0; num21--)
										{
											Class58 class11 = frmLogin.class101_0.class210_0[num21];
											if (class11.class114_0.int_9 == list3[num20])
											{
												class8 = class11;
												IL_1AF9:
												if (class8 != null)
												{
													class8.method_153();
												}
												num20++;
												goto IL_1B0A;
											}
										}
										goto IL_1AF9;
									}
								}
							}
							IL_1B14:
							goto IL_1B3D;
						}
						catch (Exception)
						{
							Class83.smethod_66(frmMain.String_453, null, new object[0]);
							goto IL_1B3D;
						}
					}
					if (int_1 == 0 || int_1 == 2)
					{
						class58_0.class75_0.int_11 = 1;
					}
				}
				IL_1B3D:
				if (num == 0 && int_0 == 8)
				{
					class58_0.class75_0.int_10 = 1;
				}
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00079800 File Offset: 0x00077A00
		internal static bool smethod_107(Class58 class58_0)
		{
			if (class58_0.class126_0.int_1 > 0 && class58_0.class126_0.list_0[0].int_0 == class58_0.class114_0.int_11)
			{
				try
				{
					for (int i = 1; i <= class58_0.class126_0.int_1; i++)
					{
						Class127 @class = class58_0.class126_0.list_0[i];
						if (@class.int_0 != class58_0.class114_0.int_11)
						{
							Class58 class2 = null;
							int j = frmLogin.class101_0.class210_0.Count - 1;
							while (j >= 0)
							{
								Class58 class3 = frmLogin.class101_0.class210_0[j];
								if (class3.class114_0.int_11 == @class.int_0)
								{
									class2 = class3;
									IL_AE:
									if (class2 == null || !class2.class114_0.bool_162)
									{
										goto IL_BE;
									}
									return true;
								}
								else
								{
									j--;
								}
							}
							goto IL_AE;
						}
						IL_BE:;
					}
					return false;
				}
				catch (Exception)
				{
					Class83.smethod_66(frmMain.String_452, class58_0, new object[0]);
					return false;
				}
				bool result;
				return result;
			}
			return false;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00079910 File Offset: 0x00077B10
		internal static void smethod_108(Class58 class58_0)
		{
			if (class58_0.class126_0.int_1 > 0)
			{
				Class127 @class = class58_0.class126_0.list_0[0];
				if (@class.int_0 != class58_0.class114_0.int_11)
				{
					try
					{
						Class58 class2 = null;
						for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
						{
							Class58 class3 = frmLogin.class101_0.class210_0[i];
							if (class3.class114_0.int_11 == @class.int_0)
							{
								class2 = class3;
								IL_81:
								if (class2 != null)
								{
									class2.method_113(class58_0.class114_0.int_11, class58_0.class114_0.int_12);
								}
								return;
							}
						}
						goto IL_81;
					}
					catch (Exception)
					{
						Class83.smethod_66(frmMain.String_451, class58_0, new object[0]);
					}
				}
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000799E4 File Offset: 0x00077BE4
		internal static bool smethod_109(Class58 class58_0)
		{
			if (class58_0.class126_0.int_1 > 0 && class58_0.class126_0.list_0[0].int_0 == class58_0.class114_0.int_11)
			{
				try
				{
					for (int i = 1; i <= class58_0.class126_0.int_1; i++)
					{
						Class127 @class = class58_0.class126_0.list_0[i];
						if (@class.int_0 != class58_0.class114_0.int_11)
						{
							Class58 class2 = null;
							int j = frmLogin.class101_0.class210_0.Count - 1;
							while (j >= 0)
							{
								Class58 class3 = frmLogin.class101_0.class210_0[j];
								if (class3.class114_0.int_11 == @class.int_0)
								{
									class2 = class3;
									IL_AE:
									if (class2 != null && class2.class114_0.Status == Class57.Enum13.const_9)
									{
										return false;
									}
									goto IL_C5;
								}
								else
								{
									j--;
								}
							}
							goto IL_AE;
						}
						IL_C5:;
					}
					return true;
				}
				catch (Exception)
				{
					Class83.smethod_66(frmMain.String_451, class58_0, new object[0]);
					return true;
				}
				bool result;
				return result;
			}
			return true;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00079AFC File Offset: 0x00077CFC
		internal static void smethod_110(Class58 class58_0, bool bool_1 = false)
		{
			if (class58_0.class126_0.int_1 > 0 && class58_0.class126_0.list_0[0].int_0 == class58_0.class114_0.int_11)
			{
				try
				{
					for (int i = 1; i <= class58_0.class126_0.int_1; i++)
					{
						Class127 @class = class58_0.class126_0.list_0[i];
						if (@class.int_0 != class58_0.class114_0.int_11)
						{
							Class58 class2 = null;
							int j = frmLogin.class101_0.class210_0.Count - 1;
							while (j >= 0)
							{
								Class58 class3 = frmLogin.class101_0.class210_0[j];
								if (class3.class114_0.int_11 == @class.int_0)
								{
									class2 = class3;
									IL_B1:
									if (class2 != null)
									{
										if (class2.class114_0.Status != Class57.Enum13.const_0)
										{
											class2.class114_0.Status = Class57.Enum13.const_0;
										}
										if (class2.class114_0.enum13_1 != Class57.Enum13.const_0)
										{
											class2.class114_0.enum13_1 = Class57.Enum13.const_0;
										}
										class2.class114_0.enum13_2 = Class57.Enum13.const_0;
										class2.class114_0.enum13_3 = Class57.Enum13.const_0;
										goto IL_FE;
									}
									goto IL_FE;
								}
								else
								{
									j--;
								}
							}
							goto IL_B1;
						}
						IL_FE:;
					}
				}
				catch (Exception)
				{
					Class83.smethod_66(frmMain.String_448, class58_0, new object[0]);
				}
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00079C44 File Offset: 0x00077E44
		internal static bool smethod_111(Class58 class58_0, int int_0 = 0)
		{
			if (class58_0.class126_0.int_1 > 0 && class58_0.class126_0.list_0[0].int_0 == class58_0.class114_0.int_11)
			{
				try
				{
					for (int i = 1; i <= class58_0.class126_0.int_1; i++)
					{
						Class127 @class = class58_0.class126_0.list_0[i];
						if (@class.int_0 != class58_0.class114_0.int_11)
						{
							Class58 class2 = null;
							int j = frmLogin.class101_0.class210_0.Count - 1;
							while (j >= 0)
							{
								Class58 class3 = frmLogin.class101_0.class210_0[j];
								if (class3.class114_0.int_11 == @class.int_0)
								{
									class2 = class3;
									IL_AE:
									if (class2 == null || int_0 != 1 || !class2.class114_0.bool_74)
									{
										goto IL_C2;
									}
									return false;
								}
								else
								{
									j--;
								}
							}
							goto IL_AE;
						}
						IL_C2:;
					}
					return true;
				}
				catch (Exception)
				{
					Class83.smethod_66(frmMain.String_451, class58_0, new object[0]);
					return true;
				}
				bool result;
				return result;
			}
			return true;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00079D58 File Offset: 0x00077F58
		internal static void smethod_112(Class58 class58_0, bool bool_1 = true, int int_0 = -1, int int_1 = -1, int int_2 = -1)
		{
			if (class58_0.class126_0.int_1 > 0 && class58_0.class126_0.list_0[0].int_0 == class58_0.class114_0.int_11)
			{
				if (bool_1)
				{
					class58_0.class114_0.Status = Class57.Enum13.const_21;
					class58_0.class114_0.int_121 = int_0;
					class58_0.class114_0.int_122 = int_1;
					class58_0.class114_0.int_123 = int_2;
					class58_0.class114_0.long_97 = frmLogin.stopwatch_0.ElapsedMilliseconds;
				}
				try
				{
					for (int i = 1; i <= class58_0.class126_0.int_1; i++)
					{
						Class127 @class = class58_0.class126_0.list_0[i];
						if (@class.int_0 != class58_0.class114_0.int_11)
						{
							Class58 class2 = null;
							int j = frmLogin.class101_0.class210_0.Count - 1;
							while (j >= 0)
							{
								Class58 class3 = frmLogin.class101_0.class210_0[j];
								if (class3.class114_0.int_11 == @class.int_0)
								{
									class2 = class3;
									IL_FF:
									if (class2 != null)
									{
										class2.class114_0.Status = Class57.Enum13.const_21;
										class2.class114_0.int_121 = int_0;
										class2.class114_0.int_122 = int_1;
										class2.class114_0.int_123 = int_2;
										class2.class114_0.long_97 = frmLogin.stopwatch_0.ElapsedMilliseconds;
										goto IL_14C;
									}
									goto IL_14C;
								}
								else
								{
									j--;
								}
							}
							goto IL_FF;
						}
						IL_14C:;
					}
				}
				catch (Exception)
				{
					Class83.smethod_66(frmMain.String_447, class58_0, new object[0]);
				}
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00079EEC File Offset: 0x000780EC
		internal static void smethod_113(Class58 class58_0, int int_0, int int_1, int int_2, bool bool_1 = true, int int_3 = 0)
		{
			if (class58_0.class126_0.int_1 > 0 && class58_0.class126_0.list_0[0].int_0 == class58_0.class114_0.int_11)
			{
				try
				{
					for (int i = 1; i <= class58_0.class126_0.int_1; i++)
					{
						Class127 @class = class58_0.class126_0.list_0[i];
						if (@class.int_0 != class58_0.class114_0.int_11)
						{
							Class58 class2 = null;
							int j = frmLogin.class101_0.class210_0.Count - 1;
							while (j >= 0)
							{
								Class58 class3 = frmLogin.class101_0.class210_0[j];
								if (class3.class114_0.int_11 == @class.int_0)
								{
									class2 = class3;
									IL_B1:
									if (class2 == null)
									{
										goto IL_271;
									}
									int num = 700;
									if (bool_1)
									{
										class2.method_175(0, 0, int_0, false, false);
										if (int_1 != 50100)
										{
											if (int_1 != 50101)
											{
												Thread.Sleep(num);
												goto IL_F5;
											}
										}
										class2.method_360();
										Thread.Sleep(num);
									}
									IL_F5:
									if (((int_1 == 50100 && int_2 == 2) || (int_1 == 50101 && int_2 == 2)) && (!class2.autoSettings_0.cboxTuHuyNV || (class2.class75_0.long_5 > 0L && frmLogin.stopwatch_0.ElapsedMilliseconds - class2.class75_0.long_5 <= 120000L)))
									{
										goto IL_271;
									}
									class2.method_175(int_1, int_2, int_0, false, false);
									Thread.Sleep(num);
									if (class2.class114_0.string_12 == "NVTB")
									{
										class2.method_20();
										if (class2.class75_0.long_5 > 0L && frmLogin.stopwatch_0.ElapsedMilliseconds - class2.class75_0.long_5 <= 60000L)
										{
											goto IL_271;
										}
										if (class2.class75_0.int_0 >= 4)
										{
											if (class2.autoSettings_0.cboxTuHuyNV)
											{
												class2.method_109(int_1);
											}
											if (class2.autoSettings_0.cboxHongQPT)
											{
												class2.method_112();
											}
											class2.class75_0.int_0 = 0;
											goto IL_271;
										}
										class2.class75_0.int_0++;
										goto IL_271;
									}
									else
									{
										if (class2.class114_0.string_12 == "DGXQ")
										{
											class2.method_131();
											Thread.Sleep(num + 300);
											class2.method_131();
											class2.method_20();
											class2.class75_0.int_0 = 0;
											goto IL_271;
										}
										if (int_3 == 1)
										{
											class2.method_121();
											Thread.Sleep(num);
											goto IL_271;
										}
										if (int_3 == 2)
										{
											class2.method_131();
											Thread.Sleep(num);
											goto IL_271;
										}
										goto IL_271;
									}
								}
								else
								{
									j--;
								}
							}
							goto IL_B1;
						}
						IL_271:;
					}
				}
				catch (Exception)
				{
					Class83.smethod_66(frmMain.String_446, class58_0, new object[0]);
				}
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0007A1B4 File Offset: 0x000783B4
		internal static void smethod_114(Class58 class58_0, int int_0 = 0, string string_2 = "")
		{
			if (class58_0.class126_0.int_1 > 0 && class58_0.class126_0.list_0[0].int_0 == class58_0.class114_0.int_11)
			{
				try
				{
					for (int i = 1; i <= class58_0.class126_0.int_1; i++)
					{
						Class127 @class = class58_0.class126_0.list_0[i];
						if (@class.int_0 != class58_0.class114_0.int_11)
						{
							Class58 class2 = null;
							int j = frmLogin.class101_0.class210_0.Count - 1;
							while (j >= 0)
							{
								Class58 class3 = frmLogin.class101_0.class210_0[j];
								if (class3.class114_0.int_11 == @class.int_0)
								{
									class2 = class3;
									IL_B1:
									if (class2 == null)
									{
										goto IL_137;
									}
									if (int_0 == 0)
									{
										class2.class118_0.list_2.Clear();
										goto IL_137;
									}
									bool flag = false;
									if (class2.class118_0.list_2.Count > 0)
									{
										for (int k = 0; k < class2.class118_0.list_2.Count; k++)
										{
											string b = class2.class118_0.list_2[k];
											if (string_2 == b)
											{
												flag = true;
											}
										}
									}
									if (!flag)
									{
										class2.class118_0.list_2.Add(string_2);
										goto IL_137;
									}
									goto IL_137;
								}
								else
								{
									j--;
								}
							}
							goto IL_B1;
						}
						IL_137:;
					}
				}
				catch (Exception)
				{
					if (Class83.smethod_119())
					{
						Class83.smethod_66(frmMain.String_445, class58_0, new object[0]);
					}
				}
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0007A348 File Offset: 0x00078548
		internal static void smethod_115(Class58 class58_0, Class58 class58_1)
		{
			if (class58_0 != null && class58_1 != null)
			{
				if (class58_0.class114_0.int_38 == -1)
				{
					class58_0.method_371();
				}
				class58_0.IsAIEnabled = true;
				class58_0.class114_0.float_11 = class58_1.class114_0.float_0;
				class58_0.class114_0.float_14 = class58_1.class114_0.float_5;
				class58_0.class114_0.int_29 = class58_1.class114_0.MapID;
				class58_0.autoSettings_0.SavedPosX = class58_1.class114_0.float_0;
				class58_0.autoSettings_0.SavedPosY = class58_1.class114_0.float_5;
				class58_0.autoSettings_0.SavedMapID = class58_1.class114_0.MapID;
				class58_0.class114_0.bool_14 = true;
				if (class58_0.autoSettings_0.MapID != class58_1.class114_0.MapID)
				{
					class58_0.autoSettings_0.MapID = class58_1.class114_0.MapID;
				}
				if (class58_0.autoSettings_0.CenterX != class58_1.autoSettings_0.CenterX)
				{
					class58_0.autoSettings_0.CenterX = class58_1.autoSettings_0.CenterX;
				}
				if (class58_0.autoSettings_0.CenterY != class58_1.autoSettings_0.CenterY)
				{
					class58_0.autoSettings_0.CenterY = class58_1.autoSettings_0.CenterY;
				}
				class58_0.class114_0.int_33 = class58_1.class114_0.MapID;
				class58_0.class114_0.int_34 = (int)class58_1.class114_0.float_0;
				class58_0.class114_0.int_35 = (int)class58_1.class114_0.float_5;
				class58_0.class114_0.bool_12 = true;
				class58_0.class114_0.enum13_3 = Class57.Enum13.const_19;
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000457F File Offset: 0x0000277F
		internal static double smethod_116(double double_0, double double_1, double double_2, double double_3)
		{
			return Math.Sqrt((double_0 - double_2) * (double_0 - double_2) + (double_1 - double_3) * (double_1 - double_3));
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0007A4F8 File Offset: 0x000786F8
		internal static bool smethod_117(int int_0, Class58 class58_0 = null)
		{
			string text = Class83.smethod_133(int_0);
			if (text.Contains("ôi đài") || text == "Arena")
			{
				return true;
			}
			if (int_0 >= 36 && int_0 <= 138 && int_0 != 39 && int_0 != 123 && int_0 != 126)
			{
				return true;
			}
			if (int_0 >= 152 && int_0 <= 155)
			{
				return true;
			}
			if (int_0 >= 182 && int_0 <= 194 && int_0 != 186 && int_0 != 188)
			{
				return true;
			}
			if (int_0 >= 196 && int_0 <= 199)
			{
				return true;
			}
			if (int_0 >= 313 && int_0 <= 399)
			{
				return true;
			}
			if (int_0 >= 403 && int_0 <= 419 && int_0 != 415)
			{
				return true;
			}
			if (class58_0 != null)
			{
				if (class58_0.class59_0.int_2 == 3)
				{
					if (int_0 != 195)
					{
						if (int_0 != 441)
						{
							if (int_0 >= 465 && int_0 <= 518)
							{
								return true;
							}
							if (int_0 == 445)
							{
								return true;
							}
							goto IL_F8;
						}
					}
					return true;
				}
				IL_F8:
				if (Class83.smethod_61(class58_0.class59_0.int_2) >= 360 && Class83.smethod_149(int_0))
				{
					return false;
				}
			}
			return (int_0 >= 446 && int_0 <= 464) || ((int_0 < 519 || int_0 > 522) && (int_0 < 496 || int_0 > 498) && int_0 != 517 && ((int_0 >= 481 && int_0 <= 596) || (int_0 >= 705 && int_0 <= 1668)));
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0007A684 File Offset: 0x00078884
		internal static bool smethod_118(int int_0, Class58 class58_0 = null)
		{
			if (class58_0 != null && class58_0.class59_0.int_2 == 3 && int_0 == 480)
			{
				return false;
			}
			if (int_0 != 0 && int_0 != 1 && int_0 != 2 && int_0 != 186 && int_0 != 480)
			{
				if (int_0 != 181)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0007A6D4 File Offset: 0x000788D4
		internal static bool smethod_119()
		{
			string username = frmLogin.class101_0.globalSettings_0.Account.Username;
			return username == "gauto.support" || username == "testauto1" || username == "testauto2" || frmLogin.class101_0.globalSettings_0.IsSupportMode;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0007A734 File Offset: 0x00078934
		internal static bool smethod_120()
		{
			string username = frmLogin.class101_0.globalSettings_0.Account.Username;
			if (frmLogin.list_14.Count == 0)
			{
				frmMain.smethod_45();
			}
			return frmLogin.list_14.Count > 0 && frmLogin.list_14.Contains(username);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00004595 File Offset: 0x00002795
		internal static string smethod_121(string string_2, string string_3)
		{
			return Class83.Class85.smethod_0(string_3 + string_2).ToLower().Substring(0, 10);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000045B0 File Offset: 0x000027B0
		internal static bool smethod_122()
		{
			return frmLogin.class101_0.globalSettings_0.Account.Username == "taitieudat";
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0007A784 File Offset: 0x00078984
		internal static Image smethod_123(string string_2, CookieContainer cookieContainer_0, ref bool bool_1)
		{
			bool_1 = false;
			Image result = null;
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_2);
			httpWebRequest.Method = "GET";
			httpWebRequest.CookieContainer = cookieContainer_0;
			httpWebRequest.KeepAlive = true;
			httpWebRequest.ContentType = "image/png";
			httpWebRequest.Timeout = 30000;
			httpWebRequest.Proxy = null;
			if (frmLogin.webProxy_0 != null)
			{
				httpWebRequest.Proxy = frmLogin.webProxy_0;
			}
			httpWebRequest.Referer = "zheshigauto";
			try
			{
				Stream responseStream = ((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream();
				responseStream.ReadTimeout = 20000;
				result = Image.FromStream(responseStream);
				bool_1 = true;
			}
			catch (Exception)
			{
				bool_1 = false;
			}
			return result;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0007A834 File Offset: 0x00078A34
		internal static string smethod_124(string string_2, string string_3, string string_4, CookieContainer cookieContainer_0, bool bool_1 = true)
		{
			long num = frmLogin.stopwatch_0.ElapsedMilliseconds + frmLogin.class101_0.globalSettings_0.httpRetriesMax;
			int num2 = 0;
			string result;
			for (;;)
			{
				if (!string_2.StartsWith("http://"))
				{
					goto IL_264;
				}
				IL_22:
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_2);
				httpWebRequest.Method = string_4.ToUpper();
				httpWebRequest.CookieContainer = cookieContainer_0;
				httpWebRequest.Timeout = 30000;
				httpWebRequest.Proxy = null;
				if (num2 >= 2)
				{
					Class83.smethod_127();
				}
				if (frmLogin.webProxy_0 != null)
				{
					httpWebRequest.Proxy = frmLogin.webProxy_0;
				}
				httpWebRequest.ServicePoint.Expect100Continue = false;
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				httpWebRequest.KeepAlive = false;
				httpWebRequest.Referer = "zheshigauto";
				bool flag = true;
				if (httpWebRequest.Method == "POST")
				{
					byte[] bytes = Encoding.ASCII.GetBytes(string_3);
					httpWebRequest.ContentLength = (long)bytes.Length;
					try
					{
						Stream requestStream = httpWebRequest.GetRequestStream();
						requestStream.ReadTimeout = 30000;
						requestStream.WriteTimeout = 30000;
						requestStream.Write(bytes, 0, bytes.Length);
						requestStream.Close();
					}
					catch (Exception ex)
					{
						num2++;
						if (bool_1)
						{
							bool flag2 = false;
							if (frmLogin.stopwatch_0.ElapsedMilliseconds > num)
							{
								flag2 = true;
							}
							bool flag3 = false;
							if (num2 > frmLogin.class101_0.globalSettings_0.httpRetries)
							{
								flag3 = true;
							}
							if (!flag3)
							{
								Thread.Sleep(frmLogin.class101_0.globalSettings_0.httpRetriesDelay);
								continue;
							}
							if (!flag2)
							{
								Thread.Sleep(frmLogin.class101_0.globalSettings_0.httpRetriesDelay);
								continue;
							}
						}
						result = frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage + ": " + ex.Message;
						break;
					}
					if (bytes.Length == 0)
					{
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
				if (!flag)
				{
					goto IL_28D;
				}
				try
				{
					Stream responseStream = ((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream();
					responseStream.ReadTimeout = 10000;
					responseStream.WriteTimeout = 10000;
					result = new StreamReader(responseStream).ReadToEnd();
					break;
				}
				catch (Exception ex2)
				{
					num2++;
					if (bool_1)
					{
						bool flag4 = false;
						if (frmLogin.stopwatch_0.ElapsedMilliseconds > num)
						{
							flag4 = true;
						}
						bool flag5 = false;
						if (num2 > frmLogin.class101_0.globalSettings_0.httpRetries)
						{
							flag5 = true;
						}
						if (!flag5)
						{
							Thread.Sleep(frmLogin.class101_0.globalSettings_0.httpRetriesDelay);
							continue;
						}
						if (!flag4)
						{
							Thread.Sleep(frmLogin.class101_0.globalSettings_0.httpRetriesDelay);
							continue;
						}
					}
					result = frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage + ": " + ex2.Message;
					break;
				}
				IL_264:
				string_2 = "http://" + string_2;
				goto IL_22;
			}
			return result;
			IL_28D:
			return frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0007AAFC File Offset: 0x00078CFC
		internal static string smethod_125(string string_2, string string_3, string string_4, CookieContainer cookieContainer_0, bool bool_1 = true)
		{
			long num = frmLogin.stopwatch_0.ElapsedMilliseconds + frmLogin.class101_0.globalSettings_0.httpRetriesMax;
			int num2 = 0;
			string result;
			for (;;)
			{
				if (!string_2.StartsWith("http://"))
				{
					goto IL_298;
				}
				IL_22:
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_2);
				httpWebRequest.Method = string_4.ToUpper();
				httpWebRequest.CookieContainer = cookieContainer_0;
				httpWebRequest.Timeout = 30000;
				httpWebRequest.Proxy = null;
				if (num2 >= 2)
				{
					Class83.smethod_127();
				}
				if (frmLogin.webProxy_0 != null)
				{
					httpWebRequest.Proxy = frmLogin.webProxy_0;
				}
				httpWebRequest.ServicePoint.Expect100Continue = false;
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				httpWebRequest.KeepAlive = true;
				httpWebRequest.Referer = "zheshigauto";
				bool flag = true;
				if (httpWebRequest.Method == "POST")
				{
					byte[] bytes = Encoding.ASCII.GetBytes(string_3);
					httpWebRequest.ContentLength = (long)bytes.Length;
					try
					{
						Stream requestStream = httpWebRequest.GetRequestStream();
						requestStream.WriteTimeout = 30000;
						requestStream.ReadTimeout = 30000;
						requestStream.Write(bytes, 0, bytes.Length);
						requestStream.Close();
					}
					catch (Exception ex)
					{
						num2++;
						if (bool_1)
						{
							bool flag2 = false;
							if (frmLogin.stopwatch_0.ElapsedMilliseconds > num)
							{
								flag2 = true;
							}
							bool flag3 = false;
							if (num2 > frmLogin.class101_0.globalSettings_0.httpRetries)
							{
								flag3 = true;
							}
							if (!flag3)
							{
								Thread.Sleep(frmLogin.class101_0.globalSettings_0.httpRetriesDelay);
								continue;
							}
							if (!flag2)
							{
								Thread.Sleep(frmLogin.class101_0.globalSettings_0.httpRetriesDelay);
								continue;
							}
						}
						result = frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage + ": " + ex.Message;
						break;
					}
					if (bytes.Length == 0)
					{
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
				if (!flag)
				{
					goto IL_2D1;
				}
				try
				{
					Stream responseStream = ((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream();
					responseStream.ReadTimeout = 30000;
					responseStream.WriteTimeout = 30000;
					result = new StreamReader(responseStream).ReadToEnd();
					break;
				}
				catch (Exception ex2)
				{
					num2++;
					if (bool_1)
					{
						bool flag4 = false;
						if (frmLogin.stopwatch_0.ElapsedMilliseconds > num)
						{
							flag4 = true;
						}
						bool flag5 = false;
						if (num2 > frmLogin.class101_0.globalSettings_0.httpRetries)
						{
							flag5 = true;
						}
						if (!flag5)
						{
							Thread.Sleep(frmLogin.class101_0.globalSettings_0.httpRetriesDelay);
							continue;
						}
						if (!flag4)
						{
							Thread.Sleep(frmLogin.class101_0.globalSettings_0.httpRetriesDelay);
							continue;
						}
					}
					Class83.smethod_66(frmMain.String_444 + ": " + ex2.Message.Replace("prx.gameauto.net", "gameauto.net"), null, new object[0]);
					result = frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage + ": " + ex2.Message;
					break;
				}
				IL_298:
				if (!string_2.StartsWith("https://"))
				{
					string_2 = "http://" + string_2;
					goto IL_22;
				}
				goto IL_22;
			}
			return result;
			IL_2D1:
			return frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0007AE08 File Offset: 0x00079008
		internal static CookieCollection smethod_126(CookieContainer cookieContainer_0)
		{
			CookieCollection cookieCollection = new CookieCollection();
			foreach (object obj in ((Hashtable)cookieContainer_0.GetType().GetField("m_domainTable", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(cookieContainer_0)))
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				foreach (object obj2 in ((SortedList)dictionaryEntry.Value.GetType().GetField("m_list", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(dictionaryEntry.Value)))
				{
					foreach (object obj3 in ((CookieCollection)((DictionaryEntry)obj2).Value))
					{
						Cookie cookie = (Cookie)obj3;
						cookieCollection.Add(cookie);
					}
				}
			}
			return cookieCollection;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0007AF44 File Offset: 0x00079144
		internal static void smethod_127()
		{
			string host = "202.43.110.72";
			try
			{
				IPHostEntry hostEntry = Dns.GetHostEntry(frmLogin.class101_0.globalSettings_0.ProxyURL);
				if (hostEntry.AddressList.Length != 0)
				{
					host = hostEntry.AddressList[0].ToString();
				}
			}
			catch (Exception)
			{
			}
			if (frmLogin.webProxy_0 == null && frmLogin.class101_0.globalSettings_0.ProxyURL != "" && Monitor.TryEnter(frmLogin.object_16, 200))
			{
				try
				{
					frmLogin.webProxy_0 = new WebProxy(host, 7777);
					frmLogin.long_38 = frmLogin.stopwatch_0.ElapsedMilliseconds + 3600000L;
				}
				catch (Exception)
				{
				}
				finally
				{
					Monitor.Exit(frmLogin.object_16);
				}
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000024E9 File Offset: 0x000006E9
		private static void smethod_128(HttpWebRequest httpWebRequest_0, Action<HttpWebResponse> action_0)
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000024E9 File Offset: 0x000006E9
		private static void smethod_129(IAsyncResult iasyncResult_0)
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0007B01C File Offset: 0x0007921C
		internal static void smethod_130(int int_0, out string string_2, out string string_3)
		{
			string_2 = "";
			string_3 = "";
			foreach (Class145 @class in frmLogin.class101_0.list_2)
			{
				if (@class.int_0 == int_0)
				{
					string_2 = @class.string_0.ToLower();
					string_3 = @class.string_1.ToLower();
					break;
				}
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0007B0A4 File Offset: 0x000792A4
		internal static Class147 smethod_131(int int_0)
		{
			if (int_0 >= 0)
			{
				using (List<Class147>.Enumerator enumerator = frmLogin.class101_0.list_3.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class147 @class = enumerator.Current;
						if (@class.int_0 == int_0)
						{
							return @class;
						}
					}
					goto IL_49;
				}
				Class147 result;
				return result;
			}
			IL_49:
			return null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0007B10C File Offset: 0x0007930C
		internal static bool smethod_132(int int_0)
		{
			bool flag = false;
			if (int_0 >= 205 && int_0 <= 312)
			{
				flag = true;
			}
			if (!flag && int_0 >= 597 && int_0 <= 704)
			{
				flag = true;
			}
			return flag;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0007B144 File Offset: 0x00079344
		internal static string smethod_133(int int_0)
		{
			if (int_0 >= 0)
			{
				using (List<Class147>.Enumerator enumerator = frmLogin.class101_0.list_3.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class147 @class = enumerator.Current;
						if (@class.int_0 == int_0)
						{
							return @class.string_0;
						}
					}
					goto IL_4E;
				}
				string result;
				return result;
			}
			IL_4E:
			return "";
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0007B1B4 File Offset: 0x000793B4
		internal static void smethod_134(Class155 class155_0, int int_0, int int_1)
		{
			if (int_0 != -1 && int_1 != -1 && class155_0 != null && File.Exists(frmLogin.class101_0.globalSettings_0.SettingDB))
			{
				SQLiteConnection sqliteConnection = new SQLiteConnection("Data Source=" + frmLogin.class101_0.globalSettings_0.SettingDB);
				sqliteConnection.Open();
				if (sqliteConnection.State == ConnectionState.Open)
				{
					if (Class161.smethod_0(frmLogin.class101_0.globalSettings_0.TNTable, true, ""))
					{
						SQLiteDataReader reader = new SQLiteCommand(string.Format("SELECT * FROM tnprices2 WHERE itemid = '{0}' AND bangid = '{1}' AND friendid = {2};", class155_0.int_0, int_0, int_1), sqliteConnection).ExecuteReader();
						DataTable dataTable = new DataTable();
						dataTable.Load(reader);
						if (dataTable.Rows.Count > 0)
						{
							DataRow dataRow = dataTable.Rows[0];
							class155_0.double_0 = ((!string.IsNullOrEmpty(dataRow["spread"].ToString())) ? double.Parse(dataRow["spread"].ToString()) : 0.0);
							class155_0.double_1 = ((!string.IsNullOrEmpty(dataRow["midprice"].ToString())) ? double.Parse(dataRow["midprice"].ToString()) : 0.0);
							class155_0.double_3 = ((!string.IsNullOrEmpty(dataRow["highprice"].ToString())) ? double.Parse(dataRow["highprice"].ToString()) : 0.0);
							class155_0.double_2 = ((!string.IsNullOrEmpty(dataRow["lowprice"].ToString())) ? double.Parse(dataRow["lowprice"].ToString()) : 0.0);
							class155_0.int_5 = int_0;
							class155_0.int_6 = int_1;
						}
						else
						{
							class155_0.double_0 = 0.0;
							class155_0.double_1 = 0.0;
							class155_0.double_3 = 0.0;
							class155_0.double_2 = 0.0;
							class155_0.int_5 = int_0;
							class155_0.int_6 = int_1;
						}
					}
					sqliteConnection.Close();
				}
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0007B3EC File Offset: 0x000795EC
		internal static void smethod_135(Class113 class113_0, int int_0, int int_1)
		{
			if (class113_0.int_0 >= 0 && int_0 != -1 && int_1 != -1)
			{
				Class155 @class = new Class155();
				@class.int_0 = class113_0.int_0;
				Class83.smethod_134(@class, int_0, int_1);
				if (@class.double_1 != 0.0)
				{
					class113_0.double_1 = @class.double_1;
					class113_0.double_2 = @class.double_0;
					class113_0.double_2 = @class.double_3;
					class113_0.double_3 = @class.double_2;
					class113_0.bool_1 = true;
				}
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0007B46C File Offset: 0x0007966C
		internal static void smethod_136(int int_0, int int_1, int int_2, double double_0, double double_1, double double_2, double double_3)
		{
			if (int_1 != -1 && int_2 != -1 && File.Exists(frmLogin.class101_0.globalSettings_0.SettingDB))
			{
				SQLiteConnection sqliteConnection = new SQLiteConnection("Data Source=" + frmLogin.class101_0.globalSettings_0.SettingDB);
				sqliteConnection.Open();
				if (sqliteConnection.State == ConnectionState.Open)
				{
					SQLiteCommand sqliteCommand = new SQLiteCommand(string.Format("SELECT itemid FROM tnprices2 WHERE itemid = '{0}' AND bangid = '{1}' AND friendid = '{2}';", int_0, int_1, int_2), sqliteConnection);
					if (sqliteCommand.ExecuteScalar() == null)
					{
						sqliteCommand = new SQLiteCommand(string.Format("INSERT INTO tnprices2 ('bangid', 'friendid', 'spread', 'itemid', 'mytype', 'midprice', 'lowprice', 'highprice' ) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');", new object[]
						{
							int_1,
							int_2,
							double_1.ToString("0.00"),
							int_0,
							1,
							double_0.ToString("0.00"),
							double_2.ToString("0.00"),
							double_3.ToString("0.00")
						}), sqliteConnection);
					}
					else
					{
						sqliteCommand = new SQLiteCommand(string.Format("UPDATE tnprices2 SET spread = '{0}', midprice = '{1}' WHERE itemid = '{2}' AND bangid = '{3}' AND friendid = '{4}'", new object[]
						{
							double_1.ToString("0.00"),
							double_0.ToString("0.00"),
							int_0,
							int_1,
							int_2
						}), sqliteConnection);
					}
					sqliteCommand.ExecuteNonQuery();
					sqliteConnection.Close();
				}
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0007B5D4 File Offset: 0x000797D4
		internal static string smethod_137(string string_2, int int_0 = 1)
		{
			if (frmLogin.string_0 == "VN" && int_0 < 5)
			{
				StringBuilder stringBuilder = new StringBuilder(string_2);
				if (Class83.dictionary_1.Count == 0)
				{
					Class83.smethod_56();
				}
				for (int i = 0; i < stringBuilder.Length; i++)
				{
					char c = stringBuilder[i];
					if (Class83.dictionary_1.ContainsValue(c))
					{
						foreach (KeyValuePair<int, char> keyValuePair in Class83.dictionary_1)
						{
							if (keyValuePair.Value == c)
							{
								stringBuilder[i] = (char)keyValuePair.Key;
								break;
							}
						}
					}
				}
				return stringBuilder.ToString();
			}
			return string_2;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0007B6A0 File Offset: 0x000798A0
		internal static byte[] smethod_138(string string_2, int int_0)
		{
			if ((frmLogin.string_0 == "VN" || frmLogin.string_0 == "EN") && int_0 <= 4)
			{
				byte[] bytes = Encoding.ASCII.GetBytes(string_2);
				StringBuilder stringBuilder = new StringBuilder(string_2);
				if (Class83.dictionary_1.Count == 0)
				{
					Class83.smethod_56();
				}
				for (int i = 0; i < stringBuilder.Length; i++)
				{
					byte b = (byte)stringBuilder[i];
					if (Class83.dictionary_1.ContainsKey((int)b))
					{
						foreach (KeyValuePair<int, char> keyValuePair in Class83.dictionary_1)
						{
							if (keyValuePair.Key == (int)b)
							{
								bytes[i] = (byte)keyValuePair.Key;
								break;
							}
						}
					}
				}
				return bytes;
			}
			if (!(frmLogin.string_0 == "CN") && int_0 < 5)
			{
				return new byte[1];
			}
			return Encoding.GetEncoding("gb2312").GetBytes(string_2);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0007B7AC File Offset: 0x000799AC
		internal static string smethod_139(string string_2)
		{
			Encoding encoding = Encoding.GetEncoding("gb2312");
			Encoding utf = Encoding.UTF8;
			return Class83.smethod_141(string_2, encoding, utf);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0007B7D4 File Offset: 0x000799D4
		internal static string smethod_140(string string_2)
		{
			Encoding utf = Encoding.UTF8;
			Encoding encoding = Encoding.GetEncoding("gb2312");
			return Class83.smethod_141(string_2, utf, encoding);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0007B7FC File Offset: 0x000799FC
		internal static string smethod_141(string string_2, Encoding encoding_0, Encoding encoding_1)
		{
			byte[] bytes = encoding_0.GetBytes(string_2);
			byte[] bytes2 = Encoding.Convert(encoding_0, encoding_1, bytes);
			return encoding_1.GetString(bytes2);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0007B824 File Offset: 0x00079A24
		internal static string smethod_142(byte[] byte_4, int int_0, int int_1)
		{
			string text = Encoding.UTF7.GetString(byte_4, int_0, int_1);
			if (frmLogin.string_0 == "CN")
			{
				text = Encoding.GetEncoding("gb2312").GetString(byte_4);
				text = text.Replace("\0", "");
			}
			if (frmLogin.string_0 == "VN")
			{
				StringBuilder stringBuilder = new StringBuilder(text);
				if (Class83.dictionary_1.Count == 0 && frmLogin.string_0 == "VN")
				{
					Class83.smethod_56();
				}
				for (int i = 0; i < stringBuilder.Length; i++)
				{
					byte key = (byte)stringBuilder[i];
					if (Class83.dictionary_1.ContainsKey((int)key))
					{
						stringBuilder[i] = Class83.dictionary_1[(int)key];
					}
				}
				text = stringBuilder.ToString();
			}
			return text;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0007B8F0 File Offset: 0x00079AF0
		internal static int smethod_143(string string_2)
		{
			foreach (Class147 @class in frmLogin.class101_0.list_3)
			{
				if (@class.string_0 == string_2)
				{
					return @class.int_0;
				}
			}
			return -1;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0007B95C File Offset: 0x00079B5C
		internal static int smethod_144(string string_2)
		{
			foreach (Class150 @class in frmLogin.class101_0.list_6)
			{
				if (string.Compare(@class.string_0, string_2, true) == 0)
				{
					return @class.int_0;
				}
			}
			return 0;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0007B9C8 File Offset: 0x00079BC8
		internal static string smethod_145(int int_0)
		{
			string string_ = frmMain.String_203;
			foreach (Class150 @class in frmLogin.class101_0.list_6)
			{
				if (@class.int_0 == int_0)
				{
					string_ = @class.string_0;
					break;
				}
			}
			return string_;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0007BA34 File Offset: 0x00079C34
		internal static void smethod_146(Class58 class58_0)
		{
			if (class58_0.class120_0 != null && class58_0.class114_0 != null)
			{
				if (class58_0.class114_0.Menpai == Class57.Menpais.CAIBANG)
				{
					class58_0.class120_0.list_4[0].int_0 = 341;
					return;
				}
				if (class58_0.class114_0.Menpai == Class57.Menpais.DUONGMON)
				{
					class58_0.class120_0.list_4[0].int_0 = 2900;
					return;
				}
				if (class58_0.class114_0.Menpai == Class57.Menpais.THIEULAM)
				{
					class58_0.class120_0.list_4[0].int_0 = 281;
					return;
				}
				if (class58_0.class114_0.Menpai == Class57.Menpais.MINHGIAO)
				{
					class58_0.class120_0.list_4[0].int_0 = 311;
					return;
				}
				if (class58_0.class114_0.Menpai == Class57.Menpais.VODANG)
				{
					class58_0.class120_0.list_4[0].int_0 = 371;
					return;
				}
				if (class58_0.class114_0.Menpai == Class57.Menpais.NGAMI)
				{
					class58_0.class120_0.list_4[0].int_0 = 401;
					return;
				}
				if (class58_0.class114_0.Menpai == Class57.Menpais.TINHTUC)
				{
					class58_0.class120_0.list_4[0].int_0 = 431;
					return;
				}
				if (class58_0.class114_0.Menpai == Class57.Menpais.THIENLONG)
				{
					class58_0.class120_0.list_4[0].int_0 = 461;
					return;
				}
				if (class58_0.class114_0.Menpai == Class57.Menpais.THIENSON)
				{
					class58_0.class120_0.list_4[0].int_0 = 491;
					return;
				}
				if (class58_0.class114_0.Menpai == Class57.Menpais.TIEUDAO)
				{
					class58_0.class120_0.list_4[0].int_0 = 521;
					return;
				}
				if (class58_0.class114_0.Menpai == Class57.Menpais.MODUNG)
				{
					class58_0.class120_0.list_4[0].int_0 = 760;
					return;
				}
				if (class58_0.class114_0.Menpai == Class57.Menpais.QUYCOC)
				{
					class58_0.class120_0.list_4[0].int_0 = 3430;
					return;
				}
				if (class58_0.class114_0.Menpai == Class57.Menpais.DAOHOA)
				{
					class58_0.class120_0.list_4[0].int_0 = 3800;
					return;
				}
				if (class58_0.class114_0.Menpai == Class57.Menpais.TUYETTINH)
				{
					class58_0.class120_0.list_4[0].int_0 = 4515;
					return;
				}
				class58_0.class120_0.list_4[0].int_0 = 0;
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0007BCC0 File Offset: 0x00079EC0
		internal static int smethod_147(Class58 class58_0)
		{
			int result = -1;
			if (class58_0 != null && (class58_0.class59_0.int_2 == 4 || class58_0.class59_0.int_11 == 9 || class58_0.class59_0.int_11 == 11 || class58_0.class59_0.int_11 == 15 || class58_0.class59_0.int_11 == 16 || class58_0.class59_0.int_11 == 18 || class58_0.class59_0.int_11 == 20 || class58_0.autoSettings_0.cboxFixKetThanh))
			{
				result = 10;
			}
			return result;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000045D5 File Offset: 0x000027D5
		internal static double smethod_148()
		{
			return frmLogin.class101_0.globalSettings_0.Account.RemainMSeconds / 1000.0 / 60.0 / 60.0 / 24.0;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00004613 File Offset: 0x00002813
		internal static bool smethod_149(int int_0)
		{
			return 574 <= int_0 && int_0 <= 578;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0007BD4C File Offset: 0x00079F4C
		internal static int smethod_150(double double_0)
		{
			int result = 0;
			string text = double_0.ToString();
			if (text.Contains("."))
			{
				result = text.Split(new char[]
				{
					'.'
				})[1].Length;
			}
			return result;
		}

		// Token: 0x040002BA RID: 698
		internal static List<Class146> list_0 = new List<Class146>
		{
			new Class146
			{
				int_0 = 1,
				int_1 = 0,
				string_0 = "Bật/tắt auto acc này"
			},
			new Class146
			{
				int_0 = 2,
				int_1 = 0,
				string_0 = "Bật/tắt đánh quái acc này"
			},
			new Class146
			{
				int_0 = 3,
				int_1 = 0,
				string_0 = "Nga My buff máu"
			},
			new Class146
			{
				int_0 = 4,
				int_1 = 0,
				string_0 = "Vật phẩm"
			},
			new Class146
			{
				int_0 = 5,
				int_1 = 0,
				string_0 = "Buff hộ thể"
			},
			new Class146
			{
				int_0 = 6,
				int_1 = 0,
				string_0 = "SKill đánh quái"
			},
			new Class146
			{
				int_0 = 7,
				int_1 = 0,
				string_0 = "Đánh trả PK"
			},
			new Class146
			{
				int_0 = 8,
				int_1 = 0,
				string_0 = "Thu pet 5 phút"
			},
			new Class146
			{
				int_0 = 9,
				int_1 = 0,
				string_0 = "Hồi phục lên bãi"
			},
			new Class146
			{
				int_0 = 10,
				int_1 = 0,
				string_0 = "Lấy tọa độ train"
			},
			new Class146
			{
				int_0 = 11,
				int_1 = 0,
				string_0 = "Tàng Kinh Các"
			},
			new Class146
			{
				int_0 = 12,
				int_1 = 0,
				string_0 = "Mở Tàng Bảo Đồ"
			},
			new Class146
			{
				int_0 = 13,
				int_1 = 0,
				string_0 = "Đánh từng con"
			},
			new Class146
			{
				int_0 = 14,
				int_1 = 0,
				string_0 = "Đánh gom quái"
			},
			new Class146
			{
				int_0 = 15,
				int_1 = 0,
				string_0 = "Đánh theo key"
			},
			new Class146
			{
				int_0 = 16,
				int_1 = 0,
				string_0 = "Tuyên chiến mục tiêu"
			},
			new Class146
			{
				int_0 = 17,
				int_1 = 0,
				string_0 = "Ẩn game"
			},
			new Class146
			{
				int_0 = 18,
				int_1 = 0,
				string_0 = "Reset giờ chơi"
			},
			new Class146
			{
				int_0 = 19,
				int_1 = 0,
				string_0 = "Mời đội cả nhóm"
			},
			new Class146
			{
				int_0 = 20,
				int_1 = 0,
				string_0 = "Triệu tập party"
			},
			new Class146
			{
				int_0 = 21,
				int_1 = 0,
				string_0 = "Khai khoáng + hái dược"
			},
			new Class146
			{
				int_0 = 22,
				int_1 = 0,
				string_0 = "Trồng trọt"
			},
			new Class146
			{
				int_0 = 23,
				int_1 = 0,
				string_0 = "Ác tặc"
			},
			new Class146
			{
				int_0 = 24,
				int_1 = 0,
				string_0 = "Ác bá"
			},
			new Class146
			{
				int_0 = 25,
				int_1 = 0,
				string_0 = "Linh thú"
			},
			new Class146
			{
				int_0 = 26,
				int_1 = 0,
				string_0 = "Trừng Ác"
			},
			new Class146
			{
				int_0 = 27,
				int_1 = 0,
				string_0 = "Luyện Kim"
			},
			new Class146
			{
				int_0 = 28,
				int_1 = 0,
				string_0 = "Xây dựng"
			},
			new Class146
			{
				int_0 = 29,
				int_1 = 0,
				string_0 = "Tu dưỡng con"
			},
			new Class146
			{
				int_0 = 30,
				int_1 = 0,
				string_0 = "Tụ bảo bồn"
			},
			new Class146
			{
				int_0 = 31,
				int_1 = 0,
				string_0 = "Bách Hoa Duyên"
			},
			new Class146
			{
				int_0 = 32,
				int_1 = 0,
				string_0 = "Tuyên chiến nhanh"
			},
			new Class146
			{
				int_0 = 33,
				int_1 = 0,
				string_0 = "Cả pt dồn dame"
			},
			new Class146
			{
				int_0 = 34,
				int_1 = 0,
				string_0 = "Bật Q1"
			},
			new Class146
			{
				int_0 = 35,
				int_1 = 0,
				string_0 = "Bật Q2"
			},
			new Class146
			{
				int_0 = 36,
				int_1 = 0,
				string_0 = "Kêu tổ đội theo sau"
			},
			new Class146
			{
				int_0 = 37,
				int_1 = 0,
				string_0 = "Dừng tổ đội theo sau"
			},
			new Class146
			{
				int_0 = 38,
				int_1 = 0,
				string_0 = "Bật Q Dưa"
			},
			new Class146
			{
				int_0 = 39,
				int_1 = 0,
				string_0 = "Nhặt hộp dưa"
			},
			new Class146
			{
				int_0 = 40,
				int_1 = 0,
				string_0 = "Thu pet nhóm"
			},
			new Class146
			{
				int_0 = 41,
				int_1 = 0,
				string_0 = "Xuất pet nhóm"
			},
			new Class146
			{
				int_0 = 42,
				int_1 = 0,
				string_0 = "Tắt skill nhóm"
			},
			new Class146
			{
				int_0 = 43,
				int_1 = 0,
				string_0 = "Bật skill nhóm"
			},
			new Class146
			{
				int_0 = 44,
				int_1 = 0,
				string_0 = "Mở rương"
			}
		};

		// Token: 0x040002BB RID: 699
		internal static List<Class146> list_1 = new List<Class146>();

		// Token: 0x040002BC RID: 700
		internal static Dictionary<int, string> dictionary_0 = new Dictionary<int, string>();

		// Token: 0x040002BD RID: 701
		internal static bool bool_0 = false;

		// Token: 0x040002BE RID: 702
		internal static Class79 class79_0;

		// Token: 0x040002BF RID: 703
		internal static long long_0 = 270000L;

		// Token: 0x040002C0 RID: 704
		internal static Class81 class81_0 = null;

		// Token: 0x040002C1 RID: 705
		internal static DateTime dateTime_0;

		// Token: 0x040002C2 RID: 706
		internal static object object_0;

		// Token: 0x040002C3 RID: 707
		internal static long long_1;

		// Token: 0x040002C4 RID: 708
		private static string[] string_0 = new string[]
		{
			"Comic Sans MS",
			"Arial",
			"Times New Roman",
			"Georgia",
			"Verdana",
			"Geneva"
		};

		// Token: 0x040002C5 RID: 709
		private static FontStyle[] fontStyle_0;

		// Token: 0x040002C6 RID: 710
		private static HatchStyle[] hatchStyle_0;

		// Token: 0x040002C7 RID: 711
		internal static Dictionary<int, char> dictionary_1;

		// Token: 0x040002C8 RID: 712
		internal static readonly Random random_0;

		// Token: 0x040002C9 RID: 713
		internal static readonly object object_1;

		// Token: 0x040002CA RID: 714
		internal static byte[] byte_0;

		// Token: 0x040002CB RID: 715
		internal static byte[] byte_1;

		// Token: 0x040002CC RID: 716
		internal static byte[] byte_2;

		// Token: 0x040002CD RID: 717
		internal static byte[] byte_3;

		// Token: 0x040002CE RID: 718
		private static string string_1;

		// Token: 0x02000075 RID: 117
		internal enum Enum16
		{
			// Token: 0x040002D0 RID: 720
			const_0 = 1,
			// Token: 0x040002D1 RID: 721
			const_1 = -1,
			// Token: 0x040002D2 RID: 722
			const_2 = -2
		}

		// Token: 0x02000076 RID: 118
		internal sealed class Class84
		{
		}

		// Token: 0x02000077 RID: 119
		internal sealed class Class85
		{
			// Token: 0x1700004E RID: 78
			// (get) Token: 0x0600043B RID: 1083 RVA: 0x0007BD8C File Offset: 0x00079F8C
			internal string String_0
			{
				get
				{
					bool flag = false;
					try
					{
						return Class83.Class85.smethod_0(Class83.Class85.smethod_4() + Class83.Class85.smethod_7() + "MD5");
					}
					catch (Exception)
					{
						flag = true;
					}
					if (flag)
					{
						flag = false;
						try
						{
							string text = Environment.GetFolderPath(Environment.SpecialFolder.System);
							if (text.Length > 3)
							{
								text = text.Substring(0, 3);
							}
							if (text == "")
							{
								text = "C:\\";
							}
							StringBuilder stringBuilder = new StringBuilder(261);
							StringBuilder stringBuilder2 = new StringBuilder(261);
							uint num;
							uint num2;
							Class159.Enum21 @enum;
							if (!Class159.GetVolumeInformation(text, stringBuilder, stringBuilder.Capacity, out num, out num2, out @enum, stringBuilder2, stringBuilder2.Capacity))
							{
								Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
							}
							return Class83.Class85.smethod_0(num + frmLogin.string_17 + "BG-GB");
						}
						catch (Exception)
						{
							flag = true;
						}
					}
					return Class83.Class85.smethod_0(frmLogin.string_17 + "BG-GB");
				}
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x0007BE88 File Offset: 0x0007A088
			internal static string smethod_0(string string_0)
			{
				HashAlgorithm hashAlgorithm = new MD5CryptoServiceProvider();
				UTF8Encoding utf8Encoding = new UTF8Encoding();
				return BitConverter.ToString(hashAlgorithm.ComputeHash(utf8Encoding.GetBytes(string_0))).Replace("-", "").ToUpper();
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x0007BEC8 File Offset: 0x0007A0C8
			internal static string smethod_1(string string_0, string string_1, string string_2)
			{
				string text = "";
				foreach (ManagementBaseObject managementBaseObject in new ManagementClass(string_0).GetInstances())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					if (managementObject[string_2].ToString() == "True" && text == string.Empty)
					{
						try
						{
							text = managementObject[string_1].ToString();
							break;
						}
						catch (Exception)
						{
						}
					}
				}
				return text;
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x0007BF64 File Offset: 0x0007A164
			internal static string smethod_2(string string_0, string string_1)
			{
				string text = "";
				foreach (ManagementBaseObject managementBaseObject in new ManagementClass(string_0).GetInstances())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					if (text == string.Empty)
					{
						try
						{
							text = managementObject[string_1].ToString();
							break;
						}
						catch (Exception)
						{
						}
					}
				}
				return text;
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x0007BFE8 File Offset: 0x0007A1E8
			private static string smethod_3()
			{
				string text = Class83.Class85.smethod_2("Win32_Processor", "UniqueId");
				if (text == string.Empty)
				{
					text = Class83.Class85.smethod_2("Win32_Processor", "ProcessorId");
					if (text == string.Empty)
					{
						text = Class83.Class85.smethod_2("Win32_Processor", "Name");
						if (text == string.Empty)
						{
							text = Class83.Class85.smethod_2("Win32_Processor", "Manufacturer");
						}
						text += Class83.Class85.smethod_2("Win32_Processor", "MaxClockSpeed");
					}
				}
				return text;
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x0007C074 File Offset: 0x0007A274
			private static string smethod_4()
			{
				return string.Concat(new string[]
				{
					Class83.Class85.smethod_2("Win32_BIOS", "Manufacturer"),
					Class83.Class85.smethod_2("Win32_BIOS", "SMBIOSBIOSVersion"),
					Class83.Class85.smethod_2("Win32_BIOS", "IdentificationCode"),
					Class83.Class85.smethod_2("Win32_BIOS", "SerialNumber"),
					Class83.Class85.smethod_2("Win32_BIOS", "ReleaseDate"),
					Class83.Class85.smethod_2("Win32_BIOS", "Version")
				});
			}

			// Token: 0x06000441 RID: 1089 RVA: 0x0007C0F8 File Offset: 0x0007A2F8
			private static string smethod_5()
			{
				return Class83.Class85.smethod_2("Win32_DiskDrive", "Model") + Class83.Class85.smethod_2("Win32_DiskDrive", "Manufacturer") + Class83.Class85.smethod_2("Win32_DiskDrive", "Signature") + Class83.Class85.smethod_2("Win32_DiskDrive", "TotalHeads");
			}

			// Token: 0x06000442 RID: 1090 RVA: 0x0007C148 File Offset: 0x0007A348
			private static string smethod_6()
			{
				return Class83.Class85.smethod_2("Win32_BaseBoard", "Model") + Class83.Class85.smethod_2("Win32_BaseBoard", "Manufacturer") + Class83.Class85.smethod_2("Win32_BaseBoard", "Name") + Class83.Class85.smethod_2("Win32_BaseBoard", "SerialNumber");
			}

			// Token: 0x06000443 RID: 1091 RVA: 0x00004628 File Offset: 0x00002828
			private static string smethod_7()
			{
				return Class83.Class85.smethod_2("Win32_VideoController", "DriverVersion") + Class83.Class85.smethod_2("Win32_VideoController", "Name");
			}

			// Token: 0x06000444 RID: 1092 RVA: 0x0000464D File Offset: 0x0000284D
			private static string smethod_8()
			{
				return Class83.Class85.smethod_1("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
			}
		}

		// Token: 0x02000079 RID: 121
		[CompilerGenerated]
		private sealed class Class86
		{
			// Token: 0x06000449 RID: 1097 RVA: 0x00004699 File Offset: 0x00002899
			internal void method_0()
			{
				Class83.smethod_47(this.string_0, this.string_1, this.int_0, this.object_0);
			}

			// Token: 0x040002D5 RID: 725
			public string string_0;

			// Token: 0x040002D6 RID: 726
			public string string_1;

			// Token: 0x040002D7 RID: 727
			public int int_0;

			// Token: 0x040002D8 RID: 728
			public object[] object_0;
		}

		// Token: 0x0200007A RID: 122
		[CompilerGenerated]
		private sealed class Class87
		{
			// Token: 0x0600044B RID: 1099 RVA: 0x0007C198 File Offset: 0x0007A398
			internal void method_0()
			{
				if (this.class58_0 != null)
				{
					if (frmLogin.stopwatch_0.ElapsedMilliseconds - this.class58_0.class114_0.long_54 >= (long)this.int_0)
					{
						this.class58_0.class114_0.long_54 = 0L;
					}
					if (this.class58_0.class114_0.long_54 == 0L)
					{
						frmMain.frmMain_0.notifyIcon_0.ShowBalloonTip(this.int_0, this.class58_0.class114_0.string_3 + ": " + this.string_0, this.string_1, ToolTipIcon.Info);
						this.class58_0.class114_0.long_54 = frmLogin.stopwatch_0.ElapsedMilliseconds;
						return;
					}
				}
				else
				{
					frmMain.frmMain_0.notifyIcon_0.ShowBalloonTip(this.int_0, this.string_0, this.string_1, ToolTipIcon.Info);
				}
			}

			// Token: 0x040002D9 RID: 729
			public Class58 class58_0;

			// Token: 0x040002DA RID: 730
			public int int_0;

			// Token: 0x040002DB RID: 731
			public string string_0;

			// Token: 0x040002DC RID: 732
			public string string_1;
		}

		// Token: 0x0200007B RID: 123
		[CompilerGenerated]
		private sealed class Class88
		{
			// Token: 0x0600044D RID: 1101 RVA: 0x000046B8 File Offset: 0x000028B8
			internal void method_0()
			{
				frmMain.frmMain_0.method_175(this.class58_0);
			}

			// Token: 0x040002DD RID: 733
			public Class58 class58_0;
		}
	}
}
