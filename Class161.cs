using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using System.Text;
using SmartBot;

namespace ns0
{
	// Token: 0x020000D8 RID: 216
	internal sealed class Class161
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x0009B2B8 File Offset: 0x000994B8
		internal static bool smethod_0(string string_0, bool bool_0 = true, string string_1 = "")
		{
			bool result = false;
			if (string_1 == "")
			{
				string_1 = frmLogin.class101_0.globalSettings_0.SettingDB;
			}
			if (!File.Exists(string_1))
			{
				SQLiteConnection.CreateFile(string_1);
			}
			SQLiteConnection sqliteConnection = null;
			try
			{
				if (File.Exists(string_1))
				{
					sqliteConnection = new SQLiteConnection("Data Source=" + string_1);
					sqliteConnection.Open();
				}
				if (sqliteConnection != null && sqliteConnection.State == ConnectionState.Open)
				{
					SQLiteDataReader reader = new SQLiteCommand(string.Format("SELECT name FROM sqlite_master WHERE type='table' AND name='{0}';", string_0), sqliteConnection).ExecuteReader();
					DataTable dataTable = new DataTable();
					dataTable.Load(reader);
					if (dataTable.Rows.Count > 0)
					{
						result = true;
					}
					else
					{
						if (bool_0)
						{
							object object_ = frmLogin.object_7;
							lock (object_)
							{
								try
								{
									new SQLiteCommand(Class161.smethod_5(string_0), sqliteConnection).ExecuteNonQuery();
									result = true;
								}
								catch (Exception)
								{
									sqliteConnection.Close();
									result = false;
								}
								goto IL_CE;
							}
						}
						result = false;
					}
				}
				IL_CE:;
			}
			catch (Exception)
			{
			}
			finally
			{
				if (sqliteConnection.State == ConnectionState.Open)
				{
					sqliteConnection.Close();
				}
			}
			return result;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0009B3E0 File Offset: 0x000995E0
		internal static void smethod_1(string string_0, bool bool_0, string string_1, Class162 class162_0)
		{
			if (string.IsNullOrEmpty(string_0))
			{
				string_0 = frmLogin.class101_0.globalSettings_0.SettingTable;
			}
			SQLiteConnection sqliteConnection = null;
			try
			{
				if (File.Exists(frmLogin.class101_0.globalSettings_0.SettingDB))
				{
					sqliteConnection = new SQLiteConnection("Data Source=" + frmLogin.class101_0.globalSettings_0.SettingDB);
					sqliteConnection.Open();
				}
				if (sqliteConnection != null && sqliteConnection.State == ConnectionState.Open && Class161.smethod_0(string_0, true, ""))
				{
					if (bool_0)
					{
						SQLiteCommand sqliteCommand = new SQLiteCommand(string.Format("SELECT key FROM '{0}' WHERE key = '{1}';", string_0, string_1), sqliteConnection);
						SQLiteDataReader reader = sqliteCommand.ExecuteReader();
						DataTable dataTable = new DataTable();
						dataTable.Load(reader);
						if (class162_0.string_2.StartsWith("0") && class162_0.string_2.Length > 1)
						{
							class162_0.string_2 = "\\" + class162_0.string_2;
						}
						if (class162_0.string_2.Contains("'"))
						{
							class162_0.string_2 = class162_0.string_2.Replace("'", "''");
						}
						string commandText = string.Format("UPDATE '{0}' SET value = '{2}', desc = '{3}', param1 = '{4}', param2 = '{5}', param3 = '{6}', param4 = '{7}' WHERE key = '{1}';", new object[]
						{
							string_0,
							string_1,
							class162_0.string_2,
							class162_0.string_1,
							class162_0.list_0[0],
							class162_0.list_0[1],
							class162_0.list_0[2],
							class162_0.list_0[3]
						});
						if (dataTable.Rows.Count == 0)
						{
							commandText = string.Format("INSERT INTO '{0}' (key, value, desc, param1, param2, param3, param4) VALUES ('{1}','{2}','{3}','{4}','{5}','{6}','{7}');", new object[]
							{
								string_0,
								string_1,
								class162_0.string_2,
								class162_0.string_1,
								class162_0.list_0[0],
								class162_0.list_0[1],
								class162_0.list_0[2],
								class162_0.list_0[3]
							});
						}
						sqliteCommand = new SQLiteCommand(commandText, sqliteConnection);
						object object_ = frmLogin.object_6;
						lock (object_)
						{
							sqliteCommand.ExecuteNonQuery();
							goto IL_267;
						}
					}
					if (!bool_0)
					{
						SQLiteDataReader reader2 = new SQLiteCommand(string.Format("SELECT * FROM '{0}' WHERE key = '{1}';", string_0, string_1), sqliteConnection).ExecuteReader();
						DataTable dataTable2 = new DataTable();
						dataTable2.Load(reader2);
						if (dataTable2.Rows.Count > 0)
						{
							DataRow dataRow_ = dataTable2.Rows[0];
							Class161.smethod_2(class162_0, dataRow_);
						}
					}
				}
				IL_267:;
			}
			catch (Exception)
			{
			}
			finally
			{
				if (sqliteConnection.State == ConnectionState.Open)
				{
					sqliteConnection.Close();
				}
			}
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0009B6B8 File Offset: 0x000998B8
		private static void smethod_2(Class162 class162_0, DataRow dataRow_0)
		{
			if (dataRow_0 != null && dataRow_0.ItemArray.Length >= 7 && class162_0 != null)
			{
				class162_0.string_0 = ((!string.IsNullOrEmpty(dataRow_0["key"].ToString())) ? dataRow_0["key"].ToString() : "");
				class162_0.string_2 = ((!string.IsNullOrEmpty(dataRow_0["value"].ToString())) ? dataRow_0["value"].ToString() : "");
				class162_0.string_1 = ((!string.IsNullOrEmpty(dataRow_0["desc"].ToString())) ? dataRow_0["desc"].ToString() : "");
				for (int i = 1; i <= 4; i++)
				{
					class162_0.list_0[i - 1] = ((!string.IsNullOrEmpty(dataRow_0["param" + i.ToString()].ToString())) ? dataRow_0["param" + i.ToString()].ToString() : "");
				}
			}
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0000979F File Offset: 0x0000799F
		internal static string smethod_3(int int_0)
		{
			if (int_0 != 0)
			{
				return int_0.ToString("X8");
			}
			return "";
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0009B7DC File Offset: 0x000999DC
		internal static void smethod_4(string string_0, string string_1, string string_2, string string_3 = "", params string[] string_4)
		{
			if (string_0 != "")
			{
				Class162 @class = new Class162();
				@class.string_0 = string_1;
				@class.string_2 = string_2;
				@class.string_1 = string_3;
				if (string_4 != null && string_4.Length != 0)
				{
					int num = 0;
					foreach (string value in string_4)
					{
						@class.list_0[num] = value;
						num++;
					}
				}
				Class161.smethod_1(string_0, true, @class.string_0, @class);
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0009B854 File Offset: 0x00099A54
		internal static string smethod_5(string string_0)
		{
			string result = string.Format("CREATE TABLE IF NOT EXISTS '{0}' (key STRING PRIMARY KEY UNIQUE NOT NULL, value STRING, desc STRING, param1 STRING, param2 STRING, param3 STRING, param4 STRING);", string_0);
			if (string_0 == "tnprices2")
			{
				result = "CREATE TABLE IF NOT EXISTS tnprices2 (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, bangid INTEGER NOT NULL, friendid INTEGER NOT NULL, spread DOUBLE NOT NULL, itemid INTEGER, mytype INTEGER DEFAULT (0), midprice DOUBLE DEFAULT (0), lowprice DOUBLE DEFAULT (0), highprice DOUBLE DEFAULT (0));";
			}
			return result;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0009B884 File Offset: 0x00099A84
		internal static void smethod_6()
		{
			string text = "gauto";
			if (!string.IsNullOrEmpty(text) && Class161.smethod_0(text, true, ""))
			{
				SQLiteConnection sqliteConnection = null;
				try
				{
					if (File.Exists(frmLogin.class101_0.globalSettings_0.SettingDB))
					{
						sqliteConnection = new SQLiteConnection("Data Source=" + frmLogin.class101_0.globalSettings_0.SettingDB);
						sqliteConnection.Open();
					}
					if (sqliteConnection.State == ConnectionState.Open)
					{
						SQLiteDataReader reader = new SQLiteCommand(string.Format("SELECT * FROM '{0}';", text), sqliteConnection).ExecuteReader();
						DataTable dataTable = new DataTable();
						dataTable.Load(reader);
						if (dataTable.Rows.Count > 0)
						{
							Type typeFromHandle = typeof(GlobalSettings);
							foreach (DataRow dataRow_ in dataTable.Rows)
							{
								Class162 @class = new Class162();
								Class161.smethod_2(@class, dataRow_);
								PropertyInfo property = typeFromHandle.GetProperty(@class.string_0);
								if (@class.string_2.StartsWith("\\"))
								{
									@class.string_2 = @class.string_2.Remove(0, 1);
								}
								if (property != null)
								{
									Type propertyType = property.PropertyType;
									if (property.PropertyType == typeof(Class210<string>))
									{
										string[] array = @class.string_2.Split(new char[]
										{
											'|'
										});
										Class210<string> class2 = new Class210<string>();
										if (array.Length != 0)
										{
											for (int i = 0; i < array.Length; i++)
											{
												if (!string.IsNullOrEmpty(array[i]))
												{
													class2.method_1(array[i]);
												}
											}
											property.SetValue(frmLogin.class101_0.globalSettings_0, class2, null);
											if (@class.string_0 == "ItemTuHuyList")
											{
												frmLogin.class101_0.globalSettings_0.ItemTuHuyList.Event_0 += frmLogin.frmLogin_0.method_22;
												frmLogin.class101_0.globalSettings_0.ItemTuHuyList.Event_1 += frmLogin.frmLogin_0.method_21;
											}
											else if (@class.string_0 == "ItemBanList")
											{
												frmLogin.class101_0.globalSettings_0.ItemBanList.Event_0 += frmLogin.frmLogin_0.method_16;
												frmLogin.class101_0.globalSettings_0.ItemBanList.Event_1 += frmLogin.frmLogin_0.method_13;
											}
											else if (@class.string_0 == "ListItemNhat")
											{
												frmLogin.class101_0.globalSettings_0.ListItemNhat.Event_0 += frmLogin.frmLogin_0.method_24;
												frmLogin.class101_0.globalSettings_0.ListItemNhat.Event_1 += frmLogin.frmLogin_0.method_23;
											}
											else if (@class.string_0 == "BuffNameList")
											{
												frmLogin.class101_0.globalSettings_0.BuffNameList.Event_0 += frmLogin.frmLogin_0.method_19;
												frmLogin.class101_0.globalSettings_0.BuffNameList.Event_1 += frmLogin.frmLogin_0.method_20;
											}
											else if (@class.string_0 == "ListBuffPetID")
											{
												frmLogin.class101_0.globalSettings_0.ListBuffPetID.Event_0 += frmLogin.frmLogin_0.method_17;
												frmLogin.class101_0.globalSettings_0.ListBuffPetID.Event_1 += frmLogin.frmLogin_0.method_18;
											}
											else if (@class.string_0 == "ListLoginProfile")
											{
											}
										}
									}
									else if (property.PropertyType == typeof(Class210<GClass2>))
									{
										string[] array2 = @class.string_2.Split(new char[]
										{
											'|'
										});
										if (array2.Length != 0)
										{
											foreach (string text2 in array2)
											{
												if (!string.IsNullOrEmpty(text2))
												{
													string[] array4 = text2.Split(new char[]
													{
														';'
													});
													if (array4.Length > 6)
													{
														GClass2 gclass = new GClass2();
														gclass.Username = array4[0];
														string string_ = "";
														try
														{
															byte[] bytes = Convert.FromBase64String(array4[1]);
															string_ = Encoding.UTF8.GetString(bytes);
															goto IL_5B6;
														}
														catch (Exception)
														{
															goto IL_5B6;
														}
														goto IL_458;
														IL_470:
														frmLogin.class101_0.globalSettings_0.ListLoginProfile.method_1(gclass);
														goto IL_486;
														IL_5B6:
														string_ = Class83.smethod_73(string_, "%6fhru4?");
														gclass.secureString_0 = Class83.smethod_70(string_);
														gclass.String_0 = array4[2];
														gclass.Server = array4[3];
														gclass.MinorServer = array4[4];
														gclass.CharName = array4[5];
														gclass.GamePath = array4[6];
														if (array4.Length <= 7)
														{
															goto IL_470;
														}
														IL_458:
														int databaseID = 0;
														int.TryParse(array4[7], out databaseID);
														gclass.DatabaseID = databaseID;
														goto IL_470;
													}
												}
												IL_486:;
											}
										}
									}
									else
									{
										object obj = Convert.ChangeType(@class.string_2, propertyType);
										if (obj != null)
										{
											property.SetValue(frmLogin.class101_0.globalSettings_0, obj, null);
										}
									}
								}
								else if (property == null && @class.string_0 == "hotkey")
								{
									string[] array5 = @class.string_2.Split(new char[]
									{
										'|'
									});
									if (array5.Length != 0)
									{
										for (int k = 0; k < array5.Length; k++)
										{
											if (!string.IsNullOrEmpty(array5[k]) && array5[k].Contains(","))
											{
												string[] array6 = array5[k].Split(new char[]
												{
													','
												});
												if (array6.Length == 2)
												{
													int num = 0;
													int int_ = 0;
													int.TryParse(array6[0], out num);
													int.TryParse(array6[1], out int_);
													Class83.list_1[num - 1].int_1 = int_;
													Class83.list_1[num - 1].bool_0 = true;
													Class83.list_1[num - 1].bool_1 = true;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				catch (Exception)
				{
				}
				finally
				{
					if (sqliteConnection.State == ConnectionState.Open)
					{
						sqliteConnection.Close();
					}
				}
			}
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0009BF3C File Offset: 0x0009A13C
		internal static void smethod_7(Class58 class58_0)
		{
			string text = Class161.smethod_3(class58_0.class114_0.int_11);
			if (!string.IsNullOrEmpty(text) && Class161.smethod_0(text, true, ""))
			{
				Class162 @class = new Class162();
				Class57.Menpais menpais = Class57.Menpais.NOMENPAI;
				int num = 0;
				Class161.smethod_1(text, false, "savedMenpai", @class);
				if (@class.string_2 != "")
				{
					try
					{
						menpais = (Class57.Menpais)Enum.Parse(typeof(Class57.Menpais), @class.string_2);
						goto IL_83;
					}
					catch (Exception)
					{
						goto IL_83;
					}
				}
				menpais = class58_0.class114_0.Menpai;
				IL_83:
				@class = new Class162();
				Class161.smethod_1(text, false, "CharDBID", @class);
				if (@class.string_2 != "")
				{
					try
					{
						num = (int)Convert.ChangeType(@class.string_2, typeof(int));
						goto IL_D4;
					}
					catch (Exception)
					{
						goto IL_D4;
					}
				}
				num = class58_0.class114_0.int_11;
				IL_D4:
				SQLiteConnection sqliteConnection = null;
				if (File.Exists(frmLogin.class101_0.globalSettings_0.SettingDB))
				{
					sqliteConnection = new SQLiteConnection("Data Source=" + frmLogin.class101_0.globalSettings_0.SettingDB);
					sqliteConnection.Open();
				}
				try
				{
					if (sqliteConnection.State == ConnectionState.Open)
					{
						SQLiteDataReader reader = new SQLiteCommand(string.Format("SELECT * FROM '{0}';", text), sqliteConnection).ExecuteReader();
						DataTable dataTable = new DataTable();
						dataTable.Load(reader);
						if (dataTable.Rows.Count > 0)
						{
							Type typeFromHandle = typeof(AutoSettings);
							foreach (DataRow dataRow_ in dataTable.Rows)
							{
								Class162 class2 = new Class162();
								Class161.smethod_2(class2, dataRow_);
								PropertyInfo property = typeFromHandle.GetProperty(class2.string_0);
								if (class2.string_2.StartsWith("\\"))
								{
									class2.string_2 = class2.string_2.Remove(0, 1);
								}
								if (property != null)
								{
									Type propertyType = property.PropertyType;
									if (property.PropertyType == typeof(Class210<string>))
									{
										string[] array = class2.string_2.Split(new char[]
										{
											'|'
										});
										Class210<string> class3 = new Class210<string>();
										if (array.Length != 0)
										{
											for (int i = 0; i < array.Length; i++)
											{
												if (!string.IsNullOrEmpty(array[i]))
												{
													class3.method_1(array[i]);
												}
											}
											property.SetValue(class58_0.autoSettings_0, class3, null);
											if (class2.string_0 == "AutoPartyList")
											{
												class58_0.autoSettings_0.AutoPartyList.Event_0 += class58_0.method_75;
												class58_0.autoSettings_0.AutoPartyList.Event_1 += class58_0.method_70;
											}
											else if (class2.string_0 == "ListItemNhatIgnore")
											{
												class58_0.autoSettings_0.ListItemNhatIgnore.Event_0 += class58_0.method_76;
												class58_0.autoSettings_0.ListItemNhatIgnore.Event_1 += class58_0.method_77;
											}
											else if (class2.string_0 == "PTBlacklist")
											{
												class58_0.autoSettings_0.PTBlacklist.Event_0 += class58_0.method_74;
												class58_0.autoSettings_0.PTBlacklist.Event_1 += class58_0.method_73;
											}
											else if (class2.string_0 == "QuaiNoAttackList")
											{
												class58_0.autoSettings_0.QuaiNoAttackList.Event_0 += class58_0.method_72;
												class58_0.autoSettings_0.QuaiNoAttackList.Event_1 += class58_0.method_71;
											}
											else if (class2.string_0 == "PKPlayerList")
											{
												class58_0.autoSettings_0.PKPlayerList.Event_0 += class58_0.method_85;
												class58_0.autoSettings_0.PKPlayerList.Event_1 += class58_0.method_84;
											}
											else if (class2.string_0 == "PKBlackList")
											{
												class58_0.autoSettings_0.PKBlackList.Event_0 += class58_0.method_87;
												class58_0.autoSettings_0.PKBlackList.Event_1 += class58_0.method_86;
											}
											else if (class2.string_0 == "txtPassCap2")
											{
											}
										}
									}
									else if (property.PropertyType == typeof(Class210<int>))
									{
										string[] array2 = class2.string_2.Split(new char[]
										{
											'|'
										});
										Class210<int> class4 = new Class210<int>();
										int gparam_ = 0;
										if (array2.Length != 0)
										{
											for (int j = 0; j < array2.Length; j++)
											{
												if (!string.IsNullOrEmpty(array2[j]))
												{
													int.TryParse(array2[j], out gparam_);
													class4.method_1(gparam_);
												}
											}
											property.SetValue(class58_0.autoSettings_0, class4, null);
											if (class2.string_0 == "PKBangList")
											{
												class58_0.autoSettings_0.PKBangList.Event_0 += class58_0.method_83;
												class58_0.autoSettings_0.PKBangList.Event_1 += class58_0.method_82;
											}
										}
									}
									else if (property.PropertyType == typeof(Class210<Class106>))
									{
										Class210<Class106> class5 = new Class210<Class106>();
										foreach (string text2 in class2.string_2.Split(new char[]
										{
											'|'
										}))
										{
											if (!string.IsNullOrEmpty(text2))
											{
												string[] array4 = text2.Split(new char[]
												{
													';'
												});
												Class106 class6 = null;
												int num2 = 0;
												int int_ = 20;
												int.TryParse(array4[0], out num2);
												int.TryParse(array4[1], out int_);
												if (num2 != 0)
												{
													foreach (Class106 class7 in frmLogin.class101_0.globalSettings_0.ListItemToBuy)
													{
														if (class7.int_0 == num2)
														{
															class6 = new Class106();
															class6.int_4 = int_;
															class6.int_0 = class7.int_0;
															class6.string_0 = class7.string_0;
															class6.enum12_0 = class7.enum12_0;
															class6.int_5 = class7.int_5;
															class6.int_3 = class7.int_3;
															class6.int_1 = class7.int_1;
															class6.int_2 = class7.int_2;
															class6.int_6 = class7.int_6;
															break;
														}
													}
													if (class6 != null)
													{
														class5.method_1(class6);
													}
												}
											}
										}
										if (class5.Count > 0)
										{
											property.SetValue(class58_0.autoSettings_0, class5, null);
											if (class2.string_0 == "ListItemToBuy")
											{
												class58_0.autoSettings_0.ListItemToBuy.Event_0 += class58_0.method_95;
												class58_0.autoSettings_0.ListItemToBuy.Event_1 += class58_0.method_94;
											}
										}
									}
									else if (property.PropertyType == typeof(Class210<Class107>))
									{
										Class210<Class107> class8 = new Class210<Class107>();
										foreach (string text3 in class2.string_2.Split(new char[]
										{
											'|'
										}))
										{
											if (!string.IsNullOrEmpty(text3))
											{
												string[] array5 = text3.Split(new char[]
												{
													';'
												});
												Class107 class9 = new Class107();
												int int_2 = 30;
												class9.string_0 = array5[0];
												int.TryParse(array5[1], out int_2);
												class9.int_0 = int_2;
												if (class9.string_0 != "")
												{
													class8.method_1(class9);
												}
											}
										}
										if (class8.Count > 0)
										{
											property.SetValue(class58_0.autoSettings_0, class8, null);
											if (class2.string_0 == "ListItemToUse")
											{
												class58_0.autoSettings_0.ListItemToUse.Event_0 += class58_0.method_92;
												class58_0.autoSettings_0.ListItemToUse.Event_1 += class58_0.method_93;
											}
										}
									}
									else if (property.PropertyType == typeof(Class210<Class121>))
									{
										if (class58_0.class114_0.Menpai == menpais)
										{
											Class210<Class121> class10 = new Class210<Class121>();
											foreach (string text4 in class2.string_2.Split(new char[]
											{
												'|'
											}))
											{
												if (!string.IsNullOrEmpty(text4))
												{
													string[] array6 = text4.Split(new char[]
													{
														';'
													});
													Class121 class11 = new Class121();
													if (array6.Length >= 3)
													{
														int.TryParse(array6[2], out class11.int_0);
														Class124 class12 = new Class124();
														class12.string_0 = array6[1];
														int.TryParse(array6[0], out class12.int_0);
														class11.class124_0 = class12;
														if (frmLogin.class101_0.list_10.Count > 0 && class58_0.class75_0.bool_20)
														{
															for (int l = 0; l < frmLogin.class101_0.list_10.Count; l++)
															{
																if (frmLogin.class101_0.list_10[l].int_2 == class12.int_0)
																{
																	class12.int_10 = frmLogin.class101_0.list_10[l].int_9;
																	class12.int_2 = frmLogin.class101_0.list_10[l].int_1;
																	class12.int_11 = frmLogin.class101_0.list_10[l].int_6;
																	class12.int_5 = frmLogin.class101_0.list_10[l].int_3;
																	class12.int_1 = frmLogin.class101_0.list_10[l].int_0;
																	class12.int_10 = frmLogin.class101_0.list_10[l].int_9;
																	break;
																}
															}
														}
														class11.bool_1 = true;
														if (class2.string_0 == "SkillBuffList")
														{
															int.TryParse(array6[3], out class11.int_1);
															bool.TryParse(array6[4], out class11.bool_2);
															bool.TryParse(array6[5], out class11.bool_3);
															bool.TryParse(array6[6], out class11.bool_4);
															bool.TryParse(array6[7], out class11.bool_5);
															try
															{
																if (array6.Length >= 9)
																{
																	bool.TryParse(array6[8], out class11.bool_1);
																}
																goto IL_11BE;
															}
															catch (Exception)
															{
																goto IL_11BE;
															}
															goto IL_AB4;
														}
														goto IL_AB4;
														IL_B44:
														if (class11.int_0 != 0 && class12.int_0 != 0 && class12.string_0 != "")
														{
															class10.method_1(class11);
															goto IL_B72;
														}
														goto IL_B72;
														IL_11BE:
														if (class58_0.class120_0 != null)
														{
															goto IL_AD8;
														}
														goto IL_B44;
														IL_AB4:
														try
														{
															if (array6.Length >= 4)
															{
																bool.TryParse(array6[3], out class11.bool_1);
															}
															goto IL_11BE;
														}
														catch (Exception)
														{
															goto IL_11BE;
														}
														IL_AD8:
														for (int m = 1; m < class58_0.class120_0.list_4.Count; m++)
														{
															if (class11.class124_0.string_0 == class58_0.class120_0.list_4[m].string_0)
															{
																class11.class124_0.string_1 = class58_0.class120_0.list_4[m].string_1;
															}
														}
														goto IL_B44;
													}
												}
												IL_B72:;
											}
											if (class10.Count > 0)
											{
												property.SetValue(class58_0.autoSettings_0, class10, null);
												if (class2.string_0 == "SkillPlayList")
												{
													class58_0.autoSettings_0.SkillPlayList.Event_0 += class58_0.method_91;
													class58_0.autoSettings_0.SkillPlayList.Event_1 += class58_0.method_90;
												}
												else if (class2.string_0 == "SkillPKList")
												{
													class58_0.autoSettings_0.SkillPKList.Event_0 += class58_0.method_88;
													class58_0.autoSettings_0.SkillPKList.Event_1 += class58_0.method_89;
												}
												else if (class2.string_0 == "SkillBuffList")
												{
													class58_0.autoSettings_0.SkillBuffList.Event_0 += class58_0.method_79;
													class58_0.autoSettings_0.SkillBuffList.Event_1 += class58_0.method_78;
												}
											}
										}
									}
									else if (property.PropertyType == typeof(Class210<GClass1>))
									{
										Class210<GClass1> class13 = new Class210<GClass1>();
										foreach (string text5 in class2.string_2.Split(new char[]
										{
											'|'
										}))
										{
											if (!string.IsNullOrEmpty(text5))
											{
												string[] array7 = text5.Split(new char[]
												{
													';'
												});
												GClass1 gclass = new GClass1();
												gclass.string_0 = array7[1];
												string[] array8 = array7[0].Split(new char[]
												{
													':'
												});
												int.TryParse(array8[0], out gclass.int_0);
												int.TryParse(array8[1], out gclass.int_1);
												if (gclass.string_0 != "")
												{
													class13.method_1(gclass);
												}
											}
										}
										if (class13.Count > 0)
										{
											property.SetValue(class58_0.autoSettings_0, class13, null);
											if (class2.string_0 == "ListScheduler")
											{
												class58_0.autoSettings_0.ListScheduler.Event_0 += class58_0.method_81;
												class58_0.autoSettings_0.ListScheduler.Event_1 += class58_0.method_80;
											}
										}
										else
										{
											class58_0.autoSettings_0.ListScheduler = new Class210<GClass1>();
										}
									}
									else if (property.PropertyType == typeof(Class57.FightingModes))
									{
										property.SetValue(class58_0.autoSettings_0, (Class57.FightingModes)Enum.Parse(typeof(Class57.FightingModes), class2.string_2), null);
									}
									else if (property.PropertyType == typeof(Class57.NhatItemModes))
									{
										property.SetValue(class58_0.autoSettings_0, (Class57.NhatItemModes)Enum.Parse(typeof(Class57.NhatItemModes), class2.string_2), null);
									}
									else if (property.PropertyType == typeof(Class57.NgaMyBuffModes))
									{
										property.SetValue(class58_0.autoSettings_0, (Class57.NgaMyBuffModes)Enum.Parse(typeof(Class57.NgaMyBuffModes), class2.string_2), null);
									}
									else if (property.PropertyType == typeof(Class57.AIModes))
									{
										property.SetValue(class58_0.autoSettings_0, (Class57.AIModes)Enum.Parse(typeof(Class57.AIModes), class2.string_2), null);
									}
									else if (class2.string_0 == "PetAOEDBID" && num == class58_0.class114_0.int_11)
									{
										int num3 = 0;
										int.TryParse(class2.string_2, out num3);
										class58_0.autoSettings_0.PetAOEDBID = num3;
										int.TryParse(class2.list_0[0], out num3);
										class58_0.autoSettings_0.numPetAOE = num3;
										int.TryParse(class2.list_0[1], out num3);
										class58_0.autoSettings_0.PetAOESkillID = num3;
									}
									else if (class2.string_0 == "txtPassCap2")
									{
										if (class2.string_2 != "")
										{
											string text6 = "";
											try
											{
												byte[] bytes = Convert.FromBase64String(class2.string_2);
												text6 = Encoding.UTF8.GetString(bytes);
											}
											catch (Exception)
											{
											}
											text6 = Class83.smethod_73(text6, "8u43!29");
											text6 = text6.Replace("Peter", "");
											text6 = text6.Replace("mary", "");
											class58_0.autoSettings_0.txtPassCap2 = text6;
										}
									}
									else if (class2.string_0 == "AfterDeathSetting")
									{
										if (class2.string_2 == "ExitGame")
										{
											class58_0.autoSettings_0.AfterDeathSetting = Class57.Enum14.const_0;
										}
										else if (class2.string_2 == "HappyTea")
										{
											class58_0.autoSettings_0.AfterDeathSetting = Class57.Enum14.const_2;
										}
										else
										{
											class58_0.autoSettings_0.AfterDeathSetting = Class57.Enum14.const_1;
										}
									}
									else if (!(class2.string_0 == "savedMenpai") && !(class2.string_0 == "CharDBID") && ((!(class2.string_0 == "CenterX") && !(class2.string_0 == "CenterY") && !(class2.string_0 == "MapID")) || num == class58_0.class114_0.int_11))
									{
										object obj = Convert.ChangeType(class2.string_2, propertyType);
										if (obj != null)
										{
											property.SetValue(class58_0.autoSettings_0, obj, null);
										}
									}
								}
								else if (num == class58_0.class114_0.int_11)
								{
									if (class2.string_0 == "AlwaysActivePetName")
									{
										class58_0.class116_0.String_2 = class2.string_2;
									}
									else if (class2.string_0 == "HuyetTePetName")
									{
										class58_0.class116_0.String_0 = class2.string_2;
									}
									else if (class2.string_0 == "CongSinhPetName")
									{
										class58_0.class116_0.String_1 = class2.string_2;
									}
								}
							}
						}
						class58_0.autoSettings_0.savedMenpai = class58_0.class114_0.Menpai;
						class58_0.autoSettings_0.CharDBID = class58_0.class114_0.int_11;
					}
				}
				catch (Exception)
				{
				}
				finally
				{
					if (sqliteConnection.State == ConnectionState.Open)
					{
						sqliteConnection.Close();
					}
				}
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0009D250 File Offset: 0x0009B450
		internal static void smethod_8(string string_0, string string_1)
		{
			if (File.Exists(frmLogin.class101_0.globalSettings_0.SettingDB))
			{
				SQLiteConnection sqliteConnection = new SQLiteConnection("Data Source=" + frmLogin.class101_0.globalSettings_0.SettingDB);
				try
				{
					sqliteConnection.Open();
					string commandText = string.Format("DELETE FROM {0} WHERE key = '{1}'", string_0, string_1);
					if (sqliteConnection.State == ConnectionState.Open)
					{
						SQLiteCommand sqliteCommand = new SQLiteCommand(commandText, sqliteConnection);
						try
						{
							object object_ = frmLogin.object_6;
							lock (object_)
							{
								sqliteCommand.ExecuteNonQuery();
							}
						}
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
				finally
				{
					if (sqliteConnection.State == ConnectionState.Open)
					{
						sqliteConnection.Close();
					}
				}
			}
		}
	}
}
