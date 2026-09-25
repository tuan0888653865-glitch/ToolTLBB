using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x020000DD RID: 221
	internal sealed class Class166
	{
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x0009DE40 File Offset: 0x0009C040
		internal static string String_0
		{
			get
			{
				string text = "";
				if (Class166.list_0.Count > 0)
				{
					for (int i = Class166.list_0.Count - 1; i >= 0; i--)
					{
						text = string.Concat(new object[]
						{
							text,
							Class166.list_0[i].int_2,
							":",
							Class83.smethod_72(Class166.list_0[i].string_1, 0),
							":"
						});
					}
				}
				return text;
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000024E9 File Offset: 0x000006E9
		internal static void smethod_0()
		{
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0009DECC File Offset: 0x0009C0CC
		internal static void smethod_1()
		{
			string text = Class83.smethod_98(5);
			string str = frmLogin.random_0.Next().ToString("0");
			string text2 = HttpUtility.UrlEncode(Class83.smethod_39(Class83.smethod_71(frmLogin.class101_0.globalSettings_0.AESKeysets[1].secureString_2) + str, 1));
			string text3 = HttpUtility.UrlEncode(Class83.smethod_39(text + "," + frmLogin.class101_0.globalSettings_0.GameID, 1));
			string text4 = Class83.smethod_125("http://server1.gameauto.net/payment/auto_tkservers.php", string.Concat(new string[]
			{
				"chicka=",
				frmLogin.string_11,
				"&f541=",
				text2,
				"&k54=",
				text3
			}), "POST", null, true);
			if (text4 != "" && !text4.Contains(frmLogin.class101_0.globalSettings_0.LoadWebErrorMessage) && text4.StartsWith("data="))
			{
				try
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					text4 = HttpUtility.UrlDecode(text4.Replace("data=", ""));
					text4 = Class83.smethod_41(text4, 1);
					dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(text4);
					if (dictionary.ContainsKey("dsign"))
					{
						string b = dictionary["dsign"].ToString();
						string str2 = dictionary["salt"].ToString();
						string value = "";
						if (dictionary.ContainsKey("allservers"))
						{
							value = dictionary["allservers"].ToString();
						}
						if (Class83.smethod_121(frmLogin.class101_0.globalSettings_0.GameID, str2 + text) == b)
						{
							Dictionary<string, object>[] array = JsonConvert.DeserializeObject<Dictionary<string, object>[]>(value);
							string a = "fwd";
							string a2 = "0";
							if (dictionary.ContainsKey("tkmode"))
							{
								a = dictionary["tkmode"].ToString();
							}
							if (dictionary.ContainsKey("sshsv"))
							{
								dictionary["sshsv"].ToString();
							}
							if (dictionary.ContainsKey("sshu"))
							{
								dictionary["sshu"].ToString();
							}
							if (dictionary.ContainsKey("sshp"))
							{
								dictionary["sshp"].ToString();
							}
							if (dictionary.ContainsKey("sshinject"))
							{
								a2 = dictionary["sshinject"].ToString();
							}
							if (array.Length != 0)
							{
								Class166.Class167 @class = new Class166.Class167();
								@class.string_0 = "";
								if (Monitor.TryEnter(Class166.object_0, 5000))
								{
									Dictionary<string, object>[] array2 = array;
									for (int i = 0; i < array2.Length; i++)
									{
										Class165 item = JsonConvert.DeserializeObject<Class165>(JsonConvert.SerializeObject(array2[i]));
										Class166.list_0.Add(item);
									}
								}
								if (Class166.list_0.Count > 0)
								{
									Class68.smethod_5(true);
									using (List<Class165>.Enumerator enumerator = Class166.list_0.GetEnumerator())
									{
										while (enumerator.MoveNext())
										{
											Class166.Class168 class2 = new Class166.Class168();
											class2.class167_0 = @class;
											class2.class165_0 = enumerator.Current;
											try
											{
												if (a == "fwd")
												{
													Class166.int_0 = 1;
													new Thread(new ThreadStart(class2.method_0)).Start();
												}
												else
												{
													if (a2 == "0")
													{
														Class166.int_0 = 0;
													}
													new Thread(new ThreadStart(Class166.<>c.<>c_0.method_0)).Start();
												}
											}
											catch (Exception)
											{
											}
										}
									}
								}
								if (@class.string_0 != "")
								{
									Class83.smethod_46("Tạo kết nối lên Tình Kiếm lỗi.\nBạn có thể bỏ qua nếu bạn không xài Tình Kiếm.\n" + @class.string_0, "Lỗi", 10000, new object[0]);
								}
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x04000B02 RID: 2818
		internal static List<Class165> list_0 = new List<Class165>();

		// Token: 0x04000B03 RID: 2819
		internal static int int_0 = 1;

		// Token: 0x04000B04 RID: 2820
		private static object object_0 = new object();

		// Token: 0x020000DE RID: 222
		[CompilerGenerated]
		private sealed class Class167
		{
			// Token: 0x04000B05 RID: 2821
			public string string_0;
		}

		// Token: 0x020000DF RID: 223
		[CompilerGenerated]
		private sealed class Class168
		{
			// Token: 0x0600085D RID: 2141 RVA: 0x0009E314 File Offset: 0x0009C514
			internal void method_0()
			{
				try
				{
					new Class169().method_0(new IPEndPoint(IPAddress.Parse("0.0.0.0"), this.class165_0.int_0), new IPEndPoint(IPAddress.Parse(this.class165_0.string_0), this.class165_0.int_1));
				}
				catch (Exception)
				{
					this.class167_0.string_0 = "Lỗi tạo cầu tham lương";
				}
			}

			// Token: 0x04000B06 RID: 2822
			public Class165 class165_0;

			// Token: 0x04000B07 RID: 2823
			public Class166.Class167 class167_0;
		}
	}
}
