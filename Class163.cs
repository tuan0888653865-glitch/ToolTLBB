using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using SmartBot;

namespace ns0
{
	// Token: 0x020000DA RID: 218
	internal sealed class Class163
	{
		// Token: 0x06000848 RID: 2120 RVA: 0x0009D38C File Offset: 0x0009B58C
		internal static void smethod_0(Class58 class58_0, string string_0, string string_1 = "")
		{
			if (string_1 != "" || (class58_0 != null && class58_0.autoSettings_0 != null))
			{
				string text = string_1;
				if (text == "" && class58_0 != null)
				{
					text = class58_0.autoSettings_0.method_2();
				}
				string string_2 = "temptable";
				string string_3 = Application.StartupPath + "\\" + frmLogin.class101_0.globalSettings_0.SettingDB;
				if (File.Exists(string_0))
				{
					try
					{
						File.Delete(string_0);
					}
					catch (Exception)
					{
					}
				}
				if (Class163.smethod_4(string_3, text, string_0, string_2))
				{
					if (string_1 != "")
					{
						Class83.smethod_46("Đã lưu thiết lập của nhân vật ID={0} vào tập tin {1}", "Lưu thiết lập", 10000, new object[]
						{
							string_1,
							string_0
						});
						return;
					}
					if (class58_0 != null && class58_0.class114_0 != null && class58_0.class114_0.string_3 != "")
					{
						Class83.smethod_46("Đã lưu thiết lập của nhân vật {0} vào tập tin {1}", "Lưu thiết lập", 10000, new object[]
						{
							class58_0.class114_0.string_3,
							string_0
						});
					}
				}
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0009D4A8 File Offset: 0x0009B6A8
		internal static void smethod_1(Class58 class58_0, string string_0, bool bool_0 = true, string string_1 = "")
		{
			if ((class58_0 != null && class58_0.autoSettings_0 != null) || string_1 != "")
			{
				string text = string_1;
				if (text == "")
				{
					text = class58_0.autoSettings_0.method_2();
				}
				string string_2 = "temptable";
				string string_3 = Application.StartupPath + "\\" + frmLogin.class101_0.globalSettings_0.SettingDB;
				if (Class163.smethod_4(string_0, string_2, string_3, text))
				{
					if (class58_0 != null && class58_0.autoSettings_0 != null)
					{
						Class163.smethod_10(class58_0, "");
						return;
					}
					if (string_1 != "")
					{
						Class163.smethod_10(null, string_1);
					}
				}
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0009D544 File Offset: 0x0009B744
		internal static void smethod_2(Class58 class58_0, string string_0 = "")
		{
			if ((class58_0 != null && class58_0.autoSettings_0 != null) || string_0 != "")
			{
				string text = string_0;
				if (text == "")
				{
					text = class58_0.autoSettings_0.method_2();
				}
				Class163.smethod_3(text);
				Class163.smethod_10(class58_0, string_0);
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0009D594 File Offset: 0x0009B794
		internal static bool smethod_3(string string_0)
		{
			string settingDB = frmLogin.class101_0.globalSettings_0.SettingDB;
			SQLiteConnection sqliteConnection = null;
			bool result = true;
			try
			{
				if (!File.Exists(settingDB))
				{
					return true;
				}
				if (File.Exists(settingDB))
				{
					sqliteConnection = new SQLiteConnection("Data Source=" + settingDB);
					sqliteConnection.Open();
					if (sqliteConnection != null && sqliteConnection.State == ConnectionState.Open)
					{
						string commandText = string.Format("DROP TABLE '{0}'", string_0);
						try
						{
							new SQLiteCommand(commandText, sqliteConnection).ExecuteNonQuery();
						}
						catch (Exception)
						{
							result = false;
						}
					}
				}
			}
			catch (Exception)
			{
				result = false;
			}
			finally
			{
				if (sqliteConnection != null && sqliteConnection.State == ConnectionState.Open)
				{
					sqliteConnection.Close();
				}
			}
			return result;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0009D654 File Offset: 0x0009B854
		internal static bool smethod_4(string string_0, string string_1, string string_2, string string_3)
		{
			SQLiteConnection sqliteConnection = null;
			bool result = true;
			try
			{
				if (!File.Exists(string_0))
				{
					return false;
				}
				if (string_0 != string_2 && !File.Exists(string_2))
				{
					SQLiteConnection.CreateFile(string_2);
				}
				if (File.Exists(string_2) && string_3 != "" && string_1 != "")
				{
					sqliteConnection = new SQLiteConnection("Data Source=" + string_2);
					sqliteConnection.Open();
					if (sqliteConnection != null && sqliteConnection.State == ConnectionState.Open)
					{
						string commandText = string.Format("DROP TABLE IF EXISTS '{0}'", string_3);
						try
						{
							new SQLiteCommand(commandText, sqliteConnection).ExecuteNonQuery();
						}
						catch (Exception)
						{
						}
						if (Class161.smethod_0(string_1, false, string_0))
						{
							string text = Class161.smethod_5(string_3);
							if (string_0 != string_2)
							{
								commandText = string.Format("ATTACH DATABASE '{0}' AS 'source'; {1} INSERT INTO '{2}' SELECT * FROM source.'{3}';", new object[]
								{
									string_0,
									text,
									string_3,
									string_1
								});
								new SQLiteCommand(commandText, sqliteConnection).ExecuteNonQuery();
							}
							else
							{
								new SQLiteCommand(text, sqliteConnection).ExecuteNonQuery();
								commandText = string.Format("INSERT INTO '{0}' SELECT * FROM '{1}';", string_3, string_1);
								new SQLiteCommand(commandText, sqliteConnection).ExecuteNonQuery();
							}
						}
						else
						{
							Class161.smethod_0(string_3, true, string_2);
						}
					}
				}
			}
			catch (Exception)
			{
				result = false;
			}
			finally
			{
				if (sqliteConnection != null && sqliteConnection.State == ConnectionState.Open)
				{
					sqliteConnection.Close();
				}
			}
			return result;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0009D7E8 File Offset: 0x0009B9E8
		internal static void smethod_5(Class58 class58_0, string string_0 = "")
		{
			if ((class58_0 != null && class58_0.autoSettings_0 != null) || string_0 != "")
			{
				string text = string_0;
				if (text == "")
				{
					text = class58_0.autoSettings_0.method_2();
				}
				if (class58_0 != null && class58_0.autoSettings_0 != null)
				{
					if (frmLogin.class101_0.class210_0.Count > 1)
					{
						for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
						{
							string text2 = frmLogin.class101_0.class210_0[i].autoSettings_0.method_2();
							if (text2 != text && Class163.smethod_4(frmLogin.class101_0.globalSettings_0.SettingDB, text, frmLogin.class101_0.globalSettings_0.SettingDB, text2))
							{
								Class163.smethod_10(frmLogin.class101_0.class210_0[i], "");
							}
						}
						return;
					}
				}
				else if (string_0 != "" && frmGLogin.frmGLogin_0 != null && frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count > 1)
				{
					try
					{
						for (int j = 0; j < frmLogin.class101_0.globalSettings_0.ListLoginProfile.Count; j++)
						{
							GClass2 gclass = frmLogin.class101_0.globalSettings_0.ListLoginProfile[j];
							if (gclass.databaseIDStr != "" && gclass.databaseIDStr != string_0)
							{
								Class163.smethod_4(frmLogin.class101_0.globalSettings_0.SettingDB, text, frmLogin.class101_0.globalSettings_0.SettingDB, gclass.databaseIDStr);
								if (gclass.RefAutoAccount != null && gclass.RefAutoAccount.class114_0 != null && gclass.RefAutoAccount.class75_0.Boolean_0)
								{
									Class163.smethod_10(gclass.RefAutoAccount, "");
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000097B6 File Offset: 0x000079B6
		internal static void smethod_6(Class58 class58_0, string string_0 = "")
		{
			if (MessageBox.Show("Áp dụng thiết lập từ nhân vật này lên tất cả các nhân vật đang mở trong auto sẽ làm mất các thiết lập đang có sẵn của các nhân vật kia, bạn có đồng ý không?", "Copy thiết lập", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Class163.smethod_5(class58_0, string_0);
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0009D9E4 File Offset: 0x0009BBE4
		internal static void smethod_7(List<Class58> list_0, List<string> list_1 = null)
		{
			if (((list_0 != null && list_0.Count > 0) || (list_1 != null && list_1.Count > 0)) && MessageBox.Show("Xóa thiết lập về mặc định sẽ làm mất các thiết lập đang có sẵn, bạn có đồng ý không?", "Xóa thiết lập", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (list_0 != null && list_0.Count > 0)
				{
					using (List<Class58>.Enumerator enumerator = list_0.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Class58 @class = enumerator.Current;
							if (@class != null && @class.class114_0.int_11 != 0)
							{
								Class163.smethod_2(@class, "");
							}
						}
						return;
					}
				}
				if (list_1 != null && list_1.Count > 0)
				{
					foreach (string text in list_1)
					{
						if (text != "")
						{
							Class163.smethod_2(null, text);
						}
					}
				}
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0009DAE0 File Offset: 0x0009BCE0
		internal static void smethod_8(List<Class58> list_0, List<string> list_1 = null)
		{
			if (((list_0 != null && list_0.Count > 0) || (list_1 != null && list_1.Count > 0)) && MessageBox.Show("Nạp thiết lập sẽ làm mất các thiết lập đang có sẵn trên các nhân vật này, bạn có đồng ý không?", "Nạp thiết lập", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Title = "Nạp thiết lập auto từ tập tin";
				openFileDialog.Filter = "GAuto Settings | *.dat";
				openFileDialog.DefaultExt = "dat";
				string text = Application.StartupPath + frmLogin.string_18;
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				openFileDialog.InitialDirectory = text;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					if (list_0 != null && list_0.Count > 0)
					{
						using (List<Class58>.Enumerator enumerator = list_0.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Class58 @class = enumerator.Current;
								if (@class != null && @class.class114_0.int_11 != 0)
								{
									Class163.smethod_1(@class, openFileDialog.FileName, true, "");
								}
							}
							return;
						}
					}
					if (list_1 != null && list_1.Count > 0)
					{
						foreach (string text2 in list_1)
						{
							if (text2 != "")
							{
								Class163.smethod_1(null, openFileDialog.FileName, true, text2);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0009DC48 File Offset: 0x0009BE48
		internal static void smethod_9(Class58 class58_0, string string_0 = "")
		{
			if (class58_0 != null || string_0 != "")
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Title = "Lưu thiết lập auto thành tập tin";
				saveFileDialog.Filter = "GAuto Settings | *.dat";
				saveFileDialog.DefaultExt = "dat";
				string text = Application.StartupPath + frmLogin.string_18;
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				saveFileDialog.InitialDirectory = text;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					Class163.smethod_0(class58_0, saveFileDialog.FileName, string_0);
				}
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0009DCC8 File Offset: 0x0009BEC8
		internal static void smethod_10(Class58 class58_0, string string_0 = "")
		{
			Class163.Class164 @class = new Class163.Class164();
			@class.class58_0 = class58_0;
			if ((@class.class58_0 == null || string_0 != "") && frmLogin.class101_0.class210_0.Count > 0)
			{
				try
				{
					for (int i = frmLogin.class101_0.class210_0.Count - 1; i >= 0; i--)
					{
						if (frmLogin.class101_0.class210_0[i] != null && frmLogin.class101_0.class210_0[i].class114_0 != null && frmLogin.class101_0.class210_0[i].class114_0.DatabaseIDStr == string_0)
						{
							@class.class58_0 = frmLogin.class101_0.class210_0[i];
							break;
						}
					}
				}
				catch (Exception)
				{
				}
			}
			if (@class.class58_0 != null)
			{
				@class.class58_0.autoSettings_0 = new AutoSettings();
				Class161.smethod_7(@class.class58_0);
				@class.class58_0.autoSettings_0.AllInformationLoaded = true;
				@class.class58_0.class116_0.Boolean_0 = true;
				@class.class58_0.method_310();
				if (@class.class58_0 == frmLogin.class101_0.CurrentAuto)
				{
					if (frmMain.frmMain_0.InvokeRequired)
					{
						frmMain.frmMain_0.Invoke(new MethodInvoker(@class.method_0));
						return;
					}
					frmMain.frmMain_0.method_21(@class.class58_0, 0);
				}
			}
		}

		// Token: 0x020000DB RID: 219
		[CompilerGenerated]
		private sealed class Class164
		{
			// Token: 0x06000854 RID: 2132 RVA: 0x000097D4 File Offset: 0x000079D4
			internal void method_0()
			{
				frmMain.frmMain_0.method_21(this.class58_0, 0);
			}

			// Token: 0x04000AFC RID: 2812
			public Class58 class58_0;
		}
	}
}
